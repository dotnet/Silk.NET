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
    [Extension("XR_HTC_foveation")]
    public unsafe partial class HtcFoveation : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_HTC_foveation";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrApplyFoveationHTC", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ApplyFoveationHtc([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FoveationApplyInfoHTC* applyInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrApplyFoveationHTC", Convention = CallingConvention.Winapi)]
        public partial Result ApplyFoveationHtc([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FoveationApplyInfoHTC applyInfo);

        public HtcFoveation(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

