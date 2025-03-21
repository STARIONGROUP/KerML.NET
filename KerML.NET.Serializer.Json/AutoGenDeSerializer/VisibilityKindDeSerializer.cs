﻿// -------------------------------------------------------------------------------------------------
// <copyright file="VisibilityKindDeSerializer.cs" company="Starion Group S.A.">
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

    using KerML.NET.Root.Namespaces;

    /// <summary>
    /// The purpose of the <see cref="VisibilityKindDeSerializer"/> is to provide deserialization capabilities
    /// for the <see cref="VisibilityKind"/> Enum
    /// </summary>
    public static class VisibilityKindDeSerializer
    {
        /// <summary>
        /// Deserializes a string value to a <see cref="VisibilityKind"/>
        /// </summary>
        /// <param name="value">
        /// The string representation of the <see cref="VisibilityKind"/>
        /// </param>
        /// <returns>
        /// The value of the <see cref="VisibilityKind"/>
        /// </returns>
        public static VisibilityKind Deserialize(string value)
        {
            value = value.ToUpper();

            switch (value)
            {
                case "PRIVATE":
                    return VisibilityKind.Private;
                case "PROTECTED":
                    return VisibilityKind.Protected;
                case "PUBLIC":
                    return VisibilityKind.Public;
                default:
                    throw new ArgumentException($"{value} is not a valid VisibilityKind", nameof(value));
            }
        }

        /// <summary>
        /// Deserializes a string value to a nullable <see cref="VisibilityKind"/>
        /// </summary>
        /// <param name="value">
        /// The string representation of the <see cref="VisibilityKind"/>
        /// </param>
        /// <returns>
        /// The value of the nullable <see cref="VisibilityKind"/>
        /// </returns>
        public static VisibilityKind? DeserializeNullable(string value)
        {
            if (value == null)
            {
                return null;
            }

            value = value.ToUpper();

            switch (value)
            {
                case "PRIVATE":
                    return VisibilityKind.Private;
                case "PROTECTED":
                    return VisibilityKind.Protected;
                case "PUBLIC":
                    return VisibilityKind.Public;
                default:
                    throw new ArgumentException($"{value} is not a valid ", nameof(value));
            }
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
