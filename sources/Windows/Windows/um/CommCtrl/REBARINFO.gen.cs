// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='REBARINFO.xml' path='doc/member[@name="REBARINFO"]/*'/>
public partial struct REBARINFO
{
    /// <include file='REBARINFO.xml' path='doc/member[@name="REBARINFO.cbSize"]/*'/>
    public uint cbSize;
    /// <include file='REBARINFO.xml' path='doc/member[@name="REBARINFO.fMask"]/*'/>
    public uint fMask;
    /// <include file='REBARINFO.xml' path='doc/member[@name="REBARINFO.himl"]/*'/>
    public HIMAGELIST himl;
}