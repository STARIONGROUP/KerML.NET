// -------------------------------------------------------------------------------------------------
// <copyright file="IDependency.cs" company="Starion Group S.A.">
//
//   Copyright (C) 2022-2025 Starion Group S.A.
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
//
// </copyright>
// ------------------------------------------------------------------------------------------------

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace KerML.NET.DTO.Root.Dependencies
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    using KerML.NET.DTO;
    using KerML.NET.Decorators;

    /// <summary>
    /// A Dependency is a Relationship that indicates that one or more client Elements require one more
    /// supplier Elements for their complete specification. In general, this means that a change to one of
    /// the supplier Elements may necessitate a change to, or re-specification of, the client Elements.Note
    /// that a Dependency is entirely a model-level Relationship, without instance-level semantics.
    /// </summary>
    [Class(xmiId: "345c4407-6df4-481b-b103-01f51cba97b7", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface IDependency : IRelationship
    {
        /// <summary>
        /// The Element or Elements dependent on the supplier Elements.
        /// </summary>
        [Property(xmiId: "4c3a1991-8da9-4cb9-bd2f-a5cbb3c055f5", aggregation: AggregationKind.None, lowerValue: 1, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "cd83f43d-3885-4b41-8f03-f02255e6a5da")]
        public new List<string> Client { get; set; }

        /// <summary>
        /// The Element or Elements on which the client Elements depend in some respect.
        /// </summary>
        [Property(xmiId: "67169bb1-834a-4a1f-8649-9d136c59a30b", aggregation: AggregationKind.None, lowerValue: 1, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "4c7374f5-78f8-42ab-ae42-672ad9c80902")]
        public new List<string> Supplier { get; set; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
