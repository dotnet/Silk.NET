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
    [Extension("XR_MSFT_scene_understanding_serialization")]
    public unsafe partial class MsftSceneUnderstandingSerialization : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_MSFT_scene_understanding_serialization";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDeserializeSceneMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result DeserializeSceneMsft([Count(Count = 0)] SceneObserverMSFT sceneObserver, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SceneDeserializeInfoMSFT* deserializeInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSerializedSceneFragmentDataMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSerializedSceneFragmentDataMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SerializedSceneFragmentDataGetInfoMSFT* getInfo, [Count(Count = 0)] uint countInput, [Count(Count = 0)] uint* readOutput, [Count(Parameter = "countInput")] byte* buffer);

        public MsftSceneUnderstandingSerialization(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

