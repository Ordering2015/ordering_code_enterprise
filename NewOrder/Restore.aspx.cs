using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace EnterpriseOrdering
{
    public partial class Resrore : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int cid = int.Parse(Request.QueryString["customerid"]);
            if (!IsPostBack)
            {
                Session["es"] = cid;
            }
            NewOrder.ServiceReference2.Service1SoapClient x = new NewOrder.ServiceReference2.Service1SoapClient();
            NewOrder.ServiceReference2.Class1[] c = x.Getorderid((int)Session["es"]);
            List<NewOrder.ServiceReference2.Class1> l = new List<NewOrder.ServiceReference2.Class1>();
            
            for (int i = 0; i < c.Length; i++)
            {
                l.Add(c[i]);
            }
            GridView1.DataSource = l;
            GridView1.DataBind();
            NewOrder.ServiceReference2.Class3[] c1 = x.Getstatus((int)Session["es"]);       
            if(c1[0].otype=="S"  && c1[0].os=="PC")
            {
                Button3.Visible = true;

            }
            else if (c1[0].otype == "R" || c1[0].otype == "N" || c1[0].otype == "C" && c1[0].os == "PC")
            {
                Button1.Visible = true;
            }
  
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "";
            DataSet Ds = new DataSet();
            DataTable dt = new DataTable();
            //dt.Columns.Add("Customer_ID");
            //dt.Columns.Add("Service_ID");
            dt.Columns.Add("Order_ID");
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                var row = dt.NewRow();
                //row["Service_ID"] = "6";
                row["Order_ID"] = Convert.ToString(GridView1.Rows[i].Cells[0].Text);
                //row["Order_ID"] = Convert.ToString(GridView1.Rows[i][0])
                dt.Rows.Add(row);
            }
            Ds.Tables.Add(dt);
            str = Ds.GetXml();
            Session["STR"] = str;
            Response.Redirect("Suspend_Due.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string str = "";
            DataSet Ds = new DataSet();
            DataTable dt = new DataTable();
            //dt.Columns.Add("Customer_ID");
            //dt.Columns.Add("Service_ID");
            dt.Columns.Add("Order_ID");
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                var row = dt.NewRow();
                //row["Service_ID"] = "6";
                row["Order_ID"] = Convert.ToString(GridView1.Rows[i].Cells[0].Text);
                //row["Order_ID"] = Convert.ToString(GridView1.Rows[i][0])
                dt.Rows.Add(row);
            }
            Ds.Tables.Add(dt);
            str = Ds.GetXml();
            Session["STR"] = str;
            Response.Redirect("Restore_due.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }

    }
}