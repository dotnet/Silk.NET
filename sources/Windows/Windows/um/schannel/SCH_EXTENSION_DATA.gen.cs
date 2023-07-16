// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SCH_EXTENSION_DATA.xml' path='doc/member[@name="SCH_EXTENSION_DATA"]/*'/>
public unsafe partial struct SCH_EXTENSION_DATA
{
    /// <include file='SCH_EXTENSION_DATA.xml' path='doc/member[@name="SCH_EXTENSION_DATA.ExtensionType"]/*'/>
    [NativeTypeName("WORD")]
    public ushort ExtensionType;
    /// <include file='SCH_EXTENSION_DATA.xml' path='doc/member[@name="SCH_EXTENSION_DATA.pExtData"]/*'/>
    [NativeTypeName("const BYTE *")]
    public byte* pExtData;
    /// <include file='SCH_EXTENSION_DATA.xml' path='doc/member[@name="SCH_EXTENSION_DATA.cbExtData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbExtData;
}