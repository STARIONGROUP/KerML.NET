// -------------------------------------------------------------------------------------------------
// <copyright file="ParameterMembershipSerializer.cs" company="Starion Group S.A.">
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

    using KerML.NET.DTO.Kernel.Behaviors;

    /// <summary>
    /// The purpose of the <see cref="ParameterMembershipSerializer"/> is to provide serialization capabilities
    /// for the <see cref="IParameterMembership"/> interface
    /// </summary>
    public static class ParameterMembershipSerializer
    {
        /// <summary>
        /// Serializes an instance of <see cref="IParameterMembership"/> using an <see cref="Utf8JsonWriter"/>
        /// </summary>
        /// <param name="obj">
        /// The <see cref="IParameterMembership"/> to serialize
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
            if (!(obj is IParameterMembership iParameterMembership))
            {
                throw new ArgumentException("The object shall be an IParameterMembership", nameof(obj));
            }

            writer.WriteStartObject();

            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue("ParameterMembership"u8);

            writer.WritePropertyName("@id"u8);
            writer.WriteStringValue(iParameterMembership.ElementId);

            writer.WriteStartArray("aliasIds"u8);
            foreach (var item in iParameterMembership.AliasIds)
            {
                writer.WriteStringValue(item);

            }
            writer.WriteEndArray();

            writer.WritePropertyName("declaredName"u8);
            if (iParameterMembership.DeclaredName != null)
            {
                writer.WriteStringValue(iParameterMembership.DeclaredName);
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WritePropertyName("declaredShortName"u8);
            if (iParameterMembership.DeclaredShortName != null)
            {
                writer.WriteStringValue(iParameterMembership.DeclaredShortName);
            }
            else
            {
                writer.WriteNullValue();
            }

            if (includeDerived)
            {
                writer.WriteStartArray("documentation"u8);
                foreach (var item in iParameterMembership.GetDocumentation)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(item);
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();

            }

            // The ParameterMembership.Feature property is a Redefined property and will not be serialized.

            writer.WritePropertyName("isImplied"u8);
            writer.WriteBooleanValue(iParameterMembership.IsImplied);

            writer.WritePropertyName("isImpliedIncluded"u8);
            writer.WriteBooleanValue(iParameterMembership.IsImpliedIncluded);

            if (includeDerived)
            {
                writer.WritePropertyName("isLibraryElement"u8);
                writer.WriteBooleanValue(iParameterMembership.GetIsLibraryElement);

            }

            // The ParameterMembership.MemberElement property is a Redefined property and will not be serialized.

            // The ParameterMembership.MemberElementId property is a Redefined property and will not be serialized.

            // The ParameterMembership.MemberName property is a Redefined property and will not be serialized.

            // The ParameterMembership.MembershipOwningNamespace property is a Redefined property and will not be serialized.

            // The ParameterMembership.MemberShortName property is a Redefined property and will not be serialized.

            if (includeDerived)
            {
                writer.WritePropertyName("name"u8);
                if (iParameterMembership.GetName != null)
                {
                    writer.WriteStringValue(iParameterMembership.GetName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            if (includeDerived)
            {
                writer.WriteStartArray("ownedAnnotation"u8);
                foreach (var item in iParameterMembership.GetOwnedAnnotation)
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
                foreach (var item in iParameterMembership.GetOwnedElement)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(item);
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();

            }

            // The ParameterMembership.OwnedMemberElement property is a Redefined property and will not be serialized.

            if (includeDerived)
            {
                writer.WritePropertyName("ownedMemberElementId"u8);
                writer.WriteStringValue(iParameterMembership.GetOwnedMemberElementId);

            }

            // The ParameterMembership.OwnedMemberFeature property is a Redefined property and will not be serialized.

            if (includeDerived)
            {
                writer.WritePropertyName("ownedMemberName"u8);
                if (iParameterMembership.GetOwnedMemberName != null)
                {
                    writer.WriteStringValue(iParameterMembership.GetOwnedMemberName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            if (includeDerived)
            {
                writer.WritePropertyName("ownedMemberParameter"u8);
                writer.WriteStartObject();
                writer.WritePropertyName("@id"u8);
                writer.WriteStringValue(iParameterMembership.GetOwnedMemberParameter);
                writer.WriteEndObject();

            }

            if (includeDerived)
            {
                writer.WritePropertyName("ownedMemberShortName"u8);
                if (iParameterMembership.GetOwnedMemberShortName != null)
                {
                    writer.WriteStringValue(iParameterMembership.GetOwnedMemberShortName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            writer.WriteStartArray("ownedRelatedElement"u8);
            foreach (var item in iParameterMembership.OwnedRelatedElement)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("@id"u8);
                writer.WriteStringValue(item);
                writer.WriteEndObject();
            }
            writer.WriteEndArray();

            writer.WriteStartArray("ownedRelationship"u8);
            foreach (var item in iParameterMembership.OwnedRelationship)
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
                if (iParameterMembership.GetOwner != null)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(iParameterMembership.GetOwner);
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
                if (iParameterMembership.GetOwningMembership != null)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(iParameterMembership.GetOwningMembership);
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
                if (iParameterMembership.GetOwningNamespace != null)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(iParameterMembership.GetOwningNamespace);
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            writer.WritePropertyName("owningRelatedElement"u8);
            if (iParameterMembership.OwningRelatedElement != null)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("@id"u8);
                writer.WriteStringValue(iParameterMembership.OwningRelatedElement);
                writer.WriteEndObject();
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WritePropertyName("owningRelationship"u8);
            if (iParameterMembership.OwningRelationship != null)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("@id"u8);
                writer.WriteStringValue(iParameterMembership.OwningRelationship);
                writer.WriteEndObject();
            }
            else
            {
                writer.WriteNullValue();
            }

            if (includeDerived)
            {
                writer.WritePropertyName("owningType"u8);
                writer.WriteStartObject();
                writer.WritePropertyName("@id"u8);
                writer.WriteStringValue(iParameterMembership.GetOwningType);
                writer.WriteEndObject();

            }

            if (includeDerived)
            {
                writer.WritePropertyName("qualifiedName"u8);
                if (iParameterMembership.GetQualifiedName != null)
                {
                    writer.WriteStringValue(iParameterMembership.GetQualifiedName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            if (includeDerived)
            {
                writer.WriteStartArray("relatedElement"u8);
                foreach (var item in iParameterMembership.GetRelatedElement)
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
                if (iParameterMembership.GetShortName != null)
                {
                    writer.WriteStringValue(iParameterMembership.GetShortName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            // The ParameterMembership.Source property is a Redefined property and will not be serialized.

            // The ParameterMembership.Target property is a Redefined property and will not be serialized.

            if (includeDerived)
            {
                writer.WriteStartArray("textualRepresentation"u8);
                foreach (var item in iParameterMembership.GetTextualRepresentation)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(item);
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();

            }

            // The ParameterMembership.Type property is a Redefined property and will not be serialized.

            writer.WritePropertyName("visibility"u8);
            writer.WriteStringValue(iParameterMembership.Visibility.ToString().ToLower());

            writer.WriteEndObject();
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
