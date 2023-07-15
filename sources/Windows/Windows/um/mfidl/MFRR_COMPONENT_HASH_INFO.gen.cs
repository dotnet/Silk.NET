// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MFRR_COMPONENT_HASH_INFO.xml' path='doc/member[@name="MFRR_COMPONENT_HASH_INFO"]/*'/>
public unsafe partial struct MFRR_COMPONENT_HASH_INFO
{
    /// <include file='MFRR_COMPONENT_HASH_INFO.xml' path='doc/member[@name="MFRR_COMPONENT_HASH_INFO.ulReason"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ulReason;
    /// <include file='MFRR_COMPONENT_HASH_INFO.xml' path='doc/member[@name="MFRR_COMPONENT_HASH_INFO.rgHeaderHash"]/*'/>
    [NativeTypeName("WCHAR[43]")]
    public fixed ushort rgHeaderHash[43];
    /// <include file='MFRR_COMPONENT_HASH_INFO.xml' path='doc/member[@name="MFRR_COMPONENT_HASH_INFO.rgPublicKeyHash"]/*'/>
    [NativeTypeName("WCHAR[43]")]
    public fixed ushort rgPublicKeyHash[43];
    /// <include file='MFRR_COMPONENT_HASH_INFO.xml' path='doc/member[@name="MFRR_COMPONENT_HASH_INFO.wszName"]/*'/>
    [NativeTypeName("WCHAR[260]")]
    public fixed ushort wszName[260];
}