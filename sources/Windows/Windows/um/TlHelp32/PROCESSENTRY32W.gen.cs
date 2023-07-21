// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/TlHelp32.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PROCESSENTRY32W.xml' path='doc/member[@name="PROCESSENTRY32W"]/*' />
public unsafe partial struct PROCESSENTRY32W
{
    /// <include file='PROCESSENTRY32W.xml' path='doc/member[@name="PROCESSENTRY32W.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='PROCESSENTRY32W.xml' path='doc/member[@name="PROCESSENTRY32W.cntUsage"]/*' />
    [NativeTypeName("DWORD")]
    public uint cntUsage;

    /// <include file='PROCESSENTRY32W.xml' path='doc/member[@name="PROCESSENTRY32W.th32ProcessID"]/*' />
    [NativeTypeName("DWORD")]
    public uint th32ProcessID;

    /// <include file='PROCESSENTRY32W.xml' path='doc/member[@name="PROCESSENTRY32W.th32DefaultHeapID"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint th32DefaultHeapID;

    /// <include file='PROCESSENTRY32W.xml' path='doc/member[@name="PROCESSENTRY32W.th32ModuleID"]/*' />
    [NativeTypeName("DWORD")]
    public uint th32ModuleID;

    /// <include file='PROCESSENTRY32W.xml' path='doc/member[@name="PROCESSENTRY32W.cntThreads"]/*' />
    [NativeTypeName("DWORD")]
    public uint cntThreads;

    /// <include file='PROCESSENTRY32W.xml' path='doc/member[@name="PROCESSENTRY32W.th32ParentProcessID"]/*' />
    [NativeTypeName("DWORD")]
    public uint th32ParentProcessID;

    /// <include file='PROCESSENTRY32W.xml' path='doc/member[@name="PROCESSENTRY32W.pcPriClassBase"]/*' />
    [NativeTypeName("LONG")]
    public int pcPriClassBase;

    /// <include file='PROCESSENTRY32W.xml' path='doc/member[@name="PROCESSENTRY32W.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='PROCESSENTRY32W.xml' path='doc/member[@name="PROCESSENTRY32W.szExeFile"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public fixed ushort szExeFile[260];
}
