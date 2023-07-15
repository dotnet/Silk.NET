// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DEBUGHOOKINFO.xml' path='doc/member[@name="DEBUGHOOKINFO"]/*'/>
public partial struct DEBUGHOOKINFO
{
    /// <include file='DEBUGHOOKINFO.xml' path='doc/member[@name="DEBUGHOOKINFO.idThread"]/*'/>
    [NativeTypeName("DWORD")]
    public uint idThread;
    /// <include file='DEBUGHOOKINFO.xml' path='doc/member[@name="DEBUGHOOKINFO.idThreadInstaller"]/*'/>
    [NativeTypeName("DWORD")]
    public uint idThreadInstaller;
    /// <include file='DEBUGHOOKINFO.xml' path='doc/member[@name="DEBUGHOOKINFO.lParam"]/*'/>
    public LPARAM lParam;
    /// <include file='DEBUGHOOKINFO.xml' path='doc/member[@name="DEBUGHOOKINFO.wParam"]/*'/>
    public WPARAM wParam;
    /// <include file='DEBUGHOOKINFO.xml' path='doc/member[@name="DEBUGHOOKINFO.code"]/*'/>
    public int code;
}