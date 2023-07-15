// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MENUITEMINFOA"/> struct.</summary>
public static unsafe partial class MENUITEMINFOATests
{
    /// <summary>Validates that the <see cref = "MENUITEMINFOA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MENUITEMINFOA>(), Is.EqualTo(sizeof(MENUITEMINFOA)));
    }

    /// <summary>Validates that the <see cref = "MENUITEMINFOA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MENUITEMINFOA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MENUITEMINFOA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(MENUITEMINFOA), Is.EqualTo(80));
        }
        else
        {
            Assert.That(sizeof(MENUITEMINFOA), Is.EqualTo(48));
        }
    }
}