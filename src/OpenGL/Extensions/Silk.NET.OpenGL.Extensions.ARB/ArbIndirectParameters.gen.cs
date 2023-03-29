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
        public unsafe partial void MultiDrawArraysIndirectCount([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] nint drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectCountARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawArraysIndirectCount([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] nint drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectCountARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsIndirectCount([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] nint drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectCountARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsIndirectCount([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] nint drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectCountARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsIndirectCount([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] nint drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectCountARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsIndirectCount([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] nint drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride);

        public ArbIndirectParameters(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

