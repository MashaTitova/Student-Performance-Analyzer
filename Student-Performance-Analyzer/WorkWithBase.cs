using System.ComponentModel;
using Student_Performance_Analyzer;
public class WorkWithBase
{
    public static DataGridView Sort(DataGridView grid, string sortDirect, string param)
    {
        // Определяем направление сортировки
        ListSortDirection sortDirection =
            sortDirect == "Возрастание"
                ? ListSortDirection.Ascending
                : ListSortDirection.Descending;
        DataGridViewColumn column = grid.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c =>c.HeaderText == param);
        grid.Sort(
               column,
               sortDirection);
        return grid;
    }
    
    public static DataGridView FindText(DataGridView grid, string searchText, string columnName)
    {
        int i = 0;
        foreach (DataGridViewRow row in grid.Rows)
        {
            DataGridViewCell cell = row.Cells[columnName];
            if (!(cell.Value != null &&
                cell.Value.ToString().Contains(searchText)))
            {
                grid.Rows.RemoveAt(i);
            }
            i++;
        }
        return grid;
    }

    public static DataGridView FindNum(DataGridView grid, string columnName, string oper, string meaning)
    {
        DataGridViewColumn column = grid.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.HeaderText == columnName);
        List<int> rowsToRemove = new List<int>();

        for (int i = 0; i < grid.Rows.Count; i++)
        {
            DataGridViewRow row = grid.Rows[i];
            object cellValue = row.Cells[column.Index].Value;
            bool result = Analyzer_form.Calculate(
                Convert.ToDouble(cellValue),
                Convert.ToDouble(meaning),
                oper);

            if (!result)
                rowsToRemove.Add(i);  
        }

        // Удаляем строки в обратном порядке
        for (int j = rowsToRemove.Count - 1; j >= 0; j--)
            grid.Rows.RemoveAt(rowsToRemove[j]);

        return grid;
    }
}

