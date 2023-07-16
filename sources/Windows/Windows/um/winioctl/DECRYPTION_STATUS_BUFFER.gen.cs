// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DECRYPTION_STATUS_BUFFER.xml' path='doc/member[@name="DECRYPTION_STATUS_BUFFER"]/*'/>
public partial struct DECRYPTION_STATUS_BUFFER
{
    /// <include file='DECRYPTION_STATUS_BUFFER.xml' path='doc/member[@name="DECRYPTION_STATUS_BUFFER.NoEncryptedStreams"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte NoEncryptedStreams;
}