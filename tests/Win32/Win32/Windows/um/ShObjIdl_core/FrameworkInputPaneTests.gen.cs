// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "FrameworkInputPane"/> struct.</summary>
public static unsafe partial class FrameworkInputPaneTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "FrameworkInputPane"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(FrameworkInputPane).GUID, Is.EqualTo(IID_FrameworkInputPane));
    }

    /// <summary>Validates that the <see cref = "FrameworkInputPane"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FrameworkInputPane>(), Is.EqualTo(sizeof(FrameworkInputPane)));
    }

    /// <summary>Validates that the <see cref = "FrameworkInputPane"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FrameworkInputPane).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "FrameworkInputPane"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(FrameworkInputPane), Is.EqualTo(1));
    }
}
