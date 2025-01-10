// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0.16299.0")]
public partial struct IMAGE_ENCLAVE_CONFIG32
{
    [NativeTypeName("DWORD")]
    public uint Size;

    [NativeTypeName("DWORD")]
    public uint MinimumRequiredConfigSize;

    [NativeTypeName("DWORD")]
    public uint PolicyFlags;

    [NativeTypeName("DWORD")]
    public uint NumberOfImports;

    [NativeTypeName("DWORD")]
    public uint ImportList;

    [NativeTypeName("DWORD")]
    public uint ImportEntrySize;

    [NativeTypeName("BYTE[16]")]
    public _FamilyID_e__FixedBuffer FamilyID;

    [NativeTypeName("BYTE[16]")]
    public _ImageID_e__FixedBuffer ImageID;

    [NativeTypeName("DWORD")]
    public uint ImageVersion;

    [NativeTypeName("DWORD")]
    public uint SecurityVersion;

    [NativeTypeName("DWORD")]
    public uint EnclaveSize;

    [NativeTypeName("DWORD")]
    public uint NumberOfThreads;

    [NativeTypeName("DWORD")]
    public uint EnclaveFlags;

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
