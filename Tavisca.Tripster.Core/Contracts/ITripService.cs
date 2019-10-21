using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.Tripster.Data.Models;

namespace Tavisca.Tripster.Core.Contracts
{
    public interface ITripService
    {
        Trip Get(Guid id);
        IEnumerable<Trip> GetAll();
        void Add(Trip entity);
        void Delete(Guid id);
        void Update(Guid id, Trip entity);
    }
}
