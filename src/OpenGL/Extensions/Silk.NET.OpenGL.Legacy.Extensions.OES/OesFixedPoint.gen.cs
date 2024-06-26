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
        public partial void Accumx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES op, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glAlphaFuncxOES", Convention = CallingConvention.Winapi)]
        public partial void AlphaFuncx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES func, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int @ref);

        [NativeApi(EntryPoint = "glAlphaFuncxOES", Convention = CallingConvention.Winapi)]
        public partial void AlphaFuncx([Flow(Silk.NET.Core.Native.FlowDirection.In)] AlphaFunction func, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int @ref);

        [NativeApi(EntryPoint = "glBitmapxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Bitmapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xorig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yorig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xmove, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ymove, [Count(Computed = "width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* bitmap);

        [NativeApi(EntryPoint = "glBitmapxOES", Convention = CallingConvention.Winapi)]
        public partial void Bitmapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xorig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yorig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xmove, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ymove, [Count(Computed = "width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte bitmap);

        [NativeApi(EntryPoint = "glBitmapxOES", Convention = CallingConvention.Winapi)]
        public partial void Bitmapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xorig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yorig, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xmove, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ymove, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string bitmap);

        [NativeApi(EntryPoint = "glBlendColorxOES", Convention = CallingConvention.Winapi)]
        public partial void BlendColorx([Flow(Silk.NET.Core.Native.FlowDirection.In)] int red, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int green, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int blue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int alpha);

        [NativeApi(EntryPoint = "glClearAccumxOES", Convention = CallingConvention.Winapi)]
        public partial void ClearAccumx([Flow(Silk.NET.Core.Native.FlowDirection.In)] int red, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int green, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int blue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int alpha);

        [NativeApi(EntryPoint = "glClearColorxOES", Convention = CallingConvention.Winapi)]
        public partial void ClearColorx([Flow(Silk.NET.Core.Native.FlowDirection.In)] int red, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int green, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int blue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int alpha);

        [NativeApi(EntryPoint = "glClearDepthxOES", Convention = CallingConvention.Winapi)]
        public partial void ClearDepthx([Flow(Silk.NET.Core.Native.FlowDirection.In)] int depth);

        [NativeApi(EntryPoint = "glClipPlanexOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClipPlanex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES plane, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* equation);

        [NativeApi(EntryPoint = "glClipPlanexOES", Convention = CallingConvention.Winapi)]
        public partial void ClipPlanex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES plane, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int equation);

        [NativeApi(EntryPoint = "glClipPlanexOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClipPlanex([Flow(Silk.NET.Core.Native.FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* equation);

        [NativeApi(EntryPoint = "glClipPlanexOES", Convention = CallingConvention.Winapi)]
        public partial void ClipPlanex([Flow(Silk.NET.Core.Native.FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int equation);

        [NativeApi(EntryPoint = "glColor3xOES", Convention = CallingConvention.Winapi)]
        public partial void Color3x([Flow(Silk.NET.Core.Native.FlowDirection.In)] int red, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int green, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int blue);

        [NativeApi(EntryPoint = "glColor3xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Color3x([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* components);

        [NativeApi(EntryPoint = "glColor3xvOES", Convention = CallingConvention.Winapi)]
        public partial void Color3x([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int components);

        [NativeApi(EntryPoint = "glColor4xOES", Convention = CallingConvention.Winapi)]
        public partial void Color4x([Flow(Silk.NET.Core.Native.FlowDirection.In)] int red, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int green, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int blue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int alpha);

        [NativeApi(EntryPoint = "glColor4xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Color4x([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* components);

        [NativeApi(EntryPoint = "glColor4xvOES", Convention = CallingConvention.Winapi)]
        public partial void Color4x([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int components);

        [NativeApi(EntryPoint = "glConvolutionParameterxOES", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glConvolutionParameterxOES", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glConvolutionParameterxOES", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glConvolutionParameterxOES", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glConvolutionParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glConvolutionParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glConvolutionParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glConvolutionParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glDepthRangexOES", Convention = CallingConvention.Winapi)]
        public partial void DepthRangex([Flow(Silk.NET.Core.Native.FlowDirection.In)] int n, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int f);

        [NativeApi(EntryPoint = "glEvalCoord1xOES", Convention = CallingConvention.Winapi)]
        public partial void EvalCoord1x([Flow(Silk.NET.Core.Native.FlowDirection.In)] int u);

        [NativeApi(EntryPoint = "glEvalCoord1xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void EvalCoord1x([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glEvalCoord1xvOES", Convention = CallingConvention.Winapi)]
        public partial void EvalCoord1x([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int coords);

        [NativeApi(EntryPoint = "glEvalCoord2xOES", Convention = CallingConvention.Winapi)]
        public partial void EvalCoord2x([Flow(Silk.NET.Core.Native.FlowDirection.In)] int u, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v);

        [NativeApi(EntryPoint = "glEvalCoord2xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void EvalCoord2x([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glEvalCoord2xvOES", Convention = CallingConvention.Winapi)]
        public partial void EvalCoord2x([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int coords);

        [NativeApi(EntryPoint = "glFeedbackBufferxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void FeedbackBufferx([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* buffer);

        [NativeApi(EntryPoint = "glFeedbackBufferxOES", Convention = CallingConvention.Winapi)]
        public partial void FeedbackBufferx([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int buffer);

        [NativeApi(EntryPoint = "glFogxOES", Convention = CallingConvention.Winapi)]
        public partial void Fogx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFogxOES", Convention = CallingConvention.Winapi)]
        public partial void Fogx([Flow(Silk.NET.Core.Native.FlowDirection.In)] FogPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFogxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Fogx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glFogxvOES", Convention = CallingConvention.Winapi)]
        public partial void Fogx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int param);

        [NativeApi(EntryPoint = "glFogxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Fogx([Flow(Silk.NET.Core.Native.FlowDirection.In)] FogPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glFogxvOES", Convention = CallingConvention.Winapi)]
        public partial void Fogx([Flow(Silk.NET.Core.Native.FlowDirection.In)] FogPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int param);

        [NativeApi(EntryPoint = "glFrustumxOES", Convention = CallingConvention.Winapi)]
        public partial void Frustumx([Flow(Silk.NET.Core.Native.FlowDirection.In)] int l, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int b, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int n, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int f);

        [NativeApi(EntryPoint = "glGetClipPlanexOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetClipPlanex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES plane, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* equation);

        [NativeApi(EntryPoint = "glGetClipPlanexOES", Convention = CallingConvention.Winapi)]
        public partial void GetClipPlanex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES plane, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int equation);

        [NativeApi(EntryPoint = "glGetClipPlanexOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetClipPlanex([Flow(Silk.NET.Core.Native.FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* equation);

        [NativeApi(EntryPoint = "glGetClipPlanexOES", Convention = CallingConvention.Winapi)]
        public partial void GetClipPlanex([Flow(Silk.NET.Core.Native.FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int equation);

        [NativeApi(EntryPoint = "glGetConvolutionParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFixedvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFixed([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFixedvOES", Convention = CallingConvention.Winapi)]
        public partial void GetFixed([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFixedvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFixed([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFixedvOES", Convention = CallingConvention.Winapi)]
        public partial void GetFixed([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetLightxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetLightx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetLightxOES", Convention = CallingConvention.Winapi)]
        public partial void GetLightx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetLightxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetLightx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetLightxOES", Convention = CallingConvention.Winapi)]
        public partial void GetLightx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetLightxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetLightx([Flow(Silk.NET.Core.Native.FlowDirection.In)] LightName light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetLightxOES", Convention = CallingConvention.Winapi)]
        public partial void GetLightx([Flow(Silk.NET.Core.Native.FlowDirection.In)] LightName light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetLightxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetLightx([Flow(Silk.NET.Core.Native.FlowDirection.In)] LightName light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetLightxOES", Convention = CallingConvention.Winapi)]
        public partial void GetLightx([Flow(Silk.NET.Core.Native.FlowDirection.In)] LightName light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMapxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES query, [Count(Computed = "query"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* v);

        [NativeApi(EntryPoint = "glGetMapxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetMapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES query, [Count(Computed = "query"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int v);

        [NativeApi(EntryPoint = "glGetMapxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMapQuery query, [Count(Computed = "query"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* v);

        [NativeApi(EntryPoint = "glGetMapxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetMapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMapQuery query, [Count(Computed = "query"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int v);

        [NativeApi(EntryPoint = "glGetMapxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES query, [Count(Computed = "query"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* v);

        [NativeApi(EntryPoint = "glGetMapxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetMapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES query, [Count(Computed = "query"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int v);

        [NativeApi(EntryPoint = "glGetMapxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMapQuery query, [Count(Computed = "query"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* v);

        [NativeApi(EntryPoint = "glGetMapxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetMapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMapQuery query, [Count(Computed = "query"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int v);

        [NativeApi(EntryPoint = "glGetMaterialxOES", Convention = CallingConvention.Winapi)]
        public partial void GetMaterialx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glGetMaterialxOES", Convention = CallingConvention.Winapi)]
        public partial void GetMaterialx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glGetMaterialxOES", Convention = CallingConvention.Winapi)]
        public partial void GetMaterialx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glGetMaterialxOES", Convention = CallingConvention.Winapi)]
        public partial void GetMaterialx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glGetPixelMapxv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPixelMapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetPixelMapxv", Convention = CallingConvention.Winapi)]
        public partial void GetPixelMapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetPixelMapxv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPixelMapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelMap map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetPixelMapxv", Convention = CallingConvention.Winapi)]
        public partial void GetPixelMapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelMap map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexEnvx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexEnvx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexEnvx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexEnvx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexEnvx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureEnvTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexEnvx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureEnvTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexEnvx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureEnvTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexEnvx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureEnvTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexGenxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexGenx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexGenxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexGenx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexGenxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexGenx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexGenxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexGenx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexGenxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexGenx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureCoordName coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexGenxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexGenx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureCoordName coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexGenxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexGenx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureCoordName coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexGenxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexGenx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureCoordName coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexLevelParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexLevelParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexLevelParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexLevelParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexLevelParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexLevelParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexLevelParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexLevelParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void GetTexParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glIndexxOES", Convention = CallingConvention.Winapi)]
        public partial void Indexx([Flow(Silk.NET.Core.Native.FlowDirection.In)] int component);

        [NativeApi(EntryPoint = "glIndexxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Indexx([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* component);

        [NativeApi(EntryPoint = "glIndexxvOES", Convention = CallingConvention.Winapi)]
        public partial void Indexx([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int component);

        [NativeApi(EntryPoint = "glLightModelxOES", Convention = CallingConvention.Winapi)]
        public partial void LightModelx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glLightModelxOES", Convention = CallingConvention.Winapi)]
        public partial void LightModelx([Flow(Silk.NET.Core.Native.FlowDirection.In)] LightModelParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glLightModelxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void LightModelx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glLightModelxvOES", Convention = CallingConvention.Winapi)]
        public partial void LightModelx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int param);

        [NativeApi(EntryPoint = "glLightModelxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void LightModelx([Flow(Silk.NET.Core.Native.FlowDirection.In)] LightModelParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glLightModelxvOES", Convention = CallingConvention.Winapi)]
        public partial void LightModelx([Flow(Silk.NET.Core.Native.FlowDirection.In)] LightModelParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int param);

        [NativeApi(EntryPoint = "glLightxOES", Convention = CallingConvention.Winapi)]
        public partial void Lightx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glLightxOES", Convention = CallingConvention.Winapi)]
        public partial void Lightx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LightParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glLightxOES", Convention = CallingConvention.Winapi)]
        public partial void Lightx([Flow(Silk.NET.Core.Native.FlowDirection.In)] LightName light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glLightxOES", Convention = CallingConvention.Winapi)]
        public partial void Lightx([Flow(Silk.NET.Core.Native.FlowDirection.In)] LightName light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LightParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glLightxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Lightx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glLightxvOES", Convention = CallingConvention.Winapi)]
        public partial void Lightx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glLightxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Lightx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glLightxvOES", Convention = CallingConvention.Winapi)]
        public partial void Lightx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glLightxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Lightx([Flow(Silk.NET.Core.Native.FlowDirection.In)] LightName light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glLightxvOES", Convention = CallingConvention.Winapi)]
        public partial void Lightx([Flow(Silk.NET.Core.Native.FlowDirection.In)] LightName light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glLightxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Lightx([Flow(Silk.NET.Core.Native.FlowDirection.In)] LightName light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glLightxvOES", Convention = CallingConvention.Winapi)]
        public partial void Lightx([Flow(Silk.NET.Core.Native.FlowDirection.In)] LightName light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glLineWidthxOES", Convention = CallingConvention.Winapi)]
        public partial void LineWidthx([Flow(Silk.NET.Core.Native.FlowDirection.In)] int width);

        [NativeApi(EntryPoint = "glLoadMatrixxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void LoadMatrixx([Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* m);

        [NativeApi(EntryPoint = "glLoadMatrixxOES", Convention = CallingConvention.Winapi)]
        public partial void LoadMatrixx([Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int m);

        [NativeApi(EntryPoint = "glLoadTransposeMatrixxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void LoadTransposeMatrixx([Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* m);

        [NativeApi(EntryPoint = "glLoadTransposeMatrixxOES", Convention = CallingConvention.Winapi)]
        public partial void LoadTransposeMatrixx([Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int m);

        [NativeApi(EntryPoint = "glMap1xOES", Convention = CallingConvention.Winapi)]
        public partial void Map1x([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int u1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int u2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int order, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int points);

        [NativeApi(EntryPoint = "glMap1xOES", Convention = CallingConvention.Winapi)]
        public partial void Map1x([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int u1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int u2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int order, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int points);

        [NativeApi(EntryPoint = "glMap2xOES", Convention = CallingConvention.Winapi)]
        public partial void Map2x([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int u1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int u2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ustride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int uorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int points);

        [NativeApi(EntryPoint = "glMap2xOES", Convention = CallingConvention.Winapi)]
        public partial void Map2x([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int u1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int u2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ustride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int uorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int points);

        [NativeApi(EntryPoint = "glMapGrid1xOES", Convention = CallingConvention.Winapi)]
        public partial void MapGrid1x([Flow(Silk.NET.Core.Native.FlowDirection.In)] int n, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int u1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int u2);

        [NativeApi(EntryPoint = "glMapGrid2xOES", Convention = CallingConvention.Winapi)]
        public partial void MapGrid2x([Flow(Silk.NET.Core.Native.FlowDirection.In)] int n, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int u1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int u2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v2);

        [NativeApi(EntryPoint = "glMaterialxOES", Convention = CallingConvention.Winapi)]
        public partial void Materialx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMaterialxOES", Convention = CallingConvention.Winapi)]
        public partial void Materialx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMaterialxOES", Convention = CallingConvention.Winapi)]
        public partial void Materialx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMaterialxOES", Convention = CallingConvention.Winapi)]
        public partial void Materialx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMaterialxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Materialx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glMaterialxvOES", Convention = CallingConvention.Winapi)]
        public partial void Materialx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int param);

        [NativeApi(EntryPoint = "glMaterialxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Materialx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glMaterialxvOES", Convention = CallingConvention.Winapi)]
        public partial void Materialx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int param);

        [NativeApi(EntryPoint = "glMaterialxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Materialx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glMaterialxvOES", Convention = CallingConvention.Winapi)]
        public partial void Materialx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int param);

        [NativeApi(EntryPoint = "glMaterialxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Materialx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glMaterialxvOES", Convention = CallingConvention.Winapi)]
        public partial void Materialx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int param);

        [NativeApi(EntryPoint = "glMultiTexCoord1xOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1x([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int s);

        [NativeApi(EntryPoint = "glMultiTexCoord1xOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1x([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int s);

        [NativeApi(EntryPoint = "glMultiTexCoord1xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord1x([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES texture, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord1xvOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1x([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES texture, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int coords);

        [NativeApi(EntryPoint = "glMultiTexCoord1xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord1x([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord1xvOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord1x([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int coords);

        [NativeApi(EntryPoint = "glMultiTexCoord2xOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2x([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int t);

        [NativeApi(EntryPoint = "glMultiTexCoord2xOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2x([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int t);

        [NativeApi(EntryPoint = "glMultiTexCoord2xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord2x([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES texture, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord2xvOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2x([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES texture, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int coords);

        [NativeApi(EntryPoint = "glMultiTexCoord2xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord2x([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord2xvOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord2x([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int coords);

        [NativeApi(EntryPoint = "glMultiTexCoord3xOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3x([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int r);

        [NativeApi(EntryPoint = "glMultiTexCoord3xOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3x([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int r);

        [NativeApi(EntryPoint = "glMultiTexCoord3xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord3x([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES texture, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord3xvOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3x([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES texture, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int coords);

        [NativeApi(EntryPoint = "glMultiTexCoord3xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord3x([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord3xvOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord3x([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int coords);

        [NativeApi(EntryPoint = "glMultiTexCoord4xOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4x([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int q);

        [NativeApi(EntryPoint = "glMultiTexCoord4xOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4x([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int q);

        [NativeApi(EntryPoint = "glMultiTexCoord4xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord4x([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES texture, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord4xvOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4x([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES texture, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int coords);

        [NativeApi(EntryPoint = "glMultiTexCoord4xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoord4x([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord4xvOES", Convention = CallingConvention.Winapi)]
        public partial void MultiTexCoord4x([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int coords);

        [NativeApi(EntryPoint = "glMultMatrixxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultMatrixx([Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* m);

        [NativeApi(EntryPoint = "glMultMatrixxOES", Convention = CallingConvention.Winapi)]
        public partial void MultMatrixx([Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int m);

        [NativeApi(EntryPoint = "glMultTransposeMatrixxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultTransposeMatrixx([Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* m);

        [NativeApi(EntryPoint = "glMultTransposeMatrixxOES", Convention = CallingConvention.Winapi)]
        public partial void MultTransposeMatrixx([Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int m);

        [NativeApi(EntryPoint = "glNormal3xOES", Convention = CallingConvention.Winapi)]
        public partial void Normal3x([Flow(Silk.NET.Core.Native.FlowDirection.In)] int nx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ny, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int nz);

        [NativeApi(EntryPoint = "glNormal3xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Normal3x([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glNormal3xvOES", Convention = CallingConvention.Winapi)]
        public partial void Normal3x([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int coords);

        [NativeApi(EntryPoint = "glOrthoxOES", Convention = CallingConvention.Winapi)]
        public partial void Orthox([Flow(Silk.NET.Core.Native.FlowDirection.In)] int l, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int b, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int n, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int f);

        [NativeApi(EntryPoint = "glPassThroughxOES", Convention = CallingConvention.Winapi)]
        public partial void PassThroughx([Flow(Silk.NET.Core.Native.FlowDirection.In)] int token);

        [NativeApi(EntryPoint = "glPixelMapx", Convention = CallingConvention.Winapi)]
        public unsafe partial void PixelMapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* values);

        [NativeApi(EntryPoint = "glPixelMapx", Convention = CallingConvention.Winapi)]
        public partial void PixelMapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int values);

        [NativeApi(EntryPoint = "glPixelMapx", Convention = CallingConvention.Winapi)]
        public unsafe partial void PixelMapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelMap map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* values);

        [NativeApi(EntryPoint = "glPixelMapx", Convention = CallingConvention.Winapi)]
        public partial void PixelMapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelMap map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int values);

        [NativeApi(EntryPoint = "glPixelStorex", Convention = CallingConvention.Winapi)]
        public partial void PixelStorex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPixelStorex", Convention = CallingConvention.Winapi)]
        public partial void PixelStorex([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelStoreParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPixelTransferxOES", Convention = CallingConvention.Winapi)]
        public partial void PixelTransferx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPixelTransferxOES", Convention = CallingConvention.Winapi)]
        public partial void PixelTransferx([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelTransferParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPixelZoomxOES", Convention = CallingConvention.Winapi)]
        public partial void PixelZoomx([Flow(Silk.NET.Core.Native.FlowDirection.In)] int xfactor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yfactor);

        [NativeApi(EntryPoint = "glPointParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void PointParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glPointParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void PointParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glPointParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void PointParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glPointParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void PointParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glPointSizexOES", Convention = CallingConvention.Winapi)]
        public partial void PointSizex([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size);

        [NativeApi(EntryPoint = "glPolygonOffsetxOES", Convention = CallingConvention.Winapi)]
        public partial void PolygonOffsetx([Flow(Silk.NET.Core.Native.FlowDirection.In)] int factor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int units);

        [NativeApi(EntryPoint = "glPrioritizeTexturesxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void PrioritizeTexturesx([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* priorities);

        [NativeApi(EntryPoint = "glPrioritizeTexturesxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void PrioritizeTexturesx([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int priorities);

        [NativeApi(EntryPoint = "glPrioritizeTexturesxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void PrioritizeTexturesx([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* priorities);

        [NativeApi(EntryPoint = "glPrioritizeTexturesxOES", Convention = CallingConvention.Winapi)]
        public partial void PrioritizeTexturesx([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int priorities);

        [NativeApi(EntryPoint = "glPrioritizeTexturesxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void PrioritizeTexturesx([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* priorities);

        [NativeApi(EntryPoint = "glPrioritizeTexturesxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void PrioritizeTexturesx([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int priorities);

        [NativeApi(EntryPoint = "glPrioritizeTexturesxOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void PrioritizeTexturesx([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* priorities);

        [NativeApi(EntryPoint = "glPrioritizeTexturesxOES", Convention = CallingConvention.Winapi)]
        public partial void PrioritizeTexturesx([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int priorities);

        [NativeApi(EntryPoint = "glRasterPos2xOES", Convention = CallingConvention.Winapi)]
        public partial void RasterPos2x([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y);

        [NativeApi(EntryPoint = "glRasterPos2xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void RasterPos2x([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glRasterPos2xvOES", Convention = CallingConvention.Winapi)]
        public partial void RasterPos2x([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int coords);

        [NativeApi(EntryPoint = "glRasterPos3xOES", Convention = CallingConvention.Winapi)]
        public partial void RasterPos3x([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int z);

        [NativeApi(EntryPoint = "glRasterPos3xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void RasterPos3x([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glRasterPos3xvOES", Convention = CallingConvention.Winapi)]
        public partial void RasterPos3x([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int coords);

        [NativeApi(EntryPoint = "glRasterPos4xOES", Convention = CallingConvention.Winapi)]
        public partial void RasterPos4x([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glRasterPos4xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void RasterPos4x([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glRasterPos4xvOES", Convention = CallingConvention.Winapi)]
        public partial void RasterPos4x([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int coords);

        [NativeApi(EntryPoint = "glRectxOES", Convention = CallingConvention.Winapi)]
        public partial void Rectx([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y2);

        [NativeApi(EntryPoint = "glRectxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Rectx([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v1, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v2);

        [NativeApi(EntryPoint = "glRectxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Rectx([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v1, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int v2);

        [NativeApi(EntryPoint = "glRectxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Rectx([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int v1, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v2);

        [NativeApi(EntryPoint = "glRectxvOES", Convention = CallingConvention.Winapi)]
        public partial void Rectx([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int v1, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int v2);

        [NativeApi(EntryPoint = "glRotatexOES", Convention = CallingConvention.Winapi)]
        public partial void Rotatex([Flow(Silk.NET.Core.Native.FlowDirection.In)] int angle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int z);

        [NativeApi(EntryPoint = "glScalexOES", Convention = CallingConvention.Winapi)]
        public partial void Scalex([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int z);

        [NativeApi(EntryPoint = "glTexCoord1xOES", Convention = CallingConvention.Winapi)]
        public partial void TexCoord1x([Flow(Silk.NET.Core.Native.FlowDirection.In)] int s);

        [NativeApi(EntryPoint = "glTexCoord1xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord1x([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glTexCoord1xvOES", Convention = CallingConvention.Winapi)]
        public partial void TexCoord1x([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int coords);

        [NativeApi(EntryPoint = "glTexCoord2xOES", Convention = CallingConvention.Winapi)]
        public partial void TexCoord2x([Flow(Silk.NET.Core.Native.FlowDirection.In)] int s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int t);

        [NativeApi(EntryPoint = "glTexCoord2xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2x([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glTexCoord2xvOES", Convention = CallingConvention.Winapi)]
        public partial void TexCoord2x([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int coords);

        [NativeApi(EntryPoint = "glTexCoord3xOES", Convention = CallingConvention.Winapi)]
        public partial void TexCoord3x([Flow(Silk.NET.Core.Native.FlowDirection.In)] int s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int r);

        [NativeApi(EntryPoint = "glTexCoord3xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord3x([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glTexCoord3xvOES", Convention = CallingConvention.Winapi)]
        public partial void TexCoord3x([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int coords);

        [NativeApi(EntryPoint = "glTexCoord4xOES", Convention = CallingConvention.Winapi)]
        public partial void TexCoord4x([Flow(Silk.NET.Core.Native.FlowDirection.In)] int s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int q);

        [NativeApi(EntryPoint = "glTexCoord4xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord4x([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glTexCoord4xvOES", Convention = CallingConvention.Winapi)]
        public partial void TexCoord4x([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int coords);

        [NativeApi(EntryPoint = "glTexEnvxOES", Convention = CallingConvention.Winapi)]
        public partial void TexEnvx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexEnvxOES", Convention = CallingConvention.Winapi)]
        public partial void TexEnvx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureEnvParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexEnvxOES", Convention = CallingConvention.Winapi)]
        public partial void TexEnvx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureEnvTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexEnvxOES", Convention = CallingConvention.Winapi)]
        public partial void TexEnvx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureEnvTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureEnvParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexEnvx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public partial void TexEnvx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexEnvx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public partial void TexEnvx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexEnvx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureEnvTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public partial void TexEnvx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureEnvTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexEnvx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureEnvTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexEnvxvOES", Convention = CallingConvention.Winapi)]
        public partial void TexEnvx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureEnvTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glTexGenxOES", Convention = CallingConvention.Winapi)]
        public partial void TexGenx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexGenxOES", Convention = CallingConvention.Winapi)]
        public partial void TexGenx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureGenParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexGenxOES", Convention = CallingConvention.Winapi)]
        public partial void TexGenx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureCoordName coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexGenxOES", Convention = CallingConvention.Winapi)]
        public partial void TexGenx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureCoordName coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureGenParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexGenxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexGenx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexGenxvOES", Convention = CallingConvention.Winapi)]
        public partial void TexGenx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glTexGenxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexGenx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexGenxvOES", Convention = CallingConvention.Winapi)]
        public partial void TexGenx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glTexGenxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexGenx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureCoordName coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexGenxvOES", Convention = CallingConvention.Winapi)]
        public partial void TexGenx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureCoordName coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glTexGenxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexGenx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureCoordName coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexGenxvOES", Convention = CallingConvention.Winapi)]
        public partial void TexGenx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureCoordName coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glTexParameterxOES", Convention = CallingConvention.Winapi)]
        public partial void TexParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexParameterxOES", Convention = CallingConvention.Winapi)]
        public partial void TexParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexParameterxOES", Convention = CallingConvention.Winapi)]
        public partial void TexParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexParameterxOES", Convention = CallingConvention.Winapi)]
        public partial void TexParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void TexParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void TexParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void TexParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameterxvOES", Convention = CallingConvention.Winapi)]
        public partial void TexParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glTranslatexOES", Convention = CallingConvention.Winapi)]
        public partial void Translatex([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int z);

        [NativeApi(EntryPoint = "glVertex2xOES", Convention = CallingConvention.Winapi)]
        public partial void Vertex2x([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x);

        [NativeApi(EntryPoint = "glVertex2xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vertex2x([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glVertex2xvOES", Convention = CallingConvention.Winapi)]
        public partial void Vertex2x([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int coords);

        [NativeApi(EntryPoint = "glVertex3xOES", Convention = CallingConvention.Winapi)]
        public partial void Vertex3x([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y);

        [NativeApi(EntryPoint = "glVertex3xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vertex3x([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glVertex3xvOES", Convention = CallingConvention.Winapi)]
        public partial void Vertex3x([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int coords);

        [NativeApi(EntryPoint = "glVertex4xOES", Convention = CallingConvention.Winapi)]
        public partial void Vertex4x([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int z);

        [NativeApi(EntryPoint = "glVertex4xvOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vertex4x([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glVertex4xvOES", Convention = CallingConvention.Winapi)]
        public partial void Vertex4x([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int coords);

        public unsafe void FeedbackBufferx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES type, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> buffer)
        {
            // ImplicitCountSpanOverloader
            FeedbackBufferx((uint) buffer.Length, type, in buffer.GetPinnableReference());
        }

        public unsafe int GetFixed([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname)
        {
            // ReturnTypeOverloader
            int ret = default;
            GetFixed(pname, &ret);
            return ret;
        }

        public unsafe int GetFixed([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPName pname)
        {
            // ReturnTypeOverloader
            int ret = default;
            GetFixed(pname, &ret);
            return ret;
        }

        public unsafe int GetPixelMapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES map)
        {
            const int size = 1;
            // ReturnTypeOverloader
            int ret = default;
            GetPixelMapx(map, size, &ret);
            return ret;
        }

        public unsafe void GetPixelMapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES map, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> values)
        {
            // ImplicitCountSpanOverloader
            GetPixelMapx(map, (int) values.Length, out values.GetPinnableReference());
        }

        public unsafe int GetPixelMapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelMap map)
        {
            const int size = 1;
            // ReturnTypeOverloader
            int ret = default;
            GetPixelMapx(map, size, &ret);
            return ret;
        }

        public unsafe void GetPixelMapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelMap map, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> values)
        {
            // ImplicitCountSpanOverloader
            GetPixelMapx(map, (int) values.Length, out values.GetPinnableReference());
        }

        public unsafe void PixelMapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES map, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> values)
        {
            // ImplicitCountSpanOverloader
            PixelMapx(map, (int) values.Length, in values.GetPinnableReference());
        }

        public unsafe void PixelMapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelMap map, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> values)
        {
            // ImplicitCountSpanOverloader
            PixelMapx(map, (int) values.Length, in values.GetPinnableReference());
        }

        public unsafe void PrioritizeTexturesx([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> priorities)
        {
            // ImplicitCountSpanOverloader
            PrioritizeTexturesx((uint) priorities.Length, textures, in priorities.GetPinnableReference());
        }

        public unsafe void PrioritizeTexturesx([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* priorities)
        {
            // ImplicitCountSpanOverloader
            PrioritizeTexturesx((uint) textures.Length, in textures.GetPinnableReference(), priorities);
        }

        public unsafe void PrioritizeTexturesx([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> priorities)
        {
            // ImplicitCountSpanOverloader
            PrioritizeTexturesx((uint) priorities.Length, in textures.GetPinnableReference(), in priorities.GetPinnableReference());
        }

        public unsafe void PrioritizeTexturesx([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> priorities)
        {
            // ImplicitCountSpanOverloader
            PrioritizeTexturesx((uint) priorities.Length, textures, in priorities.GetPinnableReference());
        }

        public unsafe void PrioritizeTexturesx([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* priorities)
        {
            // ImplicitCountSpanOverloader
            PrioritizeTexturesx((uint) textures.Length, in textures.GetPinnableReference(), priorities);
        }

        public unsafe void PrioritizeTexturesx([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> priorities)
        {
            // ImplicitCountSpanOverloader
            PrioritizeTexturesx((uint) priorities.Length, in textures.GetPinnableReference(), in priorities.GetPinnableReference());
        }

        public unsafe int GetClipPlanex([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES plane)
        {
            // NonKhrReturnTypeOverloader
            GetClipPlanex(plane, out int silkRet);
            return silkRet;
        }

        public unsafe int GetClipPlanex([Flow(Silk.NET.Core.Native.FlowDirection.In)] ClipPlaneName plane)
        {
            // NonKhrReturnTypeOverloader
            GetClipPlanex(plane, out int silkRet);
            return silkRet;
        }

        public unsafe int GetConvolutionParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname)
        {
            // NonKhrReturnTypeOverloader
            GetConvolutionParameterx(target, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetHistogramParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname)
        {
            // NonKhrReturnTypeOverloader
            GetHistogramParameterx(target, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetHistogramParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetHistogramParameterPNameEXT pname)
        {
            // NonKhrReturnTypeOverloader
            GetHistogramParameterx(target, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetHistogramParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname)
        {
            // NonKhrReturnTypeOverloader
            GetHistogramParameterx(target, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetHistogramParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetHistogramParameterPNameEXT pname)
        {
            // NonKhrReturnTypeOverloader
            GetHistogramParameterx(target, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetLightx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname)
        {
            // NonKhrReturnTypeOverloader
            GetLightx(light, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetLightx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LightParameter pname)
        {
            // NonKhrReturnTypeOverloader
            GetLightx(light, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetLightx([Flow(Silk.NET.Core.Native.FlowDirection.In)] LightName light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname)
        {
            // NonKhrReturnTypeOverloader
            GetLightx(light, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetLightx([Flow(Silk.NET.Core.Native.FlowDirection.In)] LightName light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LightParameter pname)
        {
            // NonKhrReturnTypeOverloader
            GetLightx(light, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetMapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES query)
        {
            // NonKhrReturnTypeOverloader
            GetMapx(target, query, out int silkRet);
            return silkRet;
        }

        public unsafe int GetMapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMapQuery query)
        {
            // NonKhrReturnTypeOverloader
            GetMapx(target, query, out int silkRet);
            return silkRet;
        }

        public unsafe int GetMapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES query)
        {
            // NonKhrReturnTypeOverloader
            GetMapx(target, query, out int silkRet);
            return silkRet;
        }

        public unsafe int GetMapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMapQuery query)
        {
            // NonKhrReturnTypeOverloader
            GetMapx(target, query, out int silkRet);
            return silkRet;
        }

        public unsafe int GetPixelMapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size)
        {
            // NonKhrReturnTypeOverloader
            GetPixelMapx(map, size, out int silkRet);
            return silkRet;
        }

        public unsafe int GetPixelMapx([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelMap map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size)
        {
            // NonKhrReturnTypeOverloader
            GetPixelMapx(map, size, out int silkRet);
            return silkRet;
        }

        public unsafe int GetTexEnvx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname)
        {
            // NonKhrReturnTypeOverloader
            GetTexEnvx(target, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetTexEnvx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureEnvParameter pname)
        {
            // NonKhrReturnTypeOverloader
            GetTexEnvx(target, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetTexEnvx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureEnvTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname)
        {
            // NonKhrReturnTypeOverloader
            GetTexEnvx(target, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetTexEnvx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureEnvTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureEnvParameter pname)
        {
            // NonKhrReturnTypeOverloader
            GetTexEnvx(target, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetTexGenx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname)
        {
            // NonKhrReturnTypeOverloader
            GetTexGenx(coord, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetTexGenx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureGenParameter pname)
        {
            // NonKhrReturnTypeOverloader
            GetTexGenx(coord, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetTexGenx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureCoordName coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname)
        {
            // NonKhrReturnTypeOverloader
            GetTexGenx(coord, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetTexGenx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureCoordName coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureGenParameter pname)
        {
            // NonKhrReturnTypeOverloader
            GetTexGenx(coord, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetTexLevelParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname)
        {
            // NonKhrReturnTypeOverloader
            GetTexLevelParameterx(target, level, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetTexLevelParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname)
        {
            // NonKhrReturnTypeOverloader
            GetTexLevelParameterx(target, level, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetTexLevelParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname)
        {
            // NonKhrReturnTypeOverloader
            GetTexLevelParameterx(target, level, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetTexLevelParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname)
        {
            // NonKhrReturnTypeOverloader
            GetTexLevelParameterx(target, level, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetTexParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname)
        {
            // NonKhrReturnTypeOverloader
            GetTexParameterx(target, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetTexParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname)
        {
            // NonKhrReturnTypeOverloader
            GetTexParameterx(target, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetTexParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname)
        {
            // NonKhrReturnTypeOverloader
            GetTexParameterx(target, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetTexParameterx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname)
        {
            // NonKhrReturnTypeOverloader
            GetTexParameterx(target, pname, out int silkRet);
            return silkRet;
        }

        public OesFixedPoint(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

