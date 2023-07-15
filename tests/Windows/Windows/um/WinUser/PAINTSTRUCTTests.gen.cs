// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "PAINTSTRUCT"/> struct.</summary>
public static unsafe partial class PAINTSTRUCTTests
{
    /// <summary>Validates that the <see cref = "PAINTSTRUCT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PAINTSTRUCT>(), Is.EqualTo(sizeof(PAINTSTRUCT)));
    }

    /// <summary>Validates that the <see cref = "PAINTSTRUCT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PAINTSTRUCT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PAINTSTRUCT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PAINTSTRUCT), Is.EqualTo(72));
        }
        else
        {
            Assert.That(sizeof(PAINTSTRUCT), Is.EqualTo(64));
        }
    }
}