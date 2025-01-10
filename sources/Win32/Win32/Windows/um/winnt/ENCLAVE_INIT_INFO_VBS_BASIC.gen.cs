// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct ENCLAVE_INIT_INFO_VBS_BASIC
{
    [NativeTypeName("BYTE[16]")]
    public _FamilyId_e__FixedBuffer FamilyId;

    [NativeTypeName("BYTE[16]")]
    public _ImageId_e__FixedBuffer ImageId;

    [NativeTypeName("ULONGLONG")]
    public ulong EnclaveSize;

    [NativeTypeName("DWORD")]
    public uint EnclaveSvn;

    [NativeTypeName("DWORD")]
    public uint Reserved;

    [NativeTypeName("__AnonymousRecord_winnt_L14777_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref HANDLE SignatureInfoHandle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.SignatureInfoHandle; }
    }

    [UnscopedRef]
    public ref ulong Unused
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Unused; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public HANDLE SignatureInfoHandle;

        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG")]
        public ulong Unused;
    }

    [InlineArray(16)]
    public partial struct _FamilyId_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(16)]
    public partial struct _ImageId_e__FixedBuffer
    {
        public byte e0;
    }
}
