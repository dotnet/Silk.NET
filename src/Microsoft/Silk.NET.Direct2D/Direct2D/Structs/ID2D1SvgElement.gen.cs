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
    public unsafe partial struct ID2D1SvgElement : IComVtbl<ID2D1SvgElement>, IComVtbl<ID2D1Resource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("ac7b67a6-183e-49c1-a823-0ebe40b0db29");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

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
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
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
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
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
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ref ID2D1Factory* factory)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Factory** factoryPtr = &factory)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDocument(ID2D1SvgDocument** document)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgDocument**, void>)@this->LpVtbl[4])(@this, document);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDocument(ref ID2D1SvgDocument* document)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1SvgDocument** documentPtr = &document)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgDocument**, void>)@this->LpVtbl[4])(@this, documentPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTagName(char* name, uint nameCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, uint, int>)@this->LpVtbl[5])(@this, name, nameCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTagName(ref char name, uint nameCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, uint, int>)@this->LpVtbl[5])(@this, namePtr, nameCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTagName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, uint nameCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, uint, int>)@this->LpVtbl[5])(@this, namePtr, nameCount);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetTagNameLength()
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint>)@this->LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsTextContent()
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, Silk.NET.Core.Bool32>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetParent(ID2D1SvgElement** parent)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement**, void>)@this->LpVtbl[8])(@this, parent);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetParent(ref ID2D1SvgElement* parent)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1SvgElement** parentPtr = &parent)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement**, void>)@this->LpVtbl[8])(@this, parentPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 HasChildren()
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, Silk.NET.Core.Bool32>)@this->LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFirstChild(ID2D1SvgElement** child)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement**, void>)@this->LpVtbl[10])(@this, child);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFirstChild(ref ID2D1SvgElement* child)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1SvgElement** childPtr = &child)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement**, void>)@this->LpVtbl[10])(@this, childPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetLastChild(ID2D1SvgElement** child)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement**, void>)@this->LpVtbl[11])(@this, child);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetLastChild(ref ID2D1SvgElement* child)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1SvgElement** childPtr = &child)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement**, void>)@this->LpVtbl[11])(@this, childPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPreviousChild(ID2D1SvgElement* referenceChild, ID2D1SvgElement** previousChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)@this->LpVtbl[12])(@this, referenceChild, previousChild);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPreviousChild(ID2D1SvgElement* referenceChild, ref ID2D1SvgElement* previousChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgElement** previousChildPtr = &previousChild)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)@this->LpVtbl[12])(@this, referenceChild, previousChildPtr);
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
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)@this->LpVtbl[12])(@this, referenceChildPtr, previousChild);
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
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)@this->LpVtbl[12])(@this, referenceChildPtr, previousChildPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetNextChild(ID2D1SvgElement* referenceChild, ID2D1SvgElement** nextChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)@this->LpVtbl[13])(@this, referenceChild, nextChild);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetNextChild(ID2D1SvgElement* referenceChild, ref ID2D1SvgElement* nextChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgElement** nextChildPtr = &nextChild)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)@this->LpVtbl[13])(@this, referenceChild, nextChildPtr);
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
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)@this->LpVtbl[13])(@this, referenceChildPtr, nextChild);
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
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)@this->LpVtbl[13])(@this, referenceChildPtr, nextChildPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int InsertChildBefore(ID2D1SvgElement* newChild, ID2D1SvgElement* referenceChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int>)@this->LpVtbl[14])(@this, newChild, referenceChild);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int InsertChildBefore(ID2D1SvgElement* newChild, ref ID2D1SvgElement referenceChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgElement* referenceChildPtr = &referenceChild)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int>)@this->LpVtbl[14])(@this, newChild, referenceChildPtr);
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
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int>)@this->LpVtbl[14])(@this, newChildPtr, referenceChild);
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
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int>)@this->LpVtbl[14])(@this, newChildPtr, referenceChildPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AppendChild(ID2D1SvgElement* newChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, int>)@this->LpVtbl[15])(@this, newChild);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AppendChild(ref ID2D1SvgElement newChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgElement* newChildPtr = &newChild)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, int>)@this->LpVtbl[15])(@this, newChildPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReplaceChild(ID2D1SvgElement* newChild, ID2D1SvgElement* oldChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int>)@this->LpVtbl[16])(@this, newChild, oldChild);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReplaceChild(ID2D1SvgElement* newChild, ref ID2D1SvgElement oldChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgElement* oldChildPtr = &oldChild)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int>)@this->LpVtbl[16])(@this, newChild, oldChildPtr);
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
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int>)@this->LpVtbl[16])(@this, newChildPtr, oldChild);
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
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int>)@this->LpVtbl[16])(@this, newChildPtr, oldChildPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RemoveChild(ID2D1SvgElement* oldChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, int>)@this->LpVtbl[17])(@this, oldChild);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveChild(ref ID2D1SvgElement oldChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgElement* oldChildPtr = &oldChild)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, int>)@this->LpVtbl[17])(@this, oldChildPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateChild([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* tagName, ID2D1SvgElement** newChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, ID2D1SvgElement**, int>)@this->LpVtbl[18])(@this, tagName, newChild);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateChild([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* tagName, ref ID2D1SvgElement* newChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgElement** newChildPtr = &newChild)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, ID2D1SvgElement**, int>)@this->LpVtbl[18])(@this, tagName, newChildPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateChild([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char tagName, ID2D1SvgElement** newChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* tagNamePtr = &tagName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, ID2D1SvgElement**, int>)@this->LpVtbl[18])(@this, tagNamePtr, newChild);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateChild([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char tagName, ref ID2D1SvgElement* newChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* tagNamePtr = &tagName)
            {
                fixed (ID2D1SvgElement** newChildPtr = &newChild)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, ID2D1SvgElement**, int>)@this->LpVtbl[18])(@this, tagNamePtr, newChildPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateChild([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string tagName, ID2D1SvgElement** newChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var tagNamePtr = (byte*) SilkMarshal.StringToPtr(tagName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, ID2D1SvgElement**, int>)@this->LpVtbl[18])(@this, tagNamePtr, newChild);
            SilkMarshal.Free((nint)tagNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateChild([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string tagName, ref ID2D1SvgElement* newChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var tagNamePtr = (byte*) SilkMarshal.StringToPtr(tagName, NativeStringEncoding.UTF8);
            fixed (ID2D1SvgElement** newChildPtr = &newChild)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, ID2D1SvgElement**, int>)@this->LpVtbl[18])(@this, tagNamePtr, newChildPtr);
            }
            SilkMarshal.Free((nint)tagNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe Silk.NET.Core.Bool32 IsAttributeSpecified([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, int* inherited)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, int*, Silk.NET.Core.Bool32>)@this->LpVtbl[19])(@this, name, inherited);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe Silk.NET.Core.Bool32 IsAttributeSpecified([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, ref int inherited)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            fixed (int* inheritedPtr = &inherited)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, int*, Silk.NET.Core.Bool32>)@this->LpVtbl[19])(@this, name, inheritedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe Silk.NET.Core.Bool32 IsAttributeSpecified([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name, int* inherited)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            fixed (char* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, int*, Silk.NET.Core.Bool32>)@this->LpVtbl[19])(@this, namePtr, inherited);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsAttributeSpecified([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name, ref int inherited)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            fixed (char* namePtr = &name)
            {
                fixed (int* inheritedPtr = &inherited)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, int*, Silk.NET.Core.Bool32>)@this->LpVtbl[19])(@this, namePtr, inheritedPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe Silk.NET.Core.Bool32 IsAttributeSpecified([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, int* inherited)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, int*, Silk.NET.Core.Bool32>)@this->LpVtbl[19])(@this, namePtr, inherited);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsAttributeSpecified([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, ref int inherited)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            fixed (int* inheritedPtr = &inherited)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, int*, Silk.NET.Core.Bool32>)@this->LpVtbl[19])(@this, namePtr, inheritedPtr);
            }
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetSpecifiedAttributeCount()
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint>)@this->LpVtbl[20])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSpecifiedAttributeName(uint index, char* name, uint nameCount, int* inherited)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, char*, uint, int*, int>)@this->LpVtbl[21])(@this, index, name, nameCount, inherited);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSpecifiedAttributeName(uint index, char* name, uint nameCount, ref int inherited)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* inheritedPtr = &inherited)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, char*, uint, int*, int>)@this->LpVtbl[21])(@this, index, name, nameCount, inheritedPtr);
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
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, char*, uint, int*, int>)@this->LpVtbl[21])(@this, index, namePtr, nameCount, inherited);
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
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, char*, uint, int*, int>)@this->LpVtbl[21])(@this, index, namePtr, nameCount, inheritedPtr);
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
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, byte*, uint, int*, int>)@this->LpVtbl[21])(@this, index, namePtr, nameCount, inherited);
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
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, byte*, uint, int*, int>)@this->LpVtbl[21])(@this, index, namePtr, nameCount, inheritedPtr);
            }
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSpecifiedAttributeNameLength(uint index, uint* nameLength, int* inherited)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, uint*, int*, int>)@this->LpVtbl[22])(@this, index, nameLength, inherited);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSpecifiedAttributeNameLength(uint index, uint* nameLength, ref int inherited)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* inheritedPtr = &inherited)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, uint*, int*, int>)@this->LpVtbl[22])(@this, index, nameLength, inheritedPtr);
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
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, uint*, int*, int>)@this->LpVtbl[22])(@this, index, nameLengthPtr, inherited);
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
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, uint*, int*, int>)@this->LpVtbl[22])(@this, index, nameLengthPtr, inheritedPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RemoveAttribute([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, int>)@this->LpVtbl[23])(@this, name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveAttribute([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, int>)@this->LpVtbl[23])(@this, namePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveAttribute([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, int>)@this->LpVtbl[23])(@this, namePtr);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTextValue([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, uint nameCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, uint, int>)@this->LpVtbl[24])(@this, name, nameCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTextValue([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name, uint nameCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, uint, int>)@this->LpVtbl[24])(@this, namePtr, nameCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTextValue([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, uint nameCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, uint, int>)@this->LpVtbl[24])(@this, namePtr, nameCount);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextValue(char* name, uint nameCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, uint, int>)@this->LpVtbl[25])(@this, name, nameCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTextValue(ref char name, uint nameCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, uint, int>)@this->LpVtbl[25])(@this, namePtr, nameCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTextValue([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, uint nameCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, uint, int>)@this->LpVtbl[25])(@this, namePtr, nameCount);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetTextValueLength()
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint>)@this->LpVtbl[26])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetAttributeValue([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, SvgAttributeStringType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* value)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, char*, int>)@this->LpVtbl[29])(@this, name, type, value);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetAttributeValue([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, SvgAttributeStringType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char value)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* valuePtr = &value)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, char*, int>)@this->LpVtbl[29])(@this, name, type, valuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetAttributeValue([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, SvgAttributeStringType type, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var valuePtr = (byte*) SilkMarshal.StringToPtr(value, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, byte*, int>)@this->LpVtbl[29])(@this, name, type, valuePtr);
            SilkMarshal.Free((nint)valuePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetAttributeValue([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name, SvgAttributeStringType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* value)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, char*, int>)@this->LpVtbl[29])(@this, namePtr, type, value);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAttributeValue([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name, SvgAttributeStringType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char value)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
                fixed (char* valuePtr = &value)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, char*, int>)@this->LpVtbl[29])(@this, namePtr, type, valuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAttributeValue([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name, SvgAttributeStringType type, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
            var valuePtr = (byte*) SilkMarshal.StringToPtr(value, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, byte*, int>)@this->LpVtbl[29])(@this, namePtr, type, valuePtr);
            SilkMarshal.Free((nint)valuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetAttributeValue([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SvgAttributeStringType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* value)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, SvgAttributeStringType, char*, int>)@this->LpVtbl[29])(@this, namePtr, type, value);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAttributeValue([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SvgAttributeStringType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char value)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            fixed (char* valuePtr = &value)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, SvgAttributeStringType, char*, int>)@this->LpVtbl[29])(@this, namePtr, type, valuePtr);
            }
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAttributeValue([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SvgAttributeStringType type, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            var valuePtr = (byte*) SilkMarshal.StringToPtr(value, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, SvgAttributeStringType, byte*, int>)@this->LpVtbl[29])(@this, namePtr, type, valuePtr);
            SilkMarshal.Free((nint)valuePtr);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAttributeValue([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, SvgAttributeStringType type, char* value, uint valueCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, char*, uint, int>)@this->LpVtbl[32])(@this, name, type, value, valueCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAttributeValue([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, SvgAttributeStringType type, ref char value, uint valueCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* valuePtr = &value)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, char*, uint, int>)@this->LpVtbl[32])(@this, name, type, valuePtr, valueCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAttributeValue([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, SvgAttributeStringType type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value, uint valueCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var valuePtr = (byte*) SilkMarshal.StringToPtr(value, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, byte*, uint, int>)@this->LpVtbl[32])(@this, name, type, valuePtr, valueCount);
            SilkMarshal.Free((nint)valuePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAttributeValue([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name, SvgAttributeStringType type, char* value, uint valueCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, char*, uint, int>)@this->LpVtbl[32])(@this, namePtr, type, value, valueCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAttributeValue([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name, SvgAttributeStringType type, ref char value, uint valueCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
                fixed (char* valuePtr = &value)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, char*, uint, int>)@this->LpVtbl[32])(@this, namePtr, type, valuePtr, valueCount);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAttributeValue([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name, SvgAttributeStringType type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value, uint valueCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
            var valuePtr = (byte*) SilkMarshal.StringToPtr(value, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, byte*, uint, int>)@this->LpVtbl[32])(@this, namePtr, type, valuePtr, valueCount);
            SilkMarshal.Free((nint)valuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAttributeValue([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SvgAttributeStringType type, char* value, uint valueCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, SvgAttributeStringType, char*, uint, int>)@this->LpVtbl[32])(@this, namePtr, type, value, valueCount);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAttributeValue([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SvgAttributeStringType type, ref char value, uint valueCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            fixed (char* valuePtr = &value)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, SvgAttributeStringType, char*, uint, int>)@this->LpVtbl[32])(@this, namePtr, type, valuePtr, valueCount);
            }
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAttributeValue([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SvgAttributeStringType type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value, uint valueCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            var valuePtr = (byte*) SilkMarshal.StringToPtr(value, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, SvgAttributeStringType, byte*, uint, int>)@this->LpVtbl[32])(@this, namePtr, type, valuePtr, valueCount);
            SilkMarshal.Free((nint)valuePtr);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAttributeValueLength([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, SvgAttributeStringType type, uint* valueLength)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, uint*, int>)@this->LpVtbl[33])(@this, name, type, valueLength);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAttributeValueLength([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, SvgAttributeStringType type, ref uint valueLength)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* valueLengthPtr = &valueLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, uint*, int>)@this->LpVtbl[33])(@this, name, type, valueLengthPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAttributeValueLength([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name, SvgAttributeStringType type, uint* valueLength)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, uint*, int>)@this->LpVtbl[33])(@this, namePtr, type, valueLength);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAttributeValueLength([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char name, SvgAttributeStringType type, ref uint valueLength)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
                fixed (uint* valueLengthPtr = &valueLength)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, uint*, int>)@this->LpVtbl[33])(@this, namePtr, type, valueLengthPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAttributeValueLength([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SvgAttributeStringType type, uint* valueLength)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, SvgAttributeStringType, uint*, int>)@this->LpVtbl[33])(@this, namePtr, type, valueLength);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAttributeValueLength([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, SvgAttributeStringType type, ref uint valueLength)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            fixed (uint* valueLengthPtr = &valueLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, byte*, SvgAttributeStringType, uint*, int>)@this->LpVtbl[33])(@this, namePtr, type, valueLengthPtr);
            }
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void GetFactory<TI0>(ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void GetDocument<TI0>(ref ComPtr<TI0> document) where TI0 : unmanaged, IComVtbl<ID2D1SvgDocument>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetDocument((ID2D1SvgDocument**) document.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void GetParent<TI0>(ref ComPtr<TI0> parent) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetParent((ID2D1SvgElement**) parent.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void GetFirstChild<TI0>(ref ComPtr<TI0> child) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetFirstChild((ID2D1SvgElement**) child.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void GetLastChild<TI0>(ref ComPtr<TI0> child) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetLastChild((ID2D1SvgElement**) child.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPreviousChild<TI0, TI1>(ComPtr<TI0> referenceChild, ref ComPtr<TI1> previousChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI1>
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetPreviousChild((ID2D1SvgElement*) referenceChild.Handle, (ID2D1SvgElement**) previousChild.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPreviousChild<TI0>(ComPtr<TI0> referenceChild, ref ID2D1SvgElement* previousChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetPreviousChild((ID2D1SvgElement*) referenceChild.Handle, ref previousChild);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPreviousChild<TI0>(ref ID2D1SvgElement referenceChild, ref ComPtr<TI0> previousChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetPreviousChild(ref referenceChild, (ID2D1SvgElement**) previousChild.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetNextChild<TI0, TI1>(ComPtr<TI0> referenceChild, ref ComPtr<TI1> nextChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI1>
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetNextChild((ID2D1SvgElement*) referenceChild.Handle, (ID2D1SvgElement**) nextChild.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetNextChild<TI0>(ComPtr<TI0> referenceChild, ref ID2D1SvgElement* nextChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetNextChild((ID2D1SvgElement*) referenceChild.Handle, ref nextChild);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetNextChild<TI0>(ref ID2D1SvgElement referenceChild, ref ComPtr<TI0> nextChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetNextChild(ref referenceChild, (ID2D1SvgElement**) nextChild.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int InsertChildBefore<TI0, TI1>(ComPtr<TI0> newChild, ComPtr<TI1> referenceChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI1>
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->InsertChildBefore((ID2D1SvgElement*) newChild.Handle, (ID2D1SvgElement*) referenceChild.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int InsertChildBefore<TI0>(ComPtr<TI0> newChild, ref ID2D1SvgElement referenceChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->InsertChildBefore((ID2D1SvgElement*) newChild.Handle, ref referenceChild);
        }

        /// <summary>To be documented.</summary>
        public readonly int InsertChildBefore<TI0>(ref ID2D1SvgElement newChild, ComPtr<TI0> referenceChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->InsertChildBefore(ref newChild, (ID2D1SvgElement*) referenceChild.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int AppendChild<TI0>(ComPtr<TI0> newChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AppendChild((ID2D1SvgElement*) newChild.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int ReplaceChild<TI0, TI1>(ComPtr<TI0> newChild, ComPtr<TI1> oldChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI1>
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ReplaceChild((ID2D1SvgElement*) newChild.Handle, (ID2D1SvgElement*) oldChild.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int ReplaceChild<TI0>(ComPtr<TI0> newChild, ref ID2D1SvgElement oldChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ReplaceChild((ID2D1SvgElement*) newChild.Handle, ref oldChild);
        }

        /// <summary>To be documented.</summary>
        public readonly int ReplaceChild<TI0>(ref ID2D1SvgElement newChild, ComPtr<TI0> oldChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ReplaceChild(ref newChild, (ID2D1SvgElement*) oldChild.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveChild<TI0>(ComPtr<TI0> oldChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RemoveChild((ID2D1SvgElement*) oldChild.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateChild<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* tagName, ref ComPtr<TI0> newChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateChild(tagName, (ID2D1SvgElement**) newChild.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateChild<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char tagName, ref ComPtr<TI0> newChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateChild(in tagName, (ID2D1SvgElement**) newChild.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateChild<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string tagName, ref ComPtr<TI0> newChild) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateChild(tagName, (ID2D1SvgElement**) newChild.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
