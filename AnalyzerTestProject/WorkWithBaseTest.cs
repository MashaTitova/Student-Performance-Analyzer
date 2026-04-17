public class WorkWithBaseTests
{
    private List<Student> testStudents;

    public WorkWithBaseTests()
    {
        testStudents = new List<Student>
        {
            new Student { ID = 1, FullName = "Иванов И.И.", Physics = 4.5, English = 3.0, Mathematics = 5.0, Course = 2, Group = "ИСФ-21", DebtCount = 0 },
            new Student { ID = 2, FullName = "Петров П.П.", Physics = 3.5, English = 4.0, Mathematics = 4.0, Course = 2, Group = "ИСФ-21", DebtCount = 1 },
            new Student { ID = 3, FullName = "Сидоров С.С.", Physics = 5.0, English = 5.0, Mathematics = 3.5, Course = 3, Group = "ИСФ-31", DebtCount = 2 },
            new Student { ID = 4, FullName = "Козлов К.К.", Physics = 4.0, English = 4.5, Mathematics = 4.5, Course = 3, Group = "ИСФ-32", DebtCount = 0 }
        };
    }

    [Fact]
    public void CustomSort_NullStudents_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() =>
            WorkWithBase.CustomSort(null, "Возрастание", "Физика"));
    }

    [Fact]
    public void CustomSort_EmptySortDirection_ThrowsArgumentException()
    {
        var students = new List<Student>();
        Assert.Throws<ArgumentException>(() =>
            WorkWithBase.CustomSort(students, "", "Физика"));
    }

    [Fact]
    public void CustomSort_EmptyParam_ThrowsArgumentException()
    {
        var students = new List<Student>();
        Assert.Throws<ArgumentException>(() =>
            WorkWithBase.CustomSort(students, "Возрастание", ""));
    }

    [Fact]
    public void CustomSort_Ascending_SortsCorrectly()
    {
        WorkWithBase.CustomSort(testStudents, "Возрастание", "Физика");

        var sortedIDs = testStudents.Select(s => s.ID).ToList();
        Assert.Equal(new List<int> { 2, 4, 1, 3 }, sortedIDs);
    }

    [Fact]
    public void CustomSort_Descending_SortsCorrectly()
    {
        WorkWithBase.CustomSort(testStudents, "Убывание", "Математика");

        var sortedIDs = testStudents.Select(s => s.ID).ToList();
        Assert.Equal(new List<int> { 1, 4, 2, 3 }, sortedIDs); 
    }

    [Fact]
    public void CustomSort_UnknownParam_UsesAverageGrade()
    {
        var originalStudents = new List<Student>(testStudents);

        WorkWithBase.CustomSort(testStudents, "Возрастание", "Неизвестный параметр");

        var averageGrades = testStudents.Select(s => s.AverageGrade).ToList();
        Assert.True(averageGrades.SequenceEqual(averageGrades.OrderBy(x => x)));
    }

    [Fact]
    public void GetPropertySelector_Valid_ReturnsCorrectSelector()
    {
        var selector = WorkWithBase.GetPropertySelector("Физика");
        var result = selector(testStudents[0]);

        Assert.Equal(4.5, result);
    }


    [Theory]
    [InlineData("Физика", 4.0)]
    [InlineData("Математика", 4.0)]
    [InlineData("Кол-во задолженностей", 1)]
    public void FilterNums_GreaterThan_ReturnsCorrectResults(string param, double value)
    {
        var filtered = WorkWithBase.FilterNums(testStudents, value.ToString(), param, ">");

        foreach (var student in filtered)
        {
            var propertyValue = Convert.ToDouble(WorkWithBase.GetPropertySelector(param)(student));
            Assert.True(propertyValue > value);
        }
    }

    [Theory]
    [InlineData("Физика", 4.0)]
    [InlineData("Математика", 4.0)]
    [InlineData("Кол-во задолженностей", 1)]
    public void FilterNums_LessThan_ReturnsCorrectResults(string param, double value)
    {
        var filtered = WorkWithBase.FilterNums(testStudents, value.ToString(), param, "<");

        foreach (var student in filtered)
        {
            var propertyValue = Convert.ToDouble(WorkWithBase.GetPropertySelector(param)(student));
            Assert.True(propertyValue < value);
        }
    }
    [Theory]
    [InlineData("Физика", 4.0)]
    [InlineData("Математика", 4.0)]
    [InlineData("Кол-во задолженностей", 1)]
    public void FilterNums_LessOrEqualThan_ReturnsCorrectResults(string param, double value)
    {
        var filtered = WorkWithBase.FilterNums(testStudents, value.ToString(), param, "<=");

        foreach (var student in filtered)
        {
            var propertyValue = Convert.ToDouble(WorkWithBase.GetPropertySelector(param)(student));
            Assert.True(propertyValue <= value);
        }
    }
    [Theory]
    [InlineData("Физика", 4.0)]
    [InlineData("Математика", 4.0)]
    [InlineData("Кол-во задолженностей", 1)]
    public void FilterNums_GreaterOrEqualThan_ReturnsCorrectResults(string param, double value)
    {
        var filtered = WorkWithBase.FilterNums(testStudents, value.ToString(), param, ">=");

        foreach (var student in filtered)
        {
            var propertyValue = Convert.ToDouble(WorkWithBase.GetPropertySelector(param)(student));
            Assert.True(propertyValue >= value);
        }
    }

    [Theory]
    [InlineData("Физика", 3.5)]
    [InlineData("Математика", 4.0)]
    [InlineData("Кол-во задолженностей", 0)]
    public void FilterNums_EqualTo_ReturnsCorrectResults(string param, double value)
    {
        var filtered = WorkWithBase.FilterNums(testStudents, value.ToString(), param, "=");

        foreach (var student in filtered)
        {
            var propertyValue = Convert.ToDouble(WorkWithBase.GetPropertySelector(param)(student));
            Assert.True(Math.Abs(propertyValue - value) < 0.001);
        }
    }


    [Fact]
    public void Group_ByCourse_GroupsCorrectly()
    {
        var grouped = WorkWithBase.Group(testStudents, "Курс");

        Assert.Contains("2", grouped.Keys);
        Assert.Contains("3", grouped.Keys);
        Assert.Equal(2, grouped["2"].Count);
        Assert.Equal(2, grouped["3"].Count);
    }

    [Fact]
    public void Group_ByGroup_GroupsCorrectly()
    {
        var grouped = WorkWithBase.Group(testStudents, "Группа");

        Assert.Contains("ИСФ-21", grouped.Keys);
        Assert.Contains("ИСФ-31", grouped.Keys);
        Assert.Contains("ИСФ-32", grouped.Keys);
        Assert.Equal(2, grouped["ИСФ-21"].Count);
        Assert.Equal(1, grouped["ИСФ-31"].Count);
        Assert.Equal(1, grouped["ИСФ-32"].Count);
    }

    [Fact]
    public void Group_UnknownParam_GroupsAsOther()
    {
        // Act
        var grouped = WorkWithBase.Group(testStudents, "Неизвестный параметр");

        // Assert
        Assert.Contains("Другое", grouped.Keys);
        Assert.Equal(testStudents.Count, grouped["Другое"].Count);
    }

    [Fact]
    public void GetGroupKeySelector_Course_ReturnsCourseAsString()
    {
        // Act
        var selector = WorkWithBase.GetGroupKeySelector("Курс");
        var result = selector(testStudents[0]);

        // Assert
        Assert.Equal("2", result);
    }
}