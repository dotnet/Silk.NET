// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
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
        [NativeName("Name", "XR_FALSE")]
        public const uint False = 0;
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_ACTION_NAME_SIZE")]
        public const uint MaxActionNameSize = 64;
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_ACTION_SET_NAME_SIZE")]
        public const uint MaxActionSetNameSize = 64;
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_API_LAYER_DESCRIPTION_SIZE")]
        public const uint MaxApiLayerDescriptionSize = 256;
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_API_LAYER_NAME_SIZE")]
        public const uint MaxApiLayerNameSize = 256;
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_APPLICATION_NAME_SIZE")]
        public const uint MaxApplicationNameSize = 128;
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_ENGINE_NAME_SIZE")]
        public const uint MaxEngineNameSize = 128;
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_EXTENSION_NAME_SIZE")]
        public const uint MaxExtensionNameSize = 128;
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_GRAPHICS_APIS_SUPPORTED")]
        public const uint MaxGraphicsApisSupported = 32;
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_LOCALIZED_ACTION_NAME_SIZE")]
        public const uint MaxLocalizedActionNameSize = 128;
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_LOCALIZED_ACTION_SET_NAME_SIZE")]
        public const uint MaxLocalizedActionSetNameSize = 128;
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_PATH_LENGTH")]
        public const uint MaxPathLength = 256;
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_RESULT_STRING_SIZE")]
        public const uint MaxResultStringSize = 64;
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_RUNTIME_NAME_SIZE")]
        public const uint MaxRuntimeNameSize = 128;
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_STRUCTURE_NAME_SIZE")]
        public const uint MaxStructureNameSize = 64;
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MAX_SYSTEM_NAME_SIZE")]
        public const uint MaxSystemNameSize = 256;
        [NativeName("Type", "")]
        [NativeName("Name", "XR_MIN_COMPOSITION_LAYERS_SUPPORTED")]
        public const uint MinCompositionLayersSupported = 16;
        [NativeName("Type", "")]
        [NativeName("Name", "XR_TRUE")]
        public const uint True = 1;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrAcquireSwapchainImage")]
        public unsafe partial Result AcquireSwapchainImage([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0), Flow(FlowDirection.In)] SwapchainImageAcquireInfo* acquireInfo, [Count(Count = 0)] uint* index);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrAcquireSwapchainImage")]
        public unsafe partial Result AcquireSwapchainImage([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0), Flow(FlowDirection.In)] SwapchainImageAcquireInfo* acquireInfo, [Count(Count = 0)] ref uint index);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrAcquireSwapchainImage")]
        public unsafe partial Result AcquireSwapchainImage([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0), Flow(FlowDirection.In)] in SwapchainImageAcquireInfo acquireInfo, [Count(Count = 0)] uint* index);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrAcquireSwapchainImage")]
        public partial Result AcquireSwapchainImage([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0), Flow(FlowDirection.In)] in SwapchainImageAcquireInfo acquireInfo, [Count(Count = 0)] ref uint index);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrApplyHapticFeedback")]
        public unsafe partial Result ApplyHapticFeedback([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] HapticActionInfo* hapticActionInfo, [Count(Count = 0), Flow(FlowDirection.In)] HapticBaseHeader* hapticFeedback);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrApplyHapticFeedback")]
        public unsafe partial Result ApplyHapticFeedback([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] HapticActionInfo* hapticActionInfo, [Count(Count = 0), Flow(FlowDirection.In)] in HapticBaseHeader hapticFeedback);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrApplyHapticFeedback")]
        public unsafe partial Result ApplyHapticFeedback([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in HapticActionInfo hapticActionInfo, [Count(Count = 0), Flow(FlowDirection.In)] HapticBaseHeader* hapticFeedback);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrApplyHapticFeedback")]
        public partial Result ApplyHapticFeedback([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in HapticActionInfo hapticActionInfo, [Count(Count = 0), Flow(FlowDirection.In)] in HapticBaseHeader hapticFeedback);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrAttachSessionActionSets")]
        public unsafe partial Result AttachSessionActionSets([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] SessionActionSetsAttachInfo* attachInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrAttachSessionActionSets")]
        public partial Result AttachSessionActionSets([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in SessionActionSetsAttachInfo attachInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrBeginFrame")]
        public unsafe partial Result BeginFrame([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] FrameBeginInfo* frameBeginInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrBeginFrame")]
        public partial Result BeginFrame([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in FrameBeginInfo frameBeginInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrBeginSession")]
        public unsafe partial Result BeginSession([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] SessionBeginInfo* beginInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrBeginSession")]
        public partial Result BeginSession([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in SessionBeginInfo beginInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateAction")]
        public unsafe partial Result CreateAction([Count(Count = 0)] ActionSet actionSet, [Count(Count = 0), Flow(FlowDirection.In)] ActionCreateInfo* createInfo, [Count(Count = 0)] Action* action);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateAction")]
        public unsafe partial Result CreateAction([Count(Count = 0)] ActionSet actionSet, [Count(Count = 0), Flow(FlowDirection.In)] ActionCreateInfo* createInfo, [Count(Count = 0)] ref Action action);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateAction")]
        public unsafe partial Result CreateAction([Count(Count = 0)] ActionSet actionSet, [Count(Count = 0), Flow(FlowDirection.In)] in ActionCreateInfo createInfo, [Count(Count = 0)] Action* action);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateAction")]
        public partial Result CreateAction([Count(Count = 0)] ActionSet actionSet, [Count(Count = 0), Flow(FlowDirection.In)] in ActionCreateInfo createInfo, [Count(Count = 0)] ref Action action);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateActionSet")]
        public unsafe partial Result CreateActionSet([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ActionSetCreateInfo* createInfo, [Count(Count = 0)] ActionSet* actionSet);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateActionSet")]
        public unsafe partial Result CreateActionSet([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ActionSetCreateInfo* createInfo, [Count(Count = 0)] ref ActionSet actionSet);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateActionSet")]
        public unsafe partial Result CreateActionSet([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in ActionSetCreateInfo createInfo, [Count(Count = 0)] ActionSet* actionSet);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateActionSet")]
        public partial Result CreateActionSet([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in ActionSetCreateInfo createInfo, [Count(Count = 0)] ref ActionSet actionSet);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateActionSpace")]
        public unsafe partial Result CreateActionSpace([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ActionSpaceCreateInfo* createInfo, [Count(Count = 0)] Space* space);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateActionSpace")]
        public unsafe partial Result CreateActionSpace([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ActionSpaceCreateInfo* createInfo, [Count(Count = 0)] ref Space space);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateActionSpace")]
        public unsafe partial Result CreateActionSpace([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in ActionSpaceCreateInfo createInfo, [Count(Count = 0)] Space* space);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateActionSpace")]
        public partial Result CreateActionSpace([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in ActionSpaceCreateInfo createInfo, [Count(Count = 0)] ref Space space);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateInstance")]
        public unsafe partial Result CreateInstance([Count(Count = 0), Flow(FlowDirection.In)] InstanceCreateInfo* createInfo, [Count(Count = 0)] Instance* instance);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateInstance")]
        public unsafe partial Result CreateInstance([Count(Count = 0), Flow(FlowDirection.In)] InstanceCreateInfo* createInfo, [Count(Count = 0)] ref Instance instance);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateInstance")]
        public unsafe partial Result CreateInstance([Count(Count = 0), Flow(FlowDirection.In)] in InstanceCreateInfo createInfo, [Count(Count = 0)] Instance* instance);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateInstance")]
        public partial Result CreateInstance([Count(Count = 0), Flow(FlowDirection.In)] in InstanceCreateInfo createInfo, [Count(Count = 0)] ref Instance instance);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateReferenceSpace")]
        public unsafe partial Result CreateReferenceSpace([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ReferenceSpaceCreateInfo* createInfo, [Count(Count = 0)] Space* space);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateReferenceSpace")]
        public unsafe partial Result CreateReferenceSpace([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ReferenceSpaceCreateInfo* createInfo, [Count(Count = 0)] ref Space space);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateReferenceSpace")]
        public unsafe partial Result CreateReferenceSpace([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in ReferenceSpaceCreateInfo createInfo, [Count(Count = 0)] Space* space);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateReferenceSpace")]
        public partial Result CreateReferenceSpace([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in ReferenceSpaceCreateInfo createInfo, [Count(Count = 0)] ref Space space);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSession")]
        public unsafe partial Result CreateSession([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] SessionCreateInfo* createInfo, [Count(Count = 0)] Session* session);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSession")]
        public unsafe partial Result CreateSession([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] SessionCreateInfo* createInfo, [Count(Count = 0)] ref Session session);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSession")]
        public unsafe partial Result CreateSession([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in SessionCreateInfo createInfo, [Count(Count = 0)] Session* session);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSession")]
        public partial Result CreateSession([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in SessionCreateInfo createInfo, [Count(Count = 0)] ref Session session);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSwapchain")]
        public unsafe partial Result CreateSwapchain([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] SwapchainCreateInfo* createInfo, [Count(Count = 0)] Swapchain* swapchain);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSwapchain")]
        public unsafe partial Result CreateSwapchain([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] SwapchainCreateInfo* createInfo, [Count(Count = 0)] ref Swapchain swapchain);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSwapchain")]
        public unsafe partial Result CreateSwapchain([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in SwapchainCreateInfo createInfo, [Count(Count = 0)] Swapchain* swapchain);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSwapchain")]
        public partial Result CreateSwapchain([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in SwapchainCreateInfo createInfo, [Count(Count = 0)] ref Swapchain swapchain);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrDestroyAction")]
        public partial Result DestroyAction([Count(Count = 0)] Action action);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrDestroyActionSet")]
        public partial Result DestroyActionSet([Count(Count = 0)] ActionSet actionSet);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrDestroyInstance")]
        public partial Result DestroyInstance([Count(Count = 0)] Instance instance);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrDestroySession")]
        public partial Result DestroySession([Count(Count = 0)] Session session);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrDestroySpace")]
        public partial Result DestroySpace([Count(Count = 0)] Space space);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrDestroySwapchain")]
        public partial Result DestroySwapchain([Count(Count = 0)] Swapchain swapchain);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEndFrame")]
        public unsafe partial Result EndFrame([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] FrameEndInfo* frameEndInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEndFrame")]
        public partial Result EndFrame([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in FrameEndInfo frameEndInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEndSession")]
        public partial Result EndSession([Count(Count = 0)] Session session);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateApiLayerProperties")]
        public unsafe partial Result EnumerateApiLayerProperties([Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] uint* propertyCountOutput, [Count(Computed = "propertyCapacityInput")] ApiLayerProperties* properties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateApiLayerProperties")]
        public unsafe partial Result EnumerateApiLayerProperties([Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] uint* propertyCountOutput, [Count(Computed = "propertyCapacityInput")] ref ApiLayerProperties properties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateApiLayerProperties")]
        public unsafe partial Result EnumerateApiLayerProperties([Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] ref uint propertyCountOutput, [Count(Computed = "propertyCapacityInput")] ApiLayerProperties* properties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateApiLayerProperties")]
        public partial Result EnumerateApiLayerProperties([Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] ref uint propertyCountOutput, [Count(Computed = "propertyCapacityInput")] ref ApiLayerProperties properties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateBoundSourcesForAction")]
        public unsafe partial Result EnumerateBoundSourcesForAction([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] BoundSourcesForActionEnumerateInfo* enumerateInfo, [Count(Count = 0)] uint sourceCapacityInput, [Count(Count = 0)] uint* sourceCountOutput, [Count(Computed = "sourceCapacityInput")] ulong* sources);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateBoundSourcesForAction")]
        public unsafe partial Result EnumerateBoundSourcesForAction([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] BoundSourcesForActionEnumerateInfo* enumerateInfo, [Count(Count = 0)] uint sourceCapacityInput, [Count(Count = 0)] uint* sourceCountOutput, [Count(Computed = "sourceCapacityInput")] ref ulong sources);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateBoundSourcesForAction")]
        public unsafe partial Result EnumerateBoundSourcesForAction([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] BoundSourcesForActionEnumerateInfo* enumerateInfo, [Count(Count = 0)] uint sourceCapacityInput, [Count(Count = 0)] ref uint sourceCountOutput, [Count(Computed = "sourceCapacityInput")] ulong* sources);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateBoundSourcesForAction")]
        public unsafe partial Result EnumerateBoundSourcesForAction([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] BoundSourcesForActionEnumerateInfo* enumerateInfo, [Count(Count = 0)] uint sourceCapacityInput, [Count(Count = 0)] ref uint sourceCountOutput, [Count(Computed = "sourceCapacityInput")] ref ulong sources);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateBoundSourcesForAction")]
        public unsafe partial Result EnumerateBoundSourcesForAction([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in BoundSourcesForActionEnumerateInfo enumerateInfo, [Count(Count = 0)] uint sourceCapacityInput, [Count(Count = 0)] uint* sourceCountOutput, [Count(Computed = "sourceCapacityInput")] ulong* sources);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateBoundSourcesForAction")]
        public unsafe partial Result EnumerateBoundSourcesForAction([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in BoundSourcesForActionEnumerateInfo enumerateInfo, [Count(Count = 0)] uint sourceCapacityInput, [Count(Count = 0)] uint* sourceCountOutput, [Count(Computed = "sourceCapacityInput")] ref ulong sources);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateBoundSourcesForAction")]
        public unsafe partial Result EnumerateBoundSourcesForAction([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in BoundSourcesForActionEnumerateInfo enumerateInfo, [Count(Count = 0)] uint sourceCapacityInput, [Count(Count = 0)] ref uint sourceCountOutput, [Count(Computed = "sourceCapacityInput")] ulong* sources);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateBoundSourcesForAction")]
        public partial Result EnumerateBoundSourcesForAction([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in BoundSourcesForActionEnumerateInfo enumerateInfo, [Count(Count = 0)] uint sourceCapacityInput, [Count(Count = 0)] ref uint sourceCountOutput, [Count(Computed = "sourceCapacityInput")] ref ulong sources);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateEnvironmentBlendModes")]
        public unsafe partial Result EnumerateEnvironmentBlendModes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint environmentBlendModeCapacityInput, [Count(Count = 0)] uint* environmentBlendModeCountOutput, [Count(Computed = "environmentBlendModeCapacityInput")] EnvironmentBlendMode* environmentBlendModes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateEnvironmentBlendModes")]
        public unsafe partial Result EnumerateEnvironmentBlendModes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint environmentBlendModeCapacityInput, [Count(Count = 0)] uint* environmentBlendModeCountOutput, [Count(Computed = "environmentBlendModeCapacityInput")] ref EnvironmentBlendMode environmentBlendModes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateEnvironmentBlendModes")]
        public unsafe partial Result EnumerateEnvironmentBlendModes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint environmentBlendModeCapacityInput, [Count(Count = 0)] ref uint environmentBlendModeCountOutput, [Count(Computed = "environmentBlendModeCapacityInput")] EnvironmentBlendMode* environmentBlendModes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateEnvironmentBlendModes")]
        public partial Result EnumerateEnvironmentBlendModes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint environmentBlendModeCapacityInput, [Count(Count = 0)] ref uint environmentBlendModeCountOutput, [Count(Computed = "environmentBlendModeCapacityInput")] ref EnvironmentBlendMode environmentBlendModes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInstanceExtensionProperties")]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(FlowDirection.In)] byte* layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] uint* propertyCountOutput, [Count(Computed = "propertyCapacityInput")] ExtensionProperties* properties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInstanceExtensionProperties")]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(FlowDirection.In)] byte* layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] uint* propertyCountOutput, [Count(Computed = "propertyCapacityInput")] ref ExtensionProperties properties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInstanceExtensionProperties")]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(FlowDirection.In)] byte* layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] ref uint propertyCountOutput, [Count(Computed = "propertyCapacityInput")] ExtensionProperties* properties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInstanceExtensionProperties")]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(FlowDirection.In)] byte* layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] ref uint propertyCountOutput, [Count(Computed = "propertyCapacityInput")] ref ExtensionProperties properties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInstanceExtensionProperties")]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(FlowDirection.In)] in byte layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] uint* propertyCountOutput, [Count(Computed = "propertyCapacityInput")] ExtensionProperties* properties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInstanceExtensionProperties")]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(FlowDirection.In)] in byte layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] uint* propertyCountOutput, [Count(Computed = "propertyCapacityInput")] ref ExtensionProperties properties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInstanceExtensionProperties")]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(FlowDirection.In)] in byte layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] ref uint propertyCountOutput, [Count(Computed = "propertyCapacityInput")] ExtensionProperties* properties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInstanceExtensionProperties")]
        public partial Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(FlowDirection.In)] in byte layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] ref uint propertyCountOutput, [Count(Computed = "propertyCapacityInput")] ref ExtensionProperties properties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInstanceExtensionProperties")]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Flow(FlowDirection.In)] string layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] uint* propertyCountOutput, [Count(Computed = "propertyCapacityInput")] ExtensionProperties* properties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInstanceExtensionProperties")]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Flow(FlowDirection.In)] string layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] uint* propertyCountOutput, [Count(Computed = "propertyCapacityInput")] ref ExtensionProperties properties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInstanceExtensionProperties")]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Flow(FlowDirection.In)] string layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] ref uint propertyCountOutput, [Count(Computed = "propertyCapacityInput")] ExtensionProperties* properties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInstanceExtensionProperties")]
        public partial Result EnumerateInstanceExtensionProperties([Flow(FlowDirection.In)] string layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] ref uint propertyCountOutput, [Count(Computed = "propertyCapacityInput")] ref ExtensionProperties properties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateReferenceSpaces")]
        public unsafe partial Result EnumerateReferenceSpaces([Count(Count = 0)] Session session, [Count(Count = 0)] uint spaceCapacityInput, [Count(Count = 0)] uint* spaceCountOutput, [Count(Computed = "spaceCapacityInput")] ReferenceSpaceType* spaces);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateReferenceSpaces")]
        public unsafe partial Result EnumerateReferenceSpaces([Count(Count = 0)] Session session, [Count(Count = 0)] uint spaceCapacityInput, [Count(Count = 0)] uint* spaceCountOutput, [Count(Computed = "spaceCapacityInput")] ref ReferenceSpaceType spaces);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateReferenceSpaces")]
        public unsafe partial Result EnumerateReferenceSpaces([Count(Count = 0)] Session session, [Count(Count = 0)] uint spaceCapacityInput, [Count(Count = 0)] ref uint spaceCountOutput, [Count(Computed = "spaceCapacityInput")] ReferenceSpaceType* spaces);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateReferenceSpaces")]
        public partial Result EnumerateReferenceSpaces([Count(Count = 0)] Session session, [Count(Count = 0)] uint spaceCapacityInput, [Count(Count = 0)] ref uint spaceCountOutput, [Count(Computed = "spaceCapacityInput")] ref ReferenceSpaceType spaces);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSwapchainFormats")]
        public unsafe partial Result EnumerateSwapchainFormats([Count(Count = 0)] Session session, [Count(Count = 0)] uint formatCapacityInput, [Count(Count = 0)] uint* formatCountOutput, [Count(Computed = "formatCapacityInput")] long* formats);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSwapchainFormats")]
        public unsafe partial Result EnumerateSwapchainFormats([Count(Count = 0)] Session session, [Count(Count = 0)] uint formatCapacityInput, [Count(Count = 0)] uint* formatCountOutput, [Count(Computed = "formatCapacityInput")] ref long formats);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSwapchainFormats")]
        public unsafe partial Result EnumerateSwapchainFormats([Count(Count = 0)] Session session, [Count(Count = 0)] uint formatCapacityInput, [Count(Count = 0)] ref uint formatCountOutput, [Count(Computed = "formatCapacityInput")] long* formats);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSwapchainFormats")]
        public partial Result EnumerateSwapchainFormats([Count(Count = 0)] Session session, [Count(Count = 0)] uint formatCapacityInput, [Count(Count = 0)] ref uint formatCountOutput, [Count(Computed = "formatCapacityInput")] ref long formats);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSwapchainImages")]
        public unsafe partial Result EnumerateSwapchainImages([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0)] uint imageCapacityInput, [Count(Count = 0)] uint* imageCountOutput, [Count(Computed = "imageCapacityInput")] SwapchainImageBaseHeader* images);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSwapchainImages")]
        public unsafe partial Result EnumerateSwapchainImages([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0)] uint imageCapacityInput, [Count(Count = 0)] uint* imageCountOutput, [Count(Computed = "imageCapacityInput")] ref SwapchainImageBaseHeader images);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSwapchainImages")]
        public unsafe partial Result EnumerateSwapchainImages([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0)] uint imageCapacityInput, [Count(Count = 0)] ref uint imageCountOutput, [Count(Computed = "imageCapacityInput")] SwapchainImageBaseHeader* images);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSwapchainImages")]
        public partial Result EnumerateSwapchainImages([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0)] uint imageCapacityInput, [Count(Count = 0)] ref uint imageCountOutput, [Count(Computed = "imageCapacityInput")] ref SwapchainImageBaseHeader images);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateViewConfigurations")]
        public unsafe partial Result EnumerateViewConfiguration([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint viewConfigurationTypeCapacityInput, [Count(Count = 0)] uint* viewConfigurationTypeCountOutput, [Count(Computed = "viewConfigurationTypeCapacityInput")] ViewConfigurationType* viewConfigurationTypes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateViewConfigurations")]
        public unsafe partial Result EnumerateViewConfiguration([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint viewConfigurationTypeCapacityInput, [Count(Count = 0)] uint* viewConfigurationTypeCountOutput, [Count(Computed = "viewConfigurationTypeCapacityInput")] ref ViewConfigurationType viewConfigurationTypes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateViewConfigurations")]
        public unsafe partial Result EnumerateViewConfiguration([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint viewConfigurationTypeCapacityInput, [Count(Count = 0)] ref uint viewConfigurationTypeCountOutput, [Count(Computed = "viewConfigurationTypeCapacityInput")] ViewConfigurationType* viewConfigurationTypes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateViewConfigurations")]
        public partial Result EnumerateViewConfiguration([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint viewConfigurationTypeCapacityInput, [Count(Count = 0)] ref uint viewConfigurationTypeCountOutput, [Count(Computed = "viewConfigurationTypeCapacityInput")] ref ViewConfigurationType viewConfigurationTypes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateViewConfigurationViews")]
        public unsafe partial Result EnumerateViewConfigurationView([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] uint* viewCountOutput, [Count(Computed = "viewCapacityInput")] ViewConfigurationView* views);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateViewConfigurationViews")]
        public unsafe partial Result EnumerateViewConfigurationView([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] uint* viewCountOutput, [Count(Computed = "viewCapacityInput")] ref ViewConfigurationView views);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateViewConfigurationViews")]
        public unsafe partial Result EnumerateViewConfigurationView([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] ref uint viewCountOutput, [Count(Computed = "viewCapacityInput")] ViewConfigurationView* views);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateViewConfigurationViews")]
        public partial Result EnumerateViewConfigurationView([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] ref uint viewCountOutput, [Count(Computed = "viewCapacityInput")] ref ViewConfigurationView views);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetActionStateBoolean")]
        public unsafe partial Result GetActionStateBoolean([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ActionStateGetInfo* getInfo, [Count(Count = 0)] ActionStateBoolean* state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetActionStateBoolean")]
        public unsafe partial Result GetActionStateBoolean([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ActionStateGetInfo* getInfo, [Count(Count = 0)] ref ActionStateBoolean state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetActionStateBoolean")]
        public unsafe partial Result GetActionStateBoolean([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in ActionStateGetInfo getInfo, [Count(Count = 0)] ActionStateBoolean* state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetActionStateBoolean")]
        public partial Result GetActionStateBoolean([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in ActionStateGetInfo getInfo, [Count(Count = 0)] ref ActionStateBoolean state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetActionStateFloat")]
        public unsafe partial Result GetActionStateFloat([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ActionStateGetInfo* getInfo, [Count(Count = 0)] ActionStateFloat* state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetActionStateFloat")]
        public unsafe partial Result GetActionStateFloat([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ActionStateGetInfo* getInfo, [Count(Count = 0)] ref ActionStateFloat state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetActionStateFloat")]
        public unsafe partial Result GetActionStateFloat([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in ActionStateGetInfo getInfo, [Count(Count = 0)] ActionStateFloat* state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetActionStateFloat")]
        public partial Result GetActionStateFloat([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in ActionStateGetInfo getInfo, [Count(Count = 0)] ref ActionStateFloat state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetActionStatePose")]
        public unsafe partial Result GetActionStatePose([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ActionStateGetInfo* getInfo, [Count(Count = 0)] ActionStatePose* state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetActionStatePose")]
        public unsafe partial Result GetActionStatePose([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ActionStateGetInfo* getInfo, [Count(Count = 0)] ref ActionStatePose state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetActionStatePose")]
        public unsafe partial Result GetActionStatePose([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in ActionStateGetInfo getInfo, [Count(Count = 0)] ActionStatePose* state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetActionStatePose")]
        public partial Result GetActionStatePose([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in ActionStateGetInfo getInfo, [Count(Count = 0)] ref ActionStatePose state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetActionStateVector2f")]
        public unsafe partial Result GetActionStateVector2([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ActionStateGetInfo* getInfo, [Count(Count = 0)] ActionStateVector2f* state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetActionStateVector2f")]
        public unsafe partial Result GetActionStateVector2([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ActionStateGetInfo* getInfo, [Count(Count = 0)] ref ActionStateVector2f state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetActionStateVector2f")]
        public unsafe partial Result GetActionStateVector2([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in ActionStateGetInfo getInfo, [Count(Count = 0)] ActionStateVector2f* state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetActionStateVector2f")]
        public partial Result GetActionStateVector2([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in ActionStateGetInfo getInfo, [Count(Count = 0)] ref ActionStateVector2f state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetCurrentInteractionProfile")]
        public unsafe partial Result GetCurrentInteractionProfile([Count(Count = 0)] Session session, [Count(Count = 0)] ulong topLevelUserPath, [Count(Count = 0)] InteractionProfileState* interactionProfile);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetCurrentInteractionProfile")]
        public partial Result GetCurrentInteractionProfile([Count(Count = 0)] Session session, [Count(Count = 0)] ulong topLevelUserPath, [Count(Count = 0)] ref InteractionProfileState interactionProfile);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetInputSourceLocalizedName")]
        public unsafe partial Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] InputSourceLocalizedNameGetInfo* getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Computed = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetInputSourceLocalizedName")]
        public unsafe partial Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] InputSourceLocalizedNameGetInfo* getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Computed = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetInputSourceLocalizedName")]
        public unsafe partial Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] InputSourceLocalizedNameGetInfo* getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, string buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetInputSourceLocalizedName")]
        public unsafe partial Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] InputSourceLocalizedNameGetInfo* getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Computed = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetInputSourceLocalizedName")]
        public unsafe partial Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] InputSourceLocalizedNameGetInfo* getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Computed = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetInputSourceLocalizedName")]
        public unsafe partial Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] InputSourceLocalizedNameGetInfo* getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, string buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetInputSourceLocalizedName")]
        public unsafe partial Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in InputSourceLocalizedNameGetInfo getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Computed = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetInputSourceLocalizedName")]
        public unsafe partial Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in InputSourceLocalizedNameGetInfo getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Computed = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetInputSourceLocalizedName")]
        public unsafe partial Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in InputSourceLocalizedNameGetInfo getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, string buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetInputSourceLocalizedName")]
        public unsafe partial Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in InputSourceLocalizedNameGetInfo getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Computed = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetInputSourceLocalizedName")]
        public partial Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in InputSourceLocalizedNameGetInfo getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Computed = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetInputSourceLocalizedName")]
        public partial Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in InputSourceLocalizedNameGetInfo getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, string buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetInstanceProcAddr")]
        public unsafe partial Result GetInstanceProcAddr([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] byte* name, [Count(Count = 0)] FuncPtr* function);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetInstanceProcAddr")]
        public unsafe partial Result GetInstanceProcAddr([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] byte* name, [Count(Count = 0)] ref FuncPtr function);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetInstanceProcAddr")]
        public unsafe partial Result GetInstanceProcAddr([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in byte name, [Count(Count = 0)] FuncPtr* function);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetInstanceProcAddr")]
        public partial Result GetInstanceProcAddr([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in byte name, [Count(Count = 0)] ref FuncPtr function);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetInstanceProcAddr")]
        public unsafe partial Result GetInstanceProcAddr([Count(Count = 0)] Instance instance, [Flow(FlowDirection.In)] string name, [Count(Count = 0)] FuncPtr* function);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetInstanceProcAddr")]
        public partial Result GetInstanceProcAddr([Count(Count = 0)] Instance instance, [Flow(FlowDirection.In)] string name, [Count(Count = 0)] ref FuncPtr function);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetInstanceProperties")]
        public unsafe partial Result GetInstanceProperties([Count(Count = 0)] Instance instance, [Count(Count = 0)] InstanceProperties* instanceProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetInstanceProperties")]
        public partial Result GetInstanceProperties([Count(Count = 0)] Instance instance, [Count(Count = 0)] ref InstanceProperties instanceProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetReferenceSpaceBoundsRect")]
        public unsafe partial Result GetReferenceSpaceBoundsRect([Count(Count = 0)] Session session, [Count(Count = 0)] ReferenceSpaceType referenceSpaceType, [Count(Count = 0)] Extent2Df* bounds);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetReferenceSpaceBoundsRect")]
        public partial Result GetReferenceSpaceBoundsRect([Count(Count = 0)] Session session, [Count(Count = 0)] ReferenceSpaceType referenceSpaceType, [Count(Count = 0)] ref Extent2Df bounds);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetSystem")]
        public unsafe partial Result GetSystem([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] SystemGetInfo* getInfo, [Count(Count = 0)] ulong* systemId);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetSystem")]
        public unsafe partial Result GetSystem([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] SystemGetInfo* getInfo, [Count(Count = 0)] ref ulong systemId);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetSystem")]
        public unsafe partial Result GetSystem([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in SystemGetInfo getInfo, [Count(Count = 0)] ulong* systemId);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetSystem")]
        public partial Result GetSystem([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in SystemGetInfo getInfo, [Count(Count = 0)] ref ulong systemId);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetSystemProperties")]
        public unsafe partial Result GetSystemProperties([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] SystemProperties* properties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetSystemProperties")]
        public partial Result GetSystemProperties([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ref SystemProperties properties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetViewConfigurationProperties")]
        public unsafe partial Result GetViewConfigurationProperties([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] ViewConfigurationProperties* configurationProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetViewConfigurationProperties")]
        public partial Result GetViewConfigurationProperties([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] ref ViewConfigurationProperties configurationProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLocateSpace")]
        public unsafe partial Result LocateSpace([Count(Count = 0)] Space space, [Count(Count = 0)] Space baseSpace, [Count(Count = 0)] long time, [Count(Count = 0)] SpaceLocation* location);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLocateSpace")]
        public partial Result LocateSpace([Count(Count = 0)] Space space, [Count(Count = 0)] Space baseSpace, [Count(Count = 0)] long time, [Count(Count = 0)] ref SpaceLocation location);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLocateViews")]
        public unsafe partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ViewLocateInfo* viewLocateInfo, [Count(Count = 0)] ViewState* viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] uint* viewCountOutput, [Count(Computed = "viewCapacityInput")] View* views);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLocateViews")]
        public unsafe partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ViewLocateInfo* viewLocateInfo, [Count(Count = 0)] ViewState* viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] uint* viewCountOutput, [Count(Computed = "viewCapacityInput")] ref View views);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLocateViews")]
        public unsafe partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ViewLocateInfo* viewLocateInfo, [Count(Count = 0)] ViewState* viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] ref uint viewCountOutput, [Count(Computed = "viewCapacityInput")] View* views);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLocateViews")]
        public unsafe partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ViewLocateInfo* viewLocateInfo, [Count(Count = 0)] ViewState* viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] ref uint viewCountOutput, [Count(Computed = "viewCapacityInput")] ref View views);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLocateViews")]
        public unsafe partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ViewLocateInfo* viewLocateInfo, [Count(Count = 0)] ref ViewState viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] uint* viewCountOutput, [Count(Computed = "viewCapacityInput")] View* views);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLocateViews")]
        public unsafe partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ViewLocateInfo* viewLocateInfo, [Count(Count = 0)] ref ViewState viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] uint* viewCountOutput, [Count(Computed = "viewCapacityInput")] ref View views);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLocateViews")]
        public unsafe partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ViewLocateInfo* viewLocateInfo, [Count(Count = 0)] ref ViewState viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] ref uint viewCountOutput, [Count(Computed = "viewCapacityInput")] View* views);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLocateViews")]
        public unsafe partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ViewLocateInfo* viewLocateInfo, [Count(Count = 0)] ref ViewState viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] ref uint viewCountOutput, [Count(Computed = "viewCapacityInput")] ref View views);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLocateViews")]
        public unsafe partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in ViewLocateInfo viewLocateInfo, [Count(Count = 0)] ViewState* viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] uint* viewCountOutput, [Count(Computed = "viewCapacityInput")] View* views);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLocateViews")]
        public unsafe partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in ViewLocateInfo viewLocateInfo, [Count(Count = 0)] ViewState* viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] uint* viewCountOutput, [Count(Computed = "viewCapacityInput")] ref View views);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLocateViews")]
        public unsafe partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in ViewLocateInfo viewLocateInfo, [Count(Count = 0)] ViewState* viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] ref uint viewCountOutput, [Count(Computed = "viewCapacityInput")] View* views);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLocateViews")]
        public unsafe partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in ViewLocateInfo viewLocateInfo, [Count(Count = 0)] ViewState* viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] ref uint viewCountOutput, [Count(Computed = "viewCapacityInput")] ref View views);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLocateViews")]
        public unsafe partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in ViewLocateInfo viewLocateInfo, [Count(Count = 0)] ref ViewState viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] uint* viewCountOutput, [Count(Computed = "viewCapacityInput")] View* views);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLocateViews")]
        public unsafe partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in ViewLocateInfo viewLocateInfo, [Count(Count = 0)] ref ViewState viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] uint* viewCountOutput, [Count(Computed = "viewCapacityInput")] ref View views);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLocateViews")]
        public unsafe partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in ViewLocateInfo viewLocateInfo, [Count(Count = 0)] ref ViewState viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] ref uint viewCountOutput, [Count(Computed = "viewCapacityInput")] View* views);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLocateViews")]
        public partial Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in ViewLocateInfo viewLocateInfo, [Count(Count = 0)] ref ViewState viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] ref uint viewCountOutput, [Count(Computed = "viewCapacityInput")] ref View views);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrPathToString")]
        public unsafe partial Result PathToString([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong path, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Computed = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrPathToString")]
        public unsafe partial Result PathToString([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong path, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Computed = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrPathToString")]
        public unsafe partial Result PathToString([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong path, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, string buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrPathToString")]
        public unsafe partial Result PathToString([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong path, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Computed = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrPathToString")]
        public partial Result PathToString([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong path, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Computed = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrPathToString")]
        public partial Result PathToString([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong path, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, string buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrPollEvent")]
        public unsafe partial Result PollEvent([Count(Count = 0)] Instance instance, [Count(Count = 0)] EventDataBuffer* eventData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrPollEvent")]
        public partial Result PollEvent([Count(Count = 0)] Instance instance, [Count(Count = 0)] ref EventDataBuffer eventData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrReleaseSwapchainImage")]
        public unsafe partial Result ReleaseSwapchainImage([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0), Flow(FlowDirection.In)] SwapchainImageReleaseInfo* releaseInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrReleaseSwapchainImage")]
        public partial Result ReleaseSwapchainImage([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0), Flow(FlowDirection.In)] in SwapchainImageReleaseInfo releaseInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrRequestExitSession")]
        public partial Result RequestExitSession([Count(Count = 0)] Session session);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrResultToString")]
        public partial Result ResultToString([Count(Count = 0)] Instance instance, [Count(Count = 0)] Result value, [Count(Count = 0)] byte buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrStopHapticFeedback")]
        public unsafe partial Result StopHapticFeedback([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] HapticActionInfo* hapticActionInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrStopHapticFeedback")]
        public partial Result StopHapticFeedback([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in HapticActionInfo hapticActionInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrStringToPath")]
        public unsafe partial Result StringToPath([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] byte* pathString, [Count(Count = 0)] ulong* path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrStringToPath")]
        public unsafe partial Result StringToPath([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] byte* pathString, [Count(Count = 0)] ref ulong path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrStringToPath")]
        public unsafe partial Result StringToPath([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in byte pathString, [Count(Count = 0)] ulong* path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrStringToPath")]
        public partial Result StringToPath([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in byte pathString, [Count(Count = 0)] ref ulong path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrStringToPath")]
        public unsafe partial Result StringToPath([Count(Count = 0)] Instance instance, [Flow(FlowDirection.In)] string pathString, [Count(Count = 0)] ulong* path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrStringToPath")]
        public partial Result StringToPath([Count(Count = 0)] Instance instance, [Flow(FlowDirection.In)] string pathString, [Count(Count = 0)] ref ulong path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrStructureTypeToString")]
        public partial Result StructureTypeToString([Count(Count = 0)] Instance instance, [Count(Count = 0)] StructureType value, [Count(Count = 0)] byte buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrSuggestInteractionProfileBindings")]
        public unsafe partial Result SuggestInteractionProfileBinding([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] InteractionProfileSuggestedBinding* suggestedBindings);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrSuggestInteractionProfileBindings")]
        public partial Result SuggestInteractionProfileBinding([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in InteractionProfileSuggestedBinding suggestedBindings);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrSyncActions")]
        public unsafe partial Result SyncAction([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ActionsSyncInfo* syncInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrSyncActions")]
        public partial Result SyncAction([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in ActionsSyncInfo syncInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrWaitFrame")]
        public unsafe partial Result WaitFrame([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] FrameWaitInfo* frameWaitInfo, [Count(Count = 0)] FrameState* frameState);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrWaitFrame")]
        public unsafe partial Result WaitFrame([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] FrameWaitInfo* frameWaitInfo, [Count(Count = 0)] ref FrameState frameState);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrWaitFrame")]
        public unsafe partial Result WaitFrame([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in FrameWaitInfo frameWaitInfo, [Count(Count = 0)] FrameState* frameState);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrWaitFrame")]
        public partial Result WaitFrame([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in FrameWaitInfo frameWaitInfo, [Count(Count = 0)] ref FrameState frameState);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrWaitSwapchainImage")]
        public unsafe partial Result WaitSwapchainImage([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0), Flow(FlowDirection.In)] SwapchainImageWaitInfo* waitInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrWaitSwapchainImage")]
        public partial Result WaitSwapchainImage([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0), Flow(FlowDirection.In)] in SwapchainImageWaitInfo waitInfo);


        public XR(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

