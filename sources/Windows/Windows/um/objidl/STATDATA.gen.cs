// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STATDATA.xml' path='doc/member[@name="STATDATA"]/*'/>
public unsafe partial struct STATDATA
{
    /// <include file='STATDATA.xml' path='doc/member[@name="STATDATA.formatetc"]/*'/>
    public FORMATETC formatetc;
    /// <include file='STATDATA.xml' path='doc/member[@name="STATDATA.advf"]/*'/>
    [NativeTypeName("DWORD")]
    public uint advf;
    /// <include file='STATDATA.xml' path='doc/member[@name="STATDATA.pAdvSink"]/*'/>
    public IAdviseSink* pAdvSink;
    /// <include file='STATDATA.xml' path='doc/member[@name="STATDATA.dwConnection"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwConnection;
}