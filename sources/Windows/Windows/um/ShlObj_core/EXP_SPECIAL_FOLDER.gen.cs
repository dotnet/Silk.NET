// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='EXP_SPECIAL_FOLDER.xml' path='doc/member[@name="EXP_SPECIAL_FOLDER"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct EXP_SPECIAL_FOLDER
{
    /// <include file='EXP_SPECIAL_FOLDER.xml' path='doc/member[@name="EXP_SPECIAL_FOLDER.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='EXP_SPECIAL_FOLDER.xml' path='doc/member[@name="EXP_SPECIAL_FOLDER.dwSignature"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSignature;

    /// <include file='EXP_SPECIAL_FOLDER.xml' path='doc/member[@name="EXP_SPECIAL_FOLDER.idSpecialFolder"]/*' />
    [NativeTypeName("DWORD")]
    public uint idSpecialFolder;

    /// <include file='EXP_SPECIAL_FOLDER.xml' path='doc/member[@name="EXP_SPECIAL_FOLDER.cbOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbOffset;
}
