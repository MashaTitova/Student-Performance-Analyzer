using System.Data;

public class CalculateStatisticalIndicators
{
	public static double CalculateAverage(Student[] students, string columnText)
	{
		var selector = WorkWithBase.GetPropertySelector(columnText);
		return Math.Round(students.Average(s => (double)selector(s)), 2);
	}

	public static double CalculateMedian(Student[] students, string columnText)
	{
		var selector = WorkWithBase.GetPropertySelector(columnText);
		var values = students.Select(s => (double)selector(s)).OrderBy(v => v).ToArray();
		int count = values.Length;
		return Math.Round(count % 2 == 1
			? values[count / 2]
			: (values[count / 2 - 1] + values[count / 2]) / 2.0, 2);
	}

	public static (double Min, double Max) CalculateMinMax(Student[] students, string columnText)
	{
		var selector = WorkWithBase.GetPropertySelector(columnText);
		var values = students.Select(s => (double)selector(s)).ToArray();
		return (values.Min(), values.Max());
	}
}
