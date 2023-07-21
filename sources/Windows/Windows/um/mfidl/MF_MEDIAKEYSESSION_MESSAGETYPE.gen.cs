// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='MF_MEDIAKEYSESSION_MESSAGETYPE.xml' path='doc/member[@name="MF_MEDIAKEYSESSION_MESSAGETYPE"]/*' />
[SupportedOSPlatform("windows10.0.19041.0")]
public enum MF_MEDIAKEYSESSION_MESSAGETYPE
{
    /// <include file='MF_MEDIAKEYSESSION_MESSAGETYPE.xml' path='doc/member[@name="MF_MEDIAKEYSESSION_MESSAGETYPE.MF_MEDIAKEYSESSION_MESSAGETYPE_LICENSE_REQUEST"]/*' />
    MF_MEDIAKEYSESSION_MESSAGETYPE_LICENSE_REQUEST = 0,

    /// <include file='MF_MEDIAKEYSESSION_MESSAGETYPE.xml' path='doc/member[@name="MF_MEDIAKEYSESSION_MESSAGETYPE.MF_MEDIAKEYSESSION_MESSAGETYPE_LICENSE_RENEWAL"]/*' />
    MF_MEDIAKEYSESSION_MESSAGETYPE_LICENSE_RENEWAL = 1,

    /// <include file='MF_MEDIAKEYSESSION_MESSAGETYPE.xml' path='doc/member[@name="MF_MEDIAKEYSESSION_MESSAGETYPE.MF_MEDIAKEYSESSION_MESSAGETYPE_LICENSE_RELEASE"]/*' />
    MF_MEDIAKEYSESSION_MESSAGETYPE_LICENSE_RELEASE = 2,

    /// <include file='MF_MEDIAKEYSESSION_MESSAGETYPE.xml' path='doc/member[@name="MF_MEDIAKEYSESSION_MESSAGETYPE.MF_MEDIAKEYSESSION_MESSAGETYPE_INDIVIDUALIZATION_REQUEST"]/*' />
    MF_MEDIAKEYSESSION_MESSAGETYPE_INDIVIDUALIZATION_REQUEST = 3,
}
