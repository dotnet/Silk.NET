// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DRAWTEXTPARAMS.xml' path='doc/member[@name="DRAWTEXTPARAMS"]/*'/>
public partial struct DRAWTEXTPARAMS
{
    /// <include file='DRAWTEXTPARAMS.xml' path='doc/member[@name="DRAWTEXTPARAMS.cbSize"]/*'/>
    public uint cbSize;
    /// <include file='DRAWTEXTPARAMS.xml' path='doc/member[@name="DRAWTEXTPARAMS.iTabLength"]/*'/>
    public int iTabLength;
    /// <include file='DRAWTEXTPARAMS.xml' path='doc/member[@name="DRAWTEXTPARAMS.iLeftMargin"]/*'/>
    public int iLeftMargin;
    /// <include file='DRAWTEXTPARAMS.xml' path='doc/member[@name="DRAWTEXTPARAMS.iRightMargin"]/*'/>
    public int iRightMargin;
    /// <include file='DRAWTEXTPARAMS.xml' path='doc/member[@name="DRAWTEXTPARAMS.uiLengthDrawn"]/*'/>
    public uint uiLengthDrawn;
}