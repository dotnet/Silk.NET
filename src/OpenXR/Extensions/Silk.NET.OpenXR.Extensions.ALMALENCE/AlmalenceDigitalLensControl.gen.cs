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

namespace Silk.NET.OpenXR.Extensions.ALMALENCE
{
    [Extension("XR_ALMALENCE_digital_lens_control")]
    public unsafe partial class AlmalenceDigitalLensControl : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_ALMALENCE_digital_lens_control";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSetDigitalLensControlALMALENCE", Convention = CallingConvention.Winapi)]
        public unsafe partial Result SetDigitalLensControlAlmalence([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DigitalLensControlALMALENCE* digitalLensControl);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSetDigitalLensControlALMALENCE", Convention = CallingConvention.Winapi)]
        public partial Result SetDigitalLensControlAlmalence([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DigitalLensControlALMALENCE digitalLensControl);

        public AlmalenceDigitalLensControl(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

