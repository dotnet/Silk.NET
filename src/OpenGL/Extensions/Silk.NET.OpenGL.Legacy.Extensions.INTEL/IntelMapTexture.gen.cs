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

namespace Silk.NET.OpenGL.Legacy.Extensions.INTEL
{
    [Extension("INTEL_map_texture")]
    public unsafe partial class IntelMapTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "INTEL_map_texture";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="access">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="layout">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glMapTexture2DINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* MapTexture2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint access, [Count(Count = 1), Flow(FlowDirection.Out)] int* stride, [Count(Count = 1), Flow(FlowDirection.Out)] INTEL* layout)
            => ImplMapTexture2D(texture, level, access, stride, layout);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="access">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="layout">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glMapTexture2DINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* MapTexture2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint access, [Count(Count = 1), Flow(FlowDirection.Out)] out int stride, [Count(Count = 1), Flow(FlowDirection.Out)] out INTEL layout)
            => ImplMapTexture2D(texture, level, access, stride, layout);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSyncTextureINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SyncTexture([Flow(FlowDirection.In)] uint texture)
            => ImplSyncTexture(texture);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUnmapTexture2DINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void UnmapTexture2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level)
            => ImplUnmapTexture2D(texture, level);

        public IntelMapTexture(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

