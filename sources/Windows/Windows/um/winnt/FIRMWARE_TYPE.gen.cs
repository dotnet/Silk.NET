// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='FIRMWARE_TYPE.xml' path='doc/member[@name="FIRMWARE_TYPE"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum FIRMWARE_TYPE
{
    /// <include file='FIRMWARE_TYPE.xml' path='doc/member[@name="FIRMWARE_TYPE.FirmwareTypeUnknown"]/*'/>
    FirmwareTypeUnknown,
    /// <include file='FIRMWARE_TYPE.xml' path='doc/member[@name="FIRMWARE_TYPE.FirmwareTypeBios"]/*'/>
    FirmwareTypeBios,
    /// <include file='FIRMWARE_TYPE.xml' path='doc/member[@name="FIRMWARE_TYPE.FirmwareTypeUefi"]/*'/>
    FirmwareTypeUefi,
    /// <include file='FIRMWARE_TYPE.xml' path='doc/member[@name="FIRMWARE_TYPE.FirmwareTypeMax"]/*'/>
    FirmwareTypeMax,
}