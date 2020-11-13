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
        List<int> list = new List<int>();
        Items it;
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
            txtType.Text = dgvRefitems["itemType", e.RowIndex].Value.ToString();
            txtName.Tag = dgvRefitems["refItemID", e.RowIndex].Value.ToString();
            string lc = dgvRefitems["leftCount", e.RowIndex].Value.ToString(); //남은 갯수
            string la = dgvRefitems["leftAmount", e.RowIndex].Value.ToString(); //남은 용량
            string ga = dgvRefitems["amount", e.RowIndex].Value.ToString(); //개당 용량
            
            list.Add(int.Parse(lc)); //0
            list.Add(int.Parse(la)); //1
            list.Add(int.Parse(ga)); //2
            

        }

        private void txtCount_Leave(object sender, EventArgs e)
        {
            
            if (list[1]%list[2] != 0)
            {
                if(list[0] == int.Parse(txtCount.Text))
                {
                    txtAmount.Text = list[1].ToString();
                }
                else if(int.Parse(txtCount.Text) < list[0])
                {
                    txtAmount.Text = (int.Parse(txtCount.Text) * list[2]).ToString();
                }
            }
            else
            {
                txtAmount.Text = (int.Parse(txtCount.Text) * list[2]).ToString();
            }          
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            int ct = 0;
            if (list[1] % list[2] != 0)
            {
                if (list[2] < int.Parse(txtAmount.Text))
                {
                    ct = int.Parse(txtAmount.Text) / list[2];
                }
                else if(list[1]-((list[0]-1)*list[2]) < int.Parse(txtCount.Text))
                {
                    ct = 1;
                    txtCount.Text = ct.ToString();
                }
                else
                {
                    txtCount.Text = ct.ToString();
                }
            }
            else
                txtCount.Text = ct.ToString();
        }

        private void btnWaste_Click(object sender, EventArgs e)
        {
            ItemDB db = new ItemDB();
            StringBuilder sb = new StringBuilder();
            if(txtName.Text.Length  < 1 || txtType.Text.Length < 1)
            {
                sb.AppendLine("소비할 품목을 선택하세요");
            }
            if(int.Parse(txtCount.Text) > list[0])
            {
                sb.AppendLine($"냉장고에 있는 갯수보다 많습니다 {list[0]}보다 적게 작성하세요");
            }
            if (int.Parse(txtAmount.Text) > list[1])
            {
                sb.AppendLine($"냉장고에 있는 용량보다 많습니다 {list[1]}보다 적게 작성하세요");
            }
            if(sb.Length > 0)
            {
                MessageBox.Show(sb.ToString());
            }
            else
            {
                //i.itemName, r.refName, stoPlace, leftCount, amount,leftAmount, ItemUnit
                if(int.Parse(txtCount.Text) == list[0])
                {
                    it.refItemID = Convert.ToInt32(txtName.Tag);
                    db.DeleteItem(it);
                }
                else
                {
                    it.refItemID = Convert.ToInt32(txtName.Tag);
                    it.leftCount = list[0] - int.Parse(txtCount.Text);
                    it.leftAmount = list[1] - int.Parse(txtAmount.Text);
                    db.WasteItem(it);
                    db.Dispose();
                }
            }
            DataLoad();

        }

        
    }
}
