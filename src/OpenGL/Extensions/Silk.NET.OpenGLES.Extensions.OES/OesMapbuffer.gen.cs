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

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_mapbuffer")]
    public abstract unsafe partial class OesMapbuffer : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBufferPointervOES")]
        public abstract unsafe void GetBufferPointer([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.Out)] void** @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMapBufferOES")]
        public abstract unsafe void* MapBuffer([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES access);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUnmapBufferOES")]
        public abstract bool UnmapBuffer([Flow(FlowDirection.In)] OES target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBufferPointervOES")]
        public abstract unsafe void GetBufferPointer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Flow(FlowDirection.Out)] void** @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMapBufferOES")]
        public abstract unsafe void* MapBuffer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferAccessARB access);

        public OesMapbuffer(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

