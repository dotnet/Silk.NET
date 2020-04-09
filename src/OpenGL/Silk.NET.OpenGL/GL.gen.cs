// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Loader;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL
{
    public abstract unsafe partial class GL : NativeAPI
    {

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendFunc")]
        public abstract void BlendFunc([Flow(FlowDirection.In)] GLEnum sfactor, [Flow(FlowDirection.In)] GLEnum dfactor);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClear")]
        public abstract void Clear([Flow(FlowDirection.In)] uint mask);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearColor")]
        public abstract void ClearColor([Flow(FlowDirection.In)] float red, [Flow(FlowDirection.In)] float green, [Flow(FlowDirection.In)] float blue, [Flow(FlowDirection.In)] float alpha);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearDepth")]
        public abstract void ClearDepth([Flow(FlowDirection.In)] double depth);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearStencil")]
        public abstract void ClearStencil([Flow(FlowDirection.In)] int s);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorMask")]
        public abstract void ColorMask([Flow(FlowDirection.In)] bool red, [Flow(FlowDirection.In)] bool green, [Flow(FlowDirection.In)] bool blue, [Flow(FlowDirection.In)] bool alpha);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCullFace")]
        public abstract void CullFace([Flow(FlowDirection.In)] GLEnum mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDepthFunc")]
        public abstract void DepthFunc([Flow(FlowDirection.In)] GLEnum func);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDepthMask")]
        public abstract void DepthMask([Flow(FlowDirection.In)] bool flag);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDepthRange")]
        public abstract void DepthRange([Flow(FlowDirection.In)] double n, [Flow(FlowDirection.In)] double f);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDisable")]
        public abstract void Disable([Flow(FlowDirection.In)] GLEnum cap);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawBuffer")]
        public abstract void DrawBuffer([Flow(FlowDirection.In)] GLEnum buf);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEnable")]
        public abstract void Enable([Flow(FlowDirection.In)] GLEnum cap);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFinish")]
        public abstract void Finish();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFlush")]
        public abstract void Flush();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFrontFace")]
        public abstract void FrontFace([Flow(FlowDirection.In)] GLEnum mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBooleanv")]
        public abstract unsafe void GetBoolean([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] bool* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBooleanv")]
        public abstract void GetBoolean([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out bool data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetDoublev")]
        public abstract unsafe void GetDouble([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetDoublev")]
        public abstract void GetDouble([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetError")]
        public abstract GLEnum GetError();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFloatv")]
        public abstract unsafe void GetFloat([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFloatv")]
        public abstract void GetFloat([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetIntegerv")]
        public abstract unsafe void GetInteger([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetIntegerv")]
        public abstract void GetInteger([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetString")]
        public abstract unsafe byte* GetString([Flow(FlowDirection.In)] GLEnum name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexImage")]
        public abstract unsafe void GetTexImage([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexImage")]
        public abstract void GetTexImage<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexLevelParameterfv")]
        public abstract unsafe void GetTexLevelParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexLevelParameterfv")]
        public abstract void GetTexLevelParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexLevelParameteriv")]
        public abstract unsafe void GetTexLevelParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexLevelParameteriv")]
        public abstract void GetTexLevelParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexParameterfv")]
        public abstract unsafe void GetTexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexParameterfv")]
        public abstract void GetTexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexParameteriv")]
        public abstract unsafe void GetTexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexParameteriv")]
        public abstract void GetTexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glHint")]
        public abstract void Hint([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsEnabled")]
        public abstract bool IsEnabled([Flow(FlowDirection.In)] GLEnum cap);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glLineWidth")]
        public abstract void LineWidth([Flow(FlowDirection.In)] float width);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glLogicOp")]
        public abstract void LogicOp([Flow(FlowDirection.In)] GLEnum opcode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPixelStoref")]
        public abstract void PixelStore([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPixelStorei")]
        public abstract void PixelStore([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPointSize")]
        public abstract void PointSize([Flow(FlowDirection.In)] float size);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPolygonMode")]
        public abstract void PolygonMode([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] GLEnum mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glReadBuffer")]
        public abstract void ReadBuffer([Flow(FlowDirection.In)] GLEnum src);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glReadPixels")]
        public abstract unsafe void ReadPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.Out)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glReadPixels")]
        public abstract void ReadPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glScissor")]
        public abstract void Scissor([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glStencilFunc")]
        public abstract void StencilFunc([Flow(FlowDirection.In)] GLEnum func, [Flow(FlowDirection.In)] int @ref, [Flow(FlowDirection.In)] uint mask);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glStencilMask")]
        public abstract void StencilMask([Flow(FlowDirection.In)] uint mask);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glStencilOp")]
        public abstract void StencilOp([Flow(FlowDirection.In)] GLEnum fail, [Flow(FlowDirection.In)] GLEnum zfail, [Flow(FlowDirection.In)] GLEnum zpass);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexImage1D")]
        public abstract unsafe void TexImage1D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexImage1D")]
        public abstract void TexImage1D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexImage2D")]
        public abstract unsafe void TexImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexImage2D")]
        public abstract void TexImage2D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexParameterf")]
        public abstract void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexParameterfv")]
        public abstract unsafe void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexParameterfv")]
        public abstract void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexParameteri")]
        public abstract void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexParameteriv")]
        public abstract unsafe void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexParameteriv")]
        public abstract void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glViewport")]
        public abstract void Viewport([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendFunc")]
        public abstract void BlendFunc([Flow(FlowDirection.In)] BlendingFactor sfactor, [Flow(FlowDirection.In)] BlendingFactor dfactor);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCullFace")]
        public abstract void CullFace([Flow(FlowDirection.In)] CullFaceMode mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDepthFunc")]
        public abstract void DepthFunc([Flow(FlowDirection.In)] DepthFunction func);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDisable")]
        public abstract void Disable([Flow(FlowDirection.In)] EnableCap cap);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawBuffer")]
        public abstract void DrawBuffer([Flow(FlowDirection.In)] DrawBufferMode buf);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEnable")]
        public abstract void Enable([Flow(FlowDirection.In)] EnableCap cap);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFrontFace")]
        public abstract void FrontFace([Flow(FlowDirection.In)] FrontFaceDirection mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBooleanv")]
        public abstract unsafe void GetBoolean([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] bool* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBooleanv")]
        public abstract void GetBoolean([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out bool data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetDoublev")]
        public abstract unsafe void GetDouble([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetDoublev")]
        public abstract void GetDouble([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFloatv")]
        public abstract unsafe void GetFloat([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFloatv")]
        public abstract void GetFloat([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetIntegerv")]
        public abstract unsafe void GetInteger([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetIntegerv")]
        public abstract void GetInteger([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetString")]
        public abstract string GetString([Flow(FlowDirection.In)] StringName name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexImage")]
        public abstract unsafe void GetTexImage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexImage")]
        public abstract void GetTexImage<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexLevelParameterfv")]
        public abstract unsafe void GetTexLevelParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexLevelParameterfv")]
        public abstract void GetTexLevelParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexLevelParameteriv")]
        public abstract unsafe void GetTexLevelParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexLevelParameteriv")]
        public abstract void GetTexLevelParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexParameterfv")]
        public abstract unsafe void GetTexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexParameterfv")]
        public abstract void GetTexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexParameteriv")]
        public abstract unsafe void GetTexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexParameteriv")]
        public abstract void GetTexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glHint")]
        public abstract void Hint([Flow(FlowDirection.In)] HintTarget target, [Flow(FlowDirection.In)] HintMode mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsEnabled")]
        public abstract bool IsEnabled([Flow(FlowDirection.In)] EnableCap cap);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glLogicOp")]
        public abstract void LogicOp([Flow(FlowDirection.In)] LogicOp opcode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPixelStoref")]
        public abstract void PixelStore([Flow(FlowDirection.In)] PixelStoreParameter pname, [Flow(FlowDirection.In)] float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPixelStorei")]
        public abstract void PixelStore([Flow(FlowDirection.In)] PixelStoreParameter pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPolygonMode")]
        public abstract void PolygonMode([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] PolygonMode mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glReadBuffer")]
        public abstract void ReadBuffer([Flow(FlowDirection.In)] ReadBufferMode src);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glReadPixels")]
        public abstract unsafe void ReadPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.Out)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glReadPixels")]
        public abstract void ReadPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glStencilFunc")]
        public abstract void StencilFunc([Flow(FlowDirection.In)] StencilFunction func, [Flow(FlowDirection.In)] int @ref, [Flow(FlowDirection.In)] uint mask);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glStencilOp")]
        public abstract void StencilOp([Flow(FlowDirection.In)] StencilOp fail, [Flow(FlowDirection.In)] StencilOp zfail, [Flow(FlowDirection.In)] StencilOp zpass);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexImage1D")]
        public abstract unsafe void TexImage1D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexImage1D")]
        public abstract void TexImage1D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexImage2D")]
        public abstract unsafe void TexImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexImage2D")]
        public abstract void TexImage2D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexParameterf")]
        public abstract void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexParameterfv")]
        public abstract unsafe void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexParameterfv")]
        public abstract void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexParameteri")]
        public abstract void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexParameteriv")]
        public abstract unsafe void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexParameteriv")]
        public abstract void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindTexture")]
        public abstract void BindTexture([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint texture);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyTexImage1D")]
        public abstract void CopyTexImage1D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyTexImage2D")]
        public abstract void CopyTexImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyTexSubImage1D")]
        public abstract void CopyTexSubImage1D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyTexSubImage2D")]
        public abstract void CopyTexSubImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteTextures")]
        public abstract unsafe void DeleteTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* textures);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteTextures")]
        public abstract void DeleteTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> textures);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawArrays")]
        public abstract void DrawArrays([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElements")]
        public abstract unsafe void DrawElements([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElements")]
        public abstract void DrawElements<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenTextures")]
        public abstract unsafe void GenTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* textures);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenTextures")]
        public abstract void GenTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> textures);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsTexture")]
        public abstract bool IsTexture([Flow(FlowDirection.In)] uint texture);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPolygonOffset")]
        public abstract void PolygonOffset([Flow(FlowDirection.In)] float factor, [Flow(FlowDirection.In)] float units);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexSubImage1D")]
        public abstract unsafe void TexSubImage1D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexSubImage1D")]
        public abstract void TexSubImage1D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexSubImage2D")]
        public abstract unsafe void TexSubImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexSubImage2D")]
        public abstract void TexSubImage2D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindTexture")]
        public abstract void BindTexture([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint texture);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyTexImage1D")]
        public abstract void CopyTexImage1D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyTexImage2D")]
        public abstract void CopyTexImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyTexSubImage1D")]
        public abstract void CopyTexSubImage1D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyTexSubImage2D")]
        public abstract void CopyTexSubImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawArrays")]
        public abstract void DrawArrays([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElements")]
        public abstract unsafe void DrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElements")]
        public abstract void DrawElements<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexSubImage1D")]
        public abstract unsafe void TexSubImage1D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexSubImage1D")]
        public abstract void TexSubImage1D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexSubImage2D")]
        public abstract unsafe void TexSubImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexSubImage2D")]
        public abstract void TexSubImage2D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyTexSubImage3D")]
        public abstract void CopyTexSubImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawRangeElements")]
        public abstract unsafe void DrawRangeElements([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawRangeElements")]
        public abstract void DrawRangeElements<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexImage3D")]
        public abstract unsafe void TexImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexImage3D")]
        public abstract void TexImage3D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexSubImage3D")]
        public abstract unsafe void TexSubImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexSubImage3D")]
        public abstract void TexSubImage3D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyTexSubImage3D")]
        public abstract void CopyTexSubImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawRangeElements")]
        public abstract unsafe void DrawRangeElements([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawRangeElements")]
        public abstract void DrawRangeElements<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexImage3D")]
        public abstract unsafe void TexImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexImage3D")]
        public abstract void TexImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexSubImage3D")]
        public abstract unsafe void TexSubImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexSubImage3D")]
        public abstract void TexSubImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glActiveTexture")]
        public abstract void ActiveTexture([Flow(FlowDirection.In)] GLEnum texture);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTexImage1D")]
        public abstract unsafe void CompressedTexImage1D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTexImage1D")]
        public abstract void CompressedTexImage1D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTexImage2D")]
        public abstract unsafe void CompressedTexImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTexImage2D")]
        public abstract void CompressedTexImage2D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTexImage3D")]
        public abstract unsafe void CompressedTexImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTexImage3D")]
        public abstract void CompressedTexImage3D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTexSubImage1D")]
        public abstract unsafe void CompressedTexSubImage1D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTexSubImage1D")]
        public abstract void CompressedTexSubImage1D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTexSubImage2D")]
        public abstract unsafe void CompressedTexSubImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTexSubImage2D")]
        public abstract void CompressedTexSubImage2D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTexSubImage3D")]
        public abstract unsafe void CompressedTexSubImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTexSubImage3D")]
        public abstract void CompressedTexSubImage3D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetCompressedTexImage")]
        public abstract unsafe void GetCompressedTexImage([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Count(Computed = "target, level"), Flow(FlowDirection.Out)] void* img);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetCompressedTexImage")]
        public abstract void GetCompressedTexImage<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Count(Computed = "target, level"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSampleCoverage")]
        public abstract void SampleCoverage([Flow(FlowDirection.In)] float value, [Flow(FlowDirection.In)] bool invert);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glActiveTexture")]
        public abstract void ActiveTexture([Flow(FlowDirection.In)] TextureUnit texture);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTexImage1D")]
        public abstract unsafe void CompressedTexImage1D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTexImage1D")]
        public abstract void CompressedTexImage1D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTexImage2D")]
        public abstract unsafe void CompressedTexImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTexImage2D")]
        public abstract void CompressedTexImage2D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTexImage3D")]
        public abstract unsafe void CompressedTexImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTexImage3D")]
        public abstract void CompressedTexImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTexSubImage1D")]
        public abstract unsafe void CompressedTexSubImage1D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTexSubImage1D")]
        public abstract void CompressedTexSubImage1D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTexSubImage2D")]
        public abstract unsafe void CompressedTexSubImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTexSubImage2D")]
        public abstract void CompressedTexSubImage2D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTexSubImage3D")]
        public abstract unsafe void CompressedTexSubImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTexSubImage3D")]
        public abstract void CompressedTexSubImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetCompressedTexImage")]
        public abstract unsafe void GetCompressedTexImage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Count(Computed = "target, level"), Flow(FlowDirection.Out)] void* img);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetCompressedTexImage")]
        public abstract void GetCompressedTexImage<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Count(Computed = "target, level"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendColor")]
        public abstract void BlendColor([Flow(FlowDirection.In)] float red, [Flow(FlowDirection.In)] float green, [Flow(FlowDirection.In)] float blue, [Flow(FlowDirection.In)] float alpha);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendEquation")]
        public abstract void BlendEquation([Flow(FlowDirection.In)] GLEnum mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendFuncSeparate")]
        public abstract void BlendFuncSeparate([Flow(FlowDirection.In)] GLEnum sfactorRGB, [Flow(FlowDirection.In)] GLEnum dfactorRGB, [Flow(FlowDirection.In)] GLEnum sfactorAlpha, [Flow(FlowDirection.In)] GLEnum dfactorAlpha);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawArrays")]
        public abstract unsafe void MultiDrawArrays([Flow(FlowDirection.In)] GLEnum mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint drawcount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawArrays")]
        public abstract void MultiDrawArrays([Flow(FlowDirection.In)] GLEnum mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref int first, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] uint drawcount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawElements")]
        public abstract unsafe void MultiDrawElements([Flow(FlowDirection.In)] GLEnum mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawElements")]
        public abstract unsafe void MultiDrawElements<T0>([Flow(FlowDirection.In)] GLEnum mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref T0* indices, [Flow(FlowDirection.In)] uint drawcount) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPointParameterf")]
        public abstract void PointParameter([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPointParameterfv")]
        public abstract unsafe void PointParameter([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPointParameterfv")]
        public abstract void PointParameter([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPointParameteri")]
        public abstract void PointParameter([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPointParameteriv")]
        public abstract unsafe void PointParameter([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPointParameteriv")]
        public abstract void PointParameter([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendEquation")]
        public abstract void BlendEquation([Flow(FlowDirection.In)] BlendEquationModeEXT mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendFuncSeparate")]
        public abstract void BlendFuncSeparate([Flow(FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(FlowDirection.In)] BlendingFactor dfactorAlpha);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawArrays")]
        public abstract unsafe void MultiDrawArrays([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint drawcount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawArrays")]
        public abstract void MultiDrawArrays([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref int first, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] uint drawcount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawElements")]
        public abstract unsafe void MultiDrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawElements")]
        public abstract unsafe void MultiDrawElements<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref T0* indices, [Flow(FlowDirection.In)] uint drawcount) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPointParameterf")]
        public abstract void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Flow(FlowDirection.In)] float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPointParameterfv")]
        public abstract unsafe void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPointParameterfv")]
        public abstract void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPointParameteri")]
        public abstract void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPointParameteriv")]
        public abstract unsafe void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPointParameteriv")]
        public abstract void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBeginQuery")]
        public abstract void BeginQuery([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint id);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindBuffer")]
        public abstract void BindBuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBufferData")]
        public abstract unsafe void BufferData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] GLEnum usage);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBufferData")]
        public abstract void BufferData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] GLEnum usage) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBufferSubData")]
        public abstract unsafe void BufferSubData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBufferSubData")]
        public abstract void BufferSubData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteBuffers")]
        public abstract unsafe void DeleteBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* buffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteBuffers")]
        public abstract void DeleteBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> buffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteQueries")]
        public abstract unsafe void DeleteQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteQueries")]
        public abstract void DeleteQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEndQuery")]
        public abstract void EndQuery([Flow(FlowDirection.In)] GLEnum target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenBuffers")]
        public abstract unsafe void GenBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* buffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenBuffers")]
        public abstract void GenBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> buffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenQueries")]
        public abstract unsafe void GenQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenQueries")]
        public abstract void GenQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBufferParameteriv")]
        public abstract unsafe void GetBufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBufferParameteriv")]
        public abstract void GetBufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBufferPointerv")]
        public abstract unsafe void GetBufferPointer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBufferPointerv")]
        public abstract unsafe void GetBufferPointer<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* @params) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBufferSubData")]
        public abstract unsafe void GetBufferSubData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBufferSubData")]
        public abstract void GetBufferSubData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryiv")]
        public abstract unsafe void GetQuery([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryiv")]
        public abstract void GetQuery([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryObjectiv")]
        public abstract unsafe void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryObjectiv")]
        public abstract void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryObjectuiv")]
        public abstract unsafe void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryObjectuiv")]
        public abstract void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsBuffer")]
        public abstract bool IsBuffer([Flow(FlowDirection.In)] uint buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsQuery")]
        public abstract bool IsQuery([Flow(FlowDirection.In)] uint id);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMapBuffer")]
        public abstract unsafe void* MapBuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum access);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUnmapBuffer")]
        public abstract bool UnmapBuffer([Flow(FlowDirection.In)] GLEnum target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBeginQuery")]
        public abstract void BeginQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint id);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindBuffer")]
        public abstract void BindBuffer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBufferData")]
        public abstract unsafe void BufferData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] BufferUsageARB usage);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBufferData")]
        public abstract void BufferData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] BufferUsageARB usage) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBufferSubData")]
        public abstract unsafe void BufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBufferSubData")]
        public abstract void BufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEndQuery")]
        public abstract void EndQuery([Flow(FlowDirection.In)] QueryTarget target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBufferParameteriv")]
        public abstract unsafe void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBufferParameteriv")]
        public abstract void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBufferPointerv")]
        public abstract unsafe void GetBufferPointer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBufferPointerv")]
        public abstract unsafe void GetBufferPointer<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* @params) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBufferSubData")]
        public abstract unsafe void GetBufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBufferSubData")]
        public abstract void GetBufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryiv")]
        public abstract unsafe void GetQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryiv")]
        public abstract void GetQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryObjectiv")]
        public abstract unsafe void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryObjectiv")]
        public abstract void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryObjectuiv")]
        public abstract unsafe void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryObjectuiv")]
        public abstract void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMapBuffer")]
        public abstract unsafe void* MapBuffer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferAccessARB access);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUnmapBuffer")]
        public abstract bool UnmapBuffer([Flow(FlowDirection.In)] BufferTargetARB target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glAttachShader")]
        public abstract void AttachShader([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint shader);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindAttribLocation")]
        public abstract unsafe void BindAttribLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindAttribLocation")]
        public abstract void BindAttribLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Span<char> name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendEquationSeparate")]
        public abstract void BlendEquationSeparate([Flow(FlowDirection.In)] GLEnum modeRGB, [Flow(FlowDirection.In)] GLEnum modeAlpha);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompileShader")]
        public abstract void CompileShader([Flow(FlowDirection.In)] uint shader);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateProgram")]
        public abstract uint CreateProgram();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateShader")]
        public abstract uint CreateShader([Flow(FlowDirection.In)] GLEnum type);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteProgram")]
        public abstract void DeleteProgram([Flow(FlowDirection.In)] uint program);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteShader")]
        public abstract void DeleteShader([Flow(FlowDirection.In)] uint shader);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDetachShader")]
        public abstract void DetachShader([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint shader);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDisableVertexAttribArray")]
        public abstract void DisableVertexAttribArray([Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawBuffers")]
        public abstract unsafe void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] GLEnum* bufs);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawBuffers")]
        public abstract void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<GLEnum> bufs);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEnableVertexAttribArray")]
        public abstract void EnableVertexAttribArray([Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public abstract unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public abstract void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public abstract unsafe void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public abstract void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetAttachedShaders")]
        public abstract unsafe void GetAttachedShaders([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] uint* count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] uint* shaders);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetAttachedShaders")]
        public abstract void GetAttachedShaders([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] out uint count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] Span<uint> shaders);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetAttribLocation")]
        public abstract unsafe int GetAttribLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetAttribLocation")]
        public abstract int GetAttribLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] Span<char> name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramiv")]
        public abstract unsafe void GetProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramiv")]
        public abstract void GetProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramInfoLog")]
        public abstract unsafe void GetProgramInfoLog([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* infoLog);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramInfoLog")]
        public abstract void GetProgramInfoLog([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> infoLog);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetShaderiv")]
        public abstract unsafe void GetShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetShaderiv")]
        public abstract void GetShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetShaderInfoLog")]
        public abstract unsafe void GetShaderInfoLog([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* infoLog);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetShaderInfoLog")]
        public abstract void GetShaderInfoLog([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> infoLog);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetShaderSource")]
        public abstract unsafe void GetShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* source);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetShaderSource")]
        public abstract void GetShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> source);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformfv")]
        public abstract unsafe void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformfv")]
        public abstract void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformiv")]
        public abstract unsafe void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformiv")]
        public abstract void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformLocation")]
        public abstract unsafe int GetUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformLocation")]
        public abstract int GetUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] Span<char> name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribdv")]
        public abstract unsafe void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribdv")]
        public abstract void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribfv")]
        public abstract unsafe void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribfv")]
        public abstract void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribiv")]
        public abstract unsafe void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribiv")]
        public abstract void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribPointerv")]
        public abstract unsafe void GetVertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** pointer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribPointerv")]
        public abstract unsafe void GetVertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* pointer) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsProgram")]
        public abstract bool IsProgram([Flow(FlowDirection.In)] uint program);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsShader")]
        public abstract bool IsShader([Flow(FlowDirection.In)] uint shader);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glLinkProgram")]
        public abstract void LinkProgram([Flow(FlowDirection.In)] uint program);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glShaderSource")]
        public abstract unsafe void ShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] char** @string, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* length);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glShaderSource")]
        public abstract unsafe void ShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] char** @string, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> length);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glStencilFuncSeparate")]
        public abstract void StencilFuncSeparate([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] GLEnum func, [Flow(FlowDirection.In)] int @ref, [Flow(FlowDirection.In)] uint mask);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glStencilMaskSeparate")]
        public abstract void StencilMaskSeparate([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] uint mask);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glStencilOpSeparate")]
        public abstract void StencilOpSeparate([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] GLEnum sfail, [Flow(FlowDirection.In)] GLEnum dpfail, [Flow(FlowDirection.In)] GLEnum dppass);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform1f")]
        public abstract void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform1i")]
        public abstract void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform1fv")]
        public abstract unsafe void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform1fv")]
        public abstract void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform1iv")]
        public abstract unsafe void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform1iv")]
        public abstract void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform2f")]
        public abstract void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform2i")]
        public abstract void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform2fv")]
        public abstract unsafe void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform2fv")]
        public abstract void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform2iv")]
        public abstract unsafe void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform2iv")]
        public abstract void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform3f")]
        public abstract void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform3i")]
        public abstract void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform3fv")]
        public abstract unsafe void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform3fv")]
        public abstract void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform3iv")]
        public abstract unsafe void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform3iv")]
        public abstract void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform4f")]
        public abstract void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] float v3);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform4i")]
        public abstract void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2, [Flow(FlowDirection.In)] int v3);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform4fv")]
        public abstract unsafe void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform4fv")]
        public abstract void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform4iv")]
        public abstract unsafe void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform4iv")]
        public abstract void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix2fv")]
        public abstract unsafe void UniformMatrix2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix2fv")]
        public abstract void UniformMatrix2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix3fv")]
        public abstract unsafe void UniformMatrix3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix3fv")]
        public abstract void UniformMatrix3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix4fv")]
        public abstract unsafe void UniformMatrix4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix4fv")]
        public abstract void UniformMatrix4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUseProgram")]
        public abstract void UseProgram([Flow(FlowDirection.In)] uint program);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glValidateProgram")]
        public abstract void ValidateProgram([Flow(FlowDirection.In)] uint program);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib1d")]
        public abstract void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib1dv")]
        public abstract unsafe void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] double* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib1dv")]
        public abstract void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref double v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib1f")]
        public abstract void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib1fv")]
        public abstract unsafe void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] float* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib1fv")]
        public abstract void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref float v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib1s")]
        public abstract void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib1sv")]
        public abstract unsafe void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] short* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib1sv")]
        public abstract void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref short v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib2d")]
        public abstract void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib2dv")]
        public abstract unsafe void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] double* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib2dv")]
        public abstract void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<double> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib2f")]
        public abstract void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib2fv")]
        public abstract unsafe void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] float* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib2fv")]
        public abstract void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<float> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib2s")]
        public abstract void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib2sv")]
        public abstract unsafe void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] short* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib2sv")]
        public abstract void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<short> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib3d")]
        public abstract void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib3dv")]
        public abstract unsafe void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] double* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib3dv")]
        public abstract void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<double> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib3f")]
        public abstract void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib3fv")]
        public abstract unsafe void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib3fv")]
        public abstract void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib3s")]
        public abstract void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib3sv")]
        public abstract unsafe void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] short* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib3sv")]
        public abstract void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<short> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4bv")]
        public abstract unsafe void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] sbyte* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4bv")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<sbyte> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4d")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4dv")]
        public abstract unsafe void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] double* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4dv")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4f")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4fv")]
        public abstract unsafe void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4fv")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4iv")]
        public abstract unsafe void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4iv")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4s")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z, [Flow(FlowDirection.In)] short w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4sv")]
        public abstract unsafe void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] short* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4sv")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<short> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4ubv")]
        public abstract unsafe void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] byte* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4ubv")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<byte> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4uiv")]
        public abstract unsafe void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4uiv")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<uint> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4usv")]
        public abstract unsafe void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ushort* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4usv")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<ushort> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4Nbv")]
        public abstract unsafe void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] sbyte* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4Nbv")]
        public abstract void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<sbyte> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4Niv")]
        public abstract unsafe void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4Niv")]
        public abstract void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4Nsv")]
        public abstract unsafe void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] short* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4Nsv")]
        public abstract void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<short> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4Nub")]
        public abstract void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] byte x, [Flow(FlowDirection.In)] byte y, [Flow(FlowDirection.In)] byte z, [Flow(FlowDirection.In)] byte w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4Nubv")]
        public abstract unsafe void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] byte* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4Nubv")]
        public abstract void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<byte> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4Nuiv")]
        public abstract unsafe void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4Nuiv")]
        public abstract void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<uint> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4Nusv")]
        public abstract unsafe void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ushort* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4Nusv")]
        public abstract void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<ushort> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribPointer")]
        public abstract unsafe void VertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribPointer")]
        public abstract void VertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindAttribLocation")]
        public abstract void BindAttribLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendEquationSeparate")]
        public abstract void BlendEquationSeparate([Flow(FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateShader")]
        public abstract uint CreateShader([Flow(FlowDirection.In)] ShaderType type);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawBuffers")]
        public abstract unsafe void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] DrawBufferMode* bufs);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawBuffers")]
        public abstract void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<DrawBufferMode> bufs);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public abstract unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -4)] out string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public abstract void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -4)] out string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public abstract unsafe void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -4)] out string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public abstract void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out UniformType type, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -4)] out string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetAttribLocation")]
        public abstract int GetAttribLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramiv")]
        public abstract unsafe void GetProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramPropertyARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramiv")]
        public abstract void GetProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramPropertyARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramInfoLog")]
        public abstract unsafe void GetProgramInfoLog([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string infoLog);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramInfoLog")]
        public abstract void GetProgramInfoLog([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string infoLog);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetShaderiv")]
        public abstract unsafe void GetShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] ShaderParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetShaderiv")]
        public abstract void GetShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] ShaderParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetShaderInfoLog")]
        public abstract unsafe void GetShaderInfoLog([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string infoLog);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetShaderInfoLog")]
        public abstract void GetShaderInfoLog([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string infoLog);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetShaderSource")]
        public abstract unsafe void GetShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string source);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetShaderSource")]
        public abstract void GetShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string source);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformLocation")]
        public abstract int GetUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribdv")]
        public abstract unsafe void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribdv")]
        public abstract void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribfv")]
        public abstract unsafe void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribfv")]
        public abstract void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribiv")]
        public abstract unsafe void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribiv")]
        public abstract void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribPointerv")]
        public abstract unsafe void GetVertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerPropertyARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** pointer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribPointerv")]
        public abstract unsafe void GetVertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerPropertyARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* pointer) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glStencilFuncSeparate")]
        public abstract void StencilFuncSeparate([Flow(FlowDirection.In)] StencilFaceDirection face, [Flow(FlowDirection.In)] StencilFunction func, [Flow(FlowDirection.In)] int @ref, [Flow(FlowDirection.In)] uint mask);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glStencilMaskSeparate")]
        public abstract void StencilMaskSeparate([Flow(FlowDirection.In)] StencilFaceDirection face, [Flow(FlowDirection.In)] uint mask);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glStencilOpSeparate")]
        public abstract void StencilOpSeparate([Flow(FlowDirection.In)] StencilFaceDirection face, [Flow(FlowDirection.In)] StencilOp sfail, [Flow(FlowDirection.In)] StencilOp dpfail, [Flow(FlowDirection.In)] StencilOp dppass);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4ubv")]
        public abstract void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] string v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttrib4Nubv")]
        public abstract void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] string v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribPointer")]
        public abstract unsafe void VertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribPointer")]
        public abstract void VertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix2x3fv")]
        public abstract unsafe void UniformMatrix2x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix2x3fv")]
        public abstract void UniformMatrix2x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix2x4fv")]
        public abstract unsafe void UniformMatrix2x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix2x4fv")]
        public abstract void UniformMatrix2x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix3x2fv")]
        public abstract unsafe void UniformMatrix3x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix3x2fv")]
        public abstract void UniformMatrix3x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix3x4fv")]
        public abstract unsafe void UniformMatrix3x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix3x4fv")]
        public abstract void UniformMatrix3x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix4x2fv")]
        public abstract unsafe void UniformMatrix4x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix4x2fv")]
        public abstract void UniformMatrix4x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix4x3fv")]
        public abstract unsafe void UniformMatrix4x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix4x3fv")]
        public abstract void UniformMatrix4x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBeginConditionalRender")]
        public abstract void BeginConditionalRender([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBeginTransformFeedback")]
        public abstract void BeginTransformFeedback([Flow(FlowDirection.In)] GLEnum primitiveMode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindBufferBase")]
        public abstract void BindBufferBase([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindBufferRange")]
        public abstract void BindBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindFragDataLocation")]
        public abstract unsafe void BindFragDataLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint color, [Count(Computed = "name"), Flow(FlowDirection.In)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindFragDataLocation")]
        public abstract void BindFragDataLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint color, [Count(Computed = "name"), Flow(FlowDirection.In)] ref char name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindFramebuffer")]
        public abstract void BindFramebuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint framebuffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindRenderbuffer")]
        public abstract void BindRenderbuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint renderbuffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindVertexArray")]
        public abstract void BindVertexArray([Flow(FlowDirection.In)] uint array);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlitFramebuffer")]
        public abstract void BlitFramebuffer([Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] GLEnum filter);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCheckFramebufferStatus")]
        public abstract GLEnum CheckFramebufferStatus([Flow(FlowDirection.In)] GLEnum target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClampColor")]
        public abstract void ClampColor([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum clamp);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearBufferiv")]
        public abstract unsafe void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] int* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearBufferiv")]
        public abstract void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ref int value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearBufferuiv")]
        public abstract unsafe void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearBufferuiv")]
        public abstract void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ref uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearBufferfv")]
        public abstract unsafe void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearBufferfv")]
        public abstract void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ref float value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearBufferfi")]
        public abstract void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float depth, [Flow(FlowDirection.In)] int stencil);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorMaski")]
        public abstract void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] bool r, [Flow(FlowDirection.In)] bool g, [Flow(FlowDirection.In)] bool b, [Flow(FlowDirection.In)] bool a);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteFramebuffers")]
        public abstract unsafe void DeleteFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* framebuffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteFramebuffers")]
        public abstract void DeleteFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> framebuffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteRenderbuffers")]
        public abstract unsafe void DeleteRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* renderbuffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteRenderbuffers")]
        public abstract void DeleteRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> renderbuffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteVertexArrays")]
        public abstract unsafe void DeleteVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* arrays);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteVertexArrays")]
        public abstract void DeleteVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> arrays);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDisablei")]
        public abstract void Disable([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEnablei")]
        public abstract void Enable([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEndConditionalRender")]
        public abstract void EndConditionalRender();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEndTransformFeedback")]
        public abstract void EndTransformFeedback();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFlushMappedBufferRange")]
        public abstract void FlushMappedBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferRenderbuffer")]
        public abstract void FramebufferRenderbuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferTexture1D")]
        public abstract void FramebufferTexture1D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferTexture2D")]
        public abstract void FramebufferTexture2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferTexture3D")]
        public abstract void FramebufferTexture3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferTextureLayer")]
        public abstract void FramebufferTextureLayer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenerateMipmap")]
        public abstract void GenerateMipmap([Flow(FlowDirection.In)] GLEnum target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenFramebuffers")]
        public abstract unsafe void GenFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* framebuffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenFramebuffers")]
        public abstract void GenFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> framebuffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenRenderbuffers")]
        public abstract unsafe void GenRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* renderbuffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenRenderbuffers")]
        public abstract void GenRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> renderbuffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenVertexArrays")]
        public abstract unsafe void GenVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* arrays);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenVertexArrays")]
        public abstract void GenVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> arrays);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBooleani_v")]
        public abstract unsafe void GetBoolean([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] bool* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBooleani_v")]
        public abstract void GetBoolean([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out bool data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFragDataLocation")]
        public abstract unsafe int GetFragDataLocation([Flow(FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(FlowDirection.In)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFragDataLocation")]
        public abstract int GetFragDataLocation([Flow(FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(FlowDirection.In)] ref char name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public abstract unsafe void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public abstract void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetIntegeri_v")]
        public abstract unsafe void GetInteger([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] int* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetIntegeri_v")]
        public abstract void GetInteger([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out int data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv")]
        public abstract unsafe void GetRenderbufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv")]
        public abstract void GetRenderbufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetStringi")]
        public abstract unsafe byte* GetString([Flow(FlowDirection.In)] GLEnum name, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexParameterIiv")]
        public abstract unsafe void GetTexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexParameterIiv")]
        public abstract void GetTexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexParameterIuiv")]
        public abstract unsafe void GetTexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexParameterIuiv")]
        public abstract void GetTexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public abstract unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public abstract void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformuiv")]
        public abstract unsafe void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformuiv")]
        public abstract void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] out uint @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribIiv")]
        public abstract unsafe void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribIiv")]
        public abstract void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribIuiv")]
        public abstract unsafe void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribIuiv")]
        public abstract void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out uint @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsEnabledi")]
        public abstract bool IsEnabled([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsFramebuffer")]
        public abstract bool IsFramebuffer([Flow(FlowDirection.In)] uint framebuffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsRenderbuffer")]
        public abstract bool IsRenderbuffer([Flow(FlowDirection.In)] uint renderbuffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsVertexArray")]
        public abstract bool IsVertexArray([Flow(FlowDirection.In)] uint array);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMapBufferRange")]
        public abstract unsafe void* MapBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length, [Flow(FlowDirection.In)] uint access);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glRenderbufferStorage")]
        public abstract void RenderbufferStorage([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glRenderbufferStorageMultisample")]
        public abstract void RenderbufferStorageMultisample([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexParameterIiv")]
        public abstract unsafe void TexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexParameterIiv")]
        public abstract void TexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexParameterIuiv")]
        public abstract unsafe void TexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexParameterIuiv")]
        public abstract void TexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTransformFeedbackVaryings")]
        public abstract unsafe void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] char** varyings, [Flow(FlowDirection.In)] GLEnum bufferMode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform1ui")]
        public abstract void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform1uiv")]
        public abstract unsafe void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform1uiv")]
        public abstract void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform2ui")]
        public abstract void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform2uiv")]
        public abstract unsafe void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform2uiv")]
        public abstract void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform3ui")]
        public abstract void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1, [Flow(FlowDirection.In)] uint v2);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform3uiv")]
        public abstract unsafe void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform3uiv")]
        public abstract void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform4ui")]
        public abstract void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1, [Flow(FlowDirection.In)] uint v2, [Flow(FlowDirection.In)] uint v3);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform4uiv")]
        public abstract unsafe void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform4uiv")]
        public abstract void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI1i")]
        public abstract void VertexAttribI1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI1ui")]
        public abstract void VertexAttribI1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI1iv")]
        public abstract unsafe void VertexAttribI1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] int* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI1iv")]
        public abstract void VertexAttribI1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref int v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI1uiv")]
        public abstract unsafe void VertexAttribI1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] uint* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI1uiv")]
        public abstract void VertexAttribI1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref uint v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI2i")]
        public abstract void VertexAttribI2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI2ui")]
        public abstract void VertexAttribI2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI2iv")]
        public abstract unsafe void VertexAttribI2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] int* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI2iv")]
        public abstract void VertexAttribI2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<int> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI2uiv")]
        public abstract unsafe void VertexAttribI2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] uint* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI2uiv")]
        public abstract void VertexAttribI2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<uint> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI3i")]
        public abstract void VertexAttribI3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI3ui")]
        public abstract void VertexAttribI3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI3iv")]
        public abstract unsafe void VertexAttribI3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] int* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI3iv")]
        public abstract void VertexAttribI3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<int> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI3uiv")]
        public abstract unsafe void VertexAttribI3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] uint* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI3uiv")]
        public abstract void VertexAttribI3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<uint> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI4i")]
        public abstract void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI4ui")]
        public abstract void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint z, [Flow(FlowDirection.In)] uint w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI4iv")]
        public abstract unsafe void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI4iv")]
        public abstract void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI4uiv")]
        public abstract unsafe void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI4uiv")]
        public abstract void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<uint> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI4bv")]
        public abstract unsafe void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] sbyte* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI4bv")]
        public abstract void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<sbyte> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI4sv")]
        public abstract unsafe void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] short* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI4sv")]
        public abstract void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<short> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI4ubv")]
        public abstract unsafe void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] byte* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI4ubv")]
        public abstract void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<byte> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI4usv")]
        public abstract unsafe void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ushort* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI4usv")]
        public abstract void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<ushort> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribIPointer")]
        public abstract unsafe void VertexAttribIPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribIPointer")]
        public abstract void VertexAttribIPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBeginConditionalRender")]
        public abstract void BeginConditionalRender([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ConditionalRenderMode mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBeginTransformFeedback")]
        public abstract void BeginTransformFeedback([Flow(FlowDirection.In)] PrimitiveType primitiveMode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindBufferBase")]
        public abstract void BindBufferBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindBufferRange")]
        public abstract void BindBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindFragDataLocation")]
        public abstract void BindFragDataLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint color, [Flow(FlowDirection.In)] string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindFramebuffer")]
        public abstract void BindFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint framebuffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindRenderbuffer")]
        public abstract void BindRenderbuffer([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint renderbuffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlitFramebuffer")]
        public abstract void BlitFramebuffer([Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] BlitFramebufferFilter filter);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCheckFramebufferStatus")]
        public abstract GLEnum CheckFramebufferStatus([Flow(FlowDirection.In)] FramebufferTarget target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClampColor")]
        public abstract void ClampColor([Flow(FlowDirection.In)] ClampColorTargetARB target, [Flow(FlowDirection.In)] ClampColorModeARB clamp);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearBufferiv")]
        public abstract unsafe void ClearBuffer([Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] int* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearBufferiv")]
        public abstract void ClearBuffer([Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ref int value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearBufferuiv")]
        public abstract unsafe void ClearBuffer([Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearBufferuiv")]
        public abstract void ClearBuffer([Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ref uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearBufferfv")]
        public abstract unsafe void ClearBuffer([Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearBufferfv")]
        public abstract void ClearBuffer([Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ref float value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearBufferfi")]
        public abstract void ClearBuffer([Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float depth, [Flow(FlowDirection.In)] int stencil);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDisablei")]
        public abstract void Disable([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEnablei")]
        public abstract void Enable([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFlushMappedBufferRange")]
        public abstract void FlushMappedBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferRenderbuffer")]
        public abstract void FramebufferRenderbuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] RenderbufferTarget renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferTexture1D")]
        public abstract void FramebufferTexture1D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferTexture2D")]
        public abstract void FramebufferTexture2D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferTexture3D")]
        public abstract void FramebufferTexture3D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferTextureLayer")]
        public abstract void FramebufferTextureLayer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenerateMipmap")]
        public abstract void GenerateMipmap([Flow(FlowDirection.In)] TextureTarget target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBooleani_v")]
        public abstract unsafe void GetBoolean([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] bool* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBooleani_v")]
        public abstract void GetBoolean([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out bool data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFragDataLocation")]
        public abstract int GetFragDataLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public abstract unsafe void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public abstract void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv")]
        public abstract unsafe void GetRenderbufferParameter([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv")]
        public abstract void GetRenderbufferParameter([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetStringi")]
        public abstract string GetString([Flow(FlowDirection.In)] StringName name, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexParameterIiv")]
        public abstract unsafe void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexParameterIiv")]
        public abstract void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexParameterIuiv")]
        public abstract unsafe void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTexParameterIuiv")]
        public abstract void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public abstract unsafe void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] GlslTypeToken* type, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -4)] out string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public abstract void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out GlslTypeToken type, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -4)] out string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribIiv")]
        public abstract unsafe void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribIiv")]
        public abstract void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribIuiv")]
        public abstract unsafe void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribIuiv")]
        public abstract void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out uint @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsEnabledi")]
        public abstract bool IsEnabled([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMapBufferRange")]
        public abstract unsafe void* MapBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length, [Flow(FlowDirection.In)] uint access);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glRenderbufferStorage")]
        public abstract void RenderbufferStorage([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glRenderbufferStorageMultisample")]
        public abstract void RenderbufferStorageMultisample([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexParameterIiv")]
        public abstract unsafe void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexParameterIiv")]
        public abstract void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexParameterIuiv")]
        public abstract unsafe void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexParameterIuiv")]
        public abstract void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTransformFeedbackVaryings")]
        public abstract unsafe void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] char** varyings, [Flow(FlowDirection.In)] TransformFeedbackBufferMode bufferMode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI4ubv")]
        public abstract void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] string v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribIPointer")]
        public abstract unsafe void VertexAttribIPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribIPointer")]
        public abstract void VertexAttribIPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyBufferSubData")]
        public abstract void CopyBufferSubData([Flow(FlowDirection.In)] GLEnum readTarget, [Flow(FlowDirection.In)] GLEnum writeTarget, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawArraysInstanced")]
        public abstract void DrawArraysInstanced([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint instancecount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstanced")]
        public abstract unsafe void DrawElementsInstanced([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstanced")]
        public abstract void DrawElementsInstanced<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] uint instancecount) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveUniformBlockiv")]
        public abstract unsafe void GetActiveUniformBlock([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveUniformBlockiv")]
        public abstract void GetActiveUniformBlock([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveUniformBlockName")]
        public abstract unsafe void GetActiveUniformBlockName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* uniformBlockName);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveUniformBlockName")]
        public abstract void GetActiveUniformBlockName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> uniformBlockName);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveUniformName")]
        public abstract unsafe void GetActiveUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* uniformName);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveUniformName")]
        public abstract void GetActiveUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> uniformName);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveUniformsiv")]
        public abstract unsafe void GetActiveUniforms([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] uint* uniformIndices, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveUniformsiv")]
        public abstract void GetActiveUniforms([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] Span<uint> uniformIndices, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformBlockIndex")]
        public abstract unsafe uint GetUniformBlockIndex([Flow(FlowDirection.In)] uint program, [Count(Count = 0), Flow(FlowDirection.In)] char* uniformBlockName);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformBlockIndex")]
        public abstract uint GetUniformBlockIndex([Flow(FlowDirection.In)] uint program, [Count(Count = 0), Flow(FlowDirection.In)] ref char uniformBlockName);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformIndices")]
        public abstract unsafe void GetUniformIndices([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(FlowDirection.In)] char** uniformNames, [Count(Computed = "uniformCount"), Flow(FlowDirection.Out)] uint* uniformIndices);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformIndices")]
        public abstract unsafe void GetUniformIndices([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(FlowDirection.In)] ref char* uniformNames, [Count(Computed = "uniformCount"), Flow(FlowDirection.Out)] out uint uniformIndices);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPrimitiveRestartIndex")]
        public abstract void PrimitiveRestartIndex([Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexBuffer")]
        public abstract void TexBuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformBlockBinding")]
        public abstract void UniformBlockBinding([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint uniformBlockBinding);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyBufferSubData")]
        public abstract void CopyBufferSubData([Flow(FlowDirection.In)] CopyBufferSubDataTarget readTarget, [Flow(FlowDirection.In)] CopyBufferSubDataTarget writeTarget, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawArraysInstanced")]
        public abstract void DrawArraysInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint instancecount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstanced")]
        public abstract unsafe void DrawElementsInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstanced")]
        public abstract void DrawElementsInstanced<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] uint instancecount) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveUniformBlockiv")]
        public abstract unsafe void GetActiveUniformBlock([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] UniformBlockPName pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveUniformBlockiv")]
        public abstract void GetActiveUniformBlock([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] UniformBlockPName pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveUniformBlockName")]
        public abstract unsafe void GetActiveUniformBlockName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string uniformBlockName);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveUniformBlockName")]
        public abstract void GetActiveUniformBlockName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string uniformBlockName);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveUniformName")]
        public abstract unsafe void GetActiveUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string uniformName);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveUniformName")]
        public abstract void GetActiveUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string uniformName);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveUniformsiv")]
        public abstract unsafe void GetActiveUniforms([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] uint* uniformIndices, [Flow(FlowDirection.In)] UniformPName pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveUniformsiv")]
        public abstract void GetActiveUniforms([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] Span<uint> uniformIndices, [Flow(FlowDirection.In)] UniformPName pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformBlockIndex")]
        public abstract uint GetUniformBlockIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string uniformBlockName);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexBuffer")]
        public abstract void TexBuffer([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClientWaitSync")]
        public abstract GLEnum ClientWaitSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] ulong timeout);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteSync")]
        public abstract void DeleteSync([Flow(FlowDirection.In)] IntPtr sync);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public abstract unsafe void DrawElementsBaseVertex([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public abstract void DrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public abstract unsafe void DrawElementsInstancedBaseVertex([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public abstract void DrawElementsInstancedBaseVertex<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public abstract unsafe void DrawRangeElementsBaseVertex([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public abstract void DrawRangeElementsBaseVertex<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFenceSync")]
        public abstract IntPtr FenceSync([Flow(FlowDirection.In)] GLEnum condition, [Flow(FlowDirection.In)] uint flags);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferTexture")]
        public abstract void FramebufferTexture([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBufferParameteri64v")]
        public abstract unsafe void GetBufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBufferParameteri64v")]
        public abstract void GetBufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetInteger64v")]
        public abstract unsafe void GetInteger64([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetInteger64v")]
        public abstract void GetInteger64([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetInteger64i_v")]
        public abstract unsafe void GetInteger64([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] long* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetInteger64i_v")]
        public abstract void GetInteger64([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out long data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultisamplefv")]
        public abstract unsafe void GetMultisample([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* val);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultisamplefv")]
        public abstract void GetMultisample([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float val);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSynciv")]
        public abstract unsafe void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSynciv")]
        public abstract void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsSync")]
        public abstract bool IsSync([Flow(FlowDirection.In)] IntPtr sync);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public abstract unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] GLEnum mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public abstract unsafe void MultiDrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] GLEnum mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref T0* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref int basevertex) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProvokingVertex")]
        public abstract void ProvokingVertex([Flow(FlowDirection.In)] GLEnum mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSampleMaski")]
        public abstract void SampleMask([Flow(FlowDirection.In)] uint maskNumber, [Flow(FlowDirection.In)] uint mask);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexImage2DMultisample")]
        public abstract void TexImage2DMultisample([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexImage3DMultisample")]
        public abstract void TexImage3DMultisample([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glWaitSync")]
        public abstract void WaitSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] ulong timeout);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public abstract unsafe void DrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public abstract void DrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public abstract unsafe void DrawElementsInstancedBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public abstract void DrawElementsInstancedBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public abstract unsafe void DrawRangeElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public abstract void DrawRangeElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFenceSync")]
        public abstract IntPtr FenceSync([Flow(FlowDirection.In)] SyncCondition condition, [Flow(FlowDirection.In)] uint flags);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferTexture")]
        public abstract void FramebufferTexture([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBufferParameteri64v")]
        public abstract unsafe void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBufferParameteri64v")]
        public abstract void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetInteger64v")]
        public abstract unsafe void GetInteger64([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetInteger64v")]
        public abstract void GetInteger64([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultisamplefv")]
        public abstract unsafe void GetMultisample([Flow(FlowDirection.In)] GetMultisamplePNameNV pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* val);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultisamplefv")]
        public abstract void GetMultisample([Flow(FlowDirection.In)] GetMultisamplePNameNV pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float val);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSynciv")]
        public abstract unsafe void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSynciv")]
        public abstract void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public abstract unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public abstract unsafe void MultiDrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref T0* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref int basevertex) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProvokingVertex")]
        public abstract void ProvokingVertex([Flow(FlowDirection.In)] VertexProvokingMode mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexImage2DMultisample")]
        public abstract void TexImage2DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexImage3DMultisample")]
        public abstract void TexImage3DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindFragDataLocationIndexed")]
        public abstract unsafe void BindFragDataLocationIndexed([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindFragDataLocationIndexed")]
        public abstract void BindFragDataLocationIndexed([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Span<char> name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindSampler")]
        public abstract void BindSampler([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint sampler);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorP3ui")]
        public abstract void ColorP3([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint color);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorP3uiv")]
        public abstract unsafe void ColorP3([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorP3uiv")]
        public abstract void ColorP3([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint color);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorP4ui")]
        public abstract void ColorP4([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint color);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorP4uiv")]
        public abstract unsafe void ColorP4([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorP4uiv")]
        public abstract void ColorP4([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint color);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteSamplers")]
        public abstract unsafe void DeleteSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* samplers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteSamplers")]
        public abstract void DeleteSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> samplers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenSamplers")]
        public abstract unsafe void GenSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* samplers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenSamplers")]
        public abstract void GenSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> samplers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFragDataIndex")]
        public abstract unsafe int GetFragDataIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFragDataIndex")]
        public abstract int GetFragDataIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] Span<char> name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryObjecti64v")]
        public abstract unsafe void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryObjecti64v")]
        public abstract void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryObjectui64v")]
        public abstract unsafe void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] ulong* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryObjectui64v")]
        public abstract void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out ulong @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSamplerParameteriv")]
        public abstract unsafe void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSamplerParameteriv")]
        public abstract void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSamplerParameterfv")]
        public abstract unsafe void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSamplerParameterfv")]
        public abstract void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSamplerParameterIiv")]
        public abstract unsafe void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSamplerParameterIiv")]
        public abstract void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv")]
        public abstract unsafe void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv")]
        public abstract void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsSampler")]
        public abstract bool IsSampler([Flow(FlowDirection.In)] uint sampler);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoordP1ui")]
        public abstract void MultiTexCoordP1([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv")]
        public abstract unsafe void MultiTexCoordP1([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv")]
        public abstract void MultiTexCoordP1([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoordP2ui")]
        public abstract void MultiTexCoordP2([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv")]
        public abstract unsafe void MultiTexCoordP2([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv")]
        public abstract void MultiTexCoordP2([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoordP3ui")]
        public abstract void MultiTexCoordP3([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv")]
        public abstract unsafe void MultiTexCoordP3([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv")]
        public abstract void MultiTexCoordP3([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoordP4ui")]
        public abstract void MultiTexCoordP4([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv")]
        public abstract unsafe void MultiTexCoordP4([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv")]
        public abstract void MultiTexCoordP4([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalP3ui")]
        public abstract void NormalP3([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalP3uiv")]
        public abstract unsafe void NormalP3([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalP3uiv")]
        public abstract void NormalP3([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glQueryCounter")]
        public abstract void QueryCounter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSamplerParameteri")]
        public abstract void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSamplerParameteriv")]
        public abstract unsafe void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSamplerParameteriv")]
        public abstract void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSamplerParameterf")]
        public abstract void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSamplerParameterfv")]
        public abstract unsafe void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSamplerParameterfv")]
        public abstract void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSamplerParameterIiv")]
        public abstract unsafe void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSamplerParameterIiv")]
        public abstract void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSamplerParameterIuiv")]
        public abstract unsafe void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSamplerParameterIuiv")]
        public abstract void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColorP3ui")]
        public abstract void SecondaryColorP3([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint color);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColorP3uiv")]
        public abstract unsafe void SecondaryColorP3([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColorP3uiv")]
        public abstract void SecondaryColorP3([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint color);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoordP1ui")]
        public abstract void TexCoordP1([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoordP1uiv")]
        public abstract unsafe void TexCoordP1([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoordP1uiv")]
        public abstract void TexCoordP1([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoordP2ui")]
        public abstract void TexCoordP2([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoordP2uiv")]
        public abstract unsafe void TexCoordP2([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoordP2uiv")]
        public abstract void TexCoordP2([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoordP3ui")]
        public abstract void TexCoordP3([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoordP3uiv")]
        public abstract unsafe void TexCoordP3([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoordP3uiv")]
        public abstract void TexCoordP3([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoordP4ui")]
        public abstract void TexCoordP4([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoordP4uiv")]
        public abstract unsafe void TexCoordP4([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoordP4uiv")]
        public abstract void TexCoordP4([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribDivisor")]
        public abstract void VertexAttribDivisor([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint divisor);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP1ui")]
        public abstract void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP1uiv")]
        public abstract unsafe void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP1uiv")]
        public abstract void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP2ui")]
        public abstract void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP2uiv")]
        public abstract unsafe void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP2uiv")]
        public abstract void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP3ui")]
        public abstract void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP3uiv")]
        public abstract unsafe void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP3uiv")]
        public abstract void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP4ui")]
        public abstract void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP4uiv")]
        public abstract unsafe void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP4uiv")]
        public abstract void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexP2ui")]
        public abstract void VertexP2([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexP2uiv")]
        public abstract unsafe void VertexP2([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexP2uiv")]
        public abstract void VertexP2([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexP3ui")]
        public abstract void VertexP3([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexP3uiv")]
        public abstract unsafe void VertexP3([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexP3uiv")]
        public abstract void VertexP3([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexP4ui")]
        public abstract void VertexP4([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexP4uiv")]
        public abstract unsafe void VertexP4([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexP4uiv")]
        public abstract void VertexP4([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindFragDataLocationIndexed")]
        public abstract void BindFragDataLocationIndexed([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorP3ui")]
        public abstract void ColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint color);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorP3uiv")]
        public abstract unsafe void ColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorP3uiv")]
        public abstract void ColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint color);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorP4ui")]
        public abstract void ColorP4([Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint color);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorP4uiv")]
        public abstract unsafe void ColorP4([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorP4uiv")]
        public abstract void ColorP4([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint color);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFragDataIndex")]
        public abstract int GetFragDataIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryObjecti64v")]
        public abstract unsafe void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryObjecti64v")]
        public abstract void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryObjectui64v")]
        public abstract unsafe void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] ulong* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryObjectui64v")]
        public abstract void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out ulong @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSamplerParameteriv")]
        public abstract unsafe void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSamplerParameteriv")]
        public abstract void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSamplerParameterfv")]
        public abstract unsafe void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSamplerParameterfv")]
        public abstract void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSamplerParameterIiv")]
        public abstract unsafe void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSamplerParameterIiv")]
        public abstract void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv")]
        public abstract unsafe void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv")]
        public abstract void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoordP1ui")]
        public abstract void MultiTexCoordP1([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv")]
        public abstract unsafe void MultiTexCoordP1([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv")]
        public abstract void MultiTexCoordP1([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoordP2ui")]
        public abstract void MultiTexCoordP2([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv")]
        public abstract unsafe void MultiTexCoordP2([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv")]
        public abstract void MultiTexCoordP2([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoordP3ui")]
        public abstract void MultiTexCoordP3([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv")]
        public abstract unsafe void MultiTexCoordP3([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv")]
        public abstract void MultiTexCoordP3([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoordP4ui")]
        public abstract void MultiTexCoordP4([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv")]
        public abstract unsafe void MultiTexCoordP4([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv")]
        public abstract void MultiTexCoordP4([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalP3ui")]
        public abstract void NormalP3([Flow(FlowDirection.In)] NormalPointerType type, [Flow(FlowDirection.In)] uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalP3uiv")]
        public abstract unsafe void NormalP3([Flow(FlowDirection.In)] NormalPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalP3uiv")]
        public abstract void NormalP3([Flow(FlowDirection.In)] NormalPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glQueryCounter")]
        public abstract void QueryCounter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryCounterTarget target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSamplerParameteri")]
        public abstract void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSamplerParameteriv")]
        public abstract unsafe void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSamplerParameteriv")]
        public abstract void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSamplerParameterf")]
        public abstract void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Flow(FlowDirection.In)] float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSamplerParameterfv")]
        public abstract unsafe void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSamplerParameterfv")]
        public abstract void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSamplerParameterIiv")]
        public abstract unsafe void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSamplerParameterIiv")]
        public abstract void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSamplerParameterIuiv")]
        public abstract unsafe void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSamplerParameterIuiv")]
        public abstract void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColorP3ui")]
        public abstract void SecondaryColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint color);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColorP3uiv")]
        public abstract unsafe void SecondaryColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColorP3uiv")]
        public abstract void SecondaryColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint color);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoordP1ui")]
        public abstract void TexCoordP1([Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoordP1uiv")]
        public abstract unsafe void TexCoordP1([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoordP1uiv")]
        public abstract void TexCoordP1([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoordP2ui")]
        public abstract void TexCoordP2([Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoordP2uiv")]
        public abstract unsafe void TexCoordP2([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoordP2uiv")]
        public abstract void TexCoordP2([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoordP3ui")]
        public abstract void TexCoordP3([Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoordP3uiv")]
        public abstract unsafe void TexCoordP3([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoordP3uiv")]
        public abstract void TexCoordP3([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoordP4ui")]
        public abstract void TexCoordP4([Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoordP4uiv")]
        public abstract unsafe void TexCoordP4([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoordP4uiv")]
        public abstract void TexCoordP4([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP1ui")]
        public abstract void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP1uiv")]
        public abstract unsafe void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP1uiv")]
        public abstract void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP2ui")]
        public abstract void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP2uiv")]
        public abstract unsafe void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP2uiv")]
        public abstract void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP3ui")]
        public abstract void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP3uiv")]
        public abstract unsafe void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP3uiv")]
        public abstract void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP4ui")]
        public abstract void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP4uiv")]
        public abstract unsafe void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP4uiv")]
        public abstract void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexP2ui")]
        public abstract void VertexP2([Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexP2uiv")]
        public abstract unsafe void VertexP2([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexP2uiv")]
        public abstract void VertexP2([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexP3ui")]
        public abstract void VertexP3([Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexP3uiv")]
        public abstract unsafe void VertexP3([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexP3uiv")]
        public abstract void VertexP3([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexP4ui")]
        public abstract void VertexP4([Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexP4uiv")]
        public abstract unsafe void VertexP4([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexP4uiv")]
        public abstract void VertexP4([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBeginQueryIndexed")]
        public abstract void BeginQueryIndexed([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint id);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindTransformFeedback")]
        public abstract void BindTransformFeedback([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint id);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendEquationi")]
        public abstract void BlendEquation([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] GLEnum mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendEquationSeparatei")]
        public abstract void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] GLEnum modeRGB, [Flow(FlowDirection.In)] GLEnum modeAlpha);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendFunci")]
        public abstract void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] GLEnum src, [Flow(FlowDirection.In)] GLEnum dst);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendFuncSeparatei")]
        public abstract void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] GLEnum srcRGB, [Flow(FlowDirection.In)] GLEnum dstRGB, [Flow(FlowDirection.In)] GLEnum srcAlpha, [Flow(FlowDirection.In)] GLEnum dstAlpha);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteTransformFeedbacks")]
        public abstract unsafe void DeleteTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteTransformFeedbacks")]
        public abstract void DeleteTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawArraysIndirect")]
        public abstract unsafe void DrawArraysIndirect([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] void* indirect);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawArraysIndirect")]
        public abstract void DrawArraysIndirect<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] Span<T0> indirect) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        public abstract unsafe void DrawElementsIndirect([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] void* indirect);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        public abstract void DrawElementsIndirect<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] Span<T0> indirect) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawTransformFeedback")]
        public abstract void DrawTransformFeedback([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint id);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawTransformFeedbackStream")]
        public abstract void DrawTransformFeedbackStream([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint stream);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEndQueryIndexed")]
        public abstract void EndQueryIndexed([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenTransformFeedbacks")]
        public abstract unsafe void GenTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenTransformFeedbacks")]
        public abstract void GenTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        public abstract unsafe void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        public abstract void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv")]
        public abstract unsafe void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv")]
        public abstract void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        public abstract unsafe void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        public abstract void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramStageiv")]
        public abstract unsafe void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramStageiv")]
        public abstract void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryIndexediv")]
        public abstract unsafe void GetQueryIndexed([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryIndexediv")]
        public abstract void GetQueryIndexed([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSubroutineIndex")]
        public abstract unsafe uint GetSubroutineIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSubroutineIndex")]
        public abstract uint GetSubroutineIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] Span<char> name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSubroutineUniformLocation")]
        public abstract unsafe int GetSubroutineUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSubroutineUniformLocation")]
        public abstract int GetSubroutineUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] Span<char> name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformdv")]
        public abstract unsafe void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] double* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformdv")]
        public abstract void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] out double @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformSubroutineuiv")]
        public abstract unsafe void GetUniformSubroutine([Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] int location, [Count(Count = 1), Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformSubroutineuiv")]
        public abstract void GetUniformSubroutine([Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] int location, [Count(Count = 1), Flow(FlowDirection.Out)] out uint @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsTransformFeedback")]
        public abstract bool IsTransformFeedback([Flow(FlowDirection.In)] uint id);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMinSampleShading")]
        public abstract void MinSampleShading([Flow(FlowDirection.In)] float value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPatchParameteri")]
        public abstract void PatchParameter([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPatchParameterfv")]
        public abstract unsafe void PatchParameter([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPatchParameterfv")]
        public abstract void PatchParameter([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPauseTransformFeedback")]
        public abstract void PauseTransformFeedback();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glResumeTransformFeedback")]
        public abstract void ResumeTransformFeedback();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform1d")]
        public abstract void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform1dv")]
        public abstract unsafe void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform1dv")]
        public abstract void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform2d")]
        public abstract void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform2dv")]
        public abstract unsafe void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform2dv")]
        public abstract void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform3d")]
        public abstract void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform3dv")]
        public abstract unsafe void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform3dv")]
        public abstract void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform4d")]
        public abstract void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform4dv")]
        public abstract unsafe void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform4dv")]
        public abstract void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix2dv")]
        public abstract unsafe void UniformMatrix2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix2dv")]
        public abstract void UniformMatrix2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix2x3dv")]
        public abstract unsafe void UniformMatrix2x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix2x3dv")]
        public abstract void UniformMatrix2x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix2x4dv")]
        public abstract unsafe void UniformMatrix2x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix2x4dv")]
        public abstract void UniformMatrix2x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix3dv")]
        public abstract unsafe void UniformMatrix3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix3dv")]
        public abstract void UniformMatrix3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix3x2dv")]
        public abstract unsafe void UniformMatrix3x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix3x2dv")]
        public abstract void UniformMatrix3x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix3x4dv")]
        public abstract unsafe void UniformMatrix3x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix3x4dv")]
        public abstract void UniformMatrix3x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix4dv")]
        public abstract unsafe void UniformMatrix4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix4dv")]
        public abstract void UniformMatrix4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix4x2dv")]
        public abstract unsafe void UniformMatrix4x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix4x2dv")]
        public abstract void UniformMatrix4x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix4x3dv")]
        public abstract unsafe void UniformMatrix4x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix4x3dv")]
        public abstract void UniformMatrix4x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformSubroutinesuiv")]
        public abstract unsafe void UniformSubroutines([Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* indices);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformSubroutinesuiv")]
        public abstract void UniformSubroutines([Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> indices);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBeginQueryIndexed")]
        public abstract void BeginQueryIndexed([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint id);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindTransformFeedback")]
        public abstract void BindTransformFeedback([Flow(FlowDirection.In)] BindTransformFeedbackTarget target, [Flow(FlowDirection.In)] uint id);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendEquationi")]
        public abstract void BlendEquation([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendEquationSeparatei")]
        public abstract void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendFunci")]
        public abstract void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor src, [Flow(FlowDirection.In)] BlendingFactor dst);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendFuncSeparatei")]
        public abstract void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawArraysIndirect")]
        public abstract unsafe void DrawArraysIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] void* indirect);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawArraysIndirect")]
        public abstract void DrawArraysIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] Span<T0> indirect) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        public abstract unsafe void DrawElementsIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] void* indirect);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        public abstract void DrawElementsIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] Span<T0> indirect) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawTransformFeedback")]
        public abstract void DrawTransformFeedback([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint id);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawTransformFeedbackStream")]
        public abstract void DrawTransformFeedbackStream([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint stream);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEndQueryIndexed")]
        public abstract void EndQueryIndexed([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        public abstract unsafe void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        public abstract void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv")]
        public abstract unsafe void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] SubroutineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv")]
        public abstract void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] SubroutineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        public abstract unsafe void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        public abstract void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramStageiv")]
        public abstract unsafe void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] ProgramStagePName pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramStageiv")]
        public abstract void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] ProgramStagePName pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryIndexediv")]
        public abstract unsafe void GetQueryIndexed([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryIndexediv")]
        public abstract void GetQueryIndexed([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSubroutineIndex")]
        public abstract uint GetSubroutineIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSubroutineUniformLocation")]
        public abstract int GetSubroutineUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformSubroutineuiv")]
        public abstract unsafe void GetUniformSubroutine([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] int location, [Count(Count = 1), Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformSubroutineuiv")]
        public abstract void GetUniformSubroutine([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] int location, [Count(Count = 1), Flow(FlowDirection.Out)] out uint @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPatchParameteri")]
        public abstract void PatchParameter([Flow(FlowDirection.In)] PatchParameterName pname, [Flow(FlowDirection.In)] int value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPatchParameterfv")]
        public abstract unsafe void PatchParameter([Flow(FlowDirection.In)] PatchParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPatchParameterfv")]
        public abstract void PatchParameter([Flow(FlowDirection.In)] PatchParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformSubroutinesuiv")]
        public abstract unsafe void UniformSubroutines([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* indices);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformSubroutinesuiv")]
        public abstract void UniformSubroutines([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> indices);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glActiveShaderProgram")]
        public abstract void ActiveShaderProgram([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint program);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindProgramPipeline")]
        public abstract void BindProgramPipeline([Flow(FlowDirection.In)] uint pipeline);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearDepthf")]
        public abstract void ClearDepth([Flow(FlowDirection.In)] float d);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateShaderProgramv")]
        public abstract unsafe uint CreateShaderProgram([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] char** strings);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteProgramPipelines")]
        public abstract unsafe void DeleteProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* pipelines);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteProgramPipelines")]
        public abstract void DeleteProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> pipelines);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDepthRangef")]
        public abstract void DepthRange([Flow(FlowDirection.In)] float n, [Flow(FlowDirection.In)] float f);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDepthRangeArrayv")]
        public abstract unsafe void DepthRangeArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] double* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDepthRangeArrayv")]
        public abstract void DepthRangeArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] ref double v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDepthRangeIndexed")]
        public abstract void DepthRangeIndexed([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double n, [Flow(FlowDirection.In)] double f);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenProgramPipelines")]
        public abstract unsafe void GenProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* pipelines);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenProgramPipelines")]
        public abstract void GenProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> pipelines);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetDoublei_v")]
        public abstract unsafe void GetDouble([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] double* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetDoublei_v")]
        public abstract void GetDouble([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out double data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFloati_v")]
        public abstract unsafe void GetFloat([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] float* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFloati_v")]
        public abstract void GetFloat([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out float data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramBinary")]
        public abstract unsafe void GetProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* binary);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramBinary")]
        public abstract void GetProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> binary) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramPipelineiv")]
        public abstract unsafe void GetProgramPipeline([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramPipelineiv")]
        public abstract void GetProgramPipeline([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLog")]
        public abstract unsafe void GetProgramPipelineInfoLog([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* infoLog);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLog")]
        public abstract void GetProgramPipelineInfoLog([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> infoLog);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public abstract unsafe void GetShaderPrecisionFormat([Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] GLEnum precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public abstract void GetShaderPrecisionFormat([Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] GLEnum precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] Span<int> range, [Count(Count = 1), Flow(FlowDirection.Out)] out int precision);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribLdv")]
        public abstract unsafe void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribLdv")]
        public abstract void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsProgramPipeline")]
        public abstract bool IsProgramPipeline([Flow(FlowDirection.In)] uint pipeline);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramBinary")]
        public abstract unsafe void ProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramBinary")]
        public abstract void ProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] Span<T0> binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramParameteri")]
        public abstract void ProgramParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform1i")]
        public abstract void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform1iv")]
        public abstract unsafe void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform1iv")]
        public abstract void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform1f")]
        public abstract void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform1fv")]
        public abstract unsafe void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform1fv")]
        public abstract void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform1d")]
        public abstract void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double v0);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform1dv")]
        public abstract unsafe void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform1dv")]
        public abstract void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform1ui")]
        public abstract void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform1uiv")]
        public abstract unsafe void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform1uiv")]
        public abstract void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform2i")]
        public abstract void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform2iv")]
        public abstract unsafe void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform2iv")]
        public abstract void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform2f")]
        public abstract void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform2fv")]
        public abstract unsafe void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform2fv")]
        public abstract void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform2d")]
        public abstract void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double v0, [Flow(FlowDirection.In)] double v1);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform2dv")]
        public abstract unsafe void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform2dv")]
        public abstract void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform2ui")]
        public abstract void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform2uiv")]
        public abstract unsafe void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform2uiv")]
        public abstract void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform3i")]
        public abstract void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform3iv")]
        public abstract unsafe void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform3iv")]
        public abstract void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform3f")]
        public abstract void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform3fv")]
        public abstract unsafe void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform3fv")]
        public abstract void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform3d")]
        public abstract void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double v0, [Flow(FlowDirection.In)] double v1, [Flow(FlowDirection.In)] double v2);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform3dv")]
        public abstract unsafe void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform3dv")]
        public abstract void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform3ui")]
        public abstract void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1, [Flow(FlowDirection.In)] uint v2);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform3uiv")]
        public abstract unsafe void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform3uiv")]
        public abstract void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform4i")]
        public abstract void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2, [Flow(FlowDirection.In)] int v3);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform4iv")]
        public abstract unsafe void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform4iv")]
        public abstract void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform4f")]
        public abstract void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] float v3);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform4fv")]
        public abstract unsafe void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform4fv")]
        public abstract void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform4d")]
        public abstract void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double v0, [Flow(FlowDirection.In)] double v1, [Flow(FlowDirection.In)] double v2, [Flow(FlowDirection.In)] double v3);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform4dv")]
        public abstract unsafe void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform4dv")]
        public abstract void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform4ui")]
        public abstract void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1, [Flow(FlowDirection.In)] uint v2, [Flow(FlowDirection.In)] uint v3);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform4uiv")]
        public abstract unsafe void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform4uiv")]
        public abstract void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix2fv")]
        public abstract unsafe void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix2fv")]
        public abstract void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix2dv")]
        public abstract unsafe void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix2dv")]
        public abstract void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3fv")]
        public abstract unsafe void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3fv")]
        public abstract void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3dv")]
        public abstract unsafe void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3dv")]
        public abstract void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4fv")]
        public abstract unsafe void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4fv")]
        public abstract void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4dv")]
        public abstract unsafe void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4dv")]
        public abstract void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix3fv")]
        public abstract unsafe void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix3fv")]
        public abstract void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix3dv")]
        public abstract unsafe void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix3dv")]
        public abstract void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2fv")]
        public abstract unsafe void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2fv")]
        public abstract void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2dv")]
        public abstract unsafe void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2dv")]
        public abstract void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4fv")]
        public abstract unsafe void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4fv")]
        public abstract void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4dv")]
        public abstract unsafe void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4dv")]
        public abstract void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix4fv")]
        public abstract unsafe void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix4fv")]
        public abstract void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix4dv")]
        public abstract unsafe void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix4dv")]
        public abstract void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2fv")]
        public abstract unsafe void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2fv")]
        public abstract void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2dv")]
        public abstract unsafe void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2dv")]
        public abstract void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3fv")]
        public abstract unsafe void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3fv")]
        public abstract void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3dv")]
        public abstract unsafe void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3dv")]
        public abstract void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glReleaseShaderCompiler")]
        public abstract void ReleaseShaderCompiler();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glScissorArrayv")]
        public abstract unsafe void ScissorArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] int* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glScissorArrayv")]
        public abstract void ScissorArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] ref int v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glScissorIndexed")]
        public abstract void ScissorIndexed([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int left, [Flow(FlowDirection.In)] int bottom, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glScissorIndexedv")]
        public abstract unsafe void ScissorIndexed([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glScissorIndexedv")]
        public abstract void ScissorIndexed([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glShaderBinary")]
        public abstract unsafe void ShaderBinary([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* shaders, [Flow(FlowDirection.In)] GLEnum binaryformat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glShaderBinary")]
        public abstract void ShaderBinary<T0>([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> shaders, [Flow(FlowDirection.In)] GLEnum binaryformat, [Count(Parameter = "length"), Flow(FlowDirection.In)] Span<T0> binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUseProgramStages")]
        public abstract void UseProgramStages([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint stages, [Flow(FlowDirection.In)] uint program);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glValidateProgramPipeline")]
        public abstract void ValidateProgramPipeline([Flow(FlowDirection.In)] uint pipeline);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL1d")]
        public abstract void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL1dv")]
        public abstract unsafe void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] double* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL1dv")]
        public abstract void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref double v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL2d")]
        public abstract void VertexAttribL2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL2dv")]
        public abstract unsafe void VertexAttribL2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] double* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL2dv")]
        public abstract void VertexAttribL2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<double> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL3d")]
        public abstract void VertexAttribL3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL3dv")]
        public abstract unsafe void VertexAttribL3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] double* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL3dv")]
        public abstract void VertexAttribL3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<double> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL4d")]
        public abstract void VertexAttribL4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL4dv")]
        public abstract unsafe void VertexAttribL4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] double* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL4dv")]
        public abstract void VertexAttribL4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribLPointer")]
        public abstract unsafe void VertexAttribLPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint stride, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* pointer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribLPointer")]
        public abstract void VertexAttribLPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint stride, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> pointer) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glViewportArrayv")]
        public abstract unsafe void ViewportArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] float* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glViewportArrayv")]
        public abstract void ViewportArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] ref float v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glViewportIndexedf")]
        public abstract void ViewportIndexed([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float w, [Flow(FlowDirection.In)] float h);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glViewportIndexedfv")]
        public abstract unsafe void ViewportIndexed([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glViewportIndexedfv")]
        public abstract void ViewportIndexed([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateShaderProgramv")]
        public abstract unsafe uint CreateShaderProgram([Flow(FlowDirection.In)] ShaderType type, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] char** strings);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramPipelineiv")]
        public abstract unsafe void GetProgramPipeline([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] PipelineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramPipelineiv")]
        public abstract void GetProgramPipeline([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] PipelineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLog")]
        public abstract unsafe void GetProgramPipelineInfoLog([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string infoLog);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLog")]
        public abstract void GetProgramPipelineInfoLog([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string infoLog);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public abstract unsafe void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public abstract void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] Span<int> range, [Count(Count = 1), Flow(FlowDirection.Out)] out int precision);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribLdv")]
        public abstract unsafe void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribLdv")]
        public abstract void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramParameteri")]
        public abstract void ProgramParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramParameterPName pname, [Flow(FlowDirection.In)] int value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribLPointer")]
        public abstract unsafe void VertexAttribLPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* pointer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribLPointer")]
        public abstract void VertexAttribLPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> pointer) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindImageTexture")]
        public abstract void BindImageTexture([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] GLEnum access, [Flow(FlowDirection.In)] GLEnum format);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawArraysInstancedBaseInstance")]
        public abstract void DrawArraysInstancedBaseInstance([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseInstance")]
        public abstract unsafe void DrawElementsInstancedBaseInstance([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Parameter = "count"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseInstance")]
        public abstract void DrawElementsInstancedBaseInstance<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance")]
        public abstract unsafe void DrawElementsInstancedBaseVertexBaseInstance([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Parameter = "count"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance")]
        public abstract void DrawElementsInstancedBaseVertexBaseInstance<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawTransformFeedbackInstanced")]
        public abstract void DrawTransformFeedbackInstanced([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint instancecount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawTransformFeedbackStreamInstanced")]
        public abstract void DrawTransformFeedbackStreamInstanced([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] uint instancecount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveAtomicCounterBufferiv")]
        public abstract unsafe void GetActiveAtomicCounterBuffer([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufferIndex, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveAtomicCounterBufferiv")]
        public abstract void GetActiveAtomicCounterBuffer([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufferIndex, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public abstract unsafe void GetInternalformat([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public abstract void GetInternalformat([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMemoryBarrier")]
        public abstract void MemoryBarrier([Flow(FlowDirection.In)] uint barriers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexStorage1D")]
        public abstract void TexStorage1D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexStorage2D")]
        public abstract void TexStorage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexStorage3D")]
        public abstract void TexStorage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindImageTexture")]
        public abstract void BindImageTexture([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] BufferAccessARB access, [Flow(FlowDirection.In)] InternalFormat format);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawArraysInstancedBaseInstance")]
        public abstract void DrawArraysInstancedBaseInstance([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseInstance")]
        public abstract unsafe void DrawElementsInstancedBaseInstance([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PrimitiveType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseInstance")]
        public abstract void DrawElementsInstancedBaseInstance<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PrimitiveType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance")]
        public abstract unsafe void DrawElementsInstancedBaseVertexBaseInstance([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance")]
        public abstract void DrawElementsInstancedBaseVertexBaseInstance<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawTransformFeedbackInstanced")]
        public abstract void DrawTransformFeedbackInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint instancecount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawTransformFeedbackStreamInstanced")]
        public abstract void DrawTransformFeedbackStreamInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] uint instancecount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveAtomicCounterBufferiv")]
        public abstract unsafe void GetActiveAtomicCounterBuffer([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufferIndex, [Flow(FlowDirection.In)] AtomicCounterBufferPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveAtomicCounterBufferiv")]
        public abstract void GetActiveAtomicCounterBuffer([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufferIndex, [Flow(FlowDirection.In)] AtomicCounterBufferPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public abstract unsafe void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public abstract void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexStorage1D")]
        public abstract void TexStorage1D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexStorage2D")]
        public abstract void TexStorage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexStorage3D")]
        public abstract void TexStorage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindVertexBuffer")]
        public abstract void BindVertexBuffer([Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] uint stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearBufferData")]
        public abstract unsafe void ClearBufferData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearBufferData")]
        public abstract void ClearBufferData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearBufferSubData")]
        public abstract unsafe void ClearBufferSubData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearBufferSubData")]
        public abstract void ClearBufferSubData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyImageSubData")]
        public abstract void CopyImageSubData([Flow(FlowDirection.In)] uint srcName, [Flow(FlowDirection.In)] GLEnum srcTarget, [Flow(FlowDirection.In)] int srcLevel, [Flow(FlowDirection.In)] int srcX, [Flow(FlowDirection.In)] int srcY, [Flow(FlowDirection.In)] int srcZ, [Flow(FlowDirection.In)] uint dstName, [Flow(FlowDirection.In)] GLEnum dstTarget, [Flow(FlowDirection.In)] int dstLevel, [Flow(FlowDirection.In)] int dstX, [Flow(FlowDirection.In)] int dstY, [Flow(FlowDirection.In)] int dstZ, [Flow(FlowDirection.In)] uint srcWidth, [Flow(FlowDirection.In)] uint srcHeight, [Flow(FlowDirection.In)] uint srcDepth);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDebugMessageCallback")]
        public abstract unsafe void DebugMessageCallback([Flow(FlowDirection.In), Ultz.SuperInvoke.InteropServices.PinObjectAttribute(Ultz.SuperInvoke.InteropServices.PinMode.UntilNextCall)] DebugProc callback, [Flow(FlowDirection.In)] void* userParam);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDebugMessageCallback")]
        public abstract void DebugMessageCallback<T0>([Flow(FlowDirection.In), Ultz.SuperInvoke.InteropServices.PinObjectAttribute(Ultz.SuperInvoke.InteropServices.PinMode.UntilNextCall)] DebugProc callback, [Flow(FlowDirection.In)] Span<T0> userParam) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public abstract unsafe void DebugMessageControl([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public abstract void DebugMessageControl([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> ids, [Flow(FlowDirection.In)] bool enabled);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public abstract unsafe void DebugMessageInsert([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] char* buf);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public abstract void DebugMessageInsert([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] ref char buf);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDispatchCompute")]
        public abstract void DispatchCompute([Flow(FlowDirection.In)] uint num_groups_x, [Flow(FlowDirection.In)] uint num_groups_y, [Flow(FlowDirection.In)] uint num_groups_z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDispatchComputeIndirect")]
        public abstract void DispatchComputeIndirect([Flow(FlowDirection.In)] IntPtr indirect);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferParameteri")]
        public abstract void FramebufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public abstract unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* messageLog);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public abstract uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> messageLog);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        public abstract unsafe void GetFramebufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        public abstract void GetFramebufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetInternalformati64v")]
        public abstract unsafe void GetInternalformat([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] long* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetInternalformati64v")]
        public abstract void GetInternalformat([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<long> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetObjectLabel")]
        public abstract unsafe void GetObjectLabel([Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* label);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetObjectLabel")]
        public abstract void GetObjectLabel([Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> label);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        public abstract unsafe void GetObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* label);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        public abstract void GetObjectPtrLabel<T0>([Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> label) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        public abstract unsafe void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        public abstract void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public abstract unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] GLEnum* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public abstract void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] Span<GLEnum> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramResourceIndex")]
        public abstract unsafe uint GetProgramResourceIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramResourceIndex")]
        public abstract uint GetProgramResourceIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ref char name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramResourceLocation")]
        public abstract unsafe int GetProgramResourceLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramResourceLocation")]
        public abstract int GetProgramResourceLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ref char name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndex")]
        public abstract unsafe int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndex")]
        public abstract int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ref char name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        public abstract unsafe void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        public abstract void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInvalidateBufferData")]
        public abstract void InvalidateBufferData([Flow(FlowDirection.In)] uint buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInvalidateBufferSubData")]
        public abstract void InvalidateBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInvalidateFramebuffer")]
        public abstract unsafe void InvalidateFramebuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] GLEnum* attachments);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInvalidateFramebuffer")]
        public abstract void InvalidateFramebuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] Span<GLEnum> attachments);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer")]
        public abstract unsafe void InvalidateSubFramebuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] GLEnum* attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer")]
        public abstract void InvalidateSubFramebuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] Span<GLEnum> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInvalidateTexImage")]
        public abstract void InvalidateTexImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInvalidateTexSubImage")]
        public abstract void InvalidateTexSubImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirect")]
        public abstract unsafe void MultiDrawArraysIndirect([Flow(FlowDirection.In)] GLEnum mode, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirect")]
        public abstract void MultiDrawArraysIndirect<T0>([Flow(FlowDirection.In)] GLEnum mode, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] ref T0 indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirect")]
        public abstract unsafe void MultiDrawElementsIndirect([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirect")]
        public abstract void MultiDrawElementsIndirect<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] ref T0 indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glObjectLabel")]
        public abstract unsafe void ObjectLabel([Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] char* label);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glObjectLabel")]
        public abstract void ObjectLabel([Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] ref char label);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glObjectPtrLabel")]
        public abstract unsafe void ObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] char* label);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glObjectPtrLabel")]
        public abstract void ObjectPtrLabel<T0>([Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] ref char label) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPopDebugGroup")]
        public abstract void PopDebugGroup();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPushDebugGroup")]
        public abstract unsafe void PushDebugGroup([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Count(Computed = "message, length"), Flow(FlowDirection.In)] char* message);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPushDebugGroup")]
        public abstract void PushDebugGroup([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Count(Computed = "message, length"), Flow(FlowDirection.In)] ref char message);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glShaderStorageBlockBinding")]
        public abstract void ShaderStorageBlockBinding([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint storageBlockIndex, [Flow(FlowDirection.In)] uint storageBlockBinding);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexBufferRange")]
        public abstract void TexBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexStorage2DMultisample")]
        public abstract void TexStorage2DMultisample([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexStorage3DMultisample")]
        public abstract void TexStorage3DMultisample([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureView")]
        public abstract void TextureView([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint origtexture, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint minlevel, [Flow(FlowDirection.In)] uint numlevels, [Flow(FlowDirection.In)] uint minlayer, [Flow(FlowDirection.In)] uint numlayers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribBinding")]
        public abstract void VertexAttribBinding([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] uint bindingindex);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribFormat")]
        public abstract void VertexAttribFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribIFormat")]
        public abstract void VertexAttribIFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint relativeoffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribLFormat")]
        public abstract void VertexAttribLFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint relativeoffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexBindingDivisor")]
        public abstract void VertexBindingDivisor([Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint divisor);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearBufferData")]
        public abstract unsafe void ClearBufferData([Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearBufferData")]
        public abstract void ClearBufferData<T0>([Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearBufferSubData")]
        public abstract unsafe void ClearBufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearBufferSubData")]
        public abstract void ClearBufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyImageSubData")]
        public abstract void CopyImageSubData([Flow(FlowDirection.In)] uint srcName, [Flow(FlowDirection.In)] CopyImageSubDataTarget srcTarget, [Flow(FlowDirection.In)] int srcLevel, [Flow(FlowDirection.In)] int srcX, [Flow(FlowDirection.In)] int srcY, [Flow(FlowDirection.In)] int srcZ, [Flow(FlowDirection.In)] uint dstName, [Flow(FlowDirection.In)] CopyImageSubDataTarget dstTarget, [Flow(FlowDirection.In)] int dstLevel, [Flow(FlowDirection.In)] int dstX, [Flow(FlowDirection.In)] int dstY, [Flow(FlowDirection.In)] int dstZ, [Flow(FlowDirection.In)] uint srcWidth, [Flow(FlowDirection.In)] uint srcHeight, [Flow(FlowDirection.In)] uint srcDepth);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public abstract unsafe void DebugMessageControl([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public abstract void DebugMessageControl([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> ids, [Flow(FlowDirection.In)] bool enabled);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public abstract void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string buf);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFramebufferParameteri")]
        public abstract void FramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferParameterName pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public abstract unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -6)] out string messageLog);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public abstract uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -6)] out string messageLog);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        public abstract unsafe void GetFramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        public abstract void GetFramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetInternalformati64v")]
        public abstract unsafe void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] long* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetInternalformati64v")]
        public abstract void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<long> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetObjectLabel")]
        public abstract unsafe void GetObjectLabel([Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string label);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetObjectLabel")]
        public abstract void GetObjectLabel([Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string label);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        public abstract unsafe void GetObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string label);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        public abstract void GetObjectPtrLabel<T0>([Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string label) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        public abstract unsafe void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] ProgramInterfacePName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        public abstract void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] ProgramInterfacePName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public abstract unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public abstract void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] Span<ProgramResourceProperty> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramResourceIndex")]
        public abstract uint GetProgramResourceIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramResourceLocation")]
        public abstract int GetProgramResourceLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndex")]
        public abstract int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        public abstract unsafe void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        public abstract void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInvalidateFramebuffer")]
        public abstract unsafe void InvalidateFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] InvalidateFramebufferAttachment* attachments);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInvalidateFramebuffer")]
        public abstract void InvalidateFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] Span<InvalidateFramebufferAttachment> attachments);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer")]
        public abstract unsafe void InvalidateSubFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] InvalidateFramebufferAttachment* attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer")]
        public abstract void InvalidateSubFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] Span<InvalidateFramebufferAttachment> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirect")]
        public abstract unsafe void MultiDrawArraysIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirect")]
        public abstract void MultiDrawArraysIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] ref T0 indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirect")]
        public abstract unsafe void MultiDrawElementsIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirect")]
        public abstract void MultiDrawElementsIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] ref T0 indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glObjectLabel")]
        public abstract void ObjectLabel([Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string label);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glObjectPtrLabel")]
        public abstract unsafe void ObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string label);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glObjectPtrLabel")]
        public abstract void ObjectPtrLabel<T0>([Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string label) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPushDebugGroup")]
        public abstract void PushDebugGroup([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string message);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexBufferRange")]
        public abstract void TexBufferRange([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexStorage2DMultisample")]
        public abstract void TexStorage2DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexStorage3DMultisample")]
        public abstract void TexStorage3DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureView")]
        public abstract void TextureView([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint origtexture, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint minlevel, [Flow(FlowDirection.In)] uint numlevels, [Flow(FlowDirection.In)] uint minlayer, [Flow(FlowDirection.In)] uint numlayers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribFormat")]
        public abstract void VertexAttribFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribIFormat")]
        public abstract void VertexAttribIFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribIType type, [Flow(FlowDirection.In)] uint relativeoffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribLFormat")]
        public abstract void VertexAttribLFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribLType type, [Flow(FlowDirection.In)] uint relativeoffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public abstract unsafe void BindBuffersBase([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public abstract void BindBuffersBase([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> buffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public abstract unsafe void BindBuffersRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] IntPtr* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] UIntPtr* sizes);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public abstract void BindBuffersRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<IntPtr> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<UIntPtr> sizes);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindImageTextures")]
        public abstract unsafe void BindImageTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* textures);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindImageTextures")]
        public abstract void BindImageTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> textures);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindSamplers")]
        public abstract unsafe void BindSamplers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* samplers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindSamplers")]
        public abstract void BindSamplers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> samplers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindTextures")]
        public abstract unsafe void BindTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* textures);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindTextures")]
        public abstract void BindTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> textures);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public abstract unsafe void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] IntPtr* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public abstract void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<IntPtr> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> strides);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBufferStorage")]
        public abstract unsafe void BufferStorage([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBufferStorage")]
        public abstract void BufferStorage<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearTexImage")]
        public abstract unsafe void ClearTexImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearTexImage")]
        public abstract void ClearTexImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearTexSubImage")]
        public abstract unsafe void ClearTexSubImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearTexSubImage")]
        public abstract void ClearTexSubImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public abstract unsafe void BindBuffersBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public abstract void BindBuffersBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> buffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public abstract unsafe void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] IntPtr* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] UIntPtr* sizes);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public abstract void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<IntPtr> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<UIntPtr> sizes);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBufferStorage")]
        public abstract unsafe void BufferStorage([Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBufferStorage")]
        public abstract void BufferStorage<T0>([Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearTexImage")]
        public abstract unsafe void ClearTexImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearTexImage")]
        public abstract void ClearTexImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearTexSubImage")]
        public abstract unsafe void ClearTexSubImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearTexSubImage")]
        public abstract void ClearTexSubImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindTextureUnit")]
        public abstract void BindTextureUnit([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint texture);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlitNamedFramebuffer")]
        public abstract void BlitNamedFramebuffer([Flow(FlowDirection.In)] uint readFramebuffer, [Flow(FlowDirection.In)] uint drawFramebuffer, [Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] GLEnum filter);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCheckNamedFramebufferStatus")]
        public abstract GLEnum CheckNamedFramebufferStatus([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedBufferData")]
        public abstract unsafe void ClearNamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedBufferData")]
        public abstract void ClearNamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedBufferSubData")]
        public abstract unsafe void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedBufferSubData")]
        public abstract void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedFramebufferiv")]
        public abstract unsafe void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] int* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedFramebufferiv")]
        public abstract void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<int> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedFramebufferuiv")]
        public abstract unsafe void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedFramebufferuiv")]
        public abstract void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<uint> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedFramebufferfv")]
        public abstract unsafe void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedFramebufferfv")]
        public abstract void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedFramebufferfi")]
        public abstract void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float depth, [Flow(FlowDirection.In)] int stencil);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClipControl")]
        public abstract void ClipControl([Flow(FlowDirection.In)] GLEnum origin, [Flow(FlowDirection.In)] GLEnum depth);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage1D")]
        public abstract unsafe void CompressedTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage1D")]
        public abstract void CompressedTextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage2D")]
        public abstract unsafe void CompressedTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage2D")]
        public abstract void CompressedTextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage3D")]
        public abstract unsafe void CompressedTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage3D")]
        public abstract void CompressedTextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyNamedBufferSubData")]
        public abstract void CopyNamedBufferSubData([Flow(FlowDirection.In)] uint readBuffer, [Flow(FlowDirection.In)] uint writeBuffer, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyTextureSubImage1D")]
        public abstract void CopyTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyTextureSubImage2D")]
        public abstract void CopyTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyTextureSubImage3D")]
        public abstract void CopyTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateBuffers")]
        public abstract unsafe void CreateBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* buffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateBuffers")]
        public abstract void CreateBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> buffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateFramebuffers")]
        public abstract unsafe void CreateFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* framebuffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateFramebuffers")]
        public abstract void CreateFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> framebuffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateProgramPipelines")]
        public abstract unsafe void CreateProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* pipelines);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateProgramPipelines")]
        public abstract void CreateProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> pipelines);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateQueries")]
        public abstract unsafe void CreateQueries([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateQueries")]
        public abstract void CreateQueries([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateRenderbuffers")]
        public abstract unsafe void CreateRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* renderbuffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateRenderbuffers")]
        public abstract void CreateRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> renderbuffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateSamplers")]
        public abstract unsafe void CreateSamplers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* samplers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateSamplers")]
        public abstract void CreateSamplers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> samplers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateTextures")]
        public abstract unsafe void CreateTextures([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* textures);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateTextures")]
        public abstract void CreateTextures([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> textures);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateTransformFeedbacks")]
        public abstract unsafe void CreateTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateTransformFeedbacks")]
        public abstract void CreateTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateVertexArrays")]
        public abstract unsafe void CreateVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* arrays);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateVertexArrays")]
        public abstract void CreateVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> arrays);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDisableVertexArrayAttrib")]
        public abstract void DisableVertexArrayAttrib([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEnableVertexArrayAttrib")]
        public abstract void EnableVertexArrayAttrib([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFlushMappedNamedBufferRange")]
        public abstract void FlushMappedNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenerateTextureMipmap")]
        public abstract void GenerateTextureMipmap([Flow(FlowDirection.In)] uint texture);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetCompressedTextureImage")]
        public abstract unsafe void GetCompressedTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetCompressedTextureImage")]
        public abstract void GetCompressedTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetCompressedTextureSubImage")]
        public abstract unsafe void GetCompressedTextureSubImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetCompressedTextureSubImage")]
        public abstract void GetCompressedTextureSubImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetGraphicsResetStatus")]
        public abstract GLEnum GetGraphicsResetStatus();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferParameteriv")]
        public abstract unsafe void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferParameteriv")]
        public abstract void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferParameteri64v")]
        public abstract unsafe void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] long* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferParameteri64v")]
        public abstract void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<long> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferPointerv")]
        public abstract unsafe void GetNamedBufferPointer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] void** @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferSubData")]
        public abstract unsafe void GetNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferSubData")]
        public abstract void GetNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv")]
        public abstract unsafe void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv")]
        public abstract void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedFramebufferParameteriv")]
        public abstract unsafe void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedFramebufferParameteriv")]
        public abstract void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<int> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameteriv")]
        public abstract unsafe void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameteriv")]
        public abstract void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnColorTable")]
        public abstract unsafe void GetnColorTable([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* table);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnColorTable")]
        public abstract void GetnColorTable<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> table) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnCompressedTexImage")]
        public abstract unsafe void GetnCompressedTexImage([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int lod, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnCompressedTexImage")]
        public abstract void GetnCompressedTexImage<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int lod, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnConvolutionFilter")]
        public abstract unsafe void GetnConvolutionFilter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* image);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnConvolutionFilter")]
        public abstract void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnHistogram")]
        public abstract unsafe void GetnHistogram([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnHistogram")]
        public abstract void GetnHistogram<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnMapdv")]
        public abstract unsafe void GetnMap([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] double* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnMapdv")]
        public abstract void GetnMap([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<double> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnMapfv")]
        public abstract unsafe void GetnMap([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] float* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnMapfv")]
        public abstract void GetnMap([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<float> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnMapiv")]
        public abstract unsafe void GetnMap([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] int* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnMapiv")]
        public abstract void GetnMap([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<int> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnMinmax")]
        public abstract unsafe void GetnMinmax([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnMinmax")]
        public abstract void GetnMinmax<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnPixelMapfv")]
        public abstract unsafe void GetnPixelMap([Flow(FlowDirection.In)] GLEnum map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] float* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnPixelMapfv")]
        public abstract void GetnPixelMap([Flow(FlowDirection.In)] GLEnum map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<float> values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnPixelMapuiv")]
        public abstract unsafe void GetnPixelMap([Flow(FlowDirection.In)] GLEnum map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] uint* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnPixelMapuiv")]
        public abstract void GetnPixelMap([Flow(FlowDirection.In)] GLEnum map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<uint> values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnPixelMapusv")]
        public abstract unsafe void GetnPixelMap([Flow(FlowDirection.In)] GLEnum map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] ushort* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnPixelMapusv")]
        public abstract void GetnPixelMap([Flow(FlowDirection.In)] GLEnum map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<ushort> values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnPolygonStipple")]
        public abstract unsafe void GetnPolygonStipple([Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] byte* pattern);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnPolygonStipple")]
        public abstract void GetnPolygonStipple([Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<byte> pattern);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnSeparableFilter")]
        public abstract unsafe void GetnSeparableFilter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint rowBufSize, [Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Flow(FlowDirection.Out)] void* column, [Flow(FlowDirection.Out)] void* span);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnSeparableFilter")]
        public abstract void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint rowBufSize, [Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Flow(FlowDirection.Out)] Span<T1> column, [Flow(FlowDirection.Out)] Span<T2> span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnTexImage")]
        public abstract unsafe void GetnTexImage([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnTexImage")]
        public abstract void GetnTexImage<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnUniformdv")]
        public abstract unsafe void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] double* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnUniformdv")]
        public abstract void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<double> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnUniformfv")]
        public abstract unsafe void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnUniformfv")]
        public abstract void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<float> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnUniformiv")]
        public abstract unsafe void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnUniformiv")]
        public abstract void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnUniformuiv")]
        public abstract unsafe void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnUniformuiv")]
        public abstract void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<uint> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryBufferObjecti64v")]
        public abstract void GetQueryBufferObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] IntPtr offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureImage")]
        public abstract unsafe void GetTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureImage")]
        public abstract void GetTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureLevelParameterfv")]
        public abstract unsafe void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureLevelParameterfv")]
        public abstract void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<float> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureLevelParameteriv")]
        public abstract unsafe void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureLevelParameteriv")]
        public abstract void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterfv")]
        public abstract unsafe void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterfv")]
        public abstract void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<float> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameteriv")]
        public abstract unsafe void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameteriv")]
        public abstract void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterIiv")]
        public abstract unsafe void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterIiv")]
        public abstract void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterIuiv")]
        public abstract unsafe void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterIuiv")]
        public abstract void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<uint> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureSubImage")]
        public abstract unsafe void GetTextureSubImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureSubImage")]
        public abstract void GetTextureSubImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTransformFeedbackiv")]
        public abstract unsafe void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTransformFeedbackiv")]
        public abstract void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<int> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTransformFeedbacki_v")]
        public abstract unsafe void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTransformFeedbacki_v")]
        public abstract void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] Span<int> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTransformFeedbacki64_v")]
        public abstract unsafe void GetTransformFeedbacki64_([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] long* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTransformFeedbacki64_v")]
        public abstract void GetTransformFeedbacki64_([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] Span<long> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayiv")]
        public abstract unsafe void GetVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayiv")]
        public abstract void GetVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<int> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayIndexediv")]
        public abstract unsafe void GetVertexArrayIndexed([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayIndexediv")]
        public abstract void GetVertexArrayIndexed([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<int> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayIndexed64iv")]
        public abstract unsafe void GetVertexArrayIndexed64([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] long* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayIndexed64iv")]
        public abstract void GetVertexArrayIndexed64([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<long> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferData")]
        public abstract unsafe void InvalidateNamedFramebufferData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] GLEnum* attachments);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferData")]
        public abstract void InvalidateNamedFramebufferData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] Span<GLEnum> attachments);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferSubData")]
        public abstract unsafe void InvalidateNamedFramebufferSubData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] GLEnum* attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferSubData")]
        public abstract void InvalidateNamedFramebufferSubData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] Span<GLEnum> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMapNamedBuffer")]
        public abstract unsafe void* MapNamedBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum access);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMapNamedBufferRange")]
        public abstract unsafe void* MapNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length, [Flow(FlowDirection.In)] uint access);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMemoryBarrierByRegion")]
        public abstract void MemoryBarrierByRegion([Flow(FlowDirection.In)] uint barriers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedBufferData")]
        public abstract unsafe void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] GLEnum usage);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedBufferData")]
        public abstract void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] GLEnum usage) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedBufferStorage")]
        public abstract unsafe void NamedBufferStorage([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedBufferStorage")]
        public abstract void NamedBufferStorage<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedBufferSubData")]
        public abstract unsafe void NamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Computed = "size"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedBufferSubData")]
        public abstract void NamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Computed = "size"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffer")]
        public abstract void NamedFramebufferDrawBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum buf);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffers")]
        public abstract unsafe void NamedFramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] GLEnum* bufs);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffers")]
        public abstract void NamedFramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] Span<GLEnum> bufs);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferParameteri")]
        public abstract void NamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferReadBuffer")]
        public abstract void NamedFramebufferReadBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum src);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferRenderbuffer")]
        public abstract void NamedFramebufferRenderbuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferTexture")]
        public abstract void NamedFramebufferTexture([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferTextureLayer")]
        public abstract void NamedFramebufferTextureLayer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedRenderbufferStorage")]
        public abstract void NamedRenderbufferStorage([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisample")]
        public abstract void NamedRenderbufferStorageMultisample([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glReadnPixels")]
        public abstract unsafe void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glReadnPixels")]
        public abstract void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureBarrier")]
        public abstract void TextureBarrier();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureBuffer")]
        public abstract void TextureBuffer([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureBufferRange")]
        public abstract void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterf")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterfv")]
        public abstract unsafe void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterfv")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] Span<float> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameteri")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameteriv")]
        public abstract unsafe void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameteriv")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] Span<int> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterIiv")]
        public abstract unsafe void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterIiv")]
        public abstract void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterIuiv")]
        public abstract unsafe void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterIuiv")]
        public abstract void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] Span<uint> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage1D")]
        public abstract void TextureStorage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage2D")]
        public abstract void TextureStorage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage2DMultisample")]
        public abstract void TextureStorage2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage3D")]
        public abstract void TextureStorage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage3DMultisample")]
        public abstract void TextureStorage3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage1D")]
        public abstract unsafe void TextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage1D")]
        public abstract void TextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage2D")]
        public abstract unsafe void TextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage2D")]
        public abstract void TextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage3D")]
        public abstract unsafe void TextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage3D")]
        public abstract void TextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTransformFeedbackBufferBase")]
        public abstract void TransformFeedbackBufferBase([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTransformFeedbackBufferRange")]
        public abstract void TransformFeedbackBufferRange([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUnmapNamedBuffer")]
        public abstract bool UnmapNamedBuffer([Flow(FlowDirection.In)] uint buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayAttribBinding")]
        public abstract void VertexArrayAttribBinding([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] uint bindingindex);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayAttribFormat")]
        public abstract void VertexArrayAttribFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayAttribIFormat")]
        public abstract void VertexArrayAttribIFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint relativeoffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayAttribLFormat")]
        public abstract void VertexArrayAttribLFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint relativeoffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayBindingDivisor")]
        public abstract void VertexArrayBindingDivisor([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint divisor);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayElementBuffer")]
        public abstract void VertexArrayElementBuffer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayVertexBuffer")]
        public abstract void VertexArrayVertexBuffer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] uint stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayVertexBuffers")]
        public abstract unsafe void VertexArrayVertexBuffers([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] IntPtr* offsets, [Flow(FlowDirection.In)] uint* strides);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayVertexBuffers")]
        public abstract void VertexArrayVertexBuffers([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Span<uint> buffers, [Flow(FlowDirection.In)] Span<IntPtr> offsets, [Flow(FlowDirection.In)] Span<uint> strides);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlitNamedFramebuffer")]
        public abstract void BlitNamedFramebuffer([Flow(FlowDirection.In)] uint readFramebuffer, [Flow(FlowDirection.In)] uint drawFramebuffer, [Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] BlitFramebufferFilter filter);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCheckNamedFramebufferStatus")]
        public abstract GLEnum CheckNamedFramebufferStatus([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferTarget target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedBufferData")]
        public abstract unsafe void ClearNamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedBufferData")]
        public abstract void ClearNamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedBufferSubData")]
        public abstract unsafe void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedBufferSubData")]
        public abstract void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedFramebufferiv")]
        public abstract unsafe void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] int* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedFramebufferiv")]
        public abstract void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<int> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedFramebufferuiv")]
        public abstract unsafe void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedFramebufferuiv")]
        public abstract void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<uint> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedFramebufferfv")]
        public abstract unsafe void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedFramebufferfv")]
        public abstract void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedFramebufferfi")]
        public abstract void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float depth, [Flow(FlowDirection.In)] int stencil);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClipControl")]
        public abstract void ClipControl([Flow(FlowDirection.In)] ClipControlOrigin origin, [Flow(FlowDirection.In)] ClipControlDepth depth);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage1D")]
        public abstract unsafe void CompressedTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage1D")]
        public abstract void CompressedTextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage2D")]
        public abstract unsafe void CompressedTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage2D")]
        public abstract void CompressedTextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage3D")]
        public abstract unsafe void CompressedTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage3D")]
        public abstract void CompressedTextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateQueries")]
        public abstract unsafe void CreateQueries([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateQueries")]
        public abstract void CreateQueries([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateTextures")]
        public abstract unsafe void CreateTextures([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* textures);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateTextures")]
        public abstract void CreateTextures([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> textures);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferParameteriv")]
        public abstract unsafe void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] VertexBufferObjectParameter pname, [Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferParameteriv")]
        public abstract void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] VertexBufferObjectParameter pname, [Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferParameteri64v")]
        public abstract unsafe void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] VertexBufferObjectParameter pname, [Flow(FlowDirection.Out)] long* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferParameteri64v")]
        public abstract void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] VertexBufferObjectParameter pname, [Flow(FlowDirection.Out)] Span<long> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferPointerv")]
        public abstract unsafe void GetNamedBufferPointer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] VertexBufferObjectParameter pname, [Flow(FlowDirection.Out)] void** @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv")]
        public abstract unsafe void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv")]
        public abstract void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedFramebufferParameteriv")]
        public abstract unsafe void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GetFramebufferParameter pname, [Flow(FlowDirection.Out)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedFramebufferParameteriv")]
        public abstract void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GetFramebufferParameter pname, [Flow(FlowDirection.Out)] Span<int> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameteriv")]
        public abstract unsafe void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameteriv")]
        public abstract void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnColorTable")]
        public abstract unsafe void GetnColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* table);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnColorTable")]
        public abstract void GetnColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> table) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnCompressedTexImage")]
        public abstract unsafe void GetnCompressedTexImage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnCompressedTexImage")]
        public abstract void GetnCompressedTexImage<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnConvolutionFilter")]
        public abstract unsafe void GetnConvolutionFilter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* image);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnConvolutionFilter")]
        public abstract void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnHistogram")]
        public abstract unsafe void GetnHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnHistogram")]
        public abstract void GetnHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnMapdv")]
        public abstract unsafe void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] double* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnMapdv")]
        public abstract void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<double> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnMapfv")]
        public abstract unsafe void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] float* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnMapfv")]
        public abstract void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<float> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnMapiv")]
        public abstract unsafe void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] int* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnMapiv")]
        public abstract void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<int> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnMinmax")]
        public abstract unsafe void GetnMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnMinmax")]
        public abstract void GetnMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnPixelMapfv")]
        public abstract unsafe void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] float* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnPixelMapfv")]
        public abstract void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<float> values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnPixelMapuiv")]
        public abstract unsafe void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] uint* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnPixelMapuiv")]
        public abstract void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<uint> values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnPixelMapusv")]
        public abstract unsafe void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] ushort* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnPixelMapusv")]
        public abstract void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<ushort> values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnPolygonStipple")]
        public abstract void GetnPolygonStipple([Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] string pattern);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnSeparableFilter")]
        public abstract unsafe void GetnSeparableFilter([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Flow(FlowDirection.Out)] void* column, [Flow(FlowDirection.Out)] void* span);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnSeparableFilter")]
        public abstract void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Flow(FlowDirection.Out)] Span<T1> column, [Flow(FlowDirection.Out)] Span<T2> span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnTexImage")]
        public abstract unsafe void GetnTexImage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnTexImage")]
        public abstract void GetnTexImage<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryBufferObjecti64v")]
        public abstract void GetQueryBufferObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Flow(FlowDirection.In)] IntPtr offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureImage")]
        public abstract unsafe void GetTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureImage")]
        public abstract void GetTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureLevelParameterfv")]
        public abstract unsafe void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureLevelParameterfv")]
        public abstract void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<float> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureLevelParameteriv")]
        public abstract unsafe void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureLevelParameteriv")]
        public abstract void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterfv")]
        public abstract unsafe void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterfv")]
        public abstract void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<float> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameteriv")]
        public abstract unsafe void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameteriv")]
        public abstract void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterIiv")]
        public abstract unsafe void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterIiv")]
        public abstract void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterIuiv")]
        public abstract unsafe void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterIuiv")]
        public abstract void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<uint> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureSubImage")]
        public abstract unsafe void GetTextureSubImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureSubImage")]
        public abstract void GetTextureSubImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTransformFeedbackiv")]
        public abstract unsafe void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.Out)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTransformFeedbackiv")]
        public abstract void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.Out)] Span<int> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTransformFeedbacki_v")]
        public abstract unsafe void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTransformFeedbacki_v")]
        public abstract void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] Span<int> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTransformFeedbacki64_v")]
        public abstract unsafe void GetTransformFeedbacki64_([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] long* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTransformFeedbacki64_v")]
        public abstract void GetTransformFeedbacki64_([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] Span<long> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayiv")]
        public abstract unsafe void GetVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayiv")]
        public abstract void GetVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] Span<int> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayIndexediv")]
        public abstract unsafe void GetVertexArrayIndexed([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayIndexediv")]
        public abstract void GetVertexArrayIndexed([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] Span<int> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayIndexed64iv")]
        public abstract unsafe void GetVertexArrayIndexed64([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] long* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayIndexed64iv")]
        public abstract void GetVertexArrayIndexed64([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] Span<long> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferData")]
        public abstract unsafe void InvalidateNamedFramebufferData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] FramebufferAttachment* attachments);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferData")]
        public abstract void InvalidateNamedFramebufferData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] Span<FramebufferAttachment> attachments);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferSubData")]
        public abstract unsafe void InvalidateNamedFramebufferSubData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] FramebufferAttachment* attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferSubData")]
        public abstract void InvalidateNamedFramebufferSubData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] Span<FramebufferAttachment> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMapNamedBuffer")]
        public abstract unsafe void* MapNamedBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferAccessARB access);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedBufferData")]
        public abstract unsafe void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedBufferData")]
        public abstract void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffer")]
        public abstract void NamedFramebufferDrawBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ColorBuffer buf);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffers")]
        public abstract unsafe void NamedFramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] ColorBuffer* bufs);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffers")]
        public abstract void NamedFramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] Span<ColorBuffer> bufs);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferParameteri")]
        public abstract void NamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferParameterName pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferReadBuffer")]
        public abstract void NamedFramebufferReadBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ColorBuffer src);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferRenderbuffer")]
        public abstract void NamedFramebufferRenderbuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] RenderbufferTarget renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferTexture")]
        public abstract void NamedFramebufferTexture([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferTextureLayer")]
        public abstract void NamedFramebufferTextureLayer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedRenderbufferStorage")]
        public abstract void NamedRenderbufferStorage([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisample")]
        public abstract void NamedRenderbufferStorageMultisample([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glReadnPixels")]
        public abstract unsafe void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glReadnPixels")]
        public abstract void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureBuffer")]
        public abstract void TextureBuffer([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureBufferRange")]
        public abstract void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterf")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterfv")]
        public abstract unsafe void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] float* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterfv")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] Span<float> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameteri")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameteriv")]
        public abstract unsafe void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameteriv")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] Span<int> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterIiv")]
        public abstract unsafe void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterIiv")]
        public abstract void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterIuiv")]
        public abstract unsafe void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterIuiv")]
        public abstract void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] Span<uint> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage1D")]
        public abstract void TextureStorage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage2D")]
        public abstract void TextureStorage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage2DMultisample")]
        public abstract void TextureStorage2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage3D")]
        public abstract void TextureStorage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage3DMultisample")]
        public abstract void TextureStorage3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage1D")]
        public abstract unsafe void TextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage1D")]
        public abstract void TextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage2D")]
        public abstract unsafe void TextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage2D")]
        public abstract void TextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage3D")]
        public abstract unsafe void TextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage3D")]
        public abstract void TextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayAttribFormat")]
        public abstract void VertexArrayAttribFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayAttribIFormat")]
        public abstract void VertexArrayAttribIFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribIType type, [Flow(FlowDirection.In)] uint relativeoffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayAttribLFormat")]
        public abstract void VertexArrayAttribLFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribLType type, [Flow(FlowDirection.In)] uint relativeoffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectCount")]
        public abstract unsafe void MultiDrawArraysIndirectCount([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectCount")]
        public abstract void MultiDrawArraysIndirectCount<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectCount")]
        public abstract unsafe void MultiDrawElementsIndirectCount([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectCount")]
        public abstract void MultiDrawElementsIndirectCount<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPolygonOffsetClamp")]
        public abstract void PolygonOffsetClamp([Flow(FlowDirection.In)] float factor, [Flow(FlowDirection.In)] float units, [Flow(FlowDirection.In)] float clamp);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSpecializeShader")]
        public abstract unsafe void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] char* pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] uint* pConstantIndex, [Flow(FlowDirection.In)] uint* pConstantValue);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSpecializeShader")]
        public abstract void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] Span<char> pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] Span<uint> pConstantIndex, [Flow(FlowDirection.In)] Span<uint> pConstantValue);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectCount")]
        public abstract unsafe void MultiDrawArraysIndirectCount([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectCount")]
        public abstract void MultiDrawArraysIndirectCount<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectCount")]
        public abstract unsafe void MultiDrawElementsIndirectCount([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectCount")]
        public abstract void MultiDrawElementsIndirectCount<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSpecializeShader")]
        public abstract unsafe void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] string pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] uint* pConstantIndex, [Flow(FlowDirection.In)] uint* pConstantValue);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSpecializeShader")]
        public abstract void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] string pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] Span<uint> pConstantIndex, [Flow(FlowDirection.In)] Span<uint> pConstantValue);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        public unsafe bool GetBoolean([Flow(FlowDirection.In)] GLEnum pname)
        {
            // ReturnTypeOverloader
            bool ret = default;
            GetBoolean(pname, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        public unsafe double GetDouble([Flow(FlowDirection.In)] GLEnum pname)
        {
            // ReturnTypeOverloader
            double ret = default;
            GetDouble(pname, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        public unsafe float GetFloat([Flow(FlowDirection.In)] GLEnum pname)
        {
            // ReturnTypeOverloader
            float ret = default;
            GetFloat(pname, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        public unsafe int GetInteger([Flow(FlowDirection.In)] GLEnum pname)
        {
            // ReturnTypeOverloader
            int ret = default;
            GetInteger(pname, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        public unsafe bool GetBoolean([Flow(FlowDirection.In)] GetPName pname)
        {
            // ReturnTypeOverloader
            bool ret = default;
            GetBoolean(pname, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        public unsafe double GetDouble([Flow(FlowDirection.In)] GetPName pname)
        {
            // ReturnTypeOverloader
            double ret = default;
            GetDouble(pname, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        public unsafe float GetFloat([Flow(FlowDirection.In)] GetPName pname)
        {
            // ReturnTypeOverloader
            float ret = default;
            GetFloat(pname, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        public unsafe int GetInteger([Flow(FlowDirection.In)] GetPName pname)
        {
            // ReturnTypeOverloader
            int ret = default;
            GetInteger(pname, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="textures">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe void DeleteTexture([Count(Parameter = "n"), Flow(FlowDirection.In)] uint textures)
        {
            // ArrayParameterOverloader
            DeleteTextures(1, &textures);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="textures">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe uint GenTexture()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenTextures(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        public unsafe void BufferData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] GLEnum usage)
        {
            // IntPtrOverloader
            BufferData(target, new UIntPtr(size), data, usage);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        public unsafe void BufferData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] GLEnum usage) where T0 : unmanaged
        {
            // IntPtrOverloader
            BufferData(target, new UIntPtr(size), data, usage);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        public unsafe void BufferSubData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            BufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        public unsafe void BufferSubData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            BufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe void DeleteBuffer([Count(Parameter = "n"), Flow(FlowDirection.In)] uint buffers)
        {
            // ArrayParameterOverloader
            DeleteBuffers(1, &buffers);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe void DeleteQuery([Count(Parameter = "n"), Flow(FlowDirection.In)] uint ids)
        {
            // ArrayParameterOverloader
            DeleteQueries(1, &ids);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe uint GenBuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenBuffers(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe uint GenQuery()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenQueries(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        public unsafe void GetBufferSubData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] void* data)
        {
            // IntPtrOverloader
            GetBufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        public unsafe void GetBufferSubData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            GetBufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        public unsafe void BufferData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] BufferUsageARB usage)
        {
            // IntPtrOverloader
            BufferData(target, new UIntPtr(size), data, usage);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        public unsafe void BufferData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] BufferUsageARB usage) where T0 : unmanaged
        {
            // IntPtrOverloader
            BufferData(target, new UIntPtr(size), data, usage);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        public unsafe void BufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            BufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        public unsafe void BufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            BufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        public unsafe void GetBufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] void* data)
        {
            // IntPtrOverloader
            GetBufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        public unsafe void GetBufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            GetBufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shader">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@string">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        public unsafe void ShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] @stringSa, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* length)
        {
            // StringArrayOverloader
            var @string = (char**) SilkMarshal.MarshalStringArrayToPtr(@stringSa);
            ShaderSource(shader, count, @string, length);
            SilkMarshal.CopyPtrToStringArray((IntPtr) @string, @stringSa);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shader">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@string">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        public unsafe void ShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] @stringSa, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> length)
        {
            // StringArrayOverloader
            var @string = (char**) SilkMarshal.MarshalStringArrayToPtr(@stringSa);
            ShaderSource(shader, count, @string, length);
            SilkMarshal.CopyPtrToStringArray((IntPtr) @string, @stringSa);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        public unsafe void BindBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            BindBufferRange(target, index, buffer, new IntPtr(offset), new UIntPtr(size));
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
        /// <param name="arrays">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe void DeleteVertexArray([Count(Parameter = "n"), Flow(FlowDirection.In)] uint arrays)
        {
            // ArrayParameterOverloader
            DeleteVertexArrays(1, &arrays);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        public unsafe void FlushMappedBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length)
        {
            // IntPtrOverloader
            FlushMappedBufferRange(target, new IntPtr(offset), new UIntPtr(length));
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

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="arrays">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe uint GenVertexArray()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenVertexArrays(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="access">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        public unsafe void* MapBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] uint access)
        {
            // IntPtrOverloader
            return MapBufferRange(target, new IntPtr(offset), new UIntPtr(length), access);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="varyings">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="bufferMode">
        /// To be added.
        /// </param>
        public unsafe void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] varyingsSa, [Flow(FlowDirection.In)] GLEnum bufferMode)
        {
            // StringArrayOverloader
            var varyings = (char**) SilkMarshal.MarshalStringArrayToPtr(varyingsSa);
            TransformFeedbackVaryings(program, count, varyings, bufferMode);
            SilkMarshal.CopyPtrToStringArray((IntPtr) varyings, varyingsSa);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        public unsafe void BindBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            BindBufferRange(target, index, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        public unsafe void FlushMappedBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length)
        {
            // IntPtrOverloader
            FlushMappedBufferRange(target, new IntPtr(offset), new UIntPtr(length));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="access">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        public unsafe void* MapBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] uint access)
        {
            // IntPtrOverloader
            return MapBufferRange(target, new IntPtr(offset), new UIntPtr(length), access);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="varyings">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="bufferMode">
        /// To be added.
        /// </param>
        public unsafe void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] varyingsSa, [Flow(FlowDirection.In)] TransformFeedbackBufferMode bufferMode)
        {
            // StringArrayOverloader
            var varyings = (char**) SilkMarshal.MarshalStringArrayToPtr(varyingsSa);
            TransformFeedbackVaryings(program, count, varyings, bufferMode);
            SilkMarshal.CopyPtrToStringArray((IntPtr) varyings, varyingsSa);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="readTarget">
        /// To be added.
        /// </param>
        /// <param name="writeTarget">
        /// To be added.
        /// </param>
        /// <param name="readOffset">
        /// To be added.
        /// </param>
        /// <param name="writeOffset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        public unsafe void CopyBufferSubData([Flow(FlowDirection.In)] GLEnum readTarget, [Flow(FlowDirection.In)] GLEnum writeTarget, [Flow(FlowDirection.In)] int readOffset, [Flow(FlowDirection.In)] int writeOffset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            CopyBufferSubData(readTarget, writeTarget, new IntPtr(readOffset), new IntPtr(writeOffset), new UIntPtr(size));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="uniformCount">
        /// To be added.
        /// </param>
        /// <param name="uniformNames">
        /// To be added.
        /// This parameter's element count is computed from uniformCount.
        /// </param>
        /// <param name="uniformIndices">
        /// To be added.
        /// This parameter's element count is computed from uniformCount.
        /// </param>
        public unsafe void GetUniformIndices([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(FlowDirection.In)] string[] uniformNamesSa, [Count(Computed = "uniformCount"), Flow(FlowDirection.Out)] uint* uniformIndices)
        {
            // StringArrayOverloader
            var uniformNames = (char**) SilkMarshal.MarshalStringArrayToPtr(uniformNamesSa);
            GetUniformIndices(program, uniformCount, uniformNames, uniformIndices);
            SilkMarshal.CopyPtrToStringArray((IntPtr) uniformNames, uniformNamesSa);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="readTarget">
        /// To be added.
        /// </param>
        /// <param name="writeTarget">
        /// To be added.
        /// </param>
        /// <param name="readOffset">
        /// To be added.
        /// </param>
        /// <param name="writeOffset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        public unsafe void CopyBufferSubData([Flow(FlowDirection.In)] CopyBufferSubDataTarget readTarget, [Flow(FlowDirection.In)] CopyBufferSubDataTarget writeTarget, [Flow(FlowDirection.In)] int readOffset, [Flow(FlowDirection.In)] int writeOffset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            CopyBufferSubData(readTarget, writeTarget, new IntPtr(readOffset), new IntPtr(writeOffset), new UIntPtr(size));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        /// <param name="timeout">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        public unsafe GLEnum ClientWaitSync([Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] ulong timeout)
        {
            // IntPtrOverloader
            return ClientWaitSync(new IntPtr(sync), flags, timeout);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        public unsafe void DeleteSync([Flow(FlowDirection.In)] int sync)
        {
            // IntPtrOverloader
            DeleteSync(new IntPtr(sync));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        public unsafe long GetInteger64([Flow(FlowDirection.In)] GLEnum pname)
        {
            // ReturnTypeOverloader
            long ret = default;
            GetInteger64(pname, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        public unsafe void GetSync([Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values)
        {
            // IntPtrOverloader
            GetSync(new IntPtr(sync), pname, count, length, values);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        public unsafe void GetSync([Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // IntPtrOverloader
            GetSync(new IntPtr(sync), pname, count, out length, values);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        public unsafe bool IsSync([Flow(FlowDirection.In)] int sync)
        {
            // IntPtrOverloader
            return IsSync(new IntPtr(sync));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        /// <param name="timeout">
        /// To be added.
        /// </param>
        public unsafe void WaitSync([Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] ulong timeout)
        {
            // IntPtrOverloader
            WaitSync(new IntPtr(sync), flags, timeout);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        public unsafe long GetInteger64([Flow(FlowDirection.In)] GetPName pname)
        {
            // ReturnTypeOverloader
            long ret = default;
            GetInteger64(pname, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        public unsafe void GetSync([Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values)
        {
            // IntPtrOverloader
            GetSync(new IntPtr(sync), pname, count, length, values);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sync">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        public unsafe void GetSync([Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // IntPtrOverloader
            GetSync(new IntPtr(sync), pname, count, out length, values);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="samplers">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        public unsafe void DeleteSampler([Count(Parameter = "count"), Flow(FlowDirection.In)] uint samplers)
        {
            // ArrayParameterOverloader
            DeleteSamplers(1, &samplers);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="samplers">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        public unsafe uint GenSampler()
        {
            const uint count = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenSamplers(count, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe void DeleteTransformFeedback([Count(Parameter = "n"), Flow(FlowDirection.In)] uint ids)
        {
            // ArrayParameterOverloader
            DeleteTransformFeedbacks(1, &ids);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe uint GenTransformFeedback()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenTransformFeedbacks(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="strings">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <returns>See summary.</returns>
        public unsafe uint CreateShaderProgram([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] stringsSa)
        {
            // StringArrayOverloader
            var strings = (char**) SilkMarshal.MarshalStringArrayToPtr(stringsSa);
            var ret = CreateShaderProgram(type, count, strings);
            SilkMarshal.CopyPtrToStringArray((IntPtr) strings, stringsSa);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="pipelines">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe void DeleteProgramPipeline([Count(Parameter = "n"), Flow(FlowDirection.In)] uint pipelines)
        {
            // ArrayParameterOverloader
            DeleteProgramPipelines(1, &pipelines);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="pipelines">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe uint GenProgramPipeline()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenProgramPipelines(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="strings">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <returns>See summary.</returns>
        public unsafe uint CreateShaderProgram([Flow(FlowDirection.In)] ShaderType type, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] stringsSa)
        {
            // StringArrayOverloader
            var strings = (char**) SilkMarshal.MarshalStringArrayToPtr(stringsSa);
            var ret = CreateShaderProgram(type, count, strings);
            SilkMarshal.CopyPtrToStringArray((IntPtr) strings, stringsSa);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="bindingindex">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        public unsafe void BindVertexBuffer([Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            BindVertexBuffer(bindingindex, buffer, new IntPtr(offset), stride);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from format and type.
        /// </param>
        public unsafe void ClearBufferSubData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            ClearBufferSubData(target, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from format and type.
        /// </param>
        public unsafe void ClearBufferSubData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged
        {
            // IntPtrOverloader
            ClearBufferSubData(target, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, ref data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        public unsafe void DispatchComputeIndirect([Flow(FlowDirection.In)] int indirect)
        {
            // IntPtrOverloader
            DispatchComputeIndirect(new IntPtr(indirect));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        public unsafe void InvalidateBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length)
        {
            // IntPtrOverloader
            InvalidateBufferSubData(buffer, new IntPtr(offset), new UIntPtr(length));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        public unsafe void TexBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TexBufferRange(target, internalformat, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from format and type.
        /// </param>
        public unsafe void ClearBufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            ClearBufferSubData(target, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from format and type.
        /// </param>
        public unsafe void ClearBufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged
        {
            // IntPtrOverloader
            ClearBufferSubData(target, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, ref data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        public unsafe void TexBufferRange([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TexBufferRange(target, internalformat, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        public unsafe void BufferStorage([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags)
        {
            // IntPtrOverloader
            BufferStorage(target, new UIntPtr(size), data, flags);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        public unsafe void BufferStorage<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged
        {
            // IntPtrOverloader
            BufferStorage(target, new UIntPtr(size), data, flags);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        public unsafe void BufferStorage([Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags)
        {
            // IntPtrOverloader
            BufferStorage(target, new UIntPtr(size), data, flags);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        public unsafe void BufferStorage<T0>([Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged
        {
            // IntPtrOverloader
            BufferStorage(target, new UIntPtr(size), data, flags);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        public unsafe void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        public unsafe void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="readBuffer">
        /// To be added.
        /// </param>
        /// <param name="writeBuffer">
        /// To be added.
        /// </param>
        /// <param name="readOffset">
        /// To be added.
        /// </param>
        /// <param name="writeOffset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        public unsafe void CopyNamedBufferSubData([Flow(FlowDirection.In)] uint readBuffer, [Flow(FlowDirection.In)] uint writeBuffer, [Flow(FlowDirection.In)] int readOffset, [Flow(FlowDirection.In)] int writeOffset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            CopyNamedBufferSubData(readBuffer, writeBuffer, new IntPtr(readOffset), new IntPtr(writeOffset), new UIntPtr(size));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe uint CreateBuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateBuffers(n, &ret);
            return ret;
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
        public unsafe uint CreateFramebuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateFramebuffers(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="pipelines">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe uint CreateProgramPipeline()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateProgramPipelines(n, &ret);
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
        public unsafe uint CreateRenderbuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateRenderbuffers(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="samplers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe uint CreateSampler()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateSamplers(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe uint CreateTransformFeedback()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateTransformFeedbacks(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="arrays">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe uint CreateVertexArray()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateVertexArrays(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        public unsafe void FlushMappedNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length)
        {
            // IntPtrOverloader
            FlushMappedNamedBufferRange(buffer, new IntPtr(offset), new UIntPtr(length));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        public unsafe void GetNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] void* data)
        {
            // IntPtrOverloader
            GetNamedBufferSubData(buffer, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        public unsafe void GetNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            GetNamedBufferSubData(buffer, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="pattern">
        /// To be added.
        /// </param>
        public unsafe byte GetnPolygonStipple()
        {
            const uint bufSize = 1;
            // ReturnTypeOverloader
            byte ret = default;
            GetnPolygonStipple(bufSize, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void GetQueryBufferObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            GetQueryBufferObject(id, buffer, pname, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="access">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        public unsafe void* MapNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] uint access)
        {
            // IntPtrOverloader
            return MapNamedBufferRange(buffer, new IntPtr(offset), new UIntPtr(length), access);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        public unsafe void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] GLEnum usage)
        {
            // IntPtrOverloader
            NamedBufferData(buffer, new UIntPtr(size), data, usage);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        public unsafe void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] GLEnum usage) where T0 : unmanaged
        {
            // IntPtrOverloader
            NamedBufferData(buffer, new UIntPtr(size), data, usage);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        public unsafe void NamedBufferStorage([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags)
        {
            // IntPtrOverloader
            NamedBufferStorage(buffer, new UIntPtr(size), data, flags);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        public unsafe void NamedBufferStorage<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged
        {
            // IntPtrOverloader
            NamedBufferStorage(buffer, new UIntPtr(size), data, flags);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from size.
        /// </param>
        public unsafe void NamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Computed = "size"), Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            NamedBufferSubData(buffer, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from size.
        /// </param>
        public unsafe void NamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Computed = "size"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged
        {
            // IntPtrOverloader
            NamedBufferSubData(buffer, new IntPtr(offset), new UIntPtr(size), ref data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        public unsafe void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TextureBufferRange(texture, internalformat, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="xfb">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        public unsafe void TransformFeedbackBufferRange([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TransformFeedbackBufferRange(xfb, index, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="bindingindex">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        public unsafe void VertexArrayVertexBuffer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            VertexArrayVertexBuffer(vaobj, bindingindex, buffer, new IntPtr(offset), stride);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        public unsafe void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        public unsafe void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void GetQueryBufferObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            GetQueryBufferObject(id, buffer, pname, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        public unsafe void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage)
        {
            // IntPtrOverloader
            NamedBufferData(buffer, new UIntPtr(size), data, usage);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        public unsafe void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage) where T0 : unmanaged
        {
            // IntPtrOverloader
            NamedBufferData(buffer, new UIntPtr(size), data, usage);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        public unsafe void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TextureBufferRange(texture, internalformat, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="maxdrawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        public unsafe void MultiDrawArraysIndirectCount([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            MultiDrawArraysIndirectCount(mode, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="maxdrawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        public unsafe void MultiDrawArraysIndirectCount<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // IntPtrOverloader
            MultiDrawArraysIndirectCount(mode, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="maxdrawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        public unsafe void MultiDrawElementsIndirectCount([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            MultiDrawElementsIndirectCount(mode, type, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="maxdrawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        public unsafe void MultiDrawElementsIndirectCount<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // IntPtrOverloader
            MultiDrawElementsIndirectCount(mode, type, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="maxdrawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        public unsafe void MultiDrawArraysIndirectCount([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            MultiDrawArraysIndirectCount(mode, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="maxdrawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        public unsafe void MultiDrawArraysIndirectCount<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // IntPtrOverloader
            MultiDrawArraysIndirectCount(mode, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="maxdrawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        public unsafe void MultiDrawElementsIndirectCount([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            MultiDrawElementsIndirectCount(mode, type, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="maxdrawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        public unsafe void MultiDrawElementsIndirectCount<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // IntPtrOverloader
            MultiDrawElementsIndirectCount(mode, type, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        private SearchPathContainer _searchPaths;
        public override SearchPathContainer SearchPaths => _searchPaths ??= new GLCoreLibraryNameContainer();

        public GL(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }

        static GL()
        {
            LibraryLoader.CreateBuilder<GL>(Silk.NET.Core.Platform.SilkManager.Get<GLSymbolLoader>());
        }
    }
}

