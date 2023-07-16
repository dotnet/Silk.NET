// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='REASSIGN_BLOCKS.xml' path='doc/member[@name="REASSIGN_BLOCKS"]/*'/>
public unsafe partial struct REASSIGN_BLOCKS
{
    /// <include file='REASSIGN_BLOCKS.xml' path='doc/member[@name="REASSIGN_BLOCKS.Reserved"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Reserved;
    /// <include file='REASSIGN_BLOCKS.xml' path='doc/member[@name="REASSIGN_BLOCKS.Count"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Count;
    /// <include file='REASSIGN_BLOCKS.xml' path='doc/member[@name="REASSIGN_BLOCKS.BlockNumber"]/*'/>
    [NativeTypeName("DWORD[1]")]
    public fixed uint BlockNumber[1];
}