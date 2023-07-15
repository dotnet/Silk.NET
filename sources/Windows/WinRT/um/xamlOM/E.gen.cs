// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using TerraFX.Interop.WinRT;

namespace TerraFX.Interop.Windows;
public static partial class E
{
    [NativeTypeName("#define E_UNKNOWNTYPE MAKE_HRESULT(SEVERITY_ERROR, FACILITY_XAML, 40L)")]
    public const int E_UNKNOWNTYPE = unchecked((int)(((uint)(1) << 31) | ((uint)(43) << 16) | ((uint)(40))));
}