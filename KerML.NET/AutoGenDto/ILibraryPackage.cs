// -------------------------------------------------------------------------------------------------
// <copyright file="ILibraryPackage.cs" company="Starion Group S.A.">
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

namespace KerML.NET.DTO.Kernel.Packages
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    using KerML.NET.DTO.Kernel.Packages;
    using KerML.NET.Decorators;
    using KerML.NET.Namespaces;
    using KerML.NET.Types;

    /// <summary>
    /// A LibraryPackage is a Package that is the container for a model library. A LibraryPackage is itself
    /// a library Element as are all Elements that are directly or indirectly contained in it.
    /// </summary>
    [Class(xmiId: "5ff2aa81-bad0-4a7b-b241-74b19634d58d", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface ILibraryPackage : IPackage
    {
        /// <summary>
        /// Whether this LibraryPackage contains a standard library model. This should only be set to true for
        /// LibraryPackages in the standard Kernel Model Libraries or in normative model libraries for a
        /// language built on KerML.
        /// </summary>
        [Property(xmiId: "24d847c2-8227-41f1-865e-4bd5d1e5e8f7", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: "false")]
        public bool IsStandard { get; set; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
