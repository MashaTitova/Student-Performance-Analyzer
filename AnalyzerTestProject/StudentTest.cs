public class StudentTests
{
    [Fact]
    public void Student_Constructor_InitializesPropertiesCorrectly()
    {
        int id = 1;
        string fullName = "Иванов И.И.";
        int course = 2;
        string group = "Гр-101";
        double physics = 4.5;
        double english = 5.0;
        double history = 3.8;
        double physicalEducation = 4.2;
        double culturalStudies = 4.0;
        double informatics = 4.8;
        double psychology = 4.3;
        double mathematics = 4.7;
        double biology = 4.1;
        double chemistry = 4.6;
        double averageGrade = 4.4;
        int debtCount = 0;

        var student = new Student
        (
            id,
            fullName,
            course,
            group,
            physics,
            english,
            history,
            physicalEducation,
            culturalStudies,
            informatics,
            psychology,
            mathematics,
            biology,
            chemistry,
            averageGrade,
            debtCount
        );

        Assert.Equal(id, student.ID);
        Assert.Equal(fullName, student.FullName);
        Assert.Equal(course, student.Course);
        Assert.Equal(group, student.Group);
        Assert.Equal(physics, student.Physics);
        Assert.Equal(english, student.English);
        Assert.Equal(history, student.History);
        Assert.Equal(physicalEducation, student.PhysicalEducation);
        Assert.Equal(culturalStudies, student.CulturalStudies);
        Assert.Equal(informatics, student.Informatics);
        Assert.Equal(psychology, student.Psychology);
        Assert.Equal(mathematics, student.Mathematics);
        Assert.Equal(biology, student.Biology);
        Assert.Equal(chemistry, student.Chemistry);
        Assert.Equal(averageGrade, student.AverageGrade);
        Assert.Equal(debtCount, student.DebtCount);
    }
}