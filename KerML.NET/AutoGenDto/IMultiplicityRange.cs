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

    using KerML.NET.DTO.Core.Types;
    using KerML.NET.Decorators;
    using KerML.NET.Namespaces;
    using KerML.NET.Types;

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
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
