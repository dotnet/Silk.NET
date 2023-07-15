// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tbs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "TPM_WNF_PROVISIONING"/> struct.</summary>
public static unsafe partial class TPM_WNF_PROVISIONINGTests
{
    /// <summary>Validates that the <see cref = "TPM_WNF_PROVISIONING"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TPM_WNF_PROVISIONING>(), Is.EqualTo(sizeof(TPM_WNF_PROVISIONING)));
    }

    /// <summary>Validates that the <see cref = "TPM_WNF_PROVISIONING"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TPM_WNF_PROVISIONING).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TPM_WNF_PROVISIONING"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TPM_WNF_PROVISIONING), Is.EqualTo(32));
    }
}