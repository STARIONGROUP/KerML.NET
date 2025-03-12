// -------------------------------------------------------------------------------------------------
// <copyright file="IExpression.cs" company="Starion Group S.A.">
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

namespace KerML.NET.DTO.Kernel.Functions
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    using KerML.NET.DTO.Core.Features;
    using KerML.NET.DTO.Core.Types;
    using KerML.NET.DTO.Kernel.Behaviors;
    using KerML.NET.DTO.Kernel.Functions;
    using KerML.NET.DTO.Root.Annotations;
    using KerML.NET.DTO.Root.Elements;
    using KerML.NET.DTO.Root.Namespaces;

    using KerML.NET.Decorators;
    using KerML.NET.Namespaces;
    using KerML.NET.Types;

    /// <summary>
    /// An Expression is a Step that is typed by a Function. An Expression that also has a Function as its
    /// featuringType is a computational step within that Function. An Expression always has a single result
    /// parameter, which redefines the result parameter of its defining function. This allows Expressions to
    /// be interconnected in tree structures, in which inputs to each Expression in the tree are determined
    /// as the results of other Expression in the tree.
    /// </summary>
    [Class(xmiId: "e8904b17-7bf3-47eb-b907-a6efe22c56b7", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface IExpression : IStep
    {
        /// <summary>
        /// The Function that types this Expression.
        /// </summary>
        [Property(xmiId: "2e507a50-ac61-442c-8efa-716bfc5e6ff9", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "4f6477ef-2deb-4f17-a41e-e2aa01f6bb7e")]
        string? GetFunction { get; }

        /// <summary>
        /// Whether this Expression meets the constraints necessary to be evaluated at model level, that is,
        /// using metadata within the model.
        /// </summary>
        [Property(xmiId: "979f5a07-f7a7-456a-b708-72f2db2b62c7", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        bool GetIsModelLevelEvaluable { get; }

        /// <summary>
        /// An output parameter of the Expression whose value is the result of the Expression. The result of an
        /// Expression is either inherited from its function or it is related to the Expression via a
        /// ReturnParameterMembership, in which case it redefines the result parameter of its function.
        /// </summary>
        [Property(xmiId: "16d0e627-990b-4388-9c7c-591ab204b49a", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "f33f29d7-3216-4ab5-9298-4fd27cf976f2")]
        [SubsettedProperty(propertyName: "5568f668-7e98-4b99-a40f-7c2eecde3db2")]
        string GetResult { get; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
