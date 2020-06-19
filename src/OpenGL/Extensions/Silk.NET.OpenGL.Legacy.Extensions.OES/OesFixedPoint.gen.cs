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

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.OES
{
    [Extension("OES_fixed_point")]
    public abstract unsafe partial class OesFixedPoint : NativeExtension<GL>
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
        public abstract void Accumx([Flow(FlowDirection.In)] OES op, [Flow(FlowDirection.In)] int value);

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
        public abstract void AlphaFuncx([Flow(FlowDirection.In)] OES func, [Flow(FlowDirection.In)] int @ref);

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
        public abstract unsafe void Bitmapx([Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int xorig, [Flow(FlowDirection.In)] int yorig, [Flow(FlowDirection.In)] int xmove, [Flow(FlowDirection.In)] int ymove, [Count(Computed = "width, height"), Flow(FlowDirection.In)] byte* bitmap);

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
        public abstract void Bitmapx([Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int xorig, [Flow(FlowDirection.In)] int yorig, [Flow(FlowDirection.In)] int xmove, [Flow(FlowDirection.In)] int ymove, [Count(Computed = "width, height"), Flow(FlowDirection.In)] ref byte bitmap);

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
        public abstract void BlendColorx([Flow(FlowDirection.In)] int red, [Flow(FlowDirection.In)] int green, [Flow(FlowDirection.In)] int blue, [Flow(FlowDirection.In)] int alpha);

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
        public abstract void ClearAccumx([Flow(FlowDirection.In)] int red, [Flow(FlowDirection.In)] int green, [Flow(FlowDirection.In)] int blue, [Flow(FlowDirection.In)] int alpha);

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
        public abstract void ClearColorx([Flow(FlowDirection.In)] int red, [Flow(FlowDirection.In)] int green, [Flow(FlowDirection.In)] int blue, [Flow(FlowDirection.In)] int alpha);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="depth">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearDepthxOES")]
        public abstract void ClearDepthx([Flow(FlowDirection.In)] int depth);

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
        public abstract unsafe void ClipPlanex([Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.In)] int* equation);

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
        public abstract void ClipPlanex([Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> equation);

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
        public abstract void Color3x([Flow(FlowDirection.In)] int red, [Flow(FlowDirection.In)] int green, [Flow(FlowDirection.In)] int blue);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="components">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColor3xvOES")]
        public abstract unsafe void Color3x([Count(Count = 3), Flow(FlowDirection.In)] int* components);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="components">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColor3xvOES")]
        public abstract void Color3x([Count(Count = 3), Flow(FlowDirection.In)] Span<int> components);

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
        public abstract void Color4x([Flow(FlowDirection.In)] int red, [Flow(FlowDirection.In)] int green, [Flow(FlowDirection.In)] int blue, [Flow(FlowDirection.In)] int alpha);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="components">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColor4xvOES")]
        public abstract unsafe void Color4x([Count(Count = 4), Flow(FlowDirection.In)] int* components);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="components">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColor4xvOES")]
        public abstract void Color4x([Count(Count = 4), Flow(FlowDirection.In)] Span<int> components);

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
        public abstract void ConvolutionParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

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
        public abstract unsafe void ConvolutionParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

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
        public abstract void ConvolutionParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

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
        public abstract void DepthRangex([Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int f);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="u">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEvalCoord1xOES")]
        public abstract void EvalCoord1x([Flow(FlowDirection.In)] int u);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glEvalCoord1xvOES")]
        public abstract unsafe void EvalCoord1x([Count(Count = 1), Flow(FlowDirection.In)] int* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glEvalCoord1xvOES")]
        public abstract void EvalCoord1x([Count(Count = 1), Flow(FlowDirection.In)] ref int coords);

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
        public abstract void EvalCoord2x([Flow(FlowDirection.In)] int u, [Flow(FlowDirection.In)] int v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glEvalCoord2xvOES")]
        public abstract unsafe void EvalCoord2x([Count(Count = 2), Flow(FlowDirection.In)] int* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glEvalCoord2xvOES")]
        public abstract void EvalCoord2x([Count(Count = 2), Flow(FlowDirection.In)] Span<int> coords);

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
        public abstract unsafe void FeedbackBufferx([Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] OES type, [Count(Parameter = "n"), Flow(FlowDirection.In)] int* buffer);

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
        public abstract void FeedbackBufferx([Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] OES type, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<int> buffer);

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
        public abstract void Fogx([Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

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
        public abstract unsafe void Fogx([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

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
        public abstract void Fogx([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

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
        public abstract void Frustumx([Flow(FlowDirection.In)] int l, [Flow(FlowDirection.In)] int r, [Flow(FlowDirection.In)] int b, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int f);

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
        public abstract unsafe void GetClipPlanex([Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.Out)] int* equation);

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
        public abstract void GetClipPlanex([Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> equation);

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
        public abstract unsafe void GetConvolutionParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

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
        public abstract void GetConvolutionParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

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
        public abstract unsafe void GetFixed([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

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
        public abstract void GetFixed([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

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
        public abstract unsafe void GetHistogramParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

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
        public abstract void GetHistogramParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

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
        public abstract unsafe void GetLightx([Flow(FlowDirection.In)] OES light, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

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
        public abstract void GetLightx([Flow(FlowDirection.In)] OES light, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

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
        public abstract unsafe void GetMapx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES query, [Count(Computed = "query"), Flow(FlowDirection.Out)] int* v);

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
        public abstract void GetMapx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES query, [Count(Computed = "query"), Flow(FlowDirection.Out)] out int v);

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
        public abstract void GetMaterialx([Flow(FlowDirection.In)] OES face, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

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
        public abstract unsafe void GetPixelMapx([Flow(FlowDirection.In)] OES map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] int* values);

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
        public abstract void GetPixelMapx([Flow(FlowDirection.In)] OES map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<int> values);

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
        public abstract unsafe void GetTexEnvx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

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
        public abstract void GetTexEnvx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

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
        public abstract unsafe void GetTexGenx([Flow(FlowDirection.In)] OES coord, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

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
        public abstract void GetTexGenx([Flow(FlowDirection.In)] OES coord, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

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
        public abstract unsafe void GetTexLevelParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

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
        public abstract void GetTexLevelParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

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
        public abstract unsafe void GetTexParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

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
        public abstract void GetTexParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="component">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glIndexxOES")]
        public abstract void Indexx([Flow(FlowDirection.In)] int component);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="component">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glIndexxvOES")]
        public abstract unsafe void Indexx([Count(Count = 1), Flow(FlowDirection.In)] int* component);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="component">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glIndexxvOES")]
        public abstract void Indexx([Count(Count = 1), Flow(FlowDirection.In)] ref int component);

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
        public abstract void LightModelx([Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

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
        public abstract unsafe void LightModelx([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

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
        public abstract void LightModelx([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

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
        public abstract void Lightx([Flow(FlowDirection.In)] OES light, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

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
        public abstract unsafe void Lightx([Flow(FlowDirection.In)] OES light, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

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
        public abstract void Lightx([Flow(FlowDirection.In)] OES light, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="width">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glLineWidthxOES")]
        public abstract void LineWidthx([Flow(FlowDirection.In)] int width);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glLoadMatrixxOES")]
        public abstract unsafe void LoadMatrixx([Count(Count = 16), Flow(FlowDirection.In)] int* m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glLoadMatrixxOES")]
        public abstract void LoadMatrixx([Count(Count = 16), Flow(FlowDirection.In)] Span<int> m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glLoadTransposeMatrixxOES")]
        public abstract unsafe void LoadTransposeMatrixx([Count(Count = 16), Flow(FlowDirection.In)] int* m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glLoadTransposeMatrixxOES")]
        public abstract void LoadTransposeMatrixx([Count(Count = 16), Flow(FlowDirection.In)] Span<int> m);

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
        public abstract void Map1x([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int u1, [Flow(FlowDirection.In)] int u2, [Flow(FlowDirection.In)] int stride, [Flow(FlowDirection.In)] int order, [Flow(FlowDirection.In)] int points);

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
        public abstract void Map2x([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int u1, [Flow(FlowDirection.In)] int u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] int points);

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
        public abstract void MapGrid1x([Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int u1, [Flow(FlowDirection.In)] int u2);

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
        public abstract void MapGrid2x([Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int u1, [Flow(FlowDirection.In)] int u2, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2);

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
        public abstract void Materialx([Flow(FlowDirection.In)] OES face, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

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
        public abstract unsafe void Materialx([Flow(FlowDirection.In)] OES face, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

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
        public abstract void Materialx([Flow(FlowDirection.In)] OES face, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

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
        public abstract void MultiTexCoord1x([Flow(FlowDirection.In)] OES texture, [Flow(FlowDirection.In)] int s);

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
        public abstract unsafe void MultiTexCoord1x([Flow(FlowDirection.In)] OES texture, [Count(Count = 1), Flow(FlowDirection.In)] int* coords);

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
        public abstract void MultiTexCoord1x([Flow(FlowDirection.In)] OES texture, [Count(Count = 1), Flow(FlowDirection.In)] ref int coords);

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
        public abstract void MultiTexCoord2x([Flow(FlowDirection.In)] OES texture, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t);

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
        public abstract unsafe void MultiTexCoord2x([Flow(FlowDirection.In)] OES texture, [Count(Count = 2), Flow(FlowDirection.In)] int* coords);

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
        public abstract void MultiTexCoord2x([Flow(FlowDirection.In)] OES texture, [Count(Count = 2), Flow(FlowDirection.In)] Span<int> coords);

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
        public abstract void MultiTexCoord3x([Flow(FlowDirection.In)] OES texture, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r);

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
        public abstract unsafe void MultiTexCoord3x([Flow(FlowDirection.In)] OES texture, [Count(Count = 3), Flow(FlowDirection.In)] int* coords);

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
        public abstract void MultiTexCoord3x([Flow(FlowDirection.In)] OES texture, [Count(Count = 3), Flow(FlowDirection.In)] Span<int> coords);

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
        public abstract void MultiTexCoord4x([Flow(FlowDirection.In)] OES texture, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r, [Flow(FlowDirection.In)] int q);

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
        public abstract unsafe void MultiTexCoord4x([Flow(FlowDirection.In)] OES texture, [Count(Count = 4), Flow(FlowDirection.In)] int* coords);

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
        public abstract void MultiTexCoord4x([Flow(FlowDirection.In)] OES texture, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultMatrixxOES")]
        public abstract unsafe void MultMatrixx([Count(Count = 16), Flow(FlowDirection.In)] int* m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultMatrixxOES")]
        public abstract void MultMatrixx([Count(Count = 16), Flow(FlowDirection.In)] Span<int> m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultTransposeMatrixxOES")]
        public abstract unsafe void MultTransposeMatrixx([Count(Count = 16), Flow(FlowDirection.In)] int* m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultTransposeMatrixxOES")]
        public abstract void MultTransposeMatrixx([Count(Count = 16), Flow(FlowDirection.In)] Span<int> m);

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
        public abstract void Normal3x([Flow(FlowDirection.In)] int nx, [Flow(FlowDirection.In)] int ny, [Flow(FlowDirection.In)] int nz);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormal3xvOES")]
        public abstract unsafe void Normal3x([Count(Count = 3), Flow(FlowDirection.In)] int* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormal3xvOES")]
        public abstract void Normal3x([Count(Count = 3), Flow(FlowDirection.In)] Span<int> coords);

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
        public abstract void Orthox([Flow(FlowDirection.In)] int l, [Flow(FlowDirection.In)] int r, [Flow(FlowDirection.In)] int b, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int f);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="token">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPassThroughxOES")]
        public abstract void PassThroughx([Flow(FlowDirection.In)] int token);

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
        public abstract unsafe void PixelMapx([Flow(FlowDirection.In)] OES map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] int* values);

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
        public abstract void PixelMapx([Flow(FlowDirection.In)] OES map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<int> values);

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
        public abstract void PixelStorex([Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

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
        public abstract void PixelTransferx([Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

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
        public abstract void PixelZoomx([Flow(FlowDirection.In)] int xfactor, [Flow(FlowDirection.In)] int yfactor);

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
        public abstract unsafe void PointParameterx([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

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
        public abstract void PointParameterx([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPointSizexOES")]
        public abstract void PointSizex([Flow(FlowDirection.In)] int size);

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
        public abstract void PolygonOffsetx([Flow(FlowDirection.In)] int factor, [Flow(FlowDirection.In)] int units);

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
        public abstract unsafe void PrioritizeTexturesx([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] int* priorities);

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
        public abstract void PrioritizeTexturesx([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<int> priorities);

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
        public abstract void RasterPos2x([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glRasterPos2xvOES")]
        public abstract unsafe void RasterPos2x([Count(Count = 2), Flow(FlowDirection.In)] int* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glRasterPos2xvOES")]
        public abstract void RasterPos2x([Count(Count = 2), Flow(FlowDirection.In)] Span<int> coords);

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
        public abstract void RasterPos3x([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glRasterPos3xvOES")]
        public abstract unsafe void RasterPos3x([Count(Count = 3), Flow(FlowDirection.In)] int* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glRasterPos3xvOES")]
        public abstract void RasterPos3x([Count(Count = 3), Flow(FlowDirection.In)] Span<int> coords);

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
        public abstract void RasterPos4x([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glRasterPos4xvOES")]
        public abstract unsafe void RasterPos4x([Count(Count = 4), Flow(FlowDirection.In)] int* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glRasterPos4xvOES")]
        public abstract void RasterPos4x([Count(Count = 4), Flow(FlowDirection.In)] Span<int> coords);

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
        public abstract void Rectx([Flow(FlowDirection.In)] int x1, [Flow(FlowDirection.In)] int y1, [Flow(FlowDirection.In)] int x2, [Flow(FlowDirection.In)] int y2);

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
        public abstract unsafe void Rectx([Count(Count = 2), Flow(FlowDirection.In)] int* v1, [Count(Count = 2), Flow(FlowDirection.In)] int* v2);

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
        public abstract void Rectx([Count(Count = 2), Flow(FlowDirection.In)] Span<int> v1, [Count(Count = 2), Flow(FlowDirection.In)] Span<int> v2);

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
        public abstract void Rotatex([Flow(FlowDirection.In)] int angle, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z);

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
        public abstract void Scalex([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="s">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord1xOES")]
        public abstract void TexCoord1x([Flow(FlowDirection.In)] int s);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord1xvOES")]
        public abstract unsafe void TexCoord1x([Count(Count = 1), Flow(FlowDirection.In)] int* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord1xvOES")]
        public abstract void TexCoord1x([Count(Count = 1), Flow(FlowDirection.In)] ref int coords);

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
        public abstract void TexCoord2x([Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord2xvOES")]
        public abstract unsafe void TexCoord2x([Count(Count = 2), Flow(FlowDirection.In)] int* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord2xvOES")]
        public abstract void TexCoord2x([Count(Count = 2), Flow(FlowDirection.In)] Span<int> coords);

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
        public abstract void TexCoord3x([Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord3xvOES")]
        public abstract unsafe void TexCoord3x([Count(Count = 3), Flow(FlowDirection.In)] int* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord3xvOES")]
        public abstract void TexCoord3x([Count(Count = 3), Flow(FlowDirection.In)] Span<int> coords);

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
        public abstract void TexCoord4x([Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r, [Flow(FlowDirection.In)] int q);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord4xvOES")]
        public abstract unsafe void TexCoord4x([Count(Count = 4), Flow(FlowDirection.In)] int* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoord4xvOES")]
        public abstract void TexCoord4x([Count(Count = 4), Flow(FlowDirection.In)] Span<int> coords);

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
        public abstract void TexEnvx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

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
        public abstract unsafe void TexEnvx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

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
        public abstract void TexEnvx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

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
        public abstract void TexGenx([Flow(FlowDirection.In)] OES coord, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

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
        public abstract unsafe void TexGenx([Flow(FlowDirection.In)] OES coord, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

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
        public abstract void TexGenx([Flow(FlowDirection.In)] OES coord, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

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
        public abstract void TexParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

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
        public abstract unsafe void TexParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

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
        public abstract void TexParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

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
        public abstract void Translatex([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertex2xOES")]
        public abstract void Vertex2x([Flow(FlowDirection.In)] int x);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertex2xvOES")]
        public abstract unsafe void Vertex2x([Count(Count = 2), Flow(FlowDirection.In)] int* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertex2xvOES")]
        public abstract void Vertex2x([Count(Count = 2), Flow(FlowDirection.In)] Span<int> coords);

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
        public abstract void Vertex3x([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertex3xvOES")]
        public abstract unsafe void Vertex3x([Count(Count = 3), Flow(FlowDirection.In)] int* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertex3xvOES")]
        public abstract void Vertex3x([Count(Count = 3), Flow(FlowDirection.In)] Span<int> coords);

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
        public abstract void Vertex4x([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertex4xvOES")]
        public abstract unsafe void Vertex4x([Count(Count = 4), Flow(FlowDirection.In)] int* coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coords">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertex4xvOES")]
        public abstract void Vertex4x([Count(Count = 4), Flow(FlowDirection.In)] Span<int> coords);

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
        public abstract void AlphaFuncx([Flow(FlowDirection.In)] AlphaFunction func, [Flow(FlowDirection.In)] int @ref);

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
        public abstract void Bitmapx([Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int xorig, [Flow(FlowDirection.In)] int yorig, [Flow(FlowDirection.In)] int xmove, [Flow(FlowDirection.In)] int ymove, [Flow(FlowDirection.In)] string bitmap);

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
        public abstract unsafe void ClipPlanex([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.In)] int* equation);

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
        public abstract void ClipPlanex([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> equation);

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
        public abstract void ConvolutionParameterx([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Flow(FlowDirection.In)] int param);

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
        public abstract unsafe void ConvolutionParameterx([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

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
        public abstract void ConvolutionParameterx([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

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
        public abstract void Fogx([Flow(FlowDirection.In)] FogPName pname, [Flow(FlowDirection.In)] int param);

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
        public abstract unsafe void Fogx([Flow(FlowDirection.In)] FogPName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

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
        public abstract void Fogx([Flow(FlowDirection.In)] FogPName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

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
        public abstract unsafe void GetClipPlanex([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.Out)] int* equation);

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
        public abstract void GetClipPlanex([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> equation);

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
        public abstract unsafe void GetFixed([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

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
        public abstract void GetFixed([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

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
        public abstract unsafe void GetHistogramParameterx([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

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
        public abstract void GetHistogramParameterx([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

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
        public abstract unsafe void GetLightx([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

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
        public abstract void GetLightx([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

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
        public abstract unsafe void GetMapx([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] GetMapQuery query, [Count(Computed = "query"), Flow(FlowDirection.Out)] int* v);

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
        public abstract void GetMapx([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] GetMapQuery query, [Count(Computed = "query"), Flow(FlowDirection.Out)] out int v);

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
        public abstract void GetMaterialx([Flow(FlowDirection.In)] OES face, [Flow(FlowDirection.In)] MaterialParameter pname, [Flow(FlowDirection.In)] int param);

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
        public abstract unsafe void GetPixelMapx([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] int* values);

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
        public abstract void GetPixelMapx([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<int> values);

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
        public abstract unsafe void GetTexEnvx([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

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
        public abstract void GetTexEnvx([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

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
        public abstract unsafe void GetTexGenx([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

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
        public abstract void GetTexGenx([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

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
        public abstract unsafe void GetTexLevelParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

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
        public abstract void GetTexLevelParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

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
        public abstract unsafe void GetTexParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

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
        public abstract void GetTexParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

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
        public abstract void LightModelx([Flow(FlowDirection.In)] LightModelParameter pname, [Flow(FlowDirection.In)] int param);

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
        public abstract unsafe void LightModelx([Flow(FlowDirection.In)] LightModelParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

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
        public abstract void LightModelx([Flow(FlowDirection.In)] LightModelParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

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
        public abstract void Lightx([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Flow(FlowDirection.In)] int param);

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
        public abstract unsafe void Lightx([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

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
        public abstract void Lightx([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

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
        public abstract void Map1x([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] int u1, [Flow(FlowDirection.In)] int u2, [Flow(FlowDirection.In)] int stride, [Flow(FlowDirection.In)] int order, [Flow(FlowDirection.In)] int points);

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
        public abstract void Map2x([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] int u1, [Flow(FlowDirection.In)] int u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] int points);

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
        public abstract void Materialx([Flow(FlowDirection.In)] OES face, [Flow(FlowDirection.In)] MaterialParameter pname, [Flow(FlowDirection.In)] int param);

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
        public abstract unsafe void Materialx([Flow(FlowDirection.In)] OES face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

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
        public abstract void Materialx([Flow(FlowDirection.In)] OES face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

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
        public abstract void MultiTexCoord1x([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] int s);

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
        public abstract unsafe void MultiTexCoord1x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 1), Flow(FlowDirection.In)] int* coords);

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
        public abstract void MultiTexCoord1x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 1), Flow(FlowDirection.In)] ref int coords);

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
        public abstract void MultiTexCoord2x([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t);

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
        public abstract unsafe void MultiTexCoord2x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 2), Flow(FlowDirection.In)] int* coords);

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
        public abstract void MultiTexCoord2x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 2), Flow(FlowDirection.In)] Span<int> coords);

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
        public abstract void MultiTexCoord3x([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r);

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
        public abstract unsafe void MultiTexCoord3x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 3), Flow(FlowDirection.In)] int* coords);

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
        public abstract void MultiTexCoord3x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 3), Flow(FlowDirection.In)] Span<int> coords);

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
        public abstract void MultiTexCoord4x([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r, [Flow(FlowDirection.In)] int q);

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
        public abstract unsafe void MultiTexCoord4x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 4), Flow(FlowDirection.In)] int* coords);

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
        public abstract void MultiTexCoord4x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> coords);

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
        public abstract unsafe void PixelMapx([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] int* values);

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
        public abstract void PixelMapx([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<int> values);

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
        public abstract void PixelStorex([Flow(FlowDirection.In)] PixelStoreParameter pname, [Flow(FlowDirection.In)] int param);

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
        public abstract void PixelTransferx([Flow(FlowDirection.In)] PixelTransferParameter pname, [Flow(FlowDirection.In)] int param);

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
        public abstract unsafe void PointParameterx([Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

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
        public abstract void PointParameterx([Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

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
        public abstract void TexEnvx([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Flow(FlowDirection.In)] int param);

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
        public abstract unsafe void TexEnvx([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

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
        public abstract void TexEnvx([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

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
        public abstract void TexGenx([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Flow(FlowDirection.In)] int param);

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
        public abstract unsafe void TexGenx([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

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
        public abstract void TexGenx([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

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
        public abstract void TexParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.In)] int param);

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
        public abstract unsafe void TexParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

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
        public abstract void TexParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

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
        public unsafe int GetFixed([Flow(FlowDirection.In)] GetPName pname)
        {
            // ReturnTypeOverloader
            int ret = default;
            GetFixed(pname, &ret);
            return ret;
        }

        public OesFixedPoint(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

