// -------------------------------------------------------------------------------------------------
// <copyright file="UmlJsonSerializerGeneratorTestFixture.cs" company="Starion Group S.A.">
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

namespace KerML.NET.CodeGenerator.Tests.Generators.UmlHandleBarsGenerators
{
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;

    using KerML.NET.CodeGenerator.Generators.UmlHandleBarsGenerators;

    using Microsoft.Extensions.Logging;

    using NUnit.Framework;

    using Serilog;

    using uml4net.xmi;
    using uml4net.xmi.Readers;

    [TestFixture]
    public class UmlJsonSerializerGeneratorTestFixture
    {
        private DirectoryInfo jsonSerializerDirectoryInfo;

        private UmlJsonSerializerGenerator umlJsonSerializerGenerator;

        private ILoggerFactory loggerFactory;

        private XmiReaderResult xmiReaderResult;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .CreateLogger();

            loggerFactory = LoggerFactory.Create(builder => { builder.AddSerilog(); });
        }

        [SetUp]
        public void SetUp()
        {
            var rootPath = Path.Combine(TestContext.CurrentContext.TestDirectory, "datamodel");

            var pathMaps = new Dictionary<string, string>
            {
                ["pathmap://UML_LIBRARIES/UMLPrimitiveTypes.library.uml"] =
                    Path.Combine(rootPath, "PrimitiveTypes.xmi")
            };

            var reader = XmiReaderBuilder.Create()
                .UsingSettings(x => x.LocalReferenceBasePath = rootPath)
                .UsingSettings(x => x.PathMaps = pathMaps)
                .WithLogger(loggerFactory)
                .Build();

            xmiReaderResult = reader.Read(Path.Combine(TestContext.CurrentContext.TestDirectory, "datamodel",
                "KerML_only_xmi.uml"));

            var directoryInfo = new DirectoryInfo(TestContext.CurrentContext.TestDirectory);

            var path = Path.Combine("UML", "_KerML2.AutoGenSerializer");

            this.jsonSerializerDirectoryInfo = directoryInfo.CreateSubdirectory(path);

            this.umlJsonSerializerGenerator = new UmlJsonSerializerGenerator();
        }

        [Test]
        public async Task Verify_that_expected_Classes_are_generated(
            [Values("Annotation", "Comment", "Dependency", "Feature",
                "LiteralInteger", "LiteralRational")] string className)
        {
            var generatedCode = await this.umlJsonSerializerGenerator.GenerateJsonSerializerAsync(xmiReaderResult,
                this.jsonSerializerDirectoryInfo,
                className);

            var expected = await File.ReadAllTextAsync(Path.Combine(TestContext.CurrentContext.TestDirectory,
                $"Expected/UML/AutoGenSerializer/{className}Serializer.cs"));

            Assert.That(generatedCode, Is.EqualTo(expected));
        }

        [Test]
        public void Verify_that_JsonSerializers_are_generated()
        {
            Assert.That(async () => await this.umlJsonSerializerGenerator.GenerateDtoJsonSerializersAsync(
                    xmiReaderResult,
                    this.jsonSerializerDirectoryInfo),
                Throws.Nothing);
        }
    }
}