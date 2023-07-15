// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='INPUT_MESSAGE_SOURCE.xml' path='doc/member[@name="INPUT_MESSAGE_SOURCE"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct INPUT_MESSAGE_SOURCE
{
    /// <include file='INPUT_MESSAGE_SOURCE.xml' path='doc/member[@name="INPUT_MESSAGE_SOURCE.deviceType"]/*'/>
    public INPUT_MESSAGE_DEVICE_TYPE deviceType;
    /// <include file='INPUT_MESSAGE_SOURCE.xml' path='doc/member[@name="INPUT_MESSAGE_SOURCE.originId"]/*'/>
    public INPUT_MESSAGE_ORIGIN_ID originId;
}