// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("88960F5B-422F-4E7B-8013-73415381C3C3")]
[NativeTypeName("struct IWizardSite : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWizardSite : IWizardSite.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWizardSite));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWizardSite, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWizardSite, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWizardSite, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPreviousPage(HPROPSHEETPAGE* phpage)
    {
        return ((delegate* unmanaged<IWizardSite, HPROPSHEETPAGE*, int>)((*lpVtbl)[3]))(
            this,
            phpage
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetNextPage(HPROPSHEETPAGE* phpage)
    {
        return ((delegate* unmanaged<IWizardSite, HPROPSHEETPAGE*, int>)((*lpVtbl)[4]))(
            this,
            phpage
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCancelledPage(HPROPSHEETPAGE* phpage)
    {
        return ((delegate* unmanaged<IWizardSite, HPROPSHEETPAGE*, int>)((*lpVtbl)[5]))(
            this,
            phpage
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetPreviousPage(HPROPSHEETPAGE* phpage);

        [VtblIndex(4)]
        HRESULT GetNextPage(HPROPSHEETPAGE* phpage);

        [VtblIndex(5)]
        HRESULT GetCancelledPage(HPROPSHEETPAGE* phpage);
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

        [NativeTypeName("HRESULT (HPROPSHEETPAGE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HPROPSHEETPAGE*, int> GetPreviousPage;

        [NativeTypeName("HRESULT (HPROPSHEETPAGE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HPROPSHEETPAGE*, int> GetNextPage;

        [NativeTypeName("HRESULT (HPROPSHEETPAGE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HPROPSHEETPAGE*, int> GetCancelledPage;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWizardSite"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWizardSite(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWizardSite"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWizardSite(Silk.NET.Windows.IUnknown value)
    {
        return new IWizardSite(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWizardSite"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWizardSite"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWizardSite value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
