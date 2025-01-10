// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct APPINFODATA
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("DWORD")]
    public uint dwMask;

    [NativeTypeName("LPWSTR")]
    public ushort* pszDisplayName;

    [NativeTypeName("LPWSTR")]
    public ushort* pszVersion;

    [NativeTypeName("LPWSTR")]
    public ushort* pszPublisher;

    [NativeTypeName("LPWSTR")]
    public ushort* pszProductID;

    [NativeTypeName("LPWSTR")]
    public ushort* pszRegisteredOwner;

    [NativeTypeName("LPWSTR")]
    public ushort* pszRegisteredCompany;

    [NativeTypeName("LPWSTR")]
    public ushort* pszLanguage;

    [NativeTypeName("LPWSTR")]
    public ushort* pszSupportUrl;

    [NativeTypeName("LPWSTR")]
    public ushort* pszSupportTelephone;

    [NativeTypeName("LPWSTR")]
    public ushort* pszHelpLink;

    [NativeTypeName("LPWSTR")]
    public ushort* pszInstallLocation;

    [NativeTypeName("LPWSTR")]
    public ushort* pszInstallSource;

    [NativeTypeName("LPWSTR")]
    public ushort* pszInstallDate;

    [NativeTypeName("LPWSTR")]
    public ushort* pszContact;

    [NativeTypeName("LPWSTR")]
    public ushort* pszComments;

    [NativeTypeName("LPWSTR")]
    public ushort* pszImage;

    [NativeTypeName("LPWSTR")]
    public ushort* pszReadmeUrl;

    [NativeTypeName("LPWSTR")]
    public ushort* pszUpdateInfoUrl;
}
