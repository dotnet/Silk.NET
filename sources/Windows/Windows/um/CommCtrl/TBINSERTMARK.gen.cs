// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TBINSERTMARK.xml' path='doc/member[@name="TBINSERTMARK"]/*'/>
public partial struct TBINSERTMARK
{
    /// <include file='TBINSERTMARK.xml' path='doc/member[@name="TBINSERTMARK.iButton"]/*'/>
    public int iButton;
    /// <include file='TBINSERTMARK.xml' path='doc/member[@name="TBINSERTMARK.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
}