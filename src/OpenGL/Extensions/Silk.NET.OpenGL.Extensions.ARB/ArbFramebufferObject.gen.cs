// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_framebuffer_object")]
    public abstract unsafe partial class ArbFramebufferObject : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_framebuffer_object";
        [NativeApi(EntryPoint = "glBindFramebuffer")]
        public abstract void BindFramebuffer([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint framebuffer);

        [NativeApi(EntryPoint = "glBindRenderbuffer")]
        public abstract void BindRenderbuffer([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glBlitFramebuffer")]
        public abstract void BlitFramebuffer([Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] ARB filter);

        [NativeApi(EntryPoint = "glCheckFramebufferStatus")]
        public abstract ARB CheckFramebufferStatus([Flow(FlowDirection.In)] ARB target);

        [NativeApi(EntryPoint = "glDeleteFramebuffers")]
        public abstract unsafe void DeleteFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* framebuffers);

        [NativeApi(EntryPoint = "glDeleteFramebuffers")]
        public abstract void DeleteFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> framebuffers);

        [NativeApi(EntryPoint = "glDeleteRenderbuffers")]
        public abstract unsafe void DeleteRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* renderbuffers);

        [NativeApi(EntryPoint = "glDeleteRenderbuffers")]
        public abstract void DeleteRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> renderbuffers);

        [NativeApi(EntryPoint = "glFramebufferRenderbuffer")]
        public abstract void FramebufferRenderbuffer([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] ARB renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferTexture1D")]
        public abstract void FramebufferTexture1D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] ARB textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture2D")]
        public abstract void FramebufferTexture2D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] ARB textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture3D")]
        public abstract void FramebufferTexture3D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] ARB textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glFramebufferTextureLayer")]
        public abstract void FramebufferTextureLayer([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glGenerateMipmap")]
        public abstract void GenerateMipmap([Flow(FlowDirection.In)] ARB target);

        [NativeApi(EntryPoint = "glGenFramebuffers")]
        public abstract unsafe void GenFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* framebuffers);

        [NativeApi(EntryPoint = "glGenFramebuffers")]
        public abstract void GenFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> framebuffers);

        [NativeApi(EntryPoint = "glGenRenderbuffers")]
        public abstract unsafe void GenRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* renderbuffers);

        [NativeApi(EntryPoint = "glGenRenderbuffers")]
        public abstract void GenRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> renderbuffers);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public abstract unsafe void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public abstract void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv")]
        public abstract unsafe void GetRenderbufferParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv")]
        public abstract void GetRenderbufferParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glIsFramebuffer")]
        public abstract bool IsFramebuffer([Flow(FlowDirection.In)] uint framebuffer);

        [NativeApi(EntryPoint = "glIsRenderbuffer")]
        public abstract bool IsRenderbuffer([Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glRenderbufferStorage")]
        public abstract void RenderbufferStorage([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisample")]
        public abstract void RenderbufferStorageMultisample([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glBindFramebuffer")]
        public abstract void BindFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint framebuffer);

        [NativeApi(EntryPoint = "glBindRenderbuffer")]
        public abstract void BindRenderbuffer([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glBlitFramebuffer")]
        public abstract void BlitFramebuffer([Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] BlitFramebufferFilter filter);

        [NativeApi(EntryPoint = "glCheckFramebufferStatus")]
        public abstract ARB CheckFramebufferStatus([Flow(FlowDirection.In)] FramebufferTarget target);

        [NativeApi(EntryPoint = "glFramebufferRenderbuffer")]
        public abstract void FramebufferRenderbuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] RenderbufferTarget renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferTexture1D")]
        public abstract void FramebufferTexture1D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture2D")]
        public abstract void FramebufferTexture2D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture3D")]
        public abstract void FramebufferTexture3D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glFramebufferTextureLayer")]
        public abstract void FramebufferTextureLayer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glGenerateMipmap")]
        public abstract void GenerateMipmap([Flow(FlowDirection.In)] TextureTarget target);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public abstract unsafe void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public abstract void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv")]
        public abstract unsafe void GetRenderbufferParameter([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv")]
        public abstract void GetRenderbufferParameter([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glRenderbufferStorage")]
        public abstract void RenderbufferStorage([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisample")]
        public abstract void RenderbufferStorageMultisample([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        public unsafe void DeleteFramebuffer([Count(Parameter = "n"), Flow(FlowDirection.In)] uint framebuffers)
        {
            // ArrayParameterOverloader
            DeleteFramebuffers(1, &framebuffers);
        }

        public unsafe void DeleteRenderbuffer([Count(Parameter = "n"), Flow(FlowDirection.In)] uint renderbuffers)
        {
            // ArrayParameterOverloader
            DeleteRenderbuffers(1, &renderbuffers);
        }

        public unsafe uint GenFramebuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenFramebuffers(n, &ret);
            return ret;
        }

        public unsafe uint GenRenderbuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenRenderbuffers(n, &ret);
            return ret;
        }

        public ArbFramebufferObject(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

