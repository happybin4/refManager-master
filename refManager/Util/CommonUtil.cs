﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace refManager
{
    public class CommonUtil
    {
        public static void BindingComboBox(ComboBox cbo, DataTable dt, string valueMember, string displayMember, bool blankItemAdd = true)
        {
            if (blankItemAdd)
            {
                DataRow dr = dt.NewRow();                
                dr[displayMember] = "";
                dt.Rows.InsertAt(dr, 0);
                dt.AcceptChanges();
            }

            
            cbo.DisplayMember = displayMember;
            cbo.DataSource = dt;
        }
        public static void SetInitGridView(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            dgv.AllowUserToAddRows = false;
            //dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public static void AddGridTextColumn(
                            DataGridView dgv,                            
                            string headerText,
                            string dataPropertyName,
                            int colWidth = 100,
                            bool visibility = true,
                            DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleLeft)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Name = dataPropertyName;
            col.HeaderText = headerText;
            col.DataPropertyName = dataPropertyName;            
            col.Width = colWidth;
            col.DefaultCellStyle.Alignment = textAlign;
            col.Visible = visibility;
            col.ReadOnly = true;

            dgv.Columns.Add(col);
        }
    }
}
