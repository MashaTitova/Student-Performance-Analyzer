using System.Data;

public class CalculateStatisticalIndicators
{
    public static double CalculateAverage(List<Student> students, string columnText)
    {
        var selector = WorkWithBase.GetPropertySelector(columnText);

        double sum = 0;
        int count = 0;

        foreach (var student in students)
        {
            sum += (double)selector(student);
            count++;
        }

        if (count == 0)
            return 0; // или выбросить исключение

        return Math.Round(sum / count, 2);
    }

    public static double CalculateMedian(List<Student> students, string columnText)
    {
        var selector = WorkWithBase.GetPropertySelector(columnText);

        // Получаем все значения
        List<double> values = new List<double>();
        foreach (var student in students)
        {
            values.Add((double)selector(student));
        }

        int n = values.Count;
        if (n == 0) return 0;

        // Сортировка пузырьком (вместо OrderBy)
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (values[j] > values[j + 1])
                {
                    // Обмен элементов
                    double temp = values[j];
                    values[j] = values[j + 1];
                    values[j + 1] = temp;
                }
            }
        }

        // Расчёт медианы
        if (n % 2 == 1)
        {
            // Нечётное количество: берём средний элемент
            return values[n / 2];
        }
        else
        {
            // Чётное количество: среднее двух центральных элементов
            int mid1 = n / 2 - 1;
            int mid2 = n / 2;
            return (values[mid1] + values[mid2]) / 2.0;
        }
    }

    static (double Min, double Max) CalculateMinMax(List<Student> students, string columnText)
    {
        var selector = WorkWithBase.GetPropertySelector(columnText);

        if (students.Count == 0)
            return (0, 0); // или выбросить исключение

        // Инициализируем min и max первым элементом
        double firstValue = (double)selector(students[0]);
        double min = firstValue;
        double max = firstValue;

        // Проходим по остальным элементам
        for (int i = 1; i < students.Count; i++)
        {
            double currentValue = (double)selector(students[i]);

            if (currentValue < min)
                min = currentValue;

            if (currentValue > max)
                max = currentValue;
        }

        return (min, max);
    }
}