// -------------------------------------------------------------------------------------------------
// <copyright file="ResultExpressionMembershipSerializer.cs" company="Starion Group S.A.">
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

    using KerML.NET.DTO.Kernel.Functions;

    /// <summary>
    /// The purpose of the <see cref="ResultExpressionMembershipSerializer"/> is to provide serialization capabilities
    /// for the <see cref="IResultExpressionMembership"/> interface
    /// </summary>
    public static class ResultExpressionMembershipSerializer
    {
        /// <summary>
        /// Serializes an instance of <see cref="IResultExpressionMembership"/> using an <see cref="Utf8JsonWriter"/>
        /// </summary>
        /// <param name="obj">
        /// The <see cref="IResultExpressionMembership"/> to serialize
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
            if (!(obj is IResultExpressionMembership iResultExpressionMembership))
            {
                throw new ArgumentException("The object shall be an IResultExpressionMembership", nameof(obj));
            }

            writer.WriteStartObject();

            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue("ResultExpressionMembership"u8);

            writer.WritePropertyName("@id"u8);
            writer.WriteStringValue(iResultExpressionMembership.ElementId);

            writer.WriteStartArray("aliasIds"u8);
            foreach (var item in iResultExpressionMembership.AliasIds)
            {
                writer.WriteStringValue(item);

            }
            writer.WriteEndArray();

            writer.WritePropertyName("declaredName"u8);
            if (iResultExpressionMembership.DeclaredName != null)
            {
                writer.WriteStringValue(iResultExpressionMembership.DeclaredName);
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WritePropertyName("declaredShortName"u8);
            if (iResultExpressionMembership.DeclaredShortName != null)
            {
                writer.WriteStringValue(iResultExpressionMembership.DeclaredShortName);
            }
            else
            {
                writer.WriteNullValue();
            }

            if (includeDerived)
            {
                writer.WriteStartArray("documentation"u8);
                foreach (var item in iResultExpressionMembership.GetDocumentation)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(item);
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();

            }

            // The ResultExpressionMembership.Feature property is a Redefined property and will not be serialized.

            writer.WritePropertyName("isImplied"u8);
            writer.WriteBooleanValue(iResultExpressionMembership.IsImplied);

            writer.WritePropertyName("isImpliedIncluded"u8);
            writer.WriteBooleanValue(iResultExpressionMembership.IsImpliedIncluded);

            if (includeDerived)
            {
                writer.WritePropertyName("isLibraryElement"u8);
                writer.WriteBooleanValue(iResultExpressionMembership.GetIsLibraryElement);

            }

            // The ResultExpressionMembership.MemberElement property is a Redefined property and will not be serialized.

            // The ResultExpressionMembership.MemberElementId property is a Redefined property and will not be serialized.

            // The ResultExpressionMembership.MemberName property is a Redefined property and will not be serialized.

            // The ResultExpressionMembership.MembershipOwningNamespace property is a Redefined property and will not be serialized.

            // The ResultExpressionMembership.MemberShortName property is a Redefined property and will not be serialized.

            if (includeDerived)
            {
                writer.WritePropertyName("name"u8);
                if (iResultExpressionMembership.GetName != null)
                {
                    writer.WriteStringValue(iResultExpressionMembership.GetName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            if (includeDerived)
            {
                writer.WriteStartArray("ownedAnnotation"u8);
                foreach (var item in iResultExpressionMembership.GetOwnedAnnotation)
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
                foreach (var item in iResultExpressionMembership.GetOwnedElement)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(item);
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();

            }

            // The ResultExpressionMembership.OwnedMemberElement property is a Redefined property and will not be serialized.

            if (includeDerived)
            {
                writer.WritePropertyName("ownedMemberElementId"u8);
                writer.WriteStringValue(iResultExpressionMembership.GetOwnedMemberElementId);

            }

            // The ResultExpressionMembership.OwnedMemberFeature property is a Redefined property and will not be serialized.

            if (includeDerived)
            {
                writer.WritePropertyName("ownedMemberName"u8);
                if (iResultExpressionMembership.GetOwnedMemberName != null)
                {
                    writer.WriteStringValue(iResultExpressionMembership.GetOwnedMemberName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            if (includeDerived)
            {
                writer.WritePropertyName("ownedMemberShortName"u8);
                if (iResultExpressionMembership.GetOwnedMemberShortName != null)
                {
                    writer.WriteStringValue(iResultExpressionMembership.GetOwnedMemberShortName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            writer.WriteStartArray("ownedRelatedElement"u8);
            foreach (var item in iResultExpressionMembership.OwnedRelatedElement)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("@id"u8);
                writer.WriteStringValue(item);
                writer.WriteEndObject();
            }
            writer.WriteEndArray();

            writer.WriteStartArray("ownedRelationship"u8);
            foreach (var item in iResultExpressionMembership.OwnedRelationship)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("@id"u8);
                writer.WriteStringValue(item);
                writer.WriteEndObject();
            }
            writer.WriteEndArray();

            if (includeDerived)
            {
                writer.WritePropertyName("ownedResultExpression"u8);
                writer.WriteStartObject();
                writer.WritePropertyName("@id"u8);
                writer.WriteStringValue(iResultExpressionMembership.GetOwnedResultExpression);
                writer.WriteEndObject();

            }

            if (includeDerived)
            {
                writer.WritePropertyName("owner"u8);
                if (iResultExpressionMembership.GetOwner != null)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(iResultExpressionMembership.GetOwner);
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
                if (iResultExpressionMembership.GetOwningMembership != null)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(iResultExpressionMembership.GetOwningMembership);
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
                if (iResultExpressionMembership.GetOwningNamespace != null)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(iResultExpressionMembership.GetOwningNamespace);
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            writer.WritePropertyName("owningRelatedElement"u8);
            if (iResultExpressionMembership.OwningRelatedElement != null)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("@id"u8);
                writer.WriteStringValue(iResultExpressionMembership.OwningRelatedElement);
                writer.WriteEndObject();
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WritePropertyName("owningRelationship"u8);
            if (iResultExpressionMembership.OwningRelationship != null)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("@id"u8);
                writer.WriteStringValue(iResultExpressionMembership.OwningRelationship);
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
                writer.WriteStringValue(iResultExpressionMembership.GetOwningType);
                writer.WriteEndObject();

            }

            if (includeDerived)
            {
                writer.WritePropertyName("qualifiedName"u8);
                if (iResultExpressionMembership.GetQualifiedName != null)
                {
                    writer.WriteStringValue(iResultExpressionMembership.GetQualifiedName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            if (includeDerived)
            {
                writer.WriteStartArray("relatedElement"u8);
                foreach (var item in iResultExpressionMembership.GetRelatedElement)
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
                if (iResultExpressionMembership.GetShortName != null)
                {
                    writer.WriteStringValue(iResultExpressionMembership.GetShortName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            // The ResultExpressionMembership.Source property is a Redefined property and will not be serialized.

            // The ResultExpressionMembership.Target property is a Redefined property and will not be serialized.

            if (includeDerived)
            {
                writer.WriteStartArray("textualRepresentation"u8);
                foreach (var item in iResultExpressionMembership.GetTextualRepresentation)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(item);
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();

            }

            // The ResultExpressionMembership.Type property is a Redefined property and will not be serialized.

            writer.WritePropertyName("visibility"u8);
            writer.WriteStringValue(iResultExpressionMembership.Visibility.ToString().ToLower());

            writer.WriteEndObject();
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
