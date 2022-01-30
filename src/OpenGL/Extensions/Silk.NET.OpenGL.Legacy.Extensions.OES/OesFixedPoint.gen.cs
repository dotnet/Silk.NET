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

namespace Silk.NET.OpenGL.Legacy.Extensions.OES
{
    [Extension("OES_fixed_point")]
    public unsafe partial class OesFixedPoint : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_fixed_point";
        [NativeApi(EntryPoint = "glAccumxOES", Convention = CallingConvention.Winapi)]
        public partial void Accumx([Flow(FlowDirection.In)] OES op, [Flow(FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glAlphaFuncxOES", Convention = CallingConvention.Winapi)]
        public partial void AlphaFuncx([Flow(FlowDirection.In)] OES func, [Flow(FlowDirection.In)] int @ref);

        [NativeApi(EntryPoint = "glAlphaFuncxOES", Convention = CallingConvention.Winapi)]
        public partial void AlphaFuncx([Flow(FlowDirection.In)] AlphaFunction func, [Flow(FlowDirection.In)] int @ref);

        [NativeApi(EntryPoint = "glBitmapxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Bitmapx([Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int xorig, [Flow(FlowDirection.In)] int yorig, [Flow(FlowDirection.In)] int xmove, [Flow(FlowDirection.In)] int ymove, [Count(Computed = "width, height"), Flow(FlowDirection.In)] byte* bitmap);

        [NativeApi(EntryPoint = "glBitmapxOES", Convention = CallingConvention.Winapi)]
        public partial void Bitmapx([Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int xorig, [Flow(FlowDirection.In)] int yorig, [Flow(FlowDirection.In)] int xmove, [Flow(FlowDirection.In)] int ymove, [Count(Computed = "width, height"), Flow(FlowDirection.In)] in byte bitmap);

        [NativeApi(EntryPoint = "glBitmapxOES", Convention = CallingConvention.Winapi)]
        public partial void Bitmapx([Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int xorig, [Flow(FlowDirection.In)] int yorig, [Flow(FlowDirection.In)] int xmove, [Flow(FlowDirection.In)] int ymove, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string bitmap);

        [NativeApi(EntryPoint = "glBlendColorxOES", Convention = CallingConvention.Winapi)]
        public partial void BlendColorx([Flow(FlowDirection.In)] int red, [Flow(FlowDirection.In)] int green, [Flow(FlowDirection.In)] int blue, [Flow(FlowDirection.In)] int alpha);

        [NativeApi(EntryPoint = "glClearAccumxOES", Convention = CallingConvention.Winapi)]
        public partial void ClearAccumx([Flow(FlowDirection.In)] int red, [Flow(FlowDirection.In)] int green, [Flow(FlowDirection.In)] int blue, [Flow(FlowDirection.In)] int alpha);

        [NativeApi(EntryPoint = "glClearColorxOES", Convention = CallingConvention.Winapi)]
        public partial void ClearColorx([Flow(FlowDirection.In)] int red, [Flow(FlowDirection.In)] int green, [Flow(FlowDirection.In)] int blue, [Flow(FlowDirection.In)] int alpha);

        [NativeApi(EntryPoint = "glClearDepthxOES", Convention = CallingConvention.Winapi)]
        public partial void ClearDepthx([Flow(FlowDirection.In)] int depth);

        [NativeApi(EntryPoint = "glClipPlanexOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClipPlanex([Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.In)] int* equation);

        [NativeApi(EntryPoint = "glClipPlanexOES", Convention = CallingConvention.Winapi)]
        public partial void ClipPlanex([Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.In)] in int equation);

        [NativeApi(EntryPoint = "glClipPlanexOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClipPlanex([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.In)] int* equation);

        [NativeApi(EntryPoint = "glClipPlanexOES", Convention = CallingConvention.Winapi)]
        public partial void ClipPlanex([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.In)] in int equation);

        [NativeApi(EntryPoint = "glColor3xOES", Convention = CallingConvention.Winapi)]
        public partial void Color3x([Flow(FlowDirection.In)] int red, [Flow(FlowDirection.In)] int green, [Flow(FlowDirection.In)] int blue);

        [NativeApi(EntryPoint = "glColor3xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Color3x([Count(Count = 3), Flow(FlowDirection.In)] int* components);

        [NativeApi(EntryPoint = "glColor3xvOES", Convention = CallingConvention.Winapi)]
        public partial void Color3x([Count(Count = 3), Flow(FlowDirection.In)] in int components);

        [NativeApi(EntryPoint = "glColor4xOES", Convention = CallingConvention.Winapi)]
        public partial void Color4x([Flow(FlowDirection.In)] int red, [Flow(FlowDirection.In)] int green, [Flow(FlowDirection.In)] int blue, [Flow(FlowDirection.In)] int alpha);

        [NativeApi(EntryPoint = "glColor4xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Color4x([Count(Count = 4), Flow(FlowDirection.In)] int* components);

        [NativeApi(EntryPoint = "glColor4xvOES", Convention = CallingConvention.Winapi)]
        public partial void Color4x([Count(Count = 4), Flow(FlowDirection.In)] in int components);

        [NativeApi(EntryPoint = "glConvolutionParameterxOES", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glConvolutionParameterxOES", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glConvolutionParameterxOES", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameterx([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glConvolutionParameterxOES", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameterx([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glConvolutionParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glConvolutionParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glConvolutionParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameterx([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameterx([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glConvolutionParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameterx([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameterx([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glDepthRangexOES", Convention = CallingConvention.Winapi)]
        public partial void DepthRangex([Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int f);

        [NativeApi(EntryPoint = "glEvalCoord1xOES", Convention = CallingConvention.Winapi)]
        public partial void EvalCoord1x([Flow(FlowDirection.In)] int u);

        [NativeApi(EntryPoint = "glEvalCoord1xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void EvalCoord1x([Count(Count = 1), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glEvalCoord1xvOES", Convention = CallingConvention.Winapi)]
        public partial void EvalCoord1x([Count(Count = 1), Flow(FlowDirection.In)] in int coords);

        [NativeApi(EntryPoint = "glEvalCoord2xOES", Convention = CallingConvention.Winapi)]
        public partial void EvalCoord2x([Flow(FlowDirection.In)] int u, [Flow(FlowDirection.In)] int v);

        [NativeApi(EntryPoint = "glEvalCoord2xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void EvalCoord2x([Count(Count = 2), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glEvalCoord2xvOES", Convention = CallingConvention.Winapi)]
        public partial void EvalCoord2x([Count(Count = 2), Flow(FlowDirection.In)] in int coords);

        [NativeApi(EntryPoint = "glFeedbackBufferxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void FeedbackBufferx([Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] OES type, [Count(Parameter = "n"), Flow(FlowDirection.In)] int* buffer);

        [NativeApi(EntryPoint = "glFeedbackBufferxOES", Convention = CallingConvention.Winapi)]
        public partial void FeedbackBufferx([Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] OES type, [Count(Parameter = "n"), Flow(FlowDirection.In)] in int buffer);

        [NativeApi(EntryPoint = "glFogxOES", Convention = CallingConvention.Winapi)]
        public partial void Fogx([Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFogxOES", Convention = CallingConvention.Winapi)]
        public partial void Fogx([Flow(FlowDirection.In)] FogPName pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFogxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Fogx([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glFogxvOES", Convention = CallingConvention.Winapi)]
        public partial void Fogx([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int param);

        [NativeApi(EntryPoint = "glFogxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Fogx([Flow(FlowDirection.In)] FogPName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glFogxvOES", Convention = CallingConvention.Winapi)]
        public partial void Fogx([Flow(FlowDirection.In)] FogPName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int param);

        [NativeApi(EntryPoint = "glFrustumxOES", Convention = CallingConvention.Winapi)]
        public partial void Frustumx([Flow(FlowDirection.In)] int l, [Flow(FlowDirection.In)] int r, [Flow(FlowDirection.In)] int b, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int f);

        [NativeApi(EntryPoint = "glGetClipPlanexOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetClipPlanex([Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.Out)] int* equation);

        [NativeApi(EntryPoint = "glGetClipPlanexOES", Convention = CallingConvention.Winapi)]
        public partial void GetClipPlanex([Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.Out)] out int equation);

        [NativeApi(EntryPoint = "glGetClipPlanexOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetClipPlanex([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.Out)] int* equation);

        [NativeApi(EntryPoint = "glGetClipPlanexOES", Convention = CallingConvention.Winapi)]
        public partial void GetClipPlanex([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.Out)] out int equation);

        [NativeApi(EntryPoint = "glGetConvolutionParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFixedvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFixed([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFixedvOES", Convention = CallingConvention.Winapi)]
        public partial void GetFixed([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFixedvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFixed([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFixedvOES", Convention = CallingConvention.Winapi)]
        public partial void GetFixed([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameterx([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameterx([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameterx([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameterx([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetLightxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetLightx([Flow(FlowDirection.In)] OES light, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetLightxOES", Convention = CallingConvention.Winapi)]
        public partial void GetLightx([Flow(FlowDirection.In)] OES light, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetLightxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetLightx([Flow(FlowDirection.In)] OES light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetLightxOES", Convention = CallingConvention.Winapi)]
        public partial void GetLightx([Flow(FlowDirection.In)] OES light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetLightxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetLightx([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetLightxOES", Convention = CallingConvention.Winapi)]
        public partial void GetLightx([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetLightxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetLightx([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetLightxOES", Convention = CallingConvention.Winapi)]
        public partial void GetLightx([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMapxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES query, [Count(Computed = "query"), Flow(FlowDirection.Out)] int* v);

        [NativeApi(EntryPoint = "glGetMapxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetMapx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES query, [Count(Computed = "query"), Flow(FlowDirection.Out)] out int v);

        [NativeApi(EntryPoint = "glGetMapxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] GetMapQuery query, [Count(Computed = "query"), Flow(FlowDirection.Out)] int* v);

        [NativeApi(EntryPoint = "glGetMapxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetMapx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] GetMapQuery query, [Count(Computed = "query"), Flow(FlowDirection.Out)] out int v);

        [NativeApi(EntryPoint = "glGetMapxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapx([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] OES query, [Count(Computed = "query"), Flow(FlowDirection.Out)] int* v);

        [NativeApi(EntryPoint = "glGetMapxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetMapx([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] OES query, [Count(Computed = "query"), Flow(FlowDirection.Out)] out int v);

        [NativeApi(EntryPoint = "glGetMapxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapx([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] GetMapQuery query, [Count(Computed = "query"), Flow(FlowDirection.Out)] int* v);

        [NativeApi(EntryPoint = "glGetMapxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetMapx([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] GetMapQuery query, [Count(Computed = "query"), Flow(FlowDirection.Out)] out int v);

        [NativeApi(EntryPoint = "glGetMaterialxOES", Convention = CallingConvention.Winapi)]
        public partial void GetMaterialx([Flow(FlowDirection.In)] OES face, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glGetMaterialxOES", Convention = CallingConvention.Winapi)]
        public partial void GetMaterialx([Flow(FlowDirection.In)] OES face, [Flow(FlowDirection.In)] MaterialParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glGetMaterialxOES", Convention = CallingConvention.Winapi)]
        public partial void GetMaterialx([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glGetMaterialxOES", Convention = CallingConvention.Winapi)]
        public partial void GetMaterialx([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glGetPixelMapxv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPixelMapx([Flow(FlowDirection.In)] OES map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetPixelMapxv", Convention = CallingConvention.Winapi)]
        public partial void GetPixelMapx([Flow(FlowDirection.In)] OES map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetPixelMapxv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPixelMapx([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetPixelMapxv", Convention = CallingConvention.Winapi)]
        public partial void GetPixelMapx([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexEnvx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexEnvx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexEnvx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexEnvx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexEnvx([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexEnvx([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexEnvx([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexEnvx([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexGenxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexGenx([Flow(FlowDirection.In)] OES coord, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexGenxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexGenx([Flow(FlowDirection.In)] OES coord, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexGenxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexGenx([Flow(FlowDirection.In)] OES coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexGenxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexGenx([Flow(FlowDirection.In)] OES coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexGenxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexGenx([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexGenxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexGenx([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexGenxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexGenx([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexGenxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexGenx([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexLevelParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexLevelParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexLevelParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexLevelParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexLevelParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexLevelParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexLevelParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexLevelParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glIndexxOES", Convention = CallingConvention.Winapi)]
        public partial void Indexx([Flow(FlowDirection.In)] int component);

        [NativeApi(EntryPoint = "glIndexxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Indexx([Count(Count = 1), Flow(FlowDirection.In)] int* component);

        [NativeApi(EntryPoint = "glIndexxvOES", Convention = CallingConvention.Winapi)]
        public partial void Indexx([Count(Count = 1), Flow(FlowDirection.In)] in int component);

        [NativeApi(EntryPoint = "glLightModelxOES", Convention = CallingConvention.Winapi)]
        public partial void LightModelx([Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glLightModelxOES", Convention = CallingConvention.Winapi)]
        public partial void LightModelx([Flow(FlowDirection.In)] LightModelParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glLightModelxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void LightModelx([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glLightModelxvOES", Convention = CallingConvention.Winapi)]
        public partial void LightModelx([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int param);

        [NativeApi(EntryPoint = "glLightModelxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void LightModelx([Flow(FlowDirection.In)] LightModelParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glLightModelxvOES", Convention = CallingConvention.Winapi)]
        public partial void LightModelx([Flow(FlowDirection.In)] LightModelParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int param);

        [NativeApi(EntryPoint = "glLightxOES", Convention = CallingConvention.Winapi)]
        public partial void Lightx([Flow(FlowDirection.In)] OES light, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glLightxOES", Convention = CallingConvention.Winapi)]
        public partial void Lightx([Flow(FlowDirection.In)] OES light, [Flow(FlowDirection.In)] LightParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glLightxOES", Convention = CallingConvention.Winapi)]
        public partial void Lightx([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glLightxOES", Convention = CallingConvention.Winapi)]
        public partial void Lightx([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glLightxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Lightx([Flow(FlowDirection.In)] OES light, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glLightxvOES", Convention = CallingConvention.Winapi)]
        public partial void Lightx([Flow(FlowDirection.In)] OES light, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glLightxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Lightx([Flow(FlowDirection.In)] OES light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glLightxvOES", Convention = CallingConvention.Winapi)]
        public partial void Lightx([Flow(FlowDirection.In)] OES light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glLightxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Lightx([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glLightxvOES", Convention = CallingConvention.Winapi)]
        public partial void Lightx([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glLightxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Lightx([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glLightxvOES", Convention = CallingConvention.Winapi)]
        public partial void Lightx([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glLineWidthxOES", Convention = CallingConvention.Winapi)]
        public partial void LineWidthx([Flow(FlowDirection.In)] int width);

        [NativeApi(EntryPoint = "glLoadMatrixxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void LoadMatrixx([Count(Count = 16), Flow(FlowDirection.In)] int* m);

        [NativeApi(EntryPoint = "glLoadMatrixxOES", Convention = CallingConvention.Winapi)]
        public partial void LoadMatrixx([Count(Count = 16), Flow(FlowDirection.In)] in int m);

        [NativeApi(EntryPoint = "glLoadTransposeMatrixxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void LoadTransposeMatrixx([Count(Count = 16), Flow(FlowDirection.In)] int* m);

        [NativeApi(EntryPoint = "glLoadTransposeMatrixxOES", Convention = CallingConvention.Winapi)]
        public partial void LoadTransposeMatrixx([Count(Count = 16), Flow(FlowDirection.In)] in int m);

        [NativeApi(EntryPoint = "glMap1xOES", Convention = CallingConvention.Winapi)]
        public partial void Map1x([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int u1, [Flow(FlowDirection.In)] int u2, [Flow(FlowDirection.In)] int stride, [Flow(FlowDirection.In)] int order, [Flow(FlowDirection.In)] int points);

        [NativeApi(EntryPoint = "glMap1xOES", Convention = CallingConvention.Winapi)]
        public partial void Map1x([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] int u1, [Flow(FlowDirection.In)] int u2, [Flow(FlowDirection.In)] int stride, [Flow(FlowDirection.In)] int order, [Flow(FlowDirection.In)] int points);

        [NativeApi(EntryPoint = "glMap2xOES", Convention = CallingConvention.Winapi)]
        public partial void Map2x([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int u1, [Flow(FlowDirection.In)] int u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] int points);

        [NativeApi(EntryPoint = "glMap2xOES", Convention = CallingConvention.Winapi)]
        public partial void Map2x([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] int u1, [Flow(FlowDirection.In)] int u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] int points);

        [NativeApi(EntryPoint = "glMapGrid1xOES", Convention = CallingConvention.Winapi)]
        public partial void MapGrid1x([Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int u1, [Flow(FlowDirection.In)] int u2);

        [NativeApi(EntryPoint = "glMapGrid2xOES", Convention = CallingConvention.Winapi)]
        public partial void MapGrid2x([Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int u1, [Flow(FlowDirection.In)] int u2, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2);

        [NativeApi(EntryPoint = "glMaterialxOES", Convention = CallingConvention.Winapi)]
        public partial void Materialx([Flow(FlowDirection.In)] OES face, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMaterialxOES", Convention = CallingConvention.Winapi)]
        public partial void Materialx([Flow(FlowDirection.In)] OES face, [Flow(FlowDirection.In)] MaterialParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMaterialxOES", Convention = CallingConvention.Winapi)]
        public partial void Materialx([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMaterialxOES", Convention = CallingConvention.Winapi)]
        public partial void Materialx([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMaterialxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Materialx([Flow(FlowDirection.In)] OES face, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glMaterialxvOES", Convention = CallingConvention.Winapi)]
        public partial void Materialx([Flow(FlowDirection.In)] OES face, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int param);

        [NativeApi(EntryPoint = "glMaterialxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Materialx([Flow(FlowDirection.In)] OES face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glMaterialxvOES", Convention = CallingConvention.Winapi)]
        public partial void Materialx([Flow(FlowDirection.In)] OES face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int param);

        [NativeApi(EntryPoint = "glMaterialxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Materialx([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glMaterialxvOES", Convention = CallingConvention.Winapi)]
        public partial void Materialx([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int param);

        [NativeApi(EntryPoint = "glMaterialxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Materialx([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glMaterialxvOES", Convention = CallingConvention.Winapi)]
        public partial void Materialx([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int param);

        [NativeApi(EntryPoint = "glMultiTexCoord1xOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1x([Flow(FlowDirection.In)] OES texture, [Flow(FlowDirection.In)] int s);

        [NativeApi(EntryPoint = "glMultiTexCoord1xOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1x([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] int s);

        [NativeApi(EntryPoint = "glMultiTexCoord1xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord1x([Flow(FlowDirection.In)] OES texture, [Count(Count = 1), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord1xvOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1x([Flow(FlowDirection.In)] OES texture, [Count(Count = 1), Flow(FlowDirection.In)] in int coords);

        [NativeApi(EntryPoint = "glMultiTexCoord1xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord1x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 1), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord1xvOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 1), Flow(FlowDirection.In)] in int coords);

        [NativeApi(EntryPoint = "glMultiTexCoord2xOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2x([Flow(FlowDirection.In)] OES texture, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t);

        [NativeApi(EntryPoint = "glMultiTexCoord2xOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2x([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t);

        [NativeApi(EntryPoint = "glMultiTexCoord2xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord2x([Flow(FlowDirection.In)] OES texture, [Count(Count = 2), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord2xvOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2x([Flow(FlowDirection.In)] OES texture, [Count(Count = 2), Flow(FlowDirection.In)] in int coords);

        [NativeApi(EntryPoint = "glMultiTexCoord2xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord2x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 2), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord2xvOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 2), Flow(FlowDirection.In)] in int coords);

        [NativeApi(EntryPoint = "glMultiTexCoord3xOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3x([Flow(FlowDirection.In)] OES texture, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r);

        [NativeApi(EntryPoint = "glMultiTexCoord3xOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3x([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r);

        [NativeApi(EntryPoint = "glMultiTexCoord3xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord3x([Flow(FlowDirection.In)] OES texture, [Count(Count = 3), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord3xvOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3x([Flow(FlowDirection.In)] OES texture, [Count(Count = 3), Flow(FlowDirection.In)] in int coords);

        [NativeApi(EntryPoint = "glMultiTexCoord3xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord3x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 3), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord3xvOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 3), Flow(FlowDirection.In)] in int coords);

        [NativeApi(EntryPoint = "glMultiTexCoord4xOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4x([Flow(FlowDirection.In)] OES texture, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r, [Flow(FlowDirection.In)] int q);

        [NativeApi(EntryPoint = "glMultiTexCoord4xOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4x([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r, [Flow(FlowDirection.In)] int q);

        [NativeApi(EntryPoint = "glMultiTexCoord4xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord4x([Flow(FlowDirection.In)] OES texture, [Count(Count = 4), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord4xvOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4x([Flow(FlowDirection.In)] OES texture, [Count(Count = 4), Flow(FlowDirection.In)] in int coords);

        [NativeApi(EntryPoint = "glMultiTexCoord4xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord4x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 4), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord4xvOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 4), Flow(FlowDirection.In)] in int coords);

        [NativeApi(EntryPoint = "glMultMatrixxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultMatrixx([Count(Count = 16), Flow(FlowDirection.In)] int* m);

        [NativeApi(EntryPoint = "glMultMatrixxOES", Convention = CallingConvention.Winapi)]
        public partial void MultMatrixx([Count(Count = 16), Flow(FlowDirection.In)] in int m);

        [NativeApi(EntryPoint = "glMultTransposeMatrixxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultTransposeMatrixx([Count(Count = 16), Flow(FlowDirection.In)] int* m);

        [NativeApi(EntryPoint = "glMultTransposeMatrixxOES", Convention = CallingConvention.Winapi)]
        public partial void MultTransposeMatrixx([Count(Count = 16), Flow(FlowDirection.In)] in int m);

        [NativeApi(EntryPoint = "glNormal3xOES", Convention = CallingConvention.Winapi)]
        public partial void Normal3x([Flow(FlowDirection.In)] int nx, [Flow(FlowDirection.In)] int ny, [Flow(FlowDirection.In)] int nz);

        [NativeApi(EntryPoint = "glNormal3xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Normal3x([Count(Count = 3), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glNormal3xvOES", Convention = CallingConvention.Winapi)]
        public partial void Normal3x([Count(Count = 3), Flow(FlowDirection.In)] in int coords);

        [NativeApi(EntryPoint = "glOrthoxOES", Convention = CallingConvention.Winapi)]
        public partial void Orthox([Flow(FlowDirection.In)] int l, [Flow(FlowDirection.In)] int r, [Flow(FlowDirection.In)] int b, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int f);

        [NativeApi(EntryPoint = "glPassThroughxOES", Convention = CallingConvention.Winapi)]
        public partial void PassThroughx([Flow(FlowDirection.In)] int token);

        [NativeApi(EntryPoint = "glPixelMapx", Convention = CallingConvention.Winapi)]
        public unsafe partial void PixelMapx([Flow(FlowDirection.In)] OES map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] int* values);

        [NativeApi(EntryPoint = "glPixelMapx", Convention = CallingConvention.Winapi)]
        public partial void PixelMapx([Flow(FlowDirection.In)] OES map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] in int values);

        [NativeApi(EntryPoint = "glPixelMapx", Convention = CallingConvention.Winapi)]
        public unsafe partial void PixelMapx([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] int* values);

        [NativeApi(EntryPoint = "glPixelMapx", Convention = CallingConvention.Winapi)]
        public partial void PixelMapx([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] in int values);

        [NativeApi(EntryPoint = "glPixelStorex", Convention = CallingConvention.Winapi)]
        public partial void PixelStorex([Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPixelStorex", Convention = CallingConvention.Winapi)]
        public partial void PixelStorex([Flow(FlowDirection.In)] PixelStoreParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPixelTransferxOES", Convention = CallingConvention.Winapi)]
        public partial void PixelTransferx([Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPixelTransferxOES", Convention = CallingConvention.Winapi)]
        public partial void PixelTransferx([Flow(FlowDirection.In)] PixelTransferParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPixelZoomxOES", Convention = CallingConvention.Winapi)]
        public partial void PixelZoomx([Flow(FlowDirection.In)] int xfactor, [Flow(FlowDirection.In)] int yfactor);

        [NativeApi(EntryPoint = "glPointParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void PointParameterx([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glPointParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void PointParameterx([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glPointParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void PointParameterx([Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glPointParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void PointParameterx([Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glPointSizexOES", Convention = CallingConvention.Winapi)]
        public partial void PointSizex([Flow(FlowDirection.In)] int size);

        [NativeApi(EntryPoint = "glPolygonOffsetxOES", Convention = CallingConvention.Winapi)]
        public partial void PolygonOffsetx([Flow(FlowDirection.In)] int factor, [Flow(FlowDirection.In)] int units);

        [NativeApi(EntryPoint = "glPrioritizeTexturesxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void PrioritizeTexturesx([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] int* priorities);

        [NativeApi(EntryPoint = "glPrioritizeTexturesxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void PrioritizeTexturesx([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] in int priorities);

        [NativeApi(EntryPoint = "glPrioritizeTexturesxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void PrioritizeTexturesx([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] int* priorities);

        [NativeApi(EntryPoint = "glPrioritizeTexturesxOES", Convention = CallingConvention.Winapi)]
        public partial void PrioritizeTexturesx([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] in int priorities);

        [NativeApi(EntryPoint = "glPrioritizeTexturesxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void PrioritizeTexturesx([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Texture* textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] int* priorities);

        [NativeApi(EntryPoint = "glPrioritizeTexturesxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void PrioritizeTexturesx([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Texture* textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] in int priorities);

        [NativeApi(EntryPoint = "glPrioritizeTexturesxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void PrioritizeTexturesx([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Texture textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] int* priorities);

        [NativeApi(EntryPoint = "glPrioritizeTexturesxOES", Convention = CallingConvention.Winapi)]
        public partial void PrioritizeTexturesx([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Texture textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] in int priorities);

        [NativeApi(EntryPoint = "glRasterPos2xOES", Convention = CallingConvention.Winapi)]
        public partial void RasterPos2x([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y);

        [NativeApi(EntryPoint = "glRasterPos2xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void RasterPos2x([Count(Count = 2), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glRasterPos2xvOES", Convention = CallingConvention.Winapi)]
        public partial void RasterPos2x([Count(Count = 2), Flow(FlowDirection.In)] in int coords);

        [NativeApi(EntryPoint = "glRasterPos3xOES", Convention = CallingConvention.Winapi)]
        public partial void RasterPos3x([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z);

        [NativeApi(EntryPoint = "glRasterPos3xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void RasterPos3x([Count(Count = 3), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glRasterPos3xvOES", Convention = CallingConvention.Winapi)]
        public partial void RasterPos3x([Count(Count = 3), Flow(FlowDirection.In)] in int coords);

        [NativeApi(EntryPoint = "glRasterPos4xOES", Convention = CallingConvention.Winapi)]
        public partial void RasterPos4x([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glRasterPos4xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void RasterPos4x([Count(Count = 4), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glRasterPos4xvOES", Convention = CallingConvention.Winapi)]
        public partial void RasterPos4x([Count(Count = 4), Flow(FlowDirection.In)] in int coords);

        [NativeApi(EntryPoint = "glRectxOES", Convention = CallingConvention.Winapi)]
        public partial void Rectx([Flow(FlowDirection.In)] int x1, [Flow(FlowDirection.In)] int y1, [Flow(FlowDirection.In)] int x2, [Flow(FlowDirection.In)] int y2);

        [NativeApi(EntryPoint = "glRectxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Rectx([Count(Count = 2), Flow(FlowDirection.In)] int* v1, [Count(Count = 2), Flow(FlowDirection.In)] int* v2);

        [NativeApi(EntryPoint = "glRectxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Rectx([Count(Count = 2), Flow(FlowDirection.In)] int* v1, [Count(Count = 2), Flow(FlowDirection.In)] in int v2);

        [NativeApi(EntryPoint = "glRectxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Rectx([Count(Count = 2), Flow(FlowDirection.In)] in int v1, [Count(Count = 2), Flow(FlowDirection.In)] int* v2);

        [NativeApi(EntryPoint = "glRectxvOES", Convention = CallingConvention.Winapi)]
        public partial void Rectx([Count(Count = 2), Flow(FlowDirection.In)] in int v1, [Count(Count = 2), Flow(FlowDirection.In)] in int v2);

        [NativeApi(EntryPoint = "glRotatexOES", Convention = CallingConvention.Winapi)]
        public partial void Rotatex([Flow(FlowDirection.In)] int angle, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z);

        [NativeApi(EntryPoint = "glScalexOES", Convention = CallingConvention.Winapi)]
        public partial void Scalex([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z);

        [NativeApi(EntryPoint = "glTexCoord1xOES", Convention = CallingConvention.Winapi)]
        public partial void TexCoord1x([Flow(FlowDirection.In)] int s);

        [NativeApi(EntryPoint = "glTexCoord1xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord1x([Count(Count = 1), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glTexCoord1xvOES", Convention = CallingConvention.Winapi)]
        public partial void TexCoord1x([Count(Count = 1), Flow(FlowDirection.In)] in int coords);

        [NativeApi(EntryPoint = "glTexCoord2xOES", Convention = CallingConvention.Winapi)]
        public partial void TexCoord2x([Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t);

        [NativeApi(EntryPoint = "glTexCoord2xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2x([Count(Count = 2), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glTexCoord2xvOES", Convention = CallingConvention.Winapi)]
        public partial void TexCoord2x([Count(Count = 2), Flow(FlowDirection.In)] in int coords);

        [NativeApi(EntryPoint = "glTexCoord3xOES", Convention = CallingConvention.Winapi)]
        public partial void TexCoord3x([Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r);

        [NativeApi(EntryPoint = "glTexCoord3xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord3x([Count(Count = 3), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glTexCoord3xvOES", Convention = CallingConvention.Winapi)]
        public partial void TexCoord3x([Count(Count = 3), Flow(FlowDirection.In)] in int coords);

        [NativeApi(EntryPoint = "glTexCoord4xOES", Convention = CallingConvention.Winapi)]
        public partial void TexCoord4x([Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r, [Flow(FlowDirection.In)] int q);

        [NativeApi(EntryPoint = "glTexCoord4xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord4x([Count(Count = 4), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glTexCoord4xvOES", Convention = CallingConvention.Winapi)]
        public partial void TexCoord4x([Count(Count = 4), Flow(FlowDirection.In)] in int coords);

        [NativeApi(EntryPoint = "glTexEnvxOES", Convention = CallingConvention.Winapi)]
        public partial void TexEnvx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexEnvxOES", Convention = CallingConvention.Winapi)]
        public partial void TexEnvx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexEnvxOES", Convention = CallingConvention.Winapi)]
        public partial void TexEnvx([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexEnvxOES", Convention = CallingConvention.Winapi)]
        public partial void TexEnvx([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexEnvx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public partial void TexEnvx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexEnvx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public partial void TexEnvx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexEnvx([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public partial void TexEnvx([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexEnvx([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public partial void TexEnvx([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTexGenxOES", Convention = CallingConvention.Winapi)]
        public partial void TexGenx([Flow(FlowDirection.In)] OES coord, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexGenxOES", Convention = CallingConvention.Winapi)]
        public partial void TexGenx([Flow(FlowDirection.In)] OES coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexGenxOES", Convention = CallingConvention.Winapi)]
        public partial void TexGenx([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexGenxOES", Convention = CallingConvention.Winapi)]
        public partial void TexGenx([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexGenxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexGenx([Flow(FlowDirection.In)] OES coord, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexGenxvOES", Convention = CallingConvention.Winapi)]
        public partial void TexGenx([Flow(FlowDirection.In)] OES coord, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTexGenxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexGenx([Flow(FlowDirection.In)] OES coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexGenxvOES", Convention = CallingConvention.Winapi)]
        public partial void TexGenx([Flow(FlowDirection.In)] OES coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTexGenxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexGenx([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexGenxvOES", Convention = CallingConvention.Winapi)]
        public partial void TexGenx([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTexGenxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexGenx([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexGenxvOES", Convention = CallingConvention.Winapi)]
        public partial void TexGenx([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTexParameterxOES", Convention = CallingConvention.Winapi)]
        public partial void TexParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexParameterxOES", Convention = CallingConvention.Winapi)]
        public partial void TexParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexParameterxOES", Convention = CallingConvention.Winapi)]
        public partial void TexParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexParameterxOES", Convention = CallingConvention.Winapi)]
        public partial void TexParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void TexParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void TexParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void TexParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void TexParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTranslatexOES", Convention = CallingConvention.Winapi)]
        public partial void Translatex([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z);

        [NativeApi(EntryPoint = "glVertex2xOES", Convention = CallingConvention.Winapi)]
        public partial void Vertex2x([Flow(FlowDirection.In)] int x);

        [NativeApi(EntryPoint = "glVertex2xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vertex2x([Count(Count = 2), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glVertex2xvOES", Convention = CallingConvention.Winapi)]
        public partial void Vertex2x([Count(Count = 2), Flow(FlowDirection.In)] in int coords);

        [NativeApi(EntryPoint = "glVertex3xOES", Convention = CallingConvention.Winapi)]
        public partial void Vertex3x([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y);

        [NativeApi(EntryPoint = "glVertex3xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vertex3x([Count(Count = 3), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glVertex3xvOES", Convention = CallingConvention.Winapi)]
        public partial void Vertex3x([Count(Count = 3), Flow(FlowDirection.In)] in int coords);

        [NativeApi(EntryPoint = "glVertex4xOES", Convention = CallingConvention.Winapi)]
        public partial void Vertex4x([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z);

        [NativeApi(EntryPoint = "glVertex4xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vertex4x([Count(Count = 4), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glVertex4xvOES", Convention = CallingConvention.Winapi)]
        public partial void Vertex4x([Count(Count = 4), Flow(FlowDirection.In)] in int coords);

        public unsafe void FeedbackBufferx([Flow(FlowDirection.In)] OES type, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<int> buffer)
        {
            // ImplicitCountSpanOverloader
            FeedbackBufferx((uint) buffer.Length, type, in buffer.GetPinnableReference());
        }

        public unsafe int GetFixed([Flow(FlowDirection.In)] OES pname)
        {
            // ReturnTypeOverloader
            int ret = default;
            GetFixed(pname, &ret);
            return ret;
        }

        public unsafe void GetPixelMapx([Flow(FlowDirection.In)] OES map, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // ImplicitCountSpanOverloader
            GetPixelMapx(map, (int) values.Length, out values.GetPinnableReference());
        }

        public unsafe void GetPixelMapx([Flow(FlowDirection.In)] PixelMap map, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // ImplicitCountSpanOverloader
            GetPixelMapx(map, (int) values.Length, out values.GetPinnableReference());
        }

        public unsafe void PixelMapx([Flow(FlowDirection.In)] OES map, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<int> values)
        {
            // ImplicitCountSpanOverloader
            PixelMapx(map, (int) values.Length, in values.GetPinnableReference());
        }

        public unsafe void PixelMapx([Flow(FlowDirection.In)] PixelMap map, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<int> values)
        {
            // ImplicitCountSpanOverloader
            PixelMapx(map, (int) values.Length, in values.GetPinnableReference());
        }

        public unsafe void PrioritizeTexturesx([Count(Parameter = "n"), Flow(FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<int> priorities)
        {
            // ImplicitCountSpanOverloader
            PrioritizeTexturesx((uint) priorities.Length, textures, in priorities.GetPinnableReference());
        }

        public unsafe void PrioritizeTexturesx([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] int* priorities)
        {
            // ImplicitCountSpanOverloader
            PrioritizeTexturesx((uint) textures.Length, in textures.GetPinnableReference(), priorities);
        }

        public unsafe void PrioritizeTexturesx([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<int> priorities)
        {
            // ImplicitCountSpanOverloader
            PrioritizeTexturesx((uint) priorities.Length, in textures.GetPinnableReference(), in priorities.GetPinnableReference());
        }

        public unsafe void PrioritizeTexturesx([Count(Parameter = "n"), Flow(FlowDirection.In)] Texture* textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<int> priorities)
        {
            // ImplicitCountSpanOverloader
            PrioritizeTexturesx((uint) priorities.Length, textures, in priorities.GetPinnableReference());
        }

        public unsafe void PrioritizeTexturesx([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] int* priorities)
        {
            // ImplicitCountSpanOverloader
            PrioritizeTexturesx((uint) textures.Length, in textures.GetPinnableReference(), priorities);
        }

        public unsafe void PrioritizeTexturesx([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<int> priorities)
        {
            // ImplicitCountSpanOverloader
            PrioritizeTexturesx((uint) priorities.Length, in textures.GetPinnableReference(), in priorities.GetPinnableReference());
        }

        public OesFixedPoint(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

