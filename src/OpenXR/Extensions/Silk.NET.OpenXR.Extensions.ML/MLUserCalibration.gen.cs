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

namespace Silk.NET.OpenXR.Extensions.ML
{
    [Extension("XR_ML_user_calibration")]
    public unsafe partial class MLUserCalibration : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_ML_user_calibration";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnableUserCalibrationEventsML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnableUserCalibrationEventsML([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] UserCalibrationEnableEventsInfoML* enableInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnableUserCalibrationEventsML", Convention = CallingConvention.Winapi)]
        public partial Result EnableUserCalibrationEventsML([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UserCalibrationEnableEventsInfoML enableInfo);

        public MLUserCalibration(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

