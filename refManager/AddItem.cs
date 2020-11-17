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

        //품목 타입 콤보박스
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
            cbItemName.Tag = cbItemName.SelectedValue;
            //itemID, itemName 

        }
        //품목명 콤보박스
        private void cbItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtItemName.Text = cbItemName.Text;
            cbItemName.Tag = cbItemName.SelectedValue;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (rbRef1.Checked)
            {
                it.stoPlace = rbRef1.Text;
                rbCheck = true;
            }
            else if (rbRef2.Checked)
            {
                it.stoPlace = rbRef2.Text;
                rbCheck = true;
            }
            else
            {
                rbCheck = false;
            }

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
                // itemID, refID, amount, count, leftCount, stoPlace, dDay
                try
                {
                    it.itemID = Convert.ToInt32(cbItemName.Tag);
                    it.refID = Convert.ToInt32(cbRefName.Tag);
                    it.amount = int.Parse(txtAmount.Text);
                    it.count = int.Parse(txtNum.Text);
                    it.leftCount = int.Parse(txtNum.Text);
                    it.dDay = dtpDday.Value.Date;
                    it.leftAmount = it.amount * it.count;
                    it.itemUnit = cbAmountType.Text;
                    ItemDB idb = new ItemDB();
                    idb.InsertItem(it);
                    idb.Dispose();
                    MessageBox.Show($"{txtItemName.Text} {txtAmount.Text}{cbAmountType.Text} " +
                        $"{txtNum.Text}개를 {cbRefName.Text}에 넣었습니다");
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }

        }
        //냉장고명 콤보박스
        private void cbRefName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRefName.Tag = cbRefName.SelectedValue;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {

        }
    }
}
