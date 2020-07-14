// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenXR;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.KHR
{
    [Extension("XR_KHR_android_thread_settings")]
    public abstract unsafe partial class KhrAndroidThreadSettings : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_KHR_android_thread_settings";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrSetAndroidApplicationThreadKHR")]
        public abstract Result SetAndroidApplicationThread([Count(Count = 0)] Session session, [Count(Count = 0)] AndroidThreadTypeKHR threadType, [Count(Count = 0)] uint threadId);

        public KhrAndroidThreadSettings(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

