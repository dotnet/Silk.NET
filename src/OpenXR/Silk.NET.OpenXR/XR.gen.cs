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
    public unsafe partial class XR : NativeAPI
    {
        [NativeName("Type", "")]
        [NativeName("Name", "XR_API_LAYER_CREATE_INFO_STRUCT_VERSION")]
        public const uint ApiLayerCreateInfoStructVersion = unchecked((uint) 1);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_API_LAYER_INFO_STRUCT_VERSION")]
        public const uint ApiLayerInfoStructVersion = unchecked((uint) 1);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_API_LAYER_MAX_SETTINGS_PATH_SIZE")]
        public const uint ApiLayerMaxSettingsPathSize = unchecked((uint) 512);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_API_LAYER_NEXT_INFO_STRUCT_VERSION")]
        public const uint ApiLayerNextInfoStructVersion = unchecked((uint) 1);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_BODY_JOINT_COUNT_HTC")]
        public const uint BodyJointCountHtc = unchecked((uint) 26);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_CURRENT_LOADER_API_LAYER_VERSION")]
        public const uint CurrentLoaderApiLayerVersion = unchecked((uint) 1);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_CURRENT_LOADER_RUNTIME_VERSION")]
        public const uint CurrentLoaderRuntimeVersion = unchecked((uint) 1);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_EXTENSION_ENUM_BASE")]
        public const uint ExtensionEnumBase = unchecked((uint) 1000000000);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_EXTENSION_ENUM_STRIDE")]
        public const uint ExtensionEnumStride = unchecked((uint) 1000);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_FACIAL_EXPRESSION_EYE_COUNT_HTC")]
        public const uint FacialExpressionEyeCountHtc = unchecked((uint) 14);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_FACIAL_EXPRESSION_LIP_COUNT_HTC")]
        public const uint FacialExpressionLipCountHtc = unchecked((uint) 37);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_FALSE")]
        public const uint False = unchecked((uint) 0);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_FREQUENCY_UNSPECIFIED")]
        public const uint FrequencyUnspecified = unchecked((uint) 0);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_COUNT_ULTRALEAP")]
        public const uint HandForearmJointCountUltraleap = unchecked((uint) 27);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_HAND_JOINT_COUNT_EXT")]
        public const uint HandJointCountExt = unchecked((uint) 26);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_LOADER_INFO_STRUCT_VERSION")]
        public const uint LoaderInfoStructVersion = unchecked((uint) 1);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_ACTION_NAME_SIZE")]
        public const uint MaxActionNameSize = unchecked((uint) 64);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_ACTION_SET_NAME_SIZE")]
        public const uint MaxActionSetNameSize = unchecked((uint) 64);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_API_LAYER_DESCRIPTION_SIZE")]
        public const uint MaxApiLayerDescriptionSize = unchecked((uint) 256);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_API_LAYER_NAME_SIZE")]
        public const uint MaxApiLayerNameSize = unchecked((uint) 256);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_APPLICATION_NAME_SIZE")]
        public const uint MaxApplicationNameSize = unchecked((uint) 128);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_ENGINE_NAME_SIZE")]
        public const uint MaxEngineNameSize = unchecked((uint) 128);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_EXTENSION_NAME_SIZE")]
        public const uint MaxExtensionNameSize = unchecked((uint) 128);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_GRAPHICS_APIS_SUPPORTED")]
        public const uint MaxGraphicsApisSupported = unchecked((uint) 32);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_HAPTIC_PCM_BUFFER_SIZE_FB")]
        public const uint MaxHapticPcmBufferSizeFB = unchecked((uint) 4000);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_LOCALIZED_ACTION_NAME_SIZE")]
        public const uint MaxLocalizedActionNameSize = unchecked((uint) 128);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_LOCALIZED_ACTION_SET_NAME_SIZE")]
        public const uint MaxLocalizedActionSetNameSize = unchecked((uint) 128);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_PATH_LENGTH")]
        public const uint MaxPathLength = unchecked((uint) 256);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_RESULT_STRING_SIZE")]
        public const uint MaxResultStringSize = unchecked((uint) 64);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_RUNTIME_NAME_SIZE")]
        public const uint MaxRuntimeNameSize = unchecked((uint) 128);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_STRUCTURE_NAME_SIZE")]
        public const uint MaxStructureNameSize = unchecked((uint) 64);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_SYSTEM_NAME_SIZE")]
        public const uint MaxSystemNameSize = unchecked((uint) 256);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MIN_COMPOSITION_LAYERS_SUPPORTED")]
        public const uint MinCompositionLayersSupported = unchecked((uint) 16);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MIN_HAPTIC_DURATION")]
        public const uint MinHapticDuration = unchecked((uint) -1);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_NO_DURATION")]
        public const uint NoDuration = unchecked((uint) 0);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_NULL_CONTROLLER_MODEL_KEY_MSFT")]
        public const uint NullControllerModelKeyMsft = unchecked((uint) 0);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_NULL_PATH")]
        public const uint NullPath = unchecked((uint) 0);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_NULL_RENDER_MODEL_KEY_FB")]
        public const uint NullRenderModelKeyFB = unchecked((uint) 0);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_NULL_SYSTEM_ID")]
        public const uint NullSystemID = unchecked((uint) 0);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_RUNTIME_INFO_STRUCT_VERSION")]
        public const uint RuntimeInfoStructVersion = unchecked((uint) 1);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_TRUE")]
        public const uint True = unchecked((uint) 1);
        [NativeName("Type", "")]
        [NativeName("Name", "XR_UUID_SIZE")]
        public const uint UuidSize = unchecked((uint) 16);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateSpaces", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateSpaces([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpacesLocateInfo* locateInfo, [Count(Count = 0)] SpaceLocations* spaceLocations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateSpaces", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateSpaces([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpacesLocateInfo* locateInfo, [Count(Count = 0)] ref SpaceLocations spaceLocations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateSpaces", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateSpaces([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpacesLocateInfo locateInfo, [Count(Count = 0)] SpaceLocations* spaceLocations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateSpaces", Convention = CallingConvention.Winapi)]
        public partial Result LocateSpaces([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpacesLocateInfo locateInfo, [Count(Count = 0)] ref SpaceLocations spaceLocations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrAcquireSwapchainImage", Convention = CallingConvention.Winapi)]
        public unsafe partial Result AcquireSwapchainImage([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainImageAcquireInfo* acquireInfo, [Count(Count = 0)] uint* index);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrAcquireSwapchainImage", Convention = CallingConvention.Winapi)]
        public unsafe partial Result AcquireSwapchainImage([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainImageAcquireInfo* acquireInfo, [Count(Count = 0)] ref uint index);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrAcquireSwapchainImage", Convention = CallingConvention.Winapi)]
        public unsafe partial Result AcquireSwapchainImage([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapchainImageAcquireInfo acquireInfo, [Count(Count = 0)] uint* index);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrAcquireSwapchainImage", Convention = CallingConvention.Winapi)]
        public partial Result AcquireSwapchainImage([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapchainImageAcquireInfo acquireInfo, [Count(Count = 0)] ref uint index);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrApplyHapticFeedback", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ApplyHapticFeedback([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] HapticActionInfo* hapticActionInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] HapticBaseHeader* hapticFeedback);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrApplyHapticFeedback", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ApplyHapticFeedback([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] HapticActionInfo* hapticActionInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HapticBaseHeader hapticFeedback);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrApplyHapticFeedback", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ApplyHapticFeedback([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HapticActionInfo hapticActionInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] HapticBaseHeader* hapticFeedback);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrApplyHapticFeedback", Convention = CallingConvention.Winapi)]
        public partial Result ApplyHapticFeedback([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HapticActionInfo hapticActionInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HapticBaseHeader hapticFeedback);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrAttachSessionActionSets", Convention = CallingConvention.Winapi)]
        public unsafe partial Result AttachSessionActionSets([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SessionActionSetsAttachInfo* attachInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrAttachSessionActionSets", Convention = CallingConvention.Winapi)]
        public partial Result AttachSessionActionSets([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SessionActionSetsAttachInfo attachInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrBeginFrame", Convention = CallingConvention.Winapi)]
        public unsafe partial Result BeginFrame([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FrameBeginInfo* frameBeginInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrBeginFrame", Convention = CallingConvention.Winapi)]
        public partial Result BeginFrame([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FrameBeginInfo frameBeginInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrBeginSession", Convention = CallingConvention.Winapi)]
        public unsafe partial Result BeginSession([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SessionBeginInfo* beginInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrBeginSession", Convention = CallingConvention.Winapi)]
        public partial Result BeginSession([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SessionBeginInfo beginInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateAction", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateAction([Count(Count = 0)] ActionSet actionSet, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ActionCreateInfo* createInfo, [Count(Count = 0)] Action* action);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateAction", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateAction([Count(Count = 0)] ActionSet actionSet, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ActionCreateInfo* createInfo, [Count(Count = 0)] ref Action action);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateAction", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateAction([Count(Count = 0)] ActionSet actionSet, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ActionCreateInfo createInfo, [Count(Count = 0)] Action* action);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateAction", Convention = CallingConvention.Winapi)]
        public partial Result CreateAction([Count(Count = 0)] ActionSet actionSet, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ActionCreateInfo createInfo, [Count(Count = 0)] ref Action action);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateActionSet", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateActionSet([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ActionSetCreateInfo* createInfo, [Count(Count = 0)] ActionSet* actionSet);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateActionSet", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateActionSet([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ActionSetCreateInfo* createInfo, [Count(Count = 0)] ref ActionSet actionSet);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateActionSet", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateActionSet([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ActionSetCreateInfo createInfo, [Count(Count = 0)] ActionSet* actionSet);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateActionSet", Convention = CallingConvention.Winapi)]
        public partial Result CreateActionSet([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ActionSetCreateInfo createInfo, [Count(Count = 0)] ref ActionSet actionSet);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateActionSpace", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateActionSpace([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ActionSpaceCreateInfo* createInfo, [Count(Count = 0)] Space* space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateActionSpace", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateActionSpace([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ActionSpaceCreateInfo* createInfo, [Count(Count = 0)] ref Space space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateActionSpace", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateActionSpace([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ActionSpaceCreateInfo createInfo, [Count(Count = 0)] Space* space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateActionSpace", Convention = CallingConvention.Winapi)]
        public partial Result CreateActionSpace([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ActionSpaceCreateInfo createInfo, [Count(Count = 0)] ref Space space);

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentInstance = *%$PARAM(instance)$%; }")]
        [NativeApi(EntryPoint = "xrCreateInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateInstance([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InstanceCreateInfo* createInfo, [Count(Count = 0)] Instance* instance);

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentInstance = *%$PARAM(instance)$%; }")]
        [NativeApi(EntryPoint = "xrCreateInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateInstance([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InstanceCreateInfo* createInfo, [Count(Count = 0)] ref Instance instance);

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentInstance = *%$PARAM(instance)$%; }")]
        [NativeApi(EntryPoint = "xrCreateInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateInstance([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InstanceCreateInfo createInfo, [Count(Count = 0)] Instance* instance);

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentInstance = *%$PARAM(instance)$%; }")]
        [NativeApi(EntryPoint = "xrCreateInstance", Convention = CallingConvention.Winapi)]
        public partial Result CreateInstance([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InstanceCreateInfo createInfo, [Count(Count = 0)] ref Instance instance);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateReferenceSpace", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateReferenceSpace([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReferenceSpaceCreateInfo* createInfo, [Count(Count = 0)] Space* space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateReferenceSpace", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateReferenceSpace([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReferenceSpaceCreateInfo* createInfo, [Count(Count = 0)] ref Space space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateReferenceSpace", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateReferenceSpace([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReferenceSpaceCreateInfo createInfo, [Count(Count = 0)] Space* space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateReferenceSpace", Convention = CallingConvention.Winapi)]
        public partial Result CreateReferenceSpace([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReferenceSpaceCreateInfo createInfo, [Count(Count = 0)] ref Space space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSession", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSession([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SessionCreateInfo* createInfo, [Count(Count = 0)] Session* session);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSession", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSession([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SessionCreateInfo* createInfo, [Count(Count = 0)] ref Session session);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSession", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSession([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SessionCreateInfo createInfo, [Count(Count = 0)] Session* session);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSession", Convention = CallingConvention.Winapi)]
        public partial Result CreateSession([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SessionCreateInfo createInfo, [Count(Count = 0)] ref Session session);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSwapchain", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSwapchain([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainCreateInfo* createInfo, [Count(Count = 0)] Swapchain* swapchain);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSwapchain", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSwapchain([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainCreateInfo* createInfo, [Count(Count = 0)] ref Swapchain swapchain);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSwapchain", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSwapchain([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapchainCreateInfo createInfo, [Count(Count = 0)] Swapchain* swapchain);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSwapchain", Convention = CallingConvention.Winapi)]
        public partial Result CreateSwapchain([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapchainCreateInfo createInfo, [Count(Count = 0)] ref Swapchain swapchain);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyAction", Convention = CallingConvention.Winapi)]
        public partial Result DestroyAction([Count(Count = 0)] Action action);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyActionSet", Convention = CallingConvention.Winapi)]
        public partial Result DestroyActionSet([Count(Count = 0)] ActionSet actionSet);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyInstance", Convention = CallingConvention.Winapi)]
        public partial Result DestroyInstance([Count(Count = 0)] Instance instance);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroySession", Convention = CallingConvention.Winapi)]
        public partial Result DestroySession([Count(Count = 0)] Session session);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroySpace", Convention = CallingConvention.Winapi)]
        public partial Result DestroySpace([Count(Count = 0)] Space space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroySwapchain", Convention = CallingConvention.Winapi)]
        public partial Result DestroySwapchain([Count(Count = 0)] Swapchain swapchain);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEndFrame", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EndFrame([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FrameEndInfo* frameEndInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEndFrame", Convention = CallingConvention.Winapi)]
        public partial Result EndFrame([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FrameEndInfo frameEndInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEndSession", Convention = CallingConvention.Winapi)]
        public partial Result EndSession([Count(Count = 0)] Session session);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateApiLayerProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateApiLayerProperties([Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] uint* propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] ApiLayerProperties* properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateApiLayerProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateApiLayerProperties([Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] uint* propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] ref ApiLayerProperties properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateApiLayerProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateApiLayerProperties([Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] ref uint propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] ApiLayerProperties* properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateApiLayerProperties", Convention = CallingConvention.Winapi)]
        public partial Result EnumerateApiLayerProperties([Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] ref uint propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] ref ApiLayerProperties properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateBoundSourcesForAction", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateBoundSourcesForAction([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BoundSourcesForActionEnumerateInfo* enumerateInfo, [Count(Count = 0)] uint sourceCapacityInput, [Count(Count = 0)] uint* sourceCountOutput, [Count(Parameter = "sourceCapacityInput")] ulong* sources);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateBoundSourcesForAction", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateBoundSourcesForAction([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BoundSourcesForActionEnumerateInfo* enumerateInfo, [Count(Count = 0)] uint sourceCapacityInput, [Count(Count = 0)] uint* sourceCountOutput, [Count(Parameter = "sourceCapacityInput")] ref ulong sources);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateBoundSourcesForAction", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateBoundSourcesForAction([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BoundSourcesForActionEnumerateInfo* enumerateInfo, [Count(Count = 0)] uint sourceCapacityInput, [Count(Count = 0)] ref uint sourceCountOutput, [Count(Parameter = "sourceCapacityInput")] ulong* sources);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateBoundSourcesForAction", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateBoundSourcesForAction([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BoundSourcesForActionEnumerateInfo* enumerateInfo, [Count(Count = 0)] uint sourceCapacityInput, [Count(Count = 0)] ref uint sourceCountOutput, [Count(Parameter = "sourceCapacityInput")] ref ulong sources);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateBoundSourcesForAction", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateBoundSourcesForAction([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BoundSourcesForActionEnumerateInfo enumerateInfo, [Count(Count = 0)] uint sourceCapacityInput, [Count(Count = 0)] uint* sourceCountOutput, [Count(Parameter = "sourceCapacityInput")] ulong* sources);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateBoundSourcesForAction", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateBoundSourcesForAction([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BoundSourcesForActionEnumerateInfo enumerateInfo, [Count(Count = 0)] uint sourceCapacityInput, [Count(Count = 0)] uint* sourceCountOutput, [Count(Parameter = "sourceCapacityInput")] ref ulong sources);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateBoundSourcesForAction", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateBoundSourcesForAction([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BoundSourcesForActionEnumerateInfo enumerateInfo, [Count(Count = 0)] uint sourceCapacityInput, [Count(Count = 0)] ref uint sourceCountOutput, [Count(Parameter = "sourceCapacityInput")] ulong* sources);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateBoundSourcesForAction", Convention = CallingConvention.Winapi)]
        public partial Result EnumerateBoundSourcesForAction([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BoundSourcesForActionEnumerateInfo enumerateInfo, [Count(Count = 0)] uint sourceCapacityInput, [Count(Count = 0)] ref uint sourceCountOutput, [Count(Parameter = "sourceCapacityInput")] ref ulong sources);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateEnvironmentBlendModes", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateEnvironmentBlendModes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint environmentBlendModeCapacityInput, [Count(Count = 0)] uint* environmentBlendModeCountOutput, [Count(Parameter = "environmentBlendModeCapacityInput")] EnvironmentBlendMode* environmentBlendModes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateEnvironmentBlendModes", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateEnvironmentBlendModes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint environmentBlendModeCapacityInput, [Count(Count = 0)] uint* environmentBlendModeCountOutput, [Count(Parameter = "environmentBlendModeCapacityInput")] ref EnvironmentBlendMode environmentBlendModes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateEnvironmentBlendModes", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateEnvironmentBlendModes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint environmentBlendModeCapacityInput, [Count(Count = 0)] ref uint environmentBlendModeCountOutput, [Count(Parameter = "environmentBlendModeCapacityInput")] EnvironmentBlendMode* environmentBlendModes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateEnvironmentBlendModes", Convention = CallingConvention.Winapi)]
        public partial Result EnumerateEnvironmentBlendModes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint environmentBlendModeCapacityInput, [Count(Count = 0)] ref uint environmentBlendModeCountOutput, [Count(Parameter = "environmentBlendModeCapacityInput")] ref EnvironmentBlendMode environmentBlendModes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInstanceExtensionProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] uint* propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] ExtensionProperties* properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInstanceExtensionProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] uint* propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] ref ExtensionProperties properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInstanceExtensionProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] ref uint propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] ExtensionProperties* properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInstanceExtensionProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] ref uint propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] ref ExtensionProperties properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInstanceExtensionProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] uint* propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] ExtensionProperties* properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInstanceExtensionProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] uint* propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] ref ExtensionProperties properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInstanceExtensionProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] ref uint propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] ExtensionProperties* properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInstanceExtensionProperties", Convention = CallingConvention.Winapi)]
        public partial Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] ref uint propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] ref ExtensionProperties properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInstanceExtensionProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] uint* propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] ExtensionProperties* properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInstanceExtensionProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] uint* propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] ref ExtensionProperties properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInstanceExtensionProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] ref uint propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] ExtensionProperties* properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInstanceExtensionProperties", Convention = CallingConvention.Winapi)]
        public partial Result EnumerateInstanceExtensionProperties([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] ref uint propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] ref ExtensionProperties properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateReferenceSpaces", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateReferenceSpaces([Count(Count = 0)] Session session, [Count(Count = 0)] uint spaceCapacityInput, [Count(Count = 0)] uint* spaceCountOutput, [Count(Parameter = "spaceCapacityInput")] ReferenceSpaceType* spaces);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateReferenceSpaces", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateReferenceSpaces([Count(Count = 0)] Session session, [Count(Count = 0)] uint spaceCapacityInput, [Count(Count = 0)] uint* spaceCountOutput, [Count(Parameter = "spaceCapacityInput")] ref ReferenceSpaceType spaces);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateReferenceSpaces", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateReferenceSpaces([Count(Count = 0)] Session session, [Count(Count = 0)] uint spaceCapacityInput, [Count(Count = 0)] ref uint spaceCountOutput, [Count(Parameter = "spaceCapacityInput")] ReferenceSpaceType* spaces);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateReferenceSpaces", Convention = CallingConvention.Winapi)]
        public partial Result EnumerateReferenceSpaces([Count(Count = 0)] Session session, [Count(Count = 0)] uint spaceCapacityInput, [Count(Count = 0)] ref uint spaceCountOutput, [Count(Parameter = "spaceCapacityInput")] ref ReferenceSpaceType spaces);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSwapchainFormats", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSwapchainFormats([Count(Count = 0)] Session session, [Count(Count = 0)] uint formatCapacityInput, [Count(Count = 0)] uint* formatCountOutput, [Count(Parameter = "formatCapacityInput")] long* formats);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSwapchainFormats", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSwapchainFormats([Count(Count = 0)] Session session, [Count(Count = 0)] uint formatCapacityInput, [Count(Count = 0)] uint* formatCountOutput, [Count(Parameter = "formatCapacityInput")] ref long formats);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSwapchainFormats", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSwapchainFormats([Count(Count = 0)] Session session, [Count(Count = 0)] uint formatCapacityInput, [Count(Count = 0)] ref uint formatCountOutput, [Count(Parameter = "formatCapacityInput")] long* formats);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSwapchainFormats", Convention = CallingConvention.Winapi)]
        public partial Result EnumerateSwapchainFormats([Count(Count = 0)] Session session, [Count(Count = 0)] uint formatCapacityInput, [Count(Count = 0)] ref uint formatCountOutput, [Count(Parameter = "formatCapacityInput")] ref long formats);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSwapchainImages", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSwapchainImages([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0)] uint imageCapacityInput, [Count(Count = 0)] uint* imageCountOutput, [Count(Parameter = "imageCapacityInput")] SwapchainImageBaseHeader* images);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSwapchainImages", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSwapchainImages([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0)] uint imageCapacityInput, [Count(Count = 0)] uint* imageCountOutput, [Count(Parameter = "imageCapacityInput")] ref SwapchainImageBaseHeader images);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSwapchainImages", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSwapchainImages([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0)] uint imageCapacityInput, [Count(Count = 0)] ref uint imageCountOutput, [Count(Parameter = "imageCapacityInput")] SwapchainImageBaseHeader* images);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSwapchainImages", Convention = CallingConvention.Winapi)]
        public partial Result EnumerateSwapchainImages([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0)] uint imageCapacityInput, [Count(Count = 0)] ref uint imageCountOutput, [Count(Parameter = "imageCapacityInput")] ref SwapchainImageBaseHeader images);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateViewConfigurations", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateViewConfiguration([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint viewConfigurationTypeCapacityInput, [Count(Count = 0)] uint* viewConfigurationTypeCountOutput, [Count(Parameter = "viewConfigurationTypeCapacityInput")] ViewConfigurationType* viewConfigurationTypes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateViewConfigurations", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateViewConfiguration([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint viewConfigurationTypeCapacityInput, [Count(Count = 0)] uint* viewConfigurationTypeCountOutput, [Count(Parameter = "viewConfigurationTypeCapacityInput")] ref ViewConfigurationType viewConfigurationTypes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateViewConfigurations", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateViewConfiguration([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint viewConfigurationTypeCapacityInput, [Count(Count = 0)] ref uint viewConfigurationTypeCountOutput, [Count(Parameter = "viewConfigurationTypeCapacityInput")] ViewConfigurationType* viewConfigurationTypes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateViewConfigurations", Convention = CallingConvention.Winapi)]
        public partial Result EnumerateViewConfiguration([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint viewConfigurationTypeCapacityInput, [Count(Count = 0)] ref uint viewConfigurationTypeCountOutput, [Count(Parameter = "viewConfigurationTypeCapacityInput")] ref ViewConfigurationType viewConfigurationTypes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateViewConfigurationViews", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateViewConfigurationView([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] uint* viewCountOutput, [Count(Parameter = "viewCapacityInput")] ViewConfigurationView* views);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateViewConfigurationViews", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateViewConfigurationView([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] uint* viewCountOutput, [Count(Parameter = "viewCapacityInput")] ref ViewConfigurationView views);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateViewConfigurationViews", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateViewConfigurationView([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] ref uint viewCountOutput, [Count(Parameter = "viewCapacityInput")] ViewConfigurationView* views);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateViewConfigurationViews", Convention = CallingConvention.Winapi)]
        public partial Result EnumerateViewConfigurationView([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] ref uint viewCountOutput, [Count(Parameter = "viewCapacityInput")] ref ViewConfigurationView views);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetActionStateBoolean", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetActionStateBoolean([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ActionStateGetInfo* getInfo, [Count(Count = 0)] ActionStateBoolean* state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetActionStateBoolean", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetActionStateBoolean([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ActionStateGetInfo* getInfo, [Count(Count = 0)] ref ActionStateBoolean state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetActionStateBoolean", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetActionStateBoolean([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ActionStateGetInfo getInfo, [Count(Count = 0)] ActionStateBoolean* state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetActionStateBoolean", Convention = CallingConvention.Winapi)]
        public partial Result GetActionStateBoolean([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ActionStateGetInfo getInfo, [Count(Count = 0)] ref ActionStateBoolean state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetActionStateFloat", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetActionStateFloat([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ActionStateGetInfo* getInfo, [Count(Count = 0)] ActionStateFloat* state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetActionStateFloat", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetActionStateFloat([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ActionStateGetInfo* getInfo, [Count(Count = 0)] ref ActionStateFloat state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetActionStateFloat", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetActionStateFloat([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ActionStateGetInfo getInfo, [Count(Count = 0)] ActionStateFloat* state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetActionStateFloat", Convention = CallingConvention.Winapi)]
        public partial Result GetActionStateFloat([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ActionStateGetInfo getInfo, [Count(Count = 0)] ref ActionStateFloat state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetActionStatePose", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetActionStatePose([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ActionStateGetInfo* getInfo, [Count(Count = 0)] ActionStatePose* state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetActionStatePose", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetActionStatePose([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ActionStateGetInfo* getInfo, [Count(Count = 0)] ref ActionStatePose state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetActionStatePose", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetActionStatePose([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ActionStateGetInfo getInfo, [Count(Count = 0)] ActionStatePose* state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetActionStatePose", Convention = CallingConvention.Winapi)]
        public partial Result GetActionStatePose([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ActionStateGetInfo getInfo, [Count(Count = 0)] ref ActionStatePose state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetActionStateVector2f", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetActionStateVector2([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ActionStateGetInfo* getInfo, [Count(Count = 0)] ActionStateVector2f* state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetActionStateVector2f", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetActionStateVector2([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ActionStateGetInfo* getInfo, [Count(Count = 0)] ref ActionStateVector2f state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetActionStateVector2f", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetActionStateVector2([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ActionStateGetInfo getInfo, [Count(Count = 0)] ActionStateVector2f* state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetActionStateVector2f", Convention = CallingConvention.Winapi)]
        public partial Result GetActionStateVector2([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ActionStateGetInfo getInfo, [Count(Count = 0)] ref ActionStateVector2f state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetCurrentInteractionProfile", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetCurrentInteractionProfile([Count(Count = 0)] Session session, [Count(Count = 0)] ulong topLevelUserPath, [Count(Count = 0)] InteractionProfileState* interactionProfile);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetCurrentInteractionProfile", Convention = CallingConvention.Winapi)]
        public partial Result GetCurrentInteractionProfile([Count(Count = 0)] Session session, [Count(Count = 0)] ulong topLevelUserPath, [Count(Count = 0)] ref InteractionProfileState interactionProfile);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetInputSourceLocalizedName", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InputSourceLocalizedNameGetInfo* getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetInputSourceLocalizedName", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InputSourceLocalizedNameGetInfo* getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetInputSourceLocalizedName", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InputSourceLocalizedNameGetInfo* getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetInputSourceLocalizedName", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InputSourceLocalizedNameGetInfo* getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetInputSourceLocalizedName", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InputSourceLocalizedNameGetInfo* getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetInputSourceLocalizedName", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InputSourceLocalizedNameGetInfo* getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetInputSourceLocalizedName", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InputSourceLocalizedNameGetInfo getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetInputSourceLocalizedName", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InputSourceLocalizedNameGetInfo getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetInputSourceLocalizedName", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InputSourceLocalizedNameGetInfo getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetInputSourceLocalizedName", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InputSourceLocalizedNameGetInfo getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetInputSourceLocalizedName", Convention = CallingConvention.Winapi)]
        public partial Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InputSourceLocalizedNameGetInfo getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetInputSourceLocalizedName", Convention = CallingConvention.Winapi)]
        public partial Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InputSourceLocalizedNameGetInfo getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetInstanceProcAddr", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetInstanceProcAddr([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, [Count(Count = 0)] PfnVoidFunction* function);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetInstanceProcAddr", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetInstanceProcAddr([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, [Count(Count = 0)] ref PfnVoidFunction function);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetInstanceProcAddr", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetInstanceProcAddr([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, [Count(Count = 0)] PfnVoidFunction* function);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetInstanceProcAddr", Convention = CallingConvention.Winapi)]
        public partial Result GetInstanceProcAddr([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, [Count(Count = 0)] ref PfnVoidFunction function);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetInstanceProcAddr", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetInstanceProcAddr([Count(Count = 0)] Instance instance, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Count(Count = 0)] PfnVoidFunction* function);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetInstanceProcAddr", Convention = CallingConvention.Winapi)]
        public partial Result GetInstanceProcAddr([Count(Count = 0)] Instance instance, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Count(Count = 0)] ref PfnVoidFunction function);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetInstanceProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetInstanceProperties([Count(Count = 0)] Instance instance, [Count(Count = 0)] InstanceProperties* instanceProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetInstanceProperties", Convention = CallingConvention.Winapi)]
        public partial Result GetInstanceProperties([Count(Count = 0)] Instance instance, [Count(Count = 0)] ref InstanceProperties instanceProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetReferenceSpaceBoundsRect", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetReferenceSpaceBoundsRect([Count(Count = 0)] Session session, [Count(Count = 0)] ReferenceSpaceType referenceSpaceType, [Count(Count = 0)] Extent2Df* bounds);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetReferenceSpaceBoundsRect", Convention = CallingConvention.Winapi)]
        public partial Result GetReferenceSpaceBoundsRect([Count(Count = 0)] Session session, [Count(Count = 0)] ReferenceSpaceType referenceSpaceType, [Count(Count = 0)] ref Extent2Df bounds);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSystem", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSystem([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SystemGetInfo* getInfo, [Count(Count = 0)] ulong* systemId);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSystem", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSystem([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SystemGetInfo* getInfo, [Count(Count = 0)] ref ulong systemId);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSystem", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSystem([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SystemGetInfo getInfo, [Count(Count = 0)] ulong* systemId);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSystem", Convention = CallingConvention.Winapi)]
        public partial Result GetSystem([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SystemGetInfo getInfo, [Count(Count = 0)] ref ulong systemId);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSystemProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSystemProperties([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] SystemProperties* properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSystemProperties", Convention = CallingConvention.Winapi)]
        public partial Result GetSystemProperties([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ref SystemProperties properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetViewConfigurationProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetViewConfigurationProperties([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] ViewConfigurationProperties* configurationProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetViewConfigurationProperties", Convention = CallingConvention.Winapi)]
        public partial Result GetViewConfigurationProperties([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] ref ViewConfigurationProperties configurationProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateSpace", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateSpace([Count(Count = 0)] Space space, [Count(Count = 0)] Space baseSpace, [Count(Count = 0)] long time, [Count(Count = 0)] SpaceLocation* location);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateSpace", Convention = CallingConvention.Winapi)]
        public partial Result LocateSpace([Count(Count = 0)] Space space, [Count(Count = 0)] Space baseSpace, [Count(Count = 0)] long time, [Count(Count = 0)] ref SpaceLocation location);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateViews", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ViewLocateInfo* viewLocateInfo, [Count(Count = 0)] ViewState* viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] uint* viewCountOutput, [Count(Parameter = "viewCapacityInput")] View* views);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateViews", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ViewLocateInfo* viewLocateInfo, [Count(Count = 0)] ViewState* viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] uint* viewCountOutput, [Count(Parameter = "viewCapacityInput")] ref View views);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateViews", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ViewLocateInfo* viewLocateInfo, [Count(Count = 0)] ViewState* viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] ref uint viewCountOutput, [Count(Parameter = "viewCapacityInput")] View* views);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateViews", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ViewLocateInfo* viewLocateInfo, [Count(Count = 0)] ViewState* viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] ref uint viewCountOutput, [Count(Parameter = "viewCapacityInput")] ref View views);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateViews", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ViewLocateInfo* viewLocateInfo, [Count(Count = 0)] ref ViewState viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] uint* viewCountOutput, [Count(Parameter = "viewCapacityInput")] View* views);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateViews", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ViewLocateInfo* viewLocateInfo, [Count(Count = 0)] ref ViewState viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] uint* viewCountOutput, [Count(Parameter = "viewCapacityInput")] ref View views);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateViews", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ViewLocateInfo* viewLocateInfo, [Count(Count = 0)] ref ViewState viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] ref uint viewCountOutput, [Count(Parameter = "viewCapacityInput")] View* views);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateViews", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ViewLocateInfo* viewLocateInfo, [Count(Count = 0)] ref ViewState viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] ref uint viewCountOutput, [Count(Parameter = "viewCapacityInput")] ref View views);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateViews", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ViewLocateInfo viewLocateInfo, [Count(Count = 0)] ViewState* viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] uint* viewCountOutput, [Count(Parameter = "viewCapacityInput")] View* views);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateViews", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ViewLocateInfo viewLocateInfo, [Count(Count = 0)] ViewState* viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] uint* viewCountOutput, [Count(Parameter = "viewCapacityInput")] ref View views);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateViews", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ViewLocateInfo viewLocateInfo, [Count(Count = 0)] ViewState* viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] ref uint viewCountOutput, [Count(Parameter = "viewCapacityInput")] View* views);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateViews", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ViewLocateInfo viewLocateInfo, [Count(Count = 0)] ViewState* viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] ref uint viewCountOutput, [Count(Parameter = "viewCapacityInput")] ref View views);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateViews", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ViewLocateInfo viewLocateInfo, [Count(Count = 0)] ref ViewState viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] uint* viewCountOutput, [Count(Parameter = "viewCapacityInput")] View* views);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateViews", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ViewLocateInfo viewLocateInfo, [Count(Count = 0)] ref ViewState viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] uint* viewCountOutput, [Count(Parameter = "viewCapacityInput")] ref View views);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateViews", Convention = CallingConvention.Winapi)]
        public unsafe partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ViewLocateInfo viewLocateInfo, [Count(Count = 0)] ref ViewState viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] ref uint viewCountOutput, [Count(Parameter = "viewCapacityInput")] View* views);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrLocateViews", Convention = CallingConvention.Winapi)]
        public partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ViewLocateInfo viewLocateInfo, [Count(Count = 0)] ref ViewState viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] ref uint viewCountOutput, [Count(Parameter = "viewCapacityInput")] ref View views);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPathToString", Convention = CallingConvention.Winapi)]
        public unsafe partial Result PathToString([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong path, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPathToString", Convention = CallingConvention.Winapi)]
        public unsafe partial Result PathToString([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong path, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPathToString", Convention = CallingConvention.Winapi)]
        public unsafe partial Result PathToString([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong path, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPathToString", Convention = CallingConvention.Winapi)]
        public unsafe partial Result PathToString([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong path, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPathToString", Convention = CallingConvention.Winapi)]
        public partial Result PathToString([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong path, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPathToString", Convention = CallingConvention.Winapi)]
        public partial Result PathToString([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong path, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPollEvent", Convention = CallingConvention.Winapi)]
        public unsafe partial Result PollEvent([Count(Count = 0)] Instance instance, [Count(Count = 0)] EventDataBuffer* eventData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPollEvent", Convention = CallingConvention.Winapi)]
        public partial Result PollEvent([Count(Count = 0)] Instance instance, [Count(Count = 0)] ref EventDataBuffer eventData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrReleaseSwapchainImage", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ReleaseSwapchainImage([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainImageReleaseInfo* releaseInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrReleaseSwapchainImage", Convention = CallingConvention.Winapi)]
        public partial Result ReleaseSwapchainImage([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapchainImageReleaseInfo releaseInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrRequestExitSession", Convention = CallingConvention.Winapi)]
        public partial Result RequestExitSession([Count(Count = 0)] Session session);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrResultToString", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ResultToString([Count(Count = 0)] Instance instance, [Count(Count = 0)] Result value, [Count(Computed = "XR_MAX_RESULT_STRING_SIZE")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrResultToString", Convention = CallingConvention.Winapi)]
        public partial Result ResultToString([Count(Count = 0)] Instance instance, [Count(Count = 0)] Result value, [Count(Computed = "XR_MAX_RESULT_STRING_SIZE")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrResultToString", Convention = CallingConvention.Winapi)]
        public partial Result ResultToString([Count(Count = 0)] Instance instance, [Count(Count = 0)] Result value, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrStopHapticFeedback", Convention = CallingConvention.Winapi)]
        public unsafe partial Result StopHapticFeedback([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] HapticActionInfo* hapticActionInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrStopHapticFeedback", Convention = CallingConvention.Winapi)]
        public partial Result StopHapticFeedback([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HapticActionInfo hapticActionInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrStringToPath", Convention = CallingConvention.Winapi)]
        public unsafe partial Result StringToPath([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pathString, [Count(Count = 0)] ulong* path);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrStringToPath", Convention = CallingConvention.Winapi)]
        public unsafe partial Result StringToPath([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pathString, [Count(Count = 0)] ref ulong path);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrStringToPath", Convention = CallingConvention.Winapi)]
        public unsafe partial Result StringToPath([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pathString, [Count(Count = 0)] ulong* path);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrStringToPath", Convention = CallingConvention.Winapi)]
        public partial Result StringToPath([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pathString, [Count(Count = 0)] ref ulong path);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrStringToPath", Convention = CallingConvention.Winapi)]
        public unsafe partial Result StringToPath([Count(Count = 0)] Instance instance, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pathString, [Count(Count = 0)] ulong* path);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrStringToPath", Convention = CallingConvention.Winapi)]
        public partial Result StringToPath([Count(Count = 0)] Instance instance, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pathString, [Count(Count = 0)] ref ulong path);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrStructureTypeToString", Convention = CallingConvention.Winapi)]
        public unsafe partial Result StructureTypeToString([Count(Count = 0)] Instance instance, [Count(Count = 0)] StructureType value, [Count(Computed = "XR_MAX_STRUCTURE_NAME_SIZE")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrStructureTypeToString", Convention = CallingConvention.Winapi)]
        public partial Result StructureTypeToString([Count(Count = 0)] Instance instance, [Count(Count = 0)] StructureType value, [Count(Computed = "XR_MAX_STRUCTURE_NAME_SIZE")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrStructureTypeToString", Convention = CallingConvention.Winapi)]
        public partial Result StructureTypeToString([Count(Count = 0)] Instance instance, [Count(Count = 0)] StructureType value, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSuggestInteractionProfileBindings", Convention = CallingConvention.Winapi)]
        public unsafe partial Result SuggestInteractionProfileBinding([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InteractionProfileSuggestedBinding* suggestedBindings);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSuggestInteractionProfileBindings", Convention = CallingConvention.Winapi)]
        public partial Result SuggestInteractionProfileBinding([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InteractionProfileSuggestedBinding suggestedBindings);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSyncActions", Convention = CallingConvention.Winapi)]
        public unsafe partial Result SyncAction([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ActionsSyncInfo* syncInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSyncActions", Convention = CallingConvention.Winapi)]
        public partial Result SyncAction([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ActionsSyncInfo syncInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrWaitFrame", Convention = CallingConvention.Winapi)]
        public unsafe partial Result WaitFrame([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FrameWaitInfo* frameWaitInfo, [Count(Count = 0)] FrameState* frameState);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrWaitFrame", Convention = CallingConvention.Winapi)]
        public unsafe partial Result WaitFrame([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FrameWaitInfo* frameWaitInfo, [Count(Count = 0)] ref FrameState frameState);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrWaitFrame", Convention = CallingConvention.Winapi)]
        public unsafe partial Result WaitFrame([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FrameWaitInfo frameWaitInfo, [Count(Count = 0)] FrameState* frameState);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrWaitFrame", Convention = CallingConvention.Winapi)]
        public partial Result WaitFrame([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FrameWaitInfo frameWaitInfo, [Count(Count = 0)] ref FrameState frameState);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrWaitSwapchainImage", Convention = CallingConvention.Winapi)]
        public unsafe partial Result WaitSwapchainImage([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainImageWaitInfo* waitInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrWaitSwapchainImage", Convention = CallingConvention.Winapi)]
        public partial Result WaitSwapchainImage([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapchainImageWaitInfo waitInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateApiLayerInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateApiLayerInstance([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InstanceCreateInfo* info, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ApiLayerCreateInfo* layerInfo, [Count(Count = 0)] Instance* instance);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateApiLayerInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateApiLayerInstance([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InstanceCreateInfo* info, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ApiLayerCreateInfo* layerInfo, [Count(Count = 0)] ref Instance instance);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateApiLayerInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateApiLayerInstance([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InstanceCreateInfo* info, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ApiLayerCreateInfo layerInfo, [Count(Count = 0)] Instance* instance);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateApiLayerInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateApiLayerInstance([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InstanceCreateInfo* info, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ApiLayerCreateInfo layerInfo, [Count(Count = 0)] ref Instance instance);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateApiLayerInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateApiLayerInstance([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InstanceCreateInfo info, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ApiLayerCreateInfo* layerInfo, [Count(Count = 0)] Instance* instance);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateApiLayerInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateApiLayerInstance([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InstanceCreateInfo info, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ApiLayerCreateInfo* layerInfo, [Count(Count = 0)] ref Instance instance);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateApiLayerInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateApiLayerInstance([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InstanceCreateInfo info, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ApiLayerCreateInfo layerInfo, [Count(Count = 0)] Instance* instance);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateApiLayerInstance", Convention = CallingConvention.Winapi)]
        public partial Result CreateApiLayerInstance([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InstanceCreateInfo info, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ApiLayerCreateInfo layerInfo, [Count(Count = 0)] ref Instance instance);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrNegotiateLoaderApiLayerInterface", Convention = CallingConvention.Winapi)]
        public unsafe partial Result NegotiateLoaderApiLayerInterface([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] NegotiateLoaderInfo* loaderInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* layerName, [Count(Count = 0)] NegotiateApiLayerRequest* apiLayerRequest);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrNegotiateLoaderApiLayerInterface", Convention = CallingConvention.Winapi)]
        public unsafe partial Result NegotiateLoaderApiLayerInterface([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] NegotiateLoaderInfo* loaderInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* layerName, [Count(Count = 0)] ref NegotiateApiLayerRequest apiLayerRequest);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrNegotiateLoaderApiLayerInterface", Convention = CallingConvention.Winapi)]
        public unsafe partial Result NegotiateLoaderApiLayerInterface([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] NegotiateLoaderInfo* loaderInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte layerName, [Count(Count = 0)] NegotiateApiLayerRequest* apiLayerRequest);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrNegotiateLoaderApiLayerInterface", Convention = CallingConvention.Winapi)]
        public unsafe partial Result NegotiateLoaderApiLayerInterface([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] NegotiateLoaderInfo* loaderInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte layerName, [Count(Count = 0)] ref NegotiateApiLayerRequest apiLayerRequest);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrNegotiateLoaderApiLayerInterface", Convention = CallingConvention.Winapi)]
        public unsafe partial Result NegotiateLoaderApiLayerInterface([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] NegotiateLoaderInfo* loaderInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string layerName, [Count(Count = 0)] NegotiateApiLayerRequest* apiLayerRequest);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrNegotiateLoaderApiLayerInterface", Convention = CallingConvention.Winapi)]
        public unsafe partial Result NegotiateLoaderApiLayerInterface([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] NegotiateLoaderInfo* loaderInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string layerName, [Count(Count = 0)] ref NegotiateApiLayerRequest apiLayerRequest);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrNegotiateLoaderApiLayerInterface", Convention = CallingConvention.Winapi)]
        public unsafe partial Result NegotiateLoaderApiLayerInterface([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in NegotiateLoaderInfo loaderInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* layerName, [Count(Count = 0)] NegotiateApiLayerRequest* apiLayerRequest);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrNegotiateLoaderApiLayerInterface", Convention = CallingConvention.Winapi)]
        public unsafe partial Result NegotiateLoaderApiLayerInterface([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in NegotiateLoaderInfo loaderInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* layerName, [Count(Count = 0)] ref NegotiateApiLayerRequest apiLayerRequest);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrNegotiateLoaderApiLayerInterface", Convention = CallingConvention.Winapi)]
        public unsafe partial Result NegotiateLoaderApiLayerInterface([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in NegotiateLoaderInfo loaderInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte layerName, [Count(Count = 0)] NegotiateApiLayerRequest* apiLayerRequest);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrNegotiateLoaderApiLayerInterface", Convention = CallingConvention.Winapi)]
        public partial Result NegotiateLoaderApiLayerInterface([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in NegotiateLoaderInfo loaderInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte layerName, [Count(Count = 0)] ref NegotiateApiLayerRequest apiLayerRequest);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrNegotiateLoaderApiLayerInterface", Convention = CallingConvention.Winapi)]
        public unsafe partial Result NegotiateLoaderApiLayerInterface([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in NegotiateLoaderInfo loaderInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string layerName, [Count(Count = 0)] NegotiateApiLayerRequest* apiLayerRequest);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrNegotiateLoaderApiLayerInterface", Convention = CallingConvention.Winapi)]
        public partial Result NegotiateLoaderApiLayerInterface([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in NegotiateLoaderInfo loaderInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string layerName, [Count(Count = 0)] ref NegotiateApiLayerRequest apiLayerRequest);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrNegotiateLoaderRuntimeInterface", Convention = CallingConvention.Winapi)]
        public unsafe partial Result NegotiateLoaderRuntimeInterface([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] NegotiateLoaderInfo* loaderInfo, [Count(Count = 0)] NegotiateRuntimeRequest* runtimeRequest);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrNegotiateLoaderRuntimeInterface", Convention = CallingConvention.Winapi)]
        public unsafe partial Result NegotiateLoaderRuntimeInterface([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] NegotiateLoaderInfo* loaderInfo, [Count(Count = 0)] ref NegotiateRuntimeRequest runtimeRequest);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrNegotiateLoaderRuntimeInterface", Convention = CallingConvention.Winapi)]
        public unsafe partial Result NegotiateLoaderRuntimeInterface([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in NegotiateLoaderInfo loaderInfo, [Count(Count = 0)] NegotiateRuntimeRequest* runtimeRequest);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrNegotiateLoaderRuntimeInterface", Convention = CallingConvention.Winapi)]
        public partial Result NegotiateLoaderRuntimeInterface([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in NegotiateLoaderInfo loaderInfo, [Count(Count = 0)] ref NegotiateRuntimeRequest runtimeRequest);

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateApiLayerProperties([Count(Count = 0)] uint* propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] Span<ApiLayerProperties> properties)
        {
            // ImplicitCountSpanOverloader
            return EnumerateApiLayerProperties((uint) properties.Length, propertyCountOutput, ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateApiLayerProperties([Count(Count = 0)] ref uint propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] Span<ApiLayerProperties> properties)
        {
            // ImplicitCountSpanOverloader
            return EnumerateApiLayerProperties((uint) properties.Length, ref propertyCountOutput, ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateBoundSourcesForAction([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BoundSourcesForActionEnumerateInfo* enumerateInfo, [Count(Count = 0)] uint* sourceCountOutput, [Count(Parameter = "sourceCapacityInput")] Span<ulong> sources)
        {
            // ImplicitCountSpanOverloader
            return EnumerateBoundSourcesForAction(session, enumerateInfo, (uint) sources.Length, sourceCountOutput, ref sources.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateBoundSourcesForAction([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BoundSourcesForActionEnumerateInfo* enumerateInfo, [Count(Count = 0)] ref uint sourceCountOutput, [Count(Parameter = "sourceCapacityInput")] Span<ulong> sources)
        {
            // ImplicitCountSpanOverloader
            return EnumerateBoundSourcesForAction(session, enumerateInfo, (uint) sources.Length, ref sourceCountOutput, ref sources.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateBoundSourcesForAction([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BoundSourcesForActionEnumerateInfo enumerateInfo, [Count(Count = 0)] uint* sourceCountOutput, [Count(Parameter = "sourceCapacityInput")] Span<ulong> sources)
        {
            // ImplicitCountSpanOverloader
            return EnumerateBoundSourcesForAction(session, in enumerateInfo, (uint) sources.Length, sourceCountOutput, ref sources.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateBoundSourcesForAction([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BoundSourcesForActionEnumerateInfo enumerateInfo, [Count(Count = 0)] ref uint sourceCountOutput, [Count(Parameter = "sourceCapacityInput")] Span<ulong> sources)
        {
            // ImplicitCountSpanOverloader
            return EnumerateBoundSourcesForAction(session, in enumerateInfo, (uint) sources.Length, ref sourceCountOutput, ref sources.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateEnvironmentBlendModes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint* environmentBlendModeCountOutput, [Count(Parameter = "environmentBlendModeCapacityInput")] Span<EnvironmentBlendMode> environmentBlendModes)
        {
            // ImplicitCountSpanOverloader
            return EnumerateEnvironmentBlendModes(instance, systemId, viewConfigurationType, (uint) environmentBlendModes.Length, environmentBlendModeCountOutput, ref environmentBlendModes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateEnvironmentBlendModes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] ref uint environmentBlendModeCountOutput, [Count(Parameter = "environmentBlendModeCapacityInput")] Span<EnvironmentBlendMode> environmentBlendModes)
        {
            // ImplicitCountSpanOverloader
            return EnumerateEnvironmentBlendModes(instance, systemId, viewConfigurationType, (uint) environmentBlendModes.Length, ref environmentBlendModeCountOutput, ref environmentBlendModes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* layerName, [Count(Count = 0)] uint* propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] Span<ExtensionProperties> properties)
        {
            // ImplicitCountSpanOverloader
            return EnumerateInstanceExtensionProperties(layerName, (uint) properties.Length, propertyCountOutput, ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* layerName, [Count(Count = 0)] ref uint propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] Span<ExtensionProperties> properties)
        {
            // ImplicitCountSpanOverloader
            return EnumerateInstanceExtensionProperties(layerName, (uint) properties.Length, ref propertyCountOutput, ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte layerName, [Count(Count = 0)] uint* propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] Span<ExtensionProperties> properties)
        {
            // ImplicitCountSpanOverloader
            return EnumerateInstanceExtensionProperties(in layerName, (uint) properties.Length, propertyCountOutput, ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte layerName, [Count(Count = 0)] ref uint propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] Span<ExtensionProperties> properties)
        {
            // ImplicitCountSpanOverloader
            return EnumerateInstanceExtensionProperties(in layerName, (uint) properties.Length, ref propertyCountOutput, ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateInstanceExtensionProperties([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string layerName, [Count(Count = 0)] uint* propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] Span<ExtensionProperties> properties)
        {
            // ImplicitCountSpanOverloader
            return EnumerateInstanceExtensionProperties(layerName, (uint) properties.Length, propertyCountOutput, ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateInstanceExtensionProperties([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string layerName, [Count(Count = 0)] ref uint propertyCountOutput, [Count(Parameter = "propertyCapacityInput")] Span<ExtensionProperties> properties)
        {
            // ImplicitCountSpanOverloader
            return EnumerateInstanceExtensionProperties(layerName, (uint) properties.Length, ref propertyCountOutput, ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateReferenceSpaces([Count(Count = 0)] Session session, [Count(Count = 0)] uint* spaceCountOutput, [Count(Parameter = "spaceCapacityInput")] Span<ReferenceSpaceType> spaces)
        {
            // ImplicitCountSpanOverloader
            return EnumerateReferenceSpaces(session, (uint) spaces.Length, spaceCountOutput, ref spaces.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateReferenceSpaces([Count(Count = 0)] Session session, [Count(Count = 0)] ref uint spaceCountOutput, [Count(Parameter = "spaceCapacityInput")] Span<ReferenceSpaceType> spaces)
        {
            // ImplicitCountSpanOverloader
            return EnumerateReferenceSpaces(session, (uint) spaces.Length, ref spaceCountOutput, ref spaces.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateSwapchainFormats([Count(Count = 0)] Session session, [Count(Count = 0)] uint* formatCountOutput, [Count(Parameter = "formatCapacityInput")] Span<long> formats)
        {
            // ImplicitCountSpanOverloader
            return EnumerateSwapchainFormats(session, (uint) formats.Length, formatCountOutput, ref formats.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateSwapchainFormats([Count(Count = 0)] Session session, [Count(Count = 0)] ref uint formatCountOutput, [Count(Parameter = "formatCapacityInput")] Span<long> formats)
        {
            // ImplicitCountSpanOverloader
            return EnumerateSwapchainFormats(session, (uint) formats.Length, ref formatCountOutput, ref formats.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateSwapchainImages([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0)] uint* imageCountOutput, [Count(Parameter = "imageCapacityInput")] Span<SwapchainImageBaseHeader> images)
        {
            // ImplicitCountSpanOverloader
            return EnumerateSwapchainImages(swapchain, (uint) images.Length, imageCountOutput, ref images.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateSwapchainImages([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0)] ref uint imageCountOutput, [Count(Parameter = "imageCapacityInput")] Span<SwapchainImageBaseHeader> images)
        {
            // ImplicitCountSpanOverloader
            return EnumerateSwapchainImages(swapchain, (uint) images.Length, ref imageCountOutput, ref images.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateViewConfiguration([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint* viewConfigurationTypeCountOutput, [Count(Parameter = "viewConfigurationTypeCapacityInput")] Span<ViewConfigurationType> viewConfigurationTypes)
        {
            // ImplicitCountSpanOverloader
            return EnumerateViewConfiguration(instance, systemId, (uint) viewConfigurationTypes.Length, viewConfigurationTypeCountOutput, ref viewConfigurationTypes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateViewConfiguration([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ref uint viewConfigurationTypeCountOutput, [Count(Parameter = "viewConfigurationTypeCapacityInput")] Span<ViewConfigurationType> viewConfigurationTypes)
        {
            // ImplicitCountSpanOverloader
            return EnumerateViewConfiguration(instance, systemId, (uint) viewConfigurationTypes.Length, ref viewConfigurationTypeCountOutput, ref viewConfigurationTypes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateViewConfigurationView([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint* viewCountOutput, [Count(Parameter = "viewCapacityInput")] Span<ViewConfigurationView> views)
        {
            // ImplicitCountSpanOverloader
            return EnumerateViewConfigurationView(instance, systemId, viewConfigurationType, (uint) views.Length, viewCountOutput, ref views.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateViewConfigurationView([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] ref uint viewCountOutput, [Count(Parameter = "viewCapacityInput")] Span<ViewConfigurationView> views)
        {
            // ImplicitCountSpanOverloader
            return EnumerateViewConfigurationView(instance, systemId, viewConfigurationType, (uint) views.Length, ref viewCountOutput, ref views.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InputSourceLocalizedNameGetInfo* getInfo, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetInputSourceLocalizedName(session, getInfo, (uint) buffer.Length, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] InputSourceLocalizedNameGetInfo* getInfo, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetInputSourceLocalizedName(session, getInfo, (uint) buffer.Length, ref bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InputSourceLocalizedNameGetInfo getInfo, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetInputSourceLocalizedName(session, in getInfo, (uint) buffer.Length, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InputSourceLocalizedNameGetInfo getInfo, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetInputSourceLocalizedName(session, in getInfo, (uint) buffer.Length, ref bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ViewLocateInfo* viewLocateInfo, [Count(Count = 0)] ViewState* viewState, [Count(Count = 0)] uint* viewCountOutput, [Count(Parameter = "viewCapacityInput")] Span<View> views)
        {
            // ImplicitCountSpanOverloader
            return LocateView(session, viewLocateInfo, viewState, (uint) views.Length, viewCountOutput, ref views.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ViewLocateInfo* viewLocateInfo, [Count(Count = 0)] ViewState* viewState, [Count(Count = 0)] ref uint viewCountOutput, [Count(Parameter = "viewCapacityInput")] Span<View> views)
        {
            // ImplicitCountSpanOverloader
            return LocateView(session, viewLocateInfo, viewState, (uint) views.Length, ref viewCountOutput, ref views.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ViewLocateInfo* viewLocateInfo, [Count(Count = 0)] ref ViewState viewState, [Count(Count = 0)] uint* viewCountOutput, [Count(Parameter = "viewCapacityInput")] Span<View> views)
        {
            // ImplicitCountSpanOverloader
            return LocateView(session, viewLocateInfo, ref viewState, (uint) views.Length, viewCountOutput, ref views.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ViewLocateInfo* viewLocateInfo, [Count(Count = 0)] ref ViewState viewState, [Count(Count = 0)] ref uint viewCountOutput, [Count(Parameter = "viewCapacityInput")] Span<View> views)
        {
            // ImplicitCountSpanOverloader
            return LocateView(session, viewLocateInfo, ref viewState, (uint) views.Length, ref viewCountOutput, ref views.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ViewLocateInfo viewLocateInfo, [Count(Count = 0)] ViewState* viewState, [Count(Count = 0)] uint* viewCountOutput, [Count(Parameter = "viewCapacityInput")] Span<View> views)
        {
            // ImplicitCountSpanOverloader
            return LocateView(session, in viewLocateInfo, viewState, (uint) views.Length, viewCountOutput, ref views.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ViewLocateInfo viewLocateInfo, [Count(Count = 0)] ViewState* viewState, [Count(Count = 0)] ref uint viewCountOutput, [Count(Parameter = "viewCapacityInput")] Span<View> views)
        {
            // ImplicitCountSpanOverloader
            return LocateView(session, in viewLocateInfo, viewState, (uint) views.Length, ref viewCountOutput, ref views.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ViewLocateInfo viewLocateInfo, [Count(Count = 0)] ref ViewState viewState, [Count(Count = 0)] uint* viewCountOutput, [Count(Parameter = "viewCapacityInput")] Span<View> views)
        {
            // ImplicitCountSpanOverloader
            return LocateView(session, in viewLocateInfo, ref viewState, (uint) views.Length, viewCountOutput, ref views.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ViewLocateInfo viewLocateInfo, [Count(Count = 0)] ref ViewState viewState, [Count(Count = 0)] ref uint viewCountOutput, [Count(Parameter = "viewCapacityInput")] Span<View> views)
        {
            // ImplicitCountSpanOverloader
            return LocateView(session, in viewLocateInfo, ref viewState, (uint) views.Length, ref viewCountOutput, ref views.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result PathToString([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong path, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return PathToString(instance, path, (uint) buffer.Length, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result PathToString([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong path, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return PathToString(instance, path, (uint) buffer.Length, ref bufferCountOutput, ref buffer.GetPinnableReference());
        }


        public XR(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

