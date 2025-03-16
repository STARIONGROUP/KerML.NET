// -------------------------------------------------------------------------------------------------
// <copyright file="UmlJsonDeSerializerGenerator.cs" company="Starion Group S.A.">
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

namespace KerML.NET.CodeGenerator.Generators.UmlHandleBarsGenerators
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    using uml4net.Extensions;
    using uml4net.SimpleClassifiers;
    using uml4net.StructuredClassifiers;
    using uml4net.xmi.Readers;

    /// <summary>
    /// A UML Handlebars based DeSerializer code generator
    /// </summary>
    public class UmlJsonDeSerializerGenerator : UmlHandleBarsGenerator
    {
        /// <summary>
        /// Generates JSON DeSerializer for KerML classes and enumerations
        /// </summary>
        /// <param name="xmiReaderResult">
        /// the <see cref="XmiReaderResult"/> that contains the UML model to generate from
        /// </param>
        /// <param name="outputDirectory">
        /// The target <see cref="DirectoryInfo"/>
        /// </param>
        /// <returns>
        /// an awaitable <see cref="Task"/>
        /// </returns>
        public override async Task GenerateAsync(XmiReaderResult xmiReaderResult, DirectoryInfo outputDirectory)
        {
            await this.GenerateEnumJsonDeSerializersAsync(xmiReaderResult, outputDirectory);
            await this.GenerateDtoJsonDeSerializersAsync(xmiReaderResult, outputDirectory);
            await this.GenerateDeSerializationProviderAsync(xmiReaderResult, outputDirectory);
        }

        /// <summary>
        /// Generates JSON DeSerializer for KerML enumerations
        /// </summary>
        /// <param name="xmiReaderResult">
        /// the <see cref="XmiReaderResult"/> that contains the UML model to generate from
        /// </param>
        /// <param name="outputDirectory">
        /// The target <see cref="DirectoryInfo"/>
        /// </param>
        /// <returns>
        /// an awaitable <see cref="Task"/>
        /// </returns>
        public Task GenerateEnumJsonDeSerializersAsync(XmiReaderResult xmiReaderResult, DirectoryInfo outputDirectory)
        {
            ArgumentNullException.ThrowIfNull(xmiReaderResult);

            ArgumentNullException.ThrowIfNull(outputDirectory);

            return this.GenerateEnumJsonDeSerializersInternalAsync(xmiReaderResult, outputDirectory);
        }

        /// <summary>
        /// Generates JSON DeSerializer for KerML enumerations
        /// </summary>
        /// <param name="xmiReaderResult">
        /// the <see cref="XmiReaderResult"/> that contains the UML model to generate from
        /// </param>
        /// <param name="outputDirectory">
        /// The target <see cref="DirectoryInfo"/>
        /// </param>
        /// <returns>
        /// an awaitable <see cref="Task"/>
        /// </returns>
        public async Task GenerateEnumJsonDeSerializersInternalAsync(XmiReaderResult xmiReaderResult, DirectoryInfo outputDirectory)
        {
            var template = this.Templates["json-enum-deserializer-uml-template"];

            var enumerations = xmiReaderResult.Root.QueryPackages()
                .SelectMany(x => x.PackagedElement.OfType<IEnumeration>())
                .ToList();

            foreach (var enumeration in enumerations)
            {
                var generatedDeSerializer = template(enumeration);

                generatedDeSerializer = CodeCleanup(generatedDeSerializer);

                var fileName = $"{enumeration.Name.CapitalizeFirstLetter()}DeSerializer.cs";

                await WriteAsync(generatedDeSerializer, outputDirectory, fileName);
            }
        }

        /// <summary>
        /// Generates JSON DeSerializer for KerML classes
        /// </summary>
        /// <param name="xmiReaderResult">
        /// the <see cref="XmiReaderResult"/> that contains the UML model to generate from
        /// </param>
        /// <param name="outputDirectory">
        /// The target <see cref="DirectoryInfo"/>
        /// </param>
        /// <returns>
        /// an awaitable task
        /// </returns>
        public Task GenerateDtoJsonDeSerializersAsync(XmiReaderResult xmiReaderResult, DirectoryInfo outputDirectory)
        {
            ArgumentNullException.ThrowIfNull(xmiReaderResult);

            ArgumentNullException.ThrowIfNull(outputDirectory);

            return this.GenerateDtoJsonDeSerializersInternalAsync(xmiReaderResult, outputDirectory);
        }

        /// <summary>
        /// Generates JSON DeSerializer for KerML classes
        /// </summary>
        /// <param name="xmiReaderResult">
        /// the <see cref="XmiReaderResult"/> that contains the UML model to generate from
        /// </param>
        /// <param name="outputDirectory">
        /// The target <see cref="DirectoryInfo"/>
        /// </param>
        /// <returns>
        /// an awaitable task
        /// </returns>
        private async Task GenerateDtoJsonDeSerializersInternalAsync(XmiReaderResult xmiReaderResult, DirectoryInfo outputDirectory)
        {
            var template = this.Templates["json-deserializer-uml-template"];

            var classes = xmiReaderResult.Root.QueryPackages()
                .SelectMany(x => x.PackagedElement.OfType<IClass>())
                .Where(x => !x.IsAbstract)
                .ToList();

            foreach (var @class in classes)
            {
                var generatedDto = template(@class);

                generatedDto = CodeCleanup(generatedDto);

                var fileName = $"{@class.Name.CapitalizeFirstLetter()}DeSerializer.cs";

                await WriteAsync(generatedDto, outputDirectory, fileName);
            }
        }

        /// <summary>
        /// Generates JSON DeSerializer for KerML class
        /// </summary>
        /// <param name="xmiReaderResult">
        /// the <see cref="XmiReaderResult"/> that contains the UML model to generate from
        /// </param>
        /// <param name="outputDirectory">
        /// The target <see cref="DirectoryInfo"/>
        /// </param>
        /// <param name="name">
        /// The name of the DTO to generate
        /// </param>
        /// <returns>
        /// an awaitable task
        /// </returns>
        public Task<string> GenerateJsonDeSerializerAsync(XmiReaderResult xmiReaderResult, DirectoryInfo outputDirectory, string name)
        {
            ArgumentNullException.ThrowIfNull(xmiReaderResult);

            ArgumentNullException.ThrowIfNull(outputDirectory);

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException(nameof(name));
            }

            return this.GenerateJsonDeSerializerInternalAsync(xmiReaderResult, outputDirectory, name);
        }

        /// <summary>
        /// Generates JSON DeSerializer for KerML class
        /// </summary>
        /// <param name="xmiReaderResult">
        /// the <see cref="XmiReaderResult"/> that contains the UML model to generate from
        /// </param>
        /// <param name="outputDirectory">
        /// The target <see cref="DirectoryInfo"/>
        /// </param>
        /// <param name="name">
        /// The name of the DTO interface to generate
        /// </param>
        /// <returns>
        /// an awaitable task
        /// </returns>
        private async Task<string> GenerateJsonDeSerializerInternalAsync(XmiReaderResult xmiReaderResult, DirectoryInfo outputDirectory, string name)
        {
            var template = this.Templates["json-deserializer-uml-template"];

            var classes = xmiReaderResult.Root.QueryPackages()
                .SelectMany(x => x.PackagedElement.OfType<IClass>())
                .ToList();

            var @class = classes.Single(x => x.Name == name);

            var generatedDataTransferObjectInterface = template(@class);

            generatedDataTransferObjectInterface = CodeCleanup(generatedDataTransferObjectInterface);

            var fileName = $"{@class.Name.CapitalizeFirstLetter()}DeSerializer.cs";

            await WriteAsync(generatedDataTransferObjectInterface, outputDirectory, fileName);

            return generatedDataTransferObjectInterface;
        }

        /// <summary>
        /// Generates Json DeSerializerProvider
        /// </summary>
        /// <param name="xmiReaderResult">
        /// the <see cref="XmiReaderResult"/> that contains the UML model to generate from
        /// </param>
        /// <param name="outputDirectory">
        /// The target <see cref="DirectoryInfo"/>
        /// </param>
        /// <returns>
        /// an awaitable task
        /// </returns>
        public Task GenerateDeSerializationProviderAsync(XmiReaderResult xmiReaderResult, DirectoryInfo outputDirectory)
        {
            ArgumentNullException.ThrowIfNull(xmiReaderResult);

            ArgumentNullException.ThrowIfNull(outputDirectory);

            return this.GenerateDeSerializationProviderInternalAsync(xmiReaderResult, outputDirectory);
        }

        /// <summary>
        /// Generates Json DeSerializerProvider
        /// </summary>
        /// <param name="xmiReaderResult">
        /// the <see cref="XmiReaderResult"/> that contains the UML model to generate from
        /// </param>
        /// <param name="outputDirectory">
        /// The target <see cref="DirectoryInfo"/>
        /// </param>
        /// <returns>
        /// an awaitable task
        /// </returns>
        private async Task GenerateDeSerializationProviderInternalAsync(XmiReaderResult xmiReaderResult, DirectoryInfo outputDirectory)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Register the custom helpers
        /// </summary>
        protected override void RegisterHelpers()
        {
            uml4net.HandleBars.StringHelper.RegisterStringHelper(this.Handlebars);
            uml4net.HandleBars.IEnumerableHelper.RegisterEnumerableHelper(this.Handlebars);
            uml4net.HandleBars.ClassHelper.RegisterClassHelper(this.Handlebars);
            uml4net.HandleBars.PropertyHelper.RegisterPropertyHelper(this.Handlebars);
            uml4net.HandleBars.GeneralizationHelper.RegisterGeneralizationHelper(this.Handlebars);
            uml4net.HandleBars.DocumentationHelper.RegisteredDocumentationHelper(this.Handlebars);
            uml4net.HandleBars.EnumHelper.RegisterEnumHelper(this.Handlebars);
            uml4net.HandleBars.DecoratorHelper.RegisterDecoratorHelper(this.Handlebars);

            KerML.NET.CodeGenerator.HandleBarHelpers.PropertyHelper.RegisterPropertyHelper(this.Handlebars);
            KerML.NET.CodeGenerator.HandleBarHelpers.ClassHelper.RegisterClassHelper(this.Handlebars);
            KerML.NET.CodeGenerator.HandleBarHelpers.NamedElementHelper.RegisterNamedElementHelper(this.Handlebars);
        }

        /// <summary>
        /// Register the code templates
        /// </summary>
        protected override void RegisterTemplates()
        {
            this.RegisterTemplate("json-enum-deserializer-uml-template");
            this.RegisterTemplate("json-deserializer-uml-template");
            this.RegisterTemplate("json-deserializer-provider-template");
        }
    }
}
