using System.Buffers;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

public class WorkWithBase
{
    public static void CustomSort(Student[] students, string sortDirection, string param)
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
        int n = students.Length;
        if (n == 0) return;
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
                    Student tmp = students[j];
                    students[j] = students[j + 1];
                    students[j + 1] = tmp;
                }
            }
        }
    }

    public static Func<Student, object> GetPropertySelector(string propertyName)
    {
        return propertyName switch
        {
            "ФИО студента" => s => s.FullName,
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
        if (students == null)
            return new Student[0];
        double value = Convert.ToDouble(searchValue);
        var propertySelector = GetPropertySelector(param);
        List<Student> result = new List<Student>();

        for(int i = 0; i <  students.Length; i++)
        {
            double studentValue = Convert.ToDouble(propertySelector(students[i]));
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
                result.Add(students[i]);
            }
        }
        var resultArray = result.ToArray();
        return resultArray;
    }
    public static Student[] FilterString(Student[] students, string searchString)
    {
        if (students == null)
            return new Student[0];
        var propertySelector = GetPropertySelector("ФИО студента");
        List<Student> result = new List<Student>();
        for (int i = 0; i < students.Length; i++)
        {
            string studentName = Convert.ToString(propertySelector(students[i]));
            bool matches = ContainsSubstring(studentName, searchString);

            if (matches)
            {
                result.Add(students[i]);
            }
        }
        var resultArray = result.ToArray();
        return resultArray;
    }
    private static bool ContainsSubstring(string text, string substring)
    {
        if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(substring))
            return string.IsNullOrEmpty(substring) && !string.IsNullOrEmpty(text);

        string lowerText = text.ToLower();
        string lowerSubstring = substring.ToLower();

        int textLength = lowerText.Length;
        int subLength = lowerSubstring.Length;

        if (subLength > textLength)
            return false;

        for (int i = 0; i <= textLength - subLength; i++)
        {
            bool isMatch = true;
            for (int j = 0; j < subLength; j++)
            {
                if (lowerText[i + j] != lowerSubstring[j])
                {
                    isMatch = false;
                    break;
                }
            }
            if (isMatch)
                return true;
        }

        return false;
    }
    public static Dictionary<string, Student[]> Group(Student[] students, string param)
    {
        if (students == null)
            return new Dictionary<string, Student[]>();

        var keySelector = GetGroupKeySelector(param);
        var result = new Dictionary<string, List<Student>>();

        for (int i = 0; i < students.Length; i++)
        {
            string key = keySelector(students[i]);

            if (!result.ContainsKey(key))
            {
                result[key] = new List<Student>();
            }

            result[key].Add(students[i]); 
        }

        // Преобразование в Dictionary<string, Student[]>
        var resultArray = new Dictionary<string, Student[]>();
        foreach (var kvp in result)
        {
            resultArray[kvp.Key] = kvp.Value.ToArray(); 
        }

        return resultArray;
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