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
    public static class MsftSceneUnderstandingOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result ComputeNewSceneMsft(this MsftSceneUnderstanding thisApi, [Count(Count = 0)] SceneObserverMSFT sceneObserver, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<NewSceneComputeInfoMSFT> computeInfo)
        {
            // SpanOverloader
            return thisApi.ComputeNewSceneMsft(sceneObserver, in computeInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSceneMsft(this MsftSceneUnderstanding thisApi, [Count(Count = 0)] SceneObserverMSFT sceneObserver, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SceneCreateInfoMSFT* createInfo, [Count(Count = 0)] Span<SceneMSFT> scene)
        {
            // SpanOverloader
            return thisApi.CreateSceneMsft(sceneObserver, createInfo, ref scene.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSceneMsft(this MsftSceneUnderstanding thisApi, [Count(Count = 0)] SceneObserverMSFT sceneObserver, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SceneCreateInfoMSFT> createInfo, [Count(Count = 0)] SceneMSFT* scene)
        {
            // SpanOverloader
            return thisApi.CreateSceneMsft(sceneObserver, in createInfo.GetPinnableReference(), scene);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSceneMsft(this MsftSceneUnderstanding thisApi, [Count(Count = 0)] SceneObserverMSFT sceneObserver, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SceneCreateInfoMSFT> createInfo, [Count(Count = 0)] Span<SceneMSFT> scene)
        {
            // SpanOverloader
            return thisApi.CreateSceneMsft(sceneObserver, in createInfo.GetPinnableReference(), ref scene.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSceneObserverMsft(this MsftSceneUnderstanding thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SceneObserverCreateInfoMSFT* createInfo, [Count(Count = 0)] Span<SceneObserverMSFT> sceneObserver)
        {
            // SpanOverloader
            return thisApi.CreateSceneObserverMsft(session, createInfo, ref sceneObserver.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSceneObserverMsft(this MsftSceneUnderstanding thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SceneObserverCreateInfoMSFT> createInfo, [Count(Count = 0)] SceneObserverMSFT* sceneObserver)
        {
            // SpanOverloader
            return thisApi.CreateSceneObserverMsft(session, in createInfo.GetPinnableReference(), sceneObserver);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSceneObserverMsft(this MsftSceneUnderstanding thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SceneObserverCreateInfoMSFT> createInfo, [Count(Count = 0)] Span<SceneObserverMSFT> sceneObserver)
        {
            // SpanOverloader
            return thisApi.CreateSceneObserverMsft(session, in createInfo.GetPinnableReference(), ref sceneObserver.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSceneComputeFeaturesMsft(this MsftSceneUnderstanding thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint featureCapacityInput, [Count(Count = 0)] uint* featureCountOutput, [Count(Parameter = "featureCapacityInput")] Span<SceneComputeFeatureMSFT> features)
        {
            // SpanOverloader
            return thisApi.EnumerateSceneComputeFeaturesMsft(instance, systemId, featureCapacityInput, featureCountOutput, ref features.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSceneComputeFeaturesMsft(this MsftSceneUnderstanding thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint featureCapacityInput, [Count(Count = 0)] Span<uint> featureCountOutput, [Count(Parameter = "featureCapacityInput")] SceneComputeFeatureMSFT* features)
        {
            // SpanOverloader
            return thisApi.EnumerateSceneComputeFeaturesMsft(instance, systemId, featureCapacityInput, ref featureCountOutput.GetPinnableReference(), features);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSceneComputeFeaturesMsft(this MsftSceneUnderstanding thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint featureCapacityInput, [Count(Count = 0)] Span<uint> featureCountOutput, [Count(Parameter = "featureCapacityInput")] Span<SceneComputeFeatureMSFT> features)
        {
            // SpanOverloader
            return thisApi.EnumerateSceneComputeFeaturesMsft(instance, systemId, featureCapacityInput, ref featureCountOutput.GetPinnableReference(), ref features.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSceneComponentsMsft(this MsftSceneUnderstanding thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SceneComponentsGetInfoMSFT* getInfo, [Count(Count = 0)] Span<SceneComponentsMSFT> components)
        {
            // SpanOverloader
            return thisApi.GetSceneComponentsMsft(scene, getInfo, ref components.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSceneComponentsMsft(this MsftSceneUnderstanding thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SceneComponentsGetInfoMSFT> getInfo, [Count(Count = 0)] SceneComponentsMSFT* components)
        {
            // SpanOverloader
            return thisApi.GetSceneComponentsMsft(scene, in getInfo.GetPinnableReference(), components);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSceneComponentsMsft(this MsftSceneUnderstanding thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SceneComponentsGetInfoMSFT> getInfo, [Count(Count = 0)] Span<SceneComponentsMSFT> components)
        {
            // SpanOverloader
            return thisApi.GetSceneComponentsMsft(scene, in getInfo.GetPinnableReference(), ref components.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSceneComputeStateMsft(this MsftSceneUnderstanding thisApi, [Count(Count = 0)] SceneObserverMSFT sceneObserver, [Count(Count = 0)] Span<SceneComputeStateMSFT> state)
        {
            // SpanOverloader
            return thisApi.GetSceneComputeStateMsft(sceneObserver, ref state.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSceneMeshBuffersMsft(this MsftSceneUnderstanding thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SceneMeshBuffersGetInfoMSFT* getInfo, [Count(Count = 0)] Span<SceneMeshBuffersMSFT> buffers)
        {
            // SpanOverloader
            return thisApi.GetSceneMeshBuffersMsft(scene, getInfo, ref buffers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSceneMeshBuffersMsft(this MsftSceneUnderstanding thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SceneMeshBuffersGetInfoMSFT> getInfo, [Count(Count = 0)] SceneMeshBuffersMSFT* buffers)
        {
            // SpanOverloader
            return thisApi.GetSceneMeshBuffersMsft(scene, in getInfo.GetPinnableReference(), buffers);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSceneMeshBuffersMsft(this MsftSceneUnderstanding thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SceneMeshBuffersGetInfoMSFT> getInfo, [Count(Count = 0)] Span<SceneMeshBuffersMSFT> buffers)
        {
            // SpanOverloader
            return thisApi.GetSceneMeshBuffersMsft(scene, in getInfo.GetPinnableReference(), ref buffers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateSceneComponentsMsft(this MsftSceneUnderstanding thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SceneComponentsLocateInfoMSFT* locateInfo, [Count(Count = 0)] Span<SceneComponentLocationsMSFT> locations)
        {
            // SpanOverloader
            return thisApi.LocateSceneComponentsMsft(scene, locateInfo, ref locations.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateSceneComponentsMsft(this MsftSceneUnderstanding thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SceneComponentsLocateInfoMSFT> locateInfo, [Count(Count = 0)] SceneComponentLocationsMSFT* locations)
        {
            // SpanOverloader
            return thisApi.LocateSceneComponentsMsft(scene, in locateInfo.GetPinnableReference(), locations);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateSceneComponentsMsft(this MsftSceneUnderstanding thisApi, [Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SceneComponentsLocateInfoMSFT> locateInfo, [Count(Count = 0)] Span<SceneComponentLocationsMSFT> locations)
        {
            // SpanOverloader
            return thisApi.LocateSceneComponentsMsft(scene, in locateInfo.GetPinnableReference(), ref locations.GetPinnableReference());
        }

    }
}

