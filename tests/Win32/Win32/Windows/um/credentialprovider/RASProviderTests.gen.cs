// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "RASProvider"/> struct.</summary>
public static unsafe partial class RASProviderTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "RASProvider"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(RASProvider).GUID, Is.EqualTo(IID_RASProvider));
    }

    /// <summary>Validates that the <see cref = "RASProvider"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<RASProvider>(), Is.EqualTo(sizeof(RASProvider)));
    }

    /// <summary>Validates that the <see cref = "RASProvider"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(RASProvider).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "RASProvider"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(RASProvider), Is.EqualTo(1));
    }
}
