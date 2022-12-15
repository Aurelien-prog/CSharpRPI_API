using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetAPI;

public class Type
{
    public int id {get; set;}
    public string generation {get;set;} = string.Empty; //1ère/2ème/3ème/4ème/.../7ème génération
    public string edition {get;set;} = string.Empty; //1ère/2ème édition
    public string extension {get;set;} = string.Empty; //Épée et bouclier - Stars Étincelante - 
    public bool holographique {get;set;}
    public string rarete {get;set;} = string.Empty;//Rare - Très rare - Super rare
}