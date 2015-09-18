using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrugBank;
using Google.API.Translate;
using Tiraggo.Core;
using Tiraggo.DynamicQuery;

namespace DrugBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSearchDrug.Font = new Font(txtSearchDrug.Font, FontStyle.Bold);
            
            //DrugbankCollection diC = new DrugbankCollection();
            ////diC.Query.SelectAll();
            //diC.LoadAll();
            //string translated = string.Empty;
            //foreach (Drugbank di in diC)
            //{
            //    //Translator tr = new Translator();
            //    //Drugbank DI = new Drugbank();
            //    //DI.LoadByPrimaryKey((int)di.WID);
            //    //translated = tr.Translate(di.Description, "English", "Indonesian");
            //    //DI.Description = translated;
            //    //DI.Save();
            //    //Drugbankindo d = new Drugbankindo();
            //    //if (d.LoadByPrimaryKey((int)di.WID))
            //    //{
            //    //    Translator tr = new Translator();
            //    //    d.Description = tr.Translate(di.Description, "English", "Indonesian");
            //        //if (!string.IsNullOrEmpty(di.Indication))
            //        //    d.Indication = tr.Translate(di.Indication, "English", "Indonesian");
            //        //if (!string.IsNullOrEmpty(di.Pharmacology))
            //        //    d.Pharmacology = tr.Translate(di.Pharmacology, "English", "Indonesian");
            //        //if (!string.IsNullOrEmpty(di.MechanismOfAction))
            //        //    d.MechanismOfAction = tr.Translate(di.MechanismOfAction, "English", "Indonesian");
            //        //if (!string.IsNullOrEmpty(di.Toxicity))
            //        //    d.Toxicity = tr.Translate(di.Toxicity, "English", "Indonesian");
            //        //if (!string.IsNullOrEmpty(di.Absorption))
            //        //    d.Absorption = tr.Translate(di.Absorption, "English", "Indonesian");
            //        //if (!string.IsNullOrEmpty(di.HalfLife))
            //        //    d.HalfLife = tr.Translate(di.HalfLife, "English", "Indonesian");
            //    //    d.Save();
            //    //}
            //    //diI.Drug = di.Drug;
            //    //diI.DrugbankWid = di.DrugbankWid;
            //    //diI.Description = tr.Translate(di.Description, "English", "Indonesian");
            //    //diI.Save();
            //}
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            //fillDrugListView(txtSearchDrug.Text);
            cmdSearch.Enabled = false;
            cmdSearch.Visible = false;
            try
            {
                fillDrugGridView(txtSearchDrug.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmdSearch.Enabled = true;
                cmdSearch.Visible = true;
            }       
        }        

        private void fillDrugGridView(string txtDrug)
        {
            if (string.IsNullOrEmpty(txtDrug))
            { }
            else
            {
                dgvDrugList.DataSource = null;
                DrugbankQuery dbQ = new DrugbankQuery("a");
                dbQ.Select(dbQ.Id,dbQ.WID ,dbQ.Name.As("DrugName"));
                dbQ.Where(dbQ.Id.Like("%" + txtDrug + "%") || dbQ.Name.Like("%" + txtDrug + "%"));
                //DrugbankCollection dbC = new DrugbankCollection();
                //dbC.Load(dbQ);
                //var item = lvDrugList.Items;
                //if (dbC.Count > 0)
                //{
                //    foreach (Drugbank db in dbC)
                //    {
                //        item.Add(db.Name);
                //    }
                //}
                dgvDrugList.DataSource = dbQ.LoadDataTable();
            }
        }

        private void LoadAllDrugData()
        {
            //lvDrugList.Items.Clear();
            ////BusinessObjects.Drugbank db = new BusinessObjects.Drugbank();
            ////BusinessObjects.DrugbankCollection dbC = new BusinessObjects.DrugbankCollection();
            ////dbC.LoadAll();     
            //DrugbankQuery dbQ = new DrugbankQuery("a");
            //DrugbankHasDrugbankcategoryQuery dbcQ = new DrugbankHasDrugbankcategoryQuery("b");

            //DrugbankCollection dbC = new DrugbankCollection();
            //dbC.LoadAll();
            ////string obatName = string.Empty;
            //var item = lvDrugList.Items;
            //foreach (Drugbank db in dbC)
            //{
            //    item.Add(db.Name);
            //}            
            ////MessageBox.Show(obatName);
        }

        private void dgvDrugList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvDrugList_SelectionChanged(object sender, EventArgs e)
        {
            cmdSearch.Enabled = false;
            dgvDrugList.Visible = false;
            string id = string.Empty;
            Int32 WID = 0;
            foreach (DataGridViewRow row in dgvDrugList.SelectedRows)
            {
                id = row.Cells[0].Value.ToString();
                WID = Convert.ToInt32(row.Cells[1].Value.ToString());
            }

            DrugbankdruginteractionQuery dbdiQ = new DrugbankdruginteractionQuery("a");
            DrugbankQuery dbQ = new DrugbankQuery("b");
            dbdiQ.Select(dbdiQ.DrugbankWid, dbdiQ.Drug, dbdiQ.Description, dbQ.Name.As("Names"));
            dbdiQ.InnerJoin(dbQ).On(dbdiQ.Drug == dbQ.WID);
            dbdiQ.Where(dbdiQ.DrugbankWid == WID);
            dbdiQ.OrderBy(dbQ.Name.Ascending);
            DataTable dtDI = dbdiQ.LoadDataTable();
            //dtDI.Columns.Add(new DataColumn("Deskripsi", typeof(string)));
            //if (dtDI.Rows.Count > 0)
            //{
            //    //foreach (DataRow dr in dtDI.Rows)
            //    //{
            //    //    Translator t = new Translator();
            //    //    dr["Deskripsi"] = t.Translate(dr["Description"].ToString().Trim(), Language.English, Language.Indonesian);
            //    //}
            //    for (int i = 0; i < dtDI.Rows.Count; i++)
            //    {
            //        Translator t = new Translator();
            //        dtDI.Rows[i]["Deskripsi"] = t.Translate(dtDI.Rows[i]["Description"].ToString().Trim(), "English", "Indonesian");
            //        dtDI.AcceptChanges();
            //    }
            //}
            dtDI.Columns.Remove("DrugBank_WID");
            dtDI.Columns.Remove("Drug");
            //dtDI.Columns.Remove("Description");
            dgvDrugInteraction.DataSource = dtDI;
            // ===================||====================
            //for Drug Information TabPage
            
            DrugbankQuery DBQ = new DrugbankQuery("a");
            DBQ.SelectAll().Where(DBQ.WID == WID && DBQ.Id == id);
            DataTable dtDB = DBQ.LoadDataTable();
            int counter = 0;
            if (dtDB.Rows.Count > 0)
            {
                rtbDrugInfo.Text = string.Empty;
                foreach (DataRow drDB in dtDB.Rows)
                {
                    counter++;
                    foreach (DataColumn dcDB in dtDB.Columns)
                    {   
                        rtbDrugInfo.Text = rtbDrugInfo.Text + dcDB.ColumnName + " : ";
                        rtbDrugInfo.Text = rtbDrugInfo.Text + Environment.NewLine;
                        rtbDrugInfo.Text = rtbDrugInfo.Text + "---------------------";
                        rtbDrugInfo.Text = rtbDrugInfo.Text + Environment.NewLine;
                        rtbDrugInfo.Text = rtbDrugInfo.Text + drDB[dcDB].ToString();
                        rtbDrugInfo.Text = rtbDrugInfo.Text + Environment.NewLine;
                        rtbDrugInfo.Text = rtbDrugInfo.Text + "_______________________________________________________________________________________________________________________________________";
                        rtbDrugInfo.Text = rtbDrugInfo.Text + Environment.NewLine;                        
                    }
                    if (counter >= 1)
                        continue;
                }
            }
            //
            cmdSearch.Enabled = true;
            dgvDrugList.Visible = true;
        }
    }
}
