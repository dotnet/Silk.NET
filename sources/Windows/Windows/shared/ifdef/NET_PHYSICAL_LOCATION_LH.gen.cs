// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ifdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NET_PHYSICAL_LOCATION_LH.xml' path='doc/member[@name="NET_PHYSICAL_LOCATION_LH"]/*'/>
public partial struct NET_PHYSICAL_LOCATION_LH
{
    /// <include file='NET_PHYSICAL_LOCATION_LH.xml' path='doc/member[@name="NET_PHYSICAL_LOCATION_LH.BusNumber"]/*'/>
    [NativeTypeName("ULONG")]
    public uint BusNumber;
    /// <include file='NET_PHYSICAL_LOCATION_LH.xml' path='doc/member[@name="NET_PHYSICAL_LOCATION_LH.SlotNumber"]/*'/>
    [NativeTypeName("ULONG")]
    public uint SlotNumber;
    /// <include file='NET_PHYSICAL_LOCATION_LH.xml' path='doc/member[@name="NET_PHYSICAL_LOCATION_LH.FunctionNumber"]/*'/>
    [NativeTypeName("ULONG")]
    public uint FunctionNumber;
}