// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Silk.NET.Core.Native;
using Silk.NET.Direct3D12;
using Silk.NET.DXGI;
using Silk.NET.Maths;
using InfoQueueFilter = Silk.NET.Direct3D12.InfoQueueFilter;
using InfoQueueFilterDesc = Silk.NET.Direct3D12.InfoQueueFilterDesc;

namespace D3D12Triangle
{
    public abstract unsafe class DX12Sample : DXSample
    {
        private ID3D12Device* _d3dDevice;
        private IDXGIAdapter1* _dxgiAdapter;
        private IDXGIFactory4* _dxgiFactory;
        private IDXGISwapChain3* _swapChain;
        private ID3D12Resource*[] _renderTargets;
        private ID3D12Resource* _depthStencil;
        private ID3D12DescriptorHeap* _rtvHeap;
        private ID3D12DescriptorHeap* _dsvHeap;
        private ID3D12CommandQueue* _commandQueue;
        private ID3D12CommandAllocator*[] _commandAllocators;
        private Viewport _viewport;
        private Box2D<int> _scissorRect;
        private uint _rtvDescriptorSize;
        private Silk.NET.Direct3D12.D3D12 _d3d12;

        private ID3D12Fence* _fence;
        private ulong[] _fenceValues;
        private IntPtr _fenceEvent;

        private ID3D12GraphicsCommandList*[] _graphicsCommandLists;
        private ID3D12RootSignature* _rootSignature;
        private ID3D12PipelineState* _pipelineState;

        private bool _debug;

        private ID3D12InfoQueue* _infoQueue;
        private Task _infoPump;
        private CancellationTokenSource _infoPumpCancellationToken;

        protected DX12Sample(string name) : base(name)
        {
            _renderTargets = new ID3D12Resource*[2];
            _commandAllocators = new ID3D12CommandAllocator*[2];
            _fenceValues = new ulong[2];
            _graphicsCommandLists = new ID3D12GraphicsCommandList*[2];
            _d3d12 = Silk.NET.Direct3D12.D3D12.GetApi();
        }

        public Silk.NET.Direct3D12.D3D12 D3D12 => _d3d12;

        public ID3D12CommandAllocator* CommandAllocator => _commandAllocators[FrameIndex];

        public ID3D12CommandQueue* CommandQueue => _commandQueue;

        public ID3D12Device* D3DDevice => _d3dDevice;

        public ID3D12Resource* DepthStencil => _depthStencil;

        public ID3D12DescriptorHeap* DSVHeap => _dsvHeap;

        public IDXGIAdapter1* DxgiAdapter => _dxgiAdapter;

        public IDXGIFactory4* DxgiFactory => _dxgiFactory;

        public ID3D12Fence* Fence => _fence;

        public IntPtr FenceEvent => _fenceEvent;

        public ref ulong FenceValue => ref _fenceValues[FrameIndex];

        public ID3D12GraphicsCommandList* GraphicsCommandList => _graphicsCommandLists[FrameIndex];

        public ID3D12PipelineState* PipelineState => _pipelineState;

        public ID3D12Resource* RenderTarget => _renderTargets[FrameIndex];

        public ID3D12RootSignature* RootSignature => _rootSignature;

        public uint RTVDescriptorSize => _rtvDescriptorSize;

        public ID3D12DescriptorHeap* RTVHeap => _rtvHeap;

        public ref Box2D<int> ScissorRect => ref _scissorRect;

        public IDXGISwapChain3* SwapChain => _swapChain;

        public ref Viewport Viewport => ref _viewport;

        public override void OnDestroy()
        {
            WaitForGpu(moveToNextFrame: false);
            _infoPumpCancellationToken.Cancel();
            base.OnDestroy();
        }

