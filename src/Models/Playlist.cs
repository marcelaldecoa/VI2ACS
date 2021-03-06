﻿using Microsoft.Azure.Search;
using System;

namespace VIToACS.Models
{
    public class Playlist
    {

        [IsSearchable, IsFilterable]
        public string Name { get; set; }

        [IsSearchable]
        public string Description { get; set; }

        [IsFilterable, IsFacetable]
        public string PrivacyMode { get; set; }

        [IsFilterable, IsFacetable]
        public string State { get; set; }

        [IsFilterable, IsFacetable]
        public string AccountId { get; set; }

        [IsFilterable]
        public string Id { get; set; }

        [IsFilterable, IsFacetable]
        public string UserName { get; set; }

        [IsFilterable]
        public DateTimeOffset Created { get; set; }

        [IsFilterable, IsFacetable]
        public bool IsOwned { get; set; }

        [IsFilterable, IsFacetable]
        public bool IsEditable { get; set; }

        [IsFilterable, IsFacetable]
        public bool IsBase { get; set; }

        public double DurationInSeconds { get; set; }
    }
}
