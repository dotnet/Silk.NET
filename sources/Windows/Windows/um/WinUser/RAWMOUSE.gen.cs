// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='RAWMOUSE.xml' path='doc/member[@name="RAWMOUSE"]/*' />
public partial struct RAWMOUSE
{
    /// <include file='RAWMOUSE.xml' path='doc/member[@name="RAWMOUSE.usFlags"]/*' />
    public ushort usFlags;

    /// <include file='RAWMOUSE.xml' path='doc/member[@name="RAWMOUSE.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_WinUser_L14952_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='RAWMOUSE.xml' path='doc/member[@name="RAWMOUSE.ulRawButtons"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulRawButtons;

    /// <include file='RAWMOUSE.xml' path='doc/member[@name="RAWMOUSE.lLastX"]/*' />
    [NativeTypeName("LONG")]
    public int lLastX;

    /// <include file='RAWMOUSE.xml' path='doc/member[@name="RAWMOUSE.lLastY"]/*' />
    [NativeTypeName("LONG")]
    public int lLastY;

    /// <include file='RAWMOUSE.xml' path='doc/member[@name="RAWMOUSE.ulExtraInformation"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulExtraInformation;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ulButtons"]/*' />
    [UnscopedRef]
    public ref uint ulButtons
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.ulButtons;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.usButtonFlags"]/*' />
    [UnscopedRef]
    public ref ushort usButtonFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.usButtonFlags;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.usButtonData"]/*' />
    [UnscopedRef]
    public ref ushort usButtonData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.usButtonData;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ulButtons"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("ULONG")]
        public uint ulButtons;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_WinUser_L14954_C9")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.usButtonFlags"]/*' />
            public ushort usButtonFlags;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.usButtonData"]/*' />
            public ushort usButtonData;
        }
    }
}
