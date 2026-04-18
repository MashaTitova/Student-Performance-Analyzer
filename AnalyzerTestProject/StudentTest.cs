using System.Collections.Generic;
using Xunit;

public class StudentTests
{
    [Fact]
    public void Student_Constructor_InitializesPropertiesCorrectly()
    {
        // Arrange
        var student = new Student
        {
            ID = 1,
            FullName = "Иванов Иван Иванович",
            Course = 2,
            Group = "ИТ-21",
            Physics = 4.5,
            English = 5.0,
            History = 3.0,
            PhysicalEducation = 4.0,
            CulturalStudies = 4.5,
            Informatics = 5.0,
            Psychology = 4.0,
            Mathematics = 3.5,
            Biology = 4.0,
            Chemistry = 4.5,
            AverageGrade = 4.2,
            DebtCount = 1
        };

        // Assert
        Assert.Equal(1, student.ID);
        Assert.Equal("Иванов Иван Иванович", student.FullName);
        Assert.Equal(2, student.Course);
        Assert.Equal("ИТ-21", student.Group);
        Assert.Equal(4.5, student.Physics);
        Assert.Equal(5.0, student.English);
        Assert.Equal(3.0, student.History);
        Assert.Equal(4.0, student.PhysicalEducation);
        Assert.Equal(4.5, student.CulturalStudies);
        Assert.Equal(5.0, student.Informatics);
        Assert.Equal(4.0, student.Psychology);
        Assert.Equal(3.5, student.Mathematics);
        Assert.Equal(4.0, student.Biology);
        Assert.Equal(4.5, student.Chemistry);
        Assert.Equal(4.2, student.AverageGrade);
        Assert.Equal(1, student.DebtCount);
    }

}