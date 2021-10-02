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
    [NativeName("Name", "D3D12_COMMAND_QUEUE_DESC")]
    public unsafe partial struct CommandQueueDesc
    {
        public CommandQueueDesc
        (
            CommandListType? type = null,
            int? priority = null,
            CommandQueueFlags? flags = null,
            uint? nodeMask = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (priority is not null)
            {
                Priority = priority.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (nodeMask is not null)
            {
                NodeMask = nodeMask.Value;
            }
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
