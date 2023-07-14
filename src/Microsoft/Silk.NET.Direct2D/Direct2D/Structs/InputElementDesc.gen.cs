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

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_INPUT_ELEMENT_DESC")]
    public unsafe partial struct InputElementDesc
    {
        public InputElementDesc
        (
            byte* semanticName = null,
            uint? semanticIndex = null,
            Silk.NET.DXGI.Format? format = null,
            uint? inputSlot = null,
            uint? alignedByteOffset = null
        ) : this()
        {
            if (semanticName is not null)
            {
                SemanticName = semanticName;
            }

            if (semanticIndex is not null)
            {
                SemanticIndex = semanticIndex.Value;
            }

            if (format is not null)
            {
                Format = format.Value;
            }

            if (inputSlot is not null)
            {
                InputSlot = inputSlot.Value;
            }

            if (alignedByteOffset is not null)
            {
                AlignedByteOffset = alignedByteOffset.Value;
            }
        }


        [NativeName("Type", "PCSTR")]
        [NativeName("Type.Name", "PCSTR")]
        [NativeName("Name", "semanticName")]
        public byte* SemanticName;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "semanticIndex")]
        public uint SemanticIndex;

        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "format")]
        public Silk.NET.DXGI.Format Format;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "inputSlot")]
        public uint InputSlot;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "alignedByteOffset")]
        public uint AlignedByteOffset;
    }
}
