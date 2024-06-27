// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras;

public unsafe static class PropertySetStorageVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPropertySetStorage> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPropertySetStorage> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPropertySetStorage> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPropertySetStorage> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IPropertySetStorage> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IPropertySetStorage> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Create(this ComPtr<IPropertySetStorage> thisVtbl, Guid* rfmtid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pclsid, uint grfFlags, uint grfMode, IPropertyStorage** ppprstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, Guid*, uint, uint, IPropertyStorage**, int>)@this->LpVtbl[3])(@this, rfmtid, pclsid, grfFlags, grfMode, ppprstg);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Create(this ComPtr<IPropertySetStorage> thisVtbl, Guid* rfmtid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pclsid, uint grfFlags, uint grfMode, ref IPropertyStorage* ppprstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IPropertyStorage** ppprstgPtr = &ppprstg)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, Guid*, uint, uint, IPropertyStorage**, int>)@this->LpVtbl[3])(@this, rfmtid, pclsid, grfFlags, grfMode, ppprstgPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Create(this ComPtr<IPropertySetStorage> thisVtbl, Guid* rfmtid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pclsid, uint grfFlags, uint grfMode, IPropertyStorage** ppprstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pclsidPtr = &pclsid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, Guid*, uint, uint, IPropertyStorage**, int>)@this->LpVtbl[3])(@this, rfmtid, pclsidPtr, grfFlags, grfMode, ppprstg);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Create(this ComPtr<IPropertySetStorage> thisVtbl, Guid* rfmtid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pclsid, uint grfFlags, uint grfMode, ref IPropertyStorage* ppprstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pclsidPtr = &pclsid)
        {
            fixed (IPropertyStorage** ppprstgPtr = &ppprstg)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, Guid*, uint, uint, IPropertyStorage**, int>)@this->LpVtbl[3])(@this, rfmtid, pclsidPtr, grfFlags, grfMode, ppprstgPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Create(this ComPtr<IPropertySetStorage> thisVtbl, ref Guid rfmtid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pclsid, uint grfFlags, uint grfMode, IPropertyStorage** ppprstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* rfmtidPtr = &rfmtid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, Guid*, uint, uint, IPropertyStorage**, int>)@this->LpVtbl[3])(@this, rfmtidPtr, pclsid, grfFlags, grfMode, ppprstg);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Create(this ComPtr<IPropertySetStorage> thisVtbl, ref Guid rfmtid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pclsid, uint grfFlags, uint grfMode, ref IPropertyStorage* ppprstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* rfmtidPtr = &rfmtid)
        {
            fixed (IPropertyStorage** ppprstgPtr = &ppprstg)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, Guid*, uint, uint, IPropertyStorage**, int>)@this->LpVtbl[3])(@this, rfmtidPtr, pclsid, grfFlags, grfMode, ppprstgPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Create(this ComPtr<IPropertySetStorage> thisVtbl, ref Guid rfmtid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pclsid, uint grfFlags, uint grfMode, IPropertyStorage** ppprstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* rfmtidPtr = &rfmtid)
        {
            fixed (Guid* pclsidPtr = &pclsid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, Guid*, uint, uint, IPropertyStorage**, int>)@this->LpVtbl[3])(@this, rfmtidPtr, pclsidPtr, grfFlags, grfMode, ppprstg);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Create(this ComPtr<IPropertySetStorage> thisVtbl, ref Guid rfmtid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pclsid, uint grfFlags, uint grfMode, ref IPropertyStorage* ppprstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* rfmtidPtr = &rfmtid)
        {
            fixed (Guid* pclsidPtr = &pclsid)
            {
                fixed (IPropertyStorage** ppprstgPtr = &ppprstg)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, Guid*, uint, uint, IPropertyStorage**, int>)@this->LpVtbl[3])(@this, rfmtidPtr, pclsidPtr, grfFlags, grfMode, ppprstgPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<IPropertySetStorage> thisVtbl, Guid* rfmtid, uint grfMode, IPropertyStorage** ppprstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, uint, IPropertyStorage**, int>)@this->LpVtbl[4])(@this, rfmtid, grfMode, ppprstg);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<IPropertySetStorage> thisVtbl, Guid* rfmtid, uint grfMode, ref IPropertyStorage* ppprstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IPropertyStorage** ppprstgPtr = &ppprstg)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, uint, IPropertyStorage**, int>)@this->LpVtbl[4])(@this, rfmtid, grfMode, ppprstgPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<IPropertySetStorage> thisVtbl, ref Guid rfmtid, uint grfMode, IPropertyStorage** ppprstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* rfmtidPtr = &rfmtid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, uint, IPropertyStorage**, int>)@this->LpVtbl[4])(@this, rfmtidPtr, grfMode, ppprstg);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<IPropertySetStorage> thisVtbl, ref Guid rfmtid, uint grfMode, ref IPropertyStorage* ppprstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* rfmtidPtr = &rfmtid)
        {
            fixed (IPropertyStorage** ppprstgPtr = &ppprstg)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, uint, IPropertyStorage**, int>)@this->LpVtbl[4])(@this, rfmtidPtr, grfMode, ppprstgPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Delete(this ComPtr<IPropertySetStorage> thisVtbl, Guid* rfmtid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, int>)@this->LpVtbl[5])(@this, rfmtid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Delete(this ComPtr<IPropertySetStorage> thisVtbl, ref Guid rfmtid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* rfmtidPtr = &rfmtid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, Guid*, int>)@this->LpVtbl[5])(@this, rfmtidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Enum(this ComPtr<IPropertySetStorage> thisVtbl, IEnumSTATPROPSETSTG** ppenum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, IEnumSTATPROPSETSTG**, int>)@this->LpVtbl[6])(@this, ppenum);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Enum(this ComPtr<IPropertySetStorage> thisVtbl, ref IEnumSTATPROPSETSTG* ppenum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IEnumSTATPROPSETSTG** ppenumPtr = &ppenum)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertySetStorage*, IEnumSTATPROPSETSTG**, int>)@this->LpVtbl[6])(@this, ppenumPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IPropertySetStorage> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPropertySetStorage> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPropertySetStorage> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Create<TI0>(this ComPtr<IPropertySetStorage> thisVtbl, Guid* rfmtid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pclsid, uint grfFlags, uint grfMode, ref ComPtr<TI0> ppprstg) where TI0 : unmanaged, IComVtbl<IPropertyStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Create(rfmtid, pclsid, grfFlags, grfMode, (IPropertyStorage**) ppprstg.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Create(this ComPtr<IPropertySetStorage> thisVtbl, Guid* rfmtid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pclsid, uint grfFlags, uint grfMode, IPropertyStorage** ppprstg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Create(rfmtid, in pclsid.GetPinnableReference(), grfFlags, grfMode, ppprstg);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Create<TI0>(this ComPtr<IPropertySetStorage> thisVtbl, Guid* rfmtid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pclsid, uint grfFlags, uint grfMode, ref ComPtr<TI0> ppprstg) where TI0 : unmanaged, IComVtbl<IPropertyStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Create(rfmtid, in pclsid, grfFlags, grfMode, (IPropertyStorage**) ppprstg.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Create(this ComPtr<IPropertySetStorage> thisVtbl, Guid* rfmtid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pclsid, uint grfFlags, uint grfMode, ref IPropertyStorage* ppprstg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Create(rfmtid, in pclsid.GetPinnableReference(), grfFlags, grfMode, ref ppprstg);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Create(this ComPtr<IPropertySetStorage> thisVtbl, Span<Guid> rfmtid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pclsid, uint grfFlags, uint grfMode, IPropertyStorage** ppprstg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Create(ref rfmtid.GetPinnableReference(), pclsid, grfFlags, grfMode, ppprstg);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Create<TI0>(this ComPtr<IPropertySetStorage> thisVtbl, ref Guid rfmtid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pclsid, uint grfFlags, uint grfMode, ref ComPtr<TI0> ppprstg) where TI0 : unmanaged, IComVtbl<IPropertyStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Create(ref rfmtid, pclsid, grfFlags, grfMode, (IPropertyStorage**) ppprstg.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Create(this ComPtr<IPropertySetStorage> thisVtbl, Span<Guid> rfmtid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pclsid, uint grfFlags, uint grfMode, ref IPropertyStorage* ppprstg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Create(ref rfmtid.GetPinnableReference(), pclsid, grfFlags, grfMode, ref ppprstg);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Create(this ComPtr<IPropertySetStorage> thisVtbl, Span<Guid> rfmtid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pclsid, uint grfFlags, uint grfMode, IPropertyStorage** ppprstg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Create(ref rfmtid.GetPinnableReference(), in pclsid.GetPinnableReference(), grfFlags, grfMode, ppprstg);
    }

    /// <summary>To be documented.</summary>
    public static int Create<TI0>(this ComPtr<IPropertySetStorage> thisVtbl, ref Guid rfmtid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pclsid, uint grfFlags, uint grfMode, ref ComPtr<TI0> ppprstg) where TI0 : unmanaged, IComVtbl<IPropertyStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Create(ref rfmtid, in pclsid, grfFlags, grfMode, (IPropertyStorage**) ppprstg.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Create(this ComPtr<IPropertySetStorage> thisVtbl, Span<Guid> rfmtid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pclsid, uint grfFlags, uint grfMode, ref IPropertyStorage* ppprstg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Create(ref rfmtid.GetPinnableReference(), in pclsid.GetPinnableReference(), grfFlags, grfMode, ref ppprstg);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open<TI0>(this ComPtr<IPropertySetStorage> thisVtbl, Guid* rfmtid, uint grfMode, ref ComPtr<TI0> ppprstg) where TI0 : unmanaged, IComVtbl<IPropertyStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Open(rfmtid, grfMode, (IPropertyStorage**) ppprstg.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<IPropertySetStorage> thisVtbl, Span<Guid> rfmtid, uint grfMode, IPropertyStorage** ppprstg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(ref rfmtid.GetPinnableReference(), grfMode, ppprstg);
    }

    /// <summary>To be documented.</summary>
    public static int Open<TI0>(this ComPtr<IPropertySetStorage> thisVtbl, ref Guid rfmtid, uint grfMode, ref ComPtr<TI0> ppprstg) where TI0 : unmanaged, IComVtbl<IPropertyStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Open(ref rfmtid, grfMode, (IPropertyStorage**) ppprstg.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Open(this ComPtr<IPropertySetStorage> thisVtbl, Span<Guid> rfmtid, uint grfMode, ref IPropertyStorage* ppprstg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Open(ref rfmtid.GetPinnableReference(), grfMode, ref ppprstg);
    }

    /// <summary>To be documented.</summary>
    public static int Delete(this ComPtr<IPropertySetStorage> thisVtbl, Span<Guid> rfmtid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Delete(ref rfmtid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Enum<TI0>(this ComPtr<IPropertySetStorage> thisVtbl, ref ComPtr<TI0> ppenum) where TI0 : unmanaged, IComVtbl<IEnumSTATPROPSETSTG>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Enum((IEnumSTATPROPSETSTG**) ppenum.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IPropertySetStorage> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
