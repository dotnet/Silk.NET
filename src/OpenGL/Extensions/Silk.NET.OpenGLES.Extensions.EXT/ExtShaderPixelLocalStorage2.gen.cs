// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_shader_pixel_local_storage2")]
    public abstract unsafe partial class ExtShaderPixelLocalStorage2 : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_shader_pixel_local_storage2";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glClearPixelLocalStorageuiEXT")]
        public abstract unsafe void ClearPixelLocalStorage([Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glClearPixelLocalStorageuiEXT")]
        public abstract void ClearPixelLocalStorage([Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferPixelLocalStorageSizeEXT")]
        public abstract void FramebufferPixelLocalStorageSize([Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] uint size);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetFramebufferPixelLocalStorageSizeEXT")]
        public abstract uint GetFramebufferPixelLocalStorageSize([Flow(FlowDirection.In)] uint target);

        public ExtShaderPixelLocalStorage2(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

