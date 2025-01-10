// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum eAVEncVideoColorLighting
{
    eAVEncVideoColorLighting_SameAsSource = 0,
    eAVEncVideoColorLighting_Unknown = 1,
    eAVEncVideoColorLighting_Bright = 2,
    eAVEncVideoColorLighting_Office = 3,
    eAVEncVideoColorLighting_Dim = 4,
    eAVEncVideoColorLighting_Dark = 5,
}
