// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='EXTENDED_ENCRYPTED_DATA_INFO.xml' path='doc/member[@name="EXTENDED_ENCRYPTED_DATA_INFO"]/*'/>
public partial struct EXTENDED_ENCRYPTED_DATA_INFO
{
    /// <include file='EXTENDED_ENCRYPTED_DATA_INFO.xml' path='doc/member[@name="EXTENDED_ENCRYPTED_DATA_INFO.ExtendedCode"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ExtendedCode;
    /// <include file='EXTENDED_ENCRYPTED_DATA_INFO.xml' path='doc/member[@name="EXTENDED_ENCRYPTED_DATA_INFO.Length"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Length;
    /// <include file='EXTENDED_ENCRYPTED_DATA_INFO.xml' path='doc/member[@name="EXTENDED_ENCRYPTED_DATA_INFO.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='EXTENDED_ENCRYPTED_DATA_INFO.xml' path='doc/member[@name="EXTENDED_ENCRYPTED_DATA_INFO.Reserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Reserved;
}