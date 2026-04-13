using System.Buffers;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

public class AnalyzerClassLibrary
{
    public static void CustomSort(DataGridView grid, string sortDirect, string param)
    {

        // Определяем направление сортировки
        ListSortDirection sortDirection =
            sortDirect == "Возрастание"
                ? ListSortDirection.Ascending
                : ListSortDirection.Descending;
        DataGridViewColumn column = grid.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.HeaderText == param);
        grid.Sort(
                column,
                sortDirection);
    }

    public static void FilterString(DataGridView grid, string searchValue, string param)
    {
        DataGridViewColumn column = grid.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.HeaderText == param);
        if (column == null || string.IsNullOrEmpty(searchValue))
            return;

        // Получаем DataTable из DataGridView
        DataTable dataTable = (DataTable)grid.DataSource;

        // Формируем фильтр
        string filter = $"[{column.Name}] LIKE '%{searchValue}%'";

        // Применяем фильтр
        dataTable.DefaultView.RowFilter = filter;
    }
    public static void FilterNums(DataGridView grid, string searchValue, string param, string ratio)
    {
        DataGridViewColumn column = grid.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.HeaderText == param);
        if (column == null || string.IsNullOrEmpty(searchValue))
            return;

        // Получаем DataTable из DataGridView
        DataTable dataTable = (DataTable)grid.DataSource;

        // Формируем фильтр
        string filter = $"Convert([{column.Name}], 'System.Double') {ratio} {Convert.ToDouble(searchValue)}";

        // Применяем фильтр
        dataTable.DefaultView.RowFilter = filter;
    }
    public static void Group(DataGridView grid, string param)
    {
        DataGridViewColumn column = grid.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.HeaderText == param);
        grid.Sort(column, ListSortDirection.Ascending);
    }
}


