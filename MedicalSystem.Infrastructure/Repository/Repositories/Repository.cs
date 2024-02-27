using MedicalSystem.Infrastructure.Data;
using MedicalSystem.Infrastructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystem.Infrastructure.Repository.Repositories
{
	public class Repository<T> : IRepository<T> where T : class
	{

		internal DbSet<T> dbSet;
		internal ApplicationDbContext _db;
		public Repository(ApplicationDbContext db)
		{
			_db = db;
			dbSet = db.Set<T>();
		}
		public void Add(T entity)
		{
			dbSet.Add(entity);
		}

		public T Get(Expression<Func<T, bool>>? query=null, string? includeProperties=null)
		{
			IQueryable<T> dataQuery = dbSet;
			if (query != null)
			{
				dataQuery = dataQuery.Where(query);
			}

			if (!string.IsNullOrEmpty(includeProperties))
			{
				string[] properties = includeProperties.Split(",", StringSplitOptions.RemoveEmptyEntries);
				foreach (string property in properties)
				{
					dataQuery = dataQuery.Include(property.Trim());
				}
			}
			return dataQuery.FirstOrDefault();

		}

		public IEnumerable<T> GetAll(Expression<Func<T, bool>>? query=null, string? includeProperties=null)
		{
			IQueryable<T> dataQuery = dbSet;
			if (query != null)
			{
				dataQuery = dataQuery.Where(query);
			}

			if (!string.IsNullOrEmpty(includeProperties))
			{
				string[] properties = includeProperties.Split(",",StringSplitOptions.RemoveEmptyEntries);
				foreach (string property in properties)
				{
					dataQuery = dataQuery.Include(property.Trim());
				}
			}
			return dataQuery.ToList();
		}

		public void Remove(T entity)
		{
			dbSet.Remove(entity);
		}

		public void RemoveRange(IEnumerable<T> entities)
		{
			dbSet.RemoveRange(entities);
		}
	}
}
