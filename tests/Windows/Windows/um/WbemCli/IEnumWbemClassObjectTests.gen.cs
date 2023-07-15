// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IEnumWbemClassObject"/> struct.</summary>
public static unsafe partial class IEnumWbemClassObjectTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IEnumWbemClassObject"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IEnumWbemClassObject).GUID, Is.EqualTo(IID_IEnumWbemClassObject));
    }

    /// <summary>Validates that the <see cref = "IEnumWbemClassObject"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IEnumWbemClassObject>(), Is.EqualTo(sizeof(IEnumWbemClassObject)));
    }

    /// <summary>Validates that the <see cref = "IEnumWbemClassObject"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IEnumWbemClassObject).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IEnumWbemClassObject"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IEnumWbemClassObject), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IEnumWbemClassObject), Is.EqualTo(4));
        }
    }
}