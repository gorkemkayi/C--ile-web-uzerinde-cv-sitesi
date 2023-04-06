using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProje
{
    public partial class YeniDeneyim : System.Web.UI.Page
    {
        DBCVENTITYEntities db=new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLHAKKIMDA t=new TBLHAKKIMDA();

            t.ISDENEYIMLERI = TextBox1.Text;
            db.TBLHAKKIMDA.Add(t);
            db.SaveChanges();
            Response.Redirect("Deneyimler.aspx");
        }
    }
}