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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "IDirect3DDevice9")]
    public unsafe partial struct IDirect3DDevice9
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3DDevice9 val)
            => Unsafe.As<IDirect3DDevice9, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public IDirect3DDevice9
        (
            DeviceCreationParameters creationParameters = default,
            PresentParameters presentParameters = default,
            Displaymode displayMode = default,
            Caps9 caps = default,
            uint availableTextureMem = default,
            uint swapChains = default,
            uint textures = default,
            uint vertexBuffers = default,
            uint indexBuffers = default,
            uint vertexShaders = default,
            uint pixelShaders = default,
            Viewport9 viewport = default,
            Matrix projectionMatrix = default,
            Matrix viewMatrix = default,
            Matrix worldMatrix = default,
            uint fVF = default,
            uint vertexSize = default,
            uint vertexShaderVersion = default,
            uint pixelShaderVersion = default,
            int softwareVertexProcessing = default,
            Material9 material = default,
            Gammaramp gammaRamp = default,
            Silk.NET.Core.Native.TagRect scissorRect = default,
            int dialogBoxMode = default,
            void** lpVtbl = default
        )
        {
            CreationParameters = creationParameters;
            PresentParameters = presentParameters;
            DisplayMode = displayMode;
            Caps = caps;
            AvailableTextureMem = availableTextureMem;
            SwapChains = swapChains;
            Textures = textures;
            VertexBuffers = vertexBuffers;
            IndexBuffers = indexBuffers;
            VertexShaders = vertexShaders;
            PixelShaders = pixelShaders;
            Viewport = viewport;
            ProjectionMatrix = projectionMatrix;
            ViewMatrix = viewMatrix;
            WorldMatrix = worldMatrix;
           TextureMatrices_0 = default;
           TextureMatrices_1 = default;
           TextureMatrices_2 = default;
           TextureMatrices_3 = default;
           TextureMatrices_4 = default;
           TextureMatrices_5 = default;
           TextureMatrices_6 = default;
           TextureMatrices_7 = default;
            FVF = fVF;
            VertexSize = vertexSize;
            VertexShaderVersion = vertexShaderVersion;
            PixelShaderVersion = pixelShaderVersion;
            SoftwareVertexProcessing = softwareVertexProcessing;
            Material = material;
           Lights_0 = default;
           Lights_1 = default;
           Lights_2 = default;
           Lights_3 = default;
           Lights_4 = default;
           Lights_5 = default;
           Lights_6 = default;
           Lights_7 = default;
           Lights_8 = default;
           Lights_9 = default;
           Lights_10 = default;
           Lights_11 = default;
           Lights_12 = default;
           Lights_13 = default;
           Lights_14 = default;
           Lights_15 = default;
            GammaRamp = gammaRamp;
            ScissorRect = scissorRect;
            DialogBoxMode = dialogBoxMode;
            LpVtbl = lpVtbl;
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
        public Matrix TextureMatrices_0;
        
        [NativeName("Type", "D3DMATRIX [8]")]
        [NativeName("Type.Name", "D3DMATRIX [8]")]
        [NativeName("Name", "TextureMatrices")]
        public Matrix TextureMatrices_1;
        
        [NativeName("Type", "D3DMATRIX [8]")]
        [NativeName("Type.Name", "D3DMATRIX [8]")]
        [NativeName("Name", "TextureMatrices")]
        public Matrix TextureMatrices_2;
        
        [NativeName("Type", "D3DMATRIX [8]")]
        [NativeName("Type.Name", "D3DMATRIX [8]")]
        [NativeName("Name", "TextureMatrices")]
        public Matrix TextureMatrices_3;
        
        [NativeName("Type", "D3DMATRIX [8]")]
        [NativeName("Type.Name", "D3DMATRIX [8]")]
        [NativeName("Name", "TextureMatrices")]
        public Matrix TextureMatrices_4;
        
        [NativeName("Type", "D3DMATRIX [8]")]
        [NativeName("Type.Name", "D3DMATRIX [8]")]
        [NativeName("Name", "TextureMatrices")]
        public Matrix TextureMatrices_5;
        
        [NativeName("Type", "D3DMATRIX [8]")]
        [NativeName("Type.Name", "D3DMATRIX [8]")]
        [NativeName("Name", "TextureMatrices")]
        public Matrix TextureMatrices_6;
        
        [NativeName("Type", "D3DMATRIX [8]")]
        [NativeName("Type.Name", "D3DMATRIX [8]")]
        [NativeName("Name", "TextureMatrices")]
        public Matrix TextureMatrices_7;

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
        public Light9 Lights_0;
        
        [NativeName("Type", "D3DLIGHT9 [16]")]
        [NativeName("Type.Name", "D3DLIGHT9 [16]")]
        [NativeName("Name", "Lights")]
        public Light9 Lights_1;
        
        [NativeName("Type", "D3DLIGHT9 [16]")]
        [NativeName("Type.Name", "D3DLIGHT9 [16]")]
        [NativeName("Name", "Lights")]
        public Light9 Lights_2;
        
        [NativeName("Type", "D3DLIGHT9 [16]")]
        [NativeName("Type.Name", "D3DLIGHT9 [16]")]
        [NativeName("Name", "Lights")]
        public Light9 Lights_3;
        
        [NativeName("Type", "D3DLIGHT9 [16]")]
        [NativeName("Type.Name", "D3DLIGHT9 [16]")]
        [NativeName("Name", "Lights")]
        public Light9 Lights_4;
        
        [NativeName("Type", "D3DLIGHT9 [16]")]
        [NativeName("Type.Name", "D3DLIGHT9 [16]")]
        [NativeName("Name", "Lights")]
        public Light9 Lights_5;
        
        [NativeName("Type", "D3DLIGHT9 [16]")]
        [NativeName("Type.Name", "D3DLIGHT9 [16]")]
        [NativeName("Name", "Lights")]
        public Light9 Lights_6;
        
        [NativeName("Type", "D3DLIGHT9 [16]")]
        [NativeName("Type.Name", "D3DLIGHT9 [16]")]
        [NativeName("Name", "Lights")]
        public Light9 Lights_7;
        
        [NativeName("Type", "D3DLIGHT9 [16]")]
        [NativeName("Type.Name", "D3DLIGHT9 [16]")]
        [NativeName("Name", "Lights")]
        public Light9 Lights_8;
        
        [NativeName("Type", "D3DLIGHT9 [16]")]
        [NativeName("Type.Name", "D3DLIGHT9 [16]")]
        [NativeName("Name", "Lights")]
        public Light9 Lights_9;
        
        [NativeName("Type", "D3DLIGHT9 [16]")]
        [NativeName("Type.Name", "D3DLIGHT9 [16]")]
        [NativeName("Name", "Lights")]
        public Light9 Lights_10;
        
        [NativeName("Type", "D3DLIGHT9 [16]")]
        [NativeName("Type.Name", "D3DLIGHT9 [16]")]
        [NativeName("Name", "Lights")]
        public Light9 Lights_11;
        
        [NativeName("Type", "D3DLIGHT9 [16]")]
        [NativeName("Type.Name", "D3DLIGHT9 [16]")]
        [NativeName("Name", "Lights")]
        public Light9 Lights_12;
        
        [NativeName("Type", "D3DLIGHT9 [16]")]
        [NativeName("Type.Name", "D3DLIGHT9 [16]")]
        [NativeName("Name", "Lights")]
        public Light9 Lights_13;
        
        [NativeName("Type", "D3DLIGHT9 [16]")]
        [NativeName("Type.Name", "D3DLIGHT9 [16]")]
        [NativeName("Name", "Lights")]
        public Light9 Lights_14;
        
        [NativeName("Type", "D3DLIGHT9 [16]")]
        [NativeName("Type.Name", "D3DLIGHT9 [16]")]
        [NativeName("Name", "Lights")]
        public Light9 Lights_15;
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
        public Silk.NET.Core.Native.TagRect ScissorRect;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DialogBoxMode")]
        public int DialogBoxMode;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int TestCooperativeLevel()
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, int>)LpVtbl[3])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetAvailableTextureMem()
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint>)LpVtbl[4])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int EvictManagedResources()
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, int>)LpVtbl[5])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDirect3D(IDirect3D9** ppD3D9)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3D9**, int>)LpVtbl[6])(@this, ppD3D9);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDirect3D(ref IDirect3D9* ppD3D9)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3D9** ppD3D9Ptr = &ppD3D9)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3D9**, int>)LpVtbl[6])(@this, ppD3D9Ptr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDeviceCaps(Caps9* pCaps)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, Caps9*, int>)LpVtbl[7])(@this, pCaps);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDeviceCaps(ref Caps9 pCaps)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Caps9* pCapsPtr = &pCaps)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, Caps9*, int>)LpVtbl[7])(@this, pCapsPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDisplayMode(uint iSwapChain, Displaymode* pMode)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, Displaymode*, int>)LpVtbl[8])(@this, iSwapChain, pMode);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDisplayMode(uint iSwapChain, ref Displaymode pMode)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Displaymode* pModePtr = &pMode)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, Displaymode*, int>)LpVtbl[8])(@this, iSwapChain, pModePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCreationParameters(DeviceCreationParameters* pParameters)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, DeviceCreationParameters*, int>)LpVtbl[9])(@this, pParameters);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetCreationParameters(ref DeviceCreationParameters pParameters)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (DeviceCreationParameters* pParametersPtr = &pParameters)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, DeviceCreationParameters*, int>)LpVtbl[9])(@this, pParametersPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetCursorProperties(uint XHotSpot, uint YHotSpot, IDirect3DSurface9* pCursorBitmap)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, IDirect3DSurface9*, int>)LpVtbl[10])(@this, XHotSpot, YHotSpot, pCursorBitmap);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetCursorProperties(uint XHotSpot, uint YHotSpot, ref IDirect3DSurface9 pCursorBitmap)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9* pCursorBitmapPtr = &pCursorBitmap)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, IDirect3DSurface9*, int>)LpVtbl[10])(@this, XHotSpot, YHotSpot, pCursorBitmapPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public void SetCursorPosition(int X, int Y, uint Flags)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                ((delegate* cdecl<IDirect3DDevice9*, int, int, uint, void>)LpVtbl[11])(@this, X, Y, Flags);
            }
        }

        /// <summary>To be added.</summary>
        public int ShowCursor(int bShow)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, int, int>)LpVtbl[12])(@this, bShow);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateAdditionalSwapChain(PresentParameters* pPresentationParameters, IDirect3DSwapChain9** pSwapChain)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, PresentParameters*, IDirect3DSwapChain9**, int>)LpVtbl[13])(@this, pPresentationParameters, pSwapChain);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateAdditionalSwapChain(PresentParameters* pPresentationParameters, ref IDirect3DSwapChain9* pSwapChain)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSwapChain9** pSwapChainPtr = &pSwapChain)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, PresentParameters*, IDirect3DSwapChain9**, int>)LpVtbl[13])(@this, pPresentationParameters, pSwapChainPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateAdditionalSwapChain(ref PresentParameters pPresentationParameters, IDirect3DSwapChain9** pSwapChain)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, PresentParameters*, IDirect3DSwapChain9**, int>)LpVtbl[13])(@this, pPresentationParametersPtr, pSwapChain);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateAdditionalSwapChain(ref PresentParameters pPresentationParameters, ref IDirect3DSwapChain9* pSwapChain)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
                {
                    fixed (IDirect3DSwapChain9** pSwapChainPtr = &pSwapChain)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, PresentParameters*, IDirect3DSwapChain9**, int>)LpVtbl[13])(@this, pPresentationParametersPtr, pSwapChainPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetSwapChain(uint iSwapChain, IDirect3DSwapChain9** pSwapChain)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, IDirect3DSwapChain9**, int>)LpVtbl[14])(@this, iSwapChain, pSwapChain);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetSwapChain(uint iSwapChain, ref IDirect3DSwapChain9* pSwapChain)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSwapChain9** pSwapChainPtr = &pSwapChain)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, IDirect3DSwapChain9**, int>)LpVtbl[14])(@this, iSwapChain, pSwapChainPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetNumberOfSwapChains()
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint>)LpVtbl[15])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Reset(PresentParameters* pPresentationParameters)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, PresentParameters*, int>)LpVtbl[16])(@this, pPresentationParameters);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int Reset(ref PresentParameters pPresentationParameters)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, PresentParameters*, int>)LpVtbl[16])(@this, pPresentationParametersPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Present(Silk.NET.Core.Native.TagRect* pSourceRect, Silk.NET.Core.Native.TagRect* pDestRect, IntPtr hDestWindowOverride, RGNData* pDirtyRegion)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, Silk.NET.Core.Native.TagRect*, Silk.NET.Core.Native.TagRect*, IntPtr, RGNData*, int>)LpVtbl[17])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Present(Silk.NET.Core.Native.TagRect* pSourceRect, Silk.NET.Core.Native.TagRect* pDestRect, IntPtr hDestWindowOverride, ref RGNData pDirtyRegion)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, Silk.NET.Core.Native.TagRect*, Silk.NET.Core.Native.TagRect*, IntPtr, RGNData*, int>)LpVtbl[17])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegionPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Present(Silk.NET.Core.Native.TagRect* pSourceRect, ref Silk.NET.Core.Native.TagRect pDestRect, IntPtr hDestWindowOverride, RGNData* pDirtyRegion)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.TagRect* pDestRectPtr = &pDestRect)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, Silk.NET.Core.Native.TagRect*, Silk.NET.Core.Native.TagRect*, IntPtr, RGNData*, int>)LpVtbl[17])(@this, pSourceRect, pDestRectPtr, hDestWindowOverride, pDirtyRegion);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Present(Silk.NET.Core.Native.TagRect* pSourceRect, ref Silk.NET.Core.Native.TagRect pDestRect, IntPtr hDestWindowOverride, ref RGNData pDirtyRegion)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.TagRect* pDestRectPtr = &pDestRect)
                {
                    fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, Silk.NET.Core.Native.TagRect*, Silk.NET.Core.Native.TagRect*, IntPtr, RGNData*, int>)LpVtbl[17])(@this, pSourceRect, pDestRectPtr, hDestWindowOverride, pDirtyRegionPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Present(ref Silk.NET.Core.Native.TagRect pSourceRect, Silk.NET.Core.Native.TagRect* pDestRect, IntPtr hDestWindowOverride, RGNData* pDirtyRegion)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.TagRect* pSourceRectPtr = &pSourceRect)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, Silk.NET.Core.Native.TagRect*, Silk.NET.Core.Native.TagRect*, IntPtr, RGNData*, int>)LpVtbl[17])(@this, pSourceRectPtr, pDestRect, hDestWindowOverride, pDirtyRegion);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Present(ref Silk.NET.Core.Native.TagRect pSourceRect, Silk.NET.Core.Native.TagRect* pDestRect, IntPtr hDestWindowOverride, ref RGNData pDirtyRegion)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.TagRect* pSourceRectPtr = &pSourceRect)
                {
                    fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, Silk.NET.Core.Native.TagRect*, Silk.NET.Core.Native.TagRect*, IntPtr, RGNData*, int>)LpVtbl[17])(@this, pSourceRectPtr, pDestRect, hDestWindowOverride, pDirtyRegionPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Present(ref Silk.NET.Core.Native.TagRect pSourceRect, ref Silk.NET.Core.Native.TagRect pDestRect, IntPtr hDestWindowOverride, RGNData* pDirtyRegion)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.TagRect* pSourceRectPtr = &pSourceRect)
                {
                    fixed (Silk.NET.Core.Native.TagRect* pDestRectPtr = &pDestRect)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, Silk.NET.Core.Native.TagRect*, Silk.NET.Core.Native.TagRect*, IntPtr, RGNData*, int>)LpVtbl[17])(@this, pSourceRectPtr, pDestRectPtr, hDestWindowOverride, pDirtyRegion);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int Present(ref Silk.NET.Core.Native.TagRect pSourceRect, ref Silk.NET.Core.Native.TagRect pDestRect, IntPtr hDestWindowOverride, ref RGNData pDirtyRegion)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.TagRect* pSourceRectPtr = &pSourceRect)
                {
                    fixed (Silk.NET.Core.Native.TagRect* pDestRectPtr = &pDestRect)
                    {
                        fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
                        {
                            ret = ((delegate* cdecl<IDirect3DDevice9*, Silk.NET.Core.Native.TagRect*, Silk.NET.Core.Native.TagRect*, IntPtr, RGNData*, int>)LpVtbl[17])(@this, pSourceRectPtr, pDestRectPtr, hDestWindowOverride, pDirtyRegionPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetBackBuffer(uint iSwapChain, uint iBackBuffer, BackbufferType Type, IDirect3DSurface9** ppBackBuffer)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, BackbufferType, IDirect3DSurface9**, int>)LpVtbl[18])(@this, iSwapChain, iBackBuffer, Type, ppBackBuffer);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetBackBuffer(uint iSwapChain, uint iBackBuffer, BackbufferType Type, ref IDirect3DSurface9* ppBackBuffer)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9** ppBackBufferPtr = &ppBackBuffer)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, BackbufferType, IDirect3DSurface9**, int>)LpVtbl[18])(@this, iSwapChain, iBackBuffer, Type, ppBackBufferPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetRasterStatus(uint iSwapChain, RasterStatus* pRasterStatus)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, RasterStatus*, int>)LpVtbl[19])(@this, iSwapChain, pRasterStatus);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetRasterStatus(uint iSwapChain, ref RasterStatus pRasterStatus)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (RasterStatus* pRasterStatusPtr = &pRasterStatus)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, RasterStatus*, int>)LpVtbl[19])(@this, iSwapChain, pRasterStatusPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetDialogBoxMode(int bEnableDialogs)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, int, int>)LpVtbl[20])(@this, bEnableDialogs);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SetGammaRamp(uint iSwapChain, uint Flags, Gammaramp* pRamp)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                ((delegate* cdecl<IDirect3DDevice9*, uint, uint, Gammaramp*, void>)LpVtbl[21])(@this, iSwapChain, Flags, pRamp);
            }
        }

        /// <summary>To be added.</summary>
        public void SetGammaRamp(uint iSwapChain, uint Flags, ref Gammaramp pRamp)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                fixed (Gammaramp* pRampPtr = &pRamp)
                {
                    ((delegate* cdecl<IDirect3DDevice9*, uint, uint, Gammaramp*, void>)LpVtbl[21])(@this, iSwapChain, Flags, pRampPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void GetGammaRamp(uint iSwapChain, Gammaramp* pRamp)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                ((delegate* cdecl<IDirect3DDevice9*, uint, Gammaramp*, void>)LpVtbl[22])(@this, iSwapChain, pRamp);
            }
        }

        /// <summary>To be added.</summary>
        public void GetGammaRamp(uint iSwapChain, ref Gammaramp pRamp)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                fixed (Gammaramp* pRampPtr = &pRamp)
                {
                    ((delegate* cdecl<IDirect3DDevice9*, uint, Gammaramp*, void>)LpVtbl[22])(@this, iSwapChain, pRampPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateTexture(uint Width, uint Height, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DTexture9** ppTexture, void** pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexture, pSharedHandle);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateTexture(uint Width, uint Height, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DTexture9** ppTexture, ref void* pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexture, pSharedHandlePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateTexture(uint Width, uint Height, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DTexture9* ppTexture, void** pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DTexture9** ppTexturePtr = &ppTexture)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexturePtr, pSharedHandle);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateTexture(uint Width, uint Height, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DTexture9* ppTexture, ref void* pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DTexture9** ppTexturePtr = &ppTexture)
                {
                    fixed (void** pSharedHandlePtr = &pSharedHandle)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexturePtr, pSharedHandlePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVolumeTexture(uint Width, uint Height, uint Depth, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DVolumeTexture9** ppVolumeTexture, void** pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexture, pSharedHandle);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVolumeTexture(uint Width, uint Height, uint Depth, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DVolumeTexture9** ppVolumeTexture, ref void* pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexture, pSharedHandlePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVolumeTexture(uint Width, uint Height, uint Depth, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DVolumeTexture9* ppVolumeTexture, void** pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DVolumeTexture9** ppVolumeTexturePtr = &ppVolumeTexture)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexturePtr, pSharedHandle);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVolumeTexture(uint Width, uint Height, uint Depth, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DVolumeTexture9* ppVolumeTexture, ref void* pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DVolumeTexture9** ppVolumeTexturePtr = &ppVolumeTexture)
                {
                    fixed (void** pSharedHandlePtr = &pSharedHandle)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexturePtr, pSharedHandlePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCubeTexture(uint EdgeLength, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DCubeTexture9** ppCubeTexture, void** pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexture, pSharedHandle);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCubeTexture(uint EdgeLength, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DCubeTexture9** ppCubeTexture, ref void* pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexture, pSharedHandlePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCubeTexture(uint EdgeLength, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DCubeTexture9* ppCubeTexture, void** pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DCubeTexture9** ppCubeTexturePtr = &ppCubeTexture)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexturePtr, pSharedHandle);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCubeTexture(uint EdgeLength, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DCubeTexture9* ppCubeTexture, ref void* pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DCubeTexture9** ppCubeTexturePtr = &ppCubeTexture)
                {
                    fixed (void** pSharedHandlePtr = &pSharedHandle)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexturePtr, pSharedHandlePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVertexBuffer(uint Length, uint Usage, uint FVF, Pool Pool, IDirect3DVertexBuffer9** ppVertexBuffer, void** pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBuffer, pSharedHandle);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVertexBuffer(uint Length, uint Usage, uint FVF, Pool Pool, IDirect3DVertexBuffer9** ppVertexBuffer, ref void* pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBuffer, pSharedHandlePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVertexBuffer(uint Length, uint Usage, uint FVF, Pool Pool, ref IDirect3DVertexBuffer9* ppVertexBuffer, void** pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DVertexBuffer9** ppVertexBufferPtr = &ppVertexBuffer)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBufferPtr, pSharedHandle);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVertexBuffer(uint Length, uint Usage, uint FVF, Pool Pool, ref IDirect3DVertexBuffer9* ppVertexBuffer, ref void* pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DVertexBuffer9** ppVertexBufferPtr = &ppVertexBuffer)
                {
                    fixed (void** pSharedHandlePtr = &pSharedHandle)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBufferPtr, pSharedHandlePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateIndexBuffer(uint Length, uint Usage, Format Format, Pool Pool, IDirect3DIndexBuffer9** ppIndexBuffer, void** pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBuffer, pSharedHandle);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateIndexBuffer(uint Length, uint Usage, Format Format, Pool Pool, IDirect3DIndexBuffer9** ppIndexBuffer, ref void* pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBuffer, pSharedHandlePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateIndexBuffer(uint Length, uint Usage, Format Format, Pool Pool, ref IDirect3DIndexBuffer9* ppIndexBuffer, void** pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DIndexBuffer9** ppIndexBufferPtr = &ppIndexBuffer)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBufferPtr, pSharedHandle);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateIndexBuffer(uint Length, uint Usage, Format Format, Pool Pool, ref IDirect3DIndexBuffer9* ppIndexBuffer, ref void* pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DIndexBuffer9** ppIndexBufferPtr = &ppIndexBuffer)
                {
                    fixed (void** pSharedHandlePtr = &pSharedHandle)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBufferPtr, pSharedHandlePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateRenderTarget(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Lockable, IDirect3DSurface9** ppSurface, void** pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurface, pSharedHandle);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateRenderTarget(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Lockable, IDirect3DSurface9** ppSurface, ref void* pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurface, pSharedHandlePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateRenderTarget(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Lockable, ref IDirect3DSurface9* ppSurface, void** pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurfacePtr, pSharedHandle);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateRenderTarget(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Lockable, ref IDirect3DSurface9* ppSurface, ref void* pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
                {
                    fixed (void** pSharedHandlePtr = &pSharedHandle)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurfacePtr, pSharedHandlePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateDepthStencilSurface(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Discard, IDirect3DSurface9** ppSurface, void** pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurface, pSharedHandle);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateDepthStencilSurface(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Discard, IDirect3DSurface9** ppSurface, ref void* pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurface, pSharedHandlePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateDepthStencilSurface(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Discard, ref IDirect3DSurface9* ppSurface, void** pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurfacePtr, pSharedHandle);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateDepthStencilSurface(uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Discard, ref IDirect3DSurface9* ppSurface, ref void* pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
                {
                    fixed (void** pSharedHandlePtr = &pSharedHandle)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurfacePtr, pSharedHandlePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, Silk.NET.Core.Native.TagRect* pSourceRect, IDirect3DSurface9* pDestinationSurface, Silk.NET.Core.Native.TagPoint* pDestPoint)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagPoint*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurface, pDestPoint);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, Silk.NET.Core.Native.TagRect* pSourceRect, IDirect3DSurface9* pDestinationSurface, ref Silk.NET.Core.Native.TagPoint pDestPoint)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.TagPoint* pDestPointPtr = &pDestPoint)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagPoint*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurface, pDestPointPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, Silk.NET.Core.Native.TagRect* pSourceRect, ref IDirect3DSurface9 pDestinationSurface, Silk.NET.Core.Native.TagPoint* pDestPoint)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagPoint*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurfacePtr, pDestPoint);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, Silk.NET.Core.Native.TagRect* pSourceRect, ref IDirect3DSurface9 pDestinationSurface, ref Silk.NET.Core.Native.TagPoint pDestPoint)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
                {
                    fixed (Silk.NET.Core.Native.TagPoint* pDestPointPtr = &pDestPoint)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagPoint*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurfacePtr, pDestPointPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, ref Silk.NET.Core.Native.TagRect pSourceRect, IDirect3DSurface9* pDestinationSurface, Silk.NET.Core.Native.TagPoint* pDestPoint)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.TagRect* pSourceRectPtr = &pSourceRect)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagPoint*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurface, pDestPoint);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, ref Silk.NET.Core.Native.TagRect pSourceRect, IDirect3DSurface9* pDestinationSurface, ref Silk.NET.Core.Native.TagPoint pDestPoint)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.TagRect* pSourceRectPtr = &pSourceRect)
                {
                    fixed (Silk.NET.Core.Native.TagPoint* pDestPointPtr = &pDestPoint)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagPoint*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurface, pDestPointPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, ref Silk.NET.Core.Native.TagRect pSourceRect, ref IDirect3DSurface9 pDestinationSurface, Silk.NET.Core.Native.TagPoint* pDestPoint)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.TagRect* pSourceRectPtr = &pSourceRect)
                {
                    fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagPoint*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurfacePtr, pDestPoint);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateSurface(IDirect3DSurface9* pSourceSurface, ref Silk.NET.Core.Native.TagRect pSourceRect, ref IDirect3DSurface9 pDestinationSurface, ref Silk.NET.Core.Native.TagPoint pDestPoint)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.TagRect* pSourceRectPtr = &pSourceRect)
                {
                    fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
                    {
                        fixed (Silk.NET.Core.Native.TagPoint* pDestPointPtr = &pDestPoint)
                        {
                            ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagPoint*, int>)LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurfacePtr, pDestPointPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, Silk.NET.Core.Native.TagRect* pSourceRect, IDirect3DSurface9* pDestinationSurface, Silk.NET.Core.Native.TagPoint* pDestPoint)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagPoint*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurface, pDestPoint);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, Silk.NET.Core.Native.TagRect* pSourceRect, IDirect3DSurface9* pDestinationSurface, ref Silk.NET.Core.Native.TagPoint pDestPoint)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
                {
                    fixed (Silk.NET.Core.Native.TagPoint* pDestPointPtr = &pDestPoint)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagPoint*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurface, pDestPointPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, Silk.NET.Core.Native.TagRect* pSourceRect, ref IDirect3DSurface9 pDestinationSurface, Silk.NET.Core.Native.TagPoint* pDestPoint)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
                {
                    fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagPoint*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurfacePtr, pDestPoint);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, Silk.NET.Core.Native.TagRect* pSourceRect, ref IDirect3DSurface9 pDestinationSurface, ref Silk.NET.Core.Native.TagPoint pDestPoint)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
                {
                    fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
                    {
                        fixed (Silk.NET.Core.Native.TagPoint* pDestPointPtr = &pDestPoint)
                        {
                            ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagPoint*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurfacePtr, pDestPointPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Core.Native.TagRect pSourceRect, IDirect3DSurface9* pDestinationSurface, Silk.NET.Core.Native.TagPoint* pDestPoint)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
                {
                    fixed (Silk.NET.Core.Native.TagRect* pSourceRectPtr = &pSourceRect)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagPoint*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurface, pDestPoint);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Core.Native.TagRect pSourceRect, IDirect3DSurface9* pDestinationSurface, ref Silk.NET.Core.Native.TagPoint pDestPoint)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
                {
                    fixed (Silk.NET.Core.Native.TagRect* pSourceRectPtr = &pSourceRect)
                    {
                        fixed (Silk.NET.Core.Native.TagPoint* pDestPointPtr = &pDestPoint)
                        {
                            ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagPoint*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurface, pDestPointPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Core.Native.TagRect pSourceRect, ref IDirect3DSurface9 pDestinationSurface, Silk.NET.Core.Native.TagPoint* pDestPoint)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
                {
                    fixed (Silk.NET.Core.Native.TagRect* pSourceRectPtr = &pSourceRect)
                    {
                        fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
                        {
                            ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagPoint*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurfacePtr, pDestPoint);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int UpdateSurface(ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Core.Native.TagRect pSourceRect, ref IDirect3DSurface9 pDestinationSurface, ref Silk.NET.Core.Native.TagPoint pDestPoint)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
                {
                    fixed (Silk.NET.Core.Native.TagRect* pSourceRectPtr = &pSourceRect)
                    {
                        fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
                        {
                            fixed (Silk.NET.Core.Native.TagPoint* pDestPointPtr = &pDestPoint)
                            {
                                ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagPoint*, int>)LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurfacePtr, pDestPointPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTexture(IDirect3DBaseTexture9* pSourceTexture, IDirect3DBaseTexture9* pDestinationTexture)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)LpVtbl[31])(@this, pSourceTexture, pDestinationTexture);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTexture(IDirect3DBaseTexture9* pSourceTexture, ref IDirect3DBaseTexture9 pDestinationTexture)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DBaseTexture9* pDestinationTexturePtr = &pDestinationTexture)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)LpVtbl[31])(@this, pSourceTexture, pDestinationTexturePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UpdateTexture(ref IDirect3DBaseTexture9 pSourceTexture, IDirect3DBaseTexture9* pDestinationTexture)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DBaseTexture9* pSourceTexturePtr = &pSourceTexture)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)LpVtbl[31])(@this, pSourceTexturePtr, pDestinationTexture);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int UpdateTexture(ref IDirect3DBaseTexture9 pSourceTexture, ref IDirect3DBaseTexture9 pDestinationTexture)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DBaseTexture9* pSourceTexturePtr = &pSourceTexture)
                {
                    fixed (IDirect3DBaseTexture9* pDestinationTexturePtr = &pDestinationTexture)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)LpVtbl[31])(@this, pSourceTexturePtr, pDestinationTexturePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetRenderTargetData(IDirect3DSurface9* pRenderTarget, IDirect3DSurface9* pDestSurface)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, IDirect3DSurface9*, int>)LpVtbl[32])(@this, pRenderTarget, pDestSurface);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetRenderTargetData(IDirect3DSurface9* pRenderTarget, ref IDirect3DSurface9 pDestSurface)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, IDirect3DSurface9*, int>)LpVtbl[32])(@this, pRenderTarget, pDestSurfacePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetRenderTargetData(ref IDirect3DSurface9 pRenderTarget, IDirect3DSurface9* pDestSurface)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, IDirect3DSurface9*, int>)LpVtbl[32])(@this, pRenderTargetPtr, pDestSurface);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetRenderTargetData(ref IDirect3DSurface9 pRenderTarget, ref IDirect3DSurface9 pDestSurface)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
                {
                    fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, IDirect3DSurface9*, int>)LpVtbl[32])(@this, pRenderTargetPtr, pDestSurfacePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFrontBufferData(uint iSwapChain, IDirect3DSurface9* pDestSurface)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, IDirect3DSurface9*, int>)LpVtbl[33])(@this, iSwapChain, pDestSurface);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetFrontBufferData(uint iSwapChain, ref IDirect3DSurface9 pDestSurface)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, IDirect3DSurface9*, int>)LpVtbl[33])(@this, iSwapChain, pDestSurfacePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, Silk.NET.Core.Native.TagRect* pSourceRect, IDirect3DSurface9* pDestSurface, Silk.NET.Core.Native.TagRect* pDestRect, Texturefiltertype Filter)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurface, pDestRect, Filter);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, Silk.NET.Core.Native.TagRect* pSourceRect, IDirect3DSurface9* pDestSurface, ref Silk.NET.Core.Native.TagRect pDestRect, Texturefiltertype Filter)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.TagRect* pDestRectPtr = &pDestRect)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurface, pDestRectPtr, Filter);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, Silk.NET.Core.Native.TagRect* pSourceRect, ref IDirect3DSurface9 pDestSurface, Silk.NET.Core.Native.TagRect* pDestRect, Texturefiltertype Filter)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurfacePtr, pDestRect, Filter);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, Silk.NET.Core.Native.TagRect* pSourceRect, ref IDirect3DSurface9 pDestSurface, ref Silk.NET.Core.Native.TagRect pDestRect, Texturefiltertype Filter)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                {
                    fixed (Silk.NET.Core.Native.TagRect* pDestRectPtr = &pDestRect)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurfacePtr, pDestRectPtr, Filter);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, ref Silk.NET.Core.Native.TagRect pSourceRect, IDirect3DSurface9* pDestSurface, Silk.NET.Core.Native.TagRect* pDestRect, Texturefiltertype Filter)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.TagRect* pSourceRectPtr = &pSourceRect)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurface, pDestRect, Filter);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, ref Silk.NET.Core.Native.TagRect pSourceRect, IDirect3DSurface9* pDestSurface, ref Silk.NET.Core.Native.TagRect pDestRect, Texturefiltertype Filter)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.TagRect* pSourceRectPtr = &pSourceRect)
                {
                    fixed (Silk.NET.Core.Native.TagRect* pDestRectPtr = &pDestRect)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurface, pDestRectPtr, Filter);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, ref Silk.NET.Core.Native.TagRect pSourceRect, ref IDirect3DSurface9 pDestSurface, Silk.NET.Core.Native.TagRect* pDestRect, Texturefiltertype Filter)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.TagRect* pSourceRectPtr = &pSourceRect)
                {
                    fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurfacePtr, pDestRect, Filter);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int StretchRect(IDirect3DSurface9* pSourceSurface, ref Silk.NET.Core.Native.TagRect pSourceRect, ref IDirect3DSurface9 pDestSurface, ref Silk.NET.Core.Native.TagRect pDestRect, Texturefiltertype Filter)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.TagRect* pSourceRectPtr = &pSourceRect)
                {
                    fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                    {
                        fixed (Silk.NET.Core.Native.TagRect* pDestRectPtr = &pDestRect)
                        {
                            ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurfacePtr, pDestRectPtr, Filter);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int StretchRect(ref IDirect3DSurface9 pSourceSurface, Silk.NET.Core.Native.TagRect* pSourceRect, IDirect3DSurface9* pDestSurface, Silk.NET.Core.Native.TagRect* pDestRect, Texturefiltertype Filter)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurface, pDestRect, Filter);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int StretchRect(ref IDirect3DSurface9 pSourceSurface, Silk.NET.Core.Native.TagRect* pSourceRect, IDirect3DSurface9* pDestSurface, ref Silk.NET.Core.Native.TagRect pDestRect, Texturefiltertype Filter)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
                {
                    fixed (Silk.NET.Core.Native.TagRect* pDestRectPtr = &pDestRect)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurface, pDestRectPtr, Filter);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int StretchRect(ref IDirect3DSurface9 pSourceSurface, Silk.NET.Core.Native.TagRect* pSourceRect, ref IDirect3DSurface9 pDestSurface, Silk.NET.Core.Native.TagRect* pDestRect, Texturefiltertype Filter)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
                {
                    fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurfacePtr, pDestRect, Filter);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int StretchRect(ref IDirect3DSurface9 pSourceSurface, Silk.NET.Core.Native.TagRect* pSourceRect, ref IDirect3DSurface9 pDestSurface, ref Silk.NET.Core.Native.TagRect pDestRect, Texturefiltertype Filter)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
                {
                    fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                    {
                        fixed (Silk.NET.Core.Native.TagRect* pDestRectPtr = &pDestRect)
                        {
                            ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurfacePtr, pDestRectPtr, Filter);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int StretchRect(ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Core.Native.TagRect pSourceRect, IDirect3DSurface9* pDestSurface, Silk.NET.Core.Native.TagRect* pDestRect, Texturefiltertype Filter)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
                {
                    fixed (Silk.NET.Core.Native.TagRect* pSourceRectPtr = &pSourceRect)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurface, pDestRect, Filter);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int StretchRect(ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Core.Native.TagRect pSourceRect, IDirect3DSurface9* pDestSurface, ref Silk.NET.Core.Native.TagRect pDestRect, Texturefiltertype Filter)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
                {
                    fixed (Silk.NET.Core.Native.TagRect* pSourceRectPtr = &pSourceRect)
                    {
                        fixed (Silk.NET.Core.Native.TagRect* pDestRectPtr = &pDestRect)
                        {
                            ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurface, pDestRectPtr, Filter);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int StretchRect(ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Core.Native.TagRect pSourceRect, ref IDirect3DSurface9 pDestSurface, Silk.NET.Core.Native.TagRect* pDestRect, Texturefiltertype Filter)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
                {
                    fixed (Silk.NET.Core.Native.TagRect* pSourceRectPtr = &pSourceRect)
                    {
                        fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                        {
                            ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurfacePtr, pDestRect, Filter);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int StretchRect(ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Core.Native.TagRect pSourceRect, ref IDirect3DSurface9 pDestSurface, ref Silk.NET.Core.Native.TagRect pDestRect, Texturefiltertype Filter)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
                {
                    fixed (Silk.NET.Core.Native.TagRect* pSourceRectPtr = &pSourceRect)
                    {
                        fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                        {
                            fixed (Silk.NET.Core.Native.TagRect* pDestRectPtr = &pDestRect)
                            {
                                ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, Texturefiltertype, int>)LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurfacePtr, pDestRectPtr, Filter);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ColorFill(IDirect3DSurface9* pSurface, Silk.NET.Core.Native.TagRect* pRect, uint color)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, uint, int>)LpVtbl[35])(@this, pSurface, pRect, color);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ColorFill(IDirect3DSurface9* pSurface, ref Silk.NET.Core.Native.TagRect pRect, uint color)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.TagRect* pRectPtr = &pRect)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, uint, int>)LpVtbl[35])(@this, pSurface, pRectPtr, color);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ColorFill(ref IDirect3DSurface9 pSurface, Silk.NET.Core.Native.TagRect* pRect, uint color)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9* pSurfacePtr = &pSurface)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, uint, int>)LpVtbl[35])(@this, pSurfacePtr, pRect, color);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int ColorFill(ref IDirect3DSurface9 pSurface, ref Silk.NET.Core.Native.TagRect pRect, uint color)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9* pSurfacePtr = &pSurface)
                {
                    fixed (Silk.NET.Core.Native.TagRect* pRectPtr = &pRect)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, Silk.NET.Core.Native.TagRect*, uint, int>)LpVtbl[35])(@this, pSurfacePtr, pRectPtr, color);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateOffscreenPlainSurface(uint Width, uint Height, Format Format, Pool Pool, IDirect3DSurface9** ppSurface, void** pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurface, pSharedHandle);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateOffscreenPlainSurface(uint Width, uint Height, Format Format, Pool Pool, IDirect3DSurface9** ppSurface, ref void* pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurface, pSharedHandlePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateOffscreenPlainSurface(uint Width, uint Height, Format Format, Pool Pool, ref IDirect3DSurface9* ppSurface, void** pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurfacePtr, pSharedHandle);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateOffscreenPlainSurface(uint Width, uint Height, Format Format, Pool Pool, ref IDirect3DSurface9* ppSurface, ref void* pSharedHandle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
                {
                    fixed (void** pSharedHandlePtr = &pSharedHandle)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurfacePtr, pSharedHandlePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetRenderTarget(uint RenderTargetIndex, IDirect3DSurface9* pRenderTarget)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, IDirect3DSurface9*, int>)LpVtbl[37])(@this, RenderTargetIndex, pRenderTarget);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetRenderTarget(uint RenderTargetIndex, ref IDirect3DSurface9 pRenderTarget)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, IDirect3DSurface9*, int>)LpVtbl[37])(@this, RenderTargetIndex, pRenderTargetPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetRenderTarget(uint RenderTargetIndex, IDirect3DSurface9** ppRenderTarget)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, IDirect3DSurface9**, int>)LpVtbl[38])(@this, RenderTargetIndex, ppRenderTarget);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetRenderTarget(uint RenderTargetIndex, ref IDirect3DSurface9* ppRenderTarget)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9** ppRenderTargetPtr = &ppRenderTarget)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, IDirect3DSurface9**, int>)LpVtbl[38])(@this, RenderTargetIndex, ppRenderTargetPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetDepthStencilSurface(IDirect3DSurface9* pNewZStencil)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, int>)LpVtbl[39])(@this, pNewZStencil);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetDepthStencilSurface(ref IDirect3DSurface9 pNewZStencil)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9* pNewZStencilPtr = &pNewZStencil)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9*, int>)LpVtbl[39])(@this, pNewZStencilPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDepthStencilSurface(IDirect3DSurface9** ppZStencilSurface)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9**, int>)LpVtbl[40])(@this, ppZStencilSurface);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDepthStencilSurface(ref IDirect3DSurface9* ppZStencilSurface)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9** ppZStencilSurfacePtr = &ppZStencilSurface)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DSurface9**, int>)LpVtbl[40])(@this, ppZStencilSurfacePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int BeginScene()
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, int>)LpVtbl[41])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int EndScene()
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, int>)LpVtbl[42])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Clear(uint Count, Rect* pRects, uint Flags, uint Color, float Z, uint Stencil)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, Rect*, uint, uint, float, uint, int>)LpVtbl[43])(@this, Count, pRects, Flags, Color, Z, Stencil);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int Clear(uint Count, ref Rect pRects, uint Flags, uint Color, float Z, uint Stencil)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Rect* pRectsPtr = &pRects)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, Rect*, uint, uint, float, uint, int>)LpVtbl[43])(@this, Count, pRectsPtr, Flags, Color, Z, Stencil);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetTransform(Transformstatetype State, Matrix* pMatrix)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, Transformstatetype, Matrix*, int>)LpVtbl[44])(@this, State, pMatrix);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetTransform(Transformstatetype State, ref Matrix pMatrix)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Matrix* pMatrixPtr = &pMatrix)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, Transformstatetype, Matrix*, int>)LpVtbl[44])(@this, State, pMatrixPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetTransform(Transformstatetype State, Matrix* pMatrix)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, Transformstatetype, Matrix*, int>)LpVtbl[45])(@this, State, pMatrix);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetTransform(Transformstatetype State, ref Matrix pMatrix)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Matrix* pMatrixPtr = &pMatrix)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, Transformstatetype, Matrix*, int>)LpVtbl[45])(@this, State, pMatrixPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int MultiplyTransform(Transformstatetype arg0, Matrix* arg1)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, Transformstatetype, Matrix*, int>)LpVtbl[46])(@this, arg0, arg1);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int MultiplyTransform(Transformstatetype arg0, ref Matrix arg1)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Matrix* arg1Ptr = &arg1)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, Transformstatetype, Matrix*, int>)LpVtbl[46])(@this, arg0, arg1Ptr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetViewport(Viewport9* pViewport)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, Viewport9*, int>)LpVtbl[47])(@this, pViewport);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetViewport(ref Viewport9 pViewport)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Viewport9* pViewportPtr = &pViewport)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, Viewport9*, int>)LpVtbl[47])(@this, pViewportPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetViewport(Viewport9* pViewport)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, Viewport9*, int>)LpVtbl[48])(@this, pViewport);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetViewport(ref Viewport9 pViewport)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Viewport9* pViewportPtr = &pViewport)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, Viewport9*, int>)LpVtbl[48])(@this, pViewportPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetMaterial(Material9* pMaterial)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, Material9*, int>)LpVtbl[49])(@this, pMaterial);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetMaterial(ref Material9 pMaterial)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Material9* pMaterialPtr = &pMaterial)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, Material9*, int>)LpVtbl[49])(@this, pMaterialPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetMaterial(Material9* pMaterial)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, Material9*, int>)LpVtbl[50])(@this, pMaterial);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetMaterial(ref Material9 pMaterial)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Material9* pMaterialPtr = &pMaterial)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, Material9*, int>)LpVtbl[50])(@this, pMaterialPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetLight(uint Index, Light9* arg1)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, Light9*, int>)LpVtbl[51])(@this, Index, arg1);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetLight(uint Index, ref Light9 arg1)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Light9* arg1Ptr = &arg1)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, Light9*, int>)LpVtbl[51])(@this, Index, arg1Ptr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetLight(uint Index, Light9* arg1)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, Light9*, int>)LpVtbl[52])(@this, Index, arg1);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetLight(uint Index, ref Light9 arg1)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Light9* arg1Ptr = &arg1)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, Light9*, int>)LpVtbl[52])(@this, Index, arg1Ptr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int LightEnable(uint Index, int Enable)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, int, int>)LpVtbl[53])(@this, Index, Enable);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetLightEnable(uint Index, int* pEnable)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, int*, int>)LpVtbl[54])(@this, Index, pEnable);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetLightEnable(uint Index, ref int pEnable)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (int* pEnablePtr = &pEnable)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, int*, int>)LpVtbl[54])(@this, Index, pEnablePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetClipPlane(uint Index, float* pPlane)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, float*, int>)LpVtbl[55])(@this, Index, pPlane);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetClipPlane(uint Index, ref float pPlane)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (float* pPlanePtr = &pPlane)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, float*, int>)LpVtbl[55])(@this, Index, pPlanePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetClipPlane(uint Index, float* pPlane)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, float*, int>)LpVtbl[56])(@this, Index, pPlane);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetClipPlane(uint Index, ref float pPlane)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (float* pPlanePtr = &pPlane)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, float*, int>)LpVtbl[56])(@this, Index, pPlanePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetRenderState(Renderstatetype State, uint Value)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, Renderstatetype, uint, int>)LpVtbl[57])(@this, State, Value);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetRenderState(Renderstatetype State, uint* pValue)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, Renderstatetype, uint*, int>)LpVtbl[58])(@this, State, pValue);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetRenderState(Renderstatetype State, ref uint pValue)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (uint* pValuePtr = &pValue)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, Renderstatetype, uint*, int>)LpVtbl[58])(@this, State, pValuePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateStateBlock(Stateblocktype Type, IDirect3DStateBlock9** ppSB)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, Stateblocktype, IDirect3DStateBlock9**, int>)LpVtbl[59])(@this, Type, ppSB);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateStateBlock(Stateblocktype Type, ref IDirect3DStateBlock9* ppSB)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DStateBlock9** ppSBPtr = &ppSB)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, Stateblocktype, IDirect3DStateBlock9**, int>)LpVtbl[59])(@this, Type, ppSBPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int BeginStateBlock()
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, int>)LpVtbl[60])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int EndStateBlock(IDirect3DStateBlock9** ppSB)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DStateBlock9**, int>)LpVtbl[61])(@this, ppSB);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int EndStateBlock(ref IDirect3DStateBlock9* ppSB)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DStateBlock9** ppSBPtr = &ppSB)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DStateBlock9**, int>)LpVtbl[61])(@this, ppSBPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetClipStatus(Clipstatus9* pClipStatus)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, Clipstatus9*, int>)LpVtbl[62])(@this, pClipStatus);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetClipStatus(ref Clipstatus9 pClipStatus)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Clipstatus9* pClipStatusPtr = &pClipStatus)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, Clipstatus9*, int>)LpVtbl[62])(@this, pClipStatusPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetClipStatus(Clipstatus9* pClipStatus)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, Clipstatus9*, int>)LpVtbl[63])(@this, pClipStatus);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetClipStatus(ref Clipstatus9 pClipStatus)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Clipstatus9* pClipStatusPtr = &pClipStatus)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, Clipstatus9*, int>)LpVtbl[63])(@this, pClipStatusPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetTexture(uint Stage, IDirect3DBaseTexture9** ppTexture)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, IDirect3DBaseTexture9**, int>)LpVtbl[64])(@this, Stage, ppTexture);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetTexture(uint Stage, ref IDirect3DBaseTexture9* ppTexture)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DBaseTexture9** ppTexturePtr = &ppTexture)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, IDirect3DBaseTexture9**, int>)LpVtbl[64])(@this, Stage, ppTexturePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetTexture(uint Stage, IDirect3DBaseTexture9* pTexture)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, IDirect3DBaseTexture9*, int>)LpVtbl[65])(@this, Stage, pTexture);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetTexture(uint Stage, ref IDirect3DBaseTexture9 pTexture)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DBaseTexture9* pTexturePtr = &pTexture)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, IDirect3DBaseTexture9*, int>)LpVtbl[65])(@this, Stage, pTexturePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetTextureStageState(uint Stage, Texturestagestatetype Type, uint* pValue)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, Texturestagestatetype, uint*, int>)LpVtbl[66])(@this, Stage, Type, pValue);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetTextureStageState(uint Stage, Texturestagestatetype Type, ref uint pValue)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (uint* pValuePtr = &pValue)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, Texturestagestatetype, uint*, int>)LpVtbl[66])(@this, Stage, Type, pValuePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetTextureStageState(uint Stage, Texturestagestatetype Type, uint Value)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, Texturestagestatetype, uint, int>)LpVtbl[67])(@this, Stage, Type, Value);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetSamplerState(uint Sampler, Samplerstatetype Type, uint* pValue)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, Samplerstatetype, uint*, int>)LpVtbl[68])(@this, Sampler, Type, pValue);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetSamplerState(uint Sampler, Samplerstatetype Type, ref uint pValue)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (uint* pValuePtr = &pValue)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, Samplerstatetype, uint*, int>)LpVtbl[68])(@this, Sampler, Type, pValuePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetSamplerState(uint Sampler, Samplerstatetype Type, uint Value)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, Samplerstatetype, uint, int>)LpVtbl[69])(@this, Sampler, Type, Value);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ValidateDevice(uint* pNumPasses)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint*, int>)LpVtbl[70])(@this, pNumPasses);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int ValidateDevice(ref uint pNumPasses)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (uint* pNumPassesPtr = &pNumPasses)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint*, int>)LpVtbl[70])(@this, pNumPassesPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPaletteEntries(uint PaletteNumber, Silk.NET.Core.Native.TagPaletteEntry* pEntries)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, Silk.NET.Core.Native.TagPaletteEntry*, int>)LpVtbl[71])(@this, PaletteNumber, pEntries);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPaletteEntries(uint PaletteNumber, ref Silk.NET.Core.Native.TagPaletteEntry pEntries)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.TagPaletteEntry* pEntriesPtr = &pEntries)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, Silk.NET.Core.Native.TagPaletteEntry*, int>)LpVtbl[71])(@this, PaletteNumber, pEntriesPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPaletteEntries(uint PaletteNumber, Silk.NET.Core.Native.TagPaletteEntry* pEntries)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, Silk.NET.Core.Native.TagPaletteEntry*, int>)LpVtbl[72])(@this, PaletteNumber, pEntries);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPaletteEntries(uint PaletteNumber, ref Silk.NET.Core.Native.TagPaletteEntry pEntries)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.TagPaletteEntry* pEntriesPtr = &pEntries)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, Silk.NET.Core.Native.TagPaletteEntry*, int>)LpVtbl[72])(@this, PaletteNumber, pEntriesPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetCurrentTexturePalette(uint PaletteNumber)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, int>)LpVtbl[73])(@this, PaletteNumber);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCurrentTexturePalette(uint* PaletteNumber)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint*, int>)LpVtbl[74])(@this, PaletteNumber);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetCurrentTexturePalette(ref uint PaletteNumber)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (uint* PaletteNumberPtr = &PaletteNumber)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint*, int>)LpVtbl[74])(@this, PaletteNumberPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetScissorRect(Silk.NET.Core.Native.TagRect* pRect)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, Silk.NET.Core.Native.TagRect*, int>)LpVtbl[75])(@this, pRect);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetScissorRect(ref Silk.NET.Core.Native.TagRect pRect)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.TagRect* pRectPtr = &pRect)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, Silk.NET.Core.Native.TagRect*, int>)LpVtbl[75])(@this, pRectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetScissorRect(Silk.NET.Core.Native.TagRect* pRect)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, Silk.NET.Core.Native.TagRect*, int>)LpVtbl[76])(@this, pRect);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetScissorRect(ref Silk.NET.Core.Native.TagRect pRect)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.TagRect* pRectPtr = &pRect)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, Silk.NET.Core.Native.TagRect*, int>)LpVtbl[76])(@this, pRectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetSoftwareVertexProcessing(int bSoftware)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, int, int>)LpVtbl[77])(@this, bSoftware);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetSoftwareVertexProcessing()
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, int>)LpVtbl[78])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetNPatchMode(float nSegments)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, float, int>)LpVtbl[79])(@this, nSegments);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public float GetNPatchMode()
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                float ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, float>)LpVtbl[80])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int DrawPrimitive(Primitivetype PrimitiveType, uint StartVertex, uint PrimitiveCount)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, Primitivetype, uint, uint, int>)LpVtbl[81])(@this, PrimitiveType, StartVertex, PrimitiveCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int DrawIndexedPrimitive(Primitivetype arg0, int BaseVertexIndex, uint MinVertexIndex, uint NumVertices, uint startIndex, uint primCount)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, Primitivetype, int, uint, uint, uint, uint, int>)LpVtbl[82])(@this, arg0, BaseVertexIndex, MinVertexIndex, NumVertices, startIndex, primCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DrawPrimitiveUP(Primitivetype PrimitiveType, uint PrimitiveCount, void* pVertexStreamZeroData, uint VertexStreamZeroStride)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, Primitivetype, uint, void*, uint, int>)LpVtbl[83])(@this, PrimitiveType, PrimitiveCount, pVertexStreamZeroData, VertexStreamZeroStride);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int DrawPrimitiveUP<T0>(Primitivetype PrimitiveType, uint PrimitiveCount, ref T0 pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (T0* pVertexStreamZeroDataPtr = &pVertexStreamZeroData)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, Primitivetype, uint, T0*, uint, int>)LpVtbl[83])(@this, PrimitiveType, PrimitiveCount, pVertexStreamZeroDataPtr, VertexStreamZeroStride);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DrawIndexedPrimitiveUP(Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, void* pIndexData, Format IndexDataFormat, void* pVertexStreamZeroData, uint VertexStreamZeroStride)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, Primitivetype, uint, uint, uint, void*, Format, void*, uint, int>)LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexData, IndexDataFormat, pVertexStreamZeroData, VertexStreamZeroStride);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DrawIndexedPrimitiveUP<T0>(Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, void* pIndexData, Format IndexDataFormat, ref T0 pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (T0* pVertexStreamZeroDataPtr = &pVertexStreamZeroData)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, Primitivetype, uint, uint, uint, void*, Format, T0*, uint, int>)LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexData, IndexDataFormat, pVertexStreamZeroDataPtr, VertexStreamZeroStride);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DrawIndexedPrimitiveUP<T0>(Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, ref T0 pIndexData, Format IndexDataFormat, void* pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (T0* pIndexDataPtr = &pIndexData)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, Primitivetype, uint, uint, uint, T0*, Format, void*, uint, int>)LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexDataPtr, IndexDataFormat, pVertexStreamZeroData, VertexStreamZeroStride);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int DrawIndexedPrimitiveUP<T0, T1>(Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, ref T0 pIndexData, Format IndexDataFormat, ref T1 pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged where T1 : unmanaged
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (T0* pIndexDataPtr = &pIndexData)
                {
                    fixed (T1* pVertexStreamZeroDataPtr = &pVertexStreamZeroData)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, Primitivetype, uint, uint, uint, T0*, Format, T1*, uint, int>)LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexDataPtr, IndexDataFormat, pVertexStreamZeroDataPtr, VertexStreamZeroStride);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ProcessVertices(uint SrcStartIndex, uint DestIndex, uint VertexCount, IDirect3DVertexBuffer9* pDestBuffer, IDirect3DVertexDeclaration9* pVertexDecl, uint Flags)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBuffer, pVertexDecl, Flags);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ProcessVertices(uint SrcStartIndex, uint DestIndex, uint VertexCount, IDirect3DVertexBuffer9* pDestBuffer, ref IDirect3DVertexDeclaration9 pVertexDecl, uint Flags)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DVertexDeclaration9* pVertexDeclPtr = &pVertexDecl)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBuffer, pVertexDeclPtr, Flags);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ProcessVertices(uint SrcStartIndex, uint DestIndex, uint VertexCount, ref IDirect3DVertexBuffer9 pDestBuffer, IDirect3DVertexDeclaration9* pVertexDecl, uint Flags)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DVertexBuffer9* pDestBufferPtr = &pDestBuffer)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBufferPtr, pVertexDecl, Flags);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int ProcessVertices(uint SrcStartIndex, uint DestIndex, uint VertexCount, ref IDirect3DVertexBuffer9 pDestBuffer, ref IDirect3DVertexDeclaration9 pVertexDecl, uint Flags)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DVertexBuffer9* pDestBufferPtr = &pDestBuffer)
                {
                    fixed (IDirect3DVertexDeclaration9* pVertexDeclPtr = &pVertexDecl)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBufferPtr, pVertexDeclPtr, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVertexDeclaration(Vertexelement9* pVertexElements, IDirect3DVertexDeclaration9** ppDecl)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)LpVtbl[86])(@this, pVertexElements, ppDecl);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVertexDeclaration(Vertexelement9* pVertexElements, ref IDirect3DVertexDeclaration9* ppDecl)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DVertexDeclaration9** ppDeclPtr = &ppDecl)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)LpVtbl[86])(@this, pVertexElements, ppDeclPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVertexDeclaration(ref Vertexelement9 pVertexElements, IDirect3DVertexDeclaration9** ppDecl)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Vertexelement9* pVertexElementsPtr = &pVertexElements)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)LpVtbl[86])(@this, pVertexElementsPtr, ppDecl);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVertexDeclaration(ref Vertexelement9 pVertexElements, ref IDirect3DVertexDeclaration9* ppDecl)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (Vertexelement9* pVertexElementsPtr = &pVertexElements)
                {
                    fixed (IDirect3DVertexDeclaration9** ppDeclPtr = &ppDecl)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)LpVtbl[86])(@this, pVertexElementsPtr, ppDeclPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetVertexDeclaration(IDirect3DVertexDeclaration9* pDecl)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DVertexDeclaration9*, int>)LpVtbl[87])(@this, pDecl);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetVertexDeclaration(ref IDirect3DVertexDeclaration9 pDecl)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DVertexDeclaration9* pDeclPtr = &pDecl)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DVertexDeclaration9*, int>)LpVtbl[87])(@this, pDeclPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVertexDeclaration(IDirect3DVertexDeclaration9** ppDecl)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DVertexDeclaration9**, int>)LpVtbl[88])(@this, ppDecl);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVertexDeclaration(ref IDirect3DVertexDeclaration9* ppDecl)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DVertexDeclaration9** ppDeclPtr = &ppDecl)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DVertexDeclaration9**, int>)LpVtbl[88])(@this, ppDeclPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetFVF(uint FVF)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, int>)LpVtbl[89])(@this, FVF);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFVF(uint* pFVF)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint*, int>)LpVtbl[90])(@this, pFVF);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetFVF(ref uint pFVF)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (uint* pFVFPtr = &pFVF)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint*, int>)LpVtbl[90])(@this, pFVFPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVertexShader(uint* pFunction, IDirect3DVertexShader9** ppShader)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint*, IDirect3DVertexShader9**, int>)LpVtbl[91])(@this, pFunction, ppShader);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVertexShader(uint* pFunction, ref IDirect3DVertexShader9* ppShader)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DVertexShader9** ppShaderPtr = &ppShader)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint*, IDirect3DVertexShader9**, int>)LpVtbl[91])(@this, pFunction, ppShaderPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVertexShader(ref uint pFunction, IDirect3DVertexShader9** ppShader)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (uint* pFunctionPtr = &pFunction)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint*, IDirect3DVertexShader9**, int>)LpVtbl[91])(@this, pFunctionPtr, ppShader);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVertexShader(ref uint pFunction, ref IDirect3DVertexShader9* ppShader)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (uint* pFunctionPtr = &pFunction)
                {
                    fixed (IDirect3DVertexShader9** ppShaderPtr = &ppShader)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, uint*, IDirect3DVertexShader9**, int>)LpVtbl[91])(@this, pFunctionPtr, ppShaderPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetVertexShader(IDirect3DVertexShader9* pShader)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DVertexShader9*, int>)LpVtbl[92])(@this, pShader);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetVertexShader(ref IDirect3DVertexShader9 pShader)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DVertexShader9* pShaderPtr = &pShader)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DVertexShader9*, int>)LpVtbl[92])(@this, pShaderPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVertexShader(IDirect3DVertexShader9** ppShader)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DVertexShader9**, int>)LpVtbl[93])(@this, ppShader);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVertexShader(ref IDirect3DVertexShader9* ppShader)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DVertexShader9** ppShaderPtr = &ppShader)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DVertexShader9**, int>)LpVtbl[93])(@this, ppShaderPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetVertexShaderConstantF(uint StartRegister, float* pConstantData, uint Vector4fCount)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[94])(@this, StartRegister, pConstantData, Vector4fCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetVertexShaderConstantF(uint StartRegister, ref float pConstantData, uint Vector4fCount)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (float* pConstantDataPtr = &pConstantData)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[94])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVertexShaderConstantF(uint StartRegister, float* pConstantData, uint Vector4fCount)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[95])(@this, StartRegister, pConstantData, Vector4fCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetVertexShaderConstantF(uint StartRegister, ref float pConstantData, uint Vector4fCount)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (float* pConstantDataPtr = &pConstantData)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[95])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetVertexShaderConstantI(uint StartRegister, int* pConstantData, uint Vector4iCount)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[96])(@this, StartRegister, pConstantData, Vector4iCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetVertexShaderConstantI(uint StartRegister, ref int pConstantData, uint Vector4iCount)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (int* pConstantDataPtr = &pConstantData)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[96])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVertexShaderConstantI(uint StartRegister, int* pConstantData, uint Vector4iCount)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[97])(@this, StartRegister, pConstantData, Vector4iCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetVertexShaderConstantI(uint StartRegister, ref int pConstantData, uint Vector4iCount)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (int* pConstantDataPtr = &pConstantData)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[97])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetVertexShaderConstantB(uint StartRegister, int* pConstantData, uint BoolCount)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[98])(@this, StartRegister, pConstantData, BoolCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetVertexShaderConstantB(uint StartRegister, ref int pConstantData, uint BoolCount)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (int* pConstantDataPtr = &pConstantData)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[98])(@this, StartRegister, pConstantDataPtr, BoolCount);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVertexShaderConstantB(uint StartRegister, int* pConstantData, uint BoolCount)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[99])(@this, StartRegister, pConstantData, BoolCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetVertexShaderConstantB(uint StartRegister, ref int pConstantData, uint BoolCount)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (int* pConstantDataPtr = &pConstantData)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[99])(@this, StartRegister, pConstantDataPtr, BoolCount);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9* pStreamData, uint OffsetInBytes, uint Stride)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9*, uint, uint, int>)LpVtbl[100])(@this, StreamNumber, pStreamData, OffsetInBytes, Stride);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetStreamSource(uint StreamNumber, ref IDirect3DVertexBuffer9 pStreamData, uint OffsetInBytes, uint Stride)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DVertexBuffer9* pStreamDataPtr = &pStreamData)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9*, uint, uint, int>)LpVtbl[100])(@this, StreamNumber, pStreamDataPtr, OffsetInBytes, Stride);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, uint* OffsetInBytes, uint* pStride)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamData, OffsetInBytes, pStride);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, uint* OffsetInBytes, ref uint pStride)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (uint* pStridePtr = &pStride)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamData, OffsetInBytes, pStridePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, ref uint OffsetInBytes, uint* pStride)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (uint* OffsetInBytesPtr = &OffsetInBytes)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamData, OffsetInBytesPtr, pStride);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, ref uint OffsetInBytes, ref uint pStride)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (uint* OffsetInBytesPtr = &OffsetInBytes)
                {
                    fixed (uint* pStridePtr = &pStride)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamData, OffsetInBytesPtr, pStridePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetStreamSource(uint StreamNumber, ref IDirect3DVertexBuffer9* ppStreamData, uint* OffsetInBytes, uint* pStride)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DVertexBuffer9** ppStreamDataPtr = &ppStreamData)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamDataPtr, OffsetInBytes, pStride);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetStreamSource(uint StreamNumber, ref IDirect3DVertexBuffer9* ppStreamData, uint* OffsetInBytes, ref uint pStride)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DVertexBuffer9** ppStreamDataPtr = &ppStreamData)
                {
                    fixed (uint* pStridePtr = &pStride)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamDataPtr, OffsetInBytes, pStridePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetStreamSource(uint StreamNumber, ref IDirect3DVertexBuffer9* ppStreamData, ref uint OffsetInBytes, uint* pStride)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DVertexBuffer9** ppStreamDataPtr = &ppStreamData)
                {
                    fixed (uint* OffsetInBytesPtr = &OffsetInBytes)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamDataPtr, OffsetInBytesPtr, pStride);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetStreamSource(uint StreamNumber, ref IDirect3DVertexBuffer9* ppStreamData, ref uint OffsetInBytes, ref uint pStride)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DVertexBuffer9** ppStreamDataPtr = &ppStreamData)
                {
                    fixed (uint* OffsetInBytesPtr = &OffsetInBytes)
                    {
                        fixed (uint* pStridePtr = &pStride)
                        {
                            ret = ((delegate* cdecl<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)LpVtbl[101])(@this, StreamNumber, ppStreamDataPtr, OffsetInBytesPtr, pStridePtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetStreamSourceFreq(uint StreamNumber, uint Divider)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint, int>)LpVtbl[102])(@this, StreamNumber, Divider);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetStreamSourceFreq(uint StreamNumber, uint* Divider)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint*, int>)LpVtbl[103])(@this, StreamNumber, Divider);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetStreamSourceFreq(uint StreamNumber, ref uint Divider)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (uint* DividerPtr = &Divider)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, uint*, int>)LpVtbl[103])(@this, StreamNumber, DividerPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetIndices(IDirect3DIndexBuffer9* pIndexData)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DIndexBuffer9*, int>)LpVtbl[104])(@this, pIndexData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetIndices(ref IDirect3DIndexBuffer9 pIndexData)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DIndexBuffer9* pIndexDataPtr = &pIndexData)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DIndexBuffer9*, int>)LpVtbl[104])(@this, pIndexDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetIndices(IDirect3DIndexBuffer9** ppIndexData)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DIndexBuffer9**, int>)LpVtbl[105])(@this, ppIndexData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetIndices(ref IDirect3DIndexBuffer9* ppIndexData)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DIndexBuffer9** ppIndexDataPtr = &ppIndexData)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DIndexBuffer9**, int>)LpVtbl[105])(@this, ppIndexDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreatePixelShader(uint* pFunction, IDirect3DPixelShader9** ppShader)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint*, IDirect3DPixelShader9**, int>)LpVtbl[106])(@this, pFunction, ppShader);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreatePixelShader(uint* pFunction, ref IDirect3DPixelShader9* ppShader)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DPixelShader9** ppShaderPtr = &ppShader)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint*, IDirect3DPixelShader9**, int>)LpVtbl[106])(@this, pFunction, ppShaderPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreatePixelShader(ref uint pFunction, IDirect3DPixelShader9** ppShader)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (uint* pFunctionPtr = &pFunction)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint*, IDirect3DPixelShader9**, int>)LpVtbl[106])(@this, pFunctionPtr, ppShader);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreatePixelShader(ref uint pFunction, ref IDirect3DPixelShader9* ppShader)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (uint* pFunctionPtr = &pFunction)
                {
                    fixed (IDirect3DPixelShader9** ppShaderPtr = &ppShader)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, uint*, IDirect3DPixelShader9**, int>)LpVtbl[106])(@this, pFunctionPtr, ppShaderPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPixelShader(IDirect3DPixelShader9* pShader)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DPixelShader9*, int>)LpVtbl[107])(@this, pShader);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPixelShader(ref IDirect3DPixelShader9 pShader)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DPixelShader9* pShaderPtr = &pShader)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DPixelShader9*, int>)LpVtbl[107])(@this, pShaderPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPixelShader(IDirect3DPixelShader9** ppShader)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DPixelShader9**, int>)LpVtbl[108])(@this, ppShader);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPixelShader(ref IDirect3DPixelShader9* ppShader)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DPixelShader9** ppShaderPtr = &ppShader)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, IDirect3DPixelShader9**, int>)LpVtbl[108])(@this, ppShaderPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPixelShaderConstantF(uint StartRegister, float* pConstantData, uint Vector4fCount)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[109])(@this, StartRegister, pConstantData, Vector4fCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPixelShaderConstantF(uint StartRegister, ref float pConstantData, uint Vector4fCount)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (float* pConstantDataPtr = &pConstantData)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[109])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPixelShaderConstantF(uint StartRegister, float* pConstantData, uint Vector4fCount)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[110])(@this, StartRegister, pConstantData, Vector4fCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPixelShaderConstantF(uint StartRegister, ref float pConstantData, uint Vector4fCount)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (float* pConstantDataPtr = &pConstantData)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, float*, uint, int>)LpVtbl[110])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPixelShaderConstantI(uint StartRegister, int* pConstantData, uint Vector4iCount)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[111])(@this, StartRegister, pConstantData, Vector4iCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPixelShaderConstantI(uint StartRegister, ref int pConstantData, uint Vector4iCount)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (int* pConstantDataPtr = &pConstantData)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[111])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPixelShaderConstantI(uint StartRegister, int* pConstantData, uint Vector4iCount)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[112])(@this, StartRegister, pConstantData, Vector4iCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPixelShaderConstantI(uint StartRegister, ref int pConstantData, uint Vector4iCount)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (int* pConstantDataPtr = &pConstantData)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[112])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPixelShaderConstantB(uint StartRegister, int* pConstantData, uint BoolCount)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[113])(@this, StartRegister, pConstantData, BoolCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPixelShaderConstantB(uint StartRegister, ref int pConstantData, uint BoolCount)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (int* pConstantDataPtr = &pConstantData)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[113])(@this, StartRegister, pConstantDataPtr, BoolCount);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPixelShaderConstantB(uint StartRegister, int* pConstantData, uint BoolCount)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[114])(@this, StartRegister, pConstantData, BoolCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPixelShaderConstantB(uint StartRegister, ref int pConstantData, uint BoolCount)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (int* pConstantDataPtr = &pConstantData)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, int*, uint, int>)LpVtbl[114])(@this, StartRegister, pConstantDataPtr, BoolCount);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DrawRectPatch(uint Handle, float* pNumSegs, RectpatchInfo* pRectPatchInfo)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, float*, RectpatchInfo*, int>)LpVtbl[115])(@this, Handle, pNumSegs, pRectPatchInfo);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DrawRectPatch(uint Handle, float* pNumSegs, ref RectpatchInfo pRectPatchInfo)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (RectpatchInfo* pRectPatchInfoPtr = &pRectPatchInfo)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, float*, RectpatchInfo*, int>)LpVtbl[115])(@this, Handle, pNumSegs, pRectPatchInfoPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DrawRectPatch(uint Handle, ref float pNumSegs, RectpatchInfo* pRectPatchInfo)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (float* pNumSegsPtr = &pNumSegs)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, float*, RectpatchInfo*, int>)LpVtbl[115])(@this, Handle, pNumSegsPtr, pRectPatchInfo);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int DrawRectPatch(uint Handle, ref float pNumSegs, ref RectpatchInfo pRectPatchInfo)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (float* pNumSegsPtr = &pNumSegs)
                {
                    fixed (RectpatchInfo* pRectPatchInfoPtr = &pRectPatchInfo)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, uint, float*, RectpatchInfo*, int>)LpVtbl[115])(@this, Handle, pNumSegsPtr, pRectPatchInfoPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DrawTriPatch(uint Handle, float* pNumSegs, TripatchInfo* pTriPatchInfo)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, float*, TripatchInfo*, int>)LpVtbl[116])(@this, Handle, pNumSegs, pTriPatchInfo);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DrawTriPatch(uint Handle, float* pNumSegs, ref TripatchInfo pTriPatchInfo)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (TripatchInfo* pTriPatchInfoPtr = &pTriPatchInfo)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, float*, TripatchInfo*, int>)LpVtbl[116])(@this, Handle, pNumSegs, pTriPatchInfoPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DrawTriPatch(uint Handle, ref float pNumSegs, TripatchInfo* pTriPatchInfo)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (float* pNumSegsPtr = &pNumSegs)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, uint, float*, TripatchInfo*, int>)LpVtbl[116])(@this, Handle, pNumSegsPtr, pTriPatchInfo);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int DrawTriPatch(uint Handle, ref float pNumSegs, ref TripatchInfo pTriPatchInfo)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (float* pNumSegsPtr = &pNumSegs)
                {
                    fixed (TripatchInfo* pTriPatchInfoPtr = &pTriPatchInfo)
                    {
                        ret = ((delegate* cdecl<IDirect3DDevice9*, uint, float*, TripatchInfo*, int>)LpVtbl[116])(@this, Handle, pNumSegsPtr, pTriPatchInfoPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int DeletePatch(uint Handle)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, uint, int>)LpVtbl[117])(@this, Handle);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateQuery(Querytype Type, IDirect3DQuery9** ppQuery)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DDevice9*, Querytype, IDirect3DQuery9**, int>)LpVtbl[118])(@this, Type, ppQuery);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateQuery(Querytype Type, ref IDirect3DQuery9* ppQuery)
        {
            fixed (IDirect3DDevice9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DQuery9** ppQueryPtr = &ppQuery)
                {
                    ret = ((delegate* cdecl<IDirect3DDevice9*, Querytype, IDirect3DQuery9**, int>)LpVtbl[118])(@this, Type, ppQueryPtr);
                }
                return ret;
            }
        }

    }
}
