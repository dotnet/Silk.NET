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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
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
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="table">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnColorTableARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* table)
            => ImplGetnColorTable(target, format, type, bufSize, table);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
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
        /// <param name="table">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnColorTableARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnColorTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
            => ImplGetnColorTable<T0>(target, format, type, bufSize, table);

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
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="image">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnConvolutionFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* image)
            => ImplGetnConvolutionFilter(target, format, type, bufSize, image);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
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
        /// <param name="image">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
            => ImplGetnConvolutionFilter<T0>(target, format, type, bufSize, image);

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
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnHistogramARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnHistogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values)
            => ImplGetnHistogram(target, reset, format, type, bufSize, values);

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
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnHistogramARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
            => ImplGetnHistogram<T0>(target, reset, format, type, bufSize, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="query">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnMapdvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] double* v)
            => ImplGetnMap(target, query, bufSize, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="query">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnMapdvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<double> v)
            => ImplGetnMap(target, query, bufSize, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="query">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnMapfvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] float* v)
            => ImplGetnMap(target, query, bufSize, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="query">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnMapfvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<float> v)
            => ImplGetnMap(target, query, bufSize, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="query">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnMapivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] int* v)
            => ImplGetnMap(target, query, bufSize, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="query">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnMapivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<int> v)
            => ImplGetnMap(target, query, bufSize, v);

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
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnMinmaxARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnMinmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values)
            => ImplGetnMinmax(target, reset, format, type, bufSize, values);

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
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnMinmaxARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
            => ImplGetnMinmax<T0>(target, reset, format, type, bufSize, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="map">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnPixelMapfvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnPixelMap([Flow(FlowDirection.In)] ARB map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] float* values)
            => ImplGetnPixelMap(map, bufSize, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="map">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnPixelMapfvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnPixelMap([Flow(FlowDirection.In)] ARB map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<float> values)
            => ImplGetnPixelMap(map, bufSize, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="map">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnPixelMapuivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnPixelMap([Flow(FlowDirection.In)] ARB map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] uint* values)
            => ImplGetnPixelMap(map, bufSize, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="map">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnPixelMapuivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnPixelMap([Flow(FlowDirection.In)] ARB map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<uint> values)
            => ImplGetnPixelMap(map, bufSize, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="map">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnPixelMapusvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnPixelMap([Flow(FlowDirection.In)] ARB map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] ushort* values)
            => ImplGetnPixelMap(map, bufSize, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="map">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnPixelMapusvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnPixelMap([Flow(FlowDirection.In)] ARB map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<ushort> values)
            => ImplGetnPixelMap(map, bufSize, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="pattern">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnPolygonStippleARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnPolygonStipple([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* pattern)
            => ImplGetnPolygonStipple(bufSize, pattern);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="pattern">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnPolygonStippleARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnPolygonStipple([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> pattern)
            => ImplGetnPolygonStipple(bufSize, pattern);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="rowBufSize">
        /// To be added.
        /// </param>
        /// <param name="row">
        /// To be added.
        /// This parameter's element count is taken from rowBufSize.
        /// </param>
        /// <param name="columnBufSize">
        /// To be added.
        /// </param>
        /// <param name="column">
        /// To be added.
        /// This parameter's element count is taken from columnBufSize.
        /// </param>
        /// <param name="span">
        /// To be added.
        /// This parameter contains 0 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnSeparableFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span)
            => ImplGetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, column, span);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="rowBufSize">
        /// To be added.
        /// </param>
        /// <param name="row">
        /// To be added.
        /// This parameter's element count is taken from rowBufSize.
        /// </param>
        /// <param name="columnBufSize">
        /// To be added.
        /// </param>
        /// <param name="column">
        /// To be added.
        /// This parameter's element count is taken from columnBufSize.
        /// </param>
        /// <param name="span">
        /// To be added.
        /// This parameter contains 0 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
            => ImplGetnSeparableFilter<T0, T1, T2>(target, format, type, rowBufSize, row, columnBufSize, column, span);

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
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="table">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnColorTableARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* table)
            => ImplGetnColorTable(target, format, type, bufSize, table);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
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
        /// <param name="table">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnColorTableARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
            => ImplGetnColorTable<T0>(target, format, type, bufSize, table);

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
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="image">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnConvolutionFilter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* image)
            => ImplGetnConvolutionFilter(target, format, type, bufSize, image);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
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
        /// <param name="image">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
            => ImplGetnConvolutionFilter<T0>(target, format, type, bufSize, image);

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
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnHistogramARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values)
            => ImplGetnHistogram(target, reset, format, type, bufSize, values);

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
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnHistogramARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
            => ImplGetnHistogram<T0>(target, reset, format, type, bufSize, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="query">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnMapdvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] double* v)
            => ImplGetnMap(target, query, bufSize, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="query">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnMapdvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<double> v)
            => ImplGetnMap(target, query, bufSize, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="query">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnMapfvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] float* v)
            => ImplGetnMap(target, query, bufSize, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="query">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnMapfvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<float> v)
            => ImplGetnMap(target, query, bufSize, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="query">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnMapivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] int* v)
            => ImplGetnMap(target, query, bufSize, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="query">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnMapivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<int> v)
            => ImplGetnMap(target, query, bufSize, v);

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
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnMinmaxARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values)
            => ImplGetnMinmax(target, reset, format, type, bufSize, values);

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
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnMinmaxARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
            => ImplGetnMinmax<T0>(target, reset, format, type, bufSize, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="map">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnPixelMapfvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] float* values)
            => ImplGetnPixelMap(map, bufSize, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="map">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnPixelMapfvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<float> values)
            => ImplGetnPixelMap(map, bufSize, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="map">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnPixelMapuivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] uint* values)
            => ImplGetnPixelMap(map, bufSize, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="map">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnPixelMapuivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<uint> values)
            => ImplGetnPixelMap(map, bufSize, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="map">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnPixelMapusvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] ushort* values)
            => ImplGetnPixelMap(map, bufSize, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="map">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetnPixelMapusvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<ushort> values)
            => ImplGetnPixelMap(map, bufSize, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="pattern">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetnPolygonStippleARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnPolygonStipple([Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -1)] out string pattern)
            => ImplGetnPolygonStipple(bufSize, pattern);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="rowBufSize">
        /// To be added.
        /// </param>
        /// <param name="row">
        /// To be added.
        /// This parameter's element count is taken from rowBufSize.
        /// </param>
        /// <param name="columnBufSize">
        /// To be added.
        /// </param>
        /// <param name="column">
        /// To be added.
        /// This parameter's element count is taken from columnBufSize.
        /// </param>
        /// <param name="span">
        /// To be added.
        /// This parameter contains 0 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetnSeparableFilter([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span)
            => ImplGetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, column, span);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="rowBufSize">
        /// To be added.
        /// </param>
        /// <param name="row">
        /// To be added.
        /// This parameter's element count is taken from rowBufSize.
        /// </param>
        /// <param name="columnBufSize">
        /// To be added.
        /// </param>
        /// <param name="column">
        /// To be added.
        /// This parameter's element count is taken from columnBufSize.
        /// </param>
        /// <param name="span">
        /// To be added.
        /// This parameter contains 0 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
            => ImplGetnSeparableFilter<T0, T1, T2>(target, format, type, rowBufSize, row, columnBufSize, column, span);

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

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="pattern">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe byte GetnPolygonStipple()
        {
            const uint bufSize = 1;
            // ReturnTypeOverloader
            byte ret = default;
            GetnPolygonStipple(bufSize, &ret);
            return ret;
        }

        public ArbRobustness(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

