using System;
using System.Collections.Generic;
using Business.Entities;
using Business.Repositories;

namespace Business.Services
{
		public class GenericService<TEntity> where TEntity : Generic
		{
			protected GenericRepository<TEntity> rep;

			public GenericService(GenericRepository<TEntity> rep)
			{
				this.rep = rep;
			}

			public void Insert(TEntity entity)
			{
				Validate(entity);
				rep.Add(entity);
			}

			public void Delete(TEntity entity)
			{
				Validate(entity);
                rep.Remove(entity);
			}

			public void Update(TEntity entity)
			{
				Validate(entity);
				rep.Update(entity);
			}

			public TEntity FindById(int id)
			{
                return rep.Find(id);
			}

			public IEnumerable<TEntity> ListAll()
			{
				return rep.ListAll();
			}

			public void Validate(TEntity entity)
			{

			}

		}
}
