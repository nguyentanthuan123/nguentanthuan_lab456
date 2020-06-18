using Microsoft.AspNet.Identity;
using nguentanthuan_lab456.Models;
using nguentanthuan_lab456.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nguentanthuan_lab456.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplycationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplycationDbContext();
        }
        // GET: Courses
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }

    }
}