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
    public partial class UpdateItem : Form
    {
        Items it;
        ItemDB items = new ItemDB();
        bool bChecked = false;
        public UpdateItem()
        {
            InitializeComponent();
        }

        private void UpdateItem_Load(object sender, EventArgs e)
        {
            string[] codes = { "A100", "B100" };

            DataSet ds = items.GetCommonCode(codes);
            DataSet ds2 = items.GetRefName();

            CommonUtil.BindingComboBox(cbRefName, ds2.Tables[0], "refID", "refName");
            CommonUtil.BindingComboBox(cbItemType, ds.Tables["A100"], "codeID", "codeName");
            CommonUtil.BindingComboBox(cbAmountType, ds.Tables["B100"], "codeID", "codeName");

            //refItemID, itemID, refID, amount, count, leftCount, stoPlace, dDay
            //품목명, 냉장고명, 남은갯수, 남은용량 ,저장장소, 
            CommonUtil.SetInitGridView(dgvUpdateItems);
            CommonUtil.AddGridTextColumn(dgvUpdateItems, "id", "refItemID", 35);
            CommonUtil.AddGridTextColumn(dgvUpdateItems, "품목명", "itemName", 100);
            CommonUtil.AddGridTextColumn(dgvUpdateItems, "냉장고명", "refName", 100);
            CommonUtil.AddGridTextColumn(dgvUpdateItems, "저장장소", "stoPlace", 80);
            CommonUtil.AddGridTextColumn(dgvUpdateItems, "남은갯수", "leftCount", 80);
            CommonUtil.AddGridTextColumn(dgvUpdateItems, "개당 용량", "amount", 80);
            CommonUtil.AddGridTextColumn(dgvUpdateItems, "남은용량", "leftAmount", 80);
            CommonUtil.AddGridTextColumn(dgvUpdateItems, "용량 단위", "ItemUnit", 80);
            CommonUtil.AddGridTextColumn(dgvUpdateItems, "품목타입", "itemType", 100);
            CommonUtil.AddGridTextColumn(dgvUpdateItems, "유통기한", "dDay", 100);

            DataLoad();
        }

        private void DataLoad()
        {
            ItemDB db = new ItemDB();
            DataSet ds = db.GetAllUpDateItems();
            db.Dispose();
            dgvUpdateItems.DataSource = ds.Tables["refItems"].DefaultView;
        }

        private void dgvUpdateItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            cbRefName.Text = "";
            cbItemType.Text = "";
            cbItemName.Text = "";
            cbAmountType.Text = "";
            txtID.Text = dgvUpdateItems["refItemID", e.RowIndex].Value.ToString();
            txtRefName.Text = dgvUpdateItems["refName", e.RowIndex].Value.ToString();
            txtItmeType.Text = dgvUpdateItems["itemType", e.RowIndex].Value.ToString();
            txtItemName.Text = dgvUpdateItems["itemName", e.RowIndex].Value.ToString();            
            //cbRefName.SelectedText = dgvUpdateItems["refName", e.RowIndex].Value.ToString();
            cbRefName.SelectedIndex = cbRefName.FindStringExact(dgvUpdateItems["refName", e.RowIndex].Value.ToString());
            //cbItemType.SelectedText = dgvUpdateItems["itemType", e.RowIndex].Value.ToString();
            //cbItemType.SelectedIndex = 3;
            cbItemType.SelectedIndex = cbItemType.FindStringExact(dgvUpdateItems["itemType", e.RowIndex].Value.ToString());
            cbItemName.SelectedIndex = cbItemName.FindStringExact(dgvUpdateItems["itemName", e.RowIndex].Value.ToString());
            //cbItemName.SelectedText = dgvUpdateItems["itemName", e.RowIndex].Value.ToString();
            if (dgvUpdateItems["stoPlace", e.RowIndex].Value.ToString() == "냉장")            
                rbRef1.Select();            
            else            
                rbRef2.Select();            
            txtNum.Text = dgvUpdateItems["leftCount", e.RowIndex].Value.ToString();
            txtAmount.Text = dgvUpdateItems["amount", e.RowIndex].Value.ToString();
            cbAmountType.SelectedText = dgvUpdateItems["ItemUnit", e.RowIndex].Value.ToString();
            dtpDate.Value = Convert.ToDateTime(dgvUpdateItems["dDay", e.RowIndex].Value.ToString());

        }

        private void cbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbItemType.SelectedIndex > 0)
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
            cbItemName.Tag = cbItemName.SelectedValue;
        }

        private void cbRefName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRefName.Text = cbRefName.Text;
            cbRefName.Tag = cbRefName.SelectedValue;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (rbRef1.Checked)
            {
                it.stoPlace = "냉장";
                bChecked = true;
            }
            else if (rbRef2.Checked)
            {
                it.stoPlace = "냉동";
                bChecked = true;
            }
            else
                bChecked = false;

            StringBuilder sb = new StringBuilder();
            if(txtID.Text.Length < 1)
            {
                sb.AppendLine("품목을 더블클릭하여 선택하세요");
            }
            if (cbRefName.Text.Length < 1)
            {
                sb.AppendLine("냉장고를 선택하세요");
            }
            if (txtItmeType.Text.Length < 1)
            {
                sb.AppendLine("품목종류를 선택하세요");
            }
            if (txtItemName.Text.Length < 1)
            {
                sb.AppendLine("품목명을 선택하세요");
            }
            if (bChecked == false)
            {
                sb.AppendLine("저장장소를 고르세요");
            }
            if (txtNum.Text.Length < 1)
            {
                sb.AppendLine("갯수를 작성하세요");
            }
            else if (int.TryParse(txtNum.Text, out int num) == false)
            {
                sb.AppendLine("갯수칸에는 숫자만 입력하세요");
            }

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString());
                return;
            }
            else
            {
                try
                {
                    //refItemID, itemID, refID, amount, count, leftCount, stoPlace, dDay 
                    ItemDB db = new ItemDB();
                    it.refItemID = Convert.ToInt32(txtID.Text);
                    it.itemID = Convert.ToInt32(cbItemName.Tag);
                    it.refID = Convert.ToInt32(cbRefName.Tag);
                    it.amount = int.Parse(txtAmount.Text);
                    it.leftCount = int.Parse(txtNum.Text);
                    it.leftAmount = it.amount * it.leftCount;                    
                    it.itemUnit = cbAmountType.Text;
                    it.dDay = dtpDate.Value.Date;
                    db.UpdateItems(it);
                    MessageBox.Show($"{txtID.Text}를 수정하였습니다");
                    db.Dispose();
                    DataLoad();
                    txtClear();
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Length < 1)
                {
                    MessageBox.Show("삭제할 품목을 다시 선택해주세요");
                    return;
                }
                else
                {
                    if (MessageBox.Show($"정말로 ID : {txtID.Text}을 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.OKCancel)
                    == DialogResult.OK)
                    {
                        ItemDB db = new ItemDB();
                        int uitemID = Convert.ToInt32(txtID.Text);
                        db.DeleteItem(uitemID);
                        MessageBox.Show($"{txtID.Text}가 냉장고에서 삭제되었습니다.");
                        db.Dispose();
                        DataLoad();
                        txtClear();
                    }
                    else
                    {
                        MessageBox.Show("삭제를 취소하셨습니다.");
                        return;
                    }
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
           
            
            //ItemDB db = new ItemDB();
            //int uitemID = Convert.ToInt32(txtItemName.Tag);
            

        }

        private void txtClear()
        {
            txtID.Clear();
            txtItemName.Clear();
            txtItmeType.Clear();
            txtAmount.Clear();
            txtNum.Clear();
            txtRefName.Clear();
            cbRefName.Text = "";
            cbItemType.Text = "";
            cbItemName.Text = "";
            cbAmountType.Text = "";
            dtpDate.Value = DateTime.Now;
        }

        private void rbRef2_CheckedChanged(object sender, EventArgs e)
        {
                        
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
