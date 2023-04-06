using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvProje
{
    public partial class iletisim : System.Web.UI.Page
    {
        DBCVENTITYEntities db=new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var mesajlar=db.TBLILETISIM.ToList();
            Repeater1.DataSource = mesajlar;
            Repeater1.DataBind();
        }
    }
}