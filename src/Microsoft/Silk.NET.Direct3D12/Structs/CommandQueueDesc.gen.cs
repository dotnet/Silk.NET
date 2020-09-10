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
    [NativeName("Name", "D3D12_COMMAND_QUEUE_DESC")]
    public unsafe partial struct CommandQueueDesc
    {
        public CommandQueueDesc
        (
            CommandListType type = default,
            int priority = default,
            CommandQueueFlags flags = default,
            uint nodeMask = default
        )
        {
            Type = type;
            Priority = priority;
            Flags = flags;
            NodeMask = nodeMask;
        }


        [NativeName("Type", "D3D12_COMMAND_LIST_TYPE")]
        [NativeName("Type.Name", "D3D12_COMMAND_LIST_TYPE")]
        [NativeName("Name", "Type")]
        public CommandListType Type;

        [NativeName("Type", "INT")]
        [NativeName("Type.Name", "INT")]
        [NativeName("Name", "Priority")]
        public int Priority;

        [NativeName("Type", "D3D12_COMMAND_QUEUE_FLAGS")]
        [NativeName("Type.Name", "D3D12_COMMAND_QUEUE_FLAGS")]
        [NativeName("Name", "Flags")]
        public CommandQueueFlags Flags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeMask")]
        public uint NodeMask;
    }
}
