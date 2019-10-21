using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.Tripster.Core.Contracts;

namespace Tavisca.Tripster.Core.Validations
{
    public class TripValidation
    {
        private ITripService _tripService;

        public TripValidation(ITripService tripService)
        {
            _tripService = tripService;
        }

       // public object 
    }
}
