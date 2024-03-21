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

namespace Silk.NET.OpenGL.Legacy.Extensions.SUN
{
    [Extension("SUN_vertex")]
    public unsafe partial class SunVertex : NativeExtension<GL>
    {
        public const string ExtensionName = "SUN_vertex";
        [NativeApi(EntryPoint = "glColor3fVertex3fSUN", Convention = CallingConvention.Winapi)]
        public partial void Color3fVertex3([Flow(Silk.NET.Core.Native.FlowDirection.In)] float r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float g, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float b, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glColor3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void Color3fVertex3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glColor3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void Color3fVertex3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glColor3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void Color3fVertex3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glColor3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public partial void Color3fVertex3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glColor4fNormal3fVertex3fSUN", Convention = CallingConvention.Winapi)]
        public partial void Color4fNormal3fVertex3([Flow(Silk.NET.Core.Native.FlowDirection.In)] float r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float g, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float b, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float nx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float ny, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float nz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void Color4fNormal3fVertex3([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void Color4fNormal3fVertex3([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void Color4fNormal3fVertex3([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void Color4fNormal3fVertex3([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void Color4fNormal3fVertex3([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void Color4fNormal3fVertex3([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void Color4fNormal3fVertex3([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public partial void Color4fNormal3fVertex3([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glColor4ubVertex2fSUN", Convention = CallingConvention.Winapi)]
        public partial void Color4ubVertex2([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte g, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte b, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y);

        [NativeApi(EntryPoint = "glColor4ubVertex2fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void Color4ubVertex2([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* c, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glColor4ubVertex2fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void Color4ubVertex2([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* c, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glColor4ubVertex2fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void Color4ubVertex2([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte c, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glColor4ubVertex2fvSUN", Convention = CallingConvention.Winapi)]
        public partial void Color4ubVertex2([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte c, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glColor4ubVertex2fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void Color4ubVertex2([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string c, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glColor4ubVertex2fvSUN", Convention = CallingConvention.Winapi)]
        public partial void Color4ubVertex2([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string c, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glColor4ubVertex3fSUN", Convention = CallingConvention.Winapi)]
        public partial void Color4ubVertex3([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte g, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte b, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void Color4ubVertex3([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void Color4ubVertex3([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void Color4ubVertex3([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public partial void Color4ubVertex3([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void Color4ubVertex3([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public partial void Color4ubVertex3([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glNormal3fVertex3fSUN", Convention = CallingConvention.Winapi)]
        public partial void Normal3fVertex3([Flow(Silk.NET.Core.Native.FlowDirection.In)] float nx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float ny, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float nz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void Normal3fVertex3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void Normal3fVertex3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void Normal3fVertex3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public partial void Normal3fVertex3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor3fVertex3fSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiColor3fVertex3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float g, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float b, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor3fVertex3fSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiColor3fVertex3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN rc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float g, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float b, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiColor3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiColor3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiColor4fNormal3fVertex3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float g, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float b, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float nx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float ny, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float nz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiColor4fNormal3fVertex3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN rc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float g, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float b, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float nx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float ny, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float nz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiColor4ubVertex3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte g, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte b, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiColor4ubVertex3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN rc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte g, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte b, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiNormal3fVertex3fSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiNormal3fVertex3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float nx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float ny, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float nz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glReplacementCodeuiNormal3fVertex3fSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiNormal3fVertex3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN rc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float nx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float ny, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float nz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float g, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float b, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float nx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float ny, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float nz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN rc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float g, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float b, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float nx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float ny, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float nz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float nx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float ny, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float nz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN rc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float nx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float ny, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float nz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiTexCoord2fVertex3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiTexCoord2fVertex3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN rc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiTexCoord2fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiTexCoord2fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiTexCoord2fVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiVertex3fSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiVertex3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glReplacementCodeuiVertex3fSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiVertex3([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN rc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glReplacementCodeuiVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodeuiVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCodeuiVertex3([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor3fVertex3fSUN", Convention = CallingConvention.Winapi)]
        public partial void TexCoord2fColor3fVertex3([Flow(Silk.NET.Core.Native.FlowDirection.In)] float s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float g, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float b, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glTexCoord2fColor3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public partial void TexCoord2fColor3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fSUN", Convention = CallingConvention.Winapi)]
        public partial void TexCoord2fColor4fNormal3fVertex3([Flow(Silk.NET.Core.Native.FlowDirection.In)] float s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float g, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float b, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float nx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float ny, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float nz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fSUN", Convention = CallingConvention.Winapi)]
        public partial void TexCoord2fColor4ubVertex3([Flow(Silk.NET.Core.Native.FlowDirection.In)] float s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte g, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte b, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor4ubVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor4ubVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor4ubVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor4ubVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor4ubVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor4ubVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor4ubVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor4ubVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor4ubVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public partial void TexCoord2fColor4ubVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fColor4ubVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public partial void TexCoord2fColor4ubVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fNormal3fVertex3fSUN", Convention = CallingConvention.Winapi)]
        public partial void TexCoord2fNormal3fVertex3([Flow(Silk.NET.Core.Native.FlowDirection.In)] float s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float nx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float ny, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float nz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fNormal3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fNormal3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fNormal3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fNormal3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fNormal3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fNormal3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fNormal3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fNormal3fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public partial void TexCoord2fNormal3fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fVertex3fSUN", Convention = CallingConvention.Winapi)]
        public partial void TexCoord2fVertex3([Flow(Silk.NET.Core.Native.FlowDirection.In)] float s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glTexCoord2fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord2fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fVertex3fvSUN", Convention = CallingConvention.Winapi)]
        public partial void TexCoord2fVertex3([Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fSUN", Convention = CallingConvention.Winapi)]
        public partial void TexCoord4fColor4fNormal3fVertex4([Flow(Silk.NET.Core.Native.FlowDirection.In)] float s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float p, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float q, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float g, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float b, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float nx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float ny, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float nz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN", Convention = CallingConvention.Winapi)]
        public partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord4fVertex4fSUN", Convention = CallingConvention.Winapi)]
        public partial void TexCoord4fVertex4([Flow(Silk.NET.Core.Native.FlowDirection.In)] float s, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float p, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float q, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glTexCoord4fVertex4fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord4fVertex4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord4fVertex4fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord4fVertex4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTexCoord4fVertex4fvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoord4fVertex4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord4fVertex4fvSUN", Convention = CallingConvention.Winapi)]
        public partial void TexCoord4fVertex4([Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        public SunVertex(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

