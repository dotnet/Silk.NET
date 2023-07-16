// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/prsht.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "PROPSHEETHEADERA_V2"/> struct.</summary>
public static unsafe partial class PROPSHEETHEADERA_V2Tests
{
    /// <summary>Validates that the <see cref = "PROPSHEETHEADERA_V2"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PROPSHEETHEADERA_V2>(), Is.EqualTo(sizeof(PROPSHEETHEADERA_V2)));
    }

    /// <summary>Validates that the <see cref = "PROPSHEETHEADERA_V2"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PROPSHEETHEADERA_V2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PROPSHEETHEADERA_V2"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PROPSHEETHEADERA_V2), Is.EqualTo(96));
        }
        else
        {
            Assert.That(sizeof(PROPSHEETHEADERA_V2), Is.EqualTo(52));
        }
    }
}