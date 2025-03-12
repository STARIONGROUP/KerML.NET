// -------------------------------------------------------------------------------------------------
// <copyright file="IFeatureChainExpression.cs" company="Starion Group S.A.">
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

namespace KerML.NET.DTO.Kernel.Expressions
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    using KerML.NET.DTO.Core.Features;
    using KerML.NET.DTO.Core.Types;
    using KerML.NET.DTO.Kernel.Behaviors;
    using KerML.NET.DTO.Kernel.Expressions;
    using KerML.NET.DTO.Kernel.Functions;
    using KerML.NET.DTO.Root.Annotations;
    using KerML.NET.DTO.Root.Elements;
    using KerML.NET.DTO.Root.Namespaces;

    using KerML.NET.Decorators;
    using KerML.NET.Namespaces;
    using KerML.NET.Types;

    /// <summary>
    /// A FeatureChainExpression is an OperatorExpression whose operator is ".", which resolves to the
    /// Function ControlFunctions::'.' from the Kernel Functions Library. It evaluates to the result of
    /// chaining the result Feature of its single argument Expression with its targetFeature.
    /// </summary>
    [Class(xmiId: "40ee2207-a638-4d8d-8ef3-6b9d5deeddd5", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface IFeatureChainExpression : IOperatorExpression
    {
        /// <summary>
        /// </summary>
        [Property(xmiId: "553a107a-ef1a-475e-a210-a02aa4b4f67c", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: ".")]
        [RedefinedProperty(propertyName: "70aa2b17-758f-4426-8b45-52253479ca7c")]
        string Operator { get; set; }

        /// <summary>
        /// The Feature that is accessed by this FeatureChainExpression, which is its first non-parameter
        /// member.
        /// </summary>
        [Property(xmiId: "ac7c4937-8e0b-4f9a-8ba5-f645f90afc49", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "9098f21e-06d6-46cd-b1c6-3ccde8f5d8bb")]
        string GetTargetFeature { get; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
