namespace PersonalSiteMVC.Models
{
    public class LightboxViewModel
    {
        public string Title { get; set; } = null!;
        public string Image1 { get; set; } = null!;
        public string Image1Alt { get; set; } = null!;
        public string? Image2 { get; set; }
        public string? Image2Alt { get; set; }
        public string? Image3 { get; set; }
        public string? Image3Alt { get; set; }
        public string Category { get; set; } = null!;
        public DateTime Date { get; set; }
        public string? ProjUrl { get; set; }
        public string GitUrl { get; set; } = null!;
        public string Description { get; set; } = null!;

        public static LightboxViewModel GetLightbox(string name)
        {

            switch (name)
            {
                case "Dungeon":
                    LightboxViewModel dungeon = new ()
                    {
                        Title = "C# Dungeon Console App",
                        Image1 = "/assets/img/Dungeon/DungeonApp1.png",
                        Image1Alt = "Attack Menu",
                        Image2 = "/assets/img/Dungeon/DungeonApp2.png",
                        Image2Alt = "Attack Victory",
                        Image3 = "/assets/img/Dungeon/DungeonApp3.png",
                        Image3Alt = "Green Door Opens",
                        Category = "Application Development",
                        Date = new DateTime(2023, 3, 6),
                        GitUrl = "https://github.com/jpinky82/DungeonApplication",
                        Description = "This is a .NET Core Console Application where the foundational concepts of C#, as a language, were learned."
                    };
                    return dungeon;

                case "StoreFront":
                    LightboxViewModel storefront = new ()
                    {
                        Title = "Retro Games StoreFront",
                        Image1 = "/assets/img/StoreFront/Products.jpg",
                        Image1Alt = "Product Page",
                        Image2 = "/assets/img/StoreFront/About.jpg",
                        Image2Alt = "About Page",
                        Image3 = "/assets/img/StoreFront/Cart.jpg",
                        Image3Alt = "Shopping Cart",
                        Category = "Web design",
                        Date = new DateTime(2023, 3, 20),
                        ProjUrl = "http://retrogames.jpinkston.com",
                        GitUrl = "https://github.com/jpinky82/RetroGamesStoreFront",
                        Description = "A secure application for managing product data. The application is built to simulate an online store front with a shopping cart. Administrators have the ability to manage product, category, and vendor data."
                    };
                    return storefront;
                case "ToDoApi":
                    LightboxViewModel todoapi = new ()
                    {
                        Title = "ToDo API",
                        Image1 = "/assets/img/ToDo_API/todo_image.png",
                        Image1Alt = "Checklist",
                        Category = "Restful API",
                        Date = new DateTime(2023, 5, 1),
                        GitUrl = "https://github.com/jpinky82/ToDoAPI",
                        Description = "This Web API project is intended to showcase my ability to create a RESTful API that can be consumed by another application. The topic of this API is to provide the backend functionality for the React ToDo list application."
                    };
                    return todoapi;
                case "ReactToDo":
                    LightboxViewModel reacttodo = new ()
                    {
                        Title = "React ToDo List",
                        Image1 = "/assets/img/React_ToDo/Todos.jpg",
                        Image1Alt = "Todo's Page",
                        Image2 = "/assets/img/React_ToDo/Categories.jpg",
                        Image2Alt = "Categories Page",
                        Image3 = "/assets/img/React_ToDo/React_logo.png",
                        Image3Alt = "React Logo",
                        Category = "React Web App",
                        Date = new DateTime(2023, 5, 8),
                        ProjUrl = "http://todo.jpinkston.com",
                        GitUrl = "https://github.com/jpinky82/TodoWebApplication",
                        Description = "The React To Do Application is a portfolio project that showcases my ability to build a single page application using React JS.  The application allows users to sign in and see items on the to do list as well as mark to do items as complete. Admins are able to add, edit, and delete(full CRUD). This application leverages   the .NET Web API as the backend of the app."
                    };
                    return reacttodo;
                case "SAT":
                    LightboxViewModel sat = new ()
                    {
                        Title = "Scheduling Administration Tool",
                        Image1 = "/assets/img/SAT/UnderConstruction.jpg",
                        Image1Alt = "Under Construction",
                        Image3Alt = "Under Construction",
                        Category = "Web design",
                        Date = new DateTime(2023, 5, 12),
                        ProjUrl = "Coming Soon!",
                        GitUrl = "Coming Soon!",
                        Description = "A secure application for managing product data. The application is built to simulate an online class scheduling system.  Administrators will have the ability to manage students, courses, scheduled classes, and enrollments."
                    };
                    return sat;

                case "Atomic_Synergistics":
                    LightboxViewModel atomicSynergistics = new()
                    {
                        Title = "Atomic Synergistics",
                        Image1 = "/assets/img/Atomic_Synergistics/Dashboard.jpg",
                        Image1Alt = "Dashboard Page",
                        Image2 = "/assets/img/Atomic_Synergistics/Departments.jpg",
                        Image2Alt = "Departments Page",
                        Image3 = "/assets/img/Atomic_Synergistics/Products.jpg",
                        Image3Alt = "Products Page",
                        Category = "Web design",
                        Date = new DateTime(2023, 5, 19),
                        GitUrl = "https://github.com/jpinky82/Atomic-Synergistics",
                        Description = "This is an Intranet Web Application for the fictional company Atomic Synergistics.  It was the final project for the Centriq Program and was developed as a team using a Kanban Board and Peer Programming."
                    };
                    return atomicSynergistics;

                //New Project can be added here.  the case MUST match the value of Lightbox in the ProjectViewModel.

                default:
                    return default;
            }
        }
    }
}
