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
        public unsafe partial void ExtGetBufferPointer([Flow(FlowDirection.In)] QCOM target, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glExtGetBufferPointervQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetBufferPointer([Flow(FlowDirection.In)] QCOM target, [Count(Count = 1), Flow(FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glExtGetBuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(FlowDirection.Out)] uint* buffers, [Flow(FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(FlowDirection.Out)] int* numBuffers);

        [NativeApi(EntryPoint = "glExtGetBuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(FlowDirection.Out)] uint* buffers, [Flow(FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(FlowDirection.Out)] out int numBuffers);

        [NativeApi(EntryPoint = "glExtGetBuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(FlowDirection.Out)] out uint buffers, [Flow(FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(FlowDirection.Out)] int* numBuffers);

        [NativeApi(EntryPoint = "glExtGetBuffersQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(FlowDirection.Out)] out uint buffers, [Flow(FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(FlowDirection.Out)] out int numBuffers);

        [NativeApi(EntryPoint = "glExtGetBuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(FlowDirection.Out)] Buffer* buffers, [Flow(FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(FlowDirection.Out)] int* numBuffers);

        [NativeApi(EntryPoint = "glExtGetBuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(FlowDirection.Out)] Buffer* buffers, [Flow(FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(FlowDirection.Out)] out int numBuffers);

        [NativeApi(EntryPoint = "glExtGetBuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(FlowDirection.Out)] out Buffer buffers, [Flow(FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(FlowDirection.Out)] int* numBuffers);

        [NativeApi(EntryPoint = "glExtGetBuffersQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(FlowDirection.Out)] out Buffer buffers, [Flow(FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(FlowDirection.Out)] out int numBuffers);

        [NativeApi(EntryPoint = "glExtGetFramebuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(FlowDirection.Out)] uint* framebuffers, [Flow(FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(FlowDirection.Out)] int* numFramebuffers);

        [NativeApi(EntryPoint = "glExtGetFramebuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(FlowDirection.Out)] uint* framebuffers, [Flow(FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(FlowDirection.Out)] out int numFramebuffers);

        [NativeApi(EntryPoint = "glExtGetFramebuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(FlowDirection.Out)] out uint framebuffers, [Flow(FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(FlowDirection.Out)] int* numFramebuffers);

        [NativeApi(EntryPoint = "glExtGetFramebuffersQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(FlowDirection.Out)] out uint framebuffers, [Flow(FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(FlowDirection.Out)] out int numFramebuffers);

        [NativeApi(EntryPoint = "glExtGetFramebuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(FlowDirection.Out)] Framebuffer* framebuffers, [Flow(FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(FlowDirection.Out)] int* numFramebuffers);

        [NativeApi(EntryPoint = "glExtGetFramebuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(FlowDirection.Out)] Framebuffer* framebuffers, [Flow(FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(FlowDirection.Out)] out int numFramebuffers);

        [NativeApi(EntryPoint = "glExtGetFramebuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(FlowDirection.Out)] out Framebuffer framebuffers, [Flow(FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(FlowDirection.Out)] int* numFramebuffers);

        [NativeApi(EntryPoint = "glExtGetFramebuffersQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(FlowDirection.Out)] out Framebuffer framebuffers, [Flow(FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(FlowDirection.Out)] out int numFramebuffers);

        [NativeApi(EntryPoint = "glExtGetRenderbuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(FlowDirection.Out)] uint* renderbuffers, [Flow(FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(FlowDirection.Out)] int* numRenderbuffers);

        [NativeApi(EntryPoint = "glExtGetRenderbuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(FlowDirection.Out)] uint* renderbuffers, [Flow(FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(FlowDirection.Out)] out int numRenderbuffers);

        [NativeApi(EntryPoint = "glExtGetRenderbuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(FlowDirection.Out)] out uint renderbuffers, [Flow(FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(FlowDirection.Out)] int* numRenderbuffers);

        [NativeApi(EntryPoint = "glExtGetRenderbuffersQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(FlowDirection.Out)] out uint renderbuffers, [Flow(FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(FlowDirection.Out)] out int numRenderbuffers);

        [NativeApi(EntryPoint = "glExtGetRenderbuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(FlowDirection.Out)] Renderbuffer* renderbuffers, [Flow(FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(FlowDirection.Out)] int* numRenderbuffers);

        [NativeApi(EntryPoint = "glExtGetRenderbuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(FlowDirection.Out)] Renderbuffer* renderbuffers, [Flow(FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(FlowDirection.Out)] out int numRenderbuffers);

        [NativeApi(EntryPoint = "glExtGetRenderbuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(FlowDirection.Out)] out Renderbuffer renderbuffers, [Flow(FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(FlowDirection.Out)] int* numRenderbuffers);

        [NativeApi(EntryPoint = "glExtGetRenderbuffersQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(FlowDirection.Out)] out Renderbuffer renderbuffers, [Flow(FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(FlowDirection.Out)] out int numRenderbuffers);

        [NativeApi(EntryPoint = "glExtGetTexLevelParameterivQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetTexLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] QCOM face, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] QCOM pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glExtGetTexLevelParameterivQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetTexLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] QCOM face, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] QCOM pname, [Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glExtGetTexSubImageQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetTexSubImage([Flow(FlowDirection.In)] QCOM target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] QCOM format, [Flow(FlowDirection.In)] QCOM type, [Flow(FlowDirection.Out)] void* texels);

        [NativeApi(EntryPoint = "glExtGetTexSubImageQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetTexSubImage<T0>([Flow(FlowDirection.In)] QCOM target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] QCOM format, [Flow(FlowDirection.In)] QCOM type, [Flow(FlowDirection.Out)] out T0 texels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glExtGetTexSubImageQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetTexSubImage([Flow(FlowDirection.In)] QCOM target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] QCOM format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.Out)] void* texels);

        [NativeApi(EntryPoint = "glExtGetTexSubImageQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetTexSubImage<T0>([Flow(FlowDirection.In)] QCOM target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] QCOM format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.Out)] out T0 texels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glExtGetTexSubImageQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetTexSubImage([Flow(FlowDirection.In)] QCOM target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] QCOM type, [Flow(FlowDirection.Out)] void* texels);

        [NativeApi(EntryPoint = "glExtGetTexSubImageQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetTexSubImage<T0>([Flow(FlowDirection.In)] QCOM target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] QCOM type, [Flow(FlowDirection.Out)] out T0 texels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glExtGetTexSubImageQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetTexSubImage([Flow(FlowDirection.In)] QCOM target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.Out)] void* texels);

        [NativeApi(EntryPoint = "glExtGetTexSubImageQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetTexSubImage<T0>([Flow(FlowDirection.In)] QCOM target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.Out)] out T0 texels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glExtGetTexturesQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetTextures([Flow(FlowDirection.Out)] uint* textures, [Flow(FlowDirection.In)] int maxTextures, [Flow(FlowDirection.Out)] int* numTextures);

        [NativeApi(EntryPoint = "glExtGetTexturesQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetTextures([Flow(FlowDirection.Out)] uint* textures, [Flow(FlowDirection.In)] int maxTextures, [Flow(FlowDirection.Out)] out int numTextures);

        [NativeApi(EntryPoint = "glExtGetTexturesQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetTextures([Flow(FlowDirection.Out)] out uint textures, [Flow(FlowDirection.In)] int maxTextures, [Flow(FlowDirection.Out)] int* numTextures);

        [NativeApi(EntryPoint = "glExtGetTexturesQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetTextures([Flow(FlowDirection.Out)] out uint textures, [Flow(FlowDirection.In)] int maxTextures, [Flow(FlowDirection.Out)] out int numTextures);

        [NativeApi(EntryPoint = "glExtGetTexturesQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetTextures([Flow(FlowDirection.Out)] Texture* textures, [Flow(FlowDirection.In)] int maxTextures, [Flow(FlowDirection.Out)] int* numTextures);

        [NativeApi(EntryPoint = "glExtGetTexturesQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetTextures([Flow(FlowDirection.Out)] Texture* textures, [Flow(FlowDirection.In)] int maxTextures, [Flow(FlowDirection.Out)] out int numTextures);

        [NativeApi(EntryPoint = "glExtGetTexturesQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetTextures([Flow(FlowDirection.Out)] out Texture textures, [Flow(FlowDirection.In)] int maxTextures, [Flow(FlowDirection.Out)] int* numTextures);

        [NativeApi(EntryPoint = "glExtGetTexturesQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetTextures([Flow(FlowDirection.Out)] out Texture textures, [Flow(FlowDirection.In)] int maxTextures, [Flow(FlowDirection.Out)] out int numTextures);

        [NativeApi(EntryPoint = "glExtTexObjectStateOverrideiQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtTexObjectStateOverride([Flow(FlowDirection.In)] QCOM target, [Flow(FlowDirection.In)] QCOM pname, [Flow(FlowDirection.In)] int param);

        public unsafe void ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(FlowDirection.Out)] Span<uint> buffers, [Count(Count = 1), Flow(FlowDirection.Out)] int* numBuffers)
        {
            // ImplicitCountSpanOverloader
            ExtGetBuffers(out buffers.GetPinnableReference(), (int) buffers.Length, numBuffers);
        }

        public unsafe void ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(FlowDirection.Out)] Span<uint> buffers, [Count(Count = 1), Flow(FlowDirection.Out)] out int numBuffers)
        {
            // ImplicitCountSpanOverloader
            ExtGetBuffers(out buffers.GetPinnableReference(), (int) buffers.Length, out numBuffers);
        }

        public unsafe void ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(FlowDirection.Out)] Span<Buffer> buffers, [Count(Count = 1), Flow(FlowDirection.Out)] int* numBuffers)
        {
            // ImplicitCountSpanOverloader
            ExtGetBuffers(out buffers.GetPinnableReference(), (int) buffers.Length, numBuffers);
        }

        public unsafe void ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(FlowDirection.Out)] Span<Buffer> buffers, [Count(Count = 1), Flow(FlowDirection.Out)] out int numBuffers)
        {
            // ImplicitCountSpanOverloader
            ExtGetBuffers(out buffers.GetPinnableReference(), (int) buffers.Length, out numBuffers);
        }

        public unsafe void ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(FlowDirection.Out)] Span<uint> framebuffers, [Count(Count = 1), Flow(FlowDirection.Out)] int* numFramebuffers)
        {
            // ImplicitCountSpanOverloader
            ExtGetFramebuffers(out framebuffers.GetPinnableReference(), (int) framebuffers.Length, numFramebuffers);
        }

        public unsafe void ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(FlowDirection.Out)] Span<uint> framebuffers, [Count(Count = 1), Flow(FlowDirection.Out)] out int numFramebuffers)
        {
            // ImplicitCountSpanOverloader
            ExtGetFramebuffers(out framebuffers.GetPinnableReference(), (int) framebuffers.Length, out numFramebuffers);
        }

        public unsafe void ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(FlowDirection.Out)] Span<Framebuffer> framebuffers, [Count(Count = 1), Flow(FlowDirection.Out)] int* numFramebuffers)
        {
            // ImplicitCountSpanOverloader
            ExtGetFramebuffers(out framebuffers.GetPinnableReference(), (int) framebuffers.Length, numFramebuffers);
        }

        public unsafe void ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(FlowDirection.Out)] Span<Framebuffer> framebuffers, [Count(Count = 1), Flow(FlowDirection.Out)] out int numFramebuffers)
        {
            // ImplicitCountSpanOverloader
            ExtGetFramebuffers(out framebuffers.GetPinnableReference(), (int) framebuffers.Length, out numFramebuffers);
        }

        public unsafe void ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(FlowDirection.Out)] Span<uint> renderbuffers, [Count(Count = 1), Flow(FlowDirection.Out)] int* numRenderbuffers)
        {
            // ImplicitCountSpanOverloader
            ExtGetRenderbuffers(out renderbuffers.GetPinnableReference(), (int) renderbuffers.Length, numRenderbuffers);
        }

        public unsafe void ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(FlowDirection.Out)] Span<uint> renderbuffers, [Count(Count = 1), Flow(FlowDirection.Out)] out int numRenderbuffers)
        {
            // ImplicitCountSpanOverloader
            ExtGetRenderbuffers(out renderbuffers.GetPinnableReference(), (int) renderbuffers.Length, out numRenderbuffers);
        }

        public unsafe void ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(FlowDirection.Out)] Span<Renderbuffer> renderbuffers, [Count(Count = 1), Flow(FlowDirection.Out)] int* numRenderbuffers)
        {
            // ImplicitCountSpanOverloader
            ExtGetRenderbuffers(out renderbuffers.GetPinnableReference(), (int) renderbuffers.Length, numRenderbuffers);
        }

        public unsafe void ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(FlowDirection.Out)] Span<Renderbuffer> renderbuffers, [Count(Count = 1), Flow(FlowDirection.Out)] out int numRenderbuffers)
        {
            // ImplicitCountSpanOverloader
            ExtGetRenderbuffers(out renderbuffers.GetPinnableReference(), (int) renderbuffers.Length, out numRenderbuffers);
        }

        public QComExtendedGet(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

