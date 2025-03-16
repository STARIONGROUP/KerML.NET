// -------------------------------------------------------------------------------------------------
// <copyright file="ITypeFeaturing.cs" company="Starion Group S.A.">
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

    /// <summary>
    /// A TypeFeaturing is a Featuring Relationship in which the featureOfType is the source and the
    /// featuringType is the target.
    /// </summary>
    [Class(xmiId: "f6581ab1-844e-4f0b-b4da-8f9eb207fec0", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface ITypeFeaturing : IFeaturing
    {
        /// <summary>
        /// The Feature that is featured by the featuringType. It is the source of the TypeFeaturing.
        /// </summary>
        [Property(xmiId: "02d8e7c6-f578-46e2-8b60-8f6781e3c76a", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "cd83f43d-3885-4b41-8f03-f02255e6a5da")]
        [RedefinedProperty(propertyName: "e3585351-105e-4e50-9547-2974f25f09a4")]
        string FeatureOfType { get; set; }

        /// <summary>
        /// The Type that features the featureOfType. It is the target of the TypeFeaturing.
        /// </summary>
        [Property(xmiId: "fd727563-b8f6-4727-b5a1-ec338e551951", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "4c7374f5-78f8-42ab-ae42-672ad9c80902")]
        [RedefinedProperty(propertyName: "35ddd42a-b8a5-4ea6-b2d1-ab7d0a827a00")]
        string FeaturingType { get; set; }

        /// <summary>
        /// A featureOfType that is also the owningRelatedElement of this TypeFeaturing.
        /// </summary>
        [Property(xmiId: "5b10450f-fcde-4a1a-8688-24625e1b6dd0", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "c81d146c-d738-40a0-ab80-8526beac3673")]
        [SubsettedProperty(propertyName: "02d8e7c6-f578-46e2-8b60-8f6781e3c76a")]
        string? GetOwningFeatureOfType { get; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
