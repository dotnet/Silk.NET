// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='JOBOBJECT_IO_ATTRIBUTION_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_IO_ATTRIBUTION_INFORMATION"]/*'/>
public partial struct JOBOBJECT_IO_ATTRIBUTION_INFORMATION
{
    /// <include file='JOBOBJECT_IO_ATTRIBUTION_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_IO_ATTRIBUTION_INFORMATION.ControlFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ControlFlags;
    /// <include file='JOBOBJECT_IO_ATTRIBUTION_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_IO_ATTRIBUTION_INFORMATION.ReadStats"]/*'/>
    public JOBOBJECT_IO_ATTRIBUTION_STATS ReadStats;
    /// <include file='JOBOBJECT_IO_ATTRIBUTION_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_IO_ATTRIBUTION_INFORMATION.WriteStats"]/*'/>
    public JOBOBJECT_IO_ATTRIBUTION_STATS WriteStats;
}