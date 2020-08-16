// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_path_rendering")]
    public unsafe partial class NVPathRendering : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_path_rendering";
        [NativeApi(EntryPoint = "glCopyPathNV")]
        public partial void CopyPath([Flow(FlowDirection.In)] uint resultPath, [Flow(FlowDirection.In)] uint srcPath);

        [NativeApi(EntryPoint = "glCoverFillPathNV")]
        public partial void CoverFillPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV coverMode);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV")]
        public unsafe partial void CoverFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV")]
        public partial void CoverFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] ref T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] ref float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathNV")]
        public partial void CoverStrokePath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV coverMode);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV")]
        public unsafe partial void CoverStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV")]
        public partial void CoverStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] ref T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] ref float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDeletePathsNV")]
        public partial void DeletePath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint range);

        [NativeApi(EntryPoint = "glGenPathsNV")]
        public partial uint GenPath([Flow(FlowDirection.In)] uint range);

        [NativeApi(EntryPoint = "glGetPathCommandsNV")]
        public unsafe partial void GetPathCommands([Flow(FlowDirection.In)] uint path, [Count(Computed = "path"), Flow(FlowDirection.Out)] byte* commands);

        [NativeApi(EntryPoint = "glGetPathCommandsNV")]
        public partial void GetPathCommands([Flow(FlowDirection.In)] uint path, [Count(Computed = "path"), Flow(FlowDirection.Out)] out byte commands);

        [NativeApi(EntryPoint = "glGetPathCoordsNV")]
        public unsafe partial void GetPathCoords([Flow(FlowDirection.In)] uint path, [Count(Computed = "path"), Flow(FlowDirection.Out)] float* coords);

        [NativeApi(EntryPoint = "glGetPathCoordsNV")]
        public partial void GetPathCoords([Flow(FlowDirection.In)] uint path, [Count(Computed = "path"), Flow(FlowDirection.Out)] out float coords);

        [NativeApi(EntryPoint = "glGetPathDashArrayNV")]
        public unsafe partial void GetPathDashArray([Flow(FlowDirection.In)] uint path, [Count(Computed = "path"), Flow(FlowDirection.Out)] float* dashArray);

        [NativeApi(EntryPoint = "glGetPathDashArrayNV")]
        public partial void GetPathDashArray([Flow(FlowDirection.In)] uint path, [Count(Computed = "path"), Flow(FlowDirection.Out)] out float dashArray);

        [NativeApi(EntryPoint = "glGetPathLengthNV")]
        public partial float GetPathLength([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint startSegment, [Flow(FlowDirection.In)] uint numSegments);

        [NativeApi(EntryPoint = "glGetPathMetricsNV")]
        public unsafe partial void GetPathMetric([Flow(FlowDirection.In)] uint metricQueryMask, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] float* metrics);

        [NativeApi(EntryPoint = "glGetPathMetricsNV")]
        public partial void GetPathMetric<T0>([Flow(FlowDirection.In)] uint metricQueryMask, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] ref T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] out float metrics) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathMetricRangeNV")]
        public unsafe partial void GetPathMetricRange([Flow(FlowDirection.In)] uint metricQueryMask, [Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] float* metrics);

        [NativeApi(EntryPoint = "glGetPathMetricRangeNV")]
        public partial void GetPathMetricRange([Flow(FlowDirection.In)] uint metricQueryMask, [Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] out float metrics);

        [NativeApi(EntryPoint = "glGetPathParameterivNV")]
        public unsafe partial void GetPathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "glGetPathParameterivNV")]
        public partial void GetPathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> value);

        [NativeApi(EntryPoint = "glGetPathParameterfvNV")]
        public unsafe partial void GetPathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* value);

        [NativeApi(EntryPoint = "glGetPathParameterfvNV")]
        public partial void GetPathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> value);

        [NativeApi(EntryPoint = "glGetPathSpacingNV")]
        public unsafe partial void GetPathSpacing([Flow(FlowDirection.In)] NV pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] float* returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV")]
        public partial void GetPathSpacing<T0>([Flow(FlowDirection.In)] NV pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] ref T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] out float returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] NV programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] NV* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV")]
        public partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] NV programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] Span<NV> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<float> @params);

        [NativeApi(EntryPoint = "glInterpolatePathsNV")]
        public partial void InterpolatePath([Flow(FlowDirection.In)] uint resultPath, [Flow(FlowDirection.In)] uint pathA, [Flow(FlowDirection.In)] uint pathB, [Flow(FlowDirection.In)] float weight);

        [NativeApi(EntryPoint = "glIsPathNV")]
        public partial bool IsPath([Flow(FlowDirection.In)] uint path);

        [NativeApi(EntryPoint = "glIsPointInFillPathNV")]
        public partial bool IsPointInFillPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y);

        [NativeApi(EntryPoint = "glIsPointInStrokePathNV")]
        public partial bool IsPointInStrokePath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y);

        [NativeApi(EntryPoint = "glMatrixFrustumEXT")]
        public partial void MatrixFrustum([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] double left, [Flow(FlowDirection.In)] double right, [Flow(FlowDirection.In)] double bottom, [Flow(FlowDirection.In)] double top, [Flow(FlowDirection.In)] double zNear, [Flow(FlowDirection.In)] double zFar);

        [NativeApi(EntryPoint = "glMatrixLoadfEXT")]
        public unsafe partial void MatrixLoad([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixLoadfEXT")]
        public partial void MatrixLoad([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m);

        [NativeApi(EntryPoint = "glMatrixLoaddEXT")]
        public unsafe partial void MatrixLoad([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixLoaddEXT")]
        public partial void MatrixLoad([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m);

        [NativeApi(EntryPoint = "glMatrixLoad3x2fNV")]
        public unsafe partial void MatrixLoad3x2([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixLoad3x2fNV")]
        public partial void MatrixLoad3x2([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] Span<float> m);

        [NativeApi(EntryPoint = "glMatrixLoad3x3fNV")]
        public unsafe partial void MatrixLoad3x3([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixLoad3x3fNV")]
        public partial void MatrixLoad3x3([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] Span<float> m);

        [NativeApi(EntryPoint = "glMatrixLoadIdentityEXT")]
        public partial void MatrixLoadIdentity([Flow(FlowDirection.In)] NV mode);

        [NativeApi(EntryPoint = "glMatrixLoadTransposefEXT")]
        public unsafe partial void MatrixLoadTranspose([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixLoadTransposefEXT")]
        public partial void MatrixLoadTranspose([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m);

        [NativeApi(EntryPoint = "glMatrixLoadTransposedEXT")]
        public unsafe partial void MatrixLoadTranspose([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixLoadTransposedEXT")]
        public partial void MatrixLoadTranspose([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m);

        [NativeApi(EntryPoint = "glMatrixLoadTranspose3x3fNV")]
        public unsafe partial void MatrixLoadTranspose3x3([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixLoadTranspose3x3fNV")]
        public partial void MatrixLoadTranspose3x3([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] Span<float> m);

        [NativeApi(EntryPoint = "glMatrixMultfEXT")]
        public unsafe partial void MatrixMult([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixMultfEXT")]
        public partial void MatrixMult([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m);

        [NativeApi(EntryPoint = "glMatrixMultdEXT")]
        public unsafe partial void MatrixMult([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixMultdEXT")]
        public partial void MatrixMult([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m);

        [NativeApi(EntryPoint = "glMatrixMult3x2fNV")]
        public unsafe partial void MatrixMult3x2([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixMult3x2fNV")]
        public partial void MatrixMult3x2([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] Span<float> m);

        [NativeApi(EntryPoint = "glMatrixMult3x3fNV")]
        public unsafe partial void MatrixMult3x3([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixMult3x3fNV")]
        public partial void MatrixMult3x3([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] Span<float> m);

        [NativeApi(EntryPoint = "glMatrixMultTransposefEXT")]
        public unsafe partial void MatrixMultTranspose([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixMultTransposefEXT")]
        public partial void MatrixMultTranspose([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m);

        [NativeApi(EntryPoint = "glMatrixMultTransposedEXT")]
        public unsafe partial void MatrixMultTranspose([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixMultTransposedEXT")]
        public partial void MatrixMultTranspose([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m);

        [NativeApi(EntryPoint = "glMatrixMultTranspose3x3fNV")]
        public unsafe partial void MatrixMultTranspose3x3([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixMultTranspose3x3fNV")]
        public partial void MatrixMultTranspose3x3([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] Span<float> m);

        [NativeApi(EntryPoint = "glMatrixOrthoEXT")]
        public partial void MatrixOrtho([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] double left, [Flow(FlowDirection.In)] double right, [Flow(FlowDirection.In)] double bottom, [Flow(FlowDirection.In)] double top, [Flow(FlowDirection.In)] double zNear, [Flow(FlowDirection.In)] double zFar);

        [NativeApi(EntryPoint = "glMatrixPopEXT")]
        public partial void MatrixPop([Flow(FlowDirection.In)] NV mode);

        [NativeApi(EntryPoint = "glMatrixPushEXT")]
        public partial void MatrixPush([Flow(FlowDirection.In)] NV mode);

        [NativeApi(EntryPoint = "glMatrixRotatefEXT")]
        public partial void MatrixRotate([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] float angle, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glMatrixRotatedEXT")]
        public partial void MatrixRotate([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] double angle, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glMatrixScalefEXT")]
        public partial void MatrixScale([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glMatrixScaledEXT")]
        public partial void MatrixScale([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glMatrixTranslatefEXT")]
        public partial void MatrixTranslate([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glMatrixTranslatedEXT")]
        public partial void MatrixTranslate([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glPathCommandsNV")]
        public unsafe partial void PathCommands([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] byte* commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathCommandsNV")]
        public partial void PathCommands<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] Span<byte> commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] ref T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathCoordsNV")]
        public unsafe partial void PathCoords([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathCoordsNV")]
        public partial void PathCoords<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] ref T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathCoverDepthFuncNV")]
        public partial void PathCoverDepthFunc([Flow(FlowDirection.In)] NV func);

        [NativeApi(EntryPoint = "glPathDashArrayNV")]
        public unsafe partial void PathDashArray([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint dashCount, [Count(Parameter = "dashCount"), Flow(FlowDirection.In)] float* dashArray);

        [NativeApi(EntryPoint = "glPathDashArrayNV")]
        public partial void PathDashArray([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint dashCount, [Count(Parameter = "dashCount"), Flow(FlowDirection.In)] Span<float> dashArray);

        [NativeApi(EntryPoint = "glPathGlyphsNV")]
        public unsafe partial void PathGlyph([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV")]
        public partial void PathGlyph<T0, T1>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] ref T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] ref T1 charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphIndexArrayNV")]
        public unsafe partial NV PathGlyphIndexArray([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint firstGlyphIndex, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphIndexArrayNV")]
        public partial NV PathGlyphIndexArray<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Flow(FlowDirection.In)] Span<T0> fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint firstGlyphIndex, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphIndexRangeNV")]
        public unsafe partial NV PathGlyphIndexRange([Flow(FlowDirection.In)] NV fontTarget, [Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale, [Flow(FlowDirection.In)] uint baseAndCount);

        [NativeApi(EntryPoint = "glPathGlyphIndexRangeNV")]
        public partial NV PathGlyphIndexRange<T0>([Flow(FlowDirection.In)] NV fontTarget, [Flow(FlowDirection.In)] Span<T0> fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale, [Flow(FlowDirection.In)] uint baseAndCount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphRangeNV")]
        public unsafe partial void PathGlyphRange([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint firstGlyph, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphRangeNV")]
        public partial void PathGlyphRange<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] ref T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint firstGlyph, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathMemoryGlyphIndexArrayNV")]
        public unsafe partial NV PathMemoryGlyphIndexArray([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Flow(FlowDirection.In)] UIntPtr fontSize, [Flow(FlowDirection.In)] void* fontData, [Flow(FlowDirection.In)] uint faceIndex, [Flow(FlowDirection.In)] uint firstGlyphIndex, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathMemoryGlyphIndexArrayNV")]
        public partial NV PathMemoryGlyphIndexArray<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Flow(FlowDirection.In)] UIntPtr fontSize, [Flow(FlowDirection.In)] Span<T0> fontData, [Flow(FlowDirection.In)] uint faceIndex, [Flow(FlowDirection.In)] uint firstGlyphIndex, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathParameterivNV")]
        public unsafe partial void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glPathParameterivNV")]
        public partial void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int value);

        [NativeApi(EntryPoint = "glPathParameteriNV")]
        public partial void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glPathParameterfvNV")]
        public unsafe partial void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glPathParameterfvNV")]
        public partial void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float value);

        [NativeApi(EntryPoint = "glPathParameterfNV")]
        public partial void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] float value);

        [NativeApi(EntryPoint = "glPathStencilDepthOffsetNV")]
        public partial void PathStencilDepthOffset([Flow(FlowDirection.In)] float factor, [Flow(FlowDirection.In)] float units);

        [NativeApi(EntryPoint = "glPathStencilFuncNV")]
        public partial void PathStencilFunc([Flow(FlowDirection.In)] NV func, [Flow(FlowDirection.In)] int @ref, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glPathStringNV")]
        public unsafe partial void PathString([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV format, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* pathString);

        [NativeApi(EntryPoint = "glPathStringNV")]
        public partial void PathString<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV format, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] Span<T0> pathString) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathSubCommandsNV")]
        public unsafe partial void PathSubCommands([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint commandStart, [Flow(FlowDirection.In)] uint commandsToDelete, [Flow(FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] byte* commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathSubCommandsNV")]
        public partial void PathSubCommands<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint commandStart, [Flow(FlowDirection.In)] uint commandsToDelete, [Flow(FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] Span<byte> commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] ref T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathSubCoordsNV")]
        public unsafe partial void PathSubCoords([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint coordStart, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathSubCoordsNV")]
        public partial void PathSubCoords<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint coordStart, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] ref T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPointAlongPathNV")]
        public unsafe partial bool PointAlongPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint startSegment, [Flow(FlowDirection.In)] uint numSegments, [Flow(FlowDirection.In)] float distance, [Count(Count = 1), Flow(FlowDirection.Out)] float* x, [Count(Count = 1), Flow(FlowDirection.Out)] float* y, [Count(Count = 1), Flow(FlowDirection.Out)] float* tangentX, [Count(Count = 1), Flow(FlowDirection.Out)] float* tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV")]
        public partial bool PointAlongPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint startSegment, [Flow(FlowDirection.In)] uint numSegments, [Flow(FlowDirection.In)] float distance, [Count(Count = 1), Flow(FlowDirection.Out)] out float x, [Count(Count = 1), Flow(FlowDirection.Out)] out float y, [Count(Count = 1), Flow(FlowDirection.Out)] out float tangentX, [Count(Count = 1), Flow(FlowDirection.Out)] out float tangentY);

        [NativeApi(EntryPoint = "glProgramPathFragmentInputGenNV")]
        public unsafe partial void ProgramPathFragmentInputGen([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] NV genMode, [Flow(FlowDirection.In)] int components, [Flow(FlowDirection.In)] float* coeffs);

        [NativeApi(EntryPoint = "glProgramPathFragmentInputGenNV")]
        public partial void ProgramPathFragmentInputGen([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] NV genMode, [Flow(FlowDirection.In)] int components, [Flow(FlowDirection.In)] Span<float> coeffs);

        [NativeApi(EntryPoint = "glStencilFillPathNV")]
        public partial void StencilFillPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV")]
        public unsafe partial void StencilFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV")]
        public partial void StencilFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] ref T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] ref float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilStrokePathNV")]
        public partial void StencilStrokePath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV")]
        public unsafe partial void StencilStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV")]
        public partial void StencilStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] ref T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] ref float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathNV")]
        public partial void StencilThenCoverFillPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV coverMode);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV")]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV")]
        public partial void StencilThenCoverFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Flow(FlowDirection.In)] Span<T0> paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Flow(FlowDirection.In)] Span<float> transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathNV")]
        public partial void StencilThenCoverStrokePath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV coverMode);

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV")]
        public unsafe partial void StencilThenCoverStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV")]
        public partial void StencilThenCoverStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Flow(FlowDirection.In)] Span<T0> paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Flow(FlowDirection.In)] Span<float> transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTransformPathNV")]
        public unsafe partial void TransformPath([Flow(FlowDirection.In)] uint resultPath, [Flow(FlowDirection.In)] uint srcPath, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glTransformPathNV")]
        public partial void TransformPath([Flow(FlowDirection.In)] uint resultPath, [Flow(FlowDirection.In)] uint srcPath, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "transformType"), Flow(FlowDirection.In)] ref float transformValues);

        [NativeApi(EntryPoint = "glWeightPathsNV")]
        public unsafe partial void WeightPath([Flow(FlowDirection.In)] uint resultPath, [Flow(FlowDirection.In)] uint numPaths, [Count(Parameter = "numPaths"), Flow(FlowDirection.In)] uint* paths, [Count(Parameter = "numPaths"), Flow(FlowDirection.In)] float* weights);

        [NativeApi(EntryPoint = "glWeightPathsNV")]
        public partial void WeightPath([Flow(FlowDirection.In)] uint resultPath, [Flow(FlowDirection.In)] uint numPaths, [Count(Parameter = "numPaths"), Flow(FlowDirection.In)] Span<uint> paths, [Count(Parameter = "numPaths"), Flow(FlowDirection.In)] Span<float> weights);

        [NativeApi(EntryPoint = "glCoverFillPathNV")]
        public partial void CoverFillPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathCoverMode coverMode);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV")]
        public unsafe partial void CoverFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV")]
        public partial void CoverFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] ref T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] ref float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathNV")]
        public partial void CoverStrokePath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathCoverMode coverMode);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV")]
        public unsafe partial void CoverStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV")]
        public partial void CoverStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] ref T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] ref float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathCommandsNV")]
        public partial void GetPathCommands([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.Out)] string commands);

        [NativeApi(EntryPoint = "glGetPathMetricsNV")]
        public unsafe partial void GetPathMetric([Flow(FlowDirection.In)] uint metricQueryMask, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] float* metrics);

        [NativeApi(EntryPoint = "glGetPathMetricsNV")]
        public partial void GetPathMetric<T0>([Flow(FlowDirection.In)] uint metricQueryMask, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] ref T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] out float metrics) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathParameterivNV")]
        public unsafe partial void GetPathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathParameter pname, [Count(Count = 4), Flow(FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "glGetPathParameterivNV")]
        public partial void GetPathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathParameter pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> value);

        [NativeApi(EntryPoint = "glGetPathParameterfvNV")]
        public unsafe partial void GetPathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathParameter pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* value);

        [NativeApi(EntryPoint = "glGetPathParameterfvNV")]
        public partial void GetPathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathParameter pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> value);

        [NativeApi(EntryPoint = "glGetPathSpacingNV")]
        public unsafe partial void GetPathSpacing([Flow(FlowDirection.In)] PathListMode pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] float* returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV")]
        public partial void GetPathSpacing<T0>([Flow(FlowDirection.In)] PathListMode pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] ref T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] out float returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] NV* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV")]
        public partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] Span<NV> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<float> @params);

        [NativeApi(EntryPoint = "glMatrixFrustumEXT")]
        public partial void MatrixFrustum([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] double left, [Flow(FlowDirection.In)] double right, [Flow(FlowDirection.In)] double bottom, [Flow(FlowDirection.In)] double top, [Flow(FlowDirection.In)] double zNear, [Flow(FlowDirection.In)] double zFar);

        [NativeApi(EntryPoint = "glMatrixLoadfEXT")]
        public unsafe partial void MatrixLoad([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixLoadfEXT")]
        public partial void MatrixLoad([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m);

        [NativeApi(EntryPoint = "glMatrixLoaddEXT")]
        public unsafe partial void MatrixLoad([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixLoaddEXT")]
        public partial void MatrixLoad([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m);

        [NativeApi(EntryPoint = "glMatrixLoadIdentityEXT")]
        public partial void MatrixLoadIdentity([Flow(FlowDirection.In)] MatrixMode mode);

        [NativeApi(EntryPoint = "glMatrixLoadTransposefEXT")]
        public unsafe partial void MatrixLoadTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixLoadTransposefEXT")]
        public partial void MatrixLoadTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m);

        [NativeApi(EntryPoint = "glMatrixLoadTransposedEXT")]
        public unsafe partial void MatrixLoadTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixLoadTransposedEXT")]
        public partial void MatrixLoadTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m);

        [NativeApi(EntryPoint = "glMatrixMultfEXT")]
        public unsafe partial void MatrixMult([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixMultfEXT")]
        public partial void MatrixMult([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m);

        [NativeApi(EntryPoint = "glMatrixMultdEXT")]
        public unsafe partial void MatrixMult([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixMultdEXT")]
        public partial void MatrixMult([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m);

        [NativeApi(EntryPoint = "glMatrixMultTransposefEXT")]
        public unsafe partial void MatrixMultTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixMultTransposefEXT")]
        public partial void MatrixMultTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m);

        [NativeApi(EntryPoint = "glMatrixMultTransposedEXT")]
        public unsafe partial void MatrixMultTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixMultTransposedEXT")]
        public partial void MatrixMultTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m);

        [NativeApi(EntryPoint = "glMatrixOrthoEXT")]
        public partial void MatrixOrtho([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] double left, [Flow(FlowDirection.In)] double right, [Flow(FlowDirection.In)] double bottom, [Flow(FlowDirection.In)] double top, [Flow(FlowDirection.In)] double zNear, [Flow(FlowDirection.In)] double zFar);

        [NativeApi(EntryPoint = "glMatrixPopEXT")]
        public partial void MatrixPop([Flow(FlowDirection.In)] MatrixMode mode);

        [NativeApi(EntryPoint = "glMatrixPushEXT")]
        public partial void MatrixPush([Flow(FlowDirection.In)] MatrixMode mode);

        [NativeApi(EntryPoint = "glMatrixRotatefEXT")]
        public partial void MatrixRotate([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] float angle, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glMatrixRotatedEXT")]
        public partial void MatrixRotate([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] double angle, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glMatrixScalefEXT")]
        public partial void MatrixScale([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glMatrixScaledEXT")]
        public partial void MatrixScale([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glMatrixTranslatefEXT")]
        public partial void MatrixTranslate([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glMatrixTranslatedEXT")]
        public partial void MatrixTranslate([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glPathCommandsNV")]
        public unsafe partial void PathCommands([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCommands, [Flow(FlowDirection.In)] string commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathCommandsNV")]
        public partial void PathCommands<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCommands, [Flow(FlowDirection.In)] string commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] ref T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathCoordsNV")]
        public unsafe partial void PathCoords([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathCoordsNV")]
        public partial void PathCoords<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] ref T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathCoverDepthFuncNV")]
        public partial void PathCoverDepthFunc([Flow(FlowDirection.In)] DepthFunction func);

        [NativeApi(EntryPoint = "glPathGlyphsNV")]
        public unsafe partial void PathGlyph([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV")]
        public partial void PathGlyph<T0, T1>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] ref T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] ref T1 charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphRangeNV")]
        public unsafe partial void PathGlyphRange([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint firstGlyph, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphRangeNV")]
        public partial void PathGlyphRange<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] ref T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint firstGlyph, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathParameterivNV")]
        public unsafe partial void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glPathParameterivNV")]
        public partial void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int value);

        [NativeApi(EntryPoint = "glPathParameteriNV")]
        public partial void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathParameter pname, [Flow(FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glPathParameterfvNV")]
        public unsafe partial void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glPathParameterfvNV")]
        public partial void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float value);

        [NativeApi(EntryPoint = "glPathParameterfNV")]
        public partial void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathParameter pname, [Flow(FlowDirection.In)] float value);

        [NativeApi(EntryPoint = "glPathStencilFuncNV")]
        public partial void PathStencilFunc([Flow(FlowDirection.In)] StencilFunction func, [Flow(FlowDirection.In)] int @ref, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glPathStringNV")]
        public unsafe partial void PathString([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathStringFormat format, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* pathString);

        [NativeApi(EntryPoint = "glPathStringNV")]
        public partial void PathString<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathStringFormat format, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] Span<T0> pathString) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathSubCommandsNV")]
        public unsafe partial void PathSubCommands([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint commandStart, [Flow(FlowDirection.In)] uint commandsToDelete, [Flow(FlowDirection.In)] uint numCommands, [Flow(FlowDirection.In)] string commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathSubCommandsNV")]
        public partial void PathSubCommands<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint commandStart, [Flow(FlowDirection.In)] uint commandsToDelete, [Flow(FlowDirection.In)] uint numCommands, [Flow(FlowDirection.In)] string commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] ref T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathSubCoordsNV")]
        public unsafe partial void PathSubCoords([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint coordStart, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathSubCoordsNV")]
        public partial void PathSubCoords<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint coordStart, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] ref T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathNV")]
        public partial void StencilFillPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathFillMode fillMode, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV")]
        public unsafe partial void StencilFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathFillMode fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV")]
        public partial void StencilFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] ref T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathFillMode fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] ref float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV")]
        public unsafe partial void StencilStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV")]
        public partial void StencilStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] ref T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] ref float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTransformPathNV")]
        public unsafe partial void TransformPath([Flow(FlowDirection.In)] uint resultPath, [Flow(FlowDirection.In)] uint srcPath, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glTransformPathNV")]
        public partial void TransformPath([Flow(FlowDirection.In)] uint resultPath, [Flow(FlowDirection.In)] uint srcPath, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "transformType"), Flow(FlowDirection.In)] ref float transformValues);

        public unsafe byte GetPathCommand()
        {
            const uint path = 1;
            // ReturnTypeOverloader
            byte ret = default;
            GetPathCommands(path, &ret);
            return ret;
        }

        public unsafe float GetPathCoord()
        {
            const uint path = 1;
            // ReturnTypeOverloader
            float ret = default;
            GetPathCoords(path, &ret);
            return ret;
        }

        public unsafe float GetPathDashArray()
        {
            const uint path = 1;
            // ReturnTypeOverloader
            float ret = default;
            GetPathDashArray(path, &ret);
            return ret;
        }

        public unsafe NV PathMemoryGlyphIndexArray([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Flow(FlowDirection.In)] uint fontSize, [Flow(FlowDirection.In)] void* fontData, [Flow(FlowDirection.In)] uint faceIndex, [Flow(FlowDirection.In)] uint firstGlyphIndex, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale)
        {
            // IntPtrOverloader
            return PathMemoryGlyphIndexArray(firstPathName, fontTarget, new UIntPtr(fontSize), fontData, faceIndex, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
        }

        public unsafe NV PathMemoryGlyphIndexArray<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Flow(FlowDirection.In)] uint fontSize, [Flow(FlowDirection.In)] Span<T0> fontData, [Flow(FlowDirection.In)] uint faceIndex, [Flow(FlowDirection.In)] uint firstGlyphIndex, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // IntPtrOverloader
            return PathMemoryGlyphIndexArray(firstPathName, fontTarget, new UIntPtr(fontSize), fontData, faceIndex, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
        }

        public NVPathRendering(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

