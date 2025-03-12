// -------------------------------------------------------------------------------------------------
// <copyright file="IMembership.cs" company="Starion Group S.A.">
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
    /// A Membership is a Relationship between a Namespace and an Element that indicates the Element is a
    /// member of (i.e., is contained in) the Namespace. Any memberNames specify how the memberElement is
    /// identified in the Namespace and the visibility specifies whether or not the memberElement is
    /// publicly visible from outside the Namespace.If a Membership is an OwningMembership, then it owns its
    /// memberElement, which becomes an ownedMember of the membershipOwningNamespace. Otherwise, the
    /// memberNames of a Membership are effectively aliases within the membershipOwningNamespace for an
    /// Element with a separate OwningMembership in the same or a different Namespace. 
    /// </summary>
    [Class(xmiId: "aac28989-9501-4cdb-a0de-5be645062d3c", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface IMembership : IRelationship
    {
        /// <summary>
        /// The Element that becomes a member of the membershipOwningNamespace due to this Membership.
        /// </summary>
        [Property(xmiId: "ea691af8-fe94-4d70-8a6f-7433b40c3398", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "4c7374f5-78f8-42ab-ae42-672ad9c80902")]
        string MemberElement { get; set; }

        /// <summary>
        /// The elementId of the memberElement.
        /// </summary>
        [Property(xmiId: "867c63ec-3922-4eaa-8c78-47ca3f9d04b8", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        string GetMemberElementId { get; }

        /// <summary>
        /// The name of the memberElement relative to the membershipOwningNamespace.
        /// </summary>
        [Property(xmiId: "edd22f54-2750-4e4f-bdf3-96edc70b3ca1", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        string? MemberName { get; set; }

        /// <summary>
        /// The Namespace of which the memberElement becomes a member due to this Membership.
        /// </summary>
        [Property(xmiId: "67aded9a-ae8a-4191-8053-2df04cce9c8c", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "84afb4bc-eed8-491b-bcf4-169870b700a8")]
        [SubsettedProperty(propertyName: "c81d146c-d738-40a0-ab80-8526beac3673")]
        [RedefinedProperty(propertyName: "cd83f43d-3885-4b41-8f03-f02255e6a5da")]
        string GetMembershipOwningNamespace { get; }

        /// <summary>
        /// The short name of the memberElement relative to the membershipOwningNamespace.
        /// </summary>
        [Property(xmiId: "d9a35a1e-b312-4566-a773-c1a0897341c8", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        string? MemberShortName { get; set; }

        /// <summary>
        /// Whether or not the Membership of the memberElement in the membershipOwningNamespace is publicly
        /// visible outside that Namespace.
        /// </summary>
        [Property(xmiId: "5901151e-f794-4fe3-bda3-fda18dd23c41", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: "public")]
        VisibilityKind Visibility { get; set; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
