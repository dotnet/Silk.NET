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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_draw_indirect")]
    public unsafe partial class ArbDrawIndirect : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_draw_indirect";
        [NativeApi(EntryPoint = "glDrawArraysIndirect", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawArraysIndirect([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] void* indirect);

        [NativeApi(EntryPoint = "glDrawArraysIndirect", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawArraysIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] void* indirect);

        [NativeApi(EntryPoint = "glDrawElementsIndirect", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsIndirect([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] void* indirect);

        [NativeApi(EntryPoint = "glDrawElementsIndirect", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsIndirect([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] void* indirect);

        [NativeApi(EntryPoint = "glDrawElementsIndirect", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] void* indirect);

        [NativeApi(EntryPoint = "glDrawElementsIndirect", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] void* indirect);

        public ArbDrawIndirect(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

