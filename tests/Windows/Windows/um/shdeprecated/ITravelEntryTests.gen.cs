// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ITravelEntry"/> struct.</summary>
public static unsafe partial class ITravelEntryTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ITravelEntry"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ITravelEntry).GUID, Is.EqualTo(IID_ITravelEntry));
    }

    /// <summary>Validates that the <see cref = "ITravelEntry"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ITravelEntry>(), Is.EqualTo(sizeof(ITravelEntry)));
    }

    /// <summary>Validates that the <see cref = "ITravelEntry"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ITravelEntry).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ITravelEntry"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ITravelEntry), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ITravelEntry), Is.EqualTo(4));
        }
    }
}