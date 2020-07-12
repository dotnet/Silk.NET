// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrAndroidThreadTypeKHR")]
    public enum AndroidThreadTypeKHR
    {
        [NativeName("Name", "XR_ANDROID_THREAD_TYPE_APPLICATION_MAIN_KHR")]
        AndroidThreadTypeApplicationMainKhr = 1,
        [NativeName("Name", "XR_ANDROID_THREAD_TYPE_APPLICATION_WORKER_KHR")]
        AndroidThreadTypeApplicationWorkerKhr = 2,
        [NativeName("Name", "XR_ANDROID_THREAD_TYPE_RENDERER_MAIN_KHR")]
        AndroidThreadTypeRendererMainKhr = 3,
        [NativeName("Name", "XR_ANDROID_THREAD_TYPE_RENDERER_WORKER_KHR")]
        AndroidThreadTypeRendererWorkerKhr = 4,
    }
}
