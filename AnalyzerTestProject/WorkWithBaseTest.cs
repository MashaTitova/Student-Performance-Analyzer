public class WorkWithBaseTests
{
    private Student[] CreateTestStudents()
    {
        return new Student[]
        {
            new Student(1, "Иванов И.И.", 2, "Гр-101", 4.5, 5.0, 3.8, 4.2, 4.0, 4.8, 4.3, 4.7, 4.1, 4.6, 4.4, 0),
            new Student(2, "Петров П.П.", 2, "Гр-102", 3.2, 4.0, 4.5, 3.9, 4.1, 3.7, 4.2, 3.5, 4.3, 3.8, 3.9, 1),
            new Student(3, "Сидоров С.С.", 3, "Гр-101", 5.0, 4.8, 4.9, 5.0, 4.7, 4.9, 4.8, 5.0, 4.9, 4.8, 4.9, 0),
            new Student(4, "Козлова К.К.", 3, "Гр-103", 4.0, 4.2, 4.1, 4.3, 4.4, 4.0, 4.5, 4.1, 4.2, 4.3, 4.2, 0)
        };
    }
    [Theory]
    [InlineData("Физика", "Возрастание")]
    [InlineData("Английский язык", "Убывание")]
    [InlineData("Математика", "Возрастание")]
    public void CustomSort_SortsCorrectly(string param, string sortDirection)
    {
        var students = CreateTestStudents();
        var originalStudents = (Student[])students.Clone();


        WorkWithBase.CustomSort(ref students, sortDirection, param);

        var selector = WorkWithBase.GetPropertySelector(param);
        var expected = sortDirection == "Возрастание"
            ? originalStudents.OrderBy(selector).ToArray()
            : originalStudents.OrderByDescending(selector).ToArray();

        Assert.Equal(expected.Length, students.Length);
        for (int i = 0; i < expected.Length; i++)
        {
            Assert.Equal(expected[i].ID, students[i].ID);
        }
    }

    [Fact]
    public void CustomSort_ThrowsArgumentNullException_WhenStudentsIsNull()
    {
        Student[] students = null;
        Assert.Throws<ArgumentNullException>(() =>
            WorkWithBase.CustomSort(ref students, "Возрастание", "Физика"));
    }

    [Fact]
    public void CustomSort_ThrowsArgumentException_WhenSortDirectionIsEmpty()
    {
        var students = CreateTestStudents();
        Assert.Throws<ArgumentException>(() =>
            WorkWithBase.CustomSort(ref students, "", "Физика"));
    }

    [Fact]
    public void CustomSort_ThrowsArgumentException_WhenParamIsEmpty()
    {
        var students = CreateTestStudents();
        Assert.Throws<ArgumentException>(() =>
            WorkWithBase.CustomSort(ref students, "Возрастание", ""));
    }
    [Theory]
    [InlineData(">", 4.0, 2)] 
    [InlineData("<", 4.0, 1)] 
    [InlineData("=", 4.5, 1)]  
    [InlineData(">=", 4.5, 2)] 
    public void FilterNums_FiltersCorrectly(string ratio, double value, int expectedCount)
    {
        var students = CreateTestStudents();

        var filtered = WorkWithBase.FilterNums(students, value.ToString(), "Физика", ratio);

        Assert.Equal(expectedCount, filtered.Length);
    }

    [Fact]
    public void FilterNums_ReturnsOriginalArray_WhenInvalidRatio()
    {
        var students = CreateTestStudents();

        var result = WorkWithBase.FilterNums(students, "4,0", "Физика", "invalid");

        Assert.Same(students, result);
    }

  
     [Fact]
    public void Group_GroupsByCourse_Correctly()
    {
        var students = CreateTestStudents();


        var result = WorkWithBase.Group(students, "Курс");

        Assert.Equal(2, result.Count); 
        Assert.True(result.ContainsKey("2"));
        Assert.True(result.ContainsKey("3"));
        Assert.Equal(2, result["2"].Length); 
        Assert.Equal(2, result["3"].Length); 

        Assert.Contains(result["2"], s => s.ID == 1); 
        Assert.Contains(result["2"], s => s.ID == 2); 
        Assert.Contains(result["3"], s => s.ID == 3); 
        Assert.Contains(result["3"], s => s.ID == 4); 
    }

    [Fact]
    public void Group_GroupsByGroup_Correctly()
    {
        var students = CreateTestStudents();

        var result = WorkWithBase.Group(students, "Группа");


        Assert.Equal(3, result.Count); 
        Assert.True(result.ContainsKey("Гр-101"));
        Assert.True(result.ContainsKey("Гр-102"));
        Assert.True(result.ContainsKey("Гр-103"));

        Assert.Equal(2, result["Гр-101"].Length); 
        Assert.Equal(1, result["Гр-102"].Length); 
        Assert.Equal(1, result["Гр-103"].Length); 

        Assert.Contains(result["Гр-101"], s => s.ID == 1);
        Assert.Contains(result["Гр-101"], s => s.ID == 3);
        Assert.Contains(result["Гр-102"], s => s.ID == 2);
        Assert.Contains(result["Гр-103"], s => s.ID == 4);
    }

    [Fact]
    public void Group_HandlesUnknownParameter_Correctly()
    {
        var students = CreateTestStudents();

        var result = WorkWithBase.Group(students, "Неизвестный параметр");

        Assert.Equal(1, result.Count);
        Assert.True(result.ContainsKey("Другое"));
        Assert.Equal(students.Length, result["Другое"].Length);

        for (int i = 0; i < students.Length; i++)
        {
            Assert.Contains(result["Другое"], s => s.ID == students[i].ID);
        }
    }

    [Fact]
    public void Group_ReturnsEmptyDictionary_EmptyArray()
    {
        // Arrange
        Student[] students = new Student[0];

        var result = WorkWithBase.Group(students, "Курс");

        Assert.Empty(result);
    }


}