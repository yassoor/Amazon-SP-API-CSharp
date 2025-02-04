﻿using FikaAmazonAPI.AmazonSpApiSDK.Models.Token;
using FikaAmazonAPI.Search;
using System;
using System.Collections.Generic;
using System.Text;

namespace FikaAmazonAPI.Parameter
{
    public class ParameterBasedPII : ParameterBased, IParameterBasedPII
    {
        public bool IsNeedRestrictedDataToken { get; set; }
        public CreateRestrictedDataTokenRequest RestrictedDataTokenRequest { get; set; }
    }
}
