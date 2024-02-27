﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystem.Infrastructure.Repository.Interfaces
{
	public interface IRepository<T> where T : class
	{
		IEnumerable<T> GetAll(Expression<Func<T,bool>>? query=null, string? includeProperties = null);

		T Get(Expression<Func<T, bool>>? query = null, string? includeProperties= null);

		void Add(T entity);

		void Remove(T entity);

		void RemoveRange(IEnumerable<T> entities);
	}
}
