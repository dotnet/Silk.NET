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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_META_COMMAND_PARAMETER_DESC")]
    public unsafe partial struct MetaCommandParameterDesc
    {
        public MetaCommandParameterDesc
        (
            char* name = default,
            MetaCommandParameterType type = default,
            MetaCommandParameterFlags flags = default,
            ResourceStates requiredResourceState = default,
            uint structureOffset = default
        )
        {
            Name = name;
            Type = type;
            Flags = flags;
            RequiredResourceState = requiredResourceState;
            StructureOffset = structureOffset;
        }


        [NativeName("Type", "LPCWSTR")]
        [NativeName("Type.Name", "LPCWSTR")]
        [NativeName("Name", "Name")]
        public char* Name;

        [NativeName("Type", "D3D12_META_COMMAND_PARAMETER_TYPE")]
        [NativeName("Type.Name", "D3D12_META_COMMAND_PARAMETER_TYPE")]
        [NativeName("Name", "Type")]
        public MetaCommandParameterType Type;

        [NativeName("Type", "D3D12_META_COMMAND_PARAMETER_FLAGS")]
        [NativeName("Type.Name", "D3D12_META_COMMAND_PARAMETER_FLAGS")]
        [NativeName("Name", "Flags")]
        public MetaCommandParameterFlags Flags;

        [NativeName("Type", "D3D12_RESOURCE_STATES")]
        [NativeName("Type.Name", "D3D12_RESOURCE_STATES")]
        [NativeName("Name", "RequiredResourceState")]
        public ResourceStates RequiredResourceState;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "StructureOffset")]
        public uint StructureOffset;
    }
}
