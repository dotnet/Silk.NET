// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MARGINS.xml' path='doc/member[@name="MARGINS"]/*'/>
public partial struct MARGINS
{
    /// <include file='MARGINS.xml' path='doc/member[@name="MARGINS.cxLeftWidth"]/*'/>
    public int cxLeftWidth;
    /// <include file='MARGINS.xml' path='doc/member[@name="MARGINS.cxRightWidth"]/*'/>
    public int cxRightWidth;
    /// <include file='MARGINS.xml' path='doc/member[@name="MARGINS.cyTopHeight"]/*'/>
    public int cyTopHeight;
    /// <include file='MARGINS.xml' path='doc/member[@name="MARGINS.cyBottomHeight"]/*'/>
    public int cyBottomHeight;
}