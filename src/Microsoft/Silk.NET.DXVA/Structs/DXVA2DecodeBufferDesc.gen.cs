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
    [NativeName("Name", "_DXVA2_DecodeBufferDesc")]
    public unsafe partial struct DXVA2DecodeBufferDesc
    {
        public DXVA2DecodeBufferDesc
        (
            int? compressedBufferType = null,
            uint? bufferIndex = null,
            uint? dataOffset = null,
            uint? dataSize = null,
            uint? firstMBaddress = null,
            uint? numMBsInBuffer = null,
            uint? width = null,
            uint? height = null,
            uint? stride = null,
            uint? reservedBits = null,
            void* pvPVPState = null
        ) : this()
        {
            if (compressedBufferType is not null)
            {
                CompressedBufferType = compressedBufferType.Value;
            }

            if (bufferIndex is not null)
            {
                BufferIndex = bufferIndex.Value;
            }

            if (dataOffset is not null)
            {
                DataOffset = dataOffset.Value;
            }

            if (dataSize is not null)
            {
                DataSize = dataSize.Value;
            }

            if (firstMBaddress is not null)
            {
                FirstMBaddress = firstMBaddress.Value;
            }

            if (numMBsInBuffer is not null)
            {
                NumMBsInBuffer = numMBsInBuffer.Value;
            }

            if (width is not null)
            {
                Width = width.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (stride is not null)
            {
                Stride = stride.Value;
            }

            if (reservedBits is not null)
            {
                ReservedBits = reservedBits.Value;
            }

            if (pvPVPState is not null)
            {
                PvPVPState = pvPVPState;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "CompressedBufferType")]
        public int CompressedBufferType;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BufferIndex")]
        public uint BufferIndex;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DataOffset")]
        public uint DataOffset;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DataSize")]
        public uint DataSize;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FirstMBaddress")]
        public uint FirstMBaddress;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumMBsInBuffer")]
        public uint NumMBsInBuffer;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Width")]
        public uint Width;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Height")]
        public uint Height;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Stride")]
        public uint Stride;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ReservedBits")]
        public uint ReservedBits;

        [NativeName("Type", "PVOID")]
        [NativeName("Type.Name", "PVOID")]
        [NativeName("Name", "pvPVPState")]
        public void* PvPVPState;
    }
}