        public override void OnRender()
        {
            PopulateGraphicsCommandList();
            ExecuteGraphicsCommandList();

            SilkMarshal.ThrowHResult(_swapChain->Present(SyncInterval: 1, Flags: 0));
            WaitForGpu(moveToNextFrame: true);

            void PopulateGraphicsCommandList()
            {
                WaitForGpu(moveToNextFrame: false);

                SilkMarshal.ThrowHResult(CommandAllocator->Reset());
                SilkMarshal.ThrowHResult(GraphicsCommandList->Reset(CommandAllocator, PipelineState));

                SetGraphicsCommandListState();

                TransitionForRender();

                var backgroundColor = BackgroundColor;

                // in d3dx12.h:
                // new CpuDescriptorHandle(RTVHeap->GetCPUDescriptorHandleForHeapStart(), (int)FrameIndex,
                //                         RTVDescriptorSize)
                var rtvHandle = new CpuDescriptorHandle
                {
                    Ptr = (nuint) ((long) @RTVHeap->GetCPUDescriptorHandleForHeapStart().Ptr +
                                   ((long) FrameIndex * (long) RTVDescriptorSize))
                };
                GraphicsCommandList->ClearRenderTargetView(rtvHandle, (float*) &backgroundColor, 0, null);

                var dsvHandle = DSVHeap->GetCPUDescriptorHandleForHeapStart();
                GraphicsCommandList->ClearDepthStencilView(dsvHandle, ClearFlags.Depth, 1, 0, 0, null);

                GraphicsCommandList->OMSetRenderTargets(1, &rtvHandle, 0, &dsvHandle);

                Draw();
                TransitionForPresent();

                SilkMarshal.ThrowHResult(GraphicsCommandList->Close());
            }
        }

        protected virtual void CreateAssets()
        {
            SilkMarshal.ThrowHResult(GraphicsCommandList->Close());
            ExecuteGraphicsCommandList();
            WaitForGpu(moveToNextFrame: false);
        }

        protected virtual ID3D12Resource* CreateDepthStencil()
        {
            ID3D12Resource* depthStencil;

            var heapProperties = new HeapProperties(HeapType.Default);

            var resourceDesc = new ResourceDesc
            (
                ResourceDimension.Texture2D,
                0ul,
                (ulong) Size.X,
                (uint) Size.Y,
                1,
                1,
                DepthBufferFormat,
                new SampleDesc() {Count = 1, Quality = 0},
                TextureLayout.LayoutUnknown,
                ResourceFlags.AllowDepthStencil
            );

            var clearValue = new ClearValue(DepthBufferFormat, depthStencil: new DepthStencilValue(1.0f, 0));

            var iid = ID3D12Resource.Guid;
            SilkMarshal.ThrowHResult
            (
                D3DDevice->CreateCommittedResource
                (
                    &heapProperties, HeapFlags.None, &resourceDesc, ResourceStates.DepthWrite,
                    &clearValue, &iid, (void**) &depthStencil
                )
            );

            var dsvDesc = new DepthStencilViewDesc
            {
                Format = DepthBufferFormat,
                ViewDimension = DsvDimension.Texture2D
            };
            D3DDevice->CreateDepthStencilView(depthStencil, &dsvDesc, DSVHeap->GetCPUDescriptorHandleForHeapStart());

            return depthStencil;
        }

        protected virtual void CreateDescriptorHeaps()
        {
            _rtvHeap = CreateRTVHeap(out _rtvDescriptorSize);
            _dsvHeap = CreateDSVHeap();

            ID3D12DescriptorHeap* CreateDSVHeap()
            {
                var dsvHeapDesc = new DescriptorHeapDesc
                {
                    NumDescriptors = 1,
                    Type = DescriptorHeapType.Dsv,
                };

                ID3D12DescriptorHeap* dsvHeap;

                var iid = ID3D12DescriptorHeap.Guid;
                SilkMarshal.ThrowHResult(D3DDevice->CreateDescriptorHeap(&dsvHeapDesc, &iid, (void**) &dsvHeap));

                return dsvHeap;
            }

            ID3D12DescriptorHeap* CreateRTVHeap(out uint rtvDescriptorSize)
            {
                var rtvHeapDesc = new DescriptorHeapDesc
                {
                    NumDescriptors = FrameCount,
                    Type = DescriptorHeapType.Rtv,
                };

                ID3D12DescriptorHeap* rtvHeap;

                var iid = ID3D12DescriptorHeap.Guid;
                SilkMarshal.ThrowHResult(D3DDevice->CreateDescriptorHeap(&rtvHeapDesc, &iid, (void**) &rtvHeap));

                rtvDescriptorSize = D3DDevice->GetDescriptorHandleIncrementSize
                    (DescriptorHeapType.Rtv);
                return rtvHeap;
            }
        }

