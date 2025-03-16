// -------------------------------------------------------------------------------------------------
// <copyright file="IRedefinition.cs" company="Starion Group S.A.">
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

    /// <summary>
    /// Redefinition is a kind of Subsetting that requires the redefinedFeature and the redefiningFeature to
    /// have the same values (on each instance of the domain of the redefiningFeature). This means any
    /// restrictions on the redefiningFeature, such as type or multiplicity, also apply to the
    /// redefinedFeature (on each instance of the domain of the redefiningFeature), and vice versa. The
    /// redefinedFeature might have values for instances of the domain of the redefiningFeature, but only as
    /// instances of the domain of the redefinedFeature that happen to also be instances of the domain of
    /// the redefiningFeature. This is supported by the constraints inherited from Subsetting on the domains
    /// of the redefiningFeature and redefinedFeature. However, these constraints are narrowed for
    /// Redefinition to require the owningTypes of the redefiningFeature and redefinedFeature to be
    /// different and the redefinedFeature to not be inherited into the owningNamespace of the
    /// redefiningFeature.This enables the redefiningFeature to have the same name as the redefinedFeature,
    /// if desired.
    /// </summary>
    [Class(xmiId: "df9c1df6-7aa0-41af-8adb-8cdd7a47738f", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface IRedefinition : ISubsetting
    {
        /// <summary>
        /// The Feature that is redefined by the redefiningFeature of this Redefinition.
        /// </summary>
        [Property(xmiId: "c30433b4-031a-4ee7-8b11-9d39cbb35d39", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "b8bb3b86-cf2d-451e-b3c1-6a3aecac5aa4")]
        string RedefinedFeature { get; set; }

        /// <summary>
        /// The Feature that is redefining the redefinedFeature of this Redefinition.
        /// </summary>
        [Property(xmiId: "f5092d04-2553-4bcd-9c80-2e0e8d70d2fc", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "20d11fe1-16c0-41fb-8823-559ce4084ebf")]
        string RedefiningFeature { get; set; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
