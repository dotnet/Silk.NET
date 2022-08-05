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

namespace Silk.NET.Direct2D
{
    [Guid("ac7b67a6-183e-49c1-a823-0ebe40b0db29")]
    [NativeName("Name", "ID2D1SvgElement")]
    public unsafe partial struct ID2D1SvgElement
    {
        public static readonly Guid Guid = new("ac7b67a6-183e-49c1-a823-0ebe40b0db29");

        public static implicit operator ID2D1Resource(ID2D1SvgElement val)
            => Unsafe.As<ID2D1SvgElement, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1SvgElement val)
            => Unsafe.As<ID2D1SvgElement, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1SvgElement
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
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1Factory**, void>)LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ref ID2D1Factory* factory)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Factory** factoryPtr = &factory)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1Factory**, void>)LpVtbl[3])(@this, factoryPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDocument(ID2D1SvgDocument** document)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgDocument**, void>)LpVtbl[4])(@this, document);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDocument(ref ID2D1SvgDocument* document)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1SvgDocument** documentPtr = &document)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgDocument**, void>)LpVtbl[4])(@this, documentPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTagName(char* name, uint nameCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, uint, int>)LpVtbl[5])(@this, name, nameCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTagName(ref char name, uint nameCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, uint, int>)LpVtbl[5])(@this, namePtr, nameCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTagName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, uint nameCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, uint, int>)LpVtbl[5])(@this, namePtr, nameCount);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetTagNameLength()
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint>)LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsTextContent()
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, int>)LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetParent(ID2D1SvgElement** parent)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement**, void>)LpVtbl[8])(@this, parent);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetParent(ref ID2D1SvgElement* parent)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1SvgElement** parentPtr = &parent)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement**, void>)LpVtbl[8])(@this, parentPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int HasChildren()
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, int>)LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFirstChild(ID2D1SvgElement** child)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement**, void>)LpVtbl[10])(@this, child);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFirstChild(ref ID2D1SvgElement* child)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1SvgElement** childPtr = &child)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement**, void>)LpVtbl[10])(@this, childPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetLastChild(ID2D1SvgElement** child)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement**, void>)LpVtbl[11])(@this, child);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetLastChild(ref ID2D1SvgElement* child)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1SvgElement** childPtr = &child)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement**, void>)LpVtbl[11])(@this, childPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPreviousChild(ID2D1SvgElement* referenceChild, ID2D1SvgElement** previousChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)LpVtbl[12])(@this, referenceChild, previousChild);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPreviousChild(ID2D1SvgElement* referenceChild, ref ID2D1SvgElement* previousChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgElement** previousChildPtr = &previousChild)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)LpVtbl[12])(@this, referenceChild, previousChildPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPreviousChild(ref ID2D1SvgElement referenceChild, ID2D1SvgElement** previousChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgElement* referenceChildPtr = &referenceChild)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)LpVtbl[12])(@this, referenceChildPtr, previousChild);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPreviousChild(ref ID2D1SvgElement referenceChild, ref ID2D1SvgElement* previousChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgElement* referenceChildPtr = &referenceChild)
            {
                fixed (ID2D1SvgElement** previousChildPtr = &previousChild)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)LpVtbl[12])(@this, referenceChildPtr, previousChildPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetNextChild(ID2D1SvgElement* referenceChild, ID2D1SvgElement** nextChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)LpVtbl[13])(@this, referenceChild, nextChild);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetNextChild(ID2D1SvgElement* referenceChild, ref ID2D1SvgElement* nextChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgElement** nextChildPtr = &nextChild)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)LpVtbl[13])(@this, referenceChild, nextChildPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetNextChild(ref ID2D1SvgElement referenceChild, ID2D1SvgElement** nextChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgElement* referenceChildPtr = &referenceChild)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)LpVtbl[13])(@this, referenceChildPtr, nextChild);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetNextChild(ref ID2D1SvgElement referenceChild, ref ID2D1SvgElement* nextChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgElement* referenceChildPtr = &referenceChild)
            {
                fixed (ID2D1SvgElement** nextChildPtr = &nextChild)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)LpVtbl[13])(@this, referenceChildPtr, nextChildPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int InsertChildBefore(ID2D1SvgElement* newChild, ID2D1SvgElement* referenceChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int>)LpVtbl[14])(@this, newChild, referenceChild);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int InsertChildBefore(ID2D1SvgElement* newChild, ref ID2D1SvgElement referenceChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgElement* referenceChildPtr = &referenceChild)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int>)LpVtbl[14])(@this, newChild, referenceChildPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int InsertChildBefore(ref ID2D1SvgElement newChild, ID2D1SvgElement* referenceChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgElement* newChildPtr = &newChild)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int>)LpVtbl[14])(@this, newChildPtr, referenceChild);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int InsertChildBefore(ref ID2D1SvgElement newChild, ref ID2D1SvgElement referenceChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgElement* newChildPtr = &newChild)
            {
                fixed (ID2D1SvgElement* referenceChildPtr = &referenceChild)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int>)LpVtbl[14])(@this, newChildPtr, referenceChildPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AppendChild(ID2D1SvgElement* newChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, int>)LpVtbl[15])(@this, newChild);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AppendChild(ref ID2D1SvgElement newChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgElement* newChildPtr = &newChild)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, int>)LpVtbl[15])(@this, newChildPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReplaceChild(ID2D1SvgElement* newChild, ID2D1SvgElement* oldChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int>)LpVtbl[16])(@this, newChild, oldChild);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReplaceChild(ID2D1SvgElement* newChild, ref ID2D1SvgElement oldChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgElement* oldChildPtr = &oldChild)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int>)LpVtbl[16])(@this, newChild, oldChildPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReplaceChild(ref ID2D1SvgElement newChild, ID2D1SvgElement* oldChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgElement* newChildPtr = &newChild)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int>)LpVtbl[16])(@this, newChildPtr, oldChild);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ReplaceChild(ref ID2D1SvgElement newChild, ref ID2D1SvgElement oldChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgElement* newChildPtr = &newChild)
            {
                fixed (ID2D1SvgElement* oldChildPtr = &oldChild)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int>)LpVtbl[16])(@this, newChildPtr, oldChildPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RemoveChild(ID2D1SvgElement* oldChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, int>)LpVtbl[17])(@this, oldChild);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveChild(ref ID2D1SvgElement oldChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgElement* oldChildPtr = &oldChild)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, int>)LpVtbl[17])(@this, oldChildPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateChild(char* tagName, ID2D1SvgElement** newChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, ID2D1SvgElement**, int>)LpVtbl[18])(@this, tagName, newChild);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateChild(char* tagName, ref ID2D1SvgElement* newChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgElement** newChildPtr = &newChild)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, ID2D1SvgElement**, int>)LpVtbl[18])(@this, tagName, newChildPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateChild(ref char tagName, ID2D1SvgElement** newChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* tagNamePtr = &tagName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, ID2D1SvgElement**, int>)LpVtbl[18])(@this, tagNamePtr, newChild);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateChild(ref char tagName, ref ID2D1SvgElement* newChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* tagNamePtr = &tagName)
            {
                fixed (ID2D1SvgElement** newChildPtr = &newChild)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, ID2D1SvgElement**, int>)LpVtbl[18])(@this, tagNamePtr, newChildPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateChild([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string tagName, ID2D1SvgElement** newChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var tagNamePtr = (byte*) SilkMarshal.StringToPtr(tagName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, ID2D1SvgElement**, int>)LpVtbl[18])(@this, tagNamePtr, newChild);
            SilkMarshal.Free((nint)tagNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateChild([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string tagName, ref ID2D1SvgElement* newChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var tagNamePtr = (byte*) SilkMarshal.StringToPtr(tagName, NativeStringEncoding.UTF8);
            fixed (ID2D1SvgElement** newChildPtr = &newChild)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, ID2D1SvgElement**, int>)LpVtbl[18])(@this, tagNamePtr, newChildPtr);
            }
            SilkMarshal.Free((nint)tagNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsAttributeSpecified(char* name, int* inherited)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, int*, int>)LpVtbl[19])(@this, name, inherited);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsAttributeSpecified(char* name, ref int inherited)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* inheritedPtr = &inherited)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, int*, int>)LpVtbl[19])(@this, name, inheritedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsAttributeSpecified(ref char name, int* inherited)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, int*, int>)LpVtbl[19])(@this, namePtr, inherited);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsAttributeSpecified(ref char name, ref int inherited)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
                fixed (int* inheritedPtr = &inherited)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, int*, int>)LpVtbl[19])(@this, namePtr, inheritedPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsAttributeSpecified([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, int* inherited)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, int*, int>)LpVtbl[19])(@this, namePtr, inherited);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsAttributeSpecified([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, ref int inherited)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            fixed (int* inheritedPtr = &inherited)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, int*, int>)LpVtbl[19])(@this, namePtr, inheritedPtr);
            }
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetSpecifiedAttributeCount()
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint>)LpVtbl[20])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSpecifiedAttributeName(uint index, char* name, uint nameCount, int* inherited)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, char*, uint, int*, int>)LpVtbl[21])(@this, index, name, nameCount, inherited);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSpecifiedAttributeName(uint index, char* name, uint nameCount, ref int inherited)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* inheritedPtr = &inherited)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, char*, uint, int*, int>)LpVtbl[21])(@this, index, name, nameCount, inheritedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSpecifiedAttributeName(uint index, ref char name, uint nameCount, int* inherited)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, char*, uint, int*, int>)LpVtbl[21])(@this, index, namePtr, nameCount, inherited);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSpecifiedAttributeName(uint index, ref char name, uint nameCount, ref int inherited)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
                fixed (int* inheritedPtr = &inherited)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, char*, uint, int*, int>)LpVtbl[21])(@this, index, namePtr, nameCount, inheritedPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSpecifiedAttributeName(uint index, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, uint nameCount, int* inherited)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, byte*, uint, int*, int>)LpVtbl[21])(@this, index, namePtr, nameCount, inherited);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSpecifiedAttributeName(uint index, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, uint nameCount, ref int inherited)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            fixed (int* inheritedPtr = &inherited)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, byte*, uint, int*, int>)LpVtbl[21])(@this, index, namePtr, nameCount, inheritedPtr);
            }
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSpecifiedAttributeNameLength(uint index, uint* nameLength, int* inherited)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, uint*, int*, int>)LpVtbl[22])(@this, index, nameLength, inherited);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSpecifiedAttributeNameLength(uint index, uint* nameLength, ref int inherited)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* inheritedPtr = &inherited)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, uint*, int*, int>)LpVtbl[22])(@this, index, nameLength, inheritedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSpecifiedAttributeNameLength(uint index, ref uint nameLength, int* inherited)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* nameLengthPtr = &nameLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, uint*, int*, int>)LpVtbl[22])(@this, index, nameLengthPtr, inherited);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSpecifiedAttributeNameLength(uint index, ref uint nameLength, ref int inherited)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* nameLengthPtr = &nameLength)
            {
                fixed (int* inheritedPtr = &inherited)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, uint*, int*, int>)LpVtbl[22])(@this, index, nameLengthPtr, inheritedPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RemoveAttribute(char* name)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, int>)LpVtbl[23])(@this, name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveAttribute(ref char name)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, int>)LpVtbl[23])(@this, namePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveAttribute([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, int>)LpVtbl[23])(@this, namePtr);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTextValue(char* name, uint nameCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, uint, int>)LpVtbl[24])(@this, name, nameCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTextValue(ref char name, uint nameCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, uint, int>)LpVtbl[24])(@this, namePtr, nameCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTextValue([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, uint nameCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, uint, int>)LpVtbl[24])(@this, namePtr, nameCount);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextValue(char* name, uint nameCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, uint, int>)LpVtbl[25])(@this, name, nameCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTextValue(ref char name, uint nameCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, uint, int>)LpVtbl[25])(@this, namePtr, nameCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTextValue([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, uint nameCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, uint, int>)LpVtbl[25])(@this, namePtr, nameCount);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetTextValueLength()
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint>)LpVtbl[26])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetAttributeValue(char* name, SvgAttributeStringType type, char* value)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, char*, int>)LpVtbl[27])(@this, name, type, value);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetAttributeValue(char* name, SvgAttributeStringType type, ref char value)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* valuePtr = &value)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, char*, int>)LpVtbl[27])(@this, name, type, valuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetAttributeValue(char* name, SvgAttributeStringType type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var valuePtr = (byte*) SilkMarshal.StringToPtr(value, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, byte*, int>)LpVtbl[27])(@this, name, type, valuePtr);
            SilkMarshal.Free((nint)valuePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetAttributeValue(ref char name, SvgAttributeStringType type, char* value)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, char*, int>)LpVtbl[27])(@this, namePtr, type, value);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAttributeValue(ref char name, SvgAttributeStringType type, ref char value)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
                fixed (char* valuePtr = &value)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, char*, int>)LpVtbl[27])(@this, namePtr, type, valuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAttributeValue(ref char name, SvgAttributeStringType type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
            var valuePtr = (byte*) SilkMarshal.StringToPtr(value, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, byte*, int>)LpVtbl[27])(@this, namePtr, type, valuePtr);
            SilkMarshal.Free((nint)valuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetAttributeValue([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SvgAttributeStringType type, char* value)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, SvgAttributeStringType, char*, int>)LpVtbl[27])(@this, namePtr, type, value);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAttributeValue([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SvgAttributeStringType type, ref char value)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            fixed (char* valuePtr = &value)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, SvgAttributeStringType, char*, int>)LpVtbl[27])(@this, namePtr, type, valuePtr);
            }
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAttributeValue([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SvgAttributeStringType type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            var valuePtr = (byte*) SilkMarshal.StringToPtr(value, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, SvgAttributeStringType, byte*, int>)LpVtbl[27])(@this, namePtr, type, valuePtr);
            SilkMarshal.Free((nint)valuePtr);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAttributeValue(char* name, SvgAttributeStringType type, char* value, uint valueCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, char*, uint, int>)LpVtbl[28])(@this, name, type, value, valueCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAttributeValue(char* name, SvgAttributeStringType type, ref char value, uint valueCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* valuePtr = &value)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, char*, uint, int>)LpVtbl[28])(@this, name, type, valuePtr, valueCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAttributeValue(char* name, SvgAttributeStringType type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value, uint valueCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var valuePtr = (byte*) SilkMarshal.StringToPtr(value, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, byte*, uint, int>)LpVtbl[28])(@this, name, type, valuePtr, valueCount);
            SilkMarshal.Free((nint)valuePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAttributeValue(ref char name, SvgAttributeStringType type, char* value, uint valueCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, char*, uint, int>)LpVtbl[28])(@this, namePtr, type, value, valueCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAttributeValue(ref char name, SvgAttributeStringType type, ref char value, uint valueCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
                fixed (char* valuePtr = &value)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, char*, uint, int>)LpVtbl[28])(@this, namePtr, type, valuePtr, valueCount);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAttributeValue(ref char name, SvgAttributeStringType type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value, uint valueCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
            var valuePtr = (byte*) SilkMarshal.StringToPtr(value, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, byte*, uint, int>)LpVtbl[28])(@this, namePtr, type, valuePtr, valueCount);
            SilkMarshal.Free((nint)valuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAttributeValue([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SvgAttributeStringType type, char* value, uint valueCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, SvgAttributeStringType, char*, uint, int>)LpVtbl[28])(@this, namePtr, type, value, valueCount);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAttributeValue([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SvgAttributeStringType type, ref char value, uint valueCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            fixed (char* valuePtr = &value)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, SvgAttributeStringType, char*, uint, int>)LpVtbl[28])(@this, namePtr, type, valuePtr, valueCount);
            }
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAttributeValue([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SvgAttributeStringType type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value, uint valueCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            var valuePtr = (byte*) SilkMarshal.StringToPtr(value, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, SvgAttributeStringType, byte*, uint, int>)LpVtbl[28])(@this, namePtr, type, valuePtr, valueCount);
            SilkMarshal.Free((nint)valuePtr);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAttributeValueLength(char* name, SvgAttributeStringType type, uint* valueLength)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, uint*, int>)LpVtbl[29])(@this, name, type, valueLength);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAttributeValueLength(char* name, SvgAttributeStringType type, ref uint valueLength)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* valueLengthPtr = &valueLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, uint*, int>)LpVtbl[29])(@this, name, type, valueLengthPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAttributeValueLength(ref char name, SvgAttributeStringType type, uint* valueLength)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, uint*, int>)LpVtbl[29])(@this, namePtr, type, valueLength);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAttributeValueLength(ref char name, SvgAttributeStringType type, ref uint valueLength)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
                fixed (uint* valueLengthPtr = &valueLength)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, uint*, int>)LpVtbl[29])(@this, namePtr, type, valueLengthPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAttributeValueLength([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SvgAttributeStringType type, uint* valueLength)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, SvgAttributeStringType, uint*, int>)LpVtbl[29])(@this, namePtr, type, valueLength);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAttributeValueLength([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SvgAttributeStringType type, ref uint valueLength)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            fixed (uint* valueLengthPtr = &valueLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, SvgAttributeStringType, uint*, int>)LpVtbl[29])(@this, namePtr, type, valueLengthPtr);
            }
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

    }
}
