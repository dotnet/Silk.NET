// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0E6B3F66-98D1-48C0-A222-FBDE74E2FBC5")]
[NativeTypeName("struct IWebWizardExtension : IWizardExtension")]
[NativeInheritance("IWizardExtension")]
public unsafe partial struct IWebWizardExtension : IWebWizardExtension.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebWizardExtension));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWebWizardExtension, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWebWizardExtension, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWebWizardExtension, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddPages(HPROPSHEETPAGE* aPages, uint cPages, uint* pnPagesAdded)
    {
        return (
            (delegate* unmanaged<IWebWizardExtension, HPROPSHEETPAGE*, uint, uint*, int>)(
                (*lpVtbl)[3]
            )
        )(this, aPages, cPages, pnPagesAdded);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFirstPage(HPROPSHEETPAGE* phpage)
    {
        return ((delegate* unmanaged<IWebWizardExtension, HPROPSHEETPAGE*, int>)((*lpVtbl)[4]))(
            this,
            phpage
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetLastPage(HPROPSHEETPAGE* phpage)
    {
        return ((delegate* unmanaged<IWebWizardExtension, HPROPSHEETPAGE*, int>)((*lpVtbl)[5]))(
            this,
            phpage
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetInitialURL([NativeTypeName("LPCWSTR")] ushort* pszURL)
    {
        return ((delegate* unmanaged<IWebWizardExtension, ushort*, int>)((*lpVtbl)[6]))(
            this,
            pszURL
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetErrorURL([NativeTypeName("LPCWSTR")] ushort* pszErrorURL)
    {
        return ((delegate* unmanaged<IWebWizardExtension, ushort*, int>)((*lpVtbl)[7]))(
            this,
            pszErrorURL
        );
    }

    public interface Interface : IWizardExtension.Interface
    {
        [VtblIndex(6)]
        HRESULT SetInitialURL([NativeTypeName("LPCWSTR")] ushort* pszURL);

        [VtblIndex(7)]
        HRESULT SetErrorURL([NativeTypeName("LPCWSTR")] ushort* pszErrorURL);
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

        [NativeTypeName("HRESULT (HPROPSHEETPAGE *, UINT, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HPROPSHEETPAGE*, uint, uint*, int> AddPages;

        [NativeTypeName("HRESULT (HPROPSHEETPAGE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HPROPSHEETPAGE*, int> GetFirstPage;

        [NativeTypeName("HRESULT (HPROPSHEETPAGE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HPROPSHEETPAGE*, int> GetLastPage;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetInitialURL;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetErrorURL;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWebWizardExtension"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWebWizardExtension(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IWizardExtension"/> to <see cref = "IWebWizardExtension"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IWizardExtension"/> instance to be converted </param>
    public static explicit operator IWebWizardExtension(Silk.NET.Windows.IWizardExtension value)
    {
        return new IWebWizardExtension(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebWizardExtension"/> to <see cref = "Silk.NET.Windows.IWizardExtension"/>.</summary>
    /// <param name = "value">The <see cref = "IWebWizardExtension"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IWizardExtension(IWebWizardExtension value)
    {
        return new Silk.NET.Windows.IWizardExtension(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWebWizardExtension"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWebWizardExtension(Silk.NET.Windows.IUnknown value)
    {
        return new IWebWizardExtension(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebWizardExtension"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWebWizardExtension"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWebWizardExtension value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
