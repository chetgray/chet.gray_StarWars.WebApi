StarWars.WebApi
===============

User Story #211916: WebAPI: Create Star Wars Characters API
-----------------------------------------------------------

> Create a WebAPI that gives us information on Star Wars characters.
>
> - [x] Create a StarWarsCharacter model that contains the following:
>   - [x] Id
>   - [x] Name
>   - [x] Allegiance (Rebellion, Empire, None)
>   - [x] IsJedi (True / False)
>   - [x] Trilogy Introduced In (Original, Prequel, Sequel)
> - [x] Create a new CharacterController.
> - [x] Inside the CharacterController, populate a list of characters as
>   follows:
>   - [x] 1, Luke Skywalker, Rebellion, True, Original
>   - [x] 2, Obi-Wan Kenobi, Rebellion, True, Original
>   - [x] 3, Jar Jar Binks, None, False, Prequel
>   - [x] 4, Poe Dameron, Rebellion, False, Sequel
>   - [x] 5, Finn, Rebellion, False, Sequel
>   - [x] 6, Rey Skywalker, Rebellion, True, Sequel
>   - [x] 7, C-3PO, Rebellion, False, Original
>   - [x] 8, R2-D2, Rebellion, False, Original
> - [ ] Your WebAPI should do the following (this will not have Data
>   Access, so this is just based on the data you've entered in the
>   Constructor):
>   - [x] Have a GET method to give a list of all the characters
>   - [x] Have a GET method to get a character by Id
>   - [x] Have a GET method to get a character's allegiance by name
>   - [x] Have a GET method to list of all Jedis
>   - [x] Have a GET method that accepts a trilogy and returns all the
>     characters from that trilogy
>   - [ ] Have a POST method that allows you to enter a new character
>     (we can't save it or anything just yet)
>   - [x] Have good XML documentation
