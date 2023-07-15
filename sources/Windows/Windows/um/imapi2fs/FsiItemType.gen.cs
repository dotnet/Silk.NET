// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='FsiItemType.xml' path='doc/member[@name="FsiItemType"]/*'/>
public enum FsiItemType
{
    /// <include file='FsiItemType.xml' path='doc/member[@name="FsiItemType.FsiItemNotFound"]/*'/>
    FsiItemNotFound = 0,
    /// <include file='FsiItemType.xml' path='doc/member[@name="FsiItemType.FsiItemDirectory"]/*'/>
    FsiItemDirectory = 1,
    /// <include file='FsiItemType.xml' path='doc/member[@name="FsiItemType.FsiItemFile"]/*'/>
    FsiItemFile = 2,
}