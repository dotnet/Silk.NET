// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "QUERYCONTEXT"/> struct.</summary>
public static unsafe partial class QUERYCONTEXTTests
{
    /// <summary>Validates that the <see cref = "QUERYCONTEXT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<QUERYCONTEXT>(), Is.EqualTo(sizeof(QUERYCONTEXT)));
    }

    /// <summary>Validates that the <see cref = "QUERYCONTEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(QUERYCONTEXT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "QUERYCONTEXT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(QUERYCONTEXT), Is.EqualTo(32));
    }
}