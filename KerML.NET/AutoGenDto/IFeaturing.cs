// -------------------------------------------------------------------------------------------------
// <copyright file="IFeaturing.cs" company="Starion Group S.A.">
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
    /// Featuring is a Relationship between a Type and a Feature that is featured by that Type. It asserts
    /// that every instance in the domain of the feature must be classified by the type.Featuring is
    /// abstract and does not commit to which of feature or type are the source or target of the
    /// Relationship. This commitment is made in the subclasses of Featuring, TypeFeaturing and
    /// FeatureMembership, which have opposite directions.
    /// </summary>
    [Class(xmiId: "6b39d50b-0fa2-46c4-88e1-14ea53f05f8b", isAbstract: true, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface IFeaturing : IRelationship
    {
        /// <summary>
        /// The Feature that is featured by the featuringType.
        /// </summary>
        [Property(xmiId: "e3585351-105e-4e50-9547-2974f25f09a4", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "0d55f45c-0032-4618-9131-61ed58c3b8e2")]
        string Feature { get; set; }

        /// <summary>
        /// The Type that features the featureOfType.
        /// </summary>
        [Property(xmiId: "35ddd42a-b8a5-4ea6-b2d1-ab7d0a827a00", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "0d55f45c-0032-4618-9131-61ed58c3b8e2")]
        string Type { get; set; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
