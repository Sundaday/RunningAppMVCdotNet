﻿using RunningApp.Models;

namespace RunningApp.Interfaces
{
    public interface IClubRepository
    {
        Task<IEnumerable<Club>> GetAll();
        Task<IEnumerable<Club>> GetClubByCity(string city);
        Task<Club> GetByIdAsync(int id);
        Task<Club> GetByIdAsyncNoTracking(int id);
        bool Add(Club club);
        bool Update(Club club);
        bool Delete(Club club);
        bool Save();
    }
}
