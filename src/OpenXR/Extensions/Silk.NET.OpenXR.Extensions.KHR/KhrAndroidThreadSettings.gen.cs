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

namespace Silk.NET.OpenXR.Extensions.KHR
{
    [Extension("XR_KHR_android_thread_settings")]
    public unsafe partial class KhrAndroidThreadSettings : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_KHR_android_thread_settings";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSetAndroidApplicationThreadKHR", Convention = CallingConvention.Winapi)]
        public partial Result SetAndroidApplicationThread([Count(Count = 0)] Session session, [Count(Count = 0)] AndroidThreadTypeKHR threadType, [Count(Count = 0)] uint threadId);

        public KhrAndroidThreadSettings(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

