// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.OES
{
    [Extension("OES_fixed_point")]
    public unsafe partial class OesFixedPoint : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_fixed_point";
        [NativeApi(EntryPoint = "glAccumxOES")]
        public partial void Accumx([Flow(FlowDirection.In)] OES op, [Flow(FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glAlphaFuncxOES")]
        public partial void AlphaFuncx([Flow(FlowDirection.In)] OES func, [Flow(FlowDirection.In)] int @ref);

        [NativeApi(EntryPoint = "glBitmapxOES")]
        public unsafe partial void Bitmapx([Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int xorig, [Flow(FlowDirection.In)] int yorig, [Flow(FlowDirection.In)] int xmove, [Flow(FlowDirection.In)] int ymove, [Count(Computed = "width, height"), Flow(FlowDirection.In)] byte* bitmap);

        [NativeApi(EntryPoint = "glBitmapxOES")]
        public partial void Bitmapx([Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int xorig, [Flow(FlowDirection.In)] int yorig, [Flow(FlowDirection.In)] int xmove, [Flow(FlowDirection.In)] int ymove, [Count(Computed = "width, height"), Flow(FlowDirection.In)] ref byte bitmap);

        [NativeApi(EntryPoint = "glBlendColorxOES")]
        public partial void BlendColorx([Flow(FlowDirection.In)] int red, [Flow(FlowDirection.In)] int green, [Flow(FlowDirection.In)] int blue, [Flow(FlowDirection.In)] int alpha);

        [NativeApi(EntryPoint = "glClearAccumxOES")]
        public partial void ClearAccumx([Flow(FlowDirection.In)] int red, [Flow(FlowDirection.In)] int green, [Flow(FlowDirection.In)] int blue, [Flow(FlowDirection.In)] int alpha);

        [NativeApi(EntryPoint = "glClearColorxOES")]
        public partial void ClearColorx([Flow(FlowDirection.In)] int red, [Flow(FlowDirection.In)] int green, [Flow(FlowDirection.In)] int blue, [Flow(FlowDirection.In)] int alpha);

        [NativeApi(EntryPoint = "glClearDepthxOES")]
        public partial void ClearDepthx([Flow(FlowDirection.In)] int depth);

        [NativeApi(EntryPoint = "glClipPlanexOES")]
        public unsafe partial void ClipPlanex([Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.In)] int* equation);

        [NativeApi(EntryPoint = "glClipPlanexOES")]
        public partial void ClipPlanex([Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> equation);

        [NativeApi(EntryPoint = "glColor3xOES")]
        public partial void Color3x([Flow(FlowDirection.In)] int red, [Flow(FlowDirection.In)] int green, [Flow(FlowDirection.In)] int blue);

        [NativeApi(EntryPoint = "glColor3xvOES")]
        public unsafe partial void Color3x([Count(Count = 3), Flow(FlowDirection.In)] int* components);

        [NativeApi(EntryPoint = "glColor3xvOES")]
        public partial void Color3x([Count(Count = 3), Flow(FlowDirection.In)] Span<int> components);

        [NativeApi(EntryPoint = "glColor4xOES")]
        public partial void Color4x([Flow(FlowDirection.In)] int red, [Flow(FlowDirection.In)] int green, [Flow(FlowDirection.In)] int blue, [Flow(FlowDirection.In)] int alpha);

        [NativeApi(EntryPoint = "glColor4xvOES")]
        public unsafe partial void Color4x([Count(Count = 4), Flow(FlowDirection.In)] int* components);

        [NativeApi(EntryPoint = "glColor4xvOES")]
        public partial void Color4x([Count(Count = 4), Flow(FlowDirection.In)] Span<int> components);

        [NativeApi(EntryPoint = "glConvolutionParameterxOES")]
        public partial void ConvolutionParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glConvolutionParameterxvOES")]
        public unsafe partial void ConvolutionParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterxvOES")]
        public partial void ConvolutionParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glDepthRangexOES")]
        public partial void DepthRangex([Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int f);

        [NativeApi(EntryPoint = "glEvalCoord1xOES")]
        public partial void EvalCoord1x([Flow(FlowDirection.In)] int u);

        [NativeApi(EntryPoint = "glEvalCoord1xvOES")]
        public unsafe partial void EvalCoord1x([Count(Count = 1), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glEvalCoord1xvOES")]
        public partial void EvalCoord1x([Count(Count = 1), Flow(FlowDirection.In)] ref int coords);

        [NativeApi(EntryPoint = "glEvalCoord2xOES")]
        public partial void EvalCoord2x([Flow(FlowDirection.In)] int u, [Flow(FlowDirection.In)] int v);

        [NativeApi(EntryPoint = "glEvalCoord2xvOES")]
        public unsafe partial void EvalCoord2x([Count(Count = 2), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glEvalCoord2xvOES")]
        public partial void EvalCoord2x([Count(Count = 2), Flow(FlowDirection.In)] Span<int> coords);

        [NativeApi(EntryPoint = "glFeedbackBufferxOES")]
        public unsafe partial void FeedbackBufferx([Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] OES type, [Count(Parameter = "n"), Flow(FlowDirection.In)] int* buffer);

        [NativeApi(EntryPoint = "glFeedbackBufferxOES")]
        public partial void FeedbackBufferx([Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] OES type, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<int> buffer);

        [NativeApi(EntryPoint = "glFogxOES")]
        public partial void Fogx([Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFogxvOES")]
        public unsafe partial void Fogx([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glFogxvOES")]
        public partial void Fogx([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

        [NativeApi(EntryPoint = "glFrustumxOES")]
        public partial void Frustumx([Flow(FlowDirection.In)] int l, [Flow(FlowDirection.In)] int r, [Flow(FlowDirection.In)] int b, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int f);

        [NativeApi(EntryPoint = "glGetClipPlanexOES")]
        public unsafe partial void GetClipPlanex([Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.Out)] int* equation);

        [NativeApi(EntryPoint = "glGetClipPlanexOES")]
        public partial void GetClipPlanex([Flow(FlowDirection.In)] OES plane, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> equation);

        [NativeApi(EntryPoint = "glGetConvolutionParameterxvOES")]
        public unsafe partial void GetConvolutionParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterxvOES")]
        public partial void GetConvolutionParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFixedvOES")]
        public unsafe partial void GetFixed([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFixedvOES")]
        public partial void GetFixed([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterxvOES")]
        public unsafe partial void GetHistogramParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterxvOES")]
        public partial void GetHistogramParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetLightxOES")]
        public unsafe partial void GetLightx([Flow(FlowDirection.In)] OES light, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetLightxOES")]
        public partial void GetLightx([Flow(FlowDirection.In)] OES light, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMapxvOES")]
        public unsafe partial void GetMapx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES query, [Count(Computed = "query"), Flow(FlowDirection.Out)] int* v);

        [NativeApi(EntryPoint = "glGetMapxvOES")]
        public partial void GetMapx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES query, [Count(Computed = "query"), Flow(FlowDirection.Out)] out int v);

        [NativeApi(EntryPoint = "glGetMaterialxOES")]
        public partial void GetMaterialx([Flow(FlowDirection.In)] OES face, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glGetPixelMapxv")]
        public unsafe partial void GetPixelMapx([Flow(FlowDirection.In)] OES map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetPixelMapxv")]
        public partial void GetPixelMapx([Flow(FlowDirection.In)] OES map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<int> values);

        [NativeApi(EntryPoint = "glGetTexEnvxvOES")]
        public unsafe partial void GetTexEnvx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexEnvxvOES")]
        public partial void GetTexEnvx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexGenxvOES")]
        public unsafe partial void GetTexGenx([Flow(FlowDirection.In)] OES coord, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexGenxvOES")]
        public partial void GetTexGenx([Flow(FlowDirection.In)] OES coord, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterxvOES")]
        public unsafe partial void GetTexLevelParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterxvOES")]
        public partial void GetTexLevelParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterxvOES")]
        public unsafe partial void GetTexParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameterxvOES")]
        public partial void GetTexParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glIndexxOES")]
        public partial void Indexx([Flow(FlowDirection.In)] int component);

        [NativeApi(EntryPoint = "glIndexxvOES")]
        public unsafe partial void Indexx([Count(Count = 1), Flow(FlowDirection.In)] int* component);

        [NativeApi(EntryPoint = "glIndexxvOES")]
        public partial void Indexx([Count(Count = 1), Flow(FlowDirection.In)] ref int component);

        [NativeApi(EntryPoint = "glLightModelxOES")]
        public partial void LightModelx([Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glLightModelxvOES")]
        public unsafe partial void LightModelx([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glLightModelxvOES")]
        public partial void LightModelx([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

        [NativeApi(EntryPoint = "glLightxOES")]
        public partial void Lightx([Flow(FlowDirection.In)] OES light, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glLightxvOES")]
        public unsafe partial void Lightx([Flow(FlowDirection.In)] OES light, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glLightxvOES")]
        public partial void Lightx([Flow(FlowDirection.In)] OES light, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glLineWidthxOES")]
        public partial void LineWidthx([Flow(FlowDirection.In)] int width);

        [NativeApi(EntryPoint = "glLoadMatrixxOES")]
        public unsafe partial void LoadMatrixx([Count(Count = 16), Flow(FlowDirection.In)] int* m);

        [NativeApi(EntryPoint = "glLoadMatrixxOES")]
        public partial void LoadMatrixx([Count(Count = 16), Flow(FlowDirection.In)] Span<int> m);

        [NativeApi(EntryPoint = "glLoadTransposeMatrixxOES")]
        public unsafe partial void LoadTransposeMatrixx([Count(Count = 16), Flow(FlowDirection.In)] int* m);

        [NativeApi(EntryPoint = "glLoadTransposeMatrixxOES")]
        public partial void LoadTransposeMatrixx([Count(Count = 16), Flow(FlowDirection.In)] Span<int> m);

        [NativeApi(EntryPoint = "glMap1xOES")]
        public partial void Map1x([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int u1, [Flow(FlowDirection.In)] int u2, [Flow(FlowDirection.In)] int stride, [Flow(FlowDirection.In)] int order, [Flow(FlowDirection.In)] int points);

        [NativeApi(EntryPoint = "glMap2xOES")]
        public partial void Map2x([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int u1, [Flow(FlowDirection.In)] int u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] int points);

        [NativeApi(EntryPoint = "glMapGrid1xOES")]
        public partial void MapGrid1x([Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int u1, [Flow(FlowDirection.In)] int u2);

        [NativeApi(EntryPoint = "glMapGrid2xOES")]
        public partial void MapGrid2x([Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int u1, [Flow(FlowDirection.In)] int u2, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2);

        [NativeApi(EntryPoint = "glMaterialxOES")]
        public partial void Materialx([Flow(FlowDirection.In)] OES face, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMaterialxvOES")]
        public unsafe partial void Materialx([Flow(FlowDirection.In)] OES face, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glMaterialxvOES")]
        public partial void Materialx([Flow(FlowDirection.In)] OES face, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

        [NativeApi(EntryPoint = "glMultiTexCoord1xOES")]
        public partial void MultiTexCoord1x([Flow(FlowDirection.In)] OES texture, [Flow(FlowDirection.In)] int s);

        [NativeApi(EntryPoint = "glMultiTexCoord1xvOES")]
        public unsafe partial void MultiTexCoord1x([Flow(FlowDirection.In)] OES texture, [Count(Count = 1), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord1xvOES")]
        public partial void MultiTexCoord1x([Flow(FlowDirection.In)] OES texture, [Count(Count = 1), Flow(FlowDirection.In)] ref int coords);

        [NativeApi(EntryPoint = "glMultiTexCoord2xOES")]
        public partial void MultiTexCoord2x([Flow(FlowDirection.In)] OES texture, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t);

        [NativeApi(EntryPoint = "glMultiTexCoord2xvOES")]
        public unsafe partial void MultiTexCoord2x([Flow(FlowDirection.In)] OES texture, [Count(Count = 2), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord2xvOES")]
        public partial void MultiTexCoord2x([Flow(FlowDirection.In)] OES texture, [Count(Count = 2), Flow(FlowDirection.In)] Span<int> coords);

        [NativeApi(EntryPoint = "glMultiTexCoord3xOES")]
        public partial void MultiTexCoord3x([Flow(FlowDirection.In)] OES texture, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r);

        [NativeApi(EntryPoint = "glMultiTexCoord3xvOES")]
        public unsafe partial void MultiTexCoord3x([Flow(FlowDirection.In)] OES texture, [Count(Count = 3), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord3xvOES")]
        public partial void MultiTexCoord3x([Flow(FlowDirection.In)] OES texture, [Count(Count = 3), Flow(FlowDirection.In)] Span<int> coords);

        [NativeApi(EntryPoint = "glMultiTexCoord4xOES")]
        public partial void MultiTexCoord4x([Flow(FlowDirection.In)] OES texture, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r, [Flow(FlowDirection.In)] int q);

        [NativeApi(EntryPoint = "glMultiTexCoord4xvOES")]
        public unsafe partial void MultiTexCoord4x([Flow(FlowDirection.In)] OES texture, [Count(Count = 4), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord4xvOES")]
        public partial void MultiTexCoord4x([Flow(FlowDirection.In)] OES texture, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> coords);

        [NativeApi(EntryPoint = "glMultMatrixxOES")]
        public unsafe partial void MultMatrixx([Count(Count = 16), Flow(FlowDirection.In)] int* m);

        [NativeApi(EntryPoint = "glMultMatrixxOES")]
        public partial void MultMatrixx([Count(Count = 16), Flow(FlowDirection.In)] Span<int> m);

        [NativeApi(EntryPoint = "glMultTransposeMatrixxOES")]
        public unsafe partial void MultTransposeMatrixx([Count(Count = 16), Flow(FlowDirection.In)] int* m);

        [NativeApi(EntryPoint = "glMultTransposeMatrixxOES")]
        public partial void MultTransposeMatrixx([Count(Count = 16), Flow(FlowDirection.In)] Span<int> m);

        [NativeApi(EntryPoint = "glNormal3xOES")]
        public partial void Normal3x([Flow(FlowDirection.In)] int nx, [Flow(FlowDirection.In)] int ny, [Flow(FlowDirection.In)] int nz);

        [NativeApi(EntryPoint = "glNormal3xvOES")]
        public unsafe partial void Normal3x([Count(Count = 3), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glNormal3xvOES")]
        public partial void Normal3x([Count(Count = 3), Flow(FlowDirection.In)] Span<int> coords);

        [NativeApi(EntryPoint = "glOrthoxOES")]
        public partial void Orthox([Flow(FlowDirection.In)] int l, [Flow(FlowDirection.In)] int r, [Flow(FlowDirection.In)] int b, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int f);

        [NativeApi(EntryPoint = "glPassThroughxOES")]
        public partial void PassThroughx([Flow(FlowDirection.In)] int token);

        [NativeApi(EntryPoint = "glPixelMapx")]
        public unsafe partial void PixelMapx([Flow(FlowDirection.In)] OES map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] int* values);

        [NativeApi(EntryPoint = "glPixelMapx")]
        public partial void PixelMapx([Flow(FlowDirection.In)] OES map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<int> values);

        [NativeApi(EntryPoint = "glPixelStorex")]
        public partial void PixelStorex([Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPixelTransferxOES")]
        public partial void PixelTransferx([Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPixelZoomxOES")]
        public partial void PixelZoomx([Flow(FlowDirection.In)] int xfactor, [Flow(FlowDirection.In)] int yfactor);

        [NativeApi(EntryPoint = "glPointParameterxvOES")]
        public unsafe partial void PointParameterx([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glPointParameterxvOES")]
        public partial void PointParameterx([Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glPointSizexOES")]
        public partial void PointSizex([Flow(FlowDirection.In)] int size);

        [NativeApi(EntryPoint = "glPolygonOffsetxOES")]
        public partial void PolygonOffsetx([Flow(FlowDirection.In)] int factor, [Flow(FlowDirection.In)] int units);

        [NativeApi(EntryPoint = "glPrioritizeTexturesxOES")]
        public unsafe partial void PrioritizeTexturesx([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] int* priorities);

        [NativeApi(EntryPoint = "glPrioritizeTexturesxOES")]
        public partial void PrioritizeTexturesx([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> textures, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<int> priorities);

        [NativeApi(EntryPoint = "glRasterPos2xOES")]
        public partial void RasterPos2x([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y);

        [NativeApi(EntryPoint = "glRasterPos2xvOES")]
        public unsafe partial void RasterPos2x([Count(Count = 2), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glRasterPos2xvOES")]
        public partial void RasterPos2x([Count(Count = 2), Flow(FlowDirection.In)] Span<int> coords);

        [NativeApi(EntryPoint = "glRasterPos3xOES")]
        public partial void RasterPos3x([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z);

        [NativeApi(EntryPoint = "glRasterPos3xvOES")]
        public unsafe partial void RasterPos3x([Count(Count = 3), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glRasterPos3xvOES")]
        public partial void RasterPos3x([Count(Count = 3), Flow(FlowDirection.In)] Span<int> coords);

        [NativeApi(EntryPoint = "glRasterPos4xOES")]
        public partial void RasterPos4x([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glRasterPos4xvOES")]
        public unsafe partial void RasterPos4x([Count(Count = 4), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glRasterPos4xvOES")]
        public partial void RasterPos4x([Count(Count = 4), Flow(FlowDirection.In)] Span<int> coords);

        [NativeApi(EntryPoint = "glRectxOES")]
        public partial void Rectx([Flow(FlowDirection.In)] int x1, [Flow(FlowDirection.In)] int y1, [Flow(FlowDirection.In)] int x2, [Flow(FlowDirection.In)] int y2);

        [NativeApi(EntryPoint = "glRectxvOES")]
        public unsafe partial void Rectx([Count(Count = 2), Flow(FlowDirection.In)] int* v1, [Count(Count = 2), Flow(FlowDirection.In)] int* v2);

        [NativeApi(EntryPoint = "glRectxvOES")]
        public partial void Rectx([Count(Count = 2), Flow(FlowDirection.In)] Span<int> v1, [Count(Count = 2), Flow(FlowDirection.In)] Span<int> v2);

        [NativeApi(EntryPoint = "glRotatexOES")]
        public partial void Rotatex([Flow(FlowDirection.In)] int angle, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z);

        [NativeApi(EntryPoint = "glScalexOES")]
        public partial void Scalex([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z);

        [NativeApi(EntryPoint = "glTexCoord1xOES")]
        public partial void TexCoord1x([Flow(FlowDirection.In)] int s);

        [NativeApi(EntryPoint = "glTexCoord1xvOES")]
        public unsafe partial void TexCoord1x([Count(Count = 1), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glTexCoord1xvOES")]
        public partial void TexCoord1x([Count(Count = 1), Flow(FlowDirection.In)] ref int coords);

        [NativeApi(EntryPoint = "glTexCoord2xOES")]
        public partial void TexCoord2x([Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t);

        [NativeApi(EntryPoint = "glTexCoord2xvOES")]
        public unsafe partial void TexCoord2x([Count(Count = 2), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glTexCoord2xvOES")]
        public partial void TexCoord2x([Count(Count = 2), Flow(FlowDirection.In)] Span<int> coords);

        [NativeApi(EntryPoint = "glTexCoord3xOES")]
        public partial void TexCoord3x([Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r);

        [NativeApi(EntryPoint = "glTexCoord3xvOES")]
        public unsafe partial void TexCoord3x([Count(Count = 3), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glTexCoord3xvOES")]
        public partial void TexCoord3x([Count(Count = 3), Flow(FlowDirection.In)] Span<int> coords);

        [NativeApi(EntryPoint = "glTexCoord4xOES")]
        public partial void TexCoord4x([Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r, [Flow(FlowDirection.In)] int q);

        [NativeApi(EntryPoint = "glTexCoord4xvOES")]
        public unsafe partial void TexCoord4x([Count(Count = 4), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glTexCoord4xvOES")]
        public partial void TexCoord4x([Count(Count = 4), Flow(FlowDirection.In)] Span<int> coords);

        [NativeApi(EntryPoint = "glTexEnvxOES")]
        public partial void TexEnvx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexEnvxvOES")]
        public unsafe partial void TexEnvx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexEnvxvOES")]
        public partial void TexEnvx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glTexGenxOES")]
        public partial void TexGenx([Flow(FlowDirection.In)] OES coord, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexGenxvOES")]
        public unsafe partial void TexGenx([Flow(FlowDirection.In)] OES coord, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexGenxvOES")]
        public partial void TexGenx([Flow(FlowDirection.In)] OES coord, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glTexParameterxOES")]
        public partial void TexParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexParameterxvOES")]
        public unsafe partial void TexParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameterxvOES")]
        public partial void TexParameterx([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glTranslatexOES")]
        public partial void Translatex([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z);

        [NativeApi(EntryPoint = "glVertex2xOES")]
        public partial void Vertex2x([Flow(FlowDirection.In)] int x);

        [NativeApi(EntryPoint = "glVertex2xvOES")]
        public unsafe partial void Vertex2x([Count(Count = 2), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glVertex2xvOES")]
        public partial void Vertex2x([Count(Count = 2), Flow(FlowDirection.In)] Span<int> coords);

        [NativeApi(EntryPoint = "glVertex3xOES")]
        public partial void Vertex3x([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y);

        [NativeApi(EntryPoint = "glVertex3xvOES")]
        public unsafe partial void Vertex3x([Count(Count = 3), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glVertex3xvOES")]
        public partial void Vertex3x([Count(Count = 3), Flow(FlowDirection.In)] Span<int> coords);

        [NativeApi(EntryPoint = "glVertex4xOES")]
        public partial void Vertex4x([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z);

        [NativeApi(EntryPoint = "glVertex4xvOES")]
        public unsafe partial void Vertex4x([Count(Count = 4), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glVertex4xvOES")]
        public partial void Vertex4x([Count(Count = 4), Flow(FlowDirection.In)] Span<int> coords);

        [NativeApi(EntryPoint = "glAlphaFuncxOES")]
        public partial void AlphaFuncx([Flow(FlowDirection.In)] AlphaFunction func, [Flow(FlowDirection.In)] int @ref);

        [NativeApi(EntryPoint = "glBitmapxOES")]
        public partial void Bitmapx([Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int xorig, [Flow(FlowDirection.In)] int yorig, [Flow(FlowDirection.In)] int xmove, [Flow(FlowDirection.In)] int ymove, [Flow(FlowDirection.In)] string bitmap);

        [NativeApi(EntryPoint = "glClipPlanexOES")]
        public unsafe partial void ClipPlanex([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.In)] int* equation);

        [NativeApi(EntryPoint = "glClipPlanexOES")]
        public partial void ClipPlanex([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> equation);

        [NativeApi(EntryPoint = "glConvolutionParameterxOES")]
        public partial void ConvolutionParameterx([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glConvolutionParameterxvOES")]
        public unsafe partial void ConvolutionParameterx([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterxvOES")]
        public partial void ConvolutionParameterx([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glFogxOES")]
        public partial void Fogx([Flow(FlowDirection.In)] FogPName pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFogxvOES")]
        public unsafe partial void Fogx([Flow(FlowDirection.In)] FogPName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glFogxvOES")]
        public partial void Fogx([Flow(FlowDirection.In)] FogPName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

        [NativeApi(EntryPoint = "glGetClipPlanexOES")]
        public unsafe partial void GetClipPlanex([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.Out)] int* equation);

        [NativeApi(EntryPoint = "glGetClipPlanexOES")]
        public partial void GetClipPlanex([Flow(FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> equation);

        [NativeApi(EntryPoint = "glGetFixedvOES")]
        public unsafe partial void GetFixed([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFixedvOES")]
        public partial void GetFixed([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterxvOES")]
        public unsafe partial void GetHistogramParameterx([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterxvOES")]
        public partial void GetHistogramParameterx([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetLightxOES")]
        public unsafe partial void GetLightx([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetLightxOES")]
        public partial void GetLightx([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMapxvOES")]
        public unsafe partial void GetMapx([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] GetMapQuery query, [Count(Computed = "query"), Flow(FlowDirection.Out)] int* v);

        [NativeApi(EntryPoint = "glGetMapxvOES")]
        public partial void GetMapx([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] GetMapQuery query, [Count(Computed = "query"), Flow(FlowDirection.Out)] out int v);

        [NativeApi(EntryPoint = "glGetMaterialxOES")]
        public partial void GetMaterialx([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glGetPixelMapxv")]
        public unsafe partial void GetPixelMapx([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetPixelMapxv")]
        public partial void GetPixelMapx([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<int> values);

        [NativeApi(EntryPoint = "glGetTexEnvxvOES")]
        public unsafe partial void GetTexEnvx([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexEnvxvOES")]
        public partial void GetTexEnvx([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexGenxvOES")]
        public unsafe partial void GetTexGenx([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexGenxvOES")]
        public partial void GetTexGenx([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterxvOES")]
        public unsafe partial void GetTexLevelParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterxvOES")]
        public partial void GetTexLevelParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterxvOES")]
        public unsafe partial void GetTexParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameterxvOES")]
        public partial void GetTexParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glLightModelxOES")]
        public partial void LightModelx([Flow(FlowDirection.In)] LightModelParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glLightModelxvOES")]
        public unsafe partial void LightModelx([Flow(FlowDirection.In)] LightModelParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glLightModelxvOES")]
        public partial void LightModelx([Flow(FlowDirection.In)] LightModelParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

        [NativeApi(EntryPoint = "glLightxOES")]
        public partial void Lightx([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glLightxvOES")]
        public unsafe partial void Lightx([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glLightxvOES")]
        public partial void Lightx([Flow(FlowDirection.In)] LightName light, [Flow(FlowDirection.In)] LightParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glMap1xOES")]
        public partial void Map1x([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] int u1, [Flow(FlowDirection.In)] int u2, [Flow(FlowDirection.In)] int stride, [Flow(FlowDirection.In)] int order, [Flow(FlowDirection.In)] int points);

        [NativeApi(EntryPoint = "glMap2xOES")]
        public partial void Map2x([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] int u1, [Flow(FlowDirection.In)] int u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] int points);

        [NativeApi(EntryPoint = "glMaterialxOES")]
        public partial void Materialx([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMaterialxvOES")]
        public unsafe partial void Materialx([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glMaterialxvOES")]
        public partial void Materialx([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

        [NativeApi(EntryPoint = "glMultiTexCoord1xOES")]
        public partial void MultiTexCoord1x([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] int s);

        [NativeApi(EntryPoint = "glMultiTexCoord1xvOES")]
        public unsafe partial void MultiTexCoord1x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 1), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord1xvOES")]
        public partial void MultiTexCoord1x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 1), Flow(FlowDirection.In)] ref int coords);

        [NativeApi(EntryPoint = "glMultiTexCoord2xOES")]
        public partial void MultiTexCoord2x([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t);

        [NativeApi(EntryPoint = "glMultiTexCoord2xvOES")]
        public unsafe partial void MultiTexCoord2x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 2), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord2xvOES")]
        public partial void MultiTexCoord2x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 2), Flow(FlowDirection.In)] Span<int> coords);

        [NativeApi(EntryPoint = "glMultiTexCoord3xOES")]
        public partial void MultiTexCoord3x([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r);

        [NativeApi(EntryPoint = "glMultiTexCoord3xvOES")]
        public unsafe partial void MultiTexCoord3x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 3), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord3xvOES")]
        public partial void MultiTexCoord3x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 3), Flow(FlowDirection.In)] Span<int> coords);

        [NativeApi(EntryPoint = "glMultiTexCoord4xOES")]
        public partial void MultiTexCoord4x([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] int s, [Flow(FlowDirection.In)] int t, [Flow(FlowDirection.In)] int r, [Flow(FlowDirection.In)] int q);

        [NativeApi(EntryPoint = "glMultiTexCoord4xvOES")]
        public unsafe partial void MultiTexCoord4x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 4), Flow(FlowDirection.In)] int* coords);

        [NativeApi(EntryPoint = "glMultiTexCoord4xvOES")]
        public partial void MultiTexCoord4x([Flow(FlowDirection.In)] TextureUnit texture, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> coords);

        [NativeApi(EntryPoint = "glPixelMapx")]
        public unsafe partial void PixelMapx([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] int* values);

        [NativeApi(EntryPoint = "glPixelMapx")]
        public partial void PixelMapx([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<int> values);

        [NativeApi(EntryPoint = "glPixelStorex")]
        public partial void PixelStorex([Flow(FlowDirection.In)] PixelStoreParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPixelTransferxOES")]
        public partial void PixelTransferx([Flow(FlowDirection.In)] PixelTransferParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPointParameterxvOES")]
        public unsafe partial void PointParameterx([Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glPointParameterxvOES")]
        public partial void PointParameterx([Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glTexEnvxOES")]
        public partial void TexEnvx([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexEnvxvOES")]
        public unsafe partial void TexEnvx([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexEnvxvOES")]
        public partial void TexEnvx([Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glTexGenxOES")]
        public partial void TexGenx([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexGenxvOES")]
        public unsafe partial void TexGenx([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexGenxvOES")]
        public partial void TexGenx([Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glTexParameterxOES")]
        public partial void TexParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexParameterxvOES")]
        public unsafe partial void TexParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameterxvOES")]
        public partial void TexParameterx([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        public unsafe int GetFixed([Flow(FlowDirection.In)] OES pname)
        {
            // ReturnTypeOverloader
            int ret = default;
            GetFixed(pname, &ret);
            return ret;
        }

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
        }
    }
}

