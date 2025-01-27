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

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagExtentInfo")]
    public unsafe partial struct ExtentInfo
    {
        public ExtentInfo
        (
            uint? cb = null,
            uint? dwExtentMode = null,
            Silk.NET.Maths.Vector2D<int>? sizelProposed = null
        ) : this()
        {
            if (cb is not null)
            {
                Cb = cb.Value;
            }

            if (dwExtentMode is not null)
            {
                DwExtentMode = dwExtentMode.Value;
            }

            if (sizelProposed is not null)
            {
                SizelProposed = sizelProposed.Value;
            }
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "cb")]
        public uint Cb;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwExtentMode")]
        public uint DwExtentMode;

        [NativeName("Type", "SIZEL")]
        [NativeName("Type.Name", "SIZEL")]
        [NativeName("Name", "sizelProposed")]
        public Silk.NET.Maths.Vector2D<int> SizelProposed;
    }
}
