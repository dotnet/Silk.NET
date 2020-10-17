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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_shader_image_load_store")]
    public unsafe partial class ExtShaderImageLoadStore : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_shader_image_load_store";
        [NativeApi(EntryPoint = "glBindImageTextureEXT")]
        public partial void BindImageTexture([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] EXT access, [Flow(FlowDirection.In)] int format);

        [NativeApi(EntryPoint = "glBindImageTextureEXT")]
        public partial void BindImageTexture([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] BufferAccessARB access, [Flow(FlowDirection.In)] int format);

        [NativeApi(EntryPoint = "glMemoryBarrierEXT")]
        public partial void MemoryBarrier([Flow(FlowDirection.In)] uint barriers);

        public ExtShaderImageLoadStore(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

