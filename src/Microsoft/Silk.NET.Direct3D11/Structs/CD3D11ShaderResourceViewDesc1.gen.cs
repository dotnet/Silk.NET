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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "CD3D11_SHADER_RESOURCE_VIEW_DESC1")]
    public unsafe partial struct CD3D11ShaderResourceViewDesc1
    {
        public CD3D11ShaderResourceViewDesc1
        (
            Silk.NET.DXGI.Format? format = null,
            Silk.NET.Core.Native.D3DSrvDimension? viewDimension = null,
            ShaderResourceViewDesc1Union? anonymous = null,
            BufferSrv? buffer = null,
            Tex1DSrv? texture1D = null,
            Tex1DArraySrv? texture1DArray = null,
            Tex2DSrv1? texture2D = null,
            Tex2DArraySrv1? texture2DArray = null,
            Tex2DmsSrv? texture2DMS = null,
            Tex2DmsArraySrv? texture2DMSArray = null,
            Tex3DSrv? texture3D = null,
            TexcubeSrv? textureCube = null,
            TexcubeArraySrv? textureCubeArray = null,
            BufferexSrv? bufferEx = null
        ) : this()
        {
            if (format is not null)
            {
                Format = format.Value;
            }

            if (viewDimension is not null)
            {
                ViewDimension = viewDimension.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (buffer is not null)
            {
                Buffer = buffer.Value;
            }

            if (texture1D is not null)
            {
                Texture1D = texture1D.Value;
            }

            if (texture1DArray is not null)
            {
                Texture1DArray = texture1DArray.Value;
            }

            if (texture2D is not null)
            {
                Texture2D = texture2D.Value;
            }

            if (texture2DArray is not null)
            {
                Texture2DArray = texture2DArray.Value;
            }

            if (texture2DMS is not null)
            {
                Texture2DMS = texture2DMS.Value;
            }

            if (texture2DMSArray is not null)
            {
                Texture2DMSArray = texture2DMSArray.Value;
            }

            if (texture3D is not null)
            {
                Texture3D = texture3D.Value;
            }

            if (textureCube is not null)
            {
                TextureCube = textureCube.Value;
            }

            if (textureCubeArray is not null)
            {
                TextureCubeArray = textureCubeArray.Value;
            }

            if (bufferEx is not null)
            {
                BufferEx = bufferEx.Value;
            }
        }


        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.DXGI.Format Format;

        [NativeName("Type", "D3D11_SRV_DIMENSION")]
        [NativeName("Type.Name", "D3D11_SRV_DIMENSION")]
        [NativeName("Name", "ViewDimension")]
        public Silk.NET.Core.Native.D3DSrvDimension ViewDimension;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d11_3_L886_C5")]
        [NativeName("Name", "anonymous1")]
        public ShaderResourceViewDesc1Union Anonymous;
        public BufferSrv Buffer
        {
            get => Anonymous.Buffer;
            set => Anonymous.Buffer = value;
        }

        public Tex1DSrv Texture1D
        {
            get => Anonymous.Texture1D;
            set => Anonymous.Texture1D = value;
        }

        public Tex1DArraySrv Texture1DArray
        {
            get => Anonymous.Texture1DArray;
            set => Anonymous.Texture1DArray = value;
        }

        public Tex2DSrv1 Texture2D
        {
            get => Anonymous.Texture2D;
            set => Anonymous.Texture2D = value;
        }

        public Tex2DArraySrv1 Texture2DArray
        {
            get => Anonymous.Texture2DArray;
            set => Anonymous.Texture2DArray = value;
        }

        public Tex2DmsSrv Texture2DMS
        {
            get => Anonymous.Texture2DMS;
            set => Anonymous.Texture2DMS = value;
        }

        public Tex2DmsArraySrv Texture2DMSArray
        {
            get => Anonymous.Texture2DMSArray;
            set => Anonymous.Texture2DMSArray = value;
        }

        public Tex3DSrv Texture3D
        {
            get => Anonymous.Texture3D;
            set => Anonymous.Texture3D = value;
        }

        public TexcubeSrv TextureCube
        {
            get => Anonymous.TextureCube;
            set => Anonymous.TextureCube = value;
        }

        public TexcubeArraySrv TextureCubeArray
        {
            get => Anonymous.TextureCubeArray;
            set => Anonymous.TextureCubeArray = value;
        }

        public BufferexSrv BufferEx
        {
            get => Anonymous.BufferEx;
            set => Anonymous.BufferEx = value;
        }

    }
}
