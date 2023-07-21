// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA"]/*' />
public unsafe partial struct APPINFODATA
{
    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.dwMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMask;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszDisplayName"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszDisplayName;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszVersion"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszVersion;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszPublisher"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszPublisher;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszProductID"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszProductID;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszRegisteredOwner"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszRegisteredOwner;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszRegisteredCompany"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszRegisteredCompany;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszLanguage"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszLanguage;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszSupportUrl"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszSupportUrl;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszSupportTelephone"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszSupportTelephone;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszHelpLink"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszHelpLink;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszInstallLocation"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszInstallLocation;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszInstallSource"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszInstallSource;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszInstallDate"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszInstallDate;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszContact"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszContact;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszComments"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszComments;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszImage"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszImage;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszReadmeUrl"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszReadmeUrl;

    /// <include file='APPINFODATA.xml' path='doc/member[@name="APPINFODATA.pszUpdateInfoUrl"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszUpdateInfoUrl;
}
