// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='ENCRYPTION_BUFFER.xml' path='doc/member[@name="ENCRYPTION_BUFFER"]/*'/>
public unsafe partial struct ENCRYPTION_BUFFER
{
    /// <include file='ENCRYPTION_BUFFER.xml' path='doc/member[@name="ENCRYPTION_BUFFER.EncryptionOperation"]/*'/>
    [NativeTypeName("DWORD")]
    public uint EncryptionOperation;
    /// <include file='ENCRYPTION_BUFFER.xml' path='doc/member[@name="ENCRYPTION_BUFFER.Private"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte Private[1];
}