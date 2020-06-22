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
    [Extension("NV_geometry_program4")]
    public abstract unsafe partial class NVGeometryProgram4 : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_geometry_program4";
        [NativeApi(EntryPoint = "glFramebufferTextureEXT")]
        public abstract void FramebufferTexture([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTextureFaceEXT")]
        public abstract void FramebufferTextureFace([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] NV face);

        [NativeApi(EntryPoint = "glFramebufferTextureLayerEXT")]
        public abstract void FramebufferTextureLayer([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glProgramVertexLimitNV")]
        public abstract void ProgramVertexLimit([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] int limit);

        [NativeApi(EntryPoint = "glFramebufferTextureEXT")]
        public abstract void FramebufferTexture([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTextureFaceEXT")]
        public abstract void FramebufferTextureFace([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] TextureTarget face);

        [NativeApi(EntryPoint = "glFramebufferTextureLayerEXT")]
        public abstract void FramebufferTextureLayer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glProgramVertexLimitNV")]
        public abstract void ProgramVertexLimit([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] int limit);

        public NVGeometryProgram4(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

