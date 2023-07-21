// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='MFCONTENTPROTECTIONDEVICE_OUTPUT_DATA.xml' path='doc/member[@name="MFCONTENTPROTECTIONDEVICE_OUTPUT_DATA"]/*' />
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct MFCONTENTPROTECTIONDEVICE_OUTPUT_DATA
{
    /// <include file='MFCONTENTPROTECTIONDEVICE_OUTPUT_DATA.xml' path='doc/member[@name="MFCONTENTPROTECTIONDEVICE_OUTPUT_DATA.PrivateDataByteCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint PrivateDataByteCount;

    /// <include file='MFCONTENTPROTECTIONDEVICE_OUTPUT_DATA.xml' path='doc/member[@name="MFCONTENTPROTECTIONDEVICE_OUTPUT_DATA.MaxHWProtectionDataByteCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxHWProtectionDataByteCount;

    /// <include file='MFCONTENTPROTECTIONDEVICE_OUTPUT_DATA.xml' path='doc/member[@name="MFCONTENTPROTECTIONDEVICE_OUTPUT_DATA.HWProtectionDataByteCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint HWProtectionDataByteCount;

    /// <include file='MFCONTENTPROTECTIONDEVICE_OUTPUT_DATA.xml' path='doc/member[@name="MFCONTENTPROTECTIONDEVICE_OUTPUT_DATA.Status"]/*' />
    public HRESULT Status;

    /// <include file='MFCONTENTPROTECTIONDEVICE_OUTPUT_DATA.xml' path='doc/member[@name="MFCONTENTPROTECTIONDEVICE_OUTPUT_DATA.TransportTimeInHundredsOfNanoseconds"]/*' />
    [NativeTypeName("LONGLONG")]
    public long TransportTimeInHundredsOfNanoseconds;

    /// <include file='MFCONTENTPROTECTIONDEVICE_OUTPUT_DATA.xml' path='doc/member[@name="MFCONTENTPROTECTIONDEVICE_OUTPUT_DATA.ExecutionTimeInHundredsOfNanoseconds"]/*' />
    [NativeTypeName("LONGLONG")]
    public long ExecutionTimeInHundredsOfNanoseconds;

    /// <include file='MFCONTENTPROTECTIONDEVICE_OUTPUT_DATA.xml' path='doc/member[@name="MFCONTENTPROTECTIONDEVICE_OUTPUT_DATA.OutputData"]/*' />
    [NativeTypeName("BYTE[4]")]
    public fixed byte OutputData[4];
}
