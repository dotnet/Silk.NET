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

namespace Silk.NET.OpenXR.Extensions.EXT
{
    [Extension("XR_EXT_future")]
    public unsafe partial class ExtFuture : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_EXT_future";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCancelFutureEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CancelFuture([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FutureCancelInfoEXT* cancelInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCancelFutureEXT", Convention = CallingConvention.Winapi)]
        public partial Result CancelFuture([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FutureCancelInfoEXT cancelInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPollFutureEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result PollFuture([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FuturePollInfoEXT* pollInfo, [Count(Count = 0)] FuturePollResultEXT* pollResult);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPollFutureEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result PollFuture([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FuturePollInfoEXT* pollInfo, [Count(Count = 0)] ref FuturePollResultEXT pollResult);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPollFutureEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result PollFuture([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FuturePollInfoEXT pollInfo, [Count(Count = 0)] FuturePollResultEXT* pollResult);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPollFutureEXT", Convention = CallingConvention.Winapi)]
        public partial Result PollFuture([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FuturePollInfoEXT pollInfo, [Count(Count = 0)] ref FuturePollResultEXT pollResult);

        public ExtFuture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

