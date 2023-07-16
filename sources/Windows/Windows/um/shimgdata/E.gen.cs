// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shimgdata.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class E
{
    [NativeTypeName("#define E_NOTVALIDFORANIMATEDIMAGE MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x01)")]
    public const int E_NOTVALIDFORANIMATEDIMAGE = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x01))));
}