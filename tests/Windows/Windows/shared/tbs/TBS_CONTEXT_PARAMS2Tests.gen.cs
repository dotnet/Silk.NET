// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tbs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "TBS_CONTEXT_PARAMS2"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class TBS_CONTEXT_PARAMS2Tests
{
    /// <summary>Validates that the <see cref = "TBS_CONTEXT_PARAMS2"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TBS_CONTEXT_PARAMS2>(), Is.EqualTo(sizeof(TBS_CONTEXT_PARAMS2)));
    }

    /// <summary>Validates that the <see cref = "TBS_CONTEXT_PARAMS2"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TBS_CONTEXT_PARAMS2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TBS_CONTEXT_PARAMS2"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TBS_CONTEXT_PARAMS2), Is.EqualTo(8));
    }
}