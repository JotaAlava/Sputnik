namespace Sputnik.Models.BaseModels
{
    public class TableElement
    {
        private PageElement table;
        public TableElement(string tableId)
        {
            table = new PageElement(tableId);
        }
    }
}
