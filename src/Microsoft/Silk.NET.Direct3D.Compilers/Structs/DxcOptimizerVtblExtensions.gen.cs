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
    public static unsafe int QueryInterface(this ComPtr<IDxcOptimizer> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcOptimizer> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcOptimizer> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcOptimizer> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
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
    public static uint AddRef(this ComPtr<IDxcOptimizer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDxcOptimizer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAvailablePassCount(this ComPtr<IDxcOptimizer> thisVtbl, uint* pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint*, int>)@this->LpVtbl[3])(@this, pCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAvailablePassCount(this ComPtr<IDxcOptimizer> thisVtbl, ref uint pCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint*, int>)@this->LpVtbl[3])(@this, pCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAvailablePass(this ComPtr<IDxcOptimizer> thisVtbl, uint index, IDxcOptimizerPass** ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint, IDxcOptimizerPass**, int>)@this->LpVtbl[4])(@this, index, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAvailablePass(this ComPtr<IDxcOptimizer> thisVtbl, uint index, ref IDxcOptimizerPass* ppResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcOptimizerPass** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint, IDxcOptimizerPass**, int>)@this->LpVtbl[4])(@this, index, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, IDxcBlob* pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlob, ppOptions, optionCount, pOutputModule, ppOutputText);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, IDxcBlob* pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlob, ppOptions, optionCount, pOutputModule, ppOutputTextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, IDxcBlob* pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlob, ppOptions, optionCount, pOutputModulePtr, ppOutputText);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, IDxcBlob* pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, IDxcBlob* pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** ppOptionsPtr = &ppOptions)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlob, ppOptionsPtr, optionCount, pOutputModule, ppOutputText);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, IDxcBlob* pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, IDxcBlob* pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, IDxcBlob* pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, ref IDxcBlob pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlobPtr, ppOptions, optionCount, pOutputModule, ppOutputText);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, ref IDxcBlob pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, ref IDxcBlob pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, ref IDxcBlob pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, ref IDxcBlob pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, ref IDxcBlob pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, ref IDxcBlob pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, ref IDxcBlob pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText)
    {
        var @this = thisVtbl.Handle;
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
    public static int QueryInterface<TI0>(this ComPtr<IDxcOptimizer> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcOptimizer> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDxcOptimizer> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetAvailablePassCount(this ComPtr<IDxcOptimizer> thisVtbl, Span<uint> pCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAvailablePassCount(ref pCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetAvailablePass<TI0>(this ComPtr<IDxcOptimizer> thisVtbl, uint index, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOptimizerPass>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetAvailablePass(index, (IDxcOptimizerPass**) ppResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, IDxcBlob* pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] ppOptionsSa, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var ppOptions = (char**) SilkMarshal.StringArrayToPtr(ppOptionsSa);
        var ret = @this->RunOptimizer(pBlob, ppOptions, optionCount, pOutputModule, ppOutputText);
        SilkMarshal.CopyPtrToStringArray((nint) ppOptions, ppOptionsSa);
        SilkMarshal.Free((nint) ppOptions);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TI0, TI1, TI2>(this ComPtr<IDxcOptimizer> thisVtbl, ComPtr<TI0> pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** ppOptions, uint optionCount, ref ComPtr<TI1> pOutputModule, ref ComPtr<TI2> ppOutputText) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RunOptimizer((IDxcBlob*) pBlob.Handle, ppOptions, optionCount, (IDxcBlob**) pOutputModule.GetAddressOf(), (IDxcBlobEncoding**) ppOutputText.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, IDxcBlob* pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] ppOptionsSa, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var ppOptions = (char**) SilkMarshal.StringArrayToPtr(ppOptionsSa);
        var ret = @this->RunOptimizer(pBlob, ppOptions, optionCount, pOutputModule, ref ppOutputText);
        SilkMarshal.CopyPtrToStringArray((nint) ppOptions, ppOptionsSa);
        SilkMarshal.Free((nint) ppOptions);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TI0, TI1>(this ComPtr<IDxcOptimizer> thisVtbl, ComPtr<TI0> pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** ppOptions, uint optionCount, ref ComPtr<TI1> pOutputModule, ref IDxcBlobEncoding* ppOutputText) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RunOptimizer((IDxcBlob*) pBlob.Handle, ppOptions, optionCount, (IDxcBlob**) pOutputModule.GetAddressOf(), ref ppOutputText);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, IDxcBlob* pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] ppOptionsSa, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var ppOptions = (char**) SilkMarshal.StringArrayToPtr(ppOptionsSa);
        var ret = @this->RunOptimizer(pBlob, ppOptions, optionCount, ref pOutputModule, ppOutputText);
        SilkMarshal.CopyPtrToStringArray((nint) ppOptions, ppOptionsSa);
        SilkMarshal.Free((nint) ppOptions);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TI0, TI1>(this ComPtr<IDxcOptimizer> thisVtbl, ComPtr<TI0> pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref ComPtr<TI1> ppOutputText) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RunOptimizer((IDxcBlob*) pBlob.Handle, ppOptions, optionCount, ref pOutputModule, (IDxcBlobEncoding**) ppOutputText.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, IDxcBlob* pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] ppOptionsSa, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var ppOptions = (char**) SilkMarshal.StringArrayToPtr(ppOptionsSa);
        var ret = @this->RunOptimizer(pBlob, ppOptions, optionCount, ref pOutputModule, ref ppOutputText);
        SilkMarshal.CopyPtrToStringArray((nint) ppOptions, ppOptionsSa);
        SilkMarshal.Free((nint) ppOptions);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TI0>(this ComPtr<IDxcOptimizer> thisVtbl, ComPtr<TI0> pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RunOptimizer((IDxcBlob*) pBlob.Handle, ppOptions, optionCount, ref pOutputModule, ref ppOutputText);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TI0, TI1, TI2>(this ComPtr<IDxcOptimizer> thisVtbl, ComPtr<TI0> pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* ppOptions, uint optionCount, ref ComPtr<TI1> pOutputModule, ref ComPtr<TI2> ppOutputText) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RunOptimizer((IDxcBlob*) pBlob.Handle, in ppOptions, optionCount, (IDxcBlob**) pOutputModule.GetAddressOf(), (IDxcBlobEncoding**) ppOutputText.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TI0, TI1>(this ComPtr<IDxcOptimizer> thisVtbl, ComPtr<TI0> pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* ppOptions, uint optionCount, ref ComPtr<TI1> pOutputModule, ref IDxcBlobEncoding* ppOutputText) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RunOptimizer((IDxcBlob*) pBlob.Handle, in ppOptions, optionCount, (IDxcBlob**) pOutputModule.GetAddressOf(), ref ppOutputText);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TI0, TI1>(this ComPtr<IDxcOptimizer> thisVtbl, ComPtr<TI0> pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref ComPtr<TI1> ppOutputText) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RunOptimizer((IDxcBlob*) pBlob.Handle, in ppOptions, optionCount, ref pOutputModule, (IDxcBlobEncoding**) ppOutputText.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TI0>(this ComPtr<IDxcOptimizer> thisVtbl, ComPtr<TI0> pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RunOptimizer((IDxcBlob*) pBlob.Handle, in ppOptions, optionCount, ref pOutputModule, ref ppOutputText);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, ref IDxcBlob pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] ppOptionsSa, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var ppOptions = (char**) SilkMarshal.StringArrayToPtr(ppOptionsSa);
        var ret = @this->RunOptimizer(ref pBlob, ppOptions, optionCount, pOutputModule, ppOutputText);
        SilkMarshal.CopyPtrToStringArray((nint) ppOptions, ppOptionsSa);
        SilkMarshal.Free((nint) ppOptions);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, Span<IDxcBlob> pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RunOptimizer(ref pBlob.GetPinnableReference(), ppOptions, optionCount, pOutputModule, ppOutputText);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TI0, TI1>(this ComPtr<IDxcOptimizer> thisVtbl, ref IDxcBlob pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** ppOptions, uint optionCount, ref ComPtr<TI0> pOutputModule, ref ComPtr<TI1> ppOutputText) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RunOptimizer(ref pBlob, ppOptions, optionCount, (IDxcBlob**) pOutputModule.GetAddressOf(), (IDxcBlobEncoding**) ppOutputText.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, ref IDxcBlob pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] ppOptionsSa, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var ppOptions = (char**) SilkMarshal.StringArrayToPtr(ppOptionsSa);
        var ret = @this->RunOptimizer(ref pBlob, ppOptions, optionCount, pOutputModule, ref ppOutputText);
        SilkMarshal.CopyPtrToStringArray((nint) ppOptions, ppOptionsSa);
        SilkMarshal.Free((nint) ppOptions);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, Span<IDxcBlob> pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RunOptimizer(ref pBlob.GetPinnableReference(), ppOptions, optionCount, pOutputModule, ref ppOutputText);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TI0>(this ComPtr<IDxcOptimizer> thisVtbl, ref IDxcBlob pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** ppOptions, uint optionCount, ref ComPtr<TI0> pOutputModule, ref IDxcBlobEncoding* ppOutputText) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RunOptimizer(ref pBlob, ppOptions, optionCount, (IDxcBlob**) pOutputModule.GetAddressOf(), ref ppOutputText);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, ref IDxcBlob pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] ppOptionsSa, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var ppOptions = (char**) SilkMarshal.StringArrayToPtr(ppOptionsSa);
        var ret = @this->RunOptimizer(ref pBlob, ppOptions, optionCount, ref pOutputModule, ppOutputText);
        SilkMarshal.CopyPtrToStringArray((nint) ppOptions, ppOptionsSa);
        SilkMarshal.Free((nint) ppOptions);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, Span<IDxcBlob> pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RunOptimizer(ref pBlob.GetPinnableReference(), ppOptions, optionCount, ref pOutputModule, ppOutputText);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TI0>(this ComPtr<IDxcOptimizer> thisVtbl, ref IDxcBlob pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref ComPtr<TI0> ppOutputText) where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RunOptimizer(ref pBlob, ppOptions, optionCount, ref pOutputModule, (IDxcBlobEncoding**) ppOutputText.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, ref IDxcBlob pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] ppOptionsSa, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var ppOptions = (char**) SilkMarshal.StringArrayToPtr(ppOptionsSa);
        var ret = @this->RunOptimizer(ref pBlob, ppOptions, optionCount, ref pOutputModule, ref ppOutputText);
        SilkMarshal.CopyPtrToStringArray((nint) ppOptions, ppOptionsSa);
        SilkMarshal.Free((nint) ppOptions);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, Span<IDxcBlob> pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RunOptimizer(ref pBlob.GetPinnableReference(), ppOptions, optionCount, ref pOutputModule, ref ppOutputText);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, Span<IDxcBlob> pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RunOptimizer(ref pBlob.GetPinnableReference(), in ppOptions, optionCount, pOutputModule, ppOutputText);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TI0, TI1>(this ComPtr<IDxcOptimizer> thisVtbl, ref IDxcBlob pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* ppOptions, uint optionCount, ref ComPtr<TI0> pOutputModule, ref ComPtr<TI1> ppOutputText) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RunOptimizer(ref pBlob, in ppOptions, optionCount, (IDxcBlob**) pOutputModule.GetAddressOf(), (IDxcBlobEncoding**) ppOutputText.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, Span<IDxcBlob> pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RunOptimizer(ref pBlob.GetPinnableReference(), in ppOptions, optionCount, pOutputModule, ref ppOutputText);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TI0>(this ComPtr<IDxcOptimizer> thisVtbl, ref IDxcBlob pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* ppOptions, uint optionCount, ref ComPtr<TI0> pOutputModule, ref IDxcBlobEncoding* ppOutputText) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RunOptimizer(ref pBlob, in ppOptions, optionCount, (IDxcBlob**) pOutputModule.GetAddressOf(), ref ppOutputText);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, Span<IDxcBlob> pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RunOptimizer(ref pBlob.GetPinnableReference(), in ppOptions, optionCount, ref pOutputModule, ppOutputText);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer<TI0>(this ComPtr<IDxcOptimizer> thisVtbl, ref IDxcBlob pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref ComPtr<TI0> ppOutputText) where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RunOptimizer(ref pBlob, in ppOptions, optionCount, ref pOutputModule, (IDxcBlobEncoding**) ppOutputText.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RunOptimizer(this ComPtr<IDxcOptimizer> thisVtbl, Span<IDxcBlob> pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RunOptimizer(ref pBlob.GetPinnableReference(), in ppOptions, optionCount, ref pOutputModule, ref ppOutputText);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDxcOptimizer> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
