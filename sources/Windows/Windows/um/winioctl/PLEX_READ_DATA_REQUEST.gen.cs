// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PLEX_READ_DATA_REQUEST.xml' path='doc/member[@name="PLEX_READ_DATA_REQUEST"]/*'/>
public partial struct PLEX_READ_DATA_REQUEST
{
    /// <include file='PLEX_READ_DATA_REQUEST.xml' path='doc/member[@name="PLEX_READ_DATA_REQUEST.ByteOffset"]/*'/>
    public LARGE_INTEGER ByteOffset;
    /// <include file='PLEX_READ_DATA_REQUEST.xml' path='doc/member[@name="PLEX_READ_DATA_REQUEST.ByteLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ByteLength;
    /// <include file='PLEX_READ_DATA_REQUEST.xml' path='doc/member[@name="PLEX_READ_DATA_REQUEST.PlexNumber"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PlexNumber;
}