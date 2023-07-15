// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateInteractionContext"]/*'/>
    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT CreateInteractionContext(HINTERACTIONCONTEXT* interactionContext);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DestroyInteractionContext"]/*'/>
    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT DestroyInteractionContext(HINTERACTIONCONTEXT interactionContext);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterOutputCallbackInteractionContext"]/*'/>
    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT RegisterOutputCallbackInteractionContext(HINTERACTIONCONTEXT interactionContext, [NativeTypeName("INTERACTION_CONTEXT_OUTPUT_CALLBACK")] delegate* unmanaged<void*, INTERACTION_CONTEXT_OUTPUT*, void> outputCallback, void* clientData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterOutputCallbackInteractionContext2"]/*'/>
    [DllImport("ninput", ExactSpelling = true)]
    public static extern HRESULT RegisterOutputCallbackInteractionContext2(HINTERACTIONCONTEXT interactionContext, [NativeTypeName("INTERACTION_CONTEXT_OUTPUT_CALLBACK2")] delegate* unmanaged<void*, INTERACTION_CONTEXT_OUTPUT2*, void> outputCallback, void* clientData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetInteractionConfigurationInteractionContext"]/*'/>
    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT SetInteractionConfigurationInteractionContext(HINTERACTIONCONTEXT interactionContext, [NativeTypeName("UINT32")] uint configurationCount, [NativeTypeName("const INTERACTION_CONTEXT_CONFIGURATION *")] INTERACTION_CONTEXT_CONFIGURATION* configuration);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetInteractionConfigurationInteractionContext"]/*'/>
    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT GetInteractionConfigurationInteractionContext(HINTERACTIONCONTEXT interactionContext, [NativeTypeName("UINT32")] uint configurationCount, INTERACTION_CONTEXT_CONFIGURATION* configuration);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetPropertyInteractionContext"]/*'/>
    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT SetPropertyInteractionContext(HINTERACTIONCONTEXT interactionContext, INTERACTION_CONTEXT_PROPERTY contextProperty, [NativeTypeName("UINT32")] uint value);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPropertyInteractionContext"]/*'/>
    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT GetPropertyInteractionContext(HINTERACTIONCONTEXT interactionContext, INTERACTION_CONTEXT_PROPERTY contextProperty, [NativeTypeName("UINT32 *")] uint* value);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetInertiaParameterInteractionContext"]/*'/>
    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT SetInertiaParameterInteractionContext(HINTERACTIONCONTEXT interactionContext, INERTIA_PARAMETER inertiaParameter, float value);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetInertiaParameterInteractionContext"]/*'/>
    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT GetInertiaParameterInteractionContext(HINTERACTIONCONTEXT interactionContext, INERTIA_PARAMETER inertiaParameter, float* value);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetCrossSlideParametersInteractionContext"]/*'/>
    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT SetCrossSlideParametersInteractionContext(HINTERACTIONCONTEXT interactionContext, [NativeTypeName("UINT32")] uint parameterCount, CROSS_SLIDE_PARAMETER* crossSlideParameters);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCrossSlideParameterInteractionContext"]/*'/>
    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT GetCrossSlideParameterInteractionContext(HINTERACTIONCONTEXT interactionContext, CROSS_SLIDE_THRESHOLD threshold, float* distance);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetTapParameterInteractionContext"]/*'/>
    [DllImport("ninput", ExactSpelling = true)]
    public static extern HRESULT SetTapParameterInteractionContext(HINTERACTIONCONTEXT interactionContext, TAP_PARAMETER parameter, float value);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTapParameterInteractionContext"]/*'/>
    [DllImport("ninput", ExactSpelling = true)]
    public static extern HRESULT GetTapParameterInteractionContext(HINTERACTIONCONTEXT interactionContext, TAP_PARAMETER parameter, float* value);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetHoldParameterInteractionContext"]/*'/>
    [DllImport("ninput", ExactSpelling = true)]
    public static extern HRESULT SetHoldParameterInteractionContext(HINTERACTIONCONTEXT interactionContext, HOLD_PARAMETER parameter, float value);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetHoldParameterInteractionContext"]/*'/>
    [DllImport("ninput", ExactSpelling = true)]
    public static extern HRESULT GetHoldParameterInteractionContext(HINTERACTIONCONTEXT interactionContext, HOLD_PARAMETER parameter, float* value);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetTranslationParameterInteractionContext"]/*'/>
    [DllImport("ninput", ExactSpelling = true)]
    public static extern HRESULT SetTranslationParameterInteractionContext(HINTERACTIONCONTEXT interactionContext, TRANSLATION_PARAMETER parameter, float value);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTranslationParameterInteractionContext"]/*'/>
    [DllImport("ninput", ExactSpelling = true)]
    public static extern HRESULT GetTranslationParameterInteractionContext(HINTERACTIONCONTEXT interactionContext, TRANSLATION_PARAMETER parameter, float* value);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetMouseWheelParameterInteractionContext"]/*'/>
    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT SetMouseWheelParameterInteractionContext(HINTERACTIONCONTEXT interactionContext, MOUSE_WHEEL_PARAMETER parameter, float value);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMouseWheelParameterInteractionContext"]/*'/>
    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT GetMouseWheelParameterInteractionContext(HINTERACTIONCONTEXT interactionContext, MOUSE_WHEEL_PARAMETER parameter, float* value);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ResetInteractionContext"]/*'/>
    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT ResetInteractionContext(HINTERACTIONCONTEXT interactionContext);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetStateInteractionContext"]/*'/>
    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT GetStateInteractionContext(HINTERACTIONCONTEXT interactionContext, [NativeTypeName("const POINTER_INFO *")] POINTER_INFO* pointerInfo, INTERACTION_STATE* state);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddPointerInteractionContext"]/*'/>
    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT AddPointerInteractionContext(HINTERACTIONCONTEXT interactionContext, [NativeTypeName("UINT32")] uint pointerId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RemovePointerInteractionContext"]/*'/>
    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT RemovePointerInteractionContext(HINTERACTIONCONTEXT interactionContext, [NativeTypeName("UINT32")] uint pointerId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ProcessPointerFramesInteractionContext"]/*'/>
    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT ProcessPointerFramesInteractionContext(HINTERACTIONCONTEXT interactionContext, [NativeTypeName("UINT32")] uint entriesCount, [NativeTypeName("UINT32")] uint pointerCount, [NativeTypeName("const POINTER_INFO *")] POINTER_INFO* pointerInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.BufferPointerPacketsInteractionContext"]/*'/>
    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT BufferPointerPacketsInteractionContext(HINTERACTIONCONTEXT interactionContext, [NativeTypeName("UINT32")] uint entriesCount, [NativeTypeName("const POINTER_INFO *")] POINTER_INFO* pointerInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ProcessBufferedPacketsInteractionContext"]/*'/>
    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT ProcessBufferedPacketsInteractionContext(HINTERACTIONCONTEXT interactionContext);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ProcessInertiaInteractionContext"]/*'/>
    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT ProcessInertiaInteractionContext(HINTERACTIONCONTEXT interactionContext);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StopInteractionContext"]/*'/>
    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT StopInteractionContext(HINTERACTIONCONTEXT interactionContext);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetPivotInteractionContext"]/*'/>
    [DllImport("ninput", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT SetPivotInteractionContext(HINTERACTIONCONTEXT interactionContext, float x, float y, float radius);
    [NativeTypeName("#define CROSS_SLIDE_THRESHOLD_INVALID_VALUE FLT_MAX")]
    public const float CROSS_SLIDE_THRESHOLD_INVALID_VALUE = 3.402823466e+38F;
    [NativeTypeName("#define INERTIA_PARAMETER_INVALID_VALUE FLT_MAX")]
    public const float INERTIA_PARAMETER_INVALID_VALUE = 3.402823466e+38F;
}