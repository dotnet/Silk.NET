// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusmetaheader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Gdiplus.MetafileType;

namespace Silk.NET.Gdiplus;

/// <include file='MetafileHeader.xml' path='doc/member[@name="MetafileHeader"]/*' />
public unsafe partial struct MetafileHeader
{
    /// <include file='MetafileHeader.xml' path='doc/member[@name="MetafileHeader.Type"]/*' />
    [NativeTypeName("Gdiplus::MetafileType")]
    public MetafileType Type;

    /// <include file='MetafileHeader.xml' path='doc/member[@name="MetafileHeader.Size"]/*' />
    public uint Size;

    /// <include file='MetafileHeader.xml' path='doc/member[@name="MetafileHeader.Version"]/*' />
    public uint Version;

    /// <include file='MetafileHeader.xml' path='doc/member[@name="MetafileHeader.EmfPlusFlags"]/*' />
    public uint EmfPlusFlags;

    /// <include file='MetafileHeader.xml' path='doc/member[@name="MetafileHeader.DpiX"]/*' />
    [NativeTypeName("Gdiplus::REAL")]
    public float DpiX;

    /// <include file='MetafileHeader.xml' path='doc/member[@name="MetafileHeader.DpiY"]/*' />
    [NativeTypeName("Gdiplus::REAL")]
    public float DpiY;

    /// <include file='MetafileHeader.xml' path='doc/member[@name="MetafileHeader.X"]/*' />
    public int X;

    /// <include file='MetafileHeader.xml' path='doc/member[@name="MetafileHeader.Y"]/*' />
    public int Y;

    /// <include file='MetafileHeader.xml' path='doc/member[@name="MetafileHeader.Width"]/*' />
    public int Width;

    /// <include file='MetafileHeader.xml' path='doc/member[@name="MetafileHeader.Height"]/*' />
    public int Height;

    /// <include file='MetafileHeader.xml' path='doc/member[@name="MetafileHeader.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_GdiplusMetaHeader_L129_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='MetafileHeader.xml' path='doc/member[@name="MetafileHeader.EmfPlusHeaderSize"]/*' />
    public int EmfPlusHeaderSize;

    /// <include file='MetafileHeader.xml' path='doc/member[@name="MetafileHeader.LogicalDpiX"]/*' />
    public int LogicalDpiX;

    /// <include file='MetafileHeader.xml' path='doc/member[@name="MetafileHeader.LogicalDpiY"]/*' />
    public int LogicalDpiY;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.WmfHeader"]/*' />
    [UnscopedRef]
    public ref METAHEADER WmfHeader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.WmfHeader;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.EmfHeader"]/*' />
    [UnscopedRef]
    public ref ENHMETAHEADER3 EmfHeader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.EmfHeader;
        }
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

    [return: NativeTypeName("const ENHMETAHEADER3 *")]
    public ENHMETAHEADER3* GetEmfHeader()
    {
        if ((_ = IsEmfOrEmfPlus()) != 0)
        {
            return &Anonymous.EmfHeader;
        }

        return null;
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.WmfHeader"]/*' />
        [FieldOffset(0)]
        public METAHEADER WmfHeader;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.EmfHeader"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("Gdiplus::ENHMETAHEADER3")]
        public ENHMETAHEADER3 EmfHeader;
    }
}
