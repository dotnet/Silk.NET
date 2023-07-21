// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PROCESS_INFORMATION.xml' path='doc/member[@name="PROCESS_INFORMATION"]/*' />
public partial struct PROCESS_INFORMATION
{
    /// <include file='PROCESS_INFORMATION.xml' path='doc/member[@name="PROCESS_INFORMATION.hProcess"]/*' />
    public HANDLE hProcess;

    /// <include file='PROCESS_INFORMATION.xml' path='doc/member[@name="PROCESS_INFORMATION.hThread"]/*' />
    public HANDLE hThread;

    /// <include file='PROCESS_INFORMATION.xml' path='doc/member[@name="PROCESS_INFORMATION.dwProcessId"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwProcessId;

    /// <include file='PROCESS_INFORMATION.xml' path='doc/member[@name="PROCESS_INFORMATION.dwThreadId"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwThreadId;
}
