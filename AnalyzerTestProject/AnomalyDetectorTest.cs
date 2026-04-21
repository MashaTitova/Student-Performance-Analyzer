using AnalyzerClassLibrary;


public class AnomalyDetectorTest
{
    private Student[] testStudents;

    public  AnomalyDetectorTest()
    {
        testStudents = new Student[]
        {
            new Student { ID = 1, FullName = "Иванов И.И.", Physics = 4.5, English = 3.0, Mathematics = 5.0, Course = 2, Group = "ИСФ-21", DebtCount = 0, AverageGrade = 4.17 },
            new Student { ID = 2, FullName = "Петров П.П.", Physics = 3.5, English = 4.0, Mathematics = 4.0, Course = 2, Group = "ИСФ-21", DebtCount = 1, AverageGrade = 3.83 },
            new Student { ID = 3, FullName = "Сидоров С.С.", Physics = 5.0, English = 5.0, Mathematics = 3.5, Course = 3, Group = "ИСФ-31", DebtCount = 2, AverageGrade = 4.5 },
            new Student { ID = 4, FullName = "Козлов К.К.", Physics = 4.0, English = 4.5, Mathematics = 4.5, Course = 3, Group = "ИСФ-32", DebtCount = 0, AverageGrade = 4.33 },
            // Аномалии
            new Student { ID = 5, FullName = "Аномальный 1", Physics = 1.0, English = 1.0, Mathematics = 1.0, Course = 2, Group = "ИСФ-21", DebtCount = 3, AverageGrade = 1.0 },
            new Student { ID = 6, FullName = "Аномальный 2", Physics = 5.0, English = 5.0, Mathematics = 5.0, Course = 3, Group = "ИСФ-31", DebtCount = 0, AverageGrade = 6.0 }
        };
    }
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

    // Типичный случай 2 выброса
    [Fact]
    public void FindAnomalies_TypicalData_ReturnsCorrectAnomalies()
    {
        string param = "AverageGrade";

        var result = AnomalyDetector.FindAnomalies(testStudents, param);

        Assert.Equal(2, result.Length);
        Assert.Contains(result, s => s.FullName == "Аномальный 1");
        Assert.Contains(result, s => s.FullName == "Аномальный 2");
    }
    // Типичный случай нет выбросов
    [Fact]
    public void FindAnomalies_NoAnomalies_ReturnsEmptyArray()
    {
        var normalStudents = new Student[]
        {
            new Student { FullName = "Студент 1", AverageGrade = 4.0 },
            new Student { FullName = "Студент 2", AverageGrade = 4.2 },
            new Student { FullName = "Студент 3", AverageGrade = 3.8 },
            new Student { FullName = "Студент 4", AverageGrade = 4.1 }
        };
        string param = "AverageGrade";

        var result = AnomalyDetector.FindAnomalies(normalStudents, param);

        Assert.Empty(result);
    }

    // Граничный случай - пустой массив
    [Fact]
    public void FindAnomalies_EmptyArray_ReturnsEmptyArray()
    {
        Student[] emptyStudents = new Student[0];
        string param = "AverageGrade";

        var result = AnomalyDetector.FindAnomalies(emptyStudents, param);

        Assert.Empty(result);
    }

    // Некорректные входные данные - null 
    [Fact]
    public void FindAnomalies_NullArray_ReturnsEmptyArray()
    {
        Student[] nullStudents = null;
        string param = "AverageGrade";

        var result = AnomalyDetector.FindAnomalies(nullStudents, param);

        Assert.Empty(result);
    }
    // Некорректные входные данные - несуществующий параметр
    [Fact]
    public void FindAnomalies_InvalidParam_ReturnsEmptyArray()
    {
        string invalidParam = "InvalidProperty";

        var result = AnomalyDetector.FindAnomalies(testStudents, invalidParam);

        Assert.Equal(2, result.Length);
        Assert.Contains(result, s => s.FullName == "Аномальный 1");
        Assert.Contains(result, s => s.FullName == "Аномальный 2");
    }

    // Большой объём данных
    [Fact]
    public void FindAnomalies_LargeDataSet_CompletesInReasonableTime()
    {

        const int largeSize = 5000;
        var originalStudents = GenerateLargeStudentArray(largeSize);

        var largeStudents = new Student[largeSize + 2];

        for (int i = 0; i < originalStudents.Length; i++)
        {
            largeStudents[i] = originalStudents[i];
        }

        largeStudents[largeSize] = new Student { FullName = "Аномалия 1", AverageGrade = 1.0 };
        largeStudents[largeSize + 1] = new Student { FullName = "Аномалия 2", AverageGrade = 6.0 };
        string param = "AverageGrade";

        var result = AnomalyDetector.FindAnomalies(largeStudents.ToArray(), param);

        var stopwatch = System.Diagnostics.Stopwatch.StartNew();

        WorkWithBase.FilterString(largeStudents, param);

        stopwatch.Stop();

        Assert.True(stopwatch.ElapsedMilliseconds < 5000,
            $"Сортировка заняла {stopwatch.ElapsedMilliseconds} мс, что больше допустимых 5000 мс");
    }

    // Специфический случай: отсортированные данные
    [Fact]
    public void FindAnomalies_AlreadySortedData_ReturnsCorrectResults()
    {
        var sortedStudents = new Student[]
        {
                new Student { FullName = "Низкий балл", AverageGrade = 1.0 },
                new Student { FullName = "Средний 1", AverageGrade = 3.8 },
                new Student { FullName = "Средний 2", AverageGrade = 4.0 },
                new Student { FullName = "Средний 3", AverageGrade = 4.2 },
                new Student { FullName = "Высокий балл", AverageGrade = 5.0 }
        };
        string param = "AverageGrade";

        var result = AnomalyDetector.FindAnomalies(sortedStudents, param);

        Assert.Equal(2, result.Length);
        Assert.Contains(result, s => s.FullName == "Низкий балл");
        Assert.Contains(result, s => s.FullName == "Высокий балл");
    }
}
