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

namespace Silk.NET.OpenXR
{
    public static class XROverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result LocateSpaces(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpacesLocateInfo* locateInfo, [Count(Count = 0)] Span<SpaceLocations> spaceLocations)
        {
            // SpanOverloader
            return thisApi.LocateSpaces(session, locateInfo, ref spaceLocations.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateSpaces(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpacesLocateInfo> locateInfo, [Count(Count = 0)] SpaceLocations* spaceLocations)
        {
            // SpanOverloader
            return thisApi.LocateSpaces(session, in locateInfo.GetPinnableReference(), spaceLocations);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateSpaces(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpacesLocateInfo> locateInfo, [Count(Count = 0)] Span<SpaceLocations> spaceLocations)
        {
            // SpanOverloader
            return thisApi.LocateSpaces(session, in locateInfo.GetPinnableReference(), ref spaceLocations.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result AcquireSwapchainImage(this XR thisApi, [Count(Count = 0)] Swapchain swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainImageAcquireInfo* acquireInfo, [Count(Count = 0)] Span<uint> index)
        {
            // SpanOverloader
            return thisApi.AcquireSwapchainImage(swapchain, acquireInfo, ref index.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result AcquireSwapchainImage(this XR thisApi, [Count(Count = 0)] Swapchain swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapchainImageAcquireInfo> acquireInfo, [Count(Count = 0)] uint* index)
        {
            // SpanOverloader
            return thisApi.AcquireSwapchainImage(swapchain, in acquireInfo.GetPinnableReference(), index);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result AcquireSwapchainImage(this XR thisApi, [Count(Count = 0)] Swapchain swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapchainImageAcquireInfo> acquireInfo, [Count(Count = 0)] Span<uint> index)
        {
            // SpanOverloader
            return thisApi.AcquireSwapchainImage(swapchain, in acquireInfo.GetPinnableReference(), ref index.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ApplyHapticFeedback(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] HapticActionInfo* hapticActionInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HapticBaseHeader> hapticFeedback)
        {
            // SpanOverloader
            return thisApi.ApplyHapticFeedback(session, hapticActionInfo, in hapticFeedback.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ApplyHapticFeedback(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HapticActionInfo> hapticActionInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] HapticBaseHeader* hapticFeedback)
        {
            // SpanOverloader
            return thisApi.ApplyHapticFeedback(session, in hapticActionInfo.GetPinnableReference(), hapticFeedback);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ApplyHapticFeedback(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HapticActionInfo> hapticActionInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HapticBaseHeader> hapticFeedback)
        {
            // SpanOverloader
            return thisApi.ApplyHapticFeedback(session, in hapticActionInfo.GetPinnableReference(), in hapticFeedback.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result AttachSessionActionSets(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SessionActionSetsAttachInfo> attachInfo)
        {
            // SpanOverloader
            return thisApi.AttachSessionActionSets(session, in attachInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result BeginFrame(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FrameBeginInfo> frameBeginInfo)
        {
            // SpanOverloader
            return thisApi.BeginFrame(session, in frameBeginInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result BeginSession(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SessionBeginInfo> beginInfo)
        {
            // SpanOverloader
            return thisApi.BeginSession(session, in beginInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateAction(this XR thisApi, [Count(Count = 0)] ActionSet actionSet, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ActionCreateInfo* createInfo, [Count(Count = 0)] Span<Action> action)
        {
            // SpanOverloader
            return thisApi.CreateAction(actionSet, createInfo, ref action.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateAction(this XR thisApi, [Count(Count = 0)] ActionSet actionSet, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ActionCreateInfo> createInfo, [Count(Count = 0)] Action* action)
        {
            // SpanOverloader
            return thisApi.CreateAction(actionSet, in createInfo.GetPinnableReference(), action);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateAction(this XR thisApi, [Count(Count = 0)] ActionSet actionSet, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ActionCreateInfo> createInfo, [Count(Count = 0)] Span<Action> action)
        {
            // SpanOverloader
            return thisApi.CreateAction(actionSet, in createInfo.GetPinnableReference(), ref action.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateActionSet(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ActionSetCreateInfo* createInfo, [Count(Count = 0)] Span<ActionSet> actionSet)
        {
            // SpanOverloader
            return thisApi.CreateActionSet(instance, createInfo, ref actionSet.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateActionSet(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ActionSetCreateInfo> createInfo, [Count(Count = 0)] ActionSet* actionSet)
        {
            // SpanOverloader
            return thisApi.CreateActionSet(instance, in createInfo.GetPinnableReference(), actionSet);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateActionSet(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ActionSetCreateInfo> createInfo, [Count(Count = 0)] Span<ActionSet> actionSet)
        {
            // SpanOverloader
            return thisApi.CreateActionSet(instance, in createInfo.GetPinnableReference(), ref actionSet.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateActionSpace(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ActionSpaceCreateInfo* createInfo, [Count(Count = 0)] Span<Space> space)
        {
            // SpanOverloader
            return thisApi.CreateActionSpace(session, createInfo, ref space.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateActionSpace(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ActionSpaceCreateInfo> createInfo, [Count(Count = 0)] Space* space)
        {
            // SpanOverloader
            return thisApi.CreateActionSpace(session, in createInfo.GetPinnableReference(), space);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateActionSpace(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ActionSpaceCreateInfo> createInfo, [Count(Count = 0)] Span<Space> space)
        {
            // SpanOverloader
            return thisApi.CreateActionSpace(session, in createInfo.GetPinnableReference(), ref space.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentInstance = *%$PARAM(instance)$%; }")]
        public static unsafe Result CreateInstance(this XR thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InstanceCreateInfo* createInfo, [Count(Count = 0)] Span<Instance> instance)
        {
            // SpanOverloader
            return thisApi.CreateInstance(createInfo, ref instance.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentInstance = *%$PARAM(instance)$%; }")]
        public static unsafe Result CreateInstance(this XR thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InstanceCreateInfo> createInfo, [Count(Count = 0)] Instance* instance)
        {
            // SpanOverloader
            return thisApi.CreateInstance(in createInfo.GetPinnableReference(), instance);
        }

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentInstance = *%$PARAM(instance)$%; }")]
        public static unsafe Result CreateInstance(this XR thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InstanceCreateInfo> createInfo, [Count(Count = 0)] Span<Instance> instance)
        {
            // SpanOverloader
            return thisApi.CreateInstance(in createInfo.GetPinnableReference(), ref instance.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateReferenceSpace(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReferenceSpaceCreateInfo* createInfo, [Count(Count = 0)] Span<Space> space)
        {
            // SpanOverloader
            return thisApi.CreateReferenceSpace(session, createInfo, ref space.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateReferenceSpace(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReferenceSpaceCreateInfo> createInfo, [Count(Count = 0)] Space* space)
        {
            // SpanOverloader
            return thisApi.CreateReferenceSpace(session, in createInfo.GetPinnableReference(), space);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateReferenceSpace(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReferenceSpaceCreateInfo> createInfo, [Count(Count = 0)] Span<Space> space)
        {
            // SpanOverloader
            return thisApi.CreateReferenceSpace(session, in createInfo.GetPinnableReference(), ref space.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSession(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SessionCreateInfo* createInfo, [Count(Count = 0)] Span<Session> session)
        {
            // SpanOverloader
            return thisApi.CreateSession(instance, createInfo, ref session.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSession(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SessionCreateInfo> createInfo, [Count(Count = 0)] Session* session)
        {
            // SpanOverloader
            return thisApi.CreateSession(instance, in createInfo.GetPinnableReference(), session);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSession(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SessionCreateInfo> createInfo, [Count(Count = 0)] Span<Session> session)
        {
            // SpanOverloader
            return thisApi.CreateSession(instance, in createInfo.GetPinnableReference(), ref session.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSwapchain(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainCreateInfo* createInfo, [Count(Count = 0)] Span<Swapchain> swapchain)
        {
            // SpanOverloader
            return thisApi.CreateSwapchain(session, createInfo, ref swapchain.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSwapchain(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapchainCreateInfo> createInfo, [Count(Count = 0)] Swapchain* swapchain)
        {
            // SpanOverloader
            return thisApi.CreateSwapchain(session, in createInfo.GetPinnableReference(), swapchain);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSwapchain(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapchainCreateInfo> createInfo, [Count(Count = 0)] Span<Swapchain> swapchain)
        {
            // SpanOverloader
            return thisApi.CreateSwapchain(session, in createInfo.GetPinnableReference(), ref swapchain.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EndFrame(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FrameEndInfo> frameEndInfo)
        {
            // SpanOverloader
            return thisApi.EndFrame(session, in frameEndInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateApiLayerProperties(this XR thisApi, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] uint* propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] Span<ApiLayerProperties> properties)
        {
            // SpanOverloader
            return thisApi.EnumerateApiLayerProperties(propertyCapacityInput, propertyCountOutput, ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateApiLayerProperties(this XR thisApi, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] Span<uint> propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] ApiLayerProperties* properties)
        {
            // SpanOverloader
            return thisApi.EnumerateApiLayerProperties(propertyCapacityInput, ref propertyCountOutput.GetPinnableReference(), properties);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateApiLayerProperties(this XR thisApi, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] Span<uint> propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] Span<ApiLayerProperties> properties)
        {
            // SpanOverloader
            return thisApi.EnumerateApiLayerProperties(propertyCapacityInput, ref propertyCountOutput.GetPinnableReference(), ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateBoundSourcesForAction(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BoundSourcesForActionEnumerateInfo* enumerateInfo, [Count(Count = 0)] uint sourceCapacityInput, [Count(Count = 0)] uint* sourceCountOutput, [Count(Parameter = "sourceCapacityInput")] Span<ulong> sources)
        {
            // SpanOverloader
            return thisApi.EnumerateBoundSourcesForAction(session, enumerateInfo, sourceCapacityInput, sourceCountOutput, ref sources.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateBoundSourcesForAction(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BoundSourcesForActionEnumerateInfo* enumerateInfo, [Count(Count = 0)] uint sourceCapacityInput, [Count(Count = 0)] Span<uint> sourceCountOutput, [Count(Parameter = "sourceCapacityInput")] ulong* sources)
        {
            // SpanOverloader
            return thisApi.EnumerateBoundSourcesForAction(session, enumerateInfo, sourceCapacityInput, ref sourceCountOutput.GetPinnableReference(), sources);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateBoundSourcesForAction(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BoundSourcesForActionEnumerateInfo* enumerateInfo, [Count(Count = 0)] uint sourceCapacityInput, [Count(Count = 0)] Span<uint> sourceCountOutput, [Count(Parameter = "sourceCapacityInput")] Span<ulong> sources)
        {
            // SpanOverloader
            return thisApi.EnumerateBoundSourcesForAction(session, enumerateInfo, sourceCapacityInput, ref sourceCountOutput.GetPinnableReference(), ref sources.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateBoundSourcesForAction(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BoundSourcesForActionEnumerateInfo> enumerateInfo, [Count(Count = 0)] uint sourceCapacityInput, [Count(Count = 0)] uint* sourceCountOutput, [Count(Parameter = "sourceCapacityInput")] ulong* sources)
        {
            // SpanOverloader
            return thisApi.EnumerateBoundSourcesForAction(session, in enumerateInfo.GetPinnableReference(), sourceCapacityInput, sourceCountOutput, sources);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateBoundSourcesForAction(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BoundSourcesForActionEnumerateInfo> enumerateInfo, [Count(Count = 0)] uint sourceCapacityInput, [Count(Count = 0)] uint* sourceCountOutput, [Count(Parameter = "sourceCapacityInput")] Span<ulong> sources)
        {
            // SpanOverloader
            return thisApi.EnumerateBoundSourcesForAction(session, in enumerateInfo.GetPinnableReference(), sourceCapacityInput, sourceCountOutput, ref sources.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateBoundSourcesForAction(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BoundSourcesForActionEnumerateInfo> enumerateInfo, [Count(Count = 0)] uint sourceCapacityInput, [Count(Count = 0)] Span<uint> sourceCountOutput, [Count(Parameter = "sourceCapacityInput")] ulong* sources)
        {
            // SpanOverloader
            return thisApi.EnumerateBoundSourcesForAction(session, in enumerateInfo.GetPinnableReference(), sourceCapacityInput, ref sourceCountOutput.GetPinnableReference(), sources);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateBoundSourcesForAction(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BoundSourcesForActionEnumerateInfo> enumerateInfo, [Count(Count = 0)] uint sourceCapacityInput, [Count(Count = 0)] Span<uint> sourceCountOutput, [Count(Parameter = "sourceCapacityInput")] Span<ulong> sources)
        {
            // SpanOverloader
            return thisApi.EnumerateBoundSourcesForAction(session, in enumerateInfo.GetPinnableReference(), sourceCapacityInput, ref sourceCountOutput.GetPinnableReference(), ref sources.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateEnvironmentBlendModes(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint environmentBlendModeCapacityInput, [Count(Count = 0)] uint* environmentBlendModeCountOutput, [Count(Parameter = "environmentBlendModeCapacityInput")] Span<EnvironmentBlendMode> environmentBlendModes)
        {
            // SpanOverloader
            return thisApi.EnumerateEnvironmentBlendModes(instance, systemId, viewConfigurationType, environmentBlendModeCapacityInput, environmentBlendModeCountOutput, ref environmentBlendModes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateEnvironmentBlendModes(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint environmentBlendModeCapacityInput, [Count(Count = 0)] Span<uint> environmentBlendModeCountOutput, [Count(Parameter = "environmentBlendModeCapacityInput")] EnvironmentBlendMode* environmentBlendModes)
        {
            // SpanOverloader
            return thisApi.EnumerateEnvironmentBlendModes(instance, systemId, viewConfigurationType, environmentBlendModeCapacityInput, ref environmentBlendModeCountOutput.GetPinnableReference(), environmentBlendModes);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateEnvironmentBlendModes(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint environmentBlendModeCapacityInput, [Count(Count = 0)] Span<uint> environmentBlendModeCountOutput, [Count(Parameter = "environmentBlendModeCapacityInput")] Span<EnvironmentBlendMode> environmentBlendModes)
        {
            // SpanOverloader
            return thisApi.EnumerateEnvironmentBlendModes(instance, systemId, viewConfigurationType, environmentBlendModeCapacityInput, ref environmentBlendModeCountOutput.GetPinnableReference(), ref environmentBlendModes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInstanceExtensionProperties(this XR thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] uint* propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] Span<ExtensionProperties> properties)
        {
            // SpanOverloader
            return thisApi.EnumerateInstanceExtensionProperties(layerName, propertyCapacityInput, propertyCountOutput, ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInstanceExtensionProperties(this XR thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] Span<uint> propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] ExtensionProperties* properties)
        {
            // SpanOverloader
            return thisApi.EnumerateInstanceExtensionProperties(layerName, propertyCapacityInput, ref propertyCountOutput.GetPinnableReference(), properties);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInstanceExtensionProperties(this XR thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] Span<uint> propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] Span<ExtensionProperties> properties)
        {
            // SpanOverloader
            return thisApi.EnumerateInstanceExtensionProperties(layerName, propertyCapacityInput, ref propertyCountOutput.GetPinnableReference(), ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInstanceExtensionProperties(this XR thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] uint* propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] ExtensionProperties* properties)
        {
            // SpanOverloader
            return thisApi.EnumerateInstanceExtensionProperties(in layerName.GetPinnableReference(), propertyCapacityInput, propertyCountOutput, properties);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInstanceExtensionProperties(this XR thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] uint* propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] Span<ExtensionProperties> properties)
        {
            // SpanOverloader
            return thisApi.EnumerateInstanceExtensionProperties(in layerName.GetPinnableReference(), propertyCapacityInput, propertyCountOutput, ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInstanceExtensionProperties(this XR thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] Span<uint> propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] ExtensionProperties* properties)
        {
            // SpanOverloader
            return thisApi.EnumerateInstanceExtensionProperties(in layerName.GetPinnableReference(), propertyCapacityInput, ref propertyCountOutput.GetPinnableReference(), properties);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInstanceExtensionProperties(this XR thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] Span<uint> propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] Span<ExtensionProperties> properties)
        {
            // SpanOverloader
            return thisApi.EnumerateInstanceExtensionProperties(in layerName.GetPinnableReference(), propertyCapacityInput, ref propertyCountOutput.GetPinnableReference(), ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInstanceExtensionProperties(this XR thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] uint* propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] Span<ExtensionProperties> properties)
        {
            // SpanOverloader
            return thisApi.EnumerateInstanceExtensionProperties(layerName, propertyCapacityInput, propertyCountOutput, ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInstanceExtensionProperties(this XR thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] Span<uint> propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] ExtensionProperties* properties)
        {
            // SpanOverloader
            return thisApi.EnumerateInstanceExtensionProperties(layerName, propertyCapacityInput, ref propertyCountOutput.GetPinnableReference(), properties);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateInstanceExtensionProperties(this XR thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] Span<uint> propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] Span<ExtensionProperties> properties)
        {
            // SpanOverloader
            return thisApi.EnumerateInstanceExtensionProperties(layerName, propertyCapacityInput, ref propertyCountOutput.GetPinnableReference(), ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateReferenceSpaces(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] uint spaceCapacityInput, [Count(Count = 0)] uint* spaceCountOutput, [Count(Parameter = "spaceCapacityInput")] Span<ReferenceSpaceType> spaces)
        {
            // SpanOverloader
            return thisApi.EnumerateReferenceSpaces(session, spaceCapacityInput, spaceCountOutput, ref spaces.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateReferenceSpaces(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] uint spaceCapacityInput, [Count(Count = 0)] Span<uint> spaceCountOutput, [Count(Parameter = "spaceCapacityInput")] ReferenceSpaceType* spaces)
        {
            // SpanOverloader
            return thisApi.EnumerateReferenceSpaces(session, spaceCapacityInput, ref spaceCountOutput.GetPinnableReference(), spaces);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateReferenceSpaces(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] uint spaceCapacityInput, [Count(Count = 0)] Span<uint> spaceCountOutput, [Count(Parameter = "spaceCapacityInput")] Span<ReferenceSpaceType> spaces)
        {
            // SpanOverloader
            return thisApi.EnumerateReferenceSpaces(session, spaceCapacityInput, ref spaceCountOutput.GetPinnableReference(), ref spaces.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSwapchainFormats(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] uint formatCapacityInput, [Count(Count = 0)] uint* formatCountOutput, [Count(Parameter = "formatCapacityInput")] Span<long> formats)
        {
            // SpanOverloader
            return thisApi.EnumerateSwapchainFormats(session, formatCapacityInput, formatCountOutput, ref formats.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSwapchainFormats(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] uint formatCapacityInput, [Count(Count = 0)] Span<uint> formatCountOutput, [Count(Parameter = "formatCapacityInput")] long* formats)
        {
            // SpanOverloader
            return thisApi.EnumerateSwapchainFormats(session, formatCapacityInput, ref formatCountOutput.GetPinnableReference(), formats);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSwapchainFormats(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] uint formatCapacityInput, [Count(Count = 0)] Span<uint> formatCountOutput, [Count(Parameter = "formatCapacityInput")] Span<long> formats)
        {
            // SpanOverloader
            return thisApi.EnumerateSwapchainFormats(session, formatCapacityInput, ref formatCountOutput.GetPinnableReference(), ref formats.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSwapchainImages(this XR thisApi, [Count(Count = 0)] Swapchain swapchain, [Count(Count = 0)] uint imageCapacityInput, [Count(Count = 0)] uint* imageCountOutput, [Count(Parameter = "imageCapacityInput")] Span<SwapchainImageBaseHeader> images)
        {
            // SpanOverloader
            return thisApi.EnumerateSwapchainImages(swapchain, imageCapacityInput, imageCountOutput, ref images.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSwapchainImages(this XR thisApi, [Count(Count = 0)] Swapchain swapchain, [Count(Count = 0)] uint imageCapacityInput, [Count(Count = 0)] Span<uint> imageCountOutput, [Count(Parameter = "imageCapacityInput")] SwapchainImageBaseHeader* images)
        {
            // SpanOverloader
            return thisApi.EnumerateSwapchainImages(swapchain, imageCapacityInput, ref imageCountOutput.GetPinnableReference(), images);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSwapchainImages(this XR thisApi, [Count(Count = 0)] Swapchain swapchain, [Count(Count = 0)] uint imageCapacityInput, [Count(Count = 0)] Span<uint> imageCountOutput, [Count(Parameter = "imageCapacityInput")] Span<SwapchainImageBaseHeader> images)
        {
            // SpanOverloader
            return thisApi.EnumerateSwapchainImages(swapchain, imageCapacityInput, ref imageCountOutput.GetPinnableReference(), ref images.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateViewConfiguration(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint viewConfigurationTypeCapacityInput, [Count(Count = 0)] uint* viewConfigurationTypeCountOutput, [Count(Parameter = "viewConfigurationTypeCapacityInput")] Span<ViewConfigurationType> viewConfigurationTypes)
        {
            // SpanOverloader
            return thisApi.EnumerateViewConfiguration(instance, systemId, viewConfigurationTypeCapacityInput, viewConfigurationTypeCountOutput, ref viewConfigurationTypes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateViewConfiguration(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint viewConfigurationTypeCapacityInput, [Count(Count = 0)] Span<uint> viewConfigurationTypeCountOutput, [Count(Parameter = "viewConfigurationTypeCapacityInput")] ViewConfigurationType* viewConfigurationTypes)
        {
            // SpanOverloader
            return thisApi.EnumerateViewConfiguration(instance, systemId, viewConfigurationTypeCapacityInput, ref viewConfigurationTypeCountOutput.GetPinnableReference(), viewConfigurationTypes);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateViewConfiguration(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint viewConfigurationTypeCapacityInput, [Count(Count = 0)] Span<uint> viewConfigurationTypeCountOutput, [Count(Parameter = "viewConfigurationTypeCapacityInput")] Span<ViewConfigurationType> viewConfigurationTypes)
        {
            // SpanOverloader
            return thisApi.EnumerateViewConfiguration(instance, systemId, viewConfigurationTypeCapacityInput, ref viewConfigurationTypeCountOutput.GetPinnableReference(), ref viewConfigurationTypes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateViewConfigurationView(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] uint* viewCountOutput, [Count(Parameter = "viewCapacityInput")] Span<ViewConfigurationView> views)
        {
            // SpanOverloader
            return thisApi.EnumerateViewConfigurationView(instance, systemId, viewConfigurationType, viewCapacityInput, viewCountOutput, ref views.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateViewConfigurationView(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] Span<uint> viewCountOutput, [Count(Parameter = "viewCapacityInput")] ViewConfigurationView* views)
        {
            // SpanOverloader
            return thisApi.EnumerateViewConfigurationView(instance, systemId, viewConfigurationType, viewCapacityInput, ref viewCountOutput.GetPinnableReference(), views);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateViewConfigurationView(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] Span<uint> viewCountOutput, [Count(Parameter = "viewCapacityInput")] Span<ViewConfigurationView> views)
        {
            // SpanOverloader
            return thisApi.EnumerateViewConfigurationView(instance, systemId, viewConfigurationType, viewCapacityInput, ref viewCountOutput.GetPinnableReference(), ref views.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetActionStateBoolean(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ActionStateGetInfo* getInfo, [Count(Count = 0)] Span<ActionStateBoolean> state)
        {
            // SpanOverloader
            return thisApi.GetActionStateBoolean(session, getInfo, ref state.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetActionStateBoolean(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ActionStateGetInfo> getInfo, [Count(Count = 0)] ActionStateBoolean* state)
        {
            // SpanOverloader
            return thisApi.GetActionStateBoolean(session, in getInfo.GetPinnableReference(), state);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetActionStateBoolean(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ActionStateGetInfo> getInfo, [Count(Count = 0)] Span<ActionStateBoolean> state)
        {
            // SpanOverloader
            return thisApi.GetActionStateBoolean(session, in getInfo.GetPinnableReference(), ref state.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetActionStateFloat(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ActionStateGetInfo* getInfo, [Count(Count = 0)] Span<ActionStateFloat> state)
        {
            // SpanOverloader
            return thisApi.GetActionStateFloat(session, getInfo, ref state.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetActionStateFloat(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ActionStateGetInfo> getInfo, [Count(Count = 0)] ActionStateFloat* state)
        {
            // SpanOverloader
            return thisApi.GetActionStateFloat(session, in getInfo.GetPinnableReference(), state);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetActionStateFloat(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ActionStateGetInfo> getInfo, [Count(Count = 0)] Span<ActionStateFloat> state)
        {
            // SpanOverloader
            return thisApi.GetActionStateFloat(session, in getInfo.GetPinnableReference(), ref state.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetActionStatePose(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ActionStateGetInfo* getInfo, [Count(Count = 0)] Span<ActionStatePose> state)
        {
            // SpanOverloader
            return thisApi.GetActionStatePose(session, getInfo, ref state.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetActionStatePose(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ActionStateGetInfo> getInfo, [Count(Count = 0)] ActionStatePose* state)
        {
            // SpanOverloader
            return thisApi.GetActionStatePose(session, in getInfo.GetPinnableReference(), state);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetActionStatePose(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ActionStateGetInfo> getInfo, [Count(Count = 0)] Span<ActionStatePose> state)
        {
            // SpanOverloader
            return thisApi.GetActionStatePose(session, in getInfo.GetPinnableReference(), ref state.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetActionStateVector2(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ActionStateGetInfo* getInfo, [Count(Count = 0)] Span<ActionStateVector2f> state)
        {
            // SpanOverloader
            return thisApi.GetActionStateVector2(session, getInfo, ref state.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetActionStateVector2(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ActionStateGetInfo> getInfo, [Count(Count = 0)] ActionStateVector2f* state)
        {
            // SpanOverloader
            return thisApi.GetActionStateVector2(session, in getInfo.GetPinnableReference(), state);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetActionStateVector2(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ActionStateGetInfo> getInfo, [Count(Count = 0)] Span<ActionStateVector2f> state)
        {
            // SpanOverloader
            return thisApi.GetActionStateVector2(session, in getInfo.GetPinnableReference(), ref state.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetCurrentInteractionProfile(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] ulong topLevelUserPath, [Count(Count = 0)] Span<InteractionProfileState> interactionProfile)
        {
            // SpanOverloader
            return thisApi.GetCurrentInteractionProfile(session, topLevelUserPath, ref interactionProfile.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetInputSourceLocalizedName(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InputSourceLocalizedNameGetInfo* getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetInputSourceLocalizedName(session, getInfo, bufferCapacityInput, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetInputSourceLocalizedName(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InputSourceLocalizedNameGetInfo* getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer)
        {
            // SpanOverloader
            return thisApi.GetInputSourceLocalizedName(session, getInfo, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetInputSourceLocalizedName(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InputSourceLocalizedNameGetInfo* getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetInputSourceLocalizedName(session, getInfo, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetInputSourceLocalizedName(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InputSourceLocalizedNameGetInfo* getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer)
        {
            // SpanOverloader
            return thisApi.GetInputSourceLocalizedName(session, getInfo, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetInputSourceLocalizedName(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InputSourceLocalizedNameGetInfo> getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer)
        {
            // SpanOverloader
            return thisApi.GetInputSourceLocalizedName(session, in getInfo.GetPinnableReference(), bufferCapacityInput, bufferCountOutput, buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetInputSourceLocalizedName(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InputSourceLocalizedNameGetInfo> getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetInputSourceLocalizedName(session, in getInfo.GetPinnableReference(), bufferCapacityInput, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetInputSourceLocalizedName(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InputSourceLocalizedNameGetInfo> getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer)
        {
            // SpanOverloader
            return thisApi.GetInputSourceLocalizedName(session, in getInfo.GetPinnableReference(), bufferCapacityInput, bufferCountOutput, buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetInputSourceLocalizedName(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InputSourceLocalizedNameGetInfo> getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer)
        {
            // SpanOverloader
            return thisApi.GetInputSourceLocalizedName(session, in getInfo.GetPinnableReference(), bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetInputSourceLocalizedName(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InputSourceLocalizedNameGetInfo> getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetInputSourceLocalizedName(session, in getInfo.GetPinnableReference(), bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetInputSourceLocalizedName(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InputSourceLocalizedNameGetInfo> getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer)
        {
            // SpanOverloader
            return thisApi.GetInputSourceLocalizedName(session, in getInfo.GetPinnableReference(), bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetInstanceProcAddr(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, [Count(Count = 0)] Span<PfnVoidFunction> function)
        {
            // SpanOverloader
            return thisApi.GetInstanceProcAddr(instance, name, ref function.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetInstanceProcAddr(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Count(Count = 0)] PfnVoidFunction* function)
        {
            // SpanOverloader
            return thisApi.GetInstanceProcAddr(instance, in name.GetPinnableReference(), function);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetInstanceProcAddr(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Count(Count = 0)] Span<PfnVoidFunction> function)
        {
            // SpanOverloader
            return thisApi.GetInstanceProcAddr(instance, in name.GetPinnableReference(), ref function.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetInstanceProcAddr(this XR thisApi, [Count(Count = 0)] Instance instance, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Count(Count = 0)] Span<PfnVoidFunction> function)
        {
            // SpanOverloader
            return thisApi.GetInstanceProcAddr(instance, name, ref function.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetInstanceProperties(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] Span<InstanceProperties> instanceProperties)
        {
            // SpanOverloader
            return thisApi.GetInstanceProperties(instance, ref instanceProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetReferenceSpaceBoundsRect(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] ReferenceSpaceType referenceSpaceType, [Count(Count = 0)] Span<Extent2Df> bounds)
        {
            // SpanOverloader
            return thisApi.GetReferenceSpaceBoundsRect(session, referenceSpaceType, ref bounds.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSystem(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SystemGetInfo* getInfo, [Count(Count = 0)] Span<ulong> systemId)
        {
            // SpanOverloader
            return thisApi.GetSystem(instance, getInfo, ref systemId.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSystem(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SystemGetInfo> getInfo, [Count(Count = 0)] ulong* systemId)
        {
            // SpanOverloader
            return thisApi.GetSystem(instance, in getInfo.GetPinnableReference(), systemId);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSystem(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SystemGetInfo> getInfo, [Count(Count = 0)] Span<ulong> systemId)
        {
            // SpanOverloader
            return thisApi.GetSystem(instance, in getInfo.GetPinnableReference(), ref systemId.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSystemProperties(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] Span<SystemProperties> properties)
        {
            // SpanOverloader
            return thisApi.GetSystemProperties(instance, systemId, ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetViewConfigurationProperties(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] Span<ViewConfigurationProperties> configurationProperties)
        {
            // SpanOverloader
            return thisApi.GetViewConfigurationProperties(instance, systemId, viewConfigurationType, ref configurationProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateSpace(this XR thisApi, [Count(Count = 0)] Space space, [Count(Count = 0)] Space baseSpace, [Count(Count = 0)] long time, [Count(Count = 0)] Span<SpaceLocation> location)
        {
            // SpanOverloader
            return thisApi.LocateSpace(space, baseSpace, time, ref location.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateView(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ViewLocateInfo* viewLocateInfo, [Count(Count = 0)] ViewState* viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] uint* viewCountOutput, [Count(Parameter = "viewCapacityInput")] Span<View> views)
        {
            // SpanOverloader
            return thisApi.LocateView(session, viewLocateInfo, viewState, viewCapacityInput, viewCountOutput, ref views.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateView(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ViewLocateInfo* viewLocateInfo, [Count(Count = 0)] ViewState* viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] Span<uint> viewCountOutput, [Count(Parameter = "viewCapacityInput")] View* views)
        {
            // SpanOverloader
            return thisApi.LocateView(session, viewLocateInfo, viewState, viewCapacityInput, ref viewCountOutput.GetPinnableReference(), views);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateView(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ViewLocateInfo* viewLocateInfo, [Count(Count = 0)] ViewState* viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] Span<uint> viewCountOutput, [Count(Parameter = "viewCapacityInput")] Span<View> views)
        {
            // SpanOverloader
            return thisApi.LocateView(session, viewLocateInfo, viewState, viewCapacityInput, ref viewCountOutput.GetPinnableReference(), ref views.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateView(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ViewLocateInfo* viewLocateInfo, [Count(Count = 0)] Span<ViewState> viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] uint* viewCountOutput, [Count(Parameter = "viewCapacityInput")] View* views)
        {
            // SpanOverloader
            return thisApi.LocateView(session, viewLocateInfo, ref viewState.GetPinnableReference(), viewCapacityInput, viewCountOutput, views);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateView(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ViewLocateInfo* viewLocateInfo, [Count(Count = 0)] Span<ViewState> viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] uint* viewCountOutput, [Count(Parameter = "viewCapacityInput")] Span<View> views)
        {
            // SpanOverloader
            return thisApi.LocateView(session, viewLocateInfo, ref viewState.GetPinnableReference(), viewCapacityInput, viewCountOutput, ref views.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateView(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ViewLocateInfo* viewLocateInfo, [Count(Count = 0)] Span<ViewState> viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] Span<uint> viewCountOutput, [Count(Parameter = "viewCapacityInput")] View* views)
        {
            // SpanOverloader
            return thisApi.LocateView(session, viewLocateInfo, ref viewState.GetPinnableReference(), viewCapacityInput, ref viewCountOutput.GetPinnableReference(), views);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateView(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ViewLocateInfo* viewLocateInfo, [Count(Count = 0)] Span<ViewState> viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] Span<uint> viewCountOutput, [Count(Parameter = "viewCapacityInput")] Span<View> views)
        {
            // SpanOverloader
            return thisApi.LocateView(session, viewLocateInfo, ref viewState.GetPinnableReference(), viewCapacityInput, ref viewCountOutput.GetPinnableReference(), ref views.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateView(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ViewLocateInfo> viewLocateInfo, [Count(Count = 0)] ViewState* viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] uint* viewCountOutput, [Count(Parameter = "viewCapacityInput")] View* views)
        {
            // SpanOverloader
            return thisApi.LocateView(session, in viewLocateInfo.GetPinnableReference(), viewState, viewCapacityInput, viewCountOutput, views);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateView(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ViewLocateInfo> viewLocateInfo, [Count(Count = 0)] ViewState* viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] uint* viewCountOutput, [Count(Parameter = "viewCapacityInput")] Span<View> views)
        {
            // SpanOverloader
            return thisApi.LocateView(session, in viewLocateInfo.GetPinnableReference(), viewState, viewCapacityInput, viewCountOutput, ref views.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateView(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ViewLocateInfo> viewLocateInfo, [Count(Count = 0)] ViewState* viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] Span<uint> viewCountOutput, [Count(Parameter = "viewCapacityInput")] View* views)
        {
            // SpanOverloader
            return thisApi.LocateView(session, in viewLocateInfo.GetPinnableReference(), viewState, viewCapacityInput, ref viewCountOutput.GetPinnableReference(), views);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateView(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ViewLocateInfo> viewLocateInfo, [Count(Count = 0)] ViewState* viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] Span<uint> viewCountOutput, [Count(Parameter = "viewCapacityInput")] Span<View> views)
        {
            // SpanOverloader
            return thisApi.LocateView(session, in viewLocateInfo.GetPinnableReference(), viewState, viewCapacityInput, ref viewCountOutput.GetPinnableReference(), ref views.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateView(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ViewLocateInfo> viewLocateInfo, [Count(Count = 0)] Span<ViewState> viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] uint* viewCountOutput, [Count(Parameter = "viewCapacityInput")] View* views)
        {
            // SpanOverloader
            return thisApi.LocateView(session, in viewLocateInfo.GetPinnableReference(), ref viewState.GetPinnableReference(), viewCapacityInput, viewCountOutput, views);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateView(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ViewLocateInfo> viewLocateInfo, [Count(Count = 0)] Span<ViewState> viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] uint* viewCountOutput, [Count(Parameter = "viewCapacityInput")] Span<View> views)
        {
            // SpanOverloader
            return thisApi.LocateView(session, in viewLocateInfo.GetPinnableReference(), ref viewState.GetPinnableReference(), viewCapacityInput, viewCountOutput, ref views.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateView(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ViewLocateInfo> viewLocateInfo, [Count(Count = 0)] Span<ViewState> viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] Span<uint> viewCountOutput, [Count(Parameter = "viewCapacityInput")] View* views)
        {
            // SpanOverloader
            return thisApi.LocateView(session, in viewLocateInfo.GetPinnableReference(), ref viewState.GetPinnableReference(), viewCapacityInput, ref viewCountOutput.GetPinnableReference(), views);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateView(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ViewLocateInfo> viewLocateInfo, [Count(Count = 0)] Span<ViewState> viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] Span<uint> viewCountOutput, [Count(Parameter = "viewCapacityInput")] Span<View> views)
        {
            // SpanOverloader
            return thisApi.LocateView(session, in viewLocateInfo.GetPinnableReference(), ref viewState.GetPinnableReference(), viewCapacityInput, ref viewCountOutput.GetPinnableReference(), ref views.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result PathToString(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong path, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.PathToString(instance, path, bufferCapacityInput, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result PathToString(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong path, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer)
        {
            // SpanOverloader
            return thisApi.PathToString(instance, path, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result PathToString(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong path, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.PathToString(instance, path, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result PathToString(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong path, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer)
        {
            // SpanOverloader
            return thisApi.PathToString(instance, path, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result PollEvent(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] Span<EventDataBuffer> eventData)
        {
            // SpanOverloader
            return thisApi.PollEvent(instance, ref eventData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ReleaseSwapchainImage(this XR thisApi, [Count(Count = 0)] Swapchain swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapchainImageReleaseInfo> releaseInfo)
        {
            // SpanOverloader
            return thisApi.ReleaseSwapchainImage(swapchain, in releaseInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ResultToString(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] Result value, [Count(Computed = "XR_MAX_RESULT_STRING_SIZE")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.ResultToString(instance, value, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result StopHapticFeedback(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HapticActionInfo> hapticActionInfo)
        {
            // SpanOverloader
            return thisApi.StopHapticFeedback(session, in hapticActionInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result StringToPath(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pathString, [Count(Count = 0)] Span<ulong> path)
        {
            // SpanOverloader
            return thisApi.StringToPath(instance, pathString, ref path.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result StringToPath(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pathString, [Count(Count = 0)] ulong* path)
        {
            // SpanOverloader
            return thisApi.StringToPath(instance, in pathString.GetPinnableReference(), path);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result StringToPath(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pathString, [Count(Count = 0)] Span<ulong> path)
        {
            // SpanOverloader
            return thisApi.StringToPath(instance, in pathString.GetPinnableReference(), ref path.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result StringToPath(this XR thisApi, [Count(Count = 0)] Instance instance, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pathString, [Count(Count = 0)] Span<ulong> path)
        {
            // SpanOverloader
            return thisApi.StringToPath(instance, pathString, ref path.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result StructureTypeToString(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] StructureType value, [Count(Computed = "XR_MAX_STRUCTURE_NAME_SIZE")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.StructureTypeToString(instance, value, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result SuggestInteractionProfileBinding(this XR thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InteractionProfileSuggestedBinding> suggestedBindings)
        {
            // SpanOverloader
            return thisApi.SuggestInteractionProfileBinding(instance, in suggestedBindings.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result SyncAction(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ActionsSyncInfo> syncInfo)
        {
            // SpanOverloader
            return thisApi.SyncAction(session, in syncInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result WaitFrame(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FrameWaitInfo* frameWaitInfo, [Count(Count = 0)] Span<FrameState> frameState)
        {
            // SpanOverloader
            return thisApi.WaitFrame(session, frameWaitInfo, ref frameState.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result WaitFrame(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FrameWaitInfo> frameWaitInfo, [Count(Count = 0)] FrameState* frameState)
        {
            // SpanOverloader
            return thisApi.WaitFrame(session, in frameWaitInfo.GetPinnableReference(), frameState);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result WaitFrame(this XR thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FrameWaitInfo> frameWaitInfo, [Count(Count = 0)] Span<FrameState> frameState)
        {
            // SpanOverloader
            return thisApi.WaitFrame(session, in frameWaitInfo.GetPinnableReference(), ref frameState.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result WaitSwapchainImage(this XR thisApi, [Count(Count = 0)] Swapchain swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapchainImageWaitInfo> waitInfo)
        {
            // SpanOverloader
            return thisApi.WaitSwapchainImage(swapchain, in waitInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateApiLayerInstance(this XR thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InstanceCreateInfo* info, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ApiLayerCreateInfo* layerInfo, [Count(Count = 0)] Span<Instance> instance)
        {
            // SpanOverloader
            return thisApi.CreateApiLayerInstance(info, layerInfo, ref instance.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateApiLayerInstance(this XR thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InstanceCreateInfo* info, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ApiLayerCreateInfo> layerInfo, [Count(Count = 0)] Instance* instance)
        {
            // SpanOverloader
            return thisApi.CreateApiLayerInstance(info, in layerInfo.GetPinnableReference(), instance);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateApiLayerInstance(this XR thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InstanceCreateInfo* info, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ApiLayerCreateInfo> layerInfo, [Count(Count = 0)] Span<Instance> instance)
        {
            // SpanOverloader
            return thisApi.CreateApiLayerInstance(info, in layerInfo.GetPinnableReference(), ref instance.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateApiLayerInstance(this XR thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InstanceCreateInfo> info, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ApiLayerCreateInfo* layerInfo, [Count(Count = 0)] Instance* instance)
        {
            // SpanOverloader
            return thisApi.CreateApiLayerInstance(in info.GetPinnableReference(), layerInfo, instance);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateApiLayerInstance(this XR thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InstanceCreateInfo> info, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ApiLayerCreateInfo* layerInfo, [Count(Count = 0)] Span<Instance> instance)
        {
            // SpanOverloader
            return thisApi.CreateApiLayerInstance(in info.GetPinnableReference(), layerInfo, ref instance.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateApiLayerInstance(this XR thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InstanceCreateInfo> info, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ApiLayerCreateInfo> layerInfo, [Count(Count = 0)] Instance* instance)
        {
            // SpanOverloader
            return thisApi.CreateApiLayerInstance(in info.GetPinnableReference(), in layerInfo.GetPinnableReference(), instance);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateApiLayerInstance(this XR thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InstanceCreateInfo> info, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ApiLayerCreateInfo> layerInfo, [Count(Count = 0)] Span<Instance> instance)
        {
            // SpanOverloader
            return thisApi.CreateApiLayerInstance(in info.GetPinnableReference(), in layerInfo.GetPinnableReference(), ref instance.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result NegotiateLoaderApiLayerInterface(this XR thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] NegotiateLoaderInfo* loaderInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* layerName, [Count(Count = 0)] Span<NegotiateApiLayerRequest> apiLayerRequest)
        {
            // SpanOverloader
            return thisApi.NegotiateLoaderApiLayerInterface(loaderInfo, layerName, ref apiLayerRequest.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result NegotiateLoaderApiLayerInterface(this XR thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] NegotiateLoaderInfo* loaderInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> layerName, [Count(Count = 0)] NegotiateApiLayerRequest* apiLayerRequest)
        {
            // SpanOverloader
            return thisApi.NegotiateLoaderApiLayerInterface(loaderInfo, in layerName.GetPinnableReference(), apiLayerRequest);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result NegotiateLoaderApiLayerInterface(this XR thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] NegotiateLoaderInfo* loaderInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> layerName, [Count(Count = 0)] Span<NegotiateApiLayerRequest> apiLayerRequest)
        {
            // SpanOverloader
            return thisApi.NegotiateLoaderApiLayerInterface(loaderInfo, in layerName.GetPinnableReference(), ref apiLayerRequest.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result NegotiateLoaderApiLayerInterface(this XR thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] NegotiateLoaderInfo* loaderInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string layerName, [Count(Count = 0)] Span<NegotiateApiLayerRequest> apiLayerRequest)
        {
            // SpanOverloader
            return thisApi.NegotiateLoaderApiLayerInterface(loaderInfo, layerName, ref apiLayerRequest.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result NegotiateLoaderApiLayerInterface(this XR thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<NegotiateLoaderInfo> loaderInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* layerName, [Count(Count = 0)] NegotiateApiLayerRequest* apiLayerRequest)
        {
            // SpanOverloader
            return thisApi.NegotiateLoaderApiLayerInterface(in loaderInfo.GetPinnableReference(), layerName, apiLayerRequest);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result NegotiateLoaderApiLayerInterface(this XR thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<NegotiateLoaderInfo> loaderInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* layerName, [Count(Count = 0)] Span<NegotiateApiLayerRequest> apiLayerRequest)
        {
            // SpanOverloader
            return thisApi.NegotiateLoaderApiLayerInterface(in loaderInfo.GetPinnableReference(), layerName, ref apiLayerRequest.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result NegotiateLoaderApiLayerInterface(this XR thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<NegotiateLoaderInfo> loaderInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> layerName, [Count(Count = 0)] NegotiateApiLayerRequest* apiLayerRequest)
        {
            // SpanOverloader
            return thisApi.NegotiateLoaderApiLayerInterface(in loaderInfo.GetPinnableReference(), in layerName.GetPinnableReference(), apiLayerRequest);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result NegotiateLoaderApiLayerInterface(this XR thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<NegotiateLoaderInfo> loaderInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> layerName, [Count(Count = 0)] Span<NegotiateApiLayerRequest> apiLayerRequest)
        {
            // SpanOverloader
            return thisApi.NegotiateLoaderApiLayerInterface(in loaderInfo.GetPinnableReference(), in layerName.GetPinnableReference(), ref apiLayerRequest.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result NegotiateLoaderApiLayerInterface(this XR thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<NegotiateLoaderInfo> loaderInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string layerName, [Count(Count = 0)] NegotiateApiLayerRequest* apiLayerRequest)
        {
            // SpanOverloader
            return thisApi.NegotiateLoaderApiLayerInterface(in loaderInfo.GetPinnableReference(), layerName, apiLayerRequest);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result NegotiateLoaderApiLayerInterface(this XR thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<NegotiateLoaderInfo> loaderInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string layerName, [Count(Count = 0)] Span<NegotiateApiLayerRequest> apiLayerRequest)
        {
            // SpanOverloader
            return thisApi.NegotiateLoaderApiLayerInterface(in loaderInfo.GetPinnableReference(), layerName, ref apiLayerRequest.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result NegotiateLoaderRuntimeInterface(this XR thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] NegotiateLoaderInfo* loaderInfo, [Count(Count = 0)] Span<NegotiateRuntimeRequest> runtimeRequest)
        {
            // SpanOverloader
            return thisApi.NegotiateLoaderRuntimeInterface(loaderInfo, ref runtimeRequest.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result NegotiateLoaderRuntimeInterface(this XR thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<NegotiateLoaderInfo> loaderInfo, [Count(Count = 0)] NegotiateRuntimeRequest* runtimeRequest)
        {
            // SpanOverloader
            return thisApi.NegotiateLoaderRuntimeInterface(in loaderInfo.GetPinnableReference(), runtimeRequest);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result NegotiateLoaderRuntimeInterface(this XR thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<NegotiateLoaderInfo> loaderInfo, [Count(Count = 0)] Span<NegotiateRuntimeRequest> runtimeRequest)
        {
            // SpanOverloader
            return thisApi.NegotiateLoaderRuntimeInterface(in loaderInfo.GetPinnableReference(), ref runtimeRequest.GetPinnableReference());
        }

    }
}

