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

public unsafe static class PropertyStorageVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPropertyStorage> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPropertyStorage> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPropertyStorage> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPropertyStorage> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IPropertyStorage> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IPropertyStorage> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadMultiple(this ComPtr<IPropertyStorage> thisVtbl, uint cpspec, PropSpec* rgpspec, PropVariant* rgpropvar)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, PropSpec*, PropVariant*, int>)@this->LpVtbl[3])(@this, cpspec, rgpspec, rgpropvar);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadMultiple(this ComPtr<IPropertyStorage> thisVtbl, uint cpspec, PropSpec* rgpspec, ref PropVariant rgpropvar)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PropVariant* rgpropvarPtr = &rgpropvar)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, PropSpec*, PropVariant*, int>)@this->LpVtbl[3])(@this, cpspec, rgpspec, rgpropvarPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadMultiple(this ComPtr<IPropertyStorage> thisVtbl, uint cpspec, ref PropSpec rgpspec, PropVariant* rgpropvar)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PropSpec* rgpspecPtr = &rgpspec)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, PropSpec*, PropVariant*, int>)@this->LpVtbl[3])(@this, cpspec, rgpspecPtr, rgpropvar);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ReadMultiple(this ComPtr<IPropertyStorage> thisVtbl, uint cpspec, ref PropSpec rgpspec, ref PropVariant rgpropvar)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PropSpec* rgpspecPtr = &rgpspec)
        {
            fixed (PropVariant* rgpropvarPtr = &rgpropvar)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, PropSpec*, PropVariant*, int>)@this->LpVtbl[3])(@this, cpspec, rgpspecPtr, rgpropvarPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteMultiple(this ComPtr<IPropertyStorage> thisVtbl, uint cpspec, PropSpec* rgpspec, PropVariant* rgpropvar, uint propidNameFirst)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, PropSpec*, PropVariant*, uint, int>)@this->LpVtbl[4])(@this, cpspec, rgpspec, rgpropvar, propidNameFirst);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteMultiple(this ComPtr<IPropertyStorage> thisVtbl, uint cpspec, PropSpec* rgpspec, ref PropVariant rgpropvar, uint propidNameFirst)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PropVariant* rgpropvarPtr = &rgpropvar)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, PropSpec*, PropVariant*, uint, int>)@this->LpVtbl[4])(@this, cpspec, rgpspec, rgpropvarPtr, propidNameFirst);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteMultiple(this ComPtr<IPropertyStorage> thisVtbl, uint cpspec, ref PropSpec rgpspec, PropVariant* rgpropvar, uint propidNameFirst)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PropSpec* rgpspecPtr = &rgpspec)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, PropSpec*, PropVariant*, uint, int>)@this->LpVtbl[4])(@this, cpspec, rgpspecPtr, rgpropvar, propidNameFirst);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int WriteMultiple(this ComPtr<IPropertyStorage> thisVtbl, uint cpspec, ref PropSpec rgpspec, ref PropVariant rgpropvar, uint propidNameFirst)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PropSpec* rgpspecPtr = &rgpspec)
        {
            fixed (PropVariant* rgpropvarPtr = &rgpropvar)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, PropSpec*, PropVariant*, uint, int>)@this->LpVtbl[4])(@this, cpspec, rgpspecPtr, rgpropvarPtr, propidNameFirst);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DeleteMultiple(this ComPtr<IPropertyStorage> thisVtbl, uint cpspec, PropSpec* rgpspec)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, PropSpec*, int>)@this->LpVtbl[5])(@this, cpspec, rgpspec);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DeleteMultiple(this ComPtr<IPropertyStorage> thisVtbl, uint cpspec, ref PropSpec rgpspec)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PropSpec* rgpspecPtr = &rgpspec)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, PropSpec*, int>)@this->LpVtbl[5])(@this, cpspec, rgpspecPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadPropertyNames(this ComPtr<IPropertyStorage> thisVtbl, uint cpropid, uint* rgpropid, char** rglpwstrName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, uint*, char**, int>)@this->LpVtbl[6])(@this, cpropid, rgpropid, rglpwstrName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadPropertyNames(this ComPtr<IPropertyStorage> thisVtbl, uint cpropid, uint* rgpropid, ref char* rglpwstrName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** rglpwstrNamePtr = &rglpwstrName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, uint*, char**, int>)@this->LpVtbl[6])(@this, cpropid, rgpropid, rglpwstrNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadPropertyNames(this ComPtr<IPropertyStorage> thisVtbl, uint cpropid, ref uint rgpropid, char** rglpwstrName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* rgpropidPtr = &rgpropid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, uint*, char**, int>)@this->LpVtbl[6])(@this, cpropid, rgpropidPtr, rglpwstrName);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadPropertyNames(this ComPtr<IPropertyStorage> thisVtbl, uint cpropid, ref uint rgpropid, ref char* rglpwstrName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* rgpropidPtr = &rgpropid)
        {
            fixed (char** rglpwstrNamePtr = &rglpwstrName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, uint*, char**, int>)@this->LpVtbl[6])(@this, cpropid, rgpropidPtr, rglpwstrNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WritePropertyNames(this ComPtr<IPropertyStorage> thisVtbl, uint cpropid, uint* rgpropid, char** rglpwstrName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, uint*, char**, int>)@this->LpVtbl[7])(@this, cpropid, rgpropid, rglpwstrName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WritePropertyNames(this ComPtr<IPropertyStorage> thisVtbl, uint cpropid, uint* rgpropid, ref char* rglpwstrName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** rglpwstrNamePtr = &rglpwstrName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, uint*, char**, int>)@this->LpVtbl[7])(@this, cpropid, rgpropid, rglpwstrNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WritePropertyNames(this ComPtr<IPropertyStorage> thisVtbl, uint cpropid, ref uint rgpropid, char** rglpwstrName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* rgpropidPtr = &rgpropid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, uint*, char**, int>)@this->LpVtbl[7])(@this, cpropid, rgpropidPtr, rglpwstrName);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WritePropertyNames(this ComPtr<IPropertyStorage> thisVtbl, uint cpropid, ref uint rgpropid, ref char* rglpwstrName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* rgpropidPtr = &rgpropid)
        {
            fixed (char** rglpwstrNamePtr = &rglpwstrName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, uint*, char**, int>)@this->LpVtbl[7])(@this, cpropid, rgpropidPtr, rglpwstrNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DeletePropertyNames(this ComPtr<IPropertyStorage> thisVtbl, uint cpropid, uint* rgpropid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, uint*, int>)@this->LpVtbl[8])(@this, cpropid, rgpropid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DeletePropertyNames(this ComPtr<IPropertyStorage> thisVtbl, uint cpropid, ref uint rgpropid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* rgpropidPtr = &rgpropid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, uint*, int>)@this->LpVtbl[8])(@this, cpropid, rgpropidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Commit(this ComPtr<IPropertyStorage> thisVtbl, uint grfCommitFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, int>)@this->LpVtbl[9])(@this, grfCommitFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Revert(this ComPtr<IPropertyStorage> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, int>)@this->LpVtbl[10])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Enum(this ComPtr<IPropertyStorage> thisVtbl, IEnumSTATPROPSTG** ppenum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, IEnumSTATPROPSTG**, int>)@this->LpVtbl[11])(@this, ppenum);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Enum(this ComPtr<IPropertyStorage> thisVtbl, ref IEnumSTATPROPSTG* ppenum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IEnumSTATPROPSTG** ppenumPtr = &ppenum)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, IEnumSTATPROPSTG**, int>)@this->LpVtbl[11])(@this, ppenumPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTimes(this ComPtr<IPropertyStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[12])(@this, pctime, patime, pmtime);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTimes(this ComPtr<IPropertyStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Filetime* pmtimePtr = &pmtime)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[12])(@this, pctime, patime, pmtimePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTimes(this ComPtr<IPropertyStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Filetime* patimePtr = &patime)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[12])(@this, pctime, patimePtr, pmtime);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTimes(this ComPtr<IPropertyStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Filetime* patimePtr = &patime)
        {
            fixed (Filetime* pmtimePtr = &pmtime)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[12])(@this, pctime, patimePtr, pmtimePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTimes(this ComPtr<IPropertyStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Filetime* pctimePtr = &pctime)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[12])(@this, pctimePtr, patime, pmtime);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTimes(this ComPtr<IPropertyStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Filetime* pctimePtr = &pctime)
        {
            fixed (Filetime* pmtimePtr = &pmtime)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[12])(@this, pctimePtr, patime, pmtimePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTimes(this ComPtr<IPropertyStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Filetime* pctimePtr = &pctime)
        {
            fixed (Filetime* patimePtr = &patime)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[12])(@this, pctimePtr, patimePtr, pmtime);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTimes(this ComPtr<IPropertyStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pmtime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Filetime* pctimePtr = &pctime)
        {
            fixed (Filetime* patimePtr = &patime)
            {
                fixed (Filetime* pmtimePtr = &pmtime)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[12])(@this, pctimePtr, patimePtr, pmtimePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetClass(this ComPtr<IPropertyStorage> thisVtbl, Guid* clsid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, Guid*, int>)@this->LpVtbl[13])(@this, clsid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetClass(this ComPtr<IPropertyStorage> thisVtbl, ref Guid clsid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidPtr = &clsid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, Guid*, int>)@this->LpVtbl[13])(@this, clsidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Stat(this ComPtr<IPropertyStorage> thisVtbl, STATPROPSETSTG* pstatpsstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, STATPROPSETSTG*, int>)@this->LpVtbl[14])(@this, pstatpsstg);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Stat(this ComPtr<IPropertyStorage> thisVtbl, ref STATPROPSETSTG pstatpsstg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (STATPROPSETSTG* pstatpsstgPtr = &pstatpsstg)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, STATPROPSETSTG*, int>)@this->LpVtbl[14])(@this, pstatpsstgPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IPropertyStorage> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPropertyStorage> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPropertyStorage> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadMultiple(this ComPtr<IPropertyStorage> thisVtbl, uint cpspec, PropSpec* rgpspec, Span<PropVariant> rgpropvar)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ReadMultiple(cpspec, rgpspec, ref rgpropvar.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadMultiple(this ComPtr<IPropertyStorage> thisVtbl, uint cpspec, Span<PropSpec> rgpspec, PropVariant* rgpropvar)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ReadMultiple(cpspec, ref rgpspec.GetPinnableReference(), rgpropvar);
    }

    /// <summary>To be documented.</summary>
    public static int ReadMultiple(this ComPtr<IPropertyStorage> thisVtbl, uint cpspec, Span<PropSpec> rgpspec, Span<PropVariant> rgpropvar)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ReadMultiple(cpspec, ref rgpspec.GetPinnableReference(), ref rgpropvar.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteMultiple(this ComPtr<IPropertyStorage> thisVtbl, uint cpspec, PropSpec* rgpspec, Span<PropVariant> rgpropvar, uint propidNameFirst)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteMultiple(cpspec, rgpspec, ref rgpropvar.GetPinnableReference(), propidNameFirst);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteMultiple(this ComPtr<IPropertyStorage> thisVtbl, uint cpspec, Span<PropSpec> rgpspec, PropVariant* rgpropvar, uint propidNameFirst)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteMultiple(cpspec, ref rgpspec.GetPinnableReference(), rgpropvar, propidNameFirst);
    }

    /// <summary>To be documented.</summary>
    public static int WriteMultiple(this ComPtr<IPropertyStorage> thisVtbl, uint cpspec, Span<PropSpec> rgpspec, Span<PropVariant> rgpropvar, uint propidNameFirst)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteMultiple(cpspec, ref rgpspec.GetPinnableReference(), ref rgpropvar.GetPinnableReference(), propidNameFirst);
    }

    /// <summary>To be documented.</summary>
    public static int DeleteMultiple(this ComPtr<IPropertyStorage> thisVtbl, uint cpspec, Span<PropSpec> rgpspec)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DeleteMultiple(cpspec, ref rgpspec.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadPropertyNames(this ComPtr<IPropertyStorage> thisVtbl, uint cpropid, uint* rgpropid, string[] rglpwstrNameSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var rglpwstrName = (char**) SilkMarshal.StringArrayToPtr(rglpwstrNameSa);
        var ret = @this->ReadPropertyNames(cpropid, rgpropid, rglpwstrName);
        SilkMarshal.CopyPtrToStringArray((nint) rglpwstrName, rglpwstrNameSa);
        SilkMarshal.Free((nint) rglpwstrName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ReadPropertyNames(this ComPtr<IPropertyStorage> thisVtbl, uint cpropid, ref uint rgpropid, string[] rglpwstrNameSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var rglpwstrName = (char**) SilkMarshal.StringArrayToPtr(rglpwstrNameSa);
        var ret = @this->ReadPropertyNames(cpropid, ref rgpropid, rglpwstrName);
        SilkMarshal.CopyPtrToStringArray((nint) rglpwstrName, rglpwstrNameSa);
        SilkMarshal.Free((nint) rglpwstrName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadPropertyNames(this ComPtr<IPropertyStorage> thisVtbl, uint cpropid, Span<uint> rgpropid, char** rglpwstrName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ReadPropertyNames(cpropid, ref rgpropid.GetPinnableReference(), rglpwstrName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadPropertyNames(this ComPtr<IPropertyStorage> thisVtbl, uint cpropid, Span<uint> rgpropid, ref char* rglpwstrName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ReadPropertyNames(cpropid, ref rgpropid.GetPinnableReference(), ref rglpwstrName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WritePropertyNames(this ComPtr<IPropertyStorage> thisVtbl, uint cpropid, uint* rgpropid, string[] rglpwstrNameSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var rglpwstrName = (char**) SilkMarshal.StringArrayToPtr(rglpwstrNameSa);
        var ret = @this->WritePropertyNames(cpropid, rgpropid, rglpwstrName);
        SilkMarshal.CopyPtrToStringArray((nint) rglpwstrName, rglpwstrNameSa);
        SilkMarshal.Free((nint) rglpwstrName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int WritePropertyNames(this ComPtr<IPropertyStorage> thisVtbl, uint cpropid, ref uint rgpropid, string[] rglpwstrNameSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var rglpwstrName = (char**) SilkMarshal.StringArrayToPtr(rglpwstrNameSa);
        var ret = @this->WritePropertyNames(cpropid, ref rgpropid, rglpwstrName);
        SilkMarshal.CopyPtrToStringArray((nint) rglpwstrName, rglpwstrNameSa);
        SilkMarshal.Free((nint) rglpwstrName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WritePropertyNames(this ComPtr<IPropertyStorage> thisVtbl, uint cpropid, Span<uint> rgpropid, char** rglpwstrName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WritePropertyNames(cpropid, ref rgpropid.GetPinnableReference(), rglpwstrName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WritePropertyNames(this ComPtr<IPropertyStorage> thisVtbl, uint cpropid, Span<uint> rgpropid, ref char* rglpwstrName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WritePropertyNames(cpropid, ref rgpropid.GetPinnableReference(), ref rglpwstrName);
    }

    /// <summary>To be documented.</summary>
    public static int DeletePropertyNames(this ComPtr<IPropertyStorage> thisVtbl, uint cpropid, Span<uint> rgpropid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DeletePropertyNames(cpropid, ref rgpropid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Enum<TI0>(this ComPtr<IPropertyStorage> thisVtbl, ref ComPtr<TI0> ppenum) where TI0 : unmanaged, IComVtbl<IEnumSTATPROPSTG>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Enum((IEnumSTATPROPSTG**) ppenum.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTimes(this ComPtr<IPropertyStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pmtime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetTimes(pctime, patime, in pmtime.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTimes(this ComPtr<IPropertyStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetTimes(pctime, in patime.GetPinnableReference(), pmtime);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTimes(this ComPtr<IPropertyStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pmtime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetTimes(pctime, in patime.GetPinnableReference(), in pmtime.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTimes(this ComPtr<IPropertyStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetTimes(in pctime.GetPinnableReference(), patime, pmtime);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTimes(this ComPtr<IPropertyStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pmtime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetTimes(in pctime.GetPinnableReference(), patime, in pmtime.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTimes(this ComPtr<IPropertyStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetTimes(in pctime.GetPinnableReference(), in patime.GetPinnableReference(), pmtime);
    }

    /// <summary>To be documented.</summary>
    public static int SetTimes(this ComPtr<IPropertyStorage> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Filetime> pmtime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetTimes(in pctime.GetPinnableReference(), in patime.GetPinnableReference(), in pmtime.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetClass(this ComPtr<IPropertyStorage> thisVtbl, Span<Guid> clsid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetClass(ref clsid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Stat(this ComPtr<IPropertyStorage> thisVtbl, Span<STATPROPSETSTG> pstatpsstg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Stat(ref pstatpsstg.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IPropertyStorage> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
