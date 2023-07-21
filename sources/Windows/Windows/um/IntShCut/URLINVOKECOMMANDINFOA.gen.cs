// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IntShCut.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='URLINVOKECOMMANDINFOA.xml' path='doc/member[@name="URLINVOKECOMMANDINFOA"]/*' />
public unsafe partial struct URLINVOKECOMMANDINFOA
{
    /// <include file='URLINVOKECOMMANDINFOA.xml' path='doc/member[@name="URLINVOKECOMMANDINFOA.dwcbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwcbSize;

    /// <include file='URLINVOKECOMMANDINFOA.xml' path='doc/member[@name="URLINVOKECOMMANDINFOA.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='URLINVOKECOMMANDINFOA.xml' path='doc/member[@name="URLINVOKECOMMANDINFOA.hwndParent"]/*' />
    public HWND hwndParent;

    /// <include file='URLINVOKECOMMANDINFOA.xml' path='doc/member[@name="URLINVOKECOMMANDINFOA.pcszVerb"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* pcszVerb;
}
