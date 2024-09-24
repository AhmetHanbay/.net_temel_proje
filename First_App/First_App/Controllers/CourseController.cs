using First_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class CourseController: Controller{

    public IActionResult Details(int? id){ //sadece course yazsak da course/index yazasak da burası çağırılır

    if(id == null){
        return Redirect("course/list");
    }

        var kurs = Repository.GetById(id);

        return View(kurs);
    }

    public IActionResult List(){ //course/list yazınca da burası çağırılır
        
        return View("CourseList" , Repository.Courses);
    }
     
}