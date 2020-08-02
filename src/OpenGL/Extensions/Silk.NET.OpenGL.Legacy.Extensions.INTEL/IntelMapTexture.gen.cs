// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.INTEL
{
    [Extension("INTEL_map_texture")]
    public unsafe partial class IntelMapTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "INTEL_map_texture";
        [NativeApi(EntryPoint = "glMapTexture2DINTEL")]
        public unsafe partial void* MapTexture2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint access, [Count(Count = 1), Flow(FlowDirection.Out)] int* stride, [Count(Count = 1), Flow(FlowDirection.Out)] INTEL* layout);

        [NativeApi(EntryPoint = "glMapTexture2DINTEL")]
        public unsafe partial void* MapTexture2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint access, [Count(Count = 1), Flow(FlowDirection.Out)] out int stride, [Count(Count = 1), Flow(FlowDirection.Out)] out INTEL layout);

        [NativeApi(EntryPoint = "glSyncTextureINTEL")]
        public partial void SyncTexture([Flow(FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glUnmapTexture2DINTEL")]
        public partial void UnmapTexture2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        public IntelMapTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

