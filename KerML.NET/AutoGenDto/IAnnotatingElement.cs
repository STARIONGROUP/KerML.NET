// -------------------------------------------------------------------------------------------------
// <copyright file="IAnnotatingElement.cs" company="Starion Group S.A.">
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

namespace KerML.NET.DTO.Root.Annotations
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    using KerML.NET.DTO.Root.Annotations;
    using KerML.NET.DTO.Root.Elements;
    using KerML.NET.DTO.Root.Namespaces;

    using KerML.NET.Decorators;

    /// <summary>
    /// An AnnotatingElement is an Element that provides additional description of or metadata on some other
    /// Element. An AnnotatingElement is either attached to its annotatedElements by Annotation
    /// Relationships, or it implicitly annotates its owningNamespace.
    /// </summary>
    [Class(xmiId: "3bade169-f558-4d7e-aea3-b195c0224e20", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface IAnnotatingElement : IElement
    {
        /// <summary>
        /// The Elements that are annotated by this AnnotatingElement. If annotation is not empty, these are the
        /// annotatedElements of the annotations. If annotation is empty, then it is the owningNamespace of the
        /// AnnotatingElement.
        /// </summary>
        [Property(xmiId: "d0221b66-75b1-4727-90da-636288f9d289", aggregation: AggregationKind.None, lowerValue: 1, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        List<string> GetAnnotatedElement { get; }

        /// <summary>
        /// The Annotations that relate this AnnotatingElement to its annotatedElements. This includes the
        /// owningAnnotatingRelationship (if any) followed by all the ownedAnnotatingRelationshps.
        /// </summary>
        [Property(xmiId: "34fba3f5-26ca-48b3-9d7a-047fb78011b4", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "fd194ed0-9544-4215-b3df-64c5423ec874")]
        List<string> GetAnnotation { get; }

        /// <summary>
        /// The ownedRelationships of this AnnotatingElement that are Annotations, for which this
        /// AnnotatingElement is the annotatingElement.
        /// </summary>
        [Property(xmiId: "e126bf1c-1878-4e87-ab9e-f056abda2405", aggregation: AggregationKind.Composite, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "34fba3f5-26ca-48b3-9d7a-047fb78011b4")]
        [SubsettedProperty(propertyName: "9a0cb697-5a6b-4fa8-806e-ea6c79d5ada9")]
        List<string> GetOwnedAnnotatingRelationship { get; }

        /// <summary>
        /// The owningRelationship of this AnnotatingRelationship, if it is an Annotation
        /// </summary>
        [Property(xmiId: "a59f6f24-34c8-4564-bc32-160afa748b1f", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "0c64cbc0-cb58-4982-b1ac-d09f6ac8d497")]
        [SubsettedProperty(propertyName: "34fba3f5-26ca-48b3-9d7a-047fb78011b4")]
        string? GetOwningAnnotatingRelationship { get; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
