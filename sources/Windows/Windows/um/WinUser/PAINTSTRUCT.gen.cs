// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PAINTSTRUCT.xml' path='doc/member[@name="PAINTSTRUCT"]/*' />
public unsafe partial struct PAINTSTRUCT
{
    /// <include file='PAINTSTRUCT.xml' path='doc/member[@name="PAINTSTRUCT.hdc"]/*' />
    public HDC hdc;

    /// <include file='PAINTSTRUCT.xml' path='doc/member[@name="PAINTSTRUCT.fErase"]/*' />
    public BOOL fErase;

    /// <include file='PAINTSTRUCT.xml' path='doc/member[@name="PAINTSTRUCT.rcPaint"]/*' />
    public RECT rcPaint;

    /// <include file='PAINTSTRUCT.xml' path='doc/member[@name="PAINTSTRUCT.fRestore"]/*' />
    public BOOL fRestore;

    /// <include file='PAINTSTRUCT.xml' path='doc/member[@name="PAINTSTRUCT.fIncUpdate"]/*' />
    public BOOL fIncUpdate;

    /// <include file='PAINTSTRUCT.xml' path='doc/member[@name="PAINTSTRUCT.rgbReserved"]/*' />
    [NativeTypeName("BYTE[32]")]
    public fixed byte rgbReserved[32];
}
