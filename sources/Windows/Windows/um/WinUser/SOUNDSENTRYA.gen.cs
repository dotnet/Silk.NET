// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SOUNDSENTRYA.xml' path='doc/member[@name="SOUNDSENTRYA"]/*'/>
public unsafe partial struct SOUNDSENTRYA
{
    /// <include file='SOUNDSENTRYA.xml' path='doc/member[@name="SOUNDSENTRYA.cbSize"]/*'/>
    public uint cbSize;
    /// <include file='SOUNDSENTRYA.xml' path='doc/member[@name="SOUNDSENTRYA.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='SOUNDSENTRYA.xml' path='doc/member[@name="SOUNDSENTRYA.iFSTextEffect"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iFSTextEffect;
    /// <include file='SOUNDSENTRYA.xml' path='doc/member[@name="SOUNDSENTRYA.iFSTextEffectMSec"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iFSTextEffectMSec;
    /// <include file='SOUNDSENTRYA.xml' path='doc/member[@name="SOUNDSENTRYA.iFSTextEffectColorBits"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iFSTextEffectColorBits;
    /// <include file='SOUNDSENTRYA.xml' path='doc/member[@name="SOUNDSENTRYA.iFSGrafEffect"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iFSGrafEffect;
    /// <include file='SOUNDSENTRYA.xml' path='doc/member[@name="SOUNDSENTRYA.iFSGrafEffectMSec"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iFSGrafEffectMSec;
    /// <include file='SOUNDSENTRYA.xml' path='doc/member[@name="SOUNDSENTRYA.iFSGrafEffectColor"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iFSGrafEffectColor;
    /// <include file='SOUNDSENTRYA.xml' path='doc/member[@name="SOUNDSENTRYA.iWindowsEffect"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iWindowsEffect;
    /// <include file='SOUNDSENTRYA.xml' path='doc/member[@name="SOUNDSENTRYA.iWindowsEffectMSec"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iWindowsEffectMSec;
    /// <include file='SOUNDSENTRYA.xml' path='doc/member[@name="SOUNDSENTRYA.lpszWindowsEffectDLL"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpszWindowsEffectDLL;
    /// <include file='SOUNDSENTRYA.xml' path='doc/member[@name="SOUNDSENTRYA.iWindowsEffectOrdinal"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iWindowsEffectOrdinal;
}