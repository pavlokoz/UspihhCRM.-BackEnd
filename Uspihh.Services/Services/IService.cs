using System.Threading.Tasks;

namespace Uspihh.Services.Services
{
    public interface IService<T>
    {
        T GetById(long id);
    }
}
