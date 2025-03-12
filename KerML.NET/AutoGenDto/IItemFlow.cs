// -------------------------------------------------------------------------------------------------
// <copyright file="IItemFlow.cs" company="Starion Group S.A.">
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

namespace KerML.NET.DTO.Kernel.Interactions
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    using KerML.NET.DTO.Core.Classifiers;
    using KerML.NET.DTO.Core.Features;
    using KerML.NET.DTO.Core.Types;
    using KerML.NET.DTO.Kernel.Associations;
    using KerML.NET.DTO.Kernel.Behaviors;
    using KerML.NET.DTO.Kernel.Connectors;
    using KerML.NET.DTO.Kernel.Interactions;
    using KerML.NET.DTO.Root.Annotations;
    using KerML.NET.DTO.Root.Elements;
    using KerML.NET.DTO.Root.Namespaces;

    using KerML.NET.Decorators;
    using KerML.NET.Namespaces;
    using KerML.NET.Types;

    /// <summary>
    /// An ItemFlow is a Step that represents the transfer of objects or data values from one Feature to
    /// another. ItemFlows can take non-zero time to complete.
    /// </summary>
    [Class(xmiId: "73ae40ef-8916-44d6-a1fd-e1674275b1a3", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface IItemFlow : IConnector, IStep
    {
        /// <summary>
        /// The Interactions that type this ItemFlow. Interactions are both Associations and Behaviors, which
        /// can type Connectors and Steps, respectively.
        /// </summary>
        [Property(xmiId: "c7286954-bc9f-4c14-b1f8-33819e60a964", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "e15018cb-6a4b-48b2-b818-d21f0622c267")]
        [RedefinedProperty(propertyName: "4f6477ef-2deb-4f17-a41e-e2aa01f6bb7e")]
        List<string> GetInteraction { get; }

        /// <summary>
        /// The ownedFeature of the ItemFlow that is an ItemFeature (if any).
        /// </summary>
        [Property(xmiId: "a240b4b6-ff8d-4dd1-b9ae-a62d63d3f4fd", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "f062fa83-0335-40e0-8652-a22e6a8b3b11")]
        string? GetItemFeature { get; }

        /// <summary>
        /// The connectorEnds of this ItemFlow that are ItemFlowEnds.
        /// </summary>
        [Property(xmiId: "a488bc40-85cc-48ca-aee8-f11f79165221", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 2, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "cf2b6440-1987-451c-b676-389e1aaa7122")]
        List<string> GetItemFlowEnd { get; }

        /// <summary>
        /// The type of values transferred, which is the type of the itemFeature of the ItemFlow.
        /// </summary>
        [Property(xmiId: "a0cbf746-f328-4d57-9954-465e4117e979", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        List<string> GetItemType { get; }

        /// <summary>
        /// The Feature that provides the items carried by the ItemFlow. It must be an owned output of the
        /// source of the ItemFlow.
        /// </summary>
        [Property(xmiId: "26d0e34b-1431-4a1a-922f-e6d597167761", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        string? GetSourceOutputFeature { get; }

        /// <summary>
        /// The Feature that receives the values carried by the ItemFlow. It must be an owned output of the
        /// target participant of the ItemFlow.
        /// </summary>
        [Property(xmiId: "cb963ace-2a41-43b1-bb94-a7a064dc7dcc", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        string? GetTargetInputFeature { get; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
