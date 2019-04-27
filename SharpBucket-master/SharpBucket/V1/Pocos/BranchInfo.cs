﻿using System;
using System.Collections.Generic;

namespace SharpBucket.V1.Pocos
{
    [Obsolete("Bitbucket Cloud v1 APIs are deprecated")]
    public class BranchInfo
    {
        public string node { get; set; }
        public List<FileInfo> files { get; set; }
        public string raw_author { get; set; }
        public string utctimestamp { get; set; }
        public string author { get; set; }
        public string timestamp { get; set; }
        public string raw_node { get; set; }
        public List<string> parents { get; set; }
        public string branch { get; set; }
        public string message { get; set; }
        public object revision { get; set; }
        public long? size { get; set; }
    }
}