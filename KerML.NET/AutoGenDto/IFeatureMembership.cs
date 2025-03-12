// -------------------------------------------------------------------------------------------------
// <copyright file="IFeatureMembership.cs" company="Starion Group S.A.">
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

    using KerML.NET.DTO.Core.Features;
    using KerML.NET.DTO.Core.Types;
    using KerML.NET.DTO.Root.Annotations;
    using KerML.NET.DTO.Root.Elements;
    using KerML.NET.DTO.Root.Namespaces;

    using KerML.NET.Decorators;
    using KerML.NET.Namespaces;
    using KerML.NET.Types;

    /// <summary>
    /// A FeatureMembership is an OwningMembership between a Feature in an owningType that is also a
    /// Featuring Relationship between the Feature and the Type, in which the featuringType is the source
    /// and the featureOfType is the target. A FeatureMembership is always owned by its owningType, which is
    /// the featuringType for the FeatureMembership considered as a Featuring.
    /// </summary>
    [Class(xmiId: "10189040-993c-4d64-aacf-0d99b558af68", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface IFeatureMembership : IFeaturing, IOwningMembership
    {
        /// <summary>
        /// The Feature that this FeatureMembership relates to its owningType, making it an ownedFeature of the
        /// owningType.
        /// </summary>
        [Property(xmiId: "6bf83eae-2d89-4ea9-8c7b-92d8ef26bfaa", aggregation: AggregationKind.Composite, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "e3585351-105e-4e50-9547-2974f25f09a4")]
        [RedefinedProperty(propertyName: "c23da327-2bed-4f05-9fa2-9749097c6eca")]
        string GetOwnedMemberFeature { get; }

        /// <summary>
        /// The Type that owns this FeatureMembership.
        /// </summary>
        [Property(xmiId: "b698b27c-2d6a-4cc5-a202-ab3d3cb5ec2a", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "2ef320b9-d900-484f-ab11-5aa59e441577")]
        [RedefinedProperty(propertyName: "35ddd42a-b8a5-4ea6-b2d1-ab7d0a827a00")]
        [RedefinedProperty(propertyName: "67aded9a-ae8a-4191-8053-2df04cce9c8c")]
        string GetOwningType { get; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
