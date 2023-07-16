// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='INTERACTION_CONTEXT_OUTPUT.xml' path='doc/member[@name="INTERACTION_CONTEXT_OUTPUT"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct INTERACTION_CONTEXT_OUTPUT
{
    /// <include file='INTERACTION_CONTEXT_OUTPUT.xml' path='doc/member[@name="INTERACTION_CONTEXT_OUTPUT.interactionId"]/*'/>
    public INTERACTION_ID interactionId;
    /// <include file='INTERACTION_CONTEXT_OUTPUT.xml' path='doc/member[@name="INTERACTION_CONTEXT_OUTPUT.interactionFlags"]/*'/>
    public INTERACTION_FLAGS interactionFlags;
    /// <include file='INTERACTION_CONTEXT_OUTPUT.xml' path='doc/member[@name="INTERACTION_CONTEXT_OUTPUT.inputType"]/*'/>
    [NativeTypeName("POINTER_INPUT_TYPE")]
    public uint inputType;
    /// <include file='INTERACTION_CONTEXT_OUTPUT.xml' path='doc/member[@name="INTERACTION_CONTEXT_OUTPUT.x"]/*'/>
    public float x;
    /// <include file='INTERACTION_CONTEXT_OUTPUT.xml' path='doc/member[@name="INTERACTION_CONTEXT_OUTPUT.y"]/*'/>
    public float y;
    /// <include file='INTERACTION_CONTEXT_OUTPUT.xml' path='doc/member[@name="INTERACTION_CONTEXT_OUTPUT.arguments"]/*'/>
    [NativeTypeName("__AnonymousRecord_InteractionContext_L234_C5")]
    public _arguments_e__Union arguments;
    /// <include file='_arguments_e__Union.xml' path='doc/member[@name="_arguments_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _arguments_e__Union
    {
        /// <include file='_arguments_e__Union.xml' path='doc/member[@name="_arguments_e__Union.manipulation"]/*'/>
        [FieldOffset(0)]
        public INTERACTION_ARGUMENTS_MANIPULATION manipulation;
        /// <include file='_arguments_e__Union.xml' path='doc/member[@name="_arguments_e__Union.tap"]/*'/>
        [FieldOffset(0)]
        public INTERACTION_ARGUMENTS_TAP tap;
        /// <include file='_arguments_e__Union.xml' path='doc/member[@name="_arguments_e__Union.crossSlide"]/*'/>
        [FieldOffset(0)]
        public INTERACTION_ARGUMENTS_CROSS_SLIDE crossSlide;
    }
}