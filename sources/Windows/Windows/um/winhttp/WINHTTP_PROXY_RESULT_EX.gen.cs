// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WINHTTP_PROXY_RESULT_EX.xml' path='doc/member[@name="WINHTTP_PROXY_RESULT_EX"]/*'/>
public unsafe partial struct WINHTTP_PROXY_RESULT_EX
{
    /// <include file='WINHTTP_PROXY_RESULT_EX.xml' path='doc/member[@name="WINHTTP_PROXY_RESULT_EX.cEntries"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cEntries;
    /// <include file='WINHTTP_PROXY_RESULT_EX.xml' path='doc/member[@name="WINHTTP_PROXY_RESULT_EX.pEntries"]/*'/>
    public WINHTTP_PROXY_RESULT_ENTRY* pEntries;
    /// <include file='WINHTTP_PROXY_RESULT_EX.xml' path='doc/member[@name="WINHTTP_PROXY_RESULT_EX.hProxyDetectionHandle"]/*'/>
    public HANDLE hProxyDetectionHandle;
    /// <include file='WINHTTP_PROXY_RESULT_EX.xml' path='doc/member[@name="WINHTTP_PROXY_RESULT_EX.dwProxyInterfaceAffinity"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwProxyInterfaceAffinity;
}