using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.IO;

namespace refManager
{
    public partial class RefManager : Form
    {
        
        public RefManager()
        {        
            InitializeComponent();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Length > 0)
                {
                    Ref myref=new Ref();
                    myref.refName = txtName.Text;
                    myref.refSize = Convert.ToInt32(txtSize.Text);

                    refDB myrefs = new refDB();
                    myrefs.Insert(myref);
                    DataLoad();
                    myrefs.Dispose();
                }
                else
                {
                    MessageBox.Show("냉장고명을 입력하세요");
                    return;
                }

                MessageBox.Show($"{txtName.Text}이 추가되었습니다");
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void RefManager_Load(object sender, EventArgs e)
        {            
            CommonUtil.SetInitGridView(dgvRef);
            CommonUtil.AddGridTextColumn(dgvRef, "ID", "refID", 30);
            CommonUtil.AddGridTextColumn(dgvRef, "냉장고명", "refName", 100);
            CommonUtil.AddGridTextColumn(dgvRef, "용량", "refSize", 100);

            DataLoad();
           
        }

        private void DataLoad()
        {
            refDB db = new refDB();
            DataSet ds = db.GetAll();
            db.Dispose();
            dgvRef.DataSource = ds.Tables["ref"].DefaultView;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            refDB db = new refDB();
            DataTable dt = db.SearchData(txtName.Text);
            db.Dispose();
            dgvRef.DataSource = dt;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(lblRefID.Text.Trim().Length == 0)
            {
                MessageBox.Show("수정할 내용을 선택하세요");
                return;
            }
            else if(txtName.Text.Length <1 || txtSize.Text.Length < 1)
            {
                MessageBox.Show("수정할 내용을 입력하세요");
                return;
            }
            
            if(!int.TryParse(txtSize.Text,out int size))
            {
                MessageBox.Show("용량은 숫자를 입력해주세요");
                return;
            }

            
            
            Ref myref;
            myref.refID = int.Parse(lblRefID.Text);
            myref.refName = txtName.Text;
            myref.refSize = int.Parse(txtSize.Text);
            refDB db = new refDB();
            try
            {               
                db.update(myref);
                db.Dispose();

                DataLoad();
                MessageBox.Show($"냉장고번호가 {myref.refID}인 냉장고가 수정되었습니다");
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dgvRef_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //refID, refName, refSize
            
            lblRefID.Text = dgvRef["refID", e.RowIndex].Value.ToString();
            txtName.Text = dgvRef["refName", e.RowIndex].Value.ToString();
            txtSize.Text = dgvRef["refSize", e.RowIndex].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 삭제하시겠습니까", "삭제확인", MessageBoxButtons.OKCancel)
                == DialogResult.OK)
            {

                try
                {
                    if (lblRefID.Text.Length < 1)
                    {
                        MessageBox.Show("삭제할 냉장고를 선택하세요");
                    }
                    Ref myref = new Ref();
                    myref.refID = int.Parse(lblRefID.Text);
                    refDB db = new refDB();
                    db.delete(myref);

                    MessageBox.Show($"냉장고번호가 {myref.refID}인 냉장고가 삭제되었습니다.");
                    DataLoad();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else
            {
                MessageBox.Show("삭제를 취소하셨습니다.");
                return;
            }
        }
    }

}
