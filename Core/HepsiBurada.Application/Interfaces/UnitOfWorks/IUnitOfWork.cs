﻿using HepsiBurada.Application.Interfaces.Repositories;
using HepsiBurada.Domain.Common;

namespace HepsiBurada.Application.Interfaces.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IReadRepository<T> GetReadRepository<T>() where T : class, IEntityBase, new();

        IWriteRepository<T> GetWriteRepository<T>() where T : class, IEntityBase, new();

        Task<int> SaveAsync();

        int Save();
    }
}
