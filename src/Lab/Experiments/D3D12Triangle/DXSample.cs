// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DXSample.h in https://github.com/Microsoft/DirectX-Graphics-Samples
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.IO;
using System.Numerics;
using Microsoft.Extensions.Logging;
using Silk.NET.DXGI;
using Silk.NET.Maths;
using Silk.NET.Windowing;
using Ultz.Extensions.Logging;

namespace D3D12Triangle
{
    public abstract unsafe class DXSample : IDisposable
    {
        private readonly string _name;
        private Format _backBufferFormat;
        private Vector4 _backgroundColor;
        private Format _depthBufferFormat;
        private float _dpi;
        private uint _frameCount;
        private uint _frameIndex;
        private bool _useWarpDevice;
        private IWindow _window;
        private ILogger _logger;
        private ILoggerProvider _loggerProvider;
        private DXGI _dxgi;

        protected DXSample(string name)
        {
            _name = name;
            _loggerProvider = new UltzLoggerProvider();
            _logger = _loggerProvider.CreateLogger(name);
        }

        ~DXSample()
        {
            Dispose(isDisposing: false);
        }

        public float AspectRatio => Size.X / (float) Size.Y;

        public string AssetsPath => AppContext.BaseDirectory;

        public Format BackBufferFormat => _backBufferFormat;

        public Vector4 BackgroundColor
        {
            get { return _backgroundColor; }

            set { _backgroundColor = value; }
        }

        public Format DepthBufferFormat => _depthBufferFormat;

        public float Dpi => _dpi;

        public uint FrameCount => _frameCount;

        public ref uint FrameIndex => ref _frameIndex;

        public IWindow Window => _window;

        public bool IsWindowVisible => Window.IsVisible;

        public string Name => _name;

        public Vector2D<int> Size => Window.Size;

        public bool UseWarpDevice => _useWarpDevice;

        public ILogger Log => _logger;

        public DXGI Dxgi => _dxgi;

        public void Dispose()
        {
            Dispose(isDisposing: true);
            GC.SuppressFinalize(this);
        }

        public virtual void OnDestroy()
        {
            DestroyWindowSizeDependentResources();
            DestroyDeviceDependentResources();
        }

        public void OnInit
        (
            Format backBufferFormat,
            Vector4 backgroundColor,
            Format depthBufferFormat,
            float dpi,
            uint frameCount,
            IWindow window,
            bool useWarpDevice
        )
        {
            _dxgi = DXGI.GetApi(window);
            _backBufferFormat = (backBufferFormat != Format.FormatUnknown)
                ? backBufferFormat
                : Format.FormatR8G8B8A8Unorm;
            _backgroundColor = backgroundColor;
            _depthBufferFormat =
                (depthBufferFormat != Format.FormatUnknown) ? depthBufferFormat : Format.FormatD32Float;
            _dpi = dpi;
            _frameCount = Math.Max(frameCount, 1);
            _window = window;
            _useWarpDevice = useWarpDevice;

            CreateDeviceDependentResources();
            CreateWindowSizeDependentResources();
        }

        public virtual void OnKeyDown(int key)
        {
        }

        public virtual void OnKeyUp(int key)
        {
        }

        public abstract void OnRender();

        public void OnDpiChanged(float dpi)
        {
            _dpi = dpi;
            OnWindowSizeChanged(Size);
        }

        public void OnWindowSizeChanged(Vector2D<int> size)
        {
            if (size != Size)
            {
                DestroyWindowSizeDependentResources();
                CreateWindowSizeDependentResources();
            }
        }

        public abstract void OnUpdate();

        public override string ToString()
        {
            return Name;
        }

        protected abstract void CreateDeviceDependentResources();

        protected abstract void CreateWindowSizeDependentResources();

        protected abstract void DestroyDeviceDependentResources();

        protected abstract void DestroyWindowSizeDependentResources();

        protected virtual void Dispose(bool isDisposing) => OnDestroy();

        // Helper function for resolving the full path of assets
        protected string GetAssetFullPath(string assetName) => Path.Combine(AssetsPath, assetName);

        // Helper function for acquiring the first available hardware adapter that supports the required Direct3D version.
        // If no such adapter can be found, returns null.
        protected IDXGIAdapter1* GetHardwareAdapter(IDXGIFactory1* pFactory)
        {
            IDXGIAdapter1* adapter;

            // TODO DXGI_ERROR_NOT_FOUND is 0x887A0002 - maybe we should add Winerror.h somewhere in Silk.NET.Core?
            const int errorNotFound = unchecked((int) 0x887A0002);

            for (var adapterIndex = 0u;
                errorNotFound != pFactory->EnumAdapters1(adapterIndex, &adapter);
                ++adapterIndex)
            {
                AdapterDesc1 desc;
                _ = adapter->GetDesc1(&desc);

                if ((desc.Flags & (uint) AdapterFlag.Software) != 0)
                {
                    // Don't select the Basic Render Driver adapter.
                    // If you want a software adapter, pass in "/warp" on the command line.
                    continue;
                }

                // Check to see if the adapter supports the required Direct3D version, but don't create the
                // actual device yet.
                if (SupportsRequiredDirect3DVersion(adapter))
                {
                    break;
                }
            }

            return adapter;
        }

        protected abstract bool SupportsRequiredDirect3DVersion(IDXGIAdapter1* adapter);
    }
}
