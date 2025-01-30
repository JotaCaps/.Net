using Blog.Models;
using Blog.Repositories;
using Blog.Screens.TagScreens;

namespace Blog.Screens.TagScreen
{
    public static class CreateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova tag");
            Console.WriteLine("-------------");
            Console.WriteLine("Name: ");
            var name = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Slug:");
            var slug = Console.ReadLine();

            Create(new Tag{Name =name, Slug = slug});
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Create(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Create(tag);
                System.Console.WriteLine("Tag cadastrada com sucesso!");
            }catch(Exception ex)
            {
                Console.WriteLine("Não foi possível salvar a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}