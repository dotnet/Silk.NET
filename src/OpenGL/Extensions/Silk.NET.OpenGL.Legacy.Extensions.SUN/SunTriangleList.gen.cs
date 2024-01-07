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
    [Extension("SUN_triangle_list")]
    public unsafe partial class SunTriangleList : NativeExtension<GL>
    {
        public const string ExtensionName = "SUN_triangle_list";
        [NativeApi(EntryPoint = "glReplacementCodeuiSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCode([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint code);

        [NativeApi(EntryPoint = "glReplacementCodeuiSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCode([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN code);

        [NativeApi(EntryPoint = "glReplacementCodeusSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCode([Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort code);

        [NativeApi(EntryPoint = "glReplacementCodeubSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCode([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte code);

        [NativeApi(EntryPoint = "glReplacementCodeuivSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCode([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* code);

        [NativeApi(EntryPoint = "glReplacementCodeuivSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCode([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint code);

        [NativeApi(EntryPoint = "glReplacementCodeuivSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCode([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* code);

        [NativeApi(EntryPoint = "glReplacementCodeuivSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCode([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TriangleListSUN code);

        [NativeApi(EntryPoint = "glReplacementCodeusvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCode([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* code);

        [NativeApi(EntryPoint = "glReplacementCodeusvSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCode([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort code);

        [NativeApi(EntryPoint = "glReplacementCodeubvSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCode([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* code);

        [NativeApi(EntryPoint = "glReplacementCodeubvSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCode([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte code);

        [NativeApi(EntryPoint = "glReplacementCodeubvSUN", Convention = CallingConvention.Winapi)]
        public partial void ReplacementCode([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string code);

        [NativeApi(EntryPoint = "glReplacementCodePointerSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodePointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] SUN type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** pointer);

        [NativeApi(EntryPoint = "glReplacementCodePointerSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodePointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] SUN type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* pointer);

        [NativeApi(EntryPoint = "glReplacementCodePointerSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodePointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReplacementCodeTypeSUN type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** pointer);

        [NativeApi(EntryPoint = "glReplacementCodePointerSUN", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReplacementCodePointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReplacementCodeTypeSUN type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* pointer);

        public SunTriangleList(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

