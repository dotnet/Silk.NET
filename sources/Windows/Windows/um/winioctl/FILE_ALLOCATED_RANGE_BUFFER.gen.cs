// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='FILE_ALLOCATED_RANGE_BUFFER.xml' path='doc/member[@name="FILE_ALLOCATED_RANGE_BUFFER"]/*'/>
public partial struct FILE_ALLOCATED_RANGE_BUFFER
{
    /// <include file='FILE_ALLOCATED_RANGE_BUFFER.xml' path='doc/member[@name="FILE_ALLOCATED_RANGE_BUFFER.FileOffset"]/*'/>
    public LARGE_INTEGER FileOffset;
    /// <include file='FILE_ALLOCATED_RANGE_BUFFER.xml' path='doc/member[@name="FILE_ALLOCATED_RANGE_BUFFER.Length"]/*'/>
    public LARGE_INTEGER Length;
}