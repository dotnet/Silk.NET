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

namespace Silk.NET.OpenXR.Extensions.MSFT
{
    public static class MsftSceneMarkerOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetSceneMarkerDecodedStringMsft(this MsftSceneMarker thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetSceneMarkerDecodedStringMsft(scene, markerId, bufferCapacityInput, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSceneMarkerDecodedStringMsft(this MsftSceneMarker thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer)
        {
            // SpanOverloader
            return thisApi.GetSceneMarkerDecodedStringMsft(scene, markerId, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSceneMarkerDecodedStringMsft(this MsftSceneMarker thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetSceneMarkerDecodedStringMsft(scene, markerId, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSceneMarkerDecodedStringMsft(this MsftSceneMarker thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer)
        {
            // SpanOverloader
            return thisApi.GetSceneMarkerDecodedStringMsft(scene, markerId, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSceneMarkerDecodedStringMsft(this MsftSceneMarker thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer)
        {
            // SpanOverloader
            return thisApi.GetSceneMarkerDecodedStringMsft(scene, in markerId.GetPinnableReference(), bufferCapacityInput, bufferCountOutput, buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSceneMarkerDecodedStringMsft(this MsftSceneMarker thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetSceneMarkerDecodedStringMsft(scene, in markerId.GetPinnableReference(), bufferCapacityInput, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSceneMarkerDecodedStringMsft(this MsftSceneMarker thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer)
        {
            // SpanOverloader
            return thisApi.GetSceneMarkerDecodedStringMsft(scene, in markerId.GetPinnableReference(), bufferCapacityInput, bufferCountOutput, buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSceneMarkerDecodedStringMsft(this MsftSceneMarker thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer)
        {
            // SpanOverloader
            return thisApi.GetSceneMarkerDecodedStringMsft(scene, in markerId.GetPinnableReference(), bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSceneMarkerDecodedStringMsft(this MsftSceneMarker thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetSceneMarkerDecodedStringMsft(scene, in markerId.GetPinnableReference(), bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSceneMarkerDecodedStringMsft(this MsftSceneMarker thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer)
        {
            // SpanOverloader
            return thisApi.GetSceneMarkerDecodedStringMsft(scene, in markerId.GetPinnableReference(), bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSceneMarkerRawDataMsft(this MsftSceneMarker thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetSceneMarkerRawDataMsft(scene, markerId, bufferCapacityInput, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSceneMarkerRawDataMsft(this MsftSceneMarker thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer)
        {
            // SpanOverloader
            return thisApi.GetSceneMarkerRawDataMsft(scene, markerId, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSceneMarkerRawDataMsft(this MsftSceneMarker thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetSceneMarkerRawDataMsft(scene, markerId, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSceneMarkerRawDataMsft(this MsftSceneMarker thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer)
        {
            // SpanOverloader
            return thisApi.GetSceneMarkerRawDataMsft(scene, markerId, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSceneMarkerRawDataMsft(this MsftSceneMarker thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer)
        {
            // SpanOverloader
            return thisApi.GetSceneMarkerRawDataMsft(scene, in markerId.GetPinnableReference(), bufferCapacityInput, bufferCountOutput, buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSceneMarkerRawDataMsft(this MsftSceneMarker thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetSceneMarkerRawDataMsft(scene, in markerId.GetPinnableReference(), bufferCapacityInput, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSceneMarkerRawDataMsft(this MsftSceneMarker thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer)
        {
            // SpanOverloader
            return thisApi.GetSceneMarkerRawDataMsft(scene, in markerId.GetPinnableReference(), bufferCapacityInput, bufferCountOutput, buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSceneMarkerRawDataMsft(this MsftSceneMarker thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer)
        {
            // SpanOverloader
            return thisApi.GetSceneMarkerRawDataMsft(scene, in markerId.GetPinnableReference(), bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSceneMarkerRawDataMsft(this MsftSceneMarker thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetSceneMarkerRawDataMsft(scene, in markerId.GetPinnableReference(), bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSceneMarkerRawDataMsft(this MsftSceneMarker thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> markerId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer)
        {
            // SpanOverloader
            return thisApi.GetSceneMarkerRawDataMsft(scene, in markerId.GetPinnableReference(), bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

    }
}

