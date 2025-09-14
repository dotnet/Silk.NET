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
    [Extension("ARB_multi_draw_indirect")]
    public unsafe partial class ArbMultiDrawIndirect : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_multi_draw_indirect";
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirect", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawArraysIndirect([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB mode, [Count(Computed = "drawcount, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirect", Convention = CallingConvention.Winapi)]
        public partial void MultiDrawArraysIndirect<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB mode, [Count(Computed = "drawcount, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirect", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawArraysIndirect([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirect", Convention = CallingConvention.Winapi)]
        public partial void MultiDrawArraysIndirect<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirect", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsIndirect([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "drawcount, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirect", Convention = CallingConvention.Winapi)]
        public partial void MultiDrawElementsIndirect<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "drawcount, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirect", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsIndirect([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirect", Convention = CallingConvention.Winapi)]
        public partial void MultiDrawElementsIndirect<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirect", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsIndirect([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "drawcount, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirect", Convention = CallingConvention.Winapi)]
        public partial void MultiDrawElementsIndirect<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "drawcount, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirect", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsIndirect([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirect", Convention = CallingConvention.Winapi)]
        public partial void MultiDrawElementsIndirect<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride) where T0 : unmanaged;

        public ArbMultiDrawIndirect(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