        protected override void CreateDeviceDependentResources()
        {
            _dxgiFactory = CreateDxgiFactory();
            _dxgiAdapter = GetDxgiAdapter();
            _d3dDevice = CreateD3DDevice();
            StartInfoPump();
            _commandQueue = CreateCommandQueue();

            CreateDescriptorHeaps();

            for (int i = 0; i < FrameCount; i++)
            {
                _commandAllocators[i] = CreateCommandAllocator();
            }

            _fence = CreateFence();
            _fenceValues = CreateFenceValues();
            _fenceEvent = CreateFenceEvent();

            _rootSignature = CreateRootSignature();
            _pipelineState = CreatePipelineState();
            _graphicsCommandLists = CreateGraphicsCommandLists();

            SilkMarshal.ThrowHResult(CommandAllocator->Reset());
            SilkMarshal.ThrowHResult(GraphicsCommandList->Reset(CommandAllocator, PipelineState));

            CreateAssets();

            ID3D12CommandAllocator* CreateCommandAllocator()
            {
                ID3D12CommandAllocator* commandAllocator;

                var iid = ID3D12CommandAllocator.Guid;
                SilkMarshal.ThrowHResult
                (
                    D3DDevice->CreateCommandAllocator
                        (CommandListType.Direct, &iid, (void**) &commandAllocator)
                );

                return commandAllocator;
            }

            ID3D12CommandQueue* CreateCommandQueue()
            {
                var queueDesc = new CommandQueueDesc();

                ID3D12CommandQueue* commandQueue;

                var iid = ID3D12CommandQueue.Guid;
                SilkMarshal.ThrowHResult(D3DDevice->CreateCommandQueue(&queueDesc, &iid, (void**) &commandQueue));

                return commandQueue;
            }

            ID3D12Device* CreateD3DDevice()
            {
                ID3D12Device* d3dDevice;

                var iid = ID3D12Device.Guid;
                SilkMarshal.ThrowHResult
                (
                    D3D12.CreateDevice
                        ((IUnknown*) _dxgiAdapter, D3DFeatureLevel.Level110, &iid, (void**) &d3dDevice)
                );

                return d3dDevice;
            }

            IDXGIFactory4* CreateDxgiFactory()
            {
                var dxgiFactoryFlags = TryEnableDebugLayer() ? 0x01 : 0u;

                IDXGIFactory4* dxgiFactory;

                var iid = IDXGIFactory4.Guid;
                SilkMarshal.ThrowHResult(Dxgi.CreateDXGIFactory2(dxgiFactoryFlags, &iid, (void**) &dxgiFactory));

                return dxgiFactory;
            }

            ID3D12Fence* CreateFence()
            {
                ID3D12Fence* fence;

                var iid = ID3D12Fence.Guid;
                SilkMarshal.ThrowHResult
                    (D3DDevice->CreateFence(InitialValue: 0, FenceFlags.None, &iid, (void**) &fence));

                return fence;
            }

            IntPtr CreateFenceEvent()
            {
                var fenceEvent = SilkMarshal.CreateWindowsEvent(null, false, false, null);

                if (fenceEvent == IntPtr.Zero)
                {
                    var hr = Marshal.GetHRForLastWin32Error();
                    Marshal.ThrowExceptionForHR(hr);
                }

                return fenceEvent;
            }

            ulong[] CreateFenceValues()
            {
                var fenceValues = new ulong[FrameCount];
                fenceValues[0] = 1;
                return fenceValues;
            }

            ID3D12GraphicsCommandList*[] CreateGraphicsCommandLists()
            {
                var graphicsCommandLists = new ID3D12GraphicsCommandList*[FrameCount];

                for (uint i = 0u; i < FrameCount; i++)
                {
                    ID3D12GraphicsCommandList* graphicsCommandList;

                    var iid = ID3D12GraphicsCommandList.Guid;
                    SilkMarshal.ThrowHResult
                    (
                        D3DDevice->CreateCommandList
                        (
                            nodeMask: 0, CommandListType.Direct, _commandAllocators[i], PipelineState,
                            &iid, (void**) &graphicsCommandList
                        )
                    );

                    SilkMarshal.ThrowHResult(graphicsCommandList->Close());
                    graphicsCommandLists[i] = graphicsCommandList;
                }

                return graphicsCommandLists;
            }

            IDXGIAdapter1* GetDxgiAdapter()
            {
                if (UseWarpDevice)
                {
                    IDXGIAdapter1* adapter;

                    var iid = IDXGIAdapter.Guid;
                    SilkMarshal.ThrowHResult(_dxgiFactory->EnumWarpAdapter(&iid, (void**) &adapter));

                    return adapter;
                }
                else
                {
                    return GetHardwareAdapter((IDXGIFactory1*) _dxgiFactory);
                }
            }

            bool TryEnableDebugLayer()
            {
#if DEBUG
                // Enable the debug layer (requires the Graphics Tools "optional feature").
                // NOTE: Enabling the debug layer after device creation will invalidate the active device.

                using ComPtr<ID3D12Debug> debugController = null;
                var iid = ID3D12Debug.Guid;
                var hr = D3D12.GetDebugInterface(&iid, (void**) &debugController);

                if (HResult.IndicatesSuccess(hr))
                {
                    debugController.Get().EnableDebugLayer();
                    Log.LogInformation("Debug layer enabled");
                    return _debug = true;
                }
                else
                {
                    Log.LogWarning
                    (
                        Marshal.GetExceptionForHR(hr),
                        $"Failed to enable debug layer, failed with result {hr} (0x{hr:x8})"
                    );
                }
#endif

                return false;
            }

            void StartInfoPump()
            {
#if DEBUG
                if (!_debug)
                {
                    Log.LogInformation("Skipped creation of info pump due to the debug layer not being enabled.");
                    return;
                }

                var iid = ID3D12InfoQueue.Guid;
                fixed (ID3D12InfoQueue** @out = &_infoQueue)
                {
                    SilkMarshal.ThrowHResult(D3DDevice->QueryInterface(&iid, (void**) @out));
                }

                _infoPumpCancellationToken = new();
                _infoPump = Task.Run
                (
                    () =>
                    {
                        Log.LogInformation("Info queue pump started");
                        while (!_infoPumpCancellationToken.Token.IsCancellationRequested)
                        {
                            var numMessages = _infoQueue->GetNumStoredMessages();
                            if (numMessages == 0)
                            {
                                continue;
                            }

                            for (var i = 0ul; i < numMessages; i++)
                            {
                                nuint msgByteLength;
                                SilkMarshal.ThrowHResult(_infoQueue->GetMessageA(i, null, &msgByteLength));
                                using var memory = GlobalMemory.Allocate((int) msgByteLength);
                                SilkMarshal.ThrowHResult
                                (
                                    _infoQueue->GetMessageA(i, memory.AsPtr<Message>(), &msgByteLength)
                                );

                                ref var msg = ref memory.AsRef<Message>();
                                var descBytes = new Span<byte>(msg.PDescription, (int) msg.DescriptionByteLength);
                                var desc = Encoding.UTF8.GetString(descBytes[..^1]);
                                var eid = new EventId((int) msg.ID, msg.ID.ToString()["MessageID".Length..]);
                                var str = $"{msg.Category.ToString()["MessageCategory".Length..]} (From D3D12): {desc}";
                                switch (msg.Severity)
                                {
                                    case MessageSeverity.Corruption:
                                    {
                                        Log.LogCritical(eid, str);
                                        break;
                                    }
                                    case MessageSeverity.Error:
                                    {
                                        Log.LogError(eid, str);
                                        break;
                                    }
                                    case MessageSeverity.Warning:
                                    {
                                        Log.LogWarning(eid, str);
                                        break;
                                    }
                                    case MessageSeverity.Info:
                                    {
                                        Log.LogInformation(eid, str);
                                        break;
                                    }
                                    case MessageSeverity.Message:
                                    {
                                        Log.LogTrace(eid, str);
                                        break;
                                    }
                                    default:
                                        throw new ArgumentOutOfRangeException();
                                }
                            }

                            _infoQueue->ClearStoredMessages();
                        }

                        Log.LogInformation("Info queue pump stopped");
                    }, _infoPumpCancellationToken.Token
                );
#endif
            }
        }

