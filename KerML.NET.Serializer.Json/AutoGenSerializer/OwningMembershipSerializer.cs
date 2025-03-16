// -------------------------------------------------------------------------------------------------
// <copyright file="OwningMembershipSerializer.cs" company="Starion Group S.A.">
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

    using KerML.NET.DTO.Root.Namespaces;

    /// <summary>
    /// The purpose of the <see cref="OwningMembershipSerializer"/> is to provide serialization capabilities
    /// for the <see cref="IOwningMembership"/> interface
    /// </summary>
    public static class OwningMembershipSerializer
    {
        /// <summary>
        /// Serializes an instance of <see cref="IOwningMembership"/> using an <see cref="Utf8JsonWriter"/>
        /// </summary>
        /// <param name="obj">
        /// The <see cref="IOwningMembership"/> to serialize
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
            if (!(obj is IOwningMembership iOwningMembership))
            {
                throw new ArgumentException("The object shall be an IOwningMembership", nameof(obj));
            }

            writer.WriteStartObject();

            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue("OwningMembership"u8);

            writer.WritePropertyName("@id"u8);
            writer.WriteStringValue(iOwningMembership.ElementId);

            writer.WriteStartArray("aliasIds"u8);
            foreach (var item in iOwningMembership.AliasIds)
            {
                writer.WriteStringValue(item);

            }
            writer.WriteEndArray();

            writer.WritePropertyName("declaredName"u8);
            if (iOwningMembership.DeclaredName != null)
            {
                writer.WriteStringValue(iOwningMembership.DeclaredName);
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WritePropertyName("declaredShortName"u8);
            if (iOwningMembership.DeclaredShortName != null)
            {
                writer.WriteStringValue(iOwningMembership.DeclaredShortName);
            }
            else
            {
                writer.WriteNullValue();
            }

            if (includeDerived)
            {
                writer.WriteStartArray("documentation"u8);
                foreach (var item in iOwningMembership.GetDocumentation)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(item);
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();

            }

            writer.WritePropertyName("isImplied"u8);
            writer.WriteBooleanValue(iOwningMembership.IsImplied);

            writer.WritePropertyName("isImpliedIncluded"u8);
            writer.WriteBooleanValue(iOwningMembership.IsImpliedIncluded);

            if (includeDerived)
            {
                writer.WritePropertyName("isLibraryElement"u8);
                writer.WriteBooleanValue(iOwningMembership.GetIsLibraryElement);

            }

            // The OwningMembership.MemberElement property is a Redefined property and will not be serialized.

            // The OwningMembership.MemberElementId property is a Redefined property and will not be serialized.

            // The OwningMembership.MemberName property is a Redefined property and will not be serialized.

            if (includeDerived)
            {
                writer.WritePropertyName("membershipOwningNamespace"u8);
                writer.WriteStartObject();
                writer.WritePropertyName("@id"u8);
                writer.WriteStringValue(iOwningMembership.GetMembershipOwningNamespace);
                writer.WriteEndObject();

            }

            // The OwningMembership.MemberShortName property is a Redefined property and will not be serialized.

            if (includeDerived)
            {
                writer.WritePropertyName("name"u8);
                if (iOwningMembership.GetName != null)
                {
                    writer.WriteStringValue(iOwningMembership.GetName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            if (includeDerived)
            {
                writer.WriteStartArray("ownedAnnotation"u8);
                foreach (var item in iOwningMembership.GetOwnedAnnotation)
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
                foreach (var item in iOwningMembership.GetOwnedElement)
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
                writer.WritePropertyName("ownedMemberElement"u8);
                writer.WriteStartObject();
                writer.WritePropertyName("@id"u8);
                writer.WriteStringValue(iOwningMembership.GetOwnedMemberElement);
                writer.WriteEndObject();

            }

            if (includeDerived)
            {
                writer.WritePropertyName("ownedMemberElementId"u8);
                writer.WriteStringValue(iOwningMembership.GetOwnedMemberElementId);

            }

            if (includeDerived)
            {
                writer.WritePropertyName("ownedMemberName"u8);
                if (iOwningMembership.GetOwnedMemberName != null)
                {
                    writer.WriteStringValue(iOwningMembership.GetOwnedMemberName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            if (includeDerived)
            {
                writer.WritePropertyName("ownedMemberShortName"u8);
                if (iOwningMembership.GetOwnedMemberShortName != null)
                {
                    writer.WriteStringValue(iOwningMembership.GetOwnedMemberShortName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            writer.WriteStartArray("ownedRelatedElement"u8);
            foreach (var item in iOwningMembership.OwnedRelatedElement)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("@id"u8);
                writer.WriteStringValue(item);
                writer.WriteEndObject();
            }
            writer.WriteEndArray();

            writer.WriteStartArray("ownedRelationship"u8);
            foreach (var item in iOwningMembership.OwnedRelationship)
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
                if (iOwningMembership.GetOwner != null)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(iOwningMembership.GetOwner);
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
                if (iOwningMembership.GetOwningMembership != null)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(iOwningMembership.GetOwningMembership);
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
                if (iOwningMembership.GetOwningNamespace != null)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(iOwningMembership.GetOwningNamespace);
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            writer.WritePropertyName("owningRelatedElement"u8);
            if (iOwningMembership.OwningRelatedElement != null)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("@id"u8);
                writer.WriteStringValue(iOwningMembership.OwningRelatedElement);
                writer.WriteEndObject();
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WritePropertyName("owningRelationship"u8);
            if (iOwningMembership.OwningRelationship != null)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("@id"u8);
                writer.WriteStringValue(iOwningMembership.OwningRelationship);
                writer.WriteEndObject();
            }
            else
            {
                writer.WriteNullValue();
            }

            if (includeDerived)
            {
                writer.WritePropertyName("qualifiedName"u8);
                if (iOwningMembership.GetQualifiedName != null)
                {
                    writer.WriteStringValue(iOwningMembership.GetQualifiedName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            if (includeDerived)
            {
                writer.WriteStartArray("relatedElement"u8);
                foreach (var item in iOwningMembership.GetRelatedElement)
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
                if (iOwningMembership.GetShortName != null)
                {
                    writer.WriteStringValue(iOwningMembership.GetShortName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            // The OwningMembership.Source property is a Redefined property and will not be serialized.

            // The OwningMembership.Target property is a Redefined property and will not be serialized.

            if (includeDerived)
            {
                writer.WriteStartArray("textualRepresentation"u8);
                foreach (var item in iOwningMembership.GetTextualRepresentation)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(item);
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();

            }

            writer.WritePropertyName("visibility"u8);
            writer.WriteStringValue(iOwningMembership.Visibility.ToString().ToLower());

            writer.WriteEndObject();
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
