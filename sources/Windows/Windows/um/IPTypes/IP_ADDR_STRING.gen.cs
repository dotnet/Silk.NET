// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IP_ADDR_STRING.xml' path='doc/member[@name="IP_ADDR_STRING"]/*'/>
public unsafe partial struct IP_ADDR_STRING
{
    /// <include file='IP_ADDR_STRING.xml' path='doc/member[@name="IP_ADDR_STRING.Next"]/*'/>
    [NativeTypeName("struct _IP_ADDR_STRING *")]
    public IP_ADDR_STRING* Next;
    /// <include file='IP_ADDR_STRING.xml' path='doc/member[@name="IP_ADDR_STRING.IpAddress"]/*'/>
    [NativeTypeName("IP_ADDRESS_STRING")]
    public IP_MASK_STRING IpAddress;
    /// <include file='IP_ADDR_STRING.xml' path='doc/member[@name="IP_ADDR_STRING.IpMask"]/*'/>
    public IP_MASK_STRING IpMask;
    /// <include file='IP_ADDR_STRING.xml' path='doc/member[@name="IP_ADDR_STRING.Context"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Context;
}