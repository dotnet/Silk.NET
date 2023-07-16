// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MSV1_0_SUPPLEMENTAL_CREDENTIAL.xml' path='doc/member[@name="MSV1_0_SUPPLEMENTAL_CREDENTIAL"]/*'/>
public unsafe partial struct MSV1_0_SUPPLEMENTAL_CREDENTIAL
{
    /// <include file='MSV1_0_SUPPLEMENTAL_CREDENTIAL.xml' path='doc/member[@name="MSV1_0_SUPPLEMENTAL_CREDENTIAL.Version"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Version;
    /// <include file='MSV1_0_SUPPLEMENTAL_CREDENTIAL.xml' path='doc/member[@name="MSV1_0_SUPPLEMENTAL_CREDENTIAL.Flags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Flags;
    /// <include file='MSV1_0_SUPPLEMENTAL_CREDENTIAL.xml' path='doc/member[@name="MSV1_0_SUPPLEMENTAL_CREDENTIAL.LmPassword"]/*'/>
    [NativeTypeName("UCHAR[16]")]
    public fixed byte LmPassword[16];
    /// <include file='MSV1_0_SUPPLEMENTAL_CREDENTIAL.xml' path='doc/member[@name="MSV1_0_SUPPLEMENTAL_CREDENTIAL.NtPassword"]/*'/>
    [NativeTypeName("UCHAR[16]")]
    public fixed byte NtPassword[16];
}