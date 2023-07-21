// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MENUGETOBJECTINFO.xml' path='doc/member[@name="MENUGETOBJECTINFO"]/*' />
public unsafe partial struct MENUGETOBJECTINFO
{
    /// <include file='MENUGETOBJECTINFO.xml' path='doc/member[@name="MENUGETOBJECTINFO.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='MENUGETOBJECTINFO.xml' path='doc/member[@name="MENUGETOBJECTINFO.uPos"]/*' />
    public uint uPos;

    /// <include file='MENUGETOBJECTINFO.xml' path='doc/member[@name="MENUGETOBJECTINFO.hmenu"]/*' />
    public HMENU hmenu;

    /// <include file='MENUGETOBJECTINFO.xml' path='doc/member[@name="MENUGETOBJECTINFO.riid"]/*' />
    [NativeTypeName("PVOID")]
    public void* riid;

    /// <include file='MENUGETOBJECTINFO.xml' path='doc/member[@name="MENUGETOBJECTINFO.pvObj"]/*' />
    [NativeTypeName("PVOID")]
    public void* pvObj;
}
