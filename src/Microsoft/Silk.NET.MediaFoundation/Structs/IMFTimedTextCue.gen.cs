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

namespace Silk.NET.MediaFoundation
{
    [Guid("1e560447-9a2b-43e1-a94c-b0aaabfbfbc9")]
    [NativeName("Name", "IMFTimedTextCue")]
    public unsafe partial struct IMFTimedTextCue : IComVtbl<IMFTimedTextCue>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("1e560447-9a2b-43e1-a94c-b0aaabfbfbc9");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFTimedTextCue val)
            => Unsafe.As<IMFTimedTextCue, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFTimedTextCue
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
            var @this = (IMFTimedTextCue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFTimedTextCue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFTimedTextCue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFTimedTextCue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMFTimedTextCue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFTimedTextCue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetId()
        {
            var @this = (IMFTimedTextCue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, uint>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOriginalId(char** originalId)
        {
            var @this = (IMFTimedTextCue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, char**, int>)@this->LpVtbl[4])(@this, originalId);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOriginalId(ref char* originalId)
        {
            var @this = (IMFTimedTextCue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** originalIdPtr = &originalId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, char**, int>)@this->LpVtbl[4])(@this, originalIdPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly TimedTextTrackKind GetCueKind()
        {
            var @this = (IMFTimedTextCue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            TimedTextTrackKind ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, TimedTextTrackKind>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly double GetStartTime()
        {
            var @this = (IMFTimedTextCue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            double ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, double>)@this->LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly double GetDuration()
        {
            var @this = (IMFTimedTextCue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            double ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, double>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetTrackId()
        {
            var @this = (IMFTimedTextCue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, uint>)@this->LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetData(IMFTimedTextBinary** data)
        {
            var @this = (IMFTimedTextCue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, IMFTimedTextBinary**, int>)@this->LpVtbl[9])(@this, data);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetData(ref IMFTimedTextBinary* data)
        {
            var @this = (IMFTimedTextCue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFTimedTextBinary** dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, IMFTimedTextBinary**, int>)@this->LpVtbl[9])(@this, dataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRegion(IMFTimedTextRegion** region)
        {
            var @this = (IMFTimedTextCue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, IMFTimedTextRegion**, int>)@this->LpVtbl[10])(@this, region);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRegion(ref IMFTimedTextRegion* region)
        {
            var @this = (IMFTimedTextCue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFTimedTextRegion** regionPtr = &region)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, IMFTimedTextRegion**, int>)@this->LpVtbl[10])(@this, regionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStyle(IMFTimedTextStyle** style)
        {
            var @this = (IMFTimedTextCue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, IMFTimedTextStyle**, int>)@this->LpVtbl[11])(@this, style);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStyle(ref IMFTimedTextStyle* style)
        {
            var @this = (IMFTimedTextCue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFTimedTextStyle** stylePtr = &style)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, IMFTimedTextStyle**, int>)@this->LpVtbl[11])(@this, stylePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetLineCount()
        {
            var @this = (IMFTimedTextCue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, uint>)@this->LpVtbl[12])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLine(uint index, IMFTimedTextFormattedText** line)
        {
            var @this = (IMFTimedTextCue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, uint, IMFTimedTextFormattedText**, int>)@this->LpVtbl[13])(@this, index, line);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLine(uint index, ref IMFTimedTextFormattedText* line)
        {
            var @this = (IMFTimedTextCue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFTimedTextFormattedText** linePtr = &line)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, uint, IMFTimedTextFormattedText**, int>)@this->LpVtbl[13])(@this, index, linePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextCue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetOriginalId(string[] originalIdSa)
        {
            var @this = (IMFTimedTextCue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var originalId = (char**) SilkMarshal.StringArrayToPtr(originalIdSa);
            var ret = @this->GetOriginalId(originalId);
            SilkMarshal.CopyPtrToStringArray((nint) originalId, originalIdSa);
            SilkMarshal.Free((nint) originalId);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetData<TI0>(ref ComPtr<TI0> data) where TI0 : unmanaged, IComVtbl<IMFTimedTextBinary>, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextCue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetData((IMFTimedTextBinary**) data.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRegion<TI0>(ref ComPtr<TI0> region) where TI0 : unmanaged, IComVtbl<IMFTimedTextRegion>, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextCue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetRegion((IMFTimedTextRegion**) region.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetStyle<TI0>(ref ComPtr<TI0> style) where TI0 : unmanaged, IComVtbl<IMFTimedTextStyle>, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextCue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetStyle((IMFTimedTextStyle**) style.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLine<TI0>(uint index, ref ComPtr<TI0> line) where TI0 : unmanaged, IComVtbl<IMFTimedTextFormattedText>, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextCue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetLine(index, (IMFTimedTextFormattedText**) line.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextCue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
