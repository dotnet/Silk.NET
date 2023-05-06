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
    public static class MsftSceneUnderstandingSerializationOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result DeserializeSceneMsft(this MsftSceneUnderstandingSerialization thisApi, [Count(Count = 0)] SceneObserverMSFT sceneObserver, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SceneDeserializeInfoMSFT> deserializeInfo)
        {
            // SpanOverloader
            return thisApi.DeserializeSceneMsft(sceneObserver, in deserializeInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSerializedSceneFragmentDataMsft(this MsftSceneUnderstandingSerialization thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SerializedSceneFragmentDataGetInfoMSFT* getInfo, [Count(Count = 0)] uint countInput, [Count(Count = 0)] uint* readOutput, [Count(Parameter = "countInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetSerializedSceneFragmentDataMsft(scene, getInfo, countInput, readOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSerializedSceneFragmentDataMsft(this MsftSceneUnderstandingSerialization thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SerializedSceneFragmentDataGetInfoMSFT* getInfo, [Count(Count = 0)] uint countInput, [Count(Count = 0)] Span<uint> readOutput, [Count(Parameter = "countInput")] byte* buffer)
        {
            // SpanOverloader
            return thisApi.GetSerializedSceneFragmentDataMsft(scene, getInfo, countInput, ref readOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSerializedSceneFragmentDataMsft(this MsftSceneUnderstandingSerialization thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SerializedSceneFragmentDataGetInfoMSFT* getInfo, [Count(Count = 0)] uint countInput, [Count(Count = 0)] Span<uint> readOutput, [Count(Parameter = "countInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetSerializedSceneFragmentDataMsft(scene, getInfo, countInput, ref readOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSerializedSceneFragmentDataMsft(this MsftSceneUnderstandingSerialization thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SerializedSceneFragmentDataGetInfoMSFT* getInfo, [Count(Count = 0)] uint countInput, [Count(Count = 0)] Span<uint> readOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer)
        {
            // SpanOverloader
            return thisApi.GetSerializedSceneFragmentDataMsft(scene, getInfo, countInput, ref readOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSerializedSceneFragmentDataMsft(this MsftSceneUnderstandingSerialization thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SerializedSceneFragmentDataGetInfoMSFT> getInfo, [Count(Count = 0)] uint countInput, [Count(Count = 0)] uint* readOutput, [Count(Parameter = "countInput")] byte* buffer)
        {
            // SpanOverloader
            return thisApi.GetSerializedSceneFragmentDataMsft(scene, in getInfo.GetPinnableReference(), countInput, readOutput, buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSerializedSceneFragmentDataMsft(this MsftSceneUnderstandingSerialization thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SerializedSceneFragmentDataGetInfoMSFT> getInfo, [Count(Count = 0)] uint countInput, [Count(Count = 0)] uint* readOutput, [Count(Parameter = "countInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetSerializedSceneFragmentDataMsft(scene, in getInfo.GetPinnableReference(), countInput, readOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSerializedSceneFragmentDataMsft(this MsftSceneUnderstandingSerialization thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SerializedSceneFragmentDataGetInfoMSFT> getInfo, [Count(Count = 0)] uint countInput, [Count(Count = 0)] uint* readOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer)
        {
            // SpanOverloader
            return thisApi.GetSerializedSceneFragmentDataMsft(scene, in getInfo.GetPinnableReference(), countInput, readOutput, buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSerializedSceneFragmentDataMsft(this MsftSceneUnderstandingSerialization thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SerializedSceneFragmentDataGetInfoMSFT> getInfo, [Count(Count = 0)] uint countInput, [Count(Count = 0)] Span<uint> readOutput, [Count(Parameter = "countInput")] byte* buffer)
        {
            // SpanOverloader
            return thisApi.GetSerializedSceneFragmentDataMsft(scene, in getInfo.GetPinnableReference(), countInput, ref readOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSerializedSceneFragmentDataMsft(this MsftSceneUnderstandingSerialization thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SerializedSceneFragmentDataGetInfoMSFT> getInfo, [Count(Count = 0)] uint countInput, [Count(Count = 0)] Span<uint> readOutput, [Count(Parameter = "countInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetSerializedSceneFragmentDataMsft(scene, in getInfo.GetPinnableReference(), countInput, ref readOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSerializedSceneFragmentDataMsft(this MsftSceneUnderstandingSerialization thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SerializedSceneFragmentDataGetInfoMSFT> getInfo, [Count(Count = 0)] uint countInput, [Count(Count = 0)] Span<uint> readOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer)
        {
            // SpanOverloader
            return thisApi.GetSerializedSceneFragmentDataMsft(scene, in getInfo.GetPinnableReference(), countInput, ref readOutput.GetPinnableReference(), buffer);
        }

    }
}

