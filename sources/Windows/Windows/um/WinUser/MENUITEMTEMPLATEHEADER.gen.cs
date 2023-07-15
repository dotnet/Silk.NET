// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MENUITEMTEMPLATEHEADER.xml' path='doc/member[@name="MENUITEMTEMPLATEHEADER"]/*'/>
public partial struct MENUITEMTEMPLATEHEADER
{
    /// <include file='MENUITEMTEMPLATEHEADER.xml' path='doc/member[@name="MENUITEMTEMPLATEHEADER.versionNumber"]/*'/>
    [NativeTypeName("WORD")]
    public ushort versionNumber;
    /// <include file='MENUITEMTEMPLATEHEADER.xml' path='doc/member[@name="MENUITEMTEMPLATEHEADER.offset"]/*'/>
    [NativeTypeName("WORD")]
    public ushort offset;
}