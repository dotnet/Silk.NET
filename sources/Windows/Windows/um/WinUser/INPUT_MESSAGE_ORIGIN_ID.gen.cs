// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='INPUT_MESSAGE_ORIGIN_ID.xml' path='doc/member[@name="INPUT_MESSAGE_ORIGIN_ID"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum INPUT_MESSAGE_ORIGIN_ID
{
    /// <include file='INPUT_MESSAGE_ORIGIN_ID.xml' path='doc/member[@name="INPUT_MESSAGE_ORIGIN_ID.IMO_UNAVAILABLE"]/*' />
    IMO_UNAVAILABLE = 0x00000000,

    /// <include file='INPUT_MESSAGE_ORIGIN_ID.xml' path='doc/member[@name="INPUT_MESSAGE_ORIGIN_ID.IMO_HARDWARE"]/*' />
    IMO_HARDWARE = 0x00000001,

    /// <include file='INPUT_MESSAGE_ORIGIN_ID.xml' path='doc/member[@name="INPUT_MESSAGE_ORIGIN_ID.IMO_INJECTED"]/*' />
    IMO_INJECTED = 0x00000002,

    /// <include file='INPUT_MESSAGE_ORIGIN_ID.xml' path='doc/member[@name="INPUT_MESSAGE_ORIGIN_ID.IMO_SYSTEM"]/*' />
    IMO_SYSTEM = 0x00000004,
}
