// -------------------------------------------------------------------------------------------------
// <copyright file="ISubclassification.cs" company="Starion Group S.A.">
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

namespace KerML.NET.DTO.Core.Classifiers
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    using KerML.NET.DTO.Core.Types;
    using KerML.NET.Decorators;
    using KerML.NET.Namespaces;
    using KerML.NET.Types;

    /// <summary>
    /// Subclassification is Specialization in which both the specific and general Types are Classifier.
    /// This means all instances of the specific Classifier are also instances of the general Classifier.
    /// </summary>
    [Class(xmiId: "cc1fdc81-c8a8-44ba-8a31-e4b9f2f9de02", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface ISubclassification : ISpecialization
    {
        /// <summary>
        /// The more specific Classifier in this Subclassification.
        /// </summary>
        [Property(xmiId: "8d95c5c6-badf-420d-be23-73bbe915a016", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "f45c204e-a88a-4382-9701-ccc842d4a68a")]
        public new string Subclassifier { get; set; }

        /// <summary>
        /// The more general Classifier in this Subclassification.
        /// </summary>
        [Property(xmiId: "63d72dd5-812d-41f7-9669-ffc82d00072a", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "6dd5c0f9-10e8-4361-90d4-723016f969f5")]
        public new string Superclassifier { get; set; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
