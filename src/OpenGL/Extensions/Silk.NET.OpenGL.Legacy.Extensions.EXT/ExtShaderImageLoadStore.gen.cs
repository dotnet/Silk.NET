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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_shader_image_load_store")]
    public abstract unsafe partial class ExtShaderImageLoadStore : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_shader_image_load_store";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="layered">
        /// To be added.
        /// </param>
        /// <param name="layer">
        /// To be added.
        /// </param>
        /// <param name="access">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindImageTextureEXT")]
        public abstract void BindImageTexture([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] EXT access, [Flow(FlowDirection.In)] int format);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="barriers">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMemoryBarrierEXT")]
        public abstract void MemoryBarrier([Flow(FlowDirection.In)] uint barriers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="layered">
        /// To be added.
        /// </param>
        /// <param name="layer">
        /// To be added.
        /// </param>
        /// <param name="access">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindImageTextureEXT")]
        public abstract void BindImageTexture([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] BufferAccessARB access, [Flow(FlowDirection.In)] int format);

        public ExtShaderImageLoadStore(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

