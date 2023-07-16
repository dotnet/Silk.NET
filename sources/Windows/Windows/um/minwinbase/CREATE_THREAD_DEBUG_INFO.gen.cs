// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CREATE_THREAD_DEBUG_INFO.xml' path='doc/member[@name="CREATE_THREAD_DEBUG_INFO"]/*'/>
public unsafe partial struct CREATE_THREAD_DEBUG_INFO
{
    /// <include file='CREATE_THREAD_DEBUG_INFO.xml' path='doc/member[@name="CREATE_THREAD_DEBUG_INFO.hThread"]/*'/>
    public HANDLE hThread;
    /// <include file='CREATE_THREAD_DEBUG_INFO.xml' path='doc/member[@name="CREATE_THREAD_DEBUG_INFO.lpThreadLocalBase"]/*'/>
    [NativeTypeName("LPVOID")]
    public void* lpThreadLocalBase;
    /// <include file='CREATE_THREAD_DEBUG_INFO.xml' path='doc/member[@name="CREATE_THREAD_DEBUG_INFO.lpStartAddress"]/*'/>
    [NativeTypeName("LPTHREAD_START_ROUTINE")]
    public delegate* unmanaged<void*, uint> lpStartAddress;
}