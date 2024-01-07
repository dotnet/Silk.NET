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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_draw_range_elements")]
    public unsafe partial class ExtDrawRangeElements : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_draw_range_elements";
        [NativeApi(EntryPoint = "glDrawRangeElementsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawRangeElements([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices);

        [NativeApi(EntryPoint = "glDrawRangeElementsEXT", Convention = CallingConvention.Winapi)]
        public partial void DrawRangeElements<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElementsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawRangeElements([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices);

        [NativeApi(EntryPoint = "glDrawRangeElementsEXT", Convention = CallingConvention.Winapi)]
        public partial void DrawRangeElements<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElementsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawRangeElements([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices);

        [NativeApi(EntryPoint = "glDrawRangeElementsEXT", Convention = CallingConvention.Winapi)]
        public partial void DrawRangeElements<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElementsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawRangeElements([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices);

        [NativeApi(EntryPoint = "glDrawRangeElementsEXT", Convention = CallingConvention.Winapi)]
        public partial void DrawRangeElements<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indices) where T0 : unmanaged;

        public ExtDrawRangeElements(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

