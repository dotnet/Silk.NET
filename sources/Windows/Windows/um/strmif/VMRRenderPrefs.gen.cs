// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='VMRRenderPrefs.xml' path='doc/member[@name="VMRRenderPrefs"]/*'/>
public enum VMRRenderPrefs
{
    /// <include file='VMRRenderPrefs.xml' path='doc/member[@name="VMRRenderPrefs.RenderPrefs_RestrictToInitialMonitor"]/*'/>
    RenderPrefs_RestrictToInitialMonitor = 0,
    /// <include file='VMRRenderPrefs.xml' path='doc/member[@name="VMRRenderPrefs.RenderPrefs_ForceOffscreen"]/*'/>
    RenderPrefs_ForceOffscreen = 0x1,
    /// <include file='VMRRenderPrefs.xml' path='doc/member[@name="VMRRenderPrefs.RenderPrefs_ForceOverlays"]/*'/>
    RenderPrefs_ForceOverlays = 0x2,
    /// <include file='VMRRenderPrefs.xml' path='doc/member[@name="VMRRenderPrefs.RenderPrefs_AllowOverlays"]/*'/>
    RenderPrefs_AllowOverlays = 0,
    /// <include file='VMRRenderPrefs.xml' path='doc/member[@name="VMRRenderPrefs.RenderPrefs_AllowOffscreen"]/*'/>
    RenderPrefs_AllowOffscreen = 0,
    /// <include file='VMRRenderPrefs.xml' path='doc/member[@name="VMRRenderPrefs.RenderPrefs_DoNotRenderColorKeyAndBorder"]/*'/>
    RenderPrefs_DoNotRenderColorKeyAndBorder = 0x8,
    /// <include file='VMRRenderPrefs.xml' path='doc/member[@name="VMRRenderPrefs.RenderPrefs_Reserved"]/*'/>
    RenderPrefs_Reserved = 0x10,
    /// <include file='VMRRenderPrefs.xml' path='doc/member[@name="VMRRenderPrefs.RenderPrefs_PreferAGPMemWhenMixing"]/*'/>
    RenderPrefs_PreferAGPMemWhenMixing = 0x20,
    /// <include file='VMRRenderPrefs.xml' path='doc/member[@name="VMRRenderPrefs.RenderPrefs_Mask"]/*'/>
    RenderPrefs_Mask = 0x3f,
}