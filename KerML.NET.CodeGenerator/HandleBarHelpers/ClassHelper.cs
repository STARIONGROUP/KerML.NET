// -------------------------------------------------------------------------------------------------
// <copyright file="ClassHelper.cs" company="Starion Group S.A.">
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

namespace KerML.NET.CodeGenerator.HandleBarHelpers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using HandlebarsDotNet;

    using uml4net.Extensions;
    using uml4net.StructuredClassifiers;

    /// <summary>
    /// A handlebars block helper for the <see cref="IClass"/> interface
    /// </summary>
    public static class ClassHelper
    {
        /// <summary>
        /// Registers the <see cref="ClassHelper"/>
        /// </summary>
        /// <param name="handlebars">
        /// The <see cref="IHandlebars"/> context with which the helper needs to be registered
        /// </param>
        public static void RegisterClassHelper(this IHandlebars handlebars)
        {
            handlebars.RegisterHelper("Class.QueryOwnedAttributeOrdered", (context, _) =>
            {
                if (!(context.Value is IClass @class))
                {
                    throw new ArgumentException("supposed to be IClass");
                }

                var properties = @class.OwnedAttribute.OrderBy(x => x.Name);

                return properties;
            });

            handlebars.RegisterHelper("Class.QueryOwnedNonDerivedNonReadOnlyProperties", (context, _) =>
            {
                if (!(context.Value is IClass @class))
                {
                    throw new ArgumentException("supposed to be IClass");
                }

                var properties = @class.OwnedAttribute
                    .Where(x => !x.IsDerived)
                    .Where(x => !x.IsDerivedUnion)
                    .Where(x => !x.IsReadOnly)
                    .OrderBy(x => x.Name)
                    .ToList();

                return properties;
            });

            handlebars.RegisterHelper("Class.WritePocoNameSpacesOwnedNonDerivedNonReadOnlyProperties", (writer, context, _) =>
            {
                if (!(context.Value is IClass @class))
                {
                    throw new ArgumentException("supposed to be IClass");
                }

                var properties = @class.OwnedAttribute
                    .Where(x => !x.IsDerived)
                    .Where(x => !x.IsDerivedUnion)
                    .Where(x => !x.IsReadOnly)
                    .OrderBy(x => x.Name)
                    .Where(x => x.QueryIsReferenceProperty())
                    .ToList();

                var uniqueNamespaces = new HashSet<string>();

                foreach (var property in properties)
                {
                    var qualifiedNameSpaces = property.Type.QualifiedName.Split("::");
                    var namespaces = qualifiedNameSpaces.Skip(1).Take(qualifiedNameSpaces.Length - 2);
                    var nameSpace = string.Join('.', namespaces);
                    uniqueNamespaces.Add(nameSpace);
                }

                var orderedNamespaces = uniqueNamespaces.Order();
                foreach (var orderedNamespace in orderedNamespaces)
                {
                    writer.WriteSafeString($"using KerML.NET.DTO.{orderedNamespace} ;{Environment.NewLine}");
                }
            });

            handlebars.RegisterHelper("Class.WriteDTONameSpaces", (writer, context, _) =>
            {
                if (!(context.Value is IClass @class))
                {
                    throw new ArgumentException("supposed to be IClass");
                }

                var superClasses = @class.QuerySuperClass();

                var uniqueNamespaces = new HashSet<string>();

                foreach (var superClass in superClasses)
                {
                    var qualifiedNameSpaces = superClass.QualifiedName.Split("::");
                    var namespaces = qualifiedNameSpaces.Skip(1).Take(qualifiedNameSpaces.Length - 2);
                    var nameSpace = string.Join('.', namespaces);
                    uniqueNamespaces.Add(nameSpace);
                }

                var allProperties = @class.QueryAllProperties();
                foreach (var prop in allProperties.Where(x => x.QueryIsReferenceProperty()))
                {
                    var qualifiedNameSpaces = prop.Type.QualifiedName.Split("::");
                    var namespaces = qualifiedNameSpaces.Skip(1).Take(qualifiedNameSpaces.Length - 2);
                    var nameSpace = string.Join('.', namespaces);
                    uniqueNamespaces.Add(nameSpace);
                }

                var orderedNamespaces = uniqueNamespaces.Order().ToList();
                foreach (var orderedNamespace in orderedNamespaces)
                {
                    writer.WriteSafeString($"using KerML.NET.DTO.{orderedNamespace} ;{Environment.NewLine}");
                }
            });

            handlebars.RegisterHelper("Class.WriteFullyQualifiedName", (writer, context, _) =>
            {
                if (!(context.Value is IClass @class))
                {
                    throw new ArgumentException("supposed to be IClass");
                }

                var qualifiedNameSpaces = @class.QualifiedName.Split("::");
                var namespaces = qualifiedNameSpaces.Skip(1).Take(qualifiedNameSpaces.Length - 2);
                var nameSpace = string.Join('.', namespaces);

                writer.WriteSafeString($"KerML.NET.DTO.{nameSpace}.{@class.Name}");
            });

            handlebars.RegisterHelper("Class.WriteFullyQualifiedNameSpace", (writer, context, _) =>
            {
                if (!(context.Value is IClass @class))
                {
                    throw new ArgumentException("supposed to be IClass");
                }

                var qualifiedNameSpaces = @class.QualifiedName.Split("::");
                var namespaces = qualifiedNameSpaces.Skip(1).Take(qualifiedNameSpaces.Length - 2);
                var nameSpace = string.Join('.', namespaces);

                writer.WriteSafeString($"KerML.NET.DTO.{nameSpace}");
            });
        }
    }
}
