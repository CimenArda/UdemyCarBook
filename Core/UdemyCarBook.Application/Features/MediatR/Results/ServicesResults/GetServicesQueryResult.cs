using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.MediatR.Results.ServicesResults
{
    public class GetServicesQueryResult
    {
        public int ServiceID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string IconUrl { get; set; }
    }
}
