// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.OpenCL
{
    public unsafe delegate void NotifyCallback(char* errinfo, void* privateInfo, UIntPtr cb, void* userData);
}
