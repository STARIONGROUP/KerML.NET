﻿// -------------------------------------------------------------------------------------------------
// <copyright file="IntersectingDeSerializer.cs" company="Starion Group S.A.">
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

    using KerML.NET.DTO.Core.Types;

    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Logging.Abstractions;

    /// <summary>
    /// The purpose of the <see cref="IntersectingDeSerializer"/> is to provide deserialization capabilities
    /// for the <see cref="IIntersecting"/> interface
    /// </summary>
    public static class IntersectingDeSerializer
    {
        /// <summary>
        /// Deserializes an instance of <see cref="IIntersecting"/> from the provided <see cref="JsonElement"/>
        /// </summary>
        /// <param name="jsonElement">
        /// The <see cref="JsonElement"/> that contains the <see cref="IIntersecting"/> json object
        /// </param>
        /// <param name="serializationModeKind">
        /// enumeration specifying what kind of serialization shall be used
        /// </param>
        /// <param name="loggerFactory">
        /// The <see cref="ILoggerFactory"/> used to set up logging
        /// </param>
        /// <returns>
        /// an instance of <see cref="IIntersecting"/>
        /// </returns>
        public static IIntersecting DeSerialize(JsonElement jsonElement, SerializationModeKind serializationModeKind, ILoggerFactory? loggerFactory = null)
        {
            var logger = loggerFactory == null ? NullLogger.Instance : loggerFactory.CreateLogger("IntersectingDeSerializer");

            if (!jsonElement.TryGetProperty("@type"u8, out JsonElement type))
            {
                throw new InvalidOperationException("The @type property is not available, the IntersectingDeSerializer cannot be used to deserialize this JsonElement");
            }

            if (type.GetString() != "Intersecting")
            {
                throw new InvalidOperationException($"The IntersectingDeSerializer can only be used to deserialize objects of type IIntersecting, a {type.GetString()} was provided");
            }

            var dtoInstance = new KerML.NET.DTO.Core.Types.Intersecting();

            if (jsonElement.TryGetProperty("@id"u8, out JsonElement idProperty))
            {
                var propertyValue = idProperty.GetString();
                if (propertyValue == null)
                {
                    throw new JsonException("The @id property is not present, the Intersecting cannot be deserialized");
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
                logger.LogDebug($"the aliasIds Json property was not found in the Intersecting: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("declaredName"u8, out JsonElement declaredNameProperty))
            {
                dtoInstance.DeclaredName = declaredNameProperty.GetString();
            }
            else
            {
                logger.LogDebug($"the declaredName Json property was not found in the Intersecting: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("declaredShortName"u8, out JsonElement declaredShortNameProperty))
            {
                dtoInstance.DeclaredShortName = declaredShortNameProperty.GetString();
            }
            else
            {
                logger.LogDebug($"the declaredShortName Json property was not found in the Intersecting: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("documentation"u8, out JsonElement getDocumentationProperty))
            {
                foreach (var arrayItem in getDocumentationProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getDocumentationAtIdProperty))
                    {
                        var propertyValue = getDocumentationAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetDocumentation.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the documentation Json property was not found in the Intersecting: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the elementId Json property was not found in the Intersecting: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("intersectingType"u8, out JsonElement intersectingTypeProperty))
            {
                if (intersectingTypeProperty.ValueKind == JsonValueKind.Null)
                {
                    dtoInstance.IntersectingType = "-";
                    logger.LogDebug("the Intersecting.IntersectingType property was not found in the Json. The value is set to '-'");
                }
                else
                {
                    if (intersectingTypeProperty.TryGetProperty("@id"u8, out JsonElement intersectingTypeAtIdProperty))
                    {
                        var propertyValue = intersectingTypeAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.IntersectingType = propertyValue;
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the intersectingType Json property was not found in the Intersecting: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("isImplied"u8, out JsonElement isImpliedProperty))
            {
                if (isImpliedProperty.ValueKind != JsonValueKind.Null)
                {
                    dtoInstance.IsImplied = isImpliedProperty.GetBoolean();
                }
            }
            else
            {
                logger.LogDebug($"the isImplied Json property was not found in the Intersecting: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the isImpliedIncluded Json property was not found in the Intersecting: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("isLibraryElement"u8, out JsonElement getIsLibraryElementProperty))
            {
                if (getIsLibraryElementProperty.ValueKind != JsonValueKind.Null)
                {
                    dtoInstance.GetIsLibraryElement = getIsLibraryElementProperty.GetBoolean();
                }
            }
            else
            {
                logger.LogDebug($"the isLibraryElement Json property was not found in the Intersecting: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("name"u8, out JsonElement getNameProperty))
            {
                dtoInstance.GetName = getNameProperty.GetString();
            }
            else
            {
                logger.LogDebug($"the name Json property was not found in the Intersecting: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedAnnotation"u8, out JsonElement getOwnedAnnotationProperty))
            {
                foreach (var arrayItem in getOwnedAnnotationProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getOwnedAnnotationAtIdProperty))
                    {
                        var propertyValue = getOwnedAnnotationAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedAnnotation.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedAnnotation Json property was not found in the Intersecting: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedElement"u8, out JsonElement getOwnedElementProperty))
            {
                foreach (var arrayItem in getOwnedElementProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getOwnedElementAtIdProperty))
                    {
                        var propertyValue = getOwnedElementAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedElement.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedElement Json property was not found in the Intersecting: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedRelatedElement"u8, out JsonElement ownedRelatedElementProperty))
            {
                foreach (var arrayItem in ownedRelatedElementProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement ownedRelatedElementAtIdProperty))
                    {
                        var propertyValue = ownedRelatedElementAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.OwnedRelatedElement.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedRelatedElement Json property was not found in the Intersecting: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedRelationship"u8, out JsonElement ownedRelationshipProperty))
            {
                foreach (var arrayItem in ownedRelationshipProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement ownedRelationshipAtIdProperty))
                    {
                        var propertyValue = ownedRelationshipAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.OwnedRelationship.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedRelationship Json property was not found in the Intersecting: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("owner"u8, out JsonElement getOwnerProperty))
            {
                if (getOwnerProperty.ValueKind == JsonValueKind.Null)
                {
                    dtoInstance.GetOwner = null;
                }
                else
                {
                    if (getOwnerProperty.TryGetProperty("@id"u8, out JsonElement getOwnerAtIdProperty))
                    {
                        var propertyValue = getOwnerAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwner = propertyValue;
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the owner Json property was not found in the Intersecting: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("owningMembership"u8, out JsonElement getOwningMembershipProperty))
            {
                if (getOwningMembershipProperty.ValueKind == JsonValueKind.Null)
                {
                    dtoInstance.GetOwningMembership = null;
                }
                else
                {
                    if (getOwningMembershipProperty.TryGetProperty("@id"u8, out JsonElement getOwningMembershipAtIdProperty))
                    {
                        var propertyValue = getOwningMembershipAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwningMembership = propertyValue;
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the owningMembership Json property was not found in the Intersecting: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("owningNamespace"u8, out JsonElement getOwningNamespaceProperty))
            {
                if (getOwningNamespaceProperty.ValueKind == JsonValueKind.Null)
                {
                    dtoInstance.GetOwningNamespace = null;
                }
                else
                {
                    if (getOwningNamespaceProperty.TryGetProperty("@id"u8, out JsonElement getOwningNamespaceAtIdProperty))
                    {
                        var propertyValue = getOwningNamespaceAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwningNamespace = propertyValue;
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the owningNamespace Json property was not found in the Intersecting: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("owningRelatedElement"u8, out JsonElement owningRelatedElementProperty))
            {
                if (owningRelatedElementProperty.ValueKind == JsonValueKind.Null)
                {
                    dtoInstance.OwningRelatedElement = null;
                }
                else
                {
                    if (owningRelatedElementProperty.TryGetProperty("@id"u8, out JsonElement owningRelatedElementAtIdProperty))
                    {
                        var propertyValue = owningRelatedElementAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.OwningRelatedElement = propertyValue;
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the owningRelatedElement Json property was not found in the Intersecting: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("owningRelationship"u8, out JsonElement owningRelationshipProperty))
            {
                if (owningRelationshipProperty.ValueKind == JsonValueKind.Null)
                {
                    dtoInstance.OwningRelationship = null;
                }
                else
                {
                    if (owningRelationshipProperty.TryGetProperty("@id"u8, out JsonElement owningRelationshipAtIdProperty))
                    {
                        var propertyValue = owningRelationshipAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.OwningRelationship = propertyValue;
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the owningRelationship Json property was not found in the Intersecting: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("qualifiedName"u8, out JsonElement getQualifiedNameProperty))
            {
                dtoInstance.GetQualifiedName = getQualifiedNameProperty.GetString();
            }
            else
            {
                logger.LogDebug($"the qualifiedName Json property was not found in the Intersecting: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("relatedElement"u8, out JsonElement getRelatedElementProperty))
            {
                foreach (var arrayItem in getRelatedElementProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getRelatedElementAtIdProperty))
                    {
                        var propertyValue = getRelatedElementAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetRelatedElement.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the relatedElement Json property was not found in the Intersecting: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("shortName"u8, out JsonElement getShortNameProperty))
            {
                dtoInstance.GetShortName = getShortNameProperty.GetString();
            }
            else
            {
                logger.LogDebug($"the shortName Json property was not found in the Intersecting: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("source"u8, out _))
            {
                logger.LogDebug($"the Intersecting.Source property is Redefined property which should not be present in the JSON. It was found in Intersecting: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("target"u8, out _))
            {
                logger.LogDebug($"the Intersecting.Target property is Redefined property which should not be present in the JSON. It was found in Intersecting: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("textualRepresentation"u8, out JsonElement getTextualRepresentationProperty))
            {
                foreach (var arrayItem in getTextualRepresentationProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getTextualRepresentationAtIdProperty))
                    {
                        var propertyValue = getTextualRepresentationAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetTextualRepresentation.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the textualRepresentation Json property was not found in the Intersecting: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("typeIntersected"u8, out JsonElement getTypeIntersectedProperty))
            {
                if (getTypeIntersectedProperty.ValueKind == JsonValueKind.Null)
                {
                    dtoInstance.GetTypeIntersected = "-";
                    logger.LogDebug("the Intersecting.TypeIntersected property was not found in the Json. The value is set to '-'");
                }
                else
                {
                    if (getTypeIntersectedProperty.TryGetProperty("@id"u8, out JsonElement getTypeIntersectedAtIdProperty))
                    {
                        var propertyValue = getTypeIntersectedAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetTypeIntersected = propertyValue;
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the typeIntersected Json property was not found in the Intersecting: {dtoInstance.ElementId}");
            }


            return dtoInstance;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
