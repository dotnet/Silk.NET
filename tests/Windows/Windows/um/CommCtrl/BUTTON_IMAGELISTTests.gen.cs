// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "BUTTON_IMAGELIST"/> struct.</summary>
public static unsafe partial class BUTTON_IMAGELISTTests
{
    /// <summary>Validates that the <see cref = "BUTTON_IMAGELIST"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<BUTTON_IMAGELIST>(), Is.EqualTo(sizeof(BUTTON_IMAGELIST)));
    }

    /// <summary>Validates that the <see cref = "BUTTON_IMAGELIST"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(BUTTON_IMAGELIST).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "BUTTON_IMAGELIST"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(BUTTON_IMAGELIST), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(BUTTON_IMAGELIST), Is.EqualTo(24));
        }
    }
}