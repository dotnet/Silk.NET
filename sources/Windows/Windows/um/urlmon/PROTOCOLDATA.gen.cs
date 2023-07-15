// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='PROTOCOLDATA.xml' path='doc/member[@name="PROTOCOLDATA"]/*'/>
public unsafe partial struct PROTOCOLDATA
{
    /// <include file='PROTOCOLDATA.xml' path='doc/member[@name="PROTOCOLDATA.grfFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint grfFlags;
    /// <include file='PROTOCOLDATA.xml' path='doc/member[@name="PROTOCOLDATA.dwState"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwState;
    /// <include file='PROTOCOLDATA.xml' path='doc/member[@name="PROTOCOLDATA.pData"]/*'/>
    [NativeTypeName("LPVOID")]
    public void* pData;
    /// <include file='PROTOCOLDATA.xml' path='doc/member[@name="PROTOCOLDATA.cbData"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cbData;
}