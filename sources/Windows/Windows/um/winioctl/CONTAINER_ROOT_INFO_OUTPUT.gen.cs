// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CONTAINER_ROOT_INFO_OUTPUT.xml' path='doc/member[@name="CONTAINER_ROOT_INFO_OUTPUT"]/*' />
public unsafe partial struct CONTAINER_ROOT_INFO_OUTPUT
{
    /// <include file='CONTAINER_ROOT_INFO_OUTPUT.xml' path='doc/member[@name="CONTAINER_ROOT_INFO_OUTPUT.ContainerRootIdLength"]/*' />
    [NativeTypeName("WORD")]
    public ushort ContainerRootIdLength;

    /// <include file='CONTAINER_ROOT_INFO_OUTPUT.xml' path='doc/member[@name="CONTAINER_ROOT_INFO_OUTPUT.ContainerRootId"]/*' />
    [NativeTypeName("BYTE[1]")]
    public fixed byte ContainerRootId[1];
}
