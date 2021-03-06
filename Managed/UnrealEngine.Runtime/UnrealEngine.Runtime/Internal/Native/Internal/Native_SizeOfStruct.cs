﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#pragma warning disable 649 // Field is never assigned

namespace UnrealEngine.Runtime.Native
{
    static class Native_SizeOfStruct
    {
        public delegate int Del_SizeOf();

        public static Del_SizeOf SizeOf_FSoftObjectPtr;
        public static Del_SizeOf SizeOf_FWeakObjectPtr;
        public static Del_SizeOf SizeOf_FLazyObjectPtr;
        public static Del_SizeOf SizeOf_FSharedPtr;
        public static Del_SizeOf SizeOf_FSoftObjectPath;
        public static Del_SizeOf SizeOf_FUniqueObjectGuid;
        public static Del_SizeOf SizeOf_FAssetData;
        public static Del_SizeOf SizeOf_FName;
        public static Del_SizeOf SizeOf_FMinimalName;
        public static Del_SizeOf SizeOf_FScriptName;
        public static Del_SizeOf SizeOf_FScriptDelegate;
        public static Del_SizeOf SizeOf_FMulticastScriptDelegate;
        public static Del_SizeOf SizeOf_FScriptArray;
        public static Del_SizeOf SizeOf_FScriptMap;
        public static Del_SizeOf SizeOf_FScriptMapLayout;
        public static Del_SizeOf SizeOf_FScriptSetLayout;
        public static Del_SizeOf SizeOf_FScriptSparseArrayLayout;
        public static Del_SizeOf SizeOf_FDefaultBitArrayAllocator;
        public static Del_SizeOf SizeOf_FScriptBitArray;
        public static Del_SizeOf SizeOf_FScriptSparseArray;
        public static Del_SizeOf SizeOf_FBitReference;
        public static Del_SizeOf SizeOf_FHashAllocator;
        public static Del_SizeOf SizeOf_FSetElementId;
        public static Del_SizeOf SizeOf_FScriptSet;
        public static Del_SizeOf SizeOf_FImplementedInterfaceInterop;
        public static Del_SizeOf SizeOf_FNativeFunctionLookup;
        public static Del_SizeOf SizeOf_FDelegateHandle;
        public static Del_SizeOf SizeOf_TStatId;
        public static Del_SizeOf SizeOf_FText;
        public static Del_SizeOf SizeOf_FGuid;
        public static Del_SizeOf SizeOf_FActorSpawnParameters;
        public static Del_SizeOf SizeOf_FTickPrerequisite;
        public static Del_SizeOf SizeOf_FKey;
        public static Del_SizeOf SizeOf_FLifetimeProperty;
        public static Del_SizeOf SizeOf_FLatentActionInfo;
        public static Del_SizeOf SizeOf_FGameplayResourceSet;

        // Math structs
        public static Del_SizeOf SizeOf_FInterpCurvePointFloat;
        public static Del_SizeOf SizeOf_FInterpCurvePointLinearColor;
        public static Del_SizeOf SizeOf_FInterpCurvePointQuat;
        public static Del_SizeOf SizeOf_FInterpCurvePointTwoVectors;
        public static Del_SizeOf SizeOf_FInterpCurvePointVector;
        public static Del_SizeOf SizeOf_FInterpCurvePointVector2D;
        public static Del_SizeOf SizeOf_FFloatInterval;
        public static Del_SizeOf SizeOf_FInt32Interval;
        public static Del_SizeOf SizeOf_FFloatRange;
        public static Del_SizeOf SizeOf_FInt32Range;
        public static Del_SizeOf SizeOf_FFloatRangeBound;
        public static Del_SizeOf SizeOf_FInt32RangeBound;
        public static Del_SizeOf SizeOf_FBox;
        public static Del_SizeOf SizeOf_FBox2D;
        public static Del_SizeOf SizeOf_FBoxSphereBounds;
        public static Del_SizeOf SizeOf_FColor;
        public static Del_SizeOf SizeOf_FIntPoint;
        public static Del_SizeOf SizeOf_FIntRect;
        public static Del_SizeOf SizeOf_FIntVector;
        public static Del_SizeOf SizeOf_FIntVector4;
        public static Del_SizeOf SizeOf_FLinearColor;
        public static Del_SizeOf SizeOf_FMatrix;
        public static Del_SizeOf SizeOf_FOrientedBox;
        public static Del_SizeOf SizeOf_FPlane;
        public static Del_SizeOf SizeOf_FQuat;
        public static Del_SizeOf SizeOf_FRandomStream;
        public static Del_SizeOf SizeOf_FRotator;
        public static Del_SizeOf SizeOf_FSphere;
        public static Del_SizeOf SizeOf_FTransform;
        public static Del_SizeOf SizeOf_FTransform_IsVectorized;
        public static Del_SizeOf SizeOf_FTwoVectors;
        public static Del_SizeOf SizeOf_FVector;
        public static Del_SizeOf SizeOf_FVector2D;
        public static Del_SizeOf SizeOf_FVector4;

        // FTickFunction structs (we (dangerously) expect these to all be the same size to get the Target pointer)
        public static Del_SizeOf SizeOf_FActorComponentTickFunction;
        public static Del_SizeOf SizeOf_FActorTickFunction;
        public static Del_SizeOf SizeOf_FCharacterMovementComponentPostPhysicsTickFunction;
        public static Del_SizeOf SizeOf_FEndPhysicsTickFunction;
        public static Del_SizeOf SizeOf_FSkeletalMeshComponentClothTickFunction;
        public static Del_SizeOf SizeOf_FSkeletalMeshComponentEndPhysicsTickFunction;
        public static Del_SizeOf SizeOf_FStartPhysicsTickFunction;
    }
}
