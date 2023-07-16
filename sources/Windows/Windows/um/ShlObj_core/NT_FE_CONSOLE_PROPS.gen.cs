// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='NT_FE_CONSOLE_PROPS.xml' path='doc/member[@name="NT_FE_CONSOLE_PROPS"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct NT_FE_CONSOLE_PROPS
{
    /// <include file='NT_FE_CONSOLE_PROPS.xml' path='doc/member[@name="NT_FE_CONSOLE_PROPS.dbh"]/*'/>
    public DATABLOCK_HEADER dbh;
    /// <include file='NT_FE_CONSOLE_PROPS.xml' path='doc/member[@name="NT_FE_CONSOLE_PROPS.uCodePage"]/*'/>
    public uint uCodePage;
}