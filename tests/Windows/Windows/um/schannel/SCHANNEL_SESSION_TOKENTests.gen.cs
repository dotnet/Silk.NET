// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SCHANNEL_SESSION_TOKEN"/> struct.</summary>
public static unsafe partial class SCHANNEL_SESSION_TOKENTests
{
    /// <summary>Validates that the <see cref = "SCHANNEL_SESSION_TOKEN"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SCHANNEL_SESSION_TOKEN>(), Is.EqualTo(sizeof(SCHANNEL_SESSION_TOKEN)));
    }

    /// <summary>Validates that the <see cref = "SCHANNEL_SESSION_TOKEN"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SCHANNEL_SESSION_TOKEN).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SCHANNEL_SESSION_TOKEN"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SCHANNEL_SESSION_TOKEN), Is.EqualTo(8));
    }
}