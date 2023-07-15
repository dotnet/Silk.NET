// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IEnumOLEVERB"/> struct.</summary>
public static unsafe partial class IEnumOLEVERBTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IEnumOLEVERB"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IEnumOLEVERB).GUID, Is.EqualTo(IID_IEnumOLEVERB));
    }

    /// <summary>Validates that the <see cref = "IEnumOLEVERB"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IEnumOLEVERB>(), Is.EqualTo(sizeof(IEnumOLEVERB)));
    }

    /// <summary>Validates that the <see cref = "IEnumOLEVERB"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IEnumOLEVERB).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IEnumOLEVERB"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IEnumOLEVERB), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IEnumOLEVERB), Is.EqualTo(4));
        }
    }
}