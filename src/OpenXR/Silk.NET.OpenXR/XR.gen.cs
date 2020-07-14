// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    public abstract unsafe partial class XR : NativeAPI
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
        public abstract unsafe Result AcquireSwapchainImage([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0), Flow(FlowDirection.In)] SwapchainImageAcquireInfo* acquireInfo, [Count(Count = 0)] uint* index);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrAcquireSwapchainImage")]
        public abstract Result AcquireSwapchainImage([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0), Flow(FlowDirection.In)] ref SwapchainImageAcquireInfo acquireInfo, [Count(Count = 0)] ref uint index);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrApplyHapticFeedback")]
        public abstract unsafe Result ApplyHapticFeedback([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] HapticActionInfo* hapticActionInfo, [Count(Count = 0), Flow(FlowDirection.In)] HapticBaseHeader* hapticFeedback);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrApplyHapticFeedback")]
        public abstract Result ApplyHapticFeedback([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ref HapticActionInfo hapticActionInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref HapticBaseHeader hapticFeedback);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrAttachSessionActionSets")]
        public abstract unsafe Result AttachSessionActionSets([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] SessionActionSetsAttachInfo* attachInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrAttachSessionActionSets")]
        public abstract Result AttachSessionActionSets([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ref SessionActionSetsAttachInfo attachInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrBeginFrame")]
        public abstract unsafe Result BeginFrame([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] FrameBeginInfo* frameBeginInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrBeginFrame")]
        public abstract Result BeginFrame([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ref FrameBeginInfo frameBeginInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrBeginSession")]
        public abstract unsafe Result BeginSession([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] SessionBeginInfo* beginInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrBeginSession")]
        public abstract Result BeginSession([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ref SessionBeginInfo beginInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateAction")]
        public abstract unsafe Result CreateAction([Count(Count = 0)] ActionSet actionSet, [Count(Count = 0), Flow(FlowDirection.In)] ActionCreateInfo* createInfo, [Count(Count = 0)] Action* action);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateAction")]
        public abstract Result CreateAction([Count(Count = 0)] ActionSet actionSet, [Count(Count = 0), Flow(FlowDirection.In)] ref ActionCreateInfo createInfo, [Count(Count = 0)] ref Action action);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateActionSet")]
        public abstract unsafe Result CreateActionSet([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ActionSetCreateInfo* createInfo, [Count(Count = 0)] ActionSet* actionSet);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateActionSet")]
        public abstract Result CreateActionSet([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref ActionSetCreateInfo createInfo, [Count(Count = 0)] ref ActionSet actionSet);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateActionSpace")]
        public abstract unsafe Result CreateActionSpace([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ActionSpaceCreateInfo* createInfo, [Count(Count = 0)] Space* space);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateActionSpace")]
        public abstract Result CreateActionSpace([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ref ActionSpaceCreateInfo createInfo, [Count(Count = 0)] ref Space space);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateInstance")]
        public abstract unsafe Result CreateInstance([Count(Count = 0), Flow(FlowDirection.In)] InstanceCreateInfo* createInfo, [Count(Count = 0)] Instance* instance);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateInstance")]
        public abstract Result CreateInstance([Count(Count = 0), Flow(FlowDirection.In)] ref InstanceCreateInfo createInfo, [Count(Count = 0)] ref Instance instance);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateReferenceSpace")]
        public abstract unsafe Result CreateReferenceSpace([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ReferenceSpaceCreateInfo* createInfo, [Count(Count = 0)] Space* space);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateReferenceSpace")]
        public abstract Result CreateReferenceSpace([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ref ReferenceSpaceCreateInfo createInfo, [Count(Count = 0)] ref Space space);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSession")]
        public abstract unsafe Result CreateSession([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] SessionCreateInfo* createInfo, [Count(Count = 0)] Session* session);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSession")]
        public abstract Result CreateSession([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref SessionCreateInfo createInfo, [Count(Count = 0)] ref Session session);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSwapchain")]
        public abstract unsafe Result CreateSwapchain([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] SwapchainCreateInfo* createInfo, [Count(Count = 0)] Swapchain* swapchain);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateSwapchain")]
        public abstract Result CreateSwapchain([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ref SwapchainCreateInfo createInfo, [Count(Count = 0)] ref Swapchain swapchain);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrDestroyAction")]
        public abstract Result DestroyAction([Count(Count = 0)] Action action);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrDestroyActionSet")]
        public abstract Result DestroyActionSet([Count(Count = 0)] ActionSet actionSet);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrDestroyInstance")]
        public abstract Result DestroyInstance([Count(Count = 0)] Instance instance);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrDestroySession")]
        public abstract Result DestroySession([Count(Count = 0)] Session session);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrDestroySpace")]
        public abstract Result DestroySpace([Count(Count = 0)] Space space);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrDestroySwapchain")]
        public abstract Result DestroySwapchain([Count(Count = 0)] Swapchain swapchain);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEndFrame")]
        public abstract unsafe Result EndFrame([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] FrameEndInfo* frameEndInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEndFrame")]
        public abstract Result EndFrame([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ref FrameEndInfo frameEndInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEndSession")]
        public abstract Result EndSession([Count(Count = 0)] Session session);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateApiLayerProperties")]
        public abstract unsafe Result EnumerateApiLayerProperties([Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] uint* propertyCountOutput, [Count(Computed = "propertyCapacityInput")] ApiLayerProperties* properties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateApiLayerProperties")]
        public abstract Result EnumerateApiLayerProperties([Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] ref uint propertyCountOutput, [Count(Computed = "propertyCapacityInput")] ref ApiLayerProperties properties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateBoundSourcesForAction")]
        public abstract unsafe Result EnumerateBoundSourcesForAction([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] BoundSourcesForActionEnumerateInfo* enumerateInfo, [Count(Count = 0)] uint sourceCapacityInput, [Count(Count = 0)] uint* sourceCountOutput, [Count(Computed = "sourceCapacityInput")] ulong* sources);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateBoundSourcesForAction")]
        public abstract Result EnumerateBoundSourcesForAction([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ref BoundSourcesForActionEnumerateInfo enumerateInfo, [Count(Count = 0)] uint sourceCapacityInput, [Count(Count = 0)] ref uint sourceCountOutput, [Count(Computed = "sourceCapacityInput")] ref ulong sources);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateEnvironmentBlendModes")]
        public abstract unsafe Result EnumerateEnvironmentBlendModes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint environmentBlendModeCapacityInput, [Count(Count = 0)] uint* environmentBlendModeCountOutput, [Count(Computed = "environmentBlendModeCapacityInput")] EnvironmentBlendMode* environmentBlendModes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateEnvironmentBlendModes")]
        public abstract Result EnumerateEnvironmentBlendModes([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint environmentBlendModeCapacityInput, [Count(Count = 0)] ref uint environmentBlendModeCountOutput, [Count(Computed = "environmentBlendModeCapacityInput")] ref EnvironmentBlendMode environmentBlendModes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInstanceExtensionProperties")]
        public abstract unsafe Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(FlowDirection.In)] byte* layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] uint* propertyCountOutput, [Count(Computed = "propertyCapacityInput")] ExtensionProperties* properties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInstanceExtensionProperties")]
        public abstract Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(FlowDirection.In)] ref byte layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] ref uint propertyCountOutput, [Count(Computed = "propertyCapacityInput")] ref ExtensionProperties properties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateReferenceSpaces")]
        public abstract unsafe Result EnumerateReferenceSpaces([Count(Count = 0)] Session session, [Count(Count = 0)] uint spaceCapacityInput, [Count(Count = 0)] uint* spaceCountOutput, [Count(Computed = "spaceCapacityInput")] ReferenceSpaceType* spaces);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateReferenceSpaces")]
        public abstract Result EnumerateReferenceSpaces([Count(Count = 0)] Session session, [Count(Count = 0)] uint spaceCapacityInput, [Count(Count = 0)] ref uint spaceCountOutput, [Count(Computed = "spaceCapacityInput")] ref ReferenceSpaceType spaces);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSwapchainFormats")]
        public abstract unsafe Result EnumerateSwapchainFormats([Count(Count = 0)] Session session, [Count(Count = 0)] uint formatCapacityInput, [Count(Count = 0)] uint* formatCountOutput, [Count(Computed = "formatCapacityInput")] long* formats);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSwapchainFormats")]
        public abstract Result EnumerateSwapchainFormats([Count(Count = 0)] Session session, [Count(Count = 0)] uint formatCapacityInput, [Count(Count = 0)] ref uint formatCountOutput, [Count(Computed = "formatCapacityInput")] ref long formats);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSwapchainImages")]
        public abstract unsafe Result EnumerateSwapchainImages([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0)] uint imageCapacityInput, [Count(Count = 0)] uint* imageCountOutput, [Count(Computed = "imageCapacityInput")] SwapchainImageBaseHeader* images);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSwapchainImages")]
        public abstract Result EnumerateSwapchainImages([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0)] uint imageCapacityInput, [Count(Count = 0)] ref uint imageCountOutput, [Count(Computed = "imageCapacityInput")] ref SwapchainImageBaseHeader images);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateViewConfigurations")]
        public abstract unsafe Result EnumerateViewConfiguration([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint viewConfigurationTypeCapacityInput, [Count(Count = 0)] uint* viewConfigurationTypeCountOutput, [Count(Computed = "viewConfigurationTypeCapacityInput")] ViewConfigurationType* viewConfigurationTypes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateViewConfigurations")]
        public abstract Result EnumerateViewConfiguration([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint viewConfigurationTypeCapacityInput, [Count(Count = 0)] ref uint viewConfigurationTypeCountOutput, [Count(Computed = "viewConfigurationTypeCapacityInput")] ref ViewConfigurationType viewConfigurationTypes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateViewConfigurationViews")]
        public abstract unsafe Result EnumerateViewConfigurationView([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] uint* viewCountOutput, [Count(Computed = "viewCapacityInput")] ViewConfigurationView* views);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateViewConfigurationViews")]
        public abstract Result EnumerateViewConfigurationView([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] ref uint viewCountOutput, [Count(Computed = "viewCapacityInput")] ref ViewConfigurationView views);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetActionStateBoolean")]
        public abstract unsafe Result GetActionStateBoolean([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ActionStateGetInfo* getInfo, [Count(Count = 0)] ActionStateBoolean* state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetActionStateBoolean")]
        public abstract Result GetActionStateBoolean([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ref ActionStateGetInfo getInfo, [Count(Count = 0)] ref ActionStateBoolean state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetActionStateFloat")]
        public abstract unsafe Result GetActionStateFloat([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ActionStateGetInfo* getInfo, [Count(Count = 0)] ActionStateFloat* state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetActionStateFloat")]
        public abstract Result GetActionStateFloat([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ref ActionStateGetInfo getInfo, [Count(Count = 0)] ref ActionStateFloat state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetActionStatePose")]
        public abstract unsafe Result GetActionStatePose([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ActionStateGetInfo* getInfo, [Count(Count = 0)] ActionStatePose* state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetActionStatePose")]
        public abstract Result GetActionStatePose([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ref ActionStateGetInfo getInfo, [Count(Count = 0)] ref ActionStatePose state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetActionStateVector2f")]
        public abstract unsafe Result GetActionStateVector2([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ActionStateGetInfo* getInfo, [Count(Count = 0)] ActionStateVector2f* state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetActionStateVector2f")]
        public abstract Result GetActionStateVector2([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ref ActionStateGetInfo getInfo, [Count(Count = 0)] ref ActionStateVector2f state);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetCurrentInteractionProfile")]
        public abstract unsafe Result GetCurrentInteractionProfile([Count(Count = 0)] Session session, [Count(Count = 0)] ulong topLevelUserPath, [Count(Count = 0)] InteractionProfileState* interactionProfile);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetCurrentInteractionProfile")]
        public abstract Result GetCurrentInteractionProfile([Count(Count = 0)] Session session, [Count(Count = 0)] ulong topLevelUserPath, [Count(Count = 0)] ref InteractionProfileState interactionProfile);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetInputSourceLocalizedName")]
        public abstract unsafe Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] InputSourceLocalizedNameGetInfo* getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Computed = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetInputSourceLocalizedName")]
        public abstract Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ref InputSourceLocalizedNameGetInfo getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Computed = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetInstanceProcAddr")]
        public abstract unsafe Result GetInstanceProcAddr([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] byte* name, [Count(Count = 0)] FuncPtr* function);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetInstanceProcAddr")]
        public abstract Result GetInstanceProcAddr([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref byte name, [Count(Count = 0)] ref FuncPtr function);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetInstanceProperties")]
        public abstract unsafe Result GetInstanceProperties([Count(Count = 0)] Instance instance, [Count(Count = 0)] InstanceProperties* instanceProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetInstanceProperties")]
        public abstract Result GetInstanceProperties([Count(Count = 0)] Instance instance, [Count(Count = 0)] ref InstanceProperties instanceProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetReferenceSpaceBoundsRect")]
        public abstract unsafe Result GetReferenceSpaceBoundsRect([Count(Count = 0)] Session session, [Count(Count = 0)] ReferenceSpaceType referenceSpaceType, [Count(Count = 0)] Extent2Df* bounds);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetReferenceSpaceBoundsRect")]
        public abstract Result GetReferenceSpaceBoundsRect([Count(Count = 0)] Session session, [Count(Count = 0)] ReferenceSpaceType referenceSpaceType, [Count(Count = 0)] ref Extent2Df bounds);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetSystem")]
        public abstract unsafe Result GetSystem([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] SystemGetInfo* getInfo, [Count(Count = 0)] ulong* systemId);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetSystem")]
        public abstract Result GetSystem([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref SystemGetInfo getInfo, [Count(Count = 0)] ref ulong systemId);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetSystemProperties")]
        public abstract unsafe Result GetSystemProperties([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] SystemProperties* properties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetSystemProperties")]
        public abstract Result GetSystemProperties([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ref SystemProperties properties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetViewConfigurationProperties")]
        public abstract unsafe Result GetViewConfigurationProperties([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] ViewConfigurationProperties* configurationProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetViewConfigurationProperties")]
        public abstract Result GetViewConfigurationProperties([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] ref ViewConfigurationProperties configurationProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLocateSpace")]
        public abstract unsafe Result LocateSpace([Count(Count = 0)] Space space, [Count(Count = 0)] Space baseSpace, [Count(Count = 0)] long time, [Count(Count = 0)] SpaceLocation* location);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLocateSpace")]
        public abstract Result LocateSpace([Count(Count = 0)] Space space, [Count(Count = 0)] Space baseSpace, [Count(Count = 0)] long time, [Count(Count = 0)] ref SpaceLocation location);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLocateViews")]
        public abstract unsafe Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ViewLocateInfo* viewLocateInfo, [Count(Count = 0)] ViewState* viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] uint* viewCountOutput, [Count(Computed = "viewCapacityInput")] View* views);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrLocateViews")]
        public abstract Result LocateView([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ref ViewLocateInfo viewLocateInfo, [Count(Count = 0)] ref ViewState viewState, [Count(Count = 0)] uint viewCapacityInput, [Count(Count = 0)] ref uint viewCountOutput, [Count(Computed = "viewCapacityInput")] ref View views);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrPathToString")]
        public abstract unsafe Result PathToString([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong path, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Computed = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrPathToString")]
        public abstract Result PathToString([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong path, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Computed = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrPollEvent")]
        public abstract unsafe Result PollEvent([Count(Count = 0)] Instance instance, [Count(Count = 0)] EventDataBuffer* eventData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrPollEvent")]
        public abstract Result PollEvent([Count(Count = 0)] Instance instance, [Count(Count = 0)] ref EventDataBuffer eventData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrReleaseSwapchainImage")]
        public abstract unsafe Result ReleaseSwapchainImage([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0), Flow(FlowDirection.In)] SwapchainImageReleaseInfo* releaseInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrReleaseSwapchainImage")]
        public abstract Result ReleaseSwapchainImage([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0), Flow(FlowDirection.In)] ref SwapchainImageReleaseInfo releaseInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrRequestExitSession")]
        public abstract Result RequestExitSession([Count(Count = 0)] Session session);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrResultToString")]
        public abstract Result ResultToString([Count(Count = 0)] Instance instance, [Count(Count = 0)] Result value, [Count(Count = 0)] byte buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrStopHapticFeedback")]
        public abstract unsafe Result StopHapticFeedback([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] HapticActionInfo* hapticActionInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrStopHapticFeedback")]
        public abstract Result StopHapticFeedback([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ref HapticActionInfo hapticActionInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrStringToPath")]
        public abstract unsafe Result StringToPath([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] byte* pathString, [Count(Count = 0)] ulong* path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrStringToPath")]
        public abstract Result StringToPath([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref byte pathString, [Count(Count = 0)] ref ulong path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrStructureTypeToString")]
        public abstract Result StructureTypeToString([Count(Count = 0)] Instance instance, [Count(Count = 0)] StructureType value, [Count(Count = 0)] byte buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrSuggestInteractionProfileBindings")]
        public abstract unsafe Result SuggestInteractionProfileBinding([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] InteractionProfileSuggestedBinding* suggestedBindings);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrSuggestInteractionProfileBindings")]
        public abstract Result SuggestInteractionProfileBinding([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref InteractionProfileSuggestedBinding suggestedBindings);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrSyncActions")]
        public abstract unsafe Result SyncAction([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ActionsSyncInfo* syncInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrSyncActions")]
        public abstract Result SyncAction([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ref ActionsSyncInfo syncInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrWaitFrame")]
        public abstract unsafe Result WaitFrame([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] FrameWaitInfo* frameWaitInfo, [Count(Count = 0)] FrameState* frameState);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrWaitFrame")]
        public abstract Result WaitFrame([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ref FrameWaitInfo frameWaitInfo, [Count(Count = 0)] ref FrameState frameState);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrWaitSwapchainImage")]
        public abstract unsafe Result WaitSwapchainImage([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0), Flow(FlowDirection.In)] SwapchainImageWaitInfo* waitInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrWaitSwapchainImage")]
        public abstract Result WaitSwapchainImage([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0), Flow(FlowDirection.In)] ref SwapchainImageWaitInfo waitInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInstanceExtensionProperties")]
        public abstract unsafe Result EnumerateInstanceExtensionProperties([Flow(FlowDirection.In)] string layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] uint* propertyCountOutput, [Count(Computed = "propertyCapacityInput")] ExtensionProperties* properties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrEnumerateInstanceExtensionProperties")]
        public abstract Result EnumerateInstanceExtensionProperties([Flow(FlowDirection.In)] string layerName, [Count(Count = 0)] uint propertyCapacityInput, [Count(Count = 0)] ref uint propertyCountOutput, [Count(Computed = "propertyCapacityInput")] ref ExtensionProperties properties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetInputSourceLocalizedName")]
        public abstract unsafe Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] InputSourceLocalizedNameGetInfo* getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, string buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetInputSourceLocalizedName")]
        public abstract Result GetInputSourceLocalizedName([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ref InputSourceLocalizedNameGetInfo getInfo, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, string buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetInstanceProcAddr")]
        public abstract unsafe Result GetInstanceProcAddr([Count(Count = 0)] Instance instance, [Flow(FlowDirection.In)] string name, [Count(Count = 0)] FuncPtr* function);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetInstanceProcAddr")]
        public abstract Result GetInstanceProcAddr([Count(Count = 0)] Instance instance, [Flow(FlowDirection.In)] string name, [Count(Count = 0)] ref FuncPtr function);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrPathToString")]
        public abstract unsafe Result PathToString([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong path, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, string buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrPathToString")]
        public abstract Result PathToString([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong path, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, string buffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrStringToPath")]
        public abstract unsafe Result StringToPath([Count(Count = 0)] Instance instance, [Flow(FlowDirection.In)] string pathString, [Count(Count = 0)] ulong* path);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrStringToPath")]
        public abstract Result StringToPath([Count(Count = 0)] Instance instance, [Flow(FlowDirection.In)] string pathString, [Count(Count = 0)] ref ulong path);

        private SearchPathContainer _searchPaths;
        public override SearchPathContainer SearchPaths => _searchPaths ??= new OpenXRLibraryNameContainer();

        public XR(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

