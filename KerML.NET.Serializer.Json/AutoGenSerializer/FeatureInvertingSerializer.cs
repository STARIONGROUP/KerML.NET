// -------------------------------------------------------------------------------------------------
// <copyright file="FeatureInvertingSerializer.cs" company="Starion Group S.A.">
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

    using KerML.NET.DTO.Core.Features;

    /// <summary>
    /// The purpose of the <see cref="FeatureInvertingSerializer"/> is to provide serialization capabilities
    /// for the <see cref="IFeatureInverting"/> interface
    /// </summary>
    public static class FeatureInvertingSerializer
    {
        /// <summary>
        /// Serializes an instance of <see cref="IFeatureInverting"/> using an <see cref="Utf8JsonWriter"/>
        /// </summary>
        /// <param name="obj">
        /// The <see cref="IFeatureInverting"/> to serialize
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
            if (!(obj is IFeatureInverting iFeatureInverting))
            {
                throw new ArgumentException("The object shall be an IFeatureInverting", nameof(obj));
            }

            writer.WriteStartObject();

            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue("FeatureInverting"u8);

            writer.WritePropertyName("@id"u8);
            writer.WriteStringValue(iFeatureInverting.ElementId);

            writer.WriteStartArray("aliasIds"u8);
            foreach (var item in iFeatureInverting.AliasIds)
            {
                writer.WriteStringValue(item);

            }
            writer.WriteEndArray();

            writer.WritePropertyName("declaredName"u8);
            if (iFeatureInverting.DeclaredName != null)
            {
                writer.WriteStringValue(iFeatureInverting.DeclaredName);
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WritePropertyName("declaredShortName"u8);
            if (iFeatureInverting.DeclaredShortName != null)
            {
                writer.WriteStringValue(iFeatureInverting.DeclaredShortName);
            }
            else
            {
                writer.WriteNullValue();
            }

            if (includeDerived)
            {
                writer.WriteStartArray("documentation"u8);
                foreach (var item in iFeatureInverting.GetDocumentation)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(item);
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();

            }

            writer.WritePropertyName("featureInverted"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("@id"u8);
            writer.WriteStringValue(iFeatureInverting.FeatureInverted);
            writer.WriteEndObject();

            writer.WritePropertyName("invertingFeature"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("@id"u8);
            writer.WriteStringValue(iFeatureInverting.InvertingFeature);
            writer.WriteEndObject();

            writer.WritePropertyName("isImplied"u8);
            writer.WriteBooleanValue(iFeatureInverting.IsImplied);

            writer.WritePropertyName("isImpliedIncluded"u8);
            writer.WriteBooleanValue(iFeatureInverting.IsImpliedIncluded);

            if (includeDerived)
            {
                writer.WritePropertyName("isLibraryElement"u8);
                writer.WriteBooleanValue(iFeatureInverting.GetIsLibraryElement);

            }

            if (includeDerived)
            {
                writer.WritePropertyName("name"u8);
                if (iFeatureInverting.GetName != null)
                {
                    writer.WriteStringValue(iFeatureInverting.GetName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            if (includeDerived)
            {
                writer.WriteStartArray("ownedAnnotation"u8);
                foreach (var item in iFeatureInverting.GetOwnedAnnotation)
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
                foreach (var item in iFeatureInverting.GetOwnedElement)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(item);
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();

            }

            writer.WriteStartArray("ownedRelatedElement"u8);
            foreach (var item in iFeatureInverting.OwnedRelatedElement)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("@id"u8);
                writer.WriteStringValue(item);
                writer.WriteEndObject();
            }
            writer.WriteEndArray();

            writer.WriteStartArray("ownedRelationship"u8);
            foreach (var item in iFeatureInverting.OwnedRelationship)
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
                if (iFeatureInverting.GetOwner != null)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(iFeatureInverting.GetOwner);
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            if (includeDerived)
            {
                writer.WritePropertyName("owningFeature"u8);
                if (iFeatureInverting.GetOwningFeature != null)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(iFeatureInverting.GetOwningFeature);
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
                if (iFeatureInverting.GetOwningMembership != null)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(iFeatureInverting.GetOwningMembership);
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
                if (iFeatureInverting.GetOwningNamespace != null)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("@id"u8);
                    writer.WriteStringValue(iFeatureInverting.GetOwningNamespace);
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            writer.WritePropertyName("owningRelatedElement"u8);
            if (iFeatureInverting.OwningRelatedElement != null)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("@id"u8);
                writer.WriteStringValue(iFeatureInverting.OwningRelatedElement);
                writer.WriteEndObject();
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WritePropertyName("owningRelationship"u8);
            if (iFeatureInverting.OwningRelationship != null)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("@id"u8);
                writer.WriteStringValue(iFeatureInverting.OwningRelationship);
                writer.WriteEndObject();
            }
            else
            {
                writer.WriteNullValue();
            }

            if (includeDerived)
            {
                writer.WritePropertyName("qualifiedName"u8);
                if (iFeatureInverting.GetQualifiedName != null)
                {
                    writer.WriteStringValue(iFeatureInverting.GetQualifiedName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            if (includeDerived)
            {
                writer.WriteStartArray("relatedElement"u8);
                foreach (var item in iFeatureInverting.GetRelatedElement)
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
                if (iFeatureInverting.GetShortName != null)
                {
                    writer.WriteStringValue(iFeatureInverting.GetShortName);
                }
                else
                {
                    writer.WriteNullValue();
                }

            }

            // The FeatureInverting.Source property is a Redefined property and will not be serialized.

            // The FeatureInverting.Target property is a Redefined property and will not be serialized.

            if (includeDerived)
            {
                writer.WriteStartArray("textualRepresentation"u8);
                foreach (var item in iFeatureInverting.GetTextualRepresentation)
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
