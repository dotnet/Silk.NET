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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMANDS")]
    public unsafe partial struct FeatureDataVideoExtensionCommands
    {
        public FeatureDataVideoExtensionCommands
        (
            uint nodeIndex = default,
            uint commandCount = default,
            VideoExtensionCommandInfo* pCommandInfos = default
        )
        {
            NodeIndex = nodeIndex;
            CommandCount = commandCount;
            PCommandInfos = pCommandInfos;
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
