// -------------------------------------------------------------------------------------------------
// <copyright file="TextualRepresentationSerializer.cs" company="Starion Group S.A.">
//
//   Copyright 2022-2025 Starion Group S.A.
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

namespace KerML.NET.Serializer.Json
{
    using System;
    using System.Text.Json;

    using KerML.NET.DTO.Root.Annotations;

    /// <summary>
    /// The purpose of the <see cref="TextualRepresentationSerializer"/> is to provide serialization capabilities
    /// for the <see cref="ITextualRepresentation"/> interface
    /// </summary>
    public static class TextualRepresentationSerializer
    {
        /// <summary>
        /// Serializes an instance of <see cref="ITextualRepresentation"/> using an <see cref="Utf8JsonWriter"/>
        /// </summary>
        /// <param name="obj">
        /// The <see cref="ITextualRepresentation"/> to serialize
        /// </param>
        /// <param name="writer">
        /// The target <see cref="Utf8JsonWriter"/>
        /// </param>
        /// <param name="serializationModeKind">
        /// enumeration specifying what kind of serialization shall be used
        /// </param>
        /// <param name="includeDerived">
        /// A value indicating whether derived properties shall be serialized or not
        /// </param>
        public static void Serialize(object obj, Utf8JsonWriter writer, SerializationModeKind serializationModeKind, bool includeDerived)
        {
            if (!(obj is ITextualRepresentation iTextualRepresentation))
            {
                throw new ArgumentException("The object shall be an ITextualRepresentation", nameof(obj));
            }

            writer.WriteStartObject();

            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue("TextualRepresentation"u8);

            writer.WritePropertyName("@id"u8);
            writer.WriteStringValue(iTextualRepresentation.ElementId);

            writer.WriteStartArray("aliasIds"u8);
            foreach (var item in iTextualRepresentation.AliasIds)
            {
                writer.WriteStringValue(item);

            }
            writer.WriteEndArray();

            // The TextualRepresentation.AnnotatedElement property is a Redefined property and will not be serialized.

            if (includeDerived)
            {
                writer.WriteStartArray("annotation"u8);
                foreach (var item in iTextualRepresentation.GetAnnotation)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(item);
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();

            }

            writer.WritePropertyName("body"u8);
            writer.WriteStringValue(iTextualRepresentation.Body);

            writer.WritePropertyName("declaredName"u8);
            if (iTextualRepresentation.DeclaredName != null)
            {
                writer.WriteStringValue(iTextualRepresentation.DeclaredName);
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WritePropertyName("declaredShortName"u8);
            if (iTextualRepresentation.DeclaredShortName != null)
            {
                writer.WriteStringValue(iTextualRepresentation.DeclaredShortName);
            }
            else
            {
                writer.WriteNullValue();
            }

            if (includeDerived)
            {
                writer.WriteStartArray("documentation"u8);
                foreach (var item in iTextualRepresentation.GetDocumentation)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(item);
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();

            }

            writer.WritePropertyName("isImpliedIncluded"u8);
            writer.WriteBooleanValue(iTextualRepresentation.IsImpliedIncluded);

            if (includeDerived)
            {
                writer.WritePropertyName("isLibraryElement"u8);
                writer.WriteBooleanValue(iTextualRepresentation.GetIsLibraryElement);

            }

            writer.WritePropertyName("language"u8);
            writer.WriteStringValue(iTextualRepresentation.Language);

            if (includeDerived)
            {
                writer.WritePropertyName("name"u8);
                if (iTextualRepresentation.GetName != null)
                {
                    writer.WriteStringValue(iTextualRepresentation.GetName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            if (includeDerived)
            {
                writer.WriteStartArray("ownedAnnotatingRelationship"u8);
                foreach (var item in iTextualRepresentation.GetOwnedAnnotatingRelationship)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(item);
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();

            }

            if (includeDerived)
            {
                writer.WriteStartArray("ownedAnnotation"u8);
                foreach (var item in iTextualRepresentation.GetOwnedAnnotation)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(item);
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();

            }

            if (includeDerived)
            {
                writer.WriteStartArray("ownedElement"u8);
                foreach (var item in iTextualRepresentation.GetOwnedElement)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(item);
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();

            }

            writer.WriteStartArray("ownedRelationship"u8);
            foreach (var item in iTextualRepresentation.OwnedRelationship)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("@id"u8);
                writer.WriteStringValue(item);
                writer.WriteEndObject();
            }
            writer.WriteEndArray();

            if (includeDerived)
            {
                writer.WritePropertyName("owner"u8);
                if (iTextualRepresentation.GetOwner != null)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(iTextualRepresentation.GetOwner);
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            if (includeDerived)
            {
                writer.WritePropertyName("owningAnnotatingRelationship"u8);
                if (iTextualRepresentation.GetOwningAnnotatingRelationship != null)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(iTextualRepresentation.GetOwningAnnotatingRelationship);
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            if (includeDerived)
            {
                writer.WritePropertyName("owningMembership"u8);
                if (iTextualRepresentation.GetOwningMembership != null)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(iTextualRepresentation.GetOwningMembership);
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            if (includeDerived)
            {
                writer.WritePropertyName("owningNamespace"u8);
                if (iTextualRepresentation.GetOwningNamespace != null)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(iTextualRepresentation.GetOwningNamespace);
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            writer.WritePropertyName("owningRelationship"u8);
            if (iTextualRepresentation.OwningRelationship != null)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("@id"u8);
                writer.WriteStringValue(iTextualRepresentation.OwningRelationship);
                writer.WriteEndObject();
            }
            else
            {
                writer.WriteNullValue();
            }

            if (includeDerived)
            {
                writer.WritePropertyName("qualifiedName"u8);
                if (iTextualRepresentation.GetQualifiedName != null)
                {
                    writer.WriteStringValue(iTextualRepresentation.GetQualifiedName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            if (includeDerived)
            {
                writer.WritePropertyName("representedElement"u8);
                writer.WriteStartObject();
                writer.WritePropertyName("@id"u8);
                writer.WriteStringValue(iTextualRepresentation.GetRepresentedElement);
                writer.WriteEndObject();

            }

            if (includeDerived)
            {
                writer.WritePropertyName("shortName"u8);
                if (iTextualRepresentation.GetShortName != null)
                {
                    writer.WriteStringValue(iTextualRepresentation.GetShortName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            if (includeDerived)
            {
                writer.WriteStartArray("textualRepresentation"u8);
                foreach (var item in iTextualRepresentation.GetTextualRepresentation)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(item);
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();

            }

            writer.WriteEndObject();
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
