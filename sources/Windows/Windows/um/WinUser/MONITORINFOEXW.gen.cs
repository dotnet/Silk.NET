// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MONITORINFOEXW.xml' path='doc/member[@name="MONITORINFOEXW"]/*' />
[NativeTypeName("struct tagMONITORINFOEXW : tagMONITORINFO")]
[NativeInheritance("tagMONITORINFO")]
public unsafe partial struct MONITORINFOEXW
{
    public MONITORINFO Base;

    /// <include file='MONITORINFOEXW.xml' path='doc/member[@name="MONITORINFOEXW.szDevice"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public fixed ushort szDevice[32];
}
