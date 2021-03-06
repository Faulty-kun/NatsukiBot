﻿using MonikAIBot.Services.Database.Repos;
using System;
using System.Threading.Tasks;

namespace MonikAIBot.Services.Database
{
    public interface IUnitOfWork : IDisposable
    {
        DBContext _context { get; }

        IChannelsRepository Channels { get; }
        IUserRepository User { get; }
        IUserRateRepository UserRate { get; }

        int Complete();
        Task<int> CompleteAsync();
    }
}
