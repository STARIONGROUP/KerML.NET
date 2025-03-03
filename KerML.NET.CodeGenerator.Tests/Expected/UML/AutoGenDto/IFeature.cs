// -------------------------------------------------------------------------------------------------
// <copyright file="IFeature.cs" company="Starion Group S.A.">
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

    using KerML.NET.DTO.Core.Types;
    using KerML.NET.Decorators;
    using KerML.NET.Namespaces;
    using KerML.NET.Types;

    /// <summary>
    /// A Feature is a Type that classifies relations between multiple things (in the universe). The domain
    /// of the relation is the intersection of the featuringTypes of the Feature. (The domain of a Feature
    /// with no featuringTyps is implicitly the most general Type Base::Anything from the Kernel Semantic
    /// Library.) The co-domain of the relation is the intersection of the types of the Feature.In the
    /// simplest cases, the featuringTypes and types are Classifiers and the Feature relates two things, one
    /// from the domain and one from the range. Examples include cars paired with wheels, people paired with
    /// other people, and cars paired with numbers representing the car length.Since Features are Types,
    /// their featuringTypes and types can be Features. In this case, the Feature effectively classifies
    /// relations between relations, which can be interpreted as the sequence of things related by the
    /// domain Feature concatenated with the sequence of things related by the co-domain Feature.The values
    /// of a Feature for a given instance of its domain are all the instances of its co-domain that are
    /// related to that domain instance by the Feature. The values of a Feature with chainingFeatures are
    /// the same as values of the last Feature in the chain, which can be found by starting with values of
    /// the first Feature, then using those values as domain instances to obtain valus of the second
    /// Feature, and so on, to values of the last Feature.
    /// </summary>
    [Class(xmiId: "56b2e3ab-f2e5-4330-9c25-362cb4af825d", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface IFeature : IType
    {
        /// <summary>
        /// Indicates how values of this Feature are determined or used (as specified for the
        /// FeatureDirectionKind).
        /// </summary>
        [Property(xmiId: "223be62d-afd1-4955-b258-78902bbc83e8", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        public FeatureDirectionKind? Direction { get; set; }

        /// <summary>
        /// Whether the Feature is a composite feature of its featuringType. If so, the values of the Feature
        /// cannot exist after its featuring instance no longer does.
        /// </summary>
        [Property(xmiId: "5c603204-888c-435b-980f-5b21617df027", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: "false")]
        public bool IsComposite { get; set; }

        /// <summary>
        /// Whether the values of this Feature can always be computed from the values of other Features.
        /// </summary>
        [Property(xmiId: "fb250937-23af-4b97-afc5-aedb5f2734f6", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: "false")]
        public bool IsDerived { get; set; }

        /// <summary>
        /// Whether or not this Feature is an end Feature. An end Feature always has multiplicity 1, mapping
        /// each of its domain instances to a single co-domain instance. However, it may have a crossFeature, in
        /// which case values of the crossFeature must be the same as those found by navigation across instances
        /// of the owningType from values of other end Features to values of this Feature. If the owningType has
        /// n end Features, then the multiplicity, ordering, and uniqueness declared for the crossFeature of any
        /// one of these end Features constrains the cardinality, ordering, and uniqueness of the collection of
        /// values of that Feature reached by navigation when the values of the other n-1 end Features are held
        /// fixed.
        /// </summary>
        [Property(xmiId: "7106639b-7eaa-43c0-9f16-3ee22064145c", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: "false")]
        public bool IsEnd { get; set; }

        /// <summary>
        /// Whether an order exists for the values of this Feature or not.
        /// </summary>
        [Property(xmiId: "64e2167d-05dc-49ab-a30b-befdbe17c100", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: "false")]
        public bool IsOrdered { get; set; }

        /// <summary>
        /// Whether the values of this Feature are contained in the space and time of instances of the domain of
        /// the Feature and represent the same thing as those instances.
        /// </summary>
        [Property(xmiId: "ecaa2470-9287-4437-809a-38d344328298", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: "false")]
        public bool IsPortion { get; set; }

        /// <summary>
        /// Whether the values of this Feature can change over the lifetime of an instance of the domain.
        /// </summary>
        [Property(xmiId: "4aad3e9c-a931-4bef-9d81-a7650840ce2f", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: "false")]
        public bool IsReadOnly { get; set; }

        /// <summary>
        /// Whether or not values for this Feature must have no duplicates or not.
        /// </summary>
        [Property(xmiId: "a74e590e-8750-4378-a370-f6e196b41fc2", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: "true")]
        public bool IsUnique { get; set; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
