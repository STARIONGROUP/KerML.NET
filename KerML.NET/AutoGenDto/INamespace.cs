// -------------------------------------------------------------------------------------------------
// <copyright file="INamespace.cs" company="Starion Group S.A.">
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

    using KerML.NET.DTO.Root.Annotations;
    using KerML.NET.DTO.Root.Elements;
    using KerML.NET.DTO.Root.Namespaces;

    using KerML.NET.Decorators;
    using KerML.NET.Namespaces;
    using KerML.NET.Types;

    /// <summary>
    /// A Namespace is an Element that contains other Elements, known as its members, via Membership
    /// Relationships with those Elements. The members of a Namespace may be owned by the Namespace, aliased
    /// in the Namespace, or imported into the Namespace via Import Relationships.A Namespace can provide
    /// names for its members via the memberNames and memberShortNames specified by the Memberships in the
    /// Namespace. If a Membership specifies a memberName and/or memberShortName, then those are names of
    /// the corresponding memberElement relative to the Namespace. For an OwningMembership, the
    /// owningMemberName and owningMemberShortName are given by the Element name and shortName. Note that
    /// the same Element may be the memberElement of multiple Memberships in a Namespace (though it may be
    /// owned at most once), each of which may define a separate alias for the Element relative to the
    /// Namespace.
    /// </summary>
    [Class(xmiId: "16a893ca-c85b-4a48-989a-fc24520fc6d6", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface INamespace : IElement
    {
        /// <summary>
        /// The Memberships in this Namespace that result from the ownedImports of this Namespace.
        /// </summary>
        [Property(xmiId: "88e42ee1-8909-4ebd-b5df-cca0a4c44be4", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "596739a5-b42a-40d6-af0c-89cddf2d7768")]
        List<string> GetImportedMembership { get; }

        /// <summary>
        /// The set of all member Elements of this Namespace, which are the memberElements of all memberships of
        /// the Namespace.
        /// </summary>
        [Property(xmiId: "9098f21e-06d6-46cd-b1c6-3ccde8f5d8bb", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        List<string> GetMember { get; }

        /// <summary>
        /// All Memberships in this Namespace, including (at least) the union of ownedMemberships and
        /// importedMemberships.
        /// </summary>
        [Property(xmiId: "596739a5-b42a-40d6-af0c-89cddf2d7768", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: true, isUnique: false, defaultValue: null)]
        List<string> GetMembership { get; }

        /// <summary>
        /// The ownedRelationships of this Namespace that are Imports, for which the Namespace is the
        /// importOwningNamespace.
        /// </summary>
        [Property(xmiId: "d382696c-18ad-4754-8872-cf777875c8c6", aggregation: AggregationKind.Composite, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "9a0cb697-5a6b-4fa8-806e-ea6c79d5ada9")]
        [SubsettedProperty(propertyName: "fd194ed0-9544-4215-b3df-64c5423ec874")]
        List<string> GetOwnedImport { get; }

        /// <summary>
        /// The owned members of this Namespace, which are the <cpde>ownedMemberElements of the ownedMemberships
        /// of the Namespace.</cpde>
        /// </summary>
        [Property(xmiId: "e77d17fa-39f5-4493-b101-5630bea6df70", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "9098f21e-06d6-46cd-b1c6-3ccde8f5d8bb")]
        List<string> GetOwnedMember { get; }

        /// <summary>
        /// The ownedRelationships of this Namespace that are Memberships, for which the Namespace is the
        /// membershipOwningNamespace.
        /// </summary>
        [Property(xmiId: "fad0c25d-2a44-4e7a-9b06-bae16320cb4e", aggregation: AggregationKind.Composite, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "596739a5-b42a-40d6-af0c-89cddf2d7768")]
        [SubsettedProperty(propertyName: "fd194ed0-9544-4215-b3df-64c5423ec874")]
        [SubsettedProperty(propertyName: "9a0cb697-5a6b-4fa8-806e-ea6c79d5ada9")]
        List<string> GetOwnedMembership { get; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
