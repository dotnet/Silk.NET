// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusinit.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Gdiplus;
/// <include file='GdiplusStartupOutput.xml' path='doc/member[@name="GdiplusStartupOutput"]/*'/>
public unsafe partial struct GdiplusStartupOutput
{
    /// <include file='GdiplusStartupOutput.xml' path='doc/member[@name="GdiplusStartupOutput.NotificationHook"]/*'/>
    [NativeTypeName("Gdiplus::NotificationHookProc")]
    public delegate* unmanaged<nuint*, GpStatus> NotificationHook;
    /// <include file='GdiplusStartupOutput.xml' path='doc/member[@name="GdiplusStartupOutput.NotificationUnhook"]/*'/>
    [NativeTypeName("Gdiplus::NotificationUnhookProc")]
    public delegate* unmanaged<nuint, void> NotificationUnhook;
}