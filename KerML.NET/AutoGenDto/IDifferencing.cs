﻿// -------------------------------------------------------------------------------------------------
// <copyright file="IDifferencing.cs" company="Starion Group S.A.">
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

namespace KerML.NET.DTO.Core.Types
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    using KerML.NET.DTO.Core.Types;
    using KerML.NET.DTO.Root.Annotations;
    using KerML.NET.DTO.Root.Elements;
    using KerML.NET.DTO.Root.Namespaces;

    using KerML.NET.Decorators;

    /// <summary>
    /// Differencing is a Relationship that makes its differencingType one of the differencingTypes of its
    /// typeDifferenced.
    /// </summary>
    [Class(xmiId: "887c3ec8-ed8f-434a-a993-2eff824ef796", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface IDifferencing : IRelationship
    {
        /// <summary>
        /// Type that partly determines interpretations of typeDifferenced, as described in
        /// Type::differencingType.
        /// </summary>
        [Property(xmiId: "fdf0f94a-d20b-4597-a464-5c0b1a98b56c", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "4c7374f5-78f8-42ab-ae42-672ad9c80902")]
        string DifferencingType { get; set; }

        /// <summary>
        /// Type with interpretations partly determined by differencingType, as described in
        /// Type::differencingType.
        /// </summary>
        [Property(xmiId: "52af1f1f-e0ab-47c8-8aae-0da34ec51d4f", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "c81d146c-d738-40a0-ab80-8526beac3673")]
        [RedefinedProperty(propertyName: "cd83f43d-3885-4b41-8f03-f02255e6a5da")]
        string GetTypeDifferenced { get; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
