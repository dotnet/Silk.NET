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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_direct_state_access")]
    public unsafe partial class ArbDirectStateAccess : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_direct_state_access";
        [NativeApi(EntryPoint = "glBindTextureUnit", Convention = CallingConvention.Winapi)]
        public partial void BindTextureUnit([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint unit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glBlitNamedFramebuffer", Convention = CallingConvention.Winapi)]
        public partial void BlitNamedFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint readFramebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawFramebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB filter);

        [NativeApi(EntryPoint = "glCheckNamedFramebufferStatus", Convention = CallingConvention.Winapi)]
        public partial ARB CheckNamedFramebufferStatus([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target);

        [NativeApi(EntryPoint = "glClearNamedBufferData", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferSubData", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedFramebufferiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferuiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferfi", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int drawbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stencil);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureSubImage1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureSubImage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage3D", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureSubImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCopyNamedBufferSubData", Convention = CallingConvention.Winapi)]
        public partial void CopyNamedBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint readBuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint writeBuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint readOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint writeOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glCopyTextureSubImage1D", Convention = CallingConvention.Winapi)]
        public partial void CopyTextureSubImage1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyTextureSubImage2D", Convention = CallingConvention.Winapi)]
        public partial void CopyTextureSubImage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyTextureSubImage3D", Convention = CallingConvention.Winapi)]
        public partial void CopyTextureSubImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCreateBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* buffers);

        [NativeApi(EntryPoint = "glCreateFramebuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateFramebuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* framebuffers);

        [NativeApi(EntryPoint = "glCreateProgramPipelines", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateProgramPipelines([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* pipelines);

        [NativeApi(EntryPoint = "glCreateQueries", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateQueries([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glCreateRenderbuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateRenderbuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* renderbuffers);

        [NativeApi(EntryPoint = "glCreateSamplers", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateSamplers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* samplers);

        [NativeApi(EntryPoint = "glCreateTextures", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* textures);

        [NativeApi(EntryPoint = "glCreateTransformFeedbacks", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateTransformFeedbacks([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glCreateVertexArrays", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateVertexArrays([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* arrays);

        [NativeApi(EntryPoint = "glDisableVertexArrayAttrib", Convention = CallingConvention.Winapi)]
        public partial void DisableVertexArrayAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableVertexArrayAttrib", Convention = CallingConvention.Winapi)]
        public partial void EnableVertexArrayAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glFlushMappedNamedBufferRange", Convention = CallingConvention.Winapi)]
        public partial void FlushMappedNamedBufferRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint length);

        [NativeApi(EntryPoint = "glGenerateTextureMipmap", Convention = CallingConvention.Winapi)]
        public partial void GenerateTextureMipmap([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glGetCompressedTextureImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCompressedTextureImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetNamedBufferParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedBufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameteri64v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedBufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetNamedBufferPointerv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetNamedBufferSubData", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedRenderbufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryBufferObjecti64v", Convention = CallingConvention.Winapi)]
        public partial void GetQueryBufferObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glGetTextureImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureLevelParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureLevelParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureLevelParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTextureParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIuiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTransformFeedbackiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedback([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint xfb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki_v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedback([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint xfb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki64_v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbacki64([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint xfb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* param);

        [NativeApi(EntryPoint = "glGetVertexArrayiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexediv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexArrayIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexed64iv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexArrayIndexed64([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* param);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferData", Convention = CallingConvention.Winapi)]
        public unsafe partial void InvalidateNamedFramebufferData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB* attachments);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferSubData", Convention = CallingConvention.Winapi)]
        public unsafe partial void InvalidateNamedFramebufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB* attachments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glMapNamedBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial void* MapNamedBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB access);

        [NativeApi(EntryPoint = "glMapNamedBufferRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void* MapNamedBufferRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint access);

        [NativeApi(EntryPoint = "glNamedBufferData", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedBufferData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB usage);

        [NativeApi(EntryPoint = "glNamedBufferStorage", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedBufferStorage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glNamedBufferSubData", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffer", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferDrawBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB buf);

        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedFramebufferDrawBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB* bufs);

        [NativeApi(EntryPoint = "glNamedFramebufferParameteri", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glNamedFramebufferReadBuffer", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferReadBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB src);

        [NativeApi(EntryPoint = "glNamedFramebufferRenderbuffer", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferRenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB renderbuffertarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glNamedFramebufferTexture", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glNamedFramebufferTextureLayer", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTextureLayer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glNamedRenderbufferStorage", Convention = CallingConvention.Winapi)]
        public partial void NamedRenderbufferStorage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisample", Convention = CallingConvention.Winapi)]
        public partial void NamedRenderbufferStorageMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glTextureBuffer", Convention = CallingConvention.Winapi)]
        public partial void TextureBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTextureBufferRange", Convention = CallingConvention.Winapi)]
        public partial void TextureBufferRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glTextureParameterf", Convention = CallingConvention.Winapi)]
        public partial void TextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glTextureParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* param);

        [NativeApi(EntryPoint = "glTextureParameteri", Convention = CallingConvention.Winapi)]
        public partial void TextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTextureParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glTextureParameterIiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTextureParameterIuiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTextureStorage1D", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glTextureStorage2D", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glTextureStorage2DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage2DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureStorage3D", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth);

        [NativeApi(EntryPoint = "glTextureStorage3DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage3DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureSubImage1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage3D", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTransformFeedbackBufferBase", Convention = CallingConvention.Winapi)]
        public partial void TransformFeedbackBufferBase([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint xfb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTransformFeedbackBufferRange", Convention = CallingConvention.Winapi)]
        public partial void TransformFeedbackBufferRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint xfb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glUnmapNamedBuffer", Convention = CallingConvention.Winapi)]
        public partial bool UnmapNamedBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glVertexArrayAttribBinding", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayAttribBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint attribindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bindingindex);

        [NativeApi(EntryPoint = "glVertexArrayAttribFormat", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayAttribFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint attribindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayAttribIFormat", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayAttribIFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint attribindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayAttribLFormat", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayAttribLFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint attribindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayBindingDivisor", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayBindingDivisor([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bindingindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint divisor);

        [NativeApi(EntryPoint = "glVertexArrayElementBuffer", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayElementBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glVertexArrayVertexBuffer", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bindingindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glVertexArrayVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides);

        public ArbDirectStateAccess(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

