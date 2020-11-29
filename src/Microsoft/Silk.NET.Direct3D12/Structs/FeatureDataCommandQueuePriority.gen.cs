// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_FEATURE_DATA_COMMAND_QUEUE_PRIORITY")]
    public unsafe partial struct FeatureDataCommandQueuePriority
    {
        public FeatureDataCommandQueuePriority
        (
            CommandListType? commandListType = null,
            uint? priority = null,
            int? priorityForTypeIsSupported = null
        ) : this()
        {
            if (commandListType is not null)
            {
                CommandListType = commandListType.Value;
            }

            if (priority is not null)
            {
                Priority = priority.Value;
            }

            if (priorityForTypeIsSupported is not null)
            {
                PriorityForTypeIsSupported = priorityForTypeIsSupported.Value;
            }
        }


        [NativeName("Type", "D3D12_COMMAND_LIST_TYPE")]
        [NativeName("Type.Name", "D3D12_COMMAND_LIST_TYPE")]
        [NativeName("Name", "CommandListType")]
        public CommandListType CommandListType;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Priority")]
        public uint Priority;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "PriorityForTypeIsSupported")]
        public int PriorityForTypeIsSupported;
    }
}
