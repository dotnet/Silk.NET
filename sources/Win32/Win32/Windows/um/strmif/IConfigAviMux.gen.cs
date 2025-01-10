// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("5ACD6AA0-F482-11CE-8B67-00AA00A3F1A6")]
[NativeTypeName("struct IConfigAviMux : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IConfigAviMux : IConfigAviMux.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IConfigAviMux));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IConfigAviMux, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IConfigAviMux, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IConfigAviMux, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetMasterStream([NativeTypeName("LONG")] int iStream)
    {
        return ((delegate* unmanaged<IConfigAviMux, int, int>)((*lpVtbl)[3]))(this, iStream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMasterStream([NativeTypeName("LONG *")] int* pStream)
    {
        return ((delegate* unmanaged<IConfigAviMux, int*, int>)((*lpVtbl)[4]))(this, pStream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetOutputCompatibilityIndex(BOOL fOldIndex)
    {
        return ((delegate* unmanaged<IConfigAviMux, BOOL, int>)((*lpVtbl)[5]))(this, fOldIndex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetOutputCompatibilityIndex(BOOL* pfOldIndex)
    {
        return ((delegate* unmanaged<IConfigAviMux, BOOL*, int>)((*lpVtbl)[6]))(this, pfOldIndex);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetMasterStream([NativeTypeName("LONG")] int iStream);

        [VtblIndex(4)]
        HRESULT GetMasterStream([NativeTypeName("LONG *")] int* pStream);

        [VtblIndex(5)]
        HRESULT SetOutputCompatibilityIndex(BOOL fOldIndex);

        [VtblIndex(6)]
        HRESULT GetOutputCompatibilityIndex(BOOL* pfOldIndex);
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

        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> SetMasterStream;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetMasterStream;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetOutputCompatibilityIndex;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetOutputCompatibilityIndex;
    }

    /// <summary>Initializes a new instance of the <see cref = "IConfigAviMux"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IConfigAviMux(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IConfigAviMux"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IConfigAviMux(Silk.NET.Windows.IUnknown value)
    {
        return new IConfigAviMux(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IConfigAviMux"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IConfigAviMux"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IConfigAviMux value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
