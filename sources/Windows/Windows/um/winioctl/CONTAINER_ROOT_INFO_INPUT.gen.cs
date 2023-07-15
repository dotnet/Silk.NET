// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CONTAINER_ROOT_INFO_INPUT.xml' path='doc/member[@name="CONTAINER_ROOT_INFO_INPUT"]/*'/>
public partial struct CONTAINER_ROOT_INFO_INPUT
{
    /// <include file='CONTAINER_ROOT_INFO_INPUT.xml' path='doc/member[@name="CONTAINER_ROOT_INFO_INPUT.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
}