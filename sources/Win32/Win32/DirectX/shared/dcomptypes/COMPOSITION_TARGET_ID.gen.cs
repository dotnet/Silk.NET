// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[SupportedOSPlatform("windows10.0.22000.0")]
public partial struct COMPOSITION_TARGET_ID
{
    public LUID displayAdapterLuid;
    public LUID renderAdapterLuid;
    public uint vidPnSourceId;
    public uint vidPnTargetId;
    public uint uniqueId;
}
