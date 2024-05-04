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
using Silk.NET.OpenXR;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.HTC
{
    [Extension("XR_HTC_passthrough")]
    public unsafe partial class HtcPassthrough : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_HTC_passthrough";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreatePassthroughHTC", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreatePassthroughHtc([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PassthroughCreateInfoHTC* createInfo, [Count(Count = 0)] PassthroughHTC* passthrough);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreatePassthroughHTC", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreatePassthroughHtc([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PassthroughCreateInfoHTC* createInfo, [Count(Count = 0)] ref PassthroughHTC passthrough);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreatePassthroughHTC", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreatePassthroughHtc([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PassthroughCreateInfoHTC createInfo, [Count(Count = 0)] PassthroughHTC* passthrough);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreatePassthroughHTC", Convention = CallingConvention.Winapi)]
        public partial Result CreatePassthroughHtc([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PassthroughCreateInfoHTC createInfo, [Count(Count = 0)] ref PassthroughHTC passthrough);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyPassthroughHTC", Convention = CallingConvention.Winapi)]
        public partial Result DestroyPassthroughHtc([Count(Count = 0)] PassthroughHTC passthrough);

        public HtcPassthrough(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

