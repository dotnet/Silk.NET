// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='msidbEmbeddedUIAttributes.xml' path='doc/member[@name="msidbEmbeddedUIAttributes"]/*'/>
public enum msidbEmbeddedUIAttributes
{
    /// <include file='msidbEmbeddedUIAttributes.xml' path='doc/member[@name="msidbEmbeddedUIAttributes.msidbEmbeddedUI"]/*'/>
    msidbEmbeddedUI = 0x01,
    /// <include file='msidbEmbeddedUIAttributes.xml' path='doc/member[@name="msidbEmbeddedUIAttributes.msidbEmbeddedHandlesBasic"]/*'/>
    msidbEmbeddedHandlesBasic = 0x02,
}