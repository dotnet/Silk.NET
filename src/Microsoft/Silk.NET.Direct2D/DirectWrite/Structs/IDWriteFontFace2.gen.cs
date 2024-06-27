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
    [Guid("d8b768ff-64bc-4e66-982b-ec8e87f693f7")]
    [NativeName("Name", "IDWriteFontFace2")]
    public unsafe partial struct IDWriteFontFace2 : IComVtbl<IDWriteFontFace2>, IComVtbl<IDWriteFontFace1>, IComVtbl<IDWriteFontFace>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("d8b768ff-64bc-4e66-982b-ec8e87f693f7");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteFontFace1(IDWriteFontFace2 val)
            => Unsafe.As<IDWriteFontFace2, IDWriteFontFace1>(ref val);

        public static implicit operator IDWriteFontFace(IDWriteFontFace2 val)
            => Unsafe.As<IDWriteFontFace2, IDWriteFontFace>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFontFace2 val)
            => Unsafe.As<IDWriteFontFace2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFontFace2
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
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontFaceType GetType()
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontFaceType ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, FontFaceType>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFiles(uint* numberOfFiles, IDWriteFontFile** fontFiles)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, numberOfFiles, fontFiles);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFiles(uint* numberOfFiles, ref IDWriteFontFile* fontFiles)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFile** fontFilesPtr = &fontFiles)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, numberOfFiles, fontFilesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFiles(ref uint numberOfFiles, IDWriteFontFile** fontFiles)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* numberOfFilesPtr = &numberOfFiles)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, numberOfFilesPtr, fontFiles);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFiles(ref uint numberOfFiles, ref IDWriteFontFile* fontFiles)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* numberOfFilesPtr = &numberOfFiles)
            {
                fixed (IDWriteFontFile** fontFilesPtr = &fontFiles)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, numberOfFilesPtr, fontFilesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetIndex()
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontSimulations GetSimulations()
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontSimulations ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, FontSimulations>)@this->LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsSymbolFont()
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, Silk.NET.Core.Bool32>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetMetrics(FontMetrics* fontFaceMetrics)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, FontMetrics*, void>)@this->LpVtbl[8])(@this, fontFaceMetrics);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetMetrics(ref FontMetrics fontFaceMetrics)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (FontMetrics* fontFaceMetricsPtr = &fontFaceMetrics)
            {
                ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, FontMetrics*, void>)@this->LpVtbl[8])(@this, fontFaceMetricsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly ushort GetGlyphCount()
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ushort ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, ushort>)@this->LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesignGlyphMetrics([Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[10])(@this, glyphIndices, glyphCount, glyphMetrics, isSideways);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesignGlyphMetrics([Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, ref GlyphMetrics glyphMetrics, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphMetrics* glyphMetricsPtr = &glyphMetrics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[10])(@this, glyphIndices, glyphCount, glyphMetricsPtr, isSideways);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesignGlyphMetrics([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[10])(@this, glyphIndicesPtr, glyphCount, glyphMetrics, isSideways);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDesignGlyphMetrics([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, ref GlyphMetrics glyphMetrics, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                fixed (GlyphMetrics* glyphMetricsPtr = &glyphMetrics)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[10])(@this, glyphIndicesPtr, glyphCount, glyphMetricsPtr, isSideways);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphIndicesA([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* codePoints, uint codePointCount, ushort* glyphIndices)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint*, uint, ushort*, int>)@this->LpVtbl[11])(@this, codePoints, codePointCount, glyphIndices);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphIndicesA([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* codePoints, uint codePointCount, ref ushort glyphIndices)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint*, uint, ushort*, int>)@this->LpVtbl[11])(@this, codePoints, codePointCount, glyphIndicesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphIndicesA([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint codePoints, uint codePointCount, ushort* glyphIndices)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* codePointsPtr = &codePoints)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint*, uint, ushort*, int>)@this->LpVtbl[11])(@this, codePointsPtr, codePointCount, glyphIndices);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGlyphIndicesA([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint codePoints, uint codePointCount, ref ushort glyphIndices)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* codePointsPtr = &codePoints)
            {
                fixed (ushort* glyphIndicesPtr = &glyphIndices)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint*, uint, ushort*, int>)@this->LpVtbl[11])(@this, codePointsPtr, codePointCount, glyphIndicesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, uint* tableSize, void** tableContext, int* exists)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSize, tableContext, exists);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, uint* tableSize, void** tableContext, ref int exists)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSize, tableContext, existsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, uint* tableSize, ref void* tableContext, int* exists)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** tableContextPtr = &tableContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSize, tableContextPtr, exists);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, uint* tableSize, ref void* tableContext, ref int exists)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** tableContextPtr = &tableContext)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSize, tableContextPtr, existsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, ref uint tableSize, void** tableContext, int* exists)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* tableSizePtr = &tableSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSizePtr, tableContext, exists);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, ref uint tableSize, void** tableContext, ref int exists)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* tableSizePtr = &tableSize)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSizePtr, tableContext, existsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, ref uint tableSize, ref void* tableContext, int* exists)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* tableSizePtr = &tableSize)
            {
                fixed (void** tableContextPtr = &tableContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSizePtr, tableContextPtr, exists);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, ref uint tableSize, ref void* tableContext, ref int exists)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* tableSizePtr = &tableSize)
            {
                fixed (void** tableContextPtr = &tableContext)
                {
                    fixed (int* existsPtr = &exists)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSizePtr, tableContextPtr, existsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, uint* tableSize, void** tableContext, int* exists)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** tableDataPtr = &tableData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSize, tableContext, exists);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, uint* tableSize, void** tableContext, ref int exists)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** tableDataPtr = &tableData)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSize, tableContext, existsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, uint* tableSize, ref void* tableContext, int* exists)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** tableDataPtr = &tableData)
            {
                fixed (void** tableContextPtr = &tableContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSize, tableContextPtr, exists);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, uint* tableSize, ref void* tableContext, ref int exists)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** tableDataPtr = &tableData)
            {
                fixed (void** tableContextPtr = &tableContext)
                {
                    fixed (int* existsPtr = &exists)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSize, tableContextPtr, existsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, ref uint tableSize, void** tableContext, int* exists)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** tableDataPtr = &tableData)
            {
                fixed (uint* tableSizePtr = &tableSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSizePtr, tableContext, exists);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, ref uint tableSize, void** tableContext, ref int exists)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** tableDataPtr = &tableData)
            {
                fixed (uint* tableSizePtr = &tableSize)
                {
                    fixed (int* existsPtr = &exists)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSizePtr, tableContext, existsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, ref uint tableSize, ref void* tableContext, int* exists)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** tableDataPtr = &tableData)
            {
                fixed (uint* tableSizePtr = &tableSize)
                {
                    fixed (void** tableContextPtr = &tableContext)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSizePtr, tableContextPtr, exists);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, ref uint tableSize, ref void* tableContext, ref int exists)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** tableDataPtr = &tableData)
            {
                fixed (uint* tableSizePtr = &tableSize)
                {
                    fixed (void** tableContextPtr = &tableContext)
                    {
                        fixed (int* existsPtr = &exists)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSizePtr, tableContextPtr, existsPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ReleaseFontTable(void* tableContext)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, void*, void>)@this->LpVtbl[13])(@this, tableContext);
        }

        /// <summary>To be documented.</summary>
        public readonly void ReleaseFontTable<T0>(ref T0 tableContext) where T0 : unmanaged
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* tableContextPtr = &tableContext)
            {
                ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, void*, void>)@this->LpVtbl[13])(@this, tableContextPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvances, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
            {
                fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvances, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* glyphAdvancesPtr = &glyphAdvances)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvancesPtr, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* glyphAdvancesPtr = &glyphAdvances)
            {
                fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvancesPtr, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* glyphAdvancesPtr = &glyphAdvances)
            {
                fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvancesPtr, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySink);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* glyphAdvancesPtr = &glyphAdvances)
            {
                fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
                {
                    fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvancesPtr, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvances, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySink);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
                {
                    fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvances, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                fixed (float* glyphAdvancesPtr = &glyphAdvances)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvancesPtr, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                fixed (float* glyphAdvancesPtr = &glyphAdvances)
                {
                    fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvancesPtr, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                fixed (float* glyphAdvancesPtr = &glyphAdvances)
                {
                    fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvancesPtr, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySink);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                fixed (float* glyphAdvancesPtr = &glyphAdvances)
                {
                    fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
                    {
                        fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvancesPtr, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRecommendedRenderingMode(float emSize, float pixelsPerDip, MeasuringMode measuringMode, IDWriteRenderingParams* renderingParams, RenderingMode* renderingMode)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, float, MeasuringMode, IDWriteRenderingParams*, RenderingMode*, int>)@this->LpVtbl[15])(@this, emSize, pixelsPerDip, measuringMode, renderingParams, renderingMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRecommendedRenderingMode(float emSize, float pixelsPerDip, MeasuringMode measuringMode, IDWriteRenderingParams* renderingParams, ref RenderingMode renderingMode)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderingMode* renderingModePtr = &renderingMode)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, float, MeasuringMode, IDWriteRenderingParams*, RenderingMode*, int>)@this->LpVtbl[15])(@this, emSize, pixelsPerDip, measuringMode, renderingParams, renderingModePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRecommendedRenderingMode(float emSize, float pixelsPerDip, MeasuringMode measuringMode, ref IDWriteRenderingParams renderingParams, RenderingMode* renderingMode)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteRenderingParams* renderingParamsPtr = &renderingParams)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, float, MeasuringMode, IDWriteRenderingParams*, RenderingMode*, int>)@this->LpVtbl[15])(@this, emSize, pixelsPerDip, measuringMode, renderingParamsPtr, renderingMode);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRecommendedRenderingMode(float emSize, float pixelsPerDip, MeasuringMode measuringMode, ref IDWriteRenderingParams renderingParams, ref RenderingMode renderingMode)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteRenderingParams* renderingParamsPtr = &renderingParams)
            {
                fixed (RenderingMode* renderingModePtr = &renderingMode)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, float, MeasuringMode, IDWriteRenderingParams*, RenderingMode*, int>)@this->LpVtbl[15])(@this, emSize, pixelsPerDip, measuringMode, renderingParamsPtr, renderingModePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleMetrics(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, FontMetrics* fontFaceMetrics)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, float, Matrix*, FontMetrics*, int>)@this->LpVtbl[16])(@this, emSize, pixelsPerDip, transform, fontFaceMetrics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleMetrics(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, ref FontMetrics fontFaceMetrics)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontMetrics* fontFaceMetricsPtr = &fontFaceMetrics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, float, Matrix*, FontMetrics*, int>)@this->LpVtbl[16])(@this, emSize, pixelsPerDip, transform, fontFaceMetricsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleMetrics(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, FontMetrics* fontFaceMetrics)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, float, Matrix*, FontMetrics*, int>)@this->LpVtbl[16])(@this, emSize, pixelsPerDip, transformPtr, fontFaceMetrics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGdiCompatibleMetrics(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, ref FontMetrics fontFaceMetrics)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                fixed (FontMetrics* fontFaceMetricsPtr = &fontFaceMetrics)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, float, Matrix*, FontMetrics*, int>)@this->LpVtbl[16])(@this, emSize, pixelsPerDip, transformPtr, fontFaceMetricsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphMetrics(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transform, useGdiNatural, glyphIndices, glyphCount, glyphMetrics, isSideways);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphMetrics(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, ref GlyphMetrics glyphMetrics, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphMetrics* glyphMetricsPtr = &glyphMetrics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transform, useGdiNatural, glyphIndices, glyphCount, glyphMetricsPtr, isSideways);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphMetrics(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transform, useGdiNatural, glyphIndicesPtr, glyphCount, glyphMetrics, isSideways);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphMetrics(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, ref GlyphMetrics glyphMetrics, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                fixed (GlyphMetrics* glyphMetricsPtr = &glyphMetrics)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transform, useGdiNatural, glyphIndicesPtr, glyphCount, glyphMetricsPtr, isSideways);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphMetrics(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, glyphIndices, glyphCount, glyphMetrics, isSideways);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphMetrics(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, ref GlyphMetrics glyphMetrics, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                fixed (GlyphMetrics* glyphMetricsPtr = &glyphMetrics)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, glyphIndices, glyphCount, glyphMetricsPtr, isSideways);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphMetrics(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                fixed (ushort* glyphIndicesPtr = &glyphIndices)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, glyphIndicesPtr, glyphCount, glyphMetrics, isSideways);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGdiCompatibleGlyphMetrics(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, ref GlyphMetrics glyphMetrics, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                fixed (ushort* glyphIndicesPtr = &glyphIndices)
                {
                    fixed (GlyphMetrics* glyphMetricsPtr = &glyphMetrics)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, glyphIndicesPtr, glyphCount, glyphMetricsPtr, isSideways);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCaretMetrics(CaretMetrics* caretMetrics)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, CaretMetrics*, void>)@this->LpVtbl[20])(@this, caretMetrics);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetCaretMetrics(ref CaretMetrics caretMetrics)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CaretMetrics* caretMetricsPtr = &caretMetrics)
            {
                ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, CaretMetrics*, void>)@this->LpVtbl[20])(@this, caretMetricsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnicodeRanges(uint maxRangeCount, UnicodeRange* unicodeRanges, uint* actualRangeCount)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, UnicodeRange*, uint*, int>)@this->LpVtbl[21])(@this, maxRangeCount, unicodeRanges, actualRangeCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnicodeRanges(uint maxRangeCount, UnicodeRange* unicodeRanges, ref uint actualRangeCount)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* actualRangeCountPtr = &actualRangeCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, UnicodeRange*, uint*, int>)@this->LpVtbl[21])(@this, maxRangeCount, unicodeRanges, actualRangeCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnicodeRanges(uint maxRangeCount, ref UnicodeRange unicodeRanges, uint* actualRangeCount)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* unicodeRangesPtr = &unicodeRanges)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, UnicodeRange*, uint*, int>)@this->LpVtbl[21])(@this, maxRangeCount, unicodeRangesPtr, actualRangeCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetUnicodeRanges(uint maxRangeCount, ref UnicodeRange unicodeRanges, ref uint actualRangeCount)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* unicodeRangesPtr = &unicodeRanges)
            {
                fixed (uint* actualRangeCountPtr = &actualRangeCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, UnicodeRange*, uint*, int>)@this->LpVtbl[21])(@this, maxRangeCount, unicodeRangesPtr, actualRangeCountPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsMonospacedFont()
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, Silk.NET.Core.Bool32>)@this->LpVtbl[22])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesignGlyphAdvances(uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, int* glyphAdvances, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, ushort*, int*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[23])(@this, glyphCount, glyphIndices, glyphAdvances, isSideways);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesignGlyphAdvances(uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, ref int glyphAdvances, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* glyphAdvancesPtr = &glyphAdvances)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, ushort*, int*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[23])(@this, glyphCount, glyphIndices, glyphAdvancesPtr, isSideways);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesignGlyphAdvances(uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, int* glyphAdvances, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, ushort*, int*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[23])(@this, glyphCount, glyphIndicesPtr, glyphAdvances, isSideways);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDesignGlyphAdvances(uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, ref int glyphAdvances, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                fixed (int* glyphAdvancesPtr = &glyphAdvances)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, ushort*, int*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[23])(@this, glyphCount, glyphIndicesPtr, glyphAdvancesPtr, isSideways);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphAdvances(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, int* glyphAdvances)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvances);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphAdvances(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, ref int glyphAdvances)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* glyphAdvancesPtr = &glyphAdvances)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvancesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphAdvances(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, int* glyphAdvances)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndicesPtr, glyphAdvances);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphAdvances(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, ref int glyphAdvances)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                fixed (int* glyphAdvancesPtr = &glyphAdvances)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndicesPtr, glyphAdvancesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphAdvances(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, int* glyphAdvances)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvances);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphAdvances(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, ref int glyphAdvances)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                fixed (int* glyphAdvancesPtr = &glyphAdvances)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvancesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphAdvances(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, int* glyphAdvances)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                fixed (ushort* glyphIndicesPtr = &glyphIndices)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, isSideways, glyphCount, glyphIndicesPtr, glyphAdvances);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGdiCompatibleGlyphAdvances(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, ref int glyphAdvances)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                fixed (ushort* glyphIndicesPtr = &glyphIndices)
                {
                    fixed (int* glyphAdvancesPtr = &glyphAdvances)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, isSideways, glyphCount, glyphIndicesPtr, glyphAdvancesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetKerningPairAdjustments(uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, int* glyphAdvanceAdjustments)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, ushort*, int*, int>)@this->LpVtbl[25])(@this, glyphCount, glyphIndices, glyphAdvanceAdjustments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetKerningPairAdjustments(uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, ref int glyphAdvanceAdjustments)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* glyphAdvanceAdjustmentsPtr = &glyphAdvanceAdjustments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, ushort*, int*, int>)@this->LpVtbl[25])(@this, glyphCount, glyphIndices, glyphAdvanceAdjustmentsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetKerningPairAdjustments(uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, int* glyphAdvanceAdjustments)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, ushort*, int*, int>)@this->LpVtbl[25])(@this, glyphCount, glyphIndicesPtr, glyphAdvanceAdjustments);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetKerningPairAdjustments(uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, ref int glyphAdvanceAdjustments)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                fixed (int* glyphAdvanceAdjustmentsPtr = &glyphAdvanceAdjustments)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, ushort*, int*, int>)@this->LpVtbl[25])(@this, glyphCount, glyphIndicesPtr, glyphAdvanceAdjustmentsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 HasKerningPairs()
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, Silk.NET.Core.Bool32>)@this->LpVtbl[26])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVerticalGlyphVariants(uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* nominalGlyphIndices, ushort* verticalGlyphIndices)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, ushort*, ushort*, int>)@this->LpVtbl[28])(@this, glyphCount, nominalGlyphIndices, verticalGlyphIndices);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVerticalGlyphVariants(uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* nominalGlyphIndices, ref ushort verticalGlyphIndices)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* verticalGlyphIndicesPtr = &verticalGlyphIndices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, ushort*, ushort*, int>)@this->LpVtbl[28])(@this, glyphCount, nominalGlyphIndices, verticalGlyphIndicesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVerticalGlyphVariants(uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort nominalGlyphIndices, ushort* verticalGlyphIndices)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* nominalGlyphIndicesPtr = &nominalGlyphIndices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, ushort*, ushort*, int>)@this->LpVtbl[28])(@this, glyphCount, nominalGlyphIndicesPtr, verticalGlyphIndices);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVerticalGlyphVariants(uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort nominalGlyphIndices, ref ushort verticalGlyphIndices)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* nominalGlyphIndicesPtr = &nominalGlyphIndices)
            {
                fixed (ushort* verticalGlyphIndicesPtr = &verticalGlyphIndices)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, ushort*, ushort*, int>)@this->LpVtbl[28])(@this, glyphCount, nominalGlyphIndicesPtr, verticalGlyphIndicesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 HasVerticalGlyphVariants()
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, Silk.NET.Core.Bool32>)@this->LpVtbl[29])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsColorFont()
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, Silk.NET.Core.Bool32>)@this->LpVtbl[30])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetColorPaletteCount()
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint>)@this->LpVtbl[31])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetPaletteEntryCount()
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint>)@this->LpVtbl[32])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPaletteEntries(uint colorPaletteIndex, uint firstEntryIndex, uint entryCount, Silk.NET.DXGI.D3Dcolorvalue* paletteEntries)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, uint, uint, Silk.NET.DXGI.D3Dcolorvalue*, int>)@this->LpVtbl[33])(@this, colorPaletteIndex, firstEntryIndex, entryCount, paletteEntries);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPaletteEntries(uint colorPaletteIndex, uint firstEntryIndex, uint entryCount, ref Silk.NET.DXGI.D3Dcolorvalue paletteEntries)
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.D3Dcolorvalue* paletteEntriesPtr = &paletteEntries)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace2*, uint, uint, uint, Silk.NET.DXGI.D3Dcolorvalue*, int>)@this->LpVtbl[33])(@this, colorPaletteIndex, firstEntryIndex, entryCount, paletteEntriesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFiles<TI0>(uint* numberOfFiles, ref ComPtr<TI0> fontFiles) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFiles(numberOfFiles, (IDWriteFontFile**) fontFiles.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFiles<TI0>(ref uint numberOfFiles, ref ComPtr<TI0> fontFiles) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFiles(ref numberOfFiles, (IDWriteFontFile**) fontFiles.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRecommendedRenderingMode<TI0>(float emSize, float pixelsPerDip, MeasuringMode measuringMode, ComPtr<TI0> renderingParams, RenderingMode* renderingMode) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetRecommendedRenderingMode(emSize, pixelsPerDip, measuringMode, (IDWriteRenderingParams*) renderingParams.Handle, renderingMode);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRecommendedRenderingMode<TI0>(float emSize, float pixelsPerDip, MeasuringMode measuringMode, ComPtr<TI0> renderingParams, ref RenderingMode renderingMode) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetRecommendedRenderingMode(emSize, pixelsPerDip, measuringMode, (IDWriteRenderingParams*) renderingParams.Handle, ref renderingMode);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFace2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
