using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using System.Xml.Linq;

namespace PersonalSiteMVC.Models
{
    public class ProjectViewModel
    {
        public int ID { get; set; }
        public string Filter { get; set; } = null!;
        public string Image { get; set; } = null!;
        public string ImageAlt { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string ProjectType { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string? LightBox { get; set; } = null!;


        public static List<ProjectViewModel> GetProjects()
        {
            ProjectViewModel project1 = new ()
            {
                ID = 1,
                Filter = "app",
                Image = "/assets/img/Dungeon/DungeonAppTitle.png",
                ImageAlt = "Dungeon Load Screen",
                Name = "Dungeon App",
                ProjectType = "C# App",
                Title = "Dungeon Application Created in C#",
                LightBox = "Dungeon"
            };

            ProjectViewModel project2 = new ()
            {
                ID = 2,
                Filter = "web",
                Image = "/assets/img/StoreFront/Home.jpg",
                ImageAlt = "Retro Games Home",
                Name = "Retro Games StoreFront",
                ProjectType = "Web",
                Title = "StoreFront App Created in .Net Core",
                LightBox = "StoreFront"

            };

            ProjectViewModel project3 = new ()
            {
                ID = 3,
                Filter = "api",
                Image = "/assets/img/ToDo_API/todo_image.png",
                ImageAlt = "Checklist",
                Name = "ToDo API",
                ProjectType = "App",
                Title = "ToDo API",
                LightBox = "ToDoApi"
            };

            ProjectViewModel project4 = new ()
            {
                ID = 4,
                Filter = "react",
                Image = "/assets/img/React_ToDo/Login.jpg",
                ImageAlt = "React App Login",
                Name = "React ToDo App",
                ProjectType = "React ToDo",
                Title = "React ToDo",
                LightBox = "ReactToDo"
            };

            ProjectViewModel project5 = new ()
            {
                ID = 5,
                Filter = "web",
                Image = "/assets/img/SAT/SAT.png",
                ImageAlt = "Scheduler",
                Name = "S.A.T",
                ProjectType = "Web",
                Title = "Scheduling Administration Tool",
                LightBox = "SAT"
            };

            ProjectViewModel project6 = new()
            {
                ID = 6,
                Filter = "web",
                Image = "/assets/img/Atomic_Synergistics/Login.jpg",
                ImageAlt = "Login Page",
                Name = "Atomic Synergistics",
                ProjectType = "Web",
                Title = "Intranet Application",
                LightBox = "Atomic_Synergistics"
            };

            //New Projects can be entered here and then added to the return below. New Projects will also need to be added to the LightboxViewModel!

            return new List<ProjectViewModel> { project1, project2, project3, project4, project5, project6 };


        }
    }
}
