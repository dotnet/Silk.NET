// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR
{
    /// <summary>
    /// A union containing all known graphics requirements structures, intended for use by binding creation
    /// abstractions.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct GraphicsRequirements
    {
        [FieldOffset(0)] public StructureType Type;
        
        [FieldOffset(0)] public GraphicsRequirementsD3D11KHR D3D11Khr;
        [FieldOffset(0)] public GraphicsRequirementsD3D12KHR D3D12Khr;
        [FieldOffset(0)] public GraphicsRequirementsOpenGLESKHR OpenGLESKhr;
        [FieldOffset(0)] public GraphicsRequirementsOpenGLKHR OpenGLKhr;
        [FieldOffset(0)] public GraphicsRequirementsVulkan2KHR Vulkan2Khr;
        [FieldOffset(0)] public GraphicsRequirementsVulkanKHR VulkanKhr;
        
        public static implicit operator GraphicsRequirements(GraphicsRequirementsD3D11KHR binding)
            => Unsafe.As<GraphicsRequirementsD3D11KHR, GraphicsRequirements>(ref binding);

        public static implicit operator GraphicsRequirements(GraphicsRequirementsD3D12KHR binding)
            => Unsafe.As<GraphicsRequirementsD3D12KHR, GraphicsRequirements>(ref binding);

        public static implicit operator GraphicsRequirements(GraphicsRequirementsOpenGLESKHR binding)
            => Unsafe.As<GraphicsRequirementsOpenGLESKHR, GraphicsRequirements>(ref binding);

        public static implicit operator GraphicsRequirements(GraphicsRequirementsOpenGLKHR binding)
            => Unsafe.As<GraphicsRequirementsOpenGLKHR, GraphicsRequirements>(ref binding);

        public static implicit operator GraphicsRequirements(GraphicsRequirementsVulkan2KHR binding)
            => Unsafe.As<GraphicsRequirementsVulkan2KHR, GraphicsRequirements>(ref binding);

        public static implicit operator GraphicsRequirements(GraphicsRequirementsVulkanKHR binding)
            => Unsafe.As<GraphicsRequirementsVulkanKHR, GraphicsRequirements>(ref binding);

        private readonly T Cast<T>(StructureType assertType)
        {
            if (Type != assertType)
            {
                static void Throw() => throw new InvalidCastException();
                Throw();
            }

            return Unsafe.As<GraphicsRequirements, T>(ref Unsafe.AsRef(in this));
        }
        
        public static explicit operator GraphicsRequirementsD3D11KHR(GraphicsRequirements requirements)
            => requirements.Cast<GraphicsRequirementsD3D11KHR>(StructureType.TypeGraphicsRequirementsD3D11Khr);
 
        public static explicit operator GraphicsRequirementsD3D12KHR(GraphicsRequirements requirements)
            => requirements.Cast<GraphicsRequirementsD3D12KHR>(StructureType.TypeGraphicsRequirementsD3D12Khr);
 
        public static explicit operator GraphicsRequirementsOpenGLESKHR(GraphicsRequirements requirements)
            => requirements.Cast<GraphicsRequirementsOpenGLESKHR>(StructureType.TypeGraphicsRequirementsOpenglESKhr);
 
        public static explicit operator GraphicsRequirementsOpenGLKHR(GraphicsRequirements requirements)
            => requirements.Cast<GraphicsRequirementsOpenGLKHR>(StructureType.TypeGraphicsRequirementsOpenglKhr);
 
        public static explicit operator GraphicsRequirementsVulkan2KHR(GraphicsRequirements requirements)
            => requirements.Cast<GraphicsRequirementsVulkan2KHR>(StructureType.TypeGraphicsRequirementsVulkan2Khr);
 
        public static explicit operator GraphicsRequirementsVulkanKHR(GraphicsRequirements requirements)
            => requirements.Cast<GraphicsRequirementsVulkanKHR>(StructureType.TypeGraphicsRequirementsVulkanKhr);
    }
}
