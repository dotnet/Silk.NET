// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='REPAIR_COPIES_INPUT.xml' path='doc/member[@name="REPAIR_COPIES_INPUT"]/*'/>
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct REPAIR_COPIES_INPUT
{
    /// <include file='REPAIR_COPIES_INPUT.xml' path='doc/member[@name="REPAIR_COPIES_INPUT.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='REPAIR_COPIES_INPUT.xml' path='doc/member[@name="REPAIR_COPIES_INPUT.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='REPAIR_COPIES_INPUT.xml' path='doc/member[@name="REPAIR_COPIES_INPUT.FileOffset"]/*'/>
    public LARGE_INTEGER FileOffset;
    /// <include file='REPAIR_COPIES_INPUT.xml' path='doc/member[@name="REPAIR_COPIES_INPUT.Length"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Length;
    /// <include file='REPAIR_COPIES_INPUT.xml' path='doc/member[@name="REPAIR_COPIES_INPUT.SourceCopy"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SourceCopy;
    /// <include file='REPAIR_COPIES_INPUT.xml' path='doc/member[@name="REPAIR_COPIES_INPUT.NumberOfRepairCopies"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfRepairCopies;
    /// <include file='REPAIR_COPIES_INPUT.xml' path='doc/member[@name="REPAIR_COPIES_INPUT.RepairCopies"]/*'/>
    [NativeTypeName("DWORD[1]")]
    public fixed uint RepairCopies[1];
}