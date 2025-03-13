﻿// -------------------------------------------------------------------------------------------------
// <copyright file="SerializerTestFixture.cs" company="Starion Group S.A.">
// 
//    Copyright 2022-2025 Starion Group S.A.
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
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

namespace KerML.NET.Serializer.Json.Tests
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    using NUnit.Framework;

    /// <summary>
    /// Suite of tests for the <see cref="Serializer"/>
    /// </summary>
    [TestFixture]
    public class SerializerTestFixture
    {
        private ISerializer serializer;

        [SetUp]
        public void SetUp()
        {
            this.serializer = new Serializer();
        }
    }
}
