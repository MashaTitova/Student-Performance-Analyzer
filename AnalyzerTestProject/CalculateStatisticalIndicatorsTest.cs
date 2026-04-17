using Xunit;
using System.Collections.Generic;

namespace Student_Performance_Analyzer.Tests
{
    public class CalculateStatisticalIndicatorsTests
    {
        private List<Student> createStudents;

        public CalculateStatisticalIndicatorsTests()
        {
            createStudents = new List<Student>
            {
                new Student { ID = 1, FullName = "Иванов И.И.", Physics = 4.5, English = 3.0, Mathematics = 5.0, Course = 2, Group = "ИСФ-21", DebtCount = 0 },
                new Student { ID = 2, FullName = "Петров П.П.", Physics = 3.5, English = 4.0, Mathematics = 4.0, Course = 2, Group = "ИСФ-21", DebtCount = 1 },
                new Student { ID = 3, FullName = "Сидоров С.С.", Physics = 5.0, English = 5.0, Mathematics = 3.5, Course = 3, Group = "ИСФ-31", DebtCount = 2 },
                new Student { ID = 4, FullName = "Козлов К.К.", Physics = 4.0, English = 4.5, Mathematics = 4.5, Course = 3, Group = "ИСФ-32", DebtCount = 0 }
            };
        }

        [Fact]
        public void CalculateAverage_Physics_ReturnsCorrectValue()
        {
            // Act
            double result = CalculateStatisticalIndicators.CalculateAverage(createStudents, "Physics");

            // Assert: (4.5 + 3.5 + 5.0 + 4.0) / 4 = 17.0 / 4 = 4.25
            Assert.Equal(4.25, result, 2);
        }

        [Fact]
        public void CalculateAverage_English_ReturnsCorrectValue()
        {
            // Act
            double result = CalculateStatisticalIndicators.CalculateAverage(createStudents, "English");

            // Assert: (3.0 + 4.0 + 5.0 + 4.5) / 4 = 16.5 / 4 = 4.125
            Assert.Equal(4.125, result, 3);
        }

        [Fact]
        public void CalculateAverage_Mathematics_ReturnsCorrectValue()
        {
            // Act
            double result = CalculateStatisticalIndicators.CalculateAverage(createStudents, "Mathematics");

            // Assert: (5.0 + 4.0 + 3.5 + 4.5) / 4 = 17.0 / 4 = 4.25
            Assert.Equal(4.25, result, 2);
        }

        [Fact]
        public void CalculateMedian_Physics_EvenCount_ReturnsMiddleAverage()
        {
            // Arrange: отсортированные значения Physics: 3.5, 4.0, 4.5, 5.0
            // Медиана = (4.0 + 4.5) / 2 = 4.25

            // Act
            double result = CalculateStatisticalIndicators.CalculateMedian(createStudents, "Physics");

            // Assert
            Assert.Equal(4.25, result, 2);
        }

        [Fact]
        public void CalculateMedian_Mathematics_EvenCount_ReturnsMiddleAverage()
        {
            // Arrange: отсортированные Mathematics: 3.5, 4.0, 4.5, 5.0
            // Медиана = (4.0 + 4.5) / 2 = 4.25

            // Act
            double result = CalculateStatisticalIndicators.CalculateMedian(createStudents, "Mathematics");

            // Assert
            Assert.Equal(4.25, result, 2);
        }

        [Fact]
        public void CalculateMinMax_Physics_ReturnsCorrectExtremes()
        {
            // Act
            var (min, max) = CalculateStatisticalIndicators.CalculateMinMax(createStudents, "Physics");

            // Assert
            Assert.Equal(3.5, min, 2);  // Минимальное значение Physics
            Assert.Equal(5.0, max, 2);  // Максимальное значение Physics
        }

        [Fact]
        public void CalculateMinMax_English_ReturnsCorrectExtremes()
        {
            // Act
            var (min, max) = CalculateStatisticalIndicators.CalculateMinMax(createStudents, "English");

            // Assert
            Assert.Equal(3.0, min, 2);  // Минимальное значение English
            Assert.Equal(5.0, max, 2);  // Максимальное значение English
        }

        [Fact]
        public void CalculateMinMax_Mathematics_ReturnsCorrectExtremes()
        {
            // Act
            var (min, max) = CalculateStatisticalIndicators.CalculateMinMax(createStudents, "Mathematics");

            // Assert
            Assert.Equal(3.5, min, 2);  // Минимальное значение Mathematics
            Assert.Equal(5.0, max, 2);  // Максимальное значение Mathematics
        }

        [Fact]
        public void CalculateAverage_EmptyList_ReturnsZero()
        {
            // Arrange
            var emptyList = new List<Student>();

            // Act
            double result = CalculateStatisticalIndicators.CalculateAverage(emptyList, "Physics");

            // Assert
            Assert.Equal(0.0, result, 2);
        }

        [Fact]
        public void CalculateMedian_EmptyList_ReturnsZero()
        {
            // Arrange
            var emptyList = new List<Student>();

            // Act
            double result = CalculateStatisticalIndicators.CalculateMedian(emptyList, "Physics");

            // Assert
            Assert.Equal(0.0, result, 2);
        }

        [Fact]
        public void CalculateMinMax_EmptyList_ReturnsZero()
        {
            // Arrange
            var emptyList = new List<Student>();

            // Act
            var (min, max) = CalculateStatisticalIndicators.CalculateMinMax(emptyList, "Physics");

            // Assert
            Assert.Equal(0.0, min, 2);
            Assert.Equal(0.0, max, 2);
        }
    }
}
