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

namespace Silk.NET.OpenXR.Extensions.MNDX
{
    [Extension("XR_MNDX_force_feedback_curl")]
    public unsafe partial class MndxForceFeedbackCurl : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_MNDX_force_feedback_curl";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrApplyForceFeedbackCurlMNDX", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ApplyForceFeedbackCurlMndx([Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ForceFeedbackCurlApplyLocationsMNDX* locations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrApplyForceFeedbackCurlMNDX", Convention = CallingConvention.Winapi)]
        public partial Result ApplyForceFeedbackCurlMndx([Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ForceFeedbackCurlApplyLocationsMNDX locations);

        public MndxForceFeedbackCurl(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

