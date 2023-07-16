// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DEVICE_DSM_NVCACHE_CHANGE_PRIORITY_PARAMETERS.xml' path='doc/member[@name="DEVICE_DSM_NVCACHE_CHANGE_PRIORITY_PARAMETERS"]/*'/>
public unsafe partial struct DEVICE_DSM_NVCACHE_CHANGE_PRIORITY_PARAMETERS
{
    /// <include file='DEVICE_DSM_NVCACHE_CHANGE_PRIORITY_PARAMETERS.xml' path='doc/member[@name="DEVICE_DSM_NVCACHE_CHANGE_PRIORITY_PARAMETERS.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='DEVICE_DSM_NVCACHE_CHANGE_PRIORITY_PARAMETERS.xml' path='doc/member[@name="DEVICE_DSM_NVCACHE_CHANGE_PRIORITY_PARAMETERS.TargetPriority"]/*'/>
    public byte TargetPriority;
    /// <include file='DEVICE_DSM_NVCACHE_CHANGE_PRIORITY_PARAMETERS.xml' path='doc/member[@name="DEVICE_DSM_NVCACHE_CHANGE_PRIORITY_PARAMETERS.Reserved"]/*'/>
    [NativeTypeName("BYTE[3]")]
    public fixed byte Reserved[3];
}