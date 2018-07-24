/*  ============================================
**                  
**      GameGUI class uses LifeGame.cs to          
**      construct visual representation of game 
**      using Windows Forms and it's controls
**                  
**                  
**                  
**       created by Maxim Aslamov          
**       last change(dd/mm/yyyy): 23/07/2018
**  ============================================
*/

using System;
using System.Windows.Forms;
using System.Drawing;

namespace LifeGame
{
    public partial class GameGui : Form
    {

        //Game holder to be constructed
        private LifeGame game = null;
        //cell and canvas sizes
        private int cell_size;
        private int grid_size;
        private readonly Color _alive_cell_colour = Color.Green;
        private readonly Color _dead_cell_colour = Color.White;

        public int Grid_Size { get => grid_size; set => grid_size = value; }
        public int Cell_size { get => cell_size; set => cell_size = value; }

        public Color Alive_cell_colour => _alive_cell_colour;
        public Color Dead_cell_colour => _dead_cell_colour;

        public GameGui(int cellSize, int X_dim, int Y_dim, int time)
        {
            game = new LifeGame(X_dim, Y_dim, time);
            Cell_size = cellSize;
            Grid_Size = game.Y_Dim * game.X_Dim;
            InitializeComponent();

        }

        private void OnLoad_UI(object sender, EventArgs e)
        {
            timer.Interval = game.TimeInterval;
            for (int j = 0; j + Cell_size <= Grid_Size; j += Cell_size)
                for (int i = 0; i + Cell_size <= Grid_Size; i += Cell_size)
                {
                    Button button = new Button
                    {
                        Size = new Size(Cell_size, Cell_size),
                        Location = new Point(i, j)
                    };
                    button.Click += new EventHandler(OnCellClick);
                }
        }

        private void UpdateColours()
        {
            for (int lin_index = 0; lin_index < gridUI.Controls.Count; ++lin_index)
            {
                gridUI.Controls[lin_index].BackColor =
                    game[lin_index / game.X_Dim, lin_index % game.X_Dim] == 1 ? Alive_cell_colour : Dead_cell_colour;
            }
        }

        private void OnCellClick(object sender, EventArgs e)
        {
            int buttonIndex = gridUI.Controls.IndexOf(sender as Control);
            int y = buttonIndex / game.X_Dim;
            int x = buttonIndex % game.X_Dim;
            //updating game state
            game[y, x] = game[y, x] == 0 ? 1 : 0;
            ((Button)sender).BackColor = game[y, x] == 1 ? Alive_cell_colour : Dead_cell_colour;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            game.GetNextState();
            UpdateColours();
        }
    }


}
