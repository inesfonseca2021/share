using System.Text.Json;

namespace ficha10
{
    public class JsonLoader 
    {
        public static List<Employee> LoadEmployees()
        {
            string text = File.ReadAllText("./json/employees.json");
            return JsonSerializer.Deserialize<List<Employee>>(text);
            
        }
        


        public static List<Character> LoadCharacters ()
        {
            string text = File.ReadAllText("./json/characters.json");
            return JsonSerializer.Deserialize<List<Character>>(text);
        }
        

    }
}
