// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D.Compilers
{
    [Guid("e5204dc7-d18c-4c3c-bdfb-851673980fe7")]
    [NativeName("Name", "IDxcLibrary")]
    public unsafe partial struct IDxcLibrary
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcLibrary val)
            => Unsafe.As<IDxcLibrary, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcLibrary
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetMalloc(IMalloc* pMalloc)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IMalloc*, int>)LpVtbl[3])(@this, pMalloc);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetMalloc(ref IMalloc pMalloc)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IMalloc* pMallocPtr = &pMalloc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IMalloc*, int>)LpVtbl[3])(@this, pMallocPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobFromBlob(IDxcBlob* pBlob, uint offset, uint length, IDxcBlob** ppResult)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int>)LpVtbl[4])(@this, pBlob, offset, length, ppResult);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobFromBlob(IDxcBlob* pBlob, uint offset, uint length, ref IDxcBlob* ppResult)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDxcBlob** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int>)LpVtbl[4])(@this, pBlob, offset, length, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobFromBlob(ref IDxcBlob pBlob, uint offset, uint length, IDxcBlob** ppResult)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int>)LpVtbl[4])(@this, pBlobPtr, offset, length, ppResult);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobFromBlob(ref IDxcBlob pBlob, uint offset, uint length, ref IDxcBlob* ppResult)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                fixed (IDxcBlob** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int>)LpVtbl[4])(@this, pBlobPtr, offset, length, ppResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobFromFile(char* pFileName, uint* codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileName, codePage, pBlobEncoding);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobFromFile(char* pFileName, uint* codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileName, codePage, pBlobEncodingPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobFromFile(char* pFileName, ref uint codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* codePagePtr = &codePage)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileName, codePagePtr, pBlobEncoding);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobFromFile(char* pFileName, ref uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* codePagePtr = &codePage)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileName, codePagePtr, pBlobEncodingPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobFromFile(ref char pFileName, uint* codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (char* pFileNamePtr = &pFileName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePage, pBlobEncoding);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobFromFile(ref char pFileName, uint* codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (char* pFileNamePtr = &pFileName)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePage, pBlobEncodingPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobFromFile(ref char pFileName, ref uint codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (char* pFileNamePtr = &pFileName)
            {
                fixed (uint* codePagePtr = &codePage)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePagePtr, pBlobEncoding);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobFromFile(ref char pFileName, ref uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (char* pFileNamePtr = &pFileName)
            {
                fixed (uint* codePagePtr = &codePage)
                {
                    fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePagePtr, pBlobEncodingPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobFromFile(string pFileName, uint* codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            var pFileNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pFileName);
            ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, byte*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePage, pBlobEncoding);
            Marshal.FreeHGlobal((IntPtr)pFileNamePtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobFromFile(string pFileName, uint* codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            var pFileNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pFileName);
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, byte*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePage, pBlobEncodingPtr);
            }
            Marshal.FreeHGlobal((IntPtr)pFileNamePtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobFromFile(string pFileName, ref uint codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            var pFileNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pFileName);
            fixed (uint* codePagePtr = &codePage)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, byte*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePagePtr, pBlobEncoding);
            }
            Marshal.FreeHGlobal((IntPtr)pFileNamePtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobFromFile(string pFileName, ref uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            var pFileNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pFileName);
            fixed (uint* codePagePtr = &codePage)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, byte*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePagePtr, pBlobEncodingPtr);
                }
            }
            Marshal.FreeHGlobal((IntPtr)pFileNamePtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobWithEncodingFromPinned(void* pText, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[6])(@this, pText, size, codePage, pBlobEncoding);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobWithEncodingFromPinned(void* pText, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[6])(@this, pText, size, codePage, pBlobEncodingPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobWithEncodingFromPinned<T0>(ref T0 pText, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pTextPtr = &pText)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, T0*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[6])(@this, pTextPtr, size, codePage, pBlobEncoding);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobWithEncodingFromPinned<T0>(ref T0 pText, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pTextPtr = &pText)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, T0*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[6])(@this, pTextPtr, size, codePage, pBlobEncodingPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobWithEncodingOnHeapCopy(void* pText, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pText, size, codePage, pBlobEncoding);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobWithEncodingOnHeapCopy(void* pText, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pText, size, codePage, pBlobEncodingPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobWithEncodingOnHeapCopy<T0>(ref T0 pText, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pTextPtr = &pText)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, T0*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pTextPtr, size, codePage, pBlobEncoding);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobWithEncodingOnHeapCopy<T0>(ref T0 pText, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pTextPtr = &pText)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, T0*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pTextPtr, size, codePage, pBlobEncodingPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobWithEncodingOnMalloc(void* pText, IMalloc* pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pText, pIMalloc, size, codePage, pBlobEncoding);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobWithEncodingOnMalloc(void* pText, IMalloc* pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pText, pIMalloc, size, codePage, pBlobEncodingPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobWithEncodingOnMalloc(void* pText, ref IMalloc pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IMalloc* pIMallocPtr = &pIMalloc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pText, pIMallocPtr, size, codePage, pBlobEncoding);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobWithEncodingOnMalloc(void* pText, ref IMalloc pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IMalloc* pIMallocPtr = &pIMalloc)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pText, pIMallocPtr, size, codePage, pBlobEncodingPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobWithEncodingOnMalloc<T0>(ref T0 pText, IMalloc* pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pTextPtr = &pText)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, T0*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pTextPtr, pIMalloc, size, codePage, pBlobEncoding);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobWithEncodingOnMalloc<T0>(ref T0 pText, IMalloc* pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pTextPtr = &pText)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, T0*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pTextPtr, pIMalloc, size, codePage, pBlobEncodingPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobWithEncodingOnMalloc<T0>(ref T0 pText, ref IMalloc pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pTextPtr = &pText)
            {
                fixed (IMalloc* pIMallocPtr = &pIMalloc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, T0*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pTextPtr, pIMallocPtr, size, codePage, pBlobEncoding);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateBlobWithEncodingOnMalloc<T0>(ref T0 pText, ref IMalloc pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pTextPtr = &pText)
            {
                fixed (IMalloc* pIMallocPtr = &pIMalloc)
                {
                    fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, T0*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pTextPtr, pIMallocPtr, size, codePage, pBlobEncodingPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateIncludeHandler(IDxcIncludeHandler** ppResult)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcIncludeHandler**, int>)LpVtbl[9])(@this, ppResult);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateIncludeHandler(ref IDxcIncludeHandler* ppResult)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDxcIncludeHandler** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcIncludeHandler**, int>)LpVtbl[9])(@this, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateStreamFromBlobReadOnly(IDxcBlob* pBlob, void** ppStream)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, void**, int>)LpVtbl[10])(@this, pBlob, ppStream);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateStreamFromBlobReadOnly(IDxcBlob* pBlob, ref void* ppStream)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppStreamPtr = &ppStream)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, void**, int>)LpVtbl[10])(@this, pBlob, ppStreamPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateStreamFromBlobReadOnly(ref IDxcBlob pBlob, void** ppStream)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, void**, int>)LpVtbl[10])(@this, pBlobPtr, ppStream);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateStreamFromBlobReadOnly(ref IDxcBlob pBlob, ref void* ppStream)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                fixed (void** ppStreamPtr = &ppStream)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, void**, int>)LpVtbl[10])(@this, pBlobPtr, ppStreamPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetBlobAsUtf8(IDxcBlob* pBlob, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[11])(@this, pBlob, pBlobEncoding);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetBlobAsUtf8(IDxcBlob* pBlob, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[11])(@this, pBlob, pBlobEncodingPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetBlobAsUtf8(ref IDxcBlob pBlob, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[11])(@this, pBlobPtr, pBlobEncoding);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetBlobAsUtf8(ref IDxcBlob pBlob, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[11])(@this, pBlobPtr, pBlobEncodingPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetBlobAsUtf16(IDxcBlob* pBlob, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[12])(@this, pBlob, pBlobEncoding);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetBlobAsUtf16(IDxcBlob* pBlob, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[12])(@this, pBlob, pBlobEncodingPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetBlobAsUtf16(ref IDxcBlob pBlob, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[12])(@this, pBlobPtr, pBlobEncoding);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetBlobAsUtf16(ref IDxcBlob pBlob, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcLibrary*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[12])(@this, pBlobPtr, pBlobEncodingPtr);
                }
            }
            return ret;
        }

    }
}
