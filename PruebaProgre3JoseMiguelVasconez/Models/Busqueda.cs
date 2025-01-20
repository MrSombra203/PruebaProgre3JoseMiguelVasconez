namespace PruebaProgre3JoseMiguelVasconez.Models;
using SQLite;
[Table("localisasion")]
public class Busqueda
{
    public String nombreOficial {  get; set; }
    public String region {  get; set; }
    public String googleMaps { get; set; }
    public String nombrePersona { get; set; }

}