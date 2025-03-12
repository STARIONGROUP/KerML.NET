// -------------------------------------------------------------------------------------------------
// <copyright file="IFeatureTyping.cs" company="Starion Group S.A.">
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
    /// FeatureTyping is Specialization in which the specific Type is a Feature. This means the set of
    /// instances of the (specific) typedFeature is a subset of the set of instances of the (general) type.
    /// In the simplest case, the type is a Classifier, whereupon the typedFeature has values that are
    /// instances of the Classifier.
    /// </summary>
    [Class(xmiId: "0f0dd69d-e01b-4231-a0b5-c797c6bfc142", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface IFeatureTyping : ISpecialization
    {
        /// <summary>
        /// A typedFeature that is also the owningRelatedElement of this FeatureTyping.
        /// </summary>
        [Property(xmiId: "73c7f9ef-d8cf-4eb5-a2d6-86f3ddf9dd39", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "933b0b76-a63b-4055-98d6-73d1153f9064")]
        [RedefinedProperty(propertyName: "adeb1ff1-cb20-496c-b832-6ae775e10fd9")]
        string? GetOwningFeature { get; }

        /// <summary>
        /// The Type that is being applied by this FeatureTyping.
        /// </summary>
        [Property(xmiId: "637be91d-677d-4da1-a97e-6946c1b89889", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "6dd5c0f9-10e8-4361-90d4-723016f969f5")]
        string Type { get; set; }

        /// <summary>
        /// The Feature that has a type determined by this FeatureTyping.
        /// </summary>
        [Property(xmiId: "933b0b76-a63b-4055-98d6-73d1153f9064", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "f45c204e-a88a-4382-9701-ccc842d4a68a")]
        string TypedFeature { get; set; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
