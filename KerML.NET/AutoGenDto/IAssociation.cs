// -------------------------------------------------------------------------------------------------
// <copyright file="IAssociation.cs" company="Starion Group S.A.">
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

namespace KerML.NET.DTO.Kernel.Associations
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    using KerML.NET.DTO.Core.Classifiers;
    using KerML.NET.DTO.Core.Features;
    using KerML.NET.DTO.Core.Types;
    using KerML.NET.DTO.Root.Annotations;
    using KerML.NET.DTO.Root.Elements;
    using KerML.NET.DTO.Root.Namespaces;

    using KerML.NET.Decorators;
    using KerML.NET.Namespaces;
    using KerML.NET.Types;

    /// <summary>
    /// An Association is a Relationship and a Classifier to enable classification of links between things
    /// (in the universe). The co-domains (types) of the associationEnd Features are the relatedTypes, as
    /// co-domain and participants (linked things) of an Association identify each other.
    /// </summary>
    [Class(xmiId: "1a2a531c-fd17-4ba3-a2a3-64198a4dcaa7", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface IAssociation : IClassifier, IRelationship
    {
        /// <summary>
        /// The features of the Association that identify the things that can be related by it. A concrete
        /// Association must have at least two associationEnds. When it has exactly two, the Association is
        /// called a binary Association.
        /// </summary>
        [Property(xmiId: "cb5ec957-dd8f-4ab9-b1ae-7768db7bcb93", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "5979d447-4d72-4ffb-a569-ddbe6aacc8dd")]
        List<string> GetAssociationEnd { get; }

        /// <summary>
        /// The types of the associationEnds of the Association, which are the relatedElements of the
        /// Association considered as a Relationship.
        /// </summary>
        [Property(xmiId: "b578f2b2-1cc1-4ee3-b10e-0fb07bf7f558", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "0d55f45c-0032-4618-9131-61ed58c3b8e2")]
        List<string> GetRelatedType { get; }

        /// <summary>
        /// The source relatedType for this Association. It is the first relatedType of the Association.
        /// </summary>
        [Property(xmiId: "d770302d-1f5d-445b-88a4-3029c2c09e83", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "b578f2b2-1cc1-4ee3-b10e-0fb07bf7f558")]
        [RedefinedProperty(propertyName: "cd83f43d-3885-4b41-8f03-f02255e6a5da")]
        string? GetSourceType { get; }

        /// <summary>
        /// The target relatedTypes for this Association. This includes all the relatedTypes other than the
        /// sourceType.
        /// </summary>
        [Property(xmiId: "b3337e06-c4a1-4c51-8d4a-f1c9b503ca4a", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "b578f2b2-1cc1-4ee3-b10e-0fb07bf7f558")]
        [RedefinedProperty(propertyName: "4c7374f5-78f8-42ab-ae42-672ad9c80902")]
        List<string> GetTargetType { get; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
