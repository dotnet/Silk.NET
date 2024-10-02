// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using static Silk.NET.SDL.ChromaLocation;
using static Silk.NET.SDL.ColorPrimaries;
using static Silk.NET.SDL.ColorRange;
using static Silk.NET.SDL.ColorType;
using static Silk.NET.SDL.MatrixCoefficients;
using static Silk.NET.SDL.TransferCharacteristics;

namespace Silk.NET.SDL;

[NativeTypeName("unsigned int")]
public enum Colorspace : uint
{
    Unknown,
    Srgb =
        (
            ((uint)(Rgb) << 28)
            | ((uint)(Full) << 24)
            | ((uint)(None) << 20)
            | ((uint)(ColorPrimaries.Bt709) << 10)
            | ((uint)(TransferCharacteristics.Srgb) << 5)
            | ((uint)(Identity) << 0)
        ),
    SrgbLinear =
        (
            ((uint)(Rgb) << 28)
            | ((uint)(Full) << 24)
            | ((uint)(None) << 20)
            | ((uint)(ColorPrimaries.Bt709) << 10)
            | ((uint)(Linear) << 5)
            | ((uint)(Identity) << 0)
        ),
    Hdr10 =
        (
            ((uint)(Rgb) << 28)
            | ((uint)(Full) << 24)
            | ((uint)(None) << 20)
            | ((uint)(Bt2020) << 10)
            | ((uint)(Pq) << 5)
            | ((uint)(Identity) << 0)
        ),
    Jpeg =
        (
            ((uint)(Ycbcr) << 28)
            | ((uint)(Full) << 24)
            | ((uint)(None) << 20)
            | ((uint)(ColorPrimaries.Bt709) << 10)
            | ((uint)(TransferCharacteristics.Bt601) << 5)
            | ((uint)(MatrixCoefficients.Bt601) << 0)
        ),
    Bt601Limited =
        (
            ((uint)(Ycbcr) << 28)
            | ((uint)(Limited) << 24)
            | ((uint)(Left) << 20)
            | ((uint)(ColorPrimaries.Bt601) << 10)
            | ((uint)(TransferCharacteristics.Bt601) << 5)
            | ((uint)(MatrixCoefficients.Bt601) << 0)
        ),
    Bt601Full =
        (
            ((uint)(Ycbcr) << 28)
            | ((uint)(Full) << 24)
            | ((uint)(Left) << 20)
            | ((uint)(ColorPrimaries.Bt601) << 10)
            | ((uint)(TransferCharacteristics.Bt601) << 5)
            | ((uint)(MatrixCoefficients.Bt601) << 0)
        ),
    Bt709Limited =
        (
            ((uint)(Ycbcr) << 28)
            | ((uint)(Limited) << 24)
            | ((uint)(Left) << 20)
            | ((uint)(ColorPrimaries.Bt709) << 10)
            | ((uint)(TransferCharacteristics.Bt709) << 5)
            | ((uint)(MatrixCoefficients.Bt709) << 0)
        ),
    Bt709Full =
        (
            ((uint)(Ycbcr) << 28)
            | ((uint)(Full) << 24)
            | ((uint)(Left) << 20)
            | ((uint)(ColorPrimaries.Bt709) << 10)
            | ((uint)(TransferCharacteristics.Bt709) << 5)
            | ((uint)(MatrixCoefficients.Bt709) << 0)
        ),
    Bt2020Limited =
        (
            ((uint)(Ycbcr) << 28)
            | ((uint)(Limited) << 24)
            | ((uint)(Left) << 20)
            | ((uint)(Bt2020) << 10)
            | ((uint)(Pq) << 5)
            | ((uint)(Bt2020Ncl) << 0)
        ),
    Bt2020Full =
        (
            ((uint)(Ycbcr) << 28)
            | ((uint)(Full) << 24)
            | ((uint)(Left) << 20)
            | ((uint)(Bt2020) << 10)
            | ((uint)(Pq) << 5)
            | ((uint)(Bt2020Ncl) << 0)
        ),
    RgbDefault = Srgb,
    YuvDefault = Jpeg,
}
