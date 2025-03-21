﻿// -------------------------------------------------------------------------------------------------
// <copyright file="IImport.cs" company="Starion Group S.A.">
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

namespace KerML.NET.DTO.Root.Namespaces
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    using KerML.NET.Root.Namespaces;
    using KerML.NET.DTO.Root.Annotations;
    using KerML.NET.DTO.Root.Elements;
    using KerML.NET.DTO.Root.Namespaces;

    using KerML.NET.Decorators;

    /// <summary>
    /// An Import is an Relationship between its importOwningNamespace and either a Membership (for a
    /// MembershipImport) or another Namespace (for a NamespaceImport), which determines a set of
    /// Memberships that become importedMemberships of the importOwningNamespace. If isImportAll = false
    /// (the default), then only public Memberships are considered &quot;visible&quot;. If isImportAll =
    /// true, then all Memberships are considered &quot;visible&quot;, regardless of their declared
    /// visibility. If isRecursive = true, then visible Memberships are also recursively imported from owned
    /// sub-Namespaces.
    /// </summary>
    [Class(xmiId: "8f66fb8b-4fcf-4857-aa40-e913ab2adeb4", isAbstract: true, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface IImport : IRelationship
    {
        /// <summary>
        /// The effectively imported Element for this Import. For a MembershipImport, this is the memberElement
        /// of the importedMembership. For a NamespaceImport, it is the importedNamespace.
        /// </summary>
        [Property(xmiId: "fc380ea3-2822-4ee3-84e8-c8bd84e1b793", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        string GetImportedElement { get; }

        /// <summary>
        /// The Namespace into which Memberships are imported by this Import, which must be the
        /// owningRelatedElement of the Import.
        /// </summary>
        [Property(xmiId: "271bd60d-3a80-49f3-9104-4657faeea3ff", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "c81d146c-d738-40a0-ab80-8526beac3673")]
        [RedefinedProperty(propertyName: "cd83f43d-3885-4b41-8f03-f02255e6a5da")]
        string GetImportOwningNamespace { get; }

        /// <summary>
        /// Whether to import memberships without regard to declared visibility.
        /// </summary>
        [Property(xmiId: "6f60838b-0e5b-44f0-af95-718a85fb22eb", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: "false")]
        bool IsImportAll { get; set; }

        /// <summary>
        /// Whether to recursively import Memberships from visible, owned sub-Namespaces.
        /// </summary>
        [Property(xmiId: "f3532740-fb74-407d-92e3-037e7bb482a1", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: "false")]
        bool IsRecursive { get; set; }

        /// <summary>
        /// The visibility level of the imported members from this Import relative to the importOwningNamespace.
        /// The default is private.
        /// </summary>
        [Property(xmiId: "58d5073c-91b9-4051-ba14-ea60c17342a8", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: "private")]
        VisibilityKind Visibility { get; set; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
