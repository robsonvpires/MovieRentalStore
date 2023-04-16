using Microsoft.Extensions.DependencyInjection;
using MovieRentalStore.Services;
using MovieRentalStore.Services.Interfaces;

namespace MovieRentalStore.CrossCutting.IOC;

public static class ServicesDependecy
{
    public static void AddServiceDenpendecy(this IServiceCollection services)
    {
        services.AddScoped<IMovieService, MovieService>();
        services.AddScoped<IGenreService, GenreService>();
    }
}
