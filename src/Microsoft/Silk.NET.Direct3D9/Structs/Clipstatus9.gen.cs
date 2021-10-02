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
    [NativeName("Name", "_D3DCLIPSTATUS9")]
    public unsafe partial struct Clipstatus9
    {
        public Clipstatus9
        (
            uint? clipUnion = null,
            uint? clipIntersection = null
        ) : this()
        {
            if (clipUnion is not null)
            {
                ClipUnion = clipUnion.Value;
            }

            if (clipIntersection is not null)
            {
                ClipIntersection = clipIntersection.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "ClipUnion")]
        public uint ClipUnion;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "ClipIntersection")]
        public uint ClipIntersection;
    }
}
