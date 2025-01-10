// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("27354151-7F64-5B0F-8F00-5D77AFBE261E")]
[NativeTypeName("struct IMultisessionSequential : IMultisession")]
[NativeInheritance("IMultisession")]
public unsafe partial struct IMultisessionSequential
    : IMultisessionSequential.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMultisessionSequential));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMultisessionSequential, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMultisessionSequential, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMultisessionSequential, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IMultisessionSequential, uint*, int>)((*lpVtbl)[3]))(
            this,
            pctinfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<IMultisessionSequential, uint, uint, ITypeInfo*, int>)(
                (*lpVtbl)[4]
            )
        )(this, iTInfo, lcid, ppTInfo);
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
            (delegate* unmanaged<IMultisessionSequential, Guid*, ushort**, uint, uint, int*, int>)(
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
                IMultisessionSequential,
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
    public HRESULT get_IsSupportedOnCurrentMediaState(
        [NativeTypeName("VARIANT_BOOL *")] short* value
    )
    {
        return ((delegate* unmanaged<IMultisessionSequential, short*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_InUse([NativeTypeName("VARIANT_BOOL")] short value)
    {
        return ((delegate* unmanaged<IMultisessionSequential, short, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_InUse([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IMultisessionSequential, short*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ImportRecorder(IDiscRecorder2* value)
    {
        return (
            (delegate* unmanaged<IMultisessionSequential, IDiscRecorder2*, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_IsFirstDataSession([NativeTypeName("VARIANT_BOOL *")] short* value)
    {
        return ((delegate* unmanaged<IMultisessionSequential, short*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_StartAddressOfPreviousSession([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IMultisessionSequential, int*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_LastWrittenAddressOfPreviousSession([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IMultisessionSequential, int*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_NextWritableAddress([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IMultisessionSequential, int*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_FreeSectorsOnMedia([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IMultisessionSequential, int*, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    public interface Interface : IMultisession.Interface
    {
        [VtblIndex(11)]
        HRESULT get_IsFirstDataSession([NativeTypeName("VARIANT_BOOL *")] short* value);

        [VtblIndex(12)]
        HRESULT get_StartAddressOfPreviousSession([NativeTypeName("LONG *")] int* value);

        [VtblIndex(13)]
        HRESULT get_LastWrittenAddressOfPreviousSession([NativeTypeName("LONG *")] int* value);

        [VtblIndex(14)]
        HRESULT get_NextWritableAddress([NativeTypeName("LONG *")] int* value);

        [VtblIndex(15)]
        HRESULT get_FreeSectorsOnMedia([NativeTypeName("LONG *")] int* value);
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

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_IsSupportedOnCurrentMediaState;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_InUse;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_InUse;

        [NativeTypeName("HRESULT (IDiscRecorder2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiscRecorder2*, int> get_ImportRecorder;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_IsFirstDataSession;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_StartAddressOfPreviousSession;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_LastWrittenAddressOfPreviousSession;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_NextWritableAddress;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_FreeSectorsOnMedia;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMultisessionSequential"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMultisessionSequential(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMultisession"/> to <see cref = "IMultisessionSequential"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMultisession"/> instance to be converted </param>
    public static explicit operator IMultisessionSequential(Silk.NET.Windows.IMultisession value)
    {
        return new IMultisessionSequential(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMultisessionSequential"/> to <see cref = "Silk.NET.Windows.IMultisession"/>.</summary>
    /// <param name = "value">The <see cref = "IMultisessionSequential"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMultisession(IMultisessionSequential value)
    {
        return new Silk.NET.Windows.IMultisession(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IMultisessionSequential"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IMultisessionSequential(Silk.NET.Windows.IDispatch value)
    {
        return new IMultisessionSequential(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMultisessionSequential"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IMultisessionSequential"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IMultisessionSequential value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMultisessionSequential"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMultisessionSequential(Silk.NET.Windows.IUnknown value)
    {
        return new IMultisessionSequential(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMultisessionSequential"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMultisessionSequential"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMultisessionSequential value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
