﻿using UtmBuiler.Core.ValueObjects.Exceptions;

namespace UtmBuiler.Core.ValueObjects
{
    public class Campaign : ValueObject
    {
        public Campaign(string source, string medium, string name, string? id = null, string? term = null, string? content = null)
        {
            Source = source;
            Medium = medium;
            Name = name;
            Id = id;
            Term = term;
            Content = content;
            InvalidCampaignException.ThrowifNull(source, "UTM Source is invalid");
            InvalidCampaignException.ThrowifNull(medium, "UTM Medium is invalid");
            InvalidCampaignException.ThrowifNull(name, "UTM Name is invalid");

        }
        public string Source { get; }
        public string Medium { get; } 
        public string Name { get; } 
        public string? Id { get; }
        public string? Term { get; } 
        public string? Content { get; } 

    }
}
