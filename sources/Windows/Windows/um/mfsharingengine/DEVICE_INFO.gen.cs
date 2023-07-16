// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='DEVICE_INFO.xml' path='doc/member[@name="DEVICE_INFO"]/*'/>
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct DEVICE_INFO
{
    /// <include file='DEVICE_INFO.xml' path='doc/member[@name="DEVICE_INFO.pFriendlyDeviceName"]/*'/>
    [NativeTypeName("BSTR")]
    public ushort* pFriendlyDeviceName;
    /// <include file='DEVICE_INFO.xml' path='doc/member[@name="DEVICE_INFO.pUniqueDeviceName"]/*'/>
    [NativeTypeName("BSTR")]
    public ushort* pUniqueDeviceName;
    /// <include file='DEVICE_INFO.xml' path='doc/member[@name="DEVICE_INFO.pManufacturerName"]/*'/>
    [NativeTypeName("BSTR")]
    public ushort* pManufacturerName;
    /// <include file='DEVICE_INFO.xml' path='doc/member[@name="DEVICE_INFO.pModelName"]/*'/>
    [NativeTypeName("BSTR")]
    public ushort* pModelName;
    /// <include file='DEVICE_INFO.xml' path='doc/member[@name="DEVICE_INFO.pIconURL"]/*'/>
    [NativeTypeName("BSTR")]
    public ushort* pIconURL;
}