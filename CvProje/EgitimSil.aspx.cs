using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProje
{
    public partial class EgitimSil : System.Web.UI.Page
    {
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            var egitim = db.TBLHAKKIMDA.Find(x);
            db.TBLHAKKIMDA.Remove(egitim);
            db.SaveChanges();
            Response.Redirect("Egitim.aspx");
        }
    }
}