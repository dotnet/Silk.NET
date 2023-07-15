// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='AM_GRAPH_CONFIG_RECONNECT_FLAGS.xml' path='doc/member[@name="AM_GRAPH_CONFIG_RECONNECT_FLAGS"]/*'/>
public enum AM_GRAPH_CONFIG_RECONNECT_FLAGS
{
    /// <include file='AM_GRAPH_CONFIG_RECONNECT_FLAGS.xml' path='doc/member[@name="AM_GRAPH_CONFIG_RECONNECT_FLAGS.AM_GRAPH_CONFIG_RECONNECT_DIRECTCONNECT"]/*'/>
    AM_GRAPH_CONFIG_RECONNECT_DIRECTCONNECT = 0x1,
    /// <include file='AM_GRAPH_CONFIG_RECONNECT_FLAGS.xml' path='doc/member[@name="AM_GRAPH_CONFIG_RECONNECT_FLAGS.AM_GRAPH_CONFIG_RECONNECT_CACHE_REMOVED_FILTERS"]/*'/>
    AM_GRAPH_CONFIG_RECONNECT_CACHE_REMOVED_FILTERS = 0x2,
    /// <include file='AM_GRAPH_CONFIG_RECONNECT_FLAGS.xml' path='doc/member[@name="AM_GRAPH_CONFIG_RECONNECT_FLAGS.AM_GRAPH_CONFIG_RECONNECT_USE_ONLY_CACHED_FILTERS"]/*'/>
    AM_GRAPH_CONFIG_RECONNECT_USE_ONLY_CACHED_FILTERS = 0x4,
}