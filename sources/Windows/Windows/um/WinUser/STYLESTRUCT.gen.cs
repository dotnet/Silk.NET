// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STYLESTRUCT.xml' path='doc/member[@name="STYLESTRUCT"]/*'/>
public partial struct STYLESTRUCT
{
    /// <include file='STYLESTRUCT.xml' path='doc/member[@name="STYLESTRUCT.styleOld"]/*'/>
    [NativeTypeName("DWORD")]
    public uint styleOld;
    /// <include file='STYLESTRUCT.xml' path='doc/member[@name="STYLESTRUCT.styleNew"]/*'/>
    [NativeTypeName("DWORD")]
    public uint styleNew;
}