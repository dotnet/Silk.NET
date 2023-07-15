// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/verrsrc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='VS_FIXEDFILEINFO.xml' path='doc/member[@name="VS_FIXEDFILEINFO"]/*'/>
public partial struct VS_FIXEDFILEINFO
{
    /// <include file='VS_FIXEDFILEINFO.xml' path='doc/member[@name="VS_FIXEDFILEINFO.dwSignature"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSignature;
    /// <include file='VS_FIXEDFILEINFO.xml' path='doc/member[@name="VS_FIXEDFILEINFO.dwStrucVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwStrucVersion;
    /// <include file='VS_FIXEDFILEINFO.xml' path='doc/member[@name="VS_FIXEDFILEINFO.dwFileVersionMS"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFileVersionMS;
    /// <include file='VS_FIXEDFILEINFO.xml' path='doc/member[@name="VS_FIXEDFILEINFO.dwFileVersionLS"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFileVersionLS;
    /// <include file='VS_FIXEDFILEINFO.xml' path='doc/member[@name="VS_FIXEDFILEINFO.dwProductVersionMS"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwProductVersionMS;
    /// <include file='VS_FIXEDFILEINFO.xml' path='doc/member[@name="VS_FIXEDFILEINFO.dwProductVersionLS"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwProductVersionLS;
    /// <include file='VS_FIXEDFILEINFO.xml' path='doc/member[@name="VS_FIXEDFILEINFO.dwFileFlagsMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFileFlagsMask;
    /// <include file='VS_FIXEDFILEINFO.xml' path='doc/member[@name="VS_FIXEDFILEINFO.dwFileFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFileFlags;
    /// <include file='VS_FIXEDFILEINFO.xml' path='doc/member[@name="VS_FIXEDFILEINFO.dwFileOS"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFileOS;
    /// <include file='VS_FIXEDFILEINFO.xml' path='doc/member[@name="VS_FIXEDFILEINFO.dwFileType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFileType;
    /// <include file='VS_FIXEDFILEINFO.xml' path='doc/member[@name="VS_FIXEDFILEINFO.dwFileSubtype"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFileSubtype;
    /// <include file='VS_FIXEDFILEINFO.xml' path='doc/member[@name="VS_FIXEDFILEINFO.dwFileDateMS"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFileDateMS;
    /// <include file='VS_FIXEDFILEINFO.xml' path='doc/member[@name="VS_FIXEDFILEINFO.dwFileDateLS"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFileDateLS;
}