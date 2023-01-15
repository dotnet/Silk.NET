// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;

namespace Silk.NET.DXGI
{
    public static class NativeWindowExtensions
    {
        public static unsafe int CreateDxgiSwapchain
        (
            this INativeWindow window,
            IDXGIFactory2* factory,
            IUnknown* pDevice,
            SwapChainDesc1* pDesc,
            SwapChainFullscreenDesc* pFullscreenDesc,
            IDXGIOutput* pRestrictToOutput,
            IDXGISwapChain1** ppSwapChain
        )
        {
            if (window.WinRT.HasValue)
            {
                return factory->CreateSwapChainForCoreWindow
                    (pDevice, (IUnknown*) window.WinRT.Value, pDesc, pRestrictToOutput, ppSwapChain);
            }
                    
            if (window.DXHandle.HasValue) 
            {
                return factory->CreateSwapChainForHwnd
                    (pDevice, window.DXHandle.Value, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChain); 
            }

            Throw();
            return -1;

            static void Throw() => throw new InvalidOperationException
                ("The given window has neither a valid DXHandle nor a valid WinRT CoreWindow.");
        }

        public static unsafe int CreateDxgiSwapchain
        (
            this INativeWindowSource window,
            IDXGIFactory2* factory,
            IUnknown* pDevice,
            SwapChainDesc1* pDesc,
            SwapChainFullscreenDesc* pFullscreenDesc,
            IDXGIOutput* pRestrictToOutput,
            IDXGISwapChain1** ppSwapChain
        ) => window.Native.CreateDxgiSwapchain
            (factory, pDevice, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
    }
}
