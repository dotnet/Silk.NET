// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='LOAD_DLL_DEBUG_INFO.xml' path='doc/member[@name="LOAD_DLL_DEBUG_INFO"]/*' />
public unsafe partial struct LOAD_DLL_DEBUG_INFO
{
    /// <include file='LOAD_DLL_DEBUG_INFO.xml' path='doc/member[@name="LOAD_DLL_DEBUG_INFO.hFile"]/*' />
    public HANDLE hFile;

    /// <include file='LOAD_DLL_DEBUG_INFO.xml' path='doc/member[@name="LOAD_DLL_DEBUG_INFO.lpBaseOfDll"]/*' />
    [NativeTypeName("LPVOID")]
    public void* lpBaseOfDll;

    /// <include file='LOAD_DLL_DEBUG_INFO.xml' path='doc/member[@name="LOAD_DLL_DEBUG_INFO.dwDebugInfoFileOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDebugInfoFileOffset;

    /// <include file='LOAD_DLL_DEBUG_INFO.xml' path='doc/member[@name="LOAD_DLL_DEBUG_INFO.nDebugInfoSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint nDebugInfoSize;

    /// <include file='LOAD_DLL_DEBUG_INFO.xml' path='doc/member[@name="LOAD_DLL_DEBUG_INFO.lpImageName"]/*' />
    [NativeTypeName("LPVOID")]
    public void* lpImageName;

    /// <include file='LOAD_DLL_DEBUG_INFO.xml' path='doc/member[@name="LOAD_DLL_DEBUG_INFO.fUnicode"]/*' />
    [NativeTypeName("WORD")]
    public ushort fUnicode;
}
