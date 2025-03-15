// -------------------------------------------------------------------------------------------------
// <copyright file="Comment.cs" company="Starion Group S.A.">
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

namespace KerML.NET.Serializer.Json
{
    using System;
    using System.Text.Json;

    using KerML.NET.DTO.Root.Annotations;

    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Logging.Abstractions;

    /// <summary>
    /// The purpose of the <see cref="CommentDeSerializer"/> is to provide deserialization capabilities
    /// for the <see cref="IComment"/> interface
    /// </summary>
    public static class CommentDeSerializer
    {
        /// <summary>
        /// Deserializes an instance of <see cref="IComment"/> from the provided <see cref="JsonElement"/>
        /// </summary>
        /// <param name="jsonElement">
        /// The <see cref="JsonElement"/> that contains the <see cref="IComment"/> json object
        /// </param>
        /// <param name="serializationModeKind">
        /// enumeration specifying what kind of serialization shall be used
        /// </param>
        /// <param name="loggerFactory">
        /// The <see cref="ILoggerFactory"/> used to set up logging
        /// </param>
        /// <returns>
        /// an instance of <see cref="IComment"/>
        /// </returns>
        public static IComment DeSerialize(JsonElement jsonElement, SerializationModeKind serializationModeKind, ILoggerFactory? loggerFactory = null)
        {
            var logger = loggerFactory == null ? NullLogger.Instance : loggerFactory.CreateLogger("CommentDeSerializer");

            if (!jsonElement.TryGetProperty("@type"u8, out JsonElement type))
            {
                throw new InvalidOperationException("The @type property is not available, the CommentDeSerializer cannot be used to deserialize this JsonElement");
            }

            if (type.GetString() != "Comment")
            {
                throw new InvalidOperationException($"The CommentDeSerializer can only be used to deserialize objects of type IComment, a {type.GetString()} was provided");
            }

            var dtoInstance = new KerML.NET.DTO.Root.Annotations.Comment();

            if (jsonElement.TryGetProperty("@id"u8, out JsonElement idProperty))
            {
                var propertyValue = idProperty.GetString();
                if (propertyValue == null)
                {
                    throw new JsonException("The @id property is not present, the Comment cannot be deserialized");
                }
                else
                {
                    dtoInstance.ElementId = propertyValue;
                }
            }

            if (jsonElement.TryGetProperty("aliasIds"u8, out JsonElement aliasIdsProperty))
            {
                foreach (var arrayItem in aliasIdsProperty.EnumerateArray())
                {
                    var propertyValue = arrayItem.GetString();
                    if (propertyValue != null)
                    {
                        dtoInstance.AliasIds.Add(propertyValue);
                    }
                }
            }
            else
            {
                logger.LogDebug($"the aliasIds Json property was not found in the Comment: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("annotatedElement"u8, out JsonElement annotatedElementProperty))
            {
                foreach (var arrayItem in annotatedElementProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement annotatedElementIdProperty))
                    {
                        var propertyValue = annotatedElementIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetAnnotatedElement.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the annotatedElement Json property was not found in the Comment: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("annotation"u8, out JsonElement annotationProperty))
            {
                foreach (var arrayItem in annotationProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement annotationIdProperty))
                    {
                        var propertyValue = annotationIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetAnnotation.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the annotation Json property was not found in the Comment: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("body"u8, out JsonElement bodyProperty))
            {
                var propertyValue = bodyProperty.GetString();
                if (propertyValue != null)
                {
                    dtoInstance.Body = propertyValue;
                }
            }
            else
            {
                logger.LogDebug($"the body Json property was not found in the Comment: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("declaredName"u8, out JsonElement declaredNameProperty))
            {
                dtoInstance.DeclaredName = declaredNameProperty.GetString();
            }
            else
            {
                logger.LogDebug($"the declaredName Json property was not found in the Comment: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("declaredShortName"u8, out JsonElement declaredShortNameProperty))
            {
                dtoInstance.DeclaredShortName = declaredShortNameProperty.GetString();
            }
            else
            {
                logger.LogDebug($"the declaredShortName Json property was not found in the Comment: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("documentation"u8, out JsonElement documentationProperty))
            {
                foreach (var arrayItem in documentationProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement documentationIdProperty))
                    {
                        var propertyValue = documentationIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetDocumentation.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the documentation Json property was not found in the Comment: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("elementId"u8, out JsonElement elementIdProperty))
            {
                var propertyValue = elementIdProperty.GetString();
                if (propertyValue != null)
                {
                    dtoInstance.ElementId = propertyValue;
                }
            }
            else
            {
                logger.LogDebug($"the elementId Json property was not found in the Comment: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("isImpliedIncluded"u8, out JsonElement isImpliedIncludedProperty))
            {
                if (isImpliedIncludedProperty.ValueKind != JsonValueKind.Null)
                {
                    dtoInstance.IsImpliedIncluded = isImpliedIncludedProperty.GetBoolean();
                }
            }
            else
            {
                logger.LogDebug($"the isImpliedIncluded Json property was not found in the Comment: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("isLibraryElement"u8, out JsonElement isLibraryElementProperty))
            {
                if (isLibraryElementProperty.ValueKind != JsonValueKind.Null)
                {
                    dtoInstance.GetIsLibraryElement = isLibraryElementProperty.GetBoolean();
                }
            }
            else
            {
                logger.LogDebug($"the isLibraryElement Json property was not found in the Comment: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("locale"u8, out JsonElement localeProperty))
            {
                dtoInstance.Locale = localeProperty.GetString();
            }
            else
            {
                logger.LogDebug($"the locale Json property was not found in the Comment: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("name"u8, out JsonElement nameProperty))
            {
                dtoInstance.GetName = nameProperty.GetString();
            }
            else
            {
                logger.LogDebug($"the name Json property was not found in the Comment: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedAnnotatingRelationship"u8, out JsonElement ownedAnnotatingRelationshipProperty))
            {
                foreach (var arrayItem in ownedAnnotatingRelationshipProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement ownedAnnotatingRelationshipIdProperty))
                    {
                        var propertyValue = ownedAnnotatingRelationshipIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedAnnotatingRelationship.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedAnnotatingRelationship Json property was not found in the Comment: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedAnnotation"u8, out JsonElement ownedAnnotationProperty))
            {
                foreach (var arrayItem in ownedAnnotationProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement ownedAnnotationIdProperty))
                    {
                        var propertyValue = ownedAnnotationIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedAnnotation.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedAnnotation Json property was not found in the Comment: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedElement"u8, out JsonElement ownedElementProperty))
            {
                foreach (var arrayItem in ownedElementProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement ownedElementIdProperty))
                    {
                        var propertyValue = ownedElementIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedElement.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedElement Json property was not found in the Comment: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedRelationship"u8, out JsonElement ownedRelationshipProperty))
            {
                foreach (var arrayItem in ownedRelationshipProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement ownedRelationshipIdProperty))
                    {
                        var propertyValue = ownedRelationshipIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.OwnedRelationship.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedRelationship Json property was not found in the Comment: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("owner"u8, out JsonElement ownerProperty))
            {
                if (ownerProperty.ValueKind == JsonValueKind.Null)
                {
                    dtoInstance.GetOwner = null;
                }
                else
                {
                    if (ownerProperty.TryGetProperty("@id"u8, out JsonElement ownerIdProperty))
                    {
                        var propertyValue = ownerIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwner = propertyValue;
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the owner Json property was not found in the Comment: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("owningAnnotatingRelationship"u8, out JsonElement owningAnnotatingRelationshipProperty))
            {
                if (owningAnnotatingRelationshipProperty.ValueKind == JsonValueKind.Null)
                {
                    dtoInstance.GetOwningAnnotatingRelationship = null;
                }
                else
                {
                    if (owningAnnotatingRelationshipProperty.TryGetProperty("@id"u8, out JsonElement owningAnnotatingRelationshipIdProperty))
                    {
                        var propertyValue = owningAnnotatingRelationshipIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwningAnnotatingRelationship = propertyValue;
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the owningAnnotatingRelationship Json property was not found in the Comment: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("owningMembership"u8, out JsonElement owningMembershipProperty))
            {
                if (owningMembershipProperty.ValueKind == JsonValueKind.Null)
                {
                    dtoInstance.GetOwningMembership = null;
                }
                else
                {
                    if (owningMembershipProperty.TryGetProperty("@id"u8, out JsonElement owningMembershipIdProperty))
                    {
                        var propertyValue = owningMembershipIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwningMembership = propertyValue;
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the owningMembership Json property was not found in the Comment: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("owningNamespace"u8, out JsonElement owningNamespaceProperty))
            {
                if (owningNamespaceProperty.ValueKind == JsonValueKind.Null)
                {
                    dtoInstance.GetOwningNamespace = null;
                }
                else
                {
                    if (owningNamespaceProperty.TryGetProperty("@id"u8, out JsonElement owningNamespaceIdProperty))
                    {
                        var propertyValue = owningNamespaceIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwningNamespace = propertyValue;
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the owningNamespace Json property was not found in the Comment: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("owningRelationship"u8, out JsonElement owningRelationshipProperty))
            {
                if (owningRelationshipProperty.ValueKind == JsonValueKind.Null)
                {
                    dtoInstance.OwningRelationship = null;
                }
                else
                {
                    if (owningRelationshipProperty.TryGetProperty("@id"u8, out JsonElement owningRelationshipIdProperty))
                    {
                        var propertyValue = owningRelationshipIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.OwningRelationship = propertyValue;
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the owningRelationship Json property was not found in the Comment: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("qualifiedName"u8, out JsonElement qualifiedNameProperty))
            {
                dtoInstance.GetQualifiedName = qualifiedNameProperty.GetString();
            }
            else
            {
                logger.LogDebug($"the qualifiedName Json property was not found in the Comment: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("shortName"u8, out JsonElement shortNameProperty))
            {
                dtoInstance.GetShortName = shortNameProperty.GetString();
            }
            else
            {
                logger.LogDebug($"the shortName Json property was not found in the Comment: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("textualRepresentation"u8, out JsonElement textualRepresentationProperty))
            {
                foreach (var arrayItem in textualRepresentationProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement textualRepresentationIdProperty))
                    {
                        var propertyValue = textualRepresentationIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetTextualRepresentation.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the textualRepresentation Json property was not found in the Comment: {dtoInstance.ElementId}");
            }


            return dtoInstance;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
