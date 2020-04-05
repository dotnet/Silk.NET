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

namespace Silk.NET.OpenGL.Legacy.Extensions.INTEL
{
    [Extension("INTEL_map_texture")]
    public abstract unsafe partial class IntelMapTexture : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMapTexture2DINTEL")]
        public abstract unsafe void* MapTexture2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint access, [Count(Count = 1), Flow(FlowDirection.Out)] int* stride, [Count(Count = 1), Flow(FlowDirection.Out)] INTEL* layout);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMapTexture2DINTEL")]
        public abstract unsafe void* MapTexture2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint access, [Count(Count = 1), Flow(FlowDirection.Out)] out int stride, [Count(Count = 1), Flow(FlowDirection.Out)] out INTEL layout);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSyncTextureINTEL")]
        public abstract void SyncTexture([Flow(FlowDirection.In)] uint texture);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUnmapTexture2DINTEL")]
        public abstract void UnmapTexture2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        public IntelMapTexture(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

