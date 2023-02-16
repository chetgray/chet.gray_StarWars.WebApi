StarWars.WebApi
===============

User Story #211918: WebAPI: Update Star Wars Character API to add Data
Access
----------------------------------------------------------------------

> Update your Star Wars Character API (US 211916) to add data access.
>
> - [x] Create a new StarWars database.
>   - [x] Within the database, create:
>     - [x] New table: CharacterGeneralInfo
>       - [x] Id
>       - [x] Name
>       - [x] Allegiance (Rebellion, Empire, None)
>       - [x] IsJedi (True / False)
>       - [x] Trilogy Introduced In Id - FOREIGN KEY to new
>         TrilogyInformation table (see below).
>     - [x] New Table: TrilogyInfo
>       - [x] Id
>       - [x] Trilogy Name (Original, Prequel, Sequel)
>     - [x] New Stored Procedure: Get all Character Information
>     - [x] New Stored Procedure: Get Character Information by Name
>     - [x] New Stored Procedure: Get Character Information by
>       Allegiance
>     - [x] New Stored Procedure: Get Character Information by Trilogy
>       - [-] Be sure all your stored procs appropriately JOIN your 2
>         tables to get all your information!
>     - [x] New Stored Procedure: INSERT new character information into
>       the CharacterGeneralInfo table
>       - [-] Hint: You may also need a stored proc to get the Trilogy
>         ID by Name, so you don't have to make the API caller pass the
>         Trilogy ID (it's not realistic that they'll know that) to add
>         a new character. Instead, let them pass the trilogy name, then
>         you look up the ID, then you use that ID to add to the
>         Character table.
> - [x] Create SQL to INSERT new data into both tables (or just use the
>   "Edit top 200 rows" in SSMS to add it. You can use the data below.
>   Be sure to put the trilogy information in its separate table with an
>   Id pointing to it from the main table (foreign key).
>   - [x] 1, Luke Skywalker, Rebellion, True, Original
>   - [x] 2, Obi-Wan Kenobi, Rebellion, True, Original
>   - [x] 3, Jar Jar Binks, None, False, Prequel
>   - [x] 4, Poe Dameron, Rebellion, False, Sequel
>   - [x] 5, Finn, Rebellion, False, Sequel
>   - [x] 6, Rey Skywalker, Rebellion, True, Sequel
>   - [x] 7, C-3PO, Rebellion, False, Original
>   - [x] 8, R2-D2, Rebellion, False, Original
> - [x] Change your WebAPI to add Data Access as we discussed.
>   - [x] You'll want to have a new class library with a DataAccess
>     namespace, a Repository namespace, and a DTOs namespace.
> - [x] Update the functionality of your API so that it does the
>   following:
> - [x] Your WebAPI should do the following:
>   - [x] Have a GET method to give a list of all the character
>     information (get it from the DB)
>   - [x] Have a GET method to get a character's information by their
>     name (get it from the DB)
>   - [x] Have a GET method to get a list of character information by
>     allegiance (get it from the DB)
>   - [x] Have a GET method to get a list of character information by
>     trilogy (get it from the DB)
>   - [x] Have a POST method that allows you to enter a new character
>     (write it to the DB)
>   - [-] \*\* Any methods from your older version of the app that were
>     hardcoded that aren't here, like getting character information
>     where Jedi = True, can stay hardcoded. \*\*
>   - [x] Have good XML documentation
> - [x] Thoroughly test this via Postman.

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
> - [x] Your WebAPI should do the following (this will not have Data
>   Access, so this is just based on the data you've entered in the
>   Constructor):
>   - [x] Have a GET method to give a list of all the characters
>   - [x] Have a GET method to get a character by Id
>   - [x] Have a GET method to get a character's allegiance by name
>   - [x] Have a GET method to list of all Jedis
>   - [x] Have a GET method that accepts a trilogy and returns all the
>     characters from that trilogy
>   - [x] Have a POST method that allows you to enter a new character
>     (we can't save it or anything just yet)
>   - [x] Have good XML documentation
