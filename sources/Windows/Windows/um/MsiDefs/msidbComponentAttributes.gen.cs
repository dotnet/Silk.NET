// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='msidbComponentAttributes.xml' path='doc/member[@name="msidbComponentAttributes"]/*'/>
public enum msidbComponentAttributes
{
    /// <include file='msidbComponentAttributes.xml' path='doc/member[@name="msidbComponentAttributes.msidbComponentAttributesLocalOnly"]/*'/>
    msidbComponentAttributesLocalOnly = 0x00000000,
    /// <include file='msidbComponentAttributes.xml' path='doc/member[@name="msidbComponentAttributes.msidbComponentAttributesSourceOnly"]/*'/>
    msidbComponentAttributesSourceOnly = 0x00000001,
    /// <include file='msidbComponentAttributes.xml' path='doc/member[@name="msidbComponentAttributes.msidbComponentAttributesOptional"]/*'/>
    msidbComponentAttributesOptional = 0x00000002,
    /// <include file='msidbComponentAttributes.xml' path='doc/member[@name="msidbComponentAttributes.msidbComponentAttributesRegistryKeyPath"]/*'/>
    msidbComponentAttributesRegistryKeyPath = 0x00000004,
    /// <include file='msidbComponentAttributes.xml' path='doc/member[@name="msidbComponentAttributes.msidbComponentAttributesSharedDllRefCount"]/*'/>
    msidbComponentAttributesSharedDllRefCount = 0x00000008,
    /// <include file='msidbComponentAttributes.xml' path='doc/member[@name="msidbComponentAttributes.msidbComponentAttributesPermanent"]/*'/>
    msidbComponentAttributesPermanent = 0x00000010,
    /// <include file='msidbComponentAttributes.xml' path='doc/member[@name="msidbComponentAttributes.msidbComponentAttributesODBCDataSource"]/*'/>
    msidbComponentAttributesODBCDataSource = 0x00000020,
    /// <include file='msidbComponentAttributes.xml' path='doc/member[@name="msidbComponentAttributes.msidbComponentAttributesTransitive"]/*'/>
    msidbComponentAttributesTransitive = 0x00000040,
    /// <include file='msidbComponentAttributes.xml' path='doc/member[@name="msidbComponentAttributes.msidbComponentAttributesNeverOverwrite"]/*'/>
    msidbComponentAttributesNeverOverwrite = 0x00000080,
    /// <include file='msidbComponentAttributes.xml' path='doc/member[@name="msidbComponentAttributes.msidbComponentAttributes64bit"]/*'/>
    msidbComponentAttributes64bit = 0x00000100,
    /// <include file='msidbComponentAttributes.xml' path='doc/member[@name="msidbComponentAttributes.msidbComponentAttributesDisableRegistryReflection"]/*'/>
    msidbComponentAttributesDisableRegistryReflection = 0x00000200,
    /// <include file='msidbComponentAttributes.xml' path='doc/member[@name="msidbComponentAttributes.msidbComponentAttributesUninstallOnSupersedence"]/*'/>
    msidbComponentAttributesUninstallOnSupersedence = 0x00000400,
    /// <include file='msidbComponentAttributes.xml' path='doc/member[@name="msidbComponentAttributes.msidbComponentAttributesShared"]/*'/>
    msidbComponentAttributesShared = 0x00000800,
}