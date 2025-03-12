// -------------------------------------------------------------------------------------------------
// <copyright file="IConnector.cs" company="Starion Group S.A.">
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

namespace KerML.NET.DTO.Kernel.Connectors
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    using KerML.NET.DTO.Core.Features;
    using KerML.NET.DTO.Core.Types;
    using KerML.NET.DTO.Kernel.Associations;
    using KerML.NET.DTO.Root.Annotations;
    using KerML.NET.DTO.Root.Elements;
    using KerML.NET.DTO.Root.Namespaces;

    using KerML.NET.Decorators;
    using KerML.NET.Namespaces;
    using KerML.NET.Types;

    /// <summary>
    /// A Connector is a usage of Associations, with links restricted according to instances of the Type in
    /// which they are used (domain of the Connector). The associations of the Connector restrict what kinds
    /// of things might be linked. The Connector further restricts these links to be between values of
    /// Features on instances of its domain.
    /// </summary>
    [Class(xmiId: "f9615571-b95b-49e4-a007-0ce847e62696", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface IConnector : IFeature, IRelationship
    {
        /// <summary>
        /// The Associations that type the Connector.
        /// </summary>
        [Property(xmiId: "e15018cb-6a4b-48b2-b818-d21f0622c267", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "2dd9a8a5-bc46-421d-bc22-89f91e4b6ffe")]
        List<string> GetAssociation { get; }

        /// <summary>
        /// The endFeatures of a Connector, which redefine the endFeatures of the associations of the Connector.
        /// The connectorEnds determine via ReferenceSubsetting Relationships which Features are related by the
        /// Connector.
        /// </summary>
        [Property(xmiId: "cf2b6440-1987-451c-b676-389e1aaa7122", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "5979d447-4d72-4ffb-a569-ddbe6aacc8dd")]
        List<string> GetConnectorEnd { get; }

        /// <summary>
        /// The Features that are related by this Connector considered as a Relationship and that restrict the
        /// links it identifies, given by the referenced Features of the connectorEnds of the Connector.
        /// </summary>
        [Property(xmiId: "5d81451f-480e-49d7-953a-4b441caf76d4", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "0d55f45c-0032-4618-9131-61ed58c3b8e2")]
        List<string> GetRelatedFeature { get; }

        /// <summary>
        /// The source relatedFeature for this Connector. It is the first relatedFeature.
        /// </summary>
        [Property(xmiId: "0cad7969-0d12-4a35-8473-1b1da503eaf0", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "5d81451f-480e-49d7-953a-4b441caf76d4")]
        [RedefinedProperty(propertyName: "cd83f43d-3885-4b41-8f03-f02255e6a5da")]
        string? GetSourceFeature { get; }

        /// <summary>
        /// The target relatedFeatures for this Connector. This includes all the relatedFeatures other than the
        /// sourceFeature.
        /// </summary>
        [Property(xmiId: "fc72dff0-56b8-4406-9d40-1bd319e54ce1", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "5d81451f-480e-49d7-953a-4b441caf76d4")]
        [RedefinedProperty(propertyName: "4c7374f5-78f8-42ab-ae42-672ad9c80902")]
        List<string> GetTargetFeature { get; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
