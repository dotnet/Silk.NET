// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SOUNDSENTRYW.xml' path='doc/member[@name="SOUNDSENTRYW"]/*'/>
public unsafe partial struct SOUNDSENTRYW
{
    /// <include file='SOUNDSENTRYW.xml' path='doc/member[@name="SOUNDSENTRYW.cbSize"]/*'/>
    public uint cbSize;
    /// <include file='SOUNDSENTRYW.xml' path='doc/member[@name="SOUNDSENTRYW.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='SOUNDSENTRYW.xml' path='doc/member[@name="SOUNDSENTRYW.iFSTextEffect"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iFSTextEffect;
    /// <include file='SOUNDSENTRYW.xml' path='doc/member[@name="SOUNDSENTRYW.iFSTextEffectMSec"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iFSTextEffectMSec;
    /// <include file='SOUNDSENTRYW.xml' path='doc/member[@name="SOUNDSENTRYW.iFSTextEffectColorBits"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iFSTextEffectColorBits;
    /// <include file='SOUNDSENTRYW.xml' path='doc/member[@name="SOUNDSENTRYW.iFSGrafEffect"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iFSGrafEffect;
    /// <include file='SOUNDSENTRYW.xml' path='doc/member[@name="SOUNDSENTRYW.iFSGrafEffectMSec"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iFSGrafEffectMSec;
    /// <include file='SOUNDSENTRYW.xml' path='doc/member[@name="SOUNDSENTRYW.iFSGrafEffectColor"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iFSGrafEffectColor;
    /// <include file='SOUNDSENTRYW.xml' path='doc/member[@name="SOUNDSENTRYW.iWindowsEffect"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iWindowsEffect;
    /// <include file='SOUNDSENTRYW.xml' path='doc/member[@name="SOUNDSENTRYW.iWindowsEffectMSec"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iWindowsEffectMSec;
    /// <include file='SOUNDSENTRYW.xml' path='doc/member[@name="SOUNDSENTRYW.lpszWindowsEffectDLL"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpszWindowsEffectDLL;
    /// <include file='SOUNDSENTRYW.xml' path='doc/member[@name="SOUNDSENTRYW.iWindowsEffectOrdinal"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iWindowsEffectOrdinal;
}