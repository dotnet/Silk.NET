// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT CreateInteractionContext(HINTERACTIONCONTEXT* interactionContext);

    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT DestroyInteractionContext(HINTERACTIONCONTEXT interactionContext);

    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT RegisterOutputCallbackInteractionContext(
        HINTERACTIONCONTEXT interactionContext,
        [NativeTypeName("INTERACTION_CONTEXT_OUTPUT_CALLBACK")]
            delegate* unmanaged<void*, INTERACTION_CONTEXT_OUTPUT*, void> outputCallback,
        void* clientData
    );

    [DllImport("ninput", ExactSpelling = true)]
    public static extern HRESULT RegisterOutputCallbackInteractionContext2(
        HINTERACTIONCONTEXT interactionContext,
        [NativeTypeName("INTERACTION_CONTEXT_OUTPUT_CALLBACK2")]
            delegate* unmanaged<void*, INTERACTION_CONTEXT_OUTPUT2*, void> outputCallback,
        void* clientData
    );

    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT SetInteractionConfigurationInteractionContext(
        HINTERACTIONCONTEXT interactionContext,
        [NativeTypeName("UINT32")] uint configurationCount,
        [NativeTypeName("const INTERACTION_CONTEXT_CONFIGURATION *")]
            INTERACTION_CONTEXT_CONFIGURATION* configuration
    );

    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT GetInteractionConfigurationInteractionContext(
        HINTERACTIONCONTEXT interactionContext,
        [NativeTypeName("UINT32")] uint configurationCount,
        INTERACTION_CONTEXT_CONFIGURATION* configuration
    );

    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT SetPropertyInteractionContext(
        HINTERACTIONCONTEXT interactionContext,
        INTERACTION_CONTEXT_PROPERTY contextProperty,
        [NativeTypeName("UINT32")] uint value
    );

    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT GetPropertyInteractionContext(
        HINTERACTIONCONTEXT interactionContext,
        INTERACTION_CONTEXT_PROPERTY contextProperty,
        [NativeTypeName("UINT32 *")] uint* value
    );

    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT SetInertiaParameterInteractionContext(
        HINTERACTIONCONTEXT interactionContext,
        INERTIA_PARAMETER inertiaParameter,
        float value
    );

    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT GetInertiaParameterInteractionContext(
        HINTERACTIONCONTEXT interactionContext,
        INERTIA_PARAMETER inertiaParameter,
        float* value
    );

    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT SetCrossSlideParametersInteractionContext(
        HINTERACTIONCONTEXT interactionContext,
        [NativeTypeName("UINT32")] uint parameterCount,
        CROSS_SLIDE_PARAMETER* crossSlideParameters
    );

    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT GetCrossSlideParameterInteractionContext(
        HINTERACTIONCONTEXT interactionContext,
        CROSS_SLIDE_THRESHOLD threshold,
        float* distance
    );

    [DllImport("ninput", ExactSpelling = true)]
    public static extern HRESULT SetTapParameterInteractionContext(
        HINTERACTIONCONTEXT interactionContext,
        TAP_PARAMETER parameter,
        float value
    );

    [DllImport("ninput", ExactSpelling = true)]
    public static extern HRESULT GetTapParameterInteractionContext(
        HINTERACTIONCONTEXT interactionContext,
        TAP_PARAMETER parameter,
        float* value
    );

    [DllImport("ninput", ExactSpelling = true)]
    public static extern HRESULT SetHoldParameterInteractionContext(
        HINTERACTIONCONTEXT interactionContext,
        HOLD_PARAMETER parameter,
        float value
    );

    [DllImport("ninput", ExactSpelling = true)]
    public static extern HRESULT GetHoldParameterInteractionContext(
        HINTERACTIONCONTEXT interactionContext,
        HOLD_PARAMETER parameter,
        float* value
    );

    [DllImport("ninput", ExactSpelling = true)]
    public static extern HRESULT SetTranslationParameterInteractionContext(
        HINTERACTIONCONTEXT interactionContext,
        TRANSLATION_PARAMETER parameter,
        float value
    );

    [DllImport("ninput", ExactSpelling = true)]
    public static extern HRESULT GetTranslationParameterInteractionContext(
        HINTERACTIONCONTEXT interactionContext,
        TRANSLATION_PARAMETER parameter,
        float* value
    );

    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT SetMouseWheelParameterInteractionContext(
        HINTERACTIONCONTEXT interactionContext,
        MOUSE_WHEEL_PARAMETER parameter,
        float value
    );

    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT GetMouseWheelParameterInteractionContext(
        HINTERACTIONCONTEXT interactionContext,
        MOUSE_WHEEL_PARAMETER parameter,
        float* value
    );

    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT ResetInteractionContext(HINTERACTIONCONTEXT interactionContext);

    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT GetStateInteractionContext(
        HINTERACTIONCONTEXT interactionContext,
        [NativeTypeName("const POINTER_INFO *")] POINTER_INFO* pointerInfo,
        INTERACTION_STATE* state
    );

    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT AddPointerInteractionContext(
        HINTERACTIONCONTEXT interactionContext,
        [NativeTypeName("UINT32")] uint pointerId
    );

    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT RemovePointerInteractionContext(
        HINTERACTIONCONTEXT interactionContext,
        [NativeTypeName("UINT32")] uint pointerId
    );

    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT ProcessPointerFramesInteractionContext(
        HINTERACTIONCONTEXT interactionContext,
        [NativeTypeName("UINT32")] uint entriesCount,
        [NativeTypeName("UINT32")] uint pointerCount,
        [NativeTypeName("const POINTER_INFO *")] POINTER_INFO* pointerInfo
    );

    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT BufferPointerPacketsInteractionContext(
        HINTERACTIONCONTEXT interactionContext,
        [NativeTypeName("UINT32")] uint entriesCount,
        [NativeTypeName("const POINTER_INFO *")] POINTER_INFO* pointerInfo
    );

    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT ProcessBufferedPacketsInteractionContext(
        HINTERACTIONCONTEXT interactionContext
    );

    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT ProcessInertiaInteractionContext(
        HINTERACTIONCONTEXT interactionContext
    );

    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT StopInteractionContext(HINTERACTIONCONTEXT interactionContext);

    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT SetPivotInteractionContext(
        HINTERACTIONCONTEXT interactionContext,
        float x,
        float y,
        float radius
    );

    [NativeTypeName("#define CROSS_SLIDE_THRESHOLD_INVALID_VALUE FLT_MAX")]
    public const float CROSS_SLIDE_THRESHOLD_INVALID_VALUE = 3.402823466e+38F;

    [NativeTypeName("#define INERTIA_PARAMETER_INVALID_VALUE FLT_MAX")]
    public const float INERTIA_PARAMETER_INVALID_VALUE = 3.402823466e+38F;
}
