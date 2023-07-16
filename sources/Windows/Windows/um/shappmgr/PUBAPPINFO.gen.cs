// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PUBAPPINFO.xml' path='doc/member[@name="PUBAPPINFO"]/*'/>
public unsafe partial struct PUBAPPINFO
{
    /// <include file='PUBAPPINFO.xml' path='doc/member[@name="PUBAPPINFO.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='PUBAPPINFO.xml' path='doc/member[@name="PUBAPPINFO.dwMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMask;
    /// <include file='PUBAPPINFO.xml' path='doc/member[@name="PUBAPPINFO.pszSource"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszSource;
    /// <include file='PUBAPPINFO.xml' path='doc/member[@name="PUBAPPINFO.stAssigned"]/*'/>
    public SYSTEMTIME stAssigned;
    /// <include file='PUBAPPINFO.xml' path='doc/member[@name="PUBAPPINFO.stPublished"]/*'/>
    public SYSTEMTIME stPublished;
    /// <include file='PUBAPPINFO.xml' path='doc/member[@name="PUBAPPINFO.stScheduled"]/*'/>
    public SYSTEMTIME stScheduled;
    /// <include file='PUBAPPINFO.xml' path='doc/member[@name="PUBAPPINFO.stExpire"]/*'/>
    public SYSTEMTIME stExpire;
}