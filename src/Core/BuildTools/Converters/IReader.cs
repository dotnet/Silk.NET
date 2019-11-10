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
    public interface IReader
    {
        object Load(Stream stream);
        IEnumerable<Struct> ReadStructs(object obj, ProfileConverterOptions opts);
        IEnumerable<Function> ReadFunctions(object obj, ProfileConverterOptions opts);
        IEnumerable<Enum> ReadEnums(object obj, ProfileConverterOptions opts);
        IEnumerable<Constant> ReadConstants(object obj, ProfileConverterOptions opts);
    }
}
