// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CREDUI_INFOW.xml' path='doc/member[@name="CREDUI_INFOW"]/*' />
public unsafe partial struct CREDUI_INFOW
{
    /// <include file='CREDUI_INFOW.xml' path='doc/member[@name="CREDUI_INFOW.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='CREDUI_INFOW.xml' path='doc/member[@name="CREDUI_INFOW.hwndParent"]/*' />
    public HWND hwndParent;

    /// <include file='CREDUI_INFOW.xml' path='doc/member[@name="CREDUI_INFOW.pszMessageText"]/*' />
    [NativeTypeName("PCWSTR")]
    public ushort* pszMessageText;

    /// <include file='CREDUI_INFOW.xml' path='doc/member[@name="CREDUI_INFOW.pszCaptionText"]/*' />
    [NativeTypeName("PCWSTR")]
    public ushort* pszCaptionText;

    /// <include file='CREDUI_INFOW.xml' path='doc/member[@name="CREDUI_INFOW.hbmBanner"]/*' />
    public HBITMAP hbmBanner;
}
