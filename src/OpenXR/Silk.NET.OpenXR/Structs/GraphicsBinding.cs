// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR
{
    /// <summary>
    /// A union containing known graphics bindings, intended for use by graphics binding creation abstractions.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct GraphicsBinding
    {
        [FieldOffset(0)] public StructureType Type;

        [FieldOffset(0)] public GraphicsBindingD3D11KHR D3D11Khr;
        [FieldOffset(0)] public GraphicsBindingD3D12KHR D3D12Khr;
        [FieldOffset(0)] public GraphicsBindingEGLMNDX EglMndx;
        [FieldOffset(0)] public GraphicsBindingOpenGLESAndroidKHR OpenGLESAndroidKhr;
        [FieldOffset(0)] public GraphicsBindingOpenGLWaylandKHR OpenGLWaylandKhr;
        [FieldOffset(0)] public GraphicsBindingOpenGLWin32KHR OpenGLWin32Khr;
        [FieldOffset(0)] public GraphicsBindingOpenGLXcbKHR OpenGLXcbKhr;
        [FieldOffset(0)] public GraphicsBindingOpenGLXlibKHR OpenGLXlibKhr;
        [FieldOffset(0)] public GraphicsBindingVulkan2KHR Vulkan2Khr;
        [FieldOffset(0)] public GraphicsBindingVulkanKHR VulkanKhr;
        
        public static implicit operator GraphicsBinding(GraphicsBindingD3D11KHR binding)
            => Unsafe.As<GraphicsBindingD3D11KHR, GraphicsBinding>(ref binding);

        public static implicit operator GraphicsBinding(GraphicsBindingD3D12KHR binding)
            => Unsafe.As<GraphicsBindingD3D12KHR, GraphicsBinding>(ref binding);

        public static implicit operator GraphicsBinding(GraphicsBindingEGLMNDX binding)
            => Unsafe.As<GraphicsBindingEGLMNDX, GraphicsBinding>(ref binding);

        public static implicit operator GraphicsBinding(GraphicsBindingOpenGLESAndroidKHR binding)
            => Unsafe.As<GraphicsBindingOpenGLESAndroidKHR, GraphicsBinding>(ref binding);

        public static implicit operator GraphicsBinding(GraphicsBindingOpenGLWaylandKHR binding)
            => Unsafe.As<GraphicsBindingOpenGLWaylandKHR, GraphicsBinding>(ref binding);

        public static implicit operator GraphicsBinding(GraphicsBindingOpenGLWin32KHR binding)
            => Unsafe.As<GraphicsBindingOpenGLWin32KHR, GraphicsBinding>(ref binding);

        public static implicit operator GraphicsBinding(GraphicsBindingOpenGLXcbKHR binding)
            => Unsafe.As<GraphicsBindingOpenGLXcbKHR, GraphicsBinding>(ref binding);

        public static implicit operator GraphicsBinding(GraphicsBindingOpenGLXlibKHR binding)
            => Unsafe.As<GraphicsBindingOpenGLXlibKHR, GraphicsBinding>(ref binding);

        public static implicit operator GraphicsBinding(GraphicsBindingVulkan2KHR binding)
            => Unsafe.As<GraphicsBindingVulkan2KHR, GraphicsBinding>(ref binding);

        public static implicit operator GraphicsBinding(GraphicsBindingVulkanKHR binding)
            => Unsafe.As<GraphicsBindingVulkanKHR, GraphicsBinding>(ref binding);

        private readonly T Cast<T>(StructureType assertType)
        {
            if (Type != assertType)
            {
                static void Throw() => throw new InvalidCastException();
                Throw();
            }

            return Unsafe.As<GraphicsBinding, T>(ref Unsafe.AsRef(in this));
        }
        
        public static explicit operator GraphicsBindingD3D11KHR(GraphicsBinding binding)
            => binding.Cast<GraphicsBindingD3D11KHR>(StructureType.TypeGraphicsBindingD3D11Khr);

        public static explicit operator GraphicsBindingD3D12KHR(GraphicsBinding binding)
            => binding.Cast<GraphicsBindingD3D12KHR>(StructureType.TypeGraphicsBindingD3D12Khr);

        public static explicit operator GraphicsBindingEGLMNDX(GraphicsBinding binding)
            => binding.Cast<GraphicsBindingEGLMNDX>(StructureType.TypeGraphicsBindingEglMndx);

        public static explicit operator GraphicsBindingOpenGLESAndroidKHR(GraphicsBinding binding)
            => binding.Cast<GraphicsBindingOpenGLESAndroidKHR>(StructureType.TypeGraphicsBindingOpenglESAndroidKhr);

        public static explicit operator GraphicsBindingOpenGLWaylandKHR(GraphicsBinding binding)
            => binding.Cast<GraphicsBindingOpenGLWaylandKHR>(StructureType.TypeGraphicsBindingOpenglWaylandKhr);

        public static explicit operator GraphicsBindingOpenGLWin32KHR(GraphicsBinding binding)
            => binding.Cast<GraphicsBindingOpenGLWin32KHR>(StructureType.TypeGraphicsBindingOpenglWin32Khr);

        public static explicit operator GraphicsBindingOpenGLXcbKHR(GraphicsBinding binding)
            => binding.Cast<GraphicsBindingOpenGLXcbKHR>(StructureType.TypeGraphicsBindingOpenglXcbKhr);

        public static explicit operator GraphicsBindingOpenGLXlibKHR(GraphicsBinding binding)
            => binding.Cast<GraphicsBindingOpenGLXlibKHR>(StructureType.TypeGraphicsBindingOpenglXlibKhr);

        public static explicit operator GraphicsBindingVulkan2KHR(GraphicsBinding binding)
            => binding.Cast<GraphicsBindingVulkan2KHR>(StructureType.TypeGraphicsBindingVulkan2Khr);

        public static explicit operator GraphicsBindingVulkanKHR(GraphicsBinding binding)
            => binding.Cast<GraphicsBindingVulkanKHR>(StructureType.TypeGraphicsBindingVulkanKhr);
    }
}
