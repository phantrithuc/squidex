﻿// ==========================================================================
//  ListSchemaDto.cs
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex Group
//  All rights reserved.
// ==========================================================================

using System;
using System.ComponentModel.DataAnnotations;

namespace Squidex.Modules.Api.Schemas.Models
{
    public class SchemaDto
    {
        /// <summary>
        /// The id of the schema.
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// The name of the schema. Unique within the app.
        /// </summary>
        [Required]
        [RegularExpression("^[a-z0-9]+(\\-[a-z0-9]+)*$")]
        public string Name { get; set; }
        
        /// <summary>
        /// The date and time when the schema has been creaed.
        /// </summary>
        public DateTime Created { get; set; }
        
        /// <summary>
        /// The date and time when the schema has been modified last.
        /// </summary>
        public DateTime LastModified { get; set; }
    }
}