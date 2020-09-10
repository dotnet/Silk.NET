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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SIZE")]
    public unsafe partial struct FeatureDataVideoExtensionCommandSize
    {
        public FeatureDataVideoExtensionCommandSize
        (
            uint nodeIndex = default,
            Guid commandId = default,
            void* pCreationParameters = default,
            uint creationParametersSizeInBytes = default,
            ulong memoryPoolL0Size = default,
            ulong memoryPoolL1Size = default
        )
        {
            NodeIndex = nodeIndex;
            CommandId = commandId;
            PCreationParameters = pCreationParameters;
            CreationParametersSizeInBytes = creationParametersSizeInBytes;
            MemoryPoolL0Size = memoryPoolL0Size;
            MemoryPoolL1Size = memoryPoolL1Size;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeIndex")]
        public uint NodeIndex;

        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "CommandId")]
        public Guid CommandId;

        [NativeName("Type", "const void *")]
        [NativeName("Type.Name", "const void *")]
        [NativeName("Name", "pCreationParameters")]
        public void* PCreationParameters;

        [NativeName("Type", "SIZE_T")]
        [NativeName("Type.Name", "SIZE_T")]
        [NativeName("Name", "CreationParametersSizeInBytes")]
        public uint CreationParametersSizeInBytes;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "MemoryPoolL0Size")]
        public ulong MemoryPoolL0Size;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "MemoryPoolL1Size")]
        public ulong MemoryPoolL1Size;
    }
}
