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
    [Extension("XR_EXT_conformance_automation")]
    public unsafe partial class ExtConformanceAutomation : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_EXT_conformance_automation";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSetInputDeviceActiveEXT", Convention = CallingConvention.Winapi)]
        public partial Result SetInputDeviceActive([Count(Count = 0)] Session session, [Count(Count = 0)] ulong interactionProfile, [Count(Count = 0)] ulong topLevelPath, [Count(Count = 0)] uint isActive);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSetInputDeviceLocationEXT", Convention = CallingConvention.Winapi)]
        public partial Result SetInputDeviceLocation([Count(Count = 0)] Session session, [Count(Count = 0)] ulong topLevelPath, [Count(Count = 0)] ulong inputSourcePath, [Count(Count = 0)] Space space, [Count(Count = 0)] Posef pose);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSetInputDeviceStateBoolEXT", Convention = CallingConvention.Winapi)]
        public partial Result SetInputDeviceStateBool([Count(Count = 0)] Session session, [Count(Count = 0)] ulong topLevelPath, [Count(Count = 0)] ulong inputSourcePath, [Count(Count = 0)] uint state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSetInputDeviceStateFloatEXT", Convention = CallingConvention.Winapi)]
        public partial Result SetInputDeviceStateFloat([Count(Count = 0)] Session session, [Count(Count = 0)] ulong topLevelPath, [Count(Count = 0)] ulong inputSourcePath, [Count(Count = 0)] float state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSetInputDeviceStateVector2fEXT", Convention = CallingConvention.Winapi)]
        public partial Result SetInputDeviceStateVector2([Count(Count = 0)] Session session, [Count(Count = 0)] ulong topLevelPath, [Count(Count = 0)] ulong inputSourcePath, [Count(Count = 0)] Vector2f state);

        public ExtConformanceAutomation(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

