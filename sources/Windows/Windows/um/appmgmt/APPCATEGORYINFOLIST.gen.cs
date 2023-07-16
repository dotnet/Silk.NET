// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/appmgmt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='APPCATEGORYINFOLIST.xml' path='doc/member[@name="APPCATEGORYINFOLIST"]/*'/>
public unsafe partial struct APPCATEGORYINFOLIST
{
    /// <include file='APPCATEGORYINFOLIST.xml' path='doc/member[@name="APPCATEGORYINFOLIST.cCategory"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cCategory;
    /// <include file='APPCATEGORYINFOLIST.xml' path='doc/member[@name="APPCATEGORYINFOLIST.pCategoryInfo"]/*'/>
    public APPCATEGORYINFO* pCategoryInfo;
}