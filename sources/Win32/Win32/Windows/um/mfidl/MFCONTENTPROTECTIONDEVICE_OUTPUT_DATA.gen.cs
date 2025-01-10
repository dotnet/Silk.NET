// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0")]
public partial struct MFCONTENTPROTECTIONDEVICE_OUTPUT_DATA
{
    [NativeTypeName("DWORD")]
    public uint PrivateDataByteCount;

    [NativeTypeName("DWORD")]
    public uint MaxHWProtectionDataByteCount;

    [NativeTypeName("DWORD")]
    public uint HWProtectionDataByteCount;
    public HRESULT Status;

    [NativeTypeName("LONGLONG")]
    public long TransportTimeInHundredsOfNanoseconds;

    [NativeTypeName("LONGLONG")]
    public long ExecutionTimeInHundredsOfNanoseconds;

    [NativeTypeName("BYTE[4]")]
    public _OutputData_e__FixedBuffer OutputData;

    [InlineArray(4)]
    public partial struct _OutputData_e__FixedBuffer
    {
        public byte e0;
    }
}
