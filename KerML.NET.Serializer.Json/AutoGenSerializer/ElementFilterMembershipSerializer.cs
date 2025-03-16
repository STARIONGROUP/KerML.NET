// -------------------------------------------------------------------------------------------------
// <copyright file="ElementFilterMembershipSerializer.cs" company="Starion Group S.A.">
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

    using KerML.NET.DTO.Kernel.Packages;

    /// <summary>
    /// The purpose of the <see cref="ElementFilterMembershipSerializer"/> is to provide serialization capabilities
    /// for the <see cref="IElementFilterMembership"/> interface
    /// </summary>
    public static class ElementFilterMembershipSerializer
    {
        /// <summary>
        /// Serializes an instance of <see cref="IElementFilterMembership"/> using an <see cref="Utf8JsonWriter"/>
        /// </summary>
        /// <param name="obj">
        /// The <see cref="IElementFilterMembership"/> to serialize
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
            if (!(obj is IElementFilterMembership iElementFilterMembership))
            {
                throw new ArgumentException("The object shall be an IElementFilterMembership", nameof(obj));
            }

            writer.WriteStartObject();

            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue("ElementFilterMembership"u8);

            writer.WritePropertyName("@id"u8);
            writer.WriteStringValue(iElementFilterMembership.ElementId);

            writer.WriteStartArray("aliasIds"u8);
            foreach (var item in iElementFilterMembership.AliasIds)
            {
                writer.WriteStringValue(item);

            }
            writer.WriteEndArray();

            if (includeDerived)
            {
                writer.WritePropertyName("condition"u8);
                writer.WriteStartObject();
                writer.WritePropertyName("@id"u8);
                writer.WriteStringValue(iElementFilterMembership.GetCondition);
                writer.WriteEndObject();

            }

            writer.WritePropertyName("declaredName"u8);
            if (iElementFilterMembership.DeclaredName != null)
            {
                writer.WriteStringValue(iElementFilterMembership.DeclaredName);
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WritePropertyName("declaredShortName"u8);
            if (iElementFilterMembership.DeclaredShortName != null)
            {
                writer.WriteStringValue(iElementFilterMembership.DeclaredShortName);
            }
            else
            {
                writer.WriteNullValue();
            }

            if (includeDerived)
            {
                writer.WriteStartArray("documentation"u8);
                foreach (var item in iElementFilterMembership.GetDocumentation)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(item);
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();

            }

            writer.WritePropertyName("isImplied"u8);
            writer.WriteBooleanValue(iElementFilterMembership.IsImplied);

            writer.WritePropertyName("isImpliedIncluded"u8);
            writer.WriteBooleanValue(iElementFilterMembership.IsImpliedIncluded);

            if (includeDerived)
            {
                writer.WritePropertyName("isLibraryElement"u8);
                writer.WriteBooleanValue(iElementFilterMembership.GetIsLibraryElement);

            }

            // The ElementFilterMembership.MemberElement property is a Redefined property and will not be serialized.

            // The ElementFilterMembership.MemberElementId property is a Redefined property and will not be serialized.

            // The ElementFilterMembership.MemberName property is a Redefined property and will not be serialized.

            if (includeDerived)
            {
                writer.WritePropertyName("membershipOwningNamespace"u8);
                writer.WriteStartObject();
                writer.WritePropertyName("@id"u8);
                writer.WriteStringValue(iElementFilterMembership.GetMembershipOwningNamespace);
                writer.WriteEndObject();

            }

            // The ElementFilterMembership.MemberShortName property is a Redefined property and will not be serialized.

            if (includeDerived)
            {
                writer.WritePropertyName("name"u8);
                if (iElementFilterMembership.GetName != null)
                {
                    writer.WriteStringValue(iElementFilterMembership.GetName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            if (includeDerived)
            {
                writer.WriteStartArray("ownedAnnotation"u8);
                foreach (var item in iElementFilterMembership.GetOwnedAnnotation)
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
                foreach (var item in iElementFilterMembership.GetOwnedElement)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(item);
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();

            }

            // The ElementFilterMembership.OwnedMemberElement property is a Redefined property and will not be serialized.

            if (includeDerived)
            {
                writer.WritePropertyName("ownedMemberElementId"u8);
                writer.WriteStringValue(iElementFilterMembership.GetOwnedMemberElementId);

            }

            if (includeDerived)
            {
                writer.WritePropertyName("ownedMemberName"u8);
                if (iElementFilterMembership.GetOwnedMemberName != null)
                {
                    writer.WriteStringValue(iElementFilterMembership.GetOwnedMemberName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            if (includeDerived)
            {
                writer.WritePropertyName("ownedMemberShortName"u8);
                if (iElementFilterMembership.GetOwnedMemberShortName != null)
                {
                    writer.WriteStringValue(iElementFilterMembership.GetOwnedMemberShortName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            writer.WriteStartArray("ownedRelatedElement"u8);
            foreach (var item in iElementFilterMembership.OwnedRelatedElement)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("@id"u8);
                writer.WriteStringValue(item);
                writer.WriteEndObject();
            }
            writer.WriteEndArray();

            writer.WriteStartArray("ownedRelationship"u8);
            foreach (var item in iElementFilterMembership.OwnedRelationship)
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
                if (iElementFilterMembership.GetOwner != null)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(iElementFilterMembership.GetOwner);
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
                if (iElementFilterMembership.GetOwningMembership != null)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(iElementFilterMembership.GetOwningMembership);
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
                if (iElementFilterMembership.GetOwningNamespace != null)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(iElementFilterMembership.GetOwningNamespace);
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            writer.WritePropertyName("owningRelatedElement"u8);
            if (iElementFilterMembership.OwningRelatedElement != null)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("@id"u8);
                writer.WriteStringValue(iElementFilterMembership.OwningRelatedElement);
                writer.WriteEndObject();
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WritePropertyName("owningRelationship"u8);
            if (iElementFilterMembership.OwningRelationship != null)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("@id"u8);
                writer.WriteStringValue(iElementFilterMembership.OwningRelationship);
                writer.WriteEndObject();
            }
            else
            {
                writer.WriteNullValue();
            }

            if (includeDerived)
            {
                writer.WritePropertyName("qualifiedName"u8);
                if (iElementFilterMembership.GetQualifiedName != null)
                {
                    writer.WriteStringValue(iElementFilterMembership.GetQualifiedName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            if (includeDerived)
            {
                writer.WriteStartArray("relatedElement"u8);
                foreach (var item in iElementFilterMembership.GetRelatedElement)
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
                writer.WritePropertyName("shortName"u8);
                if (iElementFilterMembership.GetShortName != null)
                {
                    writer.WriteStringValue(iElementFilterMembership.GetShortName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            // The ElementFilterMembership.Source property is a Redefined property and will not be serialized.

            // The ElementFilterMembership.Target property is a Redefined property and will not be serialized.

            if (includeDerived)
            {
                writer.WriteStartArray("textualRepresentation"u8);
                foreach (var item in iElementFilterMembership.GetTextualRepresentation)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(item);
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();

            }

            writer.WritePropertyName("visibility"u8);
            writer.WriteStringValue(iElementFilterMembership.Visibility.ToString().ToLower());

            writer.WriteEndObject();
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
