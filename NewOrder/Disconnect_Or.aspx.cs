using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace EnterpriseOrdering
{
    public partial class Disconnect_Or : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int cid =int.Parse(Request.QueryString["customerid"]);
            if (!IsPostBack)
            {
                Session["ed"] = cid;
            }
            NewOrder.ServiceReference2.Service1SoapClient x = new NewOrder.ServiceReference2.Service1SoapClient();

            NewOrder.ServiceReference2.Class3[] c1 = x.Getstatus(cid);

            if (c1[0].os != "PC")
            {
                Label1.Text = "The service has not been provisioned yet!";
                Button1.Visible = false;
                GridView1.Visible = false;
                Label2.Visible = false;
            }

            NewOrder.ServiceReference2.Class1[] c = x.Getorderid((int)Session["ed"]);
            List<NewOrder.ServiceReference2.Class1> l = new List<NewOrder.ServiceReference2.Class1>();
            for (int i = 0; i < c.Length; i++)
            {
                l.Add(c[i]);
            }
            GridView1.DataSource = l;
            GridView1.DataBind();
            


        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string str = "";
            DataSet Ds = new DataSet();

            DataTable dt = new DataTable();

            dt.Columns.Add("Customer_ID");
            dt.Columns.Add("Service_ID");
            //dt.Columns.Add("Order_ID");


            //for (int i = 0; i < GridView1.Rows.Count; i++)
            //{
            //    var row = dt.NewRow();

            //    row["Customer_ID"] = "28";
            //    row["Service_ID"] = "6";
            //    //row["Order_ID"] = Convert.ToString(GridView1.Rows[i].Cells[0].Text);


            //    dt.Rows.Add(row);
            //}
            var row = dt.NewRow();

            row["Customer_ID"] = Session["ed"].ToString();
            row["Service_ID"] = "6";
            dt.Rows.Add(row);

            Ds.Tables.Add(dt);

            str = Ds.GetXml();



            Session["STR"] = str;
            
            Response.Redirect("Disconnect_Due.aspx");
        }
    }
}