// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='msirbRebootType.xml' path='doc/member[@name="msirbRebootType"]/*'/>
public enum msirbRebootType
{
    /// <include file='msirbRebootType.xml' path='doc/member[@name="msirbRebootType.msirbRebootImmediate"]/*'/>
    msirbRebootImmediate = 1,
    /// <include file='msirbRebootType.xml' path='doc/member[@name="msirbRebootType.msirbRebootDeferred"]/*'/>
    msirbRebootDeferred = 2,
}