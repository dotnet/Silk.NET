// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IPublishingWizard.xml' path='doc/member[@name="IPublishingWizard"]/*'/>
[Guid("AA9198BB-CCEC-472D-BEED-19A4F6733F7A")]
[NativeTypeName("struct IPublishingWizard : IWizardExtension")]
[NativeInheritance("IWizardExtension")]
public unsafe partial struct IPublishingWizard : IPublishingWizard.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPublishingWizard));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPublishingWizard*, Guid*, void**, int> )(lpVtbl[0]))((IPublishingWizard*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPublishingWizard*, uint> )(lpVtbl[1]))((IPublishingWizard*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPublishingWizard*, uint> )(lpVtbl[2]))((IPublishingWizard*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IWizardExtension.AddPages"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddPages(HPROPSHEETPAGE* aPages, uint cPages, uint* pnPagesAdded)
    {
        return ((delegate* unmanaged<IPublishingWizard*, HPROPSHEETPAGE*, uint, uint*, int> )(lpVtbl[3]))((IPublishingWizard*)Unsafe.AsPointer(ref this), aPages, cPages, pnPagesAdded);
    }

    /// <inheritdoc cref = "IWizardExtension.GetFirstPage"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFirstPage(HPROPSHEETPAGE* phpage)
    {
        return ((delegate* unmanaged<IPublishingWizard*, HPROPSHEETPAGE*, int> )(lpVtbl[4]))((IPublishingWizard*)Unsafe.AsPointer(ref this), phpage);
    }

    /// <inheritdoc cref = "IWizardExtension.GetLastPage"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetLastPage(HPROPSHEETPAGE* phpage)
    {
        return ((delegate* unmanaged<IPublishingWizard*, HPROPSHEETPAGE*, int> )(lpVtbl[5]))((IPublishingWizard*)Unsafe.AsPointer(ref this), phpage);
    }

    /// <include file='IPublishingWizard.xml' path='doc/member[@name="IPublishingWizard.Initialize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Initialize(IDataObject* pdo, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("LPCWSTR")] ushort* pszServiceScope)
    {
        return ((delegate* unmanaged<IPublishingWizard*, IDataObject*, uint, ushort*, int> )(lpVtbl[6]))((IPublishingWizard*)Unsafe.AsPointer(ref this), pdo, dwOptions, pszServiceScope);
    }

    /// <include file='IPublishingWizard.xml' path='doc/member[@name="IPublishingWizard.GetTransferManifest"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetTransferManifest(HRESULT* phrFromTransfer, IXMLDOMDocument** pdocManifest)
    {
        return ((delegate* unmanaged<IPublishingWizard*, HRESULT*, IXMLDOMDocument**, int> )(lpVtbl[7]))((IPublishingWizard*)Unsafe.AsPointer(ref this), phrFromTransfer, pdocManifest);
    }

    public interface Interface : IWizardExtension.Interface
    {
        [VtblIndex(6)]
        HRESULT Initialize(IDataObject* pdo, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("LPCWSTR")] ushort* pszServiceScope);
        [VtblIndex(7)]
        HRESULT GetTransferManifest(HRESULT* phrFromTransfer, IXMLDOMDocument** pdocManifest);
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
        [NativeTypeName("HRESULT (IDataObject *, DWORD, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDataObject*, uint, ushort*, int> Initialize;
        [NativeTypeName("HRESULT (HRESULT *, IXMLDOMDocument **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT*, IXMLDOMDocument**, int> GetTransferManifest;
    }
}