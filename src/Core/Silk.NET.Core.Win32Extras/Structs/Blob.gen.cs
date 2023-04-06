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
    [NativeName("Name", "tagBLOB")]
    public unsafe partial struct Blob
    {
        public Blob
        (
            uint? cbSize = null,
            byte* pBlobData = null
        ) : this()
        {
            if (cbSize is not null)
            {
                CbSize = cbSize.Value;
            }

            if (pBlobData is not null)
            {
                PBlobData = pBlobData;
            }
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "cbSize")]
        public uint CbSize;

        [NativeName("Type", "BYTE *")]
        [NativeName("Type.Name", "BYTE *")]
        [NativeName("Name", "pBlobData")]
        public byte* PBlobData;
    }
}
