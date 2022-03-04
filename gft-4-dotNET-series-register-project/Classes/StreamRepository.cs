using gft_4_dotNET_series_register_project.Interfaces;

namespace gft_4_dotNET_series_register_project.Classes;

public class StreamRepository : IRepository<Streams>
{
    private List<Streams> listStreams = new List<Streams>();

    public List<Streams> List()
    {
        return listStreams;
    }

    public Streams ReturnById(int id)
    {
        return listStreams[id];
    }

    public void Insert(Streams entity)
    {
        listStreams.Add(entity);
    }

    public void Remove(int id)
    {
        listStreams[id].Remove();
    }

    public void Update(int id, Streams entity)
    {
        listStreams[id] = entity;
    }

    public int NextId()
    {
        return listStreams.Count;
    }
}