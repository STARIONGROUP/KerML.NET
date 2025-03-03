// -------------------------------------------------------------------------------------------------
// <copyright file="IType.cs" company="Starion Group S.A.">
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

    using KerML.NET.DTO.Root.Namespaces;
    using KerML.NET.Decorators;
    using KerML.NET.Namespaces;
    using KerML.NET.Types;

    /// <summary>
    /// A Type is a Namespace that is the most general kind of Element supporting the semantics of
    /// classification. A Type may be a Classifier or a Feature, defining conditions on what is classified
    /// by the Type (see also the description of isSufficient).
    /// </summary>
    [Class(xmiId: "a32ae34b-57c2-4f49-832c-00f8741d55e7", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface IType : INamespace
    {
        /// <summary>
        /// Indicates whether instances of this Type must also be instances of at least one of its specialized
        /// Types.
        /// </summary>
        [Property(xmiId: "8ba5f657-df28-48f4-ac52-7e154eb63b38", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: "false")]
        public bool IsAbstract { get; set; }

        /// <summary>
        /// Whether all things that meet the classification conditions of this Type must be classified by the
        /// Type.(A Type gives conditions that must be met by whatever it classifies, but when isSufficient
        /// is false, things may meet those conditions but still not be classified by the Type. For example, a
        /// Type Car that is not sufficient could require everything it classifies to have four wheels, but not
        /// all four wheeled things would classify as cars. However, if the Type Car were sufficient, it would
        /// classify all four-wheeled things.)
        /// </summary>
        [Property(xmiId: "d77a343b-bf72-4b55-9419-c4973d9398d5", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: "false")]
        public bool IsSufficient { get; set; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
