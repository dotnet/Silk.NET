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
    [NativeName("Name", "tagCLIPDATA")]
    public unsafe partial struct ClipData
    {
        public ClipData
        (
            uint? cbSize = null,
            int? ulClipFmt = null,
            byte* pClipData = null
        ) : this()
        {
            if (cbSize is not null)
            {
                CbSize = cbSize.Value;
            }

            if (ulClipFmt is not null)
            {
                UlClipFmt = ulClipFmt.Value;
            }

            if (pClipData is not null)
            {
                PClipData = pClipData;
            }
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "cbSize")]
        public uint CbSize;

        [NativeName("Type", "LONG")]
        [NativeName("Type.Name", "LONG")]
        [NativeName("Name", "ulClipFmt")]
        public int UlClipFmt;

        [NativeName("Type", "BYTE *")]
        [NativeName("Type.Name", "BYTE *")]
        [NativeName("Name", "pClipData")]
        public byte* PClipData;
    }
}
