// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='msidbLocatorType.xml' path='doc/member[@name="msidbLocatorType"]/*'/>
public enum msidbLocatorType
{
    /// <include file='msidbLocatorType.xml' path='doc/member[@name="msidbLocatorType.msidbLocatorTypeDirectory"]/*'/>
    msidbLocatorTypeDirectory = 0x00000000,
    /// <include file='msidbLocatorType.xml' path='doc/member[@name="msidbLocatorType.msidbLocatorTypeFileName"]/*'/>
    msidbLocatorTypeFileName = 0x00000001,
    /// <include file='msidbLocatorType.xml' path='doc/member[@name="msidbLocatorType.msidbLocatorTypeRawValue"]/*'/>
    msidbLocatorTypeRawValue = 0x00000002,
    /// <include file='msidbLocatorType.xml' path='doc/member[@name="msidbLocatorType.msidbLocatorType64bit"]/*'/>
    msidbLocatorType64bit = 0x00000010,
}