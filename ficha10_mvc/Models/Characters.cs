using ficha10.Controllers;
using System.Text.Json;



namespace ficha10
{
    public class Characters: ICharacters
    {
        private List<Character> charactersList;
        List<Character> ICharacters.CharactersList
        {
            get => charactersList;
            set => charactersList = value;
        }

        public Characters()
        {

            charactersList = JsonLoader.LoadCharacters();
        }

        

    }
}
