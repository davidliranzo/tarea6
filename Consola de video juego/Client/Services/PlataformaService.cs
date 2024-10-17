public class PlataformaService
{
    private List<Plataforma> plataformas = new List<Plataforma>();
    private int siguienteId = 1;

    public List<Plataforma> GetPlataformas()
    {
        return plataformas;
    }

    public Plataforma GetPlataformaById(int id)
    {
        return plataformas.FirstOrDefault(p => p.Id == id);
    }

    public void AddPlataforma(Plataforma plataforma)
    {
        plataforma.Id = siguienteId++;
        plataformas.Add(plataforma);
    }

    public void UpdatePlataforma(Plataforma plataforma)
    {
        var plataformaExistente = GetPlataformaById(plataforma.Id);
        if (plataformaExistente != null)
        {
            plataformaExistente.Nombre = plataforma.Nombre;
            plataformaExistente.Activa = plataforma.Activa;
        }
    }

    public void DeletePlataforma(int id)
    {
        var plataforma = GetPlataformaById(id);
        if (plataforma != null)
        {
            plataformas.Remove(plataforma);
        }
    }
}
