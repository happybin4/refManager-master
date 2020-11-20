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
    public partial class AddRecipe : Form
    {
        recipeDB db = new recipeDB();
        RecipeItems items;
        public AddRecipe()
        {
            InitializeComponent();
        }

        private void btnAddRItem_Click(object sender, EventArgs e)
        {
            if(txtRecName.Text.Length < 1)
            {
                MessageBox.Show("레시피 명을 입력해주세요");
            }
            else if(txtRecipe.Text.Length < 1)
            {
                MessageBox.Show("레시피 방법을 입력하세요");
            }
            else
            {
                if (MessageBox.Show($"{txtRecName.Text}에 재료를 추가하시겠습니까?", "삭제확인", MessageBoxButtons.OKCancel)
                   == DialogResult.OK)
                {
                    items.recipeName = txtRecName.Text;
                    items.recipe = txtRecipe.Text;
                    db.AddRecipe(items);
                    AddRecipe frm = new AddRecipe();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("레시피 재료 추가를 취소하였습니다");
                    return;
                }
            }
        }
    }
}
