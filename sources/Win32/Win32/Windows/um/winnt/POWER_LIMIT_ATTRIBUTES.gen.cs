// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct POWER_LIMIT_ATTRIBUTES
{
    public POWER_LIMIT_TYPES Type;

    [NativeTypeName("DWORD")]
    public uint DomainId;

    [NativeTypeName("DWORD")]
    public uint MaxValue;

    [NativeTypeName("DWORD")]
    public uint MinValue;

    [NativeTypeName("DWORD")]
    public uint MinTimeParameter;

    [NativeTypeName("DWORD")]
    public uint MaxTimeParameter;

    [NativeTypeName("DWORD")]
    public uint DefaultACValue;

    [NativeTypeName("DWORD")]
    public uint DefaultDCValue;

    [NativeTypeName("__AnonymousRecord_winnt_L18339_C5")]
    public _Flags_e__Union Flags;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Flags_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L18340_C9")]
        public _Anonymous_e__Struct Anonymous;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint AsUlong;
        public uint SupportTimeParameter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return Anonymous.SupportTimeParameter; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { Anonymous.SupportTimeParameter = value; }
        }
        public uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return Anonymous.Reserved; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { Anonymous.Reserved = value; }
        }

        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            [NativeTypeName("DWORD : 1")]
            public uint SupportTimeParameter
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return _bitfield & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~0x1u) | (value & 0x1u); }
            }

            [NativeTypeName("DWORD : 31")]
            public uint Reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 1) & 0x7FFFFFFFu; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x7FFFFFFFu << 1)) | ((value & 0x7FFFFFFFu) << 1);
                }
            }
        }
    }
}
