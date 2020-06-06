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

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_mapbuffer")]
    public unsafe partial class OesMapbuffer : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_mapbuffer";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetBufferPointervOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBufferPointer([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.Out)] void** @params)
            => ImplGetBufferPointer(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="access">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glMapBufferOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* MapBuffer([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES access)
            => ImplMapBuffer(target, access);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glUnmapBufferOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool UnmapBuffer([Flow(FlowDirection.In)] OES target)
            => ImplUnmapBuffer(target);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetBufferPointervOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBufferPointer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Flow(FlowDirection.Out)] void** @params)
            => ImplGetBufferPointer(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="access">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glMapBufferOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* MapBuffer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferAccessARB access)
            => ImplMapBuffer(target, access);

        public OesMapbuffer(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

