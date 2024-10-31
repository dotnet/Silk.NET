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
    [Extension("XR_ML_system_notifications")]
    public unsafe partial class MLSystemNotifications : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_ML_system_notifications";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSetSystemNotificationsML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result SetSystemNotificationsML([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SystemNotificationsSetInfoML* info);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSetSystemNotificationsML", Convention = CallingConvention.Winapi)]
        public partial Result SetSystemNotificationsML([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SystemNotificationsSetInfoML info);

        public MLSystemNotifications(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

