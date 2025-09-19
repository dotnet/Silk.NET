// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public unsafe partial struct HMODULE
{
    public static explicit operator HMODULE(HINSTANCE value) => new HMODULE(value.Value);

    public static implicit operator HINSTANCE(HMODULE value) => new HINSTANCE(value.Value);
}