        protected virtual ID3D12PipelineState* CreatePipelineState() => null;

        protected virtual void CreateRenderTargetViews()
        {
            var rtvHandle = RTVHeap->GetCPUDescriptorHandleForHeapStart();

            for (var i = 0u; i < FrameCount; i++)
            {
                D3DDevice->CreateRenderTargetView(_renderTargets[i], null, rtvHandle);
                rtvHandle.Ptr = (nuint) ((long) rtvHandle.Ptr + RTVDescriptorSize);
            }
        }

        protected virtual void CreateResourceViews()
        {
            FrameIndex = SwapChain->GetCurrentBackBufferIndex();

            _renderTargets = CreateRenderTargets();
            _depthStencil = CreateDepthStencil();

            CreateRenderTargetViews();

            ID3D12Resource*[] CreateRenderTargets()
            {
                var renderTargets = new ID3D12Resource*[FrameCount];
                var iid = ID3D12Resource.Guid;

                for (var i = 0u; i < FrameCount; i++)
                {
                    ID3D12Resource* renderTarget;
                    SilkMarshal.ThrowHResult(SwapChain->GetBuffer(i, &iid, (void**) &renderTarget));
                    renderTargets[unchecked((int) i)] = renderTarget;
                }

                return renderTargets;
            }
        }

