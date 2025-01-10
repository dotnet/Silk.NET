// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum AM_GRAPH_CONFIG_RECONNECT_FLAGS
{
    AM_GRAPH_CONFIG_RECONNECT_DIRECTCONNECT = 0x1,
    AM_GRAPH_CONFIG_RECONNECT_CACHE_REMOVED_FILTERS = 0x2,
    AM_GRAPH_CONFIG_RECONNECT_USE_ONLY_CACHED_FILTERS = 0x4,
}
