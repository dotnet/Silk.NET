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
    [NativeName("Name", "D3D11_SO_DECLARATION_ENTRY")]
    public unsafe partial struct SODeclarationEntry
    {
        public SODeclarationEntry
        (
            uint stream = default,
            byte* semanticName = default,
            uint semanticIndex = default,
            byte startComponent = default,
            byte componentCount = default,
            byte outputSlot = default
        )
        {
            Stream = stream;
            SemanticName = semanticName;
            SemanticIndex = semanticIndex;
            StartComponent = startComponent;
            ComponentCount = componentCount;
            OutputSlot = outputSlot;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Stream")]
        public uint Stream;

        [NativeName("Type", "LPCSTR")]
        [NativeName("Type.Name", "LPCSTR")]
        [NativeName("Name", "SemanticName")]
        public byte* SemanticName;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SemanticIndex")]
        public uint SemanticIndex;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "StartComponent")]
        public byte StartComponent;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "ComponentCount")]
        public byte ComponentCount;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "OutputSlot")]
        public byte OutputSlot;
    }
}
