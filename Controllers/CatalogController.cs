using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PMWeb.Models;

namespace PMWeb.Controllers
{
    public class CatalogController : Controller
    {
        // GET: Catalog
        
         
        public ActionResult Index()
        {
            // Lấy chuỗi kết nối từ file Web.config
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["PMDataConnectionString"].ConnectionString;

            // Khởi tạo đối tượng QuanLySanPhamDataContext với constructor có tham số chuỗi kết nối
            QuanLySanPhamDataContext context = new QuanLySanPhamDataContext(connectionString);

            // Lấy danh sách Catalog từ cơ sở dữ liệu
            List<Catalog> dsCatalog = context.Catalogs.ToList();

            // Trả về view với danh sách Catalog
            return View(dsCatalog);


        }
    }
}