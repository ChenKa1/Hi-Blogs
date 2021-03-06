﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HiBlogs.Web.Areas.Admin.Controllers
{
    /// <summary>
    /// 博客管理
    /// </summary>
    [Authorize(Roles = "Administrator")]
    public class BlogManageController : AdminBaseController
    {
        /// <summary>
        /// 博客管理
        /// </summary>
        /// <returns></returns>
        public IActionResult Blogs()
        {
            return View();
        }

        /// <summary>
        /// 博客迁移
        /// </summary>
        /// <returns></returns>
        public IActionResult Migration()
        {
            return View();
        }
    }
}
