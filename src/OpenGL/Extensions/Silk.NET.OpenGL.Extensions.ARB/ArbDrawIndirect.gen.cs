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

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_draw_indirect")]
    public unsafe partial class ArbDrawIndirect : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_draw_indirect";
        [NativeApi(EntryPoint = "glDrawArraysIndirect", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawArraysIndirect([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indirect);

        [NativeApi(EntryPoint = "glDrawArraysIndirect", Convention = CallingConvention.Winapi)]
        public partial void DrawArraysIndirect<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indirect) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawArraysIndirect", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawArraysIndirect([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indirect);

        [NativeApi(EntryPoint = "glDrawArraysIndirect", Convention = CallingConvention.Winapi)]
        public partial void DrawArraysIndirect<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indirect) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsIndirect", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsIndirect([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indirect);

        [NativeApi(EntryPoint = "glDrawElementsIndirect", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsIndirect<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indirect) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsIndirect", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsIndirect([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indirect);

        [NativeApi(EntryPoint = "glDrawElementsIndirect", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsIndirect<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indirect) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsIndirect", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsIndirect([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indirect);

        [NativeApi(EntryPoint = "glDrawElementsIndirect", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsIndirect<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indirect) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsIndirect", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsIndirect([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indirect);

        [NativeApi(EntryPoint = "glDrawElementsIndirect", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsIndirect<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indirect) where T0 : unmanaged;

        public ArbDrawIndirect(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

