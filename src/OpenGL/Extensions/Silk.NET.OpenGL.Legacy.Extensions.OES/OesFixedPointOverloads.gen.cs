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

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.OES
{
    public static class OesFixedPointOverloads
    {
        public static unsafe void Bitmapx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int xorig, [Flow(FlowDirection.In)] int yorig, [Flow(FlowDirection.In)] int xmove, [Flow(FlowDirection.In)] int ymove, [Count(Computed = "width, height"), Flow(FlowDirection.In)] ReadOnlySpan<byte> bitmap)
        {
            // SpanOverloader
            thisApi.Bitmapx(width, height, xorig, yorig, xmove, ymove, in bitmap.GetPinnableReference());
        }

        public static unsafe void ClipPlanex(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<int> equation)
        {
            // SpanOverloader
            thisApi.ClipPlanex(plane, in equation.GetPinnableReference());
        }

        public static unsafe void ClipPlanex(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<int> equation)
        {
            // SpanOverloader
            thisApi.ClipPlanex(plane, in equation.GetPinnableReference());
        }

        public static unsafe void Color3x(this OesFixedPoint thisApi, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<int> components)
        {
            // SpanOverloader
            thisApi.Color3x(in components.GetPinnableReference());
        }

        public static unsafe void Color4x(this OesFixedPoint thisApi, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<int> components)
        {
            // SpanOverloader
            thisApi.Color4x(in components.GetPinnableReference());
        }

        public static unsafe void ConvolutionParameterx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ConvolutionParameterx(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ConvolutionParameterx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ConvolutionParameterx(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ConvolutionParameterx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ConvolutionParameterx(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ConvolutionParameterx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ConvolutionParameterx(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void EvalCoord1x(this OesFixedPoint thisApi, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.EvalCoord1x(in coords.GetPinnableReference());
        }

        public static unsafe void EvalCoord2x(this OesFixedPoint thisApi, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.EvalCoord2x(in coords.GetPinnableReference());
        }

        public static unsafe void FeedbackBufferx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] OES type, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<int> buffer)
        {
            // SpanOverloader
            thisApi.FeedbackBufferx(n, type, in buffer.GetPinnableReference());
        }

        public static unsafe void Fogx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> param)
        {
            // SpanOverloader
            thisApi.Fogx(pname, in param.GetPinnableReference());
        }

        public static unsafe void Fogx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] FogPName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> param)
        {
            // SpanOverloader
            thisApi.Fogx(pname, in param.GetPinnableReference());
        }

        public static unsafe void GetClipPlanex(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> equation)
        {
            // SpanOverloader
            thisApi.GetClipPlanex(plane, out equation.GetPinnableReference());
        }

        public static unsafe void GetClipPlanex(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> equation)
        {
            // SpanOverloader
            thisApi.GetClipPlanex(plane, out equation.GetPinnableReference());
        }

        public static unsafe void GetConvolutionParameterx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetConvolutionParameterx(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFixed(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFixed(pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFixed(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFixed(pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetHistogramParameterx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetHistogramParameterx(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetHistogramParameterx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetHistogramParameterx(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetHistogramParameterx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetHistogramParameterx(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetHistogramParameterx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetHistogramParameterx(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetLightx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES light, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetLightx(light, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetLightx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetLightx(light, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetLightx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetLightx(light, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetLightx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetLightx(light, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetMapx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES query, [Count(Computed = "query"), Flow(FlowDirection.Out)] Span<int> v)
        {
            // SpanOverloader
            thisApi.GetMapx(target, query, out v.GetPinnableReference());
        }

        public static unsafe void GetMapx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] GetMapQuery query, [Count(Computed = "query"), Flow(FlowDirection.Out)] Span<int> v)
        {
            // SpanOverloader
            thisApi.GetMapx(target, query, out v.GetPinnableReference());
        }

        public static unsafe void GetMapx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] OES query, [Count(Computed = "query"), Flow(FlowDirection.Out)] Span<int> v)
        {
            // SpanOverloader
            thisApi.GetMapx(target, query, out v.GetPinnableReference());
        }

        public static unsafe void GetMapx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] GetMapQuery query, [Count(Computed = "query"), Flow(FlowDirection.Out)] Span<int> v)
        {
            // SpanOverloader
            thisApi.GetMapx(target, query, out v.GetPinnableReference());
        }

        public static unsafe void GetPixelMapx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.GetPixelMapx(map, size, out values.GetPinnableReference());
        }

        public static unsafe void GetPixelMapx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.GetPixelMapx(map, size, out values.GetPinnableReference());
        }

        public static unsafe void GetTexEnvx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexEnvx(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexEnvx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexEnvx(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexEnvx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexEnvx(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexEnvx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexEnvx(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexGenx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES coord, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexGenx(coord, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexGenx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexGenx(coord, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexGenx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexGenx(coord, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexGenx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexGenx(coord, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexLevelParameterx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexLevelParameterx(target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexLevelParameterx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexLevelParameterx(target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexLevelParameterx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexLevelParameterx(target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexLevelParameterx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexLevelParameterx(target, level, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexParameterx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexParameterx(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexParameterx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexParameterx(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexParameterx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexParameterx(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetTexParameterx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetTexParameterx(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void Indexx(this OesFixedPoint thisApi, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<int> component)
        {
            // SpanOverloader
            thisApi.Indexx(in component.GetPinnableReference());
        }

        public static unsafe void LightModelx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> param)
        {
            // SpanOverloader
            thisApi.LightModelx(pname, in param.GetPinnableReference());
        }

        public static unsafe void LightModelx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] LightModelParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> param)
        {
            // SpanOverloader
            thisApi.LightModelx(pname, in param.GetPinnableReference());
        }

        public static unsafe void Lightx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES light, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.Lightx(light, pname, in @params.GetPinnableReference());
        }

        public static unsafe void Lightx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.Lightx(light, pname, in @params.GetPinnableReference());
        }

        public static unsafe void Lightx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.Lightx(light, pname, in @params.GetPinnableReference());
        }

        public static unsafe void Lightx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.Lightx(light, pname, in @params.GetPinnableReference());
        }

        public static unsafe void LoadMatrixx(this OesFixedPoint thisApi, [Count(Count = 16), Flow(FlowDirection.In)] ReadOnlySpan<int> m)
        {
            // SpanOverloader
            thisApi.LoadMatrixx(in m.GetPinnableReference());
        }

        public static unsafe void LoadTransposeMatrixx(this OesFixedPoint thisApi, [Count(Count = 16), Flow(FlowDirection.In)] ReadOnlySpan<int> m)
        {
            // SpanOverloader
            thisApi.LoadTransposeMatrixx(in m.GetPinnableReference());
        }

        public static unsafe void Materialx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES face, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> param)
        {
            // SpanOverloader
            thisApi.Materialx(face, pname, in param.GetPinnableReference());
        }

        public static unsafe void Materialx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> param)
        {
            // SpanOverloader
            thisApi.Materialx(face, pname, in param.GetPinnableReference());
        }

        public static unsafe void Materialx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] TriangleFace face, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> param)
        {
            // SpanOverloader
            thisApi.Materialx(face, pname, in param.GetPinnableReference());
        }

        public static unsafe void Materialx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] TriangleFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> param)
        {
            // SpanOverloader
            thisApi.Materialx(face, pname, in param.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord1x(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES texture, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoord1x(texture, in coords.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord1x(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoord1x(texture, in coords.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord2x(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES texture, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoord2x(texture, in coords.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord2x(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoord2x(texture, in coords.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord3x(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES texture, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoord3x(texture, in coords.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord3x(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoord3x(texture, in coords.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord4x(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES texture, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoord4x(texture, in coords.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord4x(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoord4x(texture, in coords.GetPinnableReference());
        }

        public static unsafe void MultMatrixx(this OesFixedPoint thisApi, [Count(Count = 16), Flow(FlowDirection.In)] ReadOnlySpan<int> m)
        {
            // SpanOverloader
            thisApi.MultMatrixx(in m.GetPinnableReference());
        }

        public static unsafe void MultTransposeMatrixx(this OesFixedPoint thisApi, [Count(Count = 16), Flow(FlowDirection.In)] ReadOnlySpan<int> m)
        {
            // SpanOverloader
            thisApi.MultTransposeMatrixx(in m.GetPinnableReference());
        }

        public static unsafe void Normal3x(this OesFixedPoint thisApi, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.Normal3x(in coords.GetPinnableReference());
        }

        public static unsafe void PixelMapx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<int> values)
        {
            // SpanOverloader
            thisApi.PixelMapx(map, size, in values.GetPinnableReference());
        }

        public static unsafe void PixelMapx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<int> values)
        {
            // SpanOverloader
            thisApi.PixelMapx(map, size, in values.GetPinnableReference());
        }

        public static unsafe void PointParameterx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.PointParameterx(pname, in @params.GetPinnableReference());
        }

        public static unsafe void PointParameterx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.PointParameterx(pname, in @params.GetPinnableReference());
        }

        public static unsafe void PrioritizeTexturesx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<int> priorities)
        {
            // SpanOverloader
            thisApi.PrioritizeTexturesx(n, textures, in priorities.GetPinnableReference());
        }

        public static unsafe void PrioritizeTexturesx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] int* priorities)
        {
            // SpanOverloader
            thisApi.PrioritizeTexturesx(n, in textures.GetPinnableReference(), priorities);
        }

        public static unsafe void PrioritizeTexturesx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<int> priorities)
        {
            // SpanOverloader
            thisApi.PrioritizeTexturesx(n, in textures.GetPinnableReference(), in priorities.GetPinnableReference());
        }

        public static unsafe void PrioritizeTexturesx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Texture* textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<int> priorities)
        {
            // SpanOverloader
            thisApi.PrioritizeTexturesx(n, textures, in priorities.GetPinnableReference());
        }

        public static unsafe void PrioritizeTexturesx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] int* priorities)
        {
            // SpanOverloader
            thisApi.PrioritizeTexturesx(n, in textures.GetPinnableReference(), priorities);
        }

        public static unsafe void PrioritizeTexturesx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Texture> textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<int> priorities)
        {
            // SpanOverloader
            thisApi.PrioritizeTexturesx(n, in textures.GetPinnableReference(), in priorities.GetPinnableReference());
        }

        public static unsafe void RasterPos2x(this OesFixedPoint thisApi, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.RasterPos2x(in coords.GetPinnableReference());
        }

        public static unsafe void RasterPos3x(this OesFixedPoint thisApi, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.RasterPos3x(in coords.GetPinnableReference());
        }

        public static unsafe void RasterPos4x(this OesFixedPoint thisApi, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.RasterPos4x(in coords.GetPinnableReference());
        }

        public static unsafe void Rectx(this OesFixedPoint thisApi, [Count(Count = 2), Flow(FlowDirection.In)] int* v1, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<int> v2)
        {
            // SpanOverloader
            thisApi.Rectx(v1, in v2.GetPinnableReference());
        }

        public static unsafe void Rectx(this OesFixedPoint thisApi, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<int> v1, [Count(Count = 2), Flow(FlowDirection.In)] int* v2)
        {
            // SpanOverloader
            thisApi.Rectx(in v1.GetPinnableReference(), v2);
        }

        public static unsafe void Rectx(this OesFixedPoint thisApi, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<int> v1, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<int> v2)
        {
            // SpanOverloader
            thisApi.Rectx(in v1.GetPinnableReference(), in v2.GetPinnableReference());
        }

        public static unsafe void TexCoord1x(this OesFixedPoint thisApi, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.TexCoord1x(in coords.GetPinnableReference());
        }

        public static unsafe void TexCoord2x(this OesFixedPoint thisApi, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.TexCoord2x(in coords.GetPinnableReference());
        }

        public static unsafe void TexCoord3x(this OesFixedPoint thisApi, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.TexCoord3x(in coords.GetPinnableReference());
        }

        public static unsafe void TexCoord4x(this OesFixedPoint thisApi, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.TexCoord4x(in coords.GetPinnableReference());
        }

        public static unsafe void TexEnvx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TexEnvx(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexEnvx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TexEnvx(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexEnvx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TexEnvx(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexEnvx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TexEnvx(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexGenx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES coord, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TexGenx(coord, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexGenx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TexGenx(coord, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexGenx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TexGenx(coord, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexGenx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TexGenx(coord, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexParameterx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TexParameterx(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexParameterx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TexParameterx(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexParameterx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TexParameterx(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void TexParameterx(this OesFixedPoint thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.TexParameterx(target, pname, in @params.GetPinnableReference());
        }

        public static unsafe void Vertex2x(this OesFixedPoint thisApi, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.Vertex2x(in coords.GetPinnableReference());
        }

        public static unsafe void Vertex3x(this OesFixedPoint thisApi, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.Vertex3x(in coords.GetPinnableReference());
        }

        public static unsafe void Vertex4x(this OesFixedPoint thisApi, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.Vertex4x(in coords.GetPinnableReference());
        }

    }
}

