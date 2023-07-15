// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='JIT_DEBUG_INFO.xml' path='doc/member[@name="JIT_DEBUG_INFO"]/*'/>
public partial struct JIT_DEBUG_INFO
{
    /// <include file='JIT_DEBUG_INFO.xml' path='doc/member[@name="JIT_DEBUG_INFO.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='JIT_DEBUG_INFO.xml' path='doc/member[@name="JIT_DEBUG_INFO.dwProcessorArchitecture"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwProcessorArchitecture;
    /// <include file='JIT_DEBUG_INFO.xml' path='doc/member[@name="JIT_DEBUG_INFO.dwThreadID"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwThreadID;
    /// <include file='JIT_DEBUG_INFO.xml' path='doc/member[@name="JIT_DEBUG_INFO.dwReserved0"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved0;
    /// <include file='JIT_DEBUG_INFO.xml' path='doc/member[@name="JIT_DEBUG_INFO.lpExceptionAddress"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong lpExceptionAddress;
    /// <include file='JIT_DEBUG_INFO.xml' path='doc/member[@name="JIT_DEBUG_INFO.lpExceptionRecord"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong lpExceptionRecord;
    /// <include file='JIT_DEBUG_INFO.xml' path='doc/member[@name="JIT_DEBUG_INFO.lpContextRecord"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong lpContextRecord;
}