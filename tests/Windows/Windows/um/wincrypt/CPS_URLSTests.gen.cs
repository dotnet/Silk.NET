// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CPS_URLS"/> struct.</summary>
public static unsafe partial class CPS_URLSTests
{
    /// <summary>Validates that the <see cref = "CPS_URLS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CPS_URLS>(), Is.EqualTo(sizeof(CPS_URLS)));
    }

    /// <summary>Validates that the <see cref = "CPS_URLS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CPS_URLS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CPS_URLS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CPS_URLS), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(CPS_URLS), Is.EqualTo(12));
        }
    }
}