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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_path_rendering")]
    public unsafe partial class NVPathRendering : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_path_rendering";
        [NativeApi(EntryPoint = "glCopyPathNV", Convention = CallingConvention.Winapi)]
        public partial void CopyPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint resultPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint srcPath);

        [NativeApi(EntryPoint = "glCoverFillPathNV", Convention = CallingConvention.Winapi)]
        public partial void CoverFillPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode);

        [NativeApi(EntryPoint = "glCoverFillPathNV", Convention = CallingConvention.Winapi)]
        public partial void CoverFillPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoverMode coverMode);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathNV", Convention = CallingConvention.Winapi)]
        public partial void CoverStrokePath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode);

        [NativeApi(EntryPoint = "glCoverStrokePathNV", Convention = CallingConvention.Winapi)]
        public partial void CoverStrokePath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoverMode coverMode);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void CoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDeletePathsNV", Convention = CallingConvention.Winapi)]
        public partial void DeletePath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint range);

        [NativeApi(EntryPoint = "glGenPathsNV", Convention = CallingConvention.Winapi)]
        public partial uint GenPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint range);

        [NativeApi(EntryPoint = "glGetPathColorGenivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "glGetPathColorGenivNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int value);

        [NativeApi(EntryPoint = "glGetPathColorGenivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "glGetPathColorGenivNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int value);

        [NativeApi(EntryPoint = "glGetPathColorGenivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathColor color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "glGetPathColorGenivNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathColor color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int value);

        [NativeApi(EntryPoint = "glGetPathColorGenivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathColor color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "glGetPathColorGenivNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathColor color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int value);

        [NativeApi(EntryPoint = "glGetPathColorGenfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* value);

        [NativeApi(EntryPoint = "glGetPathColorGenfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float value);

        [NativeApi(EntryPoint = "glGetPathColorGenfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* value);

        [NativeApi(EntryPoint = "glGetPathColorGenfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float value);

        [NativeApi(EntryPoint = "glGetPathColorGenfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathColor color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* value);

        [NativeApi(EntryPoint = "glGetPathColorGenfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathColor color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float value);

        [NativeApi(EntryPoint = "glGetPathColorGenfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathColor color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* value);

        [NativeApi(EntryPoint = "glGetPathColorGenfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathColor color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float value);

        [NativeApi(EntryPoint = "glGetPathCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Count(Computed = "path"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* commands);

        [NativeApi(EntryPoint = "glGetPathCommandsNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Count(Computed = "path"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte commands);

        [NativeApi(EntryPoint = "glGetPathCommandsNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string commands);

        [NativeApi(EntryPoint = "glGetPathCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Count(Computed = "path"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PathCoordType* commands);

        [NativeApi(EntryPoint = "glGetPathCommandsNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Count(Computed = "path"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out PathCoordType commands);

        [NativeApi(EntryPoint = "glGetPathCoordsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathCoords([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Count(Computed = "path"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* coords);

        [NativeApi(EntryPoint = "glGetPathCoordsNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathCoords([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Count(Computed = "path"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float coords);

        [NativeApi(EntryPoint = "glGetPathDashArrayNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathDashArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Count(Computed = "path"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* dashArray);

        [NativeApi(EntryPoint = "glGetPathDashArrayNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathDashArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Count(Computed = "path"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float dashArray);

        [NativeApi(EntryPoint = "glGetPathLengthNV", Convention = CallingConvention.Winapi)]
        public partial float GetPathLength([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments);

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathMetric([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* metrics);

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathMetric([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float metrics);

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathMetric<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* metrics) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathMetric<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float metrics) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathMetric([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* metrics);

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathMetric([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float metrics);

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathMetric<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* metrics) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathMetric<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float metrics) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathMetric([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* metrics);

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathMetric([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float metrics);

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathMetric<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* metrics) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathMetric<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float metrics) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathMetric([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* metrics);

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathMetric([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float metrics);

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathMetric<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* metrics) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathMetricsNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathMetric<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float metrics) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathMetricRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathMetricRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* metrics);

        [NativeApi(EntryPoint = "glGetPathMetricRangeNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathMetricRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float metrics);

        [NativeApi(EntryPoint = "glGetPathMetricRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathMetricRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* metrics);

        [NativeApi(EntryPoint = "glGetPathMetricRangeNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathMetricRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "metricQueryMask, numPaths, stride"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float metrics);

        [NativeApi(EntryPoint = "glGetPathParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "glGetPathParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int value);

        [NativeApi(EntryPoint = "glGetPathParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathParameter pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "glGetPathParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathParameter pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int value);

        [NativeApi(EntryPoint = "glGetPathParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* value);

        [NativeApi(EntryPoint = "glGetPathParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float value);

        [NativeApi(EntryPoint = "glGetPathParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathParameter pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* value);

        [NativeApi(EntryPoint = "glGetPathParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathParameter pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float value);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathSpacing<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathSpacing<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathSpacing<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathSpacing<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathSpacing<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathSpacing<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathSpacing<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float returnedSpacing);

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathSpacing<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathSpacingNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathSpacing<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "pathListMode, numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float returnedSpacing) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPathTexGenivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV texCoordSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "glGetPathTexGenivNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV texCoordSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int value);

        [NativeApi(EntryPoint = "glGetPathTexGenivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV texCoordSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "glGetPathTexGenivNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV texCoordSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int value);

        [NativeApi(EntryPoint = "glGetPathTexGenivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texCoordSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "glGetPathTexGenivNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texCoordSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int value);

        [NativeApi(EntryPoint = "glGetPathTexGenivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texCoordSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "glGetPathTexGenivNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texCoordSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int value);

        [NativeApi(EntryPoint = "glGetPathTexGenfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV texCoordSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* value);

        [NativeApi(EntryPoint = "glGetPathTexGenfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV texCoordSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float value);

        [NativeApi(EntryPoint = "glGetPathTexGenfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV texCoordSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* value);

        [NativeApi(EntryPoint = "glGetPathTexGenfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV texCoordSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float value);

        [NativeApi(EntryPoint = "glGetPathTexGenfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texCoordSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* value);

        [NativeApi(EntryPoint = "glGetPathTexGenfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texCoordSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float value);

        [NativeApi(EntryPoint = "glGetPathTexGenfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPathTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texCoordSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* value);

        [NativeApi(EntryPoint = "glGetPathTexGenfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetPathTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texCoordSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float value);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly NV props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly NV props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly NV props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly NV props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly NV props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly NV props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly NV props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramResourcefvNV", Convention = CallingConvention.Winapi)]
        public partial void GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly NV props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glInterpolatePathsNV", Convention = CallingConvention.Winapi)]
        public partial void InterpolatePath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint resultPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathA, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float weight);

        [NativeApi(EntryPoint = "glIsPathNV", Convention = CallingConvention.Winapi)]
        public partial bool IsPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path);

        [NativeApi(EntryPoint = "glIsPointInFillPathNV", Convention = CallingConvention.Winapi)]
        public partial bool IsPointInFillPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y);

        [NativeApi(EntryPoint = "glIsPointInStrokePathNV", Convention = CallingConvention.Winapi)]
        public partial bool IsPointInStrokePath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y);

        [NativeApi(EntryPoint = "glMatrixFrustumEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixFrustum([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double left, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double right, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double bottom, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double top, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double zNear, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double zFar);

        [NativeApi(EntryPoint = "glMatrixFrustumEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixFrustum([Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double left, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double right, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double bottom, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double top, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double zNear, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double zFar);

        [NativeApi(EntryPoint = "glMatrixLoadfEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoad([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixLoadfEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoad([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float m);

        [NativeApi(EntryPoint = "glMatrixLoadfEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoad([Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixLoadfEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoad([Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float m);

        [NativeApi(EntryPoint = "glMatrixLoaddEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoad([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixLoaddEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoad([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly double m);

        [NativeApi(EntryPoint = "glMatrixLoaddEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoad([Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixLoaddEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoad([Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly double m);

        [NativeApi(EntryPoint = "glMatrixLoad3x2fNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoad3x2([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV matrixMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixLoad3x2fNV", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoad3x2([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV matrixMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float m);

        [NativeApi(EntryPoint = "glMatrixLoad3x3fNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoad3x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV matrixMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixLoad3x3fNV", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoad3x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV matrixMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float m);

        [NativeApi(EntryPoint = "glMatrixLoadIdentityEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoadIdentity([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode);

        [NativeApi(EntryPoint = "glMatrixLoadIdentityEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoadIdentity([Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode);

        [NativeApi(EntryPoint = "glMatrixLoadTransposefEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoadTranspose([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixLoadTransposefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoadTranspose([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float m);

        [NativeApi(EntryPoint = "glMatrixLoadTransposefEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoadTranspose([Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixLoadTransposefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoadTranspose([Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float m);

        [NativeApi(EntryPoint = "glMatrixLoadTransposedEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoadTranspose([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixLoadTransposedEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoadTranspose([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly double m);

        [NativeApi(EntryPoint = "glMatrixLoadTransposedEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoadTranspose([Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixLoadTransposedEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoadTranspose([Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly double m);

        [NativeApi(EntryPoint = "glMatrixLoadTranspose3x3fNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoadTranspose3x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV matrixMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixLoadTranspose3x3fNV", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoadTranspose3x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV matrixMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float m);

        [NativeApi(EntryPoint = "glMatrixMultfEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMult([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixMultfEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixMult([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float m);

        [NativeApi(EntryPoint = "glMatrixMultfEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMult([Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixMultfEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixMult([Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float m);

        [NativeApi(EntryPoint = "glMatrixMultdEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMult([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixMultdEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixMult([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly double m);

        [NativeApi(EntryPoint = "glMatrixMultdEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMult([Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixMultdEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixMult([Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly double m);

        [NativeApi(EntryPoint = "glMatrixMult3x2fNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMult3x2([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV matrixMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixMult3x2fNV", Convention = CallingConvention.Winapi)]
        public partial void MatrixMult3x2([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV matrixMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float m);

        [NativeApi(EntryPoint = "glMatrixMult3x3fNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMult3x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV matrixMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixMult3x3fNV", Convention = CallingConvention.Winapi)]
        public partial void MatrixMult3x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV matrixMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float m);

        [NativeApi(EntryPoint = "glMatrixMultTransposefEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMultTranspose([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixMultTransposefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixMultTranspose([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float m);

        [NativeApi(EntryPoint = "glMatrixMultTransposefEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMultTranspose([Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixMultTransposefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixMultTranspose([Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float m);

        [NativeApi(EntryPoint = "glMatrixMultTransposedEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMultTranspose([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixMultTransposedEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixMultTranspose([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly double m);

        [NativeApi(EntryPoint = "glMatrixMultTransposedEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMultTranspose([Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixMultTransposedEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixMultTranspose([Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly double m);

        [NativeApi(EntryPoint = "glMatrixMultTranspose3x3fNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMultTranspose3x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV matrixMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixMultTranspose3x3fNV", Convention = CallingConvention.Winapi)]
        public partial void MatrixMultTranspose3x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV matrixMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float m);

        [NativeApi(EntryPoint = "glMatrixOrthoEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixOrtho([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double left, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double right, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double bottom, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double top, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double zNear, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double zFar);

        [NativeApi(EntryPoint = "glMatrixOrthoEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixOrtho([Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double left, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double right, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double bottom, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double top, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double zNear, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double zFar);

        [NativeApi(EntryPoint = "glMatrixPopEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixPop([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode);

        [NativeApi(EntryPoint = "glMatrixPopEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixPop([Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode);

        [NativeApi(EntryPoint = "glMatrixPushEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixPush([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode);

        [NativeApi(EntryPoint = "glMatrixPushEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixPush([Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode);

        [NativeApi(EntryPoint = "glMatrixRotatefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixRotate([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float angle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glMatrixRotatefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixRotate([Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float angle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glMatrixRotatedEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixRotate([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double angle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glMatrixRotatedEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixRotate([Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double angle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glMatrixScalefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixScale([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glMatrixScalefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixScale([Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glMatrixScaledEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixScale([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glMatrixScaledEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixScale([Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glMatrixTranslatefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixTranslate([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glMatrixTranslatefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixTranslate([Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glMatrixTranslatedEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixTranslate([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glMatrixTranslatedEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixTranslate([Flow(Silk.NET.Core.Native.FlowDirection.In)] MatrixMode mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glPathColorGenNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV genMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV colorFormat, [Count(Computed = "genMode, colorFormat"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* coeffs);

        [NativeApi(EntryPoint = "glPathColorGenNV", Convention = CallingConvention.Winapi)]
        public partial void PathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV genMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV colorFormat, [Count(Computed = "genMode, colorFormat"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float coeffs);

        [NativeApi(EntryPoint = "glPathColorGenNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV genMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathColorFormat colorFormat, [Count(Computed = "genMode, colorFormat"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* coeffs);

        [NativeApi(EntryPoint = "glPathColorGenNV", Convention = CallingConvention.Winapi)]
        public partial void PathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV genMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathColorFormat colorFormat, [Count(Computed = "genMode, colorFormat"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float coeffs);

        [NativeApi(EntryPoint = "glPathColorGenNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode genMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV colorFormat, [Count(Computed = "genMode, colorFormat"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* coeffs);

        [NativeApi(EntryPoint = "glPathColorGenNV", Convention = CallingConvention.Winapi)]
        public partial void PathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode genMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV colorFormat, [Count(Computed = "genMode, colorFormat"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float coeffs);

        [NativeApi(EntryPoint = "glPathColorGenNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode genMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathColorFormat colorFormat, [Count(Computed = "genMode, colorFormat"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* coeffs);

        [NativeApi(EntryPoint = "glPathColorGenNV", Convention = CallingConvention.Winapi)]
        public partial void PathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode genMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathColorFormat colorFormat, [Count(Computed = "genMode, colorFormat"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float coeffs);

        [NativeApi(EntryPoint = "glPathColorGenNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathColor color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV genMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV colorFormat, [Count(Computed = "genMode, colorFormat"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* coeffs);

        [NativeApi(EntryPoint = "glPathColorGenNV", Convention = CallingConvention.Winapi)]
        public partial void PathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathColor color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV genMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV colorFormat, [Count(Computed = "genMode, colorFormat"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float coeffs);

        [NativeApi(EntryPoint = "glPathColorGenNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathColor color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV genMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathColorFormat colorFormat, [Count(Computed = "genMode, colorFormat"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* coeffs);

        [NativeApi(EntryPoint = "glPathColorGenNV", Convention = CallingConvention.Winapi)]
        public partial void PathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathColor color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV genMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathColorFormat colorFormat, [Count(Computed = "genMode, colorFormat"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float coeffs);

        [NativeApi(EntryPoint = "glPathColorGenNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathColor color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode genMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV colorFormat, [Count(Computed = "genMode, colorFormat"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* coeffs);

        [NativeApi(EntryPoint = "glPathColorGenNV", Convention = CallingConvention.Winapi)]
        public partial void PathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathColor color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode genMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV colorFormat, [Count(Computed = "genMode, colorFormat"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float coeffs);

        [NativeApi(EntryPoint = "glPathColorGenNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathColor color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode genMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathColorFormat colorFormat, [Count(Computed = "genMode, colorFormat"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* coeffs);

        [NativeApi(EntryPoint = "glPathColorGenNV", Convention = CallingConvention.Winapi)]
        public partial void PathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathColor color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode genMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathColorFormat colorFormat, [Count(Computed = "genMode, colorFormat"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float coeffs);

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathCommands<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public partial void PathCommands<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public partial void PathCommands<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathCommands<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public partial void PathCommands<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public partial void PathCommands<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType* commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathCommands<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType* commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PathCoordType commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public partial void PathCommands<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PathCoordType commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType* commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathCommands<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType* commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PathCoordType commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathCommandsNV", Convention = CallingConvention.Winapi)]
        public partial void PathCommands<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PathCoordType commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathCoordsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathCoords([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathCoordsNV", Convention = CallingConvention.Winapi)]
        public partial void PathCoords<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathCoordsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathCoords([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathCoordsNV", Convention = CallingConvention.Winapi)]
        public partial void PathCoords<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathCoverDepthFuncNV", Convention = CallingConvention.Winapi)]
        public partial void PathCoverDepthFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV func);

        [NativeApi(EntryPoint = "glPathCoverDepthFuncNV", Convention = CallingConvention.Winapi)]
        public partial void PathCoverDepthFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] DepthFunction func);

        [NativeApi(EntryPoint = "glPathDashArrayNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathDashArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dashCount, [Count(Parameter = "dashCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashArray);

        [NativeApi(EntryPoint = "glPathDashArrayNV", Convention = CallingConvention.Winapi)]
        public partial void PathDashArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dashCount, [Count(Parameter = "dashCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float dashArray);

        [NativeApi(EntryPoint = "glPathFogGenNV", Convention = CallingConvention.Winapi)]
        public partial void PathFogGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV genMode);

        [NativeApi(EntryPoint = "glPathFogGenNV", Convention = CallingConvention.Winapi)]
        public partial void PathFogGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode genMode);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T1 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T1 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T1 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T1 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T1 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T1 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T1 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T1 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T1 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T1 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T1 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T1 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T1 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T1 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T1 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyph<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphsNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyph<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType type, [Count(Computed = "numGlyphs, type, charcodes"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T1 charcodes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphIndexArrayNV", Convention = CallingConvention.Winapi)]
        public unsafe partial NV PathGlyphIndexArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyphIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphIndexArrayNV", Convention = CallingConvention.Winapi)]
        public partial NV PathGlyphIndexArray<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyphIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphIndexArrayNV", Convention = CallingConvention.Winapi)]
        public unsafe partial NV PathGlyphIndexArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyphIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphIndexArrayNV", Convention = CallingConvention.Winapi)]
        public partial NV PathGlyphIndexArray<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyphIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphIndexRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial NV PathGlyphIndexRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* baseAndCount);

        [NativeApi(EntryPoint = "glPathGlyphIndexRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial NV PathGlyphIndexRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint baseAndCount);

        [NativeApi(EntryPoint = "glPathGlyphIndexRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial NV PathGlyphIndexRange<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* baseAndCount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphIndexRangeNV", Convention = CallingConvention.Winapi)]
        public partial NV PathGlyphIndexRange<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint baseAndCount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphIndexRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial NV PathGlyphIndexRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* baseAndCount);

        [NativeApi(EntryPoint = "glPathGlyphIndexRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial NV PathGlyphIndexRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint baseAndCount);

        [NativeApi(EntryPoint = "glPathGlyphIndexRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial NV PathGlyphIndexRange<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* baseAndCount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphIndexRangeNV", Convention = CallingConvention.Winapi)]
        public partial NV PathGlyphIndexRange<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint baseAndCount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyphRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyph, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyphRange<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyph, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyphRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyph, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyphRange<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyph, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyphRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyph, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyphRange<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyph, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyphRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyph, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyphRange<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyph, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyphRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyph, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyphRange<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyph, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyphRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyph, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyphRange<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyph, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyphRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyph, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyphRange<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyph, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathGlyphRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyph, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathGlyphRangeNV", Convention = CallingConvention.Winapi)]
        public partial void PathGlyphRange<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontTarget fontTarget, [Count(Computed = "fontTarget, fontName"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFontStyle fontStyle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyph, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathHandleMissingGlyphs handleMissingGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathMemoryGlyphIndexArrayNV", Convention = CallingConvention.Winapi)]
        public unsafe partial NV PathMemoryGlyphIndexArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint faceIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyphIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale);

        [NativeApi(EntryPoint = "glPathMemoryGlyphIndexArrayNV", Convention = CallingConvention.Winapi)]
        public partial NV PathMemoryGlyphIndexArray<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fontTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint faceIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstGlyphIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numGlyphs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathParameterTemplate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float emScale) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glPathParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void PathParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int value);

        [NativeApi(EntryPoint = "glPathParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glPathParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void PathParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int value);

        [NativeApi(EntryPoint = "glPathParameteriNV", Convention = CallingConvention.Winapi)]
        public partial void PathParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glPathParameteriNV", Convention = CallingConvention.Winapi)]
        public partial void PathParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glPathParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glPathParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void PathParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float value);

        [NativeApi(EntryPoint = "glPathParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glPathParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void PathParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float value);

        [NativeApi(EntryPoint = "glPathParameterfNV", Convention = CallingConvention.Winapi)]
        public partial void PathParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float value);

        [NativeApi(EntryPoint = "glPathParameterfNV", Convention = CallingConvention.Winapi)]
        public partial void PathParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float value);

        [NativeApi(EntryPoint = "glPathStencilDepthOffsetNV", Convention = CallingConvention.Winapi)]
        public partial void PathStencilDepthOffset([Flow(Silk.NET.Core.Native.FlowDirection.In)] float factor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float units);

        [NativeApi(EntryPoint = "glPathStencilFuncNV", Convention = CallingConvention.Winapi)]
        public partial void PathStencilFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV func, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int @ref, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glPathStencilFuncNV", Convention = CallingConvention.Winapi)]
        public partial void PathStencilFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] StencilFunction func, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int @ref, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glPathStringNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pathString);

        [NativeApi(EntryPoint = "glPathStringNV", Convention = CallingConvention.Winapi)]
        public partial void PathString<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pathString) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathStringNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathStringFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pathString);

        [NativeApi(EntryPoint = "glPathStringNV", Convention = CallingConvention.Winapi)]
        public partial void PathString<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathStringFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pathString) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathSubCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathSubCommands<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathSubCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public partial void PathSubCommands<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathSubCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public partial void PathSubCommands<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathSubCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathSubCommands<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathSubCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public partial void PathSubCommands<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathSubCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public partial void PathSubCommands<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathSubCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType* commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathSubCommands<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType* commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathSubCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PathCoordType commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public partial void PathSubCommands<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PathCoordType commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathSubCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType* commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathSubCommands<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType* commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathSubCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PathCoordType commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathSubCommandsNV", Convention = CallingConvention.Winapi)]
        public partial void PathSubCommands<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCommands, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PathCoordType commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathSubCoordsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathSubCoords([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coordStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathSubCoordsNV", Convention = CallingConvention.Winapi)]
        public partial void PathSubCoords<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coordStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathSubCoordsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathSubCoords([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coordStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords);

        [NativeApi(EntryPoint = "glPathSubCoordsNV", Convention = CallingConvention.Winapi)]
        public partial void PathSubCoords<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coordStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPathTexGenNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV texCoordSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV genMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int components, [Count(Computed = "genMode, components"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* coeffs);

        [NativeApi(EntryPoint = "glPathTexGenNV", Convention = CallingConvention.Winapi)]
        public partial void PathTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV texCoordSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV genMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int components, [Count(Computed = "genMode, components"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float coeffs);

        [NativeApi(EntryPoint = "glPathTexGenNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV texCoordSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode genMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int components, [Count(Computed = "genMode, components"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* coeffs);

        [NativeApi(EntryPoint = "glPathTexGenNV", Convention = CallingConvention.Winapi)]
        public partial void PathTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV texCoordSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode genMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int components, [Count(Computed = "genMode, components"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float coeffs);

        [NativeApi(EntryPoint = "glPathTexGenNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathColor texCoordSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV genMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int components, [Count(Computed = "genMode, components"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* coeffs);

        [NativeApi(EntryPoint = "glPathTexGenNV", Convention = CallingConvention.Winapi)]
        public partial void PathTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathColor texCoordSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV genMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int components, [Count(Computed = "genMode, components"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float coeffs);

        [NativeApi(EntryPoint = "glPathTexGenNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PathTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathColor texCoordSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode genMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int components, [Count(Computed = "genMode, components"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* coeffs);

        [NativeApi(EntryPoint = "glPathTexGenNV", Convention = CallingConvention.Winapi)]
        public partial void PathTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathColor texCoordSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode genMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int components, [Count(Computed = "genMode, components"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float coeffs);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool PointAlongPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool PointAlongPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool PointAlongPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool PointAlongPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool PointAlongPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool PointAlongPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool PointAlongPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool PointAlongPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool PointAlongPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool PointAlongPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool PointAlongPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool PointAlongPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool PointAlongPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool PointAlongPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial bool PointAlongPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* tangentY);

        [NativeApi(EntryPoint = "glPointAlongPathNV", Convention = CallingConvention.Winapi)]
        public partial bool PointAlongPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint startSegment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSegments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float distance, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float x, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float y, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float tangentX, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float tangentY);

        [NativeApi(EntryPoint = "glProgramPathFragmentInputGenNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramPathFragmentInputGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV genMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int components, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* coeffs);

        [NativeApi(EntryPoint = "glProgramPathFragmentInputGenNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramPathFragmentInputGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV genMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int components, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float coeffs);

        [NativeApi(EntryPoint = "glStencilFillPathNV", Convention = CallingConvention.Winapi)]
        public partial void StencilFillPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilFillPathNV", Convention = CallingConvention.Winapi)]
        public partial void StencilFillPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilStrokePathNV", Convention = CallingConvention.Winapi)]
        public partial void StencilStrokePath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverFillPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverFillPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoverMode coverMode);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverFillPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverFillPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoverMode coverMode);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverFillPathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverFillPathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathFillMode fillMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverStrokePath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode);

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverStrokePath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoverMode coverMode);

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverStrokePathInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void StencilThenCoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilThenCoverStrokePathInstancedNV", Convention = CallingConvention.Winapi)]
        public partial void StencilThenCoverStrokePathInstanced<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int reference, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InstancedPathCoverMode coverMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "numPaths, transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTransformPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint resultPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint srcPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glTransformPathNV", Convention = CallingConvention.Winapi)]
        public partial void TransformPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint resultPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint srcPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType, [Count(Computed = "transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glTransformPathNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint resultPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint srcPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* transformValues);

        [NativeApi(EntryPoint = "glTransformPathNV", Convention = CallingConvention.Winapi)]
        public partial void TransformPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint resultPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint srcPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType, [Count(Computed = "transformType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float transformValues);

        [NativeApi(EntryPoint = "glWeightPathsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void WeightPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint resultPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Count(Parameter = "numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* paths, [Count(Parameter = "numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* weights);

        [NativeApi(EntryPoint = "glWeightPathsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void WeightPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint resultPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Count(Parameter = "numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* paths, [Count(Parameter = "numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float weights);

        [NativeApi(EntryPoint = "glWeightPathsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void WeightPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint resultPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Count(Parameter = "numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint paths, [Count(Parameter = "numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* weights);

        [NativeApi(EntryPoint = "glWeightPathsNV", Convention = CallingConvention.Winapi)]
        public partial void WeightPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint resultPath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Count(Parameter = "numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint paths, [Count(Parameter = "numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float weights);

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

        public unsafe void GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV* props, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, propCount, props, (uint) @params.Length, length, out @params.GetPinnableReference());
        }

        public unsafe void GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV* props, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, propCount, props, (uint) @params.Length, out length, out @params.GetPinnableReference());
        }

        public unsafe void GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly NV props, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, propCount, in props, (uint) @params.Length, length, out @params.GetPinnableReference());
        }

        public unsafe void GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly NV props, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, propCount, in props, (uint) @params.Length, out length, out @params.GetPinnableReference());
        }

        public unsafe void GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV* props, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, propCount, props, (uint) @params.Length, length, out @params.GetPinnableReference());
        }

        public unsafe void GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV* props, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, propCount, props, (uint) @params.Length, out length, out @params.GetPinnableReference());
        }

        public unsafe void GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly NV props, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, propCount, in props, (uint) @params.Length, length, out @params.GetPinnableReference());
        }

        public unsafe void GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly NV props, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // ImplicitCountSpanOverloader
            GetProgramResource(program, programInterface, index, propCount, in props, (uint) @params.Length, out length, out @params.GetPinnableReference());
        }

        public unsafe void PathCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords)
        {
            // ImplicitCountSpanOverloader
            PathCommands(path, (uint) commands.Length, in commands.GetPinnableReference(), numCoords, coordType, coords);
        }

        public unsafe void PathCommands<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            PathCommands(path, (uint) commands.Length, in commands.GetPinnableReference(), numCoords, coordType, in coords);
        }

        public unsafe void PathCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords)
        {
            // ImplicitCountSpanOverloader
            PathCommands(path, (uint) commands.Length, in commands.GetPinnableReference(), numCoords, coordType, coords);
        }

        public unsafe void PathCommands<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            PathCommands(path, (uint) commands.Length, in commands.GetPinnableReference(), numCoords, coordType, in coords);
        }

        public unsafe void PathCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PathCoordType> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords)
        {
            // ImplicitCountSpanOverloader
            PathCommands(path, (uint) commands.Length, in commands.GetPinnableReference(), numCoords, coordType, coords);
        }

        public unsafe void PathCommands<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PathCoordType> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            PathCommands(path, (uint) commands.Length, in commands.GetPinnableReference(), numCoords, coordType, in coords);
        }

        public unsafe void PathCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PathCoordType> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords)
        {
            // ImplicitCountSpanOverloader
            PathCommands(path, (uint) commands.Length, in commands.GetPinnableReference(), numCoords, coordType, coords);
        }

        public unsafe void PathCommands<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PathCoordType> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            PathCommands(path, (uint) commands.Length, in commands.GetPinnableReference(), numCoords, coordType, in coords);
        }

        public unsafe void PathDashArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Count(Parameter = "dashCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> dashArray)
        {
            // ImplicitCountSpanOverloader
            PathDashArray(path, (uint) dashArray.Length, in dashArray.GetPinnableReference());
        }

        public unsafe void PathString<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV format, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pathString) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            PathString(path, format, (uint) ((pathString.Length) * Unsafe.SizeOf<T0>()), in pathString.GetPinnableReference());
        }

        public unsafe void PathString<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathStringFormat format, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pathString) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            PathString(path, format, (uint) ((pathString.Length) * Unsafe.SizeOf<T0>()), in pathString.GetPinnableReference());
        }

        public unsafe void PathSubCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords)
        {
            // ImplicitCountSpanOverloader
            PathSubCommands(path, commandStart, commandsToDelete, (uint) commands.Length, in commands.GetPinnableReference(), numCoords, coordType, coords);
        }

        public unsafe void PathSubCommands<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            PathSubCommands(path, commandStart, commandsToDelete, (uint) commands.Length, in commands.GetPinnableReference(), numCoords, coordType, in coords);
        }

        public unsafe void PathSubCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords)
        {
            // ImplicitCountSpanOverloader
            PathSubCommands(path, commandStart, commandsToDelete, (uint) commands.Length, in commands.GetPinnableReference(), numCoords, coordType, coords);
        }

        public unsafe void PathSubCommands<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            PathSubCommands(path, commandStart, commandsToDelete, (uint) commands.Length, in commands.GetPinnableReference(), numCoords, coordType, in coords);
        }

        public unsafe void PathSubCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PathCoordType> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords)
        {
            // ImplicitCountSpanOverloader
            PathSubCommands(path, commandStart, commandsToDelete, (uint) commands.Length, in commands.GetPinnableReference(), numCoords, coordType, coords);
        }

        public unsafe void PathSubCommands<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PathCoordType> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            PathSubCommands(path, commandStart, commandsToDelete, (uint) commands.Length, in commands.GetPinnableReference(), numCoords, coordType, in coords);
        }

        public unsafe void PathSubCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PathCoordType> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* coords)
        {
            // ImplicitCountSpanOverloader
            PathSubCommands(path, commandStart, commandsToDelete, (uint) commands.Length, in commands.GetPinnableReference(), numCoords, coordType, coords);
        }

        public unsafe void PathSubCommands<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint commandsToDelete, [Count(Parameter = "numCommands"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PathCoordType> commands, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numCoords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathCoordType coordType, [Count(Computed = "numCoords, coordType"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 coords) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            PathSubCommands(path, commandStart, commandsToDelete, (uint) commands.Length, in commands.GetPinnableReference(), numCoords, coordType, in coords);
        }

        public unsafe void WeightPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint resultPath, [Count(Parameter = "numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* paths, [Count(Parameter = "numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> weights)
        {
            // ImplicitCountSpanOverloader
            WeightPath(resultPath, (uint) weights.Length, paths, in weights.GetPinnableReference());
        }

        public unsafe void WeightPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint resultPath, [Count(Parameter = "numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> paths, [Count(Parameter = "numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* weights)
        {
            // ImplicitCountSpanOverloader
            WeightPath(resultPath, (uint) paths.Length, in paths.GetPinnableReference(), weights);
        }

        public unsafe void WeightPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint resultPath, [Count(Parameter = "numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> paths, [Count(Parameter = "numPaths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> weights)
        {
            // ImplicitCountSpanOverloader
            WeightPath(resultPath, (uint) weights.Length, in paths.GetPinnableReference(), in weights.GetPinnableReference());
        }

        public unsafe int GetPathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname)
        {
            // NonKhrReturnTypeOverloader
            GetPathColorGen(color, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetPathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode pname)
        {
            // NonKhrReturnTypeOverloader
            GetPathColorGen(color, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetPathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathColor color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname)
        {
            // NonKhrReturnTypeOverloader
            GetPathColorGen(color, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetPathColorGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathColor color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode pname)
        {
            // NonKhrReturnTypeOverloader
            GetPathColorGen(color, pname, out int silkRet);
            return silkRet;
        }

        public unsafe byte GetPathCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path)
        {
            // NonKhrReturnTypeOverloader
            GetPathCommands(path, out byte silkRet);
            return silkRet;
        }

        public unsafe float GetPathCoords([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path)
        {
            // NonKhrReturnTypeOverloader
            GetPathCoords(path, out float silkRet);
            return silkRet;
        }

        public unsafe float GetPathDashArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path)
        {
            // NonKhrReturnTypeOverloader
            GetPathDashArray(path, out float silkRet);
            return silkRet;
        }

        public unsafe float GetPathMetric([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride)
        {
            // NonKhrReturnTypeOverloader
            GetPathMetric(metricQueryMask, numPaths, pathNameType, paths, pathBase, stride, out float silkRet);
            return silkRet;
        }

        public unsafe float GetPathMetric<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetPathMetric(metricQueryMask, numPaths, pathNameType, in paths, pathBase, stride, out float silkRet);
            return silkRet;
        }

        public unsafe float GetPathMetric([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride)
        {
            // NonKhrReturnTypeOverloader
            GetPathMetric(metricQueryMask, numPaths, pathNameType, paths, pathBase, stride, out float silkRet);
            return silkRet;
        }

        public unsafe float GetPathMetric<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetPathMetric(metricQueryMask, numPaths, pathNameType, in paths, pathBase, stride, out float silkRet);
            return silkRet;
        }

        public unsafe float GetPathMetric([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride)
        {
            // NonKhrReturnTypeOverloader
            GetPathMetric(metricQueryMask, numPaths, pathNameType, paths, pathBase, stride, out float silkRet);
            return silkRet;
        }

        public unsafe float GetPathMetric<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetPathMetric(metricQueryMask, numPaths, pathNameType, in paths, pathBase, stride, out float silkRet);
            return silkRet;
        }

        public unsafe float GetPathMetric([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride)
        {
            // NonKhrReturnTypeOverloader
            GetPathMetric(metricQueryMask, numPaths, pathNameType, paths, pathBase, stride, out float silkRet);
            return silkRet;
        }

        public unsafe float GetPathMetric<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetPathMetric(metricQueryMask, numPaths, pathNameType, in paths, pathBase, stride, out float silkRet);
            return silkRet;
        }

        public unsafe float GetPathMetricRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride)
        {
            // NonKhrReturnTypeOverloader
            GetPathMetricRange(metricQueryMask, firstPathName, numPaths, stride, out float silkRet);
            return silkRet;
        }

        public unsafe float GetPathMetricRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathMetricMask metricQueryMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint firstPathName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride)
        {
            // NonKhrReturnTypeOverloader
            GetPathMetricRange(metricQueryMask, firstPathName, numPaths, stride, out float silkRet);
            return silkRet;
        }

        public unsafe int GetPathParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname)
        {
            // NonKhrReturnTypeOverloader
            GetPathParameter(path, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetPathParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathParameter pname)
        {
            // NonKhrReturnTypeOverloader
            GetPathParameter(path, pname, out int silkRet);
            return silkRet;
        }

        public unsafe float GetPathSpacing([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType)
        {
            // NonKhrReturnTypeOverloader
            GetPathSpacing(pathListMode, numPaths, pathNameType, paths, pathBase, advanceScale, kerningScale, transformType, out float silkRet);
            return silkRet;
        }

        public unsafe float GetPathSpacing<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetPathSpacing(pathListMode, numPaths, pathNameType, in paths, pathBase, advanceScale, kerningScale, transformType, out float silkRet);
            return silkRet;
        }

        public unsafe float GetPathSpacing([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType)
        {
            // NonKhrReturnTypeOverloader
            GetPathSpacing(pathListMode, numPaths, pathNameType, paths, pathBase, advanceScale, kerningScale, transformType, out float silkRet);
            return silkRet;
        }

        public unsafe float GetPathSpacing<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetPathSpacing(pathListMode, numPaths, pathNameType, in paths, pathBase, advanceScale, kerningScale, transformType, out float silkRet);
            return silkRet;
        }

        public unsafe float GetPathSpacing([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType)
        {
            // NonKhrReturnTypeOverloader
            GetPathSpacing(pathListMode, numPaths, pathNameType, paths, pathBase, advanceScale, kerningScale, transformType, out float silkRet);
            return silkRet;
        }

        public unsafe float GetPathSpacing<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetPathSpacing(pathListMode, numPaths, pathNameType, in paths, pathBase, advanceScale, kerningScale, transformType, out float silkRet);
            return silkRet;
        }

        public unsafe float GetPathSpacing([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType)
        {
            // NonKhrReturnTypeOverloader
            GetPathSpacing(pathListMode, numPaths, pathNameType, paths, pathBase, advanceScale, kerningScale, transformType, out float silkRet);
            return silkRet;
        }

        public unsafe float GetPathSpacing<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetPathSpacing(pathListMode, numPaths, pathNameType, in paths, pathBase, advanceScale, kerningScale, transformType, out float silkRet);
            return silkRet;
        }

        public unsafe float GetPathSpacing([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType)
        {
            // NonKhrReturnTypeOverloader
            GetPathSpacing(pathListMode, numPaths, pathNameType, paths, pathBase, advanceScale, kerningScale, transformType, out float silkRet);
            return silkRet;
        }

        public unsafe float GetPathSpacing<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetPathSpacing(pathListMode, numPaths, pathNameType, in paths, pathBase, advanceScale, kerningScale, transformType, out float silkRet);
            return silkRet;
        }

        public unsafe float GetPathSpacing([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType)
        {
            // NonKhrReturnTypeOverloader
            GetPathSpacing(pathListMode, numPaths, pathNameType, paths, pathBase, advanceScale, kerningScale, transformType, out float silkRet);
            return silkRet;
        }

        public unsafe float GetPathSpacing<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetPathSpacing(pathListMode, numPaths, pathNameType, in paths, pathBase, advanceScale, kerningScale, transformType, out float silkRet);
            return silkRet;
        }

        public unsafe float GetPathSpacing([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType)
        {
            // NonKhrReturnTypeOverloader
            GetPathSpacing(pathListMode, numPaths, pathNameType, paths, pathBase, advanceScale, kerningScale, transformType, out float silkRet);
            return silkRet;
        }

        public unsafe float GetPathSpacing<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV transformType) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetPathSpacing(pathListMode, numPaths, pathNameType, in paths, pathBase, advanceScale, kerningScale, transformType, out float silkRet);
            return silkRet;
        }

        public unsafe float GetPathSpacing([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType)
        {
            // NonKhrReturnTypeOverloader
            GetPathSpacing(pathListMode, numPaths, pathNameType, paths, pathBase, advanceScale, kerningScale, transformType, out float silkRet);
            return silkRet;
        }

        public unsafe float GetPathSpacing<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PathListMode pathListMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathElementType pathNameType, [Count(Computed = "numPaths, pathNameType, paths"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 paths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pathBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float advanceScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float kerningScale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathTransformType transformType) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetPathSpacing(pathListMode, numPaths, pathNameType, in paths, pathBase, advanceScale, kerningScale, transformType, out float silkRet);
            return silkRet;
        }

        public unsafe int GetPathTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV texCoordSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname)
        {
            // NonKhrReturnTypeOverloader
            GetPathTexGen(texCoordSet, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetPathTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV texCoordSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode pname)
        {
            // NonKhrReturnTypeOverloader
            GetPathTexGen(texCoordSet, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetPathTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texCoordSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname)
        {
            // NonKhrReturnTypeOverloader
            GetPathTexGen(texCoordSet, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetPathTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texCoordSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PathGenMode pname)
        {
            // NonKhrReturnTypeOverloader
            GetPathTexGen(texCoordSet, pname, out int silkRet);
            return silkRet;
        }

        public unsafe float GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length)
        {
            // NonKhrReturnTypeOverloader
            GetProgramResource(program, programInterface, index, propCount, props, count, length, out float silkRet);
            return silkRet;
        }

        public unsafe float GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length)
        {
            // NonKhrReturnTypeOverloader
            GetProgramResource(program, programInterface, index, propCount, props, count, out length, out float silkRet);
            return silkRet;
        }

        public unsafe float GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly NV props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length)
        {
            // NonKhrReturnTypeOverloader
            GetProgramResource(program, programInterface, index, propCount, in props, count, length, out float silkRet);
            return silkRet;
        }

        public unsafe float GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly NV props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length)
        {
            // NonKhrReturnTypeOverloader
            GetProgramResource(program, programInterface, index, propCount, in props, count, out length, out float silkRet);
            return silkRet;
        }

        public unsafe float GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length)
        {
            // NonKhrReturnTypeOverloader
            GetProgramResource(program, programInterface, index, propCount, props, count, length, out float silkRet);
            return silkRet;
        }

        public unsafe float GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length)
        {
            // NonKhrReturnTypeOverloader
            GetProgramResource(program, programInterface, index, propCount, props, count, out length, out float silkRet);
            return silkRet;
        }

        public unsafe float GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly NV props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length)
        {
            // NonKhrReturnTypeOverloader
            GetProgramResource(program, programInterface, index, propCount, in props, count, length, out float silkRet);
            return silkRet;
        }

        public unsafe float GetProgramResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly NV props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length)
        {
            // NonKhrReturnTypeOverloader
            GetProgramResource(program, programInterface, index, propCount, in props, count, out length, out float silkRet);
            return silkRet;
        }

        public NVPathRendering(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

