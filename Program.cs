using System;
using System.Linq;
using Balta.ContentContext;
using Balta.SubscriptionContext;

namespace Balta 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre c#", "CSharp"));
            articles.Add(new Article("Artigo sobre .NET", "DotNET"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }

            var courses = new List<Course>();
            var courseOOP = new Course("Fudamentos OOP", "fundamentos-oop");
            var courseCSharp = new Course("Fudamentos C#", "fundamentos-csharp");
            var courseAspNet = new Course("Fudamentos ASP.NET", "fundamentos-aspdotnet");

            courses.Add(courseOOP);
            courses.Add(courseCSharp);
            courses.Add(courseAspNet);

            

            var careers = new List<Career>();
            var careerDotNet = new Career("Especialista .NET", "especialista-DotNet");
            var careerItem2 = new CareerItem(2, "aprenda OOP", "", null);
            var careerItem = new CareerItem(1, "Comece por aqui", "", courseCSharp);
            var careerItem3 = new CareerItem(3, "aprenda .NET", "", courseAspNet);
            careerDotNet.Items.Add(careerItem2);
            careerDotNet.Items.Add(careerItem3);
            careerDotNet.Items.Add(careerItem);
            careers.Add(careerDotNet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Propety} - {notification.Message}");
                    }
                }

                var payPalSubscription = new PayPalSubscription();
                var student = new Student();
                

                student.CreateSubscription(payPalSubscription);
            }

        }
    }
}