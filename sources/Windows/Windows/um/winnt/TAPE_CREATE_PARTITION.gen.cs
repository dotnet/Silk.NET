// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TAPE_CREATE_PARTITION.xml' path='doc/member[@name="TAPE_CREATE_PARTITION"]/*'/>
public partial struct TAPE_CREATE_PARTITION
{
    /// <include file='TAPE_CREATE_PARTITION.xml' path='doc/member[@name="TAPE_CREATE_PARTITION.Method"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Method;
    /// <include file='TAPE_CREATE_PARTITION.xml' path='doc/member[@name="TAPE_CREATE_PARTITION.Count"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Count;
    /// <include file='TAPE_CREATE_PARTITION.xml' path='doc/member[@name="TAPE_CREATE_PARTITION.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
}