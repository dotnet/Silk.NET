// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_framebuffer_object")]
    public abstract unsafe partial class ExtFramebufferObject : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindFramebufferEXT")]
        public abstract void BindFramebuffer([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint framebuffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindRenderbufferEXT")]
        public abstract void BindRenderbuffer([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint renderbuffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCheckFramebufferStatusEXT")]
        public abstract EXT CheckFramebufferStatus([Flow(FlowDirection.In)] EXT target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteFramebuffersEXT")]
        public abstract unsafe void DeleteFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* framebuffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteFramebuffersEXT")]
        public abstract void DeleteFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> framebuffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteRenderbuffersEXT")]
        public abstract unsafe void DeleteRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* renderbuffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteRenderbuffersEXT")]
        public abstract void DeleteRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> renderbuffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferRenderbufferEXT")]
        public abstract void FramebufferRenderbuffer([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferTexture1DEXT")]
        public abstract void FramebufferTexture1D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferTexture2DEXT")]
        public abstract void FramebufferTexture2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferTexture3DEXT")]
        public abstract void FramebufferTexture3D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenerateMipmapEXT")]
        public abstract void GenerateMipmap([Flow(FlowDirection.In)] EXT target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenFramebuffersEXT")]
        public abstract unsafe void GenFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* framebuffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenFramebuffersEXT")]
        public abstract void GenFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> framebuffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenRenderbuffersEXT")]
        public abstract unsafe void GenRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* renderbuffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenRenderbuffersEXT")]
        public abstract void GenRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> renderbuffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameterivEXT")]
        public abstract unsafe void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameterivEXT")]
        public abstract void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetRenderbufferParameterivEXT")]
        public abstract unsafe void GetRenderbufferParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetRenderbufferParameterivEXT")]
        public abstract void GetRenderbufferParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsFramebufferEXT")]
        public abstract bool IsFramebuffer([Flow(FlowDirection.In)] uint framebuffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsRenderbufferEXT")]
        public abstract bool IsRenderbuffer([Flow(FlowDirection.In)] uint renderbuffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glRenderbufferStorageEXT")]
        public abstract void RenderbufferStorage([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindFramebufferEXT")]
        public abstract void BindFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint framebuffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindRenderbufferEXT")]
        public abstract void BindRenderbuffer([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint renderbuffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCheckFramebufferStatusEXT")]
        public abstract EXT CheckFramebufferStatus([Flow(FlowDirection.In)] FramebufferTarget target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferRenderbufferEXT")]
        public abstract void FramebufferRenderbuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] RenderbufferTarget renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferTexture1DEXT")]
        public abstract void FramebufferTexture1D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferTexture2DEXT")]
        public abstract void FramebufferTexture2D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferTexture3DEXT")]
        public abstract void FramebufferTexture3D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenerateMipmapEXT")]
        public abstract void GenerateMipmap([Flow(FlowDirection.In)] TextureTarget target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameterivEXT")]
        public abstract unsafe void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameterivEXT")]
        public abstract void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetRenderbufferParameterivEXT")]
        public abstract unsafe void GetRenderbufferParameter([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetRenderbufferParameterivEXT")]
        public abstract void GetRenderbufferParameter([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glRenderbufferStorageEXT")]
        public abstract void RenderbufferStorage([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="framebuffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe void DeleteFramebuffer([Count(Parameter = "n"), Flow(FlowDirection.In)] uint framebuffers)
        {
            // ArrayParameterOverloader
            DeleteFramebuffers(1, &framebuffers);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="renderbuffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe void DeleteRenderbuffer([Count(Parameter = "n"), Flow(FlowDirection.In)] uint renderbuffers)
        {
            // ArrayParameterOverloader
            DeleteRenderbuffers(1, &renderbuffers);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="framebuffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe uint GenFramebuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenFramebuffers(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="renderbuffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe uint GenRenderbuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenRenderbuffers(n, &ret);
            return ret;
        }

        public ExtFramebufferObject(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

