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

        [NativeApi(EntryPoint = "glExtGetBufferPointervQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glExtGetBuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numBuffers);

        [NativeApi(EntryPoint = "glExtGetBuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numBuffers);

        [NativeApi(EntryPoint = "glExtGetBuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numBuffers);

        [NativeApi(EntryPoint = "glExtGetBuffersQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numBuffers);

        [NativeApi(EntryPoint = "glExtGetBuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numBuffers);

        [NativeApi(EntryPoint = "glExtGetBuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numBuffers);

        [NativeApi(EntryPoint = "glExtGetBuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numBuffers);

        [NativeApi(EntryPoint = "glExtGetBuffersQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numBuffers);

        [NativeApi(EntryPoint = "glExtGetFramebuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* framebuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numFramebuffers);

        [NativeApi(EntryPoint = "glExtGetFramebuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* framebuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numFramebuffers);

        [NativeApi(EntryPoint = "glExtGetFramebuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint framebuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numFramebuffers);

        [NativeApi(EntryPoint = "glExtGetFramebuffersQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint framebuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numFramebuffers);

        [NativeApi(EntryPoint = "glExtGetFramebuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Framebuffer* framebuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numFramebuffers);

        [NativeApi(EntryPoint = "glExtGetFramebuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Framebuffer* framebuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numFramebuffers);

        [NativeApi(EntryPoint = "glExtGetFramebuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Framebuffer framebuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numFramebuffers);

        [NativeApi(EntryPoint = "glExtGetFramebuffersQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Framebuffer framebuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numFramebuffers);

        [NativeApi(EntryPoint = "glExtGetRenderbuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* renderbuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numRenderbuffers);

        [NativeApi(EntryPoint = "glExtGetRenderbuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* renderbuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numRenderbuffers);

        [NativeApi(EntryPoint = "glExtGetRenderbuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint renderbuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numRenderbuffers);

        [NativeApi(EntryPoint = "glExtGetRenderbuffersQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint renderbuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numRenderbuffers);

        [NativeApi(EntryPoint = "glExtGetRenderbuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Renderbuffer* renderbuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numRenderbuffers);

        [NativeApi(EntryPoint = "glExtGetRenderbuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Renderbuffer* renderbuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numRenderbuffers);

        [NativeApi(EntryPoint = "glExtGetRenderbuffersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Renderbuffer renderbuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numRenderbuffers);

        [NativeApi(EntryPoint = "glExtGetRenderbuffersQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Renderbuffer renderbuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numRenderbuffers);

        [NativeApi(EntryPoint = "glExtGetTexLevelParameterivQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetTexLevelParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glExtGetTexLevelParameterivQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetTexLevelParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glExtGetTexSubImageQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetTexSubImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* texels);

        [NativeApi(EntryPoint = "glExtGetTexSubImageQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetTexSubImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 texels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glExtGetTexSubImageQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetTexSubImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* texels);

        [NativeApi(EntryPoint = "glExtGetTexSubImageQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetTexSubImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 texels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glExtGetTexSubImageQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetTexSubImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* texels);

        [NativeApi(EntryPoint = "glExtGetTexSubImageQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetTexSubImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 texels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glExtGetTexSubImageQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetTexSubImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* texels);

        [NativeApi(EntryPoint = "glExtGetTexSubImageQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetTexSubImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 texels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glExtGetTexturesQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetTextures([Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* textures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxTextures, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numTextures);

        [NativeApi(EntryPoint = "glExtGetTexturesQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetTextures([Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* textures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxTextures, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numTextures);

        [NativeApi(EntryPoint = "glExtGetTexturesQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetTextures([Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint textures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxTextures, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numTextures);

        [NativeApi(EntryPoint = "glExtGetTexturesQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetTextures([Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint textures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxTextures, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numTextures);

        [NativeApi(EntryPoint = "glExtGetTexturesQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetTextures([Flow(Silk.NET.Core.Native.FlowDirection.Out)] Texture* textures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxTextures, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numTextures);

        [NativeApi(EntryPoint = "glExtGetTexturesQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetTextures([Flow(Silk.NET.Core.Native.FlowDirection.Out)] Texture* textures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxTextures, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numTextures);

        [NativeApi(EntryPoint = "glExtGetTexturesQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetTextures([Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Texture textures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxTextures, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numTextures);

        [NativeApi(EntryPoint = "glExtGetTexturesQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtGetTextures([Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Texture textures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxTextures, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numTextures);

        [NativeApi(EntryPoint = "glExtTexObjectStateOverrideiQCOM", Convention = CallingConvention.Winapi)]
        public partial void ExtTexObjectStateOverride([Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        public unsafe void ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> buffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numBuffers)
        {
            // ImplicitCountSpanOverloader
            ExtGetBuffers(out buffers.GetPinnableReference(), (int) buffers.Length, numBuffers);
        }

        public unsafe void ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> buffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numBuffers)
        {
            // ImplicitCountSpanOverloader
            ExtGetBuffers(out buffers.GetPinnableReference(), (int) buffers.Length, out numBuffers);
        }

        public unsafe void ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Buffer> buffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numBuffers)
        {
            // ImplicitCountSpanOverloader
            ExtGetBuffers(out buffers.GetPinnableReference(), (int) buffers.Length, numBuffers);
        }

        public unsafe void ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Buffer> buffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numBuffers)
        {
            // ImplicitCountSpanOverloader
            ExtGetBuffers(out buffers.GetPinnableReference(), (int) buffers.Length, out numBuffers);
        }

        public unsafe void ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> framebuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numFramebuffers)
        {
            // ImplicitCountSpanOverloader
            ExtGetFramebuffers(out framebuffers.GetPinnableReference(), (int) framebuffers.Length, numFramebuffers);
        }

        public unsafe void ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> framebuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numFramebuffers)
        {
            // ImplicitCountSpanOverloader
            ExtGetFramebuffers(out framebuffers.GetPinnableReference(), (int) framebuffers.Length, out numFramebuffers);
        }

        public unsafe void ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Framebuffer> framebuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numFramebuffers)
        {
            // ImplicitCountSpanOverloader
            ExtGetFramebuffers(out framebuffers.GetPinnableReference(), (int) framebuffers.Length, numFramebuffers);
        }

        public unsafe void ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Framebuffer> framebuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numFramebuffers)
        {
            // ImplicitCountSpanOverloader
            ExtGetFramebuffers(out framebuffers.GetPinnableReference(), (int) framebuffers.Length, out numFramebuffers);
        }

        public unsafe void ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> renderbuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numRenderbuffers)
        {
            // ImplicitCountSpanOverloader
            ExtGetRenderbuffers(out renderbuffers.GetPinnableReference(), (int) renderbuffers.Length, numRenderbuffers);
        }

        public unsafe void ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> renderbuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numRenderbuffers)
        {
            // ImplicitCountSpanOverloader
            ExtGetRenderbuffers(out renderbuffers.GetPinnableReference(), (int) renderbuffers.Length, out numRenderbuffers);
        }

        public unsafe void ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Renderbuffer> renderbuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numRenderbuffers)
        {
            // ImplicitCountSpanOverloader
            ExtGetRenderbuffers(out renderbuffers.GetPinnableReference(), (int) renderbuffers.Length, numRenderbuffers);
        }

        public unsafe void ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Renderbuffer> renderbuffers, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numRenderbuffers)
        {
            // ImplicitCountSpanOverloader
            ExtGetRenderbuffers(out renderbuffers.GetPinnableReference(), (int) renderbuffers.Length, out numRenderbuffers);
        }

        public unsafe void* ExtGetBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM target)
        {
            // NonKhrReturnTypeOverloader
            ExtGetBufferPointer(target, out void* silkRet);
            return silkRet;
        }

        public unsafe int ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxBuffers)
        {
            // NonKhrReturnTypeOverloader
            ExtGetBuffers(buffers, maxBuffers, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxBuffers)
        {
            // NonKhrReturnTypeOverloader
            ExtGetBuffers(out buffers, maxBuffers, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxBuffers)
        {
            // NonKhrReturnTypeOverloader
            ExtGetBuffers(buffers, maxBuffers, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxBuffers)
        {
            // NonKhrReturnTypeOverloader
            ExtGetBuffers(out buffers, maxBuffers, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* framebuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxFramebuffers)
        {
            // NonKhrReturnTypeOverloader
            ExtGetFramebuffers(framebuffers, maxFramebuffers, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint framebuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxFramebuffers)
        {
            // NonKhrReturnTypeOverloader
            ExtGetFramebuffers(out framebuffers, maxFramebuffers, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Framebuffer* framebuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxFramebuffers)
        {
            // NonKhrReturnTypeOverloader
            ExtGetFramebuffers(framebuffers, maxFramebuffers, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Framebuffer framebuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxFramebuffers)
        {
            // NonKhrReturnTypeOverloader
            ExtGetFramebuffers(out framebuffers, maxFramebuffers, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* renderbuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxRenderbuffers)
        {
            // NonKhrReturnTypeOverloader
            ExtGetRenderbuffers(renderbuffers, maxRenderbuffers, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint renderbuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxRenderbuffers)
        {
            // NonKhrReturnTypeOverloader
            ExtGetRenderbuffers(out renderbuffers, maxRenderbuffers, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Renderbuffer* renderbuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxRenderbuffers)
        {
            // NonKhrReturnTypeOverloader
            ExtGetRenderbuffers(renderbuffers, maxRenderbuffers, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Renderbuffer renderbuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxRenderbuffers)
        {
            // NonKhrReturnTypeOverloader
            ExtGetRenderbuffers(out renderbuffers, maxRenderbuffers, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetTexLevelParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM pname)
        {
            // NonKhrReturnTypeOverloader
            ExtGetTexLevelParameter(texture, face, level, pname, out int silkRet);
            return silkRet;
        }

        public unsafe T0 ExtGetTexSubImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            ExtGetTexSubImage(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 ExtGetTexSubImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            ExtGetTexSubImage(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 ExtGetTexSubImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            ExtGetTexSubImage(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 ExtGetTexSubImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            ExtGetTexSubImage(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe int ExtGetTextures([Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* textures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxTextures)
        {
            // NonKhrReturnTypeOverloader
            ExtGetTextures(textures, maxTextures, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetTextures([Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint textures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxTextures)
        {
            // NonKhrReturnTypeOverloader
            ExtGetTextures(out textures, maxTextures, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetTextures([Flow(Silk.NET.Core.Native.FlowDirection.Out)] Texture* textures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxTextures)
        {
            // NonKhrReturnTypeOverloader
            ExtGetTextures(textures, maxTextures, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetTextures([Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Texture textures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxTextures)
        {
            // NonKhrReturnTypeOverloader
            ExtGetTextures(out textures, maxTextures, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> buffers)
        {
            // NonKhrReturnTypeOverloader
            ExtGetBuffers(buffers, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Buffer> buffers)
        {
            // NonKhrReturnTypeOverloader
            ExtGetBuffers(buffers, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> framebuffers)
        {
            // NonKhrReturnTypeOverloader
            ExtGetFramebuffers(framebuffers, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Framebuffer> framebuffers)
        {
            // NonKhrReturnTypeOverloader
            ExtGetFramebuffers(framebuffers, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> renderbuffers)
        {
            // NonKhrReturnTypeOverloader
            ExtGetRenderbuffers(renderbuffers, out int silkRet);
            return silkRet;
        }

        public unsafe int ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Renderbuffer> renderbuffers)
        {
            // NonKhrReturnTypeOverloader
            ExtGetRenderbuffers(renderbuffers, out int silkRet);
            return silkRet;
        }

        public QComExtendedGet(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

