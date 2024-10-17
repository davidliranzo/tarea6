public class Personaje
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Alias { get; set; } // Opcional
    public string Rol { get; set; } // Ej: Protagonista, Villano, Secundario
    public string HabilidadEspecial { get; set; } // Opcional
    public string ArmaFavorita { get; set; } // Opcional
    public int NivelDePoder { get; set; } // Del 1 al 100
    public string ImagenUrl { get; set; } // URL de la imagen del personaje
}
