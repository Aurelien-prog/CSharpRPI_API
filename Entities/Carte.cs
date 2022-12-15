using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetAPI;

public class Carte
{
    public int id {get; set;}
    public string name {get; set;} = string.Empty;
    public int hp {get; set;}
    public string element {get; set;} = string.Empty;
    public Type generation {get; set;}
    public Type type {get; set;}
}