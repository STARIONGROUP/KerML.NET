// -------------------------------------------------------------------------------------------------
// <copyright file="FeatureMembershipSerializer.cs" company="Starion Group S.A.">
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

    using KerML.NET.DTO.Core.Types;

    /// <summary>
    /// The purpose of the <see cref="FeatureMembershipSerializer"/> is to provide serialization capabilities
    /// for the <see cref="IFeatureMembership"/> interface
    /// </summary>
    public static class FeatureMembershipSerializer
    {
        /// <summary>
        /// Serializes an instance of <see cref="IFeatureMembership"/> using an <see cref="Utf8JsonWriter"/>
        /// </summary>
        /// <param name="obj">
        /// The <see cref="IFeatureMembership"/> to serialize
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
            if (!(obj is IFeatureMembership iFeatureMembership))
            {
                throw new ArgumentException("The object shall be an IFeatureMembership", nameof(obj));
            }

            writer.WriteStartObject();

            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue("FeatureMembership"u8);

            writer.WritePropertyName("@id"u8);
            writer.WriteStringValue(iFeatureMembership.ElementId);

            writer.WriteStartArray("aliasIds"u8);
            foreach (var item in iFeatureMembership.AliasIds)
            {
                writer.WriteStringValue(item);

            }
            writer.WriteEndArray();

            writer.WritePropertyName("declaredName"u8);
            if (iFeatureMembership.DeclaredName != null)
            {
                writer.WriteStringValue(iFeatureMembership.DeclaredName);
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WritePropertyName("declaredShortName"u8);
            if (iFeatureMembership.DeclaredShortName != null)
            {
                writer.WriteStringValue(iFeatureMembership.DeclaredShortName);
            }
            else
            {
                writer.WriteNullValue();
            }

            if (includeDerived)
            {
                writer.WriteStartArray("documentation"u8);
                foreach (var item in iFeatureMembership.GetDocumentation)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(item);
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();

            }

            // The FeatureMembership.Feature property is a Redefined property and will not be serialized.

            writer.WritePropertyName("isImplied"u8);
            writer.WriteBooleanValue(iFeatureMembership.IsImplied);

            writer.WritePropertyName("isImpliedIncluded"u8);
            writer.WriteBooleanValue(iFeatureMembership.IsImpliedIncluded);

            if (includeDerived)
            {
                writer.WritePropertyName("isLibraryElement"u8);
                writer.WriteBooleanValue(iFeatureMembership.GetIsLibraryElement);

            }

            // The FeatureMembership.MemberElement property is a Redefined property and will not be serialized.

            // The FeatureMembership.MemberElementId property is a Redefined property and will not be serialized.

            // The FeatureMembership.MemberName property is a Redefined property and will not be serialized.

            // The FeatureMembership.MembershipOwningNamespace property is a Redefined property and will not be serialized.

            // The FeatureMembership.MemberShortName property is a Redefined property and will not be serialized.

            if (includeDerived)
            {
                writer.WritePropertyName("name"u8);
                if (iFeatureMembership.GetName != null)
                {
                    writer.WriteStringValue(iFeatureMembership.GetName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            if (includeDerived)
            {
                writer.WriteStartArray("ownedAnnotation"u8);
                foreach (var item in iFeatureMembership.GetOwnedAnnotation)
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
                foreach (var item in iFeatureMembership.GetOwnedElement)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(item);
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();

            }

            // The FeatureMembership.OwnedMemberElement property is a Redefined property and will not be serialized.

            if (includeDerived)
            {
                writer.WritePropertyName("ownedMemberElementId"u8);
                writer.WriteStringValue(iFeatureMembership.GetOwnedMemberElementId);

            }

            if (includeDerived)
            {
                writer.WritePropertyName("ownedMemberFeature"u8);
                writer.WriteStartObject();
                writer.WritePropertyName("@id"u8);
                writer.WriteStringValue(iFeatureMembership.GetOwnedMemberFeature);
                writer.WriteEndObject();

            }

            if (includeDerived)
            {
                writer.WritePropertyName("ownedMemberName"u8);
                if (iFeatureMembership.GetOwnedMemberName != null)
                {
                    writer.WriteStringValue(iFeatureMembership.GetOwnedMemberName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            if (includeDerived)
            {
                writer.WritePropertyName("ownedMemberShortName"u8);
                if (iFeatureMembership.GetOwnedMemberShortName != null)
                {
                    writer.WriteStringValue(iFeatureMembership.GetOwnedMemberShortName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            writer.WriteStartArray("ownedRelatedElement"u8);
            foreach (var item in iFeatureMembership.OwnedRelatedElement)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("@id"u8);
                writer.WriteStringValue(item);
                writer.WriteEndObject();
            }
            writer.WriteEndArray();

            writer.WriteStartArray("ownedRelationship"u8);
            foreach (var item in iFeatureMembership.OwnedRelationship)
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
                if (iFeatureMembership.GetOwner != null)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(iFeatureMembership.GetOwner);
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
                if (iFeatureMembership.GetOwningMembership != null)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(iFeatureMembership.GetOwningMembership);
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
                if (iFeatureMembership.GetOwningNamespace != null)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(iFeatureMembership.GetOwningNamespace);
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            writer.WritePropertyName("owningRelatedElement"u8);
            if (iFeatureMembership.OwningRelatedElement != null)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("@id"u8);
                writer.WriteStringValue(iFeatureMembership.OwningRelatedElement);
                writer.WriteEndObject();
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WritePropertyName("owningRelationship"u8);
            if (iFeatureMembership.OwningRelationship != null)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("@id"u8);
                writer.WriteStringValue(iFeatureMembership.OwningRelationship);
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
                writer.WriteStringValue(iFeatureMembership.GetOwningType);
                writer.WriteEndObject();

            }

            if (includeDerived)
            {
                writer.WritePropertyName("qualifiedName"u8);
                if (iFeatureMembership.GetQualifiedName != null)
                {
                    writer.WriteStringValue(iFeatureMembership.GetQualifiedName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            if (includeDerived)
            {
                writer.WriteStartArray("relatedElement"u8);
                foreach (var item in iFeatureMembership.GetRelatedElement)
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
                if (iFeatureMembership.GetShortName != null)
                {
                    writer.WriteStringValue(iFeatureMembership.GetShortName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            // The FeatureMembership.Source property is a Redefined property and will not be serialized.

            // The FeatureMembership.Target property is a Redefined property and will not be serialized.

            if (includeDerived)
            {
                writer.WriteStartArray("textualRepresentation"u8);
                foreach (var item in iFeatureMembership.GetTextualRepresentation)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(item);
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();

            }

            // The FeatureMembership.Type property is a Redefined property and will not be serialized.

            writer.WritePropertyName("visibility"u8);
            writer.WriteStringValue(iFeatureMembership.Visibility.ToString().ToLower());

            writer.WriteEndObject();
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
