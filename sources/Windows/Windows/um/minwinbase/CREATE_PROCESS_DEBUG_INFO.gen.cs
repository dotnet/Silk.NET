// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CREATE_PROCESS_DEBUG_INFO.xml' path='doc/member[@name="CREATE_PROCESS_DEBUG_INFO"]/*'/>
public unsafe partial struct CREATE_PROCESS_DEBUG_INFO
{
    /// <include file='CREATE_PROCESS_DEBUG_INFO.xml' path='doc/member[@name="CREATE_PROCESS_DEBUG_INFO.hFile"]/*'/>
    public HANDLE hFile;
    /// <include file='CREATE_PROCESS_DEBUG_INFO.xml' path='doc/member[@name="CREATE_PROCESS_DEBUG_INFO.hProcess"]/*'/>
    public HANDLE hProcess;
    /// <include file='CREATE_PROCESS_DEBUG_INFO.xml' path='doc/member[@name="CREATE_PROCESS_DEBUG_INFO.hThread"]/*'/>
    public HANDLE hThread;
    /// <include file='CREATE_PROCESS_DEBUG_INFO.xml' path='doc/member[@name="CREATE_PROCESS_DEBUG_INFO.lpBaseOfImage"]/*'/>
    [NativeTypeName("LPVOID")]
    public void* lpBaseOfImage;
    /// <include file='CREATE_PROCESS_DEBUG_INFO.xml' path='doc/member[@name="CREATE_PROCESS_DEBUG_INFO.dwDebugInfoFileOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDebugInfoFileOffset;
    /// <include file='CREATE_PROCESS_DEBUG_INFO.xml' path='doc/member[@name="CREATE_PROCESS_DEBUG_INFO.nDebugInfoSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nDebugInfoSize;
    /// <include file='CREATE_PROCESS_DEBUG_INFO.xml' path='doc/member[@name="CREATE_PROCESS_DEBUG_INFO.lpThreadLocalBase"]/*'/>
    [NativeTypeName("LPVOID")]
    public void* lpThreadLocalBase;
    /// <include file='CREATE_PROCESS_DEBUG_INFO.xml' path='doc/member[@name="CREATE_PROCESS_DEBUG_INFO.lpStartAddress"]/*'/>
    [NativeTypeName("LPTHREAD_START_ROUTINE")]
    public delegate* unmanaged<void*, uint> lpStartAddress;
    /// <include file='CREATE_PROCESS_DEBUG_INFO.xml' path='doc/member[@name="CREATE_PROCESS_DEBUG_INFO.lpImageName"]/*'/>
    [NativeTypeName("LPVOID")]
    public void* lpImageName;
    /// <include file='CREATE_PROCESS_DEBUG_INFO.xml' path='doc/member[@name="CREATE_PROCESS_DEBUG_INFO.fUnicode"]/*'/>
    [NativeTypeName("WORD")]
    public ushort fUnicode;
}