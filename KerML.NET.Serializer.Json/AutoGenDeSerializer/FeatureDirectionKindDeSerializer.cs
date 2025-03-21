﻿// -------------------------------------------------------------------------------------------------
// <copyright file="FeatureDirectionKindDeSerializer.cs" company="Starion Group S.A.">
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

    using KerML.NET.Core.Types;

    /// <summary>
    /// The purpose of the <see cref="FeatureDirectionKindDeSerializer"/> is to provide deserialization capabilities
    /// for the <see cref="FeatureDirectionKind"/> Enum
    /// </summary>
    public static class FeatureDirectionKindDeSerializer
    {
        /// <summary>
        /// Deserializes a string value to a <see cref="FeatureDirectionKind"/>
        /// </summary>
        /// <param name="value">
        /// The string representation of the <see cref="FeatureDirectionKind"/>
        /// </param>
        /// <returns>
        /// The value of the <see cref="FeatureDirectionKind"/>
        /// </returns>
        public static FeatureDirectionKind Deserialize(string value)
        {
            value = value.ToUpper();

            switch (value)
            {
                case "IN":
                    return FeatureDirectionKind.In;
                case "INOUT":
                    return FeatureDirectionKind.Inout;
                case "OUT":
                    return FeatureDirectionKind.Out;
                default:
                    throw new ArgumentException($"{value} is not a valid FeatureDirectionKind", nameof(value));
            }
        }

        /// <summary>
        /// Deserializes a string value to a nullable <see cref="FeatureDirectionKind"/>
        /// </summary>
        /// <param name="value">
        /// The string representation of the <see cref="FeatureDirectionKind"/>
        /// </param>
        /// <returns>
        /// The value of the nullable <see cref="FeatureDirectionKind"/>
        /// </returns>
        public static FeatureDirectionKind? DeserializeNullable(string value)
        {
            if (value == null)
            {
                return null;
            }

            value = value.ToUpper();

            switch (value)
            {
                case "IN":
                    return FeatureDirectionKind.In;
                case "INOUT":
                    return FeatureDirectionKind.Inout;
                case "OUT":
                    return FeatureDirectionKind.Out;
                default:
                    throw new ArgumentException($"{value} is not a valid ", nameof(value));
            }
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
