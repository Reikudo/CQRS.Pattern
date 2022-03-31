﻿using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CQRS.Pattern.Infrastructure.Base
{
    /// <summary>
    /// Generic entity class
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        /// Globally unique identifier  
        /// </summary>
        [BsonGuidRepresentation(GuidRepresentation.CSharpLegacy)]

        public Guid Id { get; set; }
    }
}