// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ACTCTXW.xml' path='doc/member[@name="ACTCTXW"]/*'/>
public unsafe partial struct ACTCTXW
{
    /// <include file='ACTCTXW.xml' path='doc/member[@name="ACTCTXW.cbSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cbSize;
    /// <include file='ACTCTXW.xml' path='doc/member[@name="ACTCTXW.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='ACTCTXW.xml' path='doc/member[@name="ACTCTXW.lpSource"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* lpSource;
    /// <include file='ACTCTXW.xml' path='doc/member[@name="ACTCTXW.wProcessorArchitecture"]/*'/>
    public ushort wProcessorArchitecture;
    /// <include file='ACTCTXW.xml' path='doc/member[@name="ACTCTXW.wLangId"]/*'/>
    [NativeTypeName("LANGID")]
    public ushort wLangId;
    /// <include file='ACTCTXW.xml' path='doc/member[@name="ACTCTXW.lpAssemblyDirectory"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* lpAssemblyDirectory;
    /// <include file='ACTCTXW.xml' path='doc/member[@name="ACTCTXW.lpResourceName"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* lpResourceName;
    /// <include file='ACTCTXW.xml' path='doc/member[@name="ACTCTXW.lpApplicationName"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* lpApplicationName;
    /// <include file='ACTCTXW.xml' path='doc/member[@name="ACTCTXW.hModule"]/*'/>
    public HMODULE hModule;
}