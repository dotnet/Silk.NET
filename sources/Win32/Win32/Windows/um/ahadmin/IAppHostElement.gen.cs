// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("64FF8CCC-B287-4DAE-B08A-A72CBF45F453")]
[NativeTypeName("struct IAppHostElement : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostElement : IAppHostElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostElement));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppHostElement, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppHostElement, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppHostElement, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Name([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<IAppHostElement, ushort**, int>)((*lpVtbl)[3]))(
            this,
            pbstrName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Collection(IAppHostElementCollection* ppCollection)
    {
        return (
            (delegate* unmanaged<IAppHostElement, IAppHostElementCollection*, int>)((*lpVtbl)[4])
        )(this, ppCollection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_Properties(IAppHostPropertyCollection* ppProperties)
    {
        return (
            (delegate* unmanaged<IAppHostElement, IAppHostPropertyCollection*, int>)((*lpVtbl)[5])
        )(this, ppProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ChildElements(IAppHostChildElementCollection* ppElements)
    {
        return (
            (delegate* unmanaged<IAppHostElement, IAppHostChildElementCollection*, int>)(
                (*lpVtbl)[6]
            )
        )(this, ppElements);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetMetadata([NativeTypeName("BSTR")] ushort* bstrMetadataType, VARIANT* pValue)
    {
        return ((delegate* unmanaged<IAppHostElement, ushort*, VARIANT*, int>)((*lpVtbl)[7]))(
            this,
            bstrMetadataType,
            pValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetMetadata([NativeTypeName("BSTR")] ushort* bstrMetadataType, VARIANT value)
    {
        return ((delegate* unmanaged<IAppHostElement, ushort*, VARIANT, int>)((*lpVtbl)[8]))(
            this,
            bstrMetadataType,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Schema(IAppHostElementSchema* ppSchema)
    {
        return ((delegate* unmanaged<IAppHostElement, IAppHostElementSchema*, int>)((*lpVtbl)[9]))(
            this,
            ppSchema
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetElementByName(
        [NativeTypeName("BSTR")] ushort* bstrSubName,
        IAppHostElement* ppElement
    )
    {
        return (
            (delegate* unmanaged<IAppHostElement, ushort*, IAppHostElement*, int>)((*lpVtbl)[10])
        )(this, bstrSubName, ppElement);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetPropertyByName(
        [NativeTypeName("BSTR")] ushort* bstrSubName,
        IAppHostProperty* ppProperty
    )
    {
        return (
            (delegate* unmanaged<IAppHostElement, ushort*, IAppHostProperty*, int>)((*lpVtbl)[11])
        )(this, bstrSubName, ppProperty);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Clear()
    {
        return ((delegate* unmanaged<IAppHostElement, int>)((*lpVtbl)[12]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Methods(IAppHostMethodCollection* ppMethods)
    {
        return (
            (delegate* unmanaged<IAppHostElement, IAppHostMethodCollection*, int>)((*lpVtbl)[13])
        )(this, ppMethods);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Name([NativeTypeName("BSTR *")] ushort** pbstrName);

        [VtblIndex(4)]
        HRESULT get_Collection(IAppHostElementCollection* ppCollection);

        [VtblIndex(5)]
        HRESULT get_Properties(IAppHostPropertyCollection* ppProperties);

        [VtblIndex(6)]
        HRESULT get_ChildElements(IAppHostChildElementCollection* ppElements);

        [VtblIndex(7)]
        HRESULT GetMetadata([NativeTypeName("BSTR")] ushort* bstrMetadataType, VARIANT* pValue);

        [VtblIndex(8)]
        HRESULT SetMetadata([NativeTypeName("BSTR")] ushort* bstrMetadataType, VARIANT value);

        [VtblIndex(9)]
        HRESULT get_Schema(IAppHostElementSchema* ppSchema);

        [VtblIndex(10)]
        HRESULT GetElementByName(
            [NativeTypeName("BSTR")] ushort* bstrSubName,
            IAppHostElement* ppElement
        );

        [VtblIndex(11)]
        HRESULT GetPropertyByName(
            [NativeTypeName("BSTR")] ushort* bstrSubName,
            IAppHostProperty* ppProperty
        );

        [VtblIndex(12)]
        HRESULT Clear();

        [VtblIndex(13)]
        HRESULT get_Methods(IAppHostMethodCollection* ppMethods);
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Name;

        [NativeTypeName("HRESULT (IAppHostElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppHostElementCollection*, int> get_Collection;

        [NativeTypeName("HRESULT (IAppHostPropertyCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppHostPropertyCollection*, int> get_Properties;

        [NativeTypeName("HRESULT (IAppHostChildElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppHostChildElementCollection*, int> get_ChildElements;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> GetMetadata;

        [NativeTypeName("HRESULT (BSTR, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT, int> SetMetadata;

        [NativeTypeName("HRESULT (IAppHostElementSchema **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppHostElementSchema*, int> get_Schema;

        [NativeTypeName("HRESULT (BSTR, IAppHostElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IAppHostElement*, int> GetElementByName;

        [NativeTypeName("HRESULT (BSTR, IAppHostProperty **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IAppHostProperty*, int> GetPropertyByName;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Clear;

        [NativeTypeName("HRESULT (IAppHostMethodCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppHostMethodCollection*, int> get_Methods;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppHostElement"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppHostElement(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppHostElement"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppHostElement(Silk.NET.Windows.IUnknown value)
    {
        return new IAppHostElement(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppHostElement"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppHostElement"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppHostElement value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
