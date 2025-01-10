// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("CF51ED10-62FE-11CF-BF86-00A0C9034836")]
[NativeTypeName("struct IQuickActivate : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IQuickActivate : IQuickActivate.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IQuickActivate));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IQuickActivate, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IQuickActivate, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IQuickActivate, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QuickActivate(QACONTAINER* pQaContainer, QACONTROL* pQaControl)
    {
        return ((delegate* unmanaged<IQuickActivate, QACONTAINER*, QACONTROL*, int>)((*lpVtbl)[3]))(
            this,
            pQaContainer,
            pQaControl
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetContentExtent([NativeTypeName("LPSIZEL")] SIZE* pSizel)
    {
        return ((delegate* unmanaged<IQuickActivate, SIZE*, int>)((*lpVtbl)[4]))(this, pSizel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetContentExtent([NativeTypeName("LPSIZEL")] SIZE* pSizel)
    {
        return ((delegate* unmanaged<IQuickActivate, SIZE*, int>)((*lpVtbl)[5]))(this, pSizel);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT QuickActivate(QACONTAINER* pQaContainer, QACONTROL* pQaControl);

        [VtblIndex(4)]
        HRESULT SetContentExtent([NativeTypeName("LPSIZEL")] SIZE* pSizel);

        [VtblIndex(5)]
        HRESULT GetContentExtent([NativeTypeName("LPSIZEL")] SIZE* pSizel);
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

        [NativeTypeName("HRESULT (QACONTAINER *, QACONTROL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, QACONTAINER*, QACONTROL*, int> QuickActivate;

        [NativeTypeName("HRESULT (LPSIZEL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SIZE*, int> SetContentExtent;

        [NativeTypeName("HRESULT (LPSIZEL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SIZE*, int> GetContentExtent;
    }

    /// <summary>Initializes a new instance of the <see cref = "IQuickActivate"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IQuickActivate(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IQuickActivate"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IQuickActivate(Silk.NET.Windows.IUnknown value)
    {
        return new IQuickActivate(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IQuickActivate"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IQuickActivate"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IQuickActivate value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
