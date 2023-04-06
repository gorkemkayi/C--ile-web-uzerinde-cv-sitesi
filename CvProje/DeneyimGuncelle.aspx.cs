using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProje
{
    public partial class DeneyimGuncelle : System.Web.UI.Page
    {
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);
            if (Page.IsPostBack == false)
            {
                var deneyim = db.TBLHAKKIMDA.Find(x);
                TextBox1.Text = deneyim.ISDENEYIMLERI;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);
            var deneyim =db.TBLHAKKIMDA.Find(x);

            deneyim.ISDENEYIMLERI = TextBox1.Text;
            db.SaveChanges();
            Response.Redirect("Deneyimler.aspx");
        }
    }
}