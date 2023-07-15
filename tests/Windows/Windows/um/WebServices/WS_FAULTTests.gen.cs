// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "WS_FAULT"/> struct.</summary>
public static unsafe partial class WS_FAULTTests
{
    /// <summary>Validates that the <see cref = "WS_FAULT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WS_FAULT>(), Is.EqualTo(sizeof(WS_FAULT)));
    }

    /// <summary>Validates that the <see cref = "WS_FAULT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WS_FAULT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WS_FAULT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(WS_FAULT), Is.EqualTo(64));
        }
        else
        {
            Assert.That(sizeof(WS_FAULT), Is.EqualTo(32));
        }
    }
}