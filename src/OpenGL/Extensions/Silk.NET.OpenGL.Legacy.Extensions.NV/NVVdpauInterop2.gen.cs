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
    [Extension("NV_vdpau_interop2")]
    public abstract unsafe partial class NVVdpauInterop2 : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_vdpau_interop2";
        [NativeApi(EntryPoint = "glVDPAURegisterVideoSurfaceWithPictureStructureNV")]
        public abstract unsafe IntPtr VdpauregisterVideoSurfaceWithPictureStructure([Flow(FlowDirection.In)] void* vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] uint* textureNames, [Flow(FlowDirection.In)] bool isFrameStructure);

        [NativeApi(EntryPoint = "glVDPAURegisterVideoSurfaceWithPictureStructureNV")]
        public abstract IntPtr VdpauregisterVideoSurfaceWithPictureStructure<T0>([Flow(FlowDirection.In)] Span<T0> vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] Span<uint> textureNames, [Flow(FlowDirection.In)] bool isFrameStructure) where T0 : unmanaged;

        public NVVdpauInterop2(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

