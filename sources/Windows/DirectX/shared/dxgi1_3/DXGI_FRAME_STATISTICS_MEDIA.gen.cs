// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='DXGI_FRAME_STATISTICS_MEDIA.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS_MEDIA"]/*'/>
public partial struct DXGI_FRAME_STATISTICS_MEDIA
{
    /// <include file='DXGI_FRAME_STATISTICS_MEDIA.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS_MEDIA.PresentCount"]/*'/>
    public uint PresentCount;
    /// <include file='DXGI_FRAME_STATISTICS_MEDIA.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS_MEDIA.PresentRefreshCount"]/*'/>
    public uint PresentRefreshCount;
    /// <include file='DXGI_FRAME_STATISTICS_MEDIA.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS_MEDIA.SyncRefreshCount"]/*'/>
    public uint SyncRefreshCount;
    /// <include file='DXGI_FRAME_STATISTICS_MEDIA.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS_MEDIA.SyncQPCTime"]/*'/>
    public LARGE_INTEGER SyncQPCTime;
    /// <include file='DXGI_FRAME_STATISTICS_MEDIA.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS_MEDIA.SyncGPUTime"]/*'/>
    public LARGE_INTEGER SyncGPUTime;
    /// <include file='DXGI_FRAME_STATISTICS_MEDIA.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS_MEDIA.CompositionMode"]/*'/>
    public DXGI_FRAME_PRESENTATION_MODE CompositionMode;
    /// <include file='DXGI_FRAME_STATISTICS_MEDIA.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS_MEDIA.ApprovedPresentDuration"]/*'/>
    public uint ApprovedPresentDuration;
}