﻿using FikaAmazonAPI.Search;
using System;
using System.Collections.Generic;
using System.Text;
using static FikaAmazonAPI.Utils.Constants;

namespace FikaAmazonAPI.Parameter.FulFillmentInbound
{
    public class ParameterGetLabels : ParameterBased
    {
        public string MarketplaceId { get; set; }
        public string shipmentId { get; set; }
        public PageType PageType { get; set; }
        public LabelType LabelType { get; set; }
        public int? NumberOfPackages { get; set; }
        public IList<string> PackageLabelsToPrint { get; set; }
        public int? NumberOfPallets { get; set; }
        public int? PageSize { get; set; }
        public int? PageStartIndex { get; set; }
    }
}
