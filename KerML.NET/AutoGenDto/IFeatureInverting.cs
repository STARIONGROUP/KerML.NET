// -------------------------------------------------------------------------------------------------
// <copyright file="IFeatureInverting.cs" company="Starion Group S.A.">
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
    using KerML.NET.DTO.Root.Annotations;
    using KerML.NET.DTO.Root.Elements;
    using KerML.NET.DTO.Root.Namespaces;

    using KerML.NET.Decorators;
    using KerML.NET.Namespaces;
    using KerML.NET.Types;

    /// <summary>
    /// A FeatureInverting is a Relationship between Features asserting that their interpretations
    /// (sequences) are the reverse of each other, identified as featureInverted and invertingFeature. For
    /// example, a Feature identifying each person&#39;s parents is the inverse of a Feature identifying
    /// each person&#39;s children. A person identified as a parent of another will identify that other as
    /// one of their children.
    /// </summary>
    [Class(xmiId: "19742ae9-e925-4fec-99cb-fcf43a063039", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface IFeatureInverting : IRelationship
    {
        /// <summary>
        /// The Feature that is an inverse of the invertingFeature.
        /// </summary>
        [Property(xmiId: "f4c5ac7d-9ed1-46da-a787-c595dfc5eeb0", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "cd83f43d-3885-4b41-8f03-f02255e6a5da")]
        string FeatureInverted { get; set; }

        /// <summary>
        /// The Feature that is an inverse of the invertedFeature.
        /// </summary>
        [Property(xmiId: "36f71aed-a12e-4332-8ca1-7000d7b4571f", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "4c7374f5-78f8-42ab-ae42-672ad9c80902")]
        string InvertingFeature { get; set; }

        /// <summary>
        /// A featureInverted that is also the owningRelatedElement of this FeatureInverting.
        /// </summary>
        [Property(xmiId: "b893a139-4098-4e9d-8794-d7ba21da6687", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "f4c5ac7d-9ed1-46da-a787-c595dfc5eeb0")]
        [SubsettedProperty(propertyName: "c81d146c-d738-40a0-ab80-8526beac3673")]
        string? GetOwningFeature { get; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
