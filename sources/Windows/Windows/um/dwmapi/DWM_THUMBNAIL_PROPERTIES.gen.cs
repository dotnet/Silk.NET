// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='DWM_THUMBNAIL_PROPERTIES.xml' path='doc/member[@name="DWM_THUMBNAIL_PROPERTIES"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DWM_THUMBNAIL_PROPERTIES
{
    /// <include file='DWM_THUMBNAIL_PROPERTIES.xml' path='doc/member[@name="DWM_THUMBNAIL_PROPERTIES.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='DWM_THUMBNAIL_PROPERTIES.xml' path='doc/member[@name="DWM_THUMBNAIL_PROPERTIES.rcDestination"]/*'/>
    public RECT rcDestination;
    /// <include file='DWM_THUMBNAIL_PROPERTIES.xml' path='doc/member[@name="DWM_THUMBNAIL_PROPERTIES.rcSource"]/*'/>
    public RECT rcSource;
    /// <include file='DWM_THUMBNAIL_PROPERTIES.xml' path='doc/member[@name="DWM_THUMBNAIL_PROPERTIES.opacity"]/*'/>
    public byte opacity;
    /// <include file='DWM_THUMBNAIL_PROPERTIES.xml' path='doc/member[@name="DWM_THUMBNAIL_PROPERTIES.fVisible"]/*'/>
    public BOOL fVisible;
    /// <include file='DWM_THUMBNAIL_PROPERTIES.xml' path='doc/member[@name="DWM_THUMBNAIL_PROPERTIES.fSourceClientAreaOnly"]/*'/>
    public BOOL fSourceClientAreaOnly;
}