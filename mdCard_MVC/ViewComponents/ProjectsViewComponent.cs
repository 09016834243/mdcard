using mdCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace mdCard_MVC.ViewComponents
{
	public class ProjectsViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var projects = new List<Project>
			{
				new Project(1,"تاکسی","درخواست آنلاین خودرو برای سفر های درون شهری","project-1.jpg","Maxim"),
				new Project(2,"زودپز","درخواست آنلاین غذا برای سراسر کشور","project-2.jpg","ZoodPaz"),
				new Project(3,"مدارس","سیستم مدیریت یکپارچه مدارس","project-3.jpg","Monop"),
				new Project(4,"جانگل واتر","پروژه هوشمند مدیریت گلخانه ها با سیستم های نوین و هوش مصنوعی","project-4.jpg","JungleWater"),
			};
			return View("Projects",projects);
		}
	}
}
