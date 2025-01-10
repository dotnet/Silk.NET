// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0.16299.0")]
public partial struct IMAGE_ENCLAVE_IMPORT
{
    [NativeTypeName("DWORD")]
    public uint MatchType;

    [NativeTypeName("DWORD")]
    public uint MinimumSecurityVersion;

    [NativeTypeName("BYTE[32]")]
    public _UniqueOrAuthorID_e__FixedBuffer UniqueOrAuthorID;

    [NativeTypeName("BYTE[16]")]
    public _FamilyID_e__FixedBuffer FamilyID;

    [NativeTypeName("BYTE[16]")]
    public _ImageID_e__FixedBuffer ImageID;

    [NativeTypeName("DWORD")]
    public uint ImportName;

    [NativeTypeName("DWORD")]
    public uint Reserved;

    [InlineArray(32)]
    public partial struct _UniqueOrAuthorID_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(16)]
    public partial struct _FamilyID_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(16)]
    public partial struct _ImageID_e__FixedBuffer
    {
        public byte e0;
    }
}
