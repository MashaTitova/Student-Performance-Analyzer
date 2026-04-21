namespace AnalyzerClassLibrary
{
    public class AnomalyDetector
    {
        public static Student[] FindAnomalies(Student[] data, string param)
        {
            if (data == null || data.Length < 4)
                return new Student[0];

            // Сортируем данные вручную (пузырьковая сортировка)
            WorkWithBase.CustomSort(data, "Возрастание", param);

            var selector = WorkWithBase.GetPropertySelector(param);
            // Вычисляем квартили
            double q1 = CalculateQuartile(data, 25, param);
            double q3 = CalculateQuartile(data, 75, param);

            // Межквартильный размах
            double iqr = q3 - q1;

            // Границы для выбросов
            double lowerBound = q1 - 1.5 * iqr;
            double upperBound = q3 + 1.5 * iqr;

            // Ищем аномалии
            List<Student> anomalies = new List<Student>();
            for (int i = 0; i < data.Length; i++) 
            {
                if (Convert.ToDouble(selector(data[i])) < lowerBound || (Convert.ToDouble(selector(data[i])) > upperBound))
                    anomalies.Add(data[i]);
            }
            var result = anomalies.ToArray();
            return result;
        }

        

        // Вычисление квартиля
        private static double CalculateQuartile(Student[] sortedData, int percentile, string param)
        {
            var selector = WorkWithBase.GetPropertySelector(param);
            int n = sortedData.Length;
            // Позиция в массиве
            double pos = (percentile / 100.0) * (n - 1);
            int intPos = (int)pos;
            double frac = pos - intPos;

            if (intPos >= n - 1)
                return Convert.ToDouble(selector(sortedData[n - 1]));

            if (frac == 0)
                return Convert.ToDouble(selector(sortedData[intPos]));

            // Линейная интерполяция между соседними значениями
            return Convert.ToDouble(selector(sortedData[intPos])) + frac * (Convert.ToDouble(selector(sortedData[intPos + 1])) - Convert.ToDouble(selector(sortedData[intPos])));
        }
    }
}
