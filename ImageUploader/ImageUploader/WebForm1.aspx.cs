using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace ImageUploader
{
    public partial class WebForm1 : System.Web.UI.Page
    {


        void Page_PreRender()
        {

            string UploadFolder = MapPath("~/Resources/");
            DirectoryInfo dir = new DirectoryInfo(UploadFolder);
            DataList1.DataSource = dir.GetFiles();
            DataList1.DataBind();
        }

        bool DataTypeCheck(string filename)
        {
            string ext = Path.GetExtension(filename);
            switch (ext.ToLower())
            {
                case ".gif":
                    return true;
                   
                case ".jpg":
                    return true;

                case ".jpeg":
                    return true;

                case ".png":
                    return true;

                default:
                    return false;

            }
        
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFiles)
            {
                if (DataTypeCheck(FileUpload1.FileName))
                {
                    FileUpload1.SaveAs(MapPath("~/Resources/" + FileUpload1.FileName));
                }
            }
        }
    }
}