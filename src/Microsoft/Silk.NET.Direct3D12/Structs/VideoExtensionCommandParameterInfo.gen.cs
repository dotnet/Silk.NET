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
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO")]
    public unsafe partial struct VideoExtensionCommandParameterInfo
    {
        public VideoExtensionCommandParameterInfo
        (
            char* name = null,
            VideoExtensionCommandParameterType? type = null,
            VideoExtensionCommandParameterFlags? flags = null
        ) : this()
        {
            if (name is not null)
            {
                Name = name;
            }

            if (type is not null)
            {
                Type = type.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
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
