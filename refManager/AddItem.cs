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
    public partial class AddItem : Form
    {
        Items it;
        ItemDB items = new ItemDB();
        bool rbCheck = false;
        public AddItem()
        {
            InitializeComponent();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            string[] codes = { "A100", "B100"};
            
            DataSet ds = items.GetCommonCode(codes);
            DataSet ds2 = items.GetRefName();
           

            CommonUtil.BindingComboBox(cbRefName, ds2.Tables[0], "refID", "refName");
            CommonUtil.BindingComboBox(cbItemType, ds.Tables["A100"], "codeID", "codeName");
            CommonUtil.BindingComboBox(cbAmountType, ds.Tables["B100"], "codeID", "codeName");
        }

        private void cbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbItemType.SelectedIndex > 0)
            {
                string itype = cbItemType.Text;
                txtItmeType.Text = itype;
                it.itemType = itype;
                DataSet ds = items.GetItemName(itype);
                CommonUtil.BindingComboBox(cbItemName, ds.Tables[0], "itemID", "itemName");
            }
            else
            {
                cbItemName.DataSource = null;
            }                        
            //itemID, itemName 
            
        }

        private void cbItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtItemName.Text = cbItemName.Text;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            //sb.AppendLine("학번은 10자리로 입력하세요.");
            if (cbRefName.Text.Length < 1)
            {
                sb.AppendLine("냉장고를 선택하세요");
            }
            if (txtItmeType.Text.Length <1)
            {
                sb.AppendLine("품목종류를 선택하세요");
            }
            if (txtItemName.Text.Length < 1)
            {
                sb.AppendLine("품목명을 선택하세요");
            }
            if(rbCheck == false)
            {
                sb.AppendLine("저장장소를 고르세요");
            }
            if (txtNum.Text.Length < 1)
            {
                sb.AppendLine("갯수를 작성하세요");
            }else if(int.TryParse(txtNum.Text,out int num) == false)
            {
                sb.AppendLine("갯수칸에는 숫자만 입력하세요");
            }

            if(sb.Length > 0)
            {
                MessageBox.Show(sb.ToString());
            }
            else
            {

            }
            
           
        }

        private void rbRef1_CheckedChanged(object sender, EventArgs e)
        {
            rbCheck = true;
            if (rbRef1.Checked)
            {
                it.stoPlace = rbRef1.Text;
            }
            
        }

        private void rbRef2_CheckedChanged(object sender, EventArgs e)
        {
            rbCheck = true;
            if (rbRef2.Checked)
            {
                it.stoPlace = rbRef2.Text;
            }
        }
    }
}
