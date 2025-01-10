// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3D8B0590-F691-11D2-8EA9-006097DF5BD4")]
[NativeTypeName("struct IDataObjectAsyncCapability : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDataObjectAsyncCapability
    : IDataObjectAsyncCapability.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDataObjectAsyncCapability));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDataObjectAsyncCapability, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDataObjectAsyncCapability, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDataObjectAsyncCapability, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetAsyncMode(BOOL fDoOpAsync)
    {
        return ((delegate* unmanaged<IDataObjectAsyncCapability, BOOL, int>)((*lpVtbl)[3]))(
            this,
            fDoOpAsync
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAsyncMode(BOOL* pfIsOpAsync)
    {
        return ((delegate* unmanaged<IDataObjectAsyncCapability, BOOL*, int>)((*lpVtbl)[4]))(
            this,
            pfIsOpAsync
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT StartOperation(IBindCtx pbcReserved)
    {
        return ((delegate* unmanaged<IDataObjectAsyncCapability, IBindCtx, int>)((*lpVtbl)[5]))(
            this,
            pbcReserved
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT InOperation(BOOL* pfInAsyncOp)
    {
        return ((delegate* unmanaged<IDataObjectAsyncCapability, BOOL*, int>)((*lpVtbl)[6]))(
            this,
            pfInAsyncOp
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT EndOperation(
        HRESULT hResult,
        IBindCtx pbcReserved,
        [NativeTypeName("DWORD")] uint dwEffects
    )
    {
        return (
            (delegate* unmanaged<IDataObjectAsyncCapability, HRESULT, IBindCtx, uint, int>)(
                (*lpVtbl)[7]
            )
        )(this, hResult, pbcReserved, dwEffects);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetAsyncMode(BOOL fDoOpAsync);

        [VtblIndex(4)]
        HRESULT GetAsyncMode(BOOL* pfIsOpAsync);

        [VtblIndex(5)]
        HRESULT StartOperation(IBindCtx pbcReserved);

        [VtblIndex(6)]
        HRESULT InOperation(BOOL* pfInAsyncOp);

        [VtblIndex(7)]
        HRESULT EndOperation(
            HRESULT hResult,
            IBindCtx pbcReserved,
            [NativeTypeName("DWORD")] uint dwEffects
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

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetAsyncMode;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetAsyncMode;

        [NativeTypeName("HRESULT (IBindCtx *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBindCtx, int> StartOperation;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> InOperation;

        [NativeTypeName("HRESULT (HRESULT, IBindCtx *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, IBindCtx, uint, int> EndOperation;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDataObjectAsyncCapability"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDataObjectAsyncCapability(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDataObjectAsyncCapability"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDataObjectAsyncCapability(Silk.NET.Windows.IUnknown value)
    {
        return new IDataObjectAsyncCapability(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDataObjectAsyncCapability"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDataObjectAsyncCapability"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDataObjectAsyncCapability value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
