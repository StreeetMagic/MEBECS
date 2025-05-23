namespace ME.BECS {
    using BURST = Unity.Burst.BurstCompileAttribute;
    using Unity.Collections;
    using Unity.Collections.LowLevel.Unsafe;
    using UnityEngine.Scripting;
    using Unity.Burst;
    using Unity.Jobs.LowLevel.Unsafe;
    using ME.BECS.Jobs;
    using static Cuts;
    using s = System.Collections.Generic;
    public static unsafe class GraphGraphSmesharix_FeaturesGraphInitialize {
        public static NativeArray<System.IntPtr> graphNodes1001_SystemsCodeGenerator;
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.InitializeGraph))]
        public static void GraphInitialize_1001_SystemsCodeGenerator() {
            // Smesharix-FeaturesGraph
            var allocator = (AllocatorManager.AllocatorHandle)Constants.ALLOCATOR_DOMAIN;
            graphNodes1001_SystemsCodeGenerator = CollectionHelper.CreateNativeArray<System.IntPtr>(5, allocator);
            {
                var item = allocator.Allocate(TSize<ME.BECS.DestroyWithLifetimeSystem>.sizeInt, TAlign<ME.BECS.DestroyWithLifetimeSystem>.alignInt);
                *(ME.BECS.DestroyWithLifetimeSystem*)item = new ME.BECS.DestroyWithLifetimeSystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.DestroyWithLifetimeSystem>(1001, item);
                graphNodes1001_SystemsCodeGenerator[0] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>.sizeInt, TAlign<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>.alignInt);
                *(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem*)item = new ME.BECS.Transforms.TransformWorldMatrixUpdateSystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>(1001, item);
                graphNodes1001_SystemsCodeGenerator[1] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.DestroyWithTicksSystem>.sizeInt, TAlign<ME.BECS.DestroyWithTicksSystem>.alignInt);
                *(ME.BECS.DestroyWithTicksSystem*)item = new ME.BECS.DestroyWithTicksSystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.DestroyWithTicksSystem>(1001, item);
                graphNodes1001_SystemsCodeGenerator[2] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.Players.PlayersSystem>.sizeInt, TAlign<ME.BECS.Players.PlayersSystem>.alignInt);
                *(ME.BECS.Players.PlayersSystem*)item = new ME.BECS.Players.PlayersSystem {
                    playersCount = 4,
                }
                ;
                TSystemGraph.Register<ME.BECS.Players.PlayersSystem>(1001, item);
                graphNodes1001_SystemsCodeGenerator[3] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<Smesharix.Systems.ExampleSystem>.sizeInt, TAlign<Smesharix.Systems.ExampleSystem>.alignInt);
                *(Smesharix.Systems.ExampleSystem*)item = new Smesharix.Systems.ExampleSystem {
                    Config = new ME.BECS.Config {
                        sourceId = 0,
                    }
                    ,
                    Delay = 0f,
                }
                ;
                TSystemGraph.Register<Smesharix.Systems.ExampleSystem>(1001, item);
                graphNodes1001_SystemsCodeGenerator[4] = (System.IntPtr)item;
            }
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.GetSystem))]
        public static void GraphGetSystem_1001_SystemsCodeGenerator(int index, out void* ptr) {
            ptr = (void*)graphNodes1001_SystemsCodeGenerator[index];
        }
    }
     
}
