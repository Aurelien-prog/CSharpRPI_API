using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetAPI;

public class Type
{
    public int id {get; set;}
    public string generation {get;set;} = string.Empty;
    public string type {get;set;} = string.Empty;
}