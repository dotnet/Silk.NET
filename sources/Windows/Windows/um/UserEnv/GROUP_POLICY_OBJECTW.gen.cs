// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UserEnv.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='GROUP_POLICY_OBJECTW.xml' path='doc/member[@name="GROUP_POLICY_OBJECTW"]/*'/>
public unsafe partial struct GROUP_POLICY_OBJECTW
{
    /// <include file='GROUP_POLICY_OBJECTW.xml' path='doc/member[@name="GROUP_POLICY_OBJECTW.dwOptions"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwOptions;
    /// <include file='GROUP_POLICY_OBJECTW.xml' path='doc/member[@name="GROUP_POLICY_OBJECTW.dwVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVersion;
    /// <include file='GROUP_POLICY_OBJECTW.xml' path='doc/member[@name="GROUP_POLICY_OBJECTW.lpDSPath"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpDSPath;
    /// <include file='GROUP_POLICY_OBJECTW.xml' path='doc/member[@name="GROUP_POLICY_OBJECTW.lpFileSysPath"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpFileSysPath;
    /// <include file='GROUP_POLICY_OBJECTW.xml' path='doc/member[@name="GROUP_POLICY_OBJECTW.lpDisplayName"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpDisplayName;
    /// <include file='GROUP_POLICY_OBJECTW.xml' path='doc/member[@name="GROUP_POLICY_OBJECTW.szGPOName"]/*'/>
    [NativeTypeName("WCHAR[50]")]
    public fixed ushort szGPOName[50];
    /// <include file='GROUP_POLICY_OBJECTW.xml' path='doc/member[@name="GROUP_POLICY_OBJECTW.GPOLink"]/*'/>
    public GPO_LINK GPOLink;
    /// <include file='GROUP_POLICY_OBJECTW.xml' path='doc/member[@name="GROUP_POLICY_OBJECTW.lParam"]/*'/>
    public LPARAM lParam;
    /// <include file='GROUP_POLICY_OBJECTW.xml' path='doc/member[@name="GROUP_POLICY_OBJECTW.pNext"]/*'/>
    [NativeTypeName("struct _GROUP_POLICY_OBJECTW *")]
    public GROUP_POLICY_OBJECTW* pNext;
    /// <include file='GROUP_POLICY_OBJECTW.xml' path='doc/member[@name="GROUP_POLICY_OBJECTW.pPrev"]/*'/>
    [NativeTypeName("struct _GROUP_POLICY_OBJECTW *")]
    public GROUP_POLICY_OBJECTW* pPrev;
    /// <include file='GROUP_POLICY_OBJECTW.xml' path='doc/member[@name="GROUP_POLICY_OBJECTW.lpExtensions"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpExtensions;
    /// <include file='GROUP_POLICY_OBJECTW.xml' path='doc/member[@name="GROUP_POLICY_OBJECTW.lParam2"]/*'/>
    public LPARAM lParam2;
    /// <include file='GROUP_POLICY_OBJECTW.xml' path='doc/member[@name="GROUP_POLICY_OBJECTW.lpLink"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpLink;
}