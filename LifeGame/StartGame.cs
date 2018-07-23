using System;
using System.Windows.Forms;

namespace LifeGame
{
    public partial class StartGame : Form
    {
        public StartGame()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GameGui gui = new GameGui()
        }



        /*public enum CellSizes
        {
            1,
            2,
            5,
            10;
        }*/


    }
}
