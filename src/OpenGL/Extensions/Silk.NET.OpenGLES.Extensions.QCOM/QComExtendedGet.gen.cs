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

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    [Extension("QCOM_extended_get")]
    public unsafe partial class QComExtendedGet : NativeExtension<GL>
    {
        public const string ExtensionName = "QCOM_extended_get";
        [NativeApi(EntryPoint = "glExtGetBufferPointervQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glExtGetBuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numBuffers);

        [NativeApi(EntryPoint = "glExtGetFramebuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* framebuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numFramebuffers);

        [NativeApi(EntryPoint = "glExtGetRenderbuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* renderbuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numRenderbuffers);

        [NativeApi(EntryPoint = "glExtGetTexLevelParameterivQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetTexLevelParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glExtGetTexSubImageQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetTexSubImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* texels);

        [NativeApi(EntryPoint = "glExtGetTexturesQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetTextures([Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* textures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxTextures, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numTextures);

        [NativeApi(EntryPoint = "glExtTexObjectStateOverrideiQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtTexObjectStateOverride([Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        public QComExtendedGet(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

