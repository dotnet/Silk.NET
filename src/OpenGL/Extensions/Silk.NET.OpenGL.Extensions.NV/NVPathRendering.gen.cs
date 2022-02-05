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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_path_rendering")]
    public unsafe partial class NVPathRendering : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_path_rendering";
        [NativeApi(EntryPoint = "glCopyPathNV", Convention = CallingConvention.Winapi)]
        public partial void CopyPath([Flow(FlowDirection.In)] uint resultPath, [Flow(FlowDirection.In)] uint srcPath);

        [NativeApi(EntryPoint = "glCoverFillPathNV", Convention = CallingConvention.Winapi)]
        public partial void CoverFillPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV coverMode);

        [NativeApi(EntryPoint = "glCoverFillPathNV", Convention = CallingConvention.Winapi)]
        public partial void CoverFillPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathCoverMode coverMode);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathNV", Convention = CallingConvention.Winapi)]
        public partial void CoverStrokePath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV coverMode);

        [NativeApi(EntryPoint = "glCoverStrokePathNV", Convention = CallingConvention.Winapi)]
        public partial void CoverStrokePath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathCoverMode coverMode);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathCoverMode coverMode, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDeletePathsNV", Convention = CallingConvention.Winapi)]
        public partial void DeletePath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint range);

        [NativeApi(EntryPoint = "glGenPathsNV", Convention = CallingConvention.Winapi)]
        public partial uint GenPath([Flow(FlowDirection.In)] uint range);

        [NativeApi(EntryPoint = "glGetPathCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathCommands([Flow(FlowDirection.In)] uint path, [Count(Computed = "path"), Flow(FlowDirection.Out)] byte* commands);

        [NativeApi(EntryPoint = "glGetPathCommandsNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathCommands([Flow(FlowDirection.In)] uint path, [Count(Computed = "path"), Flow(FlowDirection.Out)] out byte commands);

        [NativeApi(EntryPoint = "glGetPathCommandsNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathCommands([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string commands);

        [NativeApi(EntryPoint = "glGetPathCoordsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathCoords([Flow(FlowDirection.In)] uint path, [Count(Computed = "path"), Flow(FlowDirection.Out)] float* coords);

        [NativeApi(EntryPoint = "glGetPathCoordsNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathCoords([Flow(FlowDirection.In)] uint path, [Count(Computed = "path"), Flow(FlowDirection.Out)] out float coords);

        [NativeApi(EntryPoint = "glGetPathDashArrayNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathDashArray([Flow(FlowDirection.In)] uint path, [Count(Computed = "path"), Flow(FlowDirection.Out)] float* dashArray);

        [NativeApi(EntryPoint = "glGetPathDashArrayNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathDashArray([Flow(FlowDirection.In)] uint path, [Count(Computed = "path"), Flow(FlowDirection.Out)] out float dashArray);

        [NativeApi(EntryPoint = "glGetPathLengthNV", Convention = CallingConvention.Winapi)]
        public partial float GetPathLength([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint startSegment, [Flow(FlowDirection.In)] uint numSegments);

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathMetric([Flow(FlowDirection.In)] uint metricQueryMask, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] float* metrics);

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathMetric([Flow(FlowDirection.In)] uint metricQueryMask, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] out float metrics);

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathMetric<T0>([Flow(FlowDirection.In)] uint metricQueryMask, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] float* metrics) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathMetric<T0>([Flow(FlowDirection.In)] uint metricQueryMask, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] out float metrics) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathMetric([Flow(FlowDirection.In)] uint metricQueryMask, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] float* metrics);

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathMetric([Flow(FlowDirection.In)] uint metricQueryMask, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] out float metrics);

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathMetric<T0>([Flow(FlowDirection.In)] uint metricQueryMask, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] float* metrics) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathMetric<T0>([Flow(FlowDirection.In)] uint metricQueryMask, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] out float metrics) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathMetric([Flow(FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] float* metrics);

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathMetric([Flow(FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] out float metrics);

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathMetric<T0>([Flow(FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] float* metrics) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathMetric<T0>([Flow(FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] out float metrics) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathMetric([Flow(FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] float* metrics);

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathMetric([Flow(FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] out float metrics);

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathMetric<T0>([Flow(FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] float* metrics) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathMetric<T0>([Flow(FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] out float metrics) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathMetricRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathMetricRange([Flow(FlowDirection.In)] uint metricQueryMask, [Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] float* metrics);

        [NativeApi(EntryPoint = "glGetPathMetricRangeNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathMetricRange([Flow(FlowDirection.In)] uint metricQueryMask, [Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] out float metrics);

        [NativeApi(EntryPoint = "glGetPathMetricRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathMetricRange([Flow(FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] float* metrics);

        [NativeApi(EntryPoint = "glGetPathMetricRangeNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathMetricRange([Flow(FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(FlowDirection.Out)] out float metrics);

        [NativeApi(EntryPoint = "glGetPathParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "glGetPathParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] out int value);

        [NativeApi(EntryPoint = "glGetPathParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathParameter pname, [Count(Count = 4), Flow(FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "glGetPathParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathParameter pname, [Count(Count = 4), Flow(FlowDirection.Out)] out int value);

        [NativeApi(EntryPoint = "glGetPathParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* value);

        [NativeApi(EntryPoint = "glGetPathParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV pname, [Count(Count = 4), Flow(FlowDirection.Out)] out float value);

        [NativeApi(EntryPoint = "glGetPathParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathParameter pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* value);

        [NativeApi(EntryPoint = "glGetPathParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathParameter pname, [Count(Count = 4), Flow(FlowDirection.Out)] out float value);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(FlowDirection.In)] NV pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] float* returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(FlowDirection.In)] NV pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] out float returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing<T0>([Flow(FlowDirection.In)] NV pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] float* returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathSpacing<T0>([Flow(FlowDirection.In)] NV pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] out float returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(FlowDirection.In)] NV pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] float* returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(FlowDirection.In)] NV pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] out float returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing<T0>([Flow(FlowDirection.In)] NV pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] float* returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathSpacing<T0>([Flow(FlowDirection.In)] NV pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] out float returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(FlowDirection.In)] NV pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] float* returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(FlowDirection.In)] NV pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] out float returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing<T0>([Flow(FlowDirection.In)] NV pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] float* returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathSpacing<T0>([Flow(FlowDirection.In)] NV pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] out float returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(FlowDirection.In)] NV pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] float* returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(FlowDirection.In)] NV pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] out float returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing<T0>([Flow(FlowDirection.In)] NV pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] float* returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathSpacing<T0>([Flow(FlowDirection.In)] NV pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] out float returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(FlowDirection.In)] PathListMode pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] float* returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(FlowDirection.In)] PathListMode pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] out float returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing<T0>([Flow(FlowDirection.In)] PathListMode pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] float* returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathSpacing<T0>([Flow(FlowDirection.In)] PathListMode pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] out float returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(FlowDirection.In)] PathListMode pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] float* returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(FlowDirection.In)] PathListMode pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] out float returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing<T0>([Flow(FlowDirection.In)] PathListMode pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] float* returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathSpacing<T0>([Flow(FlowDirection.In)] PathListMode pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] out float returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(FlowDirection.In)] PathListMode pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] float* returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(FlowDirection.In)] PathListMode pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] out float returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing<T0>([Flow(FlowDirection.In)] PathListMode pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] float* returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathSpacing<T0>([Flow(FlowDirection.In)] PathListMode pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] out float returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(FlowDirection.In)] PathListMode pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] float* returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(FlowDirection.In)] PathListMode pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] out float returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing<T0>([Flow(FlowDirection.In)] PathListMode pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] float* returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathSpacing<T0>([Flow(FlowDirection.In)] PathListMode pathListMode, [Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] float advanceScale, [Flow(FlowDirection.In)] float kerningScale, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(FlowDirection.Out)] out float returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] NV programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] NV* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] NV programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] NV* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] NV programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] NV* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] NV programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] NV* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] NV programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] in NV props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] NV programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] in NV props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] NV programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] in NV props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] NV programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] in NV props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] NV* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] NV* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] NV* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] NV* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] in NV props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] in NV props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] in NV props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] in NV props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glInterpolatePathsNV", Convention = CallingConvention.Winapi)]
        public partial void InterpolatePath([Flow(FlowDirection.In)] uint resultPath, [Flow(FlowDirection.In)] uint pathA, [Flow(FlowDirection.In)] uint pathB, [Flow(FlowDirection.In)] float weight);

        [NativeApi(EntryPoint = "glIsPathNV", Convention = CallingConvention.Winapi)]
        public partial bool IsPath([Flow(FlowDirection.In)] uint path);

        [NativeApi(EntryPoint = "glIsPointInFillPathNV", Convention = CallingConvention.Winapi)]
        public partial bool IsPointInFillPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y);

        [NativeApi(EntryPoint = "glIsPointInStrokePathNV", Convention = CallingConvention.Winapi)]
        public partial bool IsPointInStrokePath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y);

        [NativeApi(EntryPoint = "glMatrixFrustumEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixFrustum([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] double left, [Flow(FlowDirection.In)] double right, [Flow(FlowDirection.In)] double bottom, [Flow(FlowDirection.In)] double top, [Flow(FlowDirection.In)] double zNear, [Flow(FlowDirection.In)] double zFar);

        [NativeApi(EntryPoint = "glMatrixFrustumEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixFrustum([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] double left, [Flow(FlowDirection.In)] double right, [Flow(FlowDirection.In)] double bottom, [Flow(FlowDirection.In)] double top, [Flow(FlowDirection.In)] double zNear, [Flow(FlowDirection.In)] double zFar);

        [NativeApi(EntryPoint = "glMatrixLoadfEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoad([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixLoadfEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoad([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] in float m);

        [NativeApi(EntryPoint = "glMatrixLoadfEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoad([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixLoadfEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoad([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] in float m);

        [NativeApi(EntryPoint = "glMatrixLoaddEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoad([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixLoaddEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoad([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] in double m);

        [NativeApi(EntryPoint = "glMatrixLoaddEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoad([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixLoaddEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoad([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] in double m);

        [NativeApi(EntryPoint = "glMatrixLoad3x2fNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoad3x2([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixLoad3x2fNV", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoad3x2([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] in float m);

        [NativeApi(EntryPoint = "glMatrixLoad3x3fNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoad3x3([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixLoad3x3fNV", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoad3x3([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] in float m);

        [NativeApi(EntryPoint = "glMatrixLoadIdentityEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoadIdentity([Flow(FlowDirection.In)] NV mode);

        [NativeApi(EntryPoint = "glMatrixLoadIdentityEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoadIdentity([Flow(FlowDirection.In)] MatrixMode mode);

        [NativeApi(EntryPoint = "glMatrixLoadTransposefEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoadTranspose([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixLoadTransposefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoadTranspose([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] in float m);

        [NativeApi(EntryPoint = "glMatrixLoadTransposefEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoadTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixLoadTransposefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoadTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] in float m);

        [NativeApi(EntryPoint = "glMatrixLoadTransposedEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoadTranspose([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixLoadTransposedEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoadTranspose([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] in double m);

        [NativeApi(EntryPoint = "glMatrixLoadTransposedEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoadTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixLoadTransposedEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoadTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] in double m);

        [NativeApi(EntryPoint = "glMatrixLoadTranspose3x3fNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoadTranspose3x3([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixLoadTranspose3x3fNV", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoadTranspose3x3([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] in float m);

        [NativeApi(EntryPoint = "glMatrixMultfEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMult([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixMultfEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixMult([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] in float m);

        [NativeApi(EntryPoint = "glMatrixMultfEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMult([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixMultfEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixMult([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] in float m);

        [NativeApi(EntryPoint = "glMatrixMultdEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMult([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixMultdEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixMult([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] in double m);

        [NativeApi(EntryPoint = "glMatrixMultdEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMult([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixMultdEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixMult([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] in double m);

        [NativeApi(EntryPoint = "glMatrixMult3x2fNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMult3x2([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixMult3x2fNV", Convention = CallingConvention.Winapi)]
        public partial void MatrixMult3x2([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] in float m);

        [NativeApi(EntryPoint = "glMatrixMult3x3fNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMult3x3([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixMult3x3fNV", Convention = CallingConvention.Winapi)]
        public partial void MatrixMult3x3([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] in float m);

        [NativeApi(EntryPoint = "glMatrixMultTransposefEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMultTranspose([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixMultTransposefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixMultTranspose([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] in float m);

        [NativeApi(EntryPoint = "glMatrixMultTransposefEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMultTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixMultTransposefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixMultTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] in float m);

        [NativeApi(EntryPoint = "glMatrixMultTransposedEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMultTranspose([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixMultTransposedEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixMultTranspose([Flow(FlowDirection.In)] NV mode, [Count(Count = 16), Flow(FlowDirection.In)] in double m);

        [NativeApi(EntryPoint = "glMatrixMultTransposedEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMultTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixMultTransposedEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixMultTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] in double m);

        [NativeApi(EntryPoint = "glMatrixMultTranspose3x3fNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMultTranspose3x3([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixMultTranspose3x3fNV", Convention = CallingConvention.Winapi)]
        public partial void MatrixMultTranspose3x3([Flow(FlowDirection.In)] NV matrixMode, [Flow(FlowDirection.In)] in float m);

        [NativeApi(EntryPoint = "glMatrixOrthoEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixOrtho([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] double left, [Flow(FlowDirection.In)] double right, [Flow(FlowDirection.In)] double bottom, [Flow(FlowDirection.In)] double top, [Flow(FlowDirection.In)] double zNear, [Flow(FlowDirection.In)] double zFar);

        [NativeApi(EntryPoint = "glMatrixOrthoEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixOrtho([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] double left, [Flow(FlowDirection.In)] double right, [Flow(FlowDirection.In)] double bottom, [Flow(FlowDirection.In)] double top, [Flow(FlowDirection.In)] double zNear, [Flow(FlowDirection.In)] double zFar);

        [NativeApi(EntryPoint = "glMatrixPopEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixPop([Flow(FlowDirection.In)] NV mode);

        [NativeApi(EntryPoint = "glMatrixPopEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixPop([Flow(FlowDirection.In)] MatrixMode mode);

        [NativeApi(EntryPoint = "glMatrixPushEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixPush([Flow(FlowDirection.In)] NV mode);

        [NativeApi(EntryPoint = "glMatrixPushEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixPush([Flow(FlowDirection.In)] MatrixMode mode);

        [NativeApi(EntryPoint = "glMatrixRotatefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixRotate([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] float angle, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glMatrixRotatefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixRotate([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] float angle, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glMatrixRotatedEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixRotate([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] double angle, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glMatrixRotatedEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixRotate([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] double angle, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glMatrixScalefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixScale([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glMatrixScalefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixScale([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glMatrixScaledEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixScale([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glMatrixScaledEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixScale([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glMatrixTranslatefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixTranslate([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glMatrixTranslatefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixTranslate([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glMatrixTranslatedEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixTranslate([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glMatrixTranslatedEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixTranslate([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathCommands([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] byte* commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathCommands<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] byte* commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] in T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathCommands([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] in byte commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public partial void PathCommands<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] in byte commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] in T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathCommands([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCommands, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public partial void PathCommands<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCommands, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] in T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathCommands([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] byte* commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathCommands<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] byte* commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] in T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathCommands([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] in byte commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public partial void PathCommands<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] in byte commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] in T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathCommands([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCommands, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public partial void PathCommands<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCommands, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] in T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathCoordsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathCoords([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathCoordsNV", Convention = CallingConvention.Winapi)]
        public partial void PathCoords<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] in T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathCoordsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathCoords([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathCoordsNV", Convention = CallingConvention.Winapi)]
        public partial void PathCoords<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] in T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathCoverDepthFuncNV", Convention = CallingConvention.Winapi)]
        public partial void PathCoverDepthFunc([Flow(FlowDirection.In)] NV func);

        [NativeApi(EntryPoint = "glPathCoverDepthFuncNV", Convention = CallingConvention.Winapi)]
        public partial void PathCoverDepthFunc([Flow(FlowDirection.In)] DepthFunction func);

        [NativeApi(EntryPoint = "glPathDashArrayNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathDashArray([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint dashCount, [Count(Parameter = "dashCount"), Flow(FlowDirection.In)] float* dashArray);

        [NativeApi(EntryPoint = "glPathDashArrayNV", Convention = CallingConvention.Winapi)]
        public partial void PathDashArray([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint dashCount, [Count(Parameter = "dashCount"), Flow(FlowDirection.In)] in float dashArray);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T0 charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T1 charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T0 charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T1 charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T0 charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T1 charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T0 charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T1 charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T0 charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T1 charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T0 charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T1 charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T0 charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T1 charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T0 charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T1 charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T0 charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T1 charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T0 charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T1 charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T0 charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T1 charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T0 charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T1 charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T0 charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T1 charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T0 charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T1 charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T0 charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T1 charcodes, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T0 charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] void* charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(FlowDirection.In)] in T1 charcodes, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphIndexArrayNV", Convention = CallingConvention.Winapi)]
        public unsafe partial NV PathGlyphIndexArray([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint firstGlyphIndex, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphIndexArrayNV", Convention = CallingConvention.Winapi)]
        public partial NV PathGlyphIndexArray<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint firstGlyphIndex, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphIndexArrayNV", Convention = CallingConvention.Winapi)]
        public unsafe partial NV PathGlyphIndexArray([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint firstGlyphIndex, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphIndexArrayNV", Convention = CallingConvention.Winapi)]
        public partial NV PathGlyphIndexArray<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint firstGlyphIndex, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphIndexRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial NV PathGlyphIndexRange([Flow(FlowDirection.In)] NV fontTarget, [Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale, [Count(Count = 2), Flow(FlowDirection.Out)] uint* baseAndCount);

        [NativeApi(EntryPoint = "glPathGlyphIndexRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial NV PathGlyphIndexRange([Flow(FlowDirection.In)] NV fontTarget, [Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale, [Count(Count = 2), Flow(FlowDirection.Out)] out uint baseAndCount);

        [NativeApi(EntryPoint = "glPathGlyphIndexRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial NV PathGlyphIndexRange<T0>([Flow(FlowDirection.In)] NV fontTarget, [Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale, [Count(Count = 2), Flow(FlowDirection.Out)] uint* baseAndCount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphIndexRangeNV", Convention = CallingConvention.Winapi)]
        public partial NV PathGlyphIndexRange<T0>([Flow(FlowDirection.In)] NV fontTarget, [Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale, [Count(Count = 2), Flow(FlowDirection.Out)] out uint baseAndCount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphIndexRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial NV PathGlyphIndexRange([Flow(FlowDirection.In)] NV fontTarget, [Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale, [Count(Count = 2), Flow(FlowDirection.Out)] uint* baseAndCount);

        [NativeApi(EntryPoint = "glPathGlyphIndexRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial NV PathGlyphIndexRange([Flow(FlowDirection.In)] NV fontTarget, [Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale, [Count(Count = 2), Flow(FlowDirection.Out)] out uint baseAndCount);

        [NativeApi(EntryPoint = "glPathGlyphIndexRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial NV PathGlyphIndexRange<T0>([Flow(FlowDirection.In)] NV fontTarget, [Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale, [Count(Count = 2), Flow(FlowDirection.Out)] uint* baseAndCount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphIndexRangeNV", Convention = CallingConvention.Winapi)]
        public partial NV PathGlyphIndexRange<T0>([Flow(FlowDirection.In)] NV fontTarget, [Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale, [Count(Count = 2), Flow(FlowDirection.Out)] out uint baseAndCount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyphRange([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint firstGlyph, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyphRange<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint firstGlyph, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyphRange([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint firstGlyph, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyphRange<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint firstGlyph, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyphRange([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint firstGlyph, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyphRange<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint firstGlyph, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyphRange([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint firstGlyph, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyphRange<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint firstGlyph, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyphRange([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint firstGlyph, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyphRange<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint firstGlyph, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyphRange([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint firstGlyph, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyphRange<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] uint fontStyle, [Flow(FlowDirection.In)] uint firstGlyph, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyphRange([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint firstGlyph, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyphRange<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint firstGlyph, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] NV handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyphRange([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] void* fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint firstGlyph, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyphRange<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(FlowDirection.In)] in T0 fontName, [Flow(FlowDirection.In)] PathFontStyle fontStyle, [Flow(FlowDirection.In)] uint firstGlyph, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathMemoryGlyphIndexArrayNV", Convention = CallingConvention.Winapi)]
        public unsafe partial NV PathMemoryGlyphIndexArray([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Flow(FlowDirection.In)] nuint fontSize, [Flow(FlowDirection.In)] void* fontData, [Flow(FlowDirection.In)] uint faceIndex, [Flow(FlowDirection.In)] uint firstGlyphIndex, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathMemoryGlyphIndexArrayNV", Convention = CallingConvention.Winapi)]
        public partial NV PathMemoryGlyphIndexArray<T0>([Flow(FlowDirection.In)] uint firstPathName, [Flow(FlowDirection.In)] NV fontTarget, [Flow(FlowDirection.In)] nuint fontSize, [Flow(FlowDirection.In)] in T0 fontData, [Flow(FlowDirection.In)] uint faceIndex, [Flow(FlowDirection.In)] uint firstGlyphIndex, [Flow(FlowDirection.In)] uint numGlyphs, [Flow(FlowDirection.In)] uint pathParameterTemplate, [Flow(FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glPathParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int value);

        [NativeApi(EntryPoint = "glPathParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glPathParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int value);

        [NativeApi(EntryPoint = "glPathParameteriNV", Convention = CallingConvention.Winapi)]
        public partial void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glPathParameteriNV", Convention = CallingConvention.Winapi)]
        public partial void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathParameter pname, [Flow(FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glPathParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glPathParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glPathParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glPathParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glPathParameterfNV", Convention = CallingConvention.Winapi)]
        public partial void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] float value);

        [NativeApi(EntryPoint = "glPathParameterfNV", Convention = CallingConvention.Winapi)]
        public partial void PathParameter([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathParameter pname, [Flow(FlowDirection.In)] float value);

        [NativeApi(EntryPoint = "glPathStencilDepthOffsetNV", Convention = CallingConvention.Winapi)]
        public partial void PathStencilDepthOffset([Flow(FlowDirection.In)] float factor, [Flow(FlowDirection.In)] float units);

        [NativeApi(EntryPoint = "glPathStencilFuncNV", Convention = CallingConvention.Winapi)]
        public partial void PathStencilFunc([Flow(FlowDirection.In)] NV func, [Flow(FlowDirection.In)] int @ref, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glPathStencilFuncNV", Convention = CallingConvention.Winapi)]
        public partial void PathStencilFunc([Flow(FlowDirection.In)] StencilFunction func, [Flow(FlowDirection.In)] int @ref, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glPathStringNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathString([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV format, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* pathString);

        [NativeApi(EntryPoint = "glPathStringNV", Convention = CallingConvention.Winapi)]
        public partial void PathString<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV format, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] in T0 pathString) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathStringNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathString([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathStringFormat format, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* pathString);

        [NativeApi(EntryPoint = "glPathStringNV", Convention = CallingConvention.Winapi)]
        public partial void PathString<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathStringFormat format, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] in T0 pathString) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathSubCommands([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint commandStart, [Flow(FlowDirection.In)] uint commandsToDelete, [Flow(FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] byte* commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathSubCommands<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint commandStart, [Flow(FlowDirection.In)] uint commandsToDelete, [Flow(FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] byte* commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] in T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathSubCommands([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint commandStart, [Flow(FlowDirection.In)] uint commandsToDelete, [Flow(FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] in byte commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public partial void PathSubCommands<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint commandStart, [Flow(FlowDirection.In)] uint commandsToDelete, [Flow(FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] in byte commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] in T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathSubCommands([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint commandStart, [Flow(FlowDirection.In)] uint commandsToDelete, [Flow(FlowDirection.In)] uint numCommands, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public partial void PathSubCommands<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint commandStart, [Flow(FlowDirection.In)] uint commandsToDelete, [Flow(FlowDirection.In)] uint numCommands, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] in T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathSubCommands([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint commandStart, [Flow(FlowDirection.In)] uint commandsToDelete, [Flow(FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] byte* commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathSubCommands<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint commandStart, [Flow(FlowDirection.In)] uint commandsToDelete, [Flow(FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] byte* commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] in T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathSubCommands([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint commandStart, [Flow(FlowDirection.In)] uint commandsToDelete, [Flow(FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] in byte commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public partial void PathSubCommands<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint commandStart, [Flow(FlowDirection.In)] uint commandsToDelete, [Flow(FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] in byte commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] in T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathSubCommands([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint commandStart, [Flow(FlowDirection.In)] uint commandsToDelete, [Flow(FlowDirection.In)] uint numCommands, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public partial void PathSubCommands<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint commandStart, [Flow(FlowDirection.In)] uint commandsToDelete, [Flow(FlowDirection.In)] uint numCommands, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] in T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathSubCoordsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathSubCoords([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint coordStart, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathSubCoordsNV", Convention = CallingConvention.Winapi)]
        public partial void PathSubCoords<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint coordStart, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] in T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathSubCoordsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathSubCoords([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint coordStart, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathSubCoordsNV", Convention = CallingConvention.Winapi)]
        public partial void PathSubCoords<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint coordStart, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] in T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool PointAlongPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint startSegment, [Flow(FlowDirection.In)] uint numSegments, [Flow(FlowDirection.In)] float distance, [Count(Count = 1), Flow(FlowDirection.Out)] float* x, [Count(Count = 1), Flow(FlowDirection.Out)] float* y, [Count(Count = 1), Flow(FlowDirection.Out)] float* tangentX, [Count(Count = 1), Flow(FlowDirection.Out)] float* tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool PointAlongPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint startSegment, [Flow(FlowDirection.In)] uint numSegments, [Flow(FlowDirection.In)] float distance, [Count(Count = 1), Flow(FlowDirection.Out)] float* x, [Count(Count = 1), Flow(FlowDirection.Out)] float* y, [Count(Count = 1), Flow(FlowDirection.Out)] float* tangentX, [Count(Count = 1), Flow(FlowDirection.Out)] out float tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool PointAlongPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint startSegment, [Flow(FlowDirection.In)] uint numSegments, [Flow(FlowDirection.In)] float distance, [Count(Count = 1), Flow(FlowDirection.Out)] float* x, [Count(Count = 1), Flow(FlowDirection.Out)] float* y, [Count(Count = 1), Flow(FlowDirection.Out)] out float tangentX, [Count(Count = 1), Flow(FlowDirection.Out)] float* tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool PointAlongPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint startSegment, [Flow(FlowDirection.In)] uint numSegments, [Flow(FlowDirection.In)] float distance, [Count(Count = 1), Flow(FlowDirection.Out)] float* x, [Count(Count = 1), Flow(FlowDirection.Out)] float* y, [Count(Count = 1), Flow(FlowDirection.Out)] out float tangentX, [Count(Count = 1), Flow(FlowDirection.Out)] out float tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool PointAlongPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint startSegment, [Flow(FlowDirection.In)] uint numSegments, [Flow(FlowDirection.In)] float distance, [Count(Count = 1), Flow(FlowDirection.Out)] float* x, [Count(Count = 1), Flow(FlowDirection.Out)] out float y, [Count(Count = 1), Flow(FlowDirection.Out)] float* tangentX, [Count(Count = 1), Flow(FlowDirection.Out)] float* tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool PointAlongPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint startSegment, [Flow(FlowDirection.In)] uint numSegments, [Flow(FlowDirection.In)] float distance, [Count(Count = 1), Flow(FlowDirection.Out)] float* x, [Count(Count = 1), Flow(FlowDirection.Out)] out float y, [Count(Count = 1), Flow(FlowDirection.Out)] float* tangentX, [Count(Count = 1), Flow(FlowDirection.Out)] out float tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool PointAlongPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint startSegment, [Flow(FlowDirection.In)] uint numSegments, [Flow(FlowDirection.In)] float distance, [Count(Count = 1), Flow(FlowDirection.Out)] float* x, [Count(Count = 1), Flow(FlowDirection.Out)] out float y, [Count(Count = 1), Flow(FlowDirection.Out)] out float tangentX, [Count(Count = 1), Flow(FlowDirection.Out)] float* tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool PointAlongPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint startSegment, [Flow(FlowDirection.In)] uint numSegments, [Flow(FlowDirection.In)] float distance, [Count(Count = 1), Flow(FlowDirection.Out)] float* x, [Count(Count = 1), Flow(FlowDirection.Out)] out float y, [Count(Count = 1), Flow(FlowDirection.Out)] out float tangentX, [Count(Count = 1), Flow(FlowDirection.Out)] out float tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool PointAlongPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint startSegment, [Flow(FlowDirection.In)] uint numSegments, [Flow(FlowDirection.In)] float distance, [Count(Count = 1), Flow(FlowDirection.Out)] out float x, [Count(Count = 1), Flow(FlowDirection.Out)] float* y, [Count(Count = 1), Flow(FlowDirection.Out)] float* tangentX, [Count(Count = 1), Flow(FlowDirection.Out)] float* tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool PointAlongPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint startSegment, [Flow(FlowDirection.In)] uint numSegments, [Flow(FlowDirection.In)] float distance, [Count(Count = 1), Flow(FlowDirection.Out)] out float x, [Count(Count = 1), Flow(FlowDirection.Out)] float* y, [Count(Count = 1), Flow(FlowDirection.Out)] float* tangentX, [Count(Count = 1), Flow(FlowDirection.Out)] out float tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool PointAlongPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint startSegment, [Flow(FlowDirection.In)] uint numSegments, [Flow(FlowDirection.In)] float distance, [Count(Count = 1), Flow(FlowDirection.Out)] out float x, [Count(Count = 1), Flow(FlowDirection.Out)] float* y, [Count(Count = 1), Flow(FlowDirection.Out)] out float tangentX, [Count(Count = 1), Flow(FlowDirection.Out)] float* tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool PointAlongPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint startSegment, [Flow(FlowDirection.In)] uint numSegments, [Flow(FlowDirection.In)] float distance, [Count(Count = 1), Flow(FlowDirection.Out)] out float x, [Count(Count = 1), Flow(FlowDirection.Out)] float* y, [Count(Count = 1), Flow(FlowDirection.Out)] out float tangentX, [Count(Count = 1), Flow(FlowDirection.Out)] out float tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool PointAlongPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint startSegment, [Flow(FlowDirection.In)] uint numSegments, [Flow(FlowDirection.In)] float distance, [Count(Count = 1), Flow(FlowDirection.Out)] out float x, [Count(Count = 1), Flow(FlowDirection.Out)] out float y, [Count(Count = 1), Flow(FlowDirection.Out)] float* tangentX, [Count(Count = 1), Flow(FlowDirection.Out)] float* tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool PointAlongPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint startSegment, [Flow(FlowDirection.In)] uint numSegments, [Flow(FlowDirection.In)] float distance, [Count(Count = 1), Flow(FlowDirection.Out)] out float x, [Count(Count = 1), Flow(FlowDirection.Out)] out float y, [Count(Count = 1), Flow(FlowDirection.Out)] float* tangentX, [Count(Count = 1), Flow(FlowDirection.Out)] out float tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool PointAlongPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint startSegment, [Flow(FlowDirection.In)] uint numSegments, [Flow(FlowDirection.In)] float distance, [Count(Count = 1), Flow(FlowDirection.Out)] out float x, [Count(Count = 1), Flow(FlowDirection.Out)] out float y, [Count(Count = 1), Flow(FlowDirection.Out)] out float tangentX, [Count(Count = 1), Flow(FlowDirection.Out)] float* tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public partial bool PointAlongPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint startSegment, [Flow(FlowDirection.In)] uint numSegments, [Flow(FlowDirection.In)] float distance, [Count(Count = 1), Flow(FlowDirection.Out)] out float x, [Count(Count = 1), Flow(FlowDirection.Out)] out float y, [Count(Count = 1), Flow(FlowDirection.Out)] out float tangentX, [Count(Count = 1), Flow(FlowDirection.Out)] out float tangentY);

        [NativeApi(EntryPoint = "glProgramPathFragmentInputGenNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramPathFragmentInputGen([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] NV genMode, [Flow(FlowDirection.In)] int components, [Flow(FlowDirection.In)] float* coeffs);

        [NativeApi(EntryPoint = "glProgramPathFragmentInputGenNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramPathFragmentInputGen([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] NV genMode, [Flow(FlowDirection.In)] int components, [Flow(FlowDirection.In)] in float coeffs);

        [NativeApi(EntryPoint = "glStencilFillPathNV", Convention = CallingConvention.Winapi)]
        public partial void StencilFillPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilFillPathNV", Convention = CallingConvention.Winapi)]
        public partial void StencilFillPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathFillMode fillMode, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathFillMode fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathFillMode fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathFillMode fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathFillMode fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathFillMode fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathFillMode fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathFillMode fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathFillMode fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathFillMode fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathFillMode fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathFillMode fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathFillMode fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathFillMode fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathFillMode fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathFillMode fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] PathFillMode fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilStrokePathNV", Convention = CallingConvention.Winapi)]
        public partial void StencilStrokePath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(FlowDirection.In)] in float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverFillPath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV coverMode);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Flow(FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverFillPathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] NV fillMode, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Flow(FlowDirection.In)] in float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverStrokePath([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV coverMode);

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverStrokePathInstanced([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Flow(FlowDirection.In)] void* paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Flow(FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverStrokePathInstanced<T0>([Flow(FlowDirection.In)] uint numPaths, [Flow(FlowDirection.In)] NV pathNameType, [Flow(FlowDirection.In)] in T0 paths, [Flow(FlowDirection.In)] uint pathBase, [Flow(FlowDirection.In)] int reference, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV coverMode, [Flow(FlowDirection.In)] NV transformType, [Flow(FlowDirection.In)] in float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTransformPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformPath([Flow(FlowDirection.In)] uint resultPath, [Flow(FlowDirection.In)] uint srcPath, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glTransformPathNV", Convention = CallingConvention.Winapi)]
        public partial void TransformPath([Flow(FlowDirection.In)] uint resultPath, [Flow(FlowDirection.In)] uint srcPath, [Flow(FlowDirection.In)] NV transformType, [Count(Computed = "transformType"), Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glTransformPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformPath([Flow(FlowDirection.In)] uint resultPath, [Flow(FlowDirection.In)] uint srcPath, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "transformType"), Flow(FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glTransformPathNV", Convention = CallingConvention.Winapi)]
        public partial void TransformPath([Flow(FlowDirection.In)] uint resultPath, [Flow(FlowDirection.In)] uint srcPath, [Flow(FlowDirection.In)] PathTransformType transformType, [Count(Computed = "transformType"), Flow(FlowDirection.In)] in float transformValues);

        [NativeApi(EntryPoint = "glWeightPathsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void WeightPath([Flow(FlowDirection.In)] uint resultPath, [Flow(FlowDirection.In)] uint numPaths, [Count(Parameter = "numPaths"), Flow(FlowDirection.In)] uint* paths, [Count(Parameter = "numPaths"), Flow(FlowDirection.In)] float* weights);

        [NativeApi(EntryPoint = "glWeightPathsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void WeightPath([Flow(FlowDirection.In)] uint resultPath, [Flow(FlowDirection.In)] uint numPaths, [Count(Parameter = "numPaths"), Flow(FlowDirection.In)] uint* paths, [Count(Parameter = "numPaths"), Flow(FlowDirection.In)] in float weights);

        [NativeApi(EntryPoint = "glWeightPathsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void WeightPath([Flow(FlowDirection.In)] uint resultPath, [Flow(FlowDirection.In)] uint numPaths, [Count(Parameter = "numPaths"), Flow(FlowDirection.In)] in uint paths, [Count(Parameter = "numPaths"), Flow(FlowDirection.In)] float* weights);

        [NativeApi(EntryPoint = "glWeightPathsNV", Convention = CallingConvention.Winapi)]
        public partial void WeightPath([Flow(FlowDirection.In)] uint resultPath, [Flow(FlowDirection.In)] uint numPaths, [Count(Parameter = "numPaths"), Flow(FlowDirection.In)] in uint paths, [Count(Parameter = "numPaths"), Flow(FlowDirection.In)] in float weights);

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

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] NV programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] NV* props, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, propCount, props, (uint) @params.Length, length, out @params.GetPinnableReference());
        }

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] NV programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] NV* props, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, propCount, props, (uint) @params.Length, out length, out @params.GetPinnableReference());
        }

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] NV programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] in NV props, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, propCount, in props, (uint) @params.Length, length, out @params.GetPinnableReference());
        }

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] NV programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] in NV props, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, propCount, in props, (uint) @params.Length, out length, out @params.GetPinnableReference());
        }

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] NV* props, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, propCount, props, (uint) @params.Length, length, out @params.GetPinnableReference());
        }

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] NV* props, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, propCount, props, (uint) @params.Length, out length, out @params.GetPinnableReference());
        }

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] in NV props, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, propCount, in props, (uint) @params.Length, length, out @params.GetPinnableReference());
        }

        public unsafe void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Flow(FlowDirection.In)] in NV props, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, propCount, in props, (uint) @params.Length, out length, out @params.GetPinnableReference());
        }

        public unsafe void PathCommands([Flow(FlowDirection.In)] uint path, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] ReadOnlySpan<byte> commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords)
        {
            // ImplicitCountSpanOverloader
            PathCommands(path, (uint) commands.Length, in commands.GetPinnableReference(), numCoords, coordType, coords);
        }

        public unsafe void PathCommands<T0>([Flow(FlowDirection.In)] uint path, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] ReadOnlySpan<byte> commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] in T0 coords) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            PathCommands(path, (uint) commands.Length, in commands.GetPinnableReference(), numCoords, coordType, in coords);
        }

        public unsafe void PathCommands([Flow(FlowDirection.In)] uint path, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] ReadOnlySpan<byte> commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords)
        {
            // ImplicitCountSpanOverloader
            PathCommands(path, (uint) commands.Length, in commands.GetPinnableReference(), numCoords, coordType, coords);
        }

        public unsafe void PathCommands<T0>([Flow(FlowDirection.In)] uint path, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] ReadOnlySpan<byte> commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] in T0 coords) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            PathCommands(path, (uint) commands.Length, in commands.GetPinnableReference(), numCoords, coordType, in coords);
        }

        public unsafe void PathDashArray([Flow(FlowDirection.In)] uint path, [Count(Parameter = "dashCount"), Flow(FlowDirection.In)] ReadOnlySpan<float> dashArray)
        {
            // ImplicitCountSpanOverloader
            PathDashArray(path, (uint) dashArray.Length, in dashArray.GetPinnableReference());
        }

        public unsafe void PathString<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] NV format, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pathString) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            PathString(path, format, (uint) (pathString.Length * Unsafe.SizeOf<T0>()), in pathString.GetPinnableReference());
        }

        public unsafe void PathString<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] PathStringFormat format, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pathString) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            PathString(path, format, (uint) (pathString.Length * Unsafe.SizeOf<T0>()), in pathString.GetPinnableReference());
        }

        public unsafe void PathSubCommands([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint commandStart, [Flow(FlowDirection.In)] uint commandsToDelete, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] ReadOnlySpan<byte> commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords)
        {
            // ImplicitCountSpanOverloader
            PathSubCommands(path, commandStart, commandsToDelete, (uint) commands.Length, in commands.GetPinnableReference(), numCoords, coordType, coords);
        }

        public unsafe void PathSubCommands<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint commandStart, [Flow(FlowDirection.In)] uint commandsToDelete, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] ReadOnlySpan<byte> commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] in T0 coords) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            PathSubCommands(path, commandStart, commandsToDelete, (uint) commands.Length, in commands.GetPinnableReference(), numCoords, coordType, in coords);
        }

        public unsafe void PathSubCommands([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint commandStart, [Flow(FlowDirection.In)] uint commandsToDelete, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] ReadOnlySpan<byte> commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] void* coords)
        {
            // ImplicitCountSpanOverloader
            PathSubCommands(path, commandStart, commandsToDelete, (uint) commands.Length, in commands.GetPinnableReference(), numCoords, coordType, coords);
        }

        public unsafe void PathSubCommands<T0>([Flow(FlowDirection.In)] uint path, [Flow(FlowDirection.In)] uint commandStart, [Flow(FlowDirection.In)] uint commandsToDelete, [Count(Parameter = "numCommands"), Flow(FlowDirection.In)] ReadOnlySpan<byte> commands, [Flow(FlowDirection.In)] uint numCoords, [Flow(FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(FlowDirection.In)] in T0 coords) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            PathSubCommands(path, commandStart, commandsToDelete, (uint) commands.Length, in commands.GetPinnableReference(), numCoords, coordType, in coords);
        }

        public unsafe void WeightPath([Flow(FlowDirection.In)] uint resultPath, [Count(Parameter = "numPaths"), Flow(FlowDirection.In)] uint* paths, [Count(Parameter = "numPaths"), Flow(FlowDirection.In)] ReadOnlySpan<float> weights)
        {
            // ImplicitCountSpanOverloader
            WeightPath(resultPath, (uint) weights.Length, paths, in weights.GetPinnableReference());
        }

        public unsafe void WeightPath([Flow(FlowDirection.In)] uint resultPath, [Count(Parameter = "numPaths"), Flow(FlowDirection.In)] ReadOnlySpan<uint> paths, [Count(Parameter = "numPaths"), Flow(FlowDirection.In)] float* weights)
        {
            // ImplicitCountSpanOverloader
            WeightPath(resultPath, (uint) paths.Length, in paths.GetPinnableReference(), weights);
        }

        public unsafe void WeightPath([Flow(FlowDirection.In)] uint resultPath, [Count(Parameter = "numPaths"), Flow(FlowDirection.In)] ReadOnlySpan<uint> paths, [Count(Parameter = "numPaths"), Flow(FlowDirection.In)] ReadOnlySpan<float> weights)
        {
            // ImplicitCountSpanOverloader
            WeightPath(resultPath, (uint) weights.Length, in paths.GetPinnableReference(), in weights.GetPinnableReference());
        }

        public NVPathRendering(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

