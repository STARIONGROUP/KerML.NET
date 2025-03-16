// -------------------------------------------------------------------------------------------------
// <copyright file="SerializationProvider.cs" company="Starion Group S.A.">
//
//   Copyright 2022-2025 Starion Group S.A.
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
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

    /// <summary>
    /// Delegate provider for the appropriate serialization method to serialize a <see cref="Type" />
    /// </summary>
    public static class SerializationProvider
    {
        private static readonly Dictionary<System.Type, Action<object, Utf8JsonWriter, SerializationModeKind, bool>> SerializerActionMap = new Dictionary<System.Type, Action<object, Utf8JsonWriter, SerializationModeKind, bool>>
        {
            { typeof(KerML.NET.DTO.Root.Annotations.AnnotatingElement), AnnotatingElementSerializer.Serialize },
            { typeof(KerML.NET.DTO.Root.Annotations.Annotation), AnnotationSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Associations.Association), AssociationSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Associations.AssociationStructure), AssociationStructureSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Behaviors.Behavior), BehaviorSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Connectors.BindingConnector), BindingConnectorSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Functions.BooleanExpression), BooleanExpressionSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Classes.Class), ClassSerializer.Serialize },
            { typeof(KerML.NET.DTO.Core.Classifiers.Classifier), ClassifierSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Expressions.CollectExpression), CollectExpressionSerializer.Serialize },
            { typeof(KerML.NET.DTO.Root.Annotations.Comment), CommentSerializer.Serialize },
            { typeof(KerML.NET.DTO.Core.Types.Conjugation), ConjugationSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Connectors.Connector), ConnectorSerializer.Serialize },
            { typeof(KerML.NET.DTO.Core.Features.CrossSubsetting), CrossSubsettingSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.DataTypes.DataType), DataTypeSerializer.Serialize },
            { typeof(KerML.NET.DTO.Root.Dependencies.Dependency), DependencySerializer.Serialize },
            { typeof(KerML.NET.DTO.Core.Types.Differencing), DifferencingSerializer.Serialize },
            { typeof(KerML.NET.DTO.Core.Types.Disjoining), DisjoiningSerializer.Serialize },
            { typeof(KerML.NET.DTO.Root.Annotations.Documentation), DocumentationSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Packages.ElementFilterMembership), ElementFilterMembershipSerializer.Serialize },
            { typeof(KerML.NET.DTO.Core.Features.EndFeatureMembership), EndFeatureMembershipSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Functions.Expression), ExpressionSerializer.Serialize },
            { typeof(KerML.NET.DTO.Core.Features.Feature), FeatureSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Expressions.FeatureChainExpression), FeatureChainExpressionSerializer.Serialize },
            { typeof(KerML.NET.DTO.Core.Features.FeatureChaining), FeatureChainingSerializer.Serialize },
            { typeof(KerML.NET.DTO.Core.Features.FeatureInverting), FeatureInvertingSerializer.Serialize },
            { typeof(KerML.NET.DTO.Core.Types.FeatureMembership), FeatureMembershipSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Expressions.FeatureReferenceExpression), FeatureReferenceExpressionSerializer.Serialize },
            { typeof(KerML.NET.DTO.Core.Features.FeatureTyping), FeatureTypingSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.FeatureValues.FeatureValue), FeatureValueSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Functions.Function), FunctionSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Expressions.IndexExpression), IndexExpressionSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Interactions.Interaction), InteractionSerializer.Serialize },
            { typeof(KerML.NET.DTO.Core.Types.Intersecting), IntersectingSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Functions.Invariant), InvariantSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Expressions.InvocationExpression), InvocationExpressionSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Interactions.ItemFeature), ItemFeatureSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Interactions.ItemFlow), ItemFlowSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Interactions.ItemFlowEnd), ItemFlowEndSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Packages.LibraryPackage), LibraryPackageSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Expressions.LiteralBoolean), LiteralBooleanSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Expressions.LiteralExpression), LiteralExpressionSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Expressions.LiteralInfinity), LiteralInfinitySerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Expressions.LiteralInteger), LiteralIntegerSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Expressions.LiteralRational), LiteralRationalSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Expressions.LiteralString), LiteralStringSerializer.Serialize },
            { typeof(KerML.NET.DTO.Root.Namespaces.Membership), MembershipSerializer.Serialize },
            { typeof(KerML.NET.DTO.Root.Namespaces.MembershipImport), MembershipImportSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Metadata.Metaclass), MetaclassSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Expressions.MetadataAccessExpression), MetadataAccessExpressionSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Metadata.MetadataFeature), MetadataFeatureSerializer.Serialize },
            { typeof(KerML.NET.DTO.Core.Types.Multiplicity), MultiplicitySerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Multiplicities.MultiplicityRange), MultiplicityRangeSerializer.Serialize },
            { typeof(KerML.NET.DTO.Root.Namespaces.Namespace), NamespaceSerializer.Serialize },
            { typeof(KerML.NET.DTO.Root.Namespaces.NamespaceImport), NamespaceImportSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Expressions.NullExpression), NullExpressionSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Expressions.OperatorExpression), OperatorExpressionSerializer.Serialize },
            { typeof(KerML.NET.DTO.Root.Namespaces.OwningMembership), OwningMembershipSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Packages.Package), PackageSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Behaviors.ParameterMembership), ParameterMembershipSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Functions.Predicate), PredicateSerializer.Serialize },
            { typeof(KerML.NET.DTO.Core.Features.Redefinition), RedefinitionSerializer.Serialize },
            { typeof(KerML.NET.DTO.Core.Features.ReferenceSubsetting), ReferenceSubsettingSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Functions.ResultExpressionMembership), ResultExpressionMembershipSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Functions.ReturnParameterMembership), ReturnParameterMembershipSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Expressions.SelectExpression), SelectExpressionSerializer.Serialize },
            { typeof(KerML.NET.DTO.Core.Types.Specialization), SpecializationSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Behaviors.Step), StepSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Structures.Structure), StructureSerializer.Serialize },
            { typeof(KerML.NET.DTO.Core.Classifiers.Subclassification), SubclassificationSerializer.Serialize },
            { typeof(KerML.NET.DTO.Core.Features.Subsetting), SubsettingSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Connectors.Succession), SuccessionSerializer.Serialize },
            { typeof(KerML.NET.DTO.Kernel.Interactions.SuccessionItemFlow), SuccessionItemFlowSerializer.Serialize },
            { typeof(KerML.NET.DTO.Root.Annotations.TextualRepresentation), TextualRepresentationSerializer.Serialize },
            { typeof(KerML.NET.DTO.Core.Types.Type), TypeSerializer.Serialize },
            { typeof(KerML.NET.DTO.Core.Features.TypeFeaturing), TypeFeaturingSerializer.Serialize },
            { typeof(KerML.NET.DTO.Core.Types.Unioning), UnioningSerializer.Serialize },
        };

        /// <summary>
        /// Provides the delegate <see cref="Action{object, Utf8JsonWriter, SerializationModeKind,bool}"/> for the
        /// <see cref="System.Type"/> that is to be serialized
        /// </summary>
        /// <param name="type">
        /// The subject <see cref="System.Type"/> that is to be serialized
        /// </param>
        /// <returns>
        /// A Delegate of <see cref="Action{object, Utf8JsonWriter, SerializationModeKind,bool}"/>
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// Thrown when the <see cref="System.Type"/> is not supported.
        /// </exception>
        public static Action<object, Utf8JsonWriter, SerializationModeKind, bool> Provide(System.Type type)
        {
            if (!SerializerActionMap.TryGetValue(type, out var action))
            {
                throw new NotSupportedException($"The {type.Name} is not supported by the SerializationProvider.");
            }

            return action;
        }

        /// <summary>
        /// Asserts whether the <paramref name="type"/> is supported by the provider
        /// </summary>
        /// <param name="typeName">
        /// The name of the subject <see cref="System.Type"/> for which support is asserted
        /// </param>
        /// <returns></returns>
        public static bool IsTypeSupported(System.Type type)
        {
            return SerializerActionMap.ContainsKey(type);
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
