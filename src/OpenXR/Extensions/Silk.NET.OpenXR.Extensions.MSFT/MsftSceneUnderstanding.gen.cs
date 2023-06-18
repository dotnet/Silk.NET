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
    [Extension("XR_MSFT_scene_understanding")]
    public unsafe partial class MsftSceneUnderstanding : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_MSFT_scene_understanding";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrComputeNewSceneMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ComputeNewSceneMsft([Count(Count = 0)] SceneObserverMSFT sceneObserver, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] NewSceneComputeInfoMSFT* computeInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSceneMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSceneMsft([Count(Count = 0)] SceneObserverMSFT sceneObserver, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SceneCreateInfoMSFT* createInfo, [Count(Count = 0)] SceneMSFT* scene);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSceneObserverMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSceneObserverMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SceneObserverCreateInfoMSFT* createInfo, [Count(Count = 0)] SceneObserverMSFT* sceneObserver);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroySceneMSFT", Convention = CallingConvention.Winapi)]
        public partial Result DestroySceneMsft([Count(Count = 0)] SceneMSFT scene);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroySceneObserverMSFT", Convention = CallingConvention.Winapi)]
        public partial Result DestroySceneObserverMsft([Count(Count = 0)] SceneObserverMSFT sceneObserver);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSceneComputeFeaturesMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSceneComputeFeaturesMsft([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint featureCapacityInput, [Count(Count = 0)] uint* featureCountOutput, [Count(Parameter = "featureCapacityInput")] SceneComputeFeatureMSFT* features);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSceneComponentsMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSceneComponentsMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SceneComponentsGetInfoMSFT* getInfo, [Count(Count = 0)] SceneComponentsMSFT* components);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSceneComputeStateMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSceneComputeStateMsft([Count(Count = 0)] SceneObserverMSFT sceneObserver, [Count(Count = 0)] SceneComputeStateMSFT* state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSceneMeshBuffersMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSceneMeshBuffersMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SceneMeshBuffersGetInfoMSFT* getInfo, [Count(Count = 0)] SceneMeshBuffersMSFT* buffers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateSceneComponentsMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateSceneComponentsMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SceneComponentsLocateInfoMSFT* locateInfo, [Count(Count = 0)] SceneComponentLocationsMSFT* locations);

        public MsftSceneUnderstanding(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

