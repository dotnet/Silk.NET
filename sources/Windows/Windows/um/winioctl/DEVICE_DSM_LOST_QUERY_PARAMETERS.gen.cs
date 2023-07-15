// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DEVICE_DSM_LOST_QUERY_PARAMETERS.xml' path='doc/member[@name="DEVICE_DSM_LOST_QUERY_PARAMETERS"]/*'/>
public partial struct DEVICE_DSM_LOST_QUERY_PARAMETERS
{
    /// <include file='DEVICE_DSM_LOST_QUERY_PARAMETERS.xml' path='doc/member[@name="DEVICE_DSM_LOST_QUERY_PARAMETERS.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='DEVICE_DSM_LOST_QUERY_PARAMETERS.xml' path='doc/member[@name="DEVICE_DSM_LOST_QUERY_PARAMETERS.Granularity"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong Granularity;
}