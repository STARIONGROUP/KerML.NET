// -------------------------------------------------------------------------------------------------
// <copyright file="UmlJsonSerializerGenerator.cs" company="Starion Group S.A.">
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
    using uml4net.StructuredClassifiers;
    using uml4net.xmi.Readers;

    /// <summary>
    /// A UML Handlebars based JsonSerializer code generator
    /// </summary>
    public class UmlJsonSerializerGenerator : UmlHandleBarsGenerator
    {
        /// <summary>
        /// A UML Handlebars based JsonSerializer code generator
        /// </summary>
        public override Task GenerateAsync(XmiReaderResult xmiReaderResult, DirectoryInfo outputDirectory)
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
            this.RegisterTemplate("dto-interface-uml-template");
            this.RegisterTemplate("dto-class-uml-template");
        }

        
    }
}