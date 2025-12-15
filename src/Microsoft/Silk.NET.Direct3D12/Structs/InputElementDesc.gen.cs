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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_INPUT_ELEMENT_DESC")]
    public unsafe partial struct InputElementDesc
    {
        public InputElementDesc
        (
            byte* semanticName = null,
            uint? semanticIndex = null,
            Silk.NET.DXGI.Format? format = null,
            uint? inputSlot = null,
            uint? alignedByteOffset = null,
            InputClassification? inputSlotClass = null,
            uint? instanceDataStepRate = null
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

            if (inputSlotClass is not null)
            {
                InputSlotClass = inputSlotClass.Value;
            }

            if (instanceDataStepRate is not null)
            {
                InstanceDataStepRate = instanceDataStepRate.Value;
            }
        }


        [NativeName("Type", "LPCSTR")]
        [NativeName("Type.Name", "LPCSTR")]
        [NativeName("Name", "SemanticName")]
        public byte* SemanticName;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SemanticIndex")]
        public uint SemanticIndex;

        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.DXGI.Format Format;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InputSlot")]
        public uint InputSlot;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "AlignedByteOffset")]
        public uint AlignedByteOffset;

        [NativeName("Type", "D3D12_INPUT_CLASSIFICATION")]
        [NativeName("Type.Name", "D3D12_INPUT_CLASSIFICATION")]
        [NativeName("Name", "InputSlotClass")]
        public InputClassification InputSlotClass;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InstanceDataStepRate")]
        public uint InstanceDataStepRate;
    }
}
