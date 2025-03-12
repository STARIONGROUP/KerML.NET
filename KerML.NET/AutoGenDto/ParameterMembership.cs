// -------------------------------------------------------------------------------------------------
// <copyright file="ParameterMembership.cs" company="Starion Group S.A.">
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

namespace KerML.NET.DTO.Kernel.Behaviors
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    using KerML.NET.DTO.Core.Features;
    using KerML.NET.DTO.Core.Types;
    using KerML.NET.DTO.Root.Annotations;
    using KerML.NET.DTO.Root.Elements;
    using KerML.NET.DTO.Root.Namespaces;

    using KerML.NET.Decorators;
    using KerML.NET.Namespaces;
    using KerML.NET.Types;

    /// <summary>
    /// A ParameterMembership is a FeatureMembership that identifies its memberFeature as a parameter, which
    /// is always owned, and must have a direction. A ParameterMembership must be owned by a Behavior or a
    /// Step.
    /// </summary>
    [Class(xmiId: "eb1dad4c-855f-4154-b5f3-bd7d07932a0c", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial class ParameterMembership : IParameterMembership
    {
        /// <summary>
        /// Various alternative identifiers for this Element. Generally, these will be set by tools.
        /// </summary>
        [Property(xmiId: "dc13c4bf-26f8-44d3-b7e1-42e3c0d6508c", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [Implements(implementation: "IElement.AliasIds")]
        public List<string> AliasIds { get; set; } = [];

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
        /// The Feature that is featured by the featuringType.
        /// </summary>
        [Property(xmiId: "e3585351-105e-4e50-9547-2974f25f09a4", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "0d55f45c-0032-4618-9131-61ed58c3b8e2")]
        [RedefinedByProperty("IFeatureMembership.OwnedMemberFeature")]
        [Implements(implementation: "IFeaturing.Feature")]
        string IFeaturing.Feature
        {
            get => throw new NotSupportedException("IFeaturing.Feature has been redefined by IFeatureMembership.OwnedMemberFeature");
            set => throw new NotSupportedException("IFeaturing.Feature has been redefined by IFeatureMembership.OwnedMemberFeature");
        }


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
        /// The Element that becomes a member of the membershipOwningNamespace due to this Membership.
        /// </summary>
        [Property(xmiId: "ea691af8-fe94-4d70-8a6f-7433b40c3398", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "4c7374f5-78f8-42ab-ae42-672ad9c80902")]
        [RedefinedByProperty("IOwningMembership.OwnedMemberElement")]
        [Implements(implementation: "IMembership.MemberElement")]
        string IMembership.MemberElement
        {
            get => throw new NotSupportedException("IMembership.MemberElement has been redefined by IOwningMembership.OwnedMemberElement");
            set => throw new NotSupportedException("IMembership.MemberElement has been redefined by IOwningMembership.OwnedMemberElement");
        }


        /// <summary>
        /// The elementId of the memberElement.
        /// </summary>
        [Property(xmiId: "867c63ec-3922-4eaa-8c78-47ca3f9d04b8", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedByProperty("IOwningMembership.OwnedMemberElementId")]
        [Implements(implementation: "IMembership.MemberElementId")]
        string IMembership.GetMemberElementId => throw new NotSupportedException("IMembership.GetMemberElementId has been redefined by IOwningMembership.OwnedMemberElementId");

        /// <summary>
        /// The name of the memberElement relative to the membershipOwningNamespace.
        /// </summary>
        [Property(xmiId: "edd22f54-2750-4e4f-bdf3-96edc70b3ca1", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedByProperty("IOwningMembership.OwnedMemberName")]
        [Implements(implementation: "IMembership.MemberName")]
        string? IMembership.MemberName
        {
            get => throw new NotSupportedException("IMembership.MemberName has been redefined by IOwningMembership.OwnedMemberName");
            set => throw new NotSupportedException("IMembership.MemberName has been redefined by IOwningMembership.OwnedMemberName");
        }


        /// <summary>
        /// The Namespace of which the memberElement becomes a member due to this Membership.
        /// </summary>
        [Property(xmiId: "67aded9a-ae8a-4191-8053-2df04cce9c8c", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "84afb4bc-eed8-491b-bcf4-169870b700a8")]
        [SubsettedProperty(propertyName: "c81d146c-d738-40a0-ab80-8526beac3673")]
        [RedefinedProperty(propertyName: "cd83f43d-3885-4b41-8f03-f02255e6a5da")]
        [RedefinedByProperty("IFeatureMembership.OwningType")]
        [Implements(implementation: "IMembership.MembershipOwningNamespace")]
        string IMembership.GetMembershipOwningNamespace => throw new NotSupportedException("IMembership.GetMembershipOwningNamespace has been redefined by IFeatureMembership.OwningType");

        /// <summary>
        /// The short name of the memberElement relative to the membershipOwningNamespace.
        /// </summary>
        [Property(xmiId: "d9a35a1e-b312-4566-a773-c1a0897341c8", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedByProperty("IOwningMembership.OwnedMemberShortName")]
        [Implements(implementation: "IMembership.MemberShortName")]
        string? IMembership.MemberShortName
        {
            get => throw new NotSupportedException("IMembership.MemberShortName has been redefined by IOwningMembership.OwnedMemberShortName");
            set => throw new NotSupportedException("IMembership.MemberShortName has been redefined by IOwningMembership.OwnedMemberShortName");
        }


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
        /// The ownedRelationships of this Element that are Annotations, for which this Element is the
        /// annotatedElement.
        /// </summary>
        [Property(xmiId: "8cd0b6e4-8a21-48e4-bb7c-4c249a352d01", aggregation: AggregationKind.Composite, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "9a0cb697-5a6b-4fa8-806e-ea6c79d5ada9")]
        [SubsettedProperty(propertyName: "4ad2615b-7b77-4084-bd3e-bd0f31cc54e1")]
        [Implements(implementation: "IElement.OwnedAnnotation")]
        public List<string> GetOwnedAnnotation { get; internal set; }

        /// <summary>
        /// The Elements owned by this Element, derived as the ownedRelatedElements of the ownedRelationships of
        /// this Element.
        /// </summary>
        [Property(xmiId: "953bdc5d-4008-4e40-8e30-c760f7956254", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [Implements(implementation: "IElement.OwnedElement")]
        public List<string> GetOwnedElement { get; internal set; }

        /// <summary>
        /// The Element that becomes an ownedMember of the membershipOwningNamespace due to this
        /// OwningMembership.
        /// </summary>
        [Property(xmiId: "c23da327-2bed-4f05-9fa2-9749097c6eca", aggregation: AggregationKind.Composite, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "27fc72b3-57ec-4aa5-a656-1e902c5d768a")]
        [RedefinedProperty(propertyName: "ea691af8-fe94-4d70-8a6f-7433b40c3398")]
        [RedefinedByProperty("IFeatureMembership.OwnedMemberFeature")]
        [Implements(implementation: "IOwningMembership.OwnedMemberElement")]
        string IOwningMembership.GetOwnedMemberElement => throw new NotSupportedException("IOwningMembership.GetOwnedMemberElement has been redefined by IFeatureMembership.OwnedMemberFeature");

        /// <summary>
        /// The elementId of the ownedMemberElement.
        /// </summary>
        [Property(xmiId: "46b967c5-57c8-42bd-a2bb-ff9293739afc", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "867c63ec-3922-4eaa-8c78-47ca3f9d04b8")]
        [Implements(implementation: "IOwningMembership.OwnedMemberElementId")]
        public string GetOwnedMemberElementId { get; internal set; }

        /// <summary>
        /// The Feature that this FeatureMembership relates to its owningType, making it an ownedFeature of the
        /// owningType.
        /// </summary>
        [Property(xmiId: "6bf83eae-2d89-4ea9-8c7b-92d8ef26bfaa", aggregation: AggregationKind.Composite, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "e3585351-105e-4e50-9547-2974f25f09a4")]
        [RedefinedProperty(propertyName: "c23da327-2bed-4f05-9fa2-9749097c6eca")]
        [RedefinedByProperty("IParameterMembership.OwnedMemberParameter")]
        [Implements(implementation: "IFeatureMembership.OwnedMemberFeature")]
        string IFeatureMembership.GetOwnedMemberFeature => throw new NotSupportedException("IFeatureMembership.GetOwnedMemberFeature has been redefined by IParameterMembership.OwnedMemberParameter");

        /// <summary>
        /// The name of the ownedMemberElement.
        /// </summary>
        [Property(xmiId: "ad6df655-1655-4769-ae6d-ddc1ad53a4bd", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "edd22f54-2750-4e4f-bdf3-96edc70b3ca1")]
        [Implements(implementation: "IOwningMembership.OwnedMemberName")]
        public string? GetOwnedMemberName { get; internal set; }

        /// <summary>
        /// The Feature that is identified as a parameter by this ParameterMembership.
        /// </summary>
        [Property(xmiId: "0a469064-fb44-493a-94be-d3a43d23f5f8", aggregation: AggregationKind.Composite, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "6bf83eae-2d89-4ea9-8c7b-92d8ef26bfaa")]
        [Implements(implementation: "IParameterMembership.OwnedMemberParameter")]
        public string GetOwnedMemberParameter { get; internal set; }

        /// <summary>
        /// The shortName of the ownedMemberElement.
        /// </summary>
        [Property(xmiId: "cf030abd-08d4-4739-9891-42b0a540203a", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "d9a35a1e-b312-4566-a773-c1a0897341c8")]
        [Implements(implementation: "IOwningMembership.OwnedMemberShortName")]
        public string? GetOwnedMemberShortName { get; internal set; }

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
        /// The owner of this Element, derived as the owningRelatedElement of the owningRelationship of this
        /// Element, if any.
        /// </summary>
        [Property(xmiId: "62034bc0-cc6e-41a0-b2b7-09f6bb604c5e", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [Implements(implementation: "IElement.Owner")]
        public string? GetOwner { get; internal set; }

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
        /// The Type that owns this FeatureMembership.
        /// </summary>
        [Property(xmiId: "b698b27c-2d6a-4cc5-a202-ab3d3cb5ec2a", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "2ef320b9-d900-484f-ab11-5aa59e441577")]
        [RedefinedProperty(propertyName: "35ddd42a-b8a5-4ea6-b2d1-ab7d0a827a00")]
        [RedefinedProperty(propertyName: "67aded9a-ae8a-4191-8053-2df04cce9c8c")]
        [Implements(implementation: "IFeatureMembership.OwningType")]
        public string GetOwningType { get; internal set; }

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
        [Implements(implementation: "IRelationship.RelatedElement")]
        public List<string> GetRelatedElement { get; internal set; }

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
        [RedefinedByProperty("IMembership.MembershipOwningNamespace")]
        [Implements(implementation: "IRelationship.Source")]
        List<string> IRelationship.Source
        {
            get => throw new NotSupportedException("IRelationship.Source has been redefined by IMembership.MembershipOwningNamespace");
            set => throw new NotSupportedException("IRelationship.Source has been redefined by IMembership.MembershipOwningNamespace");
        }


        /// <summary>
        /// The relatedElements to which this Relationship is considered to be directed.
        /// </summary>
        [Property(xmiId: "4c7374f5-78f8-42ab-ae42-672ad9c80902", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "0d55f45c-0032-4618-9131-61ed58c3b8e2")]
        [RedefinedByProperty("IMembership.MemberElement")]
        [Implements(implementation: "IRelationship.Target")]
        List<string> IRelationship.Target
        {
            get => throw new NotSupportedException("IRelationship.Target has been redefined by IMembership.MemberElement");
            set => throw new NotSupportedException("IRelationship.Target has been redefined by IMembership.MemberElement");
        }


        /// <summary>
        /// The TextualRepresentations that annotate this Element.
        /// </summary>
        [Property(xmiId: "b8f93a3a-579d-4404-a560-2d9e3d40ff45", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "79363c3a-95cb-4931-b243-549e858d6d77")]
        [SubsettedProperty(propertyName: "953bdc5d-4008-4e40-8e30-c760f7956254")]
        [Implements(implementation: "IElement.TextualRepresentation")]
        public List<string> GetTextualRepresentation { get; internal set; }

        /// <summary>
        /// The Type that features the featureOfType.
        /// </summary>
        [Property(xmiId: "35ddd42a-b8a5-4ea6-b2d1-ab7d0a827a00", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "0d55f45c-0032-4618-9131-61ed58c3b8e2")]
        [RedefinedByProperty("IFeatureMembership.OwningType")]
        [Implements(implementation: "IFeaturing.Type")]
        string IFeaturing.Type
        {
            get => throw new NotSupportedException("IFeaturing.Type has been redefined by IFeatureMembership.OwningType");
            set => throw new NotSupportedException("IFeaturing.Type has been redefined by IFeatureMembership.OwningType");
        }


        /// <summary>
        /// Whether or not the Membership of the memberElement in the membershipOwningNamespace is publicly
        /// visible outside that Namespace.
        /// </summary>
        [Property(xmiId: "5901151e-f794-4fe3-bda3-fda18dd23c41", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: "public")]
        [Implements(implementation: "IMembership.Visibility")]
        public VisibilityKind Visibility { get; set; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
