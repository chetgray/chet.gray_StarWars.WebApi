StarWars.WebApi
===============

User Story #211916: WebAPI: Create Star Wars Characters API
-----------------------------------------------------------

> Create a WebAPI that gives us information on Star Wars characters.
>
> - [ ] Create a StarWarsCharacter model that contains the following:
>   - [ ] Id
>   - [ ] Name
>   - [ ] Allegiance (Rebellion, Empire, None)
>   - [ ] IsJedi (True / False)
>   - [ ] Trilogy Introduced In (Original, Prequel, Sequel)
> - [ ] Create a new CharacterController.
> - [ ] Inside the CharacterController, populate a list of characters as
>   follows:
>   - [ ] 1, Luke Skywalker, Rebellion, True, Original
>   - [ ] 2, Obi-Wan Kenobi, Rebellion, True, Original
>   - [ ] 3, Jar Jar Binks, None, False, Prequel
>   - [ ] 4, Poe Dameron, Rebellion, False, Sequel
>   - [ ] 5, Finn, Rebellion, False, Sequel
>   - [ ] 6, Rey Skywalker, Rebellion, True, Sequel
>   - [ ] 7, C-3PO, Rebellion, False, Original
>   - [ ] 8, R2-D2, Rebellion, False, Original
> - [ ] Your WebAPI should do the following (this will not have Data
>   Access, so this is just based on the data you've entered in the
>   Constructor):
>   - [ ] Have a GET method to give a list of all the characters
>   - [ ] Have a GET method to get a character by Id
>   - [ ] Have a GET method to get a character's allegiance by name
>   - [ ] Have a GET method to list of all Jedis
>   - [ ] Have a GET method that accepts a trilogy and returns all the
>     characters from that trilogy
>   - [ ] Have a POST method that allows you to enter a new character
>     (we can't save it or anything just yet)
>   - [ ] Have good XML documentation
