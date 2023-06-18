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
        public readonly unsafe void GetDocument(ID2D1SvgDocument** document)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgDocument**, void>)@this->LpVtbl[4])(@this, document);
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
        public readonly unsafe void GetLastChild(ID2D1SvgElement** child)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement**, void>)@this->LpVtbl[11])(@this, child);
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
        public readonly unsafe int GetNextChild(ID2D1SvgElement* referenceChild, ID2D1SvgElement** nextChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)@this->LpVtbl[13])(@this, referenceChild, nextChild);
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
        public readonly unsafe int AppendChild(ID2D1SvgElement* newChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, int>)@this->LpVtbl[15])(@this, newChild);
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
        public readonly unsafe int RemoveChild(ID2D1SvgElement* oldChild)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, int>)@this->LpVtbl[17])(@this, oldChild);
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
        public readonly unsafe Silk.NET.Core.Bool32 IsAttributeSpecified([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, int* inherited)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, int*, Silk.NET.Core.Bool32>)@this->LpVtbl[19])(@this, name, inherited);
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
        public readonly unsafe int GetSpecifiedAttributeNameLength(uint index, uint* nameLength, int* inherited)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, uint*, int*, int>)@this->LpVtbl[22])(@this, index, nameLength, inherited);
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
        public readonly unsafe int SetTextValue([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, uint nameCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, uint, int>)@this->LpVtbl[24])(@this, name, nameCount);
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
        public readonly unsafe int GetAttributeValue([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, SvgAttributeStringType type, char* value, uint valueCount)
        {
            var @this = (ID2D1SvgElement*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, char*, SvgAttributeStringType, char*, uint, int>)@this->LpVtbl[32])(@this, name, type, value, valueCount);
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

    }
}
