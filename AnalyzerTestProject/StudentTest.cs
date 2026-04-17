
public class StudentTests
{
    [Fact]
    public void Student_Properties_SetAndGetCorrectly()
    {
        var student = new Student();

        student.ID = 1;
        student.FullName = "Иванов Иван Иванович";
        student.Course = 2;
        student.Group = "ИСФ-21";
        student.Physics = 4.5;
        student.English = 3.8;
        student.History = 4.2;
        student.PhysicalEducation = 5.0;
        student.CulturalStudies = 4.0;
        student.Informatics = 4.7;
        student.Psychology = 3.9;
        student.Mathematics = 4.3;
        student.Biology = 4.1;
        student.Chemistry = 4.6;
        student.AverageGrade = 4.35;
        student.DebtCount = 0;

        Assert.Equal(1, student.ID);
        Assert.Equal("Иванов Иван Иванович", student.FullName);
        Assert.Equal(2, student.Course);
        Assert.Equal("ИСФ-21", student.Group);
        Assert.Equal(4.5, student.Physics);
        Assert.Equal(3.8, student.English);
        Assert.Equal(4.2, student.History);
        Assert.Equal(5.0, student.PhysicalEducation);
        Assert.Equal(4.0, student.CulturalStudies);
        Assert.Equal(4.7, student.Informatics);
        Assert.Equal(3.9, student.Psychology);
        Assert.Equal(4.3, student.Mathematics);
        Assert.Equal(4.1, student.Biology);
        Assert.Equal(4.6, student.Chemistry);
        Assert.Equal(4.35, student.AverageGrade);
        Assert.Equal(0, student.DebtCount);
    }

    [Fact]
    public void Student_Constructor_InitializesWithDefaultValues()
    {
        var student = new Student();

        Assert.Equal(0, student.ID);
        Assert.Null(student.FullName);
        Assert.Equal(0, student.Course);
        Assert.Null(student.Group);
        Assert.Equal(0.0, student.Physics);
        Assert.Equal(0.0, student.English);
        Assert.Equal(0.0, student.History);
        Assert.Equal(0.0, student.PhysicalEducation);
        Assert.Equal(0.0, student.CulturalStudies);
        Assert.Equal(0.0, student.Informatics);
        Assert.Equal(0.0, student.Psychology);
        Assert.Equal(0.0, student.Mathematics);
        Assert.Equal(0.0, student.Biology);
        Assert.Equal(0.0, student.Chemistry);
        Assert.Equal(0.0, student.AverageGrade);
        Assert.Equal(0, student.DebtCount);
    }


    [Theory]
    [InlineData(0.0)]
    [InlineData(2.5)]
    [InlineData(4.8)]
    [InlineData(5.0)]
    public void Student_GradeProperties_AcceptValidValues(double grade)
    {
 
        var student = new Student();

 
        student.Physics = grade;
        student.English = grade;
        student.Mathematics = grade;

        // Assert
        Assert.Equal(grade, student.Physics);
        Assert.Equal(grade, student.English);
        Assert.Equal(grade, student.Mathematics);
    }

    [Theory]
    [InlineData(double.NaN)]
    [InlineData(double.PositiveInfinity)]
    [InlineData(double.NegativeInfinity)]
    public void Student_GradeProperties_HandleSpecialDoubleValues(double specialValue)
    {
        var student = new Student();

        student.Physics = specialValue;
 
        Assert.Equal(specialValue, student.Physics);
    }

    [Fact]
    public void Student_InCollection_WorksCorrectly()
    {
        var students = new List<Student>
        {
            new Student { ID = 1, FullName = "Иванов И.И.", Course = 2, Group = "ИС-21" },
            new Student { ID = 2, FullName = "Петров П.П.", Course = 2, Group = "ИС-21" },
            new Student { ID = 3, FullName = "Сидоров С.С.", Course = 3, Group = "ИС-31" }
        };

        var filtered = students.Where(s => s.Course == 2).ToList();

        Assert.Equal(2, filtered.Count);
        Assert.Contains(filtered, s => s.ID == 1);
        Assert.Contains(filtered, s => s.ID == 2);
    }

    [Fact]
    public void Student_Equality_ReferenceEquality()
    {
        var student1 = new Student { ID = 1, FullName = "Иванов И.И." };
        var student2 = new Student { ID = 1, FullName = "Иванов И.И." };
        var student3 = student1;

        Assert.False(student1.Equals(student2)); 
        Assert.True(student1.Equals(student3));  
    }

}
