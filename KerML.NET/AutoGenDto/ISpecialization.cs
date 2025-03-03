// -------------------------------------------------------------------------------------------------
// <copyright file="ISpecialization.cs" company="Starion Group S.A.">
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

namespace KerML.NET.DTO.Core.Types
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    using KerML.NET.DTO.Root.Elements;
    using KerML.NET.Decorators;
    using KerML.NET.Namespaces;
    using KerML.NET.Types;

    /// <summary>
    /// Specialization is a Relationship between two Types that requires all instances of the specific type
    /// to also be instances of the general Type (i.e., the set of instances of the specific Type is a
    /// subset of those of the general Type, which might be the same set).
    /// </summary>
    [Class(xmiId: "d0bbaddc-004a-4559-b707-31bbc0d7c7e9", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface ISpecialization : IRelationship
    {
        /// <summary>
        /// A Type with a superset of all instances of the specific Type, which might be the same set.
        /// </summary>
        [Property(xmiId: "6dd5c0f9-10e8-4361-90d4-723016f969f5", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "4c7374f5-78f8-42ab-ae42-672ad9c80902")]
        public new string General { get; set; }

        /// <summary>
        /// A Type with a subset of all instances of the general Type, which might be the same set.
        /// </summary>
        [Property(xmiId: "f45c204e-a88a-4382-9701-ccc842d4a68a", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "cd83f43d-3885-4b41-8f03-f02255e6a5da")]
        public new string Specific { get; set; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
