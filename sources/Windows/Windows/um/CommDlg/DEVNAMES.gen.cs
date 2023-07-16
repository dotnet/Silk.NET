// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DEVNAMES.xml' path='doc/member[@name="DEVNAMES"]/*'/>
public partial struct DEVNAMES
{
    /// <include file='DEVNAMES.xml' path='doc/member[@name="DEVNAMES.wDriverOffset"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wDriverOffset;
    /// <include file='DEVNAMES.xml' path='doc/member[@name="DEVNAMES.wDeviceOffset"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wDeviceOffset;
    /// <include file='DEVNAMES.xml' path='doc/member[@name="DEVNAMES.wOutputOffset"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wOutputOffset;
    /// <include file='DEVNAMES.xml' path='doc/member[@name="DEVNAMES.wDefault"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wDefault;
}