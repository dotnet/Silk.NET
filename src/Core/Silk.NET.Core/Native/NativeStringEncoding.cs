// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Core.Native
{
    public enum NativeStringEncoding
    {
        BStr,
        LPStr,
        LPTStr,
        LPUTF8Str,
        LPWStr,
        Ansi = LPStr,
        Auto = LPTStr,
        Uni = LPWStr,
        UTF8 = LPUTF8Str
    }
}
