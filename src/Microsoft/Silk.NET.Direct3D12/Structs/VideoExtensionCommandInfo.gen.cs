// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_INFO")]
    public unsafe partial struct VideoExtensionCommandInfo
    {
        public VideoExtensionCommandInfo
        (
            Guid? commandId = null,
            char* name = null,
            CommandListSupportFlags? commandListSupportFlags = null
        ) : this()
        {
            if (commandId is not null)
            {
                CommandId = commandId.Value;
            }

            if (name is not null)
            {
                Name = name;
            }

            if (commandListSupportFlags is not null)
            {
                CommandListSupportFlags = commandListSupportFlags.Value;
            }
        }


        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "CommandId")]
        public Guid CommandId;

        [NativeName("Type", "LPCWSTR")]
        [NativeName("Type.Name", "LPCWSTR")]
        [NativeName("Name", "Name")]
        public char* Name;

        [NativeName("Type", "D3D12_COMMAND_LIST_SUPPORT_FLAGS")]
        [NativeName("Type.Name", "D3D12_COMMAND_LIST_SUPPORT_FLAGS")]
        [NativeName("Name", "CommandListSupportFlags")]
        public CommandListSupportFlags CommandListSupportFlags;
    }
}
