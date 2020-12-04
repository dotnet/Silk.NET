// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.IO;
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
        IEnumerable<Struct> ReadStructs(object obj, ProfileConverterOptions opts);

        /// <summary>
        /// Read the functions from the specification.
        /// </summary>
        /// <param name="obj">The specification to read from.</param>
        /// <param name="opts">The options to use while reading.</param>
        /// <returns>A list of all functions in the specification.</returns>
        IEnumerable<Function> ReadFunctions(object obj, ProfileConverterOptions opts);

        /// <summary>
        /// Read the enums from the specification.
        /// </summary>
        /// <param name="obj">The specification to read from.</param>
        /// <param name="opts">The options to use while reading.</param>
        /// <returns>A list of all enums in the specification.</returns>
        IEnumerable<Enum> ReadEnums(object obj, ProfileConverterOptions opts);

        /// <summary>
        /// Read the constants from the specification.
        /// </summary>
        /// <param name="obj">The specification to read from.</param>
        /// <param name="opts">The options to use while reading.</param>
        /// <returns>A list of all constants in the specification.</returns>
        IEnumerable<Constant> ReadConstants(object obj, ProfileConverterOptions opts);
    }
}
