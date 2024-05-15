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
    [NativeName("Name", "tagBSTRBLOB")]
    public unsafe partial struct BSTRBlob
    {
        public BSTRBlob
        (
            uint? cbSize = null,
            byte* pData = null
        ) : this()
        {
            if (cbSize is not null)
            {
                CbSize = cbSize.Value;
            }

            if (pData is not null)
            {
                PData = pData;
            }
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "cbSize")]
        public uint CbSize;

        [NativeName("Type", "BYTE *")]
        [NativeName("Type.Name", "BYTE *")]
        [NativeName("Name", "pData")]
        public byte* PData;
    }
}
