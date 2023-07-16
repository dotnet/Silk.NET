// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='HW_PROFILE_INFOA.xml' path='doc/member[@name="HW_PROFILE_INFOA"]/*'/>
public unsafe partial struct HW_PROFILE_INFOA
{
    /// <include file='HW_PROFILE_INFOA.xml' path='doc/member[@name="HW_PROFILE_INFOA.dwDockInfo"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDockInfo;
    /// <include file='HW_PROFILE_INFOA.xml' path='doc/member[@name="HW_PROFILE_INFOA.szHwProfileGuid"]/*'/>
    [NativeTypeName("CHAR[39]")]
    public fixed sbyte szHwProfileGuid[39];
    /// <include file='HW_PROFILE_INFOA.xml' path='doc/member[@name="HW_PROFILE_INFOA.szHwProfileName"]/*'/>
    [NativeTypeName("CHAR[80]")]
    public fixed sbyte szHwProfileName[80];
}