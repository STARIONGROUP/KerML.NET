// -------------------------------------------------------------------------------------------------
// <copyright file="IClassifier.cs" company="Starion Group S.A.">
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

namespace KerML.NET.DTO.Core.Classifiers
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    using KerML.NET.DTO.Core.Types;
    using KerML.NET.Decorators;
    using KerML.NET.Namespaces;
    using KerML.NET.Types;

    /// <summary>
    /// A Classifier is a Type that classifies:<ul>	<li>Things (in the universe) regardless of how Features
    /// relate them. (These are interpreted semantically as sequences of exactly one thing.)</li>	<li>How
    /// the above things are related by Features. (These are interpreted semantically as sequences of
    /// multiple things, such that the last thing in the sequence is also classified by the Classifier. Note
    /// that this means that a Classifier modeled as specializing a Feature cannot classify
    /// anything.)</li></ul>
    /// </summary>
    [Class(xmiId: "d0a45a28-7af9-4bb2-9fc9-ac3e79928263", isAbstract: false, isFinalSpecialization: false, isActive: false)]
    [GeneratedCode("KerML.NET", "latest")]
    public partial interface IClassifier : IType
    {
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
