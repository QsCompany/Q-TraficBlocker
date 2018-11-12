using System.Windows.Forms;

namespace _
{
    public class ________________:DataGridViewRow
    {
        private DataGridViewCheckBoxCell New=new DataGridViewCheckBoxCell(){};
        private DataGridViewTextBoxCell Name=new DataGridViewTextBoxCell();
        private DataGridViewTextBoxCell PID=new DataGridViewTextBoxCell();
        private DataGridViewTextBoxCell Path=new DataGridViewTextBoxCell();
        private DataGridViewCheckBoxCell Blocked=new DataGridViewCheckBoxCell();
        private DataGridViewCheckBoxCell Allowed=new DataGridViewCheckBoxCell() ;
        private readonly DataGridViewComboBoxCell Direction=new DataGridViewComboBoxCell();
        private readonly DataGridViewComboBoxCell Strategy=new DataGridViewComboBoxCell();
        private DataGridViewTextBoxCell ID = new DataGridViewTextBoxCell();

        public ________________(DataGridView explrer)
        {
            this.Cells.AddRange(new DataGridViewCell[]
            {
                New, Name, PID, Path, Blocked, Allowed, Direction, Strategy
            }); 
            Direction.ReadOnly = true;
            Strategy.ReadOnly = true;
            
        }
    }
}