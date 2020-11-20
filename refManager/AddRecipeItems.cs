using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace refManager
{
    public partial class AddRecipeItems : Form
    {
        recipeDB items = new recipeDB();

        public AddRecipeItems()
        {
            InitializeComponent();
        }

        private void AddRecipeItems_Load(object sender, EventArgs e)
        {

        }
    }
}
