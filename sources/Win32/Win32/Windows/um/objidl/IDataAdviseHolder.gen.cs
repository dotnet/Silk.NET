// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00000110-0000-0000-C000-000000000046")]
[NativeTypeName("struct IDataAdviseHolder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDataAdviseHolder : IDataAdviseHolder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDataAdviseHolder));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDataAdviseHolder, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDataAdviseHolder, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDataAdviseHolder, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Advise(
        IDataObject pDataObject,
        FORMATETC* pFetc,
        [NativeTypeName("DWORD")] uint advf,
        IAdviseSink pAdvise,
        [NativeTypeName("DWORD *")] uint* pdwConnection
    )
    {
        return (
            (delegate* unmanaged<
                IDataAdviseHolder,
                IDataObject,
                FORMATETC*,
                uint,
                IAdviseSink,
                uint*,
                int>)((*lpVtbl)[3])
        )(this, pDataObject, pFetc, advf, pAdvise, pdwConnection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Unadvise([NativeTypeName("DWORD")] uint dwConnection)
    {
        return ((delegate* unmanaged<IDataAdviseHolder, uint, int>)((*lpVtbl)[4]))(
            this,
            dwConnection
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EnumAdvise(IEnumSTATDATA* ppenumAdvise)
    {
        return ((delegate* unmanaged<IDataAdviseHolder, IEnumSTATDATA*, int>)((*lpVtbl)[5]))(
            this,
            ppenumAdvise
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SendOnDataChange(
        IDataObject pDataObject,
        [NativeTypeName("DWORD")] uint dwReserved,
        [NativeTypeName("DWORD")] uint advf
    )
    {
        return (
            (delegate* unmanaged<IDataAdviseHolder, IDataObject, uint, uint, int>)((*lpVtbl)[6])
        )(this, pDataObject, dwReserved, advf);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Advise(
            IDataObject pDataObject,
            FORMATETC* pFetc,
            [NativeTypeName("DWORD")] uint advf,
            IAdviseSink pAdvise,
            [NativeTypeName("DWORD *")] uint* pdwConnection
        );

        [VtblIndex(4)]
        HRESULT Unadvise([NativeTypeName("DWORD")] uint dwConnection);

        [VtblIndex(5)]
        HRESULT EnumAdvise(IEnumSTATDATA* ppenumAdvise);

        [VtblIndex(6)]
        HRESULT SendOnDataChange(
            IDataObject pDataObject,
            [NativeTypeName("DWORD")] uint dwReserved,
            [NativeTypeName("DWORD")] uint advf
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

        [NativeTypeName(
            "HRESULT (IDataObject *, FORMATETC *, DWORD, IAdviseSink *, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDataObject,
            FORMATETC*,
            uint,
            IAdviseSink,
            uint*,
            int> Advise;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Unadvise;

        [NativeTypeName("HRESULT (IEnumSTATDATA **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumSTATDATA*, int> EnumAdvise;

        [NativeTypeName("HRESULT (IDataObject *, DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDataObject, uint, uint, int> SendOnDataChange;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDataAdviseHolder"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDataAdviseHolder(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDataAdviseHolder"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDataAdviseHolder(Silk.NET.Windows.IUnknown value)
    {
        return new IDataAdviseHolder(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDataAdviseHolder"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDataAdviseHolder"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDataAdviseHolder value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
