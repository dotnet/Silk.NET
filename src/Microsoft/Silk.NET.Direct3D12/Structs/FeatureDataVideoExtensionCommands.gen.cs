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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMANDS")]
    public unsafe partial struct FeatureDataVideoExtensionCommands
    {
        public FeatureDataVideoExtensionCommands
        (
            uint? nodeIndex = null,
            uint? commandCount = null,
            VideoExtensionCommandInfo* pCommandInfos = null
        ) : this()
        {
            if (nodeIndex is not null)
            {
                NodeIndex = nodeIndex.Value;
            }

            if (commandCount is not null)
            {
                CommandCount = commandCount.Value;
            }

            if (pCommandInfos is not null)
            {
                PCommandInfos = pCommandInfos;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeIndex")]
        public uint NodeIndex;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "CommandCount")]
        public uint CommandCount;

        [NativeName("Type", "D3D12_VIDEO_EXTENSION_COMMAND_INFO *")]
        [NativeName("Type.Name", "D3D12_VIDEO_EXTENSION_COMMAND_INFO *")]
        [NativeName("Name", "pCommandInfos")]
        public VideoExtensionCommandInfo* PCommandInfos;
    }
}
