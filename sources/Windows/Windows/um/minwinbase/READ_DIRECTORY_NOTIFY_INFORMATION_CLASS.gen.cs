// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='READ_DIRECTORY_NOTIFY_INFORMATION_CLASS.xml' path='doc/member[@name="READ_DIRECTORY_NOTIFY_INFORMATION_CLASS"]/*'/>
[SupportedOSPlatform("windows10.0.16299.0")]
public enum READ_DIRECTORY_NOTIFY_INFORMATION_CLASS
{
    /// <include file='READ_DIRECTORY_NOTIFY_INFORMATION_CLASS.xml' path='doc/member[@name="READ_DIRECTORY_NOTIFY_INFORMATION_CLASS.ReadDirectoryNotifyInformation"]/*'/>
    ReadDirectoryNotifyInformation = 1,
    /// <include file='READ_DIRECTORY_NOTIFY_INFORMATION_CLASS.xml' path='doc/member[@name="READ_DIRECTORY_NOTIFY_INFORMATION_CLASS.ReadDirectoryNotifyExtendedInformation"]/*'/>
    ReadDirectoryNotifyExtendedInformation,
    /// <include file='READ_DIRECTORY_NOTIFY_INFORMATION_CLASS.xml' path='doc/member[@name="READ_DIRECTORY_NOTIFY_INFORMATION_CLASS.ReadDirectoryNotifyFullInformation"]/*'/>
    ReadDirectoryNotifyFullInformation,
    /// <include file='READ_DIRECTORY_NOTIFY_INFORMATION_CLASS.xml' path='doc/member[@name="READ_DIRECTORY_NOTIFY_INFORMATION_CLASS.ReadDirectoryNotifyMaximumInformation"]/*'/>
    ReadDirectoryNotifyMaximumInformation,
}