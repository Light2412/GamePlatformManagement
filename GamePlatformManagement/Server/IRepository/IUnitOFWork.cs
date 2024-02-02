using GamePlatformManagement.Shared.Domain;
using GamePlatformManagement.Server.IRepository;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace GamePlatformManagement.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Game> Games { get; }
        IGenericRepository<Staff> Staffs { get; }
    }
}