// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MOUSEHOOKSTRUCTEX.xml' path='doc/member[@name="MOUSEHOOKSTRUCTEX"]/*'/>
[NativeTypeName("struct tagMOUSEHOOKSTRUCTEX : tagMOUSEHOOKSTRUCT")]
[NativeInheritance("tagMOUSEHOOKSTRUCT")]
public partial struct MOUSEHOOKSTRUCTEX
{
    public MOUSEHOOKSTRUCT Base;
    /// <include file='MOUSEHOOKSTRUCTEX.xml' path='doc/member[@name="MOUSEHOOKSTRUCTEX.mouseData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint mouseData;
}