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
    [Extension("ARB_indirect_parameters")]
    public unsafe partial class ArbIndirectParameters : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_indirect_parameters";
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectCountARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawArraysIndirectCount([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxdrawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectCountARB", Convention = CallingConvention.Winapi)]
        public partial void MultiDrawArraysIndirectCount<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxdrawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectCountARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawArraysIndirectCount([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxdrawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectCountARB", Convention = CallingConvention.Winapi)]
        public partial void MultiDrawArraysIndirectCount<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxdrawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectCountARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsIndirectCount([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxdrawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectCountARB", Convention = CallingConvention.Winapi)]
        public partial void MultiDrawElementsIndirectCount<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxdrawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectCountARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsIndirectCount([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxdrawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectCountARB", Convention = CallingConvention.Winapi)]
        public partial void MultiDrawElementsIndirectCount<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxdrawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectCountARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsIndirectCount([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxdrawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectCountARB", Convention = CallingConvention.Winapi)]
        public partial void MultiDrawElementsIndirectCount<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxdrawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectCountARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsIndirectCount([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxdrawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectCountARB", Convention = CallingConvention.Winapi)]
        public partial void MultiDrawElementsIndirectCount<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxdrawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride) where T0 : unmanaged;

        public ArbIndirectParameters(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

