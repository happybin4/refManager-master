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
            DataSet ds = db.GetAll();
            db.Dispose();
            dgvUpdateItems.DataSource = ds.Tables["refItems"].DefaultView;
        }

        private void dgvUpdateItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRefName.Text = dgvUpdateItems["refName", e.RowIndex].Value.ToString();
            txtItmeType.Text = dgvUpdateItems["itemType", e.RowIndex].Value.ToString();
            txtItemName.Text = dgvUpdateItems["itemName", e.RowIndex].Value.ToString();
            cbRefName.SelectedText = dgvUpdateItems["refName", e.RowIndex].Value.ToString();           
            cbItemType.SelectedText = dgvUpdateItems["itemType", e.RowIndex].Value.ToString();           
            cbItemName.SelectedText = dgvUpdateItems["itemName", e.RowIndex].Value.ToString();
            if (dgvUpdateItems["stoPlace", e.RowIndex].Value.ToString() == "냉장")            
                rbRef1.Select();            
            else            
                rbRef2.Select();            
            txtNum.Text = dgvUpdateItems["leftCount", e.RowIndex].Value.ToString();
            txtAmount.Text = dgvUpdateItems["leftAmount", e.RowIndex].Value.ToString();
            cbAmountType.SelectedText = dgvUpdateItems["ItemUnit", e.RowIndex].Value.ToString();
            dtpDday.Value = Convert.ToDateTime(dgvUpdateItems["dDay", e.RowIndex].Value.ToString());

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
            cbItemName.Tag = cbItemName.SelectedValue;
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

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
