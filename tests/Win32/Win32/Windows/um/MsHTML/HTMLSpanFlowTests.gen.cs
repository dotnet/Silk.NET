// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "HTMLSpanFlow"/> struct.</summary>
public static unsafe partial class HTMLSpanFlowTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "HTMLSpanFlow"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(HTMLSpanFlow).GUID, Is.EqualTo(IID_HTMLSpanFlow));
    }

    /// <summary>Validates that the <see cref = "HTMLSpanFlow"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HTMLSpanFlow>(), Is.EqualTo(sizeof(HTMLSpanFlow)));
    }

    /// <summary>Validates that the <see cref = "HTMLSpanFlow"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HTMLSpanFlow).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HTMLSpanFlow"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HTMLSpanFlow), Is.EqualTo(1));
    }
}
