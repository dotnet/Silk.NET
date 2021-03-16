// Copyright ? Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from HelloTriangle\shaders.hlsl in https://github.com/Microsoft/DirectX-Graphics-Samples
// Original source is Copyright ? Microsoft. All rights reserved. Licensed under the MIT License (MIT).

struct PSInput
{
    float4 position : SV_POSITION;
    float4 color : COLOR;
};

PSInput VSMain(float4 position : POSITION, float4 color : COLOR)
{
    PSInput result;

    result.position = position;
    result.color = color;

    return result;
}

float4 PSMain(PSInput input) : SV_TARGET
{
    return input.color;
}
