// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public unsafe partial struct CLAIM_SECURITY_ATTRIBUTE_V1
{
    [NativeTypeName("PWSTR")]
    public ushort* Name;

    [NativeTypeName("WORD")]
    public ushort ValueType;

    [NativeTypeName("WORD")]
    public ushort Reserved;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORD")]
    public uint ValueCount;

    [NativeTypeName("__AnonymousRecord_winnt_L12466_C5")]
    public _Values_e__Union Values;

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Values_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("PLONG64")]
        public long* pInt64;

        [FieldOffset(0)]
        [NativeTypeName("PDWORD64")]
        public ulong* pUint64;

        [FieldOffset(0)]
        [NativeTypeName("PWSTR *")]
        public ushort** ppString;

        [FieldOffset(0)]
        [NativeTypeName("PCLAIM_SECURITY_ATTRIBUTE_FQBN_VALUE")]
        public CLAIM_SECURITY_ATTRIBUTE_FQBN_VALUE* pFqbn;

        [FieldOffset(0)]
        [NativeTypeName("PCLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE")]
        public CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE* pOctetString;
    }
}
