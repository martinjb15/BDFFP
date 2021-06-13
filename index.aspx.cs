using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BDFFP
{
    public partial class index : System.Web.UI.Page
    {
        public string SuggestionList = "";

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                if (SuggestionList.Length == 0)
            {
                string connetionString = "Server=abbey-tourplan;Database=abbey_tours_Ireland;User ID=tpwebuser;Password=cf5&web22";
                SqlConnection cnn = new SqlConnection(connetionString);
                string query = "select distinct  OPT.SUPPLIER, crm.NAME from opt left join crm on crm.code = opt.SUPPLIER ";
                using (SqlConnection connection = new SqlConnection(connetionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (string.IsNullOrEmpty(SuggestionList))
                                {
                                    SuggestionList += "\"" + reader["supplier"].ToString() + " - " + reader["name"].ToString() + "\"";
                                }
                                else
                                {
                                    SuggestionList += ", \"" + reader["supplier"].ToString() + " - " + reader["name"].ToString() + "\"";
                                }

                            }
                        }
                    }
                }
            }
            ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "auto()", true);
        }

            //if (!IsPostBack)

            //{

            //    //string type = Request.QueryString["type"];
            //    //TextBox11.Text = type;
            //    //string dbname = "";
            //    //dbname = Request.QueryString["db"];

            //    //if (dbname == "abbey_tours_Scotland")
            //    //{
            //    //    RadioButtonList1.Text = "0";
            //    //}
            //    //if (dbname == "abbey_tours_ireland")
            //    //{
            //    //    RadioButtonList1.Text = "1";
            //    //}
            //    //if (dbname == "M&K_ireland")
            //    //{
            //    //    RadioButtonList1.Text = "2";
            //    //}
            //    //string dbinstance = "";
            //    //dbinstance = "abbey-tourplan";
            //    //Session.Add("dbname", dbname);
            //    //Session.Add("dbinstance", dbinstance);


            //    //if (type != null)
            //    {

            //        //loaddetails(dbname, dbinstance);
            //        //optionLines(dbname, dbinstance);
            //        //optionLines2(dbname, dbinstance);
            //        //iframe(dbname, dbinstance);
            //        //loadGallery();
            //        //englishDescription(dbname, dbinstance);

            //    }
            //}
        }



        public void englishDescription(string dbname, string dbinstance)
        {
            string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password=cf5&web22";

            SqlConnection cnn = new SqlConnection(connetionString);

            //run query connected to dropdownlist
            string query = "select crm.CODE, nts.MESSAGE_TEXT from crm left join nts on crm.CODE = nts.SUPPLIER_CODE where nts.CATEGORY = 'sed'and BSL_ID = 0 and crm.code = '"
                + TextBox11.Text.ToString().Trim() +
                "'";

            cnn.Open();

            SqlCommand queryCommand = new SqlCommand(query, cnn);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            DataTable dataTable = new DataTable("AgentDetails");
            dataTable.Load(queryCommandReader);
            cnn.Close();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    //TextBox21.Text = rtfreturn(dr["MESSAGE_TEXT"].ToString().Trim());
                    collapse1.InnerText = rtfreturn(dr["MESSAGE_TEXT"].ToString().Trim());

                }
            }
            else
            {

            }
                //TextBox21.Text = string.Empty;

        }

        public void FrenchDescription(string dbname, string dbinstance)
        {
            string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password=cf5&web22";

            SqlConnection cnn = new SqlConnection(connetionString);

            //run query connected to dropdownlist
            string query = "select crm.CODE, nts.MESSAGE_TEXT from crm left join nts on crm.CODE = nts.SUPPLIER_CODE where nts.CATEGORY = 'sfr'and BSL_ID = 0 and crm.code = '"
                + TextBox11.Text.ToString().Trim() +
                "'";

            cnn.Open();

            SqlCommand queryCommand = new SqlCommand(query, cnn);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            DataTable dataTable = new DataTable("AgentDetails");
            dataTable.Load(queryCommandReader);
            cnn.Close();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    //TextBox23.Text = rtfreturn(dr["MESSAGE_TEXT"].ToString().Trim());

                    collapse3.InnerText = rtfreturn(dr["MESSAGE_TEXT"].ToString().Trim());
                }
            }
            else { }
                //TextBox23.Text = string.Empty;

        }

        public void GermanDescription(string dbname, string dbinstance)
        {
            string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password=cf5&web22";

            SqlConnection cnn = new SqlConnection(connetionString);

            //run query connected to dropdownlist
            string query = "select crm.CODE, nts.MESSAGE_TEXT from crm left join nts on crm.CODE = nts.SUPPLIER_CODE where nts.CATEGORY = 'sge'and BSL_ID = 0 and crm.code = '"
                + TextBox11.Text.ToString().Trim() +
                "'";

            cnn.Open();

            SqlCommand queryCommand = new SqlCommand(query, cnn);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            DataTable dataTable = new DataTable("AgentDetails");
            dataTable.Load(queryCommandReader);
            cnn.Close();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    //TextBox24.Text = rtfreturn(dr["MESSAGE_TEXT"].ToString().Trim());
                }
            }
            else { }
                //TextBox24.Text = string.Empty;
        }

        public void ItalianDescription(string dbname, string dbinstance)
        {
            string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password=cf5&web22";
           
            SqlConnection cnn = new SqlConnection(connetionString);

            //run query connected to dropdownlist
            string query = "select crm.CODE, nts.MESSAGE_TEXT from crm left join nts on crm.CODE = nts.SUPPLIER_CODE where nts.CATEGORY = 'sit'and BSL_ID = 0 and crm.code = '"
                + TextBox11.Text.ToString().Trim() +
                "'";

            cnn.Open();

            SqlCommand queryCommand = new SqlCommand(query, cnn);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            DataTable dataTable = new DataTable("AgentDetails");
            dataTable.Load(queryCommandReader);
            cnn.Close();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    //TextBox25.Text = rtfreturn(dr["MESSAGE_TEXT"].ToString().Trim());
                    collapse1.InnerText =  rtfreturn(dr["MESSAGE_TEXT"].ToString().Trim());
                }
            }
            else { }
                //TextBox25.Text = string.Empty;

            

        }

        public void loaddetails(string dbname, string dbinstance)
        {
            //create connection to database
            string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password=cf5&web22";

            SqlConnection cnn = new SqlConnection(connetionString);

            //run query connected to dropdownlist
            string query = "select distinct crm.address1, crm.address2, crm.address3, crm.name, crm.address4, crm.pcode, crm.code, crm.int_access FROM crm where crm.code ='"
                + TextBox11.Text.ToString().Trim() + "' order by code";

            cnn.Open();

            SqlCommand queryCommand = new SqlCommand(query, cnn);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            DataTable dataTable = new DataTable("AgentDetails");
            dataTable.Load(queryCommandReader);

            cnn.Close();

            // load data into textbox
            foreach (DataRow dr in dataTable.Rows)
            {
                TextBox5.Text = dr["name"].ToString();

                TextBox1.Text = dr["address1"].ToString().Trim();

                TextBox2.Text = dr["address2"].ToString().Trim();

                TextBox3.Text = dr["address3"].ToString().Trim();

                TextBox4.Text = (dr["address4"].ToString().Trim() + " " + dr["pcode"].ToString().Trim());
            }
        }

        public void optionLines(string dbname, string dbinstance)
        {
            string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password=cf5&web22";

            SqlConnection cnn = new SqlConnection(connetionString);


            string query = "select distinct crm.CODE,opt.SERVICE, opt.SUPPLIER, opt.CODE as 'option code', opt.DESCRIPTION, opd.SS as 'Single Room Cost' , opd.TW as 'Twin Room Cost',  opd.TR as 'Triple Room Cost', opd.QR as 'Quad Room Cost', opd.ADD_ADULT1 as 'Add adult', osr.DATE_FROM, OSR.DATE_TO from OPT left join CRM on CRM.CODE = opt.SUPPLIER left join osr on opt.OPT_ID = osr.OPT_ID left join opd on OSR.OSR_ID = opd.OSR_ID where crm.code = '"
                + TextBox11.Text.ToString().Trim() +
                "'and osr.DATE_FROM >= '2018-01-01' and opt.SERVICE = 'AC' order by osr.Date_from";

            cnn.Open();

            SqlCommand queryCommand = new SqlCommand(query, cnn);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            DataTable dataTable = new DataTable("AgentDetails");
            dataTable.Load(queryCommandReader);
            cnn.Close();

            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }

        public void optionLines2(string dbname, string dbinstance)
        {
            string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password=cf5&web22";

            SqlConnection cnn = new SqlConnection(connetionString);


            string query = "select distinct crm.CODE,opt.SERVICE, opt.SUPPLIER, opt.CODE as 'option code', opt.DESCRIPTION from crm left join opt on crm.code = opt.SUPPLIER  where crm.code = '"
                + TextBox11.Text.ToString().Trim() +
                "'and opt.SERVICE != 'AC'";

            cnn.Open();

            SqlCommand queryCommand = new SqlCommand(query, cnn);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            DataTable dataTable = new DataTable("AgentDetails");
            dataTable.Load(queryCommandReader);
            cnn.Close();

            GridView3.DataSource = dataTable;
            GridView3.DataBind();
        }

        // rtf conversion
        public string rtfreturn(string rtftext)
        {
            string normaltext = "";
            try
            {
                Process rtfapp = new Process();
                ProcessStartInfo pstart = new ProcessStartInfo();
                pstart.FileName = "RTFtoTextApp.exe";
                pstart.RedirectStandardOutput = true;
                pstart.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory + @"App_Data\";
                pstart.UseShellExecute = false;
                pstart.Arguments = @"""" + rtftext + @"""";
                pstart.FileName = AppDomain.CurrentDomain.BaseDirectory + @"App_Data\RTFtoTextApp.exe";
                rtfapp.StartInfo = pstart;
                rtfapp.Start();

                using (StreamReader output = rtfapp.StandardOutput)
                {
                    normaltext = output.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                normaltext = ex.InnerException.Message.ToString();
            }

            return normaltext;
        }

        public void SpanishDescription(string dbname, string dbinstance)
        {
            string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password=cf5&web22";

            SqlConnection cnn = new SqlConnection(connetionString);

            string query = "select crm.CODE, nts.MESSAGE_TEXT from crm left join nts on crm.CODE = nts.SUPPLIER_CODE where nts.CATEGORY = 'SSP' and BSL_ID = 0 and crm.code = '"
                + TextBox11.Text.ToString().Trim() +
                "'";

            cnn.Open();

            SqlCommand queryCommand = new SqlCommand(query, cnn);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            DataTable dataTable = new DataTable("AgentDetails");
            dataTable.Load(queryCommandReader);
            cnn.Close();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    //TextBox26.Text = rtfreturn(dr["MESSAGE_TEXT"].ToString().Trim());
                }
            }
            else { }
                //TextBox26.Text = string.Empty;
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            string dbname = "abbey_tours_ireland";
            if (RadioButtonList1.Text == "0")
            {
                dbname = "abbey_tours_Scotland";
            }
            if (RadioButtonList1.Text == "1")
            {
                dbname = "abbey_tours_ireland";
            }
            if (RadioButtonList1.Text == "2")
            {
                dbname = "M&K_ireland";
            }

            string dbinstance = "abbey-tourplan";

            GridView1.DataSource = null;

            loaddetails(dbname, dbinstance);
            optionLines(dbname, dbinstance);
            iframe(dbname, dbinstance);
            loadGallery();
            englishDescription(dbname, dbinstance);
            LoadContract();
            TextBox11.Text = string.Empty;
        }

        public void iframe(string dbname, string dbinstance)
        {
            string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password=cf5&web22";

            SqlConnection cnn = new SqlConnection(connetionString);

            string query = "select crm.CODE, nts.MESSAGE_TEXT from crm left join nts on crm.CODE = nts.SUPPLIER_CODE where nts.CATEGORY = 'GEO' and BSL_ID = 0 and crm.code = '"
                + TextBox11.Text.ToString().Trim() +
                "'";

            cnn.Open();

            SqlCommand queryCommand = new SqlCommand(query, cnn);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            DataTable dataTable = new DataTable("AgentDetails");
            dataTable.Load(queryCommandReader);
            cnn.Close();

            if (dataTable.Rows.Count != 0)
            {
                string geo = dataTable.Rows[0]["MESSAGE_TEXT"].ToString().Trim();
                string url = "https://www.google.ie/maps?q=";
                string key = "&key=AIzaSyBUO7_n9t9Lvzaqv3beI7hFp2TWx_VffPc&output=embed";
                string combine = url + geo + key;
                //myiFrame.Controls.Add(new LiteralControl("<iframe src='" +combine+ "'></iframe><br />"));
                myiFrame.Src = combine;
            }
            if (dataTable.Rows.Count <= 0)
            {
                Label21.Visible = true;
                myiFrame.Visible = false;
            }
            else
            {
                Label21.Visible = false;
                myiFrame.Visible = true;
            }
        }



        protected void GridView1_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            string dbinstance = "";
            string dbname = "abbey_tours_ireland";
            if (RadioButtonList1.Text == "0")
            {
                dbname = "abbey_tours_Scotland";
            }
            if (RadioButtonList1.Text == "1")
            {
                dbname = "abbey_tours_ireland";
            }
            if (RadioButtonList1.Text == "2")
            {
                dbname = "M&K_ireland";
            }
            dbinstance = "abbey-tourplan";
            optionLines(dbname, dbinstance);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string dbname = "abbey_tours_ireland";
            if (RadioButtonList1.Text == "0")
            {
                dbname = "abbey_tours_Scotland";
            }
            if (RadioButtonList1.Text == "1")
            {
                dbname = "abbey_tours_ireland";
            }
            if (RadioButtonList1.Text == "2")
            {
                dbname = "M&K_ireland";
            }


            string dbinstance = "abbey-tourplan";
            englishDescription(dbname, dbinstance);
            FrenchDescription(dbname, dbinstance);
            GermanDescription(dbname, dbinstance);
            ItalianDescription(dbname, dbinstance);
            SpanishDescription(dbname, dbinstance);

            //TextBox21.Visible = true;
            //TextBox23.Visible = true;
            //TextBox24.Visible = true;
            //TextBox25.Visible = true;
            //TextBox26.Visible = true;
            LinkButton1.Visible = true;
            Button1.Visible = false;

            //Label14.Visible = true;
            //Label15.Visible = true;
            //Label17.Visible = true;
            //Label18.Visible = true;
            //Label19.Visible = true;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
          
            LinkButton1.Visible = false;
            Button1.Visible = true;
        }

        public void loadGallery()
        {
            List<string> tempString = new List<string>();

            try
            {
                DataTable img = new DataTable();
                img.Columns.Add("imgs");
                DirectoryInfo di = new DirectoryInfo(@"//abbey-ftp01/Public/Tourplan_Pictures/Supplier_" + TextBox11.Text.ToString().Trim());
                foreach (var fi in di.GetFiles())
                {
                    if (fi.Name.ToLower() != "thumbs.db")
                    {
                        img.Rows.Add(@"http://abbey-ftp01/Supplier_" + TextBox11.Text.ToString().Trim() + "/" + fi.Name);
                        tempString.Add(@"http://abbey-ftp01/Supplier_" + TextBox11.Text.ToString().Trim() + "/" + fi.Name);
                    }

                }
                //GridView2.DataSource = img;
                //GridView2.DataBind();



            }
            catch (Exception ex)
            {
                //GridView2.DataSource = null;
                //GridView2.DataBind();
                string msg = ex.Message;
            }
            StringBuilder sb = new StringBuilder();
            sb.Append("<script>");
            sb.Append("var testArray = new Array;");
            foreach (string str in tempString)
            {
                sb.Append("testArray.push('" + str + "');");
            }
            sb.Append("</script>");

            ClientScript.RegisterStartupScript(this.GetType(), "TestArrayScript", sb.ToString());



        }


        protected void GridView3_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            string dbinstance = "";
            string dbname = "abbey_tours_ireland";
            if (RadioButtonList1.Text == "0")
            {
                dbname = "abbey_tours_Scotland";
            }
            if (RadioButtonList1.Text == "1")
            {
                dbname = "abbey_tours_ireland";
            }
            if (RadioButtonList1.Text == "2")
            {
                dbname = "M&K_ireland";
            }
            dbinstance = "abbey-tourplan";
            GridView3.PageIndex = e.NewPageIndex;
            optionLines2(dbname, dbinstance);


        }

        List<string> files = new List<string>();
        private void getFilesRecursive(string sDir)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    getFilesRecursive(d);
                }
                foreach (var file in Directory.GetFiles(sDir))
                {
                    //This is where you would manipulate each file found, e.g.:
                    
                    DoAction(file);
                }
            }
            catch (System.Exception e)
            {
                string err = e.Message;
            }
        }

        private void DoAction(string filepath)
        {
            files.Add(filepath);

            if (filepath.ToLower().Contains(TextBox11.Text.ToString().ToLower()))
            {
                string myTest =  filepath;
                string test2 = filepath.Replace(@"\\abbey-fp01\ndrive\General Information & Final Contracts\Rates (Final Contracts & Generics)\2018",@"https://web.abbey.ie/bdffp/contracts/2018");
                test2 = test2.Replace(@"\", @"/");
                mylink.Target = myTest.ToString();
                mylink.InnerText = myTest.ToString();
                mylink.HRef = test2.ToString();
            }
           
        }

        public void LoadContract()
        {
            string sDir = @"\\abbey-fp01\ndrive\General Information & Final Contracts\Rates (Final Contracts & Generics)\2018";
            getFilesRecursive(sDir);




         }

       
       

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}