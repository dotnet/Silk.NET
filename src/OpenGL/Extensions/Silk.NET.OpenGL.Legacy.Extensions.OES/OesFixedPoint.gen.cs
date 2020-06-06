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

namespace Silk.NET.OpenGL.Legacy.Extensions.OES
{
    [Extension("OES_fixed_point")]
    public unsafe partial class OesFixedPoint : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_fixed_point";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="op">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glAccumxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Accumx([Flow(FlowDirection.In)] OES op, [Flow(FlowDirection.In)] int value)
            => ImplAccumx(op, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="func">
        /// To be added.
        /// </param>
        /// <param name="@ref">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glAlphaFuncxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void AlphaFuncx([Flow(FlowDirection.In)] OES func, [Flow(FlowDirection.In)] int @ref)
            => ImplAlphaFuncx(func, @ref);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="xorig">
        /// To be added.
        /// </param>
        /// <param name="yorig">
        /// To be added.
        /// </param>
        /// <param name="xmove">
        /// To be added.
        /// </param>
        /// <param name="ymove">
        /// To be added.
        /// </param>
        /// <param name="bitmap">
        /// To be added.
        /// This parameter's element count is computed from width and height.
        /// </param>
        [NativeApi(EntryPoint = "glBitmapxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Bitmapx([Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int xorig, [Flow(FlowDirection.In)] int yorig, [Flow(FlowDirection.In)] int xmove, [Flow(FlowDirection.In)] int ymove, [Count(Computed = "width, height"), Flow(FlowDirection.In)] byte* bitmap)
            => ImplBitmapx(width, height, xorig, yorig, xmove, ymove, bitmap);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="xorig">
        /// To be added.
        /// </param>
        /// <param name="yorig">
        /// To be added.
        /// </param>
        /// <param name="xmove">
        /// To be added.
        /// </param>
        /// <param name="ymove">
        /// To be added.
        /// </param>
        /// <param name="bitmap">
        /// To be added.
        /// This parameter's element count is computed from width and height.
        /// </param>
        [NativeApi(EntryPoint = "glBitmapxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Bitmapx([Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int xorig, [Flow(FlowDirection.In)] int yorig, [Flow(FlowDirection.In)] int xmove, [Flow(FlowDirection.In)] int ymove, [Count(Computed = "width, height"), Flow(FlowDirection.In)] ref byte bitmap)
            => ImplBitmapx(width, height, xorig, yorig, xmove, ymove, bitmap);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="red">
        /// To be added.
        /// </param>
        /// <param name="green">
        /// To be added.
        /// </param>
        /// <param name="blue">
        /// To be added.
        /// </param>
        /// <param name="alpha">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendColorxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendColorx([Flow(FlowDirection.In)] int red, [Flow(FlowDirection.In)] int green, [Flow(FlowDirection.In)] int blue, [Flow(FlowDirection.In)] int alpha)
            => ImplBlendColorx(red, green, blue, alpha);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="red">
        /// To be added.
        /// </param>
        /// <param name="green">
        /// To be added.
        /// </param>
        /// <param name="blue">
        /// To be added.
        /// </param>
        /// <param name="alpha">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearAccumxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearAccumx([Flow(FlowDirection.In)] int red, [Flow(FlowDirection.In)] int green, [Flow(FlowDirection.In)] int blue, [Flow(FlowDirection.In)] int alpha)
            => ImplClearAccumx(red, green, blue, alpha);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="red">
        /// To be added.
        /// </param>
        /// <param name="green">
        /// To be added.
        /// </param>
        /// <param name="blue">
        /// To be added.
        /// </param>
        /// <param name="alpha">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearColorxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearColorx([Flow(FlowDirection.In)] int red, [Flow(FlowDirection.In)] int green, [Flow(FlowDirection.In)] int blue, [Flow(FlowDirection.In)] int alpha)
            => ImplClearColorx(red, green, blue, alpha);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="depth">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearDepthxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearDepthx([Flow(FlowDirection.In)] int depth)
            => ImplClearDepthx(depth);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="plane">
        /// To be added.
        /// </param>
        /// <param name="equation">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glClipPlanexOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClipPlanex([Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.In)] int* equation)
            => ImplClipPlanex(plane, equation);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="plane">
        /// To be added.
        /// </param>
        /// <param name="equation">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glClipPlanexOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClipPlanex([Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> equation)
            => ImplClipPlanex(plane, equation);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="red">
        /// To be added.
        /// </param>
        /// <param name="green">
        /// To be added.
        /// </param>
        /// <param name="blue">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glColor3xOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Color3x([Flow(FlowDirection.In)] int red, [Flow(FlowDirection.In)] int green, [Flow(FlowDirection.In)] int blue)
            => ImplColor3x(red, green, blue);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="components">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColor3xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Color3x([Count(Count = 3), Flow(FlowDirection.In)] int* components)
            => ImplColor3x(components);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="components">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColor3xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Color3x([Count(Count = 3), Flow(FlowDirection.In)] Span<int> components)
            => ImplColor3x(components);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="red">
        /// To be added.
        /// </param>
        /// <param name="green">
        /// To be added.
        /// </param>
        /// <param name="blue">
        /// To be added.
        /// </param>
        /// <param name="alpha">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glColor4xOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Color4x([Flow(FlowDirection.In)] int red, [Flow(FlowDirection.In)] int green, [Flow(FlowDirection.In)] int blue, [Flow(FlowDirection.In)] int alpha)
            => ImplColor4x(red, green, blue, alpha);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="components">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColor4xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Color4x([Count(Count = 4), Flow(FlowDirection.In)] int* components)
            => ImplColor4x(components);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="components">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColor4xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Color4x([Count(Count = 4), Flow(FlowDirection.In)] Span<int> components)
            => ImplColor4x(components);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glConvolutionParameterxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ConvolutionParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param)
            => ImplConvolutionParameterx(target, pname, param);

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
        [NativeApi(EntryPoint = "glConvolutionParameterxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ConvolutionParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplConvolutionParameterx(target, pname, @params);

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
        [NativeApi(EntryPoint = "glConvolutionParameterxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ConvolutionParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplConvolutionParameterx(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="f">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDepthRangexOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DepthRangex([Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int f)
            => ImplDepthRangex(n, f);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="u">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEvalCoord1xOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EvalCoord1x([Flow(FlowDirection.In)] int u)
            => ImplEvalCoord1x(u);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glEvalCoord1xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void EvalCoord1x([Count(Count = 1), Flow(FlowDirection.In)] int* coords)
            => ImplEvalCoord1x(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glEvalCoord1xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EvalCoord1x([Count(Count = 1), Flow(FlowDirection.In)] ref int coords)
            => ImplEvalCoord1x(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="u">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEvalCoord2xOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EvalCoord2x([Flow(FlowDirection.In)] int u, [Flow(FlowDirection.In)] int v)
            => ImplEvalCoord2x(u, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glEvalCoord2xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void EvalCoord2x([Count(Count = 2), Flow(FlowDirection.In)] int* coords)
            => ImplEvalCoord2x(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glEvalCoord2xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EvalCoord2x([Count(Count = 2), Flow(FlowDirection.In)] Span<int> coords)
            => ImplEvalCoord2x(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glFeedbackBufferxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FeedbackBufferx([Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] OES type, [Count(Parameter = "n"), Flow(FlowDirection.In)] int* buffer)
            => ImplFeedbackBufferx(n, type, buffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glFeedbackBufferxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FeedbackBufferx([Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] OES type, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<int> buffer)
            => ImplFeedbackBufferx(n, type, buffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFogxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Fogx([Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param)
            => ImplFogx(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glFogxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Fogx([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param)
            => ImplFogx(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glFogxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Fogx([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param)
            => ImplFogx(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="l">
        /// To be added.
        /// </param>
        /// <param name="r">
        /// To be added.
        /// </param>
        /// <param name="b">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="f">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFrustumxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Frustumx([Flow(FlowDirection.In)] int l, [Flow(FlowDirection.In)] int r, [Flow(FlowDirection.In)] int b, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int f)
            => ImplFrustumx(l, r, b, t, n, f);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="plane">
        /// To be added.
        /// </param>
        /// <param name="equation">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetClipPlanexOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetClipPlanex([Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.Out)] int* equation)
            => ImplGetClipPlanex(plane, equation);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="plane">
        /// To be added.
        /// </param>
        /// <param name="equation">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetClipPlanexOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetClipPlanex([Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> equation)
            => ImplGetClipPlanex(plane, equation);

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
        [NativeApi(EntryPoint = "glGetConvolutionParameterxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetConvolutionParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetConvolutionParameterx(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetConvolutionParameterxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetConvolutionParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetConvolutionParameterx(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFixedvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetFixed([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetFixed(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFixedvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetFixed([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetFixed(pname, @params);

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
        [NativeApi(EntryPoint = "glGetHistogramParameterxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetHistogramParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetHistogramParameterx(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetHistogramParameterxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetHistogramParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetHistogramParameterx(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetLightxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetLightx([Flow(FlowDirection.In)] OES light, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetLightx(light, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetLightxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetLightx([Flow(FlowDirection.In)] OES light, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetLightx(light, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="query">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is computed from query.
        /// </param>
        [NativeApi(EntryPoint = "glGetMapxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMapx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES query, [Count(Computed = "query"), Flow(FlowDirection.Out)] int* v)
            => ImplGetMapx(target, query, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="query">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is computed from query.
        /// </param>
        [NativeApi(EntryPoint = "glGetMapxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMapx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES query, [Count(Computed = "query"), Flow(FlowDirection.Out)] out int v)
            => ImplGetMapx(target, query, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetMaterialxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMaterialx([Flow(FlowDirection.In)] OES face, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param)
            => ImplGetMaterialx(face, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="map">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glGetPixelMapxv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPixelMapx([Flow(FlowDirection.In)] OES map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] int* values)
            => ImplGetPixelMapx(map, size, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="map">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glGetPixelMapxv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPixelMapx([Flow(FlowDirection.In)] OES map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<int> values)
            => ImplGetPixelMapx(map, size, values);

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
        [NativeApi(EntryPoint = "glGetTexEnvxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTexEnvx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetTexEnvx(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetTexEnvxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTexEnvx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetTexEnvx(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTexGenxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTexGenx([Flow(FlowDirection.In)] OES coord, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetTexGenx(coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTexGenxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTexGenx([Flow(FlowDirection.In)] OES coord, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetTexGenx(coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTexLevelParameterxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTexLevelParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetTexLevelParameterx(target, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTexLevelParameterxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTexLevelParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetTexLevelParameterx(target, level, pname, @params);

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
        [NativeApi(EntryPoint = "glGetTexParameterxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTexParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetTexParameterx(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetTexParameterxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTexParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetTexParameterx(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="component">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glIndexxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Indexx([Flow(FlowDirection.In)] int component)
            => ImplIndexx(component);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="component">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glIndexxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Indexx([Count(Count = 1), Flow(FlowDirection.In)] int* component)
            => ImplIndexx(component);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="component">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glIndexxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Indexx([Count(Count = 1), Flow(FlowDirection.In)] ref int component)
            => ImplIndexx(component);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glLightModelxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void LightModelx([Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param)
            => ImplLightModelx(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glLightModelxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void LightModelx([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param)
            => ImplLightModelx(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glLightModelxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void LightModelx([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param)
            => ImplLightModelx(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glLightxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Lightx([Flow(FlowDirection.In)] OES light, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param)
            => ImplLightx(light, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glLightxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Lightx([Flow(FlowDirection.In)] OES light, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplLightx(light, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glLightxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Lightx([Flow(FlowDirection.In)] OES light, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplLightx(light, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="width">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glLineWidthxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void LineWidthx([Flow(FlowDirection.In)] int width)
            => ImplLineWidthx(width);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glLoadMatrixxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void LoadMatrixx([Count(Count = 16), Flow(FlowDirection.In)] int* m)
            => ImplLoadMatrixx(m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glLoadMatrixxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void LoadMatrixx([Count(Count = 16), Flow(FlowDirection.In)] Span<int> m)
            => ImplLoadMatrixx(m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glLoadTransposeMatrixxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void LoadTransposeMatrixx([Count(Count = 16), Flow(FlowDirection.In)] int* m)
            => ImplLoadTransposeMatrixx(m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glLoadTransposeMatrixxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void LoadTransposeMatrixx([Count(Count = 16), Flow(FlowDirection.In)] Span<int> m)
            => ImplLoadTransposeMatrixx(m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="u1">
        /// To be added.
        /// </param>
        /// <param name="u2">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="order">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMap1xOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Map1x([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int u1, [Flow(FlowDirection.In)] int u2, [Flow(FlowDirection.In)] int stride, [Flow(FlowDirection.In)] int order, [Flow(FlowDirection.In)] int points)
            => ImplMap1x(target, u1, u2, stride, order, points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="u1">
        /// To be added.
        /// </param>
        /// <param name="u2">
        /// To be added.
        /// </param>
        /// <param name="ustride">
        /// To be added.
        /// </param>
        /// <param name="uorder">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// </param>
        /// <param name="vstride">
        /// To be added.
        /// </param>
        /// <param name="vorder">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMap2xOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Map2x([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int u1, [Flow(FlowDirection.In)] int u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] int points)
            => ImplMap2x(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="u1">
        /// To be added.
        /// </param>
        /// <param name="u2">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMapGrid1xOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MapGrid1x([Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int u1, [Flow(FlowDirection.In)] int u2)
            => ImplMapGrid1x(n, u1, u2);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="u1">
        /// To be added.
        /// </param>
        /// <param name="u2">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMapGrid2xOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MapGrid2x([Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int u1, [Flow(FlowDirection.In)] int u2, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2)
            => ImplMapGrid2x(n, u1, u2, v1, v2);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMaterialxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Materialx([Flow(FlowDirection.In)] OES face, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param)
            => ImplMaterialx(face, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMaterialxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Materialx([Flow(FlowDirection.In)] OES face, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param)
            => ImplMaterialx(face, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMaterialxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Materialx([Flow(FlowDirection.In)] OES face, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param)
            => ImplMaterialx(face, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1xOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord1x([Flow(FlowDirection.In)] OES texture, [Flow(FlowDirection.In)] int s)
            => ImplMultiTexCoord1x(texture, s);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord1x([Flow(FlowDirection.In)] OES texture, [Count(Count = 1), Flow(FlowDirection.In)] int* coords)
            => ImplMultiTexCoord1x(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord1x([Flow(FlowDirection.In)] OES texture, [Count(Count = 1), Flow(FlowDirection.In)] ref int coords)
            => ImplMultiTexCoord1x(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2xOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord2x([Flow(FlowDirection.In)] OES texture, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t)
            => ImplMultiTexCoord2x(texture, s, t);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord2x([Flow(FlowDirection.In)] OES texture, [Count(Count = 2), Flow(FlowDirection.In)] int* coords)
            => ImplMultiTexCoord2x(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord2x([Flow(FlowDirection.In)] OES texture, [Count(Count = 2), Flow(FlowDirection.In)] Span<int> coords)
            => ImplMultiTexCoord2x(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        /// <param name="r">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord3xOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord3x([Flow(FlowDirection.In)] OES texture, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r)
            => ImplMultiTexCoord3x(texture, s, t, r);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord3xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord3x([Flow(FlowDirection.In)] OES texture, [Count(Count = 3), Flow(FlowDirection.In)] int* coords)
            => ImplMultiTexCoord3x(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord3xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord3x([Flow(FlowDirection.In)] OES texture, [Count(Count = 3), Flow(FlowDirection.In)] Span<int> coords)
            => ImplMultiTexCoord3x(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        /// <param name="r">
        /// To be added.
        /// </param>
        /// <param name="q">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord4xOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord4x([Flow(FlowDirection.In)] OES texture, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r, [Flow(FlowDirection.In)] int q)
            => ImplMultiTexCoord4x(texture, s, t, r, q);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord4xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord4x([Flow(FlowDirection.In)] OES texture, [Count(Count = 4), Flow(FlowDirection.In)] int* coords)
            => ImplMultiTexCoord4x(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord4xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord4x([Flow(FlowDirection.In)] OES texture, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> coords)
            => ImplMultiTexCoord4x(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultMatrixxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultMatrixx([Count(Count = 16), Flow(FlowDirection.In)] int* m)
            => ImplMultMatrixx(m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultMatrixxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultMatrixx([Count(Count = 16), Flow(FlowDirection.In)] Span<int> m)
            => ImplMultMatrixx(m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultTransposeMatrixxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultTransposeMatrixx([Count(Count = 16), Flow(FlowDirection.In)] int* m)
            => ImplMultTransposeMatrixx(m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultTransposeMatrixxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultTransposeMatrixx([Count(Count = 16), Flow(FlowDirection.In)] Span<int> m)
            => ImplMultTransposeMatrixx(m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="nx">
        /// To be added.
        /// </param>
        /// <param name="ny">
        /// To be added.
        /// </param>
        /// <param name="nz">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNormal3xOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Normal3x([Flow(FlowDirection.In)] int nx, [Flow(FlowDirection.In)] int ny, [Flow(FlowDirection.In)] int nz)
            => ImplNormal3x(nx, ny, nz);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormal3xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Normal3x([Count(Count = 3), Flow(FlowDirection.In)] int* coords)
            => ImplNormal3x(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormal3xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Normal3x([Count(Count = 3), Flow(FlowDirection.In)] Span<int> coords)
            => ImplNormal3x(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="l">
        /// To be added.
        /// </param>
        /// <param name="r">
        /// To be added.
        /// </param>
        /// <param name="b">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="f">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glOrthoxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Orthox([Flow(FlowDirection.In)] int l, [Flow(FlowDirection.In)] int r, [Flow(FlowDirection.In)] int b, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int f)
            => ImplOrthox(l, r, b, t, n, f);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="token">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPassThroughxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PassThroughx([Flow(FlowDirection.In)] int token)
            => ImplPassThroughx(token);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="map">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glPixelMapx")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PixelMapx([Flow(FlowDirection.In)] OES map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] int* values)
            => ImplPixelMapx(map, size, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="map">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glPixelMapx")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PixelMapx([Flow(FlowDirection.In)] OES map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<int> values)
            => ImplPixelMapx(map, size, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPixelStorex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PixelStorex([Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param)
            => ImplPixelStorex(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPixelTransferxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PixelTransferx([Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param)
            => ImplPixelTransferx(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="xfactor">
        /// To be added.
        /// </param>
        /// <param name="yfactor">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPixelZoomxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PixelZoomx([Flow(FlowDirection.In)] int xfactor, [Flow(FlowDirection.In)] int yfactor)
            => ImplPixelZoomx(xfactor, yfactor);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glPointParameterxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PointParameterx([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplPointParameterx(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glPointParameterxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PointParameterx([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplPointParameterx(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPointSizexOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PointSizex([Flow(FlowDirection.In)] int size)
            => ImplPointSizex(size);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="factor">
        /// To be added.
        /// </param>
        /// <param name="units">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPolygonOffsetxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PolygonOffsetx([Flow(FlowDirection.In)] int factor, [Flow(FlowDirection.In)] int units)
            => ImplPolygonOffsetx(factor, units);

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
        /// <param name="priorities">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glPrioritizeTexturesxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PrioritizeTexturesx([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] int* priorities)
            => ImplPrioritizeTexturesx(n, textures, priorities);

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
        /// <param name="priorities">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glPrioritizeTexturesxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PrioritizeTexturesx([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<int> priorities)
            => ImplPrioritizeTexturesx(n, textures, priorities);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glRasterPos2xOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void RasterPos2x([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y)
            => ImplRasterPos2x(x, y);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glRasterPos2xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void RasterPos2x([Count(Count = 2), Flow(FlowDirection.In)] int* coords)
            => ImplRasterPos2x(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glRasterPos2xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void RasterPos2x([Count(Count = 2), Flow(FlowDirection.In)] Span<int> coords)
            => ImplRasterPos2x(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glRasterPos3xOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void RasterPos3x([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z)
            => ImplRasterPos3x(x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glRasterPos3xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void RasterPos3x([Count(Count = 3), Flow(FlowDirection.In)] int* coords)
            => ImplRasterPos3x(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glRasterPos3xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void RasterPos3x([Count(Count = 3), Flow(FlowDirection.In)] Span<int> coords)
            => ImplRasterPos3x(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        /// <param name="w">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glRasterPos4xOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void RasterPos4x([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w)
            => ImplRasterPos4x(x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glRasterPos4xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void RasterPos4x([Count(Count = 4), Flow(FlowDirection.In)] int* coords)
            => ImplRasterPos4x(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glRasterPos4xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void RasterPos4x([Count(Count = 4), Flow(FlowDirection.In)] Span<int> coords)
            => ImplRasterPos4x(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x1">
        /// To be added.
        /// </param>
        /// <param name="y1">
        /// To be added.
        /// </param>
        /// <param name="x2">
        /// To be added.
        /// </param>
        /// <param name="y2">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glRectxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Rectx([Flow(FlowDirection.In)] int x1, [Flow(FlowDirection.In)] int y1, [Flow(FlowDirection.In)] int x2, [Flow(FlowDirection.In)] int y2)
            => ImplRectx(x1, y1, x2, y2);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v1">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glRectxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Rectx([Count(Count = 2), Flow(FlowDirection.In)] int* v1, [Count(Count = 2), Flow(FlowDirection.In)] int* v2)
            => ImplRectx(v1, v2);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v1">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glRectxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Rectx([Count(Count = 2), Flow(FlowDirection.In)] Span<int> v1, [Count(Count = 2), Flow(FlowDirection.In)] Span<int> v2)
            => ImplRectx(v1, v2);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="angle">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glRotatexOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Rotatex([Flow(FlowDirection.In)] int angle, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z)
            => ImplRotatex(angle, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glScalexOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Scalex([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z)
            => ImplScalex(x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="s">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord1xOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoord1x([Flow(FlowDirection.In)] int s)
            => ImplTexCoord1x(s);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord1xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexCoord1x([Count(Count = 1), Flow(FlowDirection.In)] int* coords)
            => ImplTexCoord1x(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord1xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoord1x([Count(Count = 1), Flow(FlowDirection.In)] ref int coords)
            => ImplTexCoord1x(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord2xOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoord2x([Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t)
            => ImplTexCoord2x(s, t);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord2xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexCoord2x([Count(Count = 2), Flow(FlowDirection.In)] int* coords)
            => ImplTexCoord2x(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord2xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoord2x([Count(Count = 2), Flow(FlowDirection.In)] Span<int> coords)
            => ImplTexCoord2x(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        /// <param name="r">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord3xOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoord3x([Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r)
            => ImplTexCoord3x(s, t, r);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord3xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexCoord3x([Count(Count = 3), Flow(FlowDirection.In)] int* coords)
            => ImplTexCoord3x(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord3xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoord3x([Count(Count = 3), Flow(FlowDirection.In)] Span<int> coords)
            => ImplTexCoord3x(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        /// <param name="r">
        /// To be added.
        /// </param>
        /// <param name="q">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord4xOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoord4x([Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r, [Flow(FlowDirection.In)] int q)
            => ImplTexCoord4x(s, t, r, q);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord4xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexCoord4x([Count(Count = 4), Flow(FlowDirection.In)] int* coords)
            => ImplTexCoord4x(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord4xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoord4x([Count(Count = 4), Flow(FlowDirection.In)] Span<int> coords)
            => ImplTexCoord4x(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexEnvxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexEnvx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param)
            => ImplTexEnvx(target, pname, param);

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
        [NativeApi(EntryPoint = "glTexEnvxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexEnvx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplTexEnvx(target, pname, @params);

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
        [NativeApi(EntryPoint = "glTexEnvxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexEnvx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplTexEnvx(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexGenxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexGenx([Flow(FlowDirection.In)] OES coord, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param)
            => ImplTexGenx(coord, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glTexGenxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexGenx([Flow(FlowDirection.In)] OES coord, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplTexGenx(coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glTexGenxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexGenx([Flow(FlowDirection.In)] OES coord, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplTexGenx(coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexParameterxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param)
            => ImplTexParameterx(target, pname, param);

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
        [NativeApi(EntryPoint = "glTexParameterxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplTexParameterx(target, pname, @params);

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
        [NativeApi(EntryPoint = "glTexParameterxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplTexParameterx(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTranslatexOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Translatex([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z)
            => ImplTranslatex(x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertex2xOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Vertex2x([Flow(FlowDirection.In)] int x)
            => ImplVertex2x(x);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertex2xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Vertex2x([Count(Count = 2), Flow(FlowDirection.In)] int* coords)
            => ImplVertex2x(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertex2xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Vertex2x([Count(Count = 2), Flow(FlowDirection.In)] Span<int> coords)
            => ImplVertex2x(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertex3xOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Vertex3x([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y)
            => ImplVertex3x(x, y);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertex3xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Vertex3x([Count(Count = 3), Flow(FlowDirection.In)] int* coords)
            => ImplVertex3x(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertex3xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Vertex3x([Count(Count = 3), Flow(FlowDirection.In)] Span<int> coords)
            => ImplVertex3x(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertex4xOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Vertex4x([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z)
            => ImplVertex4x(x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertex4xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Vertex4x([Count(Count = 4), Flow(FlowDirection.In)] int* coords)
            => ImplVertex4x(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertex4xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Vertex4x([Count(Count = 4), Flow(FlowDirection.In)] Span<int> coords)
            => ImplVertex4x(coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="func">
        /// To be added.
        /// </param>
        /// <param name="@ref">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glAlphaFuncxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void AlphaFuncx([Flow(FlowDirection.In)] AlphaFunction func, [Flow(FlowDirection.In)] int @ref)
            => ImplAlphaFuncx(func, @ref);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="xorig">
        /// To be added.
        /// </param>
        /// <param name="yorig">
        /// To be added.
        /// </param>
        /// <param name="xmove">
        /// To be added.
        /// </param>
        /// <param name="ymove">
        /// To be added.
        /// </param>
        /// <param name="bitmap">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBitmapxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Bitmapx([Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int xorig, [Flow(FlowDirection.In)] int yorig, [Flow(FlowDirection.In)] int xmove, [Flow(FlowDirection.In)] int ymove, [Flow(FlowDirection.In)] string bitmap)
            => ImplBitmapx(width, height, xorig, yorig, xmove, ymove, bitmap);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="plane">
        /// To be added.
        /// </param>
        /// <param name="equation">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glClipPlanexOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ClipPlanex([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.In)] int* equation)
            => ImplClipPlanex(plane, equation);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="plane">
        /// To be added.
        /// </param>
        /// <param name="equation">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glClipPlanexOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClipPlanex([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> equation)
            => ImplClipPlanex(plane, equation);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glConvolutionParameterxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ConvolutionParameterx([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Flow(FlowDirection.In)] int param)
            => ImplConvolutionParameterx(target, pname, param);

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
        [NativeApi(EntryPoint = "glConvolutionParameterxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ConvolutionParameterx([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplConvolutionParameterx(target, pname, @params);

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
        [NativeApi(EntryPoint = "glConvolutionParameterxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ConvolutionParameterx([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplConvolutionParameterx(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFogxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Fogx([Flow(FlowDirection.In)] FogPName pname, [Flow(FlowDirection.In)] int param)
            => ImplFogx(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glFogxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Fogx([Flow(FlowDirection.In)] FogPName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param)
            => ImplFogx(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glFogxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Fogx([Flow(FlowDirection.In)] FogPName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param)
            => ImplFogx(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="plane">
        /// To be added.
        /// </param>
        /// <param name="equation">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetClipPlanexOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetClipPlanex([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.Out)] int* equation)
            => ImplGetClipPlanex(plane, equation);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="plane">
        /// To be added.
        /// </param>
        /// <param name="equation">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetClipPlanexOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetClipPlanex([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> equation)
            => ImplGetClipPlanex(plane, equation);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFixedvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetFixed([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetFixed(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFixedvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetFixed([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetFixed(pname, @params);

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
        [NativeApi(EntryPoint = "glGetHistogramParameterxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetHistogramParameterx([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetHistogramParameterx(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetHistogramParameterxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetHistogramParameterx([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetHistogramParameterx(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetLightxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetLightx([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetLightx(light, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetLightxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetLightx([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetLightx(light, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="query">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is computed from query.
        /// </param>
        [NativeApi(EntryPoint = "glGetMapxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMapx([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] GetMapQuery query, [Count(Computed = "query"), Flow(FlowDirection.Out)] int* v)
            => ImplGetMapx(target, query, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="query">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is computed from query.
        /// </param>
        [NativeApi(EntryPoint = "glGetMapxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMapx([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] GetMapQuery query, [Count(Computed = "query"), Flow(FlowDirection.Out)] out int v)
            => ImplGetMapx(target, query, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetMaterialxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMaterialx([Flow(FlowDirection.In)] OES face, [Flow(FlowDirection.In)] MaterialParameter pname, [Flow(FlowDirection.In)] int param)
            => ImplGetMaterialx(face, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="map">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glGetPixelMapxv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPixelMapx([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] int* values)
            => ImplGetPixelMapx(map, size, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="map">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glGetPixelMapxv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPixelMapx([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<int> values)
            => ImplGetPixelMapx(map, size, values);

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
        [NativeApi(EntryPoint = "glGetTexEnvxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTexEnvx([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetTexEnvx(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetTexEnvxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTexEnvx([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetTexEnvx(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTexGenxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTexGenx([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetTexGenx(coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTexGenxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTexGenx([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetTexGenx(coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTexLevelParameterxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTexLevelParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetTexLevelParameterx(target, level, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetTexLevelParameterxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTexLevelParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetTexLevelParameterx(target, level, pname, @params);

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
        [NativeApi(EntryPoint = "glGetTexParameterxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetTexParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetTexParameterx(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetTexParameterxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetTexParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetTexParameterx(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glLightModelxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void LightModelx([Flow(FlowDirection.In)] LightModelParameter pname, [Flow(FlowDirection.In)] int param)
            => ImplLightModelx(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glLightModelxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void LightModelx([Flow(FlowDirection.In)] LightModelParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param)
            => ImplLightModelx(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glLightModelxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void LightModelx([Flow(FlowDirection.In)] LightModelParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param)
            => ImplLightModelx(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glLightxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Lightx([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Flow(FlowDirection.In)] int param)
            => ImplLightx(light, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glLightxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Lightx([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplLightx(light, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glLightxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Lightx([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplLightx(light, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="u1">
        /// To be added.
        /// </param>
        /// <param name="u2">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="order">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMap1xOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Map1x([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] int u1, [Flow(FlowDirection.In)] int u2, [Flow(FlowDirection.In)] int stride, [Flow(FlowDirection.In)] int order, [Flow(FlowDirection.In)] int points)
            => ImplMap1x(target, u1, u2, stride, order, points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="u1">
        /// To be added.
        /// </param>
        /// <param name="u2">
        /// To be added.
        /// </param>
        /// <param name="ustride">
        /// To be added.
        /// </param>
        /// <param name="uorder">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// </param>
        /// <param name="vstride">
        /// To be added.
        /// </param>
        /// <param name="vorder">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMap2xOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Map2x([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] int u1, [Flow(FlowDirection.In)] int u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] int points)
            => ImplMap2x(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMaterialxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Materialx([Flow(FlowDirection.In)] OES face, [Flow(FlowDirection.In)] MaterialParameter pname, [Flow(FlowDirection.In)] int param)
            => ImplMaterialx(face, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMaterialxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Materialx([Flow(FlowDirection.In)] OES face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param)
            => ImplMaterialx(face, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glMaterialxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Materialx([Flow(FlowDirection.In)] OES face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param)
            => ImplMaterialx(face, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1xOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord1x([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] int s)
            => ImplMultiTexCoord1x(texture, s);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord1x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 1), Flow(FlowDirection.In)] int* coords)
            => ImplMultiTexCoord1x(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord1xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord1x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 1), Flow(FlowDirection.In)] ref int coords)
            => ImplMultiTexCoord1x(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2xOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord2x([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t)
            => ImplMultiTexCoord2x(texture, s, t);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord2x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 2), Flow(FlowDirection.In)] int* coords)
            => ImplMultiTexCoord2x(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord2xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord2x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 2), Flow(FlowDirection.In)] Span<int> coords)
            => ImplMultiTexCoord2x(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        /// <param name="r">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord3xOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord3x([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r)
            => ImplMultiTexCoord3x(texture, s, t, r);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord3xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord3x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 3), Flow(FlowDirection.In)] int* coords)
            => ImplMultiTexCoord3x(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord3xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord3x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 3), Flow(FlowDirection.In)] Span<int> coords)
            => ImplMultiTexCoord3x(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="s">
        /// To be added.
        /// </param>
        /// <param name="t">
        /// To be added.
        /// </param>
        /// <param name="r">
        /// To be added.
        /// </param>
        /// <param name="q">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord4xOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord4x([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r, [Flow(FlowDirection.In)] int q)
            => ImplMultiTexCoord4x(texture, s, t, r, q);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord4xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiTexCoord4x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 4), Flow(FlowDirection.In)] int* coords)
            => ImplMultiTexCoord4x(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultiTexCoord4xvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiTexCoord4x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> coords)
            => ImplMultiTexCoord4x(texture, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="map">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glPixelMapx")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PixelMapx([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] int* values)
            => ImplPixelMapx(map, size, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="map">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        [NativeApi(EntryPoint = "glPixelMapx")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PixelMapx([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<int> values)
            => ImplPixelMapx(map, size, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPixelStorex")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PixelStorex([Flow(FlowDirection.In)] PixelStoreParameter pname, [Flow(FlowDirection.In)] int param)
            => ImplPixelStorex(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPixelTransferxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PixelTransferx([Flow(FlowDirection.In)] PixelTransferParameter pname, [Flow(FlowDirection.In)] int param)
            => ImplPixelTransferx(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glPointParameterxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PointParameterx([Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplPointParameterx(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glPointParameterxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PointParameterx([Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplPointParameterx(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexEnvxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexEnvx([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Flow(FlowDirection.In)] int param)
            => ImplTexEnvx(target, pname, param);

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
        [NativeApi(EntryPoint = "glTexEnvxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexEnvx([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplTexEnvx(target, pname, @params);

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
        [NativeApi(EntryPoint = "glTexEnvxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexEnvx([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplTexEnvx(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexGenxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexGenx([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Flow(FlowDirection.In)] int param)
            => ImplTexGenx(coord, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glTexGenxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexGenx([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplTexGenx(coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coord">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glTexGenxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexGenx([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplTexGenx(coord, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexParameterxOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.In)] int param)
            => ImplTexParameterx(target, pname, param);

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
        [NativeApi(EntryPoint = "glTexParameterxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplTexParameterx(target, pname, @params);

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
        [NativeApi(EntryPoint = "glTexParameterxvOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplTexParameterx(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetFixed([Flow(FlowDirection.In)] OES pname)
        {
            // ReturnTypeOverloader
            int ret = default;
            GetFixed(pname, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetFixed([Flow(FlowDirection.In)] GetPName pname)
        {
            // ReturnTypeOverloader
            int ret = default;
            GetFixed(pname, &ret);
            return ret;
        }

        public OesFixedPoint(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

