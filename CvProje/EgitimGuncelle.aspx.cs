using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProje
{
    public partial class EgitimGuncelle : System.Web.UI.Page
    {
        DBCVENTITYEntities db=new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);
            if (Page.IsPostBack == false)
            {
                var Egitim = db.TBLHAKKIMDA.Find(x);
                TextBox1.Text = Egitim.EGITIM;
            }
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);
            var Egitim = db.TBLHAKKIMDA.Find(x);
            Egitim.EGITIM = TextBox1.Text;
            db.SaveChanges();
            Response.Redirect("Egitim.aspx");
        }
    }
}