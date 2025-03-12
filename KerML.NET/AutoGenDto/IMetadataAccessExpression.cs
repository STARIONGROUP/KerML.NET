// -------------------------------------------------------------------------------------------------
// <copyright file="IMetadataAccessExpression.cs" company="Starion Group S.A.">
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
    using KerML.NET.DTO.Kernel.Functions;
    using KerML.NET.DTO.Root.Annotations;
    using KerML.NET.DTO.Root.Elements;
    using KerML.NET.DTO.Root.Namespaces;

    using KerML.NET.Decorators;
    using KerML.NET.Namespaces;
    using KerML.NET.Types;

    /// <summary>
    /// A MetadataAccessExpression is an Expression whose result is a sequence of instances of Metaclasses
    /// representing all the MetadataFeature annotations of the referencedElement. In addition, the sequence
    /// includes an instance of the reflective Metaclass corresponding to the MOF class of the
    /// referencedElement, with values for all the abstract syntax properties of the referencedElement.
    /// </summary>
    [Class(xmiId: "952262ce-7687-4374-aca0-3ecfabf2e9e0", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface IMetadataAccessExpression : IExpression
    {
        /// <summary>
        /// The Element whose metadata is being accessed.
        /// </summary>
        [Property(xmiId: "fcc25c98-f6f9-476f-9869-ddb9098f45d1", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        string ReferencedElement { get; set; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
