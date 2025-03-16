// -------------------------------------------------------------------------------------------------
// <copyright file="IMultiplicityRange.cs" company="Starion Group S.A.">
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

namespace KerML.NET.DTO.Kernel.Multiplicities
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    using KerML.NET.Core.Types;
    using KerML.NET.DTO.Core.Features;
    using KerML.NET.DTO.Core.Types;
    using KerML.NET.DTO.Kernel.Functions;
    using KerML.NET.DTO.Root.Annotations;
    using KerML.NET.DTO.Root.Elements;
    using KerML.NET.DTO.Root.Namespaces;

    using KerML.NET.Decorators;

    /// <summary>
    /// A MultiplicityRange is a Multiplicity whose value is defined to be the (inclusive) range of natural
    /// numbers given by the result of a lowerBound Expression and the result of an upperBound Expression.
    /// The result of these Expressions shall be of type Natural. If the result of the upperBound Expression
    /// is the unbounded value *, then the specified range includes all natural numbers greater than or
    /// equal to the lowerBound value. If no lowerBound Expression, then the default is that the lower bound
    /// has the same value as the upper bound, except if the upperBound evaluates to *, in which case the
    /// default for the lower bound is 0.
    /// </summary>
    [Class(xmiId: "75a83cbe-61f8-4c24-9197-d56a3b7a75ae", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface IMultiplicityRange : IMultiplicity
    {
        /// <summary>
        /// The owned Expressions of the MultiplicityRange whose results provide its bounds. These must be the
        /// only ownedMembers of the MultiplicityRange.
        /// </summary>
        [Property(xmiId: "4bb7d4c4-1d9d-430e-b800-742937b52136", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 2, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "e77d17fa-39f5-4493-b101-5630bea6df70")]
        List<string> GetBound { get; }

        /// <summary>
        /// The Expression whose result provides the lower bound of the MultiplicityRange. If no lowerBound
        /// Expression is given, then the lower bound shall have the same value as the upper bound, unless the
        /// upper bound is unbounded (*), in which case the lower bound shall be 0.
        /// </summary>
        [Property(xmiId: "970548a2-16ef-4558-989c-57ae2e224b0b", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "4bb7d4c4-1d9d-430e-b800-742937b52136")]
        string? GetLowerBound { get; }

        /// <summary>
        /// The Expression whose result is the upper bound of the MultiplicityRange.
        /// </summary>
        [Property(xmiId: "d447f313-c541-45cd-8171-668f747036dc", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "4bb7d4c4-1d9d-430e-b800-742937b52136")]
        string GetUpperBound { get; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
