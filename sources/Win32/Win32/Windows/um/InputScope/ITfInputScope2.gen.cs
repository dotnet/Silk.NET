// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InputScope.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("5731EAA0-6BC2-4681-A532-92FBB74D7C41")]
[NativeTypeName("struct ITfInputScope2 : ITfInputScope")]
[NativeInheritance("ITfInputScope")]
public unsafe partial struct ITfInputScope2 : ITfInputScope2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfInputScope2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfInputScope2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfInputScope2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfInputScope2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetInputScopes(InputScope** pprgInputScopes, uint* pcCount)
    {
        return ((delegate* unmanaged<ITfInputScope2, InputScope**, uint*, int>)((*lpVtbl)[3]))(
            this,
            pprgInputScopes,
            pcCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPhrase([NativeTypeName("BSTR **")] ushort*** ppbstrPhrases, uint* pcCount)
    {
        return ((delegate* unmanaged<ITfInputScope2, ushort***, uint*, int>)((*lpVtbl)[4]))(
            this,
            ppbstrPhrases,
            pcCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetRegularExpression([NativeTypeName("BSTR *")] ushort** pbstrRegExp)
    {
        return ((delegate* unmanaged<ITfInputScope2, ushort**, int>)((*lpVtbl)[5]))(
            this,
            pbstrRegExp
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSRGS([NativeTypeName("BSTR *")] ushort** pbstrSRGS)
    {
        return ((delegate* unmanaged<ITfInputScope2, ushort**, int>)((*lpVtbl)[6]))(
            this,
            pbstrSRGS
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetXML([NativeTypeName("BSTR *")] ushort** pbstrXML)
    {
        return ((delegate* unmanaged<ITfInputScope2, ushort**, int>)((*lpVtbl)[7]))(this, pbstrXML);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT EnumWordList(IEnumString* ppEnumString)
    {
        return ((delegate* unmanaged<ITfInputScope2, IEnumString*, int>)((*lpVtbl)[8]))(
            this,
            ppEnumString
        );
    }

    public interface Interface : ITfInputScope.Interface
    {
        [VtblIndex(8)]
        HRESULT EnumWordList(IEnumString* ppEnumString);
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

        [NativeTypeName("HRESULT (InputScope **, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, InputScope**, uint*, int> GetInputScopes;

        [NativeTypeName("HRESULT (BSTR **, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort***, uint*, int> GetPhrase;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetRegularExpression;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetSRGS;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetXML;

        [NativeTypeName("HRESULT (IEnumString **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumString*, int> EnumWordList;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfInputScope2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfInputScope2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ITfInputScope"/> to <see cref = "ITfInputScope2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ITfInputScope"/> instance to be converted </param>
    public static explicit operator ITfInputScope2(Silk.NET.Windows.ITfInputScope value)
    {
        return new ITfInputScope2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfInputScope2"/> to <see cref = "Silk.NET.Windows.ITfInputScope"/>.</summary>
    /// <param name = "value">The <see cref = "ITfInputScope2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ITfInputScope(ITfInputScope2 value)
    {
        return new Silk.NET.Windows.ITfInputScope(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfInputScope2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfInputScope2(Silk.NET.Windows.IUnknown value)
    {
        return new ITfInputScope2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfInputScope2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfInputScope2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfInputScope2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
