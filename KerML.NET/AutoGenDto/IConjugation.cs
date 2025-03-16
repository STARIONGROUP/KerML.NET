// -------------------------------------------------------------------------------------------------
// <copyright file="IConjugation.cs" company="Starion Group S.A.">
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
    /// Conjugation is a Relationship between two types in which the conjugatedType inherits all the
    /// Features of the originalType, but with all input and output Features reversed. That is, any Features
    /// with a direction in relative to the originalType are considered to have an effective direction of
    /// out relative to the conjugatedType and, similarly, Features with direction out in the originalType
    /// are considered to have an effective direction of in in the conjugatedType. Features with direction
    /// inout, or with no direction, in the originalType, are inherited without change.A Type may
    /// participate as a conjugatedType in at most one Conjugation relationship, and such a Type may not
    /// also be the specific Type in any Specialization relationship.
    /// </summary>
    [Class(xmiId: "d8fbc0dd-ef0f-45c5-a080-d79d10517d09", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface IConjugation : IRelationship
    {
        /// <summary>
        /// The Type that is the result of applying Conjugation to the originalType.
        /// </summary>
        [Property(xmiId: "416f9595-3386-4e1b-b01e-57e62a6b49a4", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "cd83f43d-3885-4b41-8f03-f02255e6a5da")]
        string ConjugatedType { get; set; }

        /// <summary>
        /// The Type to be conjugated.
        /// </summary>
        [Property(xmiId: "25a6f648-493b-4a49-bebd-401e893df0f3", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "4c7374f5-78f8-42ab-ae42-672ad9c80902")]
        string OriginalType { get; set; }

        /// <summary>
        /// The conjugatedType of this Conjugation that is also its owningRelatedElement.
        /// </summary>
        [Property(xmiId: "ac96d8b3-4339-4e70-964b-d4be9f0fcc81", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "416f9595-3386-4e1b-b01e-57e62a6b49a4")]
        [SubsettedProperty(propertyName: "c81d146c-d738-40a0-ab80-8526beac3673")]
        string? GetOwningType { get; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