        protected virtual ID3D12RootSignature* CreateRootSignature() => null;

        protected override void CreateWindowSizeDependentResources()
        {
            // Wait until all previous GPU work is complete.
            WaitForGpu(moveToNextFrame: false);

            // Clear the previous window size specific content and update the tracked fence values.
            for (var i = 0u; i < FrameCount; i++)
            {
                _renderTargets[i] = null;
                _fenceValues[i] = _fenceValues[FrameIndex];
            }

            if (_swapChain != null)
            {
                SilkMarshal.ThrowHResult
                    (_swapChain->ResizeBuffers(FrameCount, (uint) Size.X, (uint) Size.Y, BackBufferFormat, 0));
            }
            else
            {
                _swapChain = CreateSwapChain();
            }

            CreateResourceViews();

            _viewport = new Viewport
            {
                TopLeftX = 0,
                TopLeftY = 0,
                Width = Size.X,
                Height = Size.Y,
                MinDepth = 0,
                MaxDepth = 1
            };

            _scissorRect = new(Vector2D<int>.Zero, Size);

            IDXGISwapChain3* CreateSwapChain()
            {
                using ComPtr<IDXGISwapChain1> swapChain = null;

                var swapChainDesc = new SwapChainDesc1
                {
                    BufferCount = FrameCount,
                    Width = (uint) Size.X,
                    Height = (uint) Size.Y,
                    Format = BackBufferFormat,
                    BufferUsage = DXGI.UsageRenderTargetOutput,
                    SwapEffect = SwapEffect.FlipDiscard,
                    SampleDesc = new(1, 0),
                };

                SilkMarshal.ThrowHResult
                (
                    Window.CreateDxgiSwapchain
                    (
                        (IDXGIFactory2*) DxgiFactory,
                        (IUnknown*) _commandQueue, // Swap chain needs the queue so that it can force a flush on it.
                        &swapChainDesc,
                        pFullscreenDesc: null,
                        pRestrictToOutput: null,
                        swapChain.GetAddressOf()
                    )
                );

                IDXGISwapChain3* swapChain3;

                var iid = IDXGISwapChain3.Guid;
                SilkMarshal.ThrowHResult(swapChain.Get().QueryInterface(&iid, (void**) &swapChain3));

                return swapChain3;
            }
        }

