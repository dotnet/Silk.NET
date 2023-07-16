// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CONTAINER_VOLUME_STATE.xml' path='doc/member[@name="CONTAINER_VOLUME_STATE"]/*'/>
public partial struct CONTAINER_VOLUME_STATE
{
    /// <include file='CONTAINER_VOLUME_STATE.xml' path='doc/member[@name="CONTAINER_VOLUME_STATE.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
}