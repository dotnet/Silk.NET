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

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.ML
{
    public static class MLSystemNotificationsOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result SetSystemNotificationsML(this MLSystemNotifications thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SystemNotificationsSetInfoML> info)
        {
            // SpanOverloader
            return thisApi.SetSystemNotificationsML(instance, in info.GetPinnableReference());
        }

    }
}

