// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_vdpau_interop")]
    public abstract unsafe partial class NVVdpauInterop : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_vdpau_interop";
        [NativeApi(EntryPoint = "glVDPAUFiniNV")]
        public abstract void Vdpaufin();

        [NativeApi(EntryPoint = "glVDPAUGetSurfaceivNV")]
        public abstract unsafe void VdpaugetSurface([Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glVDPAUGetSurfaceivNV")]
        public abstract void VdpaugetSurface([Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values);

        [NativeApi(EntryPoint = "glVDPAUInitNV")]
        public abstract unsafe void Vdpauinit([Flow(FlowDirection.In)] void* vdpDevice, [Flow(FlowDirection.In)] void* getProcAddress);

        [NativeApi(EntryPoint = "glVDPAUInitNV")]
        public abstract void Vdpauinit<T0, T1>([Flow(FlowDirection.In)] Span<T0> vdpDevice, [Flow(FlowDirection.In)] Span<T1> getProcAddress) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glVDPAUIsSurfaceNV")]
        public abstract bool VdpauisSurface([Flow(FlowDirection.In)] IntPtr surface);

        [NativeApi(EntryPoint = "glVDPAUMapSurfacesNV")]
        public abstract unsafe void VdpaumapSurfaces([Flow(FlowDirection.In)] uint numSurfaces, [Count(Parameter = "numSurfaces"), Flow(FlowDirection.In)] IntPtr* surfaces);

        [NativeApi(EntryPoint = "glVDPAUMapSurfacesNV")]
        public abstract void VdpaumapSurfaces([Flow(FlowDirection.In)] uint numSurfaces, [Count(Parameter = "numSurfaces"), Flow(FlowDirection.In)] Span<IntPtr> surfaces);

        [NativeApi(EntryPoint = "glVDPAURegisterOutputSurfaceNV")]
        public abstract unsafe IntPtr VdpauregisterOutputSurface([Flow(FlowDirection.In)] void* vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] uint* textureNames);

        [NativeApi(EntryPoint = "glVDPAURegisterOutputSurfaceNV")]
        public abstract IntPtr VdpauregisterOutputSurface<T0>([Flow(FlowDirection.In)] Span<T0> vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] Span<uint> textureNames) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glVDPAURegisterVideoSurfaceNV")]
        public abstract unsafe IntPtr VdpauregisterVideoSurface([Flow(FlowDirection.In)] void* vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] uint* textureNames);

        [NativeApi(EntryPoint = "glVDPAURegisterVideoSurfaceNV")]
        public abstract IntPtr VdpauregisterVideoSurface<T0>([Flow(FlowDirection.In)] Span<T0> vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] Span<uint> textureNames) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glVDPAUSurfaceAccessNV")]
        public abstract void VdpausurfaceAccess([Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] NV access);

        [NativeApi(EntryPoint = "glVDPAUUnmapSurfacesNV")]
        public abstract unsafe void VdpauunmapSurfaces([Flow(FlowDirection.In)] uint numSurface, [Count(Parameter = "numSurface"), Flow(FlowDirection.In)] IntPtr* surfaces);

        [NativeApi(EntryPoint = "glVDPAUUnmapSurfacesNV")]
        public abstract void VdpauunmapSurfaces([Flow(FlowDirection.In)] uint numSurface, [Count(Parameter = "numSurface"), Flow(FlowDirection.In)] Span<IntPtr> surfaces);

        [NativeApi(EntryPoint = "glVDPAUUnregisterSurfaceNV")]
        public abstract void VdpauunregisterSurface([Flow(FlowDirection.In)] IntPtr surface);

        public unsafe void VdpaugetSurface([Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values)
        {
            // IntPtrOverloader
            VdpaugetSurface(new IntPtr(surface), pname, count, length, values);
        }

        public unsafe void VdpaugetSurface([Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // IntPtrOverloader
            VdpaugetSurface(new IntPtr(surface), pname, count, length, values);
        }

        public unsafe bool VdpauisSurface([Flow(FlowDirection.In)] int surface)
        {
            // IntPtrOverloader
            return VdpauisSurface(new IntPtr(surface));
        }

        public unsafe void VdpausurfaceAccess([Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.In)] NV access)
        {
            // IntPtrOverloader
            VdpausurfaceAccess(new IntPtr(surface), access);
        }

        public unsafe void VdpauunregisterSurface([Flow(FlowDirection.In)] int surface)
        {
            // IntPtrOverloader
            VdpauunregisterSurface(new IntPtr(surface));
        }

        public NVVdpauInterop(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

