// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_robustness")]
    public unsafe partial class ExtRobustness : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_robustness";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetGraphicsResetStatusEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public EXT GetGraphicsResetStatus()
            => ImplGetGraphicsResetStatus();

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
        [NativeApi(EntryPoint = "glGetnUniformfvEXT")]
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
        [NativeApi(EntryPoint = "glGetnUniformfvEXT")]
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
        [NativeApi(EntryPoint = "glGetnUniformivEXT")]
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
        [NativeApi(EntryPoint = "glGetnUniformivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<int> @params)
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
        [NativeApi(EntryPoint = "glReadnPixelsEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data)
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
        [NativeApi(EntryPoint = "glReadnPixelsEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
            => ImplReadnPixels<T0>(x, y, width, height, format, type, bufSize, data);

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
        [NativeApi(EntryPoint = "glReadnPixelsEXT")]
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
        [NativeApi(EntryPoint = "glReadnPixelsEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
            => ImplReadnPixels<T0>(x, y, width, height, format, type, bufSize, data);

        public ExtRobustness(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

