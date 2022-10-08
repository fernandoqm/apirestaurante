using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiRestaurante.Core.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IRestauranteRepository RestauranteRepository { get; }
        ISalonesRepository SalonesRepository { get; }
        IAreaDespachoRepository AreaDespachoRepository { get; }
        IBodegasRepository bodegasRepository { get; }
        ICantonesRepository CantonesRepository { get; } 
        IComandasRepository ComandasRepository { get; }
        IDetalleComandaRepository IDetalleComandaRepository { get; }    
        IDistritosRepository IDistritosRepository { get; }  
        IMesasRepository MesasRepository { get; }   
        IPaisesRepository PaisesRepository { get; } 
        IProvinciasRepository ProvinciasRepository { get; } 
        IProductosRepository ProductosRepository { get; }   
        

        Task<int> CommitAsync();
    }
}
