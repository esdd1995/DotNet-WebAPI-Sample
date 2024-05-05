﻿using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class EducationRepository : IEducationRepository
    {
        private readonly SampleDbContext _dbContext;
        public EducationRepository(SampleDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Education>> GetAll()
        {
            return await _dbContext.Educations.ToListAsync();
        }

        public async Task<Education?> GetById(Guid id)
        {
            return await _dbContext.Educations.AsNoTracking().FirstOrDefaultAsync(c=>c.Id == id);
        }

        public async Task<Education> Add(Education model)
        {
            var result = await _dbContext.Educations.AddAsync(model);
            return result.Entity;
        }

        public void Update(Education model)
        {
            _dbContext.Educations.Update(model);
        }

        public void Delete(Education model)
        {
            _dbContext.Educations.Remove(model);
        }
    }
}
