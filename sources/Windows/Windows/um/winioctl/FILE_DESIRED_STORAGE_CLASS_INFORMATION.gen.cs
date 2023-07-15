// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='FILE_DESIRED_STORAGE_CLASS_INFORMATION.xml' path='doc/member[@name="FILE_DESIRED_STORAGE_CLASS_INFORMATION"]/*'/>
public partial struct FILE_DESIRED_STORAGE_CLASS_INFORMATION
{
    /// <include file='FILE_DESIRED_STORAGE_CLASS_INFORMATION.xml' path='doc/member[@name="FILE_DESIRED_STORAGE_CLASS_INFORMATION.Class"]/*'/>
    public FILE_STORAGE_TIER_CLASS Class;
    /// <include file='FILE_DESIRED_STORAGE_CLASS_INFORMATION.xml' path='doc/member[@name="FILE_DESIRED_STORAGE_CLASS_INFORMATION.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
}