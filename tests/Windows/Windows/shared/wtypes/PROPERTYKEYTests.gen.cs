// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "PROPERTYKEY"/> struct.</summary>
public static unsafe partial class PROPERTYKEYTests
{
    /// <summary>Validates that the <see cref = "PROPERTYKEY"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PROPERTYKEY>(), Is.EqualTo(sizeof(PROPERTYKEY)));
    }

    /// <summary>Validates that the <see cref = "PROPERTYKEY"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PROPERTYKEY).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PROPERTYKEY"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(PROPERTYKEY), Is.EqualTo(20));
    }
}