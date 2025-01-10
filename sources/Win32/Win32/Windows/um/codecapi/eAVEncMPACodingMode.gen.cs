// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum eAVEncMPACodingMode
{
    eAVEncMPACodingMode_Mono = 0,
    eAVEncMPACodingMode_Stereo = 1,
    eAVEncMPACodingMode_DualChannel = 2,
    eAVEncMPACodingMode_JointStereo = 3,
    eAVEncMPACodingMode_Surround = 4,
}
