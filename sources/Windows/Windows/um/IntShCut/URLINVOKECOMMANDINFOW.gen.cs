// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IntShCut.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='URLINVOKECOMMANDINFOW.xml' path='doc/member[@name="URLINVOKECOMMANDINFOW"]/*' />
public unsafe partial struct URLINVOKECOMMANDINFOW
{
    /// <include file='URLINVOKECOMMANDINFOW.xml' path='doc/member[@name="URLINVOKECOMMANDINFOW.dwcbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwcbSize;

    /// <include file='URLINVOKECOMMANDINFOW.xml' path='doc/member[@name="URLINVOKECOMMANDINFOW.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='URLINVOKECOMMANDINFOW.xml' path='doc/member[@name="URLINVOKECOMMANDINFOW.hwndParent"]/*' />
    public HWND hwndParent;

    /// <include file='URLINVOKECOMMANDINFOW.xml' path='doc/member[@name="URLINVOKECOMMANDINFOW.pcszVerb"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* pcszVerb;
}
