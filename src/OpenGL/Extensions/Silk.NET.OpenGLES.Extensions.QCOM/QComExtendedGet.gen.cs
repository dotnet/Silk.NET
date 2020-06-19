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
        [NativeApi(EntryPoint = "glExtGetBufferPointervQCOM")]
        public abstract unsafe void ExtGetBufferPointer([Flow(FlowDirection.In)] QCOM target, [Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glExtGetBuffersQCOM")]
        public abstract unsafe void ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(FlowDirection.Out)] uint* buffers, [Flow(FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(FlowDirection.Out)] int* numBuffers);

        [NativeApi(EntryPoint = "glExtGetBuffersQCOM")]
        public abstract void ExtGetBuffers([Count(Parameter = "maxBuffers"), Flow(FlowDirection.Out)] Span<uint> buffers, [Flow(FlowDirection.In)] int maxBuffers, [Count(Count = 1), Flow(FlowDirection.Out)] out int numBuffers);

        [NativeApi(EntryPoint = "glExtGetFramebuffersQCOM")]
        public abstract unsafe void ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(FlowDirection.Out)] uint* framebuffers, [Flow(FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(FlowDirection.Out)] int* numFramebuffers);

        [NativeApi(EntryPoint = "glExtGetFramebuffersQCOM")]
        public abstract void ExtGetFramebuffers([Count(Parameter = "maxFramebuffers"), Flow(FlowDirection.Out)] Span<uint> framebuffers, [Flow(FlowDirection.In)] int maxFramebuffers, [Count(Count = 1), Flow(FlowDirection.Out)] out int numFramebuffers);

        [NativeApi(EntryPoint = "glExtGetRenderbuffersQCOM")]
        public abstract unsafe void ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(FlowDirection.Out)] uint* renderbuffers, [Flow(FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(FlowDirection.Out)] int* numRenderbuffers);

        [NativeApi(EntryPoint = "glExtGetRenderbuffersQCOM")]
        public abstract void ExtGetRenderbuffers([Count(Parameter = "maxRenderbuffers"), Flow(FlowDirection.Out)] Span<uint> renderbuffers, [Flow(FlowDirection.In)] int maxRenderbuffers, [Count(Count = 1), Flow(FlowDirection.Out)] out int numRenderbuffers);

        [NativeApi(EntryPoint = "glExtGetTexLevelParameterivQCOM")]
        public abstract unsafe void ExtGetTexLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] QCOM face, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] QCOM pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glExtGetTexLevelParameterivQCOM")]
        public abstract void ExtGetTexLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] QCOM face, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] QCOM pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glExtGetTexSubImageQCOM")]
        public abstract unsafe void ExtGetTexSubImage([Flow(FlowDirection.In)] QCOM target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] QCOM format, [Flow(FlowDirection.In)] QCOM type, [Flow(FlowDirection.Out)] void* texels);

        [NativeApi(EntryPoint = "glExtGetTexSubImageQCOM")]
        public abstract void ExtGetTexSubImage<T0>([Flow(FlowDirection.In)] QCOM target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] QCOM format, [Flow(FlowDirection.In)] QCOM type, [Flow(FlowDirection.Out)] Span<T0> texels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glExtGetTexturesQCOM")]
        public abstract unsafe void ExtGetTextures([Flow(FlowDirection.Out)] uint* textures, [Flow(FlowDirection.In)] int maxTextures, [Flow(FlowDirection.Out)] int* numTextures);

        [NativeApi(EntryPoint = "glExtGetTexturesQCOM")]
        public abstract void ExtGetTextures([Flow(FlowDirection.Out)] Span<uint> textures, [Flow(FlowDirection.In)] int maxTextures, [Flow(FlowDirection.Out)] Span<int> numTextures);

        [NativeApi(EntryPoint = "glExtTexObjectStateOverrideiQCOM")]
        public abstract void ExtTexObjectStateOverride([Flow(FlowDirection.In)] QCOM target, [Flow(FlowDirection.In)] QCOM pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glExtGetTexSubImageQCOM")]
        public abstract unsafe void ExtGetTexSubImage([Flow(FlowDirection.In)] QCOM target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.Out)] void* texels);

        [NativeApi(EntryPoint = "glExtGetTexSubImageQCOM")]
        public abstract void ExtGetTexSubImage<T0>([Flow(FlowDirection.In)] QCOM target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.Out)] Span<T0> texels) where T0 : unmanaged;

        public QComExtendedGet(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

