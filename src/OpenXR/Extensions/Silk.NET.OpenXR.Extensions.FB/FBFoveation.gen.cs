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

namespace Silk.NET.OpenXR.Extensions.FB
{
    [Extension("XR_FB_foveation")]
    public unsafe partial class FBFoveation : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_FB_foveation";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateFoveationProfileFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateFoveationProfileFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FoveationProfileCreateInfoFB* createInfo, [Count(Count = 0)] FoveationProfileFB* profile);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateFoveationProfileFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateFoveationProfileFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FoveationProfileCreateInfoFB* createInfo, [Count(Count = 0)] ref FoveationProfileFB profile);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateFoveationProfileFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateFoveationProfileFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FoveationProfileCreateInfoFB createInfo, [Count(Count = 0)] FoveationProfileFB* profile);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateFoveationProfileFB", Convention = CallingConvention.Winapi)]
        public partial Result CreateFoveationProfileFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FoveationProfileCreateInfoFB createInfo, [Count(Count = 0)] ref FoveationProfileFB profile);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyFoveationProfileFB", Convention = CallingConvention.Winapi)]
        public partial Result DestroyFoveationProfileFB([Count(Count = 0)] FoveationProfileFB profile);

        public FBFoveation(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

