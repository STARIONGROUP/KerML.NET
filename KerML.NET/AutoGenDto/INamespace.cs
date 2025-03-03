// -------------------------------------------------------------------------------------------------
// <copyright file="INamespace.cs" company="Starion Group S.A.">
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

namespace KerML.NET.DTO.Root.Namespaces
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    using KerML.NET.DTO.Root.Elements;
    using KerML.NET.Decorators;
    using KerML.NET.Namespaces;
    using KerML.NET.Types;

    /// <summary>
    /// A Namespace is an Element that contains other Elements, known as its members, via Membership
    /// Relationships with those Elements. The members of a Namespace may be owned by the Namespace, aliased
    /// in the Namespace, or imported into the Namespace via Import Relationships.A Namespace can provide
    /// names for its members via the memberNames and memberShortNames specified by the Memberships in the
    /// Namespace. If a Membership specifies a memberName and/or memberShortName, then those are names of
    /// the corresponding memberElement relative to the Namespace. For an OwningMembership, the
    /// owningMemberName and owningMemberShortName are given by the Element name and shortName. Note that
    /// the same Element may be the memberElement of multiple Memberships in a Namespace (though it may be
    /// owned at most once), each of which may define a separate alias for the Element relative to the
    /// Namespace.
    /// </summary>
    [Class(xmiId: "16a893ca-c85b-4a48-989a-fc24520fc6d6", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface INamespace : IElement
    {
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
