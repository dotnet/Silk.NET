// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SoftPub.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct DRIVER_VER_INFO
{
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    [NativeTypeName("ULONG_PTR")]
    public nuint dwReserved1;

    [NativeTypeName("ULONG_PTR")]
    public nuint dwReserved2;

    [NativeTypeName("DWORD")]
    public uint dwPlatform;

    [NativeTypeName("DWORD")]
    public uint dwVersion;

    [NativeTypeName("WCHAR[260]")]
    public _wszVersion_e__FixedBuffer wszVersion;

    [NativeTypeName("WCHAR[260]")]
    public _wszSignedBy_e__FixedBuffer wszSignedBy;

    [NativeTypeName("PCCERT_CONTEXT")]
    public CERT_CONTEXT* pcSignerCertContext;
    public DRIVER_VER_MAJORMINOR sOSVersionLow;
    public DRIVER_VER_MAJORMINOR sOSVersionHigh;

    [NativeTypeName("DWORD")]
    public uint dwBuildNumberLow;

    [NativeTypeName("DWORD")]
    public uint dwBuildNumberHigh;

    [InlineArray(260)]
    public partial struct _wszVersion_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(260)]
    public partial struct _wszSignedBy_e__FixedBuffer
    {
        public ushort e0;
    }
}
