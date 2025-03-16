// -------------------------------------------------------------------------------------------------
// <copyright file="ISuccession.cs" company="Starion Group S.A.">
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

    using KerML.NET.Core.Types;
    using KerML.NET.DTO.Core.Features;
    using KerML.NET.DTO.Core.Types;
    using KerML.NET.DTO.Kernel.Associations;
    using KerML.NET.DTO.Kernel.Behaviors;
    using KerML.NET.DTO.Kernel.Connectors;
    using KerML.NET.DTO.Kernel.Functions;
    using KerML.NET.DTO.Root.Annotations;
    using KerML.NET.DTO.Root.Elements;
    using KerML.NET.DTO.Root.Namespaces;

    using KerML.NET.Decorators;

    /// <summary>
    /// A Succession is a binary Connector that requires its relatedFeatures to happen separately in time.
    /// </summary>
    [Class(xmiId: "1c11fcd6-7d2e-4326-8913-6b6ad5e1f4ae", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface ISuccession : IConnector
    {
        /// <summary>
        /// Steps that represent occurrences that are side effects of the transitionStep occurring.
        /// </summary>
        [Property(xmiId: "d65132c3-ec1f-4255-aece-84e82c352f74", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        List<string> GetEffectStep { get; }

        /// <summary>
        /// Expressions that must evaluate to true before the transitionStep can occur.
        /// </summary>
        [Property(xmiId: "e92a9775-4ff0-42f9-b08e-72d5dcc5935d", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        List<string> GetGuardExpression { get; }

        /// <summary>
        /// A Step that is typed by the Behavior TransitionPerformances::TransitionPerformance (from the Kernel
        /// Semantic Library) that has this Succession as its transitionLink.
        /// </summary>
        [Property(xmiId: "e338aa69-6d9d-4159-8de9-a46e3ab98cfd", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        string? GetTransitionStep { get; }

        /// <summary>
        /// Steps that map incoming events to the timing of occurrences of the transitionStep. The values of
        /// triggerStep subset the list of acceptable events to be received by a Behavior or the object that
        /// performs it.
        /// </summary>
        [Property(xmiId: "b9cac2ff-307f-40d6-8340-901d3e2af1ca", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        List<string> GetTriggerStep { get; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
