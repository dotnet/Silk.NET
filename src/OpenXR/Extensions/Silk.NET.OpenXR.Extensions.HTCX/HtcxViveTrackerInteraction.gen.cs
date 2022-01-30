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

namespace Silk.NET.OpenXR.Extensions.HTCX
{
    [Extension("XR_HTCX_vive_tracker_interaction")]
    public unsafe partial class HtcxViveTrackerInteraction : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_HTCX_vive_tracker_interaction";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateViveTrackerPathsHTCX", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateViveTrackerPathsHtcx([Count(Count = 0)] Instance instance, [Count(Count = 0)] uint pathCapacityInput, [Count(Count = 0)] uint* pathCountOutput, [Count(Parameter = "pathCapacityInput")] ViveTrackerPathsHTCX* paths);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateViveTrackerPathsHTCX", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateViveTrackerPathsHtcx([Count(Count = 0)] Instance instance, [Count(Count = 0)] uint pathCapacityInput, [Count(Count = 0)] uint* pathCountOutput, [Count(Parameter = "pathCapacityInput")] ref ViveTrackerPathsHTCX paths);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateViveTrackerPathsHTCX", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateViveTrackerPathsHtcx([Count(Count = 0)] Instance instance, [Count(Count = 0)] uint pathCapacityInput, [Count(Count = 0)] ref uint pathCountOutput, [Count(Parameter = "pathCapacityInput")] ViveTrackerPathsHTCX* paths);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateViveTrackerPathsHTCX", Convention = CallingConvention.Winapi)]
        public partial Result EnumerateViveTrackerPathsHtcx([Count(Count = 0)] Instance instance, [Count(Count = 0)] uint pathCapacityInput, [Count(Count = 0)] ref uint pathCountOutput, [Count(Parameter = "pathCapacityInput")] ref ViveTrackerPathsHTCX paths);

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateViveTrackerPathsHtcx([Count(Count = 0)] Instance instance, [Count(Count = 0)] uint* pathCountOutput, [Count(Parameter = "pathCapacityInput")] Span<ViveTrackerPathsHTCX> paths)
        {
            // ImplicitCountSpanOverloader
            return EnumerateViveTrackerPathsHtcx(instance, (uint) paths.Length, pathCountOutput, ref paths.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateViveTrackerPathsHtcx([Count(Count = 0)] Instance instance, [Count(Count = 0)] ref uint pathCountOutput, [Count(Parameter = "pathCapacityInput")] Span<ViveTrackerPathsHTCX> paths)
        {
            // ImplicitCountSpanOverloader
            return EnumerateViveTrackerPathsHtcx(instance, (uint) paths.Length, ref pathCountOutput, ref paths.GetPinnableReference());
        }

        public HtcxViveTrackerInteraction(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

