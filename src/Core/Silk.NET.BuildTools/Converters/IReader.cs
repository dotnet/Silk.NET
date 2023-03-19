// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.IO;
using System.Linq;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Enums;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Converters
{
    /// <summary>
    /// An interface representing an API reader. 
    /// </summary>
    public interface IReader
    {
        /// <summary>
        /// Read the specification from the provided stream.
        /// </summary>
        /// <param name="stream">A stream containing an XDocument describing the specification.</param>
        /// <returns></returns>
        object Load(Stream stream);
        
        /// <summary>
        /// Read the structs from the specification.
        /// </summary>
        /// <param name="obj">The specification to read from.</param>
        /// <param name="opts">The options to use while reading.</param>
        /// <returns>A list of all structs in the specification.</returns>
        IEnumerable<Struct> ReadStructs(object obj, BindTask task);
        
        /// <summary>
        /// Read the functions from the specification.
        /// </summary>
        /// <param name="obj">The specification to read from.</param>
        /// <param name="opts">The options to use while reading.</param>
        /// <returns>A list of all functions in the specification.</returns>
        IEnumerable<Function> ReadFunctions(object obj, BindTask task);
        
        /// <summary>
        /// Read the enums from the specification.
        /// </summary>
        /// <param name="obj">The specification to read from.</param>
        /// <param name="opts">The options to use while reading.</param>
        /// <returns>A list of all enums in the specification.</returns>
        IEnumerable<Enum> ReadEnums(object obj, BindTask task);
        
        /// <summary>
        /// Read the constants from the specification.
        /// </summary>
        /// <param name="obj">The specification to read from.</param>
        /// <param name="opts">The options to use while reading.</param>
        /// <returns>A list of all constants in the specification.</returns>
        IEnumerable<Constant> ReadConstants(object obj, BindTask task);

        /// <summary>
        /// Reads the typedefs from the specification.
        /// </summary>
        /// <param name="obj">The specification to read from.</param>
        /// <param name="task">The options to use while reading.</param>
        /// <returns>A list of all the typedefs in the specification.</returns>
        IEnumerable<ConverterTypemap> ReadTypedefs(object obj, BindTask task)
            => Enumerable.Empty<ConverterTypemap>();
    }
}
