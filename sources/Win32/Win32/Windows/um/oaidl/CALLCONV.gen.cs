// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum CALLCONV
{
    CC_FASTCALL = 0,
    CC_CDECL = 1,
    CC_MSCPASCAL = (CC_CDECL + 1),
    CC_PASCAL = CC_MSCPASCAL,
    CC_MACPASCAL = (CC_PASCAL + 1),
    CC_STDCALL = (CC_MACPASCAL + 1),
    CC_FPFASTCALL = (CC_STDCALL + 1),
    CC_SYSCALL = (CC_FPFASTCALL + 1),
    CC_MPWCDECL = (CC_SYSCALL + 1),
    CC_MPWPASCAL = (CC_MPWCDECL + 1),
    CC_MAX = (CC_MPWPASCAL + 1),
}
