// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "DOMMSManipulationEvent"/> struct.</summary>
public static unsafe partial class DOMMSManipulationEventTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "DOMMSManipulationEvent"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(DOMMSManipulationEvent).GUID, Is.EqualTo(IID_DOMMSManipulationEvent));
    }

    /// <summary>Validates that the <see cref = "DOMMSManipulationEvent"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DOMMSManipulationEvent>(), Is.EqualTo(sizeof(DOMMSManipulationEvent)));
    }

    /// <summary>Validates that the <see cref = "DOMMSManipulationEvent"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DOMMSManipulationEvent).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DOMMSManipulationEvent"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DOMMSManipulationEvent), Is.EqualTo(1));
    }
}