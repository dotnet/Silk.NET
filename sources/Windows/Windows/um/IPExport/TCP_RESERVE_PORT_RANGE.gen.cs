// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TCP_RESERVE_PORT_RANGE.xml' path='doc/member[@name="TCP_RESERVE_PORT_RANGE"]/*'/>
public partial struct TCP_RESERVE_PORT_RANGE
{
    /// <include file='TCP_RESERVE_PORT_RANGE.xml' path='doc/member[@name="TCP_RESERVE_PORT_RANGE.UpperRange"]/*'/>
    public ushort UpperRange;
    /// <include file='TCP_RESERVE_PORT_RANGE.xml' path='doc/member[@name="TCP_RESERVE_PORT_RANGE.LowerRange"]/*'/>
    public ushort LowerRange;
}