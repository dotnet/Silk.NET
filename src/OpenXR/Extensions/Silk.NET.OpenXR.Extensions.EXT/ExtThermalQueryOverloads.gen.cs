// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.EXT
{
    public static class ExtThermalQueryOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result ThermalGetTemperatureTrend(this ExtThermalQuery thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] PerfSettingsNotificationLevelEXT* notificationLevel, [Count(Count = 0)] float* tempHeadroom, [Count(Count = 0)] Span<float> tempSlope)
        {
            // SpanOverloader
            return thisApi.ThermalGetTemperatureTrend(session, domain, notificationLevel, tempHeadroom, ref tempSlope.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result ThermalGetTemperatureTrend(this ExtThermalQuery thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] PerfSettingsNotificationLevelEXT* notificationLevel, [Count(Count = 0)] Span<float> tempHeadroom, [Count(Count = 0)] float* tempSlope)
        {
            // SpanOverloader
            return thisApi.ThermalGetTemperatureTrend(session, domain, notificationLevel, ref tempHeadroom.GetPinnableReference(), tempSlope);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result ThermalGetTemperatureTrend(this ExtThermalQuery thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] PerfSettingsNotificationLevelEXT* notificationLevel, [Count(Count = 0)] Span<float> tempHeadroom, [Count(Count = 0)] Span<float> tempSlope)
        {
            // SpanOverloader
            return thisApi.ThermalGetTemperatureTrend(session, domain, notificationLevel, ref tempHeadroom.GetPinnableReference(), ref tempSlope.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result ThermalGetTemperatureTrend(this ExtThermalQuery thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] Span<PerfSettingsNotificationLevelEXT> notificationLevel, [Count(Count = 0)] float* tempHeadroom, [Count(Count = 0)] float* tempSlope)
        {
            // SpanOverloader
            return thisApi.ThermalGetTemperatureTrend(session, domain, ref notificationLevel.GetPinnableReference(), tempHeadroom, tempSlope);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result ThermalGetTemperatureTrend(this ExtThermalQuery thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] Span<PerfSettingsNotificationLevelEXT> notificationLevel, [Count(Count = 0)] float* tempHeadroom, [Count(Count = 0)] Span<float> tempSlope)
        {
            // SpanOverloader
            return thisApi.ThermalGetTemperatureTrend(session, domain, ref notificationLevel.GetPinnableReference(), tempHeadroom, ref tempSlope.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result ThermalGetTemperatureTrend(this ExtThermalQuery thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] Span<PerfSettingsNotificationLevelEXT> notificationLevel, [Count(Count = 0)] Span<float> tempHeadroom, [Count(Count = 0)] float* tempSlope)
        {
            // SpanOverloader
            return thisApi.ThermalGetTemperatureTrend(session, domain, ref notificationLevel.GetPinnableReference(), ref tempHeadroom.GetPinnableReference(), tempSlope);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result ThermalGetTemperatureTrend(this ExtThermalQuery thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] Span<PerfSettingsNotificationLevelEXT> notificationLevel, [Count(Count = 0)] Span<float> tempHeadroom, [Count(Count = 0)] Span<float> tempSlope)
        {
            // SpanOverloader
            return thisApi.ThermalGetTemperatureTrend(session, domain, ref notificationLevel.GetPinnableReference(), ref tempHeadroom.GetPinnableReference(), ref tempSlope.GetPinnableReference());
        }

    }
}

