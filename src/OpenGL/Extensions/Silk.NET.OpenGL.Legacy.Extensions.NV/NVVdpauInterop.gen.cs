// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_vdpau_interop")]
    public unsafe partial class NVVdpauInterop : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_vdpau_interop";
        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glVDPAUFiniNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Vdpaufin()
            => ImplVdpaufin();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="surface">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glVDPAUGetSurfaceivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VdpaugetSurface([Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values)
            => ImplVdpaugetSurface(surface, pname, count, length, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="surface">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glVDPAUGetSurfaceivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VdpaugetSurface([Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
            => ImplVdpaugetSurface(surface, pname, count, length, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vdpDevice">
        /// To be added.
        /// </param>
        /// <param name="getProcAddress">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVDPAUInitNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Vdpauinit([Flow(FlowDirection.In)] void* vdpDevice, [Flow(FlowDirection.In)] void* getProcAddress)
            => ImplVdpauinit(vdpDevice, getProcAddress);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vdpDevice">
        /// To be added.
        /// </param>
        /// <param name="getProcAddress">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVDPAUInitNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Vdpauinit<T0, T1>([Flow(FlowDirection.In)] Span<T0> vdpDevice, [Flow(FlowDirection.In)] Span<T1> getProcAddress) where T0 : unmanaged where T1 : unmanaged
            => ImplVdpauinit<T0, T1>(vdpDevice, getProcAddress);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="surface">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glVDPAUIsSurfaceNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool VdpauisSurface([Flow(FlowDirection.In)] IntPtr surface)
            => ImplVdpauisSurface(surface);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="numSurfaces">
        /// To be added.
        /// </param>
        /// <param name="surfaces">
        /// To be added.
        /// This parameter's element count is taken from numSurfaces.
        /// </param>
        [NativeApi(EntryPoint = "glVDPAUMapSurfacesNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VdpaumapSurfaces([Flow(FlowDirection.In)] uint numSurfaces, [Count(Parameter = "numSurfaces"), Flow(FlowDirection.In)] IntPtr* surfaces)
            => ImplVdpaumapSurfaces(numSurfaces, surfaces);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="numSurfaces">
        /// To be added.
        /// </param>
        /// <param name="surfaces">
        /// To be added.
        /// This parameter's element count is taken from numSurfaces.
        /// </param>
        [NativeApi(EntryPoint = "glVDPAUMapSurfacesNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VdpaumapSurfaces([Flow(FlowDirection.In)] uint numSurfaces, [Count(Parameter = "numSurfaces"), Flow(FlowDirection.In)] Span<IntPtr> surfaces)
            => ImplVdpaumapSurfaces(numSurfaces, surfaces);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vdpSurface">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="numTextureNames">
        /// To be added.
        /// </param>
        /// <param name="textureNames">
        /// To be added.
        /// This parameter's element count is taken from numTextureNames.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glVDPAURegisterOutputSurfaceNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr VdpauregisterOutputSurface([Flow(FlowDirection.In)] void* vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] uint* textureNames)
            => ImplVdpauregisterOutputSurface(vdpSurface, target, numTextureNames, textureNames);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vdpSurface">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="numTextureNames">
        /// To be added.
        /// </param>
        /// <param name="textureNames">
        /// To be added.
        /// This parameter's element count is taken from numTextureNames.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glVDPAURegisterOutputSurfaceNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr VdpauregisterOutputSurface<T0>([Flow(FlowDirection.In)] Span<T0> vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] Span<uint> textureNames) where T0 : unmanaged
            => ImplVdpauregisterOutputSurface<T0>(vdpSurface, target, numTextureNames, textureNames);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vdpSurface">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="numTextureNames">
        /// To be added.
        /// </param>
        /// <param name="textureNames">
        /// To be added.
        /// This parameter's element count is taken from numTextureNames.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glVDPAURegisterVideoSurfaceNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr VdpauregisterVideoSurface([Flow(FlowDirection.In)] void* vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] uint* textureNames)
            => ImplVdpauregisterVideoSurface(vdpSurface, target, numTextureNames, textureNames);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vdpSurface">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="numTextureNames">
        /// To be added.
        /// </param>
        /// <param name="textureNames">
        /// To be added.
        /// This parameter's element count is taken from numTextureNames.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glVDPAURegisterVideoSurfaceNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr VdpauregisterVideoSurface<T0>([Flow(FlowDirection.In)] Span<T0> vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] Span<uint> textureNames) where T0 : unmanaged
            => ImplVdpauregisterVideoSurface<T0>(vdpSurface, target, numTextureNames, textureNames);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="surface">
        /// To be added.
        /// </param>
        /// <param name="access">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVDPAUSurfaceAccessNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VdpausurfaceAccess([Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] NV access)
            => ImplVdpausurfaceAccess(surface, access);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="numSurface">
        /// To be added.
        /// </param>
        /// <param name="surfaces">
        /// To be added.
        /// This parameter's element count is taken from numSurface.
        /// </param>
        [NativeApi(EntryPoint = "glVDPAUUnmapSurfacesNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VdpauunmapSurfaces([Flow(FlowDirection.In)] uint numSurface, [Count(Parameter = "numSurface"), Flow(FlowDirection.In)] IntPtr* surfaces)
            => ImplVdpauunmapSurfaces(numSurface, surfaces);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="numSurface">
        /// To be added.
        /// </param>
        /// <param name="surfaces">
        /// To be added.
        /// This parameter's element count is taken from numSurface.
        /// </param>
        [NativeApi(EntryPoint = "glVDPAUUnmapSurfacesNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VdpauunmapSurfaces([Flow(FlowDirection.In)] uint numSurface, [Count(Parameter = "numSurface"), Flow(FlowDirection.In)] Span<IntPtr> surfaces)
            => ImplVdpauunmapSurfaces(numSurface, surfaces);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="surface">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVDPAUUnregisterSurfaceNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VdpauunregisterSurface([Flow(FlowDirection.In)] IntPtr surface)
            => ImplVdpauunregisterSurface(surface);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="surface">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VdpaugetSurface([Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values)
        {
            // IntPtrOverloader
            VdpaugetSurface(new IntPtr(surface), pname, count, length, values);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="surface">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VdpaugetSurface([Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // IntPtrOverloader
            VdpaugetSurface(new IntPtr(surface), pname, count, length, values);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="surface">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe bool VdpauisSurface([Flow(FlowDirection.In)] int surface)
        {
            // IntPtrOverloader
            return VdpauisSurface(new IntPtr(surface));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="surface">
        /// To be added.
        /// </param>
        /// <param name="access">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VdpausurfaceAccess([Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.In)] NV access)
        {
            // IntPtrOverloader
            VdpausurfaceAccess(new IntPtr(surface), access);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="surface">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VdpauunregisterSurface([Flow(FlowDirection.In)] int surface)
        {
            // IntPtrOverloader
            VdpauunregisterSurface(new IntPtr(surface));
        }

        public NVVdpauInterop(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

