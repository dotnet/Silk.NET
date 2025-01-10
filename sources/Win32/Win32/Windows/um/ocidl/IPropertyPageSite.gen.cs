// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("B196B28C-BAB4-101A-B69C-00AA00341D07")]
[NativeTypeName("struct IPropertyPageSite : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPropertyPageSite : IPropertyPageSite.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPropertyPageSite));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPropertyPageSite, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPropertyPageSite, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPropertyPageSite, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnStatusChange([NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IPropertyPageSite, uint, int>)((*lpVtbl)[3]))(this, dwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetLocaleID([NativeTypeName("LCID *")] uint* pLocaleID)
    {
        return ((delegate* unmanaged<IPropertyPageSite, uint*, int>)((*lpVtbl)[4]))(
            this,
            pLocaleID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPageContainer(IUnknown* ppUnk)
    {
        return ((delegate* unmanaged<IPropertyPageSite, IUnknown*, int>)((*lpVtbl)[5]))(
            this,
            ppUnk
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT TranslateAccelerator(MSG* pMsg)
    {
        return ((delegate* unmanaged<IPropertyPageSite, MSG*, int>)((*lpVtbl)[6]))(this, pMsg);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnStatusChange([NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(4)]
        HRESULT GetLocaleID([NativeTypeName("LCID *")] uint* pLocaleID);

        [VtblIndex(5)]
        HRESULT GetPageContainer(IUnknown* ppUnk);

        [VtblIndex(6)]
        HRESULT TranslateAccelerator(MSG* pMsg);
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

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> OnStatusChange;

        [NativeTypeName("HRESULT (LCID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetLocaleID;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> GetPageContainer;

        [NativeTypeName("HRESULT (MSG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MSG*, int> TranslateAccelerator;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPropertyPageSite"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPropertyPageSite(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPropertyPageSite"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPropertyPageSite(Silk.NET.Windows.IUnknown value)
    {
        return new IPropertyPageSite(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPropertyPageSite"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPropertyPageSite"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPropertyPageSite value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
