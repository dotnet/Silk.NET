// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='RBHITTESTINFO.xml' path='doc/member[@name="RBHITTESTINFO"]/*'/>
public partial struct RBHITTESTINFO
{
    /// <include file='RBHITTESTINFO.xml' path='doc/member[@name="RBHITTESTINFO.pt"]/*'/>
    public POINT pt;
    /// <include file='RBHITTESTINFO.xml' path='doc/member[@name="RBHITTESTINFO.flags"]/*'/>
    public uint flags;
    /// <include file='RBHITTESTINFO.xml' path='doc/member[@name="RBHITTESTINFO.iBand"]/*'/>
    public int iBand;
}