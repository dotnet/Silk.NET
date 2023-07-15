// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='MFCONTENTPROTECTIONDEVICE_INPUT_DATA.xml' path='doc/member[@name="MFCONTENTPROTECTIONDEVICE_INPUT_DATA"]/*'/>
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct MFCONTENTPROTECTIONDEVICE_INPUT_DATA
{
    /// <include file='MFCONTENTPROTECTIONDEVICE_INPUT_DATA.xml' path='doc/member[@name="MFCONTENTPROTECTIONDEVICE_INPUT_DATA.HWProtectionFunctionID"]/*'/>
    [NativeTypeName("DWORD")]
    public uint HWProtectionFunctionID;
    /// <include file='MFCONTENTPROTECTIONDEVICE_INPUT_DATA.xml' path='doc/member[@name="MFCONTENTPROTECTIONDEVICE_INPUT_DATA.PrivateDataByteCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PrivateDataByteCount;
    /// <include file='MFCONTENTPROTECTIONDEVICE_INPUT_DATA.xml' path='doc/member[@name="MFCONTENTPROTECTIONDEVICE_INPUT_DATA.HWProtectionDataByteCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint HWProtectionDataByteCount;
    /// <include file='MFCONTENTPROTECTIONDEVICE_INPUT_DATA.xml' path='doc/member[@name="MFCONTENTPROTECTIONDEVICE_INPUT_DATA.Reserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Reserved;
    /// <include file='MFCONTENTPROTECTIONDEVICE_INPUT_DATA.xml' path='doc/member[@name="MFCONTENTPROTECTIONDEVICE_INPUT_DATA.InputData"]/*'/>
    [NativeTypeName("BYTE[4]")]
    public fixed byte InputData[4];
}