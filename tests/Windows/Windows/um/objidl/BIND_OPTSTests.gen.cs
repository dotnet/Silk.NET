// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "BIND_OPTS"/> struct.</summary>
public static unsafe partial class BIND_OPTSTests
{
    /// <summary>Validates that the <see cref = "BIND_OPTS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<BIND_OPTS>(), Is.EqualTo(sizeof(BIND_OPTS)));
    }

    /// <summary>Validates that the <see cref = "BIND_OPTS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(BIND_OPTS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "BIND_OPTS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(BIND_OPTS), Is.EqualTo(16));
    }
}