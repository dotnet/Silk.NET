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
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [NativeName("Name", "tagStorageLayout")]
    public unsafe partial struct StorageLayout
    {
        public StorageLayout
        (
            uint? layoutType = null,
            char* pwcsElementName = null,
            long? cOffset = null,
            long? cBytes = null
        ) : this()
        {
            if (layoutType is not null)
            {
                LayoutType = layoutType.Value;
            }

            if (pwcsElementName is not null)
            {
                PwcsElementName = pwcsElementName;
            }

            if (cOffset is not null)
            {
                COffset = cOffset.Value;
            }

            if (cBytes is not null)
            {
                CBytes = cBytes.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "LayoutType")]
        public uint LayoutType;

        [NativeName("Type", "OLECHAR *")]
        [NativeName("Type.Name", "OLECHAR *")]
        [NativeName("Name", "pwcsElementName")]
        public char* PwcsElementName;

        [NativeName("Type", "LARGE_INTEGER")]
        [NativeName("Type.Name", "LARGE_INTEGER")]
        [NativeName("Name", "cOffset")]
        public long COffset;

        [NativeName("Type", "LARGE_INTEGER")]
        [NativeName("Type.Name", "LARGE_INTEGER")]
        [NativeName("Name", "cBytes")]
        public long CBytes;
    }
}
