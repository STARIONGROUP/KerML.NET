﻿// -------------------------------------------------------------------------------------------------
// <copyright file="ITextualRepresentation.cs" company="Starion Group S.A.">
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
    /// A TextualRepresentation is an AnnotatingElement whose body represents the representedElement in a
    /// given language. The representedElement must be the owner of the TextualRepresentation. The named
    /// language can be a natural language, in which case the body is an informal representation, or an
    /// artificial language, in which case the body is expected to be a formal, machine-parsable
    /// representation.If the named language of a TextualRepresentation is machine-parsable, then the body
    /// text should be legal input text as defined for that language. The interpretation of the named
    /// language string shall be case insensitive. The following language names are defined to correspond to
    /// the given standard languages:<table border="1" cellpadding="1" cellspacing="1"
    /// width="498">	<thead>	</thead>	<tbody>		<tr>			<td style="text-align: center; width:
    /// 154px;">kerml</td>			<td style="width: 332px;">Kernel Modeling Language</td>		</tr>		<tr>			<td
    /// style="text-align: center; width: 154px;">ocl</td>			<td style="width: 332px;">Object Constraint
    /// Language</td>		</tr>		<tr>			<td style="text-align: center; width: 154px;">alf</td>			<td
    /// style="width: 332px;">Action Language for fUML</td>		</tr>	</tbody></table>Other specifications may
    /// define specific language strings, other than those shown above, to be used to indicate the use of
    /// languages from those specifications in KerML TextualRepresentation.If the language of a
    /// TextualRepresentation is &quot;kerml&quot;, then the body text shall be a legal representation of
    /// the representedElement in the KerML textual concrete syntax. A conforming tool can use such a
    /// TextualRepresentation Annotation to record the original KerML concrete syntax text from which an
    /// Element was parsed. In this case, it is a tool responsibility to ensure that the body of the
    /// TextualRepresentation remains correct (or the Annotation is removed) if the annotated Element
    /// changes other than by re-parsing the body text.An Element with a TextualRepresentation in a language
    /// other than KerML is essentially a semantically &quot;opaque&quot; Element specified in the other
    /// language. However, a conforming KerML tool may interpret such an element consistently with the
    /// specification of the named language.
    /// </summary>
    [Class(xmiId: "c10e5da4-a3e6-425d-b09b-2c5b1deebf36", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface ITextualRepresentation : IAnnotatingElement
    {
        /// <summary>
        /// The textual representation of the representedElement in the given language.
        /// </summary>
        [Property(xmiId: "a58b6080-248a-433e-9178-f0b58d7179d1", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        string Body { get; set; }

        /// <summary>
        /// The natural or artifical language in which the body text is written.
        /// </summary>
        [Property(xmiId: "bc93f8c6-215d-4e59-811a-4c28c5c5cb21", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        string Language { get; set; }

        /// <summary>
        /// The Element that is represented by this TextualRepresentation.
        /// </summary>
        [Property(xmiId: "94b41a6b-aa1f-4950-9fb3-34a3a8c7ce79", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "62034bc0-cc6e-41a0-b2b7-09f6bb604c5e")]
        [RedefinedProperty(propertyName: "d0221b66-75b1-4727-90da-636288f9d289")]
        string GetRepresentedElement { get; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
