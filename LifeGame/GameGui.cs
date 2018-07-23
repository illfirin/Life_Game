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
        //default colours
        private static readonly Color dead_cell_colour = Color.FromArgb(255, 0, 0, 0);
        private static readonly Color life_cell_colour = Color.White;
        //cell and canvas sizes
        private const int cell_size = 10;
        public static int Grid_Size { get; private set; }

        public GameGui()
        {
            InitializeComponent();
            LifeGame game = new LifeGame(80, 80);
            Grid_Size = game.Y_Dim * game.X_Dim;
        }

        private void OnLoad_UI(object sender, EventArgs e)
        {

        }

        private void OnCellClick(object sender, EventArgs e)
        {

        }

    }


}
