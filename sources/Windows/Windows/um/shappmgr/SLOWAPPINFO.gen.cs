// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SLOWAPPINFO.xml' path='doc/member[@name="SLOWAPPINFO"]/*'/>
public unsafe partial struct SLOWAPPINFO
{
    /// <include file='SLOWAPPINFO.xml' path='doc/member[@name="SLOWAPPINFO.ullSize"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong ullSize;
    /// <include file='SLOWAPPINFO.xml' path='doc/member[@name="SLOWAPPINFO.ftLastUsed"]/*'/>
    public FILETIME ftLastUsed;
    /// <include file='SLOWAPPINFO.xml' path='doc/member[@name="SLOWAPPINFO.iTimesUsed"]/*'/>
    public int iTimesUsed;
    /// <include file='SLOWAPPINFO.xml' path='doc/member[@name="SLOWAPPINFO.pszImage"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszImage;
}