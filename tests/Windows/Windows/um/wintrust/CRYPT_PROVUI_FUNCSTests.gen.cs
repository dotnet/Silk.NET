// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CRYPT_PROVUI_FUNCS"/> struct.</summary>
public static unsafe partial class CRYPT_PROVUI_FUNCSTests
{
    /// <summary>Validates that the <see cref = "CRYPT_PROVUI_FUNCS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CRYPT_PROVUI_FUNCS>(), Is.EqualTo(sizeof(CRYPT_PROVUI_FUNCS)));
    }

    /// <summary>Validates that the <see cref = "CRYPT_PROVUI_FUNCS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CRYPT_PROVUI_FUNCS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CRYPT_PROVUI_FUNCS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CRYPT_PROVUI_FUNCS), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(CRYPT_PROVUI_FUNCS), Is.EqualTo(24));
        }
    }
}