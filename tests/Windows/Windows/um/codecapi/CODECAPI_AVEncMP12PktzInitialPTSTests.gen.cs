// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CODECAPI_AVEncMP12PktzInitialPTS"/> struct.</summary>
public static unsafe partial class CODECAPI_AVEncMP12PktzInitialPTSTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "CODECAPI_AVEncMP12PktzInitialPTS"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(CODECAPI_AVEncMP12PktzInitialPTS).GUID, Is.EqualTo(IID_CODECAPI_AVEncMP12PktzInitialPTS));
    }

    /// <summary>Validates that the <see cref = "CODECAPI_AVEncMP12PktzInitialPTS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CODECAPI_AVEncMP12PktzInitialPTS>(), Is.EqualTo(sizeof(CODECAPI_AVEncMP12PktzInitialPTS)));
    }

    /// <summary>Validates that the <see cref = "CODECAPI_AVEncMP12PktzInitialPTS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CODECAPI_AVEncMP12PktzInitialPTS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CODECAPI_AVEncMP12PktzInitialPTS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(CODECAPI_AVEncMP12PktzInitialPTS), Is.EqualTo(1));
    }
}