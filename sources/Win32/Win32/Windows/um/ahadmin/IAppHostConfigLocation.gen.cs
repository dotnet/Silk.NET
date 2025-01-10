// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("370AF178-7758-4DAD-8146-7391F6E18585")]
[NativeTypeName("struct IAppHostConfigLocation : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostConfigLocation : IAppHostConfigLocation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostConfigLocation));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppHostConfigLocation, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppHostConfigLocation, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppHostConfigLocation, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Path([NativeTypeName("BSTR *")] ushort** pbstrLocationPath)
    {
        return ((delegate* unmanaged<IAppHostConfigLocation, ushort**, int>)((*lpVtbl)[3]))(
            this,
            pbstrLocationPath
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Count([NativeTypeName("DWORD *")] uint* pcCount)
    {
        return ((delegate* unmanaged<IAppHostConfigLocation, uint*, int>)((*lpVtbl)[4]))(
            this,
            pcCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_Item(VARIANT cIndex, IAppHostElement* ppSection)
    {
        return (
            (delegate* unmanaged<IAppHostConfigLocation, VARIANT, IAppHostElement*, int>)(
                (*lpVtbl)[5]
            )
        )(this, cIndex, ppSection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddConfigSection(
        [NativeTypeName("BSTR")] ushort* bstrSectionName,
        IAppHostElement* ppAdminElement
    )
    {
        return (
            (delegate* unmanaged<IAppHostConfigLocation, ushort*, IAppHostElement*, int>)(
                (*lpVtbl)[6]
            )
        )(this, bstrSectionName, ppAdminElement);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT DeleteConfigSection(VARIANT cIndex)
    {
        return ((delegate* unmanaged<IAppHostConfigLocation, VARIANT, int>)((*lpVtbl)[7]))(
            this,
            cIndex
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Path([NativeTypeName("BSTR *")] ushort** pbstrLocationPath);

        [VtblIndex(4)]
        HRESULT get_Count([NativeTypeName("DWORD *")] uint* pcCount);

        [VtblIndex(5)]
        HRESULT get_Item(VARIANT cIndex, IAppHostElement* ppSection);

        [VtblIndex(6)]
        HRESULT AddConfigSection(
            [NativeTypeName("BSTR")] ushort* bstrSectionName,
            IAppHostElement* ppAdminElement
        );

        [VtblIndex(7)]
        HRESULT DeleteConfigSection(VARIANT cIndex);
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
        public delegate* unmanaged<TSelf*, ushort**, int> get_Path;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_Count;

        [NativeTypeName("HRESULT (VARIANT, IAppHostElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, IAppHostElement*, int> get_Item;

        [NativeTypeName("HRESULT (BSTR, IAppHostElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IAppHostElement*, int> AddConfigSection;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> DeleteConfigSection;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppHostConfigLocation"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppHostConfigLocation(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppHostConfigLocation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppHostConfigLocation(Silk.NET.Windows.IUnknown value)
    {
        return new IAppHostConfigLocation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppHostConfigLocation"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppHostConfigLocation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppHostConfigLocation value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
