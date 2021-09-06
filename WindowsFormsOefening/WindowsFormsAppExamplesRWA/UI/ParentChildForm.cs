using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppExamplesRWA.Model;

namespace WindowsFormsAppExamplesRWA
{
    public partial class ParentChildForm : Form
    {
        // DAL = Data Access Layer (vertaal-laag Classes <-> Tabellen)
        DAL ThisDAL = new DAL();

        public ParentChildForm()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ThisDAL.PopulateModelLocally();
            refresh_DataGridParent();
            initItemsParent();
            refresh_DataGridChild();
            initItemsChild();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            ThisDAL.PopulateModelFromDB();

            refresh_DataGridParent();
            initItemsParent();
            refresh_DataGridChild();
            initItemsChild();
        }

        // PARENTCLASS DataGrid
        private void refresh_DataGridParent()
        {
            // Definieer de DataGrid kolommen
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Status", typeof(string));
            // Vul de rijen
            for (int i = 0; i < ThisDAL.ParentClassList.Count; i++)
            {
                table.Rows.Add(ThisDAL.ParentClassList[i].Id
                              , ThisDAL.ParentClassList[i].Name
                              , ThisDAL.ParentClassList[i].Status
                              );
            }
            dataGridViewParent.DataSource = table;
            dataGridViewParent.Refresh();
        }
        private void initItemsParent()
        {
            try
            {
                textBoxParentId.Text = dataGridViewParent[0, 0].Value.ToString();
                textBoxParentName.Text = dataGridViewParent[1, 0].Value.ToString();
                textBoxParentStatus.Text = dataGridViewParent[2, 0].Value.ToString();
            }
            catch
            {
            }
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBoxParentId.Text = dataGridViewParent[0, e.RowIndex].Value.ToString();
                textBoxParentName.Text = dataGridViewParent[1, e.RowIndex].Value.ToString();
                textBoxParentStatus.Text = dataGridViewParent[2, e.RowIndex].Value.ToString();
                refresh_DataGridChild();
                initItemsChild();
            }
            catch
            {
            }
        }

        // CHILDCLASS en SUBCLASS DataGrid
        private void refresh_DataGridChild()
        {
            int RowNum = dataGridViewParent.CurrentCell.RowIndex;
            // Definieer de DataGrid kolommen
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("ExtraAtribute", typeof(string));
            table.Columns.Add("ParentId", typeof(int)); // <<-- ChildClass referentie vanuit Parent
            // Vul de rijen
            foreach (ChildClass child in ThisDAL.ParentClassList[RowNum].ListOfChildClasses)
            {
                if (child is SubClass)
                {
                    SubClass subChild = (SubClass) child;
                    table.Rows.Add(subChild.Id, subChild.Name, subChild.ExtraAttribute, subChild.TheParent.Id);
                }
                else
                {
                    table.Rows.Add(child.Id, child.Name, string.Empty, child.TheParent.Id);
                }
                
            }
            /*
            for (int i = 0; i < ThisDAL.ParentClassList[RowNum].ListOfChildClasses.Count; i++)
            {
                table.Rows.Add( ThisDAL.ParentClassList[RowNum].ListOfChildClasses[i].Id
                              , ThisDAL.ParentClassList[RowNum].ListOfChildClasses[i].Name
                              , string.Empty
                              , ThisDAL.ParentClassList[RowNum].ListOfChildClasses[i].TheParent.Id // <<-- Lichtknop referentie vanuit Lamp
                              );
            }
            */
            dataGridViewChild.DataSource = table;
            dataGridViewChild.Refresh();
        }
        private void initItemsChild()
        {
            try
            {
                textChildId.Text = dataGridViewChild[0, 0].Value.ToString();
                textChildName.Text = dataGridViewChild[1, 0].Value.ToString();
                textBoxSubclassAttribute.Text = dataGridViewChild[2, 0].Value.ToString();
            }
            catch
            {
                textChildId.Clear();
                textChildName.Clear();
                textBoxSubclassAttribute.Clear();
            }
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textChildId.Text = dataGridViewChild[0, e.RowIndex].Value.ToString();
                textChildName.Text = dataGridViewChild[1, e.RowIndex].Value.ToString();
                textBoxSubclassAttribute.Text = dataGridViewChild[2, e.RowIndex].Value.ToString();
            }
            catch
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThisDAL.InsertParent(textBoxParentName.Text, textBoxParentStatus.Text);
            RefreshData();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ThisDAL.UpdateParent(Int32.Parse(textBoxParentId.Text), textBoxParentName.Text, textBoxParentStatus.Text);
            RefreshData();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ThisDAL.DeleteParent(Int32.Parse(textBoxParentId.Text));
            RefreshData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ThisDAL.InsertChild( Int32.Parse(textBoxParentId.Text), textChildName.Text, textBoxSubclassAttribute.Text);
            RefreshData();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            ThisDAL.UpdateChild(Int32.Parse(textChildId.Text), textChildName.Text, textBoxSubclassAttribute.Text);
            RefreshData();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            ThisDAL.DeleteChild(Int32.Parse(textChildId.Text));
            RefreshData();
        }

        private void SearchButton1_Click(object sender, EventArgs e)
        {
            ThisDAL.SearchDataInDB(textBoxParentName.Text, textChildName.Text);

            refresh_DataGridParent();
            initItemsParent();
            refresh_DataGridChild();
            initItemsChild();
        }

        private void SearchButton2_Click(object sender, EventArgs e)
        {
            // Definieer de DataGrid kolommen
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Status", typeof(string));
            // Vul de rijen
            for (int i = 0; i < ThisDAL.ParentClassList.Count; i++)
            {
                if ( textBoxParentName.Text == ThisDAL.ParentClassList[i].Name
                  || textBoxParentName.Text.Contains(ThisDAL.ParentClassList[i].Name)
                  || ThisDAL.ParentClassList[i].Name.Contains(textBoxParentName.Text)
                   )
                {
                    table.Rows.Add( ThisDAL.ParentClassList[i].Id
                                  , ThisDAL.ParentClassList[i].Name
                                  , ThisDAL.ParentClassList[i].Status
                                  );
                }
            }
            dataGridViewParent.DataSource = table;
            dataGridViewParent.Refresh();

            int RowNum = dataGridViewParent.CurrentCell.RowIndex;
            // Definieer de DataGrid kolommen
            table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("ExtraAtribute", typeof(string));
            table.Columns.Add("ParentId", typeof(int)); // <<-- ChildClass referentie vanuit Parent
            // Vul de rijen
            foreach (ChildClass child in ThisDAL.ParentClassList[RowNum].ListOfChildClasses)
            {
                if ( textChildName.Text == child.Name
                  || textChildName.Text.Contains(child.Name)
                  || child.Name.Contains(textChildName.Text)
                   )
                {
                    if (child is SubClass)
                    {
                        SubClass subChild = (SubClass)child;
                        table.Rows.Add(subChild.Id, subChild.Name, subChild.ExtraAttribute, subChild.TheParent.Id);
                    }
                    else
                    {
                        table.Rows.Add(child.Id, child.Name, string.Empty, child.TheParent.Id);
                    }
                }
            }
            dataGridViewChild.DataSource = table;
            dataGridViewChild.Refresh();
        }

    }
}
