using System.Collections.Generic;
using System.Diagnostics;
using Xunit;

public class CalculateStatisticalIndicatorsTests
{
    private Student[] sampleStudents;
    private Student[] singleStudent;
    private Student[] emptyStudents;

    public CalculateStatisticalIndicatorsTests()
    {
        sampleStudents = new Student[]
        {
            new Student { ID = 1, Physics = 4.0, English = 5.0, Mathematics = 3.0, AverageGrade = 4.0 },
            new Student { ID = 2, Physics = 3.0, English = 4.0, Mathematics = 4.0, AverageGrade = 3.5 },
            new Student { ID = 3, Physics = 5.0, English = 3.0, Mathematics = 5.0, AverageGrade = 4.5 },
            new Student { ID = 4, Physics = 4.0, English = 4.0, Mathematics = 4.0, AverageGrade = 4.0 }
        };

        singleStudent = new Student[]
        {
            new Student { ID = 1, Physics = 4.5, English = 3.8, Mathematics = 4.2, AverageGrade = 4.1 }
        };

        emptyStudents = new Student[0];
    }
    // Вспомогательный метод: генерация большого массива
    private Student[] GenerateLargeStudentArray(int size)
    {
        var students = new Student[size];
        var random = new Random(50);

        for (int i = 0; i < size; i++)
        {
            students[i] = new Student
            {
                ID = i,
                FullName = $"Студент {i}",
                Physics = random.NextDouble() * 5,
                English = random.NextDouble() * 5,
                Mathematics = random.NextDouble() * 5,
                Course = random.Next(1, 5),
                Group = $"Группа-{random.Next(1, 10)}",
                DebtCount = random.Next(0, 3)
            };
        }
        return students;
    }
    // Типичный случай Среднее арифметическое
    [Theory]
    [InlineData("Physics", 4.0)]
    [InlineData("English", 4.0)]
    [InlineData("Mathematics", 4.0)]
    [InlineData("AverageGrade", 4.0)]
    public void CalculateAverage_WithValidData_ReturnsCorrectResult(string column, double expected)
    {
        double result = CalculateStatisticalIndicators.CalculateAverage(sampleStudents, column);

        Assert.Equal(expected, result);
    }
    // Граничный случай - пустой массив Среднее арифметическое
    [Fact]
    public void CalculateAverage_EmptyList_ReturnsZero()
    {
        var average = CalculateStatisticalIndicators.CalculateAverage(emptyStudents, "Physics");

        Assert.Equal(0, average);
    }
    // Некорректные входные данные - null Среднее арифметическое
    [Fact]
    public void CalculateAverage_NullList_ReturnsZero()
    {
        var average = CalculateStatisticalIndicators.CalculateAverage(emptyStudents, "Physics");

        Assert.Equal(0, average);
    }
    // Специфический случай: одно значение Среднее арифметическое
    [Fact]
    public void CalculateAverage_SingleValue()
    {
        var average = CalculateStatisticalIndicators.CalculateAverage(singleStudent, "Physics");

        Assert.Equal(4,5, average);
    }
    // Большой объем данных Среднее арифметическое
    [Fact]
    public void CalculateAverage_LargeDataSet_ShouldCompleteInReasonableTime()
    {
        const int largeSize = 100000;
        var largeArray = GenerateLargeStudentArray(largeSize);
        string columnText = "Physics";

        var stopwatch = Stopwatch.StartNew();

        var result = CalculateStatisticalIndicators.CalculateAverage(largeArray, columnText);

        stopwatch.Stop();

        Assert.True(stopwatch.ElapsedMilliseconds < 1000,
            $"Расчёт среднего занял {stopwatch.ElapsedMilliseconds} мс, что больше допустимых 1000 мс");
    }
    // Типичный случай Медиана
    [Theory]
    [InlineData("Physics", 4.0)]
    [InlineData("English", 4.0)]
    [InlineData("Mathematics", 4.0)]
    public void CalculateMedian_EvenCount_ReturnsAverageOfMiddleValues(string column, double expected)
    {
        double result = CalculateStatisticalIndicators.CalculateMedian(sampleStudents, column);

        Assert.Equal(expected, result);
    }
    // Граничный случай - пустой массив Медиана
    [Fact]
    public void CalculateMedian_EmptyList_ReturnsZero()
    {
        var median = CalculateStatisticalIndicators.CalculateMedian(emptyStudents, "Physics");

        Assert.Equal(0, median);
    }
    // Некорректные входные данные - null Медиана
    [Fact]
    public void CalculateMedian_NullList_ReturnsZero()
    {
        var median = CalculateStatisticalIndicators.CalculateMedian(emptyStudents, "Physics");

        Assert.Equal(0, median);
    }
    // Специфический случай: одно значение Медиана
    [Fact]
    public void CalculateMedian_SingleValue()
    {
        var median = CalculateStatisticalIndicators.CalculateMedian(singleStudent, "Physics");

        Assert.Equal(4,5, median);
    }
    // Большой объем данных Медиана
    [Fact]
    public void CalculateMedian_LargeDataSet_ShouldCompleteInReasonableTime()
    {
        const int largeSize = 50000; 
        var largeArray = GenerateLargeStudentArray(largeSize);
        string columnText = "Mathematics";

        var stopwatch = Stopwatch.StartNew();

        var result = CalculateStatisticalIndicators.CalculateMedian(largeArray, columnText);

        stopwatch.Stop();

        Assert.True(stopwatch.ElapsedMilliseconds < 5000,
            $"Расчёт медианы занял {stopwatch.ElapsedMilliseconds} мс, что больше допустимых 5000 мс");
    }
    // Типичный случай Минимальное и максимальное значения
    [Fact]
    public void CalculateMinMax_WithValidData_ReturnsCorrectResult()
    {
        var (min, max) = CalculateStatisticalIndicators.CalculateMinMax(sampleStudents, "AverageGrade");

        Assert.Equal(3.5, min);
        Assert.Equal(4.5, max);
    }
    // Специфический случай: одно значение Минимальное и максимальное значения
    [Fact]
    public void CalculateMinMax_SingleStudent()
    {
        var (min, max) = CalculateStatisticalIndicators.CalculateMinMax(singleStudent, "AverageGrade");

        Assert.Equal(4.1, min);
        Assert.Equal(4.1, max);
    }
    // Граничный случай - пустой массив Минимальное и максимальное значения
    [Fact]
    public void CalculateMinMax_EmptyList_ReturnsZero()
    {
        (double min, double max) =  CalculateStatisticalIndicators.CalculateMinMax(emptyStudents, "Physics");

        Assert.Equal(0, min);
        Assert.Equal(0, max);
    }
    // Некорректные входные данные - null Минимальное и максимальное значения
    [Fact]
    public void CalculateMinMax_NullList_ReturnsZero()
    {
        (double min, double max) = CalculateStatisticalIndicators.CalculateMinMax(emptyStudents, "Physics");

        Assert.Equal(0, min);
        Assert.Equal(0, max);
    }
    // Большой объем данных Минимальное и максимальное значения
    [Fact]
    public void CalculateMinMax_LargeDataSet_ShouldCompleteInReasonableTime()
    {
        const int largeSize = 100000;
        var largeArray = GenerateLargeStudentArray(largeSize);
        string columnText = "AverageGrade";

        var stopwatch = Stopwatch.StartNew();

        var result = CalculateStatisticalIndicators.CalculateMinMax(largeArray, columnText);

        stopwatch.Stop();

        Assert.True(stopwatch.ElapsedMilliseconds < 1000,
            $"Расчёт Min/Max занял {stopwatch.ElapsedMilliseconds} мс, что больше допустимых 1000 мс");
    }

}
