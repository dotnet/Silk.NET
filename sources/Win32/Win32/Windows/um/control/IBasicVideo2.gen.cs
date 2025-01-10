// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/control.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("329BB360-F6EA-11D1-9038-00A0C9697298")]
[NativeTypeName("struct IBasicVideo2 : IBasicVideo")]
[NativeInheritance("IBasicVideo")]
public unsafe partial struct IBasicVideo2 : IBasicVideo2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBasicVideo2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBasicVideo2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IBasicVideo2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBasicVideo2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IBasicVideo2, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<IBasicVideo2, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
            this,
            iTInfo,
            lcid,
            ppTInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPOLESTR *")] ushort** rgszNames,
        uint cNames,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("DISPID *")] int* rgDispId
    )
    {
        return (
            (delegate* unmanaged<IBasicVideo2, Guid*, ushort**, uint, uint, int*, int>)(
                (*lpVtbl)[5]
            )
        )(this, riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke(
        [NativeTypeName("DISPID")] int dispIdMember,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("WORD")] ushort wFlags,
        DISPPARAMS* pDispParams,
        VARIANT* pVarResult,
        EXCEPINFO* pExcepInfo,
        uint* puArgErr
    )
    {
        return (
            (delegate* unmanaged<
                IBasicVideo2,
                int,
                Guid*,
                uint,
                ushort,
                DISPPARAMS*,
                VARIANT*,
                EXCEPINFO*,
                uint*,
                int>)((*lpVtbl)[6])
        )(this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AvgTimePerFrame([NativeTypeName("REFTIME *")] double* pAvgTimePerFrame)
    {
        return ((delegate* unmanaged<IBasicVideo2, double*, int>)((*lpVtbl)[7]))(
            this,
            pAvgTimePerFrame
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BitRate([NativeTypeName("long *")] int* pBitRate)
    {
        return ((delegate* unmanaged<IBasicVideo2, int*, int>)((*lpVtbl)[8]))(this, pBitRate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_BitErrorRate([NativeTypeName("long *")] int* pBitErrorRate)
    {
        return ((delegate* unmanaged<IBasicVideo2, int*, int>)((*lpVtbl)[9]))(this, pBitErrorRate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_VideoWidth([NativeTypeName("long *")] int* pVideoWidth)
    {
        return ((delegate* unmanaged<IBasicVideo2, int*, int>)((*lpVtbl)[10]))(this, pVideoWidth);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_VideoHeight([NativeTypeName("long *")] int* pVideoHeight)
    {
        return ((delegate* unmanaged<IBasicVideo2, int*, int>)((*lpVtbl)[11]))(this, pVideoHeight);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_SourceLeft([NativeTypeName("long")] int SourceLeft)
    {
        return ((delegate* unmanaged<IBasicVideo2, int, int>)((*lpVtbl)[12]))(this, SourceLeft);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_SourceLeft([NativeTypeName("long *")] int* pSourceLeft)
    {
        return ((delegate* unmanaged<IBasicVideo2, int*, int>)((*lpVtbl)[13]))(this, pSourceLeft);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_SourceWidth([NativeTypeName("long")] int SourceWidth)
    {
        return ((delegate* unmanaged<IBasicVideo2, int, int>)((*lpVtbl)[14]))(this, SourceWidth);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_SourceWidth([NativeTypeName("long *")] int* pSourceWidth)
    {
        return ((delegate* unmanaged<IBasicVideo2, int*, int>)((*lpVtbl)[15]))(this, pSourceWidth);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_SourceTop([NativeTypeName("long")] int SourceTop)
    {
        return ((delegate* unmanaged<IBasicVideo2, int, int>)((*lpVtbl)[16]))(this, SourceTop);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_SourceTop([NativeTypeName("long *")] int* pSourceTop)
    {
        return ((delegate* unmanaged<IBasicVideo2, int*, int>)((*lpVtbl)[17]))(this, pSourceTop);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_SourceHeight([NativeTypeName("long")] int SourceHeight)
    {
        return ((delegate* unmanaged<IBasicVideo2, int, int>)((*lpVtbl)[18]))(this, SourceHeight);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_SourceHeight([NativeTypeName("long *")] int* pSourceHeight)
    {
        return ((delegate* unmanaged<IBasicVideo2, int*, int>)((*lpVtbl)[19]))(this, pSourceHeight);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_DestinationLeft([NativeTypeName("long")] int DestinationLeft)
    {
        return ((delegate* unmanaged<IBasicVideo2, int, int>)((*lpVtbl)[20]))(
            this,
            DestinationLeft
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_DestinationLeft([NativeTypeName("long *")] int* pDestinationLeft)
    {
        return ((delegate* unmanaged<IBasicVideo2, int*, int>)((*lpVtbl)[21]))(
            this,
            pDestinationLeft
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_DestinationWidth([NativeTypeName("long")] int DestinationWidth)
    {
        return ((delegate* unmanaged<IBasicVideo2, int, int>)((*lpVtbl)[22]))(
            this,
            DestinationWidth
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_DestinationWidth([NativeTypeName("long *")] int* pDestinationWidth)
    {
        return ((delegate* unmanaged<IBasicVideo2, int*, int>)((*lpVtbl)[23]))(
            this,
            pDestinationWidth
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_DestinationTop([NativeTypeName("long")] int DestinationTop)
    {
        return ((delegate* unmanaged<IBasicVideo2, int, int>)((*lpVtbl)[24]))(this, DestinationTop);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_DestinationTop([NativeTypeName("long *")] int* pDestinationTop)
    {
        return ((delegate* unmanaged<IBasicVideo2, int*, int>)((*lpVtbl)[25]))(
            this,
            pDestinationTop
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_DestinationHeight([NativeTypeName("long")] int DestinationHeight)
    {
        return ((delegate* unmanaged<IBasicVideo2, int, int>)((*lpVtbl)[26]))(
            this,
            DestinationHeight
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_DestinationHeight([NativeTypeName("long *")] int* pDestinationHeight)
    {
        return ((delegate* unmanaged<IBasicVideo2, int*, int>)((*lpVtbl)[27]))(
            this,
            pDestinationHeight
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SetSourcePosition(
        [NativeTypeName("long")] int Left,
        [NativeTypeName("long")] int Top,
        [NativeTypeName("long")] int Width,
        [NativeTypeName("long")] int Height
    )
    {
        return ((delegate* unmanaged<IBasicVideo2, int, int, int, int, int>)((*lpVtbl)[28]))(
            this,
            Left,
            Top,
            Width,
            Height
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT GetSourcePosition(
        [NativeTypeName("long *")] int* pLeft,
        [NativeTypeName("long *")] int* pTop,
        [NativeTypeName("long *")] int* pWidth,
        [NativeTypeName("long *")] int* pHeight
    )
    {
        return ((delegate* unmanaged<IBasicVideo2, int*, int*, int*, int*, int>)((*lpVtbl)[29]))(
            this,
            pLeft,
            pTop,
            pWidth,
            pHeight
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT SetDefaultSourcePosition()
    {
        return ((delegate* unmanaged<IBasicVideo2, int>)((*lpVtbl)[30]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT SetDestinationPosition(
        [NativeTypeName("long")] int Left,
        [NativeTypeName("long")] int Top,
        [NativeTypeName("long")] int Width,
        [NativeTypeName("long")] int Height
    )
    {
        return ((delegate* unmanaged<IBasicVideo2, int, int, int, int, int>)((*lpVtbl)[31]))(
            this,
            Left,
            Top,
            Width,
            Height
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT GetDestinationPosition(
        [NativeTypeName("long *")] int* pLeft,
        [NativeTypeName("long *")] int* pTop,
        [NativeTypeName("long *")] int* pWidth,
        [NativeTypeName("long *")] int* pHeight
    )
    {
        return ((delegate* unmanaged<IBasicVideo2, int*, int*, int*, int*, int>)((*lpVtbl)[32]))(
            this,
            pLeft,
            pTop,
            pWidth,
            pHeight
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT SetDefaultDestinationPosition()
    {
        return ((delegate* unmanaged<IBasicVideo2, int>)((*lpVtbl)[33]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT GetVideoSize(
        [NativeTypeName("long *")] int* pWidth,
        [NativeTypeName("long *")] int* pHeight
    )
    {
        return ((delegate* unmanaged<IBasicVideo2, int*, int*, int>)((*lpVtbl)[34]))(
            this,
            pWidth,
            pHeight
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT GetVideoPaletteEntries(
        [NativeTypeName("long")] int StartIndex,
        [NativeTypeName("long")] int Entries,
        [NativeTypeName("long *")] int* pRetrieved,
        [NativeTypeName("long *")] int* pPalette
    )
    {
        return ((delegate* unmanaged<IBasicVideo2, int, int, int*, int*, int>)((*lpVtbl)[35]))(
            this,
            StartIndex,
            Entries,
            pRetrieved,
            pPalette
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT GetCurrentImage(
        [NativeTypeName("long *")] int* pBufferSize,
        [NativeTypeName("long *")] int* pDIBImage
    )
    {
        return ((delegate* unmanaged<IBasicVideo2, int*, int*, int>)((*lpVtbl)[36]))(
            this,
            pBufferSize,
            pDIBImage
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT IsUsingDefaultSource()
    {
        return ((delegate* unmanaged<IBasicVideo2, int>)((*lpVtbl)[37]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT IsUsingDefaultDestination()
    {
        return ((delegate* unmanaged<IBasicVideo2, int>)((*lpVtbl)[38]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT GetPreferredAspectRatio(
        [NativeTypeName("long *")] int* plAspectX,
        [NativeTypeName("long *")] int* plAspectY
    )
    {
        return ((delegate* unmanaged<IBasicVideo2, int*, int*, int>)((*lpVtbl)[39]))(
            this,
            plAspectX,
            plAspectY
        );
    }

    public interface Interface : IBasicVideo.Interface
    {
        [VtblIndex(39)]
        HRESULT GetPreferredAspectRatio(
            [NativeTypeName("long *")] int* plAspectX,
            [NativeTypeName("long *")] int* plAspectY
        );
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo*, int> GetTypeInfo;

        [NativeTypeName(
            "HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName(
            "HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            Guid*,
            uint,
            ushort,
            DISPPARAMS*,
            VARIANT*,
            EXCEPINFO*,
            uint*,
            int> Invoke;

        [NativeTypeName("HRESULT (REFTIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_AvgTimePerFrame;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_BitRate;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_BitErrorRate;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_VideoWidth;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_VideoHeight;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_SourceLeft;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_SourceLeft;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_SourceWidth;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_SourceWidth;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_SourceTop;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_SourceTop;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_SourceHeight;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_SourceHeight;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_DestinationLeft;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_DestinationLeft;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_DestinationWidth;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_DestinationWidth;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_DestinationTop;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_DestinationTop;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_DestinationHeight;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_DestinationHeight;

        [NativeTypeName("HRESULT (long, long, long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int, int, int> SetSourcePosition;

        [NativeTypeName("HRESULT (long *, long *, long *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, int*, int*, int> GetSourcePosition;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SetDefaultSourcePosition;

        [NativeTypeName("HRESULT (long, long, long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int, int, int> SetDestinationPosition;

        [NativeTypeName("HRESULT (long *, long *, long *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, int*, int*, int> GetDestinationPosition;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SetDefaultDestinationPosition;

        [NativeTypeName("HRESULT (long *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, int> GetVideoSize;

        [NativeTypeName("HRESULT (long, long, long *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int*, int*, int> GetVideoPaletteEntries;

        [NativeTypeName("HRESULT (long *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, int> GetCurrentImage;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsUsingDefaultSource;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsUsingDefaultDestination;

        [NativeTypeName("HRESULT (long *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, int> GetPreferredAspectRatio;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBasicVideo2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBasicVideo2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IBasicVideo"/> to <see cref = "IBasicVideo2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IBasicVideo"/> instance to be converted </param>
    public static explicit operator IBasicVideo2(Silk.NET.Windows.IBasicVideo value)
    {
        return new IBasicVideo2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBasicVideo2"/> to <see cref = "Silk.NET.Windows.IBasicVideo"/>.</summary>
    /// <param name = "value">The <see cref = "IBasicVideo2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IBasicVideo(IBasicVideo2 value)
    {
        return new Silk.NET.Windows.IBasicVideo(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IBasicVideo2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IBasicVideo2(Silk.NET.Windows.IDispatch value)
    {
        return new IBasicVideo2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBasicVideo2"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IBasicVideo2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IBasicVideo2 value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBasicVideo2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBasicVideo2(Silk.NET.Windows.IUnknown value)
    {
        return new IBasicVideo2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBasicVideo2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBasicVideo2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBasicVideo2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
