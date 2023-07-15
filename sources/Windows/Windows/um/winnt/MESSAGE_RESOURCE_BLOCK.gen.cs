// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MESSAGE_RESOURCE_BLOCK.xml' path='doc/member[@name="MESSAGE_RESOURCE_BLOCK"]/*'/>
public partial struct MESSAGE_RESOURCE_BLOCK
{
    /// <include file='MESSAGE_RESOURCE_BLOCK.xml' path='doc/member[@name="MESSAGE_RESOURCE_BLOCK.LowId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint LowId;
    /// <include file='MESSAGE_RESOURCE_BLOCK.xml' path='doc/member[@name="MESSAGE_RESOURCE_BLOCK.HighId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint HighId;
    /// <include file='MESSAGE_RESOURCE_BLOCK.xml' path='doc/member[@name="MESSAGE_RESOURCE_BLOCK.OffsetToEntries"]/*'/>
    [NativeTypeName("DWORD")]
    public uint OffsetToEntries;
}