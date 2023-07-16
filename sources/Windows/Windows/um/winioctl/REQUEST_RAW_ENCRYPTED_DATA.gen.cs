// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='REQUEST_RAW_ENCRYPTED_DATA.xml' path='doc/member[@name="REQUEST_RAW_ENCRYPTED_DATA"]/*'/>
public partial struct REQUEST_RAW_ENCRYPTED_DATA
{
    /// <include file='REQUEST_RAW_ENCRYPTED_DATA.xml' path='doc/member[@name="REQUEST_RAW_ENCRYPTED_DATA.FileOffset"]/*'/>
    [NativeTypeName("LONGLONG")]
    public long FileOffset;
    /// <include file='REQUEST_RAW_ENCRYPTED_DATA.xml' path='doc/member[@name="REQUEST_RAW_ENCRYPTED_DATA.Length"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Length;
}