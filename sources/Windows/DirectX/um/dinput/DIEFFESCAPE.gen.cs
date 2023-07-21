// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DIEFFESCAPE.xml' path='doc/member[@name="DIEFFESCAPE"]/*' />
public unsafe partial struct DIEFFESCAPE
{
    /// <include file='DIEFFESCAPE.xml' path='doc/member[@name="DIEFFESCAPE.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='DIEFFESCAPE.xml' path='doc/member[@name="DIEFFESCAPE.dwCommand"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCommand;

    /// <include file='DIEFFESCAPE.xml' path='doc/member[@name="DIEFFESCAPE.lpvInBuffer"]/*' />
    [NativeTypeName("LPVOID")]
    public void* lpvInBuffer;

    /// <include file='DIEFFESCAPE.xml' path='doc/member[@name="DIEFFESCAPE.cbInBuffer"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbInBuffer;

    /// <include file='DIEFFESCAPE.xml' path='doc/member[@name="DIEFFESCAPE.lpvOutBuffer"]/*' />
    [NativeTypeName("LPVOID")]
    public void* lpvOutBuffer;

    /// <include file='DIEFFESCAPE.xml' path='doc/member[@name="DIEFFESCAPE.cbOutBuffer"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbOutBuffer;
}
