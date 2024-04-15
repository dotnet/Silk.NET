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

namespace Silk.NET.OpenXR.Extensions.FB
{
    [Extension("XR_FB_keyboard_tracking")]
    public unsafe partial class FBKeyboardTracking : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_FB_keyboard_tracking";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateKeyboardSpaceFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateKeyboardSpaceFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] KeyboardSpaceCreateInfoFB* createInfo, [Count(Count = 0)] Space* keyboardSpace);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateKeyboardSpaceFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateKeyboardSpaceFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] KeyboardSpaceCreateInfoFB* createInfo, [Count(Count = 0)] ref Space keyboardSpace);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateKeyboardSpaceFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateKeyboardSpaceFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in KeyboardSpaceCreateInfoFB createInfo, [Count(Count = 0)] Space* keyboardSpace);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateKeyboardSpaceFB", Convention = CallingConvention.Winapi)]
        public partial Result CreateKeyboardSpaceFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in KeyboardSpaceCreateInfoFB createInfo, [Count(Count = 0)] ref Space keyboardSpace);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrQuerySystemTrackedKeyboardFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result QuerySystemTrackedKeyboardFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] KeyboardTrackingQueryFB* queryInfo, [Count(Count = 0)] KeyboardTrackingDescriptionFB* keyboard);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrQuerySystemTrackedKeyboardFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result QuerySystemTrackedKeyboardFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] KeyboardTrackingQueryFB* queryInfo, [Count(Count = 0)] ref KeyboardTrackingDescriptionFB keyboard);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrQuerySystemTrackedKeyboardFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result QuerySystemTrackedKeyboardFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in KeyboardTrackingQueryFB queryInfo, [Count(Count = 0)] KeyboardTrackingDescriptionFB* keyboard);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrQuerySystemTrackedKeyboardFB", Convention = CallingConvention.Winapi)]
        public partial Result QuerySystemTrackedKeyboardFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in KeyboardTrackingQueryFB queryInfo, [Count(Count = 0)] ref KeyboardTrackingDescriptionFB keyboard);

        public FBKeyboardTracking(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

