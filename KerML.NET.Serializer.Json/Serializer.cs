﻿// -------------------------------------------------------------------------------------------------
// <copyright file="Serializer.cs" company="Starion Group S.A.">
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

namespace KerML.NET.Serializer.Json
{
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json;
    using System.Threading;
    using System.Threading.Tasks;

    using KerML.NET.DTO.Root.Elements;

    /// <summary>
    /// The purpose of the <see cref="Serializer"/> is to write an <see cref="IElement"/> and <see cref="IEnumerable{IElement}"/>
    /// as JSON to a <see cref="Stream"/>
    /// </summary>
    public class Serializer : ISerializer
    {
        /// <summary>
        /// Serialize an <see cref="IEnumerable{IElement}"/> as JSON to a target <see cref="Stream"/>
        /// </summary>
        /// <param name="elements">
        /// The <see cref="IEnumerable{IElement}"/> that shall be serialized
        /// </param>
        /// <param name="serializationModeKind">
        /// The <see cref="SerializationModeKind"/> to use
        /// </param>
        /// <param name="includeDerived">
        /// A value indicating whether derived properties shall be serialized or not
        /// </param>
        /// <param name="stream">
        /// The target <see cref="Stream"/>
        /// </param>
        /// <param name="jsonWriterOptions">
        /// The <see cref="JsonWriterOptions"/> to use
        /// </param>
        public void Serialize(IEnumerable<IElement> elements, SerializationModeKind serializationModeKind, bool includeDerived, Stream stream, JsonWriterOptions jsonWriterOptions)
        {
            using var writer = new Utf8JsonWriter(stream, jsonWriterOptions);

            writer.WriteStartArray();

            foreach (var element in elements)
            {
                var serializationAction = SerializationProvider.Provide(element.GetType());
                serializationAction(element, writer, serializationModeKind, includeDerived);
                writer.Flush();
            }

            writer.WriteEndArray();

            writer.Flush();
        }

        /// <summary>
        /// Serialize an <see cref="IElement"/> as JSON to a target <see cref="Stream"/>
        /// </summary>
        /// <param name="element">
        /// The <see cref="IElement"/> that shall be serialized
        /// </param>
        /// <param name="serializationModeKind">
        /// The <see cref="SerializationModeKind"/> to use
        /// </param>
        /// <param name="includeDerived">
        /// A value indicating whether derived properties shall be serialized or not
        /// </param>
        /// <param name="stream">
        /// The target <see cref="Stream"/>
        /// </param>
        /// <param name="jsonWriterOptions">
        /// The <see cref="JsonWriterOptions"/> to use
        /// </param>
        public void Serialize(IElement element, SerializationModeKind serializationModeKind, bool includeDerived, Stream stream, JsonWriterOptions jsonWriterOptions)
        {
            using var writer = new Utf8JsonWriter(stream, jsonWriterOptions);
            var serializationAction = SerializationProvider.Provide(element.GetType());
            serializationAction(element, writer, serializationModeKind, includeDerived);
            writer.Flush();
        }

        /// <summary>
        /// Asynchronously serialize an <see cref="IEnumerable{IElement}"/> as JSON to a target <see cref="Stream"/>
        /// </summary>
        /// <param name="elements">
        /// The <see cref="IEnumerable{IElement}"/> that shall be serialized
        /// </param>
        /// <param name="serializationModeKind">
        /// The <see cref="SerializationModeKind"/> to use
        /// </param>
        /// <param name="includeDerived">
        /// A value indicating whether derived properties shall be serialized or not
        /// </param>
        /// <param name="stream">
        /// The target <see cref="Stream"/>
        /// </param>
        /// <param name="jsonWriterOptions">
        /// The <see cref="JsonWriterOptions"/> to use
        /// </param>
        /// <param name="cancellationToken">
        /// The <see cref="CancellationToken"/> used to cancel the operation
        /// </param>
        public async Task SerializeAsync(IEnumerable<IElement> elements, SerializationModeKind serializationModeKind, bool includeDerived, Stream stream, JsonWriterOptions jsonWriterOptions, CancellationToken cancellationToken)
        {
            await using var writer = new Utf8JsonWriter(stream, jsonWriterOptions);
            writer.WriteStartArray();

            foreach (var element in elements)
            {
                var serializationAction = SerializationProvider.Provide(element.GetType());
                serializationAction(element, writer, serializationModeKind, includeDerived);
                await writer.FlushAsync(cancellationToken);
                    
            }

            writer.WriteEndArray();

            await writer.FlushAsync(cancellationToken);
        }

        /// <summary>
        /// Asynchronously serialize an <see cref="IElement"/> as JSON to a target <see cref="Stream"/>
        /// </summary>
        /// <param name="element">
        /// The <see cref="IElement"/> that shall be serialized
        /// </param>
        /// <param name="serializationModeKind">
        /// The <see cref="SerializationModeKind"/> to use
        /// </param>
        /// <param name="includeDerived">
        /// A value indicating whether derived properties shall be serialized or not
        /// </param>
        /// <param name="stream">
        /// The target <see cref="Stream"/>
        /// </param>
        /// <param name="jsonWriterOptions">
        /// The <see cref="JsonWriterOptions"/> to use
        /// </param>
        /// <param name="cancellationToken">
        /// The <see cref="CancellationToken"/> used to cancel the operation
        /// </param>
        public async Task SerializeAsync(IElement element, SerializationModeKind serializationModeKind, bool includeDerived, Stream stream, JsonWriterOptions jsonWriterOptions, CancellationToken cancellationToken)
        {
            await using var writer = new Utf8JsonWriter(stream, jsonWriterOptions);
            var serializationAction = SerializationProvider.Provide(element.GetType());
            serializationAction(element, writer, serializationModeKind, includeDerived);
            await writer.FlushAsync(cancellationToken);
        }
    }
}