// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ObjectArray.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("5632B1A4-E38A-400A-928A-D4CD63230295")]
[NativeTypeName("struct IObjectCollection : IObjectArray")]
[NativeInheritance("IObjectArray")]
public unsafe partial struct IObjectCollection : IObjectCollection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IObjectCollection));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IObjectCollection, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IObjectCollection, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IObjectCollection, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCount(uint* pcObjects)
    {
        return ((delegate* unmanaged<IObjectCollection, uint*, int>)((*lpVtbl)[3]))(
            this,
            pcObjects
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAt(uint uiIndex, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IObjectCollection, uint, Guid*, void**, int>)((*lpVtbl)[4]))(
            this,
            uiIndex,
            riid,
            ppv
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddObject(IUnknown punk)
    {
        return ((delegate* unmanaged<IObjectCollection, IUnknown, int>)((*lpVtbl)[5]))(this, punk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddFromArray(IObjectArray poaSource)
    {
        return ((delegate* unmanaged<IObjectCollection, IObjectArray, int>)((*lpVtbl)[6]))(
            this,
            poaSource
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RemoveObjectAt(uint uiIndex)
    {
        return ((delegate* unmanaged<IObjectCollection, uint, int>)((*lpVtbl)[7]))(this, uiIndex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Clear()
    {
        return ((delegate* unmanaged<IObjectCollection, int>)((*lpVtbl)[8]))(this);
    }

    public interface Interface : IObjectArray.Interface
    {
        [VtblIndex(5)]
        HRESULT AddObject(IUnknown punk);

        [VtblIndex(6)]
        HRESULT AddFromArray(IObjectArray poaSource);

        [VtblIndex(7)]
        HRESULT RemoveObjectAt(uint uiIndex);

        [VtblIndex(8)]
        HRESULT Clear();
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCount;

        [NativeTypeName("HRESULT (UINT, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, void**, int> GetAt;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> AddObject;

        [NativeTypeName("HRESULT (IObjectArray *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IObjectArray, int> AddFromArray;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> RemoveObjectAt;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Clear;
    }

    /// <summary>Initializes a new instance of the <see cref = "IObjectCollection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IObjectCollection(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IObjectArray"/> to <see cref = "IObjectCollection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IObjectArray"/> instance to be converted </param>
    public static explicit operator IObjectCollection(Silk.NET.Windows.IObjectArray value)
    {
        return new IObjectCollection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IObjectCollection"/> to <see cref = "Silk.NET.Windows.IObjectArray"/>.</summary>
    /// <param name = "value">The <see cref = "IObjectCollection"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IObjectArray(IObjectCollection value)
    {
        return new Silk.NET.Windows.IObjectArray(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IObjectCollection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IObjectCollection(Silk.NET.Windows.IUnknown value)
    {
        return new IObjectCollection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IObjectCollection"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IObjectCollection"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IObjectCollection value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
