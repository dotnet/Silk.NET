// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Native;

namespace Silk.NET.Direct3D9
{
    public struct RGNData
    {
        public Header Rdh;
        public unsafe fixed byte Buffer[1];
        public struct Header
        {
            public long DwSize;
            public long IType;
            public long NCount;
            public long NRgnSize;
            public TagRect rcBound;
        }
    }
}
