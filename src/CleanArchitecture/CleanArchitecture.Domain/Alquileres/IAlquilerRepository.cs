using CleanArchitecture.Domain.Vehiculos;

namespace CleanArchitecture.Domain.Alquileres;


public interface IAlquilerRepository
{
    Task<Alquiler?> GetByIdAsync(AlquilerId id, CancellationToken cancellationToken = default);
    Task<bool> IsOverLappingAsync(
        Vehiculo vehiculo,
        DateRange dateRange,
        CancellationToken cancellationToken = default
    );

    void  Add(Alquiler alquiler);
}