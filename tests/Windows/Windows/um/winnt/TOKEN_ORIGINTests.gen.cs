// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "TOKEN_ORIGIN"/> struct.</summary>
public static unsafe partial class TOKEN_ORIGINTests
{
    /// <summary>Validates that the <see cref = "TOKEN_ORIGIN"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TOKEN_ORIGIN>(), Is.EqualTo(sizeof(TOKEN_ORIGIN)));
    }

    /// <summary>Validates that the <see cref = "TOKEN_ORIGIN"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TOKEN_ORIGIN).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TOKEN_ORIGIN"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TOKEN_ORIGIN), Is.EqualTo(8));
    }
}