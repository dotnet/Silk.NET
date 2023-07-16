// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='BUTTON_SPLITINFO.xml' path='doc/member[@name="BUTTON_SPLITINFO"]/*'/>
public partial struct BUTTON_SPLITINFO
{
    /// <include file='BUTTON_SPLITINFO.xml' path='doc/member[@name="BUTTON_SPLITINFO.mask"]/*'/>
    public uint mask;
    /// <include file='BUTTON_SPLITINFO.xml' path='doc/member[@name="BUTTON_SPLITINFO.himlGlyph"]/*'/>
    public HIMAGELIST himlGlyph;
    /// <include file='BUTTON_SPLITINFO.xml' path='doc/member[@name="BUTTON_SPLITINFO.uSplitStyle"]/*'/>
    public uint uSplitStyle;
    /// <include file='BUTTON_SPLITINFO.xml' path='doc/member[@name="BUTTON_SPLITINFO.size"]/*'/>
    public SIZE size;
}