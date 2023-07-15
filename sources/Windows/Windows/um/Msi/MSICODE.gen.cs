// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Msi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MSICODE.xml' path='doc/member[@name="MSICODE"]/*'/>
public enum MSICODE
{
    /// <include file='MSICODE.xml' path='doc/member[@name="MSICODE.MSICODE_PRODUCT"]/*'/>
    MSICODE_PRODUCT = 0x00000000,
    /// <include file='MSICODE.xml' path='doc/member[@name="MSICODE.MSICODE_PATCH"]/*'/>
    MSICODE_PATCH = 0x40000000,
}