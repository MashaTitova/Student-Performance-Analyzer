using Xunit;
using System.Linq;

public class CalculateStatisticalIndicatorsTests
{
    private Student[] GetTestStudents()
    {
        return new Student[]
        {
            new Student(1, "Иванов И.И.", 2, "Гр-101", 4.5, 5.0, 3.8, 4.2, 4.0, 4.8, 4.3, 4.7, 4.1, 4.6, 4.4, 0),
            new Student(2, "Петров П.П.", 2, "Гр-101", 3.5, 4.0, 3.2, 3.8, 3.9, 3.7, 3.6, 3.9, 3.4, 3.7, 3.7, 1),
            new Student(3, "Сидоров С.С.", 3, "Гр-102", 5.0, 5.0, 4.9, 5.0, 4.8, 5.0, 4.9, 5.0, 4.9, 5.0, 4.9, 0),
            new Student(4, "Козлова К.К.", 3, "Гр-102", 4.0, 4.2, 4.1, 4.3, 4.4, 4.0, 4.5, 4.1, 4.2, 4.3, 4.2, 0)
        };
    }

    [Fact]
    public void CalculateAverage_ReturnsCorrectAverageForPhysics()
    {
        var students = GetTestStudents();
        string columnText = nameof(Student.Physics);

        var average = CalculateStatisticalIndicators.CalculateAverage(students, columnText);

        Assert.Equal(4.3, average);
    }

    [Fact]
    public void CalculateAverage_ReturnsCorrectAverageForMathematics()
    {
        var students = GetTestStudents();
        string columnText = nameof(Student.Mathematics);

        var average = CalculateStatisticalIndicators.CalculateAverage(students, columnText);

        Assert.Equal(4.30, average);
    }

    [Fact]
    public void CalculateMedian_ReturnsCorrectMedianForEnglish()
    {

        var students = GetTestStudents();
        string columnText = nameof(Student.English);

        var median = CalculateStatisticalIndicators.CalculateMedian(students, columnText);


        Assert.Equal(4.3, median);
    }
    [Fact]
    public void CalculateMedian_ReturnsCorrectMedianForMath()
    {

        var students = GetTestStudents();
        string columnText = nameof(Student.Mathematics);

        var median = CalculateStatisticalIndicators.CalculateMedian(students, columnText);


        Assert.Equal(4.3, median);
    }

    [Fact]
    public void CalculateMinMax_ReturnsCorrectMinMaxForPhysics()
    {
        // Arrange
        var students = GetTestStudents();
        string columnText = nameof(Student.Physics);

        // Act
        var (min, max) = CalculateStatisticalIndicators.CalculateMinMax(students, columnText);

        // Assert
        Assert.Equal(3.7, min); 
        Assert.Equal(4.9, max); 
    }

    [Fact]
    public void CalculateMinMax_ReturnsCorrectMinMaxForMathematics()
    {
        // Arrange
        var students = GetTestStudents();
        string columnText = nameof(Student.Mathematics);

        // Act
        var (min, max) = CalculateStatisticalIndicators.CalculateMinMax(students, columnText);

        // Assert
        Assert.Equal(3.7, min); 
        Assert.Equal(4.9, max);
    }
}