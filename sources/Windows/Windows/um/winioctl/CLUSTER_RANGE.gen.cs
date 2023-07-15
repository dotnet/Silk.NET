// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CLUSTER_RANGE.xml' path='doc/member[@name="CLUSTER_RANGE"]/*'/>
public partial struct CLUSTER_RANGE
{
    /// <include file='CLUSTER_RANGE.xml' path='doc/member[@name="CLUSTER_RANGE.StartingCluster"]/*'/>
    public LARGE_INTEGER StartingCluster;
    /// <include file='CLUSTER_RANGE.xml' path='doc/member[@name="CLUSTER_RANGE.ClusterCount"]/*'/>
    public LARGE_INTEGER ClusterCount;
}