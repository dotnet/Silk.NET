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
    [Guid("27f2a904-4eb8-441d-9678-0563f53e3e2f")]
    [NativeName("Name", "IDWriteFontFace4")]
    public unsafe partial struct IDWriteFontFace4 : IComVtbl<IDWriteFontFace4>, IComVtbl<IDWriteFontFace3>, IComVtbl<IDWriteFontFace2>, IComVtbl<IDWriteFontFace1>, IComVtbl<IDWriteFontFace>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("27f2a904-4eb8-441d-9678-0563f53e3e2f");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteFontFace3(IDWriteFontFace4 val)
            => Unsafe.As<IDWriteFontFace4, IDWriteFontFace3>(ref val);

        public static implicit operator IDWriteFontFace2(IDWriteFontFace4 val)
            => Unsafe.As<IDWriteFontFace4, IDWriteFontFace2>(ref val);

        public static implicit operator IDWriteFontFace1(IDWriteFontFace4 val)
            => Unsafe.As<IDWriteFontFace4, IDWriteFontFace1>(ref val);

        public static implicit operator IDWriteFontFace(IDWriteFontFace4 val)
            => Unsafe.As<IDWriteFontFace4, IDWriteFontFace>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFontFace4 val)
            => Unsafe.As<IDWriteFontFace4, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFontFace4
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
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontFaceType GetType()
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontFaceType ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, FontFaceType>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFiles(uint* numberOfFiles, IDWriteFontFile** fontFiles)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, numberOfFiles, fontFiles);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFiles(uint* numberOfFiles, ref IDWriteFontFile* fontFiles)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFile** fontFilesPtr = &fontFiles)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, numberOfFiles, fontFilesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFiles(ref uint numberOfFiles, IDWriteFontFile** fontFiles)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* numberOfFilesPtr = &numberOfFiles)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, numberOfFilesPtr, fontFiles);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFiles(ref uint numberOfFiles, ref IDWriteFontFile* fontFiles)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* numberOfFilesPtr = &numberOfFiles)
            {
                fixed (IDWriteFontFile** fontFilesPtr = &fontFiles)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, numberOfFilesPtr, fontFilesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetIndex()
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontSimulations GetSimulations()
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontSimulations ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, FontSimulations>)@this->LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsSymbolFont()
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, Silk.NET.Core.Bool32>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetMetrics(FontMetrics* fontFaceMetrics)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, FontMetrics*, void>)@this->LpVtbl[8])(@this, fontFaceMetrics);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetMetrics(ref FontMetrics fontFaceMetrics)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (FontMetrics* fontFaceMetricsPtr = &fontFaceMetrics)
            {
                ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, FontMetrics*, void>)@this->LpVtbl[8])(@this, fontFaceMetricsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly ushort GetGlyphCount()
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ushort ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort>)@this->LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesignGlyphMetrics([Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[10])(@this, glyphIndices, glyphCount, glyphMetrics, isSideways);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesignGlyphMetrics([Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, ref GlyphMetrics glyphMetrics, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphMetrics* glyphMetricsPtr = &glyphMetrics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[10])(@this, glyphIndices, glyphCount, glyphMetricsPtr, isSideways);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesignGlyphMetrics([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[10])(@this, glyphIndicesPtr, glyphCount, glyphMetrics, isSideways);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDesignGlyphMetrics([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, ref GlyphMetrics glyphMetrics, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                fixed (GlyphMetrics* glyphMetricsPtr = &glyphMetrics)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[10])(@this, glyphIndicesPtr, glyphCount, glyphMetricsPtr, isSideways);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphIndicesA([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* codePoints, uint codePointCount, ushort* glyphIndices)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint*, uint, ushort*, int>)@this->LpVtbl[11])(@this, codePoints, codePointCount, glyphIndices);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphIndicesA([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* codePoints, uint codePointCount, ref ushort glyphIndices)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint*, uint, ushort*, int>)@this->LpVtbl[11])(@this, codePoints, codePointCount, glyphIndicesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphIndicesA([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint codePoints, uint codePointCount, ushort* glyphIndices)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* codePointsPtr = &codePoints)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint*, uint, ushort*, int>)@this->LpVtbl[11])(@this, codePointsPtr, codePointCount, glyphIndices);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGlyphIndicesA([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint codePoints, uint codePointCount, ref ushort glyphIndices)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* codePointsPtr = &codePoints)
            {
                fixed (ushort* glyphIndicesPtr = &glyphIndices)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint*, uint, ushort*, int>)@this->LpVtbl[11])(@this, codePointsPtr, codePointCount, glyphIndicesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, uint* tableSize, void** tableContext, int* exists)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSize, tableContext, exists);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, uint* tableSize, void** tableContext, ref int exists)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSize, tableContext, existsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, uint* tableSize, ref void* tableContext, int* exists)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** tableContextPtr = &tableContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSize, tableContextPtr, exists);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, uint* tableSize, ref void* tableContext, ref int exists)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** tableContextPtr = &tableContext)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSize, tableContextPtr, existsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, ref uint tableSize, void** tableContext, int* exists)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* tableSizePtr = &tableSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSizePtr, tableContext, exists);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, ref uint tableSize, void** tableContext, ref int exists)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* tableSizePtr = &tableSize)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSizePtr, tableContext, existsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, ref uint tableSize, ref void* tableContext, int* exists)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* tableSizePtr = &tableSize)
            {
                fixed (void** tableContextPtr = &tableContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSizePtr, tableContextPtr, exists);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, ref uint tableSize, ref void* tableContext, ref int exists)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* tableSizePtr = &tableSize)
            {
                fixed (void** tableContextPtr = &tableContext)
                {
                    fixed (int* existsPtr = &exists)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSizePtr, tableContextPtr, existsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, uint* tableSize, void** tableContext, int* exists)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** tableDataPtr = &tableData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSize, tableContext, exists);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, uint* tableSize, void** tableContext, ref int exists)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** tableDataPtr = &tableData)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSize, tableContext, existsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, uint* tableSize, ref void* tableContext, int* exists)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** tableDataPtr = &tableData)
            {
                fixed (void** tableContextPtr = &tableContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSize, tableContextPtr, exists);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, uint* tableSize, ref void* tableContext, ref int exists)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** tableDataPtr = &tableData)
            {
                fixed (void** tableContextPtr = &tableContext)
                {
                    fixed (int* existsPtr = &exists)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSize, tableContextPtr, existsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, ref uint tableSize, void** tableContext, int* exists)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** tableDataPtr = &tableData)
            {
                fixed (uint* tableSizePtr = &tableSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSizePtr, tableContext, exists);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, ref uint tableSize, void** tableContext, ref int exists)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** tableDataPtr = &tableData)
            {
                fixed (uint* tableSizePtr = &tableSize)
                {
                    fixed (int* existsPtr = &exists)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSizePtr, tableContext, existsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, ref uint tableSize, ref void* tableContext, int* exists)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** tableDataPtr = &tableData)
            {
                fixed (uint* tableSizePtr = &tableSize)
                {
                    fixed (void** tableContextPtr = &tableContext)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSizePtr, tableContextPtr, exists);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, ref uint tableSize, ref void* tableContext, ref int exists)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** tableDataPtr = &tableData)
            {
                fixed (uint* tableSizePtr = &tableSize)
                {
                    fixed (void** tableContextPtr = &tableContext)
                    {
                        fixed (int* existsPtr = &exists)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSizePtr, tableContextPtr, existsPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ReleaseFontTable(void* tableContext)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, void*, void>)@this->LpVtbl[13])(@this, tableContext);
        }

        /// <summary>To be documented.</summary>
        public readonly void ReleaseFontTable<T0>(ref T0 tableContext) where T0 : unmanaged
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* tableContextPtr = &tableContext)
            {
                ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, void*, void>)@this->LpVtbl[13])(@this, tableContextPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvances, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
            {
                fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvances, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* glyphAdvancesPtr = &glyphAdvances)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvancesPtr, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* glyphAdvancesPtr = &glyphAdvances)
            {
                fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvancesPtr, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* glyphAdvancesPtr = &glyphAdvances)
            {
                fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvancesPtr, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySink);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* glyphAdvancesPtr = &glyphAdvances)
            {
                fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
                {
                    fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvancesPtr, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvances, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySink);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
                {
                    fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvances, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                fixed (float* glyphAdvancesPtr = &glyphAdvances)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvancesPtr, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                fixed (float* glyphAdvancesPtr = &glyphAdvances)
                {
                    fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvancesPtr, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                fixed (float* glyphAdvancesPtr = &glyphAdvances)
                {
                    fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvancesPtr, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySink);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                fixed (float* glyphAdvancesPtr = &glyphAdvances)
                {
                    fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
                    {
                        fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvancesPtr, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRecommendedRenderingMode(float emSize, float pixelsPerDip, MeasuringMode measuringMode, IDWriteRenderingParams* renderingParams, RenderingMode* renderingMode)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, MeasuringMode, IDWriteRenderingParams*, RenderingMode*, int>)@this->LpVtbl[15])(@this, emSize, pixelsPerDip, measuringMode, renderingParams, renderingMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRecommendedRenderingMode(float emSize, float pixelsPerDip, MeasuringMode measuringMode, IDWriteRenderingParams* renderingParams, ref RenderingMode renderingMode)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderingMode* renderingModePtr = &renderingMode)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, MeasuringMode, IDWriteRenderingParams*, RenderingMode*, int>)@this->LpVtbl[15])(@this, emSize, pixelsPerDip, measuringMode, renderingParams, renderingModePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRecommendedRenderingMode(float emSize, float pixelsPerDip, MeasuringMode measuringMode, ref IDWriteRenderingParams renderingParams, RenderingMode* renderingMode)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteRenderingParams* renderingParamsPtr = &renderingParams)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, MeasuringMode, IDWriteRenderingParams*, RenderingMode*, int>)@this->LpVtbl[15])(@this, emSize, pixelsPerDip, measuringMode, renderingParamsPtr, renderingMode);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRecommendedRenderingMode(float emSize, float pixelsPerDip, MeasuringMode measuringMode, ref IDWriteRenderingParams renderingParams, ref RenderingMode renderingMode)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteRenderingParams* renderingParamsPtr = &renderingParams)
            {
                fixed (RenderingMode* renderingModePtr = &renderingMode)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, MeasuringMode, IDWriteRenderingParams*, RenderingMode*, int>)@this->LpVtbl[15])(@this, emSize, pixelsPerDip, measuringMode, renderingParamsPtr, renderingModePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleMetrics(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, FontMetrics* fontFaceMetrics)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, FontMetrics*, int>)@this->LpVtbl[16])(@this, emSize, pixelsPerDip, transform, fontFaceMetrics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleMetrics(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, ref FontMetrics fontFaceMetrics)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontMetrics* fontFaceMetricsPtr = &fontFaceMetrics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, FontMetrics*, int>)@this->LpVtbl[16])(@this, emSize, pixelsPerDip, transform, fontFaceMetricsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleMetrics(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, FontMetrics* fontFaceMetrics)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, FontMetrics*, int>)@this->LpVtbl[16])(@this, emSize, pixelsPerDip, transformPtr, fontFaceMetrics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGdiCompatibleMetrics(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, ref FontMetrics fontFaceMetrics)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                fixed (FontMetrics* fontFaceMetricsPtr = &fontFaceMetrics)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, FontMetrics*, int>)@this->LpVtbl[16])(@this, emSize, pixelsPerDip, transformPtr, fontFaceMetricsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphMetrics(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transform, useGdiNatural, glyphIndices, glyphCount, glyphMetrics, isSideways);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphMetrics(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, ref GlyphMetrics glyphMetrics, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphMetrics* glyphMetricsPtr = &glyphMetrics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transform, useGdiNatural, glyphIndices, glyphCount, glyphMetricsPtr, isSideways);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphMetrics(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transform, useGdiNatural, glyphIndicesPtr, glyphCount, glyphMetrics, isSideways);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphMetrics(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, ref GlyphMetrics glyphMetrics, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                fixed (GlyphMetrics* glyphMetricsPtr = &glyphMetrics)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transform, useGdiNatural, glyphIndicesPtr, glyphCount, glyphMetricsPtr, isSideways);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphMetrics(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, glyphIndices, glyphCount, glyphMetrics, isSideways);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphMetrics(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, ref GlyphMetrics glyphMetrics, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                fixed (GlyphMetrics* glyphMetricsPtr = &glyphMetrics)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, glyphIndices, glyphCount, glyphMetricsPtr, isSideways);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphMetrics(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                fixed (ushort* glyphIndicesPtr = &glyphIndices)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, glyphIndicesPtr, glyphCount, glyphMetrics, isSideways);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGdiCompatibleGlyphMetrics(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, ref GlyphMetrics glyphMetrics, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                fixed (ushort* glyphIndicesPtr = &glyphIndices)
                {
                    fixed (GlyphMetrics* glyphMetricsPtr = &glyphMetrics)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, glyphIndicesPtr, glyphCount, glyphMetricsPtr, isSideways);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCaretMetrics(CaretMetrics* caretMetrics)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, CaretMetrics*, void>)@this->LpVtbl[20])(@this, caretMetrics);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetCaretMetrics(ref CaretMetrics caretMetrics)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CaretMetrics* caretMetricsPtr = &caretMetrics)
            {
                ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, CaretMetrics*, void>)@this->LpVtbl[20])(@this, caretMetricsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnicodeRanges(uint maxRangeCount, UnicodeRange* unicodeRanges, uint* actualRangeCount)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, UnicodeRange*, uint*, int>)@this->LpVtbl[21])(@this, maxRangeCount, unicodeRanges, actualRangeCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnicodeRanges(uint maxRangeCount, UnicodeRange* unicodeRanges, ref uint actualRangeCount)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* actualRangeCountPtr = &actualRangeCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, UnicodeRange*, uint*, int>)@this->LpVtbl[21])(@this, maxRangeCount, unicodeRanges, actualRangeCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnicodeRanges(uint maxRangeCount, ref UnicodeRange unicodeRanges, uint* actualRangeCount)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* unicodeRangesPtr = &unicodeRanges)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, UnicodeRange*, uint*, int>)@this->LpVtbl[21])(@this, maxRangeCount, unicodeRangesPtr, actualRangeCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetUnicodeRanges(uint maxRangeCount, ref UnicodeRange unicodeRanges, ref uint actualRangeCount)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* unicodeRangesPtr = &unicodeRanges)
            {
                fixed (uint* actualRangeCountPtr = &actualRangeCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, UnicodeRange*, uint*, int>)@this->LpVtbl[21])(@this, maxRangeCount, unicodeRangesPtr, actualRangeCountPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsMonospacedFont()
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, Silk.NET.Core.Bool32>)@this->LpVtbl[22])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesignGlyphAdvances(uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, int* glyphAdvances, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, ushort*, int*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[23])(@this, glyphCount, glyphIndices, glyphAdvances, isSideways);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesignGlyphAdvances(uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, ref int glyphAdvances, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* glyphAdvancesPtr = &glyphAdvances)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, ushort*, int*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[23])(@this, glyphCount, glyphIndices, glyphAdvancesPtr, isSideways);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesignGlyphAdvances(uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, int* glyphAdvances, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, ushort*, int*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[23])(@this, glyphCount, glyphIndicesPtr, glyphAdvances, isSideways);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDesignGlyphAdvances(uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, ref int glyphAdvances, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                fixed (int* glyphAdvancesPtr = &glyphAdvances)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, ushort*, int*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[23])(@this, glyphCount, glyphIndicesPtr, glyphAdvancesPtr, isSideways);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphAdvances(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, int* glyphAdvances)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvances);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphAdvances(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, ref int glyphAdvances)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* glyphAdvancesPtr = &glyphAdvances)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvancesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphAdvances(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, int* glyphAdvances)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndicesPtr, glyphAdvances);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphAdvances(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, ref int glyphAdvances)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                fixed (int* glyphAdvancesPtr = &glyphAdvances)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndicesPtr, glyphAdvancesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphAdvances(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, int* glyphAdvances)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvances);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphAdvances(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, ref int glyphAdvances)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                fixed (int* glyphAdvancesPtr = &glyphAdvances)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvancesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphAdvances(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, int* glyphAdvances)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                fixed (ushort* glyphIndicesPtr = &glyphIndices)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, isSideways, glyphCount, glyphIndicesPtr, glyphAdvances);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGdiCompatibleGlyphAdvances(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, ref int glyphAdvances)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                fixed (ushort* glyphIndicesPtr = &glyphIndices)
                {
                    fixed (int* glyphAdvancesPtr = &glyphAdvances)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, isSideways, glyphCount, glyphIndicesPtr, glyphAdvancesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetKerningPairAdjustments(uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, int* glyphAdvanceAdjustments)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, ushort*, int*, int>)@this->LpVtbl[25])(@this, glyphCount, glyphIndices, glyphAdvanceAdjustments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetKerningPairAdjustments(uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, ref int glyphAdvanceAdjustments)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* glyphAdvanceAdjustmentsPtr = &glyphAdvanceAdjustments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, ushort*, int*, int>)@this->LpVtbl[25])(@this, glyphCount, glyphIndices, glyphAdvanceAdjustmentsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetKerningPairAdjustments(uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, int* glyphAdvanceAdjustments)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, ushort*, int*, int>)@this->LpVtbl[25])(@this, glyphCount, glyphIndicesPtr, glyphAdvanceAdjustments);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetKerningPairAdjustments(uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, ref int glyphAdvanceAdjustments)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                fixed (int* glyphAdvanceAdjustmentsPtr = &glyphAdvanceAdjustments)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, ushort*, int*, int>)@this->LpVtbl[25])(@this, glyphCount, glyphIndicesPtr, glyphAdvanceAdjustmentsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 HasKerningPairs()
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, Silk.NET.Core.Bool32>)@this->LpVtbl[26])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVerticalGlyphVariants(uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* nominalGlyphIndices, ushort* verticalGlyphIndices)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, ushort*, ushort*, int>)@this->LpVtbl[28])(@this, glyphCount, nominalGlyphIndices, verticalGlyphIndices);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVerticalGlyphVariants(uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* nominalGlyphIndices, ref ushort verticalGlyphIndices)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* verticalGlyphIndicesPtr = &verticalGlyphIndices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, ushort*, ushort*, int>)@this->LpVtbl[28])(@this, glyphCount, nominalGlyphIndices, verticalGlyphIndicesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVerticalGlyphVariants(uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort nominalGlyphIndices, ushort* verticalGlyphIndices)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* nominalGlyphIndicesPtr = &nominalGlyphIndices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, ushort*, ushort*, int>)@this->LpVtbl[28])(@this, glyphCount, nominalGlyphIndicesPtr, verticalGlyphIndices);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVerticalGlyphVariants(uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort nominalGlyphIndices, ref ushort verticalGlyphIndices)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* nominalGlyphIndicesPtr = &nominalGlyphIndices)
            {
                fixed (ushort* verticalGlyphIndicesPtr = &verticalGlyphIndices)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, ushort*, ushort*, int>)@this->LpVtbl[28])(@this, glyphCount, nominalGlyphIndicesPtr, verticalGlyphIndicesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 HasVerticalGlyphVariants()
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, Silk.NET.Core.Bool32>)@this->LpVtbl[29])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsColorFont()
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, Silk.NET.Core.Bool32>)@this->LpVtbl[30])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetColorPaletteCount()
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint>)@this->LpVtbl[31])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetPaletteEntryCount()
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint>)@this->LpVtbl[32])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPaletteEntries(uint colorPaletteIndex, uint firstEntryIndex, uint entryCount, Silk.NET.DXGI.D3Dcolorvalue* paletteEntries)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, uint, uint, Silk.NET.DXGI.D3Dcolorvalue*, int>)@this->LpVtbl[33])(@this, colorPaletteIndex, firstEntryIndex, entryCount, paletteEntries);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPaletteEntries(uint colorPaletteIndex, uint firstEntryIndex, uint entryCount, ref Silk.NET.DXGI.D3Dcolorvalue paletteEntries)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.D3Dcolorvalue* paletteEntriesPtr = &paletteEntries)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, uint, uint, Silk.NET.DXGI.D3Dcolorvalue*, int>)@this->LpVtbl[33])(@this, colorPaletteIndex, firstEntryIndex, entryCount, paletteEntriesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFaceReference(IDWriteFontFaceReference** fontFaceReference)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, IDWriteFontFaceReference**, int>)@this->LpVtbl[35])(@this, fontFaceReference);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFaceReference(ref IDWriteFontFaceReference* fontFaceReference)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFaceReference** fontFaceReferencePtr = &fontFaceReference)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, IDWriteFontFaceReference**, int>)@this->LpVtbl[35])(@this, fontFaceReferencePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetPanose(Panose* panose)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, Panose*, void>)@this->LpVtbl[36])(@this, panose);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetPanose(ref Panose panose)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Panose* panosePtr = &panose)
            {
                ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, Panose*, void>)@this->LpVtbl[36])(@this, panosePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly FontWeight GetWeight()
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontWeight ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, FontWeight>)@this->LpVtbl[37])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontStretch GetStretch()
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontStretch ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, FontStretch>)@this->LpVtbl[38])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontStyle GetStyle()
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontStyle ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, FontStyle>)@this->LpVtbl[39])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFamilyNames(IDWriteLocalizedStrings** names)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[40])(@this, names);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFamilyNames(ref IDWriteLocalizedStrings* names)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteLocalizedStrings** namesPtr = &names)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[40])(@this, namesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFaceNames(IDWriteLocalizedStrings** names)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[41])(@this, names);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFaceNames(ref IDWriteLocalizedStrings* names)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteLocalizedStrings** namesPtr = &names)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[41])(@this, namesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInformationalStrings(InformationalStringID informationalStringID, IDWriteLocalizedStrings** informationalStrings, int* exists)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, InformationalStringID, IDWriteLocalizedStrings**, int*, int>)@this->LpVtbl[42])(@this, informationalStringID, informationalStrings, exists);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInformationalStrings(InformationalStringID informationalStringID, IDWriteLocalizedStrings** informationalStrings, ref int exists)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, InformationalStringID, IDWriteLocalizedStrings**, int*, int>)@this->LpVtbl[42])(@this, informationalStringID, informationalStrings, existsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInformationalStrings(InformationalStringID informationalStringID, ref IDWriteLocalizedStrings* informationalStrings, int* exists)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteLocalizedStrings** informationalStringsPtr = &informationalStrings)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, InformationalStringID, IDWriteLocalizedStrings**, int*, int>)@this->LpVtbl[42])(@this, informationalStringID, informationalStringsPtr, exists);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInformationalStrings(InformationalStringID informationalStringID, ref IDWriteLocalizedStrings* informationalStrings, ref int exists)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteLocalizedStrings** informationalStringsPtr = &informationalStrings)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, InformationalStringID, IDWriteLocalizedStrings**, int*, int>)@this->LpVtbl[42])(@this, informationalStringID, informationalStringsPtr, existsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 HasCharacter(uint unicodeValue)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, Silk.NET.Core.Bool32>)@this->LpVtbl[43])(@this, unicodeValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsCharacterLocal(uint unicodeValue)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, Silk.NET.Core.Bool32>)@this->LpVtbl[45])(@this, unicodeValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsGlyphLocal(ushort glyphId)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort, Silk.NET.Core.Bool32>)@this->LpVtbl[46])(@this, glyphId);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AreCharactersLocal([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* characters, uint characterCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, int* isLocal)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, char*, uint, Silk.NET.Core.Bool32, int*, int>)@this->LpVtbl[47])(@this, characters, characterCount, enqueueIfNotLocal, isLocal);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AreCharactersLocal([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* characters, uint characterCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, ref int isLocal)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* isLocalPtr = &isLocal)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, char*, uint, Silk.NET.Core.Bool32, int*, int>)@this->LpVtbl[47])(@this, characters, characterCount, enqueueIfNotLocal, isLocalPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AreCharactersLocal([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char characters, uint characterCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, int* isLocal)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* charactersPtr = &characters)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, char*, uint, Silk.NET.Core.Bool32, int*, int>)@this->LpVtbl[47])(@this, charactersPtr, characterCount, enqueueIfNotLocal, isLocal);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AreCharactersLocal([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char characters, uint characterCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, ref int isLocal)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* charactersPtr = &characters)
            {
                fixed (int* isLocalPtr = &isLocal)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, char*, uint, Silk.NET.Core.Bool32, int*, int>)@this->LpVtbl[47])(@this, charactersPtr, characterCount, enqueueIfNotLocal, isLocalPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AreCharactersLocal([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string characters, uint characterCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, int* isLocal)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var charactersPtr = (byte*) SilkMarshal.StringToPtr(characters, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, byte*, uint, Silk.NET.Core.Bool32, int*, int>)@this->LpVtbl[47])(@this, charactersPtr, characterCount, enqueueIfNotLocal, isLocal);
            SilkMarshal.Free((nint)charactersPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AreCharactersLocal([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string characters, uint characterCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, ref int isLocal)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var charactersPtr = (byte*) SilkMarshal.StringToPtr(characters, NativeStringEncoding.UTF8);
            fixed (int* isLocalPtr = &isLocal)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, byte*, uint, Silk.NET.Core.Bool32, int*, int>)@this->LpVtbl[47])(@this, charactersPtr, characterCount, enqueueIfNotLocal, isLocalPtr);
            }
            SilkMarshal.Free((nint)charactersPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AreGlyphsLocal([Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, int* isLocal)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort*, uint, Silk.NET.Core.Bool32, int*, int>)@this->LpVtbl[48])(@this, glyphIndices, glyphCount, enqueueIfNotLocal, isLocal);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AreGlyphsLocal([Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, ref int isLocal)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* isLocalPtr = &isLocal)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort*, uint, Silk.NET.Core.Bool32, int*, int>)@this->LpVtbl[48])(@this, glyphIndices, glyphCount, enqueueIfNotLocal, isLocalPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AreGlyphsLocal([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, int* isLocal)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort*, uint, Silk.NET.Core.Bool32, int*, int>)@this->LpVtbl[48])(@this, glyphIndicesPtr, glyphCount, enqueueIfNotLocal, isLocal);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AreGlyphsLocal([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, ref int isLocal)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                fixed (int* isLocalPtr = &isLocal)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort*, uint, Silk.NET.Core.Bool32, int*, int>)@this->LpVtbl[48])(@this, glyphIndicesPtr, glyphCount, enqueueIfNotLocal, isLocalPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly GlyphImageFormats GetGlyphImageFormats()
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            GlyphImageFormats ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, GlyphImageFormats>)@this->LpVtbl[50])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphImageData(ushort glyphId, uint pixelsPerEm, GlyphImageFormats glyphImageFormat, GlyphImageData* glyphData, void** glyphDataContext)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort, uint, GlyphImageFormats, GlyphImageData*, void**, int>)@this->LpVtbl[51])(@this, glyphId, pixelsPerEm, glyphImageFormat, glyphData, glyphDataContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphImageData(ushort glyphId, uint pixelsPerEm, GlyphImageFormats glyphImageFormat, GlyphImageData* glyphData, ref void* glyphDataContext)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** glyphDataContextPtr = &glyphDataContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort, uint, GlyphImageFormats, GlyphImageData*, void**, int>)@this->LpVtbl[51])(@this, glyphId, pixelsPerEm, glyphImageFormat, glyphData, glyphDataContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphImageData(ushort glyphId, uint pixelsPerEm, GlyphImageFormats glyphImageFormat, ref GlyphImageData glyphData, void** glyphDataContext)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphImageData* glyphDataPtr = &glyphData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort, uint, GlyphImageFormats, GlyphImageData*, void**, int>)@this->LpVtbl[51])(@this, glyphId, pixelsPerEm, glyphImageFormat, glyphDataPtr, glyphDataContext);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphImageData(ushort glyphId, uint pixelsPerEm, GlyphImageFormats glyphImageFormat, ref GlyphImageData glyphData, ref void* glyphDataContext)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphImageData* glyphDataPtr = &glyphData)
            {
                fixed (void** glyphDataContextPtr = &glyphDataContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort, uint, GlyphImageFormats, GlyphImageData*, void**, int>)@this->LpVtbl[51])(@this, glyphId, pixelsPerEm, glyphImageFormat, glyphDataPtr, glyphDataContextPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ReleaseGlyphImageData(void* glyphDataContext)
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, void*, void>)@this->LpVtbl[52])(@this, glyphDataContext);
        }

        /// <summary>To be documented.</summary>
        public readonly void ReleaseGlyphImageData<T0>(ref T0 glyphDataContext) where T0 : unmanaged
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* glyphDataContextPtr = &glyphDataContext)
            {
                ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, void*, void>)@this->LpVtbl[52])(@this, glyphDataContextPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFiles<TI0>(uint* numberOfFiles, ref ComPtr<TI0> fontFiles) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFiles(numberOfFiles, (IDWriteFontFile**) fontFiles.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFiles<TI0>(ref uint numberOfFiles, ref ComPtr<TI0> fontFiles) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFiles(ref numberOfFiles, (IDWriteFontFile**) fontFiles.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRecommendedRenderingMode<TI0>(float emSize, float pixelsPerDip, MeasuringMode measuringMode, ComPtr<TI0> renderingParams, RenderingMode* renderingMode) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetRecommendedRenderingMode(emSize, pixelsPerDip, measuringMode, (IDWriteRenderingParams*) renderingParams.Handle, renderingMode);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRecommendedRenderingMode<TI0>(float emSize, float pixelsPerDip, MeasuringMode measuringMode, ComPtr<TI0> renderingParams, ref RenderingMode renderingMode) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetRecommendedRenderingMode(emSize, pixelsPerDip, measuringMode, (IDWriteRenderingParams*) renderingParams.Handle, ref renderingMode);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFontFaceReference<TI0>(ref ComPtr<TI0> fontFaceReference) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFontFaceReference((IDWriteFontFaceReference**) fontFaceReference.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFamilyNames<TI0>(ref ComPtr<TI0> names) where TI0 : unmanaged, IComVtbl<IDWriteLocalizedStrings>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFamilyNames((IDWriteLocalizedStrings**) names.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFaceNames<TI0>(ref ComPtr<TI0> names) where TI0 : unmanaged, IComVtbl<IDWriteLocalizedStrings>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFaceNames((IDWriteLocalizedStrings**) names.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInformationalStrings<TI0>(InformationalStringID informationalStringID, ref ComPtr<TI0> informationalStrings, int* exists) where TI0 : unmanaged, IComVtbl<IDWriteLocalizedStrings>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetInformationalStrings(informationalStringID, (IDWriteLocalizedStrings**) informationalStrings.GetAddressOf(), exists);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetInformationalStrings<TI0>(InformationalStringID informationalStringID, ref ComPtr<TI0> informationalStrings, ref int exists) where TI0 : unmanaged, IComVtbl<IDWriteLocalizedStrings>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetInformationalStrings(informationalStringID, (IDWriteLocalizedStrings**) informationalStrings.GetAddressOf(), ref exists);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFace4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
