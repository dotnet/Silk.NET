// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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

namespace Silk.NET.Direct3D9
{
    [Guid("d0223b96-bf7a-43fd-92bd-a43b0d82b9eb")]
    [NativeName("Name", "IDirect3DDevice9")]
    public unsafe partial struct IDirect3DDevice9
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3DDevice9 val)
            => Unsafe.As<IDirect3DDevice9, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirect3DDevice9
        (
            DeviceCreationParameters? creationParameters = null,
            PresentParameters? presentParameters = null,
            Displaymode? displayMode = null,
            Caps9? caps = null,
            uint? availableTextureMem = null,
            uint? swapChains = null,
            uint? textures = null,
            uint? vertexBuffers = null,
            uint? indexBuffers = null,
            uint? vertexShaders = null,
            uint? pixelShaders = null,
            Viewport9? viewport = null,
            Matrix? projectionMatrix = null,
            Matrix? viewMatrix = null,
            Matrix? worldMatrix = null,
            uint? fVF = null,
            uint? vertexSize = null,
            uint? vertexShaderVersion = null,
            uint? pixelShaderVersion = null,
            int? softwareVertexProcessing = null,
            Material9? material = null,
            Gammaramp? gammaRamp = null,
            Silk.NET.Maths.Rectangle<long>? scissorRect = null,
            int? dialogBoxMode = null,
            void** lpVtbl = null
        ) : this()
        {
            if (creationParameters is not null)
            {
                CreationParameters = creationParameters.Value;
            }

            if (presentParameters is not null)
            {
                PresentParameters = presentParameters.Value;
            }

            if (displayMode is not null)
            {
                DisplayMode = displayMode.Value;
            }

            if (caps is not null)
            {
                Caps = caps.Value;
            }

            if (availableTextureMem is not null)
            {
                AvailableTextureMem = availableTextureMem.Value;
            }

            if (swapChains is not null)
            {
                SwapChains = swapChains.Value;
            }

            if (textures is not null)
            {
                Textures = textures.Value;
            }

            if (vertexBuffers is not null)
            {
                VertexBuffers = vertexBuffers.Value;
            }

            if (indexBuffers is not null)
            {
                IndexBuffers = indexBuffers.Value;
            }

            if (vertexShaders is not null)
            {
                VertexShaders = vertexShaders.Value;
            }

            if (pixelShaders is not null)
            {
                PixelShaders = pixelShaders.Value;
            }

            if (viewport is not null)
            {
                Viewport = viewport.Value;
            }

            if (projectionMatrix is not null)
            {
                ProjectionMatrix = projectionMatrix.Value;
            }

            if (viewMatrix is not null)
            {
                ViewMatrix = viewMatrix.Value;
            }

            if (worldMatrix is not null)
            {
                WorldMatrix = worldMatrix.Value;
            }

            if (fVF is not null)
            {
                FVF = fVF.Value;
            }

            if (vertexSize is not null)
            {
                VertexSize = vertexSize.Value;
            }

            if (vertexShaderVersion is not null)
            {
                VertexShaderVersion = vertexShaderVersion.Value;
            }

            if (pixelShaderVersion is not null)
            {
                PixelShaderVersion = pixelShaderVersion.Value;
            }

            if (softwareVertexProcessing is not null)
            {
                SoftwareVertexProcessing = softwareVertexProcessing.Value;
            }

            if (material is not null)
            {
                Material = material.Value;
            }

            if (gammaRamp is not null)
            {
                GammaRamp = gammaRamp.Value;
            }

            if (scissorRect is not null)
            {
                ScissorRect = scissorRect.Value;
            }

            if (dialogBoxMode is not null)
            {
                DialogBoxMode = dialogBoxMode.Value;
            }

            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "D3DDEVICE_CREATION_PARAMETERS")]
        [NativeName("Type.Name", "D3DDEVICE_CREATION_PARAMETERS")]
        [NativeName("Name", "CreationParameters")]
        public DeviceCreationParameters CreationParameters;

        [NativeName("Type", "D3DPRESENT_PARAMETERS")]
        [NativeName("Type.Name", "D3DPRESENT_PARAMETERS")]
        [NativeName("Name", "PresentParameters")]
        public PresentParameters PresentParameters;

        [NativeName("Type", "D3DDISPLAYMODE")]
        [NativeName("Type.Name", "D3DDISPLAYMODE")]
        [NativeName("Name", "DisplayMode")]
        public Displaymode DisplayMode;

        [NativeName("Type", "D3DCAPS9")]
        [NativeName("Type.Name", "D3DCAPS9")]
        [NativeName("Name", "Caps")]
        public Caps9 Caps;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "AvailableTextureMem")]
        public uint AvailableTextureMem;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SwapChains")]
        public uint SwapChains;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Textures")]
        public uint Textures;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "VertexBuffers")]
        public uint VertexBuffers;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "IndexBuffers")]
        public uint IndexBuffers;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "VertexShaders")]
        public uint VertexShaders;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "PixelShaders")]
        public uint PixelShaders;

        [NativeName("Type", "D3DVIEWPORT9")]
        [NativeName("Type.Name", "D3DVIEWPORT9")]
        [NativeName("Name", "Viewport")]
        public Viewport9 Viewport;

        [NativeName("Type", "D3DMATRIX")]
        [NativeName("Type.Name", "D3DMATRIX")]
        [NativeName("Name", "ProjectionMatrix")]
        public Matrix ProjectionMatrix;

        [NativeName("Type", "D3DMATRIX")]
        [NativeName("Type.Name", "D3DMATRIX")]
        [NativeName("Name", "ViewMatrix")]
        public Matrix ViewMatrix;

        [NativeName("Type", "D3DMATRIX")]
        [NativeName("Type.Name", "D3DMATRIX")]
        [NativeName("Name", "WorldMatrix")]
        public Matrix WorldMatrix;
        
        [NativeName("Type", "D3DMATRIX [8]")]
        [NativeName("Type.Name", "D3DMATRIX [8]")]
        [NativeName("Name", "TextureMatrices")]
        public TextureMatricesBuffer TextureMatrices;

        public struct TextureMatricesBuffer
        {
            public Matrix Element0;
            public Matrix Element1;
            public Matrix Element2;
            public Matrix Element3;
            public Matrix Element4;
            public Matrix Element5;
            public Matrix Element6;
            public Matrix Element7;
            public ref Matrix this[int index]
            {
                get
                {
                    if (index > 7 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (Matrix* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1
            public Span<Matrix> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 8);
#endif
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "FVF")]
        public uint FVF;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "VertexSize")]
        public uint VertexSize;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "VertexShaderVersion")]
        public uint VertexShaderVersion;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "PixelShaderVersion")]
        public uint PixelShaderVersion;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "SoftwareVertexProcessing")]
        public int SoftwareVertexProcessing;

        [NativeName("Type", "D3DMATERIAL9")]
        [NativeName("Type.Name", "D3DMATERIAL9")]
        [NativeName("Name", "Material")]
        public Material9 Material;
        
        [NativeName("Type", "D3DLIGHT9 [16]")]
        [NativeName("Type.Name", "D3DLIGHT9 [16]")]
        [NativeName("Name", "Lights")]
        public LightsBuffer Lights;

        public struct LightsBuffer
        {
            public Light9 Element0;
            public Light9 Element1;
            public Light9 Element2;
            public Light9 Element3;
            public Light9 Element4;
            public Light9 Element5;
            public Light9 Element6;
            public Light9 Element7;
            public Light9 Element8;
            public Light9 Element9;
            public Light9 Element10;
            public Light9 Element11;
            public Light9 Element12;
            public Light9 Element13;
            public Light9 Element14;
            public Light9 Element15;
            public ref Light9 this[int index]
            {
                get
                {
                    if (index > 15 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (Light9* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1
            public Span<Light9> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 16);
#endif
        }

        [NativeName("Type", "BOOL [16]")]
        [NativeName("Type.Name", "BOOL [16]")]
        [NativeName("Name", "LightsEnabled")]
        public fixed int LightsEnabled[16];

        [NativeName("Type", "D3DGAMMARAMP")]
        [NativeName("Type.Name", "D3DGAMMARAMP")]
        [NativeName("Name", "GammaRamp")]
        public Gammaramp GammaRamp;

        [NativeName("Type", "RECT")]
        [NativeName("Type.Name", "RECT")]
        [NativeName("Name", "ScissorRect")]
        public Silk.NET.Maths.Rectangle<long> ScissorRect;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DialogBoxMode")]
        public int DialogBoxMode;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint Release()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int TestCooperativeLevel()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, int>)LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint GetAvailableTextureMem()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint>)LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int EvictManagedResources()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, int>)LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetDirect3D(IDirect3D9** ppD3D9)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3D9**, int>)LpVtbl[6])(@this, ppD3D9);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetDirect3D(ref IDirect3D9* ppD3D9)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3D9** ppD3D9Ptr = &ppD3D9)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3D9**, int>)LpVtbl[6])(@this, ppD3D9Ptr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetDeviceCaps(Caps9* pCaps)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Caps9*, int>)LpVtbl[7])(@this, pCaps);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetDeviceCaps(ref Caps9 pCaps)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Caps9* pCapsPtr = &pCaps)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Caps9*, int>)LpVtbl[7])(@this, pCapsPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetDisplayMode(uint iSwapChain, Displaymode* pMode)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Displaymode*, int>)LpVtbl[8])(@this, iSwapChain, pMode);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetDisplayMode(uint iSwapChain, ref Displaymode pMode)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Displaymode* pModePtr = &pMode)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Displaymode*, int>)LpVtbl[8])(@this, iSwapChain, pModePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetCreationParameters(DeviceCreationParameters* pParameters)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, DeviceCreationParameters*, int>)LpVtbl[9])(@this, pParameters);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetCreationParameters(ref DeviceCreationParameters pParameters)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (DeviceCreationParameters* pParametersPtr = &pParameters)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, DeviceCreationParameters*, int>)LpVtbl[9])(@this, pParametersPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetCursorProperties(uint XHotSpot, uint YHotSpot, IDirect3DSurface9* pCursorBitmap)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, IDirect3DSurface9*, int>)LpVtbl[10])(@this, XHotSpot, YHotSpot, pCursorBitmap);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetCursorProperties(uint XHotSpot, uint YHotSpot, ref IDirect3DSurface9 pCursorBitmap)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9* pCursorBitmapPtr = &pCursorBitmap)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, IDirect3DSurface9*, int>)LpVtbl[10])(@this, XHotSpot, YHotSpot, pCursorBitmapPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly void SetCursorPosition(int X, int Y, uint Flags)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, int, int, uint, void>)LpVtbl[11])(@this, X, Y, Flags);
        }

        /// <summary>To be added.</summary>
        public readonly int ShowCursor(int bShow)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, int, int>)LpVtbl[12])(@this, bShow);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateAdditionalSwapChain(PresentParameters* pPresentationParameters, IDirect3DSwapChain9** pSwapChain)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, PresentParameters*, IDirect3DSwapChain9**, int>)LpVtbl[13])(@this, pPresentationParameters, pSwapChain);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateAdditionalSwapChain(PresentParameters* pPresentationParameters, ref IDirect3DSwapChain9* pSwapChain)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSwapChain9** pSwapChainPtr = &pSwapChain)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, PresentParameters*, IDirect3DSwapChain9**, int>)LpVtbl[13])(@this, pPresentationParameters, pSwapChainPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateAdditionalSwapChain(ref PresentParameters pPresentationParameters, IDirect3DSwapChain9** pSwapChain)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, PresentParameters*, IDirect3DSwapChain9**, int>)LpVtbl[13])(@this, pPresentationParametersPtr, pSwapChain);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateAdditionalSwapChain(ref PresentParameters pPresentationParameters, ref IDirect3DSwapChain9* pSwapChain)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
            {
                fixed (IDirect3DSwapChain9** pSwapChainPtr = &pSwapChain)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, PresentParameters*, IDirect3DSwapChain9**, int>)LpVtbl[13])(@this, pPresentationParametersPtr, pSwapChainPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetSwapChain(uint iSwapChain, IDirect3DSwapChain9** pSwapChain)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DSwapChain9**, int>)LpVtbl[14])(@this, iSwapChain, pSwapChain);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetSwapChain(uint iSwapChain, ref IDirect3DSwapChain9* pSwapChain)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSwapChain9** pSwapChainPtr = &pSwapChain)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DSwapChain9**, int>)LpVtbl[14])(@this, iSwapChain, pSwapChainPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint GetNumberOfSwapChains()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint>)LpVtbl[15])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Reset(PresentParameters* pPresentationParameters)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, PresentParameters*, int>)LpVtbl[16])(@this, pPresentationParameters);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int Reset(ref PresentParameters pPresentationParameters)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, PresentParameters*, int>)LpVtbl[16])(@this, pPresentationParametersPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Present(Silk.NET.Maths.Rectangle<long>* pSourceRect, Silk.NET.Maths.Rectangle<long>* pDestRect, IntPtr hDestWindowOverride, RGNData* pDirtyRegion)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<long>*, Silk.NET.Maths.Rectangle<long>*, IntPtr, RGNData*, int>)LpVtbl[17])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Present(Silk.NET.Maths.Rectangle<long>* pSourceRect, Silk.NET.Maths.Rectangle<long>* pDestRect, IntPtr hDestWindowOverride, ref RGNData pDirtyRegion)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<long>*, Silk.NET.Maths.Rectangle<long>*, IntPtr, RGNData*, int>)LpVtbl[17])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegionPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Present(Silk.NET.Maths.Rectangle<long>* pSourceRect, ref Silk.NET.Maths.Rectangle<long> pDestRect, IntPtr hDestWindowOverride, RGNData* pDirtyRegion)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Maths.Rectangle<long>* pDestRectPtr = &pDestRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<long>*, Silk.NET.Maths.Rectangle<long>*, IntPtr, RGNData*, int>)LpVtbl[17])(@this, pSourceRect, pDestRectPtr, hDestWindowOverride, pDirtyRegion);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Present(Silk.NET.Maths.Rectangle<long>* pSourceRect, ref Silk.NET.Maths.Rectangle<long> pDestRect, IntPtr hDestWindowOverride, ref RGNData pDirtyRegion)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Maths.Rectangle<long>* pDestRectPtr = &pDestRect)
            {
                fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<long>*, Silk.NET.Maths.Rectangle<long>*, IntPtr, RGNData*, int>)LpVtbl[17])(@this, pSourceRect, pDestRectPtr, hDestWindowOverride, pDirtyRegionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Present(ref Silk.NET.Maths.Rectangle<long> pSourceRect, Silk.NET.Maths.Rectangle<long>* pDestRect, IntPtr hDestWindowOverride, RGNData* pDirtyRegion)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Maths.Rectangle<long>* pSourceRectPtr = &pSourceRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<long>*, Silk.NET.Maths.Rectangle<long>*, IntPtr, RGNData*, int>)LpVtbl[17])(@this, pSourceRectPtr, pDestRect, hDestWindowOverride, pDirtyRegion);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Present(ref Silk.NET.Maths.Rectangle<long> pSourceRect, Silk.NET.Maths.Rectangle<long>* pDestRect, IntPtr hDestWindowOverride, ref RGNData pDirtyRegion)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Maths.Rectangle<long>* pSourceRectPtr = &pSourceRect)
            {
                fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<long>*, Silk.NET.Maths.Rectangle<long>*, IntPtr, RGNData*, int>)LpVtbl[17])(@this, pSourceRectPtr, pDestRect, hDestWindowOverride, pDirtyRegionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Present(ref Silk.NET.Maths.Rectangle<long> pSourceRect, ref Silk.NET.Maths.Rectangle<long> pDestRect, IntPtr hDestWindowOverride, RGNData* pDirtyRegion)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Maths.Rectangle<long>* pSourceRectPtr = &pSourceRect)
            {
                fixed (Silk.NET.Maths.Rectangle<long>* pDestRectPtr = &pDestRect)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<long>*, Silk.NET.Maths.Rectangle<long>*, IntPtr, RGNData*, int>)LpVtbl[17])(@this, pSourceRectPtr, pDestRectPtr, hDestWindowOverride, pDirtyRegion);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int Present(ref Silk.NET.Maths.Rectangle<long> pSourceRect, ref Silk.NET.Maths.Rectangle<long> pDestRect, IntPtr hDestWindowOverride, ref RGNData pDirtyRegion)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Maths.Rectangle<long>* pSourceRectPtr = &pSourceRect)
            {
                fixed (Silk.NET.Maths.Rectangle<long>* pDestRectPtr = &pDestRect)
                {
                    fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<long>*, Silk.NET.Maths.Rectangle<long>*, IntPtr, RGNData*, int>)LpVtbl[17])(@this, pSourceRectPtr, pDestRectPtr, hDestWindowOverride, pDirtyRegionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetBackBuffer(uint iSwapChain, uint iBackBuffer, BackbufferType Type, IDirect3DSurface9** ppBackBuffer)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, BackbufferType, IDirect3DSurface9**, int>)LpVtbl[18])(@this, iSwapChain, iBackBuffer, Type, ppBackBuffer);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetBackBuffer(uint iSwapChain, uint iBackBuffer, BackbufferType Type, ref IDirect3DSurface9* ppBackBuffer)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9** ppBackBufferPtr = &ppBackBuffer)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, BackbufferType, IDirect3DSurface9**, int>)LpVtbl[18])(@this, iSwapChain, iBackBuffer, Type, ppBackBufferPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetRasterStatus(uint iSwapChain, RasterStatus* pRasterStatus)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, RasterStatus*, int>)LpVtbl[19])(@this, iSwapChain, pRasterStatus);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetRasterStatus(uint iSwapChain, ref RasterStatus pRasterStatus)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (RasterStatus* pRasterStatusPtr = &pRasterStatus)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, RasterStatus*, int>)LpVtbl[19])(@this, iSwapChain, pRasterStatusPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetDialogBoxMode(int bEnableDialogs)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, int, int>)LpVtbl[20])(@this, bEnableDialogs);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void SetGammaRamp(uint iSwapChain, uint Flags, Gammaramp* pRamp)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Gammaramp*, void>)LpVtbl[21])(@this, iSwapChain, Flags, pRamp);
        }

        /// <summary>To be added.</summary>
        public readonly void SetGammaRamp(uint iSwapChain, uint Flags, ref Gammaramp pRamp)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Gammaramp* pRampPtr = &pRamp)
            {
                ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Gammaramp*, void>)LpVtbl[21])(@this, iSwapChain, Flags, pRampPtr);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetGammaRamp(uint iSwapChain, Gammaramp* pRamp)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Gammaramp*, void>)LpVtbl[22])(@this, iSwapChain, pRamp);
        }

        /// <summary>To be added.</summary>
        public readonly void GetGammaRamp(uint iSwapChain, ref Gammaramp pRamp)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Gammaramp* pRampPtr = &pRamp)
            {
                ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Gammaramp*, void>)LpVtbl[22])(@this, iSwapChain, pRampPtr);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateTexture(uint Width, uint Height, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DTexture9** ppTexture, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexture, pSharedHandle);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateTexture(uint Width, uint Height, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DTexture9** ppTexture, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexture, pSharedHandlePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateTexture(uint Width, uint Height, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DTexture9* ppTexture, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DTexture9** ppTexturePtr = &ppTexture)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexturePtr, pSharedHandle);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateTexture(uint Width, uint Height, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DTexture9* ppTexture, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DTexture9** ppTexturePtr = &ppTexture)
            {
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexturePtr, pSharedHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateVolumeTexture(uint Width, uint Height, uint Depth, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DVolumeTexture9** ppVolumeTexture, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexture, pSharedHandle);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateVolumeTexture(uint Width, uint Height, uint Depth, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DVolumeTexture9** ppVolumeTexture, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexture, pSharedHandlePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateVolumeTexture(uint Width, uint Height, uint Depth, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DVolumeTexture9* ppVolumeTexture, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DVolumeTexture9** ppVolumeTexturePtr = &ppVolumeTexture)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexturePtr, pSharedHandle);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateVolumeTexture(uint Width, uint Height, uint Depth, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DVolumeTexture9* ppVolumeTexture, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DVolumeTexture9** ppVolumeTexturePtr = &ppVolumeTexture)
            {
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexturePtr, pSharedHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCubeTexture(uint EdgeLength, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DCubeTexture9** ppCubeTexture, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexture, pSharedHandle);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCubeTexture(uint EdgeLength, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DCubeTexture9** ppCubeTexture, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexture, pSharedHandlePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCubeTexture(uint EdgeLength, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DCubeTexture9* ppCubeTexture, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DCubeTexture9** ppCubeTexturePtr = &ppCubeTexture)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexturePtr, pSharedHandle);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateCubeTexture(uint EdgeLength, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DCubeTexture9* ppCubeTexture, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DCubeTexture9** ppCubeTexturePtr = &ppCubeTexture)
            {
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexturePtr, pSharedHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateVertexBuffer(uint Length, uint Usage, uint FVF, Pool Pool, IDirect3DVertexBuffer9** ppVertexBuffer, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBuffer, pSharedHandle);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateVertexBuffer(uint Length, uint Usage, uint FVF, Pool Pool, IDirect3DVertexBuffer9** ppVertexBuffer, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBuffer, pSharedHandlePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateVertexBuffer(uint Length, uint Usage, uint FVF, Pool Pool, ref IDirect3DVertexBuffer9* ppVertexBuffer, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DVertexBuffer9** ppVertexBufferPtr = &ppVertexBuffer)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBufferPtr, pSharedHandle);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateVertexBuffer(uint Length, uint Usage, uint FVF, Pool Pool, ref IDirect3DVertexBuffer9* ppVertexBuffer, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DVertexBuffer9** ppVertexBufferPtr = &ppVertexBuffer)
            {
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBufferPtr, pSharedHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateIndexBuffer(uint Length, uint Usage, Format Format, Pool Pool, IDirect3DIndexBuffer9** ppIndexBuffer, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBuffer, pSharedHandle);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateIndexBuffer(uint Length, uint Usage, Format Format, Pool Pool, IDirect3DIndexBuffer9** ppIndexBuffer, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBuffer, pSharedHandlePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateIndexBuffer(uint Length, uint Usage, Format Format, Pool Pool, ref IDirect3DIndexBuffer9* ppIndexBuffer, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DIndexBuffer9** ppIndexBufferPtr = &ppIndexBuffer)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBufferPtr, pSharedHandle);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateIndexBuffer(uint Length, uint Usage, Format Format, Pool Pool, ref IDirect3DIndexBuffer9* ppIndexBuffer, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DIndexBuffer9** ppIndexBufferPtr = &ppIndexBuffer)
            {
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBufferPtr, pSharedHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateRenderTarget(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Lockable, IDirect3DSurface9** ppSurface, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurface, pSharedHandle);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateRenderTarget(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Lockable, IDirect3DSurface9** ppSurface, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurface, pSharedHandlePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateRenderTarget(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Lockable, ref IDirect3DSurface9* ppSurface, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurfacePtr, pSharedHandle);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateRenderTarget(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Lockable, ref IDirect3DSurface9* ppSurface, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
            {
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurfacePtr, pSharedHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateDepthStencilSurface(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Discard, IDirect3DSurface9** ppSurface, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurface, pSharedHandle);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateDepthStencilSurface(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Discard, IDirect3DSurface9** ppSurface, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurface, pSharedHandlePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateDepthStencilSurface(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Discard, ref IDirect3DSurface9* ppSurface, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurfacePtr, pSharedHandle);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateDepthStencilSurface(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Discard, ref IDirect3DSurface9* ppSurface, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
            {
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurfacePtr, pSharedHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, Silk.NET.Maths.Rectangle<long>* pSourceRect, IDirect3DSurface9* pDestinationSurface, Silk.NET.Maths.Vector2D<long>* pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<long>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurface, pDestPoint);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, Silk.NET.Maths.Rectangle<long>* pSourceRect, IDirect3DSurface9* pDestinationSurface, ref Silk.NET.Maths.Vector2D<long> pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Maths.Vector2D<long>* pDestPointPtr = &pDestPoint)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<long>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurface, pDestPointPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, Silk.NET.Maths.Rectangle<long>* pSourceRect, ref IDirect3DSurface9 pDestinationSurface, Silk.NET.Maths.Vector2D<long>* pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<long>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurfacePtr, pDestPoint);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, Silk.NET.Maths.Rectangle<long>* pSourceRect, ref IDirect3DSurface9 pDestinationSurface, ref Silk.NET.Maths.Vector2D<long> pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
            {
                fixed (Silk.NET.Maths.Vector2D<long>* pDestPointPtr = &pDestPoint)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<long>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurfacePtr, pDestPointPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, ref Silk.NET.Maths.Rectangle<long> pSourceRect, IDirect3DSurface9* pDestinationSurface, Silk.NET.Maths.Vector2D<long>* pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Maths.Rectangle<long>* pSourceRectPtr = &pSourceRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<long>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurface, pDestPoint);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, ref Silk.NET.Maths.Rectangle<long> pSourceRect, IDirect3DSurface9* pDestinationSurface, ref Silk.NET.Maths.Vector2D<long> pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Maths.Rectangle<long>* pSourceRectPtr = &pSourceRect)
            {
                fixed (Silk.NET.Maths.Vector2D<long>* pDestPointPtr = &pDestPoint)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<long>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurface, pDestPointPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, ref Silk.NET.Maths.Rectangle<long> pSourceRect, ref IDirect3DSurface9 pDestinationSurface, Silk.NET.Maths.Vector2D<long>* pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Maths.Rectangle<long>* pSourceRectPtr = &pSourceRect)
            {
                fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<long>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurfacePtr, pDestPoint);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, ref Silk.NET.Maths.Rectangle<long> pSourceRect, ref IDirect3DSurface9 pDestinationSurface, ref Silk.NET.Maths.Vector2D<long> pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Maths.Rectangle<long>* pSourceRectPtr = &pSourceRect)
            {
                fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
                {
                    fixed (Silk.NET.Maths.Vector2D<long>* pDestPointPtr = &pDestPoint)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<long>*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurfacePtr, pDestPointPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, Silk.NET.Maths.Rectangle<long>* pSourceRect, IDirect3DSurface9* pDestinationSurface, Silk.NET.Maths.Vector2D<long>* pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<long>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurface, pDestPoint);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, Silk.NET.Maths.Rectangle<long>* pSourceRect, IDirect3DSurface9* pDestinationSurface, ref Silk.NET.Maths.Vector2D<long> pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (Silk.NET.Maths.Vector2D<long>* pDestPointPtr = &pDestPoint)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<long>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurface, pDestPointPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, Silk.NET.Maths.Rectangle<long>* pSourceRect, ref IDirect3DSurface9 pDestinationSurface, Silk.NET.Maths.Vector2D<long>* pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<long>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurfacePtr, pDestPoint);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, Silk.NET.Maths.Rectangle<long>* pSourceRect, ref IDirect3DSurface9 pDestinationSurface, ref Silk.NET.Maths.Vector2D<long> pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
                {
                    fixed (Silk.NET.Maths.Vector2D<long>* pDestPointPtr = &pDestPoint)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<long>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurfacePtr, pDestPointPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Maths.Rectangle<long> pSourceRect, IDirect3DSurface9* pDestinationSurface, Silk.NET.Maths.Vector2D<long>* pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (Silk.NET.Maths.Rectangle<long>* pSourceRectPtr = &pSourceRect)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<long>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurface, pDestPoint);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Maths.Rectangle<long> pSourceRect, IDirect3DSurface9* pDestinationSurface, ref Silk.NET.Maths.Vector2D<long> pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (Silk.NET.Maths.Rectangle<long>* pSourceRectPtr = &pSourceRect)
                {
                    fixed (Silk.NET.Maths.Vector2D<long>* pDestPointPtr = &pDestPoint)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<long>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurface, pDestPointPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Maths.Rectangle<long> pSourceRect, ref IDirect3DSurface9 pDestinationSurface, Silk.NET.Maths.Vector2D<long>* pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (Silk.NET.Maths.Rectangle<long>* pSourceRectPtr = &pSourceRect)
                {
                    fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<long>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurfacePtr, pDestPoint);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Maths.Rectangle<long> pSourceRect, ref IDirect3DSurface9 pDestinationSurface, ref Silk.NET.Maths.Vector2D<long> pDestPoint)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (Silk.NET.Maths.Rectangle<long>* pSourceRectPtr = &pSourceRect)
                {
                    fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
                    {
                        fixed (Silk.NET.Maths.Vector2D<long>* pDestPointPtr = &pDestPoint)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<long>*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurfacePtr, pDestPointPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int UpdateTexture(IDirect3DBaseTexture9* pSourceTexture, IDirect3DBaseTexture9* pDestinationTexture)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)LpVtbl[31])(@this, pSourceTexture, pDestinationTexture);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int UpdateTexture(IDirect3DBaseTexture9* pSourceTexture, ref IDirect3DBaseTexture9 pDestinationTexture)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DBaseTexture9* pDestinationTexturePtr = &pDestinationTexture)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)LpVtbl[31])(@this, pSourceTexture, pDestinationTexturePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int UpdateTexture(ref IDirect3DBaseTexture9 pSourceTexture, IDirect3DBaseTexture9* pDestinationTexture)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DBaseTexture9* pSourceTexturePtr = &pSourceTexture)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)LpVtbl[31])(@this, pSourceTexturePtr, pDestinationTexture);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int UpdateTexture(ref IDirect3DBaseTexture9 pSourceTexture, ref IDirect3DBaseTexture9 pDestinationTexture)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DBaseTexture9* pSourceTexturePtr = &pSourceTexture)
            {
                fixed (IDirect3DBaseTexture9* pDestinationTexturePtr = &pDestinationTexture)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)LpVtbl[31])(@this, pSourceTexturePtr, pDestinationTexturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetRenderTargetData(IDirect3DSurface9* pRenderTarget, IDirect3DSurface9* pDestSurface)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, IDirect3DSurface9*, int>)LpVtbl[32])(@this, pRenderTarget, pDestSurface);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetRenderTargetData(IDirect3DSurface9* pRenderTarget, ref IDirect3DSurface9 pDestSurface)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, IDirect3DSurface9*, int>)LpVtbl[32])(@this, pRenderTarget, pDestSurfacePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetRenderTargetData(ref IDirect3DSurface9 pRenderTarget, IDirect3DSurface9* pDestSurface)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, IDirect3DSurface9*, int>)LpVtbl[32])(@this, pRenderTargetPtr, pDestSurface);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetRenderTargetData(ref IDirect3DSurface9 pRenderTarget, ref IDirect3DSurface9 pDestSurface)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
            {
                fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, IDirect3DSurface9*, int>)LpVtbl[32])(@this, pRenderTargetPtr, pDestSurfacePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetFrontBufferData(uint iSwapChain, IDirect3DSurface9* pDestSurface)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DSurface9*, int>)LpVtbl[33])(@this, iSwapChain, pDestSurface);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetFrontBufferData(uint iSwapChain, ref IDirect3DSurface9 pDestSurface)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DSurface9*, int>)LpVtbl[33])(@this, iSwapChain, pDestSurfacePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, Silk.NET.Maths.Rectangle<long>* pSourceRect, IDirect3DSurface9* pDestSurface, Silk.NET.Maths.Rectangle<long>* pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurface, pDestRect, Filter);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, Silk.NET.Maths.Rectangle<long>* pSourceRect, IDirect3DSurface9* pDestSurface, ref Silk.NET.Maths.Rectangle<long> pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Maths.Rectangle<long>* pDestRectPtr = &pDestRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurface, pDestRectPtr, Filter);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, Silk.NET.Maths.Rectangle<long>* pSourceRect, ref IDirect3DSurface9 pDestSurface, Silk.NET.Maths.Rectangle<long>* pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurfacePtr, pDestRect, Filter);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, Silk.NET.Maths.Rectangle<long>* pSourceRect, ref IDirect3DSurface9 pDestSurface, ref Silk.NET.Maths.Rectangle<long> pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
            {
                fixed (Silk.NET.Maths.Rectangle<long>* pDestRectPtr = &pDestRect)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurfacePtr, pDestRectPtr, Filter);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, ref Silk.NET.Maths.Rectangle<long> pSourceRect, IDirect3DSurface9* pDestSurface, Silk.NET.Maths.Rectangle<long>* pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Maths.Rectangle<long>* pSourceRectPtr = &pSourceRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurface, pDestRect, Filter);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, ref Silk.NET.Maths.Rectangle<long> pSourceRect, IDirect3DSurface9* pDestSurface, ref Silk.NET.Maths.Rectangle<long> pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Maths.Rectangle<long>* pSourceRectPtr = &pSourceRect)
            {
                fixed (Silk.NET.Maths.Rectangle<long>* pDestRectPtr = &pDestRect)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurface, pDestRectPtr, Filter);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, ref Silk.NET.Maths.Rectangle<long> pSourceRect, ref IDirect3DSurface9 pDestSurface, Silk.NET.Maths.Rectangle<long>* pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Maths.Rectangle<long>* pSourceRectPtr = &pSourceRect)
            {
                fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurfacePtr, pDestRect, Filter);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, ref Silk.NET.Maths.Rectangle<long> pSourceRect, ref IDirect3DSurface9 pDestSurface, ref Silk.NET.Maths.Rectangle<long> pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Maths.Rectangle<long>* pSourceRectPtr = &pSourceRect)
            {
                fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                {
                    fixed (Silk.NET.Maths.Rectangle<long>* pDestRectPtr = &pDestRect)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurfacePtr, pDestRectPtr, Filter);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int StretchRect(ref IDirect3DSurface9 pSourceSurface, Silk.NET.Maths.Rectangle<long>* pSourceRect, IDirect3DSurface9* pDestSurface, Silk.NET.Maths.Rectangle<long>* pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurface, pDestRect, Filter);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int StretchRect(ref IDirect3DSurface9 pSourceSurface, Silk.NET.Maths.Rectangle<long>* pSourceRect, IDirect3DSurface9* pDestSurface, ref Silk.NET.Maths.Rectangle<long> pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (Silk.NET.Maths.Rectangle<long>* pDestRectPtr = &pDestRect)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurface, pDestRectPtr, Filter);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int StretchRect(ref IDirect3DSurface9 pSourceSurface, Silk.NET.Maths.Rectangle<long>* pSourceRect, ref IDirect3DSurface9 pDestSurface, Silk.NET.Maths.Rectangle<long>* pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurfacePtr, pDestRect, Filter);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int StretchRect(ref IDirect3DSurface9 pSourceSurface, Silk.NET.Maths.Rectangle<long>* pSourceRect, ref IDirect3DSurface9 pDestSurface, ref Silk.NET.Maths.Rectangle<long> pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                {
                    fixed (Silk.NET.Maths.Rectangle<long>* pDestRectPtr = &pDestRect)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurfacePtr, pDestRectPtr, Filter);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int StretchRect(ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Maths.Rectangle<long> pSourceRect, IDirect3DSurface9* pDestSurface, Silk.NET.Maths.Rectangle<long>* pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (Silk.NET.Maths.Rectangle<long>* pSourceRectPtr = &pSourceRect)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurface, pDestRect, Filter);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int StretchRect(ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Maths.Rectangle<long> pSourceRect, IDirect3DSurface9* pDestSurface, ref Silk.NET.Maths.Rectangle<long> pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (Silk.NET.Maths.Rectangle<long>* pSourceRectPtr = &pSourceRect)
                {
                    fixed (Silk.NET.Maths.Rectangle<long>* pDestRectPtr = &pDestRect)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurface, pDestRectPtr, Filter);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int StretchRect(ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Maths.Rectangle<long> pSourceRect, ref IDirect3DSurface9 pDestSurface, Silk.NET.Maths.Rectangle<long>* pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (Silk.NET.Maths.Rectangle<long>* pSourceRectPtr = &pSourceRect)
                {
                    fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurfacePtr, pDestRect, Filter);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int StretchRect(ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Maths.Rectangle<long> pSourceRect, ref IDirect3DSurface9 pDestSurface, ref Silk.NET.Maths.Rectangle<long> pDestRect, Texturefiltertype Filter)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
            {
                fixed (Silk.NET.Maths.Rectangle<long>* pSourceRectPtr = &pSourceRect)
                {
                    fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                    {
                        fixed (Silk.NET.Maths.Rectangle<long>* pDestRectPtr = &pDestRect)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurfacePtr, pDestRectPtr, Filter);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int ColorFill(IDirect3DSurface9* pSurface, Silk.NET.Maths.Rectangle<long>* pRect, uint color)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, uint, int>)LpVtbl[35])(@this, pSurface, pRect, color);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int ColorFill(IDirect3DSurface9* pSurface, ref Silk.NET.Maths.Rectangle<long> pRect, uint color)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Maths.Rectangle<long>* pRectPtr = &pRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, uint, int>)LpVtbl[35])(@this, pSurface, pRectPtr, color);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int ColorFill(ref IDirect3DSurface9 pSurface, Silk.NET.Maths.Rectangle<long>* pRect, uint color)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9* pSurfacePtr = &pSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, uint, int>)LpVtbl[35])(@this, pSurfacePtr, pRect, color);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int ColorFill(ref IDirect3DSurface9 pSurface, ref Silk.NET.Maths.Rectangle<long> pRect, uint color)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9* pSurfacePtr = &pSurface)
            {
                fixed (Silk.NET.Maths.Rectangle<long>* pRectPtr = &pRect)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<long>*, uint, int>)LpVtbl[35])(@this, pSurfacePtr, pRectPtr, color);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateOffscreenPlainSurface(uint Width, uint Height, Format Format, Pool Pool, IDirect3DSurface9** ppSurface, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurface, pSharedHandle);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateOffscreenPlainSurface(uint Width, uint Height, Format Format, Pool Pool, IDirect3DSurface9** ppSurface, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurface, pSharedHandlePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateOffscreenPlainSurface(uint Width, uint Height, Format Format, Pool Pool, ref IDirect3DSurface9* ppSurface, void** pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurfacePtr, pSharedHandle);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateOffscreenPlainSurface(uint Width, uint Height, Format Format, Pool Pool, ref IDirect3DSurface9* ppSurface, ref void* pSharedHandle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
            {
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurfacePtr, pSharedHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetRenderTarget(uint RenderTargetIndex, IDirect3DSurface9* pRenderTarget)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DSurface9*, int>)LpVtbl[37])(@this, RenderTargetIndex, pRenderTarget);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetRenderTarget(uint RenderTargetIndex, ref IDirect3DSurface9 pRenderTarget)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DSurface9*, int>)LpVtbl[37])(@this, RenderTargetIndex, pRenderTargetPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetRenderTarget(uint RenderTargetIndex, IDirect3DSurface9** ppRenderTarget)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DSurface9**, int>)LpVtbl[38])(@this, RenderTargetIndex, ppRenderTarget);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetRenderTarget(uint RenderTargetIndex, ref IDirect3DSurface9* ppRenderTarget)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9** ppRenderTargetPtr = &ppRenderTarget)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DSurface9**, int>)LpVtbl[38])(@this, RenderTargetIndex, ppRenderTargetPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetDepthStencilSurface(IDirect3DSurface9* pNewZStencil)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, int>)LpVtbl[39])(@this, pNewZStencil);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetDepthStencilSurface(ref IDirect3DSurface9 pNewZStencil)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9* pNewZStencilPtr = &pNewZStencil)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9*, int>)LpVtbl[39])(@this, pNewZStencilPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetDepthStencilSurface(IDirect3DSurface9** ppZStencilSurface)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9**, int>)LpVtbl[40])(@this, ppZStencilSurface);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetDepthStencilSurface(ref IDirect3DSurface9* ppZStencilSurface)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DSurface9** ppZStencilSurfacePtr = &ppZStencilSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DSurface9**, int>)LpVtbl[40])(@this, ppZStencilSurfacePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int BeginScene()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, int>)LpVtbl[41])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int EndScene()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, int>)LpVtbl[42])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Clear(uint Count, Rect* pRects, uint Flags, uint Color, float Z, uint Stencil)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Rect*, uint, uint, float, uint, int>)LpVtbl[43])(@this, Count, pRects, Flags, Color, Z, Stencil);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int Clear(uint Count, ref Rect pRects, uint Flags, uint Color, float Z, uint Stencil)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Rect* pRectsPtr = &pRects)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Rect*, uint, uint, float, uint, int>)LpVtbl[43])(@this, Count, pRectsPtr, Flags, Color, Z, Stencil);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetTransform(Transformstatetype State, Matrix* pMatrix)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Transformstatetype, Matrix*, int>)LpVtbl[44])(@this, State, pMatrix);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetTransform(Transformstatetype State, ref Matrix pMatrix)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Matrix* pMatrixPtr = &pMatrix)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Transformstatetype, Matrix*, int>)LpVtbl[44])(@this, State, pMatrixPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetTransform(Transformstatetype State, Matrix* pMatrix)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Transformstatetype, Matrix*, int>)LpVtbl[45])(@this, State, pMatrix);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetTransform(Transformstatetype State, ref Matrix pMatrix)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Matrix* pMatrixPtr = &pMatrix)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Transformstatetype, Matrix*, int>)LpVtbl[45])(@this, State, pMatrixPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int MultiplyTransform(Transformstatetype arg0, Matrix* arg1)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Transformstatetype, Matrix*, int>)LpVtbl[46])(@this, arg0, arg1);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int MultiplyTransform(Transformstatetype arg0, ref Matrix arg1)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Matrix* arg1Ptr = &arg1)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Transformstatetype, Matrix*, int>)LpVtbl[46])(@this, arg0, arg1Ptr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetViewport(Viewport9* pViewport)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Viewport9*, int>)LpVtbl[47])(@this, pViewport);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetViewport(ref Viewport9 pViewport)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Viewport9* pViewportPtr = &pViewport)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Viewport9*, int>)LpVtbl[47])(@this, pViewportPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetViewport(Viewport9* pViewport)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Viewport9*, int>)LpVtbl[48])(@this, pViewport);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetViewport(ref Viewport9 pViewport)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Viewport9* pViewportPtr = &pViewport)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Viewport9*, int>)LpVtbl[48])(@this, pViewportPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetMaterial(Material9* pMaterial)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Material9*, int>)LpVtbl[49])(@this, pMaterial);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetMaterial(ref Material9 pMaterial)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Material9* pMaterialPtr = &pMaterial)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Material9*, int>)LpVtbl[49])(@this, pMaterialPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetMaterial(Material9* pMaterial)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Material9*, int>)LpVtbl[50])(@this, pMaterial);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetMaterial(ref Material9 pMaterial)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Material9* pMaterialPtr = &pMaterial)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Material9*, int>)LpVtbl[50])(@this, pMaterialPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetLight(uint Index, Light9* arg1)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Light9*, int>)LpVtbl[51])(@this, Index, arg1);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetLight(uint Index, ref Light9 arg1)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Light9* arg1Ptr = &arg1)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Light9*, int>)LpVtbl[51])(@this, Index, arg1Ptr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetLight(uint Index, Light9* arg1)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Light9*, int>)LpVtbl[52])(@this, Index, arg1);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetLight(uint Index, ref Light9 arg1)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Light9* arg1Ptr = &arg1)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Light9*, int>)LpVtbl[52])(@this, Index, arg1Ptr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int LightEnable(uint Index, int Enable)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int, int>)LpVtbl[53])(@this, Index, Enable);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetLightEnable(uint Index, int* pEnable)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, int>)LpVtbl[54])(@this, Index, pEnable);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetLightEnable(uint Index, ref int pEnable)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (int* pEnablePtr = &pEnable)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, int>)LpVtbl[54])(@this, Index, pEnablePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetClipPlane(uint Index, float* pPlane)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, int>)LpVtbl[55])(@this, Index, pPlane);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetClipPlane(uint Index, ref float pPlane)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (float* pPlanePtr = &pPlane)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, int>)LpVtbl[55])(@this, Index, pPlanePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetClipPlane(uint Index, float* pPlane)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, int>)LpVtbl[56])(@this, Index, pPlane);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetClipPlane(uint Index, ref float pPlane)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (float* pPlanePtr = &pPlane)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, int>)LpVtbl[56])(@this, Index, pPlanePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetRenderState(Renderstatetype State, uint Value)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Renderstatetype, uint, int>)LpVtbl[57])(@this, State, Value);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetRenderState(Renderstatetype State, uint* pValue)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Renderstatetype, uint*, int>)LpVtbl[58])(@this, State, pValue);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetRenderState(Renderstatetype State, ref uint pValue)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pValuePtr = &pValue)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Renderstatetype, uint*, int>)LpVtbl[58])(@this, State, pValuePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateStateBlock(Stateblocktype Type, IDirect3DStateBlock9** ppSB)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Stateblocktype, IDirect3DStateBlock9**, int>)LpVtbl[59])(@this, Type, ppSB);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateStateBlock(Stateblocktype Type, ref IDirect3DStateBlock9* ppSB)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DStateBlock9** ppSBPtr = &ppSB)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Stateblocktype, IDirect3DStateBlock9**, int>)LpVtbl[59])(@this, Type, ppSBPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int BeginStateBlock()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, int>)LpVtbl[60])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int EndStateBlock(IDirect3DStateBlock9** ppSB)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DStateBlock9**, int>)LpVtbl[61])(@this, ppSB);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int EndStateBlock(ref IDirect3DStateBlock9* ppSB)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DStateBlock9** ppSBPtr = &ppSB)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DStateBlock9**, int>)LpVtbl[61])(@this, ppSBPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetClipStatus(Clipstatus9* pClipStatus)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Clipstatus9*, int>)LpVtbl[62])(@this, pClipStatus);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetClipStatus(ref Clipstatus9 pClipStatus)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Clipstatus9* pClipStatusPtr = &pClipStatus)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Clipstatus9*, int>)LpVtbl[62])(@this, pClipStatusPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetClipStatus(Clipstatus9* pClipStatus)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Clipstatus9*, int>)LpVtbl[63])(@this, pClipStatus);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetClipStatus(ref Clipstatus9 pClipStatus)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Clipstatus9* pClipStatusPtr = &pClipStatus)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Clipstatus9*, int>)LpVtbl[63])(@this, pClipStatusPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetTexture(uint Stage, IDirect3DBaseTexture9** ppTexture)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DBaseTexture9**, int>)LpVtbl[64])(@this, Stage, ppTexture);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetTexture(uint Stage, ref IDirect3DBaseTexture9* ppTexture)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DBaseTexture9** ppTexturePtr = &ppTexture)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DBaseTexture9**, int>)LpVtbl[64])(@this, Stage, ppTexturePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetTexture(uint Stage, IDirect3DBaseTexture9* pTexture)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DBaseTexture9*, int>)LpVtbl[65])(@this, Stage, pTexture);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetTexture(uint Stage, ref IDirect3DBaseTexture9 pTexture)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DBaseTexture9* pTexturePtr = &pTexture)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DBaseTexture9*, int>)LpVtbl[65])(@this, Stage, pTexturePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetTextureStageState(uint Stage, Texturestagestatetype Type, uint* pValue)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Texturestagestatetype, uint*, int>)LpVtbl[66])(@this, Stage, Type, pValue);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetTextureStageState(uint Stage, Texturestagestatetype Type, ref uint pValue)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pValuePtr = &pValue)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Texturestagestatetype, uint*, int>)LpVtbl[66])(@this, Stage, Type, pValuePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetTextureStageState(uint Stage, Texturestagestatetype Type, uint Value)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Texturestagestatetype, uint, int>)LpVtbl[67])(@this, Stage, Type, Value);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetSamplerState(uint Sampler, Samplerstatetype Type, uint* pValue)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Samplerstatetype, uint*, int>)LpVtbl[68])(@this, Sampler, Type, pValue);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetSamplerState(uint Sampler, Samplerstatetype Type, ref uint pValue)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pValuePtr = &pValue)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Samplerstatetype, uint*, int>)LpVtbl[68])(@this, Sampler, Type, pValuePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetSamplerState(uint Sampler, Samplerstatetype Type, uint Value)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Samplerstatetype, uint, int>)LpVtbl[69])(@this, Sampler, Type, Value);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int ValidateDevice(uint* pNumPasses)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, int>)LpVtbl[70])(@this, pNumPasses);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int ValidateDevice(ref uint pNumPasses)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pNumPassesPtr = &pNumPasses)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, int>)LpVtbl[70])(@this, pNumPassesPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPaletteEntries(uint PaletteNumber, Silk.NET.Maths.Vector4D<byte>* pEntries)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Silk.NET.Maths.Vector4D<byte>*, int>)LpVtbl[71])(@this, PaletteNumber, pEntries);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetPaletteEntries(uint PaletteNumber, ref Silk.NET.Maths.Vector4D<byte> pEntries)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Maths.Vector4D<byte>* pEntriesPtr = &pEntries)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Silk.NET.Maths.Vector4D<byte>*, int>)LpVtbl[71])(@this, PaletteNumber, pEntriesPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPaletteEntries(uint PaletteNumber, Silk.NET.Maths.Vector4D<byte>* pEntries)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Silk.NET.Maths.Vector4D<byte>*, int>)LpVtbl[72])(@this, PaletteNumber, pEntries);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetPaletteEntries(uint PaletteNumber, ref Silk.NET.Maths.Vector4D<byte> pEntries)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Maths.Vector4D<byte>* pEntriesPtr = &pEntries)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, Silk.NET.Maths.Vector4D<byte>*, int>)LpVtbl[72])(@this, PaletteNumber, pEntriesPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetCurrentTexturePalette(uint PaletteNumber)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int>)LpVtbl[73])(@this, PaletteNumber);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetCurrentTexturePalette(uint* PaletteNumber)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, int>)LpVtbl[74])(@this, PaletteNumber);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetCurrentTexturePalette(ref uint PaletteNumber)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* PaletteNumberPtr = &PaletteNumber)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, int>)LpVtbl[74])(@this, PaletteNumberPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetScissorRect(Silk.NET.Maths.Rectangle<long>* pRect)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<long>*, int>)LpVtbl[75])(@this, pRect);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetScissorRect(ref Silk.NET.Maths.Rectangle<long> pRect)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Maths.Rectangle<long>* pRectPtr = &pRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<long>*, int>)LpVtbl[75])(@this, pRectPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetScissorRect(Silk.NET.Maths.Rectangle<long>* pRect)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<long>*, int>)LpVtbl[76])(@this, pRect);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetScissorRect(ref Silk.NET.Maths.Rectangle<long> pRect)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Maths.Rectangle<long>* pRectPtr = &pRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Silk.NET.Maths.Rectangle<long>*, int>)LpVtbl[76])(@this, pRectPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetSoftwareVertexProcessing(int bSoftware)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, int, int>)LpVtbl[77])(@this, bSoftware);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetSoftwareVertexProcessing()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, int>)LpVtbl[78])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetNPatchMode(float nSegments)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, float, int>)LpVtbl[79])(@this, nSegments);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly float GetNPatchMode()
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                float ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, float>)LpVtbl[80])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int DrawPrimitive(Primitivetype PrimitiveType, uint StartVertex, uint PrimitiveCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Primitivetype, uint, uint, int>)LpVtbl[81])(@this, PrimitiveType, StartVertex, PrimitiveCount);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int DrawIndexedPrimitive(Primitivetype arg0, int BaseVertexIndex, uint MinVertexIndex, uint NumVertices, uint startIndex, uint primCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Primitivetype, int, uint, uint, uint, uint, int>)LpVtbl[82])(@this, arg0, BaseVertexIndex, MinVertexIndex, NumVertices, startIndex, primCount);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int DrawPrimitiveUP(Primitivetype PrimitiveType, uint PrimitiveCount, void* pVertexStreamZeroData, uint VertexStreamZeroStride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Primitivetype, uint, void*, uint, int>)LpVtbl[83])(@this, PrimitiveType, PrimitiveCount, pVertexStreamZeroData, VertexStreamZeroStride);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int DrawPrimitiveUP<T0>(Primitivetype PrimitiveType, uint PrimitiveCount, ref T0 pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pVertexStreamZeroDataPtr = &pVertexStreamZeroData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Primitivetype, uint, T0*, uint, int>)LpVtbl[83])(@this, PrimitiveType, PrimitiveCount, pVertexStreamZeroDataPtr, VertexStreamZeroStride);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int DrawIndexedPrimitiveUP(Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, void* pIndexData, Format IndexDataFormat, void* pVertexStreamZeroData, uint VertexStreamZeroStride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Primitivetype, uint, uint, uint, void*, Format, void*, uint, int>)LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexData, IndexDataFormat, pVertexStreamZeroData, VertexStreamZeroStride);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int DrawIndexedPrimitiveUP<T0>(Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, void* pIndexData, Format IndexDataFormat, ref T0 pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pVertexStreamZeroDataPtr = &pVertexStreamZeroData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Primitivetype, uint, uint, uint, void*, Format, T0*, uint, int>)LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexData, IndexDataFormat, pVertexStreamZeroDataPtr, VertexStreamZeroStride);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int DrawIndexedPrimitiveUP<T0>(Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, ref T0 pIndexData, Format IndexDataFormat, void* pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pIndexDataPtr = &pIndexData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Primitivetype, uint, uint, uint, T0*, Format, void*, uint, int>)LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexDataPtr, IndexDataFormat, pVertexStreamZeroData, VertexStreamZeroStride);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int DrawIndexedPrimitiveUP<T0, T1>(Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, ref T0 pIndexData, Format IndexDataFormat, ref T1 pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pIndexDataPtr = &pIndexData)
            {
                fixed (T1* pVertexStreamZeroDataPtr = &pVertexStreamZeroData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Primitivetype, uint, uint, uint, T0*, Format, T1*, uint, int>)LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexDataPtr, IndexDataFormat, pVertexStreamZeroDataPtr, VertexStreamZeroStride);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int ProcessVertices(uint SrcStartIndex, uint DestIndex, uint VertexCount, IDirect3DVertexBuffer9* pDestBuffer, IDirect3DVertexDeclaration9* pVertexDecl, uint Flags)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBuffer, pVertexDecl, Flags);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int ProcessVertices(uint SrcStartIndex, uint DestIndex, uint VertexCount, IDirect3DVertexBuffer9* pDestBuffer, ref IDirect3DVertexDeclaration9 pVertexDecl, uint Flags)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DVertexDeclaration9* pVertexDeclPtr = &pVertexDecl)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBuffer, pVertexDeclPtr, Flags);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int ProcessVertices(uint SrcStartIndex, uint DestIndex, uint VertexCount, ref IDirect3DVertexBuffer9 pDestBuffer, IDirect3DVertexDeclaration9* pVertexDecl, uint Flags)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DVertexBuffer9* pDestBufferPtr = &pDestBuffer)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBufferPtr, pVertexDecl, Flags);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int ProcessVertices(uint SrcStartIndex, uint DestIndex, uint VertexCount, ref IDirect3DVertexBuffer9 pDestBuffer, ref IDirect3DVertexDeclaration9 pVertexDecl, uint Flags)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DVertexBuffer9* pDestBufferPtr = &pDestBuffer)
            {
                fixed (IDirect3DVertexDeclaration9* pVertexDeclPtr = &pVertexDecl)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBufferPtr, pVertexDeclPtr, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateVertexDeclaration(Vertexelement9* pVertexElements, IDirect3DVertexDeclaration9** ppDecl)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)LpVtbl[86])(@this, pVertexElements, ppDecl);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateVertexDeclaration(Vertexelement9* pVertexElements, ref IDirect3DVertexDeclaration9* ppDecl)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DVertexDeclaration9** ppDeclPtr = &ppDecl)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)LpVtbl[86])(@this, pVertexElements, ppDeclPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateVertexDeclaration(ref Vertexelement9 pVertexElements, IDirect3DVertexDeclaration9** ppDecl)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Vertexelement9* pVertexElementsPtr = &pVertexElements)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)LpVtbl[86])(@this, pVertexElementsPtr, ppDecl);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateVertexDeclaration(ref Vertexelement9 pVertexElements, ref IDirect3DVertexDeclaration9* ppDecl)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Vertexelement9* pVertexElementsPtr = &pVertexElements)
            {
                fixed (IDirect3DVertexDeclaration9** ppDeclPtr = &ppDecl)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)LpVtbl[86])(@this, pVertexElementsPtr, ppDeclPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetVertexDeclaration(IDirect3DVertexDeclaration9* pDecl)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DVertexDeclaration9*, int>)LpVtbl[87])(@this, pDecl);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetVertexDeclaration(ref IDirect3DVertexDeclaration9 pDecl)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DVertexDeclaration9* pDeclPtr = &pDecl)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DVertexDeclaration9*, int>)LpVtbl[87])(@this, pDeclPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetVertexDeclaration(IDirect3DVertexDeclaration9** ppDecl)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DVertexDeclaration9**, int>)LpVtbl[88])(@this, ppDecl);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetVertexDeclaration(ref IDirect3DVertexDeclaration9* ppDecl)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DVertexDeclaration9** ppDeclPtr = &ppDecl)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DVertexDeclaration9**, int>)LpVtbl[88])(@this, ppDeclPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetFVF(uint FVF)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int>)LpVtbl[89])(@this, FVF);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetFVF(uint* pFVF)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, int>)LpVtbl[90])(@this, pFVF);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetFVF(ref uint pFVF)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pFVFPtr = &pFVF)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, int>)LpVtbl[90])(@this, pFVFPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateVertexShader(uint* pFunction, IDirect3DVertexShader9** ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, IDirect3DVertexShader9**, int>)LpVtbl[91])(@this, pFunction, ppShader);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateVertexShader(uint* pFunction, ref IDirect3DVertexShader9* ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DVertexShader9** ppShaderPtr = &ppShader)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, IDirect3DVertexShader9**, int>)LpVtbl[91])(@this, pFunction, ppShaderPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateVertexShader(ref uint pFunction, IDirect3DVertexShader9** ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pFunctionPtr = &pFunction)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, IDirect3DVertexShader9**, int>)LpVtbl[91])(@this, pFunctionPtr, ppShader);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateVertexShader(ref uint pFunction, ref IDirect3DVertexShader9* ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pFunctionPtr = &pFunction)
            {
                fixed (IDirect3DVertexShader9** ppShaderPtr = &ppShader)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, IDirect3DVertexShader9**, int>)LpVtbl[91])(@this, pFunctionPtr, ppShaderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetVertexShader(IDirect3DVertexShader9* pShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DVertexShader9*, int>)LpVtbl[92])(@this, pShader);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetVertexShader(ref IDirect3DVertexShader9 pShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DVertexShader9* pShaderPtr = &pShader)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DVertexShader9*, int>)LpVtbl[92])(@this, pShaderPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetVertexShader(IDirect3DVertexShader9** ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DVertexShader9**, int>)LpVtbl[93])(@this, ppShader);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetVertexShader(ref IDirect3DVertexShader9* ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DVertexShader9** ppShaderPtr = &ppShader)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DVertexShader9**, int>)LpVtbl[93])(@this, ppShaderPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetVertexShaderConstantF(uint StartRegister, float* pConstantData, uint Vector4fCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[94])(@this, StartRegister, pConstantData, Vector4fCount);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetVertexShaderConstantF(uint StartRegister, ref float pConstantData, uint Vector4fCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (float* pConstantDataPtr = &pConstantData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[94])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetVertexShaderConstantF(uint StartRegister, float* pConstantData, uint Vector4fCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[95])(@this, StartRegister, pConstantData, Vector4fCount);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetVertexShaderConstantF(uint StartRegister, ref float pConstantData, uint Vector4fCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (float* pConstantDataPtr = &pConstantData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[95])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetVertexShaderConstantI(uint StartRegister, int* pConstantData, uint Vector4iCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[96])(@this, StartRegister, pConstantData, Vector4iCount);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetVertexShaderConstantI(uint StartRegister, ref int pConstantData, uint Vector4iCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (int* pConstantDataPtr = &pConstantData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[96])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetVertexShaderConstantI(uint StartRegister, int* pConstantData, uint Vector4iCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[97])(@this, StartRegister, pConstantData, Vector4iCount);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetVertexShaderConstantI(uint StartRegister, ref int pConstantData, uint Vector4iCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (int* pConstantDataPtr = &pConstantData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[97])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetVertexShaderConstantB(uint StartRegister, int* pConstantData, uint BoolCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[98])(@this, StartRegister, pConstantData, BoolCount);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetVertexShaderConstantB(uint StartRegister, ref int pConstantData, uint BoolCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (int* pConstantDataPtr = &pConstantData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[98])(@this, StartRegister, pConstantDataPtr, BoolCount);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetVertexShaderConstantB(uint StartRegister, int* pConstantData, uint BoolCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[99])(@this, StartRegister, pConstantData, BoolCount);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetVertexShaderConstantB(uint StartRegister, ref int pConstantData, uint BoolCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (int* pConstantDataPtr = &pConstantData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[99])(@this, StartRegister, pConstantDataPtr, BoolCount);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9* pStreamData, uint OffsetInBytes, uint Stride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9*, uint, uint, int>)LpVtbl[100])(@this, StreamNumber, pStreamData, OffsetInBytes, Stride);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetStreamSource(uint StreamNumber, ref IDirect3DVertexBuffer9 pStreamData, uint OffsetInBytes, uint Stride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DVertexBuffer9* pStreamDataPtr = &pStreamData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9*, uint, uint, int>)LpVtbl[100])(@this, StreamNumber, pStreamDataPtr, OffsetInBytes, Stride);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, uint* OffsetInBytes, uint* pStride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamData, OffsetInBytes, pStride);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, uint* OffsetInBytes, ref uint pStride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pStridePtr = &pStride)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamData, OffsetInBytes, pStridePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, ref uint OffsetInBytes, uint* pStride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* OffsetInBytesPtr = &OffsetInBytes)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamData, OffsetInBytesPtr, pStride);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, ref uint OffsetInBytes, ref uint pStride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* OffsetInBytesPtr = &OffsetInBytes)
            {
                fixed (uint* pStridePtr = &pStride)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamData, OffsetInBytesPtr, pStridePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetStreamSource(uint StreamNumber, ref IDirect3DVertexBuffer9* ppStreamData, uint* OffsetInBytes, uint* pStride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DVertexBuffer9** ppStreamDataPtr = &ppStreamData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamDataPtr, OffsetInBytes, pStride);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetStreamSource(uint StreamNumber, ref IDirect3DVertexBuffer9* ppStreamData, uint* OffsetInBytes, ref uint pStride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DVertexBuffer9** ppStreamDataPtr = &ppStreamData)
            {
                fixed (uint* pStridePtr = &pStride)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamDataPtr, OffsetInBytes, pStridePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetStreamSource(uint StreamNumber, ref IDirect3DVertexBuffer9* ppStreamData, ref uint OffsetInBytes, uint* pStride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DVertexBuffer9** ppStreamDataPtr = &ppStreamData)
            {
                fixed (uint* OffsetInBytesPtr = &OffsetInBytes)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamDataPtr, OffsetInBytesPtr, pStride);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetStreamSource(uint StreamNumber, ref IDirect3DVertexBuffer9* ppStreamData, ref uint OffsetInBytes, ref uint pStride)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DVertexBuffer9** ppStreamDataPtr = &ppStreamData)
            {
                fixed (uint* OffsetInBytesPtr = &OffsetInBytes)
                {
                    fixed (uint* pStridePtr = &pStride)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamDataPtr, OffsetInBytesPtr, pStridePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetStreamSourceFreq(uint StreamNumber, uint Divider)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint, int>)LpVtbl[102])(@this, StreamNumber, Divider);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetStreamSourceFreq(uint StreamNumber, uint* Divider)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint*, int>)LpVtbl[103])(@this, StreamNumber, Divider);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetStreamSourceFreq(uint StreamNumber, ref uint Divider)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* DividerPtr = &Divider)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, uint*, int>)LpVtbl[103])(@this, StreamNumber, DividerPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetIndices(IDirect3DIndexBuffer9* pIndexData)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DIndexBuffer9*, int>)LpVtbl[104])(@this, pIndexData);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetIndices(ref IDirect3DIndexBuffer9 pIndexData)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DIndexBuffer9* pIndexDataPtr = &pIndexData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DIndexBuffer9*, int>)LpVtbl[104])(@this, pIndexDataPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetIndices(IDirect3DIndexBuffer9** ppIndexData)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DIndexBuffer9**, int>)LpVtbl[105])(@this, ppIndexData);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetIndices(ref IDirect3DIndexBuffer9* ppIndexData)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DIndexBuffer9** ppIndexDataPtr = &ppIndexData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DIndexBuffer9**, int>)LpVtbl[105])(@this, ppIndexDataPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePixelShader(uint* pFunction, IDirect3DPixelShader9** ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, IDirect3DPixelShader9**, int>)LpVtbl[106])(@this, pFunction, ppShader);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePixelShader(uint* pFunction, ref IDirect3DPixelShader9* ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DPixelShader9** ppShaderPtr = &ppShader)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, IDirect3DPixelShader9**, int>)LpVtbl[106])(@this, pFunction, ppShaderPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePixelShader(ref uint pFunction, IDirect3DPixelShader9** ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pFunctionPtr = &pFunction)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, IDirect3DPixelShader9**, int>)LpVtbl[106])(@this, pFunctionPtr, ppShader);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreatePixelShader(ref uint pFunction, ref IDirect3DPixelShader9* ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pFunctionPtr = &pFunction)
            {
                fixed (IDirect3DPixelShader9** ppShaderPtr = &ppShader)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint*, IDirect3DPixelShader9**, int>)LpVtbl[106])(@this, pFunctionPtr, ppShaderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPixelShader(IDirect3DPixelShader9* pShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DPixelShader9*, int>)LpVtbl[107])(@this, pShader);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetPixelShader(ref IDirect3DPixelShader9 pShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DPixelShader9* pShaderPtr = &pShader)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DPixelShader9*, int>)LpVtbl[107])(@this, pShaderPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPixelShader(IDirect3DPixelShader9** ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DPixelShader9**, int>)LpVtbl[108])(@this, ppShader);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPixelShader(ref IDirect3DPixelShader9* ppShader)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DPixelShader9** ppShaderPtr = &ppShader)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, IDirect3DPixelShader9**, int>)LpVtbl[108])(@this, ppShaderPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPixelShaderConstantF(uint StartRegister, float* pConstantData, uint Vector4fCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[109])(@this, StartRegister, pConstantData, Vector4fCount);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetPixelShaderConstantF(uint StartRegister, ref float pConstantData, uint Vector4fCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (float* pConstantDataPtr = &pConstantData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[109])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPixelShaderConstantF(uint StartRegister, float* pConstantData, uint Vector4fCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[110])(@this, StartRegister, pConstantData, Vector4fCount);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetPixelShaderConstantF(uint StartRegister, ref float pConstantData, uint Vector4fCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (float* pConstantDataPtr = &pConstantData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[110])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPixelShaderConstantI(uint StartRegister, int* pConstantData, uint Vector4iCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[111])(@this, StartRegister, pConstantData, Vector4iCount);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetPixelShaderConstantI(uint StartRegister, ref int pConstantData, uint Vector4iCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (int* pConstantDataPtr = &pConstantData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[111])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPixelShaderConstantI(uint StartRegister, int* pConstantData, uint Vector4iCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[112])(@this, StartRegister, pConstantData, Vector4iCount);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetPixelShaderConstantI(uint StartRegister, ref int pConstantData, uint Vector4iCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (int* pConstantDataPtr = &pConstantData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[112])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPixelShaderConstantB(uint StartRegister, int* pConstantData, uint BoolCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[113])(@this, StartRegister, pConstantData, BoolCount);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetPixelShaderConstantB(uint StartRegister, ref int pConstantData, uint BoolCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (int* pConstantDataPtr = &pConstantData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[113])(@this, StartRegister, pConstantDataPtr, BoolCount);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPixelShaderConstantB(uint StartRegister, int* pConstantData, uint BoolCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[114])(@this, StartRegister, pConstantData, BoolCount);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetPixelShaderConstantB(uint StartRegister, ref int pConstantData, uint BoolCount)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (int* pConstantDataPtr = &pConstantData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[114])(@this, StartRegister, pConstantDataPtr, BoolCount);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int DrawRectPatch(uint Handle, float* pNumSegs, RectpatchInfo* pRectPatchInfo)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, RectpatchInfo*, int>)LpVtbl[115])(@this, Handle, pNumSegs, pRectPatchInfo);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int DrawRectPatch(uint Handle, float* pNumSegs, ref RectpatchInfo pRectPatchInfo)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (RectpatchInfo* pRectPatchInfoPtr = &pRectPatchInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, RectpatchInfo*, int>)LpVtbl[115])(@this, Handle, pNumSegs, pRectPatchInfoPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int DrawRectPatch(uint Handle, ref float pNumSegs, RectpatchInfo* pRectPatchInfo)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (float* pNumSegsPtr = &pNumSegs)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, RectpatchInfo*, int>)LpVtbl[115])(@this, Handle, pNumSegsPtr, pRectPatchInfo);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int DrawRectPatch(uint Handle, ref float pNumSegs, ref RectpatchInfo pRectPatchInfo)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (float* pNumSegsPtr = &pNumSegs)
            {
                fixed (RectpatchInfo* pRectPatchInfoPtr = &pRectPatchInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, RectpatchInfo*, int>)LpVtbl[115])(@this, Handle, pNumSegsPtr, pRectPatchInfoPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int DrawTriPatch(uint Handle, float* pNumSegs, TripatchInfo* pTriPatchInfo)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, TripatchInfo*, int>)LpVtbl[116])(@this, Handle, pNumSegs, pTriPatchInfo);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int DrawTriPatch(uint Handle, float* pNumSegs, ref TripatchInfo pTriPatchInfo)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (TripatchInfo* pTriPatchInfoPtr = &pTriPatchInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, TripatchInfo*, int>)LpVtbl[116])(@this, Handle, pNumSegs, pTriPatchInfoPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int DrawTriPatch(uint Handle, ref float pNumSegs, TripatchInfo* pTriPatchInfo)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (float* pNumSegsPtr = &pNumSegs)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, TripatchInfo*, int>)LpVtbl[116])(@this, Handle, pNumSegsPtr, pTriPatchInfo);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int DrawTriPatch(uint Handle, ref float pNumSegs, ref TripatchInfo pTriPatchInfo)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (float* pNumSegsPtr = &pNumSegs)
            {
                fixed (TripatchInfo* pTriPatchInfoPtr = &pTriPatchInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, float*, TripatchInfo*, int>)LpVtbl[116])(@this, Handle, pNumSegsPtr, pTriPatchInfoPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int DeletePatch(uint Handle)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, uint, int>)LpVtbl[117])(@this, Handle);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateQuery(Querytype Type, IDirect3DQuery9** ppQuery)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Querytype, IDirect3DQuery9**, int>)LpVtbl[118])(@this, Type, ppQuery);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateQuery(Querytype Type, ref IDirect3DQuery9* ppQuery)
        {
            var @this = (IDirect3DDevice9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DQuery9** ppQueryPtr = &ppQuery)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9*, Querytype, IDirect3DQuery9**, int>)LpVtbl[118])(@this, Type, ppQueryPtr);
            }
            return ret;
        }

    }
}
