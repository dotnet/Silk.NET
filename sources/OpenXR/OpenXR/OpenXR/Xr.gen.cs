// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[SupportedApiProfile("openxr")]
public unsafe partial class Xr : IXr, IXr.Static
{
    public partial class DllImport : IXr.Static
    {
        [NativeName("xrAcquireSwapchainImage")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrAcquireSwapchainImage")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result AcquireSwapchainImage(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result AcquireSwapchainImage(
            SwapchainHandle swapchain,
            Ref<SwapchainImageAcquireInfo> acquireInfo,
            Ref<uint> index
        )
        {
            fixed (uint* __dsl_index = index)
            fixed (SwapchainImageAcquireInfo* __dsl_acquireInfo = acquireInfo)
            {
                return (Result)AcquireSwapchainImage(swapchain, __dsl_acquireInfo, __dsl_index);
            }
        }

        [NativeName("xrApplyHapticFeedback")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrApplyHapticFeedback")]
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
        public static extern Result ApplyHapticFeedback(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result ApplyHapticFeedback(
            SessionHandle session,
            Ref<HapticActionInfo> hapticActionInfo,
            Ref<HapticBaseHeader> hapticFeedback
        )
        {
            fixed (HapticBaseHeader* __dsl_hapticFeedback = hapticFeedback)
            fixed (HapticActionInfo* __dsl_hapticActionInfo = hapticActionInfo)
            {
                return (Result)ApplyHapticFeedback(
                    session,
                    __dsl_hapticActionInfo,
                    __dsl_hapticFeedback
                );
            }
        }

        [NativeName("xrAttachSessionActionSets")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrAttachSessionActionSets")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result AttachSessionActionSets(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result AttachSessionActionSets(
            SessionHandle session,
            Ref<SessionActionSetsAttachInfo> attachInfo
        )
        {
            fixed (SessionActionSetsAttachInfo* __dsl_attachInfo = attachInfo)
            {
                return (Result)AttachSessionActionSets(session, __dsl_attachInfo);
            }
        }

        [NativeName("xrBeginFrame")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrBeginFrame")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result BeginFrame(
            SessionHandle session,
            FrameBeginInfo* frameBeginInfo
        );

        [NativeName("xrBeginFrame")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrBeginFrame")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result BeginFrame(SessionHandle session, Ref<FrameBeginInfo> frameBeginInfo)
        {
            fixed (FrameBeginInfo* __dsl_frameBeginInfo = frameBeginInfo)
            {
                return (Result)BeginFrame(session, __dsl_frameBeginInfo);
            }
        }

        [NativeName("xrBeginSession")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrBeginSession")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result BeginSession(
            SessionHandle session,
            SessionBeginInfo* beginInfo
        );

        [NativeName("xrBeginSession")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrBeginSession")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result BeginSession(SessionHandle session, Ref<SessionBeginInfo> beginInfo)
        {
            fixed (SessionBeginInfo* __dsl_beginInfo = beginInfo)
            {
                return (Result)BeginSession(session, __dsl_beginInfo);
            }
        }

        [NativeName("xrCreateAction")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrCreateAction")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result CreateAction(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result CreateAction(
            ActionSetHandle actionSet,
            Ref<ActionCreateInfo> createInfo,
            Ref<ActionHandle> action
        )
        {
            fixed (ActionHandle* __dsl_action = action)
            fixed (ActionCreateInfo* __dsl_createInfo = createInfo)
            {
                return (Result)CreateAction(actionSet, __dsl_createInfo, __dsl_action);
            }
        }

        [NativeName("xrCreateActionSet")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrCreateActionSet")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result CreateActionSet(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result CreateActionSet(
            InstanceHandle instance,
            Ref<ActionSetCreateInfo> createInfo,
            Ref<ActionSetHandle> actionSet
        )
        {
            fixed (ActionSetHandle* __dsl_actionSet = actionSet)
            fixed (ActionSetCreateInfo* __dsl_createInfo = createInfo)
            {
                return (Result)CreateActionSet(instance, __dsl_createInfo, __dsl_actionSet);
            }
        }

        [NativeName("xrCreateActionSpace")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrCreateActionSpace")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result CreateActionSpace(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result CreateActionSpace(
            SessionHandle session,
            Ref<ActionSpaceCreateInfo> createInfo,
            Ref<SpaceHandle> space
        )
        {
            fixed (SpaceHandle* __dsl_space = space)
            fixed (ActionSpaceCreateInfo* __dsl_createInfo = createInfo)
            {
                return (Result)CreateActionSpace(session, __dsl_createInfo, __dsl_space);
            }
        }

        [NativeName("xrCreateInstance")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateInstance")]
        public static partial Result CreateInstance(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result CreateInstance(
            Ref<InstanceCreateInfo> createInfo,
            Ref<InstanceHandle> instance
        )
        {
            fixed (InstanceHandle* __dsl_instance = instance)
            fixed (InstanceCreateInfo* __dsl_createInfo = createInfo)
            {
                return (Result)CreateInstance(__dsl_createInfo, __dsl_instance);
            }
        }

        [NativeName("xrCreateInstance")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrCreateInstance")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        private static extern Result CreateInstanceInternal(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        private static Result CreateInstanceInternal(
            Ref<InstanceCreateInfo> createInfo,
            Ref<InstanceHandle> instance
        )
        {
            fixed (InstanceHandle* __dsl_instance = instance)
            fixed (InstanceCreateInfo* __dsl_createInfo = createInfo)
            {
                return (Result)CreateInstanceInternal(__dsl_createInfo, __dsl_instance);
            }
        }

        [NativeName("xrCreateReferenceSpace")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrCreateReferenceSpace")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result CreateReferenceSpace(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result CreateReferenceSpace(
            SessionHandle session,
            Ref<ReferenceSpaceCreateInfo> createInfo,
            Ref<SpaceHandle> space
        )
        {
            fixed (SpaceHandle* __dsl_space = space)
            fixed (ReferenceSpaceCreateInfo* __dsl_createInfo = createInfo)
            {
                return (Result)CreateReferenceSpace(session, __dsl_createInfo, __dsl_space);
            }
        }

        [NativeName("xrCreateSession")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrCreateSession")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result CreateSession(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result CreateSession(
            InstanceHandle instance,
            Ref<SessionCreateInfo> createInfo,
            Ref<SessionHandle> session
        )
        {
            fixed (SessionHandle* __dsl_session = session)
            fixed (SessionCreateInfo* __dsl_createInfo = createInfo)
            {
                return (Result)CreateSession(instance, __dsl_createInfo, __dsl_session);
            }
        }

        [NativeName("xrCreateSwapchain")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrCreateSwapchain")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result CreateSwapchain(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result CreateSwapchain(
            SessionHandle session,
            Ref<SwapchainCreateInfo> createInfo,
            Ref<SwapchainHandle> swapchain
        )
        {
            fixed (SwapchainHandle* __dsl_swapchain = swapchain)
            fixed (SwapchainCreateInfo* __dsl_createInfo = createInfo)
            {
                return (Result)CreateSwapchain(session, __dsl_createInfo, __dsl_swapchain);
            }
        }

        [NativeName("xrDestroyAction")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrDestroyAction")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result DestroyAction(ActionHandle action);

        [NativeName("xrDestroyActionSet")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrDestroyActionSet")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result DestroyActionSet(ActionSetHandle actionSet);

        [NativeName("xrDestroyInstance")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrDestroyInstance")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result DestroyInstance(InstanceHandle instance);

        [NativeName("xrDestroySession")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrDestroySession")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result DestroySession(SessionHandle session);

        [NativeName("xrDestroySpace")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrDestroySpace")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result DestroySpace(SpaceHandle space);

        [NativeName("xrDestroySwapchain")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrDestroySwapchain")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result DestroySwapchain(SwapchainHandle swapchain);

        [NativeName("xrEndFrame")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrEndFrame")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result EndFrame(SessionHandle session, FrameEndInfo* frameEndInfo);

        [NativeName("xrEndFrame")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEndFrame")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EndFrame(SessionHandle session, Ref<FrameEndInfo> frameEndInfo)
        {
            fixed (FrameEndInfo* __dsl_frameEndInfo = frameEndInfo)
            {
                return (Result)EndFrame(session, __dsl_frameEndInfo);
            }
        }

        [NativeName("xrEndSession")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrEndSession")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result EndSession(SessionHandle session);

        [NativeName("xrEnumerateApiLayerProperties")]
        [DllImport(
            "openxr_loader",
            ExactSpelling = true,
            EntryPoint = "xrEnumerateApiLayerProperties"
        )]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result EnumerateApiLayerProperties(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EnumerateApiLayerProperties(
            uint propertyCapacityInput,
            Ref<uint> propertyCountOutput,
            Ref<ApiLayerProperties> properties
        )
        {
            fixed (ApiLayerProperties* __dsl_properties = properties)
            fixed (uint* __dsl_propertyCountOutput = propertyCountOutput)
            {
                return (Result)EnumerateApiLayerProperties(
                    propertyCapacityInput,
                    __dsl_propertyCountOutput,
                    __dsl_properties
                );
            }
        }

        [NativeName("xrEnumerateBoundSourcesForAction")]
        [DllImport(
            "openxr_loader",
            ExactSpelling = true,
            EntryPoint = "xrEnumerateBoundSourcesForAction"
        )]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result EnumerateBoundSourcesForAction(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EnumerateBoundSourcesForAction(
            SessionHandle session,
            Ref<BoundSourcesForActionEnumerateInfo> enumerateInfo,
            uint sourceCapacityInput,
            Ref<uint> sourceCountOutput,
            Ref<ulong> sources
        )
        {
            fixed (ulong* __dsl_sources = sources)
            fixed (uint* __dsl_sourceCountOutput = sourceCountOutput)
            fixed (BoundSourcesForActionEnumerateInfo* __dsl_enumerateInfo = enumerateInfo)
            {
                return (Result)EnumerateBoundSourcesForAction(
                    session,
                    __dsl_enumerateInfo,
                    sourceCapacityInput,
                    __dsl_sourceCountOutput,
                    __dsl_sources
                );
            }
        }

        [NativeName("xrEnumerateEnvironmentBlendModes")]
        [DllImport(
            "openxr_loader",
            ExactSpelling = true,
            EntryPoint = "xrEnumerateEnvironmentBlendModes"
        )]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result EnumerateEnvironmentBlendModes(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EnumerateEnvironmentBlendModes(
            InstanceHandle instance,
            ulong systemId,
            ViewConfigurationType viewConfigurationType,
            uint environmentBlendModeCapacityInput,
            Ref<uint> environmentBlendModeCountOutput,
            Ref<EnvironmentBlendMode> environmentBlendModes
        )
        {
            fixed (EnvironmentBlendMode* __dsl_environmentBlendModes = environmentBlendModes)
            fixed (uint* __dsl_environmentBlendModeCountOutput = environmentBlendModeCountOutput)
            {
                return (Result)EnumerateEnvironmentBlendModes(
                    instance,
                    systemId,
                    viewConfigurationType,
                    environmentBlendModeCapacityInput,
                    __dsl_environmentBlendModeCountOutput,
                    __dsl_environmentBlendModes
                );
            }
        }

        [NativeName("xrEnumerateInstanceExtensionProperties")]
        [DllImport(
            "openxr_loader",
            ExactSpelling = true,
            EntryPoint = "xrEnumerateInstanceExtensionProperties"
        )]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result EnumerateInstanceExtensionProperties(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EnumerateInstanceExtensionProperties(
            Ref<sbyte> layerName,
            uint propertyCapacityInput,
            Ref<uint> propertyCountOutput,
            Ref<ExtensionProperties> properties
        )
        {
            fixed (ExtensionProperties* __dsl_properties = properties)
            fixed (uint* __dsl_propertyCountOutput = propertyCountOutput)
            fixed (sbyte* __dsl_layerName = layerName)
            {
                return (Result)EnumerateInstanceExtensionProperties(
                    __dsl_layerName,
                    propertyCapacityInput,
                    __dsl_propertyCountOutput,
                    __dsl_properties
                );
            }
        }

        [NativeName("xrEnumerateReferenceSpaces")]
        [DllImport(
            "openxr_loader",
            ExactSpelling = true,
            EntryPoint = "xrEnumerateReferenceSpaces"
        )]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result EnumerateReferenceSpaces(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EnumerateReferenceSpaces(
            SessionHandle session,
            uint spaceCapacityInput,
            Ref<uint> spaceCountOutput,
            Ref<ReferenceSpaceType> spaces
        )
        {
            fixed (ReferenceSpaceType* __dsl_spaces = spaces)
            fixed (uint* __dsl_spaceCountOutput = spaceCountOutput)
            {
                return (Result)EnumerateReferenceSpaces(
                    session,
                    spaceCapacityInput,
                    __dsl_spaceCountOutput,
                    __dsl_spaces
                );
            }
        }

        [NativeName("xrEnumerateSwapchainFormats")]
        [DllImport(
            "openxr_loader",
            ExactSpelling = true,
            EntryPoint = "xrEnumerateSwapchainFormats"
        )]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result EnumerateSwapchainFormats(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EnumerateSwapchainFormats(
            SessionHandle session,
            uint formatCapacityInput,
            Ref<uint> formatCountOutput,
            Ref<long> formats
        )
        {
            fixed (long* __dsl_formats = formats)
            fixed (uint* __dsl_formatCountOutput = formatCountOutput)
            {
                return (Result)EnumerateSwapchainFormats(
                    session,
                    formatCapacityInput,
                    __dsl_formatCountOutput,
                    __dsl_formats
                );
            }
        }

        [NativeName("xrEnumerateSwapchainImages")]
        [DllImport(
            "openxr_loader",
            ExactSpelling = true,
            EntryPoint = "xrEnumerateSwapchainImages"
        )]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result EnumerateSwapchainImages(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EnumerateSwapchainImages(
            SwapchainHandle swapchain,
            uint imageCapacityInput,
            Ref<uint> imageCountOutput,
            Ref<SwapchainImageBaseHeader> images
        )
        {
            fixed (SwapchainImageBaseHeader* __dsl_images = images)
            fixed (uint* __dsl_imageCountOutput = imageCountOutput)
            {
                return (Result)EnumerateSwapchainImages(
                    swapchain,
                    imageCapacityInput,
                    __dsl_imageCountOutput,
                    __dsl_images
                );
            }
        }

        [NativeName("xrEnumerateViewConfigurations")]
        [DllImport(
            "openxr_loader",
            ExactSpelling = true,
            EntryPoint = "xrEnumerateViewConfigurations"
        )]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result EnumerateViewConfigurations(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EnumerateViewConfigurations(
            InstanceHandle instance,
            ulong systemId,
            uint viewConfigurationTypeCapacityInput,
            Ref<uint> viewConfigurationTypeCountOutput,
            Ref<ViewConfigurationType> viewConfigurationTypes
        )
        {
            fixed (ViewConfigurationType* __dsl_viewConfigurationTypes = viewConfigurationTypes)
            fixed (uint* __dsl_viewConfigurationTypeCountOutput = viewConfigurationTypeCountOutput)
            {
                return (Result)EnumerateViewConfigurations(
                    instance,
                    systemId,
                    viewConfigurationTypeCapacityInput,
                    __dsl_viewConfigurationTypeCountOutput,
                    __dsl_viewConfigurationTypes
                );
            }
        }

        [NativeName("xrEnumerateViewConfigurationViews")]
        [DllImport(
            "openxr_loader",
            ExactSpelling = true,
            EntryPoint = "xrEnumerateViewConfigurationViews"
        )]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result EnumerateViewConfigurationViews(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EnumerateViewConfigurationViews(
            InstanceHandle instance,
            ulong systemId,
            ViewConfigurationType viewConfigurationType,
            uint viewCapacityInput,
            Ref<uint> viewCountOutput,
            Ref<ViewConfigurationView> views
        )
        {
            fixed (ViewConfigurationView* __dsl_views = views)
            fixed (uint* __dsl_viewCountOutput = viewCountOutput)
            {
                return (Result)EnumerateViewConfigurationViews(
                    instance,
                    systemId,
                    viewConfigurationType,
                    viewCapacityInput,
                    __dsl_viewCountOutput,
                    __dsl_views
                );
            }
        }

        [NativeName("xrGetActionStateBoolean")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrGetActionStateBoolean")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result GetActionStateBoolean(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetActionStateBoolean(
            SessionHandle session,
            Ref<ActionStateGetInfo> getInfo,
            Ref<ActionStateBoolean> state
        )
        {
            fixed (ActionStateBoolean* __dsl_state = state)
            fixed (ActionStateGetInfo* __dsl_getInfo = getInfo)
            {
                return (Result)GetActionStateBoolean(session, __dsl_getInfo, __dsl_state);
            }
        }

        [NativeName("xrGetActionStateFloat")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrGetActionStateFloat")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result GetActionStateFloat(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetActionStateFloat(
            SessionHandle session,
            Ref<ActionStateGetInfo> getInfo,
            Ref<ActionStateFloat> state
        )
        {
            fixed (ActionStateFloat* __dsl_state = state)
            fixed (ActionStateGetInfo* __dsl_getInfo = getInfo)
            {
                return (Result)GetActionStateFloat(session, __dsl_getInfo, __dsl_state);
            }
        }

        [NativeName("xrGetActionStatePose")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrGetActionStatePose")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result GetActionStatePose(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetActionStatePose(
            SessionHandle session,
            Ref<ActionStateGetInfo> getInfo,
            Ref<ActionStatePose> state
        )
        {
            fixed (ActionStatePose* __dsl_state = state)
            fixed (ActionStateGetInfo* __dsl_getInfo = getInfo)
            {
                return (Result)GetActionStatePose(session, __dsl_getInfo, __dsl_state);
            }
        }

        [NativeName("xrGetActionStateVector2f")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrGetActionStateVector2f")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result GetActionStateVector2F(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetActionStateVector2F(
            SessionHandle session,
            Ref<ActionStateGetInfo> getInfo,
            Ref<ActionStateVector2F> state
        )
        {
            fixed (ActionStateVector2F* __dsl_state = state)
            fixed (ActionStateGetInfo* __dsl_getInfo = getInfo)
            {
                return (Result)GetActionStateVector2F(session, __dsl_getInfo, __dsl_state);
            }
        }

        [NativeName("xrGetCurrentInteractionProfile")]
        [DllImport(
            "openxr_loader",
            ExactSpelling = true,
            EntryPoint = "xrGetCurrentInteractionProfile"
        )]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result GetCurrentInteractionProfile(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetCurrentInteractionProfile(
            SessionHandle session,
            ulong topLevelUserPath,
            Ref<InteractionProfileState> interactionProfile
        )
        {
            fixed (InteractionProfileState* __dsl_interactionProfile = interactionProfile)
            {
                return (Result)GetCurrentInteractionProfile(
                    session,
                    topLevelUserPath,
                    __dsl_interactionProfile
                );
            }
        }

        [NativeName("xrGetInputSourceLocalizedName")]
        [DllImport(
            "openxr_loader",
            ExactSpelling = true,
            EntryPoint = "xrGetInputSourceLocalizedName"
        )]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result GetInputSourceLocalizedName(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetInputSourceLocalizedName(
            SessionHandle session,
            Ref<InputSourceLocalizedNameGetInfo> getInfo,
            uint bufferCapacityInput,
            Ref<uint> bufferCountOutput,
            Ref<sbyte> buffer
        )
        {
            fixed (sbyte* __dsl_buffer = buffer)
            fixed (uint* __dsl_bufferCountOutput = bufferCountOutput)
            fixed (InputSourceLocalizedNameGetInfo* __dsl_getInfo = getInfo)
            {
                return (Result)GetInputSourceLocalizedName(
                    session,
                    __dsl_getInfo,
                    bufferCapacityInput,
                    __dsl_bufferCountOutput,
                    __dsl_buffer
                );
            }
        }

        [NativeName("xrGetInstanceProcAddr")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrGetInstanceProcAddr")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result GetInstanceProcAddr(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetInstanceProcAddr(
            InstanceHandle instance,
            Ref<sbyte> name,
            Ref<VoidFunction> function
        )
        {
            fixed (VoidFunction* __dsl_function = function)
            fixed (sbyte* __dsl_name = name)
            {
                return (Result)GetInstanceProcAddr(instance, __dsl_name, __dsl_function);
            }
        }

        [NativeName("xrGetInstanceProperties")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrGetInstanceProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result GetInstanceProperties(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetInstanceProperties(
            InstanceHandle instance,
            Ref<InstanceProperties> instanceProperties
        )
        {
            fixed (InstanceProperties* __dsl_instanceProperties = instanceProperties)
            {
                return (Result)GetInstanceProperties(instance, __dsl_instanceProperties);
            }
        }

        [NativeName("xrGetReferenceSpaceBoundsRect")]
        [DllImport(
            "openxr_loader",
            ExactSpelling = true,
            EntryPoint = "xrGetReferenceSpaceBoundsRect"
        )]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result GetReferenceSpaceBoundsRect(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetReferenceSpaceBoundsRect(
            SessionHandle session,
            ReferenceSpaceType referenceSpaceType,
            Ref<Extent2Df> bounds
        )
        {
            fixed (Extent2Df* __dsl_bounds = bounds)
            {
                return (Result)GetReferenceSpaceBoundsRect(
                    session,
                    referenceSpaceType,
                    __dsl_bounds
                );
            }
        }

        [NativeName("xrGetSystem")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrGetSystem")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result GetSystem(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetSystem(
            InstanceHandle instance,
            Ref<SystemGetInfo> getInfo,
            Ref<ulong> systemId
        )
        {
            fixed (ulong* __dsl_systemId = systemId)
            fixed (SystemGetInfo* __dsl_getInfo = getInfo)
            {
                return (Result)GetSystem(instance, __dsl_getInfo, __dsl_systemId);
            }
        }

        [NativeName("xrGetSystemProperties")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrGetSystemProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result GetSystemProperties(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetSystemProperties(
            InstanceHandle instance,
            ulong systemId,
            Ref<SystemProperties> properties
        )
        {
            fixed (SystemProperties* __dsl_properties = properties)
            {
                return (Result)GetSystemProperties(instance, systemId, __dsl_properties);
            }
        }

        [NativeName("xrGetViewConfigurationProperties")]
        [DllImport(
            "openxr_loader",
            ExactSpelling = true,
            EntryPoint = "xrGetViewConfigurationProperties"
        )]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result GetViewConfigurationProperties(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetViewConfigurationProperties(
            InstanceHandle instance,
            ulong systemId,
            ViewConfigurationType viewConfigurationType,
            Ref<ViewConfigurationProperties> configurationProperties
        )
        {
            fixed (
                ViewConfigurationProperties* __dsl_configurationProperties = configurationProperties
            )
            {
                return (Result)GetViewConfigurationProperties(
                    instance,
                    systemId,
                    viewConfigurationType,
                    __dsl_configurationProperties
                );
            }
        }

        [NativeName("xrLocateSpace")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrLocateSpace")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result LocateSpace(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result LocateSpace(
            SpaceHandle space,
            SpaceHandle baseSpace,
            long time,
            Ref<SpaceLocation> location
        )
        {
            fixed (SpaceLocation* __dsl_location = location)
            {
                return (Result)LocateSpace(space, baseSpace, time, __dsl_location);
            }
        }

        [NativeName("xrLocateSpaces")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrLocateSpaces")]
        [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
        public static extern Result LocateSpaces(
            SessionHandle session,
            SpacesLocateInfo* locateInfo,
            SpaceLocations* spaceLocations
        );

        [NativeName("xrLocateSpaces")]
        [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openxr_loader", EntryPoint = "xrLocateSpaces")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result LocateSpaces(
            SessionHandle session,
            Ref<SpacesLocateInfo> locateInfo,
            Ref<SpaceLocations> spaceLocations
        )
        {
            fixed (SpaceLocations* __dsl_spaceLocations = spaceLocations)
            fixed (SpacesLocateInfo* __dsl_locateInfo = locateInfo)
            {
                return (Result)LocateSpaces(session, __dsl_locateInfo, __dsl_spaceLocations);
            }
        }

        [NativeName("xrLocateViews")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrLocateViews")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result LocateViews(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result LocateViews(
            SessionHandle session,
            Ref<ViewLocateInfo> viewLocateInfo,
            Ref<ViewState> viewState,
            uint viewCapacityInput,
            Ref<uint> viewCountOutput,
            Ref<View> views
        )
        {
            fixed (View* __dsl_views = views)
            fixed (uint* __dsl_viewCountOutput = viewCountOutput)
            fixed (ViewState* __dsl_viewState = viewState)
            fixed (ViewLocateInfo* __dsl_viewLocateInfo = viewLocateInfo)
            {
                return (Result)LocateViews(
                    session,
                    __dsl_viewLocateInfo,
                    __dsl_viewState,
                    viewCapacityInput,
                    __dsl_viewCountOutput,
                    __dsl_views
                );
            }
        }

        [NativeName("xrPathToString")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrPathToString")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result PathToString(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result PathToString(
            InstanceHandle instance,
            ulong path,
            uint bufferCapacityInput,
            Ref<uint> bufferCountOutput,
            Ref<sbyte> buffer
        )
        {
            fixed (sbyte* __dsl_buffer = buffer)
            fixed (uint* __dsl_bufferCountOutput = bufferCountOutput)
            {
                return (Result)PathToString(
                    instance,
                    path,
                    bufferCapacityInput,
                    __dsl_bufferCountOutput,
                    __dsl_buffer
                );
            }
        }

        [NativeName("xrPollEvent")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrPollEvent")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result PollEvent(InstanceHandle instance, EventDataBuffer* eventData);

        [NativeName("xrPollEvent")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrPollEvent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result PollEvent(InstanceHandle instance, Ref<EventDataBuffer> eventData)
        {
            fixed (EventDataBuffer* __dsl_eventData = eventData)
            {
                return (Result)PollEvent(instance, __dsl_eventData);
            }
        }

        [NativeName("xrReleaseSwapchainImage")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrReleaseSwapchainImage")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result ReleaseSwapchainImage(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result ReleaseSwapchainImage(
            SwapchainHandle swapchain,
            Ref<SwapchainImageReleaseInfo> releaseInfo
        )
        {
            fixed (SwapchainImageReleaseInfo* __dsl_releaseInfo = releaseInfo)
            {
                return (Result)ReleaseSwapchainImage(swapchain, __dsl_releaseInfo);
            }
        }

        [NativeName("xrRequestExitSession")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrRequestExitSession")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result RequestExitSession(SessionHandle session);

        [NativeName("xrResultToString")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrResultToString")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result ResultToString(
            InstanceHandle instance,
            Result value,
            sbyte* buffer
        );

        [NativeName("xrResultToString")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrResultToString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result ResultToString(
            InstanceHandle instance,
            Result value,
            Ref<sbyte> buffer
        )
        {
            fixed (sbyte* __dsl_buffer = buffer)
            {
                return (Result)ResultToString(instance, value, __dsl_buffer);
            }
        }

        [NativeName("xrStopHapticFeedback")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrStopHapticFeedback")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result StopHapticFeedback(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result StopHapticFeedback(
            SessionHandle session,
            Ref<HapticActionInfo> hapticActionInfo
        )
        {
            fixed (HapticActionInfo* __dsl_hapticActionInfo = hapticActionInfo)
            {
                return (Result)StopHapticFeedback(session, __dsl_hapticActionInfo);
            }
        }

        [NativeName("xrStringToPath")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrStringToPath")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result StringToPath(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result StringToPath(
            InstanceHandle instance,
            Ref<sbyte> pathString,
            Ref<ulong> path
        )
        {
            fixed (ulong* __dsl_path = path)
            fixed (sbyte* __dsl_pathString = pathString)
            {
                return (Result)StringToPath(instance, __dsl_pathString, __dsl_path);
            }
        }

        [NativeName("xrStructureTypeToString")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrStructureTypeToString")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result StructureTypeToString(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result StructureTypeToString(
            InstanceHandle instance,
            StructureType value,
            Ref<sbyte> buffer
        )
        {
            fixed (sbyte* __dsl_buffer = buffer)
            {
                return (Result)StructureTypeToString(instance, value, __dsl_buffer);
            }
        }

        [NativeName("xrSuggestInteractionProfileBindings")]
        [DllImport(
            "openxr_loader",
            ExactSpelling = true,
            EntryPoint = "xrSuggestInteractionProfileBindings"
        )]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result SuggestInteractionProfileBindings(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result SuggestInteractionProfileBindings(
            InstanceHandle instance,
            Ref<InteractionProfileSuggestedBinding> suggestedBindings
        )
        {
            fixed (InteractionProfileSuggestedBinding* __dsl_suggestedBindings = suggestedBindings)
            {
                return (Result)SuggestInteractionProfileBindings(instance, __dsl_suggestedBindings);
            }
        }

        [NativeName("xrSyncActions")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrSyncActions")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result SyncActions(SessionHandle session, ActionsSyncInfo* syncInfo);

        [NativeName("xrSyncActions")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrSyncActions")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result SyncActions(SessionHandle session, Ref<ActionsSyncInfo> syncInfo)
        {
            fixed (ActionsSyncInfo* __dsl_syncInfo = syncInfo)
            {
                return (Result)SyncActions(session, __dsl_syncInfo);
            }
        }

        [NativeName("xrWaitFrame")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrWaitFrame")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result WaitFrame(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result WaitFrame(
            SessionHandle session,
            Ref<FrameWaitInfo> frameWaitInfo,
            Ref<FrameState> frameState
        )
        {
            fixed (FrameState* __dsl_frameState = frameState)
            fixed (FrameWaitInfo* __dsl_frameWaitInfo = frameWaitInfo)
            {
                return (Result)WaitFrame(session, __dsl_frameWaitInfo, __dsl_frameState);
            }
        }

        [NativeName("xrWaitSwapchainImage")]
        [DllImport("openxr_loader", ExactSpelling = true, EntryPoint = "xrWaitSwapchainImage")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        public static extern Result WaitSwapchainImage(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result WaitSwapchainImage(
            SwapchainHandle swapchain,
            Ref<SwapchainImageWaitInfo> waitInfo
        )
        {
            fixed (SwapchainImageWaitInfo* __dsl_waitInfo = waitInfo)
            {
                return (Result)WaitSwapchainImage(swapchain, __dsl_waitInfo);
            }
        }
    }

    public partial class StaticWrapper<T> : IXr
        where T : IXr.Static
    {
        [NativeName("xrAcquireSwapchainImage")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrAcquireSwapchainImage")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result AcquireSwapchainImage(
            SwapchainHandle swapchain,
            SwapchainImageAcquireInfo* acquireInfo,
            uint* index
        ) => T.AcquireSwapchainImage(swapchain, acquireInfo, index);

        [NativeName("xrAcquireSwapchainImage")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrAcquireSwapchainImage")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result AcquireSwapchainImage(
            SwapchainHandle swapchain,
            Ref<SwapchainImageAcquireInfo> acquireInfo,
            Ref<uint> index
        ) => T.AcquireSwapchainImage(swapchain, acquireInfo, index);

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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result ApplyHapticFeedback(
            SessionHandle session,
            HapticActionInfo* hapticActionInfo,
            HapticBaseHeader* hapticFeedback
        ) => T.ApplyHapticFeedback(session, hapticActionInfo, hapticFeedback);

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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result ApplyHapticFeedback(
            SessionHandle session,
            Ref<HapticActionInfo> hapticActionInfo,
            Ref<HapticBaseHeader> hapticFeedback
        ) => T.ApplyHapticFeedback(session, hapticActionInfo, hapticFeedback);

        [NativeName("xrAttachSessionActionSets")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrAttachSessionActionSets")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result AttachSessionActionSets(
            SessionHandle session,
            SessionActionSetsAttachInfo* attachInfo
        ) => T.AttachSessionActionSets(session, attachInfo);

        [NativeName("xrAttachSessionActionSets")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrAttachSessionActionSets")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result AttachSessionActionSets(
            SessionHandle session,
            Ref<SessionActionSetsAttachInfo> attachInfo
        ) => T.AttachSessionActionSets(session, attachInfo);

        [NativeName("xrBeginFrame")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrBeginFrame")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result BeginFrame(SessionHandle session, FrameBeginInfo* frameBeginInfo) =>
            T.BeginFrame(session, frameBeginInfo);

        [NativeName("xrBeginFrame")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrBeginFrame")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result BeginFrame(SessionHandle session, Ref<FrameBeginInfo> frameBeginInfo) =>
            T.BeginFrame(session, frameBeginInfo);

        [NativeName("xrBeginSession")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrBeginSession")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result BeginSession(SessionHandle session, SessionBeginInfo* beginInfo) =>
            T.BeginSession(session, beginInfo);

        [NativeName("xrBeginSession")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrBeginSession")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result BeginSession(SessionHandle session, Ref<SessionBeginInfo> beginInfo) =>
            T.BeginSession(session, beginInfo);

        [NativeName("xrCreateAction")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateAction")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result CreateAction(
            ActionSetHandle actionSet,
            ActionCreateInfo* createInfo,
            ActionHandle* action
        ) => T.CreateAction(actionSet, createInfo, action);

        [NativeName("xrCreateAction")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateAction")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result CreateAction(
            ActionSetHandle actionSet,
            Ref<ActionCreateInfo> createInfo,
            Ref<ActionHandle> action
        ) => T.CreateAction(actionSet, createInfo, action);

        [NativeName("xrCreateActionSet")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateActionSet")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result CreateActionSet(
            InstanceHandle instance,
            ActionSetCreateInfo* createInfo,
            ActionSetHandle* actionSet
        ) => T.CreateActionSet(instance, createInfo, actionSet);

        [NativeName("xrCreateActionSet")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateActionSet")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result CreateActionSet(
            InstanceHandle instance,
            Ref<ActionSetCreateInfo> createInfo,
            Ref<ActionSetHandle> actionSet
        ) => T.CreateActionSet(instance, createInfo, actionSet);

        [NativeName("xrCreateActionSpace")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateActionSpace")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result CreateActionSpace(
            SessionHandle session,
            ActionSpaceCreateInfo* createInfo,
            SpaceHandle* space
        ) => T.CreateActionSpace(session, createInfo, space);

        [NativeName("xrCreateActionSpace")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateActionSpace")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result CreateActionSpace(
            SessionHandle session,
            Ref<ActionSpaceCreateInfo> createInfo,
            Ref<SpaceHandle> space
        ) => T.CreateActionSpace(session, createInfo, space);

        [NativeName("xrCreateInstance")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateInstance")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result CreateInstance(InstanceCreateInfo* createInfo, InstanceHandle* instance) =>
            T.CreateInstance(createInfo, instance);

        [NativeName("xrCreateInstance")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateInstance")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result CreateInstance(
            Ref<InstanceCreateInfo> createInfo,
            Ref<InstanceHandle> instance
        ) => T.CreateInstance(createInfo, instance);

        [NativeName("xrCreateReferenceSpace")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateReferenceSpace")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result CreateReferenceSpace(
            SessionHandle session,
            ReferenceSpaceCreateInfo* createInfo,
            SpaceHandle* space
        ) => T.CreateReferenceSpace(session, createInfo, space);

        [NativeName("xrCreateReferenceSpace")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateReferenceSpace")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result CreateReferenceSpace(
            SessionHandle session,
            Ref<ReferenceSpaceCreateInfo> createInfo,
            Ref<SpaceHandle> space
        ) => T.CreateReferenceSpace(session, createInfo, space);

        [NativeName("xrCreateSession")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateSession")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result CreateSession(
            InstanceHandle instance,
            SessionCreateInfo* createInfo,
            SessionHandle* session
        ) => T.CreateSession(instance, createInfo, session);

        [NativeName("xrCreateSession")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateSession")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result CreateSession(
            InstanceHandle instance,
            Ref<SessionCreateInfo> createInfo,
            Ref<SessionHandle> session
        ) => T.CreateSession(instance, createInfo, session);

        [NativeName("xrCreateSwapchain")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateSwapchain")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result CreateSwapchain(
            SessionHandle session,
            SwapchainCreateInfo* createInfo,
            SwapchainHandle* swapchain
        ) => T.CreateSwapchain(session, createInfo, swapchain);

        [NativeName("xrCreateSwapchain")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateSwapchain")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result CreateSwapchain(
            SessionHandle session,
            Ref<SwapchainCreateInfo> createInfo,
            Ref<SwapchainHandle> swapchain
        ) => T.CreateSwapchain(session, createInfo, swapchain);

        [NativeName("xrDestroyAction")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrDestroyAction")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result DestroyAction(ActionHandle action) => T.DestroyAction(action);

        [NativeName("xrDestroyActionSet")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrDestroyActionSet")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result DestroyActionSet(ActionSetHandle actionSet) => T.DestroyActionSet(actionSet);

        [NativeName("xrDestroyInstance")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrDestroyInstance")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result DestroyInstance(InstanceHandle instance) => T.DestroyInstance(instance);

        [NativeName("xrDestroySession")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrDestroySession")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result DestroySession(SessionHandle session) => T.DestroySession(session);

        [NativeName("xrDestroySpace")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrDestroySpace")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result DestroySpace(SpaceHandle space) => T.DestroySpace(space);

        [NativeName("xrDestroySwapchain")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrDestroySwapchain")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result DestroySwapchain(SwapchainHandle swapchain) => T.DestroySwapchain(swapchain);

        [NativeName("xrEndFrame")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEndFrame")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result EndFrame(SessionHandle session, FrameEndInfo* frameEndInfo) =>
            T.EndFrame(session, frameEndInfo);

        [NativeName("xrEndFrame")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEndFrame")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result EndFrame(SessionHandle session, Ref<FrameEndInfo> frameEndInfo) =>
            T.EndFrame(session, frameEndInfo);

        [NativeName("xrEndSession")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEndSession")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result EndSession(SessionHandle session) => T.EndSession(session);

        [NativeName("xrEnumerateApiLayerProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateApiLayerProperties")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result EnumerateApiLayerProperties(
            uint propertyCapacityInput,
            uint* propertyCountOutput,
            ApiLayerProperties* properties
        ) => T.EnumerateApiLayerProperties(propertyCapacityInput, propertyCountOutput, properties);

        [NativeName("xrEnumerateApiLayerProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateApiLayerProperties")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result EnumerateApiLayerProperties(
            uint propertyCapacityInput,
            Ref<uint> propertyCountOutput,
            Ref<ApiLayerProperties> properties
        ) => T.EnumerateApiLayerProperties(propertyCapacityInput, propertyCountOutput, properties);

        [NativeName("xrEnumerateBoundSourcesForAction")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateBoundSourcesForAction")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result EnumerateBoundSourcesForAction(
            SessionHandle session,
            BoundSourcesForActionEnumerateInfo* enumerateInfo,
            uint sourceCapacityInput,
            uint* sourceCountOutput,
            ulong* sources
        ) =>
            T.EnumerateBoundSourcesForAction(
                session,
                enumerateInfo,
                sourceCapacityInput,
                sourceCountOutput,
                sources
            );

        [NativeName("xrEnumerateBoundSourcesForAction")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateBoundSourcesForAction")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result EnumerateBoundSourcesForAction(
            SessionHandle session,
            Ref<BoundSourcesForActionEnumerateInfo> enumerateInfo,
            uint sourceCapacityInput,
            Ref<uint> sourceCountOutput,
            Ref<ulong> sources
        ) =>
            T.EnumerateBoundSourcesForAction(
                session,
                enumerateInfo,
                sourceCapacityInput,
                sourceCountOutput,
                sources
            );

        [NativeName("xrEnumerateEnvironmentBlendModes")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateEnvironmentBlendModes")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result EnumerateEnvironmentBlendModes(
            InstanceHandle instance,
            ulong systemId,
            ViewConfigurationType viewConfigurationType,
            uint environmentBlendModeCapacityInput,
            uint* environmentBlendModeCountOutput,
            EnvironmentBlendMode* environmentBlendModes
        ) =>
            T.EnumerateEnvironmentBlendModes(
                instance,
                systemId,
                viewConfigurationType,
                environmentBlendModeCapacityInput,
                environmentBlendModeCountOutput,
                environmentBlendModes
            );

        [NativeName("xrEnumerateEnvironmentBlendModes")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateEnvironmentBlendModes")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result EnumerateEnvironmentBlendModes(
            InstanceHandle instance,
            ulong systemId,
            ViewConfigurationType viewConfigurationType,
            uint environmentBlendModeCapacityInput,
            Ref<uint> environmentBlendModeCountOutput,
            Ref<EnvironmentBlendMode> environmentBlendModes
        ) =>
            T.EnumerateEnvironmentBlendModes(
                instance,
                systemId,
                viewConfigurationType,
                environmentBlendModeCapacityInput,
                environmentBlendModeCountOutput,
                environmentBlendModes
            );

        [NativeName("xrEnumerateInstanceExtensionProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateInstanceExtensionProperties")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result EnumerateInstanceExtensionProperties(
            sbyte* layerName,
            uint propertyCapacityInput,
            uint* propertyCountOutput,
            ExtensionProperties* properties
        ) =>
            T.EnumerateInstanceExtensionProperties(
                layerName,
                propertyCapacityInput,
                propertyCountOutput,
                properties
            );

        [NativeName("xrEnumerateInstanceExtensionProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateInstanceExtensionProperties")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result EnumerateInstanceExtensionProperties(
            Ref<sbyte> layerName,
            uint propertyCapacityInput,
            Ref<uint> propertyCountOutput,
            Ref<ExtensionProperties> properties
        ) =>
            T.EnumerateInstanceExtensionProperties(
                layerName,
                propertyCapacityInput,
                propertyCountOutput,
                properties
            );

        [NativeName("xrEnumerateReferenceSpaces")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateReferenceSpaces")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result EnumerateReferenceSpaces(
            SessionHandle session,
            uint spaceCapacityInput,
            uint* spaceCountOutput,
            ReferenceSpaceType* spaces
        ) => T.EnumerateReferenceSpaces(session, spaceCapacityInput, spaceCountOutput, spaces);

        [NativeName("xrEnumerateReferenceSpaces")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateReferenceSpaces")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result EnumerateReferenceSpaces(
            SessionHandle session,
            uint spaceCapacityInput,
            Ref<uint> spaceCountOutput,
            Ref<ReferenceSpaceType> spaces
        ) => T.EnumerateReferenceSpaces(session, spaceCapacityInput, spaceCountOutput, spaces);

        [NativeName("xrEnumerateSwapchainFormats")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateSwapchainFormats")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result EnumerateSwapchainFormats(
            SessionHandle session,
            uint formatCapacityInput,
            uint* formatCountOutput,
            long* formats
        ) => T.EnumerateSwapchainFormats(session, formatCapacityInput, formatCountOutput, formats);

        [NativeName("xrEnumerateSwapchainFormats")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateSwapchainFormats")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result EnumerateSwapchainFormats(
            SessionHandle session,
            uint formatCapacityInput,
            Ref<uint> formatCountOutput,
            Ref<long> formats
        ) => T.EnumerateSwapchainFormats(session, formatCapacityInput, formatCountOutput, formats);

        [NativeName("xrEnumerateSwapchainImages")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateSwapchainImages")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result EnumerateSwapchainImages(
            SwapchainHandle swapchain,
            uint imageCapacityInput,
            uint* imageCountOutput,
            SwapchainImageBaseHeader* images
        ) => T.EnumerateSwapchainImages(swapchain, imageCapacityInput, imageCountOutput, images);

        [NativeName("xrEnumerateSwapchainImages")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateSwapchainImages")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result EnumerateSwapchainImages(
            SwapchainHandle swapchain,
            uint imageCapacityInput,
            Ref<uint> imageCountOutput,
            Ref<SwapchainImageBaseHeader> images
        ) => T.EnumerateSwapchainImages(swapchain, imageCapacityInput, imageCountOutput, images);

        [NativeName("xrEnumerateViewConfigurations")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateViewConfigurations")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result EnumerateViewConfigurations(
            InstanceHandle instance,
            ulong systemId,
            uint viewConfigurationTypeCapacityInput,
            uint* viewConfigurationTypeCountOutput,
            ViewConfigurationType* viewConfigurationTypes
        ) =>
            T.EnumerateViewConfigurations(
                instance,
                systemId,
                viewConfigurationTypeCapacityInput,
                viewConfigurationTypeCountOutput,
                viewConfigurationTypes
            );

        [NativeName("xrEnumerateViewConfigurations")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateViewConfigurations")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result EnumerateViewConfigurations(
            InstanceHandle instance,
            ulong systemId,
            uint viewConfigurationTypeCapacityInput,
            Ref<uint> viewConfigurationTypeCountOutput,
            Ref<ViewConfigurationType> viewConfigurationTypes
        ) =>
            T.EnumerateViewConfigurations(
                instance,
                systemId,
                viewConfigurationTypeCapacityInput,
                viewConfigurationTypeCountOutput,
                viewConfigurationTypes
            );

        [NativeName("xrEnumerateViewConfigurationViews")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateViewConfigurationViews")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result EnumerateViewConfigurationViews(
            InstanceHandle instance,
            ulong systemId,
            ViewConfigurationType viewConfigurationType,
            uint viewCapacityInput,
            uint* viewCountOutput,
            ViewConfigurationView* views
        ) =>
            T.EnumerateViewConfigurationViews(
                instance,
                systemId,
                viewConfigurationType,
                viewCapacityInput,
                viewCountOutput,
                views
            );

        [NativeName("xrEnumerateViewConfigurationViews")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateViewConfigurationViews")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result EnumerateViewConfigurationViews(
            InstanceHandle instance,
            ulong systemId,
            ViewConfigurationType viewConfigurationType,
            uint viewCapacityInput,
            Ref<uint> viewCountOutput,
            Ref<ViewConfigurationView> views
        ) =>
            T.EnumerateViewConfigurationViews(
                instance,
                systemId,
                viewConfigurationType,
                viewCapacityInput,
                viewCountOutput,
                views
            );

        [NativeName("xrGetActionStateBoolean")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateBoolean")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result GetActionStateBoolean(
            SessionHandle session,
            ActionStateGetInfo* getInfo,
            ActionStateBoolean* state
        ) => T.GetActionStateBoolean(session, getInfo, state);

        [NativeName("xrGetActionStateBoolean")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateBoolean")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result GetActionStateBoolean(
            SessionHandle session,
            Ref<ActionStateGetInfo> getInfo,
            Ref<ActionStateBoolean> state
        ) => T.GetActionStateBoolean(session, getInfo, state);

        [NativeName("xrGetActionStateFloat")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateFloat")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result GetActionStateFloat(
            SessionHandle session,
            ActionStateGetInfo* getInfo,
            ActionStateFloat* state
        ) => T.GetActionStateFloat(session, getInfo, state);

        [NativeName("xrGetActionStateFloat")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateFloat")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result GetActionStateFloat(
            SessionHandle session,
            Ref<ActionStateGetInfo> getInfo,
            Ref<ActionStateFloat> state
        ) => T.GetActionStateFloat(session, getInfo, state);

        [NativeName("xrGetActionStatePose")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStatePose")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result GetActionStatePose(
            SessionHandle session,
            ActionStateGetInfo* getInfo,
            ActionStatePose* state
        ) => T.GetActionStatePose(session, getInfo, state);

        [NativeName("xrGetActionStatePose")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStatePose")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result GetActionStatePose(
            SessionHandle session,
            Ref<ActionStateGetInfo> getInfo,
            Ref<ActionStatePose> state
        ) => T.GetActionStatePose(session, getInfo, state);

        [NativeName("xrGetActionStateVector2f")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateVector2f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result GetActionStateVector2F(
            SessionHandle session,
            ActionStateGetInfo* getInfo,
            ActionStateVector2F* state
        ) => T.GetActionStateVector2F(session, getInfo, state);

        [NativeName("xrGetActionStateVector2f")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateVector2f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result GetActionStateVector2F(
            SessionHandle session,
            Ref<ActionStateGetInfo> getInfo,
            Ref<ActionStateVector2F> state
        ) => T.GetActionStateVector2F(session, getInfo, state);

        [NativeName("xrGetCurrentInteractionProfile")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetCurrentInteractionProfile")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result GetCurrentInteractionProfile(
            SessionHandle session,
            ulong topLevelUserPath,
            InteractionProfileState* interactionProfile
        ) => T.GetCurrentInteractionProfile(session, topLevelUserPath, interactionProfile);

        [NativeName("xrGetCurrentInteractionProfile")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetCurrentInteractionProfile")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result GetCurrentInteractionProfile(
            SessionHandle session,
            ulong topLevelUserPath,
            Ref<InteractionProfileState> interactionProfile
        ) => T.GetCurrentInteractionProfile(session, topLevelUserPath, interactionProfile);

        [NativeName("xrGetInputSourceLocalizedName")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetInputSourceLocalizedName")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result GetInputSourceLocalizedName(
            SessionHandle session,
            InputSourceLocalizedNameGetInfo* getInfo,
            uint bufferCapacityInput,
            uint* bufferCountOutput,
            sbyte* buffer
        ) =>
            T.GetInputSourceLocalizedName(
                session,
                getInfo,
                bufferCapacityInput,
                bufferCountOutput,
                buffer
            );

        [NativeName("xrGetInputSourceLocalizedName")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetInputSourceLocalizedName")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result GetInputSourceLocalizedName(
            SessionHandle session,
            Ref<InputSourceLocalizedNameGetInfo> getInfo,
            uint bufferCapacityInput,
            Ref<uint> bufferCountOutput,
            Ref<sbyte> buffer
        ) =>
            T.GetInputSourceLocalizedName(
                session,
                getInfo,
                bufferCapacityInput,
                bufferCountOutput,
                buffer
            );

        [NativeName("xrGetInstanceProcAddr")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetInstanceProcAddr")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result GetInstanceProcAddr(
            InstanceHandle instance,
            sbyte* name,
            VoidFunction* function
        ) => T.GetInstanceProcAddr(instance, name, function);

        [NativeName("xrGetInstanceProcAddr")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetInstanceProcAddr")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result GetInstanceProcAddr(
            InstanceHandle instance,
            Ref<sbyte> name,
            Ref<VoidFunction> function
        ) => T.GetInstanceProcAddr(instance, name, function);

        [NativeName("xrGetInstanceProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetInstanceProperties")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result GetInstanceProperties(
            InstanceHandle instance,
            InstanceProperties* instanceProperties
        ) => T.GetInstanceProperties(instance, instanceProperties);

        [NativeName("xrGetInstanceProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetInstanceProperties")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result GetInstanceProperties(
            InstanceHandle instance,
            Ref<InstanceProperties> instanceProperties
        ) => T.GetInstanceProperties(instance, instanceProperties);

        [NativeName("xrGetReferenceSpaceBoundsRect")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetReferenceSpaceBoundsRect")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result GetReferenceSpaceBoundsRect(
            SessionHandle session,
            ReferenceSpaceType referenceSpaceType,
            Extent2Df* bounds
        ) => T.GetReferenceSpaceBoundsRect(session, referenceSpaceType, bounds);

        [NativeName("xrGetReferenceSpaceBoundsRect")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetReferenceSpaceBoundsRect")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result GetReferenceSpaceBoundsRect(
            SessionHandle session,
            ReferenceSpaceType referenceSpaceType,
            Ref<Extent2Df> bounds
        ) => T.GetReferenceSpaceBoundsRect(session, referenceSpaceType, bounds);

        [NativeName("xrGetSystem")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetSystem")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result GetSystem(InstanceHandle instance, SystemGetInfo* getInfo, ulong* systemId) =>
            T.GetSystem(instance, getInfo, systemId);

        [NativeName("xrGetSystem")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetSystem")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result GetSystem(
            InstanceHandle instance,
            Ref<SystemGetInfo> getInfo,
            Ref<ulong> systemId
        ) => T.GetSystem(instance, getInfo, systemId);

        [NativeName("xrGetSystemProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetSystemProperties")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result GetSystemProperties(
            InstanceHandle instance,
            ulong systemId,
            SystemProperties* properties
        ) => T.GetSystemProperties(instance, systemId, properties);

        [NativeName("xrGetSystemProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetSystemProperties")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result GetSystemProperties(
            InstanceHandle instance,
            ulong systemId,
            Ref<SystemProperties> properties
        ) => T.GetSystemProperties(instance, systemId, properties);

        [NativeName("xrGetViewConfigurationProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetViewConfigurationProperties")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result GetViewConfigurationProperties(
            InstanceHandle instance,
            ulong systemId,
            ViewConfigurationType viewConfigurationType,
            ViewConfigurationProperties* configurationProperties
        ) =>
            T.GetViewConfigurationProperties(
                instance,
                systemId,
                viewConfigurationType,
                configurationProperties
            );

        [NativeName("xrGetViewConfigurationProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetViewConfigurationProperties")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result GetViewConfigurationProperties(
            InstanceHandle instance,
            ulong systemId,
            ViewConfigurationType viewConfigurationType,
            Ref<ViewConfigurationProperties> configurationProperties
        ) =>
            T.GetViewConfigurationProperties(
                instance,
                systemId,
                viewConfigurationType,
                configurationProperties
            );

        [NativeName("xrLocateSpace")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrLocateSpace")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result LocateSpace(
            SpaceHandle space,
            SpaceHandle baseSpace,
            long time,
            SpaceLocation* location
        ) => T.LocateSpace(space, baseSpace, time, location);

        [NativeName("xrLocateSpace")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrLocateSpace")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result LocateSpace(
            SpaceHandle space,
            SpaceHandle baseSpace,
            long time,
            Ref<SpaceLocation> location
        ) => T.LocateSpace(space, baseSpace, time, location);

        [NativeName("xrLocateSpaces")]
        [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openxr_loader", EntryPoint = "xrLocateSpaces")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result LocateSpaces(
            SessionHandle session,
            SpacesLocateInfo* locateInfo,
            SpaceLocations* spaceLocations
        ) => T.LocateSpaces(session, locateInfo, spaceLocations);

        [NativeName("xrLocateSpaces")]
        [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openxr_loader", EntryPoint = "xrLocateSpaces")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result LocateSpaces(
            SessionHandle session,
            Ref<SpacesLocateInfo> locateInfo,
            Ref<SpaceLocations> spaceLocations
        ) => T.LocateSpaces(session, locateInfo, spaceLocations);

        [NativeName("xrLocateViews")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrLocateViews")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result LocateViews(
            SessionHandle session,
            ViewLocateInfo* viewLocateInfo,
            ViewState* viewState,
            uint viewCapacityInput,
            uint* viewCountOutput,
            View* views
        ) =>
            T.LocateViews(
                session,
                viewLocateInfo,
                viewState,
                viewCapacityInput,
                viewCountOutput,
                views
            );

        [NativeName("xrLocateViews")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrLocateViews")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result LocateViews(
            SessionHandle session,
            Ref<ViewLocateInfo> viewLocateInfo,
            Ref<ViewState> viewState,
            uint viewCapacityInput,
            Ref<uint> viewCountOutput,
            Ref<View> views
        ) =>
            T.LocateViews(
                session,
                viewLocateInfo,
                viewState,
                viewCapacityInput,
                viewCountOutput,
                views
            );

        [NativeName("xrPathToString")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrPathToString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result PathToString(
            InstanceHandle instance,
            ulong path,
            uint bufferCapacityInput,
            uint* bufferCountOutput,
            sbyte* buffer
        ) => T.PathToString(instance, path, bufferCapacityInput, bufferCountOutput, buffer);

        [NativeName("xrPathToString")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrPathToString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result PathToString(
            InstanceHandle instance,
            ulong path,
            uint bufferCapacityInput,
            Ref<uint> bufferCountOutput,
            Ref<sbyte> buffer
        ) => T.PathToString(instance, path, bufferCapacityInput, bufferCountOutput, buffer);

        [NativeName("xrPollEvent")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrPollEvent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result PollEvent(InstanceHandle instance, EventDataBuffer* eventData) =>
            T.PollEvent(instance, eventData);

        [NativeName("xrPollEvent")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrPollEvent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result PollEvent(InstanceHandle instance, Ref<EventDataBuffer> eventData) =>
            T.PollEvent(instance, eventData);

        [NativeName("xrReleaseSwapchainImage")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrReleaseSwapchainImage")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result ReleaseSwapchainImage(
            SwapchainHandle swapchain,
            SwapchainImageReleaseInfo* releaseInfo
        ) => T.ReleaseSwapchainImage(swapchain, releaseInfo);

        [NativeName("xrReleaseSwapchainImage")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrReleaseSwapchainImage")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result ReleaseSwapchainImage(
            SwapchainHandle swapchain,
            Ref<SwapchainImageReleaseInfo> releaseInfo
        ) => T.ReleaseSwapchainImage(swapchain, releaseInfo);

        [NativeName("xrRequestExitSession")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrRequestExitSession")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result RequestExitSession(SessionHandle session) => T.RequestExitSession(session);

        [NativeName("xrResultToString")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrResultToString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result ResultToString(InstanceHandle instance, Result value, sbyte* buffer) =>
            T.ResultToString(instance, value, buffer);

        [NativeName("xrResultToString")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrResultToString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result ResultToString(InstanceHandle instance, Result value, Ref<sbyte> buffer) =>
            T.ResultToString(instance, value, buffer);

        [NativeName("xrStopHapticFeedback")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrStopHapticFeedback")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result StopHapticFeedback(
            SessionHandle session,
            HapticActionInfo* hapticActionInfo
        ) => T.StopHapticFeedback(session, hapticActionInfo);

        [NativeName("xrStopHapticFeedback")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrStopHapticFeedback")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result StopHapticFeedback(
            SessionHandle session,
            Ref<HapticActionInfo> hapticActionInfo
        ) => T.StopHapticFeedback(session, hapticActionInfo);

        [NativeName("xrStringToPath")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrStringToPath")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result StringToPath(InstanceHandle instance, sbyte* pathString, ulong* path) =>
            T.StringToPath(instance, pathString, path);

        [NativeName("xrStringToPath")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrStringToPath")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result StringToPath(
            InstanceHandle instance,
            Ref<sbyte> pathString,
            Ref<ulong> path
        ) => T.StringToPath(instance, pathString, path);

        [NativeName("xrStructureTypeToString")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrStructureTypeToString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result StructureTypeToString(
            InstanceHandle instance,
            StructureType value,
            sbyte* buffer
        ) => T.StructureTypeToString(instance, value, buffer);

        [NativeName("xrStructureTypeToString")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrStructureTypeToString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result StructureTypeToString(
            InstanceHandle instance,
            StructureType value,
            Ref<sbyte> buffer
        ) => T.StructureTypeToString(instance, value, buffer);

        [NativeName("xrSuggestInteractionProfileBindings")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrSuggestInteractionProfileBindings")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result SuggestInteractionProfileBindings(
            InstanceHandle instance,
            InteractionProfileSuggestedBinding* suggestedBindings
        ) => T.SuggestInteractionProfileBindings(instance, suggestedBindings);

        [NativeName("xrSuggestInteractionProfileBindings")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrSuggestInteractionProfileBindings")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result SuggestInteractionProfileBindings(
            InstanceHandle instance,
            Ref<InteractionProfileSuggestedBinding> suggestedBindings
        ) => T.SuggestInteractionProfileBindings(instance, suggestedBindings);

        [NativeName("xrSyncActions")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrSyncActions")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result SyncActions(SessionHandle session, ActionsSyncInfo* syncInfo) =>
            T.SyncActions(session, syncInfo);

        [NativeName("xrSyncActions")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrSyncActions")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result SyncActions(SessionHandle session, Ref<ActionsSyncInfo> syncInfo) =>
            T.SyncActions(session, syncInfo);

        [NativeName("xrWaitFrame")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrWaitFrame")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result WaitFrame(
            SessionHandle session,
            FrameWaitInfo* frameWaitInfo,
            FrameState* frameState
        ) => T.WaitFrame(session, frameWaitInfo, frameState);

        [NativeName("xrWaitFrame")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrWaitFrame")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result WaitFrame(
            SessionHandle session,
            Ref<FrameWaitInfo> frameWaitInfo,
            Ref<FrameState> frameState
        ) => T.WaitFrame(session, frameWaitInfo, frameState);

        [NativeName("xrWaitSwapchainImage")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrWaitSwapchainImage")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result WaitSwapchainImage(
            SwapchainHandle swapchain,
            SwapchainImageWaitInfo* waitInfo
        ) => T.WaitSwapchainImage(swapchain, waitInfo);

        [NativeName("xrWaitSwapchainImage")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrWaitSwapchainImage")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Result WaitSwapchainImage(
            SwapchainHandle swapchain,
            Ref<SwapchainImageWaitInfo> waitInfo
        ) => T.WaitSwapchainImage(swapchain, waitInfo);
    }

    public partial class ThisThread
    {
        [NativeName("xrAcquireSwapchainImage")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrAcquireSwapchainImage")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result AcquireSwapchainImage(
            SwapchainHandle swapchain,
            SwapchainImageAcquireInfo* acquireInfo,
            uint* index
        ) => Underlying.Value!.AcquireSwapchainImage(swapchain, acquireInfo, index);

        [NativeName("xrAcquireSwapchainImage")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrAcquireSwapchainImage")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result AcquireSwapchainImage(
            SwapchainHandle swapchain,
            Ref<SwapchainImageAcquireInfo> acquireInfo,
            Ref<uint> index
        )
        {
            fixed (uint* __dsl_index = index)
            fixed (SwapchainImageAcquireInfo* __dsl_acquireInfo = acquireInfo)
            {
                return (Result)AcquireSwapchainImage(swapchain, __dsl_acquireInfo, __dsl_index);
            }
        }

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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result ApplyHapticFeedback(
            SessionHandle session,
            HapticActionInfo* hapticActionInfo,
            HapticBaseHeader* hapticFeedback
        ) => Underlying.Value!.ApplyHapticFeedback(session, hapticActionInfo, hapticFeedback);

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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result ApplyHapticFeedback(
            SessionHandle session,
            Ref<HapticActionInfo> hapticActionInfo,
            Ref<HapticBaseHeader> hapticFeedback
        )
        {
            fixed (HapticBaseHeader* __dsl_hapticFeedback = hapticFeedback)
            fixed (HapticActionInfo* __dsl_hapticActionInfo = hapticActionInfo)
            {
                return (Result)ApplyHapticFeedback(
                    session,
                    __dsl_hapticActionInfo,
                    __dsl_hapticFeedback
                );
            }
        }

        [NativeName("xrAttachSessionActionSets")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrAttachSessionActionSets")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result AttachSessionActionSets(
            SessionHandle session,
            SessionActionSetsAttachInfo* attachInfo
        ) => Underlying.Value!.AttachSessionActionSets(session, attachInfo);

        [NativeName("xrAttachSessionActionSets")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrAttachSessionActionSets")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result AttachSessionActionSets(
            SessionHandle session,
            Ref<SessionActionSetsAttachInfo> attachInfo
        )
        {
            fixed (SessionActionSetsAttachInfo* __dsl_attachInfo = attachInfo)
            {
                return (Result)AttachSessionActionSets(session, __dsl_attachInfo);
            }
        }

        [NativeName("xrBeginFrame")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrBeginFrame")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result BeginFrame(SessionHandle session, FrameBeginInfo* frameBeginInfo) =>
            Underlying.Value!.BeginFrame(session, frameBeginInfo);

        [NativeName("xrBeginFrame")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrBeginFrame")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result BeginFrame(SessionHandle session, Ref<FrameBeginInfo> frameBeginInfo)
        {
            fixed (FrameBeginInfo* __dsl_frameBeginInfo = frameBeginInfo)
            {
                return (Result)BeginFrame(session, __dsl_frameBeginInfo);
            }
        }

        [NativeName("xrBeginSession")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrBeginSession")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result BeginSession(SessionHandle session, SessionBeginInfo* beginInfo) =>
            Underlying.Value!.BeginSession(session, beginInfo);

        [NativeName("xrBeginSession")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrBeginSession")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result BeginSession(SessionHandle session, Ref<SessionBeginInfo> beginInfo)
        {
            fixed (SessionBeginInfo* __dsl_beginInfo = beginInfo)
            {
                return (Result)BeginSession(session, __dsl_beginInfo);
            }
        }

        [NativeName("xrCreateAction")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateAction")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result CreateAction(
            ActionSetHandle actionSet,
            ActionCreateInfo* createInfo,
            ActionHandle* action
        ) => Underlying.Value!.CreateAction(actionSet, createInfo, action);

        [NativeName("xrCreateAction")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateAction")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result CreateAction(
            ActionSetHandle actionSet,
            Ref<ActionCreateInfo> createInfo,
            Ref<ActionHandle> action
        )
        {
            fixed (ActionHandle* __dsl_action = action)
            fixed (ActionCreateInfo* __dsl_createInfo = createInfo)
            {
                return (Result)CreateAction(actionSet, __dsl_createInfo, __dsl_action);
            }
        }

        [NativeName("xrCreateActionSet")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateActionSet")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result CreateActionSet(
            InstanceHandle instance,
            ActionSetCreateInfo* createInfo,
            ActionSetHandle* actionSet
        ) => Underlying.Value!.CreateActionSet(instance, createInfo, actionSet);

        [NativeName("xrCreateActionSet")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateActionSet")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result CreateActionSet(
            InstanceHandle instance,
            Ref<ActionSetCreateInfo> createInfo,
            Ref<ActionSetHandle> actionSet
        )
        {
            fixed (ActionSetHandle* __dsl_actionSet = actionSet)
            fixed (ActionSetCreateInfo* __dsl_createInfo = createInfo)
            {
                return (Result)CreateActionSet(instance, __dsl_createInfo, __dsl_actionSet);
            }
        }

        [NativeName("xrCreateActionSpace")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateActionSpace")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result CreateActionSpace(
            SessionHandle session,
            ActionSpaceCreateInfo* createInfo,
            SpaceHandle* space
        ) => Underlying.Value!.CreateActionSpace(session, createInfo, space);

        [NativeName("xrCreateActionSpace")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateActionSpace")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result CreateActionSpace(
            SessionHandle session,
            Ref<ActionSpaceCreateInfo> createInfo,
            Ref<SpaceHandle> space
        )
        {
            fixed (SpaceHandle* __dsl_space = space)
            fixed (ActionSpaceCreateInfo* __dsl_createInfo = createInfo)
            {
                return (Result)CreateActionSpace(session, __dsl_createInfo, __dsl_space);
            }
        }

        [NativeName("xrCreateInstance")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateInstance")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result CreateInstance(
            InstanceCreateInfo* createInfo,
            InstanceHandle* instance
        ) => Underlying.Value!.CreateInstance(createInfo, instance);

        [NativeName("xrCreateInstance")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateInstance")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result CreateInstance(
            Ref<InstanceCreateInfo> createInfo,
            Ref<InstanceHandle> instance
        )
        {
            fixed (InstanceHandle* __dsl_instance = instance)
            fixed (InstanceCreateInfo* __dsl_createInfo = createInfo)
            {
                return (Result)CreateInstance(__dsl_createInfo, __dsl_instance);
            }
        }

        [NativeName("xrCreateReferenceSpace")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateReferenceSpace")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result CreateReferenceSpace(
            SessionHandle session,
            ReferenceSpaceCreateInfo* createInfo,
            SpaceHandle* space
        ) => Underlying.Value!.CreateReferenceSpace(session, createInfo, space);

        [NativeName("xrCreateReferenceSpace")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateReferenceSpace")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result CreateReferenceSpace(
            SessionHandle session,
            Ref<ReferenceSpaceCreateInfo> createInfo,
            Ref<SpaceHandle> space
        )
        {
            fixed (SpaceHandle* __dsl_space = space)
            fixed (ReferenceSpaceCreateInfo* __dsl_createInfo = createInfo)
            {
                return (Result)CreateReferenceSpace(session, __dsl_createInfo, __dsl_space);
            }
        }

        [NativeName("xrCreateSession")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateSession")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result CreateSession(
            InstanceHandle instance,
            SessionCreateInfo* createInfo,
            SessionHandle* session
        ) => Underlying.Value!.CreateSession(instance, createInfo, session);

        [NativeName("xrCreateSession")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateSession")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result CreateSession(
            InstanceHandle instance,
            Ref<SessionCreateInfo> createInfo,
            Ref<SessionHandle> session
        )
        {
            fixed (SessionHandle* __dsl_session = session)
            fixed (SessionCreateInfo* __dsl_createInfo = createInfo)
            {
                return (Result)CreateSession(instance, __dsl_createInfo, __dsl_session);
            }
        }

        [NativeName("xrCreateSwapchain")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateSwapchain")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result CreateSwapchain(
            SessionHandle session,
            SwapchainCreateInfo* createInfo,
            SwapchainHandle* swapchain
        ) => Underlying.Value!.CreateSwapchain(session, createInfo, swapchain);

        [NativeName("xrCreateSwapchain")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrCreateSwapchain")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result CreateSwapchain(
            SessionHandle session,
            Ref<SwapchainCreateInfo> createInfo,
            Ref<SwapchainHandle> swapchain
        )
        {
            fixed (SwapchainHandle* __dsl_swapchain = swapchain)
            fixed (SwapchainCreateInfo* __dsl_createInfo = createInfo)
            {
                return (Result)CreateSwapchain(session, __dsl_createInfo, __dsl_swapchain);
            }
        }

        [NativeName("xrDestroyAction")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrDestroyAction")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result DestroyAction(ActionHandle action) =>
            Underlying.Value!.DestroyAction(action);

        [NativeName("xrDestroyActionSet")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrDestroyActionSet")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result DestroyActionSet(ActionSetHandle actionSet) =>
            Underlying.Value!.DestroyActionSet(actionSet);

        [NativeName("xrDestroyInstance")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrDestroyInstance")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result DestroyInstance(InstanceHandle instance) =>
            Underlying.Value!.DestroyInstance(instance);

        [NativeName("xrDestroySession")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrDestroySession")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result DestroySession(SessionHandle session) =>
            Underlying.Value!.DestroySession(session);

        [NativeName("xrDestroySpace")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrDestroySpace")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result DestroySpace(SpaceHandle space) =>
            Underlying.Value!.DestroySpace(space);

        [NativeName("xrDestroySwapchain")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrDestroySwapchain")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result DestroySwapchain(SwapchainHandle swapchain) =>
            Underlying.Value!.DestroySwapchain(swapchain);

        [NativeName("xrEndFrame")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEndFrame")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EndFrame(SessionHandle session, FrameEndInfo* frameEndInfo) =>
            Underlying.Value!.EndFrame(session, frameEndInfo);

        [NativeName("xrEndFrame")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEndFrame")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EndFrame(SessionHandle session, Ref<FrameEndInfo> frameEndInfo)
        {
            fixed (FrameEndInfo* __dsl_frameEndInfo = frameEndInfo)
            {
                return (Result)EndFrame(session, __dsl_frameEndInfo);
            }
        }

        [NativeName("xrEndSession")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEndSession")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EndSession(SessionHandle session) =>
            Underlying.Value!.EndSession(session);

        [NativeName("xrEnumerateApiLayerProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateApiLayerProperties")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EnumerateApiLayerProperties(
            uint propertyCapacityInput,
            uint* propertyCountOutput,
            ApiLayerProperties* properties
        ) =>
            Underlying.Value!.EnumerateApiLayerProperties(
                propertyCapacityInput,
                propertyCountOutput,
                properties
            );

        [NativeName("xrEnumerateApiLayerProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateApiLayerProperties")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EnumerateApiLayerProperties(
            uint propertyCapacityInput,
            Ref<uint> propertyCountOutput,
            Ref<ApiLayerProperties> properties
        )
        {
            fixed (ApiLayerProperties* __dsl_properties = properties)
            fixed (uint* __dsl_propertyCountOutput = propertyCountOutput)
            {
                return (Result)EnumerateApiLayerProperties(
                    propertyCapacityInput,
                    __dsl_propertyCountOutput,
                    __dsl_properties
                );
            }
        }

        [NativeName("xrEnumerateBoundSourcesForAction")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateBoundSourcesForAction")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EnumerateBoundSourcesForAction(
            SessionHandle session,
            BoundSourcesForActionEnumerateInfo* enumerateInfo,
            uint sourceCapacityInput,
            uint* sourceCountOutput,
            ulong* sources
        ) =>
            Underlying.Value!.EnumerateBoundSourcesForAction(
                session,
                enumerateInfo,
                sourceCapacityInput,
                sourceCountOutput,
                sources
            );

        [NativeName("xrEnumerateBoundSourcesForAction")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateBoundSourcesForAction")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EnumerateBoundSourcesForAction(
            SessionHandle session,
            Ref<BoundSourcesForActionEnumerateInfo> enumerateInfo,
            uint sourceCapacityInput,
            Ref<uint> sourceCountOutput,
            Ref<ulong> sources
        )
        {
            fixed (ulong* __dsl_sources = sources)
            fixed (uint* __dsl_sourceCountOutput = sourceCountOutput)
            fixed (BoundSourcesForActionEnumerateInfo* __dsl_enumerateInfo = enumerateInfo)
            {
                return (Result)EnumerateBoundSourcesForAction(
                    session,
                    __dsl_enumerateInfo,
                    sourceCapacityInput,
                    __dsl_sourceCountOutput,
                    __dsl_sources
                );
            }
        }

        [NativeName("xrEnumerateEnvironmentBlendModes")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateEnvironmentBlendModes")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EnumerateEnvironmentBlendModes(
            InstanceHandle instance,
            ulong systemId,
            ViewConfigurationType viewConfigurationType,
            uint environmentBlendModeCapacityInput,
            uint* environmentBlendModeCountOutput,
            EnvironmentBlendMode* environmentBlendModes
        ) =>
            Underlying.Value!.EnumerateEnvironmentBlendModes(
                instance,
                systemId,
                viewConfigurationType,
                environmentBlendModeCapacityInput,
                environmentBlendModeCountOutput,
                environmentBlendModes
            );

        [NativeName("xrEnumerateEnvironmentBlendModes")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateEnvironmentBlendModes")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EnumerateEnvironmentBlendModes(
            InstanceHandle instance,
            ulong systemId,
            ViewConfigurationType viewConfigurationType,
            uint environmentBlendModeCapacityInput,
            Ref<uint> environmentBlendModeCountOutput,
            Ref<EnvironmentBlendMode> environmentBlendModes
        )
        {
            fixed (EnvironmentBlendMode* __dsl_environmentBlendModes = environmentBlendModes)
            fixed (uint* __dsl_environmentBlendModeCountOutput = environmentBlendModeCountOutput)
            {
                return (Result)EnumerateEnvironmentBlendModes(
                    instance,
                    systemId,
                    viewConfigurationType,
                    environmentBlendModeCapacityInput,
                    __dsl_environmentBlendModeCountOutput,
                    __dsl_environmentBlendModes
                );
            }
        }

        [NativeName("xrEnumerateInstanceExtensionProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateInstanceExtensionProperties")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EnumerateInstanceExtensionProperties(
            sbyte* layerName,
            uint propertyCapacityInput,
            uint* propertyCountOutput,
            ExtensionProperties* properties
        ) =>
            Underlying.Value!.EnumerateInstanceExtensionProperties(
                layerName,
                propertyCapacityInput,
                propertyCountOutput,
                properties
            );

        [NativeName("xrEnumerateInstanceExtensionProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateInstanceExtensionProperties")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EnumerateInstanceExtensionProperties(
            Ref<sbyte> layerName,
            uint propertyCapacityInput,
            Ref<uint> propertyCountOutput,
            Ref<ExtensionProperties> properties
        )
        {
            fixed (ExtensionProperties* __dsl_properties = properties)
            fixed (uint* __dsl_propertyCountOutput = propertyCountOutput)
            fixed (sbyte* __dsl_layerName = layerName)
            {
                return (Result)EnumerateInstanceExtensionProperties(
                    __dsl_layerName,
                    propertyCapacityInput,
                    __dsl_propertyCountOutput,
                    __dsl_properties
                );
            }
        }

        [NativeName("xrEnumerateReferenceSpaces")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateReferenceSpaces")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EnumerateReferenceSpaces(
            SessionHandle session,
            uint spaceCapacityInput,
            uint* spaceCountOutput,
            ReferenceSpaceType* spaces
        ) =>
            Underlying.Value!.EnumerateReferenceSpaces(
                session,
                spaceCapacityInput,
                spaceCountOutput,
                spaces
            );

        [NativeName("xrEnumerateReferenceSpaces")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateReferenceSpaces")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EnumerateReferenceSpaces(
            SessionHandle session,
            uint spaceCapacityInput,
            Ref<uint> spaceCountOutput,
            Ref<ReferenceSpaceType> spaces
        )
        {
            fixed (ReferenceSpaceType* __dsl_spaces = spaces)
            fixed (uint* __dsl_spaceCountOutput = spaceCountOutput)
            {
                return (Result)EnumerateReferenceSpaces(
                    session,
                    spaceCapacityInput,
                    __dsl_spaceCountOutput,
                    __dsl_spaces
                );
            }
        }

        [NativeName("xrEnumerateSwapchainFormats")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateSwapchainFormats")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EnumerateSwapchainFormats(
            SessionHandle session,
            uint formatCapacityInput,
            uint* formatCountOutput,
            long* formats
        ) =>
            Underlying.Value!.EnumerateSwapchainFormats(
                session,
                formatCapacityInput,
                formatCountOutput,
                formats
            );

        [NativeName("xrEnumerateSwapchainFormats")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateSwapchainFormats")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EnumerateSwapchainFormats(
            SessionHandle session,
            uint formatCapacityInput,
            Ref<uint> formatCountOutput,
            Ref<long> formats
        )
        {
            fixed (long* __dsl_formats = formats)
            fixed (uint* __dsl_formatCountOutput = formatCountOutput)
            {
                return (Result)EnumerateSwapchainFormats(
                    session,
                    formatCapacityInput,
                    __dsl_formatCountOutput,
                    __dsl_formats
                );
            }
        }

        [NativeName("xrEnumerateSwapchainImages")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateSwapchainImages")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EnumerateSwapchainImages(
            SwapchainHandle swapchain,
            uint imageCapacityInput,
            uint* imageCountOutput,
            SwapchainImageBaseHeader* images
        ) =>
            Underlying.Value!.EnumerateSwapchainImages(
                swapchain,
                imageCapacityInput,
                imageCountOutput,
                images
            );

        [NativeName("xrEnumerateSwapchainImages")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateSwapchainImages")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EnumerateSwapchainImages(
            SwapchainHandle swapchain,
            uint imageCapacityInput,
            Ref<uint> imageCountOutput,
            Ref<SwapchainImageBaseHeader> images
        )
        {
            fixed (SwapchainImageBaseHeader* __dsl_images = images)
            fixed (uint* __dsl_imageCountOutput = imageCountOutput)
            {
                return (Result)EnumerateSwapchainImages(
                    swapchain,
                    imageCapacityInput,
                    __dsl_imageCountOutput,
                    __dsl_images
                );
            }
        }

        [NativeName("xrEnumerateViewConfigurations")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateViewConfigurations")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EnumerateViewConfigurations(
            InstanceHandle instance,
            ulong systemId,
            uint viewConfigurationTypeCapacityInput,
            uint* viewConfigurationTypeCountOutput,
            ViewConfigurationType* viewConfigurationTypes
        ) =>
            Underlying.Value!.EnumerateViewConfigurations(
                instance,
                systemId,
                viewConfigurationTypeCapacityInput,
                viewConfigurationTypeCountOutput,
                viewConfigurationTypes
            );

        [NativeName("xrEnumerateViewConfigurations")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateViewConfigurations")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EnumerateViewConfigurations(
            InstanceHandle instance,
            ulong systemId,
            uint viewConfigurationTypeCapacityInput,
            Ref<uint> viewConfigurationTypeCountOutput,
            Ref<ViewConfigurationType> viewConfigurationTypes
        )
        {
            fixed (ViewConfigurationType* __dsl_viewConfigurationTypes = viewConfigurationTypes)
            fixed (uint* __dsl_viewConfigurationTypeCountOutput = viewConfigurationTypeCountOutput)
            {
                return (Result)EnumerateViewConfigurations(
                    instance,
                    systemId,
                    viewConfigurationTypeCapacityInput,
                    __dsl_viewConfigurationTypeCountOutput,
                    __dsl_viewConfigurationTypes
                );
            }
        }

        [NativeName("xrEnumerateViewConfigurationViews")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateViewConfigurationViews")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EnumerateViewConfigurationViews(
            InstanceHandle instance,
            ulong systemId,
            ViewConfigurationType viewConfigurationType,
            uint viewCapacityInput,
            uint* viewCountOutput,
            ViewConfigurationView* views
        ) =>
            Underlying.Value!.EnumerateViewConfigurationViews(
                instance,
                systemId,
                viewConfigurationType,
                viewCapacityInput,
                viewCountOutput,
                views
            );

        [NativeName("xrEnumerateViewConfigurationViews")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateViewConfigurationViews")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result EnumerateViewConfigurationViews(
            InstanceHandle instance,
            ulong systemId,
            ViewConfigurationType viewConfigurationType,
            uint viewCapacityInput,
            Ref<uint> viewCountOutput,
            Ref<ViewConfigurationView> views
        )
        {
            fixed (ViewConfigurationView* __dsl_views = views)
            fixed (uint* __dsl_viewCountOutput = viewCountOutput)
            {
                return (Result)EnumerateViewConfigurationViews(
                    instance,
                    systemId,
                    viewConfigurationType,
                    viewCapacityInput,
                    __dsl_viewCountOutput,
                    __dsl_views
                );
            }
        }

        [NativeName("xrGetActionStateBoolean")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateBoolean")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetActionStateBoolean(
            SessionHandle session,
            ActionStateGetInfo* getInfo,
            ActionStateBoolean* state
        ) => Underlying.Value!.GetActionStateBoolean(session, getInfo, state);

        [NativeName("xrGetActionStateBoolean")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateBoolean")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetActionStateBoolean(
            SessionHandle session,
            Ref<ActionStateGetInfo> getInfo,
            Ref<ActionStateBoolean> state
        )
        {
            fixed (ActionStateBoolean* __dsl_state = state)
            fixed (ActionStateGetInfo* __dsl_getInfo = getInfo)
            {
                return (Result)GetActionStateBoolean(session, __dsl_getInfo, __dsl_state);
            }
        }

        [NativeName("xrGetActionStateFloat")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateFloat")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetActionStateFloat(
            SessionHandle session,
            ActionStateGetInfo* getInfo,
            ActionStateFloat* state
        ) => Underlying.Value!.GetActionStateFloat(session, getInfo, state);

        [NativeName("xrGetActionStateFloat")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateFloat")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetActionStateFloat(
            SessionHandle session,
            Ref<ActionStateGetInfo> getInfo,
            Ref<ActionStateFloat> state
        )
        {
            fixed (ActionStateFloat* __dsl_state = state)
            fixed (ActionStateGetInfo* __dsl_getInfo = getInfo)
            {
                return (Result)GetActionStateFloat(session, __dsl_getInfo, __dsl_state);
            }
        }

        [NativeName("xrGetActionStatePose")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStatePose")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetActionStatePose(
            SessionHandle session,
            ActionStateGetInfo* getInfo,
            ActionStatePose* state
        ) => Underlying.Value!.GetActionStatePose(session, getInfo, state);

        [NativeName("xrGetActionStatePose")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStatePose")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetActionStatePose(
            SessionHandle session,
            Ref<ActionStateGetInfo> getInfo,
            Ref<ActionStatePose> state
        )
        {
            fixed (ActionStatePose* __dsl_state = state)
            fixed (ActionStateGetInfo* __dsl_getInfo = getInfo)
            {
                return (Result)GetActionStatePose(session, __dsl_getInfo, __dsl_state);
            }
        }

        [NativeName("xrGetActionStateVector2f")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateVector2f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetActionStateVector2F(
            SessionHandle session,
            ActionStateGetInfo* getInfo,
            ActionStateVector2F* state
        ) => Underlying.Value!.GetActionStateVector2F(session, getInfo, state);

        [NativeName("xrGetActionStateVector2f")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateVector2f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetActionStateVector2F(
            SessionHandle session,
            Ref<ActionStateGetInfo> getInfo,
            Ref<ActionStateVector2F> state
        )
        {
            fixed (ActionStateVector2F* __dsl_state = state)
            fixed (ActionStateGetInfo* __dsl_getInfo = getInfo)
            {
                return (Result)GetActionStateVector2F(session, __dsl_getInfo, __dsl_state);
            }
        }

        [NativeName("xrGetCurrentInteractionProfile")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetCurrentInteractionProfile")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetCurrentInteractionProfile(
            SessionHandle session,
            ulong topLevelUserPath,
            InteractionProfileState* interactionProfile
        ) =>
            Underlying.Value!.GetCurrentInteractionProfile(
                session,
                topLevelUserPath,
                interactionProfile
            );

        [NativeName("xrGetCurrentInteractionProfile")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetCurrentInteractionProfile")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetCurrentInteractionProfile(
            SessionHandle session,
            ulong topLevelUserPath,
            Ref<InteractionProfileState> interactionProfile
        )
        {
            fixed (InteractionProfileState* __dsl_interactionProfile = interactionProfile)
            {
                return (Result)GetCurrentInteractionProfile(
                    session,
                    topLevelUserPath,
                    __dsl_interactionProfile
                );
            }
        }

        [NativeName("xrGetInputSourceLocalizedName")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetInputSourceLocalizedName")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetInputSourceLocalizedName(
            SessionHandle session,
            InputSourceLocalizedNameGetInfo* getInfo,
            uint bufferCapacityInput,
            uint* bufferCountOutput,
            sbyte* buffer
        ) =>
            Underlying.Value!.GetInputSourceLocalizedName(
                session,
                getInfo,
                bufferCapacityInput,
                bufferCountOutput,
                buffer
            );

        [NativeName("xrGetInputSourceLocalizedName")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetInputSourceLocalizedName")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetInputSourceLocalizedName(
            SessionHandle session,
            Ref<InputSourceLocalizedNameGetInfo> getInfo,
            uint bufferCapacityInput,
            Ref<uint> bufferCountOutput,
            Ref<sbyte> buffer
        )
        {
            fixed (sbyte* __dsl_buffer = buffer)
            fixed (uint* __dsl_bufferCountOutput = bufferCountOutput)
            fixed (InputSourceLocalizedNameGetInfo* __dsl_getInfo = getInfo)
            {
                return (Result)GetInputSourceLocalizedName(
                    session,
                    __dsl_getInfo,
                    bufferCapacityInput,
                    __dsl_bufferCountOutput,
                    __dsl_buffer
                );
            }
        }

        [NativeName("xrGetInstanceProcAddr")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetInstanceProcAddr")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetInstanceProcAddr(
            InstanceHandle instance,
            sbyte* name,
            VoidFunction* function
        ) => Underlying.Value!.GetInstanceProcAddr(instance, name, function);

        [NativeName("xrGetInstanceProcAddr")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetInstanceProcAddr")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetInstanceProcAddr(
            InstanceHandle instance,
            Ref<sbyte> name,
            Ref<VoidFunction> function
        )
        {
            fixed (VoidFunction* __dsl_function = function)
            fixed (sbyte* __dsl_name = name)
            {
                return (Result)GetInstanceProcAddr(instance, __dsl_name, __dsl_function);
            }
        }

        [NativeName("xrGetInstanceProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetInstanceProperties")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetInstanceProperties(
            InstanceHandle instance,
            InstanceProperties* instanceProperties
        ) => Underlying.Value!.GetInstanceProperties(instance, instanceProperties);

        [NativeName("xrGetInstanceProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetInstanceProperties")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetInstanceProperties(
            InstanceHandle instance,
            Ref<InstanceProperties> instanceProperties
        )
        {
            fixed (InstanceProperties* __dsl_instanceProperties = instanceProperties)
            {
                return (Result)GetInstanceProperties(instance, __dsl_instanceProperties);
            }
        }

        [NativeName("xrGetReferenceSpaceBoundsRect")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetReferenceSpaceBoundsRect")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetReferenceSpaceBoundsRect(
            SessionHandle session,
            ReferenceSpaceType referenceSpaceType,
            Extent2Df* bounds
        ) => Underlying.Value!.GetReferenceSpaceBoundsRect(session, referenceSpaceType, bounds);

        [NativeName("xrGetReferenceSpaceBoundsRect")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetReferenceSpaceBoundsRect")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetReferenceSpaceBoundsRect(
            SessionHandle session,
            ReferenceSpaceType referenceSpaceType,
            Ref<Extent2Df> bounds
        )
        {
            fixed (Extent2Df* __dsl_bounds = bounds)
            {
                return (Result)GetReferenceSpaceBoundsRect(
                    session,
                    referenceSpaceType,
                    __dsl_bounds
                );
            }
        }

        [NativeName("xrGetSystem")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetSystem")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetSystem(
            InstanceHandle instance,
            SystemGetInfo* getInfo,
            ulong* systemId
        ) => Underlying.Value!.GetSystem(instance, getInfo, systemId);

        [NativeName("xrGetSystem")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetSystem")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetSystem(
            InstanceHandle instance,
            Ref<SystemGetInfo> getInfo,
            Ref<ulong> systemId
        )
        {
            fixed (ulong* __dsl_systemId = systemId)
            fixed (SystemGetInfo* __dsl_getInfo = getInfo)
            {
                return (Result)GetSystem(instance, __dsl_getInfo, __dsl_systemId);
            }
        }

        [NativeName("xrGetSystemProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetSystemProperties")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetSystemProperties(
            InstanceHandle instance,
            ulong systemId,
            SystemProperties* properties
        ) => Underlying.Value!.GetSystemProperties(instance, systemId, properties);

        [NativeName("xrGetSystemProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetSystemProperties")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetSystemProperties(
            InstanceHandle instance,
            ulong systemId,
            Ref<SystemProperties> properties
        )
        {
            fixed (SystemProperties* __dsl_properties = properties)
            {
                return (Result)GetSystemProperties(instance, systemId, __dsl_properties);
            }
        }

        [NativeName("xrGetViewConfigurationProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetViewConfigurationProperties")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetViewConfigurationProperties(
            InstanceHandle instance,
            ulong systemId,
            ViewConfigurationType viewConfigurationType,
            ViewConfigurationProperties* configurationProperties
        ) =>
            Underlying.Value!.GetViewConfigurationProperties(
                instance,
                systemId,
                viewConfigurationType,
                configurationProperties
            );

        [NativeName("xrGetViewConfigurationProperties")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrGetViewConfigurationProperties")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result GetViewConfigurationProperties(
            InstanceHandle instance,
            ulong systemId,
            ViewConfigurationType viewConfigurationType,
            Ref<ViewConfigurationProperties> configurationProperties
        )
        {
            fixed (
                ViewConfigurationProperties* __dsl_configurationProperties = configurationProperties
            )
            {
                return (Result)GetViewConfigurationProperties(
                    instance,
                    systemId,
                    viewConfigurationType,
                    __dsl_configurationProperties
                );
            }
        }

        [NativeName("xrLocateSpace")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrLocateSpace")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result LocateSpace(
            SpaceHandle space,
            SpaceHandle baseSpace,
            long time,
            SpaceLocation* location
        ) => Underlying.Value!.LocateSpace(space, baseSpace, time, location);

        [NativeName("xrLocateSpace")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrLocateSpace")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result LocateSpace(
            SpaceHandle space,
            SpaceHandle baseSpace,
            long time,
            Ref<SpaceLocation> location
        )
        {
            fixed (SpaceLocation* __dsl_location = location)
            {
                return (Result)LocateSpace(space, baseSpace, time, __dsl_location);
            }
        }

        [NativeName("xrLocateSpaces")]
        [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openxr_loader", EntryPoint = "xrLocateSpaces")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result LocateSpaces(
            SessionHandle session,
            SpacesLocateInfo* locateInfo,
            SpaceLocations* spaceLocations
        ) => Underlying.Value!.LocateSpaces(session, locateInfo, spaceLocations);

        [NativeName("xrLocateSpaces")]
        [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openxr_loader", EntryPoint = "xrLocateSpaces")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result LocateSpaces(
            SessionHandle session,
            Ref<SpacesLocateInfo> locateInfo,
            Ref<SpaceLocations> spaceLocations
        )
        {
            fixed (SpaceLocations* __dsl_spaceLocations = spaceLocations)
            fixed (SpacesLocateInfo* __dsl_locateInfo = locateInfo)
            {
                return (Result)LocateSpaces(session, __dsl_locateInfo, __dsl_spaceLocations);
            }
        }

        [NativeName("xrLocateViews")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrLocateViews")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result LocateViews(
            SessionHandle session,
            ViewLocateInfo* viewLocateInfo,
            ViewState* viewState,
            uint viewCapacityInput,
            uint* viewCountOutput,
            View* views
        ) =>
            Underlying.Value!.LocateViews(
                session,
                viewLocateInfo,
                viewState,
                viewCapacityInput,
                viewCountOutput,
                views
            );

        [NativeName("xrLocateViews")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrLocateViews")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result LocateViews(
            SessionHandle session,
            Ref<ViewLocateInfo> viewLocateInfo,
            Ref<ViewState> viewState,
            uint viewCapacityInput,
            Ref<uint> viewCountOutput,
            Ref<View> views
        )
        {
            fixed (View* __dsl_views = views)
            fixed (uint* __dsl_viewCountOutput = viewCountOutput)
            fixed (ViewState* __dsl_viewState = viewState)
            fixed (ViewLocateInfo* __dsl_viewLocateInfo = viewLocateInfo)
            {
                return (Result)LocateViews(
                    session,
                    __dsl_viewLocateInfo,
                    __dsl_viewState,
                    viewCapacityInput,
                    __dsl_viewCountOutput,
                    __dsl_views
                );
            }
        }

        [NativeName("xrPathToString")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrPathToString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result PathToString(
            InstanceHandle instance,
            ulong path,
            uint bufferCapacityInput,
            uint* bufferCountOutput,
            sbyte* buffer
        ) =>
            Underlying.Value!.PathToString(
                instance,
                path,
                bufferCapacityInput,
                bufferCountOutput,
                buffer
            );

        [NativeName("xrPathToString")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrPathToString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result PathToString(
            InstanceHandle instance,
            ulong path,
            uint bufferCapacityInput,
            Ref<uint> bufferCountOutput,
            Ref<sbyte> buffer
        )
        {
            fixed (sbyte* __dsl_buffer = buffer)
            fixed (uint* __dsl_bufferCountOutput = bufferCountOutput)
            {
                return (Result)PathToString(
                    instance,
                    path,
                    bufferCapacityInput,
                    __dsl_bufferCountOutput,
                    __dsl_buffer
                );
            }
        }

        [NativeName("xrPollEvent")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrPollEvent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result PollEvent(InstanceHandle instance, EventDataBuffer* eventData) =>
            Underlying.Value!.PollEvent(instance, eventData);

        [NativeName("xrPollEvent")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrPollEvent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result PollEvent(InstanceHandle instance, Ref<EventDataBuffer> eventData)
        {
            fixed (EventDataBuffer* __dsl_eventData = eventData)
            {
                return (Result)PollEvent(instance, __dsl_eventData);
            }
        }

        [NativeName("xrReleaseSwapchainImage")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrReleaseSwapchainImage")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result ReleaseSwapchainImage(
            SwapchainHandle swapchain,
            SwapchainImageReleaseInfo* releaseInfo
        ) => Underlying.Value!.ReleaseSwapchainImage(swapchain, releaseInfo);

        [NativeName("xrReleaseSwapchainImage")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrReleaseSwapchainImage")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result ReleaseSwapchainImage(
            SwapchainHandle swapchain,
            Ref<SwapchainImageReleaseInfo> releaseInfo
        )
        {
            fixed (SwapchainImageReleaseInfo* __dsl_releaseInfo = releaseInfo)
            {
                return (Result)ReleaseSwapchainImage(swapchain, __dsl_releaseInfo);
            }
        }

        [NativeName("xrRequestExitSession")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrRequestExitSession")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result RequestExitSession(SessionHandle session) =>
            Underlying.Value!.RequestExitSession(session);

        [NativeName("xrResultToString")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrResultToString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result ResultToString(InstanceHandle instance, Result value, sbyte* buffer) =>
            Underlying.Value!.ResultToString(instance, value, buffer);

        [NativeName("xrResultToString")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrResultToString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result ResultToString(
            InstanceHandle instance,
            Result value,
            Ref<sbyte> buffer
        )
        {
            fixed (sbyte* __dsl_buffer = buffer)
            {
                return (Result)ResultToString(instance, value, __dsl_buffer);
            }
        }

        [NativeName("xrStopHapticFeedback")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrStopHapticFeedback")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result StopHapticFeedback(
            SessionHandle session,
            HapticActionInfo* hapticActionInfo
        ) => Underlying.Value!.StopHapticFeedback(session, hapticActionInfo);

        [NativeName("xrStopHapticFeedback")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrStopHapticFeedback")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result StopHapticFeedback(
            SessionHandle session,
            Ref<HapticActionInfo> hapticActionInfo
        )
        {
            fixed (HapticActionInfo* __dsl_hapticActionInfo = hapticActionInfo)
            {
                return (Result)StopHapticFeedback(session, __dsl_hapticActionInfo);
            }
        }

        [NativeName("xrStringToPath")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrStringToPath")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result StringToPath(
            InstanceHandle instance,
            sbyte* pathString,
            ulong* path
        ) => Underlying.Value!.StringToPath(instance, pathString, path);

        [NativeName("xrStringToPath")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrStringToPath")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result StringToPath(
            InstanceHandle instance,
            Ref<sbyte> pathString,
            Ref<ulong> path
        )
        {
            fixed (ulong* __dsl_path = path)
            fixed (sbyte* __dsl_pathString = pathString)
            {
                return (Result)StringToPath(instance, __dsl_pathString, __dsl_path);
            }
        }

        [NativeName("xrStructureTypeToString")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrStructureTypeToString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result StructureTypeToString(
            InstanceHandle instance,
            StructureType value,
            sbyte* buffer
        ) => Underlying.Value!.StructureTypeToString(instance, value, buffer);

        [NativeName("xrStructureTypeToString")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrStructureTypeToString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result StructureTypeToString(
            InstanceHandle instance,
            StructureType value,
            Ref<sbyte> buffer
        )
        {
            fixed (sbyte* __dsl_buffer = buffer)
            {
                return (Result)StructureTypeToString(instance, value, __dsl_buffer);
            }
        }

        [NativeName("xrSuggestInteractionProfileBindings")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrSuggestInteractionProfileBindings")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result SuggestInteractionProfileBindings(
            InstanceHandle instance,
            InteractionProfileSuggestedBinding* suggestedBindings
        ) => Underlying.Value!.SuggestInteractionProfileBindings(instance, suggestedBindings);

        [NativeName("xrSuggestInteractionProfileBindings")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrSuggestInteractionProfileBindings")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result SuggestInteractionProfileBindings(
            InstanceHandle instance,
            Ref<InteractionProfileSuggestedBinding> suggestedBindings
        )
        {
            fixed (InteractionProfileSuggestedBinding* __dsl_suggestedBindings = suggestedBindings)
            {
                return (Result)SuggestInteractionProfileBindings(instance, __dsl_suggestedBindings);
            }
        }

        [NativeName("xrSyncActions")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrSyncActions")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result SyncActions(SessionHandle session, ActionsSyncInfo* syncInfo) =>
            Underlying.Value!.SyncActions(session, syncInfo);

        [NativeName("xrSyncActions")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrSyncActions")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result SyncActions(SessionHandle session, Ref<ActionsSyncInfo> syncInfo)
        {
            fixed (ActionsSyncInfo* __dsl_syncInfo = syncInfo)
            {
                return (Result)SyncActions(session, __dsl_syncInfo);
            }
        }

        [NativeName("xrWaitFrame")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrWaitFrame")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result WaitFrame(
            SessionHandle session,
            FrameWaitInfo* frameWaitInfo,
            FrameState* frameState
        ) => Underlying.Value!.WaitFrame(session, frameWaitInfo, frameState);

        [NativeName("xrWaitFrame")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrWaitFrame")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result WaitFrame(
            SessionHandle session,
            Ref<FrameWaitInfo> frameWaitInfo,
            Ref<FrameState> frameState
        )
        {
            fixed (FrameState* __dsl_frameState = frameState)
            fixed (FrameWaitInfo* __dsl_frameWaitInfo = frameWaitInfo)
            {
                return (Result)WaitFrame(session, __dsl_frameWaitInfo, __dsl_frameState);
            }
        }

        [NativeName("xrWaitSwapchainImage")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrWaitSwapchainImage")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result WaitSwapchainImage(
            SwapchainHandle swapchain,
            SwapchainImageWaitInfo* waitInfo
        ) => Underlying.Value!.WaitSwapchainImage(swapchain, waitInfo);

        [NativeName("xrWaitSwapchainImage")]
        [SupportedApiProfile(
            "openxr",
            ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
            MinVersion = "1.0"
        )]
        [NativeFunction("openxr_loader", EntryPoint = "xrWaitSwapchainImage")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Result WaitSwapchainImage(
            SwapchainHandle swapchain,
            Ref<SwapchainImageWaitInfo> waitInfo
        )
        {
            fixed (SwapchainImageWaitInfo* __dsl_waitInfo = waitInfo)
            {
                return (Result)WaitSwapchainImage(swapchain, __dsl_waitInfo);
            }
        }
    }

    [NativeName("OPENXR_H_")]
    [SupportedApiProfile("openxr")]
    public const int OpenxrH = 1;

    [NativeName("XR_CURRENT_API_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    public const ulong CurrentApiVersion = (
        (((1) & 0xffffUL) << 48) | (((1) & 0xffffUL) << 32) | ((60) & 0xffffffffUL)
    );

    [NativeName("XR_API_VERSION_1_0")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    public const ulong ApiVersion1x0 = (
        (((1) & 0xffffUL) << 48)
        | (((0) & 0xffffUL) << 32)
        | (
            (
                (uint)(
                    (ulong)(
                        (
                            (((1) & 0xffffUL) << 48)
                            | (((1) & 0xffffUL) << 32)
                            | ((60) & 0xffffffffUL)
                        )
                    ) & 0xffffffffUL
                )
            ) & 0xffffffffUL
        )
    );

    [NativeName("XR_MIN_COMPOSITION_LAYERS_SUPPORTED")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    public const int MinCompositionLayersSupported = 16;

    [NativeName("XR_NULL_SYSTEM_ID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    public const int NullSystemId = 0;

    [NativeName("XR_NULL_PATH")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    public const int NullPath = 0;

    [NativeName("XR_NO_DURATION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    public const int NoDuration = 0;

    [NativeName("XR_INFINITE_DURATION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    public const long InfiniteDuration = 0x7fffffffffffffffL;

    [NativeName("XR_MIN_HAPTIC_DURATION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    public const int MinHapticDuration = -1;

    [NativeName("XR_FREQUENCY_UNSPECIFIED")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    public const int FrequencyUnspecified = 0;

    [NativeName("XR_MAX_EVENT_DATA_SIZE")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    public static ulong MaxEventDataSize => (ulong)sizeof(EventDataBuffer);

    [NativeName("XR_EXTENSION_ENUM_BASE")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    public const int ExtensionEnumBase = 1000000000;

    [NativeName("XR_EXTENSION_ENUM_STRIDE")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    public const int ExtensionEnumStride = 1000;

    [NativeName("XR_API_VERSION_1_1")]
    [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
    public const ulong ApiVersion1x1 = (
        (((1) & 0xffffUL) << 48)
        | (((1) & 0xffffUL) << 32)
        | (
            (
                (uint)(
                    (ulong)(
                        (
                            (((1) & 0xffffUL) << 48)
                            | (((1) & 0xffffUL) << 32)
                            | ((60) & 0xffffffffUL)
                        )
                    ) & 0xffffffffUL
                )
            ) & 0xffffffffUL
        )
    );

    [NativeName("XR_KHR_composition_layer_cube_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_cube"])]
    public const int KhrCompositionLayerCubeSpecVersion = 8;

    [NativeName("XR_KHR_COMPOSITION_LAYER_CUBE_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_cube"])]
    public static Utf8String KhrCompositionLayerCubeExtensionName =>
        "XR_KHR_composition_layer_cube"u8;

    [NativeName("XR_KHR_composition_layer_depth_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_depth"])]
    public const int KhrCompositionLayerDepthSpecVersion = 6;

    [NativeName("XR_KHR_COMPOSITION_LAYER_DEPTH_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_depth"])]
    public static Utf8String KhrCompositionLayerDepthExtensionName =>
        "XR_KHR_composition_layer_depth"u8;

    [NativeName("XR_KHR_composition_layer_cylinder_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_cylinder"])]
    public const int KhrCompositionLayerCylinderSpecVersion = 4;

    [NativeName("XR_KHR_COMPOSITION_LAYER_CYLINDER_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_cylinder"])]
    public static Utf8String KhrCompositionLayerCylinderExtensionName =>
        "XR_KHR_composition_layer_cylinder"u8;

    [NativeName("XR_KHR_composition_layer_equirect_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect"])]
    public const int KhrCompositionLayerEquirectSpecVersion = 3;

    [NativeName("XR_KHR_COMPOSITION_LAYER_EQUIRECT_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect"])]
    public static Utf8String KhrCompositionLayerEquirectExtensionName =>
        "XR_KHR_composition_layer_equirect"u8;

    [NativeName("XR_KHR_visibility_mask_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_KHR_visibility_mask"])]
    public const int KhrVisibilityMaskSpecVersion = 2;

    [NativeName("XR_KHR_VISIBILITY_MASK_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_KHR_visibility_mask"])]
    public static Utf8String KhrVisibilityMaskExtensionName => "XR_KHR_visibility_mask"u8;

    [NativeName("XR_KHR_composition_layer_color_scale_bias_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_color_scale_bias"])]
    public const int KhrCompositionLayerColorScaleBiasSpecVersion = 5;

    [NativeName("XR_KHR_COMPOSITION_LAYER_COLOR_SCALE_BIAS_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_color_scale_bias"])]
    public static Utf8String KhrCompositionLayerColorScaleBiasExtensionName =>
        "XR_KHR_composition_layer_color_scale_bias"u8;

    [NativeName("XR_KHR_loader_init_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_KHR_loader_init"])]
    public const int KhrLoaderInitSpecVersion = 2;

    [NativeName("XR_KHR_LOADER_INIT_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_KHR_loader_init"])]
    public static Utf8String KhrLoaderInitExtensionName => "XR_KHR_loader_init"u8;

    [NativeName("XR_KHR_composition_layer_equirect2_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect2"])]
    public const int KhrCompositionLayerEquirect2SpecVersion = 1;

    [NativeName("XR_KHR_COMPOSITION_LAYER_EQUIRECT2_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect2"])]
    public static Utf8String KhrCompositionLayerEquirect2ExtensionName =>
        "XR_KHR_composition_layer_equirect2"u8;

    [NativeName("XR_KHR_binding_modification_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_KHR_binding_modification"])]
    public const int KhrBindingModificationSpecVersion = 1;

    [NativeName("XR_KHR_BINDING_MODIFICATION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_KHR_binding_modification"])]
    public static Utf8String KhrBindingModificationExtensionName => "XR_KHR_binding_modification"u8;

    [NativeName("XR_KHR_extended_struct_name_lengths_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_KHR_extended_struct_name_lengths"])]
    public const int KhrExtendedStructNameLengthsSpecVersion = 2;

    [NativeName("XR_KHR_EXTENDED_STRUCT_NAME_LENGTHS_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_KHR_extended_struct_name_lengths"])]
    public static Utf8String KhrExtendedStructNameLengthsExtensionName =>
        "XR_KHR_extended_struct_name_lengths"u8;

    [NativeName("XR_MAX_STRUCTURE_NAME_SIZE_EXTENDED_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_extended_struct_name_lengths"])]
    public const int MaxStructureNameSizeExtendedKHR = 256;

    [NativeName("XR_KHR_swapchain_usage_input_attachment_bit_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_KHR_swapchain_usage_input_attachment_bit"])]
    public const int KhrSwapchainUsageInputAttachmentBitSpecVersion = 3;

    [NativeName("XR_KHR_SWAPCHAIN_USAGE_INPUT_ATTACHMENT_BIT_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_KHR_swapchain_usage_input_attachment_bit"])]
    public static Utf8String KhrSwapchainUsageInputAttachmentBitExtensionName =>
        "XR_KHR_swapchain_usage_input_attachment_bit"u8;

    [NativeName("XR_KHR_locate_spaces_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_KHR_locate_spaces"])]
    public const int KhrLocateSpacesSpecVersion = 1;

    [NativeName("XR_KHR_LOCATE_SPACES_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_KHR_locate_spaces"])]
    public static Utf8String KhrLocateSpacesExtensionName => "XR_KHR_locate_spaces"u8;

    [NativeName("XR_KHR_maintenance1_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_KHR_maintenance1"])]
    public const int KhrMaintenance1SpecVersion = 1;

    [NativeName("XR_KHR_MAINTENANCE1_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_KHR_maintenance1"])]
    public static Utf8String KhrMaintenance1ExtensionName => "XR_KHR_maintenance1"u8;

    [NativeName("XR_KHR_generic_controller_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_KHR_generic_controller"])]
    public const int KhrGenericControllerSpecVersion = 1;

    [NativeName("XR_KHR_GENERIC_CONTROLLER_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_KHR_generic_controller"])]
    public static Utf8String KhrGenericControllerExtensionName => "XR_KHR_generic_controller"u8;

    [NativeName("XR_EXT_performance_settings_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_EXT_performance_settings"])]
    public const int ExtPerformanceSettingsSpecVersion = 4;

    [NativeName("XR_EXT_PERFORMANCE_SETTINGS_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_EXT_performance_settings"])]
    public static Utf8String ExtPerformanceSettingsExtensionName => "XR_EXT_performance_settings"u8;

    [NativeName("XR_EXT_thermal_query_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_EXT_thermal_query"])]
    public const int ExtThermalQuerySpecVersion = 2;

    [NativeName("XR_EXT_THERMAL_QUERY_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_EXT_thermal_query"])]
    public static Utf8String ExtThermalQueryExtensionName => "XR_EXT_thermal_query"u8;

    [NativeName("XR_EXT_debug_utils_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public const int ExtDebugUtilsSpecVersion = 5;

    [NativeName("XR_EXT_DEBUG_UTILS_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public static Utf8String ExtDebugUtilsExtensionName => "XR_EXT_debug_utils"u8;

    [NativeName("XR_EXT_eye_gaze_interaction_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_EXT_eye_gaze_interaction"])]
    public const int ExtEyeGazeInteractionSpecVersion = 2;

    [NativeName("XR_EXT_EYE_GAZE_INTERACTION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_EXT_eye_gaze_interaction"])]
    public static Utf8String ExtEyeGazeInteractionExtensionName => "XR_EXT_eye_gaze_interaction"u8;

    [NativeName("XR_EXTX_overlay_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_EXTX_overlay"])]
    public const int ExtxOverlaySpecVersion = 5;

    [NativeName("XR_EXTX_OVERLAY_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_EXTX_overlay"])]
    public static Utf8String ExtxOverlayExtensionName => "XR_EXTX_overlay"u8;

    [NativeName("XR_VARJO_quad_views_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_VARJO_quad_views"])]
    public const int VarjoQuadViewsSpecVersion = 2;

    [NativeName("XR_VARJO_QUAD_VIEWS_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_VARJO_quad_views"])]
    public static Utf8String VarjoQuadViewsExtensionName => "XR_VARJO_quad_views"u8;

    [NativeName("XR_MSFT_unbounded_reference_space_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_MSFT_unbounded_reference_space"])]
    public const int MsftUnboundedReferenceSpaceSpecVersion = 1;

    [NativeName("XR_MSFT_UNBOUNDED_REFERENCE_SPACE_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_MSFT_unbounded_reference_space"])]
    public static Utf8String MsftUnboundedReferenceSpaceExtensionName =>
        "XR_MSFT_unbounded_reference_space"u8;

    [NativeName("XR_MSFT_spatial_anchor_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_anchor"])]
    public const int MsftSpatialAnchorSpecVersion = 2;

    [NativeName("XR_MSFT_SPATIAL_ANCHOR_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_anchor"])]
    public static Utf8String MsftSpatialAnchorExtensionName => "XR_MSFT_spatial_anchor"u8;

    [NativeName("XR_FB_composition_layer_image_layout_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_image_layout"])]
    public const int FBCompositionLayerImageLayoutSpecVersion = 1;

    [NativeName("XR_FB_COMPOSITION_LAYER_IMAGE_LAYOUT_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_image_layout"])]
    public static Utf8String FbCompositionLayerImageLayoutExtensionName =>
        "XR_FB_composition_layer_image_layout"u8;

    [NativeName("XR_FB_composition_layer_alpha_blend_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_alpha_blend"])]
    public const int FBCompositionLayerAlphaBlendSpecVersion = 3;

    [NativeName("XR_FB_COMPOSITION_LAYER_ALPHA_BLEND_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_alpha_blend"])]
    public static Utf8String FbCompositionLayerAlphaBlendExtensionName =>
        "XR_FB_composition_layer_alpha_blend"u8;

    [NativeName("XR_MND_headless_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_MND_headless"])]
    public const int MndHeadlessSpecVersion = 3;

    [NativeName("XR_MND_HEADLESS_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_MND_headless"])]
    public static Utf8String MndHeadlessExtensionName => "XR_MND_headless"u8;

    [NativeName("XR_OCULUS_android_session_state_enable_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_OCULUS_android_session_state_enable"])]
    public const int OculusAndroidSessionStateEnableSpecVersion = 1;

    [NativeName("XR_OCULUS_ANDROID_SESSION_STATE_ENABLE_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_OCULUS_android_session_state_enable"])]
    public static Utf8String OculusAndroidSessionStateEnableExtensionName =>
        "XR_OCULUS_android_session_state_enable"u8;

    [NativeName("XR_EXT_view_configuration_depth_range_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_EXT_view_configuration_depth_range"])]
    public const int ExtViewConfigurationDepthRangeSpecVersion = 1;

    [NativeName("XR_EXT_VIEW_CONFIGURATION_DEPTH_RANGE_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_EXT_view_configuration_depth_range"])]
    public static Utf8String ExtViewConfigurationDepthRangeExtensionName =>
        "XR_EXT_view_configuration_depth_range"u8;

    [NativeName("XR_EXT_conformance_automation_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_EXT_conformance_automation"])]
    public const int ExtConformanceAutomationSpecVersion = 3;

    [NativeName("XR_EXT_CONFORMANCE_AUTOMATION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_EXT_conformance_automation"])]
    public static Utf8String ExtConformanceAutomationExtensionName =>
        "XR_EXT_conformance_automation"u8;

    [NativeName("XR_GUID_SIZE_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    public const int GuidSizeMSFT = 16;

    [NativeName("XR_MSFT_spatial_graph_bridge_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    public const int MsftSpatialGraphBridgeSpecVersion = 2;

    [NativeName("XR_MSFT_SPATIAL_GRAPH_BRIDGE_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    public static Utf8String MsftSpatialGraphBridgeExtensionName =>
        "XR_MSFT_spatial_graph_bridge"u8;

    [NativeName("XR_MSFT_hand_interaction_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_MSFT_hand_interaction"])]
    public const int MsftHandInteractionSpecVersion = 1;

    [NativeName("XR_MSFT_HAND_INTERACTION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_MSFT_hand_interaction"])]
    public static Utf8String MsftHandInteractionExtensionName => "XR_MSFT_hand_interaction"u8;

    [NativeName("XR_HAND_JOINT_COUNT_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    public const int HandJointCountEXT = 26;

    [NativeName("XR_EXT_hand_tracking_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    public const int ExtHandTrackingSpecVersion = 4;

    [NativeName("XR_EXT_HAND_TRACKING_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    public static Utf8String ExtHandTrackingExtensionName => "XR_EXT_hand_tracking"u8;

    [NativeName("XR_MSFT_hand_tracking_mesh_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public const int MsftHandTrackingMeshSpecVersion = 4;

    [NativeName("XR_MSFT_HAND_TRACKING_MESH_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public static Utf8String MsftHandTrackingMeshExtensionName => "XR_MSFT_hand_tracking_mesh"u8;

    [NativeName("XR_MSFT_secondary_view_configuration_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_MSFT_secondary_view_configuration"])]
    public const int MsftSecondaryViewConfigurationSpecVersion = 1;

    [NativeName("XR_MSFT_SECONDARY_VIEW_CONFIGURATION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_MSFT_secondary_view_configuration"])]
    public static Utf8String MsftSecondaryViewConfigurationExtensionName =>
        "XR_MSFT_secondary_view_configuration"u8;

    [NativeName("XR_MSFT_first_person_observer_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_first_person_observer"],
        ImpliesSets = ["XR_MSFT_secondary_view_configuration", "XR_VERSION_1_0"]
    )]
    public const int MsftFirstPersonObserverSpecVersion = 1;

    [NativeName("XR_MSFT_FIRST_PERSON_OBSERVER_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_first_person_observer"],
        ImpliesSets = ["XR_MSFT_secondary_view_configuration", "XR_VERSION_1_0"]
    )]
    public static Utf8String MsftFirstPersonObserverExtensionName =>
        "XR_MSFT_first_person_observer"u8;

    [NativeName("XR_NULL_CONTROLLER_MODEL_KEY_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_controller_model"])]
    public const int NullControllerModelKeyMSFT = 0;

    [NativeName("XR_MAX_CONTROLLER_MODEL_NODE_NAME_SIZE_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_controller_model"])]
    public const int MaxControllerModelNodeNameSizeMSFT = 64;

    [NativeName("XR_MSFT_controller_model_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_MSFT_controller_model"])]
    public const int MsftControllerModelSpecVersion = 2;

    [NativeName("XR_MSFT_CONTROLLER_MODEL_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_MSFT_controller_model"])]
    public static Utf8String MsftControllerModelExtensionName => "XR_MSFT_controller_model"u8;

    [NativeName("XR_EXT_win32_appcontainer_compatible_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_EXT_win32_appcontainer_compatible"])]
    public const int ExtWin32AppcontainerCompatibleSpecVersion = 1;

    [NativeName("XR_EXT_WIN32_APPCONTAINER_COMPATIBLE_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_EXT_win32_appcontainer_compatible"])]
    public static Utf8String ExtWin32AppcontainerCompatibleExtensionName =>
        "XR_EXT_win32_appcontainer_compatible"u8;

    [NativeName("XR_EPIC_view_configuration_fov_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_EPIC_view_configuration_fov"])]
    public const int EpicViewConfigurationFovSpecVersion = 2;

    [NativeName("XR_EPIC_VIEW_CONFIGURATION_FOV_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_EPIC_view_configuration_fov"])]
    public static Utf8String EpicViewConfigurationFovExtensionName =>
        "XR_EPIC_view_configuration_fov"u8;

    [NativeName("XR_MSFT_composition_layer_reprojection_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_MSFT_composition_layer_reprojection"])]
    public const int MsftCompositionLayerReprojectionSpecVersion = 1;

    [NativeName("XR_MSFT_COMPOSITION_LAYER_REPROJECTION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_MSFT_composition_layer_reprojection"])]
    public static Utf8String MsftCompositionLayerReprojectionExtensionName =>
        "XR_MSFT_composition_layer_reprojection"u8;

    [NativeName("XR_HUAWEI_controller_interaction_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_HUAWEI_controller_interaction"])]
    public const int HuaweiControllerInteractionSpecVersion = 1;

    [NativeName("XR_HUAWEI_CONTROLLER_INTERACTION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_HUAWEI_controller_interaction"])]
    public static Utf8String HuaweiControllerInteractionExtensionName =>
        "XR_HUAWEI_controller_interaction"u8;

    [NativeName("XR_FB_swapchain_update_state_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_FB_swapchain_update_state"])]
    public const int FBSwapchainUpdateStateSpecVersion = 3;

    [NativeName("XR_FB_SWAPCHAIN_UPDATE_STATE_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_FB_swapchain_update_state"])]
    public static Utf8String FbSwapchainUpdateStateExtensionName =>
        "XR_FB_swapchain_update_state"u8;

    [NativeName("XR_FB_composition_layer_secure_content_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_secure_content"])]
    public const int FBCompositionLayerSecureContentSpecVersion = 1;

    [NativeName("XR_FB_COMPOSITION_LAYER_SECURE_CONTENT_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_secure_content"])]
    public static Utf8String FbCompositionLayerSecureContentExtensionName =>
        "XR_FB_composition_layer_secure_content"u8;

    [NativeName("XR_FB_body_tracking_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    public const int FBBodyTrackingSpecVersion = 1;

    [NativeName("XR_FB_BODY_TRACKING_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    public static Utf8String FbBodyTrackingExtensionName => "XR_FB_body_tracking"u8;

    [NativeName("XR_EXT_dpad_binding_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_dpad_binding"],
        ImpliesSets = ["XR_KHR_binding_modification", "XR_VERSION_1_0"]
    )]
    public const int ExtDpadBindingSpecVersion = 1;

    [NativeName("XR_EXT_DPAD_BINDING_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_dpad_binding"],
        ImpliesSets = ["XR_KHR_binding_modification", "XR_VERSION_1_0"]
    )]
    public static Utf8String ExtDpadBindingExtensionName => "XR_EXT_dpad_binding"u8;

    [NativeName("XR_VALVE_analog_threshold_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_VALVE_analog_threshold"])]
    public const int ValveAnalogThresholdSpecVersion = 2;

    [NativeName("XR_VALVE_ANALOG_THRESHOLD_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_VALVE_analog_threshold"])]
    public static Utf8String ValveAnalogThresholdExtensionName => "XR_VALVE_analog_threshold"u8;

    [NativeName("XR_EXT_hand_joints_motion_range_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_hand_joints_motion_range"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public const int ExtHandJointsMotionRangeSpecVersion = 1;

    [NativeName("XR_EXT_HAND_JOINTS_MOTION_RANGE_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_hand_joints_motion_range"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public static Utf8String ExtHandJointsMotionRangeExtensionName =>
        "XR_EXT_hand_joints_motion_range"u8;

    [NativeName("XR_EXT_samsung_odyssey_controller_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_EXT_samsung_odyssey_controller"])]
    public const int ExtSamsungOdysseyControllerSpecVersion = 1;

    [NativeName("XR_EXT_SAMSUNG_ODYSSEY_CONTROLLER_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_EXT_samsung_odyssey_controller"])]
    public static Utf8String ExtSamsungOdysseyControllerExtensionName =>
        "XR_EXT_samsung_odyssey_controller"u8;

    [NativeName("XR_EXT_hp_mixed_reality_controller_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_EXT_hp_mixed_reality_controller"])]
    public const int ExtHpMixedRealityControllerSpecVersion = 1;

    [NativeName("XR_EXT_HP_MIXED_REALITY_CONTROLLER_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_EXT_hp_mixed_reality_controller"])]
    public static Utf8String ExtHpMixedRealityControllerExtensionName =>
        "XR_EXT_hp_mixed_reality_controller"u8;

    [NativeName("XR_MND_swapchain_usage_input_attachment_bit_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_MND_swapchain_usage_input_attachment_bit"])]
    public const int MndSwapchainUsageInputAttachmentBitSpecVersion = 2;

    [NativeName("XR_MND_SWAPCHAIN_USAGE_INPUT_ATTACHMENT_BIT_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_MND_swapchain_usage_input_attachment_bit"])]
    public static Utf8String MndSwapchainUsageInputAttachmentBitExtensionName =>
        "XR_MND_swapchain_usage_input_attachment_bit"u8;

    [NativeName("XR_MSFT_scene_understanding_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public const int MsftSceneUnderstandingSpecVersion = 2;

    [NativeName("XR_MSFT_SCENE_UNDERSTANDING_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public static Utf8String MsftSceneUnderstandingExtensionName => "XR_MSFT_scene_understanding"u8;

    [NativeName("XR_MSFT_scene_understanding_serialization_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_scene_understanding_serialization"],
        ImpliesSets = ["XR_MSFT_scene_understanding", "XR_VERSION_1_0"]
    )]
    public const int MsftSceneUnderstandingSerializationSpecVersion = 2;

    [NativeName("XR_MSFT_SCENE_UNDERSTANDING_SERIALIZATION_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_scene_understanding_serialization"],
        ImpliesSets = ["XR_MSFT_scene_understanding", "XR_VERSION_1_0"]
    )]
    public static Utf8String MsftSceneUnderstandingSerializationExtensionName =>
        "XR_MSFT_scene_understanding_serialization"u8;

    [NativeName("XR_FB_display_refresh_rate_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_FB_display_refresh_rate"])]
    public const int FBDisplayRefreshRateSpecVersion = 1;

    [NativeName("XR_FB_DISPLAY_REFRESH_RATE_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_FB_display_refresh_rate"])]
    public static Utf8String FbDisplayRefreshRateExtensionName => "XR_FB_display_refresh_rate"u8;

    [NativeName("XR_HTC_vive_cosmos_controller_interaction_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_HTC_vive_cosmos_controller_interaction"])]
    public const int HtcViveCosmosControllerInteractionSpecVersion = 1;

    [NativeName("XR_HTC_VIVE_COSMOS_CONTROLLER_INTERACTION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_HTC_vive_cosmos_controller_interaction"])]
    public static Utf8String HtcViveCosmosControllerInteractionExtensionName =>
        "XR_HTC_vive_cosmos_controller_interaction"u8;

    [NativeName("XR_HTCX_vive_tracker_interaction_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_HTCX_vive_tracker_interaction"])]
    public const int HtcxViveTrackerInteractionSpecVersion = 3;

    [NativeName("XR_HTCX_VIVE_TRACKER_INTERACTION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_HTCX_vive_tracker_interaction"])]
    public static Utf8String HtcxViveTrackerInteractionExtensionName =>
        "XR_HTCX_vive_tracker_interaction"u8;

    [NativeName("XR_FACIAL_EXPRESSION_EYE_COUNT_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    public const int FacialExpressionEyeCountHTC = 14;

    [NativeName("XR_FACIAL_EXPRESSION_LIP_COUNT_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    public const int FacialExpressionLipCountHTC = 37;

    [NativeName("XR_HTC_facial_tracking_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    public const int HtcFacialTrackingSpecVersion = 3;

    [NativeName("XR_HTC_FACIAL_TRACKING_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    public static Utf8String HtcFacialTrackingExtensionName => "XR_HTC_facial_tracking"u8;

    [NativeName("XR_HTC_vive_focus3_controller_interaction_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_HTC_vive_focus3_controller_interaction"])]
    public const int HtcViveFocus3ControllerInteractionSpecVersion = 2;

    [NativeName("XR_HTC_VIVE_FOCUS3_CONTROLLER_INTERACTION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_HTC_vive_focus3_controller_interaction"])]
    public static Utf8String HtcViveFocus3ControllerInteractionExtensionName =>
        "XR_HTC_vive_focus3_controller_interaction"u8;

    [NativeName("XR_HTC_hand_interaction_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_HTC_hand_interaction"])]
    public const int HtcHandInteractionSpecVersion = 1;

    [NativeName("XR_HTC_HAND_INTERACTION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_HTC_hand_interaction"])]
    public static Utf8String HtcHandInteractionExtensionName => "XR_HTC_hand_interaction"u8;

    [NativeName("XR_HTC_vive_wrist_tracker_interaction_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_HTC_vive_wrist_tracker_interaction"])]
    public const int HtcViveWristTrackerInteractionSpecVersion = 1;

    [NativeName("XR_HTC_VIVE_WRIST_TRACKER_INTERACTION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_HTC_vive_wrist_tracker_interaction"])]
    public static Utf8String HtcViveWristTrackerInteractionExtensionName =>
        "XR_HTC_vive_wrist_tracker_interaction"u8;

    [NativeName("XR_FB_color_space_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_FB_color_space"])]
    public const int FBColorSpaceSpecVersion = 3;

    [NativeName("XR_FB_COLOR_SPACE_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_FB_color_space"])]
    public static Utf8String FbColorSpaceExtensionName => "XR_FB_color_space"u8;

    [NativeName("XR_FB_hand_tracking_mesh_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public const int FBHandTrackingMeshSpecVersion = 3;

    [NativeName("XR_FB_HAND_TRACKING_MESH_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public static Utf8String FbHandTrackingMeshExtensionName => "XR_FB_hand_tracking_mesh"u8;

    [NativeName("XR_FB_hand_tracking_aim_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_aim"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public const int FBHandTrackingAimSpecVersion = 2;

    [NativeName("XR_FB_HAND_TRACKING_AIM_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_aim"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public static Utf8String FbHandTrackingAimExtensionName => "XR_FB_hand_tracking_aim"u8;

    [NativeName("XR_HAND_TRACKING_CAPSULE_POINT_COUNT_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_capsules"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public const int HandTrackingCapsulePointCountFB = 2;

    [NativeName("XR_HAND_TRACKING_CAPSULE_COUNT_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_capsules"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public const int HandTrackingCapsuleCountFB = 19;

    [NativeName("XR_FB_hand_tracking_capsules_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_capsules"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public const int FBHandTrackingCapsulesSpecVersion = 3;

    [NativeName("XR_FB_HAND_TRACKING_CAPSULES_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_capsules"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public static Utf8String FbHandTrackingCapsulesExtensionName =>
        "XR_FB_hand_tracking_capsules"u8;

    [NativeName("XR_FB_HAND_TRACKING_CAPSULE_POINT_COUNT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_capsules"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public const int FbHandTrackingCapsulePointCount = 2;

    [NativeName("XR_FB_HAND_TRACKING_CAPSULE_COUNT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_capsules"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public const int FbHandTrackingCapsuleCount = 19;

    [NativeName("XR_FB_spatial_entity_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    public const int FBSpatialEntitySpecVersion = 3;

    [NativeName("XR_FB_SPATIAL_ENTITY_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    public static Utf8String FbSpatialEntityExtensionName => "XR_FB_spatial_entity"u8;

    [NativeName("XR_FB_foveation_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_VERSION_1_0"]
    )]
    public const int FBFoveationSpecVersion = 1;

    [NativeName("XR_FB_FOVEATION_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation"],
        ImpliesSets = ["XR_FB_swapchain_update_state", "XR_VERSION_1_0"]
    )]
    public static Utf8String FbFoveationExtensionName => "XR_FB_foveation"u8;

    [NativeName("XR_FB_foveation_configuration_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation_configuration"],
        ImpliesSets = ["XR_FB_foveation", "XR_VERSION_1_0"]
    )]
    public const int FBFoveationConfigurationSpecVersion = 1;

    [NativeName("XR_FB_FOVEATION_CONFIGURATION_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation_configuration"],
        ImpliesSets = ["XR_FB_foveation", "XR_VERSION_1_0"]
    )]
    public static Utf8String FbFoveationConfigurationExtensionName =>
        "XR_FB_foveation_configuration"u8;

    [NativeName("XR_MAX_KEYBOARD_TRACKING_NAME_SIZE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_keyboard_tracking"])]
    public const int MaxKeyboardTrackingNameSizeFB = 128;

    [NativeName("XR_FB_keyboard_tracking_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_FB_keyboard_tracking"])]
    public const int FBKeyboardTrackingSpecVersion = 1;

    [NativeName("XR_FB_KEYBOARD_TRACKING_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_FB_keyboard_tracking"])]
    public static Utf8String FbKeyboardTrackingExtensionName => "XR_FB_keyboard_tracking"u8;

    [NativeName("XR_FB_triangle_mesh_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_FB_triangle_mesh"])]
    public const int FBTriangleMeshSpecVersion = 2;

    [NativeName("XR_FB_TRIANGLE_MESH_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_FB_triangle_mesh"])]
    public static Utf8String FbTriangleMeshExtensionName => "XR_FB_triangle_mesh"u8;

    [NativeName("XR_PASSTHROUGH_COLOR_MAP_MONO_SIZE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    public const int PassthroughColorMapMonoSizeFB = 256;

    [NativeName("XR_FB_passthrough_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    public const int FBPassthroughSpecVersion = 5;

    [NativeName("XR_FB_PASSTHROUGH_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    public static Utf8String FbPassthroughExtensionName => "XR_FB_passthrough"u8;

    [NativeName("XR_NULL_RENDER_MODEL_KEY_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_render_model"])]
    public const int NullRenderModelKeyFB = 0;

    [NativeName("XR_MAX_RENDER_MODEL_NAME_SIZE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_render_model"])]
    public const int MaxRenderModelNameSizeFB = 64;

    [NativeName("XR_FB_render_model_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_FB_render_model"])]
    public const int FBRenderModelSpecVersion = 4;

    [NativeName("XR_FB_RENDER_MODEL_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_FB_render_model"])]
    public static Utf8String FbRenderModelExtensionName => "XR_FB_render_model"u8;

    [NativeName("XR_VARJO_foveated_rendering_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_VARJO_foveated_rendering"],
        ImpliesSets = ["XR_VARJO_quad_views", "XR_VERSION_1_0"]
    )]
    public const int VarjoFoveatedRenderingSpecVersion = 3;

    [NativeName("XR_VARJO_FOVEATED_RENDERING_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_VARJO_foveated_rendering"],
        ImpliesSets = ["XR_VARJO_quad_views", "XR_VERSION_1_0"]
    )]
    public static Utf8String VarjoFoveatedRenderingExtensionName => "XR_VARJO_foveated_rendering"u8;

    [NativeName("XR_VARJO_composition_layer_depth_test_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_VARJO_composition_layer_depth_test"],
        ImpliesSets = ["XR_KHR_composition_layer_depth", "XR_VERSION_1_0"]
    )]
    public const int VarjoCompositionLayerDepthTestSpecVersion = 2;

    [NativeName("XR_VARJO_COMPOSITION_LAYER_DEPTH_TEST_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_VARJO_composition_layer_depth_test"],
        ImpliesSets = ["XR_KHR_composition_layer_depth", "XR_VERSION_1_0"]
    )]
    public static Utf8String VarjoCompositionLayerDepthTestExtensionName =>
        "XR_VARJO_composition_layer_depth_test"u8;

    [NativeName("XR_VARJO_environment_depth_estimation_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_VARJO_environment_depth_estimation"])]
    public const int VarjoEnvironmentDepthEstimationSpecVersion = 1;

    [NativeName("XR_VARJO_ENVIRONMENT_DEPTH_ESTIMATION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_VARJO_environment_depth_estimation"])]
    public static Utf8String VarjoEnvironmentDepthEstimationExtensionName =>
        "XR_VARJO_environment_depth_estimation"u8;

    [NativeName("XR_VARJO_marker_tracking_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_VARJO_marker_tracking"])]
    public const int VarjoMarkerTrackingSpecVersion = 1;

    [NativeName("XR_VARJO_MARKER_TRACKING_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_VARJO_marker_tracking"])]
    public static Utf8String VarjoMarkerTrackingExtensionName => "XR_VARJO_marker_tracking"u8;

    [NativeName("XR_VARJO_view_offset_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_VARJO_view_offset"])]
    public const int VarjoViewOffsetSpecVersion = 1;

    [NativeName("XR_VARJO_VIEW_OFFSET_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_VARJO_view_offset"])]
    public static Utf8String VarjoViewOffsetExtensionName => "XR_VARJO_view_offset"u8;

    [NativeName("XR_VARJO_xr4_controller_interaction_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_VARJO_xr4_controller_interaction"])]
    public const int VarjoXr4ControllerInteractionSpecVersion = 2;

    [NativeName("XR_VARJO_XR4_CONTROLLER_INTERACTION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_VARJO_xr4_controller_interaction"])]
    public static Utf8String VarjoXr4ControllerInteractionExtensionName =>
        "XR_VARJO_xr4_controller_interaction"u8;

    [NativeName("XR_ML_ml2_controller_interaction_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_ML_ml2_controller_interaction"])]
    public const int MLMl2ControllerInteractionSpecVersion = 1;

    [NativeName("XR_ML_ML2_CONTROLLER_INTERACTION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_ML_ml2_controller_interaction"])]
    public static Utf8String MlMl2ControllerInteractionExtensionName =>
        "XR_ML_ml2_controller_interaction"u8;

    [NativeName("XR_ML_frame_end_info_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_ML_frame_end_info"])]
    public const int MLFrameEndInfoSpecVersion = 1;

    [NativeName("XR_ML_FRAME_END_INFO_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_ML_frame_end_info"])]
    public static Utf8String MlFrameEndInfoExtensionName => "XR_ML_frame_end_info"u8;

    [NativeName("XR_ML_global_dimmer_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_ML_global_dimmer"])]
    public const int MLGlobalDimmerSpecVersion = 1;

    [NativeName("XR_ML_GLOBAL_DIMMER_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_ML_global_dimmer"])]
    public static Utf8String MlGlobalDimmerExtensionName => "XR_ML_global_dimmer"u8;

    [NativeName("XR_ML_marker_understanding_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    public const int MLMarkerUnderstandingSpecVersion = 1;

    [NativeName("XR_ML_MARKER_UNDERSTANDING_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    public static Utf8String MlMarkerUnderstandingExtensionName => "XR_ML_marker_understanding"u8;

    [NativeName("XR_MAX_LOCALIZATION_MAP_NAME_LENGTH_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_localization_map"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    public const int MaxLocalizationMapNameLengthML = 64;

    [NativeName("XR_ML_localization_map_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_localization_map"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    public const int MLLocalizationMapSpecVersion = 1;

    [NativeName("XR_ML_LOCALIZATION_MAP_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_localization_map"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    public static Utf8String MlLocalizationMapExtensionName => "XR_ML_localization_map"u8;

    [NativeName("XR_ML_spatial_anchors_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_ML_spatial_anchors"], ImpliesSets = ["XR_EXT_future"])]
    public const int MLSpatialAnchorsSpecVersion = 1;

    [NativeName("XR_ML_SPATIAL_ANCHORS_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_ML_spatial_anchors"], ImpliesSets = ["XR_EXT_future"])]
    public static Utf8String MlSpatialAnchorsExtensionName => "XR_ML_spatial_anchors"u8;

    [NativeName("XR_ML_spatial_anchors_storage_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    public const int MLSpatialAnchorsStorageSpecVersion = 1;

    [NativeName("XR_ML_SPATIAL_ANCHORS_STORAGE_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    public static Utf8String MlSpatialAnchorsStorageExtensionName =>
        "XR_ML_spatial_anchors_storage"u8;

    [NativeName("XR_MAX_SPATIAL_ANCHOR_NAME_SIZE_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_spatial_anchor_persistence"],
        ImpliesSets = ["XR_MSFT_spatial_anchor", "XR_VERSION_1_0"]
    )]
    public const int MaxSpatialAnchorNameSizeMSFT = 256;

    [NativeName("XR_MSFT_spatial_anchor_persistence_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_spatial_anchor_persistence"],
        ImpliesSets = ["XR_MSFT_spatial_anchor", "XR_VERSION_1_0"]
    )]
    public const int MsftSpatialAnchorPersistenceSpecVersion = 2;

    [NativeName("XR_MSFT_SPATIAL_ANCHOR_PERSISTENCE_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_spatial_anchor_persistence"],
        ImpliesSets = ["XR_MSFT_spatial_anchor", "XR_VERSION_1_0"]
    )]
    public static Utf8String MsftSpatialAnchorPersistenceExtensionName =>
        "XR_MSFT_spatial_anchor_persistence"u8;

    [NativeName("XR_MSFT_scene_marker_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_scene_marker"],
        ImpliesSets = ["XR_MSFT_scene_understanding", "XR_VERSION_1_0"]
    )]
    public const int MsftSceneMarkerSpecVersion = 1;

    [NativeName("XR_MSFT_SCENE_MARKER_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_scene_marker"],
        ImpliesSets = ["XR_MSFT_scene_understanding", "XR_VERSION_1_0"]
    )]
    public static Utf8String MsftSceneMarkerExtensionName => "XR_MSFT_scene_marker"u8;

    [NativeName("XR_HAND_FOREARM_JOINT_COUNT_ULTRALEAP")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ULTRALEAP_hand_tracking_forearm"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public const int HandForearmJointCountULTRALEAP = 27;

    [NativeName("XR_ULTRALEAP_hand_tracking_forearm_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ULTRALEAP_hand_tracking_forearm"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public const int UltraleapHandTrackingForearmSpecVersion = 1;

    [NativeName("XR_ULTRALEAP_HAND_TRACKING_FOREARM_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ULTRALEAP_hand_tracking_forearm"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public static Utf8String UltraleapHandTrackingForearmExtensionName =>
        "XR_ULTRALEAP_hand_tracking_forearm"u8;

    [NativeName("XR_FB_spatial_entity_query_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_query"],
        ImpliesSets = ["XR_FB_spatial_entity_storage", "XR_VERSION_1_0"]
    )]
    public const int FBSpatialEntityQuerySpecVersion = 1;

    [NativeName("XR_FB_SPATIAL_ENTITY_QUERY_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_query"],
        ImpliesSets = ["XR_FB_spatial_entity_storage", "XR_VERSION_1_0"]
    )]
    public static Utf8String FbSpatialEntityQueryExtensionName => "XR_FB_spatial_entity_query"u8;

    [NativeName("XR_FB_spatial_entity_storage_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_storage"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public const int FBSpatialEntityStorageSpecVersion = 1;

    [NativeName("XR_FB_SPATIAL_ENTITY_STORAGE_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_storage"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public static Utf8String FbSpatialEntityStorageExtensionName =>
        "XR_FB_spatial_entity_storage"u8;

    [NativeName("XR_FB_touch_controller_pro_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_FB_touch_controller_pro"])]
    public const int FBTouchControllerProSpecVersion = 1;

    [NativeName("XR_FB_TOUCH_CONTROLLER_PRO_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_FB_touch_controller_pro"])]
    public static Utf8String FbTouchControllerProExtensionName => "XR_FB_touch_controller_pro"u8;

    [NativeName("XR_FB_spatial_entity_sharing_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public const int FBSpatialEntitySharingSpecVersion = 1;

    [NativeName("XR_FB_SPATIAL_ENTITY_SHARING_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public static Utf8String FbSpatialEntitySharingExtensionName =>
        "XR_FB_spatial_entity_sharing"u8;

    [NativeName("XR_FB_space_warp_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_FB_space_warp"])]
    public const int FBSpaceWarpSpecVersion = 2;

    [NativeName("XR_FB_SPACE_WARP_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_FB_space_warp"])]
    public static Utf8String FbSpaceWarpExtensionName => "XR_FB_space_warp"u8;

    [NativeName("XR_MAX_HAPTIC_AMPLITUDE_ENVELOPE_SAMPLES_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_haptic_amplitude_envelope"])]
    public const uint MaxHapticAmplitudeEnvelopeSamplesFB = 4000U;

    [NativeName("XR_FB_haptic_amplitude_envelope_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_FB_haptic_amplitude_envelope"])]
    public const int FBHapticAmplitudeEnvelopeSpecVersion = 1;

    [NativeName("XR_FB_HAPTIC_AMPLITUDE_ENVELOPE_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_FB_haptic_amplitude_envelope"])]
    public static Utf8String FbHapticAmplitudeEnvelopeExtensionName =>
        "XR_FB_haptic_amplitude_envelope"u8;

    [NativeName("XR_FB_scene_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_scene"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public const int FBSceneSpecVersion = 4;

    [NativeName("XR_FB_SCENE_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_scene"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public static Utf8String FbSceneExtensionName => "XR_FB_scene"u8;

    [NativeName("XR_EXT_palm_pose_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_EXT_palm_pose"])]
    public const int ExtPalmPoseSpecVersion = 3;

    [NativeName("XR_EXT_PALM_POSE_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_EXT_palm_pose"])]
    public static Utf8String ExtPalmPoseExtensionName => "XR_EXT_palm_pose"u8;

    [NativeName("XR_ALMALENCE_digital_lens_control_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_ALMALENCE_digital_lens_control"])]
    public const int AlmalenceDigitalLensControlSpecVersion = 1;

    [NativeName("XR_ALMALENCE_DIGITAL_LENS_CONTROL_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_ALMALENCE_digital_lens_control"])]
    public static Utf8String AlmalenceDigitalLensControlExtensionName =>
        "XR_ALMALENCE_digital_lens_control"u8;

    [NativeName("XR_FB_scene_capture_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_FB_scene_capture"])]
    public const int FBSceneCaptureSpecVersion = 1;

    [NativeName("XR_FB_SCENE_CAPTURE_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_FB_scene_capture"])]
    public static Utf8String FbSceneCaptureExtensionName => "XR_FB_scene_capture"u8;

    [NativeName("XR_FB_spatial_entity_container_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_container"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public const int FBSpatialEntityContainerSpecVersion = 2;

    [NativeName("XR_FB_SPATIAL_ENTITY_CONTAINER_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_container"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public static Utf8String FbSpatialEntityContainerExtensionName =>
        "XR_FB_spatial_entity_container"u8;

    [NativeName("XR_FOVEATION_CENTER_SIZE_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_foveation_eye_tracked"],
        ImpliesSets = ["XR_FB_foveation", "XR_FB_foveation_configuration", "XR_VERSION_1_0"]
    )]
    public const int FoveationCenterSizeMETA = 2;

    [NativeName("XR_META_foveation_eye_tracked_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_foveation_eye_tracked"],
        ImpliesSets = ["XR_FB_foveation", "XR_FB_foveation_configuration", "XR_VERSION_1_0"]
    )]
    public const int MetaFoveationEyeTrackedSpecVersion = 1;

    [NativeName("XR_META_FOVEATION_EYE_TRACKED_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_foveation_eye_tracked"],
        ImpliesSets = ["XR_FB_foveation", "XR_FB_foveation_configuration", "XR_VERSION_1_0"]
    )]
    public static Utf8String MetaFoveationEyeTrackedExtensionName =>
        "XR_META_foveation_eye_tracked"u8;

    [NativeName("XR_FACE_EXPRESSSION_SET_DEFAULT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    public const FaceExpressionSetFB FaceExpresssionSetDefaultFB = FaceExpressionSetFB.Default;

    [NativeName("XR_FB_face_tracking_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    public const int FBFaceTrackingSpecVersion = 1;

    [NativeName("XR_FB_FACE_TRACKING_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    public static Utf8String FbFaceTrackingExtensionName => "XR_FB_face_tracking"u8;

    [NativeName("XR_FB_eye_tracking_social_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_FB_eye_tracking_social"])]
    public const int FBEyeTrackingSocialSpecVersion = 1;

    [NativeName("XR_FB_EYE_TRACKING_SOCIAL_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_FB_eye_tracking_social"])]
    public static Utf8String FbEyeTrackingSocialExtensionName => "XR_FB_eye_tracking_social"u8;

    [NativeName("XR_FB_passthrough_keyboard_hands_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_passthrough_keyboard_hands"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    public const int FBPassthroughKeyboardHandsSpecVersion = 2;

    [NativeName("XR_FB_PASSTHROUGH_KEYBOARD_HANDS_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_passthrough_keyboard_hands"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    public static Utf8String FbPassthroughKeyboardHandsExtensionName =>
        "XR_FB_passthrough_keyboard_hands"u8;

    [NativeName("XR_FB_composition_layer_settings_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_settings"])]
    public const int FBCompositionLayerSettingsSpecVersion = 1;

    [NativeName("XR_FB_COMPOSITION_LAYER_SETTINGS_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_settings"])]
    public static Utf8String FbCompositionLayerSettingsExtensionName =>
        "XR_FB_composition_layer_settings"u8;

    [NativeName("XR_FB_touch_controller_proximity_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_FB_touch_controller_proximity"])]
    public const int FBTouchControllerProximitySpecVersion = 1;

    [NativeName("XR_FB_TOUCH_CONTROLLER_PROXIMITY_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_FB_touch_controller_proximity"])]
    public static Utf8String FbTouchControllerProximityExtensionName =>
        "XR_FB_touch_controller_proximity"u8;

    [NativeName("XR_MAX_HAPTIC_PCM_BUFFER_SIZE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_haptic_pcm"])]
    public const int MaxHapticPcmBufferSizeFB = 4000;

    [NativeName("XR_FB_haptic_pcm_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_FB_haptic_pcm"])]
    public const int FBHapticPcmSpecVersion = 1;

    [NativeName("XR_FB_HAPTIC_PCM_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_FB_haptic_pcm"])]
    public static Utf8String FbHapticPcmExtensionName => "XR_FB_haptic_pcm"u8;

    [NativeName("XR_EXT_frame_synthesis_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_EXT_frame_synthesis"])]
    public const int ExtFrameSynthesisSpecVersion = 1;

    [NativeName("XR_EXT_FRAME_SYNTHESIS_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_EXT_frame_synthesis"])]
    public static Utf8String ExtFrameSynthesisExtensionName => "XR_EXT_frame_synthesis"u8;

    [NativeName("XR_FB_composition_layer_depth_test_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_depth_test"])]
    public const int FBCompositionLayerDepthTestSpecVersion = 1;

    [NativeName("XR_FB_COMPOSITION_LAYER_DEPTH_TEST_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_depth_test"])]
    public static Utf8String FbCompositionLayerDepthTestExtensionName =>
        "XR_FB_composition_layer_depth_test"u8;

    [NativeName("XR_META_local_dimming_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_META_local_dimming"])]
    public const int MetaLocalDimmingSpecVersion = 1;

    [NativeName("XR_META_LOCAL_DIMMING_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_META_local_dimming"])]
    public static Utf8String MetaLocalDimmingExtensionName => "XR_META_local_dimming"u8;

    [NativeName("XR_META_passthrough_preferences_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_META_passthrough_preferences"])]
    public const int MetaPassthroughPreferencesSpecVersion = 1;

    [NativeName("XR_META_PASSTHROUGH_PREFERENCES_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_META_passthrough_preferences"])]
    public static Utf8String MetaPassthroughPreferencesExtensionName =>
        "XR_META_passthrough_preferences"u8;

    [NativeName("XR_MAX_VIRTUAL_KEYBOARD_COMMIT_TEXT_SIZE_META")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public const int MaxVirtualKeyboardCommitTextSizeMETA = 3992;

    [NativeName("XR_META_virtual_keyboard_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public const int MetaVirtualKeyboardSpecVersion = 1;

    [NativeName("XR_META_VIRTUAL_KEYBOARD_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public static Utf8String MetaVirtualKeyboardExtensionName => "XR_META_virtual_keyboard"u8;

    [NativeName("XR_MAX_EXTERNAL_CAMERA_NAME_SIZE_OCULUS")]
    [SupportedApiProfile("openxr", ["XR_OCULUS_external_camera"])]
    public const int MaxExternalCameraNameSizeOCULUS = 32;

    [NativeName("XR_OCULUS_external_camera_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_OCULUS_external_camera"])]
    public const int OculusExternalCameraSpecVersion = 1;

    [NativeName("XR_OCULUS_EXTERNAL_CAMERA_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_OCULUS_external_camera"])]
    public static Utf8String OculusExternalCameraExtensionName => "XR_OCULUS_external_camera"u8;

    [NativeName("XR_META_performance_metrics_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_META_performance_metrics"])]
    public const int MetaPerformanceMetricsSpecVersion = 2;

    [NativeName("XR_META_PERFORMANCE_METRICS_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_META_performance_metrics"])]
    public static Utf8String MetaPerformanceMetricsExtensionName => "XR_META_performance_metrics"u8;

    [NativeName("XR_FB_spatial_entity_storage_batch_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_storage_batch"],
        ImpliesSets = ["XR_FB_spatial_entity_storage", "XR_VERSION_1_0"]
    )]
    public const int FBSpatialEntityStorageBatchSpecVersion = 1;

    [NativeName("XR_FB_SPATIAL_ENTITY_STORAGE_BATCH_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_storage_batch"],
        ImpliesSets = ["XR_FB_spatial_entity_storage", "XR_VERSION_1_0"]
    )]
    public static Utf8String FbSpatialEntityStorageBatchExtensionName =>
        "XR_FB_spatial_entity_storage_batch"u8;

    [NativeName("XR_META_detached_controllers_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_META_detached_controllers"])]
    public const int MetaDetachedControllersSpecVersion = 1;

    [NativeName("XR_META_DETACHED_CONTROLLERS_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_META_detached_controllers"])]
    public static Utf8String MetaDetachedControllersExtensionName =>
        "XR_META_detached_controllers"u8;

    [NativeName("XR_FB_spatial_entity_user_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity_user"])]
    public const int FBSpatialEntityUserSpecVersion = 1;

    [NativeName("XR_FB_SPATIAL_ENTITY_USER_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity_user"])]
    public static Utf8String FbSpatialEntityUserExtensionName => "XR_FB_spatial_entity_user"u8;

    [NativeName("XR_META_headset_id_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_META_headset_id"])]
    public const int MetaHeadsetIdSpecVersion = 2;

    [NativeName("XR_META_HEADSET_ID_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_META_headset_id"])]
    public static Utf8String MetaHeadsetIdExtensionName => "XR_META_headset_id"u8;

    [NativeName("XR_META_spatial_entity_discovery_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_discovery"])]
    public const int MetaSpatialEntityDiscoverySpecVersion = 1;

    [NativeName("XR_META_SPATIAL_ENTITY_DISCOVERY_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_discovery"])]
    public static Utf8String MetaSpatialEntityDiscoveryExtensionName =>
        "XR_META_spatial_entity_discovery"u8;

    [NativeName("XR_META_hand_tracking_microgestures_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_hand_tracking_microgestures"],
        ImpliesSets = ["XR_EXT_hand_interaction", "XR_VERSION_1_0"]
    )]
    public const int MetaHandTrackingMicrogesturesSpecVersion = 1;

    [NativeName("XR_META_HAND_TRACKING_MICROGESTURES_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_hand_tracking_microgestures"],
        ImpliesSets = ["XR_EXT_hand_interaction", "XR_VERSION_1_0"]
    )]
    public static Utf8String MetaHandTrackingMicrogesturesExtensionName =>
        "XR_META_hand_tracking_microgestures"u8;

    [NativeName("XR_META_recommended_layer_resolution_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_META_recommended_layer_resolution"])]
    public const int MetaRecommendedLayerResolutionSpecVersion = 1;

    [NativeName("XR_META_RECOMMENDED_LAYER_RESOLUTION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_META_recommended_layer_resolution"])]
    public static Utf8String MetaRecommendedLayerResolutionExtensionName =>
        "XR_META_recommended_layer_resolution"u8;

    [NativeName("XR_META_spatial_entity_persistence_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    public const int MetaSpatialEntityPersistenceSpecVersion = 1;

    [NativeName("XR_META_SPATIAL_ENTITY_PERSISTENCE_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    public static Utf8String MetaSpatialEntityPersistenceExtensionName =>
        "XR_META_spatial_entity_persistence"u8;

    [NativeName("XR_META_passthrough_color_lut_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_passthrough_color_lut"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    public const int MetaPassthroughColorLutSpecVersion = 1;

    [NativeName("XR_META_PASSTHROUGH_COLOR_LUT_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_passthrough_color_lut"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    public static Utf8String MetaPassthroughColorLutExtensionName =>
        "XR_META_passthrough_color_lut"u8;

    [NativeName("XR_META_spatial_entity_mesh_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_mesh"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public const int MetaSpatialEntityMeshSpecVersion = 1;

    [NativeName("XR_META_SPATIAL_ENTITY_MESH_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_mesh"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public static Utf8String MetaSpatialEntityMeshExtensionName => "XR_META_spatial_entity_mesh"u8;

    [NativeName("XR_META_automatic_layer_filter_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_automatic_layer_filter"],
        ImpliesSets = ["XR_FB_composition_layer_settings", "XR_VERSION_1_0"]
    )]
    public const int MetaAutomaticLayerFilterSpecVersion = 1;

    [NativeName("XR_META_AUTOMATIC_LAYER_FILTER_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_automatic_layer_filter"],
        ImpliesSets = ["XR_FB_composition_layer_settings", "XR_VERSION_1_0"]
    )]
    public static Utf8String MetaAutomaticLayerFilterExtensionName =>
        "XR_META_automatic_layer_filter"u8;

    [NativeName("XR_META_body_tracking_full_body_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_full_body"],
        ImpliesSets = ["XR_FB_body_tracking"]
    )]
    public const int MetaBodyTrackingFullBodySpecVersion = 1;

    [NativeName("XR_META_BODY_TRACKING_FULL_BODY_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_full_body"],
        ImpliesSets = ["XR_FB_body_tracking"]
    )]
    public static Utf8String MetaBodyTrackingFullBodyExtensionName =>
        "XR_META_body_tracking_full_body"u8;

    [NativeName("XR_META_touch_controller_plus_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_META_touch_controller_plus"])]
    public const int MetaTouchControllerPlusSpecVersion = 1;

    [NativeName("XR_META_TOUCH_CONTROLLER_PLUS_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_META_touch_controller_plus"])]
    public static Utf8String MetaTouchControllerPlusExtensionName =>
        "XR_META_touch_controller_plus"u8;

    [NativeName("XR_META_passthrough_layer_resumed_event_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_passthrough_layer_resumed_event"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    public const int MetaPassthroughLayerResumedEventSpecVersion = 1;

    [NativeName("XR_META_PASSTHROUGH_LAYER_RESUMED_EVENT_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_passthrough_layer_resumed_event"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    public static Utf8String MetaPassthroughLayerResumedEventExtensionName =>
        "XR_META_passthrough_layer_resumed_event"u8;

    [NativeName("XR_META_body_tracking_calibration_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_calibration"],
        ImpliesSets = ["XR_FB_body_tracking"]
    )]
    public const int MetaBodyTrackingCalibrationSpecVersion = 1;

    [NativeName("XR_META_BODY_TRACKING_CALIBRATION_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_calibration"],
        ImpliesSets = ["XR_FB_body_tracking"]
    )]
    public static Utf8String MetaBodyTrackingCalibrationExtensionName =>
        "XR_META_body_tracking_calibration"u8;

    [NativeName("XR_META_body_tracking_fidelity_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_fidelity"],
        ImpliesSets = ["XR_FB_body_tracking", "XR_VERSION_1_0"]
    )]
    public const int MetaBodyTrackingFidelitySpecVersion = 1;

    [NativeName("XR_META_BODY_TRACKING_FIDELITY_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_fidelity"],
        ImpliesSets = ["XR_FB_body_tracking", "XR_VERSION_1_0"]
    )]
    public static Utf8String MetaBodyTrackingFidelityExtensionName =>
        "XR_META_body_tracking_fidelity"u8;

    [NativeName("XR_FB_face_tracking2_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    public const int FBFaceTracking2SpecVersion = 1;

    [NativeName("XR_FB_FACE_TRACKING2_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    public static Utf8String FbFaceTracking2ExtensionName => "XR_FB_face_tracking2"u8;

    [NativeName("XR_META_spatial_entity_sharing_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity"]
    )]
    public const int MetaSpatialEntitySharingSpecVersion = 1;

    [NativeName("XR_META_SPATIAL_ENTITY_SHARING_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity"]
    )]
    public static Utf8String MetaSpatialEntitySharingExtensionName =>
        "XR_META_spatial_entity_sharing"u8;

    [NativeName("XR_MAX_SPACES_PER_SHARE_REQUEST_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity"]
    )]
    public const int MaxSpacesPerShareRequestMETA = 32;

    [NativeName("XR_META_environment_depth_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    public const int MetaEnvironmentDepthSpecVersion = 2;

    [NativeName("XR_META_ENVIRONMENT_DEPTH_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_META_environment_depth"])]
    public static Utf8String MetaEnvironmentDepthExtensionName => "XR_META_environment_depth"u8;

    [NativeName("XR_EXT_uuid_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_EXT_uuid"])]
    public const int ExtUuidSpecVersion = 1;

    [NativeName("XR_EXT_UUID_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_EXT_uuid"])]
    public static Utf8String ExtUuidExtensionName => "XR_EXT_uuid"u8;

    [NativeName("XR_UUID_SIZE_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_uuid"])]
    public const int UuidSizeEXT = 16;

    [NativeName("XR_MAX_RENDER_MODEL_ASSET_NODE_NAME_SIZE_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    public const int MaxRenderModelAssetNodeNameSizeEXT = 64;

    [NativeName("XR_EXT_render_model_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    public const int ExtRenderModelSpecVersion = 1;

    [NativeName("XR_EXT_RENDER_MODEL_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    public static Utf8String ExtRenderModelExtensionName => "XR_EXT_render_model"u8;

    [NativeName("XR_NULL_RENDER_MODEL_ID_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_render_model"],
        ImpliesSets = ["XR_EXT_render_model+XR_EXT_uuid", "XR_EXT_render_model+XR_VERSION_1_1"]
    )]
    public const int NullRenderModelIdEXT = 0;

    [NativeName("XR_EXT_interaction_render_model_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_interaction_render_model"],
        ImpliesSets = ["XR_EXT_render_model"]
    )]
    public const int ExtInteractionRenderModelSpecVersion = 1;

    [NativeName("XR_EXT_INTERACTION_RENDER_MODEL_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_interaction_render_model"],
        ImpliesSets = ["XR_EXT_render_model"]
    )]
    public static Utf8String ExtInteractionRenderModelExtensionName =>
        "XR_EXT_interaction_render_model"u8;

    [NativeName("XR_EXT_hand_interaction_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_interaction"])]
    public const int ExtHandInteractionSpecVersion = 2;

    [NativeName("XR_EXT_HAND_INTERACTION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_interaction"])]
    public static Utf8String ExtHandInteractionExtensionName => "XR_EXT_hand_interaction"u8;

    [NativeName("XR_QCOM_tracking_optimization_settings_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_QCOM_tracking_optimization_settings"])]
    public const int QcomTrackingOptimizationSettingsSpecVersion = 1;

    [NativeName("XR_QCOM_TRACKING_OPTIMIZATION_SETTINGS_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_QCOM_tracking_optimization_settings"])]
    public static Utf8String QcomTrackingOptimizationSettingsExtensionName =>
        "XR_QCOM_tracking_optimization_settings"u8;

    [NativeName("XR_QCOM_hand_tracking_gesture_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_QCOM_hand_tracking_gesture"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public const int QcomHandTrackingGestureSpecVersion = 1;

    [NativeName("XR_QCOM_HAND_TRACKING_GESTURE_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_QCOM_hand_tracking_gesture"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public static Utf8String QcomHandTrackingGestureExtensionName =>
        "XR_QCOM_hand_tracking_gesture"u8;

    [NativeName("XR_HTC_passthrough_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    public const int HtcPassthroughSpecVersion = 1;

    [NativeName("XR_HTC_PASSTHROUGH_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    public static Utf8String HtcPassthroughExtensionName => "XR_HTC_passthrough"u8;

    [NativeName("XR_HTC_foveation_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_HTC_foveation"])]
    public const int HtcFoveationSpecVersion = 1;

    [NativeName("XR_HTC_FOVEATION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_HTC_foveation"])]
    public static Utf8String HtcFoveationExtensionName => "XR_HTC_foveation"u8;

    [NativeName("XR_MAX_SPATIAL_ANCHOR_NAME_SIZE_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_anchor"])]
    public const int MaxSpatialAnchorNameSizeHTC = 256;

    [NativeName("XR_HTC_anchor_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_HTC_anchor"])]
    public const int HtcAnchorSpecVersion = 1;

    [NativeName("XR_HTC_ANCHOR_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_HTC_anchor"])]
    public static Utf8String HtcAnchorExtensionName => "XR_HTC_anchor"u8;

    [NativeName("XR_BODY_JOINT_COUNT_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    public const int BodyJointCountHTC = 26;

    [NativeName("XR_HTC_body_tracking_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    public const int HtcBodyTrackingSpecVersion = 1;

    [NativeName("XR_HTC_BODY_TRACKING_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    public static Utf8String HtcBodyTrackingExtensionName => "XR_HTC_body_tracking"u8;

    [NativeName("XR_EXT_active_action_set_priority_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_EXT_active_action_set_priority"])]
    public const int ExtActiveActionSetPrioritySpecVersion = 1;

    [NativeName("XR_EXT_ACTIVE_ACTION_SET_PRIORITY_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_EXT_active_action_set_priority"])]
    public static Utf8String ExtActiveActionSetPriorityExtensionName =>
        "XR_EXT_active_action_set_priority"u8;

    [NativeName("XR_MNDX_force_feedback_curl_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MNDX_force_feedback_curl"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public const int MndxForceFeedbackCurlSpecVersion = 1;

    [NativeName("XR_MNDX_FORCE_FEEDBACK_CURL_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MNDX_force_feedback_curl"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public static Utf8String MndxForceFeedbackCurlExtensionName => "XR_MNDX_force_feedback_curl"u8;

    [NativeName("XR_BD_controller_interaction_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_BD_controller_interaction"])]
    public const int BDControllerInteractionSpecVersion = 2;

    [NativeName("XR_BD_CONTROLLER_INTERACTION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_BD_controller_interaction"])]
    public static Utf8String BdControllerInteractionExtensionName =>
        "XR_BD_controller_interaction"u8;

    [NativeName("XR_BODY_JOINT_COUNT_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    public const int BodyJointCountBD = 24;

    [NativeName("XR_BODY_JOINT_WITHOUT_ARM_COUNT_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    public const int BodyJointWithoutArmCountBD = 16;

    [NativeName("XR_BD_body_tracking_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    public const int BDBodyTrackingSpecVersion = 1;

    [NativeName("XR_BD_BODY_TRACKING_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    public static Utf8String BdBodyTrackingExtensionName => "XR_BD_body_tracking"u8;

    [NativeName("XR_FACE_EXPRESSION_COUNT_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    public const int FaceExpressionCountBD = 52;

    [NativeName("XR_LIP_EXPRESSION_COUNT_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    public const int LipExpressionCountBD = 20;

    [NativeName("XR_BD_facial_simulation_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    public const int BDFacialSimulationSpecVersion = 1;

    [NativeName("XR_BD_FACIAL_SIMULATION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    public static Utf8String BdFacialSimulationExtensionName => "XR_BD_facial_simulation"u8;

    [NativeName("XR_BD_spatial_sensing_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    public const int BDSpatialSensingSpecVersion = 1;

    [NativeName("XR_BD_SPATIAL_SENSING_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    public static Utf8String BdSpatialSensingExtensionName => "XR_BD_spatial_sensing"u8;

    [NativeName("XR_BD_spatial_anchor_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    public const int BDSpatialAnchorSpecVersion = 2;

    [NativeName("XR_BD_SPATIAL_ANCHOR_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    public static Utf8String BdSpatialAnchorExtensionName => "XR_BD_spatial_anchor"u8;

    [NativeName("XR_BD_spatial_anchor_sharing_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor_sharing"],
        ImpliesSets = ["XR_BD_spatial_anchor"]
    )]
    public const int BDSpatialAnchorSharingSpecVersion = 2;

    [NativeName("XR_BD_SPATIAL_ANCHOR_SHARING_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor_sharing"],
        ImpliesSets = ["XR_BD_spatial_anchor"]
    )]
    public static Utf8String BdSpatialAnchorSharingExtensionName =>
        "XR_BD_spatial_anchor_sharing"u8;

    [NativeName("XR_BD_spatial_scene_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_scene"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    public const int BDSpatialSceneSpecVersion = 1;

    [NativeName("XR_BD_SPATIAL_SCENE_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_scene"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    public static Utf8String BdSpatialSceneExtensionName => "XR_BD_spatial_scene"u8;

    [NativeName("XR_BD_spatial_mesh_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_mesh"], ImpliesSets = ["XR_BD_spatial_sensing"])]
    public const int BDSpatialMeshSpecVersion = 1;

    [NativeName("XR_BD_SPATIAL_MESH_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_mesh"], ImpliesSets = ["XR_BD_spatial_sensing"])]
    public static Utf8String BdSpatialMeshExtensionName => "XR_BD_spatial_mesh"u8;

    [NativeName("XR_BD_future_progress_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_future_progress"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    public const int BDFutureProgressSpecVersion = 1;

    [NativeName("XR_BD_FUTURE_PROGRESS_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_future_progress"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    public static Utf8String BdFutureProgressExtensionName => "XR_BD_future_progress"u8;

    [NativeName("XR_BD_spatial_plane_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_plane"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    public const int BDSpatialPlaneSpecVersion = 1;

    [NativeName("XR_BD_SPATIAL_PLANE_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_plane"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    public static Utf8String BdSpatialPlaneExtensionName => "XR_BD_spatial_plane"u8;

    [NativeName("XR_BD_ultra_controller_interaction_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_BD_ultra_controller_interaction"])]
    public const int BDUltraControllerInteractionSpecVersion = 1;

    [NativeName("XR_BD_ULTRA_CONTROLLER_INTERACTION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_BD_ultra_controller_interaction"])]
    public static Utf8String BdUltraControllerInteractionExtensionName =>
        "XR_BD_ultra_controller_interaction"u8;

    [NativeName("XR_BD_spatial_audio_rendering_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public const int BDSpatialAudioRenderingSpecVersion = 1;

    [NativeName("XR_BD_SPATIAL_AUDIO_RENDERING_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public static Utf8String BdSpatialAudioRenderingExtensionName =>
        "XR_BD_spatial_audio_rendering"u8;

    [NativeName("XR_EXT_local_floor_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_EXT_local_floor"])]
    public const int ExtLocalFloorSpecVersion = 1;

    [NativeName("XR_EXT_LOCAL_FLOOR_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_EXT_local_floor"])]
    public static Utf8String ExtLocalFloorExtensionName => "XR_EXT_local_floor"u8;

    [NativeName("XR_EXT_hand_tracking_data_source_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_hand_tracking_data_source"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public const int ExtHandTrackingDataSourceSpecVersion = 1;

    [NativeName("XR_EXT_HAND_TRACKING_DATA_SOURCE_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_hand_tracking_data_source"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public static Utf8String ExtHandTrackingDataSourceExtensionName =>
        "XR_EXT_hand_tracking_data_source"u8;

    [NativeName("XR_EXT_plane_detection_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public const int ExtPlaneDetectionSpecVersion = 2;

    [NativeName("XR_EXT_PLANE_DETECTION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public static Utf8String ExtPlaneDetectionExtensionName => "XR_EXT_plane_detection"u8;

    [NativeName("XR_OPPO_controller_interaction_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_OPPO_controller_interaction"])]
    public const int OppoControllerInteractionSpecVersion = 1;

    [NativeName("XR_OPPO_CONTROLLER_INTERACTION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_OPPO_controller_interaction"])]
    public static Utf8String OppoControllerInteractionExtensionName =>
        "XR_OPPO_controller_interaction"u8;

    [NativeName("XR_NULL_TRACKABLE_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    public const int NullTrackableANDROID = 0;

    [NativeName("XR_ANDROID_trackables_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    public const int AndroidTrackablesSpecVersion = 2;

    [NativeName("XR_ANDROID_TRACKABLES_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    public static Utf8String AndroidTrackablesExtensionName => "XR_ANDROID_trackables"u8;

    [NativeName("XR_EYE_MAX_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_eye_tracking"])]
    public const int EyeMaxANDROID = 2;

    [NativeName("XR_ANDROID_eye_tracking_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_eye_tracking"])]
    public const int AndroidEyeTrackingSpecVersion = 1;

    [NativeName("XR_ANDROID_EYE_TRACKING_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_eye_tracking"])]
    public static Utf8String AndroidEyeTrackingExtensionName => "XR_ANDROID_eye_tracking"u8;

    [NativeName("XR_ANDROID_device_anchor_persistence_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_device_anchor_persistence"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_uuid"]
    )]
    public const int AndroidDeviceAnchorPersistenceSpecVersion = 1;

    [NativeName("XR_ANDROID_DEVICE_ANCHOR_PERSISTENCE_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_device_anchor_persistence"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_uuid"]
    )]
    public static Utf8String AndroidDeviceAnchorPersistenceExtensionName =>
        "XR_ANDROID_device_anchor_persistence"u8;

    [NativeName("XR_ANDROID_face_tracking_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    public const int AndroidFaceTrackingSpecVersion = 1;

    [NativeName("XR_ANDROID_FACE_TRACKING_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    public static Utf8String AndroidFaceTrackingExtensionName => "XR_ANDROID_face_tracking"u8;

    [NativeName("XR_FACE_PARAMETER_COUNT_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    public const int FaceParameterCountANDROID = 68;

    [NativeName("XR_FACE_REGION_CONFIDENCE_COUNT_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    public const int FaceRegionConfidenceCountANDROID = 3;

    [NativeName("XR_ANDROID_passthrough_camera_state_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_passthrough_camera_state"])]
    public const int AndroidPassthroughCameraStateSpecVersion = 1;

    [NativeName("XR_ANDROID_PASSTHROUGH_CAMERA_STATE_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_passthrough_camera_state"])]
    public static Utf8String AndroidPassthroughCameraStateExtensionName =>
        "XR_ANDROID_passthrough_camera_state"u8;

    [NativeName("XR_ANDROID_recommended_resolution_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_recommended_resolution"])]
    public const int AndroidRecommendedResolutionSpecVersion = 1;

    [NativeName("XR_ANDROID_RECOMMENDED_RESOLUTION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_recommended_resolution"])]
    public static Utf8String AndroidRecommendedResolutionExtensionName =>
        "XR_ANDROID_recommended_resolution"u8;

    [NativeName("XR_ANDROID_composition_layer_passthrough_mesh_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_composition_layer_passthrough_mesh"])]
    public const int AndroidCompositionLayerPassthroughMeshSpecVersion = 1;

    [NativeName("XR_ANDROID_COMPOSITION_LAYER_PASSTHROUGH_MESH_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_composition_layer_passthrough_mesh"])]
    public static Utf8String AndroidCompositionLayerPassthroughMeshExtensionName =>
        "XR_ANDROID_composition_layer_passthrough_mesh"u8;

    [NativeName("XR_ANDROID_raycast_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_raycast"], ImpliesSets = ["XR_ANDROID_trackables"])]
    public const int AndroidRaycastSpecVersion = 1;

    [NativeName("XR_ANDROID_RAYCAST_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_raycast"], ImpliesSets = ["XR_ANDROID_trackables"])]
    public static Utf8String AndroidRaycastExtensionName => "XR_ANDROID_raycast"u8;

    [NativeName("XR_ANDROID_performance_metrics_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_performance_metrics"])]
    public const int AndroidPerformanceMetricsSpecVersion = 1;

    [NativeName("XR_ANDROID_PERFORMANCE_METRICS_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_performance_metrics"])]
    public static Utf8String AndroidPerformanceMetricsExtensionName =>
        "XR_ANDROID_performance_metrics"u8;

    [NativeName("XR_ANDROID_trackables_object_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_object"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    public const int AndroidTrackablesObjectSpecVersion = 2;

    [NativeName("XR_ANDROID_TRACKABLES_OBJECT_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_object"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    public static Utf8String AndroidTrackablesObjectExtensionName =>
        "XR_ANDROID_trackables_object"u8;

    [NativeName("XR_ANDROID_unbounded_reference_space_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_unbounded_reference_space"])]
    public const int AndroidUnboundedReferenceSpaceSpecVersion = 1;

    [NativeName("XR_ANDROID_UNBOUNDED_REFERENCE_SPACE_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_unbounded_reference_space"])]
    public static Utf8String AndroidUnboundedReferenceSpaceExtensionName =>
        "XR_ANDROID_unbounded_reference_space"u8;

    [NativeName("XR_EXT_future_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_EXT_future"])]
    public const int ExtFutureSpecVersion = 2;

    [NativeName("XR_EXT_FUTURE_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_EXT_future"])]
    public static Utf8String ExtFutureExtensionName => "XR_EXT_future"u8;

    [NativeName("XR_NULL_FUTURE_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_future"])]
    public const int NullFutureEXT = 0;

    [NativeName("XR_EXT_user_presence_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_EXT_user_presence"])]
    public const int ExtUserPresenceSpecVersion = 1;

    [NativeName("XR_EXT_USER_PRESENCE_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_EXT_user_presence"])]
    public static Utf8String ExtUserPresenceExtensionName => "XR_EXT_user_presence"u8;

    [NativeName("XR_ML_user_calibration_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_ML_user_calibration"])]
    public const int MLUserCalibrationSpecVersion = 1;

    [NativeName("XR_ML_USER_CALIBRATION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_ML_user_calibration"])]
    public static Utf8String MlUserCalibrationExtensionName => "XR_ML_user_calibration"u8;

    [NativeName("XR_ML_system_notifications_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_ML_system_notifications"])]
    public const int MLSystemNotificationsSpecVersion = 1;

    [NativeName("XR_ML_SYSTEM_NOTIFICATIONS_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_ML_system_notifications"])]
    public static Utf8String MlSystemNotificationsExtensionName => "XR_ML_system_notifications"u8;

    [NativeName("XR_ML_world_mesh_detection_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    public const int MLWorldMeshDetectionSpecVersion = 1;

    [NativeName("XR_ML_WORLD_MESH_DETECTION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    public static Utf8String MlWorldMeshDetectionExtensionName => "XR_ML_world_mesh_detection"u8;

    [NativeName("XR_ML_facial_expression_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    public const int MLFacialExpressionSpecVersion = 1;

    [NativeName("XR_ML_FACIAL_EXPRESSION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    public static Utf8String MlFacialExpressionExtensionName => "XR_ML_facial_expression"u8;

    [NativeName("XR_ML_view_configuration_depth_range_change_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_view_configuration_depth_range_change"],
        ImpliesSets = ["XR_EXT_view_configuration_depth_range"]
    )]
    public const int MLViewConfigurationDepthRangeChangeSpecVersion = 1;

    [NativeName("XR_ML_VIEW_CONFIGURATION_DEPTH_RANGE_CHANGE_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_view_configuration_depth_range_change"],
        ImpliesSets = ["XR_EXT_view_configuration_depth_range"]
    )]
    public static Utf8String MlViewConfigurationDepthRangeChangeExtensionName =>
        "XR_ML_view_configuration_depth_range_change"u8;

    [NativeName("XR_YVR_controller_interaction_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_YVR_controller_interaction"])]
    public const int YvrControllerInteractionSpecVersion = 1;

    [NativeName("XR_YVR_CONTROLLER_INTERACTION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_YVR_controller_interaction"])]
    public static Utf8String YvrControllerInteractionExtensionName =>
        "XR_YVR_controller_interaction"u8;

    [NativeName("XR_META_boundary_visibility_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_META_boundary_visibility"])]
    public const int MetaBoundaryVisibilitySpecVersion = 1;

    [NativeName("XR_META_BOUNDARY_VISIBILITY_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_META_boundary_visibility"])]
    public static Utf8String MetaBoundaryVisibilityExtensionName => "XR_META_boundary_visibility"u8;

    [NativeName("XR_META_simultaneous_hands_and_controllers_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_META_simultaneous_hands_and_controllers"])]
    public const int MetaSimultaneousHandsAndControllersSpecVersion = 1;

    [NativeName("XR_META_SIMULTANEOUS_HANDS_AND_CONTROLLERS_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_META_simultaneous_hands_and_controllers"])]
    public static Utf8String MetaSimultaneousHandsAndControllersExtensionName =>
        "XR_META_simultaneous_hands_and_controllers"u8;

    [NativeName("XR_FACE_TRACKING_VISEME_COUNT_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_face_tracking_visemes"],
        ImpliesSets = ["XR_FB_face_tracking2", "XR_VERSION_1_0"]
    )]
    public const int FaceTrackingVisemeCountMETA = 15;

    [NativeName("XR_META_face_tracking_visemes_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_face_tracking_visemes"],
        ImpliesSets = ["XR_FB_face_tracking2", "XR_VERSION_1_0"]
    )]
    public const int MetaFaceTrackingVisemesSpecVersion = 1;

    [NativeName("XR_META_FACE_TRACKING_VISEMES_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_face_tracking_visemes"],
        ImpliesSets = ["XR_FB_face_tracking2", "XR_VERSION_1_0"]
    )]
    public static Utf8String MetaFaceTrackingVisemesExtensionName =>
        "XR_META_face_tracking_visemes"u8;

    [NativeName("XR_META_spatial_entity_semantic_label_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_semantic_label"])]
    public const int MetaSpatialEntitySemanticLabelSpecVersion = 1;

    [NativeName("XR_META_SPATIAL_ENTITY_SEMANTIC_LABEL_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_semantic_label"])]
    public static Utf8String MetaSpatialEntitySemanticLabelExtensionName =>
        "XR_META_spatial_entity_semantic_label"u8;

    [NativeName("XR_META_spatial_entity_room_mesh_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_room_mesh"],
        ImpliesSets = [
            "XR_FB_spatial_entity",
            "XR_META_spatial_entity_semantic_label",
            "XR_VERSION_1_0",
        ]
    )]
    public const int MetaSpatialEntityRoomMeshSpecVersion = 1;

    [NativeName("XR_META_SPATIAL_ENTITY_ROOM_MESH_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_room_mesh"],
        ImpliesSets = [
            "XR_FB_spatial_entity",
            "XR_META_spatial_entity_semantic_label",
            "XR_VERSION_1_0",
        ]
    )]
    public static Utf8String MetaSpatialEntityRoomMeshExtensionName =>
        "XR_META_spatial_entity_room_mesh"u8;

    [NativeName("XR_EXT_composition_layer_inverted_alpha_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_EXT_composition_layer_inverted_alpha"])]
    public const int ExtCompositionLayerInvertedAlphaSpecVersion = 1;

    [NativeName("XR_EXT_COMPOSITION_LAYER_INVERTED_ALPHA_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_EXT_composition_layer_inverted_alpha"])]
    public static Utf8String ExtCompositionLayerInvertedAlphaExtensionName =>
        "XR_EXT_composition_layer_inverted_alpha"u8;

    [NativeName("XR_MAX_COLOCATION_DISCOVERY_BUFFER_SIZE_META")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    public const int MaxColocationDiscoveryBufferSizeMETA = 1024;

    [NativeName("XR_META_colocation_discovery_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    public const int MetaColocationDiscoverySpecVersion = 1;

    [NativeName("XR_META_COLOCATION_DISCOVERY_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    public static Utf8String MetaColocationDiscoveryExtensionName =>
        "XR_META_colocation_discovery"u8;

    [NativeName("XR_META_spatial_entity_group_sharing_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_group_sharing"])]
    public const int MetaSpatialEntityGroupSharingSpecVersion = 1;

    [NativeName("XR_META_SPATIAL_ENTITY_GROUP_SHARING_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_group_sharing"])]
    public static Utf8String MetaSpatialEntityGroupSharingExtensionName =>
        "XR_META_spatial_entity_group_sharing"u8;

    [NativeName("XR_META_environment_raycast_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_environment_raycast"],
        ImpliesSets = ["XR_EXT_future"]
    )]
    public const int MetaEnvironmentRaycastSpecVersion = 1;

    [NativeName("XR_META_ENVIRONMENT_RAYCAST_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_environment_raycast"],
        ImpliesSets = ["XR_EXT_future"]
    )]
    public static Utf8String MetaEnvironmentRaycastExtensionName => "XR_META_environment_raycast"u8;

    [NativeName("XR_META_tile_properties_hint_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_META_tile_properties_hint"])]
    public const int MetaTilePropertiesHintSpecVersion = 1;

    [NativeName("XR_META_TILE_PROPERTIES_HINT_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_META_tile_properties_hint"])]
    public static Utf8String MetaTilePropertiesHintExtensionName =>
        "XR_META_tile_properties_hint"u8;

    [NativeName("XR_ANDROID_light_estimation_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    public const int AndroidLightEstimationSpecVersion = 1;

    [NativeName("XR_ANDROID_LIGHT_ESTIMATION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    public static Utf8String AndroidLightEstimationExtensionName => "XR_ANDROID_light_estimation"u8;

    [NativeName("XR_ANDROID_mouse_interaction_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_mouse_interaction"])]
    public const int AndroidMouseInteractionSpecVersion = 1;

    [NativeName("XR_ANDROID_MOUSE_INTERACTION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_mouse_interaction"])]
    public static Utf8String AndroidMouseInteractionExtensionName =>
        "XR_ANDROID_mouse_interaction"u8;

    [NativeName("XR_ANDROID_trackables_marker_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_marker"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    public const int AndroidTrackablesMarkerSpecVersion = 1;

    [NativeName("XR_ANDROID_TRACKABLES_MARKER_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_marker"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    public static Utf8String AndroidTrackablesMarkerExtensionName =>
        "XR_ANDROID_trackables_marker"u8;

    [NativeName("XR_ANDROID_trackables_qr_code_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_qr_code"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    public const int AndroidTrackablesQrCodeSpecVersion = 1;

    [NativeName("XR_ANDROID_TRACKABLES_QR_CODE_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_qr_code"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    public static Utf8String AndroidTrackablesQrCodeExtensionName =>
        "XR_ANDROID_trackables_qr_code"u8;

    [NativeName("XR_ANDROID_trackables_image_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_image"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_future"]
    )]
    public const int AndroidTrackablesImageSpecVersion = 1;

    [NativeName("XR_ANDROID_TRACKABLES_IMAGE_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_image"],
        ImpliesSets = ["XR_ANDROID_trackables", "XR_EXT_future"]
    )]
    public static Utf8String AndroidTrackablesImageExtensionName => "XR_ANDROID_trackables_image"u8;

    [NativeName("XR_ANDROID_scene_meshing_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public const int AndroidSceneMeshingSpecVersion = 3;

    [NativeName("XR_ANDROID_SCENE_MESHING_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public static Utf8String AndroidSceneMeshingExtensionName => "XR_ANDROID_scene_meshing"u8;

    [NativeName("XR_NULL_SPATIAL_ENTITY_ID_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    public const int NullSpatialEntityIdEXT = 0;

    [NativeName("XR_NULL_SPATIAL_BUFFER_ID_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    public const int NullSpatialBufferIdEXT = 0;

    [NativeName("XR_EXT_spatial_entity_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    public const int ExtSpatialEntitySpecVersion = 1;

    [NativeName("XR_EXT_SPATIAL_ENTITY_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    public static Utf8String ExtSpatialEntityExtensionName => "XR_EXT_spatial_entity"u8;

    [NativeName("XR_EXT_spatial_plane_tracking_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_plane_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    public const int ExtSpatialPlaneTrackingSpecVersion = 1;

    [NativeName("XR_EXT_SPATIAL_PLANE_TRACKING_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_plane_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    public static Utf8String ExtSpatialPlaneTrackingExtensionName =>
        "XR_EXT_spatial_plane_tracking"u8;

    [NativeName("XR_EXT_stationary_reference_space_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_stationary_reference_space"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    public const int ExtStationaryReferenceSpaceSpecVersion = 1;

    [NativeName("XR_EXT_STATIONARY_REFERENCE_SPACE_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_stationary_reference_space"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    public static Utf8String ExtStationaryReferenceSpaceExtensionName =>
        "XR_EXT_stationary_reference_space"u8;

    [NativeName("XR_EXT_spatial_marker_tracking_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    public const int ExtSpatialMarkerTrackingSpecVersion = 1;

    [NativeName("XR_EXT_SPATIAL_MARKER_TRACKING_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    public static Utf8String ExtSpatialMarkerTrackingExtensionName =>
        "XR_EXT_spatial_marker_tracking"u8;

    [NativeName("XR_LOGITECH_mx_ink_stylus_interaction_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_LOGITECH_mx_ink_stylus_interaction"])]
    public const int LogitechMxInkStylusInteractionSpecVersion = 1;

    [NativeName("XR_LOGITECH_MX_INK_STYLUS_INTERACTION_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_LOGITECH_mx_ink_stylus_interaction"])]
    public static Utf8String LogitechMxInkStylusInteractionExtensionName =>
        "XR_LOGITECH_mx_ink_stylus_interaction"u8;

    [NativeName("XR_EXT_spatial_anchor_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_anchor"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    public const int ExtSpatialAnchorSpecVersion = 1;

    [NativeName("XR_EXT_SPATIAL_ANCHOR_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_anchor"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    public static Utf8String ExtSpatialAnchorExtensionName => "XR_EXT_spatial_anchor"u8;

    [NativeName("XR_EXT_spatial_persistence_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_persistence"],
        ImpliesSets = ["XR_EXT_future", "XR_EXT_spatial_entity"]
    )]
    public const int ExtSpatialPersistenceSpecVersion = 1;

    [NativeName("XR_EXT_SPATIAL_PERSISTENCE_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_persistence"],
        ImpliesSets = ["XR_EXT_future", "XR_EXT_spatial_entity"]
    )]
    public static Utf8String ExtSpatialPersistenceExtensionName => "XR_EXT_spatial_persistence"u8;

    [NativeName("XR_HAPTIC_PARAMETRIC_MAX_POINTS_TRANSIENTS_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_haptic_parametric"])]
    public const int HapticParametricMaxPointsTransientsEXT = 500;

    [NativeName("XR_HAPTIC_PARAMETRIC_VIBRATION_EXTEND_DURATION_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_haptic_parametric"])]
    public const int HapticParametricVibrationExtendDurationEXT = 50000000;

    [NativeName("XR_HAPTIC_PARAMETRIC_FREQUENCY_MIN_HZ_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_haptic_parametric"])]
    public const int HapticParametricFrequencyMinHzEXT = 1;

    [NativeName("XR_HAPTIC_PARAMETRIC_FREQUENCY_MAX_HZ_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_haptic_parametric"])]
    public const int HapticParametricFrequencyMaxHzEXT = 1000;

    [NativeName("XR_EXT_haptic_parametric_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_EXT_haptic_parametric"])]
    public const int ExtHapticParametricSpecVersion = 1;

    [NativeName("XR_EXT_HAPTIC_PARAMETRIC_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_EXT_haptic_parametric"])]
    public static Utf8String ExtHapticParametricExtensionName => "XR_EXT_haptic_parametric"u8;

    [NativeName("XR_EXT_spatial_persistence_operations_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_persistence_operations"],
        ImpliesSets = ["XR_EXT_future", "XR_EXT_spatial_persistence"]
    )]
    public const int ExtSpatialPersistenceOperationsSpecVersion = 1;

    [NativeName("XR_EXT_SPATIAL_PERSISTENCE_OPERATIONS_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_persistence_operations"],
        ImpliesSets = ["XR_EXT_future", "XR_EXT_spatial_persistence"]
    )]
    public static Utf8String ExtSpatialPersistenceOperationsExtensionName =>
        "XR_EXT_spatial_persistence_operations"u8;

    [NativeName("XR_ANDROID_spatial_object_tracking_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_object_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    public const int AndroidSpatialObjectTrackingSpecVersion = 2;

    [NativeName("XR_ANDROID_SPATIAL_OBJECT_TRACKING_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_object_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    public static Utf8String AndroidSpatialObjectTrackingExtensionName =>
        "XR_ANDROID_spatial_object_tracking"u8;

    [NativeName("XR_ANDROID_spatial_discovery_raycast_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_discovery_raycast"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    public const int AndroidSpatialDiscoveryRaycastSpecVersion = 1;

    [NativeName("XR_ANDROID_SPATIAL_DISCOVERY_RAYCAST_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_discovery_raycast"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    public static Utf8String AndroidSpatialDiscoveryRaycastExtensionName =>
        "XR_ANDROID_spatial_discovery_raycast"u8;

    [NativeName("XR_ANDROID_spatial_entity_bound_anchor_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_entity_bound_anchor"],
        ImpliesSets = ["XR_EXT_spatial_anchor"]
    )]
    public const int AndroidSpatialEntityBoundAnchorSpecVersion = 2;

    [NativeName("XR_ANDROID_SPATIAL_ENTITY_BOUND_ANCHOR_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_entity_bound_anchor"],
        ImpliesSets = ["XR_EXT_spatial_anchor"]
    )]
    public static Utf8String AndroidSpatialEntityBoundAnchorExtensionName =>
        "XR_ANDROID_spatial_entity_bound_anchor"u8;

    [NativeName("XR_ANDROID_spatial_component_subsumed_by_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_component_subsumed_by"],
        ImpliesSets = ["XR_EXT_spatial_entity", "XR_EXT_spatial_plane_tracking"]
    )]
    public const int AndroidSpatialComponentSubsumedBySpecVersion = 1;

    [NativeName("XR_ANDROID_SPATIAL_COMPONENT_SUBSUMED_BY_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_component_subsumed_by"],
        ImpliesSets = ["XR_EXT_spatial_entity", "XR_EXT_spatial_plane_tracking"]
    )]
    public static Utf8String AndroidSpatialComponentSubsumedByExtensionName =>
        "XR_ANDROID_spatial_component_subsumed_by"u8;

    [NativeName("XR_ANDROID_spatial_anchor_space_SPEC_VERSION")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_anchor_space"],
        ImpliesSets = ["XR_EXT_spatial_anchor"]
    )]
    public const int AndroidSpatialAnchorSpaceSpecVersion = 1;

    [NativeName("XR_ANDROID_SPATIAL_ANCHOR_SPACE_EXTENSION_NAME")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_anchor_space"],
        ImpliesSets = ["XR_EXT_spatial_anchor"]
    )]
    public static Utf8String AndroidSpatialAnchorSpaceExtensionName =>
        "XR_ANDROID_spatial_anchor_space"u8;

    [NativeName("XR_EXT_interaction_profile_battery_state_display_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_EXT_interaction_profile_battery_state_display"])]
    public const int ExtInteractionProfileBatteryStateDisplaySpecVersion = 1;

    [NativeName("XR_EXT_INTERACTION_PROFILE_BATTERY_STATE_DISPLAY_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_EXT_interaction_profile_battery_state_display"])]
    public static Utf8String ExtInteractionProfileBatteryStateDisplayExtensionName =>
        "XR_EXT_interaction_profile_battery_state_display"u8;

    [NativeName("XR_EXT_loader_init_properties_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_EXT_loader_init_properties"])]
    public const int ExtLoaderInitPropertiesSpecVersion = 1;

    [NativeName("XR_EXT_LOADER_INIT_PROPERTIES_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_EXT_loader_init_properties"])]
    public static Utf8String ExtLoaderInitPropertiesExtensionName =>
        "XR_EXT_loader_init_properties"u8;

    [NativeName("XR_EXT_view_configuration_views_change_SPEC_VERSION")]
    [SupportedApiProfile("openxr", ["XR_EXT_view_configuration_views_change"])]
    public const int ExtViewConfigurationViewsChangeSpecVersion = 1;

    [NativeName("XR_EXT_VIEW_CONFIGURATION_VIEWS_CHANGE_EXTENSION_NAME")]
    [SupportedApiProfile("openxr", ["XR_EXT_view_configuration_views_change"])]
    public static Utf8String ExtViewConfigurationViewsChangeExtensionName =>
        "XR_EXT_view_configuration_views_change"u8;

    [NativeName("xrAcquireSwapchainImage")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrAcquireSwapchainImage")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.AcquireSwapchainImage(
        SwapchainHandle swapchain,
        SwapchainImageAcquireInfo* acquireInfo,
        uint* index
    ) =>
        (
            (delegate* unmanaged<SwapchainHandle, SwapchainImageAcquireInfo*, uint*, Result>)(
                _slots[0] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[0] = nativeContext.LoadFunction(
                        "xrAcquireSwapchainImage",
                        "openxr_loader"
                    )
            )
        )(swapchain, acquireInfo, index);

    [NativeName("xrAcquireSwapchainImage")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrAcquireSwapchainImage")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result AcquireSwapchainImage(
        SwapchainHandle swapchain,
        SwapchainImageAcquireInfo* acquireInfo,
        uint* index
    ) => ThisThread.AcquireSwapchainImage(swapchain, acquireInfo, index);

    [NativeName("xrAcquireSwapchainImage")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrAcquireSwapchainImage")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.AcquireSwapchainImage(
        SwapchainHandle swapchain,
        Ref<SwapchainImageAcquireInfo> acquireInfo,
        Ref<uint> index
    )
    {
        fixed (uint* __dsl_index = index)
        fixed (SwapchainImageAcquireInfo* __dsl_acquireInfo = acquireInfo)
        {
            return (Result)
                ((IXr)this).AcquireSwapchainImage(swapchain, __dsl_acquireInfo, __dsl_index);
        }
    }

    [NativeName("xrAcquireSwapchainImage")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrAcquireSwapchainImage")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result AcquireSwapchainImage(
        SwapchainHandle swapchain,
        Ref<SwapchainImageAcquireInfo> acquireInfo,
        Ref<uint> index
    ) => ThisThread.AcquireSwapchainImage(swapchain, acquireInfo, index);

    [NativeName("xrApplyHapticFeedback")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_haptic_parametric", "XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrApplyHapticFeedback")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.ApplyHapticFeedback(
        SessionHandle session,
        HapticActionInfo* hapticActionInfo,
        HapticBaseHeader* hapticFeedback
    ) =>
        (
            (delegate* unmanaged<SessionHandle, HapticActionInfo*, HapticBaseHeader*, Result>)(
                _slots[1] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[1] = nativeContext.LoadFunction(
                        "xrApplyHapticFeedback",
                        "openxr_loader"
                    )
            )
        )(session, hapticActionInfo, hapticFeedback);

    [NativeName("xrApplyHapticFeedback")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_haptic_parametric", "XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrApplyHapticFeedback")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result ApplyHapticFeedback(
        SessionHandle session,
        HapticActionInfo* hapticActionInfo,
        HapticBaseHeader* hapticFeedback
    ) => ThisThread.ApplyHapticFeedback(session, hapticActionInfo, hapticFeedback);

    [NativeName("xrApplyHapticFeedback")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_haptic_parametric", "XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrApplyHapticFeedback")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.ApplyHapticFeedback(
        SessionHandle session,
        Ref<HapticActionInfo> hapticActionInfo,
        Ref<HapticBaseHeader> hapticFeedback
    )
    {
        fixed (HapticBaseHeader* __dsl_hapticFeedback = hapticFeedback)
        fixed (HapticActionInfo* __dsl_hapticActionInfo = hapticActionInfo)
        {
            return (Result)
                ((IXr)this).ApplyHapticFeedback(
                    session,
                    __dsl_hapticActionInfo,
                    __dsl_hapticFeedback
                );
        }
    }

    [NativeName("xrApplyHapticFeedback")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_haptic_parametric", "XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrApplyHapticFeedback")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result ApplyHapticFeedback(
        SessionHandle session,
        Ref<HapticActionInfo> hapticActionInfo,
        Ref<HapticBaseHeader> hapticFeedback
    ) => ThisThread.ApplyHapticFeedback(session, hapticActionInfo, hapticFeedback);

    [NativeName("xrAttachSessionActionSets")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrAttachSessionActionSets")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.AttachSessionActionSets(
        SessionHandle session,
        SessionActionSetsAttachInfo* attachInfo
    ) =>
        (
            (delegate* unmanaged<SessionHandle, SessionActionSetsAttachInfo*, Result>)(
                _slots[2] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[2] = nativeContext.LoadFunction(
                        "xrAttachSessionActionSets",
                        "openxr_loader"
                    )
            )
        )(session, attachInfo);

    [NativeName("xrAttachSessionActionSets")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrAttachSessionActionSets")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result AttachSessionActionSets(
        SessionHandle session,
        SessionActionSetsAttachInfo* attachInfo
    ) => ThisThread.AttachSessionActionSets(session, attachInfo);

    [NativeName("xrAttachSessionActionSets")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrAttachSessionActionSets")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.AttachSessionActionSets(
        SessionHandle session,
        Ref<SessionActionSetsAttachInfo> attachInfo
    )
    {
        fixed (SessionActionSetsAttachInfo* __dsl_attachInfo = attachInfo)
        {
            return (Result)((IXr)this).AttachSessionActionSets(session, __dsl_attachInfo);
        }
    }

    [NativeName("xrAttachSessionActionSets")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrAttachSessionActionSets")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result AttachSessionActionSets(
        SessionHandle session,
        Ref<SessionActionSetsAttachInfo> attachInfo
    ) => ThisThread.AttachSessionActionSets(session, attachInfo);

    [NativeName("xrBeginFrame")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrBeginFrame")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.BeginFrame(SessionHandle session, FrameBeginInfo* frameBeginInfo) =>
        (
            (delegate* unmanaged<SessionHandle, FrameBeginInfo*, Result>)(
                _slots[3] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[3] = nativeContext.LoadFunction("xrBeginFrame", "openxr_loader")
            )
        )(session, frameBeginInfo);

    [NativeName("xrBeginFrame")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrBeginFrame")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result BeginFrame(SessionHandle session, FrameBeginInfo* frameBeginInfo) =>
        ThisThread.BeginFrame(session, frameBeginInfo);

    [NativeName("xrBeginFrame")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrBeginFrame")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.BeginFrame(SessionHandle session, Ref<FrameBeginInfo> frameBeginInfo)
    {
        fixed (FrameBeginInfo* __dsl_frameBeginInfo = frameBeginInfo)
        {
            return (Result)((IXr)this).BeginFrame(session, __dsl_frameBeginInfo);
        }
    }

    [NativeName("xrBeginFrame")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrBeginFrame")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result BeginFrame(SessionHandle session, Ref<FrameBeginInfo> frameBeginInfo) =>
        ThisThread.BeginFrame(session, frameBeginInfo);

    [NativeName("xrBeginSession")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrBeginSession")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.BeginSession(SessionHandle session, SessionBeginInfo* beginInfo) =>
        (
            (delegate* unmanaged<SessionHandle, SessionBeginInfo*, Result>)(
                _slots[4] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[4] = nativeContext.LoadFunction("xrBeginSession", "openxr_loader")
            )
        )(session, beginInfo);

    [NativeName("xrBeginSession")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrBeginSession")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result BeginSession(SessionHandle session, SessionBeginInfo* beginInfo) =>
        ThisThread.BeginSession(session, beginInfo);

    [NativeName("xrBeginSession")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrBeginSession")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.BeginSession(SessionHandle session, Ref<SessionBeginInfo> beginInfo)
    {
        fixed (SessionBeginInfo* __dsl_beginInfo = beginInfo)
        {
            return (Result)((IXr)this).BeginSession(session, __dsl_beginInfo);
        }
    }

    [NativeName("xrBeginSession")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrBeginSession")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result BeginSession(SessionHandle session, Ref<SessionBeginInfo> beginInfo) =>
        ThisThread.BeginSession(session, beginInfo);

    [NativeName("xrCreateAction")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateAction")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.CreateAction(
        ActionSetHandle actionSet,
        ActionCreateInfo* createInfo,
        ActionHandle* action
    ) =>
        (
            (delegate* unmanaged<ActionSetHandle, ActionCreateInfo*, ActionHandle*, Result>)(
                _slots[5] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[5] = nativeContext.LoadFunction("xrCreateAction", "openxr_loader")
            )
        )(actionSet, createInfo, action);

    [NativeName("xrCreateAction")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateAction")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result CreateAction(
        ActionSetHandle actionSet,
        ActionCreateInfo* createInfo,
        ActionHandle* action
    ) => ThisThread.CreateAction(actionSet, createInfo, action);

    [NativeName("xrCreateAction")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateAction")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.CreateAction(
        ActionSetHandle actionSet,
        Ref<ActionCreateInfo> createInfo,
        Ref<ActionHandle> action
    )
    {
        fixed (ActionHandle* __dsl_action = action)
        fixed (ActionCreateInfo* __dsl_createInfo = createInfo)
        {
            return (Result)((IXr)this).CreateAction(actionSet, __dsl_createInfo, __dsl_action);
        }
    }

    [NativeName("xrCreateAction")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateAction")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result CreateAction(
        ActionSetHandle actionSet,
        Ref<ActionCreateInfo> createInfo,
        Ref<ActionHandle> action
    ) => ThisThread.CreateAction(actionSet, createInfo, action);

    [NativeName("xrCreateActionSet")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateActionSet")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.CreateActionSet(
        InstanceHandle instance,
        ActionSetCreateInfo* createInfo,
        ActionSetHandle* actionSet
    ) =>
        (
            (delegate* unmanaged<InstanceHandle, ActionSetCreateInfo*, ActionSetHandle*, Result>)(
                _slots[6] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[6] = nativeContext.LoadFunction("xrCreateActionSet", "openxr_loader")
            )
        )(instance, createInfo, actionSet);

    [NativeName("xrCreateActionSet")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateActionSet")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result CreateActionSet(
        InstanceHandle instance,
        ActionSetCreateInfo* createInfo,
        ActionSetHandle* actionSet
    ) => ThisThread.CreateActionSet(instance, createInfo, actionSet);

    [NativeName("xrCreateActionSet")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateActionSet")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.CreateActionSet(
        InstanceHandle instance,
        Ref<ActionSetCreateInfo> createInfo,
        Ref<ActionSetHandle> actionSet
    )
    {
        fixed (ActionSetHandle* __dsl_actionSet = actionSet)
        fixed (ActionSetCreateInfo* __dsl_createInfo = createInfo)
        {
            return (Result)((IXr)this).CreateActionSet(instance, __dsl_createInfo, __dsl_actionSet);
        }
    }

    [NativeName("xrCreateActionSet")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateActionSet")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result CreateActionSet(
        InstanceHandle instance,
        Ref<ActionSetCreateInfo> createInfo,
        Ref<ActionSetHandle> actionSet
    ) => ThisThread.CreateActionSet(instance, createInfo, actionSet);

    [NativeName("xrCreateActionSpace")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateActionSpace")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.CreateActionSpace(
        SessionHandle session,
        ActionSpaceCreateInfo* createInfo,
        SpaceHandle* space
    ) =>
        (
            (delegate* unmanaged<SessionHandle, ActionSpaceCreateInfo*, SpaceHandle*, Result>)(
                _slots[7] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[7] = nativeContext.LoadFunction("xrCreateActionSpace", "openxr_loader")
            )
        )(session, createInfo, space);

    [NativeName("xrCreateActionSpace")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateActionSpace")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result CreateActionSpace(
        SessionHandle session,
        ActionSpaceCreateInfo* createInfo,
        SpaceHandle* space
    ) => ThisThread.CreateActionSpace(session, createInfo, space);

    [NativeName("xrCreateActionSpace")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateActionSpace")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.CreateActionSpace(
        SessionHandle session,
        Ref<ActionSpaceCreateInfo> createInfo,
        Ref<SpaceHandle> space
    )
    {
        fixed (SpaceHandle* __dsl_space = space)
        fixed (ActionSpaceCreateInfo* __dsl_createInfo = createInfo)
        {
            return (Result)((IXr)this).CreateActionSpace(session, __dsl_createInfo, __dsl_space);
        }
    }

    [NativeName("xrCreateActionSpace")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateActionSpace")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result CreateActionSpace(
        SessionHandle session,
        Ref<ActionSpaceCreateInfo> createInfo,
        Ref<SpaceHandle> space
    ) => ThisThread.CreateActionSpace(session, createInfo, space);

    [NativeName("xrCreateInstance")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateInstance")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result CreateInstance(InstanceCreateInfo* createInfo, InstanceHandle* instance) =>
        ThisThread.CreateInstance(createInfo, instance);

    [NativeName("xrCreateInstance")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateInstance")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.CreateInstance(Ref<InstanceCreateInfo> createInfo, Ref<InstanceHandle> instance)
    {
        fixed (InstanceHandle* __dsl_instance = instance)
        fixed (InstanceCreateInfo* __dsl_createInfo = createInfo)
        {
            return (Result)((IXr)this).CreateInstance(__dsl_createInfo, __dsl_instance);
        }
    }

    [NativeName("xrCreateInstance")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateInstance")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result CreateInstance(
        Ref<InstanceCreateInfo> createInfo,
        Ref<InstanceHandle> instance
    ) => ThisThread.CreateInstance(createInfo, instance);

    [NativeName("xrCreateInstance")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateInstance")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private Result CreateInstanceInternal(
        InstanceCreateInfo* createInfo,
        InstanceHandle* instance
    ) =>
        (
            (delegate* unmanaged<InstanceCreateInfo*, InstanceHandle*, Result>)(
                _slots[8] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[8] = nativeContext.LoadFunction("xrCreateInstance", "openxr_loader")
            )
        )(createInfo, instance);

    [NativeName("xrCreateInstance")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateInstance")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private Result CreateInstanceInternal(
        Ref<InstanceCreateInfo> createInfo,
        Ref<InstanceHandle> instance
    )
    {
        fixed (InstanceHandle* __dsl_instance = instance)
        fixed (InstanceCreateInfo* __dsl_createInfo = createInfo)
        {
            return (Result)CreateInstanceInternal(__dsl_createInfo, __dsl_instance);
        }
    }

    [NativeName("xrCreateReferenceSpace")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateReferenceSpace")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.CreateReferenceSpace(
        SessionHandle session,
        ReferenceSpaceCreateInfo* createInfo,
        SpaceHandle* space
    ) =>
        (
            (delegate* unmanaged<SessionHandle, ReferenceSpaceCreateInfo*, SpaceHandle*, Result>)(
                _slots[9] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[9] = nativeContext.LoadFunction(
                        "xrCreateReferenceSpace",
                        "openxr_loader"
                    )
            )
        )(session, createInfo, space);

    [NativeName("xrCreateReferenceSpace")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateReferenceSpace")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result CreateReferenceSpace(
        SessionHandle session,
        ReferenceSpaceCreateInfo* createInfo,
        SpaceHandle* space
    ) => ThisThread.CreateReferenceSpace(session, createInfo, space);

    [NativeName("xrCreateReferenceSpace")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateReferenceSpace")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.CreateReferenceSpace(
        SessionHandle session,
        Ref<ReferenceSpaceCreateInfo> createInfo,
        Ref<SpaceHandle> space
    )
    {
        fixed (SpaceHandle* __dsl_space = space)
        fixed (ReferenceSpaceCreateInfo* __dsl_createInfo = createInfo)
        {
            return (Result)((IXr)this).CreateReferenceSpace(session, __dsl_createInfo, __dsl_space);
        }
    }

    [NativeName("xrCreateReferenceSpace")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateReferenceSpace")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result CreateReferenceSpace(
        SessionHandle session,
        Ref<ReferenceSpaceCreateInfo> createInfo,
        Ref<SpaceHandle> space
    ) => ThisThread.CreateReferenceSpace(session, createInfo, space);

    [NativeName("xrCreateSession")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateSession")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.CreateSession(
        InstanceHandle instance,
        SessionCreateInfo* createInfo,
        SessionHandle* session
    ) =>
        (
            (delegate* unmanaged<InstanceHandle, SessionCreateInfo*, SessionHandle*, Result>)(
                _slots[10] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[10] = nativeContext.LoadFunction("xrCreateSession", "openxr_loader")
            )
        )(instance, createInfo, session);

    [NativeName("xrCreateSession")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateSession")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result CreateSession(
        InstanceHandle instance,
        SessionCreateInfo* createInfo,
        SessionHandle* session
    ) => ThisThread.CreateSession(instance, createInfo, session);

    [NativeName("xrCreateSession")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateSession")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.CreateSession(
        InstanceHandle instance,
        Ref<SessionCreateInfo> createInfo,
        Ref<SessionHandle> session
    )
    {
        fixed (SessionHandle* __dsl_session = session)
        fixed (SessionCreateInfo* __dsl_createInfo = createInfo)
        {
            return (Result)((IXr)this).CreateSession(instance, __dsl_createInfo, __dsl_session);
        }
    }

    [NativeName("xrCreateSession")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateSession")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result CreateSession(
        InstanceHandle instance,
        Ref<SessionCreateInfo> createInfo,
        Ref<SessionHandle> session
    ) => ThisThread.CreateSession(instance, createInfo, session);

    [NativeName("xrCreateSwapchain")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateSwapchain")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.CreateSwapchain(
        SessionHandle session,
        SwapchainCreateInfo* createInfo,
        SwapchainHandle* swapchain
    ) =>
        (
            (delegate* unmanaged<SessionHandle, SwapchainCreateInfo*, SwapchainHandle*, Result>)(
                _slots[11] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[11] = nativeContext.LoadFunction("xrCreateSwapchain", "openxr_loader")
            )
        )(session, createInfo, swapchain);

    [NativeName("xrCreateSwapchain")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateSwapchain")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result CreateSwapchain(
        SessionHandle session,
        SwapchainCreateInfo* createInfo,
        SwapchainHandle* swapchain
    ) => ThisThread.CreateSwapchain(session, createInfo, swapchain);

    [NativeName("xrCreateSwapchain")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateSwapchain")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.CreateSwapchain(
        SessionHandle session,
        Ref<SwapchainCreateInfo> createInfo,
        Ref<SwapchainHandle> swapchain
    )
    {
        fixed (SwapchainHandle* __dsl_swapchain = swapchain)
        fixed (SwapchainCreateInfo* __dsl_createInfo = createInfo)
        {
            return (Result)((IXr)this).CreateSwapchain(session, __dsl_createInfo, __dsl_swapchain);
        }
    }

    [NativeName("xrCreateSwapchain")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrCreateSwapchain")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result CreateSwapchain(
        SessionHandle session,
        Ref<SwapchainCreateInfo> createInfo,
        Ref<SwapchainHandle> swapchain
    ) => ThisThread.CreateSwapchain(session, createInfo, swapchain);

    [NativeName("xrDestroyAction")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrDestroyAction")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.DestroyAction(ActionHandle action) =>
        (
            (delegate* unmanaged<ActionHandle, Result>)(
                _slots[12] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[12] = nativeContext.LoadFunction("xrDestroyAction", "openxr_loader")
            )
        )(action);

    [NativeName("xrDestroyAction")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrDestroyAction")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result DestroyAction(ActionHandle action) => ThisThread.DestroyAction(action);

    [NativeName("xrDestroyActionSet")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrDestroyActionSet")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.DestroyActionSet(ActionSetHandle actionSet) =>
        (
            (delegate* unmanaged<ActionSetHandle, Result>)(
                _slots[13] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[13] = nativeContext.LoadFunction("xrDestroyActionSet", "openxr_loader")
            )
        )(actionSet);

    [NativeName("xrDestroyActionSet")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrDestroyActionSet")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result DestroyActionSet(ActionSetHandle actionSet) =>
        ThisThread.DestroyActionSet(actionSet);

    [NativeName("xrDestroyInstance")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrDestroyInstance")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.DestroyInstance(InstanceHandle instance) =>
        (
            (delegate* unmanaged<InstanceHandle, Result>)(
                _slots[14] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[14] = nativeContext.LoadFunction("xrDestroyInstance", "openxr_loader")
            )
        )(instance);

    [NativeName("xrDestroyInstance")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrDestroyInstance")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result DestroyInstance(InstanceHandle instance) =>
        ThisThread.DestroyInstance(instance);

    [NativeName("xrDestroySession")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrDestroySession")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.DestroySession(SessionHandle session) =>
        (
            (delegate* unmanaged<SessionHandle, Result>)(
                _slots[15] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[15] = nativeContext.LoadFunction("xrDestroySession", "openxr_loader")
            )
        )(session);

    [NativeName("xrDestroySession")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrDestroySession")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result DestroySession(SessionHandle session) =>
        ThisThread.DestroySession(session);

    [NativeName("xrDestroySpace")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrDestroySpace")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.DestroySpace(SpaceHandle space) =>
        (
            (delegate* unmanaged<SpaceHandle, Result>)(
                _slots[16] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[16] = nativeContext.LoadFunction("xrDestroySpace", "openxr_loader")
            )
        )(space);

    [NativeName("xrDestroySpace")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrDestroySpace")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result DestroySpace(SpaceHandle space) => ThisThread.DestroySpace(space);

    [NativeName("xrDestroySwapchain")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrDestroySwapchain")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.DestroySwapchain(SwapchainHandle swapchain) =>
        (
            (delegate* unmanaged<SwapchainHandle, Result>)(
                _slots[17] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[17] = nativeContext.LoadFunction("xrDestroySwapchain", "openxr_loader")
            )
        )(swapchain);

    [NativeName("xrDestroySwapchain")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrDestroySwapchain")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result DestroySwapchain(SwapchainHandle swapchain) =>
        ThisThread.DestroySwapchain(swapchain);

    [NativeName("xrEndFrame")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEndFrame")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.EndFrame(SessionHandle session, FrameEndInfo* frameEndInfo) =>
        (
            (delegate* unmanaged<SessionHandle, FrameEndInfo*, Result>)(
                _slots[18] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[18] = nativeContext.LoadFunction("xrEndFrame", "openxr_loader")
            )
        )(session, frameEndInfo);

    [NativeName("xrEndFrame")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEndFrame")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result EndFrame(SessionHandle session, FrameEndInfo* frameEndInfo) =>
        ThisThread.EndFrame(session, frameEndInfo);

    [NativeName("xrEndFrame")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEndFrame")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.EndFrame(SessionHandle session, Ref<FrameEndInfo> frameEndInfo)
    {
        fixed (FrameEndInfo* __dsl_frameEndInfo = frameEndInfo)
        {
            return (Result)((IXr)this).EndFrame(session, __dsl_frameEndInfo);
        }
    }

    [NativeName("xrEndFrame")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEndFrame")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result EndFrame(SessionHandle session, Ref<FrameEndInfo> frameEndInfo) =>
        ThisThread.EndFrame(session, frameEndInfo);

    [NativeName("xrEndSession")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEndSession")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.EndSession(SessionHandle session) =>
        (
            (delegate* unmanaged<SessionHandle, Result>)(
                _slots[19] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[19] = nativeContext.LoadFunction("xrEndSession", "openxr_loader")
            )
        )(session);

    [NativeName("xrEndSession")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEndSession")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result EndSession(SessionHandle session) => ThisThread.EndSession(session);

    [NativeName("xrEnumerateApiLayerProperties")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateApiLayerProperties")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.EnumerateApiLayerProperties(
        uint propertyCapacityInput,
        uint* propertyCountOutput,
        ApiLayerProperties* properties
    ) =>
        (
            (delegate* unmanaged<uint, uint*, ApiLayerProperties*, Result>)(
                _slots[20] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[20] = nativeContext.LoadFunction(
                        "xrEnumerateApiLayerProperties",
                        "openxr_loader"
                    )
            )
        )(propertyCapacityInput, propertyCountOutput, properties);

    [NativeName("xrEnumerateApiLayerProperties")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateApiLayerProperties")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result EnumerateApiLayerProperties(
        uint propertyCapacityInput,
        uint* propertyCountOutput,
        ApiLayerProperties* properties
    ) =>
        ThisThread.EnumerateApiLayerProperties(
            propertyCapacityInput,
            propertyCountOutput,
            properties
        );

    [NativeName("xrEnumerateApiLayerProperties")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateApiLayerProperties")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.EnumerateApiLayerProperties(
        uint propertyCapacityInput,
        Ref<uint> propertyCountOutput,
        Ref<ApiLayerProperties> properties
    )
    {
        fixed (ApiLayerProperties* __dsl_properties = properties)
        fixed (uint* __dsl_propertyCountOutput = propertyCountOutput)
        {
            return (Result)
                ((IXr)this).EnumerateApiLayerProperties(
                    propertyCapacityInput,
                    __dsl_propertyCountOutput,
                    __dsl_properties
                );
        }
    }

    [NativeName("xrEnumerateApiLayerProperties")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateApiLayerProperties")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result EnumerateApiLayerProperties(
        uint propertyCapacityInput,
        Ref<uint> propertyCountOutput,
        Ref<ApiLayerProperties> properties
    ) =>
        ThisThread.EnumerateApiLayerProperties(
            propertyCapacityInput,
            propertyCountOutput,
            properties
        );

    [NativeName("xrEnumerateBoundSourcesForAction")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateBoundSourcesForAction")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.EnumerateBoundSourcesForAction(
        SessionHandle session,
        BoundSourcesForActionEnumerateInfo* enumerateInfo,
        uint sourceCapacityInput,
        uint* sourceCountOutput,
        ulong* sources
    ) =>
        (
            (delegate* unmanaged<
                SessionHandle,
                BoundSourcesForActionEnumerateInfo*,
                uint,
                uint*,
                ulong*,
                Result>)(
                _slots[21] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[21] = nativeContext.LoadFunction(
                        "xrEnumerateBoundSourcesForAction",
                        "openxr_loader"
                    )
            )
        )(session, enumerateInfo, sourceCapacityInput, sourceCountOutput, sources);

    [NativeName("xrEnumerateBoundSourcesForAction")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateBoundSourcesForAction")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result EnumerateBoundSourcesForAction(
        SessionHandle session,
        BoundSourcesForActionEnumerateInfo* enumerateInfo,
        uint sourceCapacityInput,
        uint* sourceCountOutput,
        ulong* sources
    ) =>
        ThisThread.EnumerateBoundSourcesForAction(
            session,
            enumerateInfo,
            sourceCapacityInput,
            sourceCountOutput,
            sources
        );

    [NativeName("xrEnumerateBoundSourcesForAction")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateBoundSourcesForAction")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.EnumerateBoundSourcesForAction(
        SessionHandle session,
        Ref<BoundSourcesForActionEnumerateInfo> enumerateInfo,
        uint sourceCapacityInput,
        Ref<uint> sourceCountOutput,
        Ref<ulong> sources
    )
    {
        fixed (ulong* __dsl_sources = sources)
        fixed (uint* __dsl_sourceCountOutput = sourceCountOutput)
        fixed (BoundSourcesForActionEnumerateInfo* __dsl_enumerateInfo = enumerateInfo)
        {
            return (Result)
                ((IXr)this).EnumerateBoundSourcesForAction(
                    session,
                    __dsl_enumerateInfo,
                    sourceCapacityInput,
                    __dsl_sourceCountOutput,
                    __dsl_sources
                );
        }
    }

    [NativeName("xrEnumerateBoundSourcesForAction")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateBoundSourcesForAction")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result EnumerateBoundSourcesForAction(
        SessionHandle session,
        Ref<BoundSourcesForActionEnumerateInfo> enumerateInfo,
        uint sourceCapacityInput,
        Ref<uint> sourceCountOutput,
        Ref<ulong> sources
    ) =>
        ThisThread.EnumerateBoundSourcesForAction(
            session,
            enumerateInfo,
            sourceCapacityInput,
            sourceCountOutput,
            sources
        );

    [NativeName("xrEnumerateEnvironmentBlendModes")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateEnvironmentBlendModes")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.EnumerateEnvironmentBlendModes(
        InstanceHandle instance,
        ulong systemId,
        ViewConfigurationType viewConfigurationType,
        uint environmentBlendModeCapacityInput,
        uint* environmentBlendModeCountOutput,
        EnvironmentBlendMode* environmentBlendModes
    ) =>
        (
            (delegate* unmanaged<
                InstanceHandle,
                ulong,
                ViewConfigurationType,
                uint,
                uint*,
                EnvironmentBlendMode*,
                Result>)(
                _slots[22] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[22] = nativeContext.LoadFunction(
                        "xrEnumerateEnvironmentBlendModes",
                        "openxr_loader"
                    )
            )
        )(
            instance,
            systemId,
            viewConfigurationType,
            environmentBlendModeCapacityInput,
            environmentBlendModeCountOutput,
            environmentBlendModes
        );

    [NativeName("xrEnumerateEnvironmentBlendModes")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateEnvironmentBlendModes")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result EnumerateEnvironmentBlendModes(
        InstanceHandle instance,
        ulong systemId,
        ViewConfigurationType viewConfigurationType,
        uint environmentBlendModeCapacityInput,
        uint* environmentBlendModeCountOutput,
        EnvironmentBlendMode* environmentBlendModes
    ) =>
        ThisThread.EnumerateEnvironmentBlendModes(
            instance,
            systemId,
            viewConfigurationType,
            environmentBlendModeCapacityInput,
            environmentBlendModeCountOutput,
            environmentBlendModes
        );

    [NativeName("xrEnumerateEnvironmentBlendModes")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateEnvironmentBlendModes")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.EnumerateEnvironmentBlendModes(
        InstanceHandle instance,
        ulong systemId,
        ViewConfigurationType viewConfigurationType,
        uint environmentBlendModeCapacityInput,
        Ref<uint> environmentBlendModeCountOutput,
        Ref<EnvironmentBlendMode> environmentBlendModes
    )
    {
        fixed (EnvironmentBlendMode* __dsl_environmentBlendModes = environmentBlendModes)
        fixed (uint* __dsl_environmentBlendModeCountOutput = environmentBlendModeCountOutput)
        {
            return (Result)
                ((IXr)this).EnumerateEnvironmentBlendModes(
                    instance,
                    systemId,
                    viewConfigurationType,
                    environmentBlendModeCapacityInput,
                    __dsl_environmentBlendModeCountOutput,
                    __dsl_environmentBlendModes
                );
        }
    }

    [NativeName("xrEnumerateEnvironmentBlendModes")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateEnvironmentBlendModes")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result EnumerateEnvironmentBlendModes(
        InstanceHandle instance,
        ulong systemId,
        ViewConfigurationType viewConfigurationType,
        uint environmentBlendModeCapacityInput,
        Ref<uint> environmentBlendModeCountOutput,
        Ref<EnvironmentBlendMode> environmentBlendModes
    ) =>
        ThisThread.EnumerateEnvironmentBlendModes(
            instance,
            systemId,
            viewConfigurationType,
            environmentBlendModeCapacityInput,
            environmentBlendModeCountOutput,
            environmentBlendModes
        );

    [NativeName("xrEnumerateInstanceExtensionProperties")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateInstanceExtensionProperties")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.EnumerateInstanceExtensionProperties(
        sbyte* layerName,
        uint propertyCapacityInput,
        uint* propertyCountOutput,
        ExtensionProperties* properties
    ) =>
        (
            (delegate* unmanaged<sbyte*, uint, uint*, ExtensionProperties*, Result>)(
                _slots[23] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[23] = nativeContext.LoadFunction(
                        "xrEnumerateInstanceExtensionProperties",
                        "openxr_loader"
                    )
            )
        )(layerName, propertyCapacityInput, propertyCountOutput, properties);

    [NativeName("xrEnumerateInstanceExtensionProperties")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateInstanceExtensionProperties")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result EnumerateInstanceExtensionProperties(
        sbyte* layerName,
        uint propertyCapacityInput,
        uint* propertyCountOutput,
        ExtensionProperties* properties
    ) =>
        ThisThread.EnumerateInstanceExtensionProperties(
            layerName,
            propertyCapacityInput,
            propertyCountOutput,
            properties
        );

    [NativeName("xrEnumerateInstanceExtensionProperties")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateInstanceExtensionProperties")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.EnumerateInstanceExtensionProperties(
        Ref<sbyte> layerName,
        uint propertyCapacityInput,
        Ref<uint> propertyCountOutput,
        Ref<ExtensionProperties> properties
    )
    {
        fixed (ExtensionProperties* __dsl_properties = properties)
        fixed (uint* __dsl_propertyCountOutput = propertyCountOutput)
        fixed (sbyte* __dsl_layerName = layerName)
        {
            return (Result)
                ((IXr)this).EnumerateInstanceExtensionProperties(
                    __dsl_layerName,
                    propertyCapacityInput,
                    __dsl_propertyCountOutput,
                    __dsl_properties
                );
        }
    }

    [NativeName("xrEnumerateInstanceExtensionProperties")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateInstanceExtensionProperties")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result EnumerateInstanceExtensionProperties(
        Ref<sbyte> layerName,
        uint propertyCapacityInput,
        Ref<uint> propertyCountOutput,
        Ref<ExtensionProperties> properties
    ) =>
        ThisThread.EnumerateInstanceExtensionProperties(
            layerName,
            propertyCapacityInput,
            propertyCountOutput,
            properties
        );

    [NativeName("xrEnumerateReferenceSpaces")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateReferenceSpaces")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.EnumerateReferenceSpaces(
        SessionHandle session,
        uint spaceCapacityInput,
        uint* spaceCountOutput,
        ReferenceSpaceType* spaces
    ) =>
        (
            (delegate* unmanaged<SessionHandle, uint, uint*, ReferenceSpaceType*, Result>)(
                _slots[24] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[24] = nativeContext.LoadFunction(
                        "xrEnumerateReferenceSpaces",
                        "openxr_loader"
                    )
            )
        )(session, spaceCapacityInput, spaceCountOutput, spaces);

    [NativeName("xrEnumerateReferenceSpaces")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateReferenceSpaces")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result EnumerateReferenceSpaces(
        SessionHandle session,
        uint spaceCapacityInput,
        uint* spaceCountOutput,
        ReferenceSpaceType* spaces
    ) => ThisThread.EnumerateReferenceSpaces(session, spaceCapacityInput, spaceCountOutput, spaces);

    [NativeName("xrEnumerateReferenceSpaces")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateReferenceSpaces")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.EnumerateReferenceSpaces(
        SessionHandle session,
        uint spaceCapacityInput,
        Ref<uint> spaceCountOutput,
        Ref<ReferenceSpaceType> spaces
    )
    {
        fixed (ReferenceSpaceType* __dsl_spaces = spaces)
        fixed (uint* __dsl_spaceCountOutput = spaceCountOutput)
        {
            return (Result)
                ((IXr)this).EnumerateReferenceSpaces(
                    session,
                    spaceCapacityInput,
                    __dsl_spaceCountOutput,
                    __dsl_spaces
                );
        }
    }

    [NativeName("xrEnumerateReferenceSpaces")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateReferenceSpaces")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result EnumerateReferenceSpaces(
        SessionHandle session,
        uint spaceCapacityInput,
        Ref<uint> spaceCountOutput,
        Ref<ReferenceSpaceType> spaces
    ) => ThisThread.EnumerateReferenceSpaces(session, spaceCapacityInput, spaceCountOutput, spaces);

    [NativeName("xrEnumerateSwapchainFormats")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateSwapchainFormats")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.EnumerateSwapchainFormats(
        SessionHandle session,
        uint formatCapacityInput,
        uint* formatCountOutput,
        long* formats
    ) =>
        (
            (delegate* unmanaged<SessionHandle, uint, uint*, long*, Result>)(
                _slots[25] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[25] = nativeContext.LoadFunction(
                        "xrEnumerateSwapchainFormats",
                        "openxr_loader"
                    )
            )
        )(session, formatCapacityInput, formatCountOutput, formats);

    [NativeName("xrEnumerateSwapchainFormats")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateSwapchainFormats")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result EnumerateSwapchainFormats(
        SessionHandle session,
        uint formatCapacityInput,
        uint* formatCountOutput,
        long* formats
    ) =>
        ThisThread.EnumerateSwapchainFormats(
            session,
            formatCapacityInput,
            formatCountOutput,
            formats
        );

    [NativeName("xrEnumerateSwapchainFormats")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateSwapchainFormats")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.EnumerateSwapchainFormats(
        SessionHandle session,
        uint formatCapacityInput,
        Ref<uint> formatCountOutput,
        Ref<long> formats
    )
    {
        fixed (long* __dsl_formats = formats)
        fixed (uint* __dsl_formatCountOutput = formatCountOutput)
        {
            return (Result)
                ((IXr)this).EnumerateSwapchainFormats(
                    session,
                    formatCapacityInput,
                    __dsl_formatCountOutput,
                    __dsl_formats
                );
        }
    }

    [NativeName("xrEnumerateSwapchainFormats")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateSwapchainFormats")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result EnumerateSwapchainFormats(
        SessionHandle session,
        uint formatCapacityInput,
        Ref<uint> formatCountOutput,
        Ref<long> formats
    ) =>
        ThisThread.EnumerateSwapchainFormats(
            session,
            formatCapacityInput,
            formatCountOutput,
            formats
        );

    [NativeName("xrEnumerateSwapchainImages")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateSwapchainImages")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.EnumerateSwapchainImages(
        SwapchainHandle swapchain,
        uint imageCapacityInput,
        uint* imageCountOutput,
        SwapchainImageBaseHeader* images
    ) =>
        (
            (delegate* unmanaged<SwapchainHandle, uint, uint*, SwapchainImageBaseHeader*, Result>)(
                _slots[26] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[26] = nativeContext.LoadFunction(
                        "xrEnumerateSwapchainImages",
                        "openxr_loader"
                    )
            )
        )(swapchain, imageCapacityInput, imageCountOutput, images);

    [NativeName("xrEnumerateSwapchainImages")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateSwapchainImages")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result EnumerateSwapchainImages(
        SwapchainHandle swapchain,
        uint imageCapacityInput,
        uint* imageCountOutput,
        SwapchainImageBaseHeader* images
    ) =>
        ThisThread.EnumerateSwapchainImages(
            swapchain,
            imageCapacityInput,
            imageCountOutput,
            images
        );

    [NativeName("xrEnumerateSwapchainImages")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateSwapchainImages")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.EnumerateSwapchainImages(
        SwapchainHandle swapchain,
        uint imageCapacityInput,
        Ref<uint> imageCountOutput,
        Ref<SwapchainImageBaseHeader> images
    )
    {
        fixed (SwapchainImageBaseHeader* __dsl_images = images)
        fixed (uint* __dsl_imageCountOutput = imageCountOutput)
        {
            return (Result)
                ((IXr)this).EnumerateSwapchainImages(
                    swapchain,
                    imageCapacityInput,
                    __dsl_imageCountOutput,
                    __dsl_images
                );
        }
    }

    [NativeName("xrEnumerateSwapchainImages")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateSwapchainImages")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result EnumerateSwapchainImages(
        SwapchainHandle swapchain,
        uint imageCapacityInput,
        Ref<uint> imageCountOutput,
        Ref<SwapchainImageBaseHeader> images
    ) =>
        ThisThread.EnumerateSwapchainImages(
            swapchain,
            imageCapacityInput,
            imageCountOutput,
            images
        );

    [NativeName("xrEnumerateViewConfigurations")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateViewConfigurations")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.EnumerateViewConfigurations(
        InstanceHandle instance,
        ulong systemId,
        uint viewConfigurationTypeCapacityInput,
        uint* viewConfigurationTypeCountOutput,
        ViewConfigurationType* viewConfigurationTypes
    ) =>
        (
            (delegate* unmanaged<
                InstanceHandle,
                ulong,
                uint,
                uint*,
                ViewConfigurationType*,
                Result>)(
                _slots[27] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[27] = nativeContext.LoadFunction(
                        "xrEnumerateViewConfigurations",
                        "openxr_loader"
                    )
            )
        )(
            instance,
            systemId,
            viewConfigurationTypeCapacityInput,
            viewConfigurationTypeCountOutput,
            viewConfigurationTypes
        );

    [NativeName("xrEnumerateViewConfigurations")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateViewConfigurations")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result EnumerateViewConfigurations(
        InstanceHandle instance,
        ulong systemId,
        uint viewConfigurationTypeCapacityInput,
        uint* viewConfigurationTypeCountOutput,
        ViewConfigurationType* viewConfigurationTypes
    ) =>
        ThisThread.EnumerateViewConfigurations(
            instance,
            systemId,
            viewConfigurationTypeCapacityInput,
            viewConfigurationTypeCountOutput,
            viewConfigurationTypes
        );

    [NativeName("xrEnumerateViewConfigurations")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateViewConfigurations")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.EnumerateViewConfigurations(
        InstanceHandle instance,
        ulong systemId,
        uint viewConfigurationTypeCapacityInput,
        Ref<uint> viewConfigurationTypeCountOutput,
        Ref<ViewConfigurationType> viewConfigurationTypes
    )
    {
        fixed (ViewConfigurationType* __dsl_viewConfigurationTypes = viewConfigurationTypes)
        fixed (uint* __dsl_viewConfigurationTypeCountOutput = viewConfigurationTypeCountOutput)
        {
            return (Result)
                ((IXr)this).EnumerateViewConfigurations(
                    instance,
                    systemId,
                    viewConfigurationTypeCapacityInput,
                    __dsl_viewConfigurationTypeCountOutput,
                    __dsl_viewConfigurationTypes
                );
        }
    }

    [NativeName("xrEnumerateViewConfigurations")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateViewConfigurations")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result EnumerateViewConfigurations(
        InstanceHandle instance,
        ulong systemId,
        uint viewConfigurationTypeCapacityInput,
        Ref<uint> viewConfigurationTypeCountOutput,
        Ref<ViewConfigurationType> viewConfigurationTypes
    ) =>
        ThisThread.EnumerateViewConfigurations(
            instance,
            systemId,
            viewConfigurationTypeCapacityInput,
            viewConfigurationTypeCountOutput,
            viewConfigurationTypes
        );

    [NativeName("xrEnumerateViewConfigurationViews")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateViewConfigurationViews")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.EnumerateViewConfigurationViews(
        InstanceHandle instance,
        ulong systemId,
        ViewConfigurationType viewConfigurationType,
        uint viewCapacityInput,
        uint* viewCountOutput,
        ViewConfigurationView* views
    ) =>
        (
            (delegate* unmanaged<
                InstanceHandle,
                ulong,
                ViewConfigurationType,
                uint,
                uint*,
                ViewConfigurationView*,
                Result>)(
                _slots[28] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[28] = nativeContext.LoadFunction(
                        "xrEnumerateViewConfigurationViews",
                        "openxr_loader"
                    )
            )
        )(instance, systemId, viewConfigurationType, viewCapacityInput, viewCountOutput, views);

    [NativeName("xrEnumerateViewConfigurationViews")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateViewConfigurationViews")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result EnumerateViewConfigurationViews(
        InstanceHandle instance,
        ulong systemId,
        ViewConfigurationType viewConfigurationType,
        uint viewCapacityInput,
        uint* viewCountOutput,
        ViewConfigurationView* views
    ) =>
        ThisThread.EnumerateViewConfigurationViews(
            instance,
            systemId,
            viewConfigurationType,
            viewCapacityInput,
            viewCountOutput,
            views
        );

    [NativeName("xrEnumerateViewConfigurationViews")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateViewConfigurationViews")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.EnumerateViewConfigurationViews(
        InstanceHandle instance,
        ulong systemId,
        ViewConfigurationType viewConfigurationType,
        uint viewCapacityInput,
        Ref<uint> viewCountOutput,
        Ref<ViewConfigurationView> views
    )
    {
        fixed (ViewConfigurationView* __dsl_views = views)
        fixed (uint* __dsl_viewCountOutput = viewCountOutput)
        {
            return (Result)
                ((IXr)this).EnumerateViewConfigurationViews(
                    instance,
                    systemId,
                    viewConfigurationType,
                    viewCapacityInput,
                    __dsl_viewCountOutput,
                    __dsl_views
                );
        }
    }

    [NativeName("xrEnumerateViewConfigurationViews")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrEnumerateViewConfigurationViews")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result EnumerateViewConfigurationViews(
        InstanceHandle instance,
        ulong systemId,
        ViewConfigurationType viewConfigurationType,
        uint viewCapacityInput,
        Ref<uint> viewCountOutput,
        Ref<ViewConfigurationView> views
    ) =>
        ThisThread.EnumerateViewConfigurationViews(
            instance,
            systemId,
            viewConfigurationType,
            viewCapacityInput,
            viewCountOutput,
            views
        );

    [NativeName("xrGetActionStateBoolean")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateBoolean")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.GetActionStateBoolean(
        SessionHandle session,
        ActionStateGetInfo* getInfo,
        ActionStateBoolean* state
    ) =>
        (
            (delegate* unmanaged<SessionHandle, ActionStateGetInfo*, ActionStateBoolean*, Result>)(
                _slots[29] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[29] = nativeContext.LoadFunction(
                        "xrGetActionStateBoolean",
                        "openxr_loader"
                    )
            )
        )(session, getInfo, state);

    [NativeName("xrGetActionStateBoolean")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateBoolean")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result GetActionStateBoolean(
        SessionHandle session,
        ActionStateGetInfo* getInfo,
        ActionStateBoolean* state
    ) => ThisThread.GetActionStateBoolean(session, getInfo, state);

    [NativeName("xrGetActionStateBoolean")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateBoolean")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.GetActionStateBoolean(
        SessionHandle session,
        Ref<ActionStateGetInfo> getInfo,
        Ref<ActionStateBoolean> state
    )
    {
        fixed (ActionStateBoolean* __dsl_state = state)
        fixed (ActionStateGetInfo* __dsl_getInfo = getInfo)
        {
            return (Result)((IXr)this).GetActionStateBoolean(session, __dsl_getInfo, __dsl_state);
        }
    }

    [NativeName("xrGetActionStateBoolean")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateBoolean")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result GetActionStateBoolean(
        SessionHandle session,
        Ref<ActionStateGetInfo> getInfo,
        Ref<ActionStateBoolean> state
    ) => ThisThread.GetActionStateBoolean(session, getInfo, state);

    [NativeName("xrGetActionStateFloat")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateFloat")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.GetActionStateFloat(
        SessionHandle session,
        ActionStateGetInfo* getInfo,
        ActionStateFloat* state
    ) =>
        (
            (delegate* unmanaged<SessionHandle, ActionStateGetInfo*, ActionStateFloat*, Result>)(
                _slots[30] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[30] = nativeContext.LoadFunction(
                        "xrGetActionStateFloat",
                        "openxr_loader"
                    )
            )
        )(session, getInfo, state);

    [NativeName("xrGetActionStateFloat")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateFloat")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result GetActionStateFloat(
        SessionHandle session,
        ActionStateGetInfo* getInfo,
        ActionStateFloat* state
    ) => ThisThread.GetActionStateFloat(session, getInfo, state);

    [NativeName("xrGetActionStateFloat")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateFloat")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.GetActionStateFloat(
        SessionHandle session,
        Ref<ActionStateGetInfo> getInfo,
        Ref<ActionStateFloat> state
    )
    {
        fixed (ActionStateFloat* __dsl_state = state)
        fixed (ActionStateGetInfo* __dsl_getInfo = getInfo)
        {
            return (Result)((IXr)this).GetActionStateFloat(session, __dsl_getInfo, __dsl_state);
        }
    }

    [NativeName("xrGetActionStateFloat")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateFloat")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result GetActionStateFloat(
        SessionHandle session,
        Ref<ActionStateGetInfo> getInfo,
        Ref<ActionStateFloat> state
    ) => ThisThread.GetActionStateFloat(session, getInfo, state);

    [NativeName("xrGetActionStatePose")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStatePose")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.GetActionStatePose(
        SessionHandle session,
        ActionStateGetInfo* getInfo,
        ActionStatePose* state
    ) =>
        (
            (delegate* unmanaged<SessionHandle, ActionStateGetInfo*, ActionStatePose*, Result>)(
                _slots[31] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[31] = nativeContext.LoadFunction(
                        "xrGetActionStatePose",
                        "openxr_loader"
                    )
            )
        )(session, getInfo, state);

    [NativeName("xrGetActionStatePose")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStatePose")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result GetActionStatePose(
        SessionHandle session,
        ActionStateGetInfo* getInfo,
        ActionStatePose* state
    ) => ThisThread.GetActionStatePose(session, getInfo, state);

    [NativeName("xrGetActionStatePose")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStatePose")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.GetActionStatePose(
        SessionHandle session,
        Ref<ActionStateGetInfo> getInfo,
        Ref<ActionStatePose> state
    )
    {
        fixed (ActionStatePose* __dsl_state = state)
        fixed (ActionStateGetInfo* __dsl_getInfo = getInfo)
        {
            return (Result)((IXr)this).GetActionStatePose(session, __dsl_getInfo, __dsl_state);
        }
    }

    [NativeName("xrGetActionStatePose")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStatePose")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result GetActionStatePose(
        SessionHandle session,
        Ref<ActionStateGetInfo> getInfo,
        Ref<ActionStatePose> state
    ) => ThisThread.GetActionStatePose(session, getInfo, state);

    [NativeName("xrGetActionStateVector2f")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateVector2f")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.GetActionStateVector2F(
        SessionHandle session,
        ActionStateGetInfo* getInfo,
        ActionStateVector2F* state
    ) =>
        (
            (delegate* unmanaged<SessionHandle, ActionStateGetInfo*, ActionStateVector2F*, Result>)(
                _slots[32] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[32] = nativeContext.LoadFunction(
                        "xrGetActionStateVector2f",
                        "openxr_loader"
                    )
            )
        )(session, getInfo, state);

    [NativeName("xrGetActionStateVector2f")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateVector2f")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result GetActionStateVector2F(
        SessionHandle session,
        ActionStateGetInfo* getInfo,
        ActionStateVector2F* state
    ) => ThisThread.GetActionStateVector2F(session, getInfo, state);

    [NativeName("xrGetActionStateVector2f")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateVector2f")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.GetActionStateVector2F(
        SessionHandle session,
        Ref<ActionStateGetInfo> getInfo,
        Ref<ActionStateVector2F> state
    )
    {
        fixed (ActionStateVector2F* __dsl_state = state)
        fixed (ActionStateGetInfo* __dsl_getInfo = getInfo)
        {
            return (Result)((IXr)this).GetActionStateVector2F(session, __dsl_getInfo, __dsl_state);
        }
    }

    [NativeName("xrGetActionStateVector2f")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetActionStateVector2f")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result GetActionStateVector2F(
        SessionHandle session,
        Ref<ActionStateGetInfo> getInfo,
        Ref<ActionStateVector2F> state
    ) => ThisThread.GetActionStateVector2F(session, getInfo, state);

    [NativeName("xrGetCurrentInteractionProfile")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetCurrentInteractionProfile")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.GetCurrentInteractionProfile(
        SessionHandle session,
        ulong topLevelUserPath,
        InteractionProfileState* interactionProfile
    ) =>
        (
            (delegate* unmanaged<SessionHandle, ulong, InteractionProfileState*, Result>)(
                _slots[33] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[33] = nativeContext.LoadFunction(
                        "xrGetCurrentInteractionProfile",
                        "openxr_loader"
                    )
            )
        )(session, topLevelUserPath, interactionProfile);

    [NativeName("xrGetCurrentInteractionProfile")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetCurrentInteractionProfile")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result GetCurrentInteractionProfile(
        SessionHandle session,
        ulong topLevelUserPath,
        InteractionProfileState* interactionProfile
    ) => ThisThread.GetCurrentInteractionProfile(session, topLevelUserPath, interactionProfile);

    [NativeName("xrGetCurrentInteractionProfile")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetCurrentInteractionProfile")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.GetCurrentInteractionProfile(
        SessionHandle session,
        ulong topLevelUserPath,
        Ref<InteractionProfileState> interactionProfile
    )
    {
        fixed (InteractionProfileState* __dsl_interactionProfile = interactionProfile)
        {
            return (Result)
                ((IXr)this).GetCurrentInteractionProfile(
                    session,
                    topLevelUserPath,
                    __dsl_interactionProfile
                );
        }
    }

    [NativeName("xrGetCurrentInteractionProfile")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetCurrentInteractionProfile")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result GetCurrentInteractionProfile(
        SessionHandle session,
        ulong topLevelUserPath,
        Ref<InteractionProfileState> interactionProfile
    ) => ThisThread.GetCurrentInteractionProfile(session, topLevelUserPath, interactionProfile);

    [NativeName("xrGetInputSourceLocalizedName")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetInputSourceLocalizedName")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.GetInputSourceLocalizedName(
        SessionHandle session,
        InputSourceLocalizedNameGetInfo* getInfo,
        uint bufferCapacityInput,
        uint* bufferCountOutput,
        sbyte* buffer
    ) =>
        (
            (delegate* unmanaged<
                SessionHandle,
                InputSourceLocalizedNameGetInfo*,
                uint,
                uint*,
                sbyte*,
                Result>)(
                _slots[34] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[34] = nativeContext.LoadFunction(
                        "xrGetInputSourceLocalizedName",
                        "openxr_loader"
                    )
            )
        )(session, getInfo, bufferCapacityInput, bufferCountOutput, buffer);

    [NativeName("xrGetInputSourceLocalizedName")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetInputSourceLocalizedName")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result GetInputSourceLocalizedName(
        SessionHandle session,
        InputSourceLocalizedNameGetInfo* getInfo,
        uint bufferCapacityInput,
        uint* bufferCountOutput,
        sbyte* buffer
    ) =>
        ThisThread.GetInputSourceLocalizedName(
            session,
            getInfo,
            bufferCapacityInput,
            bufferCountOutput,
            buffer
        );

    [NativeName("xrGetInputSourceLocalizedName")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetInputSourceLocalizedName")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.GetInputSourceLocalizedName(
        SessionHandle session,
        Ref<InputSourceLocalizedNameGetInfo> getInfo,
        uint bufferCapacityInput,
        Ref<uint> bufferCountOutput,
        Ref<sbyte> buffer
    )
    {
        fixed (sbyte* __dsl_buffer = buffer)
        fixed (uint* __dsl_bufferCountOutput = bufferCountOutput)
        fixed (InputSourceLocalizedNameGetInfo* __dsl_getInfo = getInfo)
        {
            return (Result)
                ((IXr)this).GetInputSourceLocalizedName(
                    session,
                    __dsl_getInfo,
                    bufferCapacityInput,
                    __dsl_bufferCountOutput,
                    __dsl_buffer
                );
        }
    }

    [NativeName("xrGetInputSourceLocalizedName")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetInputSourceLocalizedName")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result GetInputSourceLocalizedName(
        SessionHandle session,
        Ref<InputSourceLocalizedNameGetInfo> getInfo,
        uint bufferCapacityInput,
        Ref<uint> bufferCountOutput,
        Ref<sbyte> buffer
    ) =>
        ThisThread.GetInputSourceLocalizedName(
            session,
            getInfo,
            bufferCapacityInput,
            bufferCountOutput,
            buffer
        );

    [NativeName("xrGetInstanceProcAddr")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetInstanceProcAddr")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.GetInstanceProcAddr(InstanceHandle instance, sbyte* name, VoidFunction* function) =>
        (
            (delegate* unmanaged<InstanceHandle, sbyte*, VoidFunction*, Result>)(
                _slots[35] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[35] = nativeContext.LoadFunction(
                        "xrGetInstanceProcAddr",
                        "openxr_loader"
                    )
            )
        )(instance, name, function);

    [NativeName("xrGetInstanceProcAddr")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetInstanceProcAddr")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result GetInstanceProcAddr(
        InstanceHandle instance,
        sbyte* name,
        VoidFunction* function
    ) => ThisThread.GetInstanceProcAddr(instance, name, function);

    [NativeName("xrGetInstanceProcAddr")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetInstanceProcAddr")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.GetInstanceProcAddr(
        InstanceHandle instance,
        Ref<sbyte> name,
        Ref<VoidFunction> function
    )
    {
        fixed (VoidFunction* __dsl_function = function)
        fixed (sbyte* __dsl_name = name)
        {
            return (Result)((IXr)this).GetInstanceProcAddr(instance, __dsl_name, __dsl_function);
        }
    }

    [NativeName("xrGetInstanceProcAddr")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetInstanceProcAddr")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result GetInstanceProcAddr(
        InstanceHandle instance,
        Ref<sbyte> name,
        Ref<VoidFunction> function
    ) => ThisThread.GetInstanceProcAddr(instance, name, function);

    [NativeName("xrGetInstanceProperties")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetInstanceProperties")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.GetInstanceProperties(
        InstanceHandle instance,
        InstanceProperties* instanceProperties
    ) =>
        (
            (delegate* unmanaged<InstanceHandle, InstanceProperties*, Result>)(
                _slots[36] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[36] = nativeContext.LoadFunction(
                        "xrGetInstanceProperties",
                        "openxr_loader"
                    )
            )
        )(instance, instanceProperties);

    [NativeName("xrGetInstanceProperties")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetInstanceProperties")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result GetInstanceProperties(
        InstanceHandle instance,
        InstanceProperties* instanceProperties
    ) => ThisThread.GetInstanceProperties(instance, instanceProperties);

    [NativeName("xrGetInstanceProperties")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetInstanceProperties")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.GetInstanceProperties(
        InstanceHandle instance,
        Ref<InstanceProperties> instanceProperties
    )
    {
        fixed (InstanceProperties* __dsl_instanceProperties = instanceProperties)
        {
            return (Result)((IXr)this).GetInstanceProperties(instance, __dsl_instanceProperties);
        }
    }

    [NativeName("xrGetInstanceProperties")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetInstanceProperties")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result GetInstanceProperties(
        InstanceHandle instance,
        Ref<InstanceProperties> instanceProperties
    ) => ThisThread.GetInstanceProperties(instance, instanceProperties);

    [NativeName("xrGetReferenceSpaceBoundsRect")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetReferenceSpaceBoundsRect")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.GetReferenceSpaceBoundsRect(
        SessionHandle session,
        ReferenceSpaceType referenceSpaceType,
        Extent2Df* bounds
    ) =>
        (
            (delegate* unmanaged<SessionHandle, ReferenceSpaceType, Extent2Df*, Result>)(
                _slots[37] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[37] = nativeContext.LoadFunction(
                        "xrGetReferenceSpaceBoundsRect",
                        "openxr_loader"
                    )
            )
        )(session, referenceSpaceType, bounds);

    [NativeName("xrGetReferenceSpaceBoundsRect")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetReferenceSpaceBoundsRect")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result GetReferenceSpaceBoundsRect(
        SessionHandle session,
        ReferenceSpaceType referenceSpaceType,
        Extent2Df* bounds
    ) => ThisThread.GetReferenceSpaceBoundsRect(session, referenceSpaceType, bounds);

    [NativeName("xrGetReferenceSpaceBoundsRect")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetReferenceSpaceBoundsRect")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.GetReferenceSpaceBoundsRect(
        SessionHandle session,
        ReferenceSpaceType referenceSpaceType,
        Ref<Extent2Df> bounds
    )
    {
        fixed (Extent2Df* __dsl_bounds = bounds)
        {
            return (Result)
                ((IXr)this).GetReferenceSpaceBoundsRect(session, referenceSpaceType, __dsl_bounds);
        }
    }

    [NativeName("xrGetReferenceSpaceBoundsRect")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetReferenceSpaceBoundsRect")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result GetReferenceSpaceBoundsRect(
        SessionHandle session,
        ReferenceSpaceType referenceSpaceType,
        Ref<Extent2Df> bounds
    ) => ThisThread.GetReferenceSpaceBoundsRect(session, referenceSpaceType, bounds);

    [NativeName("xrGetSystem")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetSystem")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.GetSystem(InstanceHandle instance, SystemGetInfo* getInfo, ulong* systemId) =>
        (
            (delegate* unmanaged<InstanceHandle, SystemGetInfo*, ulong*, Result>)(
                _slots[38] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[38] = nativeContext.LoadFunction("xrGetSystem", "openxr_loader")
            )
        )(instance, getInfo, systemId);

    [NativeName("xrGetSystem")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetSystem")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result GetSystem(
        InstanceHandle instance,
        SystemGetInfo* getInfo,
        ulong* systemId
    ) => ThisThread.GetSystem(instance, getInfo, systemId);

    [NativeName("xrGetSystem")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetSystem")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.GetSystem(InstanceHandle instance, Ref<SystemGetInfo> getInfo, Ref<ulong> systemId)
    {
        fixed (ulong* __dsl_systemId = systemId)
        fixed (SystemGetInfo* __dsl_getInfo = getInfo)
        {
            return (Result)((IXr)this).GetSystem(instance, __dsl_getInfo, __dsl_systemId);
        }
    }

    [NativeName("xrGetSystem")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetSystem")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result GetSystem(
        InstanceHandle instance,
        Ref<SystemGetInfo> getInfo,
        Ref<ulong> systemId
    ) => ThisThread.GetSystem(instance, getInfo, systemId);

    [NativeName("xrGetSystemProperties")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetSystemProperties")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.GetSystemProperties(
        InstanceHandle instance,
        ulong systemId,
        SystemProperties* properties
    ) =>
        (
            (delegate* unmanaged<InstanceHandle, ulong, SystemProperties*, Result>)(
                _slots[39] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[39] = nativeContext.LoadFunction(
                        "xrGetSystemProperties",
                        "openxr_loader"
                    )
            )
        )(instance, systemId, properties);

    [NativeName("xrGetSystemProperties")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetSystemProperties")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result GetSystemProperties(
        InstanceHandle instance,
        ulong systemId,
        SystemProperties* properties
    ) => ThisThread.GetSystemProperties(instance, systemId, properties);

    [NativeName("xrGetSystemProperties")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetSystemProperties")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.GetSystemProperties(
        InstanceHandle instance,
        ulong systemId,
        Ref<SystemProperties> properties
    )
    {
        fixed (SystemProperties* __dsl_properties = properties)
        {
            return (Result)((IXr)this).GetSystemProperties(instance, systemId, __dsl_properties);
        }
    }

    [NativeName("xrGetSystemProperties")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetSystemProperties")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result GetSystemProperties(
        InstanceHandle instance,
        ulong systemId,
        Ref<SystemProperties> properties
    ) => ThisThread.GetSystemProperties(instance, systemId, properties);

    [NativeName("xrGetViewConfigurationProperties")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetViewConfigurationProperties")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.GetViewConfigurationProperties(
        InstanceHandle instance,
        ulong systemId,
        ViewConfigurationType viewConfigurationType,
        ViewConfigurationProperties* configurationProperties
    ) =>
        (
            (delegate* unmanaged<
                InstanceHandle,
                ulong,
                ViewConfigurationType,
                ViewConfigurationProperties*,
                Result>)(
                _slots[40] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[40] = nativeContext.LoadFunction(
                        "xrGetViewConfigurationProperties",
                        "openxr_loader"
                    )
            )
        )(instance, systemId, viewConfigurationType, configurationProperties);

    [NativeName("xrGetViewConfigurationProperties")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetViewConfigurationProperties")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result GetViewConfigurationProperties(
        InstanceHandle instance,
        ulong systemId,
        ViewConfigurationType viewConfigurationType,
        ViewConfigurationProperties* configurationProperties
    ) =>
        ThisThread.GetViewConfigurationProperties(
            instance,
            systemId,
            viewConfigurationType,
            configurationProperties
        );

    [NativeName("xrGetViewConfigurationProperties")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetViewConfigurationProperties")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.GetViewConfigurationProperties(
        InstanceHandle instance,
        ulong systemId,
        ViewConfigurationType viewConfigurationType,
        Ref<ViewConfigurationProperties> configurationProperties
    )
    {
        fixed (ViewConfigurationProperties* __dsl_configurationProperties = configurationProperties)
        {
            return (Result)
                ((IXr)this).GetViewConfigurationProperties(
                    instance,
                    systemId,
                    viewConfigurationType,
                    __dsl_configurationProperties
                );
        }
    }

    [NativeName("xrGetViewConfigurationProperties")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrGetViewConfigurationProperties")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result GetViewConfigurationProperties(
        InstanceHandle instance,
        ulong systemId,
        ViewConfigurationType viewConfigurationType,
        Ref<ViewConfigurationProperties> configurationProperties
    ) =>
        ThisThread.GetViewConfigurationProperties(
            instance,
            systemId,
            viewConfigurationType,
            configurationProperties
        );

    [NativeName("xrLocateSpace")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrLocateSpace")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.LocateSpace(
        SpaceHandle space,
        SpaceHandle baseSpace,
        long time,
        SpaceLocation* location
    ) =>
        (
            (delegate* unmanaged<SpaceHandle, SpaceHandle, long, SpaceLocation*, Result>)(
                _slots[41] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[41] = nativeContext.LoadFunction("xrLocateSpace", "openxr_loader")
            )
        )(space, baseSpace, time, location);

    [NativeName("xrLocateSpace")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrLocateSpace")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result LocateSpace(
        SpaceHandle space,
        SpaceHandle baseSpace,
        long time,
        SpaceLocation* location
    ) => ThisThread.LocateSpace(space, baseSpace, time, location);

    [NativeName("xrLocateSpace")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrLocateSpace")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.LocateSpace(
        SpaceHandle space,
        SpaceHandle baseSpace,
        long time,
        Ref<SpaceLocation> location
    )
    {
        fixed (SpaceLocation* __dsl_location = location)
        {
            return (Result)((IXr)this).LocateSpace(space, baseSpace, time, __dsl_location);
        }
    }

    [NativeName("xrLocateSpace")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrLocateSpace")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result LocateSpace(
        SpaceHandle space,
        SpaceHandle baseSpace,
        long time,
        Ref<SpaceLocation> location
    ) => ThisThread.LocateSpace(space, baseSpace, time, location);

    [NativeName("xrLocateSpaces")]
    [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openxr_loader", EntryPoint = "xrLocateSpaces")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.LocateSpaces(
        SessionHandle session,
        SpacesLocateInfo* locateInfo,
        SpaceLocations* spaceLocations
    ) =>
        (
            (delegate* unmanaged<SessionHandle, SpacesLocateInfo*, SpaceLocations*, Result>)(
                _slots[42] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[42] = nativeContext.LoadFunction("xrLocateSpaces", "openxr_loader")
            )
        )(session, locateInfo, spaceLocations);

    [NativeName("xrLocateSpaces")]
    [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openxr_loader", EntryPoint = "xrLocateSpaces")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result LocateSpaces(
        SessionHandle session,
        SpacesLocateInfo* locateInfo,
        SpaceLocations* spaceLocations
    ) => ThisThread.LocateSpaces(session, locateInfo, spaceLocations);

    [NativeName("xrLocateSpaces")]
    [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openxr_loader", EntryPoint = "xrLocateSpaces")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.LocateSpaces(
        SessionHandle session,
        Ref<SpacesLocateInfo> locateInfo,
        Ref<SpaceLocations> spaceLocations
    )
    {
        fixed (SpaceLocations* __dsl_spaceLocations = spaceLocations)
        fixed (SpacesLocateInfo* __dsl_locateInfo = locateInfo)
        {
            return (Result)
                ((IXr)this).LocateSpaces(session, __dsl_locateInfo, __dsl_spaceLocations);
        }
    }

    [NativeName("xrLocateSpaces")]
    [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openxr_loader", EntryPoint = "xrLocateSpaces")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result LocateSpaces(
        SessionHandle session,
        Ref<SpacesLocateInfo> locateInfo,
        Ref<SpaceLocations> spaceLocations
    ) => ThisThread.LocateSpaces(session, locateInfo, spaceLocations);

    [NativeName("xrLocateViews")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrLocateViews")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.LocateViews(
        SessionHandle session,
        ViewLocateInfo* viewLocateInfo,
        ViewState* viewState,
        uint viewCapacityInput,
        uint* viewCountOutput,
        View* views
    ) =>
        (
            (delegate* unmanaged<
                SessionHandle,
                ViewLocateInfo*,
                ViewState*,
                uint,
                uint*,
                View*,
                Result>)(
                _slots[43] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[43] = nativeContext.LoadFunction("xrLocateViews", "openxr_loader")
            )
        )(session, viewLocateInfo, viewState, viewCapacityInput, viewCountOutput, views);

    [NativeName("xrLocateViews")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrLocateViews")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result LocateViews(
        SessionHandle session,
        ViewLocateInfo* viewLocateInfo,
        ViewState* viewState,
        uint viewCapacityInput,
        uint* viewCountOutput,
        View* views
    ) =>
        ThisThread.LocateViews(
            session,
            viewLocateInfo,
            viewState,
            viewCapacityInput,
            viewCountOutput,
            views
        );

    [NativeName("xrLocateViews")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrLocateViews")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.LocateViews(
        SessionHandle session,
        Ref<ViewLocateInfo> viewLocateInfo,
        Ref<ViewState> viewState,
        uint viewCapacityInput,
        Ref<uint> viewCountOutput,
        Ref<View> views
    )
    {
        fixed (View* __dsl_views = views)
        fixed (uint* __dsl_viewCountOutput = viewCountOutput)
        fixed (ViewState* __dsl_viewState = viewState)
        fixed (ViewLocateInfo* __dsl_viewLocateInfo = viewLocateInfo)
        {
            return (Result)
                ((IXr)this).LocateViews(
                    session,
                    __dsl_viewLocateInfo,
                    __dsl_viewState,
                    viewCapacityInput,
                    __dsl_viewCountOutput,
                    __dsl_views
                );
        }
    }

    [NativeName("xrLocateViews")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrLocateViews")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result LocateViews(
        SessionHandle session,
        Ref<ViewLocateInfo> viewLocateInfo,
        Ref<ViewState> viewState,
        uint viewCapacityInput,
        Ref<uint> viewCountOutput,
        Ref<View> views
    ) =>
        ThisThread.LocateViews(
            session,
            viewLocateInfo,
            viewState,
            viewCapacityInput,
            viewCountOutput,
            views
        );

    [NativeName("xrPathToString")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrPathToString")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.PathToString(
        InstanceHandle instance,
        ulong path,
        uint bufferCapacityInput,
        uint* bufferCountOutput,
        sbyte* buffer
    ) =>
        (
            (delegate* unmanaged<InstanceHandle, ulong, uint, uint*, sbyte*, Result>)(
                _slots[44] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[44] = nativeContext.LoadFunction("xrPathToString", "openxr_loader")
            )
        )(instance, path, bufferCapacityInput, bufferCountOutput, buffer);

    [NativeName("xrPathToString")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrPathToString")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result PathToString(
        InstanceHandle instance,
        ulong path,
        uint bufferCapacityInput,
        uint* bufferCountOutput,
        sbyte* buffer
    ) => ThisThread.PathToString(instance, path, bufferCapacityInput, bufferCountOutput, buffer);

    [NativeName("xrPathToString")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrPathToString")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.PathToString(
        InstanceHandle instance,
        ulong path,
        uint bufferCapacityInput,
        Ref<uint> bufferCountOutput,
        Ref<sbyte> buffer
    )
    {
        fixed (sbyte* __dsl_buffer = buffer)
        fixed (uint* __dsl_bufferCountOutput = bufferCountOutput)
        {
            return (Result)
                ((IXr)this).PathToString(
                    instance,
                    path,
                    bufferCapacityInput,
                    __dsl_bufferCountOutput,
                    __dsl_buffer
                );
        }
    }

    [NativeName("xrPathToString")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrPathToString")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result PathToString(
        InstanceHandle instance,
        ulong path,
        uint bufferCapacityInput,
        Ref<uint> bufferCountOutput,
        Ref<sbyte> buffer
    ) => ThisThread.PathToString(instance, path, bufferCapacityInput, bufferCountOutput, buffer);

    [NativeName("xrPollEvent")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrPollEvent")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.PollEvent(InstanceHandle instance, EventDataBuffer* eventData) =>
        (
            (delegate* unmanaged<InstanceHandle, EventDataBuffer*, Result>)(
                _slots[45] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[45] = nativeContext.LoadFunction("xrPollEvent", "openxr_loader")
            )
        )(instance, eventData);

    [NativeName("xrPollEvent")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrPollEvent")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result PollEvent(InstanceHandle instance, EventDataBuffer* eventData) =>
        ThisThread.PollEvent(instance, eventData);

    [NativeName("xrPollEvent")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrPollEvent")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.PollEvent(InstanceHandle instance, Ref<EventDataBuffer> eventData)
    {
        fixed (EventDataBuffer* __dsl_eventData = eventData)
        {
            return (Result)((IXr)this).PollEvent(instance, __dsl_eventData);
        }
    }

    [NativeName("xrPollEvent")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrPollEvent")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result PollEvent(InstanceHandle instance, Ref<EventDataBuffer> eventData) =>
        ThisThread.PollEvent(instance, eventData);

    [NativeName("xrReleaseSwapchainImage")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrReleaseSwapchainImage")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.ReleaseSwapchainImage(
        SwapchainHandle swapchain,
        SwapchainImageReleaseInfo* releaseInfo
    ) =>
        (
            (delegate* unmanaged<SwapchainHandle, SwapchainImageReleaseInfo*, Result>)(
                _slots[46] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[46] = nativeContext.LoadFunction(
                        "xrReleaseSwapchainImage",
                        "openxr_loader"
                    )
            )
        )(swapchain, releaseInfo);

    [NativeName("xrReleaseSwapchainImage")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrReleaseSwapchainImage")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result ReleaseSwapchainImage(
        SwapchainHandle swapchain,
        SwapchainImageReleaseInfo* releaseInfo
    ) => ThisThread.ReleaseSwapchainImage(swapchain, releaseInfo);

    [NativeName("xrReleaseSwapchainImage")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrReleaseSwapchainImage")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.ReleaseSwapchainImage(
        SwapchainHandle swapchain,
        Ref<SwapchainImageReleaseInfo> releaseInfo
    )
    {
        fixed (SwapchainImageReleaseInfo* __dsl_releaseInfo = releaseInfo)
        {
            return (Result)((IXr)this).ReleaseSwapchainImage(swapchain, __dsl_releaseInfo);
        }
    }

    [NativeName("xrReleaseSwapchainImage")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrReleaseSwapchainImage")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result ReleaseSwapchainImage(
        SwapchainHandle swapchain,
        Ref<SwapchainImageReleaseInfo> releaseInfo
    ) => ThisThread.ReleaseSwapchainImage(swapchain, releaseInfo);

    [NativeName("xrRequestExitSession")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrRequestExitSession")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.RequestExitSession(SessionHandle session) =>
        (
            (delegate* unmanaged<SessionHandle, Result>)(
                _slots[47] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[47] = nativeContext.LoadFunction(
                        "xrRequestExitSession",
                        "openxr_loader"
                    )
            )
        )(session);

    [NativeName("xrRequestExitSession")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrRequestExitSession")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result RequestExitSession(SessionHandle session) =>
        ThisThread.RequestExitSession(session);

    [NativeName("xrResultToString")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrResultToString")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.ResultToString(InstanceHandle instance, Result value, sbyte* buffer) =>
        (
            (delegate* unmanaged<InstanceHandle, Result, sbyte*, Result>)(
                _slots[48] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[48] = nativeContext.LoadFunction("xrResultToString", "openxr_loader")
            )
        )(instance, value, buffer);

    [NativeName("xrResultToString")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrResultToString")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result ResultToString(InstanceHandle instance, Result value, sbyte* buffer) =>
        ThisThread.ResultToString(instance, value, buffer);

    [NativeName("xrResultToString")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrResultToString")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.ResultToString(InstanceHandle instance, Result value, Ref<sbyte> buffer)
    {
        fixed (sbyte* __dsl_buffer = buffer)
        {
            return (Result)((IXr)this).ResultToString(instance, value, __dsl_buffer);
        }
    }

    [NativeName("xrResultToString")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrResultToString")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result ResultToString(InstanceHandle instance, Result value, Ref<sbyte> buffer) =>
        ThisThread.ResultToString(instance, value, buffer);

    [NativeName("xrStopHapticFeedback")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrStopHapticFeedback")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.StopHapticFeedback(SessionHandle session, HapticActionInfo* hapticActionInfo) =>
        (
            (delegate* unmanaged<SessionHandle, HapticActionInfo*, Result>)(
                _slots[49] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[49] = nativeContext.LoadFunction(
                        "xrStopHapticFeedback",
                        "openxr_loader"
                    )
            )
        )(session, hapticActionInfo);

    [NativeName("xrStopHapticFeedback")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrStopHapticFeedback")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result StopHapticFeedback(
        SessionHandle session,
        HapticActionInfo* hapticActionInfo
    ) => ThisThread.StopHapticFeedback(session, hapticActionInfo);

    [NativeName("xrStopHapticFeedback")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrStopHapticFeedback")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.StopHapticFeedback(SessionHandle session, Ref<HapticActionInfo> hapticActionInfo)
    {
        fixed (HapticActionInfo* __dsl_hapticActionInfo = hapticActionInfo)
        {
            return (Result)((IXr)this).StopHapticFeedback(session, __dsl_hapticActionInfo);
        }
    }

    [NativeName("xrStopHapticFeedback")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrStopHapticFeedback")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result StopHapticFeedback(
        SessionHandle session,
        Ref<HapticActionInfo> hapticActionInfo
    ) => ThisThread.StopHapticFeedback(session, hapticActionInfo);

    [NativeName("xrStringToPath")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrStringToPath")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.StringToPath(InstanceHandle instance, sbyte* pathString, ulong* path) =>
        (
            (delegate* unmanaged<InstanceHandle, sbyte*, ulong*, Result>)(
                _slots[50] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[50] = nativeContext.LoadFunction("xrStringToPath", "openxr_loader")
            )
        )(instance, pathString, path);

    [NativeName("xrStringToPath")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrStringToPath")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result StringToPath(InstanceHandle instance, sbyte* pathString, ulong* path) =>
        ThisThread.StringToPath(instance, pathString, path);

    [NativeName("xrStringToPath")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrStringToPath")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.StringToPath(InstanceHandle instance, Ref<sbyte> pathString, Ref<ulong> path)
    {
        fixed (ulong* __dsl_path = path)
        fixed (sbyte* __dsl_pathString = pathString)
        {
            return (Result)((IXr)this).StringToPath(instance, __dsl_pathString, __dsl_path);
        }
    }

    [NativeName("xrStringToPath")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrStringToPath")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result StringToPath(
        InstanceHandle instance,
        Ref<sbyte> pathString,
        Ref<ulong> path
    ) => ThisThread.StringToPath(instance, pathString, path);

    [NativeName("xrStructureTypeToString")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrStructureTypeToString")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.StructureTypeToString(InstanceHandle instance, StructureType value, sbyte* buffer) =>
        (
            (delegate* unmanaged<InstanceHandle, StructureType, sbyte*, Result>)(
                _slots[51] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[51] = nativeContext.LoadFunction(
                        "xrStructureTypeToString",
                        "openxr_loader"
                    )
            )
        )(instance, value, buffer);

    [NativeName("xrStructureTypeToString")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrStructureTypeToString")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result StructureTypeToString(
        InstanceHandle instance,
        StructureType value,
        sbyte* buffer
    ) => ThisThread.StructureTypeToString(instance, value, buffer);

    [NativeName("xrStructureTypeToString")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrStructureTypeToString")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.StructureTypeToString(
        InstanceHandle instance,
        StructureType value,
        Ref<sbyte> buffer
    )
    {
        fixed (sbyte* __dsl_buffer = buffer)
        {
            return (Result)((IXr)this).StructureTypeToString(instance, value, __dsl_buffer);
        }
    }

    [NativeName("xrStructureTypeToString")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrStructureTypeToString")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result StructureTypeToString(
        InstanceHandle instance,
        StructureType value,
        Ref<sbyte> buffer
    ) => ThisThread.StructureTypeToString(instance, value, buffer);

    [NativeName("xrSuggestInteractionProfileBindings")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrSuggestInteractionProfileBindings")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.SuggestInteractionProfileBindings(
        InstanceHandle instance,
        InteractionProfileSuggestedBinding* suggestedBindings
    ) =>
        (
            (delegate* unmanaged<InstanceHandle, InteractionProfileSuggestedBinding*, Result>)(
                _slots[52] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[52] = nativeContext.LoadFunction(
                        "xrSuggestInteractionProfileBindings",
                        "openxr_loader"
                    )
            )
        )(instance, suggestedBindings);

    [NativeName("xrSuggestInteractionProfileBindings")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrSuggestInteractionProfileBindings")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result SuggestInteractionProfileBindings(
        InstanceHandle instance,
        InteractionProfileSuggestedBinding* suggestedBindings
    ) => ThisThread.SuggestInteractionProfileBindings(instance, suggestedBindings);

    [NativeName("xrSuggestInteractionProfileBindings")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrSuggestInteractionProfileBindings")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.SuggestInteractionProfileBindings(
        InstanceHandle instance,
        Ref<InteractionProfileSuggestedBinding> suggestedBindings
    )
    {
        fixed (InteractionProfileSuggestedBinding* __dsl_suggestedBindings = suggestedBindings)
        {
            return (Result)
                ((IXr)this).SuggestInteractionProfileBindings(instance, __dsl_suggestedBindings);
        }
    }

    [NativeName("xrSuggestInteractionProfileBindings")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrSuggestInteractionProfileBindings")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result SuggestInteractionProfileBindings(
        InstanceHandle instance,
        Ref<InteractionProfileSuggestedBinding> suggestedBindings
    ) => ThisThread.SuggestInteractionProfileBindings(instance, suggestedBindings);

    [NativeName("xrSyncActions")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrSyncActions")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.SyncActions(SessionHandle session, ActionsSyncInfo* syncInfo) =>
        (
            (delegate* unmanaged<SessionHandle, ActionsSyncInfo*, Result>)(
                _slots[53] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[53] = nativeContext.LoadFunction("xrSyncActions", "openxr_loader")
            )
        )(session, syncInfo);

    [NativeName("xrSyncActions")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrSyncActions")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result SyncActions(SessionHandle session, ActionsSyncInfo* syncInfo) =>
        ThisThread.SyncActions(session, syncInfo);

    [NativeName("xrSyncActions")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrSyncActions")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.SyncActions(SessionHandle session, Ref<ActionsSyncInfo> syncInfo)
    {
        fixed (ActionsSyncInfo* __dsl_syncInfo = syncInfo)
        {
            return (Result)((IXr)this).SyncActions(session, __dsl_syncInfo);
        }
    }

    [NativeName("xrSyncActions")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrSyncActions")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result SyncActions(SessionHandle session, Ref<ActionsSyncInfo> syncInfo) =>
        ThisThread.SyncActions(session, syncInfo);

    [NativeName("xrWaitFrame")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrWaitFrame")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.WaitFrame(
        SessionHandle session,
        FrameWaitInfo* frameWaitInfo,
        FrameState* frameState
    ) =>
        (
            (delegate* unmanaged<SessionHandle, FrameWaitInfo*, FrameState*, Result>)(
                _slots[54] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[54] = nativeContext.LoadFunction("xrWaitFrame", "openxr_loader")
            )
        )(session, frameWaitInfo, frameState);

    [NativeName("xrWaitFrame")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrWaitFrame")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result WaitFrame(
        SessionHandle session,
        FrameWaitInfo* frameWaitInfo,
        FrameState* frameState
    ) => ThisThread.WaitFrame(session, frameWaitInfo, frameState);

    [NativeName("xrWaitFrame")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrWaitFrame")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.WaitFrame(
        SessionHandle session,
        Ref<FrameWaitInfo> frameWaitInfo,
        Ref<FrameState> frameState
    )
    {
        fixed (FrameState* __dsl_frameState = frameState)
        fixed (FrameWaitInfo* __dsl_frameWaitInfo = frameWaitInfo)
        {
            return (Result)((IXr)this).WaitFrame(session, __dsl_frameWaitInfo, __dsl_frameState);
        }
    }

    [NativeName("xrWaitFrame")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrWaitFrame")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result WaitFrame(
        SessionHandle session,
        Ref<FrameWaitInfo> frameWaitInfo,
        Ref<FrameState> frameState
    ) => ThisThread.WaitFrame(session, frameWaitInfo, frameState);

    [NativeName("xrWaitSwapchainImage")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrWaitSwapchainImage")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.WaitSwapchainImage(SwapchainHandle swapchain, SwapchainImageWaitInfo* waitInfo) =>
        (
            (delegate* unmanaged<SwapchainHandle, SwapchainImageWaitInfo*, Result>)(
                _slots[55] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[55] = nativeContext.LoadFunction(
                        "xrWaitSwapchainImage",
                        "openxr_loader"
                    )
            )
        )(swapchain, waitInfo);

    [NativeName("xrWaitSwapchainImage")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrWaitSwapchainImage")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result WaitSwapchainImage(
        SwapchainHandle swapchain,
        SwapchainImageWaitInfo* waitInfo
    ) => ThisThread.WaitSwapchainImage(swapchain, waitInfo);

    [NativeName("xrWaitSwapchainImage")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrWaitSwapchainImage")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Result IXr.WaitSwapchainImage(SwapchainHandle swapchain, Ref<SwapchainImageWaitInfo> waitInfo)
    {
        fixed (SwapchainImageWaitInfo* __dsl_waitInfo = waitInfo)
        {
            return (Result)((IXr)this).WaitSwapchainImage(swapchain, __dsl_waitInfo);
        }
    }

    [NativeName("xrWaitSwapchainImage")]
    [SupportedApiProfile(
        "openxr",
        ["XR_LOADER_VERSION_1_0", "XR_VERSION_1_0", "XR_VERSION_1_1"],
        MinVersion = "1.0"
    )]
    [NativeFunction("openxr_loader", EntryPoint = "xrWaitSwapchainImage")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Result WaitSwapchainImage(
        SwapchainHandle swapchain,
        Ref<SwapchainImageWaitInfo> waitInfo
    ) => ThisThread.WaitSwapchainImage(swapchain, waitInfo);
}
