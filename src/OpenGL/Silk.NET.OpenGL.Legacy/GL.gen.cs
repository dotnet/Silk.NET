// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    public abstract unsafe partial class GL : NativeAPI
    {

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectCount")]
        public abstract unsafe void MultiDrawArraysIndirectCount([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectCount")]
        public abstract void MultiDrawArraysIndirectCount<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectCount")]
        public abstract unsafe void MultiDrawElementsIndirectCount([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectCount")]
        public abstract void MultiDrawElementsIndirectCount<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPolygonOffsetClamp")]
        public abstract void PolygonOffsetClamp([Flow(FlowDirection.In)] float factor, [Flow(FlowDirection.In)] float units, [Flow(FlowDirection.In)] float clamp);

        [NativeApi(EntryPoint = "glSpecializeShader")]
        public abstract unsafe void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] byte* pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] uint* pConstantIndex, [Flow(FlowDirection.In)] uint* pConstantValue);

        [NativeApi(EntryPoint = "glSpecializeShader")]
        public abstract void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] Span<byte> pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] Span<uint> pConstantIndex, [Flow(FlowDirection.In)] Span<uint> pConstantValue);

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectCount")]
        public abstract unsafe void MultiDrawArraysIndirectCount([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectCount")]
        public abstract void MultiDrawArraysIndirectCount<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectCount")]
        public abstract unsafe void MultiDrawElementsIndirectCount([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectCount")]
        public abstract void MultiDrawElementsIndirectCount<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSpecializeShader")]
        public abstract unsafe void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] string pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] uint* pConstantIndex, [Flow(FlowDirection.In)] uint* pConstantValue);

        [NativeApi(EntryPoint = "glSpecializeShader")]
        public abstract void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] string pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] Span<uint> pConstantIndex, [Flow(FlowDirection.In)] Span<uint> pConstantValue);

        [NativeApi(EntryPoint = "glBindTextureUnit")]
        public abstract void BindTextureUnit([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glBlitNamedFramebuffer")]
        public abstract void BlitNamedFramebuffer([Flow(FlowDirection.In)] uint readFramebuffer, [Flow(FlowDirection.In)] uint drawFramebuffer, [Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] GLEnum filter);

        [NativeApi(EntryPoint = "glCheckNamedFramebufferStatus")]
        public abstract GLEnum CheckNamedFramebufferStatus([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum target);

        [NativeApi(EntryPoint = "glClearNamedBufferData")]
        public abstract unsafe void ClearNamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferData")]
        public abstract void ClearNamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferSubData")]
        public abstract unsafe void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferSubData")]
        public abstract void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedFramebufferiv")]
        public abstract unsafe void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferiv")]
        public abstract void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<int> value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferuiv")]
        public abstract unsafe void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferuiv")]
        public abstract void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<uint> value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferfv")]
        public abstract unsafe void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferfv")]
        public abstract void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferfi")]
        public abstract void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float depth, [Flow(FlowDirection.In)] int stencil);

        [NativeApi(EntryPoint = "glClipControl")]
        public abstract void ClipControl([Flow(FlowDirection.In)] GLEnum origin, [Flow(FlowDirection.In)] GLEnum depth);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage1D")]
        public abstract unsafe void CompressedTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage1D")]
        public abstract void CompressedTextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureSubImage2D")]
        public abstract unsafe void CompressedTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage2D")]
        public abstract void CompressedTextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureSubImage3D")]
        public abstract unsafe void CompressedTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage3D")]
        public abstract void CompressedTextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCopyNamedBufferSubData")]
        public abstract void CopyNamedBufferSubData([Flow(FlowDirection.In)] uint readBuffer, [Flow(FlowDirection.In)] uint writeBuffer, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glCopyTextureSubImage1D")]
        public abstract void CopyTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyTextureSubImage2D")]
        public abstract void CopyTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyTextureSubImage3D")]
        public abstract void CopyTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCreateBuffers")]
        public abstract unsafe void CreateBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* buffers);

        [NativeApi(EntryPoint = "glCreateBuffers")]
        public abstract void CreateBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> buffers);

        [NativeApi(EntryPoint = "glCreateFramebuffers")]
        public abstract unsafe void CreateFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* framebuffers);

        [NativeApi(EntryPoint = "glCreateFramebuffers")]
        public abstract void CreateFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> framebuffers);

        [NativeApi(EntryPoint = "glCreateProgramPipelines")]
        public abstract unsafe void CreateProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* pipelines);

        [NativeApi(EntryPoint = "glCreateProgramPipelines")]
        public abstract void CreateProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> pipelines);

        [NativeApi(EntryPoint = "glCreateQueries")]
        public abstract unsafe void CreateQueries([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glCreateQueries")]
        public abstract void CreateQueries([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids);

        [NativeApi(EntryPoint = "glCreateRenderbuffers")]
        public abstract unsafe void CreateRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* renderbuffers);

        [NativeApi(EntryPoint = "glCreateRenderbuffers")]
        public abstract void CreateRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> renderbuffers);

        [NativeApi(EntryPoint = "glCreateSamplers")]
        public abstract unsafe void CreateSamplers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* samplers);

        [NativeApi(EntryPoint = "glCreateSamplers")]
        public abstract void CreateSamplers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> samplers);

        [NativeApi(EntryPoint = "glCreateTextures")]
        public abstract unsafe void CreateTextures([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* textures);

        [NativeApi(EntryPoint = "glCreateTextures")]
        public abstract void CreateTextures([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> textures);

        [NativeApi(EntryPoint = "glCreateTransformFeedbacks")]
        public abstract unsafe void CreateTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glCreateTransformFeedbacks")]
        public abstract void CreateTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids);

        [NativeApi(EntryPoint = "glCreateVertexArrays")]
        public abstract unsafe void CreateVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* arrays);

        [NativeApi(EntryPoint = "glCreateVertexArrays")]
        public abstract void CreateVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> arrays);

        [NativeApi(EntryPoint = "glDisableVertexArrayAttrib")]
        public abstract void DisableVertexArrayAttrib([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableVertexArrayAttrib")]
        public abstract void EnableVertexArrayAttrib([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glFlushMappedNamedBufferRange")]
        public abstract void FlushMappedNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length);

        [NativeApi(EntryPoint = "glGenerateTextureMipmap")]
        public abstract void GenerateTextureMipmap([Flow(FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glGetCompressedTextureImage")]
        public abstract unsafe void GetCompressedTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetCompressedTextureImage")]
        public abstract void GetCompressedTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetCompressedTextureSubImage")]
        public abstract unsafe void GetCompressedTextureSubImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetCompressedTextureSubImage")]
        public abstract void GetCompressedTextureSubImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetGraphicsResetStatus")]
        public abstract GLEnum GetGraphicsResetStatus();

        [NativeApi(EntryPoint = "glGetNamedBufferParameteriv")]
        public abstract unsafe void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameteriv")]
        public abstract void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameteri64v")]
        public abstract unsafe void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameteri64v")]
        public abstract void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<long> @params);

        [NativeApi(EntryPoint = "glGetNamedBufferPointerv")]
        public abstract unsafe void GetNamedBufferPointer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetNamedBufferSubData")]
        public abstract unsafe void GetNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetNamedBufferSubData")]
        public abstract void GetNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv")]
        public abstract unsafe void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv")]
        public abstract void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferParameteriv")]
        public abstract unsafe void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetNamedFramebufferParameteriv")]
        public abstract void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<int> param);

        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameteriv")]
        public abstract unsafe void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameteriv")]
        public abstract void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetnColorTable")]
        public abstract unsafe void GetnColorTable([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTable")]
        public abstract void GetnColorTable<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnCompressedTexImage")]
        public abstract unsafe void GetnCompressedTexImage([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int lod, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetnCompressedTexImage")]
        public abstract void GetnCompressedTexImage<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int lod, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnConvolutionFilter")]
        public abstract unsafe void GetnConvolutionFilter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilter")]
        public abstract void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogram")]
        public abstract unsafe void GetnHistogram([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogram")]
        public abstract void GetnHistogram<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMapdv")]
        public abstract unsafe void GetnMap([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] double* v);

        [NativeApi(EntryPoint = "glGetnMapdv")]
        public abstract void GetnMap([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<double> v);

        [NativeApi(EntryPoint = "glGetnMapfv")]
        public abstract unsafe void GetnMap([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] float* v);

        [NativeApi(EntryPoint = "glGetnMapfv")]
        public abstract void GetnMap([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<float> v);

        [NativeApi(EntryPoint = "glGetnMapiv")]
        public abstract unsafe void GetnMap([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] int* v);

        [NativeApi(EntryPoint = "glGetnMapiv")]
        public abstract void GetnMap([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<int> v);

        [NativeApi(EntryPoint = "glGetnMinmax")]
        public abstract unsafe void GetnMinmax([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmax")]
        public abstract void GetnMinmax<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnPixelMapfv")]
        public abstract unsafe void GetnPixelMap([Flow(FlowDirection.In)] GLEnum map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] float* values);

        [NativeApi(EntryPoint = "glGetnPixelMapfv")]
        public abstract void GetnPixelMap([Flow(FlowDirection.In)] GLEnum map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<float> values);

        [NativeApi(EntryPoint = "glGetnPixelMapuiv")]
        public abstract unsafe void GetnPixelMap([Flow(FlowDirection.In)] GLEnum map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] uint* values);

        [NativeApi(EntryPoint = "glGetnPixelMapuiv")]
        public abstract void GetnPixelMap([Flow(FlowDirection.In)] GLEnum map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<uint> values);

        [NativeApi(EntryPoint = "glGetnPixelMapusv")]
        public abstract unsafe void GetnPixelMap([Flow(FlowDirection.In)] GLEnum map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] ushort* values);

        [NativeApi(EntryPoint = "glGetnPixelMapusv")]
        public abstract void GetnPixelMap([Flow(FlowDirection.In)] GLEnum map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<ushort> values);

        [NativeApi(EntryPoint = "glGetnPolygonStipple")]
        public abstract unsafe void GetnPolygonStipple([Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] byte* pattern);

        [NativeApi(EntryPoint = "glGetnPolygonStipple")]
        public abstract void GetnPolygonStipple([Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<byte> pattern);

        [NativeApi(EntryPoint = "glGetnSeparableFilter")]
        public abstract unsafe void GetnSeparableFilter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint rowBufSize, [Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Flow(FlowDirection.Out)] void* column, [Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilter")]
        public abstract void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint rowBufSize, [Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Flow(FlowDirection.Out)] Span<T1> column, [Flow(FlowDirection.Out)] Span<T2> span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImage")]
        public abstract unsafe void GetnTexImage([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetnTexImage")]
        public abstract void GetnTexImage<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnUniformdv")]
        public abstract unsafe void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetnUniformdv")]
        public abstract void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<double> @params);

        [NativeApi(EntryPoint = "glGetnUniformfv")]
        public abstract unsafe void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetnUniformfv")]
        public abstract void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<float> @params);

        [NativeApi(EntryPoint = "glGetnUniformiv")]
        public abstract unsafe void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetnUniformiv")]
        public abstract void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetnUniformuiv")]
        public abstract unsafe void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetnUniformuiv")]
        public abstract void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<uint> @params);

        [NativeApi(EntryPoint = "glGetQueryBufferObjecti64v")]
        public abstract void GetQueryBufferObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] IntPtr offset);

        [NativeApi(EntryPoint = "glGetTextureImage")]
        public abstract unsafe void GetTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureImage")]
        public abstract void GetTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTextureLevelParameterfv")]
        public abstract unsafe void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameterfv")]
        public abstract void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<float> @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameteriv")]
        public abstract unsafe void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameteriv")]
        public abstract void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetTextureParameterfv")]
        public abstract unsafe void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterfv")]
        public abstract void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<float> @params);

        [NativeApi(EntryPoint = "glGetTextureParameteriv")]
        public abstract unsafe void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureParameteriv")]
        public abstract void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIiv")]
        public abstract unsafe void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIiv")]
        public abstract void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIuiv")]
        public abstract unsafe void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIuiv")]
        public abstract void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<uint> @params);

        [NativeApi(EntryPoint = "glGetTextureSubImage")]
        public abstract unsafe void GetTextureSubImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureSubImage")]
        public abstract void GetTextureSubImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTransformFeedbackiv")]
        public abstract unsafe void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetTransformFeedbackiv")]
        public abstract void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<int> param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki_v")]
        public abstract unsafe void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki_v")]
        public abstract void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] Span<int> param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki64_v")]
        public abstract unsafe void GetTransformFeedbacki64([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] long* param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki64_v")]
        public abstract void GetTransformFeedbacki64([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] Span<long> param);

        [NativeApi(EntryPoint = "glGetVertexArrayiv")]
        public abstract unsafe void GetVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetVertexArrayiv")]
        public abstract void GetVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<int> param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexediv")]
        public abstract unsafe void GetVertexArrayIndexed([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexediv")]
        public abstract void GetVertexArrayIndexed([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<int> param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexed64iv")]
        public abstract unsafe void GetVertexArrayIndexed64([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] long* param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexed64iv")]
        public abstract void GetVertexArrayIndexed64([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<long> param);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferData")]
        public abstract unsafe void InvalidateNamedFramebufferData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] GLEnum* attachments);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferData")]
        public abstract void InvalidateNamedFramebufferData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] Span<GLEnum> attachments);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferSubData")]
        public abstract unsafe void InvalidateNamedFramebufferSubData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] GLEnum* attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferSubData")]
        public abstract void InvalidateNamedFramebufferSubData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] Span<GLEnum> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glMapNamedBuffer")]
        public abstract unsafe void* MapNamedBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum access);

        [NativeApi(EntryPoint = "glMapNamedBufferRange")]
        public abstract unsafe void* MapNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length, [Flow(FlowDirection.In)] uint access);

        [NativeApi(EntryPoint = "glMemoryBarrierByRegion")]
        public abstract void MemoryBarrierByRegion([Flow(FlowDirection.In)] uint barriers);

        [NativeApi(EntryPoint = "glNamedBufferData")]
        public abstract unsafe void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] GLEnum usage);

        [NativeApi(EntryPoint = "glNamedBufferData")]
        public abstract void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] GLEnum usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNamedBufferStorage")]
        public abstract unsafe void NamedBufferStorage([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glNamedBufferStorage")]
        public abstract void NamedBufferStorage<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNamedBufferSubData")]
        public abstract unsafe void NamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Computed = "size"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glNamedBufferSubData")]
        public abstract void NamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Computed = "size"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffer")]
        public abstract void NamedFramebufferDrawBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum buf);

        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffers")]
        public abstract unsafe void NamedFramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] GLEnum* bufs);

        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffers")]
        public abstract void NamedFramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] Span<GLEnum> bufs);

        [NativeApi(EntryPoint = "glNamedFramebufferParameteri")]
        public abstract void NamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glNamedFramebufferReadBuffer")]
        public abstract void NamedFramebufferReadBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum src);

        [NativeApi(EntryPoint = "glNamedFramebufferRenderbuffer")]
        public abstract void NamedFramebufferRenderbuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glNamedFramebufferTexture")]
        public abstract void NamedFramebufferTexture([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glNamedFramebufferTextureLayer")]
        public abstract void NamedFramebufferTextureLayer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glNamedRenderbufferStorage")]
        public abstract void NamedRenderbufferStorage([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisample")]
        public abstract void NamedRenderbufferStorageMultisample([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glReadnPixels")]
        public abstract unsafe void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixels")]
        public abstract void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureBarrier")]
        public abstract void TextureBarrier();

        [NativeApi(EntryPoint = "glTextureBuffer")]
        public abstract void TextureBuffer([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTextureBufferRange")]
        public abstract void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glTextureParameterf")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glTextureParameterfv")]
        public abstract unsafe void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float* param);

        [NativeApi(EntryPoint = "glTextureParameterfv")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] Span<float> param);

        [NativeApi(EntryPoint = "glTextureParameteri")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTextureParameteriv")]
        public abstract unsafe void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glTextureParameteriv")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] Span<int> param);

        [NativeApi(EntryPoint = "glTextureParameterIiv")]
        public abstract unsafe void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTextureParameterIiv")]
        public abstract void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] Span<int> @params);

        [NativeApi(EntryPoint = "glTextureParameterIuiv")]
        public abstract unsafe void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTextureParameterIuiv")]
        public abstract void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] Span<uint> @params);

        [NativeApi(EntryPoint = "glTextureStorage1D")]
        public abstract void TextureStorage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glTextureStorage2D")]
        public abstract void TextureStorage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glTextureStorage2DMultisample")]
        public abstract void TextureStorage2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureStorage3D")]
        public abstract void TextureStorage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        [NativeApi(EntryPoint = "glTextureStorage3DMultisample")]
        public abstract void TextureStorage3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureSubImage1D")]
        public abstract unsafe void TextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage1D")]
        public abstract void TextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage2D")]
        public abstract unsafe void TextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage2D")]
        public abstract void TextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage3D")]
        public abstract unsafe void TextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage3D")]
        public abstract void TextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTransformFeedbackBufferBase")]
        public abstract void TransformFeedbackBufferBase([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTransformFeedbackBufferRange")]
        public abstract void TransformFeedbackBufferRange([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glUnmapNamedBuffer")]
        public abstract bool UnmapNamedBuffer([Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glVertexArrayAttribBinding")]
        public abstract void VertexArrayAttribBinding([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] uint bindingindex);

        [NativeApi(EntryPoint = "glVertexArrayAttribFormat")]
        public abstract void VertexArrayAttribFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayAttribIFormat")]
        public abstract void VertexArrayAttribIFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayAttribLFormat")]
        public abstract void VertexArrayAttribLFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayBindingDivisor")]
        public abstract void VertexArrayBindingDivisor([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint divisor);

        [NativeApi(EntryPoint = "glVertexArrayElementBuffer")]
        public abstract void VertexArrayElementBuffer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glVertexArrayVertexBuffer")]
        public abstract void VertexArrayVertexBuffer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glVertexArrayVertexBuffers")]
        public abstract unsafe void VertexArrayVertexBuffers([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] IntPtr* offsets, [Flow(FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glVertexArrayVertexBuffers")]
        public abstract void VertexArrayVertexBuffers([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Span<uint> buffers, [Flow(FlowDirection.In)] Span<IntPtr> offsets, [Flow(FlowDirection.In)] Span<uint> strides);

        [NativeApi(EntryPoint = "glBlitNamedFramebuffer")]
        public abstract void BlitNamedFramebuffer([Flow(FlowDirection.In)] uint readFramebuffer, [Flow(FlowDirection.In)] uint drawFramebuffer, [Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] BlitFramebufferFilter filter);

        [NativeApi(EntryPoint = "glCheckNamedFramebufferStatus")]
        public abstract GLEnum CheckNamedFramebufferStatus([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferTarget target);

        [NativeApi(EntryPoint = "glClearNamedBufferData")]
        public abstract unsafe void ClearNamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferData")]
        public abstract void ClearNamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferSubData")]
        public abstract unsafe void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferSubData")]
        public abstract void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedFramebufferiv")]
        public abstract unsafe void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferiv")]
        public abstract void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<int> value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferuiv")]
        public abstract unsafe void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferuiv")]
        public abstract void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<uint> value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferfv")]
        public abstract unsafe void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferfv")]
        public abstract void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferfi")]
        public abstract void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float depth, [Flow(FlowDirection.In)] int stencil);

        [NativeApi(EntryPoint = "glClipControl")]
        public abstract void ClipControl([Flow(FlowDirection.In)] ClipControlOrigin origin, [Flow(FlowDirection.In)] ClipControlDepth depth);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage1D")]
        public abstract unsafe void CompressedTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage1D")]
        public abstract void CompressedTextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureSubImage2D")]
        public abstract unsafe void CompressedTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage2D")]
        public abstract void CompressedTextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureSubImage3D")]
        public abstract unsafe void CompressedTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage3D")]
        public abstract void CompressedTextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCreateQueries")]
        public abstract unsafe void CreateQueries([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glCreateQueries")]
        public abstract void CreateQueries([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids);

        [NativeApi(EntryPoint = "glCreateTextures")]
        public abstract unsafe void CreateTextures([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* textures);

        [NativeApi(EntryPoint = "glCreateTextures")]
        public abstract void CreateTextures([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> textures);

        [NativeApi(EntryPoint = "glGetNamedBufferParameteriv")]
        public abstract unsafe void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferPNameARB pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameteriv")]
        public abstract void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferPNameARB pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameteri64v")]
        public abstract unsafe void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferPNameARB pname, [Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameteri64v")]
        public abstract void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferPNameARB pname, [Flow(FlowDirection.Out)] Span<long> @params);

        [NativeApi(EntryPoint = "glGetNamedBufferPointerv")]
        public abstract unsafe void GetNamedBufferPointer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv")]
        public abstract unsafe void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv")]
        public abstract void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferParameteriv")]
        public abstract unsafe void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GetFramebufferParameter pname, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetNamedFramebufferParameteriv")]
        public abstract void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GetFramebufferParameter pname, [Flow(FlowDirection.Out)] Span<int> param);

        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameteriv")]
        public abstract unsafe void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameteriv")]
        public abstract void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetnColorTable")]
        public abstract unsafe void GetnColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTable")]
        public abstract void GetnColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnCompressedTexImage")]
        public abstract unsafe void GetnCompressedTexImage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetnCompressedTexImage")]
        public abstract void GetnCompressedTexImage<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnConvolutionFilter")]
        public abstract unsafe void GetnConvolutionFilter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilter")]
        public abstract void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogram")]
        public abstract unsafe void GetnHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogram")]
        public abstract void GetnHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMapdv")]
        public abstract unsafe void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] double* v);

        [NativeApi(EntryPoint = "glGetnMapdv")]
        public abstract void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<double> v);

        [NativeApi(EntryPoint = "glGetnMapfv")]
        public abstract unsafe void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] float* v);

        [NativeApi(EntryPoint = "glGetnMapfv")]
        public abstract void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<float> v);

        [NativeApi(EntryPoint = "glGetnMapiv")]
        public abstract unsafe void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] int* v);

        [NativeApi(EntryPoint = "glGetnMapiv")]
        public abstract void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<int> v);

        [NativeApi(EntryPoint = "glGetnMinmax")]
        public abstract unsafe void GetnMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmax")]
        public abstract void GetnMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnPixelMapfv")]
        public abstract unsafe void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] float* values);

        [NativeApi(EntryPoint = "glGetnPixelMapfv")]
        public abstract void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<float> values);

        [NativeApi(EntryPoint = "glGetnPixelMapuiv")]
        public abstract unsafe void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] uint* values);

        [NativeApi(EntryPoint = "glGetnPixelMapuiv")]
        public abstract void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<uint> values);

        [NativeApi(EntryPoint = "glGetnPixelMapusv")]
        public abstract unsafe void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] ushort* values);

        [NativeApi(EntryPoint = "glGetnPixelMapusv")]
        public abstract void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<ushort> values);

        [NativeApi(EntryPoint = "glGetnPolygonStipple")]
        public abstract void GetnPolygonStipple([Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] string pattern);

        [NativeApi(EntryPoint = "glGetnSeparableFilter")]
        public abstract unsafe void GetnSeparableFilter([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Flow(FlowDirection.Out)] void* column, [Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilter")]
        public abstract void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Flow(FlowDirection.Out)] Span<T1> column, [Flow(FlowDirection.Out)] Span<T2> span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImage")]
        public abstract unsafe void GetnTexImage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetnTexImage")]
        public abstract void GetnTexImage<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetQueryBufferObjecti64v")]
        public abstract void GetQueryBufferObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Flow(FlowDirection.In)] IntPtr offset);

        [NativeApi(EntryPoint = "glGetTextureImage")]
        public abstract unsafe void GetTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureImage")]
        public abstract void GetTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTextureLevelParameterfv")]
        public abstract unsafe void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameterfv")]
        public abstract void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<float> @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameteriv")]
        public abstract unsafe void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameteriv")]
        public abstract void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetTextureParameterfv")]
        public abstract unsafe void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterfv")]
        public abstract void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<float> @params);

        [NativeApi(EntryPoint = "glGetTextureParameteriv")]
        public abstract unsafe void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureParameteriv")]
        public abstract void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIiv")]
        public abstract unsafe void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIiv")]
        public abstract void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIuiv")]
        public abstract unsafe void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIuiv")]
        public abstract void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<uint> @params);

        [NativeApi(EntryPoint = "glGetTextureSubImage")]
        public abstract unsafe void GetTextureSubImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureSubImage")]
        public abstract void GetTextureSubImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTransformFeedbackiv")]
        public abstract unsafe void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetTransformFeedbackiv")]
        public abstract void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.Out)] Span<int> param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki_v")]
        public abstract unsafe void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki_v")]
        public abstract void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] Span<int> param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki64_v")]
        public abstract unsafe void GetTransformFeedbacki64([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] long* param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki64_v")]
        public abstract void GetTransformFeedbacki64([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] Span<long> param);

        [NativeApi(EntryPoint = "glGetVertexArrayiv")]
        public abstract unsafe void GetVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetVertexArrayiv")]
        public abstract void GetVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] Span<int> param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexediv")]
        public abstract unsafe void GetVertexArrayIndexed([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexediv")]
        public abstract void GetVertexArrayIndexed([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] Span<int> param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexed64iv")]
        public abstract unsafe void GetVertexArrayIndexed64([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] long* param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexed64iv")]
        public abstract void GetVertexArrayIndexed64([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] Span<long> param);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferData")]
        public abstract unsafe void InvalidateNamedFramebufferData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] FramebufferAttachment* attachments);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferData")]
        public abstract void InvalidateNamedFramebufferData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] Span<FramebufferAttachment> attachments);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferSubData")]
        public abstract unsafe void InvalidateNamedFramebufferSubData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] FramebufferAttachment* attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferSubData")]
        public abstract void InvalidateNamedFramebufferSubData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] Span<FramebufferAttachment> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glMapNamedBuffer")]
        public abstract unsafe void* MapNamedBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferAccessARB access);

        [NativeApi(EntryPoint = "glNamedBufferData")]
        public abstract unsafe void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage);

        [NativeApi(EntryPoint = "glNamedBufferData")]
        public abstract void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffer")]
        public abstract void NamedFramebufferDrawBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ColorBuffer buf);

        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffers")]
        public abstract unsafe void NamedFramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] ColorBuffer* bufs);

        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffers")]
        public abstract void NamedFramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] Span<ColorBuffer> bufs);

        [NativeApi(EntryPoint = "glNamedFramebufferParameteri")]
        public abstract void NamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferParameterName pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glNamedFramebufferReadBuffer")]
        public abstract void NamedFramebufferReadBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ColorBuffer src);

        [NativeApi(EntryPoint = "glNamedFramebufferRenderbuffer")]
        public abstract void NamedFramebufferRenderbuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] RenderbufferTarget renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glNamedFramebufferTexture")]
        public abstract void NamedFramebufferTexture([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glNamedFramebufferTextureLayer")]
        public abstract void NamedFramebufferTextureLayer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glNamedRenderbufferStorage")]
        public abstract void NamedRenderbufferStorage([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisample")]
        public abstract void NamedRenderbufferStorageMultisample([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glReadnPixels")]
        public abstract unsafe void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixels")]
        public abstract void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureBuffer")]
        public abstract void TextureBuffer([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTextureBufferRange")]
        public abstract void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glTextureParameterf")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glTextureParameterfv")]
        public abstract unsafe void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] float* param);

        [NativeApi(EntryPoint = "glTextureParameterfv")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] Span<float> param);

        [NativeApi(EntryPoint = "glTextureParameteri")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTextureParameteriv")]
        public abstract unsafe void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glTextureParameteriv")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] Span<int> param);

        [NativeApi(EntryPoint = "glTextureParameterIiv")]
        public abstract unsafe void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTextureParameterIiv")]
        public abstract void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] Span<int> @params);

        [NativeApi(EntryPoint = "glTextureParameterIuiv")]
        public abstract unsafe void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTextureParameterIuiv")]
        public abstract void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] Span<uint> @params);

        [NativeApi(EntryPoint = "glTextureStorage1D")]
        public abstract void TextureStorage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glTextureStorage2D")]
        public abstract void TextureStorage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glTextureStorage2DMultisample")]
        public abstract void TextureStorage2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureStorage3D")]
        public abstract void TextureStorage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        [NativeApi(EntryPoint = "glTextureStorage3DMultisample")]
        public abstract void TextureStorage3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureSubImage1D")]
        public abstract unsafe void TextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage1D")]
        public abstract void TextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage2D")]
        public abstract unsafe void TextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage2D")]
        public abstract void TextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage3D")]
        public abstract unsafe void TextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage3D")]
        public abstract void TextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glVertexArrayAttribFormat")]
        public abstract void VertexArrayAttribFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayAttribIFormat")]
        public abstract void VertexArrayAttribIFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribIType type, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayAttribLFormat")]
        public abstract void VertexArrayAttribLFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribLType type, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public abstract unsafe void BindBuffersBase([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers);

        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public abstract void BindBuffersBase([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> buffers);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public abstract unsafe void BindBuffersRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] IntPtr* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] UIntPtr* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public abstract void BindBuffersRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<IntPtr> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<UIntPtr> sizes);

        [NativeApi(EntryPoint = "glBindImageTextures")]
        public abstract unsafe void BindImageTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* textures);

        [NativeApi(EntryPoint = "glBindImageTextures")]
        public abstract void BindImageTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> textures);

        [NativeApi(EntryPoint = "glBindSamplers")]
        public abstract unsafe void BindSamplers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* samplers);

        [NativeApi(EntryPoint = "glBindSamplers")]
        public abstract void BindSamplers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> samplers);

        [NativeApi(EntryPoint = "glBindTextures")]
        public abstract unsafe void BindTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* textures);

        [NativeApi(EntryPoint = "glBindTextures")]
        public abstract void BindTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> textures);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public abstract unsafe void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] IntPtr* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public abstract void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<IntPtr> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> strides);

        [NativeApi(EntryPoint = "glBufferStorage")]
        public abstract unsafe void BufferStorage([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glBufferStorage")]
        public abstract void BufferStorage<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearTexImage")]
        public abstract unsafe void ClearTexImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearTexImage")]
        public abstract void ClearTexImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearTexSubImage")]
        public abstract unsafe void ClearTexSubImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearTexSubImage")]
        public abstract void ClearTexSubImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public abstract unsafe void BindBuffersBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers);

        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public abstract void BindBuffersBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> buffers);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public abstract unsafe void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] IntPtr* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] UIntPtr* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public abstract void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<IntPtr> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<UIntPtr> sizes);

        [NativeApi(EntryPoint = "glBufferStorage")]
        public abstract unsafe void BufferStorage([Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glBufferStorage")]
        public abstract void BufferStorage<T0>([Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearTexImage")]
        public abstract unsafe void ClearTexImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearTexImage")]
        public abstract void ClearTexImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearTexSubImage")]
        public abstract unsafe void ClearTexSubImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearTexSubImage")]
        public abstract void ClearTexSubImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBindVertexBuffer")]
        public abstract void BindVertexBuffer([Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glClearBufferData")]
        public abstract unsafe void ClearBufferData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearBufferData")]
        public abstract void ClearBufferData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearBufferSubData")]
        public abstract unsafe void ClearBufferSubData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearBufferSubData")]
        public abstract void ClearBufferSubData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCopyImageSubData")]
        public abstract void CopyImageSubData([Flow(FlowDirection.In)] uint srcName, [Flow(FlowDirection.In)] GLEnum srcTarget, [Flow(FlowDirection.In)] int srcLevel, [Flow(FlowDirection.In)] int srcX, [Flow(FlowDirection.In)] int srcY, [Flow(FlowDirection.In)] int srcZ, [Flow(FlowDirection.In)] uint dstName, [Flow(FlowDirection.In)] GLEnum dstTarget, [Flow(FlowDirection.In)] int dstLevel, [Flow(FlowDirection.In)] int dstX, [Flow(FlowDirection.In)] int dstY, [Flow(FlowDirection.In)] int dstZ, [Flow(FlowDirection.In)] uint srcWidth, [Flow(FlowDirection.In)] uint srcHeight, [Flow(FlowDirection.In)] uint srcDepth);

        [NativeApi(EntryPoint = "glDebugMessageCallback")]
        public abstract unsafe void DebugMessageCallback([Flow(FlowDirection.In), Ultz.SuperInvoke.InteropServices.PinObjectAttribute(Ultz.SuperInvoke.InteropServices.PinMode.UntilNextCall)] DebugProc callback, [Flow(FlowDirection.In)] void* userParam);

        [NativeApi(EntryPoint = "glDebugMessageCallback")]
        public abstract void DebugMessageCallback<T0>([Flow(FlowDirection.In), Ultz.SuperInvoke.InteropServices.PinObjectAttribute(Ultz.SuperInvoke.InteropServices.PinMode.UntilNextCall)] DebugProc callback, [Flow(FlowDirection.In)] Span<T0> userParam) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public abstract unsafe void DebugMessageControl([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public abstract void DebugMessageControl([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public abstract unsafe void DebugMessageInsert([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] byte* buf);

        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public abstract void DebugMessageInsert([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] ref byte buf);

        [NativeApi(EntryPoint = "glDispatchCompute")]
        public abstract void DispatchCompute([Flow(FlowDirection.In)] uint num_groups_x, [Flow(FlowDirection.In)] uint num_groups_y, [Flow(FlowDirection.In)] uint num_groups_z);

        [NativeApi(EntryPoint = "glDispatchComputeIndirect")]
        public abstract void DispatchComputeIndirect([Flow(FlowDirection.In)] IntPtr indirect);

        [NativeApi(EntryPoint = "glFramebufferParameteri")]
        public abstract void FramebufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public abstract unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public abstract uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog);

        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        public abstract unsafe void GetFramebufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        public abstract void GetFramebufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformati64v")]
        public abstract unsafe void GetInternalformat([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetInternalformati64v")]
        public abstract void GetInternalformat([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<long> @params);

        [NativeApi(EntryPoint = "glGetObjectLabel")]
        public abstract unsafe void GetObjectLabel([Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* label);

        [NativeApi(EntryPoint = "glGetObjectLabel")]
        public abstract void GetObjectLabel([Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> label);

        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        public abstract unsafe void GetObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* label);

        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        public abstract void GetObjectPtrLabel<T0>([Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> label) where T0 : unmanaged;

        [System.Obsolete("Deprecated in version 4.3")]
        [NativeApi(EntryPoint = "glGetPointerv")]
        public abstract unsafe void GetPointer([Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        [System.Obsolete("Deprecated in version 4.3")]
        [NativeApi(EntryPoint = "glGetPointerv")]
        public abstract unsafe void GetPointer<T0>([Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* @params) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        public abstract unsafe void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        public abstract void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public abstract unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] GLEnum* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public abstract void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] Span<GLEnum> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetProgramResourceIndex")]
        public abstract unsafe uint GetProgramResourceIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceIndex")]
        public abstract uint GetProgramResourceIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ref byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocation")]
        public abstract unsafe int GetProgramResourceLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocation")]
        public abstract int GetProgramResourceLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ref byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndex")]
        public abstract unsafe int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndex")]
        public abstract int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ref byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        public abstract unsafe void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        public abstract void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name);

        [NativeApi(EntryPoint = "glInvalidateBufferData")]
        public abstract void InvalidateBufferData([Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glInvalidateBufferSubData")]
        public abstract void InvalidateBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length);

        [NativeApi(EntryPoint = "glInvalidateFramebuffer")]
        public abstract unsafe void InvalidateFramebuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] GLEnum* attachments);

        [NativeApi(EntryPoint = "glInvalidateFramebuffer")]
        public abstract void InvalidateFramebuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] Span<GLEnum> attachments);

        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer")]
        public abstract unsafe void InvalidateSubFramebuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] GLEnum* attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer")]
        public abstract void InvalidateSubFramebuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] Span<GLEnum> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glInvalidateTexImage")]
        public abstract void InvalidateTexImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glInvalidateTexSubImage")]
        public abstract void InvalidateTexSubImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirect")]
        public abstract unsafe void MultiDrawArraysIndirect([Flow(FlowDirection.In)] GLEnum mode, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirect")]
        public abstract void MultiDrawArraysIndirect<T0>([Flow(FlowDirection.In)] GLEnum mode, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] ref T0 indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirect")]
        public abstract unsafe void MultiDrawElementsIndirect([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirect")]
        public abstract void MultiDrawElementsIndirect<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] ref T0 indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glObjectLabel")]
        public abstract unsafe void ObjectLabel([Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] byte* label);

        [NativeApi(EntryPoint = "glObjectLabel")]
        public abstract void ObjectLabel([Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] ref byte label);

        [NativeApi(EntryPoint = "glObjectPtrLabel")]
        public abstract unsafe void ObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] byte* label);

        [NativeApi(EntryPoint = "glObjectPtrLabel")]
        public abstract void ObjectPtrLabel<T0>([Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] ref byte label) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPopDebugGroup")]
        public abstract void PopDebugGroup();

        [NativeApi(EntryPoint = "glPushDebugGroup")]
        public abstract unsafe void PushDebugGroup([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Count(Computed = "message, length"), Flow(FlowDirection.In)] byte* message);

        [NativeApi(EntryPoint = "glPushDebugGroup")]
        public abstract void PushDebugGroup([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Count(Computed = "message, length"), Flow(FlowDirection.In)] ref byte message);

        [NativeApi(EntryPoint = "glShaderStorageBlockBinding")]
        public abstract void ShaderStorageBlockBinding([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint storageBlockIndex, [Flow(FlowDirection.In)] uint storageBlockBinding);

        [NativeApi(EntryPoint = "glTexBufferRange")]
        public abstract void TexBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glTexStorage2DMultisample")]
        public abstract void TexStorage2DMultisample([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage3DMultisample")]
        public abstract void TexStorage3DMultisample([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureView")]
        public abstract void TextureView([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint origtexture, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint minlevel, [Flow(FlowDirection.In)] uint numlevels, [Flow(FlowDirection.In)] uint minlayer, [Flow(FlowDirection.In)] uint numlayers);

        [NativeApi(EntryPoint = "glVertexAttribBinding")]
        public abstract void VertexAttribBinding([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] uint bindingindex);

        [NativeApi(EntryPoint = "glVertexAttribFormat")]
        public abstract void VertexAttribFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexAttribIFormat")]
        public abstract void VertexAttribIFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexAttribLFormat")]
        public abstract void VertexAttribLFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexBindingDivisor")]
        public abstract void VertexBindingDivisor([Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint divisor);

        [NativeApi(EntryPoint = "glClearBufferData")]
        public abstract unsafe void ClearBufferData([Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearBufferData")]
        public abstract void ClearBufferData<T0>([Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearBufferSubData")]
        public abstract unsafe void ClearBufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearBufferSubData")]
        public abstract void ClearBufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCopyImageSubData")]
        public abstract void CopyImageSubData([Flow(FlowDirection.In)] uint srcName, [Flow(FlowDirection.In)] CopyImageSubDataTarget srcTarget, [Flow(FlowDirection.In)] int srcLevel, [Flow(FlowDirection.In)] int srcX, [Flow(FlowDirection.In)] int srcY, [Flow(FlowDirection.In)] int srcZ, [Flow(FlowDirection.In)] uint dstName, [Flow(FlowDirection.In)] CopyImageSubDataTarget dstTarget, [Flow(FlowDirection.In)] int dstLevel, [Flow(FlowDirection.In)] int dstX, [Flow(FlowDirection.In)] int dstY, [Flow(FlowDirection.In)] int dstZ, [Flow(FlowDirection.In)] uint srcWidth, [Flow(FlowDirection.In)] uint srcHeight, [Flow(FlowDirection.In)] uint srcDepth);

        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public abstract unsafe void DebugMessageControl([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public abstract void DebugMessageControl([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public abstract void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string buf);

        [NativeApi(EntryPoint = "glFramebufferParameteri")]
        public abstract void FramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferParameterName pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public abstract unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -6)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public abstract uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -6)] out string messageLog);

        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        public abstract unsafe void GetFramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        public abstract void GetFramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformati64v")]
        public abstract unsafe void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetInternalformati64v")]
        public abstract void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<long> @params);

        [NativeApi(EntryPoint = "glGetObjectLabel")]
        public abstract unsafe void GetObjectLabel([Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string label);

        [NativeApi(EntryPoint = "glGetObjectLabel")]
        public abstract void GetObjectLabel([Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string label);

        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        public abstract unsafe void GetObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string label);

        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        public abstract void GetObjectPtrLabel<T0>([Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string label) where T0 : unmanaged;

        [System.Obsolete("Deprecated in version 4.3")]
        [NativeApi(EntryPoint = "glGetPointerv")]
        public abstract unsafe void GetPointer([Flow(FlowDirection.In)] GetPointervPName pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        [System.Obsolete("Deprecated in version 4.3")]
        [NativeApi(EntryPoint = "glGetPointerv")]
        public abstract unsafe void GetPointer<T0>([Flow(FlowDirection.In)] GetPointervPName pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* @params) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        public abstract unsafe void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] ProgramInterfacePName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        public abstract void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] ProgramInterfacePName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public abstract unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public abstract void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] Span<ProgramResourceProperty> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetProgramResourceIndex")]
        public abstract uint GetProgramResourceIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocation")]
        public abstract int GetProgramResourceLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndex")]
        public abstract int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        public abstract unsafe void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string name);

        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        public abstract void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string name);

        [NativeApi(EntryPoint = "glInvalidateFramebuffer")]
        public abstract unsafe void InvalidateFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] InvalidateFramebufferAttachment* attachments);

        [NativeApi(EntryPoint = "glInvalidateFramebuffer")]
        public abstract void InvalidateFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] Span<InvalidateFramebufferAttachment> attachments);

        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer")]
        public abstract unsafe void InvalidateSubFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] InvalidateFramebufferAttachment* attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer")]
        public abstract void InvalidateSubFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] Span<InvalidateFramebufferAttachment> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirect")]
        public abstract unsafe void MultiDrawArraysIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirect")]
        public abstract void MultiDrawArraysIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] ref T0 indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirect")]
        public abstract unsafe void MultiDrawElementsIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirect")]
        public abstract void MultiDrawElementsIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] ref T0 indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glObjectLabel")]
        public abstract void ObjectLabel([Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string label);

        [NativeApi(EntryPoint = "glObjectPtrLabel")]
        public abstract unsafe void ObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string label);

        [NativeApi(EntryPoint = "glObjectPtrLabel")]
        public abstract void ObjectPtrLabel<T0>([Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string label) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPushDebugGroup")]
        public abstract void PushDebugGroup([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string message);

        [NativeApi(EntryPoint = "glTexBufferRange")]
        public abstract void TexBufferRange([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glTexStorage2DMultisample")]
        public abstract void TexStorage2DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage3DMultisample")]
        public abstract void TexStorage3DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureView")]
        public abstract void TextureView([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint origtexture, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint minlevel, [Flow(FlowDirection.In)] uint numlevels, [Flow(FlowDirection.In)] uint minlayer, [Flow(FlowDirection.In)] uint numlayers);

        [NativeApi(EntryPoint = "glVertexAttribFormat")]
        public abstract void VertexAttribFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexAttribIFormat")]
        public abstract void VertexAttribIFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribIType type, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexAttribLFormat")]
        public abstract void VertexAttribLFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribLType type, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glBindImageTexture")]
        public abstract void BindImageTexture([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] GLEnum access, [Flow(FlowDirection.In)] GLEnum format);

        [NativeApi(EntryPoint = "glDrawArraysInstancedBaseInstance")]
        public abstract void DrawArraysInstancedBaseInstance([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseInstance")]
        public abstract unsafe void DrawElementsInstancedBaseInstance([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Parameter = "count"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseInstance")]
        public abstract void DrawElementsInstancedBaseInstance<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance")]
        public abstract unsafe void DrawElementsInstancedBaseVertexBaseInstance([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Parameter = "count"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance")]
        public abstract void DrawElementsInstancedBaseVertexBaseInstance<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawTransformFeedbackInstanced")]
        public abstract void DrawTransformFeedbackInstanced([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glDrawTransformFeedbackStreamInstanced")]
        public abstract void DrawTransformFeedbackStreamInstanced([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glGetActiveAtomicCounterBufferiv")]
        public abstract unsafe void GetActiveAtomicCounterBuffer([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufferIndex, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetActiveAtomicCounterBufferiv")]
        public abstract void GetActiveAtomicCounterBuffer([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufferIndex, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public abstract unsafe void GetInternalformat([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public abstract void GetInternalformat([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glMemoryBarrier")]
        public abstract void MemoryBarrier([Flow(FlowDirection.In)] uint barriers);

        [NativeApi(EntryPoint = "glTexStorage1D")]
        public abstract void TexStorage1D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glTexStorage2D")]
        public abstract void TexStorage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glTexStorage3D")]
        public abstract void TexStorage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        [NativeApi(EntryPoint = "glBindImageTexture")]
        public abstract void BindImageTexture([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] BufferAccessARB access, [Flow(FlowDirection.In)] InternalFormat format);

        [NativeApi(EntryPoint = "glDrawArraysInstancedBaseInstance")]
        public abstract void DrawArraysInstancedBaseInstance([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseInstance")]
        public abstract unsafe void DrawElementsInstancedBaseInstance([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PrimitiveType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseInstance")]
        public abstract void DrawElementsInstancedBaseInstance<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PrimitiveType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance")]
        public abstract unsafe void DrawElementsInstancedBaseVertexBaseInstance([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance")]
        public abstract void DrawElementsInstancedBaseVertexBaseInstance<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawTransformFeedbackInstanced")]
        public abstract void DrawTransformFeedbackInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glDrawTransformFeedbackStreamInstanced")]
        public abstract void DrawTransformFeedbackStreamInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glGetActiveAtomicCounterBufferiv")]
        public abstract unsafe void GetActiveAtomicCounterBuffer([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufferIndex, [Flow(FlowDirection.In)] AtomicCounterBufferPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetActiveAtomicCounterBufferiv")]
        public abstract void GetActiveAtomicCounterBuffer([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufferIndex, [Flow(FlowDirection.In)] AtomicCounterBufferPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public abstract unsafe void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public abstract void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glTexStorage1D")]
        public abstract void TexStorage1D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glTexStorage2D")]
        public abstract void TexStorage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glTexStorage3D")]
        public abstract void TexStorage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        [NativeApi(EntryPoint = "glActiveShaderProgram")]
        public abstract void ActiveShaderProgram([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glBindProgramPipeline")]
        public abstract void BindProgramPipeline([Flow(FlowDirection.In)] uint pipeline);

        [NativeApi(EntryPoint = "glClearDepthf")]
        public abstract void ClearDepth([Flow(FlowDirection.In)] float d);

        [NativeApi(EntryPoint = "glCreateShaderProgramv")]
        public abstract unsafe uint CreateShaderProgram([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] byte** strings);

        [NativeApi(EntryPoint = "glDeleteProgramPipelines")]
        public abstract unsafe void DeleteProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* pipelines);

        [NativeApi(EntryPoint = "glDeleteProgramPipelines")]
        public abstract void DeleteProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> pipelines);

        [NativeApi(EntryPoint = "glDepthRangef")]
        public abstract void DepthRange([Flow(FlowDirection.In)] float n, [Flow(FlowDirection.In)] float f);

        [NativeApi(EntryPoint = "glDepthRangeArrayv")]
        public abstract unsafe void DepthRangeArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glDepthRangeArrayv")]
        public abstract void DepthRangeArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] ref double v);

        [NativeApi(EntryPoint = "glDepthRangeIndexed")]
        public abstract void DepthRangeIndexed([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double n, [Flow(FlowDirection.In)] double f);

        [NativeApi(EntryPoint = "glGenProgramPipelines")]
        public abstract unsafe void GenProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* pipelines);

        [NativeApi(EntryPoint = "glGenProgramPipelines")]
        public abstract void GenProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> pipelines);

        [NativeApi(EntryPoint = "glGetDoublei_v")]
        public abstract unsafe void GetDouble([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] double* data);

        [NativeApi(EntryPoint = "glGetDoublei_v")]
        public abstract void GetDouble([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out double data);

        [NativeApi(EntryPoint = "glGetFloati_v")]
        public abstract unsafe void GetFloat([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetFloati_v")]
        public abstract void GetFloat([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetProgramBinary")]
        public abstract unsafe void GetProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* binary);

        [NativeApi(EntryPoint = "glGetProgramBinary")]
        public abstract void GetProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> binary) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetProgramPipelineiv")]
        public abstract unsafe void GetProgramPipeline([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramPipelineiv")]
        public abstract void GetProgramPipeline([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLog")]
        public abstract unsafe void GetProgramPipelineInfoLog([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* infoLog);

        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLog")]
        public abstract void GetProgramPipelineInfoLog([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> infoLog);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public abstract unsafe void GetShaderPrecisionFormat([Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] GLEnum precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public abstract void GetShaderPrecisionFormat([Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] GLEnum precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] Span<int> range, [Count(Count = 1), Flow(FlowDirection.Out)] out int precision);

        [NativeApi(EntryPoint = "glGetVertexAttribLdv")]
        public abstract unsafe void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribLdv")]
        public abstract void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glIsProgramPipeline")]
        public abstract bool IsProgramPipeline([Flow(FlowDirection.In)] uint pipeline);

        [NativeApi(EntryPoint = "glProgramBinary")]
        public abstract unsafe void ProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length);

        [NativeApi(EntryPoint = "glProgramBinary")]
        public abstract void ProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] Span<T0> binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glProgramParameteri")]
        public abstract void ProgramParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glProgramUniform1i")]
        public abstract void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0);

        [NativeApi(EntryPoint = "glProgramUniform1iv")]
        public abstract unsafe void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform1iv")]
        public abstract void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        [NativeApi(EntryPoint = "glProgramUniform1f")]
        public abstract void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0);

        [NativeApi(EntryPoint = "glProgramUniform1fv")]
        public abstract unsafe void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform1fv")]
        public abstract void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glProgramUniform1d")]
        public abstract void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double v0);

        [NativeApi(EntryPoint = "glProgramUniform1dv")]
        public abstract unsafe void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniform1dv")]
        public abstract void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glProgramUniform1ui")]
        public abstract void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0);

        [NativeApi(EntryPoint = "glProgramUniform1uiv")]
        public abstract unsafe void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform1uiv")]
        public abstract void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value);

        [NativeApi(EntryPoint = "glProgramUniform2i")]
        public abstract void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1);

        [NativeApi(EntryPoint = "glProgramUniform2iv")]
        public abstract unsafe void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform2iv")]
        public abstract void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        [NativeApi(EntryPoint = "glProgramUniform2f")]
        public abstract void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1);

        [NativeApi(EntryPoint = "glProgramUniform2fv")]
        public abstract unsafe void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform2fv")]
        public abstract void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glProgramUniform2d")]
        public abstract void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double v0, [Flow(FlowDirection.In)] double v1);

        [NativeApi(EntryPoint = "glProgramUniform2dv")]
        public abstract unsafe void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniform2dv")]
        public abstract void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glProgramUniform2ui")]
        public abstract void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1);

        [NativeApi(EntryPoint = "glProgramUniform2uiv")]
        public abstract unsafe void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform2uiv")]
        public abstract void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value);

        [NativeApi(EntryPoint = "glProgramUniform3i")]
        public abstract void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2);

        [NativeApi(EntryPoint = "glProgramUniform3iv")]
        public abstract unsafe void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform3iv")]
        public abstract void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        [NativeApi(EntryPoint = "glProgramUniform3f")]
        public abstract void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2);

        [NativeApi(EntryPoint = "glProgramUniform3fv")]
        public abstract unsafe void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform3fv")]
        public abstract void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glProgramUniform3d")]
        public abstract void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double v0, [Flow(FlowDirection.In)] double v1, [Flow(FlowDirection.In)] double v2);

        [NativeApi(EntryPoint = "glProgramUniform3dv")]
        public abstract unsafe void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniform3dv")]
        public abstract void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glProgramUniform3ui")]
        public abstract void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1, [Flow(FlowDirection.In)] uint v2);

        [NativeApi(EntryPoint = "glProgramUniform3uiv")]
        public abstract unsafe void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform3uiv")]
        public abstract void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value);

        [NativeApi(EntryPoint = "glProgramUniform4i")]
        public abstract void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2, [Flow(FlowDirection.In)] int v3);

        [NativeApi(EntryPoint = "glProgramUniform4iv")]
        public abstract unsafe void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform4iv")]
        public abstract void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        [NativeApi(EntryPoint = "glProgramUniform4f")]
        public abstract void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] float v3);

        [NativeApi(EntryPoint = "glProgramUniform4fv")]
        public abstract unsafe void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform4fv")]
        public abstract void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glProgramUniform4d")]
        public abstract void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double v0, [Flow(FlowDirection.In)] double v1, [Flow(FlowDirection.In)] double v2, [Flow(FlowDirection.In)] double v3);

        [NativeApi(EntryPoint = "glProgramUniform4dv")]
        public abstract unsafe void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniform4dv")]
        public abstract void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glProgramUniform4ui")]
        public abstract void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1, [Flow(FlowDirection.In)] uint v2, [Flow(FlowDirection.In)] uint v3);

        [NativeApi(EntryPoint = "glProgramUniform4uiv")]
        public abstract unsafe void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform4uiv")]
        public abstract void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2fv")]
        public abstract unsafe void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2fv")]
        public abstract void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2dv")]
        public abstract unsafe void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2dv")]
        public abstract void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3fv")]
        public abstract unsafe void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3fv")]
        public abstract void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3dv")]
        public abstract unsafe void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3dv")]
        public abstract void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4fv")]
        public abstract unsafe void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4fv")]
        public abstract void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4dv")]
        public abstract unsafe void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4dv")]
        public abstract void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3fv")]
        public abstract unsafe void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3fv")]
        public abstract void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3dv")]
        public abstract unsafe void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3dv")]
        public abstract void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2fv")]
        public abstract unsafe void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2fv")]
        public abstract void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2dv")]
        public abstract unsafe void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2dv")]
        public abstract void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4fv")]
        public abstract unsafe void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4fv")]
        public abstract void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4dv")]
        public abstract unsafe void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4dv")]
        public abstract void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4fv")]
        public abstract unsafe void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4fv")]
        public abstract void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4dv")]
        public abstract unsafe void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4dv")]
        public abstract void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2fv")]
        public abstract unsafe void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2fv")]
        public abstract void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2dv")]
        public abstract unsafe void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2dv")]
        public abstract void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3fv")]
        public abstract unsafe void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3fv")]
        public abstract void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3dv")]
        public abstract unsafe void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3dv")]
        public abstract void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glReleaseShaderCompiler")]
        public abstract void ReleaseShaderCompiler();

        [NativeApi(EntryPoint = "glScissorArrayv")]
        public abstract unsafe void ScissorArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glScissorArrayv")]
        public abstract void ScissorArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] ref int v);

        [NativeApi(EntryPoint = "glScissorIndexed")]
        public abstract void ScissorIndexed([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int left, [Flow(FlowDirection.In)] int bottom, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glScissorIndexedv")]
        public abstract unsafe void ScissorIndexed([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glScissorIndexedv")]
        public abstract void ScissorIndexed([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> v);

        [NativeApi(EntryPoint = "glShaderBinary")]
        public abstract unsafe void ShaderBinary([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* shaders, [Flow(FlowDirection.In)] GLEnum binaryformat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length);

        [NativeApi(EntryPoint = "glShaderBinary")]
        public abstract void ShaderBinary<T0>([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> shaders, [Flow(FlowDirection.In)] GLEnum binaryformat, [Count(Parameter = "length"), Flow(FlowDirection.In)] Span<T0> binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glUseProgramStages")]
        public abstract void UseProgramStages([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint stages, [Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glValidateProgramPipeline")]
        public abstract void ValidateProgramPipeline([Flow(FlowDirection.In)] uint pipeline);

        [NativeApi(EntryPoint = "glVertexAttribL1d")]
        public abstract void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x);

        [NativeApi(EntryPoint = "glVertexAttribL1dv")]
        public abstract unsafe void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttribL1dv")]
        public abstract void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref double v);

        [NativeApi(EntryPoint = "glVertexAttribL2d")]
        public abstract void VertexAttribL2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y);

        [NativeApi(EntryPoint = "glVertexAttribL2dv")]
        public abstract unsafe void VertexAttribL2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttribL2dv")]
        public abstract void VertexAttribL2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<double> v);

        [NativeApi(EntryPoint = "glVertexAttribL3d")]
        public abstract void VertexAttribL3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glVertexAttribL3dv")]
        public abstract unsafe void VertexAttribL3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttribL3dv")]
        public abstract void VertexAttribL3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<double> v);

        [NativeApi(EntryPoint = "glVertexAttribL4d")]
        public abstract void VertexAttribL4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glVertexAttribL4dv")]
        public abstract unsafe void VertexAttribL4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttribL4dv")]
        public abstract void VertexAttribL4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> v);

        [NativeApi(EntryPoint = "glVertexAttribLPointer")]
        public abstract unsafe void VertexAttribLPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint stride, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribLPointer")]
        public abstract void VertexAttribLPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint stride, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glViewportArrayv")]
        public abstract unsafe void ViewportArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glViewportArrayv")]
        public abstract void ViewportArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] ref float v);

        [NativeApi(EntryPoint = "glViewportIndexedf")]
        public abstract void ViewportIndexed([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float w, [Flow(FlowDirection.In)] float h);

        [NativeApi(EntryPoint = "glViewportIndexedfv")]
        public abstract unsafe void ViewportIndexed([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glViewportIndexedfv")]
        public abstract void ViewportIndexed([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> v);

        [NativeApi(EntryPoint = "glCreateShaderProgramv")]
        public abstract unsafe uint CreateShaderProgram([Flow(FlowDirection.In)] ShaderType type, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] byte** strings);

        [NativeApi(EntryPoint = "glGetProgramPipelineiv")]
        public abstract unsafe void GetProgramPipeline([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] PipelineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramPipelineiv")]
        public abstract void GetProgramPipeline([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] PipelineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLog")]
        public abstract unsafe void GetProgramPipelineInfoLog([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string infoLog);

        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLog")]
        public abstract void GetProgramPipelineInfoLog([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string infoLog);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public abstract unsafe void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public abstract void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] Span<int> range, [Count(Count = 1), Flow(FlowDirection.Out)] out int precision);

        [NativeApi(EntryPoint = "glGetVertexAttribLdv")]
        public abstract unsafe void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribLdv")]
        public abstract void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glProgramParameteri")]
        public abstract void ProgramParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramParameterPName pname, [Flow(FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glVertexAttribLPointer")]
        public abstract unsafe void VertexAttribLPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribLType type, [Flow(FlowDirection.In)] uint stride, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribLPointer")]
        public abstract void VertexAttribLPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribLType type, [Flow(FlowDirection.In)] uint stride, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBeginQueryIndexed")]
        public abstract void BeginQueryIndexed([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glBindTransformFeedback")]
        public abstract void BindTransformFeedback([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glBlendEquationi")]
        public abstract void BlendEquation([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] GLEnum mode);

        [NativeApi(EntryPoint = "glBlendEquationSeparatei")]
        public abstract void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] GLEnum modeRGB, [Flow(FlowDirection.In)] GLEnum modeAlpha);

        [NativeApi(EntryPoint = "glBlendFunci")]
        public abstract void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] GLEnum src, [Flow(FlowDirection.In)] GLEnum dst);

        [NativeApi(EntryPoint = "glBlendFuncSeparatei")]
        public abstract void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] GLEnum srcRGB, [Flow(FlowDirection.In)] GLEnum dstRGB, [Flow(FlowDirection.In)] GLEnum srcAlpha, [Flow(FlowDirection.In)] GLEnum dstAlpha);

        [NativeApi(EntryPoint = "glDeleteTransformFeedbacks")]
        public abstract unsafe void DeleteTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* ids);

        [NativeApi(EntryPoint = "glDeleteTransformFeedbacks")]
        public abstract void DeleteTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> ids);

        [NativeApi(EntryPoint = "glDrawArraysIndirect")]
        public abstract unsafe void DrawArraysIndirect([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] void* indirect);

        [NativeApi(EntryPoint = "glDrawArraysIndirect")]
        public abstract void DrawArraysIndirect<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] Span<T0> indirect) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        public abstract unsafe void DrawElementsIndirect([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] void* indirect);

        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        public abstract void DrawElementsIndirect<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] Span<T0> indirect) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawTransformFeedback")]
        public abstract void DrawTransformFeedback([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDrawTransformFeedbackStream")]
        public abstract void DrawTransformFeedbackStream([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint stream);

        [NativeApi(EntryPoint = "glEndQueryIndexed")]
        public abstract void EndQueryIndexed([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glGenTransformFeedbacks")]
        public abstract unsafe void GenTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glGenTransformFeedbacks")]
        public abstract void GenTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids);

        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        public abstract unsafe void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        public abstract void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv")]
        public abstract unsafe void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv")]
        public abstract void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        public abstract unsafe void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        public abstract void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name);

        [NativeApi(EntryPoint = "glGetProgramStageiv")]
        public abstract unsafe void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetProgramStageiv")]
        public abstract void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetQueryIndexediv")]
        public abstract unsafe void GetQueryIndexed([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryIndexediv")]
        public abstract void GetQueryIndexed([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSubroutineIndex")]
        public abstract unsafe uint GetSubroutineIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetSubroutineIndex")]
        public abstract uint GetSubroutineIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] Span<byte> name);

        [NativeApi(EntryPoint = "glGetSubroutineUniformLocation")]
        public abstract unsafe int GetSubroutineUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetSubroutineUniformLocation")]
        public abstract int GetSubroutineUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] Span<byte> name);

        [NativeApi(EntryPoint = "glGetUniformdv")]
        public abstract unsafe void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetUniformdv")]
        public abstract void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetUniformSubroutineuiv")]
        public abstract unsafe void GetUniformSubroutine([Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] int location, [Count(Count = 1), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetUniformSubroutineuiv")]
        public abstract void GetUniformSubroutine([Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] int location, [Count(Count = 1), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glIsTransformFeedback")]
        public abstract bool IsTransformFeedback([Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glMinSampleShading")]
        public abstract void MinSampleShading([Flow(FlowDirection.In)] float value);

        [NativeApi(EntryPoint = "glPatchParameteri")]
        public abstract void PatchParameter([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glPatchParameterfv")]
        public abstract unsafe void PatchParameter([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* values);

        [NativeApi(EntryPoint = "glPatchParameterfv")]
        public abstract void PatchParameter([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float values);

        [NativeApi(EntryPoint = "glPauseTransformFeedback")]
        public abstract void PauseTransformFeedback();

        [NativeApi(EntryPoint = "glResumeTransformFeedback")]
        public abstract void ResumeTransformFeedback();

        [NativeApi(EntryPoint = "glUniform1d")]
        public abstract void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x);

        [NativeApi(EntryPoint = "glUniform1dv")]
        public abstract unsafe void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniform1dv")]
        public abstract void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glUniform2d")]
        public abstract void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y);

        [NativeApi(EntryPoint = "glUniform2dv")]
        public abstract unsafe void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniform2dv")]
        public abstract void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glUniform3d")]
        public abstract void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glUniform3dv")]
        public abstract unsafe void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniform3dv")]
        public abstract void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glUniform4d")]
        public abstract void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glUniform4dv")]
        public abstract unsafe void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniform4dv")]
        public abstract void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glUniformMatrix2dv")]
        public abstract unsafe void UniformMatrix2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix2dv")]
        public abstract void UniformMatrix2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glUniformMatrix2x3dv")]
        public abstract unsafe void UniformMatrix2x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix2x3dv")]
        public abstract void UniformMatrix2x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glUniformMatrix2x4dv")]
        public abstract unsafe void UniformMatrix2x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix2x4dv")]
        public abstract void UniformMatrix2x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glUniformMatrix3dv")]
        public abstract unsafe void UniformMatrix3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix3dv")]
        public abstract void UniformMatrix3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glUniformMatrix3x2dv")]
        public abstract unsafe void UniformMatrix3x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix3x2dv")]
        public abstract void UniformMatrix3x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glUniformMatrix3x4dv")]
        public abstract unsafe void UniformMatrix3x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix3x4dv")]
        public abstract void UniformMatrix3x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glUniformMatrix4dv")]
        public abstract unsafe void UniformMatrix4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix4dv")]
        public abstract void UniformMatrix4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glUniformMatrix4x2dv")]
        public abstract unsafe void UniformMatrix4x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix4x2dv")]
        public abstract void UniformMatrix4x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glUniformMatrix4x3dv")]
        public abstract unsafe void UniformMatrix4x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix4x3dv")]
        public abstract void UniformMatrix4x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glUniformSubroutinesuiv")]
        public abstract unsafe void UniformSubroutines([Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* indices);

        [NativeApi(EntryPoint = "glUniformSubroutinesuiv")]
        public abstract void UniformSubroutines([Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> indices);

        [NativeApi(EntryPoint = "glBeginQueryIndexed")]
        public abstract void BeginQueryIndexed([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glBindTransformFeedback")]
        public abstract void BindTransformFeedback([Flow(FlowDirection.In)] BindTransformFeedbackTarget target, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glBlendEquationi")]
        public abstract void BlendEquation([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT mode);

        [NativeApi(EntryPoint = "glBlendEquationSeparatei")]
        public abstract void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendFunci")]
        public abstract void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor src, [Flow(FlowDirection.In)] BlendingFactor dst);

        [NativeApi(EntryPoint = "glBlendFuncSeparatei")]
        public abstract void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glDrawArraysIndirect")]
        public abstract unsafe void DrawArraysIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] void* indirect);

        [NativeApi(EntryPoint = "glDrawArraysIndirect")]
        public abstract void DrawArraysIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] Span<T0> indirect) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        public abstract unsafe void DrawElementsIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] void* indirect);

        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        public abstract void DrawElementsIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] Span<T0> indirect) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawTransformFeedback")]
        public abstract void DrawTransformFeedback([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDrawTransformFeedbackStream")]
        public abstract void DrawTransformFeedbackStream([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint stream);

        [NativeApi(EntryPoint = "glEndQueryIndexed")]
        public abstract void EndQueryIndexed([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        public abstract unsafe void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        public abstract void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv")]
        public abstract unsafe void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] SubroutineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv")]
        public abstract void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] SubroutineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        public abstract unsafe void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        public abstract void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string name);

        [NativeApi(EntryPoint = "glGetProgramStageiv")]
        public abstract unsafe void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] ProgramStagePName pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetProgramStageiv")]
        public abstract void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] ProgramStagePName pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetQueryIndexediv")]
        public abstract unsafe void GetQueryIndexed([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryIndexediv")]
        public abstract void GetQueryIndexed([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSubroutineIndex")]
        public abstract uint GetSubroutineIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetSubroutineUniformLocation")]
        public abstract int GetSubroutineUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetUniformSubroutineuiv")]
        public abstract unsafe void GetUniformSubroutine([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] int location, [Count(Count = 1), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetUniformSubroutineuiv")]
        public abstract void GetUniformSubroutine([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] int location, [Count(Count = 1), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glPatchParameteri")]
        public abstract void PatchParameter([Flow(FlowDirection.In)] PatchParameterName pname, [Flow(FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glPatchParameterfv")]
        public abstract unsafe void PatchParameter([Flow(FlowDirection.In)] PatchParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* values);

        [NativeApi(EntryPoint = "glPatchParameterfv")]
        public abstract void PatchParameter([Flow(FlowDirection.In)] PatchParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float values);

        [NativeApi(EntryPoint = "glUniformSubroutinesuiv")]
        public abstract unsafe void UniformSubroutines([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* indices);

        [NativeApi(EntryPoint = "glUniformSubroutinesuiv")]
        public abstract void UniformSubroutines([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> indices);

        [NativeApi(EntryPoint = "glBindFragDataLocationIndexed")]
        public abstract unsafe void BindFragDataLocationIndexed([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glBindFragDataLocationIndexed")]
        public abstract void BindFragDataLocationIndexed([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Span<byte> name);

        [NativeApi(EntryPoint = "glBindSampler")]
        public abstract void BindSampler([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint sampler);

        [NativeApi(EntryPoint = "glColorP3ui")]
        public abstract void ColorP3([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint color);

        [NativeApi(EntryPoint = "glColorP3uiv")]
        public abstract unsafe void ColorP3([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color);

        [NativeApi(EntryPoint = "glColorP3uiv")]
        public abstract void ColorP3([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint color);

        [NativeApi(EntryPoint = "glColorP4ui")]
        public abstract void ColorP4([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint color);

        [NativeApi(EntryPoint = "glColorP4uiv")]
        public abstract unsafe void ColorP4([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color);

        [NativeApi(EntryPoint = "glColorP4uiv")]
        public abstract void ColorP4([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint color);

        [NativeApi(EntryPoint = "glDeleteSamplers")]
        public abstract unsafe void DeleteSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* samplers);

        [NativeApi(EntryPoint = "glDeleteSamplers")]
        public abstract void DeleteSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> samplers);

        [NativeApi(EntryPoint = "glGenSamplers")]
        public abstract unsafe void GenSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* samplers);

        [NativeApi(EntryPoint = "glGenSamplers")]
        public abstract void GenSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> samplers);

        [NativeApi(EntryPoint = "glGetFragDataIndex")]
        public abstract unsafe int GetFragDataIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetFragDataIndex")]
        public abstract int GetFragDataIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] Span<byte> name);

        [NativeApi(EntryPoint = "glGetQueryObjecti64v")]
        public abstract unsafe void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetQueryObjecti64v")]
        public abstract void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetQueryObjectui64v")]
        public abstract unsafe void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectui64v")]
        public abstract void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out ulong @params);

        [NativeApi(EntryPoint = "glGetSamplerParameteriv")]
        public abstract unsafe void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameteriv")]
        public abstract void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterfv")]
        public abstract unsafe void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterfv")]
        public abstract void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIiv")]
        public abstract unsafe void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIiv")]
        public abstract void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv")]
        public abstract unsafe void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv")]
        public abstract void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glIsSampler")]
        public abstract bool IsSampler([Flow(FlowDirection.In)] uint sampler);

        [NativeApi(EntryPoint = "glMultiTexCoordP1ui")]
        public abstract void MultiTexCoordP1([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv")]
        public abstract unsafe void MultiTexCoordP1([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv")]
        public abstract void MultiTexCoordP1([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2ui")]
        public abstract void MultiTexCoordP2([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv")]
        public abstract unsafe void MultiTexCoordP2([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv")]
        public abstract void MultiTexCoordP2([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3ui")]
        public abstract void MultiTexCoordP3([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv")]
        public abstract unsafe void MultiTexCoordP3([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv")]
        public abstract void MultiTexCoordP3([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4ui")]
        public abstract void MultiTexCoordP4([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv")]
        public abstract unsafe void MultiTexCoordP4([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv")]
        public abstract void MultiTexCoordP4([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glNormalP3ui")]
        public abstract void NormalP3([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glNormalP3uiv")]
        public abstract unsafe void NormalP3([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glNormalP3uiv")]
        public abstract void NormalP3([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glQueryCounter")]
        public abstract void QueryCounter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum target);

        [NativeApi(EntryPoint = "glSamplerParameteri")]
        public abstract void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glSamplerParameteriv")]
        public abstract unsafe void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameteriv")]
        public abstract void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

        [NativeApi(EntryPoint = "glSamplerParameterf")]
        public abstract void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glSamplerParameterfv")]
        public abstract unsafe void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* param);

        [NativeApi(EntryPoint = "glSamplerParameterfv")]
        public abstract void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float param);

        [NativeApi(EntryPoint = "glSamplerParameterIiv")]
        public abstract unsafe void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameterIiv")]
        public abstract void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

        [NativeApi(EntryPoint = "glSamplerParameterIuiv")]
        public abstract unsafe void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* param);

        [NativeApi(EntryPoint = "glSamplerParameterIuiv")]
        public abstract void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint param);

        [NativeApi(EntryPoint = "glSecondaryColorP3ui")]
        public abstract void SecondaryColorP3([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint color);

        [NativeApi(EntryPoint = "glSecondaryColorP3uiv")]
        public abstract unsafe void SecondaryColorP3([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color);

        [NativeApi(EntryPoint = "glSecondaryColorP3uiv")]
        public abstract void SecondaryColorP3([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint color);

        [NativeApi(EntryPoint = "glTexCoordP1ui")]
        public abstract void TexCoordP1([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP1uiv")]
        public abstract unsafe void TexCoordP1([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP1uiv")]
        public abstract void TexCoordP1([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glTexCoordP2ui")]
        public abstract void TexCoordP2([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP2uiv")]
        public abstract unsafe void TexCoordP2([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP2uiv")]
        public abstract void TexCoordP2([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glTexCoordP3ui")]
        public abstract void TexCoordP3([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP3uiv")]
        public abstract unsafe void TexCoordP3([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP3uiv")]
        public abstract void TexCoordP3([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glTexCoordP4ui")]
        public abstract void TexCoordP4([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP4uiv")]
        public abstract unsafe void TexCoordP4([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP4uiv")]
        public abstract void TexCoordP4([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glVertexAttribDivisor")]
        public abstract void VertexAttribDivisor([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint divisor);

        [NativeApi(EntryPoint = "glVertexAttribP1ui")]
        public abstract void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP1uiv")]
        public abstract unsafe void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP1uiv")]
        public abstract void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glVertexAttribP2ui")]
        public abstract void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP2uiv")]
        public abstract unsafe void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP2uiv")]
        public abstract void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glVertexAttribP3ui")]
        public abstract void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP3uiv")]
        public abstract unsafe void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP3uiv")]
        public abstract void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glVertexAttribP4ui")]
        public abstract void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP4uiv")]
        public abstract unsafe void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP4uiv")]
        public abstract void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glVertexP2ui")]
        public abstract void VertexP2([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexP2uiv")]
        public abstract unsafe void VertexP2([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexP2uiv")]
        public abstract void VertexP2([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glVertexP3ui")]
        public abstract void VertexP3([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexP3uiv")]
        public abstract unsafe void VertexP3([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexP3uiv")]
        public abstract void VertexP3([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glVertexP4ui")]
        public abstract void VertexP4([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexP4uiv")]
        public abstract unsafe void VertexP4([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexP4uiv")]
        public abstract void VertexP4([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glBindFragDataLocationIndexed")]
        public abstract void BindFragDataLocationIndexed([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glColorP3ui")]
        public abstract void ColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint color);

        [NativeApi(EntryPoint = "glColorP3uiv")]
        public abstract unsafe void ColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color);

        [NativeApi(EntryPoint = "glColorP3uiv")]
        public abstract void ColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint color);

        [NativeApi(EntryPoint = "glColorP4ui")]
        public abstract void ColorP4([Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint color);

        [NativeApi(EntryPoint = "glColorP4uiv")]
        public abstract unsafe void ColorP4([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color);

        [NativeApi(EntryPoint = "glColorP4uiv")]
        public abstract void ColorP4([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint color);

        [NativeApi(EntryPoint = "glGetFragDataIndex")]
        public abstract int GetFragDataIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetQueryObjecti64v")]
        public abstract unsafe void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetQueryObjecti64v")]
        public abstract void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetQueryObjectui64v")]
        public abstract unsafe void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectui64v")]
        public abstract void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out ulong @params);

        [NativeApi(EntryPoint = "glGetSamplerParameteriv")]
        public abstract unsafe void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameteriv")]
        public abstract void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterfv")]
        public abstract unsafe void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterfv")]
        public abstract void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIiv")]
        public abstract unsafe void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIiv")]
        public abstract void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv")]
        public abstract unsafe void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv")]
        public abstract void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glMultiTexCoordP1ui")]
        public abstract void MultiTexCoordP1([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv")]
        public abstract unsafe void MultiTexCoordP1([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv")]
        public abstract void MultiTexCoordP1([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2ui")]
        public abstract void MultiTexCoordP2([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv")]
        public abstract unsafe void MultiTexCoordP2([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv")]
        public abstract void MultiTexCoordP2([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3ui")]
        public abstract void MultiTexCoordP3([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv")]
        public abstract unsafe void MultiTexCoordP3([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv")]
        public abstract void MultiTexCoordP3([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4ui")]
        public abstract void MultiTexCoordP4([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv")]
        public abstract unsafe void MultiTexCoordP4([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv")]
        public abstract void MultiTexCoordP4([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glNormalP3ui")]
        public abstract void NormalP3([Flow(FlowDirection.In)] NormalPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glNormalP3uiv")]
        public abstract unsafe void NormalP3([Flow(FlowDirection.In)] NormalPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glNormalP3uiv")]
        public abstract void NormalP3([Flow(FlowDirection.In)] NormalPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glQueryCounter")]
        public abstract void QueryCounter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryCounterTarget target);

        [NativeApi(EntryPoint = "glSamplerParameteri")]
        public abstract void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glSamplerParameteriv")]
        public abstract unsafe void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameteriv")]
        public abstract void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

        [NativeApi(EntryPoint = "glSamplerParameterf")]
        public abstract void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glSamplerParameterfv")]
        public abstract unsafe void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* param);

        [NativeApi(EntryPoint = "glSamplerParameterfv")]
        public abstract void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float param);

        [NativeApi(EntryPoint = "glSamplerParameterIiv")]
        public abstract unsafe void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameterIiv")]
        public abstract void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

        [NativeApi(EntryPoint = "glSamplerParameterIuiv")]
        public abstract unsafe void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* param);

        [NativeApi(EntryPoint = "glSamplerParameterIuiv")]
        public abstract void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint param);

        [NativeApi(EntryPoint = "glSecondaryColorP3ui")]
        public abstract void SecondaryColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint color);

        [NativeApi(EntryPoint = "glSecondaryColorP3uiv")]
        public abstract unsafe void SecondaryColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color);

        [NativeApi(EntryPoint = "glSecondaryColorP3uiv")]
        public abstract void SecondaryColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint color);

        [NativeApi(EntryPoint = "glTexCoordP1ui")]
        public abstract void TexCoordP1([Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP1uiv")]
        public abstract unsafe void TexCoordP1([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP1uiv")]
        public abstract void TexCoordP1([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glTexCoordP2ui")]
        public abstract void TexCoordP2([Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP2uiv")]
        public abstract unsafe void TexCoordP2([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP2uiv")]
        public abstract void TexCoordP2([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glTexCoordP3ui")]
        public abstract void TexCoordP3([Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP3uiv")]
        public abstract unsafe void TexCoordP3([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP3uiv")]
        public abstract void TexCoordP3([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glTexCoordP4ui")]
        public abstract void TexCoordP4([Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP4uiv")]
        public abstract unsafe void TexCoordP4([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP4uiv")]
        public abstract void TexCoordP4([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glVertexAttribP1ui")]
        public abstract void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP1uiv")]
        public abstract unsafe void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP1uiv")]
        public abstract void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glVertexAttribP2ui")]
        public abstract void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP2uiv")]
        public abstract unsafe void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP2uiv")]
        public abstract void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glVertexAttribP3ui")]
        public abstract void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP3uiv")]
        public abstract unsafe void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP3uiv")]
        public abstract void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glVertexAttribP4ui")]
        public abstract void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP4uiv")]
        public abstract unsafe void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP4uiv")]
        public abstract void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glVertexP2ui")]
        public abstract void VertexP2([Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexP2uiv")]
        public abstract unsafe void VertexP2([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexP2uiv")]
        public abstract void VertexP2([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glVertexP3ui")]
        public abstract void VertexP3([Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexP3uiv")]
        public abstract unsafe void VertexP3([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexP3uiv")]
        public abstract void VertexP3([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glVertexP4ui")]
        public abstract void VertexP4([Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexP4uiv")]
        public abstract unsafe void VertexP4([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexP4uiv")]
        public abstract void VertexP4([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glClientWaitSync")]
        public abstract GLEnum ClientWaitSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] ulong timeout);

        [NativeApi(EntryPoint = "glDeleteSync")]
        public abstract void DeleteSync([Flow(FlowDirection.In)] IntPtr sync);

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public abstract unsafe void DrawElementsBaseVertex([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public abstract void DrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public abstract unsafe void DrawElementsInstancedBaseVertex([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public abstract void DrawElementsInstancedBaseVertex<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public abstract unsafe void DrawRangeElementsBaseVertex([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public abstract void DrawRangeElementsBaseVertex<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glFenceSync")]
        public abstract IntPtr FenceSync([Flow(FlowDirection.In)] GLEnum condition, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glFramebufferTexture")]
        public abstract void FramebufferTexture([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glGetBufferParameteri64v")]
        public abstract unsafe void GetBufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetBufferParameteri64v")]
        public abstract void GetBufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetInteger64v")]
        public abstract unsafe void GetInteger64([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* data);

        [NativeApi(EntryPoint = "glGetInteger64v")]
        public abstract void GetInteger64([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long data);

        [NativeApi(EntryPoint = "glGetInteger64i_v")]
        public abstract unsafe void GetInteger64([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] long* data);

        [NativeApi(EntryPoint = "glGetInteger64i_v")]
        public abstract void GetInteger64([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out long data);

        [NativeApi(EntryPoint = "glGetMultisamplefv")]
        public abstract unsafe void GetMultisample([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* val);

        [NativeApi(EntryPoint = "glGetMultisamplefv")]
        public abstract void GetMultisample([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float val);

        [NativeApi(EntryPoint = "glGetSynciv")]
        public abstract unsafe void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetSynciv")]
        public abstract void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values);

        [NativeApi(EntryPoint = "glIsSync")]
        public abstract bool IsSync([Flow(FlowDirection.In)] IntPtr sync);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public abstract unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] GLEnum mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public abstract unsafe void MultiDrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] GLEnum mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref T0* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glProvokingVertex")]
        public abstract void ProvokingVertex([Flow(FlowDirection.In)] GLEnum mode);

        [NativeApi(EntryPoint = "glSampleMaski")]
        public abstract void SampleMask([Flow(FlowDirection.In)] uint maskNumber, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glTexImage2DMultisample")]
        public abstract void TexImage2DMultisample([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexImage3DMultisample")]
        public abstract void TexImage3DMultisample([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glWaitSync")]
        public abstract void WaitSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] ulong timeout);

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public abstract unsafe void DrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public abstract void DrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public abstract unsafe void DrawElementsInstancedBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public abstract void DrawElementsInstancedBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public abstract unsafe void DrawRangeElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public abstract void DrawRangeElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glFenceSync")]
        public abstract IntPtr FenceSync([Flow(FlowDirection.In)] SyncCondition condition, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glFramebufferTexture")]
        public abstract void FramebufferTexture([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glGetBufferParameteri64v")]
        public abstract unsafe void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetBufferParameteri64v")]
        public abstract void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetInteger64v")]
        public abstract unsafe void GetInteger64([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* data);

        [NativeApi(EntryPoint = "glGetInteger64v")]
        public abstract void GetInteger64([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long data);

        [NativeApi(EntryPoint = "glGetMultisamplefv")]
        public abstract unsafe void GetMultisample([Flow(FlowDirection.In)] GetMultisamplePNameNV pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* val);

        [NativeApi(EntryPoint = "glGetMultisamplefv")]
        public abstract void GetMultisample([Flow(FlowDirection.In)] GetMultisamplePNameNV pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float val);

        [NativeApi(EntryPoint = "glGetSynciv")]
        public abstract unsafe void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetSynciv")]
        public abstract void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public abstract unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public abstract unsafe void MultiDrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref T0* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glProvokingVertex")]
        public abstract void ProvokingVertex([Flow(FlowDirection.In)] VertexProvokingMode mode);

        [NativeApi(EntryPoint = "glTexImage2DMultisample")]
        public abstract void TexImage2DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexImage3DMultisample")]
        public abstract void TexImage3DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glBindBufferBase")]
        public abstract void BindBufferBase([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBindBufferRange")]
        public abstract void BindBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glCopyBufferSubData")]
        public abstract void CopyBufferSubData([Flow(FlowDirection.In)] GLEnum readTarget, [Flow(FlowDirection.In)] GLEnum writeTarget, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glDrawArraysInstanced")]
        public abstract void DrawArraysInstanced([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glDrawElementsInstanced")]
        public abstract unsafe void DrawElementsInstanced([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glDrawElementsInstanced")]
        public abstract void DrawElementsInstanced<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] uint instancecount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetActiveUniformBlockiv")]
        public abstract unsafe void GetActiveUniformBlock([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockiv")]
        public abstract void GetActiveUniformBlock([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockName")]
        public abstract unsafe void GetActiveUniformBlockName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* uniformBlockName);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockName")]
        public abstract void GetActiveUniformBlockName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> uniformBlockName);

        [NativeApi(EntryPoint = "glGetActiveUniformName")]
        public abstract unsafe void GetActiveUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* uniformName);

        [NativeApi(EntryPoint = "glGetActiveUniformName")]
        public abstract void GetActiveUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> uniformName);

        [NativeApi(EntryPoint = "glGetActiveUniformsiv")]
        public abstract unsafe void GetActiveUniforms([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] uint* uniformIndices, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetActiveUniformsiv")]
        public abstract void GetActiveUniforms([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] Span<uint> uniformIndices, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetIntegeri_v")]
        public abstract unsafe void GetInteger([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetIntegeri_v")]
        public abstract void GetInteger([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetUniformBlockIndex")]
        public abstract unsafe uint GetUniformBlockIndex([Flow(FlowDirection.In)] uint program, [Count(Count = 0), Flow(FlowDirection.In)] byte* uniformBlockName);

        [NativeApi(EntryPoint = "glGetUniformBlockIndex")]
        public abstract uint GetUniformBlockIndex([Flow(FlowDirection.In)] uint program, [Count(Count = 0), Flow(FlowDirection.In)] ref byte uniformBlockName);

        [NativeApi(EntryPoint = "glGetUniformIndices")]
        public abstract unsafe void GetUniformIndices([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(FlowDirection.In)] byte** uniformNames, [Count(Computed = "uniformCount"), Flow(FlowDirection.Out)] uint* uniformIndices);

        [NativeApi(EntryPoint = "glGetUniformIndices")]
        public abstract unsafe void GetUniformIndices([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(FlowDirection.In)] ref byte* uniformNames, [Count(Computed = "uniformCount"), Flow(FlowDirection.Out)] out uint uniformIndices);

        [NativeApi(EntryPoint = "glPrimitiveRestartIndex")]
        public abstract void PrimitiveRestartIndex([Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glTexBuffer")]
        public abstract void TexBuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glUniformBlockBinding")]
        public abstract void UniformBlockBinding([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint uniformBlockBinding);

        [NativeApi(EntryPoint = "glBindBufferBase")]
        public abstract void BindBufferBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBindBufferRange")]
        public abstract void BindBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glCopyBufferSubData")]
        public abstract void CopyBufferSubData([Flow(FlowDirection.In)] CopyBufferSubDataTarget readTarget, [Flow(FlowDirection.In)] CopyBufferSubDataTarget writeTarget, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glDrawArraysInstanced")]
        public abstract void DrawArraysInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glDrawElementsInstanced")]
        public abstract unsafe void DrawElementsInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glDrawElementsInstanced")]
        public abstract void DrawElementsInstanced<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] uint instancecount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetActiveUniformBlockiv")]
        public abstract unsafe void GetActiveUniformBlock([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] UniformBlockPName pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockiv")]
        public abstract void GetActiveUniformBlock([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] UniformBlockPName pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockName")]
        public abstract unsafe void GetActiveUniformBlockName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string uniformBlockName);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockName")]
        public abstract void GetActiveUniformBlockName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string uniformBlockName);

        [NativeApi(EntryPoint = "glGetActiveUniformName")]
        public abstract unsafe void GetActiveUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string uniformName);

        [NativeApi(EntryPoint = "glGetActiveUniformName")]
        public abstract void GetActiveUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string uniformName);

        [NativeApi(EntryPoint = "glGetActiveUniformsiv")]
        public abstract unsafe void GetActiveUniforms([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] uint* uniformIndices, [Flow(FlowDirection.In)] UniformPName pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetActiveUniformsiv")]
        public abstract void GetActiveUniforms([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] Span<uint> uniformIndices, [Flow(FlowDirection.In)] UniformPName pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetUniformBlockIndex")]
        public abstract uint GetUniformBlockIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string uniformBlockName);

        [NativeApi(EntryPoint = "glTexBuffer")]
        public abstract void TexBuffer([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBeginConditionalRender")]
        public abstract void BeginConditionalRender([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum mode);

        [NativeApi(EntryPoint = "glBeginTransformFeedback")]
        public abstract void BeginTransformFeedback([Flow(FlowDirection.In)] GLEnum primitiveMode);

        [NativeApi(EntryPoint = "glBindFragDataLocation")]
        public abstract unsafe void BindFragDataLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint color, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glBindFragDataLocation")]
        public abstract void BindFragDataLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint color, [Count(Computed = "name"), Flow(FlowDirection.In)] ref byte name);

        [NativeApi(EntryPoint = "glBindFramebuffer")]
        public abstract void BindFramebuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint framebuffer);

        [NativeApi(EntryPoint = "glBindRenderbuffer")]
        public abstract void BindRenderbuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glBindVertexArray")]
        public abstract void BindVertexArray([Flow(FlowDirection.In)] uint array);

        [NativeApi(EntryPoint = "glBlitFramebuffer")]
        public abstract void BlitFramebuffer([Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] GLEnum filter);

        [NativeApi(EntryPoint = "glCheckFramebufferStatus")]
        public abstract GLEnum CheckFramebufferStatus([Flow(FlowDirection.In)] GLEnum target);

        [NativeApi(EntryPoint = "glClampColor")]
        public abstract void ClampColor([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum clamp);

        [NativeApi(EntryPoint = "glClearBufferiv")]
        public abstract unsafe void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glClearBufferiv")]
        public abstract void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ref int value);

        [NativeApi(EntryPoint = "glClearBufferuiv")]
        public abstract unsafe void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glClearBufferuiv")]
        public abstract void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glClearBufferfv")]
        public abstract unsafe void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glClearBufferfv")]
        public abstract void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ref float value);

        [NativeApi(EntryPoint = "glClearBufferfi")]
        public abstract void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float depth, [Flow(FlowDirection.In)] int stencil);

        [NativeApi(EntryPoint = "glColorMaski")]
        public abstract void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] bool r, [Flow(FlowDirection.In)] bool g, [Flow(FlowDirection.In)] bool b, [Flow(FlowDirection.In)] bool a);

        [NativeApi(EntryPoint = "glDeleteFramebuffers")]
        public abstract unsafe void DeleteFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* framebuffers);

        [NativeApi(EntryPoint = "glDeleteFramebuffers")]
        public abstract void DeleteFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> framebuffers);

        [NativeApi(EntryPoint = "glDeleteRenderbuffers")]
        public abstract unsafe void DeleteRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* renderbuffers);

        [NativeApi(EntryPoint = "glDeleteRenderbuffers")]
        public abstract void DeleteRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> renderbuffers);

        [NativeApi(EntryPoint = "glDeleteVertexArrays")]
        public abstract unsafe void DeleteVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* arrays);

        [NativeApi(EntryPoint = "glDeleteVertexArrays")]
        public abstract void DeleteVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> arrays);

        [NativeApi(EntryPoint = "glDisablei")]
        public abstract void Disable([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnablei")]
        public abstract void Enable([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEndConditionalRender")]
        public abstract void EndConditionalRender();

        [NativeApi(EntryPoint = "glEndTransformFeedback")]
        public abstract void EndTransformFeedback();

        [NativeApi(EntryPoint = "glFlushMappedBufferRange")]
        public abstract void FlushMappedBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length);

        [NativeApi(EntryPoint = "glFramebufferRenderbuffer")]
        public abstract void FramebufferRenderbuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferTexture1D")]
        public abstract void FramebufferTexture1D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture2D")]
        public abstract void FramebufferTexture2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture3D")]
        public abstract void FramebufferTexture3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glFramebufferTextureLayer")]
        public abstract void FramebufferTextureLayer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glGenerateMipmap")]
        public abstract void GenerateMipmap([Flow(FlowDirection.In)] GLEnum target);

        [NativeApi(EntryPoint = "glGenFramebuffers")]
        public abstract unsafe void GenFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* framebuffers);

        [NativeApi(EntryPoint = "glGenFramebuffers")]
        public abstract void GenFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> framebuffers);

        [NativeApi(EntryPoint = "glGenRenderbuffers")]
        public abstract unsafe void GenRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* renderbuffers);

        [NativeApi(EntryPoint = "glGenRenderbuffers")]
        public abstract void GenRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> renderbuffers);

        [NativeApi(EntryPoint = "glGenVertexArrays")]
        public abstract unsafe void GenVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* arrays);

        [NativeApi(EntryPoint = "glGenVertexArrays")]
        public abstract void GenVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> arrays);

        [NativeApi(EntryPoint = "glGetBooleani_v")]
        public abstract unsafe void GetBoolean([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetBooleani_v")]
        public abstract void GetBoolean([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetFragDataLocation")]
        public abstract unsafe int GetFragDataLocation([Flow(FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetFragDataLocation")]
        public abstract int GetFragDataLocation([Flow(FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(FlowDirection.In)] ref byte name);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public abstract unsafe void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public abstract void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv")]
        public abstract unsafe void GetRenderbufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv")]
        public abstract void GetRenderbufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetStringi")]
        public abstract unsafe byte* GetString([Flow(FlowDirection.In)] GLEnum name, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glGetTexParameterIiv")]
        public abstract unsafe void GetTexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIiv")]
        public abstract void GetTexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuiv")]
        public abstract unsafe void GetTexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuiv")]
        public abstract void GetTexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public abstract unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public abstract void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name);

        [NativeApi(EntryPoint = "glGetUniformuiv")]
        public abstract unsafe void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetUniformuiv")]
        public abstract void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIiv")]
        public abstract unsafe void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIiv")]
        public abstract void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIuiv")]
        public abstract unsafe void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIuiv")]
        public abstract void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glIsEnabledi")]
        public abstract bool IsEnabled([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glIsFramebuffer")]
        public abstract bool IsFramebuffer([Flow(FlowDirection.In)] uint framebuffer);

        [NativeApi(EntryPoint = "glIsRenderbuffer")]
        public abstract bool IsRenderbuffer([Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glIsVertexArray")]
        public abstract bool IsVertexArray([Flow(FlowDirection.In)] uint array);

        [NativeApi(EntryPoint = "glMapBufferRange")]
        public abstract unsafe void* MapBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length, [Flow(FlowDirection.In)] uint access);

        [NativeApi(EntryPoint = "glRenderbufferStorage")]
        public abstract void RenderbufferStorage([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisample")]
        public abstract void RenderbufferStorageMultisample([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glTexParameterIiv")]
        public abstract unsafe void TexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameterIiv")]
        public abstract void TexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glTexParameterIuiv")]
        public abstract unsafe void TexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTexParameterIuiv")]
        public abstract void TexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint @params);

        [NativeApi(EntryPoint = "glTransformFeedbackVaryings")]
        public abstract unsafe void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] byte** varyings, [Flow(FlowDirection.In)] GLEnum bufferMode);

        [NativeApi(EntryPoint = "glUniform1ui")]
        public abstract void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0);

        [NativeApi(EntryPoint = "glUniform1uiv")]
        public abstract unsafe void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glUniform1uiv")]
        public abstract void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value);

        [NativeApi(EntryPoint = "glUniform2ui")]
        public abstract void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1);

        [NativeApi(EntryPoint = "glUniform2uiv")]
        public abstract unsafe void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glUniform2uiv")]
        public abstract void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value);

        [NativeApi(EntryPoint = "glUniform3ui")]
        public abstract void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1, [Flow(FlowDirection.In)] uint v2);

        [NativeApi(EntryPoint = "glUniform3uiv")]
        public abstract unsafe void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glUniform3uiv")]
        public abstract void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value);

        [NativeApi(EntryPoint = "glUniform4ui")]
        public abstract void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1, [Flow(FlowDirection.In)] uint v2, [Flow(FlowDirection.In)] uint v3);

        [NativeApi(EntryPoint = "glUniform4uiv")]
        public abstract unsafe void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glUniform4uiv")]
        public abstract void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value);

        [NativeApi(EntryPoint = "glVertexAttribI1i")]
        public abstract void VertexAttribI1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x);

        [NativeApi(EntryPoint = "glVertexAttribI1ui")]
        public abstract void VertexAttribI1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x);

        [NativeApi(EntryPoint = "glVertexAttribI1iv")]
        public abstract unsafe void VertexAttribI1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glVertexAttribI1iv")]
        public abstract void VertexAttribI1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref int v);

        [NativeApi(EntryPoint = "glVertexAttribI1uiv")]
        public abstract unsafe void VertexAttribI1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glVertexAttribI1uiv")]
        public abstract void VertexAttribI1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref uint v);

        [NativeApi(EntryPoint = "glVertexAttribI2i")]
        public abstract void VertexAttribI2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y);

        [NativeApi(EntryPoint = "glVertexAttribI2ui")]
        public abstract void VertexAttribI2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y);

        [NativeApi(EntryPoint = "glVertexAttribI2iv")]
        public abstract unsafe void VertexAttribI2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glVertexAttribI2iv")]
        public abstract void VertexAttribI2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<int> v);

        [NativeApi(EntryPoint = "glVertexAttribI2uiv")]
        public abstract unsafe void VertexAttribI2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glVertexAttribI2uiv")]
        public abstract void VertexAttribI2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<uint> v);

        [NativeApi(EntryPoint = "glVertexAttribI3i")]
        public abstract void VertexAttribI3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z);

        [NativeApi(EntryPoint = "glVertexAttribI3ui")]
        public abstract void VertexAttribI3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint z);

        [NativeApi(EntryPoint = "glVertexAttribI3iv")]
        public abstract unsafe void VertexAttribI3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glVertexAttribI3iv")]
        public abstract void VertexAttribI3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<int> v);

        [NativeApi(EntryPoint = "glVertexAttribI3uiv")]
        public abstract unsafe void VertexAttribI3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glVertexAttribI3uiv")]
        public abstract void VertexAttribI3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<uint> v);

        [NativeApi(EntryPoint = "glVertexAttribI4i")]
        public abstract void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glVertexAttribI4ui")]
        public abstract void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint z, [Flow(FlowDirection.In)] uint w);

        [NativeApi(EntryPoint = "glVertexAttribI4iv")]
        public abstract unsafe void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glVertexAttribI4iv")]
        public abstract void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> v);

        [NativeApi(EntryPoint = "glVertexAttribI4uiv")]
        public abstract unsafe void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glVertexAttribI4uiv")]
        public abstract void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<uint> v);

        [NativeApi(EntryPoint = "glVertexAttribI4bv")]
        public abstract unsafe void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] sbyte* v);

        [NativeApi(EntryPoint = "glVertexAttribI4bv")]
        public abstract void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<sbyte> v);

        [NativeApi(EntryPoint = "glVertexAttribI4sv")]
        public abstract unsafe void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttribI4sv")]
        public abstract void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<short> v);

        [NativeApi(EntryPoint = "glVertexAttribI4ubv")]
        public abstract unsafe void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] byte* v);

        [NativeApi(EntryPoint = "glVertexAttribI4ubv")]
        public abstract void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<byte> v);

        [NativeApi(EntryPoint = "glVertexAttribI4usv")]
        public abstract unsafe void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ushort* v);

        [NativeApi(EntryPoint = "glVertexAttribI4usv")]
        public abstract void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<ushort> v);

        [NativeApi(EntryPoint = "glVertexAttribIPointer")]
        public abstract unsafe void VertexAttribIPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribIPointer")]
        public abstract void VertexAttribIPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBeginConditionalRender")]
        public abstract void BeginConditionalRender([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ConditionalRenderMode mode);

        [NativeApi(EntryPoint = "glBeginTransformFeedback")]
        public abstract void BeginTransformFeedback([Flow(FlowDirection.In)] PrimitiveType primitiveMode);

        [NativeApi(EntryPoint = "glBindFragDataLocation")]
        public abstract void BindFragDataLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint color, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glBindFramebuffer")]
        public abstract void BindFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint framebuffer);

        [NativeApi(EntryPoint = "glBindRenderbuffer")]
        public abstract void BindRenderbuffer([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glBlitFramebuffer")]
        public abstract void BlitFramebuffer([Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] BlitFramebufferFilter filter);

        [NativeApi(EntryPoint = "glCheckFramebufferStatus")]
        public abstract GLEnum CheckFramebufferStatus([Flow(FlowDirection.In)] FramebufferTarget target);

        [NativeApi(EntryPoint = "glClampColor")]
        public abstract void ClampColor([Flow(FlowDirection.In)] ClampColorTargetARB target, [Flow(FlowDirection.In)] ClampColorModeARB clamp);

        [NativeApi(EntryPoint = "glClearBufferiv")]
        public abstract unsafe void ClearBuffer([Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glClearBufferiv")]
        public abstract void ClearBuffer([Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ref int value);

        [NativeApi(EntryPoint = "glClearBufferuiv")]
        public abstract unsafe void ClearBuffer([Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glClearBufferuiv")]
        public abstract void ClearBuffer([Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glClearBufferfv")]
        public abstract unsafe void ClearBuffer([Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glClearBufferfv")]
        public abstract void ClearBuffer([Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ref float value);

        [NativeApi(EntryPoint = "glClearBufferfi")]
        public abstract void ClearBuffer([Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float depth, [Flow(FlowDirection.In)] int stencil);

        [NativeApi(EntryPoint = "glDisablei")]
        public abstract void Disable([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnablei")]
        public abstract void Enable([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glFlushMappedBufferRange")]
        public abstract void FlushMappedBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length);

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

        [NativeApi(EntryPoint = "glGetBooleani_v")]
        public abstract unsafe void GetBoolean([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetBooleani_v")]
        public abstract void GetBoolean([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetFragDataLocation")]
        public abstract int GetFragDataLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public abstract unsafe void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public abstract void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv")]
        public abstract unsafe void GetRenderbufferParameter([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv")]
        public abstract void GetRenderbufferParameter([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetStringi")]
        public abstract string GetString([Flow(FlowDirection.In)] StringName name, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glGetTexParameterIiv")]
        public abstract unsafe void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIiv")]
        public abstract void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuiv")]
        public abstract unsafe void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuiv")]
        public abstract void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public abstract unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -4)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public abstract void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -4)] out string name);

        [NativeApi(EntryPoint = "glGetVertexAttribIiv")]
        public abstract unsafe void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIiv")]
        public abstract void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIuiv")]
        public abstract unsafe void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIuiv")]
        public abstract void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glIsEnabledi")]
        public abstract bool IsEnabled([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glMapBufferRange")]
        public abstract unsafe void* MapBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length, [Flow(FlowDirection.In)] uint access);

        [NativeApi(EntryPoint = "glRenderbufferStorage")]
        public abstract void RenderbufferStorage([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisample")]
        public abstract void RenderbufferStorageMultisample([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glTexParameterIiv")]
        public abstract unsafe void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameterIiv")]
        public abstract void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glTexParameterIuiv")]
        public abstract unsafe void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTexParameterIuiv")]
        public abstract void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint @params);

        [NativeApi(EntryPoint = "glTransformFeedbackVaryings")]
        public abstract unsafe void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] byte** varyings, [Flow(FlowDirection.In)] TransformFeedbackBufferMode bufferMode);

        [NativeApi(EntryPoint = "glVertexAttribI4ubv")]
        public abstract void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] string v);

        [NativeApi(EntryPoint = "glVertexAttribIPointer")]
        public abstract unsafe void VertexAttribIPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribIType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribIPointer")]
        public abstract void VertexAttribIPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribIType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glUniformMatrix2x3fv")]
        public abstract unsafe void UniformMatrix2x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix2x3fv")]
        public abstract void UniformMatrix2x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUniformMatrix2x4fv")]
        public abstract unsafe void UniformMatrix2x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix2x4fv")]
        public abstract void UniformMatrix2x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUniformMatrix3x2fv")]
        public abstract unsafe void UniformMatrix3x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix3x2fv")]
        public abstract void UniformMatrix3x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUniformMatrix3x4fv")]
        public abstract unsafe void UniformMatrix3x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix3x4fv")]
        public abstract void UniformMatrix3x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUniformMatrix4x2fv")]
        public abstract unsafe void UniformMatrix4x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix4x2fv")]
        public abstract void UniformMatrix4x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUniformMatrix4x3fv")]
        public abstract unsafe void UniformMatrix4x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix4x3fv")]
        public abstract void UniformMatrix4x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glAttachShader")]
        public abstract void AttachShader([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint shader);

        [NativeApi(EntryPoint = "glBindAttribLocation")]
        public abstract unsafe void BindAttribLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glBindAttribLocation")]
        public abstract void BindAttribLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Span<byte> name);

        [NativeApi(EntryPoint = "glBlendEquationSeparate")]
        public abstract void BlendEquationSeparate([Flow(FlowDirection.In)] GLEnum modeRGB, [Flow(FlowDirection.In)] GLEnum modeAlpha);

        [NativeApi(EntryPoint = "glCompileShader")]
        public abstract void CompileShader([Flow(FlowDirection.In)] uint shader);

        [NativeApi(EntryPoint = "glCreateProgram")]
        public abstract uint CreateProgram();

        [NativeApi(EntryPoint = "glCreateShader")]
        public abstract uint CreateShader([Flow(FlowDirection.In)] GLEnum type);

        [NativeApi(EntryPoint = "glDeleteProgram")]
        public abstract void DeleteProgram([Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glDeleteShader")]
        public abstract void DeleteShader([Flow(FlowDirection.In)] uint shader);

        [NativeApi(EntryPoint = "glDetachShader")]
        public abstract void DetachShader([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint shader);

        [NativeApi(EntryPoint = "glDisableVertexAttribArray")]
        public abstract void DisableVertexAttribArray([Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glDrawBuffers")]
        public abstract unsafe void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] GLEnum* bufs);

        [NativeApi(EntryPoint = "glDrawBuffers")]
        public abstract void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<GLEnum> bufs);

        [NativeApi(EntryPoint = "glEnableVertexAttribArray")]
        public abstract void EnableVertexAttribArray([Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public abstract unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public abstract void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public abstract unsafe void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public abstract void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name);

        [NativeApi(EntryPoint = "glGetAttachedShaders")]
        public abstract unsafe void GetAttachedShaders([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] uint* count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] uint* shaders);

        [NativeApi(EntryPoint = "glGetAttachedShaders")]
        public abstract void GetAttachedShaders([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] out uint count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] Span<uint> shaders);

        [NativeApi(EntryPoint = "glGetAttribLocation")]
        public abstract unsafe int GetAttribLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetAttribLocation")]
        public abstract int GetAttribLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] Span<byte> name);

        [NativeApi(EntryPoint = "glGetProgramiv")]
        public abstract unsafe void GetProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramiv")]
        public abstract void GetProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramInfoLog")]
        public abstract unsafe void GetProgramInfoLog([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* infoLog);

        [NativeApi(EntryPoint = "glGetProgramInfoLog")]
        public abstract void GetProgramInfoLog([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> infoLog);

        [NativeApi(EntryPoint = "glGetShaderiv")]
        public abstract unsafe void GetShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetShaderiv")]
        public abstract void GetShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetShaderInfoLog")]
        public abstract unsafe void GetShaderInfoLog([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* infoLog);

        [NativeApi(EntryPoint = "glGetShaderInfoLog")]
        public abstract void GetShaderInfoLog([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> infoLog);

        [NativeApi(EntryPoint = "glGetShaderSource")]
        public abstract unsafe void GetShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* source);

        [NativeApi(EntryPoint = "glGetShaderSource")]
        public abstract void GetShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> source);

        [NativeApi(EntryPoint = "glGetUniformfv")]
        public abstract unsafe void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetUniformfv")]
        public abstract void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetUniformiv")]
        public abstract unsafe void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetUniformiv")]
        public abstract void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetUniformLocation")]
        public abstract unsafe int GetUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetUniformLocation")]
        public abstract int GetUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] Span<byte> name);

        [NativeApi(EntryPoint = "glGetVertexAttribdv")]
        public abstract unsafe void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribdv")]
        public abstract void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params);

        [NativeApi(EntryPoint = "glGetVertexAttribfv")]
        public abstract unsafe void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribfv")]
        public abstract void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params);

        [NativeApi(EntryPoint = "glGetVertexAttribiv")]
        public abstract unsafe void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribiv")]
        public abstract void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetVertexAttribPointerv")]
        public abstract unsafe void GetVertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** pointer);

        [NativeApi(EntryPoint = "glGetVertexAttribPointerv")]
        public abstract unsafe void GetVertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glIsProgram")]
        public abstract bool IsProgram([Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glIsShader")]
        public abstract bool IsShader([Flow(FlowDirection.In)] uint shader);

        [NativeApi(EntryPoint = "glLinkProgram")]
        public abstract void LinkProgram([Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glShaderSource")]
        public abstract unsafe void ShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] byte** @string, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* length);

        [NativeApi(EntryPoint = "glShaderSource")]
        public abstract unsafe void ShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] byte** @string, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> length);

        [NativeApi(EntryPoint = "glStencilFuncSeparate")]
        public abstract void StencilFuncSeparate([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] GLEnum func, [Flow(FlowDirection.In)] int @ref, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilMaskSeparate")]
        public abstract void StencilMaskSeparate([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilOpSeparate")]
        public abstract void StencilOpSeparate([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] GLEnum sfail, [Flow(FlowDirection.In)] GLEnum dpfail, [Flow(FlowDirection.In)] GLEnum dppass);

        [NativeApi(EntryPoint = "glUniform1f")]
        public abstract void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0);

        [NativeApi(EntryPoint = "glUniform1i")]
        public abstract void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0);

        [NativeApi(EntryPoint = "glUniform1fv")]
        public abstract unsafe void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniform1fv")]
        public abstract void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUniform1iv")]
        public abstract unsafe void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glUniform1iv")]
        public abstract void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        [NativeApi(EntryPoint = "glUniform2f")]
        public abstract void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1);

        [NativeApi(EntryPoint = "glUniform2i")]
        public abstract void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1);

        [NativeApi(EntryPoint = "glUniform2fv")]
        public abstract unsafe void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniform2fv")]
        public abstract void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUniform2iv")]
        public abstract unsafe void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glUniform2iv")]
        public abstract void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        [NativeApi(EntryPoint = "glUniform3f")]
        public abstract void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2);

        [NativeApi(EntryPoint = "glUniform3i")]
        public abstract void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2);

        [NativeApi(EntryPoint = "glUniform3fv")]
        public abstract unsafe void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniform3fv")]
        public abstract void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUniform3iv")]
        public abstract unsafe void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glUniform3iv")]
        public abstract void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        [NativeApi(EntryPoint = "glUniform4f")]
        public abstract void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] float v3);

        [NativeApi(EntryPoint = "glUniform4i")]
        public abstract void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2, [Flow(FlowDirection.In)] int v3);

        [NativeApi(EntryPoint = "glUniform4fv")]
        public abstract unsafe void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniform4fv")]
        public abstract void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUniform4iv")]
        public abstract unsafe void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glUniform4iv")]
        public abstract void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        [NativeApi(EntryPoint = "glUniformMatrix2fv")]
        public abstract unsafe void UniformMatrix2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix2fv")]
        public abstract void UniformMatrix2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUniformMatrix3fv")]
        public abstract unsafe void UniformMatrix3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix3fv")]
        public abstract void UniformMatrix3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUniformMatrix4fv")]
        public abstract unsafe void UniformMatrix4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix4fv")]
        public abstract void UniformMatrix4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUseProgram")]
        public abstract void UseProgram([Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glValidateProgram")]
        public abstract void ValidateProgram([Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glVertexAttrib1d")]
        public abstract void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x);

        [NativeApi(EntryPoint = "glVertexAttrib1dv")]
        public abstract unsafe void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttrib1dv")]
        public abstract void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref double v);

        [NativeApi(EntryPoint = "glVertexAttrib1f")]
        public abstract void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x);

        [NativeApi(EntryPoint = "glVertexAttrib1fv")]
        public abstract unsafe void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib1fv")]
        public abstract void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref float v);

        [NativeApi(EntryPoint = "glVertexAttrib1s")]
        public abstract void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x);

        [NativeApi(EntryPoint = "glVertexAttrib1sv")]
        public abstract unsafe void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib1sv")]
        public abstract void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref short v);

        [NativeApi(EntryPoint = "glVertexAttrib2d")]
        public abstract void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y);

        [NativeApi(EntryPoint = "glVertexAttrib2dv")]
        public abstract unsafe void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttrib2dv")]
        public abstract void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<double> v);

        [NativeApi(EntryPoint = "glVertexAttrib2f")]
        public abstract void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y);

        [NativeApi(EntryPoint = "glVertexAttrib2fv")]
        public abstract unsafe void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib2fv")]
        public abstract void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<float> v);

        [NativeApi(EntryPoint = "glVertexAttrib2s")]
        public abstract void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y);

        [NativeApi(EntryPoint = "glVertexAttrib2sv")]
        public abstract unsafe void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib2sv")]
        public abstract void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<short> v);

        [NativeApi(EntryPoint = "glVertexAttrib3d")]
        public abstract void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glVertexAttrib3dv")]
        public abstract unsafe void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttrib3dv")]
        public abstract void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<double> v);

        [NativeApi(EntryPoint = "glVertexAttrib3f")]
        public abstract void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glVertexAttrib3fv")]
        public abstract unsafe void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib3fv")]
        public abstract void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        [NativeApi(EntryPoint = "glVertexAttrib3s")]
        public abstract void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z);

        [NativeApi(EntryPoint = "glVertexAttrib3sv")]
        public abstract unsafe void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib3sv")]
        public abstract void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<short> v);

        [NativeApi(EntryPoint = "glVertexAttrib4bv")]
        public abstract unsafe void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] sbyte* v);

        [NativeApi(EntryPoint = "glVertexAttrib4bv")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<sbyte> v);

        [NativeApi(EntryPoint = "glVertexAttrib4d")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glVertexAttrib4dv")]
        public abstract unsafe void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttrib4dv")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> v);

        [NativeApi(EntryPoint = "glVertexAttrib4f")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glVertexAttrib4fv")]
        public abstract unsafe void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib4fv")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> v);

        [NativeApi(EntryPoint = "glVertexAttrib4iv")]
        public abstract unsafe void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glVertexAttrib4iv")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> v);

        [NativeApi(EntryPoint = "glVertexAttrib4s")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z, [Flow(FlowDirection.In)] short w);

        [NativeApi(EntryPoint = "glVertexAttrib4sv")]
        public abstract unsafe void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib4sv")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<short> v);

        [NativeApi(EntryPoint = "glVertexAttrib4ubv")]
        public abstract unsafe void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] byte* v);

        [NativeApi(EntryPoint = "glVertexAttrib4ubv")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<byte> v);

        [NativeApi(EntryPoint = "glVertexAttrib4uiv")]
        public abstract unsafe void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glVertexAttrib4uiv")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<uint> v);

        [NativeApi(EntryPoint = "glVertexAttrib4usv")]
        public abstract unsafe void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ushort* v);

        [NativeApi(EntryPoint = "glVertexAttrib4usv")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<ushort> v);

        [NativeApi(EntryPoint = "glVertexAttrib4Nbv")]
        public abstract unsafe void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] sbyte* v);

        [NativeApi(EntryPoint = "glVertexAttrib4Nbv")]
        public abstract void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<sbyte> v);

        [NativeApi(EntryPoint = "glVertexAttrib4Niv")]
        public abstract unsafe void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glVertexAttrib4Niv")]
        public abstract void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> v);

        [NativeApi(EntryPoint = "glVertexAttrib4Nsv")]
        public abstract unsafe void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib4Nsv")]
        public abstract void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<short> v);

        [NativeApi(EntryPoint = "glVertexAttrib4Nub")]
        public abstract void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] byte x, [Flow(FlowDirection.In)] byte y, [Flow(FlowDirection.In)] byte z, [Flow(FlowDirection.In)] byte w);

        [NativeApi(EntryPoint = "glVertexAttrib4Nubv")]
        public abstract unsafe void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] byte* v);

        [NativeApi(EntryPoint = "glVertexAttrib4Nubv")]
        public abstract void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<byte> v);

        [NativeApi(EntryPoint = "glVertexAttrib4Nuiv")]
        public abstract unsafe void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glVertexAttrib4Nuiv")]
        public abstract void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<uint> v);

        [NativeApi(EntryPoint = "glVertexAttrib4Nusv")]
        public abstract unsafe void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ushort* v);

        [NativeApi(EntryPoint = "glVertexAttrib4Nusv")]
        public abstract void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<ushort> v);

        [NativeApi(EntryPoint = "glVertexAttribPointer")]
        public abstract unsafe void VertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribPointer")]
        public abstract void VertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBindAttribLocation")]
        public abstract void BindAttribLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glBlendEquationSeparate")]
        public abstract void BlendEquationSeparate([Flow(FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        [NativeApi(EntryPoint = "glCreateShader")]
        public abstract uint CreateShader([Flow(FlowDirection.In)] ShaderType type);

        [NativeApi(EntryPoint = "glDrawBuffers")]
        public abstract unsafe void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] DrawBufferMode* bufs);

        [NativeApi(EntryPoint = "glDrawBuffers")]
        public abstract void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<DrawBufferMode> bufs);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public abstract unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -4)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public abstract void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -4)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public abstract unsafe void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -4)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public abstract void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out UniformType type, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -4)] out string name);

        [NativeApi(EntryPoint = "glGetAttribLocation")]
        public abstract int GetAttribLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetProgramiv")]
        public abstract unsafe void GetProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramPropertyARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramiv")]
        public abstract void GetProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramPropertyARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramInfoLog")]
        public abstract unsafe void GetProgramInfoLog([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string infoLog);

        [NativeApi(EntryPoint = "glGetProgramInfoLog")]
        public abstract void GetProgramInfoLog([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string infoLog);

        [NativeApi(EntryPoint = "glGetShaderiv")]
        public abstract unsafe void GetShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] ShaderParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetShaderiv")]
        public abstract void GetShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] ShaderParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetShaderInfoLog")]
        public abstract unsafe void GetShaderInfoLog([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string infoLog);

        [NativeApi(EntryPoint = "glGetShaderInfoLog")]
        public abstract void GetShaderInfoLog([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string infoLog);

        [NativeApi(EntryPoint = "glGetShaderSource")]
        public abstract unsafe void GetShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string source);

        [NativeApi(EntryPoint = "glGetShaderSource")]
        public abstract void GetShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string source);

        [NativeApi(EntryPoint = "glGetUniformLocation")]
        public abstract int GetUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetVertexAttribdv")]
        public abstract unsafe void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribdv")]
        public abstract void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params);

        [NativeApi(EntryPoint = "glGetVertexAttribfv")]
        public abstract unsafe void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribfv")]
        public abstract void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params);

        [NativeApi(EntryPoint = "glGetVertexAttribiv")]
        public abstract unsafe void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribiv")]
        public abstract void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetVertexAttribPointerv")]
        public abstract unsafe void GetVertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerPropertyARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** pointer);

        [NativeApi(EntryPoint = "glGetVertexAttribPointerv")]
        public abstract unsafe void GetVertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerPropertyARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFuncSeparate")]
        public abstract void StencilFuncSeparate([Flow(FlowDirection.In)] StencilFaceDirection face, [Flow(FlowDirection.In)] StencilFunction func, [Flow(FlowDirection.In)] int @ref, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilMaskSeparate")]
        public abstract void StencilMaskSeparate([Flow(FlowDirection.In)] StencilFaceDirection face, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilOpSeparate")]
        public abstract void StencilOpSeparate([Flow(FlowDirection.In)] StencilFaceDirection face, [Flow(FlowDirection.In)] StencilOp sfail, [Flow(FlowDirection.In)] StencilOp dpfail, [Flow(FlowDirection.In)] StencilOp dppass);

        [NativeApi(EntryPoint = "glVertexAttrib4ubv")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] string v);

        [NativeApi(EntryPoint = "glVertexAttrib4Nubv")]
        public abstract void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] string v);

        [NativeApi(EntryPoint = "glVertexAttribPointer")]
        public abstract unsafe void VertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribPointer")]
        public abstract void VertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBeginQuery")]
        public abstract void BeginQuery([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glBindBuffer")]
        public abstract void BindBuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBufferData")]
        public abstract unsafe void BufferData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] GLEnum usage);

        [NativeApi(EntryPoint = "glBufferData")]
        public abstract void BufferData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] GLEnum usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBufferSubData")]
        public abstract unsafe void BufferSubData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glBufferSubData")]
        public abstract void BufferSubData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDeleteBuffers")]
        public abstract unsafe void DeleteBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* buffers);

        [NativeApi(EntryPoint = "glDeleteBuffers")]
        public abstract void DeleteBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> buffers);

        [NativeApi(EntryPoint = "glDeleteQueries")]
        public abstract unsafe void DeleteQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* ids);

        [NativeApi(EntryPoint = "glDeleteQueries")]
        public abstract void DeleteQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> ids);

        [NativeApi(EntryPoint = "glEndQuery")]
        public abstract void EndQuery([Flow(FlowDirection.In)] GLEnum target);

        [NativeApi(EntryPoint = "glGenBuffers")]
        public abstract unsafe void GenBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* buffers);

        [NativeApi(EntryPoint = "glGenBuffers")]
        public abstract void GenBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> buffers);

        [NativeApi(EntryPoint = "glGenQueries")]
        public abstract unsafe void GenQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glGenQueries")]
        public abstract void GenQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids);

        [NativeApi(EntryPoint = "glGetBufferParameteriv")]
        public abstract unsafe void GetBufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetBufferParameteriv")]
        public abstract void GetBufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetBufferPointerv")]
        public abstract unsafe void GetBufferPointer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetBufferPointerv")]
        public abstract unsafe void GetBufferPointer<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* @params) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetBufferSubData")]
        public abstract unsafe void GetBufferSubData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetBufferSubData")]
        public abstract void GetBufferSubData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetQueryiv")]
        public abstract unsafe void GetQuery([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryiv")]
        public abstract void GetQuery([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetQueryObjectiv")]
        public abstract unsafe void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectiv")]
        public abstract void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetQueryObjectuiv")]
        public abstract unsafe void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectuiv")]
        public abstract void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glIsBuffer")]
        public abstract bool IsBuffer([Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glIsQuery")]
        public abstract bool IsQuery([Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glMapBuffer")]
        public abstract unsafe void* MapBuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum access);

        [NativeApi(EntryPoint = "glUnmapBuffer")]
        public abstract bool UnmapBuffer([Flow(FlowDirection.In)] GLEnum target);

        [NativeApi(EntryPoint = "glBeginQuery")]
        public abstract void BeginQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glBindBuffer")]
        public abstract void BindBuffer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBufferData")]
        public abstract unsafe void BufferData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] BufferUsageARB usage);

        [NativeApi(EntryPoint = "glBufferData")]
        public abstract void BufferData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] BufferUsageARB usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBufferSubData")]
        public abstract unsafe void BufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glBufferSubData")]
        public abstract void BufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glEndQuery")]
        public abstract void EndQuery([Flow(FlowDirection.In)] QueryTarget target);

        [NativeApi(EntryPoint = "glGetBufferParameteriv")]
        public abstract unsafe void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetBufferParameteriv")]
        public abstract void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetBufferPointerv")]
        public abstract unsafe void GetBufferPointer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetBufferPointerv")]
        public abstract unsafe void GetBufferPointer<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* @params) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetBufferSubData")]
        public abstract unsafe void GetBufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetBufferSubData")]
        public abstract void GetBufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetQueryiv")]
        public abstract unsafe void GetQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryiv")]
        public abstract void GetQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetQueryObjectiv")]
        public abstract unsafe void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectiv")]
        public abstract void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetQueryObjectuiv")]
        public abstract unsafe void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectuiv")]
        public abstract void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glMapBuffer")]
        public abstract unsafe void* MapBuffer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferAccessARB access);

        [NativeApi(EntryPoint = "glUnmapBuffer")]
        public abstract bool UnmapBuffer([Flow(FlowDirection.In)] BufferTargetARB target);

        [NativeApi(EntryPoint = "glBlendColor")]
        public abstract void BlendColor([Flow(FlowDirection.In)] float red, [Flow(FlowDirection.In)] float green, [Flow(FlowDirection.In)] float blue, [Flow(FlowDirection.In)] float alpha);

        [NativeApi(EntryPoint = "glBlendEquation")]
        public abstract void BlendEquation([Flow(FlowDirection.In)] GLEnum mode);

        [NativeApi(EntryPoint = "glBlendFuncSeparate")]
        public abstract void BlendFuncSeparate([Flow(FlowDirection.In)] GLEnum sfactorRGB, [Flow(FlowDirection.In)] GLEnum dfactorRGB, [Flow(FlowDirection.In)] GLEnum sfactorAlpha, [Flow(FlowDirection.In)] GLEnum dfactorAlpha);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glFogCoordf")]
        public abstract void FogCoord([Flow(FlowDirection.In)] float coord);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glFogCoordfv")]
        public abstract unsafe void FogCoord([Count(Count = 1), Flow(FlowDirection.In)] float* coord);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glFogCoordfv")]
        public abstract void FogCoord([Count(Count = 1), Flow(FlowDirection.In)] ref float coord);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glFogCoordd")]
        public abstract void FogCoord([Flow(FlowDirection.In)] double coord);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glFogCoorddv")]
        public abstract unsafe void FogCoord([Count(Count = 1), Flow(FlowDirection.In)] double* coord);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glFogCoorddv")]
        public abstract void FogCoord([Count(Count = 1), Flow(FlowDirection.In)] ref double coord);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glFogCoordPointer")]
        public abstract unsafe void FogCoordPointer([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glFogCoordPointer")]
        public abstract void FogCoordPointer<T0>([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawArrays")]
        public abstract unsafe void MultiDrawArrays([Flow(FlowDirection.In)] GLEnum mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint drawcount);

        [NativeApi(EntryPoint = "glMultiDrawArrays")]
        public abstract void MultiDrawArrays([Flow(FlowDirection.In)] GLEnum mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref int first, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] uint drawcount);

        [NativeApi(EntryPoint = "glMultiDrawElements")]
        public abstract unsafe void MultiDrawElements([Flow(FlowDirection.In)] GLEnum mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount);

        [NativeApi(EntryPoint = "glMultiDrawElements")]
        public abstract unsafe void MultiDrawElements<T0>([Flow(FlowDirection.In)] GLEnum mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref T0* indices, [Flow(FlowDirection.In)] uint drawcount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPointParameterf")]
        public abstract void PointParameter([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glPointParameterfv")]
        public abstract unsafe void PointParameter([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glPointParameterfv")]
        public abstract void PointParameter([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [NativeApi(EntryPoint = "glPointParameteri")]
        public abstract void PointParameter([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPointParameteriv")]
        public abstract unsafe void PointParameter([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glPointParameteriv")]
        public abstract void PointParameter([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glSecondaryColor3b")]
        public abstract void SecondaryColor3([Flow(FlowDirection.In)] sbyte red, [Flow(FlowDirection.In)] sbyte green, [Flow(FlowDirection.In)] sbyte blue);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glSecondaryColor3bv")]
        public abstract unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] sbyte* v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glSecondaryColor3bv")]
        public abstract void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<sbyte> v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glSecondaryColor3d")]
        public abstract void SecondaryColor3([Flow(FlowDirection.In)] double red, [Flow(FlowDirection.In)] double green, [Flow(FlowDirection.In)] double blue);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glSecondaryColor3dv")]
        public abstract unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glSecondaryColor3dv")]
        public abstract void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<double> v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glSecondaryColor3f")]
        public abstract void SecondaryColor3([Flow(FlowDirection.In)] float red, [Flow(FlowDirection.In)] float green, [Flow(FlowDirection.In)] float blue);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glSecondaryColor3fv")]
        public abstract unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glSecondaryColor3fv")]
        public abstract void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glSecondaryColor3i")]
        public abstract void SecondaryColor3([Flow(FlowDirection.In)] int red, [Flow(FlowDirection.In)] int green, [Flow(FlowDirection.In)] int blue);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glSecondaryColor3iv")]
        public abstract unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] int* v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glSecondaryColor3iv")]
        public abstract void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<int> v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glSecondaryColor3s")]
        public abstract void SecondaryColor3([Flow(FlowDirection.In)] short red, [Flow(FlowDirection.In)] short green, [Flow(FlowDirection.In)] short blue);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glSecondaryColor3sv")]
        public abstract unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] short* v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glSecondaryColor3sv")]
        public abstract void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<short> v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glSecondaryColor3ub")]
        public abstract void SecondaryColor3([Flow(FlowDirection.In)] byte red, [Flow(FlowDirection.In)] byte green, [Flow(FlowDirection.In)] byte blue);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glSecondaryColor3ubv")]
        public abstract unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] byte* v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glSecondaryColor3ubv")]
        public abstract void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<byte> v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glSecondaryColor3ui")]
        public abstract void SecondaryColor3([Flow(FlowDirection.In)] uint red, [Flow(FlowDirection.In)] uint green, [Flow(FlowDirection.In)] uint blue);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glSecondaryColor3uiv")]
        public abstract unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] uint* v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glSecondaryColor3uiv")]
        public abstract void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<uint> v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glSecondaryColor3us")]
        public abstract void SecondaryColor3([Flow(FlowDirection.In)] ushort red, [Flow(FlowDirection.In)] ushort green, [Flow(FlowDirection.In)] ushort blue);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glSecondaryColor3usv")]
        public abstract unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] ushort* v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glSecondaryColor3usv")]
        public abstract void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<ushort> v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glSecondaryColorPointer")]
        public abstract unsafe void SecondaryColorPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glSecondaryColorPointer")]
        public abstract void SecondaryColorPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glWindowPos2d")]
        public abstract void WindowPos2([Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glWindowPos2dv")]
        public abstract unsafe void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] double* v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glWindowPos2dv")]
        public abstract void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] Span<double> v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glWindowPos2f")]
        public abstract void WindowPos2([Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glWindowPos2fv")]
        public abstract unsafe void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] float* v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glWindowPos2fv")]
        public abstract void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] Span<float> v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glWindowPos2i")]
        public abstract void WindowPos2([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glWindowPos2iv")]
        public abstract unsafe void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] int* v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glWindowPos2iv")]
        public abstract void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] Span<int> v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glWindowPos2s")]
        public abstract void WindowPos2([Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glWindowPos2sv")]
        public abstract unsafe void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] short* v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glWindowPos2sv")]
        public abstract void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] Span<short> v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glWindowPos3d")]
        public abstract void WindowPos3([Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glWindowPos3dv")]
        public abstract unsafe void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glWindowPos3dv")]
        public abstract void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] Span<double> v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glWindowPos3f")]
        public abstract void WindowPos3([Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glWindowPos3fv")]
        public abstract unsafe void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glWindowPos3fv")]
        public abstract void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glWindowPos3i")]
        public abstract void WindowPos3([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glWindowPos3iv")]
        public abstract unsafe void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] int* v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glWindowPos3iv")]
        public abstract void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] Span<int> v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glWindowPos3s")]
        public abstract void WindowPos3([Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glWindowPos3sv")]
        public abstract unsafe void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] short* v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glWindowPos3sv")]
        public abstract void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] Span<short> v);

        [NativeApi(EntryPoint = "glBlendEquation")]
        public abstract void BlendEquation([Flow(FlowDirection.In)] BlendEquationModeEXT mode);

        [NativeApi(EntryPoint = "glBlendFuncSeparate")]
        public abstract void BlendFuncSeparate([Flow(FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(FlowDirection.In)] BlendingFactor dfactorAlpha);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glFogCoordPointer")]
        public abstract unsafe void FogCoordPointer([Flow(FlowDirection.In)] FogPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glFogCoordPointer")]
        public abstract void FogCoordPointer<T0>([Flow(FlowDirection.In)] FogPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawArrays")]
        public abstract unsafe void MultiDrawArrays([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint drawcount);

        [NativeApi(EntryPoint = "glMultiDrawArrays")]
        public abstract void MultiDrawArrays([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref int first, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] uint drawcount);

        [NativeApi(EntryPoint = "glMultiDrawElements")]
        public abstract unsafe void MultiDrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount);

        [NativeApi(EntryPoint = "glMultiDrawElements")]
        public abstract unsafe void MultiDrawElements<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref T0* indices, [Flow(FlowDirection.In)] uint drawcount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPointParameterf")]
        public abstract void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glPointParameterfv")]
        public abstract unsafe void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glPointParameterfv")]
        public abstract void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [NativeApi(EntryPoint = "glPointParameteri")]
        public abstract void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPointParameteriv")]
        public abstract unsafe void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glPointParameteriv")]
        public abstract void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glSecondaryColor3ubv")]
        public abstract void SecondaryColor3([Flow(FlowDirection.In)] string v);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glSecondaryColorPointer")]
        public abstract unsafe void SecondaryColorPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [System.Obsolete("Deprecated in version 1.4")]
        [NativeApi(EntryPoint = "glSecondaryColorPointer")]
        public abstract void SecondaryColorPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glActiveTexture")]
        public abstract void ActiveTexture([Flow(FlowDirection.In)] GLEnum texture);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glClientActiveTexture")]
        public abstract void ClientActiveTexture([Flow(FlowDirection.In)] GLEnum texture);

        [NativeApi(EntryPoint = "glCompressedTexImage1D")]
        public abstract unsafe void CompressedTexImage1D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexImage1D")]
        public abstract void CompressedTexImage1D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexImage2D")]
        public abstract unsafe void CompressedTexImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexImage2D")]
        public abstract void CompressedTexImage2D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexImage3D")]
        public abstract unsafe void CompressedTexImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexImage3D")]
        public abstract void CompressedTexImage3D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexSubImage1D")]
        public abstract unsafe void CompressedTexSubImage1D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexSubImage1D")]
        public abstract void CompressedTexSubImage1D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexSubImage2D")]
        public abstract unsafe void CompressedTexSubImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexSubImage2D")]
        public abstract void CompressedTexSubImage2D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexSubImage3D")]
        public abstract unsafe void CompressedTexSubImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexSubImage3D")]
        public abstract void CompressedTexSubImage3D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetCompressedTexImage")]
        public abstract unsafe void GetCompressedTexImage([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Count(Computed = "target, level"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetCompressedTexImage")]
        public abstract void GetCompressedTexImage<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Count(Computed = "target, level"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glLoadTransposeMatrixf")]
        public abstract unsafe void LoadTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] float* m);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glLoadTransposeMatrixf")]
        public abstract void LoadTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] Span<float> m);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glLoadTransposeMatrixd")]
        public abstract unsafe void LoadTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] double* m);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glLoadTransposeMatrixd")]
        public abstract void LoadTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] Span<double> m);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord1d")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] double s);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord1dv")]
        public abstract unsafe void MultiTexCoord1([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 1), Flow(FlowDirection.In)] double* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord1dv")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 1), Flow(FlowDirection.In)] ref double v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord1f")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] float s);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord1fv")]
        public abstract unsafe void MultiTexCoord1([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 1), Flow(FlowDirection.In)] float* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord1fv")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 1), Flow(FlowDirection.In)] ref float v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord1i")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int s);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord1iv")]
        public abstract unsafe void MultiTexCoord1([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 1), Flow(FlowDirection.In)] int* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord1iv")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 1), Flow(FlowDirection.In)] ref int v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord1s")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] short s);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord1sv")]
        public abstract unsafe void MultiTexCoord1([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 1), Flow(FlowDirection.In)] short* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord1sv")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 1), Flow(FlowDirection.In)] ref short v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord2d")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] double s, [Flow(FlowDirection.In)] double t);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord2dv")]
        public abstract unsafe void MultiTexCoord2([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 2), Flow(FlowDirection.In)] double* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord2dv")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 2), Flow(FlowDirection.In)] Span<double> v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord2f")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord2fv")]
        public abstract unsafe void MultiTexCoord2([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 2), Flow(FlowDirection.In)] float* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord2fv")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 2), Flow(FlowDirection.In)] Span<float> v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord2i")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord2iv")]
        public abstract unsafe void MultiTexCoord2([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 2), Flow(FlowDirection.In)] int* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord2iv")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 2), Flow(FlowDirection.In)] Span<int> v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord2s")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] short s, [Flow(FlowDirection.In)] short t);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord2sv")]
        public abstract unsafe void MultiTexCoord2([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 2), Flow(FlowDirection.In)] short* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord2sv")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 2), Flow(FlowDirection.In)] Span<short> v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord3d")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] double s, [Flow(FlowDirection.In)] double t, [Flow(FlowDirection.In)] double r);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord3dv")]
        public abstract unsafe void MultiTexCoord3([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord3dv")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 3), Flow(FlowDirection.In)] Span<double> v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord3f")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float r);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord3fv")]
        public abstract unsafe void MultiTexCoord3([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord3fv")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord3i")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord3iv")]
        public abstract unsafe void MultiTexCoord3([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 3), Flow(FlowDirection.In)] int* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord3iv")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 3), Flow(FlowDirection.In)] Span<int> v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord3s")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] short s, [Flow(FlowDirection.In)] short t, [Flow(FlowDirection.In)] short r);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord3sv")]
        public abstract unsafe void MultiTexCoord3([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 3), Flow(FlowDirection.In)] short* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord3sv")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 3), Flow(FlowDirection.In)] Span<short> v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord4d")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] double s, [Flow(FlowDirection.In)] double t, [Flow(FlowDirection.In)] double r, [Flow(FlowDirection.In)] double q);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord4dv")]
        public abstract unsafe void MultiTexCoord4([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 4), Flow(FlowDirection.In)] double* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord4dv")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord4f")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float q);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord4fv")]
        public abstract unsafe void MultiTexCoord4([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord4fv")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord4i")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r, [Flow(FlowDirection.In)] int q);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord4iv")]
        public abstract unsafe void MultiTexCoord4([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord4iv")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord4s")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] short s, [Flow(FlowDirection.In)] short t, [Flow(FlowDirection.In)] short r, [Flow(FlowDirection.In)] short q);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord4sv")]
        public abstract unsafe void MultiTexCoord4([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 4), Flow(FlowDirection.In)] short* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord4sv")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] GLEnum target, [Count(Count = 4), Flow(FlowDirection.In)] Span<short> v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultTransposeMatrixf")]
        public abstract unsafe void MultTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] float* m);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultTransposeMatrixf")]
        public abstract void MultTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] Span<float> m);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultTransposeMatrixd")]
        public abstract unsafe void MultTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] double* m);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultTransposeMatrixd")]
        public abstract void MultTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] Span<double> m);

        [NativeApi(EntryPoint = "glSampleCoverage")]
        public abstract void SampleCoverage([Flow(FlowDirection.In)] float value, [Flow(FlowDirection.In)] bool invert);

        [NativeApi(EntryPoint = "glActiveTexture")]
        public abstract void ActiveTexture([Flow(FlowDirection.In)] TextureUnit texture);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glClientActiveTexture")]
        public abstract void ClientActiveTexture([Flow(FlowDirection.In)] TextureUnit texture);

        [NativeApi(EntryPoint = "glCompressedTexImage1D")]
        public abstract unsafe void CompressedTexImage1D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexImage1D")]
        public abstract void CompressedTexImage1D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexImage2D")]
        public abstract unsafe void CompressedTexImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexImage2D")]
        public abstract void CompressedTexImage2D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexImage3D")]
        public abstract unsafe void CompressedTexImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexImage3D")]
        public abstract void CompressedTexImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexSubImage1D")]
        public abstract unsafe void CompressedTexSubImage1D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexSubImage1D")]
        public abstract void CompressedTexSubImage1D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexSubImage2D")]
        public abstract unsafe void CompressedTexSubImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexSubImage2D")]
        public abstract void CompressedTexSubImage2D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexSubImage3D")]
        public abstract unsafe void CompressedTexSubImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexSubImage3D")]
        public abstract void CompressedTexSubImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetCompressedTexImage")]
        public abstract unsafe void GetCompressedTexImage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Count(Computed = "target, level"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetCompressedTexImage")]
        public abstract void GetCompressedTexImage<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Count(Computed = "target, level"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord1d")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] double s);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord1dv")]
        public abstract unsafe void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] double* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord1dv")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] ref double v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord1f")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] float s);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord1fv")]
        public abstract unsafe void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] float* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord1fv")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] ref float v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord1i")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] int s);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord1iv")]
        public abstract unsafe void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] int* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord1iv")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] ref int v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord1s")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] short s);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord1sv")]
        public abstract unsafe void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] short* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord1sv")]
        public abstract void MultiTexCoord1([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] ref short v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord2d")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] double s, [Flow(FlowDirection.In)] double t);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord2dv")]
        public abstract unsafe void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] double* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord2dv")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] Span<double> v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord2f")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord2fv")]
        public abstract unsafe void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] float* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord2fv")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] Span<float> v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord2i")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord2iv")]
        public abstract unsafe void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] int* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord2iv")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] Span<int> v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord2s")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] short s, [Flow(FlowDirection.In)] short t);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord2sv")]
        public abstract unsafe void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] short* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord2sv")]
        public abstract void MultiTexCoord2([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] Span<short> v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord3d")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] double s, [Flow(FlowDirection.In)] double t, [Flow(FlowDirection.In)] double r);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord3dv")]
        public abstract unsafe void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord3dv")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] Span<double> v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord3f")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float r);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord3fv")]
        public abstract unsafe void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord3fv")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord3i")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord3iv")]
        public abstract unsafe void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] int* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord3iv")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] Span<int> v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord3s")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] short s, [Flow(FlowDirection.In)] short t, [Flow(FlowDirection.In)] short r);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord3sv")]
        public abstract unsafe void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] short* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord3sv")]
        public abstract void MultiTexCoord3([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] Span<short> v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord4d")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] double s, [Flow(FlowDirection.In)] double t, [Flow(FlowDirection.In)] double r, [Flow(FlowDirection.In)] double q);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord4dv")]
        public abstract unsafe void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] double* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord4dv")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord4f")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float q);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord4fv")]
        public abstract unsafe void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord4fv")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord4i")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r, [Flow(FlowDirection.In)] int q);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord4iv")]
        public abstract unsafe void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord4iv")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord4s")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Flow(FlowDirection.In)] short s, [Flow(FlowDirection.In)] short t, [Flow(FlowDirection.In)] short r, [Flow(FlowDirection.In)] short q);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord4sv")]
        public abstract unsafe void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] short* v);

        [System.Obsolete("Deprecated in version 1.3")]
        [NativeApi(EntryPoint = "glMultiTexCoord4sv")]
        public abstract void MultiTexCoord4([Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] Span<short> v);

        [NativeApi(EntryPoint = "glCopyTexSubImage3D")]
        public abstract void CopyTexSubImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glDrawRangeElements")]
        public abstract unsafe void DrawRangeElements([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices);

        [NativeApi(EntryPoint = "glDrawRangeElements")]
        public abstract void DrawRangeElements<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage3D")]
        public abstract unsafe void TexImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage3D")]
        public abstract void TexImage3D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage3D")]
        public abstract unsafe void TexSubImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage3D")]
        public abstract void TexSubImage3D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCopyTexSubImage3D")]
        public abstract void CopyTexSubImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glDrawRangeElements")]
        public abstract unsafe void DrawRangeElements([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices);

        [NativeApi(EntryPoint = "glDrawRangeElements")]
        public abstract void DrawRangeElements<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage3D")]
        public abstract unsafe void TexImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage3D")]
        public abstract void TexImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage3D")]
        public abstract unsafe void TexSubImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage3D")]
        public abstract void TexSubImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glAreTexturesResident")]
        public abstract unsafe bool AreTexturesResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] bool* residences);

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glAreTexturesResident")]
        public abstract bool AreTexturesResident([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> textures, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<bool> residences);

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glArrayElement")]
        public abstract void ArrayElement([Flow(FlowDirection.In)] int i);

        [NativeApi(EntryPoint = "glBindTexture")]
        public abstract void BindTexture([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint texture);

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glColorPointer")]
        public abstract unsafe void ColorPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glColorPointer")]
        public abstract void ColorPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCopyTexImage1D")]
        public abstract void CopyTexImage1D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyTexImage2D")]
        public abstract void CopyTexImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyTexSubImage1D")]
        public abstract void CopyTexSubImage1D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyTexSubImage2D")]
        public abstract void CopyTexSubImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glDeleteTextures")]
        public abstract unsafe void DeleteTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* textures);

        [NativeApi(EntryPoint = "glDeleteTextures")]
        public abstract void DeleteTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> textures);

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glDisableClientState")]
        public abstract void DisableClientState([Flow(FlowDirection.In)] GLEnum array);

        [NativeApi(EntryPoint = "glDrawArrays")]
        public abstract void DrawArrays([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawElements")]
        public abstract unsafe void DrawElements([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices);

        [NativeApi(EntryPoint = "glDrawElements")]
        public abstract void DrawElements<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices) where T0 : unmanaged;

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glEdgeFlagPointer")]
        public abstract unsafe void EdgeFlagPointer([Flow(FlowDirection.In)] uint stride, [Count(Computed = "stride"), Flow(FlowDirection.In)] void* pointer);

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glEdgeFlagPointer")]
        public abstract void EdgeFlagPointer<T0>([Flow(FlowDirection.In)] uint stride, [Count(Computed = "stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glEnableClientState")]
        public abstract void EnableClientState([Flow(FlowDirection.In)] GLEnum array);

        [NativeApi(EntryPoint = "glGenTextures")]
        public abstract unsafe void GenTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* textures);

        [NativeApi(EntryPoint = "glGenTextures")]
        public abstract void GenTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> textures);

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glIndexub")]
        public abstract void Index([Flow(FlowDirection.In)] byte c);

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glIndexubv")]
        public abstract unsafe void Index([Count(Count = 1), Flow(FlowDirection.In)] byte* c);

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glIndexubv")]
        public abstract void Index([Count(Count = 1), Flow(FlowDirection.In)] ref byte c);

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glIndexPointer")]
        public abstract unsafe void IndexPointer([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer);

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glIndexPointer")]
        public abstract void IndexPointer<T0>([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glInterleavedArrays")]
        public abstract unsafe void InterleavedArrays([Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "format, stride"), Flow(FlowDirection.In)] void* pointer);

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glInterleavedArrays")]
        public abstract void InterleavedArrays<T0>([Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "format, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glIsTexture")]
        public abstract bool IsTexture([Flow(FlowDirection.In)] uint texture);

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glNormalPointer")]
        public abstract unsafe void NormalPointer([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer);

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glNormalPointer")]
        public abstract void NormalPointer<T0>([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPolygonOffset")]
        public abstract void PolygonOffset([Flow(FlowDirection.In)] float factor, [Flow(FlowDirection.In)] float units);

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glPopClientAttrib")]
        public abstract void PopClientAttrib();

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glPrioritizeTextures")]
        public abstract unsafe void PrioritizeTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* priorities);

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glPrioritizeTextures")]
        public abstract void PrioritizeTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<float> priorities);

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glPushClientAttrib")]
        public abstract void PushClientAttrib([Flow(FlowDirection.In)] uint mask);

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glTexCoordPointer")]
        public abstract unsafe void TexCoordPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glTexCoordPointer")]
        public abstract void TexCoordPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage1D")]
        public abstract unsafe void TexSubImage1D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage1D")]
        public abstract void TexSubImage1D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage2D")]
        public abstract unsafe void TexSubImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage2D")]
        public abstract void TexSubImage2D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glVertexPointer")]
        public abstract unsafe void VertexPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glVertexPointer")]
        public abstract void VertexPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBindTexture")]
        public abstract void BindTexture([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint texture);

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glColorPointer")]
        public abstract unsafe void ColorPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glColorPointer")]
        public abstract void ColorPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCopyTexImage1D")]
        public abstract void CopyTexImage1D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyTexImage2D")]
        public abstract void CopyTexImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyTexSubImage1D")]
        public abstract void CopyTexSubImage1D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyTexSubImage2D")]
        public abstract void CopyTexSubImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glDisableClientState")]
        public abstract void DisableClientState([Flow(FlowDirection.In)] EnableCap array);

        [NativeApi(EntryPoint = "glDrawArrays")]
        public abstract void DrawArrays([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawElements")]
        public abstract unsafe void DrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices);

        [NativeApi(EntryPoint = "glDrawElements")]
        public abstract void DrawElements<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices) where T0 : unmanaged;

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glEnableClientState")]
        public abstract void EnableClientState([Flow(FlowDirection.In)] EnableCap array);

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glIndexubv")]
        public abstract void Index([Flow(FlowDirection.In)] string c);

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glIndexPointer")]
        public abstract unsafe void IndexPointer([Flow(FlowDirection.In)] IndexPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer);

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glIndexPointer")]
        public abstract void IndexPointer<T0>([Flow(FlowDirection.In)] IndexPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glInterleavedArrays")]
        public abstract unsafe void InterleavedArrays([Flow(FlowDirection.In)] InterleavedArrayFormat format, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "format, stride"), Flow(FlowDirection.In)] void* pointer);

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glInterleavedArrays")]
        public abstract void InterleavedArrays<T0>([Flow(FlowDirection.In)] InterleavedArrayFormat format, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "format, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glNormalPointer")]
        public abstract unsafe void NormalPointer([Flow(FlowDirection.In)] NormalPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer);

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glNormalPointer")]
        public abstract void NormalPointer<T0>([Flow(FlowDirection.In)] NormalPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glTexCoordPointer")]
        public abstract unsafe void TexCoordPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glTexCoordPointer")]
        public abstract void TexCoordPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage1D")]
        public abstract unsafe void TexSubImage1D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage1D")]
        public abstract void TexSubImage1D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage2D")]
        public abstract unsafe void TexSubImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage2D")]
        public abstract void TexSubImage2D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glVertexPointer")]
        public abstract unsafe void VertexPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [System.Obsolete("Deprecated in version 1.1")]
        [NativeApi(EntryPoint = "glVertexPointer")]
        public abstract void VertexPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glAccum")]
        public abstract void Accum([Flow(FlowDirection.In)] GLEnum op, [Flow(FlowDirection.In)] float value);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glAlphaFunc")]
        public abstract void AlphaFunc([Flow(FlowDirection.In)] GLEnum func, [Flow(FlowDirection.In)] float @ref);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glBegin")]
        public abstract void Begin([Flow(FlowDirection.In)] GLEnum mode);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glBitmap")]
        public abstract unsafe void Bitmap([Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] float xorig, [Flow(FlowDirection.In)] float yorig, [Flow(FlowDirection.In)] float xmove, [Flow(FlowDirection.In)] float ymove, [Count(Computed = "width, height"), Flow(FlowDirection.In)] byte* bitmap);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glBitmap")]
        public abstract void Bitmap([Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] float xorig, [Flow(FlowDirection.In)] float yorig, [Flow(FlowDirection.In)] float xmove, [Flow(FlowDirection.In)] float ymove, [Count(Computed = "width, height"), Flow(FlowDirection.In)] ref byte bitmap);

        [NativeApi(EntryPoint = "glBlendFunc")]
        public abstract void BlendFunc([Flow(FlowDirection.In)] GLEnum sfactor, [Flow(FlowDirection.In)] GLEnum dfactor);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glCallList")]
        public abstract void CallList([Flow(FlowDirection.In)] uint list);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glCallLists")]
        public abstract unsafe void CallLists([Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "n, type"), Flow(FlowDirection.In)] void* lists);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glCallLists")]
        public abstract void CallLists<T0>([Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "n, type"), Flow(FlowDirection.In)] ref T0 lists) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClear")]
        public abstract void Clear([Flow(FlowDirection.In)] uint mask);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glClearAccum")]
        public abstract void ClearAccum([Flow(FlowDirection.In)] float red, [Flow(FlowDirection.In)] float green, [Flow(FlowDirection.In)] float blue, [Flow(FlowDirection.In)] float alpha);

        [NativeApi(EntryPoint = "glClearColor")]
        public abstract void ClearColor([Flow(FlowDirection.In)] float red, [Flow(FlowDirection.In)] float green, [Flow(FlowDirection.In)] float blue, [Flow(FlowDirection.In)] float alpha);

        [NativeApi(EntryPoint = "glClearDepth")]
        public abstract void ClearDepth([Flow(FlowDirection.In)] double depth);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glClearIndex")]
        public abstract void ClearIndex([Flow(FlowDirection.In)] float c);

        [NativeApi(EntryPoint = "glClearStencil")]
        public abstract void ClearStencil([Flow(FlowDirection.In)] int s);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glClipPlane")]
        public abstract unsafe void ClipPlane([Flow(FlowDirection.In)] GLEnum plane, [Count(Count = 4), Flow(FlowDirection.In)] double* equation);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glClipPlane")]
        public abstract void ClipPlane([Flow(FlowDirection.In)] GLEnum plane, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> equation);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor3b")]
        public abstract void Color3([Flow(FlowDirection.In)] sbyte red, [Flow(FlowDirection.In)] sbyte green, [Flow(FlowDirection.In)] sbyte blue);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor3bv")]
        public abstract unsafe void Color3([Count(Count = 3), Flow(FlowDirection.In)] sbyte* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor3bv")]
        public abstract void Color3([Count(Count = 3), Flow(FlowDirection.In)] Span<sbyte> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor3d")]
        public abstract void Color3([Flow(FlowDirection.In)] double red, [Flow(FlowDirection.In)] double green, [Flow(FlowDirection.In)] double blue);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor3dv")]
        public abstract unsafe void Color3([Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor3dv")]
        public abstract void Color3([Count(Count = 3), Flow(FlowDirection.In)] Span<double> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor3f")]
        public abstract void Color3([Flow(FlowDirection.In)] float red, [Flow(FlowDirection.In)] float green, [Flow(FlowDirection.In)] float blue);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor3fv")]
        public abstract unsafe void Color3([Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor3fv")]
        public abstract void Color3([Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor3i")]
        public abstract void Color3([Flow(FlowDirection.In)] int red, [Flow(FlowDirection.In)] int green, [Flow(FlowDirection.In)] int blue);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor3iv")]
        public abstract unsafe void Color3([Count(Count = 3), Flow(FlowDirection.In)] int* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor3iv")]
        public abstract void Color3([Count(Count = 3), Flow(FlowDirection.In)] Span<int> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor3s")]
        public abstract void Color3([Flow(FlowDirection.In)] short red, [Flow(FlowDirection.In)] short green, [Flow(FlowDirection.In)] short blue);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor3sv")]
        public abstract unsafe void Color3([Count(Count = 3), Flow(FlowDirection.In)] short* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor3sv")]
        public abstract void Color3([Count(Count = 3), Flow(FlowDirection.In)] Span<short> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor3ub")]
        public abstract void Color3([Flow(FlowDirection.In)] byte red, [Flow(FlowDirection.In)] byte green, [Flow(FlowDirection.In)] byte blue);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor3ubv")]
        public abstract unsafe void Color3([Count(Count = 3), Flow(FlowDirection.In)] byte* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor3ubv")]
        public abstract void Color3([Count(Count = 3), Flow(FlowDirection.In)] Span<byte> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor3ui")]
        public abstract void Color3([Flow(FlowDirection.In)] uint red, [Flow(FlowDirection.In)] uint green, [Flow(FlowDirection.In)] uint blue);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor3uiv")]
        public abstract unsafe void Color3([Count(Count = 3), Flow(FlowDirection.In)] uint* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor3uiv")]
        public abstract void Color3([Count(Count = 3), Flow(FlowDirection.In)] Span<uint> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor3us")]
        public abstract void Color3([Flow(FlowDirection.In)] ushort red, [Flow(FlowDirection.In)] ushort green, [Flow(FlowDirection.In)] ushort blue);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor3usv")]
        public abstract unsafe void Color3([Count(Count = 3), Flow(FlowDirection.In)] ushort* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor3usv")]
        public abstract void Color3([Count(Count = 3), Flow(FlowDirection.In)] Span<ushort> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor4b")]
        public abstract void Color4([Flow(FlowDirection.In)] sbyte red, [Flow(FlowDirection.In)] sbyte green, [Flow(FlowDirection.In)] sbyte blue, [Flow(FlowDirection.In)] sbyte alpha);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor4bv")]
        public abstract unsafe void Color4([Count(Count = 4), Flow(FlowDirection.In)] sbyte* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor4bv")]
        public abstract void Color4([Count(Count = 4), Flow(FlowDirection.In)] Span<sbyte> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor4d")]
        public abstract void Color4([Flow(FlowDirection.In)] double red, [Flow(FlowDirection.In)] double green, [Flow(FlowDirection.In)] double blue, [Flow(FlowDirection.In)] double alpha);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor4dv")]
        public abstract unsafe void Color4([Count(Count = 4), Flow(FlowDirection.In)] double* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor4dv")]
        public abstract void Color4([Count(Count = 4), Flow(FlowDirection.In)] Span<double> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor4f")]
        public abstract void Color4([Flow(FlowDirection.In)] float red, [Flow(FlowDirection.In)] float green, [Flow(FlowDirection.In)] float blue, [Flow(FlowDirection.In)] float alpha);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor4fv")]
        public abstract unsafe void Color4([Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor4fv")]
        public abstract void Color4([Count(Count = 4), Flow(FlowDirection.In)] Span<float> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor4i")]
        public abstract void Color4([Flow(FlowDirection.In)] int red, [Flow(FlowDirection.In)] int green, [Flow(FlowDirection.In)] int blue, [Flow(FlowDirection.In)] int alpha);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor4iv")]
        public abstract unsafe void Color4([Count(Count = 4), Flow(FlowDirection.In)] int* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor4iv")]
        public abstract void Color4([Count(Count = 4), Flow(FlowDirection.In)] Span<int> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor4s")]
        public abstract void Color4([Flow(FlowDirection.In)] short red, [Flow(FlowDirection.In)] short green, [Flow(FlowDirection.In)] short blue, [Flow(FlowDirection.In)] short alpha);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor4sv")]
        public abstract unsafe void Color4([Count(Count = 4), Flow(FlowDirection.In)] short* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor4sv")]
        public abstract void Color4([Count(Count = 4), Flow(FlowDirection.In)] Span<short> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor4ub")]
        public abstract void Color4([Flow(FlowDirection.In)] byte red, [Flow(FlowDirection.In)] byte green, [Flow(FlowDirection.In)] byte blue, [Flow(FlowDirection.In)] byte alpha);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor4ubv")]
        public abstract unsafe void Color4([Count(Count = 4), Flow(FlowDirection.In)] byte* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor4ubv")]
        public abstract void Color4([Count(Count = 4), Flow(FlowDirection.In)] Span<byte> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor4ui")]
        public abstract void Color4([Flow(FlowDirection.In)] uint red, [Flow(FlowDirection.In)] uint green, [Flow(FlowDirection.In)] uint blue, [Flow(FlowDirection.In)] uint alpha);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor4uiv")]
        public abstract unsafe void Color4([Count(Count = 4), Flow(FlowDirection.In)] uint* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor4uiv")]
        public abstract void Color4([Count(Count = 4), Flow(FlowDirection.In)] Span<uint> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor4us")]
        public abstract void Color4([Flow(FlowDirection.In)] ushort red, [Flow(FlowDirection.In)] ushort green, [Flow(FlowDirection.In)] ushort blue, [Flow(FlowDirection.In)] ushort alpha);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor4usv")]
        public abstract unsafe void Color4([Count(Count = 4), Flow(FlowDirection.In)] ushort* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor4usv")]
        public abstract void Color4([Count(Count = 4), Flow(FlowDirection.In)] Span<ushort> v);

        [NativeApi(EntryPoint = "glColorMask")]
        public abstract void ColorMask([Flow(FlowDirection.In)] bool red, [Flow(FlowDirection.In)] bool green, [Flow(FlowDirection.In)] bool blue, [Flow(FlowDirection.In)] bool alpha);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColorMaterial")]
        public abstract void ColorMaterial([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] GLEnum mode);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glCopyPixels")]
        public abstract void CopyPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum type);

        [NativeApi(EntryPoint = "glCullFace")]
        public abstract void CullFace([Flow(FlowDirection.In)] GLEnum mode);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glDeleteLists")]
        public abstract void DeleteLists([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint range);

        [NativeApi(EntryPoint = "glDepthFunc")]
        public abstract void DepthFunc([Flow(FlowDirection.In)] GLEnum func);

        [NativeApi(EntryPoint = "glDepthMask")]
        public abstract void DepthMask([Flow(FlowDirection.In)] bool flag);

        [NativeApi(EntryPoint = "glDepthRange")]
        public abstract void DepthRange([Flow(FlowDirection.In)] double n, [Flow(FlowDirection.In)] double f);

        [NativeApi(EntryPoint = "glDisable")]
        public abstract void Disable([Flow(FlowDirection.In)] GLEnum cap);

        [NativeApi(EntryPoint = "glDrawBuffer")]
        public abstract void DrawBuffer([Flow(FlowDirection.In)] GLEnum buf);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glDrawPixels")]
        public abstract unsafe void DrawPixels([Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glDrawPixels")]
        public abstract void DrawPixels<T0>([Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glEdgeFlag")]
        public abstract void EdgeFlag([Flow(FlowDirection.In)] bool flag);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glEdgeFlagv")]
        public abstract unsafe void EdgeFlag([Count(Count = 1), Flow(FlowDirection.In)] bool* flag);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glEdgeFlagv")]
        public abstract void EdgeFlag([Count(Count = 1), Flow(FlowDirection.In)] ref bool flag);

        [NativeApi(EntryPoint = "glEnable")]
        public abstract void Enable([Flow(FlowDirection.In)] GLEnum cap);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glEnd")]
        public abstract void End();

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glEndList")]
        public abstract void EndList();

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glEvalCoord1d")]
        public abstract void EvalCoord1([Flow(FlowDirection.In)] double u);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glEvalCoord1dv")]
        public abstract unsafe void EvalCoord1([Count(Count = 1), Flow(FlowDirection.In)] double* u);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glEvalCoord1dv")]
        public abstract void EvalCoord1([Count(Count = 1), Flow(FlowDirection.In)] ref double u);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glEvalCoord1f")]
        public abstract void EvalCoord1([Flow(FlowDirection.In)] float u);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glEvalCoord1fv")]
        public abstract unsafe void EvalCoord1([Count(Count = 1), Flow(FlowDirection.In)] float* u);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glEvalCoord1fv")]
        public abstract void EvalCoord1([Count(Count = 1), Flow(FlowDirection.In)] ref float u);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glEvalCoord2d")]
        public abstract void EvalCoord2([Flow(FlowDirection.In)] double u, [Flow(FlowDirection.In)] double v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glEvalCoord2dv")]
        public abstract unsafe void EvalCoord2([Count(Count = 2), Flow(FlowDirection.In)] double* u);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glEvalCoord2dv")]
        public abstract void EvalCoord2([Count(Count = 2), Flow(FlowDirection.In)] Span<double> u);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glEvalCoord2f")]
        public abstract void EvalCoord2([Flow(FlowDirection.In)] float u, [Flow(FlowDirection.In)] float v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glEvalCoord2fv")]
        public abstract unsafe void EvalCoord2([Count(Count = 2), Flow(FlowDirection.In)] float* u);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glEvalCoord2fv")]
        public abstract void EvalCoord2([Count(Count = 2), Flow(FlowDirection.In)] Span<float> u);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glEvalMesh1")]
        public abstract void EvalMesh1([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] int i1, [Flow(FlowDirection.In)] int i2);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glEvalMesh2")]
        public abstract void EvalMesh2([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] int i1, [Flow(FlowDirection.In)] int i2, [Flow(FlowDirection.In)] int j1, [Flow(FlowDirection.In)] int j2);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glEvalPoint1")]
        public abstract void EvalPoint1([Flow(FlowDirection.In)] int i);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glEvalPoint2")]
        public abstract void EvalPoint2([Flow(FlowDirection.In)] int i, [Flow(FlowDirection.In)] int j);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glFeedbackBuffer")]
        public abstract unsafe void FeedbackBuffer([Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] GLEnum type, [Count(Parameter = "size"), Flow(FlowDirection.Out)] float* buffer);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glFeedbackBuffer")]
        public abstract void FeedbackBuffer([Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] GLEnum type, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<float> buffer);

        [NativeApi(EntryPoint = "glFinish")]
        public abstract void Finish();

        [NativeApi(EntryPoint = "glFlush")]
        public abstract void Flush();

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glFogf")]
        public abstract void Fog([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float param);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glFogfv")]
        public abstract unsafe void Fog([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glFogfv")]
        public abstract void Fog([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glFogi")]
        public abstract void Fog([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glFogiv")]
        public abstract unsafe void Fog([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glFogiv")]
        public abstract void Fog([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glFrontFace")]
        public abstract void FrontFace([Flow(FlowDirection.In)] GLEnum mode);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glFrustum")]
        public abstract void Frustum([Flow(FlowDirection.In)] double left, [Flow(FlowDirection.In)] double right, [Flow(FlowDirection.In)] double bottom, [Flow(FlowDirection.In)] double top, [Flow(FlowDirection.In)] double zNear, [Flow(FlowDirection.In)] double zFar);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGenLists")]
        public abstract uint GenLists([Flow(FlowDirection.In)] uint range);

        [NativeApi(EntryPoint = "glGetBooleanv")]
        public abstract unsafe void GetBoolean([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetBooleanv")]
        public abstract void GetBoolean([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out bool data);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetClipPlane")]
        public abstract unsafe void GetClipPlane([Flow(FlowDirection.In)] GLEnum plane, [Count(Count = 4), Flow(FlowDirection.Out)] double* equation);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetClipPlane")]
        public abstract void GetClipPlane([Flow(FlowDirection.In)] GLEnum plane, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> equation);

        [NativeApi(EntryPoint = "glGetDoublev")]
        public abstract unsafe void GetDouble([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* data);

        [NativeApi(EntryPoint = "glGetDoublev")]
        public abstract void GetDouble([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double data);

        [NativeApi(EntryPoint = "glGetError")]
        public abstract GLEnum GetError();

        [NativeApi(EntryPoint = "glGetFloatv")]
        public abstract unsafe void GetFloat([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetFloatv")]
        public abstract void GetFloat([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetIntegerv")]
        public abstract unsafe void GetInteger([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetIntegerv")]
        public abstract void GetInteger([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int data);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetLightfv")]
        public abstract unsafe void GetLight([Flow(FlowDirection.In)] GLEnum light, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetLightfv")]
        public abstract void GetLight([Flow(FlowDirection.In)] GLEnum light, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetLightiv")]
        public abstract unsafe void GetLight([Flow(FlowDirection.In)] GLEnum light, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetLightiv")]
        public abstract void GetLight([Flow(FlowDirection.In)] GLEnum light, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetMapdv")]
        public abstract unsafe void GetMap([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum query, [Count(Computed = "target, query"), Flow(FlowDirection.Out)] double* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetMapdv")]
        public abstract void GetMap([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum query, [Count(Computed = "target, query"), Flow(FlowDirection.Out)] out double v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetMapfv")]
        public abstract unsafe void GetMap([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum query, [Count(Computed = "target, query"), Flow(FlowDirection.Out)] float* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetMapfv")]
        public abstract void GetMap([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum query, [Count(Computed = "target, query"), Flow(FlowDirection.Out)] out float v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetMapiv")]
        public abstract unsafe void GetMap([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum query, [Count(Computed = "target, query"), Flow(FlowDirection.Out)] int* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetMapiv")]
        public abstract void GetMap([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum query, [Count(Computed = "target, query"), Flow(FlowDirection.Out)] out int v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetMaterialfv")]
        public abstract unsafe void GetMaterial([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetMaterialfv")]
        public abstract void GetMaterial([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetMaterialiv")]
        public abstract unsafe void GetMaterial([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetMaterialiv")]
        public abstract void GetMaterial([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetPixelMapfv")]
        public abstract unsafe void GetPixelMap([Flow(FlowDirection.In)] GLEnum map, [Count(Computed = "map"), Flow(FlowDirection.Out)] float* values);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetPixelMapfv")]
        public abstract void GetPixelMap([Flow(FlowDirection.In)] GLEnum map, [Count(Computed = "map"), Flow(FlowDirection.Out)] out float values);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetPixelMapuiv")]
        public abstract unsafe void GetPixelMap([Flow(FlowDirection.In)] GLEnum map, [Count(Computed = "map"), Flow(FlowDirection.Out)] uint* values);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetPixelMapuiv")]
        public abstract void GetPixelMap([Flow(FlowDirection.In)] GLEnum map, [Count(Computed = "map"), Flow(FlowDirection.Out)] out uint values);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetPixelMapusv")]
        public abstract unsafe void GetPixelMap([Flow(FlowDirection.In)] GLEnum map, [Count(Computed = "map"), Flow(FlowDirection.Out)] ushort* values);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetPixelMapusv")]
        public abstract void GetPixelMap([Flow(FlowDirection.In)] GLEnum map, [Count(Computed = "map"), Flow(FlowDirection.Out)] out ushort values);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetPolygonStipple")]
        public abstract unsafe void GetPolygonStipple([Count(Count = 0), Flow(FlowDirection.Out)] byte* mask);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetPolygonStipple")]
        public abstract void GetPolygonStipple([Count(Count = 0), Flow(FlowDirection.Out)] out byte mask);

        [NativeApi(EntryPoint = "glGetString")]
        public abstract unsafe byte* GetString([Flow(FlowDirection.In)] GLEnum name);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetTexEnvfv")]
        public abstract unsafe void GetTexEnv([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetTexEnvfv")]
        public abstract void GetTexEnv([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetTexEnviv")]
        public abstract unsafe void GetTexEnv([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetTexEnviv")]
        public abstract void GetTexEnv([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetTexGendv")]
        public abstract unsafe void GetTexGen([Flow(FlowDirection.In)] GLEnum coord, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetTexGendv")]
        public abstract void GetTexGen([Flow(FlowDirection.In)] GLEnum coord, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetTexGenfv")]
        public abstract unsafe void GetTexGen([Flow(FlowDirection.In)] GLEnum coord, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetTexGenfv")]
        public abstract void GetTexGen([Flow(FlowDirection.In)] GLEnum coord, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetTexGeniv")]
        public abstract unsafe void GetTexGen([Flow(FlowDirection.In)] GLEnum coord, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetTexGeniv")]
        public abstract void GetTexGen([Flow(FlowDirection.In)] GLEnum coord, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexImage")]
        public abstract unsafe void GetTexImage([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTexImage")]
        public abstract void GetTexImage<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTexLevelParameterfv")]
        public abstract unsafe void GetTexLevelParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterfv")]
        public abstract void GetTexLevelParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameteriv")]
        public abstract unsafe void GetTexLevelParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameteriv")]
        public abstract void GetTexLevelParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterfv")]
        public abstract unsafe void GetTexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTexParameterfv")]
        public abstract void GetTexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetTexParameteriv")]
        public abstract unsafe void GetTexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameteriv")]
        public abstract void GetTexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glHint")]
        public abstract void Hint([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum mode);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glIndexd")]
        public abstract void Index([Flow(FlowDirection.In)] double c);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glIndexdv")]
        public abstract unsafe void Index([Count(Count = 1), Flow(FlowDirection.In)] double* c);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glIndexdv")]
        public abstract void Index([Count(Count = 1), Flow(FlowDirection.In)] ref double c);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glIndexf")]
        public abstract void Index([Flow(FlowDirection.In)] float c);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glIndexfv")]
        public abstract unsafe void Index([Count(Count = 1), Flow(FlowDirection.In)] float* c);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glIndexfv")]
        public abstract void Index([Count(Count = 1), Flow(FlowDirection.In)] ref float c);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glIndexi")]
        public abstract void Index([Flow(FlowDirection.In)] int c);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glIndexiv")]
        public abstract unsafe void Index([Count(Count = 1), Flow(FlowDirection.In)] int* c);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glIndexiv")]
        public abstract void Index([Count(Count = 1), Flow(FlowDirection.In)] ref int c);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glIndexs")]
        public abstract void Index([Flow(FlowDirection.In)] short c);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glIndexsv")]
        public abstract unsafe void Index([Count(Count = 1), Flow(FlowDirection.In)] short* c);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glIndexsv")]
        public abstract void Index([Count(Count = 1), Flow(FlowDirection.In)] ref short c);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glIndexMask")]
        public abstract void IndexMask([Flow(FlowDirection.In)] uint mask);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glInitNames")]
        public abstract void InitNames();

        [NativeApi(EntryPoint = "glIsEnabled")]
        public abstract bool IsEnabled([Flow(FlowDirection.In)] GLEnum cap);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glIsList")]
        public abstract bool IsList([Flow(FlowDirection.In)] uint list);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLightf")]
        public abstract void Light([Flow(FlowDirection.In)] GLEnum light, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float param);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLightfv")]
        public abstract unsafe void Light([Flow(FlowDirection.In)] GLEnum light, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLightfv")]
        public abstract void Light([Flow(FlowDirection.In)] GLEnum light, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLighti")]
        public abstract void Light([Flow(FlowDirection.In)] GLEnum light, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLightiv")]
        public abstract unsafe void Light([Flow(FlowDirection.In)] GLEnum light, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLightiv")]
        public abstract void Light([Flow(FlowDirection.In)] GLEnum light, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLightModelf")]
        public abstract void LightModel([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float param);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLightModelfv")]
        public abstract unsafe void LightModel([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLightModelfv")]
        public abstract void LightModel([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLightModeli")]
        public abstract void LightModel([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLightModeliv")]
        public abstract unsafe void LightModel([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLightModeliv")]
        public abstract void LightModel([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLineStipple")]
        public abstract void LineStipple([Flow(FlowDirection.In)] int factor, [Flow(FlowDirection.In)] ushort pattern);

        [NativeApi(EntryPoint = "glLineWidth")]
        public abstract void LineWidth([Flow(FlowDirection.In)] float width);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glListBase")]
        public abstract void ListBase([Flow(FlowDirection.In)] uint @base);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLoadIdentity")]
        public abstract void LoadIdentity();

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLoadMatrixf")]
        public abstract unsafe void LoadMatrix([Count(Count = 16), Flow(FlowDirection.In)] float* m);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLoadMatrixf")]
        public abstract void LoadMatrix([Count(Count = 16), Flow(FlowDirection.In)] Span<float> m);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLoadMatrixd")]
        public abstract unsafe void LoadMatrix([Count(Count = 16), Flow(FlowDirection.In)] double* m);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLoadMatrixd")]
        public abstract void LoadMatrix([Count(Count = 16), Flow(FlowDirection.In)] Span<double> m);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLoadName")]
        public abstract void LoadName([Flow(FlowDirection.In)] uint name);

        [NativeApi(EntryPoint = "glLogicOp")]
        public abstract void LogicOp([Flow(FlowDirection.In)] GLEnum opcode);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMap1d")]
        public abstract unsafe void Map1([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int stride, [Flow(FlowDirection.In)] int order, [Count(Computed = "target, stride, order"), Flow(FlowDirection.In)] double* points);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMap1d")]
        public abstract void Map1([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int stride, [Flow(FlowDirection.In)] int order, [Count(Computed = "target, stride, order"), Flow(FlowDirection.In)] ref double points);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMap1f")]
        public abstract unsafe void Map1([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int stride, [Flow(FlowDirection.In)] int order, [Count(Computed = "target, stride, order"), Flow(FlowDirection.In)] float* points);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMap1f")]
        public abstract void Map1([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int stride, [Flow(FlowDirection.In)] int order, [Count(Computed = "target, stride, order"), Flow(FlowDirection.In)] ref float points);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMap2d")]
        public abstract unsafe void Map2([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] double v1, [Flow(FlowDirection.In)] double v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Count(Computed = "target, ustride, uorder, vstride, vorder"), Flow(FlowDirection.In)] double* points);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMap2d")]
        public abstract void Map2([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] double v1, [Flow(FlowDirection.In)] double v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Count(Computed = "target, ustride, uorder, vstride, vorder"), Flow(FlowDirection.In)] ref double points);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMap2f")]
        public abstract unsafe void Map2([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Count(Computed = "target, ustride, uorder, vstride, vorder"), Flow(FlowDirection.In)] float* points);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMap2f")]
        public abstract void Map2([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Count(Computed = "target, ustride, uorder, vstride, vorder"), Flow(FlowDirection.In)] ref float points);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMapGrid1d")]
        public abstract void MapGrid1([Flow(FlowDirection.In)] int un, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMapGrid1f")]
        public abstract void MapGrid1([Flow(FlowDirection.In)] int un, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMapGrid2d")]
        public abstract void MapGrid2([Flow(FlowDirection.In)] int un, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int vn, [Flow(FlowDirection.In)] double v1, [Flow(FlowDirection.In)] double v2);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMapGrid2f")]
        public abstract void MapGrid2([Flow(FlowDirection.In)] int un, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int vn, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMaterialf")]
        public abstract void Material([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float param);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMaterialfv")]
        public abstract unsafe void Material([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMaterialfv")]
        public abstract void Material([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMateriali")]
        public abstract void Material([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMaterialiv")]
        public abstract unsafe void Material([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMaterialiv")]
        public abstract void Material([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMatrixMode")]
        public abstract void MatrixMode([Flow(FlowDirection.In)] GLEnum mode);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMultMatrixf")]
        public abstract unsafe void MultMatrix([Count(Count = 16), Flow(FlowDirection.In)] float* m);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMultMatrixf")]
        public abstract void MultMatrix([Count(Count = 16), Flow(FlowDirection.In)] Span<float> m);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMultMatrixd")]
        public abstract unsafe void MultMatrix([Count(Count = 16), Flow(FlowDirection.In)] double* m);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMultMatrixd")]
        public abstract void MultMatrix([Count(Count = 16), Flow(FlowDirection.In)] Span<double> m);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glNewList")]
        public abstract void NewList([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] GLEnum mode);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glNormal3b")]
        public abstract void Normal3([Flow(FlowDirection.In)] sbyte nx, [Flow(FlowDirection.In)] sbyte ny, [Flow(FlowDirection.In)] sbyte nz);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glNormal3bv")]
        public abstract unsafe void Normal3([Count(Count = 3), Flow(FlowDirection.In)] sbyte* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glNormal3bv")]
        public abstract void Normal3([Count(Count = 3), Flow(FlowDirection.In)] Span<sbyte> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glNormal3d")]
        public abstract void Normal3([Flow(FlowDirection.In)] double nx, [Flow(FlowDirection.In)] double ny, [Flow(FlowDirection.In)] double nz);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glNormal3dv")]
        public abstract unsafe void Normal3([Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glNormal3dv")]
        public abstract void Normal3([Count(Count = 3), Flow(FlowDirection.In)] Span<double> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glNormal3f")]
        public abstract void Normal3([Flow(FlowDirection.In)] float nx, [Flow(FlowDirection.In)] float ny, [Flow(FlowDirection.In)] float nz);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glNormal3fv")]
        public abstract unsafe void Normal3([Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glNormal3fv")]
        public abstract void Normal3([Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glNormal3i")]
        public abstract void Normal3([Flow(FlowDirection.In)] int nx, [Flow(FlowDirection.In)] int ny, [Flow(FlowDirection.In)] int nz);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glNormal3iv")]
        public abstract unsafe void Normal3([Count(Count = 3), Flow(FlowDirection.In)] int* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glNormal3iv")]
        public abstract void Normal3([Count(Count = 3), Flow(FlowDirection.In)] Span<int> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glNormal3s")]
        public abstract void Normal3([Flow(FlowDirection.In)] short nx, [Flow(FlowDirection.In)] short ny, [Flow(FlowDirection.In)] short nz);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glNormal3sv")]
        public abstract unsafe void Normal3([Count(Count = 3), Flow(FlowDirection.In)] short* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glNormal3sv")]
        public abstract void Normal3([Count(Count = 3), Flow(FlowDirection.In)] Span<short> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glOrtho")]
        public abstract void Ortho([Flow(FlowDirection.In)] double left, [Flow(FlowDirection.In)] double right, [Flow(FlowDirection.In)] double bottom, [Flow(FlowDirection.In)] double top, [Flow(FlowDirection.In)] double zNear, [Flow(FlowDirection.In)] double zFar);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glPassThrough")]
        public abstract void PassThrough([Flow(FlowDirection.In)] float token);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glPixelMapfv")]
        public abstract unsafe void PixelMap([Flow(FlowDirection.In)] GLEnum map, [Flow(FlowDirection.In)] uint mapsize, [Count(Parameter = "mapsize"), Flow(FlowDirection.In)] float* values);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glPixelMapfv")]
        public abstract void PixelMap([Flow(FlowDirection.In)] GLEnum map, [Flow(FlowDirection.In)] uint mapsize, [Count(Parameter = "mapsize"), Flow(FlowDirection.In)] Span<float> values);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glPixelMapuiv")]
        public abstract unsafe void PixelMap([Flow(FlowDirection.In)] GLEnum map, [Flow(FlowDirection.In)] uint mapsize, [Count(Parameter = "mapsize"), Flow(FlowDirection.In)] uint* values);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glPixelMapuiv")]
        public abstract void PixelMap([Flow(FlowDirection.In)] GLEnum map, [Flow(FlowDirection.In)] uint mapsize, [Count(Parameter = "mapsize"), Flow(FlowDirection.In)] Span<uint> values);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glPixelMapusv")]
        public abstract unsafe void PixelMap([Flow(FlowDirection.In)] GLEnum map, [Flow(FlowDirection.In)] uint mapsize, [Count(Parameter = "mapsize"), Flow(FlowDirection.In)] ushort* values);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glPixelMapusv")]
        public abstract void PixelMap([Flow(FlowDirection.In)] GLEnum map, [Flow(FlowDirection.In)] uint mapsize, [Count(Parameter = "mapsize"), Flow(FlowDirection.In)] Span<ushort> values);

        [NativeApi(EntryPoint = "glPixelStoref")]
        public abstract void PixelStore([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glPixelStorei")]
        public abstract void PixelStore([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glPixelTransferf")]
        public abstract void PixelTransfer([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float param);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glPixelTransferi")]
        public abstract void PixelTransfer([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glPixelZoom")]
        public abstract void PixelZoom([Flow(FlowDirection.In)] float xfactor, [Flow(FlowDirection.In)] float yfactor);

        [NativeApi(EntryPoint = "glPointSize")]
        public abstract void PointSize([Flow(FlowDirection.In)] float size);

        [NativeApi(EntryPoint = "glPolygonMode")]
        public abstract void PolygonMode([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] GLEnum mode);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glPolygonStipple")]
        public abstract unsafe void PolygonStipple([Count(Count = 0), Flow(FlowDirection.In)] byte* mask);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glPolygonStipple")]
        public abstract void PolygonStipple([Count(Count = 0), Flow(FlowDirection.In)] ref byte mask);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glPopAttrib")]
        public abstract void PopAttrib();

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glPopMatrix")]
        public abstract void PopMatrix();

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glPopName")]
        public abstract void PopName();

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glPushAttrib")]
        public abstract void PushAttrib([Flow(FlowDirection.In)] uint mask);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glPushMatrix")]
        public abstract void PushMatrix();

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glPushName")]
        public abstract void PushName([Flow(FlowDirection.In)] uint name);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos2d")]
        public abstract void RasterPos2([Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos2dv")]
        public abstract unsafe void RasterPos2([Count(Count = 2), Flow(FlowDirection.In)] double* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos2dv")]
        public abstract void RasterPos2([Count(Count = 2), Flow(FlowDirection.In)] Span<double> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos2f")]
        public abstract void RasterPos2([Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos2fv")]
        public abstract unsafe void RasterPos2([Count(Count = 2), Flow(FlowDirection.In)] float* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos2fv")]
        public abstract void RasterPos2([Count(Count = 2), Flow(FlowDirection.In)] Span<float> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos2i")]
        public abstract void RasterPos2([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos2iv")]
        public abstract unsafe void RasterPos2([Count(Count = 2), Flow(FlowDirection.In)] int* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos2iv")]
        public abstract void RasterPos2([Count(Count = 2), Flow(FlowDirection.In)] Span<int> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos2s")]
        public abstract void RasterPos2([Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos2sv")]
        public abstract unsafe void RasterPos2([Count(Count = 2), Flow(FlowDirection.In)] short* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos2sv")]
        public abstract void RasterPos2([Count(Count = 2), Flow(FlowDirection.In)] Span<short> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos3d")]
        public abstract void RasterPos3([Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos3dv")]
        public abstract unsafe void RasterPos3([Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos3dv")]
        public abstract void RasterPos3([Count(Count = 3), Flow(FlowDirection.In)] Span<double> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos3f")]
        public abstract void RasterPos3([Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos3fv")]
        public abstract unsafe void RasterPos3([Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos3fv")]
        public abstract void RasterPos3([Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos3i")]
        public abstract void RasterPos3([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos3iv")]
        public abstract unsafe void RasterPos3([Count(Count = 3), Flow(FlowDirection.In)] int* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos3iv")]
        public abstract void RasterPos3([Count(Count = 3), Flow(FlowDirection.In)] Span<int> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos3s")]
        public abstract void RasterPos3([Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos3sv")]
        public abstract unsafe void RasterPos3([Count(Count = 3), Flow(FlowDirection.In)] short* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos3sv")]
        public abstract void RasterPos3([Count(Count = 3), Flow(FlowDirection.In)] Span<short> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos4d")]
        public abstract void RasterPos4([Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos4dv")]
        public abstract unsafe void RasterPos4([Count(Count = 4), Flow(FlowDirection.In)] double* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos4dv")]
        public abstract void RasterPos4([Count(Count = 4), Flow(FlowDirection.In)] Span<double> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos4f")]
        public abstract void RasterPos4([Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos4fv")]
        public abstract unsafe void RasterPos4([Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos4fv")]
        public abstract void RasterPos4([Count(Count = 4), Flow(FlowDirection.In)] Span<float> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos4i")]
        public abstract void RasterPos4([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos4iv")]
        public abstract unsafe void RasterPos4([Count(Count = 4), Flow(FlowDirection.In)] int* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos4iv")]
        public abstract void RasterPos4([Count(Count = 4), Flow(FlowDirection.In)] Span<int> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos4s")]
        public abstract void RasterPos4([Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z, [Flow(FlowDirection.In)] short w);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos4sv")]
        public abstract unsafe void RasterPos4([Count(Count = 4), Flow(FlowDirection.In)] short* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRasterPos4sv")]
        public abstract void RasterPos4([Count(Count = 4), Flow(FlowDirection.In)] Span<short> v);

        [NativeApi(EntryPoint = "glReadBuffer")]
        public abstract void ReadBuffer([Flow(FlowDirection.In)] GLEnum src);

        [NativeApi(EntryPoint = "glReadPixels")]
        public abstract unsafe void ReadPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glReadPixels")]
        public abstract void ReadPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRectd")]
        public abstract void Rect([Flow(FlowDirection.In)] double x1, [Flow(FlowDirection.In)] double y1, [Flow(FlowDirection.In)] double x2, [Flow(FlowDirection.In)] double y2);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRectdv")]
        public abstract unsafe void Rect([Count(Count = 2), Flow(FlowDirection.In)] double* v1, [Count(Count = 2), Flow(FlowDirection.In)] double* v2);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRectdv")]
        public abstract void Rect([Count(Count = 2), Flow(FlowDirection.In)] Span<double> v1, [Count(Count = 2), Flow(FlowDirection.In)] Span<double> v2);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRectf")]
        public abstract void Rect([Flow(FlowDirection.In)] float x1, [Flow(FlowDirection.In)] float y1, [Flow(FlowDirection.In)] float x2, [Flow(FlowDirection.In)] float y2);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRectfv")]
        public abstract unsafe void Rect([Count(Count = 2), Flow(FlowDirection.In)] float* v1, [Count(Count = 2), Flow(FlowDirection.In)] float* v2);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRectfv")]
        public abstract void Rect([Count(Count = 2), Flow(FlowDirection.In)] Span<float> v1, [Count(Count = 2), Flow(FlowDirection.In)] Span<float> v2);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRecti")]
        public abstract void Rect([Flow(FlowDirection.In)] int x1, [Flow(FlowDirection.In)] int y1, [Flow(FlowDirection.In)] int x2, [Flow(FlowDirection.In)] int y2);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRectiv")]
        public abstract unsafe void Rect([Count(Count = 2), Flow(FlowDirection.In)] int* v1, [Count(Count = 2), Flow(FlowDirection.In)] int* v2);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRectiv")]
        public abstract void Rect([Count(Count = 2), Flow(FlowDirection.In)] Span<int> v1, [Count(Count = 2), Flow(FlowDirection.In)] Span<int> v2);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRectsv")]
        public abstract unsafe void Rect([Count(Count = 2), Flow(FlowDirection.In)] short* v1, [Count(Count = 2), Flow(FlowDirection.In)] short* v2);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRectsv")]
        public abstract void Rect([Count(Count = 2), Flow(FlowDirection.In)] Span<short> v1, [Count(Count = 2), Flow(FlowDirection.In)] Span<short> v2);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRects")]
        public abstract void Rects([Flow(FlowDirection.In)] short x1, [Flow(FlowDirection.In)] short y1, [Flow(FlowDirection.In)] short x2, [Flow(FlowDirection.In)] short y2);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRenderMode")]
        public abstract int RenderMode([Flow(FlowDirection.In)] GLEnum mode);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRotated")]
        public abstract void Rotate([Flow(FlowDirection.In)] double angle, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRotatef")]
        public abstract void Rotate([Flow(FlowDirection.In)] float angle, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glScaled")]
        public abstract void Scale([Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glScalef")]
        public abstract void Scale([Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glScissor")]
        public abstract void Scissor([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glSelectBuffer")]
        public abstract unsafe void SelectBuffer([Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] uint* buffer);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glSelectBuffer")]
        public abstract void SelectBuffer([Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<uint> buffer);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glShadeModel")]
        public abstract void ShadeModel([Flow(FlowDirection.In)] GLEnum mode);

        [NativeApi(EntryPoint = "glStencilFunc")]
        public abstract void StencilFunc([Flow(FlowDirection.In)] GLEnum func, [Flow(FlowDirection.In)] int @ref, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilMask")]
        public abstract void StencilMask([Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilOp")]
        public abstract void StencilOp([Flow(FlowDirection.In)] GLEnum fail, [Flow(FlowDirection.In)] GLEnum zfail, [Flow(FlowDirection.In)] GLEnum zpass);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord1d")]
        public abstract void TexCoord1([Flow(FlowDirection.In)] double s);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord1dv")]
        public abstract unsafe void TexCoord1([Count(Count = 1), Flow(FlowDirection.In)] double* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord1dv")]
        public abstract void TexCoord1([Count(Count = 1), Flow(FlowDirection.In)] ref double v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord1f")]
        public abstract void TexCoord1([Flow(FlowDirection.In)] float s);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord1fv")]
        public abstract unsafe void TexCoord1([Count(Count = 1), Flow(FlowDirection.In)] float* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord1fv")]
        public abstract void TexCoord1([Count(Count = 1), Flow(FlowDirection.In)] ref float v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord1i")]
        public abstract void TexCoord1([Flow(FlowDirection.In)] int s);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord1iv")]
        public abstract unsafe void TexCoord1([Count(Count = 1), Flow(FlowDirection.In)] int* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord1iv")]
        public abstract void TexCoord1([Count(Count = 1), Flow(FlowDirection.In)] ref int v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord1s")]
        public abstract void TexCoord1([Flow(FlowDirection.In)] short s);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord1sv")]
        public abstract unsafe void TexCoord1([Count(Count = 1), Flow(FlowDirection.In)] short* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord1sv")]
        public abstract void TexCoord1([Count(Count = 1), Flow(FlowDirection.In)] ref short v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord2d")]
        public abstract void TexCoord2([Flow(FlowDirection.In)] double s, [Flow(FlowDirection.In)] double t);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord2dv")]
        public abstract unsafe void TexCoord2([Count(Count = 2), Flow(FlowDirection.In)] double* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord2dv")]
        public abstract void TexCoord2([Count(Count = 2), Flow(FlowDirection.In)] Span<double> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord2f")]
        public abstract void TexCoord2([Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord2fv")]
        public abstract unsafe void TexCoord2([Count(Count = 2), Flow(FlowDirection.In)] float* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord2fv")]
        public abstract void TexCoord2([Count(Count = 2), Flow(FlowDirection.In)] Span<float> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord2i")]
        public abstract void TexCoord2([Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord2iv")]
        public abstract unsafe void TexCoord2([Count(Count = 2), Flow(FlowDirection.In)] int* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord2iv")]
        public abstract void TexCoord2([Count(Count = 2), Flow(FlowDirection.In)] Span<int> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord2s")]
        public abstract void TexCoord2([Flow(FlowDirection.In)] short s, [Flow(FlowDirection.In)] short t);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord2sv")]
        public abstract unsafe void TexCoord2([Count(Count = 2), Flow(FlowDirection.In)] short* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord2sv")]
        public abstract void TexCoord2([Count(Count = 2), Flow(FlowDirection.In)] Span<short> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord3d")]
        public abstract void TexCoord3([Flow(FlowDirection.In)] double s, [Flow(FlowDirection.In)] double t, [Flow(FlowDirection.In)] double r);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord3dv")]
        public abstract unsafe void TexCoord3([Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord3dv")]
        public abstract void TexCoord3([Count(Count = 3), Flow(FlowDirection.In)] Span<double> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord3f")]
        public abstract void TexCoord3([Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float r);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord3fv")]
        public abstract unsafe void TexCoord3([Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord3fv")]
        public abstract void TexCoord3([Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord3i")]
        public abstract void TexCoord3([Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord3iv")]
        public abstract unsafe void TexCoord3([Count(Count = 3), Flow(FlowDirection.In)] int* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord3iv")]
        public abstract void TexCoord3([Count(Count = 3), Flow(FlowDirection.In)] Span<int> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord3s")]
        public abstract void TexCoord3([Flow(FlowDirection.In)] short s, [Flow(FlowDirection.In)] short t, [Flow(FlowDirection.In)] short r);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord3sv")]
        public abstract unsafe void TexCoord3([Count(Count = 3), Flow(FlowDirection.In)] short* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord3sv")]
        public abstract void TexCoord3([Count(Count = 3), Flow(FlowDirection.In)] Span<short> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord4d")]
        public abstract void TexCoord4([Flow(FlowDirection.In)] double s, [Flow(FlowDirection.In)] double t, [Flow(FlowDirection.In)] double r, [Flow(FlowDirection.In)] double q);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord4dv")]
        public abstract unsafe void TexCoord4([Count(Count = 4), Flow(FlowDirection.In)] double* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord4dv")]
        public abstract void TexCoord4([Count(Count = 4), Flow(FlowDirection.In)] Span<double> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord4f")]
        public abstract void TexCoord4([Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float q);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord4fv")]
        public abstract unsafe void TexCoord4([Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord4fv")]
        public abstract void TexCoord4([Count(Count = 4), Flow(FlowDirection.In)] Span<float> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord4i")]
        public abstract void TexCoord4([Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r, [Flow(FlowDirection.In)] int q);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord4iv")]
        public abstract unsafe void TexCoord4([Count(Count = 4), Flow(FlowDirection.In)] int* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord4iv")]
        public abstract void TexCoord4([Count(Count = 4), Flow(FlowDirection.In)] Span<int> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord4s")]
        public abstract void TexCoord4([Flow(FlowDirection.In)] short s, [Flow(FlowDirection.In)] short t, [Flow(FlowDirection.In)] short r, [Flow(FlowDirection.In)] short q);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord4sv")]
        public abstract unsafe void TexCoord4([Count(Count = 4), Flow(FlowDirection.In)] short* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexCoord4sv")]
        public abstract void TexCoord4([Count(Count = 4), Flow(FlowDirection.In)] Span<short> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexEnvf")]
        public abstract void TexEnv([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float param);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexEnvfv")]
        public abstract unsafe void TexEnv([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexEnvfv")]
        public abstract void TexEnv([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexEnvi")]
        public abstract void TexEnv([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexEnviv")]
        public abstract unsafe void TexEnv([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexEnviv")]
        public abstract void TexEnv([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexGendv")]
        public abstract unsafe void TexGen([Flow(FlowDirection.In)] GLEnum coord, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] double* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexGendv")]
        public abstract void TexGen([Flow(FlowDirection.In)] GLEnum coord, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref double @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexGenf")]
        public abstract void TexGen([Flow(FlowDirection.In)] GLEnum coord, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float param);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexGenfv")]
        public abstract unsafe void TexGen([Flow(FlowDirection.In)] GLEnum coord, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexGenfv")]
        public abstract void TexGen([Flow(FlowDirection.In)] GLEnum coord, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexGeni")]
        public abstract void TexGen([Flow(FlowDirection.In)] GLEnum coord, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexGeniv")]
        public abstract unsafe void TexGen([Flow(FlowDirection.In)] GLEnum coord, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexGeniv")]
        public abstract void TexGen([Flow(FlowDirection.In)] GLEnum coord, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexGend")]
        public abstract void TexGend([Flow(FlowDirection.In)] GLEnum coord, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] double param);

        [NativeApi(EntryPoint = "glTexImage1D")]
        public abstract unsafe void TexImage1D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage1D")]
        public abstract void TexImage1D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage2D")]
        public abstract unsafe void TexImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage2D")]
        public abstract void TexImage2D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexParameterf")]
        public abstract void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glTexParameterfv")]
        public abstract unsafe void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glTexParameterfv")]
        public abstract void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [NativeApi(EntryPoint = "glTexParameteri")]
        public abstract void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexParameteriv")]
        public abstract unsafe void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameteriv")]
        public abstract void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTranslated")]
        public abstract void Translate([Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTranslatef")]
        public abstract void Translate([Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex2d")]
        public abstract void Vertex2([Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex2dv")]
        public abstract unsafe void Vertex2([Count(Count = 2), Flow(FlowDirection.In)] double* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex2dv")]
        public abstract void Vertex2([Count(Count = 2), Flow(FlowDirection.In)] Span<double> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex2f")]
        public abstract void Vertex2([Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex2fv")]
        public abstract unsafe void Vertex2([Count(Count = 2), Flow(FlowDirection.In)] float* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex2fv")]
        public abstract void Vertex2([Count(Count = 2), Flow(FlowDirection.In)] Span<float> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex2i")]
        public abstract void Vertex2([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex2iv")]
        public abstract unsafe void Vertex2([Count(Count = 2), Flow(FlowDirection.In)] int* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex2iv")]
        public abstract void Vertex2([Count(Count = 2), Flow(FlowDirection.In)] Span<int> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex2s")]
        public abstract void Vertex2([Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex2sv")]
        public abstract unsafe void Vertex2([Count(Count = 2), Flow(FlowDirection.In)] short* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex2sv")]
        public abstract void Vertex2([Count(Count = 2), Flow(FlowDirection.In)] Span<short> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex3d")]
        public abstract void Vertex3([Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex3dv")]
        public abstract unsafe void Vertex3([Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex3dv")]
        public abstract void Vertex3([Count(Count = 3), Flow(FlowDirection.In)] Span<double> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex3f")]
        public abstract void Vertex3([Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex3fv")]
        public abstract unsafe void Vertex3([Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex3fv")]
        public abstract void Vertex3([Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex3i")]
        public abstract void Vertex3([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex3iv")]
        public abstract unsafe void Vertex3([Count(Count = 3), Flow(FlowDirection.In)] int* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex3iv")]
        public abstract void Vertex3([Count(Count = 3), Flow(FlowDirection.In)] Span<int> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex3s")]
        public abstract void Vertex3([Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex3sv")]
        public abstract unsafe void Vertex3([Count(Count = 3), Flow(FlowDirection.In)] short* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex3sv")]
        public abstract void Vertex3([Count(Count = 3), Flow(FlowDirection.In)] Span<short> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex4d")]
        public abstract void Vertex4([Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex4dv")]
        public abstract unsafe void Vertex4([Count(Count = 4), Flow(FlowDirection.In)] double* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex4dv")]
        public abstract void Vertex4([Count(Count = 4), Flow(FlowDirection.In)] Span<double> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex4f")]
        public abstract void Vertex4([Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex4fv")]
        public abstract unsafe void Vertex4([Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex4fv")]
        public abstract void Vertex4([Count(Count = 4), Flow(FlowDirection.In)] Span<float> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex4i")]
        public abstract void Vertex4([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex4iv")]
        public abstract unsafe void Vertex4([Count(Count = 4), Flow(FlowDirection.In)] int* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex4iv")]
        public abstract void Vertex4([Count(Count = 4), Flow(FlowDirection.In)] Span<int> v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex4s")]
        public abstract void Vertex4([Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z, [Flow(FlowDirection.In)] short w);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex4sv")]
        public abstract unsafe void Vertex4([Count(Count = 4), Flow(FlowDirection.In)] short* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glVertex4sv")]
        public abstract void Vertex4([Count(Count = 4), Flow(FlowDirection.In)] Span<short> v);

        [NativeApi(EntryPoint = "glViewport")]
        public abstract void Viewport([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glAccum")]
        public abstract void Accum([Flow(FlowDirection.In)] AccumOp op, [Flow(FlowDirection.In)] float value);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glAlphaFunc")]
        public abstract void AlphaFunc([Flow(FlowDirection.In)] AlphaFunction func, [Flow(FlowDirection.In)] float @ref);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glBegin")]
        public abstract void Begin([Flow(FlowDirection.In)] PrimitiveType mode);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glBitmap")]
        public abstract void Bitmap([Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] float xorig, [Flow(FlowDirection.In)] float yorig, [Flow(FlowDirection.In)] float xmove, [Flow(FlowDirection.In)] float ymove, [Flow(FlowDirection.In)] string bitmap);

        [NativeApi(EntryPoint = "glBlendFunc")]
        public abstract void BlendFunc([Flow(FlowDirection.In)] BlendingFactor sfactor, [Flow(FlowDirection.In)] BlendingFactor dfactor);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glCallLists")]
        public abstract unsafe void CallLists([Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] ListNameType type, [Count(Computed = "n, type"), Flow(FlowDirection.In)] void* lists);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glCallLists")]
        public abstract void CallLists<T0>([Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] ListNameType type, [Count(Computed = "n, type"), Flow(FlowDirection.In)] ref T0 lists) where T0 : unmanaged;

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glClipPlane")]
        public abstract unsafe void ClipPlane([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.In)] double* equation);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glClipPlane")]
        public abstract void ClipPlane([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> equation);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor3ubv")]
        public abstract void Color3([Flow(FlowDirection.In)] string v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColor4ubv")]
        public abstract void Color4([Flow(FlowDirection.In)] string v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glColorMaterial")]
        public abstract void ColorMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] ColorMaterialParameter mode);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glCopyPixels")]
        public abstract void CopyPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelCopyType type);

        [NativeApi(EntryPoint = "glCullFace")]
        public abstract void CullFace([Flow(FlowDirection.In)] CullFaceMode mode);

        [NativeApi(EntryPoint = "glDepthFunc")]
        public abstract void DepthFunc([Flow(FlowDirection.In)] DepthFunction func);

        [NativeApi(EntryPoint = "glDisable")]
        public abstract void Disable([Flow(FlowDirection.In)] EnableCap cap);

        [NativeApi(EntryPoint = "glDrawBuffer")]
        public abstract void DrawBuffer([Flow(FlowDirection.In)] DrawBufferMode buf);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glDrawPixels")]
        public abstract unsafe void DrawPixels([Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glDrawPixels")]
        public abstract void DrawPixels<T0>([Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glEnable")]
        public abstract void Enable([Flow(FlowDirection.In)] EnableCap cap);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glEvalMesh1")]
        public abstract void EvalMesh1([Flow(FlowDirection.In)] MeshMode1 mode, [Flow(FlowDirection.In)] int i1, [Flow(FlowDirection.In)] int i2);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glEvalMesh2")]
        public abstract void EvalMesh2([Flow(FlowDirection.In)] MeshMode2 mode, [Flow(FlowDirection.In)] int i1, [Flow(FlowDirection.In)] int i2, [Flow(FlowDirection.In)] int j1, [Flow(FlowDirection.In)] int j2);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glFeedbackBuffer")]
        public abstract unsafe void FeedbackBuffer([Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] FeedbackType type, [Count(Parameter = "size"), Flow(FlowDirection.Out)] float* buffer);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glFeedbackBuffer")]
        public abstract void FeedbackBuffer([Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] FeedbackType type, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<float> buffer);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glFogf")]
        public abstract void Fog([Flow(FlowDirection.In)] FogParameter pname, [Flow(FlowDirection.In)] float param);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glFogfv")]
        public abstract unsafe void Fog([Flow(FlowDirection.In)] FogParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glFogfv")]
        public abstract void Fog([Flow(FlowDirection.In)] FogParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glFogi")]
        public abstract void Fog([Flow(FlowDirection.In)] FogParameter pname, [Flow(FlowDirection.In)] int param);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glFogiv")]
        public abstract unsafe void Fog([Flow(FlowDirection.In)] FogParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glFogiv")]
        public abstract void Fog([Flow(FlowDirection.In)] FogParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glFrontFace")]
        public abstract void FrontFace([Flow(FlowDirection.In)] FrontFaceDirection mode);

        [NativeApi(EntryPoint = "glGetBooleanv")]
        public abstract unsafe void GetBoolean([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetBooleanv")]
        public abstract void GetBoolean([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out bool data);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetClipPlane")]
        public abstract unsafe void GetClipPlane([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.Out)] double* equation);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetClipPlane")]
        public abstract void GetClipPlane([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> equation);

        [NativeApi(EntryPoint = "glGetDoublev")]
        public abstract unsafe void GetDouble([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* data);

        [NativeApi(EntryPoint = "glGetDoublev")]
        public abstract void GetDouble([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double data);

        [NativeApi(EntryPoint = "glGetFloatv")]
        public abstract unsafe void GetFloat([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetFloatv")]
        public abstract void GetFloat([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetIntegerv")]
        public abstract unsafe void GetInteger([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetIntegerv")]
        public abstract void GetInteger([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int data);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetLightfv")]
        public abstract unsafe void GetLight([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetLightfv")]
        public abstract void GetLight([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetLightiv")]
        public abstract unsafe void GetLight([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetLightiv")]
        public abstract void GetLight([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetMapdv")]
        public abstract unsafe void GetMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] GetMapQuery query, [Count(Computed = "target, query"), Flow(FlowDirection.Out)] double* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetMapdv")]
        public abstract void GetMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] GetMapQuery query, [Count(Computed = "target, query"), Flow(FlowDirection.Out)] out double v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetMapfv")]
        public abstract unsafe void GetMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] GetMapQuery query, [Count(Computed = "target, query"), Flow(FlowDirection.Out)] float* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetMapfv")]
        public abstract void GetMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] GetMapQuery query, [Count(Computed = "target, query"), Flow(FlowDirection.Out)] out float v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetMapiv")]
        public abstract unsafe void GetMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] GetMapQuery query, [Count(Computed = "target, query"), Flow(FlowDirection.Out)] int* v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetMapiv")]
        public abstract void GetMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] GetMapQuery query, [Count(Computed = "target, query"), Flow(FlowDirection.Out)] out int v);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetMaterialfv")]
        public abstract unsafe void GetMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetMaterialfv")]
        public abstract void GetMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetMaterialiv")]
        public abstract unsafe void GetMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetMaterialiv")]
        public abstract void GetMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetPixelMapfv")]
        public abstract unsafe void GetPixelMap([Flow(FlowDirection.In)] PixelMap map, [Count(Computed = "map"), Flow(FlowDirection.Out)] float* values);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetPixelMapfv")]
        public abstract void GetPixelMap([Flow(FlowDirection.In)] PixelMap map, [Count(Computed = "map"), Flow(FlowDirection.Out)] out float values);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetPixelMapuiv")]
        public abstract unsafe void GetPixelMap([Flow(FlowDirection.In)] PixelMap map, [Count(Computed = "map"), Flow(FlowDirection.Out)] uint* values);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetPixelMapuiv")]
        public abstract void GetPixelMap([Flow(FlowDirection.In)] PixelMap map, [Count(Computed = "map"), Flow(FlowDirection.Out)] out uint values);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetPixelMapusv")]
        public abstract unsafe void GetPixelMap([Flow(FlowDirection.In)] PixelMap map, [Count(Computed = "map"), Flow(FlowDirection.Out)] ushort* values);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetPixelMapusv")]
        public abstract void GetPixelMap([Flow(FlowDirection.In)] PixelMap map, [Count(Computed = "map"), Flow(FlowDirection.Out)] out ushort values);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetPolygonStipple")]
        public abstract void GetPolygonStipple([Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.Constant, 0)] out string mask);

        [NativeApi(EntryPoint = "glGetString")]
        public abstract string GetString([Flow(FlowDirection.In)] StringName name);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetTexEnvfv")]
        public abstract unsafe void GetTexEnv([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetTexEnvfv")]
        public abstract void GetTexEnv([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetTexEnviv")]
        public abstract unsafe void GetTexEnv([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetTexEnviv")]
        public abstract void GetTexEnv([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetTexGendv")]
        public abstract unsafe void GetTexGen([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetTexGendv")]
        public abstract void GetTexGen([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetTexGenfv")]
        public abstract unsafe void GetTexGen([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetTexGenfv")]
        public abstract void GetTexGen([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetTexGeniv")]
        public abstract unsafe void GetTexGen([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glGetTexGeniv")]
        public abstract void GetTexGen([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexImage")]
        public abstract unsafe void GetTexImage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTexImage")]
        public abstract void GetTexImage<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTexLevelParameterfv")]
        public abstract unsafe void GetTexLevelParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterfv")]
        public abstract void GetTexLevelParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameteriv")]
        public abstract unsafe void GetTexLevelParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameteriv")]
        public abstract void GetTexLevelParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterfv")]
        public abstract unsafe void GetTexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTexParameterfv")]
        public abstract void GetTexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetTexParameteriv")]
        public abstract unsafe void GetTexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameteriv")]
        public abstract void GetTexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glHint")]
        public abstract void Hint([Flow(FlowDirection.In)] HintTarget target, [Flow(FlowDirection.In)] HintMode mode);

        [NativeApi(EntryPoint = "glIsEnabled")]
        public abstract bool IsEnabled([Flow(FlowDirection.In)] EnableCap cap);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLightf")]
        public abstract void Light([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Flow(FlowDirection.In)] float param);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLightfv")]
        public abstract unsafe void Light([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLightfv")]
        public abstract void Light([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLighti")]
        public abstract void Light([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Flow(FlowDirection.In)] int param);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLightiv")]
        public abstract unsafe void Light([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLightiv")]
        public abstract void Light([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLightModelf")]
        public abstract void LightModel([Flow(FlowDirection.In)] LightModelParameter pname, [Flow(FlowDirection.In)] float param);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLightModelfv")]
        public abstract unsafe void LightModel([Flow(FlowDirection.In)] LightModelParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLightModelfv")]
        public abstract void LightModel([Flow(FlowDirection.In)] LightModelParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLightModeli")]
        public abstract void LightModel([Flow(FlowDirection.In)] LightModelParameter pname, [Flow(FlowDirection.In)] int param);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLightModeliv")]
        public abstract unsafe void LightModel([Flow(FlowDirection.In)] LightModelParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glLightModeliv")]
        public abstract void LightModel([Flow(FlowDirection.In)] LightModelParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glLogicOp")]
        public abstract void LogicOp([Flow(FlowDirection.In)] LogicOp opcode);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMap1d")]
        public abstract unsafe void Map1([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int stride, [Flow(FlowDirection.In)] int order, [Count(Computed = "target, stride, order"), Flow(FlowDirection.In)] double* points);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMap1d")]
        public abstract void Map1([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int stride, [Flow(FlowDirection.In)] int order, [Count(Computed = "target, stride, order"), Flow(FlowDirection.In)] ref double points);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMap1f")]
        public abstract unsafe void Map1([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int stride, [Flow(FlowDirection.In)] int order, [Count(Computed = "target, stride, order"), Flow(FlowDirection.In)] float* points);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMap1f")]
        public abstract void Map1([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int stride, [Flow(FlowDirection.In)] int order, [Count(Computed = "target, stride, order"), Flow(FlowDirection.In)] ref float points);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMap2d")]
        public abstract unsafe void Map2([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] double v1, [Flow(FlowDirection.In)] double v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Count(Computed = "target, ustride, uorder, vstride, vorder"), Flow(FlowDirection.In)] double* points);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMap2d")]
        public abstract void Map2([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] double v1, [Flow(FlowDirection.In)] double v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Count(Computed = "target, ustride, uorder, vstride, vorder"), Flow(FlowDirection.In)] ref double points);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMap2f")]
        public abstract unsafe void Map2([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Count(Computed = "target, ustride, uorder, vstride, vorder"), Flow(FlowDirection.In)] float* points);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMap2f")]
        public abstract void Map2([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Count(Computed = "target, ustride, uorder, vstride, vorder"), Flow(FlowDirection.In)] ref float points);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMaterialf")]
        public abstract void Material([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Flow(FlowDirection.In)] float param);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMaterialfv")]
        public abstract unsafe void Material([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMaterialfv")]
        public abstract void Material([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMateriali")]
        public abstract void Material([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Flow(FlowDirection.In)] int param);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMaterialiv")]
        public abstract unsafe void Material([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMaterialiv")]
        public abstract void Material([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glMatrixMode")]
        public abstract void MatrixMode([Flow(FlowDirection.In)] MatrixMode mode);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glNewList")]
        public abstract void NewList([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListMode mode);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glPixelMapfv")]
        public abstract unsafe void PixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint mapsize, [Count(Parameter = "mapsize"), Flow(FlowDirection.In)] float* values);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glPixelMapfv")]
        public abstract void PixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint mapsize, [Count(Parameter = "mapsize"), Flow(FlowDirection.In)] Span<float> values);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glPixelMapuiv")]
        public abstract unsafe void PixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint mapsize, [Count(Parameter = "mapsize"), Flow(FlowDirection.In)] uint* values);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glPixelMapuiv")]
        public abstract void PixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint mapsize, [Count(Parameter = "mapsize"), Flow(FlowDirection.In)] Span<uint> values);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glPixelMapusv")]
        public abstract unsafe void PixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint mapsize, [Count(Parameter = "mapsize"), Flow(FlowDirection.In)] ushort* values);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glPixelMapusv")]
        public abstract void PixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint mapsize, [Count(Parameter = "mapsize"), Flow(FlowDirection.In)] Span<ushort> values);

        [NativeApi(EntryPoint = "glPixelStoref")]
        public abstract void PixelStore([Flow(FlowDirection.In)] PixelStoreParameter pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glPixelStorei")]
        public abstract void PixelStore([Flow(FlowDirection.In)] PixelStoreParameter pname, [Flow(FlowDirection.In)] int param);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glPixelTransferf")]
        public abstract void PixelTransfer([Flow(FlowDirection.In)] PixelTransferParameter pname, [Flow(FlowDirection.In)] float param);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glPixelTransferi")]
        public abstract void PixelTransfer([Flow(FlowDirection.In)] PixelTransferParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPolygonMode")]
        public abstract void PolygonMode([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] PolygonMode mode);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glPolygonStipple")]
        public abstract void PolygonStipple([Flow(FlowDirection.In)] string mask);

        [NativeApi(EntryPoint = "glReadBuffer")]
        public abstract void ReadBuffer([Flow(FlowDirection.In)] ReadBufferMode src);

        [NativeApi(EntryPoint = "glReadPixels")]
        public abstract unsafe void ReadPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glReadPixels")]
        public abstract void ReadPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glRenderMode")]
        public abstract int RenderMode([Flow(FlowDirection.In)] RenderingMode mode);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glShadeModel")]
        public abstract void ShadeModel([Flow(FlowDirection.In)] ShadingModel mode);

        [NativeApi(EntryPoint = "glStencilFunc")]
        public abstract void StencilFunc([Flow(FlowDirection.In)] StencilFunction func, [Flow(FlowDirection.In)] int @ref, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilOp")]
        public abstract void StencilOp([Flow(FlowDirection.In)] StencilOp fail, [Flow(FlowDirection.In)] StencilOp zfail, [Flow(FlowDirection.In)] StencilOp zpass);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexEnvf")]
        public abstract void TexEnv([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Flow(FlowDirection.In)] float param);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexEnvfv")]
        public abstract unsafe void TexEnv([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexEnvfv")]
        public abstract void TexEnv([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexEnvi")]
        public abstract void TexEnv([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Flow(FlowDirection.In)] int param);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexEnviv")]
        public abstract unsafe void TexEnv([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexEnviv")]
        public abstract void TexEnv([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexGendv")]
        public abstract unsafe void TexGen([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] double* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexGendv")]
        public abstract void TexGen([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref double @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexGenf")]
        public abstract void TexGen([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Flow(FlowDirection.In)] float param);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexGenfv")]
        public abstract unsafe void TexGen([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexGenfv")]
        public abstract void TexGen([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexGeni")]
        public abstract void TexGen([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Flow(FlowDirection.In)] int param);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexGeniv")]
        public abstract unsafe void TexGen([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexGeniv")]
        public abstract void TexGen([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [System.Obsolete("Deprecated in version 1.0")]
        [NativeApi(EntryPoint = "glTexGend")]
        public abstract void TexGend([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Flow(FlowDirection.In)] double param);

        [NativeApi(EntryPoint = "glTexImage1D")]
        public abstract unsafe void TexImage1D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage1D")]
        public abstract void TexImage1D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage2D")]
        public abstract unsafe void TexImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage2D")]
        public abstract void TexImage2D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexParameterf")]
        public abstract void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glTexParameterfv")]
        public abstract unsafe void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glTexParameterfv")]
        public abstract void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [NativeApi(EntryPoint = "glTexParameteri")]
        public abstract void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexParameteriv")]
        public abstract unsafe void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameteriv")]
        public abstract void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        public unsafe void MultiDrawArraysIndirectCount([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            MultiDrawArraysIndirectCount(mode, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        public unsafe void MultiDrawArraysIndirectCount<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // IntPtrOverloader
            MultiDrawArraysIndirectCount(mode, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        public unsafe void MultiDrawElementsIndirectCount([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            MultiDrawElementsIndirectCount(mode, type, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        public unsafe void MultiDrawElementsIndirectCount<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // IntPtrOverloader
            MultiDrawElementsIndirectCount(mode, type, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        public unsafe void MultiDrawArraysIndirectCount([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            MultiDrawArraysIndirectCount(mode, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        public unsafe void MultiDrawArraysIndirectCount<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // IntPtrOverloader
            MultiDrawArraysIndirectCount(mode, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        public unsafe void MultiDrawElementsIndirectCount([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            MultiDrawElementsIndirectCount(mode, type, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        public unsafe void MultiDrawElementsIndirectCount<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // IntPtrOverloader
            MultiDrawElementsIndirectCount(mode, type, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        public unsafe void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, data);
        }

        public unsafe void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, data);
        }

        public unsafe void CopyNamedBufferSubData([Flow(FlowDirection.In)] uint readBuffer, [Flow(FlowDirection.In)] uint writeBuffer, [Flow(FlowDirection.In)] int readOffset, [Flow(FlowDirection.In)] int writeOffset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            CopyNamedBufferSubData(readBuffer, writeBuffer, new IntPtr(readOffset), new IntPtr(writeOffset), new UIntPtr(size));
        }

        public unsafe uint CreateBuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateBuffers(n, &ret);
            return ret;
        }

        public unsafe uint CreateFramebuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateFramebuffers(n, &ret);
            return ret;
        }

        public unsafe uint CreateProgramPipeline()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateProgramPipelines(n, &ret);
            return ret;
        }

        public unsafe uint CreateRenderbuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateRenderbuffers(n, &ret);
            return ret;
        }

        public unsafe uint CreateSampler()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateSamplers(n, &ret);
            return ret;
        }

        public unsafe uint CreateTransformFeedback()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateTransformFeedbacks(n, &ret);
            return ret;
        }

        public unsafe uint CreateVertexArray()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateVertexArrays(n, &ret);
            return ret;
        }

        public unsafe void FlushMappedNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length)
        {
            // IntPtrOverloader
            FlushMappedNamedBufferRange(buffer, new IntPtr(offset), new UIntPtr(length));
        }

        public unsafe void GetNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] void* data)
        {
            // IntPtrOverloader
            GetNamedBufferSubData(buffer, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void GetNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            GetNamedBufferSubData(buffer, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe byte GetnPolygonStipple()
        {
            const uint bufSize = 1;
            // ReturnTypeOverloader
            byte ret = default;
            GetnPolygonStipple(bufSize, &ret);
            return ret;
        }

        public unsafe void GetQueryBufferObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            GetQueryBufferObject(id, buffer, pname, new IntPtr(offset));
        }

        public unsafe void* MapNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] uint access)
        {
            // IntPtrOverloader
            return MapNamedBufferRange(buffer, new IntPtr(offset), new UIntPtr(length), access);
        }

        public unsafe void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] GLEnum usage)
        {
            // IntPtrOverloader
            NamedBufferData(buffer, new UIntPtr(size), data, usage);
        }

        public unsafe void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] GLEnum usage) where T0 : unmanaged
        {
            // IntPtrOverloader
            NamedBufferData(buffer, new UIntPtr(size), data, usage);
        }

        public unsafe void NamedBufferStorage([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags)
        {
            // IntPtrOverloader
            NamedBufferStorage(buffer, new UIntPtr(size), data, flags);
        }

        public unsafe void NamedBufferStorage<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged
        {
            // IntPtrOverloader
            NamedBufferStorage(buffer, new UIntPtr(size), data, flags);
        }

        public unsafe void NamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Computed = "size"), Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            NamedBufferSubData(buffer, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void NamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Computed = "size"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged
        {
            // IntPtrOverloader
            NamedBufferSubData(buffer, new IntPtr(offset), new UIntPtr(size), ref data);
        }

        public unsafe void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TextureBufferRange(texture, internalformat, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        public unsafe void TransformFeedbackBufferRange([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TransformFeedbackBufferRange(xfb, index, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        public unsafe void VertexArrayVertexBuffer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            VertexArrayVertexBuffer(vaobj, bindingindex, buffer, new IntPtr(offset), stride);
        }

        public unsafe void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, data);
        }

        public unsafe void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, data);
        }

        public unsafe void GetQueryBufferObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            GetQueryBufferObject(id, buffer, pname, new IntPtr(offset));
        }

        public unsafe void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage)
        {
            // IntPtrOverloader
            NamedBufferData(buffer, new UIntPtr(size), data, usage);
        }

        public unsafe void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage) where T0 : unmanaged
        {
            // IntPtrOverloader
            NamedBufferData(buffer, new UIntPtr(size), data, usage);
        }

        public unsafe void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TextureBufferRange(texture, internalformat, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        public unsafe void BufferStorage([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags)
        {
            // IntPtrOverloader
            BufferStorage(target, new UIntPtr(size), data, flags);
        }

        public unsafe void BufferStorage<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged
        {
            // IntPtrOverloader
            BufferStorage(target, new UIntPtr(size), data, flags);
        }

        public unsafe void BufferStorage([Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags)
        {
            // IntPtrOverloader
            BufferStorage(target, new UIntPtr(size), data, flags);
        }

        public unsafe void BufferStorage<T0>([Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged
        {
            // IntPtrOverloader
            BufferStorage(target, new UIntPtr(size), data, flags);
        }

        public unsafe void BindVertexBuffer([Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            BindVertexBuffer(bindingindex, buffer, new IntPtr(offset), stride);
        }

        public unsafe void ClearBufferSubData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            ClearBufferSubData(target, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, data);
        }

        public unsafe void ClearBufferSubData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged
        {
            // IntPtrOverloader
            ClearBufferSubData(target, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, ref data);
        }

        public unsafe void DispatchComputeIndirect([Flow(FlowDirection.In)] int indirect)
        {
            // IntPtrOverloader
            DispatchComputeIndirect(new IntPtr(indirect));
        }

        [System.Obsolete("Deprecated in version 4.3")]
        public unsafe void* GetPointer([Flow(FlowDirection.In)] GLEnum pname)
        {
            // ReturnTypeOverloader
            void* ret = default;
            GetPointer(pname, &ret);
            return ret;
        }

        public unsafe void InvalidateBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length)
        {
            // IntPtrOverloader
            InvalidateBufferSubData(buffer, new IntPtr(offset), new UIntPtr(length));
        }

        public unsafe void TexBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TexBufferRange(target, internalformat, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        public unsafe void ClearBufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            ClearBufferSubData(target, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, data);
        }

        public unsafe void ClearBufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged
        {
            // IntPtrOverloader
            ClearBufferSubData(target, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, ref data);
        }

        [System.Obsolete("Deprecated in version 4.3")]
        public unsafe void* GetPointer([Flow(FlowDirection.In)] GetPointervPName pname)
        {
            // ReturnTypeOverloader
            void* ret = default;
            GetPointer(pname, &ret);
            return ret;
        }

        public unsafe void TexBufferRange([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TexBufferRange(target, internalformat, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        public unsafe uint CreateShaderProgram([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] stringsSa)
        {
            // StringArrayOverloader
            var strings = (byte**) SilkMarshal.MarshalStringArrayToPtr(stringsSa);
            var ret = CreateShaderProgram(type, count, strings);
            SilkMarshal.CopyPtrToStringArray((IntPtr) strings, stringsSa);
            return ret;
        }

        public unsafe void DeleteProgramPipeline([Count(Parameter = "n"), Flow(FlowDirection.In)] uint pipelines)
        {
            // ArrayParameterOverloader
            DeleteProgramPipelines(1, &pipelines);
        }

        public unsafe uint GenProgramPipeline()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenProgramPipelines(n, &ret);
            return ret;
        }

        public unsafe uint CreateShaderProgram([Flow(FlowDirection.In)] ShaderType type, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] stringsSa)
        {
            // StringArrayOverloader
            var strings = (byte**) SilkMarshal.MarshalStringArrayToPtr(stringsSa);
            var ret = CreateShaderProgram(type, count, strings);
            SilkMarshal.CopyPtrToStringArray((IntPtr) strings, stringsSa);
            return ret;
        }

        public unsafe void DeleteTransformFeedback([Count(Parameter = "n"), Flow(FlowDirection.In)] uint ids)
        {
            // ArrayParameterOverloader
            DeleteTransformFeedbacks(1, &ids);
        }

        public unsafe uint GenTransformFeedback()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenTransformFeedbacks(n, &ret);
            return ret;
        }

        public unsafe void DeleteSampler([Count(Parameter = "count"), Flow(FlowDirection.In)] uint samplers)
        {
            // ArrayParameterOverloader
            DeleteSamplers(1, &samplers);
        }

        public unsafe uint GenSampler()
        {
            const uint count = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenSamplers(count, &ret);
            return ret;
        }

        public unsafe GLEnum ClientWaitSync([Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] ulong timeout)
        {
            // IntPtrOverloader
            return ClientWaitSync(new IntPtr(sync), flags, timeout);
        }

        public unsafe void DeleteSync([Flow(FlowDirection.In)] int sync)
        {
            // IntPtrOverloader
            DeleteSync(new IntPtr(sync));
        }

        public unsafe long GetInteger64([Flow(FlowDirection.In)] GLEnum pname)
        {
            // ReturnTypeOverloader
            long ret = default;
            GetInteger64(pname, &ret);
            return ret;
        }

        public unsafe void GetSync([Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values)
        {
            // IntPtrOverloader
            GetSync(new IntPtr(sync), pname, count, length, values);
        }

        public unsafe void GetSync([Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // IntPtrOverloader
            GetSync(new IntPtr(sync), pname, count, out length, values);
        }

        public unsafe bool IsSync([Flow(FlowDirection.In)] int sync)
        {
            // IntPtrOverloader
            return IsSync(new IntPtr(sync));
        }

        public unsafe void WaitSync([Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] ulong timeout)
        {
            // IntPtrOverloader
            WaitSync(new IntPtr(sync), flags, timeout);
        }

        public unsafe long GetInteger64([Flow(FlowDirection.In)] GetPName pname)
        {
            // ReturnTypeOverloader
            long ret = default;
            GetInteger64(pname, &ret);
            return ret;
        }

        public unsafe void GetSync([Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values)
        {
            // IntPtrOverloader
            GetSync(new IntPtr(sync), pname, count, length, values);
        }

        public unsafe void GetSync([Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // IntPtrOverloader
            GetSync(new IntPtr(sync), pname, count, out length, values);
        }

        public unsafe void BindBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            BindBufferRange(target, index, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        public unsafe void CopyBufferSubData([Flow(FlowDirection.In)] GLEnum readTarget, [Flow(FlowDirection.In)] GLEnum writeTarget, [Flow(FlowDirection.In)] int readOffset, [Flow(FlowDirection.In)] int writeOffset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            CopyBufferSubData(readTarget, writeTarget, new IntPtr(readOffset), new IntPtr(writeOffset), new UIntPtr(size));
        }

        public unsafe void GetUniformIndices([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(FlowDirection.In)] string[] uniformNamesSa, [Count(Computed = "uniformCount"), Flow(FlowDirection.Out)] uint* uniformIndices)
        {
            // StringArrayOverloader
            var uniformNames = (byte**) SilkMarshal.MarshalStringArrayToPtr(uniformNamesSa);
            GetUniformIndices(program, uniformCount, uniformNames, uniformIndices);
            SilkMarshal.CopyPtrToStringArray((IntPtr) uniformNames, uniformNamesSa);
        }

        public unsafe void BindBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            BindBufferRange(target, index, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        public unsafe void CopyBufferSubData([Flow(FlowDirection.In)] CopyBufferSubDataTarget readTarget, [Flow(FlowDirection.In)] CopyBufferSubDataTarget writeTarget, [Flow(FlowDirection.In)] int readOffset, [Flow(FlowDirection.In)] int writeOffset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            CopyBufferSubData(readTarget, writeTarget, new IntPtr(readOffset), new IntPtr(writeOffset), new UIntPtr(size));
        }

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

        public unsafe void DeleteVertexArray([Count(Parameter = "n"), Flow(FlowDirection.In)] uint arrays)
        {
            // ArrayParameterOverloader
            DeleteVertexArrays(1, &arrays);
        }

        public unsafe void FlushMappedBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length)
        {
            // IntPtrOverloader
            FlushMappedBufferRange(target, new IntPtr(offset), new UIntPtr(length));
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

        public unsafe uint GenVertexArray()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenVertexArrays(n, &ret);
            return ret;
        }

        public unsafe void* MapBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] uint access)
        {
            // IntPtrOverloader
            return MapBufferRange(target, new IntPtr(offset), new UIntPtr(length), access);
        }

        public unsafe void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] varyingsSa, [Flow(FlowDirection.In)] GLEnum bufferMode)
        {
            // StringArrayOverloader
            var varyings = (byte**) SilkMarshal.MarshalStringArrayToPtr(varyingsSa);
            TransformFeedbackVaryings(program, count, varyings, bufferMode);
            SilkMarshal.CopyPtrToStringArray((IntPtr) varyings, varyingsSa);
        }

        public unsafe void FlushMappedBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length)
        {
            // IntPtrOverloader
            FlushMappedBufferRange(target, new IntPtr(offset), new UIntPtr(length));
        }

        public unsafe void* MapBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] uint access)
        {
            // IntPtrOverloader
            return MapBufferRange(target, new IntPtr(offset), new UIntPtr(length), access);
        }

        public unsafe void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] varyingsSa, [Flow(FlowDirection.In)] TransformFeedbackBufferMode bufferMode)
        {
            // StringArrayOverloader
            var varyings = (byte**) SilkMarshal.MarshalStringArrayToPtr(varyingsSa);
            TransformFeedbackVaryings(program, count, varyings, bufferMode);
            SilkMarshal.CopyPtrToStringArray((IntPtr) varyings, varyingsSa);
        }

        public unsafe void ShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] @stringSa, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* length)
        {
            // StringArrayOverloader
            var @string = (byte**) SilkMarshal.MarshalStringArrayToPtr(@stringSa);
            ShaderSource(shader, count, @string, length);
            SilkMarshal.CopyPtrToStringArray((IntPtr) @string, @stringSa);
        }

        public unsafe void ShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] @stringSa, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> length)
        {
            // StringArrayOverloader
            var @string = (byte**) SilkMarshal.MarshalStringArrayToPtr(@stringSa);
            ShaderSource(shader, count, @string, length);
            SilkMarshal.CopyPtrToStringArray((IntPtr) @string, @stringSa);
        }

        public unsafe void BufferData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] GLEnum usage)
        {
            // IntPtrOverloader
            BufferData(target, new UIntPtr(size), data, usage);
        }

        public unsafe void BufferData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] GLEnum usage) where T0 : unmanaged
        {
            // IntPtrOverloader
            BufferData(target, new UIntPtr(size), data, usage);
        }

        public unsafe void BufferSubData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            BufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void BufferSubData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            BufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void DeleteBuffer([Count(Parameter = "n"), Flow(FlowDirection.In)] uint buffers)
        {
            // ArrayParameterOverloader
            DeleteBuffers(1, &buffers);
        }

        public unsafe void DeleteQuery([Count(Parameter = "n"), Flow(FlowDirection.In)] uint ids)
        {
            // ArrayParameterOverloader
            DeleteQueries(1, &ids);
        }

        public unsafe uint GenBuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenBuffers(n, &ret);
            return ret;
        }

        public unsafe uint GenQuery()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenQueries(n, &ret);
            return ret;
        }

        public unsafe void GetBufferSubData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] void* data)
        {
            // IntPtrOverloader
            GetBufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void GetBufferSubData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            GetBufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void BufferData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] BufferUsageARB usage)
        {
            // IntPtrOverloader
            BufferData(target, new UIntPtr(size), data, usage);
        }

        public unsafe void BufferData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] BufferUsageARB usage) where T0 : unmanaged
        {
            // IntPtrOverloader
            BufferData(target, new UIntPtr(size), data, usage);
        }

        public unsafe void BufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            BufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void BufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            BufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void GetBufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] void* data)
        {
            // IntPtrOverloader
            GetBufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void GetBufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            GetBufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void DeleteTexture([Count(Parameter = "n"), Flow(FlowDirection.In)] uint textures)
        {
            // ArrayParameterOverloader
            DeleteTextures(1, &textures);
        }

        public unsafe uint GenTexture()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenTextures(n, &ret);
            return ret;
        }

        public unsafe bool GetBoolean([Flow(FlowDirection.In)] GLEnum pname)
        {
            // ReturnTypeOverloader
            bool ret = default;
            GetBoolean(pname, &ret);
            return ret;
        }

        public unsafe double GetDouble([Flow(FlowDirection.In)] GLEnum pname)
        {
            // ReturnTypeOverloader
            double ret = default;
            GetDouble(pname, &ret);
            return ret;
        }

        public unsafe float GetFloat([Flow(FlowDirection.In)] GLEnum pname)
        {
            // ReturnTypeOverloader
            float ret = default;
            GetFloat(pname, &ret);
            return ret;
        }

        public unsafe int GetInteger([Flow(FlowDirection.In)] GLEnum pname)
        {
            // ReturnTypeOverloader
            int ret = default;
            GetInteger(pname, &ret);
            return ret;
        }

        [System.Obsolete("Deprecated in version 1.0")]
        public unsafe float GetPixelMap([Flow(FlowDirection.In)] GLEnum map)
        {
            // ReturnTypeOverloader
            float ret = default;
            GetPixelMap(map, &ret);
            return ret;
        }

        [System.Obsolete("Deprecated in version 1.0")]
        public unsafe byte GetPolygonStipple()
        {
            // ReturnTypeOverloader
            byte ret = default;
            GetPolygonStipple(&ret);
            return ret;
        }

        public unsafe bool GetBoolean([Flow(FlowDirection.In)] GetPName pname)
        {
            // ReturnTypeOverloader
            bool ret = default;
            GetBoolean(pname, &ret);
            return ret;
        }

        public unsafe double GetDouble([Flow(FlowDirection.In)] GetPName pname)
        {
            // ReturnTypeOverloader
            double ret = default;
            GetDouble(pname, &ret);
            return ret;
        }

        public unsafe float GetFloat([Flow(FlowDirection.In)] GetPName pname)
        {
            // ReturnTypeOverloader
            float ret = default;
            GetFloat(pname, &ret);
            return ret;
        }

        public unsafe int GetInteger([Flow(FlowDirection.In)] GetPName pname)
        {
            // ReturnTypeOverloader
            int ret = default;
            GetInteger(pname, &ret);
            return ret;
        }

        [System.Obsolete("Deprecated in version 1.0")]
        public unsafe float GetPixelMap([Flow(FlowDirection.In)] PixelMap map)
        {
            // ReturnTypeOverloader
            float ret = default;
            GetPixelMap(map, &ret);
            return ret;
        }

        private SearchPathContainer _searchPaths;
        public override SearchPathContainer SearchPaths => _searchPaths ??= new OpenGLLibraryNameContainer();

        public GL(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

