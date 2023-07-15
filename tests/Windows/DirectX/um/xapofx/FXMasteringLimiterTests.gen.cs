// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xapofx.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "FXMasteringLimiter"/> struct.</summary>
public static unsafe partial class FXMasteringLimiterTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "FXMasteringLimiter"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(FXMasteringLimiter).GUID, Is.EqualTo(CLSID_FXMasteringLimiter));
    }

    /// <summary>Validates that the <see cref = "FXMasteringLimiter"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FXMasteringLimiter>(), Is.EqualTo(sizeof(FXMasteringLimiter)));
    }

    /// <summary>Validates that the <see cref = "FXMasteringLimiter"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FXMasteringLimiter).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "FXMasteringLimiter"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(FXMasteringLimiter), Is.EqualTo(1));
    }
}