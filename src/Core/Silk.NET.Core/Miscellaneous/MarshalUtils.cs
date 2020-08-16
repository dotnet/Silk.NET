// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Core
{
    public static class MarshalUtils
    {
        public static IntPtr AllocBStr(int len) => Marshal.StringToBSTR(new string('\0', len));
    }
}
