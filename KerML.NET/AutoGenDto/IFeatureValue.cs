// -------------------------------------------------------------------------------------------------
// <copyright file="IFeatureValue.cs" company="Starion Group S.A.">
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

namespace KerML.NET.DTO.Kernel.FeatureValues
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    using KerML.NET.DTO.Root.Namespaces;
    using KerML.NET.Decorators;
    using KerML.NET.Namespaces;
    using KerML.NET.Types;

    /// <summary>
    /// A FeatureValue is a Membership that identifies a particular member Expression that provides the
    /// value of the Feature that owns the FeatureValue. The value is specified as either a bound value or
    /// an initial value, and as either a concrete or default value. A Feature can have at most one
    /// FeatureValue.The result of the value Expression is bound to the featureWithValue using a
    /// BindingConnector. If isInitial = false, then the featuringType of the BindingConnector is the same
    /// as the featuringType of the featureWithValue. If isInitial = true, then the featuringType of the
    /// BindingConnector is restricted to its startShot.If isDefault = false, then the above semantics of
    /// the FeatureValue are realized for the given featureWithValue. Otherwise, the semantics are realized
    /// for any individual of the featuringType of the featureWithValue, unless another value is explicitly
    /// given for the featureWithValue for that individual.
    /// </summary>
    [Class(xmiId: "56ee4632-c7fd-4f57-b6b4-897f7b9dd712", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface IFeatureValue : IOwningMembership
    {
        /// <summary>
        /// Whether this FeatureValue is a concrete specification of the bound or initial value of the
        /// featureWithValue, or just a default value that may be overridden.
        /// </summary>
        [Property(xmiId: "15505862-8264-4ecd-a907-c6646e788f34", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: "false")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Whether this FeatureValue specifies a bound value or an initial value for the featureWithValue.
        /// </summary>
        [Property(xmiId: "5b913b24-a8c1-4b00-8af1-1d87bc5bb67c", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: "false")]
        public bool IsInitial { get; set; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
