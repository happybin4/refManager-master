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
    public partial class MyRef : Form
    {
        ItemDB items = new ItemDB();        
        Items it;
        int leftct=0;
        int leftat=0;
        int gat=0;
        string refName;
        public MyRef()
        {
            InitializeComponent();
        }

        private void 냉장고추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefManager addref = new RefManager();
            addref.ShowDialog();
        }

        private void 품목추가ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddItem frm = new AddItem();
            frm.ShowDialog();
        }

        private void 품목수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateItem frm = new UpdateItem();
            frm.ShowDialog();
        }

        private void MyRef_Load(object sender, EventArgs e)
        {
            
            string[] codes = { "A100", "B100" };
            DataSet ds = items.GetCommonCode(codes);
            CommonUtil.BindingComboBox(cbItemType, ds.Tables["A100"], "codeID", "codeName");

            //refItemID, itemID, refID, amount, count, leftCount, stoPlace, dDay
            //품목명, 냉장고명, 남은갯수, 남은용량 ,저장장소, 
            CommonUtil.SetInitGridView(dgvRefitems);
            CommonUtil.AddGridTextColumn(dgvRefitems, "id", "refItemID", 35);
            CommonUtil.AddGridTextColumn(dgvRefitems, "품목명", "itemName", 100);
            CommonUtil.AddGridTextColumn(dgvRefitems, "냉장고명", "refName", 100);
            CommonUtil.AddGridTextColumn(dgvRefitems, "저장장소", "stoPlace", 80);
            CommonUtil.AddGridTextColumn(dgvRefitems, "남은갯수", "leftCount", 80);
            CommonUtil.AddGridTextColumn(dgvRefitems, "개당 용량", "amount", 80);
            CommonUtil.AddGridTextColumn(dgvRefitems, "남은용량", "leftAmount", 80);
            CommonUtil.AddGridTextColumn(dgvRefitems, "용량 단위", "ItemUnit", 80);
            CommonUtil.AddGridTextColumn(dgvRefitems, "품목타입", "itemType", 100);
            CommonUtil.AddGridTextColumn(dgvRefitems, "d-Day", "dDay", 80);

            DataLoad();
        }
        private void DataLoad()
        {
            ItemDB db = new ItemDB();
            DataSet ds = db.GetAll();
            db.Dispose();
            dgvRefitems.DataSource = ds.Tables["refItems"].DefaultView;
        }

        private void btnTypeSE_Click(object sender, EventArgs e)
        {
            ItemDB db = new ItemDB();
            DataSet ds = db.GetAll(cbItemType.Text);
            db.Dispose();
            dgvRefitems.DataSource = ds.Tables["typeItems"].DefaultView;
        }

        private void dgvRefitems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //i.itemName, r.refName, stoPlace, leftCount, amount,leftAmount, ItemUnit

            lblUnit.Text = dgvRefitems["ItemUnit", e.RowIndex].Value.ToString();
            txtName.Text = dgvRefitems["itemName", e.RowIndex].Value.ToString();
            cbItemType.Text = dgvRefitems["itemType", e.RowIndex].Value.ToString();
            txtName.Tag = dgvRefitems["refItemID", e.RowIndex].Value.ToString();
            lblUnit.Text = dgvRefitems["ItemUnit", e.RowIndex].Value.ToString();
            leftct = Convert.ToInt32(dgvRefitems["leftCount", e.RowIndex].Value); //남은 갯수
            leftat = Convert.ToInt32(dgvRefitems["leftAmount", e.RowIndex].Value); //남은 용량
            gat = Convert.ToInt32(dgvRefitems["amount", e.RowIndex].Value); //개당 용량
            refName = dgvRefitems["refName", e.RowIndex].Value.ToString();

        }

        private void btnWaste_Click(object sender, EventArgs e)
        {
            ItemDB db = new ItemDB();
            
            if(txtName.Text.Length  < 1 || cbItemType.Text.Length < 1)
            {
                MessageBox.Show("소비할 품목을 선택하세요");
                return;
            }
            else if(rbCount.Checked == false && rbAmount.Checked == false)
            {
                MessageBox.Show("소비할 방법을 선택하여 갯수 또는 용량을 입력하세요");
                return;
            }
            //leftct = 현재갯수, leftat = 현재용량, gat = 개당갯수
            else if(rbCount.Checked) //갯수로 소비
            {
                int ct = Convert.ToInt32(numCount.Value); //소비할 갯수
                if (numCount.Value < 1)
                {
                    MessageBox.Show("0보다 큰수를 선택해주세요");                    
                    return;
                }
                else
                {
                    string del = "";
                    int rItemID = Convert.ToInt32(txtName.Tag);                    
                    it.refItemID = rItemID; //아이템 아이디
                    if (ct > leftct)
                    {
                        MessageBox.Show("현재 갯수보다 더 적은 갯수를 소비해주세요");
                        return;
                    }
                    else if (ct == leftct)
                    {
                        items.DeleteItem(rItemID);
                        db.Dispose();
                        del = " 남은 갯수를 전부 소비하였습니다";
                    }
                    else if (leftat%gat == 0) //남은용량이 개당용량으로 나눈 나머지가 0일때
                    {
                        it.leftAmount = leftat - (ct * gat); //용량은 소비전용량 - (소비할 갯수*개당용량)
                        it.leftCount = leftct - ct; //갯수는 현재 갯수 - 소비할 갯수                        
                        items.WasteItem(it);
                        db.Dispose();
                    }
                    else // 남은용량이 개당용량으로 나눈 나머지가 0이 아닐떄
                    {
                        it.leftAmount = ((ct - 1) * gat) + (leftat % gat); // ((소비갯수-1)*개당용량) + 소비전용량%개당용량
                        it.leftCount = leftct - ct; //갯수는 현재 갯수 - 소비할 갯수                       
                        items.WasteItem(it);
                        db.Dispose();
                    }
                    MessageBox.Show($"{txtName.Text} {ct}개를 {refName}에서 꺼냈습니다{del}.");
                    cbItemType.Text = "";
                    txtName.Text = "";
                    rbCount.Checked = false;
                    DataLoad();
                }
            }
            else if (rbAmount.Checked)
            {
                int at = int.Parse(txtAmount.Text); //소비할 용량
                if(txtAmount.Text.Length < 1)
                {
                    MessageBox.Show("소비할 용량을 적어주세요");
                    return;
                }
                else
                {
                    string del = "";
                    int rItemID = Convert.ToInt32(txtName.Tag);
                    it.refItemID = rItemID; //아이템 아이디
                    int sbhat = leftat - at;
                    if (at > leftat)
                    {
                        MessageBox.Show("남은 용량보다 적은 용량을 적어주세요");
                        return;
                    }
                    else if (at == leftat)
                    {
                        items.DeleteItem(rItemID);
                        db.Dispose();
                        del = "남은 용량을 전부 소비하였습니다";                        
                    }
                    else if(sbhat % gat == 0)//남은용량이 개당용량으로 나눈 나머지가 0일때
                    {
                        it.leftCount = (leftat - at) / gat; // 남은 갯수 = (소비전용량- 소비할 용량)/개당용량
                        it.leftAmount = leftat - at; //남은용량 = 소비전용량 - 소비할 용량                        
                        items.WasteItem(it);
                        db.Dispose();
                    }
                    else// 남은용량이 개당용량으로 나눈 나머지가 0이 아닐떄
                    {
                        it.leftCount = ((leftat - at) / gat)+1; // 남은 갯수 = ((소비전용량- 소비할 용량)/개당용량)+1
                        it.leftAmount = leftat - at; //남은용량 = 소비전용량 - 소비할 용량                        
                        items.WasteItem(it);
                        db.Dispose();
                    }
                    MessageBox.Show($"{txtName.Text} {at}{lblUnit.Text}를 {refName}에서 꺼냈습니다{del}.");
                    cbItemType.Text = "";
                    txtName.Text = "";
                    rbAmount.Checked = false;
                    DataLoad();
                }
            }
            

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void rbAmount_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCount.Checked)            
                countPanel.Visible = true;                
            else
                countPanel.Visible = false;

            if(rbAmount.Checked)
                amountPanel.Visible = true;
            else
                amountPanel.Visible = false;                     
        }
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))) //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void dgvRefitems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvRefitems.Rows)
                if (Convert.ToInt32(row.Cells[9].Value) <= 5)
                {
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
        }

        private void 품목추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 레시피추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRecipe frm = new AddRecipe();
            frm.ShowDialog();
        }
    }
}