        protected virtual void DestroyAssets()
        {
        }

        protected virtual void DestroyDescriptorHeaps()
        {
            DestroyDSVHeap();
            DestroyRTVHeap();

            void DestroyDSVHeap()
            {
                var dsvHeap = _dsvHeap;

                if (dsvHeap != null)
                {
                    _dsvHeap = null;
                    _ = dsvHeap->Release();
                }
            }

            void DestroyRTVHeap()
            {
                var rtvHeap = _rtvHeap;

                if (rtvHeap != null)
                {
                    _rtvHeap = null;
                    _ = rtvHeap->Release();
                }
            }
        }

        protected override void DestroyDeviceDependentResources()
        {
            DestroyAssets();

            DestroyGraphicsCommandLists();
            DestroyPipelineState();
            DestroyRootSignature();

            DestroyFenceEvent();
            DestroyFence();

            DestroyCommandAllocators();

            DestroyDescriptorHeaps();

            DestroyCommandQueue();
            DestroyD3DDevice();
            DestroyDxgiAdapter();
            DestroyDxgiFactory();

            void DestroyCommandAllocators()
            {
                for (var i = 0; i < _commandAllocators.Length; i++)
                {
                    var commandAllocator = _commandAllocators[i];

                    if (commandAllocator != null)
                    {
                        _commandAllocators[i] = null;
                        _ = commandAllocator->Release();
                    }
                }
            }

            void DestroyCommandQueue()
            {
                var commandQueue = _commandQueue;

                if (commandQueue != null)
                {
                    _commandQueue = null;
                    _ = commandQueue->Release();
                }
            }

            void DestroyD3DDevice()
            {
                var d3dDevice = _d3dDevice;

                if (d3dDevice != null)
                {
                    _d3dDevice = null;
                    _ = d3dDevice->Release();
                }
            }

            void DestroyDxgiAdapter()
            {
                var dxgiAdapter = _dxgiAdapter;

                if (dxgiAdapter != null)
                {
                    _dxgiAdapter = null;
                    _ = dxgiAdapter->Release();
                }
            }

            void DestroyDxgiFactory()
            {
                var dxgiFactory = _dxgiFactory;

                if (dxgiFactory != null)
                {
                    _dxgiFactory = null;
                    _ = dxgiFactory->Release();
                }
            }

            void DestroyFence()
            {
                var fence = _fence;

                if (fence != null)
                {
                    _fence = null;
                    _ = fence->Release();
                }
            }

            void DestroyFenceEvent()
            {
                var fenceEvent = _fenceEvent;

                if (fenceEvent != IntPtr.Zero)
                {
                    _fenceEvent = IntPtr.Zero;
                    _ = SilkMarshal.CloseWindowsHandle(_fenceEvent);
                }
            }

            void DestroyGraphicsCommandLists()
            {
                for (var i = 0; i < _graphicsCommandLists.Length; i++)
                {
                    var graphicsCommandList = _graphicsCommandLists[i];

                    if (graphicsCommandList != null)
                    {
                        _graphicsCommandLists[i] = null;
                        _ = graphicsCommandList->Release();
                    }
                }
            }

            void DestroyPipelineState()
            {
                var pipelineState = _pipelineState;

                if (pipelineState != null)
                {
                    _pipelineState = null;
                    _ = pipelineState->Release();
                }
            }

            void DestroyRootSignature()
            {
                var rootSignature = _rootSignature;

                if (rootSignature != null)
                {
                    _rootSignature = null;
                    _ = rootSignature->Release();
                }
            }
        }

