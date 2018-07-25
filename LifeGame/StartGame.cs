using System;
using System.Windows.Forms;

namespace LifeGame
{
    public partial class StartGame : Form
    {

        public StartGame()
        {
            InitializeComponent();
            //frequencies of updating game board
            this.TimeBox.Items.AddRange(new object[] { 100, 200, 500, 1000, 2500 });
            //sizes of cell
            this.CellBox.Items.AddRange(new object[] { 2, 5, 10, 20, 25, 30 });
            //sizes of board itself
            this.GridBox.Items.AddRange(new object[] { 300, 400, 500, 600, 700, 800 });
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            if (CellBox.SelectedItem != null && GridBox.SelectedItem != null && TimeBox.SelectedItem != null)
            {

                // GameGui gui = new GameGui((int)CellBox.SelectedItem, (int)GridBox.SelectedItem, (int)GridBox.SelectedItem, (int)TimeBox.SelectedItem);
                GameGui gui = new GameGui(10, 300, 300, 100);
                gui.Show();
                
            } 
            else
            {
                MessageBox.Show("Значения должны быть присвоены");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

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
