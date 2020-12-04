// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Enums;
using Silk.NET.BuildTools.Common.Functions;

// TODO: All implementors also have extra functions TrimName and FormatCategory, should that be moved here?

namespace Silk.NET.BuildTools.Converters
{
    /// <summary>
    /// An interface representing an API constructor.
    /// </summary>
    public interface IConstructor
    {
        /// <summary>
        /// Writes a collection of functions to their appropriate projects.
        /// </summary>
        /// <param name="profile">The profile to write the projects to.</param>
        /// <param name="functions">The functions to write.</param>
        /// <param name="opts">The options for profile conversion.</param>
        void WriteFunctions(Profile profile, IEnumerable<Function> functions, ProfileConverterOptions opts);

        /// <summary>
        /// Writes a collection of enums to their appropriate projects.
        /// </summary>
        /// <param name="profile">The profile to write the projects to.</param>
        /// <param name="enums">The enums to write.</param>
        /// <param name="opts">The options for profile conversion.</param>
        void WriteEnums(Profile profile, IEnumerable<Enum> enums, ProfileConverterOptions opts);

        /// <summary>
        /// Writes a collection of structs to their appropriate projects.
        /// </summary>
        /// <param name="profile">The profile to write the projects to.</param>
        /// <param name="structs">The structs to write.</param>
        /// <param name="opts">The options for profile conversion.</param>
        void WriteStructs(Profile profile, IEnumerable<Struct> structs, ProfileConverterOptions opts);

        /// <summary>
        /// Writes a collection of constants to their appropriate projects.
        /// </summary>
        /// <param name="profile">The profile to write the projects to.</param>
        /// <param name="constants">The constants to write.</param>
        /// <param name="opts">The options for profile conversion.</param>
        void WriteConstants(Profile profile, IEnumerable<Constant> constants, ProfileConverterOptions opts);
    }
}
