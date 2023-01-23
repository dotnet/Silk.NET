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
    [Extension("XR_EXT_thermal_query")]
    public unsafe partial class ExtThermalQuery : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_EXT_thermal_query";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrThermalGetTemperatureTrendEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ThermalGetTemperatureTrend([Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] PerfSettingsNotificationLevelEXT* notificationLevel, [Count(Count = 0)] float* tempHeadroom, [Count(Count = 0)] float* tempSlope);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrThermalGetTemperatureTrendEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ThermalGetTemperatureTrend([Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] PerfSettingsNotificationLevelEXT* notificationLevel, [Count(Count = 0)] float* tempHeadroom, [Count(Count = 0)] ref float tempSlope);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrThermalGetTemperatureTrendEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ThermalGetTemperatureTrend([Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] PerfSettingsNotificationLevelEXT* notificationLevel, [Count(Count = 0)] ref float tempHeadroom, [Count(Count = 0)] float* tempSlope);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrThermalGetTemperatureTrendEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ThermalGetTemperatureTrend([Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] PerfSettingsNotificationLevelEXT* notificationLevel, [Count(Count = 0)] ref float tempHeadroom, [Count(Count = 0)] ref float tempSlope);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrThermalGetTemperatureTrendEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ThermalGetTemperatureTrend([Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] ref PerfSettingsNotificationLevelEXT notificationLevel, [Count(Count = 0)] float* tempHeadroom, [Count(Count = 0)] float* tempSlope);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrThermalGetTemperatureTrendEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ThermalGetTemperatureTrend([Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] ref PerfSettingsNotificationLevelEXT notificationLevel, [Count(Count = 0)] float* tempHeadroom, [Count(Count = 0)] ref float tempSlope);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrThermalGetTemperatureTrendEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ThermalGetTemperatureTrend([Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] ref PerfSettingsNotificationLevelEXT notificationLevel, [Count(Count = 0)] ref float tempHeadroom, [Count(Count = 0)] float* tempSlope);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrThermalGetTemperatureTrendEXT", Convention = CallingConvention.Winapi)]
        public partial Result ThermalGetTemperatureTrend([Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] ref PerfSettingsNotificationLevelEXT notificationLevel, [Count(Count = 0)] ref float tempHeadroom, [Count(Count = 0)] ref float tempSlope);

        public ExtThermalQuery(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

