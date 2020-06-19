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

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    [Extension("QCOM_extended_get")]
    public abstract unsafe partial class QComExtendedGet : NativeExtension<GL>
    {
        public const string ExtensionName = "QCOM_extended_get";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glExtGetBufferPointervQCOM")]
        public abstract unsafe void ExtGetBufferPointer([Flow(FlowDirection.In)] QCOM target, [Flow(FlowDirection.Out)] void** @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from maxBuffers.
        /// </param>
        /// <param name="maxBuffers">
        /// To be added.
        /// </param>
        /// <param name="numBuffers">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glExtGetBuffersQCOM")]
        public abstract unsafe void ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(FlowDirection.Out)] uint* buffers, [Flow(FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(FlowDirection.Out)] int* numBuffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from maxBuffers.
        /// </param>
        /// <param name="maxBuffers">
        /// To be added.
        /// </param>
        /// <param name="numBuffers">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glExtGetBuffersQCOM")]
        public abstract void ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(FlowDirection.Out)] Span<uint> buffers, [Flow(FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(FlowDirection.Out)] out int numBuffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffers">
        /// To be added.
        /// This parameter's element count is taken from maxFramebuffers.
        /// </param>
        /// <param name="maxFramebuffers">
        /// To be added.
        /// </param>
        /// <param name="numFramebuffers">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glExtGetFramebuffersQCOM")]
        public abstract unsafe void ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(FlowDirection.Out)] uint* framebuffers, [Flow(FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(FlowDirection.Out)] int* numFramebuffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffers">
        /// To be added.
        /// This parameter's element count is taken from maxFramebuffers.
        /// </param>
        /// <param name="maxFramebuffers">
        /// To be added.
        /// </param>
        /// <param name="numFramebuffers">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glExtGetFramebuffersQCOM")]
        public abstract void ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(FlowDirection.Out)] Span<uint> framebuffers, [Flow(FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(FlowDirection.Out)] out int numFramebuffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="renderbuffers">
        /// To be added.
        /// This parameter's element count is taken from maxRenderbuffers.
        /// </param>
        /// <param name="maxRenderbuffers">
        /// To be added.
        /// </param>
        /// <param name="numRenderbuffers">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glExtGetRenderbuffersQCOM")]
        public abstract unsafe void ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(FlowDirection.Out)] uint* renderbuffers, [Flow(FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(FlowDirection.Out)] int* numRenderbuffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="renderbuffers">
        /// To be added.
        /// This parameter's element count is taken from maxRenderbuffers.
        /// </param>
        /// <param name="maxRenderbuffers">
        /// To be added.
        /// </param>
        /// <param name="numRenderbuffers">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glExtGetRenderbuffersQCOM")]
        public abstract void ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(FlowDirection.Out)] Span<uint> renderbuffers, [Flow(FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(FlowDirection.Out)] out int numRenderbuffers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glExtGetTexLevelParameterivQCOM")]
        public abstract unsafe void ExtGetTexLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] QCOM face, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] QCOM pname, [Flow(FlowDirection.Out)] int* @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glExtGetTexLevelParameterivQCOM")]
        public abstract void ExtGetTexLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] QCOM face, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] QCOM pname, [Flow(FlowDirection.Out)] Span<int> @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="texels">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glExtGetTexSubImageQCOM")]
        public abstract unsafe void ExtGetTexSubImage([Flow(FlowDirection.In)] QCOM target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] QCOM format, [Flow(FlowDirection.In)] QCOM type, [Flow(FlowDirection.Out)] void* texels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="texels">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glExtGetTexSubImageQCOM")]
        public abstract void ExtGetTexSubImage<T0>([Flow(FlowDirection.In)] QCOM target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] QCOM format, [Flow(FlowDirection.In)] QCOM type, [Flow(FlowDirection.Out)] Span<T0> texels) where T0 : unmanaged;

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="textures">
        /// To be added.
        /// </param>
        /// <param name="maxTextures">
        /// To be added.
        /// </param>
        /// <param name="numTextures">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glExtGetTexturesQCOM")]
        public abstract unsafe void ExtGetTextures([Flow(FlowDirection.Out)] uint* textures, [Flow(FlowDirection.In)] int maxTextures, [Flow(FlowDirection.Out)] int* numTextures);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="textures">
        /// To be added.
        /// </param>
        /// <param name="maxTextures">
        /// To be added.
        /// </param>
        /// <param name="numTextures">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glExtGetTexturesQCOM")]
        public abstract void ExtGetTextures([Flow(FlowDirection.Out)] Span<uint> textures, [Flow(FlowDirection.In)] int maxTextures, [Flow(FlowDirection.Out)] Span<int> numTextures);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glExtTexObjectStateOverrideiQCOM")]
        public abstract void ExtTexObjectStateOverride([Flow(FlowDirection.In)] QCOM target, [Flow(FlowDirection.In)] QCOM pname, [Flow(FlowDirection.In)] int param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="texels">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glExtGetTexSubImageQCOM")]
        public abstract unsafe void ExtGetTexSubImage([Flow(FlowDirection.In)] QCOM target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.Out)] void* texels);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="xoffset">
        /// To be added.
        /// </param>
        /// <param name="yoffset">
        /// To be added.
        /// </param>
        /// <param name="zoffset">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="texels">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glExtGetTexSubImageQCOM")]
        public abstract void ExtGetTexSubImage<T0>([Flow(FlowDirection.In)] QCOM target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.Out)] Span<T0> texels) where T0 : unmanaged;

        public QComExtendedGet(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

