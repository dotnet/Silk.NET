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
        public unsafe partial void VdpaugetSurface([Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glVDPAUGetSurfaceivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VdpaugetSurface([Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glVDPAUGetSurfaceivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VdpaugetSurface([Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glVDPAUGetSurfaceivNV", Convention = CallingConvention.Winapi)]
        public partial void VdpaugetSurface([Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glVDPAUInitNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vdpauinit([Flow(FlowDirection.In)] void* vdpDevice, [Flow(FlowDirection.In)] void* getProcAddress);

        [NativeApi(EntryPoint = "glVDPAUInitNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vdpauinit<T0>([Flow(FlowDirection.In)] void* vdpDevice, [Flow(FlowDirection.In)] in T0 getProcAddress) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glVDPAUInitNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vdpauinit<T0>([Flow(FlowDirection.In)] in T0 vdpDevice, [Flow(FlowDirection.In)] void* getProcAddress) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glVDPAUInitNV", Convention = CallingConvention.Winapi)]
        public partial void Vdpauinit<T0, T1>([Flow(FlowDirection.In)] in T0 vdpDevice, [Flow(FlowDirection.In)] in T1 getProcAddress) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glVDPAUIsSurfaceNV", Convention = CallingConvention.Winapi)]
        public partial bool VdpauisSurface([Flow(FlowDirection.In)] nint surface);

        [NativeApi(EntryPoint = "glVDPAUMapSurfacesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VdpaumapSurfaces([Flow(FlowDirection.In)] uint numSurfaces, [Count(Parameter = "numSurfaces"), Flow(FlowDirection.In)] nint* surfaces);

        [NativeApi(EntryPoint = "glVDPAUMapSurfacesNV", Convention = CallingConvention.Winapi)]
        public partial void VdpaumapSurfaces([Flow(FlowDirection.In)] uint numSurfaces, [Count(Parameter = "numSurfaces"), Flow(FlowDirection.In)] in nint surfaces);

        [NativeApi(EntryPoint = "glVDPAURegisterOutputSurfaceNV", Convention = CallingConvention.Winapi)]
        public unsafe partial nint VdpauregisterOutputSurface([Flow(FlowDirection.In)] void* vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] uint* textureNames);

        [NativeApi(EntryPoint = "glVDPAURegisterOutputSurfaceNV", Convention = CallingConvention.Winapi)]
        public unsafe partial nint VdpauregisterOutputSurface([Flow(FlowDirection.In)] void* vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] in uint textureNames);

        [NativeApi(EntryPoint = "glVDPAURegisterOutputSurfaceNV", Convention = CallingConvention.Winapi)]
        public unsafe partial nint VdpauregisterOutputSurface<T0>([Flow(FlowDirection.In)] in T0 vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] uint* textureNames) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glVDPAURegisterOutputSurfaceNV", Convention = CallingConvention.Winapi)]
        public partial nint VdpauregisterOutputSurface<T0>([Flow(FlowDirection.In)] in T0 vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] in uint textureNames) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glVDPAURegisterVideoSurfaceNV", Convention = CallingConvention.Winapi)]
        public unsafe partial nint VdpauregisterVideoSurface([Flow(FlowDirection.In)] void* vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] uint* textureNames);

        [NativeApi(EntryPoint = "glVDPAURegisterVideoSurfaceNV", Convention = CallingConvention.Winapi)]
        public unsafe partial nint VdpauregisterVideoSurface([Flow(FlowDirection.In)] void* vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] in uint textureNames);

        [NativeApi(EntryPoint = "glVDPAURegisterVideoSurfaceNV", Convention = CallingConvention.Winapi)]
        public unsafe partial nint VdpauregisterVideoSurface<T0>([Flow(FlowDirection.In)] in T0 vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] uint* textureNames) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glVDPAURegisterVideoSurfaceNV", Convention = CallingConvention.Winapi)]
        public partial nint VdpauregisterVideoSurface<T0>([Flow(FlowDirection.In)] in T0 vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] in uint textureNames) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glVDPAUSurfaceAccessNV", Convention = CallingConvention.Winapi)]
        public partial void VdpausurfaceAccess([Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] NV access);

        [NativeApi(EntryPoint = "glVDPAUUnmapSurfacesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VdpauunmapSurfaces([Flow(FlowDirection.In)] uint numSurface, [Count(Parameter = "numSurface"), Flow(FlowDirection.In)] nint* surfaces);

        [NativeApi(EntryPoint = "glVDPAUUnmapSurfacesNV", Convention = CallingConvention.Winapi)]
        public partial void VdpauunmapSurfaces([Flow(FlowDirection.In)] uint numSurface, [Count(Parameter = "numSurface"), Flow(FlowDirection.In)] in nint surfaces);

        [NativeApi(EntryPoint = "glVDPAUUnregisterSurfaceNV", Convention = CallingConvention.Winapi)]
        public partial void VdpauunregisterSurface([Flow(FlowDirection.In)] nint surface);

        public unsafe void VdpaugetSurface([Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // ImplicitCountSpanOverloader
            VdpaugetSurface(surface, pname, (uint) values.Length, length, out values.GetPinnableReference());
        }

        public unsafe void VdpaugetSurface([Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // ImplicitCountSpanOverloader
            VdpaugetSurface(surface, pname, (uint) values.Length, out length, out values.GetPinnableReference());
        }

        public unsafe void VdpaumapSurfaces([Count(Parameter = "numSurfaces"), Flow(FlowDirection.In)] ReadOnlySpan<nint> surfaces)
        {
            // ImplicitCountSpanOverloader
            VdpaumapSurfaces((uint) surfaces.Length, in surfaces.GetPinnableReference());
        }

        public unsafe nint VdpauregisterOutputSurface([Flow(FlowDirection.In)] void* vdpSurface, [Flow(FlowDirection.In)] NV target, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] ReadOnlySpan<uint> textureNames)
        {
            // ImplicitCountSpanOverloader
            return VdpauregisterOutputSurface(vdpSurface, target, (uint) textureNames.Length, in textureNames.GetPinnableReference());
        }

        public unsafe nint VdpauregisterOutputSurface<T0>([Flow(FlowDirection.In)] in T0 vdpSurface, [Flow(FlowDirection.In)] NV target, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] ReadOnlySpan<uint> textureNames) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            return VdpauregisterOutputSurface(in vdpSurface, target, (uint) textureNames.Length, in textureNames.GetPinnableReference());
        }

        public unsafe nint VdpauregisterVideoSurface([Flow(FlowDirection.In)] void* vdpSurface, [Flow(FlowDirection.In)] NV target, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] ReadOnlySpan<uint> textureNames)
        {
            // ImplicitCountSpanOverloader
            return VdpauregisterVideoSurface(vdpSurface, target, (uint) textureNames.Length, in textureNames.GetPinnableReference());
        }

        public unsafe nint VdpauregisterVideoSurface<T0>([Flow(FlowDirection.In)] in T0 vdpSurface, [Flow(FlowDirection.In)] NV target, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] ReadOnlySpan<uint> textureNames) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            return VdpauregisterVideoSurface(in vdpSurface, target, (uint) textureNames.Length, in textureNames.GetPinnableReference());
        }

        public unsafe void VdpauunmapSurfaces([Count(Parameter = "numSurface"), Flow(FlowDirection.In)] ReadOnlySpan<nint> surfaces)
        {
            // ImplicitCountSpanOverloader
            VdpauunmapSurfaces((uint) surfaces.Length, in surfaces.GetPinnableReference());
        }

        public NVVdpauInterop(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

