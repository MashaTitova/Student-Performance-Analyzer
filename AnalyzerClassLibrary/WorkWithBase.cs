using System.Buffers;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

public class WorkWithBase
{
	public static void CustomSort(ref Student[] students, string sortDirection, string param)
	{
		// Проверки входных параметров
		if (students == null)
			throw new ArgumentNullException(nameof(students));
		if (string.IsNullOrEmpty(sortDirection))
			throw new ArgumentException("Направление сортировки не указано");
		if (string.IsNullOrEmpty(param))
			throw new ArgumentException("Параметр сортировки не указан");

		// Получаем селектор для выбранного параметра
		var selector = GetPropertySelector(param);

		// Создаём новый отсортированный массив
		var sortedList = sortDirection == "Возрастание"
			? students.OrderBy(selector).ToArray()
			: students.OrderByDescending(selector).ToArray();

		// Переприсваиваем массив
		students = sortedList;
	}

	public static Func<Student, object> GetPropertySelector(string propertyName)
    {
        return propertyName switch
        {
            "Физика" => s => s.Physics,
            "Английский язык" => s => s.English,
            "История" => s => s.History,
            "Физическая культура" => s => s.PhysicalEducation,
            "Культурология" => s => s.CulturalStudies,
            "Информатика" => s => s.Informatics,
            "Психология" => s => s.Psychology,
            "Математика" => s => s.Mathematics,
            "Биология" => s => s.Biology,
            "Химия" => s => s.Chemistry,
            "Кол-во задолженностей" => s => s.DebtCount,
            _ => s => s.AverageGrade
        };
    }

	public static Student[] FilterNums(Student[] students, string searchValue, string param, string ratio)
	{
		double value = Convert.ToDouble(searchValue);
		var propertySelector = GetPropertySelector(param);

		return ratio switch
		{
			">" => students.Where(s => Convert.ToDouble(propertySelector(s)) > value).ToArray(),
			"<" => students.Where(s => Convert.ToDouble(propertySelector(s)) < value).ToArray(),
			"<=" => students.Where(s => Convert.ToDouble(propertySelector(s)) <= value).ToArray(),
			">=" => students.Where(s => Convert.ToDouble(propertySelector(s)) >= value).ToArray(),
			"=" => students.Where(s => Math.Abs(Convert.ToDouble(propertySelector(s)) - value) < 0.001).ToArray(),
			_ => students
		};
	}
	public static Dictionary<string, Student[]> Group(Student[] students, string param)
	{
		return students
			.GroupBy(GetGroupKeySelector(param))
			.ToDictionary(g => g.Key, g => g.ToArray());
	}

	public static Func<Student, string> GetGroupKeySelector(string propertyName)
	{
		return propertyName switch
		{
			"Курс" => s => s.Course.ToString(),
			"Группа" => s => s.Group,
			_ => s => "Другое"
		};
	}
}


