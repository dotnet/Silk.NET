// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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
