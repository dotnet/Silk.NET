// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct IMAGE_DELAYLOAD_DESCRIPTOR
{
    [NativeTypeName("__AnonymousRecord_winnt_L20629_C5")]
    public _Attributes_e__Union Attributes;

    [NativeTypeName("DWORD")]
    public uint DllNameRVA;

    [NativeTypeName("DWORD")]
    public uint ModuleHandleRVA;

    [NativeTypeName("DWORD")]
    public uint ImportAddressTableRVA;

    [NativeTypeName("DWORD")]
    public uint ImportNameTableRVA;

    [NativeTypeName("DWORD")]
    public uint BoundImportAddressTableRVA;

    [NativeTypeName("DWORD")]
    public uint UnloadInformationTableRVA;

    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Attributes_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint AllAttributes;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L20631_C9")]
        public _Anonymous_e__Struct Anonymous;
        public uint RvaBased
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return Anonymous.RvaBased; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { Anonymous.RvaBased = value; }
        }
        public uint ReservedAttributes
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return Anonymous.ReservedAttributes; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { Anonymous.ReservedAttributes = value; }
        }

        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            [NativeTypeName("DWORD : 1")]
            public uint RvaBased
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return _bitfield & 0x1u; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~0x1u) | (value & 0x1u); }
            }

            [NativeTypeName("DWORD : 31")]
            public uint ReservedAttributes
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
