using System.Security.Cryptography.X509Certificates;
using Balta.ContentContext;

var articles = new List<Article>();
articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
articles.Add(new Article("Artigo sobre C#", "csharp"));
articles.Add(new Article("Artigo sobre .NET", "dotnet"));

foreach(var article in articles)
{
    Console.WriteLine(article.Id);
    Console.WriteLine(article.Title);
    Console.WriteLine(article.Url);
}

var courses = new List<Course>();
var cursoOOP = new Course("Fundamentos OOP", "fundamentos-oop");
var cursoCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
var cursoAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");

courses.Add(cursoOOP);
courses.Add(cursoCsharp);
courses.Add(cursoAspNet);

var careers = new List<Career>();
var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
var careerItem = new CareerItem(1, "Comece por aqui", "", cursoCsharp);
var careerItem2 = new CareerItem(2, "Aprenda OOP", "", cursoCsharp);
var careerItem3 = new CareerItem(3, "Aprenda .Net", "", cursoCsharp);
careerDotnet.Items.Add(careerItem);
careerDotnet.Items.Add(careerItem2);
careerDotnet.Items.Add(careerItem3);
careers.Add(careerDotnet);

foreach(var career in careers)
{
    Console.WriteLine(career.Title);
    foreach(var item in career.Items.OrderBy(x => x.Order))
    {
        Console.WriteLine($"{item.Order} - {item.Title}");
        Console.WriteLine(item.Course.Level);
    }
}