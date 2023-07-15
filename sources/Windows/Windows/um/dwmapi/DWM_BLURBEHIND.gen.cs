// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='DWM_BLURBEHIND.xml' path='doc/member[@name="DWM_BLURBEHIND"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DWM_BLURBEHIND
{
    /// <include file='DWM_BLURBEHIND.xml' path='doc/member[@name="DWM_BLURBEHIND.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='DWM_BLURBEHIND.xml' path='doc/member[@name="DWM_BLURBEHIND.fEnable"]/*'/>
    public BOOL fEnable;
    /// <include file='DWM_BLURBEHIND.xml' path='doc/member[@name="DWM_BLURBEHIND.hRgnBlur"]/*'/>
    public HRGN hRgnBlur;
    /// <include file='DWM_BLURBEHIND.xml' path='doc/member[@name="DWM_BLURBEHIND.fTransitionOnMaximized"]/*'/>
    public BOOL fTransitionOnMaximized;
}