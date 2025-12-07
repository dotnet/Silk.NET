// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
namespace Silk.NET.SDL;

public partial struct GPUDepthStencilState
{
    public GPUCompareOp CompareOp;
    public GPUStencilOpState BackStencilState;
    public GPUStencilOpState FrontStencilState;

    [NativeTypeName("Uint8")]
    public byte CompareMask;

    [NativeTypeName("Uint8")]
    public byte WriteMask;

    [NativeTypeName("bool")]
    public byte EnableDepthTest;

    [NativeTypeName("bool")]
    public byte EnableDepthWrite;

    [NativeTypeName("bool")]
    public byte EnableStencilTest;

    [NativeTypeName("Uint8")]
    public byte Padding1;

    [NativeTypeName("Uint8")]
    public byte Padding2;

    [NativeTypeName("Uint8")]
    public byte Padding3;
}
