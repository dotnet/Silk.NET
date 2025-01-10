// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3050F489-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IElementBehaviorSiteOM : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IElementBehaviorSiteOM : IElementBehaviorSiteOM.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IElementBehaviorSiteOM));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IElementBehaviorSiteOM, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IElementBehaviorSiteOM, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IElementBehaviorSiteOM, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterEvent(
        [NativeTypeName("LPOLESTR")] ushort* pchEvent,
        [NativeTypeName("LONG")] int lFlags,
        [NativeTypeName("LONG *")] int* plCookie
    )
    {
        return (
            (delegate* unmanaged<IElementBehaviorSiteOM, ushort*, int, int*, int>)((*lpVtbl)[3])
        )(this, pchEvent, lFlags, plCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetEventCookie(
        [NativeTypeName("LPOLESTR")] ushort* pchEvent,
        [NativeTypeName("LONG *")] int* plCookie
    )
    {
        return ((delegate* unmanaged<IElementBehaviorSiteOM, ushort*, int*, int>)((*lpVtbl)[4]))(
            this,
            pchEvent,
            plCookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT FireEvent([NativeTypeName("LONG")] int lCookie, IHTMLEventObj pEventObject)
    {
        return (
            (delegate* unmanaged<IElementBehaviorSiteOM, int, IHTMLEventObj, int>)((*lpVtbl)[5])
        )(this, lCookie, pEventObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateEventObject(IHTMLEventObj* ppEventObject)
    {
        return ((delegate* unmanaged<IElementBehaviorSiteOM, IHTMLEventObj*, int>)((*lpVtbl)[6]))(
            this,
            ppEventObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RegisterName([NativeTypeName("LPOLESTR")] ushort* pchName)
    {
        return ((delegate* unmanaged<IElementBehaviorSiteOM, ushort*, int>)((*lpVtbl)[7]))(
            this,
            pchName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RegisterUrn([NativeTypeName("LPOLESTR")] ushort* pchUrn)
    {
        return ((delegate* unmanaged<IElementBehaviorSiteOM, ushort*, int>)((*lpVtbl)[8]))(
            this,
            pchUrn
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RegisterEvent(
            [NativeTypeName("LPOLESTR")] ushort* pchEvent,
            [NativeTypeName("LONG")] int lFlags,
            [NativeTypeName("LONG *")] int* plCookie
        );

        [VtblIndex(4)]
        HRESULT GetEventCookie(
            [NativeTypeName("LPOLESTR")] ushort* pchEvent,
            [NativeTypeName("LONG *")] int* plCookie
        );

        [VtblIndex(5)]
        HRESULT FireEvent([NativeTypeName("LONG")] int lCookie, IHTMLEventObj pEventObject);

        [VtblIndex(6)]
        HRESULT CreateEventObject(IHTMLEventObj* ppEventObject);

        [VtblIndex(7)]
        HRESULT RegisterName([NativeTypeName("LPOLESTR")] ushort* pchName);

        [VtblIndex(8)]
        HRESULT RegisterUrn([NativeTypeName("LPOLESTR")] ushort* pchUrn);
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

        [NativeTypeName("HRESULT (LPOLESTR, LONG, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, int*, int> RegisterEvent;

        [NativeTypeName("HRESULT (LPOLESTR, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int*, int> GetEventCookie;

        [NativeTypeName("HRESULT (LONG, IHTMLEventObj *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, IHTMLEventObj, int> FireEvent;

        [NativeTypeName("HRESULT (IHTMLEventObj **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLEventObj*, int> CreateEventObject;

        [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> RegisterName;

        [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> RegisterUrn;
    }

    /// <summary>Initializes a new instance of the <see cref = "IElementBehaviorSiteOM"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IElementBehaviorSiteOM(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IElementBehaviorSiteOM"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IElementBehaviorSiteOM(Silk.NET.Windows.IUnknown value)
    {
        return new IElementBehaviorSiteOM(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IElementBehaviorSiteOM"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IElementBehaviorSiteOM"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IElementBehaviorSiteOM value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
