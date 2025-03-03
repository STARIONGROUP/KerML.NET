// -------------------------------------------------------------------------------------------------
// <copyright file="HtmlReportGeneratorTestFixture.cs" company="Starion Group S.A.">
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

    using Microsoft.Extensions.Logging;

    using NUnit.Framework;
    
    using Serilog;
    
    using uml4net.Reporting.Generators;

    [TestFixture]
    public class HtmlReportGeneratorTestFixture
    {
        private HtmlReportGenerator htmlReportGenerator;

        private ILoggerFactory loggerFactory;

        private string modelPath;

        private FileInfo modelFileInfo;

        private FileInfo reportFileInfo;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.Console()
                .CreateLogger();

            this.loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.AddSerilog();
            });
        }

        [SetUp]
        public void SetUp()
        {
            var rootPath = Path.Combine(TestContext.CurrentContext.TestDirectory, "datamodel");

            this.modelPath = Path.Combine(rootPath, "KerML_only_xmi.uml");
            this.modelFileInfo = new FileInfo(modelPath);

            var reportPath = Path.Combine(TestContext.CurrentContext.TestDirectory, "html-report.html");
            this.reportFileInfo = new FileInfo(reportPath);
        }

        [Test]
        public void Verify_that_the_report_generator_generates_a_report_of_uml()
        {
            this.htmlReportGenerator = new HtmlReportGenerator(this.loggerFactory);

            var rootPath = Path.Combine(TestContext.CurrentContext.TestDirectory, "datamodel");

            var pathMaps = new Dictionary<string, string>
            {
                ["pathmap://UML_LIBRARIES/UMLPrimitiveTypes.library.uml"] =
                    Path.Combine(rootPath, "PrimitiveTypes.xmi")
            };

            Assert.That(() => this.htmlReportGenerator.GenerateReport(this.modelFileInfo, this.modelFileInfo.Directory, true, pathMaps, reportFileInfo), Throws.Nothing);
        }
    }
}
