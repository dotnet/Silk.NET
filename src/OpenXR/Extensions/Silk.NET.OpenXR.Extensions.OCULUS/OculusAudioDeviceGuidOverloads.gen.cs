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

namespace Silk.NET.OpenXR.Extensions.OCULUS
{
    public static class OculusAudioDeviceGuidOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetAudioInputDeviceGuidOcul(this OculusAudioDeviceGuid thisApi, [Count(Count = 0)] Instance instance, [Count(Computed = "XR_MAX_AUDIO_DEVICE_STR_SIZE_OCULUS")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetAudioInputDeviceGuidOcul(instance, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetAudioOutputDeviceGuidOcul(this OculusAudioDeviceGuid thisApi, [Count(Count = 0)] Instance instance, [Count(Computed = "XR_MAX_AUDIO_DEVICE_STR_SIZE_OCULUS")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetAudioOutputDeviceGuidOcul(instance, ref buffer.GetPinnableReference());
        }

    }
}

