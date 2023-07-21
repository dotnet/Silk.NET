// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='POINTER_TYPE_INFO.xml' path='doc/member[@name="POINTER_TYPE_INFO"]/*' />
[SupportedOSPlatform("windows10.0.17763.0")]
public partial struct POINTER_TYPE_INFO
{
    /// <include file='POINTER_TYPE_INFO.xml' path='doc/member[@name="POINTER_TYPE_INFO.type"]/*' />
    [NativeTypeName("POINTER_INPUT_TYPE")]
    public uint type;

    /// <include file='POINTER_TYPE_INFO.xml' path='doc/member[@name="POINTER_TYPE_INFO.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_WinUser_L6493_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.touchInfo"]/*' />
    [UnscopedRef]
    public ref POINTER_TOUCH_INFO touchInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.touchInfo;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.penInfo"]/*' />
    [UnscopedRef]
    public ref POINTER_PEN_INFO penInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.penInfo;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.touchInfo"]/*' />
        [FieldOffset(0)]
        public POINTER_TOUCH_INFO touchInfo;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.penInfo"]/*' />
        [FieldOffset(0)]
        public POINTER_PEN_INFO penInfo;
    }
}
