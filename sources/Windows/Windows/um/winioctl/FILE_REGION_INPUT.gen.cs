// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='FILE_REGION_INPUT.xml' path='doc/member[@name="FILE_REGION_INPUT"]/*'/>
public partial struct FILE_REGION_INPUT
{
    /// <include file='FILE_REGION_INPUT.xml' path='doc/member[@name="FILE_REGION_INPUT.FileOffset"]/*'/>
    [NativeTypeName("LONGLONG")]
    public long FileOffset;
    /// <include file='FILE_REGION_INPUT.xml' path='doc/member[@name="FILE_REGION_INPUT.Length"]/*'/>
    [NativeTypeName("LONGLONG")]
    public long Length;
    /// <include file='FILE_REGION_INPUT.xml' path='doc/member[@name="FILE_REGION_INPUT.DesiredUsage"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DesiredUsage;
}