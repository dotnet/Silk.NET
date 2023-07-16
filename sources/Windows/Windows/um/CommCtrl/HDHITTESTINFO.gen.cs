// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='HDHITTESTINFO.xml' path='doc/member[@name="HDHITTESTINFO"]/*'/>
public partial struct HDHITTESTINFO
{
    /// <include file='HDHITTESTINFO.xml' path='doc/member[@name="HDHITTESTINFO.pt"]/*'/>
    public POINT pt;
    /// <include file='HDHITTESTINFO.xml' path='doc/member[@name="HDHITTESTINFO.flags"]/*'/>
    public uint flags;
    /// <include file='HDHITTESTINFO.xml' path='doc/member[@name="HDHITTESTINFO.iItem"]/*'/>
    public int iItem;
}