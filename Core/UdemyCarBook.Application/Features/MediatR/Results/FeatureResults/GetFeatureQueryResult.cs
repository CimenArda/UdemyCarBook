﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.MediatR.Results.FeatureResults
{
    public class GetFeatureQueryResult
    {
        public int FeatureID { get; set; }

        public string FeatureName { get; set; }
    }
}
