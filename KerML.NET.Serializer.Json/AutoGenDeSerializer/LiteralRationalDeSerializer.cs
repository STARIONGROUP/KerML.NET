// -------------------------------------------------------------------------------------------------
// <copyright file="LiteralRational.cs" company="Starion Group S.A.">
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

    using KerML.NET.DTO.Kernel.Expressions;

    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Logging.Abstractions;

    /// <summary>
    /// The purpose of the <see cref="LiteralRationalDeSerializer"/> is to provide deserialization capabilities
    /// for the <see cref="ILiteralRational"/> interface
    /// </summary>
    public static class LiteralRationalDeSerializer
    {
        /// <summary>
        /// Deserializes an instance of <see cref="ILiteralRational"/> from the provided <see cref="JsonElement"/>
        /// </summary>
        /// <param name="jsonElement">
        /// The <see cref="JsonElement"/> that contains the <see cref="ILiteralRational"/> json object
        /// </param>
        /// <param name="serializationModeKind">
        /// enumeration specifying what kind of serialization shall be used
        /// </param>
        /// <param name="loggerFactory">
        /// The <see cref="ILoggerFactory"/> used to set up logging
        /// </param>
        /// <returns>
        /// an instance of <see cref="ILiteralRational"/>
        /// </returns>
        public static ILiteralRational DeSerialize(JsonElement jsonElement, SerializationModeKind serializationModeKind, ILoggerFactory? loggerFactory = null)
        {
            var logger = loggerFactory == null ? NullLogger.Instance : loggerFactory.CreateLogger("LiteralRationalDeSerializer");

            if (!jsonElement.TryGetProperty("@type"u8, out JsonElement type))
            {
                throw new InvalidOperationException("The @type property is not available, the LiteralRationalDeSerializer cannot be used to deserialize this JsonElement");
            }

            if (type.GetString() != "LiteralRational")
            {
                throw new InvalidOperationException($"The LiteralRationalDeSerializer can only be used to deserialize objects of type ILiteralRational, a {type.GetString()} was provided");
            }

            var dtoInstance = new KerML.NET.DTO.Kernel.Expressions.LiteralRational();

            if (jsonElement.TryGetProperty("@id"u8, out JsonElement idProperty))
            {
                var propertyValue = idProperty.GetString();
                if (propertyValue == null)
                {
                    throw new JsonException("The @id property is not present, the LiteralRational cannot be deserialized");
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
                logger.LogDebug($"the aliasIds Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("behavior"u8, out _))
            {
                logger.LogDebug($"the LiteralRational.Behavior property is Redefined property which should not be present in the JSON. It was found in LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("chainingFeature"u8, out JsonElement chainingFeatureProperty))
            {
                foreach (var arrayItem in chainingFeatureProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement chainingFeatureIdProperty))
                    {
                        var propertyValue = chainingFeatureIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetChainingFeature.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the chainingFeature Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("crossFeature"u8, out JsonElement crossFeatureProperty))
            {
                if (crossFeatureProperty.ValueKind == JsonValueKind.Null)
                {
                    dtoInstance.GetCrossFeature = null;
                }
                else
                {
                    if (crossFeatureProperty.TryGetProperty("@id"u8, out JsonElement crossFeatureIdProperty))
                    {
                        var propertyValue = crossFeatureIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetCrossFeature = propertyValue;
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the crossFeature Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("declaredName"u8, out JsonElement declaredNameProperty))
            {
                dtoInstance.DeclaredName = declaredNameProperty.GetString();
            }
            else
            {
                logger.LogDebug($"the declaredName Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("declaredShortName"u8, out JsonElement declaredShortNameProperty))
            {
                dtoInstance.DeclaredShortName = declaredShortNameProperty.GetString();
            }
            else
            {
                logger.LogDebug($"the declaredShortName Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("differencingType"u8, out JsonElement differencingTypeProperty))
            {
                foreach (var arrayItem in differencingTypeProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement differencingTypeIdProperty))
                    {
                        var propertyValue = differencingTypeIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetDifferencingType.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the differencingType Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("directedFeature"u8, out _))
            {
                logger.LogDebug($"the LiteralRational.DirectedFeature property is Redefined property which should not be present in the JSON. It was found in LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("direction"u8, out JsonElement directionProperty))
            {
                dtoInstance.Direction = FeatureDirectionKindDeSerializer.DeserializeNullable(directionProperty.GetString());
            }
            else
            {
                logger.LogDebug($"the direction Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the documentation Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the elementId Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("endFeature"u8, out JsonElement endFeatureProperty))
            {
                foreach (var arrayItem in endFeatureProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement endFeatureIdProperty))
                    {
                        var propertyValue = endFeatureIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetEndFeature.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the endFeature Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("endOwningType"u8, out JsonElement endOwningTypeProperty))
            {
                if (endOwningTypeProperty.ValueKind == JsonValueKind.Null)
                {
                    dtoInstance.GetEndOwningType = null;
                }
                else
                {
                    if (endOwningTypeProperty.TryGetProperty("@id"u8, out JsonElement endOwningTypeIdProperty))
                    {
                        var propertyValue = endOwningTypeIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetEndOwningType = propertyValue;
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the endOwningType Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("feature"u8, out JsonElement featureProperty))
            {
                foreach (var arrayItem in featureProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement featureIdProperty))
                    {
                        var propertyValue = featureIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetFeature.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the feature Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("featureMembership"u8, out JsonElement featureMembershipProperty))
            {
                foreach (var arrayItem in featureMembershipProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement featureMembershipIdProperty))
                    {
                        var propertyValue = featureMembershipIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetFeatureMembership.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the featureMembership Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("featureTarget"u8, out JsonElement featureTargetProperty))
            {
                if (featureTargetProperty.ValueKind == JsonValueKind.Null)
                {
                    dtoInstance.GetFeatureTarget = "-";
                    logger.LogDebug("the LiteralRational.FeatureTarget property was not found in the Json. The value is set to '-'");
                }
                else
                {
                    if (featureTargetProperty.TryGetProperty("@id"u8, out JsonElement featureTargetIdProperty))
                    {
                        var propertyValue = featureTargetIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetFeatureTarget = propertyValue;
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the featureTarget Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("featuringType"u8, out JsonElement featuringTypeProperty))
            {
                foreach (var arrayItem in featuringTypeProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement featuringTypeIdProperty))
                    {
                        var propertyValue = featuringTypeIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetFeaturingType.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the featuringType Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("function"u8, out JsonElement functionProperty))
            {
                if (functionProperty.ValueKind == JsonValueKind.Null)
                {
                    dtoInstance.GetFunction = null;
                }
                else
                {
                    if (functionProperty.TryGetProperty("@id"u8, out JsonElement functionIdProperty))
                    {
                        var propertyValue = functionIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetFunction = propertyValue;
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the function Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("importedMembership"u8, out JsonElement importedMembershipProperty))
            {
                foreach (var arrayItem in importedMembershipProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement importedMembershipIdProperty))
                    {
                        var propertyValue = importedMembershipIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetImportedMembership.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the importedMembership Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("inheritedFeature"u8, out JsonElement inheritedFeatureProperty))
            {
                foreach (var arrayItem in inheritedFeatureProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement inheritedFeatureIdProperty))
                    {
                        var propertyValue = inheritedFeatureIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetInheritedFeature.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the inheritedFeature Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("inheritedMembership"u8, out JsonElement inheritedMembershipProperty))
            {
                foreach (var arrayItem in inheritedMembershipProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement inheritedMembershipIdProperty))
                    {
                        var propertyValue = inheritedMembershipIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetInheritedMembership.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the inheritedMembership Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("input"u8, out JsonElement inputProperty))
            {
                foreach (var arrayItem in inputProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement inputIdProperty))
                    {
                        var propertyValue = inputIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetInput.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the input Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("intersectingType"u8, out JsonElement intersectingTypeProperty))
            {
                foreach (var arrayItem in intersectingTypeProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement intersectingTypeIdProperty))
                    {
                        var propertyValue = intersectingTypeIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetIntersectingType.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the intersectingType Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the isAbstract Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("isComposite"u8, out JsonElement isCompositeProperty))
            {
                if (isCompositeProperty.ValueKind != JsonValueKind.Null)
                {
                    dtoInstance.IsComposite = isCompositeProperty.GetBoolean();
                }
            }
            else
            {
                logger.LogDebug($"the isComposite Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("isConjugated"u8, out JsonElement isConjugatedProperty))
            {
                if (isConjugatedProperty.ValueKind != JsonValueKind.Null)
                {
                    dtoInstance.GetIsConjugated = isConjugatedProperty.GetBoolean();
                }
            }
            else
            {
                logger.LogDebug($"the isConjugated Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("isDerived"u8, out JsonElement isDerivedProperty))
            {
                if (isDerivedProperty.ValueKind != JsonValueKind.Null)
                {
                    dtoInstance.IsDerived = isDerivedProperty.GetBoolean();
                }
            }
            else
            {
                logger.LogDebug($"the isDerived Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("isEnd"u8, out JsonElement isEndProperty))
            {
                if (isEndProperty.ValueKind != JsonValueKind.Null)
                {
                    dtoInstance.IsEnd = isEndProperty.GetBoolean();
                }
            }
            else
            {
                logger.LogDebug($"the isEnd Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the isImpliedIncluded Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the isLibraryElement Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("isModelLevelEvaluable"u8, out JsonElement isModelLevelEvaluableProperty))
            {
                if (isModelLevelEvaluableProperty.ValueKind != JsonValueKind.Null)
                {
                    dtoInstance.GetIsModelLevelEvaluable = isModelLevelEvaluableProperty.GetBoolean();
                }
            }
            else
            {
                logger.LogDebug($"the isModelLevelEvaluable Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("isOrdered"u8, out JsonElement isOrderedProperty))
            {
                if (isOrderedProperty.ValueKind != JsonValueKind.Null)
                {
                    dtoInstance.IsOrdered = isOrderedProperty.GetBoolean();
                }
            }
            else
            {
                logger.LogDebug($"the isOrdered Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("isPortion"u8, out JsonElement isPortionProperty))
            {
                if (isPortionProperty.ValueKind != JsonValueKind.Null)
                {
                    dtoInstance.IsPortion = isPortionProperty.GetBoolean();
                }
            }
            else
            {
                logger.LogDebug($"the isPortion Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("isReadOnly"u8, out JsonElement isReadOnlyProperty))
            {
                if (isReadOnlyProperty.ValueKind != JsonValueKind.Null)
                {
                    dtoInstance.IsReadOnly = isReadOnlyProperty.GetBoolean();
                }
            }
            else
            {
                logger.LogDebug($"the isReadOnly Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the isSufficient Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("isUnique"u8, out JsonElement isUniqueProperty))
            {
                if (isUniqueProperty.ValueKind != JsonValueKind.Null)
                {
                    dtoInstance.IsUnique = isUniqueProperty.GetBoolean();
                }
            }
            else
            {
                logger.LogDebug($"the isUnique Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("member"u8, out JsonElement memberProperty))
            {
                foreach (var arrayItem in memberProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement memberIdProperty))
                    {
                        var propertyValue = memberIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetMember.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the member Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("membership"u8, out JsonElement membershipProperty))
            {
                foreach (var arrayItem in membershipProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement membershipIdProperty))
                    {
                        var propertyValue = membershipIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetMembership.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the membership Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("multiplicity"u8, out JsonElement multiplicityProperty))
            {
                if (multiplicityProperty.ValueKind == JsonValueKind.Null)
                {
                    dtoInstance.GetMultiplicity = null;
                }
                else
                {
                    if (multiplicityProperty.TryGetProperty("@id"u8, out JsonElement multiplicityIdProperty))
                    {
                        var propertyValue = multiplicityIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetMultiplicity = propertyValue;
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the multiplicity Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("name"u8, out JsonElement nameProperty))
            {
                dtoInstance.GetName = nameProperty.GetString();
            }
            else
            {
                logger.LogDebug($"the name Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("output"u8, out JsonElement outputProperty))
            {
                foreach (var arrayItem in outputProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement outputIdProperty))
                    {
                        var propertyValue = outputIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOutput.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the output Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the ownedAnnotation Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedConjugator"u8, out JsonElement ownedConjugatorProperty))
            {
                if (ownedConjugatorProperty.ValueKind == JsonValueKind.Null)
                {
                    dtoInstance.GetOwnedConjugator = null;
                }
                else
                {
                    if (ownedConjugatorProperty.TryGetProperty("@id"u8, out JsonElement ownedConjugatorIdProperty))
                    {
                        var propertyValue = ownedConjugatorIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedConjugator = propertyValue;
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedConjugator Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedCrossSubsetting"u8, out JsonElement ownedCrossSubsettingProperty))
            {
                if (ownedCrossSubsettingProperty.ValueKind == JsonValueKind.Null)
                {
                    dtoInstance.GetOwnedCrossSubsetting = null;
                }
                else
                {
                    if (ownedCrossSubsettingProperty.TryGetProperty("@id"u8, out JsonElement ownedCrossSubsettingIdProperty))
                    {
                        var propertyValue = ownedCrossSubsettingIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedCrossSubsetting = propertyValue;
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedCrossSubsetting Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedDifferencing"u8, out JsonElement ownedDifferencingProperty))
            {
                foreach (var arrayItem in ownedDifferencingProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement ownedDifferencingIdProperty))
                    {
                        var propertyValue = ownedDifferencingIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedDifferencing.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedDifferencing Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedDisjoining"u8, out JsonElement ownedDisjoiningProperty))
            {
                foreach (var arrayItem in ownedDisjoiningProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement ownedDisjoiningIdProperty))
                    {
                        var propertyValue = ownedDisjoiningIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedDisjoining.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedDisjoining Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the ownedElement Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedEndFeature"u8, out JsonElement ownedEndFeatureProperty))
            {
                foreach (var arrayItem in ownedEndFeatureProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement ownedEndFeatureIdProperty))
                    {
                        var propertyValue = ownedEndFeatureIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedEndFeature.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedEndFeature Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedFeature"u8, out JsonElement ownedFeatureProperty))
            {
                foreach (var arrayItem in ownedFeatureProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement ownedFeatureIdProperty))
                    {
                        var propertyValue = ownedFeatureIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedFeature.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedFeature Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedFeatureChaining"u8, out JsonElement ownedFeatureChainingProperty))
            {
                foreach (var arrayItem in ownedFeatureChainingProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement ownedFeatureChainingIdProperty))
                    {
                        var propertyValue = ownedFeatureChainingIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedFeatureChaining.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedFeatureChaining Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedFeatureInverting"u8, out JsonElement ownedFeatureInvertingProperty))
            {
                foreach (var arrayItem in ownedFeatureInvertingProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement ownedFeatureInvertingIdProperty))
                    {
                        var propertyValue = ownedFeatureInvertingIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedFeatureInverting.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedFeatureInverting Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedFeatureMembership"u8, out JsonElement ownedFeatureMembershipProperty))
            {
                foreach (var arrayItem in ownedFeatureMembershipProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement ownedFeatureMembershipIdProperty))
                    {
                        var propertyValue = ownedFeatureMembershipIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedFeatureMembership.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedFeatureMembership Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedImport"u8, out JsonElement ownedImportProperty))
            {
                foreach (var arrayItem in ownedImportProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement ownedImportIdProperty))
                    {
                        var propertyValue = ownedImportIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedImport.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedImport Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedIntersecting"u8, out JsonElement ownedIntersectingProperty))
            {
                foreach (var arrayItem in ownedIntersectingProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement ownedIntersectingIdProperty))
                    {
                        var propertyValue = ownedIntersectingIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedIntersecting.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedIntersecting Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedMember"u8, out JsonElement ownedMemberProperty))
            {
                foreach (var arrayItem in ownedMemberProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement ownedMemberIdProperty))
                    {
                        var propertyValue = ownedMemberIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedMember.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedMember Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedMembership"u8, out JsonElement ownedMembershipProperty))
            {
                foreach (var arrayItem in ownedMembershipProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement ownedMembershipIdProperty))
                    {
                        var propertyValue = ownedMembershipIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedMembership.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedMembership Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedRedefinition"u8, out JsonElement ownedRedefinitionProperty))
            {
                foreach (var arrayItem in ownedRedefinitionProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement ownedRedefinitionIdProperty))
                    {
                        var propertyValue = ownedRedefinitionIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedRedefinition.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedRedefinition Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedReferenceSubsetting"u8, out JsonElement ownedReferenceSubsettingProperty))
            {
                if (ownedReferenceSubsettingProperty.ValueKind == JsonValueKind.Null)
                {
                    dtoInstance.GetOwnedReferenceSubsetting = null;
                }
                else
                {
                    if (ownedReferenceSubsettingProperty.TryGetProperty("@id"u8, out JsonElement ownedReferenceSubsettingIdProperty))
                    {
                        var propertyValue = ownedReferenceSubsettingIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedReferenceSubsetting = propertyValue;
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedReferenceSubsetting Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the ownedRelationship Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedSpecialization"u8, out JsonElement ownedSpecializationProperty))
            {
                foreach (var arrayItem in ownedSpecializationProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement ownedSpecializationIdProperty))
                    {
                        var propertyValue = ownedSpecializationIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedSpecialization.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedSpecialization Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedSubsetting"u8, out JsonElement ownedSubsettingProperty))
            {
                foreach (var arrayItem in ownedSubsettingProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement ownedSubsettingIdProperty))
                    {
                        var propertyValue = ownedSubsettingIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedSubsetting.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedSubsetting Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedTypeFeaturing"u8, out JsonElement ownedTypeFeaturingProperty))
            {
                foreach (var arrayItem in ownedTypeFeaturingProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement ownedTypeFeaturingIdProperty))
                    {
                        var propertyValue = ownedTypeFeaturingIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedTypeFeaturing.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedTypeFeaturing Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedTyping"u8, out JsonElement ownedTypingProperty))
            {
                foreach (var arrayItem in ownedTypingProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement ownedTypingIdProperty))
                    {
                        var propertyValue = ownedTypingIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedTyping.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedTyping Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("ownedUnioning"u8, out JsonElement ownedUnioningProperty))
            {
                foreach (var arrayItem in ownedUnioningProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement ownedUnioningIdProperty))
                    {
                        var propertyValue = ownedUnioningIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwnedUnioning.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedUnioning Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the owner Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("owningFeatureMembership"u8, out JsonElement owningFeatureMembershipProperty))
            {
                if (owningFeatureMembershipProperty.ValueKind == JsonValueKind.Null)
                {
                    dtoInstance.GetOwningFeatureMembership = null;
                }
                else
                {
                    if (owningFeatureMembershipProperty.TryGetProperty("@id"u8, out JsonElement owningFeatureMembershipIdProperty))
                    {
                        var propertyValue = owningFeatureMembershipIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwningFeatureMembership = propertyValue;
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the owningFeatureMembership Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the owningMembership Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the owningNamespace Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the owningRelationship Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("owningType"u8, out JsonElement owningTypeProperty))
            {
                if (owningTypeProperty.ValueKind == JsonValueKind.Null)
                {
                    dtoInstance.GetOwningType = null;
                }
                else
                {
                    if (owningTypeProperty.TryGetProperty("@id"u8, out JsonElement owningTypeIdProperty))
                    {
                        var propertyValue = owningTypeIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetOwningType = propertyValue;
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the owningType Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("parameter"u8, out JsonElement parameterProperty))
            {
                foreach (var arrayItem in parameterProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement parameterIdProperty))
                    {
                        var propertyValue = parameterIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetParameter.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the parameter Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("qualifiedName"u8, out JsonElement qualifiedNameProperty))
            {
                dtoInstance.GetQualifiedName = qualifiedNameProperty.GetString();
            }
            else
            {
                logger.LogDebug($"the qualifiedName Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("result"u8, out JsonElement resultProperty))
            {
                if (resultProperty.ValueKind == JsonValueKind.Null)
                {
                    dtoInstance.GetResult = "-";
                    logger.LogDebug("the LiteralRational.Result property was not found in the Json. The value is set to '-'");
                }
                else
                {
                    if (resultProperty.TryGetProperty("@id"u8, out JsonElement resultIdProperty))
                    {
                        var propertyValue = resultIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetResult = propertyValue;
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the result Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("shortName"u8, out JsonElement shortNameProperty))
            {
                dtoInstance.GetShortName = shortNameProperty.GetString();
            }
            else
            {
                logger.LogDebug($"the shortName Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
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
                logger.LogDebug($"the textualRepresentation Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("type"u8, out JsonElement typeProperty))
            {
                foreach (var arrayItem in typeProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement typeIdProperty))
                    {
                        var propertyValue = typeIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetType.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the type Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("unioningType"u8, out JsonElement unioningTypeProperty))
            {
                foreach (var arrayItem in unioningTypeProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement unioningTypeIdProperty))
                    {
                        var propertyValue = unioningTypeIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.GetUnioningType.Add(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the unioningType Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }

            if (jsonElement.TryGetProperty("value"u8, out JsonElement valueProperty))
            {
                var propertyValue = valueProperty.GetString();
                if (propertyValue != null)
                {
                    dtoInstance.Value = propertyValue;
                }
            }
            else
            {
                logger.LogDebug($"the value Json property was not found in the LiteralRational: {dtoInstance.ElementId}");
            }


            return dtoInstance;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
