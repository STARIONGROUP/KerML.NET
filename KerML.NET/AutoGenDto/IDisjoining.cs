// -------------------------------------------------------------------------------------------------
// <copyright file="IDisjoining.cs" company="Starion Group S.A.">
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

    using KerML.NET.DTO.Core.Types;
    using KerML.NET.DTO.Root.Annotations;
    using KerML.NET.DTO.Root.Elements;
    using KerML.NET.DTO.Root.Namespaces;

    using KerML.NET.Decorators;

    /// <summary>
    /// A Disjoining is a Relationship between Types asserted to have interpretations that are not shared
    /// (disjoint) between them, identified as typeDisjoined and disjoiningType. For example, a Classifier
    /// for mammals is disjoint from a Classifier for minerals, and a Feature for people&#39;s parents is
    /// disjoint from a Feature for their children.
    /// </summary>
    [Class(xmiId: "a5e249bc-a9dd-482e-9430-33c95d80247d", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface IDisjoining : IRelationship
    {
        /// <summary>
        /// Type asserted to be disjoint with the typeDisjoined.
        /// </summary>
        [Property(xmiId: "70acb736-8e2e-4d5e-a8c4-ba326a62859c", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "4c7374f5-78f8-42ab-ae42-672ad9c80902")]
        string DisjoiningType { get; set; }

        /// <summary>
        /// A typeDisjoined that is also an owningRelatedElement.
        /// </summary>
        [Property(xmiId: "3b784da1-5a29-451c-83a0-fea18d2b9292", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "c81d146c-d738-40a0-ab80-8526beac3673")]
        [SubsettedProperty(propertyName: "f0a587d0-f650-4482-8f65-c1ff8512d614")]
        string? GetOwningType { get; }

        /// <summary>
        /// Type asserted to be disjoint with the disjoiningType.
        /// </summary>
        [Property(xmiId: "f0a587d0-f650-4482-8f65-c1ff8512d614", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "cd83f43d-3885-4b41-8f03-f02255e6a5da")]
        string TypeDisjoined { get; set; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
