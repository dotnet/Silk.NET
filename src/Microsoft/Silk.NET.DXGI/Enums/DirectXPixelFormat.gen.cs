// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DirectXPixelFormat")]
    public enum DirectXPixelFormat : int
    {
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "DirectXPixelFormat_Unknown")]
        DirectXPixelFormatUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"R32G32B32A32Typeless\"")]
        [NativeName("Name", "DirectXPixelFormat_R32G32B32A32Typeless")]
        DirectXPixelFormatR32G32B32A32Typeless = 0x1,
        [Obsolete("Deprecated in favour of \"R32G32B32A32float\"")]
        [NativeName("Name", "DirectXPixelFormat_R32G32B32A32Float")]
        DirectXPixelFormatR32G32B32A32float = 0x2,
        [Obsolete("Deprecated in favour of \"R32G32B32A32UInt\"")]
        [NativeName("Name", "DirectXPixelFormat_R32G32B32A32UInt")]
        DirectXPixelFormatR32G32B32A32uint = 0x3,
        [Obsolete("Deprecated in favour of \"R32G32B32A32int\"")]
        [NativeName("Name", "DirectXPixelFormat_R32G32B32A32Int")]
        DirectXPixelFormatR32G32B32A32int = 0x4,
        [Obsolete("Deprecated in favour of \"R32G32B32Typeless\"")]
        [NativeName("Name", "DirectXPixelFormat_R32G32B32Typeless")]
        DirectXPixelFormatR32G32B32Typeless = 0x5,
        [Obsolete("Deprecated in favour of \"R32G32B32float\"")]
        [NativeName("Name", "DirectXPixelFormat_R32G32B32Float")]
        DirectXPixelFormatR32G32B32float = 0x6,
        [Obsolete("Deprecated in favour of \"R32G32B32UInt\"")]
        [NativeName("Name", "DirectXPixelFormat_R32G32B32UInt")]
        DirectXPixelFormatR32G32B32uint = 0x7,
        [Obsolete("Deprecated in favour of \"R32G32B32int\"")]
        [NativeName("Name", "DirectXPixelFormat_R32G32B32Int")]
        DirectXPixelFormatR32G32B32int = 0x8,
        [Obsolete("Deprecated in favour of \"R16G16B16A16Typeless\"")]
        [NativeName("Name", "DirectXPixelFormat_R16G16B16A16Typeless")]
        DirectXPixelFormatR16G16B16A16Typeless = 0x9,
        [Obsolete("Deprecated in favour of \"R16G16B16A16float\"")]
        [NativeName("Name", "DirectXPixelFormat_R16G16B16A16Float")]
        DirectXPixelFormatR16G16B16A16float = 0xA,
        [Obsolete("Deprecated in favour of \"R16G16B16A16UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_R16G16B16A16UIntNormalized")]
        DirectXPixelFormatR16G16B16A16uintNormalized = 0xB,
        [Obsolete("Deprecated in favour of \"R16G16B16A16UInt\"")]
        [NativeName("Name", "DirectXPixelFormat_R16G16B16A16UInt")]
        DirectXPixelFormatR16G16B16A16uint = 0xC,
        [Obsolete("Deprecated in favour of \"R16G16B16A16intNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_R16G16B16A16IntNormalized")]
        DirectXPixelFormatR16G16B16A16intNormalized = 0xD,
        [Obsolete("Deprecated in favour of \"R16G16B16A16int\"")]
        [NativeName("Name", "DirectXPixelFormat_R16G16B16A16Int")]
        DirectXPixelFormatR16G16B16A16int = 0xE,
        [Obsolete("Deprecated in favour of \"R32G32Typeless\"")]
        [NativeName("Name", "DirectXPixelFormat_R32G32Typeless")]
        DirectXPixelFormatR32G32Typeless = 0xF,
        [Obsolete("Deprecated in favour of \"R32G32float\"")]
        [NativeName("Name", "DirectXPixelFormat_R32G32Float")]
        DirectXPixelFormatR32G32float = 0x10,
        [Obsolete("Deprecated in favour of \"R32G32UInt\"")]
        [NativeName("Name", "DirectXPixelFormat_R32G32UInt")]
        DirectXPixelFormatR32G32uint = 0x11,
        [Obsolete("Deprecated in favour of \"R32G32int\"")]
        [NativeName("Name", "DirectXPixelFormat_R32G32Int")]
        DirectXPixelFormatR32G32int = 0x12,
        [Obsolete("Deprecated in favour of \"R32G8X24Typeless\"")]
        [NativeName("Name", "DirectXPixelFormat_R32G8X24Typeless")]
        DirectXPixelFormatR32G8X24Typeless = 0x13,
        [Obsolete("Deprecated in favour of \"D32floatS8X24UInt\"")]
        [NativeName("Name", "DirectXPixelFormat_D32FloatS8X24UInt")]
        DirectXPixelFormatD32floatS8X24uint = 0x14,
        [Obsolete("Deprecated in favour of \"R32floatX8X24Typeless\"")]
        [NativeName("Name", "DirectXPixelFormat_R32FloatX8X24Typeless")]
        DirectXPixelFormatR32floatX8X24Typeless = 0x15,
        [Obsolete("Deprecated in favour of \"X32TypelessG8X24UInt\"")]
        [NativeName("Name", "DirectXPixelFormat_X32TypelessG8X24UInt")]
        DirectXPixelFormatX32TypelessG8X24uint = 0x16,
        [Obsolete("Deprecated in favour of \"R10G10B10A2Typeless\"")]
        [NativeName("Name", "DirectXPixelFormat_R10G10B10A2Typeless")]
        DirectXPixelFormatR10G10B10A2Typeless = 0x17,
        [Obsolete("Deprecated in favour of \"R10G10B10A2UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_R10G10B10A2UIntNormalized")]
        DirectXPixelFormatR10G10B10A2uintNormalized = 0x18,
        [Obsolete("Deprecated in favour of \"R10G10B10A2UInt\"")]
        [NativeName("Name", "DirectXPixelFormat_R10G10B10A2UInt")]
        DirectXPixelFormatR10G10B10A2uint = 0x19,
        [Obsolete("Deprecated in favour of \"R11G11B10float\"")]
        [NativeName("Name", "DirectXPixelFormat_R11G11B10Float")]
        DirectXPixelFormatR11G11B10float = 0x1A,
        [Obsolete("Deprecated in favour of \"R8G8B8A8Typeless\"")]
        [NativeName("Name", "DirectXPixelFormat_R8G8B8A8Typeless")]
        DirectXPixelFormatR8G8B8A8Typeless = 0x1B,
        [Obsolete("Deprecated in favour of \"R8G8B8A8UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_R8G8B8A8UIntNormalized")]
        DirectXPixelFormatR8G8B8A8uintNormalized = 0x1C,
        [Obsolete("Deprecated in favour of \"R8G8B8A8UIntNormalizedSrgb\"")]
        [NativeName("Name", "DirectXPixelFormat_R8G8B8A8UIntNormalizedSrgb")]
        DirectXPixelFormatR8G8B8A8uintNormalizedSrgb = 0x1D,
        [Obsolete("Deprecated in favour of \"R8G8B8A8UInt\"")]
        [NativeName("Name", "DirectXPixelFormat_R8G8B8A8UInt")]
        DirectXPixelFormatR8G8B8A8uint = 0x1E,
        [Obsolete("Deprecated in favour of \"R8G8B8A8intNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_R8G8B8A8IntNormalized")]
        DirectXPixelFormatR8G8B8A8intNormalized = 0x1F,
        [Obsolete("Deprecated in favour of \"R8G8B8A8int\"")]
        [NativeName("Name", "DirectXPixelFormat_R8G8B8A8Int")]
        DirectXPixelFormatR8G8B8A8int = 0x20,
        [Obsolete("Deprecated in favour of \"R16G16Typeless\"")]
        [NativeName("Name", "DirectXPixelFormat_R16G16Typeless")]
        DirectXPixelFormatR16G16Typeless = 0x21,
        [Obsolete("Deprecated in favour of \"R16G16float\"")]
        [NativeName("Name", "DirectXPixelFormat_R16G16Float")]
        DirectXPixelFormatR16G16float = 0x22,
        [Obsolete("Deprecated in favour of \"R16G16UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_R16G16UIntNormalized")]
        DirectXPixelFormatR16G16uintNormalized = 0x23,
        [Obsolete("Deprecated in favour of \"R16G16UInt\"")]
        [NativeName("Name", "DirectXPixelFormat_R16G16UInt")]
        DirectXPixelFormatR16G16uint = 0x24,
        [Obsolete("Deprecated in favour of \"R16G16intNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_R16G16IntNormalized")]
        DirectXPixelFormatR16G16intNormalized = 0x25,
        [Obsolete("Deprecated in favour of \"R16G16int\"")]
        [NativeName("Name", "DirectXPixelFormat_R16G16Int")]
        DirectXPixelFormatR16G16int = 0x26,
        [Obsolete("Deprecated in favour of \"R32Typeless\"")]
        [NativeName("Name", "DirectXPixelFormat_R32Typeless")]
        DirectXPixelFormatR32Typeless = 0x27,
        [Obsolete("Deprecated in favour of \"D32float\"")]
        [NativeName("Name", "DirectXPixelFormat_D32Float")]
        DirectXPixelFormatD32float = 0x28,
        [Obsolete("Deprecated in favour of \"R32float\"")]
        [NativeName("Name", "DirectXPixelFormat_R32Float")]
        DirectXPixelFormatR32float = 0x29,
        [Obsolete("Deprecated in favour of \"R32UInt\"")]
        [NativeName("Name", "DirectXPixelFormat_R32UInt")]
        DirectXPixelFormatR32uint = 0x2A,
        [Obsolete("Deprecated in favour of \"R32int\"")]
        [NativeName("Name", "DirectXPixelFormat_R32Int")]
        DirectXPixelFormatR32int = 0x2B,
        [Obsolete("Deprecated in favour of \"R24G8Typeless\"")]
        [NativeName("Name", "DirectXPixelFormat_R24G8Typeless")]
        DirectXPixelFormatR24G8Typeless = 0x2C,
        [Obsolete("Deprecated in favour of \"D24UIntNormalizedS8UInt\"")]
        [NativeName("Name", "DirectXPixelFormat_D24UIntNormalizedS8UInt")]
        DirectXPixelFormatD24uintNormalizedS8uint = 0x2D,
        [Obsolete("Deprecated in favour of \"R24UIntNormalizedX8Typeless\"")]
        [NativeName("Name", "DirectXPixelFormat_R24UIntNormalizedX8Typeless")]
        DirectXPixelFormatR24uintNormalizedX8Typeless = 0x2E,
        [Obsolete("Deprecated in favour of \"X24TypelessG8UInt\"")]
        [NativeName("Name", "DirectXPixelFormat_X24TypelessG8UInt")]
        DirectXPixelFormatX24TypelessG8uint = 0x2F,
        [Obsolete("Deprecated in favour of \"R8G8Typeless\"")]
        [NativeName("Name", "DirectXPixelFormat_R8G8Typeless")]
        DirectXPixelFormatR8G8Typeless = 0x30,
        [Obsolete("Deprecated in favour of \"R8G8UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_R8G8UIntNormalized")]
        DirectXPixelFormatR8G8uintNormalized = 0x31,
        [Obsolete("Deprecated in favour of \"R8G8UInt\"")]
        [NativeName("Name", "DirectXPixelFormat_R8G8UInt")]
        DirectXPixelFormatR8G8uint = 0x32,
        [Obsolete("Deprecated in favour of \"R8G8intNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_R8G8IntNormalized")]
        DirectXPixelFormatR8G8intNormalized = 0x33,
        [Obsolete("Deprecated in favour of \"R8G8int\"")]
        [NativeName("Name", "DirectXPixelFormat_R8G8Int")]
        DirectXPixelFormatR8G8int = 0x34,
        [Obsolete("Deprecated in favour of \"R16Typeless\"")]
        [NativeName("Name", "DirectXPixelFormat_R16Typeless")]
        DirectXPixelFormatR16Typeless = 0x35,
        [Obsolete("Deprecated in favour of \"R16float\"")]
        [NativeName("Name", "DirectXPixelFormat_R16Float")]
        DirectXPixelFormatR16float = 0x36,
        [Obsolete("Deprecated in favour of \"D16UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_D16UIntNormalized")]
        DirectXPixelFormatD16uintNormalized = 0x37,
        [Obsolete("Deprecated in favour of \"R16UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_R16UIntNormalized")]
        DirectXPixelFormatR16uintNormalized = 0x38,
        [Obsolete("Deprecated in favour of \"R16UInt\"")]
        [NativeName("Name", "DirectXPixelFormat_R16UInt")]
        DirectXPixelFormatR16uint = 0x39,
        [Obsolete("Deprecated in favour of \"R16intNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_R16IntNormalized")]
        DirectXPixelFormatR16intNormalized = 0x3A,
        [Obsolete("Deprecated in favour of \"R16int\"")]
        [NativeName("Name", "DirectXPixelFormat_R16Int")]
        DirectXPixelFormatR16int = 0x3B,
        [Obsolete("Deprecated in favour of \"R8Typeless\"")]
        [NativeName("Name", "DirectXPixelFormat_R8Typeless")]
        DirectXPixelFormatR8Typeless = 0x3C,
        [Obsolete("Deprecated in favour of \"R8UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_R8UIntNormalized")]
        DirectXPixelFormatR8uintNormalized = 0x3D,
        [Obsolete("Deprecated in favour of \"R8UInt\"")]
        [NativeName("Name", "DirectXPixelFormat_R8UInt")]
        DirectXPixelFormatR8uint = 0x3E,
        [Obsolete("Deprecated in favour of \"R8intNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_R8IntNormalized")]
        DirectXPixelFormatR8intNormalized = 0x3F,
        [Obsolete("Deprecated in favour of \"R8int\"")]
        [NativeName("Name", "DirectXPixelFormat_R8Int")]
        DirectXPixelFormatR8int = 0x40,
        [Obsolete("Deprecated in favour of \"A8UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_A8UIntNormalized")]
        DirectXPixelFormatA8uintNormalized = 0x41,
        [Obsolete("Deprecated in favour of \"R1UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_R1UIntNormalized")]
        DirectXPixelFormatR1uintNormalized = 0x42,
        [Obsolete("Deprecated in favour of \"R9G9B9E5SharedExponent\"")]
        [NativeName("Name", "DirectXPixelFormat_R9G9B9E5SharedExponent")]
        DirectXPixelFormatR9G9B9E5SharedExponent = 0x43,
        [Obsolete("Deprecated in favour of \"R8G8B8G8UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_R8G8B8G8UIntNormalized")]
        DirectXPixelFormatR8G8B8G8uintNormalized = 0x44,
        [Obsolete("Deprecated in favour of \"G8R8G8B8UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_G8R8G8B8UIntNormalized")]
        DirectXPixelFormatG8R8G8B8uintNormalized = 0x45,
        [Obsolete("Deprecated in favour of \"BC1Typeless\"")]
        [NativeName("Name", "DirectXPixelFormat_BC1Typeless")]
        DirectXPixelFormatBC1Typeless = 0x46,
        [Obsolete("Deprecated in favour of \"BC1UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_BC1UIntNormalized")]
        DirectXPixelFormatBC1uintNormalized = 0x47,
        [Obsolete("Deprecated in favour of \"BC1UIntNormalizedSrgb\"")]
        [NativeName("Name", "DirectXPixelFormat_BC1UIntNormalizedSrgb")]
        DirectXPixelFormatBC1uintNormalizedSrgb = 0x48,
        [Obsolete("Deprecated in favour of \"BC2Typeless\"")]
        [NativeName("Name", "DirectXPixelFormat_BC2Typeless")]
        DirectXPixelFormatBC2Typeless = 0x49,
        [Obsolete("Deprecated in favour of \"BC2UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_BC2UIntNormalized")]
        DirectXPixelFormatBC2uintNormalized = 0x4A,
        [Obsolete("Deprecated in favour of \"BC2UIntNormalizedSrgb\"")]
        [NativeName("Name", "DirectXPixelFormat_BC2UIntNormalizedSrgb")]
        DirectXPixelFormatBC2uintNormalizedSrgb = 0x4B,
        [Obsolete("Deprecated in favour of \"BC3Typeless\"")]
        [NativeName("Name", "DirectXPixelFormat_BC3Typeless")]
        DirectXPixelFormatBC3Typeless = 0x4C,
        [Obsolete("Deprecated in favour of \"BC3UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_BC3UIntNormalized")]
        DirectXPixelFormatBC3uintNormalized = 0x4D,
        [Obsolete("Deprecated in favour of \"BC3UIntNormalizedSrgb\"")]
        [NativeName("Name", "DirectXPixelFormat_BC3UIntNormalizedSrgb")]
        DirectXPixelFormatBC3uintNormalizedSrgb = 0x4E,
        [Obsolete("Deprecated in favour of \"BC4Typeless\"")]
        [NativeName("Name", "DirectXPixelFormat_BC4Typeless")]
        DirectXPixelFormatBC4Typeless = 0x4F,
        [Obsolete("Deprecated in favour of \"BC4UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_BC4UIntNormalized")]
        DirectXPixelFormatBC4uintNormalized = 0x50,
        [Obsolete("Deprecated in favour of \"BC4intNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_BC4IntNormalized")]
        DirectXPixelFormatBC4intNormalized = 0x51,
        [Obsolete("Deprecated in favour of \"BC5Typeless\"")]
        [NativeName("Name", "DirectXPixelFormat_BC5Typeless")]
        DirectXPixelFormatBC5Typeless = 0x52,
        [Obsolete("Deprecated in favour of \"BC5UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_BC5UIntNormalized")]
        DirectXPixelFormatBC5uintNormalized = 0x53,
        [Obsolete("Deprecated in favour of \"BC5intNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_BC5IntNormalized")]
        DirectXPixelFormatBC5intNormalized = 0x54,
        [Obsolete("Deprecated in favour of \"B5G6R5UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_B5G6R5UIntNormalized")]
        DirectXPixelFormatB5G6R5uintNormalized = 0x55,
        [Obsolete("Deprecated in favour of \"B5G5R5A1UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_B5G5R5A1UIntNormalized")]
        DirectXPixelFormatB5G5R5A1uintNormalized = 0x56,
        [Obsolete("Deprecated in favour of \"B8G8R8A8UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_B8G8R8A8UIntNormalized")]
        DirectXPixelFormatB8G8R8A8uintNormalized = 0x57,
        [Obsolete("Deprecated in favour of \"B8G8R8X8UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_B8G8R8X8UIntNormalized")]
        DirectXPixelFormatB8G8R8X8uintNormalized = 0x58,
        [Obsolete("Deprecated in favour of \"R10G10B10XRBiasA2UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_R10G10B10XRBiasA2UIntNormalized")]
        DirectXPixelFormatR10G10B10XrbiasA2uintNormalized = 0x59,
        [Obsolete("Deprecated in favour of \"B8G8R8A8Typeless\"")]
        [NativeName("Name", "DirectXPixelFormat_B8G8R8A8Typeless")]
        DirectXPixelFormatB8G8R8A8Typeless = 0x5A,
        [Obsolete("Deprecated in favour of \"B8G8R8A8UIntNormalizedSrgb\"")]
        [NativeName("Name", "DirectXPixelFormat_B8G8R8A8UIntNormalizedSrgb")]
        DirectXPixelFormatB8G8R8A8uintNormalizedSrgb = 0x5B,
        [Obsolete("Deprecated in favour of \"B8G8R8X8Typeless\"")]
        [NativeName("Name", "DirectXPixelFormat_B8G8R8X8Typeless")]
        DirectXPixelFormatB8G8R8X8Typeless = 0x5C,
        [Obsolete("Deprecated in favour of \"B8G8R8X8UIntNormalizedSrgb\"")]
        [NativeName("Name", "DirectXPixelFormat_B8G8R8X8UIntNormalizedSrgb")]
        DirectXPixelFormatB8G8R8X8uintNormalizedSrgb = 0x5D,
        [Obsolete("Deprecated in favour of \"BC6HTypeless\"")]
        [NativeName("Name", "DirectXPixelFormat_BC6HTypeless")]
        DirectXPixelFormatBC6HTypeless = 0x5E,
        [Obsolete("Deprecated in favour of \"BC6H16UnsignedFloat\"")]
        [NativeName("Name", "DirectXPixelFormat_BC6H16UnsignedFloat")]
        DirectXPixelFormatBC6H16UnsignedFloat = 0x5F,
        [Obsolete("Deprecated in favour of \"BC6H16float\"")]
        [NativeName("Name", "DirectXPixelFormat_BC6H16Float")]
        DirectXPixelFormatBC6H16float = 0x60,
        [Obsolete("Deprecated in favour of \"BC7Typeless\"")]
        [NativeName("Name", "DirectXPixelFormat_BC7Typeless")]
        DirectXPixelFormatBC7Typeless = 0x61,
        [Obsolete("Deprecated in favour of \"BC7UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_BC7UIntNormalized")]
        DirectXPixelFormatBC7uintNormalized = 0x62,
        [Obsolete("Deprecated in favour of \"BC7UIntNormalizedSrgb\"")]
        [NativeName("Name", "DirectXPixelFormat_BC7UIntNormalizedSrgb")]
        DirectXPixelFormatBC7uintNormalizedSrgb = 0x63,
        [Obsolete("Deprecated in favour of \"Ayuv\"")]
        [NativeName("Name", "DirectXPixelFormat_Ayuv")]
        DirectXPixelFormatAyuv = 0x64,
        [Obsolete("Deprecated in favour of \"Y410\"")]
        [NativeName("Name", "DirectXPixelFormat_Y410")]
        DirectXPixelFormatY410 = 0x65,
        [Obsolete("Deprecated in favour of \"Y416\"")]
        [NativeName("Name", "DirectXPixelFormat_Y416")]
        DirectXPixelFormatY416 = 0x66,
        [Obsolete("Deprecated in favour of \"NV12\"")]
        [NativeName("Name", "DirectXPixelFormat_NV12")]
        DirectXPixelFormatNV12 = 0x67,
        [Obsolete("Deprecated in favour of \"P010\"")]
        [NativeName("Name", "DirectXPixelFormat_P010")]
        DirectXPixelFormatP010 = 0x68,
        [Obsolete("Deprecated in favour of \"P016\"")]
        [NativeName("Name", "DirectXPixelFormat_P016")]
        DirectXPixelFormatP016 = 0x69,
        [Obsolete("Deprecated in favour of \"Opaque420\"")]
        [NativeName("Name", "DirectXPixelFormat_Opaque420")]
        DirectXPixelFormatOpaque420 = 0x6A,
        [Obsolete("Deprecated in favour of \"Yuy2\"")]
        [NativeName("Name", "DirectXPixelFormat_Yuy2")]
        DirectXPixelFormatYuy2 = 0x6B,
        [Obsolete("Deprecated in favour of \"Y210\"")]
        [NativeName("Name", "DirectXPixelFormat_Y210")]
        DirectXPixelFormatY210 = 0x6C,
        [Obsolete("Deprecated in favour of \"Y216\"")]
        [NativeName("Name", "DirectXPixelFormat_Y216")]
        DirectXPixelFormatY216 = 0x6D,
        [Obsolete("Deprecated in favour of \"NV11\"")]
        [NativeName("Name", "DirectXPixelFormat_NV11")]
        DirectXPixelFormatNV11 = 0x6E,
        [Obsolete("Deprecated in favour of \"AI44\"")]
        [NativeName("Name", "DirectXPixelFormat_AI44")]
        DirectXPixelFormatAI44 = 0x6F,
        [Obsolete("Deprecated in favour of \"IA44\"")]
        [NativeName("Name", "DirectXPixelFormat_IA44")]
        DirectXPixelFormatIA44 = 0x70,
        [Obsolete("Deprecated in favour of \"P8\"")]
        [NativeName("Name", "DirectXPixelFormat_P8")]
        DirectXPixelFormatP8 = 0x71,
        [Obsolete("Deprecated in favour of \"A8P8\"")]
        [NativeName("Name", "DirectXPixelFormat_A8P8")]
        DirectXPixelFormatA8P8 = 0x72,
        [Obsolete("Deprecated in favour of \"B4G4R4A4UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_B4G4R4A4UIntNormalized")]
        DirectXPixelFormatB4G4R4A4uintNormalized = 0x73,
        [Obsolete("Deprecated in favour of \"P208\"")]
        [NativeName("Name", "DirectXPixelFormat_P208")]
        DirectXPixelFormatP208 = 0x82,
        [Obsolete("Deprecated in favour of \"V208\"")]
        [NativeName("Name", "DirectXPixelFormat_V208")]
        DirectXPixelFormatV208 = 0x83,
        [Obsolete("Deprecated in favour of \"V408\"")]
        [NativeName("Name", "DirectXPixelFormat_V408")]
        DirectXPixelFormatV408 = 0x84,
        [Obsolete("Deprecated in favour of \"SamplerFeedbackMinMipOpaque\"")]
        [NativeName("Name", "DirectXPixelFormat_SamplerFeedbackMinMipOpaque")]
        DirectXPixelFormatSamplerFeedbackMinMipOpaque = 0xBD,
        [Obsolete("Deprecated in favour of \"SamplerFeedbackMipRegionUsedOpaque\"")]
        [NativeName("Name", "DirectXPixelFormat_SamplerFeedbackMipRegionUsedOpaque")]
        DirectXPixelFormatSamplerFeedbackMipRegionUsedOpaque = 0xBE,
        [Obsolete("Deprecated in favour of \"A4B4G4R4\"")]
        [NativeName("Name", "DirectXPixelFormat_A4B4G4R4")]
        DirectXPixelFormatA4B4G4R4 = 0xBF,
        [NativeName("Name", "DirectXPixelFormat_R32G32B32A32UInt")]
        R32G32B32A32UInt = 0x3,
        [NativeName("Name", "DirectXPixelFormat_R32G32B32UInt")]
        R32G32B32UInt = 0x7,
        [NativeName("Name", "DirectXPixelFormat_R16G16B16A16UIntNormalized")]
        R16G16B16A16UIntNormalized = 0xB,
        [NativeName("Name", "DirectXPixelFormat_R16G16B16A16UInt")]
        R16G16B16A16UInt = 0xC,
        [NativeName("Name", "DirectXPixelFormat_R32G32UInt")]
        R32G32UInt = 0x11,
        [NativeName("Name", "DirectXPixelFormat_D32FloatS8X24UInt")]
        D32floatS8X24UInt = 0x14,
        [NativeName("Name", "DirectXPixelFormat_X32TypelessG8X24UInt")]
        X32TypelessG8X24UInt = 0x16,
        [NativeName("Name", "DirectXPixelFormat_R10G10B10A2UIntNormalized")]
        R10G10B10A2UIntNormalized = 0x18,
        [NativeName("Name", "DirectXPixelFormat_R10G10B10A2UInt")]
        R10G10B10A2UInt = 0x19,
        [NativeName("Name", "DirectXPixelFormat_R8G8B8A8UIntNormalized")]
        R8G8B8A8UIntNormalized = 0x1C,
        [NativeName("Name", "DirectXPixelFormat_R8G8B8A8UIntNormalizedSrgb")]
        R8G8B8A8UIntNormalizedSrgb = 0x1D,
        [NativeName("Name", "DirectXPixelFormat_R8G8B8A8UInt")]
        R8G8B8A8UInt = 0x1E,
        [NativeName("Name", "DirectXPixelFormat_R16G16UIntNormalized")]
        R16G16UIntNormalized = 0x23,
        [NativeName("Name", "DirectXPixelFormat_R16G16UInt")]
        R16G16UInt = 0x24,
        [NativeName("Name", "DirectXPixelFormat_R32UInt")]
        R32UInt = 0x2A,
        [NativeName("Name", "DirectXPixelFormat_D24UIntNormalizedS8UInt")]
        D24UIntNormalizedS8UInt = 0x2D,
        [NativeName("Name", "DirectXPixelFormat_R24UIntNormalizedX8Typeless")]
        R24UIntNormalizedX8Typeless = 0x2E,
        [NativeName("Name", "DirectXPixelFormat_X24TypelessG8UInt")]
        X24TypelessG8UInt = 0x2F,
        [NativeName("Name", "DirectXPixelFormat_R8G8UIntNormalized")]
        R8G8UIntNormalized = 0x31,
        [NativeName("Name", "DirectXPixelFormat_R8G8UInt")]
        R8G8UInt = 0x32,
        [NativeName("Name", "DirectXPixelFormat_D16UIntNormalized")]
        D16UIntNormalized = 0x37,
        [NativeName("Name", "DirectXPixelFormat_R16UIntNormalized")]
        R16UIntNormalized = 0x38,
        [NativeName("Name", "DirectXPixelFormat_R16UInt")]
        R16UInt = 0x39,
        [NativeName("Name", "DirectXPixelFormat_R8UIntNormalized")]
        R8UIntNormalized = 0x3D,
        [NativeName("Name", "DirectXPixelFormat_R8UInt")]
        R8UInt = 0x3E,
        [NativeName("Name", "DirectXPixelFormat_A8UIntNormalized")]
        A8UIntNormalized = 0x41,
        [NativeName("Name", "DirectXPixelFormat_R1UIntNormalized")]
        R1UIntNormalized = 0x42,
        [NativeName("Name", "DirectXPixelFormat_R8G8B8G8UIntNormalized")]
        R8G8B8G8UIntNormalized = 0x44,
        [NativeName("Name", "DirectXPixelFormat_G8R8G8B8UIntNormalized")]
        G8R8G8B8UIntNormalized = 0x45,
        [NativeName("Name", "DirectXPixelFormat_BC1UIntNormalized")]
        BC1UIntNormalized = 0x47,
        [NativeName("Name", "DirectXPixelFormat_BC1UIntNormalizedSrgb")]
        BC1UIntNormalizedSrgb = 0x48,
        [NativeName("Name", "DirectXPixelFormat_BC2UIntNormalized")]
        BC2UIntNormalized = 0x4A,
        [NativeName("Name", "DirectXPixelFormat_BC2UIntNormalizedSrgb")]
        BC2UIntNormalizedSrgb = 0x4B,
        [NativeName("Name", "DirectXPixelFormat_BC3UIntNormalized")]
        BC3UIntNormalized = 0x4D,
        [NativeName("Name", "DirectXPixelFormat_BC3UIntNormalizedSrgb")]
        BC3UIntNormalizedSrgb = 0x4E,
        [NativeName("Name", "DirectXPixelFormat_BC4UIntNormalized")]
        BC4UIntNormalized = 0x50,
        [NativeName("Name", "DirectXPixelFormat_BC5UIntNormalized")]
        BC5UIntNormalized = 0x53,
        [NativeName("Name", "DirectXPixelFormat_B5G6R5UIntNormalized")]
        B5G6R5UIntNormalized = 0x55,
        [NativeName("Name", "DirectXPixelFormat_B5G5R5A1UIntNormalized")]
        B5G5R5A1UIntNormalized = 0x56,
        [NativeName("Name", "DirectXPixelFormat_B8G8R8A8UIntNormalized")]
        B8G8R8A8UIntNormalized = 0x57,
        [NativeName("Name", "DirectXPixelFormat_B8G8R8X8UIntNormalized")]
        B8G8R8X8UIntNormalized = 0x58,
        [NativeName("Name", "DirectXPixelFormat_R10G10B10XRBiasA2UIntNormalized")]
        R10G10B10XRBiasA2UIntNormalized = 0x59,
        [NativeName("Name", "DirectXPixelFormat_B8G8R8A8UIntNormalizedSrgb")]
        B8G8R8A8UIntNormalizedSrgb = 0x5B,
        [NativeName("Name", "DirectXPixelFormat_B8G8R8X8UIntNormalizedSrgb")]
        B8G8R8X8UIntNormalizedSrgb = 0x5D,
        [NativeName("Name", "DirectXPixelFormat_BC7UIntNormalized")]
        BC7UIntNormalized = 0x62,
        [NativeName("Name", "DirectXPixelFormat_BC7UIntNormalizedSrgb")]
        BC7UIntNormalizedSrgb = 0x63,
        [NativeName("Name", "DirectXPixelFormat_B4G4R4A4UIntNormalized")]
        B4G4R4A4UIntNormalized = 0x73,
        [NativeName("Name", "DirectXPixelFormat_Unknown")]
        Unknown = 0x0,
        [NativeName("Name", "DirectXPixelFormat_R32G32B32A32Typeless")]
        R32G32B32A32Typeless = 0x1,
        [NativeName("Name", "DirectXPixelFormat_R32G32B32A32Float")]
        R32G32B32A32float = 0x2,
        [Obsolete("Deprecated in favour of \"R32G32B32A32UInt\"")]
        [NativeName("Name", "DirectXPixelFormat_R32G32B32A32UInt")]
        R32G32B32A32uint = 0x3,
        [NativeName("Name", "DirectXPixelFormat_R32G32B32A32Int")]
        R32G32B32A32int = 0x4,
        [NativeName("Name", "DirectXPixelFormat_R32G32B32Typeless")]
        R32G32B32Typeless = 0x5,
        [NativeName("Name", "DirectXPixelFormat_R32G32B32Float")]
        R32G32B32float = 0x6,
        [Obsolete("Deprecated in favour of \"R32G32B32UInt\"")]
        [NativeName("Name", "DirectXPixelFormat_R32G32B32UInt")]
        R32G32B32uint = 0x7,
        [NativeName("Name", "DirectXPixelFormat_R32G32B32Int")]
        R32G32B32int = 0x8,
        [NativeName("Name", "DirectXPixelFormat_R16G16B16A16Typeless")]
        R16G16B16A16Typeless = 0x9,
        [NativeName("Name", "DirectXPixelFormat_R16G16B16A16Float")]
        R16G16B16A16float = 0xA,
        [Obsolete("Deprecated in favour of \"R16G16B16A16UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_R16G16B16A16UIntNormalized")]
        R16G16B16A16uintNormalized = 0xB,
        [Obsolete("Deprecated in favour of \"R16G16B16A16UInt\"")]
        [NativeName("Name", "DirectXPixelFormat_R16G16B16A16UInt")]
        R16G16B16A16uint = 0xC,
        [NativeName("Name", "DirectXPixelFormat_R16G16B16A16IntNormalized")]
        R16G16B16A16intNormalized = 0xD,
        [NativeName("Name", "DirectXPixelFormat_R16G16B16A16Int")]
        R16G16B16A16int = 0xE,
        [NativeName("Name", "DirectXPixelFormat_R32G32Typeless")]
        R32G32Typeless = 0xF,
        [NativeName("Name", "DirectXPixelFormat_R32G32Float")]
        R32G32float = 0x10,
        [Obsolete("Deprecated in favour of \"R32G32UInt\"")]
        [NativeName("Name", "DirectXPixelFormat_R32G32UInt")]
        R32G32uint = 0x11,
        [NativeName("Name", "DirectXPixelFormat_R32G32Int")]
        R32G32int = 0x12,
        [NativeName("Name", "DirectXPixelFormat_R32G8X24Typeless")]
        R32G8X24Typeless = 0x13,
        [Obsolete("Deprecated in favour of \"D32floatS8X24UInt\"")]
        [NativeName("Name", "DirectXPixelFormat_D32FloatS8X24UInt")]
        D32floatS8X24uint = 0x14,
        [NativeName("Name", "DirectXPixelFormat_R32FloatX8X24Typeless")]
        R32floatX8X24Typeless = 0x15,
        [Obsolete("Deprecated in favour of \"X32TypelessG8X24UInt\"")]
        [NativeName("Name", "DirectXPixelFormat_X32TypelessG8X24UInt")]
        X32TypelessG8X24uint = 0x16,
        [NativeName("Name", "DirectXPixelFormat_R10G10B10A2Typeless")]
        R10G10B10A2Typeless = 0x17,
        [Obsolete("Deprecated in favour of \"R10G10B10A2UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_R10G10B10A2UIntNormalized")]
        R10G10B10A2uintNormalized = 0x18,
        [Obsolete("Deprecated in favour of \"R10G10B10A2UInt\"")]
        [NativeName("Name", "DirectXPixelFormat_R10G10B10A2UInt")]
        R10G10B10A2uint = 0x19,
        [NativeName("Name", "DirectXPixelFormat_R11G11B10Float")]
        R11G11B10float = 0x1A,
        [NativeName("Name", "DirectXPixelFormat_R8G8B8A8Typeless")]
        R8G8B8A8Typeless = 0x1B,
        [Obsolete("Deprecated in favour of \"R8G8B8A8UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_R8G8B8A8UIntNormalized")]
        R8G8B8A8uintNormalized = 0x1C,
        [Obsolete("Deprecated in favour of \"R8G8B8A8UIntNormalizedSrgb\"")]
        [NativeName("Name", "DirectXPixelFormat_R8G8B8A8UIntNormalizedSrgb")]
        R8G8B8A8uintNormalizedSrgb = 0x1D,
        [Obsolete("Deprecated in favour of \"R8G8B8A8UInt\"")]
        [NativeName("Name", "DirectXPixelFormat_R8G8B8A8UInt")]
        R8G8B8A8uint = 0x1E,
        [NativeName("Name", "DirectXPixelFormat_R8G8B8A8IntNormalized")]
        R8G8B8A8intNormalized = 0x1F,
        [NativeName("Name", "DirectXPixelFormat_R8G8B8A8Int")]
        R8G8B8A8int = 0x20,
        [NativeName("Name", "DirectXPixelFormat_R16G16Typeless")]
        R16G16Typeless = 0x21,
        [NativeName("Name", "DirectXPixelFormat_R16G16Float")]
        R16G16float = 0x22,
        [Obsolete("Deprecated in favour of \"R16G16UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_R16G16UIntNormalized")]
        R16G16uintNormalized = 0x23,
        [Obsolete("Deprecated in favour of \"R16G16UInt\"")]
        [NativeName("Name", "DirectXPixelFormat_R16G16UInt")]
        R16G16uint = 0x24,
        [NativeName("Name", "DirectXPixelFormat_R16G16IntNormalized")]
        R16G16intNormalized = 0x25,
        [NativeName("Name", "DirectXPixelFormat_R16G16Int")]
        R16G16int = 0x26,
        [NativeName("Name", "DirectXPixelFormat_R32Typeless")]
        R32Typeless = 0x27,
        [NativeName("Name", "DirectXPixelFormat_D32Float")]
        D32float = 0x28,
        [NativeName("Name", "DirectXPixelFormat_R32Float")]
        R32float = 0x29,
        [Obsolete("Deprecated in favour of \"R32UInt\"")]
        [NativeName("Name", "DirectXPixelFormat_R32UInt")]
        R32uint = 0x2A,
        [NativeName("Name", "DirectXPixelFormat_R32Int")]
        R32int = 0x2B,
        [NativeName("Name", "DirectXPixelFormat_R24G8Typeless")]
        R24G8Typeless = 0x2C,
        [Obsolete("Deprecated in favour of \"D24UIntNormalizedS8UInt\"")]
        [NativeName("Name", "DirectXPixelFormat_D24UIntNormalizedS8UInt")]
        D24uintNormalizedS8uint = 0x2D,
        [Obsolete("Deprecated in favour of \"R24UIntNormalizedX8Typeless\"")]
        [NativeName("Name", "DirectXPixelFormat_R24UIntNormalizedX8Typeless")]
        R24uintNormalizedX8Typeless = 0x2E,
        [Obsolete("Deprecated in favour of \"X24TypelessG8UInt\"")]
        [NativeName("Name", "DirectXPixelFormat_X24TypelessG8UInt")]
        X24TypelessG8uint = 0x2F,
        [NativeName("Name", "DirectXPixelFormat_R8G8Typeless")]
        R8G8Typeless = 0x30,
        [Obsolete("Deprecated in favour of \"R8G8UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_R8G8UIntNormalized")]
        R8G8uintNormalized = 0x31,
        [Obsolete("Deprecated in favour of \"R8G8UInt\"")]
        [NativeName("Name", "DirectXPixelFormat_R8G8UInt")]
        R8G8uint = 0x32,
        [NativeName("Name", "DirectXPixelFormat_R8G8IntNormalized")]
        R8G8intNormalized = 0x33,
        [NativeName("Name", "DirectXPixelFormat_R8G8Int")]
        R8G8int = 0x34,
        [NativeName("Name", "DirectXPixelFormat_R16Typeless")]
        R16Typeless = 0x35,
        [NativeName("Name", "DirectXPixelFormat_R16Float")]
        R16float = 0x36,
        [Obsolete("Deprecated in favour of \"D16UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_D16UIntNormalized")]
        D16uintNormalized = 0x37,
        [Obsolete("Deprecated in favour of \"R16UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_R16UIntNormalized")]
        R16uintNormalized = 0x38,
        [Obsolete("Deprecated in favour of \"R16UInt\"")]
        [NativeName("Name", "DirectXPixelFormat_R16UInt")]
        R16uint = 0x39,
        [NativeName("Name", "DirectXPixelFormat_R16IntNormalized")]
        R16intNormalized = 0x3A,
        [NativeName("Name", "DirectXPixelFormat_R16Int")]
        R16int = 0x3B,
        [NativeName("Name", "DirectXPixelFormat_R8Typeless")]
        R8Typeless = 0x3C,
        [Obsolete("Deprecated in favour of \"R8UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_R8UIntNormalized")]
        R8uintNormalized = 0x3D,
        [Obsolete("Deprecated in favour of \"R8UInt\"")]
        [NativeName("Name", "DirectXPixelFormat_R8UInt")]
        R8uint = 0x3E,
        [NativeName("Name", "DirectXPixelFormat_R8IntNormalized")]
        R8intNormalized = 0x3F,
        [NativeName("Name", "DirectXPixelFormat_R8Int")]
        R8int = 0x40,
        [Obsolete("Deprecated in favour of \"A8UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_A8UIntNormalized")]
        A8uintNormalized = 0x41,
        [Obsolete("Deprecated in favour of \"R1UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_R1UIntNormalized")]
        R1uintNormalized = 0x42,
        [NativeName("Name", "DirectXPixelFormat_R9G9B9E5SharedExponent")]
        R9G9B9E5SharedExponent = 0x43,
        [Obsolete("Deprecated in favour of \"R8G8B8G8UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_R8G8B8G8UIntNormalized")]
        R8G8B8G8uintNormalized = 0x44,
        [Obsolete("Deprecated in favour of \"G8R8G8B8UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_G8R8G8B8UIntNormalized")]
        G8R8G8B8uintNormalized = 0x45,
        [NativeName("Name", "DirectXPixelFormat_BC1Typeless")]
        BC1Typeless = 0x46,
        [Obsolete("Deprecated in favour of \"BC1UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_BC1UIntNormalized")]
        BC1uintNormalized = 0x47,
        [Obsolete("Deprecated in favour of \"BC1UIntNormalizedSrgb\"")]
        [NativeName("Name", "DirectXPixelFormat_BC1UIntNormalizedSrgb")]
        BC1uintNormalizedSrgb = 0x48,
        [NativeName("Name", "DirectXPixelFormat_BC2Typeless")]
        BC2Typeless = 0x49,
        [Obsolete("Deprecated in favour of \"BC2UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_BC2UIntNormalized")]
        BC2uintNormalized = 0x4A,
        [Obsolete("Deprecated in favour of \"BC2UIntNormalizedSrgb\"")]
        [NativeName("Name", "DirectXPixelFormat_BC2UIntNormalizedSrgb")]
        BC2uintNormalizedSrgb = 0x4B,
        [NativeName("Name", "DirectXPixelFormat_BC3Typeless")]
        BC3Typeless = 0x4C,
        [Obsolete("Deprecated in favour of \"BC3UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_BC3UIntNormalized")]
        BC3uintNormalized = 0x4D,
        [Obsolete("Deprecated in favour of \"BC3UIntNormalizedSrgb\"")]
        [NativeName("Name", "DirectXPixelFormat_BC3UIntNormalizedSrgb")]
        BC3uintNormalizedSrgb = 0x4E,
        [NativeName("Name", "DirectXPixelFormat_BC4Typeless")]
        BC4Typeless = 0x4F,
        [Obsolete("Deprecated in favour of \"BC4UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_BC4UIntNormalized")]
        BC4uintNormalized = 0x50,
        [NativeName("Name", "DirectXPixelFormat_BC4IntNormalized")]
        BC4intNormalized = 0x51,
        [NativeName("Name", "DirectXPixelFormat_BC5Typeless")]
        BC5Typeless = 0x52,
        [Obsolete("Deprecated in favour of \"BC5UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_BC5UIntNormalized")]
        BC5uintNormalized = 0x53,
        [NativeName("Name", "DirectXPixelFormat_BC5IntNormalized")]
        BC5intNormalized = 0x54,
        [Obsolete("Deprecated in favour of \"B5G6R5UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_B5G6R5UIntNormalized")]
        B5G6R5uintNormalized = 0x55,
        [Obsolete("Deprecated in favour of \"B5G5R5A1UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_B5G5R5A1UIntNormalized")]
        B5G5R5A1uintNormalized = 0x56,
        [Obsolete("Deprecated in favour of \"B8G8R8A8UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_B8G8R8A8UIntNormalized")]
        B8G8R8A8uintNormalized = 0x57,
        [Obsolete("Deprecated in favour of \"B8G8R8X8UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_B8G8R8X8UIntNormalized")]
        B8G8R8X8uintNormalized = 0x58,
        [Obsolete("Deprecated in favour of \"R10G10B10XRBiasA2UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_R10G10B10XRBiasA2UIntNormalized")]
        R10G10B10XrbiasA2uintNormalized = 0x59,
        [NativeName("Name", "DirectXPixelFormat_B8G8R8A8Typeless")]
        B8G8R8A8Typeless = 0x5A,
        [Obsolete("Deprecated in favour of \"B8G8R8A8UIntNormalizedSrgb\"")]
        [NativeName("Name", "DirectXPixelFormat_B8G8R8A8UIntNormalizedSrgb")]
        B8G8R8A8uintNormalizedSrgb = 0x5B,
        [NativeName("Name", "DirectXPixelFormat_B8G8R8X8Typeless")]
        B8G8R8X8Typeless = 0x5C,
        [Obsolete("Deprecated in favour of \"B8G8R8X8UIntNormalizedSrgb\"")]
        [NativeName("Name", "DirectXPixelFormat_B8G8R8X8UIntNormalizedSrgb")]
        B8G8R8X8uintNormalizedSrgb = 0x5D,
        [NativeName("Name", "DirectXPixelFormat_BC6HTypeless")]
        BC6HTypeless = 0x5E,
        [NativeName("Name", "DirectXPixelFormat_BC6H16UnsignedFloat")]
        BC6H16UnsignedFloat = 0x5F,
        [NativeName("Name", "DirectXPixelFormat_BC6H16Float")]
        BC6H16float = 0x60,
        [NativeName("Name", "DirectXPixelFormat_BC7Typeless")]
        BC7Typeless = 0x61,
        [Obsolete("Deprecated in favour of \"BC7UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_BC7UIntNormalized")]
        BC7uintNormalized = 0x62,
        [Obsolete("Deprecated in favour of \"BC7UIntNormalizedSrgb\"")]
        [NativeName("Name", "DirectXPixelFormat_BC7UIntNormalizedSrgb")]
        BC7uintNormalizedSrgb = 0x63,
        [NativeName("Name", "DirectXPixelFormat_Ayuv")]
        Ayuv = 0x64,
        [NativeName("Name", "DirectXPixelFormat_Y410")]
        Y410 = 0x65,
        [NativeName("Name", "DirectXPixelFormat_Y416")]
        Y416 = 0x66,
        [NativeName("Name", "DirectXPixelFormat_NV12")]
        NV12 = 0x67,
        [NativeName("Name", "DirectXPixelFormat_P010")]
        P010 = 0x68,
        [NativeName("Name", "DirectXPixelFormat_P016")]
        P016 = 0x69,
        [NativeName("Name", "DirectXPixelFormat_Opaque420")]
        Opaque420 = 0x6A,
        [NativeName("Name", "DirectXPixelFormat_Yuy2")]
        Yuy2 = 0x6B,
        [NativeName("Name", "DirectXPixelFormat_Y210")]
        Y210 = 0x6C,
        [NativeName("Name", "DirectXPixelFormat_Y216")]
        Y216 = 0x6D,
        [NativeName("Name", "DirectXPixelFormat_NV11")]
        NV11 = 0x6E,
        [NativeName("Name", "DirectXPixelFormat_AI44")]
        AI44 = 0x6F,
        [NativeName("Name", "DirectXPixelFormat_IA44")]
        IA44 = 0x70,
        [NativeName("Name", "DirectXPixelFormat_P8")]
        P8 = 0x71,
        [NativeName("Name", "DirectXPixelFormat_A8P8")]
        A8P8 = 0x72,
        [Obsolete("Deprecated in favour of \"B4G4R4A4UIntNormalized\"")]
        [NativeName("Name", "DirectXPixelFormat_B4G4R4A4UIntNormalized")]
        B4G4R4A4uintNormalized = 0x73,
        [NativeName("Name", "DirectXPixelFormat_P208")]
        P208 = 0x82,
        [NativeName("Name", "DirectXPixelFormat_V208")]
        V208 = 0x83,
        [NativeName("Name", "DirectXPixelFormat_V408")]
        V408 = 0x84,
        [NativeName("Name", "DirectXPixelFormat_SamplerFeedbackMinMipOpaque")]
        SamplerFeedbackMinMipOpaque = 0xBD,
        [NativeName("Name", "DirectXPixelFormat_SamplerFeedbackMipRegionUsedOpaque")]
        SamplerFeedbackMipRegionUsedOpaque = 0xBE,
        [NativeName("Name", "DirectXPixelFormat_A4B4G4R4")]
        A4B4G4R4 = 0xBF,
    }
}
