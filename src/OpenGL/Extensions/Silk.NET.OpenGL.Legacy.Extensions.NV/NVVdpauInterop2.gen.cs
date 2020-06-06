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
    [Extension("NV_vdpau_interop2")]
    public unsafe partial class NVVdpauInterop2 : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_vdpau_interop2";
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
        /// <param name="isFrameStructure">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glVDPAURegisterVideoSurfaceWithPictureStructureNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe IntPtr VdpauregisterVideoSurfaceWithPictureStructure([Flow(FlowDirection.In)] void* vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] uint* textureNames, [Flow(FlowDirection.In)] bool isFrameStructure)
            => ImplVdpauregisterVideoSurfaceWithPictureStructure(vdpSurface, target, numTextureNames, textureNames, isFrameStructure);

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
        /// <param name="isFrameStructure">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glVDPAURegisterVideoSurfaceWithPictureStructureNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public IntPtr VdpauregisterVideoSurfaceWithPictureStructure<T0>([Flow(FlowDirection.In)] Span<T0> vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] Span<uint> textureNames, [Flow(FlowDirection.In)] bool isFrameStructure) where T0 : unmanaged
            => ImplVdpauregisterVideoSurfaceWithPictureStructure<T0>(vdpSurface, target, numTextureNames, textureNames, isFrameStructure);

        public NVVdpauInterop2(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

