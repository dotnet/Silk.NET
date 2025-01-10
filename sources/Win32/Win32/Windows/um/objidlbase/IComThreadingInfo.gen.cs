// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("000001CE-0000-0000-C000-000000000046")]
[NativeTypeName("struct IComThreadingInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IComThreadingInfo : IComThreadingInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IComThreadingInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IComThreadingInfo, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IComThreadingInfo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IComThreadingInfo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCurrentApartmentType(APTTYPE* pAptType)
    {
        return ((delegate* unmanaged<IComThreadingInfo, APTTYPE*, int>)((*lpVtbl)[3]))(
            this,
            pAptType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCurrentThreadType(THDTYPE* pThreadType)
    {
        return ((delegate* unmanaged<IComThreadingInfo, THDTYPE*, int>)((*lpVtbl)[4]))(
            this,
            pThreadType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCurrentLogicalThreadId(Guid* pguidLogicalThreadId)
    {
        return ((delegate* unmanaged<IComThreadingInfo, Guid*, int>)((*lpVtbl)[5]))(
            this,
            pguidLogicalThreadId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetCurrentLogicalThreadId([NativeTypeName("const GUID &")] Guid* rguid)
    {
        return ((delegate* unmanaged<IComThreadingInfo, Guid*, int>)((*lpVtbl)[6]))(this, rguid);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCurrentApartmentType(APTTYPE* pAptType);

        [VtblIndex(4)]
        HRESULT GetCurrentThreadType(THDTYPE* pThreadType);

        [VtblIndex(5)]
        HRESULT GetCurrentLogicalThreadId(Guid* pguidLogicalThreadId);

        [VtblIndex(6)]
        HRESULT SetCurrentLogicalThreadId([NativeTypeName("const GUID &")] Guid* rguid);
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

        [NativeTypeName("HRESULT (APTTYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, APTTYPE*, int> GetCurrentApartmentType;

        [NativeTypeName("HRESULT (THDTYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, THDTYPE*, int> GetCurrentThreadType;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetCurrentLogicalThreadId;

        [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> SetCurrentLogicalThreadId;
    }

    /// <summary>Initializes a new instance of the <see cref = "IComThreadingInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IComThreadingInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IComThreadingInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IComThreadingInfo(Silk.NET.Windows.IUnknown value)
    {
        return new IComThreadingInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IComThreadingInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IComThreadingInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IComThreadingInfo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
