// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdipluseffects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;

namespace Silk.NET.Gdiplus;

/// <include file='BrightnessContrast.xml' path='doc/member[@name="BrightnessContrast"]/*' />
[NativeTypeName("struct BrightnessContrast : Gdiplus::Effect")]
[NativeInheritance("Effect")]
public unsafe partial struct BrightnessContrast
{
    public Effect Base;

    public int GetAuxDataSize()
    {
        return Base.GetAuxDataSize();
    }

    public void* GetAuxData()
    {
        return Base.GetAuxData();
    }

    public void UseAuxData([NativeTypeName("const BOOL")] BOOL useAuxDataFlag)
    {
        Base.UseAuxData(useAuxDataFlag);
    }

    [return: NativeTypeName("Gdiplus::Status")]
    public GpStatus GetParameterSize(uint* size)
    {
        return Base.GetParameterSize(size);
    }

    [return: NativeTypeName("Gdiplus::Status")]
    public GpStatus SetParameters([NativeTypeName("const void *")] void* @params, [NativeTypeName("const UINT")] uint size)
    {
        return Base.SetParameters(@params, size);
    }

    [return: NativeTypeName("Gdiplus::Status")]
    public GpStatus GetParameters(uint* size, void* @params)
    {
        return Base.GetParameters(size, @params);
    }

    [return: NativeTypeName("Gdiplus::Status")]
    public GpStatus SetParameters([NativeTypeName("const BrightnessContrastParams *")] BrightnessContrastParams* parameters)
    {
        uint size = 8;

        return Base.SetParameters(unchecked((void*)(parameters)), size);
    }

    [return: NativeTypeName("Gdiplus::Status")]
    public GpStatus GetParameters(uint* size, [NativeTypeName("Gdiplus::BrightnessContrastParams *")] BrightnessContrastParams* parameters)
    {
        return Base.GetParameters(size, unchecked((void*)(parameters)));
    }
}
