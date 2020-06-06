// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_histogram")]
    public unsafe partial class ExtHistogram : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_histogram";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="reset">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetHistogramEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetHistogram([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values)
            => ImplGetHistogram(target, reset, format, type, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="reset">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetHistogramEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetHistogram<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged
            => ImplGetHistogram<T0>(target, reset, format, type, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetHistogramParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetHistogramParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetHistogramParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetHistogramParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetHistogramParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetHistogramParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetHistogramParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetHistogramParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetHistogramParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetHistogramParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetHistogramParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetHistogramParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="reset">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetMinmaxEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMinmax([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values)
            => ImplGetMinmax(target, reset, format, type, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="reset">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetMinmaxEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMinmax<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged
            => ImplGetMinmax<T0>(target, reset, format, type, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMinmaxParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMinmaxParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetMinmaxParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMinmaxParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMinmaxParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetMinmaxParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMinmaxParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMinmaxParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetMinmaxParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMinmaxParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMinmaxParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetMinmaxParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="sink">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glHistogramEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Histogram([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] bool sink)
            => ImplHistogram(target, width, internalformat, sink);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="sink">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMinmaxEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Minmax([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] bool sink)
            => ImplMinmax(target, internalformat, sink);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glResetHistogramEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ResetHistogram([Flow(FlowDirection.In)] EXT target)
            => ImplResetHistogram(target);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glResetMinmaxEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ResetMinmax([Flow(FlowDirection.In)] EXT target)
            => ImplResetMinmax(target);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="reset">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetHistogramEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values)
            => ImplGetHistogram(target, reset, format, type, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="reset">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetHistogramEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged
            => ImplGetHistogram<T0>(target, reset, format, type, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetHistogramParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetHistogramParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetHistogramParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetHistogramParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetHistogramParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetHistogramParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetHistogramParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetHistogramParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="reset">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetMinmaxEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values)
            => ImplGetMinmax(target, reset, format, type, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="reset">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetMinmaxEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged
            => ImplGetMinmax<T0>(target, reset, format, type, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMinmaxParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetMinmaxParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMinmaxParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetMinmaxParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMinmaxParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetMinmaxParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMinmaxParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetMinmaxParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="sink">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glHistogramEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Histogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] bool sink)
            => ImplHistogram(target, width, internalformat, sink);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="sink">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMinmaxEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Minmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] bool sink)
            => ImplMinmax(target, internalformat, sink);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glResetHistogramEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ResetHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target)
            => ImplResetHistogram(target);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glResetMinmaxEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ResetMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target)
            => ImplResetMinmax(target);

        public ExtHistogram(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

