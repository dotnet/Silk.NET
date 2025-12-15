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
    [NativeName("AnonymousName", "__AnonymousRecord_SDL_atomic_L263_C9")]
    [NativeName("Name", "SDL_atomic_t")]
    public unsafe partial struct AtomicT
    {
        public AtomicT
        (
            int? value = null
        ) : this()
        {
            if (value is not null)
            {
                Value = value.Value;
            }
        }


        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "value")]
        public int Value;
    }
}
