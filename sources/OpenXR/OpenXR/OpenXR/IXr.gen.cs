// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

public unsafe partial interface IXr
{
    public partial interface Static
    {
        [NativeName("xrAcquireSwapchainImage")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrAcquireSwapchainImage")]
        static abstract Result AcquireSwapchainImage(
            SwapchainHandle swapchain,
            SwapchainImageAcquireInfo* acquireInfo,
            uint* index
        );

        [NativeName("xrAcquireSwapchainImage")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrAcquireSwapchainImage")]
        static abstract Result AcquireSwapchainImage(
            SwapchainHandle swapchain,
            Ref<SwapchainImageAcquireInfo> acquireInfo,
            Ref<uint> index
        );

        [NativeName("xrApplyHapticFeedback")]
        [SupportedApiProfile(
            "openxr",
            [
                "XR_EXT_haptic_parametric",
                "XR_LOADER_VERSION_1_0",
                "XR_VERSION_1_0",
                "XR_VERSION_1_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrApplyHapticFeedback")]
        static abstract Result ApplyHapticFeedback(
            SessionHandle session,
            HapticActionInfo* hapticActionInfo,
            HapticBaseHeader* hapticFeedback
        );

        [NativeName("xrApplyHapticFeedback")]
        [SupportedApiProfile(
            "openxr",
            [
                "XR_EXT_haptic_parametric",
                "XR_LOADER_VERSION_1_0",
                "XR_VERSION_1_0",
                "XR_VERSION_1_1",
            ],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrApplyHapticFeedback")]
        static abstract Result ApplyHapticFeedback(
            SessionHandle session,
            Ref<HapticActionInfo> hapticActionInfo,
            Ref<HapticBaseHeader> hapticFeedback
        );

        [NativeName("xrAttachSessionActionSets")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrAttachSessionActionSets")]
        static abstract Result AttachSessionActionSets(
            SessionHandle session,
            SessionActionSetsAttachInfo* attachInfo
        );

        [NativeName("xrAttachSessionActionSets")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrAttachSessionActionSets")]
        static abstract Result AttachSessionActionSets(
            SessionHandle session,
            Ref<SessionActionSetsAttachInfo> attachInfo
        );

        [NativeName("xrBeginFrame")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrBeginFrame")]
        static abstract Result BeginFrame(SessionHandle session, FrameBeginInfo* frameBeginInfo);

        [NativeName("xrBeginFrame")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrBeginFrame")]
        static abstract Result BeginFrame(
            SessionHandle session,
            Ref<FrameBeginInfo> frameBeginInfo
        );

        [NativeName("xrBeginSession")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrBeginSession")]
        static abstract Result BeginSession(SessionHandle session, SessionBeginInfo* beginInfo);

        [NativeName("xrBeginSession")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrBeginSession")]
        static abstract Result BeginSession(SessionHandle session, Ref<SessionBeginInfo> beginInfo);

        [NativeName("xrCreateAction")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateAction")]
        static abstract Result CreateAction(
            ActionSetHandle actionSet,
            ActionCreateInfo* createInfo,
            ActionHandle* action
        );

        [NativeName("xrCreateAction")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateAction")]
        static abstract Result CreateAction(
            ActionSetHandle actionSet,
            Ref<ActionCreateInfo> createInfo,
            Ref<ActionHandle> action
        );

        [NativeName("xrCreateActionSet")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateActionSet")]
        static abstract Result CreateActionSet(
            InstanceHandle instance,
            ActionSetCreateInfo* createInfo,
            ActionSetHandle* actionSet
        );

        [NativeName("xrCreateActionSet")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateActionSet")]
        static abstract Result CreateActionSet(
            InstanceHandle instance,
            Ref<ActionSetCreateInfo> createInfo,
            Ref<ActionSetHandle> actionSet
        );

        [NativeName("xrCreateActionSpace")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateActionSpace")]
        static abstract Result CreateActionSpace(
            SessionHandle session,
            ActionSpaceCreateInfo* createInfo,
            SpaceHandle* space
        );

        [NativeName("xrCreateActionSpace")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateActionSpace")]
        static abstract Result CreateActionSpace(
            SessionHandle session,
            Ref<ActionSpaceCreateInfo> createInfo,
            Ref<SpaceHandle> space
        );

        [NativeName("xrCreateInstance")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateInstance")]
        static abstract Result CreateInstance(
            InstanceCreateInfo* createInfo,
            InstanceHandle* instance
        );

        [NativeName("xrCreateInstance")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateInstance")]
        static abstract Result CreateInstance(
            Ref<InstanceCreateInfo> createInfo,
            Ref<InstanceHandle> instance
        );

        [NativeName("xrCreateReferenceSpace")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateReferenceSpace")]
        static abstract Result CreateReferenceSpace(
            SessionHandle session,
            ReferenceSpaceCreateInfo* createInfo,
            SpaceHandle* space
        );

        [NativeName("xrCreateReferenceSpace")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateReferenceSpace")]
        static abstract Result CreateReferenceSpace(
            SessionHandle session,
            Ref<ReferenceSpaceCreateInfo> createInfo,
            Ref<SpaceHandle> space
        );

        [NativeName("xrCreateSession")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateSession")]
        static abstract Result CreateSession(
            InstanceHandle instance,
            SessionCreateInfo* createInfo,
            SessionHandle* session
        );

        [NativeName("xrCreateSession")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateSession")]
        static abstract Result CreateSession(
            InstanceHandle instance,
            Ref<SessionCreateInfo> createInfo,
            Ref<SessionHandle> session
        );

        [NativeName("xrCreateSwapchain")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateSwapchain")]
        static abstract Result CreateSwapchain(
            SessionHandle session,
            SwapchainCreateInfo* createInfo,
            SwapchainHandle* swapchain
        );

        [NativeName("xrCreateSwapchain")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateSwapchain")]
        static abstract Result CreateSwapchain(
            SessionHandle session,
            Ref<SwapchainCreateInfo> createInfo,
            Ref<SwapchainHandle> swapchain
        );

        [NativeName("xrDestroyAction")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrDestroyAction")]
        static abstract Result DestroyAction(ActionHandle action);

        [NativeName("xrDestroyActionSet")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrDestroyActionSet")]
        static abstract Result DestroyActionSet(ActionSetHandle actionSet);

        [NativeName("xrDestroyInstance")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrDestroyInstance")]
        static abstract Result DestroyInstance(InstanceHandle instance);

        [NativeName("xrDestroySession")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrDestroySession")]
        static abstract Result DestroySession(SessionHandle session);

        [NativeName("xrDestroySpace")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrDestroySpace")]
        static abstract Result DestroySpace(SpaceHandle space);

        [NativeName("xrDestroySwapchain")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrDestroySwapchain")]
        static abstract Result DestroySwapchain(SwapchainHandle swapchain);

        [NativeName("xrEndFrame")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEndFrame")]
        static abstract Result EndFrame(SessionHandle session, FrameEndInfo* frameEndInfo);

        [NativeName("xrEndFrame")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEndFrame")]
        static abstract Result EndFrame(SessionHandle session, Ref<FrameEndInfo> frameEndInfo);

        [NativeName("xrEndSession")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEndSession")]
        static abstract Result EndSession(SessionHandle session);

        [NativeName("xrEnumerateApiLayerProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateApiLayerProperties")]
        static abstract Result EnumerateApiLayerProperties(
            uint propertyCapacityInput,
            uint* propertyCountOutput,
            ApiLayerProperties* properties
        );

        [NativeName("xrEnumerateApiLayerProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateApiLayerProperties")]
        static abstract Result EnumerateApiLayerProperties(
            uint propertyCapacityInput,
            Ref<uint> propertyCountOutput,
            Ref<ApiLayerProperties> properties
        );

        [NativeName("xrEnumerateBoundSourcesForAction")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateBoundSourcesForAction")]
        static abstract Result EnumerateBoundSourcesForAction(
            SessionHandle session,
            BoundSourcesForActionEnumerateInfo* enumerateInfo,
            uint sourceCapacityInput,
            uint* sourceCountOutput,
            ulong* sources
        );

        [NativeName("xrEnumerateBoundSourcesForAction")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateBoundSourcesForAction")]
        static abstract Result EnumerateBoundSourcesForAction(
            SessionHandle session,
            Ref<BoundSourcesForActionEnumerateInfo> enumerateInfo,
            uint sourceCapacityInput,
            Ref<uint> sourceCountOutput,
            Ref<ulong> sources
        );

        [NativeName("xrEnumerateEnvironmentBlendModes")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateEnvironmentBlendModes")]
        static abstract Result EnumerateEnvironmentBlendModes(
            InstanceHandle instance,
            ulong systemId,
            ViewConfigurationType viewConfigurationType,
            uint environmentBlendModeCapacityInput,
            uint* environmentBlendModeCountOutput,
            EnvironmentBlendMode* environmentBlendModes
        );

        [NativeName("xrEnumerateEnvironmentBlendModes")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateEnvironmentBlendModes")]
        static abstract Result EnumerateEnvironmentBlendModes(
            InstanceHandle instance,
            ulong systemId,
            ViewConfigurationType viewConfigurationType,
            uint environmentBlendModeCapacityInput,
            Ref<uint> environmentBlendModeCountOutput,
            Ref<EnvironmentBlendMode> environmentBlendModes
        );

        [NativeName("xrEnumerateInstanceExtensionProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateInstanceExtensionProperties")]
        static abstract Result EnumerateInstanceExtensionProperties(
            sbyte* layerName,
            uint propertyCapacityInput,
            uint* propertyCountOutput,
            ExtensionProperties* properties
        );

        [NativeName("xrEnumerateInstanceExtensionProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateInstanceExtensionProperties")]
        static abstract Result EnumerateInstanceExtensionProperties(
            Ref<sbyte> layerName,
            uint propertyCapacityInput,
            Ref<uint> propertyCountOutput,
            Ref<ExtensionProperties> properties
        );

        [NativeName("xrEnumerateReferenceSpaces")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateReferenceSpaces")]
        static abstract Result EnumerateReferenceSpaces(
            SessionHandle session,
            uint spaceCapacityInput,
            uint* spaceCountOutput,
            ReferenceSpaceType* spaces
        );

        [NativeName("xrEnumerateReferenceSpaces")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateReferenceSpaces")]
        static abstract Result EnumerateReferenceSpaces(
            SessionHandle session,
            uint spaceCapacityInput,
            Ref<uint> spaceCountOutput,
            Ref<ReferenceSpaceType> spaces
        );

        [NativeName("xrEnumerateSwapchainFormats")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateSwapchainFormats")]
        static abstract Result EnumerateSwapchainFormats(
            SessionHandle session,
            uint formatCapacityInput,
            uint* formatCountOutput,
            long* formats
        );

        [NativeName("xrEnumerateSwapchainFormats")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateSwapchainFormats")]
        static abstract Result EnumerateSwapchainFormats(
            SessionHandle session,
            uint formatCapacityInput,
            Ref<uint> formatCountOutput,
            Ref<long> formats
        );

        [NativeName("xrEnumerateSwapchainImages")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateSwapchainImages")]
        static abstract Result EnumerateSwapchainImages(
            SwapchainHandle swapchain,
            uint imageCapacityInput,
            uint* imageCountOutput,
            SwapchainImageBaseHeader* images
        );

        [NativeName("xrEnumerateSwapchainImages")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateSwapchainImages")]
        static abstract Result EnumerateSwapchainImages(
            SwapchainHandle swapchain,
            uint imageCapacityInput,
            Ref<uint> imageCountOutput,
            Ref<SwapchainImageBaseHeader> images
        );

        [NativeName("xrEnumerateViewConfigurations")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateViewConfigurations")]
        static abstract Result EnumerateViewConfigurations(
            InstanceHandle instance,
            ulong systemId,
            uint viewConfigurationTypeCapacityInput,
            uint* viewConfigurationTypeCountOutput,
            ViewConfigurationType* viewConfigurationTypes
        );

        [NativeName("xrEnumerateViewConfigurations")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateViewConfigurations")]
        static abstract Result EnumerateViewConfigurations(
            InstanceHandle instance,
            ulong systemId,
            uint viewConfigurationTypeCapacityInput,
            Ref<uint> viewConfigurationTypeCountOutput,
            Ref<ViewConfigurationType> viewConfigurationTypes
        );

        [NativeName("xrEnumerateViewConfigurationViews")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateViewConfigurationViews")]
        static abstract Result EnumerateViewConfigurationViews(
            InstanceHandle instance,
            ulong systemId,
            ViewConfigurationType viewConfigurationType,
            uint viewCapacityInput,
            uint* viewCountOutput,
            ViewConfigurationView* views
        );

        [NativeName("xrEnumerateViewConfigurationViews")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateViewConfigurationViews")]
        static abstract Result EnumerateViewConfigurationViews(
            InstanceHandle instance,
            ulong systemId,
            ViewConfigurationType viewConfigurationType,
            uint viewCapacityInput,
            Ref<uint> viewCountOutput,
            Ref<ViewConfigurationView> views
        );

        [NativeName("xrGetActionStateBoolean")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateBoolean")]
        static abstract Result GetActionStateBoolean(
            SessionHandle session,
            ActionStateGetInfo* getInfo,
            ActionStateBoolean* state
        );

        [NativeName("xrGetActionStateBoolean")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateBoolean")]
        static abstract Result GetActionStateBoolean(
            SessionHandle session,
            Ref<ActionStateGetInfo> getInfo,
            Ref<ActionStateBoolean> state
        );

        [NativeName("xrGetActionStateFloat")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateFloat")]
        static abstract Result GetActionStateFloat(
            SessionHandle session,
            ActionStateGetInfo* getInfo,
            ActionStateFloat* state
        );

        [NativeName("xrGetActionStateFloat")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateFloat")]
        static abstract Result GetActionStateFloat(
            SessionHandle session,
            Ref<ActionStateGetInfo> getInfo,
            Ref<ActionStateFloat> state
        );

        [NativeName("xrGetActionStatePose")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStatePose")]
        static abstract Result GetActionStatePose(
            SessionHandle session,
            ActionStateGetInfo* getInfo,
            ActionStatePose* state
        );

        [NativeName("xrGetActionStatePose")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStatePose")]
        static abstract Result GetActionStatePose(
            SessionHandle session,
            Ref<ActionStateGetInfo> getInfo,
            Ref<ActionStatePose> state
        );

        [NativeName("xrGetActionStateVector2f")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateVector2f")]
        static abstract Result GetActionStateVector2F(
            SessionHandle session,
            ActionStateGetInfo* getInfo,
            ActionStateVector2F* state
        );

        [NativeName("xrGetActionStateVector2f")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateVector2f")]
        static abstract Result GetActionStateVector2F(
            SessionHandle session,
            Ref<ActionStateGetInfo> getInfo,
            Ref<ActionStateVector2F> state
        );

        [NativeName("xrGetCurrentInteractionProfile")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetCurrentInteractionProfile")]
        static abstract Result GetCurrentInteractionProfile(
            SessionHandle session,
            ulong topLevelUserPath,
            InteractionProfileState* interactionProfile
        );

        [NativeName("xrGetCurrentInteractionProfile")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetCurrentInteractionProfile")]
        static abstract Result GetCurrentInteractionProfile(
            SessionHandle session,
            ulong topLevelUserPath,
            Ref<InteractionProfileState> interactionProfile
        );

        [NativeName("xrGetInputSourceLocalizedName")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetInputSourceLocalizedName")]
        static abstract Result GetInputSourceLocalizedName(
            SessionHandle session,
            InputSourceLocalizedNameGetInfo* getInfo,
            uint bufferCapacityInput,
            uint* bufferCountOutput,
            sbyte* buffer
        );

        [NativeName("xrGetInputSourceLocalizedName")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetInputSourceLocalizedName")]
        static abstract Result GetInputSourceLocalizedName(
            SessionHandle session,
            Ref<InputSourceLocalizedNameGetInfo> getInfo,
            uint bufferCapacityInput,
            Ref<uint> bufferCountOutput,
            Ref<sbyte> buffer
        );

        [NativeName("xrGetInstanceProcAddr")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetInstanceProcAddr")]
        static abstract Result GetInstanceProcAddr(
            InstanceHandle instance,
            sbyte* name,
            VoidFunction* function
        );

        [NativeName("xrGetInstanceProcAddr")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetInstanceProcAddr")]
        static abstract Result GetInstanceProcAddr(
            InstanceHandle instance,
            Ref<sbyte> name,
            Ref<VoidFunction> function
        );

        [NativeName("xrGetInstanceProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetInstanceProperties")]
        static abstract Result GetInstanceProperties(
            InstanceHandle instance,
            InstanceProperties* instanceProperties
        );

        [NativeName("xrGetInstanceProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetInstanceProperties")]
        static abstract Result GetInstanceProperties(
            InstanceHandle instance,
            Ref<InstanceProperties> instanceProperties
        );

        [NativeName("xrGetReferenceSpaceBoundsRect")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetReferenceSpaceBoundsRect")]
        static abstract Result GetReferenceSpaceBoundsRect(
            SessionHandle session,
            ReferenceSpaceType referenceSpaceType,
            Extent2Df* bounds
        );

        [NativeName("xrGetReferenceSpaceBoundsRect")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetReferenceSpaceBoundsRect")]
        static abstract Result GetReferenceSpaceBoundsRect(
            SessionHandle session,
            ReferenceSpaceType referenceSpaceType,
            Ref<Extent2Df> bounds
        );

        [NativeName("xrGetSystem")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetSystem")]
        static abstract Result GetSystem(
            InstanceHandle instance,
            SystemGetInfo* getInfo,
            ulong* systemId
        );

        [NativeName("xrGetSystem")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetSystem")]
        static abstract Result GetSystem(
            InstanceHandle instance,
            Ref<SystemGetInfo> getInfo,
            Ref<ulong> systemId
        );

        [NativeName("xrGetSystemProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetSystemProperties")]
        static abstract Result GetSystemProperties(
            InstanceHandle instance,
            ulong systemId,
            SystemProperties* properties
        );

        [NativeName("xrGetSystemProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetSystemProperties")]
        static abstract Result GetSystemProperties(
            InstanceHandle instance,
            ulong systemId,
            Ref<SystemProperties> properties
        );

        [NativeName("xrGetViewConfigurationProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetViewConfigurationProperties")]
        static abstract Result GetViewConfigurationProperties(
            InstanceHandle instance,
            ulong systemId,
            ViewConfigurationType viewConfigurationType,
            ViewConfigurationProperties* configurationProperties
        );

        [NativeName("xrGetViewConfigurationProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetViewConfigurationProperties")]
        static abstract Result GetViewConfigurationProperties(
            InstanceHandle instance,
            ulong systemId,
            ViewConfigurationType viewConfigurationType,
            Ref<ViewConfigurationProperties> configurationProperties
        );

        [NativeName("xrLocateSpace")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrLocateSpace")]
        static abstract Result LocateSpace(
            SpaceHandle space,
            SpaceHandle baseSpace,
            long time,
            SpaceLocation* location
        );

        [NativeName("xrLocateSpace")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrLocateSpace")]
        static abstract Result LocateSpace(
            SpaceHandle space,
            SpaceHandle baseSpace,
            long time,
            Ref<SpaceLocation> location
        );

        [NativeName("xrLocateSpaces")]
        [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openxr_loader", EntryPoint = "xrLocateSpaces")]
        static abstract Result LocateSpaces(
            SessionHandle session,
            SpacesLocateInfo* locateInfo,
            SpaceLocations* spaceLocations
        );

        [NativeName("xrLocateSpaces")]
        [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openxr_loader", EntryPoint = "xrLocateSpaces")]
        static abstract Result LocateSpaces(
            SessionHandle session,
            Ref<SpacesLocateInfo> locateInfo,
            Ref<SpaceLocations> spaceLocations
        );

        [NativeName("xrLocateViews")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrLocateViews")]
        static abstract Result LocateViews(
            SessionHandle session,
            ViewLocateInfo* viewLocateInfo,
            ViewState* viewState,
            uint viewCapacityInput,
            uint* viewCountOutput,
            View* views
        );

        [NativeName("xrLocateViews")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrLocateViews")]
        static abstract Result LocateViews(
            SessionHandle session,
            Ref<ViewLocateInfo> viewLocateInfo,
            Ref<ViewState> viewState,
            uint viewCapacityInput,
            Ref<uint> viewCountOutput,
            Ref<View> views
        );

        [NativeName("xrPathToString")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrPathToString")]
        static abstract Result PathToString(
            InstanceHandle instance,
            ulong path,
            uint bufferCapacityInput,
            uint* bufferCountOutput,
            sbyte* buffer
        );

        [NativeName("xrPathToString")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrPathToString")]
        static abstract Result PathToString(
            InstanceHandle instance,
            ulong path,
            uint bufferCapacityInput,
            Ref<uint> bufferCountOutput,
            Ref<sbyte> buffer
        );

        [NativeName("xrPollEvent")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrPollEvent")]
        static abstract Result PollEvent(InstanceHandle instance, EventDataBuffer* eventData);

        [NativeName("xrPollEvent")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrPollEvent")]
        static abstract Result PollEvent(InstanceHandle instance, Ref<EventDataBuffer> eventData);

        [NativeName("xrReleaseSwapchainImage")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrReleaseSwapchainImage")]
        static abstract Result ReleaseSwapchainImage(
            SwapchainHandle swapchain,
            SwapchainImageReleaseInfo* releaseInfo
        );

        [NativeName("xrReleaseSwapchainImage")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrReleaseSwapchainImage")]
        static abstract Result ReleaseSwapchainImage(
            SwapchainHandle swapchain,
            Ref<SwapchainImageReleaseInfo> releaseInfo
        );

        [NativeName("xrRequestExitSession")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrRequestExitSession")]
        static abstract Result RequestExitSession(SessionHandle session);

        [NativeName("xrResultToString")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrResultToString")]
        static abstract Result ResultToString(InstanceHandle instance, Result value, sbyte* buffer);

        [NativeName("xrResultToString")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrResultToString")]
        static abstract Result ResultToString(
            InstanceHandle instance,
            Result value,
            Ref<sbyte> buffer
        );

        [NativeName("xrStopHapticFeedback")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrStopHapticFeedback")]
        static abstract Result StopHapticFeedback(
            SessionHandle session,
            HapticActionInfo* hapticActionInfo
        );

        [NativeName("xrStopHapticFeedback")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrStopHapticFeedback")]
        static abstract Result StopHapticFeedback(
            SessionHandle session,
            Ref<HapticActionInfo> hapticActionInfo
        );

        [NativeName("xrStringToPath")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrStringToPath")]
        static abstract Result StringToPath(
            InstanceHandle instance,
            sbyte* pathString,
            ulong* path
        );

        [NativeName("xrStringToPath")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrStringToPath")]
        static abstract Result StringToPath(
            InstanceHandle instance,
            Ref<sbyte> pathString,
            Ref<ulong> path
        );

        [NativeName("xrStructureTypeToString")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrStructureTypeToString")]
        static abstract Result StructureTypeToString(
            InstanceHandle instance,
            StructureType value,
            sbyte* buffer
        );

        [NativeName("xrStructureTypeToString")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrStructureTypeToString")]
        static abstract Result StructureTypeToString(
            InstanceHandle instance,
            StructureType value,
            Ref<sbyte> buffer
        );

        [NativeName("xrSuggestInteractionProfileBindings")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrSuggestInteractionProfileBindings")]
        static abstract Result SuggestInteractionProfileBindings(
            InstanceHandle instance,
            InteractionProfileSuggestedBinding* suggestedBindings
        );

        [NativeName("xrSuggestInteractionProfileBindings")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrSuggestInteractionProfileBindings")]
        static abstract Result SuggestInteractionProfileBindings(
            InstanceHandle instance,
            Ref<InteractionProfileSuggestedBinding> suggestedBindings
        );

        [NativeName("xrSyncActions")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrSyncActions")]
        static abstract Result SyncActions(SessionHandle session, ActionsSyncInfo* syncInfo);

        [NativeName("xrSyncActions")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrSyncActions")]
        static abstract Result SyncActions(SessionHandle session, Ref<ActionsSyncInfo> syncInfo);

        [NativeName("xrWaitFrame")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrWaitFrame")]
        static abstract Result WaitFrame(
            SessionHandle session,
            FrameWaitInfo* frameWaitInfo,
            FrameState* frameState
        );

        [NativeName("xrWaitFrame")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrWaitFrame")]
        static abstract Result WaitFrame(
            SessionHandle session,
            Ref<FrameWaitInfo> frameWaitInfo,
            Ref<FrameState> frameState
        );

        [NativeName("xrWaitSwapchainImage")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrWaitSwapchainImage")]
        static abstract Result WaitSwapchainImage(
            SwapchainHandle swapchain,
            SwapchainImageWaitInfo* waitInfo
        );

        [NativeName("xrWaitSwapchainImage")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrWaitSwapchainImage")]
        static abstract Result WaitSwapchainImage(
            SwapchainHandle swapchain,
            Ref<SwapchainImageWaitInfo> waitInfo
        );
    }

    [NativeName("xrAcquireSwapchainImage")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrAcquireSwapchainImage")]
    Result AcquireSwapchainImage(
        SwapchainHandle swapchain,
        SwapchainImageAcquireInfo* acquireInfo,
        uint* index
    );

    [NativeName("xrAcquireSwapchainImage")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrAcquireSwapchainImage")]
    Result AcquireSwapchainImage(
        SwapchainHandle swapchain,
        Ref<SwapchainImageAcquireInfo> acquireInfo,
        Ref<uint> index
    );

    [NativeName("xrApplyHapticFeedback")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_haptic_parametric", "XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrApplyHapticFeedback")]
    Result ApplyHapticFeedback(
        SessionHandle session,
        HapticActionInfo* hapticActionInfo,
        HapticBaseHeader* hapticFeedback
    );

    [NativeName("xrApplyHapticFeedback")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_haptic_parametric", "XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrApplyHapticFeedback")]
    Result ApplyHapticFeedback(
        SessionHandle session,
        Ref<HapticActionInfo> hapticActionInfo,
        Ref<HapticBaseHeader> hapticFeedback
    );

    [NativeName("xrAttachSessionActionSets")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrAttachSessionActionSets")]
    Result AttachSessionActionSets(SessionHandle session, SessionActionSetsAttachInfo* attachInfo);

    [NativeName("xrAttachSessionActionSets")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrAttachSessionActionSets")]
    Result AttachSessionActionSets(
        SessionHandle session,
        Ref<SessionActionSetsAttachInfo> attachInfo
    );

    [NativeName("xrBeginFrame")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrBeginFrame")]
    Result BeginFrame(SessionHandle session, FrameBeginInfo* frameBeginInfo);

    [NativeName("xrBeginFrame")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrBeginFrame")]
    Result BeginFrame(SessionHandle session, Ref<FrameBeginInfo> frameBeginInfo);

    [NativeName("xrBeginSession")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrBeginSession")]
    Result BeginSession(SessionHandle session, SessionBeginInfo* beginInfo);

    [NativeName("xrBeginSession")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrBeginSession")]
    Result BeginSession(SessionHandle session, Ref<SessionBeginInfo> beginInfo);

    [NativeName("xrCreateAction")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateAction")]
    Result CreateAction(
        ActionSetHandle actionSet,
        ActionCreateInfo* createInfo,
        ActionHandle* action
    );

    [NativeName("xrCreateAction")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateAction")]
    Result CreateAction(
        ActionSetHandle actionSet,
        Ref<ActionCreateInfo> createInfo,
        Ref<ActionHandle> action
    );

    [NativeName("xrCreateActionSet")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateActionSet")]
    Result CreateActionSet(
        InstanceHandle instance,
        ActionSetCreateInfo* createInfo,
        ActionSetHandle* actionSet
    );

    [NativeName("xrCreateActionSet")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateActionSet")]
    Result CreateActionSet(
        InstanceHandle instance,
        Ref<ActionSetCreateInfo> createInfo,
        Ref<ActionSetHandle> actionSet
    );

    [NativeName("xrCreateActionSpace")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateActionSpace")]
    Result CreateActionSpace(
        SessionHandle session,
        ActionSpaceCreateInfo* createInfo,
        SpaceHandle* space
    );

    [NativeName("xrCreateActionSpace")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateActionSpace")]
    Result CreateActionSpace(
        SessionHandle session,
        Ref<ActionSpaceCreateInfo> createInfo,
        Ref<SpaceHandle> space
    );

    [NativeName("xrCreateInstance")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateInstance")]
    Result CreateInstance(InstanceCreateInfo* createInfo, InstanceHandle* instance);

    [NativeName("xrCreateInstance")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateInstance")]
    Result CreateInstance(Ref<InstanceCreateInfo> createInfo, Ref<InstanceHandle> instance);

    [NativeName("xrCreateReferenceSpace")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateReferenceSpace")]
    Result CreateReferenceSpace(
        SessionHandle session,
        ReferenceSpaceCreateInfo* createInfo,
        SpaceHandle* space
    );

    [NativeName("xrCreateReferenceSpace")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateReferenceSpace")]
    Result CreateReferenceSpace(
        SessionHandle session,
        Ref<ReferenceSpaceCreateInfo> createInfo,
        Ref<SpaceHandle> space
    );

    [NativeName("xrCreateSession")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateSession")]
    Result CreateSession(
        InstanceHandle instance,
        SessionCreateInfo* createInfo,
        SessionHandle* session
    );

    [NativeName("xrCreateSession")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateSession")]
    Result CreateSession(
        InstanceHandle instance,
        Ref<SessionCreateInfo> createInfo,
        Ref<SessionHandle> session
    );

    [NativeName("xrCreateSwapchain")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateSwapchain")]
    Result CreateSwapchain(
        SessionHandle session,
        SwapchainCreateInfo* createInfo,
        SwapchainHandle* swapchain
    );

    [NativeName("xrCreateSwapchain")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateSwapchain")]
    Result CreateSwapchain(
        SessionHandle session,
        Ref<SwapchainCreateInfo> createInfo,
        Ref<SwapchainHandle> swapchain
    );

    [NativeName("xrDestroyAction")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrDestroyAction")]
    Result DestroyAction(ActionHandle action);

    [NativeName("xrDestroyActionSet")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrDestroyActionSet")]
    Result DestroyActionSet(ActionSetHandle actionSet);

    [NativeName("xrDestroyInstance")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrDestroyInstance")]
    Result DestroyInstance(InstanceHandle instance);

    [NativeName("xrDestroySession")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrDestroySession")]
    Result DestroySession(SessionHandle session);

    [NativeName("xrDestroySpace")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrDestroySpace")]
    Result DestroySpace(SpaceHandle space);

    [NativeName("xrDestroySwapchain")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrDestroySwapchain")]
    Result DestroySwapchain(SwapchainHandle swapchain);

    [NativeName("xrEndFrame")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEndFrame")]
    Result EndFrame(SessionHandle session, FrameEndInfo* frameEndInfo);

    [NativeName("xrEndFrame")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEndFrame")]
    Result EndFrame(SessionHandle session, Ref<FrameEndInfo> frameEndInfo);

    [NativeName("xrEndSession")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEndSession")]
    Result EndSession(SessionHandle session);

    [NativeName("xrEnumerateApiLayerProperties")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateApiLayerProperties")]
    Result EnumerateApiLayerProperties(
        uint propertyCapacityInput,
        uint* propertyCountOutput,
        ApiLayerProperties* properties
    );

    [NativeName("xrEnumerateApiLayerProperties")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateApiLayerProperties")]
    Result EnumerateApiLayerProperties(
        uint propertyCapacityInput,
        Ref<uint> propertyCountOutput,
        Ref<ApiLayerProperties> properties
    );

    [NativeName("xrEnumerateBoundSourcesForAction")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateBoundSourcesForAction")]
    Result EnumerateBoundSourcesForAction(
        SessionHandle session,
        BoundSourcesForActionEnumerateInfo* enumerateInfo,
        uint sourceCapacityInput,
        uint* sourceCountOutput,
        ulong* sources
    );

    [NativeName("xrEnumerateBoundSourcesForAction")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateBoundSourcesForAction")]
    Result EnumerateBoundSourcesForAction(
        SessionHandle session,
        Ref<BoundSourcesForActionEnumerateInfo> enumerateInfo,
        uint sourceCapacityInput,
        Ref<uint> sourceCountOutput,
        Ref<ulong> sources
    );

    [NativeName("xrEnumerateEnvironmentBlendModes")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateEnvironmentBlendModes")]
    Result EnumerateEnvironmentBlendModes(
        InstanceHandle instance,
        ulong systemId,
        ViewConfigurationType viewConfigurationType,
        uint environmentBlendModeCapacityInput,
        uint* environmentBlendModeCountOutput,
        EnvironmentBlendMode* environmentBlendModes
    );

    [NativeName("xrEnumerateEnvironmentBlendModes")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateEnvironmentBlendModes")]
    Result EnumerateEnvironmentBlendModes(
        InstanceHandle instance,
        ulong systemId,
        ViewConfigurationType viewConfigurationType,
        uint environmentBlendModeCapacityInput,
        Ref<uint> environmentBlendModeCountOutput,
        Ref<EnvironmentBlendMode> environmentBlendModes
    );

    [NativeName("xrEnumerateInstanceExtensionProperties")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateInstanceExtensionProperties")]
    Result EnumerateInstanceExtensionProperties(
        sbyte* layerName,
        uint propertyCapacityInput,
        uint* propertyCountOutput,
        ExtensionProperties* properties
    );

    [NativeName("xrEnumerateInstanceExtensionProperties")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateInstanceExtensionProperties")]
    Result EnumerateInstanceExtensionProperties(
        Ref<sbyte> layerName,
        uint propertyCapacityInput,
        Ref<uint> propertyCountOutput,
        Ref<ExtensionProperties> properties
    );

    [NativeName("xrEnumerateReferenceSpaces")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateReferenceSpaces")]
    Result EnumerateReferenceSpaces(
        SessionHandle session,
        uint spaceCapacityInput,
        uint* spaceCountOutput,
        ReferenceSpaceType* spaces
    );

    [NativeName("xrEnumerateReferenceSpaces")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateReferenceSpaces")]
    Result EnumerateReferenceSpaces(
        SessionHandle session,
        uint spaceCapacityInput,
        Ref<uint> spaceCountOutput,
        Ref<ReferenceSpaceType> spaces
    );

    [NativeName("xrEnumerateSwapchainFormats")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateSwapchainFormats")]
    Result EnumerateSwapchainFormats(
        SessionHandle session,
        uint formatCapacityInput,
        uint* formatCountOutput,
        long* formats
    );

    [NativeName("xrEnumerateSwapchainFormats")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateSwapchainFormats")]
    Result EnumerateSwapchainFormats(
        SessionHandle session,
        uint formatCapacityInput,
        Ref<uint> formatCountOutput,
        Ref<long> formats
    );

    [NativeName("xrEnumerateSwapchainImages")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateSwapchainImages")]
    Result EnumerateSwapchainImages(
        SwapchainHandle swapchain,
        uint imageCapacityInput,
        uint* imageCountOutput,
        SwapchainImageBaseHeader* images
    );

    [NativeName("xrEnumerateSwapchainImages")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateSwapchainImages")]
    Result EnumerateSwapchainImages(
        SwapchainHandle swapchain,
        uint imageCapacityInput,
        Ref<uint> imageCountOutput,
        Ref<SwapchainImageBaseHeader> images
    );

    [NativeName("xrEnumerateViewConfigurations")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateViewConfigurations")]
    Result EnumerateViewConfigurations(
        InstanceHandle instance,
        ulong systemId,
        uint viewConfigurationTypeCapacityInput,
        uint* viewConfigurationTypeCountOutput,
        ViewConfigurationType* viewConfigurationTypes
    );

    [NativeName("xrEnumerateViewConfigurations")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateViewConfigurations")]
    Result EnumerateViewConfigurations(
        InstanceHandle instance,
        ulong systemId,
        uint viewConfigurationTypeCapacityInput,
        Ref<uint> viewConfigurationTypeCountOutput,
        Ref<ViewConfigurationType> viewConfigurationTypes
    );

    [NativeName("xrEnumerateViewConfigurationViews")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateViewConfigurationViews")]
    Result EnumerateViewConfigurationViews(
        InstanceHandle instance,
        ulong systemId,
        ViewConfigurationType viewConfigurationType,
        uint viewCapacityInput,
        uint* viewCountOutput,
        ViewConfigurationView* views
    );

    [NativeName("xrEnumerateViewConfigurationViews")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateViewConfigurationViews")]
    Result EnumerateViewConfigurationViews(
        InstanceHandle instance,
        ulong systemId,
        ViewConfigurationType viewConfigurationType,
        uint viewCapacityInput,
        Ref<uint> viewCountOutput,
        Ref<ViewConfigurationView> views
    );

    [NativeName("xrGetActionStateBoolean")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateBoolean")]
    Result GetActionStateBoolean(
        SessionHandle session,
        ActionStateGetInfo* getInfo,
        ActionStateBoolean* state
    );

    [NativeName("xrGetActionStateBoolean")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateBoolean")]
    Result GetActionStateBoolean(
        SessionHandle session,
        Ref<ActionStateGetInfo> getInfo,
        Ref<ActionStateBoolean> state
    );

    [NativeName("xrGetActionStateFloat")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateFloat")]
    Result GetActionStateFloat(
        SessionHandle session,
        ActionStateGetInfo* getInfo,
        ActionStateFloat* state
    );

    [NativeName("xrGetActionStateFloat")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateFloat")]
    Result GetActionStateFloat(
        SessionHandle session,
        Ref<ActionStateGetInfo> getInfo,
        Ref<ActionStateFloat> state
    );

    [NativeName("xrGetActionStatePose")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStatePose")]
    Result GetActionStatePose(
        SessionHandle session,
        ActionStateGetInfo* getInfo,
        ActionStatePose* state
    );

    [NativeName("xrGetActionStatePose")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStatePose")]
    Result GetActionStatePose(
        SessionHandle session,
        Ref<ActionStateGetInfo> getInfo,
        Ref<ActionStatePose> state
    );

    [NativeName("xrGetActionStateVector2f")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateVector2f")]
    Result GetActionStateVector2F(
        SessionHandle session,
        ActionStateGetInfo* getInfo,
        ActionStateVector2F* state
    );

    [NativeName("xrGetActionStateVector2f")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateVector2f")]
    Result GetActionStateVector2F(
        SessionHandle session,
        Ref<ActionStateGetInfo> getInfo,
        Ref<ActionStateVector2F> state
    );

    [NativeName("xrGetCurrentInteractionProfile")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetCurrentInteractionProfile")]
    Result GetCurrentInteractionProfile(
        SessionHandle session,
        ulong topLevelUserPath,
        InteractionProfileState* interactionProfile
    );

    [NativeName("xrGetCurrentInteractionProfile")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetCurrentInteractionProfile")]
    Result GetCurrentInteractionProfile(
        SessionHandle session,
        ulong topLevelUserPath,
        Ref<InteractionProfileState> interactionProfile
    );

    [NativeName("xrGetInputSourceLocalizedName")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetInputSourceLocalizedName")]
    Result GetInputSourceLocalizedName(
        SessionHandle session,
        InputSourceLocalizedNameGetInfo* getInfo,
        uint bufferCapacityInput,
        uint* bufferCountOutput,
        sbyte* buffer
    );

    [NativeName("xrGetInputSourceLocalizedName")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetInputSourceLocalizedName")]
    Result GetInputSourceLocalizedName(
        SessionHandle session,
        Ref<InputSourceLocalizedNameGetInfo> getInfo,
        uint bufferCapacityInput,
        Ref<uint> bufferCountOutput,
        Ref<sbyte> buffer
    );

    [NativeName("xrGetInstanceProcAddr")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetInstanceProcAddr")]
    Result GetInstanceProcAddr(InstanceHandle instance, sbyte* name, VoidFunction* function);

    [NativeName("xrGetInstanceProcAddr")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetInstanceProcAddr")]
    Result GetInstanceProcAddr(
        InstanceHandle instance,
        Ref<sbyte> name,
        Ref<VoidFunction> function
    );

    [NativeName("xrGetInstanceProperties")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetInstanceProperties")]
    Result GetInstanceProperties(InstanceHandle instance, InstanceProperties* instanceProperties);

    [NativeName("xrGetInstanceProperties")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetInstanceProperties")]
    Result GetInstanceProperties(
        InstanceHandle instance,
        Ref<InstanceProperties> instanceProperties
    );

    [NativeName("xrGetReferenceSpaceBoundsRect")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetReferenceSpaceBoundsRect")]
    Result GetReferenceSpaceBoundsRect(
        SessionHandle session,
        ReferenceSpaceType referenceSpaceType,
        Extent2Df* bounds
    );

    [NativeName("xrGetReferenceSpaceBoundsRect")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetReferenceSpaceBoundsRect")]
    Result GetReferenceSpaceBoundsRect(
        SessionHandle session,
        ReferenceSpaceType referenceSpaceType,
        Ref<Extent2Df> bounds
    );

    [NativeName("xrGetSystem")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetSystem")]
    Result GetSystem(InstanceHandle instance, SystemGetInfo* getInfo, ulong* systemId);

    [NativeName("xrGetSystem")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetSystem")]
    Result GetSystem(InstanceHandle instance, Ref<SystemGetInfo> getInfo, Ref<ulong> systemId);

    [NativeName("xrGetSystemProperties")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetSystemProperties")]
    Result GetSystemProperties(
        InstanceHandle instance,
        ulong systemId,
        SystemProperties* properties
    );

    [NativeName("xrGetSystemProperties")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetSystemProperties")]
    Result GetSystemProperties(
        InstanceHandle instance,
        ulong systemId,
        Ref<SystemProperties> properties
    );

    [NativeName("xrGetViewConfigurationProperties")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetViewConfigurationProperties")]
    Result GetViewConfigurationProperties(
        InstanceHandle instance,
        ulong systemId,
        ViewConfigurationType viewConfigurationType,
        ViewConfigurationProperties* configurationProperties
    );

    [NativeName("xrGetViewConfigurationProperties")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetViewConfigurationProperties")]
    Result GetViewConfigurationProperties(
        InstanceHandle instance,
        ulong systemId,
        ViewConfigurationType viewConfigurationType,
        Ref<ViewConfigurationProperties> configurationProperties
    );

    [NativeName("xrLocateSpace")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrLocateSpace")]
    Result LocateSpace(
        SpaceHandle space,
        SpaceHandle baseSpace,
        long time,
        SpaceLocation* location
    );

    [NativeName("xrLocateSpace")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrLocateSpace")]
    Result LocateSpace(
        SpaceHandle space,
        SpaceHandle baseSpace,
        long time,
        Ref<SpaceLocation> location
    );

    [NativeName("xrLocateSpaces")]
    [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openxr_loader", EntryPoint = "xrLocateSpaces")]
    Result LocateSpaces(
        SessionHandle session,
        SpacesLocateInfo* locateInfo,
        SpaceLocations* spaceLocations
    );

    [NativeName("xrLocateSpaces")]
    [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openxr_loader", EntryPoint = "xrLocateSpaces")]
    Result LocateSpaces(
        SessionHandle session,
        Ref<SpacesLocateInfo> locateInfo,
        Ref<SpaceLocations> spaceLocations
    );

    [NativeName("xrLocateViews")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrLocateViews")]
    Result LocateViews(
        SessionHandle session,
        ViewLocateInfo* viewLocateInfo,
        ViewState* viewState,
        uint viewCapacityInput,
        uint* viewCountOutput,
        View* views
    );

    [NativeName("xrLocateViews")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrLocateViews")]
    Result LocateViews(
        SessionHandle session,
        Ref<ViewLocateInfo> viewLocateInfo,
        Ref<ViewState> viewState,
        uint viewCapacityInput,
        Ref<uint> viewCountOutput,
        Ref<View> views
    );

    [NativeName("xrPathToString")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrPathToString")]
    Result PathToString(
        InstanceHandle instance,
        ulong path,
        uint bufferCapacityInput,
        uint* bufferCountOutput,
        sbyte* buffer
    );

    [NativeName("xrPathToString")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrPathToString")]
    Result PathToString(
        InstanceHandle instance,
        ulong path,
        uint bufferCapacityInput,
        Ref<uint> bufferCountOutput,
        Ref<sbyte> buffer
    );

    [NativeName("xrPollEvent")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrPollEvent")]
    Result PollEvent(InstanceHandle instance, EventDataBuffer* eventData);

    [NativeName("xrPollEvent")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrPollEvent")]
    Result PollEvent(InstanceHandle instance, Ref<EventDataBuffer> eventData);

    [NativeName("xrReleaseSwapchainImage")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrReleaseSwapchainImage")]
    Result ReleaseSwapchainImage(SwapchainHandle swapchain, SwapchainImageReleaseInfo* releaseInfo);

    [NativeName("xrReleaseSwapchainImage")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrReleaseSwapchainImage")]
    Result ReleaseSwapchainImage(
        SwapchainHandle swapchain,
        Ref<SwapchainImageReleaseInfo> releaseInfo
    );

    [NativeName("xrRequestExitSession")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrRequestExitSession")]
    Result RequestExitSession(SessionHandle session);

    [NativeName("xrResultToString")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrResultToString")]
    Result ResultToString(InstanceHandle instance, Result value, sbyte* buffer);

    [NativeName("xrResultToString")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrResultToString")]
    Result ResultToString(InstanceHandle instance, Result value, Ref<sbyte> buffer);

    [NativeName("xrStopHapticFeedback")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrStopHapticFeedback")]
    Result StopHapticFeedback(SessionHandle session, HapticActionInfo* hapticActionInfo);

    [NativeName("xrStopHapticFeedback")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrStopHapticFeedback")]
    Result StopHapticFeedback(SessionHandle session, Ref<HapticActionInfo> hapticActionInfo);

    [NativeName("xrStringToPath")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrStringToPath")]
    Result StringToPath(InstanceHandle instance, sbyte* pathString, ulong* path);

    [NativeName("xrStringToPath")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrStringToPath")]
    Result StringToPath(InstanceHandle instance, Ref<sbyte> pathString, Ref<ulong> path);

    [NativeName("xrStructureTypeToString")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrStructureTypeToString")]
    Result StructureTypeToString(InstanceHandle instance, StructureType value, sbyte* buffer);

    [NativeName("xrStructureTypeToString")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrStructureTypeToString")]
    Result StructureTypeToString(InstanceHandle instance, StructureType value, Ref<sbyte> buffer);

    [NativeName("xrSuggestInteractionProfileBindings")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrSuggestInteractionProfileBindings")]
    Result SuggestInteractionProfileBindings(
        InstanceHandle instance,
        InteractionProfileSuggestedBinding* suggestedBindings
    );

    [NativeName("xrSuggestInteractionProfileBindings")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrSuggestInteractionProfileBindings")]
    Result SuggestInteractionProfileBindings(
        InstanceHandle instance,
        Ref<InteractionProfileSuggestedBinding> suggestedBindings
    );

    [NativeName("xrSyncActions")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrSyncActions")]
    Result SyncActions(SessionHandle session, ActionsSyncInfo* syncInfo);

    [NativeName("xrSyncActions")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrSyncActions")]
    Result SyncActions(SessionHandle session, Ref<ActionsSyncInfo> syncInfo);

    [NativeName("xrWaitFrame")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrWaitFrame")]
    Result WaitFrame(SessionHandle session, FrameWaitInfo* frameWaitInfo, FrameState* frameState);

    [NativeName("xrWaitFrame")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrWaitFrame")]
    Result WaitFrame(
        SessionHandle session,
        Ref<FrameWaitInfo> frameWaitInfo,
        Ref<FrameState> frameState
    );

    [NativeName("xrWaitSwapchainImage")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrWaitSwapchainImage")]
    Result WaitSwapchainImage(SwapchainHandle swapchain, SwapchainImageWaitInfo* waitInfo);

    [NativeName("xrWaitSwapchainImage")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrWaitSwapchainImage")]
    Result WaitSwapchainImage(SwapchainHandle swapchain, Ref<SwapchainImageWaitInfo> waitInfo);
}
