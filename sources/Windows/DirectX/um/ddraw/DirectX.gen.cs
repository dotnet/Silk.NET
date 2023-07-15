// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DirectDrawEnumerateW"]/*'/>
    [DllImport("ddraw", ExactSpelling = true)]
    public static extern HRESULT DirectDrawEnumerateW([NativeTypeName("LPDDENUMCALLBACKW")] delegate* unmanaged<Guid*, ushort*, ushort*, void*, BOOL> lpCallback, [NativeTypeName("LPVOID")] void* lpContext);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DirectDrawEnumerateA"]/*'/>
    [DllImport("ddraw", ExactSpelling = true)]
    public static extern HRESULT DirectDrawEnumerateA([NativeTypeName("LPDDENUMCALLBACKA")] delegate* unmanaged<Guid*, sbyte*, sbyte*, void*, BOOL> lpCallback, [NativeTypeName("LPVOID")] void* lpContext);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DirectDrawEnumerateExW"]/*'/>
    [DllImport("ddraw", ExactSpelling = true)]
    public static extern HRESULT DirectDrawEnumerateExW([NativeTypeName("LPDDENUMCALLBACKEXW")] delegate* unmanaged<Guid*, ushort*, ushort*, void*, HMONITOR, BOOL> lpCallback, [NativeTypeName("LPVOID")] void* lpContext, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DirectDrawEnumerateExA"]/*'/>
    [DllImport("ddraw", ExactSpelling = true)]
    public static extern HRESULT DirectDrawEnumerateExA([NativeTypeName("LPDDENUMCALLBACKEXA")] delegate* unmanaged<Guid*, sbyte*, sbyte*, void*, HMONITOR, BOOL> lpCallback, [NativeTypeName("LPVOID")] void* lpContext, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DirectDrawCreate"]/*'/>
    [DllImport("ddraw", ExactSpelling = true)]
    public static extern HRESULT DirectDrawCreate(Guid* lpGUID, [NativeTypeName("LPDIRECTDRAW *")] IDirectDraw** lplpDD, IUnknown* pUnkOuter);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DirectDrawCreateEx"]/*'/>
    [DllImport("ddraw", ExactSpelling = true)]
    public static extern HRESULT DirectDrawCreateEx(Guid* lpGuid, [NativeTypeName("LPVOID *")] void** lplpDD, [NativeTypeName("const IID &")] Guid* iid, IUnknown* pUnkOuter);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DirectDrawCreateClipper"]/*'/>
    [DllImport("ddraw", ExactSpelling = true)]
    public static extern HRESULT DirectDrawCreateClipper([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPDIRECTDRAWCLIPPER *")] IDirectDrawClipper** lplpDDClipper, IUnknown* pUnkOuter);
    [NativeTypeName("#define DIRECTDRAW_VERSION 0x0700")]
    public const int DIRECTDRAW_VERSION = 0x0700;
    [NativeTypeName("#define _FACDD 0x876")]
    public const int _FACDD = 0x876;
    [NativeTypeName("#define FOURCC_DXT1 (MAKEFOURCC('D','X','T','1'))")]
    public const uint FOURCC_DXT1 = (((uint)((byte)('D')) | ((uint)((byte)('X')) << 8) | ((uint)((byte)('T')) << 16) | ((uint)((byte)('1')) << 24)));
    [NativeTypeName("#define FOURCC_DXT2 (MAKEFOURCC('D','X','T','2'))")]
    public const uint FOURCC_DXT2 = (((uint)((byte)('D')) | ((uint)((byte)('X')) << 8) | ((uint)((byte)('T')) << 16) | ((uint)((byte)('2')) << 24)));
    [NativeTypeName("#define FOURCC_DXT3 (MAKEFOURCC('D','X','T','3'))")]
    public const uint FOURCC_DXT3 = (((uint)((byte)('D')) | ((uint)((byte)('X')) << 8) | ((uint)((byte)('T')) << 16) | ((uint)((byte)('3')) << 24)));
    [NativeTypeName("#define FOURCC_DXT4 (MAKEFOURCC('D','X','T','4'))")]
    public const uint FOURCC_DXT4 = (((uint)((byte)('D')) | ((uint)((byte)('X')) << 8) | ((uint)((byte)('T')) << 16) | ((uint)((byte)('4')) << 24)));
    [NativeTypeName("#define FOURCC_DXT5 (MAKEFOURCC('D','X','T','5'))")]
    public const uint FOURCC_DXT5 = (((uint)((byte)('D')) | ((uint)((byte)('X')) << 8) | ((uint)((byte)('T')) << 16) | ((uint)((byte)('5')) << 24)));
    [NativeTypeName("#define DirectDrawEnumerate DirectDrawEnumerateW")]
    public static delegate*<delegate* unmanaged<Guid*, ushort*, ushort*, void*, BOOL> , void*, HRESULT> DirectDrawEnumerate => &DirectDrawEnumerateW;

    [NativeTypeName("#define DirectDrawEnumerateEx DirectDrawEnumerateExW")]
    public static delegate*<delegate* unmanaged<Guid*, ushort*, ushort*, void*, HMONITOR, BOOL> , void*, uint, HRESULT> DirectDrawEnumerateEx => &DirectDrawEnumerateExW;

    [NativeTypeName("#define REGSTR_KEY_DDHW_DESCRIPTION \"Description\"")]
    public static ReadOnlySpan<byte> REGSTR_KEY_DDHW_DESCRIPTION => "Description"u8;

    [NativeTypeName("#define REGSTR_KEY_DDHW_DRIVERNAME \"DriverName\"")]
    public static ReadOnlySpan<byte> REGSTR_KEY_DDHW_DRIVERNAME => "DriverName"u8;

    [NativeTypeName("#define REGSTR_PATH_DDHW \"Hardware\\\\DirectDrawDrivers\"")]
    public static ReadOnlySpan<byte> REGSTR_PATH_DDHW => "Hardware\\DirectDrawDrivers"u8;

    [NativeTypeName("#define DD_ROP_SPACE (256/32)")]
    public const int DD_ROP_SPACE = (256 / 32);
    [NativeTypeName("#define DDGDI_GETHOSTIDENTIFIER 0x00000001L")]
    public const int DDGDI_GETHOSTIDENTIFIER = 0x00000001;
    [NativeTypeName("#define DDSDM_STANDARDVGAMODE 0x00000001l")]
    public const int DDSDM_STANDARDVGAMODE = 0x00000001;
    [NativeTypeName("#define DDSGR_CALIBRATE 0x00000001L")]
    public const int DDSGR_CALIBRATE = 0x00000001;
    [NativeTypeName("#define DDSMT_ISTESTREQUIRED 0x00000001L")]
    public const int DDSMT_ISTESTREQUIRED = 0x00000001;
    [NativeTypeName("#define DD_OK S_OK")]
    public const int DD_OK = ((int)(0));
    [NativeTypeName("#define DD_FALSE S_FALSE")]
    public const int DD_FALSE = ((int)(1));
}