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
    [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO")]
    public unsafe partial struct VideoExtensionCommandParameterInfo
    {
        public VideoExtensionCommandParameterInfo
        (
            char* name = default,
            VideoExtensionCommandParameterType type = default,
            VideoExtensionCommandParameterFlags flags = default
        )
        {
            Name = name;
            Type = type;
            Flags = flags;
        }


        [NativeName("Type", "LPCWSTR")]
        [NativeName("Type.Name", "LPCWSTR")]
        [NativeName("Name", "Name")]
        public char* Name;

        [NativeName("Type", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE")]
        [NativeName("Type.Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE")]
        [NativeName("Name", "Type")]
        public VideoExtensionCommandParameterType Type;

        [NativeName("Type", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAGS")]
        [NativeName("Name", "Flags")]
        public VideoExtensionCommandParameterFlags Flags;
    }
}
