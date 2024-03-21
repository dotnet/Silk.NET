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

namespace Silk.NET.OpenXR.Extensions.MSFT
{
    [Extension("XR_MSFT_scene_marker")]
    public unsafe partial class MsftSceneMarker : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_MSFT_scene_marker";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSceneMarkerDecodedStringMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSceneMarkerDecodedStringMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSceneMarkerDecodedStringMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSceneMarkerDecodedStringMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSceneMarkerDecodedStringMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSceneMarkerDecodedStringMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSceneMarkerDecodedStringMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSceneMarkerDecodedStringMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSceneMarkerDecodedStringMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSceneMarkerDecodedStringMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSceneMarkerDecodedStringMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSceneMarkerDecodedStringMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSceneMarkerDecodedStringMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSceneMarkerDecodedStringMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSceneMarkerDecodedStringMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSceneMarkerDecodedStringMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSceneMarkerDecodedStringMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSceneMarkerDecodedStringMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSceneMarkerDecodedStringMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSceneMarkerDecodedStringMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSceneMarkerDecodedStringMSFT", Convention = CallingConvention.Winapi)]
        public partial Result GetSceneMarkerDecodedStringMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSceneMarkerDecodedStringMSFT", Convention = CallingConvention.Winapi)]
        public partial Result GetSceneMarkerDecodedStringMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSceneMarkerRawDataMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSceneMarkerRawDataMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSceneMarkerRawDataMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSceneMarkerRawDataMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSceneMarkerRawDataMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSceneMarkerRawDataMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSceneMarkerRawDataMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSceneMarkerRawDataMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSceneMarkerRawDataMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSceneMarkerRawDataMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSceneMarkerRawDataMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSceneMarkerRawDataMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSceneMarkerRawDataMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSceneMarkerRawDataMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSceneMarkerRawDataMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSceneMarkerRawDataMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSceneMarkerRawDataMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSceneMarkerRawDataMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSceneMarkerRawDataMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSceneMarkerRawDataMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSceneMarkerRawDataMSFT", Convention = CallingConvention.Winapi)]
        public partial Result GetSceneMarkerRawDataMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSceneMarkerRawDataMSFT", Convention = CallingConvention.Winapi)]
        public partial Result GetSceneMarkerRawDataMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        public unsafe Result GetSceneMarkerDecodedStringMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* markerId, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSceneMarkerDecodedStringMsft(scene, markerId, (uint) buffer.Length, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSceneMarkerDecodedStringMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* markerId, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSceneMarkerDecodedStringMsft(scene, markerId, (uint) buffer.Length, ref bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSceneMarkerDecodedStringMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid markerId, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSceneMarkerDecodedStringMsft(scene, in markerId, (uint) buffer.Length, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSceneMarkerDecodedStringMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid markerId, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSceneMarkerDecodedStringMsft(scene, in markerId, (uint) buffer.Length, ref bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSceneMarkerRawDataMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* markerId, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSceneMarkerRawDataMsft(scene, markerId, (uint) buffer.Length, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSceneMarkerRawDataMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* markerId, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSceneMarkerRawDataMsft(scene, markerId, (uint) buffer.Length, ref bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSceneMarkerRawDataMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid markerId, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSceneMarkerRawDataMsft(scene, in markerId, (uint) buffer.Length, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetSceneMarkerRawDataMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid markerId, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetSceneMarkerRawDataMsft(scene, in markerId, (uint) buffer.Length, ref bufferCountOutput, ref buffer.GetPinnableReference());
        }

        public MsftSceneMarker(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

