// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("305106E2-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISurfacePresenter : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISurfacePresenter : ISurfacePresenter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISurfacePresenter));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISurfacePresenter, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISurfacePresenter, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISurfacePresenter, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Present(uint uBuffer, RECT* pDirty)
    {
        return ((delegate* unmanaged<ISurfacePresenter, uint, RECT*, int>)((*lpVtbl)[3]))(
            this,
            uBuffer,
            pDirty
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetBuffer(
        uint backBufferIndex,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppBuffer
    )
    {
        return ((delegate* unmanaged<ISurfacePresenter, uint, Guid*, void**, int>)((*lpVtbl)[4]))(
            this,
            backBufferIndex,
            riid,
            ppBuffer
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT IsCurrent(BOOL* pIsCurrent)
    {
        return ((delegate* unmanaged<ISurfacePresenter, BOOL*, int>)((*lpVtbl)[5]))(
            this,
            pIsCurrent
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Present(uint uBuffer, RECT* pDirty);

        [VtblIndex(4)]
        HRESULT GetBuffer(
            uint backBufferIndex,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppBuffer
        );

        [VtblIndex(5)]
        HRESULT IsCurrent(BOOL* pIsCurrent);
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

        [NativeTypeName("HRESULT (UINT, RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, RECT*, int> Present;

        [NativeTypeName("HRESULT (UINT, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, void**, int> GetBuffer;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsCurrent;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISurfacePresenter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISurfacePresenter(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISurfacePresenter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISurfacePresenter(Silk.NET.Windows.IUnknown value)
    {
        return new ISurfacePresenter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISurfacePresenter"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISurfacePresenter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISurfacePresenter value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
