// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct NMDATETIMEFORMATA
{
    public NMHDR nmhdr;

    [NativeTypeName("LPCSTR")]
    public sbyte* pszFormat;
    public SYSTEMTIME st;

    [NativeTypeName("LPCSTR")]
    public sbyte* pszDisplay;

    [NativeTypeName("CHAR[64]")]
    public _szDisplay_e__FixedBuffer szDisplay;

    [InlineArray(64)]
    public partial struct _szDisplay_e__FixedBuffer
    {
        public sbyte e0;
    }
}
