using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HKQTravel.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        // GET: Admin/Base
        public BaseController()
        {
            //tạo ra 1 hàm constructer bắt mọi trang admin đều phải đăng nhập
            if (System.Web.HttpContext.Current.Session["admin_user"].Equals(""))
            {
                //return redirect("~/admin/login"); lớp này không thể trả về bằng cách này 
                System.Web.HttpContext.Current.Response.Redirect("~/admin/login");
            }
        }
    }
}