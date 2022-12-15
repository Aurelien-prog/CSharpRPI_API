Qu'est ce qu'un ORM ?
Un ORM est un créateur de BDD qui remplace les frameworks.

#### Antity framework Core :
- Créer une base de données.
- Faire un CRUD
- Faire un READ.ME en expliquant tout le travail.
- Se servir de swagger.


## Création de l'API

```C#
[//Dans un invite de commande
$ dotnet new webapi -o HeroAPI

//Pour lancer l'API
$ dotnet run

//Install dotnet (une seule fois)
$ dotnet tool install --global dotnet-ef
``` 

## Installation Nugget :

```  C#
$ dotnet tool install --global dotnet-ef  
```

#### Dans le dossier du projet :

### Pour ajouter les packets Entity Framework Core  
```  C#
$ dotnet add package Microsoft.EntityFrameworkCore --version 7.0.1  
$ dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.0.1 
```

### Pour ajouter les packets MySQL :  
``` C# 
$ dotnet add package Pomelo.EntityFrameworkCore.MySql --version 7.0.0-alpha.1  
```

### Créer une méthode
```C#
[HttpGet]

public async Task<ActionResult<List<Hero>>> Get()
{
	return  Ok(await _context.Heroes.ToListAsync());
}
```

- Créer des migartions
- Crée des maj de BDD

### Ajouter à la base de donnée
```C#
$ dotnet-ef migrations add firstmigrationn

$ dotnet-ef database update
```

### Lancer le profile "https" (swagger)
```C#
$ dotnet run --launch-profile https
// Actualiser directement
$ dotnet watch
```
