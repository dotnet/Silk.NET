// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxgidebug.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[SupportedOSPlatform("windows6.2")]
public partial struct DXGI_INFO_QUEUE_FILTER
{
    public DXGI_INFO_QUEUE_FILTER_DESC AllowList;
    public DXGI_INFO_QUEUE_FILTER_DESC DenyList;
}
