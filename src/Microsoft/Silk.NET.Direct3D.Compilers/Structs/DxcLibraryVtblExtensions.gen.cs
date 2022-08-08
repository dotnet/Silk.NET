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

public unsafe static class DxcLibraryVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetMalloc<TThis>(this TThis thisVtbl, IMalloc* pMalloc) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IMalloc*, int>)@this->LpVtbl[3])(@this, pMalloc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetMalloc<TThis>(this TThis thisVtbl, ref IMalloc pMalloc) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IMalloc* pMallocPtr = &pMalloc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IMalloc*, int>)@this->LpVtbl[3])(@this, pMallocPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromBlob<TThis>(this TThis thisVtbl, IDxcBlob* pBlob, uint offset, uint length, IDxcBlob** ppResult) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int>)@this->LpVtbl[4])(@this, pBlob, offset, length, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromBlob<TThis>(this TThis thisVtbl, IDxcBlob* pBlob, uint offset, uint length, ref IDxcBlob* ppResult) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int>)@this->LpVtbl[4])(@this, pBlob, offset, length, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromBlob<TThis>(this TThis thisVtbl, ref IDxcBlob pBlob, uint offset, uint length, IDxcBlob** ppResult) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int>)@this->LpVtbl[4])(@this, pBlobPtr, offset, length, ppResult);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromBlob<TThis>(this TThis thisVtbl, ref IDxcBlob pBlob, uint offset, uint length, ref IDxcBlob* ppResult) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            fixed (IDxcBlob** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int>)@this->LpVtbl[4])(@this, pBlobPtr, offset, length, ppResultPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile<TThis>(this TThis thisVtbl, char* pFileName, uint* codePage, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pFileName, codePage, pBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile<TThis>(this TThis thisVtbl, char* pFileName, uint* codePage, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pFileName, codePage, pBlobEncodingPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile<TThis>(this TThis thisVtbl, char* pFileName, ref uint codePage, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* codePagePtr = &codePage)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pFileName, codePagePtr, pBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile<TThis>(this TThis thisVtbl, char* pFileName, ref uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* codePagePtr = &codePage)
        {
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pFileName, codePagePtr, pBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile<TThis>(this TThis thisVtbl, ref char pFileName, uint* codePage, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pFileNamePtr = &pFileName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pFileNamePtr, codePage, pBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile<TThis>(this TThis thisVtbl, ref char pFileName, uint* codePage, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pFileNamePtr = &pFileName)
        {
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pFileNamePtr, codePage, pBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile<TThis>(this TThis thisVtbl, ref char pFileName, ref uint codePage, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pFileNamePtr = &pFileName)
        {
            fixed (uint* codePagePtr = &codePage)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pFileNamePtr, codePagePtr, pBlobEncoding);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile<TThis>(this TThis thisVtbl, ref char pFileName, ref uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pFileNamePtr = &pFileName)
        {
            fixed (uint* codePagePtr = &codePage)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pFileNamePtr, codePagePtr, pBlobEncodingPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, uint* codePage, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, byte*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pFileNamePtr, codePage, pBlobEncoding);
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, uint* codePage, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPWStr);
        fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, byte*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pFileNamePtr, codePage, pBlobEncodingPtr);
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, ref uint codePage, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPWStr);
        fixed (uint* codePagePtr = &codePage)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, byte*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pFileNamePtr, codePagePtr, pBlobEncoding);
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, ref uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPWStr);
        fixed (uint* codePagePtr = &codePage)
        {
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, byte*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pFileNamePtr, codePagePtr, pBlobEncodingPtr);
            }
        }
        SilkMarshal.Free((nint)pFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingFromPinned<TThis>(this TThis thisVtbl, void* pText, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[6])(@this, pText, size, codePage, pBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingFromPinned<TThis>(this TThis thisVtbl, void* pText, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[6])(@this, pText, size, codePage, pBlobEncodingPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingFromPinned<T0, TThis>(this TThis thisVtbl, ref T0 pText, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pTextPtr = &pText)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[6])(@this, pTextPtr, size, codePage, pBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingFromPinned<T0, TThis>(this TThis thisVtbl, ref T0 pText, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pTextPtr = &pText)
        {
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[6])(@this, pTextPtr, size, codePage, pBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnHeapCopy<TThis>(this TThis thisVtbl, void* pText, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pText, size, codePage, pBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnHeapCopy<TThis>(this TThis thisVtbl, void* pText, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pText, size, codePage, pBlobEncodingPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnHeapCopy<T0, TThis>(this TThis thisVtbl, ref T0 pText, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pTextPtr = &pText)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pTextPtr, size, codePage, pBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnHeapCopy<T0, TThis>(this TThis thisVtbl, ref T0 pText, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pTextPtr = &pText)
        {
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pTextPtr, size, codePage, pBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc<TThis>(this TThis thisVtbl, void* pText, IMalloc* pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[8])(@this, pText, pIMalloc, size, codePage, pBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc<TThis>(this TThis thisVtbl, void* pText, IMalloc* pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[8])(@this, pText, pIMalloc, size, codePage, pBlobEncodingPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc<TThis>(this TThis thisVtbl, void* pText, ref IMalloc pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IMalloc* pIMallocPtr = &pIMalloc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[8])(@this, pText, pIMallocPtr, size, codePage, pBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc<TThis>(this TThis thisVtbl, void* pText, ref IMalloc pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IMalloc* pIMallocPtr = &pIMalloc)
        {
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[8])(@this, pText, pIMallocPtr, size, codePage, pBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc<T0, TThis>(this TThis thisVtbl, ref T0 pText, IMalloc* pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pTextPtr = &pText)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[8])(@this, pTextPtr, pIMalloc, size, codePage, pBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc<T0, TThis>(this TThis thisVtbl, ref T0 pText, IMalloc* pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pTextPtr = &pText)
        {
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[8])(@this, pTextPtr, pIMalloc, size, codePage, pBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc<T0, TThis>(this TThis thisVtbl, ref T0 pText, ref IMalloc pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pTextPtr = &pText)
        {
            fixed (IMalloc* pIMallocPtr = &pIMalloc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[8])(@this, pTextPtr, pIMallocPtr, size, codePage, pBlobEncoding);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc<T0, TThis>(this TThis thisVtbl, ref T0 pText, ref IMalloc pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pTextPtr = &pText)
        {
            fixed (IMalloc* pIMallocPtr = &pIMalloc)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[8])(@this, pTextPtr, pIMallocPtr, size, codePage, pBlobEncodingPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateIncludeHandler<TThis>(this TThis thisVtbl, IDxcIncludeHandler** ppResult) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcIncludeHandler**, int>)@this->LpVtbl[9])(@this, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateIncludeHandler<TThis>(this TThis thisVtbl, ref IDxcIncludeHandler* ppResult) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcIncludeHandler** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcIncludeHandler**, int>)@this->LpVtbl[9])(@this, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromBlobReadOnly<TThis>(this TThis thisVtbl, IDxcBlob* pBlob, void** ppStream) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, void**, int>)@this->LpVtbl[10])(@this, pBlob, ppStream);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromBlobReadOnly<TThis>(this TThis thisVtbl, IDxcBlob* pBlob, ref void* ppStream) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppStreamPtr = &ppStream)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, void**, int>)@this->LpVtbl[10])(@this, pBlob, ppStreamPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromBlobReadOnly<TThis>(this TThis thisVtbl, ref IDxcBlob pBlob, void** ppStream) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, void**, int>)@this->LpVtbl[10])(@this, pBlobPtr, ppStream);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromBlobReadOnly<TThis>(this TThis thisVtbl, ref IDxcBlob pBlob, ref void* ppStream) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            fixed (void** ppStreamPtr = &ppStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, void**, int>)@this->LpVtbl[10])(@this, pBlobPtr, ppStreamPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf8<TThis>(this TThis thisVtbl, IDxcBlob* pBlob, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)@this->LpVtbl[11])(@this, pBlob, pBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf8<TThis>(this TThis thisVtbl, IDxcBlob* pBlob, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)@this->LpVtbl[11])(@this, pBlob, pBlobEncodingPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf8<TThis>(this TThis thisVtbl, ref IDxcBlob pBlob, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)@this->LpVtbl[11])(@this, pBlobPtr, pBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf8<TThis>(this TThis thisVtbl, ref IDxcBlob pBlob, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)@this->LpVtbl[11])(@this, pBlobPtr, pBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf16<TThis>(this TThis thisVtbl, IDxcBlob* pBlob, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)@this->LpVtbl[12])(@this, pBlob, pBlobEncoding);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf16<TThis>(this TThis thisVtbl, IDxcBlob* pBlob, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)@this->LpVtbl[12])(@this, pBlob, pBlobEncodingPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf16<TThis>(this TThis thisVtbl, ref IDxcBlob pBlob, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)@this->LpVtbl[12])(@this, pBlobPtr, pBlobEncoding);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf16<TThis>(this TThis thisVtbl, ref IDxcBlob pBlob, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pBlobPtr = &pBlob)
        {
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)@this->LpVtbl[12])(@this, pBlobPtr, pBlobEncodingPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int SetMalloc<TThis>(this TThis thisVtbl, Span<IMalloc> pMalloc) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetMalloc(ref pMalloc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromBlob<TThis>(this TThis thisVtbl, Span<IDxcBlob> pBlob, uint offset, uint length, IDxcBlob** ppResult) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateBlobFromBlob(ref pBlob.GetPinnableReference(), offset, length, ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromBlob<TThis>(this TThis thisVtbl, Span<IDxcBlob> pBlob, uint offset, uint length, ref IDxcBlob* ppResult) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateBlobFromBlob(ref pBlob.GetPinnableReference(), offset, length, ref ppResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile<TThis>(this TThis thisVtbl, char* pFileName, Span<uint> codePage, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateBlobFromFile(pFileName, ref codePage.GetPinnableReference(), pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile<TThis>(this TThis thisVtbl, char* pFileName, Span<uint> codePage, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateBlobFromFile(pFileName, ref codePage.GetPinnableReference(), ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile<TThis>(this TThis thisVtbl, Span<char> pFileName, uint* codePage, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateBlobFromFile(ref pFileName.GetPinnableReference(), codePage, pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile<TThis>(this TThis thisVtbl, Span<char> pFileName, uint* codePage, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateBlobFromFile(ref pFileName.GetPinnableReference(), codePage, ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile<TThis>(this TThis thisVtbl, Span<char> pFileName, Span<uint> codePage, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateBlobFromFile(ref pFileName.GetPinnableReference(), ref codePage.GetPinnableReference(), pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile<TThis>(this TThis thisVtbl, Span<char> pFileName, Span<uint> codePage, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateBlobFromFile(ref pFileName.GetPinnableReference(), ref codePage.GetPinnableReference(), ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, Span<uint> codePage, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateBlobFromFile(pFileName, ref codePage.GetPinnableReference(), pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobFromFile<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, Span<uint> codePage, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateBlobFromFile(pFileName, ref codePage.GetPinnableReference(), ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingFromPinned<T0, TThis>(this TThis thisVtbl, Span<T0> pText, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateBlobWithEncodingFromPinned(ref pText.GetPinnableReference(), size, codePage, pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingFromPinned<T0, TThis>(this TThis thisVtbl, Span<T0> pText, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateBlobWithEncodingFromPinned(ref pText.GetPinnableReference(), size, codePage, ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnHeapCopy<T0, TThis>(this TThis thisVtbl, Span<T0> pText, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateBlobWithEncodingOnHeapCopy(ref pText.GetPinnableReference(), size, codePage, pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnHeapCopy<T0, TThis>(this TThis thisVtbl, Span<T0> pText, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateBlobWithEncodingOnHeapCopy(ref pText.GetPinnableReference(), size, codePage, ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc<TThis>(this TThis thisVtbl, void* pText, Span<IMalloc> pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateBlobWithEncodingOnMalloc(pText, ref pIMalloc.GetPinnableReference(), size, codePage, pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc<TThis>(this TThis thisVtbl, void* pText, Span<IMalloc> pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateBlobWithEncodingOnMalloc(pText, ref pIMalloc.GetPinnableReference(), size, codePage, ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc<T0, TThis>(this TThis thisVtbl, Span<T0> pText, IMalloc* pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateBlobWithEncodingOnMalloc(ref pText.GetPinnableReference(), pIMalloc, size, codePage, pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc<T0, TThis>(this TThis thisVtbl, Span<T0> pText, IMalloc* pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateBlobWithEncodingOnMalloc(ref pText.GetPinnableReference(), pIMalloc, size, codePage, ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc<T0, TThis>(this TThis thisVtbl, Span<T0> pText, Span<IMalloc> pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateBlobWithEncodingOnMalloc(ref pText.GetPinnableReference(), ref pIMalloc.GetPinnableReference(), size, codePage, pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlobWithEncodingOnMalloc<T0, TThis>(this TThis thisVtbl, Span<T0> pText, Span<IMalloc> pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateBlobWithEncodingOnMalloc(ref pText.GetPinnableReference(), ref pIMalloc.GetPinnableReference(), size, codePage, ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromBlobReadOnly<TThis>(this TThis thisVtbl, Span<IDxcBlob> pBlob, void** ppStream) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateStreamFromBlobReadOnly(ref pBlob.GetPinnableReference(), ppStream);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromBlobReadOnly<TThis>(this TThis thisVtbl, Span<IDxcBlob> pBlob, ref void* ppStream) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateStreamFromBlobReadOnly(ref pBlob.GetPinnableReference(), ref ppStream);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf8<TThis>(this TThis thisVtbl, Span<IDxcBlob> pBlob, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetBlobAsUtf8(ref pBlob.GetPinnableReference(), pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf8<TThis>(this TThis thisVtbl, Span<IDxcBlob> pBlob, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetBlobAsUtf8(ref pBlob.GetPinnableReference(), ref pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf16<TThis>(this TThis thisVtbl, Span<IDxcBlob> pBlob, IDxcBlobEncoding** pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetBlobAsUtf16(ref pBlob.GetPinnableReference(), pBlobEncoding);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBlobAsUtf16<TThis>(this TThis thisVtbl, Span<IDxcBlob> pBlob, ref IDxcBlobEncoding* pBlobEncoding) where TThis : IComVtbl<IDxcLibrary>
    {
        var @this = (IDxcLibrary*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetBlobAsUtf16(ref pBlob.GetPinnableReference(), ref pBlobEncoding);
    }

}
