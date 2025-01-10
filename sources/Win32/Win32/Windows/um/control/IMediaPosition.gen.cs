// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/control.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("56A868B2-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IMediaPosition : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IMediaPosition : IMediaPosition.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPosition));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaPosition, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaPosition, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaPosition, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IMediaPosition, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<IMediaPosition, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
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
            (delegate* unmanaged<IMediaPosition, Guid*, ushort**, uint, uint, int*, int>)(
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
                IMediaPosition,
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
    public HRESULT get_Duration([NativeTypeName("REFTIME *")] double* plength)
    {
        return ((delegate* unmanaged<IMediaPosition, double*, int>)((*lpVtbl)[7]))(this, plength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_CurrentPosition([NativeTypeName("REFTIME")] double llTime)
    {
        return ((delegate* unmanaged<IMediaPosition, double, int>)((*lpVtbl)[8]))(this, llTime);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CurrentPosition([NativeTypeName("REFTIME *")] double* pllTime)
    {
        return ((delegate* unmanaged<IMediaPosition, double*, int>)((*lpVtbl)[9]))(this, pllTime);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_StopTime([NativeTypeName("REFTIME *")] double* pllTime)
    {
        return ((delegate* unmanaged<IMediaPosition, double*, int>)((*lpVtbl)[10]))(this, pllTime);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_StopTime([NativeTypeName("REFTIME")] double llTime)
    {
        return ((delegate* unmanaged<IMediaPosition, double, int>)((*lpVtbl)[11]))(this, llTime);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_PrerollTime([NativeTypeName("REFTIME *")] double* pllTime)
    {
        return ((delegate* unmanaged<IMediaPosition, double*, int>)((*lpVtbl)[12]))(this, pllTime);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_PrerollTime([NativeTypeName("REFTIME")] double llTime)
    {
        return ((delegate* unmanaged<IMediaPosition, double, int>)((*lpVtbl)[13]))(this, llTime);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_Rate(double dRate)
    {
        return ((delegate* unmanaged<IMediaPosition, double, int>)((*lpVtbl)[14]))(this, dRate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Rate(double* pdRate)
    {
        return ((delegate* unmanaged<IMediaPosition, double*, int>)((*lpVtbl)[15]))(this, pdRate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CanSeekForward([NativeTypeName("LONG *")] int* pCanSeekForward)
    {
        return ((delegate* unmanaged<IMediaPosition, int*, int>)((*lpVtbl)[16]))(
            this,
            pCanSeekForward
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CanSeekBackward([NativeTypeName("LONG *")] int* pCanSeekBackward)
    {
        return ((delegate* unmanaged<IMediaPosition, int*, int>)((*lpVtbl)[17]))(
            this,
            pCanSeekBackward
        );
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_Duration([NativeTypeName("REFTIME *")] double* plength);

        [VtblIndex(8)]
        HRESULT put_CurrentPosition([NativeTypeName("REFTIME")] double llTime);

        [VtblIndex(9)]
        HRESULT get_CurrentPosition([NativeTypeName("REFTIME *")] double* pllTime);

        [VtblIndex(10)]
        HRESULT get_StopTime([NativeTypeName("REFTIME *")] double* pllTime);

        [VtblIndex(11)]
        HRESULT put_StopTime([NativeTypeName("REFTIME")] double llTime);

        [VtblIndex(12)]
        HRESULT get_PrerollTime([NativeTypeName("REFTIME *")] double* pllTime);

        [VtblIndex(13)]
        HRESULT put_PrerollTime([NativeTypeName("REFTIME")] double llTime);

        [VtblIndex(14)]
        HRESULT put_Rate(double dRate);

        [VtblIndex(15)]
        HRESULT get_Rate(double* pdRate);

        [VtblIndex(16)]
        HRESULT CanSeekForward([NativeTypeName("LONG *")] int* pCanSeekForward);

        [VtblIndex(17)]
        HRESULT CanSeekBackward([NativeTypeName("LONG *")] int* pCanSeekBackward);
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
        public delegate* unmanaged<TSelf*, double*, int> get_Duration;

        [NativeTypeName("HRESULT (REFTIME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_CurrentPosition;

        [NativeTypeName("HRESULT (REFTIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_CurrentPosition;

        [NativeTypeName("HRESULT (REFTIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_StopTime;

        [NativeTypeName("HRESULT (REFTIME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_StopTime;

        [NativeTypeName("HRESULT (REFTIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_PrerollTime;

        [NativeTypeName("HRESULT (REFTIME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_PrerollTime;

        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_Rate;

        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_Rate;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> CanSeekForward;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> CanSeekBackward;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaPosition"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaPosition(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IMediaPosition"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IMediaPosition(Silk.NET.Windows.IDispatch value)
    {
        return new IMediaPosition(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaPosition"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaPosition"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IMediaPosition value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaPosition"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaPosition(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaPosition(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaPosition"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaPosition"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaPosition value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
