// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shimgdata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("BFDEEC12-8040-4403-A5EA-9E07DAFCF530")]
[NativeTypeName("struct IShellImageData : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IShellImageData : IShellImageData.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellImageData));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellImageData, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IShellImageData, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellImageData, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Decode(
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("ULONG")] uint cxDesired,
        [NativeTypeName("ULONG")] uint cyDesired
    )
    {
        return ((delegate* unmanaged<IShellImageData, uint, uint, uint, int>)((*lpVtbl)[3]))(
            this,
            dwFlags,
            cxDesired,
            cyDesired
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Draw(
        HDC hdc,
        [NativeTypeName("LPRECT")] RECT* prcDest,
        [NativeTypeName("LPRECT")] RECT* prcSrc
    )
    {
        return ((delegate* unmanaged<IShellImageData, HDC, RECT*, RECT*, int>)((*lpVtbl)[4]))(
            this,
            hdc,
            prcDest,
            prcSrc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT NextFrame()
    {
        return ((delegate* unmanaged<IShellImageData, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT NextPage()
    {
        return ((delegate* unmanaged<IShellImageData, int>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT PrevPage()
    {
        return ((delegate* unmanaged<IShellImageData, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT IsTransparent()
    {
        return ((delegate* unmanaged<IShellImageData, int>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT IsAnimated()
    {
        return ((delegate* unmanaged<IShellImageData, int>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT IsVector()
    {
        return ((delegate* unmanaged<IShellImageData, int>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT IsMultipage()
    {
        return ((delegate* unmanaged<IShellImageData, int>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT IsEditable()
    {
        return ((delegate* unmanaged<IShellImageData, int>)((*lpVtbl)[12]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT IsPrintable()
    {
        return ((delegate* unmanaged<IShellImageData, int>)((*lpVtbl)[13]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT IsDecoded()
    {
        return ((delegate* unmanaged<IShellImageData, int>)((*lpVtbl)[14]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetCurrentPage([NativeTypeName("ULONG *")] uint* pnPage)
    {
        return ((delegate* unmanaged<IShellImageData, uint*, int>)((*lpVtbl)[15]))(this, pnPage);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetPageCount([NativeTypeName("ULONG *")] uint* pcPages)
    {
        return ((delegate* unmanaged<IShellImageData, uint*, int>)((*lpVtbl)[16]))(this, pcPages);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SelectPage([NativeTypeName("ULONG")] uint iPage)
    {
        return ((delegate* unmanaged<IShellImageData, uint, int>)((*lpVtbl)[17]))(this, iPage);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetSize(SIZE* pSize)
    {
        return ((delegate* unmanaged<IShellImageData, SIZE*, int>)((*lpVtbl)[18]))(this, pSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetRawDataFormat(Guid* pDataFormat)
    {
        return ((delegate* unmanaged<IShellImageData, Guid*, int>)((*lpVtbl)[19]))(
            this,
            pDataFormat
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetPixelFormat([NativeTypeName("PixelFormat *")] uint* pFormat)
    {
        return ((delegate* unmanaged<IShellImageData, uint*, int>)((*lpVtbl)[20]))(this, pFormat);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetDelay([NativeTypeName("DWORD *")] uint* pdwDelay)
    {
        return ((delegate* unmanaged<IShellImageData, uint*, int>)((*lpVtbl)[21]))(this, pdwDelay);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetProperties(
        [NativeTypeName("DWORD")] uint dwMode,
        IPropertySetStorage* ppPropSet
    )
    {
        return (
            (delegate* unmanaged<IShellImageData, uint, IPropertySetStorage*, int>)((*lpVtbl)[22])
        )(this, dwMode, ppPropSet);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT Rotate([NativeTypeName("DWORD")] uint dwAngle)
    {
        return ((delegate* unmanaged<IShellImageData, uint, int>)((*lpVtbl)[23]))(this, dwAngle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT Scale(
        [NativeTypeName("ULONG")] uint cx,
        [NativeTypeName("ULONG")] uint cy,
        [NativeTypeName("InterpolationMode")] uint hints
    )
    {
        return ((delegate* unmanaged<IShellImageData, uint, uint, uint, int>)((*lpVtbl)[24]))(
            this,
            cx,
            cy,
            hints
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT DiscardEdit()
    {
        return ((delegate* unmanaged<IShellImageData, int>)((*lpVtbl)[25]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT SetEncoderParams(IPropertyBag pbagEnc)
    {
        return ((delegate* unmanaged<IShellImageData, IPropertyBag, int>)((*lpVtbl)[26]))(
            this,
            pbagEnc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT DisplayName([NativeTypeName("LPWSTR")] ushort* wszName, uint cch)
    {
        return ((delegate* unmanaged<IShellImageData, ushort*, uint, int>)((*lpVtbl)[27]))(
            this,
            wszName,
            cch
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT GetResolution(
        [NativeTypeName("ULONG *")] uint* puResolutionX,
        [NativeTypeName("ULONG *")] uint* puResolutionY
    )
    {
        return ((delegate* unmanaged<IShellImageData, uint*, uint*, int>)((*lpVtbl)[28]))(
            this,
            puResolutionX,
            puResolutionY
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT GetEncoderParams(
        Guid* pguidFmt,
        [NativeTypeName("EncoderParameters **")] byte** ppEncParams
    )
    {
        return ((delegate* unmanaged<IShellImageData, Guid*, byte**, int>)((*lpVtbl)[29]))(
            this,
            pguidFmt,
            ppEncParams
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT RegisterAbort(IShellImageDataAbort pAbort, IShellImageDataAbort* ppAbortPrev)
    {
        return (
            (delegate* unmanaged<
                IShellImageData,
                IShellImageDataAbort,
                IShellImageDataAbort*,
                int>)((*lpVtbl)[30])
        )(this, pAbort, ppAbortPrev);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT CloneFrame([NativeTypeName("Image **")] byte** ppImg)
    {
        return ((delegate* unmanaged<IShellImageData, byte**, int>)((*lpVtbl)[31]))(this, ppImg);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT ReplaceFrame([NativeTypeName("Image *")] byte* pImg)
    {
        return ((delegate* unmanaged<IShellImageData, byte*, int>)((*lpVtbl)[32]))(this, pImg);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Decode(
            [NativeTypeName("DWORD")] uint dwFlags,
            [NativeTypeName("ULONG")] uint cxDesired,
            [NativeTypeName("ULONG")] uint cyDesired
        );

        [VtblIndex(4)]
        HRESULT Draw(
            HDC hdc,
            [NativeTypeName("LPRECT")] RECT* prcDest,
            [NativeTypeName("LPRECT")] RECT* prcSrc
        );

        [VtblIndex(5)]
        HRESULT NextFrame();

        [VtblIndex(6)]
        HRESULT NextPage();

        [VtblIndex(7)]
        HRESULT PrevPage();

        [VtblIndex(8)]
        HRESULT IsTransparent();

        [VtblIndex(9)]
        HRESULT IsAnimated();

        [VtblIndex(10)]
        HRESULT IsVector();

        [VtblIndex(11)]
        HRESULT IsMultipage();

        [VtblIndex(12)]
        HRESULT IsEditable();

        [VtblIndex(13)]
        HRESULT IsPrintable();

        [VtblIndex(14)]
        HRESULT IsDecoded();

        [VtblIndex(15)]
        HRESULT GetCurrentPage([NativeTypeName("ULONG *")] uint* pnPage);

        [VtblIndex(16)]
        HRESULT GetPageCount([NativeTypeName("ULONG *")] uint* pcPages);

        [VtblIndex(17)]
        HRESULT SelectPage([NativeTypeName("ULONG")] uint iPage);

        [VtblIndex(18)]
        HRESULT GetSize(SIZE* pSize);

        [VtblIndex(19)]
        HRESULT GetRawDataFormat(Guid* pDataFormat);

        [VtblIndex(20)]
        HRESULT GetPixelFormat([NativeTypeName("PixelFormat *")] uint* pFormat);

        [VtblIndex(21)]
        HRESULT GetDelay([NativeTypeName("DWORD *")] uint* pdwDelay);

        [VtblIndex(22)]
        HRESULT GetProperties(
            [NativeTypeName("DWORD")] uint dwMode,
            IPropertySetStorage* ppPropSet
        );

        [VtblIndex(23)]
        HRESULT Rotate([NativeTypeName("DWORD")] uint dwAngle);

        [VtblIndex(24)]
        HRESULT Scale(
            [NativeTypeName("ULONG")] uint cx,
            [NativeTypeName("ULONG")] uint cy,
            [NativeTypeName("InterpolationMode")] uint hints
        );

        [VtblIndex(25)]
        HRESULT DiscardEdit();

        [VtblIndex(26)]
        HRESULT SetEncoderParams(IPropertyBag pbagEnc);

        [VtblIndex(27)]
        HRESULT DisplayName([NativeTypeName("LPWSTR")] ushort* wszName, uint cch);

        [VtblIndex(28)]
        HRESULT GetResolution(
            [NativeTypeName("ULONG *")] uint* puResolutionX,
            [NativeTypeName("ULONG *")] uint* puResolutionY
        );

        [VtblIndex(29)]
        HRESULT GetEncoderParams(
            Guid* pguidFmt,
            [NativeTypeName("EncoderParameters **")] byte** ppEncParams
        );

        [VtblIndex(30)]
        HRESULT RegisterAbort(IShellImageDataAbort pAbort, IShellImageDataAbort* ppAbortPrev);

        [VtblIndex(31)]
        HRESULT CloneFrame([NativeTypeName("Image **")] byte** ppImg);

        [VtblIndex(32)]
        HRESULT ReplaceFrame([NativeTypeName("Image *")] byte* pImg);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (DWORD, ULONG, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, int> Decode;

        [NativeTypeName("HRESULT (HDC, LPRECT, LPRECT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HDC, RECT*, RECT*, int> Draw;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> NextFrame;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> NextPage;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> PrevPage;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsTransparent;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsAnimated;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsVector;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsMultipage;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsEditable;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsPrintable;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsDecoded;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCurrentPage;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetPageCount;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SelectPage;

        [NativeTypeName("HRESULT (SIZE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SIZE*, int> GetSize;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetRawDataFormat;

        [NativeTypeName("HRESULT (PixelFormat *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetPixelFormat;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetDelay;

        [NativeTypeName("HRESULT (DWORD, IPropertySetStorage **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IPropertySetStorage*, int> GetProperties;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Rotate;

        [NativeTypeName("HRESULT (ULONG, ULONG, InterpolationMode) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, int> Scale;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DiscardEdit;

        [NativeTypeName("HRESULT (IPropertyBag *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPropertyBag, int> SetEncoderParams;

        [NativeTypeName("HRESULT (LPWSTR, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> DisplayName;

        [NativeTypeName("HRESULT (ULONG *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetResolution;

        [NativeTypeName("HRESULT (GUID *, EncoderParameters **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, byte**, int> GetEncoderParams;

        [NativeTypeName(
            "HRESULT (IShellImageDataAbort *, IShellImageDataAbort **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IShellImageDataAbort,
            IShellImageDataAbort*,
            int> RegisterAbort;

        [NativeTypeName("HRESULT (Image **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, int> CloneFrame;

        [NativeTypeName("HRESULT (Image *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> ReplaceFrame;
    }

    /// <summary>Initializes a new instance of the <see cref = "IShellImageData"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IShellImageData(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IShellImageData"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IShellImageData(Silk.NET.Windows.IUnknown value)
    {
        return new IShellImageData(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellImageData"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IShellImageData"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IShellImageData value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
