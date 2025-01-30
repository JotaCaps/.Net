using Blog.Models;
using Blog.Repositories;
using Blog.Screens.TagScreens;

namespace Blog.Screens.TagScreen
{
    public static class DeleteTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Deletando uma tag");
            Console.WriteLine("-------------");
            
            Console.WriteLine("Id: ");
            var id = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Delete(new Tag{Id = id});
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Delete(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Delete(tag);
                System.Console.WriteLine("Tag deletada com sucesso!");
            }catch(Exception ex)
            {
                Console.WriteLine("Não foi possível deletar a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}