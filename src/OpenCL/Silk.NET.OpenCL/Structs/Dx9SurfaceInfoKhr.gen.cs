// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_dx9_surface_info_khr")]
    public unsafe partial struct Dx9SurfaceInfoKhr
    {
        public Dx9SurfaceInfoKhr
        (
            IntPtr resource = default,
            IntPtr sharedHandle = default
        )
        {
            Resource = resource;
            SharedHandle = sharedHandle;
        }

/// <summary></summary>
        [NativeName("Type", "IDirect3DSurface9*")]
        [NativeName("Type.Name", "IDirect3DSurface9")]
        [NativeName("Name", "resource")]
        public IntPtr Resource;
/// <summary></summary>
        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "shared_handle")]
        public IntPtr SharedHandle;
    }
}
