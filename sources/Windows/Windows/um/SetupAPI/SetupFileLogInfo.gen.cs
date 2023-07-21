// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SetupFileLogInfo.xml' path='doc/member[@name="SetupFileLogInfo"]/*' />
public enum SetupFileLogInfo
{
    /// <include file='SetupFileLogInfo.xml' path='doc/member[@name="SetupFileLogInfo.SetupFileLogSourceFilename"]/*' />
    SetupFileLogSourceFilename,

    /// <include file='SetupFileLogInfo.xml' path='doc/member[@name="SetupFileLogInfo.SetupFileLogChecksum"]/*' />
    SetupFileLogChecksum,

    /// <include file='SetupFileLogInfo.xml' path='doc/member[@name="SetupFileLogInfo.SetupFileLogDiskTagfile"]/*' />
    SetupFileLogDiskTagfile,

    /// <include file='SetupFileLogInfo.xml' path='doc/member[@name="SetupFileLogInfo.SetupFileLogDiskDescription"]/*' />
    SetupFileLogDiskDescription,

    /// <include file='SetupFileLogInfo.xml' path='doc/member[@name="SetupFileLogInfo.SetupFileLogOtherInfo"]/*' />
    SetupFileLogOtherInfo,

    /// <include file='SetupFileLogInfo.xml' path='doc/member[@name="SetupFileLogInfo.SetupFileLogMax"]/*' />
    SetupFileLogMax,
}
