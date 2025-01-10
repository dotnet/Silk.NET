// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct PAINTSTRUCT
{
    public HDC hdc;
    public BOOL fErase;
    public RECT rcPaint;
    public BOOL fRestore;
    public BOOL fIncUpdate;

    [NativeTypeName("BYTE[32]")]
    public _rgbReserved_e__FixedBuffer rgbReserved;

    [InlineArray(32)]
    public partial struct _rgbReserved_e__FixedBuffer
    {
        public byte e0;
    }
}
