// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_multiview_draw_buffers")]
    public unsafe partial class ExtMultiviewDrawBuffers : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_multiview_draw_buffers";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDrawBuffersIndexedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DrawBuffersIndexed([Flow(FlowDirection.In)] int n, [Count(Parameter = "n"), Flow(FlowDirection.In)] EXT* location, [Count(Parameter = "n"), Flow(FlowDirection.In)] int* indices)
            => ImplDrawBuffersIndexed(n, location, indices);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        /// <param name="indices">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDrawBuffersIndexedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawBuffersIndexed([Flow(FlowDirection.In)] int n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<EXT> location, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<int> indices)
            => ImplDrawBuffersIndexed(n, location, indices);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetIntegeri_vEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetInteger([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] int* data)
            => ImplGetInteger(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetIntegeri_vEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetInteger([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] Span<int> data)
            => ImplGetInteger(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="src">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glReadBufferIndexedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ReadBufferIndexed([Flow(FlowDirection.In)] EXT src, [Flow(FlowDirection.In)] int index)
            => ImplReadBufferIndexed(src, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="src">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glReadBufferIndexedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ReadBufferIndexed([Flow(FlowDirection.In)] ReadBufferMode src, [Flow(FlowDirection.In)] int index)
            => ImplReadBufferIndexed(src, index);

        public ExtMultiviewDrawBuffers(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

