// -------------------------------------------------------------------------------------------------
// <copyright file="IReferenceSubsetting.cs" company="Starion Group S.A.">
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

namespace KerML.NET.DTO.Core.Features
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    using KerML.NET.DTO.Core.Features;
    using KerML.NET.DTO.Core.Types;
    using KerML.NET.DTO.Root.Annotations;
    using KerML.NET.DTO.Root.Elements;
    using KerML.NET.DTO.Root.Namespaces;

    using KerML.NET.Decorators;
    using KerML.NET.Namespaces;
    using KerML.NET.Types;

    /// <summary>
    /// ReferenceSubsetting is a kind of Subsetting in which the referencedFeature is syntactically
    /// distinguished from other Features subsetted by the referencingFeature. ReferenceSubsetting has the
    /// same semantics as Subsetting, but the referenceFeature may have a special purpose relative to the
    /// referencingFeature. For instance, ReferenceSubsetting is used to identify the relatedFeatures of a
    /// Connector.ReferenceSubsetting is always an ownedRelationship of its referencingFeature. A Feature
    /// can have at most one ownedReferenceSubsetting.
    /// </summary>
    [Class(xmiId: "cce96e86-0574-4396-8c05-e7160bb4707a", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface IReferenceSubsetting : ISubsetting
    {
        /// <summary>
        /// The Feature that is referenced by the referencingFeature of this ReferenceSubsetting.
        /// </summary>
        [Property(xmiId: "3bbcf949-999f-49e4-9914-c273a7107f86", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "b8bb3b86-cf2d-451e-b3c1-6a3aecac5aa4")]
        string ReferencedFeature { get; set; }

        /// <summary>
        /// The Feature that owns this ReferenceSubsetting relationship, which is also its subsettingFeature.
        /// </summary>
        [Property(xmiId: "ac783c98-5d98-449b-9548-17fbab7b838a", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "43a01c3e-8273-4941-b616-2f8edcc0ac17")]
        [RedefinedProperty(propertyName: "20d11fe1-16c0-41fb-8823-559ce4084ebf")]
        string GetReferencingFeature { get; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
