// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DIENVELOPE.xml' path='doc/member[@name="DIENVELOPE"]/*'/>
public partial struct DIENVELOPE
{
    /// <include file='DIENVELOPE.xml' path='doc/member[@name="DIENVELOPE.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='DIENVELOPE.xml' path='doc/member[@name="DIENVELOPE.dwAttackLevel"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAttackLevel;
    /// <include file='DIENVELOPE.xml' path='doc/member[@name="DIENVELOPE.dwAttackTime"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAttackTime;
    /// <include file='DIENVELOPE.xml' path='doc/member[@name="DIENVELOPE.dwFadeLevel"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFadeLevel;
    /// <include file='DIENVELOPE.xml' path='doc/member[@name="DIENVELOPE.dwFadeTime"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFadeTime;
}