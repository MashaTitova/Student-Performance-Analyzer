using System.Buffers;
using System.DirectoryServices;

public class WorkWithBaseTests
{
    private Student[] testStudents;

    public WorkWithBaseTests()
    {
        testStudents = new Student[]
        {
        new Student { ID = 1, FullName = "Иванов И.И.", Physics = 4.5, English = 3.0, Mathematics = 5.0, Course = 2, Group = "ИСФ-21", DebtCount = 0 },
        new Student { ID = 2, FullName = "Петров П.П.", Physics = 3.5, English = 4.0, Mathematics = 4.0, Course = 2, Group = "ИСФ-21", DebtCount = 1 },
        new Student { ID = 3, FullName = "Сидоров С.С.", Physics = 5.0, English = 5.0, Mathematics = 3.5, Course = 3, Group = "ИСФ-31", DebtCount = 2 },
        new Student { ID = 4, FullName = "Козлов К.К.", Physics = 4.0, English = 4.5, Mathematics = 4.5, Course = 3, Group = "ИСФ-32", DebtCount = 0 }
        };
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
    // Типичный случай Строковый поиск
    [Fact]
    public void FilterString_TypicalSearch_ReturnsCorrectResults()
    {
        string searchString = "Иванов";

        var result = WorkWithBase.FilterString(testStudents, searchString);

        Assert.Single(result);
        Assert.Equal("Иванов И.И.", result[0].FullName);
    }
    // Типичный случай Строковый поиск
    [Fact]
    public void FilterString_PartialMatch_ReturnsMultipleResults()
    {
        string searchString = "ов";

        var result = WorkWithBase.FilterString(testStudents, searchString);

        Assert.Equal(4, result.Length);
        Assert.Contains(result, s => s.FullName == "Иванов И.И.");
        Assert.Contains(result, s => s.FullName == "Петров П.П.");
        Assert.Contains(result, s => s.FullName == "Сидоров С.С.");
        Assert.Contains(result, s => s.FullName == "Козлов К.К.");
    }

    // Граничный случай - пустой массив Строковый поиск
    [Fact]
    public void FilterString_EmptyArray_ReturnsEmptyArray()
    {
        Student[] emptyStudents = new Student[0];
        string searchString = "Иванов";

        var result = WorkWithBase.FilterString(emptyStudents, searchString);

        Assert.Empty(result);
    }
    // Некорректные входные данные - null Входные данные Строковый поиск
    [Fact]
    public void FilterString_NullArray_ReturnsEmptyArray()
    {
        Student[] nullStudents = null;
        string searchString = "Иванов";

        var result = WorkWithBase.FilterString(nullStudents, searchString);

        Assert.Empty(result);
    }
    // Большой объем данных Строковый поиск
    public void FilterString_LargeDataSet_CompletesInReasonableTime()
    {
        const int largeSize = 10000;
        var largeArray = GenerateLargeStudentArray(largeSize);
        string searchString = "Иванов";

        var stopwatch = System.Diagnostics.Stopwatch.StartNew();

        WorkWithBase.FilterString(largeArray, searchString);

        stopwatch.Stop();

        Assert.True(stopwatch.ElapsedMilliseconds < 5000,
            $"Сортировка заняла {stopwatch.ElapsedMilliseconds} мс, что больше допустимых 5000 мс");
    }
    // Специфический случай: несовпадение регистра Строковый поиск
    [Fact]
    public void FilterString_CaseInsensitiveSearch_ReturnsMatches()
    {
        string searchString = "иванов";

        var result = WorkWithBase.FilterString(testStudents, searchString);

        Assert.Single(result);
        Assert.Equal("Иванов И.И.", result[0].FullName);
    }
    // Специфический случай: отсортированных массив Фильтр Возрастание
    [Fact]
    public void CustomSort_AlreadySortedAscending_ShouldNotChangeArray()
    {
        var sortedStudents = new Student[]
        {
            new Student { Physics = 2.5 },
            new Student { Physics = 3.0 },
            new Student { Physics = 4.0 },
            new Student { Physics = 4.5 },
            new Student { Physics = 5.0 }
        };

        var originalReferences = sortedStudents.Select(s => s).ToArray();

        string sortDirection = "Возрастание";
        string param = "Physics";

        WorkWithBase.CustomSort(sortedStudents, sortDirection, param);

        Assert.Equal(originalReferences.Length, sortedStudents.Length);

        for (int i = 0; i < originalReferences.Length; i++)
        {
            Assert.Same(originalReferences[i], sortedStudents[i]);
        }
    }

    // Специфический случай: отсортированных массив Фильтр Убывание
    [Fact]
    public void CustomSort_AlreadySortedDescending_ShouldHandleCorrectly()
    {
        var descendingStudents = new Student[]
        {
            new Student { Physics = 5.0 },
            new Student { Physics = 4.5 },
            new Student { Physics = 4.0 },
            new Student { Physics = 3.0 },
            new Student { Physics = 2.5 }
        };

        var originalReferences = descendingStudents.Select(s => s).ToArray();
        string sortDirection = "Убывание";
        string param = "Physics";

        WorkWithBase.CustomSort(descendingStudents, sortDirection, param);

        Assert.Equal(originalReferences.Length, descendingStudents.Length);
        for (int i = 0; i < originalReferences.Length; i++)
        {
            Assert.Same(originalReferences[i], descendingStudents[i]);
        }
    }

    // Некорректные входные данные - null Входные данные Сортировка
    [Fact]
    public void CustomSort_NullStudents_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() =>
            WorkWithBase.CustomSort(null, "Возрастание", "Физика"));
    }
    // Некорректные входные данные - null Направление сортировки Сортировка
    [Fact]
    public void CustomSort_NullDirection_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
            WorkWithBase.CustomSort(testStudents,null, "Физика"));
    }
    // Некорректные входные данные - null Параметр Сортировка
    [Fact]
    public void CustomSort_NullParam_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
            WorkWithBase.CustomSort(testStudents, "Возрастание", null));
    }

    // Граничный случай - пустой массив Сортировка
    [Fact]
    public void CustomSort_EmptyParam_ThrowsArgumentException()
    {
        Student[] emptyArray = new Student[0];
        string sortDirection = "Возрастание";
        string param = "Physics";

        WorkWithBase.CustomSort(emptyArray, sortDirection, param);

        Assert.Empty(emptyArray);
    }

    // Типичный случай Сортировка Возрастание
    [Fact]
    public void CustomSort_Ascending_SortsCorrectly()
    {
        WorkWithBase.CustomSort(testStudents, "Возрастание", "Физика");

        var sortedIDs = testStudents.Select(s => s.ID).ToList();
        Assert.Equal(new List<int> { 2, 4, 1, 3 }, sortedIDs);
    }

    // Типичный случай Сортировка Убывание
    [Fact]
    public void CustomSort_Descending_SortsCorrectly()
    {
        WorkWithBase.CustomSort(testStudents, "Убывание", "Математика");

        var sortedIDs = testStudents.Select(s => s.ID).ToList();
        Assert.Equal(new List<int> { 1, 4, 2, 3 }, sortedIDs);
    }
    
    // Большой объем данных Сортировка
    [Fact]
    public void CustomSort_LargeDataSet_ShouldNotHang()
    {
        const int largeSize = 10000;
        var largeArray = GenerateLargeStudentArray(largeSize);
        string sortDirection = "Возрастание";
        string param = "Physics";

        var stopwatch = System.Diagnostics.Stopwatch.StartNew();

        WorkWithBase.CustomSort(largeArray, sortDirection, param);

        stopwatch.Stop();

        Assert.True(stopwatch.ElapsedMilliseconds < 2000,
            $"Сортировка заняла {stopwatch.ElapsedMilliseconds} мс, что больше допустимых 2000 мс");
    }

    [Fact]
    public void GetPropertySelector_Valid_ReturnsCorrectSelector()
    {
        var selector = WorkWithBase.GetPropertySelector("Физика");
        var result = selector(testStudents[0]);

        Assert.Equal(4.5, result);
    }

    // Типичный случай Фильтр >
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

    // Типичный случай Фильтр <
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

    // Типичный случай Фильтр <=
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

    // Типичный случай Фильтр >=
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

    // Типичный случай Фильтр =
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
    // Некорректные входные данные - null Фильтр
    [Fact]
    public void FilterNums_NullStudentsArray_ShouldThrowArgumentNullException()
    {
        var result = WorkWithBase.FilterNums(null, "5", "Physics", ">");
        Assert.IsType<Student[]>(result);
        Assert.Empty(result);

    }

    // Большой объем данных Фильтр
    [Fact]
    public void FilterNums_LargeDataSet_ShouldCompleteInReasonableTime()
    {
        const int largeSize = 50000;
        var largeArray = GenerateLargeStudentArray(largeSize);
        string searchValue = "3,5";
        string param = "Physics";
        string ratio = ">";

        var stopwatch = System.Diagnostics.Stopwatch.StartNew();

        var result = WorkWithBase.FilterNums(largeArray, searchValue, param, ratio);

        stopwatch.Stop();

        Assert.True(stopwatch.ElapsedMilliseconds < 2000,
            $"Фильтрация заняла {stopwatch.ElapsedMilliseconds} мс, что больше допустимых 2000 мс");
        Assert.NotNull(result);
    }

    // Граничный случай - пустой массив Фильтр
    [Fact]
    public void FilterNums_EmptyArray_ShouldReturnEmptyArray()
    {
        Student[] emptyArray = new Student[0];

        var result = WorkWithBase.FilterNums(emptyArray, "3", "Physics", ">");

        Assert.Empty(result);
    }

    // Специфический случай: не одно значение не подходит Фильтр
    [Fact]
    public void FilterNums_NoStudentsMatch_ShouldReturnEmpty()
    {
        var students = new Student[]
        {
        new Student { Physics = 3.5 },
        new Student { Physics = 4.0 },
        new Student { Physics = 2.0 }
        };

        var result = WorkWithBase.FilterNums(students, "5", "Physics", ">");

        Assert.Empty(result);
    }


    // Типичный случай Группировка по группе
    [Fact]
    public void Group_ByCourse_GroupsCorrectly()
    {
        var grouped = WorkWithBase.Group(testStudents, "Курс");

        Assert.Contains("2", grouped.Keys);
        Assert.Contains("3", grouped.Keys);
        Assert.Equal(2, grouped["2"].Length);
        Assert.Equal(2, grouped["3"].Length);
    }

    // Типичный случай Группировка по курсу
    [Fact]
    public void Group_ByGroup_GroupsCorrectly()
    {
        var grouped = WorkWithBase.Group(testStudents, "Группа");

        Assert.Contains("ИСФ-21", grouped.Keys);
        Assert.Contains("ИСФ-31", grouped.Keys);
        Assert.Contains("ИСФ-32", grouped.Keys);
        Assert.Equal(2, grouped["ИСФ-21"].Length);
        Assert.Equal(1, grouped["ИСФ-31"].Length);
        Assert.Equal(1, grouped["ИСФ-32"].Length);
    }

    // Некорректные входные данные - null Группировка
    [Fact]
    public void Group_NullStudentsArray_ReturnsEmptyDictionary()
    {
        var result = WorkWithBase.Group(null, "Course");

        Assert.Empty(result);
        Assert.IsType<Dictionary<string, Student[]>>(result);
    }

    // Большой объем данных Группировка
    [Fact]
    public void Group_LargeDataSet_ShouldCompleteInReasonableTime()
    {
        const int largeSize = 50000;
        var largeArray = GenerateLargeStudentArray(largeSize);
        string param = "Course";

        var stopwatch = System.Diagnostics.Stopwatch.StartNew();

        var result = WorkWithBase.Group(largeArray, param);

        stopwatch.Stop();

        Assert.True(stopwatch.ElapsedMilliseconds < 3000,
            $"Группировка заняла {stopwatch.ElapsedMilliseconds} мс, что больше допустимых 3000 мс");
        Assert.NotNull(result);
    }

    // Граничный случай - пустой массив Группировка
    [Fact]
    public void Group_EmptyArray_ShouldReturnEmptyDictionary()
    {
        Student[] emptyArray = new Student[0];

        var result = WorkWithBase.Group(emptyArray, "Course");

        Assert.Empty(result);
    }

    // Специфический случай: все студенты на одном курсе Группировка
    [Fact]
    public void Group_AllStudentsSameGroup_ShouldCreateSingleKey()
    {
        var students = new Student[]
        {
        new Student { Course = 3, FullName = "Иванов" },
        new Student { Course = 3, FullName = "Петров" },
        new Student { Course = 3, FullName = "Сидоров" }
        };

        var result = WorkWithBase.Group(students, "Курс");

        Assert.Single(result); 
        Assert.Contains("3", result.Keys); 
        Assert.Equal(3, result["3"].Length); 
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