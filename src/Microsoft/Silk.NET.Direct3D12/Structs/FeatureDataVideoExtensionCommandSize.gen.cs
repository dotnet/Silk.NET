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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SIZE")]
    public unsafe partial struct FeatureDataVideoExtensionCommandSize
    {
        public FeatureDataVideoExtensionCommandSize
        (
            uint? nodeIndex = null,
            Guid? commandId = null,
            void* pCreationParameters = null,
            nuint? creationParametersSizeInBytes = null,
            ulong? memoryPoolL0Size = null,
            ulong? memoryPoolL1Size = null
        ) : this()
        {
            if (nodeIndex is not null)
            {
                NodeIndex = nodeIndex.Value;
            }

            if (commandId is not null)
            {
                CommandId = commandId.Value;
            }

            if (pCreationParameters is not null)
            {
                PCreationParameters = pCreationParameters;
            }

            if (creationParametersSizeInBytes is not null)
            {
                CreationParametersSizeInBytes = creationParametersSizeInBytes.Value;
            }

            if (memoryPoolL0Size is not null)
            {
                MemoryPoolL0Size = memoryPoolL0Size.Value;
            }

            if (memoryPoolL1Size is not null)
            {
                MemoryPoolL1Size = memoryPoolL1Size.Value;
            }
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
        public nuint CreationParametersSizeInBytes;

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
