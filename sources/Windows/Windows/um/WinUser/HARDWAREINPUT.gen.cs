// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='HARDWAREINPUT.xml' path='doc/member[@name="HARDWAREINPUT"]/*' />
public partial struct HARDWAREINPUT
{
    /// <include file='HARDWAREINPUT.xml' path='doc/member[@name="HARDWAREINPUT.uMsg"]/*' />
    [NativeTypeName("DWORD")]
    public uint uMsg;

    /// <include file='HARDWAREINPUT.xml' path='doc/member[@name="HARDWAREINPUT.wParamL"]/*' />
    [NativeTypeName("WORD")]
    public ushort wParamL;

    /// <include file='HARDWAREINPUT.xml' path='doc/member[@name="HARDWAREINPUT.wParamH"]/*' />
    [NativeTypeName("WORD")]
    public ushort wParamH;
}
