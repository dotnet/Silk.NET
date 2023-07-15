// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "KERB_REFRESH_POLICY_REQUEST"/> struct.</summary>
public static unsafe partial class KERB_REFRESH_POLICY_REQUESTTests
{
    /// <summary>Validates that the <see cref = "KERB_REFRESH_POLICY_REQUEST"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<KERB_REFRESH_POLICY_REQUEST>(), Is.EqualTo(sizeof(KERB_REFRESH_POLICY_REQUEST)));
    }

    /// <summary>Validates that the <see cref = "KERB_REFRESH_POLICY_REQUEST"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(KERB_REFRESH_POLICY_REQUEST).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "KERB_REFRESH_POLICY_REQUEST"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(KERB_REFRESH_POLICY_REQUEST), Is.EqualTo(8));
    }
}