// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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

namespace Silk.NET.OpenXR.Extensions.KHR
{
    [Extension("XR_KHR_android_thread_settings")]
    public unsafe partial class KhrAndroidThreadSettings : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_KHR_android_thread_settings";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSetAndroidApplicationThreadKHR")]
        public partial Result SetAndroidApplicationThread([Count(Count = 0)] Session session, [Count(Count = 0)] AndroidThreadTypeKHR threadType, [Count(Count = 0)] uint threadId);

        public KhrAndroidThreadSettings(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

