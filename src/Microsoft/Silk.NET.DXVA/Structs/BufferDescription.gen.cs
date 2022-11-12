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

namespace Silk.NET.DXVA
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [NativeName("Name", "_DXVA_BufferDescription")]
    public unsafe partial struct BufferDescription
    {
        public BufferDescription
        (
            int? dwTypeIndex = null,
            int? dwBufferIndex = null,
            int? dwDataOffset = null,
            int? dwDataSize = null,
            int? dwFirstMBaddress = null,
            int? dwNumMBsInBuffer = null,
            int? dwWidth = null,
            int? dwHeight = null,
            int? dwStride = null,
            int? dwReservedBits = null
        ) : this()
        {
            if (dwTypeIndex is not null)
            {
                DwTypeIndex = dwTypeIndex.Value;
            }

            if (dwBufferIndex is not null)
            {
                DwBufferIndex = dwBufferIndex.Value;
            }

            if (dwDataOffset is not null)
            {
                DwDataOffset = dwDataOffset.Value;
            }

            if (dwDataSize is not null)
            {
                DwDataSize = dwDataSize.Value;
            }

            if (dwFirstMBaddress is not null)
            {
                DwFirstMBaddress = dwFirstMBaddress.Value;
            }

            if (dwNumMBsInBuffer is not null)
            {
                DwNumMBsInBuffer = dwNumMBsInBuffer.Value;
            }

            if (dwWidth is not null)
            {
                DwWidth = dwWidth.Value;
            }

            if (dwHeight is not null)
            {
                DwHeight = dwHeight.Value;
            }

            if (dwStride is not null)
            {
                DwStride = dwStride.Value;
            }

            if (dwReservedBits is not null)
            {
                DwReservedBits = dwReservedBits.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwTypeIndex")]
        public int DwTypeIndex;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwBufferIndex")]
        public int DwBufferIndex;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwDataOffset")]
        public int DwDataOffset;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwDataSize")]
        public int DwDataSize;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwFirstMBaddress")]
        public int DwFirstMBaddress;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwNumMBsInBuffer")]
        public int DwNumMBsInBuffer;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwWidth")]
        public int DwWidth;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwHeight")]
        public int DwHeight;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwStride")]
        public int DwStride;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwReservedBits")]
        public int DwReservedBits;
    }
}
