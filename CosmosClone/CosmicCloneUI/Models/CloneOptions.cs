﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace CosmicCloneUI.Models
{
    class CloneOptions
    {
        public bool copySP { get; set; }
        public bool copyUDF { get; set; }
        public bool copyTrigger { get; set; }
        public bool copyDocument { get; set; }
        public bool copyIndexingPolicy { get; set; }
        public bool copyPartitionKey { get; set; }
        public long offerThroughput { get; set; }
    }
}
