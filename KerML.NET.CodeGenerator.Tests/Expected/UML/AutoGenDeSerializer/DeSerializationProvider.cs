// -------------------------------------------------------------------------------------------------
// <copyright file="DeSerializationProvider.cs" company="Starion Group S.A.">
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
    using System.Collections.Generic;
    using System.Text.Json;

    using KerML.NET.DTO.Root.Elements;

    using Microsoft.Extensions.Logging;

    /// <summary>
    /// Delegate provider for the appropriate deserialization method to deserialize a <see cref="System.Type"/>
    /// </summary>
    public static class DeSerializationProvider
    {
        /// <summary>
        /// a dictionary that provides delegates for deserialization
        /// </summary>
        private static readonly Dictionary<string, Func<JsonElement, SerializationModeKind, ILoggerFactory, IElement>> DeSerializerActionMap = new Dictionary<string, Func<JsonElement, SerializationModeKind, ILoggerFactory, IElement>>
        {
                { "AnnotatingElement", AnnotatingElementDeSerializer.DeSerialize },
                { "Annotation", AnnotationDeSerializer.DeSerialize },
                { "Association", AssociationDeSerializer.DeSerialize },
                { "AssociationStructure", AssociationStructureDeSerializer.DeSerialize },
                { "Behavior", BehaviorDeSerializer.DeSerialize },
                { "BindingConnector", BindingConnectorDeSerializer.DeSerialize },
                { "BooleanExpression", BooleanExpressionDeSerializer.DeSerialize },
                { "Class", ClassDeSerializer.DeSerialize },
                { "Classifier", ClassifierDeSerializer.DeSerialize },
                { "CollectExpression", CollectExpressionDeSerializer.DeSerialize },
                { "Comment", CommentDeSerializer.DeSerialize },
                { "Conjugation", ConjugationDeSerializer.DeSerialize },
                { "Connector", ConnectorDeSerializer.DeSerialize },
                { "CrossSubsetting", CrossSubsettingDeSerializer.DeSerialize },
                { "DataType", DataTypeDeSerializer.DeSerialize },
                { "Dependency", DependencyDeSerializer.DeSerialize },
                { "Differencing", DifferencingDeSerializer.DeSerialize },
                { "Disjoining", DisjoiningDeSerializer.DeSerialize },
                { "Documentation", DocumentationDeSerializer.DeSerialize },
                { "ElementFilterMembership", ElementFilterMembershipDeSerializer.DeSerialize },
                { "EndFeatureMembership", EndFeatureMembershipDeSerializer.DeSerialize },
                { "Expression", ExpressionDeSerializer.DeSerialize },
                { "Feature", FeatureDeSerializer.DeSerialize },
                { "FeatureChainExpression", FeatureChainExpressionDeSerializer.DeSerialize },
                { "FeatureChaining", FeatureChainingDeSerializer.DeSerialize },
                { "FeatureInverting", FeatureInvertingDeSerializer.DeSerialize },
                { "FeatureMembership", FeatureMembershipDeSerializer.DeSerialize },
                { "FeatureReferenceExpression", FeatureReferenceExpressionDeSerializer.DeSerialize },
                { "FeatureTyping", FeatureTypingDeSerializer.DeSerialize },
                { "FeatureValue", FeatureValueDeSerializer.DeSerialize },
                { "Function", FunctionDeSerializer.DeSerialize },
                { "IndexExpression", IndexExpressionDeSerializer.DeSerialize },
                { "Interaction", InteractionDeSerializer.DeSerialize },
                { "Intersecting", IntersectingDeSerializer.DeSerialize },
                { "Invariant", InvariantDeSerializer.DeSerialize },
                { "InvocationExpression", InvocationExpressionDeSerializer.DeSerialize },
                { "ItemFeature", ItemFeatureDeSerializer.DeSerialize },
                { "ItemFlow", ItemFlowDeSerializer.DeSerialize },
                { "ItemFlowEnd", ItemFlowEndDeSerializer.DeSerialize },
                { "LibraryPackage", LibraryPackageDeSerializer.DeSerialize },
                { "LiteralBoolean", LiteralBooleanDeSerializer.DeSerialize },
                { "LiteralExpression", LiteralExpressionDeSerializer.DeSerialize },
                { "LiteralInfinity", LiteralInfinityDeSerializer.DeSerialize },
                { "LiteralInteger", LiteralIntegerDeSerializer.DeSerialize },
                { "LiteralRational", LiteralRationalDeSerializer.DeSerialize },
                { "LiteralString", LiteralStringDeSerializer.DeSerialize },
                { "Membership", MembershipDeSerializer.DeSerialize },
                { "MembershipImport", MembershipImportDeSerializer.DeSerialize },
                { "Metaclass", MetaclassDeSerializer.DeSerialize },
                { "MetadataAccessExpression", MetadataAccessExpressionDeSerializer.DeSerialize },
                { "MetadataFeature", MetadataFeatureDeSerializer.DeSerialize },
                { "Multiplicity", MultiplicityDeSerializer.DeSerialize },
                { "MultiplicityRange", MultiplicityRangeDeSerializer.DeSerialize },
                { "Namespace", NamespaceDeSerializer.DeSerialize },
                { "NamespaceImport", NamespaceImportDeSerializer.DeSerialize },
                { "NullExpression", NullExpressionDeSerializer.DeSerialize },
                { "OperatorExpression", OperatorExpressionDeSerializer.DeSerialize },
                { "OwningMembership", OwningMembershipDeSerializer.DeSerialize },
                { "Package", PackageDeSerializer.DeSerialize },
                { "ParameterMembership", ParameterMembershipDeSerializer.DeSerialize },
                { "Predicate", PredicateDeSerializer.DeSerialize },
                { "Redefinition", RedefinitionDeSerializer.DeSerialize },
                { "ReferenceSubsetting", ReferenceSubsettingDeSerializer.DeSerialize },
                { "ResultExpressionMembership", ResultExpressionMembershipDeSerializer.DeSerialize },
                { "ReturnParameterMembership", ReturnParameterMembershipDeSerializer.DeSerialize },
                { "SelectExpression", SelectExpressionDeSerializer.DeSerialize },
                { "Specialization", SpecializationDeSerializer.DeSerialize },
                { "Step", StepDeSerializer.DeSerialize },
                { "Structure", StructureDeSerializer.DeSerialize },
                { "Subclassification", SubclassificationDeSerializer.DeSerialize },
                { "Subsetting", SubsettingDeSerializer.DeSerialize },
                { "Succession", SuccessionDeSerializer.DeSerialize },
                { "SuccessionItemFlow", SuccessionItemFlowDeSerializer.DeSerialize },
                { "TextualRepresentation", TextualRepresentationDeSerializer.DeSerialize },
                { "Type", TypeDeSerializer.DeSerialize },
                { "TypeFeaturing", TypeFeaturingDeSerializer.DeSerialize },
                { "Unioning", UnioningDeSerializer.DeSerialize },
        };

        /// <summary>
        /// Provides the delegate <see cref="Func{JsonElement, SerializationModeKind, ILoggerFactory, IElement}"/> for the
        /// <see cref="System.Type"/> that is to be deserialized
        /// </summary>
        /// <param name="typeName">
        /// The name of the subject <see cref="System.Type"/> that is to be serialized
        /// </param>
        /// <returns>
        /// A Delegate of <see cref="Func{JsonElement, SerializationModeKind, ILoggerFactory, IElement}"/>
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// Thrown when the <see cref="System.Type"/> is not supported.
        /// </exception>
        public static Func<JsonElement, SerializationModeKind, ILoggerFactory, IElement> Provide(string typeName)
        {
            if (!DeSerializerActionMap.TryGetValue(typeName, out var func))
            {
                throw new NotSupportedException($"The {typeName} is not supported by the DeSerializationProvider.");
            }

            return func;
        }

        /// <summary>
        /// Asserts whether the <paramref name="typeName"/> is supported by the provider
        /// </summary>
        /// <param name="typeName">
        /// The name of the subject <see cref="System.Type"/> for which support is asserted
        /// </param>
        /// <returns></returns>
        internal static bool IsTypeSupported(string typeName)
        {
            return DeSerializerActionMap.ContainsKey(typeName);
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
