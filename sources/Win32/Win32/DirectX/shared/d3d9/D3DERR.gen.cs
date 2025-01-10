// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DERR
{
    [NativeTypeName("#define D3DERR_WRONGTEXTUREFORMAT MAKE_D3DHRESULT(2072)")]
    public const int D3DERR_WRONGTEXTUREFORMAT = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2072)))
    );

    [NativeTypeName("#define D3DERR_UNSUPPORTEDCOLOROPERATION MAKE_D3DHRESULT(2073)")]
    public const int D3DERR_UNSUPPORTEDCOLOROPERATION = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2073)))
    );

    [NativeTypeName("#define D3DERR_UNSUPPORTEDCOLORARG MAKE_D3DHRESULT(2074)")]
    public const int D3DERR_UNSUPPORTEDCOLORARG = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2074)))
    );

    [NativeTypeName("#define D3DERR_UNSUPPORTEDALPHAOPERATION MAKE_D3DHRESULT(2075)")]
    public const int D3DERR_UNSUPPORTEDALPHAOPERATION = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2075)))
    );

    [NativeTypeName("#define D3DERR_UNSUPPORTEDALPHAARG MAKE_D3DHRESULT(2076)")]
    public const int D3DERR_UNSUPPORTEDALPHAARG = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2076)))
    );

    [NativeTypeName("#define D3DERR_TOOMANYOPERATIONS MAKE_D3DHRESULT(2077)")]
    public const int D3DERR_TOOMANYOPERATIONS = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2077)))
    );

    [NativeTypeName("#define D3DERR_CONFLICTINGTEXTUREFILTER MAKE_D3DHRESULT(2078)")]
    public const int D3DERR_CONFLICTINGTEXTUREFILTER = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2078)))
    );

    [NativeTypeName("#define D3DERR_UNSUPPORTEDFACTORVALUE MAKE_D3DHRESULT(2079)")]
    public const int D3DERR_UNSUPPORTEDFACTORVALUE = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2079)))
    );

    [NativeTypeName("#define D3DERR_CONFLICTINGRENDERSTATE MAKE_D3DHRESULT(2081)")]
    public const int D3DERR_CONFLICTINGRENDERSTATE = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2081)))
    );

    [NativeTypeName("#define D3DERR_UNSUPPORTEDTEXTUREFILTER MAKE_D3DHRESULT(2082)")]
    public const int D3DERR_UNSUPPORTEDTEXTUREFILTER = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2082)))
    );

    [NativeTypeName("#define D3DERR_CONFLICTINGTEXTUREPALETTE MAKE_D3DHRESULT(2086)")]
    public const int D3DERR_CONFLICTINGTEXTUREPALETTE = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2086)))
    );

    [NativeTypeName("#define D3DERR_DRIVERINTERNALERROR MAKE_D3DHRESULT(2087)")]
    public const int D3DERR_DRIVERINTERNALERROR = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2087)))
    );

    [NativeTypeName("#define D3DERR_NOTFOUND MAKE_D3DHRESULT(2150)")]
    public const int D3DERR_NOTFOUND = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2150)))
    );

    [NativeTypeName("#define D3DERR_MOREDATA MAKE_D3DHRESULT(2151)")]
    public const int D3DERR_MOREDATA = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2151)))
    );

    [NativeTypeName("#define D3DERR_DEVICELOST MAKE_D3DHRESULT(2152)")]
    public const int D3DERR_DEVICELOST = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2152)))
    );

    [NativeTypeName("#define D3DERR_DEVICENOTRESET MAKE_D3DHRESULT(2153)")]
    public const int D3DERR_DEVICENOTRESET = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2153)))
    );

    [NativeTypeName("#define D3DERR_NOTAVAILABLE MAKE_D3DHRESULT(2154)")]
    public const int D3DERR_NOTAVAILABLE = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2154)))
    );

    [NativeTypeName("#define D3DERR_OUTOFVIDEOMEMORY MAKE_D3DHRESULT(380)")]
    public const int D3DERR_OUTOFVIDEOMEMORY = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(380)))
    );

    [NativeTypeName("#define D3DERR_INVALIDDEVICE MAKE_D3DHRESULT(2155)")]
    public const int D3DERR_INVALIDDEVICE = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2155)))
    );

    [NativeTypeName("#define D3DERR_INVALIDCALL MAKE_D3DHRESULT(2156)")]
    public const int D3DERR_INVALIDCALL = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2156)))
    );

    [NativeTypeName("#define D3DERR_DRIVERINVALIDCALL MAKE_D3DHRESULT(2157)")]
    public const int D3DERR_DRIVERINVALIDCALL = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2157)))
    );

    [NativeTypeName("#define D3DERR_WASSTILLDRAWING MAKE_D3DHRESULT(540)")]
    public const int D3DERR_WASSTILLDRAWING = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(540)))
    );

    [NativeTypeName("#define D3DERR_DEVICEREMOVED MAKE_D3DHRESULT(2160)")]
    public const int D3DERR_DEVICEREMOVED = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2160)))
    );

    [NativeTypeName("#define D3DERR_DEVICEHUNG MAKE_D3DHRESULT(2164)")]
    public const int D3DERR_DEVICEHUNG = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2164)))
    );

    [NativeTypeName("#define D3DERR_UNSUPPORTEDOVERLAY MAKE_D3DHRESULT(2171)")]
    public const int D3DERR_UNSUPPORTEDOVERLAY = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2171)))
    );

    [NativeTypeName("#define D3DERR_UNSUPPORTEDOVERLAYFORMAT MAKE_D3DHRESULT(2172)")]
    public const int D3DERR_UNSUPPORTEDOVERLAYFORMAT = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2172)))
    );

    [NativeTypeName("#define D3DERR_CANNOTPROTECTCONTENT MAKE_D3DHRESULT(2173)")]
    public const int D3DERR_CANNOTPROTECTCONTENT = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2173)))
    );

    [NativeTypeName("#define D3DERR_UNSUPPORTEDCRYPTO MAKE_D3DHRESULT(2174)")]
    public const int D3DERR_UNSUPPORTEDCRYPTO = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2174)))
    );

    [NativeTypeName("#define D3DERR_PRESENT_STATISTICS_DISJOINT MAKE_D3DHRESULT(2180)")]
    public const int D3DERR_PRESENT_STATISTICS_DISJOINT = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2180)))
    );
}
