// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WIM_PROVIDER_UPDATE_OVERLAY_INPUT.xml' path='doc/member[@name="WIM_PROVIDER_UPDATE_OVERLAY_INPUT"]/*'/>
public partial struct WIM_PROVIDER_UPDATE_OVERLAY_INPUT
{
    /// <include file='WIM_PROVIDER_UPDATE_OVERLAY_INPUT.xml' path='doc/member[@name="WIM_PROVIDER_UPDATE_OVERLAY_INPUT.DataSourceId"]/*'/>
    public LARGE_INTEGER DataSourceId;
    /// <include file='WIM_PROVIDER_UPDATE_OVERLAY_INPUT.xml' path='doc/member[@name="WIM_PROVIDER_UPDATE_OVERLAY_INPUT.WimFileNameOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint WimFileNameOffset;
    /// <include file='WIM_PROVIDER_UPDATE_OVERLAY_INPUT.xml' path='doc/member[@name="WIM_PROVIDER_UPDATE_OVERLAY_INPUT.WimFileNameLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint WimFileNameLength;
}