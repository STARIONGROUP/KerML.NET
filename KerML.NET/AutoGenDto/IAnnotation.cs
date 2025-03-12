// -------------------------------------------------------------------------------------------------
// <copyright file="IAnnotation.cs" company="Starion Group S.A.">
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
    using KerML.NET.Namespaces;
    using KerML.NET.Types;

    /// <summary>
    /// An Annotation is a Relationship between an AnnotatingElement and the Element that is annotated by
    /// that AnnotatingElement.
    /// </summary>
    [Class(xmiId: "eb2bcc09-d82c-4252-9ad4-5959443e0aee", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface IAnnotation : IRelationship
    {
        /// <summary>
        /// The Element that is annotated by the annotatingElement of this Annotation.
        /// </summary>
        [Property(xmiId: "82d77c42-a20c-41ea-bb08-85e55ac59a26", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "4c7374f5-78f8-42ab-ae42-672ad9c80902")]
        string AnnotatedElement { get; set; }

        /// <summary>
        /// The AnnotatingElement that annotates the annotatedElement of this Annotation. This is always either
        /// the ownedAnnotatingElement or the owningAnnotatingElement.
        /// </summary>
        [Property(xmiId: "05712626-eade-4016-9f1e-feec1c645bf8", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "cd83f43d-3885-4b41-8f03-f02255e6a5da")]
        string GetAnnotatingElement { get; }

        /// <summary>
        /// The annotatingElement of this Annotation, when it is an ownedRelatedElement.
        /// </summary>
        [Property(xmiId: "299ed0ae-e1b6-45aa-9438-ab6d0009a01f", aggregation: AggregationKind.Composite, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "05712626-eade-4016-9f1e-feec1c645bf8")]
        [SubsettedProperty(propertyName: "27fc72b3-57ec-4aa5-a656-1e902c5d768a")]
        string? GetOwnedAnnotatingElement { get; }

        /// <summary>
        /// The annotatedElement of this Annotation, when it is also the owningRelatedElement.
        /// </summary>
        [Property(xmiId: "3289771d-4de4-4921-b95b-d7d8aacf20f2", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "82d77c42-a20c-41ea-bb08-85e55ac59a26")]
        [SubsettedProperty(propertyName: "c81d146c-d738-40a0-ab80-8526beac3673")]
        string? GetOwningAnnotatedElement { get; }

        /// <summary>
        /// The annotatingElement of this Annotation, when it is the owningRelatedElement.
        /// </summary>
        [Property(xmiId: "dacbaa16-7f5e-49ff-8aec-43761baec776", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "05712626-eade-4016-9f1e-feec1c645bf8")]
        [SubsettedProperty(propertyName: "c81d146c-d738-40a0-ab80-8526beac3673")]
        string? GetOwningAnnotatingElement { get; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
