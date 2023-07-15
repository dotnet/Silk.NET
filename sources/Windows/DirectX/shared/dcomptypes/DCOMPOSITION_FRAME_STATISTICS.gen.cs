// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='DCOMPOSITION_FRAME_STATISTICS.xml' path='doc/member[@name="DCOMPOSITION_FRAME_STATISTICS"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct DCOMPOSITION_FRAME_STATISTICS
{
    /// <include file='DCOMPOSITION_FRAME_STATISTICS.xml' path='doc/member[@name="DCOMPOSITION_FRAME_STATISTICS.lastFrameTime"]/*'/>
    public LARGE_INTEGER lastFrameTime;
    /// <include file='DCOMPOSITION_FRAME_STATISTICS.xml' path='doc/member[@name="DCOMPOSITION_FRAME_STATISTICS.currentCompositionRate"]/*'/>
    public DXGI_RATIONAL currentCompositionRate;
    /// <include file='DCOMPOSITION_FRAME_STATISTICS.xml' path='doc/member[@name="DCOMPOSITION_FRAME_STATISTICS.currentTime"]/*'/>
    public LARGE_INTEGER currentTime;
    /// <include file='DCOMPOSITION_FRAME_STATISTICS.xml' path='doc/member[@name="DCOMPOSITION_FRAME_STATISTICS.timeFrequency"]/*'/>
    public LARGE_INTEGER timeFrequency;
    /// <include file='DCOMPOSITION_FRAME_STATISTICS.xml' path='doc/member[@name="DCOMPOSITION_FRAME_STATISTICS.nextEstimatedFrameTime"]/*'/>
    public LARGE_INTEGER nextEstimatedFrameTime;
}