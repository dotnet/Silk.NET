// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusmetaheader.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Gdiplus.MetafileType;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

public unsafe partial struct MetafileHeader
{
    [NativeTypeName("Gdiplus::MetafileType")]
    public MetafileType Type;
    public uint Size;
    public uint Version;
    public uint EmfPlusFlags;

    [NativeTypeName("Gdiplus::REAL")]
    public float DpiX;

    [NativeTypeName("Gdiplus::REAL")]
    public float DpiY;
    public int X;
    public int Y;
    public int Width;
    public int Height;

    [NativeTypeName("__AnonymousRecord_GdiplusMetaHeader_L129_C5")]
    public _Anonymous_e__Union Anonymous;
    public int EmfPlusHeaderSize;
    public int LogicalDpiX;
    public int LogicalDpiY;

    [UnscopedRef]
    public ref METAHEADER WmfHeader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.WmfHeader; }
    }

    [UnscopedRef]
    public ref ENHMETAHEADER3 EmfHeader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.EmfHeader; }
    }

    [return: NativeTypeName("Gdiplus::MetafileType")]
    public new MetafileType GetType()
    {
        return Type;
    }

    public uint GetMetafileSize()
    {
        return Size;
    }

    public uint GetVersion()
    {
        return Version;
    }

    public uint GetEmfPlusFlags()
    {
        return EmfPlusFlags;
    }

    [return: NativeTypeName("Gdiplus::REAL")]
    public float GetDpiX()
    {
        return DpiX;
    }

    [return: NativeTypeName("Gdiplus::REAL")]
    public float GetDpiY()
    {
        return DpiY;
    }

    public void GetBounds([NativeTypeName("Gdiplus::Rect *")] GpRect* rect)
    {
        rect->X = X;
        rect->Y = Y;
        rect->Width = Width;
        rect->Height = Height;
    }

    public BOOL IsWmf()
    {
        return ((Type == MetafileTypeWmf) || (Type == MetafileTypeWmfPlaceable)) ? 1 : 0;
    }

    public BOOL IsWmfPlaceable()
    {
        return (Type == MetafileTypeWmfPlaceable) ? 1 : 0;
    }

    public BOOL IsEmf()
    {
        return (Type == MetafileTypeEmf) ? 1 : 0;
    }

    public BOOL IsEmfPlusDual()
    {
        return (Type == MetafileTypeEmfPlusDual) ? 1 : 0;
    }

    public BOOL IsEmfPlusOnly()
    {
        return (Type == MetafileTypeEmfPlusOnly) ? 1 : 0;
    }

    public BOOL IsDisplay()
    {
        return ((IsEmfPlus()) != 0 && ((EmfPlusFlags & 0x00000001) != 0)) ? 1 : 0;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public METAHEADER WmfHeader;

        [FieldOffset(0)]
        [NativeTypeName("Gdiplus::ENHMETAHEADER3")]
        public ENHMETAHEADER3 EmfHeader;
    }
}
