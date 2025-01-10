// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MSV1_0_SUPPLEMENTAL_CREDENTIAL_V3
{
    [NativeTypeName("ULONG")]
    public uint Version;

    [NativeTypeName("ULONG")]
    public uint Flags;
    public MSV1_0_CREDENTIAL_KEY_TYPE CredentialKeyType;

    [NativeTypeName("UCHAR[16]")]
    public _NtPassword_e__FixedBuffer NtPassword;
    public MSV1_0_CREDENTIAL_KEY CredentialKey;

    [NativeTypeName("UCHAR[20]")]
    public _ShaPassword_e__FixedBuffer ShaPassword;

    [InlineArray(16)]
    public partial struct _NtPassword_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(20)]
    public partial struct _ShaPassword_e__FixedBuffer
    {
        public byte e0;
    }
}
