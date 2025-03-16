// -------------------------------------------------------------------------------------------------
// <copyright file="IElementFilterMembership.cs" company="Starion Group S.A.">
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

    using KerML.NET.Root.Namespaces;
    using KerML.NET.DTO.Kernel.Functions;
    using KerML.NET.DTO.Root.Annotations;
    using KerML.NET.DTO.Root.Elements;
    using KerML.NET.DTO.Root.Namespaces;

    using KerML.NET.Decorators;

    /// <summary>
    /// ElementFilterMembership is a Membership between a Namespace and a model-level evaluable
    /// Boolean-valued Expression, asserting that imported members of the Namespace should be filtered using
    /// the condition Expression. A general Namespace does not define any specific filtering behavior, but
    /// such behavior may be defined for various specialized kinds of Namespaces.
    /// </summary>
    [Class(xmiId: "901febc8-3ed1-45bf-8a99-348ef65a0589", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface IElementFilterMembership : IOwningMembership
    {
        /// <summary>
        /// The model-level evaluable Boolean-valued Expression used to filter the imported members of the
        /// membershipOwningNamespace of this ElementFilterMembership.
        /// </summary>
        [Property(xmiId: "37cbbe8d-6a19-4fa9-ba1d-76166dc6b828", aggregation: AggregationKind.Composite, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "c23da327-2bed-4f05-9fa2-9749097c6eca")]
        string GetCondition { get; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
