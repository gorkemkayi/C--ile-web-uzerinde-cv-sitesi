using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProje
{
    public partial class MesajDetay : System.Web.UI.Page
    {
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);
            var mesaj=db.TBLILETISIM.Find(x);

            TxtAdSoyad.Text = mesaj.ADSOYAD;
            TxtMail.Text = mesaj.MAIL;
            TxtKonu.Text = mesaj.KONU;
            TxtMesaj.Text = mesaj.MESAJ;
        }
    }
}