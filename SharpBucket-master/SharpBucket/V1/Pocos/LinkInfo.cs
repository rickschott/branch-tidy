﻿using System;

namespace SharpBucket.V1.Pocos
{
    [Obsolete("Bitbucket Cloud v1 APIs are deprecated")]
    public class LinkInfo
    {
        public string display_to { get; set; }
        public string replacement_url { get; set; }
        public string raw_regex { get; set; }
        public string name { get; set; }
        public string display_from { get; set; }
    }
}