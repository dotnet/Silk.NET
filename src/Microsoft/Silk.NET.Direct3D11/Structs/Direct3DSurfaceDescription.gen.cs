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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "Direct3DSurfaceDescription")]
    public unsafe partial struct Direct3DSurfaceDescription
    {
        public Direct3DSurfaceDescription
        (
            int? width = null,
            int? height = null,
            Silk.NET.DXGI.DirectXPixelFormat? format = null,
            Direct3DMultisampleDescription? multisampleDescription = null
        ) : this()
        {
            if (width is not null)
            {
                Width = width.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (format is not null)
            {
                Format = format.Value;
            }

            if (multisampleDescription is not null)
            {
                MultisampleDescription = multisampleDescription.Value;
            }
        }


        [NativeName("Type", "INT32")]
        [NativeName("Type.Name", "INT32")]
        [NativeName("Name", "Width")]
        public int Width;

        [NativeName("Type", "INT32")]
        [NativeName("Type.Name", "INT32")]
        [NativeName("Name", "Height")]
        public int Height;

        [NativeName("Type", "ABI::Windows::Graphics::DirectX::DirectXPixelFormat")]
        [NativeName("Type.Name", "ABI::Windows::Graphics::DirectX::DirectXPixelFormat")]
        [NativeName("Name", "Format")]
        public Silk.NET.DXGI.DirectXPixelFormat Format;

        [NativeName("Type", "ABI::Windows::Graphics::DirectX::Direct3D11::Direct3DMultisampleDescription")]
        [NativeName("Type.Name", "ABI::Windows::Graphics::DirectX::Direct3D11::Direct3DMultisampleDescription")]
        [NativeName("Name", "MultisampleDescription")]
        public Direct3DMultisampleDescription MultisampleDescription;
    }
}
