// -------------------------------------------------------------------------------------------------
// <copyright file="AssociationStructureDeSerializer.cs" company="Starion Group S.A.">
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

    using KerML.NET.DTO.Kernel.Associations;

    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Logging.Abstractions;

    /// <summary>
    /// The purpose of the <see cref="AssociationStructureDeSerializer"/> is to provide deserialization capabilities
    /// for the <see cref="IAssociationStructure"/> interface
    /// </summary>
    public static class AssociationStructureDeSerializer
    {
        /// <summary>
        /// Deserializes an instance of <see cref="IAssociationStructure"/> from the provided <see cref="JsonElement"/>
        /// </summary>
        /// <param name="jsonElement">
        /// The <see cref="JsonElement"/> that contains the <see cref="IAssociationStructure"/> json object
        /// </param>
        /// <param name="serializationModeKind">
        /// enumeration specifying what kind of serialization shall be used
        /// </param>
        /// <param name="loggerFactory">
        /// The <see cref="ILoggerFactory"/> used to set up logging
        /// </param>
        /// <returns>
        /// an instance of <see cref="IAssociationStructure"/>
        /// </returns>
        public static IAssociationStructure DeSerialize(JsonElement jsonElement, SerializationModeKind serializationModeKind, ILoggerFactory? loggerFactory = null)
        {
            var logger = loggerFactory == null ? NullLogger.Instance : loggerFactory.CreateLogger("AssociationStructureDeSerializer");

            if (!jsonElement.TryGetProperty("@type"u8, out JsonElement type))
            {
                throw new InvalidOperationException("The @type property is not available, the AssociationStructureDeSerializer cannot be used to deserialize this JsonElement");
            }

            if (type.GetString() != "AssociationStructure")
            {
                throw new InvalidOperationException($"The AssociationStructureDeSerializer can only be used to deserialize objects of type IAssociationStructure, a {type.GetString()} was provided");
            }

            var dtoInstance = new KerML.NET.DTO.Kernel.Associations.AssociationStructure();

            if (jsonElement.TryGetProperty("@id"u8, out JsonElement idProperty))
            {
                var propertyValue = idProperty.GetString();
                if (propertyValue == null)
                {
                    throw new JsonException("The @id property is not present, the AssociationStructure cannot be deserialized");
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
                logger.LogDebug($"the aliasIds Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("associationEnd"u8, out JsonElement getAssociationEndProperty))
            {
                foreach (var arrayItem in getAssociationEndProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getAssociationEndAtIdProperty))
                    {
                        var propertyValue = getAssociationEndAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetAssociationEnd.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the associationEnd Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("declaredName"u8, out JsonElement declaredNameProperty))
            {
                dtoInstance.DeclaredName = declaredNameProperty.GetString();
            }
            else
            {
                logger.LogDebug($"the declaredName Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("declaredShortName"u8, out JsonElement declaredShortNameProperty))
            {
                dtoInstance.DeclaredShortName = declaredShortNameProperty.GetString();
            }
            else
            {
                logger.LogDebug($"the declaredShortName Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("differencingType"u8, out JsonElement getDifferencingTypeProperty))
            {
                foreach (var arrayItem in getDifferencingTypeProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getDifferencingTypeAtIdProperty))
                    {
                        var propertyValue = getDifferencingTypeAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetDifferencingType.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the differencingType Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("directedFeature"u8, out JsonElement getDirectedFeatureProperty))
            {
                foreach (var arrayItem in getDirectedFeatureProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getDirectedFeatureAtIdProperty))
                    {
                        var propertyValue = getDirectedFeatureAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetDirectedFeature.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the directedFeature Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the documentation Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the elementId Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("endFeature"u8, out _))
            {
                logger.LogDebug($"the AssociationStructure.EndFeature property is Redefined property which should not be present in the JSON. It was found in AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("feature"u8, out JsonElement getFeatureProperty))
            {
                foreach (var arrayItem in getFeatureProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getFeatureAtIdProperty))
                    {
                        var propertyValue = getFeatureAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetFeature.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the feature Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("featureMembership"u8, out JsonElement getFeatureMembershipProperty))
            {
                foreach (var arrayItem in getFeatureMembershipProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getFeatureMembershipAtIdProperty))
                    {
                        var propertyValue = getFeatureMembershipAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetFeatureMembership.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the featureMembership Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("importedMembership"u8, out JsonElement getImportedMembershipProperty))
            {
                foreach (var arrayItem in getImportedMembershipProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getImportedMembershipAtIdProperty))
                    {
                        var propertyValue = getImportedMembershipAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetImportedMembership.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the importedMembership Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("inheritedFeature"u8, out JsonElement getInheritedFeatureProperty))
            {
                foreach (var arrayItem in getInheritedFeatureProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getInheritedFeatureAtIdProperty))
                    {
                        var propertyValue = getInheritedFeatureAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetInheritedFeature.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the inheritedFeature Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("inheritedMembership"u8, out JsonElement getInheritedMembershipProperty))
            {
                foreach (var arrayItem in getInheritedMembershipProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getInheritedMembershipAtIdProperty))
                    {
                        var propertyValue = getInheritedMembershipAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetInheritedMembership.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the inheritedMembership Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("input"u8, out JsonElement getInputProperty))
            {
                foreach (var arrayItem in getInputProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getInputAtIdProperty))
                    {
                        var propertyValue = getInputAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetInput.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the input Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("intersectingType"u8, out JsonElement getIntersectingTypeProperty))
            {
                foreach (var arrayItem in getIntersectingTypeProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getIntersectingTypeAtIdProperty))
                    {
                        var propertyValue = getIntersectingTypeAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetIntersectingType.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the intersectingType Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("isAbstract"u8, out JsonElement isAbstractProperty))
            {
                if (isAbstractProperty.ValueKind != JsonValueKind.Null)
                {
                    dtoInstance.IsAbstract = isAbstractProperty.GetBoolean();
                }
            }
            else
            {
                logger.LogDebug($"the isAbstract Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("isConjugated"u8, out JsonElement getIsConjugatedProperty))
            {
                if (getIsConjugatedProperty.ValueKind != JsonValueKind.Null)
                {
                    dtoInstance.GetIsConjugated = getIsConjugatedProperty.GetBoolean();
                }
            }
            else
            {
                logger.LogDebug($"the isConjugated Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the isImplied Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the isImpliedIncluded Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the isLibraryElement Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("isSufficient"u8, out JsonElement isSufficientProperty))
            {
                if (isSufficientProperty.ValueKind != JsonValueKind.Null)
                {
                    dtoInstance.IsSufficient = isSufficientProperty.GetBoolean();
                }
            }
            else
            {
                logger.LogDebug($"the isSufficient Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("member"u8, out JsonElement getMemberProperty))
            {
                foreach (var arrayItem in getMemberProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getMemberAtIdProperty))
                    {
                        var propertyValue = getMemberAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetMember.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the member Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("membership"u8, out JsonElement getMembershipProperty))
            {
                foreach (var arrayItem in getMembershipProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getMembershipAtIdProperty))
                    {
                        var propertyValue = getMembershipAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetMembership.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the membership Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("multiplicity"u8, out JsonElement getMultiplicityProperty))
            {
                if (getMultiplicityProperty.ValueKind == JsonValueKind.Null)
                {
                    dtoInstance.GetMultiplicity = null;
                }
                else
                {
                    if (getMultiplicityProperty.TryGetProperty("@id"u8, out JsonElement getMultiplicityAtIdProperty))
                    {
                        var propertyValue = getMultiplicityAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetMultiplicity = propertyValue;
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the multiplicity Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("name"u8, out JsonElement getNameProperty))
            {
                dtoInstance.GetName = getNameProperty.GetString();
            }
            else
            {
                logger.LogDebug($"the name Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("output"u8, out JsonElement getOutputProperty))
            {
                foreach (var arrayItem in getOutputProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getOutputAtIdProperty))
                    {
                        var propertyValue = getOutputAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOutput.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the output Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the ownedAnnotation Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedConjugator"u8, out JsonElement getOwnedConjugatorProperty))
            {
                if (getOwnedConjugatorProperty.ValueKind == JsonValueKind.Null)
                {
                    dtoInstance.GetOwnedConjugator = null;
                }
                else
                {
                    if (getOwnedConjugatorProperty.TryGetProperty("@id"u8, out JsonElement getOwnedConjugatorAtIdProperty))
                    {
                        var propertyValue = getOwnedConjugatorAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedConjugator = propertyValue;
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedConjugator Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedDifferencing"u8, out JsonElement getOwnedDifferencingProperty))
            {
                foreach (var arrayItem in getOwnedDifferencingProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getOwnedDifferencingAtIdProperty))
                    {
                        var propertyValue = getOwnedDifferencingAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedDifferencing.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedDifferencing Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedDisjoining"u8, out JsonElement getOwnedDisjoiningProperty))
            {
                foreach (var arrayItem in getOwnedDisjoiningProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getOwnedDisjoiningAtIdProperty))
                    {
                        var propertyValue = getOwnedDisjoiningAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedDisjoining.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedDisjoining Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the ownedElement Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedEndFeature"u8, out JsonElement getOwnedEndFeatureProperty))
            {
                foreach (var arrayItem in getOwnedEndFeatureProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getOwnedEndFeatureAtIdProperty))
                    {
                        var propertyValue = getOwnedEndFeatureAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedEndFeature.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedEndFeature Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedFeature"u8, out JsonElement getOwnedFeatureProperty))
            {
                foreach (var arrayItem in getOwnedFeatureProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getOwnedFeatureAtIdProperty))
                    {
                        var propertyValue = getOwnedFeatureAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedFeature.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedFeature Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedFeatureMembership"u8, out JsonElement getOwnedFeatureMembershipProperty))
            {
                foreach (var arrayItem in getOwnedFeatureMembershipProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getOwnedFeatureMembershipAtIdProperty))
                    {
                        var propertyValue = getOwnedFeatureMembershipAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedFeatureMembership.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedFeatureMembership Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedImport"u8, out JsonElement getOwnedImportProperty))
            {
                foreach (var arrayItem in getOwnedImportProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getOwnedImportAtIdProperty))
                    {
                        var propertyValue = getOwnedImportAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedImport.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedImport Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedIntersecting"u8, out JsonElement getOwnedIntersectingProperty))
            {
                foreach (var arrayItem in getOwnedIntersectingProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getOwnedIntersectingAtIdProperty))
                    {
                        var propertyValue = getOwnedIntersectingAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedIntersecting.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedIntersecting Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedMember"u8, out JsonElement getOwnedMemberProperty))
            {
                foreach (var arrayItem in getOwnedMemberProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getOwnedMemberAtIdProperty))
                    {
                        var propertyValue = getOwnedMemberAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedMember.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedMember Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedMembership"u8, out JsonElement getOwnedMembershipProperty))
            {
                foreach (var arrayItem in getOwnedMembershipProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getOwnedMembershipAtIdProperty))
                    {
                        var propertyValue = getOwnedMembershipAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedMembership.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedMembership Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the ownedRelatedElement Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the ownedRelationship Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedSpecialization"u8, out JsonElement getOwnedSpecializationProperty))
            {
                foreach (var arrayItem in getOwnedSpecializationProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getOwnedSpecializationAtIdProperty))
                    {
                        var propertyValue = getOwnedSpecializationAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedSpecialization.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedSpecialization Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedSubclassification"u8, out JsonElement getOwnedSubclassificationProperty))
            {
                foreach (var arrayItem in getOwnedSubclassificationProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getOwnedSubclassificationAtIdProperty))
                    {
                        var propertyValue = getOwnedSubclassificationAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedSubclassification.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedSubclassification Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedUnioning"u8, out JsonElement getOwnedUnioningProperty))
            {
                foreach (var arrayItem in getOwnedUnioningProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getOwnedUnioningAtIdProperty))
                    {
                        var propertyValue = getOwnedUnioningAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedUnioning.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedUnioning Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the owner Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the owningMembership Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the owningNamespace Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the owningRelatedElement Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the owningRelationship Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("qualifiedName"u8, out JsonElement getQualifiedNameProperty))
            {
                dtoInstance.GetQualifiedName = getQualifiedNameProperty.GetString();
            }
            else
            {
                logger.LogDebug($"the qualifiedName Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("relatedElement"u8, out _))
            {
                logger.LogDebug($"the AssociationStructure.RelatedElement property is Redefined property which should not be present in the JSON. It was found in AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("relatedType"u8, out JsonElement getRelatedTypeProperty))
            {
                foreach (var arrayItem in getRelatedTypeProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getRelatedTypeAtIdProperty))
                    {
                        var propertyValue = getRelatedTypeAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetRelatedType.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the relatedType Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("shortName"u8, out JsonElement getShortNameProperty))
            {
                dtoInstance.GetShortName = getShortNameProperty.GetString();
            }
            else
            {
                logger.LogDebug($"the shortName Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("source"u8, out _))
            {
                logger.LogDebug($"the AssociationStructure.Source property is Redefined property which should not be present in the JSON. It was found in AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("sourceType"u8, out JsonElement getSourceTypeProperty))
            {
                if (getSourceTypeProperty.ValueKind == JsonValueKind.Null)
                {
                    dtoInstance.GetSourceType = null;
                }
                else
                {
                    if (getSourceTypeProperty.TryGetProperty("@id"u8, out JsonElement getSourceTypeAtIdProperty))
                    {
                        var propertyValue = getSourceTypeAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetSourceType = propertyValue;
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the sourceType Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("target"u8, out _))
            {
                logger.LogDebug($"the AssociationStructure.Target property is Redefined property which should not be present in the JSON. It was found in AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("targetType"u8, out JsonElement getTargetTypeProperty))
            {
                foreach (var arrayItem in getTargetTypeProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getTargetTypeAtIdProperty))
                    {
                        var propertyValue = getTargetTypeAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetTargetType.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the targetType Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the textualRepresentation Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("unioningType"u8, out JsonElement getUnioningTypeProperty))
            {
                foreach (var arrayItem in getUnioningTypeProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement getUnioningTypeAtIdProperty))
                    {
                        var propertyValue = getUnioningTypeAtIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetUnioningType.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the unioningType Json property was not found in the AssociationStructure: {dtoInstance.ElementId}");
            }


            return dtoInstance;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
