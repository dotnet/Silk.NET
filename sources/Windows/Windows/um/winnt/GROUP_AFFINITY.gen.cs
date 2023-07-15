// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='GROUP_AFFINITY.xml' path='doc/member[@name="GROUP_AFFINITY"]/*'/>
public unsafe partial struct GROUP_AFFINITY
{
    /// <include file='GROUP_AFFINITY.xml' path='doc/member[@name="GROUP_AFFINITY.Mask"]/*'/>
    [NativeTypeName("KAFFINITY")]
    public nuint Mask;
    /// <include file='GROUP_AFFINITY.xml' path='doc/member[@name="GROUP_AFFINITY.Group"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Group;
    /// <include file='GROUP_AFFINITY.xml' path='doc/member[@name="GROUP_AFFINITY.Reserved"]/*'/>
    [NativeTypeName("WORD[3]")]
    public fixed ushort Reserved[3];
}