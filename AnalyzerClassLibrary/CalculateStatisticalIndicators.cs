using System.Data;

public class CalculateStatisticalIndicators
{
    public static double CalculateAverage(Student[] students, string columnText)
    {
        if (students.Length == 0)
            return 0;
        var selector = WorkWithBase.GetPropertySelector(columnText);

        double sum = 0;
        int count = 0;

        foreach (var student in students)
        {
            sum += (double)selector(student);
            count++;
        }

        if (count == 0)
            return 0;

        return Math.Round(sum / count, 2);

       
    }

    public static double CalculateMedian(Student[] students, string columnText)
    {
        if (students.Length == 0)
            return 0;
        var selector = WorkWithBase.GetPropertySelector(columnText);

        double [] values = new double[students.Length];
        for(int i  = 0; i < students.Length; i++)
        {
            values[i] = (double)selector(students[i]);
        }

        int n = values.Length;
        if (n == 0) return 0;

        // Сортировка пузырьком 
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (values[j] > values[j + 1])
                {
                    double tmp = values[j];
                    values[j] = values[j + 1];
                    values[j + 1] = tmp;
                }
            }
        }

        // Расчёт медианы
        if (n % 2 == 1)
        {
            return values[n / 2];
        }
        else
        {
            int mid1 = n / 2 - 1;
            int mid2 = n / 2;
            return (values[mid1] + values[mid2]) / 2.0;
        }
    }

    public static (double Min, double Max) CalculateMinMax(Student[] students, string columnText)
    {
        var selector = WorkWithBase.GetPropertySelector(columnText);

        if (students.Length == 0)
            return (0, 0); 

        double firstValue = (double)selector(students[0]);
        double min = firstValue;
        double max = firstValue;

        for (int i = 1; i < students.Length; i++)
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