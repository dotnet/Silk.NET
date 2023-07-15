// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ifdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IF_PHYSICAL_ADDRESS_LH.xml' path='doc/member[@name="IF_PHYSICAL_ADDRESS_LH"]/*'/>
public unsafe partial struct IF_PHYSICAL_ADDRESS_LH
{
    /// <include file='IF_PHYSICAL_ADDRESS_LH.xml' path='doc/member[@name="IF_PHYSICAL_ADDRESS_LH.Length"]/*'/>
    public ushort Length;
    /// <include file='IF_PHYSICAL_ADDRESS_LH.xml' path='doc/member[@name="IF_PHYSICAL_ADDRESS_LH.Address"]/*'/>
    [NativeTypeName("UCHAR[32]")]
    public fixed byte Address[32];
}