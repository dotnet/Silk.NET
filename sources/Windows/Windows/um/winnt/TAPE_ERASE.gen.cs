// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TAPE_ERASE.xml' path='doc/member[@name="TAPE_ERASE"]/*'/>
public partial struct TAPE_ERASE
{
    /// <include file='TAPE_ERASE.xml' path='doc/member[@name="TAPE_ERASE.Type"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Type;
    /// <include file='TAPE_ERASE.xml' path='doc/member[@name="TAPE_ERASE.Immediate"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte Immediate;
}