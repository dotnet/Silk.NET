// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CHANGER_SET_ACCESS.xml' path='doc/member[@name="CHANGER_SET_ACCESS"]/*'/>
public partial struct CHANGER_SET_ACCESS
{
    /// <include file='CHANGER_SET_ACCESS.xml' path='doc/member[@name="CHANGER_SET_ACCESS.Element"]/*'/>
    public CHANGER_ELEMENT Element;
    /// <include file='CHANGER_SET_ACCESS.xml' path='doc/member[@name="CHANGER_SET_ACCESS.Control"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Control;
}