// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct INTERACTION_CONTEXT_OUTPUT2
{
    public INTERACTION_ID interactionId;
    public INTERACTION_FLAGS interactionFlags;

    [NativeTypeName("POINTER_INPUT_TYPE")]
    public uint inputType;

    [NativeTypeName("UINT32")]
    public uint contactCount;

    [NativeTypeName("UINT32")]
    public uint currentContactCount;
    public float x;
    public float y;

    [NativeTypeName("__AnonymousRecord_InteractionContext_L252_C5")]
    public _arguments_e__Union arguments;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _arguments_e__Union
    {
        [FieldOffset(0)]
        public INTERACTION_ARGUMENTS_MANIPULATION manipulation;

        [FieldOffset(0)]
        public INTERACTION_ARGUMENTS_TAP tap;

        [FieldOffset(0)]
        public INTERACTION_ARGUMENTS_CROSS_SLIDE crossSlide;
    }
}
