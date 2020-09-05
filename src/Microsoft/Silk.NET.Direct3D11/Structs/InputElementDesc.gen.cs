// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_INPUT_ELEMENT_DESC")]
    public unsafe partial struct InputElementDesc
    {
        public InputElementDesc
        (
            byte* semanticName = default,
            uint semanticIndex = default,
            DXGI_FORMAT format = default,
            uint inputSlot = default,
            uint alignedByteOffset = default,
            InputClassification inputSlotClass = default,
            uint instanceDataStepRate = default
        )
        {
            SemanticName = semanticName;
            SemanticIndex = semanticIndex;
            Format = format;
            InputSlot = inputSlot;
            AlignedByteOffset = alignedByteOffset;
            InputSlotClass = inputSlotClass;
            InstanceDataStepRate = instanceDataStepRate;
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
        public DXGI_FORMAT Format;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InputSlot")]
        public uint InputSlot;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "AlignedByteOffset")]
        public uint AlignedByteOffset;

        [NativeName("Type", "D3D11_INPUT_CLASSIFICATION")]
        [NativeName("Type.Name", "D3D11_INPUT_CLASSIFICATION")]
        [NativeName("Name", "InputSlotClass")]
        public InputClassification InputSlotClass;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InstanceDataStepRate")]
        public uint InstanceDataStepRate;
    }
}
