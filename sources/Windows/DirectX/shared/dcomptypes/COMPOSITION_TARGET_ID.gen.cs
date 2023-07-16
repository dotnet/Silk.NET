// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;

namespace Silk.NET.DirectX;
/// <include file='COMPOSITION_TARGET_ID.xml' path='doc/member[@name="COMPOSITION_TARGET_ID"]/*'/>
public partial struct COMPOSITION_TARGET_ID
{
    /// <include file='COMPOSITION_TARGET_ID.xml' path='doc/member[@name="COMPOSITION_TARGET_ID.displayAdapterLuid"]/*'/>
    public LUID displayAdapterLuid;
    /// <include file='COMPOSITION_TARGET_ID.xml' path='doc/member[@name="COMPOSITION_TARGET_ID.renderAdapterLuid"]/*'/>
    public LUID renderAdapterLuid;
    /// <include file='COMPOSITION_TARGET_ID.xml' path='doc/member[@name="COMPOSITION_TARGET_ID.vidPnSourceId"]/*'/>
    public uint vidPnSourceId;
    /// <include file='COMPOSITION_TARGET_ID.xml' path='doc/member[@name="COMPOSITION_TARGET_ID.vidPnTargetId"]/*'/>
    public uint vidPnTargetId;
    /// <include file='COMPOSITION_TARGET_ID.xml' path='doc/member[@name="COMPOSITION_TARGET_ID.uniqueId"]/*'/>
    public uint uniqueId;
}