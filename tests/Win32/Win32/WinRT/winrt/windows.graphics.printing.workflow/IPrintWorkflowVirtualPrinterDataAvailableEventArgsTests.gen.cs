// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IPrintWorkflowVirtualPrinterDataAvailableEventArgs"/> struct.</summary>
public static unsafe partial class IPrintWorkflowVirtualPrinterDataAvailableEventArgsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IPrintWorkflowVirtualPrinterDataAvailableEventArgs"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IPrintWorkflowVirtualPrinterDataAvailableEventArgs).GUID,
            Is.EqualTo(IID_IPrintWorkflowVirtualPrinterDataAvailableEventArgs)
        );
    }

    /// <summary>Validates that the <see cref = "IPrintWorkflowVirtualPrinterDataAvailableEventArgs"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IPrintWorkflowVirtualPrinterDataAvailableEventArgs>(),
            Is.EqualTo(sizeof(IPrintWorkflowVirtualPrinterDataAvailableEventArgs))
        );
    }

    /// <summary>Validates that the <see cref = "IPrintWorkflowVirtualPrinterDataAvailableEventArgs"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(
            typeof(IPrintWorkflowVirtualPrinterDataAvailableEventArgs).IsLayoutSequential,
            Is.True
        );
    }

    /// <summary>Validates that the <see cref = "IPrintWorkflowVirtualPrinterDataAvailableEventArgs"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IPrintWorkflowVirtualPrinterDataAvailableEventArgs), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IPrintWorkflowVirtualPrinterDataAvailableEventArgs), Is.EqualTo(4));
        }
    }
}
