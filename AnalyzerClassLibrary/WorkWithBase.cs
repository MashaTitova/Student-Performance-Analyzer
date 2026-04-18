using System.Buffers;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

public class WorkWithBase
{
    public static void CustomSort(List<Student> students, string sortDirection, string param)
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

        // Сортировка пузырьком
        int n = students.Count;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                double currentValue = Convert.ToDouble(selector(students[j]));
                double nextValue = Convert.ToDouble(selector(students[j + 1]));

                bool shouldSwap = sortDirection == "Возрастание"
                    ? currentValue > nextValue
                    : currentValue < nextValue;

                if (shouldSwap)
                {
                    // Обмен элементов
                    Student temp = students[j];
                    students[j] = students[j + 1];
                    students[j + 1] = temp;
                }
            }
        }
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

    static List<Student> FilterNums(List<Student> students, string searchValue, string param, string ratio)
    {
        double value = Convert.ToDouble(searchValue);
        var propertySelector = GetPropertySelector(param);
        List<Student> result = new List<Student>();

        foreach (var student in students)
        {
            double studentValue = Convert.ToDouble(propertySelector(student));
            bool matches = ratio switch
            {
                ">" => studentValue > value,
                "<" => studentValue < value,
                "<=" => studentValue <= value,
                ">=" => studentValue >= value,
                "=" => Math.Abs(studentValue - value) < 0.001,
                _ => true
            };

            if (matches)
            {
                result.Add(student);
            }
        }

        return result;
    }
    static Dictionary<string, List<Student>> Group(List<Student> students, string param)
    {
        var keySelector = GetGroupKeySelector(param);
        Dictionary<string, List<Student>> result = new Dictionary<string, List<Student>>();

        foreach (var student in students)
        {
            string key = keySelector(student);

            // Если ключ уже существует, добавляем в существующий список
            if (result.ContainsKey(key))
            {
                result[key].Add(student);
            }
            else
            {
                // Создаём новый список для этого ключа
                result[key] = new List<Student> { student };
            }
        }

        return result;
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