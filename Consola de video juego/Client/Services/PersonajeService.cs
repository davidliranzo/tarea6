public class PersonajeService
{
    private List<Personaje> personajes = new List<Personaje>();
    private int siguienteId = 1;

    public List<Personaje> GetPersonajes()
    {
        return personajes;
    }

    public Personaje GetPersonajeById(int id)
    {
        return personajes.FirstOrDefault(p => p.Id == id);
    }

    public void AddPersonaje(Personaje personaje)
    {
        personaje.Id = siguienteId++;
        personajes.Add(personaje);
    }

    public void UpdatePersonaje(Personaje personaje)
    {
        var personajeExistente = GetPersonajeById(personaje.Id);
        if (personajeExistente != null)
        {
            personajeExistente.Nombre = personaje.Nombre;
            personajeExistente.Alias = personaje.Alias;
            personajeExistente.Rol = personaje.Rol;
            personajeExistente.HabilidadEspecial = personaje.HabilidadEspecial;
            personajeExistente.ArmaFavorita = personaje.ArmaFavorita;
            personajeExistente.NivelDePoder = personaje.NivelDePoder;
            personajeExistente.ImagenUrl = personaje.ImagenUrl;
        }
    }

    public void DeletePersonaje(int id)
    {
        var personaje = GetPersonajeById(id);
        if (personaje != null)
        {
            personajes.Remove(personaje);
        }
    }
}
