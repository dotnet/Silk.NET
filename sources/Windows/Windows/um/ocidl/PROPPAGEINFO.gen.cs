// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PROPPAGEINFO.xml' path='doc/member[@name="PROPPAGEINFO"]/*'/>
public unsafe partial struct PROPPAGEINFO
{
    /// <include file='PROPPAGEINFO.xml' path='doc/member[@name="PROPPAGEINFO.cb"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cb;
    /// <include file='PROPPAGEINFO.xml' path='doc/member[@name="PROPPAGEINFO.pszTitle"]/*'/>
    [NativeTypeName("LPOLESTR")]
    public ushort* pszTitle;
    /// <include file='PROPPAGEINFO.xml' path='doc/member[@name="PROPPAGEINFO.size"]/*'/>
    public SIZE size;
    /// <include file='PROPPAGEINFO.xml' path='doc/member[@name="PROPPAGEINFO.pszDocString"]/*'/>
    [NativeTypeName("LPOLESTR")]
    public ushort* pszDocString;
    /// <include file='PROPPAGEINFO.xml' path='doc/member[@name="PROPPAGEINFO.pszHelpFile"]/*'/>
    [NativeTypeName("LPOLESTR")]
    public ushort* pszHelpFile;
    /// <include file='PROPPAGEINFO.xml' path='doc/member[@name="PROPPAGEINFO.dwHelpContext"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwHelpContext;
}