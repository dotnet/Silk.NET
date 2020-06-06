// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_path_rendering")]
    public unsafe partial class NVPathRendering : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_path_rendering";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="resultPath">
        /// To be added.
        /// </param>
        /// <param name="srcPath">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyPathNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyPath([Flow(FlowDirection.In)] uint resultPath, [Flow(FlowDirection.In)] uint srcPath)
            => ImplCopyPath(resultPath, srcPath);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="coverMode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCoverFillPathNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CoverFillPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV coverMode)
            => ImplCoverFillPath(path, coverMode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="pathNameType">
        /// To be added.
        /// </param>
        /// <param name="paths">
        /// To be added.
        /// This parameter's element count is computed from numPaths, pathNameType, and paths.
        /// </param>
        /// <param name="pathBase">
        /// To be added.
        /// </param>
        /// <param name="coverMode">
        /// To be added.
        /// </param>
        /// <param name="transformType">
        /// To be added.
        /// </param>
        /// <param name="transformValues">
        /// To be added.
        /// This parameter's element count is computed from numPaths and transformType.
        /// </param>
        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CoverFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues)
            => ImplCoverFillPathInstanced(numPaths, pathNameType, paths, pathBase, coverMode, transformType, transformValues);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="pathNameType">
        /// To be added.
        /// </param>
        /// <param name="paths">
        /// To be added.
        /// This parameter's element count is computed from numPaths, pathNameType, and paths.
        /// </param>
        /// <param name="pathBase">
        /// To be added.
        /// </param>
        /// <param name="coverMode">
        /// To be added.
        /// </param>
        /// <param name="transformType">
        /// To be added.
        /// </param>
        /// <param name="transformValues">
        /// To be added.
        /// This parameter's element count is computed from numPaths and transformType.
        /// </param>
        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CoverFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] ref T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] ref float transformValues) where T0 : unmanaged
            => ImplCoverFillPathInstanced<T0>(numPaths, pathNameType, paths, pathBase, coverMode, transformType, transformValues);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="coverMode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCoverStrokePathNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CoverStrokePath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV coverMode)
            => ImplCoverStrokePath(path, coverMode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="pathNameType">
        /// To be added.
        /// </param>
        /// <param name="paths">
        /// To be added.
        /// This parameter's element count is computed from numPaths, pathNameType, and paths.
        /// </param>
        /// <param name="pathBase">
        /// To be added.
        /// </param>
        /// <param name="coverMode">
        /// To be added.
        /// </param>
        /// <param name="transformType">
        /// To be added.
        /// </param>
        /// <param name="transformValues">
        /// To be added.
        /// This parameter's element count is computed from numPaths and transformType.
        /// </param>
        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CoverStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues)
            => ImplCoverStrokePathInstanced(numPaths, pathNameType, paths, pathBase, coverMode, transformType, transformValues);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="pathNameType">
        /// To be added.
        /// </param>
        /// <param name="paths">
        /// To be added.
        /// This parameter's element count is computed from numPaths, pathNameType, and paths.
        /// </param>
        /// <param name="pathBase">
        /// To be added.
        /// </param>
        /// <param name="coverMode">
        /// To be added.
        /// </param>
        /// <param name="transformType">
        /// To be added.
        /// </param>
        /// <param name="transformValues">
        /// To be added.
        /// This parameter's element count is computed from numPaths and transformType.
        /// </param>
        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CoverStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] ref T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] ref float transformValues) where T0 : unmanaged
            => ImplCoverStrokePathInstanced<T0>(numPaths, pathNameType, paths, pathBase, coverMode, transformType, transformValues);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="range">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDeletePathsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeletePath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint range)
            => ImplDeletePath(path, range);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="range">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGenPathsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint GenPath([Flow(FlowDirection.In)] uint range)
            => ImplGenPath(range);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="commands">
        /// To be added.
        /// This parameter's element count is computed from path.
        /// </param>
        [NativeApi(EntryPoint = "glGetPathCommandsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPathCommands([Flow(FlowDirection.In)] uint path, [Count(Computed = "path"), Flow(FlowDirection.Out)] byte* commands)
            => ImplGetPathCommands(path, commands);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="commands">
        /// To be added.
        /// This parameter's element count is computed from path.
        /// </param>
        [NativeApi(EntryPoint = "glGetPathCommandsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPathCommands([Flow(FlowDirection.In)] uint path, [Count(Computed = "path"), Flow(FlowDirection.Out)] out byte commands)
            => ImplGetPathCommands(path, commands);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter's element count is computed from path.
        /// </param>
        [NativeApi(EntryPoint = "glGetPathCoordsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPathCoords([Flow(FlowDirection.In)] uint path, [Count(Computed = "path"), Flow(FlowDirection.Out)] float* coords)
            => ImplGetPathCoords(path, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter's element count is computed from path.
        /// </param>
        [NativeApi(EntryPoint = "glGetPathCoordsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPathCoords([Flow(FlowDirection.In)] uint path, [Count(Computed = "path"), Flow(FlowDirection.Out)] out float coords)
            => ImplGetPathCoords(path, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="dashArray">
        /// To be added.
        /// This parameter's element count is computed from path.
        /// </param>
        [NativeApi(EntryPoint = "glGetPathDashArrayNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPathDashArray([Flow(FlowDirection.In)] uint path, [Count(Computed = "path"), Flow(FlowDirection.Out)] float* dashArray)
            => ImplGetPathDashArray(path, dashArray);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="dashArray">
        /// To be added.
        /// This parameter's element count is computed from path.
        /// </param>
        [NativeApi(EntryPoint = "glGetPathDashArrayNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPathDashArray([Flow(FlowDirection.In)] uint path, [Count(Computed = "path"), Flow(FlowDirection.Out)] out float dashArray)
            => ImplGetPathDashArray(path, dashArray);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="startSegment">
        /// To be added.
        /// </param>
        /// <param name="numSegments">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetPathLengthNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public float GetPathLength([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint startSegment, [Flow(FlowDirection.In)] uint numSegments)
            => ImplGetPathLength(path, startSegment, numSegments);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="metricQueryMask">
        /// To be added.
        /// </param>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="pathNameType">
        /// To be added.
        /// </param>
        /// <param name="paths">
        /// To be added.
        /// This parameter's element count is computed from numPaths, pathNameType, and paths.
        /// </param>
        /// <param name="pathBase">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="metrics">
        /// To be added.
        /// This parameter's element count is computed from metricQueryMask, numPaths, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glGetPathMetricsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPathMetric([Flow(FlowDirection.In)] uint metricQueryMask, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] float* metrics)
            => ImplGetPathMetric(metricQueryMask, numPaths, pathNameType, paths, pathBase, stride, metrics);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="metricQueryMask">
        /// To be added.
        /// </param>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="pathNameType">
        /// To be added.
        /// </param>
        /// <param name="paths">
        /// To be added.
        /// This parameter's element count is computed from numPaths, pathNameType, and paths.
        /// </param>
        /// <param name="pathBase">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="metrics">
        /// To be added.
        /// This parameter's element count is computed from metricQueryMask, numPaths, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glGetPathMetricsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPathMetric<T0>([Flow(FlowDirection.In)] uint metricQueryMask, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] ref T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] out float metrics) where T0 : unmanaged
            => ImplGetPathMetric<T0>(metricQueryMask, numPaths, pathNameType, paths, pathBase, stride, metrics);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="metricQueryMask">
        /// To be added.
        /// </param>
        /// <param name="firstPathName">
        /// To be added.
        /// </param>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="metrics">
        /// To be added.
        /// This parameter's element count is computed from metricQueryMask, numPaths, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glGetPathMetricRangeNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPathMetricRange([Flow(FlowDirection.In)] uint metricQueryMask, [Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] float* metrics)
            => ImplGetPathMetricRange(metricQueryMask, firstPathName, numPaths, stride, metrics);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="metricQueryMask">
        /// To be added.
        /// </param>
        /// <param name="firstPathName">
        /// To be added.
        /// </param>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="metrics">
        /// To be added.
        /// This parameter's element count is computed from metricQueryMask, numPaths, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glGetPathMetricRangeNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPathMetricRange([Flow(FlowDirection.In)] uint metricQueryMask, [Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] out float metrics)
            => ImplGetPathMetricRange(metricQueryMask, firstPathName, numPaths, stride, metrics);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetPathParameterivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] int* value)
            => ImplGetPathParameter(path, pname, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetPathParameterivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> value)
            => ImplGetPathParameter(path, pname, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetPathParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* value)
            => ImplGetPathParameter(path, pname, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetPathParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> value)
            => ImplGetPathParameter(path, pname, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pathListMode">
        /// To be added.
        /// </param>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="pathNameType">
        /// To be added.
        /// </param>
        /// <param name="paths">
        /// To be added.
        /// This parameter's element count is computed from numPaths, pathNameType, and paths.
        /// </param>
        /// <param name="pathBase">
        /// To be added.
        /// </param>
        /// <param name="advanceScale">
        /// To be added.
        /// </param>
        /// <param name="kerningScale">
        /// To be added.
        /// </param>
        /// <param name="transformType">
        /// To be added.
        /// </param>
        /// <param name="returnedSpacing">
        /// To be added.
        /// This parameter's element count is computed from pathListMode and numPaths.
        /// </param>
        [NativeApi(EntryPoint = "glGetPathSpacingNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPathSpacing([Flow(FlowDirection.In)] NV pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] float* returnedSpacing)
            => ImplGetPathSpacing(pathListMode, numPaths, pathNameType, paths, pathBase, advanceScale, kerningScale, transformType, returnedSpacing);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pathListMode">
        /// To be added.
        /// </param>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="pathNameType">
        /// To be added.
        /// </param>
        /// <param name="paths">
        /// To be added.
        /// This parameter's element count is computed from numPaths, pathNameType, and paths.
        /// </param>
        /// <param name="pathBase">
        /// To be added.
        /// </param>
        /// <param name="advanceScale">
        /// To be added.
        /// </param>
        /// <param name="kerningScale">
        /// To be added.
        /// </param>
        /// <param name="transformType">
        /// To be added.
        /// </param>
        /// <param name="returnedSpacing">
        /// To be added.
        /// This parameter's element count is computed from pathListMode and numPaths.
        /// </param>
        [NativeApi(EntryPoint = "glGetPathSpacingNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPathSpacing<T0>([Flow(FlowDirection.In)] NV pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] ref T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] out float returnedSpacing) where T0 : unmanaged
            => ImplGetPathSpacing<T0>(pathListMode, numPaths, pathNameType, paths, pathBase, advanceScale, kerningScale, transformType, returnedSpacing);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="propCount">
        /// To be added.
        /// </param>
        /// <param name="props">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramResourcefvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] NV programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] NV* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetProgramResource(program, programInterface, index, propCount, props, count, length, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="propCount">
        /// To be added.
        /// </param>
        /// <param name="props">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramResourcefvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] NV programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] Span<NV> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<float> @params)
            => ImplGetProgramResource(program, programInterface, index, propCount, props, count, length, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="resultPath">
        /// To be added.
        /// </param>
        /// <param name="pathA">
        /// To be added.
        /// </param>
        /// <param name="pathB">
        /// To be added.
        /// </param>
        /// <param name="weight">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glInterpolatePathsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void InterpolatePath([Flow(FlowDirection.In)] uint resultPath, [Flow(FlowDirection.In)] uint pathA, [Flow(FlowDirection.In)] uint pathB, [Flow(FlowDirection.In)] float weight)
            => ImplInterpolatePath(resultPath, pathA, pathB, weight);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsPathNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsPath([Flow(FlowDirection.In)] uint path)
            => ImplIsPath(path);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsPointInFillPathNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsPointInFillPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y)
            => ImplIsPointInFillPath(path, mask, x, y);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsPointInStrokePathNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsPointInStrokePath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y)
            => ImplIsPointInStrokePath(path, x, y);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="left">
        /// To be added.
        /// </param>
        /// <param name="right">
        /// To be added.
        /// </param>
        /// <param name="bottom">
        /// To be added.
        /// </param>
        /// <param name="top">
        /// To be added.
        /// </param>
        /// <param name="zNear">
        /// To be added.
        /// </param>
        /// <param name="zFar">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixFrustumEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixFrustum([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] double left, [Flow(FlowDirection.In)] double right, [Flow(FlowDirection.In)] double bottom, [Flow(FlowDirection.In)] double top, [Flow(FlowDirection.In)] double zNear, [Flow(FlowDirection.In)] double zFar)
            => ImplMatrixFrustum(mode, left, right, bottom, top, zNear, zFar);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoadfEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixLoad([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m)
            => ImplMatrixLoad(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoadfEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixLoad([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m)
            => ImplMatrixLoad(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoaddEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixLoad([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m)
            => ImplMatrixLoad(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoaddEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixLoad([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m)
            => ImplMatrixLoad(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="matrixMode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoad3x2fNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixLoad3x2([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] float* m)
            => ImplMatrixLoad3x2(matrixMode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="matrixMode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoad3x2fNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixLoad3x2([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] Span<float> m)
            => ImplMatrixLoad3x2(matrixMode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="matrixMode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoad3x3fNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixLoad3x3([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] float* m)
            => ImplMatrixLoad3x3(matrixMode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="matrixMode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoad3x3fNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixLoad3x3([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] Span<float> m)
            => ImplMatrixLoad3x3(matrixMode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoadIdentityEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixLoadIdentity([Flow(FlowDirection.In)] NV mode)
            => ImplMatrixLoadIdentity(mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoadTransposefEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixLoadTranspose([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m)
            => ImplMatrixLoadTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoadTransposefEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixLoadTranspose([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m)
            => ImplMatrixLoadTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoadTransposedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixLoadTranspose([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m)
            => ImplMatrixLoadTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoadTransposedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixLoadTranspose([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m)
            => ImplMatrixLoadTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="matrixMode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoadTranspose3x3fNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixLoadTranspose3x3([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] float* m)
            => ImplMatrixLoadTranspose3x3(matrixMode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="matrixMode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoadTranspose3x3fNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixLoadTranspose3x3([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] Span<float> m)
            => ImplMatrixLoadTranspose3x3(matrixMode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultfEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixMult([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m)
            => ImplMatrixMult(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultfEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixMult([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m)
            => ImplMatrixMult(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultdEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixMult([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m)
            => ImplMatrixMult(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultdEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixMult([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m)
            => ImplMatrixMult(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="matrixMode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMult3x2fNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixMult3x2([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] float* m)
            => ImplMatrixMult3x2(matrixMode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="matrixMode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMult3x2fNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixMult3x2([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] Span<float> m)
            => ImplMatrixMult3x2(matrixMode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="matrixMode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMult3x3fNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixMult3x3([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] float* m)
            => ImplMatrixMult3x3(matrixMode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="matrixMode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMult3x3fNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixMult3x3([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] Span<float> m)
            => ImplMatrixMult3x3(matrixMode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultTransposefEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixMultTranspose([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m)
            => ImplMatrixMultTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultTransposefEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixMultTranspose([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m)
            => ImplMatrixMultTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultTransposedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixMultTranspose([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m)
            => ImplMatrixMultTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultTransposedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixMultTranspose([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m)
            => ImplMatrixMultTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="matrixMode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultTranspose3x3fNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixMultTranspose3x3([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] float* m)
            => ImplMatrixMultTranspose3x3(matrixMode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="matrixMode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultTranspose3x3fNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixMultTranspose3x3([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] Span<float> m)
            => ImplMatrixMultTranspose3x3(matrixMode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="left">
        /// To be added.
        /// </param>
        /// <param name="right">
        /// To be added.
        /// </param>
        /// <param name="bottom">
        /// To be added.
        /// </param>
        /// <param name="top">
        /// To be added.
        /// </param>
        /// <param name="zNear">
        /// To be added.
        /// </param>
        /// <param name="zFar">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixOrthoEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixOrtho([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] double left, [Flow(FlowDirection.In)] double right, [Flow(FlowDirection.In)] double bottom, [Flow(FlowDirection.In)] double top, [Flow(FlowDirection.In)] double zNear, [Flow(FlowDirection.In)] double zFar)
            => ImplMatrixOrtho(mode, left, right, bottom, top, zNear, zFar);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixPopEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixPop([Flow(FlowDirection.In)] NV mode)
            => ImplMatrixPop(mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixPushEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixPush([Flow(FlowDirection.In)] NV mode)
            => ImplMatrixPush(mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
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
        [NativeApi(EntryPoint = "glMatrixRotatefEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixRotate([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] float angle, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z)
            => ImplMatrixRotate(mode, angle, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
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
        [NativeApi(EntryPoint = "glMatrixRotatedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixRotate([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] double angle, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z)
            => ImplMatrixRotate(mode, angle, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
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
        [NativeApi(EntryPoint = "glMatrixScalefEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixScale([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z)
            => ImplMatrixScale(mode, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
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
        [NativeApi(EntryPoint = "glMatrixScaledEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixScale([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z)
            => ImplMatrixScale(mode, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
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
        [NativeApi(EntryPoint = "glMatrixTranslatefEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixTranslate([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z)
            => ImplMatrixTranslate(mode, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
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
        [NativeApi(EntryPoint = "glMatrixTranslatedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixTranslate([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z)
            => ImplMatrixTranslate(mode, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="numCommands">
        /// To be added.
        /// </param>
        /// <param name="commands">
        /// To be added.
        /// This parameter's element count is taken from numCommands.
        /// </param>
        /// <param name="numCoords">
        /// To be added.
        /// </param>
        /// <param name="coordType">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter's element count is computed from numCoords and coordType.
        /// </param>
        [NativeApi(EntryPoint = "glPathCommandsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PathCommands([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] byte* commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords)
            => ImplPathCommands(path, numCommands, commands, numCoords, coordType, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="numCommands">
        /// To be added.
        /// </param>
        /// <param name="commands">
        /// To be added.
        /// This parameter's element count is taken from numCommands.
        /// </param>
        /// <param name="numCoords">
        /// To be added.
        /// </param>
        /// <param name="coordType">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter's element count is computed from numCoords and coordType.
        /// </param>
        [NativeApi(EntryPoint = "glPathCommandsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PathCommands<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] Span<byte> commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] ref T0 coords) where T0 : unmanaged
            => ImplPathCommands<T0>(path, numCommands, commands, numCoords, coordType, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="numCoords">
        /// To be added.
        /// </param>
        /// <param name="coordType">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter's element count is computed from numCoords and coordType.
        /// </param>
        [NativeApi(EntryPoint = "glPathCoordsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PathCoords([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords)
            => ImplPathCoords(path, numCoords, coordType, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="numCoords">
        /// To be added.
        /// </param>
        /// <param name="coordType">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter's element count is computed from numCoords and coordType.
        /// </param>
        [NativeApi(EntryPoint = "glPathCoordsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PathCoords<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] ref T0 coords) where T0 : unmanaged
            => ImplPathCoords<T0>(path, numCoords, coordType, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="func">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPathCoverDepthFuncNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PathCoverDepthFunc([Flow(FlowDirection.In)] NV func)
            => ImplPathCoverDepthFunc(func);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="dashCount">
        /// To be added.
        /// </param>
        /// <param name="dashArray">
        /// To be added.
        /// This parameter's element count is taken from dashCount.
        /// </param>
        [NativeApi(EntryPoint = "glPathDashArrayNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PathDashArray([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint dashCount, [Count(Parameter = "dashCount"), Flow(FlowDirection.In)] float* dashArray)
            => ImplPathDashArray(path, dashCount, dashArray);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="dashCount">
        /// To be added.
        /// </param>
        /// <param name="dashArray">
        /// To be added.
        /// This parameter's element count is taken from dashCount.
        /// </param>
        [NativeApi(EntryPoint = "glPathDashArrayNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PathDashArray([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint dashCount, [Count(Parameter = "dashCount"), Flow(FlowDirection.In)] Span<float> dashArray)
            => ImplPathDashArray(path, dashCount, dashArray);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="firstPathName">
        /// To be added.
        /// </param>
        /// <param name="fontTarget">
        /// To be added.
        /// </param>
        /// <param name="fontName">
        /// To be added.
        /// This parameter's element count is computed from fontTarget and fontName.
        /// </param>
        /// <param name="fontStyle">
        /// To be added.
        /// </param>
        /// <param name="numGlyphs">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="charcodes">
        /// To be added.
        /// This parameter's element count is computed from numGlyphs, type, and charcodes.
        /// </param>
        /// <param name="handleMissingGlyphs">
        /// To be added.
        /// </param>
        /// <param name="pathParameterTemplate">
        /// To be added.
        /// </param>
        /// <param name="emScale">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPathGlyphsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PathGlyph([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale)
            => ImplPathGlyph(firstPathName, fontTarget, fontName, fontStyle, numGlyphs, type, charcodes, handleMissingGlyphs, pathParameterTemplate, emScale);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="firstPathName">
        /// To be added.
        /// </param>
        /// <param name="fontTarget">
        /// To be added.
        /// </param>
        /// <param name="fontName">
        /// To be added.
        /// This parameter's element count is computed from fontTarget and fontName.
        /// </param>
        /// <param name="fontStyle">
        /// To be added.
        /// </param>
        /// <param name="numGlyphs">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="charcodes">
        /// To be added.
        /// This parameter's element count is computed from numGlyphs, type, and charcodes.
        /// </param>
        /// <param name="handleMissingGlyphs">
        /// To be added.
        /// </param>
        /// <param name="pathParameterTemplate">
        /// To be added.
        /// </param>
        /// <param name="emScale">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPathGlyphsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PathGlyph<T0, T1>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] ref T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] ref T1 charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged
            => ImplPathGlyph<T0, T1>(firstPathName, fontTarget, fontName, fontStyle, numGlyphs, type, charcodes, handleMissingGlyphs, pathParameterTemplate, emScale);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="firstPathName">
        /// To be added.
        /// </param>
        /// <param name="fontTarget">
        /// To be added.
        /// </param>
        /// <param name="fontName">
        /// To be added.
        /// </param>
        /// <param name="fontStyle">
        /// To be added.
        /// </param>
        /// <param name="firstGlyphIndex">
        /// To be added.
        /// </param>
        /// <param name="numGlyphs">
        /// To be added.
        /// </param>
        /// <param name="pathParameterTemplate">
        /// To be added.
        /// </param>
        /// <param name="emScale">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glPathGlyphIndexArrayNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe NV PathGlyphIndexArray([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint firstGlyphIndex, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale)
            => ImplPathGlyphIndexArray(firstPathName, fontTarget, fontName, fontStyle, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="firstPathName">
        /// To be added.
        /// </param>
        /// <param name="fontTarget">
        /// To be added.
        /// </param>
        /// <param name="fontName">
        /// To be added.
        /// </param>
        /// <param name="fontStyle">
        /// To be added.
        /// </param>
        /// <param name="firstGlyphIndex">
        /// To be added.
        /// </param>
        /// <param name="numGlyphs">
        /// To be added.
        /// </param>
        /// <param name="pathParameterTemplate">
        /// To be added.
        /// </param>
        /// <param name="emScale">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glPathGlyphIndexArrayNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public NV PathGlyphIndexArray<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Flow(FlowDirection.In)] Span<T0> fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint firstGlyphIndex, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged
            => ImplPathGlyphIndexArray<T0>(firstPathName, fontTarget, fontName, fontStyle, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="fontTarget">
        /// To be added.
        /// </param>
        /// <param name="fontName">
        /// To be added.
        /// </param>
        /// <param name="fontStyle">
        /// To be added.
        /// </param>
        /// <param name="pathParameterTemplate">
        /// To be added.
        /// </param>
        /// <param name="emScale">
        /// To be added.
        /// </param>
        /// <param name="baseAndCount">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glPathGlyphIndexRangeNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe NV PathGlyphIndexRange([Flow(FlowDirection.In)] NV fontTarget, [Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale, [Flow(FlowDirection.In)] uint baseAndCount)
            => ImplPathGlyphIndexRange(fontTarget, fontName, fontStyle, pathParameterTemplate, emScale, baseAndCount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="fontTarget">
        /// To be added.
        /// </param>
        /// <param name="fontName">
        /// To be added.
        /// </param>
        /// <param name="fontStyle">
        /// To be added.
        /// </param>
        /// <param name="pathParameterTemplate">
        /// To be added.
        /// </param>
        /// <param name="emScale">
        /// To be added.
        /// </param>
        /// <param name="baseAndCount">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glPathGlyphIndexRangeNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public NV PathGlyphIndexRange<T0>([Flow(FlowDirection.In)] NV fontTarget, [Flow(FlowDirection.In)] Span<T0> fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale, [Flow(FlowDirection.In)] uint baseAndCount) where T0 : unmanaged
            => ImplPathGlyphIndexRange<T0>(fontTarget, fontName, fontStyle, pathParameterTemplate, emScale, baseAndCount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="firstPathName">
        /// To be added.
        /// </param>
        /// <param name="fontTarget">
        /// To be added.
        /// </param>
        /// <param name="fontName">
        /// To be added.
        /// This parameter's element count is computed from fontTarget and fontName.
        /// </param>
        /// <param name="fontStyle">
        /// To be added.
        /// </param>
        /// <param name="firstGlyph">
        /// To be added.
        /// </param>
        /// <param name="numGlyphs">
        /// To be added.
        /// </param>
        /// <param name="handleMissingGlyphs">
        /// To be added.
        /// </param>
        /// <param name="pathParameterTemplate">
        /// To be added.
        /// </param>
        /// <param name="emScale">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPathGlyphRangeNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PathGlyphRange([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint firstGlyph, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale)
            => ImplPathGlyphRange(firstPathName, fontTarget, fontName, fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="firstPathName">
        /// To be added.
        /// </param>
        /// <param name="fontTarget">
        /// To be added.
        /// </param>
        /// <param name="fontName">
        /// To be added.
        /// This parameter's element count is computed from fontTarget and fontName.
        /// </param>
        /// <param name="fontStyle">
        /// To be added.
        /// </param>
        /// <param name="firstGlyph">
        /// To be added.
        /// </param>
        /// <param name="numGlyphs">
        /// To be added.
        /// </param>
        /// <param name="handleMissingGlyphs">
        /// To be added.
        /// </param>
        /// <param name="pathParameterTemplate">
        /// To be added.
        /// </param>
        /// <param name="emScale">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPathGlyphRangeNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PathGlyphRange<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] ref T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint firstGlyph, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged
            => ImplPathGlyphRange<T0>(firstPathName, fontTarget, fontName, fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="firstPathName">
        /// To be added.
        /// </param>
        /// <param name="fontTarget">
        /// To be added.
        /// </param>
        /// <param name="fontSize">
        /// To be added.
        /// </param>
        /// <param name="fontData">
        /// To be added.
        /// </param>
        /// <param name="faceIndex">
        /// To be added.
        /// </param>
        /// <param name="firstGlyphIndex">
        /// To be added.
        /// </param>
        /// <param name="numGlyphs">
        /// To be added.
        /// </param>
        /// <param name="pathParameterTemplate">
        /// To be added.
        /// </param>
        /// <param name="emScale">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glPathMemoryGlyphIndexArrayNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe NV PathMemoryGlyphIndexArray([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Flow(FlowDirection.In)] UIntPtr fontSize, [Flow(FlowDirection.In)] void* fontData, [Flow(FlowDirection.In)] uint faceIndex, [Flow(FlowDirection.In)] uint firstGlyphIndex, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale)
            => ImplPathMemoryGlyphIndexArray(firstPathName, fontTarget, fontSize, fontData, faceIndex, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="firstPathName">
        /// To be added.
        /// </param>
        /// <param name="fontTarget">
        /// To be added.
        /// </param>
        /// <param name="fontSize">
        /// To be added.
        /// </param>
        /// <param name="fontData">
        /// To be added.
        /// </param>
        /// <param name="faceIndex">
        /// To be added.
        /// </param>
        /// <param name="firstGlyphIndex">
        /// To be added.
        /// </param>
        /// <param name="numGlyphs">
        /// To be added.
        /// </param>
        /// <param name="pathParameterTemplate">
        /// To be added.
        /// </param>
        /// <param name="emScale">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glPathMemoryGlyphIndexArrayNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public NV PathMemoryGlyphIndexArray<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Flow(FlowDirection.In)] UIntPtr fontSize, [Flow(FlowDirection.In)] Span<T0> fontData, [Flow(FlowDirection.In)] uint faceIndex, [Flow(FlowDirection.In)] uint firstGlyphIndex, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged
            => ImplPathMemoryGlyphIndexArray<T0>(firstPathName, fontTarget, fontSize, fontData, faceIndex, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glPathParameterivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* value)
            => ImplPathParameter(path, pname, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glPathParameterivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int value)
            => ImplPathParameter(path, pname, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPathParameteriNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] int value)
            => ImplPathParameter(path, pname, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glPathParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* value)
            => ImplPathParameter(path, pname, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glPathParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float value)
            => ImplPathParameter(path, pname, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPathParameterfNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] float value)
            => ImplPathParameter(path, pname, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="factor">
        /// To be added.
        /// </param>
        /// <param name="units">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPathStencilDepthOffsetNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PathStencilDepthOffset([Flow(FlowDirection.In)] float factor, [Flow(FlowDirection.In)] float units)
            => ImplPathStencilDepthOffset(factor, units);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="func">
        /// To be added.
        /// </param>
        /// <param name="@ref">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPathStencilFuncNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PathStencilFunc([Flow(FlowDirection.In)] NV func, [Flow(FlowDirection.In)] int @ref, [Flow(FlowDirection.In)] uint mask)
            => ImplPathStencilFunc(func, @ref, mask);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="pathString">
        /// To be added.
        /// This parameter's element count is taken from length.
        /// </param>
        [NativeApi(EntryPoint = "glPathStringNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PathString([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV format, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* pathString)
            => ImplPathString(path, format, length, pathString);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="pathString">
        /// To be added.
        /// This parameter's element count is taken from length.
        /// </param>
        [NativeApi(EntryPoint = "glPathStringNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PathString<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV format, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] Span<T0> pathString) where T0 : unmanaged
            => ImplPathString<T0>(path, format, length, pathString);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="commandStart">
        /// To be added.
        /// </param>
        /// <param name="commandsToDelete">
        /// To be added.
        /// </param>
        /// <param name="numCommands">
        /// To be added.
        /// </param>
        /// <param name="commands">
        /// To be added.
        /// This parameter's element count is taken from numCommands.
        /// </param>
        /// <param name="numCoords">
        /// To be added.
        /// </param>
        /// <param name="coordType">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter's element count is computed from numCoords and coordType.
        /// </param>
        [NativeApi(EntryPoint = "glPathSubCommandsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PathSubCommands([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint commandStart, [Flow(FlowDirection.In)] uint commandsToDelete, [Flow(FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] byte* commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords)
            => ImplPathSubCommands(path, commandStart, commandsToDelete, numCommands, commands, numCoords, coordType, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="commandStart">
        /// To be added.
        /// </param>
        /// <param name="commandsToDelete">
        /// To be added.
        /// </param>
        /// <param name="numCommands">
        /// To be added.
        /// </param>
        /// <param name="commands">
        /// To be added.
        /// This parameter's element count is taken from numCommands.
        /// </param>
        /// <param name="numCoords">
        /// To be added.
        /// </param>
        /// <param name="coordType">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter's element count is computed from numCoords and coordType.
        /// </param>
        [NativeApi(EntryPoint = "glPathSubCommandsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PathSubCommands<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint commandStart, [Flow(FlowDirection.In)] uint commandsToDelete, [Flow(FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] Span<byte> commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] ref T0 coords) where T0 : unmanaged
            => ImplPathSubCommands<T0>(path, commandStart, commandsToDelete, numCommands, commands, numCoords, coordType, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="coordStart">
        /// To be added.
        /// </param>
        /// <param name="numCoords">
        /// To be added.
        /// </param>
        /// <param name="coordType">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter's element count is computed from numCoords and coordType.
        /// </param>
        [NativeApi(EntryPoint = "glPathSubCoordsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PathSubCoords([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint coordStart, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords)
            => ImplPathSubCoords(path, coordStart, numCoords, coordType, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="coordStart">
        /// To be added.
        /// </param>
        /// <param name="numCoords">
        /// To be added.
        /// </param>
        /// <param name="coordType">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter's element count is computed from numCoords and coordType.
        /// </param>
        [NativeApi(EntryPoint = "glPathSubCoordsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PathSubCoords<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint coordStart, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] ref T0 coords) where T0 : unmanaged
            => ImplPathSubCoords<T0>(path, coordStart, numCoords, coordType, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="startSegment">
        /// To be added.
        /// </param>
        /// <param name="numSegments">
        /// To be added.
        /// </param>
        /// <param name="distance">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="tangentX">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="tangentY">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glPointAlongPathNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe bool PointAlongPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint startSegment, [Flow(FlowDirection.In)] uint numSegments, [Flow(FlowDirection.In)] float distance, [Count(Count = 1), Flow(FlowDirection.Out)] float* x, [Count(Count = 1), Flow(FlowDirection.Out)] float* y, [Count(Count = 1), Flow(FlowDirection.Out)] float* tangentX, [Count(Count = 1), Flow(FlowDirection.Out)] float* tangentY)
            => ImplPointAlongPath(path, startSegment, numSegments, distance, x, y, tangentX, tangentY);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="startSegment">
        /// To be added.
        /// </param>
        /// <param name="numSegments">
        /// To be added.
        /// </param>
        /// <param name="distance">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="tangentX">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="tangentY">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glPointAlongPathNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool PointAlongPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint startSegment, [Flow(FlowDirection.In)] uint numSegments, [Flow(FlowDirection.In)] float distance, [Count(Count = 1), Flow(FlowDirection.Out)] out float x, [Count(Count = 1), Flow(FlowDirection.Out)] out float y, [Count(Count = 1), Flow(FlowDirection.Out)] out float tangentX, [Count(Count = 1), Flow(FlowDirection.Out)] out float tangentY)
            => ImplPointAlongPath(path, startSegment, numSegments, distance, x, y, tangentX, tangentY);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="genMode">
        /// To be added.
        /// </param>
        /// <param name="components">
        /// To be added.
        /// </param>
        /// <param name="coeffs">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramPathFragmentInputGenNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramPathFragmentInputGen([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] NV genMode, [Flow(FlowDirection.In)] int components, [Flow(FlowDirection.In)] float* coeffs)
            => ImplProgramPathFragmentInputGen(program, location, genMode, components, coeffs);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="genMode">
        /// To be added.
        /// </param>
        /// <param name="components">
        /// To be added.
        /// </param>
        /// <param name="coeffs">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramPathFragmentInputGenNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramPathFragmentInputGen([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] NV genMode, [Flow(FlowDirection.In)] int components, [Flow(FlowDirection.In)] Span<float> coeffs)
            => ImplProgramPathFragmentInputGen(program, location, genMode, components, coeffs);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="fillMode">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glStencilFillPathNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void StencilFillPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask)
            => ImplStencilFillPath(path, fillMode, mask);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="pathNameType">
        /// To be added.
        /// </param>
        /// <param name="paths">
        /// To be added.
        /// This parameter's element count is computed from numPaths, pathNameType, and paths.
        /// </param>
        /// <param name="pathBase">
        /// To be added.
        /// </param>
        /// <param name="fillMode">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        /// <param name="transformType">
        /// To be added.
        /// </param>
        /// <param name="transformValues">
        /// To be added.
        /// This parameter's element count is computed from numPaths and transformType.
        /// </param>
        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void StencilFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues)
            => ImplStencilFillPathInstanced(numPaths, pathNameType, paths, pathBase, fillMode, mask, transformType, transformValues);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="pathNameType">
        /// To be added.
        /// </param>
        /// <param name="paths">
        /// To be added.
        /// This parameter's element count is computed from numPaths, pathNameType, and paths.
        /// </param>
        /// <param name="pathBase">
        /// To be added.
        /// </param>
        /// <param name="fillMode">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        /// <param name="transformType">
        /// To be added.
        /// </param>
        /// <param name="transformValues">
        /// To be added.
        /// This parameter's element count is computed from numPaths and transformType.
        /// </param>
        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void StencilFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] ref T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] ref float transformValues) where T0 : unmanaged
            => ImplStencilFillPathInstanced<T0>(numPaths, pathNameType, paths, pathBase, fillMode, mask, transformType, transformValues);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="reference">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glStencilStrokePathNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void StencilStrokePath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask)
            => ImplStencilStrokePath(path, reference, mask);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="pathNameType">
        /// To be added.
        /// </param>
        /// <param name="paths">
        /// To be added.
        /// This parameter's element count is computed from numPaths, pathNameType, and paths.
        /// </param>
        /// <param name="pathBase">
        /// To be added.
        /// </param>
        /// <param name="reference">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        /// <param name="transformType">
        /// To be added.
        /// </param>
        /// <param name="transformValues">
        /// To be added.
        /// This parameter's element count is computed from numPaths and transformType.
        /// </param>
        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void StencilStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues)
            => ImplStencilStrokePathInstanced(numPaths, pathNameType, paths, pathBase, reference, mask, transformType, transformValues);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="pathNameType">
        /// To be added.
        /// </param>
        /// <param name="paths">
        /// To be added.
        /// This parameter's element count is computed from numPaths, pathNameType, and paths.
        /// </param>
        /// <param name="pathBase">
        /// To be added.
        /// </param>
        /// <param name="reference">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        /// <param name="transformType">
        /// To be added.
        /// </param>
        /// <param name="transformValues">
        /// To be added.
        /// This parameter's element count is computed from numPaths and transformType.
        /// </param>
        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void StencilStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] ref T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] ref float transformValues) where T0 : unmanaged
            => ImplStencilStrokePathInstanced<T0>(numPaths, pathNameType, paths, pathBase, reference, mask, transformType, transformValues);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="fillMode">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        /// <param name="coverMode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glStencilThenCoverFillPathNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void StencilThenCoverFillPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV coverMode)
            => ImplStencilThenCoverFillPath(path, fillMode, mask, coverMode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="pathNameType">
        /// To be added.
        /// </param>
        /// <param name="paths">
        /// To be added.
        /// </param>
        /// <param name="pathBase">
        /// To be added.
        /// </param>
        /// <param name="fillMode">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        /// <param name="coverMode">
        /// To be added.
        /// </param>
        /// <param name="transformType">
        /// To be added.
        /// </param>
        /// <param name="transformValues">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void StencilThenCoverFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Flow(FlowDirection.In)] float* transformValues)
            => ImplStencilThenCoverFillPathInstanced(numPaths, pathNameType, paths, pathBase, fillMode, mask, coverMode, transformType, transformValues);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="pathNameType">
        /// To be added.
        /// </param>
        /// <param name="paths">
        /// To be added.
        /// </param>
        /// <param name="pathBase">
        /// To be added.
        /// </param>
        /// <param name="fillMode">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        /// <param name="coverMode">
        /// To be added.
        /// </param>
        /// <param name="transformType">
        /// To be added.
        /// </param>
        /// <param name="transformValues">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void StencilThenCoverFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Flow(FlowDirection.In)] Span<T0> paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Flow(FlowDirection.In)] Span<float> transformValues) where T0 : unmanaged
            => ImplStencilThenCoverFillPathInstanced<T0>(numPaths, pathNameType, paths, pathBase, fillMode, mask, coverMode, transformType, transformValues);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="reference">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        /// <param name="coverMode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void StencilThenCoverStrokePath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV coverMode)
            => ImplStencilThenCoverStrokePath(path, reference, mask, coverMode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="pathNameType">
        /// To be added.
        /// </param>
        /// <param name="paths">
        /// To be added.
        /// </param>
        /// <param name="pathBase">
        /// To be added.
        /// </param>
        /// <param name="reference">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        /// <param name="coverMode">
        /// To be added.
        /// </param>
        /// <param name="transformType">
        /// To be added.
        /// </param>
        /// <param name="transformValues">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void StencilThenCoverStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Flow(FlowDirection.In)] float* transformValues)
            => ImplStencilThenCoverStrokePathInstanced(numPaths, pathNameType, paths, pathBase, reference, mask, coverMode, transformType, transformValues);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="pathNameType">
        /// To be added.
        /// </param>
        /// <param name="paths">
        /// To be added.
        /// </param>
        /// <param name="pathBase">
        /// To be added.
        /// </param>
        /// <param name="reference">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        /// <param name="coverMode">
        /// To be added.
        /// </param>
        /// <param name="transformType">
        /// To be added.
        /// </param>
        /// <param name="transformValues">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void StencilThenCoverStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Flow(FlowDirection.In)] Span<T0> paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Flow(FlowDirection.In)] Span<float> transformValues) where T0 : unmanaged
            => ImplStencilThenCoverStrokePathInstanced<T0>(numPaths, pathNameType, paths, pathBase, reference, mask, coverMode, transformType, transformValues);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="resultPath">
        /// To be added.
        /// </param>
        /// <param name="srcPath">
        /// To be added.
        /// </param>
        /// <param name="transformType">
        /// To be added.
        /// </param>
        /// <param name="transformValues">
        /// To be added.
        /// This parameter's element count is computed from transformType.
        /// </param>
        [NativeApi(EntryPoint = "glTransformPathNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TransformPath([Flow(FlowDirection.In)] uint resultPath, [Flow(FlowDirection.In)] uint srcPath, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "transformType"), Flow(FlowDirection.In)] float* transformValues)
            => ImplTransformPath(resultPath, srcPath, transformType, transformValues);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="resultPath">
        /// To be added.
        /// </param>
        /// <param name="srcPath">
        /// To be added.
        /// </param>
        /// <param name="transformType">
        /// To be added.
        /// </param>
        /// <param name="transformValues">
        /// To be added.
        /// This parameter's element count is computed from transformType.
        /// </param>
        [NativeApi(EntryPoint = "glTransformPathNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TransformPath([Flow(FlowDirection.In)] uint resultPath, [Flow(FlowDirection.In)] uint srcPath, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "transformType"), Flow(FlowDirection.In)] ref float transformValues)
            => ImplTransformPath(resultPath, srcPath, transformType, transformValues);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="resultPath">
        /// To be added.
        /// </param>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="paths">
        /// To be added.
        /// This parameter's element count is taken from numPaths.
        /// </param>
        /// <param name="weights">
        /// To be added.
        /// This parameter's element count is taken from numPaths.
        /// </param>
        [NativeApi(EntryPoint = "glWeightPathsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void WeightPath([Flow(FlowDirection.In)] uint resultPath, [Flow(FlowDirection.In)] uint numPaths, [Count(Parameter = "numPaths"), Flow(FlowDirection.In)] uint* paths, [Count(Parameter = "numPaths"), Flow(FlowDirection.In)] float* weights)
            => ImplWeightPath(resultPath, numPaths, paths, weights);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="resultPath">
        /// To be added.
        /// </param>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="paths">
        /// To be added.
        /// This parameter's element count is taken from numPaths.
        /// </param>
        /// <param name="weights">
        /// To be added.
        /// This parameter's element count is taken from numPaths.
        /// </param>
        [NativeApi(EntryPoint = "glWeightPathsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WeightPath([Flow(FlowDirection.In)] uint resultPath, [Flow(FlowDirection.In)] uint numPaths, [Count(Parameter = "numPaths"), Flow(FlowDirection.In)] Span<uint> paths, [Count(Parameter = "numPaths"), Flow(FlowDirection.In)] Span<float> weights)
            => ImplWeightPath(resultPath, numPaths, paths, weights);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="coverMode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCoverFillPathNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CoverFillPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathCoverMode coverMode)
            => ImplCoverFillPath(path, coverMode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="pathNameType">
        /// To be added.
        /// </param>
        /// <param name="paths">
        /// To be added.
        /// This parameter's element count is computed from numPaths, pathNameType, and paths.
        /// </param>
        /// <param name="pathBase">
        /// To be added.
        /// </param>
        /// <param name="coverMode">
        /// To be added.
        /// </param>
        /// <param name="transformType">
        /// To be added.
        /// </param>
        /// <param name="transformValues">
        /// To be added.
        /// This parameter's element count is computed from numPaths and transformType.
        /// </param>
        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CoverFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues)
            => ImplCoverFillPathInstanced(numPaths, pathNameType, paths, pathBase, coverMode, transformType, transformValues);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="pathNameType">
        /// To be added.
        /// </param>
        /// <param name="paths">
        /// To be added.
        /// This parameter's element count is computed from numPaths, pathNameType, and paths.
        /// </param>
        /// <param name="pathBase">
        /// To be added.
        /// </param>
        /// <param name="coverMode">
        /// To be added.
        /// </param>
        /// <param name="transformType">
        /// To be added.
        /// </param>
        /// <param name="transformValues">
        /// To be added.
        /// This parameter's element count is computed from numPaths and transformType.
        /// </param>
        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CoverFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] ref T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] ref float transformValues) where T0 : unmanaged
            => ImplCoverFillPathInstanced<T0>(numPaths, pathNameType, paths, pathBase, coverMode, transformType, transformValues);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="coverMode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCoverStrokePathNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CoverStrokePath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathCoverMode coverMode)
            => ImplCoverStrokePath(path, coverMode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="pathNameType">
        /// To be added.
        /// </param>
        /// <param name="paths">
        /// To be added.
        /// This parameter's element count is computed from numPaths, pathNameType, and paths.
        /// </param>
        /// <param name="pathBase">
        /// To be added.
        /// </param>
        /// <param name="coverMode">
        /// To be added.
        /// </param>
        /// <param name="transformType">
        /// To be added.
        /// </param>
        /// <param name="transformValues">
        /// To be added.
        /// This parameter's element count is computed from numPaths and transformType.
        /// </param>
        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CoverStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues)
            => ImplCoverStrokePathInstanced(numPaths, pathNameType, paths, pathBase, coverMode, transformType, transformValues);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="pathNameType">
        /// To be added.
        /// </param>
        /// <param name="paths">
        /// To be added.
        /// This parameter's element count is computed from numPaths, pathNameType, and paths.
        /// </param>
        /// <param name="pathBase">
        /// To be added.
        /// </param>
        /// <param name="coverMode">
        /// To be added.
        /// </param>
        /// <param name="transformType">
        /// To be added.
        /// </param>
        /// <param name="transformValues">
        /// To be added.
        /// This parameter's element count is computed from numPaths and transformType.
        /// </param>
        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CoverStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] ref T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] ref float transformValues) where T0 : unmanaged
            => ImplCoverStrokePathInstanced<T0>(numPaths, pathNameType, paths, pathBase, coverMode, transformType, transformValues);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="commands">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetPathCommandsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPathCommands([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.Out)] string commands)
            => ImplGetPathCommands(path, commands);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="metricQueryMask">
        /// To be added.
        /// </param>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="pathNameType">
        /// To be added.
        /// </param>
        /// <param name="paths">
        /// To be added.
        /// This parameter's element count is computed from numPaths, pathNameType, and paths.
        /// </param>
        /// <param name="pathBase">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="metrics">
        /// To be added.
        /// This parameter's element count is computed from metricQueryMask, numPaths, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glGetPathMetricsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPathMetric([Flow(FlowDirection.In)] uint metricQueryMask, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] float* metrics)
            => ImplGetPathMetric(metricQueryMask, numPaths, pathNameType, paths, pathBase, stride, metrics);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="metricQueryMask">
        /// To be added.
        /// </param>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="pathNameType">
        /// To be added.
        /// </param>
        /// <param name="paths">
        /// To be added.
        /// This parameter's element count is computed from numPaths, pathNameType, and paths.
        /// </param>
        /// <param name="pathBase">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="metrics">
        /// To be added.
        /// This parameter's element count is computed from metricQueryMask, numPaths, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glGetPathMetricsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPathMetric<T0>([Flow(FlowDirection.In)] uint metricQueryMask, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] ref T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] out float metrics) where T0 : unmanaged
            => ImplGetPathMetric<T0>(metricQueryMask, numPaths, pathNameType, paths, pathBase, stride, metrics);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetPathParameterivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathParameter pname, [Count(Count = 4), Flow(FlowDirection.Out)] int* value)
            => ImplGetPathParameter(path, pname, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetPathParameterivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathParameter pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> value)
            => ImplGetPathParameter(path, pname, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetPathParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathParameter pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* value)
            => ImplGetPathParameter(path, pname, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetPathParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathParameter pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> value)
            => ImplGetPathParameter(path, pname, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pathListMode">
        /// To be added.
        /// </param>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="pathNameType">
        /// To be added.
        /// </param>
        /// <param name="paths">
        /// To be added.
        /// This parameter's element count is computed from numPaths, pathNameType, and paths.
        /// </param>
        /// <param name="pathBase">
        /// To be added.
        /// </param>
        /// <param name="advanceScale">
        /// To be added.
        /// </param>
        /// <param name="kerningScale">
        /// To be added.
        /// </param>
        /// <param name="transformType">
        /// To be added.
        /// </param>
        /// <param name="returnedSpacing">
        /// To be added.
        /// This parameter's element count is computed from pathListMode and numPaths.
        /// </param>
        [NativeApi(EntryPoint = "glGetPathSpacingNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPathSpacing([Flow(FlowDirection.In)] PathListMode pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] float* returnedSpacing)
            => ImplGetPathSpacing(pathListMode, numPaths, pathNameType, paths, pathBase, advanceScale, kerningScale, transformType, returnedSpacing);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pathListMode">
        /// To be added.
        /// </param>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="pathNameType">
        /// To be added.
        /// </param>
        /// <param name="paths">
        /// To be added.
        /// This parameter's element count is computed from numPaths, pathNameType, and paths.
        /// </param>
        /// <param name="pathBase">
        /// To be added.
        /// </param>
        /// <param name="advanceScale">
        /// To be added.
        /// </param>
        /// <param name="kerningScale">
        /// To be added.
        /// </param>
        /// <param name="transformType">
        /// To be added.
        /// </param>
        /// <param name="returnedSpacing">
        /// To be added.
        /// This parameter's element count is computed from pathListMode and numPaths.
        /// </param>
        [NativeApi(EntryPoint = "glGetPathSpacingNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPathSpacing<T0>([Flow(FlowDirection.In)] PathListMode pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] ref T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] out float returnedSpacing) where T0 : unmanaged
            => ImplGetPathSpacing<T0>(pathListMode, numPaths, pathNameType, paths, pathBase, advanceScale, kerningScale, transformType, returnedSpacing);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="propCount">
        /// To be added.
        /// </param>
        /// <param name="props">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramResourcefvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] NV* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetProgramResource(program, programInterface, index, propCount, props, count, length, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="propCount">
        /// To be added.
        /// </param>
        /// <param name="props">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramResourcefvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] Span<NV> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<float> @params)
            => ImplGetProgramResource(program, programInterface, index, propCount, props, count, length, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="left">
        /// To be added.
        /// </param>
        /// <param name="right">
        /// To be added.
        /// </param>
        /// <param name="bottom">
        /// To be added.
        /// </param>
        /// <param name="top">
        /// To be added.
        /// </param>
        /// <param name="zNear">
        /// To be added.
        /// </param>
        /// <param name="zFar">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixFrustumEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixFrustum([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] double left, [Flow(FlowDirection.In)] double right, [Flow(FlowDirection.In)] double bottom, [Flow(FlowDirection.In)] double top, [Flow(FlowDirection.In)] double zNear, [Flow(FlowDirection.In)] double zFar)
            => ImplMatrixFrustum(mode, left, right, bottom, top, zNear, zFar);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoadfEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixLoad([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m)
            => ImplMatrixLoad(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoadfEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixLoad([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m)
            => ImplMatrixLoad(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoaddEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixLoad([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m)
            => ImplMatrixLoad(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoaddEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixLoad([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m)
            => ImplMatrixLoad(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoadIdentityEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixLoadIdentity([Flow(FlowDirection.In)] MatrixMode mode)
            => ImplMatrixLoadIdentity(mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoadTransposefEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixLoadTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m)
            => ImplMatrixLoadTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoadTransposefEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixLoadTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m)
            => ImplMatrixLoadTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoadTransposedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixLoadTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m)
            => ImplMatrixLoadTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixLoadTransposedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixLoadTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m)
            => ImplMatrixLoadTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultfEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixMult([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m)
            => ImplMatrixMult(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultfEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixMult([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m)
            => ImplMatrixMult(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultdEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixMult([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m)
            => ImplMatrixMult(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultdEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixMult([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m)
            => ImplMatrixMult(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultTransposefEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixMultTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m)
            => ImplMatrixMultTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultTransposefEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixMultTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<float> m)
            => ImplMatrixMultTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultTransposedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MatrixMultTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m)
            => ImplMatrixMultTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixMultTransposedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixMultTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] Span<double> m)
            => ImplMatrixMultTranspose(mode, m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="left">
        /// To be added.
        /// </param>
        /// <param name="right">
        /// To be added.
        /// </param>
        /// <param name="bottom">
        /// To be added.
        /// </param>
        /// <param name="top">
        /// To be added.
        /// </param>
        /// <param name="zNear">
        /// To be added.
        /// </param>
        /// <param name="zFar">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixOrthoEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixOrtho([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] double left, [Flow(FlowDirection.In)] double right, [Flow(FlowDirection.In)] double bottom, [Flow(FlowDirection.In)] double top, [Flow(FlowDirection.In)] double zNear, [Flow(FlowDirection.In)] double zFar)
            => ImplMatrixOrtho(mode, left, right, bottom, top, zNear, zFar);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixPopEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixPop([Flow(FlowDirection.In)] MatrixMode mode)
            => ImplMatrixPop(mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMatrixPushEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixPush([Flow(FlowDirection.In)] MatrixMode mode)
            => ImplMatrixPush(mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
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
        [NativeApi(EntryPoint = "glMatrixRotatefEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixRotate([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] float angle, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z)
            => ImplMatrixRotate(mode, angle, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
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
        [NativeApi(EntryPoint = "glMatrixRotatedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixRotate([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] double angle, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z)
            => ImplMatrixRotate(mode, angle, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
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
        [NativeApi(EntryPoint = "glMatrixScalefEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixScale([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z)
            => ImplMatrixScale(mode, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
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
        [NativeApi(EntryPoint = "glMatrixScaledEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixScale([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z)
            => ImplMatrixScale(mode, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
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
        [NativeApi(EntryPoint = "glMatrixTranslatefEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixTranslate([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z)
            => ImplMatrixTranslate(mode, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
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
        [NativeApi(EntryPoint = "glMatrixTranslatedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MatrixTranslate([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z)
            => ImplMatrixTranslate(mode, x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="numCommands">
        /// To be added.
        /// </param>
        /// <param name="commands">
        /// To be added.
        /// </param>
        /// <param name="numCoords">
        /// To be added.
        /// </param>
        /// <param name="coordType">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter's element count is computed from numCoords and coordType.
        /// </param>
        [NativeApi(EntryPoint = "glPathCommandsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PathCommands([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCommands, [Flow(FlowDirection.In)] string commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords)
            => ImplPathCommands(path, numCommands, commands, numCoords, coordType, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="numCommands">
        /// To be added.
        /// </param>
        /// <param name="commands">
        /// To be added.
        /// </param>
        /// <param name="numCoords">
        /// To be added.
        /// </param>
        /// <param name="coordType">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter's element count is computed from numCoords and coordType.
        /// </param>
        [NativeApi(EntryPoint = "glPathCommandsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PathCommands<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCommands, [Flow(FlowDirection.In)] string commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] ref T0 coords) where T0 : unmanaged
            => ImplPathCommands<T0>(path, numCommands, commands, numCoords, coordType, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="numCoords">
        /// To be added.
        /// </param>
        /// <param name="coordType">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter's element count is computed from numCoords and coordType.
        /// </param>
        [NativeApi(EntryPoint = "glPathCoordsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PathCoords([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords)
            => ImplPathCoords(path, numCoords, coordType, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="numCoords">
        /// To be added.
        /// </param>
        /// <param name="coordType">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter's element count is computed from numCoords and coordType.
        /// </param>
        [NativeApi(EntryPoint = "glPathCoordsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PathCoords<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] ref T0 coords) where T0 : unmanaged
            => ImplPathCoords<T0>(path, numCoords, coordType, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="func">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPathCoverDepthFuncNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PathCoverDepthFunc([Flow(FlowDirection.In)] DepthFunction func)
            => ImplPathCoverDepthFunc(func);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="firstPathName">
        /// To be added.
        /// </param>
        /// <param name="fontTarget">
        /// To be added.
        /// </param>
        /// <param name="fontName">
        /// To be added.
        /// This parameter's element count is computed from fontTarget and fontName.
        /// </param>
        /// <param name="fontStyle">
        /// To be added.
        /// </param>
        /// <param name="numGlyphs">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="charcodes">
        /// To be added.
        /// This parameter's element count is computed from numGlyphs, type, and charcodes.
        /// </param>
        /// <param name="handleMissingGlyphs">
        /// To be added.
        /// </param>
        /// <param name="pathParameterTemplate">
        /// To be added.
        /// </param>
        /// <param name="emScale">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPathGlyphsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PathGlyph([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale)
            => ImplPathGlyph(firstPathName, fontTarget, fontName, fontStyle, numGlyphs, type, charcodes, handleMissingGlyphs, pathParameterTemplate, emScale);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="firstPathName">
        /// To be added.
        /// </param>
        /// <param name="fontTarget">
        /// To be added.
        /// </param>
        /// <param name="fontName">
        /// To be added.
        /// This parameter's element count is computed from fontTarget and fontName.
        /// </param>
        /// <param name="fontStyle">
        /// To be added.
        /// </param>
        /// <param name="numGlyphs">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="charcodes">
        /// To be added.
        /// This parameter's element count is computed from numGlyphs, type, and charcodes.
        /// </param>
        /// <param name="handleMissingGlyphs">
        /// To be added.
        /// </param>
        /// <param name="pathParameterTemplate">
        /// To be added.
        /// </param>
        /// <param name="emScale">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPathGlyphsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PathGlyph<T0, T1>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] ref T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] ref T1 charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged
            => ImplPathGlyph<T0, T1>(firstPathName, fontTarget, fontName, fontStyle, numGlyphs, type, charcodes, handleMissingGlyphs, pathParameterTemplate, emScale);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="firstPathName">
        /// To be added.
        /// </param>
        /// <param name="fontTarget">
        /// To be added.
        /// </param>
        /// <param name="fontName">
        /// To be added.
        /// This parameter's element count is computed from fontTarget and fontName.
        /// </param>
        /// <param name="fontStyle">
        /// To be added.
        /// </param>
        /// <param name="firstGlyph">
        /// To be added.
        /// </param>
        /// <param name="numGlyphs">
        /// To be added.
        /// </param>
        /// <param name="handleMissingGlyphs">
        /// To be added.
        /// </param>
        /// <param name="pathParameterTemplate">
        /// To be added.
        /// </param>
        /// <param name="emScale">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPathGlyphRangeNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PathGlyphRange([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint firstGlyph, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale)
            => ImplPathGlyphRange(firstPathName, fontTarget, fontName, fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="firstPathName">
        /// To be added.
        /// </param>
        /// <param name="fontTarget">
        /// To be added.
        /// </param>
        /// <param name="fontName">
        /// To be added.
        /// This parameter's element count is computed from fontTarget and fontName.
        /// </param>
        /// <param name="fontStyle">
        /// To be added.
        /// </param>
        /// <param name="firstGlyph">
        /// To be added.
        /// </param>
        /// <param name="numGlyphs">
        /// To be added.
        /// </param>
        /// <param name="handleMissingGlyphs">
        /// To be added.
        /// </param>
        /// <param name="pathParameterTemplate">
        /// To be added.
        /// </param>
        /// <param name="emScale">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPathGlyphRangeNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PathGlyphRange<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] ref T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint firstGlyph, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged
            => ImplPathGlyphRange<T0>(firstPathName, fontTarget, fontName, fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glPathParameterivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* value)
            => ImplPathParameter(path, pname, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glPathParameterivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int value)
            => ImplPathParameter(path, pname, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPathParameteriNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathParameter pname, [Flow(FlowDirection.In)] int value)
            => ImplPathParameter(path, pname, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glPathParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* value)
            => ImplPathParameter(path, pname, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glPathParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float value)
            => ImplPathParameter(path, pname, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPathParameterfNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathParameter pname, [Flow(FlowDirection.In)] float value)
            => ImplPathParameter(path, pname, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="func">
        /// To be added.
        /// </param>
        /// <param name="@ref">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPathStencilFuncNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PathStencilFunc([Flow(FlowDirection.In)] StencilFunction func, [Flow(FlowDirection.In)] int @ref, [Flow(FlowDirection.In)] uint mask)
            => ImplPathStencilFunc(func, @ref, mask);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="pathString">
        /// To be added.
        /// This parameter's element count is taken from length.
        /// </param>
        [NativeApi(EntryPoint = "glPathStringNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PathString([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathStringFormat format, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* pathString)
            => ImplPathString(path, format, length, pathString);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="pathString">
        /// To be added.
        /// This parameter's element count is taken from length.
        /// </param>
        [NativeApi(EntryPoint = "glPathStringNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PathString<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathStringFormat format, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] Span<T0> pathString) where T0 : unmanaged
            => ImplPathString<T0>(path, format, length, pathString);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="commandStart">
        /// To be added.
        /// </param>
        /// <param name="commandsToDelete">
        /// To be added.
        /// </param>
        /// <param name="numCommands">
        /// To be added.
        /// </param>
        /// <param name="commands">
        /// To be added.
        /// </param>
        /// <param name="numCoords">
        /// To be added.
        /// </param>
        /// <param name="coordType">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter's element count is computed from numCoords and coordType.
        /// </param>
        [NativeApi(EntryPoint = "glPathSubCommandsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PathSubCommands([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint commandStart, [Flow(FlowDirection.In)] uint commandsToDelete, [Flow(FlowDirection.In)] uint numCommands, [Flow(FlowDirection.In)] string commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords)
            => ImplPathSubCommands(path, commandStart, commandsToDelete, numCommands, commands, numCoords, coordType, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="commandStart">
        /// To be added.
        /// </param>
        /// <param name="commandsToDelete">
        /// To be added.
        /// </param>
        /// <param name="numCommands">
        /// To be added.
        /// </param>
        /// <param name="commands">
        /// To be added.
        /// </param>
        /// <param name="numCoords">
        /// To be added.
        /// </param>
        /// <param name="coordType">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter's element count is computed from numCoords and coordType.
        /// </param>
        [NativeApi(EntryPoint = "glPathSubCommandsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PathSubCommands<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint commandStart, [Flow(FlowDirection.In)] uint commandsToDelete, [Flow(FlowDirection.In)] uint numCommands, [Flow(FlowDirection.In)] string commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] ref T0 coords) where T0 : unmanaged
            => ImplPathSubCommands<T0>(path, commandStart, commandsToDelete, numCommands, commands, numCoords, coordType, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="coordStart">
        /// To be added.
        /// </param>
        /// <param name="numCoords">
        /// To be added.
        /// </param>
        /// <param name="coordType">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter's element count is computed from numCoords and coordType.
        /// </param>
        [NativeApi(EntryPoint = "glPathSubCoordsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void PathSubCoords([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint coordStart, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords)
            => ImplPathSubCoords(path, coordStart, numCoords, coordType, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="coordStart">
        /// To be added.
        /// </param>
        /// <param name="numCoords">
        /// To be added.
        /// </param>
        /// <param name="coordType">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter's element count is computed from numCoords and coordType.
        /// </param>
        [NativeApi(EntryPoint = "glPathSubCoordsNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PathSubCoords<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint coordStart, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] ref T0 coords) where T0 : unmanaged
            => ImplPathSubCoords<T0>(path, coordStart, numCoords, coordType, coords);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="fillMode">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glStencilFillPathNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void StencilFillPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathFillMode fillMode, [Flow(FlowDirection.In)] uint mask)
            => ImplStencilFillPath(path, fillMode, mask);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="pathNameType">
        /// To be added.
        /// </param>
        /// <param name="paths">
        /// To be added.
        /// This parameter's element count is computed from numPaths, pathNameType, and paths.
        /// </param>
        /// <param name="pathBase">
        /// To be added.
        /// </param>
        /// <param name="fillMode">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        /// <param name="transformType">
        /// To be added.
        /// </param>
        /// <param name="transformValues">
        /// To be added.
        /// This parameter's element count is computed from numPaths and transformType.
        /// </param>
        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void StencilFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathFillMode fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues)
            => ImplStencilFillPathInstanced(numPaths, pathNameType, paths, pathBase, fillMode, mask, transformType, transformValues);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="pathNameType">
        /// To be added.
        /// </param>
        /// <param name="paths">
        /// To be added.
        /// This parameter's element count is computed from numPaths, pathNameType, and paths.
        /// </param>
        /// <param name="pathBase">
        /// To be added.
        /// </param>
        /// <param name="fillMode">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        /// <param name="transformType">
        /// To be added.
        /// </param>
        /// <param name="transformValues">
        /// To be added.
        /// This parameter's element count is computed from numPaths and transformType.
        /// </param>
        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void StencilFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] ref T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathFillMode fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] ref float transformValues) where T0 : unmanaged
            => ImplStencilFillPathInstanced<T0>(numPaths, pathNameType, paths, pathBase, fillMode, mask, transformType, transformValues);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="pathNameType">
        /// To be added.
        /// </param>
        /// <param name="paths">
        /// To be added.
        /// This parameter's element count is computed from numPaths, pathNameType, and paths.
        /// </param>
        /// <param name="pathBase">
        /// To be added.
        /// </param>
        /// <param name="reference">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        /// <param name="transformType">
        /// To be added.
        /// </param>
        /// <param name="transformValues">
        /// To be added.
        /// This parameter's element count is computed from numPaths and transformType.
        /// </param>
        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void StencilStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues)
            => ImplStencilStrokePathInstanced(numPaths, pathNameType, paths, pathBase, reference, mask, transformType, transformValues);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="numPaths">
        /// To be added.
        /// </param>
        /// <param name="pathNameType">
        /// To be added.
        /// </param>
        /// <param name="paths">
        /// To be added.
        /// This parameter's element count is computed from numPaths, pathNameType, and paths.
        /// </param>
        /// <param name="pathBase">
        /// To be added.
        /// </param>
        /// <param name="reference">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        /// <param name="transformType">
        /// To be added.
        /// </param>
        /// <param name="transformValues">
        /// To be added.
        /// This parameter's element count is computed from numPaths and transformType.
        /// </param>
        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void StencilStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] ref T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] ref float transformValues) where T0 : unmanaged
            => ImplStencilStrokePathInstanced<T0>(numPaths, pathNameType, paths, pathBase, reference, mask, transformType, transformValues);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="resultPath">
        /// To be added.
        /// </param>
        /// <param name="srcPath">
        /// To be added.
        /// </param>
        /// <param name="transformType">
        /// To be added.
        /// </param>
        /// <param name="transformValues">
        /// To be added.
        /// This parameter's element count is computed from transformType.
        /// </param>
        [NativeApi(EntryPoint = "glTransformPathNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TransformPath([Flow(FlowDirection.In)] uint resultPath, [Flow(FlowDirection.In)] uint srcPath, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "transformType"), Flow(FlowDirection.In)] float* transformValues)
            => ImplTransformPath(resultPath, srcPath, transformType, transformValues);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="resultPath">
        /// To be added.
        /// </param>
        /// <param name="srcPath">
        /// To be added.
        /// </param>
        /// <param name="transformType">
        /// To be added.
        /// </param>
        /// <param name="transformValues">
        /// To be added.
        /// This parameter's element count is computed from transformType.
        /// </param>
        [NativeApi(EntryPoint = "glTransformPathNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TransformPath([Flow(FlowDirection.In)] uint resultPath, [Flow(FlowDirection.In)] uint srcPath, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "transformType"), Flow(FlowDirection.In)] ref float transformValues)
            => ImplTransformPath(resultPath, srcPath, transformType, transformValues);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="commands">
        /// To be added.
        /// This parameter's element count is computed from path.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe byte GetPathCommand()
        {
            const uint path = 1;
            // ReturnTypeOverloader
            byte ret = default;
            GetPathCommands(path, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="coords">
        /// To be added.
        /// This parameter's element count is computed from path.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe float GetPathCoord()
        {
            const uint path = 1;
            // ReturnTypeOverloader
            float ret = default;
            GetPathCoords(path, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="path">
        /// To be added.
        /// </param>
        /// <param name="dashArray">
        /// To be added.
        /// This parameter's element count is computed from path.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe float GetPathDashArray()
        {
            const uint path = 1;
            // ReturnTypeOverloader
            float ret = default;
            GetPathDashArray(path, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="firstPathName">
        /// To be added.
        /// </param>
        /// <param name="fontTarget">
        /// To be added.
        /// </param>
        /// <param name="fontSize">
        /// To be added.
        /// </param>
        /// <param name="fontData">
        /// To be added.
        /// </param>
        /// <param name="faceIndex">
        /// To be added.
        /// </param>
        /// <param name="firstGlyphIndex">
        /// To be added.
        /// </param>
        /// <param name="numGlyphs">
        /// To be added.
        /// </param>
        /// <param name="pathParameterTemplate">
        /// To be added.
        /// </param>
        /// <param name="emScale">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe NV PathMemoryGlyphIndexArray([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Flow(FlowDirection.In)] uint fontSize, [Flow(FlowDirection.In)] void* fontData, [Flow(FlowDirection.In)] uint faceIndex, [Flow(FlowDirection.In)] uint firstGlyphIndex, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale)
        {
            // IntPtrOverloader
            return PathMemoryGlyphIndexArray(firstPathName, fontTarget, new UIntPtr(fontSize), fontData, faceIndex, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="firstPathName">
        /// To be added.
        /// </param>
        /// <param name="fontTarget">
        /// To be added.
        /// </param>
        /// <param name="fontSize">
        /// To be added.
        /// </param>
        /// <param name="fontData">
        /// To be added.
        /// </param>
        /// <param name="faceIndex">
        /// To be added.
        /// </param>
        /// <param name="firstGlyphIndex">
        /// To be added.
        /// </param>
        /// <param name="numGlyphs">
        /// To be added.
        /// </param>
        /// <param name="pathParameterTemplate">
        /// To be added.
        /// </param>
        /// <param name="emScale">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe NV PathMemoryGlyphIndexArray<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Flow(FlowDirection.In)] uint fontSize, [Flow(FlowDirection.In)] Span<T0> fontData, [Flow(FlowDirection.In)] uint faceIndex, [Flow(FlowDirection.In)] uint firstGlyphIndex, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged
        {
            // IntPtrOverloader
            return PathMemoryGlyphIndexArray(firstPathName, fontTarget, new UIntPtr(fontSize), fontData, faceIndex, firstGlyphIndex, numGlyphs, pathParameterTemplate, emScale);
        }

        public NVPathRendering(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

