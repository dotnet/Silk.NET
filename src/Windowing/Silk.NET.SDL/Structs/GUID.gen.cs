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

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousRecord_SDL_guid_L55_C9")]
    [NativeName("Name", "SDL_GUID")]
    public unsafe partial struct GUID
    {
        [NativeName("Type", "Uint8[16]")]
        [NativeName("Type.Name", "Uint8[16]")]
        [NativeName("Name", "data")]
        public fixed byte Data[16];
    }
}
