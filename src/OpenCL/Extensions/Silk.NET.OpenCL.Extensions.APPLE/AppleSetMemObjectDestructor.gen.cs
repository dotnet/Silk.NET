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
using Silk.NET.OpenCL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.APPLE
{
    [Extension("APPLE_SetMemObjectDestructor")]
    public unsafe partial class AppleSetMemObjectDestructor : NativeExtension<CL>
    {
        public const string ExtensionName = "APPLE_SetMemObjectDestructor";
        [NativeApi(EntryPoint = "clSetMemObjectDestructorAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial int SetMemObjectDestructor([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint memobj, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] ObjectNotifyCallback pfn_notify, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clSetMemObjectDestructorAPPLE", Convention = CallingConvention.Winapi)]
        public partial int SetMemObjectDestructor<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint memobj, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] ObjectNotifyCallback pfn_notify, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        public AppleSetMemObjectDestructor(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

