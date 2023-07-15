// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D10_QUERY_DATA_TIMESTAMP_DISJOINT.xml' path='doc/member[@name="D3D10_QUERY_DATA_TIMESTAMP_DISJOINT"]/*'/>
public partial struct D3D10_QUERY_DATA_TIMESTAMP_DISJOINT
{
    /// <include file='D3D10_QUERY_DATA_TIMESTAMP_DISJOINT.xml' path='doc/member[@name="D3D10_QUERY_DATA_TIMESTAMP_DISJOINT.Frequency"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong Frequency;
    /// <include file='D3D10_QUERY_DATA_TIMESTAMP_DISJOINT.xml' path='doc/member[@name="D3D10_QUERY_DATA_TIMESTAMP_DISJOINT.Disjoint"]/*'/>
    public BOOL Disjoint;
}