// -------------------------------------------------------------------------------------------------
// <copyright file="Connector.cs" company="Starion Group S.A.">
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

namespace KerML.NET.DTO.Kernel.Connectors
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    using KerML.NET.DTO.Core.Features;
    using KerML.NET.DTO.Core.Types;
    using KerML.NET.DTO.Kernel.Associations;
    using KerML.NET.DTO.Root.Annotations;
    using KerML.NET.DTO.Root.Elements;
    using KerML.NET.DTO.Root.Namespaces;

    using KerML.NET.Decorators;
    using KerML.NET.Namespaces;
    using KerML.NET.Types;

    /// <summary>
    /// A Connector is a usage of Associations, with links restricted according to instances of the Type in
    /// which they are used (domain of the Connector). The associations of the Connector restrict what kinds
    /// of things might be linked. The Connector further restricts these links to be between values of
    /// Features on instances of its domain.
    /// </summary>
    [Class(xmiId: "f9615571-b95b-49e4-a007-0ce847e62696", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial class Connector : IConnector
    {
        /// <summary>
        /// Various alternative identifiers for this Element. Generally, these will be set by tools.
        /// </summary>
        [Property(xmiId: "dc13c4bf-26f8-44d3-b7e1-42e3c0d6508c", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [Implements(implementation: "IElement.AliasIds")]
        public List<string> AliasIds { get; set; } = [];

        /// <summary>
        /// The Associations that type the Connector.
        /// </summary>
        [Property(xmiId: "e15018cb-6a4b-48b2-b818-d21f0622c267", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "2dd9a8a5-bc46-421d-bc22-89f91e4b6ffe")]
        [Implements(implementation: "IConnector.Association")]
        public List<string> GetAssociation { get; internal set; }

        /// <summary>
        /// The Feature that are chained together to determine the values of this Feature, derived from the
        /// chainingFeatures of the ownedFeatureChainings of this Feature, in the same order. The values of a
        /// Feature with chainingFeatures are the same as values of the last Feature in the chain, which can be
        /// found by starting with the values of the first Feature (for each instance of the domain of the
        /// original Feature), then using each of those as domain instances to find the values of the second
        /// Feature in chainingFeatures, and so on, to values of the last Feature.
        /// </summary>
        [Property(xmiId: "cfa42988-6a5a-44e5-9d11-d9bec4fd5774", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [Implements(implementation: "IFeature.ChainingFeature")]
        public List<string> GetChainingFeature { get; internal set; }

        /// <summary>
        /// The endFeatures of a Connector, which redefine the endFeatures of the associations of the Connector.
        /// The connectorEnds determine via ReferenceSubsetting Relationships which Features are related by the
        /// Connector.
        /// </summary>
        [Property(xmiId: "cf2b6440-1987-451c-b676-389e1aaa7122", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "5979d447-4d72-4ffb-a569-ddbe6aacc8dd")]
        [Implements(implementation: "IConnector.ConnectorEnd")]
        public List<string> GetConnectorEnd { get; internal set; }

        /// <summary>
        /// The second chainingFeature of the crossedFeature of the ownedCrossSubsetting of this Feature, if it
        /// has one. Semantically, the values of the crossFeature of an end Feature must include all values of
        /// the end Feature obtained when navigating from values of the other end Features of the same
        /// owningType.
        /// </summary>
        [Property(xmiId: "28b33cd9-95b3-44d5-bf4a-8c796173f492", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [Implements(implementation: "IFeature.CrossFeature")]
        public string? GetCrossFeature { get; internal set; }

        /// <summary>
        /// The declared name of this Element.
        /// </summary>
        [Property(xmiId: "586e6993-dac0-4277-91ef-7a4c9788f61c", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [Implements(implementation: "IElement.DeclaredName")]
        public string? DeclaredName { get; set; }

        /// <summary>
        /// An optional alternative name for the Element that is intended to be shorter or in some way more
        /// succinct than its primary name. It may act as a modeler-specified identifier for the Element, though
        /// it is then the responsibility of the modeler to maintain the uniqueness of this identifier within a
        /// model or relative to some other context.
        /// </summary>
        [Property(xmiId: "95530b90-b70a-4b11-b334-1a5025d31570", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [Implements(implementation: "IElement.DeclaredShortName")]
        public string? DeclaredShortName { get; set; }

        /// <summary>
        /// The interpretations of a Type with differencingTypes are asserted to be those of the first of those
        /// Types, but not including those of the remaining Types. For example, a Classifier might be the
        /// difference of a Classifier for people and another for people of a particular nationality, leaving
        /// people who are not of that nationality. Similarly, a feature of people might be the difference
        /// between a feature for their children and a Classifier for people of a particular sex, identifying
        /// their children not of that sex (because the interpretations of the children Feature that identify
        /// those of that sex are also interpretations of the Classifier for that sex).
        /// </summary>
        [Property(xmiId: "7ffecf7a-110c-4ebe-a455-7d93bb939d2c", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [Implements(implementation: "IType.DifferencingType")]
        public List<string> GetDifferencingType { get; internal set; }

        /// <summary>
        /// The features of this Type that have a non-null direction.
        /// </summary>
        [Property(xmiId: "5b298b23-243e-4a34-afc9-15236eca08a8", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "42941304-02d9-4962-b118-95860c17236a")]
        [Implements(implementation: "IType.DirectedFeature")]
        public List<string> GetDirectedFeature { get; internal set; }

        /// <summary>
        /// Indicates how values of this Feature are determined or used (as specified for the
        /// FeatureDirectionKind).
        /// </summary>
        [Property(xmiId: "223be62d-afd1-4955-b258-78902bbc83e8", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [Implements(implementation: "IFeature.Direction")]
        public FeatureDirectionKind? Direction { get; set; }

        /// <summary>
        /// The Documentation owned by this Element.
        /// </summary>
        [Property(xmiId: "ac1fd098-f8ee-4db3-a7a6-5148e50e1ca7", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "79363c3a-95cb-4931-b243-549e858d6d77")]
        [SubsettedProperty(propertyName: "953bdc5d-4008-4e40-8e30-c760f7956254")]
        [Implements(implementation: "IElement.Documentation")]
        public List<string> GetDocumentation { get; internal set; }

        /// <summary>
        /// The globally unique identifier for this Element. This is intended to be set by tooling, and it must
        /// not change during the lifetime of the Element.
        /// </summary>
        [Property(xmiId: "0291c98d-3248-468c-8b9b-dab7d10284a6", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [Implements(implementation: "IElement.ElementId")]
        public string ElementId { get; set; }

        /// <summary>
        /// All features of this Type with isEnd = true.
        /// </summary>
        [Property(xmiId: "5979d447-4d72-4ffb-a569-ddbe6aacc8dd", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "42941304-02d9-4962-b118-95860c17236a")]
        [RedefinedByProperty("IConnector.ConnectorEnd")]
        [Implements(implementation: "IType.EndFeature")]
        List<string> IType.GetEndFeature => throw new NotSupportedException("IType.GetEndFeature has been redefined by IConnector.ConnectorEnd");

        /// <summary>
        /// The Type that is related to this Feature by an EndFeatureMembership in which the Feature is an
        /// ownedMemberFeature.
        /// </summary>
        [Property(xmiId: "da436a76-d30f-483b-94e9-da9e631dcf18", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "f685dfe3-4bd5-4bd3-a995-151ae1143ba7")]
        [SubsettedProperty(propertyName: "2a12de05-aa4b-4bc9-8eae-467829b67416")]
        [Implements(implementation: "IFeature.EndOwningType")]
        public string? GetEndOwningType { get; internal set; }

        /// <summary>
        /// The ownedMemberFeatures of the featureMemberships of this Type.
        /// </summary>
        [Property(xmiId: "42941304-02d9-4962-b118-95860c17236a", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "9098f21e-06d6-46cd-b1c6-3ccde8f5d8bb")]
        [Implements(implementation: "IType.Feature")]
        public List<string> GetFeature { get; internal set; }

        /// <summary>
        /// The FeatureMemberships for features of this Type, which include all ownedFeatureMemberships and
        /// those inheritedMemberships that are FeatureMemberships (but does not include any
        /// importedMemberships).
        /// </summary>
        [Property(xmiId: "c7ddb5de-07c8-4a60-ae17-11b745959f98", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [Implements(implementation: "IType.FeatureMembership")]
        public List<string> GetFeatureMembership { get; internal set; }

        /// <summary>
        /// The last of the chainingFeatures of this Feature, if it has any. Otherwise, this Feature itself.
        /// </summary>
        [Property(xmiId: "56724e7c-f67d-45cb-9015-3e5842420c83", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [Implements(implementation: "IFeature.FeatureTarget")]
        public string GetFeatureTarget { get; internal set; }

        /// <summary>
        /// Types that feature this Feature, such that any instance in the domain of the Feature must be
        /// classified by all of these Types, including at least all the featuringTypes of its typeFeaturings. 
        /// If the Feature is chained, then the featuringTypes of the first Feature in the chain are also
        /// featuringTypes of the chained Feature.
        /// </summary>
        [Property(xmiId: "c8436944-a5b8-41ca-80ef-195006f600a8", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [Implements(implementation: "IFeature.FeaturingType")]
        public List<string> GetFeaturingType { get; internal set; }

        /// <summary>
        /// The Memberships in this Namespace that result from the ownedImports of this Namespace.
        /// </summary>
        [Property(xmiId: "88e42ee1-8909-4ebd-b5df-cca0a4c44be4", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "596739a5-b42a-40d6-af0c-89cddf2d7768")]
        [Implements(implementation: "INamespace.ImportedMembership")]
        public List<string> GetImportedMembership { get; internal set; }

        /// <summary>
        /// All the memberFeatures of the inheritedMemberships of this Type that are FeatureMemberships.
        /// </summary>
        [Property(xmiId: "9bd843d3-b458-49a8-a591-7423e0d79935", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "42941304-02d9-4962-b118-95860c17236a")]
        [Implements(implementation: "IType.InheritedFeature")]
        public List<string> GetInheritedFeature { get; internal set; }

        /// <summary>
        /// All Memberships inherited by this Type via Specialization or Conjugation. These are included in the
        /// derived union for the memberships of the Type.
        /// </summary>
        [Property(xmiId: "743ca62c-f40b-47f9-8b18-1c0219ba96a1", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "596739a5-b42a-40d6-af0c-89cddf2d7768")]
        [Implements(implementation: "IType.InheritedMembership")]
        public List<string> GetInheritedMembership { get; internal set; }

        /// <summary>
        /// All features related to this Type by FeatureMemberships that have direction in or inout.
        /// </summary>
        [Property(xmiId: "76d0099a-2c42-442f-8fcf-c353da43fa2b", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "5b298b23-243e-4a34-afc9-15236eca08a8")]
        [Implements(implementation: "IType.Input")]
        public List<string> GetInput { get; internal set; }

        /// <summary>
        /// The interpretations of a Type with intersectingTypes are asserted to be those in common among the
        /// intersectingTypes, which are the Types derived from the intersectingType of the ownedIntersectings
        /// of this Type. For example, a Classifier might be an intersection of Classifiers for people of a
        /// particular sex and of a particular nationality. Similarly, a feature for people&#39;s children of a
        /// particular sex might be the intersection of a Feature for their children and a Classifier for people
        /// of that sex (because the interpretations of the children Feature that identify those of that sex are
        /// also interpretations of the Classifier for that sex).
        /// </summary>
        [Property(xmiId: "602fbd6c-9469-4f48-b529-907195ecb74b", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [Implements(implementation: "IType.IntersectingType")]
        public List<string> GetIntersectingType { get; internal set; }

        /// <summary>
        /// Indicates whether instances of this Type must also be instances of at least one of its specialized
        /// Types.
        /// </summary>
        [Property(xmiId: "8ba5f657-df28-48f4-ac52-7e154eb63b38", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: "false")]
        [Implements(implementation: "IType.IsAbstract")]
        public bool IsAbstract { get; set; }

        /// <summary>
        /// Whether the Feature is a composite feature of its featuringType. If so, the values of the Feature
        /// cannot exist after its featuring instance no longer does.
        /// </summary>
        [Property(xmiId: "5c603204-888c-435b-980f-5b21617df027", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: "false")]
        [Implements(implementation: "IFeature.IsComposite")]
        public bool IsComposite { get; set; }

        /// <summary>
        /// Indicates whether this Type has an ownedConjugator.
        /// </summary>
        [Property(xmiId: "d7e747db-632d-4f33-bf30-d5598b4bd5ba", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [Implements(implementation: "IType.IsConjugated")]
        public bool GetIsConjugated { get; internal set; }

        /// <summary>
        /// Whether the values of this Feature can always be computed from the values of other Features.
        /// </summary>
        [Property(xmiId: "fb250937-23af-4b97-afc5-aedb5f2734f6", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: "false")]
        [Implements(implementation: "IFeature.IsDerived")]
        public bool IsDerived { get; set; }

        /// <summary>
        /// Whether or not this Feature is an end Feature. An end Feature always has multiplicity 1, mapping
        /// each of its domain instances to a single co-domain instance. However, it may have a crossFeature, in
        /// which case values of the crossFeature must be the same as those found by navigation across instances
        /// of the owningType from values of other end Features to values of this Feature. If the owningType has
        /// n end Features, then the multiplicity, ordering, and uniqueness declared for the crossFeature of any
        /// one of these end Features constrains the cardinality, ordering, and uniqueness of the collection of
        /// values of that Feature reached by navigation when the values of the other n-1 end Features are held
        /// fixed.
        /// </summary>
        [Property(xmiId: "7106639b-7eaa-43c0-9f16-3ee22064145c", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: "false")]
        [Implements(implementation: "IFeature.IsEnd")]
        public bool IsEnd { get; set; }

        /// <summary>
        /// Whether this Relationship was generated by tooling to meet semantic rules, rather than being
        /// directly created by a modeler.
        /// </summary>
        [Property(xmiId: "75499eaa-ac5b-429c-ba15-f18886cd2817", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: "false")]
        [Implements(implementation: "IRelationship.IsImplied")]
        public bool IsImplied { get; set; }

        /// <summary>
        /// Whether all necessary implied Relationships have been included in the ownedRelationships of this
        /// Element. This property may be true, even if there are not actually any ownedRelationships with
        /// isImplied = true, meaning that no such Relationships are actually implied for this Element. However,
        /// if it is false, then ownedRelationships may not contain any implied Relationships. That is, either
        /// all required implied Relationships must be included, or none of them.
        /// </summary>
        [Property(xmiId: "a1b3b470-7e5e-41e7-9916-cead25ded142", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: "false")]
        [Implements(implementation: "IElement.IsImpliedIncluded")]
        public bool IsImpliedIncluded { get; set; }

        /// <summary>
        /// Whether this Element is contained in the ownership tree of a library model.
        /// </summary>
        [Property(xmiId: "0df33c44-6220-4d7e-aa32-b4ff84cfb627", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [Implements(implementation: "IElement.IsLibraryElement")]
        public bool GetIsLibraryElement { get; internal set; }

        /// <summary>
        /// Whether an order exists for the values of this Feature or not.
        /// </summary>
        [Property(xmiId: "64e2167d-05dc-49ab-a30b-befdbe17c100", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: "false")]
        [Implements(implementation: "IFeature.IsOrdered")]
        public bool IsOrdered { get; set; }

        /// <summary>
        /// Whether the values of this Feature are contained in the space and time of instances of the domain of
        /// the Feature and represent the same thing as those instances.
        /// </summary>
        [Property(xmiId: "ecaa2470-9287-4437-809a-38d344328298", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: "false")]
        [Implements(implementation: "IFeature.IsPortion")]
        public bool IsPortion { get; set; }

        /// <summary>
        /// Whether the values of this Feature can change over the lifetime of an instance of the domain.
        /// </summary>
        [Property(xmiId: "4aad3e9c-a931-4bef-9d81-a7650840ce2f", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: "false")]
        [Implements(implementation: "IFeature.IsReadOnly")]
        public bool IsReadOnly { get; set; }

        /// <summary>
        /// Whether all things that meet the classification conditions of this Type must be classified by the
        /// Type.(A Type gives conditions that must be met by whatever it classifies, but when isSufficient
        /// is false, things may meet those conditions but still not be classified by the Type. For example, a
        /// Type Car that is not sufficient could require everything it classifies to have four wheels, but not
        /// all four wheeled things would classify as cars. However, if the Type Car were sufficient, it would
        /// classify all four-wheeled things.)
        /// </summary>
        [Property(xmiId: "d77a343b-bf72-4b55-9419-c4973d9398d5", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: "false")]
        [Implements(implementation: "IType.IsSufficient")]
        public bool IsSufficient { get; set; }

        /// <summary>
        /// Whether or not values for this Feature must have no duplicates or not.
        /// </summary>
        [Property(xmiId: "a74e590e-8750-4378-a370-f6e196b41fc2", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: "true")]
        [Implements(implementation: "IFeature.IsUnique")]
        public bool IsUnique { get; set; }

        /// <summary>
        /// The set of all member Elements of this Namespace, which are the memberElements of all memberships of
        /// the Namespace.
        /// </summary>
        [Property(xmiId: "9098f21e-06d6-46cd-b1c6-3ccde8f5d8bb", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [Implements(implementation: "INamespace.Member")]
        public List<string> GetMember { get; internal set; }

        /// <summary>
        /// All Memberships in this Namespace, including (at least) the union of ownedMemberships and
        /// importedMemberships.
        /// </summary>
        [Property(xmiId: "596739a5-b42a-40d6-af0c-89cddf2d7768", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: true, isUnique: false, defaultValue: null)]
        [Implements(implementation: "INamespace.Membership")]
        public List<string> GetMembership { get; internal set; }

        /// <summary>
        /// An ownedMember of this Type that is a Multiplicity, which constraints the cardinality of the Type.
        /// If there is no such ownedMember, then the cardinality of this Type is constrained by all the
        /// Multiplicity constraints applicable to any direct supertypes.
        /// </summary>
        [Property(xmiId: "63fd5eb9-e073-41d0-9eb1-6a1a003047a9", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "e77d17fa-39f5-4493-b101-5630bea6df70")]
        [Implements(implementation: "IType.Multiplicity")]
        public string? GetMultiplicity { get; internal set; }

        /// <summary>
        /// The name to be used for this Element during name resolution within its owningNamespace. This is
        /// derived using the effectiveName() operation. By default, it is the same as the declaredName, but
        /// this is overridden for certain kinds of Elements to compute a name even when the declaredName is
        /// null.
        /// </summary>
        [Property(xmiId: "eefdd282-f78d-4133-9875-9017a9e584e1", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [Implements(implementation: "IElement.Name")]
        public string? GetName { get; internal set; }

        /// <summary>
        /// All features related to this Type by FeatureMemberships that have direction out or inout.
        /// </summary>
        [Property(xmiId: "f33f29d7-3216-4ab5-9298-4fd27cf976f2", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "5b298b23-243e-4a34-afc9-15236eca08a8")]
        [Implements(implementation: "IType.Output")]
        public List<string> GetOutput { get; internal set; }

        /// <summary>
        /// The ownedRelationships of this Element that are Annotations, for which this Element is the
        /// annotatedElement.
        /// </summary>
        [Property(xmiId: "8cd0b6e4-8a21-48e4-bb7c-4c249a352d01", aggregation: AggregationKind.Composite, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "9a0cb697-5a6b-4fa8-806e-ea6c79d5ada9")]
        [SubsettedProperty(propertyName: "4ad2615b-7b77-4084-bd3e-bd0f31cc54e1")]
        [Implements(implementation: "IElement.OwnedAnnotation")]
        public List<string> GetOwnedAnnotation { get; internal set; }

        /// <summary>
        /// A Conjugation owned by this Type for which the Type is the originalType.
        /// </summary>
        [Property(xmiId: "ccf5f8be-87c6-4779-8d89-838dee93b54a", aggregation: AggregationKind.Composite, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "6191d353-5d59-4470-a725-58c20f8c845f")]
        [SubsettedProperty(propertyName: "9a0cb697-5a6b-4fa8-806e-ea6c79d5ada9")]
        [Implements(implementation: "IType.OwnedConjugator")]
        public string? GetOwnedConjugator { get; internal set; }

        /// <summary>
        /// The one ownedSubsetting of this Feature, if any, that is a CrossSubsetting}, for which the Feature
        /// is the crossingFeature.
        /// </summary>
        [Property(xmiId: "a5a5686b-e149-4693-bba1-a8303d468a23", aggregation: AggregationKind.Composite, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "24acf8ee-a922-4e2d-b75f-ea635fac57e8")]
        [Implements(implementation: "IFeature.OwnedCrossSubsetting")]
        public string? GetOwnedCrossSubsetting { get; internal set; }

        /// <summary>
        /// The ownedRelationships of this Type that are Differencings, having this Type as their
        /// typeDifferenced.
        /// </summary>
        [Property(xmiId: "6de3e4fa-d030-4056-a604-5a08af796fe4", aggregation: AggregationKind.Composite, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "fd194ed0-9544-4215-b3df-64c5423ec874")]
        [SubsettedProperty(propertyName: "9a0cb697-5a6b-4fa8-806e-ea6c79d5ada9")]
        [Implements(implementation: "IType.OwnedDifferencing")]
        public List<string> GetOwnedDifferencing { get; internal set; }

        /// <summary>
        /// The ownedRelationships of this Type that are Disjoinings, for which the Type is the typeDisjoined
        /// Type.
        /// </summary>
        [Property(xmiId: "37d00410-6821-48b3-a834-6183305addae", aggregation: AggregationKind.Composite, lowerValue: 0, upperValue: int.MaxValue, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "9a0cb697-5a6b-4fa8-806e-ea6c79d5ada9")]
        [SubsettedProperty(propertyName: "b8d8888f-330c-4b04-ba03-6902de88586e")]
        [Implements(implementation: "IType.OwnedDisjoining")]
        public List<string> GetOwnedDisjoining { get; internal set; }

        /// <summary>
        /// The Elements owned by this Element, derived as the ownedRelatedElements of the ownedRelationships of
        /// this Element.
        /// </summary>
        [Property(xmiId: "953bdc5d-4008-4e40-8e30-c760f7956254", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [Implements(implementation: "IElement.OwnedElement")]
        public List<string> GetOwnedElement { get; internal set; }

        /// <summary>
        /// All endFeatures of this Type that are ownedFeatures.
        /// </summary>
        [Property(xmiId: "c4743769-27b0-4bec-a7ef-b187bc40ea4f", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "5979d447-4d72-4ffb-a569-ddbe6aacc8dd")]
        [SubsettedProperty(propertyName: "f062fa83-0335-40e0-8652-a22e6a8b3b11")]
        [Implements(implementation: "IType.OwnedEndFeature")]
        public List<string> GetOwnedEndFeature { get; internal set; }

        /// <summary>
        /// The ownedMemberFeatures of the ownedFeatureMemberships of this Type.
        /// </summary>
        [Property(xmiId: "f062fa83-0335-40e0-8652-a22e6a8b3b11", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "e77d17fa-39f5-4493-b101-5630bea6df70")]
        [Implements(implementation: "IType.OwnedFeature")]
        public List<string> GetOwnedFeature { get; internal set; }

        /// <summary>
        /// The ownedRelationships of this Feature that are FeatureChainings, for which the Feature will be the
        /// featureChained.
        /// </summary>
        [Property(xmiId: "92df3ab0-2f9a-4c05-9606-1be680a6f67a", aggregation: AggregationKind.Composite, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "9a0cb697-5a6b-4fa8-806e-ea6c79d5ada9")]
        [SubsettedProperty(propertyName: "fd194ed0-9544-4215-b3df-64c5423ec874")]
        [Implements(implementation: "IFeature.OwnedFeatureChaining")]
        public List<string> GetOwnedFeatureChaining { get; internal set; }

        /// <summary>
        /// The ownedRelationships of this Feature that are FeatureInvertings and for which the Feature is the
        /// featureInverted.
        /// </summary>
        [Property(xmiId: "e9b3d5a9-b17d-42fc-88ef-c71f5857fcd6", aggregation: AggregationKind.Composite, lowerValue: 0, upperValue: int.MaxValue, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "6fb1d0b2-adeb-43d6-9c2e-98697718f9b9")]
        [SubsettedProperty(propertyName: "9a0cb697-5a6b-4fa8-806e-ea6c79d5ada9")]
        [Implements(implementation: "IFeature.OwnedFeatureInverting")]
        public List<string> GetOwnedFeatureInverting { get; internal set; }

        /// <summary>
        /// The ownedMemberships of this Type that are FeatureMemberships, for which the Type is the owningType.
        /// Each such FeatureMembership identifies an ownedFeature of the Type.
        /// </summary>
        [Property(xmiId: "dc592816-92e5-4085-b386-e50a8bbdf926", aggregation: AggregationKind.Composite, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "fad0c25d-2a44-4e7a-9b06-bae16320cb4e")]
        [SubsettedProperty(propertyName: "c7ddb5de-07c8-4a60-ae17-11b745959f98")]
        [SubsettedProperty(propertyName: "50ef422c-01b0-4c96-8fcf-d091fc26655a")]
        [Implements(implementation: "IType.OwnedFeatureMembership")]
        public List<string> GetOwnedFeatureMembership { get; internal set; }

        /// <summary>
        /// The ownedRelationships of this Namespace that are Imports, for which the Namespace is the
        /// importOwningNamespace.
        /// </summary>
        [Property(xmiId: "d382696c-18ad-4754-8872-cf777875c8c6", aggregation: AggregationKind.Composite, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "9a0cb697-5a6b-4fa8-806e-ea6c79d5ada9")]
        [SubsettedProperty(propertyName: "fd194ed0-9544-4215-b3df-64c5423ec874")]
        [Implements(implementation: "INamespace.OwnedImport")]
        public List<string> GetOwnedImport { get; internal set; }

        /// <summary>
        /// The ownedRelationships of this Type that are Intersectings, have the Type as their typeIntersected.
        /// </summary>
        [Property(xmiId: "24d357f9-3e15-4f53-90b2-f3a2c4b79039", aggregation: AggregationKind.Composite, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "fd194ed0-9544-4215-b3df-64c5423ec874")]
        [SubsettedProperty(propertyName: "9a0cb697-5a6b-4fa8-806e-ea6c79d5ada9")]
        [Implements(implementation: "IType.OwnedIntersecting")]
        public List<string> GetOwnedIntersecting { get; internal set; }

        /// <summary>
        /// The owned members of this Namespace, which are the <cpde>ownedMemberElements of the ownedMemberships
        /// of the Namespace.</cpde>
        /// </summary>
        [Property(xmiId: "e77d17fa-39f5-4493-b101-5630bea6df70", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "9098f21e-06d6-46cd-b1c6-3ccde8f5d8bb")]
        [Implements(implementation: "INamespace.OwnedMember")]
        public List<string> GetOwnedMember { get; internal set; }

        /// <summary>
        /// The ownedRelationships of this Namespace that are Memberships, for which the Namespace is the
        /// membershipOwningNamespace.
        /// </summary>
        [Property(xmiId: "fad0c25d-2a44-4e7a-9b06-bae16320cb4e", aggregation: AggregationKind.Composite, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "596739a5-b42a-40d6-af0c-89cddf2d7768")]
        [SubsettedProperty(propertyName: "fd194ed0-9544-4215-b3df-64c5423ec874")]
        [SubsettedProperty(propertyName: "9a0cb697-5a6b-4fa8-806e-ea6c79d5ada9")]
        [Implements(implementation: "INamespace.OwnedMembership")]
        public List<string> GetOwnedMembership { get; internal set; }

        /// <summary>
        /// The ownedSubsettings of this Feature that are Redefinitions, for which the Feature is the
        /// redefiningFeature.
        /// </summary>
        [Property(xmiId: "82497c64-3237-4c23-bb78-9bb9d1eaf8f0", aggregation: AggregationKind.Composite, lowerValue: 0, upperValue: int.MaxValue, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "24acf8ee-a922-4e2d-b75f-ea635fac57e8")]
        [Implements(implementation: "IFeature.OwnedRedefinition")]
        public List<string> GetOwnedRedefinition { get; internal set; }

        /// <summary>
        /// The one ownedSubsetting of this Feature, if any, that is a ReferenceSubsetting, for which the
        /// Feature is the referencingFeature.
        /// </summary>
        [Property(xmiId: "b0433961-5933-432e-ac02-c6f2f849e579", aggregation: AggregationKind.Composite, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "24acf8ee-a922-4e2d-b75f-ea635fac57e8")]
        [Implements(implementation: "IFeature.OwnedReferenceSubsetting")]
        public string? GetOwnedReferenceSubsetting { get; internal set; }

        /// <summary>
        /// The relatedElements of this Relationship that are owned by the Relationship.
        /// </summary>
        [Property(xmiId: "27fc72b3-57ec-4aa5-a656-1e902c5d768a", aggregation: AggregationKind.Composite, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "0d55f45c-0032-4618-9131-61ed58c3b8e2")]
        [Implements(implementation: "IRelationship.OwnedRelatedElement")]
        public List<string> OwnedRelatedElement { get; set; } = [];

        /// <summary>
        /// The Relationships for which this Element is the owningRelatedElement.
        /// </summary>
        [Property(xmiId: "9a0cb697-5a6b-4fa8-806e-ea6c79d5ada9", aggregation: AggregationKind.Composite, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "3e98010e-1179-4758-8c95-8354c83f7fea")]
        [Implements(implementation: "IElement.OwnedRelationship")]
        public List<string> OwnedRelationship { get; set; } = [];

        /// <summary>
        /// The ownedRelationships of this Type that are Specializations, for which the Type is the specific
        /// Type.
        /// </summary>
        [Property(xmiId: "7746c947-3bd4-4cb9-98b7-cc9dddda5261", aggregation: AggregationKind.Composite, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "9a0cb697-5a6b-4fa8-806e-ea6c79d5ada9")]
        [SubsettedProperty(propertyName: "99b13dd4-d587-432b-aba9-f7fa57b7ad99")]
        [Implements(implementation: "IType.OwnedSpecialization")]
        public List<string> GetOwnedSpecialization { get; internal set; }

        /// <summary>
        /// The ownedSpecializations of this Feature that are Subsettings, for which the Feature is the
        /// subsettingFeature.
        /// </summary>
        [Property(xmiId: "24acf8ee-a922-4e2d-b75f-ea635fac57e8", aggregation: AggregationKind.Composite, lowerValue: 0, upperValue: int.MaxValue, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "7746c947-3bd4-4cb9-98b7-cc9dddda5261")]
        [SubsettedProperty(propertyName: "6d6998e4-39fd-4d6d-b2c3-96c1d403f6fe")]
        [Implements(implementation: "IFeature.OwnedSubsetting")]
        public List<string> GetOwnedSubsetting { get; internal set; }

        /// <summary>
        /// The ownedRelationships of this Feature that are TypeFeaturings and for which the Feature is the
        /// featureOfType.
        /// </summary>
        [Property(xmiId: "a2cb0eed-78bd-4eca-aa1e-78ca8d8e9868", aggregation: AggregationKind.Composite, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "147fe6bb-e3ac-450b-8bc0-24c0406ba49b")]
        [SubsettedProperty(propertyName: "9a0cb697-5a6b-4fa8-806e-ea6c79d5ada9")]
        [Implements(implementation: "IFeature.OwnedTypeFeaturing")]
        public List<string> GetOwnedTypeFeaturing { get; internal set; }

        /// <summary>
        /// The ownedSpecializations of this Feature that are FeatureTypings, for which the Feature is the
        /// typedFeature.
        /// </summary>
        [Property(xmiId: "ba9a36c8-55d6-422c-a252-f2c24ba2c4bc", aggregation: AggregationKind.Composite, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "7746c947-3bd4-4cb9-98b7-cc9dddda5261")]
        [SubsettedProperty(propertyName: "127026ea-deda-4910-8e9f-9bce075926c2")]
        [Implements(implementation: "IFeature.OwnedTyping")]
        public List<string> GetOwnedTyping { get; internal set; }

        /// <summary>
        /// The ownedRelationships of this Type that are Unionings, having the Type as their typeUnioned.
        /// </summary>
        [Property(xmiId: "eccbd0e6-244e-4264-9654-eb72d0a0c1c3", aggregation: AggregationKind.Composite, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "9a0cb697-5a6b-4fa8-806e-ea6c79d5ada9")]
        [SubsettedProperty(propertyName: "fd194ed0-9544-4215-b3df-64c5423ec874")]
        [Implements(implementation: "IType.OwnedUnioning")]
        public List<string> GetOwnedUnioning { get; internal set; }

        /// <summary>
        /// The owner of this Element, derived as the owningRelatedElement of the owningRelationship of this
        /// Element, if any.
        /// </summary>
        [Property(xmiId: "62034bc0-cc6e-41a0-b2b7-09f6bb604c5e", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [Implements(implementation: "IElement.Owner")]
        public string? GetOwner { get; internal set; }

        /// <summary>
        /// The FeatureMembership that owns this Feature as an ownedMemberFeature, determining its owningType.
        /// </summary>
        [Property(xmiId: "b79a7d91-99ab-4372-8103-af57f85ad3a1", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "bffacdf5-2f73-400c-b0d6-0aaacb177f4f")]
        [SubsettedProperty(propertyName: "8763ebb8-6a3d-45b3-b628-966dc39fbb40")]
        [Implements(implementation: "IFeature.OwningFeatureMembership")]
        public string? GetOwningFeatureMembership { get; internal set; }

        /// <summary>
        /// The owningRelationship of this Element, if that Relationship is a Membership.
        /// </summary>
        [Property(xmiId: "8763ebb8-6a3d-45b3-b628-966dc39fbb40", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "02e7bbf3-5c7d-4606-909b-42e10233ebca")]
        [SubsettedProperty(propertyName: "0c64cbc0-cb58-4982-b1ac-d09f6ac8d497")]
        [Implements(implementation: "IElement.OwningMembership")]
        public string? GetOwningMembership { get; internal set; }

        /// <summary>
        /// The Namespace that owns this Element, which is the membershipOwningNamespace of the owningMembership
        /// of this Element, if any.
        /// </summary>
        [Property(xmiId: "934985ee-d247-42fc-8106-101a5b3ebacb", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "1e7fdba0-a195-4da8-a935-bd8e7b72a7d2")]
        [Implements(implementation: "IElement.OwningNamespace")]
        public string? GetOwningNamespace { get; internal set; }

        /// <summary>
        /// The relatedElement of this Relationship that owns the Relationship, if any.
        /// </summary>
        [Property(xmiId: "c81d146c-d738-40a0-ab80-8526beac3673", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "0d55f45c-0032-4618-9131-61ed58c3b8e2")]
        [Implements(implementation: "IRelationship.OwningRelatedElement")]
        public string? OwningRelatedElement { get; set; }

        /// <summary>
        /// The Relationship for which this Element is an ownedRelatedElement, if any.
        /// </summary>
        [Property(xmiId: "0c64cbc0-cb58-4982-b1ac-d09f6ac8d497", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "3e98010e-1179-4758-8c95-8354c83f7fea")]
        [Implements(implementation: "IElement.OwningRelationship")]
        public string? OwningRelationship { get; set; }

        /// <summary>
        /// The Type that is the owningType of the owningFeatureMembership of this Feature.
        /// </summary>
        [Property(xmiId: "2a12de05-aa4b-4bc9-8eae-467829b67416", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "c8436944-a5b8-41ca-80ef-195006f600a8")]
        [SubsettedProperty(propertyName: "a73b8151-30bf-4f8d-9283-34cdea4ac29b")]
        [SubsettedProperty(propertyName: "934985ee-d247-42fc-8106-101a5b3ebacb")]
        [Implements(implementation: "IFeature.OwningType")]
        public string? GetOwningType { get; internal set; }

        /// <summary>
        /// The full ownership-qualified name of this Element, represented in a form that is valid according to
        /// the KerML textual concrete syntax for qualified names (including use of unrestricted name notation
        /// and escaped characters, as necessary). The qualifiedName is null if this Element has no
        /// owningNamespace or if there is not a complete ownership chain of named Namespaces from a root
        /// Namespace to this Element.
        /// </summary>
        [Property(xmiId: "e6d23414-9ac3-4a5c-9546-250118c85114", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [Implements(implementation: "IElement.QualifiedName")]
        public string? GetQualifiedName { get; internal set; }

        /// <summary>
        /// The Elements that are related by this Relationship, derived as the union of the source and target
        /// Elements of the Relationship.
        /// </summary>
        [Property(xmiId: "0d55f45c-0032-4618-9131-61ed58c3b8e2", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedByProperty("IConnector.RelatedFeature")]
        [Implements(implementation: "IRelationship.RelatedElement")]
        List<string> IRelationship.GetRelatedElement => throw new NotSupportedException("IRelationship.GetRelatedElement has been redefined by IConnector.RelatedFeature");

        /// <summary>
        /// The Features that are related by this Connector considered as a Relationship and that restrict the
        /// links it identifies, given by the referenced Features of the connectorEnds of the Connector.
        /// </summary>
        [Property(xmiId: "5d81451f-480e-49d7-953a-4b441caf76d4", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "0d55f45c-0032-4618-9131-61ed58c3b8e2")]
        [Implements(implementation: "IConnector.RelatedFeature")]
        public List<string> GetRelatedFeature { get; internal set; }

        /// <summary>
        /// The short name to be used for this Element during name resolution within its owningNamespace. This
        /// is derived using the effectiveShortName() operation. By default, it is the same as the
        /// declaredShortName, but this is overridden for certain kinds of Elements to compute a shortName even
        /// when the declaredName is null.
        /// </summary>
        [Property(xmiId: "64f637ef-310f-4398-8601-a38a16591e10", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [Implements(implementation: "IElement.ShortName")]
        public string? GetShortName { get; internal set; }

        /// <summary>
        /// The relatedElements from which this Relationship is considered to be directed.
        /// </summary>
        [Property(xmiId: "cd83f43d-3885-4b41-8f03-f02255e6a5da", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "0d55f45c-0032-4618-9131-61ed58c3b8e2")]
        [RedefinedByProperty("IConnector.SourceFeature")]
        [Implements(implementation: "IRelationship.Source")]
        List<string> IRelationship.Source
        {
            get => throw new NotSupportedException("IRelationship.Source has been redefined by IConnector.SourceFeature");
            set => throw new NotSupportedException("IRelationship.Source has been redefined by IConnector.SourceFeature");
        }


        /// <summary>
        /// The source relatedFeature for this Connector. It is the first relatedFeature.
        /// </summary>
        [Property(xmiId: "0cad7969-0d12-4a35-8473-1b1da503eaf0", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "5d81451f-480e-49d7-953a-4b441caf76d4")]
        [RedefinedProperty(propertyName: "cd83f43d-3885-4b41-8f03-f02255e6a5da")]
        [Implements(implementation: "IConnector.SourceFeature")]
        public string? GetSourceFeature { get; internal set; }

        /// <summary>
        /// The relatedElements to which this Relationship is considered to be directed.
        /// </summary>
        [Property(xmiId: "4c7374f5-78f8-42ab-ae42-672ad9c80902", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "0d55f45c-0032-4618-9131-61ed58c3b8e2")]
        [RedefinedByProperty("IConnector.TargetFeature")]
        [Implements(implementation: "IRelationship.Target")]
        List<string> IRelationship.Target
        {
            get => throw new NotSupportedException("IRelationship.Target has been redefined by IConnector.TargetFeature");
            set => throw new NotSupportedException("IRelationship.Target has been redefined by IConnector.TargetFeature");
        }


        /// <summary>
        /// The target relatedFeatures for this Connector. This includes all the relatedFeatures other than the
        /// sourceFeature.
        /// </summary>
        [Property(xmiId: "fc72dff0-56b8-4406-9d40-1bd319e54ce1", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "5d81451f-480e-49d7-953a-4b441caf76d4")]
        [RedefinedProperty(propertyName: "4c7374f5-78f8-42ab-ae42-672ad9c80902")]
        [Implements(implementation: "IConnector.TargetFeature")]
        public List<string> GetTargetFeature { get; internal set; }

        /// <summary>
        /// The TextualRepresentations that annotate this Element.
        /// </summary>
        [Property(xmiId: "b8f93a3a-579d-4404-a560-2d9e3d40ff45", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "79363c3a-95cb-4931-b243-549e858d6d77")]
        [SubsettedProperty(propertyName: "953bdc5d-4008-4e40-8e30-c760f7956254")]
        [Implements(implementation: "IElement.TextualRepresentation")]
        public List<string> GetTextualRepresentation { get; internal set; }

        /// <summary>
        /// Types that restrict the values of this Feature, such that the values must be instances of all the
        /// types. The types of a Feature are derived from its typings and the types of its subsettings. If the
        /// Feature is chained, then the types of the last Feature in the chain are also types of the chained
        /// Feature.
        /// </summary>
        [Property(xmiId: "2dd9a8a5-bc46-421d-bc22-89f91e4b6ffe", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedByProperty("IConnector.Association")]
        [Implements(implementation: "IFeature.Type")]
        List<string> IFeature.GetType => throw new NotSupportedException("IFeature.GetType has been redefined by IConnector.Association");

        /// <summary>
        /// The interpretations of a Type with unioningTypes are asserted to be the same as those of all the
        /// unioningTypes together, which are the Types derived from the unioningType of the ownedUnionings of
        /// this Type. For example, a Classifier for people might be the union of Classifiers for all the sexes.
        /// Similarly, a feature for people&#39;s children might be the union of features dividing them in the
        /// same ways as people in general.
        /// </summary>
        [Property(xmiId: "1ff97b5a-c841-498a-a4a0-b72de63e73e4", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [Implements(implementation: "IType.UnioningType")]
        public List<string> GetUnioningType { get; internal set; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
