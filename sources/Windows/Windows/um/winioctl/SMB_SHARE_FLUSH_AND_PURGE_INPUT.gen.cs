// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SMB_SHARE_FLUSH_AND_PURGE_INPUT.xml' path='doc/member[@name="SMB_SHARE_FLUSH_AND_PURGE_INPUT"]/*'/>
public partial struct SMB_SHARE_FLUSH_AND_PURGE_INPUT
{
    /// <include file='SMB_SHARE_FLUSH_AND_PURGE_INPUT.xml' path='doc/member[@name="SMB_SHARE_FLUSH_AND_PURGE_INPUT.Version"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Version;
}