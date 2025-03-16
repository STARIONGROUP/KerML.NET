// -------------------------------------------------------------------------------------------------
// <copyright file="Redefinition.cs" company="Starion Group S.A.">
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

namespace KerML.NET.DTO.Core.Features
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

    /// <summary>
    /// Redefinition is a kind of Subsetting that requires the redefinedFeature and the redefiningFeature to
    /// have the same values (on each instance of the domain of the redefiningFeature). This means any
    /// restrictions on the redefiningFeature, such as type or multiplicity, also apply to the
    /// redefinedFeature (on each instance of the domain of the redefiningFeature), and vice versa. The
    /// redefinedFeature might have values for instances of the domain of the redefiningFeature, but only as
    /// instances of the domain of the redefinedFeature that happen to also be instances of the domain of
    /// the redefiningFeature. This is supported by the constraints inherited from Subsetting on the domains
    /// of the redefiningFeature and redefinedFeature. However, these constraints are narrowed for
    /// Redefinition to require the owningTypes of the redefiningFeature and redefinedFeature to be
    /// different and the redefinedFeature to not be inherited into the owningNamespace of the
    /// redefiningFeature.This enables the redefiningFeature to have the same name as the redefinedFeature,
    /// if desired.
    /// </summary>
    [Class(xmiId: "df9c1df6-7aa0-41af-8adb-8cdd7a47738f", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial class Redefinition : IRedefinition
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
        /// A Type with a superset of all instances of the specific Type, which might be the same set.
        /// </summary>
        [Property(xmiId: "6dd5c0f9-10e8-4361-90d4-723016f969f5", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "4c7374f5-78f8-42ab-ae42-672ad9c80902")]
        [RedefinedByProperty("ISubsetting.SubsettedFeature")]
        [Implements(implementation: "ISpecialization.General")]
        string ISpecialization.General
        {
            get => throw new NotSupportedException("ISpecialization.General has been redefined by ISubsetting.SubsettedFeature");
            set => throw new NotSupportedException("ISpecialization.General has been redefined by ISubsetting.SubsettedFeature");
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
        /// A subsettingFeature that is also the owningRelatedElement of this Subsetting.
        /// </summary>
        [Property(xmiId: "43a01c3e-8273-4941-b616-2f8edcc0ac17", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "20d11fe1-16c0-41fb-8823-559ce4084ebf")]
        [RedefinedProperty(propertyName: "adeb1ff1-cb20-496c-b832-6ae775e10fd9")]
        [Implements(implementation: "ISubsetting.OwningFeature")]
        public string? GetOwningFeature { get; internal set; }

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
        /// The Type that is the specific Type of this Specialization and owns it as its owningRelatedElement.
        /// </summary>
        [Property(xmiId: "adeb1ff1-cb20-496c-b832-6ae775e10fd9", aggregation: AggregationKind.None, lowerValue: 0, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "c81d146c-d738-40a0-ab80-8526beac3673")]
        [SubsettedProperty(propertyName: "f45c204e-a88a-4382-9701-ccc842d4a68a")]
        [RedefinedByProperty("ISubsetting.OwningFeature")]
        [Implements(implementation: "ISpecialization.OwningType")]
        string? ISpecialization.GetOwningType => throw new NotSupportedException("ISpecialization.GetOwningType has been redefined by ISubsetting.OwningFeature");

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
        /// The Feature that is redefined by the redefiningFeature of this Redefinition.
        /// </summary>
        [Property(xmiId: "c30433b4-031a-4ee7-8b11-9d39cbb35d39", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "b8bb3b86-cf2d-451e-b3c1-6a3aecac5aa4")]
        [Implements(implementation: "IRedefinition.RedefinedFeature")]
        public string RedefinedFeature { get; set; }

        /// <summary>
        /// The Feature that is redefining the redefinedFeature of this Redefinition.
        /// </summary>
        [Property(xmiId: "f5092d04-2553-4bcd-9c80-2e0e8d70d2fc", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "20d11fe1-16c0-41fb-8823-559ce4084ebf")]
        [Implements(implementation: "IRedefinition.RedefiningFeature")]
        public string RedefiningFeature { get; set; }

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
        [RedefinedByProperty("ISpecialization.Specific")]
        [Implements(implementation: "IRelationship.Source")]
        List<string> IRelationship.Source
        {
            get => throw new NotSupportedException("IRelationship.Source has been redefined by ISpecialization.Specific");
            set => throw new NotSupportedException("IRelationship.Source has been redefined by ISpecialization.Specific");
        }


        /// <summary>
        /// A Type with a subset of all instances of the general Type, which might be the same set.
        /// </summary>
        [Property(xmiId: "f45c204e-a88a-4382-9701-ccc842d4a68a", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "cd83f43d-3885-4b41-8f03-f02255e6a5da")]
        [RedefinedByProperty("ISubsetting.SubsettingFeature")]
        [Implements(implementation: "ISpecialization.Specific")]
        string ISpecialization.Specific
        {
            get => throw new NotSupportedException("ISpecialization.Specific has been redefined by ISubsetting.SubsettingFeature");
            set => throw new NotSupportedException("ISpecialization.Specific has been redefined by ISubsetting.SubsettingFeature");
        }


        /// <summary>
        /// The Feature that is subsetted by the subsettingFeature of this Subsetting.
        /// </summary>
        [Property(xmiId: "b8bb3b86-cf2d-451e-b3c1-6a3aecac5aa4", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "6dd5c0f9-10e8-4361-90d4-723016f969f5")]
        [RedefinedByProperty("IRedefinition.RedefinedFeature")]
        [Implements(implementation: "ISubsetting.SubsettedFeature")]
        string ISubsetting.SubsettedFeature
        {
            get => throw new NotSupportedException("ISubsetting.SubsettedFeature has been redefined by IRedefinition.RedefinedFeature");
            set => throw new NotSupportedException("ISubsetting.SubsettedFeature has been redefined by IRedefinition.RedefinedFeature");
        }


        /// <summary>
        /// The Feature that is a subset of the subsettedFeature of this Subsetting.
        /// </summary>
        [Property(xmiId: "20d11fe1-16c0-41fb-8823-559ce4084ebf", aggregation: AggregationKind.None, lowerValue: 1, upperValue: 1, isOrdered: false, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [RedefinedProperty(propertyName: "f45c204e-a88a-4382-9701-ccc842d4a68a")]
        [RedefinedByProperty("IRedefinition.RedefiningFeature")]
        [Implements(implementation: "ISubsetting.SubsettingFeature")]
        string ISubsetting.SubsettingFeature
        {
            get => throw new NotSupportedException("ISubsetting.SubsettingFeature has been redefined by IRedefinition.RedefiningFeature");
            set => throw new NotSupportedException("ISubsetting.SubsettingFeature has been redefined by IRedefinition.RedefiningFeature");
        }


        /// <summary>
        /// The relatedElements to which this Relationship is considered to be directed.
        /// </summary>
        [Property(xmiId: "4c7374f5-78f8-42ab-ae42-672ad9c80902", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: false, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "0d55f45c-0032-4618-9131-61ed58c3b8e2")]
        [RedefinedByProperty("ISpecialization.General")]
        [Implements(implementation: "IRelationship.Target")]
        List<string> IRelationship.Target
        {
            get => throw new NotSupportedException("IRelationship.Target has been redefined by ISpecialization.General");
            set => throw new NotSupportedException("IRelationship.Target has been redefined by ISpecialization.General");
        }


        /// <summary>
        /// The TextualRepresentations that annotate this Element.
        /// </summary>
        [Property(xmiId: "b8f93a3a-579d-4404-a560-2d9e3d40ff45", aggregation: AggregationKind.None, lowerValue: 0, upperValue: int.MaxValue, isOrdered: true, isReadOnly: false, isDerived: true, isDerivedUnion: false, isUnique: false, defaultValue: null)]
        [SubsettedProperty(propertyName: "79363c3a-95cb-4931-b243-549e858d6d77")]
        [SubsettedProperty(propertyName: "953bdc5d-4008-4e40-8e30-c760f7956254")]
        [Implements(implementation: "IElement.TextualRepresentation")]
        public List<string> GetTextualRepresentation { get; internal set; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
