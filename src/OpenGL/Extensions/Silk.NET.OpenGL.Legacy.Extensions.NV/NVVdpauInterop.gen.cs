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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_vdpau_interop")]
    public unsafe partial class NVVdpauInterop : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_vdpau_interop";
        [NativeApi(EntryPoint = "glVDPAUFiniNV", Convention = CallingConvention.Winapi)]
        public partial void Vdpaufin();

        [NativeApi(EntryPoint = "glVDPAUGetSurfaceivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VdpaugetSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glVDPAUInitNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vdpauinit([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* vdpDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* getProcAddress);

        [NativeApi(EntryPoint = "glVDPAUIsSurfaceNV", Convention = CallingConvention.Winapi)]
        public partial bool VdpauisSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface);

        [NativeApi(EntryPoint = "glVDPAUMapSurfacesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VdpaumapSurfaces([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSurfaces, [Count(Parameter = "numSurfaces"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* surfaces);

        [NativeApi(EntryPoint = "glVDPAURegisterOutputSurfaceNV", Convention = CallingConvention.Winapi)]
        public unsafe partial nint VdpauregisterOutputSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* vdpSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textureNames);

        [NativeApi(EntryPoint = "glVDPAURegisterVideoSurfaceNV", Convention = CallingConvention.Winapi)]
        public unsafe partial nint VdpauregisterVideoSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* vdpSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textureNames);

        [NativeApi(EntryPoint = "glVDPAUSurfaceAccessNV", Convention = CallingConvention.Winapi)]
        public partial void VdpausurfaceAccess([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV access);

        [NativeApi(EntryPoint = "glVDPAUUnmapSurfacesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VdpauunmapSurfaces([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSurface, [Count(Parameter = "numSurface"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* surfaces);

        [NativeApi(EntryPoint = "glVDPAUUnregisterSurfaceNV", Convention = CallingConvention.Winapi)]
        public partial void VdpauunregisterSurface([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint surface);

        public NVVdpauInterop(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

