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
    [NativeName("Name", "D3D12_SO_DECLARATION_ENTRY")]
    public unsafe partial struct SODeclarationEntry
    {
        public SODeclarationEntry
        (
            uint? stream = null,
            byte* semanticName = null,
            uint? semanticIndex = null,
            byte? startComponent = null,
            byte? componentCount = null,
            byte? outputSlot = null
        ) : this()
        {
            if (stream is not null)
            {
                Stream = stream.Value;
            }

            if (semanticName is not null)
            {
                SemanticName = semanticName;
            }

            if (semanticIndex is not null)
            {
                SemanticIndex = semanticIndex.Value;
            }

            if (startComponent is not null)
            {
                StartComponent = startComponent.Value;
            }

            if (componentCount is not null)
            {
                ComponentCount = componentCount.Value;
            }

            if (outputSlot is not null)
            {
                OutputSlot = outputSlot.Value;
            }
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
