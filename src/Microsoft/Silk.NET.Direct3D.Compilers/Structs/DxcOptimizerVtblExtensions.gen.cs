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

namespace Silk.NET.Direct3D.Compilers;

public unsafe static class DxcOptimizerVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAvailablePassCount<TThis>(this TThis thisVtbl, uint* pCount) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint*, int>)@this->LpVtbl[3])(@this, pCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAvailablePassCount<TThis>(this TThis thisVtbl, ref uint pCount) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint*, int>)@this->LpVtbl[3])(@this, pCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAvailablePass<TThis>(this TThis thisVtbl, uint index, IDxcOptimizerPass** ppResult) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint, IDxcOptimizerPass**, int>)@this->LpVtbl[4])(@this, index, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAvailablePass<TThis>(this TThis thisVtbl, uint index, ref IDxcOptimizerPass* ppResult) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcOptimizerPass** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint, IDxcOptimizerPass**, int>)@this->LpVtbl[4])(@this, index, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, IDxcBlob* pBlob, char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlob, ppOptions, optionCount, pOutputModule, ppOutputText);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, IDxcBlob* pBlob, char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlob, ppOptions, optionCount, pOutputModule, ppOutputTextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, IDxcBlob* pBlob, char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlob, ppOptions, optionCount, pOutputModulePtr, ppOutputText);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, IDxcBlob* pBlob, char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
        {
            fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlob, ppOptions, optionCount, pOutputModulePtr, ppOutputTextPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, IDxcBlob* pBlob, ref char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char** ppOptionsPtr = &ppOptions)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlob, ppOptionsPtr, optionCount, pOutputModule, ppOutputText);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, IDxcBlob* pBlob, ref char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char** ppOptionsPtr = &ppOptions)
        {
            fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlob, ppOptionsPtr, optionCount, pOutputModule, ppOutputTextPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, IDxcBlob* pBlob, ref char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char** ppOptionsPtr = &ppOptions)
        {
            fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlob, ppOptionsPtr, optionCount, pOutputModulePtr, ppOutputText);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, IDxcBlob* pBlob, ref char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char** ppOptionsPtr = &ppOptions)
        {
            fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
            {
                fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlob, ppOptionsPtr, optionCount, pOutputModulePtr, ppOutputTextPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, ref IDxcBlob pBlob, char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlobPtr, ppOptions, optionCount, pOutputModule, ppOutputText);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, ref IDxcBlob pBlob, char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlobPtr, ppOptions, optionCount, pOutputModule, ppOutputTextPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, ref IDxcBlob pBlob, char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlobPtr, ppOptions, optionCount, pOutputModulePtr, ppOutputText);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, ref IDxcBlob pBlob, char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
            {
                fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlobPtr, ppOptions, optionCount, pOutputModulePtr, ppOutputTextPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, ref IDxcBlob pBlob, ref char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            fixed (char** ppOptionsPtr = &ppOptions)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlobPtr, ppOptionsPtr, optionCount, pOutputModule, ppOutputText);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, ref IDxcBlob pBlob, ref char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            fixed (char** ppOptionsPtr = &ppOptions)
            {
                fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlobPtr, ppOptionsPtr, optionCount, pOutputModule, ppOutputTextPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, ref IDxcBlob pBlob, ref char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            fixed (char** ppOptionsPtr = &ppOptions)
            {
                fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlobPtr, ppOptionsPtr, optionCount, pOutputModulePtr, ppOutputText);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, ref IDxcBlob pBlob, ref char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            fixed (char** ppOptionsPtr = &ppOptions)
            {
                fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
                {
                    fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlobPtr, ppOptionsPtr, optionCount, pOutputModulePtr, ppOutputTextPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetAvailablePassCount<TThis>(this TThis thisVtbl, Span<uint> pCount) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetAvailablePassCount(ref pCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, IDxcBlob* pBlob, string[] ppOptionsSa, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var ppOptions = (char**) SilkMarshal.StringArrayToPtr(ppOptionsSa);
        var ret = @this->RunOptimizer(pBlob, ppOptions, optionCount, pOutputModule, ppOutputText);
        SilkMarshal.CopyPtrToStringArray((nint) ppOptions, ppOptionsSa);
        SilkMarshal.Free((nint) ppOptions);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, IDxcBlob* pBlob, string[] ppOptionsSa, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var ppOptions = (char**) SilkMarshal.StringArrayToPtr(ppOptionsSa);
        var ret = @this->RunOptimizer(pBlob, ppOptions, optionCount, pOutputModule, ref ppOutputText);
        SilkMarshal.CopyPtrToStringArray((nint) ppOptions, ppOptionsSa);
        SilkMarshal.Free((nint) ppOptions);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, IDxcBlob* pBlob, string[] ppOptionsSa, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var ppOptions = (char**) SilkMarshal.StringArrayToPtr(ppOptionsSa);
        var ret = @this->RunOptimizer(pBlob, ppOptions, optionCount, ref pOutputModule, ppOutputText);
        SilkMarshal.CopyPtrToStringArray((nint) ppOptions, ppOptionsSa);
        SilkMarshal.Free((nint) ppOptions);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, IDxcBlob* pBlob, string[] ppOptionsSa, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var ppOptions = (char**) SilkMarshal.StringArrayToPtr(ppOptionsSa);
        var ret = @this->RunOptimizer(pBlob, ppOptions, optionCount, ref pOutputModule, ref ppOutputText);
        SilkMarshal.CopyPtrToStringArray((nint) ppOptions, ppOptionsSa);
        SilkMarshal.Free((nint) ppOptions);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, ref IDxcBlob pBlob, string[] ppOptionsSa, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var ppOptions = (char**) SilkMarshal.StringArrayToPtr(ppOptionsSa);
        var ret = @this->RunOptimizer(ref pBlob, ppOptions, optionCount, pOutputModule, ppOutputText);
        SilkMarshal.CopyPtrToStringArray((nint) ppOptions, ppOptionsSa);
        SilkMarshal.Free((nint) ppOptions);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, Span<IDxcBlob> pBlob, char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->RunOptimizer(ref pBlob.GetPinnableReference(), ppOptions, optionCount, pOutputModule, ppOutputText);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, ref IDxcBlob pBlob, string[] ppOptionsSa, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var ppOptions = (char**) SilkMarshal.StringArrayToPtr(ppOptionsSa);
        var ret = @this->RunOptimizer(ref pBlob, ppOptions, optionCount, pOutputModule, ref ppOutputText);
        SilkMarshal.CopyPtrToStringArray((nint) ppOptions, ppOptionsSa);
        SilkMarshal.Free((nint) ppOptions);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, Span<IDxcBlob> pBlob, char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->RunOptimizer(ref pBlob.GetPinnableReference(), ppOptions, optionCount, pOutputModule, ref ppOutputText);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, ref IDxcBlob pBlob, string[] ppOptionsSa, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var ppOptions = (char**) SilkMarshal.StringArrayToPtr(ppOptionsSa);
        var ret = @this->RunOptimizer(ref pBlob, ppOptions, optionCount, ref pOutputModule, ppOutputText);
        SilkMarshal.CopyPtrToStringArray((nint) ppOptions, ppOptionsSa);
        SilkMarshal.Free((nint) ppOptions);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, Span<IDxcBlob> pBlob, char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->RunOptimizer(ref pBlob.GetPinnableReference(), ppOptions, optionCount, ref pOutputModule, ppOutputText);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, ref IDxcBlob pBlob, string[] ppOptionsSa, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var ppOptions = (char**) SilkMarshal.StringArrayToPtr(ppOptionsSa);
        var ret = @this->RunOptimizer(ref pBlob, ppOptions, optionCount, ref pOutputModule, ref ppOutputText);
        SilkMarshal.CopyPtrToStringArray((nint) ppOptions, ppOptionsSa);
        SilkMarshal.Free((nint) ppOptions);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, Span<IDxcBlob> pBlob, char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->RunOptimizer(ref pBlob.GetPinnableReference(), ppOptions, optionCount, ref pOutputModule, ref ppOutputText);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, Span<IDxcBlob> pBlob, ref char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->RunOptimizer(ref pBlob.GetPinnableReference(), ref ppOptions, optionCount, pOutputModule, ppOutputText);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, Span<IDxcBlob> pBlob, ref char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->RunOptimizer(ref pBlob.GetPinnableReference(), ref ppOptions, optionCount, pOutputModule, ref ppOutputText);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, Span<IDxcBlob> pBlob, ref char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->RunOptimizer(ref pBlob.GetPinnableReference(), ref ppOptions, optionCount, ref pOutputModule, ppOutputText);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TThis>(this TThis thisVtbl, Span<IDxcBlob> pBlob, ref char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText) where TThis : IComVtbl<IDxcOptimizer>
    {
        var @this = (IDxcOptimizer*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->RunOptimizer(ref pBlob.GetPinnableReference(), ref ppOptions, optionCount, ref pOutputModule, ref ppOutputText);
    }

}
