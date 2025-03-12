// -------------------------------------------------------------------------------------------------
// <copyright file="IOwningMembership.cs" company="Starion Group S.A.">
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
    /// An OwningMembership is a Membership that owns its memberElement as a ownedRelatedElement. The
    /// ownedMemberElement becomes an ownedMember of the membershipOwningNamespace.
    /// </summary>
    [Class(xmiId: "0ac69c8b-1bab-45e9-82df-d840307444f7", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface IOwningMembership : IMembership
    {
        /// <summary>
        /// The Element that becomes an ownedMember of the membershipOwningNamespace due to this
        /// OwningMembership.
        /// </summary>
        [Property(xmiId: "c23da327-2bed-4f05-9fa2-9749097c6eca", aggregation: AggregationKind.Composite, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "27fc72b3-57ec-4aa5-a656-1e902c5d768a")]
        [RedefinedProperty(propertyName: "ea691af8-fe94-4d70-8a6f-7433b40c3398")]
        string GetOwnedMemberElement { get; }

        /// <summary>
        /// The elementId of the ownedMemberElement.
        /// </summary>
        [Property(xmiId: "46b967c5-57c8-42bd-a2bb-ff9293739afc", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "867c63ec-3922-4eaa-8c78-47ca3f9d04b8")]
        string GetOwnedMemberElementId { get; }

        /// <summary>
        /// The name of the ownedMemberElement.
        /// </summary>
        [Property(xmiId: "ad6df655-1655-4769-ae6d-ddc1ad53a4bd", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "edd22f54-2750-4e4f-bdf3-96edc70b3ca1")]
        string? GetOwnedMemberName { get; }

        /// <summary>
        /// The shortName of the ownedMemberElement.
        /// </summary>
        [Property(xmiId: "cf030abd-08d4-4739-9891-42b0a540203a", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "d9a35a1e-b312-4566-a773-c1a0897341c8")]
        string? GetOwnedMemberShortName { get; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
