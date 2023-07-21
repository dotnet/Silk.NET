// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CMINVOKECOMMANDINFO.xml' path='doc/member[@name="CMINVOKECOMMANDINFO"]/*' />
public unsafe partial struct CMINVOKECOMMANDINFO
{
    /// <include file='CMINVOKECOMMANDINFO.xml' path='doc/member[@name="CMINVOKECOMMANDINFO.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='CMINVOKECOMMANDINFO.xml' path='doc/member[@name="CMINVOKECOMMANDINFO.fMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint fMask;

    /// <include file='CMINVOKECOMMANDINFO.xml' path='doc/member[@name="CMINVOKECOMMANDINFO.hwnd"]/*' />
    public HWND hwnd;

    /// <include file='CMINVOKECOMMANDINFO.xml' path='doc/member[@name="CMINVOKECOMMANDINFO.lpVerb"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* lpVerb;

    /// <include file='CMINVOKECOMMANDINFO.xml' path='doc/member[@name="CMINVOKECOMMANDINFO.lpParameters"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* lpParameters;

    /// <include file='CMINVOKECOMMANDINFO.xml' path='doc/member[@name="CMINVOKECOMMANDINFO.lpDirectory"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* lpDirectory;

    /// <include file='CMINVOKECOMMANDINFO.xml' path='doc/member[@name="CMINVOKECOMMANDINFO.nShow"]/*' />
    public int nShow;

    /// <include file='CMINVOKECOMMANDINFO.xml' path='doc/member[@name="CMINVOKECOMMANDINFO.dwHotKey"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwHotKey;

    /// <include file='CMINVOKECOMMANDINFO.xml' path='doc/member[@name="CMINVOKECOMMANDINFO.hIcon"]/*' />
    public HANDLE hIcon;
}
