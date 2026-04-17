using System.Data;

public class CalculateStatisticalIndicators
{
    public static double CalculateAverage(List<Student> students, string columnText)
    {
        var selector = WorkWithBase.GetPropertySelector(columnText);
        return Math.Round(students.Average(s => (double)selector(s)), 2);
    }

    public static double CalculateMedian(List<Student> students, string columnText)
    {
        var selector = WorkWithBase.GetPropertySelector(columnText);
        var values = students.Select(s => (double)selector(s)).OrderBy(v => v).ToList();
        int count = values.Count;
        return count % 2 == 1
            ? values[count / 2]
            : (values[count / 2 - 1] + values[count / 2]) / 2.0;
    }

    public static (double Min, double Max) CalculateMinMax(List<Student> students, string columnText)
    {
        var selector = WorkWithBase.GetPropertySelector(columnText);
        var values = students.Select(s => (double)selector(s));
        return (values.Min(), values.Max());
    }
}
