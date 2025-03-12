// -------------------------------------------------------------------------------------------------
// <copyright file="ISubsetting.cs" company="Starion Group S.A.">
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
    /// Subsetting is Specialization in which the specific and general Types are Features. This means all
    /// values of the subsettingFeature (on instances of its domain, i.e., the intersection of its
    /// featuringTypes) are values of the subsettedFeature on instances of its domain. To support this the
    /// domain of the subsettingFeature must be the same or specialize (at least indirectly) the domain of
    /// the subsettedFeature (via Specialization), and the co-domain (intersection of the types) of the
    /// subsettingFeature must specialize the co-domain of the subsettedFeature.
    /// </summary>
    [Class(xmiId: "a26821f8-6af3-42a0-9043-03c372464172", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface ISubsetting : ISpecialization
    {
        /// <summary>
        /// A subsettingFeature that is also the owningRelatedElement of this Subsetting.
        /// </summary>
        [Property(xmiId: "43a01c3e-8273-4941-b616-2f8edcc0ac17", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "20d11fe1-16c0-41fb-8823-559ce4084ebf")]
        [RedefinedProperty(propertyName: "adeb1ff1-cb20-496c-b832-6ae775e10fd9")]
        string? GetOwningFeature { get; }

        /// <summary>
        /// The Feature that is subsetted by the subsettingFeature of this Subsetting.
        /// </summary>
        [Property(xmiId: "b8bb3b86-cf2d-451e-b3c1-6a3aecac5aa4", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "6dd5c0f9-10e8-4361-90d4-723016f969f5")]
        string SubsettedFeature { get; set; }

        /// <summary>
        /// The Feature that is a subset of the subsettedFeature of this Subsetting.
        /// </summary>
        [Property(xmiId: "20d11fe1-16c0-41fb-8823-559ce4084ebf", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "f45c204e-a88a-4382-9701-ccc842d4a68a")]
        string SubsettingFeature { get; set; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
