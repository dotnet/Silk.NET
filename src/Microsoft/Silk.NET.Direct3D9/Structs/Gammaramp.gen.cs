// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DGAMMARAMP")]
    public unsafe partial struct Gammaramp
    {
        [NativeName("Type", "WORD[256]")]
        [NativeName("Type.Name", "WORD[256]")]
        [NativeName("Name", "red")]
        public fixed ushort Red[256];
        [NativeName("Type", "WORD[256]")]
        [NativeName("Type.Name", "WORD[256]")]
        [NativeName("Name", "green")]
        public fixed ushort Green[256];
        [NativeName("Type", "WORD[256]")]
        [NativeName("Type.Name", "WORD[256]")]
        [NativeName("Name", "blue")]
        public fixed ushort Blue[256];
    }
}
