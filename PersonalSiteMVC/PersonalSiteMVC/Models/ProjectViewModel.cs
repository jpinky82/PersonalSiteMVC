using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using System.Xml.Linq;

namespace PersonalSiteMVC.Models
{
    public class ProjectViewModel
    {
        public int ID { get; set; }
        public string TitlePic { get; set; } = null!;
        public string TitlePicAlt { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Filter { get; set; } = null!;
        public string Gallery_Title { get; set; } = null!;
        public string? LightBox_URL { get; set; }
        public string Slide_Image1 { get; set; } = null!;
        public string Slide_Image2 { get; set; }
        public string Slide_Image3 { get; set; }
        public string Slide_ImageAlt { get; set; } = null!;
        public string Category { get; set; } = null!;
        public DateTime ProjectDate { get; set; }
        public string GitHub_URL { get; set; } = null!;
        public string Description { get; set; } = null!;


        //public ProjectViewModel(int iD, string titlePic, string titlePicAlt, string name, string filter, string gallery_Title, string? lightBox_URL, string slide_Image1, string slide_Image2, string slide_Image3,string slide_ImageAlt, string category, DateTime projectDate, string gitHub_URL, string description)
        //{
        //    ID = iD;
        //    TitlePic = titlePic;
        //    TitlePicAlt = titlePicAlt;
        //    Name = name;
        //    Filter = filter;
        //    Gallery_Title = gallery_Title;
        //    LightBox_URL = lightBox_URL;
        //    Slide_Image1 = slide_Image1;
        //    Slide_Image2 = slide_Image2;
        //    Slide_Image3 = slide_Image3;
        //    Slide_ImageAlt = slide_ImageAlt;
        //    Category = category;
        //    ProjectDate = projectDate;
        //    GitHub_URL = gitHub_URL;
        //    Description = description;
        //}

        public static List<ProjectViewModel> GetProjects()
        {
            ProjectViewModel project1 = new ProjectViewModel()
            {
                ID = 1,
                TitlePic = "../assets/img/Dungeon/DungeonAppTitle.png",
                TitlePicAlt = "Dungeon Load Screen",
                Name = "Dungeon App",
                Filter = "C# App",
                Gallery_Title = "Dungeon Application Created in C#",
                LightBox_URL = "@Html.Raw(ViewBag.projects[0])",
                Slide_Image1 = "../assets/img/Dungeon/DungeonApp1.png",
                Slide_Image2 = "../assets/img/Dungeon/DungeonApp2.png",
                Slide_Image3 = "../assets/img/Dungeon/DungeonApp3.png",
                Slide_ImageAlt = "Screenshot from Dungeon App",
                Category = "Application Development",
                ProjectDate = new DateTime(2023, 3, 6),
                GitHub_URL = "https://github.com/jpinky82/DungeonApplication",
                Description = "This is a .NET Core Console Application where the foundational concepts of C#, as a language, were learned."
            };

            ProjectViewModel project2 = new ProjectViewModel()
            {
                ID = 2,
                TitlePic = "../assets/img/StoreFront/Storefront.png",
                TitlePicAlt = "Picture of StoreFront",
                Name = "StoreFront",
                Filter = "Web",
                Gallery_Title = "Store Front MVC Application",
                LightBox_URL = "@Html.Raw(ViewBag.projects[1])",
                Slide_Image1 = "../assets/img/StoreFront/Under Construction1.png",
                Slide_Image2 = "../assets/img/StoreFront/Under Construction2.png",
                Slide_Image3 = "../assets/img/StoreFront/Under Construction3.png",
                Slide_ImageAlt = "Under Construction",
                Category = "Web design",
                ProjectDate = new DateTime(2023, 4, 17),
                GitHub_URL = null,
                Description = "A secure application for managing product data. The application is built to simulate an online store front with a shopping cart. Administrators have the ability to manage product, category, and vendor data."
            };

            ProjectViewModel project3 = new ProjectViewModel()
            {
                ID = 3,
                TitlePic = "../assets/img/ToDo_API/todo_image.png",
                TitlePicAlt = "Picture of Checklist",
                Name = "ToDo API",
                Filter = "App",
                Gallery_Title = "ToDo API",
                LightBox_URL = "@Html.Raw(ViewBag.projects[2])",
                Slide_Image1 = "../assets/img/ToDo_API/Under Construction1.png",
                Slide_Image2 = "../assets/img/ToDo_API/Under Construction2.png",
                Slide_Image3 = "../assets/img/ToDo_API/Under Construction3.png",
                Slide_ImageAlt = "Under Construction",
                Category = "Web design",
                ProjectDate = new DateTime(2023, 5, 1),
                GitHub_URL = null,
                Description = "Coming Soon"
            };

            ProjectViewModel project4 = new ProjectViewModel()
            {
                ID = 4,
                TitlePic = "../assets/img/React_ToDo/React_logo.png",
                TitlePicAlt = "ReactJS Logo",
                Name = "React ToDo",
                Filter = "Card",
                Gallery_Title = "React ToDo",
                LightBox_URL = "@Html.Raw(ViewBag.projects[3])",
                Slide_Image1 = "../assets/img/React_ToDo/Under Construction1.png",
                Slide_Image2 = "../assets/img/React_ToDo/Under Construction2.png",
                Slide_Image3 = "../assets/img/React_ToDo/Under Construction3.png",
                Slide_ImageAlt = "Under Construction",
                Category = "Web design",
                ProjectDate = new DateTime(2023, 5, 8),
                GitHub_URL = null,
                Description = "Coming Soon"
            };

            ProjectViewModel project5 = new ProjectViewModel()
            {
                ID = 5,
                TitlePic = "../assets/img/SAT/SAT.png",
                TitlePicAlt = "Scheduler",
                Name = "S.A.T",
                Filter = "Web",
                Gallery_Title = "Scheduling Administration Tool",
                LightBox_URL = "@Html.Raw(ViewBag.projects[4])",
                Slide_Image1 = "../assets/img/SAT/Under Construction1.png",
                Slide_Image2 = "../assets/img/SAT/Under Construction2.png",
                Slide_Image3 = "../assets/img/SAT/Under Construction3.png",
                Slide_ImageAlt = "Under Construction",
                Category = "Web design",
                ProjectDate = new DateTime(2023, 5, 15),
                GitHub_URL = null,
                Description = "Coming Soon"
            };

            return new List<ProjectViewModel> { project1, project2, project3, project4, project5 };


        }
    }
}
