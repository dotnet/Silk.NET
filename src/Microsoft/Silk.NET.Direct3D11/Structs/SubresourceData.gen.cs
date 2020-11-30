// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_SUBRESOURCE_DATA")]
    public unsafe partial struct SubresourceData
    {
        public SubresourceData
        (
            void* pSysMem = null,
            uint? sysMemPitch = null,
            uint? sysMemSlicePitch = null
        ) : this()
        {
            if (pSysMem is not null)
            {
                PSysMem = pSysMem;
            }

            if (sysMemPitch is not null)
            {
                SysMemPitch = sysMemPitch.Value;
            }

            if (sysMemSlicePitch is not null)
            {
                SysMemSlicePitch = sysMemSlicePitch.Value;
            }
        }


        [NativeName("Type", "const void *")]
        [NativeName("Type.Name", "const void *")]
        [NativeName("Name", "pSysMem")]
        public void* PSysMem;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SysMemPitch")]
        public uint SysMemPitch;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SysMemSlicePitch")]
        public uint SysMemSlicePitch;
    }
}
