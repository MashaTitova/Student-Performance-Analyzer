using System.Collections.Generic;
using Xunit;

public class CalculateStatisticalIndicatorsTests
{
    private List<Student> sampleStudents;
    private List<Student> singleStudent;
    private List<Student> emptyStudents;

    public CalculateStatisticalIndicatorsTests()
    {
        sampleStudents = new List<Student>
        {
            new Student { ID = 1, Physics = 4.0, English = 5.0, Mathematics = 3.0, AverageGrade = 4.0 },
            new Student { ID = 2, Physics = 3.0, English = 4.0, Mathematics = 4.0, AverageGrade = 3.5 },
            new Student { ID = 3, Physics = 5.0, English = 3.0, Mathematics = 5.0, AverageGrade = 4.5 },
            new Student { ID = 4, Physics = 4.0, English = 4.0, Mathematics = 4.0, AverageGrade = 4.0 }
        };

        singleStudent = new List<Student>
        {
            new Student { ID = 1, Physics = 4.5, English = 3.8, Mathematics = 4.2, AverageGrade = 4.1 }
        };

        emptyStudents = new List<Student>();
    }

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
    [Fact]
    public void CalculateAverage_EmptyList_ThrowsInvalidOperationException()
    {
        var exception = Assert.Throws<InvalidOperationException>(() =>
            CalculateStatisticalIndicators.CalculateAverage(emptyStudents, "Physics"));

        Assert.Contains("Sequence contains no elements", exception.Message);
    }

    [Theory]
    [InlineData("Physics", 4.0)]  
    [InlineData("English", 4.0)]   
    [InlineData("Mathematics", 4.0)] 
    public void CalculateMedian_EvenCount_ReturnsAverageOfMiddleValues(string column, double expected)
    {
        double result = CalculateStatisticalIndicators.CalculateMedian(sampleStudents, column);

        Assert.Equal(expected, result);
    }
    [Fact]
    public void CalculateMinMax_SingleStudent_ReturnsSameValueForMinAndMax()
    {
        var (min, max) = CalculateStatisticalIndicators.CalculateMinMax(singleStudent, "AverageGrade");

        Assert.Equal(4.1, min);
        Assert.Equal(4.1, max);
    }

    [Fact]
    public void CalculateMinMax_EmptyList_ThrowsInvalidOperationException()
    {
        var exception = Assert.Throws<InvalidOperationException>(() =>
            CalculateStatisticalIndicators.CalculateMinMax(emptyStudents, "Physics"));

        Assert.Contains("Sequence contains no elements", exception.Message);
    }
}
