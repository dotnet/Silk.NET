// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MDMRegistration.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='REGISTRATION_INFORMATION_CLASS.xml' path='doc/member[@name="REGISTRATION_INFORMATION_CLASS"]/*'/>
[SupportedOSPlatform("windows6.3")]
public enum REGISTRATION_INFORMATION_CLASS
{
    /// <include file='REGISTRATION_INFORMATION_CLASS.xml' path='doc/member[@name="REGISTRATION_INFORMATION_CLASS.DeviceRegistrationBasicInfo"]/*'/>
    DeviceRegistrationBasicInfo = 1,
    /// <include file='REGISTRATION_INFORMATION_CLASS.xml' path='doc/member[@name="REGISTRATION_INFORMATION_CLASS.MaxDeviceInfoClass"]/*'/>
    MaxDeviceInfoClass,
}