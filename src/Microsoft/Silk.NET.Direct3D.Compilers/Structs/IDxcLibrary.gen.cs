// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D.Compilers
{
    [NativeName("Name", "IDxcLibrary")]
    public unsafe partial struct IDxcLibrary
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcLibrary val)
            => Unsafe.As<IDxcLibrary, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (IDxcLibrary* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public IDxcLibrary
        (
            void** lpVtbl = default
        )
        {
            LpVtbl = lpVtbl;
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcLibrary*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDxcLibrary*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDxcLibrary*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDxcLibrary*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDxcLibrary* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDxcLibrary*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDxcLibrary* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDxcLibrary*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetMalloc(IMalloc* pMalloc)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcLibrary*, IMalloc*, int>)LpVtbl[3])(@this, pMalloc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetMalloc(ref IMalloc pMalloc)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (IMalloc* pMallocPtr = &pMalloc)
                {
                    ret = ((delegate* cdecl<IDxcLibrary*, IMalloc*, int>)LpVtbl[3])(@this, pMallocPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobFromBlob(IDxcBlob* pBlob, uint offset, uint length, IDxcBlob** ppResult)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int>)LpVtbl[4])(@this, pBlob, offset, length, ppResult);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobFromBlob(IDxcBlob* pBlob, uint offset, uint length, ref IDxcBlob* ppResult)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlob** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* cdecl<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int>)LpVtbl[4])(@this, pBlob, offset, length, ppResultPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobFromBlob(ref IDxcBlob pBlob, uint offset, uint length, IDxcBlob** ppResult)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlob* pBlobPtr = &pBlob)
                {
                    ret = ((delegate* cdecl<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int>)LpVtbl[4])(@this, pBlobPtr, offset, length, ppResult);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobFromBlob(ref IDxcBlob pBlob, uint offset, uint length, ref IDxcBlob* ppResult)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlob* pBlobPtr = &pBlob)
                {
                    fixed (IDxcBlob** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* cdecl<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int>)LpVtbl[4])(@this, pBlobPtr, offset, length, ppResultPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobFromFile(char* pFileName, uint* codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileName, codePage, pBlobEncoding);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobFromFile(char* pFileName, uint* codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* cdecl<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileName, codePage, pBlobEncodingPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobFromFile(char* pFileName, ref uint codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (uint* codePagePtr = &codePage)
                {
                    ret = ((delegate* cdecl<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileName, codePagePtr, pBlobEncoding);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobFromFile(char* pFileName, ref uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (uint* codePagePtr = &codePage)
                {
                    fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                    {
                        ret = ((delegate* cdecl<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileName, codePagePtr, pBlobEncodingPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobFromFile(ref char pFileName, uint* codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (char* pFileNamePtr = &pFileName)
                {
                    ret = ((delegate* cdecl<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePage, pBlobEncoding);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobFromFile(ref char pFileName, uint* codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (char* pFileNamePtr = &pFileName)
                {
                    fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                    {
                        ret = ((delegate* cdecl<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePage, pBlobEncodingPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobFromFile(ref char pFileName, ref uint codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (char* pFileNamePtr = &pFileName)
                {
                    fixed (uint* codePagePtr = &codePage)
                    {
                        ret = ((delegate* cdecl<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePagePtr, pBlobEncoding);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobFromFile(ref char pFileName, ref uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (char* pFileNamePtr = &pFileName)
                {
                    fixed (uint* codePagePtr = &codePage)
                    {
                        fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                        {
                            ret = ((delegate* cdecl<IDxcLibrary*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePagePtr, pBlobEncodingPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobFromFile(string pFileName, uint* codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
            var pFileNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pFileName);
                ret = ((delegate* cdecl<IDxcLibrary*, byte*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePage, pBlobEncoding);
            Marshal.FreeHGlobal((IntPtr)pFileNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobFromFile(string pFileName, uint* codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
            var pFileNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pFileName);
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* cdecl<IDxcLibrary*, byte*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePage, pBlobEncodingPtr);
                }
            Marshal.FreeHGlobal((IntPtr)pFileNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobFromFile(string pFileName, ref uint codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
            var pFileNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pFileName);
                fixed (uint* codePagePtr = &codePage)
                {
                    ret = ((delegate* cdecl<IDxcLibrary*, byte*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePagePtr, pBlobEncoding);
                }
            Marshal.FreeHGlobal((IntPtr)pFileNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobFromFile(string pFileName, ref uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
            var pFileNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pFileName);
                fixed (uint* codePagePtr = &codePage)
                {
                    fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                    {
                        ret = ((delegate* cdecl<IDxcLibrary*, byte*, uint*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pFileNamePtr, codePagePtr, pBlobEncodingPtr);
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pFileNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobWithEncodingFromPinned(void* pText, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[6])(@this, pText, size, codePage, pBlobEncoding);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobWithEncodingFromPinned(void* pText, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* cdecl<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[6])(@this, pText, size, codePage, pBlobEncodingPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobWithEncodingFromPinned<T0>(ref T0 pText, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (T0* pTextPtr = &pText)
                {
                    ret = ((delegate* cdecl<IDxcLibrary*, T0*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[6])(@this, pTextPtr, size, codePage, pBlobEncoding);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobWithEncodingFromPinned<T0>(ref T0 pText, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (T0* pTextPtr = &pText)
                {
                    fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                    {
                        ret = ((delegate* cdecl<IDxcLibrary*, T0*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[6])(@this, pTextPtr, size, codePage, pBlobEncodingPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobWithEncodingOnHeapCopy(void* pText, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pText, size, codePage, pBlobEncoding);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobWithEncodingOnHeapCopy(void* pText, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* cdecl<IDxcLibrary*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pText, size, codePage, pBlobEncodingPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobWithEncodingOnHeapCopy<T0>(ref T0 pText, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (T0* pTextPtr = &pText)
                {
                    ret = ((delegate* cdecl<IDxcLibrary*, T0*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pTextPtr, size, codePage, pBlobEncoding);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobWithEncodingOnHeapCopy<T0>(ref T0 pText, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (T0* pTextPtr = &pText)
                {
                    fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                    {
                        ret = ((delegate* cdecl<IDxcLibrary*, T0*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pTextPtr, size, codePage, pBlobEncodingPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobWithEncodingOnMalloc(void* pText, IMalloc* pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pText, pIMalloc, size, codePage, pBlobEncoding);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobWithEncodingOnMalloc(void* pText, IMalloc* pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* cdecl<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pText, pIMalloc, size, codePage, pBlobEncodingPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobWithEncodingOnMalloc(void* pText, ref IMalloc pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (IMalloc* pIMallocPtr = &pIMalloc)
                {
                    ret = ((delegate* cdecl<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pText, pIMallocPtr, size, codePage, pBlobEncoding);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobWithEncodingOnMalloc(void* pText, ref IMalloc pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (IMalloc* pIMallocPtr = &pIMalloc)
                {
                    fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                    {
                        ret = ((delegate* cdecl<IDxcLibrary*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pText, pIMallocPtr, size, codePage, pBlobEncodingPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobWithEncodingOnMalloc<T0>(ref T0 pText, IMalloc* pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (T0* pTextPtr = &pText)
                {
                    ret = ((delegate* cdecl<IDxcLibrary*, T0*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pTextPtr, pIMalloc, size, codePage, pBlobEncoding);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobWithEncodingOnMalloc<T0>(ref T0 pText, IMalloc* pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (T0* pTextPtr = &pText)
                {
                    fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                    {
                        ret = ((delegate* cdecl<IDxcLibrary*, T0*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pTextPtr, pIMalloc, size, codePage, pBlobEncodingPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobWithEncodingOnMalloc<T0>(ref T0 pText, ref IMalloc pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (T0* pTextPtr = &pText)
                {
                    fixed (IMalloc* pIMallocPtr = &pIMalloc)
                    {
                        ret = ((delegate* cdecl<IDxcLibrary*, T0*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pTextPtr, pIMallocPtr, size, codePage, pBlobEncoding);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateBlobWithEncodingOnMalloc<T0>(ref T0 pText, ref IMalloc pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (T0* pTextPtr = &pText)
                {
                    fixed (IMalloc* pIMallocPtr = &pIMalloc)
                    {
                        fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                        {
                            ret = ((delegate* cdecl<IDxcLibrary*, T0*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[8])(@this, pTextPtr, pIMallocPtr, size, codePage, pBlobEncodingPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateIncludeHandler(IDxcIncludeHandler** ppResult)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcLibrary*, IDxcIncludeHandler**, int>)LpVtbl[9])(@this, ppResult);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateIncludeHandler(ref IDxcIncludeHandler* ppResult)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (IDxcIncludeHandler** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* cdecl<IDxcLibrary*, IDxcIncludeHandler**, int>)LpVtbl[9])(@this, ppResultPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateStreamFromBlobReadOnly(IDxcBlob* pBlob, void** ppStream)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcLibrary*, IDxcBlob*, void**, int>)LpVtbl[10])(@this, pBlob, ppStream);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateStreamFromBlobReadOnly(IDxcBlob* pBlob, ref void* ppStream)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (void** ppStreamPtr = &ppStream)
                {
                    ret = ((delegate* cdecl<IDxcLibrary*, IDxcBlob*, void**, int>)LpVtbl[10])(@this, pBlob, ppStreamPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateStreamFromBlobReadOnly(ref IDxcBlob pBlob, void** ppStream)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlob* pBlobPtr = &pBlob)
                {
                    ret = ((delegate* cdecl<IDxcLibrary*, IDxcBlob*, void**, int>)LpVtbl[10])(@this, pBlobPtr, ppStream);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateStreamFromBlobReadOnly(ref IDxcBlob pBlob, ref void* ppStream)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlob* pBlobPtr = &pBlob)
                {
                    fixed (void** ppStreamPtr = &ppStream)
                    {
                        ret = ((delegate* cdecl<IDxcLibrary*, IDxcBlob*, void**, int>)LpVtbl[10])(@this, pBlobPtr, ppStreamPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetBlobAsUtf8(IDxcBlob* pBlob, IDxcBlobEncoding** pBlobEncoding)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[11])(@this, pBlob, pBlobEncoding);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetBlobAsUtf8(IDxcBlob* pBlob, ref IDxcBlobEncoding* pBlobEncoding)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* cdecl<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[11])(@this, pBlob, pBlobEncodingPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetBlobAsUtf8(ref IDxcBlob pBlob, IDxcBlobEncoding** pBlobEncoding)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlob* pBlobPtr = &pBlob)
                {
                    ret = ((delegate* cdecl<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[11])(@this, pBlobPtr, pBlobEncoding);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetBlobAsUtf8(ref IDxcBlob pBlob, ref IDxcBlobEncoding* pBlobEncoding)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlob* pBlobPtr = &pBlob)
                {
                    fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                    {
                        ret = ((delegate* cdecl<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[11])(@this, pBlobPtr, pBlobEncodingPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetBlobAsUtf16(IDxcBlob* pBlob, IDxcBlobEncoding** pBlobEncoding)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[12])(@this, pBlob, pBlobEncoding);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetBlobAsUtf16(IDxcBlob* pBlob, ref IDxcBlobEncoding* pBlobEncoding)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* cdecl<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[12])(@this, pBlob, pBlobEncodingPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetBlobAsUtf16(ref IDxcBlob pBlob, IDxcBlobEncoding** pBlobEncoding)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlob* pBlobPtr = &pBlob)
                {
                    ret = ((delegate* cdecl<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[12])(@this, pBlobPtr, pBlobEncoding);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetBlobAsUtf16(ref IDxcBlob pBlob, ref IDxcBlobEncoding* pBlobEncoding)
        {
            fixed (IDxcLibrary* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlob* pBlobPtr = &pBlob)
                {
                    fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                    {
                        ret = ((delegate* cdecl<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)LpVtbl[12])(@this, pBlobPtr, pBlobEncodingPtr);
                    }
                }
                return ret;
            }
        }

    }
}
