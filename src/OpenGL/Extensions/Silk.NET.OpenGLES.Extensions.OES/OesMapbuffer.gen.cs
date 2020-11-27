// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_mapbuffer")]
    public unsafe partial class OesMapbuffer : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_mapbuffer";
        [NativeApi(EntryPoint = "glGetBufferPointervOES")]
        public unsafe partial void GetBufferPointer([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetBufferPointervOES")]
        public unsafe partial void GetBufferPointer([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glGetBufferPointervOES")]
        public unsafe partial void GetBufferPointer([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetBufferPointervOES")]
        public unsafe partial void GetBufferPointer([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glGetBufferPointervOES")]
        public unsafe partial void GetBufferPointer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] OES pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetBufferPointervOES")]
        public unsafe partial void GetBufferPointer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] OES pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glGetBufferPointervOES")]
        public unsafe partial void GetBufferPointer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetBufferPointervOES")]
        public unsafe partial void GetBufferPointer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glMapBufferOES")]
        public unsafe partial void* MapBuffer([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES access);

        [NativeApi(EntryPoint = "glMapBufferOES")]
        public unsafe partial void* MapBuffer([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] BufferAccessARB access);

        [NativeApi(EntryPoint = "glMapBufferOES")]
        public unsafe partial void* MapBuffer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] OES access);

        [NativeApi(EntryPoint = "glMapBufferOES")]
        public unsafe partial void* MapBuffer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferAccessARB access);

        [NativeApi(EntryPoint = "glUnmapBufferOES")]
        public partial bool UnmapBuffer([Flow(FlowDirection.In)] OES target);

        public OesMapbuffer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

