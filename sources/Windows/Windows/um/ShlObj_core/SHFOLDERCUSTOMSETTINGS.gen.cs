// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='SHFOLDERCUSTOMSETTINGS.xml' path='doc/member[@name="SHFOLDERCUSTOMSETTINGS"]/*'/>
public unsafe partial struct SHFOLDERCUSTOMSETTINGS
{
    /// <include file='SHFOLDERCUSTOMSETTINGS.xml' path='doc/member[@name="SHFOLDERCUSTOMSETTINGS.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='SHFOLDERCUSTOMSETTINGS.xml' path='doc/member[@name="SHFOLDERCUSTOMSETTINGS.dwMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMask;
    /// <include file='SHFOLDERCUSTOMSETTINGS.xml' path='doc/member[@name="SHFOLDERCUSTOMSETTINGS.pvid"]/*'/>
    [NativeTypeName("SHELLVIEWID *")]
    public Guid* pvid;
    /// <include file='SHFOLDERCUSTOMSETTINGS.xml' path='doc/member[@name="SHFOLDERCUSTOMSETTINGS.pszWebViewTemplate"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszWebViewTemplate;
    /// <include file='SHFOLDERCUSTOMSETTINGS.xml' path='doc/member[@name="SHFOLDERCUSTOMSETTINGS.cchWebViewTemplate"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cchWebViewTemplate;
    /// <include file='SHFOLDERCUSTOMSETTINGS.xml' path='doc/member[@name="SHFOLDERCUSTOMSETTINGS.pszWebViewTemplateVersion"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszWebViewTemplateVersion;
    /// <include file='SHFOLDERCUSTOMSETTINGS.xml' path='doc/member[@name="SHFOLDERCUSTOMSETTINGS.pszInfoTip"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszInfoTip;
    /// <include file='SHFOLDERCUSTOMSETTINGS.xml' path='doc/member[@name="SHFOLDERCUSTOMSETTINGS.cchInfoTip"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cchInfoTip;
    /// <include file='SHFOLDERCUSTOMSETTINGS.xml' path='doc/member[@name="SHFOLDERCUSTOMSETTINGS.pclsid"]/*'/>
    [NativeTypeName("CLSID *")]
    public Guid* pclsid;
    /// <include file='SHFOLDERCUSTOMSETTINGS.xml' path='doc/member[@name="SHFOLDERCUSTOMSETTINGS.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='SHFOLDERCUSTOMSETTINGS.xml' path='doc/member[@name="SHFOLDERCUSTOMSETTINGS.pszIconFile"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszIconFile;
    /// <include file='SHFOLDERCUSTOMSETTINGS.xml' path='doc/member[@name="SHFOLDERCUSTOMSETTINGS.cchIconFile"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cchIconFile;
    /// <include file='SHFOLDERCUSTOMSETTINGS.xml' path='doc/member[@name="SHFOLDERCUSTOMSETTINGS.iIconIndex"]/*'/>
    public int iIconIndex;
    /// <include file='SHFOLDERCUSTOMSETTINGS.xml' path='doc/member[@name="SHFOLDERCUSTOMSETTINGS.pszLogo"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszLogo;
    /// <include file='SHFOLDERCUSTOMSETTINGS.xml' path='doc/member[@name="SHFOLDERCUSTOMSETTINGS.cchLogo"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cchLogo;
}