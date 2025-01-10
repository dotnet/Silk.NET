// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "HTMLWindowProxy"/> struct.</summary>
public static unsafe partial class HTMLWindowProxyTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "HTMLWindowProxy"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(HTMLWindowProxy).GUID, Is.EqualTo(IID_HTMLWindowProxy));
    }

    /// <summary>Validates that the <see cref = "HTMLWindowProxy"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HTMLWindowProxy>(), Is.EqualTo(sizeof(HTMLWindowProxy)));
    }

    /// <summary>Validates that the <see cref = "HTMLWindowProxy"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HTMLWindowProxy).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HTMLWindowProxy"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HTMLWindowProxy), Is.EqualTo(1));
    }
}
