using Microsoft.AspNetCore.Mvc;
using ficha10.Controllers;
using System.Net.Mime;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ficha10.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        private readonly ICharacters characters;

       /* public CharactersController()
        {
            characters = JsonLoader.LoadCharacters();
        }*/

        public CharactersController(ICharacters characters)
        {
            this.characters = characters;
        }


        [HttpGet]
        public IEnumerable<Character> Get()
        {
            return characters.CharactersList;
        }
        
        // POST api/<ValuesController>
        [HttpPost (Name = "PostChars")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult PostChars ([FromBody] Character chr)
        {

        if (characters.CharactersList.Count == 0)
        {
            chr.Id = 1;
            characters.CharactersList.Add(chr);
        }
        else
        {
            var lastCharacter = characters.CharactersList.LastOrDefault();
            chr.Id = lastCharacter.Id + 1;
            characters.CharactersList.Add(chr);
        }
        return Ok(chr);

        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}", Name = "DeleteChars")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteChars(int id)
        {
            int removed = characters.CharactersList.RemoveAll(c => c.Id == id);
            if (removed == 0)
            {
                return NotFound(String.Format("Id {0} was not found", id));

            }
            else
            {
                return Ok(String.Format("Character with this id {0} was deleted", id));

            }

        }


        // GET api/<ValuesController>/5

        [HttpGet("{id}", Name = "GetCharId")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Character))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetCharId (int idCh)
        {

            Character? chr = characters.CharactersList.Find(c => c.Id == idCh);
            if (chr == null)
            {
                return NotFound(String.Format("Id {0} was not found", idCh));
            }
            else
            {
                return Ok(chr);
            }

        }


        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Character))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Put(int id, Character chrFromBody)
        {
            Character? character = characters.CharactersList.Find(ch => ch.Id == id);
            if (characters.CharactersList.Count == 0)
            {
                return NotFound(String.Format("Id {0} was not found", id));
            }
            else
            {
                character.Id = chrFromBody.Id;
                character.Name = chrFromBody.Name;
                character.Gender = chrFromBody.Gender;
                character.Homeworld = chrFromBody.Homeworld;
                character.Born = chrFromBody.Born;
                character.Jedi = chrFromBody.Jedi;


                return Ok(String.Format("Character with id {0} was updated to {1}", id, chrFromBody));
            }

        }

        // GET api/<ValuesController>/5

        [HttpGet("gender/{gender}", Name = "GetByGender")] //name tem de ser igual
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetByGender(string gender)
        {
            List<Character> CharactersList = characters.CharactersList.FindAll(c => c.Gender == gender);
            if (CharactersList.Count == 0)
            {
                return NotFound(String.Format("Id {0} was not found", gender));
            }
            else
            {
                return Ok(CharactersList);
            }

        }

        // GET api/<ValuesController>/5

        [HttpGet("jedi/{jedi}", Name = "GetByJedi")] //name tem de ser igual
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetByJedi(string jedi)
        {
            List<Character> CharactersList = characters.CharactersList.FindAll(c => c.Jedi == true);
            if (CharactersList.Count == 0)
            {
                return NotFound(String.Format("Id {0} was not found", jedi));
            }
            else
            {
                return Ok(CharactersList);
            }

        }


       /* [HttpGet("/downloadChar", Name = "DownloadChar")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DownloadChar()
        {
            string character = JsonSerializer.Serialize(characters.CharactersList);
            System.IO.File.WriteAllText("./Characteres.json", character);

            try
            {
                byte[] bytes = System.IO.File.ReadAllBytes("CharacteresList.json");
                return File(bytes, "application/json", "CharacteresList.json");
            }
            catch (FileNotFoundException c )
            {
                return NotFound(c.Message);
            }
            

        }*/








    }


}
