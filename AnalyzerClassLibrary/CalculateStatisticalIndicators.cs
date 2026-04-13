using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Reflection.Emit;
using System.Text;

public class CalculateStatisticalIndicators
{
    public static double CalculateAverage(DataGridView grid, string columnText)
    {
        DataGridViewColumn column = grid.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.HeaderText == columnText);
        string ColumnName = column.Name;
        DataTable dataTable = (DataTable)grid.DataSource;
        double sum = 0;
        foreach (DataRow row in dataTable.Rows)
        {
            double newNum;
            if (double.TryParse(row[column.Name].ToString(), out newNum))
            {
                sum += newNum;
            }
        }
        return Math.Round(sum / grid.Rows.Count, 2);
    }
    public static double CalculateMedian(DataGridView grid, string columnText)
    {
        List<double> values = new List<double>();
        DataGridViewColumn column = grid.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.HeaderText == columnText);
        DataTable dataTable = (DataTable)grid.DataSource;
        foreach (DataRow row in dataTable.Rows)
        {
            double value;
            if (double.TryParse(row[column.Name].ToString(), out value))
            {
                values.Add(value);
            }
        }

        values.Sort();
        int count = values.Count;

        return count % 2 == 1
            ? values[count / 2]
            : (values[count / 2 - 1] + values[count / 2]) / 2.0;
    }
    public static double[] CalculateMinMax(DataGridView grid, string columnText)
    {
        double min = 1000000;
        double max = -1;
        DataGridViewColumn column = grid.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.HeaderText == columnText);
        DataTable dataTable = (DataTable)grid.DataSource;
        foreach (DataRow row in dataTable.Rows)
        {
            double value;
            if (double.TryParse(row[column.Name].ToString(), out value))
            {
                if (value < min) { min = value; }
                if (value > max) { max = value; }
            }
        }
        return [min, max];
    }
}
