// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Enums;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Converters
{
    public interface IConstructor
    {
        void WriteFunctions(Profile profile, IEnumerable<Function> functions, ProfileConverterOptions opts);
        void WriteEnums(Profile profile, IEnumerable<Enum> enums, ProfileConverterOptions opts);
        void WriteStructs(Profile profile, IEnumerable<Struct> structs, ProfileConverterOptions opts);
        void WriteConstants(Profile profile, IEnumerable<Constant> constants, ProfileConverterOptions opts);
    }
}
