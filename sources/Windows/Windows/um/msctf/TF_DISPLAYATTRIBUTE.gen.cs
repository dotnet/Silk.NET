// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TF_DISPLAYATTRIBUTE.xml' path='doc/member[@name="TF_DISPLAYATTRIBUTE"]/*'/>
public partial struct TF_DISPLAYATTRIBUTE
{
    /// <include file='TF_DISPLAYATTRIBUTE.xml' path='doc/member[@name="TF_DISPLAYATTRIBUTE.crText"]/*'/>
    public TF_DA_COLOR crText;
    /// <include file='TF_DISPLAYATTRIBUTE.xml' path='doc/member[@name="TF_DISPLAYATTRIBUTE.crBk"]/*'/>
    public TF_DA_COLOR crBk;
    /// <include file='TF_DISPLAYATTRIBUTE.xml' path='doc/member[@name="TF_DISPLAYATTRIBUTE.lsStyle"]/*'/>
    public TF_DA_LINESTYLE lsStyle;
    /// <include file='TF_DISPLAYATTRIBUTE.xml' path='doc/member[@name="TF_DISPLAYATTRIBUTE.fBoldLine"]/*'/>
    public BOOL fBoldLine;
    /// <include file='TF_DISPLAYATTRIBUTE.xml' path='doc/member[@name="TF_DISPLAYATTRIBUTE.crLine"]/*'/>
    public TF_DA_COLOR crLine;
    /// <include file='TF_DISPLAYATTRIBUTE.xml' path='doc/member[@name="TF_DISPLAYATTRIBUTE.bAttr"]/*'/>
    public TF_DA_ATTR_INFO bAttr;
}