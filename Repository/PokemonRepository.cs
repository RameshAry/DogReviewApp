
using DogReviewApp.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using PokemonReviewApp.Data;
using PokemonReviewApp.Models;

namespace DogReviewApp.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly DataContext _context;

        public PokemonRepository(DataContext context)
        {
            _context = context;
        }

        public Pokemon GetPokemon(string name)
        {
            return _context.Pokemon.Where(p => p.Name == name).FirstOrDefault();
        }

        public Pokemon GetPokemon(int id)
        {
            return _context.Pokemon.Where(p => p.Id == id).FirstOrDefault();
        }

        public ICollection<Pokemon> GetPokemons()
        {
            Console.WriteLine("It came here");
            return _context.Pokemon.OrderBy(p => p.Id).ToList();
        }
    }
}