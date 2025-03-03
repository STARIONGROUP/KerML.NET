// -------------------------------------------------------------------------------------------------
// <copyright file="IInvariant.cs" company="Starion Group S.A.">
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

    using KerML.NET.DTO.Kernel.Functions;
    using KerML.NET.Decorators;
    using KerML.NET.Namespaces;
    using KerML.NET.Types;

    /// <summary>
    /// An Invariant is a BooleanExpression that is asserted to have a specific Boolean result value. If
    /// isNegated = false, then the result is asserted to be true. If isNegated = true, then the result is
    /// asserted to be false.
    /// </summary>
    [Class(xmiId: "9bc8e006-7107-451a-9eea-22fa8b2a33c2", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface IInvariant : IBooleanExpression
    {
        /// <summary>
        /// Whether this Invariant is asserted to be false rather than true.
        /// </summary>
        [Property(xmiId: "30bc499c-2f9e-4372-b136-43b10076f1ad", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: "false")]
        public bool IsNegated { get; set; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
