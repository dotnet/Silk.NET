// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ACTCTXA.xml' path='doc/member[@name="ACTCTXA"]/*'/>
public unsafe partial struct ACTCTXA
{
    /// <include file='ACTCTXA.xml' path='doc/member[@name="ACTCTXA.cbSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cbSize;
    /// <include file='ACTCTXA.xml' path='doc/member[@name="ACTCTXA.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='ACTCTXA.xml' path='doc/member[@name="ACTCTXA.lpSource"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* lpSource;
    /// <include file='ACTCTXA.xml' path='doc/member[@name="ACTCTXA.wProcessorArchitecture"]/*'/>
    public ushort wProcessorArchitecture;
    /// <include file='ACTCTXA.xml' path='doc/member[@name="ACTCTXA.wLangId"]/*'/>
    [NativeTypeName("LANGID")]
    public ushort wLangId;
    /// <include file='ACTCTXA.xml' path='doc/member[@name="ACTCTXA.lpAssemblyDirectory"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* lpAssemblyDirectory;
    /// <include file='ACTCTXA.xml' path='doc/member[@name="ACTCTXA.lpResourceName"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* lpResourceName;
    /// <include file='ACTCTXA.xml' path='doc/member[@name="ACTCTXA.lpApplicationName"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* lpApplicationName;
    /// <include file='ACTCTXA.xml' path='doc/member[@name="ACTCTXA.hModule"]/*'/>
    public HMODULE hModule;
}