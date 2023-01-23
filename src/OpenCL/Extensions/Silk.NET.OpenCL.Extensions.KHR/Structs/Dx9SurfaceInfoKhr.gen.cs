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

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [NativeName("Name", "cl_dx9_surface_info_khr")]
    public unsafe partial struct Dx9SurfaceInfoKhr
    {
        public Dx9SurfaceInfoKhr
        (
            void* resource = null,
            nint? sharedHandle = null
        ) : this()
        {
            if (resource is not null)
            {
                Resource = resource;
            }

            if (sharedHandle is not null)
            {
                SharedHandle = sharedHandle.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "IDirect3DSurface9*")]
        [NativeName("Type.Name", "IDirect3DSurface9")]
        [NativeName("Name", "resource")]
        public void* Resource;
/// <summary></summary>
        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "shared_handle")]
        public nint SharedHandle;
    }
}
