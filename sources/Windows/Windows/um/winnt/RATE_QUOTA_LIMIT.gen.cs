// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='RATE_QUOTA_LIMIT.xml' path='doc/member[@name="RATE_QUOTA_LIMIT"]/*'/>
[StructLayout(LayoutKind.Explicit)]
public partial struct RATE_QUOTA_LIMIT
{
    /// <include file='RATE_QUOTA_LIMIT.xml' path='doc/member[@name="RATE_QUOTA_LIMIT.RateData"]/*'/>
    [FieldOffset(0)]
    [NativeTypeName("DWORD")]
    public uint RateData;
    /// <include file='RATE_QUOTA_LIMIT.xml' path='doc/member[@name="RATE_QUOTA_LIMIT.Anonymous"]/*'/>
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L12475_C5")]
    public _Anonymous_e__Struct Anonymous;
    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.RatePercent"]/*'/>
    public uint RatePercent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.RatePercent;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.RatePercent = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved0"]/*'/>
    public uint Reserved0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Reserved0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Reserved0 = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*'/>
    public partial struct _Anonymous_e__Struct
    {
        public uint _bitfield;
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.RatePercent"]/*'/>
        [NativeTypeName("DWORD : 7")]
        public uint RatePercent
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield & 0x7Fu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0x7Fu) | (value & 0x7Fu);
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved0"]/*'/>
        [NativeTypeName("DWORD : 25")]
        public uint Reserved0
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 7) & 0x1FFFFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1FFFFFFu << 7)) | ((value & 0x1FFFFFFu) << 7);
            }
        }
    }
}