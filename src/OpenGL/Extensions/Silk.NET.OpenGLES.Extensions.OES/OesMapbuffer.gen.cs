// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_mapbuffer")]
    public unsafe partial class OesMapbuffer : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_mapbuffer";
        [NativeApi(EntryPoint = "glGetBufferPointervOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetBufferPointervOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glGetBufferPointervOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetBufferPointervOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glGetBufferPointervOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetBufferPointervOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glGetBufferPointervOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetBufferPointervOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glMapBufferOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void* MapBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES access);

        [NativeApi(EntryPoint = "glMapBufferOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void* MapBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferAccessARB access);

        [NativeApi(EntryPoint = "glMapBufferOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void* MapBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES access);

        [NativeApi(EntryPoint = "glMapBufferOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void* MapBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferAccessARB access);

        [NativeApi(EntryPoint = "glUnmapBufferOES", Convention = CallingConvention.Winapi)]
        public partial bool UnmapBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target);

        public unsafe void* GetBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname)
        {
            // NonKhrReturnTypeOverloader
            GetBufferPointer(target, pname, out void* silkRet);
            return silkRet;
        }

        public unsafe void* GetBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferPointerNameARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetBufferPointer(target, pname, out void* silkRet);
            return silkRet;
        }

        public unsafe void* GetBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname)
        {
            // NonKhrReturnTypeOverloader
            GetBufferPointer(target, pname, out void* silkRet);
            return silkRet;
        }

        public unsafe void* GetBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferPointerNameARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetBufferPointer(target, pname, out void* silkRet);
            return silkRet;
        }

        public OesMapbuffer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