        protected virtual void DestroyResourceViews()
        {
            DestroyDepthStencil();
            DestroyRenderTargets();

            void DestroyDepthStencil()
            {
                var depthStencil = _depthStencil;

                if (depthStencil != null)
                {
                    _depthStencil = null;
                    _ = depthStencil->Release();
                }
            }

            void DestroyRenderTargets()
            {
                for (var i = 0; i < _renderTargets.Length; i++)
                {
                    var renderTarget = _renderTargets[i];

                    if (renderTarget != null)
                    {
                        _renderTargets[i] = null;
                        _ = renderTarget->Release();
                    }
                }
            }
        }

        protected override void DestroyWindowSizeDependentResources()
        {
            DestroyResourceViews();
            DestroySwapChain();

            void DestroySwapChain()
            {
                var swapChain = _swapChain;

                if (swapChain != null)
                {
                    _swapChain = null;
                    _ = swapChain->Release();
                }
            }
        }

        protected abstract void Draw();

        protected virtual void SetGraphicsCommandListState()
        {
            GraphicsCommandList->SetGraphicsRootSignature(RootSignature);

            fixed (Viewport* viewport = &Viewport)
            {
                GraphicsCommandList->RSSetViewports(1, viewport);
            }

            fixed (Box2D<int>* scissorRect = &ScissorRect)
            {
                GraphicsCommandList->RSSetScissorRects(1, scissorRect);
            }
        }

        private static ResourceBarrier InitTransition
        (
            ID3D12Resource* pResource,
            ResourceStates stateBefore,
            ResourceStates stateAfter,
            uint subresource = D3D12.ResourceBarrierAllSubresources,
            ResourceBarrierFlags flags = ResourceBarrierFlags.None
        )
        {
            // TODO THIS IS A D3DX12 FUNCTION
            ResourceBarrier result = default;
            result.Type = ResourceBarrierType.Transition;
            result.Flags = flags;
            result.Anonymous.Transition.PResource = pResource;
            result.Anonymous.Transition.StateBefore = stateBefore;
            result.Anonymous.Transition.StateAfter = stateAfter;
            result.Anonymous.Transition.Subresource = subresource;
            return result;
        }

        protected virtual void TransitionForRender()
        {
            var barrier = InitTransition
                (RenderTarget, ResourceStates.Present, ResourceStates.RenderTarget);
            GraphicsCommandList->ResourceBarrier(1, &barrier);
        }

        protected virtual void TransitionForPresent()
        {
            var barrier = InitTransition
                (RenderTarget, ResourceStates.RenderTarget, ResourceStates.Present);
            GraphicsCommandList->ResourceBarrier(1, &barrier);
        }

        protected override unsafe bool SupportsRequiredDirect3DVersion(IDXGIAdapter1* adapter)
        {
            var iid = ID3D12Device.Guid;
            return HResult.IndicatesSuccess
                (D3D12.CreateDevice((IUnknown*) adapter, D3DFeatureLevel.Level110, &iid, null));
        }

        private void ExecuteGraphicsCommandList()
        {
            const int CommandListsCount = 1;
            var ppCommandLists = stackalloc ID3D12CommandList*[CommandListsCount]
            {
                (ID3D12CommandList*) GraphicsCommandList,
            };
            CommandQueue->ExecuteCommandLists(CommandListsCount, ppCommandLists);
        }

        private void WaitForGpu(bool moveToNextFrame)
        {
            // Schedule a Signal command in the queue.
            SilkMarshal.ThrowHResult(CommandQueue->Signal(Fence, FenceValue));

            if (moveToNextFrame)
            {
                FrameIndex = SwapChain->GetCurrentBackBufferIndex();
            }

            if (!moveToNextFrame || (Fence->GetCompletedValue() < FenceValue))
            {
                // Wait until the fence has been crossed.
                SilkMarshal.ThrowHResult(Fence->SetEventOnCompletion(FenceValue, FenceEvent.ToPointer()));
                _ = SilkMarshal.WaitWindowsObjects(FenceEvent);
            }

            // Increment the fence value for the current frame.
            FenceValue++;
        }
    }
}
