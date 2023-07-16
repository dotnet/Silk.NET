// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TBINFO.xml' path='doc/member[@name="TBINFO"]/*'/>
public partial struct TBINFO
{
    /// <include file='TBINFO.xml' path='doc/member[@name="TBINFO.cbuttons"]/*'/>
    public uint cbuttons;
    /// <include file='TBINFO.xml' path='doc/member[@name="TBINFO.uFlags"]/*'/>
    public uint uFlags;
}