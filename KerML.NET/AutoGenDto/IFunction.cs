// -------------------------------------------------------------------------------------------------
// <copyright file="IFunction.cs" company="Starion Group S.A.">
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

    using KerML.NET.DTO.Core.Classifiers;
    using KerML.NET.DTO.Core.Features;
    using KerML.NET.DTO.Core.Types;
    using KerML.NET.DTO.Kernel.Behaviors;
    using KerML.NET.DTO.Kernel.Functions;
    using KerML.NET.DTO.Root.Annotations;
    using KerML.NET.DTO.Root.Elements;
    using KerML.NET.DTO.Root.Namespaces;

    using KerML.NET.Decorators;

    /// <summary>
    /// A Function is a Behavior that has an out parameter that is identified as its result. A Function
    /// represents the performance of a calculation that produces the values of its result parameter. This
    /// calculation may be decomposed into Expressions that are steps of the Function.
    /// </summary>
    [Class(xmiId: "6993b54e-1ab7-4c4e-a4c0-d71e5863f252", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface IFunction : IBehavior
    {
        /// <summary>
        /// The Expressions that are steps in the calculation of the result of this Function.
        /// </summary>
        [Property(xmiId: "3d432c24-7906-4789-8045-e6680f82a73a", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "2c467a8c-0933-4cd4-a26d-43970229f665")]
        List<string> GetExpression { get; }

        /// <summary>
        /// Whether this Function can be used as the function of a model-level evaluable InvocationExpression.
        /// Certain Functions from the Kernel Functions Library are considered to have isModelLevelEvaluable =
        /// true. For all other Functions it is false.<strong>Note:</strong> See the specification of the KerML
        /// concrete syntax notation for Expressions for an identification of which library Functions are
        /// model-level evaluable.
        /// </summary>
        [Property(xmiId: "1dd6f94c-218a-43c4-95e5-898ffe7bbd35", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        bool GetIsModelLevelEvaluable { get; }

        /// <summary>
        /// The object or value that is the result of evaluating the Function.
        /// </summary>
        [Property(xmiId: "eb936218-1650-422d-a48d-efd692684fc2", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "f33f29d7-3216-4ab5-9298-4fd27cf976f2")]
        [SubsettedProperty(propertyName: "d425d748-88fa-4431-8ae7-760c6945a9d0")]
        string GetResult { get; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
