// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

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
            if (window.Win32.HasValue)
            {
                return factory->CreateSwapChainForHwnd
                    (pDevice, window.Win32.Value.Hwnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
            }

            if (window.WinRT.HasValue)
            {
                return factory->CreateSwapChainForCoreWindow
                    (pDevice, (IUnknown*) window.WinRT.Value, pDesc, pRestrictToOutput, ppSwapChain);
            }

            Throw();
            return -1;

            static void Throw() => throw new InvalidOperationException
                ("The given window is neither a Win32 window nor a WinRT CoreWindow");
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
