using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SSharing.Frameworks.Common.Extends;
using SSharing.Frameworks.FileStore;
using System.IO;
using FileStoreDemo.Common;

namespace FileStoreDemo.WebSite
{
    public partial class Home : System.Web.UI.Page
    {
        private static string objectName = string.Empty;
        private static string fileName = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            //上传
            var postFile = fileUpload1.PostedFile;
            if (postFile.FileName.IsNullOrEmpty() || postFile.ContentLength == 0)
            {
                this.lblMsg.Text = "请选择文件！";
                return;
            }

            var now = DateTime.Now;
            fileName = Path.GetFileName(postFile.FileName);
            objectName = string.Format("{0}/{1}/{2}", now.Year.ToString(), now.Month.ToString(), fileName);
            
            FileStoreHelper.Instance.Upload(objectName, postFile.InputStream);
            this.lblMsg.Text = "上传成功！";
        }

        protected void btnDownload_Click(object sender, EventArgs e)
        {
            //下载
            //以字符流的形式下载文件 
            byte[] bytes = null;
            using (var ms = FileStoreHelper.Instance.Download(objectName))
            {
                bytes = ms.ToArray();
            }
            
            Response.ContentType = "application/octet-stream";   
            Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(fileName, System.Text.Encoding.UTF8));
            Response.BinaryWrite(bytes);
            Response.Flush();
            Response.End();
        }
    }
}