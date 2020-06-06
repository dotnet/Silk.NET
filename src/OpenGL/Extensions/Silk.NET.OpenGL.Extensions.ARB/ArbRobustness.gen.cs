// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_robustness")]
    public unsafe partial class ArbRobustness : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_robustness";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetGraphicsResetStatusARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public ARB GetGraphicsResetStatus()
            => ImplGetGraphicsResetStatus();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="lod">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="img">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnCompressedTexImageARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnCompressedTexImage([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int lod, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img)
            => ImplGetnCompressedTexImage(target, lod, bufSize, img);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="lod">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="img">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnCompressedTexImageARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnCompressedTexImage<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int lod, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
            => ImplGetnCompressedTexImage<T0>(target, lod, bufSize, img);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="img">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnTexImageARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnTexImage([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img)
            => ImplGetnTexImage(target, level, format, type, bufSize, img);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="img">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnTexImageARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnTexImage<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
            => ImplGetnTexImage<T0>(target, level, format, type, bufSize, img);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnUniformfvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetnUniform(program, location, bufSize, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnUniformfvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<float> @params)
            => ImplGetnUniform(program, location, bufSize, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnUniformivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetnUniform(program, location, bufSize, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnUniformivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<int> @params)
            => ImplGetnUniform(program, location, bufSize, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnUniformuivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] uint* @params)
            => ImplGetnUniform(program, location, bufSize, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnUniformuivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<uint> @params)
            => ImplGetnUniform(program, location, bufSize, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnUniformdvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] double* @params)
            => ImplGetnUniform(program, location, bufSize, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnUniformdvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<double> @params)
            => ImplGetnUniform(program, location, bufSize, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glReadnPixelsARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data)
            => ImplReadnPixels(x, y, width, height, format, type, bufSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glReadnPixelsARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
            => ImplReadnPixels<T0>(x, y, width, height, format, type, bufSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="lod">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="img">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnCompressedTexImageARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnCompressedTexImage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img)
            => ImplGetnCompressedTexImage(target, lod, bufSize, img);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="lod">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="img">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnCompressedTexImageARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnCompressedTexImage<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
            => ImplGetnCompressedTexImage<T0>(target, lod, bufSize, img);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="img">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnTexImageARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnTexImage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img)
            => ImplGetnTexImage(target, level, format, type, bufSize, img);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="img">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnTexImageARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnTexImage<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
            => ImplGetnTexImage<T0>(target, level, format, type, bufSize, img);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glReadnPixelsARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data)
            => ImplReadnPixels(x, y, width, height, format, type, bufSize, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glReadnPixelsARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
            => ImplReadnPixels<T0>(x, y, width, height, format, type, bufSize, data);

        public ArbRobustness(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

