// -------------------------------------------------------------------------------------------------
// <copyright file="IFeatureChaining.cs" company="Starion Group S.A.">
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

    using KerML.NET.DTO.Root.Elements;
    using KerML.NET.Decorators;
    using KerML.NET.Namespaces;
    using KerML.NET.Types;

    /// <summary>
    /// FeatureChaining is a Relationship that makes its target Feature one of the chainingFeatures of its
    /// owning Feature.
    /// </summary>
    [Class(xmiId: "7d79e5c0-21de-4f7b-999a-1896854037ca", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface IFeatureChaining : IRelationship
    {
        /// <summary>
        /// The Feature whose values partly determine values of featureChained, as described in
        /// Feature::chainingFeature.
        /// </summary>
        [Property(xmiId: "23d97038-3261-4f93-b9d0-5790d5196ebe", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "4c7374f5-78f8-42ab-ae42-672ad9c80902")]
        public new string ChainingFeature { get; set; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
