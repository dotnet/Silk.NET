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

public unsafe static class DxcUtilsVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromBlob<TThis>(this TThis thisVtbl, IDxcBlob* pBlob, uint offset, uint length, IDxcBlob** ppResult) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, uint, uint, IDxcBlob**, int>)@this->LpVtbl[3])(@this, pBlob, offset, length, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromBlob<TThis>(this TThis thisVtbl, IDxcBlob* pBlob, uint offset, uint length, ref IDxcBlob* ppResult) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, uint, uint, IDxcBlob**, int>)@this->LpVtbl[3])(@this, pBlob, offset, length, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromBlob<TThis>(this TThis thisVtbl, ref IDxcBlob pBlob, uint offset, uint length, IDxcBlob** ppResult) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, uint, uint, IDxcBlob**, int>)@this->LpVtbl[3])(@this, pBlobPtr, offset, length, ppResult);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromBlob<TThis>(this TThis thisVtbl, ref IDxcBlob pBlob, uint offset, uint length, ref IDxcBlob* ppResult) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            fixed (IDxcBlob** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, uint, uint, IDxcBlob**, int>)@this->LpVtbl[3])(@this, pBlobPtr, offset, length, ppResultPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromPinned<TThis>(this TThis thisVtbl, void* pData, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[4])(@this, pData, size, codePage, pBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromPinned<TThis>(this TThis thisVtbl, void* pData, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[4])(@this, pData, size, codePage, pBlobEncodingPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromPinned<T0, TThis>(this TThis thisVtbl, ref T0 pData, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[4])(@this, pDataPtr, size, codePage, pBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromPinned<T0, TThis>(this TThis thisVtbl, ref T0 pData, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[4])(@this, pDataPtr, size, codePage, pBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob<TThis>(this TThis thisVtbl, void* pData, IMalloc* pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pData, pIMalloc, size, codePage, pBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob<TThis>(this TThis thisVtbl, void* pData, IMalloc* pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pData, pIMalloc, size, codePage, pBlobEncodingPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob<TThis>(this TThis thisVtbl, void* pData, ref IMalloc pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IMalloc* pIMallocPtr = &pIMalloc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pData, pIMallocPtr, size, codePage, pBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob<TThis>(this TThis thisVtbl, void* pData, ref IMalloc pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IMalloc* pIMallocPtr = &pIMalloc)
        {
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pData, pIMallocPtr, size, codePage, pBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob<T0, TThis>(this TThis thisVtbl, ref T0 pData, IMalloc* pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pDataPtr, pIMalloc, size, codePage, pBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob<T0, TThis>(this TThis thisVtbl, ref T0 pData, IMalloc* pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pDataPtr, pIMalloc, size, codePage, pBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob<T0, TThis>(this TThis thisVtbl, ref T0 pData, ref IMalloc pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            fixed (IMalloc* pIMallocPtr = &pIMalloc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pDataPtr, pIMallocPtr, size, codePage, pBlobEncoding);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob<T0, TThis>(this TThis thisVtbl, ref T0 pData, ref IMalloc pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            fixed (IMalloc* pIMallocPtr = &pIMalloc)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pDataPtr, pIMallocPtr, size, codePage, pBlobEncodingPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlob<TThis>(this TThis thisVtbl, void* pData, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[6])(@this, pData, size, codePage, pBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlob<TThis>(this TThis thisVtbl, void* pData, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[6])(@this, pData, size, codePage, pBlobEncodingPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlob<T0, TThis>(this TThis thisVtbl, ref T0 pData, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[6])(@this, pDataPtr, size, codePage, pBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlob<T0, TThis>(this TThis thisVtbl, ref T0 pData, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[6])(@this, pDataPtr, size, codePage, pBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile<TThis>(this TThis thisVtbl, char* pFileName, uint* pCodePage, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pFileName, pCodePage, pBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile<TThis>(this TThis thisVtbl, char* pFileName, uint* pCodePage, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pFileName, pCodePage, pBlobEncodingPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile<TThis>(this TThis thisVtbl, char* pFileName, ref uint pCodePage, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCodePagePtr = &pCodePage)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pFileName, pCodePagePtr, pBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile<TThis>(this TThis thisVtbl, char* pFileName, ref uint pCodePage, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCodePagePtr = &pCodePage)
        {
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pFileName, pCodePagePtr, pBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile<TThis>(this TThis thisVtbl, ref char pFileName, uint* pCodePage, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pFileNamePtr = &pFileName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pFileNamePtr, pCodePage, pBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile<TThis>(this TThis thisVtbl, ref char pFileName, uint* pCodePage, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pFileNamePtr = &pFileName)
        {
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pFileNamePtr, pCodePage, pBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile<TThis>(this TThis thisVtbl, ref char pFileName, ref uint pCodePage, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pFileNamePtr = &pFileName)
        {
            fixed (uint* pCodePagePtr = &pCodePage)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pFileNamePtr, pCodePagePtr, pBlobEncoding);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile<TThis>(this TThis thisVtbl, ref char pFileName, ref uint pCodePage, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pFileNamePtr = &pFileName)
        {
            fixed (uint* pCodePagePtr = &pCodePage)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pFileNamePtr, pCodePagePtr, pBlobEncodingPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, uint* pCodePage, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pFileNamePtr, pCodePage, pBlobEncoding);
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, uint* pCodePage, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPWStr);
        fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pFileNamePtr, pCodePage, pBlobEncodingPtr);
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, ref uint pCodePage, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPWStr);
        fixed (uint* pCodePagePtr = &pCodePage)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pFileNamePtr, pCodePagePtr, pBlobEncoding);
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, ref uint pCodePage, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPWStr);
        fixed (uint* pCodePagePtr = &pCodePage)
        {
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pFileNamePtr, pCodePagePtr, pBlobEncodingPtr);
            }
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReadOnlyStreamFromBlob<TThis>(this TThis thisVtbl, IDxcBlob* pBlob, void** ppStream) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, void**, int>)@this->LpVtbl[8])(@this, pBlob, ppStream);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReadOnlyStreamFromBlob<TThis>(this TThis thisVtbl, IDxcBlob* pBlob, ref void* ppStream) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppStreamPtr = &ppStream)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, void**, int>)@this->LpVtbl[8])(@this, pBlob, ppStreamPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReadOnlyStreamFromBlob<TThis>(this TThis thisVtbl, ref IDxcBlob pBlob, void** ppStream) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, void**, int>)@this->LpVtbl[8])(@this, pBlobPtr, ppStream);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReadOnlyStreamFromBlob<TThis>(this TThis thisVtbl, ref IDxcBlob pBlob, ref void* ppStream) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            fixed (void** ppStreamPtr = &ppStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, void**, int>)@this->LpVtbl[8])(@this, pBlobPtr, ppStreamPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDefaultIncludeHandler<TThis>(this TThis thisVtbl, IDxcIncludeHandler** ppResult) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcIncludeHandler**, int>)@this->LpVtbl[9])(@this, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDefaultIncludeHandler<TThis>(this TThis thisVtbl, ref IDxcIncludeHandler* ppResult) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcIncludeHandler** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcIncludeHandler**, int>)@this->LpVtbl[9])(@this, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf8<TThis>(this TThis thisVtbl, IDxcBlob* pBlob, IDxcBlobUtf8** pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlobUtf8**, int>)@this->LpVtbl[10])(@this, pBlob, pBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf8<TThis>(this TThis thisVtbl, IDxcBlob* pBlob, ref IDxcBlobUtf8* pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlobUtf8** pBlobEncodingPtr = &pBlobEncoding)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlobUtf8**, int>)@this->LpVtbl[10])(@this, pBlob, pBlobEncodingPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf8<TThis>(this TThis thisVtbl, ref IDxcBlob pBlob, IDxcBlobUtf8** pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlobUtf8**, int>)@this->LpVtbl[10])(@this, pBlobPtr, pBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf8<TThis>(this TThis thisVtbl, ref IDxcBlob pBlob, ref IDxcBlobUtf8* pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            fixed (IDxcBlobUtf8** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlobUtf8**, int>)@this->LpVtbl[10])(@this, pBlobPtr, pBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf16<TThis>(this TThis thisVtbl, IDxcBlob* pBlob, IDxcBlobUtf16** pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlobUtf16**, int>)@this->LpVtbl[11])(@this, pBlob, pBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf16<TThis>(this TThis thisVtbl, IDxcBlob* pBlob, ref IDxcBlobUtf16* pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlobUtf16** pBlobEncodingPtr = &pBlobEncoding)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlobUtf16**, int>)@this->LpVtbl[11])(@this, pBlob, pBlobEncodingPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf16<TThis>(this TThis thisVtbl, ref IDxcBlob pBlob, IDxcBlobUtf16** pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlobUtf16**, int>)@this->LpVtbl[11])(@this, pBlobPtr, pBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf16<TThis>(this TThis thisVtbl, ref IDxcBlob pBlob, ref IDxcBlobUtf16* pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            fixed (IDxcBlobUtf16** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlobUtf16**, int>)@this->LpVtbl[11])(@this, pBlobPtr, pBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxilContainerPart<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] Buffer* pShader, uint DxcPart, void** ppPartData, uint* pPartSizeInBytes) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, uint, void**, uint*, int>)@this->LpVtbl[12])(@this, pShader, DxcPart, ppPartData, pPartSizeInBytes);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxilContainerPart<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] Buffer* pShader, uint DxcPart, void** ppPartData, ref uint pPartSizeInBytes) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pPartSizeInBytesPtr = &pPartSizeInBytes)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, uint, void**, uint*, int>)@this->LpVtbl[12])(@this, pShader, DxcPart, ppPartData, pPartSizeInBytesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxilContainerPart<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] Buffer* pShader, uint DxcPart, ref void* ppPartData, uint* pPartSizeInBytes) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppPartDataPtr = &ppPartData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, uint, void**, uint*, int>)@this->LpVtbl[12])(@this, pShader, DxcPart, ppPartDataPtr, pPartSizeInBytes);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxilContainerPart<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] Buffer* pShader, uint DxcPart, ref void* ppPartData, ref uint pPartSizeInBytes) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppPartDataPtr = &ppPartData)
        {
            fixed (uint* pPartSizeInBytesPtr = &pPartSizeInBytes)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, uint, void**, uint*, int>)@this->LpVtbl[12])(@this, pShader, DxcPart, ppPartDataPtr, pPartSizeInBytesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxilContainerPart<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] in Buffer pShader, uint DxcPart, void** ppPartData, uint* pPartSizeInBytes) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Buffer* pShaderPtr = &pShader)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, uint, void**, uint*, int>)@this->LpVtbl[12])(@this, pShaderPtr, DxcPart, ppPartData, pPartSizeInBytes);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxilContainerPart<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] in Buffer pShader, uint DxcPart, void** ppPartData, ref uint pPartSizeInBytes) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Buffer* pShaderPtr = &pShader)
        {
            fixed (uint* pPartSizeInBytesPtr = &pPartSizeInBytes)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, uint, void**, uint*, int>)@this->LpVtbl[12])(@this, pShaderPtr, DxcPart, ppPartData, pPartSizeInBytesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxilContainerPart<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] in Buffer pShader, uint DxcPart, ref void* ppPartData, uint* pPartSizeInBytes) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Buffer* pShaderPtr = &pShader)
        {
            fixed (void** ppPartDataPtr = &ppPartData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, uint, void**, uint*, int>)@this->LpVtbl[12])(@this, pShaderPtr, DxcPart, ppPartDataPtr, pPartSizeInBytes);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxilContainerPart<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] in Buffer pShader, uint DxcPart, ref void* ppPartData, ref uint pPartSizeInBytes) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Buffer* pShaderPtr = &pShader)
        {
            fixed (void** ppPartDataPtr = &ppPartData)
            {
                fixed (uint* pPartSizeInBytesPtr = &pPartSizeInBytes)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, uint, void**, uint*, int>)@this->LpVtbl[12])(@this, pShaderPtr, DxcPart, ppPartDataPtr, pPartSizeInBytesPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReflection<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] Buffer* pData, Guid* iid, void** ppvReflection) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pData, iid, ppvReflection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReflection<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] Buffer* pData, Guid* iid, ref void* ppvReflection) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvReflectionPtr = &ppvReflection)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pData, iid, ppvReflectionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReflection<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] Buffer* pData, ref Guid iid, void** ppvReflection) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* iidPtr = &iid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pData, iidPtr, ppvReflection);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReflection<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] Buffer* pData, ref Guid iid, ref void* ppvReflection) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* iidPtr = &iid)
        {
            fixed (void** ppvReflectionPtr = &ppvReflection)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pData, iidPtr, ppvReflectionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReflection<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] in Buffer pData, Guid* iid, void** ppvReflection) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Buffer* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pDataPtr, iid, ppvReflection);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReflection<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] in Buffer pData, Guid* iid, ref void* ppvReflection) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Buffer* pDataPtr = &pData)
        {
            fixed (void** ppvReflectionPtr = &ppvReflection)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pDataPtr, iid, ppvReflectionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReflection<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] in Buffer pData, ref Guid iid, void** ppvReflection) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Buffer* pDataPtr = &pData)
        {
            fixed (Guid* iidPtr = &iid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pDataPtr, iidPtr, ppvReflection);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReflection<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] in Buffer pData, ref Guid iid, ref void* ppvReflection) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Buffer* pDataPtr = &pData)
        {
            fixed (Guid* iidPtr = &iid)
            {
                fixed (void** ppvReflectionPtr = &ppvReflection)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pDataPtr, iidPtr, ppvReflectionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Define* pDefinesPtr = &pDefines)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Define* pDefinesPtr = &pDefines)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char** pArgumentsPtr = &pArguments)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.Free((nint)pTargetProfilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (Define* pDefinesPtr = &pDefines)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (Define* pDefinesPtr = &pDefines)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (Define* pDefinesPtr = &pDefines)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (Define* pDefinesPtr = &pDefines)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (Define* pDefinesPtr = &pDefines)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (Define* pDefinesPtr = &pDefines)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                            }
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.Free((nint)pTargetProfilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                }
        SilkMarshal.Free((nint)pTargetProfilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                }
        SilkMarshal.Free((nint)pTargetProfilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
        SilkMarshal.Free((nint)pTargetProfilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                }
        SilkMarshal.Free((nint)pTargetProfilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
        SilkMarshal.Free((nint)pTargetProfilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
        SilkMarshal.Free((nint)pTargetProfilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
        SilkMarshal.Free((nint)pTargetProfilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
            }
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                }
            }
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
            }
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
            }
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
            }
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pSourceNamePtr = &pSourceName)
        {
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (Define* pDefinesPtr = &pDefines)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (Define* pDefinesPtr = &pDefines)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (Define* pDefinesPtr = &pDefines)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (Define* pDefinesPtr = &pDefines)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
            }
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        fixed (char* pEntryPointPtr = &pEntryPoint)
        {
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        }
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (Define* pDefinesPtr = &pDefines)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (Define* pDefinesPtr = &pDefines)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        fixed (char* pTargetProfilePtr = &pTargetProfile)
        {
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
        }
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (Define* pDefinesPtr = &pDefines)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (Define* pDefinesPtr = &pDefines)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
        var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
        var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
        fixed (char** pArgumentsPtr = &pArguments)
        {
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, byte*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
        }
        SilkMarshal.Free((nint)pTargetProfilePtr);
        SilkMarshal.Free((nint)pEntryPointPtr);
        SilkMarshal.Free((nint)pSourceNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPDBContents<TThis>(this TThis thisVtbl, IDxcBlob* pPDBBlob, IDxcBlob** ppHash, IDxcBlob** ppContainer) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlob**, IDxcBlob**, int>)@this->LpVtbl[15])(@this, pPDBBlob, ppHash, ppContainer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPDBContents<TThis>(this TThis thisVtbl, IDxcBlob* pPDBBlob, IDxcBlob** ppHash, ref IDxcBlob* ppContainer) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob** ppContainerPtr = &ppContainer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlob**, IDxcBlob**, int>)@this->LpVtbl[15])(@this, pPDBBlob, ppHash, ppContainerPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPDBContents<TThis>(this TThis thisVtbl, IDxcBlob* pPDBBlob, ref IDxcBlob* ppHash, IDxcBlob** ppContainer) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob** ppHashPtr = &ppHash)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlob**, IDxcBlob**, int>)@this->LpVtbl[15])(@this, pPDBBlob, ppHashPtr, ppContainer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPDBContents<TThis>(this TThis thisVtbl, IDxcBlob* pPDBBlob, ref IDxcBlob* ppHash, ref IDxcBlob* ppContainer) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob** ppHashPtr = &ppHash)
        {
            fixed (IDxcBlob** ppContainerPtr = &ppContainer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlob**, IDxcBlob**, int>)@this->LpVtbl[15])(@this, pPDBBlob, ppHashPtr, ppContainerPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPDBContents<TThis>(this TThis thisVtbl, ref IDxcBlob pPDBBlob, IDxcBlob** ppHash, IDxcBlob** ppContainer) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pPDBBlobPtr = &pPDBBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlob**, IDxcBlob**, int>)@this->LpVtbl[15])(@this, pPDBBlobPtr, ppHash, ppContainer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPDBContents<TThis>(this TThis thisVtbl, ref IDxcBlob pPDBBlob, IDxcBlob** ppHash, ref IDxcBlob* ppContainer) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pPDBBlobPtr = &pPDBBlob)
        {
            fixed (IDxcBlob** ppContainerPtr = &ppContainer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlob**, IDxcBlob**, int>)@this->LpVtbl[15])(@this, pPDBBlobPtr, ppHash, ppContainerPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPDBContents<TThis>(this TThis thisVtbl, ref IDxcBlob pPDBBlob, ref IDxcBlob* ppHash, IDxcBlob** ppContainer) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pPDBBlobPtr = &pPDBBlob)
        {
            fixed (IDxcBlob** ppHashPtr = &ppHash)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlob**, IDxcBlob**, int>)@this->LpVtbl[15])(@this, pPDBBlobPtr, ppHashPtr, ppContainer);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPDBContents<TThis>(this TThis thisVtbl, ref IDxcBlob pPDBBlob, ref IDxcBlob* ppHash, ref IDxcBlob* ppContainer) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pPDBBlobPtr = &pPDBBlob)
        {
            fixed (IDxcBlob** ppHashPtr = &ppHash)
            {
                fixed (IDxcBlob** ppContainerPtr = &ppContainer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlob**, IDxcBlob**, int>)@this->LpVtbl[15])(@this, pPDBBlobPtr, ppHashPtr, ppContainerPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromBlob<TThis>(this TThis thisVtbl, Span<IDxcBlob> pBlob, uint offset, uint length, IDxcBlob** ppResult) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateBlobFromBlob(ref pBlob.GetPinnableReference(), offset, length, ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromBlob<TThis>(this TThis thisVtbl, Span<IDxcBlob> pBlob, uint offset, uint length, ref IDxcBlob* ppResult) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateBlobFromBlob(ref pBlob.GetPinnableReference(), offset, length, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromPinned<T0, TThis>(this TThis thisVtbl, Span<T0> pData, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateBlobFromPinned(ref pData.GetPinnableReference(), size, codePage, pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromPinned<T0, TThis>(this TThis thisVtbl, Span<T0> pData, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateBlobFromPinned(ref pData.GetPinnableReference(), size, codePage, ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob<TThis>(this TThis thisVtbl, void* pData, Span<IMalloc> pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->MoveToBlob(pData, ref pIMalloc.GetPinnableReference(), size, codePage, pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob<TThis>(this TThis thisVtbl, void* pData, Span<IMalloc> pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->MoveToBlob(pData, ref pIMalloc.GetPinnableReference(), size, codePage, ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob<T0, TThis>(this TThis thisVtbl, Span<T0> pData, IMalloc* pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->MoveToBlob(ref pData.GetPinnableReference(), pIMalloc, size, codePage, pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob<T0, TThis>(this TThis thisVtbl, Span<T0> pData, IMalloc* pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->MoveToBlob(ref pData.GetPinnableReference(), pIMalloc, size, codePage, ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob<T0, TThis>(this TThis thisVtbl, Span<T0> pData, Span<IMalloc> pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->MoveToBlob(ref pData.GetPinnableReference(), ref pIMalloc.GetPinnableReference(), size, codePage, pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveToBlob<T0, TThis>(this TThis thisVtbl, Span<T0> pData, Span<IMalloc> pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->MoveToBlob(ref pData.GetPinnableReference(), ref pIMalloc.GetPinnableReference(), size, codePage, ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlob<T0, TThis>(this TThis thisVtbl, Span<T0> pData, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateBlob(ref pData.GetPinnableReference(), size, codePage, pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlob<T0, TThis>(this TThis thisVtbl, Span<T0> pData, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateBlob(ref pData.GetPinnableReference(), size, codePage, ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile<TThis>(this TThis thisVtbl, char* pFileName, Span<uint> pCodePage, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->LoadFile(pFileName, ref pCodePage.GetPinnableReference(), pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile<TThis>(this TThis thisVtbl, char* pFileName, Span<uint> pCodePage, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->LoadFile(pFileName, ref pCodePage.GetPinnableReference(), ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile<TThis>(this TThis thisVtbl, Span<char> pFileName, uint* pCodePage, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->LoadFile(ref pFileName.GetPinnableReference(), pCodePage, pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile<TThis>(this TThis thisVtbl, Span<char> pFileName, uint* pCodePage, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->LoadFile(ref pFileName.GetPinnableReference(), pCodePage, ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile<TThis>(this TThis thisVtbl, Span<char> pFileName, Span<uint> pCodePage, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->LoadFile(ref pFileName.GetPinnableReference(), ref pCodePage.GetPinnableReference(), pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile<TThis>(this TThis thisVtbl, Span<char> pFileName, Span<uint> pCodePage, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->LoadFile(ref pFileName.GetPinnableReference(), ref pCodePage.GetPinnableReference(), ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, Span<uint> pCodePage, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->LoadFile(pFileName, ref pCodePage.GetPinnableReference(), pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadFile<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, Span<uint> pCodePage, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->LoadFile(pFileName, ref pCodePage.GetPinnableReference(), ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReadOnlyStreamFromBlob<TThis>(this TThis thisVtbl, Span<IDxcBlob> pBlob, void** ppStream) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateReadOnlyStreamFromBlob(ref pBlob.GetPinnableReference(), ppStream);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReadOnlyStreamFromBlob<TThis>(this TThis thisVtbl, Span<IDxcBlob> pBlob, ref void* ppStream) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateReadOnlyStreamFromBlob(ref pBlob.GetPinnableReference(), ref ppStream);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf8<TThis>(this TThis thisVtbl, Span<IDxcBlob> pBlob, IDxcBlobUtf8** pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetBlobAsUtf8(ref pBlob.GetPinnableReference(), pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf8<TThis>(this TThis thisVtbl, Span<IDxcBlob> pBlob, ref IDxcBlobUtf8* pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetBlobAsUtf8(ref pBlob.GetPinnableReference(), ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf16<TThis>(this TThis thisVtbl, Span<IDxcBlob> pBlob, IDxcBlobUtf16** pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetBlobAsUtf16(ref pBlob.GetPinnableReference(), pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf16<TThis>(this TThis thisVtbl, Span<IDxcBlob> pBlob, ref IDxcBlobUtf16* pBlobEncoding) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetBlobAsUtf16(ref pBlob.GetPinnableReference(), ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxilContainerPart<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] Buffer* pShader, uint DxcPart, void** ppPartData, Span<uint> pPartSizeInBytes) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDxilContainerPart(pShader, DxcPart, ppPartData, ref pPartSizeInBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxilContainerPart<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] Buffer* pShader, uint DxcPart, ref void* ppPartData, Span<uint> pPartSizeInBytes) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDxilContainerPart(pShader, DxcPart, ref ppPartData, ref pPartSizeInBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxilContainerPart<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pShader, uint DxcPart, void** ppPartData, uint* pPartSizeInBytes) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDxilContainerPart(in pShader.GetPinnableReference(), DxcPart, ppPartData, pPartSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxilContainerPart<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pShader, uint DxcPart, void** ppPartData, Span<uint> pPartSizeInBytes) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDxilContainerPart(in pShader.GetPinnableReference(), DxcPart, ppPartData, ref pPartSizeInBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxilContainerPart<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pShader, uint DxcPart, ref void* ppPartData, uint* pPartSizeInBytes) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDxilContainerPart(in pShader.GetPinnableReference(), DxcPart, ref ppPartData, pPartSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDxilContainerPart<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pShader, uint DxcPart, ref void* ppPartData, Span<uint> pPartSizeInBytes) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDxilContainerPart(in pShader.GetPinnableReference(), DxcPart, ref ppPartData, ref pPartSizeInBytes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReflection<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] Buffer* pData, Span<Guid> iid, void** ppvReflection) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateReflection(pData, ref iid.GetPinnableReference(), ppvReflection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReflection<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] Buffer* pData, Span<Guid> iid, ref void* ppvReflection) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateReflection(pData, ref iid.GetPinnableReference(), ref ppvReflection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReflection<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pData, Guid* iid, void** ppvReflection) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateReflection(in pData.GetPinnableReference(), iid, ppvReflection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReflection<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pData, Guid* iid, ref void* ppvReflection) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateReflection(in pData.GetPinnableReference(), iid, ref ppvReflection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReflection<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pData, Span<Guid> iid, void** ppvReflection) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateReflection(in pData.GetPinnableReference(), ref iid.GetPinnableReference(), ppvReflection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReflection<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pData, Span<Guid> iid, ref void* ppvReflection) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateReflection(in pData.GetPinnableReference(), ref iid.GetPinnableReference(), ref ppvReflection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, ref pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, Span<char> pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, ref pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, Span<char> pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, ref pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, Span<char> pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, ref pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, Span<char> pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, Span<char> pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, ref pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, Span<char> pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, ref pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, Span<char> pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, Span<char> pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, ref pEntryPoint, ref pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, Span<char> pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, ref pEntryPoint, ref pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, Span<char> pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, ref pEntryPoint, ref pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, Span<char> pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, ref pEntryPoint, ref pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, Span<char> pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, Span<char> pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, Span<char> pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, Span<char> pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, Span<char> pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, ref pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, Span<char> pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, ref pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, Span<char> pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, ref pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, Span<char> pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, ref pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, Span<char> pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, Span<char> pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, ref pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, Span<char> pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, ref pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, Span<char> pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, Span<char> pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, ref pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, ref pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, pEntryPoint, ref pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, char* pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, ref pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, pEntryPoint, ref pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, char* pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, ref pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, pEntryPoint, ref pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, char* pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, ref pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, pEntryPoint, ref pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, char* pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, ref pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, char* pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, char* pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, char* pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, char* pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, ref pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, ref pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, ref pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, Span<char> pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), ref pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, ref pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, Span<char> pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), ref pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, ref pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, Span<char> pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), ref pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, ref pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, Span<char> pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), ref pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, Span<char> pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), ref pEntryPoint.GetPinnableReference(), pTargetProfile, ref pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, Span<char> pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), ref pEntryPoint.GetPinnableReference(), pTargetProfile, ref pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, Span<char> pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), ref pEntryPoint.GetPinnableReference(), pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, Span<char> pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), ref pEntryPoint.GetPinnableReference(), pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, ref pEntryPoint, ref pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, Span<char> pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), ref pEntryPoint.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, ref pEntryPoint, ref pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, Span<char> pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), ref pEntryPoint.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, ref pEntryPoint, ref pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, Span<char> pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), ref pEntryPoint.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, ref pEntryPoint, ref pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, Span<char> pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), ref pEntryPoint.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, Span<char> pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), ref pEntryPoint.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, Span<char> pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), ref pEntryPoint.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, Span<char> pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), ref pEntryPoint.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, Span<char> pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), ref pEntryPoint.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, ref pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, Span<char> pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), ref pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, ref pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, Span<char> pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), ref pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, ref pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, Span<char> pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), ref pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, ref pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, Span<char> pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), ref pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, Span<char> pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), ref pEntryPoint.GetPinnableReference(), pTargetProfile, ref pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, Span<char> pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), ref pEntryPoint.GetPinnableReference(), pTargetProfile, ref pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, Span<char> pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), ref pEntryPoint.GetPinnableReference(), pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, Span<char> pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), ref pEntryPoint.GetPinnableReference(), pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, ref pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, ref pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, pEntryPoint, ref pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, ref pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, pEntryPoint, ref pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, ref pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, pEntryPoint, ref pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, ref pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, pEntryPoint, ref pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, ref pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(ref pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, ref pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, ref pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, Span<char> pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(ref pSourceName.GetPinnableReference(), pEntryPoint, pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, ref pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, Span<char> pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, ref pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, Span<char> pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, ref pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, Span<char> pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, ref pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, Span<char> pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, Span<char> pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, ref pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, Span<char> pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, ref pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, Span<char> pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, Span<char> pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, ref pEntryPoint, ref pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, Span<char> pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, ref pEntryPoint, ref pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, Span<char> pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, ref pEntryPoint, ref pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, Span<char> pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, ref pEntryPoint, ref pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, Span<char> pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, Span<char> pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, Span<char> pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, Span<char> pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, Span<char> pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, ref pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, Span<char> pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, ref pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, Span<char> pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, ref pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, Span<char> pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, ref pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, Span<char> pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, Span<char> pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, ref pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, Span<char> pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, ref pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, Span<char> pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, Span<char> pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, ref pEntryPoint.GetPinnableReference(), pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, Span<char> pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, pDefines, defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, Span<char> pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, ref pTargetProfile.GetPinnableReference(), ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // StringArrayOverloader
        var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
        var ret = @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref ppArgs);
        SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
        SilkMarshal.Free((nint) pArguments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, IDxcCompilerArgs** ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BuildArguments<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] ReadOnlySpan<Define> pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BuildArguments(pSourceName, pEntryPoint, pTargetProfile, ref pArguments, argCount, in pDefines.GetPinnableReference(), defineCount, ref ppArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPDBContents<TThis>(this TThis thisVtbl, Span<IDxcBlob> pPDBBlob, IDxcBlob** ppHash, IDxcBlob** ppContainer) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPDBContents(ref pPDBBlob.GetPinnableReference(), ppHash, ppContainer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPDBContents<TThis>(this TThis thisVtbl, Span<IDxcBlob> pPDBBlob, IDxcBlob** ppHash, ref IDxcBlob* ppContainer) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPDBContents(ref pPDBBlob.GetPinnableReference(), ppHash, ref ppContainer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPDBContents<TThis>(this TThis thisVtbl, Span<IDxcBlob> pPDBBlob, ref IDxcBlob* ppHash, IDxcBlob** ppContainer) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPDBContents(ref pPDBBlob.GetPinnableReference(), ref ppHash, ppContainer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPDBContents<TThis>(this TThis thisVtbl, Span<IDxcBlob> pPDBBlob, ref IDxcBlob* ppHash, ref IDxcBlob* ppContainer) where TThis : IComVtbl<IDxcUtils>
    {
        var @this = (IDxcUtils*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPDBContents(ref pPDBBlob.GetPinnableReference(), ref ppHash, ref ppContainer);
    }

}
