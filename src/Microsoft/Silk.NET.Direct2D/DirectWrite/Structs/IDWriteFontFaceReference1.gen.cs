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

namespace Silk.NET.DirectWrite
{
    [Guid("c081fe77-2fd1-41ac-a5a3-34983c4ba61a")]
    [NativeName("Name", "IDWriteFontFaceReference1")]
    public unsafe partial struct IDWriteFontFaceReference1 : IComVtbl<IDWriteFontFaceReference1>, IComVtbl<IDWriteFontFaceReference>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("c081fe77-2fd1-41ac-a5a3-34983c4ba61a");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteFontFaceReference(IDWriteFontFaceReference1 val)
            => Unsafe.As<IDWriteFontFaceReference1, IDWriteFontFaceReference>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFontFaceReference1 val)
            => Unsafe.As<IDWriteFontFaceReference1, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFontFaceReference1
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
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFace(IDWriteFontFace3** fontFace)
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, IDWriteFontFace3**, int>)@this->LpVtbl[3])(@this, fontFace);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFace(ref IDWriteFontFace3* fontFace)
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace3** fontFacePtr = &fontFace)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, IDWriteFontFace3**, int>)@this->LpVtbl[3])(@this, fontFacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFaceWithSimulations(FontSimulations fontFaceSimulationFlags, IDWriteFontFace3** fontFace)
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, FontSimulations, IDWriteFontFace3**, int>)@this->LpVtbl[4])(@this, fontFaceSimulationFlags, fontFace);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFaceWithSimulations(FontSimulations fontFaceSimulationFlags, ref IDWriteFontFace3* fontFace)
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace3** fontFacePtr = &fontFace)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, FontSimulations, IDWriteFontFace3**, int>)@this->LpVtbl[4])(@this, fontFaceSimulationFlags, fontFacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe Silk.NET.Core.Bool32 Equals(IDWriteFontFaceReference* fontFaceReference)
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, IDWriteFontFaceReference*, Silk.NET.Core.Bool32>)@this->LpVtbl[5])(@this, fontFaceReference);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 Equals(ref IDWriteFontFaceReference fontFaceReference)
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            fixed (IDWriteFontFaceReference* fontFaceReferencePtr = &fontFaceReference)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, IDWriteFontFaceReference*, Silk.NET.Core.Bool32>)@this->LpVtbl[5])(@this, fontFaceReferencePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetFontFaceIndex()
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, uint>)@this->LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontSimulations GetSimulations()
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontSimulations ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, FontSimulations>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFile(IDWriteFontFile** fontFile)
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFile);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFile(ref IDWriteFontFile* fontFile)
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFile** fontFilePtr = &fontFile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetLocalFileSize()
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, ulong>)@this->LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetFileSize()
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, ulong>)@this->LpVtbl[10])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFileTime(Silk.NET.Core.Win32Extras.Filetime* lastWriteTime)
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, Silk.NET.Core.Win32Extras.Filetime*, int>)@this->LpVtbl[11])(@this, lastWriteTime);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFileTime(ref Silk.NET.Core.Win32Extras.Filetime lastWriteTime)
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.Filetime* lastWriteTimePtr = &lastWriteTime)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, Silk.NET.Core.Win32Extras.Filetime*, int>)@this->LpVtbl[11])(@this, lastWriteTimePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Locality GetLocality()
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Locality ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, Locality>)@this->LpVtbl[12])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnqueueFontDownloadRequest()
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, int>)@this->LpVtbl[13])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnqueueCharacterDownloadRequest([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* characters, uint characterCount)
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, char*, uint, int>)@this->LpVtbl[14])(@this, characters, characterCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnqueueCharacterDownloadRequest([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char characters, uint characterCount)
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* charactersPtr = &characters)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, char*, uint, int>)@this->LpVtbl[14])(@this, charactersPtr, characterCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnqueueCharacterDownloadRequest([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string characters, uint characterCount)
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var charactersPtr = (byte*) SilkMarshal.StringToPtr(characters, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, byte*, uint, int>)@this->LpVtbl[14])(@this, charactersPtr, characterCount);
            SilkMarshal.Free((nint)charactersPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnqueueGlyphDownloadRequest([Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount)
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, ushort*, uint, int>)@this->LpVtbl[15])(@this, glyphIndices, glyphCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnqueueGlyphDownloadRequest([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ushort glyphIndices, uint glyphCount)
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, ushort*, uint, int>)@this->LpVtbl[15])(@this, glyphIndicesPtr, glyphCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnqueueFileFragmentDownloadRequest(ulong fileOffset, ulong fragmentSize)
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, ulong, ulong, int>)@this->LpVtbl[16])(@this, fileOffset, fragmentSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetFontAxisValueCount()
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, uint>)@this->LpVtbl[18])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontAxisValues(FontAxisValue* fontAxisValues, uint fontAxisValueCount)
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, FontAxisValue*, uint, int>)@this->LpVtbl[19])(@this, fontAxisValues, fontAxisValueCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFontAxisValues(ref FontAxisValue fontAxisValues, uint fontAxisValueCount)
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontAxisValue* fontAxisValuesPtr = &fontAxisValues)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, FontAxisValue*, uint, int>)@this->LpVtbl[19])(@this, fontAxisValuesPtr, fontAxisValueCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFontFace<TI0>(ref ComPtr<TI0> fontFace) where TI0 : unmanaged, IComVtbl<IDWriteFontFace3>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFace((IDWriteFontFace3**) fontFace.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFontFaceWithSimulations<TI0>(FontSimulations fontFaceSimulationFlags, ref ComPtr<TI0> fontFace) where TI0 : unmanaged, IComVtbl<IDWriteFontFace3>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFaceWithSimulations(fontFaceSimulationFlags, (IDWriteFontFace3**) fontFace.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 Equals<TI0>(ComPtr<TI0> fontFaceReference) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Equals((IDWriteFontFaceReference*) fontFaceReference.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFontFile<TI0>(ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFontFile((IDWriteFontFile**) fontFile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
