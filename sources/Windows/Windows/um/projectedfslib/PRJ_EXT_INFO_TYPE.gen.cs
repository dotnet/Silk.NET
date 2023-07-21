// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='PRJ_EXT_INFO_TYPE.xml' path='doc/member[@name="PRJ_EXT_INFO_TYPE"]/*' />
[SupportedOSPlatform("windows10.0.19041.0")]
public enum PRJ_EXT_INFO_TYPE
{
    /// <include file='PRJ_EXT_INFO_TYPE.xml' path='doc/member[@name="PRJ_EXT_INFO_TYPE.PRJ_EXT_INFO_TYPE_SYMLINK"]/*' />
    PRJ_EXT_INFO_TYPE_SYMLINK = 1,
}
