using ConanExiles;
using ConanExiles.Memory;
using ConanExiles.UnrealClasses;
using ConanExiles.UnrealStructures;
using ConanExilesGame.Script;


namespace ConanExilesGame.Script
{
	/// <summary>
	/// UBlueprintAsyncActionBase:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBlueprintAsyncActionBase:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UAddGuildMemberCallProxy:UBlueprintAsyncActionBase
	/// Size: 0x68
	/// Properties: 2
	/// </summary>
	public class UAddGuildMemberCallProxy:UBlueprintAsyncActionBase
	{
		public override int ObjectSize => 104;
		/// <summary>
		/// Name: PlayerId
		/// Type: ObjectProperty
		/// Offset: 0x50
		/// Size: 0x08
		/// </summary>
		public UUniqueID PlayerId => ReadUObject<UUniqueID>(0x50);
		
		/// <summary>
		/// Name: guildId
		/// Type: ObjectProperty
		/// Offset: 0x58
		/// Size: 0x08
		/// </summary>
		public UUniqueID guildId => ReadUObject<UUniqueID>(0x58);
		
	}


	/// <summary>
	/// UActorComponent:UObject
	/// Size: 0xD8
	/// Properties: 15
	/// </summary>
	public class UActorComponent:UObject
	{
		public override int ObjectSize => 216;
		/// <summary>
		/// Name: PrimaryComponentTick
		/// Type: StructProperty
		/// Offset: 0x30
		/// Size: 0x60
		/// </summary>
		public FActorComponentTickFunction PrimaryComponentTick => ReadStruct<FActorComponentTickFunction>(0x30);
		
		/// <summary>
		/// Name: ComponentTags
		/// Type: TArray<FName>
		/// Offset: 0x90
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		public TArray<FName> ComponentTags => new TArray<FName>(BaseAddress+0x90);
		
		/// <summary>
		/// Name: AssetUserData
		/// Type: TArray<UAssetUserData>
		/// Offset: 0xA0
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<UAssetUserData> AssetUserData => new TArray<UAssetUserData>(BaseAddress+0xA0);
		
		/// <summary>
		/// Name: bReplicates
		/// Type: BoolProperty
		/// Offset: 0xB0
		/// Size: 0x01
		/// </summary>
		public bool bReplicates => (ReadByte(0x00B0) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bIsClientOnly
		/// Type: BoolProperty
		/// Offset: 0xB0
		/// Size: 0x01
		/// </summary>
		public bool bIsClientOnly => (ReadByte(0x00B0) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bNetAddressable
		/// Type: BoolProperty
		/// Offset: 0xB0
		/// Size: 0x01
		/// </summary>
		public bool bNetAddressable => (ReadByte(0x00B0) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: bCreatedByConstructionScript
		/// Type: BoolProperty
		/// Offset: 0xB1
		/// Size: 0x01
		/// </summary>
		public bool bCreatedByConstructionScript => (ReadByte(0x00B1) & 0x80) == 0x80;
		
		/// <summary>
		/// Name: bInstanceComponent
		/// Type: BoolProperty
		/// Offset: 0xB2
		/// Size: 0x01
		/// </summary>
		public bool bInstanceComponent => (ReadByte(0x00B2) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bAutoActivate
		/// Type: BoolProperty
		/// Offset: 0xB2
		/// Size: 0x01
		/// </summary>
		public bool bAutoActivate => (ReadByte(0x00B2) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bIsActive
		/// Type: BoolProperty
		/// Offset: 0xB2
		/// Size: 0x01
		/// </summary>
		public bool bIsActive => (ReadByte(0x00B2) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bEditableWhenInherited
		/// Type: BoolProperty
		/// Offset: 0xB2
		/// Size: 0x01
		/// </summary>
		public bool bEditableWhenInherited => (ReadByte(0x00B2) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bCanEverAffectNavigation
		/// Type: BoolProperty
		/// Offset: 0xB2
		/// Size: 0x01
		/// </summary>
		public bool bCanEverAffectNavigation => (ReadByte(0x00B2) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: bWantsBeginPlay
		/// Type: BoolProperty
		/// Offset: 0xB2
		/// Size: 0x01
		/// </summary>
		public bool bWantsBeginPlay => (ReadByte(0x00B2) & 0x80) == 0x80;
		
		/// <summary>
		/// Name: CreationMethod
		/// Type: ByteProperty
		/// Offset: 0xB4
		/// Size: 0x01
		/// </summary>
		public byte CreationMethod
		{
			get
			{
				return ReadByte(0xB4);
			}
			set
			{
				WriteByte(0xB4,value);
			}
		}
		
		/// <summary>
		/// Name: UCSModifiedProperties
		/// Type: TArray<FSimpleMemberReference>
		/// Offset: 0xC0
		/// Size: 0x10
		/// SubElement Size: 0x20
		/// </summary>
		public TArray<FSimpleMemberReference> UCSModifiedProperties => new TArray<FSimpleMemberReference>(BaseAddress+0xC0);
		
	}


	/// <summary>
	/// USceneComponent:UActorComponent
	/// Size: 0x220
	/// Properties: 20
	/// </summary>
	public class USceneComponent:UActorComponent
	{
		public override int ObjectSize => 544;
		/// <summary>
		/// Name: AttachParent
		/// Type: ObjectProperty
		/// Offset: 0xD8
		/// Size: 0x08
		/// </summary>
		public USceneComponent AttachParent => ReadUObject<USceneComponent>(0xD8);
		
		/// <summary>
		/// Name: AttachChildren
		/// Type: TArray<USceneComponent>
		/// Offset: 0xE0
		/// Size: 0x10
		/// SubElement Size: 0x220
		/// </summary>
		public TArray<USceneComponent> AttachChildren => new TArray<USceneComponent>(BaseAddress+0xE0);
		
		/// <summary>
		/// Name: AttachSocketName
		/// Type: NameProperty
		/// Offset: 0xF0
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: bWorldToComponentUpdated
		/// Type: BoolProperty
		/// Offset: 0xF8
		/// Size: 0x01
		/// </summary>
		public bool bWorldToComponentUpdated => (ReadByte(0x00F8) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bAbsoluteLocation
		/// Type: BoolProperty
		/// Offset: 0xF8
		/// Size: 0x01
		/// </summary>
		public bool bAbsoluteLocation => (ReadByte(0x00F8) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bAbsoluteRotation
		/// Type: BoolProperty
		/// Offset: 0xF8
		/// Size: 0x01
		/// </summary>
		public bool bAbsoluteRotation => (ReadByte(0x00F8) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bAbsoluteScale
		/// Type: BoolProperty
		/// Offset: 0xF8
		/// Size: 0x01
		/// </summary>
		public bool bAbsoluteScale => (ReadByte(0x00F8) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bVisible
		/// Type: BoolProperty
		/// Offset: 0xF8
		/// Size: 0x01
		/// </summary>
		public bool bVisible => (ReadByte(0x00F8) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: bHiddenInGame
		/// Type: BoolProperty
		/// Offset: 0xF8
		/// Size: 0x01
		/// </summary>
		public bool bHiddenInGame => (ReadByte(0x00F8) & 0x40) == 0x40;
		
		/// <summary>
		/// Name: bShouldUpdatePhysicsVolume
		/// Type: BoolProperty
		/// Offset: 0xF8
		/// Size: 0x01
		/// </summary>
		public bool bShouldUpdatePhysicsVolume => (ReadByte(0x00F8) & 0x80) == 0x80;
		
		/// <summary>
		/// Name: bBoundsChangeTriggersStreamingDataRebuild
		/// Type: BoolProperty
		/// Offset: 0xF9
		/// Size: 0x01
		/// </summary>
		public bool bBoundsChangeTriggersStreamingDataRebuild => (ReadByte(0x00F9) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bUseAttachParentBound
		/// Type: BoolProperty
		/// Offset: 0xF9
		/// Size: 0x01
		/// </summary>
		public bool bUseAttachParentBound => (ReadByte(0x00F9) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bAbsoluteTranslation
		/// Type: BoolProperty
		/// Offset: 0xF9
		/// Size: 0x01
		/// </summary>
		public bool bAbsoluteTranslation => (ReadByte(0x00F9) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: RelativeLocation
		/// Type: StructProperty
		/// Offset: 0x170
		/// Size: 0x0C
		/// </summary>
		public FVector RelativeLocation => ReadStruct<FVector>(0x170);
		
		/// <summary>
		/// Name: RelativeRotation
		/// Type: StructProperty
		/// Offset: 0x17C
		/// Size: 0x0C
		/// </summary>
		public FRotator RelativeRotation => ReadStruct<FRotator>(0x17C);
		
		/// <summary>
		/// Name: RelativeScale3D
		/// Type: StructProperty
		/// Offset: 0x1B0
		/// Size: 0x0C
		/// </summary>
		public FVector RelativeScale3D => ReadStruct<FVector>(0x1B0);
		
		/// <summary>
		/// Name: RelativeTranslation
		/// Type: StructProperty
		/// Offset: 0x1BC
		/// Size: 0x0C
		/// </summary>
		public FVector RelativeTranslation => ReadStruct<FVector>(0x1BC);
		
		/// <summary>
		/// Name: Mobility
		/// Type: ByteProperty
		/// Offset: 0x1C8
		/// Size: 0x01
		/// </summary>
		public byte Mobility
		{
			get
			{
				return ReadByte(0x1C8);
			}
			set
			{
				WriteByte(0x1C8,value);
			}
		}
		
		/// <summary>
		/// Name: DetailMode
		/// Type: ByteProperty
		/// Offset: 0x1C9
		/// Size: 0x01
		/// </summary>
		public byte DetailMode
		{
			get
			{
				return ReadByte(0x1C9);
			}
			set
			{
				WriteByte(0x1C9,value);
			}
		}
		
		/// <summary>
		/// Name: ComponentVelocity
		/// Type: StructProperty
		/// Offset: 0x1E0
		/// Size: 0x0C
		/// </summary>
		public FVector ComponentVelocity => ReadStruct<FVector>(0x1E0);
		
	}


	/// <summary>
	/// UCameraComponent:USceneComponent
	/// Size: 0x640
	/// Properties: 13
	/// </summary>
	public class UCameraComponent:USceneComponent
	{
		public override int ObjectSize => 1600;
		/// <summary>
		/// Name: FieldOfView
		/// Type: FloatProperty
		/// Offset: 0x218
		/// Size: 0x04
		/// </summary>
		public float FieldOfView
		{
			get
			{
				return ReadSingle(0x218);
			}
			set
			{
				WriteSingle(0x218,value);
			}
		}
		
		/// <summary>
		/// Name: OrthoWidth
		/// Type: FloatProperty
		/// Offset: 0x21C
		/// Size: 0x04
		/// </summary>
		public float OrthoWidth
		{
			get
			{
				return ReadSingle(0x21C);
			}
			set
			{
				WriteSingle(0x21C,value);
			}
		}
		
		/// <summary>
		/// Name: OrthoNearClipPlane
		/// Type: FloatProperty
		/// Offset: 0x220
		/// Size: 0x04
		/// </summary>
		public float OrthoNearClipPlane
		{
			get
			{
				return ReadSingle(0x220);
			}
			set
			{
				WriteSingle(0x220,value);
			}
		}
		
		/// <summary>
		/// Name: OrthoFarClipPlane
		/// Type: FloatProperty
		/// Offset: 0x224
		/// Size: 0x04
		/// </summary>
		public float OrthoFarClipPlane
		{
			get
			{
				return ReadSingle(0x224);
			}
			set
			{
				WriteSingle(0x224,value);
			}
		}
		
		/// <summary>
		/// Name: AspectRatio
		/// Type: FloatProperty
		/// Offset: 0x228
		/// Size: 0x04
		/// </summary>
		public float AspectRatio
		{
			get
			{
				return ReadSingle(0x228);
			}
			set
			{
				WriteSingle(0x228,value);
			}
		}
		
		/// <summary>
		/// Name: bConstrainAspectRatio
		/// Type: BoolProperty
		/// Offset: 0x22C
		/// Size: 0x01
		/// </summary>
		public bool bConstrainAspectRatio => (ReadByte(0x022C) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bUseFieldOfViewForLOD
		/// Type: BoolProperty
		/// Offset: 0x22C
		/// Size: 0x01
		/// </summary>
		public bool bUseFieldOfViewForLOD => (ReadByte(0x022C) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bLockToHmd
		/// Type: BoolProperty
		/// Offset: 0x22C
		/// Size: 0x01
		/// </summary>
		public bool bLockToHmd => (ReadByte(0x022C) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bUsePawnControlRotation
		/// Type: BoolProperty
		/// Offset: 0x22C
		/// Size: 0x01
		/// </summary>
		public bool bUsePawnControlRotation => (ReadByte(0x022C) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: ProjectionMode
		/// Type: ByteProperty
		/// Offset: 0x230
		/// Size: 0x01
		/// </summary>
		public byte ProjectionMode
		{
			get
			{
				return ReadByte(0x230);
			}
			set
			{
				WriteByte(0x230,value);
			}
		}
		
		/// <summary>
		/// Name: PostProcessBlendWeight
		/// Type: FloatProperty
		/// Offset: 0x234
		/// Size: 0x04
		/// </summary>
		public float PostProcessBlendWeight
		{
			get
			{
				return ReadSingle(0x234);
			}
			set
			{
				WriteSingle(0x234,value);
			}
		}
		
		/// <summary>
		/// Name: PostProcessSettings
		/// Type: StructProperty
		/// Offset: 0x238
		/// Size: 0x3A0
		/// </summary>
		public FPostProcessSettings PostProcessSettings => ReadStruct<FPostProcessSettings>(0x238);
		
		/// <summary>
		/// Name: bUseControllerViewRotation
		/// Type: BoolProperty
		/// Offset: 0x638
		/// Size: 0x01
		/// </summary>
		public bool bUseControllerViewRotation => (ReadByte(0x0638) & 0x01) == 0x01;
		
	}


	/// <summary>
	/// UAdjustableCameraComponent:UCameraComponent
	/// Size: 0x650
	/// Properties: 1
	/// </summary>
	public class UAdjustableCameraComponent:UCameraComponent
	{
		public override int ObjectSize => 1616;
		/// <summary>
		/// Name: PerspectiveNearClipPlane
		/// Type: FloatProperty
		/// Offset: 0x640
		/// Size: 0x04
		/// </summary>
		public float PerspectiveNearClipPlane
		{
			get
			{
				return ReadSingle(0x640);
			}
			set
			{
				WriteSingle(0x640,value);
			}
		}
		
	}


	/// <summary>
	/// UPrimitiveComponent:USceneComponent
	/// Size: 0x5A0
	/// Properties: 69
	/// </summary>
	public class UPrimitiveComponent:USceneComponent
	{
		public override int ObjectSize => 1440;
		/// <summary>
		/// Name: MinDrawDistance
		/// Type: FloatProperty
		/// Offset: 0x220
		/// Size: 0x04
		/// </summary>
		public float MinDrawDistance
		{
			get
			{
				return ReadSingle(0x220);
			}
			set
			{
				WriteSingle(0x220,value);
			}
		}
		
		/// <summary>
		/// Name: LDMaxDrawDistance
		/// Type: FloatProperty
		/// Offset: 0x224
		/// Size: 0x04
		/// </summary>
		public float LDMaxDrawDistance
		{
			get
			{
				return ReadSingle(0x224);
			}
			set
			{
				WriteSingle(0x224,value);
			}
		}
		
		/// <summary>
		/// Name: CachedMaxDrawDistance
		/// Type: FloatProperty
		/// Offset: 0x228
		/// Size: 0x04
		/// </summary>
		public float CachedMaxDrawDistance
		{
			get
			{
				return ReadSingle(0x228);
			}
			set
			{
				WriteSingle(0x228,value);
			}
		}
		
		/// <summary>
		/// Name: DepthPriorityGroup
		/// Type: ByteProperty
		/// Offset: 0x22C
		/// Size: 0x01
		/// </summary>
		public byte DepthPriorityGroup
		{
			get
			{
				return ReadByte(0x22C);
			}
			set
			{
				WriteByte(0x22C,value);
			}
		}
		
		/// <summary>
		/// Name: ViewOwnerDepthPriorityGroup
		/// Type: ByteProperty
		/// Offset: 0x22D
		/// Size: 0x01
		/// </summary>
		public byte ViewOwnerDepthPriorityGroup
		{
			get
			{
				return ReadByte(0x22D);
			}
			set
			{
				WriteByte(0x22D,value);
			}
		}
		
		/// <summary>
		/// Name: bAlwaysCreatePhysicsState
		/// Type: BoolProperty
		/// Offset: 0x230
		/// Size: 0x01
		/// </summary>
		public bool bAlwaysCreatePhysicsState => (ReadByte(0x0230) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bGenerateOverlapEvents
		/// Type: BoolProperty
		/// Offset: 0x230
		/// Size: 0x01
		/// </summary>
		public bool bGenerateOverlapEvents => (ReadByte(0x0230) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bForceGenerateOverlapEvents
		/// Type: BoolProperty
		/// Offset: 0x230
		/// Size: 0x01
		/// </summary>
		public bool bForceGenerateOverlapEvents => (ReadByte(0x0230) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bMultiBodyOverlap
		/// Type: BoolProperty
		/// Offset: 0x230
		/// Size: 0x01
		/// </summary>
		public bool bMultiBodyOverlap => (ReadByte(0x0230) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bCheckAsyncSceneOnMove
		/// Type: BoolProperty
		/// Offset: 0x230
		/// Size: 0x01
		/// </summary>
		public bool bCheckAsyncSceneOnMove => (ReadByte(0x0230) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bTraceComplexOnMove
		/// Type: BoolProperty
		/// Offset: 0x230
		/// Size: 0x01
		/// </summary>
		public bool bTraceComplexOnMove => (ReadByte(0x0230) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: bReturnMaterialOnMove
		/// Type: BoolProperty
		/// Offset: 0x230
		/// Size: 0x01
		/// </summary>
		public bool bReturnMaterialOnMove => (ReadByte(0x0230) & 0x40) == 0x40;
		
		/// <summary>
		/// Name: bUseViewOwnerDepthPriorityGroup
		/// Type: BoolProperty
		/// Offset: 0x230
		/// Size: 0x01
		/// </summary>
		public bool bUseViewOwnerDepthPriorityGroup => (ReadByte(0x0230) & 0x80) == 0x80;
		
		/// <summary>
		/// Name: bAllowCullDistanceVolume
		/// Type: BoolProperty
		/// Offset: 0x231
		/// Size: 0x01
		/// </summary>
		public bool bAllowCullDistanceVolume => (ReadByte(0x0231) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bHasMotionBlurVelocityMeshes
		/// Type: BoolProperty
		/// Offset: 0x231
		/// Size: 0x01
		/// </summary>
		public bool bHasMotionBlurVelocityMeshes => (ReadByte(0x0231) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bRenderInMainPass
		/// Type: BoolProperty
		/// Offset: 0x231
		/// Size: 0x01
		/// </summary>
		public bool bRenderInMainPass => (ReadByte(0x0231) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bReceivesDecals
		/// Type: BoolProperty
		/// Offset: 0x231
		/// Size: 0x01
		/// </summary>
		public bool bReceivesDecals => (ReadByte(0x0231) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bOwnerNoSee
		/// Type: BoolProperty
		/// Offset: 0x231
		/// Size: 0x01
		/// </summary>
		public bool bOwnerNoSee => (ReadByte(0x0231) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bOnlyOwnerSee
		/// Type: BoolProperty
		/// Offset: 0x231
		/// Size: 0x01
		/// </summary>
		public bool bOnlyOwnerSee => (ReadByte(0x0231) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: bTreatAsBackgroundForOcclusion
		/// Type: BoolProperty
		/// Offset: 0x231
		/// Size: 0x01
		/// </summary>
		public bool bTreatAsBackgroundForOcclusion => (ReadByte(0x0231) & 0x40) == 0x40;
		
		/// <summary>
		/// Name: bHeightOutputReferenceSand
		/// Type: BoolProperty
		/// Offset: 0x231
		/// Size: 0x01
		/// </summary>
		public bool bHeightOutputReferenceSand => (ReadByte(0x0231) & 0x80) == 0x80;
		
		/// <summary>
		/// Name: bHeightOutputReferenceWater
		/// Type: BoolProperty
		/// Offset: 0x232
		/// Size: 0x01
		/// </summary>
		public bool bHeightOutputReferenceWater => (ReadByte(0x0232) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bHeightOutputIgnoreSand
		/// Type: BoolProperty
		/// Offset: 0x232
		/// Size: 0x01
		/// </summary>
		public bool bHeightOutputIgnoreSand => (ReadByte(0x0232) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bHeightOutputIgnoreWater
		/// Type: BoolProperty
		/// Offset: 0x232
		/// Size: 0x01
		/// </summary>
		public bool bHeightOutputIgnoreWater => (ReadByte(0x0232) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bCullFromDistantShadowCascades
		/// Type: BoolProperty
		/// Offset: 0x232
		/// Size: 0x01
		/// </summary>
		public bool bCullFromDistantShadowCascades => (ReadByte(0x0232) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bUseAsOccluder
		/// Type: BoolProperty
		/// Offset: 0x232
		/// Size: 0x01
		/// </summary>
		public bool bUseAsOccluder => (ReadByte(0x0232) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bSelectable
		/// Type: BoolProperty
		/// Offset: 0x232
		/// Size: 0x01
		/// </summary>
		public bool bSelectable => (ReadByte(0x0232) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: bForceMipStreaming
		/// Type: BoolProperty
		/// Offset: 0x232
		/// Size: 0x01
		/// </summary>
		public bool bForceMipStreaming => (ReadByte(0x0232) & 0x40) == 0x40;
		
		/// <summary>
		/// Name: bHasPerInstanceHitProxies
		/// Type: BoolProperty
		/// Offset: 0x232
		/// Size: 0x01
		/// </summary>
		public bool bHasPerInstanceHitProxies => (ReadByte(0x0232) & 0x80) == 0x80;
		
		/// <summary>
		/// Name: CastShadow
		/// Type: BoolProperty
		/// Offset: 0x233
		/// Size: 0x01
		/// </summary>
		public bool CastShadow => (ReadByte(0x0233) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bAffectDynamicIndirectLighting
		/// Type: BoolProperty
		/// Offset: 0x233
		/// Size: 0x01
		/// </summary>
		public bool bAffectDynamicIndirectLighting => (ReadByte(0x0233) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bAffectDistanceFieldLighting
		/// Type: BoolProperty
		/// Offset: 0x233
		/// Size: 0x01
		/// </summary>
		public bool bAffectDistanceFieldLighting => (ReadByte(0x0233) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bCastDynamicShadow
		/// Type: BoolProperty
		/// Offset: 0x233
		/// Size: 0x01
		/// </summary>
		public bool bCastDynamicShadow => (ReadByte(0x0233) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bCastStaticShadow
		/// Type: BoolProperty
		/// Offset: 0x233
		/// Size: 0x01
		/// </summary>
		public bool bCastStaticShadow => (ReadByte(0x0233) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bCastVolumetricTranslucentShadow
		/// Type: BoolProperty
		/// Offset: 0x233
		/// Size: 0x01
		/// </summary>
		public bool bCastVolumetricTranslucentShadow => (ReadByte(0x0233) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: bSelfShadowOnly
		/// Type: BoolProperty
		/// Offset: 0x233
		/// Size: 0x01
		/// </summary>
		public bool bSelfShadowOnly => (ReadByte(0x0233) & 0x40) == 0x40;
		
		/// <summary>
		/// Name: bCastFarShadow
		/// Type: BoolProperty
		/// Offset: 0x233
		/// Size: 0x01
		/// </summary>
		public bool bCastFarShadow => (ReadByte(0x0233) & 0x80) == 0x80;
		
		/// <summary>
		/// Name: bCastInsetShadow
		/// Type: BoolProperty
		/// Offset: 0x234
		/// Size: 0x01
		/// </summary>
		public bool bCastInsetShadow => (ReadByte(0x0234) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bCastCinematicShadow
		/// Type: BoolProperty
		/// Offset: 0x234
		/// Size: 0x01
		/// </summary>
		public bool bCastCinematicShadow => (ReadByte(0x0234) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bCastHiddenShadow
		/// Type: BoolProperty
		/// Offset: 0x234
		/// Size: 0x01
		/// </summary>
		public bool bCastHiddenShadow => (ReadByte(0x0234) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bCastShadowAsTwoSided
		/// Type: BoolProperty
		/// Offset: 0x234
		/// Size: 0x01
		/// </summary>
		public bool bCastShadowAsTwoSided => (ReadByte(0x0234) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bLightAsIfStatic
		/// Type: BoolProperty
		/// Offset: 0x234
		/// Size: 0x01
		/// </summary>
		public bool bLightAsIfStatic => (ReadByte(0x0234) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bLightAttachmentsAsGroup
		/// Type: BoolProperty
		/// Offset: 0x234
		/// Size: 0x01
		/// </summary>
		public bool bLightAttachmentsAsGroup => (ReadByte(0x0234) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: IndirectLightingCacheQuality
		/// Type: ByteProperty
		/// Offset: 0x238
		/// Size: 0x01
		/// </summary>
		public byte IndirectLightingCacheQuality
		{
			get
			{
				return ReadByte(0x238);
			}
			set
			{
				WriteByte(0x238,value);
			}
		}
		
		/// <summary>
		/// Name: bReceiveCombinedCSMAndStaticShadowsFromStationaryLights
		/// Type: BoolProperty
		/// Offset: 0x23C
		/// Size: 0x01
		/// </summary>
		public bool bReceiveCombinedCSMAndStaticShadowsFromStationaryLights => (ReadByte(0x023C) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bSingleSampleShadowFromStationaryLights
		/// Type: BoolProperty
		/// Offset: 0x23C
		/// Size: 0x01
		/// </summary>
		public bool bSingleSampleShadowFromStationaryLights => (ReadByte(0x023C) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: LightingChannels
		/// Type: StructProperty
		/// Offset: 0x240
		/// Size: 0x03
		/// </summary>
		public FLightingChannels LightingChannels => ReadStruct<FLightingChannels>(0x240);
		
		/// <summary>
		/// Name: bHasCachedStaticLighting
		/// Type: BoolProperty
		/// Offset: 0x243
		/// Size: 0x01
		/// </summary>
		public bool bHasCachedStaticLighting
		{
			get
			{
				return ReadBool(0x243);
			}
			set
			{
				WriteBool(0x243,value);
			}
		}
		
		/// <summary>
		/// Name: bStaticLightingBuildEnqueued
		/// Type: BoolProperty
		/// Offset: 0x244
		/// Size: 0x01
		/// </summary>
		public bool bStaticLightingBuildEnqueued
		{
			get
			{
				return ReadBool(0x244);
			}
			set
			{
				WriteBool(0x244,value);
			}
		}
		
		/// <summary>
		/// Name: bIgnoreRadialImpulse
		/// Type: BoolProperty
		/// Offset: 0x248
		/// Size: 0x01
		/// </summary>
		public bool bIgnoreRadialImpulse => (ReadByte(0x0248) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bIgnoreRadialForce
		/// Type: BoolProperty
		/// Offset: 0x248
		/// Size: 0x01
		/// </summary>
		public bool bIgnoreRadialForce => (ReadByte(0x0248) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: AlwaysLoadOnClient
		/// Type: BoolProperty
		/// Offset: 0x248
		/// Size: 0x01
		/// </summary>
		public bool AlwaysLoadOnClient => (ReadByte(0x0248) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: AlwaysLoadOnServer
		/// Type: BoolProperty
		/// Offset: 0x248
		/// Size: 0x01
		/// </summary>
		public bool AlwaysLoadOnServer => (ReadByte(0x0248) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bUseEditorCompositing
		/// Type: BoolProperty
		/// Offset: 0x248
		/// Size: 0x01
		/// </summary>
		public bool bUseEditorCompositing => (ReadByte(0x0248) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bRenderCustomDepth
		/// Type: BoolProperty
		/// Offset: 0x248
		/// Size: 0x01
		/// </summary>
		public bool bRenderCustomDepth => (ReadByte(0x0248) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: CustomDepthStencilValue
		/// Type: IntProperty
		/// Offset: 0x24C
		/// Size: 0x04
		/// </summary>
		public int CustomDepthStencilValue
		{
			get
			{
				return ReadInt32(0x24C);
			}
			set
			{
				WriteInt32(0x24C,value);
			}
		}
		
		/// <summary>
		/// Name: TranslucencySortPriority
		/// Type: IntProperty
		/// Offset: 0x250
		/// Size: 0x04
		/// </summary>
		public int TranslucencySortPriority
		{
			get
			{
				return ReadInt32(0x250);
			}
			set
			{
				WriteInt32(0x250,value);
			}
		}
		
		/// <summary>
		/// Name: VisibilityId
		/// Type: IntProperty
		/// Offset: 0x254
		/// Size: 0x04
		/// </summary>
		public int VisibilityId
		{
			get
			{
				return ReadInt32(0x254);
			}
			set
			{
				WriteInt32(0x254,value);
			}
		}
		
		/// <summary>
		/// Name: LpvBiasMultiplier
		/// Type: FloatProperty
		/// Offset: 0x25C
		/// Size: 0x04
		/// </summary>
		public float LpvBiasMultiplier
		{
			get
			{
				return ReadSingle(0x25C);
			}
			set
			{
				WriteSingle(0x25C,value);
			}
		}
		
		/// <summary>
		/// Name: BodyInstance
		/// Type: StructProperty
		/// Offset: 0x260
		/// Size: 0x1B0
		/// </summary>
		public FBodyInstance BodyInstance => ReadStruct<FBodyInstance>(0x260);
		
		/// <summary>
		/// Name: bHasCustomNavigableGeometry
		/// Type: ByteProperty
		/// Offset: 0x418
		/// Size: 0x01
		/// </summary>
		public byte bHasCustomNavigableGeometry
		{
			get
			{
				return ReadByte(0x418);
			}
			set
			{
				WriteByte(0x418,value);
			}
		}
		
		/// <summary>
		/// Name: BoundsScale
		/// Type: FloatProperty
		/// Offset: 0x41C
		/// Size: 0x04
		/// </summary>
		public float BoundsScale
		{
			get
			{
				return ReadSingle(0x41C);
			}
			set
			{
				WriteSingle(0x41C,value);
			}
		}
		
		/// <summary>
		/// Name: LastSubmitTime
		/// Type: FloatProperty
		/// Offset: 0x420
		/// Size: 0x04
		/// </summary>
		public float LastSubmitTime
		{
			get
			{
				return ReadSingle(0x420);
			}
			set
			{
				WriteSingle(0x420,value);
			}
		}
		
		/// <summary>
		/// Name: LastRenderTime
		/// Type: FloatProperty
		/// Offset: 0x424
		/// Size: 0x04
		/// </summary>
		public float LastRenderTime
		{
			get
			{
				return ReadSingle(0x424);
			}
			set
			{
				WriteSingle(0x424,value);
			}
		}
		
		/// <summary>
		/// Name: CanBeCharacterBase
		/// Type: ByteProperty
		/// Offset: 0x428
		/// Size: 0x01
		/// </summary>
		public byte CanBeCharacterBase
		{
			get
			{
				return ReadByte(0x428);
			}
			set
			{
				WriteByte(0x428,value);
			}
		}
		
		/// <summary>
		/// Name: CanCharacterStepUpOn
		/// Type: ByteProperty
		/// Offset: 0x42A
		/// Size: 0x01
		/// </summary>
		public byte CanCharacterStepUpOn
		{
			get
			{
				return ReadByte(0x42A);
			}
			set
			{
				WriteByte(0x42A,value);
			}
		}
		
		/// <summary>
		/// Name: MoveIgnoreActors
		/// Type: TArray<AActor>
		/// Offset: 0x430
		/// Size: 0x10
		/// SubElement Size: 0x3D0
		/// </summary>
		public TArray<AActor> MoveIgnoreActors => new TArray<AActor>(BaseAddress+0x430);
		
		/// <summary>
		/// Name: LODParentPrimitive
		/// Type: ObjectProperty
		/// Offset: 0x538
		/// Size: 0x08
		/// </summary>
		public UPrimitiveComponent LODParentPrimitive => ReadUObject<UPrimitiveComponent>(0x538);
		
		/// <summary>
		/// Name: PostPhysicsComponentTick
		/// Type: StructProperty
		/// Offset: 0x540
		/// Size: 0x60
		/// </summary>
		public FPrimitiveComponentPostPhysicsTickFunction PostPhysicsComponentTick => ReadStruct<FPrimitiveComponentPostPhysicsTickFunction>(0x540);
		
	}


	/// <summary>
	/// UMeshComponent:UPrimitiveComponent
	/// Size: 0x660
	/// Properties: 1
	/// </summary>
	public class UMeshComponent:UPrimitiveComponent
	{
		public override int ObjectSize => 1632;
		/// <summary>
		/// Name: OverrideMaterials
		/// Type: TArray<UMaterialInterface>
		/// Offset: 0x5A0
		/// Size: 0x10
		/// SubElement Size: 0x58
		/// </summary>
		public TArray<UMaterialInterface> OverrideMaterials => new TArray<UMaterialInterface>(BaseAddress+0x5A0);
		
	}


	/// <summary>
	/// UStaticMeshComponent:UMeshComponent
	/// Size: 0x6E0
	/// Properties: 21
	/// </summary>
	public class UStaticMeshComponent:UMeshComponent
	{
		public override int ObjectSize => 1760;
		/// <summary>
		/// Name: ForcedLodModel
		/// Type: IntProperty
		/// Offset: 0x658
		/// Size: 0x04
		/// </summary>
		public int ForcedLodModel
		{
			get
			{
				return ReadInt32(0x658);
			}
			set
			{
				WriteInt32(0x658,value);
			}
		}
		
		/// <summary>
		/// Name: PreviousLODLevel
		/// Type: IntProperty
		/// Offset: 0x65C
		/// Size: 0x04
		/// </summary>
		public int PreviousLODLevel
		{
			get
			{
				return ReadInt32(0x65C);
			}
			set
			{
				WriteInt32(0x65C,value);
			}
		}
		
		/// <summary>
		/// Name: bOverrideMinLOD
		/// Type: BoolProperty
		/// Offset: 0x660
		/// Size: 0x01
		/// </summary>
		public bool bOverrideMinLOD
		{
			get
			{
				return ReadBool(0x660);
			}
			set
			{
				WriteBool(0x660,value);
			}
		}
		
		/// <summary>
		/// Name: MinLOD
		/// Type: IntProperty
		/// Offset: 0x664
		/// Size: 0x04
		/// </summary>
		public int MinLOD
		{
			get
			{
				return ReadInt32(0x664);
			}
			set
			{
				WriteInt32(0x664,value);
			}
		}
		
		/// <summary>
		/// Name: StaticMesh
		/// Type: ObjectProperty
		/// Offset: 0x668
		/// Size: 0x08
		/// </summary>
		public UStaticMesh StaticMesh => ReadUObject<UStaticMesh>(0x668);
		
		/// <summary>
		/// Name: bOverrideWireframeColor
		/// Type: BoolProperty
		/// Offset: 0x670
		/// Size: 0x01
		/// </summary>
		public bool bOverrideWireframeColor
		{
			get
			{
				return ReadBool(0x670);
			}
			set
			{
				WriteBool(0x670,value);
			}
		}
		
		/// <summary>
		/// Name: WireframeColorOverride
		/// Type: StructProperty
		/// Offset: 0x674
		/// Size: 0x04
		/// </summary>
		public FColor WireframeColorOverride => ReadStruct<FColor>(0x674);
		
		/// <summary>
		/// Name: bOverrideNavigationExport
		/// Type: BoolProperty
		/// Offset: 0x678
		/// Size: 0x01
		/// </summary>
		public bool bOverrideNavigationExport => (ReadByte(0x0678) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bForceNavigationObstacle
		/// Type: BoolProperty
		/// Offset: 0x678
		/// Size: 0x01
		/// </summary>
		public bool bForceNavigationObstacle => (ReadByte(0x0678) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bDisallowMeshPaintPerInstance
		/// Type: BoolProperty
		/// Offset: 0x678
		/// Size: 0x01
		/// </summary>
		public bool bDisallowMeshPaintPerInstance => (ReadByte(0x0678) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bIgnoreInstanceForTextureStreaming
		/// Type: BoolProperty
		/// Offset: 0x678
		/// Size: 0x01
		/// </summary>
		public bool bIgnoreInstanceForTextureStreaming => (ReadByte(0x0678) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bOverrideLightMapRes
		/// Type: BoolProperty
		/// Offset: 0x678
		/// Size: 0x01
		/// </summary>
		public bool bOverrideLightMapRes => (ReadByte(0x0678) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: OverriddenLightMapRes
		/// Type: IntProperty
		/// Offset: 0x67C
		/// Size: 0x04
		/// </summary>
		public int OverriddenLightMapRes
		{
			get
			{
				return ReadInt32(0x67C);
			}
			set
			{
				WriteInt32(0x67C,value);
			}
		}
		
		/// <summary>
		/// Name: StreamingDistanceMultiplier
		/// Type: FloatProperty
		/// Offset: 0x680
		/// Size: 0x04
		/// </summary>
		public float StreamingDistanceMultiplier
		{
			get
			{
				return ReadSingle(0x680);
			}
			set
			{
				WriteSingle(0x680,value);
			}
		}
		
		/// <summary>
		/// Name: SubDivisionStepSize
		/// Type: IntProperty
		/// Offset: 0x684
		/// Size: 0x04
		/// </summary>
		public int SubDivisionStepSize
		{
			get
			{
				return ReadInt32(0x684);
			}
			set
			{
				WriteInt32(0x684,value);
			}
		}
		
		/// <summary>
		/// Name: bUseSubDivisions
		/// Type: BoolProperty
		/// Offset: 0x688
		/// Size: 0x01
		/// </summary>
		public bool bUseSubDivisions => (ReadByte(0x0688) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: IrrelevantLights
		/// Type: TArray<FGuid>
		/// Offset: 0x690
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FGuid> IrrelevantLights => new TArray<FGuid>(BaseAddress+0x690);
		
		/// <summary>
		/// Name: LODData
		/// Type: TArray<FStaticMeshComponentLODInfo>
		/// Offset: 0x6A0
		/// Size: 0x10
		/// SubElement Size: 0x98
		/// </summary>
		public TArray<FStaticMeshComponentLODInfo> LODData => new TArray<FStaticMeshComponentLODInfo>(BaseAddress+0x6A0);
		
		/// <summary>
		/// Name: StreamingTextureData
		/// Type: TArray<FStreamingTextureBuildInfo>
		/// Offset: 0x6B0
		/// Size: 0x10
		/// SubElement Size: 0x0C
		/// </summary>
		public TArray<FStreamingTextureBuildInfo> StreamingTextureData => new TArray<FStreamingTextureBuildInfo>(BaseAddress+0x6B0);
		
		/// <summary>
		/// Name: bUseDefaultCollision
		/// Type: BoolProperty
		/// Offset: 0x6C0
		/// Size: 0x01
		/// </summary>
		public bool bUseDefaultCollision
		{
			get
			{
				return ReadBool(0x6C0);
			}
			set
			{
				WriteBool(0x6C0,value);
			}
		}
		
		/// <summary>
		/// Name: LightmassSettings
		/// Type: StructProperty
		/// Offset: 0x6C4
		/// Size: 0x18
		/// </summary>
		public FLightmassPrimitiveSettings LightmassSettings => ReadStruct<FLightmassPrimitiveSettings>(0x6C4);
		
	}


	/// <summary>
	/// UInstancedStaticMeshComponent:UStaticMeshComponent
	/// Size: 0x780
	/// Properties: 9
	/// </summary>
	public class UInstancedStaticMeshComponent:UStaticMeshComponent
	{
		public override int ObjectSize => 1920;
		/// <summary>
		/// Name: PerInstanceSMData
		/// Type: TArray<FInstancedStaticMeshInstanceData>
		/// Offset: 0x6E0
		/// Size: 0x10
		/// SubElement Size: 0x50
		/// </summary>
		public TArray<FInstancedStaticMeshInstanceData> PerInstanceSMData => new TArray<FInstancedStaticMeshInstanceData>(BaseAddress+0x6E0);
		
		/// <summary>
		/// Name: InstancingRandomSeed
		/// Type: IntProperty
		/// Offset: 0x6F0
		/// Size: 0x04
		/// </summary>
		public int InstancingRandomSeed
		{
			get
			{
				return ReadInt32(0x6F0);
			}
			set
			{
				WriteInt32(0x6F0,value);
			}
		}
		
		/// <summary>
		/// Name: InstanceStartCullDistance
		/// Type: IntProperty
		/// Offset: 0x6F4
		/// Size: 0x04
		/// </summary>
		public int InstanceStartCullDistance
		{
			get
			{
				return ReadInt32(0x6F4);
			}
			set
			{
				WriteInt32(0x6F4,value);
			}
		}
		
		/// <summary>
		/// Name: InstanceEndCullDistance
		/// Type: IntProperty
		/// Offset: 0x6F8
		/// Size: 0x04
		/// </summary>
		public int InstanceEndCullDistance
		{
			get
			{
				return ReadInt32(0x6F8);
			}
			set
			{
				WriteInt32(0x6F8,value);
			}
		}
		
		/// <summary>
		/// Name: InstanceReorderTable
		/// Type: TArray<>
		/// Offset: 0x700
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: RemovedInstances
		/// Type: TArray<>
		/// Offset: 0x710
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: PhysicsSerializer
		/// Type: ObjectProperty
		/// Offset: 0x760
		/// Size: 0x08
		/// </summary>
		public UPhysicsSerializer PhysicsSerializer => ReadUObject<UPhysicsSerializer>(0x760);
		
		/// <summary>
		/// Name: NumPendingLightmaps
		/// Type: IntProperty
		/// Offset: 0x768
		/// Size: 0x04
		/// </summary>
		public int NumPendingLightmaps
		{
			get
			{
				return ReadInt32(0x768);
			}
			set
			{
				WriteInt32(0x768,value);
			}
		}
		
		/// <summary>
		/// Name: CachedMappings
		/// Type: TArray<FInstancedStaticMeshMappingInfo>
		/// Offset: 0x770
		/// Size: 0x10
		/// SubElement Size: 0x08
		/// </summary>
		public TArray<FInstancedStaticMeshMappingInfo> CachedMappings => new TArray<FInstancedStaticMeshMappingInfo>(BaseAddress+0x770);
		
	}


	/// <summary>
	/// UBuildingSocketComponent:UInstancedStaticMeshComponent
	/// Size: 0x7D0
	/// Properties: 1
	/// </summary>
	public class UBuildingSocketComponent:UInstancedStaticMeshComponent
	{
		public override int ObjectSize => 2000;
		/// <summary>
		/// Name: PerInstanceStaticSocketData
		/// Type: TArray<FSocketStaticData>
		/// Offset: 0x780
		/// Size: 0x10
		/// SubElement Size: 0x18
		/// </summary>
		public TArray<FSocketStaticData> PerInstanceStaticSocketData => new TArray<FSocketStaticData>(BaseAddress+0x780);
		
	}


	/// <summary>
	/// UInterface:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UInterface:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// USuspendableInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class USuspendableInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// AActor:UObject
	/// Size: 0x3D0
	/// Properties: 57
	/// </summary>
	public class AActor:UObject
	{
		public override int ObjectSize => 976;
		/// <summary>
		/// Name: PrimaryActorTick
		/// Type: StructProperty
		/// Offset: 0x28
		/// Size: 0x60
		/// </summary>
		public FActorTickFunction PrimaryActorTick => ReadStruct<FActorTickFunction>(0x28);
		
		/// <summary>
		/// Name: CustomTimeDilation
		/// Type: FloatProperty
		/// Offset: 0x88
		/// Size: 0x04
		/// </summary>
		public float CustomTimeDilation
		{
			get
			{
				return ReadSingle(0x88);
			}
			set
			{
				WriteSingle(0x88,value);
			}
		}
		
		/// <summary>
		/// Name: bHidden
		/// Type: BoolProperty
		/// Offset: 0x8C
		/// Size: 0x01
		/// </summary>
		public bool bHidden => (ReadByte(0x008C) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bNetTemporary
		/// Type: BoolProperty
		/// Offset: 0x8C
		/// Size: 0x01
		/// </summary>
		public bool bNetTemporary => (ReadByte(0x008C) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bNetStartup
		/// Type: BoolProperty
		/// Offset: 0x8C
		/// Size: 0x01
		/// </summary>
		public bool bNetStartup => (ReadByte(0x008C) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bOnlyRelevantToOwner
		/// Type: BoolProperty
		/// Offset: 0x8C
		/// Size: 0x01
		/// </summary>
		public bool bOnlyRelevantToOwner => (ReadByte(0x008C) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bAlwaysRelevant
		/// Type: BoolProperty
		/// Offset: 0x8C
		/// Size: 0x01
		/// </summary>
		public bool bAlwaysRelevant => (ReadByte(0x008C) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bReplicateMovement
		/// Type: BoolProperty
		/// Offset: 0x8C
		/// Size: 0x01
		/// </summary>
		public bool bReplicateMovement => (ReadByte(0x008C) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: bTearOff
		/// Type: BoolProperty
		/// Offset: 0x8C
		/// Size: 0x01
		/// </summary>
		public bool bTearOff => (ReadByte(0x008C) & 0x40) == 0x40;
		
		/// <summary>
		/// Name: bExchangedRoles
		/// Type: BoolProperty
		/// Offset: 0x8C
		/// Size: 0x01
		/// </summary>
		public bool bExchangedRoles => (ReadByte(0x008C) & 0x80) == 0x80;
		
		/// <summary>
		/// Name: bPendingNetUpdate
		/// Type: BoolProperty
		/// Offset: 0x8D
		/// Size: 0x01
		/// </summary>
		public bool bPendingNetUpdate => (ReadByte(0x008D) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bNetLoadOnClient
		/// Type: BoolProperty
		/// Offset: 0x8D
		/// Size: 0x01
		/// </summary>
		public bool bNetLoadOnClient => (ReadByte(0x008D) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bNetUseOwnerRelevancy
		/// Type: BoolProperty
		/// Offset: 0x8D
		/// Size: 0x01
		/// </summary>
		public bool bNetUseOwnerRelevancy => (ReadByte(0x008D) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bBlockInput
		/// Type: BoolProperty
		/// Offset: 0x8D
		/// Size: 0x01
		/// </summary>
		public bool bBlockInput => (ReadByte(0x008D) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bAllowTickBeforeBeginPlay
		/// Type: BoolProperty
		/// Offset: 0x8D
		/// Size: 0x01
		/// </summary>
		public bool bAllowTickBeforeBeginPlay => (ReadByte(0x008D) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: bActorEnableCollision
		/// Type: BoolProperty
		/// Offset: 0x8E
		/// Size: 0x01
		/// </summary>
		public bool bActorEnableCollision => (ReadByte(0x008E) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bReplicates
		/// Type: BoolProperty
		/// Offset: 0x8E
		/// Size: 0x01
		/// </summary>
		public bool bReplicates => (ReadByte(0x008E) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bLostRelevancy
		/// Type: BoolProperty
		/// Offset: 0x8E
		/// Size: 0x01
		/// </summary>
		public bool bLostRelevancy => (ReadByte(0x008E) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: NetDriverName
		/// Type: NameProperty
		/// Offset: 0x90
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: RemoteRole
		/// Type: ByteProperty
		/// Offset: 0x98
		/// Size: 0x01
		/// </summary>
		public byte RemoteRole
		{
			get
			{
				return ReadByte(0x98);
			}
			set
			{
				WriteByte(0x98,value);
			}
		}
		
		/// <summary>
		/// Name: Owner
		/// Type: ObjectProperty
		/// Offset: 0xA0
		/// Size: 0x08
		/// </summary>
		public AActor Owner => ReadUObject<AActor>(0xA0);
		
		/// <summary>
		/// Name: ReplicatedMovement
		/// Type: StructProperty
		/// Offset: 0xA8
		/// Size: 0x34
		/// </summary>
		public FRepMovement ReplicatedMovement => ReadStruct<FRepMovement>(0xA8);
		
		/// <summary>
		/// Name: AttachmentReplication
		/// Type: StructProperty
		/// Offset: 0xE0
		/// Size: 0x40
		/// </summary>
		public FRepAttachment AttachmentReplication => ReadStruct<FRepAttachment>(0xE0);
		
		/// <summary>
		/// Name: Role
		/// Type: ByteProperty
		/// Offset: 0x120
		/// Size: 0x01
		/// </summary>
		public byte Role
		{
			get
			{
				return ReadByte(0x120);
			}
			set
			{
				WriteByte(0x120,value);
			}
		}
		
		/// <summary>
		/// Name: AutoReceiveInput
		/// Type: ByteProperty
		/// Offset: 0x122
		/// Size: 0x01
		/// </summary>
		public byte AutoReceiveInput
		{
			get
			{
				return ReadByte(0x122);
			}
			set
			{
				WriteByte(0x122,value);
			}
		}
		
		/// <summary>
		/// Name: InputPriority
		/// Type: IntProperty
		/// Offset: 0x124
		/// Size: 0x04
		/// </summary>
		public int InputPriority
		{
			get
			{
				return ReadInt32(0x124);
			}
			set
			{
				WriteInt32(0x124,value);
			}
		}
		
		/// <summary>
		/// Name: InputComponent
		/// Type: ObjectProperty
		/// Offset: 0x128
		/// Size: 0x08
		/// </summary>
		public UInputComponent InputComponent => ReadUObject<UInputComponent>(0x128);
		
		/// <summary>
		/// Name: InputConsumeOption
		/// Type: ByteProperty
		/// Offset: 0x130
		/// Size: 0x01
		/// </summary>
		public byte InputConsumeOption
		{
			get
			{
				return ReadByte(0x130);
			}
			set
			{
				WriteByte(0x130,value);
			}
		}
		
		/// <summary>
		/// Name: NetCullDistanceSquared
		/// Type: FloatProperty
		/// Offset: 0x134
		/// Size: 0x04
		/// </summary>
		public float NetCullDistanceSquared
		{
			get
			{
				return ReadSingle(0x134);
			}
			set
			{
				WriteSingle(0x134,value);
			}
		}
		
		/// <summary>
		/// Name: NetTag
		/// Type: IntProperty
		/// Offset: 0x138
		/// Size: 0x04
		/// </summary>
		public int NetTag
		{
			get
			{
				return ReadInt32(0x138);
			}
			set
			{
				WriteInt32(0x138,value);
			}
		}
		
		/// <summary>
		/// Name: NetUpdateTime
		/// Type: FloatProperty
		/// Offset: 0x13C
		/// Size: 0x04
		/// </summary>
		public float NetUpdateTime
		{
			get
			{
				return ReadSingle(0x13C);
			}
			set
			{
				WriteSingle(0x13C,value);
			}
		}
		
		/// <summary>
		/// Name: NetUpdateFrequency
		/// Type: FloatProperty
		/// Offset: 0x140
		/// Size: 0x04
		/// </summary>
		public float NetUpdateFrequency
		{
			get
			{
				return ReadSingle(0x140);
			}
			set
			{
				WriteSingle(0x140,value);
			}
		}
		
		/// <summary>
		/// Name: MinNetUpdateFrequency
		/// Type: FloatProperty
		/// Offset: 0x144
		/// Size: 0x04
		/// </summary>
		public float MinNetUpdateFrequency
		{
			get
			{
				return ReadSingle(0x144);
			}
			set
			{
				WriteSingle(0x144,value);
			}
		}
		
		/// <summary>
		/// Name: NetPriority
		/// Type: FloatProperty
		/// Offset: 0x148
		/// Size: 0x04
		/// </summary>
		public float NetPriority
		{
			get
			{
				return ReadSingle(0x148);
			}
			set
			{
				WriteSingle(0x148,value);
			}
		}
		
		/// <summary>
		/// Name: LastNetUpdateTime
		/// Type: FloatProperty
		/// Offset: 0x14C
		/// Size: 0x04
		/// </summary>
		public float LastNetUpdateTime
		{
			get
			{
				return ReadSingle(0x14C);
			}
			set
			{
				WriteSingle(0x14C,value);
			}
		}
		
		/// <summary>
		/// Name: bAutoDestroyWhenFinished
		/// Type: BoolProperty
		/// Offset: 0x150
		/// Size: 0x01
		/// </summary>
		public bool bAutoDestroyWhenFinished => (ReadByte(0x0150) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bCanBeDamaged
		/// Type: BoolProperty
		/// Offset: 0x150
		/// Size: 0x01
		/// </summary>
		public bool bCanBeDamaged => (ReadByte(0x0150) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bActorIsBeingDestroyed
		/// Type: BoolProperty
		/// Offset: 0x150
		/// Size: 0x01
		/// </summary>
		public bool bActorIsBeingDestroyed => (ReadByte(0x0150) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bCollideWhenPlacing
		/// Type: BoolProperty
		/// Offset: 0x150
		/// Size: 0x01
		/// </summary>
		public bool bCollideWhenPlacing => (ReadByte(0x0150) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bFindCameraComponentWhenViewTarget
		/// Type: BoolProperty
		/// Offset: 0x150
		/// Size: 0x01
		/// </summary>
		public bool bFindCameraComponentWhenViewTarget => (ReadByte(0x0150) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bRelevantForNetworkReplays
		/// Type: BoolProperty
		/// Offset: 0x150
		/// Size: 0x01
		/// </summary>
		public bool bRelevantForNetworkReplays => (ReadByte(0x0150) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: SpawnCollisionHandlingMethod
		/// Type: ByteProperty
		/// Offset: 0x151
		/// Size: 0x01
		/// </summary>
		public byte SpawnCollisionHandlingMethod
		{
			get
			{
				return ReadByte(0x151);
			}
			set
			{
				WriteByte(0x151,value);
			}
		}
		
		/// <summary>
		/// Name: Instigator
		/// Type: ObjectProperty
		/// Offset: 0x158
		/// Size: 0x08
		/// </summary>
		public APawn Instigator => ReadUObject<APawn>(0x158);
		
		/// <summary>
		/// Name: Children
		/// Type: TArray<AActor>
		/// Offset: 0x160
		/// Size: 0x10
		/// SubElement Size: 0x3D0
		/// </summary>
		public TArray<AActor> Children => new TArray<AActor>(BaseAddress+0x160);
		
		/// <summary>
		/// Name: RootComponent
		/// Type: ObjectProperty
		/// Offset: 0x170
		/// Size: 0x08
		/// </summary>
		public USceneComponent RootComponent => ReadUObject<USceneComponent>(0x170);
		
		/// <summary>
		/// Name: ControllingMatineeActors
		/// Type: TArray<AMatineeActor>
		/// Offset: 0x178
		/// Size: 0x10
		/// SubElement Size: 0x478
		/// </summary>
		public TArray<AMatineeActor> ControllingMatineeActors => new TArray<AMatineeActor>(BaseAddress+0x178);
		
		/// <summary>
		/// Name: InitialLifeSpan
		/// Type: FloatProperty
		/// Offset: 0x188
		/// Size: 0x04
		/// </summary>
		public float InitialLifeSpan
		{
			get
			{
				return ReadSingle(0x188);
			}
			set
			{
				WriteSingle(0x188,value);
			}
		}
		
		/// <summary>
		/// Name: Layers
		/// Type: TArray<FName>
		/// Offset: 0x198
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		public TArray<FName> Layers => new TArray<FName>(BaseAddress+0x198);
		
		/// <summary>
		/// Name: bAllowReceiveTickEventOnDedicatedServer
		/// Type: BoolProperty
		/// Offset: 0x1B8
		/// Size: 0x01
		/// </summary>
		public bool bAllowReceiveTickEventOnDedicatedServer => (ReadByte(0x01B8) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bUseExtendedRelevancyTimeout
		/// Type: BoolProperty
		/// Offset: 0x1B8
		/// Size: 0x01
		/// </summary>
		public bool bUseExtendedRelevancyTimeout => (ReadByte(0x01B8) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bActorSeamlessTraveled
		/// Type: BoolProperty
		/// Offset: 0x1B8
		/// Size: 0x01
		/// </summary>
		public bool bActorSeamlessTraveled => (ReadByte(0x01B8) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: bIgnoresOriginShifting
		/// Type: BoolProperty
		/// Offset: 0x1B8
		/// Size: 0x01
		/// </summary>
		public bool bIgnoresOriginShifting => (ReadByte(0x01B8) & 0x40) == 0x40;
		
		/// <summary>
		/// Name: bEnableAutoLODGeneration
		/// Type: BoolProperty
		/// Offset: 0x1B8
		/// Size: 0x01
		/// </summary>
		public bool bEnableAutoLODGeneration => (ReadByte(0x01B8) & 0x80) == 0x80;
		
		/// <summary>
		/// Name: Tags
		/// Type: TArray<FName>
		/// Offset: 0x1C0
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		public TArray<FName> Tags => new TArray<FName>(BaseAddress+0x1C0);
		
		/// <summary>
		/// Name: HiddenEditorViews
		/// Type: UInt64Property
		/// Offset: 0x1D0
		/// Size: 0x08
		/// </summary>
		public ulong HiddenEditorViews
		{
			get
			{
				return ReadUInt64(0x1D0);
			}
			set
			{
				WriteUInt64(0x1D0,value);
			}
		}
		
		/// <summary>
		/// Name: BlueprintCreatedComponents
		/// Type: TArray<UActorComponent>
		/// Offset: 0x3A8
		/// Size: 0x10
		/// SubElement Size: 0xD8
		/// </summary>
		public TArray<UActorComponent> BlueprintCreatedComponents => new TArray<UActorComponent>(BaseAddress+0x3A8);
		
		/// <summary>
		/// Name: InstanceComponents
		/// Type: TArray<UActorComponent>
		/// Offset: 0x3B8
		/// Size: 0x10
		/// SubElement Size: 0xD8
		/// </summary>
		public TArray<UActorComponent> InstanceComponents => new TArray<UActorComponent>(BaseAddress+0x3B8);
		
	}


	/// <summary>
	/// ABuildableBase:AActor
	/// Size: 0x490
	/// Properties: 21
	/// </summary>
	public class ABuildableBase:AActor
	{
		public override int ObjectSize => 1168;
		/// <summary>
		/// Name: SourceItemTemplateID
		/// Type: IntProperty
		/// Offset: 0x3D8
		/// Size: 0x04
		/// </summary>
		public int SourceItemTemplateID
		{
			get
			{
				return ReadInt32(0x3D8);
			}
			set
			{
				WriteInt32(0x3D8,value);
			}
		}
		
		/// <summary>
		/// Name: IsABrush
		/// Type: BoolProperty
		/// Offset: 0x3DC
		/// Size: 0x01
		/// </summary>
		public bool IsABrush
		{
			get
			{
				return ReadBool(0x3DC);
			}
			set
			{
				WriteBool(0x3DC,value);
			}
		}
		
		/// <summary>
		/// Name: BuildSockets
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UBuildingSocketComponent BuildSockets => ReadUObject<UBuildingSocketComponent>(0x3E0);
		
		/// <summary>
		/// Name: IsSnappedToSocket
		/// Type: BoolProperty
		/// Offset: 0x3E8
		/// Size: 0x01
		/// </summary>
		public bool IsSnappedToSocket
		{
			get
			{
				return ReadBool(0x3E8);
			}
			set
			{
				WriteBool(0x3E8,value);
			}
		}
		
		/// <summary>
		/// Name: TargetSocketTypes
		/// Type: TArray<>
		/// Offset: 0x3F0
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: MaxHealth
		/// Type: IntProperty
		/// Offset: 0x400
		/// Size: 0x04
		/// </summary>
		public int MaxHealth
		{
			get
			{
				return ReadInt32(0x400);
			}
			set
			{
				WriteInt32(0x400,value);
			}
		}
		
		/// <summary>
		/// Name: CurrentHealth
		/// Type: IntProperty
		/// Offset: 0x404
		/// Size: 0x04
		/// </summary>
		public int CurrentHealth
		{
			get
			{
				return ReadInt32(0x404);
			}
			set
			{
				WriteInt32(0x404,value);
			}
		}
		
		/// <summary>
		/// Name: AffectedByDamageTiers
		/// Type: IntProperty
		/// Offset: 0x408
		/// Size: 0x04
		/// </summary>
		public int AffectedByDamageTiers
		{
			get
			{
				return ReadInt32(0x408);
			}
			set
			{
				WriteInt32(0x408,value);
			}
		}
		
		/// <summary>
		/// Name: ClaimRadiusBuilding
		/// Type: FloatProperty
		/// Offset: 0x40C
		/// Size: 0x04
		/// </summary>
		public float ClaimRadiusBuilding
		{
			get
			{
				return ReadSingle(0x40C);
			}
			set
			{
				WriteSingle(0x40C,value);
			}
		}
		
		/// <summary>
		/// Name: ClaimRadiusFoliage
		/// Type: FloatProperty
		/// Offset: 0x410
		/// Size: 0x04
		/// </summary>
		public float ClaimRadiusFoliage
		{
			get
			{
				return ReadSingle(0x410);
			}
			set
			{
				WriteSingle(0x410,value);
			}
		}
		
		/// <summary>
		/// Name: EnforceLandclaim
		/// Type: BoolProperty
		/// Offset: 0x414
		/// Size: 0x01
		/// </summary>
		public bool EnforceLandclaim
		{
			get
			{
				return ReadBool(0x414);
			}
			set
			{
				WriteBool(0x414,value);
			}
		}
		
		/// <summary>
		/// Name: ClaimLocation
		/// Type: StructProperty
		/// Offset: 0x418
		/// Size: 0x0C
		/// </summary>
		public FVector ClaimLocation => ReadStruct<FVector>(0x418);
		
		/// <summary>
		/// Name: TemplateId
		/// Type: IntProperty
		/// Offset: 0x424
		/// Size: 0x04
		/// </summary>
		public int TemplateId
		{
			get
			{
				return ReadInt32(0x424);
			}
			set
			{
				WriteInt32(0x424,value);
			}
		}
		
		/// <summary>
		/// Name: BuildingPieceScore
		/// Type: IntProperty
		/// Offset: 0x428
		/// Size: 0x04
		/// </summary>
		public int BuildingPieceScore
		{
			get
			{
				return ReadInt32(0x428);
			}
			set
			{
				WriteInt32(0x428,value);
			}
		}
		
		/// <summary>
		/// Name: BuildingScore
		/// Type: IntProperty
		/// Offset: 0x42C
		/// Size: 0x04
		/// </summary>
		public int BuildingScore
		{
			get
			{
				return ReadInt32(0x42C);
			}
			set
			{
				WriteInt32(0x42C,value);
			}
		}
		
		/// <summary>
		/// Name: DecayTimestamp
		/// Type: FloatProperty
		/// Offset: 0x430
		/// Size: 0x04
		/// </summary>
		public float DecayTimestamp
		{
			get
			{
				return ReadSingle(0x430);
			}
			set
			{
				WriteSingle(0x430,value);
			}
		}
		
		/// <summary>
		/// Name: DecayState
		/// Type: IntProperty
		/// Offset: 0x434
		/// Size: 0x04
		/// </summary>
		public int DecayState
		{
			get
			{
				return ReadInt32(0x434);
			}
			set
			{
				WriteInt32(0x434,value);
			}
		}
		
		/// <summary>
		/// Name: OwnerUniqueID
		/// Type: ObjectProperty
		/// Offset: 0x438
		/// Size: 0x08
		/// </summary>
		public UUniqueID OwnerUniqueID => ReadUObject<UUniqueID>(0x438);
		
		/// <summary>
		/// Name: m_HealthPool
		/// Type: TArray<FBuildableHealthEntry>
		/// Offset: 0x450
		/// Size: 0x10
		/// SubElement Size: 0x14
		/// </summary>
		public TArray<FBuildableHealthEntry> m_HealthPool => new TArray<FBuildableHealthEntry>(BaseAddress+0x450);
		
		/// <summary>
		/// Name: ValidSocketRotations
		/// Type: TArray<>
		/// Offset: 0x460
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: OwnerName
		/// Type: TextProperty
		/// Offset: 0x470
		/// Size: 0x18
		/// </summary>
		
	}


	/// <summary>
	/// UBuildingModuleData:UObject
	/// Size: 0xF0
	/// Properties: 13
	/// </summary>
	public class UBuildingModuleData:UObject
	{
		public override int ObjectSize => 240;
		/// <summary>
		/// Name: CurrentHealth
		/// Type: IntProperty
		/// Offset: 0x34
		/// Size: 0x04
		/// </summary>
		public int CurrentHealth
		{
			get
			{
				return ReadInt32(0x34);
			}
			set
			{
				WriteInt32(0x34,value);
			}
		}
		
		/// <summary>
		/// Name: Stability
		/// Type: Int8Property
		/// Offset: 0x38
		/// Size: 0x01
		/// </summary>
		
		/// <summary>
		/// Name: IsFoundation
		/// Type: BoolProperty
		/// Offset: 0x39
		/// Size: 0x01
		/// </summary>
		public bool IsFoundation
		{
			get
			{
				return ReadBool(0x39);
			}
			set
			{
				WriteBool(0x39,value);
			}
		}
		
		/// <summary>
		/// Name: IsPillar
		/// Type: BoolProperty
		/// Offset: 0x3A
		/// Size: 0x01
		/// </summary>
		public bool IsPillar
		{
			get
			{
				return ReadBool(0x3A);
			}
			set
			{
				WriteBool(0x3A,value);
			}
		}
		
		/// <summary>
		/// Name: OwnerComponent
		/// Type: ObjectProperty
		/// Offset: 0x40
		/// Size: 0x08
		/// </summary>
		public UInstancedBuildingComponent OwnerComponent => ReadUObject<UInstancedBuildingComponent>(0x40);
		
		/// <summary>
		/// Name: WorldLocation
		/// Type: StructProperty
		/// Offset: 0x50
		/// Size: 0x0C
		/// </summary>
		public FVector WorldLocation => ReadStruct<FVector>(0x50);
		
		/// <summary>
		/// Name: WorldRotation
		/// Type: StructProperty
		/// Offset: 0x60
		/// Size: 0x10
		/// </summary>
		public FQuat WorldRotation => ReadStruct<FQuat>(0x60);
		
		/// <summary>
		/// Name: m_BestPath
		/// Type: TArray<UBuildingModuleData>
		/// Offset: 0x80
		/// Size: 0x10
		/// SubElement Size: 0xF0
		/// </summary>
		public TArray<UBuildingModuleData> m_BestPath => new TArray<UBuildingModuleData>(BaseAddress+0x80);
		
		/// <summary>
		/// Name: m_SocketBestStabilities
		/// Type: TArray<>
		/// Offset: 0x90
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: m_SocketlessConnections
		/// Type: TArray<FSocketlessConnection>
		/// Offset: 0xA8
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FSocketlessConnection> m_SocketlessConnections => new TArray<FSocketlessConnection>(BaseAddress+0xA8);
		
		/// <summary>
		/// Name: m_ConnectedTo
		/// Type: StructProperty
		/// Offset: 0xB8
		/// Size: 0x10
		/// </summary>
		public FSocketlessConnection m_ConnectedTo => ReadStruct<FSocketlessConnection>(0xB8);
		
		/// <summary>
		/// Name: m_HealthPool
		/// Type: TArray<FBuildableHealthEntry>
		/// Offset: 0xC8
		/// Size: 0x10
		/// SubElement Size: 0x14
		/// </summary>
		public TArray<FBuildableHealthEntry> m_HealthPool => new TArray<FBuildableHealthEntry>(BaseAddress+0xC8);
		
		/// <summary>
		/// Name: m_HealthPoolPercentages
		/// Type: TArray<>
		/// Offset: 0xD8
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
	}


	/// <summary>
	/// UInteractableInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UInteractableInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UVisual:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UVisual:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UWidget:UVisual
	/// Size: 0x118
	/// Properties: 19
	/// </summary>
	public class UWidget:UVisual
	{
		public override int ObjectSize => 280;
		/// <summary>
		/// Name: bIsVariable
		/// Type: BoolProperty
		/// Offset: 0x28
		/// Size: 0x01
		/// </summary>
		public bool bIsVariable
		{
			get
			{
				return ReadBool(0x28);
			}
			set
			{
				WriteBool(0x28,value);
			}
		}
		
		/// <summary>
		/// Name: bCreatedByConstructionScript
		/// Type: BoolProperty
		/// Offset: 0x29
		/// Size: 0x01
		/// </summary>
		public bool bCreatedByConstructionScript
		{
			get
			{
				return ReadBool(0x29);
			}
			set
			{
				WriteBool(0x29,value);
			}
		}
		
		/// <summary>
		/// Name: Slot
		/// Type: ObjectProperty
		/// Offset: 0x30
		/// Size: 0x08
		/// </summary>
		public UPanelSlot Slot => ReadUObject<UPanelSlot>(0x30);
		
		/// <summary>
		/// Name: bIsEnabled
		/// Type: BoolProperty
		/// Offset: 0x38
		/// Size: 0x01
		/// </summary>
		public bool bIsEnabled
		{
			get
			{
				return ReadBool(0x38);
			}
			set
			{
				WriteBool(0x38,value);
			}
		}
		
		/// <summary>
		/// Name: bIsEnabledDelegate
		/// Type: DelegateProperty
		/// Offset: 0x40
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: ToolTipText
		/// Type: TextProperty
		/// Offset: 0x50
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: ToolTipTextDelegate
		/// Type: DelegateProperty
		/// Offset: 0x68
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: TooltipWidget
		/// Type: ObjectProperty
		/// Offset: 0x78
		/// Size: 0x08
		/// </summary>
		public UWidget TooltipWidget => ReadUObject<UWidget>(0x78);
		
		/// <summary>
		/// Name: ToolTipWidgetDelegate
		/// Type: DelegateProperty
		/// Offset: 0x80
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: Visiblity
		/// Type: ByteProperty
		/// Offset: 0x90
		/// Size: 0x01
		/// </summary>
		public byte Visiblity
		{
			get
			{
				return ReadByte(0x90);
			}
			set
			{
				WriteByte(0x90,value);
			}
		}
		
		/// <summary>
		/// Name: Visibility
		/// Type: ByteProperty
		/// Offset: 0x91
		/// Size: 0x01
		/// </summary>
		public byte Visibility
		{
			get
			{
				return ReadByte(0x91);
			}
			set
			{
				WriteByte(0x91,value);
			}
		}
		
		/// <summary>
		/// Name: VisibilityDelegate
		/// Type: DelegateProperty
		/// Offset: 0x98
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: bOverride_Cursor
		/// Type: BoolProperty
		/// Offset: 0xA8
		/// Size: 0x01
		/// </summary>
		public bool bOverride_Cursor => (ReadByte(0x00A8) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: Cursor
		/// Type: ByteProperty
		/// Offset: 0xAC
		/// Size: 0x01
		/// </summary>
		public byte Cursor
		{
			get
			{
				return ReadByte(0xAC);
			}
			set
			{
				WriteByte(0xAC,value);
			}
		}
		
		/// <summary>
		/// Name: bIsVolatile
		/// Type: BoolProperty
		/// Offset: 0xAD
		/// Size: 0x01
		/// </summary>
		public bool bIsVolatile
		{
			get
			{
				return ReadBool(0xAD);
			}
			set
			{
				WriteBool(0xAD,value);
			}
		}
		
		/// <summary>
		/// Name: RenderTransform
		/// Type: StructProperty
		/// Offset: 0xB0
		/// Size: 0x1C
		/// </summary>
		public FWidgetTransform RenderTransform => ReadStruct<FWidgetTransform>(0xB0);
		
		/// <summary>
		/// Name: RenderTransformPivot
		/// Type: StructProperty
		/// Offset: 0xCC
		/// Size: 0x08
		/// </summary>
		public FVector2D RenderTransformPivot => ReadStruct<FVector2D>(0xCC);
		
		/// <summary>
		/// Name: Navigation
		/// Type: ObjectProperty
		/// Offset: 0xD8
		/// Size: 0x08
		/// </summary>
		public UWidgetNavigation Navigation => ReadUObject<UWidgetNavigation>(0xD8);
		
		/// <summary>
		/// Name: NativeBindings
		/// Type: TArray<UPropertyBinding>
		/// Offset: 0x108
		/// Size: 0x10
		/// SubElement Size: 0x48
		/// </summary>
		public TArray<UPropertyBinding> NativeBindings => new TArray<UPropertyBinding>(BaseAddress+0x108);
		
	}


	/// <summary>
	/// UUserWidget:UWidget
	/// Size: 0x238
	/// Properties: 14
	/// </summary>
	public class UUserWidget:UWidget
	{
		public override int ObjectSize => 568;
		/// <summary>
		/// Name: ColorAndOpacity
		/// Type: StructProperty
		/// Offset: 0x120
		/// Size: 0x10
		/// </summary>
		public FLinearColor ColorAndOpacity => ReadStruct<FLinearColor>(0x120);
		
		/// <summary>
		/// Name: ColorAndOpacityDelegate
		/// Type: DelegateProperty
		/// Offset: 0x130
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: ForegroundColor
		/// Type: StructProperty
		/// Offset: 0x140
		/// Size: 0x28
		/// </summary>
		public FSlateColor ForegroundColor => ReadStruct<FSlateColor>(0x140);
		
		/// <summary>
		/// Name: ForegroundColorDelegate
		/// Type: DelegateProperty
		/// Offset: 0x168
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: Padding
		/// Type: StructProperty
		/// Offset: 0x178
		/// Size: 0x10
		/// </summary>
		public FMargin Padding => ReadStruct<FMargin>(0x178);
		
		/// <summary>
		/// Name: bSupportsKeyboardFocus
		/// Type: BoolProperty
		/// Offset: 0x188
		/// Size: 0x01
		/// </summary>
		public bool bSupportsKeyboardFocus
		{
			get
			{
				return ReadBool(0x188);
			}
			set
			{
				WriteBool(0x188,value);
			}
		}
		
		/// <summary>
		/// Name: bIsFocusable
		/// Type: BoolProperty
		/// Offset: 0x189
		/// Size: 0x01
		/// </summary>
		public bool bIsFocusable
		{
			get
			{
				return ReadBool(0x189);
			}
			set
			{
				WriteBool(0x189,value);
			}
		}
		
		/// <summary>
		/// Name: WidgetTree
		/// Type: ObjectProperty
		/// Offset: 0x190
		/// Size: 0x08
		/// </summary>
		public UWidgetTree WidgetTree => ReadUObject<UWidgetTree>(0x190);
		
		/// <summary>
		/// Name: ActiveSequencePlayers
		/// Type: TArray<UUMGSequencePlayer>
		/// Offset: 0x198
		/// Size: 0x10
		/// SubElement Size: 0x190
		/// </summary>
		public TArray<UUMGSequencePlayer> ActiveSequencePlayers => new TArray<UUMGSequencePlayer>(BaseAddress+0x198);
		
		/// <summary>
		/// Name: StoppedSequencePlayers
		/// Type: TArray<UUMGSequencePlayer>
		/// Offset: 0x1A8
		/// Size: 0x10
		/// SubElement Size: 0x190
		/// </summary>
		public TArray<UUMGSequencePlayer> StoppedSequencePlayers => new TArray<UUMGSequencePlayer>(BaseAddress+0x1A8);
		
		/// <summary>
		/// Name: NamedSlotBindings
		/// Type: TArray<FNamedSlotBinding>
		/// Offset: 0x1B8
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FNamedSlotBinding> NamedSlotBindings => new TArray<FNamedSlotBinding>(BaseAddress+0x1B8);
		
		/// <summary>
		/// Name: bStopAction
		/// Type: BoolProperty
		/// Offset: 0x1C8
		/// Size: 0x01
		/// </summary>
		public bool bStopAction
		{
			get
			{
				return ReadBool(0x1C8);
			}
			set
			{
				WriteBool(0x1C8,value);
			}
		}
		
		/// <summary>
		/// Name: Priority
		/// Type: IntProperty
		/// Offset: 0x1CC
		/// Size: 0x04
		/// </summary>
		public int Priority
		{
			get
			{
				return ReadInt32(0x1CC);
			}
			set
			{
				WriteInt32(0x1CC,value);
			}
		}
		
		/// <summary>
		/// Name: InputComponent
		/// Type: ObjectProperty
		/// Offset: 0x1D8
		/// Size: 0x08
		/// </summary>
		public UInputComponent InputComponent => ReadUObject<UInputComponent>(0x1D8);
		
	}


	/// <summary>
	/// UTooltipWidget:UUserWidget
	/// Size: 0x240
	/// Properties: 0
	/// </summary>
	public class UTooltipWidget:UUserWidget
	{
		public override int ObjectSize => 576;
	}


	/// <summary>
	/// URootWidget:UUserWidget
	/// Size: 0x308
	/// Properties: 8
	/// </summary>
	public class URootWidget:UUserWidget
	{
		public override int ObjectSize => 776;
		/// <summary>
		/// Name: KeyNavAutoSetBack
		/// Type: BoolProperty
		/// Offset: 0x2A0
		/// Size: 0x01
		/// </summary>
		public bool KeyNavAutoSetBack
		{
			get
			{
				return ReadBool(0x2A0);
			}
			set
			{
				WriteBool(0x2A0,value);
			}
		}
		
		/// <summary>
		/// Name: TooltipWidgetClass
		/// Type: ClassProperty
		/// Offset: 0x2A8
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: KeyNavIndicatorClass
		/// Type: ClassProperty
		/// Offset: 0x2B0
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: PositiveFeedbackColor
		/// Type: StructProperty
		/// Offset: 0x2B8
		/// Size: 0x10
		/// </summary>
		public FLinearColor PositiveFeedbackColor => ReadStruct<FLinearColor>(0x2B8);
		
		/// <summary>
		/// Name: NegativeFeedbackColor
		/// Type: StructProperty
		/// Offset: 0x2C8
		/// Size: 0x10
		/// </summary>
		public FLinearColor NegativeFeedbackColor => ReadStruct<FLinearColor>(0x2C8);
		
		/// <summary>
		/// Name: NeutralFeedbackColor
		/// Type: StructProperty
		/// Offset: 0x2D8
		/// Size: 0x10
		/// </summary>
		public FLinearColor NeutralFeedbackColor => ReadStruct<FLinearColor>(0x2D8);
		
		/// <summary>
		/// Name: m_Window
		/// Type: ObjectProperty
		/// Offset: 0x2E8
		/// Size: 0x08
		/// </summary>
		public UWindowRoot m_Window => ReadUObject<UWindowRoot>(0x2E8);
		
		/// <summary>
		/// Name: m_KeyNavIndicator
		/// Type: ObjectProperty
		/// Offset: 0x2F8
		/// Size: 0x08
		/// </summary>
		public UKeyNavIndicator m_KeyNavIndicator => ReadUObject<UKeyNavIndicator>(0x2F8);
		
	}


	/// <summary>
	/// UIntStatChangeSignalNode:UObject
	/// Size: 0x38
	/// Properties: 0
	/// </summary>
	public class UIntStatChangeSignalNode:UObject
	{
		public override int ObjectSize => 56;
	}


	/// <summary>
	/// UFloatStatChangeSignalNode:UObject
	/// Size: 0x38
	/// Properties: 0
	/// </summary>
	public class UFloatStatChangeSignalNode:UObject
	{
		public override int ObjectSize => 56;
	}


	/// <summary>
	/// UPersistenceComponent:UActorComponent
	/// Size: 0x130
	/// Properties: 4
	/// </summary>
	public class UPersistenceComponent:UActorComponent
	{
		public override int ObjectSize => 304;
		/// <summary>
		/// Name: SaveOnSpawn
		/// Type: BoolProperty
		/// Offset: 0xD8
		/// Size: 0x01
		/// </summary>
		public bool SaveOnSpawn
		{
			get
			{
				return ReadBool(0xD8);
			}
			set
			{
				WriteBool(0xD8,value);
			}
		}
		
		/// <summary>
		/// Name: SaveFrequency
		/// Type: FloatProperty
		/// Offset: 0xDC
		/// Size: 0x04
		/// </summary>
		public float SaveFrequency
		{
			get
			{
				return ReadSingle(0xDC);
			}
			set
			{
				WriteSingle(0xDC,value);
			}
		}
		
		/// <summary>
		/// Name: SkipSaving
		/// Type: BoolProperty
		/// Offset: 0xE0
		/// Size: 0x01
		/// </summary>
		public bool SkipSaving
		{
			get
			{
				return ReadBool(0xE0);
			}
			set
			{
				WriteBool(0xE0,value);
			}
		}
		
		/// <summary>
		/// Name: UID
		/// Type: ObjectProperty
		/// Offset: 0xE8
		/// Size: 0x08
		/// </summary>
		public UUniqueID UID => ReadUObject<UUniqueID>(0xE8);
		
	}


	/// <summary>
	/// UStatHolder:UPersistenceComponent
	/// Size: 0x310
	/// Properties: 4
	/// </summary>
	public class UStatHolder:UPersistenceComponent
	{
		public override int ObjectSize => 784;
		/// <summary>
		/// Name: m_IntStatArray
		/// Type: StructProperty
		/// Offset: 0x160
		/// Size: 0x10
		/// </summary>
		public FStatArrayInt32 m_IntStatArray => ReadStruct<FStatArrayInt32>(0x160);
		
		/// <summary>
		/// Name: m_FloatStatArray
		/// Type: StructProperty
		/// Offset: 0x180
		/// Size: 0x10
		/// </summary>
		public FStatArrayFloat m_FloatStatArray => ReadStruct<FStatArrayFloat>(0x180);
		
		/// <summary>
		/// Name: m_IntStatChangeNodeList
		/// Type: TArray<UIntStatChangeSignalNode>
		/// Offset: 0x230
		/// Size: 0x10
		/// SubElement Size: 0x38
		/// </summary>
		public TArray<UIntStatChangeSignalNode> m_IntStatChangeNodeList => new TArray<UIntStatChangeSignalNode>(BaseAddress+0x230);
		
		/// <summary>
		/// Name: m_FloatStatChangeNodeList
		/// Type: TArray<UFloatStatChangeSignalNode>
		/// Offset: 0x240
		/// Size: 0x10
		/// SubElement Size: 0x38
		/// </summary>
		public TArray<UFloatStatChangeSignalNode> m_FloatStatChangeNodeList => new TArray<UFloatStatChangeSignalNode>(BaseAddress+0x240);
		
	}


	/// <summary>
	/// UGUIModule:UObject
	/// Size: 0xA0
	/// Properties: 12
	/// </summary>
	public class UGUIModule:UObject
	{
		public override int ObjectSize => 160;
		/// <summary>
		/// Name: ModuleName
		/// Type: NameProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: ToggleActionName
		/// Type: NameProperty
		/// Offset: 0x30
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: CloseOnShortcutRelease
		/// Type: BoolProperty
		/// Offset: 0x38
		/// Size: 0x01
		/// </summary>
		public bool CloseOnShortcutRelease
		{
			get
			{
				return ReadBool(0x38);
			}
			set
			{
				WriteBool(0x38,value);
			}
		}
		
		/// <summary>
		/// Name: CloseOnESC
		/// Type: BoolProperty
		/// Offset: 0x39
		/// Size: 0x01
		/// </summary>
		public bool CloseOnESC
		{
			get
			{
				return ReadBool(0x39);
			}
			set
			{
				WriteBool(0x39,value);
			}
		}
		
		/// <summary>
		/// Name: CloseOnEndPlay
		/// Type: BoolProperty
		/// Offset: 0x3A
		/// Size: 0x01
		/// </summary>
		public bool CloseOnEndPlay
		{
			get
			{
				return ReadBool(0x3A);
			}
			set
			{
				WriteBool(0x3A,value);
			}
		}
		
		/// <summary>
		/// Name: PreloadOnStartup
		/// Type: BoolProperty
		/// Offset: 0x3B
		/// Size: 0x01
		/// </summary>
		public bool PreloadOnStartup
		{
			get
			{
				return ReadBool(0x3B);
			}
			set
			{
				WriteBool(0x3B,value);
			}
		}
		
		/// <summary>
		/// Name: IsPersistent
		/// Type: BoolProperty
		/// Offset: 0x3C
		/// Size: 0x01
		/// </summary>
		public bool IsPersistent
		{
			get
			{
				return ReadBool(0x3C);
			}
			set
			{
				WriteBool(0x3C,value);
			}
		}
		
		/// <summary>
		/// Name: Category
		/// Type: ByteProperty
		/// Offset: 0x3D
		/// Size: 0x01
		/// </summary>
		public byte Category
		{
			get
			{
				return ReadByte(0x3D);
			}
			set
			{
				WriteByte(0x3D,value);
			}
		}
		
		/// <summary>
		/// Name: WidgetClass
		/// Type: AssetClassProperty
		/// Offset: 0x40
		/// Size: 0x20
		/// </summary>
		
		/// <summary>
		/// Name: RootWidget
		/// Type: ObjectProperty
		/// Offset: 0x60
		/// Size: 0x08
		/// </summary>
		public UWindowRoot RootWidget => ReadUObject<UWindowRoot>(0x60);
		
		/// <summary>
		/// Name: IsFullscreen
		/// Type: BoolProperty
		/// Offset: 0x68
		/// Size: 0x01
		/// </summary>
		public bool IsFullscreen
		{
			get
			{
				return ReadBool(0x68);
			}
			set
			{
				WriteBool(0x68,value);
			}
		}
		
		/// <summary>
		/// Name: m_ModuleController
		/// Type: ObjectProperty
		/// Offset: 0x80
		/// Size: 0x08
		/// </summary>
		public UGUIModuleController m_ModuleController => ReadUObject<UGUIModuleController>(0x80);
		
	}


	/// <summary>
	/// UGameInstance:UObject
	/// Size: 0xF0
	/// Properties: 2
	/// </summary>
	public class UGameInstance:UObject
	{
		public override int ObjectSize => 240;
		/// <summary>
		/// Name: LocalPlayers
		/// Type: TArray<ULocalPlayer>
		/// Offset: 0x38
		/// Size: 0x10
		/// SubElement Size: 0x190
		/// </summary>
		public TArray<ULocalPlayer> LocalPlayers => new TArray<ULocalPlayer>(BaseAddress+0x38);
		
		/// <summary>
		/// Name: OnlineSession
		/// Type: ObjectProperty
		/// Offset: 0x58
		/// Size: 0x08
		/// </summary>
		public UOnlineSession OnlineSession => ReadUObject<UOnlineSession>(0x58);
		
	}


	/// <summary>
	/// UConanGameInstance:UGameInstance
	/// Size: 0x2C0
	/// Properties: 4
	/// </summary>
	public class UConanGameInstance:UGameInstance
	{
		public override int ObjectSize => 704;
		/// <summary>
		/// Name: m_ShowLoadingScreens
		/// Type: BoolProperty
		/// Offset: 0xF0
		/// Size: 0x01
		/// </summary>
		public bool m_ShowLoadingScreens
		{
			get
			{
				return ReadBool(0xF0);
			}
			set
			{
				WriteBool(0xF0,value);
			}
		}
		
		/// <summary>
		/// Name: ServerSettings
		/// Type: ObjectProperty
		/// Offset: 0x220
		/// Size: 0x08
		/// </summary>
		public AServerSettings ServerSettings => ReadUObject<AServerSettings>(0x220);
		
		/// <summary>
		/// Name: m_GUIModuleController
		/// Type: ObjectProperty
		/// Offset: 0x258
		/// Size: 0x08
		/// </summary>
		public UGUIModuleController m_GUIModuleController => ReadUObject<UGUIModuleController>(0x258);
		
		/// <summary>
		/// Name: m_LoadingScreenWidget
		/// Type: ObjectProperty
		/// Offset: 0x260
		/// Size: 0x08
		/// </summary>
		public UWidget m_LoadingScreenWidget => ReadUObject<UWidget>(0x260);
		
	}


	/// <summary>
	/// UEscapeStackNode:UObject
	/// Size: 0x38
	/// Properties: 1
	/// </summary>
	public class UEscapeStackNode:UObject
	{
		public override int ObjectSize => 56;
		/// <summary>
		/// Name: SignalActivated
		/// Type: DelegateProperty
		/// Offset: 0x28
		/// Size: 0x10
		/// </summary>
		
	}


	/// <summary>
	/// UGUIModuleController:UObject
	/// Size: 0x140
	/// Properties: 8
	/// </summary>
	public class UGUIModuleController:UObject
	{
		public override int ObjectSize => 320;
		/// <summary>
		/// Name: m_WindowList
		/// Type: TArray<UWindowRoot>
		/// Offset: 0x60
		/// Size: 0x10
		/// SubElement Size: 0x378
		/// </summary>
		public TArray<UWindowRoot> m_WindowList => new TArray<UWindowRoot>(BaseAddress+0x60);
		
		/// <summary>
		/// Name: m_MouseBlockWindow
		/// Type: ObjectProperty
		/// Offset: 0x70
		/// Size: 0x08
		/// </summary>
		public UWindowRoot m_MouseBlockWindow => ReadUObject<UWindowRoot>(0x70);
		
		/// <summary>
		/// Name: m_Modules
		/// Type: TArray<UGUIModule>
		/// Offset: 0x78
		/// Size: 0x10
		/// SubElement Size: 0xA0
		/// </summary>
		public TArray<UGUIModule> m_Modules => new TArray<UGUIModule>(BaseAddress+0x78);
		
		/// <summary>
		/// Name: m_EscapeStack
		/// Type: TArray<UEscapeStackNode>
		/// Offset: 0x88
		/// Size: 0x10
		/// SubElement Size: 0x38
		/// </summary>
		public TArray<UEscapeStackNode> m_EscapeStack => new TArray<UEscapeStackNode>(BaseAddress+0x88);
		
		/// <summary>
		/// Name: m_GUIModuleTable
		/// Type: ObjectProperty
		/// Offset: 0x98
		/// Size: 0x08
		/// </summary>
		public UDataTable m_GUIModuleTable => ReadUObject<UDataTable>(0x98);
		
		/// <summary>
		/// Name: m_KeyNavSelectedWidget
		/// Type: ObjectProperty
		/// Offset: 0xA8
		/// Size: 0x08
		/// </summary>
		public URootWidget m_KeyNavSelectedWidget => ReadUObject<URootWidget>(0xA8);
		
		/// <summary>
		/// Name: m_PlayerController
		/// Type: ObjectProperty
		/// Offset: 0xD8
		/// Size: 0x08
		/// </summary>
		public APlayerController m_PlayerController => ReadUObject<APlayerController>(0xD8);
		
		/// <summary>
		/// Name: m_InputComponent
		/// Type: ObjectProperty
		/// Offset: 0xE0
		/// Size: 0x08
		/// </summary>
		public UInputComponent m_InputComponent => ReadUObject<UInputComponent>(0xE0);
		
	}


	/// <summary>
	/// UWindowRoot:URootWidget
	/// Size: 0x378
	/// Properties: 5
	/// </summary>
	public class UWindowRoot:URootWidget
	{
		public override int ObjectSize => 888;
		/// <summary>
		/// Name: CloseOnClick
		/// Type: BoolProperty
		/// Offset: 0x308
		/// Size: 0x01
		/// </summary>
		public bool CloseOnClick
		{
			get
			{
				return ReadBool(0x308);
			}
			set
			{
				WriteBool(0x308,value);
			}
		}
		
		/// <summary>
		/// Name: OpeningSlateSound
		/// Type: StructProperty
		/// Offset: 0x310
		/// Size: 0x18
		/// </summary>
		public FSlateSound OpeningSlateSound => ReadStruct<FSlateSound>(0x310);
		
		/// <summary>
		/// Name: ClosingSlateSound
		/// Type: StructProperty
		/// Offset: 0x328
		/// Size: 0x18
		/// </summary>
		public FSlateSound ClosingSlateSound => ReadStruct<FSlateSound>(0x328);
		
		/// <summary>
		/// Name: m_InputComponent
		/// Type: ObjectProperty
		/// Offset: 0x360
		/// Size: 0x08
		/// </summary>
		public UInputComponent m_InputComponent => ReadUObject<UInputComponent>(0x360);
		
		/// <summary>
		/// Name: m_GUIModule
		/// Type: ObjectProperty
		/// Offset: 0x368
		/// Size: 0x08
		/// </summary>
		public UGUIModule m_GUIModule => ReadUObject<UGUIModule>(0x368);
		
	}


	/// <summary>
	/// UMessageBoxWidget:UWindowRoot
	/// Size: 0x3D8
	/// Properties: 0
	/// </summary>
	public class UMessageBoxWidget:UWindowRoot
	{
		public override int ObjectSize => 984;
	}


	/// <summary>
	/// UInstancedBuildingComponent:UInstancedStaticMeshComponent
	/// Size: 0x800
	/// Properties: 7
	/// </summary>
	public class UInstancedBuildingComponent:UInstancedStaticMeshComponent
	{
		public override int ObjectSize => 2048;
		/// <summary>
		/// Name: DestructibleMesh
		/// Type: ObjectProperty
		/// Offset: 0x788
		/// Size: 0x08
		/// </summary>
		public UDestructibleMesh DestructibleMesh => ReadUObject<UDestructibleMesh>(0x788);
		
		/// <summary>
		/// Name: MaxHealth
		/// Type: IntProperty
		/// Offset: 0x790
		/// Size: 0x04
		/// </summary>
		public int MaxHealth
		{
			get
			{
				return ReadInt32(0x790);
			}
			set
			{
				WriteInt32(0x790,value);
			}
		}
		
		/// <summary>
		/// Name: m_SourceClass
		/// Type: ClassProperty
		/// Offset: 0x798
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: m_BuildingModules
		/// Type: TArray<UBuildingModuleData>
		/// Offset: 0x7A8
		/// Size: 0x10
		/// SubElement Size: 0xF0
		/// </summary>
		public TArray<UBuildingModuleData> m_BuildingModules => new TArray<UBuildingModuleData>(BaseAddress+0x7A8);
		
		/// <summary>
		/// Name: m_PendingDestructionModules
		/// Type: TArray<UBuildingModuleData>
		/// Offset: 0x7C8
		/// Size: 0x10
		/// SubElement Size: 0xF0
		/// </summary>
		public TArray<UBuildingModuleData> m_PendingDestructionModules => new TArray<UBuildingModuleData>(BaseAddress+0x7C8);
		
		/// <summary>
		/// Name: m_SpawnedDestructibles
		/// Type: TArray<ADestructibleActor>
		/// Offset: 0x7D8
		/// Size: 0x10
		/// SubElement Size: 0x3F0
		/// </summary>
		public TArray<ADestructibleActor> m_SpawnedDestructibles => new TArray<ADestructibleActor>(BaseAddress+0x7D8);
		
		/// <summary>
		/// Name: m_RadialDamageDestroyedModules
		/// Type: TArray<UBuildingModuleData>
		/// Offset: 0x7E8
		/// Size: 0x10
		/// SubElement Size: 0xF0
		/// </summary>
		public TArray<UBuildingModuleData> m_RadialDamageDestroyedModules => new TArray<UBuildingModuleData>(BaseAddress+0x7E8);
		
	}


	/// <summary>
	/// ABuildingBase:ABuildableBase
	/// Size: 0x608
	/// Properties: 18
	/// </summary>
	public class ABuildingBase:ABuildableBase
	{
		public override int ObjectSize => 1544;
		/// <summary>
		/// Name: InstancedBuildingMesh
		/// Type: ObjectProperty
		/// Offset: 0x4C0
		/// Size: 0x08
		/// </summary>
		public UInstancedBuildingComponent InstancedBuildingMesh => ReadUObject<UInstancedBuildingComponent>(0x4C0);
		
		/// <summary>
		/// Name: IsFoundation
		/// Type: BoolProperty
		/// Offset: 0x4C8
		/// Size: 0x01
		/// </summary>
		public bool IsFoundation
		{
			get
			{
				return ReadBool(0x4C8);
			}
			set
			{
				WriteBool(0x4C8,value);
			}
		}
		
		/// <summary>
		/// Name: IsPillar
		/// Type: BoolProperty
		/// Offset: 0x4C9
		/// Size: 0x01
		/// </summary>
		public bool IsPillar
		{
			get
			{
				return ReadBool(0x4C9);
			}
			set
			{
				WriteBool(0x4C9,value);
			}
		}
		
		/// <summary>
		/// Name: CanUpgradeFrom
		/// Type: TArray<UStaticMesh>
		/// Offset: 0x4D0
		/// Size: 0x10
		/// SubElement Size: 0x118
		/// </summary>
		public TArray<UStaticMesh> CanUpgradeFrom => new TArray<UStaticMesh>(BaseAddress+0x4D0);
		
		/// <summary>
		/// Name: m_PlacementHelper
		/// Type: ObjectProperty
		/// Offset: 0x4E0
		/// Size: 0x08
		/// </summary>
		public ABuildingBase m_PlacementHelper => ReadUObject<ABuildingBase>(0x4E0);
		
		/// <summary>
		/// Name: m_InstancedBuildingMeshes
		/// Type: TArray<UInstancedBuildingComponent>
		/// Offset: 0x4E8
		/// Size: 0x10
		/// SubElement Size: 0x800
		/// </summary>
		public TArray<UInstancedBuildingComponent> m_InstancedBuildingMeshes => new TArray<UInstancedBuildingComponent>(BaseAddress+0x4E8);
		
		/// <summary>
		/// Name: m_IsLoading
		/// Type: BoolProperty
		/// Offset: 0x4F8
		/// Size: 0x01
		/// </summary>
		public bool m_IsLoading
		{
			get
			{
				return ReadBool(0x4F8);
			}
			set
			{
				WriteBool(0x4F8,value);
			}
		}
		
		/// <summary>
		/// Name: m_MasterBuilding
		/// Type: ObjectProperty
		/// Offset: 0x500
		/// Size: 0x08
		/// </summary>
		public ABuildingBase m_MasterBuilding => ReadUObject<ABuildingBase>(0x500);
		
		/// <summary>
		/// Name: m_Buildings
		/// Type: MapProperty
		/// Offset: 0x508
		/// Size: 0x50
		/// </summary>
		
		/// <summary>
		/// Name: m_NextBuilding
		/// Type: ObjectProperty
		/// Offset: 0x568
		/// Size: 0x08
		/// </summary>
		public ABuildingBase m_NextBuilding => ReadUObject<ABuildingBase>(0x568);
		
		/// <summary>
		/// Name: m_PrevBuilding
		/// Type: ObjectProperty
		/// Offset: 0x570
		/// Size: 0x08
		/// </summary>
		public ABuildingBase m_PrevBuilding => ReadUObject<ABuildingBase>(0x570);
		
		/// <summary>
		/// Name: m_BuildingKey
		/// Type: UInt32Property
		/// Offset: 0x578
		/// Size: 0x04
		/// </summary>
		
		/// <summary>
		/// Name: m_BuildingClasses
		/// Type: TArray<>
		/// Offset: 0x5D0
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: m_RandomizingBuildSystem
		/// Type: ObjectProperty
		/// Offset: 0x5E0
		/// Size: 0x08
		/// </summary>
		public UBuildSystemComponent m_RandomizingBuildSystem => ReadUObject<UBuildSystemComponent>(0x5E0);
		
		/// <summary>
		/// Name: m_NumStartingPiecesForRandomization
		/// Type: IntProperty
		/// Offset: 0x5E8
		/// Size: 0x04
		/// </summary>
		public int m_NumStartingPiecesForRandomization
		{
			get
			{
				return ReadInt32(0x5E8);
			}
			set
			{
				WriteInt32(0x5E8,value);
			}
		}
		
		/// <summary>
		/// Name: m_NumPiecesForRandomization
		/// Type: IntProperty
		/// Offset: 0x5EC
		/// Size: 0x04
		/// </summary>
		public int m_NumPiecesForRandomization
		{
			get
			{
				return ReadInt32(0x5EC);
			}
			set
			{
				WriteInt32(0x5EC,value);
			}
		}
		
		/// <summary>
		/// Name: m_NumFoundationPiecesForRandomization
		/// Type: IntProperty
		/// Offset: 0x5F0
		/// Size: 0x04
		/// </summary>
		public int m_NumFoundationPiecesForRandomization
		{
			get
			{
				return ReadInt32(0x5F0);
			}
			set
			{
				WriteInt32(0x5F0,value);
			}
		}
		
		/// <summary>
		/// Name: m_RandomizationModulesList
		/// Type: TArray<UBuildingModuleData>
		/// Offset: 0x5F8
		/// Size: 0x10
		/// SubElement Size: 0xF0
		/// </summary>
		public TArray<UBuildingModuleData> m_RandomizationModulesList => new TArray<UBuildingModuleData>(BaseAddress+0x5F8);
		
	}


	/// <summary>
	/// UBlueprintFunctionLibrary:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBlueprintFunctionLibrary:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UTargetAreaHelpers:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UTargetAreaHelpers:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UAIFunctionLibrary:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UAIFunctionLibrary:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UAILODComponent:UActorComponent
	/// Size: 0x190
	/// Properties: 7
	/// </summary>
	public class UAILODComponent:UActorComponent
	{
		public override int ObjectSize => 400;
		/// <summary>
		/// Name: AILOD2DistanceOverride
		/// Type: FloatProperty
		/// Offset: 0xE0
		/// Size: 0x04
		/// </summary>
		public float AILOD2DistanceOverride
		{
			get
			{
				return ReadSingle(0xE0);
			}
			set
			{
				WriteSingle(0xE0,value);
			}
		}
		
		/// <summary>
		/// Name: AILOD1Distance
		/// Type: FloatProperty
		/// Offset: 0xE4
		/// Size: 0x04
		/// </summary>
		public float AILOD1Distance
		{
			get
			{
				return ReadSingle(0xE4);
			}
			set
			{
				WriteSingle(0xE4,value);
			}
		}
		
		/// <summary>
		/// Name: AILOD2Distance
		/// Type: FloatProperty
		/// Offset: 0xE8
		/// Size: 0x04
		/// </summary>
		public float AILOD2Distance
		{
			get
			{
				return ReadSingle(0xE8);
			}
			set
			{
				WriteSingle(0xE8,value);
			}
		}
		
		/// <summary>
		/// Name: AILOD3Distance
		/// Type: FloatProperty
		/// Offset: 0xEC
		/// Size: 0x04
		/// </summary>
		public float AILOD3Distance
		{
			get
			{
				return ReadSingle(0xEC);
			}
			set
			{
				WriteSingle(0xEC,value);
			}
		}
		
		/// <summary>
		/// Name: SuspendAtMaxAILOD
		/// Type: BoolProperty
		/// Offset: 0xF0
		/// Size: 0x01
		/// </summary>
		public bool SuspendAtMaxAILOD
		{
			get
			{
				return ReadBool(0xF0);
			}
			set
			{
				WriteBool(0xF0,value);
			}
		}
		
		/// <summary>
		/// Name: AILOD
		/// Type: ByteProperty
		/// Offset: 0xF1
		/// Size: 0x01
		/// </summary>
		public byte AILOD
		{
			get
			{
				return ReadByte(0xF1);
			}
			set
			{
				WriteByte(0xF1,value);
			}
		}
		
		/// <summary>
		/// Name: pausedComponents
		/// Type: TArray<UActorComponent>
		/// Offset: 0x168
		/// Size: 0x10
		/// SubElement Size: 0xD8
		/// </summary>
		public TArray<UActorComponent> pausedComponents => new TArray<UActorComponent>(BaseAddress+0x168);
		
	}


	/// <summary>
	/// ALandClaim:AActor
	/// Size: 0x448
	/// Properties: 7
	/// </summary>
	public class ALandClaim:AActor
	{
		public override int ObjectSize => 1096;
		/// <summary>
		/// Name: CellSize
		/// Type: IntProperty
		/// Offset: 0x3D0
		/// Size: 0x04
		/// </summary>
		public int CellSize
		{
			get
			{
				return ReadInt32(0x3D0);
			}
			set
			{
				WriteInt32(0x3D0,value);
			}
		}
		
		/// <summary>
		/// Name: CellData
		/// Type: TArray<FLandClaimCellData>
		/// Offset: 0x3D8
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FLandClaimCellData> CellData => new TArray<FLandClaimCellData>(BaseAddress+0x3D8);
		
		/// <summary>
		/// Name: Cells
		/// Type: MapProperty
		/// Offset: 0x3E8
		/// Size: 0x50
		/// </summary>
		
		/// <summary>
		/// Name: Channel
		/// Type: ByteProperty
		/// Offset: 0x438
		/// Size: 0x01
		/// </summary>
		public byte Channel
		{
			get
			{
				return ReadByte(0x438);
			}
			set
			{
				WriteByte(0x438,value);
			}
		}
		
		/// <summary>
		/// Name: RadiusCoefficient
		/// Type: FloatProperty
		/// Offset: 0x43C
		/// Size: 0x04
		/// </summary>
		public float RadiusCoefficient
		{
			get
			{
				return ReadSingle(0x43C);
			}
			set
			{
				WriteSingle(0x43C,value);
			}
		}
		
		/// <summary>
		/// Name: ScaledCellSize
		/// Type: IntProperty
		/// Offset: 0x440
		/// Size: 0x04
		/// </summary>
		public int ScaledCellSize
		{
			get
			{
				return ReadInt32(0x440);
			}
			set
			{
				WriteInt32(0x440,value);
			}
		}
		
		/// <summary>
		/// Name: NoOwnership
		/// Type: BoolProperty
		/// Offset: 0x444
		/// Size: 0x01
		/// </summary>
		public bool NoOwnership
		{
			get
			{
				return ReadBool(0x444);
			}
			set
			{
				WriteBool(0x444,value);
			}
		}
		
	}


	/// <summary>
	/// UEnergyReceiverComponent:UActorComponent
	/// Size: 0x190
	/// Properties: 4
	/// </summary>
	public class UEnergyReceiverComponent:UActorComponent
	{
		public override int ObjectSize => 400;
		/// <summary>
		/// Name: ListeningToTypes
		/// Type: IntProperty
		/// Offset: 0x160
		/// Size: 0x04
		/// </summary>
		public int ListeningToTypes
		{
			get
			{
				return ReadInt32(0x160);
			}
			set
			{
				WriteInt32(0x160,value);
			}
		}
		
		/// <summary>
		/// Name: Energies
		/// Type: TArray<>
		/// Offset: 0x168
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: EnergyDataTable
		/// Type: ObjectProperty
		/// Offset: 0x178
		/// Size: 0x08
		/// </summary>
		public UDataTable EnergyDataTable => ReadUObject<UDataTable>(0x178);
		
		/// <summary>
		/// Name: EnergyEventTable
		/// Type: ObjectProperty
		/// Offset: 0x180
		/// Size: 0x08
		/// </summary>
		public UDataTable EnergyEventTable => ReadUObject<UDataTable>(0x180);
		
	}


	/// <summary>
	/// AEnergyReceiverRegistry:AActor
	/// Size: 0x3E0
	/// Properties: 1
	/// </summary>
	public class AEnergyReceiverRegistry:AActor
	{
		public override int ObjectSize => 992;
		/// <summary>
		/// Name: EnergyListeners
		/// Type: TArray<UEnergyReceiverComponent>
		/// Offset: 0x3D0
		/// Size: 0x10
		/// SubElement Size: 0x190
		/// </summary>
		public TArray<UEnergyReceiverComponent> EnergyListeners => new TArray<UEnergyReceiverComponent>(BaseAddress+0x3D0);
		
	}


	/// <summary>
	/// UStaticNavigation:UObject
	/// Size: 0xA8
	/// Properties: 3
	/// </summary>
	public class UStaticNavigation:UObject
	{
		public override int ObjectSize => 168;
		/// <summary>
		/// Name: m_SpawnerIndices
		/// Type: TArray<FSpawnerIndex>
		/// Offset: 0x28
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FSpawnerIndex> m_SpawnerIndices => new TArray<FSpawnerIndex>(BaseAddress+0x28);
		
		/// <summary>
		/// Name: m_SampledSpawnPoints
		/// Type: TArray<FVector>
		/// Offset: 0x38
		/// Size: 0x10
		/// SubElement Size: 0x0C
		/// </summary>
		public TArray<FVector> m_SampledSpawnPoints => new TArray<FVector>(BaseAddress+0x38);
		
		/// <summary>
		/// Name: m_SampledRoamingPaths
		/// Type: TArray<FRoamingPath>
		/// Offset: 0x48
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FRoamingPath> m_SampledRoamingPaths => new TArray<FRoamingPath>(BaseAddress+0x48);
		
	}


	/// <summary>
	/// UNPCTerritorySpawnerInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UNPCTerritorySpawnerInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// ANPCRegistry:AActor
	/// Size: 0x470
	/// Properties: 1
	/// </summary>
	public class ANPCRegistry:AActor
	{
		public override int ObjectSize => 1136;
		/// <summary>
		/// Name: m_ActiveSpawners
		/// Type: TArray<>
		/// Offset: 0x3D0
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
	}


	/// <summary>
	/// AInfo:AActor
	/// Size: 0x3D0
	/// Properties: 0
	/// </summary>
	public class AInfo:AActor
	{
		public override int ObjectSize => 976;
	}


	/// <summary>
	/// AWorldSettings:AInfo
	/// Size: 0x590
	/// Properties: 45
	/// </summary>
	public class AWorldSettings:AInfo
	{
		public override int ObjectSize => 1424;
		/// <summary>
		/// Name: bEnableWorldBoundsChecks
		/// Type: BoolProperty
		/// Offset: 0x3D8
		/// Size: 0x01
		/// </summary>
		public bool bEnableWorldBoundsChecks => (ReadByte(0x03D8) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bEnableNavigationSystem
		/// Type: BoolProperty
		/// Offset: 0x3D8
		/// Size: 0x01
		/// </summary>
		public bool bEnableNavigationSystem => (ReadByte(0x03D8) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bEnableWorldComposition
		/// Type: BoolProperty
		/// Offset: 0x3D8
		/// Size: 0x01
		/// </summary>
		public bool bEnableWorldComposition => (ReadByte(0x03D8) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bEnableWorldOriginRebasing
		/// Type: BoolProperty
		/// Offset: 0x3D8
		/// Size: 0x01
		/// </summary>
		public bool bEnableWorldOriginRebasing => (ReadByte(0x03D8) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bWorldGravitySet
		/// Type: BoolProperty
		/// Offset: 0x3D8
		/// Size: 0x01
		/// </summary>
		public bool bWorldGravitySet => (ReadByte(0x03D8) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bGlobalGravitySet
		/// Type: BoolProperty
		/// Offset: 0x3D8
		/// Size: 0x01
		/// </summary>
		public bool bGlobalGravitySet => (ReadByte(0x03D8) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: KillZ
		/// Type: FloatProperty
		/// Offset: 0x3DC
		/// Size: 0x04
		/// </summary>
		public float KillZ
		{
			get
			{
				return ReadSingle(0x3DC);
			}
			set
			{
				WriteSingle(0x3DC,value);
			}
		}
		
		/// <summary>
		/// Name: KillZDamageType
		/// Type: ClassProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: WorldGravityZ
		/// Type: FloatProperty
		/// Offset: 0x3E8
		/// Size: 0x04
		/// </summary>
		public float WorldGravityZ
		{
			get
			{
				return ReadSingle(0x3E8);
			}
			set
			{
				WriteSingle(0x3E8,value);
			}
		}
		
		/// <summary>
		/// Name: GlobalGravityZ
		/// Type: FloatProperty
		/// Offset: 0x3EC
		/// Size: 0x04
		/// </summary>
		public float GlobalGravityZ
		{
			get
			{
				return ReadSingle(0x3EC);
			}
			set
			{
				WriteSingle(0x3EC,value);
			}
		}
		
		/// <summary>
		/// Name: DefaultPhysicsVolumeClass
		/// Type: ClassProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: PhysicsCollisionHandlerClass
		/// Type: ClassProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: DefaultGameMode
		/// Type: ClassProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: DefaultMapPrefixes
		/// Type: TArray<FGameModePrefix>
		/// Offset: 0x408
		/// Size: 0x10
		/// SubElement Size: 0x20
		/// </summary>
		public TArray<FGameModePrefix> DefaultMapPrefixes => new TArray<FGameModePrefix>(BaseAddress+0x408);
		
		/// <summary>
		/// Name: GameNetworkManagerClass
		/// Type: ClassProperty
		/// Offset: 0x418
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: WorldCompositionClass
		/// Type: ClassProperty
		/// Offset: 0x420
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: PackedLightAndShadowMapTextureSize
		/// Type: IntProperty
		/// Offset: 0x428
		/// Size: 0x04
		/// </summary>
		public int PackedLightAndShadowMapTextureSize
		{
			get
			{
				return ReadInt32(0x428);
			}
			set
			{
				WriteInt32(0x428,value);
			}
		}
		
		/// <summary>
		/// Name: bMinimizeBSPSections
		/// Type: BoolProperty
		/// Offset: 0x42C
		/// Size: 0x01
		/// </summary>
		public bool bMinimizeBSPSections => (ReadByte(0x042C) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: DefaultColorScale
		/// Type: StructProperty
		/// Offset: 0x430
		/// Size: 0x0C
		/// </summary>
		public FVector DefaultColorScale => ReadStruct<FVector>(0x430);
		
		/// <summary>
		/// Name: DefaultMaxDistanceFieldOcclusionDistance
		/// Type: FloatProperty
		/// Offset: 0x43C
		/// Size: 0x04
		/// </summary>
		public float DefaultMaxDistanceFieldOcclusionDistance
		{
			get
			{
				return ReadSingle(0x43C);
			}
			set
			{
				WriteSingle(0x43C,value);
			}
		}
		
		/// <summary>
		/// Name: GlobalDistanceFieldViewDistance
		/// Type: FloatProperty
		/// Offset: 0x440
		/// Size: 0x04
		/// </summary>
		public float GlobalDistanceFieldViewDistance
		{
			get
			{
				return ReadSingle(0x440);
			}
			set
			{
				WriteSingle(0x440,value);
			}
		}
		
		/// <summary>
		/// Name: bPrecomputeVisibility
		/// Type: BoolProperty
		/// Offset: 0x444
		/// Size: 0x01
		/// </summary>
		public bool bPrecomputeVisibility => (ReadByte(0x0444) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bPlaceCellsOnlyAlongCameraTracks
		/// Type: BoolProperty
		/// Offset: 0x444
		/// Size: 0x01
		/// </summary>
		public bool bPlaceCellsOnlyAlongCameraTracks => (ReadByte(0x0444) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: VisibilityCellSize
		/// Type: IntProperty
		/// Offset: 0x448
		/// Size: 0x04
		/// </summary>
		public int VisibilityCellSize
		{
			get
			{
				return ReadInt32(0x448);
			}
			set
			{
				WriteInt32(0x448,value);
			}
		}
		
		/// <summary>
		/// Name: VisibilityAggressiveness
		/// Type: ByteProperty
		/// Offset: 0x44C
		/// Size: 0x01
		/// </summary>
		public byte VisibilityAggressiveness
		{
			get
			{
				return ReadByte(0x44C);
			}
			set
			{
				WriteByte(0x44C,value);
			}
		}
		
		/// <summary>
		/// Name: bForceNoPrecomputedLighting
		/// Type: BoolProperty
		/// Offset: 0x450
		/// Size: 0x01
		/// </summary>
		public bool bForceNoPrecomputedLighting => (ReadByte(0x0450) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: LightmassSettings
		/// Type: StructProperty
		/// Offset: 0x454
		/// Size: 0x48
		/// </summary>
		public FLightmassWorldInfoSettings LightmassSettings => ReadStruct<FLightmassWorldInfoSettings>(0x454);
		
		/// <summary>
		/// Name: LevelLightingQuality
		/// Type: ByteProperty
		/// Offset: 0x49C
		/// Size: 0x01
		/// </summary>
		public byte LevelLightingQuality
		{
			get
			{
				return ReadByte(0x49C);
			}
			set
			{
				WriteByte(0x49C,value);
			}
		}
		
		/// <summary>
		/// Name: DefaultReverbSettings
		/// Type: StructProperty
		/// Offset: 0x4A0
		/// Size: 0x18
		/// </summary>
		public FReverbSettings DefaultReverbSettings => ReadStruct<FReverbSettings>(0x4A0);
		
		/// <summary>
		/// Name: DefaultAmbientZoneSettings
		/// Type: StructProperty
		/// Offset: 0x4B8
		/// Size: 0x24
		/// </summary>
		public FInteriorSettings DefaultAmbientZoneSettings => ReadStruct<FInteriorSettings>(0x4B8);
		
		/// <summary>
		/// Name: DefaultBaseSoundMix
		/// Type: ObjectProperty
		/// Offset: 0x4E0
		/// Size: 0x08
		/// </summary>
		public USoundMix DefaultBaseSoundMix => ReadUObject<USoundMix>(0x4E0);
		
		/// <summary>
		/// Name: WorldToMeters
		/// Type: FloatProperty
		/// Offset: 0x4E8
		/// Size: 0x04
		/// </summary>
		public float WorldToMeters
		{
			get
			{
				return ReadSingle(0x4E8);
			}
			set
			{
				WriteSingle(0x4E8,value);
			}
		}
		
		/// <summary>
		/// Name: BookMarks
		/// Type: ObjectProperty
		/// Offset: 0x4F0
		/// Size: 0x08
		/// </summary>
		public UBookMark BookMarks => ReadUObject<UBookMark>(0x4F0);
		
		/// <summary>
		/// Name: TimeDilation
		/// Type: FloatProperty
		/// Offset: 0x540
		/// Size: 0x04
		/// </summary>
		public float TimeDilation
		{
			get
			{
				return ReadSingle(0x540);
			}
			set
			{
				WriteSingle(0x540,value);
			}
		}
		
		/// <summary>
		/// Name: MatineeTimeDilation
		/// Type: FloatProperty
		/// Offset: 0x544
		/// Size: 0x04
		/// </summary>
		public float MatineeTimeDilation
		{
			get
			{
				return ReadSingle(0x544);
			}
			set
			{
				WriteSingle(0x544,value);
			}
		}
		
		/// <summary>
		/// Name: DemoPlayTimeDilation
		/// Type: FloatProperty
		/// Offset: 0x548
		/// Size: 0x04
		/// </summary>
		public float DemoPlayTimeDilation
		{
			get
			{
				return ReadSingle(0x548);
			}
			set
			{
				WriteSingle(0x548,value);
			}
		}
		
		/// <summary>
		/// Name: MinGlobalTimeDilation
		/// Type: FloatProperty
		/// Offset: 0x54C
		/// Size: 0x04
		/// </summary>
		public float MinGlobalTimeDilation
		{
			get
			{
				return ReadSingle(0x54C);
			}
			set
			{
				WriteSingle(0x54C,value);
			}
		}
		
		/// <summary>
		/// Name: MaxGlobalTimeDilation
		/// Type: FloatProperty
		/// Offset: 0x550
		/// Size: 0x04
		/// </summary>
		public float MaxGlobalTimeDilation
		{
			get
			{
				return ReadSingle(0x550);
			}
			set
			{
				WriteSingle(0x550,value);
			}
		}
		
		/// <summary>
		/// Name: MinUndilatedFrameTime
		/// Type: FloatProperty
		/// Offset: 0x554
		/// Size: 0x04
		/// </summary>
		public float MinUndilatedFrameTime
		{
			get
			{
				return ReadSingle(0x554);
			}
			set
			{
				WriteSingle(0x554,value);
			}
		}
		
		/// <summary>
		/// Name: MaxUndilatedFrameTime
		/// Type: FloatProperty
		/// Offset: 0x558
		/// Size: 0x04
		/// </summary>
		public float MaxUndilatedFrameTime
		{
			get
			{
				return ReadSingle(0x558);
			}
			set
			{
				WriteSingle(0x558,value);
			}
		}
		
		/// <summary>
		/// Name: Pauser
		/// Type: ObjectProperty
		/// Offset: 0x560
		/// Size: 0x08
		/// </summary>
		public APlayerState Pauser => ReadUObject<APlayerState>(0x560);
		
		/// <summary>
		/// Name: bHighPriorityLoading
		/// Type: BoolProperty
		/// Offset: 0x568
		/// Size: 0x01
		/// </summary>
		public bool bHighPriorityLoading => (ReadByte(0x0568) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bHighPriorityLoadingLocal
		/// Type: BoolProperty
		/// Offset: 0x568
		/// Size: 0x01
		/// </summary>
		public bool bHighPriorityLoadingLocal => (ReadByte(0x0568) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: ReplicationViewers
		/// Type: TArray<FNetViewer>
		/// Offset: 0x570
		/// Size: 0x10
		/// SubElement Size: 0x30
		/// </summary>
		public TArray<FNetViewer> ReplicationViewers => new TArray<FNetViewer>(BaseAddress+0x570);
		
		/// <summary>
		/// Name: AssetUserData
		/// Type: TArray<UAssetUserData>
		/// Offset: 0x580
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<UAssetUserData> AssetUserData => new TArray<UAssetUserData>(BaseAddress+0x580);
		
	}


	/// <summary>
	/// AConanWorldSettings:AWorldSettings
	/// Size: 0x608
	/// Properties: 17
	/// </summary>
	public class AConanWorldSettings:AWorldSettings
	{
		public override int ObjectSize => 1544;
		/// <summary>
		/// Name: BuildingGridSize
		/// Type: IntProperty
		/// Offset: 0x590
		/// Size: 0x04
		/// </summary>
		public int BuildingGridSize
		{
			get
			{
				return ReadInt32(0x590);
			}
			set
			{
				WriteInt32(0x590,value);
			}
		}
		
		/// <summary>
		/// Name: FoliageGridSize
		/// Type: IntProperty
		/// Offset: 0x594
		/// Size: 0x04
		/// </summary>
		public int FoliageGridSize
		{
			get
			{
				return ReadInt32(0x594);
			}
			set
			{
				WriteInt32(0x594,value);
			}
		}
		
		/// <summary>
		/// Name: FoliagePhysicsRangeClient
		/// Type: FloatProperty
		/// Offset: 0x598
		/// Size: 0x04
		/// </summary>
		public float FoliagePhysicsRangeClient
		{
			get
			{
				return ReadSingle(0x598);
			}
			set
			{
				WriteSingle(0x598,value);
			}
		}
		
		/// <summary>
		/// Name: FoliagePhysicsRangeServer
		/// Type: FloatProperty
		/// Offset: 0x59C
		/// Size: 0x04
		/// </summary>
		public float FoliagePhysicsRangeServer
		{
			get
			{
				return ReadSingle(0x59C);
			}
			set
			{
				WriteSingle(0x59C,value);
			}
		}
		
		/// <summary>
		/// Name: TetheringRangeStart
		/// Type: FloatProperty
		/// Offset: 0x5A0
		/// Size: 0x04
		/// </summary>
		public float TetheringRangeStart
		{
			get
			{
				return ReadSingle(0x5A0);
			}
			set
			{
				WriteSingle(0x5A0,value);
			}
		}
		
		/// <summary>
		/// Name: TetheringRangeEnd
		/// Type: FloatProperty
		/// Offset: 0x5A4
		/// Size: 0x04
		/// </summary>
		public float TetheringRangeEnd
		{
			get
			{
				return ReadSingle(0x5A4);
			}
			set
			{
				WriteSingle(0x5A4,value);
			}
		}
		
		/// <summary>
		/// Name: AILODBoundary
		/// Type: FloatProperty
		/// Offset: 0x5A8
		/// Size: 0x04
		/// </summary>
		public float AILODBoundary
		{
			get
			{
				return ReadSingle(0x5A8);
			}
			set
			{
				WriteSingle(0x5A8,value);
			}
		}
		
		/// <summary>
		/// Name: AILODMaxRaycastDistance
		/// Type: FloatProperty
		/// Offset: 0x5AC
		/// Size: 0x04
		/// </summary>
		public float AILODMaxRaycastDistance
		{
			get
			{
				return ReadSingle(0x5AC);
			}
			set
			{
				WriteSingle(0x5AC,value);
			}
		}
		
		/// <summary>
		/// Name: BuildingStabilityDecrease
		/// Type: IntProperty
		/// Offset: 0x5B0
		/// Size: 0x04
		/// </summary>
		public int BuildingStabilityDecrease
		{
			get
			{
				return ReadInt32(0x5B0);
			}
			set
			{
				WriteInt32(0x5B0,value);
			}
		}
		
		/// <summary>
		/// Name: NetCullDistanceScaling
		/// Type: FloatProperty
		/// Offset: 0x5B4
		/// Size: 0x04
		/// </summary>
		public float NetCullDistanceScaling
		{
			get
			{
				return ReadSingle(0x5B4);
			}
			set
			{
				WriteSingle(0x5B4,value);
			}
		}
		
		/// <summary>
		/// Name: StaticNavigation
		/// Type: ObjectProperty
		/// Offset: 0x5B8
		/// Size: 0x08
		/// </summary>
		public UStaticNavigation StaticNavigation => ReadUObject<UStaticNavigation>(0x5B8);
		
		/// <summary>
		/// Name: SpawnProbabilityBands
		/// Type: TArray<FSpawnProbabilityBand>
		/// Offset: 0x5C0
		/// Size: 0x10
		/// SubElement Size: 0x08
		/// </summary>
		public TArray<FSpawnProbabilityBand> SpawnProbabilityBands => new TArray<FSpawnProbabilityBand>(BaseAddress+0x5C0);
		
		/// <summary>
		/// Name: SpawnProbabilityBandsListenServer
		/// Type: TArray<FSpawnProbabilityBand>
		/// Offset: 0x5D0
		/// Size: 0x10
		/// SubElement Size: 0x08
		/// </summary>
		public TArray<FSpawnProbabilityBand> SpawnProbabilityBandsListenServer => new TArray<FSpawnProbabilityBand>(BaseAddress+0x5D0);
		
		/// <summary>
		/// Name: m_NPCRegistry
		/// Type: ObjectProperty
		/// Offset: 0x5E0
		/// Size: 0x08
		/// </summary>
		public ANPCRegistry m_NPCRegistry => ReadUObject<ANPCRegistry>(0x5E0);
		
		/// <summary>
		/// Name: m_PlayerPawnRegistry
		/// Type: ObjectProperty
		/// Offset: 0x5E8
		/// Size: 0x08
		/// </summary>
		public APlayerPawnRegistry m_PlayerPawnRegistry => ReadUObject<APlayerPawnRegistry>(0x5E8);
		
		/// <summary>
		/// Name: LandClaim
		/// Type: TArray<ALandClaim>
		/// Offset: 0x5F0
		/// Size: 0x10
		/// SubElement Size: 0x448
		/// </summary>
		public TArray<ALandClaim> LandClaim => new TArray<ALandClaim>(BaseAddress+0x5F0);
		
		/// <summary>
		/// Name: m_EnergyReceiverRegistry
		/// Type: ObjectProperty
		/// Offset: 0x600
		/// Size: 0x08
		/// </summary>
		public AEnergyReceiverRegistry m_EnergyReceiverRegistry => ReadUObject<AEnergyReceiverRegistry>(0x600);
		
	}


	/// <summary>
	/// AAILODSystem:AActor
	/// Size: 0x4E8
	/// Properties: 6
	/// </summary>
	public class AAILODSystem:AActor
	{
		public override int ObjectSize => 1256;
		/// <summary>
		/// Name: ActiveLODComponents
		/// Type: TArray<UAILODComponent>
		/// Offset: 0x3D0
		/// Size: 0x10
		/// SubElement Size: 0x190
		/// </summary>
		public TArray<UAILODComponent> ActiveLODComponents => new TArray<UAILODComponent>(BaseAddress+0x3D0);
		
		/// <summary>
		/// Name: m_AILODComponents
		/// Type: TArray<UAILODComponent>
		/// Offset: 0x3E0
		/// Size: 0x10
		/// SubElement Size: 0x190
		/// </summary>
		public TArray<UAILODComponent> m_AILODComponents => new TArray<UAILODComponent>(BaseAddress+0x3E0);
		
		/// <summary>
		/// Name: m_SuspendCallbacks
		/// Type: MapProperty
		/// Offset: 0x3F0
		/// Size: 0x50
		/// </summary>
		
		/// <summary>
		/// Name: m_LODCounter
		/// Type: IntProperty
		/// Offset: 0x444
		/// Size: 0x04
		/// </summary>
		public int m_LODCounter
		{
			get
			{
				return ReadInt32(0x444);
			}
			set
			{
				WriteInt32(0x444,value);
			}
		}
		
		/// <summary>
		/// Name: m_DebugAILODs
		/// Type: TArray<FAILODInfo>
		/// Offset: 0x458
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FAILODInfo> m_DebugAILODs => new TArray<FAILODInfo>(BaseAddress+0x458);
		
		/// <summary>
		/// Name: m_ShowAILOD
		/// Type: BoolProperty
		/// Offset: 0x468
		/// Size: 0x01
		/// </summary>
		public bool m_ShowAILOD => (ReadByte(0x0468) & 0x01) == 0x01;
		
	}


	/// <summary>
	/// UAISense:UObject
	/// Size: 0x120
	/// Properties: 5
	/// </summary>
	public class UAISense:UObject
	{
		public override int ObjectSize => 288;
		/// <summary>
		/// Name: DefaultExpirationAge
		/// Type: FloatProperty
		/// Offset: 0x28
		/// Size: 0x04
		/// </summary>
		public float DefaultExpirationAge
		{
			get
			{
				return ReadSingle(0x28);
			}
			set
			{
				WriteSingle(0x28,value);
			}
		}
		
		/// <summary>
		/// Name: NotifyType
		/// Type: ByteProperty
		/// Offset: 0x2C
		/// Size: 0x01
		/// </summary>
		public byte NotifyType
		{
			get
			{
				return ReadByte(0x2C);
			}
			set
			{
				WriteByte(0x2C,value);
			}
		}
		
		/// <summary>
		/// Name: bWantsNewPawnNotification
		/// Type: BoolProperty
		/// Offset: 0x30
		/// Size: 0x01
		/// </summary>
		public bool bWantsNewPawnNotification => (ReadByte(0x0030) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bAutoRegisterAllPawnsAsSources
		/// Type: BoolProperty
		/// Offset: 0x30
		/// Size: 0x01
		/// </summary>
		public bool bAutoRegisterAllPawnsAsSources => (ReadByte(0x0030) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: PerceptionSystemInstance
		/// Type: ObjectProperty
		/// Offset: 0x38
		/// Size: 0x08
		/// </summary>
		public UAIPerceptionSystem PerceptionSystemInstance => ReadUObject<UAIPerceptionSystem>(0x38);
		
	}


	/// <summary>
	/// UAISense_NewSight:UAISense
	/// Size: 0x260
	/// Properties: 4
	/// </summary>
	public class UAISense_NewSight:UAISense
	{
		public override int ObjectSize => 608;
		/// <summary>
		/// Name: MaxTracesPerTick
		/// Type: IntProperty
		/// Offset: 0x248
		/// Size: 0x04
		/// </summary>
		public int MaxTracesPerTick
		{
			get
			{
				return ReadInt32(0x248);
			}
			set
			{
				WriteInt32(0x248,value);
			}
		}
		
		/// <summary>
		/// Name: HighImportanceQueryDistanceThreshold
		/// Type: FloatProperty
		/// Offset: 0x24C
		/// Size: 0x04
		/// </summary>
		public float HighImportanceQueryDistanceThreshold
		{
			get
			{
				return ReadSingle(0x24C);
			}
			set
			{
				WriteSingle(0x24C,value);
			}
		}
		
		/// <summary>
		/// Name: MaxQueryImportance
		/// Type: FloatProperty
		/// Offset: 0x254
		/// Size: 0x04
		/// </summary>
		public float MaxQueryImportance
		{
			get
			{
				return ReadSingle(0x254);
			}
			set
			{
				WriteSingle(0x254,value);
			}
		}
		
		/// <summary>
		/// Name: SightLimitQueryImportance
		/// Type: FloatProperty
		/// Offset: 0x258
		/// Size: 0x04
		/// </summary>
		public float SightLimitQueryImportance
		{
			get
			{
				return ReadSingle(0x258);
			}
			set
			{
				WriteSingle(0x258,value);
			}
		}
		
	}


	/// <summary>
	/// UAISenseConfig:UObject
	/// Size: 0x48
	/// Properties: 3
	/// </summary>
	public class UAISenseConfig:UObject
	{
		public override int ObjectSize => 72;
		/// <summary>
		/// Name: DebugColor
		/// Type: StructProperty
		/// Offset: 0x28
		/// Size: 0x04
		/// </summary>
		public FColor DebugColor => ReadStruct<FColor>(0x28);
		
		/// <summary>
		/// Name: MaxAge
		/// Type: FloatProperty
		/// Offset: 0x2C
		/// Size: 0x04
		/// </summary>
		public float MaxAge
		{
			get
			{
				return ReadSingle(0x2C);
			}
			set
			{
				WriteSingle(0x2C,value);
			}
		}
		
		/// <summary>
		/// Name: bStartsEnabled
		/// Type: BoolProperty
		/// Offset: 0x30
		/// Size: 0x01
		/// </summary>
		public bool bStartsEnabled => (ReadByte(0x0030) & 0x01) == 0x01;
		
	}


	/// <summary>
	/// UAISenseConfig_NewSight:UAISenseConfig
	/// Size: 0x68
	/// Properties: 6
	/// </summary>
	public class UAISenseConfig_NewSight:UAISenseConfig
	{
		public override int ObjectSize => 104;
		/// <summary>
		/// Name: Implementation
		/// Type: ClassProperty
		/// Offset: 0x48
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: SightRadius
		/// Type: FloatProperty
		/// Offset: 0x50
		/// Size: 0x04
		/// </summary>
		public float SightRadius
		{
			get
			{
				return ReadSingle(0x50);
			}
			set
			{
				WriteSingle(0x50,value);
			}
		}
		
		/// <summary>
		/// Name: LoseSightRadius
		/// Type: FloatProperty
		/// Offset: 0x54
		/// Size: 0x04
		/// </summary>
		public float LoseSightRadius
		{
			get
			{
				return ReadSingle(0x54);
			}
			set
			{
				WriteSingle(0x54,value);
			}
		}
		
		/// <summary>
		/// Name: PeripheralVisionAngleDegrees
		/// Type: FloatProperty
		/// Offset: 0x58
		/// Size: 0x04
		/// </summary>
		public float PeripheralVisionAngleDegrees
		{
			get
			{
				return ReadSingle(0x58);
			}
			set
			{
				WriteSingle(0x58,value);
			}
		}
		
		/// <summary>
		/// Name: DetectionByAffiliation
		/// Type: StructProperty
		/// Offset: 0x5C
		/// Size: 0x04
		/// </summary>
		public FAISenseAffiliationFilter DetectionByAffiliation => ReadStruct<FAISenseAffiliationFilter>(0x5C);
		
		/// <summary>
		/// Name: AutoSuccessRangeFromLastSeenLocation
		/// Type: FloatProperty
		/// Offset: 0x60
		/// Size: 0x04
		/// </summary>
		public float AutoSuccessRangeFromLastSeenLocation
		{
			get
			{
				return ReadSingle(0x60);
			}
			set
			{
				WriteSingle(0x60,value);
			}
		}
		
	}


	/// <summary>
	/// UAnimationFunctionLibrary:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UAnimationFunctionLibrary:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UAvatarSpawnerInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UAvatarSpawnerInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// APlaceableBase:ABuildableBase
	/// Size: 0x4D8
	/// Properties: 10
	/// </summary>
	public class APlaceableBase:ABuildableBase
	{
		public override int ObjectSize => 1240;
		/// <summary>
		/// Name: CraftingGroups
		/// Type: TArray<>
		/// Offset: 0x490
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: DestroyActorOnZeroHealth
		/// Type: BoolProperty
		/// Offset: 0x4A0
		/// Size: 0x01
		/// </summary>
		public bool DestroyActorOnZeroHealth
		{
			get
			{
				return ReadBool(0x4A0);
			}
			set
			{
				WriteBool(0x4A0,value);
			}
		}
		
		/// <summary>
		/// Name: DropInventoryContentOnDestroyed
		/// Type: BoolProperty
		/// Offset: 0x4A1
		/// Size: 0x01
		/// </summary>
		public bool DropInventoryContentOnDestroyed
		{
			get
			{
				return ReadBool(0x4A1);
			}
			set
			{
				WriteBool(0x4A1,value);
			}
		}
		
		/// <summary>
		/// Name: LootContainerClass
		/// Type: ClassProperty
		/// Offset: 0x4A8
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: DoNotRespectOwnership
		/// Type: BoolProperty
		/// Offset: 0x4B0
		/// Size: 0x01
		/// </summary>
		public bool DoNotRespectOwnership
		{
			get
			{
				return ReadBool(0x4B0);
			}
			set
			{
				WriteBool(0x4B0,value);
			}
		}
		
		/// <summary>
		/// Name: CanTakeDamage
		/// Type: BoolProperty
		/// Offset: 0x4B1
		/// Size: 0x01
		/// </summary>
		public bool CanTakeDamage
		{
			get
			{
				return ReadBool(0x4B1);
			}
			set
			{
				WriteBool(0x4B1,value);
			}
		}
		
		/// <summary>
		/// Name: IgnoreCanDamagePlayerOwnedStucture
		/// Type: BoolProperty
		/// Offset: 0x4B2
		/// Size: 0x01
		/// </summary>
		public bool IgnoreCanDamagePlayerOwnedStucture
		{
			get
			{
				return ReadBool(0x4B2);
			}
			set
			{
				WriteBool(0x4B2,value);
			}
		}
		
		/// <summary>
		/// Name: UpgradeTargets
		/// Type: TArray<>
		/// Offset: 0x4B8
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: HasHitGround
		/// Type: BoolProperty
		/// Offset: 0x4C8
		/// Size: 0x01
		/// </summary>
		public bool HasHitGround
		{
			get
			{
				return ReadBool(0x4C8);
			}
			set
			{
				WriteBool(0x4C8,value);
			}
		}
		
		/// <summary>
		/// Name: AttachedToModule
		/// Type: ObjectProperty
		/// Offset: 0x4D0
		/// Size: 0x08
		/// </summary>
		public UBuildingModuleData AttachedToModule => ReadUObject<UBuildingModuleData>(0x4D0);
		
	}


	/// <summary>
	/// UBuildSystemComponent:UActorComponent
	/// Size: 0x1A0
	/// Properties: 23
	/// </summary>
	public class UBuildSystemComponent:UActorComponent
	{
		public override int ObjectSize => 416;
		/// <summary>
		/// Name: IsBuilding
		/// Type: BoolProperty
		/// Offset: 0xD8
		/// Size: 0x01
		/// </summary>
		public bool IsBuilding
		{
			get
			{
				return ReadBool(0xD8);
			}
			set
			{
				WriteBool(0xD8,value);
			}
		}
		
		/// <summary>
		/// Name: developerMode
		/// Type: BoolProperty
		/// Offset: 0xD9
		/// Size: 0x01
		/// </summary>
		public bool developerMode
		{
			get
			{
				return ReadBool(0xD9);
			}
			set
			{
				WriteBool(0xD9,value);
			}
		}
		
		/// <summary>
		/// Name: CurrentBuildBrushClass
		/// Type: ClassProperty
		/// Offset: 0xE0
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: SourceBuildItem
		/// Type: ObjectProperty
		/// Offset: 0xE8
		/// Size: 0x08
		/// </summary>
		public UBuildingItem SourceBuildItem => ReadUObject<UBuildingItem>(0xE8);
		
		/// <summary>
		/// Name: buildingMode
		/// Type: ByteProperty
		/// Offset: 0xF0
		/// Size: 0x01
		/// </summary>
		public byte buildingMode
		{
			get
			{
				return ReadByte(0xF0);
			}
			set
			{
				WriteByte(0xF0,value);
			}
		}
		
		/// <summary>
		/// Name: ValidSocketResults
		/// Type: TArray<FValidSocketResult>
		/// Offset: 0xF8
		/// Size: 0x10
		/// SubElement Size: 0x80
		/// </summary>
		public TArray<FValidSocketResult> ValidSocketResults => new TArray<FValidSocketResult>(BaseAddress+0xF8);
		
		/// <summary>
		/// Name: CurrentSocketResultIndex
		/// Type: IntProperty
		/// Offset: 0x108
		/// Size: 0x04
		/// </summary>
		public int CurrentSocketResultIndex
		{
			get
			{
				return ReadInt32(0x108);
			}
			set
			{
				WriteInt32(0x108,value);
			}
		}
		
		/// <summary>
		/// Name: BuildingBrushBase
		/// Type: ObjectProperty
		/// Offset: 0x110
		/// Size: 0x08
		/// </summary>
		public ABuildableBase BuildingBrushBase => ReadUObject<ABuildableBase>(0x110);
		
		/// <summary>
		/// Name: PlacementGhostRadius
		/// Type: FloatProperty
		/// Offset: 0x118
		/// Size: 0x04
		/// </summary>
		public float PlacementGhostRadius
		{
			get
			{
				return ReadSingle(0x118);
			}
			set
			{
				WriteSingle(0x118,value);
			}
		}
		
		/// <summary>
		/// Name: PlacementGhostObjectType
		/// Type: ByteProperty
		/// Offset: 0x11C
		/// Size: 0x01
		/// </summary>
		public byte PlacementGhostObjectType
		{
			get
			{
				return ReadByte(0x11C);
			}
			set
			{
				WriteByte(0x11C,value);
			}
		}
		
		/// <summary>
		/// Name: PlacementGhostLineTraceChannel
		/// Type: ByteProperty
		/// Offset: 0x11D
		/// Size: 0x01
		/// </summary>
		public byte PlacementGhostLineTraceChannel
		{
			get
			{
				return ReadByte(0x11D);
			}
			set
			{
				WriteByte(0x11D,value);
			}
		}
		
		/// <summary>
		/// Name: PlacementGhostMaterial
		/// Type: ObjectProperty
		/// Offset: 0x120
		/// Size: 0x08
		/// </summary>
		public UMaterialInterface PlacementGhostMaterial => ReadUObject<UMaterialInterface>(0x120);
		
		/// <summary>
		/// Name: PlacementUpgradeGhostMaterial
		/// Type: ObjectProperty
		/// Offset: 0x128
		/// Size: 0x08
		/// </summary>
		public UMaterialInterface PlacementUpgradeGhostMaterial => ReadUObject<UMaterialInterface>(0x128);
		
		/// <summary>
		/// Name: ShowBuildingSockets
		/// Type: BoolProperty
		/// Offset: 0x130
		/// Size: 0x01
		/// </summary>
		public bool ShowBuildingSockets
		{
			get
			{
				return ReadBool(0x130);
			}
			set
			{
				WriteBool(0x130,value);
			}
		}
		
		/// <summary>
		/// Name: IconDismantle
		/// Type: ObjectProperty
		/// Offset: 0x138
		/// Size: 0x08
		/// </summary>
		public UTexture2D IconDismantle => ReadUObject<UTexture2D>(0x138);
		
		/// <summary>
		/// Name: ghostBuildingComponent
		/// Type: ObjectProperty
		/// Offset: 0x140
		/// Size: 0x08
		/// </summary>
		public UInstancedStaticMeshComponent ghostBuildingComponent => ReadUObject<UInstancedStaticMeshComponent>(0x140);
		
		/// <summary>
		/// Name: ghostBuildingUpgradeablesComponent
		/// Type: ObjectProperty
		/// Offset: 0x148
		/// Size: 0x08
		/// </summary>
		public UInstancedStaticMeshComponent ghostBuildingUpgradeablesComponent => ReadUObject<UInstancedStaticMeshComponent>(0x148);
		
		/// <summary>
		/// Name: ghostSocketResults
		/// Type: TArray<FValidSocketResult>
		/// Offset: 0x150
		/// Size: 0x10
		/// SubElement Size: 0x80
		/// </summary>
		public TArray<FValidSocketResult> ghostSocketResults => new TArray<FValidSocketResult>(BaseAddress+0x150);
		
		/// <summary>
		/// Name: invalidGhostSocketResults
		/// Type: TArray<FValidSocketResult>
		/// Offset: 0x160
		/// Size: 0x10
		/// SubElement Size: 0x80
		/// </summary>
		public TArray<FValidSocketResult> invalidGhostSocketResults => new TArray<FValidSocketResult>(BaseAddress+0x160);
		
		/// <summary>
		/// Name: ghostSocketIndexedResults
		/// Type: TArray<FValidSocketResult>
		/// Offset: 0x170
		/// Size: 0x10
		/// SubElement Size: 0x80
		/// </summary>
		public TArray<FValidSocketResult> ghostSocketIndexedResults => new TArray<FValidSocketResult>(BaseAddress+0x170);
		
		/// <summary>
		/// Name: ghostUpgradeSocketIndexedResults
		/// Type: TArray<FValidSocketResult>
		/// Offset: 0x180
		/// Size: 0x10
		/// SubElement Size: 0x80
		/// </summary>
		public TArray<FValidSocketResult> ghostUpgradeSocketIndexedResults => new TArray<FValidSocketResult>(BaseAddress+0x180);
		
		/// <summary>
		/// Name: lastGhostOrigin
		/// Type: StructProperty
		/// Offset: 0x190
		/// Size: 0x0C
		/// </summary>
		public FVector lastGhostOrigin => ReadStruct<FVector>(0x190);
		
		/// <summary>
		/// Name: m_bDirtyGhosts
		/// Type: BoolProperty
		/// Offset: 0x19C
		/// Size: 0x01
		/// </summary>
		public bool m_bDirtyGhosts
		{
			get
			{
				return ReadBool(0x19C);
			}
			set
			{
				WriteBool(0x19C,value);
			}
		}
		
	}


	/// <summary>
	/// UCharacterCustomizationComponent:UActorComponent
	/// Size: 0x430
	/// Properties: 7
	/// </summary>
	public class UCharacterCustomizationComponent:UActorComponent
	{
		public override int ObjectSize => 1072;
		/// <summary>
		/// Name: Layout
		/// Type: StructProperty
		/// Offset: 0xD8
		/// Size: 0x124
		/// </summary>
		public FCharacterLayout Layout => ReadStruct<FCharacterLayout>(0xD8);
		
		/// <summary>
		/// Name: LayoutHash
		/// Type: IntProperty
		/// Offset: 0x1FC
		/// Size: 0x04
		/// </summary>
		public int LayoutHash
		{
			get
			{
				return ReadInt32(0x1FC);
			}
			set
			{
				WriteInt32(0x1FC,value);
			}
		}
		
		/// <summary>
		/// Name: Meshes
		/// Type: StructProperty
		/// Offset: 0x200
		/// Size: 0x50
		/// </summary>
		public FCharacterResolvedMeshes Meshes => ReadStruct<FCharacterResolvedMeshes>(0x200);
		
		/// <summary>
		/// Name: MaterialParams
		/// Type: StructProperty
		/// Offset: 0x250
		/// Size: 0xF8
		/// </summary>
		public FCharacterMaterialParams MaterialParams => ReadStruct<FCharacterMaterialParams>(0x250);
		
		/// <summary>
		/// Name: Master
		/// Type: ObjectProperty
		/// Offset: 0x348
		/// Size: 0x08
		/// </summary>
		public USkeletalMeshComponent Master => ReadUObject<USkeletalMeshComponent>(0x348);
		
		/// <summary>
		/// Name: SkeletalMeshes
		/// Type: TArray<USkeletalMeshComponent>
		/// Offset: 0x350
		/// Size: 0x10
		/// SubElement Size: 0xD20
		/// </summary>
		public TArray<USkeletalMeshComponent> SkeletalMeshes => new TArray<USkeletalMeshComponent>(BaseAddress+0x350);
		
		/// <summary>
		/// Name: SpawnInitialHidden
		/// Type: BoolProperty
		/// Offset: 0x360
		/// Size: 0x01
		/// </summary>
		public bool SpawnInitialHidden
		{
			get
			{
				return ReadBool(0x360);
			}
			set
			{
				WriteBool(0x360,value);
			}
		}
		
	}


	/// <summary>
	/// UCharacterFunctionLibrary:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UCharacterFunctionLibrary:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// ACharacterCreationActorBase:AActor
	/// Size: 0x4B0
	/// Properties: 6
	/// </summary>
	public class ACharacterCreationActorBase:AActor
	{
		public override int ObjectSize => 1200;
		/// <summary>
		/// Name: m_Spotlight
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public USpotLightComponent m_Spotlight => ReadUObject<USpotLightComponent>(0x3E0);
		
		/// <summary>
		/// Name: m_Voice
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UAudioComponent m_Voice => ReadUObject<UAudioComponent>(0x3E8);
		
		/// <summary>
		/// Name: MaxIntensity
		/// Type: FloatProperty
		/// Offset: 0x3F0
		/// Size: 0x04
		/// </summary>
		public float MaxIntensity
		{
			get
			{
				return ReadSingle(0x3F0);
			}
			set
			{
				WriteSingle(0x3F0,value);
			}
		}
		
		/// <summary>
		/// Name: DefaultIntensity
		/// Type: FloatProperty
		/// Offset: 0x3F4
		/// Size: 0x04
		/// </summary>
		public float DefaultIntensity
		{
			get
			{
				return ReadSingle(0x3F4);
			}
			set
			{
				WriteSingle(0x3F4,value);
			}
		}
		
		/// <summary>
		/// Name: m_MeshComponents
		/// Type: ObjectProperty
		/// Offset: 0x460
		/// Size: 0x08
		/// </summary>
		public USkeletalMeshComponent m_MeshComponents => ReadUObject<USkeletalMeshComponent>(0x460);
		
		/// <summary>
		/// Name: m_CharacterBase
		/// Type: ObjectProperty
		/// Offset: 0x4A8
		/// Size: 0x08
		/// </summary>
		public USkeletalMeshComponent m_CharacterBase => ReadUObject<USkeletalMeshComponent>(0x4A8);
		
	}


	/// <summary>
	/// UCharacterCreationBase:UWindowRoot
	/// Size: 0x378
	/// Properties: 0
	/// </summary>
	public class UCharacterCreationBase:UWindowRoot
	{
		public override int ObjectSize => 888;
	}


	/// <summary>
	/// ACharacterLodSystem:AInfo
	/// Size: 0x4D0
	/// Properties: 9
	/// </summary>
	public class ACharacterLodSystem:AInfo
	{
		public override int ObjectSize => 1232;
		/// <summary>
		/// Name: SimultaneousIK
		/// Type: IntProperty
		/// Offset: 0x3D0
		/// Size: 0x04
		/// </summary>
		public int SimultaneousIK
		{
			get
			{
				return ReadInt32(0x3D0);
			}
			set
			{
				WriteInt32(0x3D0,value);
			}
		}
		
		/// <summary>
		/// Name: IKLodUpdateInterval
		/// Type: FloatProperty
		/// Offset: 0x3D4
		/// Size: 0x04
		/// </summary>
		public float IKLodUpdateInterval
		{
			get
			{
				return ReadSingle(0x3D4);
			}
			set
			{
				WriteSingle(0x3D4,value);
			}
		}
		
		/// <summary>
		/// Name: IKRange
		/// Type: FloatProperty
		/// Offset: 0x3D8
		/// Size: 0x04
		/// </summary>
		public float IKRange
		{
			get
			{
				return ReadSingle(0x3D8);
			}
			set
			{
				WriteSingle(0x3D8,value);
			}
		}
		
		/// <summary>
		/// Name: SimultaneousHighQualityHair
		/// Type: IntProperty
		/// Offset: 0x3DC
		/// Size: 0x04
		/// </summary>
		public int SimultaneousHighQualityHair
		{
			get
			{
				return ReadInt32(0x3DC);
			}
			set
			{
				WriteInt32(0x3DC,value);
			}
		}
		
		/// <summary>
		/// Name: HairLodUpdateInterval
		/// Type: FloatProperty
		/// Offset: 0x3E0
		/// Size: 0x04
		/// </summary>
		public float HairLodUpdateInterval
		{
			get
			{
				return ReadSingle(0x3E0);
			}
			set
			{
				WriteSingle(0x3E0,value);
			}
		}
		
		/// <summary>
		/// Name: IKActors
		/// Type: TArray<AActor>
		/// Offset: 0x3F0
		/// Size: 0x10
		/// SubElement Size: 0x3D0
		/// </summary>
		public TArray<AActor> IKActors => new TArray<AActor>(BaseAddress+0x3F0);
		
		/// <summary>
		/// Name: HighQualityHairComponents
		/// Type: TArray<UCharacterCustomizationComponent>
		/// Offset: 0x408
		/// Size: 0x10
		/// SubElement Size: 0x430
		/// </summary>
		public TArray<UCharacterCustomizationComponent> HighQualityHairComponents => new TArray<UCharacterCustomizationComponent>(BaseAddress+0x408);
		
		/// <summary>
		/// Name: m_EnabledClothSimActors
		/// Type: MapProperty
		/// Offset: 0x430
		/// Size: 0x50
		/// </summary>
		
		/// <summary>
		/// Name: m_AllClothSimActors
		/// Type: MapProperty
		/// Offset: 0x480
		/// Size: 0x50
		/// </summary>
		
	}


	/// <summary>
	/// UChatCommandHelper:UObject
	/// Size: 0x38
	/// Properties: 0
	/// </summary>
	public class UChatCommandHelper:UObject
	{
		public override int ObjectSize => 56;
	}


	/// <summary>
	/// UCollisionStaticMeshComponent:UStaticMeshComponent
	/// Size: 0x6E0
	/// Properties: 0
	/// </summary>
	public class UCollisionStaticMeshComponent:UStaticMeshComponent
	{
		public override int ObjectSize => 1760;
	}


	/// <summary>
	/// UCollisionSystemComponent:UActorComponent
	/// Size: 0x1A0
	/// Properties: 7
	/// </summary>
	public class UCollisionSystemComponent:UActorComponent
	{
		public override int ObjectSize => 416;
		/// <summary>
		/// Name: DefendingActors
		/// Type: TArray<AActor>
		/// Offset: 0xD8
		/// Size: 0x10
		/// SubElement Size: 0x3D0
		/// </summary>
		public TArray<AActor> DefendingActors => new TArray<AActor>(BaseAddress+0xD8);
		
		/// <summary>
		/// Name: HasDoneLineTrace
		/// Type: BoolProperty
		/// Offset: 0xE8
		/// Size: 0x01
		/// </summary>
		public bool HasDoneLineTrace
		{
			get
			{
				return ReadBool(0xE8);
			}
			set
			{
				WriteBool(0xE8,value);
			}
		}
		
		/// <summary>
		/// Name: LineTraceHitResult
		/// Type: StructProperty
		/// Offset: 0xF0
		/// Size: 0x88
		/// </summary>
		public FHitResult LineTraceHitResult => ReadStruct<FHitResult>(0xF0);
		
		/// <summary>
		/// Name: SweepHitResults
		/// Type: TArray<FHitResult>
		/// Offset: 0x178
		/// Size: 0x10
		/// SubElement Size: 0x88
		/// </summary>
		public TArray<FHitResult> SweepHitResults => new TArray<FHitResult>(BaseAddress+0x178);
		
		/// <summary>
		/// Name: FinishedFeedbackResults
		/// Type: TArray<FHitResult>
		/// Offset: 0x188
		/// Size: 0x10
		/// SubElement Size: 0x88
		/// </summary>
		public TArray<FHitResult> FinishedFeedbackResults => new TArray<FHitResult>(BaseAddress+0x188);
		
		/// <summary>
		/// Name: HasSweepHitAnything
		/// Type: BoolProperty
		/// Offset: 0x198
		/// Size: 0x01
		/// </summary>
		public bool HasSweepHitAnything
		{
			get
			{
				return ReadBool(0x198);
			}
			set
			{
				WriteBool(0x198,value);
			}
		}
		
		/// <summary>
		/// Name: LineTraceWasAHit
		/// Type: BoolProperty
		/// Offset: 0x199
		/// Size: 0x01
		/// </summary>
		public bool LineTraceWasAHit
		{
			get
			{
				return ReadBool(0x199);
			}
			set
			{
				WriteBool(0x199,value);
			}
		}
		
	}


	/// <summary>
	/// UPointOfInterestCollectionHelper:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UPointOfInterestCollectionHelper:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// AController:AActor
	/// Size: 0x438
	/// Properties: 8
	/// </summary>
	public class AController:AActor
	{
		public override int ObjectSize => 1080;
		/// <summary>
		/// Name: Pawn
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public APawn Pawn => ReadUObject<APawn>(0x3D8);
		
		/// <summary>
		/// Name: Character
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public ACharacter Character => ReadUObject<ACharacter>(0x3E8);
		
		/// <summary>
		/// Name: PlayerState
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public APlayerState PlayerState => ReadUObject<APlayerState>(0x3F0);
		
		/// <summary>
		/// Name: TransformComponent
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public USceneComponent TransformComponent => ReadUObject<USceneComponent>(0x3F8);
		
		/// <summary>
		/// Name: ControlRotation
		/// Type: StructProperty
		/// Offset: 0x400
		/// Size: 0x0C
		/// </summary>
		public FRotator ControlRotation => ReadStruct<FRotator>(0x400);
		
		/// <summary>
		/// Name: bAttachToPawn
		/// Type: BoolProperty
		/// Offset: 0x40C
		/// Size: 0x01
		/// </summary>
		public bool bAttachToPawn => (ReadByte(0x040C) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bIsPlayerController
		/// Type: BoolProperty
		/// Offset: 0x40C
		/// Size: 0x01
		/// </summary>
		public bool bIsPlayerController => (ReadByte(0x040C) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: StateName
		/// Type: NameProperty
		/// Offset: 0x420
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// AAIController:AController
	/// Size: 0x4B8
	/// Properties: 12
	/// </summary>
	public class AAIController:AController
	{
		public override int ObjectSize => 1208;
		/// <summary>
		/// Name: bStopAILogicOnUnposses
		/// Type: BoolProperty
		/// Offset: 0x468
		/// Size: 0x01
		/// </summary>
		public bool bStopAILogicOnUnposses => (ReadByte(0x0468) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bLOSflag
		/// Type: BoolProperty
		/// Offset: 0x468
		/// Size: 0x01
		/// </summary>
		public bool bLOSflag => (ReadByte(0x0468) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bSkipExtraLOSChecks
		/// Type: BoolProperty
		/// Offset: 0x468
		/// Size: 0x01
		/// </summary>
		public bool bSkipExtraLOSChecks => (ReadByte(0x0468) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bAllowStrafe
		/// Type: BoolProperty
		/// Offset: 0x468
		/// Size: 0x01
		/// </summary>
		public bool bAllowStrafe => (ReadByte(0x0468) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bWantsPlayerState
		/// Type: BoolProperty
		/// Offset: 0x468
		/// Size: 0x01
		/// </summary>
		public bool bWantsPlayerState => (ReadByte(0x0468) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bSetControlRotationFromPawnOrientation
		/// Type: BoolProperty
		/// Offset: 0x468
		/// Size: 0x01
		/// </summary>
		public bool bSetControlRotationFromPawnOrientation => (ReadByte(0x0468) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: PathFollowingComponent
		/// Type: ObjectProperty
		/// Offset: 0x470
		/// Size: 0x08
		/// </summary>
		public UPathFollowingComponent PathFollowingComponent => ReadUObject<UPathFollowingComponent>(0x470);
		
		/// <summary>
		/// Name: BrainComponent
		/// Type: ObjectProperty
		/// Offset: 0x478
		/// Size: 0x08
		/// </summary>
		public UBrainComponent BrainComponent => ReadUObject<UBrainComponent>(0x478);
		
		/// <summary>
		/// Name: PerceptionComponent
		/// Type: ObjectProperty
		/// Offset: 0x480
		/// Size: 0x08
		/// </summary>
		public UAIPerceptionComponent PerceptionComponent => ReadUObject<UAIPerceptionComponent>(0x480);
		
		/// <summary>
		/// Name: ActionsComp
		/// Type: ObjectProperty
		/// Offset: 0x488
		/// Size: 0x08
		/// </summary>
		public UPawnActionsComponent ActionsComp => ReadUObject<UPawnActionsComponent>(0x488);
		
		/// <summary>
		/// Name: Blackboard
		/// Type: ObjectProperty
		/// Offset: 0x490
		/// Size: 0x08
		/// </summary>
		public UBlackboardComponent Blackboard => ReadUObject<UBlackboardComponent>(0x490);
		
		/// <summary>
		/// Name: CachedGameplayTasksComponent
		/// Type: ObjectProperty
		/// Offset: 0x498
		/// Size: 0x08
		/// </summary>
		public UGameplayTasksComponent CachedGameplayTasksComponent => ReadUObject<UGameplayTasksComponent>(0x498);
		
	}


	/// <summary>
	/// AConanAIController:AAIController
	/// Size: 0x5A0
	/// Properties: 2
	/// </summary>
	public class AConanAIController:AAIController
	{
		public override int ObjectSize => 1440;
		/// <summary>
		/// Name: PointOfInterestCollection
		/// Type: StructProperty
		/// Offset: 0x4C0
		/// Size: 0xC0
		/// </summary>
		public FPointOfInterestCollection PointOfInterestCollection => ReadStruct<FPointOfInterestCollection>(0x4C0);
		
		/// <summary>
		/// Name: DeferredBTAsset
		/// Type: ObjectProperty
		/// Offset: 0x580
		/// Size: 0x08
		/// </summary>
		public UBehaviorTree DeferredBTAsset => ReadUObject<UBehaviorTree>(0x580);
		
	}


	/// <summary>
	/// AConanAmbientSound:AActor
	/// Size: 0x3D8
	/// Properties: 1
	/// </summary>
	public class AConanAmbientSound:AActor
	{
		public override int ObjectSize => 984;
		/// <summary>
		/// Name: AudioComponent
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UConanAudioComponent AudioComponent => ReadUObject<UConanAudioComponent>(0x3D0);
		
	}


	/// <summary>
	/// UAudioComponent:USceneComponent
	/// Size: 0x420
	/// Properties: 25
	/// </summary>
	public class UAudioComponent:USceneComponent
	{
		public override int ObjectSize => 1056;
		/// <summary>
		/// Name: Sound
		/// Type: ObjectProperty
		/// Offset: 0x218
		/// Size: 0x08
		/// </summary>
		public USoundBase Sound => ReadUObject<USoundBase>(0x218);
		
		/// <summary>
		/// Name: InstanceParameters
		/// Type: TArray<FAudioComponentParam>
		/// Offset: 0x220
		/// Size: 0x10
		/// SubElement Size: 0x20
		/// </summary>
		public TArray<FAudioComponentParam> InstanceParameters => new TArray<FAudioComponentParam>(BaseAddress+0x220);
		
		/// <summary>
		/// Name: SoundClassOverride
		/// Type: ObjectProperty
		/// Offset: 0x230
		/// Size: 0x08
		/// </summary>
		public USoundClass SoundClassOverride => ReadUObject<USoundClass>(0x230);
		
		/// <summary>
		/// Name: bAutoDestroy
		/// Type: BoolProperty
		/// Offset: 0x238
		/// Size: 0x01
		/// </summary>
		public bool bAutoDestroy => (ReadByte(0x0238) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bStopWhenOwnerDestroyed
		/// Type: BoolProperty
		/// Offset: 0x238
		/// Size: 0x01
		/// </summary>
		public bool bStopWhenOwnerDestroyed => (ReadByte(0x0238) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bShouldRemainActiveIfDropped
		/// Type: BoolProperty
		/// Offset: 0x238
		/// Size: 0x01
		/// </summary>
		public bool bShouldRemainActiveIfDropped => (ReadByte(0x0238) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bAllowSpatialization
		/// Type: BoolProperty
		/// Offset: 0x238
		/// Size: 0x01
		/// </summary>
		public bool bAllowSpatialization => (ReadByte(0x0238) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bOverrideAttenuation
		/// Type: BoolProperty
		/// Offset: 0x238
		/// Size: 0x01
		/// </summary>
		public bool bOverrideAttenuation => (ReadByte(0x0238) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bIsUISound
		/// Type: BoolProperty
		/// Offset: 0x238
		/// Size: 0x01
		/// </summary>
		public bool bIsUISound => (ReadByte(0x0238) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: bEnableLowPassFilter
		/// Type: BoolProperty
		/// Offset: 0x238
		/// Size: 0x01
		/// </summary>
		public bool bEnableLowPassFilter => (ReadByte(0x0238) & 0x40) == 0x40;
		
		/// <summary>
		/// Name: bOverridePriority
		/// Type: BoolProperty
		/// Offset: 0x238
		/// Size: 0x01
		/// </summary>
		public bool bOverridePriority => (ReadByte(0x0238) & 0x80) == 0x80;
		
		/// <summary>
		/// Name: PitchModulationMin
		/// Type: FloatProperty
		/// Offset: 0x23C
		/// Size: 0x04
		/// </summary>
		public float PitchModulationMin
		{
			get
			{
				return ReadSingle(0x23C);
			}
			set
			{
				WriteSingle(0x23C,value);
			}
		}
		
		/// <summary>
		/// Name: PitchModulationMax
		/// Type: FloatProperty
		/// Offset: 0x240
		/// Size: 0x04
		/// </summary>
		public float PitchModulationMax
		{
			get
			{
				return ReadSingle(0x240);
			}
			set
			{
				WriteSingle(0x240,value);
			}
		}
		
		/// <summary>
		/// Name: VolumeModulationMin
		/// Type: FloatProperty
		/// Offset: 0x244
		/// Size: 0x04
		/// </summary>
		public float VolumeModulationMin
		{
			get
			{
				return ReadSingle(0x244);
			}
			set
			{
				WriteSingle(0x244,value);
			}
		}
		
		/// <summary>
		/// Name: VolumeModulationMax
		/// Type: FloatProperty
		/// Offset: 0x248
		/// Size: 0x04
		/// </summary>
		public float VolumeModulationMax
		{
			get
			{
				return ReadSingle(0x248);
			}
			set
			{
				WriteSingle(0x248,value);
			}
		}
		
		/// <summary>
		/// Name: VolumeMultiplier
		/// Type: FloatProperty
		/// Offset: 0x24C
		/// Size: 0x04
		/// </summary>
		public float VolumeMultiplier
		{
			get
			{
				return ReadSingle(0x24C);
			}
			set
			{
				WriteSingle(0x24C,value);
			}
		}
		
		/// <summary>
		/// Name: Priority
		/// Type: FloatProperty
		/// Offset: 0x250
		/// Size: 0x04
		/// </summary>
		public float Priority
		{
			get
			{
				return ReadSingle(0x250);
			}
			set
			{
				WriteSingle(0x250,value);
			}
		}
		
		/// <summary>
		/// Name: VolumeWeightedPriorityScale
		/// Type: FloatProperty
		/// Offset: 0x254
		/// Size: 0x04
		/// </summary>
		public float VolumeWeightedPriorityScale
		{
			get
			{
				return ReadSingle(0x254);
			}
			set
			{
				WriteSingle(0x254,value);
			}
		}
		
		/// <summary>
		/// Name: PitchMultiplier
		/// Type: FloatProperty
		/// Offset: 0x258
		/// Size: 0x04
		/// </summary>
		public float PitchMultiplier
		{
			get
			{
				return ReadSingle(0x258);
			}
			set
			{
				WriteSingle(0x258,value);
			}
		}
		
		/// <summary>
		/// Name: HighFrequencyGainMultiplier
		/// Type: FloatProperty
		/// Offset: 0x25C
		/// Size: 0x04
		/// </summary>
		public float HighFrequencyGainMultiplier
		{
			get
			{
				return ReadSingle(0x25C);
			}
			set
			{
				WriteSingle(0x25C,value);
			}
		}
		
		/// <summary>
		/// Name: LowPassFilterFrequency
		/// Type: FloatProperty
		/// Offset: 0x260
		/// Size: 0x04
		/// </summary>
		public float LowPassFilterFrequency
		{
			get
			{
				return ReadSingle(0x260);
			}
			set
			{
				WriteSingle(0x260,value);
			}
		}
		
		/// <summary>
		/// Name: AttenuationSettings
		/// Type: ObjectProperty
		/// Offset: 0x268
		/// Size: 0x08
		/// </summary>
		public USoundAttenuation AttenuationSettings => ReadUObject<USoundAttenuation>(0x268);
		
		/// <summary>
		/// Name: AttenuationOverrides
		/// Type: StructProperty
		/// Offset: 0x270
		/// Size: 0xF8
		/// </summary>
		public FAttenuationSettings AttenuationOverrides => ReadStruct<FAttenuationSettings>(0x270);
		
		/// <summary>
		/// Name: ConcurrencySettings
		/// Type: ObjectProperty
		/// Offset: 0x368
		/// Size: 0x08
		/// </summary>
		public USoundConcurrency ConcurrencySettings => ReadUObject<USoundConcurrency>(0x368);
		
		/// <summary>
		/// Name: OnQueueSubtitles
		/// Type: DelegateProperty
		/// Offset: 0x400
		/// Size: 0x10
		/// </summary>
		
	}


	/// <summary>
	/// UConanAudioComponent:UAudioComponent
	/// Size: 0x4E0
	/// Properties: 0
	/// </summary>
	public class UConanAudioComponent:UAudioComponent
	{
		public override int ObjectSize => 1248;
	}


	/// <summary>
	/// UBrainComponent:UActorComponent
	/// Size: 0x138
	/// Properties: 2
	/// </summary>
	public class UBrainComponent:UActorComponent
	{
		public override int ObjectSize => 312;
		/// <summary>
		/// Name: BlackboardComp
		/// Type: ObjectProperty
		/// Offset: 0xE0
		/// Size: 0x08
		/// </summary>
		public UBlackboardComponent BlackboardComp => ReadUObject<UBlackboardComponent>(0xE0);
		
		/// <summary>
		/// Name: AIOwner
		/// Type: ObjectProperty
		/// Offset: 0xE8
		/// Size: 0x08
		/// </summary>
		public AAIController AIOwner => ReadUObject<AAIController>(0xE8);
		
	}


	/// <summary>
	/// UBehaviorTreeComponent:UBrainComponent
	/// Size: 0x270
	/// Properties: 1
	/// </summary>
	public class UBehaviorTreeComponent:UBrainComponent
	{
		public override int ObjectSize => 624;
		/// <summary>
		/// Name: NodeInstances
		/// Type: TArray<UBTNode>
		/// Offset: 0x158
		/// Size: 0x10
		/// SubElement Size: 0x58
		/// </summary>
		public TArray<UBTNode> NodeInstances => new TArray<UBTNode>(BaseAddress+0x158);
		
	}


	/// <summary>
	/// UConanBehaviorTreeComponent:UBehaviorTreeComponent
	/// Size: 0x278
	/// Properties: 0
	/// </summary>
	public class UConanBehaviorTreeComponent:UBehaviorTreeComponent
	{
		public override int ObjectSize => 632;
	}


	/// <summary>
	/// UActorPersistenceComponent:UPersistenceComponent
	/// Size: 0x138
	/// Properties: 1
	/// </summary>
	public class UActorPersistenceComponent:UPersistenceComponent
	{
		public override int ObjectSize => 312;
		/// <summary>
		/// Name: m_bWasLoadedFromDB
		/// Type: BoolProperty
		/// Offset: 0x130
		/// Size: 0x01
		/// </summary>
		public bool m_bWasLoadedFromDB
		{
			get
			{
				return ReadBool(0x130);
			}
			set
			{
				WriteBool(0x130,value);
			}
		}
		
	}


	/// <summary>
	/// UConanBuildingPersistenceComponent:UActorPersistenceComponent
	/// Size: 0x148
	/// Properties: 0
	/// </summary>
	public class UConanBuildingPersistenceComponent:UActorPersistenceComponent
	{
		public override int ObjectSize => 328;
	}


	/// <summary>
	/// USettingsEventDispatchers:UObject
	/// Size: 0x38
	/// Properties: 0
	/// </summary>
	public class USettingsEventDispatchers:UObject
	{
		public override int ObjectSize => 56;
	}


	/// <summary>
	/// UUserSettingsLibrary:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UUserSettingsLibrary:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UPlayerControllerInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UPlayerControllerInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UGameItemInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UGameItemInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UGameItem:UObject
	/// Size: 0x360
	/// Properties: 24
	/// </summary>
	public class UGameItem:UObject
	{
		public override int ObjectSize => 864;
		/// <summary>
		/// Name: TypeID
		/// Type: ByteProperty
		/// Offset: 0x30
		/// Size: 0x01
		/// </summary>
		public byte TypeID
		{
			get
			{
				return ReadByte(0x30);
			}
			set
			{
				WriteByte(0x30,value);
			}
		}
		
		/// <summary>
		/// Name: GUICategory
		/// Type: ByteProperty
		/// Offset: 0x31
		/// Size: 0x01
		/// </summary>
		public byte GUICategory
		{
			get
			{
				return ReadByte(0x31);
			}
			set
			{
				WriteByte(0x31,value);
			}
		}
		
		/// <summary>
		/// Name: TemplateId
		/// Type: IntProperty
		/// Offset: 0x34
		/// Size: 0x04
		/// </summary>
		public int TemplateId
		{
			get
			{
				return ReadInt32(0x34);
			}
			set
			{
				WriteInt32(0x34,value);
			}
		}
		
		/// <summary>
		/// Name: Name
		/// Type: TextProperty
		/// Offset: 0x38
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: ShortDesc
		/// Type: TextProperty
		/// Offset: 0x50
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: LongDesc
		/// Type: TextProperty
		/// Offset: 0x68
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: VisualObject
		/// Type: AssetClassProperty
		/// Offset: 0xA0
		/// Size: 0x20
		/// </summary>
		
		/// <summary>
		/// Name: ActionBlueprint_Use
		/// Type: AssetClassProperty
		/// Offset: 0xC0
		/// Size: 0x20
		/// </summary>
		
		/// <summary>
		/// Name: SoundPhysicalSurface
		/// Type: ByteProperty
		/// Offset: 0xE0
		/// Size: 0x01
		/// </summary>
		public byte SoundPhysicalSurface
		{
			get
			{
				return ReadByte(0xE0);
			}
			set
			{
				WriteByte(0xE0,value);
			}
		}
		
		/// <summary>
		/// Name: WeaponArcheType
		/// Type: ByteProperty
		/// Offset: 0xE1
		/// Size: 0x01
		/// </summary>
		public byte WeaponArcheType
		{
			get
			{
				return ReadByte(0xE1);
			}
			set
			{
				WriteByte(0xE1,value);
			}
		}
		
		/// <summary>
		/// Name: FirstModifier
		/// Type: TextProperty
		/// Offset: 0xE8
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: SecondModifier
		/// Type: TextProperty
		/// Offset: 0x100
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: ThirdModifier
		/// Type: TextProperty
		/// Offset: 0x118
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: FourthModifier
		/// Type: TextProperty
		/// Offset: 0x130
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: ActualDestructibleMesh
		/// Type: ObjectProperty
		/// Offset: 0x148
		/// Size: 0x08
		/// </summary>
		public UDestructibleMesh ActualDestructibleMesh => ReadUObject<UDestructibleMesh>(0x148);
		
		/// <summary>
		/// Name: VisualActor
		/// Type: ObjectProperty
		/// Offset: 0x150
		/// Size: 0x08
		/// </summary>
		public AInventoryItemBase VisualActor => ReadUObject<AInventoryItemBase>(0x150);
		
		/// <summary>
		/// Name: OwnerActor
		/// Type: ObjectProperty
		/// Offset: 0x158
		/// Size: 0x08
		/// </summary>
		public AActor OwnerActor => ReadUObject<AActor>(0x158);
		
		/// <summary>
		/// Name: ItemFlags
		/// Type: IntProperty
		/// Offset: 0x240
		/// Size: 0x04
		/// </summary>
		public int ItemFlags
		{
			get
			{
				return ReadInt32(0x240);
			}
			set
			{
				WriteInt32(0x240,value);
			}
		}
		
		/// <summary>
		/// Name: CompatableAmmunitions
		/// Type: TArray<>
		/// Offset: 0x248
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: m_ActualIcon
		/// Type: ObjectProperty
		/// Offset: 0x268
		/// Size: 0x08
		/// </summary>
		public UTexture2D m_ActualIcon => ReadUObject<UTexture2D>(0x268);
		
		/// <summary>
		/// Name: m_BorderIcon
		/// Type: ObjectProperty
		/// Offset: 0x270
		/// Size: 0x08
		/// </summary>
		public UTexture2D m_BorderIcon => ReadUObject<UTexture2D>(0x270);
		
		/// <summary>
		/// Name: VisualObjectClass
		/// Type: ClassProperty
		/// Offset: 0x328
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: m_OwnerInventory
		/// Type: ObjectProperty
		/// Offset: 0x338
		/// Size: 0x08
		/// </summary>
		public UItemInventory m_OwnerInventory => ReadUObject<UItemInventory>(0x338);
		
		/// <summary>
		/// Name: m_IsEnabled
		/// Type: BoolProperty
		/// Offset: 0x340
		/// Size: 0x01
		/// </summary>
		public bool m_IsEnabled
		{
			get
			{
				return ReadBool(0x340);
			}
			set
			{
				WriteBool(0x340,value);
			}
		}
		
	}


	/// <summary>
	/// APlayerController:AController
	/// Size: 0x6C8
	/// Properties: 45
	/// </summary>
	public class APlayerController:AController
	{
		public override int ObjectSize => 1736;
		/// <summary>
		/// Name: Player
		/// Type: ObjectProperty
		/// Offset: 0x438
		/// Size: 0x08
		/// </summary>
		public UPlayer Player => ReadUObject<UPlayer>(0x438);
		
		/// <summary>
		/// Name: AcknowledgedPawn
		/// Type: ObjectProperty
		/// Offset: 0x448
		/// Size: 0x08
		/// </summary>
		public APawn AcknowledgedPawn => ReadUObject<APawn>(0x448);
		
		/// <summary>
		/// Name: ControllingDirTrackInst
		/// Type: ObjectProperty
		/// Offset: 0x450
		/// Size: 0x08
		/// </summary>
		public UInterpTrackInstDirector ControllingDirTrackInst => ReadUObject<UInterpTrackInstDirector>(0x450);
		
		/// <summary>
		/// Name: MyHUD
		/// Type: ObjectProperty
		/// Offset: 0x460
		/// Size: 0x08
		/// </summary>
		public AHUD MyHUD => ReadUObject<AHUD>(0x460);
		
		/// <summary>
		/// Name: PlayerCameraManager
		/// Type: ObjectProperty
		/// Offset: 0x468
		/// Size: 0x08
		/// </summary>
		public APlayerCameraManager PlayerCameraManager => ReadUObject<APlayerCameraManager>(0x468);
		
		/// <summary>
		/// Name: PlayerCameraManagerClass
		/// Type: ClassProperty
		/// Offset: 0x470
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: bAutoManageActiveCameraTarget
		/// Type: BoolProperty
		/// Offset: 0x478
		/// Size: 0x01
		/// </summary>
		public bool bAutoManageActiveCameraTarget
		{
			get
			{
				return ReadBool(0x478);
			}
			set
			{
				WriteBool(0x478,value);
			}
		}
		
		/// <summary>
		/// Name: TargetViewRotation
		/// Type: StructProperty
		/// Offset: 0x47C
		/// Size: 0x0C
		/// </summary>
		public FRotator TargetViewRotation => ReadStruct<FRotator>(0x47C);
		
		/// <summary>
		/// Name: SmoothTargetViewRotationSpeed
		/// Type: FloatProperty
		/// Offset: 0x494
		/// Size: 0x04
		/// </summary>
		public float SmoothTargetViewRotationSpeed
		{
			get
			{
				return ReadSingle(0x494);
			}
			set
			{
				WriteSingle(0x494,value);
			}
		}
		
		/// <summary>
		/// Name: HiddenActors
		/// Type: TArray<AActor>
		/// Offset: 0x498
		/// Size: 0x10
		/// SubElement Size: 0x3D0
		/// </summary>
		public TArray<AActor> HiddenActors => new TArray<AActor>(BaseAddress+0x498);
		
		/// <summary>
		/// Name: LastSpectatorStateSynchTime
		/// Type: FloatProperty
		/// Offset: 0x4A8
		/// Size: 0x04
		/// </summary>
		public float LastSpectatorStateSynchTime
		{
			get
			{
				return ReadSingle(0x4A8);
			}
			set
			{
				WriteSingle(0x4A8,value);
			}
		}
		
		/// <summary>
		/// Name: LastSpectatorSyncLocation
		/// Type: StructProperty
		/// Offset: 0x4AC
		/// Size: 0x0C
		/// </summary>
		public FVector LastSpectatorSyncLocation => ReadStruct<FVector>(0x4AC);
		
		/// <summary>
		/// Name: LastSpectatorSyncRotation
		/// Type: StructProperty
		/// Offset: 0x4B8
		/// Size: 0x0C
		/// </summary>
		public FRotator LastSpectatorSyncRotation => ReadStruct<FRotator>(0x4B8);
		
		/// <summary>
		/// Name: ClientCap
		/// Type: IntProperty
		/// Offset: 0x4C4
		/// Size: 0x04
		/// </summary>
		public int ClientCap
		{
			get
			{
				return ReadInt32(0x4C4);
			}
			set
			{
				WriteInt32(0x4C4,value);
			}
		}
		
		/// <summary>
		/// Name: CheatManager
		/// Type: ObjectProperty
		/// Offset: 0x4C8
		/// Size: 0x08
		/// </summary>
		public UCheatManager CheatManager => ReadUObject<UCheatManager>(0x4C8);
		
		/// <summary>
		/// Name: CheatClass
		/// Type: ClassProperty
		/// Offset: 0x4D0
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: PlayerInput
		/// Type: ObjectProperty
		/// Offset: 0x4D8
		/// Size: 0x08
		/// </summary>
		public UPlayerInput PlayerInput => ReadUObject<UPlayerInput>(0x4D8);
		
		/// <summary>
		/// Name: ActiveForceFeedbackEffects
		/// Type: TArray<FActiveForceFeedbackEffect>
		/// Offset: 0x4E0
		/// Size: 0x10
		/// SubElement Size: 0x18
		/// </summary>
		public TArray<FActiveForceFeedbackEffect> ActiveForceFeedbackEffects => new TArray<FActiveForceFeedbackEffect>(BaseAddress+0x4E0);
		
		/// <summary>
		/// Name: bPlayerIsWaiting
		/// Type: BoolProperty
		/// Offset: 0x570
		/// Size: 0x01
		/// </summary>
		public bool bPlayerIsWaiting => (ReadByte(0x0570) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: NetPlayerIndex
		/// Type: ByteProperty
		/// Offset: 0x574
		/// Size: 0x01
		/// </summary>
		public byte NetPlayerIndex
		{
			get
			{
				return ReadByte(0x574);
			}
			set
			{
				WriteByte(0x574,value);
			}
		}
		
		/// <summary>
		/// Name: PendingSwapConnection
		/// Type: ObjectProperty
		/// Offset: 0x578
		/// Size: 0x08
		/// </summary>
		public UNetConnection PendingSwapConnection => ReadUObject<UNetConnection>(0x578);
		
		/// <summary>
		/// Name: NetConnection
		/// Type: ObjectProperty
		/// Offset: 0x580
		/// Size: 0x08
		/// </summary>
		public UNetConnection NetConnection => ReadUObject<UNetConnection>(0x580);
		
		/// <summary>
		/// Name: InputYawScale
		/// Type: FloatProperty
		/// Offset: 0x594
		/// Size: 0x04
		/// </summary>
		public float InputYawScale
		{
			get
			{
				return ReadSingle(0x594);
			}
			set
			{
				WriteSingle(0x594,value);
			}
		}
		
		/// <summary>
		/// Name: InputPitchScale
		/// Type: FloatProperty
		/// Offset: 0x598
		/// Size: 0x04
		/// </summary>
		public float InputPitchScale
		{
			get
			{
				return ReadSingle(0x598);
			}
			set
			{
				WriteSingle(0x598,value);
			}
		}
		
		/// <summary>
		/// Name: InputRollScale
		/// Type: FloatProperty
		/// Offset: 0x59C
		/// Size: 0x04
		/// </summary>
		public float InputRollScale
		{
			get
			{
				return ReadSingle(0x59C);
			}
			set
			{
				WriteSingle(0x59C,value);
			}
		}
		
		/// <summary>
		/// Name: bShowMouseCursor
		/// Type: BoolProperty
		/// Offset: 0x5A0
		/// Size: 0x01
		/// </summary>
		public bool bShowMouseCursor => (ReadByte(0x05A0) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bEnableClickEvents
		/// Type: BoolProperty
		/// Offset: 0x5A0
		/// Size: 0x01
		/// </summary>
		public bool bEnableClickEvents => (ReadByte(0x05A0) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bEnableTouchEvents
		/// Type: BoolProperty
		/// Offset: 0x5A0
		/// Size: 0x01
		/// </summary>
		public bool bEnableTouchEvents => (ReadByte(0x05A0) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bEnableMouseOverEvents
		/// Type: BoolProperty
		/// Offset: 0x5A0
		/// Size: 0x01
		/// </summary>
		public bool bEnableMouseOverEvents => (ReadByte(0x05A0) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bEnableTouchOverEvents
		/// Type: BoolProperty
		/// Offset: 0x5A0
		/// Size: 0x01
		/// </summary>
		public bool bEnableTouchOverEvents => (ReadByte(0x05A0) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bForceFeedbackEnabled
		/// Type: BoolProperty
		/// Offset: 0x5A0
		/// Size: 0x01
		/// </summary>
		public bool bForceFeedbackEnabled => (ReadByte(0x05A0) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: bKeepPawnAliveOnControllerDeath
		/// Type: BoolProperty
		/// Offset: 0x5A0
		/// Size: 0x01
		/// </summary>
		public bool bKeepPawnAliveOnControllerDeath => (ReadByte(0x05A0) & 0x40) == 0x40;
		
		/// <summary>
		/// Name: ClickEventKeys
		/// Type: TArray<FKey>
		/// Offset: 0x5A8
		/// Size: 0x10
		/// SubElement Size: 0x18
		/// </summary>
		public TArray<FKey> ClickEventKeys => new TArray<FKey>(BaseAddress+0x5A8);
		
		/// <summary>
		/// Name: DefaultMouseCursor
		/// Type: ByteProperty
		/// Offset: 0x5B8
		/// Size: 0x01
		/// </summary>
		public byte DefaultMouseCursor
		{
			get
			{
				return ReadByte(0x5B8);
			}
			set
			{
				WriteByte(0x5B8,value);
			}
		}
		
		/// <summary>
		/// Name: CurrentMouseCursor
		/// Type: ByteProperty
		/// Offset: 0x5B9
		/// Size: 0x01
		/// </summary>
		public byte CurrentMouseCursor
		{
			get
			{
				return ReadByte(0x5B9);
			}
			set
			{
				WriteByte(0x5B9,value);
			}
		}
		
		/// <summary>
		/// Name: DefaultClickTraceChannel
		/// Type: ByteProperty
		/// Offset: 0x5BA
		/// Size: 0x01
		/// </summary>
		public byte DefaultClickTraceChannel
		{
			get
			{
				return ReadByte(0x5BA);
			}
			set
			{
				WriteByte(0x5BA,value);
			}
		}
		
		/// <summary>
		/// Name: CurrentClickTraceChannel
		/// Type: ByteProperty
		/// Offset: 0x5BB
		/// Size: 0x01
		/// </summary>
		public byte CurrentClickTraceChannel
		{
			get
			{
				return ReadByte(0x5BB);
			}
			set
			{
				WriteByte(0x5BB,value);
			}
		}
		
		/// <summary>
		/// Name: HitResultTraceDistance
		/// Type: FloatProperty
		/// Offset: 0x5BC
		/// Size: 0x04
		/// </summary>
		public float HitResultTraceDistance
		{
			get
			{
				return ReadSingle(0x5BC);
			}
			set
			{
				WriteSingle(0x5BC,value);
			}
		}
		
		/// <summary>
		/// Name: InactiveStateInputComponent
		/// Type: ObjectProperty
		/// Offset: 0x640
		/// Size: 0x08
		/// </summary>
		public UInputComponent InactiveStateInputComponent => ReadUObject<UInputComponent>(0x640);
		
		/// <summary>
		/// Name: CurrentTouchInterface
		/// Type: ObjectProperty
		/// Offset: 0x660
		/// Size: 0x08
		/// </summary>
		public UTouchInterface CurrentTouchInterface => ReadUObject<UTouchInterface>(0x660);
		
		/// <summary>
		/// Name: SpectatorPawn
		/// Type: ObjectProperty
		/// Offset: 0x6A8
		/// Size: 0x08
		/// </summary>
		public ASpectatorPawn SpectatorPawn => ReadUObject<ASpectatorPawn>(0x6A8);
		
		/// <summary>
		/// Name: SpawnLocation
		/// Type: StructProperty
		/// Offset: 0x6B0
		/// Size: 0x0C
		/// </summary>
		public FVector SpawnLocation => ReadStruct<FVector>(0x6B0);
		
		/// <summary>
		/// Name: bIsLocalPlayerController
		/// Type: BoolProperty
		/// Offset: 0x6C0
		/// Size: 0x01
		/// </summary>
		public bool bIsLocalPlayerController
		{
			get
			{
				return ReadBool(0x6C0);
			}
			set
			{
				WriteBool(0x6C0,value);
			}
		}
		
		/// <summary>
		/// Name: SeamlessTravelCount
		/// Type: UInt16Property
		/// Offset: 0x6C2
		/// Size: 0x02
		/// </summary>
		public ushort SeamlessTravelCount
		{
			get
			{
				return ReadUInt16(0x6C2);
			}
			set
			{
				WriteUInt16(0x6C2,value);
			}
		}
		
		/// <summary>
		/// Name: LastCompletedSeamlessTravelCount
		/// Type: UInt16Property
		/// Offset: 0x6C4
		/// Size: 0x02
		/// </summary>
		public ushort LastCompletedSeamlessTravelCount
		{
			get
			{
				return ReadUInt16(0x6C4);
			}
			set
			{
				WriteUInt16(0x6C4,value);
			}
		}
		
	}


	/// <summary>
	/// AConanPlayerController:APlayerController
	/// Size: 0x870
	/// Properties: 9
	/// </summary>
	public class AConanPlayerController:APlayerController
	{
		public override int ObjectSize => 2160;
		/// <summary>
		/// Name: OverridenStreamingLocations
		/// Type: TArray<FVector>
		/// Offset: 0x6E0
		/// Size: 0x10
		/// SubElement Size: 0x0C
		/// </summary>
		public TArray<FVector> OverridenStreamingLocations => new TArray<FVector>(BaseAddress+0x6E0);
		
		/// <summary>
		/// Name: m_OwnedCameraComponents
		/// Type: TArray<UCameraComponent>
		/// Offset: 0x770
		/// Size: 0x10
		/// SubElement Size: 0x640
		/// </summary>
		public TArray<UCameraComponent> m_OwnedCameraComponents => new TArray<UCameraComponent>(BaseAddress+0x770);
		
		/// <summary>
		/// Name: InitialPlayerStart
		/// Type: ObjectProperty
		/// Offset: 0x780
		/// Size: 0x08
		/// </summary>
		public APlayerStart InitialPlayerStart => ReadUObject<APlayerStart>(0x780);
		
		/// <summary>
		/// Name: UserIDFromURLOptions
		/// Type: StrProperty
		/// Offset: 0x788
		/// Size: 0x10
		/// </summary>
		public FString UserIDFromURLOptions => new FString(BaseAddress+0x788);
		
		/// <summary>
		/// Name: NetConnectionLostTimeout
		/// Type: FloatProperty
		/// Offset: 0x7A8
		/// Size: 0x04
		/// </summary>
		public float NetConnectionLostTimeout
		{
			get
			{
				return ReadSingle(0x7A8);
			}
			set
			{
				WriteSingle(0x7A8,value);
			}
		}
		
		/// <summary>
		/// Name: ConanCheatManager
		/// Type: ObjectProperty
		/// Offset: 0x7C0
		/// Size: 0x08
		/// </summary>
		public UConanCheatManager ConanCheatManager => ReadUObject<UConanCheatManager>(0x7C0);
		
		/// <summary>
		/// Name: m_PendingInventoryRequests
		/// Type: TArray<FPendingInventoryUpdate>
		/// Offset: 0x7C8
		/// Size: 0x10
		/// SubElement Size: 0x20
		/// </summary>
		public TArray<FPendingInventoryUpdate> m_PendingInventoryRequests => new TArray<FPendingInventoryUpdate>(BaseAddress+0x7C8);
		
		/// <summary>
		/// Name: m_bShowDebugText
		/// Type: BoolProperty
		/// Offset: 0x7D8
		/// Size: 0x01
		/// </summary>
		public bool m_bShowDebugText
		{
			get
			{
				return ReadBool(0x7D8);
			}
			set
			{
				WriteBool(0x7D8,value);
			}
		}
		
		/// <summary>
		/// Name: m_IsAdmin
		/// Type: BoolProperty
		/// Offset: 0x7D9
		/// Size: 0x01
		/// </summary>
		public bool m_IsAdmin
		{
			get
			{
				return ReadBool(0x7D9);
			}
			set
			{
				WriteBool(0x7D9,value);
			}
		}
		
	}


	/// <summary>
	/// AGameSession:AInfo
	/// Size: 0x400
	/// Properties: 6
	/// </summary>
	public class AGameSession:AInfo
	{
		public override int ObjectSize => 1024;
		/// <summary>
		/// Name: MaxSpectators
		/// Type: IntProperty
		/// Offset: 0x3D0
		/// Size: 0x04
		/// </summary>
		public int MaxSpectators
		{
			get
			{
				return ReadInt32(0x3D0);
			}
			set
			{
				WriteInt32(0x3D0,value);
			}
		}
		
		/// <summary>
		/// Name: MaxPlayers
		/// Type: IntProperty
		/// Offset: 0x3D4
		/// Size: 0x04
		/// </summary>
		public int MaxPlayers
		{
			get
			{
				return ReadInt32(0x3D4);
			}
			set
			{
				WriteInt32(0x3D4,value);
			}
		}
		
		/// <summary>
		/// Name: MaxPartySize
		/// Type: IntProperty
		/// Offset: 0x3D8
		/// Size: 0x04
		/// </summary>
		public int MaxPartySize
		{
			get
			{
				return ReadInt32(0x3D8);
			}
			set
			{
				WriteInt32(0x3D8,value);
			}
		}
		
		/// <summary>
		/// Name: MaxSplitscreensPerConnection
		/// Type: ByteProperty
		/// Offset: 0x3DC
		/// Size: 0x01
		/// </summary>
		public byte MaxSplitscreensPerConnection
		{
			get
			{
				return ReadByte(0x3DC);
			}
			set
			{
				WriteByte(0x3DC,value);
			}
		}
		
		/// <summary>
		/// Name: bRequiresPushToTalk
		/// Type: BoolProperty
		/// Offset: 0x3DD
		/// Size: 0x01
		/// </summary>
		public bool bRequiresPushToTalk
		{
			get
			{
				return ReadBool(0x3DD);
			}
			set
			{
				WriteBool(0x3DD,value);
			}
		}
		
		/// <summary>
		/// Name: SessionName
		/// Type: NameProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// AConanGameSession:AGameSession
	/// Size: 0x400
	/// Properties: 0
	/// </summary>
	public class AConanGameSession:AGameSession
	{
		public override int ObjectSize => 1024;
	}


	/// <summary>
	/// AServerSettings:AInfo
	/// Size: 0x568
	/// Properties: 83
	/// </summary>
	public class AServerSettings:AInfo
	{
		public override int ObjectSize => 1384;
		/// <summary>
		/// Name: BlueprintConfigVersion
		/// Type: IntProperty
		/// Offset: 0x3D0
		/// Size: 0x04
		/// </summary>
		public int BlueprintConfigVersion
		{
			get
			{
				return ReadInt32(0x3D0);
			}
			set
			{
				WriteInt32(0x3D0,value);
			}
		}
		
		/// <summary>
		/// Name: ConfigVersion
		/// Type: IntProperty
		/// Offset: 0x3D4
		/// Size: 0x04
		/// </summary>
		public int ConfigVersion
		{
			get
			{
				return ReadInt32(0x3D4);
			}
			set
			{
				WriteInt32(0x3D4,value);
			}
		}
		
		/// <summary>
		/// Name: serverRegion
		/// Type: ByteProperty
		/// Offset: 0x3D8
		/// Size: 0x01
		/// </summary>
		public byte serverRegion
		{
			get
			{
				return ReadByte(0x3D8);
			}
			set
			{
				WriteByte(0x3D8,value);
			}
		}
		
		/// <summary>
		/// Name: PVPEnabled
		/// Type: BoolProperty
		/// Offset: 0x3D9
		/// Size: 0x01
		/// </summary>
		public bool PVPEnabled
		{
			get
			{
				return ReadBool(0x3D9);
			}
			set
			{
				WriteBool(0x3D9,value);
			}
		}
		
		/// <summary>
		/// Name: RestrictPVPTime
		/// Type: BoolProperty
		/// Offset: 0x3DA
		/// Size: 0x01
		/// </summary>
		public bool RestrictPVPTime
		{
			get
			{
				return ReadBool(0x3DA);
			}
			set
			{
				WriteBool(0x3DA,value);
			}
		}
		
		/// <summary>
		/// Name: PVPTimeWeekdayStart
		/// Type: IntProperty
		/// Offset: 0x3DC
		/// Size: 0x04
		/// </summary>
		public int PVPTimeWeekdayStart
		{
			get
			{
				return ReadInt32(0x3DC);
			}
			set
			{
				WriteInt32(0x3DC,value);
			}
		}
		
		/// <summary>
		/// Name: PVPTimeWeekdayEnd
		/// Type: IntProperty
		/// Offset: 0x3E0
		/// Size: 0x04
		/// </summary>
		public int PVPTimeWeekdayEnd
		{
			get
			{
				return ReadInt32(0x3E0);
			}
			set
			{
				WriteInt32(0x3E0,value);
			}
		}
		
		/// <summary>
		/// Name: PVPTimeWeekendStart
		/// Type: IntProperty
		/// Offset: 0x3E4
		/// Size: 0x04
		/// </summary>
		public int PVPTimeWeekendStart
		{
			get
			{
				return ReadInt32(0x3E4);
			}
			set
			{
				WriteInt32(0x3E4,value);
			}
		}
		
		/// <summary>
		/// Name: PVPTimeWeekendEnd
		/// Type: IntProperty
		/// Offset: 0x3E8
		/// Size: 0x04
		/// </summary>
		public int PVPTimeWeekendEnd
		{
			get
			{
				return ReadInt32(0x3E8);
			}
			set
			{
				WriteInt32(0x3E8,value);
			}
		}
		
		/// <summary>
		/// Name: RestrictPVPBuildingDamageTime
		/// Type: BoolProperty
		/// Offset: 0x3EC
		/// Size: 0x01
		/// </summary>
		public bool RestrictPVPBuildingDamageTime
		{
			get
			{
				return ReadBool(0x3EC);
			}
			set
			{
				WriteBool(0x3EC,value);
			}
		}
		
		/// <summary>
		/// Name: PVPBuildingDamageTimeWeekdayStart
		/// Type: IntProperty
		/// Offset: 0x3F0
		/// Size: 0x04
		/// </summary>
		public int PVPBuildingDamageTimeWeekdayStart
		{
			get
			{
				return ReadInt32(0x3F0);
			}
			set
			{
				WriteInt32(0x3F0,value);
			}
		}
		
		/// <summary>
		/// Name: PVPBuildingDamageTimeWeekdayEnd
		/// Type: IntProperty
		/// Offset: 0x3F4
		/// Size: 0x04
		/// </summary>
		public int PVPBuildingDamageTimeWeekdayEnd
		{
			get
			{
				return ReadInt32(0x3F4);
			}
			set
			{
				WriteInt32(0x3F4,value);
			}
		}
		
		/// <summary>
		/// Name: PVPBuildingDamageTimeWeekendStart
		/// Type: IntProperty
		/// Offset: 0x3F8
		/// Size: 0x04
		/// </summary>
		public int PVPBuildingDamageTimeWeekendStart
		{
			get
			{
				return ReadInt32(0x3F8);
			}
			set
			{
				WriteInt32(0x3F8,value);
			}
		}
		
		/// <summary>
		/// Name: PVPBuildingDamageTimeWeekendEnd
		/// Type: IntProperty
		/// Offset: 0x3FC
		/// Size: 0x04
		/// </summary>
		public int PVPBuildingDamageTimeWeekendEnd
		{
			get
			{
				return ReadInt32(0x3FC);
			}
			set
			{
				WriteInt32(0x3FC,value);
			}
		}
		
		/// <summary>
		/// Name: PVPBlitzServer
		/// Type: BoolProperty
		/// Offset: 0x400
		/// Size: 0x01
		/// </summary>
		public bool PVPBlitzServer
		{
			get
			{
				return ReadBool(0x400);
			}
			set
			{
				WriteBool(0x400,value);
			}
		}
		
		/// <summary>
		/// Name: NoOwnership
		/// Type: BoolProperty
		/// Offset: 0x401
		/// Size: 0x01
		/// </summary>
		public bool NoOwnership
		{
			get
			{
				return ReadBool(0x401);
			}
			set
			{
				WriteBool(0x401,value);
			}
		}
		
		/// <summary>
		/// Name: LandClaimRadiusMultiplier
		/// Type: FloatProperty
		/// Offset: 0x404
		/// Size: 0x04
		/// </summary>
		public float LandClaimRadiusMultiplier
		{
			get
			{
				return ReadSingle(0x404);
			}
			set
			{
				WriteSingle(0x404,value);
			}
		}
		
		/// <summary>
		/// Name: CanDamagePlayerOwnedStructures
		/// Type: BoolProperty
		/// Offset: 0x408
		/// Size: 0x01
		/// </summary>
		public bool CanDamagePlayerOwnedStructures
		{
			get
			{
				return ReadBool(0x408);
			}
			set
			{
				WriteBool(0x408,value);
			}
		}
		
		/// <summary>
		/// Name: AdminPassword
		/// Type: StrProperty
		/// Offset: 0x410
		/// Size: 0x10
		/// </summary>
		public FString AdminPassword => new FString(BaseAddress+0x410);
		
		/// <summary>
		/// Name: BuildingRadialDestructionForceMultiplier
		/// Type: FloatProperty
		/// Offset: 0x420
		/// Size: 0x04
		/// </summary>
		public float BuildingRadialDestructionForceMultiplier
		{
			get
			{
				return ReadSingle(0x420);
			}
			set
			{
				WriteSingle(0x420,value);
			}
		}
		
		/// <summary>
		/// Name: LogoutCharactersRemainInTheWorld
		/// Type: BoolProperty
		/// Offset: 0x424
		/// Size: 0x01
		/// </summary>
		public bool LogoutCharactersRemainInTheWorld
		{
			get
			{
				return ReadBool(0x424);
			}
			set
			{
				WriteBool(0x424,value);
			}
		}
		
		/// <summary>
		/// Name: DurabilityMultiplier
		/// Type: FloatProperty
		/// Offset: 0x428
		/// Size: 0x04
		/// </summary>
		public float DurabilityMultiplier
		{
			get
			{
				return ReadSingle(0x428);
			}
			set
			{
				WriteSingle(0x428,value);
			}
		}
		
		/// <summary>
		/// Name: DropEquipmentOnDeath
		/// Type: BoolProperty
		/// Offset: 0x42C
		/// Size: 0x01
		/// </summary>
		public bool DropEquipmentOnDeath
		{
			get
			{
				return ReadBool(0x42C);
			}
			set
			{
				WriteBool(0x42C,value);
			}
		}
		
		/// <summary>
		/// Name: EverybodyCanLootCorpse
		/// Type: BoolProperty
		/// Offset: 0x42D
		/// Size: 0x01
		/// </summary>
		public bool EverybodyCanLootCorpse
		{
			get
			{
				return ReadBool(0x42D);
			}
			set
			{
				WriteBool(0x42D,value);
			}
		}
		
		/// <summary>
		/// Name: ItemConvertionMultiplier
		/// Type: FloatProperty
		/// Offset: 0x430
		/// Size: 0x04
		/// </summary>
		public float ItemConvertionMultiplier
		{
			get
			{
				return ReadSingle(0x430);
			}
			set
			{
				WriteSingle(0x430,value);
			}
		}
		
		/// <summary>
		/// Name: DayCycleSpeedScale
		/// Type: FloatProperty
		/// Offset: 0x434
		/// Size: 0x04
		/// </summary>
		public float DayCycleSpeedScale
		{
			get
			{
				return ReadSingle(0x434);
			}
			set
			{
				WriteSingle(0x434,value);
			}
		}
		
		/// <summary>
		/// Name: DayTimeSpeedScale
		/// Type: FloatProperty
		/// Offset: 0x438
		/// Size: 0x04
		/// </summary>
		public float DayTimeSpeedScale
		{
			get
			{
				return ReadSingle(0x438);
			}
			set
			{
				WriteSingle(0x438,value);
			}
		}
		
		/// <summary>
		/// Name: NightTimeSpeedScale
		/// Type: FloatProperty
		/// Offset: 0x43C
		/// Size: 0x04
		/// </summary>
		public float NightTimeSpeedScale
		{
			get
			{
				return ReadSingle(0x43C);
			}
			set
			{
				WriteSingle(0x43C,value);
			}
		}
		
		/// <summary>
		/// Name: DawnDuskSpeedScale
		/// Type: FloatProperty
		/// Offset: 0x440
		/// Size: 0x04
		/// </summary>
		public float DawnDuskSpeedScale
		{
			get
			{
				return ReadSingle(0x440);
			}
			set
			{
				WriteSingle(0x440,value);
			}
		}
		
		/// <summary>
		/// Name: ClientCatchUpTime
		/// Type: FloatProperty
		/// Offset: 0x444
		/// Size: 0x04
		/// </summary>
		public float ClientCatchUpTime
		{
			get
			{
				return ReadSingle(0x444);
			}
			set
			{
				WriteSingle(0x444,value);
			}
		}
		
		/// <summary>
		/// Name: UseClientCatchUpTime
		/// Type: BoolProperty
		/// Offset: 0x448
		/// Size: 0x01
		/// </summary>
		public bool UseClientCatchUpTime
		{
			get
			{
				return ReadBool(0x448);
			}
			set
			{
				WriteBool(0x448,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerHealthMultiplier
		/// Type: FloatProperty
		/// Offset: 0x44C
		/// Size: 0x04
		/// </summary>
		public float PlayerHealthMultiplier
		{
			get
			{
				return ReadSingle(0x44C);
			}
			set
			{
				WriteSingle(0x44C,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerStaminaMultiplier
		/// Type: FloatProperty
		/// Offset: 0x450
		/// Size: 0x04
		/// </summary>
		public float PlayerStaminaMultiplier
		{
			get
			{
				return ReadSingle(0x450);
			}
			set
			{
				WriteSingle(0x450,value);
			}
		}
		
		/// <summary>
		/// Name: StaminaCostMultiplier
		/// Type: FloatProperty
		/// Offset: 0x454
		/// Size: 0x04
		/// </summary>
		public float StaminaCostMultiplier
		{
			get
			{
				return ReadSingle(0x454);
			}
			set
			{
				WriteSingle(0x454,value);
			}
		}
		
		/// <summary>
		/// Name: ItemSpoilRateScale
		/// Type: FloatProperty
		/// Offset: 0x458
		/// Size: 0x04
		/// </summary>
		public float ItemSpoilRateScale
		{
			get
			{
				return ReadSingle(0x458);
			}
			set
			{
				WriteSingle(0x458,value);
			}
		}
		
		/// <summary>
		/// Name: HarvestAmountMultiplier
		/// Type: FloatProperty
		/// Offset: 0x45C
		/// Size: 0x04
		/// </summary>
		public float HarvestAmountMultiplier
		{
			get
			{
				return ReadSingle(0x45C);
			}
			set
			{
				WriteSingle(0x45C,value);
			}
		}
		
		/// <summary>
		/// Name: ResourceRespawnSpeedMultiplier
		/// Type: FloatProperty
		/// Offset: 0x460
		/// Size: 0x04
		/// </summary>
		public float ResourceRespawnSpeedMultiplier
		{
			get
			{
				return ReadSingle(0x460);
			}
			set
			{
				WriteSingle(0x460,value);
			}
		}
		
		/// <summary>
		/// Name: NPCMindReadingMode
		/// Type: ByteProperty
		/// Offset: 0x464
		/// Size: 0x01
		/// </summary>
		public byte NPCMindReadingMode
		{
			get
			{
				return ReadByte(0x464);
			}
			set
			{
				WriteByte(0x464,value);
			}
		}
		
		/// <summary>
		/// Name: PathFollowingSendsAngularVelocity
		/// Type: BoolProperty
		/// Offset: 0x465
		/// Size: 0x01
		/// </summary>
		public bool PathFollowingSendsAngularVelocity
		{
			get
			{
				return ReadBool(0x465);
			}
			set
			{
				WriteBool(0x465,value);
			}
		}
		
		/// <summary>
		/// Name: UnconsciousTimeSeconds
		/// Type: FloatProperty
		/// Offset: 0x468
		/// Size: 0x04
		/// </summary>
		public float UnconsciousTimeSeconds
		{
			get
			{
				return ReadSingle(0x468);
			}
			set
			{
				WriteSingle(0x468,value);
			}
		}
		
		/// <summary>
		/// Name: ConciousnessDamageMultiplier
		/// Type: FloatProperty
		/// Offset: 0x46C
		/// Size: 0x04
		/// </summary>
		public float ConciousnessDamageMultiplier
		{
			get
			{
				return ReadSingle(0x46C);
			}
			set
			{
				WriteSingle(0x46C,value);
			}
		}
		
		/// <summary>
		/// Name: BuildingDecayTimePerScore
		/// Type: FloatProperty
		/// Offset: 0x470
		/// Size: 0x04
		/// </summary>
		public float BuildingDecayTimePerScore
		{
			get
			{
				return ReadSingle(0x470);
			}
			set
			{
				WriteSingle(0x470,value);
			}
		}
		
		/// <summary>
		/// Name: MaxBuildingDecayTime
		/// Type: FloatProperty
		/// Offset: 0x474
		/// Size: 0x04
		/// </summary>
		public float MaxBuildingDecayTime
		{
			get
			{
				return ReadSingle(0x474);
			}
			set
			{
				WriteSingle(0x474,value);
			}
		}
		
		/// <summary>
		/// Name: BuildingDecayRateModifier
		/// Type: FloatProperty
		/// Offset: 0x478
		/// Size: 0x04
		/// </summary>
		public float BuildingDecayRateModifier
		{
			get
			{
				return ReadSingle(0x478);
			}
			set
			{
				WriteSingle(0x478,value);
			}
		}
		
		/// <summary>
		/// Name: DecayCleanupTimeMultiplier
		/// Type: FloatProperty
		/// Offset: 0x47C
		/// Size: 0x04
		/// </summary>
		public float DecayCleanupTimeMultiplier
		{
			get
			{
				return ReadSingle(0x47C);
			}
			set
			{
				WriteSingle(0x47C,value);
			}
		}
		
		/// <summary>
		/// Name: MaxDecayTimeToAutoDemolish
		/// Type: FloatProperty
		/// Offset: 0x480
		/// Size: 0x04
		/// </summary>
		public float MaxDecayTimeToAutoDemolish
		{
			get
			{
				return ReadSingle(0x480);
			}
			set
			{
				WriteSingle(0x480,value);
			}
		}
		
		/// <summary>
		/// Name: ValidatePhysNavWalkWithRaycast
		/// Type: BoolProperty
		/// Offset: 0x484
		/// Size: 0x01
		/// </summary>
		public bool ValidatePhysNavWalkWithRaycast
		{
			get
			{
				return ReadBool(0x484);
			}
			set
			{
				WriteBool(0x484,value);
			}
		}
		
		/// <summary>
		/// Name: LocalNavMeshVisualizationFrequency
		/// Type: FloatProperty
		/// Offset: 0x488
		/// Size: 0x04
		/// </summary>
		public float LocalNavMeshVisualizationFrequency
		{
			get
			{
				return ReadSingle(0x488);
			}
			set
			{
				WriteSingle(0x488,value);
			}
		}
		
		/// <summary>
		/// Name: UseLocalQuadraticAngularVelocityPrediction
		/// Type: BoolProperty
		/// Offset: 0x48C
		/// Size: 0x01
		/// </summary>
		public bool UseLocalQuadraticAngularVelocityPrediction
		{
			get
			{
				return ReadBool(0x48C);
			}
			set
			{
				WriteBool(0x48C,value);
			}
		}
		
		/// <summary>
		/// Name: LQAVPUseTime
		/// Type: FloatProperty
		/// Offset: 0x490
		/// Size: 0x04
		/// </summary>
		public float LQAVPUseTime
		{
			get
			{
				return ReadSingle(0x490);
			}
			set
			{
				WriteSingle(0x490,value);
			}
		}
		
		/// <summary>
		/// Name: LQAVPFadeTime
		/// Type: FloatProperty
		/// Offset: 0x494
		/// Size: 0x04
		/// </summary>
		public float LQAVPFadeTime
		{
			get
			{
				return ReadSingle(0x494);
			}
			set
			{
				WriteSingle(0x494,value);
			}
		}
		
		/// <summary>
		/// Name: LQAVPMethod
		/// Type: ByteProperty
		/// Offset: 0x498
		/// Size: 0x01
		/// </summary>
		public byte LQAVPMethod
		{
			get
			{
				return ReadByte(0x498);
			}
			set
			{
				WriteByte(0x498,value);
			}
		}
		
		/// <summary>
		/// Name: NetworkSimulatedSmoothRotationTimeWithLQAVP
		/// Type: FloatProperty
		/// Offset: 0x49C
		/// Size: 0x04
		/// </summary>
		public float NetworkSimulatedSmoothRotationTimeWithLQAVP
		{
			get
			{
				return ReadSingle(0x49C);
			}
			set
			{
				WriteSingle(0x49C,value);
			}
		}
		
		/// <summary>
		/// Name: MaxNudity
		/// Type: ByteProperty
		/// Offset: 0x4A0
		/// Size: 0x01
		/// </summary>
		public byte MaxNudity
		{
			get
			{
				return ReadByte(0x4A0);
			}
			set
			{
				WriteByte(0x4A0,value);
			}
		}
		
		/// <summary>
		/// Name: ServerCommunity
		/// Type: ByteProperty
		/// Offset: 0x4A1
		/// Size: 0x01
		/// </summary>
		public byte ServerCommunity
		{
			get
			{
				return ReadByte(0x4A1);
			}
			set
			{
				WriteByte(0x4A1,value);
			}
		}
		
		/// <summary>
		/// Name: clanMaxSize
		/// Type: IntProperty
		/// Offset: 0x4A4
		/// Size: 0x04
		/// </summary>
		public int clanMaxSize
		{
			get
			{
				return ReadInt32(0x4A4);
			}
			set
			{
				WriteInt32(0x4A4,value);
			}
		}
		
		/// <summary>
		/// Name: IsLoadErrorsFatal
		/// Type: BoolProperty
		/// Offset: 0x4A8
		/// Size: 0x01
		/// </summary>
		public bool IsLoadErrorsFatal
		{
			get
			{
				return ReadBool(0x4A8);
			}
			set
			{
				WriteBool(0x4A8,value);
			}
		}
		
		/// <summary>
		/// Name: ChatHasGlobal
		/// Type: BoolProperty
		/// Offset: 0x4A9
		/// Size: 0x01
		/// </summary>
		public bool ChatHasGlobal
		{
			get
			{
				return ReadBool(0x4A9);
			}
			set
			{
				WriteBool(0x4A9,value);
			}
		}
		
		/// <summary>
		/// Name: ChatLocalRadius
		/// Type: FloatProperty
		/// Offset: 0x4AC
		/// Size: 0x04
		/// </summary>
		public float ChatLocalRadius
		{
			get
			{
				return ReadSingle(0x4AC);
			}
			set
			{
				WriteSingle(0x4AC,value);
			}
		}
		
		/// <summary>
		/// Name: ChatMaxMessageLength
		/// Type: IntProperty
		/// Offset: 0x4B0
		/// Size: 0x04
		/// </summary>
		public int ChatMaxMessageLength
		{
			get
			{
				return ReadInt32(0x4B0);
			}
			set
			{
				WriteInt32(0x4B0,value);
			}
		}
		
		/// <summary>
		/// Name: ChatFloodControlAheadCounter
		/// Type: IntProperty
		/// Offset: 0x4B4
		/// Size: 0x04
		/// </summary>
		public int ChatFloodControlAheadCounter
		{
			get
			{
				return ReadInt32(0x4B4);
			}
			set
			{
				WriteInt32(0x4B4,value);
			}
		}
		
		/// <summary>
		/// Name: serverVoiceChat
		/// Type: ByteProperty
		/// Offset: 0x4B8
		/// Size: 0x01
		/// </summary>
		public byte serverVoiceChat
		{
			get
			{
				return ReadByte(0x4B8);
			}
			set
			{
				WriteByte(0x4B8,value);
			}
		}
		
		/// <summary>
		/// Name: EnableSandStorm
		/// Type: BoolProperty
		/// Offset: 0x4B9
		/// Size: 0x01
		/// </summary>
		public bool EnableSandStorm
		{
			get
			{
				return ReadBool(0x4B9);
			}
			set
			{
				WriteBool(0x4B9,value);
			}
		}
		
		/// <summary>
		/// Name: AvatarsDisabled
		/// Type: BoolProperty
		/// Offset: 0x4BA
		/// Size: 0x01
		/// </summary>
		public bool AvatarsDisabled
		{
			get
			{
				return ReadBool(0x4BA);
			}
			set
			{
				WriteBool(0x4BA,value);
			}
		}
		
		/// <summary>
		/// Name: RestrictAvatarSummoningTime
		/// Type: BoolProperty
		/// Offset: 0x4BB
		/// Size: 0x01
		/// </summary>
		public bool RestrictAvatarSummoningTime
		{
			get
			{
				return ReadBool(0x4BB);
			}
			set
			{
				WriteBool(0x4BB,value);
			}
		}
		
		/// <summary>
		/// Name: AvatarSummoningTimeWeekdayStart
		/// Type: IntProperty
		/// Offset: 0x4BC
		/// Size: 0x04
		/// </summary>
		public int AvatarSummoningTimeWeekdayStart
		{
			get
			{
				return ReadInt32(0x4BC);
			}
			set
			{
				WriteInt32(0x4BC,value);
			}
		}
		
		/// <summary>
		/// Name: AvatarSummoningTimeWeekdayEnd
		/// Type: IntProperty
		/// Offset: 0x4C0
		/// Size: 0x04
		/// </summary>
		public int AvatarSummoningTimeWeekdayEnd
		{
			get
			{
				return ReadInt32(0x4C0);
			}
			set
			{
				WriteInt32(0x4C0,value);
			}
		}
		
		/// <summary>
		/// Name: AvatarSummoningTimeWeekendStart
		/// Type: IntProperty
		/// Offset: 0x4C4
		/// Size: 0x04
		/// </summary>
		public int AvatarSummoningTimeWeekendStart
		{
			get
			{
				return ReadInt32(0x4C4);
			}
			set
			{
				WriteInt32(0x4C4,value);
			}
		}
		
		/// <summary>
		/// Name: AvatarSummoningTimeWeekendEnd
		/// Type: IntProperty
		/// Offset: 0x4C8
		/// Size: 0x04
		/// </summary>
		public int AvatarSummoningTimeWeekendEnd
		{
			get
			{
				return ReadInt32(0x4C8);
			}
			set
			{
				WriteInt32(0x4C8,value);
			}
		}
		
		/// <summary>
		/// Name: AvatarLifetime
		/// Type: FloatProperty
		/// Offset: 0x4CC
		/// Size: 0x04
		/// </summary>
		public float AvatarLifetime
		{
			get
			{
				return ReadSingle(0x4CC);
			}
			set
			{
				WriteSingle(0x4CC,value);
			}
		}
		
		/// <summary>
		/// Name: AvatarSummonTime
		/// Type: FloatProperty
		/// Offset: 0x4D0
		/// Size: 0x04
		/// </summary>
		public float AvatarSummonTime
		{
			get
			{
				return ReadSingle(0x4D0);
			}
			set
			{
				WriteSingle(0x4D0,value);
			}
		}
		
		/// <summary>
		/// Name: IsBattlEyeEnabled
		/// Type: BoolProperty
		/// Offset: 0x4D4
		/// Size: 0x01
		/// </summary>
		public bool IsBattlEyeEnabled
		{
			get
			{
				return ReadBool(0x4D4);
			}
			set
			{
				WriteBool(0x4D4,value);
			}
		}
		
		/// <summary>
		/// Name: IsVACEnabled
		/// Type: BoolProperty
		/// Offset: 0x4D5
		/// Size: 0x01
		/// </summary>
		public bool IsVACEnabled
		{
			get
			{
				return ReadBool(0x4D5);
			}
			set
			{
				WriteBool(0x4D5,value);
			}
		}
		
		/// <summary>
		/// Name: RegionAllowAfrica
		/// Type: BoolProperty
		/// Offset: 0x4DC
		/// Size: 0x01
		/// </summary>
		public bool RegionAllowAfrica
		{
			get
			{
				return ReadBool(0x4DC);
			}
			set
			{
				WriteBool(0x4DC,value);
			}
		}
		
		/// <summary>
		/// Name: RegionAllowAsia
		/// Type: BoolProperty
		/// Offset: 0x4DD
		/// Size: 0x01
		/// </summary>
		public bool RegionAllowAsia
		{
			get
			{
				return ReadBool(0x4DD);
			}
			set
			{
				WriteBool(0x4DD,value);
			}
		}
		
		/// <summary>
		/// Name: RegionAllowCentralEurope
		/// Type: BoolProperty
		/// Offset: 0x4DE
		/// Size: 0x01
		/// </summary>
		public bool RegionAllowCentralEurope
		{
			get
			{
				return ReadBool(0x4DE);
			}
			set
			{
				WriteBool(0x4DE,value);
			}
		}
		
		/// <summary>
		/// Name: RegionAllowEasternEurope
		/// Type: BoolProperty
		/// Offset: 0x4DF
		/// Size: 0x01
		/// </summary>
		public bool RegionAllowEasternEurope
		{
			get
			{
				return ReadBool(0x4DF);
			}
			set
			{
				WriteBool(0x4DF,value);
			}
		}
		
		/// <summary>
		/// Name: RegionAllowWesternEurope
		/// Type: BoolProperty
		/// Offset: 0x4E0
		/// Size: 0x01
		/// </summary>
		public bool RegionAllowWesternEurope
		{
			get
			{
				return ReadBool(0x4E0);
			}
			set
			{
				WriteBool(0x4E0,value);
			}
		}
		
		/// <summary>
		/// Name: RegionAllowNorthAmerica
		/// Type: BoolProperty
		/// Offset: 0x4E1
		/// Size: 0x01
		/// </summary>
		public bool RegionAllowNorthAmerica
		{
			get
			{
				return ReadBool(0x4E1);
			}
			set
			{
				WriteBool(0x4E1,value);
			}
		}
		
		/// <summary>
		/// Name: RegionAllowOceania
		/// Type: BoolProperty
		/// Offset: 0x4E2
		/// Size: 0x01
		/// </summary>
		public bool RegionAllowOceania
		{
			get
			{
				return ReadBool(0x4E2);
			}
			set
			{
				WriteBool(0x4E2,value);
			}
		}
		
		/// <summary>
		/// Name: RegionAllowSouthAmerica
		/// Type: BoolProperty
		/// Offset: 0x4E3
		/// Size: 0x01
		/// </summary>
		public bool RegionAllowSouthAmerica
		{
			get
			{
				return ReadBool(0x4E3);
			}
			set
			{
				WriteBool(0x4E3,value);
			}
		}
		
		/// <summary>
		/// Name: RegionBlockList
		/// Type: StrProperty
		/// Offset: 0x4E8
		/// Size: 0x10
		/// </summary>
		public FString RegionBlockList => new FString(BaseAddress+0x4E8);
		
		/// <summary>
		/// Name: ServerModList
		/// Type: StrProperty
		/// Offset: 0x4F8
		/// Size: 0x10
		/// </summary>
		public FString ServerModList => new FString(BaseAddress+0x4F8);
		
	}


	/// <summary>
	/// UServerInfoBase:URootWidget
	/// Size: 0x548
	/// Properties: 6
	/// </summary>
	public class UServerInfoBase:URootWidget
	{
		public override int ObjectSize => 1352;
		/// <summary>
		/// Name: m_Session
		/// Type: StructProperty
		/// Offset: 0x308
		/// Size: 0xC8
		/// </summary>
		public FBlueprintSessionResult m_Session => ReadStruct<FBlueprintSessionResult>(0x308);
		
		/// <summary>
		/// Name: m_IsBattlEyeEnabled
		/// Type: BoolProperty
		/// Offset: 0x3D0
		/// Size: 0x01
		/// </summary>
		public bool m_IsBattlEyeEnabled
		{
			get
			{
				return ReadBool(0x3D0);
			}
			set
			{
				WriteBool(0x3D0,value);
			}
		}
		
		/// <summary>
		/// Name: m_IsVACEnabled
		/// Type: BoolProperty
		/// Offset: 0x3D1
		/// Size: 0x01
		/// </summary>
		public bool m_IsVACEnabled
		{
			get
			{
				return ReadBool(0x3D1);
			}
			set
			{
				WriteBool(0x3D1,value);
			}
		}
		
		/// <summary>
		/// Name: m_ServerModList
		/// Type: StructProperty
		/// Offset: 0x3D8
		/// Size: 0x18
		/// </summary>
		public FServerModList m_ServerModList => ReadStruct<FServerModList>(0x3D8);
		
		/// <summary>
		/// Name: m_IsValid
		/// Type: BoolProperty
		/// Offset: 0x3F0
		/// Size: 0x01
		/// </summary>
		public bool m_IsValid
		{
			get
			{
				return ReadBool(0x3F0);
			}
			set
			{
				WriteBool(0x3F0,value);
			}
		}
		
		/// <summary>
		/// Name: m_Entry
		/// Type: StructProperty
		/// Offset: 0x468
		/// Size: 0xD8
		/// </summary>
		public FServerListViewEntry m_Entry => ReadStruct<FServerListViewEntry>(0x468);
		
	}


	/// <summary>
	/// UFuncomGenericLibrary:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UFuncomGenericLibrary:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UGuildInviteBase:UWindowRoot
	/// Size: 0x400
	/// Properties: 2
	/// </summary>
	public class UGuildInviteBase:UWindowRoot
	{
		public override int ObjectSize => 1024;
		/// <summary>
		/// Name: ListEntryClass
		/// Type: ClassProperty
		/// Offset: 0x3C0
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: m_GuildId
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public UUniqueID m_GuildId => ReadUObject<UUniqueID>(0x3F0);
		
	}


	/// <summary>
	/// AGuild:AInfo
	/// Size: 0x570
	/// Properties: 6
	/// </summary>
	public class AGuild:AInfo
	{
		public override int ObjectSize => 1392;
		/// <summary>
		/// Name: m_GuildId
		/// Type: ObjectProperty
		/// Offset: 0x4D0
		/// Size: 0x08
		/// </summary>
		public UUniqueID m_GuildId => ReadUObject<UUniqueID>(0x4D0);
		
		/// <summary>
		/// Name: m_GuildName
		/// Type: StrProperty
		/// Offset: 0x4D8
		/// Size: 0x10
		/// </summary>
		public FString m_GuildName => new FString(BaseAddress+0x4D8);
		
		/// <summary>
		/// Name: m_MessageOfTheDay
		/// Type: TextProperty
		/// Offset: 0x4E8
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: m_GuildMasterPlayerId
		/// Type: Int64Property
		/// Offset: 0x500
		/// Size: 0x08
		/// </summary>
		public long m_GuildMasterPlayerId
		{
			get
			{
				return ReadInt64(0x500);
			}
			set
			{
				WriteInt64(0x500,value);
			}
		}
		
		/// <summary>
		/// Name: m_GuildMembers
		/// Type: TArray<FPlayerInfo>
		/// Offset: 0x508
		/// Size: 0x10
		/// SubElement Size: 0x30
		/// </summary>
		public TArray<FPlayerInfo> m_GuildMembers => new TArray<FPlayerInfo>(BaseAddress+0x508);
		
		/// <summary>
		/// Name: m_GuildEvents
		/// Type: TArray<FEventInfo>
		/// Offset: 0x518
		/// Size: 0x10
		/// SubElement Size: 0x40
		/// </summary>
		public TArray<FEventInfo> m_GuildEvents => new TArray<FEventInfo>(BaseAddress+0x518);
		
	}


	/// <summary>
	/// APawn:AActor
	/// Size: 0x430
	/// Properties: 14
	/// </summary>
	public class APawn:AActor
	{
		public override int ObjectSize => 1072;
		/// <summary>
		/// Name: bUseControllerRotationPitch
		/// Type: BoolProperty
		/// Offset: 0x3D8
		/// Size: 0x01
		/// </summary>
		public bool bUseControllerRotationPitch => (ReadByte(0x03D8) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bUseControllerRotationYaw
		/// Type: BoolProperty
		/// Offset: 0x3D8
		/// Size: 0x01
		/// </summary>
		public bool bUseControllerRotationYaw => (ReadByte(0x03D8) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bUseControllerRotationRoll
		/// Type: BoolProperty
		/// Offset: 0x3D8
		/// Size: 0x01
		/// </summary>
		public bool bUseControllerRotationRoll => (ReadByte(0x03D8) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bCanAffectNavigationGeneration
		/// Type: BoolProperty
		/// Offset: 0x3D8
		/// Size: 0x01
		/// </summary>
		public bool bCanAffectNavigationGeneration => (ReadByte(0x03D8) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: BaseEyeHeight
		/// Type: FloatProperty
		/// Offset: 0x3DC
		/// Size: 0x04
		/// </summary>
		public float BaseEyeHeight
		{
			get
			{
				return ReadSingle(0x3DC);
			}
			set
			{
				WriteSingle(0x3DC,value);
			}
		}
		
		/// <summary>
		/// Name: AutoPossessPlayer
		/// Type: ByteProperty
		/// Offset: 0x3E0
		/// Size: 0x01
		/// </summary>
		public byte AutoPossessPlayer
		{
			get
			{
				return ReadByte(0x3E0);
			}
			set
			{
				WriteByte(0x3E0,value);
			}
		}
		
		/// <summary>
		/// Name: AutoPossessAI
		/// Type: ByteProperty
		/// Offset: 0x3E1
		/// Size: 0x01
		/// </summary>
		public byte AutoPossessAI
		{
			get
			{
				return ReadByte(0x3E1);
			}
			set
			{
				WriteByte(0x3E1,value);
			}
		}
		
		/// <summary>
		/// Name: AIControllerClass
		/// Type: ClassProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: PlayerState
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public APlayerState PlayerState => ReadUObject<APlayerState>(0x3F0);
		
		/// <summary>
		/// Name: RemoteViewPitch
		/// Type: ByteProperty
		/// Offset: 0x3F8
		/// Size: 0x01
		/// </summary>
		public byte RemoteViewPitch
		{
			get
			{
				return ReadByte(0x3F8);
			}
			set
			{
				WriteByte(0x3F8,value);
			}
		}
		
		/// <summary>
		/// Name: LastHitBy
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public AController LastHitBy => ReadUObject<AController>(0x400);
		
		/// <summary>
		/// Name: Controller
		/// Type: ObjectProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public AController Controller => ReadUObject<AController>(0x408);
		
		/// <summary>
		/// Name: ControlInputVector
		/// Type: StructProperty
		/// Offset: 0x418
		/// Size: 0x0C
		/// </summary>
		public FVector ControlInputVector => ReadStruct<FVector>(0x418);
		
		/// <summary>
		/// Name: LastControlInputVector
		/// Type: StructProperty
		/// Offset: 0x424
		/// Size: 0x0C
		/// </summary>
		public FVector LastControlInputVector => ReadStruct<FVector>(0x424);
		
	}


	/// <summary>
	/// ACharacter:APawn
	/// Size: 0x7E0
	/// Properties: 27
	/// </summary>
	public class ACharacter:APawn
	{
		public override int ObjectSize => 2016;
		/// <summary>
		/// Name: Mesh
		/// Type: ObjectProperty
		/// Offset: 0x430
		/// Size: 0x08
		/// </summary>
		public USkeletalMeshComponent Mesh => ReadUObject<USkeletalMeshComponent>(0x430);
		
		/// <summary>
		/// Name: CharacterMovement
		/// Type: ObjectProperty
		/// Offset: 0x438
		/// Size: 0x08
		/// </summary>
		public UCharacterMovementComponent CharacterMovement => ReadUObject<UCharacterMovementComponent>(0x438);
		
		/// <summary>
		/// Name: CapsuleComponent
		/// Type: ObjectProperty
		/// Offset: 0x440
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent CapsuleComponent => ReadUObject<UCapsuleComponent>(0x440);
		
		/// <summary>
		/// Name: BasedMovement
		/// Type: StructProperty
		/// Offset: 0x448
		/// Size: 0x30
		/// </summary>
		public FBasedMovementInfo BasedMovement => ReadStruct<FBasedMovementInfo>(0x448);
		
		/// <summary>
		/// Name: ReplicatedBasedMovement
		/// Type: StructProperty
		/// Offset: 0x478
		/// Size: 0x30
		/// </summary>
		public FBasedMovementInfo ReplicatedBasedMovement => ReadStruct<FBasedMovementInfo>(0x478);
		
		/// <summary>
		/// Name: AnimRootMotionTranslationScale
		/// Type: FloatProperty
		/// Offset: 0x4A8
		/// Size: 0x04
		/// </summary>
		public float AnimRootMotionTranslationScale
		{
			get
			{
				return ReadSingle(0x4A8);
			}
			set
			{
				WriteSingle(0x4A8,value);
			}
		}
		
		/// <summary>
		/// Name: BaseTranslationOffset
		/// Type: StructProperty
		/// Offset: 0x4AC
		/// Size: 0x0C
		/// </summary>
		public FVector BaseTranslationOffset => ReadStruct<FVector>(0x4AC);
		
		/// <summary>
		/// Name: BaseRotationOffset
		/// Type: StructProperty
		/// Offset: 0x4C0
		/// Size: 0x10
		/// </summary>
		public FQuat BaseRotationOffset => ReadStruct<FQuat>(0x4C0);
		
		/// <summary>
		/// Name: ReplicatedServerLastTransformUpdateTimeStamp
		/// Type: FloatProperty
		/// Offset: 0x4D0
		/// Size: 0x04
		/// </summary>
		public float ReplicatedServerLastTransformUpdateTimeStamp
		{
			get
			{
				return ReadSingle(0x4D0);
			}
			set
			{
				WriteSingle(0x4D0,value);
			}
		}
		
		/// <summary>
		/// Name: ReplicatedMovementMode
		/// Type: ByteProperty
		/// Offset: 0x4D4
		/// Size: 0x01
		/// </summary>
		public byte ReplicatedMovementMode
		{
			get
			{
				return ReadByte(0x4D4);
			}
			set
			{
				WriteByte(0x4D4,value);
			}
		}
		
		/// <summary>
		/// Name: bInBaseReplication
		/// Type: BoolProperty
		/// Offset: 0x4D5
		/// Size: 0x01
		/// </summary>
		public bool bInBaseReplication
		{
			get
			{
				return ReadBool(0x4D5);
			}
			set
			{
				WriteBool(0x4D5,value);
			}
		}
		
		/// <summary>
		/// Name: CrouchedEyeHeight
		/// Type: FloatProperty
		/// Offset: 0x4D8
		/// Size: 0x04
		/// </summary>
		public float CrouchedEyeHeight
		{
			get
			{
				return ReadSingle(0x4D8);
			}
			set
			{
				WriteSingle(0x4D8,value);
			}
		}
		
		/// <summary>
		/// Name: bIsCrouched
		/// Type: BoolProperty
		/// Offset: 0x4DC
		/// Size: 0x01
		/// </summary>
		public bool bIsCrouched => (ReadByte(0x04DC) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bPressedJump
		/// Type: BoolProperty
		/// Offset: 0x4DC
		/// Size: 0x01
		/// </summary>
		public bool bPressedJump => (ReadByte(0x04DC) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bClientUpdating
		/// Type: BoolProperty
		/// Offset: 0x4DC
		/// Size: 0x01
		/// </summary>
		public bool bClientUpdating => (ReadByte(0x04DC) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bClientWasFalling
		/// Type: BoolProperty
		/// Offset: 0x4DC
		/// Size: 0x01
		/// </summary>
		public bool bClientWasFalling => (ReadByte(0x04DC) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bClientResimulateRootMotion
		/// Type: BoolProperty
		/// Offset: 0x4DC
		/// Size: 0x01
		/// </summary>
		public bool bClientResimulateRootMotion => (ReadByte(0x04DC) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bClientResimulateRootMotionSources
		/// Type: BoolProperty
		/// Offset: 0x4DC
		/// Size: 0x01
		/// </summary>
		public bool bClientResimulateRootMotionSources => (ReadByte(0x04DC) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: bSimGravityDisabled
		/// Type: BoolProperty
		/// Offset: 0x4DC
		/// Size: 0x01
		/// </summary>
		public bool bSimGravityDisabled => (ReadByte(0x04DC) & 0x40) == 0x40;
		
		/// <summary>
		/// Name: bClientCheckEncroachmentOnNetUpdate
		/// Type: BoolProperty
		/// Offset: 0x4DC
		/// Size: 0x01
		/// </summary>
		public bool bClientCheckEncroachmentOnNetUpdate => (ReadByte(0x04DC) & 0x80) == 0x80;
		
		/// <summary>
		/// Name: bServerMoveIgnoreRootMotion
		/// Type: BoolProperty
		/// Offset: 0x4DD
		/// Size: 0x01
		/// </summary>
		public bool bServerMoveIgnoreRootMotion => (ReadByte(0x04DD) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: JumpKeyHoldTime
		/// Type: FloatProperty
		/// Offset: 0x4E0
		/// Size: 0x04
		/// </summary>
		public float JumpKeyHoldTime
		{
			get
			{
				return ReadSingle(0x4E0);
			}
			set
			{
				WriteSingle(0x4E0,value);
			}
		}
		
		/// <summary>
		/// Name: JumpMaxHoldTime
		/// Type: FloatProperty
		/// Offset: 0x4E4
		/// Size: 0x04
		/// </summary>
		public float JumpMaxHoldTime
		{
			get
			{
				return ReadSingle(0x4E4);
			}
			set
			{
				WriteSingle(0x4E4,value);
			}
		}
		
		/// <summary>
		/// Name: SavedRootMotion
		/// Type: StructProperty
		/// Offset: 0x528
		/// Size: 0x100
		/// </summary>
		public FRootMotionSourceGroup SavedRootMotion => ReadStruct<FRootMotionSourceGroup>(0x528);
		
		/// <summary>
		/// Name: ClientRootMotionParams
		/// Type: StructProperty
		/// Offset: 0x630
		/// Size: 0x40
		/// </summary>
		public FRootMotionMovementParams ClientRootMotionParams => ReadStruct<FRootMotionMovementParams>(0x630);
		
		/// <summary>
		/// Name: RootMotionRepMoves
		/// Type: TArray<FSimulatedRootMotionReplicatedMove>
		/// Offset: 0x670
		/// Size: 0x10
		/// SubElement Size: 0x168
		/// </summary>
		public TArray<FSimulatedRootMotionReplicatedMove> RootMotionRepMoves => new TArray<FSimulatedRootMotionReplicatedMove>(BaseAddress+0x670);
		
		/// <summary>
		/// Name: RepRootMotion
		/// Type: StructProperty
		/// Offset: 0x680
		/// Size: 0x160
		/// </summary>
		public FRepRootMotionMontage RepRootMotion => ReadStruct<FRepRootMotionMontage>(0x680);
		
	}


	/// <summary>
	/// AConanCharacter:ACharacter
	/// Size: 0xA60
	/// Properties: 21
	/// </summary>
	public class AConanCharacter:ACharacter
	{
		public override int ObjectSize => 2656;
		/// <summary>
		/// Name: m_InteractingActor
		/// Type: ObjectProperty
		/// Offset: 0x7F0
		/// Size: 0x08
		/// </summary>
		public AActor m_InteractingActor => ReadUObject<AActor>(0x7F0);
		
		/// <summary>
		/// Name: WeaponChangeDisabled
		/// Type: BoolProperty
		/// Offset: 0x800
		/// Size: 0x01
		/// </summary>
		public bool WeaponChangeDisabled
		{
			get
			{
				return ReadBool(0x800);
			}
			set
			{
				WriteBool(0x800,value);
			}
		}
		
		/// <summary>
		/// Name: m_IsReparing
		/// Type: BoolProperty
		/// Offset: 0x801
		/// Size: 0x01
		/// </summary>
		public bool m_IsReparing
		{
			get
			{
				return ReadBool(0x801);
			}
			set
			{
				WriteBool(0x801,value);
			}
		}
		
		/// <summary>
		/// Name: HasTimeCatchedUp
		/// Type: BoolProperty
		/// Offset: 0x802
		/// Size: 0x01
		/// </summary>
		public bool HasTimeCatchedUp
		{
			get
			{
				return ReadBool(0x802);
			}
			set
			{
				WriteBool(0x802,value);
			}
		}
		
		/// <summary>
		/// Name: FeatVersion
		/// Type: IntProperty
		/// Offset: 0x804
		/// Size: 0x04
		/// </summary>
		public int FeatVersion
		{
			get
			{
				return ReadInt32(0x804);
			}
			set
			{
				WriteInt32(0x804,value);
			}
		}
		
		/// <summary>
		/// Name: characterUniqueId
		/// Type: ObjectProperty
		/// Offset: 0x808
		/// Size: 0x08
		/// </summary>
		public UUniqueID characterUniqueId => ReadUObject<UUniqueID>(0x808);
		
		/// <summary>
		/// Name: CharacterGuildID
		/// Type: ObjectProperty
		/// Offset: 0x810
		/// Size: 0x08
		/// </summary>
		public UUniqueID CharacterGuildID => ReadUObject<UUniqueID>(0x810);
		
		/// <summary>
		/// Name: SourceSpawnTable
		/// Type: NameProperty
		/// Offset: 0x818
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: isAlive
		/// Type: BoolProperty
		/// Offset: 0x820
		/// Size: 0x01
		/// </summary>
		public bool isAlive
		{
			get
			{
				return ReadBool(0x820);
			}
			set
			{
				WriteBool(0x820,value);
			}
		}
		
		/// <summary>
		/// Name: killerName
		/// Type: TextProperty
		/// Offset: 0x828
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: HarvestTimeStamp
		/// Type: StructProperty
		/// Offset: 0x840
		/// Size: 0x08
		/// </summary>
		public FDateTime HarvestTimeStamp => ReadStruct<FDateTime>(0x840);
		
		/// <summary>
		/// Name: SprintNoCost
		/// Type: BoolProperty
		/// Offset: 0x858
		/// Size: 0x01
		/// </summary>
		public bool SprintNoCost
		{
			get
			{
				return ReadBool(0x858);
			}
			set
			{
				WriteBool(0x858,value);
			}
		}
		
		/// <summary>
		/// Name: SenseDetection
		/// Type: BoolProperty
		/// Offset: 0x859
		/// Size: 0x01
		/// </summary>
		public bool SenseDetection
		{
			get
			{
				return ReadBool(0x859);
			}
			set
			{
				WriteBool(0x859,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerInvisibility
		/// Type: BoolProperty
		/// Offset: 0x85A
		/// Size: 0x01
		/// </summary>
		public bool PlayerInvisibility
		{
			get
			{
				return ReadBool(0x85A);
			}
			set
			{
				WriteBool(0x85A,value);
			}
		}
		
		/// <summary>
		/// Name: AdditionalInteractionExtent
		/// Type: FloatProperty
		/// Offset: 0x85C
		/// Size: 0x04
		/// </summary>
		public float AdditionalInteractionExtent
		{
			get
			{
				return ReadSingle(0x85C);
			}
			set
			{
				WriteSingle(0x85C,value);
			}
		}
		
		/// <summary>
		/// Name: CarriedPeople
		/// Type: TArray<AConanCharacter>
		/// Offset: 0x9B0
		/// Size: 0x10
		/// SubElement Size: 0xA60
		/// </summary>
		public TArray<AConanCharacter> CarriedPeople => new TArray<AConanCharacter>(BaseAddress+0x9B0);
		
		/// <summary>
		/// Name: BeingCarriedWeight
		/// Type: FloatProperty
		/// Offset: 0x9C0
		/// Size: 0x04
		/// </summary>
		public float BeingCarriedWeight
		{
			get
			{
				return ReadSingle(0x9C0);
			}
			set
			{
				WriteSingle(0x9C0,value);
			}
		}
		
		/// <summary>
		/// Name: m_StatHolder
		/// Type: ObjectProperty
		/// Offset: 0xA00
		/// Size: 0x08
		/// </summary>
		public UStatHolder m_StatHolder => ReadUObject<UStatHolder>(0xA00);
		
		/// <summary>
		/// Name: m_GameState
		/// Type: ObjectProperty
		/// Offset: 0xA08
		/// Size: 0x08
		/// </summary>
		public AConanGameState m_GameState => ReadUObject<AConanGameState>(0xA08);
		
		/// <summary>
		/// Name: m_HungerSystem
		/// Type: ObjectProperty
		/// Offset: 0xA10
		/// Size: 0x08
		/// </summary>
		public UHungerSystem m_HungerSystem => ReadUObject<UHungerSystem>(0xA10);
		
		/// <summary>
		/// Name: m_CharacterName
		/// Type: TextProperty
		/// Offset: 0xA18
		/// Size: 0x18
		/// </summary>
		
	}


	/// <summary>
	/// AAvatarCharacter:AConanCharacter
	/// Size: 0xA70
	/// Properties: 1
	/// </summary>
	public class AAvatarCharacter:AConanCharacter
	{
		public override int ObjectSize => 2672;
		/// <summary>
		/// Name: m_Summoner
		/// Type: ObjectProperty
		/// Offset: 0xA60
		/// Size: 0x08
		/// </summary>
		public AConanCharacter m_Summoner => ReadUObject<AConanCharacter>(0xA60);
		
	}


	/// <summary>
	/// UConanCharacterComponent:UActorComponent
	/// Size: 0xE0
	/// Properties: 0
	/// </summary>
	public class UConanCharacterComponent:UActorComponent
	{
		public override int ObjectSize => 224;
	}


	/// <summary>
	/// UEncumbranceSystem:UConanCharacterComponent
	/// Size: 0xF8
	/// Properties: 2
	/// </summary>
	public class UEncumbranceSystem:UConanCharacterComponent
	{
		public override int ObjectSize => 248;
		/// <summary>
		/// Name: EncumbranceTierThresholds
		/// Type: TArray<>
		/// Offset: 0xE0
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: CurrentEncumbranceTier
		/// Type: ByteProperty
		/// Offset: 0xF0
		/// Size: 0x01
		/// </summary>
		public byte CurrentEncumbranceTier
		{
			get
			{
				return ReadByte(0xF0);
			}
			set
			{
				WriteByte(0xF0,value);
			}
		}
		
	}


	/// <summary>
	/// UHungerSystem:UConanCharacterComponent
	/// Size: 0x100
	/// Properties: 0
	/// </summary>
	public class UHungerSystem:UConanCharacterComponent
	{
		public override int ObjectSize => 256;
	}


	/// <summary>
	/// UProgressionSystem:UConanCharacterComponent
	/// Size: 0x198
	/// Properties: 0
	/// </summary>
	public class UProgressionSystem:UConanCharacterComponent
	{
		public override int ObjectSize => 408;
	}


	/// <summary>
	/// UCharacterPersistenceComponent:UPersistenceComponent
	/// Size: 0x138
	/// Properties: 0
	/// </summary>
	public class UCharacterPersistenceComponent:UPersistenceComponent
	{
		public override int ObjectSize => 312;
	}


	/// <summary>
	/// UConanCharacterPersistenceComponent:UCharacterPersistenceComponent
	/// Size: 0x138
	/// Properties: 0
	/// </summary>
	public class UConanCharacterPersistenceComponent:UCharacterPersistenceComponent
	{
		public override int ObjectSize => 312;
	}


	/// <summary>
	/// UEmoteController:UActorComponent
	/// Size: 0xF0
	/// Properties: 3
	/// </summary>
	public class UEmoteController:UActorComponent
	{
		public override int ObjectSize => 240;
		/// <summary>
		/// Name: CurrentEmote
		/// Type: ByteProperty
		/// Offset: 0xD8
		/// Size: 0x01
		/// </summary>
		public byte CurrentEmote
		{
			get
			{
				return ReadByte(0xD8);
			}
			set
			{
				WriteByte(0xD8,value);
			}
		}
		
		/// <summary>
		/// Name: CurrentEmoteAnimMontage
		/// Type: ObjectProperty
		/// Offset: 0xE0
		/// Size: 0x08
		/// </summary>
		public UAnimMontage CurrentEmoteAnimMontage => ReadUObject<UAnimMontage>(0xE0);
		
		/// <summary>
		/// Name: CurrentEmoteFlags
		/// Type: IntProperty
		/// Offset: 0xE8
		/// Size: 0x04
		/// </summary>
		public int CurrentEmoteFlags
		{
			get
			{
				return ReadInt32(0xE8);
			}
			set
			{
				WriteInt32(0xE8,value);
			}
		}
		
	}


	/// <summary>
	/// UCheatManager:UObject
	/// Size: 0x78
	/// Properties: 2
	/// </summary>
	public class UCheatManager:UObject
	{
		public override int ObjectSize => 120;
		/// <summary>
		/// Name: DebugCameraControllerRef
		/// Type: ObjectProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		public ADebugCameraController DebugCameraControllerRef => ReadUObject<ADebugCameraController>(0x28);
		
		/// <summary>
		/// Name: DebugCameraControllerClass
		/// Type: ClassProperty
		/// Offset: 0x30
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// UConanCheatManager:UCheatManager
	/// Size: 0xD0
	/// Properties: 0
	/// </summary>
	public class UConanCheatManager:UCheatManager
	{
		public override int ObjectSize => 208;
	}


	/// <summary>
	/// AGameMode:AInfo
	/// Size: 0x4C8
	/// Properties: 25
	/// </summary>
	public class AGameMode:AInfo
	{
		public override int ObjectSize => 1224;
		/// <summary>
		/// Name: bUseSeamlessTravel
		/// Type: BoolProperty
		/// Offset: 0x3D8
		/// Size: 0x01
		/// </summary>
		public bool bUseSeamlessTravel => (ReadByte(0x03D8) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bPauseable
		/// Type: BoolProperty
		/// Offset: 0x3D8
		/// Size: 0x01
		/// </summary>
		public bool bPauseable => (ReadByte(0x03D8) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bStartPlayersAsSpectators
		/// Type: BoolProperty
		/// Offset: 0x3D8
		/// Size: 0x01
		/// </summary>
		public bool bStartPlayersAsSpectators => (ReadByte(0x03D8) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bDelayedStart
		/// Type: BoolProperty
		/// Offset: 0x3D8
		/// Size: 0x01
		/// </summary>
		public bool bDelayedStart => (ReadByte(0x03D8) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: OptionsString
		/// Type: StrProperty
		/// Offset: 0x3E0
		/// Size: 0x10
		/// </summary>
		public FString OptionsString => new FString(BaseAddress+0x3E0);
		
		/// <summary>
		/// Name: DefaultPawnClass
		/// Type: ClassProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: HUDClass
		/// Type: ClassProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: NumSpectators
		/// Type: IntProperty
		/// Offset: 0x400
		/// Size: 0x04
		/// </summary>
		public int NumSpectators
		{
			get
			{
				return ReadInt32(0x400);
			}
			set
			{
				WriteInt32(0x400,value);
			}
		}
		
		/// <summary>
		/// Name: NumPlayers
		/// Type: IntProperty
		/// Offset: 0x404
		/// Size: 0x04
		/// </summary>
		public int NumPlayers
		{
			get
			{
				return ReadInt32(0x404);
			}
			set
			{
				WriteInt32(0x404,value);
			}
		}
		
		/// <summary>
		/// Name: NumBots
		/// Type: IntProperty
		/// Offset: 0x408
		/// Size: 0x04
		/// </summary>
		public int NumBots
		{
			get
			{
				return ReadInt32(0x408);
			}
			set
			{
				WriteInt32(0x408,value);
			}
		}
		
		/// <summary>
		/// Name: MinRespawnDelay
		/// Type: FloatProperty
		/// Offset: 0x40C
		/// Size: 0x04
		/// </summary>
		public float MinRespawnDelay
		{
			get
			{
				return ReadSingle(0x40C);
			}
			set
			{
				WriteSingle(0x40C,value);
			}
		}
		
		/// <summary>
		/// Name: GameSession
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public AGameSession GameSession => ReadUObject<AGameSession>(0x410);
		
		/// <summary>
		/// Name: NumTravellingPlayers
		/// Type: IntProperty
		/// Offset: 0x418
		/// Size: 0x04
		/// </summary>
		public int NumTravellingPlayers
		{
			get
			{
				return ReadInt32(0x418);
			}
			set
			{
				WriteInt32(0x418,value);
			}
		}
		
		/// <summary>
		/// Name: DefaultPlayerName
		/// Type: TextProperty
		/// Offset: 0x420
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: EngineMessageClass
		/// Type: ClassProperty
		/// Offset: 0x438
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: PlayerControllerClass
		/// Type: ClassProperty
		/// Offset: 0x440
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: SpectatorClass
		/// Type: ClassProperty
		/// Offset: 0x448
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: ReplaySpectatorPlayerControllerClass
		/// Type: ClassProperty
		/// Offset: 0x450
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: PlayerStateClass
		/// Type: ClassProperty
		/// Offset: 0x458
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: GameStateClass
		/// Type: ClassProperty
		/// Offset: 0x460
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: GameState
		/// Type: ObjectProperty
		/// Offset: 0x468
		/// Size: 0x08
		/// </summary>
		public AGameState GameState => ReadUObject<AGameState>(0x468);
		
		/// <summary>
		/// Name: InactivePlayerArray
		/// Type: TArray<APlayerState>
		/// Offset: 0x470
		/// Size: 0x10
		/// SubElement Size: 0x458
		/// </summary>
		public TArray<APlayerState> InactivePlayerArray => new TArray<APlayerState>(BaseAddress+0x470);
		
		/// <summary>
		/// Name: GameModeClassAliases
		/// Type: TArray<FGameClassShortName>
		/// Offset: 0x4A0
		/// Size: 0x10
		/// SubElement Size: 0x20
		/// </summary>
		public TArray<FGameClassShortName> GameModeClassAliases => new TArray<FGameClassShortName>(BaseAddress+0x4A0);
		
		/// <summary>
		/// Name: InactivePlayerStateLifeSpan
		/// Type: FloatProperty
		/// Offset: 0x4B0
		/// Size: 0x04
		/// </summary>
		public float InactivePlayerStateLifeSpan
		{
			get
			{
				return ReadSingle(0x4B0);
			}
			set
			{
				WriteSingle(0x4B0,value);
			}
		}
		
		/// <summary>
		/// Name: bHandleDedicatedServerReplays
		/// Type: BoolProperty
		/// Offset: 0x4B4
		/// Size: 0x01
		/// </summary>
		public bool bHandleDedicatedServerReplays
		{
			get
			{
				return ReadBool(0x4B4);
			}
			set
			{
				WriteBool(0x4B4,value);
			}
		}
		
	}


	/// <summary>
	/// ADWGameMode:AGameMode
	/// Size: 0x5A0
	/// Properties: 4
	/// </summary>
	public class ADWGameMode:AGameMode
	{
		public override int ObjectSize => 1440;
		/// <summary>
		/// Name: DatabaseHost
		/// Type: StrProperty
		/// Offset: 0x4C8
		/// Size: 0x10
		/// </summary>
		public FString DatabaseHost => new FString(BaseAddress+0x4C8);
		
		/// <summary>
		/// Name: DatabasePort
		/// Type: IntProperty
		/// Offset: 0x4D8
		/// Size: 0x04
		/// </summary>
		public int DatabasePort
		{
			get
			{
				return ReadInt32(0x4D8);
			}
			set
			{
				WriteInt32(0x4D8,value);
			}
		}
		
		/// <summary>
		/// Name: DatabaseVerbose
		/// Type: BoolProperty
		/// Offset: 0x4DC
		/// Size: 0x01
		/// </summary>
		public bool DatabaseVerbose
		{
			get
			{
				return ReadBool(0x4DC);
			}
			set
			{
				WriteBool(0x4DC,value);
			}
		}
		
		/// <summary>
		/// Name: WorldPersistence
		/// Type: ObjectProperty
		/// Offset: 0x4E0
		/// Size: 0x08
		/// </summary>
		public UWorldPersistenceComponent WorldPersistence => ReadUObject<UWorldPersistenceComponent>(0x4E0);
		
	}


	/// <summary>
	/// AConanGameMode:ADWGameMode
	/// Size: 0x6A8
	/// Properties: 8
	/// </summary>
	public class AConanGameMode:ADWGameMode
	{
		public override int ObjectSize => 1704;
		/// <summary>
		/// Name: SpawnTableSystem
		/// Type: ObjectProperty
		/// Offset: 0x5A0
		/// Size: 0x08
		/// </summary>
		public USpawnTableComponent SpawnTableSystem => ReadUObject<USpawnTableComponent>(0x5A0);
		
		/// <summary>
		/// Name: SharedDebugInfoClass
		/// Type: ClassProperty
		/// Offset: 0x5A8
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: CountryBlackList
		/// Type: TArray<>
		/// Offset: 0x5D8
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: MaxPeriodicBackupsToKeep
		/// Type: UInt32Property
		/// Offset: 0x5E8
		/// Size: 0x04
		/// </summary>
		
		/// <summary>
		/// Name: PeriodicBackupInterval
		/// Type: FloatProperty
		/// Offset: 0x5EC
		/// Size: 0x04
		/// </summary>
		public float PeriodicBackupInterval
		{
			get
			{
				return ReadSingle(0x5EC);
			}
			set
			{
				WriteSingle(0x5EC,value);
			}
		}
		
		/// <summary>
		/// Name: MaxUpgradeBackupstoKeep
		/// Type: IntProperty
		/// Offset: 0x5F0
		/// Size: 0x04
		/// </summary>
		public int MaxUpgradeBackupstoKeep
		{
			get
			{
				return ReadInt32(0x5F0);
			}
			set
			{
				WriteInt32(0x5F0,value);
			}
		}
		
		/// <summary>
		/// Name: m_HarvestCorpseAntiGC
		/// Type: TArray<UUniqueID>
		/// Offset: 0x5F8
		/// Size: 0x10
		/// SubElement Size: 0x50
		/// </summary>
		public TArray<UUniqueID> m_HarvestCorpseAntiGC => new TArray<UUniqueID>(BaseAddress+0x5F8);
		
		/// <summary>
		/// Name: m_ServerFrameRateReporter
		/// Type: ObjectProperty
		/// Offset: 0x658
		/// Size: 0x08
		/// </summary>
		public UFrameRateReporter m_ServerFrameRateReporter => ReadUObject<UFrameRateReporter>(0x658);
		
	}


	/// <summary>
	/// AGameState:AInfo
	/// Size: 0x430
	/// Properties: 10
	/// </summary>
	public class AGameState:AInfo
	{
		public override int ObjectSize => 1072;
		/// <summary>
		/// Name: GameModeClass
		/// Type: ClassProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: AuthorityGameMode
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public AGameMode AuthorityGameMode => ReadUObject<AGameMode>(0x3D8);
		
		/// <summary>
		/// Name: SpectatorClass
		/// Type: ClassProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: MatchState
		/// Type: NameProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: PreviousMatchState
		/// Type: NameProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: ElapsedTime
		/// Type: IntProperty
		/// Offset: 0x3F8
		/// Size: 0x04
		/// </summary>
		public int ElapsedTime
		{
			get
			{
				return ReadInt32(0x3F8);
			}
			set
			{
				WriteInt32(0x3F8,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerArray
		/// Type: TArray<APlayerState>
		/// Offset: 0x400
		/// Size: 0x10
		/// SubElement Size: 0x458
		/// </summary>
		public TArray<APlayerState> PlayerArray => new TArray<APlayerState>(BaseAddress+0x400);
		
		/// <summary>
		/// Name: ReplicatedWorldTimeSeconds
		/// Type: FloatProperty
		/// Offset: 0x410
		/// Size: 0x04
		/// </summary>
		public float ReplicatedWorldTimeSeconds
		{
			get
			{
				return ReadSingle(0x410);
			}
			set
			{
				WriteSingle(0x410,value);
			}
		}
		
		/// <summary>
		/// Name: ServerWorldTimeSecondsDelta
		/// Type: FloatProperty
		/// Offset: 0x414
		/// Size: 0x04
		/// </summary>
		public float ServerWorldTimeSecondsDelta
		{
			get
			{
				return ReadSingle(0x414);
			}
			set
			{
				WriteSingle(0x414,value);
			}
		}
		
		/// <summary>
		/// Name: ServerWorldTimeSecondsUpdateFrequency
		/// Type: FloatProperty
		/// Offset: 0x418
		/// Size: 0x04
		/// </summary>
		public float ServerWorldTimeSecondsUpdateFrequency
		{
			get
			{
				return ReadSingle(0x418);
			}
			set
			{
				WriteSingle(0x418,value);
			}
		}
		
	}


	/// <summary>
	/// ADWGameState:AGameState
	/// Size: 0x448
	/// Properties: 2
	/// </summary>
	public class ADWGameState:AGameState
	{
		public override int ObjectSize => 1096;
		/// <summary>
		/// Name: SoundStageClassName
		/// Type: StructProperty
		/// Offset: 0x430
		/// Size: 0x10
		/// </summary>
		public FStringClassReference SoundStageClassName => ReadStruct<FStringClassReference>(0x430);
		
		/// <summary>
		/// Name: SoundStage
		/// Type: ObjectProperty
		/// Offset: 0x440
		/// Size: 0x08
		/// </summary>
		public ASoundStage SoundStage => ReadUObject<ASoundStage>(0x440);
		
	}


	/// <summary>
	/// AConanGameState:ADWGameState
	/// Size: 0x500
	/// Properties: 12
	/// </summary>
	public class AConanGameState:ADWGameState
	{
		public override int ObjectSize => 1280;
		/// <summary>
		/// Name: CharacterLodSystem
		/// Type: ObjectProperty
		/// Offset: 0x448
		/// Size: 0x08
		/// </summary>
		public ACharacterLodSystem CharacterLodSystem => ReadUObject<ACharacterLodSystem>(0x448);
		
		/// <summary>
		/// Name: ServerTimezoneHours
		/// Type: IntProperty
		/// Offset: 0x490
		/// Size: 0x04
		/// </summary>
		public int ServerTimezoneHours
		{
			get
			{
				return ReadInt32(0x490);
			}
			set
			{
				WriteInt32(0x490,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerHealthMultiplier
		/// Type: FloatProperty
		/// Offset: 0x494
		/// Size: 0x04
		/// </summary>
		public float PlayerHealthMultiplier
		{
			get
			{
				return ReadSingle(0x494);
			}
			set
			{
				WriteSingle(0x494,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerStaminaMultiplier
		/// Type: FloatProperty
		/// Offset: 0x498
		/// Size: 0x04
		/// </summary>
		public float PlayerStaminaMultiplier
		{
			get
			{
				return ReadSingle(0x498);
			}
			set
			{
				WriteSingle(0x498,value);
			}
		}
		
		/// <summary>
		/// Name: UseListenServerHostPlayerLocation
		/// Type: BoolProperty
		/// Offset: 0x49C
		/// Size: 0x01
		/// </summary>
		public bool UseListenServerHostPlayerLocation => (ReadByte(0x049C) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: ListenServerHostPlayerLocation
		/// Type: StructProperty
		/// Offset: 0x4A0
		/// Size: 0x0C
		/// </summary>
		public FVector ListenServerHostPlayerLocation => ReadStruct<FVector>(0x4A0);
		
		/// <summary>
		/// Name: UserSettingsEventDispatcher
		/// Type: ObjectProperty
		/// Offset: 0x4B0
		/// Size: 0x08
		/// </summary>
		public USettingsEventDispatchers UserSettingsEventDispatcher => ReadUObject<USettingsEventDispatchers>(0x4B0);
		
		/// <summary>
		/// Name: m_ChatCommandHelper
		/// Type: ObjectProperty
		/// Offset: 0x4B8
		/// Size: 0x08
		/// </summary>
		public UChatCommandHelper m_ChatCommandHelper => ReadUObject<UChatCommandHelper>(0x4B8);
		
		/// <summary>
		/// Name: guildList
		/// Type: TArray<AGuild>
		/// Offset: 0x4C0
		/// Size: 0x10
		/// SubElement Size: 0x570
		/// </summary>
		public TArray<AGuild> guildList => new TArray<AGuild>(BaseAddress+0x4C0);
		
		/// <summary>
		/// Name: ServerSettingsClass
		/// Type: ClassProperty
		/// Offset: 0x4D8
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: ReplicatedIds
		/// Type: TArray<UUniqueID>
		/// Offset: 0x4E0
		/// Size: 0x10
		/// SubElement Size: 0x50
		/// </summary>
		public TArray<UUniqueID> ReplicatedIds => new TArray<UUniqueID>(BaseAddress+0x4E0);
		
		/// <summary>
		/// Name: ServerSettings
		/// Type: ObjectProperty
		/// Offset: 0x4F0
		/// Size: 0x08
		/// </summary>
		public AServerSettings ServerSettings => ReadUObject<AServerSettings>(0x4F0);
		
	}


	/// <summary>
	/// UEngine:UObject
	/// Size: 0xBB0
	/// Properties: 196
	/// </summary>
	public class UEngine:UObject
	{
		public override int ObjectSize => 2992;
		/// <summary>
		/// Name: TinyFont
		/// Type: ObjectProperty
		/// Offset: 0x30
		/// Size: 0x08
		/// </summary>
		public UFont TinyFont => ReadUObject<UFont>(0x30);
		
		/// <summary>
		/// Name: TinyFontName
		/// Type: StructProperty
		/// Offset: 0x38
		/// Size: 0x10
		/// </summary>
		public FStringAssetReference TinyFontName => ReadStruct<FStringAssetReference>(0x38);
		
		/// <summary>
		/// Name: SmallFont
		/// Type: ObjectProperty
		/// Offset: 0x48
		/// Size: 0x08
		/// </summary>
		public UFont SmallFont => ReadUObject<UFont>(0x48);
		
		/// <summary>
		/// Name: SmallFontName
		/// Type: StructProperty
		/// Offset: 0x50
		/// Size: 0x10
		/// </summary>
		public FStringAssetReference SmallFontName => ReadStruct<FStringAssetReference>(0x50);
		
		/// <summary>
		/// Name: MediumFont
		/// Type: ObjectProperty
		/// Offset: 0x60
		/// Size: 0x08
		/// </summary>
		public UFont MediumFont => ReadUObject<UFont>(0x60);
		
		/// <summary>
		/// Name: MediumFontName
		/// Type: StructProperty
		/// Offset: 0x68
		/// Size: 0x10
		/// </summary>
		public FStringAssetReference MediumFontName => ReadStruct<FStringAssetReference>(0x68);
		
		/// <summary>
		/// Name: LargeFont
		/// Type: ObjectProperty
		/// Offset: 0x78
		/// Size: 0x08
		/// </summary>
		public UFont LargeFont => ReadUObject<UFont>(0x78);
		
		/// <summary>
		/// Name: LargeFontName
		/// Type: StructProperty
		/// Offset: 0x80
		/// Size: 0x10
		/// </summary>
		public FStringAssetReference LargeFontName => ReadStruct<FStringAssetReference>(0x80);
		
		/// <summary>
		/// Name: SubtitleFont
		/// Type: ObjectProperty
		/// Offset: 0x90
		/// Size: 0x08
		/// </summary>
		public UFont SubtitleFont => ReadUObject<UFont>(0x90);
		
		/// <summary>
		/// Name: SubtitleFontName
		/// Type: StructProperty
		/// Offset: 0x98
		/// Size: 0x10
		/// </summary>
		public FStringAssetReference SubtitleFontName => ReadStruct<FStringAssetReference>(0x98);
		
		/// <summary>
		/// Name: AdditionalFonts
		/// Type: TArray<UFont>
		/// Offset: 0xA8
		/// Size: 0x10
		/// SubElement Size: 0x1C0
		/// </summary>
		public TArray<UFont> AdditionalFonts => new TArray<UFont>(BaseAddress+0xA8);
		
		/// <summary>
		/// Name: AdditionalFontNames
		/// Type: TArray<>
		/// Offset: 0xC0
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: ConsoleClass
		/// Type: ClassProperty
		/// Offset: 0xD0
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: ConsoleClassName
		/// Type: StructProperty
		/// Offset: 0xD8
		/// Size: 0x10
		/// </summary>
		public FStringClassReference ConsoleClassName => ReadStruct<FStringClassReference>(0xD8);
		
		/// <summary>
		/// Name: GameViewportClientClass
		/// Type: ClassProperty
		/// Offset: 0xE8
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: GameViewportClientClassName
		/// Type: StructProperty
		/// Offset: 0xF0
		/// Size: 0x10
		/// </summary>
		public FStringClassReference GameViewportClientClassName => ReadStruct<FStringClassReference>(0xF0);
		
		/// <summary>
		/// Name: LocalPlayerClass
		/// Type: ClassProperty
		/// Offset: 0x100
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: LocalPlayerClassName
		/// Type: StructProperty
		/// Offset: 0x108
		/// Size: 0x10
		/// </summary>
		public FStringClassReference LocalPlayerClassName => ReadStruct<FStringClassReference>(0x108);
		
		/// <summary>
		/// Name: WorldSettingsClass
		/// Type: ClassProperty
		/// Offset: 0x118
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: WorldSettingsClassName
		/// Type: StructProperty
		/// Offset: 0x120
		/// Size: 0x10
		/// </summary>
		public FStringClassReference WorldSettingsClassName => ReadStruct<FStringClassReference>(0x120);
		
		/// <summary>
		/// Name: NavigationSystemClassName
		/// Type: StructProperty
		/// Offset: 0x130
		/// Size: 0x10
		/// </summary>
		public FStringClassReference NavigationSystemClassName => ReadStruct<FStringClassReference>(0x130);
		
		/// <summary>
		/// Name: NavigationSystemClass
		/// Type: ClassProperty
		/// Offset: 0x140
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: AvoidanceManagerClassName
		/// Type: StructProperty
		/// Offset: 0x148
		/// Size: 0x10
		/// </summary>
		public FStringClassReference AvoidanceManagerClassName => ReadStruct<FStringClassReference>(0x148);
		
		/// <summary>
		/// Name: AvoidanceManagerClass
		/// Type: ClassProperty
		/// Offset: 0x158
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: PhysicsCollisionHandlerClass
		/// Type: ClassProperty
		/// Offset: 0x160
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: PhysicsCollisionHandlerClassName
		/// Type: StructProperty
		/// Offset: 0x168
		/// Size: 0x10
		/// </summary>
		public FStringClassReference PhysicsCollisionHandlerClassName => ReadStruct<FStringClassReference>(0x168);
		
		/// <summary>
		/// Name: GameUserSettingsClassName
		/// Type: StructProperty
		/// Offset: 0x178
		/// Size: 0x10
		/// </summary>
		public FStringClassReference GameUserSettingsClassName => ReadStruct<FStringClassReference>(0x178);
		
		/// <summary>
		/// Name: GameUserSettingsClass
		/// Type: ClassProperty
		/// Offset: 0x188
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: AIControllerClassName
		/// Type: StructProperty
		/// Offset: 0x190
		/// Size: 0x10
		/// </summary>
		public FStringClassReference AIControllerClassName => ReadStruct<FStringClassReference>(0x190);
		
		/// <summary>
		/// Name: GameUserSettings
		/// Type: ObjectProperty
		/// Offset: 0x1A0
		/// Size: 0x08
		/// </summary>
		public UGameUserSettings GameUserSettings => ReadUObject<UGameUserSettings>(0x1A0);
		
		/// <summary>
		/// Name: LevelScriptActorClass
		/// Type: ClassProperty
		/// Offset: 0x1A8
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: LevelScriptActorClassName
		/// Type: StructProperty
		/// Offset: 0x1B0
		/// Size: 0x10
		/// </summary>
		public FStringClassReference LevelScriptActorClassName => ReadStruct<FStringClassReference>(0x1B0);
		
		/// <summary>
		/// Name: DefaultBlueprintBaseClassName
		/// Type: StructProperty
		/// Offset: 0x1C0
		/// Size: 0x10
		/// </summary>
		public FStringClassReference DefaultBlueprintBaseClassName => ReadStruct<FStringClassReference>(0x1C0);
		
		/// <summary>
		/// Name: GameSingletonClassName
		/// Type: StructProperty
		/// Offset: 0x1D0
		/// Size: 0x10
		/// </summary>
		public FStringClassReference GameSingletonClassName => ReadStruct<FStringClassReference>(0x1D0);
		
		/// <summary>
		/// Name: GameSingleton
		/// Type: ObjectProperty
		/// Offset: 0x1E0
		/// Size: 0x08
		/// </summary>
		public UObject GameSingleton => ReadUObject<UObject>(0x1E0);
		
		/// <summary>
		/// Name: DefaultTireType
		/// Type: ObjectProperty
		/// Offset: 0x1E8
		/// Size: 0x08
		/// </summary>
		public UTireType DefaultTireType => ReadUObject<UTireType>(0x1E8);
		
		/// <summary>
		/// Name: DefaultTireTypeName
		/// Type: StructProperty
		/// Offset: 0x1F0
		/// Size: 0x10
		/// </summary>
		public FStringAssetReference DefaultTireTypeName => ReadStruct<FStringAssetReference>(0x1F0);
		
		/// <summary>
		/// Name: PlayOnConsoleSaveDir
		/// Type: StrProperty
		/// Offset: 0x200
		/// Size: 0x10
		/// </summary>
		public FString PlayOnConsoleSaveDir => new FString(BaseAddress+0x200);
		
		/// <summary>
		/// Name: DefaultTexture
		/// Type: ObjectProperty
		/// Offset: 0x210
		/// Size: 0x08
		/// </summary>
		public UTexture2D DefaultTexture => ReadUObject<UTexture2D>(0x210);
		
		/// <summary>
		/// Name: DefaultTextureName
		/// Type: StructProperty
		/// Offset: 0x218
		/// Size: 0x10
		/// </summary>
		public FStringAssetReference DefaultTextureName => ReadStruct<FStringAssetReference>(0x218);
		
		/// <summary>
		/// Name: DefaultDiffuseTexture
		/// Type: ObjectProperty
		/// Offset: 0x228
		/// Size: 0x08
		/// </summary>
		public UTexture DefaultDiffuseTexture => ReadUObject<UTexture>(0x228);
		
		/// <summary>
		/// Name: DefaultDiffuseTextureName
		/// Type: StructProperty
		/// Offset: 0x230
		/// Size: 0x10
		/// </summary>
		public FStringAssetReference DefaultDiffuseTextureName => ReadStruct<FStringAssetReference>(0x230);
		
		/// <summary>
		/// Name: DefaultBSPVertexTexture
		/// Type: ObjectProperty
		/// Offset: 0x240
		/// Size: 0x08
		/// </summary>
		public UTexture2D DefaultBSPVertexTexture => ReadUObject<UTexture2D>(0x240);
		
		/// <summary>
		/// Name: DefaultBSPVertexTextureName
		/// Type: StructProperty
		/// Offset: 0x248
		/// Size: 0x10
		/// </summary>
		public FStringAssetReference DefaultBSPVertexTextureName => ReadStruct<FStringAssetReference>(0x248);
		
		/// <summary>
		/// Name: HighFrequencyNoiseTexture
		/// Type: ObjectProperty
		/// Offset: 0x258
		/// Size: 0x08
		/// </summary>
		public UTexture2D HighFrequencyNoiseTexture => ReadUObject<UTexture2D>(0x258);
		
		/// <summary>
		/// Name: HighFrequencyNoiseTextureName
		/// Type: StructProperty
		/// Offset: 0x260
		/// Size: 0x10
		/// </summary>
		public FStringAssetReference HighFrequencyNoiseTextureName => ReadStruct<FStringAssetReference>(0x260);
		
		/// <summary>
		/// Name: DefaultBokehTexture
		/// Type: ObjectProperty
		/// Offset: 0x270
		/// Size: 0x08
		/// </summary>
		public UTexture2D DefaultBokehTexture => ReadUObject<UTexture2D>(0x270);
		
		/// <summary>
		/// Name: DefaultBokehTextureName
		/// Type: StructProperty
		/// Offset: 0x278
		/// Size: 0x10
		/// </summary>
		public FStringAssetReference DefaultBokehTextureName => ReadStruct<FStringAssetReference>(0x278);
		
		/// <summary>
		/// Name: WireframeMaterial
		/// Type: ObjectProperty
		/// Offset: 0x288
		/// Size: 0x08
		/// </summary>
		public UMaterial WireframeMaterial => ReadUObject<UMaterial>(0x288);
		
		/// <summary>
		/// Name: WireframeMaterialName
		/// Type: StrProperty
		/// Offset: 0x290
		/// Size: 0x10
		/// </summary>
		public FString WireframeMaterialName => new FString(BaseAddress+0x290);
		
		/// <summary>
		/// Name: DebugMeshMaterial
		/// Type: ObjectProperty
		/// Offset: 0x2A0
		/// Size: 0x08
		/// </summary>
		public UMaterial DebugMeshMaterial => ReadUObject<UMaterial>(0x2A0);
		
		/// <summary>
		/// Name: DebugMeshMaterialName
		/// Type: StructProperty
		/// Offset: 0x2A8
		/// Size: 0x10
		/// </summary>
		public FStringAssetReference DebugMeshMaterialName => ReadStruct<FStringAssetReference>(0x2A8);
		
		/// <summary>
		/// Name: LevelColorationLitMaterial
		/// Type: ObjectProperty
		/// Offset: 0x2B8
		/// Size: 0x08
		/// </summary>
		public UMaterial LevelColorationLitMaterial => ReadUObject<UMaterial>(0x2B8);
		
		/// <summary>
		/// Name: LevelColorationLitMaterialName
		/// Type: StrProperty
		/// Offset: 0x2C0
		/// Size: 0x10
		/// </summary>
		public FString LevelColorationLitMaterialName => new FString(BaseAddress+0x2C0);
		
		/// <summary>
		/// Name: LevelColorationUnlitMaterial
		/// Type: ObjectProperty
		/// Offset: 0x2D0
		/// Size: 0x08
		/// </summary>
		public UMaterial LevelColorationUnlitMaterial => ReadUObject<UMaterial>(0x2D0);
		
		/// <summary>
		/// Name: LevelColorationUnlitMaterialName
		/// Type: StrProperty
		/// Offset: 0x2D8
		/// Size: 0x10
		/// </summary>
		public FString LevelColorationUnlitMaterialName => new FString(BaseAddress+0x2D8);
		
		/// <summary>
		/// Name: LightingTexelDensityMaterial
		/// Type: ObjectProperty
		/// Offset: 0x2E8
		/// Size: 0x08
		/// </summary>
		public UMaterial LightingTexelDensityMaterial => ReadUObject<UMaterial>(0x2E8);
		
		/// <summary>
		/// Name: LightingTexelDensityName
		/// Type: StrProperty
		/// Offset: 0x2F0
		/// Size: 0x10
		/// </summary>
		public FString LightingTexelDensityName => new FString(BaseAddress+0x2F0);
		
		/// <summary>
		/// Name: ShadedLevelColorationLitMaterial
		/// Type: ObjectProperty
		/// Offset: 0x300
		/// Size: 0x08
		/// </summary>
		public UMaterial ShadedLevelColorationLitMaterial => ReadUObject<UMaterial>(0x300);
		
		/// <summary>
		/// Name: ShadedLevelColorationLitMaterialName
		/// Type: StrProperty
		/// Offset: 0x308
		/// Size: 0x10
		/// </summary>
		public FString ShadedLevelColorationLitMaterialName => new FString(BaseAddress+0x308);
		
		/// <summary>
		/// Name: ShadedLevelColorationUnlitMaterial
		/// Type: ObjectProperty
		/// Offset: 0x318
		/// Size: 0x08
		/// </summary>
		public UMaterial ShadedLevelColorationUnlitMaterial => ReadUObject<UMaterial>(0x318);
		
		/// <summary>
		/// Name: ShadedLevelColorationUnlitMaterialName
		/// Type: StrProperty
		/// Offset: 0x320
		/// Size: 0x10
		/// </summary>
		public FString ShadedLevelColorationUnlitMaterialName => new FString(BaseAddress+0x320);
		
		/// <summary>
		/// Name: RemoveSurfaceMaterial
		/// Type: ObjectProperty
		/// Offset: 0x330
		/// Size: 0x08
		/// </summary>
		public UMaterial RemoveSurfaceMaterial => ReadUObject<UMaterial>(0x330);
		
		/// <summary>
		/// Name: RemoveSurfaceMaterialName
		/// Type: StructProperty
		/// Offset: 0x338
		/// Size: 0x10
		/// </summary>
		public FStringAssetReference RemoveSurfaceMaterialName => ReadStruct<FStringAssetReference>(0x338);
		
		/// <summary>
		/// Name: VertexColorMaterial
		/// Type: ObjectProperty
		/// Offset: 0x348
		/// Size: 0x08
		/// </summary>
		public UMaterial VertexColorMaterial => ReadUObject<UMaterial>(0x348);
		
		/// <summary>
		/// Name: VertexColorMaterialName
		/// Type: StrProperty
		/// Offset: 0x350
		/// Size: 0x10
		/// </summary>
		public FString VertexColorMaterialName => new FString(BaseAddress+0x350);
		
		/// <summary>
		/// Name: VertexColorViewModeMaterial_ColorOnly
		/// Type: ObjectProperty
		/// Offset: 0x360
		/// Size: 0x08
		/// </summary>
		public UMaterial VertexColorViewModeMaterial_ColorOnly => ReadUObject<UMaterial>(0x360);
		
		/// <summary>
		/// Name: VertexColorViewModeMaterialName_ColorOnly
		/// Type: StrProperty
		/// Offset: 0x368
		/// Size: 0x10
		/// </summary>
		public FString VertexColorViewModeMaterialName_ColorOnly => new FString(BaseAddress+0x368);
		
		/// <summary>
		/// Name: VertexColorViewModeMaterial_AlphaAsColor
		/// Type: ObjectProperty
		/// Offset: 0x378
		/// Size: 0x08
		/// </summary>
		public UMaterial VertexColorViewModeMaterial_AlphaAsColor => ReadUObject<UMaterial>(0x378);
		
		/// <summary>
		/// Name: VertexColorViewModeMaterialName_AlphaAsColor
		/// Type: StrProperty
		/// Offset: 0x380
		/// Size: 0x10
		/// </summary>
		public FString VertexColorViewModeMaterialName_AlphaAsColor => new FString(BaseAddress+0x380);
		
		/// <summary>
		/// Name: VertexColorViewModeMaterial_RedOnly
		/// Type: ObjectProperty
		/// Offset: 0x390
		/// Size: 0x08
		/// </summary>
		public UMaterial VertexColorViewModeMaterial_RedOnly => ReadUObject<UMaterial>(0x390);
		
		/// <summary>
		/// Name: VertexColorViewModeMaterialName_RedOnly
		/// Type: StrProperty
		/// Offset: 0x398
		/// Size: 0x10
		/// </summary>
		public FString VertexColorViewModeMaterialName_RedOnly => new FString(BaseAddress+0x398);
		
		/// <summary>
		/// Name: VertexColorViewModeMaterial_GreenOnly
		/// Type: ObjectProperty
		/// Offset: 0x3A8
		/// Size: 0x08
		/// </summary>
		public UMaterial VertexColorViewModeMaterial_GreenOnly => ReadUObject<UMaterial>(0x3A8);
		
		/// <summary>
		/// Name: VertexColorViewModeMaterialName_GreenOnly
		/// Type: StrProperty
		/// Offset: 0x3B0
		/// Size: 0x10
		/// </summary>
		public FString VertexColorViewModeMaterialName_GreenOnly => new FString(BaseAddress+0x3B0);
		
		/// <summary>
		/// Name: VertexColorViewModeMaterial_BlueOnly
		/// Type: ObjectProperty
		/// Offset: 0x3C0
		/// Size: 0x08
		/// </summary>
		public UMaterial VertexColorViewModeMaterial_BlueOnly => ReadUObject<UMaterial>(0x3C0);
		
		/// <summary>
		/// Name: VertexColorViewModeMaterialName_BlueOnly
		/// Type: StrProperty
		/// Offset: 0x3C8
		/// Size: 0x10
		/// </summary>
		public FString VertexColorViewModeMaterialName_BlueOnly => new FString(BaseAddress+0x3C8);
		
		/// <summary>
		/// Name: ConstraintLimitMaterial
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UMaterial ConstraintLimitMaterial => ReadUObject<UMaterial>(0x3D8);
		
		/// <summary>
		/// Name: ConstraintLimitMaterialX
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UMaterialInstanceDynamic ConstraintLimitMaterialX => ReadUObject<UMaterialInstanceDynamic>(0x3E0);
		
		/// <summary>
		/// Name: ConstraintLimitMaterialY
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UMaterialInstanceDynamic ConstraintLimitMaterialY => ReadUObject<UMaterialInstanceDynamic>(0x3E8);
		
		/// <summary>
		/// Name: ConstraintLimitMaterialZ
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public UMaterialInstanceDynamic ConstraintLimitMaterialZ => ReadUObject<UMaterialInstanceDynamic>(0x3F0);
		
		/// <summary>
		/// Name: ConstraintLimitMaterialPrismatic
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UMaterialInstanceDynamic ConstraintLimitMaterialPrismatic => ReadUObject<UMaterialInstanceDynamic>(0x3F8);
		
		/// <summary>
		/// Name: ConstraintLimitMaterialName
		/// Type: StructProperty
		/// Offset: 0x400
		/// Size: 0x10
		/// </summary>
		public FStringAssetReference ConstraintLimitMaterialName => ReadStruct<FStringAssetReference>(0x400);
		
		/// <summary>
		/// Name: InvalidLightmapSettingsMaterial
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public UMaterial InvalidLightmapSettingsMaterial => ReadUObject<UMaterial>(0x410);
		
		/// <summary>
		/// Name: InvalidLightmapSettingsMaterialName
		/// Type: StructProperty
		/// Offset: 0x418
		/// Size: 0x10
		/// </summary>
		public FStringAssetReference InvalidLightmapSettingsMaterialName => ReadStruct<FStringAssetReference>(0x418);
		
		/// <summary>
		/// Name: PreviewShadowsIndicatorMaterial
		/// Type: ObjectProperty
		/// Offset: 0x428
		/// Size: 0x08
		/// </summary>
		public UMaterial PreviewShadowsIndicatorMaterial => ReadUObject<UMaterial>(0x428);
		
		/// <summary>
		/// Name: PreviewShadowsIndicatorMaterialName
		/// Type: StructProperty
		/// Offset: 0x430
		/// Size: 0x10
		/// </summary>
		public FStringAssetReference PreviewShadowsIndicatorMaterialName => ReadStruct<FStringAssetReference>(0x430);
		
		/// <summary>
		/// Name: ArrowMaterial
		/// Type: ObjectProperty
		/// Offset: 0x440
		/// Size: 0x08
		/// </summary>
		public UMaterial ArrowMaterial => ReadUObject<UMaterial>(0x440);
		
		/// <summary>
		/// Name: ArrowMaterialName
		/// Type: StructProperty
		/// Offset: 0x448
		/// Size: 0x10
		/// </summary>
		public FStringAssetReference ArrowMaterialName => ReadStruct<FStringAssetReference>(0x448);
		
		/// <summary>
		/// Name: LightingOnlyBrightness
		/// Type: StructProperty
		/// Offset: 0x458
		/// Size: 0x10
		/// </summary>
		public FLinearColor LightingOnlyBrightness => ReadStruct<FLinearColor>(0x458);
		
		/// <summary>
		/// Name: ShaderComplexityColors
		/// Type: TArray<FLinearColor>
		/// Offset: 0x468
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FLinearColor> ShaderComplexityColors => new TArray<FLinearColor>(BaseAddress+0x468);
		
		/// <summary>
		/// Name: QuadComplexityColors
		/// Type: TArray<FLinearColor>
		/// Offset: 0x478
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FLinearColor> QuadComplexityColors => new TArray<FLinearColor>(BaseAddress+0x478);
		
		/// <summary>
		/// Name: LightComplexityColors
		/// Type: TArray<FLinearColor>
		/// Offset: 0x488
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FLinearColor> LightComplexityColors => new TArray<FLinearColor>(BaseAddress+0x488);
		
		/// <summary>
		/// Name: StationaryLightOverlapColors
		/// Type: TArray<FLinearColor>
		/// Offset: 0x498
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FLinearColor> StationaryLightOverlapColors => new TArray<FLinearColor>(BaseAddress+0x498);
		
		/// <summary>
		/// Name: LODColorationColors
		/// Type: TArray<FLinearColor>
		/// Offset: 0x4A8
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FLinearColor> LODColorationColors => new TArray<FLinearColor>(BaseAddress+0x4A8);
		
		/// <summary>
		/// Name: HLODColorationColors
		/// Type: TArray<FLinearColor>
		/// Offset: 0x4B8
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FLinearColor> HLODColorationColors => new TArray<FLinearColor>(BaseAddress+0x4B8);
		
		/// <summary>
		/// Name: StreamingAccuracyColors
		/// Type: TArray<FLinearColor>
		/// Offset: 0x4C8
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FLinearColor> StreamingAccuracyColors => new TArray<FLinearColor>(BaseAddress+0x4C8);
		
		/// <summary>
		/// Name: MaxPixelShaderAdditiveComplexityCount
		/// Type: FloatProperty
		/// Offset: 0x4D8
		/// Size: 0x04
		/// </summary>
		public float MaxPixelShaderAdditiveComplexityCount
		{
			get
			{
				return ReadSingle(0x4D8);
			}
			set
			{
				WriteSingle(0x4D8,value);
			}
		}
		
		/// <summary>
		/// Name: MaxES2PixelShaderAdditiveComplexityCount
		/// Type: FloatProperty
		/// Offset: 0x4DC
		/// Size: 0x04
		/// </summary>
		public float MaxES2PixelShaderAdditiveComplexityCount
		{
			get
			{
				return ReadSingle(0x4DC);
			}
			set
			{
				WriteSingle(0x4DC,value);
			}
		}
		
		/// <summary>
		/// Name: MinLightMapDensity
		/// Type: FloatProperty
		/// Offset: 0x4E0
		/// Size: 0x04
		/// </summary>
		public float MinLightMapDensity
		{
			get
			{
				return ReadSingle(0x4E0);
			}
			set
			{
				WriteSingle(0x4E0,value);
			}
		}
		
		/// <summary>
		/// Name: IdealLightMapDensity
		/// Type: FloatProperty
		/// Offset: 0x4E4
		/// Size: 0x04
		/// </summary>
		public float IdealLightMapDensity
		{
			get
			{
				return ReadSingle(0x4E4);
			}
			set
			{
				WriteSingle(0x4E4,value);
			}
		}
		
		/// <summary>
		/// Name: MaxLightMapDensity
		/// Type: FloatProperty
		/// Offset: 0x4E8
		/// Size: 0x04
		/// </summary>
		public float MaxLightMapDensity
		{
			get
			{
				return ReadSingle(0x4E8);
			}
			set
			{
				WriteSingle(0x4E8,value);
			}
		}
		
		/// <summary>
		/// Name: bRenderLightMapDensityGrayscale
		/// Type: BoolProperty
		/// Offset: 0x4EC
		/// Size: 0x01
		/// </summary>
		public bool bRenderLightMapDensityGrayscale => (ReadByte(0x04EC) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: RenderLightMapDensityGrayscaleScale
		/// Type: FloatProperty
		/// Offset: 0x4F0
		/// Size: 0x04
		/// </summary>
		public float RenderLightMapDensityGrayscaleScale
		{
			get
			{
				return ReadSingle(0x4F0);
			}
			set
			{
				WriteSingle(0x4F0,value);
			}
		}
		
		/// <summary>
		/// Name: RenderLightMapDensityColorScale
		/// Type: FloatProperty
		/// Offset: 0x4F4
		/// Size: 0x04
		/// </summary>
		public float RenderLightMapDensityColorScale
		{
			get
			{
				return ReadSingle(0x4F4);
			}
			set
			{
				WriteSingle(0x4F4,value);
			}
		}
		
		/// <summary>
		/// Name: LightMapDensityVertexMappedColor
		/// Type: StructProperty
		/// Offset: 0x4F8
		/// Size: 0x10
		/// </summary>
		public FLinearColor LightMapDensityVertexMappedColor => ReadStruct<FLinearColor>(0x4F8);
		
		/// <summary>
		/// Name: LightMapDensitySelectedColor
		/// Type: StructProperty
		/// Offset: 0x508
		/// Size: 0x10
		/// </summary>
		public FLinearColor LightMapDensitySelectedColor => ReadStruct<FLinearColor>(0x508);
		
		/// <summary>
		/// Name: StatColorMappings
		/// Type: TArray<FStatColorMapping>
		/// Offset: 0x518
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<FStatColorMapping> StatColorMappings => new TArray<FStatColorMapping>(BaseAddress+0x518);
		
		/// <summary>
		/// Name: DefaultPhysMaterial
		/// Type: ObjectProperty
		/// Offset: 0x528
		/// Size: 0x08
		/// </summary>
		public UPhysicalMaterial DefaultPhysMaterial => ReadUObject<UPhysicalMaterial>(0x528);
		
		/// <summary>
		/// Name: DefaultPhysMaterialName
		/// Type: StructProperty
		/// Offset: 0x530
		/// Size: 0x10
		/// </summary>
		public FStringAssetReference DefaultPhysMaterialName => ReadStruct<FStringAssetReference>(0x530);
		
		/// <summary>
		/// Name: ActiveGameNameRedirects
		/// Type: TArray<FGameNameRedirect>
		/// Offset: 0x540
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FGameNameRedirect> ActiveGameNameRedirects => new TArray<FGameNameRedirect>(BaseAddress+0x540);
		
		/// <summary>
		/// Name: ActiveClassRedirects
		/// Type: TArray<FClassRedirect>
		/// Offset: 0x550
		/// Size: 0x10
		/// SubElement Size: 0x40
		/// </summary>
		public TArray<FClassRedirect> ActiveClassRedirects => new TArray<FClassRedirect>(BaseAddress+0x550);
		
		/// <summary>
		/// Name: ActivePluginRedirects
		/// Type: TArray<FPluginRedirect>
		/// Offset: 0x560
		/// Size: 0x10
		/// SubElement Size: 0x20
		/// </summary>
		public TArray<FPluginRedirect> ActivePluginRedirects => new TArray<FPluginRedirect>(BaseAddress+0x560);
		
		/// <summary>
		/// Name: ActiveStructRedirects
		/// Type: TArray<FStructRedirect>
		/// Offset: 0x570
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FStructRedirect> ActiveStructRedirects => new TArray<FStructRedirect>(BaseAddress+0x570);
		
		/// <summary>
		/// Name: PreIntegratedSkinBRDFTexture
		/// Type: ObjectProperty
		/// Offset: 0x580
		/// Size: 0x08
		/// </summary>
		public UTexture2D PreIntegratedSkinBRDFTexture => ReadUObject<UTexture2D>(0x580);
		
		/// <summary>
		/// Name: PreIntegratedSkinBRDFTextureName
		/// Type: StructProperty
		/// Offset: 0x588
		/// Size: 0x10
		/// </summary>
		public FStringAssetReference PreIntegratedSkinBRDFTextureName => ReadStruct<FStringAssetReference>(0x588);
		
		/// <summary>
		/// Name: MiniFontTexture
		/// Type: ObjectProperty
		/// Offset: 0x598
		/// Size: 0x08
		/// </summary>
		public UTexture2D MiniFontTexture => ReadUObject<UTexture2D>(0x598);
		
		/// <summary>
		/// Name: MiniFontTextureName
		/// Type: StructProperty
		/// Offset: 0x5A0
		/// Size: 0x10
		/// </summary>
		public FStringAssetReference MiniFontTextureName => ReadStruct<FStringAssetReference>(0x5A0);
		
		/// <summary>
		/// Name: WeightMapPlaceholderTexture
		/// Type: ObjectProperty
		/// Offset: 0x5B0
		/// Size: 0x08
		/// </summary>
		public UTexture WeightMapPlaceholderTexture => ReadUObject<UTexture>(0x5B0);
		
		/// <summary>
		/// Name: WeightMapPlaceholderTextureName
		/// Type: StructProperty
		/// Offset: 0x5B8
		/// Size: 0x10
		/// </summary>
		public FStringAssetReference WeightMapPlaceholderTextureName => ReadStruct<FStringAssetReference>(0x5B8);
		
		/// <summary>
		/// Name: LightMapDensityTexture
		/// Type: ObjectProperty
		/// Offset: 0x5C8
		/// Size: 0x08
		/// </summary>
		public UTexture2D LightMapDensityTexture => ReadUObject<UTexture2D>(0x5C8);
		
		/// <summary>
		/// Name: LightMapDensityTextureName
		/// Type: StructProperty
		/// Offset: 0x5D0
		/// Size: 0x10
		/// </summary>
		public FStringAssetReference LightMapDensityTextureName => ReadStruct<FStringAssetReference>(0x5D0);
		
		/// <summary>
		/// Name: GameViewport
		/// Type: ObjectProperty
		/// Offset: 0x5E8
		/// Size: 0x08
		/// </summary>
		public UGameViewportClient GameViewport => ReadUObject<UGameViewportClient>(0x5E8);
		
		/// <summary>
		/// Name: DeferredCommands
		/// Type: TArray<>
		/// Offset: 0x5F0
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: TickCycles
		/// Type: IntProperty
		/// Offset: 0x600
		/// Size: 0x04
		/// </summary>
		public int TickCycles
		{
			get
			{
				return ReadInt32(0x600);
			}
			set
			{
				WriteInt32(0x600,value);
			}
		}
		
		/// <summary>
		/// Name: GameCycles
		/// Type: IntProperty
		/// Offset: 0x604
		/// Size: 0x04
		/// </summary>
		public int GameCycles
		{
			get
			{
				return ReadInt32(0x604);
			}
			set
			{
				WriteInt32(0x604,value);
			}
		}
		
		/// <summary>
		/// Name: ClientCycles
		/// Type: IntProperty
		/// Offset: 0x608
		/// Size: 0x04
		/// </summary>
		public int ClientCycles
		{
			get
			{
				return ReadInt32(0x608);
			}
			set
			{
				WriteInt32(0x608,value);
			}
		}
		
		/// <summary>
		/// Name: NearClipPlane
		/// Type: FloatProperty
		/// Offset: 0x60C
		/// Size: 0x04
		/// </summary>
		public float NearClipPlane
		{
			get
			{
				return ReadSingle(0x60C);
			}
			set
			{
				WriteSingle(0x60C,value);
			}
		}
		
		/// <summary>
		/// Name: bHardwareSurveyEnabled
		/// Type: BoolProperty
		/// Offset: 0x610
		/// Size: 0x01
		/// </summary>
		public bool bHardwareSurveyEnabled => (ReadByte(0x0610) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bSubtitlesEnabled
		/// Type: BoolProperty
		/// Offset: 0x610
		/// Size: 0x01
		/// </summary>
		public bool bSubtitlesEnabled => (ReadByte(0x0610) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bSubtitlesForcedOff
		/// Type: BoolProperty
		/// Offset: 0x610
		/// Size: 0x01
		/// </summary>
		public bool bSubtitlesForcedOff => (ReadByte(0x0610) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: MaximumLoopIterationCount
		/// Type: IntProperty
		/// Offset: 0x614
		/// Size: 0x04
		/// </summary>
		public int MaximumLoopIterationCount
		{
			get
			{
				return ReadInt32(0x614);
			}
			set
			{
				WriteInt32(0x614,value);
			}
		}
		
		/// <summary>
		/// Name: bCanBlueprintsTickByDefault
		/// Type: BoolProperty
		/// Offset: 0x618
		/// Size: 0x01
		/// </summary>
		public bool bCanBlueprintsTickByDefault => (ReadByte(0x0618) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bOptimizeAnimBlueprintMemberVariableAccess
		/// Type: BoolProperty
		/// Offset: 0x618
		/// Size: 0x01
		/// </summary>
		public bool bOptimizeAnimBlueprintMemberVariableAccess => (ReadByte(0x0618) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bEnableEditorPSysRealtimeLOD
		/// Type: BoolProperty
		/// Offset: 0x618
		/// Size: 0x01
		/// </summary>
		public bool bEnableEditorPSysRealtimeLOD => (ReadByte(0x0618) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bSmoothFrameRate
		/// Type: BoolProperty
		/// Offset: 0x618
		/// Size: 0x01
		/// </summary>
		public bool bSmoothFrameRate => (ReadByte(0x0618) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bUseFixedFrameRate
		/// Type: BoolProperty
		/// Offset: 0x618
		/// Size: 0x01
		/// </summary>
		public bool bUseFixedFrameRate => (ReadByte(0x0618) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: FixedFrameRate
		/// Type: FloatProperty
		/// Offset: 0x61C
		/// Size: 0x04
		/// </summary>
		public float FixedFrameRate
		{
			get
			{
				return ReadSingle(0x61C);
			}
			set
			{
				WriteSingle(0x61C,value);
			}
		}
		
		/// <summary>
		/// Name: SmoothedFrameRateRange
		/// Type: StructProperty
		/// Offset: 0x620
		/// Size: 0x10
		/// </summary>
		public FFloatRange SmoothedFrameRateRange => ReadStruct<FFloatRange>(0x620);
		
		/// <summary>
		/// Name: bCheckForMultiplePawnsSpawnedInAFrame
		/// Type: BoolProperty
		/// Offset: 0x630
		/// Size: 0x01
		/// </summary>
		public bool bCheckForMultiplePawnsSpawnedInAFrame => (ReadByte(0x0630) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: NumPawnsAllowedToBeSpawnedInAFrame
		/// Type: IntProperty
		/// Offset: 0x634
		/// Size: 0x04
		/// </summary>
		public int NumPawnsAllowedToBeSpawnedInAFrame
		{
			get
			{
				return ReadInt32(0x634);
			}
			set
			{
				WriteInt32(0x634,value);
			}
		}
		
		/// <summary>
		/// Name: bShouldGenerateLowQualityLightmaps
		/// Type: BoolProperty
		/// Offset: 0x638
		/// Size: 0x01
		/// </summary>
		public bool bShouldGenerateLowQualityLightmaps => (ReadByte(0x0638) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: C_WorldBox
		/// Type: StructProperty
		/// Offset: 0x63C
		/// Size: 0x04
		/// </summary>
		public FColor C_WorldBox => ReadStruct<FColor>(0x63C);
		
		/// <summary>
		/// Name: C_BrushWire
		/// Type: StructProperty
		/// Offset: 0x640
		/// Size: 0x04
		/// </summary>
		public FColor C_BrushWire => ReadStruct<FColor>(0x640);
		
		/// <summary>
		/// Name: C_AddWire
		/// Type: StructProperty
		/// Offset: 0x644
		/// Size: 0x04
		/// </summary>
		public FColor C_AddWire => ReadStruct<FColor>(0x644);
		
		/// <summary>
		/// Name: C_SubtractWire
		/// Type: StructProperty
		/// Offset: 0x648
		/// Size: 0x04
		/// </summary>
		public FColor C_SubtractWire => ReadStruct<FColor>(0x648);
		
		/// <summary>
		/// Name: C_SemiSolidWire
		/// Type: StructProperty
		/// Offset: 0x64C
		/// Size: 0x04
		/// </summary>
		public FColor C_SemiSolidWire => ReadStruct<FColor>(0x64C);
		
		/// <summary>
		/// Name: C_NonSolidWire
		/// Type: StructProperty
		/// Offset: 0x650
		/// Size: 0x04
		/// </summary>
		public FColor C_NonSolidWire => ReadStruct<FColor>(0x650);
		
		/// <summary>
		/// Name: C_WireBackground
		/// Type: StructProperty
		/// Offset: 0x654
		/// Size: 0x04
		/// </summary>
		public FColor C_WireBackground => ReadStruct<FColor>(0x654);
		
		/// <summary>
		/// Name: C_ScaleBoxHi
		/// Type: StructProperty
		/// Offset: 0x658
		/// Size: 0x04
		/// </summary>
		public FColor C_ScaleBoxHi => ReadStruct<FColor>(0x658);
		
		/// <summary>
		/// Name: C_VolumeCollision
		/// Type: StructProperty
		/// Offset: 0x65C
		/// Size: 0x04
		/// </summary>
		public FColor C_VolumeCollision => ReadStruct<FColor>(0x65C);
		
		/// <summary>
		/// Name: C_BSPCollision
		/// Type: StructProperty
		/// Offset: 0x660
		/// Size: 0x04
		/// </summary>
		public FColor C_BSPCollision => ReadStruct<FColor>(0x660);
		
		/// <summary>
		/// Name: C_OrthoBackground
		/// Type: StructProperty
		/// Offset: 0x664
		/// Size: 0x04
		/// </summary>
		public FColor C_OrthoBackground => ReadStruct<FColor>(0x664);
		
		/// <summary>
		/// Name: C_Volume
		/// Type: StructProperty
		/// Offset: 0x668
		/// Size: 0x04
		/// </summary>
		public FColor C_Volume => ReadStruct<FColor>(0x668);
		
		/// <summary>
		/// Name: C_BrushShape
		/// Type: StructProperty
		/// Offset: 0x66C
		/// Size: 0x04
		/// </summary>
		public FColor C_BrushShape => ReadStruct<FColor>(0x66C);
		
		/// <summary>
		/// Name: StreamingDistanceFactor
		/// Type: FloatProperty
		/// Offset: 0x670
		/// Size: 0x04
		/// </summary>
		public float StreamingDistanceFactor
		{
			get
			{
				return ReadSingle(0x670);
			}
			set
			{
				WriteSingle(0x670,value);
			}
		}
		
		/// <summary>
		/// Name: TransitionType
		/// Type: ByteProperty
		/// Offset: 0x674
		/// Size: 0x01
		/// </summary>
		public byte TransitionType
		{
			get
			{
				return ReadByte(0x674);
			}
			set
			{
				WriteByte(0x674,value);
			}
		}
		
		/// <summary>
		/// Name: TransitionDescription
		/// Type: StrProperty
		/// Offset: 0x678
		/// Size: 0x10
		/// </summary>
		public FString TransitionDescription => new FString(BaseAddress+0x678);
		
		/// <summary>
		/// Name: TransitionGameMode
		/// Type: StrProperty
		/// Offset: 0x688
		/// Size: 0x10
		/// </summary>
		public FString TransitionGameMode => new FString(BaseAddress+0x688);
		
		/// <summary>
		/// Name: MeshLODRange
		/// Type: FloatProperty
		/// Offset: 0x698
		/// Size: 0x04
		/// </summary>
		public float MeshLODRange
		{
			get
			{
				return ReadSingle(0x698);
			}
			set
			{
				WriteSingle(0x698,value);
			}
		}
		
		/// <summary>
		/// Name: bAllowMatureLanguage
		/// Type: BoolProperty
		/// Offset: 0x69C
		/// Size: 0x01
		/// </summary>
		public bool bAllowMatureLanguage => (ReadByte(0x069C) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: CameraRotationThreshold
		/// Type: FloatProperty
		/// Offset: 0x6A0
		/// Size: 0x04
		/// </summary>
		public float CameraRotationThreshold
		{
			get
			{
				return ReadSingle(0x6A0);
			}
			set
			{
				WriteSingle(0x6A0,value);
			}
		}
		
		/// <summary>
		/// Name: CameraTranslationThreshold
		/// Type: FloatProperty
		/// Offset: 0x6A4
		/// Size: 0x04
		/// </summary>
		public float CameraTranslationThreshold
		{
			get
			{
				return ReadSingle(0x6A4);
			}
			set
			{
				WriteSingle(0x6A4,value);
			}
		}
		
		/// <summary>
		/// Name: PrimitiveProbablyVisibleTime
		/// Type: FloatProperty
		/// Offset: 0x6A8
		/// Size: 0x04
		/// </summary>
		public float PrimitiveProbablyVisibleTime
		{
			get
			{
				return ReadSingle(0x6A8);
			}
			set
			{
				WriteSingle(0x6A8,value);
			}
		}
		
		/// <summary>
		/// Name: MaxOcclusionPixelsFraction
		/// Type: FloatProperty
		/// Offset: 0x6AC
		/// Size: 0x04
		/// </summary>
		public float MaxOcclusionPixelsFraction
		{
			get
			{
				return ReadSingle(0x6AC);
			}
			set
			{
				WriteSingle(0x6AC,value);
			}
		}
		
		/// <summary>
		/// Name: bPauseOnLossOfFocus
		/// Type: BoolProperty
		/// Offset: 0x6B0
		/// Size: 0x01
		/// </summary>
		public bool bPauseOnLossOfFocus => (ReadByte(0x06B0) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: MaxParticleResize
		/// Type: IntProperty
		/// Offset: 0x6B4
		/// Size: 0x04
		/// </summary>
		public int MaxParticleResize
		{
			get
			{
				return ReadInt32(0x6B4);
			}
			set
			{
				WriteInt32(0x6B4,value);
			}
		}
		
		/// <summary>
		/// Name: MaxParticleResizeWarn
		/// Type: IntProperty
		/// Offset: 0x6B8
		/// Size: 0x04
		/// </summary>
		public int MaxParticleResizeWarn
		{
			get
			{
				return ReadInt32(0x6B8);
			}
			set
			{
				WriteInt32(0x6B8,value);
			}
		}
		
		/// <summary>
		/// Name: PendingDroppedNotes
		/// Type: TArray<FDropNoteInfo>
		/// Offset: 0x6C0
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<FDropNoteInfo> PendingDroppedNotes => new TArray<FDropNoteInfo>(BaseAddress+0x6C0);
		
		/// <summary>
		/// Name: PhysicErrorCorrection
		/// Type: StructProperty
		/// Offset: 0x6D0
		/// Size: 0x1C
		/// </summary>
		public FRigidBodyErrorCorrection PhysicErrorCorrection => ReadStruct<FRigidBodyErrorCorrection>(0x6D0);
		
		/// <summary>
		/// Name: NetClientTicksPerSecond
		/// Type: FloatProperty
		/// Offset: 0x6EC
		/// Size: 0x04
		/// </summary>
		public float NetClientTicksPerSecond
		{
			get
			{
				return ReadSingle(0x6EC);
			}
			set
			{
				WriteSingle(0x6EC,value);
			}
		}
		
		/// <summary>
		/// Name: DisplayGamma
		/// Type: FloatProperty
		/// Offset: 0x6F0
		/// Size: 0x04
		/// </summary>
		public float DisplayGamma
		{
			get
			{
				return ReadSingle(0x6F0);
			}
			set
			{
				WriteSingle(0x6F0,value);
			}
		}
		
		/// <summary>
		/// Name: MinDesiredFrameRate
		/// Type: FloatProperty
		/// Offset: 0x6F4
		/// Size: 0x04
		/// </summary>
		public float MinDesiredFrameRate
		{
			get
			{
				return ReadSingle(0x6F4);
			}
			set
			{
				WriteSingle(0x6F4,value);
			}
		}
		
		/// <summary>
		/// Name: DefaultSelectedMaterialColor
		/// Type: StructProperty
		/// Offset: 0x6F8
		/// Size: 0x10
		/// </summary>
		public FLinearColor DefaultSelectedMaterialColor => ReadStruct<FLinearColor>(0x6F8);
		
		/// <summary>
		/// Name: SelectedMaterialColor
		/// Type: StructProperty
		/// Offset: 0x708
		/// Size: 0x10
		/// </summary>
		public FLinearColor SelectedMaterialColor => ReadStruct<FLinearColor>(0x708);
		
		/// <summary>
		/// Name: SelectionOutlineColor
		/// Type: StructProperty
		/// Offset: 0x718
		/// Size: 0x10
		/// </summary>
		public FLinearColor SelectionOutlineColor => ReadStruct<FLinearColor>(0x718);
		
		/// <summary>
		/// Name: SubduedSelectionOutlineColor
		/// Type: StructProperty
		/// Offset: 0x728
		/// Size: 0x10
		/// </summary>
		public FLinearColor SubduedSelectionOutlineColor => ReadStruct<FLinearColor>(0x728);
		
		/// <summary>
		/// Name: SelectedMaterialColorOverride
		/// Type: StructProperty
		/// Offset: 0x738
		/// Size: 0x10
		/// </summary>
		public FLinearColor SelectedMaterialColorOverride => ReadStruct<FLinearColor>(0x738);
		
		/// <summary>
		/// Name: bIsOverridingSelectedColor
		/// Type: BoolProperty
		/// Offset: 0x748
		/// Size: 0x01
		/// </summary>
		public bool bIsOverridingSelectedColor
		{
			get
			{
				return ReadBool(0x748);
			}
			set
			{
				WriteBool(0x748,value);
			}
		}
		
		/// <summary>
		/// Name: bEnableOnScreenDebugMessages
		/// Type: BoolProperty
		/// Offset: 0x74C
		/// Size: 0x01
		/// </summary>
		public bool bEnableOnScreenDebugMessages => (ReadByte(0x074C) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bEnableOnScreenDebugMessagesDisplay
		/// Type: BoolProperty
		/// Offset: 0x74C
		/// Size: 0x01
		/// </summary>
		public bool bEnableOnScreenDebugMessagesDisplay => (ReadByte(0x074C) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bSuppressMapWarnings
		/// Type: BoolProperty
		/// Offset: 0x74C
		/// Size: 0x01
		/// </summary>
		public bool bSuppressMapWarnings => (ReadByte(0x074C) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bCookSeparateSharedMPGameContent
		/// Type: BoolProperty
		/// Offset: 0x74C
		/// Size: 0x01
		/// </summary>
		public bool bCookSeparateSharedMPGameContent => (ReadByte(0x074C) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bDisableAILogging
		/// Type: BoolProperty
		/// Offset: 0x74C
		/// Size: 0x01
		/// </summary>
		public bool bDisableAILogging => (ReadByte(0x074C) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bEnableVisualLogRecordingOnStart
		/// Type: UInt32Property
		/// Offset: 0x750
		/// Size: 0x04
		/// </summary>
		
		/// <summary>
		/// Name: ScreenSaverInhibitorSemaphore
		/// Type: IntProperty
		/// Offset: 0x758
		/// Size: 0x04
		/// </summary>
		public int ScreenSaverInhibitorSemaphore
		{
			get
			{
				return ReadInt32(0x758);
			}
			set
			{
				WriteInt32(0x758,value);
			}
		}
		
		/// <summary>
		/// Name: bLockReadOnlyLevels
		/// Type: BoolProperty
		/// Offset: 0x75C
		/// Size: 0x01
		/// </summary>
		public bool bLockReadOnlyLevels => (ReadByte(0x075C) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: ParticleEventManagerClassPath
		/// Type: StrProperty
		/// Offset: 0x760
		/// Size: 0x10
		/// </summary>
		public FString ParticleEventManagerClassPath => new FString(BaseAddress+0x760);
		
		/// <summary>
		/// Name: SelectionHighlightIntensity
		/// Type: FloatProperty
		/// Offset: 0x780
		/// Size: 0x04
		/// </summary>
		public float SelectionHighlightIntensity
		{
			get
			{
				return ReadSingle(0x780);
			}
			set
			{
				WriteSingle(0x780,value);
			}
		}
		
		/// <summary>
		/// Name: BSPSelectionHighlightIntensity
		/// Type: FloatProperty
		/// Offset: 0x784
		/// Size: 0x04
		/// </summary>
		public float BSPSelectionHighlightIntensity
		{
			get
			{
				return ReadSingle(0x784);
			}
			set
			{
				WriteSingle(0x784,value);
			}
		}
		
		/// <summary>
		/// Name: HoverHighlightIntensity
		/// Type: FloatProperty
		/// Offset: 0x788
		/// Size: 0x04
		/// </summary>
		public float HoverHighlightIntensity
		{
			get
			{
				return ReadSingle(0x788);
			}
			set
			{
				WriteSingle(0x788,value);
			}
		}
		
		/// <summary>
		/// Name: SelectionHighlightIntensityBillboards
		/// Type: FloatProperty
		/// Offset: 0x78C
		/// Size: 0x04
		/// </summary>
		public float SelectionHighlightIntensityBillboards
		{
			get
			{
				return ReadSingle(0x78C);
			}
			set
			{
				WriteSingle(0x78C,value);
			}
		}
		
		/// <summary>
		/// Name: NetDriverDefinitions
		/// Type: TArray<FNetDriverDefinition>
		/// Offset: 0xB40
		/// Size: 0x10
		/// SubElement Size: 0x18
		/// </summary>
		public TArray<FNetDriverDefinition> NetDriverDefinitions => new TArray<FNetDriverDefinition>(BaseAddress+0xB40);
		
		/// <summary>
		/// Name: ServerActors
		/// Type: TArray<>
		/// Offset: 0xB50
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: RuntimeServerActors
		/// Type: TArray<>
		/// Offset: 0xB60
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: bStartedLoadMapMovie
		/// Type: BoolProperty
		/// Offset: 0xB70
		/// Size: 0x01
		/// </summary>
		public bool bStartedLoadMapMovie => (ReadByte(0x0B70) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: NextWorldContextHandle
		/// Type: IntProperty
		/// Offset: 0xB88
		/// Size: 0x04
		/// </summary>
		public int NextWorldContextHandle
		{
			get
			{
				return ReadInt32(0xB88);
			}
			set
			{
				WriteInt32(0xB88,value);
			}
		}
		
	}


	/// <summary>
	/// UScriptViewportClient:UObject
	/// Size: 0x30
	/// Properties: 0
	/// </summary>
	public class UScriptViewportClient:UObject
	{
		public override int ObjectSize => 48;
	}


	/// <summary>
	/// UGameViewportClient:UScriptViewportClient
	/// Size: 0x450
	/// Properties: 4
	/// </summary>
	public class UGameViewportClient:UScriptViewportClient
	{
		public override int ObjectSize => 1104;
		/// <summary>
		/// Name: ViewportConsole
		/// Type: ObjectProperty
		/// Offset: 0x38
		/// Size: 0x08
		/// </summary>
		public UConsole ViewportConsole => ReadUObject<UConsole>(0x38);
		
		/// <summary>
		/// Name: DebugProperties
		/// Type: TArray<FDebugDisplayProperty>
		/// Offset: 0x40
		/// Size: 0x10
		/// SubElement Size: 0x20
		/// </summary>
		public TArray<FDebugDisplayProperty> DebugProperties => new TArray<FDebugDisplayProperty>(BaseAddress+0x40);
		
		/// <summary>
		/// Name: World
		/// Type: ObjectProperty
		/// Offset: 0x80
		/// Size: 0x08
		/// </summary>
		public UWorld World => ReadUObject<UWorld>(0x80);
		
		/// <summary>
		/// Name: GameInstance
		/// Type: ObjectProperty
		/// Offset: 0x88
		/// Size: 0x08
		/// </summary>
		public UGameInstance GameInstance => ReadUObject<UGameInstance>(0x88);
		
	}


	/// <summary>
	/// UConanGameViewportClient:UGameViewportClient
	/// Size: 0x450
	/// Properties: 0
	/// </summary>
	public class UConanGameViewportClient:UGameViewportClient
	{
		public override int ObjectSize => 1104;
	}


	/// <summary>
	/// AHUD:AActor
	/// Size: 0x4D0
	/// Properties: 21
	/// </summary>
	public class AHUD:AActor
	{
		public override int ObjectSize => 1232;
		/// <summary>
		/// Name: WhiteColor
		/// Type: StructProperty
		/// Offset: 0x3D0
		/// Size: 0x04
		/// </summary>
		public FColor WhiteColor => ReadStruct<FColor>(0x3D0);
		
		/// <summary>
		/// Name: GreenColor
		/// Type: StructProperty
		/// Offset: 0x3D4
		/// Size: 0x04
		/// </summary>
		public FColor GreenColor => ReadStruct<FColor>(0x3D4);
		
		/// <summary>
		/// Name: RedColor
		/// Type: StructProperty
		/// Offset: 0x3D8
		/// Size: 0x04
		/// </summary>
		public FColor RedColor => ReadStruct<FColor>(0x3D8);
		
		/// <summary>
		/// Name: PlayerOwner
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public APlayerController PlayerOwner => ReadUObject<APlayerController>(0x3E0);
		
		/// <summary>
		/// Name: bLostFocusPaused
		/// Type: BoolProperty
		/// Offset: 0x3E8
		/// Size: 0x01
		/// </summary>
		public bool bLostFocusPaused => (ReadByte(0x03E8) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bShowHUD
		/// Type: BoolProperty
		/// Offset: 0x3E8
		/// Size: 0x01
		/// </summary>
		public bool bShowHUD => (ReadByte(0x03E8) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bShowDebugInfo
		/// Type: BoolProperty
		/// Offset: 0x3E8
		/// Size: 0x01
		/// </summary>
		public bool bShowDebugInfo => (ReadByte(0x03E8) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bShowHitBoxDebugInfo
		/// Type: BoolProperty
		/// Offset: 0x3E8
		/// Size: 0x01
		/// </summary>
		public bool bShowHitBoxDebugInfo => (ReadByte(0x03E8) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bShowOverlays
		/// Type: BoolProperty
		/// Offset: 0x3E8
		/// Size: 0x01
		/// </summary>
		public bool bShowOverlays => (ReadByte(0x03E8) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bEnableDebugTextShadow
		/// Type: BoolProperty
		/// Offset: 0x3E8
		/// Size: 0x01
		/// </summary>
		public bool bEnableDebugTextShadow => (ReadByte(0x03E8) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: PostRenderedActors
		/// Type: TArray<AActor>
		/// Offset: 0x3F0
		/// Size: 0x10
		/// SubElement Size: 0x3D0
		/// </summary>
		public TArray<AActor> PostRenderedActors => new TArray<AActor>(BaseAddress+0x3F0);
		
		/// <summary>
		/// Name: LastHUDRenderTime
		/// Type: FloatProperty
		/// Offset: 0x400
		/// Size: 0x04
		/// </summary>
		public float LastHUDRenderTime
		{
			get
			{
				return ReadSingle(0x400);
			}
			set
			{
				WriteSingle(0x400,value);
			}
		}
		
		/// <summary>
		/// Name: RenderDelta
		/// Type: FloatProperty
		/// Offset: 0x404
		/// Size: 0x04
		/// </summary>
		public float RenderDelta
		{
			get
			{
				return ReadSingle(0x404);
			}
			set
			{
				WriteSingle(0x404,value);
			}
		}
		
		/// <summary>
		/// Name: DebugDisplay
		/// Type: TArray<FName>
		/// Offset: 0x408
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		public TArray<FName> DebugDisplay => new TArray<FName>(BaseAddress+0x408);
		
		/// <summary>
		/// Name: ToggledDebugCategories
		/// Type: TArray<FName>
		/// Offset: 0x418
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		public TArray<FName> ToggledDebugCategories => new TArray<FName>(BaseAddress+0x418);
		
		/// <summary>
		/// Name: Canvas
		/// Type: ObjectProperty
		/// Offset: 0x428
		/// Size: 0x08
		/// </summary>
		public UCanvas Canvas => ReadUObject<UCanvas>(0x428);
		
		/// <summary>
		/// Name: DebugCanvas
		/// Type: ObjectProperty
		/// Offset: 0x430
		/// Size: 0x08
		/// </summary>
		public UCanvas DebugCanvas => ReadUObject<UCanvas>(0x430);
		
		/// <summary>
		/// Name: DebugTextList
		/// Type: TArray<FDebugTextInfo>
		/// Offset: 0x438
		/// Size: 0x10
		/// SubElement Size: 0x60
		/// </summary>
		public TArray<FDebugTextInfo> DebugTextList => new TArray<FDebugTextInfo>(BaseAddress+0x438);
		
		/// <summary>
		/// Name: bShowDebugForReticleTarget
		/// Type: BoolProperty
		/// Offset: 0x448
		/// Size: 0x01
		/// </summary>
		public bool bShowDebugForReticleTarget
		{
			get
			{
				return ReadBool(0x448);
			}
			set
			{
				WriteBool(0x448,value);
			}
		}
		
		/// <summary>
		/// Name: ShowDebugTargetDesiredClass
		/// Type: ClassProperty
		/// Offset: 0x450
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: ShowDebugTargetActor
		/// Type: ObjectProperty
		/// Offset: 0x458
		/// Size: 0x08
		/// </summary>
		public AActor ShowDebugTargetActor => ReadUObject<AActor>(0x458);
		
	}


	/// <summary>
	/// AConanHUD:AHUD
	/// Size: 0x4E8
	/// Properties: 1
	/// </summary>
	public class AConanHUD:AHUD
	{
		public override int ObjectSize => 1256;
		/// <summary>
		/// Name: LoadingScreenText
		/// Type: TextProperty
		/// Offset: 0x4D0
		/// Size: 0x18
		/// </summary>
		
	}


	/// <summary>
	/// ALevelScriptActor:AActor
	/// Size: 0x3D8
	/// Properties: 1
	/// </summary>
	public class ALevelScriptActor:AActor
	{
		public override int ObjectSize => 984;
		/// <summary>
		/// Name: bInputEnabled
		/// Type: BoolProperty
		/// Offset: 0x3D0
		/// Size: 0x01
		/// </summary>
		public bool bInputEnabled => (ReadByte(0x03D0) & 0x01) == 0x01;
		
	}


	/// <summary>
	/// ADWLevelScriptActor:ALevelScriptActor
	/// Size: 0x3D8
	/// Properties: 0
	/// </summary>
	public class ADWLevelScriptActor:ALevelScriptActor
	{
		public override int ObjectSize => 984;
	}


	/// <summary>
	/// AConanLevelScriptActor:ADWLevelScriptActor
	/// Size: 0x3D8
	/// Properties: 0
	/// </summary>
	public class AConanLevelScriptActor:ADWLevelScriptActor
	{
		public override int ObjectSize => 984;
	}


	/// <summary>
	/// AConanSandboxLevelScriptActor:AConanLevelScriptActor
	/// Size: 0x3D8
	/// Properties: 0
	/// </summary>
	public class AConanSandboxLevelScriptActor:AConanLevelScriptActor
	{
		public override int ObjectSize => 984;
	}


	/// <summary>
	/// UPlayer:UObject
	/// Size: 0x48
	/// Properties: 4
	/// </summary>
	public class UPlayer:UObject
	{
		public override int ObjectSize => 72;
		/// <summary>
		/// Name: PlayerController
		/// Type: ObjectProperty
		/// Offset: 0x30
		/// Size: 0x08
		/// </summary>
		public APlayerController PlayerController => ReadUObject<APlayerController>(0x30);
		
		/// <summary>
		/// Name: CurrentNetSpeed
		/// Type: IntProperty
		/// Offset: 0x38
		/// Size: 0x04
		/// </summary>
		public int CurrentNetSpeed
		{
			get
			{
				return ReadInt32(0x38);
			}
			set
			{
				WriteInt32(0x38,value);
			}
		}
		
		/// <summary>
		/// Name: ConfiguredInternetSpeed
		/// Type: IntProperty
		/// Offset: 0x3C
		/// Size: 0x04
		/// </summary>
		public int ConfiguredInternetSpeed
		{
			get
			{
				return ReadInt32(0x3C);
			}
			set
			{
				WriteInt32(0x3C,value);
			}
		}
		
		/// <summary>
		/// Name: ConfiguredLanSpeed
		/// Type: IntProperty
		/// Offset: 0x40
		/// Size: 0x04
		/// </summary>
		public int ConfiguredLanSpeed
		{
			get
			{
				return ReadInt32(0x40);
			}
			set
			{
				WriteInt32(0x40,value);
			}
		}
		
	}


	/// <summary>
	/// ULocalPlayer:UPlayer
	/// Size: 0x190
	/// Properties: 4
	/// </summary>
	public class ULocalPlayer:UPlayer
	{
		public override int ObjectSize => 400;
		/// <summary>
		/// Name: ViewportClient
		/// Type: ObjectProperty
		/// Offset: 0x58
		/// Size: 0x08
		/// </summary>
		public UGameViewportClient ViewportClient => ReadUObject<UGameViewportClient>(0x58);
		
		/// <summary>
		/// Name: AspectRatioAxisConstraint
		/// Type: ByteProperty
		/// Offset: 0x7C
		/// Size: 0x01
		/// </summary>
		public byte AspectRatioAxisConstraint
		{
			get
			{
				return ReadByte(0x7C);
			}
			set
			{
				WriteByte(0x7C,value);
			}
		}
		
		/// <summary>
		/// Name: PendingLevelPlayerControllerClass
		/// Type: ClassProperty
		/// Offset: 0x80
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: bSentSplitJoin
		/// Type: BoolProperty
		/// Offset: 0x88
		/// Size: 0x01
		/// </summary>
		public bool bSentSplitJoin => (ReadByte(0x0088) & 0x01) == 0x01;
		
	}


	/// <summary>
	/// UConanLocalPlayer:ULocalPlayer
	/// Size: 0x190
	/// Properties: 0
	/// </summary>
	public class UConanLocalPlayer:ULocalPlayer
	{
		public override int ObjectSize => 400;
	}


	/// <summary>
	/// UPathFollowingComponent:UActorComponent
	/// Size: 0x340
	/// Properties: 3
	/// </summary>
	public class UPathFollowingComponent:UActorComponent
	{
		public override int ObjectSize => 832;
		/// <summary>
		/// Name: MovementComp
		/// Type: ObjectProperty
		/// Offset: 0x190
		/// Size: 0x08
		/// </summary>
		public UNavMovementComponent MovementComp => ReadUObject<UNavMovementComponent>(0x190);
		
		/// <summary>
		/// Name: MyNavData
		/// Type: ObjectProperty
		/// Offset: 0x1A0
		/// Size: 0x08
		/// </summary>
		public ANavigationData MyNavData => ReadUObject<ANavigationData>(0x1A0);
		
		/// <summary>
		/// Name: bUseVisibilityTestsSimplification
		/// Type: BoolProperty
		/// Offset: 0x294
		/// Size: 0x01
		/// </summary>
		public bool bUseVisibilityTestsSimplification => (ReadByte(0x0294) & 0x01) == 0x01;
		
	}


	/// <summary>
	/// UConanPathFollowingComponent:UPathFollowingComponent
	/// Size: 0x440
	/// Properties: 15
	/// </summary>
	public class UConanPathFollowingComponent:UPathFollowingComponent
	{
		public override int ObjectSize => 1088;
		/// <summary>
		/// Name: PathWidth
		/// Type: FloatProperty
		/// Offset: 0x338
		/// Size: 0x04
		/// </summary>
		public float PathWidth
		{
			get
			{
				return ReadSingle(0x338);
			}
			set
			{
				WriteSingle(0x338,value);
			}
		}
		
		/// <summary>
		/// Name: BreakAngle
		/// Type: FloatProperty
		/// Offset: 0x33C
		/// Size: 0x04
		/// </summary>
		public float BreakAngle
		{
			get
			{
				return ReadSingle(0x33C);
			}
			set
			{
				WriteSingle(0x33C,value);
			}
		}
		
		/// <summary>
		/// Name: AccelerationFactor
		/// Type: FloatProperty
		/// Offset: 0x340
		/// Size: 0x04
		/// </summary>
		public float AccelerationFactor
		{
			get
			{
				return ReadSingle(0x340);
			}
			set
			{
				WriteSingle(0x340,value);
			}
		}
		
		/// <summary>
		/// Name: AccelerationMinSpeed
		/// Type: FloatProperty
		/// Offset: 0x344
		/// Size: 0x04
		/// </summary>
		public float AccelerationMinSpeed
		{
			get
			{
				return ReadSingle(0x344);
			}
			set
			{
				WriteSingle(0x344,value);
			}
		}
		
		/// <summary>
		/// Name: NavMeshSearchExtent
		/// Type: FloatProperty
		/// Offset: 0x348
		/// Size: 0x04
		/// </summary>
		public float NavMeshSearchExtent
		{
			get
			{
				return ReadSingle(0x348);
			}
			set
			{
				WriteSingle(0x348,value);
			}
		}
		
		/// <summary>
		/// Name: AvoidanceMaxTimeHorizonSeconds
		/// Type: FloatProperty
		/// Offset: 0x34C
		/// Size: 0x04
		/// </summary>
		public float AvoidanceMaxTimeHorizonSeconds
		{
			get
			{
				return ReadSingle(0x34C);
			}
			set
			{
				WriteSingle(0x34C,value);
			}
		}
		
		/// <summary>
		/// Name: AvoidanceMinTimeHorizonSeconds
		/// Type: FloatProperty
		/// Offset: 0x350
		/// Size: 0x04
		/// </summary>
		public float AvoidanceMinTimeHorizonSeconds
		{
			get
			{
				return ReadSingle(0x350);
			}
			set
			{
				WriteSingle(0x350,value);
			}
		}
		
		/// <summary>
		/// Name: AvoidanceMinDistance
		/// Type: FloatProperty
		/// Offset: 0x354
		/// Size: 0x04
		/// </summary>
		public float AvoidanceMinDistance
		{
			get
			{
				return ReadSingle(0x354);
			}
			set
			{
				WriteSingle(0x354,value);
			}
		}
		
		/// <summary>
		/// Name: AvoidanceSearchRadius
		/// Type: FloatProperty
		/// Offset: 0x358
		/// Size: 0x04
		/// </summary>
		public float AvoidanceSearchRadius
		{
			get
			{
				return ReadSingle(0x358);
			}
			set
			{
				WriteSingle(0x358,value);
			}
		}
		
		/// <summary>
		/// Name: InitialAvoidanceYawSearchRange
		/// Type: FloatProperty
		/// Offset: 0x35C
		/// Size: 0x04
		/// </summary>
		public float InitialAvoidanceYawSearchRange
		{
			get
			{
				return ReadSingle(0x35C);
			}
			set
			{
				WriteSingle(0x35C,value);
			}
		}
		
		/// <summary>
		/// Name: AvoidanceMinSpeed
		/// Type: FloatProperty
		/// Offset: 0x360
		/// Size: 0x04
		/// </summary>
		public float AvoidanceMinSpeed
		{
			get
			{
				return ReadSingle(0x360);
			}
			set
			{
				WriteSingle(0x360,value);
			}
		}
		
		/// <summary>
		/// Name: SecondsUntilFullAvoidanceYawSearchRange
		/// Type: FloatProperty
		/// Offset: 0x364
		/// Size: 0x04
		/// </summary>
		public float SecondsUntilFullAvoidanceYawSearchRange
		{
			get
			{
				return ReadSingle(0x364);
			}
			set
			{
				WriteSingle(0x364,value);
			}
		}
		
		/// <summary>
		/// Name: AvoidPlayerCharacters
		/// Type: BoolProperty
		/// Offset: 0x368
		/// Size: 0x01
		/// </summary>
		public bool AvoidPlayerCharacters => (ReadByte(0x0368) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: PredictedObstacles
		/// Type: TArray<FPredictedObstacle>
		/// Offset: 0x370
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<FPredictedObstacle> PredictedObstacles => new TArray<FPredictedObstacle>(BaseAddress+0x370);
		
		/// <summary>
		/// Name: YawAngleWeights
		/// Type: StructProperty
		/// Offset: 0x380
		/// Size: 0x18
		/// </summary>
		public FPolarUtilityVector YawAngleWeights => ReadStruct<FPolarUtilityVector>(0x380);
		
	}


	/// <summary>
	/// APlayerCameraManager:AActor
	/// Size: 0x1518
	/// Properties: 29
	/// </summary>
	public class APlayerCameraManager:AActor
	{
		public override int ObjectSize => 5400;
		/// <summary>
		/// Name: PCOwner
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public APlayerController PCOwner => ReadUObject<APlayerController>(0x3D0);
		
		/// <summary>
		/// Name: TransformComponent
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public USceneComponent TransformComponent => ReadUObject<USceneComponent>(0x3D8);
		
		/// <summary>
		/// Name: DefaultFOV
		/// Type: FloatProperty
		/// Offset: 0x3E8
		/// Size: 0x04
		/// </summary>
		public float DefaultFOV
		{
			get
			{
				return ReadSingle(0x3E8);
			}
			set
			{
				WriteSingle(0x3E8,value);
			}
		}
		
		/// <summary>
		/// Name: DefaultOrthoWidth
		/// Type: FloatProperty
		/// Offset: 0x3F0
		/// Size: 0x04
		/// </summary>
		public float DefaultOrthoWidth
		{
			get
			{
				return ReadSingle(0x3F0);
			}
			set
			{
				WriteSingle(0x3F0,value);
			}
		}
		
		/// <summary>
		/// Name: DefaultAspectRatio
		/// Type: FloatProperty
		/// Offset: 0x3F8
		/// Size: 0x04
		/// </summary>
		public float DefaultAspectRatio
		{
			get
			{
				return ReadSingle(0x3F8);
			}
			set
			{
				WriteSingle(0x3F8,value);
			}
		}
		
		/// <summary>
		/// Name: CameraCache
		/// Type: StructProperty
		/// Offset: 0x440
		/// Size: 0x3E8
		/// </summary>
		public FCameraCacheEntry CameraCache => ReadStruct<FCameraCacheEntry>(0x440);
		
		/// <summary>
		/// Name: LastFrameCameraCache
		/// Type: StructProperty
		/// Offset: 0x828
		/// Size: 0x3E8
		/// </summary>
		public FCameraCacheEntry LastFrameCameraCache => ReadStruct<FCameraCacheEntry>(0x828);
		
		/// <summary>
		/// Name: ViewTarget
		/// Type: StructProperty
		/// Offset: 0xC10
		/// Size: 0x3F0
		/// </summary>
		public FTViewTarget ViewTarget => ReadStruct<FTViewTarget>(0xC10);
		
		/// <summary>
		/// Name: PendingViewTarget
		/// Type: StructProperty
		/// Offset: 0x1000
		/// Size: 0x3F0
		/// </summary>
		public FTViewTarget PendingViewTarget => ReadStruct<FTViewTarget>(0x1000);
		
		/// <summary>
		/// Name: ModifierList
		/// Type: TArray<UCameraModifier>
		/// Offset: 0x1408
		/// Size: 0x10
		/// SubElement Size: 0x48
		/// </summary>
		public TArray<UCameraModifier> ModifierList => new TArray<UCameraModifier>(BaseAddress+0x1408);
		
		/// <summary>
		/// Name: DefaultModifiers
		/// Type: TArray<>
		/// Offset: 0x1418
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: FreeCamDistance
		/// Type: FloatProperty
		/// Offset: 0x1428
		/// Size: 0x04
		/// </summary>
		public float FreeCamDistance
		{
			get
			{
				return ReadSingle(0x1428);
			}
			set
			{
				WriteSingle(0x1428,value);
			}
		}
		
		/// <summary>
		/// Name: FreeCamOffset
		/// Type: StructProperty
		/// Offset: 0x142C
		/// Size: 0x0C
		/// </summary>
		public FVector FreeCamOffset => ReadStruct<FVector>(0x142C);
		
		/// <summary>
		/// Name: ViewTargetOffset
		/// Type: StructProperty
		/// Offset: 0x1438
		/// Size: 0x0C
		/// </summary>
		public FVector ViewTargetOffset => ReadStruct<FVector>(0x1438);
		
		/// <summary>
		/// Name: CameraLensEffects
		/// Type: TArray<AEmitterCameraLensEffectBase>
		/// Offset: 0x1458
		/// Size: 0x10
		/// SubElement Size: 0x490
		/// </summary>
		public TArray<AEmitterCameraLensEffectBase> CameraLensEffects => new TArray<AEmitterCameraLensEffectBase>(BaseAddress+0x1458);
		
		/// <summary>
		/// Name: CachedCameraShakeMod
		/// Type: ObjectProperty
		/// Offset: 0x1468
		/// Size: 0x08
		/// </summary>
		public UCameraModifier_CameraShake CachedCameraShakeMod => ReadUObject<UCameraModifier_CameraShake>(0x1468);
		
		/// <summary>
		/// Name: AnimInstPool
		/// Type: ObjectProperty
		/// Offset: 0x1470
		/// Size: 0x08
		/// </summary>
		public UCameraAnimInst AnimInstPool => ReadUObject<UCameraAnimInst>(0x1470);
		
		/// <summary>
		/// Name: PostProcessBlendCache
		/// Type: TArray<FPostProcessSettings>
		/// Offset: 0x14B0
		/// Size: 0x10
		/// SubElement Size: 0x3A0
		/// </summary>
		public TArray<FPostProcessSettings> PostProcessBlendCache => new TArray<FPostProcessSettings>(BaseAddress+0x14B0);
		
		/// <summary>
		/// Name: ActiveAnims
		/// Type: TArray<UCameraAnimInst>
		/// Offset: 0x14D0
		/// Size: 0x10
		/// SubElement Size: 0x110
		/// </summary>
		public TArray<UCameraAnimInst> ActiveAnims => new TArray<UCameraAnimInst>(BaseAddress+0x14D0);
		
		/// <summary>
		/// Name: FreeAnims
		/// Type: TArray<UCameraAnimInst>
		/// Offset: 0x14E0
		/// Size: 0x10
		/// SubElement Size: 0x110
		/// </summary>
		public TArray<UCameraAnimInst> FreeAnims => new TArray<UCameraAnimInst>(BaseAddress+0x14E0);
		
		/// <summary>
		/// Name: AnimCameraActor
		/// Type: ObjectProperty
		/// Offset: 0x14F0
		/// Size: 0x08
		/// </summary>
		public ACameraActor AnimCameraActor => ReadUObject<ACameraActor>(0x14F0);
		
		/// <summary>
		/// Name: bIsOrthographic
		/// Type: BoolProperty
		/// Offset: 0x14F8
		/// Size: 0x01
		/// </summary>
		public bool bIsOrthographic => (ReadByte(0x14F8) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bUseClientSideCameraUpdates
		/// Type: BoolProperty
		/// Offset: 0x14F8
		/// Size: 0x01
		/// </summary>
		public bool bUseClientSideCameraUpdates => (ReadByte(0x14F8) & 0x40) == 0x40;
		
		/// <summary>
		/// Name: ViewPitchMin
		/// Type: FloatProperty
		/// Offset: 0x14FC
		/// Size: 0x04
		/// </summary>
		public float ViewPitchMin
		{
			get
			{
				return ReadSingle(0x14FC);
			}
			set
			{
				WriteSingle(0x14FC,value);
			}
		}
		
		/// <summary>
		/// Name: ViewPitchMax
		/// Type: FloatProperty
		/// Offset: 0x1500
		/// Size: 0x04
		/// </summary>
		public float ViewPitchMax
		{
			get
			{
				return ReadSingle(0x1500);
			}
			set
			{
				WriteSingle(0x1500,value);
			}
		}
		
		/// <summary>
		/// Name: ViewYawMin
		/// Type: FloatProperty
		/// Offset: 0x1504
		/// Size: 0x04
		/// </summary>
		public float ViewYawMin
		{
			get
			{
				return ReadSingle(0x1504);
			}
			set
			{
				WriteSingle(0x1504,value);
			}
		}
		
		/// <summary>
		/// Name: ViewYawMax
		/// Type: FloatProperty
		/// Offset: 0x1508
		/// Size: 0x04
		/// </summary>
		public float ViewYawMax
		{
			get
			{
				return ReadSingle(0x1508);
			}
			set
			{
				WriteSingle(0x1508,value);
			}
		}
		
		/// <summary>
		/// Name: ViewRollMin
		/// Type: FloatProperty
		/// Offset: 0x150C
		/// Size: 0x04
		/// </summary>
		public float ViewRollMin
		{
			get
			{
				return ReadSingle(0x150C);
			}
			set
			{
				WriteSingle(0x150C,value);
			}
		}
		
		/// <summary>
		/// Name: ViewRollMax
		/// Type: FloatProperty
		/// Offset: 0x1510
		/// Size: 0x04
		/// </summary>
		public float ViewRollMax
		{
			get
			{
				return ReadSingle(0x1510);
			}
			set
			{
				WriteSingle(0x1510,value);
			}
		}
		
	}


	/// <summary>
	/// AConanPlayerCameraManager:APlayerCameraManager
	/// Size: 0x1518
	/// Properties: 0
	/// </summary>
	public class AConanPlayerCameraManager:APlayerCameraManager
	{
		public override int ObjectSize => 5400;
	}


	/// <summary>
	/// APlayerState:AInfo
	/// Size: 0x458
	/// Properties: 13
	/// </summary>
	public class APlayerState:AInfo
	{
		public override int ObjectSize => 1112;
		/// <summary>
		/// Name: score
		/// Type: FloatProperty
		/// Offset: 0x3D0
		/// Size: 0x04
		/// </summary>
		public float score
		{
			get
			{
				return ReadSingle(0x3D0);
			}
			set
			{
				WriteSingle(0x3D0,value);
			}
		}
		
		/// <summary>
		/// Name: Ping
		/// Type: ByteProperty
		/// Offset: 0x3D4
		/// Size: 0x01
		/// </summary>
		public byte Ping
		{
			get
			{
				return ReadByte(0x3D4);
			}
			set
			{
				WriteByte(0x3D4,value);
			}
		}
		
		/// <summary>
		/// Name: PlayerName
		/// Type: StrProperty
		/// Offset: 0x3D8
		/// Size: 0x10
		/// </summary>
		public FString PlayerName => new FString(BaseAddress+0x3D8);
		
		/// <summary>
		/// Name: PlayerId
		/// Type: IntProperty
		/// Offset: 0x3F8
		/// Size: 0x04
		/// </summary>
		public int PlayerId
		{
			get
			{
				return ReadInt32(0x3F8);
			}
			set
			{
				WriteInt32(0x3F8,value);
			}
		}
		
		/// <summary>
		/// Name: bIsSpectator
		/// Type: BoolProperty
		/// Offset: 0x3FC
		/// Size: 0x01
		/// </summary>
		public bool bIsSpectator => (ReadByte(0x03FC) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bOnlySpectator
		/// Type: BoolProperty
		/// Offset: 0x3FC
		/// Size: 0x01
		/// </summary>
		public bool bOnlySpectator => (ReadByte(0x03FC) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bIsABot
		/// Type: BoolProperty
		/// Offset: 0x3FC
		/// Size: 0x01
		/// </summary>
		public bool bIsABot => (ReadByte(0x03FC) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bIsInactive
		/// Type: BoolProperty
		/// Offset: 0x3FC
		/// Size: 0x01
		/// </summary>
		public bool bIsInactive => (ReadByte(0x03FC) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bFromPreviousLevel
		/// Type: BoolProperty
		/// Offset: 0x3FC
		/// Size: 0x01
		/// </summary>
		public bool bFromPreviousLevel => (ReadByte(0x03FC) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: StartTime
		/// Type: IntProperty
		/// Offset: 0x400
		/// Size: 0x04
		/// </summary>
		public int StartTime
		{
			get
			{
				return ReadInt32(0x400);
			}
			set
			{
				WriteInt32(0x400,value);
			}
		}
		
		/// <summary>
		/// Name: EngineMessageClass
		/// Type: ClassProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: SavedNetworkAddress
		/// Type: StrProperty
		/// Offset: 0x418
		/// Size: 0x10
		/// </summary>
		public FString SavedNetworkAddress => new FString(BaseAddress+0x418);
		
		/// <summary>
		/// Name: UniqueID
		/// Type: StructProperty
		/// Offset: 0x428
		/// Size: 0x10
		/// </summary>
		public FUniqueNetIdRepl UniqueID => ReadStruct<FUniqueNetIdRepl>(0x428);
		
	}


	/// <summary>
	/// AConanPlayerState:APlayerState
	/// Size: 0x458
	/// Properties: 0
	/// </summary>
	public class AConanPlayerState:APlayerState
	{
		public override int ObjectSize => 1112;
	}


	/// <summary>
	/// UMovementComponent:UActorComponent
	/// Size: 0x130
	/// Properties: 13
	/// </summary>
	public class UMovementComponent:UActorComponent
	{
		public override int ObjectSize => 304;
		/// <summary>
		/// Name: UpdatedComponent
		/// Type: ObjectProperty
		/// Offset: 0xD8
		/// Size: 0x08
		/// </summary>
		public USceneComponent UpdatedComponent => ReadUObject<USceneComponent>(0xD8);
		
		/// <summary>
		/// Name: UpdatedPrimitive
		/// Type: ObjectProperty
		/// Offset: 0xE0
		/// Size: 0x08
		/// </summary>
		public UPrimitiveComponent UpdatedPrimitive => ReadUObject<UPrimitiveComponent>(0xE0);
		
		/// <summary>
		/// Name: Velocity
		/// Type: StructProperty
		/// Offset: 0xEC
		/// Size: 0x0C
		/// </summary>
		public FVector Velocity => ReadStruct<FVector>(0xEC);
		
		/// <summary>
		/// Name: AngularVelocity
		/// Type: StructProperty
		/// Offset: 0xF8
		/// Size: 0x0C
		/// </summary>
		public FVector AngularVelocity => ReadStruct<FVector>(0xF8);
		
		/// <summary>
		/// Name: bConstrainToPlane
		/// Type: BoolProperty
		/// Offset: 0x104
		/// Size: 0x01
		/// </summary>
		public bool bConstrainToPlane => (ReadByte(0x0104) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bSnapToPlaneAtStart
		/// Type: BoolProperty
		/// Offset: 0x104
		/// Size: 0x01
		/// </summary>
		public bool bSnapToPlaneAtStart => (ReadByte(0x0104) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: PlaneConstraintAxisSetting
		/// Type: ByteProperty
		/// Offset: 0x108
		/// Size: 0x01
		/// </summary>
		public byte PlaneConstraintAxisSetting
		{
			get
			{
				return ReadByte(0x108);
			}
			set
			{
				WriteByte(0x108,value);
			}
		}
		
		/// <summary>
		/// Name: PlaneConstraintNormal
		/// Type: StructProperty
		/// Offset: 0x10C
		/// Size: 0x0C
		/// </summary>
		public FVector PlaneConstraintNormal => ReadStruct<FVector>(0x10C);
		
		/// <summary>
		/// Name: PlaneConstraintOrigin
		/// Type: StructProperty
		/// Offset: 0x118
		/// Size: 0x0C
		/// </summary>
		public FVector PlaneConstraintOrigin => ReadStruct<FVector>(0x118);
		
		/// <summary>
		/// Name: bUpdateOnlyIfRendered
		/// Type: BoolProperty
		/// Offset: 0x124
		/// Size: 0x01
		/// </summary>
		public bool bUpdateOnlyIfRendered => (ReadByte(0x0124) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bAutoUpdateTickRegistration
		/// Type: BoolProperty
		/// Offset: 0x124
		/// Size: 0x01
		/// </summary>
		public bool bAutoUpdateTickRegistration => (ReadByte(0x0124) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bTickBeforeOwner
		/// Type: BoolProperty
		/// Offset: 0x124
		/// Size: 0x01
		/// </summary>
		public bool bTickBeforeOwner => (ReadByte(0x0124) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bAutoRegisterUpdatedComponent
		/// Type: BoolProperty
		/// Offset: 0x124
		/// Size: 0x01
		/// </summary>
		public bool bAutoRegisterUpdatedComponent => (ReadByte(0x0124) & 0x08) == 0x08;
		
	}


	/// <summary>
	/// UProjectileMovementComponent:UMovementComponent
	/// Size: 0x198
	/// Properties: 19
	/// </summary>
	public class UProjectileMovementComponent:UMovementComponent
	{
		public override int ObjectSize => 408;
		/// <summary>
		/// Name: InitialSpeed
		/// Type: FloatProperty
		/// Offset: 0x130
		/// Size: 0x04
		/// </summary>
		public float InitialSpeed
		{
			get
			{
				return ReadSingle(0x130);
			}
			set
			{
				WriteSingle(0x130,value);
			}
		}
		
		/// <summary>
		/// Name: MaxSpeed
		/// Type: FloatProperty
		/// Offset: 0x134
		/// Size: 0x04
		/// </summary>
		public float MaxSpeed
		{
			get
			{
				return ReadSingle(0x134);
			}
			set
			{
				WriteSingle(0x134,value);
			}
		}
		
		/// <summary>
		/// Name: bRotationFollowsVelocity
		/// Type: BoolProperty
		/// Offset: 0x138
		/// Size: 0x01
		/// </summary>
		public bool bRotationFollowsVelocity => (ReadByte(0x0138) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bShouldBounce
		/// Type: BoolProperty
		/// Offset: 0x138
		/// Size: 0x01
		/// </summary>
		public bool bShouldBounce => (ReadByte(0x0138) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bInitialVelocityInLocalSpace
		/// Type: BoolProperty
		/// Offset: 0x138
		/// Size: 0x01
		/// </summary>
		public bool bInitialVelocityInLocalSpace => (ReadByte(0x0138) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bForceSubStepping
		/// Type: BoolProperty
		/// Offset: 0x138
		/// Size: 0x01
		/// </summary>
		public bool bForceSubStepping => (ReadByte(0x0138) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bIsHomingProjectile
		/// Type: BoolProperty
		/// Offset: 0x138
		/// Size: 0x01
		/// </summary>
		public bool bIsHomingProjectile => (ReadByte(0x0138) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bBounceAngleAffectsFriction
		/// Type: BoolProperty
		/// Offset: 0x138
		/// Size: 0x01
		/// </summary>
		public bool bBounceAngleAffectsFriction => (ReadByte(0x0138) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: bIsSliding
		/// Type: BoolProperty
		/// Offset: 0x138
		/// Size: 0x01
		/// </summary>
		public bool bIsSliding => (ReadByte(0x0138) & 0x40) == 0x40;
		
		/// <summary>
		/// Name: PreviousHitTime
		/// Type: FloatProperty
		/// Offset: 0x13C
		/// Size: 0x04
		/// </summary>
		public float PreviousHitTime
		{
			get
			{
				return ReadSingle(0x13C);
			}
			set
			{
				WriteSingle(0x13C,value);
			}
		}
		
		/// <summary>
		/// Name: PreviousHitNormal
		/// Type: StructProperty
		/// Offset: 0x140
		/// Size: 0x0C
		/// </summary>
		public FVector PreviousHitNormal => ReadStruct<FVector>(0x140);
		
		/// <summary>
		/// Name: ProjectileGravityScale
		/// Type: FloatProperty
		/// Offset: 0x14C
		/// Size: 0x04
		/// </summary>
		public float ProjectileGravityScale
		{
			get
			{
				return ReadSingle(0x14C);
			}
			set
			{
				WriteSingle(0x14C,value);
			}
		}
		
		/// <summary>
		/// Name: Buoyancy
		/// Type: FloatProperty
		/// Offset: 0x150
		/// Size: 0x04
		/// </summary>
		public float Buoyancy
		{
			get
			{
				return ReadSingle(0x150);
			}
			set
			{
				WriteSingle(0x150,value);
			}
		}
		
		/// <summary>
		/// Name: Bounciness
		/// Type: FloatProperty
		/// Offset: 0x154
		/// Size: 0x04
		/// </summary>
		public float Bounciness
		{
			get
			{
				return ReadSingle(0x154);
			}
			set
			{
				WriteSingle(0x154,value);
			}
		}
		
		/// <summary>
		/// Name: Friction
		/// Type: FloatProperty
		/// Offset: 0x158
		/// Size: 0x04
		/// </summary>
		public float Friction
		{
			get
			{
				return ReadSingle(0x158);
			}
			set
			{
				WriteSingle(0x158,value);
			}
		}
		
		/// <summary>
		/// Name: BounceVelocityStopSimulatingThreshold
		/// Type: FloatProperty
		/// Offset: 0x15C
		/// Size: 0x04
		/// </summary>
		public float BounceVelocityStopSimulatingThreshold
		{
			get
			{
				return ReadSingle(0x15C);
			}
			set
			{
				WriteSingle(0x15C,value);
			}
		}
		
		/// <summary>
		/// Name: HomingAccelerationMagnitude
		/// Type: FloatProperty
		/// Offset: 0x180
		/// Size: 0x04
		/// </summary>
		public float HomingAccelerationMagnitude
		{
			get
			{
				return ReadSingle(0x180);
			}
			set
			{
				WriteSingle(0x180,value);
			}
		}
		
		/// <summary>
		/// Name: MaxSimulationTimeStep
		/// Type: FloatProperty
		/// Offset: 0x18C
		/// Size: 0x04
		/// </summary>
		public float MaxSimulationTimeStep
		{
			get
			{
				return ReadSingle(0x18C);
			}
			set
			{
				WriteSingle(0x18C,value);
			}
		}
		
		/// <summary>
		/// Name: MaxSimulationIterations
		/// Type: IntProperty
		/// Offset: 0x190
		/// Size: 0x04
		/// </summary>
		public int MaxSimulationIterations
		{
			get
			{
				return ReadInt32(0x190);
			}
			set
			{
				WriteInt32(0x190,value);
			}
		}
		
	}


	/// <summary>
	/// UConanProjectileMovementComponent:UProjectileMovementComponent
	/// Size: 0x198
	/// Properties: 0
	/// </summary>
	public class UConanProjectileMovementComponent:UProjectileMovementComponent
	{
		public override int ObjectSize => 408;
	}


	/// <summary>
	/// AConanTimeOfDayManager:AActor
	/// Size: 0x3F0
	/// Properties: 4
	/// </summary>
	public class AConanTimeOfDayManager:AActor
	{
		public override int ObjectSize => 1008;
		/// <summary>
		/// Name: DayLength
		/// Type: FloatProperty
		/// Offset: 0x3D0
		/// Size: 0x04
		/// </summary>
		public float DayLength
		{
			get
			{
				return ReadSingle(0x3D0);
			}
			set
			{
				WriteSingle(0x3D0,value);
			}
		}
		
		/// <summary>
		/// Name: StartTimeOfDay
		/// Type: FloatProperty
		/// Offset: 0x3D4
		/// Size: 0x04
		/// </summary>
		public float StartTimeOfDay
		{
			get
			{
				return ReadSingle(0x3D4);
			}
			set
			{
				WriteSingle(0x3D4,value);
			}
		}
		
		/// <summary>
		/// Name: TimeEnabled
		/// Type: BoolProperty
		/// Offset: 0x3D8
		/// Size: 0x01
		/// </summary>
		public bool TimeEnabled
		{
			get
			{
				return ReadBool(0x3D8);
			}
			set
			{
				WriteBool(0x3D8,value);
			}
		}
		
		/// <summary>
		/// Name: TimeOfDay
		/// Type: FloatProperty
		/// Offset: 0x3DC
		/// Size: 0x04
		/// </summary>
		public float TimeOfDay
		{
			get
			{
				return ReadSingle(0x3DC);
			}
			set
			{
				WriteSingle(0x3DC,value);
			}
		}
		
	}


	/// <summary>
	/// UWorldComposition:UObject
	/// Size: 0x68
	/// Properties: 5
	/// </summary>
	public class UWorldComposition:UObject
	{
		public override int ObjectSize => 104;
		/// <summary>
		/// Name: TilesStreaming
		/// Type: TArray<ULevelStreaming>
		/// Offset: 0x48
		/// Size: 0x10
		/// SubElement Size: 0x160
		/// </summary>
		public TArray<ULevelStreaming> TilesStreaming => new TArray<ULevelStreaming>(BaseAddress+0x48);
		
		/// <summary>
		/// Name: TilesStreamingTimeThreshold
		/// Type: DoubleProperty
		/// Offset: 0x58
		/// Size: 0x08
		/// </summary>
		public double TilesStreamingTimeThreshold
		{
			get
			{
				return ReadDouble(0x58);
			}
			set
			{
				WriteDouble(0x58,value);
			}
		}
		
		/// <summary>
		/// Name: bLoadAllTilesDuringCinematic
		/// Type: BoolProperty
		/// Offset: 0x60
		/// Size: 0x01
		/// </summary>
		public bool bLoadAllTilesDuringCinematic
		{
			get
			{
				return ReadBool(0x60);
			}
			set
			{
				WriteBool(0x60,value);
			}
		}
		
		/// <summary>
		/// Name: bRebaseOriginIn3DSpace
		/// Type: BoolProperty
		/// Offset: 0x61
		/// Size: 0x01
		/// </summary>
		public bool bRebaseOriginIn3DSpace
		{
			get
			{
				return ReadBool(0x61);
			}
			set
			{
				WriteBool(0x61,value);
			}
		}
		
		/// <summary>
		/// Name: RebaseOriginDistance
		/// Type: FloatProperty
		/// Offset: 0x64
		/// Size: 0x04
		/// </summary>
		public float RebaseOriginDistance
		{
			get
			{
				return ReadSingle(0x64);
			}
			set
			{
				WriteSingle(0x64,value);
			}
		}
		
	}


	/// <summary>
	/// UConanWorldComposition:UWorldComposition
	/// Size: 0x68
	/// Properties: 0
	/// </summary>
	public class UConanWorldComposition:UWorldComposition
	{
		public override int ObjectSize => 104;
	}


	/// <summary>
	/// ACorpseBase:AActor
	/// Size: 0x3E8
	/// Properties: 1
	/// </summary>
	public class ACorpseBase:AActor
	{
		public override int ObjectSize => 1000;
		/// <summary>
		/// Name: DisplayName
		/// Type: TextProperty
		/// Offset: 0x3D0
		/// Size: 0x18
		/// </summary>
		
	}


	/// <summary>
	/// UCraftingStationInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UCraftingStationInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UCustomRenderWidget:UWidget
	/// Size: 0x128
	/// Properties: 0
	/// </summary>
	public class UCustomRenderWidget:UWidget
	{
		public override int ObjectSize => 296;
	}


	/// <summary>
	/// UPieRenderWidget:UCustomRenderWidget
	/// Size: 0x150
	/// Properties: 6
	/// </summary>
	public class UPieRenderWidget:UCustomRenderWidget
	{
		public override int ObjectSize => 336;
		/// <summary>
		/// Name: Texture
		/// Type: ObjectProperty
		/// Offset: 0x128
		/// Size: 0x08
		/// </summary>
		public UTexture2D Texture => ReadUObject<UTexture2D>(0x128);
		
		/// <summary>
		/// Name: ColorAndOpacity
		/// Type: StructProperty
		/// Offset: 0x130
		/// Size: 0x10
		/// </summary>
		public FLinearColor ColorAndOpacity => ReadStruct<FLinearColor>(0x130);
		
		/// <summary>
		/// Name: StartAngle
		/// Type: FloatProperty
		/// Offset: 0x140
		/// Size: 0x04
		/// </summary>
		public float StartAngle
		{
			get
			{
				return ReadSingle(0x140);
			}
			set
			{
				WriteSingle(0x140,value);
			}
		}
		
		/// <summary>
		/// Name: AngleSpan
		/// Type: FloatProperty
		/// Offset: 0x144
		/// Size: 0x04
		/// </summary>
		public float AngleSpan
		{
			get
			{
				return ReadSingle(0x144);
			}
			set
			{
				WriteSingle(0x144,value);
			}
		}
		
		/// <summary>
		/// Name: InnerRadius
		/// Type: FloatProperty
		/// Offset: 0x148
		/// Size: 0x04
		/// </summary>
		public float InnerRadius
		{
			get
			{
				return ReadSingle(0x148);
			}
			set
			{
				WriteSingle(0x148,value);
			}
		}
		
		/// <summary>
		/// Name: OuterRadius
		/// Type: FloatProperty
		/// Offset: 0x14C
		/// Size: 0x04
		/// </summary>
		public float OuterRadius
		{
			get
			{
				return ReadSingle(0x14C);
			}
			set
			{
				WriteSingle(0x14C,value);
			}
		}
		
	}


	/// <summary>
	/// UDamageMonitorInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UDamageMonitorInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UDamageMonitorHelper:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UDamageMonitorHelper:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// ADynamicSkyBase:AActor
	/// Size: 0x3E0
	/// Properties: 3
	/// </summary>
	public class ADynamicSkyBase:AActor
	{
		public override int ObjectSize => 992;
		/// <summary>
		/// Name: TimeManager
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public AConanTimeOfDayManager TimeManager => ReadUObject<AConanTimeOfDayManager>(0x3D0);
		
		/// <summary>
		/// Name: AnimateDayNight
		/// Type: BoolProperty
		/// Offset: 0x3D8
		/// Size: 0x01
		/// </summary>
		public bool AnimateDayNight
		{
			get
			{
				return ReadBool(0x3D8);
			}
			set
			{
				WriteBool(0x3D8,value);
			}
		}
		
		/// <summary>
		/// Name: TimeOfDay
		/// Type: FloatProperty
		/// Offset: 0x3DC
		/// Size: 0x04
		/// </summary>
		public float TimeOfDay
		{
			get
			{
				return ReadSingle(0x3DC);
			}
			set
			{
				WriteSingle(0x3DC,value);
			}
		}
		
	}


	/// <summary>
	/// UEgocentricParticleSpawnerComponent:UActorComponent
	/// Size: 0x170
	/// Properties: 6
	/// </summary>
	public class UEgocentricParticleSpawnerComponent:UActorComponent
	{
		public override int ObjectSize => 368;
		/// <summary>
		/// Name: MinSpawnInterval
		/// Type: FloatProperty
		/// Offset: 0xD8
		/// Size: 0x04
		/// </summary>
		public float MinSpawnInterval
		{
			get
			{
				return ReadSingle(0xD8);
			}
			set
			{
				WriteSingle(0xD8,value);
			}
		}
		
		/// <summary>
		/// Name: MaxRadius
		/// Type: FloatProperty
		/// Offset: 0xDC
		/// Size: 0x04
		/// </summary>
		public float MaxRadius
		{
			get
			{
				return ReadSingle(0xDC);
			}
			set
			{
				WriteSingle(0xDC,value);
			}
		}
		
		/// <summary>
		/// Name: TraceStartZ
		/// Type: FloatProperty
		/// Offset: 0xE0
		/// Size: 0x04
		/// </summary>
		public float TraceStartZ
		{
			get
			{
				return ReadSingle(0xE0);
			}
			set
			{
				WriteSingle(0xE0,value);
			}
		}
		
		/// <summary>
		/// Name: TraceEndZ
		/// Type: FloatProperty
		/// Offset: 0xE4
		/// Size: 0x04
		/// </summary>
		public float TraceEndZ
		{
			get
			{
				return ReadSingle(0xE4);
			}
			set
			{
				WriteSingle(0xE4,value);
			}
		}
		
		/// <summary>
		/// Name: MaxSpawnCount
		/// Type: IntProperty
		/// Offset: 0xE8
		/// Size: 0x04
		/// </summary>
		public int MaxSpawnCount
		{
			get
			{
				return ReadInt32(0xE8);
			}
			set
			{
				WriteInt32(0xE8,value);
			}
		}
		
		/// <summary>
		/// Name: m_SpawnedParticles
		/// Type: TArray<AActor>
		/// Offset: 0xF0
		/// Size: 0x10
		/// SubElement Size: 0x3D0
		/// </summary>
		public TArray<AActor> m_SpawnedParticles => new TArray<AActor>(BaseAddress+0xF0);
		
	}


	/// <summary>
	/// UEnergySourceComponent:UActorComponent
	/// Size: 0xF0
	/// Properties: 2
	/// </summary>
	public class UEnergySourceComponent:UActorComponent
	{
		public override int ObjectSize => 240;
		/// <summary>
		/// Name: TickInterval
		/// Type: FloatProperty
		/// Offset: 0xD8
		/// Size: 0x04
		/// </summary>
		public float TickInterval
		{
			get
			{
				return ReadSingle(0xD8);
			}
			set
			{
				WriteSingle(0xD8,value);
			}
		}
		
		/// <summary>
		/// Name: RegisterAsSourceForEnergies
		/// Type: TArray<FBaseEnergy>
		/// Offset: 0xE0
		/// Size: 0x10
		/// SubElement Size: 0x24
		/// </summary>
		public TArray<FBaseEnergy> RegisterAsSourceForEnergies => new TArray<FBaseEnergy>(BaseAddress+0xE0);
		
	}


	/// <summary>
	/// UEnvironmentFunctionLibrary:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UEnvironmentFunctionLibrary:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UTextLayoutWidget:UWidget
	/// Size: 0x140
	/// Properties: 7
	/// </summary>
	public class UTextLayoutWidget:UWidget
	{
		public override int ObjectSize => 320;
		/// <summary>
		/// Name: ShapedTextOptions
		/// Type: StructProperty
		/// Offset: 0x118
		/// Size: 0x08
		/// </summary>
		public FShapedTextOptions ShapedTextOptions => ReadStruct<FShapedTextOptions>(0x118);
		
		/// <summary>
		/// Name: Justification
		/// Type: ByteProperty
		/// Offset: 0x120
		/// Size: 0x01
		/// </summary>
		public byte Justification
		{
			get
			{
				return ReadByte(0x120);
			}
			set
			{
				WriteByte(0x120,value);
			}
		}
		
		/// <summary>
		/// Name: AutoWrapText
		/// Type: BoolProperty
		/// Offset: 0x121
		/// Size: 0x01
		/// </summary>
		public bool AutoWrapText
		{
			get
			{
				return ReadBool(0x121);
			}
			set
			{
				WriteBool(0x121,value);
			}
		}
		
		/// <summary>
		/// Name: WrapTextAt
		/// Type: FloatProperty
		/// Offset: 0x124
		/// Size: 0x04
		/// </summary>
		public float WrapTextAt
		{
			get
			{
				return ReadSingle(0x124);
			}
			set
			{
				WriteSingle(0x124,value);
			}
		}
		
		/// <summary>
		/// Name: WrappingPolicy
		/// Type: ByteProperty
		/// Offset: 0x128
		/// Size: 0x01
		/// </summary>
		public byte WrappingPolicy
		{
			get
			{
				return ReadByte(0x128);
			}
			set
			{
				WriteByte(0x128,value);
			}
		}
		
		/// <summary>
		/// Name: Margin
		/// Type: StructProperty
		/// Offset: 0x12C
		/// Size: 0x10
		/// </summary>
		public FMargin Margin => ReadStruct<FMargin>(0x12C);
		
		/// <summary>
		/// Name: LineHeightPercentage
		/// Type: FloatProperty
		/// Offset: 0x13C
		/// Size: 0x04
		/// </summary>
		public float LineHeightPercentage
		{
			get
			{
				return ReadSingle(0x13C);
			}
			set
			{
				WriteSingle(0x13C,value);
			}
		}
		
	}


	/// <summary>
	/// URichTextBlock:UTextLayoutWidget
	/// Size: 0x328
	/// Properties: 5
	/// </summary>
	public class URichTextBlock:UTextLayoutWidget
	{
		public override int ObjectSize => 808;
		/// <summary>
		/// Name: Text
		/// Type: TextProperty
		/// Offset: 0x140
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: TextDelegate
		/// Type: DelegateProperty
		/// Offset: 0x158
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: Font
		/// Type: StructProperty
		/// Offset: 0x168
		/// Size: 0x40
		/// </summary>
		public FSlateFontInfo Font => ReadStruct<FSlateFontInfo>(0x168);
		
		/// <summary>
		/// Name: Color
		/// Type: StructProperty
		/// Offset: 0x1A8
		/// Size: 0x10
		/// </summary>
		public FLinearColor Color => ReadStruct<FLinearColor>(0x1A8);
		
		/// <summary>
		/// Name: Decorators
		/// Type: TArray<URichTextBlockDecorator>
		/// Offset: 0x1B8
		/// Size: 0x10
		/// SubElement Size: 0x30
		/// </summary>
		public TArray<URichTextBlockDecorator> Decorators => new TArray<URichTextBlockDecorator>(BaseAddress+0x1B8);
		
	}


	/// <summary>
	/// UFCRichTextBlock:URichTextBlock
	/// Size: 0x328
	/// Properties: 0
	/// </summary>
	public class UFCRichTextBlock:URichTextBlock
	{
		public override int ObjectSize => 808;
	}


	/// <summary>
	/// USkinnedMeshComponent:UMeshComponent
	/// Size: 0x7B0
	/// Properties: 31
	/// </summary>
	public class USkinnedMeshComponent:UMeshComponent
	{
		public override int ObjectSize => 1968;
		/// <summary>
		/// Name: SkeletalMesh
		/// Type: ObjectProperty
		/// Offset: 0x658
		/// Size: 0x08
		/// </summary>
		public USkeletalMesh SkeletalMesh => ReadUObject<USkeletalMesh>(0x658);
		
		/// <summary>
		/// Name: bUseBoundsFromMasterPoseComponent
		/// Type: BoolProperty
		/// Offset: 0x6BC
		/// Size: 0x01
		/// </summary>
		public bool bUseBoundsFromMasterPoseComponent => (ReadByte(0x06BC) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: ActiveVertexAnims
		/// Type: TArray<FActiveVertexAnim>
		/// Offset: 0x6C0
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FActiveVertexAnim> ActiveVertexAnims => new TArray<FActiveVertexAnim>(BaseAddress+0x6C0);
		
		/// <summary>
		/// Name: PhysicsAssetOverride
		/// Type: ObjectProperty
		/// Offset: 0x6D0
		/// Size: 0x08
		/// </summary>
		public UPhysicsAsset PhysicsAssetOverride => ReadUObject<UPhysicsAsset>(0x6D0);
		
		/// <summary>
		/// Name: ForcedLodModel
		/// Type: IntProperty
		/// Offset: 0x6D8
		/// Size: 0x04
		/// </summary>
		public int ForcedLodModel
		{
			get
			{
				return ReadInt32(0x6D8);
			}
			set
			{
				WriteInt32(0x6D8,value);
			}
		}
		
		/// <summary>
		/// Name: MinLodModel
		/// Type: IntProperty
		/// Offset: 0x6DC
		/// Size: 0x04
		/// </summary>
		public int MinLodModel
		{
			get
			{
				return ReadInt32(0x6DC);
			}
			set
			{
				WriteInt32(0x6DC,value);
			}
		}
		
		/// <summary>
		/// Name: PredictedLODLevel
		/// Type: IntProperty
		/// Offset: 0x6E0
		/// Size: 0x04
		/// </summary>
		public int PredictedLODLevel
		{
			get
			{
				return ReadInt32(0x6E0);
			}
			set
			{
				WriteInt32(0x6E0,value);
			}
		}
		
		/// <summary>
		/// Name: OldPredictedLODLevel
		/// Type: IntProperty
		/// Offset: 0x6E4
		/// Size: 0x04
		/// </summary>
		public int OldPredictedLODLevel
		{
			get
			{
				return ReadInt32(0x6E4);
			}
			set
			{
				WriteInt32(0x6E4,value);
			}
		}
		
		/// <summary>
		/// Name: MaxDistanceFactor
		/// Type: FloatProperty
		/// Offset: 0x6E8
		/// Size: 0x04
		/// </summary>
		public float MaxDistanceFactor
		{
			get
			{
				return ReadSingle(0x6E8);
			}
			set
			{
				WriteSingle(0x6E8,value);
			}
		}
		
		/// <summary>
		/// Name: LODInfo
		/// Type: TArray<FSkelMeshComponentLODInfo>
		/// Offset: 0x6F0
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FSkelMeshComponentLODInfo> LODInfo => new TArray<FSkelMeshComponentLODInfo>(BaseAddress+0x6F0);
		
		/// <summary>
		/// Name: StreamingDistanceMultiplier
		/// Type: FloatProperty
		/// Offset: 0x700
		/// Size: 0x04
		/// </summary>
		public float StreamingDistanceMultiplier
		{
			get
			{
				return ReadSingle(0x700);
			}
			set
			{
				WriteSingle(0x700,value);
			}
		}
		
		/// <summary>
		/// Name: WireframeColor
		/// Type: StructProperty
		/// Offset: 0x704
		/// Size: 0x04
		/// </summary>
		public FColor WireframeColor => ReadStruct<FColor>(0x704);
		
		/// <summary>
		/// Name: bForceWireframe
		/// Type: BoolProperty
		/// Offset: 0x708
		/// Size: 0x01
		/// </summary>
		public bool bForceWireframe => (ReadByte(0x0708) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bDisplayBones
		/// Type: BoolProperty
		/// Offset: 0x708
		/// Size: 0x01
		/// </summary>
		public bool bDisplayBones => (ReadByte(0x0708) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bDisableMorphTarget
		/// Type: BoolProperty
		/// Offset: 0x708
		/// Size: 0x01
		/// </summary>
		public bool bDisableMorphTarget => (ReadByte(0x0708) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bHideSkin
		/// Type: BoolProperty
		/// Offset: 0x708
		/// Size: 0x01
		/// </summary>
		public bool bHideSkin => (ReadByte(0x0708) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bPerBoneMotionBlur
		/// Type: BoolProperty
		/// Offset: 0x720
		/// Size: 0x01
		/// </summary>
		public bool bPerBoneMotionBlur => (ReadByte(0x0720) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bComponentUseFixedSkelBounds
		/// Type: BoolProperty
		/// Offset: 0x720
		/// Size: 0x01
		/// </summary>
		public bool bComponentUseFixedSkelBounds => (ReadByte(0x0720) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bConsiderAllBodiesForBounds
		/// Type: BoolProperty
		/// Offset: 0x720
		/// Size: 0x01
		/// </summary>
		public bool bConsiderAllBodiesForBounds => (ReadByte(0x0720) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: MeshComponentUpdateFlag
		/// Type: ByteProperty
		/// Offset: 0x724
		/// Size: 0x01
		/// </summary>
		public byte MeshComponentUpdateFlag
		{
			get
			{
				return ReadByte(0x724);
			}
			set
			{
				WriteByte(0x724,value);
			}
		}
		
		/// <summary>
		/// Name: bForceMeshObjectUpdate
		/// Type: BoolProperty
		/// Offset: 0x728
		/// Size: 0x01
		/// </summary>
		public bool bForceMeshObjectUpdate => (ReadByte(0x0728) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bCanHighlightSelectedSections
		/// Type: BoolProperty
		/// Offset: 0x728
		/// Size: 0x01
		/// </summary>
		public bool bCanHighlightSelectedSections => (ReadByte(0x0728) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bRecentlyRendered
		/// Type: BoolProperty
		/// Offset: 0x728
		/// Size: 0x01
		/// </summary>
		public bool bRecentlyRendered => (ReadByte(0x0728) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: ProgressiveDrawingFraction
		/// Type: FloatProperty
		/// Offset: 0x72C
		/// Size: 0x04
		/// </summary>
		public float ProgressiveDrawingFraction
		{
			get
			{
				return ReadSingle(0x72C);
			}
			set
			{
				WriteSingle(0x72C,value);
			}
		}
		
		/// <summary>
		/// Name: CustomSortAlternateIndexMode
		/// Type: ByteProperty
		/// Offset: 0x730
		/// Size: 0x01
		/// </summary>
		public byte CustomSortAlternateIndexMode
		{
			get
			{
				return ReadByte(0x730);
			}
			set
			{
				WriteByte(0x730,value);
			}
		}
		
		/// <summary>
		/// Name: bCastCapsuleDirectShadow
		/// Type: BoolProperty
		/// Offset: 0x734
		/// Size: 0x01
		/// </summary>
		public bool bCastCapsuleDirectShadow => (ReadByte(0x0734) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bCastCapsuleIndirectShadow
		/// Type: BoolProperty
		/// Offset: 0x734
		/// Size: 0x01
		/// </summary>
		public bool bCastCapsuleIndirectShadow => (ReadByte(0x0734) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: CachedLocalBounds
		/// Type: StructProperty
		/// Offset: 0x744
		/// Size: 0x1C
		/// </summary>
		public FBoxSphereBounds CachedLocalBounds => ReadStruct<FBoxSphereBounds>(0x744);
		
		/// <summary>
		/// Name: bCachedLocalBoundsUpToDate
		/// Type: BoolProperty
		/// Offset: 0x760
		/// Size: 0x01
		/// </summary>
		public bool bCachedLocalBoundsUpToDate
		{
			get
			{
				return ReadBool(0x760);
			}
			set
			{
				WriteBool(0x760,value);
			}
		}
		
		/// <summary>
		/// Name: bEnableUpdateRateOptimizations
		/// Type: BoolProperty
		/// Offset: 0x761
		/// Size: 0x01
		/// </summary>
		public bool bEnableUpdateRateOptimizations
		{
			get
			{
				return ReadBool(0x761);
			}
			set
			{
				WriteBool(0x761,value);
			}
		}
		
		/// <summary>
		/// Name: bDisplayDebugUpdateRateOptimizations
		/// Type: BoolProperty
		/// Offset: 0x762
		/// Size: 0x01
		/// </summary>
		public bool bDisplayDebugUpdateRateOptimizations
		{
			get
			{
				return ReadBool(0x762);
			}
			set
			{
				WriteBool(0x762,value);
			}
		}
		
	}


	/// <summary>
	/// USkeletalMeshComponent:USkinnedMeshComponent
	/// Size: 0xD20
	/// Properties: 44
	/// </summary>
	public class USkeletalMeshComponent:USkinnedMeshComponent
	{
		public override int ObjectSize => 3360;
		/// <summary>
		/// Name: AnimationMode
		/// Type: ByteProperty
		/// Offset: 0x7B8
		/// Size: 0x01
		/// </summary>
		public byte AnimationMode
		{
			get
			{
				return ReadByte(0x7B8);
			}
			set
			{
				WriteByte(0x7B8,value);
			}
		}
		
		/// <summary>
		/// Name: AnimBlueprintGeneratedClass
		/// Type: ClassProperty
		/// Offset: 0x7C0
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: AnimClass
		/// Type: ClassProperty
		/// Offset: 0x7C8
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: AnimScriptInstance
		/// Type: ObjectProperty
		/// Offset: 0x7D0
		/// Size: 0x08
		/// </summary>
		public UAnimInstance AnimScriptInstance => ReadUObject<UAnimInstance>(0x7D0);
		
		/// <summary>
		/// Name: AnimationData
		/// Type: StructProperty
		/// Offset: 0x7D8
		/// Size: 0x20
		/// </summary>
		public FSingleAnimationPlayData AnimationData => ReadStruct<FSingleAnimationPlayData>(0x7D8);
		
		/// <summary>
		/// Name: CachedLocalAtoms
		/// Type: TArray<FTransform>
		/// Offset: 0x808
		/// Size: 0x10
		/// SubElement Size: 0x30
		/// </summary>
		public TArray<FTransform> CachedLocalAtoms => new TArray<FTransform>(BaseAddress+0x808);
		
		/// <summary>
		/// Name: CachedSpaceBases
		/// Type: TArray<FTransform>
		/// Offset: 0x818
		/// Size: 0x10
		/// SubElement Size: 0x30
		/// </summary>
		public TArray<FTransform> CachedSpaceBases => new TArray<FTransform>(BaseAddress+0x818);
		
		/// <summary>
		/// Name: GlobalAnimRateScale
		/// Type: FloatProperty
		/// Offset: 0x848
		/// Size: 0x04
		/// </summary>
		public float GlobalAnimRateScale
		{
			get
			{
				return ReadSingle(0x848);
			}
			set
			{
				WriteSingle(0x848,value);
			}
		}
		
		/// <summary>
		/// Name: bHasValidBodies
		/// Type: BoolProperty
		/// Offset: 0x84C
		/// Size: 0x01
		/// </summary>
		public bool bHasValidBodies => (ReadByte(0x084C) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: KinematicBonesUpdateType
		/// Type: ByteProperty
		/// Offset: 0x850
		/// Size: 0x01
		/// </summary>
		public byte KinematicBonesUpdateType
		{
			get
			{
				return ReadByte(0x850);
			}
			set
			{
				WriteByte(0x850,value);
			}
		}
		
		/// <summary>
		/// Name: bBlendPhysics
		/// Type: BoolProperty
		/// Offset: 0x854
		/// Size: 0x01
		/// </summary>
		public bool bBlendPhysics => (ReadByte(0x0854) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bEnablePhysicsOnDedicatedServer
		/// Type: BoolProperty
		/// Offset: 0x854
		/// Size: 0x01
		/// </summary>
		public bool bEnablePhysicsOnDedicatedServer => (ReadByte(0x0854) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bUpdateJointsFromAnimation
		/// Type: BoolProperty
		/// Offset: 0x854
		/// Size: 0x01
		/// </summary>
		public bool bUpdateJointsFromAnimation => (ReadByte(0x0854) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bDisableClothSimulation
		/// Type: BoolProperty
		/// Offset: 0x854
		/// Size: 0x01
		/// </summary>
		public bool bDisableClothSimulation => (ReadByte(0x0854) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bCollideWithEnvironment
		/// Type: BoolProperty
		/// Offset: 0x854
		/// Size: 0x01
		/// </summary>
		public bool bCollideWithEnvironment => (ReadByte(0x0854) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bCollideWithAttachedChildren
		/// Type: BoolProperty
		/// Offset: 0x854
		/// Size: 0x01
		/// </summary>
		public bool bCollideWithAttachedChildren => (ReadByte(0x0854) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: bLocalSpaceSimulation
		/// Type: BoolProperty
		/// Offset: 0x854
		/// Size: 0x01
		/// </summary>
		public bool bLocalSpaceSimulation => (ReadByte(0x0854) & 0x40) == 0x40;
		
		/// <summary>
		/// Name: bClothMorphTarget
		/// Type: BoolProperty
		/// Offset: 0x854
		/// Size: 0x01
		/// </summary>
		public bool bClothMorphTarget => (ReadByte(0x0854) & 0x80) == 0x80;
		
		/// <summary>
		/// Name: bResetAfterTeleport
		/// Type: BoolProperty
		/// Offset: 0x855
		/// Size: 0x01
		/// </summary>
		public bool bResetAfterTeleport => (ReadByte(0x0855) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: TeleportDistanceThreshold
		/// Type: FloatProperty
		/// Offset: 0x858
		/// Size: 0x04
		/// </summary>
		public float TeleportDistanceThreshold
		{
			get
			{
				return ReadSingle(0x858);
			}
			set
			{
				WriteSingle(0x858,value);
			}
		}
		
		/// <summary>
		/// Name: TeleportRotationThreshold
		/// Type: FloatProperty
		/// Offset: 0x85C
		/// Size: 0x04
		/// </summary>
		public float TeleportRotationThreshold
		{
			get
			{
				return ReadSingle(0x85C);
			}
			set
			{
				WriteSingle(0x85C,value);
			}
		}
		
		/// <summary>
		/// Name: ClothBlendWeight
		/// Type: FloatProperty
		/// Offset: 0x860
		/// Size: 0x04
		/// </summary>
		public float ClothBlendWeight
		{
			get
			{
				return ReadSingle(0x860);
			}
			set
			{
				WriteSingle(0x860,value);
			}
		}
		
		/// <summary>
		/// Name: RootBoneTranslation
		/// Type: StructProperty
		/// Offset: 0x868
		/// Size: 0x0C
		/// </summary>
		public FVector RootBoneTranslation => ReadStruct<FVector>(0x868);
		
		/// <summary>
		/// Name: bNoSkeletonUpdate
		/// Type: BoolProperty
		/// Offset: 0x874
		/// Size: 0x01
		/// </summary>
		public bool bNoSkeletonUpdate => (ReadByte(0x0874) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bPauseAnims
		/// Type: BoolProperty
		/// Offset: 0x874
		/// Size: 0x01
		/// </summary>
		public bool bPauseAnims => (ReadByte(0x0874) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bUseRefPoseOnInitAnim
		/// Type: BoolProperty
		/// Offset: 0x878
		/// Size: 0x01
		/// </summary>
		public bool bUseRefPoseOnInitAnim
		{
			get
			{
				return ReadBool(0x878);
			}
			set
			{
				WriteBool(0x878,value);
			}
		}
		
		/// <summary>
		/// Name: bEnablePerPolyCollision
		/// Type: BoolProperty
		/// Offset: 0x87C
		/// Size: 0x01
		/// </summary>
		public bool bEnablePerPolyCollision => (ReadByte(0x087C) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: BodySetup
		/// Type: ObjectProperty
		/// Offset: 0x880
		/// Size: 0x08
		/// </summary>
		public UBodySetup BodySetup => ReadUObject<UBodySetup>(0x880);
		
		/// <summary>
		/// Name: bAutonomousTickPose
		/// Type: BoolProperty
		/// Offset: 0x888
		/// Size: 0x01
		/// </summary>
		public bool bAutonomousTickPose => (ReadByte(0x0888) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bForceRefpose
		/// Type: BoolProperty
		/// Offset: 0x888
		/// Size: 0x01
		/// </summary>
		public bool bForceRefpose => (ReadByte(0x0888) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bOldForceRefPose
		/// Type: BoolProperty
		/// Offset: 0x888
		/// Size: 0x01
		/// </summary>
		public bool bOldForceRefPose => (ReadByte(0x0888) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bShowPrePhysBones
		/// Type: BoolProperty
		/// Offset: 0x888
		/// Size: 0x01
		/// </summary>
		public bool bShowPrePhysBones => (ReadByte(0x0888) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bRequiredBonesUpToDate
		/// Type: BoolProperty
		/// Offset: 0x888
		/// Size: 0x01
		/// </summary>
		public bool bRequiredBonesUpToDate => (ReadByte(0x0888) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bAnimTreeInitialised
		/// Type: BoolProperty
		/// Offset: 0x888
		/// Size: 0x01
		/// </summary>
		public bool bAnimTreeInitialised => (ReadByte(0x0888) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: bEnableLineCheckWithBounds
		/// Type: BoolProperty
		/// Offset: 0x888
		/// Size: 0x01
		/// </summary>
		public bool bEnableLineCheckWithBounds => (ReadByte(0x0888) & 0x40) == 0x40;
		
		/// <summary>
		/// Name: LineCheckBoundsScale
		/// Type: StructProperty
		/// Offset: 0x88C
		/// Size: 0x0C
		/// </summary>
		public FVector LineCheckBoundsScale => ReadStruct<FVector>(0x88C);
		
		/// <summary>
		/// Name: RagdollAggregateThreshold
		/// Type: IntProperty
		/// Offset: 0x898
		/// Size: 0x04
		/// </summary>
		public int RagdollAggregateThreshold
		{
			get
			{
				return ReadInt32(0x898);
			}
			set
			{
				WriteInt32(0x898,value);
			}
		}
		
		/// <summary>
		/// Name: SequenceToPlay
		/// Type: ObjectProperty
		/// Offset: 0xC78
		/// Size: 0x08
		/// </summary>
		public UAnimSequence SequenceToPlay => ReadUObject<UAnimSequence>(0xC78);
		
		/// <summary>
		/// Name: AnimToPlay
		/// Type: ObjectProperty
		/// Offset: 0xC80
		/// Size: 0x08
		/// </summary>
		public UAnimationAsset AnimToPlay => ReadUObject<UAnimationAsset>(0xC80);
		
		/// <summary>
		/// Name: bDefaultLooping
		/// Type: BoolProperty
		/// Offset: 0xC88
		/// Size: 0x01
		/// </summary>
		public bool bDefaultLooping => (ReadByte(0x0C88) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bDefaultPlaying
		/// Type: BoolProperty
		/// Offset: 0xC88
		/// Size: 0x01
		/// </summary>
		public bool bDefaultPlaying => (ReadByte(0x0C88) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: DefaultPosition
		/// Type: FloatProperty
		/// Offset: 0xC8C
		/// Size: 0x04
		/// </summary>
		public float DefaultPosition
		{
			get
			{
				return ReadSingle(0xC8C);
			}
			set
			{
				WriteSingle(0xC8C,value);
			}
		}
		
		/// <summary>
		/// Name: DefaultPlayRate
		/// Type: FloatProperty
		/// Offset: 0xC90
		/// Size: 0x04
		/// </summary>
		public float DefaultPlayRate
		{
			get
			{
				return ReadSingle(0xC90);
			}
			set
			{
				WriteSingle(0xC90,value);
			}
		}
		
		/// <summary>
		/// Name: LastPoseTickTime
		/// Type: FloatProperty
		/// Offset: 0xCA8
		/// Size: 0x04
		/// </summary>
		public float LastPoseTickTime
		{
			get
			{
				return ReadSingle(0xCA8);
			}
			set
			{
				WriteSingle(0xCA8,value);
			}
		}
		
	}


	/// <summary>
	/// UFuncomSkeletalMeshComponent:USkeletalMeshComponent
	/// Size: 0xD40
	/// Properties: 2
	/// </summary>
	public class UFuncomSkeletalMeshComponent:USkeletalMeshComponent
	{
		public override int ObjectSize => 3392;
		/// <summary>
		/// Name: bHasCachedPose
		/// Type: BoolProperty
		/// Offset: 0xD20
		/// Size: 0x01
		/// </summary>
		public bool bHasCachedPose
		{
			get
			{
				return ReadBool(0xD20);
			}
			set
			{
				WriteBool(0xD20,value);
			}
		}
		
		/// <summary>
		/// Name: CachedPose
		/// Type: StructProperty
		/// Offset: 0xD28
		/// Size: 0x10
		/// </summary>
		public FPoseSnapshot CachedPose => ReadStruct<FPoseSnapshot>(0xD28);
		
	}


	/// <summary>
	/// UAvatarItem:UGameItem
	/// Size: 0x368
	/// Properties: 0
	/// </summary>
	public class UAvatarItem:UGameItem
	{
		public override int ObjectSize => 872;
	}


	/// <summary>
	/// UEmoteItem:UGameItem
	/// Size: 0x390
	/// Properties: 3
	/// </summary>
	public class UEmoteItem:UGameItem
	{
		public override int ObjectSize => 912;
		/// <summary>
		/// Name: emoteID
		/// Type: ByteProperty
		/// Offset: 0x360
		/// Size: 0x01
		/// </summary>
		public byte emoteID
		{
			get
			{
				return ReadByte(0x360);
			}
			set
			{
				WriteByte(0x360,value);
			}
		}
		
		/// <summary>
		/// Name: EmoteFlags
		/// Type: IntProperty
		/// Offset: 0x364
		/// Size: 0x04
		/// </summary>
		public int EmoteFlags
		{
			get
			{
				return ReadInt32(0x364);
			}
			set
			{
				WriteInt32(0x364,value);
			}
		}
		
		/// <summary>
		/// Name: EmoteCategory
		/// Type: ByteProperty
		/// Offset: 0x388
		/// Size: 0x01
		/// </summary>
		public byte EmoteCategory
		{
			get
			{
				return ReadByte(0x388);
			}
			set
			{
				WriteByte(0x388,value);
			}
		}
		
	}


	/// <summary>
	/// UFeatItem:UGameItem
	/// Size: 0x3C8
	/// Properties: 7
	/// </summary>
	public class UFeatItem:UGameItem
	{
		public override int ObjectSize => 968;
		/// <summary>
		/// Name: GiveOnSpawn
		/// Type: BoolProperty
		/// Offset: 0x380
		/// Size: 0x01
		/// </summary>
		public bool GiveOnSpawn
		{
			get
			{
				return ReadBool(0x380);
			}
			set
			{
				WriteBool(0x380,value);
			}
		}
		
		/// <summary>
		/// Name: LevelRequirement
		/// Type: IntProperty
		/// Offset: 0x384
		/// Size: 0x04
		/// </summary>
		public int LevelRequirement
		{
			get
			{
				return ReadInt32(0x384);
			}
			set
			{
				WriteInt32(0x384,value);
			}
		}
		
		/// <summary>
		/// Name: FeatCost
		/// Type: IntProperty
		/// Offset: 0x388
		/// Size: 0x04
		/// </summary>
		public int FeatCost
		{
			get
			{
				return ReadInt32(0x388);
			}
			set
			{
				WriteInt32(0x388,value);
			}
		}
		
		/// <summary>
		/// Name: Categories
		/// Type: TArray<>
		/// Offset: 0x390
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: PrerequisiteFeat
		/// Type: TArray<>
		/// Offset: 0x3A0
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: RewardRecipe
		/// Type: TArray<>
		/// Offset: 0x3B0
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: LearnedFromNPC
		/// Type: BoolProperty
		/// Offset: 0x3C0
		/// Size: 0x01
		/// </summary>
		public bool LearnedFromNPC
		{
			get
			{
				return ReadBool(0x3C0);
			}
			set
			{
				WriteBool(0x3C0,value);
			}
		}
		
	}


	/// <summary>
	/// URecipeItem:UGameItem
	/// Size: 0x3D0
	/// Properties: 12
	/// </summary>
	public class URecipeItem:UGameItem
	{
		public override int ObjectSize => 976;
		/// <summary>
		/// Name: RecipeType
		/// Type: IntProperty
		/// Offset: 0x360
		/// Size: 0x04
		/// </summary>
		public int RecipeType
		{
			get
			{
				return ReadInt32(0x360);
			}
			set
			{
				WriteInt32(0x360,value);
			}
		}
		
		/// <summary>
		/// Name: Tier
		/// Type: IntProperty
		/// Offset: 0x364
		/// Size: 0x04
		/// </summary>
		public int Tier
		{
			get
			{
				return ReadInt32(0x364);
			}
			set
			{
				WriteInt32(0x364,value);
			}
		}
		
		/// <summary>
		/// Name: CraftXP
		/// Type: IntProperty
		/// Offset: 0x368
		/// Size: 0x04
		/// </summary>
		public int CraftXP
		{
			get
			{
				return ReadInt32(0x368);
			}
			set
			{
				WriteInt32(0x368,value);
			}
		}
		
		/// <summary>
		/// Name: CraftingStations
		/// Type: IntProperty
		/// Offset: 0x36C
		/// Size: 0x04
		/// </summary>
		public int CraftingStations
		{
			get
			{
				return ReadInt32(0x36C);
			}
			set
			{
				WriteInt32(0x36C,value);
			}
		}
		
		/// <summary>
		/// Name: RequiredFuel
		/// Type: IntProperty
		/// Offset: 0x370
		/// Size: 0x04
		/// </summary>
		public int RequiredFuel
		{
			get
			{
				return ReadInt32(0x370);
			}
			set
			{
				WriteInt32(0x370,value);
			}
		}
		
		/// <summary>
		/// Name: BuildingModuleClass
		/// Type: ClassProperty
		/// Offset: 0x378
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: CraftingCharacterUID
		/// Type: ObjectProperty
		/// Offset: 0x380
		/// Size: 0x08
		/// </summary>
		public UUniqueID CraftingCharacterUID => ReadUObject<UUniqueID>(0x380);
		
		/// <summary>
		/// Name: Ingredients
		/// Type: TArray<FIngredientEntry>
		/// Offset: 0x388
		/// Size: 0x10
		/// SubElement Size: 0x0C
		/// </summary>
		public TArray<FIngredientEntry> Ingredients => new TArray<FIngredientEntry>(BaseAddress+0x388);
		
		/// <summary>
		/// Name: Results
		/// Type: TArray<FIngredientEntry>
		/// Offset: 0x398
		/// Size: 0x10
		/// SubElement Size: 0x0C
		/// </summary>
		public TArray<FIngredientEntry> Results => new TArray<FIngredientEntry>(BaseAddress+0x398);
		
		/// <summary>
		/// Name: BuildingModule
		/// Type: AssetClassProperty
		/// Offset: 0x3A8
		/// Size: 0x20
		/// </summary>
		
		/// <summary>
		/// Name: DestroyStationOnComplete
		/// Type: BoolProperty
		/// Offset: 0x3C8
		/// Size: 0x01
		/// </summary>
		public bool DestroyStationOnComplete
		{
			get
			{
				return ReadBool(0x3C8);
			}
			set
			{
				WriteBool(0x3C8,value);
			}
		}
		
		/// <summary>
		/// Name: ThrallRecipeFeatRequirement
		/// Type: IntProperty
		/// Offset: 0x3CC
		/// Size: 0x04
		/// </summary>
		public int ThrallRecipeFeatRequirement
		{
			get
			{
				return ReadInt32(0x3CC);
			}
			set
			{
				WriteInt32(0x3CC,value);
			}
		}
		
	}


	/// <summary>
	/// UItemInventoryClientMonitor:UObject
	/// Size: 0x30
	/// Properties: 0
	/// </summary>
	public class UItemInventoryClientMonitor:UObject
	{
		public override int ObjectSize => 48;
	}


	/// <summary>
	/// UItemInventory:UPersistenceComponent
	/// Size: 0x280
	/// Properties: 7
	/// </summary>
	public class UItemInventory:UPersistenceComponent
	{
		public override int ObjectSize => 640;
		/// <summary>
		/// Name: DelegateCanBeDropped
		/// Type: DelegateProperty
		/// Offset: 0x188
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: ItemList
		/// Type: TArray<UGameItem>
		/// Offset: 0x210
		/// Size: 0x10
		/// SubElement Size: 0x360
		/// </summary>
		public TArray<UGameItem> ItemList => new TArray<UGameItem>(BaseAddress+0x210);
		
		/// <summary>
		/// Name: bReplicatesToEveryone
		/// Type: BoolProperty
		/// Offset: 0x220
		/// Size: 0x01
		/// </summary>
		public bool bReplicatesToEveryone
		{
			get
			{
				return ReadBool(0x220);
			}
			set
			{
				WriteBool(0x220,value);
			}
		}
		
		/// <summary>
		/// Name: InventoryType
		/// Type: ByteProperty
		/// Offset: 0x221
		/// Size: 0x01
		/// </summary>
		public byte InventoryType
		{
			get
			{
				return ReadByte(0x221);
			}
			set
			{
				WriteByte(0x221,value);
			}
		}
		
		/// <summary>
		/// Name: MaxItemCount
		/// Type: IntProperty
		/// Offset: 0x224
		/// Size: 0x04
		/// </summary>
		public int MaxItemCount
		{
			get
			{
				return ReadInt32(0x224);
			}
			set
			{
				WriteInt32(0x224,value);
			}
		}
		
		/// <summary>
		/// Name: PerishModifier
		/// Type: FloatProperty
		/// Offset: 0x228
		/// Size: 0x04
		/// </summary>
		public float PerishModifier
		{
			get
			{
				return ReadSingle(0x228);
			}
			set
			{
				WriteSingle(0x228,value);
			}
		}
		
		/// <summary>
		/// Name: LootContainerClass
		/// Type: ClassProperty
		/// Offset: 0x270
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// UItemInventoryReplicateToAll:UItemInventory
	/// Size: 0x280
	/// Properties: 0
	/// </summary>
	public class UItemInventoryReplicateToAll:UItemInventory
	{
		public override int ObjectSize => 640;
	}


	/// <summary>
	/// UEquipmentInventory:UItemInventoryReplicateToAll
	/// Size: 0x2A0
	/// Properties: 0
	/// </summary>
	public class UEquipmentInventory:UItemInventoryReplicateToAll
	{
		public override int ObjectSize => 672;
	}


	/// <summary>
	/// UThrallRecipeItem:URecipeItem
	/// Size: 0x3E0
	/// Properties: 3
	/// </summary>
	public class UThrallRecipeItem:URecipeItem
	{
		public override int ObjectSize => 992;
		/// <summary>
		/// Name: SourceThrallItem
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UThrallItem SourceThrallItem => ReadUObject<UThrallItem>(0x3D0);
		
		/// <summary>
		/// Name: SourceThrallItemIndex
		/// Type: IntProperty
		/// Offset: 0x3D8
		/// Size: 0x04
		/// </summary>
		public int SourceThrallItemIndex
		{
			get
			{
				return ReadInt32(0x3D8);
			}
			set
			{
				WriteInt32(0x3D8,value);
			}
		}
		
		/// <summary>
		/// Name: SourceThrallInventoryIndex
		/// Type: IntProperty
		/// Offset: 0x3DC
		/// Size: 0x04
		/// </summary>
		public int SourceThrallInventoryIndex
		{
			get
			{
				return ReadInt32(0x3DC);
			}
			set
			{
				WriteInt32(0x3DC,value);
			}
		}
		
	}


	/// <summary>
	/// UShortcutRefItem:UGameItem
	/// Size: 0x378
	/// Properties: 0
	/// </summary>
	public class UShortcutRefItem:UGameItem
	{
		public override int ObjectSize => 888;
	}


	/// <summary>
	/// UShortcutUsableItem:UGameItem
	/// Size: 0x370
	/// Properties: 0
	/// </summary>
	public class UShortcutUsableItem:UGameItem
	{
		public override int ObjectSize => 880;
	}


	/// <summary>
	/// UBuildingItem:UShortcutUsableItem
	/// Size: 0x3A0
	/// Properties: 2
	/// </summary>
	public class UBuildingItem:UShortcutUsableItem
	{
		public override int ObjectSize => 928;
		/// <summary>
		/// Name: BuildingObject
		/// Type: AssetClassProperty
		/// Offset: 0x370
		/// Size: 0x20
		/// </summary>
		
		/// <summary>
		/// Name: BuildingObjectClass
		/// Type: ClassProperty
		/// Offset: 0x390
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// AThrallBase:AActor
	/// Size: 0x3D0
	/// Properties: 0
	/// </summary>
	public class AThrallBase:AActor
	{
		public override int ObjectSize => 976;
	}


	/// <summary>
	/// UThrallItem:UShortcutUsableItem
	/// Size: 0x550
	/// Properties: 5
	/// </summary>
	public class UThrallItem:UShortcutUsableItem
	{
		public override int ObjectSize => 1360;
		/// <summary>
		/// Name: ThrallCharLayout
		/// Type: StructProperty
		/// Offset: 0x370
		/// Size: 0x124
		/// </summary>
		public FCharacterLayout ThrallCharLayout => ReadStruct<FCharacterLayout>(0x370);
		
		/// <summary>
		/// Name: EquipmentTemplateIDs
		/// Type: TArray<>
		/// Offset: 0x498
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: BackpackTemplateIDs
		/// Type: TArray<>
		/// Offset: 0x4A8
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: ThrallInfo
		/// Type: StructProperty
		/// Offset: 0x4B8
		/// Size: 0x80
		/// </summary>
		public FThrallInfo ThrallInfo => ReadStruct<FThrallInfo>(0x4B8);
		
		/// <summary>
		/// Name: m_bHasRequestedCharLayout
		/// Type: BoolProperty
		/// Offset: 0x548
		/// Size: 0x01
		/// </summary>
		public bool m_bHasRequestedCharLayout
		{
			get
			{
				return ReadBool(0x548);
			}
			set
			{
				WriteBool(0x548,value);
			}
		}
		
	}


	/// <summary>
	/// UGameItemSelection:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UGameItemSelection:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UGameItemSpawner:UBlueprintFunctionLibrary
	/// Size: 0x60
	/// Properties: 7
	/// </summary>
	public class UGameItemSpawner:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 96;
		/// <summary>
		/// Name: m_ItemTable
		/// Type: ObjectProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		public UDataTable m_ItemTable => ReadUObject<UDataTable>(0x28);
		
		/// <summary>
		/// Name: m_RecipeTable
		/// Type: ObjectProperty
		/// Offset: 0x30
		/// Size: 0x08
		/// </summary>
		public UDataTable m_RecipeTable => ReadUObject<UDataTable>(0x30);
		
		/// <summary>
		/// Name: m_EmoteTable
		/// Type: ObjectProperty
		/// Offset: 0x38
		/// Size: 0x08
		/// </summary>
		public UDataTable m_EmoteTable => ReadUObject<UDataTable>(0x38);
		
		/// <summary>
		/// Name: m_FeatTable
		/// Type: ObjectProperty
		/// Offset: 0x40
		/// Size: 0x08
		/// </summary>
		public UDataTable m_FeatTable => ReadUObject<UDataTable>(0x40);
		
		/// <summary>
		/// Name: m_CraftingStationNameTable
		/// Type: ObjectProperty
		/// Offset: 0x48
		/// Size: 0x08
		/// </summary>
		public UDataTable m_CraftingStationNameTable => ReadUObject<UDataTable>(0x48);
		
		/// <summary>
		/// Name: m_DyeItemTable
		/// Type: ObjectProperty
		/// Offset: 0x50
		/// Size: 0x08
		/// </summary>
		public UDataTable m_DyeItemTable => ReadUObject<UDataTable>(0x50);
		
		/// <summary>
		/// Name: m_EquipmentVariationTable
		/// Type: ObjectProperty
		/// Offset: 0x58
		/// Size: 0x08
		/// </summary>
		public UDataTable m_EquipmentVariationTable => ReadUObject<UDataTable>(0x58);
		
	}


	/// <summary>
	/// UGetGuildMembersListCallProxy:UBlueprintAsyncActionBase
	/// Size: 0x58
	/// Properties: 0
	/// </summary>
	public class UGetGuildMembersListCallProxy:UBlueprintAsyncActionBase
	{
		public override int ObjectSize => 88;
	}


	/// <summary>
	/// UGetOwnerCallProxy:UBlueprintAsyncActionBase
	/// Size: 0x58
	/// Properties: 0
	/// </summary>
	public class UGetOwnerCallProxy:UBlueprintAsyncActionBase
	{
		public override int ObjectSize => 88;
	}


	/// <summary>
	/// UHierarchicalInstancedStaticMeshComponent:UInstancedStaticMeshComponent
	/// Size: 0x8C0
	/// Properties: 8
	/// </summary>
	public class UHierarchicalInstancedStaticMeshComponent:UInstancedStaticMeshComponent
	{
		public override int ObjectSize => 2240;
		/// <summary>
		/// Name: SortedInstances
		/// Type: TArray<>
		/// Offset: 0x7E8
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: NumBuiltInstances
		/// Type: IntProperty
		/// Offset: 0x7F8
		/// Size: 0x04
		/// </summary>
		public int NumBuiltInstances
		{
			get
			{
				return ReadInt32(0x7F8);
			}
			set
			{
				WriteInt32(0x7F8,value);
			}
		}
		
		/// <summary>
		/// Name: BuiltInstanceBounds
		/// Type: StructProperty
		/// Offset: 0x800
		/// Size: 0x1C
		/// </summary>
		public FBox BuiltInstanceBounds => ReadStruct<FBox>(0x800);
		
		/// <summary>
		/// Name: UnbuiltInstanceBounds
		/// Type: StructProperty
		/// Offset: 0x81C
		/// Size: 0x1C
		/// </summary>
		public FBox UnbuiltInstanceBounds => ReadStruct<FBox>(0x81C);
		
		/// <summary>
		/// Name: UnbuiltInstanceBoundsList
		/// Type: TArray<FBox>
		/// Offset: 0x838
		/// Size: 0x10
		/// SubElement Size: 0x1C
		/// </summary>
		public TArray<FBox> UnbuiltInstanceBoundsList => new TArray<FBox>(BaseAddress+0x838);
		
		/// <summary>
		/// Name: bEnableDensityScaling
		/// Type: BoolProperty
		/// Offset: 0x848
		/// Size: 0x01
		/// </summary>
		public bool bEnableDensityScaling => (ReadByte(0x0848) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: OcclusionLayerNumNodes
		/// Type: IntProperty
		/// Offset: 0x870
		/// Size: 0x04
		/// </summary>
		public int OcclusionLayerNumNodes
		{
			get
			{
				return ReadInt32(0x870);
			}
			set
			{
				WriteInt32(0x870,value);
			}
		}
		
		/// <summary>
		/// Name: bDisableCollision
		/// Type: BoolProperty
		/// Offset: 0x877
		/// Size: 0x01
		/// </summary>
		public bool bDisableCollision
		{
			get
			{
				return ReadBool(0x877);
			}
			set
			{
				WriteBool(0x877,value);
			}
		}
		
	}


	/// <summary>
	/// UFoliageInstancedStaticMeshComponent:UHierarchicalInstancedStaticMeshComponent
	/// Size: 0x8E0
	/// Properties: 0
	/// </summary>
	public class UFoliageInstancedStaticMeshComponent:UHierarchicalInstancedStaticMeshComponent
	{
		public override int ObjectSize => 2272;
	}


	/// <summary>
	/// UPickupFoliage:UFoliageInstancedStaticMeshComponent
	/// Size: 0xA00
	/// Properties: 2
	/// </summary>
	public class UPickupFoliage:UFoliageInstancedStaticMeshComponent
	{
		public override int ObjectSize => 2560;
		/// <summary>
		/// Name: ReplicatedRespawnParams
		/// Type: StructProperty
		/// Offset: 0x8D8
		/// Size: 0x18
		/// </summary>
		public FoliageRespawnParams ReplicatedRespawnParams => ReadStruct<FoliageRespawnParams>(0x8D8);
		
		/// <summary>
		/// Name: RespawnTimes
		/// Type: TArray<FVector2D>
		/// Offset: 0x8F0
		/// Size: 0x10
		/// SubElement Size: 0x08
		/// </summary>
		public TArray<FVector2D> RespawnTimes => new TArray<FVector2D>(BaseAddress+0x8F0);
		
	}


	/// <summary>
	/// UHarvestFoliage:UFoliageInstancedStaticMeshComponent
	/// Size: 0xA50
	/// Properties: 2
	/// </summary>
	public class UHarvestFoliage:UFoliageInstancedStaticMeshComponent
	{
		public override int ObjectSize => 2640;
		/// <summary>
		/// Name: ReplicatedRespawnParams
		/// Type: StructProperty
		/// Offset: 0x8D8
		/// Size: 0x18
		/// </summary>
		public FoliageRespawnParams ReplicatedRespawnParams => ReadStruct<FoliageRespawnParams>(0x8D8);
		
		/// <summary>
		/// Name: RespawnTimes
		/// Type: TArray<FVector2D>
		/// Offset: 0x8F0
		/// Size: 0x10
		/// SubElement Size: 0x08
		/// </summary>
		public TArray<FVector2D> RespawnTimes => new TArray<FVector2D>(BaseAddress+0x8F0);
		
	}


	/// <summary>
	/// AHarvestFoliageSystem:AActor
	/// Size: 0x430
	/// Properties: 0
	/// </summary>
	public class AHarvestFoliageSystem:AActor
	{
		public override int ObjectSize => 1072;
	}


	/// <summary>
	/// UHeatmapDataGeneration:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UHeatmapDataGeneration:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UIKInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UIKInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UInventoryItemInterfaceBase:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UInventoryItemInterfaceBase:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// AInventoryItemBase:AActor
	/// Size: 0x3E8
	/// Properties: 2
	/// </summary>
	public class AInventoryItemBase:AActor
	{
		public override int ObjectSize => 1000;
		/// <summary>
		/// Name: EquipSocketName
		/// Type: NameProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: OwnerItem
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UGameItem OwnerItem => ReadUObject<UGameItem>(0x3E0);
		
	}


	/// <summary>
	/// UCraftingQueue:UItemInventory
	/// Size: 0x3D0
	/// Properties: 19
	/// </summary>
	public class UCraftingQueue:UItemInventory
	{
		public override int ObjectSize => 976;
		/// <summary>
		/// Name: AcceptedFuels
		/// Type: TArray<>
		/// Offset: 0x278
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: BurnTimeMultiplier
		/// Type: FloatProperty
		/// Offset: 0x288
		/// Size: 0x04
		/// </summary>
		public float BurnTimeMultiplier
		{
			get
			{
				return ReadSingle(0x288);
			}
			set
			{
				WriteSingle(0x288,value);
			}
		}
		
		/// <summary>
		/// Name: AutoScheduleRecipes
		/// Type: BoolProperty
		/// Offset: 0x28C
		/// Size: 0x01
		/// </summary>
		public bool AutoScheduleRecipes
		{
			get
			{
				return ReadBool(0x28C);
			}
			set
			{
				WriteBool(0x28C,value);
			}
		}
		
		/// <summary>
		/// Name: MachineRecipes
		/// Type: TArray<>
		/// Offset: 0x290
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: MaxAutoCraftQueueSize
		/// Type: IntProperty
		/// Offset: 0x2A0
		/// Size: 0x04
		/// </summary>
		public int MaxAutoCraftQueueSize
		{
			get
			{
				return ReadInt32(0x2A0);
			}
			set
			{
				WriteInt32(0x2A0,value);
			}
		}
		
		/// <summary>
		/// Name: MachineBannerImage
		/// Type: ObjectProperty
		/// Offset: 0x2A8
		/// Size: 0x08
		/// </summary>
		public UTexture2D MachineBannerImage => ReadUObject<UTexture2D>(0x2A8);
		
		/// <summary>
		/// Name: CanConvertThralls
		/// Type: BoolProperty
		/// Offset: 0x2B0
		/// Size: 0x01
		/// </summary>
		public bool CanConvertThralls
		{
			get
			{
				return ReadBool(0x2B0);
			}
			set
			{
				WriteBool(0x2B0,value);
			}
		}
		
		/// <summary>
		/// Name: ThrallConversionRecipeIDs
		/// Type: TArray<>
		/// Offset: 0x2B8
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: m_ResourceInventories
		/// Type: TArray<UItemInventory>
		/// Offset: 0x300
		/// Size: 0x10
		/// SubElement Size: 0x280
		/// </summary>
		public TArray<UItemInventory> m_ResourceInventories => new TArray<UItemInventory>(BaseAddress+0x300);
		
		/// <summary>
		/// Name: m_TargetInventories
		/// Type: TArray<UItemInventory>
		/// Offset: 0x310
		/// Size: 0x10
		/// SubElement Size: 0x280
		/// </summary>
		public TArray<UItemInventory> m_TargetInventories => new TArray<UItemInventory>(BaseAddress+0x310);
		
		/// <summary>
		/// Name: m_EquipmentInventory
		/// Type: ObjectProperty
		/// Offset: 0x320
		/// Size: 0x08
		/// </summary>
		public UEquipmentInventory m_EquipmentInventory => ReadUObject<UEquipmentInventory>(0x320);
		
		/// <summary>
		/// Name: m_MachineRecipeList
		/// Type: TArray<URecipeItem>
		/// Offset: 0x328
		/// Size: 0x10
		/// SubElement Size: 0x3D0
		/// </summary>
		public TArray<URecipeItem> m_MachineRecipeList => new TArray<URecipeItem>(BaseAddress+0x328);
		
		/// <summary>
		/// Name: m_ArtisanThrallInventory
		/// Type: ObjectProperty
		/// Offset: 0x338
		/// Size: 0x08
		/// </summary>
		public UItemInventory m_ArtisanThrallInventory => ReadUObject<UItemInventory>(0x338);
		
		/// <summary>
		/// Name: m_ArtisanRecipeInventory
		/// Type: ObjectProperty
		/// Offset: 0x340
		/// Size: 0x08
		/// </summary>
		public UItemInventory m_ArtisanRecipeInventory => ReadUObject<UItemInventory>(0x340);
		
		/// <summary>
		/// Name: m_IsStarted
		/// Type: BoolProperty
		/// Offset: 0x34C
		/// Size: 0x01
		/// </summary>
		public bool m_IsStarted
		{
			get
			{
				return ReadBool(0x34C);
			}
			set
			{
				WriteBool(0x34C,value);
			}
		}
		
		/// <summary>
		/// Name: m_FuelTemplateID
		/// Type: IntProperty
		/// Offset: 0x350
		/// Size: 0x04
		/// </summary>
		public int m_FuelTemplateID
		{
			get
			{
				return ReadInt32(0x350);
			}
			set
			{
				WriteInt32(0x350,value);
			}
		}
		
		/// <summary>
		/// Name: m_CurrentBurnTimePerFuelItem
		/// Type: FloatProperty
		/// Offset: 0x354
		/// Size: 0x04
		/// </summary>
		public float m_CurrentBurnTimePerFuelItem
		{
			get
			{
				return ReadSingle(0x354);
			}
			set
			{
				WriteSingle(0x354,value);
			}
		}
		
		/// <summary>
		/// Name: m_RemainingBurnTime
		/// Type: FloatProperty
		/// Offset: 0x358
		/// Size: 0x04
		/// </summary>
		public float m_RemainingBurnTime
		{
			get
			{
				return ReadSingle(0x358);
			}
			set
			{
				WriteSingle(0x358,value);
			}
		}
		
		/// <summary>
		/// Name: m_CurrentBurnTimePerFuelItemBase
		/// Type: FloatProperty
		/// Offset: 0x35C
		/// Size: 0x04
		/// </summary>
		public float m_CurrentBurnTimePerFuelItemBase
		{
			get
			{
				return ReadSingle(0x35C);
			}
			set
			{
				WriteSingle(0x35C,value);
			}
		}
		
	}


	/// <summary>
	/// UEmoteInventory:UItemInventory
	/// Size: 0x290
	/// Properties: 0
	/// </summary>
	public class UEmoteInventory:UItemInventory
	{
		public override int ObjectSize => 656;
	}


	/// <summary>
	/// UFeatInventory:UItemInventory
	/// Size: 0x280
	/// Properties: 0
	/// </summary>
	public class UFeatInventory:UItemInventory
	{
		public override int ObjectSize => 640;
	}


	/// <summary>
	/// URecipeManager:UItemInventory
	/// Size: 0x2A0
	/// Properties: 0
	/// </summary>
	public class URecipeManager:UItemInventory
	{
		public override int ObjectSize => 672;
	}


	/// <summary>
	/// ULandClaimCell:UObject
	/// Size: 0xC0
	/// Properties: 2
	/// </summary>
	public class ULandClaimCell:UObject
	{
		public override int ObjectSize => 192;
		/// <summary>
		/// Name: CellDataIndex
		/// Type: IntProperty
		/// Offset: 0xB0
		/// Size: 0x04
		/// </summary>
		public int CellDataIndex
		{
			get
			{
				return ReadInt32(0xB0);
			}
			set
			{
				WriteInt32(0xB0,value);
			}
		}
		
		/// <summary>
		/// Name: RefCount
		/// Type: IntProperty
		/// Offset: 0xB4
		/// Size: 0x04
		/// </summary>
		public int RefCount
		{
			get
			{
				return ReadInt32(0xB4);
			}
			set
			{
				WriteInt32(0xB4,value);
			}
		}
		
	}


	/// <summary>
	/// ULandClaimSystem:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class ULandClaimSystem:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// ULoadCharacterCallProxy:UBlueprintAsyncActionBase
	/// Size: 0x78
	/// Properties: 3
	/// </summary>
	public class ULoadCharacterCallProxy:UBlueprintAsyncActionBase
	{
		public override int ObjectSize => 120;
		/// <summary>
		/// Name: WorldContextObject
		/// Type: ObjectProperty
		/// Offset: 0x48
		/// Size: 0x08
		/// </summary>
		public UObject WorldContextObject => ReadUObject<UObject>(0x48);
		
		/// <summary>
		/// Name: UID
		/// Type: ObjectProperty
		/// Offset: 0x50
		/// Size: 0x08
		/// </summary>
		public UUniqueID UID => ReadUObject<UUniqueID>(0x50);
		
		/// <summary>
		/// Name: IsNPC
		/// Type: BoolProperty
		/// Offset: 0x58
		/// Size: 0x01
		/// </summary>
		public bool IsNPC
		{
			get
			{
				return ReadBool(0x58);
			}
			set
			{
				WriteBool(0x58,value);
			}
		}
		
	}


	/// <summary>
	/// ULoadGuildIdCallProxy:UBlueprintAsyncActionBase
	/// Size: 0x58
	/// Properties: 0
	/// </summary>
	public class ULoadGuildIdCallProxy:UBlueprintAsyncActionBase
	{
		public override int ObjectSize => 88;
	}


	/// <summary>
	/// ULoadGuildsCallProxy:UBlueprintAsyncActionBase
	/// Size: 0x50
	/// Properties: 0
	/// </summary>
	public class ULoadGuildsCallProxy:UBlueprintAsyncActionBase
	{
		public override int ObjectSize => 80;
	}


	/// <summary>
	/// ULoadInventoryCallProxy:UBlueprintAsyncActionBase
	/// Size: 0x70
	/// Properties: 0
	/// </summary>
	public class ULoadInventoryCallProxy:UBlueprintAsyncActionBase
	{
		public override int ObjectSize => 112;
	}


	/// <summary>
	/// ULoadStatHolderCallProxy:UBlueprintAsyncActionBase
	/// Size: 0xC0
	/// Properties: 0
	/// </summary>
	public class ULoadStatHolderCallProxy:UBlueprintAsyncActionBase
	{
		public override int ObjectSize => 192;
	}


	/// <summary>
	/// ALootContainer:AActor
	/// Size: 0x3E8
	/// Properties: 2
	/// </summary>
	public class ALootContainer:AActor
	{
		public override int ObjectSize => 1000;
		/// <summary>
		/// Name: m_InventoryMonitor
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UItemInventoryClientMonitor m_InventoryMonitor => ReadUObject<UItemInventoryClientMonitor>(0x3D0);
		
		/// <summary>
		/// Name: m_Inventory
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UItemInventory m_Inventory => ReadUObject<UItemInventory>(0x3D8);
		
	}


	/// <summary>
	/// AStaticMeshActor:AActor
	/// Size: 0x3E0
	/// Properties: 3
	/// </summary>
	public class AStaticMeshActor:AActor
	{
		public override int ObjectSize => 992;
		/// <summary>
		/// Name: StaticMeshComponent
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent StaticMeshComponent => ReadUObject<UStaticMeshComponent>(0x3D0);
		
		/// <summary>
		/// Name: bStaticMeshReplicateMovement
		/// Type: BoolProperty
		/// Offset: 0x3D8
		/// Size: 0x01
		/// </summary>
		public bool bStaticMeshReplicateMovement
		{
			get
			{
				return ReadBool(0x3D8);
			}
			set
			{
				WriteBool(0x3D8,value);
			}
		}
		
		/// <summary>
		/// Name: NavigationGeometryGatheringMode
		/// Type: ByteProperty
		/// Offset: 0x3D9
		/// Size: 0x01
		/// </summary>
		public byte NavigationGeometryGatheringMode
		{
			get
			{
				return ReadByte(0x3D9);
			}
			set
			{
				WriteByte(0x3D9,value);
			}
		}
		
	}


	/// <summary>
	/// ALoreMeshActor:AStaticMeshActor
	/// Size: 0x3F0
	/// Properties: 1
	/// </summary>
	public class ALoreMeshActor:AStaticMeshActor
	{
		public override int ObjectSize => 1008;
		/// <summary>
		/// Name: LoreId
		/// Type: IntProperty
		/// Offset: 0x3E8
		/// Size: 0x04
		/// </summary>
		public int LoreId
		{
			get
			{
				return ReadInt32(0x3E8);
			}
			set
			{
				WriteInt32(0x3E8,value);
			}
		}
		
	}


	/// <summary>
	/// UNPCCommunicationInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UNPCCommunicationInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UNPCCommunicationHelper:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UNPCCommunicationHelper:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UOnScreenInfoInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UOnScreenInfoInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UPathFollowingAnimationInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UPathFollowingAnimationInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UPathPoints:UObject
	/// Size: 0x48
	/// Properties: 1
	/// </summary>
	public class UPathPoints:UObject
	{
		public override int ObjectSize => 72;
		/// <summary>
		/// Name: PathPoints
		/// Type: TArray<FVector>
		/// Offset: 0x28
		/// Size: 0x10
		/// SubElement Size: 0x0C
		/// </summary>
		public TArray<FVector> PathPoints => new TArray<FVector>(BaseAddress+0x28);
		
	}


	/// <summary>
	/// UPlayerMarkerComponent:UActorComponent
	/// Size: 0xD8
	/// Properties: 0
	/// </summary>
	public class UPlayerMarkerComponent:UActorComponent
	{
		public override int ObjectSize => 216;
	}


	/// <summary>
	/// APlayerPawnRegistry:AActor
	/// Size: 0x3E0
	/// Properties: 1
	/// </summary>
	public class APlayerPawnRegistry:AActor
	{
		public override int ObjectSize => 992;
		/// <summary>
		/// Name: m_ExtraPlayerPawns
		/// Type: TArray<APawn>
		/// Offset: 0x3D0
		/// Size: 0x10
		/// SubElement Size: 0x430
		/// </summary>
		public TArray<APawn> m_ExtraPlayerPawns => new TArray<APawn>(BaseAddress+0x3D0);
		
	}


	/// <summary>
	/// URadialMenuEntry:UObject
	/// Size: 0xA8
	/// Properties: 9
	/// </summary>
	public class URadialMenuEntry:UObject
	{
		public override int ObjectSize => 168;
		/// <summary>
		/// Name: label
		/// Type: TextProperty
		/// Offset: 0x28
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: subtitle
		/// Type: TextProperty
		/// Offset: 0x40
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: Icon
		/// Type: ObjectProperty
		/// Offset: 0x58
		/// Size: 0x08
		/// </summary>
		public UTexture2D Icon => ReadUObject<UTexture2D>(0x58);
		
		/// <summary>
		/// Name: UserCategory
		/// Type: IntProperty
		/// Offset: 0x60
		/// Size: 0x04
		/// </summary>
		public int UserCategory
		{
			get
			{
				return ReadInt32(0x60);
			}
			set
			{
				WriteInt32(0x60,value);
			}
		}
		
		/// <summary>
		/// Name: UserValue
		/// Type: IntProperty
		/// Offset: 0x64
		/// Size: 0x04
		/// </summary>
		public int UserValue
		{
			get
			{
				return ReadInt32(0x64);
			}
			set
			{
				WriteInt32(0x64,value);
			}
		}
		
		/// <summary>
		/// Name: UserObject
		/// Type: ObjectProperty
		/// Offset: 0x68
		/// Size: 0x08
		/// </summary>
		public UObject UserObject => ReadUObject<UObject>(0x68);
		
		/// <summary>
		/// Name: KeyShortcutName
		/// Type: NameProperty
		/// Offset: 0x70
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: m_ChildEntries
		/// Type: TArray<URadialMenuEntry>
		/// Offset: 0x90
		/// Size: 0x10
		/// SubElement Size: 0xA8
		/// </summary>
		public TArray<URadialMenuEntry> m_ChildEntries => new TArray<URadialMenuEntry>(BaseAddress+0x90);
		
		/// <summary>
		/// Name: m_Parent
		/// Type: ObjectProperty
		/// Offset: 0xA0
		/// Size: 0x08
		/// </summary>
		public URadialMenuEntry m_Parent => ReadUObject<URadialMenuEntry>(0xA0);
		
	}


	/// <summary>
	/// URadialMenu:URootWidget
	/// Size: 0x478
	/// Properties: 29
	/// </summary>
	public class URadialMenu:URootWidget
	{
		public override int ObjectSize => 1144;
		/// <summary>
		/// Name: AnimTime
		/// Type: FloatProperty
		/// Offset: 0x308
		/// Size: 0x04
		/// </summary>
		public float AnimTime
		{
			get
			{
				return ReadSingle(0x308);
			}
			set
			{
				WriteSingle(0x308,value);
			}
		}
		
		/// <summary>
		/// Name: AnimFullRadiusThreshold
		/// Type: FloatProperty
		/// Offset: 0x30C
		/// Size: 0x04
		/// </summary>
		public float AnimFullRadiusThreshold
		{
			get
			{
				return ReadSingle(0x30C);
			}
			set
			{
				WriteSingle(0x30C,value);
			}
		}
		
		/// <summary>
		/// Name: StartAngle
		/// Type: FloatProperty
		/// Offset: 0x310
		/// Size: 0x04
		/// </summary>
		public float StartAngle
		{
			get
			{
				return ReadSingle(0x310);
			}
			set
			{
				WriteSingle(0x310,value);
			}
		}
		
		/// <summary>
		/// Name: InnerRadius
		/// Type: FloatProperty
		/// Offset: 0x314
		/// Size: 0x04
		/// </summary>
		public float InnerRadius
		{
			get
			{
				return ReadSingle(0x314);
			}
			set
			{
				WriteSingle(0x314,value);
			}
		}
		
		/// <summary>
		/// Name: OuterRadius
		/// Type: FloatProperty
		/// Offset: 0x318
		/// Size: 0x04
		/// </summary>
		public float OuterRadius
		{
			get
			{
				return ReadSingle(0x318);
			}
			set
			{
				WriteSingle(0x318,value);
			}
		}
		
		/// <summary>
		/// Name: IconCenterRadius
		/// Type: FloatProperty
		/// Offset: 0x31C
		/// Size: 0x04
		/// </summary>
		public float IconCenterRadius
		{
			get
			{
				return ReadSingle(0x31C);
			}
			set
			{
				WriteSingle(0x31C,value);
			}
		}
		
		/// <summary>
		/// Name: StartCapOffset
		/// Type: StructProperty
		/// Offset: 0x320
		/// Size: 0x08
		/// </summary>
		public FVector2D StartCapOffset => ReadStruct<FVector2D>(0x320);
		
		/// <summary>
		/// Name: EndCapOffset
		/// Type: StructProperty
		/// Offset: 0x328
		/// Size: 0x08
		/// </summary>
		public FVector2D EndCapOffset => ReadStruct<FVector2D>(0x328);
		
		/// <summary>
		/// Name: StartCapScale
		/// Type: StructProperty
		/// Offset: 0x330
		/// Size: 0x08
		/// </summary>
		public FVector2D StartCapScale => ReadStruct<FVector2D>(0x330);
		
		/// <summary>
		/// Name: EndCapScale
		/// Type: StructProperty
		/// Offset: 0x338
		/// Size: 0x08
		/// </summary>
		public FVector2D EndCapScale => ReadStruct<FVector2D>(0x338);
		
		/// <summary>
		/// Name: SegmentSpacing
		/// Type: FloatProperty
		/// Offset: 0x340
		/// Size: 0x04
		/// </summary>
		public float SegmentSpacing
		{
			get
			{
				return ReadSingle(0x340);
			}
			set
			{
				WriteSingle(0x340,value);
			}
		}
		
		/// <summary>
		/// Name: SelectedScale
		/// Type: FloatProperty
		/// Offset: 0x344
		/// Size: 0x04
		/// </summary>
		public float SelectedScale
		{
			get
			{
				return ReadSingle(0x344);
			}
			set
			{
				WriteSingle(0x344,value);
			}
		}
		
		/// <summary>
		/// Name: HoverScale
		/// Type: FloatProperty
		/// Offset: 0x348
		/// Size: 0x04
		/// </summary>
		public float HoverScale
		{
			get
			{
				return ReadSingle(0x348);
			}
			set
			{
				WriteSingle(0x348,value);
			}
		}
		
		/// <summary>
		/// Name: SegmentViewClass
		/// Type: ClassProperty
		/// Offset: 0x350
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: SegmentTextureUnselected
		/// Type: ObjectProperty
		/// Offset: 0x358
		/// Size: 0x08
		/// </summary>
		public UTexture2D SegmentTextureUnselected => ReadUObject<UTexture2D>(0x358);
		
		/// <summary>
		/// Name: SegmentTextureSelected
		/// Type: ObjectProperty
		/// Offset: 0x360
		/// Size: 0x08
		/// </summary>
		public UTexture2D SegmentTextureSelected => ReadUObject<UTexture2D>(0x360);
		
		/// <summary>
		/// Name: SegmentTextureHovered
		/// Type: ObjectProperty
		/// Offset: 0x368
		/// Size: 0x08
		/// </summary>
		public UTexture2D SegmentTextureHovered => ReadUObject<UTexture2D>(0x368);
		
		/// <summary>
		/// Name: StartCapTextureUnselected
		/// Type: ObjectProperty
		/// Offset: 0x370
		/// Size: 0x08
		/// </summary>
		public UTexture2D StartCapTextureUnselected => ReadUObject<UTexture2D>(0x370);
		
		/// <summary>
		/// Name: StartCapTextureSelected
		/// Type: ObjectProperty
		/// Offset: 0x378
		/// Size: 0x08
		/// </summary>
		public UTexture2D StartCapTextureSelected => ReadUObject<UTexture2D>(0x378);
		
		/// <summary>
		/// Name: StartCapTextureHovered
		/// Type: ObjectProperty
		/// Offset: 0x380
		/// Size: 0x08
		/// </summary>
		public UTexture2D StartCapTextureHovered => ReadUObject<UTexture2D>(0x380);
		
		/// <summary>
		/// Name: EndCapTextureUnselected
		/// Type: ObjectProperty
		/// Offset: 0x388
		/// Size: 0x08
		/// </summary>
		public UTexture2D EndCapTextureUnselected => ReadUObject<UTexture2D>(0x388);
		
		/// <summary>
		/// Name: EndCapTextureSelected
		/// Type: ObjectProperty
		/// Offset: 0x390
		/// Size: 0x08
		/// </summary>
		public UTexture2D EndCapTextureSelected => ReadUObject<UTexture2D>(0x390);
		
		/// <summary>
		/// Name: EndCapTextureHovered
		/// Type: ObjectProperty
		/// Offset: 0x398
		/// Size: 0x08
		/// </summary>
		public UTexture2D EndCapTextureHovered => ReadUObject<UTexture2D>(0x398);
		
		/// <summary>
		/// Name: InputAxisDeadZone
		/// Type: FloatProperty
		/// Offset: 0x3A0
		/// Size: 0x04
		/// </summary>
		public float InputAxisDeadZone
		{
			get
			{
				return ReadSingle(0x3A0);
			}
			set
			{
				WriteSingle(0x3A0,value);
			}
		}
		
		/// <summary>
		/// Name: PressedSlateSound
		/// Type: StructProperty
		/// Offset: 0x3A8
		/// Size: 0x18
		/// </summary>
		public FSlateSound PressedSlateSound => ReadStruct<FSlateSound>(0x3A8);
		
		/// <summary>
		/// Name: HoveredSlateSound
		/// Type: StructProperty
		/// Offset: 0x3C0
		/// Size: 0x18
		/// </summary>
		public FSlateSound HoveredSlateSound => ReadStruct<FSlateSound>(0x3C0);
		
		/// <summary>
		/// Name: m_CurrentSubMenu
		/// Type: ObjectProperty
		/// Offset: 0x450
		/// Size: 0x08
		/// </summary>
		public URadialMenuEntry m_CurrentSubMenu => ReadUObject<URadialMenuEntry>(0x450);
		
		/// <summary>
		/// Name: m_RootEntries
		/// Type: TArray<URadialMenuEntry>
		/// Offset: 0x458
		/// Size: 0x10
		/// SubElement Size: 0xA8
		/// </summary>
		public TArray<URadialMenuEntry> m_RootEntries => new TArray<URadialMenuEntry>(BaseAddress+0x458);
		
		/// <summary>
		/// Name: m_ShortcutsInputComponent
		/// Type: ObjectProperty
		/// Offset: 0x470
		/// Size: 0x08
		/// </summary>
		public UInputComponent m_ShortcutsInputComponent => ReadUObject<UInputComponent>(0x470);
		
	}


	/// <summary>
	/// URandomWalkComponent:UActorComponent
	/// Size: 0xD8
	/// Properties: 0
	/// </summary>
	public class URandomWalkComponent:UActorComponent
	{
		public override int ObjectSize => 216;
	}


	/// <summary>
	/// AResourceActorBase:AActor
	/// Size: 0x3D0
	/// Properties: 0
	/// </summary>
	public class AResourceActorBase:AActor
	{
		public override int ObjectSize => 976;
	}


	/// <summary>
	/// UAttributesBase:URootWidget
	/// Size: 0x398
	/// Properties: 1
	/// </summary>
	public class UAttributesBase:URootWidget
	{
		public override int ObjectSize => 920;
		/// <summary>
		/// Name: m_ProgressionSystem
		/// Type: ObjectProperty
		/// Offset: 0x308
		/// Size: 0x08
		/// </summary>
		public UProgressionSystem m_ProgressionSystem => ReadUObject<UProgressionSystem>(0x308);
		
	}


	/// <summary>
	/// UCircularProgressbar:URootWidget
	/// Size: 0x3F8
	/// Properties: 11
	/// </summary>
	public class UCircularProgressbar:URootWidget
	{
		public override int ObjectSize => 1016;
		/// <summary>
		/// Name: progress
		/// Type: FloatProperty
		/// Offset: 0x308
		/// Size: 0x04
		/// </summary>
		public float progress
		{
			get
			{
				return ReadSingle(0x308);
			}
			set
			{
				WriteSingle(0x308,value);
			}
		}
		
		/// <summary>
		/// Name: SegmentSpacing
		/// Type: FloatProperty
		/// Offset: 0x30C
		/// Size: 0x04
		/// </summary>
		public float SegmentSpacing
		{
			get
			{
				return ReadSingle(0x30C);
			}
			set
			{
				WriteSingle(0x30C,value);
			}
		}
		
		/// <summary>
		/// Name: StartAngle
		/// Type: FloatProperty
		/// Offset: 0x310
		/// Size: 0x04
		/// </summary>
		public float StartAngle
		{
			get
			{
				return ReadSingle(0x310);
			}
			set
			{
				WriteSingle(0x310,value);
			}
		}
		
		/// <summary>
		/// Name: AngleSpan
		/// Type: FloatProperty
		/// Offset: 0x314
		/// Size: 0x04
		/// </summary>
		public float AngleSpan
		{
			get
			{
				return ReadSingle(0x314);
			}
			set
			{
				WriteSingle(0x314,value);
			}
		}
		
		/// <summary>
		/// Name: InnerRadius
		/// Type: FloatProperty
		/// Offset: 0x318
		/// Size: 0x04
		/// </summary>
		public float InnerRadius
		{
			get
			{
				return ReadSingle(0x318);
			}
			set
			{
				WriteSingle(0x318,value);
			}
		}
		
		/// <summary>
		/// Name: OuterRadius
		/// Type: FloatProperty
		/// Offset: 0x31C
		/// Size: 0x04
		/// </summary>
		public float OuterRadius
		{
			get
			{
				return ReadSingle(0x31C);
			}
			set
			{
				WriteSingle(0x31C,value);
			}
		}
		
		/// <summary>
		/// Name: IconBrush
		/// Type: StructProperty
		/// Offset: 0x320
		/// Size: 0x90
		/// </summary>
		public FSlateBrush IconBrush => ReadStruct<FSlateBrush>(0x320);
		
		/// <summary>
		/// Name: IconColorAndOpacity
		/// Type: StructProperty
		/// Offset: 0x3B0
		/// Size: 0x10
		/// </summary>
		public FLinearColor IconColorAndOpacity => ReadStruct<FLinearColor>(0x3B0);
		
		/// <summary>
		/// Name: TextureEmpty
		/// Type: ObjectProperty
		/// Offset: 0x3C0
		/// Size: 0x08
		/// </summary>
		public UTexture2D TextureEmpty => ReadUObject<UTexture2D>(0x3C0);
		
		/// <summary>
		/// Name: ColorAndOpacityEmpty
		/// Type: StructProperty
		/// Offset: 0x3C8
		/// Size: 0x10
		/// </summary>
		public FLinearColor ColorAndOpacityEmpty => ReadStruct<FLinearColor>(0x3C8);
		
		/// <summary>
		/// Name: Segments
		/// Type: TArray<FCircularProgressbarSegment>
		/// Offset: 0x3D8
		/// Size: 0x10
		/// SubElement Size: 0x20
		/// </summary>
		public TArray<FCircularProgressbarSegment> Segments => new TArray<FCircularProgressbarSegment>(BaseAddress+0x3D8);
		
	}


	/// <summary>
	/// UCraftingManagerGUI:URootWidget
	/// Size: 0x310
	/// Properties: 0
	/// </summary>
	public class UCraftingManagerGUI:URootWidget
	{
		public override int ObjectSize => 784;
	}


	/// <summary>
	/// UCraftingPanel:URootWidget
	/// Size: 0x428
	/// Properties: 9
	/// </summary>
	public class UCraftingPanel:URootWidget
	{
		public override int ObjectSize => 1064;
		/// <summary>
		/// Name: MinRecipeIconSize
		/// Type: FloatProperty
		/// Offset: 0x308
		/// Size: 0x04
		/// </summary>
		public float MinRecipeIconSize
		{
			get
			{
				return ReadSingle(0x308);
			}
			set
			{
				WriteSingle(0x308,value);
			}
		}
		
		/// <summary>
		/// Name: MaxRecipeIconSize
		/// Type: FloatProperty
		/// Offset: 0x30C
		/// Size: 0x04
		/// </summary>
		public float MaxRecipeIconSize
		{
			get
			{
				return ReadSingle(0x30C);
			}
			set
			{
				WriteSingle(0x30C,value);
			}
		}
		
		/// <summary>
		/// Name: m_StationInventory
		/// Type: ObjectProperty
		/// Offset: 0x3C0
		/// Size: 0x08
		/// </summary>
		public UItemInventory m_StationInventory => ReadUObject<UItemInventory>(0x3C0);
		
		/// <summary>
		/// Name: m_ShortcutBar
		/// Type: ObjectProperty
		/// Offset: 0x3C8
		/// Size: 0x08
		/// </summary>
		public UItemInventory m_ShortcutBar => ReadUObject<UItemInventory>(0x3C8);
		
		/// <summary>
		/// Name: m_RecipeIngredientsInventory
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UItemInventory m_RecipeIngredientsInventory => ReadUObject<UItemInventory>(0x3D0);
		
		/// <summary>
		/// Name: m_CraftingStation
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public APlaceableBase m_CraftingStation => ReadUObject<APlaceableBase>(0x3D8);
		
		/// <summary>
		/// Name: m_CraftingQueue
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UCraftingQueue m_CraftingQueue => ReadUObject<UCraftingQueue>(0x3E0);
		
		/// <summary>
		/// Name: m_ArtisanThrallInventory
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UItemInventory m_ArtisanThrallInventory => ReadUObject<UItemInventory>(0x3E8);
		
		/// <summary>
		/// Name: m_CurrentlySelectedRecipe
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public URecipeItem m_CurrentlySelectedRecipe => ReadUObject<URecipeItem>(0x3F0);
		
	}


	/// <summary>
	/// UCraftingStationInventoryView:URootWidget
	/// Size: 0x380
	/// Properties: 1
	/// </summary>
	public class UCraftingStationInventoryView:URootWidget
	{
		public override int ObjectSize => 896;
		/// <summary>
		/// Name: m_CraftingQueue
		/// Type: ObjectProperty
		/// Offset: 0x308
		/// Size: 0x08
		/// </summary>
		public UCraftingQueue m_CraftingQueue => ReadUObject<UCraftingQueue>(0x308);
		
	}


	/// <summary>
	/// UEditableLabeledSlider:URootWidget
	/// Size: 0xDD0
	/// Properties: 7
	/// </summary>
	public class UEditableLabeledSlider:URootWidget
	{
		public override int ObjectSize => 3536;
		/// <summary>
		/// Name: Value
		/// Type: FloatProperty
		/// Offset: 0x308
		/// Size: 0x04
		/// </summary>
		public float Value
		{
			get
			{
				return ReadSingle(0x308);
			}
			set
			{
				WriteSingle(0x308,value);
			}
		}
		
		/// <summary>
		/// Name: MinValue
		/// Type: FloatProperty
		/// Offset: 0x30C
		/// Size: 0x04
		/// </summary>
		public float MinValue
		{
			get
			{
				return ReadSingle(0x30C);
			}
			set
			{
				WriteSingle(0x30C,value);
			}
		}
		
		/// <summary>
		/// Name: MaxValue
		/// Type: FloatProperty
		/// Offset: 0x310
		/// Size: 0x04
		/// </summary>
		public float MaxValue
		{
			get
			{
				return ReadSingle(0x310);
			}
			set
			{
				WriteSingle(0x310,value);
			}
		}
		
		/// <summary>
		/// Name: MinFractionalDigits
		/// Type: IntProperty
		/// Offset: 0x314
		/// Size: 0x04
		/// </summary>
		public int MinFractionalDigits
		{
			get
			{
				return ReadInt32(0x314);
			}
			set
			{
				WriteInt32(0x314,value);
			}
		}
		
		/// <summary>
		/// Name: MaxFractionalDigits
		/// Type: IntProperty
		/// Offset: 0x318
		/// Size: 0x04
		/// </summary>
		public int MaxFractionalDigits
		{
			get
			{
				return ReadInt32(0x318);
			}
			set
			{
				WriteInt32(0x318,value);
			}
		}
		
		/// <summary>
		/// Name: SliderWidgetStyle
		/// Type: StructProperty
		/// Offset: 0x320
		/// Size: 0x250
		/// </summary>
		public FSliderStyle SliderWidgetStyle => ReadStruct<FSliderStyle>(0x320);
		
		/// <summary>
		/// Name: TextWidgetStyle
		/// Type: StructProperty
		/// Offset: 0x570
		/// Size: 0x848
		/// </summary>
		public FEditableTextBoxStyle TextWidgetStyle => ReadStruct<FEditableTextBoxStyle>(0x570);
		
	}


	/// <summary>
	/// UInventoryFilterSelector:URootWidget
	/// Size: 0x3A8
	/// Properties: 1
	/// </summary>
	public class UInventoryFilterSelector:URootWidget
	{
		public override int ObjectSize => 936;
		/// <summary>
		/// Name: ShowEncumbrance
		/// Type: BoolProperty
		/// Offset: 0x308
		/// Size: 0x01
		/// </summary>
		public bool ShowEncumbrance
		{
			get
			{
				return ReadBool(0x308);
			}
			set
			{
				WriteBool(0x308,value);
			}
		}
		
	}


	/// <summary>
	/// UInventoryViewBase:URootWidget
	/// Size: 0x490
	/// Properties: 2
	/// </summary>
	public class UInventoryViewBase:URootWidget
	{
		public override int ObjectSize => 1168;
		/// <summary>
		/// Name: inventory
		/// Type: ObjectProperty
		/// Offset: 0x348
		/// Size: 0x08
		/// </summary>
		public UItemInventory inventory => ReadUObject<UItemInventory>(0x348);
		
		/// <summary>
		/// Name: FilterButtonSpacing
		/// Type: FloatProperty
		/// Offset: 0x350
		/// Size: 0x04
		/// </summary>
		public float FilterButtonSpacing
		{
			get
			{
				return ReadSingle(0x350);
			}
			set
			{
				WriteSingle(0x350,value);
			}
		}
		
	}


	/// <summary>
	/// UInventoryItemActionBar:URootWidget
	/// Size: 0x338
	/// Properties: 2
	/// </summary>
	public class UInventoryItemActionBar:URootWidget
	{
		public override int ObjectSize => 824;
		/// <summary>
		/// Name: m_ButtonListLeft
		/// Type: TArray<UFCButton>
		/// Offset: 0x318
		/// Size: 0x10
		/// SubElement Size: 0xB90
		/// </summary>
		public TArray<UFCButton> m_ButtonListLeft => new TArray<UFCButton>(BaseAddress+0x318);
		
		/// <summary>
		/// Name: m_ButtonListRight
		/// Type: TArray<UFCButton>
		/// Offset: 0x328
		/// Size: 0x10
		/// SubElement Size: 0xB90
		/// </summary>
		public TArray<UFCButton> m_ButtonListRight => new TArray<UFCButton>(BaseAddress+0x328);
		
	}


	/// <summary>
	/// UExternalInventoryView:URootWidget
	/// Size: 0x360
	/// Properties: 3
	/// </summary>
	public class UExternalInventoryView:URootWidget
	{
		public override int ObjectSize => 864;
		/// <summary>
		/// Name: CanItemBeDropedOn
		/// Type: BoolProperty
		/// Offset: 0x308
		/// Size: 0x01
		/// </summary>
		public bool CanItemBeDropedOn
		{
			get
			{
				return ReadBool(0x308);
			}
			set
			{
				WriteBool(0x308,value);
			}
		}
		
		/// <summary>
		/// Name: m_Inventory
		/// Type: ObjectProperty
		/// Offset: 0x350
		/// Size: 0x08
		/// </summary>
		public UItemInventory m_Inventory => ReadUObject<UItemInventory>(0x350);
		
		/// <summary>
		/// Name: m_TargetInventory
		/// Type: ObjectProperty
		/// Offset: 0x358
		/// Size: 0x08
		/// </summary>
		public UItemInventory m_TargetInventory => ReadUObject<UItemInventory>(0x358);
		
	}


	/// <summary>
	/// UCharacterInventoryView:UExternalInventoryView
	/// Size: 0x360
	/// Properties: 0
	/// </summary>
	public class UCharacterInventoryView:UExternalInventoryView
	{
		public override int ObjectSize => 864;
	}


	/// <summary>
	/// UChestInventoryView:UExternalInventoryView
	/// Size: 0x360
	/// Properties: 0
	/// </summary>
	public class UChestInventoryView:UExternalInventoryView
	{
		public override int ObjectSize => 864;
	}


	/// <summary>
	/// UFCButton:URootWidget
	/// Size: 0xB90
	/// Properties: 14
	/// </summary>
	public class UFCButton:URootWidget
	{
		public override int ObjectSize => 2960;
		/// <summary>
		/// Name: label
		/// Type: TextProperty
		/// Offset: 0x308
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: KeyShortcutName
		/// Type: NameProperty
		/// Offset: 0x320
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: GamepadIconKey
		/// Type: StructProperty
		/// Offset: 0x328
		/// Size: 0x18
		/// </summary>
		public FKey GamepadIconKey => ReadStruct<FKey>(0x328);
		
		/// <summary>
		/// Name: ShowOnlyGamepadIcon
		/// Type: BoolProperty
		/// Offset: 0x340
		/// Size: 0x01
		/// </summary>
		public bool ShowOnlyGamepadIcon
		{
			get
			{
				return ReadBool(0x340);
			}
			set
			{
				WriteBool(0x340,value);
			}
		}
		
		/// <summary>
		/// Name: Style
		/// Type: StructProperty
		/// Offset: 0x348
		/// Size: 0x6C0
		/// </summary>
		public FFCButtonStyle Style => ReadStruct<FFCButtonStyle>(0x348);
		
		/// <summary>
		/// Name: IsCheckable
		/// Type: BoolProperty
		/// Offset: 0xA08
		/// Size: 0x01
		/// </summary>
		public bool IsCheckable
		{
			get
			{
				return ReadBool(0xA08);
			}
			set
			{
				WriteBool(0xA08,value);
			}
		}
		
		/// <summary>
		/// Name: ToggleWhenClicked
		/// Type: BoolProperty
		/// Offset: 0xA09
		/// Size: 0x01
		/// </summary>
		public bool ToggleWhenClicked
		{
			get
			{
				return ReadBool(0xA09);
			}
			set
			{
				WriteBool(0xA09,value);
			}
		}
		
		/// <summary>
		/// Name: ToggleAction
		/// Type: ByteProperty
		/// Offset: 0xA0A
		/// Size: 0x01
		/// </summary>
		public byte ToggleAction
		{
			get
			{
				return ReadByte(0xA0A);
			}
			set
			{
				WriteByte(0xA0A,value);
			}
		}
		
		/// <summary>
		/// Name: IsChecked
		/// Type: BoolProperty
		/// Offset: 0xA0B
		/// Size: 0x01
		/// </summary>
		public bool IsChecked
		{
			get
			{
				return ReadBool(0xA0B);
			}
			set
			{
				WriteBool(0xA0B,value);
			}
		}
		
		/// <summary>
		/// Name: HoveredFontColor
		/// Type: StructProperty
		/// Offset: 0xA10
		/// Size: 0x28
		/// </summary>
		public FSlateColor HoveredFontColor => ReadStruct<FSlateColor>(0xA10);
		
		/// <summary>
		/// Name: PressedFontColor
		/// Type: StructProperty
		/// Offset: 0xA38
		/// Size: 0x28
		/// </summary>
		public FSlateColor PressedFontColor => ReadStruct<FSlateColor>(0xA38);
		
		/// <summary>
		/// Name: PressedHoveredFontColor
		/// Type: StructProperty
		/// Offset: 0xA60
		/// Size: 0x28
		/// </summary>
		public FSlateColor PressedHoveredFontColor => ReadStruct<FSlateColor>(0xA60);
		
		/// <summary>
		/// Name: FontColor
		/// Type: StructProperty
		/// Offset: 0xA88
		/// Size: 0x28
		/// </summary>
		public FSlateColor FontColor => ReadStruct<FSlateColor>(0xA88);
		
		/// <summary>
		/// Name: m_SubButtons
		/// Type: TArray<UFCButton>
		/// Offset: 0xB70
		/// Size: 0x10
		/// SubElement Size: 0xB90
		/// </summary>
		public TArray<UFCButton> m_SubButtons => new TArray<UFCButton>(BaseAddress+0xB70);
		
	}


	/// <summary>
	/// UTabButtonBase:UFCButton
	/// Size: 0xB98
	/// Properties: 1
	/// </summary>
	public class UTabButtonBase:UFCButton
	{
		public override int ObjectSize => 2968;
		/// <summary>
		/// Name: SwitcherIndex
		/// Type: IntProperty
		/// Offset: 0xB90
		/// Size: 0x04
		/// </summary>
		public int SwitcherIndex
		{
			get
			{
				return ReadInt32(0xB90);
			}
			set
			{
				WriteInt32(0xB90,value);
			}
		}
		
	}


	/// <summary>
	/// UFCComboBoxString:URootWidget
	/// Size: 0x370
	/// Properties: 1
	/// </summary>
	public class UFCComboBoxString:URootWidget
	{
		public override int ObjectSize => 880;
		/// <summary>
		/// Name: m_ComboBox
		/// Type: ObjectProperty
		/// Offset: 0x318
		/// Size: 0x08
		/// </summary>
		public UComboBoxString m_ComboBox => ReadUObject<UComboBoxString>(0x318);
		
	}


	/// <summary>
	/// UFCEditableMultiLineText:URootWidget
	/// Size: 0xD58
	/// Properties: 22
	/// </summary>
	public class UFCEditableMultiLineText:URootWidget
	{
		public override int ObjectSize => 3416;
		/// <summary>
		/// Name: Text
		/// Type: TextProperty
		/// Offset: 0x308
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: WidgetStyle
		/// Type: StructProperty
		/// Offset: 0x320
		/// Size: 0x848
		/// </summary>
		public FEditableTextBoxStyle WidgetStyle => ReadStruct<FEditableTextBoxStyle>(0x320);
		
		/// <summary>
		/// Name: TextStyle
		/// Type: StructProperty
		/// Offset: 0xB68
		/// Size: 0x150
		/// </summary>
		public FTextBlockStyle TextStyle => ReadStruct<FTextBlockStyle>(0xB68);
		
		/// <summary>
		/// Name: HintText
		/// Type: TextProperty
		/// Offset: 0xCB8
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: HintTextDelegate
		/// Type: DelegateProperty
		/// Offset: 0xCD0
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: IsReadOnly
		/// Type: BoolProperty
		/// Offset: 0xCE0
		/// Size: 0x01
		/// </summary>
		public bool IsReadOnly
		{
			get
			{
				return ReadBool(0xCE0);
			}
			set
			{
				WriteBool(0xCE0,value);
			}
		}
		
		/// <summary>
		/// Name: IsPassword
		/// Type: BoolProperty
		/// Offset: 0xCE1
		/// Size: 0x01
		/// </summary>
		public bool IsPassword
		{
			get
			{
				return ReadBool(0xCE1);
			}
			set
			{
				WriteBool(0xCE1,value);
			}
		}
		
		/// <summary>
		/// Name: MinimumDesiredWidth
		/// Type: FloatProperty
		/// Offset: 0xCE4
		/// Size: 0x04
		/// </summary>
		public float MinimumDesiredWidth
		{
			get
			{
				return ReadSingle(0xCE4);
			}
			set
			{
				WriteSingle(0xCE4,value);
			}
		}
		
		/// <summary>
		/// Name: TextMaxLength
		/// Type: IntProperty
		/// Offset: 0xCE8
		/// Size: 0x04
		/// </summary>
		public int TextMaxLength
		{
			get
			{
				return ReadInt32(0xCE8);
			}
			set
			{
				WriteInt32(0xCE8,value);
			}
		}
		
		/// <summary>
		/// Name: IsCaretMovedWhenGainFocus
		/// Type: BoolProperty
		/// Offset: 0xCEC
		/// Size: 0x01
		/// </summary>
		public bool IsCaretMovedWhenGainFocus
		{
			get
			{
				return ReadBool(0xCEC);
			}
			set
			{
				WriteBool(0xCEC,value);
			}
		}
		
		/// <summary>
		/// Name: SelectAllTextWhenFocused
		/// Type: BoolProperty
		/// Offset: 0xCED
		/// Size: 0x01
		/// </summary>
		public bool SelectAllTextWhenFocused
		{
			get
			{
				return ReadBool(0xCED);
			}
			set
			{
				WriteBool(0xCED,value);
			}
		}
		
		/// <summary>
		/// Name: RevertTextOnEscape
		/// Type: BoolProperty
		/// Offset: 0xCEE
		/// Size: 0x01
		/// </summary>
		public bool RevertTextOnEscape
		{
			get
			{
				return ReadBool(0xCEE);
			}
			set
			{
				WriteBool(0xCEE,value);
			}
		}
		
		/// <summary>
		/// Name: ClearKeyboardFocusOnCommit
		/// Type: BoolProperty
		/// Offset: 0xCEF
		/// Size: 0x01
		/// </summary>
		public bool ClearKeyboardFocusOnCommit
		{
			get
			{
				return ReadBool(0xCEF);
			}
			set
			{
				WriteBool(0xCEF,value);
			}
		}
		
		/// <summary>
		/// Name: SelectAllTextOnCommit
		/// Type: BoolProperty
		/// Offset: 0xCF0
		/// Size: 0x01
		/// </summary>
		public bool SelectAllTextOnCommit
		{
			get
			{
				return ReadBool(0xCF0);
			}
			set
			{
				WriteBool(0xCF0,value);
			}
		}
		
		/// <summary>
		/// Name: AllowContextMenu
		/// Type: BoolProperty
		/// Offset: 0xCF1
		/// Size: 0x01
		/// </summary>
		public bool AllowContextMenu
		{
			get
			{
				return ReadBool(0xCF1);
			}
			set
			{
				WriteBool(0xCF1,value);
			}
		}
		
		/// <summary>
		/// Name: ShapedTextOptions
		/// Type: StructProperty
		/// Offset: 0xCF4
		/// Size: 0x08
		/// </summary>
		public FShapedTextOptions ShapedTextOptions => ReadStruct<FShapedTextOptions>(0xCF4);
		
		/// <summary>
		/// Name: Justification
		/// Type: ByteProperty
		/// Offset: 0xCFC
		/// Size: 0x01
		/// </summary>
		public byte Justification
		{
			get
			{
				return ReadByte(0xCFC);
			}
			set
			{
				WriteByte(0xCFC,value);
			}
		}
		
		/// <summary>
		/// Name: AutoWrapText
		/// Type: BoolProperty
		/// Offset: 0xCFD
		/// Size: 0x01
		/// </summary>
		public bool AutoWrapText
		{
			get
			{
				return ReadBool(0xCFD);
			}
			set
			{
				WriteBool(0xCFD,value);
			}
		}
		
		/// <summary>
		/// Name: WrapTextAt
		/// Type: FloatProperty
		/// Offset: 0xD00
		/// Size: 0x04
		/// </summary>
		public float WrapTextAt
		{
			get
			{
				return ReadSingle(0xD00);
			}
			set
			{
				WriteSingle(0xD00,value);
			}
		}
		
		/// <summary>
		/// Name: WrappingPolicy
		/// Type: ByteProperty
		/// Offset: 0xD04
		/// Size: 0x01
		/// </summary>
		public byte WrappingPolicy
		{
			get
			{
				return ReadByte(0xD04);
			}
			set
			{
				WriteByte(0xD04,value);
			}
		}
		
		/// <summary>
		/// Name: Margin
		/// Type: StructProperty
		/// Offset: 0xD08
		/// Size: 0x10
		/// </summary>
		public FMargin Margin => ReadStruct<FMargin>(0xD08);
		
		/// <summary>
		/// Name: LineHeightPercentage
		/// Type: FloatProperty
		/// Offset: 0xD18
		/// Size: 0x04
		/// </summary>
		public float LineHeightPercentage
		{
			get
			{
				return ReadSingle(0xD18);
			}
			set
			{
				WriteSingle(0xD18,value);
			}
		}
		
	}


	/// <summary>
	/// UFCEditableTextBox:URootWidget
	/// Size: 0xBF8
	/// Properties: 16
	/// </summary>
	public class UFCEditableTextBox:URootWidget
	{
		public override int ObjectSize => 3064;
		/// <summary>
		/// Name: Text
		/// Type: TextProperty
		/// Offset: 0x308
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: TextDelegate
		/// Type: DelegateProperty
		/// Offset: 0x320
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: WidgetStyle
		/// Type: StructProperty
		/// Offset: 0x330
		/// Size: 0x848
		/// </summary>
		public FEditableTextBoxStyle WidgetStyle => ReadStruct<FEditableTextBoxStyle>(0x330);
		
		/// <summary>
		/// Name: HintText
		/// Type: TextProperty
		/// Offset: 0xB78
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: HintTextDelegate
		/// Type: DelegateProperty
		/// Offset: 0xB90
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: IsReadOnly
		/// Type: BoolProperty
		/// Offset: 0xBA0
		/// Size: 0x01
		/// </summary>
		public bool IsReadOnly
		{
			get
			{
				return ReadBool(0xBA0);
			}
			set
			{
				WriteBool(0xBA0,value);
			}
		}
		
		/// <summary>
		/// Name: IsPassword
		/// Type: BoolProperty
		/// Offset: 0xBA1
		/// Size: 0x01
		/// </summary>
		public bool IsPassword
		{
			get
			{
				return ReadBool(0xBA1);
			}
			set
			{
				WriteBool(0xBA1,value);
			}
		}
		
		/// <summary>
		/// Name: MinimumDesiredWidth
		/// Type: FloatProperty
		/// Offset: 0xBA4
		/// Size: 0x04
		/// </summary>
		public float MinimumDesiredWidth
		{
			get
			{
				return ReadSingle(0xBA4);
			}
			set
			{
				WriteSingle(0xBA4,value);
			}
		}
		
		/// <summary>
		/// Name: TextMaxLength
		/// Type: IntProperty
		/// Offset: 0xBA8
		/// Size: 0x04
		/// </summary>
		public int TextMaxLength
		{
			get
			{
				return ReadInt32(0xBA8);
			}
			set
			{
				WriteInt32(0xBA8,value);
			}
		}
		
		/// <summary>
		/// Name: IsCaretMovedWhenGainFocus
		/// Type: BoolProperty
		/// Offset: 0xBAC
		/// Size: 0x01
		/// </summary>
		public bool IsCaretMovedWhenGainFocus
		{
			get
			{
				return ReadBool(0xBAC);
			}
			set
			{
				WriteBool(0xBAC,value);
			}
		}
		
		/// <summary>
		/// Name: SelectAllTextWhenFocused
		/// Type: BoolProperty
		/// Offset: 0xBAD
		/// Size: 0x01
		/// </summary>
		public bool SelectAllTextWhenFocused
		{
			get
			{
				return ReadBool(0xBAD);
			}
			set
			{
				WriteBool(0xBAD,value);
			}
		}
		
		/// <summary>
		/// Name: RevertTextOnEscape
		/// Type: BoolProperty
		/// Offset: 0xBAE
		/// Size: 0x01
		/// </summary>
		public bool RevertTextOnEscape
		{
			get
			{
				return ReadBool(0xBAE);
			}
			set
			{
				WriteBool(0xBAE,value);
			}
		}
		
		/// <summary>
		/// Name: ClearKeyboardFocusOnCommit
		/// Type: BoolProperty
		/// Offset: 0xBAF
		/// Size: 0x01
		/// </summary>
		public bool ClearKeyboardFocusOnCommit
		{
			get
			{
				return ReadBool(0xBAF);
			}
			set
			{
				WriteBool(0xBAF,value);
			}
		}
		
		/// <summary>
		/// Name: SelectAllTextOnCommit
		/// Type: BoolProperty
		/// Offset: 0xBB0
		/// Size: 0x01
		/// </summary>
		public bool SelectAllTextOnCommit
		{
			get
			{
				return ReadBool(0xBB0);
			}
			set
			{
				WriteBool(0xBB0,value);
			}
		}
		
		/// <summary>
		/// Name: AllowContextMenu
		/// Type: BoolProperty
		/// Offset: 0xBB1
		/// Size: 0x01
		/// </summary>
		public bool AllowContextMenu
		{
			get
			{
				return ReadBool(0xBB1);
			}
			set
			{
				WriteBool(0xBB1,value);
			}
		}
		
		/// <summary>
		/// Name: ShapedTextOptions
		/// Type: StructProperty
		/// Offset: 0xBB4
		/// Size: 0x08
		/// </summary>
		public FShapedTextOptions ShapedTextOptions => ReadStruct<FShapedTextOptions>(0xBB4);
		
	}


	/// <summary>
	/// UFCProgressbar:URootWidget
	/// Size: 0x338
	/// Properties: 3
	/// </summary>
	public class UFCProgressbar:URootWidget
	{
		public override int ObjectSize => 824;
		/// <summary>
		/// Name: progress
		/// Type: FloatProperty
		/// Offset: 0x308
		/// Size: 0x04
		/// </summary>
		public float progress
		{
			get
			{
				return ReadSingle(0x308);
			}
			set
			{
				WriteSingle(0x308,value);
			}
		}
		
		/// <summary>
		/// Name: Segments
		/// Type: TArray<FFCProgressbarSegment>
		/// Offset: 0x310
		/// Size: 0x10
		/// SubElement Size: 0x1C0
		/// </summary>
		public TArray<FFCProgressbarSegment> Segments => new TArray<FFCProgressbarSegment>(BaseAddress+0x310);
		
		/// <summary>
		/// Name: m_ProgressBars
		/// Type: TArray<UProgressBar>
		/// Offset: 0x328
		/// Size: 0x10
		/// SubElement Size: 0x338
		/// </summary>
		public TArray<UProgressBar> m_ProgressBars => new TArray<UProgressBar>(BaseAddress+0x328);
		
	}


	/// <summary>
	/// UFCSlider:URootWidget
	/// Size: 0x5A8
	/// Properties: 8
	/// </summary>
	public class UFCSlider:URootWidget
	{
		public override int ObjectSize => 1448;
		/// <summary>
		/// Name: Value
		/// Type: FloatProperty
		/// Offset: 0x308
		/// Size: 0x04
		/// </summary>
		public float Value
		{
			get
			{
				return ReadSingle(0x308);
			}
			set
			{
				WriteSingle(0x308,value);
			}
		}
		
		/// <summary>
		/// Name: WidgetStyle
		/// Type: StructProperty
		/// Offset: 0x310
		/// Size: 0x250
		/// </summary>
		public FSliderStyle WidgetStyle => ReadStruct<FSliderStyle>(0x310);
		
		/// <summary>
		/// Name: Orientation
		/// Type: ByteProperty
		/// Offset: 0x560
		/// Size: 0x01
		/// </summary>
		public byte Orientation
		{
			get
			{
				return ReadByte(0x560);
			}
			set
			{
				WriteByte(0x560,value);
			}
		}
		
		/// <summary>
		/// Name: SliderBarColor
		/// Type: StructProperty
		/// Offset: 0x564
		/// Size: 0x10
		/// </summary>
		public FLinearColor SliderBarColor => ReadStruct<FLinearColor>(0x564);
		
		/// <summary>
		/// Name: SliderHandleColor
		/// Type: StructProperty
		/// Offset: 0x574
		/// Size: 0x10
		/// </summary>
		public FLinearColor SliderHandleColor => ReadStruct<FLinearColor>(0x574);
		
		/// <summary>
		/// Name: IndentHandle
		/// Type: BoolProperty
		/// Offset: 0x584
		/// Size: 0x01
		/// </summary>
		public bool IndentHandle
		{
			get
			{
				return ReadBool(0x584);
			}
			set
			{
				WriteBool(0x584,value);
			}
		}
		
		/// <summary>
		/// Name: Locked
		/// Type: BoolProperty
		/// Offset: 0x585
		/// Size: 0x01
		/// </summary>
		public bool Locked
		{
			get
			{
				return ReadBool(0x585);
			}
			set
			{
				WriteBool(0x585,value);
			}
		}
		
		/// <summary>
		/// Name: StepSize
		/// Type: FloatProperty
		/// Offset: 0x588
		/// Size: 0x04
		/// </summary>
		public float StepSize
		{
			get
			{
				return ReadSingle(0x588);
			}
			set
			{
				WriteSingle(0x588,value);
			}
		}
		
	}


	/// <summary>
	/// UFeatResultRecipeInfoView:URootWidget
	/// Size: 0x340
	/// Properties: 1
	/// </summary>
	public class UFeatResultRecipeInfoView:URootWidget
	{
		public override int ObjectSize => 832;
		/// <summary>
		/// Name: m_Item
		/// Type: ObjectProperty
		/// Offset: 0x308
		/// Size: 0x08
		/// </summary>
		public URecipeItem m_Item => ReadUObject<URecipeItem>(0x308);
		
	}


	/// <summary>
	/// UFIFOMessageView:URootWidget
	/// Size: 0x308
	/// Properties: 0
	/// </summary>
	public class UFIFOMessageView:URootWidget
	{
		public override int ObjectSize => 776;
	}


	/// <summary>
	/// UFloatingNameBase:URootWidget
	/// Size: 0x310
	/// Properties: 0
	/// </summary>
	public class UFloatingNameBase:URootWidget
	{
		public override int ObjectSize => 784;
	}


	/// <summary>
	/// UGuildLogBase:URootWidget
	/// Size: 0x3A0
	/// Properties: 1
	/// </summary>
	public class UGuildLogBase:URootWidget
	{
		public override int ObjectSize => 928;
		/// <summary>
		/// Name: ListEntryClass
		/// Type: ClassProperty
		/// Offset: 0x350
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// UGuildMembersBase:URootWidget
	/// Size: 0x348
	/// Properties: 2
	/// </summary>
	public class UGuildMembersBase:URootWidget
	{
		public override int ObjectSize => 840;
		/// <summary>
		/// Name: ListEntryClass
		/// Type: ClassProperty
		/// Offset: 0x308
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: OptionsMenuClass
		/// Type: ClassProperty
		/// Offset: 0x310
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// UHotkeyIcon:URootWidget
	/// Size: 0x3F8
	/// Properties: 8
	/// </summary>
	public class UHotkeyIcon:URootWidget
	{
		public override int ObjectSize => 1016;
		/// <summary>
		/// Name: GamepadKey
		/// Type: StructProperty
		/// Offset: 0x308
		/// Size: 0x18
		/// </summary>
		public FKey GamepadKey => ReadStruct<FKey>(0x308);
		
		/// <summary>
		/// Name: BindingLabel
		/// Type: TextProperty
		/// Offset: 0x320
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: BindingLabelFormat
		/// Type: TextProperty
		/// Offset: 0x338
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: InputActionName
		/// Type: NameProperty
		/// Offset: 0x350
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: ShowOnlyGamepadIcon
		/// Type: BoolProperty
		/// Offset: 0x358
		/// Size: 0x01
		/// </summary>
		public bool ShowOnlyGamepadIcon
		{
			get
			{
				return ReadBool(0x358);
			}
			set
			{
				WriteBool(0x358,value);
			}
		}
		
		/// <summary>
		/// Name: IconSize
		/// Type: FloatProperty
		/// Offset: 0x35C
		/// Size: 0x04
		/// </summary>
		public float IconSize
		{
			get
			{
				return ReadSingle(0x35C);
			}
			set
			{
				WriteSingle(0x35C,value);
			}
		}
		
		/// <summary>
		/// Name: Font
		/// Type: StructProperty
		/// Offset: 0x360
		/// Size: 0x40
		/// </summary>
		public FSlateFontInfo Font => ReadStruct<FSlateFontInfo>(0x360);
		
		/// <summary>
		/// Name: Platforms
		/// Type: TArray<FHotkeyIconPlatform>
		/// Offset: 0x3A0
		/// Size: 0x10
		/// SubElement Size: 0x18
		/// </summary>
		public TArray<FHotkeyIconPlatform> Platforms => new TArray<FHotkeyIconPlatform>(BaseAddress+0x3A0);
		
	}


	/// <summary>
	/// UInventoryGridSlotViewBase:URootWidget
	/// Size: 0x490
	/// Properties: 9
	/// </summary>
	public class UInventoryGridSlotViewBase:URootWidget
	{
		public override int ObjectSize => 1168;
		/// <summary>
		/// Name: IconSize
		/// Type: FloatProperty
		/// Offset: 0x308
		/// Size: 0x04
		/// </summary>
		public float IconSize
		{
			get
			{
				return ReadSingle(0x308);
			}
			set
			{
				WriteSingle(0x308,value);
			}
		}
		
		/// <summary>
		/// Name: IconPadding
		/// Type: StructProperty
		/// Offset: 0x30C
		/// Size: 0x10
		/// </summary>
		public FMargin IconPadding => ReadStruct<FMargin>(0x30C);
		
		/// <summary>
		/// Name: AnimationSelect
		/// Type: ObjectProperty
		/// Offset: 0x320
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation AnimationSelect => ReadUObject<UWidgetAnimation>(0x320);
		
		/// <summary>
		/// Name: AnimationMouseOver
		/// Type: ObjectProperty
		/// Offset: 0x328
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation AnimationMouseOver => ReadUObject<UWidgetAnimation>(0x328);
		
		/// <summary>
		/// Name: IconView
		/// Type: ObjectProperty
		/// Offset: 0x330
		/// Size: 0x08
		/// </summary>
		public UInventoryIconViewBase IconView => ReadUObject<UInventoryIconViewBase>(0x330);
		
		/// <summary>
		/// Name: DropSound
		/// Type: ObjectProperty
		/// Offset: 0x338
		/// Size: 0x08
		/// </summary>
		public USoundCue DropSound => ReadUObject<USoundCue>(0x338);
		
		/// <summary>
		/// Name: HoveredSlateSound
		/// Type: StructProperty
		/// Offset: 0x340
		/// Size: 0x18
		/// </summary>
		public FSlateSound HoveredSlateSound => ReadStruct<FSlateSound>(0x340);
		
		/// <summary>
		/// Name: m_IconSlot
		/// Type: ObjectProperty
		/// Offset: 0x358
		/// Size: 0x08
		/// </summary>
		public UNamedSlot m_IconSlot => ReadUObject<UNamedSlot>(0x358);
		
		/// <summary>
		/// Name: m_SizeBox
		/// Type: ObjectProperty
		/// Offset: 0x480
		/// Size: 0x08
		/// </summary>
		public USizeBox m_SizeBox => ReadUObject<USizeBox>(0x480);
		
	}


	/// <summary>
	/// UInventoryGridViewBase:URootWidget
	/// Size: 0x550
	/// Properties: 20
	/// </summary>
	public class UInventoryGridViewBase:URootWidget
	{
		public override int ObjectSize => 1360;
		/// <summary>
		/// Name: GridSlotViewClass
		/// Type: ClassProperty
		/// Offset: 0x308
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: ItemViewClass
		/// Type: ClassProperty
		/// Offset: 0x310
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: ItemTooltipViewClass
		/// Type: ClassProperty
		/// Offset: 0x318
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: StackSplitDialogClass
		/// Type: ClassProperty
		/// Offset: 0x320
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: inventory
		/// Type: ObjectProperty
		/// Offset: 0x328
		/// Size: 0x08
		/// </summary>
		public UItemInventory inventory => ReadUObject<UItemInventory>(0x328);
		
		/// <summary>
		/// Name: ColumnCount
		/// Type: IntProperty
		/// Offset: 0x330
		/// Size: 0x04
		/// </summary>
		public int ColumnCount
		{
			get
			{
				return ReadInt32(0x330);
			}
			set
			{
				WriteInt32(0x330,value);
			}
		}
		
		/// <summary>
		/// Name: RowCount
		/// Type: IntProperty
		/// Offset: 0x334
		/// Size: 0x04
		/// </summary>
		public int RowCount
		{
			get
			{
				return ReadInt32(0x334);
			}
			set
			{
				WriteInt32(0x334,value);
			}
		}
		
		/// <summary>
		/// Name: IconSlotSize
		/// Type: FloatProperty
		/// Offset: 0x338
		/// Size: 0x04
		/// </summary>
		public float IconSlotSize
		{
			get
			{
				return ReadSingle(0x338);
			}
			set
			{
				WriteSingle(0x338,value);
			}
		}
		
		/// <summary>
		/// Name: IconSlotPadding
		/// Type: StructProperty
		/// Offset: 0x33C
		/// Size: 0x10
		/// </summary>
		public FMargin IconSlotPadding => ReadStruct<FMargin>(0x33C);
		
		/// <summary>
		/// Name: Orientation
		/// Type: ByteProperty
		/// Offset: 0x34C
		/// Size: 0x01
		/// </summary>
		public byte Orientation
		{
			get
			{
				return ReadByte(0x34C);
			}
			set
			{
				WriteByte(0x34C,value);
			}
		}
		
		/// <summary>
		/// Name: EnableScrollBar
		/// Type: BoolProperty
		/// Offset: 0x34D
		/// Size: 0x01
		/// </summary>
		public bool EnableScrollBar
		{
			get
			{
				return ReadBool(0x34D);
			}
			set
			{
				WriteBool(0x34D,value);
			}
		}
		
		/// <summary>
		/// Name: ShowItemProgress
		/// Type: BoolProperty
		/// Offset: 0x34E
		/// Size: 0x01
		/// </summary>
		public bool ShowItemProgress
		{
			get
			{
				return ReadBool(0x34E);
			}
			set
			{
				WriteBool(0x34E,value);
			}
		}
		
		/// <summary>
		/// Name: AllowItemDrag
		/// Type: BoolProperty
		/// Offset: 0x34F
		/// Size: 0x01
		/// </summary>
		public bool AllowItemDrag
		{
			get
			{
				return ReadBool(0x34F);
			}
			set
			{
				WriteBool(0x34F,value);
			}
		}
		
		/// <summary>
		/// Name: AllowItemDrop
		/// Type: BoolProperty
		/// Offset: 0x350
		/// Size: 0x01
		/// </summary>
		public bool AllowItemDrop
		{
			get
			{
				return ReadBool(0x350);
			}
			set
			{
				WriteBool(0x350,value);
			}
		}
		
		/// <summary>
		/// Name: ItemsCombinedSound
		/// Type: StructProperty
		/// Offset: 0x358
		/// Size: 0x18
		/// </summary>
		public FSlateSound ItemsCombinedSound => ReadStruct<FSlateSound>(0x358);
		
		/// <summary>
		/// Name: DelegateGetItemTooltip
		/// Type: DelegateProperty
		/// Offset: 0x370
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: DelegateFilterItem
		/// Type: DelegateProperty
		/// Offset: 0x380
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: DelegateCompareItems
		/// Type: DelegateProperty
		/// Offset: 0x390
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: m_SplitStackDialog
		/// Type: ObjectProperty
		/// Offset: 0x520
		/// Size: 0x08
		/// </summary>
		public UStackSplitValueDialog m_SplitStackDialog => ReadUObject<UStackSplitValueDialog>(0x520);
		
		/// <summary>
		/// Name: m_InventoryMonitor
		/// Type: ObjectProperty
		/// Offset: 0x528
		/// Size: 0x08
		/// </summary>
		public UItemInventoryClientMonitor m_InventoryMonitor => ReadUObject<UItemInventoryClientMonitor>(0x528);
		
	}


	/// <summary>
	/// UInventoryIconViewBase:URootWidget
	/// Size: 0x370
	/// Properties: 3
	/// </summary>
	public class UInventoryIconViewBase:URootWidget
	{
		public override int ObjectSize => 880;
		/// <summary>
		/// Name: AllowItemDrag
		/// Type: BoolProperty
		/// Offset: 0x308
		/// Size: 0x01
		/// </summary>
		public bool AllowItemDrag
		{
			get
			{
				return ReadBool(0x308);
			}
			set
			{
				WriteBool(0x308,value);
			}
		}
		
		/// <summary>
		/// Name: DragSound
		/// Type: ObjectProperty
		/// Offset: 0x310
		/// Size: 0x08
		/// </summary>
		public USoundCue DragSound => ReadUObject<USoundCue>(0x310);
		
		/// <summary>
		/// Name: m_GameItem
		/// Type: ObjectProperty
		/// Offset: 0x318
		/// Size: 0x08
		/// </summary>
		public UGameItem m_GameItem => ReadUObject<UGameItem>(0x318);
		
	}


	/// <summary>
	/// UInventoryItemInfoPanel:URootWidget
	/// Size: 0x360
	/// Properties: 1
	/// </summary>
	public class UInventoryItemInfoPanel:URootWidget
	{
		public override int ObjectSize => 864;
		/// <summary>
		/// Name: m_GameItem
		/// Type: ObjectProperty
		/// Offset: 0x358
		/// Size: 0x08
		/// </summary>
		public UGameItem m_GameItem => ReadUObject<UGameItem>(0x358);
		
	}


	/// <summary>
	/// UItemStatView:URootWidget
	/// Size: 0x330
	/// Properties: 1
	/// </summary>
	public class UItemStatView:URootWidget
	{
		public override int ObjectSize => 816;
		/// <summary>
		/// Name: fontSize
		/// Type: IntProperty
		/// Offset: 0x308
		/// Size: 0x04
		/// </summary>
		public int fontSize
		{
			get
			{
				return ReadInt32(0x308);
			}
			set
			{
				WriteInt32(0x308,value);
			}
		}
		
	}


	/// <summary>
	/// UKeyBindingsCategoryBase:URootWidget
	/// Size: 0x410
	/// Properties: 1
	/// </summary>
	public class UKeyBindingsCategoryBase:URootWidget
	{
		public override int ObjectSize => 1040;
		/// <summary>
		/// Name: m_EntryClass
		/// Type: ClassProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// UKeyBindingsCommandBase:URootWidget
	/// Size: 0x3C0
	/// Properties: 0
	/// </summary>
	public class UKeyBindingsCommandBase:URootWidget
	{
		public override int ObjectSize => 960;
	}


	/// <summary>
	/// UKeyBindingsCommandEntryBase:URootWidget
	/// Size: 0x3B0
	/// Properties: 0
	/// </summary>
	public class UKeyBindingsCommandEntryBase:URootWidget
	{
		public override int ObjectSize => 944;
	}


	/// <summary>
	/// UKeyBindingsEntryBase:URootWidget
	/// Size: 0x420
	/// Properties: 0
	/// </summary>
	public class UKeyBindingsEntryBase:URootWidget
	{
		public override int ObjectSize => 1056;
	}


	/// <summary>
	/// UKeyBindingsKeyBase:URootWidget
	/// Size: 0x430
	/// Properties: 0
	/// </summary>
	public class UKeyBindingsKeyBase:URootWidget
	{
		public override int ObjectSize => 1072;
	}


	/// <summary>
	/// UKeyNavIndicator:URootWidget
	/// Size: 0x310
	/// Properties: 0
	/// </summary>
	public class UKeyNavIndicator:URootWidget
	{
		public override int ObjectSize => 784;
	}


	/// <summary>
	/// UListEntryBase:URootWidget
	/// Size: 0x4A8
	/// Properties: 5
	/// </summary>
	public class UListEntryBase:URootWidget
	{
		public override int ObjectSize => 1192;
		/// <summary>
		/// Name: m_HighlightedColor
		/// Type: StructProperty
		/// Offset: 0x328
		/// Size: 0x28
		/// </summary>
		public FSlateColor m_HighlightedColor => ReadStruct<FSlateColor>(0x328);
		
		/// <summary>
		/// Name: m_OnlineColor
		/// Type: StructProperty
		/// Offset: 0x350
		/// Size: 0x28
		/// </summary>
		public FSlateColor m_OnlineColor => ReadStruct<FSlateColor>(0x350);
		
		/// <summary>
		/// Name: m_OfflineColor
		/// Type: StructProperty
		/// Offset: 0x378
		/// Size: 0x28
		/// </summary>
		public FSlateColor m_OfflineColor => ReadStruct<FSlateColor>(0x378);
		
		/// <summary>
		/// Name: m_PlayerId
		/// Type: Int64Property
		/// Offset: 0x490
		/// Size: 0x08
		/// </summary>
		public long m_PlayerId
		{
			get
			{
				return ReadInt64(0x490);
			}
			set
			{
				WriteInt64(0x490,value);
			}
		}
		
		/// <summary>
		/// Name: m_GuildId
		/// Type: ObjectProperty
		/// Offset: 0x498
		/// Size: 0x08
		/// </summary>
		public UUniqueID m_GuildId => ReadUObject<UUniqueID>(0x498);
		
	}


	/// <summary>
	/// UListMenu:URootWidget
	/// Size: 0x4D0
	/// Properties: 10
	/// </summary>
	public class UListMenu:URootWidget
	{
		public override int ObjectSize => 1232;
		/// <summary>
		/// Name: ButtonClass
		/// Type: ClassProperty
		/// Offset: 0x308
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: NormalHovered
		/// Type: StructProperty
		/// Offset: 0x310
		/// Size: 0x28
		/// </summary>
		public FSlateColor NormalHovered => ReadStruct<FSlateColor>(0x310);
		
		/// <summary>
		/// Name: NormalColor
		/// Type: StructProperty
		/// Offset: 0x338
		/// Size: 0x28
		/// </summary>
		public FSlateColor NormalColor => ReadStruct<FSlateColor>(0x338);
		
		/// <summary>
		/// Name: NormalPressedHovered
		/// Type: StructProperty
		/// Offset: 0x360
		/// Size: 0x28
		/// </summary>
		public FSlateColor NormalPressedHovered => ReadStruct<FSlateColor>(0x360);
		
		/// <summary>
		/// Name: NormalPressed
		/// Type: StructProperty
		/// Offset: 0x388
		/// Size: 0x28
		/// </summary>
		public FSlateColor NormalPressed => ReadStruct<FSlateColor>(0x388);
		
		/// <summary>
		/// Name: GuildMasterHovered
		/// Type: StructProperty
		/// Offset: 0x3B0
		/// Size: 0x28
		/// </summary>
		public FSlateColor GuildMasterHovered => ReadStruct<FSlateColor>(0x3B0);
		
		/// <summary>
		/// Name: GuildMasterColor
		/// Type: StructProperty
		/// Offset: 0x3D8
		/// Size: 0x28
		/// </summary>
		public FSlateColor GuildMasterColor => ReadStruct<FSlateColor>(0x3D8);
		
		/// <summary>
		/// Name: GuildMasterPressedHovered
		/// Type: StructProperty
		/// Offset: 0x400
		/// Size: 0x28
		/// </summary>
		public FSlateColor GuildMasterPressedHovered => ReadStruct<FSlateColor>(0x400);
		
		/// <summary>
		/// Name: GuildMasterPressed
		/// Type: StructProperty
		/// Offset: 0x428
		/// Size: 0x28
		/// </summary>
		public FSlateColor GuildMasterPressed => ReadStruct<FSlateColor>(0x428);
		
		/// <summary>
		/// Name: m_selectedPlayerId
		/// Type: Int64Property
		/// Offset: 0x4C0
		/// Size: 0x08
		/// </summary>
		public long m_selectedPlayerId
		{
			get
			{
				return ReadInt64(0x4C0);
			}
			set
			{
				WriteInt64(0x4C0,value);
			}
		}
		
	}


	/// <summary>
	/// UMapWithMarkerWidget:URootWidget
	/// Size: 0x348
	/// Properties: 0
	/// </summary>
	public class UMapWithMarkerWidget:URootWidget
	{
		public override int ObjectSize => 840;
	}


	/// <summary>
	/// UPaperdollIconSlot:URootWidget
	/// Size: 0x360
	/// Properties: 0
	/// </summary>
	public class UPaperdollIconSlot:URootWidget
	{
		public override int ObjectSize => 864;
	}


	/// <summary>
	/// UPaperdollPanel:URootWidget
	/// Size: 0x3D8
	/// Properties: 1
	/// </summary>
	public class UPaperdollPanel:URootWidget
	{
		public override int ObjectSize => 984;
		/// <summary>
		/// Name: m_EquipmentInventory
		/// Type: ObjectProperty
		/// Offset: 0x308
		/// Size: 0x08
		/// </summary>
		public UEquipmentInventory m_EquipmentInventory => ReadUObject<UEquipmentInventory>(0x308);
		
	}


	/// <summary>
	/// UPlayerInventoryView:URootWidget
	/// Size: 0x360
	/// Properties: 6
	/// </summary>
	public class UPlayerInventoryView:URootWidget
	{
		public override int ObjectSize => 864;
		/// <summary>
		/// Name: m_BackpackInventory
		/// Type: ObjectProperty
		/// Offset: 0x308
		/// Size: 0x08
		/// </summary>
		public UItemInventory m_BackpackInventory => ReadUObject<UItemInventory>(0x308);
		
		/// <summary>
		/// Name: m_EquipmentInventory
		/// Type: ObjectProperty
		/// Offset: 0x310
		/// Size: 0x08
		/// </summary>
		public UItemInventory m_EquipmentInventory => ReadUObject<UItemInventory>(0x310);
		
		/// <summary>
		/// Name: m_ShortcutbarInventory
		/// Type: ObjectProperty
		/// Offset: 0x318
		/// Size: 0x08
		/// </summary>
		public UItemInventory m_ShortcutbarInventory => ReadUObject<UItemInventory>(0x318);
		
		/// <summary>
		/// Name: m_BackpackInventoryView
		/// Type: ObjectProperty
		/// Offset: 0x320
		/// Size: 0x08
		/// </summary>
		public UChestInventoryView m_BackpackInventoryView => ReadUObject<UChestInventoryView>(0x320);
		
		/// <summary>
		/// Name: m_EquipmentInventoryView
		/// Type: ObjectProperty
		/// Offset: 0x328
		/// Size: 0x08
		/// </summary>
		public UChestInventoryView m_EquipmentInventoryView => ReadUObject<UChestInventoryView>(0x328);
		
		/// <summary>
		/// Name: m_ShortcutbarInventoryView
		/// Type: ObjectProperty
		/// Offset: 0x330
		/// Size: 0x08
		/// </summary>
		public UChestInventoryView m_ShortcutbarInventoryView => ReadUObject<UChestInventoryView>(0x330);
		
	}


	/// <summary>
	/// URadialMenuSegment:URootWidget
	/// Size: 0x348
	/// Properties: 3
	/// </summary>
	public class URadialMenuSegment:URootWidget
	{
		public override int ObjectSize => 840;
		/// <summary>
		/// Name: m_IconTexture
		/// Type: ObjectProperty
		/// Offset: 0x328
		/// Size: 0x08
		/// </summary>
		public UTexture2D m_IconTexture => ReadUObject<UTexture2D>(0x328);
		
		/// <summary>
		/// Name: m_StartCapTexture
		/// Type: ObjectProperty
		/// Offset: 0x330
		/// Size: 0x08
		/// </summary>
		public UTexture2D m_StartCapTexture => ReadUObject<UTexture2D>(0x330);
		
		/// <summary>
		/// Name: m_EndCapTexture
		/// Type: ObjectProperty
		/// Offset: 0x338
		/// Size: 0x08
		/// </summary>
		public UTexture2D m_EndCapTexture => ReadUObject<UTexture2D>(0x338);
		
	}


	/// <summary>
	/// UServerListView:URootWidget
	/// Size: 0x490
	/// Properties: 6
	/// </summary>
	public class UServerListView:URootWidget
	{
		public override int ObjectSize => 1168;
		/// <summary>
		/// Name: m_CurrentSteamFilter
		/// Type: ByteProperty
		/// Offset: 0x338
		/// Size: 0x01
		/// </summary>
		public byte m_CurrentSteamFilter
		{
			get
			{
				return ReadByte(0x338);
			}
			set
			{
				WriteByte(0x338,value);
			}
		}
		
		/// <summary>
		/// Name: m_CurrentOfficalFilter
		/// Type: ByteProperty
		/// Offset: 0x339
		/// Size: 0x01
		/// </summary>
		public byte m_CurrentOfficalFilter
		{
			get
			{
				return ReadByte(0x339);
			}
			set
			{
				WriteByte(0x339,value);
			}
		}
		
		/// <summary>
		/// Name: m_ServerInfoClass
		/// Type: ClassProperty
		/// Offset: 0x368
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: m_ListUpdateProgressView
		/// Type: ObjectProperty
		/// Offset: 0x370
		/// Size: 0x08
		/// </summary>
		public UTextBlock m_ListUpdateProgressView => ReadUObject<UTextBlock>(0x370);
		
		/// <summary>
		/// Name: m_UnusedListEntryWidgets
		/// Type: TArray<UServerInfoBase>
		/// Offset: 0x380
		/// Size: 0x10
		/// SubElement Size: 0x548
		/// </summary>
		public TArray<UServerInfoBase> m_UnusedListEntryWidgets => new TArray<UServerInfoBase>(BaseAddress+0x380);
		
		/// <summary>
		/// Name: m_ListViewEntries
		/// Type: TArray<FServerListViewEntry>
		/// Offset: 0x390
		/// Size: 0x10
		/// SubElement Size: 0xD8
		/// </summary>
		public TArray<FServerListViewEntry> m_ListViewEntries => new TArray<FServerListViewEntry>(BaseAddress+0x390);
		
	}


	/// <summary>
	/// UShortcutIconBase:URootWidget
	/// Size: 0x470
	/// Properties: 0
	/// </summary>
	public class UShortcutIconBase:URootWidget
	{
		public override int ObjectSize => 1136;
	}


	/// <summary>
	/// USubSettingsMaster:URootWidget
	/// Size: 0x310
	/// Properties: 1
	/// </summary>
	public class USubSettingsMaster:URootWidget
	{
		public override int ObjectSize => 784;
		/// <summary>
		/// Name: IsDirty
		/// Type: BoolProperty
		/// Offset: 0x308
		/// Size: 0x01
		/// </summary>
		public bool IsDirty
		{
			get
			{
				return ReadBool(0x308);
			}
			set
			{
				WriteBool(0x308,value);
			}
		}
		
	}


	/// <summary>
	/// USettingsAudioBase:USubSettingsMaster
	/// Size: 0x3B8
	/// Properties: 8
	/// </summary>
	public class USettingsAudioBase:USubSettingsMaster
	{
		public override int ObjectSize => 952;
		/// <summary>
		/// Name: MasterClass
		/// Type: ObjectProperty
		/// Offset: 0x310
		/// Size: 0x08
		/// </summary>
		public USoundClass MasterClass => ReadUObject<USoundClass>(0x310);
		
		/// <summary>
		/// Name: MusicClass
		/// Type: ObjectProperty
		/// Offset: 0x318
		/// Size: 0x08
		/// </summary>
		public USoundClass MusicClass => ReadUObject<USoundClass>(0x318);
		
		/// <summary>
		/// Name: VoiceClass
		/// Type: ObjectProperty
		/// Offset: 0x320
		/// Size: 0x08
		/// </summary>
		public USoundClass VoiceClass => ReadUObject<USoundClass>(0x320);
		
		/// <summary>
		/// Name: VoiceChatClass
		/// Type: ObjectProperty
		/// Offset: 0x328
		/// Size: 0x08
		/// </summary>
		public USoundClass VoiceChatClass => ReadUObject<USoundClass>(0x328);
		
		/// <summary>
		/// Name: SFXClass
		/// Type: ObjectProperty
		/// Offset: 0x330
		/// Size: 0x08
		/// </summary>
		public USoundClass SFXClass => ReadUObject<USoundClass>(0x330);
		
		/// <summary>
		/// Name: maxVolume
		/// Type: FloatProperty
		/// Offset: 0x338
		/// Size: 0x04
		/// </summary>
		public float maxVolume
		{
			get
			{
				return ReadSingle(0x338);
			}
			set
			{
				WriteSingle(0x338,value);
			}
		}
		
		/// <summary>
		/// Name: MinSliderValue
		/// Type: IntProperty
		/// Offset: 0x33C
		/// Size: 0x04
		/// </summary>
		public int MinSliderValue
		{
			get
			{
				return ReadInt32(0x33C);
			}
			set
			{
				WriteInt32(0x33C,value);
			}
		}
		
		/// <summary>
		/// Name: MaxSliderValue
		/// Type: IntProperty
		/// Offset: 0x340
		/// Size: 0x04
		/// </summary>
		public int MaxSliderValue
		{
			get
			{
				return ReadInt32(0x340);
			}
			set
			{
				WriteInt32(0x340,value);
			}
		}
		
	}


	/// <summary>
	/// USettingsControlBase:USubSettingsMaster
	/// Size: 0x3B0
	/// Properties: 8
	/// </summary>
	public class USettingsControlBase:USubSettingsMaster
	{
		public override int ObjectSize => 944;
		/// <summary>
		/// Name: maxMouseSensitivity
		/// Type: FloatProperty
		/// Offset: 0x310
		/// Size: 0x04
		/// </summary>
		public float maxMouseSensitivity
		{
			get
			{
				return ReadSingle(0x310);
			}
			set
			{
				WriteSingle(0x310,value);
			}
		}
		
		/// <summary>
		/// Name: minMouseSensitivity
		/// Type: FloatProperty
		/// Offset: 0x314
		/// Size: 0x04
		/// </summary>
		public float minMouseSensitivity
		{
			get
			{
				return ReadSingle(0x314);
			}
			set
			{
				WriteSingle(0x314,value);
			}
		}
		
		/// <summary>
		/// Name: maxAxisSensitivity
		/// Type: FloatProperty
		/// Offset: 0x318
		/// Size: 0x04
		/// </summary>
		public float maxAxisSensitivity
		{
			get
			{
				return ReadSingle(0x318);
			}
			set
			{
				WriteSingle(0x318,value);
			}
		}
		
		/// <summary>
		/// Name: minAxisSensitivity
		/// Type: FloatProperty
		/// Offset: 0x31C
		/// Size: 0x04
		/// </summary>
		public float minAxisSensitivity
		{
			get
			{
				return ReadSingle(0x31C);
			}
			set
			{
				WriteSingle(0x31C,value);
			}
		}
		
		/// <summary>
		/// Name: maxAxisDeadzone
		/// Type: FloatProperty
		/// Offset: 0x320
		/// Size: 0x04
		/// </summary>
		public float maxAxisDeadzone
		{
			get
			{
				return ReadSingle(0x320);
			}
			set
			{
				WriteSingle(0x320,value);
			}
		}
		
		/// <summary>
		/// Name: minAxisDeadzone
		/// Type: FloatProperty
		/// Offset: 0x324
		/// Size: 0x04
		/// </summary>
		public float minAxisDeadzone
		{
			get
			{
				return ReadSingle(0x324);
			}
			set
			{
				WriteSingle(0x324,value);
			}
		}
		
		/// <summary>
		/// Name: maxTriggerDeadzone
		/// Type: FloatProperty
		/// Offset: 0x328
		/// Size: 0x04
		/// </summary>
		public float maxTriggerDeadzone
		{
			get
			{
				return ReadSingle(0x328);
			}
			set
			{
				WriteSingle(0x328,value);
			}
		}
		
		/// <summary>
		/// Name: minTriggerDeadzone
		/// Type: FloatProperty
		/// Offset: 0x32C
		/// Size: 0x04
		/// </summary>
		public float minTriggerDeadzone
		{
			get
			{
				return ReadSingle(0x32C);
			}
			set
			{
				WriteSingle(0x32C,value);
			}
		}
		
	}


	/// <summary>
	/// USettingsGameplayBase:USubSettingsMaster
	/// Size: 0x4A0
	/// Properties: 12
	/// </summary>
	public class USettingsGameplayBase:USubSettingsMaster
	{
		public override int ObjectSize => 1184;
		/// <summary>
		/// Name: m_LastNudity
		/// Type: ByteProperty
		/// Offset: 0x310
		/// Size: 0x01
		/// </summary>
		public byte m_LastNudity
		{
			get
			{
				return ReadByte(0x310);
			}
			set
			{
				WriteByte(0x310,value);
			}
		}
		
		/// <summary>
		/// Name: English
		/// Type: TextProperty
		/// Offset: 0x318
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: German
		/// Type: TextProperty
		/// Offset: 0x330
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: Spanish
		/// Type: TextProperty
		/// Offset: 0x348
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: French
		/// Type: TextProperty
		/// Offset: 0x360
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: Russian
		/// Type: TextProperty
		/// Offset: 0x378
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: Polish
		/// Type: TextProperty
		/// Offset: 0x390
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: Brazilian
		/// Type: TextProperty
		/// Offset: 0x3A8
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: Korean
		/// Type: TextProperty
		/// Offset: 0x3C0
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: Japanese
		/// Type: TextProperty
		/// Offset: 0x3D8
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: SimplifiedChinese
		/// Type: TextProperty
		/// Offset: 0x3F0
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: TraditionalChinese
		/// Type: TextProperty
		/// Offset: 0x408
		/// Size: 0x18
		/// </summary>
		
	}


	/// <summary>
	/// USettingsKeyBindingsBase:USubSettingsMaster
	/// Size: 0x388
	/// Properties: 1
	/// </summary>
	public class USettingsKeyBindingsBase:USubSettingsMaster
	{
		public override int ObjectSize => 904;
		/// <summary>
		/// Name: m_CategoryClass
		/// Type: ClassProperty
		/// Offset: 0x360
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// USettingsServerBase:USubSettingsMaster
	/// Size: 0x5C8
	/// Properties: 1
	/// </summary>
	public class USettingsServerBase:USubSettingsMaster
	{
		public override int ObjectSize => 1480;
		/// <summary>
		/// Name: MaxPasswordLength
		/// Type: FloatProperty
		/// Offset: 0x310
		/// Size: 0x04
		/// </summary>
		public float MaxPasswordLength
		{
			get
			{
				return ReadSingle(0x310);
			}
			set
			{
				WriteSingle(0x310,value);
			}
		}
		
	}


	/// <summary>
	/// USettingsVideoBase:USubSettingsMaster
	/// Size: 0x430
	/// Properties: 5
	/// </summary>
	public class USettingsVideoBase:USubSettingsMaster
	{
		public override int ObjectSize => 1072;
		/// <summary>
		/// Name: maxGamma
		/// Type: FloatProperty
		/// Offset: 0x320
		/// Size: 0x04
		/// </summary>
		public float maxGamma
		{
			get
			{
				return ReadSingle(0x320);
			}
			set
			{
				WriteSingle(0x320,value);
			}
		}
		
		/// <summary>
		/// Name: minGAMMA
		/// Type: FloatProperty
		/// Offset: 0x324
		/// Size: 0x04
		/// </summary>
		public float minGAMMA
		{
			get
			{
				return ReadSingle(0x324);
			}
			set
			{
				WriteSingle(0x324,value);
			}
		}
		
		/// <summary>
		/// Name: maxFOV
		/// Type: FloatProperty
		/// Offset: 0x328
		/// Size: 0x04
		/// </summary>
		public float maxFOV
		{
			get
			{
				return ReadSingle(0x328);
			}
			set
			{
				WriteSingle(0x328,value);
			}
		}
		
		/// <summary>
		/// Name: minFOV
		/// Type: FloatProperty
		/// Offset: 0x32C
		/// Size: 0x04
		/// </summary>
		public float minFOV
		{
			get
			{
				return ReadSingle(0x32C);
			}
			set
			{
				WriteSingle(0x32C,value);
			}
		}
		
		/// <summary>
		/// Name: IsVideoModeDirty
		/// Type: BoolProperty
		/// Offset: 0x330
		/// Size: 0x01
		/// </summary>
		public bool IsVideoModeDirty
		{
			get
			{
				return ReadBool(0x330);
			}
			set
			{
				WriteBool(0x330,value);
			}
		}
		
	}


	/// <summary>
	/// UTimeInputBox:URootWidget
	/// Size: 0x340
	/// Properties: 0
	/// </summary>
	public class UTimeInputBox:URootWidget
	{
		public override int ObjectSize => 832;
	}


	/// <summary>
	/// UAddMemberBase:UWindowRoot
	/// Size: 0x420
	/// Properties: 1
	/// </summary>
	public class UAddMemberBase:UWindowRoot
	{
		public override int ObjectSize => 1056;
		/// <summary>
		/// Name: ListEntryClass
		/// Type: ClassProperty
		/// Offset: 0x3C0
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// UChatWindow:UWindowRoot
	/// Size: 0x3B0
	/// Properties: 7
	/// </summary>
	public class UChatWindow:UWindowRoot
	{
		public override int ObjectSize => 944;
		/// <summary>
		/// Name: ChatLineClass
		/// Type: ClassProperty
		/// Offset: 0x378
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: SystemMessageColor
		/// Type: StructProperty
		/// Offset: 0x380
		/// Size: 0x04
		/// </summary>
		public FColor SystemMessageColor => ReadStruct<FColor>(0x380);
		
		/// <summary>
		/// Name: GlobalMessageColor
		/// Type: StructProperty
		/// Offset: 0x384
		/// Size: 0x04
		/// </summary>
		public FColor GlobalMessageColor => ReadStruct<FColor>(0x384);
		
		/// <summary>
		/// Name: LocalMessageColor
		/// Type: StructProperty
		/// Offset: 0x388
		/// Size: 0x04
		/// </summary>
		public FColor LocalMessageColor => ReadStruct<FColor>(0x388);
		
		/// <summary>
		/// Name: GuildMessageColor
		/// Type: StructProperty
		/// Offset: 0x38C
		/// Size: 0x04
		/// </summary>
		public FColor GuildMessageColor => ReadStruct<FColor>(0x38C);
		
		/// <summary>
		/// Name: PlayerNameColor
		/// Type: StructProperty
		/// Offset: 0x390
		/// Size: 0x04
		/// </summary>
		public FColor PlayerNameColor => ReadStruct<FColor>(0x390);
		
		/// <summary>
		/// Name: OtherPlayerNameColors
		/// Type: TArray<FColor>
		/// Offset: 0x398
		/// Size: 0x10
		/// SubElement Size: 0x04
		/// </summary>
		public TArray<FColor> OtherPlayerNameColors => new TArray<FColor>(BaseAddress+0x398);
		
	}


	/// <summary>
	/// UChestInventoryGUI:UWindowRoot
	/// Size: 0x390
	/// Properties: 1
	/// </summary>
	public class UChestInventoryGUI:UWindowRoot
	{
		public override int ObjectSize => 912;
		/// <summary>
		/// Name: m_ChestInventory
		/// Type: ObjectProperty
		/// Offset: 0x388
		/// Size: 0x08
		/// </summary>
		public UItemInventory m_ChestInventory => ReadUObject<UItemInventory>(0x388);
		
	}


	/// <summary>
	/// UConanIngameLoadingScreen:UWindowRoot
	/// Size: 0x378
	/// Properties: 0
	/// </summary>
	public class UConanIngameLoadingScreen:UWindowRoot
	{
		public override int ObjectSize => 888;
	}


	/// <summary>
	/// UCraftingGUIBase:UWindowRoot
	/// Size: 0x3D0
	/// Properties: 5
	/// </summary>
	public class UCraftingGUIBase:UWindowRoot
	{
		public override int ObjectSize => 976;
		/// <summary>
		/// Name: ChestInventoryViewClass
		/// Type: ClassProperty
		/// Offset: 0x378
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: CraftingStationInventoryViewClass
		/// Type: ClassProperty
		/// Offset: 0x380
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: PaperDollViewClass
		/// Type: ClassProperty
		/// Offset: 0x388
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: PlayerInventoryViewClass
		/// Type: ClassProperty
		/// Offset: 0x390
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: m_CurrentCenterPanel
		/// Type: ObjectProperty
		/// Offset: 0x3C8
		/// Size: 0x08
		/// </summary>
		public URootWidget m_CurrentCenterPanel => ReadUObject<URootWidget>(0x3C8);
		
	}


	/// <summary>
	/// UDyeWindow:UWindowRoot
	/// Size: 0x3D0
	/// Properties: 3
	/// </summary>
	public class UDyeWindow:UWindowRoot
	{
		public override int ObjectSize => 976;
		/// <summary>
		/// Name: DyeIndices
		/// Type: TArray<>
		/// Offset: 0x380
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: SavedDyeIndices
		/// Type: TArray<>
		/// Offset: 0x390
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: SelectedTintChannel
		/// Type: IntProperty
		/// Offset: 0x3A0
		/// Size: 0x04
		/// </summary>
		public int SelectedTintChannel
		{
			get
			{
				return ReadInt32(0x3A0);
			}
			set
			{
				WriteInt32(0x3A0,value);
			}
		}
		
	}


	/// <summary>
	/// UEmotesMenu:UWindowRoot
	/// Size: 0x3B8
	/// Properties: 6
	/// </summary>
	public class UEmotesMenu:UWindowRoot
	{
		public override int ObjectSize => 952;
		/// <summary>
		/// Name: Categories
		/// Type: TArray<FEmotesMenuCategoryNode>
		/// Offset: 0x378
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<FEmotesMenuCategoryNode> Categories => new TArray<FEmotesMenuCategoryNode>(BaseAddress+0x378);
		
		/// <summary>
		/// Name: CancelIcon
		/// Type: ObjectProperty
		/// Offset: 0x388
		/// Size: 0x08
		/// </summary>
		public UTexture2D CancelIcon => ReadUObject<UTexture2D>(0x388);
		
		/// <summary>
		/// Name: InventoryIcon
		/// Type: ObjectProperty
		/// Offset: 0x390
		/// Size: 0x08
		/// </summary>
		public UTexture2D InventoryIcon => ReadUObject<UTexture2D>(0x390);
		
		/// <summary>
		/// Name: MainMenuIcon
		/// Type: ObjectProperty
		/// Offset: 0x398
		/// Size: 0x08
		/// </summary>
		public UTexture2D MainMenuIcon => ReadUObject<UTexture2D>(0x398);
		
		/// <summary>
		/// Name: BackIcon
		/// Type: ObjectProperty
		/// Offset: 0x3A0
		/// Size: 0x08
		/// </summary>
		public UTexture2D BackIcon => ReadUObject<UTexture2D>(0x3A0);
		
		/// <summary>
		/// Name: m_Inventory
		/// Type: ObjectProperty
		/// Offset: 0x3A8
		/// Size: 0x08
		/// </summary>
		public UItemInventory m_Inventory => ReadUObject<UItemInventory>(0x3A8);
		
	}


	/// <summary>
	/// UFeatWindow:UWindowRoot
	/// Size: 0x4B0
	/// Properties: 10
	/// </summary>
	public class UFeatWindow:UWindowRoot
	{
		public override int ObjectSize => 1200;
		/// <summary>
		/// Name: FeatResultRecipeInfoViewClass
		/// Type: ClassProperty
		/// Offset: 0x378
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: ResultListItemSpacing
		/// Type: FloatProperty
		/// Offset: 0x380
		/// Size: 0x04
		/// </summary>
		public float ResultListItemSpacing
		{
			get
			{
				return ReadSingle(0x380);
			}
			set
			{
				WriteSingle(0x380,value);
			}
		}
		
		/// <summary>
		/// Name: BackgroundColorNotPurchaseable
		/// Type: StructProperty
		/// Offset: 0x384
		/// Size: 0x10
		/// </summary>
		public FLinearColor BackgroundColorNotPurchaseable => ReadStruct<FLinearColor>(0x384);
		
		/// <summary>
		/// Name: BackgroundColorPurchaseable
		/// Type: StructProperty
		/// Offset: 0x394
		/// Size: 0x10
		/// </summary>
		public FLinearColor BackgroundColorPurchaseable => ReadStruct<FLinearColor>(0x394);
		
		/// <summary>
		/// Name: BackgroundColorPurchased
		/// Type: StructProperty
		/// Offset: 0x3A4
		/// Size: 0x10
		/// </summary>
		public FLinearColor BackgroundColorPurchased => ReadStruct<FLinearColor>(0x3A4);
		
		/// <summary>
		/// Name: FrameColorIsBlocking
		/// Type: StructProperty
		/// Offset: 0x3B4
		/// Size: 0x10
		/// </summary>
		public FLinearColor FrameColorIsBlocking => ReadStruct<FLinearColor>(0x3B4);
		
		/// <summary>
		/// Name: FrameColorIsUnlocking
		/// Type: StructProperty
		/// Offset: 0x3C4
		/// Size: 0x10
		/// </summary>
		public FLinearColor FrameColorIsUnlocking => ReadStruct<FLinearColor>(0x3C4);
		
		/// <summary>
		/// Name: BorderOpen
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UTexture2D BorderOpen => ReadUObject<UTexture2D>(0x3D8);
		
		/// <summary>
		/// Name: BorderNotPurchaseable
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UTexture2D BorderNotPurchaseable => ReadUObject<UTexture2D>(0x3E0);
		
		/// <summary>
		/// Name: BorderPurchaseable
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UTexture2D BorderPurchaseable => ReadUObject<UTexture2D>(0x3E8);
		
	}


	/// <summary>
	/// UFIFOWindow:UWindowRoot
	/// Size: 0x378
	/// Properties: 0
	/// </summary>
	public class UFIFOWindow:UWindowRoot
	{
		public override int ObjectSize => 888;
	}


	/// <summary>
	/// UGuildViewBase:UWindowRoot
	/// Size: 0x438
	/// Properties: 0
	/// </summary>
	public class UGuildViewBase:UWindowRoot
	{
		public override int ObjectSize => 1080;
	}


	/// <summary>
	/// UHostLocalBase:UWindowRoot
	/// Size: 0x388
	/// Properties: 1
	/// </summary>
	public class UHostLocalBase:UWindowRoot
	{
		public override int ObjectSize => 904;
		/// <summary>
		/// Name: ServerSettingsClass
		/// Type: ClassProperty
		/// Offset: 0x380
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// UHUDCharacterStatIndicators:UWindowRoot
	/// Size: 0x3A8
	/// Properties: 0
	/// </summary>
	public class UHUDCharacterStatIndicators:UWindowRoot
	{
		public override int ObjectSize => 936;
	}


	/// <summary>
	/// UHUDCraftingBase:UWindowRoot
	/// Size: 0x390
	/// Properties: 1
	/// </summary>
	public class UHUDCraftingBase:UWindowRoot
	{
		public override int ObjectSize => 912;
		/// <summary>
		/// Name: m_CratfingQueue
		/// Type: ObjectProperty
		/// Offset: 0x378
		/// Size: 0x08
		/// </summary>
		public UCraftingQueue m_CratfingQueue => ReadUObject<UCraftingQueue>(0x378);
		
	}


	/// <summary>
	/// UIconGridBase:UWindowRoot
	/// Size: 0x378
	/// Properties: 0
	/// </summary>
	public class UIconGridBase:UWindowRoot
	{
		public override int ObjectSize => 888;
	}


	/// <summary>
	/// UInputBoxWidget:UWindowRoot
	/// Size: 0x3B8
	/// Properties: 0
	/// </summary>
	public class UInputBoxWidget:UWindowRoot
	{
		public override int ObjectSize => 952;
	}


	/// <summary>
	/// UItemInfoPopup:UWindowRoot
	/// Size: 0x3A8
	/// Properties: 1
	/// </summary>
	public class UItemInfoPopup:UWindowRoot
	{
		public override int ObjectSize => 936;
		/// <summary>
		/// Name: ItemStatViewClass
		/// Type: ClassProperty
		/// Offset: 0x378
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// UMainMenuBase:UWindowRoot
	/// Size: 0x3E0
	/// Properties: 0
	/// </summary>
	public class UMainMenuBase:UWindowRoot
	{
		public override int ObjectSize => 992;
	}


	/// <summary>
	/// UMainRadialMenu:UWindowRoot
	/// Size: 0x380
	/// Properties: 0
	/// </summary>
	public class UMainRadialMenu:UWindowRoot
	{
		public override int ObjectSize => 896;
	}


	/// <summary>
	/// UPaperdollGUIBase:UWindowRoot
	/// Size: 0x378
	/// Properties: 0
	/// </summary>
	public class UPaperdollGUIBase:UWindowRoot
	{
		public override int ObjectSize => 888;
	}


	/// <summary>
	/// UPasswordDialogBase:UWindowRoot
	/// Size: 0x5E0
	/// Properties: 1
	/// </summary>
	public class UPasswordDialogBase:UWindowRoot
	{
		public override int ObjectSize => 1504;
		/// <summary>
		/// Name: m_Session
		/// Type: StructProperty
		/// Offset: 0x410
		/// Size: 0xC8
		/// </summary>
		public FBlueprintSessionResult m_Session => ReadStruct<FBlueprintSessionResult>(0x410);
		
	}


	/// <summary>
	/// UPlaceableInfoBase:UWindowRoot
	/// Size: 0x398
	/// Properties: 0
	/// </summary>
	public class UPlaceableInfoBase:UWindowRoot
	{
		public override int ObjectSize => 920;
	}


	/// <summary>
	/// UPlayerlistBase:UWindowRoot
	/// Size: 0x3F8
	/// Properties: 3
	/// </summary>
	public class UPlayerlistBase:UWindowRoot
	{
		public override int ObjectSize => 1016;
		/// <summary>
		/// Name: PlayerNames
		/// Type: TArray<>
		/// Offset: 0x378
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: PlayerIds
		/// Type: TArray<>
		/// Offset: 0x388
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: BannedPlayers
		/// Type: TArray<>
		/// Offset: 0x398
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
	}


	/// <summary>
	/// USettingsBase:UWindowRoot
	/// Size: 0x3D0
	/// Properties: 0
	/// </summary>
	public class USettingsBase:UWindowRoot
	{
		public override int ObjectSize => 976;
	}


	/// <summary>
	/// UShortcutBarBase:UWindowRoot
	/// Size: 0x408
	/// Properties: 4
	/// </summary>
	public class UShortcutBarBase:UWindowRoot
	{
		public override int ObjectSize => 1032;
		/// <summary>
		/// Name: m_ShortcutInventory
		/// Type: ObjectProperty
		/// Offset: 0x378
		/// Size: 0x08
		/// </summary>
		public UItemInventory m_ShortcutInventory => ReadUObject<UItemInventory>(0x378);
		
		/// <summary>
		/// Name: m_BackpackInventory
		/// Type: ObjectProperty
		/// Offset: 0x380
		/// Size: 0x08
		/// </summary>
		public UItemInventory m_BackpackInventory => ReadUObject<UItemInventory>(0x380);
		
		/// <summary>
		/// Name: m_EquipmentInventory
		/// Type: ObjectProperty
		/// Offset: 0x388
		/// Size: 0x08
		/// </summary>
		public UEquipmentInventory m_EquipmentInventory => ReadUObject<UEquipmentInventory>(0x388);
		
		/// <summary>
		/// Name: m_CharacterCratfingQ
		/// Type: ObjectProperty
		/// Offset: 0x390
		/// Size: 0x08
		/// </summary>
		public UCraftingQueue m_CharacterCratfingQ => ReadUObject<UCraftingQueue>(0x390);
		
	}


	/// <summary>
	/// UStackSplitValueDialog:UWindowRoot
	/// Size: 0x3B0
	/// Properties: 2
	/// </summary>
	public class UStackSplitValueDialog:UWindowRoot
	{
		public override int ObjectSize => 944;
		/// <summary>
		/// Name: m_SrcInventory
		/// Type: ObjectProperty
		/// Offset: 0x390
		/// Size: 0x08
		/// </summary>
		public UItemInventory m_SrcInventory => ReadUObject<UItemInventory>(0x390);
		
		/// <summary>
		/// Name: m_DstInventory
		/// Type: ObjectProperty
		/// Offset: 0x398
		/// Size: 0x08
		/// </summary>
		public UItemInventory m_DstInventory => ReadUObject<UItemInventory>(0x398);
		
	}


	/// <summary>
	/// UThrallViewBase:UWindowRoot
	/// Size: 0x3A0
	/// Properties: 0
	/// </summary>
	public class UThrallViewBase:UWindowRoot
	{
		public override int ObjectSize => 928;
	}


	/// <summary>
	/// UVoiceChatWindow:UWindowRoot
	/// Size: 0x388
	/// Properties: 1
	/// </summary>
	public class UVoiceChatWindow:UWindowRoot
	{
		public override int ObjectSize => 904;
		/// <summary>
		/// Name: ChatLineClass
		/// Type: ClassProperty
		/// Offset: 0x378
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// USaveLevelCallProxy:UBlueprintAsyncActionBase
	/// Size: 0x68
	/// Properties: 0
	/// </summary>
	public class USaveLevelCallProxy:UBlueprintAsyncActionBase
	{
		public override int ObjectSize => 104;
	}


	/// <summary>
	/// AServerBlacklist:AInfo
	/// Size: 0x420
	/// Properties: 1
	/// </summary>
	public class AServerBlacklist:AInfo
	{
		public override int ObjectSize => 1056;
		/// <summary>
		/// Name: Blacklist
		/// Type: MapProperty
		/// Offset: 0x3D0
		/// Size: 0x50
		/// </summary>
		
	}


	/// <summary>
	/// USetUserLoginStatusCallProxy:UBlueprintAsyncActionBase
	/// Size: 0x70
	/// Properties: 0
	/// </summary>
	public class USetUserLoginStatusCallProxy:UBlueprintAsyncActionBase
	{
		public override int ObjectSize => 112;
	}


	/// <summary>
	/// ASharedDebugInfo:AActor
	/// Size: 0x3D8
	/// Properties: 0
	/// </summary>
	public class ASharedDebugInfo:AActor
	{
		public override int ObjectSize => 984;
	}


	/// <summary>
	/// USoundBase:UObject
	/// Size: 0x70
	/// Properties: 11
	/// </summary>
	public class USoundBase:UObject
	{
		public override int ObjectSize => 112;
		/// <summary>
		/// Name: SoundClassObject
		/// Type: ObjectProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		public USoundClass SoundClassObject => ReadUObject<USoundClass>(0x28);
		
		/// <summary>
		/// Name: bDebug
		/// Type: BoolProperty
		/// Offset: 0x30
		/// Size: 0x01
		/// </summary>
		public bool bDebug => (ReadByte(0x0030) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bOverrideConcurrency
		/// Type: BoolProperty
		/// Offset: 0x30
		/// Size: 0x01
		/// </summary>
		public bool bOverrideConcurrency => (ReadByte(0x0030) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bIgnoreFocus
		/// Type: BoolProperty
		/// Offset: 0x30
		/// Size: 0x01
		/// </summary>
		public bool bIgnoreFocus => (ReadByte(0x0030) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: SoundConcurrencySettings
		/// Type: ObjectProperty
		/// Offset: 0x38
		/// Size: 0x08
		/// </summary>
		public USoundConcurrency SoundConcurrencySettings => ReadUObject<USoundConcurrency>(0x38);
		
		/// <summary>
		/// Name: ConcurrencyOverrides
		/// Type: StructProperty
		/// Offset: 0x40
		/// Size: 0x10
		/// </summary>
		public FSoundConcurrencySettings ConcurrencyOverrides => ReadStruct<FSoundConcurrencySettings>(0x40);
		
		/// <summary>
		/// Name: MaxConcurrentResolutionRule
		/// Type: ByteProperty
		/// Offset: 0x50
		/// Size: 0x01
		/// </summary>
		public byte MaxConcurrentResolutionRule
		{
			get
			{
				return ReadByte(0x50);
			}
			set
			{
				WriteByte(0x50,value);
			}
		}
		
		/// <summary>
		/// Name: MaxConcurrentPlayCount
		/// Type: IntProperty
		/// Offset: 0x54
		/// Size: 0x04
		/// </summary>
		public int MaxConcurrentPlayCount
		{
			get
			{
				return ReadInt32(0x54);
			}
			set
			{
				WriteInt32(0x54,value);
			}
		}
		
		/// <summary>
		/// Name: Duration
		/// Type: FloatProperty
		/// Offset: 0x58
		/// Size: 0x04
		/// </summary>
		public float Duration
		{
			get
			{
				return ReadSingle(0x58);
			}
			set
			{
				WriteSingle(0x58,value);
			}
		}
		
		/// <summary>
		/// Name: AttenuationSettings
		/// Type: ObjectProperty
		/// Offset: 0x60
		/// Size: 0x08
		/// </summary>
		public USoundAttenuation AttenuationSettings => ReadUObject<USoundAttenuation>(0x60);
		
		/// <summary>
		/// Name: Priority
		/// Type: FloatProperty
		/// Offset: 0x68
		/// Size: 0x04
		/// </summary>
		public float Priority
		{
			get
			{
				return ReadSingle(0x68);
			}
			set
			{
				WriteSingle(0x68,value);
			}
		}
		
	}


	/// <summary>
	/// USoundWave:USoundBase
	/// Size: 0x238
	/// Properties: 17
	/// </summary>
	public class USoundWave:USoundBase
	{
		public override int ObjectSize => 568;
		/// <summary>
		/// Name: CompressionQuality
		/// Type: IntProperty
		/// Offset: 0x70
		/// Size: 0x04
		/// </summary>
		public int CompressionQuality
		{
			get
			{
				return ReadInt32(0x70);
			}
			set
			{
				WriteInt32(0x70,value);
			}
		}
		
		/// <summary>
		/// Name: bLooping
		/// Type: BoolProperty
		/// Offset: 0x74
		/// Size: 0x01
		/// </summary>
		public bool bLooping => (ReadByte(0x0074) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bStreaming
		/// Type: BoolProperty
		/// Offset: 0x74
		/// Size: 0x01
		/// </summary>
		public bool bStreaming => (ReadByte(0x0074) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: StreamingPriority
		/// Type: IntProperty
		/// Offset: 0x78
		/// Size: 0x04
		/// </summary>
		public int StreamingPriority
		{
			get
			{
				return ReadInt32(0x78);
			}
			set
			{
				WriteInt32(0x78,value);
			}
		}
		
		/// <summary>
		/// Name: bMature
		/// Type: BoolProperty
		/// Offset: 0x7C
		/// Size: 0x01
		/// </summary>
		public bool bMature => (ReadByte(0x007C) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bManualWordWrap
		/// Type: BoolProperty
		/// Offset: 0x7C
		/// Size: 0x01
		/// </summary>
		public bool bManualWordWrap => (ReadByte(0x007C) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bSingleLine
		/// Type: BoolProperty
		/// Offset: 0x7C
		/// Size: 0x01
		/// </summary>
		public bool bSingleLine => (ReadByte(0x007C) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: SoundGroup
		/// Type: ByteProperty
		/// Offset: 0x80
		/// Size: 0x01
		/// </summary>
		public byte SoundGroup
		{
			get
			{
				return ReadByte(0x80);
			}
			set
			{
				WriteByte(0x80,value);
			}
		}
		
		/// <summary>
		/// Name: SpokenText
		/// Type: StrProperty
		/// Offset: 0x88
		/// Size: 0x10
		/// </summary>
		public FString SpokenText => new FString(BaseAddress+0x88);
		
		/// <summary>
		/// Name: SubtitlePriority
		/// Type: FloatProperty
		/// Offset: 0x98
		/// Size: 0x04
		/// </summary>
		public float SubtitlePriority
		{
			get
			{
				return ReadSingle(0x98);
			}
			set
			{
				WriteSingle(0x98,value);
			}
		}
		
		/// <summary>
		/// Name: Volume
		/// Type: FloatProperty
		/// Offset: 0x9C
		/// Size: 0x04
		/// </summary>
		public float Volume
		{
			get
			{
				return ReadSingle(0x9C);
			}
			set
			{
				WriteSingle(0x9C,value);
			}
		}
		
		/// <summary>
		/// Name: Pitch
		/// Type: FloatProperty
		/// Offset: 0xA0
		/// Size: 0x04
		/// </summary>
		public float Pitch
		{
			get
			{
				return ReadSingle(0xA0);
			}
			set
			{
				WriteSingle(0xA0,value);
			}
		}
		
		/// <summary>
		/// Name: NumChannels
		/// Type: IntProperty
		/// Offset: 0xA4
		/// Size: 0x04
		/// </summary>
		public int NumChannels
		{
			get
			{
				return ReadInt32(0xA4);
			}
			set
			{
				WriteInt32(0xA4,value);
			}
		}
		
		/// <summary>
		/// Name: SampleRate
		/// Type: IntProperty
		/// Offset: 0xA8
		/// Size: 0x04
		/// </summary>
		public int SampleRate
		{
			get
			{
				return ReadInt32(0xA8);
			}
			set
			{
				WriteInt32(0xA8,value);
			}
		}
		
		/// <summary>
		/// Name: RawPCMDataSize
		/// Type: IntProperty
		/// Offset: 0xAC
		/// Size: 0x04
		/// </summary>
		public int RawPCMDataSize
		{
			get
			{
				return ReadInt32(0xAC);
			}
			set
			{
				WriteInt32(0xAC,value);
			}
		}
		
		/// <summary>
		/// Name: Subtitles
		/// Type: TArray<FSubtitleCue>
		/// Offset: 0xB0
		/// Size: 0x10
		/// SubElement Size: 0x20
		/// </summary>
		public TArray<FSubtitleCue> Subtitles => new TArray<FSubtitleCue>(BaseAddress+0xB0);
		
		/// <summary>
		/// Name: LocalizedSubtitles
		/// Type: TArray<FLocalizedSubtitle>
		/// Offset: 0xC0
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<FLocalizedSubtitle> LocalizedSubtitles => new TArray<FLocalizedSubtitle>(BaseAddress+0xC0);
		
	}


	/// <summary>
	/// USoundWaveProcedural:USoundWave
	/// Size: 0x2C0
	/// Properties: 0
	/// </summary>
	public class USoundWaveProcedural:USoundWave
	{
		public override int ObjectSize => 704;
	}


	/// <summary>
	/// USoundWaveVoiceChat:USoundWaveProcedural
	/// Size: 0x2C0
	/// Properties: 0
	/// </summary>
	public class USoundWaveVoiceChat:USoundWaveProcedural
	{
		public override int ObjectSize => 704;
	}


	/// <summary>
	/// UStatIntArray:UObject
	/// Size: 0x40
	/// Properties: 2
	/// </summary>
	public class UStatIntArray:UObject
	{
		public override int ObjectSize => 64;
		/// <summary>
		/// Name: Key
		/// Type: NameProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: Stats
		/// Type: TArray<FStatIntEntry>
		/// Offset: 0x30
		/// Size: 0x10
		/// SubElement Size: 0x08
		/// </summary>
		public TArray<FStatIntEntry> Stats => new TArray<FStatIntEntry>(BaseAddress+0x30);
		
	}


	/// <summary>
	/// UStatFloatArray:UObject
	/// Size: 0x40
	/// Properties: 2
	/// </summary>
	public class UStatFloatArray:UObject
	{
		public override int ObjectSize => 64;
		/// <summary>
		/// Name: Key
		/// Type: NameProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: Stats
		/// Type: TArray<FStatFloatEntry>
		/// Offset: 0x30
		/// Size: 0x10
		/// SubElement Size: 0x08
		/// </summary>
		public TArray<FStatFloatEntry> Stats => new TArray<FStatFloatEntry>(BaseAddress+0x30);
		
	}


	/// <summary>
	/// UWeightedTableArray:UObject
	/// Size: 0x48
	/// Properties: 3
	/// </summary>
	public class UWeightedTableArray:UObject
	{
		public override int ObjectSize => 72;
		/// <summary>
		/// Name: Key
		/// Type: NameProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: TotalWeight
		/// Type: FloatProperty
		/// Offset: 0x30
		/// Size: 0x04
		/// </summary>
		public float TotalWeight
		{
			get
			{
				return ReadSingle(0x30);
			}
			set
			{
				WriteSingle(0x30,value);
			}
		}
		
		/// <summary>
		/// Name: Entries
		/// Type: TArray<FWeightedTableEntry>
		/// Offset: 0x38
		/// Size: 0x10
		/// SubElement Size: 0x18
		/// </summary>
		public TArray<FWeightedTableEntry> Entries => new TArray<FWeightedTableEntry>(BaseAddress+0x38);
		
	}


	/// <summary>
	/// USpawnTableComponent:UActorComponent
	/// Size: 0x2E0
	/// Properties: 9
	/// </summary>
	public class USpawnTableComponent:UActorComponent
	{
		public override int ObjectSize => 736;
		/// <summary>
		/// Name: m_StatIntTable
		/// Type: TArray<UStatIntArray>
		/// Offset: 0xD8
		/// Size: 0x10
		/// SubElement Size: 0x40
		/// </summary>
		public TArray<UStatIntArray> m_StatIntTable => new TArray<UStatIntArray>(BaseAddress+0xD8);
		
		/// <summary>
		/// Name: m_StatIntModifierTable
		/// Type: TArray<UStatIntArray>
		/// Offset: 0xE8
		/// Size: 0x10
		/// SubElement Size: 0x40
		/// </summary>
		public TArray<UStatIntArray> m_StatIntModifierTable => new TArray<UStatIntArray>(BaseAddress+0xE8);
		
		/// <summary>
		/// Name: m_StatFloatTable
		/// Type: TArray<UStatFloatArray>
		/// Offset: 0xF8
		/// Size: 0x10
		/// SubElement Size: 0x40
		/// </summary>
		public TArray<UStatFloatArray> m_StatFloatTable => new TArray<UStatFloatArray>(BaseAddress+0xF8);
		
		/// <summary>
		/// Name: m_StatFloatModifierTable
		/// Type: TArray<UStatFloatArray>
		/// Offset: 0x108
		/// Size: 0x10
		/// SubElement Size: 0x40
		/// </summary>
		public TArray<UStatFloatArray> m_StatFloatModifierTable => new TArray<UStatFloatArray>(BaseAddress+0x108);
		
		/// <summary>
		/// Name: m_WeightedSpawnTable
		/// Type: TArray<UWeightedTableArray>
		/// Offset: 0x118
		/// Size: 0x10
		/// SubElement Size: 0x48
		/// </summary>
		public TArray<UWeightedTableArray> m_WeightedSpawnTable => new TArray<UWeightedTableArray>(BaseAddress+0x118);
		
		/// <summary>
		/// Name: m_SpawnTable
		/// Type: ObjectProperty
		/// Offset: 0x128
		/// Size: 0x08
		/// </summary>
		public UDataTable m_SpawnTable => ReadUObject<UDataTable>(0x128);
		
		/// <summary>
		/// Name: m_EquipmentTable
		/// Type: ObjectProperty
		/// Offset: 0x130
		/// Size: 0x08
		/// </summary>
		public UDataTable m_EquipmentTable => ReadUObject<UDataTable>(0x130);
		
		/// <summary>
		/// Name: m_ProfessionTable
		/// Type: ObjectProperty
		/// Offset: 0x138
		/// Size: 0x08
		/// </summary>
		public UDataTable m_ProfessionTable => ReadUObject<UDataTable>(0x138);
		
		/// <summary>
		/// Name: m_RaceTable
		/// Type: ObjectProperty
		/// Offset: 0x140
		/// Size: 0x08
		/// </summary>
		public UDataTable m_RaceTable => ReadUObject<UDataTable>(0x140);
		
	}


	/// <summary>
	/// AStaticWaypoint:AActor
	/// Size: 0x3E0
	/// Properties: 2
	/// </summary>
	public class AStaticWaypoint:AActor
	{
		public override int ObjectSize => 992;
		/// <summary>
		/// Name: NextWaypoint
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public AStaticWaypoint NextWaypoint => ReadUObject<AStaticWaypoint>(0x3D0);
		
		/// <summary>
		/// Name: Root
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public USceneComponent Root => ReadUObject<USceneComponent>(0x3D8);
		
	}


	/// <summary>
	/// AStaticSpawnPoint:AActor
	/// Size: 0x3D8
	/// Properties: 1
	/// </summary>
	public class AStaticSpawnPoint:AActor
	{
		public override int ObjectSize => 984;
		/// <summary>
		/// Name: Root
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public USceneComponent Root => ReadUObject<USceneComponent>(0x3D0);
		
	}


	/// <summary>
	/// UStaticNavigationProviderInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UStaticNavigationProviderInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// ASuspendableActor:AActor
	/// Size: 0x3D8
	/// Properties: 0
	/// </summary>
	public class ASuspendableActor:AActor
	{
		public override int ObjectSize => 984;
	}


	/// <summary>
	/// UTargetAreaAllocatorComponent:UActorComponent
	/// Size: 0xF0
	/// Properties: 1
	/// </summary>
	public class UTargetAreaAllocatorComponent:UActorComponent
	{
		public override int ObjectSize => 240;
		/// <summary>
		/// Name: CachedAreas
		/// Type: TArray<FTargetAreaAllocationData>
		/// Offset: 0xD8
		/// Size: 0x10
		/// SubElement Size: 0x38
		/// </summary>
		public TArray<FTargetAreaAllocationData> CachedAreas => new TArray<FTargetAreaAllocationData>(BaseAddress+0xD8);
		
	}


	/// <summary>
	/// UShapeComponent:UPrimitiveComponent
	/// Size: 0x5D0
	/// Properties: 7
	/// </summary>
	public class UShapeComponent:UPrimitiveComponent
	{
		public override int ObjectSize => 1488;
		/// <summary>
		/// Name: ShapeColor
		/// Type: StructProperty
		/// Offset: 0x5A0
		/// Size: 0x04
		/// </summary>
		public FColor ShapeColor => ReadStruct<FColor>(0x5A0);
		
		/// <summary>
		/// Name: ShapeBodySetup
		/// Type: ObjectProperty
		/// Offset: 0x5A8
		/// Size: 0x08
		/// </summary>
		public UBodySetup ShapeBodySetup => ReadUObject<UBodySetup>(0x5A8);
		
		/// <summary>
		/// Name: bDrawOnlyIfSelected
		/// Type: BoolProperty
		/// Offset: 0x5B0
		/// Size: 0x01
		/// </summary>
		public bool bDrawOnlyIfSelected => (ReadByte(0x05B0) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bShouldCollideWhenPlacing
		/// Type: BoolProperty
		/// Offset: 0x5B0
		/// Size: 0x01
		/// </summary>
		public bool bShouldCollideWhenPlacing => (ReadByte(0x05B0) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bDynamicObstacle
		/// Type: BoolProperty
		/// Offset: 0x5B0
		/// Size: 0x01
		/// </summary>
		public bool bDynamicObstacle => (ReadByte(0x05B0) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: AreaClass
		/// Type: ClassProperty
		/// Offset: 0x5B8
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: HitLocation
		/// Type: ByteProperty
		/// Offset: 0x5C0
		/// Size: 0x01
		/// </summary>
		public byte HitLocation
		{
			get
			{
				return ReadByte(0x5C0);
			}
			set
			{
				WriteByte(0x5C0,value);
			}
		}
		
	}


	/// <summary>
	/// UTargetAreaComponent:UShapeComponent
	/// Size: 0x5D0
	/// Properties: 2
	/// </summary>
	public class UTargetAreaComponent:UShapeComponent
	{
		public override int ObjectSize => 1488;
		/// <summary>
		/// Name: TargetAreaRadius
		/// Type: FloatProperty
		/// Offset: 0x5C8
		/// Size: 0x04
		/// </summary>
		public float TargetAreaRadius
		{
			get
			{
				return ReadSingle(0x5C8);
			}
			set
			{
				WriteSingle(0x5C8,value);
			}
		}
		
		/// <summary>
		/// Name: TargetAreaDepth
		/// Type: FloatProperty
		/// Offset: 0x5CC
		/// Size: 0x04
		/// </summary>
		public float TargetAreaDepth
		{
			get
			{
				return ReadSingle(0x5CC);
			}
			set
			{
				WriteSingle(0x5CC,value);
			}
		}
		
	}


	/// <summary>
	/// UTargetingMonitorInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UTargetingMonitorInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UTargetingMonitorHelper:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UTargetingMonitorHelper:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UTargetingControllersComponent:UActorComponent
	/// Size: 0xE8
	/// Properties: 0
	/// </summary>
	public class UTargetingControllersComponent:UActorComponent
	{
		public override int ObjectSize => 232;
	}


	/// <summary>
	/// UTestable:UActorComponent
	/// Size: 0x110
	/// Properties: 1
	/// </summary>
	public class UTestable:UActorComponent
	{
		public override int ObjectSize => 272;
		/// <summary>
		/// Name: TestLabels
		/// Type: TArray<>
		/// Offset: 0xD8
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
	}


	/// <summary>
	/// UTestUtils:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UTestUtils:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UThrallComponent:UActorComponent
	/// Size: 0x180
	/// Properties: 6
	/// </summary>
	public class UThrallComponent:UActorComponent
	{
		public override int ObjectSize => 384;
		/// <summary>
		/// Name: ClaimRadiusBuilding
		/// Type: FloatProperty
		/// Offset: 0xD8
		/// Size: 0x04
		/// </summary>
		public float ClaimRadiusBuilding
		{
			get
			{
				return ReadSingle(0xD8);
			}
			set
			{
				WriteSingle(0xD8,value);
			}
		}
		
		/// <summary>
		/// Name: ClaimRadiusFoliage
		/// Type: FloatProperty
		/// Offset: 0xDC
		/// Size: 0x04
		/// </summary>
		public float ClaimRadiusFoliage
		{
			get
			{
				return ReadSingle(0xDC);
			}
			set
			{
				WriteSingle(0xDC,value);
			}
		}
		
		/// <summary>
		/// Name: ClaimLocation
		/// Type: StructProperty
		/// Offset: 0xE0
		/// Size: 0x0C
		/// </summary>
		public FVector ClaimLocation => ReadStruct<FVector>(0xE0);
		
		/// <summary>
		/// Name: ThrallInfo
		/// Type: StructProperty
		/// Offset: 0xF0
		/// Size: 0x80
		/// </summary>
		public FThrallInfo ThrallInfo => ReadStruct<FThrallInfo>(0xF0);
		
		/// <summary>
		/// Name: OwnerUniqueID
		/// Type: ObjectProperty
		/// Offset: 0x170
		/// Size: 0x08
		/// </summary>
		public UUniqueID OwnerUniqueID => ReadUObject<UUniqueID>(0x170);
		
		/// <summary>
		/// Name: IsABrush
		/// Type: BoolProperty
		/// Offset: 0x178
		/// Size: 0x01
		/// </summary>
		public bool IsABrush
		{
			get
			{
				return ReadBool(0x178);
			}
			set
			{
				WriteBool(0x178,value);
			}
		}
		
	}


	/// <summary>
	/// UThrallInfoComponent:UActorComponent
	/// Size: 0x158
	/// Properties: 1
	/// </summary>
	public class UThrallInfoComponent:UActorComponent
	{
		public override int ObjectSize => 344;
		/// <summary>
		/// Name: ThrallInfo
		/// Type: StructProperty
		/// Offset: 0xD8
		/// Size: 0x80
		/// </summary>
		public FThrallInfo ThrallInfo => ReadStruct<FThrallInfo>(0xD8);
		
	}


	/// <summary>
	/// UThrallOwnerInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UThrallOwnerInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UThrallSystemComponent:UActorComponent
	/// Size: 0xF0
	/// Properties: 3
	/// </summary>
	public class UThrallSystemComponent:UActorComponent
	{
		public override int ObjectSize => 240;
		/// <summary>
		/// Name: IsPlacingThrall
		/// Type: BoolProperty
		/// Offset: 0xD8
		/// Size: 0x01
		/// </summary>
		public bool IsPlacingThrall
		{
			get
			{
				return ReadBool(0xD8);
			}
			set
			{
				WriteBool(0xD8,value);
			}
		}
		
		/// <summary>
		/// Name: CurrentThrallBrushClass
		/// Type: ClassProperty
		/// Offset: 0xE0
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: CurrentThrallItem
		/// Type: ObjectProperty
		/// Offset: 0xE8
		/// Size: 0x08
		/// </summary>
		public UThrallItem CurrentThrallItem => ReadUObject<UThrallItem>(0xE8);
		
	}


	/// <summary>
	/// UInventoryIconTooltipView:UTooltipWidget
	/// Size: 0x250
	/// Properties: 1
	/// </summary>
	public class UInventoryIconTooltipView:UTooltipWidget
	{
		public override int ObjectSize => 592;
		/// <summary>
		/// Name: m_GameItem
		/// Type: ObjectProperty
		/// Offset: 0x240
		/// Size: 0x08
		/// </summary>
		public UGameItem m_GameItem => ReadUObject<UGameItem>(0x240);
		
	}


	/// <summary>
	/// UUIResourceSingleton:UObject
	/// Size: 0x60
	/// Properties: 5
	/// </summary>
	public class UUIResourceSingleton:UObject
	{
		public override int ObjectSize => 96;
		/// <summary>
		/// Name: MessageBoxWidgetClass
		/// Type: ClassProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: MouseBlockWindowClass
		/// Type: ClassProperty
		/// Offset: 0x30
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: LoadingScreenWidget
		/// Type: ClassProperty
		/// Offset: 0x38
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: InputBoxWidgetClass
		/// Type: ClassProperty
		/// Offset: 0x40
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: StartupSound
		/// Type: StructProperty
		/// Offset: 0x48
		/// Size: 0x18
		/// </summary>
		public FSlateSound StartupSound => ReadStruct<FSlateSound>(0x48);
		
	}


	/// <summary>
	/// UUtilityMatrix:UObject
	/// Size: 0x98
	/// Properties: 2
	/// </summary>
	public class UUtilityMatrix:UObject
	{
		public override int ObjectSize => 152;
		/// <summary>
		/// Name: Bounds
		/// Type: StructProperty
		/// Offset: 0x28
		/// Size: 0x18
		/// </summary>
		public FBoxBounds Bounds => ReadStruct<FBoxBounds>(0x28);
		
		/// <summary>
		/// Name: UnitsPerCell
		/// Type: FloatProperty
		/// Offset: 0x40
		/// Size: 0x04
		/// </summary>
		public float UnitsPerCell
		{
			get
			{
				return ReadSingle(0x40);
			}
			set
			{
				WriteSingle(0x40,value);
			}
		}
		
	}


	/// <summary>
	/// UAnimNotifyState:UObject
	/// Size: 0x30
	/// Properties: 0
	/// </summary>
	public class UAnimNotifyState:UObject
	{
		public override int ObjectSize => 48;
	}


	/// <summary>
	/// UWeaponCollisionAnimNotifyState:UAnimNotifyState
	/// Size: 0x30
	/// Properties: 0
	/// </summary>
	public class UWeaponCollisionAnimNotifyState:UAnimNotifyState
	{
		public override int ObjectSize => 48;
	}


	/// <summary>
	/// UGCObjectReferencer:UObject
	/// Size: 0x38
	/// Properties: 0
	/// </summary>
	public class UGCObjectReferencer:UObject
	{
		public override int ObjectSize => 56;
	}


	/// <summary>
	/// UTextBuffer:UObject
	/// Size: 0x50
	/// Properties: 0
	/// </summary>
	public class UTextBuffer:UObject
	{
		public override int ObjectSize => 80;
	}


	/// <summary>
	/// UPackage:UObject
	/// Size: 0x150
	/// Properties: 0
	/// </summary>
	public class UPackage:UObject
	{
		public override int ObjectSize => 336;
	}


	/// <summary>
	/// UDelegateFunction:UFunction
	/// Size: 0xB8
	/// Properties: 0
	/// </summary>
	public class UDelegateFunction:UFunction
	{
		public override int ObjectSize => 184;
	}


	/// <summary>
	/// UDynamicClass:UClass
	/// Size: 0x280
	/// Properties: 0
	/// </summary>
	public class UDynamicClass:UClass
	{
		public override int ObjectSize => 640;
	}


	/// <summary>
	/// UPackageMap:UObject
	/// Size: 0x50
	/// Properties: 0
	/// </summary>
	public class UPackageMap:UObject
	{
		public override int ObjectSize => 80;
	}


	/// <summary>
	/// UEnum:UField
	/// Size: 0x58
	/// Properties: 0
	/// </summary>
	public class UEnum:UField
	{
		public override int ObjectSize => 88;
	}


	/// <summary>
	/// ULinkerPlaceholderClass:UClass
	/// Size: 0x368
	/// Properties: 0
	/// </summary>
	public class ULinkerPlaceholderClass:UClass
	{
		public override int ObjectSize => 872;
	}


	/// <summary>
	/// ULinkerPlaceholderExportObject:UObject
	/// Size: 0x88
	/// Properties: 0
	/// </summary>
	public class ULinkerPlaceholderExportObject:UObject
	{
		public override int ObjectSize => 136;
	}


	/// <summary>
	/// ULinkerPlaceholderFunction:UFunction
	/// Size: 0x208
	/// Properties: 0
	/// </summary>
	public class ULinkerPlaceholderFunction:UFunction
	{
		public override int ObjectSize => 520;
	}


	/// <summary>
	/// UMetaData:UObject
	/// Size: 0x78
	/// Properties: 0
	/// </summary>
	public class UMetaData:UObject
	{
		public override int ObjectSize => 120;
	}


	/// <summary>
	/// UObjectRedirector:UObject
	/// Size: 0x30
	/// Properties: 0
	/// </summary>
	public class UObjectRedirector:UObject
	{
		public override int ObjectSize => 48;
	}


	/// <summary>
	/// UObjectPropertyBase:UProperty
	/// Size: 0x80
	/// Properties: 0
	/// </summary>
	public class UObjectPropertyBase:UProperty
	{
		public override int ObjectSize => 128;
	}


	/// <summary>
	/// UAssetObjectProperty:UObjectPropertyBase
	/// Size: 0x80
	/// Properties: 0
	/// </summary>
	public class UAssetObjectProperty:UObjectPropertyBase
	{
		public override int ObjectSize => 128;
	}


	/// <summary>
	/// UAssetClassProperty:UAssetObjectProperty
	/// Size: 0x88
	/// Properties: 0
	/// </summary>
	public class UAssetClassProperty:UAssetObjectProperty
	{
		public override int ObjectSize => 136;
	}


	/// <summary>
	/// UDelegateProperty:UProperty
	/// Size: 0x80
	/// Properties: 0
	/// </summary>
	public class UDelegateProperty:UProperty
	{
		public override int ObjectSize => 128;
	}


	/// <summary>
	/// UDoubleProperty:UNumericProperty
	/// Size: 0x78
	/// Properties: 0
	/// </summary>
	public class UDoubleProperty:UNumericProperty
	{
		public override int ObjectSize => 120;
	}


	/// <summary>
	/// UInt16Property:UNumericProperty
	/// Size: 0x78
	/// Properties: 0
	/// </summary>
	public class UInt16Property:UNumericProperty
	{
		public override int ObjectSize => 120;
	}


	/// <summary>
	/// UInt64Property:UNumericProperty
	/// Size: 0x78
	/// Properties: 0
	/// </summary>
	public class UInt64Property:UNumericProperty
	{
		public override int ObjectSize => 120;
	}


	/// <summary>
	/// UInt8Property:UNumericProperty
	/// Size: 0x78
	/// Properties: 0
	/// </summary>
	public class UInt8Property:UNumericProperty
	{
		public override int ObjectSize => 120;
	}


	/// <summary>
	/// ULazyObjectProperty:UObjectPropertyBase
	/// Size: 0x80
	/// Properties: 0
	/// </summary>
	public class ULazyObjectProperty:UObjectPropertyBase
	{
		public override int ObjectSize => 128;
	}


	/// <summary>
	/// UMapProperty:UProperty
	/// Size: 0xB0
	/// Properties: 0
	/// </summary>
	public class UMapProperty:UProperty
	{
		public override int ObjectSize => 176;
	}


	/// <summary>
	/// UMulticastDelegateProperty:UProperty
	/// Size: 0x80
	/// Properties: 0
	/// </summary>
	public class UMulticastDelegateProperty:UProperty
	{
		public override int ObjectSize => 128;
	}


	/// <summary>
	/// UNameProperty:UProperty
	/// Size: 0x78
	/// Properties: 0
	/// </summary>
	public class UNameProperty:UProperty
	{
		public override int ObjectSize => 120;
	}


	/// <summary>
	/// UStrProperty:UProperty
	/// Size: 0x78
	/// Properties: 0
	/// </summary>
	public class UStrProperty:UProperty
	{
		public override int ObjectSize => 120;
	}


	/// <summary>
	/// UUInt16Property:UNumericProperty
	/// Size: 0x78
	/// Properties: 0
	/// </summary>
	public class UUInt16Property:UNumericProperty
	{
		public override int ObjectSize => 120;
	}


	/// <summary>
	/// UUInt32Property:UNumericProperty
	/// Size: 0x78
	/// Properties: 0
	/// </summary>
	public class UUInt32Property:UNumericProperty
	{
		public override int ObjectSize => 120;
	}


	/// <summary>
	/// UUInt64Property:UNumericProperty
	/// Size: 0x78
	/// Properties: 0
	/// </summary>
	public class UUInt64Property:UNumericProperty
	{
		public override int ObjectSize => 120;
	}


	/// <summary>
	/// UWeakObjectProperty:UObjectPropertyBase
	/// Size: 0x80
	/// Properties: 0
	/// </summary>
	public class UWeakObjectProperty:UObjectPropertyBase
	{
		public override int ObjectSize => 128;
	}


	/// <summary>
	/// UTextProperty:UProperty
	/// Size: 0x78
	/// Properties: 0
	/// </summary>
	public class UTextProperty:UProperty
	{
		public override int ObjectSize => 120;
	}


	/// <summary>
	/// UInputCoreTypes:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UInputCoreTypes:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UFontBulkData:UObject
	/// Size: 0xC0
	/// Properties: 0
	/// </summary>
	public class UFontBulkData:UObject
	{
		public override int ObjectSize => 192;
	}


	/// <summary>
	/// UFontProviderInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UFontProviderInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// USlateTypes:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class USlateTypes:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// USlateWidgetStyleContainerInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class USlateWidgetStyleContainerInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// USlateWidgetStyleContainerBase:UObject
	/// Size: 0x30
	/// Properties: 0
	/// </summary>
	public class USlateWidgetStyleContainerBase:UObject
	{
		public override int ObjectSize => 48;
	}


	/// <summary>
	/// USlateWidgetStyleAsset:UObject
	/// Size: 0x30
	/// Properties: 1
	/// </summary>
	public class USlateWidgetStyleAsset:UObject
	{
		public override int ObjectSize => 48;
		/// <summary>
		/// Name: CustomStyle
		/// Type: ObjectProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		public USlateWidgetStyleContainerBase CustomStyle => ReadUObject<USlateWidgetStyleContainerBase>(0x28);
		
	}


	/// <summary>
	/// UButtonWidgetStyle:USlateWidgetStyleContainerBase
	/// Size: 0x2D8
	/// Properties: 1
	/// </summary>
	public class UButtonWidgetStyle:USlateWidgetStyleContainerBase
	{
		public override int ObjectSize => 728;
		/// <summary>
		/// Name: ButtonStyle
		/// Type: StructProperty
		/// Offset: 0x30
		/// Size: 0x2A8
		/// </summary>
		public FButtonStyle ButtonStyle => ReadStruct<FButtonStyle>(0x30);
		
	}


	/// <summary>
	/// UCheckBoxWidgetStyle:USlateWidgetStyleContainerBase
	/// Size: 0x610
	/// Properties: 1
	/// </summary>
	public class UCheckBoxWidgetStyle:USlateWidgetStyleContainerBase
	{
		public override int ObjectSize => 1552;
		/// <summary>
		/// Name: CheckBoxStyle
		/// Type: StructProperty
		/// Offset: 0x30
		/// Size: 0x5E0
		/// </summary>
		public FCheckBoxStyle CheckBoxStyle => ReadStruct<FCheckBoxStyle>(0x30);
		
	}


	/// <summary>
	/// UComboBoxWidgetStyle:USlateWidgetStyleContainerBase
	/// Size: 0x480
	/// Properties: 1
	/// </summary>
	public class UComboBoxWidgetStyle:USlateWidgetStyleContainerBase
	{
		public override int ObjectSize => 1152;
		/// <summary>
		/// Name: ComboBoxStyle
		/// Type: StructProperty
		/// Offset: 0x30
		/// Size: 0x450
		/// </summary>
		public FComboBoxStyle ComboBoxStyle => ReadStruct<FComboBoxStyle>(0x30);
		
	}


	/// <summary>
	/// UComboButtonWidgetStyle:USlateWidgetStyleContainerBase
	/// Size: 0x438
	/// Properties: 1
	/// </summary>
	public class UComboButtonWidgetStyle:USlateWidgetStyleContainerBase
	{
		public override int ObjectSize => 1080;
		/// <summary>
		/// Name: ComboButtonStyle
		/// Type: StructProperty
		/// Offset: 0x30
		/// Size: 0x408
		/// </summary>
		public FComboButtonStyle ComboButtonStyle => ReadStruct<FComboButtonStyle>(0x30);
		
	}


	/// <summary>
	/// UEditableTextBoxWidgetStyle:USlateWidgetStyleContainerBase
	/// Size: 0x878
	/// Properties: 1
	/// </summary>
	public class UEditableTextBoxWidgetStyle:USlateWidgetStyleContainerBase
	{
		public override int ObjectSize => 2168;
		/// <summary>
		/// Name: EditableTextBoxStyle
		/// Type: StructProperty
		/// Offset: 0x30
		/// Size: 0x848
		/// </summary>
		public FEditableTextBoxStyle EditableTextBoxStyle => ReadStruct<FEditableTextBoxStyle>(0x30);
		
	}


	/// <summary>
	/// UEditableTextWidgetStyle:USlateWidgetStyleContainerBase
	/// Size: 0x250
	/// Properties: 1
	/// </summary>
	public class UEditableTextWidgetStyle:USlateWidgetStyleContainerBase
	{
		public override int ObjectSize => 592;
		/// <summary>
		/// Name: EditableTextStyle
		/// Type: StructProperty
		/// Offset: 0x30
		/// Size: 0x220
		/// </summary>
		public FEditableTextStyle EditableTextStyle => ReadStruct<FEditableTextStyle>(0x30);
		
	}


	/// <summary>
	/// UProgressWidgetStyle:USlateWidgetStyleContainerBase
	/// Size: 0x1E8
	/// Properties: 1
	/// </summary>
	public class UProgressWidgetStyle:USlateWidgetStyleContainerBase
	{
		public override int ObjectSize => 488;
		/// <summary>
		/// Name: ProgressBarStyle
		/// Type: StructProperty
		/// Offset: 0x30
		/// Size: 0x1B8
		/// </summary>
		public FProgressBarStyle ProgressBarStyle => ReadStruct<FProgressBarStyle>(0x30);
		
	}


	/// <summary>
	/// UScrollBarWidgetStyle:USlateWidgetStyleContainerBase
	/// Size: 0x548
	/// Properties: 1
	/// </summary>
	public class UScrollBarWidgetStyle:USlateWidgetStyleContainerBase
	{
		public override int ObjectSize => 1352;
		/// <summary>
		/// Name: ScrollBarStyle
		/// Type: StructProperty
		/// Offset: 0x30
		/// Size: 0x518
		/// </summary>
		public FScrollBarStyle ScrollBarStyle => ReadStruct<FScrollBarStyle>(0x30);
		
	}


	/// <summary>
	/// UScrollBoxWidgetStyle:USlateWidgetStyleContainerBase
	/// Size: 0x278
	/// Properties: 1
	/// </summary>
	public class UScrollBoxWidgetStyle:USlateWidgetStyleContainerBase
	{
		public override int ObjectSize => 632;
		/// <summary>
		/// Name: ScrollBoxStyle
		/// Type: StructProperty
		/// Offset: 0x30
		/// Size: 0x248
		/// </summary>
		public FScrollBoxStyle ScrollBoxStyle => ReadStruct<FScrollBoxStyle>(0x30);
		
	}


	/// <summary>
	/// USpinBoxWidgetStyle:USlateWidgetStyleContainerBase
	/// Size: 0x340
	/// Properties: 1
	/// </summary>
	public class USpinBoxWidgetStyle:USlateWidgetStyleContainerBase
	{
		public override int ObjectSize => 832;
		/// <summary>
		/// Name: SpinBoxStyle
		/// Type: StructProperty
		/// Offset: 0x30
		/// Size: 0x310
		/// </summary>
		public FSpinBoxStyle SpinBoxStyle => ReadStruct<FSpinBoxStyle>(0x30);
		
	}


	/// <summary>
	/// UTextBlockWidgetStyle:USlateWidgetStyleContainerBase
	/// Size: 0x180
	/// Properties: 1
	/// </summary>
	public class UTextBlockWidgetStyle:USlateWidgetStyleContainerBase
	{
		public override int ObjectSize => 384;
		/// <summary>
		/// Name: TextBlockStyle
		/// Type: StructProperty
		/// Offset: 0x30
		/// Size: 0x150
		/// </summary>
		public FTextBlockStyle TextBlockStyle => ReadStruct<FTextBlockStyle>(0x30);
		
	}


	/// <summary>
	/// UShaderPlatformQualitySettings:UObject
	/// Size: 0x38
	/// Properties: 1
	/// </summary>
	public class UShaderPlatformQualitySettings:UObject
	{
		public override int ObjectSize => 56;
		/// <summary>
		/// Name: QualityOverrides
		/// Type: StructProperty
		/// Offset: 0x28
		/// Size: 0x05
		/// </summary>
		public FMaterialQualityOverrides QualityOverrides => ReadStruct<FMaterialQualityOverrides>(0x28);
		
	}


	/// <summary>
	/// UMaterialShaderQualitySettings:UObject
	/// Size: 0x80
	/// Properties: 1
	/// </summary>
	public class UMaterialShaderQualitySettings:UObject
	{
		public override int ObjectSize => 128;
		/// <summary>
		/// Name: ForwardSettingMap
		/// Type: MapProperty
		/// Offset: 0x28
		/// Size: 0x50
		/// </summary>
		
	}


	/// <summary>
	/// UMotionControllerComponent:UPrimitiveComponent
	/// Size: 0x5C0
	/// Properties: 4
	/// </summary>
	public class UMotionControllerComponent:UPrimitiveComponent
	{
		public override int ObjectSize => 1472;
		/// <summary>
		/// Name: PlayerIndex
		/// Type: IntProperty
		/// Offset: 0x5A0
		/// Size: 0x04
		/// </summary>
		public int PlayerIndex
		{
			get
			{
				return ReadInt32(0x5A0);
			}
			set
			{
				WriteInt32(0x5A0,value);
			}
		}
		
		/// <summary>
		/// Name: Hand
		/// Type: ByteProperty
		/// Offset: 0x5A4
		/// Size: 0x01
		/// </summary>
		public byte Hand
		{
			get
			{
				return ReadByte(0x5A4);
			}
			set
			{
				WriteByte(0x5A4,value);
			}
		}
		
		/// <summary>
		/// Name: bDisableLowLatencyUpdate
		/// Type: BoolProperty
		/// Offset: 0x5A8
		/// Size: 0x01
		/// </summary>
		public bool bDisableLowLatencyUpdate => (ReadByte(0x05A8) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: CurrentTrackingStatus
		/// Type: ByteProperty
		/// Offset: 0x5AC
		/// Size: 0x01
		/// </summary>
		public byte CurrentTrackingStatus
		{
			get
			{
				return ReadByte(0x5AC);
			}
			set
			{
				WriteByte(0x5AC,value);
			}
		}
		
	}


	/// <summary>
	/// UVRNotificationsComponent:UActorComponent
	/// Size: 0x108
	/// Properties: 0
	/// </summary>
	public class UVRNotificationsComponent:UActorComponent
	{
		public override int ObjectSize => 264;
	}


	/// <summary>
	/// UFoliageStatistics:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UFoliageStatistics:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UFoliageType:UObject
	/// Size: 0x3E0
	/// Properties: 74
	/// </summary>
	public class UFoliageType:UObject
	{
		public override int ObjectSize => 992;
		/// <summary>
		/// Name: UpdateGuid
		/// Type: StructProperty
		/// Offset: 0x28
		/// Size: 0x10
		/// </summary>
		public FGuid UpdateGuid => ReadStruct<FGuid>(0x28);
		
		/// <summary>
		/// Name: Density
		/// Type: FloatProperty
		/// Offset: 0x58
		/// Size: 0x04
		/// </summary>
		public float Density
		{
			get
			{
				return ReadSingle(0x58);
			}
			set
			{
				WriteSingle(0x58,value);
			}
		}
		
		/// <summary>
		/// Name: DensityAdjustmentFactor
		/// Type: FloatProperty
		/// Offset: 0x5C
		/// Size: 0x04
		/// </summary>
		public float DensityAdjustmentFactor
		{
			get
			{
				return ReadSingle(0x5C);
			}
			set
			{
				WriteSingle(0x5C,value);
			}
		}
		
		/// <summary>
		/// Name: Radius
		/// Type: FloatProperty
		/// Offset: 0x60
		/// Size: 0x04
		/// </summary>
		public float Radius
		{
			get
			{
				return ReadSingle(0x60);
			}
			set
			{
				WriteSingle(0x60,value);
			}
		}
		
		/// <summary>
		/// Name: Scaling
		/// Type: ByteProperty
		/// Offset: 0x64
		/// Size: 0x01
		/// </summary>
		public byte Scaling
		{
			get
			{
				return ReadByte(0x64);
			}
			set
			{
				WriteByte(0x64,value);
			}
		}
		
		/// <summary>
		/// Name: ScaleX
		/// Type: StructProperty
		/// Offset: 0x68
		/// Size: 0x08
		/// </summary>
		public FFloatInterval ScaleX => ReadStruct<FFloatInterval>(0x68);
		
		/// <summary>
		/// Name: ScaleY
		/// Type: StructProperty
		/// Offset: 0x70
		/// Size: 0x08
		/// </summary>
		public FFloatInterval ScaleY => ReadStruct<FFloatInterval>(0x70);
		
		/// <summary>
		/// Name: ScaleZ
		/// Type: StructProperty
		/// Offset: 0x78
		/// Size: 0x08
		/// </summary>
		public FFloatInterval ScaleZ => ReadStruct<FFloatInterval>(0x78);
		
		/// <summary>
		/// Name: VertexColorMaskByChannel
		/// Type: StructProperty
		/// Offset: 0x80
		/// Size: 0x0C
		/// </summary>
		public FFoliageVertexColorChannelMask VertexColorMaskByChannel => ReadStruct<FFoliageVertexColorChannelMask>(0x80);
		
		/// <summary>
		/// Name: VertexColorMask
		/// Type: ByteProperty
		/// Offset: 0xB0
		/// Size: 0x01
		/// </summary>
		public byte VertexColorMask
		{
			get
			{
				return ReadByte(0xB0);
			}
			set
			{
				WriteByte(0xB0,value);
			}
		}
		
		/// <summary>
		/// Name: VertexColorMaskThreshold
		/// Type: FloatProperty
		/// Offset: 0xB4
		/// Size: 0x04
		/// </summary>
		public float VertexColorMaskThreshold
		{
			get
			{
				return ReadSingle(0xB4);
			}
			set
			{
				WriteSingle(0xB4,value);
			}
		}
		
		/// <summary>
		/// Name: VertexColorMaskInvert
		/// Type: BoolProperty
		/// Offset: 0xB8
		/// Size: 0x01
		/// </summary>
		public bool VertexColorMaskInvert => (ReadByte(0x00B8) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: ZOffset
		/// Type: StructProperty
		/// Offset: 0xBC
		/// Size: 0x08
		/// </summary>
		public FFloatInterval ZOffset => ReadStruct<FFloatInterval>(0xBC);
		
		/// <summary>
		/// Name: AlignToNormal
		/// Type: BoolProperty
		/// Offset: 0xC4
		/// Size: 0x01
		/// </summary>
		public bool AlignToNormal => (ReadByte(0x00C4) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: AlignMaxAngle
		/// Type: FloatProperty
		/// Offset: 0xC8
		/// Size: 0x04
		/// </summary>
		public float AlignMaxAngle
		{
			get
			{
				return ReadSingle(0xC8);
			}
			set
			{
				WriteSingle(0xC8,value);
			}
		}
		
		/// <summary>
		/// Name: RandomYaw
		/// Type: BoolProperty
		/// Offset: 0xCC
		/// Size: 0x01
		/// </summary>
		public bool RandomYaw => (ReadByte(0x00CC) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: RandomPitchAngle
		/// Type: FloatProperty
		/// Offset: 0xD0
		/// Size: 0x04
		/// </summary>
		public float RandomPitchAngle
		{
			get
			{
				return ReadSingle(0xD0);
			}
			set
			{
				WriteSingle(0xD0,value);
			}
		}
		
		/// <summary>
		/// Name: GroundSlopeAngle
		/// Type: StructProperty
		/// Offset: 0xD4
		/// Size: 0x08
		/// </summary>
		public FFloatInterval GroundSlopeAngle => ReadStruct<FFloatInterval>(0xD4);
		
		/// <summary>
		/// Name: Height
		/// Type: StructProperty
		/// Offset: 0xDC
		/// Size: 0x08
		/// </summary>
		public FFloatInterval Height => ReadStruct<FFloatInterval>(0xDC);
		
		/// <summary>
		/// Name: LandscapeLayers
		/// Type: TArray<FName>
		/// Offset: 0xE8
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		public TArray<FName> LandscapeLayers => new TArray<FName>(BaseAddress+0xE8);
		
		/// <summary>
		/// Name: LandscapeLayer
		/// Type: NameProperty
		/// Offset: 0xF8
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: CollisionWithWorld
		/// Type: BoolProperty
		/// Offset: 0x100
		/// Size: 0x01
		/// </summary>
		public bool CollisionWithWorld => (ReadByte(0x0100) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: CollisionScale
		/// Type: StructProperty
		/// Offset: 0x104
		/// Size: 0x0C
		/// </summary>
		public FVector CollisionScale => ReadStruct<FVector>(0x104);
		
		/// <summary>
		/// Name: MinimumLayerWeight
		/// Type: FloatProperty
		/// Offset: 0x110
		/// Size: 0x04
		/// </summary>
		public float MinimumLayerWeight
		{
			get
			{
				return ReadSingle(0x110);
			}
			set
			{
				WriteSingle(0x110,value);
			}
		}
		
		/// <summary>
		/// Name: MeshBounds
		/// Type: StructProperty
		/// Offset: 0x114
		/// Size: 0x1C
		/// </summary>
		public FBoxSphereBounds MeshBounds => ReadStruct<FBoxSphereBounds>(0x114);
		
		/// <summary>
		/// Name: LowBoundOriginRadius
		/// Type: StructProperty
		/// Offset: 0x130
		/// Size: 0x0C
		/// </summary>
		public FVector LowBoundOriginRadius => ReadStruct<FVector>(0x130);
		
		/// <summary>
		/// Name: Mobility
		/// Type: ByteProperty
		/// Offset: 0x13C
		/// Size: 0x01
		/// </summary>
		public byte Mobility
		{
			get
			{
				return ReadByte(0x13C);
			}
			set
			{
				WriteByte(0x13C,value);
			}
		}
		
		/// <summary>
		/// Name: CullDistance
		/// Type: StructProperty
		/// Offset: 0x140
		/// Size: 0x08
		/// </summary>
		public FInt32Interval CullDistance => ReadStruct<FInt32Interval>(0x140);
		
		/// <summary>
		/// Name: bEnableStaticLighting
		/// Type: BoolProperty
		/// Offset: 0x148
		/// Size: 0x01
		/// </summary>
		public bool bEnableStaticLighting => (ReadByte(0x0148) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: CastShadow
		/// Type: BoolProperty
		/// Offset: 0x148
		/// Size: 0x01
		/// </summary>
		public bool CastShadow => (ReadByte(0x0148) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bAffectDynamicIndirectLighting
		/// Type: BoolProperty
		/// Offset: 0x148
		/// Size: 0x01
		/// </summary>
		public bool bAffectDynamicIndirectLighting => (ReadByte(0x0148) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bAffectDistanceFieldLighting
		/// Type: BoolProperty
		/// Offset: 0x148
		/// Size: 0x01
		/// </summary>
		public bool bAffectDistanceFieldLighting => (ReadByte(0x0148) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bCastDynamicShadow
		/// Type: BoolProperty
		/// Offset: 0x148
		/// Size: 0x01
		/// </summary>
		public bool bCastDynamicShadow => (ReadByte(0x0148) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bCastStaticShadow
		/// Type: BoolProperty
		/// Offset: 0x148
		/// Size: 0x01
		/// </summary>
		public bool bCastStaticShadow => (ReadByte(0x0148) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: bCastShadowAsTwoSided
		/// Type: BoolProperty
		/// Offset: 0x148
		/// Size: 0x01
		/// </summary>
		public bool bCastShadowAsTwoSided => (ReadByte(0x0148) & 0x40) == 0x40;
		
		/// <summary>
		/// Name: bReceivesDecals
		/// Type: BoolProperty
		/// Offset: 0x148
		/// Size: 0x01
		/// </summary>
		public bool bReceivesDecals => (ReadByte(0x0148) & 0x80) == 0x80;
		
		/// <summary>
		/// Name: bOverrideLightMapRes
		/// Type: BoolProperty
		/// Offset: 0x149
		/// Size: 0x01
		/// </summary>
		public bool bOverrideLightMapRes => (ReadByte(0x0149) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: OverriddenLightMapRes
		/// Type: IntProperty
		/// Offset: 0x14C
		/// Size: 0x04
		/// </summary>
		public int OverriddenLightMapRes
		{
			get
			{
				return ReadInt32(0x14C);
			}
			set
			{
				WriteInt32(0x14C,value);
			}
		}
		
		/// <summary>
		/// Name: bUseAsOccluder
		/// Type: BoolProperty
		/// Offset: 0x150
		/// Size: 0x01
		/// </summary>
		public bool bUseAsOccluder => (ReadByte(0x0150) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: BodyInstance
		/// Type: StructProperty
		/// Offset: 0x160
		/// Size: 0x1B0
		/// </summary>
		public FBodyInstance BodyInstance => ReadStruct<FBodyInstance>(0x160);
		
		/// <summary>
		/// Name: CustomNavigableGeometry
		/// Type: ByteProperty
		/// Offset: 0x310
		/// Size: 0x01
		/// </summary>
		public byte CustomNavigableGeometry
		{
			get
			{
				return ReadByte(0x310);
			}
			set
			{
				WriteByte(0x310,value);
			}
		}
		
		/// <summary>
		/// Name: CollisionRadius
		/// Type: FloatProperty
		/// Offset: 0x314
		/// Size: 0x04
		/// </summary>
		public float CollisionRadius
		{
			get
			{
				return ReadSingle(0x314);
			}
			set
			{
				WriteSingle(0x314,value);
			}
		}
		
		/// <summary>
		/// Name: ShadeRadius
		/// Type: FloatProperty
		/// Offset: 0x318
		/// Size: 0x04
		/// </summary>
		public float ShadeRadius
		{
			get
			{
				return ReadSingle(0x318);
			}
			set
			{
				WriteSingle(0x318,value);
			}
		}
		
		/// <summary>
		/// Name: NumSteps
		/// Type: IntProperty
		/// Offset: 0x31C
		/// Size: 0x04
		/// </summary>
		public int NumSteps
		{
			get
			{
				return ReadInt32(0x31C);
			}
			set
			{
				WriteInt32(0x31C,value);
			}
		}
		
		/// <summary>
		/// Name: InitialSeedDensity
		/// Type: FloatProperty
		/// Offset: 0x320
		/// Size: 0x04
		/// </summary>
		public float InitialSeedDensity
		{
			get
			{
				return ReadSingle(0x320);
			}
			set
			{
				WriteSingle(0x320,value);
			}
		}
		
		/// <summary>
		/// Name: AverageSpreadDistance
		/// Type: FloatProperty
		/// Offset: 0x324
		/// Size: 0x04
		/// </summary>
		public float AverageSpreadDistance
		{
			get
			{
				return ReadSingle(0x324);
			}
			set
			{
				WriteSingle(0x324,value);
			}
		}
		
		/// <summary>
		/// Name: SpreadVariance
		/// Type: FloatProperty
		/// Offset: 0x328
		/// Size: 0x04
		/// </summary>
		public float SpreadVariance
		{
			get
			{
				return ReadSingle(0x328);
			}
			set
			{
				WriteSingle(0x328,value);
			}
		}
		
		/// <summary>
		/// Name: SeedsPerStep
		/// Type: IntProperty
		/// Offset: 0x32C
		/// Size: 0x04
		/// </summary>
		public int SeedsPerStep
		{
			get
			{
				return ReadInt32(0x32C);
			}
			set
			{
				WriteInt32(0x32C,value);
			}
		}
		
		/// <summary>
		/// Name: DistributionSeed
		/// Type: IntProperty
		/// Offset: 0x330
		/// Size: 0x04
		/// </summary>
		public int DistributionSeed
		{
			get
			{
				return ReadInt32(0x330);
			}
			set
			{
				WriteInt32(0x330,value);
			}
		}
		
		/// <summary>
		/// Name: MaxInitialSeedOffset
		/// Type: FloatProperty
		/// Offset: 0x334
		/// Size: 0x04
		/// </summary>
		public float MaxInitialSeedOffset
		{
			get
			{
				return ReadSingle(0x334);
			}
			set
			{
				WriteSingle(0x334,value);
			}
		}
		
		/// <summary>
		/// Name: bCanGrowInShade
		/// Type: BoolProperty
		/// Offset: 0x338
		/// Size: 0x01
		/// </summary>
		public bool bCanGrowInShade
		{
			get
			{
				return ReadBool(0x338);
			}
			set
			{
				WriteBool(0x338,value);
			}
		}
		
		/// <summary>
		/// Name: bSpawnsInShade
		/// Type: BoolProperty
		/// Offset: 0x339
		/// Size: 0x01
		/// </summary>
		public bool bSpawnsInShade
		{
			get
			{
				return ReadBool(0x339);
			}
			set
			{
				WriteBool(0x339,value);
			}
		}
		
		/// <summary>
		/// Name: MaxInitialAge
		/// Type: FloatProperty
		/// Offset: 0x33C
		/// Size: 0x04
		/// </summary>
		public float MaxInitialAge
		{
			get
			{
				return ReadSingle(0x33C);
			}
			set
			{
				WriteSingle(0x33C,value);
			}
		}
		
		/// <summary>
		/// Name: MaxAge
		/// Type: FloatProperty
		/// Offset: 0x340
		/// Size: 0x04
		/// </summary>
		public float MaxAge
		{
			get
			{
				return ReadSingle(0x340);
			}
			set
			{
				WriteSingle(0x340,value);
			}
		}
		
		/// <summary>
		/// Name: OverlapPriority
		/// Type: FloatProperty
		/// Offset: 0x344
		/// Size: 0x04
		/// </summary>
		public float OverlapPriority
		{
			get
			{
				return ReadSingle(0x344);
			}
			set
			{
				WriteSingle(0x344,value);
			}
		}
		
		/// <summary>
		/// Name: ProceduralScale
		/// Type: StructProperty
		/// Offset: 0x348
		/// Size: 0x08
		/// </summary>
		public FFloatInterval ProceduralScale => ReadStruct<FFloatInterval>(0x348);
		
		/// <summary>
		/// Name: ScaleCurve
		/// Type: StructProperty
		/// Offset: 0x350
		/// Size: 0x80
		/// </summary>
		public FRuntimeFloatCurve ScaleCurve => ReadStruct<FRuntimeFloatCurve>(0x350);
		
		/// <summary>
		/// Name: ChangeCount
		/// Type: IntProperty
		/// Offset: 0x3D0
		/// Size: 0x04
		/// </summary>
		public int ChangeCount
		{
			get
			{
				return ReadInt32(0x3D0);
			}
			set
			{
				WriteInt32(0x3D0,value);
			}
		}
		
		/// <summary>
		/// Name: ReapplyDensity
		/// Type: BoolProperty
		/// Offset: 0x3D4
		/// Size: 0x01
		/// </summary>
		public bool ReapplyDensity => (ReadByte(0x03D4) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: ReapplyRadius
		/// Type: BoolProperty
		/// Offset: 0x3D4
		/// Size: 0x01
		/// </summary>
		public bool ReapplyRadius => (ReadByte(0x03D4) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: ReapplyAlignToNormal
		/// Type: BoolProperty
		/// Offset: 0x3D4
		/// Size: 0x01
		/// </summary>
		public bool ReapplyAlignToNormal => (ReadByte(0x03D4) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: ReapplyRandomYaw
		/// Type: BoolProperty
		/// Offset: 0x3D4
		/// Size: 0x01
		/// </summary>
		public bool ReapplyRandomYaw => (ReadByte(0x03D4) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: ReapplyScaling
		/// Type: BoolProperty
		/// Offset: 0x3D4
		/// Size: 0x01
		/// </summary>
		public bool ReapplyScaling => (ReadByte(0x03D4) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: ReapplyScaleX
		/// Type: BoolProperty
		/// Offset: 0x3D4
		/// Size: 0x01
		/// </summary>
		public bool ReapplyScaleX => (ReadByte(0x03D4) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: ReapplyScaleY
		/// Type: BoolProperty
		/// Offset: 0x3D4
		/// Size: 0x01
		/// </summary>
		public bool ReapplyScaleY => (ReadByte(0x03D4) & 0x40) == 0x40;
		
		/// <summary>
		/// Name: ReapplyScaleZ
		/// Type: BoolProperty
		/// Offset: 0x3D4
		/// Size: 0x01
		/// </summary>
		public bool ReapplyScaleZ => (ReadByte(0x03D4) & 0x80) == 0x80;
		
		/// <summary>
		/// Name: ReapplyRandomPitchAngle
		/// Type: BoolProperty
		/// Offset: 0x3D5
		/// Size: 0x01
		/// </summary>
		public bool ReapplyRandomPitchAngle => (ReadByte(0x03D5) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: ReapplyGroundSlope
		/// Type: BoolProperty
		/// Offset: 0x3D5
		/// Size: 0x01
		/// </summary>
		public bool ReapplyGroundSlope => (ReadByte(0x03D5) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: ReapplyHeight
		/// Type: BoolProperty
		/// Offset: 0x3D5
		/// Size: 0x01
		/// </summary>
		public bool ReapplyHeight => (ReadByte(0x03D5) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: ReapplyLandscapeLayers
		/// Type: BoolProperty
		/// Offset: 0x3D5
		/// Size: 0x01
		/// </summary>
		public bool ReapplyLandscapeLayers => (ReadByte(0x03D5) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: ReapplyZOffset
		/// Type: BoolProperty
		/// Offset: 0x3D5
		/// Size: 0x01
		/// </summary>
		public bool ReapplyZOffset => (ReadByte(0x03D5) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: ReapplyCollisionWithWorld
		/// Type: BoolProperty
		/// Offset: 0x3D5
		/// Size: 0x01
		/// </summary>
		public bool ReapplyCollisionWithWorld => (ReadByte(0x03D5) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: ReapplyVertexColorMask
		/// Type: BoolProperty
		/// Offset: 0x3D5
		/// Size: 0x01
		/// </summary>
		public bool ReapplyVertexColorMask => (ReadByte(0x03D5) & 0x40) == 0x40;
		
		/// <summary>
		/// Name: bEnableDensityScaling
		/// Type: BoolProperty
		/// Offset: 0x3D5
		/// Size: 0x01
		/// </summary>
		public bool bEnableDensityScaling => (ReadByte(0x03D5) & 0x80) == 0x80;
		
	}


	/// <summary>
	/// UFoliageType_InstancedStaticMesh:UFoliageType
	/// Size: 0x400
	/// Properties: 3
	/// </summary>
	public class UFoliageType_InstancedStaticMesh:UFoliageType
	{
		public override int ObjectSize => 1024;
		/// <summary>
		/// Name: Mesh
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UStaticMesh Mesh => ReadUObject<UStaticMesh>(0x3D8);
		
		/// <summary>
		/// Name: OverrideMaterials
		/// Type: TArray<UMaterialInterface>
		/// Offset: 0x3E0
		/// Size: 0x10
		/// SubElement Size: 0x58
		/// </summary>
		public TArray<UMaterialInterface> OverrideMaterials => new TArray<UMaterialInterface>(BaseAddress+0x3E0);
		
		/// <summary>
		/// Name: ComponentClass
		/// Type: ClassProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// AInstancedFoliageActor:AActor
	/// Size: 0x420
	/// Properties: 0
	/// </summary>
	public class AInstancedFoliageActor:AActor
	{
		public override int ObjectSize => 1056;
	}


	/// <summary>
	/// AInteractiveFoliageActor:AStaticMeshActor
	/// Size: 0x440
	/// Properties: 14
	/// </summary>
	public class AInteractiveFoliageActor:AStaticMeshActor
	{
		public override int ObjectSize => 1088;
		/// <summary>
		/// Name: CapsuleComponent
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent CapsuleComponent => ReadUObject<UCapsuleComponent>(0x3E0);
		
		/// <summary>
		/// Name: TouchingActorEntryPosition
		/// Type: StructProperty
		/// Offset: 0x3E8
		/// Size: 0x0C
		/// </summary>
		public FVector TouchingActorEntryPosition => ReadStruct<FVector>(0x3E8);
		
		/// <summary>
		/// Name: FoliageVelocity
		/// Type: StructProperty
		/// Offset: 0x3F4
		/// Size: 0x0C
		/// </summary>
		public FVector FoliageVelocity => ReadStruct<FVector>(0x3F4);
		
		/// <summary>
		/// Name: FoliageForce
		/// Type: StructProperty
		/// Offset: 0x400
		/// Size: 0x0C
		/// </summary>
		public FVector FoliageForce => ReadStruct<FVector>(0x400);
		
		/// <summary>
		/// Name: FoliagePosition
		/// Type: StructProperty
		/// Offset: 0x40C
		/// Size: 0x0C
		/// </summary>
		public FVector FoliagePosition => ReadStruct<FVector>(0x40C);
		
		/// <summary>
		/// Name: FoliageDamageImpulseScale
		/// Type: FloatProperty
		/// Offset: 0x418
		/// Size: 0x04
		/// </summary>
		public float FoliageDamageImpulseScale
		{
			get
			{
				return ReadSingle(0x418);
			}
			set
			{
				WriteSingle(0x418,value);
			}
		}
		
		/// <summary>
		/// Name: FoliageTouchImpulseScale
		/// Type: FloatProperty
		/// Offset: 0x41C
		/// Size: 0x04
		/// </summary>
		public float FoliageTouchImpulseScale
		{
			get
			{
				return ReadSingle(0x41C);
			}
			set
			{
				WriteSingle(0x41C,value);
			}
		}
		
		/// <summary>
		/// Name: FoliageStiffness
		/// Type: FloatProperty
		/// Offset: 0x420
		/// Size: 0x04
		/// </summary>
		public float FoliageStiffness
		{
			get
			{
				return ReadSingle(0x420);
			}
			set
			{
				WriteSingle(0x420,value);
			}
		}
		
		/// <summary>
		/// Name: FoliageStiffnessQuadratic
		/// Type: FloatProperty
		/// Offset: 0x424
		/// Size: 0x04
		/// </summary>
		public float FoliageStiffnessQuadratic
		{
			get
			{
				return ReadSingle(0x424);
			}
			set
			{
				WriteSingle(0x424,value);
			}
		}
		
		/// <summary>
		/// Name: FoliageDamping
		/// Type: FloatProperty
		/// Offset: 0x428
		/// Size: 0x04
		/// </summary>
		public float FoliageDamping
		{
			get
			{
				return ReadSingle(0x428);
			}
			set
			{
				WriteSingle(0x428,value);
			}
		}
		
		/// <summary>
		/// Name: MaxDamageImpulse
		/// Type: FloatProperty
		/// Offset: 0x42C
		/// Size: 0x04
		/// </summary>
		public float MaxDamageImpulse
		{
			get
			{
				return ReadSingle(0x42C);
			}
			set
			{
				WriteSingle(0x42C,value);
			}
		}
		
		/// <summary>
		/// Name: MaxTouchImpulse
		/// Type: FloatProperty
		/// Offset: 0x430
		/// Size: 0x04
		/// </summary>
		public float MaxTouchImpulse
		{
			get
			{
				return ReadSingle(0x430);
			}
			set
			{
				WriteSingle(0x430,value);
			}
		}
		
		/// <summary>
		/// Name: MaxForce
		/// Type: FloatProperty
		/// Offset: 0x434
		/// Size: 0x04
		/// </summary>
		public float MaxForce
		{
			get
			{
				return ReadSingle(0x434);
			}
			set
			{
				WriteSingle(0x434,value);
			}
		}
		
		/// <summary>
		/// Name: Mass
		/// Type: FloatProperty
		/// Offset: 0x438
		/// Size: 0x04
		/// </summary>
		public float Mass
		{
			get
			{
				return ReadSingle(0x438);
			}
			set
			{
				WriteSingle(0x438,value);
			}
		}
		
	}


	/// <summary>
	/// UInteractiveFoliageComponent:UStaticMeshComponent
	/// Size: 0x6F0
	/// Properties: 0
	/// </summary>
	public class UInteractiveFoliageComponent:UStaticMeshComponent
	{
		public override int ObjectSize => 1776;
	}


	/// <summary>
	/// ABrush:AActor
	/// Size: 0x408
	/// Properties: 11
	/// </summary>
	public class ABrush:AActor
	{
		public override int ObjectSize => 1032;
		/// <summary>
		/// Name: BrushType
		/// Type: ByteProperty
		/// Offset: 0x3D0
		/// Size: 0x01
		/// </summary>
		public byte BrushType
		{
			get
			{
				return ReadByte(0x3D0);
			}
			set
			{
				WriteByte(0x3D0,value);
			}
		}
		
		/// <summary>
		/// Name: BrushColor
		/// Type: StructProperty
		/// Offset: 0x3D4
		/// Size: 0x04
		/// </summary>
		public FColor BrushColor => ReadStruct<FColor>(0x3D4);
		
		/// <summary>
		/// Name: PolyFlags
		/// Type: IntProperty
		/// Offset: 0x3D8
		/// Size: 0x04
		/// </summary>
		public int PolyFlags
		{
			get
			{
				return ReadInt32(0x3D8);
			}
			set
			{
				WriteInt32(0x3D8,value);
			}
		}
		
		/// <summary>
		/// Name: bColored
		/// Type: BoolProperty
		/// Offset: 0x3DC
		/// Size: 0x01
		/// </summary>
		public bool bColored => (ReadByte(0x03DC) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bSolidWhenSelected
		/// Type: BoolProperty
		/// Offset: 0x3DC
		/// Size: 0x01
		/// </summary>
		public bool bSolidWhenSelected => (ReadByte(0x03DC) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bPlaceableFromClassBrowser
		/// Type: BoolProperty
		/// Offset: 0x3DC
		/// Size: 0x01
		/// </summary>
		public bool bPlaceableFromClassBrowser => (ReadByte(0x03DC) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bNotForClientOrServer
		/// Type: BoolProperty
		/// Offset: 0x3DC
		/// Size: 0x01
		/// </summary>
		public bool bNotForClientOrServer => (ReadByte(0x03DC) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: Brush
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UModel Brush => ReadUObject<UModel>(0x3E0);
		
		/// <summary>
		/// Name: BrushComponent
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UBrushComponent BrushComponent => ReadUObject<UBrushComponent>(0x3E8);
		
		/// <summary>
		/// Name: bInManipulation
		/// Type: BoolProperty
		/// Offset: 0x3F0
		/// Size: 0x01
		/// </summary>
		public bool bInManipulation => (ReadByte(0x03F0) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: SavedSelections
		/// Type: TArray<FGeomSelection>
		/// Offset: 0x3F8
		/// Size: 0x10
		/// SubElement Size: 0x0C
		/// </summary>
		public TArray<FGeomSelection> SavedSelections => new TArray<FGeomSelection>(BaseAddress+0x3F8);
		
	}


	/// <summary>
	/// AVolume:ABrush
	/// Size: 0x408
	/// Properties: 0
	/// </summary>
	public class AVolume:ABrush
	{
		public override int ObjectSize => 1032;
	}


	/// <summary>
	/// AProceduralFoliageBlockingVolume:AVolume
	/// Size: 0x410
	/// Properties: 1
	/// </summary>
	public class AProceduralFoliageBlockingVolume:AVolume
	{
		public override int ObjectSize => 1040;
		/// <summary>
		/// Name: ProceduralFoliageVolume
		/// Type: ObjectProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public AProceduralFoliageVolume ProceduralFoliageVolume => ReadUObject<AProceduralFoliageVolume>(0x408);
		
	}


	/// <summary>
	/// UProceduralFoliageComponent:UActorComponent
	/// Size: 0x100
	/// Properties: 4
	/// </summary>
	public class UProceduralFoliageComponent:UActorComponent
	{
		public override int ObjectSize => 256;
		/// <summary>
		/// Name: FoliageSpawner
		/// Type: ObjectProperty
		/// Offset: 0xD8
		/// Size: 0x08
		/// </summary>
		public UProceduralFoliageSpawner FoliageSpawner => ReadUObject<UProceduralFoliageSpawner>(0xD8);
		
		/// <summary>
		/// Name: TileOverlap
		/// Type: FloatProperty
		/// Offset: 0xE0
		/// Size: 0x04
		/// </summary>
		public float TileOverlap
		{
			get
			{
				return ReadSingle(0xE0);
			}
			set
			{
				WriteSingle(0xE0,value);
			}
		}
		
		/// <summary>
		/// Name: SpawningVolume
		/// Type: ObjectProperty
		/// Offset: 0xE8
		/// Size: 0x08
		/// </summary>
		public AVolume SpawningVolume => ReadUObject<AVolume>(0xE8);
		
		/// <summary>
		/// Name: ProceduralGuid
		/// Type: StructProperty
		/// Offset: 0xF0
		/// Size: 0x10
		/// </summary>
		public FGuid ProceduralGuid => ReadStruct<FGuid>(0xF0);
		
	}


	/// <summary>
	/// UProceduralFoliageSpawner:UObject
	/// Size: 0x68
	/// Properties: 5
	/// </summary>
	public class UProceduralFoliageSpawner:UObject
	{
		public override int ObjectSize => 104;
		/// <summary>
		/// Name: RandomSeed
		/// Type: IntProperty
		/// Offset: 0x28
		/// Size: 0x04
		/// </summary>
		public int RandomSeed
		{
			get
			{
				return ReadInt32(0x28);
			}
			set
			{
				WriteInt32(0x28,value);
			}
		}
		
		/// <summary>
		/// Name: TileSize
		/// Type: FloatProperty
		/// Offset: 0x2C
		/// Size: 0x04
		/// </summary>
		public float TileSize
		{
			get
			{
				return ReadSingle(0x2C);
			}
			set
			{
				WriteSingle(0x2C,value);
			}
		}
		
		/// <summary>
		/// Name: NumUniqueTiles
		/// Type: IntProperty
		/// Offset: 0x30
		/// Size: 0x04
		/// </summary>
		public int NumUniqueTiles
		{
			get
			{
				return ReadInt32(0x30);
			}
			set
			{
				WriteInt32(0x30,value);
			}
		}
		
		/// <summary>
		/// Name: FoliageTypes
		/// Type: TArray<FFoliageTypeObject>
		/// Offset: 0x38
		/// Size: 0x10
		/// SubElement Size: 0x20
		/// </summary>
		public TArray<FFoliageTypeObject> FoliageTypes => new TArray<FFoliageTypeObject>(BaseAddress+0x38);
		
		/// <summary>
		/// Name: bNeedsSimulation
		/// Type: BoolProperty
		/// Offset: 0x48
		/// Size: 0x01
		/// </summary>
		public bool bNeedsSimulation
		{
			get
			{
				return ReadBool(0x48);
			}
			set
			{
				WriteBool(0x48,value);
			}
		}
		
	}


	/// <summary>
	/// UProceduralFoliageTile:UObject
	/// Size: 0x150
	/// Properties: 2
	/// </summary>
	public class UProceduralFoliageTile:UObject
	{
		public override int ObjectSize => 336;
		/// <summary>
		/// Name: FoliageSpawner
		/// Type: ObjectProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		public UProceduralFoliageSpawner FoliageSpawner => ReadUObject<UProceduralFoliageSpawner>(0x28);
		
		/// <summary>
		/// Name: InstancesArray
		/// Type: TArray<FProceduralFoliageInstance>
		/// Offset: 0xD0
		/// Size: 0x10
		/// SubElement Size: 0x60
		/// </summary>
		public TArray<FProceduralFoliageInstance> InstancesArray => new TArray<FProceduralFoliageInstance>(BaseAddress+0xD0);
		
	}


	/// <summary>
	/// AProceduralFoliageVolume:AVolume
	/// Size: 0x410
	/// Properties: 1
	/// </summary>
	public class AProceduralFoliageVolume:AVolume
	{
		public override int ObjectSize => 1040;
		/// <summary>
		/// Name: ProceduralComponent
		/// Type: ObjectProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public UProceduralFoliageComponent ProceduralComponent => ReadUObject<UProceduralFoliageComponent>(0x408);
		
	}


	/// <summary>
	/// UControlPointMeshComponent:UStaticMeshComponent
	/// Size: 0x6E0
	/// Properties: 0
	/// </summary>
	public class UControlPointMeshComponent:UStaticMeshComponent
	{
		public override int ObjectSize => 1760;
	}


	/// <summary>
	/// ULandscapeGrassType:UObject
	/// Size: 0x58
	/// Properties: 8
	/// </summary>
	public class ULandscapeGrassType:UObject
	{
		public override int ObjectSize => 88;
		/// <summary>
		/// Name: GrassVarieties
		/// Type: TArray<FGrassVariety>
		/// Offset: 0x28
		/// Size: 0x10
		/// SubElement Size: 0x40
		/// </summary>
		public TArray<FGrassVariety> GrassVarieties => new TArray<FGrassVariety>(BaseAddress+0x28);
		
		/// <summary>
		/// Name: GrassMesh
		/// Type: ObjectProperty
		/// Offset: 0x38
		/// Size: 0x08
		/// </summary>
		public UStaticMesh GrassMesh => ReadUObject<UStaticMesh>(0x38);
		
		/// <summary>
		/// Name: GrassDensity
		/// Type: FloatProperty
		/// Offset: 0x40
		/// Size: 0x04
		/// </summary>
		public float GrassDensity
		{
			get
			{
				return ReadSingle(0x40);
			}
			set
			{
				WriteSingle(0x40,value);
			}
		}
		
		/// <summary>
		/// Name: PlacementJitter
		/// Type: FloatProperty
		/// Offset: 0x44
		/// Size: 0x04
		/// </summary>
		public float PlacementJitter
		{
			get
			{
				return ReadSingle(0x44);
			}
			set
			{
				WriteSingle(0x44,value);
			}
		}
		
		/// <summary>
		/// Name: StartCullDistance
		/// Type: IntProperty
		/// Offset: 0x48
		/// Size: 0x04
		/// </summary>
		public int StartCullDistance
		{
			get
			{
				return ReadInt32(0x48);
			}
			set
			{
				WriteInt32(0x48,value);
			}
		}
		
		/// <summary>
		/// Name: EndCullDistance
		/// Type: IntProperty
		/// Offset: 0x4C
		/// Size: 0x04
		/// </summary>
		public int EndCullDistance
		{
			get
			{
				return ReadInt32(0x4C);
			}
			set
			{
				WriteInt32(0x4C,value);
			}
		}
		
		/// <summary>
		/// Name: RandomRotation
		/// Type: BoolProperty
		/// Offset: 0x50
		/// Size: 0x01
		/// </summary>
		public bool RandomRotation
		{
			get
			{
				return ReadBool(0x50);
			}
			set
			{
				WriteBool(0x50,value);
			}
		}
		
		/// <summary>
		/// Name: AlignToSurface
		/// Type: BoolProperty
		/// Offset: 0x51
		/// Size: 0x01
		/// </summary>
		public bool AlignToSurface
		{
			get
			{
				return ReadBool(0x51);
			}
			set
			{
				WriteBool(0x51,value);
			}
		}
		
	}


	/// <summary>
	/// ULandscapeComponent:UPrimitiveComponent
	/// Size: 0x710
	/// Properties: 31
	/// </summary>
	public class ULandscapeComponent:UPrimitiveComponent
	{
		public override int ObjectSize => 1808;
		/// <summary>
		/// Name: SectionBaseX
		/// Type: IntProperty
		/// Offset: 0x5A0
		/// Size: 0x04
		/// </summary>
		public int SectionBaseX
		{
			get
			{
				return ReadInt32(0x5A0);
			}
			set
			{
				WriteInt32(0x5A0,value);
			}
		}
		
		/// <summary>
		/// Name: SectionBaseY
		/// Type: IntProperty
		/// Offset: 0x5A4
		/// Size: 0x04
		/// </summary>
		public int SectionBaseY
		{
			get
			{
				return ReadInt32(0x5A4);
			}
			set
			{
				WriteInt32(0x5A4,value);
			}
		}
		
		/// <summary>
		/// Name: ComponentSizeQuads
		/// Type: IntProperty
		/// Offset: 0x5A8
		/// Size: 0x04
		/// </summary>
		public int ComponentSizeQuads
		{
			get
			{
				return ReadInt32(0x5A8);
			}
			set
			{
				WriteInt32(0x5A8,value);
			}
		}
		
		/// <summary>
		/// Name: SubsectionSizeQuads
		/// Type: IntProperty
		/// Offset: 0x5AC
		/// Size: 0x04
		/// </summary>
		public int SubsectionSizeQuads
		{
			get
			{
				return ReadInt32(0x5AC);
			}
			set
			{
				WriteInt32(0x5AC,value);
			}
		}
		
		/// <summary>
		/// Name: NumSubsections
		/// Type: IntProperty
		/// Offset: 0x5B0
		/// Size: 0x04
		/// </summary>
		public int NumSubsections
		{
			get
			{
				return ReadInt32(0x5B0);
			}
			set
			{
				WriteInt32(0x5B0,value);
			}
		}
		
		/// <summary>
		/// Name: OverrideMaterial
		/// Type: ObjectProperty
		/// Offset: 0x5B8
		/// Size: 0x08
		/// </summary>
		public UMaterialInterface OverrideMaterial => ReadUObject<UMaterialInterface>(0x5B8);
		
		/// <summary>
		/// Name: OverrideHoleMaterial
		/// Type: ObjectProperty
		/// Offset: 0x5C0
		/// Size: 0x08
		/// </summary>
		public UMaterialInterface OverrideHoleMaterial => ReadUObject<UMaterialInterface>(0x5C0);
		
		/// <summary>
		/// Name: MaterialInstance
		/// Type: ObjectProperty
		/// Offset: 0x5C8
		/// Size: 0x08
		/// </summary>
		public UMaterialInstanceConstant MaterialInstance => ReadUObject<UMaterialInstanceConstant>(0x5C8);
		
		/// <summary>
		/// Name: WeightmapLayerAllocations
		/// Type: TArray<FWeightmapLayerAllocationInfo>
		/// Offset: 0x5D0
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FWeightmapLayerAllocationInfo> WeightmapLayerAllocations => new TArray<FWeightmapLayerAllocationInfo>(BaseAddress+0x5D0);
		
		/// <summary>
		/// Name: WeightmapTextures
		/// Type: TArray<UTexture2D>
		/// Offset: 0x5E0
		/// Size: 0x10
		/// SubElement Size: 0x100
		/// </summary>
		public TArray<UTexture2D> WeightmapTextures => new TArray<UTexture2D>(BaseAddress+0x5E0);
		
		/// <summary>
		/// Name: XYOffsetmapTexture
		/// Type: ObjectProperty
		/// Offset: 0x5F0
		/// Size: 0x08
		/// </summary>
		public UTexture2D XYOffsetmapTexture => ReadUObject<UTexture2D>(0x5F0);
		
		/// <summary>
		/// Name: WeightmapScaleBias
		/// Type: StructProperty
		/// Offset: 0x600
		/// Size: 0x10
		/// </summary>
		public FVector4 WeightmapScaleBias => ReadStruct<FVector4>(0x600);
		
		/// <summary>
		/// Name: WeightmapSubsectionOffset
		/// Type: FloatProperty
		/// Offset: 0x610
		/// Size: 0x04
		/// </summary>
		public float WeightmapSubsectionOffset
		{
			get
			{
				return ReadSingle(0x610);
			}
			set
			{
				WriteSingle(0x610,value);
			}
		}
		
		/// <summary>
		/// Name: HeightmapScaleBias
		/// Type: StructProperty
		/// Offset: 0x620
		/// Size: 0x10
		/// </summary>
		public FVector4 HeightmapScaleBias => ReadStruct<FVector4>(0x620);
		
		/// <summary>
		/// Name: HeightmapTexture
		/// Type: ObjectProperty
		/// Offset: 0x630
		/// Size: 0x08
		/// </summary>
		public UTexture2D HeightmapTexture => ReadUObject<UTexture2D>(0x630);
		
		/// <summary>
		/// Name: CachedLocalBox
		/// Type: StructProperty
		/// Offset: 0x638
		/// Size: 0x1C
		/// </summary>
		public FBox CachedLocalBox => ReadStruct<FBox>(0x638);
		
		/// <summary>
		/// Name: CollisionComponent
		/// Type: LazyObjectProperty
		/// Offset: 0x654
		/// Size: 0x1C
		/// </summary>
		
		/// <summary>
		/// Name: IrrelevantLights
		/// Type: TArray<FGuid>
		/// Offset: 0x670
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FGuid> IrrelevantLights => new TArray<FGuid>(BaseAddress+0x670);
		
		/// <summary>
		/// Name: CollisionMipLevel
		/// Type: IntProperty
		/// Offset: 0x690
		/// Size: 0x04
		/// </summary>
		public int CollisionMipLevel
		{
			get
			{
				return ReadInt32(0x690);
			}
			set
			{
				WriteInt32(0x690,value);
			}
		}
		
		/// <summary>
		/// Name: SimpleCollisionMipLevel
		/// Type: IntProperty
		/// Offset: 0x694
		/// Size: 0x04
		/// </summary>
		public int SimpleCollisionMipLevel
		{
			get
			{
				return ReadInt32(0x694);
			}
			set
			{
				WriteInt32(0x694,value);
			}
		}
		
		/// <summary>
		/// Name: NegativeZBoundsExtension
		/// Type: FloatProperty
		/// Offset: 0x698
		/// Size: 0x04
		/// </summary>
		public float NegativeZBoundsExtension
		{
			get
			{
				return ReadSingle(0x698);
			}
			set
			{
				WriteSingle(0x698,value);
			}
		}
		
		/// <summary>
		/// Name: PositiveZBoundsExtension
		/// Type: FloatProperty
		/// Offset: 0x69C
		/// Size: 0x04
		/// </summary>
		public float PositiveZBoundsExtension
		{
			get
			{
				return ReadSingle(0x69C);
			}
			set
			{
				WriteSingle(0x69C,value);
			}
		}
		
		/// <summary>
		/// Name: StaticLightingResolution
		/// Type: FloatProperty
		/// Offset: 0x6A0
		/// Size: 0x04
		/// </summary>
		public float StaticLightingResolution
		{
			get
			{
				return ReadSingle(0x6A0);
			}
			set
			{
				WriteSingle(0x6A0,value);
			}
		}
		
		/// <summary>
		/// Name: ForcedLOD
		/// Type: IntProperty
		/// Offset: 0x6A4
		/// Size: 0x04
		/// </summary>
		public int ForcedLOD
		{
			get
			{
				return ReadInt32(0x6A4);
			}
			set
			{
				WriteInt32(0x6A4,value);
			}
		}
		
		/// <summary>
		/// Name: LODBias
		/// Type: IntProperty
		/// Offset: 0x6A8
		/// Size: 0x04
		/// </summary>
		public int LODBias
		{
			get
			{
				return ReadInt32(0x6A8);
			}
			set
			{
				WriteInt32(0x6A8,value);
			}
		}
		
		/// <summary>
		/// Name: StateId
		/// Type: StructProperty
		/// Offset: 0x6AC
		/// Size: 0x10
		/// </summary>
		public FGuid StateId => ReadStruct<FGuid>(0x6AC);
		
		/// <summary>
		/// Name: BakedTextureMaterialGuid
		/// Type: StructProperty
		/// Offset: 0x6BC
		/// Size: 0x10
		/// </summary>
		public FGuid BakedTextureMaterialGuid => ReadStruct<FGuid>(0x6BC);
		
		/// <summary>
		/// Name: GIBakedBaseColorTexture
		/// Type: ObjectProperty
		/// Offset: 0x6D0
		/// Size: 0x08
		/// </summary>
		public UTexture2D GIBakedBaseColorTexture => ReadUObject<UTexture2D>(0x6D0);
		
		/// <summary>
		/// Name: MobileBlendableLayerMask
		/// Type: ByteProperty
		/// Offset: 0x6D8
		/// Size: 0x01
		/// </summary>
		public byte MobileBlendableLayerMask
		{
			get
			{
				return ReadByte(0x6D8);
			}
			set
			{
				WriteByte(0x6D8,value);
			}
		}
		
		/// <summary>
		/// Name: MobileMaterialInterface
		/// Type: ObjectProperty
		/// Offset: 0x6E0
		/// Size: 0x08
		/// </summary>
		public UMaterialInterface MobileMaterialInterface => ReadUObject<UMaterialInterface>(0x6E0);
		
		/// <summary>
		/// Name: MobileWeightNormalmapTexture
		/// Type: ObjectProperty
		/// Offset: 0x6E8
		/// Size: 0x08
		/// </summary>
		public UTexture2D MobileWeightNormalmapTexture => ReadUObject<UTexture2D>(0x6E8);
		
	}


	/// <summary>
	/// ALandscapeGizmoActor:AActor
	/// Size: 0x3D0
	/// Properties: 0
	/// </summary>
	public class ALandscapeGizmoActor:AActor
	{
		public override int ObjectSize => 976;
	}


	/// <summary>
	/// ALandscapeGizmoActiveActor:ALandscapeGizmoActor
	/// Size: 0x420
	/// Properties: 0
	/// </summary>
	public class ALandscapeGizmoActiveActor:ALandscapeGizmoActor
	{
		public override int ObjectSize => 1056;
	}


	/// <summary>
	/// ULandscapeGizmoRenderComponent:UPrimitiveComponent
	/// Size: 0x5A0
	/// Properties: 0
	/// </summary>
	public class ULandscapeGizmoRenderComponent:UPrimitiveComponent
	{
		public override int ObjectSize => 1440;
	}


	/// <summary>
	/// ULandscapeHeightfieldCollisionComponent:UPrimitiveComponent
	/// Size: 0x680
	/// Properties: 11
	/// </summary>
	public class ULandscapeHeightfieldCollisionComponent:UPrimitiveComponent
	{
		public override int ObjectSize => 1664;
		/// <summary>
		/// Name: ComponentLayerInfos
		/// Type: TArray<ULandscapeLayerInfoObject>
		/// Offset: 0x5A0
		/// Size: 0x10
		/// SubElement Size: 0x50
		/// </summary>
		public TArray<ULandscapeLayerInfoObject> ComponentLayerInfos => new TArray<ULandscapeLayerInfoObject>(BaseAddress+0x5A0);
		
		/// <summary>
		/// Name: SectionBaseX
		/// Type: IntProperty
		/// Offset: 0x5B0
		/// Size: 0x04
		/// </summary>
		public int SectionBaseX
		{
			get
			{
				return ReadInt32(0x5B0);
			}
			set
			{
				WriteInt32(0x5B0,value);
			}
		}
		
		/// <summary>
		/// Name: SectionBaseY
		/// Type: IntProperty
		/// Offset: 0x5B4
		/// Size: 0x04
		/// </summary>
		public int SectionBaseY
		{
			get
			{
				return ReadInt32(0x5B4);
			}
			set
			{
				WriteInt32(0x5B4,value);
			}
		}
		
		/// <summary>
		/// Name: CollisionSizeQuads
		/// Type: IntProperty
		/// Offset: 0x5B8
		/// Size: 0x04
		/// </summary>
		public int CollisionSizeQuads
		{
			get
			{
				return ReadInt32(0x5B8);
			}
			set
			{
				WriteInt32(0x5B8,value);
			}
		}
		
		/// <summary>
		/// Name: CollisionScale
		/// Type: FloatProperty
		/// Offset: 0x5BC
		/// Size: 0x04
		/// </summary>
		public float CollisionScale
		{
			get
			{
				return ReadSingle(0x5BC);
			}
			set
			{
				WriteSingle(0x5BC,value);
			}
		}
		
		/// <summary>
		/// Name: SimpleCollisionSizeQuads
		/// Type: IntProperty
		/// Offset: 0x5C0
		/// Size: 0x04
		/// </summary>
		public int SimpleCollisionSizeQuads
		{
			get
			{
				return ReadInt32(0x5C0);
			}
			set
			{
				WriteInt32(0x5C0,value);
			}
		}
		
		/// <summary>
		/// Name: CollisionQuadFlags
		/// Type: TArray<>
		/// Offset: 0x5C8
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: HeightfieldGuid
		/// Type: StructProperty
		/// Offset: 0x5D8
		/// Size: 0x10
		/// </summary>
		public FGuid HeightfieldGuid => ReadStruct<FGuid>(0x5D8);
		
		/// <summary>
		/// Name: CachedLocalBox
		/// Type: StructProperty
		/// Offset: 0x5E8
		/// Size: 0x1C
		/// </summary>
		public FBox CachedLocalBox => ReadStruct<FBox>(0x5E8);
		
		/// <summary>
		/// Name: RenderComponent
		/// Type: LazyObjectProperty
		/// Offset: 0x604
		/// Size: 0x1C
		/// </summary>
		
		/// <summary>
		/// Name: CookedPhysicalMaterials
		/// Type: TArray<UPhysicalMaterial>
		/// Offset: 0x630
		/// Size: 0x10
		/// SubElement Size: 0x88
		/// </summary>
		public TArray<UPhysicalMaterial> CookedPhysicalMaterials => new TArray<UPhysicalMaterial>(BaseAddress+0x630);
		
	}


	/// <summary>
	/// ULandscapeMeshCollisionComponent:ULandscapeHeightfieldCollisionComponent
	/// Size: 0x6A0
	/// Properties: 1
	/// </summary>
	public class ULandscapeMeshCollisionComponent:ULandscapeHeightfieldCollisionComponent
	{
		public override int ObjectSize => 1696;
		/// <summary>
		/// Name: MeshGuid
		/// Type: StructProperty
		/// Offset: 0x680
		/// Size: 0x10
		/// </summary>
		public FGuid MeshGuid => ReadStruct<FGuid>(0x680);
		
	}


	/// <summary>
	/// ULandscapeInfo:UObject
	/// Size: 0x210
	/// Properties: 6
	/// </summary>
	public class ULandscapeInfo:UObject
	{
		public override int ObjectSize => 528;
		/// <summary>
		/// Name: LandscapeActor
		/// Type: LazyObjectProperty
		/// Offset: 0x28
		/// Size: 0x1C
		/// </summary>
		
		/// <summary>
		/// Name: LandscapeGuid
		/// Type: StructProperty
		/// Offset: 0x44
		/// Size: 0x10
		/// </summary>
		public FGuid LandscapeGuid => ReadStruct<FGuid>(0x44);
		
		/// <summary>
		/// Name: ComponentSizeQuads
		/// Type: IntProperty
		/// Offset: 0x54
		/// Size: 0x04
		/// </summary>
		public int ComponentSizeQuads
		{
			get
			{
				return ReadInt32(0x54);
			}
			set
			{
				WriteInt32(0x54,value);
			}
		}
		
		/// <summary>
		/// Name: SubsectionSizeQuads
		/// Type: IntProperty
		/// Offset: 0x58
		/// Size: 0x04
		/// </summary>
		public int SubsectionSizeQuads
		{
			get
			{
				return ReadInt32(0x58);
			}
			set
			{
				WriteInt32(0x58,value);
			}
		}
		
		/// <summary>
		/// Name: ComponentNumSubsections
		/// Type: IntProperty
		/// Offset: 0x5C
		/// Size: 0x04
		/// </summary>
		public int ComponentNumSubsections
		{
			get
			{
				return ReadInt32(0x5C);
			}
			set
			{
				WriteInt32(0x5C,value);
			}
		}
		
		/// <summary>
		/// Name: DrawScale
		/// Type: StructProperty
		/// Offset: 0x60
		/// Size: 0x0C
		/// </summary>
		public FVector DrawScale => ReadStruct<FVector>(0x60);
		
	}


	/// <summary>
	/// ULandscapeInfoMap:UObject
	/// Size: 0x78
	/// Properties: 0
	/// </summary>
	public class ULandscapeInfoMap:UObject
	{
		public override int ObjectSize => 120;
	}


	/// <summary>
	/// ULandscapeLayerInfoObject:UObject
	/// Size: 0x50
	/// Properties: 4
	/// </summary>
	public class ULandscapeLayerInfoObject:UObject
	{
		public override int ObjectSize => 80;
		/// <summary>
		/// Name: LayerName
		/// Type: NameProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: PhysMaterial
		/// Type: ObjectProperty
		/// Offset: 0x30
		/// Size: 0x08
		/// </summary>
		public UPhysicalMaterial PhysMaterial => ReadUObject<UPhysicalMaterial>(0x30);
		
		/// <summary>
		/// Name: Hardness
		/// Type: FloatProperty
		/// Offset: 0x38
		/// Size: 0x04
		/// </summary>
		public float Hardness
		{
			get
			{
				return ReadSingle(0x38);
			}
			set
			{
				WriteSingle(0x38,value);
			}
		}
		
		/// <summary>
		/// Name: LayerUsageDebugColor
		/// Type: StructProperty
		/// Offset: 0x3C
		/// Size: 0x10
		/// </summary>
		public FLinearColor LayerUsageDebugColor => ReadStruct<FLinearColor>(0x3C);
		
	}


	/// <summary>
	/// UMaterialInterface:UObject
	/// Size: 0x58
	/// Properties: 2
	/// </summary>
	public class UMaterialInterface:UObject
	{
		public override int ObjectSize => 88;
		/// <summary>
		/// Name: SubsurfaceProfile
		/// Type: ObjectProperty
		/// Offset: 0x30
		/// Size: 0x08
		/// </summary>
		public USubsurfaceProfile SubsurfaceProfile => ReadUObject<USubsurfaceProfile>(0x30);
		
		/// <summary>
		/// Name: LightmassSettings
		/// Type: StructProperty
		/// Offset: 0x40
		/// Size: 0x14
		/// </summary>
		public FLightmassMaterialInterfaceSettings LightmassSettings => ReadStruct<FLightmassMaterialInterfaceSettings>(0x40);
		
	}


	/// <summary>
	/// UMaterialInstance:UMaterialInterface
	/// Size: 0x1C8
	/// Properties: 13
	/// </summary>
	public class UMaterialInstance:UMaterialInterface
	{
		public override int ObjectSize => 456;
		/// <summary>
		/// Name: PhysMaterial
		/// Type: ObjectProperty
		/// Offset: 0x58
		/// Size: 0x08
		/// </summary>
		public UPhysicalMaterial PhysMaterial => ReadUObject<UPhysicalMaterial>(0x58);
		
		/// <summary>
		/// Name: Parent
		/// Type: ObjectProperty
		/// Offset: 0x60
		/// Size: 0x08
		/// </summary>
		public UMaterialInterface Parent => ReadUObject<UMaterialInterface>(0x60);
		
		/// <summary>
		/// Name: bHasStaticPermutationResource
		/// Type: BoolProperty
		/// Offset: 0x68
		/// Size: 0x01
		/// </summary>
		public bool bHasStaticPermutationResource => (ReadByte(0x0068) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bOverrideSubsurfaceProfile
		/// Type: BoolProperty
		/// Offset: 0x68
		/// Size: 0x01
		/// </summary>
		public bool bOverrideSubsurfaceProfile => (ReadByte(0x0068) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: ParentLightingGuid
		/// Type: StructProperty
		/// Offset: 0x6C
		/// Size: 0x10
		/// </summary>
		public FGuid ParentLightingGuid => ReadStruct<FGuid>(0x6C);
		
		/// <summary>
		/// Name: FontParameterValues
		/// Type: TArray<FFontParameterValue>
		/// Offset: 0x80
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<FFontParameterValue> FontParameterValues => new TArray<FFontParameterValue>(BaseAddress+0x80);
		
		/// <summary>
		/// Name: ScalarParameterValues
		/// Type: TArray<FScalarParameterValue>
		/// Offset: 0x90
		/// Size: 0x10
		/// SubElement Size: 0x20
		/// </summary>
		public TArray<FScalarParameterValue> ScalarParameterValues => new TArray<FScalarParameterValue>(BaseAddress+0x90);
		
		/// <summary>
		/// Name: TextureParameterValues
		/// Type: TArray<FTextureParameterValue>
		/// Offset: 0xA0
		/// Size: 0x10
		/// SubElement Size: 0x20
		/// </summary>
		public TArray<FTextureParameterValue> TextureParameterValues => new TArray<FTextureParameterValue>(BaseAddress+0xA0);
		
		/// <summary>
		/// Name: GraniteTextureParameterValues
		/// Type: TArray<FGraniteTextureParameterValue>
		/// Offset: 0xB0
		/// Size: 0x10
		/// SubElement Size: 0x20
		/// </summary>
		public TArray<FGraniteTextureParameterValue> GraniteTextureParameterValues => new TArray<FGraniteTextureParameterValue>(BaseAddress+0xB0);
		
		/// <summary>
		/// Name: GraniteErrors
		/// Type: TArray<>
		/// Offset: 0xC0
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: VectorParameterValues
		/// Type: TArray<FVectorParameterValue>
		/// Offset: 0xD0
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<FVectorParameterValue> VectorParameterValues => new TArray<FVectorParameterValue>(BaseAddress+0xD0);
		
		/// <summary>
		/// Name: bOverrideBaseProperties
		/// Type: BoolProperty
		/// Offset: 0xE0
		/// Size: 0x01
		/// </summary>
		public bool bOverrideBaseProperties
		{
			get
			{
				return ReadBool(0xE0);
			}
			set
			{
				WriteBool(0xE0,value);
			}
		}
		
		/// <summary>
		/// Name: BasePropertyOverrides
		/// Type: StructProperty
		/// Offset: 0xE4
		/// Size: 0x14
		/// </summary>
		public FMaterialInstanceBasePropertyOverrides BasePropertyOverrides => ReadStruct<FMaterialInstanceBasePropertyOverrides>(0xE4);
		
	}


	/// <summary>
	/// UMaterialInstanceConstant:UMaterialInstance
	/// Size: 0x1C8
	/// Properties: 0
	/// </summary>
	public class UMaterialInstanceConstant:UMaterialInstance
	{
		public override int ObjectSize => 456;
	}


	/// <summary>
	/// ULandscapeMaterialInstanceConstant:UMaterialInstanceConstant
	/// Size: 0x1D0
	/// Properties: 1
	/// </summary>
	public class ULandscapeMaterialInstanceConstant:UMaterialInstanceConstant
	{
		public override int ObjectSize => 464;
		/// <summary>
		/// Name: bIsLayerThumbnail
		/// Type: BoolProperty
		/// Offset: 0x1C8
		/// Size: 0x01
		/// </summary>
		public bool bIsLayerThumbnail => (ReadByte(0x01C8) & 0x01) == 0x01;
		
	}


	/// <summary>
	/// ALandscapeMeshProxyActor:AActor
	/// Size: 0x3D8
	/// Properties: 1
	/// </summary>
	public class ALandscapeMeshProxyActor:AActor
	{
		public override int ObjectSize => 984;
		/// <summary>
		/// Name: LandscapeMeshProxyComponent
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public ULandscapeMeshProxyComponent LandscapeMeshProxyComponent => ReadUObject<ULandscapeMeshProxyComponent>(0x3D0);
		
	}


	/// <summary>
	/// ULandscapeMeshProxyComponent:UStaticMeshComponent
	/// Size: 0x710
	/// Properties: 3
	/// </summary>
	public class ULandscapeMeshProxyComponent:UStaticMeshComponent
	{
		public override int ObjectSize => 1808;
		/// <summary>
		/// Name: LandscapeGuid
		/// Type: StructProperty
		/// Offset: 0x6E0
		/// Size: 0x10
		/// </summary>
		public FGuid LandscapeGuid => ReadStruct<FGuid>(0x6E0);
		
		/// <summary>
		/// Name: ProxyComponentBases
		/// Type: TArray<FIntPoint>
		/// Offset: 0x6F0
		/// Size: 0x10
		/// SubElement Size: 0x08
		/// </summary>
		public TArray<FIntPoint> ProxyComponentBases => new TArray<FIntPoint>(BaseAddress+0x6F0);
		
		/// <summary>
		/// Name: ProxyLOD
		/// Type: Int8Property
		/// Offset: 0x700
		/// Size: 0x01
		/// </summary>
		
	}


	/// <summary>
	/// ALandscapeProxy:AActor
	/// Size: 0x780
	/// Properties: 36
	/// </summary>
	public class ALandscapeProxy:AActor
	{
		public override int ObjectSize => 1920;
		/// <summary>
		/// Name: SplineComponent
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public ULandscapeSplinesComponent SplineComponent => ReadUObject<ULandscapeSplinesComponent>(0x3D0);
		
		/// <summary>
		/// Name: LandscapeGuid
		/// Type: StructProperty
		/// Offset: 0x3D8
		/// Size: 0x10
		/// </summary>
		public FGuid LandscapeGuid => ReadStruct<FGuid>(0x3D8);
		
		/// <summary>
		/// Name: LandscapeSectionOffset
		/// Type: StructProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public FIntPoint LandscapeSectionOffset => ReadStruct<FIntPoint>(0x3E8);
		
		/// <summary>
		/// Name: MaxLODLevel
		/// Type: IntProperty
		/// Offset: 0x3F0
		/// Size: 0x04
		/// </summary>
		public int MaxLODLevel
		{
			get
			{
				return ReadInt32(0x3F0);
			}
			set
			{
				WriteInt32(0x3F0,value);
			}
		}
		
		/// <summary>
		/// Name: LODDistanceFactor
		/// Type: FloatProperty
		/// Offset: 0x3F4
		/// Size: 0x04
		/// </summary>
		public float LODDistanceFactor
		{
			get
			{
				return ReadSingle(0x3F4);
			}
			set
			{
				WriteSingle(0x3F4,value);
			}
		}
		
		/// <summary>
		/// Name: LODFalloff
		/// Type: ByteProperty
		/// Offset: 0x3F8
		/// Size: 0x01
		/// </summary>
		public byte LODFalloff
		{
			get
			{
				return ReadByte(0x3F8);
			}
			set
			{
				WriteByte(0x3F8,value);
			}
		}
		
		/// <summary>
		/// Name: StaticLightingLOD
		/// Type: IntProperty
		/// Offset: 0x3FC
		/// Size: 0x04
		/// </summary>
		public int StaticLightingLOD
		{
			get
			{
				return ReadInt32(0x3FC);
			}
			set
			{
				WriteInt32(0x3FC,value);
			}
		}
		
		/// <summary>
		/// Name: DefaultPhysMaterial
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UPhysicalMaterial DefaultPhysMaterial => ReadUObject<UPhysicalMaterial>(0x400);
		
		/// <summary>
		/// Name: StreamingDistanceMultiplier
		/// Type: FloatProperty
		/// Offset: 0x408
		/// Size: 0x04
		/// </summary>
		public float StreamingDistanceMultiplier
		{
			get
			{
				return ReadSingle(0x408);
			}
			set
			{
				WriteSingle(0x408,value);
			}
		}
		
		/// <summary>
		/// Name: LandscapeMaterial
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public UMaterialInterface LandscapeMaterial => ReadUObject<UMaterialInterface>(0x410);
		
		/// <summary>
		/// Name: LandscapeHoleMaterial
		/// Type: ObjectProperty
		/// Offset: 0x418
		/// Size: 0x08
		/// </summary>
		public UMaterialInterface LandscapeHoleMaterial => ReadUObject<UMaterialInterface>(0x418);
		
		/// <summary>
		/// Name: NegativeZBoundsExtension
		/// Type: FloatProperty
		/// Offset: 0x420
		/// Size: 0x04
		/// </summary>
		public float NegativeZBoundsExtension
		{
			get
			{
				return ReadSingle(0x420);
			}
			set
			{
				WriteSingle(0x420,value);
			}
		}
		
		/// <summary>
		/// Name: PositiveZBoundsExtension
		/// Type: FloatProperty
		/// Offset: 0x424
		/// Size: 0x04
		/// </summary>
		public float PositiveZBoundsExtension
		{
			get
			{
				return ReadSingle(0x424);
			}
			set
			{
				WriteSingle(0x424,value);
			}
		}
		
		/// <summary>
		/// Name: LandscapeComponents
		/// Type: TArray<ULandscapeComponent>
		/// Offset: 0x428
		/// Size: 0x10
		/// SubElement Size: 0x710
		/// </summary>
		public TArray<ULandscapeComponent> LandscapeComponents => new TArray<ULandscapeComponent>(BaseAddress+0x428);
		
		/// <summary>
		/// Name: CollisionComponents
		/// Type: TArray<ULandscapeHeightfieldCollisionComponent>
		/// Offset: 0x438
		/// Size: 0x10
		/// SubElement Size: 0x680
		/// </summary>
		public TArray<ULandscapeHeightfieldCollisionComponent> CollisionComponents => new TArray<ULandscapeHeightfieldCollisionComponent>(BaseAddress+0x438);
		
		/// <summary>
		/// Name: FoliageComponents
		/// Type: TArray<UHierarchicalInstancedStaticMeshComponent>
		/// Offset: 0x448
		/// Size: 0x10
		/// SubElement Size: 0x8C0
		/// </summary>
		public TArray<UHierarchicalInstancedStaticMeshComponent> FoliageComponents => new TArray<UHierarchicalInstancedStaticMeshComponent>(BaseAddress+0x448);
		
		/// <summary>
		/// Name: bHasLandscapeGrass
		/// Type: BoolProperty
		/// Offset: 0x4B8
		/// Size: 0x01
		/// </summary>
		public bool bHasLandscapeGrass
		{
			get
			{
				return ReadBool(0x4B8);
			}
			set
			{
				WriteBool(0x4B8,value);
			}
		}
		
		/// <summary>
		/// Name: StaticLightingResolution
		/// Type: FloatProperty
		/// Offset: 0x4BC
		/// Size: 0x04
		/// </summary>
		public float StaticLightingResolution
		{
			get
			{
				return ReadSingle(0x4BC);
			}
			set
			{
				WriteSingle(0x4BC,value);
			}
		}
		
		/// <summary>
		/// Name: LandscapeActor
		/// Type: LazyObjectProperty
		/// Offset: 0x4C0
		/// Size: 0x1C
		/// </summary>
		
		/// <summary>
		/// Name: bCastStaticShadow
		/// Type: BoolProperty
		/// Offset: 0x4DC
		/// Size: 0x01
		/// </summary>
		public bool bCastStaticShadow => (ReadByte(0x04DC) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bCastShadowAsTwoSided
		/// Type: BoolProperty
		/// Offset: 0x4DC
		/// Size: 0x01
		/// </summary>
		public bool bCastShadowAsTwoSided => (ReadByte(0x04DC) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bCastFarShadow
		/// Type: BoolProperty
		/// Offset: 0x4DC
		/// Size: 0x01
		/// </summary>
		public bool bCastFarShadow => (ReadByte(0x04DC) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bUseMaterialPositionOffsetInStaticLighting
		/// Type: BoolProperty
		/// Offset: 0x4DC
		/// Size: 0x01
		/// </summary>
		public bool bUseMaterialPositionOffsetInStaticLighting => (ReadByte(0x04DC) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bIsProxy
		/// Type: BoolProperty
		/// Offset: 0x4DC
		/// Size: 0x01
		/// </summary>
		public bool bIsProxy => (ReadByte(0x04DC) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: LightmassSettings
		/// Type: StructProperty
		/// Offset: 0x4E0
		/// Size: 0x18
		/// </summary>
		public FLightmassPrimitiveSettings LightmassSettings => ReadStruct<FLightmassPrimitiveSettings>(0x4E0);
		
		/// <summary>
		/// Name: CollisionMipLevel
		/// Type: IntProperty
		/// Offset: 0x4F8
		/// Size: 0x04
		/// </summary>
		public int CollisionMipLevel
		{
			get
			{
				return ReadInt32(0x4F8);
			}
			set
			{
				WriteInt32(0x4F8,value);
			}
		}
		
		/// <summary>
		/// Name: SimpleCollisionMipLevel
		/// Type: IntProperty
		/// Offset: 0x4FC
		/// Size: 0x04
		/// </summary>
		public int SimpleCollisionMipLevel
		{
			get
			{
				return ReadInt32(0x4FC);
			}
			set
			{
				WriteInt32(0x4FC,value);
			}
		}
		
		/// <summary>
		/// Name: CollisionThickness
		/// Type: FloatProperty
		/// Offset: 0x500
		/// Size: 0x04
		/// </summary>
		public float CollisionThickness
		{
			get
			{
				return ReadSingle(0x500);
			}
			set
			{
				WriteSingle(0x500,value);
			}
		}
		
		/// <summary>
		/// Name: BodyInstance
		/// Type: StructProperty
		/// Offset: 0x510
		/// Size: 0x1B0
		/// </summary>
		public FBodyInstance BodyInstance => ReadStruct<FBodyInstance>(0x510);
		
		/// <summary>
		/// Name: bBakeMaterialPositionOffsetIntoCollision
		/// Type: BoolProperty
		/// Offset: 0x6C0
		/// Size: 0x01
		/// </summary>
		public bool bBakeMaterialPositionOffsetIntoCollision => (ReadByte(0x06C0) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: ComponentSizeQuads
		/// Type: IntProperty
		/// Offset: 0x6C4
		/// Size: 0x04
		/// </summary>
		public int ComponentSizeQuads
		{
			get
			{
				return ReadInt32(0x6C4);
			}
			set
			{
				WriteInt32(0x6C4,value);
			}
		}
		
		/// <summary>
		/// Name: SubsectionSizeQuads
		/// Type: IntProperty
		/// Offset: 0x6C8
		/// Size: 0x04
		/// </summary>
		public int SubsectionSizeQuads
		{
			get
			{
				return ReadInt32(0x6C8);
			}
			set
			{
				WriteInt32(0x6C8,value);
			}
		}
		
		/// <summary>
		/// Name: NumSubsections
		/// Type: IntProperty
		/// Offset: 0x6CC
		/// Size: 0x04
		/// </summary>
		public int NumSubsections
		{
			get
			{
				return ReadInt32(0x6CC);
			}
			set
			{
				WriteInt32(0x6CC,value);
			}
		}
		
		/// <summary>
		/// Name: bUsedForNavigation
		/// Type: BoolProperty
		/// Offset: 0x6D0
		/// Size: 0x01
		/// </summary>
		public bool bUsedForNavigation => (ReadByte(0x06D0) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: NavigationGeometryGatheringMode
		/// Type: ByteProperty
		/// Offset: 0x6D4
		/// Size: 0x01
		/// </summary>
		public byte NavigationGeometryGatheringMode
		{
			get
			{
				return ReadByte(0x6D4);
			}
			set
			{
				WriteByte(0x6D4,value);
			}
		}
		
		/// <summary>
		/// Name: bUseLandscapeForCullingInvisibleHLODVertices
		/// Type: BoolProperty
		/// Offset: 0x6D5
		/// Size: 0x01
		/// </summary>
		public bool bUseLandscapeForCullingInvisibleHLODVertices
		{
			get
			{
				return ReadBool(0x6D5);
			}
			set
			{
				WriteBool(0x6D5,value);
			}
		}
		
	}


	/// <summary>
	/// ALandscape:ALandscapeProxy
	/// Size: 0x780
	/// Properties: 0
	/// </summary>
	public class ALandscape:ALandscapeProxy
	{
		public override int ObjectSize => 1920;
	}


	/// <summary>
	/// ULandscapeSplinesComponent:UPrimitiveComponent
	/// Size: 0x5D0
	/// Properties: 3
	/// </summary>
	public class ULandscapeSplinesComponent:UPrimitiveComponent
	{
		public override int ObjectSize => 1488;
		/// <summary>
		/// Name: ControlPoints
		/// Type: TArray<ULandscapeSplineControlPoint>
		/// Offset: 0x5A0
		/// Size: 0x10
		/// SubElement Size: 0x98
		/// </summary>
		public TArray<ULandscapeSplineControlPoint> ControlPoints => new TArray<ULandscapeSplineControlPoint>(BaseAddress+0x5A0);
		
		/// <summary>
		/// Name: Segments
		/// Type: TArray<ULandscapeSplineSegment>
		/// Offset: 0x5B0
		/// Size: 0x10
		/// SubElement Size: 0xB0
		/// </summary>
		public TArray<ULandscapeSplineSegment> Segments => new TArray<ULandscapeSplineSegment>(BaseAddress+0x5B0);
		
		/// <summary>
		/// Name: CookedForeignMeshComponents
		/// Type: TArray<UMeshComponent>
		/// Offset: 0x5C0
		/// Size: 0x10
		/// SubElement Size: 0x660
		/// </summary>
		public TArray<UMeshComponent> CookedForeignMeshComponents => new TArray<UMeshComponent>(BaseAddress+0x5C0);
		
	}


	/// <summary>
	/// ULandscapeSplineSegment:UObject
	/// Size: 0xB0
	/// Properties: 5
	/// </summary>
	public class ULandscapeSplineSegment:UObject
	{
		public override int ObjectSize => 176;
		/// <summary>
		/// Name: Connections
		/// Type: StructProperty
		/// Offset: 0x28
		/// Size: 0x18
		/// </summary>
		public FLandscapeSplineSegmentConnection Connections => ReadStruct<FLandscapeSplineSegmentConnection>(0x28);
		
		/// <summary>
		/// Name: SplineInfo
		/// Type: StructProperty
		/// Offset: 0x58
		/// Size: 0x18
		/// </summary>
		public FInterpCurveVector SplineInfo => ReadStruct<FInterpCurveVector>(0x58);
		
		/// <summary>
		/// Name: Points
		/// Type: TArray<FLandscapeSplineInterpPoint>
		/// Offset: 0x70
		/// Size: 0x10
		/// SubElement Size: 0x40
		/// </summary>
		public TArray<FLandscapeSplineInterpPoint> Points => new TArray<FLandscapeSplineInterpPoint>(BaseAddress+0x70);
		
		/// <summary>
		/// Name: Bounds
		/// Type: StructProperty
		/// Offset: 0x80
		/// Size: 0x1C
		/// </summary>
		public FBox Bounds => ReadStruct<FBox>(0x80);
		
		/// <summary>
		/// Name: LocalMeshComponents
		/// Type: TArray<USplineMeshComponent>
		/// Offset: 0xA0
		/// Size: 0x10
		/// SubElement Size: 0x780
		/// </summary>
		public TArray<USplineMeshComponent> LocalMeshComponents => new TArray<USplineMeshComponent>(BaseAddress+0xA0);
		
	}


	/// <summary>
	/// ULandscapeSplineControlPoint:UObject
	/// Size: 0x98
	/// Properties: 9
	/// </summary>
	public class ULandscapeSplineControlPoint:UObject
	{
		public override int ObjectSize => 152;
		/// <summary>
		/// Name: Location
		/// Type: StructProperty
		/// Offset: 0x28
		/// Size: 0x0C
		/// </summary>
		public FVector Location => ReadStruct<FVector>(0x28);
		
		/// <summary>
		/// Name: Rotation
		/// Type: StructProperty
		/// Offset: 0x34
		/// Size: 0x0C
		/// </summary>
		public FRotator Rotation => ReadStruct<FRotator>(0x34);
		
		/// <summary>
		/// Name: Width
		/// Type: FloatProperty
		/// Offset: 0x40
		/// Size: 0x04
		/// </summary>
		public float Width
		{
			get
			{
				return ReadSingle(0x40);
			}
			set
			{
				WriteSingle(0x40,value);
			}
		}
		
		/// <summary>
		/// Name: SideFalloff
		/// Type: FloatProperty
		/// Offset: 0x44
		/// Size: 0x04
		/// </summary>
		public float SideFalloff
		{
			get
			{
				return ReadSingle(0x44);
			}
			set
			{
				WriteSingle(0x44,value);
			}
		}
		
		/// <summary>
		/// Name: EndFalloff
		/// Type: FloatProperty
		/// Offset: 0x48
		/// Size: 0x04
		/// </summary>
		public float EndFalloff
		{
			get
			{
				return ReadSingle(0x48);
			}
			set
			{
				WriteSingle(0x48,value);
			}
		}
		
		/// <summary>
		/// Name: ConnectedSegments
		/// Type: TArray<FLandscapeSplineConnection>
		/// Offset: 0x50
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FLandscapeSplineConnection> ConnectedSegments => new TArray<FLandscapeSplineConnection>(BaseAddress+0x50);
		
		/// <summary>
		/// Name: Points
		/// Type: TArray<FLandscapeSplineInterpPoint>
		/// Offset: 0x60
		/// Size: 0x10
		/// SubElement Size: 0x40
		/// </summary>
		public TArray<FLandscapeSplineInterpPoint> Points => new TArray<FLandscapeSplineInterpPoint>(BaseAddress+0x60);
		
		/// <summary>
		/// Name: Bounds
		/// Type: StructProperty
		/// Offset: 0x70
		/// Size: 0x1C
		/// </summary>
		public FBox Bounds => ReadStruct<FBox>(0x70);
		
		/// <summary>
		/// Name: LocalMeshComponent
		/// Type: ObjectProperty
		/// Offset: 0x90
		/// Size: 0x08
		/// </summary>
		public UControlPointMeshComponent LocalMeshComponent => ReadUObject<UControlPointMeshComponent>(0x90);
		
	}


	/// <summary>
	/// UMaterialExpression:UObject
	/// Size: 0x70
	/// Properties: 16
	/// </summary>
	public class UMaterialExpression:UObject
	{
		public override int ObjectSize => 112;
		/// <summary>
		/// Name: Material
		/// Type: ObjectProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		public UMaterial Material => ReadUObject<UMaterial>(0x28);
		
		/// <summary>
		/// Name: Function
		/// Type: ObjectProperty
		/// Offset: 0x30
		/// Size: 0x08
		/// </summary>
		public UMaterialFunction Function => ReadUObject<UMaterialFunction>(0x30);
		
		/// <summary>
		/// Name: Desc
		/// Type: StrProperty
		/// Offset: 0x38
		/// Size: 0x10
		/// </summary>
		public FString Desc => new FString(BaseAddress+0x38);
		
		/// <summary>
		/// Name: BorderColor
		/// Type: StructProperty
		/// Offset: 0x48
		/// Size: 0x04
		/// </summary>
		public FColor BorderColor => ReadStruct<FColor>(0x48);
		
		/// <summary>
		/// Name: bRealtimePreview
		/// Type: BoolProperty
		/// Offset: 0x4C
		/// Size: 0x01
		/// </summary>
		public bool bRealtimePreview => (ReadByte(0x004C) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bNeedToUpdatePreview
		/// Type: BoolProperty
		/// Offset: 0x4C
		/// Size: 0x01
		/// </summary>
		public bool bNeedToUpdatePreview => (ReadByte(0x004C) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bIsParameterExpression
		/// Type: BoolProperty
		/// Offset: 0x4C
		/// Size: 0x01
		/// </summary>
		public bool bIsParameterExpression => (ReadByte(0x004C) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bCommentBubbleVisible
		/// Type: BoolProperty
		/// Offset: 0x4C
		/// Size: 0x01
		/// </summary>
		public bool bCommentBubbleVisible => (ReadByte(0x004C) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bShowOutputNameOnPin
		/// Type: BoolProperty
		/// Offset: 0x4C
		/// Size: 0x01
		/// </summary>
		public bool bShowOutputNameOnPin => (ReadByte(0x004C) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bHidePreviewWindow
		/// Type: BoolProperty
		/// Offset: 0x4C
		/// Size: 0x01
		/// </summary>
		public bool bHidePreviewWindow => (ReadByte(0x004C) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: bCollapsed
		/// Type: BoolProperty
		/// Offset: 0x4C
		/// Size: 0x01
		/// </summary>
		public bool bCollapsed => (ReadByte(0x004C) & 0x40) == 0x40;
		
		/// <summary>
		/// Name: bShaderInputData
		/// Type: BoolProperty
		/// Offset: 0x4C
		/// Size: 0x01
		/// </summary>
		public bool bShaderInputData => (ReadByte(0x004C) & 0x80) == 0x80;
		
		/// <summary>
		/// Name: bShowInputs
		/// Type: BoolProperty
		/// Offset: 0x4D
		/// Size: 0x01
		/// </summary>
		public bool bShowInputs => (ReadByte(0x004D) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bShowOutputs
		/// Type: BoolProperty
		/// Offset: 0x4D
		/// Size: 0x01
		/// </summary>
		public bool bShowOutputs => (ReadByte(0x004D) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: MenuCategories
		/// Type: TArray<>
		/// Offset: 0x50
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: Outputs
		/// Type: TArray<FExpressionOutput>
		/// Offset: 0x60
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<FExpressionOutput> Outputs => new TArray<FExpressionOutput>(BaseAddress+0x60);
		
	}


	/// <summary>
	/// UMaterialExpressionCustomOutput:UMaterialExpression
	/// Size: 0x70
	/// Properties: 0
	/// </summary>
	public class UMaterialExpressionCustomOutput:UMaterialExpression
	{
		public override int ObjectSize => 112;
	}


	/// <summary>
	/// UMaterialExpressionLandscapeGrassOutput:UMaterialExpressionCustomOutput
	/// Size: 0x80
	/// Properties: 1
	/// </summary>
	public class UMaterialExpressionLandscapeGrassOutput:UMaterialExpressionCustomOutput
	{
		public override int ObjectSize => 128;
		/// <summary>
		/// Name: GrassTypes
		/// Type: TArray<FGrassInput>
		/// Offset: 0x70
		/// Size: 0x10
		/// SubElement Size: 0x48
		/// </summary>
		public TArray<FGrassInput> GrassTypes => new TArray<FGrassInput>(BaseAddress+0x70);
		
	}


	/// <summary>
	/// UMaterialExpressionLandscapeLayerBlend:UMaterialExpression
	/// Size: 0x90
	/// Properties: 2
	/// </summary>
	public class UMaterialExpressionLandscapeLayerBlend:UMaterialExpression
	{
		public override int ObjectSize => 144;
		/// <summary>
		/// Name: Layers
		/// Type: TArray<FLayerBlendInput>
		/// Offset: 0x70
		/// Size: 0x10
		/// SubElement Size: 0x98
		/// </summary>
		public TArray<FLayerBlendInput> Layers => new TArray<FLayerBlendInput>(BaseAddress+0x70);
		
		/// <summary>
		/// Name: ExpressionGUID
		/// Type: StructProperty
		/// Offset: 0x80
		/// Size: 0x10
		/// </summary>
		public FGuid ExpressionGUID => ReadStruct<FGuid>(0x80);
		
	}


	/// <summary>
	/// UMaterialExpressionLandscapeLayerCoords:UMaterialExpression
	/// Size: 0x88
	/// Properties: 6
	/// </summary>
	public class UMaterialExpressionLandscapeLayerCoords:UMaterialExpression
	{
		public override int ObjectSize => 136;
		/// <summary>
		/// Name: MappingType
		/// Type: ByteProperty
		/// Offset: 0x70
		/// Size: 0x01
		/// </summary>
		public byte MappingType
		{
			get
			{
				return ReadByte(0x70);
			}
			set
			{
				WriteByte(0x70,value);
			}
		}
		
		/// <summary>
		/// Name: CustomUVType
		/// Type: ByteProperty
		/// Offset: 0x71
		/// Size: 0x01
		/// </summary>
		public byte CustomUVType
		{
			get
			{
				return ReadByte(0x71);
			}
			set
			{
				WriteByte(0x71,value);
			}
		}
		
		/// <summary>
		/// Name: MappingScale
		/// Type: FloatProperty
		/// Offset: 0x74
		/// Size: 0x04
		/// </summary>
		public float MappingScale
		{
			get
			{
				return ReadSingle(0x74);
			}
			set
			{
				WriteSingle(0x74,value);
			}
		}
		
		/// <summary>
		/// Name: MappingRotation
		/// Type: FloatProperty
		/// Offset: 0x78
		/// Size: 0x04
		/// </summary>
		public float MappingRotation
		{
			get
			{
				return ReadSingle(0x78);
			}
			set
			{
				WriteSingle(0x78,value);
			}
		}
		
		/// <summary>
		/// Name: MappingPanU
		/// Type: FloatProperty
		/// Offset: 0x7C
		/// Size: 0x04
		/// </summary>
		public float MappingPanU
		{
			get
			{
				return ReadSingle(0x7C);
			}
			set
			{
				WriteSingle(0x7C,value);
			}
		}
		
		/// <summary>
		/// Name: MappingPanV
		/// Type: FloatProperty
		/// Offset: 0x80
		/// Size: 0x04
		/// </summary>
		public float MappingPanV
		{
			get
			{
				return ReadSingle(0x80);
			}
			set
			{
				WriteSingle(0x80,value);
			}
		}
		
	}


	/// <summary>
	/// UMaterialExpressionLandscapeLayerSample:UMaterialExpression
	/// Size: 0x90
	/// Properties: 3
	/// </summary>
	public class UMaterialExpressionLandscapeLayerSample:UMaterialExpression
	{
		public override int ObjectSize => 144;
		/// <summary>
		/// Name: ParameterName
		/// Type: NameProperty
		/// Offset: 0x70
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: PreviewWeight
		/// Type: FloatProperty
		/// Offset: 0x78
		/// Size: 0x04
		/// </summary>
		public float PreviewWeight
		{
			get
			{
				return ReadSingle(0x78);
			}
			set
			{
				WriteSingle(0x78,value);
			}
		}
		
		/// <summary>
		/// Name: ExpressionGUID
		/// Type: StructProperty
		/// Offset: 0x7C
		/// Size: 0x10
		/// </summary>
		public FGuid ExpressionGUID => ReadStruct<FGuid>(0x7C);
		
	}


	/// <summary>
	/// UMaterialExpressionLandscapeLayerSwitch:UMaterialExpression
	/// Size: 0x100
	/// Properties: 5
	/// </summary>
	public class UMaterialExpressionLandscapeLayerSwitch:UMaterialExpression
	{
		public override int ObjectSize => 256;
		/// <summary>
		/// Name: LayerUsed
		/// Type: StructProperty
		/// Offset: 0x70
		/// Size: 0x38
		/// </summary>
		public FExpressionInput LayerUsed => ReadStruct<FExpressionInput>(0x70);
		
		/// <summary>
		/// Name: LayerNotUsed
		/// Type: StructProperty
		/// Offset: 0xA8
		/// Size: 0x38
		/// </summary>
		public FExpressionInput LayerNotUsed => ReadStruct<FExpressionInput>(0xA8);
		
		/// <summary>
		/// Name: ParameterName
		/// Type: NameProperty
		/// Offset: 0xE0
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: PreviewUsed
		/// Type: BoolProperty
		/// Offset: 0xE8
		/// Size: 0x01
		/// </summary>
		public bool PreviewUsed => (ReadByte(0x00E8) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: ExpressionGUID
		/// Type: StructProperty
		/// Offset: 0xEC
		/// Size: 0x10
		/// </summary>
		public FGuid ExpressionGUID => ReadStruct<FGuid>(0xEC);
		
	}


	/// <summary>
	/// UMaterialExpressionLandscapeLayerWeight:UMaterialExpression
	/// Size: 0x108
	/// Properties: 6
	/// </summary>
	public class UMaterialExpressionLandscapeLayerWeight:UMaterialExpression
	{
		public override int ObjectSize => 264;
		/// <summary>
		/// Name: Base
		/// Type: StructProperty
		/// Offset: 0x70
		/// Size: 0x38
		/// </summary>
		public FExpressionInput Base => ReadStruct<FExpressionInput>(0x70);
		
		/// <summary>
		/// Name: Layer
		/// Type: StructProperty
		/// Offset: 0xA8
		/// Size: 0x38
		/// </summary>
		public FExpressionInput Layer => ReadStruct<FExpressionInput>(0xA8);
		
		/// <summary>
		/// Name: ParameterName
		/// Type: NameProperty
		/// Offset: 0xE0
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: PreviewWeight
		/// Type: FloatProperty
		/// Offset: 0xE8
		/// Size: 0x04
		/// </summary>
		public float PreviewWeight
		{
			get
			{
				return ReadSingle(0xE8);
			}
			set
			{
				WriteSingle(0xE8,value);
			}
		}
		
		/// <summary>
		/// Name: ConstBase
		/// Type: StructProperty
		/// Offset: 0xEC
		/// Size: 0x0C
		/// </summary>
		public FVector ConstBase => ReadStruct<FVector>(0xEC);
		
		/// <summary>
		/// Name: ExpressionGUID
		/// Type: StructProperty
		/// Offset: 0xF8
		/// Size: 0x10
		/// </summary>
		public FGuid ExpressionGUID => ReadStruct<FGuid>(0xF8);
		
	}


	/// <summary>
	/// UMaterialExpressionLandscapeVisibilityMask:UMaterialExpression
	/// Size: 0x80
	/// Properties: 1
	/// </summary>
	public class UMaterialExpressionLandscapeVisibilityMask:UMaterialExpression
	{
		public override int ObjectSize => 128;
		/// <summary>
		/// Name: ExpressionGUID
		/// Type: StructProperty
		/// Offset: 0x70
		/// Size: 0x10
		/// </summary>
		public FGuid ExpressionGUID => ReadStruct<FGuid>(0x70);
		
	}


	/// <summary>
	/// UMovieScene:UObject
	/// Size: 0xA8
	/// Properties: 13
	/// </summary>
	public class UMovieScene:UObject
	{
		public override int ObjectSize => 168;
		/// <summary>
		/// Name: Spawnables
		/// Type: TArray<FMovieSceneSpawnable>
		/// Offset: 0x28
		/// Size: 0x10
		/// SubElement Size: 0x40
		/// </summary>
		public TArray<FMovieSceneSpawnable> Spawnables => new TArray<FMovieSceneSpawnable>(BaseAddress+0x28);
		
		/// <summary>
		/// Name: Possessables
		/// Type: TArray<FMovieScenePossessable>
		/// Offset: 0x38
		/// Size: 0x10
		/// SubElement Size: 0x38
		/// </summary>
		public TArray<FMovieScenePossessable> Possessables => new TArray<FMovieScenePossessable>(BaseAddress+0x38);
		
		/// <summary>
		/// Name: ObjectBindings
		/// Type: TArray<FMovieSceneBinding>
		/// Offset: 0x48
		/// Size: 0x10
		/// SubElement Size: 0x30
		/// </summary>
		public TArray<FMovieSceneBinding> ObjectBindings => new TArray<FMovieSceneBinding>(BaseAddress+0x48);
		
		/// <summary>
		/// Name: MasterTracks
		/// Type: TArray<UMovieSceneTrack>
		/// Offset: 0x58
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<UMovieSceneTrack> MasterTracks => new TArray<UMovieSceneTrack>(BaseAddress+0x58);
		
		/// <summary>
		/// Name: CameraCutTrack
		/// Type: ObjectProperty
		/// Offset: 0x68
		/// Size: 0x08
		/// </summary>
		public UMovieSceneTrack CameraCutTrack => ReadUObject<UMovieSceneTrack>(0x68);
		
		/// <summary>
		/// Name: SelectionRange
		/// Type: StructProperty
		/// Offset: 0x70
		/// Size: 0x10
		/// </summary>
		public FFloatRange SelectionRange => ReadStruct<FFloatRange>(0x70);
		
		/// <summary>
		/// Name: PlaybackRange
		/// Type: StructProperty
		/// Offset: 0x80
		/// Size: 0x10
		/// </summary>
		public FFloatRange PlaybackRange => ReadStruct<FFloatRange>(0x80);
		
		/// <summary>
		/// Name: bForceFixedFrameIntervalPlayback
		/// Type: BoolProperty
		/// Offset: 0x90
		/// Size: 0x01
		/// </summary>
		public bool bForceFixedFrameIntervalPlayback
		{
			get
			{
				return ReadBool(0x90);
			}
			set
			{
				WriteBool(0x90,value);
			}
		}
		
		/// <summary>
		/// Name: FixedFrameInterval
		/// Type: FloatProperty
		/// Offset: 0x94
		/// Size: 0x04
		/// </summary>
		public float FixedFrameInterval
		{
			get
			{
				return ReadSingle(0x94);
			}
			set
			{
				WriteSingle(0x94,value);
			}
		}
		
		/// <summary>
		/// Name: InTime
		/// Type: FloatProperty
		/// Offset: 0x98
		/// Size: 0x04
		/// </summary>
		public float InTime
		{
			get
			{
				return ReadSingle(0x98);
			}
			set
			{
				WriteSingle(0x98,value);
			}
		}
		
		/// <summary>
		/// Name: OutTime
		/// Type: FloatProperty
		/// Offset: 0x9C
		/// Size: 0x04
		/// </summary>
		public float OutTime
		{
			get
			{
				return ReadSingle(0x9C);
			}
			set
			{
				WriteSingle(0x9C,value);
			}
		}
		
		/// <summary>
		/// Name: StartTime
		/// Type: FloatProperty
		/// Offset: 0xA0
		/// Size: 0x04
		/// </summary>
		public float StartTime
		{
			get
			{
				return ReadSingle(0xA0);
			}
			set
			{
				WriteSingle(0xA0,value);
			}
		}
		
		/// <summary>
		/// Name: EndTime
		/// Type: FloatProperty
		/// Offset: 0xA4
		/// Size: 0x04
		/// </summary>
		public float EndTime
		{
			get
			{
				return ReadSingle(0xA4);
			}
			set
			{
				WriteSingle(0xA4,value);
			}
		}
		
	}


	/// <summary>
	/// UMovieSceneFolder:UObject
	/// Size: 0x70
	/// Properties: 4
	/// </summary>
	public class UMovieSceneFolder:UObject
	{
		public override int ObjectSize => 112;
		/// <summary>
		/// Name: FolderName
		/// Type: NameProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: ChildFolders
		/// Type: TArray<UMovieSceneFolder>
		/// Offset: 0x30
		/// Size: 0x10
		/// SubElement Size: 0x70
		/// </summary>
		public TArray<UMovieSceneFolder> ChildFolders => new TArray<UMovieSceneFolder>(BaseAddress+0x30);
		
		/// <summary>
		/// Name: ChildMasterTracks
		/// Type: TArray<UMovieSceneTrack>
		/// Offset: 0x40
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<UMovieSceneTrack> ChildMasterTracks => new TArray<UMovieSceneTrack>(BaseAddress+0x40);
		
		/// <summary>
		/// Name: ChildObjectBindingStrings
		/// Type: TArray<>
		/// Offset: 0x50
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
	}


	/// <summary>
	/// UMovieSceneSection:UObject
	/// Size: 0x40
	/// Properties: 7
	/// </summary>
	public class UMovieSceneSection:UObject
	{
		public override int ObjectSize => 64;
		/// <summary>
		/// Name: StartTime
		/// Type: FloatProperty
		/// Offset: 0x28
		/// Size: 0x04
		/// </summary>
		public float StartTime
		{
			get
			{
				return ReadSingle(0x28);
			}
			set
			{
				WriteSingle(0x28,value);
			}
		}
		
		/// <summary>
		/// Name: EndTime
		/// Type: FloatProperty
		/// Offset: 0x2C
		/// Size: 0x04
		/// </summary>
		public float EndTime
		{
			get
			{
				return ReadSingle(0x2C);
			}
			set
			{
				WriteSingle(0x2C,value);
			}
		}
		
		/// <summary>
		/// Name: RowIndex
		/// Type: IntProperty
		/// Offset: 0x30
		/// Size: 0x04
		/// </summary>
		public int RowIndex
		{
			get
			{
				return ReadInt32(0x30);
			}
			set
			{
				WriteInt32(0x30,value);
			}
		}
		
		/// <summary>
		/// Name: OverlapPriority
		/// Type: IntProperty
		/// Offset: 0x34
		/// Size: 0x04
		/// </summary>
		public int OverlapPriority
		{
			get
			{
				return ReadInt32(0x34);
			}
			set
			{
				WriteInt32(0x34,value);
			}
		}
		
		/// <summary>
		/// Name: bIsActive
		/// Type: BoolProperty
		/// Offset: 0x38
		/// Size: 0x01
		/// </summary>
		public bool bIsActive => (ReadByte(0x0038) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bIsLocked
		/// Type: BoolProperty
		/// Offset: 0x38
		/// Size: 0x01
		/// </summary>
		public bool bIsLocked => (ReadByte(0x0038) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bIsInfinite
		/// Type: BoolProperty
		/// Offset: 0x38
		/// Size: 0x01
		/// </summary>
		public bool bIsInfinite => (ReadByte(0x0038) & 0x04) == 0x04;
		
	}


	/// <summary>
	/// UMovieSceneSequence:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UMovieSceneSequence:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UMovieSceneTrack:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UMovieSceneTrack:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UMovieSceneNameableTrack:UMovieSceneTrack
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UMovieSceneNameableTrack:UMovieSceneTrack
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UMovieScene3DConstraintSection:UMovieSceneSection
	/// Size: 0x50
	/// Properties: 1
	/// </summary>
	public class UMovieScene3DConstraintSection:UMovieSceneSection
	{
		public override int ObjectSize => 80;
		/// <summary>
		/// Name: ConstraintId
		/// Type: StructProperty
		/// Offset: 0x40
		/// Size: 0x10
		/// </summary>
		public FGuid ConstraintId => ReadStruct<FGuid>(0x40);
		
	}


	/// <summary>
	/// UMovieScene3DAttachSection:UMovieScene3DConstraintSection
	/// Size: 0x68
	/// Properties: 8
	/// </summary>
	public class UMovieScene3DAttachSection:UMovieScene3DConstraintSection
	{
		public override int ObjectSize => 104;
		/// <summary>
		/// Name: AttachSocketName
		/// Type: NameProperty
		/// Offset: 0x50
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: AttachComponentName
		/// Type: NameProperty
		/// Offset: 0x58
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: bConstrainTx
		/// Type: BoolProperty
		/// Offset: 0x60
		/// Size: 0x01
		/// </summary>
		public bool bConstrainTx => (ReadByte(0x0060) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bConstrainTy
		/// Type: BoolProperty
		/// Offset: 0x60
		/// Size: 0x01
		/// </summary>
		public bool bConstrainTy => (ReadByte(0x0060) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bConstrainTz
		/// Type: BoolProperty
		/// Offset: 0x60
		/// Size: 0x01
		/// </summary>
		public bool bConstrainTz => (ReadByte(0x0060) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bConstrainRx
		/// Type: BoolProperty
		/// Offset: 0x60
		/// Size: 0x01
		/// </summary>
		public bool bConstrainRx => (ReadByte(0x0060) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bConstrainRy
		/// Type: BoolProperty
		/// Offset: 0x60
		/// Size: 0x01
		/// </summary>
		public bool bConstrainRy => (ReadByte(0x0060) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bConstrainRz
		/// Type: BoolProperty
		/// Offset: 0x60
		/// Size: 0x01
		/// </summary>
		public bool bConstrainRz => (ReadByte(0x0060) & 0x20) == 0x20;
		
	}


	/// <summary>
	/// UMovieScene3DPathSection:UMovieScene3DConstraintSection
	/// Size: 0xD0
	/// Properties: 6
	/// </summary>
	public class UMovieScene3DPathSection:UMovieScene3DConstraintSection
	{
		public override int ObjectSize => 208;
		/// <summary>
		/// Name: TimingCurve
		/// Type: StructProperty
		/// Offset: 0x50
		/// Size: 0x78
		/// </summary>
		public FRichCurve TimingCurve => ReadStruct<FRichCurve>(0x50);
		
		/// <summary>
		/// Name: FrontAxisEnum
		/// Type: ByteProperty
		/// Offset: 0xC8
		/// Size: 0x01
		/// </summary>
		public byte FrontAxisEnum
		{
			get
			{
				return ReadByte(0xC8);
			}
			set
			{
				WriteByte(0xC8,value);
			}
		}
		
		/// <summary>
		/// Name: UpAxisEnum
		/// Type: ByteProperty
		/// Offset: 0xC9
		/// Size: 0x01
		/// </summary>
		public byte UpAxisEnum
		{
			get
			{
				return ReadByte(0xC9);
			}
			set
			{
				WriteByte(0xC9,value);
			}
		}
		
		/// <summary>
		/// Name: bFollow
		/// Type: BoolProperty
		/// Offset: 0xCC
		/// Size: 0x01
		/// </summary>
		public bool bFollow => (ReadByte(0x00CC) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bReverse
		/// Type: BoolProperty
		/// Offset: 0xCC
		/// Size: 0x01
		/// </summary>
		public bool bReverse => (ReadByte(0x00CC) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bForceUpright
		/// Type: BoolProperty
		/// Offset: 0xCC
		/// Size: 0x01
		/// </summary>
		public bool bForceUpright => (ReadByte(0x00CC) & 0x04) == 0x04;
		
	}


	/// <summary>
	/// UMovieScene3DConstraintTrack:UMovieSceneTrack
	/// Size: 0x38
	/// Properties: 1
	/// </summary>
	public class UMovieScene3DConstraintTrack:UMovieSceneTrack
	{
		public override int ObjectSize => 56;
		/// <summary>
		/// Name: ConstraintSections
		/// Type: TArray<UMovieSceneSection>
		/// Offset: 0x28
		/// Size: 0x10
		/// SubElement Size: 0x40
		/// </summary>
		public TArray<UMovieSceneSection> ConstraintSections => new TArray<UMovieSceneSection>(BaseAddress+0x28);
		
	}


	/// <summary>
	/// UMovieScene3DAttachTrack:UMovieScene3DConstraintTrack
	/// Size: 0x38
	/// Properties: 0
	/// </summary>
	public class UMovieScene3DAttachTrack:UMovieScene3DConstraintTrack
	{
		public override int ObjectSize => 56;
	}


	/// <summary>
	/// UMovieScene3DPathTrack:UMovieScene3DConstraintTrack
	/// Size: 0x38
	/// Properties: 0
	/// </summary>
	public class UMovieScene3DPathTrack:UMovieScene3DConstraintTrack
	{
		public override int ObjectSize => 56;
	}


	/// <summary>
	/// UMovieScene3DTransformSection:UMovieSceneSection
	/// Size: 0x480
	/// Properties: 3
	/// </summary>
	public class UMovieScene3DTransformSection:UMovieSceneSection
	{
		public override int ObjectSize => 1152;
		/// <summary>
		/// Name: Translation
		/// Type: StructProperty
		/// Offset: 0x48
		/// Size: 0x78
		/// </summary>
		public FRichCurve Translation => ReadStruct<FRichCurve>(0x48);
		
		/// <summary>
		/// Name: Rotation
		/// Type: StructProperty
		/// Offset: 0x1B0
		/// Size: 0x78
		/// </summary>
		public FRichCurve Rotation => ReadStruct<FRichCurve>(0x1B0);
		
		/// <summary>
		/// Name: Scale
		/// Type: StructProperty
		/// Offset: 0x318
		/// Size: 0x78
		/// </summary>
		public FRichCurve Scale => ReadStruct<FRichCurve>(0x318);
		
	}


	/// <summary>
	/// UMovieSceneActorReferenceSection:UMovieSceneSection
	/// Size: 0xD8
	/// Properties: 2
	/// </summary>
	public class UMovieSceneActorReferenceSection:UMovieSceneSection
	{
		public override int ObjectSize => 216;
		/// <summary>
		/// Name: ActorGuidIndexCurve
		/// Type: StructProperty
		/// Offset: 0x48
		/// Size: 0x70
		/// </summary>
		public FIntegralCurve ActorGuidIndexCurve => ReadStruct<FIntegralCurve>(0x48);
		
		/// <summary>
		/// Name: ActorGuidStrings
		/// Type: TArray<>
		/// Offset: 0xC8
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
	}


	/// <summary>
	/// UMovieSceneAudioSection:UMovieSceneSection
	/// Size: 0x58
	/// Properties: 4
	/// </summary>
	public class UMovieSceneAudioSection:UMovieSceneSection
	{
		public override int ObjectSize => 88;
		/// <summary>
		/// Name: Sound
		/// Type: ObjectProperty
		/// Offset: 0x40
		/// Size: 0x08
		/// </summary>
		public USoundBase Sound => ReadUObject<USoundBase>(0x40);
		
		/// <summary>
		/// Name: AudioStartTime
		/// Type: FloatProperty
		/// Offset: 0x48
		/// Size: 0x04
		/// </summary>
		public float AudioStartTime
		{
			get
			{
				return ReadSingle(0x48);
			}
			set
			{
				WriteSingle(0x48,value);
			}
		}
		
		/// <summary>
		/// Name: AudioDilationFactor
		/// Type: FloatProperty
		/// Offset: 0x4C
		/// Size: 0x04
		/// </summary>
		public float AudioDilationFactor
		{
			get
			{
				return ReadSingle(0x4C);
			}
			set
			{
				WriteSingle(0x4C,value);
			}
		}
		
		/// <summary>
		/// Name: AudioVolume
		/// Type: FloatProperty
		/// Offset: 0x50
		/// Size: 0x04
		/// </summary>
		public float AudioVolume
		{
			get
			{
				return ReadSingle(0x50);
			}
			set
			{
				WriteSingle(0x50,value);
			}
		}
		
	}


	/// <summary>
	/// UMovieSceneAudioTrack:UMovieSceneNameableTrack
	/// Size: 0x38
	/// Properties: 1
	/// </summary>
	public class UMovieSceneAudioTrack:UMovieSceneNameableTrack
	{
		public override int ObjectSize => 56;
		/// <summary>
		/// Name: AudioSections
		/// Type: TArray<UMovieSceneSection>
		/// Offset: 0x28
		/// Size: 0x10
		/// SubElement Size: 0x40
		/// </summary>
		public TArray<UMovieSceneSection> AudioSections => new TArray<UMovieSceneSection>(BaseAddress+0x28);
		
	}


	/// <summary>
	/// UMovieSceneBoolSection:UMovieSceneSection
	/// Size: 0xC0
	/// Properties: 2
	/// </summary>
	public class UMovieSceneBoolSection:UMovieSceneSection
	{
		public override int ObjectSize => 192;
		/// <summary>
		/// Name: DefaultValue
		/// Type: BoolProperty
		/// Offset: 0x48
		/// Size: 0x01
		/// </summary>
		public bool DefaultValue
		{
			get
			{
				return ReadBool(0x48);
			}
			set
			{
				WriteBool(0x48,value);
			}
		}
		
		/// <summary>
		/// Name: BoolCurve
		/// Type: StructProperty
		/// Offset: 0x50
		/// Size: 0x70
		/// </summary>
		public FIntegralCurve BoolCurve => ReadStruct<FIntegralCurve>(0x50);
		
	}


	/// <summary>
	/// UMovieSceneVisibilitySection:UMovieSceneBoolSection
	/// Size: 0xC0
	/// Properties: 0
	/// </summary>
	public class UMovieSceneVisibilitySection:UMovieSceneBoolSection
	{
		public override int ObjectSize => 192;
	}


	/// <summary>
	/// UMovieSceneByteSection:UMovieSceneSection
	/// Size: 0xB8
	/// Properties: 1
	/// </summary>
	public class UMovieSceneByteSection:UMovieSceneSection
	{
		public override int ObjectSize => 184;
		/// <summary>
		/// Name: ByteCurve
		/// Type: StructProperty
		/// Offset: 0x48
		/// Size: 0x70
		/// </summary>
		public FIntegralCurve ByteCurve => ReadStruct<FIntegralCurve>(0x48);
		
	}


	/// <summary>
	/// UMovieSceneCameraAnimSection:UMovieSceneSection
	/// Size: 0x68
	/// Properties: 8
	/// </summary>
	public class UMovieSceneCameraAnimSection:UMovieSceneSection
	{
		public override int ObjectSize => 104;
		/// <summary>
		/// Name: CameraAnim
		/// Type: ObjectProperty
		/// Offset: 0x40
		/// Size: 0x08
		/// </summary>
		public UCameraAnim CameraAnim => ReadUObject<UCameraAnim>(0x40);
		
		/// <summary>
		/// Name: PlayRate
		/// Type: FloatProperty
		/// Offset: 0x48
		/// Size: 0x04
		/// </summary>
		public float PlayRate
		{
			get
			{
				return ReadSingle(0x48);
			}
			set
			{
				WriteSingle(0x48,value);
			}
		}
		
		/// <summary>
		/// Name: PlayScale
		/// Type: FloatProperty
		/// Offset: 0x4C
		/// Size: 0x04
		/// </summary>
		public float PlayScale
		{
			get
			{
				return ReadSingle(0x4C);
			}
			set
			{
				WriteSingle(0x4C,value);
			}
		}
		
		/// <summary>
		/// Name: BlendInTime
		/// Type: FloatProperty
		/// Offset: 0x50
		/// Size: 0x04
		/// </summary>
		public float BlendInTime
		{
			get
			{
				return ReadSingle(0x50);
			}
			set
			{
				WriteSingle(0x50,value);
			}
		}
		
		/// <summary>
		/// Name: BlendOutTime
		/// Type: FloatProperty
		/// Offset: 0x54
		/// Size: 0x04
		/// </summary>
		public float BlendOutTime
		{
			get
			{
				return ReadSingle(0x54);
			}
			set
			{
				WriteSingle(0x54,value);
			}
		}
		
		/// <summary>
		/// Name: bLooping
		/// Type: BoolProperty
		/// Offset: 0x58
		/// Size: 0x01
		/// </summary>
		public bool bLooping
		{
			get
			{
				return ReadBool(0x58);
			}
			set
			{
				WriteBool(0x58,value);
			}
		}
		
		/// <summary>
		/// Name: PlaySpace
		/// Type: ByteProperty
		/// Offset: 0x5A
		/// Size: 0x01
		/// </summary>
		public byte PlaySpace
		{
			get
			{
				return ReadByte(0x5A);
			}
			set
			{
				WriteByte(0x5A,value);
			}
		}
		
		/// <summary>
		/// Name: UserDefinedPlaySpace
		/// Type: StructProperty
		/// Offset: 0x5C
		/// Size: 0x0C
		/// </summary>
		public FRotator UserDefinedPlaySpace => ReadStruct<FRotator>(0x5C);
		
	}


	/// <summary>
	/// UMovieSceneCameraAnimTrack:UMovieSceneNameableTrack
	/// Size: 0x38
	/// Properties: 1
	/// </summary>
	public class UMovieSceneCameraAnimTrack:UMovieSceneNameableTrack
	{
		public override int ObjectSize => 56;
		/// <summary>
		/// Name: CameraAnimSections
		/// Type: TArray<UMovieSceneSection>
		/// Offset: 0x28
		/// Size: 0x10
		/// SubElement Size: 0x40
		/// </summary>
		public TArray<UMovieSceneSection> CameraAnimSections => new TArray<UMovieSceneSection>(BaseAddress+0x28);
		
	}


	/// <summary>
	/// UMovieSceneCameraCutSection:UMovieSceneSection
	/// Size: 0x50
	/// Properties: 1
	/// </summary>
	public class UMovieSceneCameraCutSection:UMovieSceneSection
	{
		public override int ObjectSize => 80;
		/// <summary>
		/// Name: CameraGuid
		/// Type: StructProperty
		/// Offset: 0x40
		/// Size: 0x10
		/// </summary>
		public FGuid CameraGuid => ReadStruct<FGuid>(0x40);
		
	}


	/// <summary>
	/// UMovieSceneCameraCutTrack:UMovieSceneNameableTrack
	/// Size: 0x38
	/// Properties: 1
	/// </summary>
	public class UMovieSceneCameraCutTrack:UMovieSceneNameableTrack
	{
		public override int ObjectSize => 56;
		/// <summary>
		/// Name: Sections
		/// Type: TArray<UMovieSceneSection>
		/// Offset: 0x28
		/// Size: 0x10
		/// SubElement Size: 0x40
		/// </summary>
		public TArray<UMovieSceneSection> Sections => new TArray<UMovieSceneSection>(BaseAddress+0x28);
		
	}


	/// <summary>
	/// UMovieSceneCameraShakeSection:UMovieSceneSection
	/// Size: 0x60
	/// Properties: 4
	/// </summary>
	public class UMovieSceneCameraShakeSection:UMovieSceneSection
	{
		public override int ObjectSize => 96;
		/// <summary>
		/// Name: ShakeClass
		/// Type: ClassProperty
		/// Offset: 0x40
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: PlayScale
		/// Type: FloatProperty
		/// Offset: 0x48
		/// Size: 0x04
		/// </summary>
		public float PlayScale
		{
			get
			{
				return ReadSingle(0x48);
			}
			set
			{
				WriteSingle(0x48,value);
			}
		}
		
		/// <summary>
		/// Name: PlaySpace
		/// Type: ByteProperty
		/// Offset: 0x4C
		/// Size: 0x01
		/// </summary>
		public byte PlaySpace
		{
			get
			{
				return ReadByte(0x4C);
			}
			set
			{
				WriteByte(0x4C,value);
			}
		}
		
		/// <summary>
		/// Name: UserDefinedPlaySpace
		/// Type: StructProperty
		/// Offset: 0x50
		/// Size: 0x0C
		/// </summary>
		public FRotator UserDefinedPlaySpace => ReadStruct<FRotator>(0x50);
		
	}


	/// <summary>
	/// UMovieSceneCameraShakeTrack:UMovieSceneNameableTrack
	/// Size: 0x38
	/// Properties: 1
	/// </summary>
	public class UMovieSceneCameraShakeTrack:UMovieSceneNameableTrack
	{
		public override int ObjectSize => 56;
		/// <summary>
		/// Name: CameraShakeSections
		/// Type: TArray<UMovieSceneSection>
		/// Offset: 0x28
		/// Size: 0x10
		/// SubElement Size: 0x40
		/// </summary>
		public TArray<UMovieSceneSection> CameraShakeSections => new TArray<UMovieSceneSection>(BaseAddress+0x28);
		
	}


	/// <summary>
	/// UMovieSceneColorSection:UMovieSceneSection
	/// Size: 0x228
	/// Properties: 4
	/// </summary>
	public class UMovieSceneColorSection:UMovieSceneSection
	{
		public override int ObjectSize => 552;
		/// <summary>
		/// Name: RedCurve
		/// Type: StructProperty
		/// Offset: 0x48
		/// Size: 0x78
		/// </summary>
		public FRichCurve RedCurve => ReadStruct<FRichCurve>(0x48);
		
		/// <summary>
		/// Name: GreenCurve
		/// Type: StructProperty
		/// Offset: 0xC0
		/// Size: 0x78
		/// </summary>
		public FRichCurve GreenCurve => ReadStruct<FRichCurve>(0xC0);
		
		/// <summary>
		/// Name: BlueCurve
		/// Type: StructProperty
		/// Offset: 0x138
		/// Size: 0x78
		/// </summary>
		public FRichCurve BlueCurve => ReadStruct<FRichCurve>(0x138);
		
		/// <summary>
		/// Name: AlphaCurve
		/// Type: StructProperty
		/// Offset: 0x1B0
		/// Size: 0x78
		/// </summary>
		public FRichCurve AlphaCurve => ReadStruct<FRichCurve>(0x1B0);
		
	}


	/// <summary>
	/// UMovieSceneEventSection:UMovieSceneSection
	/// Size: 0xA8
	/// Properties: 1
	/// </summary>
	public class UMovieSceneEventSection:UMovieSceneSection
	{
		public override int ObjectSize => 168;
		/// <summary>
		/// Name: Events
		/// Type: StructProperty
		/// Offset: 0x40
		/// Size: 0x68
		/// </summary>
		public FNameCurve Events => ReadStruct<FNameCurve>(0x40);
		
	}


	/// <summary>
	/// UMovieSceneEventTrack:UMovieSceneNameableTrack
	/// Size: 0x40
	/// Properties: 3
	/// </summary>
	public class UMovieSceneEventTrack:UMovieSceneNameableTrack
	{
		public override int ObjectSize => 64;
		/// <summary>
		/// Name: bFireEventsWhenForwards
		/// Type: BoolProperty
		/// Offset: 0x28
		/// Size: 0x01
		/// </summary>
		public bool bFireEventsWhenForwards => (ReadByte(0x0028) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bFireEventsWhenBackwards
		/// Type: BoolProperty
		/// Offset: 0x28
		/// Size: 0x01
		/// </summary>
		public bool bFireEventsWhenBackwards => (ReadByte(0x0028) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: Sections
		/// Type: TArray<UMovieSceneSection>
		/// Offset: 0x30
		/// Size: 0x10
		/// SubElement Size: 0x40
		/// </summary>
		public TArray<UMovieSceneSection> Sections => new TArray<UMovieSceneSection>(BaseAddress+0x30);
		
	}


	/// <summary>
	/// UMovieSceneFloatSection:UMovieSceneSection
	/// Size: 0xC0
	/// Properties: 1
	/// </summary>
	public class UMovieSceneFloatSection:UMovieSceneSection
	{
		public override int ObjectSize => 192;
		/// <summary>
		/// Name: FloatCurve
		/// Type: StructProperty
		/// Offset: 0x48
		/// Size: 0x78
		/// </summary>
		public FRichCurve FloatCurve => ReadStruct<FRichCurve>(0x48);
		
	}


	/// <summary>
	/// UMovieSceneFadeSection:UMovieSceneFloatSection
	/// Size: 0xD8
	/// Properties: 2
	/// </summary>
	public class UMovieSceneFadeSection:UMovieSceneFloatSection
	{
		public override int ObjectSize => 216;
		/// <summary>
		/// Name: FadeColor
		/// Type: StructProperty
		/// Offset: 0xC0
		/// Size: 0x10
		/// </summary>
		public FLinearColor FadeColor => ReadStruct<FLinearColor>(0xC0);
		
		/// <summary>
		/// Name: bFadeAudio
		/// Type: BoolProperty
		/// Offset: 0xD0
		/// Size: 0x01
		/// </summary>
		public bool bFadeAudio => (ReadByte(0x00D0) & 0x01) == 0x01;
		
	}


	/// <summary>
	/// UMovieSceneSlomoSection:UMovieSceneFloatSection
	/// Size: 0xC0
	/// Properties: 0
	/// </summary>
	public class UMovieSceneSlomoSection:UMovieSceneFloatSection
	{
		public override int ObjectSize => 192;
	}


	/// <summary>
	/// UMovieSceneLevelVisibilitySection:UMovieSceneSection
	/// Size: 0x58
	/// Properties: 2
	/// </summary>
	public class UMovieSceneLevelVisibilitySection:UMovieSceneSection
	{
		public override int ObjectSize => 88;
		/// <summary>
		/// Name: Visibility
		/// Type: ByteProperty
		/// Offset: 0x40
		/// Size: 0x01
		/// </summary>
		public byte Visibility
		{
			get
			{
				return ReadByte(0x40);
			}
			set
			{
				WriteByte(0x40,value);
			}
		}
		
		/// <summary>
		/// Name: LevelNames
		/// Type: TArray<FName>
		/// Offset: 0x48
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		public TArray<FName> LevelNames => new TArray<FName>(BaseAddress+0x48);
		
	}


	/// <summary>
	/// UMovieScenePropertyTrack:UMovieSceneNameableTrack
	/// Size: 0x50
	/// Properties: 3
	/// </summary>
	public class UMovieScenePropertyTrack:UMovieSceneNameableTrack
	{
		public override int ObjectSize => 80;
		/// <summary>
		/// Name: PropertyName
		/// Type: NameProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: PropertyPath
		/// Type: StrProperty
		/// Offset: 0x30
		/// Size: 0x10
		/// </summary>
		public FString PropertyPath => new FString(BaseAddress+0x30);
		
		/// <summary>
		/// Name: Sections
		/// Type: TArray<UMovieSceneSection>
		/// Offset: 0x40
		/// Size: 0x10
		/// SubElement Size: 0x40
		/// </summary>
		public TArray<UMovieSceneSection> Sections => new TArray<UMovieSceneSection>(BaseAddress+0x40);
		
	}


	/// <summary>
	/// UMovieSceneLevelVisibilityTrack:UMovieSceneNameableTrack
	/// Size: 0x38
	/// Properties: 1
	/// </summary>
	public class UMovieSceneLevelVisibilityTrack:UMovieSceneNameableTrack
	{
		public override int ObjectSize => 56;
		/// <summary>
		/// Name: Sections
		/// Type: TArray<UMovieSceneSection>
		/// Offset: 0x28
		/// Size: 0x10
		/// SubElement Size: 0x40
		/// </summary>
		public TArray<UMovieSceneSection> Sections => new TArray<UMovieSceneSection>(BaseAddress+0x28);
		
	}


	/// <summary>
	/// UMovieSceneParameterSection:UMovieSceneSection
	/// Size: 0x70
	/// Properties: 3
	/// </summary>
	public class UMovieSceneParameterSection:UMovieSceneSection
	{
		public override int ObjectSize => 112;
		/// <summary>
		/// Name: ScalarParameterNamesAndCurves
		/// Type: TArray<FScalarParameterNameAndCurve>
		/// Offset: 0x40
		/// Size: 0x10
		/// SubElement Size: 0x88
		/// </summary>
		public TArray<FScalarParameterNameAndCurve> ScalarParameterNamesAndCurves => new TArray<FScalarParameterNameAndCurve>(BaseAddress+0x40);
		
		/// <summary>
		/// Name: VectorParameterNamesAndCurves
		/// Type: TArray<FVectorParameterNameAndCurves>
		/// Offset: 0x50
		/// Size: 0x10
		/// SubElement Size: 0x178
		/// </summary>
		public TArray<FVectorParameterNameAndCurves> VectorParameterNamesAndCurves => new TArray<FVectorParameterNameAndCurves>(BaseAddress+0x50);
		
		/// <summary>
		/// Name: ColorParameterNamesAndCurves
		/// Type: TArray<FColorParameterNameAndCurves>
		/// Offset: 0x60
		/// Size: 0x10
		/// SubElement Size: 0x1F0
		/// </summary>
		public TArray<FColorParameterNameAndCurves> ColorParameterNamesAndCurves => new TArray<FColorParameterNameAndCurves>(BaseAddress+0x60);
		
	}


	/// <summary>
	/// UMovieSceneMaterialTrack:UMovieSceneNameableTrack
	/// Size: 0x38
	/// Properties: 1
	/// </summary>
	public class UMovieSceneMaterialTrack:UMovieSceneNameableTrack
	{
		public override int ObjectSize => 56;
		/// <summary>
		/// Name: Sections
		/// Type: TArray<UMovieSceneSection>
		/// Offset: 0x28
		/// Size: 0x10
		/// SubElement Size: 0x40
		/// </summary>
		public TArray<UMovieSceneSection> Sections => new TArray<UMovieSceneSection>(BaseAddress+0x28);
		
	}


	/// <summary>
	/// UMovieSceneComponentMaterialTrack:UMovieSceneMaterialTrack
	/// Size: 0x40
	/// Properties: 1
	/// </summary>
	public class UMovieSceneComponentMaterialTrack:UMovieSceneMaterialTrack
	{
		public override int ObjectSize => 64;
		/// <summary>
		/// Name: MaterialIndex
		/// Type: IntProperty
		/// Offset: 0x38
		/// Size: 0x04
		/// </summary>
		public int MaterialIndex
		{
			get
			{
				return ReadInt32(0x38);
			}
			set
			{
				WriteInt32(0x38,value);
			}
		}
		
	}


	/// <summary>
	/// UMovieSceneParticleParameterTrack:UMovieSceneNameableTrack
	/// Size: 0x38
	/// Properties: 1
	/// </summary>
	public class UMovieSceneParticleParameterTrack:UMovieSceneNameableTrack
	{
		public override int ObjectSize => 56;
		/// <summary>
		/// Name: Sections
		/// Type: TArray<UMovieSceneSection>
		/// Offset: 0x28
		/// Size: 0x10
		/// SubElement Size: 0x40
		/// </summary>
		public TArray<UMovieSceneSection> Sections => new TArray<UMovieSceneSection>(BaseAddress+0x28);
		
	}


	/// <summary>
	/// UMovieSceneParticleSection:UMovieSceneSection
	/// Size: 0xB0
	/// Properties: 1
	/// </summary>
	public class UMovieSceneParticleSection:UMovieSceneSection
	{
		public override int ObjectSize => 176;
		/// <summary>
		/// Name: ParticleKeys
		/// Type: StructProperty
		/// Offset: 0x40
		/// Size: 0x70
		/// </summary>
		public FIntegralCurve ParticleKeys => ReadStruct<FIntegralCurve>(0x40);
		
	}


	/// <summary>
	/// UMovieSceneParticleTrack:UMovieSceneNameableTrack
	/// Size: 0x38
	/// Properties: 1
	/// </summary>
	public class UMovieSceneParticleTrack:UMovieSceneNameableTrack
	{
		public override int ObjectSize => 56;
		/// <summary>
		/// Name: ParticleSections
		/// Type: TArray<UMovieSceneSection>
		/// Offset: 0x28
		/// Size: 0x10
		/// SubElement Size: 0x40
		/// </summary>
		public TArray<UMovieSceneSection> ParticleSections => new TArray<UMovieSceneSection>(BaseAddress+0x28);
		
	}


	/// <summary>
	/// UMovieScene3DTransformTrack:UMovieScenePropertyTrack
	/// Size: 0x50
	/// Properties: 0
	/// </summary>
	public class UMovieScene3DTransformTrack:UMovieScenePropertyTrack
	{
		public override int ObjectSize => 80;
	}


	/// <summary>
	/// UMovieSceneActorReferenceTrack:UMovieScenePropertyTrack
	/// Size: 0x50
	/// Properties: 0
	/// </summary>
	public class UMovieSceneActorReferenceTrack:UMovieScenePropertyTrack
	{
		public override int ObjectSize => 80;
	}


	/// <summary>
	/// UMovieSceneBoolTrack:UMovieScenePropertyTrack
	/// Size: 0x50
	/// Properties: 0
	/// </summary>
	public class UMovieSceneBoolTrack:UMovieScenePropertyTrack
	{
		public override int ObjectSize => 80;
	}


	/// <summary>
	/// UMovieSceneVisibilityTrack:UMovieSceneBoolTrack
	/// Size: 0x50
	/// Properties: 0
	/// </summary>
	public class UMovieSceneVisibilityTrack:UMovieSceneBoolTrack
	{
		public override int ObjectSize => 80;
	}


	/// <summary>
	/// UMovieSceneByteTrack:UMovieScenePropertyTrack
	/// Size: 0x58
	/// Properties: 1
	/// </summary>
	public class UMovieSceneByteTrack:UMovieScenePropertyTrack
	{
		public override int ObjectSize => 88;
		/// <summary>
		/// Name: Enum
		/// Type: ObjectProperty
		/// Offset: 0x50
		/// Size: 0x08
		/// </summary>
		public UEnum Enum => ReadUObject<UEnum>(0x50);
		
	}


	/// <summary>
	/// UMovieSceneColorTrack:UMovieScenePropertyTrack
	/// Size: 0x58
	/// Properties: 1
	/// </summary>
	public class UMovieSceneColorTrack:UMovieScenePropertyTrack
	{
		public override int ObjectSize => 88;
		/// <summary>
		/// Name: bIsSlateColor
		/// Type: BoolProperty
		/// Offset: 0x50
		/// Size: 0x01
		/// </summary>
		public bool bIsSlateColor
		{
			get
			{
				return ReadBool(0x50);
			}
			set
			{
				WriteBool(0x50,value);
			}
		}
		
	}


	/// <summary>
	/// UMovieSceneFloatTrack:UMovieScenePropertyTrack
	/// Size: 0x50
	/// Properties: 0
	/// </summary>
	public class UMovieSceneFloatTrack:UMovieScenePropertyTrack
	{
		public override int ObjectSize => 80;
	}


	/// <summary>
	/// UMovieSceneFadeTrack:UMovieSceneFloatTrack
	/// Size: 0x50
	/// Properties: 0
	/// </summary>
	public class UMovieSceneFadeTrack:UMovieSceneFloatTrack
	{
		public override int ObjectSize => 80;
	}


	/// <summary>
	/// UMovieSceneSlomoTrack:UMovieSceneFloatTrack
	/// Size: 0x50
	/// Properties: 0
	/// </summary>
	public class UMovieSceneSlomoTrack:UMovieSceneFloatTrack
	{
		public override int ObjectSize => 80;
	}


	/// <summary>
	/// UMovieSceneVectorTrack:UMovieScenePropertyTrack
	/// Size: 0x58
	/// Properties: 1
	/// </summary>
	public class UMovieSceneVectorTrack:UMovieScenePropertyTrack
	{
		public override int ObjectSize => 88;
		/// <summary>
		/// Name: NumChannelsUsed
		/// Type: IntProperty
		/// Offset: 0x50
		/// Size: 0x04
		/// </summary>
		public int NumChannelsUsed
		{
			get
			{
				return ReadInt32(0x50);
			}
			set
			{
				WriteInt32(0x50,value);
			}
		}
		
	}


	/// <summary>
	/// UMovieSceneSkeletalAnimationSection:UMovieSceneSection
	/// Size: 0x60
	/// Properties: 6
	/// </summary>
	public class UMovieSceneSkeletalAnimationSection:UMovieSceneSection
	{
		public override int ObjectSize => 96;
		/// <summary>
		/// Name: AnimSequence
		/// Type: ObjectProperty
		/// Offset: 0x40
		/// Size: 0x08
		/// </summary>
		public UAnimSequence AnimSequence => ReadUObject<UAnimSequence>(0x40);
		
		/// <summary>
		/// Name: StartOffset
		/// Type: FloatProperty
		/// Offset: 0x48
		/// Size: 0x04
		/// </summary>
		public float StartOffset
		{
			get
			{
				return ReadSingle(0x48);
			}
			set
			{
				WriteSingle(0x48,value);
			}
		}
		
		/// <summary>
		/// Name: EndOffset
		/// Type: FloatProperty
		/// Offset: 0x4C
		/// Size: 0x04
		/// </summary>
		public float EndOffset
		{
			get
			{
				return ReadSingle(0x4C);
			}
			set
			{
				WriteSingle(0x4C,value);
			}
		}
		
		/// <summary>
		/// Name: PlayRate
		/// Type: FloatProperty
		/// Offset: 0x50
		/// Size: 0x04
		/// </summary>
		public float PlayRate
		{
			get
			{
				return ReadSingle(0x50);
			}
			set
			{
				WriteSingle(0x50,value);
			}
		}
		
		/// <summary>
		/// Name: bReverse
		/// Type: BoolProperty
		/// Offset: 0x54
		/// Size: 0x01
		/// </summary>
		public bool bReverse => (ReadByte(0x0054) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: SlotName
		/// Type: NameProperty
		/// Offset: 0x58
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// UMovieSceneSkeletalAnimationTrack:UMovieSceneNameableTrack
	/// Size: 0x38
	/// Properties: 1
	/// </summary>
	public class UMovieSceneSkeletalAnimationTrack:UMovieSceneNameableTrack
	{
		public override int ObjectSize => 56;
		/// <summary>
		/// Name: AnimationSections
		/// Type: TArray<UMovieSceneSection>
		/// Offset: 0x28
		/// Size: 0x10
		/// SubElement Size: 0x40
		/// </summary>
		public TArray<UMovieSceneSection> AnimationSections => new TArray<UMovieSceneSection>(BaseAddress+0x28);
		
	}


	/// <summary>
	/// UMovieSceneSpawnTrack:UMovieSceneTrack
	/// Size: 0x48
	/// Properties: 2
	/// </summary>
	public class UMovieSceneSpawnTrack:UMovieSceneTrack
	{
		public override int ObjectSize => 72;
		/// <summary>
		/// Name: Sections
		/// Type: TArray<UMovieSceneSection>
		/// Offset: 0x28
		/// Size: 0x10
		/// SubElement Size: 0x40
		/// </summary>
		public TArray<UMovieSceneSection> Sections => new TArray<UMovieSceneSection>(BaseAddress+0x28);
		
		/// <summary>
		/// Name: ObjectGuid
		/// Type: StructProperty
		/// Offset: 0x38
		/// Size: 0x10
		/// </summary>
		public FGuid ObjectGuid => ReadStruct<FGuid>(0x38);
		
	}


	/// <summary>
	/// UMovieSceneSubSection:UMovieSceneSection
	/// Size: 0x88
	/// Properties: 7
	/// </summary>
	public class UMovieSceneSubSection:UMovieSceneSection
	{
		public override int ObjectSize => 136;
		/// <summary>
		/// Name: StartOffset
		/// Type: FloatProperty
		/// Offset: 0x40
		/// Size: 0x04
		/// </summary>
		public float StartOffset
		{
			get
			{
				return ReadSingle(0x40);
			}
			set
			{
				WriteSingle(0x40,value);
			}
		}
		
		/// <summary>
		/// Name: TimeScale
		/// Type: FloatProperty
		/// Offset: 0x44
		/// Size: 0x04
		/// </summary>
		public float TimeScale
		{
			get
			{
				return ReadSingle(0x44);
			}
			set
			{
				WriteSingle(0x44,value);
			}
		}
		
		/// <summary>
		/// Name: PrerollTime
		/// Type: FloatProperty
		/// Offset: 0x48
		/// Size: 0x04
		/// </summary>
		public float PrerollTime
		{
			get
			{
				return ReadSingle(0x48);
			}
			set
			{
				WriteSingle(0x48,value);
			}
		}
		
		/// <summary>
		/// Name: SubSequence
		/// Type: ObjectProperty
		/// Offset: 0x50
		/// Size: 0x08
		/// </summary>
		public UMovieSceneSequence SubSequence => ReadUObject<UMovieSceneSequence>(0x50);
		
		/// <summary>
		/// Name: NameOfActorToRecord
		/// Type: StrProperty
		/// Offset: 0x58
		/// Size: 0x10
		/// </summary>
		public FString NameOfActorToRecord => new FString(BaseAddress+0x58);
		
		/// <summary>
		/// Name: TargetSequenceName
		/// Type: StrProperty
		/// Offset: 0x68
		/// Size: 0x10
		/// </summary>
		public FString TargetSequenceName => new FString(BaseAddress+0x68);
		
		/// <summary>
		/// Name: TargetPathToRecordTo
		/// Type: StructProperty
		/// Offset: 0x78
		/// Size: 0x10
		/// </summary>
		public FDirectoryPath TargetPathToRecordTo => ReadStruct<FDirectoryPath>(0x78);
		
	}


	/// <summary>
	/// UMovieSceneCinematicShotSection:UMovieSceneSubSection
	/// Size: 0xA0
	/// Properties: 1
	/// </summary>
	public class UMovieSceneCinematicShotSection:UMovieSceneSubSection
	{
		public override int ObjectSize => 160;
		/// <summary>
		/// Name: DisplayName
		/// Type: TextProperty
		/// Offset: 0x88
		/// Size: 0x18
		/// </summary>
		
	}


	/// <summary>
	/// UMovieSceneSubTrack:UMovieSceneNameableTrack
	/// Size: 0x38
	/// Properties: 1
	/// </summary>
	public class UMovieSceneSubTrack:UMovieSceneNameableTrack
	{
		public override int ObjectSize => 56;
		/// <summary>
		/// Name: Sections
		/// Type: TArray<UMovieSceneSection>
		/// Offset: 0x28
		/// Size: 0x10
		/// SubElement Size: 0x40
		/// </summary>
		public TArray<UMovieSceneSection> Sections => new TArray<UMovieSceneSection>(BaseAddress+0x28);
		
	}


	/// <summary>
	/// UMovieSceneCinematicShotTrack:UMovieSceneSubTrack
	/// Size: 0x38
	/// Properties: 0
	/// </summary>
	public class UMovieSceneCinematicShotTrack:UMovieSceneSubTrack
	{
		public override int ObjectSize => 56;
	}


	/// <summary>
	/// UMovieSceneVectorSection:UMovieSceneSection
	/// Size: 0x230
	/// Properties: 2
	/// </summary>
	public class UMovieSceneVectorSection:UMovieSceneSection
	{
		public override int ObjectSize => 560;
		/// <summary>
		/// Name: Curves
		/// Type: StructProperty
		/// Offset: 0x48
		/// Size: 0x78
		/// </summary>
		public FRichCurve Curves => ReadStruct<FRichCurve>(0x48);
		
		/// <summary>
		/// Name: ChannelsUsed
		/// Type: IntProperty
		/// Offset: 0x228
		/// Size: 0x04
		/// </summary>
		public int ChannelsUsed
		{
			get
			{
				return ReadInt32(0x228);
			}
			set
			{
				WriteInt32(0x228,value);
			}
		}
		
	}


	/// <summary>
	/// UAsyncTaskDownloadImage:UBlueprintAsyncActionBase
	/// Size: 0x48
	/// Properties: 0
	/// </summary>
	public class UAsyncTaskDownloadImage:UBlueprintAsyncActionBase
	{
		public override int ObjectSize => 72;
	}


	/// <summary>
	/// UDragDropOperation:UObject
	/// Size: 0x88
	/// Properties: 5
	/// </summary>
	public class UDragDropOperation:UObject
	{
		public override int ObjectSize => 136;
		/// <summary>
		/// Name: Tag
		/// Type: StrProperty
		/// Offset: 0x28
		/// Size: 0x10
		/// </summary>
		public FString Tag => new FString(BaseAddress+0x28);
		
		/// <summary>
		/// Name: Payload
		/// Type: ObjectProperty
		/// Offset: 0x38
		/// Size: 0x08
		/// </summary>
		public UObject Payload => ReadUObject<UObject>(0x38);
		
		/// <summary>
		/// Name: DefaultDragVisual
		/// Type: ObjectProperty
		/// Offset: 0x40
		/// Size: 0x08
		/// </summary>
		public UWidget DefaultDragVisual => ReadUObject<UWidget>(0x40);
		
		/// <summary>
		/// Name: Pivot
		/// Type: ByteProperty
		/// Offset: 0x48
		/// Size: 0x01
		/// </summary>
		public byte Pivot
		{
			get
			{
				return ReadByte(0x48);
			}
			set
			{
				WriteByte(0x48,value);
			}
		}
		
		/// <summary>
		/// Name: Offset
		/// Type: StructProperty
		/// Offset: 0x4C
		/// Size: 0x08
		/// </summary>
		public FVector2D Offset => ReadStruct<FVector2D>(0x4C);
		
	}


	/// <summary>
	/// UMovieScene2DTransformSection:UMovieSceneSection
	/// Size: 0x390
	/// Properties: 4
	/// </summary>
	public class UMovieScene2DTransformSection:UMovieSceneSection
	{
		public override int ObjectSize => 912;
		/// <summary>
		/// Name: Translation
		/// Type: StructProperty
		/// Offset: 0x48
		/// Size: 0x78
		/// </summary>
		public FRichCurve Translation => ReadStruct<FRichCurve>(0x48);
		
		/// <summary>
		/// Name: Rotation
		/// Type: StructProperty
		/// Offset: 0x138
		/// Size: 0x78
		/// </summary>
		public FRichCurve Rotation => ReadStruct<FRichCurve>(0x138);
		
		/// <summary>
		/// Name: Scale
		/// Type: StructProperty
		/// Offset: 0x1B0
		/// Size: 0x78
		/// </summary>
		public FRichCurve Scale => ReadStruct<FRichCurve>(0x1B0);
		
		/// <summary>
		/// Name: Shear
		/// Type: StructProperty
		/// Offset: 0x2A0
		/// Size: 0x78
		/// </summary>
		public FRichCurve Shear => ReadStruct<FRichCurve>(0x2A0);
		
	}


	/// <summary>
	/// UMovieScene2DTransformTrack:UMovieScenePropertyTrack
	/// Size: 0x50
	/// Properties: 0
	/// </summary>
	public class UMovieScene2DTransformTrack:UMovieScenePropertyTrack
	{
		public override int ObjectSize => 80;
	}


	/// <summary>
	/// UMovieSceneMarginSection:UMovieSceneSection
	/// Size: 0x228
	/// Properties: 4
	/// </summary>
	public class UMovieSceneMarginSection:UMovieSceneSection
	{
		public override int ObjectSize => 552;
		/// <summary>
		/// Name: TopCurve
		/// Type: StructProperty
		/// Offset: 0x48
		/// Size: 0x78
		/// </summary>
		public FRichCurve TopCurve => ReadStruct<FRichCurve>(0x48);
		
		/// <summary>
		/// Name: LeftCurve
		/// Type: StructProperty
		/// Offset: 0xC0
		/// Size: 0x78
		/// </summary>
		public FRichCurve LeftCurve => ReadStruct<FRichCurve>(0xC0);
		
		/// <summary>
		/// Name: RightCurve
		/// Type: StructProperty
		/// Offset: 0x138
		/// Size: 0x78
		/// </summary>
		public FRichCurve RightCurve => ReadStruct<FRichCurve>(0x138);
		
		/// <summary>
		/// Name: BottomCurve
		/// Type: StructProperty
		/// Offset: 0x1B0
		/// Size: 0x78
		/// </summary>
		public FRichCurve BottomCurve => ReadStruct<FRichCurve>(0x1B0);
		
	}


	/// <summary>
	/// UMovieSceneMarginTrack:UMovieScenePropertyTrack
	/// Size: 0x50
	/// Properties: 0
	/// </summary>
	public class UMovieSceneMarginTrack:UMovieScenePropertyTrack
	{
		public override int ObjectSize => 80;
	}


	/// <summary>
	/// UMovieSceneWidgetMaterialTrack:UMovieSceneMaterialTrack
	/// Size: 0x50
	/// Properties: 2
	/// </summary>
	public class UMovieSceneWidgetMaterialTrack:UMovieSceneMaterialTrack
	{
		public override int ObjectSize => 80;
		/// <summary>
		/// Name: BrushPropertyNamePath
		/// Type: TArray<FName>
		/// Offset: 0x38
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		public TArray<FName> BrushPropertyNamePath => new TArray<FName>(BaseAddress+0x38);
		
		/// <summary>
		/// Name: TrackName
		/// Type: NameProperty
		/// Offset: 0x48
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// UNamedSlotInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UNamedSlotInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UPropertyBinding:UObject
	/// Size: 0x48
	/// Properties: 2
	/// </summary>
	public class UPropertyBinding:UObject
	{
		public override int ObjectSize => 72;
		/// <summary>
		/// Name: SourcePath
		/// Type: StructProperty
		/// Offset: 0x30
		/// Size: 0x10
		/// </summary>
		public FDynamicPropertyPath SourcePath => ReadStruct<FDynamicPropertyPath>(0x30);
		
		/// <summary>
		/// Name: DestinationProperty
		/// Type: NameProperty
		/// Offset: 0x40
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// UBoolBinding:UPropertyBinding
	/// Size: 0x48
	/// Properties: 0
	/// </summary>
	public class UBoolBinding:UPropertyBinding
	{
		public override int ObjectSize => 72;
	}


	/// <summary>
	/// UBrushBinding:UPropertyBinding
	/// Size: 0x50
	/// Properties: 0
	/// </summary>
	public class UBrushBinding:UPropertyBinding
	{
		public override int ObjectSize => 80;
	}


	/// <summary>
	/// UCheckedStateBinding:UPropertyBinding
	/// Size: 0x50
	/// Properties: 0
	/// </summary>
	public class UCheckedStateBinding:UPropertyBinding
	{
		public override int ObjectSize => 80;
	}


	/// <summary>
	/// UColorBinding:UPropertyBinding
	/// Size: 0x50
	/// Properties: 0
	/// </summary>
	public class UColorBinding:UPropertyBinding
	{
		public override int ObjectSize => 80;
	}


	/// <summary>
	/// UFloatBinding:UPropertyBinding
	/// Size: 0x48
	/// Properties: 0
	/// </summary>
	public class UFloatBinding:UPropertyBinding
	{
		public override int ObjectSize => 72;
	}


	/// <summary>
	/// UInt32Binding:UPropertyBinding
	/// Size: 0x48
	/// Properties: 0
	/// </summary>
	public class UInt32Binding:UPropertyBinding
	{
		public override int ObjectSize => 72;
	}


	/// <summary>
	/// UMouseCursorBinding:UPropertyBinding
	/// Size: 0x48
	/// Properties: 0
	/// </summary>
	public class UMouseCursorBinding:UPropertyBinding
	{
		public override int ObjectSize => 72;
	}


	/// <summary>
	/// UTextBinding:UPropertyBinding
	/// Size: 0x50
	/// Properties: 0
	/// </summary>
	public class UTextBinding:UPropertyBinding
	{
		public override int ObjectSize => 80;
	}


	/// <summary>
	/// UVisibilityBinding:UPropertyBinding
	/// Size: 0x48
	/// Properties: 0
	/// </summary>
	public class UVisibilityBinding:UPropertyBinding
	{
		public override int ObjectSize => 72;
	}


	/// <summary>
	/// UWidgetBinding:UPropertyBinding
	/// Size: 0x48
	/// Properties: 0
	/// </summary>
	public class UWidgetBinding:UPropertyBinding
	{
		public override int ObjectSize => 72;
	}


	/// <summary>
	/// URichTextBlockDecorator:UObject
	/// Size: 0x30
	/// Properties: 2
	/// </summary>
	public class URichTextBlockDecorator:UObject
	{
		public override int ObjectSize => 48;
		/// <summary>
		/// Name: bReveal
		/// Type: BoolProperty
		/// Offset: 0x28
		/// Size: 0x01
		/// </summary>
		public bool bReveal
		{
			get
			{
				return ReadBool(0x28);
			}
			set
			{
				WriteBool(0x28,value);
			}
		}
		
		/// <summary>
		/// Name: RevealedIndex
		/// Type: IntProperty
		/// Offset: 0x2C
		/// Size: 0x04
		/// </summary>
		public int RevealedIndex
		{
			get
			{
				return ReadInt32(0x2C);
			}
			set
			{
				WriteInt32(0x2C,value);
			}
		}
		
	}


	/// <summary>
	/// USlateBlueprintLibrary:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class USlateBlueprintLibrary:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// USlateDataSheet:UObject
	/// Size: 0x430
	/// Properties: 1
	/// </summary>
	public class USlateDataSheet:UObject
	{
		public override int ObjectSize => 1072;
		/// <summary>
		/// Name: DataTexture
		/// Type: ObjectProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		public UTexture2D DataTexture => ReadUObject<UTexture2D>(0x28);
		
	}


	/// <summary>
	/// USlateVectorArtData:UObject
	/// Size: 0x60
	/// Properties: 5
	/// </summary>
	public class USlateVectorArtData:UObject
	{
		public override int ObjectSize => 96;
		/// <summary>
		/// Name: VertexData
		/// Type: TArray<FSlateMeshVertex>
		/// Offset: 0x28
		/// Size: 0x10
		/// SubElement Size: 0x3C
		/// </summary>
		public TArray<FSlateMeshVertex> VertexData => new TArray<FSlateMeshVertex>(BaseAddress+0x28);
		
		/// <summary>
		/// Name: IndexData
		/// Type: TArray<>
		/// Offset: 0x38
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: Material
		/// Type: ObjectProperty
		/// Offset: 0x48
		/// Size: 0x08
		/// </summary>
		public UMaterialInterface Material => ReadUObject<UMaterialInterface>(0x48);
		
		/// <summary>
		/// Name: ExtentMin
		/// Type: StructProperty
		/// Offset: 0x50
		/// Size: 0x08
		/// </summary>
		public FVector2D ExtentMin => ReadStruct<FVector2D>(0x50);
		
		/// <summary>
		/// Name: ExtentMax
		/// Type: StructProperty
		/// Offset: 0x58
		/// Size: 0x08
		/// </summary>
		public FVector2D ExtentMax => ReadStruct<FVector2D>(0x58);
		
	}


	/// <summary>
	/// UUMGSequencePlayer:UObject
	/// Size: 0x190
	/// Properties: 1
	/// </summary>
	public class UUMGSequencePlayer:UObject
	{
		public override int ObjectSize => 400;
		/// <summary>
		/// Name: Animation
		/// Type: ObjectProperty
		/// Offset: 0x48
		/// Size: 0x08
		/// </summary>
		public UWidgetAnimation Animation => ReadUObject<UWidgetAnimation>(0x48);
		
	}


	/// <summary>
	/// UPanelSlot:UVisual
	/// Size: 0x38
	/// Properties: 2
	/// </summary>
	public class UPanelSlot:UVisual
	{
		public override int ObjectSize => 56;
		/// <summary>
		/// Name: Parent
		/// Type: ObjectProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		public UPanelWidget Parent => ReadUObject<UPanelWidget>(0x28);
		
		/// <summary>
		/// Name: Content
		/// Type: ObjectProperty
		/// Offset: 0x30
		/// Size: 0x08
		/// </summary>
		public UWidget Content => ReadUObject<UWidget>(0x30);
		
	}


	/// <summary>
	/// UBorderSlot:UPanelSlot
	/// Size: 0x60
	/// Properties: 3
	/// </summary>
	public class UBorderSlot:UPanelSlot
	{
		public override int ObjectSize => 96;
		/// <summary>
		/// Name: Padding
		/// Type: StructProperty
		/// Offset: 0x38
		/// Size: 0x10
		/// </summary>
		public FMargin Padding => ReadStruct<FMargin>(0x38);
		
		/// <summary>
		/// Name: HorizontalAlignment
		/// Type: ByteProperty
		/// Offset: 0x48
		/// Size: 0x01
		/// </summary>
		public byte HorizontalAlignment
		{
			get
			{
				return ReadByte(0x48);
			}
			set
			{
				WriteByte(0x48,value);
			}
		}
		
		/// <summary>
		/// Name: VerticalAlignment
		/// Type: ByteProperty
		/// Offset: 0x49
		/// Size: 0x01
		/// </summary>
		public byte VerticalAlignment
		{
			get
			{
				return ReadByte(0x49);
			}
			set
			{
				WriteByte(0x49,value);
			}
		}
		
	}


	/// <summary>
	/// UButtonSlot:UPanelSlot
	/// Size: 0x60
	/// Properties: 3
	/// </summary>
	public class UButtonSlot:UPanelSlot
	{
		public override int ObjectSize => 96;
		/// <summary>
		/// Name: Padding
		/// Type: StructProperty
		/// Offset: 0x38
		/// Size: 0x10
		/// </summary>
		public FMargin Padding => ReadStruct<FMargin>(0x38);
		
		/// <summary>
		/// Name: HorizontalAlignment
		/// Type: ByteProperty
		/// Offset: 0x48
		/// Size: 0x01
		/// </summary>
		public byte HorizontalAlignment
		{
			get
			{
				return ReadByte(0x48);
			}
			set
			{
				WriteByte(0x48,value);
			}
		}
		
		/// <summary>
		/// Name: VerticalAlignment
		/// Type: ByteProperty
		/// Offset: 0x49
		/// Size: 0x01
		/// </summary>
		public byte VerticalAlignment
		{
			get
			{
				return ReadByte(0x49);
			}
			set
			{
				WriteByte(0x49,value);
			}
		}
		
	}


	/// <summary>
	/// UCanvasPanelSlot:UPanelSlot
	/// Size: 0x70
	/// Properties: 3
	/// </summary>
	public class UCanvasPanelSlot:UPanelSlot
	{
		public override int ObjectSize => 112;
		/// <summary>
		/// Name: LayoutData
		/// Type: StructProperty
		/// Offset: 0x38
		/// Size: 0x28
		/// </summary>
		public FAnchorData LayoutData => ReadStruct<FAnchorData>(0x38);
		
		/// <summary>
		/// Name: bAutoSize
		/// Type: BoolProperty
		/// Offset: 0x60
		/// Size: 0x01
		/// </summary>
		public bool bAutoSize
		{
			get
			{
				return ReadBool(0x60);
			}
			set
			{
				WriteBool(0x60,value);
			}
		}
		
		/// <summary>
		/// Name: ZOrder
		/// Type: IntProperty
		/// Offset: 0x64
		/// Size: 0x04
		/// </summary>
		public int ZOrder
		{
			get
			{
				return ReadInt32(0x64);
			}
			set
			{
				WriteInt32(0x64,value);
			}
		}
		
	}


	/// <summary>
	/// UGridSlot:UPanelSlot
	/// Size: 0x60
	/// Properties: 8
	/// </summary>
	public class UGridSlot:UPanelSlot
	{
		public override int ObjectSize => 96;
		/// <summary>
		/// Name: HorizontalAlignment
		/// Type: ByteProperty
		/// Offset: 0x38
		/// Size: 0x01
		/// </summary>
		public byte HorizontalAlignment
		{
			get
			{
				return ReadByte(0x38);
			}
			set
			{
				WriteByte(0x38,value);
			}
		}
		
		/// <summary>
		/// Name: VerticalAlignment
		/// Type: ByteProperty
		/// Offset: 0x39
		/// Size: 0x01
		/// </summary>
		public byte VerticalAlignment
		{
			get
			{
				return ReadByte(0x39);
			}
			set
			{
				WriteByte(0x39,value);
			}
		}
		
		/// <summary>
		/// Name: Row
		/// Type: IntProperty
		/// Offset: 0x3C
		/// Size: 0x04
		/// </summary>
		public int Row
		{
			get
			{
				return ReadInt32(0x3C);
			}
			set
			{
				WriteInt32(0x3C,value);
			}
		}
		
		/// <summary>
		/// Name: RowSpan
		/// Type: IntProperty
		/// Offset: 0x40
		/// Size: 0x04
		/// </summary>
		public int RowSpan
		{
			get
			{
				return ReadInt32(0x40);
			}
			set
			{
				WriteInt32(0x40,value);
			}
		}
		
		/// <summary>
		/// Name: Column
		/// Type: IntProperty
		/// Offset: 0x44
		/// Size: 0x04
		/// </summary>
		public int Column
		{
			get
			{
				return ReadInt32(0x44);
			}
			set
			{
				WriteInt32(0x44,value);
			}
		}
		
		/// <summary>
		/// Name: ColumnSpan
		/// Type: IntProperty
		/// Offset: 0x48
		/// Size: 0x04
		/// </summary>
		public int ColumnSpan
		{
			get
			{
				return ReadInt32(0x48);
			}
			set
			{
				WriteInt32(0x48,value);
			}
		}
		
		/// <summary>
		/// Name: Layer
		/// Type: IntProperty
		/// Offset: 0x4C
		/// Size: 0x04
		/// </summary>
		public int Layer
		{
			get
			{
				return ReadInt32(0x4C);
			}
			set
			{
				WriteInt32(0x4C,value);
			}
		}
		
		/// <summary>
		/// Name: Nudge
		/// Type: StructProperty
		/// Offset: 0x50
		/// Size: 0x08
		/// </summary>
		public FVector2D Nudge => ReadStruct<FVector2D>(0x50);
		
	}


	/// <summary>
	/// UHorizontalBoxSlot:UPanelSlot
	/// Size: 0x60
	/// Properties: 4
	/// </summary>
	public class UHorizontalBoxSlot:UPanelSlot
	{
		public override int ObjectSize => 96;
		/// <summary>
		/// Name: Padding
		/// Type: StructProperty
		/// Offset: 0x38
		/// Size: 0x10
		/// </summary>
		public FMargin Padding => ReadStruct<FMargin>(0x38);
		
		/// <summary>
		/// Name: Size
		/// Type: StructProperty
		/// Offset: 0x48
		/// Size: 0x08
		/// </summary>
		public FSlateChildSize Size => ReadStruct<FSlateChildSize>(0x48);
		
		/// <summary>
		/// Name: HorizontalAlignment
		/// Type: ByteProperty
		/// Offset: 0x50
		/// Size: 0x01
		/// </summary>
		public byte HorizontalAlignment
		{
			get
			{
				return ReadByte(0x50);
			}
			set
			{
				WriteByte(0x50,value);
			}
		}
		
		/// <summary>
		/// Name: VerticalAlignment
		/// Type: ByteProperty
		/// Offset: 0x51
		/// Size: 0x01
		/// </summary>
		public byte VerticalAlignment
		{
			get
			{
				return ReadByte(0x51);
			}
			set
			{
				WriteByte(0x51,value);
			}
		}
		
	}


	/// <summary>
	/// UOverlaySlot:UPanelSlot
	/// Size: 0x58
	/// Properties: 3
	/// </summary>
	public class UOverlaySlot:UPanelSlot
	{
		public override int ObjectSize => 88;
		/// <summary>
		/// Name: Padding
		/// Type: StructProperty
		/// Offset: 0x38
		/// Size: 0x10
		/// </summary>
		public FMargin Padding => ReadStruct<FMargin>(0x38);
		
		/// <summary>
		/// Name: HorizontalAlignment
		/// Type: ByteProperty
		/// Offset: 0x48
		/// Size: 0x01
		/// </summary>
		public byte HorizontalAlignment
		{
			get
			{
				return ReadByte(0x48);
			}
			set
			{
				WriteByte(0x48,value);
			}
		}
		
		/// <summary>
		/// Name: VerticalAlignment
		/// Type: ByteProperty
		/// Offset: 0x49
		/// Size: 0x01
		/// </summary>
		public byte VerticalAlignment
		{
			get
			{
				return ReadByte(0x49);
			}
			set
			{
				WriteByte(0x49,value);
			}
		}
		
	}


	/// <summary>
	/// USafeZoneSlot:UPanelSlot
	/// Size: 0x50
	/// Properties: 4
	/// </summary>
	public class USafeZoneSlot:UPanelSlot
	{
		public override int ObjectSize => 80;
		/// <summary>
		/// Name: bIsTitleSafe
		/// Type: BoolProperty
		/// Offset: 0x38
		/// Size: 0x01
		/// </summary>
		public bool bIsTitleSafe
		{
			get
			{
				return ReadBool(0x38);
			}
			set
			{
				WriteBool(0x38,value);
			}
		}
		
		/// <summary>
		/// Name: HAlign
		/// Type: ByteProperty
		/// Offset: 0x39
		/// Size: 0x01
		/// </summary>
		public byte HAlign
		{
			get
			{
				return ReadByte(0x39);
			}
			set
			{
				WriteByte(0x39,value);
			}
		}
		
		/// <summary>
		/// Name: VAlign
		/// Type: ByteProperty
		/// Offset: 0x3A
		/// Size: 0x01
		/// </summary>
		public byte VAlign
		{
			get
			{
				return ReadByte(0x3A);
			}
			set
			{
				WriteByte(0x3A,value);
			}
		}
		
		/// <summary>
		/// Name: Padding
		/// Type: StructProperty
		/// Offset: 0x3C
		/// Size: 0x10
		/// </summary>
		public FMargin Padding => ReadStruct<FMargin>(0x3C);
		
	}


	/// <summary>
	/// UScaleBoxSlot:UPanelSlot
	/// Size: 0x60
	/// Properties: 3
	/// </summary>
	public class UScaleBoxSlot:UPanelSlot
	{
		public override int ObjectSize => 96;
		/// <summary>
		/// Name: Padding
		/// Type: StructProperty
		/// Offset: 0x38
		/// Size: 0x10
		/// </summary>
		public FMargin Padding => ReadStruct<FMargin>(0x38);
		
		/// <summary>
		/// Name: HorizontalAlignment
		/// Type: ByteProperty
		/// Offset: 0x48
		/// Size: 0x01
		/// </summary>
		public byte HorizontalAlignment
		{
			get
			{
				return ReadByte(0x48);
			}
			set
			{
				WriteByte(0x48,value);
			}
		}
		
		/// <summary>
		/// Name: VerticalAlignment
		/// Type: ByteProperty
		/// Offset: 0x49
		/// Size: 0x01
		/// </summary>
		public byte VerticalAlignment
		{
			get
			{
				return ReadByte(0x49);
			}
			set
			{
				WriteByte(0x49,value);
			}
		}
		
	}


	/// <summary>
	/// UScrollBoxSlot:UPanelSlot
	/// Size: 0x58
	/// Properties: 2
	/// </summary>
	public class UScrollBoxSlot:UPanelSlot
	{
		public override int ObjectSize => 88;
		/// <summary>
		/// Name: Padding
		/// Type: StructProperty
		/// Offset: 0x38
		/// Size: 0x10
		/// </summary>
		public FMargin Padding => ReadStruct<FMargin>(0x38);
		
		/// <summary>
		/// Name: HorizontalAlignment
		/// Type: ByteProperty
		/// Offset: 0x48
		/// Size: 0x01
		/// </summary>
		public byte HorizontalAlignment
		{
			get
			{
				return ReadByte(0x48);
			}
			set
			{
				WriteByte(0x48,value);
			}
		}
		
	}


	/// <summary>
	/// USizeBoxSlot:UPanelSlot
	/// Size: 0x60
	/// Properties: 3
	/// </summary>
	public class USizeBoxSlot:UPanelSlot
	{
		public override int ObjectSize => 96;
		/// <summary>
		/// Name: Padding
		/// Type: StructProperty
		/// Offset: 0x38
		/// Size: 0x10
		/// </summary>
		public FMargin Padding => ReadStruct<FMargin>(0x38);
		
		/// <summary>
		/// Name: HorizontalAlignment
		/// Type: ByteProperty
		/// Offset: 0x48
		/// Size: 0x01
		/// </summary>
		public byte HorizontalAlignment
		{
			get
			{
				return ReadByte(0x48);
			}
			set
			{
				WriteByte(0x48,value);
			}
		}
		
		/// <summary>
		/// Name: VerticalAlignment
		/// Type: ByteProperty
		/// Offset: 0x49
		/// Size: 0x01
		/// </summary>
		public byte VerticalAlignment
		{
			get
			{
				return ReadByte(0x49);
			}
			set
			{
				WriteByte(0x49,value);
			}
		}
		
	}


	/// <summary>
	/// UUniformGridSlot:UPanelSlot
	/// Size: 0x50
	/// Properties: 4
	/// </summary>
	public class UUniformGridSlot:UPanelSlot
	{
		public override int ObjectSize => 80;
		/// <summary>
		/// Name: HorizontalAlignment
		/// Type: ByteProperty
		/// Offset: 0x38
		/// Size: 0x01
		/// </summary>
		public byte HorizontalAlignment
		{
			get
			{
				return ReadByte(0x38);
			}
			set
			{
				WriteByte(0x38,value);
			}
		}
		
		/// <summary>
		/// Name: VerticalAlignment
		/// Type: ByteProperty
		/// Offset: 0x39
		/// Size: 0x01
		/// </summary>
		public byte VerticalAlignment
		{
			get
			{
				return ReadByte(0x39);
			}
			set
			{
				WriteByte(0x39,value);
			}
		}
		
		/// <summary>
		/// Name: Row
		/// Type: IntProperty
		/// Offset: 0x3C
		/// Size: 0x04
		/// </summary>
		public int Row
		{
			get
			{
				return ReadInt32(0x3C);
			}
			set
			{
				WriteInt32(0x3C,value);
			}
		}
		
		/// <summary>
		/// Name: Column
		/// Type: IntProperty
		/// Offset: 0x40
		/// Size: 0x04
		/// </summary>
		public int Column
		{
			get
			{
				return ReadInt32(0x40);
			}
			set
			{
				WriteInt32(0x40,value);
			}
		}
		
	}


	/// <summary>
	/// UVerticalBoxSlot:UPanelSlot
	/// Size: 0x60
	/// Properties: 4
	/// </summary>
	public class UVerticalBoxSlot:UPanelSlot
	{
		public override int ObjectSize => 96;
		/// <summary>
		/// Name: Padding
		/// Type: StructProperty
		/// Offset: 0x38
		/// Size: 0x10
		/// </summary>
		public FMargin Padding => ReadStruct<FMargin>(0x38);
		
		/// <summary>
		/// Name: Size
		/// Type: StructProperty
		/// Offset: 0x48
		/// Size: 0x08
		/// </summary>
		public FSlateChildSize Size => ReadStruct<FSlateChildSize>(0x48);
		
		/// <summary>
		/// Name: HorizontalAlignment
		/// Type: ByteProperty
		/// Offset: 0x50
		/// Size: 0x01
		/// </summary>
		public byte HorizontalAlignment
		{
			get
			{
				return ReadByte(0x50);
			}
			set
			{
				WriteByte(0x50,value);
			}
		}
		
		/// <summary>
		/// Name: VerticalAlignment
		/// Type: ByteProperty
		/// Offset: 0x51
		/// Size: 0x01
		/// </summary>
		public byte VerticalAlignment
		{
			get
			{
				return ReadByte(0x51);
			}
			set
			{
				WriteByte(0x51,value);
			}
		}
		
	}


	/// <summary>
	/// UWidgetSwitcherSlot:UPanelSlot
	/// Size: 0x58
	/// Properties: 3
	/// </summary>
	public class UWidgetSwitcherSlot:UPanelSlot
	{
		public override int ObjectSize => 88;
		/// <summary>
		/// Name: Padding
		/// Type: StructProperty
		/// Offset: 0x38
		/// Size: 0x10
		/// </summary>
		public FMargin Padding => ReadStruct<FMargin>(0x38);
		
		/// <summary>
		/// Name: HorizontalAlignment
		/// Type: ByteProperty
		/// Offset: 0x48
		/// Size: 0x01
		/// </summary>
		public byte HorizontalAlignment
		{
			get
			{
				return ReadByte(0x48);
			}
			set
			{
				WriteByte(0x48,value);
			}
		}
		
		/// <summary>
		/// Name: VerticalAlignment
		/// Type: ByteProperty
		/// Offset: 0x49
		/// Size: 0x01
		/// </summary>
		public byte VerticalAlignment
		{
			get
			{
				return ReadByte(0x49);
			}
			set
			{
				WriteByte(0x49,value);
			}
		}
		
	}


	/// <summary>
	/// UWrapBoxSlot:UPanelSlot
	/// Size: 0x60
	/// Properties: 5
	/// </summary>
	public class UWrapBoxSlot:UPanelSlot
	{
		public override int ObjectSize => 96;
		/// <summary>
		/// Name: Padding
		/// Type: StructProperty
		/// Offset: 0x38
		/// Size: 0x10
		/// </summary>
		public FMargin Padding => ReadStruct<FMargin>(0x38);
		
		/// <summary>
		/// Name: bFillEmptySpace
		/// Type: BoolProperty
		/// Offset: 0x48
		/// Size: 0x01
		/// </summary>
		public bool bFillEmptySpace
		{
			get
			{
				return ReadBool(0x48);
			}
			set
			{
				WriteBool(0x48,value);
			}
		}
		
		/// <summary>
		/// Name: FillSpanWhenLessThan
		/// Type: FloatProperty
		/// Offset: 0x4C
		/// Size: 0x04
		/// </summary>
		public float FillSpanWhenLessThan
		{
			get
			{
				return ReadSingle(0x4C);
			}
			set
			{
				WriteSingle(0x4C,value);
			}
		}
		
		/// <summary>
		/// Name: HorizontalAlignment
		/// Type: ByteProperty
		/// Offset: 0x50
		/// Size: 0x01
		/// </summary>
		public byte HorizontalAlignment
		{
			get
			{
				return ReadByte(0x50);
			}
			set
			{
				WriteByte(0x50,value);
			}
		}
		
		/// <summary>
		/// Name: VerticalAlignment
		/// Type: ByteProperty
		/// Offset: 0x51
		/// Size: 0x01
		/// </summary>
		public byte VerticalAlignment
		{
			get
			{
				return ReadByte(0x51);
			}
			set
			{
				WriteByte(0x51,value);
			}
		}
		
	}


	/// <summary>
	/// UCircularThrobber:UWidget
	/// Size: 0x1D8
	/// Properties: 6
	/// </summary>
	public class UCircularThrobber:UWidget
	{
		public override int ObjectSize => 472;
		/// <summary>
		/// Name: NumberOfPieces
		/// Type: IntProperty
		/// Offset: 0x118
		/// Size: 0x04
		/// </summary>
		public int NumberOfPieces
		{
			get
			{
				return ReadInt32(0x118);
			}
			set
			{
				WriteInt32(0x118,value);
			}
		}
		
		/// <summary>
		/// Name: Period
		/// Type: FloatProperty
		/// Offset: 0x11C
		/// Size: 0x04
		/// </summary>
		public float Period
		{
			get
			{
				return ReadSingle(0x11C);
			}
			set
			{
				WriteSingle(0x11C,value);
			}
		}
		
		/// <summary>
		/// Name: Radius
		/// Type: FloatProperty
		/// Offset: 0x120
		/// Size: 0x04
		/// </summary>
		public float Radius
		{
			get
			{
				return ReadSingle(0x120);
			}
			set
			{
				WriteSingle(0x120,value);
			}
		}
		
		/// <summary>
		/// Name: PieceImage
		/// Type: ObjectProperty
		/// Offset: 0x128
		/// Size: 0x08
		/// </summary>
		public USlateBrushAsset PieceImage => ReadUObject<USlateBrushAsset>(0x128);
		
		/// <summary>
		/// Name: Image
		/// Type: StructProperty
		/// Offset: 0x130
		/// Size: 0x90
		/// </summary>
		public FSlateBrush Image => ReadStruct<FSlateBrush>(0x130);
		
		/// <summary>
		/// Name: bEnableRadius
		/// Type: BoolProperty
		/// Offset: 0x1C0
		/// Size: 0x01
		/// </summary>
		public bool bEnableRadius
		{
			get
			{
				return ReadBool(0x1C0);
			}
			set
			{
				WriteBool(0x1C0,value);
			}
		}
		
	}


	/// <summary>
	/// UComboBox:UWidget
	/// Size: 0x148
	/// Properties: 2
	/// </summary>
	public class UComboBox:UWidget
	{
		public override int ObjectSize => 328;
		/// <summary>
		/// Name: Items
		/// Type: TArray<UObject>
		/// Offset: 0x118
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<UObject> Items => new TArray<UObject>(BaseAddress+0x118);
		
		/// <summary>
		/// Name: OnGenerateWidgetEvent
		/// Type: DelegateProperty
		/// Offset: 0x128
		/// Size: 0x10
		/// </summary>
		
	}


	/// <summary>
	/// UComboBoxString:UWidget
	/// Size: 0x610
	/// Properties: 7
	/// </summary>
	public class UComboBoxString:UWidget
	{
		public override int ObjectSize => 1552;
		/// <summary>
		/// Name: DefaultOptions
		/// Type: TArray<>
		/// Offset: 0x118
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: SelectedOption
		/// Type: StrProperty
		/// Offset: 0x128
		/// Size: 0x10
		/// </summary>
		public FString SelectedOption => new FString(BaseAddress+0x128);
		
		/// <summary>
		/// Name: WidgetStyle
		/// Type: StructProperty
		/// Offset: 0x138
		/// Size: 0x450
		/// </summary>
		public FComboBoxStyle WidgetStyle => ReadStruct<FComboBoxStyle>(0x138);
		
		/// <summary>
		/// Name: ContentPadding
		/// Type: StructProperty
		/// Offset: 0x588
		/// Size: 0x10
		/// </summary>
		public FMargin ContentPadding => ReadStruct<FMargin>(0x588);
		
		/// <summary>
		/// Name: MaxListHeight
		/// Type: FloatProperty
		/// Offset: 0x598
		/// Size: 0x04
		/// </summary>
		public float MaxListHeight
		{
			get
			{
				return ReadSingle(0x598);
			}
			set
			{
				WriteSingle(0x598,value);
			}
		}
		
		/// <summary>
		/// Name: HasDownArrow
		/// Type: BoolProperty
		/// Offset: 0x59C
		/// Size: 0x01
		/// </summary>
		public bool HasDownArrow
		{
			get
			{
				return ReadBool(0x59C);
			}
			set
			{
				WriteBool(0x59C,value);
			}
		}
		
		/// <summary>
		/// Name: OnGenerateWidgetEvent
		/// Type: DelegateProperty
		/// Offset: 0x5A0
		/// Size: 0x10
		/// </summary>
		
	}


	/// <summary>
	/// UEditableText:UWidget
	/// Size: 0x458
	/// Properties: 22
	/// </summary>
	public class UEditableText:UWidget
	{
		public override int ObjectSize => 1112;
		/// <summary>
		/// Name: Text
		/// Type: TextProperty
		/// Offset: 0x118
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: TextDelegate
		/// Type: DelegateProperty
		/// Offset: 0x130
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: HintText
		/// Type: TextProperty
		/// Offset: 0x140
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: HintTextDelegate
		/// Type: DelegateProperty
		/// Offset: 0x158
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: WidgetStyle
		/// Type: StructProperty
		/// Offset: 0x168
		/// Size: 0x220
		/// </summary>
		public FEditableTextStyle WidgetStyle => ReadStruct<FEditableTextStyle>(0x168);
		
		/// <summary>
		/// Name: Style
		/// Type: ObjectProperty
		/// Offset: 0x388
		/// Size: 0x08
		/// </summary>
		public USlateWidgetStyleAsset Style => ReadUObject<USlateWidgetStyleAsset>(0x388);
		
		/// <summary>
		/// Name: BackgroundImageSelected
		/// Type: ObjectProperty
		/// Offset: 0x390
		/// Size: 0x08
		/// </summary>
		public USlateBrushAsset BackgroundImageSelected => ReadUObject<USlateBrushAsset>(0x390);
		
		/// <summary>
		/// Name: BackgroundImageComposing
		/// Type: ObjectProperty
		/// Offset: 0x398
		/// Size: 0x08
		/// </summary>
		public USlateBrushAsset BackgroundImageComposing => ReadUObject<USlateBrushAsset>(0x398);
		
		/// <summary>
		/// Name: CaretImage
		/// Type: ObjectProperty
		/// Offset: 0x3A0
		/// Size: 0x08
		/// </summary>
		public USlateBrushAsset CaretImage => ReadUObject<USlateBrushAsset>(0x3A0);
		
		/// <summary>
		/// Name: Font
		/// Type: StructProperty
		/// Offset: 0x3A8
		/// Size: 0x40
		/// </summary>
		public FSlateFontInfo Font => ReadStruct<FSlateFontInfo>(0x3A8);
		
		/// <summary>
		/// Name: ColorAndOpacity
		/// Type: StructProperty
		/// Offset: 0x3E8
		/// Size: 0x28
		/// </summary>
		public FSlateColor ColorAndOpacity => ReadStruct<FSlateColor>(0x3E8);
		
		/// <summary>
		/// Name: IsReadOnly
		/// Type: BoolProperty
		/// Offset: 0x410
		/// Size: 0x01
		/// </summary>
		public bool IsReadOnly
		{
			get
			{
				return ReadBool(0x410);
			}
			set
			{
				WriteBool(0x410,value);
			}
		}
		
		/// <summary>
		/// Name: IsPassword
		/// Type: BoolProperty
		/// Offset: 0x411
		/// Size: 0x01
		/// </summary>
		public bool IsPassword
		{
			get
			{
				return ReadBool(0x411);
			}
			set
			{
				WriteBool(0x411,value);
			}
		}
		
		/// <summary>
		/// Name: MinimumDesiredWidth
		/// Type: FloatProperty
		/// Offset: 0x414
		/// Size: 0x04
		/// </summary>
		public float MinimumDesiredWidth
		{
			get
			{
				return ReadSingle(0x414);
			}
			set
			{
				WriteSingle(0x414,value);
			}
		}
		
		/// <summary>
		/// Name: IsCaretMovedWhenGainFocus
		/// Type: BoolProperty
		/// Offset: 0x418
		/// Size: 0x01
		/// </summary>
		public bool IsCaretMovedWhenGainFocus
		{
			get
			{
				return ReadBool(0x418);
			}
			set
			{
				WriteBool(0x418,value);
			}
		}
		
		/// <summary>
		/// Name: SelectAllTextWhenFocused
		/// Type: BoolProperty
		/// Offset: 0x419
		/// Size: 0x01
		/// </summary>
		public bool SelectAllTextWhenFocused
		{
			get
			{
				return ReadBool(0x419);
			}
			set
			{
				WriteBool(0x419,value);
			}
		}
		
		/// <summary>
		/// Name: RevertTextOnEscape
		/// Type: BoolProperty
		/// Offset: 0x41A
		/// Size: 0x01
		/// </summary>
		public bool RevertTextOnEscape
		{
			get
			{
				return ReadBool(0x41A);
			}
			set
			{
				WriteBool(0x41A,value);
			}
		}
		
		/// <summary>
		/// Name: ClearKeyboardFocusOnCommit
		/// Type: BoolProperty
		/// Offset: 0x41B
		/// Size: 0x01
		/// </summary>
		public bool ClearKeyboardFocusOnCommit
		{
			get
			{
				return ReadBool(0x41B);
			}
			set
			{
				WriteBool(0x41B,value);
			}
		}
		
		/// <summary>
		/// Name: SelectAllTextOnCommit
		/// Type: BoolProperty
		/// Offset: 0x41C
		/// Size: 0x01
		/// </summary>
		public bool SelectAllTextOnCommit
		{
			get
			{
				return ReadBool(0x41C);
			}
			set
			{
				WriteBool(0x41C,value);
			}
		}
		
		/// <summary>
		/// Name: AllowContextMenu
		/// Type: BoolProperty
		/// Offset: 0x41D
		/// Size: 0x01
		/// </summary>
		public bool AllowContextMenu
		{
			get
			{
				return ReadBool(0x41D);
			}
			set
			{
				WriteBool(0x41D,value);
			}
		}
		
		/// <summary>
		/// Name: KeyboardType
		/// Type: ByteProperty
		/// Offset: 0x41E
		/// Size: 0x01
		/// </summary>
		public byte KeyboardType
		{
			get
			{
				return ReadByte(0x41E);
			}
			set
			{
				WriteByte(0x41E,value);
			}
		}
		
		/// <summary>
		/// Name: ShapedTextOptions
		/// Type: StructProperty
		/// Offset: 0x420
		/// Size: 0x08
		/// </summary>
		public FShapedTextOptions ShapedTextOptions => ReadStruct<FShapedTextOptions>(0x420);
		
	}


	/// <summary>
	/// UEditableTextBox:UWidget
	/// Size: 0xA80
	/// Properties: 22
	/// </summary>
	public class UEditableTextBox:UWidget
	{
		public override int ObjectSize => 2688;
		/// <summary>
		/// Name: Text
		/// Type: TextProperty
		/// Offset: 0x118
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: TextDelegate
		/// Type: DelegateProperty
		/// Offset: 0x130
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: WidgetStyle
		/// Type: StructProperty
		/// Offset: 0x140
		/// Size: 0x848
		/// </summary>
		public FEditableTextBoxStyle WidgetStyle => ReadStruct<FEditableTextBoxStyle>(0x140);
		
		/// <summary>
		/// Name: Style
		/// Type: ObjectProperty
		/// Offset: 0x988
		/// Size: 0x08
		/// </summary>
		public USlateWidgetStyleAsset Style => ReadUObject<USlateWidgetStyleAsset>(0x988);
		
		/// <summary>
		/// Name: HintText
		/// Type: TextProperty
		/// Offset: 0x990
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: HintTextDelegate
		/// Type: DelegateProperty
		/// Offset: 0x9A8
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: Font
		/// Type: StructProperty
		/// Offset: 0x9B8
		/// Size: 0x40
		/// </summary>
		public FSlateFontInfo Font => ReadStruct<FSlateFontInfo>(0x9B8);
		
		/// <summary>
		/// Name: ForegroundColor
		/// Type: StructProperty
		/// Offset: 0x9F8
		/// Size: 0x10
		/// </summary>
		public FLinearColor ForegroundColor => ReadStruct<FLinearColor>(0x9F8);
		
		/// <summary>
		/// Name: BackgroundColor
		/// Type: StructProperty
		/// Offset: 0xA08
		/// Size: 0x10
		/// </summary>
		public FLinearColor BackgroundColor => ReadStruct<FLinearColor>(0xA08);
		
		/// <summary>
		/// Name: ReadOnlyForegroundColor
		/// Type: StructProperty
		/// Offset: 0xA18
		/// Size: 0x10
		/// </summary>
		public FLinearColor ReadOnlyForegroundColor => ReadStruct<FLinearColor>(0xA18);
		
		/// <summary>
		/// Name: IsReadOnly
		/// Type: BoolProperty
		/// Offset: 0xA28
		/// Size: 0x01
		/// </summary>
		public bool IsReadOnly
		{
			get
			{
				return ReadBool(0xA28);
			}
			set
			{
				WriteBool(0xA28,value);
			}
		}
		
		/// <summary>
		/// Name: IsPassword
		/// Type: BoolProperty
		/// Offset: 0xA29
		/// Size: 0x01
		/// </summary>
		public bool IsPassword
		{
			get
			{
				return ReadBool(0xA29);
			}
			set
			{
				WriteBool(0xA29,value);
			}
		}
		
		/// <summary>
		/// Name: MinimumDesiredWidth
		/// Type: FloatProperty
		/// Offset: 0xA2C
		/// Size: 0x04
		/// </summary>
		public float MinimumDesiredWidth
		{
			get
			{
				return ReadSingle(0xA2C);
			}
			set
			{
				WriteSingle(0xA2C,value);
			}
		}
		
		/// <summary>
		/// Name: Padding
		/// Type: StructProperty
		/// Offset: 0xA30
		/// Size: 0x10
		/// </summary>
		public FMargin Padding => ReadStruct<FMargin>(0xA30);
		
		/// <summary>
		/// Name: IsCaretMovedWhenGainFocus
		/// Type: BoolProperty
		/// Offset: 0xA40
		/// Size: 0x01
		/// </summary>
		public bool IsCaretMovedWhenGainFocus
		{
			get
			{
				return ReadBool(0xA40);
			}
			set
			{
				WriteBool(0xA40,value);
			}
		}
		
		/// <summary>
		/// Name: SelectAllTextWhenFocused
		/// Type: BoolProperty
		/// Offset: 0xA41
		/// Size: 0x01
		/// </summary>
		public bool SelectAllTextWhenFocused
		{
			get
			{
				return ReadBool(0xA41);
			}
			set
			{
				WriteBool(0xA41,value);
			}
		}
		
		/// <summary>
		/// Name: RevertTextOnEscape
		/// Type: BoolProperty
		/// Offset: 0xA42
		/// Size: 0x01
		/// </summary>
		public bool RevertTextOnEscape
		{
			get
			{
				return ReadBool(0xA42);
			}
			set
			{
				WriteBool(0xA42,value);
			}
		}
		
		/// <summary>
		/// Name: ClearKeyboardFocusOnCommit
		/// Type: BoolProperty
		/// Offset: 0xA43
		/// Size: 0x01
		/// </summary>
		public bool ClearKeyboardFocusOnCommit
		{
			get
			{
				return ReadBool(0xA43);
			}
			set
			{
				WriteBool(0xA43,value);
			}
		}
		
		/// <summary>
		/// Name: SelectAllTextOnCommit
		/// Type: BoolProperty
		/// Offset: 0xA44
		/// Size: 0x01
		/// </summary>
		public bool SelectAllTextOnCommit
		{
			get
			{
				return ReadBool(0xA44);
			}
			set
			{
				WriteBool(0xA44,value);
			}
		}
		
		/// <summary>
		/// Name: AllowContextMenu
		/// Type: BoolProperty
		/// Offset: 0xA45
		/// Size: 0x01
		/// </summary>
		public bool AllowContextMenu
		{
			get
			{
				return ReadBool(0xA45);
			}
			set
			{
				WriteBool(0xA45,value);
			}
		}
		
		/// <summary>
		/// Name: KeyboardType
		/// Type: ByteProperty
		/// Offset: 0xA46
		/// Size: 0x01
		/// </summary>
		public byte KeyboardType
		{
			get
			{
				return ReadByte(0xA46);
			}
			set
			{
				WriteByte(0xA46,value);
			}
		}
		
		/// <summary>
		/// Name: ShapedTextOptions
		/// Type: StructProperty
		/// Offset: 0xA48
		/// Size: 0x08
		/// </summary>
		public FShapedTextOptions ShapedTextOptions => ReadStruct<FShapedTextOptions>(0xA48);
		
	}


	/// <summary>
	/// UExpandableArea:UWidget
	/// Size: 0x358
	/// Properties: 9
	/// </summary>
	public class UExpandableArea:UWidget
	{
		public override int ObjectSize => 856;
		/// <summary>
		/// Name: Style
		/// Type: StructProperty
		/// Offset: 0x120
		/// Size: 0x128
		/// </summary>
		public FExpandableAreaStyle Style => ReadStruct<FExpandableAreaStyle>(0x120);
		
		/// <summary>
		/// Name: BorderBrush
		/// Type: StructProperty
		/// Offset: 0x248
		/// Size: 0x90
		/// </summary>
		public FSlateBrush BorderBrush => ReadStruct<FSlateBrush>(0x248);
		
		/// <summary>
		/// Name: BorderColor
		/// Type: StructProperty
		/// Offset: 0x2D8
		/// Size: 0x28
		/// </summary>
		public FSlateColor BorderColor => ReadStruct<FSlateColor>(0x2D8);
		
		/// <summary>
		/// Name: bIsExpanded
		/// Type: BoolProperty
		/// Offset: 0x300
		/// Size: 0x01
		/// </summary>
		public bool bIsExpanded
		{
			get
			{
				return ReadBool(0x300);
			}
			set
			{
				WriteBool(0x300,value);
			}
		}
		
		/// <summary>
		/// Name: MaxHeight
		/// Type: FloatProperty
		/// Offset: 0x304
		/// Size: 0x04
		/// </summary>
		public float MaxHeight
		{
			get
			{
				return ReadSingle(0x304);
			}
			set
			{
				WriteSingle(0x304,value);
			}
		}
		
		/// <summary>
		/// Name: HeaderPadding
		/// Type: StructProperty
		/// Offset: 0x308
		/// Size: 0x10
		/// </summary>
		public FMargin HeaderPadding => ReadStruct<FMargin>(0x308);
		
		/// <summary>
		/// Name: AreaPadding
		/// Type: StructProperty
		/// Offset: 0x318
		/// Size: 0x10
		/// </summary>
		public FMargin AreaPadding => ReadStruct<FMargin>(0x318);
		
		/// <summary>
		/// Name: HeaderContent
		/// Type: ObjectProperty
		/// Offset: 0x338
		/// Size: 0x08
		/// </summary>
		public UWidget HeaderContent => ReadUObject<UWidget>(0x338);
		
		/// <summary>
		/// Name: BodyContent
		/// Type: ObjectProperty
		/// Offset: 0x340
		/// Size: 0x08
		/// </summary>
		public UWidget BodyContent => ReadUObject<UWidget>(0x340);
		
	}


	/// <summary>
	/// UImage:UWidget
	/// Size: 0x200
	/// Properties: 6
	/// </summary>
	public class UImage:UWidget
	{
		public override int ObjectSize => 512;
		/// <summary>
		/// Name: Image
		/// Type: ObjectProperty
		/// Offset: 0x118
		/// Size: 0x08
		/// </summary>
		public USlateBrushAsset Image => ReadUObject<USlateBrushAsset>(0x118);
		
		/// <summary>
		/// Name: Brush
		/// Type: StructProperty
		/// Offset: 0x120
		/// Size: 0x90
		/// </summary>
		public FSlateBrush Brush => ReadStruct<FSlateBrush>(0x120);
		
		/// <summary>
		/// Name: BrushDelegate
		/// Type: DelegateProperty
		/// Offset: 0x1B0
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: ColorAndOpacity
		/// Type: StructProperty
		/// Offset: 0x1C0
		/// Size: 0x10
		/// </summary>
		public FLinearColor ColorAndOpacity => ReadStruct<FLinearColor>(0x1C0);
		
		/// <summary>
		/// Name: ColorAndOpacityDelegate
		/// Type: DelegateProperty
		/// Offset: 0x1D0
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: OnMouseButtonDownEvent
		/// Type: DelegateProperty
		/// Offset: 0x1E0
		/// Size: 0x10
		/// </summary>
		
	}


	/// <summary>
	/// UInputKeySelector:UWidget
	/// Size: 0x1F0
	/// Properties: 6
	/// </summary>
	public class UInputKeySelector:UWidget
	{
		public override int ObjectSize => 496;
		/// <summary>
		/// Name: SelectedKey
		/// Type: StructProperty
		/// Offset: 0x118
		/// Size: 0x20
		/// </summary>
		public FInputChord SelectedKey => ReadStruct<FInputChord>(0x118);
		
		/// <summary>
		/// Name: Font
		/// Type: StructProperty
		/// Offset: 0x138
		/// Size: 0x40
		/// </summary>
		public FSlateFontInfo Font => ReadStruct<FSlateFontInfo>(0x138);
		
		/// <summary>
		/// Name: Margin
		/// Type: StructProperty
		/// Offset: 0x178
		/// Size: 0x10
		/// </summary>
		public FMargin Margin => ReadStruct<FMargin>(0x178);
		
		/// <summary>
		/// Name: ColorAndOpacity
		/// Type: StructProperty
		/// Offset: 0x188
		/// Size: 0x10
		/// </summary>
		public FLinearColor ColorAndOpacity => ReadStruct<FLinearColor>(0x188);
		
		/// <summary>
		/// Name: KeySelectionText
		/// Type: TextProperty
		/// Offset: 0x198
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: bAllowModifierKeys
		/// Type: BoolProperty
		/// Offset: 0x1B0
		/// Size: 0x01
		/// </summary>
		public bool bAllowModifierKeys
		{
			get
			{
				return ReadBool(0x1B0);
			}
			set
			{
				WriteBool(0x1B0,value);
			}
		}
		
	}


	/// <summary>
	/// UNativeWidgetHost:UWidget
	/// Size: 0x128
	/// Properties: 0
	/// </summary>
	public class UNativeWidgetHost:UWidget
	{
		public override int ObjectSize => 296;
	}


	/// <summary>
	/// UPanelWidget:UWidget
	/// Size: 0x130
	/// Properties: 1
	/// </summary>
	public class UPanelWidget:UWidget
	{
		public override int ObjectSize => 304;
		/// <summary>
		/// Name: Slots
		/// Type: TArray<UPanelSlot>
		/// Offset: 0x118
		/// Size: 0x10
		/// SubElement Size: 0x38
		/// </summary>
		public TArray<UPanelSlot> Slots => new TArray<UPanelSlot>(BaseAddress+0x118);
		
	}


	/// <summary>
	/// UCanvasPanel:UPanelWidget
	/// Size: 0x140
	/// Properties: 0
	/// </summary>
	public class UCanvasPanel:UPanelWidget
	{
		public override int ObjectSize => 320;
	}


	/// <summary>
	/// UContentWidget:UPanelWidget
	/// Size: 0x130
	/// Properties: 0
	/// </summary>
	public class UContentWidget:UPanelWidget
	{
		public override int ObjectSize => 304;
	}


	/// <summary>
	/// UBorder:UContentWidget
	/// Size: 0x288
	/// Properties: 15
	/// </summary>
	public class UBorder:UContentWidget
	{
		public override int ObjectSize => 648;
		/// <summary>
		/// Name: ContentColorAndOpacity
		/// Type: StructProperty
		/// Offset: 0x130
		/// Size: 0x10
		/// </summary>
		public FLinearColor ContentColorAndOpacity => ReadStruct<FLinearColor>(0x130);
		
		/// <summary>
		/// Name: ContentColorAndOpacityDelegate
		/// Type: DelegateProperty
		/// Offset: 0x140
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: Padding
		/// Type: StructProperty
		/// Offset: 0x150
		/// Size: 0x10
		/// </summary>
		public FMargin Padding => ReadStruct<FMargin>(0x150);
		
		/// <summary>
		/// Name: HorizontalAlignment
		/// Type: ByteProperty
		/// Offset: 0x160
		/// Size: 0x01
		/// </summary>
		public byte HorizontalAlignment
		{
			get
			{
				return ReadByte(0x160);
			}
			set
			{
				WriteByte(0x160,value);
			}
		}
		
		/// <summary>
		/// Name: VerticalAlignment
		/// Type: ByteProperty
		/// Offset: 0x161
		/// Size: 0x01
		/// </summary>
		public byte VerticalAlignment
		{
			get
			{
				return ReadByte(0x161);
			}
			set
			{
				WriteByte(0x161,value);
			}
		}
		
		/// <summary>
		/// Name: Background
		/// Type: StructProperty
		/// Offset: 0x168
		/// Size: 0x90
		/// </summary>
		public FSlateBrush Background => ReadStruct<FSlateBrush>(0x168);
		
		/// <summary>
		/// Name: BackgroundDelegate
		/// Type: DelegateProperty
		/// Offset: 0x1F8
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: BrushColor
		/// Type: StructProperty
		/// Offset: 0x208
		/// Size: 0x10
		/// </summary>
		public FLinearColor BrushColor => ReadStruct<FLinearColor>(0x208);
		
		/// <summary>
		/// Name: BrushColorDelegate
		/// Type: DelegateProperty
		/// Offset: 0x218
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: bShowEffectWhenDisabled
		/// Type: BoolProperty
		/// Offset: 0x228
		/// Size: 0x01
		/// </summary>
		public bool bShowEffectWhenDisabled
		{
			get
			{
				return ReadBool(0x228);
			}
			set
			{
				WriteBool(0x228,value);
			}
		}
		
		/// <summary>
		/// Name: OnMouseButtonDownEvent
		/// Type: DelegateProperty
		/// Offset: 0x230
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: OnMouseButtonUpEvent
		/// Type: DelegateProperty
		/// Offset: 0x240
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: OnMouseMoveEvent
		/// Type: DelegateProperty
		/// Offset: 0x250
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: OnMouseDoubleClickEvent
		/// Type: DelegateProperty
		/// Offset: 0x260
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: Brush
		/// Type: ObjectProperty
		/// Offset: 0x280
		/// Size: 0x08
		/// </summary>
		public USlateBrushAsset Brush => ReadUObject<USlateBrushAsset>(0x280);
		
	}


	/// <summary>
	/// UButton:UContentWidget
	/// Size: 0x468
	/// Properties: 7
	/// </summary>
	public class UButton:UContentWidget
	{
		public override int ObjectSize => 1128;
		/// <summary>
		/// Name: Style
		/// Type: ObjectProperty
		/// Offset: 0x130
		/// Size: 0x08
		/// </summary>
		public USlateWidgetStyleAsset Style => ReadUObject<USlateWidgetStyleAsset>(0x130);
		
		/// <summary>
		/// Name: WidgetStyle
		/// Type: StructProperty
		/// Offset: 0x138
		/// Size: 0x2A8
		/// </summary>
		public FButtonStyle WidgetStyle => ReadStruct<FButtonStyle>(0x138);
		
		/// <summary>
		/// Name: ColorAndOpacity
		/// Type: StructProperty
		/// Offset: 0x3E0
		/// Size: 0x10
		/// </summary>
		public FLinearColor ColorAndOpacity => ReadStruct<FLinearColor>(0x3E0);
		
		/// <summary>
		/// Name: BackgroundColor
		/// Type: StructProperty
		/// Offset: 0x3F0
		/// Size: 0x10
		/// </summary>
		public FLinearColor BackgroundColor => ReadStruct<FLinearColor>(0x3F0);
		
		/// <summary>
		/// Name: ClickMethod
		/// Type: ByteProperty
		/// Offset: 0x400
		/// Size: 0x01
		/// </summary>
		public byte ClickMethod
		{
			get
			{
				return ReadByte(0x400);
			}
			set
			{
				WriteByte(0x400,value);
			}
		}
		
		/// <summary>
		/// Name: TouchMethod
		/// Type: ByteProperty
		/// Offset: 0x401
		/// Size: 0x01
		/// </summary>
		public byte TouchMethod
		{
			get
			{
				return ReadByte(0x401);
			}
			set
			{
				WriteByte(0x401,value);
			}
		}
		
		/// <summary>
		/// Name: IsFocusable
		/// Type: BoolProperty
		/// Offset: 0x402
		/// Size: 0x01
		/// </summary>
		public bool IsFocusable
		{
			get
			{
				return ReadBool(0x402);
			}
			set
			{
				WriteBool(0x402,value);
			}
		}
		
	}


	/// <summary>
	/// UCheckBox:UContentWidget
	/// Size: 0x7E0
	/// Properties: 17
	/// </summary>
	public class UCheckBox:UContentWidget
	{
		public override int ObjectSize => 2016;
		/// <summary>
		/// Name: CheckedState
		/// Type: ByteProperty
		/// Offset: 0x130
		/// Size: 0x01
		/// </summary>
		public byte CheckedState
		{
			get
			{
				return ReadByte(0x130);
			}
			set
			{
				WriteByte(0x130,value);
			}
		}
		
		/// <summary>
		/// Name: CheckedStateDelegate
		/// Type: DelegateProperty
		/// Offset: 0x138
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: WidgetStyle
		/// Type: StructProperty
		/// Offset: 0x148
		/// Size: 0x5E0
		/// </summary>
		public FCheckBoxStyle WidgetStyle => ReadStruct<FCheckBoxStyle>(0x148);
		
		/// <summary>
		/// Name: Style
		/// Type: ObjectProperty
		/// Offset: 0x728
		/// Size: 0x08
		/// </summary>
		public USlateWidgetStyleAsset Style => ReadUObject<USlateWidgetStyleAsset>(0x728);
		
		/// <summary>
		/// Name: UnCheckedImage
		/// Type: ObjectProperty
		/// Offset: 0x730
		/// Size: 0x08
		/// </summary>
		public USlateBrushAsset UnCheckedImage => ReadUObject<USlateBrushAsset>(0x730);
		
		/// <summary>
		/// Name: UnCheckedHoveredImage
		/// Type: ObjectProperty
		/// Offset: 0x738
		/// Size: 0x08
		/// </summary>
		public USlateBrushAsset UnCheckedHoveredImage => ReadUObject<USlateBrushAsset>(0x738);
		
		/// <summary>
		/// Name: UnCheckedPressedImage
		/// Type: ObjectProperty
		/// Offset: 0x740
		/// Size: 0x08
		/// </summary>
		public USlateBrushAsset UnCheckedPressedImage => ReadUObject<USlateBrushAsset>(0x740);
		
		/// <summary>
		/// Name: CheckedImage
		/// Type: ObjectProperty
		/// Offset: 0x748
		/// Size: 0x08
		/// </summary>
		public USlateBrushAsset CheckedImage => ReadUObject<USlateBrushAsset>(0x748);
		
		/// <summary>
		/// Name: CheckedHoveredImage
		/// Type: ObjectProperty
		/// Offset: 0x750
		/// Size: 0x08
		/// </summary>
		public USlateBrushAsset CheckedHoveredImage => ReadUObject<USlateBrushAsset>(0x750);
		
		/// <summary>
		/// Name: CheckedPressedImage
		/// Type: ObjectProperty
		/// Offset: 0x758
		/// Size: 0x08
		/// </summary>
		public USlateBrushAsset CheckedPressedImage => ReadUObject<USlateBrushAsset>(0x758);
		
		/// <summary>
		/// Name: UndeterminedImage
		/// Type: ObjectProperty
		/// Offset: 0x760
		/// Size: 0x08
		/// </summary>
		public USlateBrushAsset UndeterminedImage => ReadUObject<USlateBrushAsset>(0x760);
		
		/// <summary>
		/// Name: UndeterminedHoveredImage
		/// Type: ObjectProperty
		/// Offset: 0x768
		/// Size: 0x08
		/// </summary>
		public USlateBrushAsset UndeterminedHoveredImage => ReadUObject<USlateBrushAsset>(0x768);
		
		/// <summary>
		/// Name: UndeterminedPressedImage
		/// Type: ObjectProperty
		/// Offset: 0x770
		/// Size: 0x08
		/// </summary>
		public USlateBrushAsset UndeterminedPressedImage => ReadUObject<USlateBrushAsset>(0x770);
		
		/// <summary>
		/// Name: HorizontalAlignment
		/// Type: ByteProperty
		/// Offset: 0x778
		/// Size: 0x01
		/// </summary>
		public byte HorizontalAlignment
		{
			get
			{
				return ReadByte(0x778);
			}
			set
			{
				WriteByte(0x778,value);
			}
		}
		
		/// <summary>
		/// Name: Padding
		/// Type: StructProperty
		/// Offset: 0x77C
		/// Size: 0x10
		/// </summary>
		public FMargin Padding => ReadStruct<FMargin>(0x77C);
		
		/// <summary>
		/// Name: BorderBackgroundColor
		/// Type: StructProperty
		/// Offset: 0x790
		/// Size: 0x28
		/// </summary>
		public FSlateColor BorderBackgroundColor => ReadStruct<FSlateColor>(0x790);
		
		/// <summary>
		/// Name: IsFocusable
		/// Type: BoolProperty
		/// Offset: 0x7B8
		/// Size: 0x01
		/// </summary>
		public bool IsFocusable
		{
			get
			{
				return ReadBool(0x7B8);
			}
			set
			{
				WriteBool(0x7B8,value);
			}
		}
		
	}


	/// <summary>
	/// UInvalidationBox:UContentWidget
	/// Size: 0x148
	/// Properties: 2
	/// </summary>
	public class UInvalidationBox:UContentWidget
	{
		public override int ObjectSize => 328;
		/// <summary>
		/// Name: bCanCache
		/// Type: BoolProperty
		/// Offset: 0x130
		/// Size: 0x01
		/// </summary>
		public bool bCanCache
		{
			get
			{
				return ReadBool(0x130);
			}
			set
			{
				WriteBool(0x130,value);
			}
		}
		
		/// <summary>
		/// Name: CacheRelativeTransforms
		/// Type: BoolProperty
		/// Offset: 0x131
		/// Size: 0x01
		/// </summary>
		public bool CacheRelativeTransforms
		{
			get
			{
				return ReadBool(0x131);
			}
			set
			{
				WriteBool(0x131,value);
			}
		}
		
	}


	/// <summary>
	/// UMenuAnchor:UContentWidget
	/// Size: 0x170
	/// Properties: 5
	/// </summary>
	public class UMenuAnchor:UContentWidget
	{
		public override int ObjectSize => 368;
		/// <summary>
		/// Name: MenuClass
		/// Type: ClassProperty
		/// Offset: 0x130
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: OnGetMenuContentEvent
		/// Type: DelegateProperty
		/// Offset: 0x138
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: Placement
		/// Type: ByteProperty
		/// Offset: 0x148
		/// Size: 0x01
		/// </summary>
		public byte Placement
		{
			get
			{
				return ReadByte(0x148);
			}
			set
			{
				WriteByte(0x148,value);
			}
		}
		
		/// <summary>
		/// Name: ShouldDeferPaintingAfterWindowContent
		/// Type: BoolProperty
		/// Offset: 0x149
		/// Size: 0x01
		/// </summary>
		public bool ShouldDeferPaintingAfterWindowContent
		{
			get
			{
				return ReadBool(0x149);
			}
			set
			{
				WriteBool(0x149,value);
			}
		}
		
		/// <summary>
		/// Name: UseApplicationMenuStack
		/// Type: BoolProperty
		/// Offset: 0x14A
		/// Size: 0x01
		/// </summary>
		public bool UseApplicationMenuStack
		{
			get
			{
				return ReadBool(0x14A);
			}
			set
			{
				WriteBool(0x14A,value);
			}
		}
		
	}


	/// <summary>
	/// UNamedSlot:UContentWidget
	/// Size: 0x140
	/// Properties: 0
	/// </summary>
	public class UNamedSlot:UContentWidget
	{
		public override int ObjectSize => 320;
	}


	/// <summary>
	/// URetainerBox:UContentWidget
	/// Size: 0x158
	/// Properties: 4
	/// </summary>
	public class URetainerBox:UContentWidget
	{
		public override int ObjectSize => 344;
		/// <summary>
		/// Name: Phase
		/// Type: IntProperty
		/// Offset: 0x130
		/// Size: 0x04
		/// </summary>
		public int Phase
		{
			get
			{
				return ReadInt32(0x130);
			}
			set
			{
				WriteInt32(0x130,value);
			}
		}
		
		/// <summary>
		/// Name: PhaseCount
		/// Type: IntProperty
		/// Offset: 0x134
		/// Size: 0x04
		/// </summary>
		public int PhaseCount
		{
			get
			{
				return ReadInt32(0x134);
			}
			set
			{
				WriteInt32(0x134,value);
			}
		}
		
		/// <summary>
		/// Name: EffectMaterial
		/// Type: ObjectProperty
		/// Offset: 0x138
		/// Size: 0x08
		/// </summary>
		public UMaterialInterface EffectMaterial => ReadUObject<UMaterialInterface>(0x138);
		
		/// <summary>
		/// Name: TextureParameter
		/// Type: NameProperty
		/// Offset: 0x140
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// USafeZone:UContentWidget
	/// Size: 0x140
	/// Properties: 0
	/// </summary>
	public class USafeZone:UContentWidget
	{
		public override int ObjectSize => 320;
	}


	/// <summary>
	/// UScaleBox:UContentWidget
	/// Size: 0x150
	/// Properties: 4
	/// </summary>
	public class UScaleBox:UContentWidget
	{
		public override int ObjectSize => 336;
		/// <summary>
		/// Name: StretchDirection
		/// Type: ByteProperty
		/// Offset: 0x130
		/// Size: 0x01
		/// </summary>
		public byte StretchDirection
		{
			get
			{
				return ReadByte(0x130);
			}
			set
			{
				WriteByte(0x130,value);
			}
		}
		
		/// <summary>
		/// Name: Stretch
		/// Type: ByteProperty
		/// Offset: 0x131
		/// Size: 0x01
		/// </summary>
		public byte Stretch
		{
			get
			{
				return ReadByte(0x131);
			}
			set
			{
				WriteByte(0x131,value);
			}
		}
		
		/// <summary>
		/// Name: UserSpecifiedScale
		/// Type: FloatProperty
		/// Offset: 0x134
		/// Size: 0x04
		/// </summary>
		public float UserSpecifiedScale
		{
			get
			{
				return ReadSingle(0x134);
			}
			set
			{
				WriteSingle(0x134,value);
			}
		}
		
		/// <summary>
		/// Name: IgnoreInheritedScale
		/// Type: BoolProperty
		/// Offset: 0x138
		/// Size: 0x01
		/// </summary>
		public bool IgnoreInheritedScale
		{
			get
			{
				return ReadBool(0x138);
			}
			set
			{
				WriteBool(0x138,value);
			}
		}
		
	}


	/// <summary>
	/// USizeBox:UContentWidget
	/// Size: 0x160
	/// Properties: 12
	/// </summary>
	public class USizeBox:UContentWidget
	{
		public override int ObjectSize => 352;
		/// <summary>
		/// Name: bOverride_WidthOverride
		/// Type: BoolProperty
		/// Offset: 0x130
		/// Size: 0x01
		/// </summary>
		public bool bOverride_WidthOverride => (ReadByte(0x0130) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bOverride_HeightOverride
		/// Type: BoolProperty
		/// Offset: 0x130
		/// Size: 0x01
		/// </summary>
		public bool bOverride_HeightOverride => (ReadByte(0x0130) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bOverride_MinDesiredWidth
		/// Type: BoolProperty
		/// Offset: 0x130
		/// Size: 0x01
		/// </summary>
		public bool bOverride_MinDesiredWidth => (ReadByte(0x0130) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bOverride_MinDesiredHeight
		/// Type: BoolProperty
		/// Offset: 0x130
		/// Size: 0x01
		/// </summary>
		public bool bOverride_MinDesiredHeight => (ReadByte(0x0130) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bOverride_MaxDesiredWidth
		/// Type: BoolProperty
		/// Offset: 0x130
		/// Size: 0x01
		/// </summary>
		public bool bOverride_MaxDesiredWidth => (ReadByte(0x0130) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bOverride_MaxDesiredHeight
		/// Type: BoolProperty
		/// Offset: 0x130
		/// Size: 0x01
		/// </summary>
		public bool bOverride_MaxDesiredHeight => (ReadByte(0x0130) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: WidthOverride
		/// Type: FloatProperty
		/// Offset: 0x134
		/// Size: 0x04
		/// </summary>
		public float WidthOverride
		{
			get
			{
				return ReadSingle(0x134);
			}
			set
			{
				WriteSingle(0x134,value);
			}
		}
		
		/// <summary>
		/// Name: HeightOverride
		/// Type: FloatProperty
		/// Offset: 0x138
		/// Size: 0x04
		/// </summary>
		public float HeightOverride
		{
			get
			{
				return ReadSingle(0x138);
			}
			set
			{
				WriteSingle(0x138,value);
			}
		}
		
		/// <summary>
		/// Name: MinDesiredWidth
		/// Type: FloatProperty
		/// Offset: 0x13C
		/// Size: 0x04
		/// </summary>
		public float MinDesiredWidth
		{
			get
			{
				return ReadSingle(0x13C);
			}
			set
			{
				WriteSingle(0x13C,value);
			}
		}
		
		/// <summary>
		/// Name: MinDesiredHeight
		/// Type: FloatProperty
		/// Offset: 0x140
		/// Size: 0x04
		/// </summary>
		public float MinDesiredHeight
		{
			get
			{
				return ReadSingle(0x140);
			}
			set
			{
				WriteSingle(0x140,value);
			}
		}
		
		/// <summary>
		/// Name: MaxDesiredWidth
		/// Type: FloatProperty
		/// Offset: 0x144
		/// Size: 0x04
		/// </summary>
		public float MaxDesiredWidth
		{
			get
			{
				return ReadSingle(0x144);
			}
			set
			{
				WriteSingle(0x144,value);
			}
		}
		
		/// <summary>
		/// Name: MaxDesiredHeight
		/// Type: FloatProperty
		/// Offset: 0x148
		/// Size: 0x04
		/// </summary>
		public float MaxDesiredHeight
		{
			get
			{
				return ReadSingle(0x148);
			}
			set
			{
				WriteSingle(0x148,value);
			}
		}
		
	}


	/// <summary>
	/// UViewport:UContentWidget
	/// Size: 0x158
	/// Properties: 1
	/// </summary>
	public class UViewport:UContentWidget
	{
		public override int ObjectSize => 344;
		/// <summary>
		/// Name: BackgroundColor
		/// Type: StructProperty
		/// Offset: 0x130
		/// Size: 0x10
		/// </summary>
		public FLinearColor BackgroundColor => ReadStruct<FLinearColor>(0x130);
		
	}


	/// <summary>
	/// UGridPanel:UPanelWidget
	/// Size: 0x160
	/// Properties: 2
	/// </summary>
	public class UGridPanel:UPanelWidget
	{
		public override int ObjectSize => 352;
		/// <summary>
		/// Name: ColumnFill
		/// Type: TArray<>
		/// Offset: 0x130
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: RowFill
		/// Type: TArray<>
		/// Offset: 0x140
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
	}


	/// <summary>
	/// UHorizontalBox:UPanelWidget
	/// Size: 0x140
	/// Properties: 0
	/// </summary>
	public class UHorizontalBox:UPanelWidget
	{
		public override int ObjectSize => 320;
	}


	/// <summary>
	/// UOverlay:UPanelWidget
	/// Size: 0x140
	/// Properties: 0
	/// </summary>
	public class UOverlay:UPanelWidget
	{
		public override int ObjectSize => 320;
	}


	/// <summary>
	/// UScrollBox:UPanelWidget
	/// Size: 0x8C8
	/// Properties: 9
	/// </summary>
	public class UScrollBox:UPanelWidget
	{
		public override int ObjectSize => 2248;
		/// <summary>
		/// Name: WidgetStyle
		/// Type: StructProperty
		/// Offset: 0x130
		/// Size: 0x248
		/// </summary>
		public FScrollBoxStyle WidgetStyle => ReadStruct<FScrollBoxStyle>(0x130);
		
		/// <summary>
		/// Name: WidgetBarStyle
		/// Type: StructProperty
		/// Offset: 0x378
		/// Size: 0x518
		/// </summary>
		public FScrollBarStyle WidgetBarStyle => ReadStruct<FScrollBarStyle>(0x378);
		
		/// <summary>
		/// Name: Style
		/// Type: ObjectProperty
		/// Offset: 0x890
		/// Size: 0x08
		/// </summary>
		public USlateWidgetStyleAsset Style => ReadUObject<USlateWidgetStyleAsset>(0x890);
		
		/// <summary>
		/// Name: BarStyle
		/// Type: ObjectProperty
		/// Offset: 0x898
		/// Size: 0x08
		/// </summary>
		public USlateWidgetStyleAsset BarStyle => ReadUObject<USlateWidgetStyleAsset>(0x898);
		
		/// <summary>
		/// Name: Orientation
		/// Type: ByteProperty
		/// Offset: 0x8A0
		/// Size: 0x01
		/// </summary>
		public byte Orientation
		{
			get
			{
				return ReadByte(0x8A0);
			}
			set
			{
				WriteByte(0x8A0,value);
			}
		}
		
		/// <summary>
		/// Name: ScrollBarVisibility
		/// Type: ByteProperty
		/// Offset: 0x8A1
		/// Size: 0x01
		/// </summary>
		public byte ScrollBarVisibility
		{
			get
			{
				return ReadByte(0x8A1);
			}
			set
			{
				WriteByte(0x8A1,value);
			}
		}
		
		/// <summary>
		/// Name: ConsumeMouseWheel
		/// Type: ByteProperty
		/// Offset: 0x8A2
		/// Size: 0x01
		/// </summary>
		public byte ConsumeMouseWheel
		{
			get
			{
				return ReadByte(0x8A2);
			}
			set
			{
				WriteByte(0x8A2,value);
			}
		}
		
		/// <summary>
		/// Name: ScrollbarThickness
		/// Type: StructProperty
		/// Offset: 0x8A4
		/// Size: 0x08
		/// </summary>
		public FVector2D ScrollbarThickness => ReadStruct<FVector2D>(0x8A4);
		
		/// <summary>
		/// Name: AlwaysShowScrollbar
		/// Type: BoolProperty
		/// Offset: 0x8AC
		/// Size: 0x01
		/// </summary>
		public bool AlwaysShowScrollbar
		{
			get
			{
				return ReadBool(0x8AC);
			}
			set
			{
				WriteBool(0x8AC,value);
			}
		}
		
	}


	/// <summary>
	/// UUniformGridPanel:UPanelWidget
	/// Size: 0x158
	/// Properties: 3
	/// </summary>
	public class UUniformGridPanel:UPanelWidget
	{
		public override int ObjectSize => 344;
		/// <summary>
		/// Name: SlotPadding
		/// Type: StructProperty
		/// Offset: 0x130
		/// Size: 0x10
		/// </summary>
		public FMargin SlotPadding => ReadStruct<FMargin>(0x130);
		
		/// <summary>
		/// Name: MinDesiredSlotWidth
		/// Type: FloatProperty
		/// Offset: 0x140
		/// Size: 0x04
		/// </summary>
		public float MinDesiredSlotWidth
		{
			get
			{
				return ReadSingle(0x140);
			}
			set
			{
				WriteSingle(0x140,value);
			}
		}
		
		/// <summary>
		/// Name: MinDesiredSlotHeight
		/// Type: FloatProperty
		/// Offset: 0x144
		/// Size: 0x04
		/// </summary>
		public float MinDesiredSlotHeight
		{
			get
			{
				return ReadSingle(0x144);
			}
			set
			{
				WriteSingle(0x144,value);
			}
		}
		
	}


	/// <summary>
	/// UVerticalBox:UPanelWidget
	/// Size: 0x140
	/// Properties: 0
	/// </summary>
	public class UVerticalBox:UPanelWidget
	{
		public override int ObjectSize => 320;
	}


	/// <summary>
	/// UWidgetSwitcher:UPanelWidget
	/// Size: 0x148
	/// Properties: 1
	/// </summary>
	public class UWidgetSwitcher:UPanelWidget
	{
		public override int ObjectSize => 328;
		/// <summary>
		/// Name: ActiveWidgetIndex
		/// Type: IntProperty
		/// Offset: 0x130
		/// Size: 0x04
		/// </summary>
		public int ActiveWidgetIndex
		{
			get
			{
				return ReadInt32(0x130);
			}
			set
			{
				WriteInt32(0x130,value);
			}
		}
		
	}


	/// <summary>
	/// UWrapBox:UPanelWidget
	/// Size: 0x148
	/// Properties: 1
	/// </summary>
	public class UWrapBox:UPanelWidget
	{
		public override int ObjectSize => 328;
		/// <summary>
		/// Name: InnerSlotPadding
		/// Type: StructProperty
		/// Offset: 0x130
		/// Size: 0x08
		/// </summary>
		public FVector2D InnerSlotPadding => ReadStruct<FVector2D>(0x130);
		
	}


	/// <summary>
	/// UProgressBar:UWidget
	/// Size: 0x338
	/// Properties: 11
	/// </summary>
	public class UProgressBar:UWidget
	{
		public override int ObjectSize => 824;
		/// <summary>
		/// Name: WidgetStyle
		/// Type: StructProperty
		/// Offset: 0x118
		/// Size: 0x1B8
		/// </summary>
		public FProgressBarStyle WidgetStyle => ReadStruct<FProgressBarStyle>(0x118);
		
		/// <summary>
		/// Name: Style
		/// Type: ObjectProperty
		/// Offset: 0x2D0
		/// Size: 0x08
		/// </summary>
		public USlateWidgetStyleAsset Style => ReadUObject<USlateWidgetStyleAsset>(0x2D0);
		
		/// <summary>
		/// Name: BackgroundImage
		/// Type: ObjectProperty
		/// Offset: 0x2D8
		/// Size: 0x08
		/// </summary>
		public USlateBrushAsset BackgroundImage => ReadUObject<USlateBrushAsset>(0x2D8);
		
		/// <summary>
		/// Name: FillImage
		/// Type: ObjectProperty
		/// Offset: 0x2E0
		/// Size: 0x08
		/// </summary>
		public USlateBrushAsset FillImage => ReadUObject<USlateBrushAsset>(0x2E0);
		
		/// <summary>
		/// Name: MarqueeImage
		/// Type: ObjectProperty
		/// Offset: 0x2E8
		/// Size: 0x08
		/// </summary>
		public USlateBrushAsset MarqueeImage => ReadUObject<USlateBrushAsset>(0x2E8);
		
		/// <summary>
		/// Name: Percent
		/// Type: FloatProperty
		/// Offset: 0x2F0
		/// Size: 0x04
		/// </summary>
		public float Percent
		{
			get
			{
				return ReadSingle(0x2F0);
			}
			set
			{
				WriteSingle(0x2F0,value);
			}
		}
		
		/// <summary>
		/// Name: BarFillType
		/// Type: ByteProperty
		/// Offset: 0x2F4
		/// Size: 0x01
		/// </summary>
		public byte BarFillType
		{
			get
			{
				return ReadByte(0x2F4);
			}
			set
			{
				WriteByte(0x2F4,value);
			}
		}
		
		/// <summary>
		/// Name: bIsMarquee
		/// Type: BoolProperty
		/// Offset: 0x2F5
		/// Size: 0x01
		/// </summary>
		public bool bIsMarquee
		{
			get
			{
				return ReadBool(0x2F5);
			}
			set
			{
				WriteBool(0x2F5,value);
			}
		}
		
		/// <summary>
		/// Name: PercentDelegate
		/// Type: DelegateProperty
		/// Offset: 0x2F8
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: FillColorAndOpacity
		/// Type: StructProperty
		/// Offset: 0x308
		/// Size: 0x10
		/// </summary>
		public FLinearColor FillColorAndOpacity => ReadStruct<FLinearColor>(0x308);
		
		/// <summary>
		/// Name: FillColorAndOpacityDelegate
		/// Type: DelegateProperty
		/// Offset: 0x318
		/// Size: 0x10
		/// </summary>
		
	}


	/// <summary>
	/// UScrollBar:UWidget
	/// Size: 0x658
	/// Properties: 5
	/// </summary>
	public class UScrollBar:UWidget
	{
		public override int ObjectSize => 1624;
		/// <summary>
		/// Name: WidgetStyle
		/// Type: StructProperty
		/// Offset: 0x118
		/// Size: 0x518
		/// </summary>
		public FScrollBarStyle WidgetStyle => ReadStruct<FScrollBarStyle>(0x118);
		
		/// <summary>
		/// Name: Style
		/// Type: ObjectProperty
		/// Offset: 0x630
		/// Size: 0x08
		/// </summary>
		public USlateWidgetStyleAsset Style => ReadUObject<USlateWidgetStyleAsset>(0x630);
		
		/// <summary>
		/// Name: bAlwaysShowScrollbar
		/// Type: BoolProperty
		/// Offset: 0x638
		/// Size: 0x01
		/// </summary>
		public bool bAlwaysShowScrollbar
		{
			get
			{
				return ReadBool(0x638);
			}
			set
			{
				WriteBool(0x638,value);
			}
		}
		
		/// <summary>
		/// Name: Orientation
		/// Type: ByteProperty
		/// Offset: 0x639
		/// Size: 0x01
		/// </summary>
		public byte Orientation
		{
			get
			{
				return ReadByte(0x639);
			}
			set
			{
				WriteByte(0x639,value);
			}
		}
		
		/// <summary>
		/// Name: Thickness
		/// Type: StructProperty
		/// Offset: 0x63C
		/// Size: 0x08
		/// </summary>
		public FVector2D Thickness => ReadStruct<FVector2D>(0x63C);
		
	}


	/// <summary>
	/// USlider:UWidget
	/// Size: 0x410
	/// Properties: 9
	/// </summary>
	public class USlider:UWidget
	{
		public override int ObjectSize => 1040;
		/// <summary>
		/// Name: Value
		/// Type: FloatProperty
		/// Offset: 0x118
		/// Size: 0x04
		/// </summary>
		public float Value
		{
			get
			{
				return ReadSingle(0x118);
			}
			set
			{
				WriteSingle(0x118,value);
			}
		}
		
		/// <summary>
		/// Name: ValueDelegate
		/// Type: DelegateProperty
		/// Offset: 0x120
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: WidgetStyle
		/// Type: StructProperty
		/// Offset: 0x130
		/// Size: 0x250
		/// </summary>
		public FSliderStyle WidgetStyle => ReadStruct<FSliderStyle>(0x130);
		
		/// <summary>
		/// Name: Orientation
		/// Type: ByteProperty
		/// Offset: 0x380
		/// Size: 0x01
		/// </summary>
		public byte Orientation
		{
			get
			{
				return ReadByte(0x380);
			}
			set
			{
				WriteByte(0x380,value);
			}
		}
		
		/// <summary>
		/// Name: SliderBarColor
		/// Type: StructProperty
		/// Offset: 0x384
		/// Size: 0x10
		/// </summary>
		public FLinearColor SliderBarColor => ReadStruct<FLinearColor>(0x384);
		
		/// <summary>
		/// Name: SliderHandleColor
		/// Type: StructProperty
		/// Offset: 0x394
		/// Size: 0x10
		/// </summary>
		public FLinearColor SliderHandleColor => ReadStruct<FLinearColor>(0x394);
		
		/// <summary>
		/// Name: IndentHandle
		/// Type: BoolProperty
		/// Offset: 0x3A4
		/// Size: 0x01
		/// </summary>
		public bool IndentHandle
		{
			get
			{
				return ReadBool(0x3A4);
			}
			set
			{
				WriteBool(0x3A4,value);
			}
		}
		
		/// <summary>
		/// Name: Locked
		/// Type: BoolProperty
		/// Offset: 0x3A5
		/// Size: 0x01
		/// </summary>
		public bool Locked
		{
			get
			{
				return ReadBool(0x3A5);
			}
			set
			{
				WriteBool(0x3A5,value);
			}
		}
		
		/// <summary>
		/// Name: StepSize
		/// Type: FloatProperty
		/// Offset: 0x3A8
		/// Size: 0x04
		/// </summary>
		public float StepSize
		{
			get
			{
				return ReadSingle(0x3A8);
			}
			set
			{
				WriteSingle(0x3A8,value);
			}
		}
		
	}


	/// <summary>
	/// USpacer:UWidget
	/// Size: 0x130
	/// Properties: 1
	/// </summary>
	public class USpacer:UWidget
	{
		public override int ObjectSize => 304;
		/// <summary>
		/// Name: Size
		/// Type: StructProperty
		/// Offset: 0x118
		/// Size: 0x08
		/// </summary>
		public FVector2D Size => ReadStruct<FVector2D>(0x118);
		
	}


	/// <summary>
	/// USpinBox:UWidget
	/// Size: 0x528
	/// Properties: 19
	/// </summary>
	public class USpinBox:UWidget
	{
		public override int ObjectSize => 1320;
		/// <summary>
		/// Name: Value
		/// Type: FloatProperty
		/// Offset: 0x118
		/// Size: 0x04
		/// </summary>
		public float Value
		{
			get
			{
				return ReadSingle(0x118);
			}
			set
			{
				WriteSingle(0x118,value);
			}
		}
		
		/// <summary>
		/// Name: ValueDelegate
		/// Type: DelegateProperty
		/// Offset: 0x120
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: WidgetStyle
		/// Type: StructProperty
		/// Offset: 0x130
		/// Size: 0x310
		/// </summary>
		public FSpinBoxStyle WidgetStyle => ReadStruct<FSpinBoxStyle>(0x130);
		
		/// <summary>
		/// Name: Style
		/// Type: ObjectProperty
		/// Offset: 0x440
		/// Size: 0x08
		/// </summary>
		public USlateWidgetStyleAsset Style => ReadUObject<USlateWidgetStyleAsset>(0x440);
		
		/// <summary>
		/// Name: Delta
		/// Type: FloatProperty
		/// Offset: 0x448
		/// Size: 0x04
		/// </summary>
		public float Delta
		{
			get
			{
				return ReadSingle(0x448);
			}
			set
			{
				WriteSingle(0x448,value);
			}
		}
		
		/// <summary>
		/// Name: SliderExponent
		/// Type: FloatProperty
		/// Offset: 0x44C
		/// Size: 0x04
		/// </summary>
		public float SliderExponent
		{
			get
			{
				return ReadSingle(0x44C);
			}
			set
			{
				WriteSingle(0x44C,value);
			}
		}
		
		/// <summary>
		/// Name: Font
		/// Type: StructProperty
		/// Offset: 0x450
		/// Size: 0x40
		/// </summary>
		public FSlateFontInfo Font => ReadStruct<FSlateFontInfo>(0x450);
		
		/// <summary>
		/// Name: MinDesiredWidth
		/// Type: FloatProperty
		/// Offset: 0x490
		/// Size: 0x04
		/// </summary>
		public float MinDesiredWidth
		{
			get
			{
				return ReadSingle(0x490);
			}
			set
			{
				WriteSingle(0x490,value);
			}
		}
		
		/// <summary>
		/// Name: ClearKeyboardFocusOnCommit
		/// Type: BoolProperty
		/// Offset: 0x494
		/// Size: 0x01
		/// </summary>
		public bool ClearKeyboardFocusOnCommit
		{
			get
			{
				return ReadBool(0x494);
			}
			set
			{
				WriteBool(0x494,value);
			}
		}
		
		/// <summary>
		/// Name: SelectAllTextOnCommit
		/// Type: BoolProperty
		/// Offset: 0x495
		/// Size: 0x01
		/// </summary>
		public bool SelectAllTextOnCommit
		{
			get
			{
				return ReadBool(0x495);
			}
			set
			{
				WriteBool(0x495,value);
			}
		}
		
		/// <summary>
		/// Name: ForegroundColor
		/// Type: StructProperty
		/// Offset: 0x498
		/// Size: 0x28
		/// </summary>
		public FSlateColor ForegroundColor => ReadStruct<FSlateColor>(0x498);
		
		/// <summary>
		/// Name: bOverride_MinValue
		/// Type: BoolProperty
		/// Offset: 0x500
		/// Size: 0x01
		/// </summary>
		public bool bOverride_MinValue => (ReadByte(0x0500) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bOverride_MaxValue
		/// Type: BoolProperty
		/// Offset: 0x500
		/// Size: 0x01
		/// </summary>
		public bool bOverride_MaxValue => (ReadByte(0x0500) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bOverride_MinSliderValue
		/// Type: BoolProperty
		/// Offset: 0x500
		/// Size: 0x01
		/// </summary>
		public bool bOverride_MinSliderValue => (ReadByte(0x0500) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bOverride_MaxSliderValue
		/// Type: BoolProperty
		/// Offset: 0x500
		/// Size: 0x01
		/// </summary>
		public bool bOverride_MaxSliderValue => (ReadByte(0x0500) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: MinValue
		/// Type: FloatProperty
		/// Offset: 0x504
		/// Size: 0x04
		/// </summary>
		public float MinValue
		{
			get
			{
				return ReadSingle(0x504);
			}
			set
			{
				WriteSingle(0x504,value);
			}
		}
		
		/// <summary>
		/// Name: MaxValue
		/// Type: FloatProperty
		/// Offset: 0x508
		/// Size: 0x04
		/// </summary>
		public float MaxValue
		{
			get
			{
				return ReadSingle(0x508);
			}
			set
			{
				WriteSingle(0x508,value);
			}
		}
		
		/// <summary>
		/// Name: MinSliderValue
		/// Type: FloatProperty
		/// Offset: 0x50C
		/// Size: 0x04
		/// </summary>
		public float MinSliderValue
		{
			get
			{
				return ReadSingle(0x50C);
			}
			set
			{
				WriteSingle(0x50C,value);
			}
		}
		
		/// <summary>
		/// Name: MaxSliderValue
		/// Type: FloatProperty
		/// Offset: 0x510
		/// Size: 0x04
		/// </summary>
		public float MaxSliderValue
		{
			get
			{
				return ReadSingle(0x510);
			}
			set
			{
				WriteSingle(0x510,value);
			}
		}
		
	}


	/// <summary>
	/// UTableViewBase:UWidget
	/// Size: 0x118
	/// Properties: 0
	/// </summary>
	public class UTableViewBase:UWidget
	{
		public override int ObjectSize => 280;
	}


	/// <summary>
	/// UListView:UTableViewBase
	/// Size: 0x158
	/// Properties: 4
	/// </summary>
	public class UListView:UTableViewBase
	{
		public override int ObjectSize => 344;
		/// <summary>
		/// Name: ItemHeight
		/// Type: FloatProperty
		/// Offset: 0x118
		/// Size: 0x04
		/// </summary>
		public float ItemHeight
		{
			get
			{
				return ReadSingle(0x118);
			}
			set
			{
				WriteSingle(0x118,value);
			}
		}
		
		/// <summary>
		/// Name: Items
		/// Type: TArray<UObject>
		/// Offset: 0x120
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<UObject> Items => new TArray<UObject>(BaseAddress+0x120);
		
		/// <summary>
		/// Name: SelectionMode
		/// Type: ByteProperty
		/// Offset: 0x130
		/// Size: 0x01
		/// </summary>
		public byte SelectionMode
		{
			get
			{
				return ReadByte(0x130);
			}
			set
			{
				WriteByte(0x130,value);
			}
		}
		
		/// <summary>
		/// Name: OnGenerateRowEvent
		/// Type: DelegateProperty
		/// Offset: 0x138
		/// Size: 0x10
		/// </summary>
		
	}


	/// <summary>
	/// UTileView:UTableViewBase
	/// Size: 0x158
	/// Properties: 5
	/// </summary>
	public class UTileView:UTableViewBase
	{
		public override int ObjectSize => 344;
		/// <summary>
		/// Name: ItemWidth
		/// Type: FloatProperty
		/// Offset: 0x118
		/// Size: 0x04
		/// </summary>
		public float ItemWidth
		{
			get
			{
				return ReadSingle(0x118);
			}
			set
			{
				WriteSingle(0x118,value);
			}
		}
		
		/// <summary>
		/// Name: ItemHeight
		/// Type: FloatProperty
		/// Offset: 0x11C
		/// Size: 0x04
		/// </summary>
		public float ItemHeight
		{
			get
			{
				return ReadSingle(0x11C);
			}
			set
			{
				WriteSingle(0x11C,value);
			}
		}
		
		/// <summary>
		/// Name: Items
		/// Type: TArray<UObject>
		/// Offset: 0x120
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<UObject> Items => new TArray<UObject>(BaseAddress+0x120);
		
		/// <summary>
		/// Name: SelectionMode
		/// Type: ByteProperty
		/// Offset: 0x130
		/// Size: 0x01
		/// </summary>
		public byte SelectionMode
		{
			get
			{
				return ReadByte(0x130);
			}
			set
			{
				WriteByte(0x130,value);
			}
		}
		
		/// <summary>
		/// Name: OnGenerateTileEvent
		/// Type: DelegateProperty
		/// Offset: 0x138
		/// Size: 0x10
		/// </summary>
		
	}


	/// <summary>
	/// UMultiLineEditableText:UTextLayoutWidget
	/// Size: 0x348
	/// Properties: 6
	/// </summary>
	public class UMultiLineEditableText:UTextLayoutWidget
	{
		public override int ObjectSize => 840;
		/// <summary>
		/// Name: Text
		/// Type: TextProperty
		/// Offset: 0x140
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: HintText
		/// Type: TextProperty
		/// Offset: 0x158
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: HintTextDelegate
		/// Type: DelegateProperty
		/// Offset: 0x170
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: WidgetStyle
		/// Type: StructProperty
		/// Offset: 0x180
		/// Size: 0x150
		/// </summary>
		public FTextBlockStyle WidgetStyle => ReadStruct<FTextBlockStyle>(0x180);
		
		/// <summary>
		/// Name: Font
		/// Type: StructProperty
		/// Offset: 0x2D0
		/// Size: 0x40
		/// </summary>
		public FSlateFontInfo Font => ReadStruct<FSlateFontInfo>(0x2D0);
		
		/// <summary>
		/// Name: AllowContextMenu
		/// Type: BoolProperty
		/// Offset: 0x310
		/// Size: 0x01
		/// </summary>
		public bool AllowContextMenu
		{
			get
			{
				return ReadBool(0x310);
			}
			set
			{
				WriteBool(0x310,value);
			}
		}
		
	}


	/// <summary>
	/// UMultiLineEditableTextBox:UTextLayoutWidget
	/// Size: 0xBC8
	/// Properties: 11
	/// </summary>
	public class UMultiLineEditableTextBox:UTextLayoutWidget
	{
		public override int ObjectSize => 3016;
		/// <summary>
		/// Name: Text
		/// Type: TextProperty
		/// Offset: 0x140
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: HintText
		/// Type: TextProperty
		/// Offset: 0x158
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: HintTextDelegate
		/// Type: DelegateProperty
		/// Offset: 0x170
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: WidgetStyle
		/// Type: StructProperty
		/// Offset: 0x180
		/// Size: 0x848
		/// </summary>
		public FEditableTextBoxStyle WidgetStyle => ReadStruct<FEditableTextBoxStyle>(0x180);
		
		/// <summary>
		/// Name: TextStyle
		/// Type: StructProperty
		/// Offset: 0x9C8
		/// Size: 0x150
		/// </summary>
		public FTextBlockStyle TextStyle => ReadStruct<FTextBlockStyle>(0x9C8);
		
		/// <summary>
		/// Name: AllowContextMenu
		/// Type: BoolProperty
		/// Offset: 0xB18
		/// Size: 0x01
		/// </summary>
		public bool AllowContextMenu
		{
			get
			{
				return ReadBool(0xB18);
			}
			set
			{
				WriteBool(0xB18,value);
			}
		}
		
		/// <summary>
		/// Name: Style
		/// Type: ObjectProperty
		/// Offset: 0xB20
		/// Size: 0x08
		/// </summary>
		public USlateWidgetStyleAsset Style => ReadUObject<USlateWidgetStyleAsset>(0xB20);
		
		/// <summary>
		/// Name: Font
		/// Type: StructProperty
		/// Offset: 0xB28
		/// Size: 0x40
		/// </summary>
		public FSlateFontInfo Font => ReadStruct<FSlateFontInfo>(0xB28);
		
		/// <summary>
		/// Name: ForegroundColor
		/// Type: StructProperty
		/// Offset: 0xB68
		/// Size: 0x10
		/// </summary>
		public FLinearColor ForegroundColor => ReadStruct<FLinearColor>(0xB68);
		
		/// <summary>
		/// Name: BackgroundColor
		/// Type: StructProperty
		/// Offset: 0xB78
		/// Size: 0x10
		/// </summary>
		public FLinearColor BackgroundColor => ReadStruct<FLinearColor>(0xB78);
		
		/// <summary>
		/// Name: ReadOnlyForegroundColor
		/// Type: StructProperty
		/// Offset: 0xB88
		/// Size: 0x10
		/// </summary>
		public FLinearColor ReadOnlyForegroundColor => ReadStruct<FLinearColor>(0xB88);
		
	}


	/// <summary>
	/// UTextBlock:UTextLayoutWidget
	/// Size: 0x220
	/// Properties: 10
	/// </summary>
	public class UTextBlock:UTextLayoutWidget
	{
		public override int ObjectSize => 544;
		/// <summary>
		/// Name: Text
		/// Type: TextProperty
		/// Offset: 0x140
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: TextDelegate
		/// Type: DelegateProperty
		/// Offset: 0x158
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: ColorAndOpacity
		/// Type: StructProperty
		/// Offset: 0x168
		/// Size: 0x28
		/// </summary>
		public FSlateColor ColorAndOpacity => ReadStruct<FSlateColor>(0x168);
		
		/// <summary>
		/// Name: ColorAndOpacityDelegate
		/// Type: DelegateProperty
		/// Offset: 0x190
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: Font
		/// Type: StructProperty
		/// Offset: 0x1A0
		/// Size: 0x40
		/// </summary>
		public FSlateFontInfo Font => ReadStruct<FSlateFontInfo>(0x1A0);
		
		/// <summary>
		/// Name: ShadowOffset
		/// Type: StructProperty
		/// Offset: 0x1E0
		/// Size: 0x08
		/// </summary>
		public FVector2D ShadowOffset => ReadStruct<FVector2D>(0x1E0);
		
		/// <summary>
		/// Name: ShadowColorAndOpacity
		/// Type: StructProperty
		/// Offset: 0x1E8
		/// Size: 0x10
		/// </summary>
		public FLinearColor ShadowColorAndOpacity => ReadStruct<FLinearColor>(0x1E8);
		
		/// <summary>
		/// Name: ShadowColorAndOpacityDelegate
		/// Type: DelegateProperty
		/// Offset: 0x1F8
		/// Size: 0x10
		/// </summary>
		
		/// <summary>
		/// Name: MinDesiredWidth
		/// Type: FloatProperty
		/// Offset: 0x208
		/// Size: 0x04
		/// </summary>
		public float MinDesiredWidth
		{
			get
			{
				return ReadSingle(0x208);
			}
			set
			{
				WriteSingle(0x208,value);
			}
		}
		
		/// <summary>
		/// Name: bWrapWithInvalidationPanel
		/// Type: BoolProperty
		/// Offset: 0x20C
		/// Size: 0x01
		/// </summary>
		public bool bWrapWithInvalidationPanel
		{
			get
			{
				return ReadBool(0x20C);
			}
			set
			{
				WriteBool(0x20C,value);
			}
		}
		
	}


	/// <summary>
	/// UThrobber:UWidget
	/// Size: 0x1C8
	/// Properties: 6
	/// </summary>
	public class UThrobber:UWidget
	{
		public override int ObjectSize => 456;
		/// <summary>
		/// Name: NumberOfPieces
		/// Type: IntProperty
		/// Offset: 0x118
		/// Size: 0x04
		/// </summary>
		public int NumberOfPieces
		{
			get
			{
				return ReadInt32(0x118);
			}
			set
			{
				WriteInt32(0x118,value);
			}
		}
		
		/// <summary>
		/// Name: bAnimateHorizontally
		/// Type: BoolProperty
		/// Offset: 0x11C
		/// Size: 0x01
		/// </summary>
		public bool bAnimateHorizontally
		{
			get
			{
				return ReadBool(0x11C);
			}
			set
			{
				WriteBool(0x11C,value);
			}
		}
		
		/// <summary>
		/// Name: bAnimateVertically
		/// Type: BoolProperty
		/// Offset: 0x11D
		/// Size: 0x01
		/// </summary>
		public bool bAnimateVertically
		{
			get
			{
				return ReadBool(0x11D);
			}
			set
			{
				WriteBool(0x11D,value);
			}
		}
		
		/// <summary>
		/// Name: bAnimateOpacity
		/// Type: BoolProperty
		/// Offset: 0x11E
		/// Size: 0x01
		/// </summary>
		public bool bAnimateOpacity
		{
			get
			{
				return ReadBool(0x11E);
			}
			set
			{
				WriteBool(0x11E,value);
			}
		}
		
		/// <summary>
		/// Name: PieceImage
		/// Type: ObjectProperty
		/// Offset: 0x120
		/// Size: 0x08
		/// </summary>
		public USlateBrushAsset PieceImage => ReadUObject<USlateBrushAsset>(0x120);
		
		/// <summary>
		/// Name: Image
		/// Type: StructProperty
		/// Offset: 0x128
		/// Size: 0x90
		/// </summary>
		public FSlateBrush Image => ReadStruct<FSlateBrush>(0x128);
		
	}


	/// <summary>
	/// UWidgetTree:UObject
	/// Size: 0x40
	/// Properties: 2
	/// </summary>
	public class UWidgetTree:UObject
	{
		public override int ObjectSize => 64;
		/// <summary>
		/// Name: RootWidget
		/// Type: ObjectProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		public UWidget RootWidget => ReadUObject<UWidget>(0x28);
		
		/// <summary>
		/// Name: AllWidgets
		/// Type: TArray<UWidget>
		/// Offset: 0x30
		/// Size: 0x10
		/// SubElement Size: 0x118
		/// </summary>
		public TArray<UWidget> AllWidgets => new TArray<UWidget>(BaseAddress+0x30);
		
	}


	/// <summary>
	/// UWidgetAnimation:UMovieSceneSequence
	/// Size: 0x1A8
	/// Properties: 2
	/// </summary>
	public class UWidgetAnimation:UMovieSceneSequence
	{
		public override int ObjectSize => 424;
		/// <summary>
		/// Name: MovieScene
		/// Type: ObjectProperty
		/// Offset: 0x48
		/// Size: 0x08
		/// </summary>
		public UMovieScene MovieScene => ReadUObject<UMovieScene>(0x48);
		
		/// <summary>
		/// Name: AnimationBindings
		/// Type: TArray<FWidgetAnimationBinding>
		/// Offset: 0x50
		/// Size: 0x10
		/// SubElement Size: 0x20
		/// </summary>
		public TArray<FWidgetAnimationBinding> AnimationBindings => new TArray<FWidgetAnimationBinding>(BaseAddress+0x50);
		
	}


	/// <summary>
	/// UBlueprintGeneratedClass:UClass
	/// Size: 0x2E8
	/// Properties: 11
	/// </summary>
	public class UBlueprintGeneratedClass:UClass
	{
		public override int ObjectSize => 744;
		/// <summary>
		/// Name: NumReplicatedProperties
		/// Type: IntProperty
		/// Offset: 0x218
		/// Size: 0x04
		/// </summary>
		public int NumReplicatedProperties
		{
			get
			{
				return ReadInt32(0x218);
			}
			set
			{
				WriteInt32(0x218,value);
			}
		}
		
		/// <summary>
		/// Name: DynamicBindingObjects
		/// Type: TArray<UDynamicBlueprintBinding>
		/// Offset: 0x220
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<UDynamicBlueprintBinding> DynamicBindingObjects => new TArray<UDynamicBlueprintBinding>(BaseAddress+0x220);
		
		/// <summary>
		/// Name: ComponentTemplates
		/// Type: TArray<UActorComponent>
		/// Offset: 0x230
		/// Size: 0x10
		/// SubElement Size: 0xD8
		/// </summary>
		public TArray<UActorComponent> ComponentTemplates => new TArray<UActorComponent>(BaseAddress+0x230);
		
		/// <summary>
		/// Name: Timelines
		/// Type: TArray<UTimelineTemplate>
		/// Offset: 0x240
		/// Size: 0x10
		/// SubElement Size: 0x98
		/// </summary>
		public TArray<UTimelineTemplate> Timelines => new TArray<UTimelineTemplate>(BaseAddress+0x240);
		
		/// <summary>
		/// Name: SimpleConstructionScript
		/// Type: ObjectProperty
		/// Offset: 0x250
		/// Size: 0x08
		/// </summary>
		public USimpleConstructionScript SimpleConstructionScript => ReadUObject<USimpleConstructionScript>(0x250);
		
		/// <summary>
		/// Name: InheritableComponentHandler
		/// Type: ObjectProperty
		/// Offset: 0x258
		/// Size: 0x08
		/// </summary>
		public UInheritableComponentHandler InheritableComponentHandler => ReadUObject<UInheritableComponentHandler>(0x258);
		
		/// <summary>
		/// Name: UberGraphFramePointerProperty
		/// Type: ObjectProperty
		/// Offset: 0x260
		/// Size: 0x08
		/// </summary>
		public UStructProperty UberGraphFramePointerProperty => ReadUObject<UStructProperty>(0x260);
		
		/// <summary>
		/// Name: UberGraphFunction
		/// Type: ObjectProperty
		/// Offset: 0x268
		/// Size: 0x08
		/// </summary>
		public UFunction UberGraphFunction => ReadUObject<UFunction>(0x268);
		
		/// <summary>
		/// Name: FastCallPairs
		/// Type: TArray<FEventGraphFastCallPair>
		/// Offset: 0x270
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FEventGraphFastCallPair> FastCallPairs => new TArray<FEventGraphFastCallPair>(BaseAddress+0x270);
		
		/// <summary>
		/// Name: bHasInstrumentation
		/// Type: BoolProperty
		/// Offset: 0x280
		/// Size: 0x01
		/// </summary>
		public bool bHasInstrumentation
		{
			get
			{
				return ReadBool(0x280);
			}
			set
			{
				WriteBool(0x280,value);
			}
		}
		
		/// <summary>
		/// Name: CookedComponentInstancingData
		/// Type: MapProperty
		/// Offset: 0x288
		/// Size: 0x50
		/// </summary>
		
	}


	/// <summary>
	/// UWidgetBlueprintGeneratedClass:UBlueprintGeneratedClass
	/// Size: 0x328
	/// Properties: 6
	/// </summary>
	public class UWidgetBlueprintGeneratedClass:UBlueprintGeneratedClass
	{
		public override int ObjectSize => 808;
		/// <summary>
		/// Name: WidgetTree
		/// Type: ObjectProperty
		/// Offset: 0x2E8
		/// Size: 0x08
		/// </summary>
		public UWidgetTree WidgetTree => ReadUObject<UWidgetTree>(0x2E8);
		
		/// <summary>
		/// Name: Bindings
		/// Type: TArray<FDelegateRuntimeBinding>
		/// Offset: 0x2F0
		/// Size: 0x10
		/// SubElement Size: 0x38
		/// </summary>
		public TArray<FDelegateRuntimeBinding> Bindings => new TArray<FDelegateRuntimeBinding>(BaseAddress+0x2F0);
		
		/// <summary>
		/// Name: Animations
		/// Type: TArray<UWidgetAnimation>
		/// Offset: 0x300
		/// Size: 0x10
		/// SubElement Size: 0x1A8
		/// </summary>
		public TArray<UWidgetAnimation> Animations => new TArray<UWidgetAnimation>(BaseAddress+0x300);
		
		/// <summary>
		/// Name: NamedSlots
		/// Type: TArray<FName>
		/// Offset: 0x310
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		public TArray<FName> NamedSlots => new TArray<FName>(BaseAddress+0x310);
		
		/// <summary>
		/// Name: bCanEverTick
		/// Type: BoolProperty
		/// Offset: 0x320
		/// Size: 0x01
		/// </summary>
		public bool bCanEverTick => (ReadByte(0x0320) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bCanEverPaint
		/// Type: BoolProperty
		/// Offset: 0x320
		/// Size: 0x01
		/// </summary>
		public bool bCanEverPaint => (ReadByte(0x0320) & 0x02) == 0x02;
		
	}


	/// <summary>
	/// UWidgetBlueprintLibrary:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UWidgetBlueprintLibrary:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UWidgetComponent:UPrimitiveComponent
	/// Size: 0x6B0
	/// Properties: 27
	/// </summary>
	public class UWidgetComponent:UPrimitiveComponent
	{
		public override int ObjectSize => 1712;
		/// <summary>
		/// Name: Space
		/// Type: ByteProperty
		/// Offset: 0x5A0
		/// Size: 0x01
		/// </summary>
		public byte Space
		{
			get
			{
				return ReadByte(0x5A0);
			}
			set
			{
				WriteByte(0x5A0,value);
			}
		}
		
		/// <summary>
		/// Name: WidgetClass
		/// Type: ClassProperty
		/// Offset: 0x5A8
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: DrawSize
		/// Type: StructProperty
		/// Offset: 0x5B0
		/// Size: 0x08
		/// </summary>
		public FIntPoint DrawSize => ReadStruct<FIntPoint>(0x5B0);
		
		/// <summary>
		/// Name: Pivot
		/// Type: StructProperty
		/// Offset: 0x5B8
		/// Size: 0x08
		/// </summary>
		public FVector2D Pivot => ReadStruct<FVector2D>(0x5B8);
		
		/// <summary>
		/// Name: MaxInteractionDistance
		/// Type: FloatProperty
		/// Offset: 0x5C0
		/// Size: 0x04
		/// </summary>
		public float MaxInteractionDistance
		{
			get
			{
				return ReadSingle(0x5C0);
			}
			set
			{
				WriteSingle(0x5C0,value);
			}
		}
		
		/// <summary>
		/// Name: OwnerPlayer
		/// Type: ObjectProperty
		/// Offset: 0x5C8
		/// Size: 0x08
		/// </summary>
		public ULocalPlayer OwnerPlayer => ReadUObject<ULocalPlayer>(0x5C8);
		
		/// <summary>
		/// Name: BackgroundColor
		/// Type: StructProperty
		/// Offset: 0x5D0
		/// Size: 0x10
		/// </summary>
		public FLinearColor BackgroundColor => ReadStruct<FLinearColor>(0x5D0);
		
		/// <summary>
		/// Name: TintColorAndOpacity
		/// Type: StructProperty
		/// Offset: 0x5E0
		/// Size: 0x10
		/// </summary>
		public FLinearColor TintColorAndOpacity => ReadStruct<FLinearColor>(0x5E0);
		
		/// <summary>
		/// Name: OpacityFromTexture
		/// Type: FloatProperty
		/// Offset: 0x5F0
		/// Size: 0x04
		/// </summary>
		public float OpacityFromTexture
		{
			get
			{
				return ReadSingle(0x5F0);
			}
			set
			{
				WriteSingle(0x5F0,value);
			}
		}
		
		/// <summary>
		/// Name: BlendMode
		/// Type: ByteProperty
		/// Offset: 0x5F4
		/// Size: 0x01
		/// </summary>
		public byte BlendMode
		{
			get
			{
				return ReadByte(0x5F4);
			}
			set
			{
				WriteByte(0x5F4,value);
			}
		}
		
		/// <summary>
		/// Name: bIsOpaque
		/// Type: BoolProperty
		/// Offset: 0x5F5
		/// Size: 0x01
		/// </summary>
		public bool bIsOpaque
		{
			get
			{
				return ReadBool(0x5F5);
			}
			set
			{
				WriteBool(0x5F5,value);
			}
		}
		
		/// <summary>
		/// Name: bIsTwoSided
		/// Type: BoolProperty
		/// Offset: 0x5F6
		/// Size: 0x01
		/// </summary>
		public bool bIsTwoSided
		{
			get
			{
				return ReadBool(0x5F6);
			}
			set
			{
				WriteBool(0x5F6,value);
			}
		}
		
		/// <summary>
		/// Name: ParabolaDistortion
		/// Type: FloatProperty
		/// Offset: 0x5F8
		/// Size: 0x04
		/// </summary>
		public float ParabolaDistortion
		{
			get
			{
				return ReadSingle(0x5F8);
			}
			set
			{
				WriteSingle(0x5F8,value);
			}
		}
		
		/// <summary>
		/// Name: TickWhenOffscreen
		/// Type: BoolProperty
		/// Offset: 0x5FC
		/// Size: 0x01
		/// </summary>
		public bool TickWhenOffscreen
		{
			get
			{
				return ReadBool(0x5FC);
			}
			set
			{
				WriteBool(0x5FC,value);
			}
		}
		
		/// <summary>
		/// Name: Widget
		/// Type: ObjectProperty
		/// Offset: 0x600
		/// Size: 0x08
		/// </summary>
		public UUserWidget Widget => ReadUObject<UUserWidget>(0x600);
		
		/// <summary>
		/// Name: BodySetup
		/// Type: ObjectProperty
		/// Offset: 0x628
		/// Size: 0x08
		/// </summary>
		public UBodySetup BodySetup => ReadUObject<UBodySetup>(0x628);
		
		/// <summary>
		/// Name: TranslucentMaterial
		/// Type: ObjectProperty
		/// Offset: 0x630
		/// Size: 0x08
		/// </summary>
		public UMaterialInterface TranslucentMaterial => ReadUObject<UMaterialInterface>(0x630);
		
		/// <summary>
		/// Name: TranslucentMaterial_OneSided
		/// Type: ObjectProperty
		/// Offset: 0x638
		/// Size: 0x08
		/// </summary>
		public UMaterialInterface TranslucentMaterial_OneSided => ReadUObject<UMaterialInterface>(0x638);
		
		/// <summary>
		/// Name: OpaqueMaterial
		/// Type: ObjectProperty
		/// Offset: 0x640
		/// Size: 0x08
		/// </summary>
		public UMaterialInterface OpaqueMaterial => ReadUObject<UMaterialInterface>(0x640);
		
		/// <summary>
		/// Name: OpaqueMaterial_OneSided
		/// Type: ObjectProperty
		/// Offset: 0x648
		/// Size: 0x08
		/// </summary>
		public UMaterialInterface OpaqueMaterial_OneSided => ReadUObject<UMaterialInterface>(0x648);
		
		/// <summary>
		/// Name: MaskedMaterial
		/// Type: ObjectProperty
		/// Offset: 0x650
		/// Size: 0x08
		/// </summary>
		public UMaterialInterface MaskedMaterial => ReadUObject<UMaterialInterface>(0x650);
		
		/// <summary>
		/// Name: MaskedMaterial_OneSided
		/// Type: ObjectProperty
		/// Offset: 0x658
		/// Size: 0x08
		/// </summary>
		public UMaterialInterface MaskedMaterial_OneSided => ReadUObject<UMaterialInterface>(0x658);
		
		/// <summary>
		/// Name: RenderTarget
		/// Type: ObjectProperty
		/// Offset: 0x660
		/// Size: 0x08
		/// </summary>
		public UTextureRenderTarget2D RenderTarget => ReadUObject<UTextureRenderTarget2D>(0x660);
		
		/// <summary>
		/// Name: MaterialInstance
		/// Type: ObjectProperty
		/// Offset: 0x668
		/// Size: 0x08
		/// </summary>
		public UMaterialInstanceDynamic MaterialInstance => ReadUObject<UMaterialInstanceDynamic>(0x668);
		
		/// <summary>
		/// Name: bUseLegacyRotation
		/// Type: BoolProperty
		/// Offset: 0x670
		/// Size: 0x01
		/// </summary>
		public bool bUseLegacyRotation
		{
			get
			{
				return ReadBool(0x670);
			}
			set
			{
				WriteBool(0x670,value);
			}
		}
		
		/// <summary>
		/// Name: bAddedToScreen
		/// Type: BoolProperty
		/// Offset: 0x671
		/// Size: 0x01
		/// </summary>
		public bool bAddedToScreen
		{
			get
			{
				return ReadBool(0x671);
			}
			set
			{
				WriteBool(0x671,value);
			}
		}
		
		/// <summary>
		/// Name: bEditTimeUsable
		/// Type: BoolProperty
		/// Offset: 0x672
		/// Size: 0x01
		/// </summary>
		public bool bEditTimeUsable
		{
			get
			{
				return ReadBool(0x672);
			}
			set
			{
				WriteBool(0x672,value);
			}
		}
		
	}


	/// <summary>
	/// UWidgetLayoutLibrary:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UWidgetLayoutLibrary:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UWidgetNavigation:UObject
	/// Size: 0xB8
	/// Properties: 6
	/// </summary>
	public class UWidgetNavigation:UObject
	{
		public override int ObjectSize => 184;
		/// <summary>
		/// Name: Up
		/// Type: StructProperty
		/// Offset: 0x28
		/// Size: 0x18
		/// </summary>
		public FWidgetNavigationData Up => ReadStruct<FWidgetNavigationData>(0x28);
		
		/// <summary>
		/// Name: Down
		/// Type: StructProperty
		/// Offset: 0x40
		/// Size: 0x18
		/// </summary>
		public FWidgetNavigationData Down => ReadStruct<FWidgetNavigationData>(0x40);
		
		/// <summary>
		/// Name: Left
		/// Type: StructProperty
		/// Offset: 0x58
		/// Size: 0x18
		/// </summary>
		public FWidgetNavigationData Left => ReadStruct<FWidgetNavigationData>(0x58);
		
		/// <summary>
		/// Name: Right
		/// Type: StructProperty
		/// Offset: 0x70
		/// Size: 0x18
		/// </summary>
		public FWidgetNavigationData Right => ReadStruct<FWidgetNavigationData>(0x70);
		
		/// <summary>
		/// Name: Next
		/// Type: StructProperty
		/// Offset: 0x88
		/// Size: 0x18
		/// </summary>
		public FWidgetNavigationData Next => ReadStruct<FWidgetNavigationData>(0x88);
		
		/// <summary>
		/// Name: Previous
		/// Type: StructProperty
		/// Offset: 0xA0
		/// Size: 0x18
		/// </summary>
		public FWidgetNavigationData Previous => ReadStruct<FWidgetNavigationData>(0xA0);
		
	}


	/// <summary>
	/// UNiagaraDataObject:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UNiagaraDataObject:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UNiagaraCurveDataObject:UNiagaraDataObject
	/// Size: 0x30
	/// Properties: 1
	/// </summary>
	public class UNiagaraCurveDataObject:UNiagaraDataObject
	{
		public override int ObjectSize => 48;
		/// <summary>
		/// Name: CurveObj
		/// Type: ObjectProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		public UCurveVector CurveObj => ReadUObject<UCurveVector>(0x28);
		
	}


	/// <summary>
	/// UNiagaraSparseVolumeDataObject:UNiagaraDataObject
	/// Size: 0x48
	/// Properties: 0
	/// </summary>
	public class UNiagaraSparseVolumeDataObject:UNiagaraDataObject
	{
		public override int ObjectSize => 72;
	}


	/// <summary>
	/// ANiagaraActor:AActor
	/// Size: 0x3D8
	/// Properties: 1
	/// </summary>
	public class ANiagaraActor:AActor
	{
		public override int ObjectSize => 984;
		/// <summary>
		/// Name: NiagaraComponent
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UNiagaraComponent NiagaraComponent => ReadUObject<UNiagaraComponent>(0x3D0);
		
	}


	/// <summary>
	/// UNiagaraComponent:UPrimitiveComponent
	/// Size: 0x5C0
	/// Properties: 1
	/// </summary>
	public class UNiagaraComponent:UPrimitiveComponent
	{
		public override int ObjectSize => 1472;
		/// <summary>
		/// Name: Asset
		/// Type: ObjectProperty
		/// Offset: 0x5A0
		/// Size: 0x08
		/// </summary>
		public UNiagaraEffect Asset => ReadUObject<UNiagaraEffect>(0x5A0);
		
	}


	/// <summary>
	/// UNiagaraScript:UObject
	/// Size: 0x1F0
	/// Properties: 6
	/// </summary>
	public class UNiagaraScript:UObject
	{
		public override int ObjectSize => 496;
		/// <summary>
		/// Name: ByteCode
		/// Type: TArray<>
		/// Offset: 0x28
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: ConstantData
		/// Type: StructProperty
		/// Offset: 0x38
		/// Size: 0x180
		/// </summary>
		public FNiagaraScriptConstantData ConstantData => ReadStruct<FNiagaraScriptConstantData>(0x38);
		
		/// <summary>
		/// Name: Attributes
		/// Type: TArray<FNiagaraVariableInfo>
		/// Offset: 0x1B8
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FNiagaraVariableInfo> Attributes => new TArray<FNiagaraVariableInfo>(BaseAddress+0x1B8);
		
		/// <summary>
		/// Name: EventReceivers
		/// Type: TArray<FNiagaraDataSetProperties>
		/// Offset: 0x1C8
		/// Size: 0x10
		/// SubElement Size: 0x20
		/// </summary>
		public TArray<FNiagaraDataSetProperties> EventReceivers => new TArray<FNiagaraDataSetProperties>(BaseAddress+0x1C8);
		
		/// <summary>
		/// Name: EventGenerators
		/// Type: TArray<FNiagaraDataSetProperties>
		/// Offset: 0x1D8
		/// Size: 0x10
		/// SubElement Size: 0x20
		/// </summary>
		public TArray<FNiagaraDataSetProperties> EventGenerators => new TArray<FNiagaraDataSetProperties>(BaseAddress+0x1D8);
		
		/// <summary>
		/// Name: Usage
		/// Type: StructProperty
		/// Offset: 0x1E8
		/// Size: 0x01
		/// </summary>
		public FNiagaraScriptUsageInfo Usage => ReadStruct<FNiagaraScriptUsageInfo>(0x1E8);
		
	}


	/// <summary>
	/// UNiagaraEmitterProperties:UObject
	/// Size: 0x138
	/// Properties: 11
	/// </summary>
	public class UNiagaraEmitterProperties:UObject
	{
		public override int ObjectSize => 312;
		/// <summary>
		/// Name: EmitterName
		/// Type: StrProperty
		/// Offset: 0x28
		/// Size: 0x10
		/// </summary>
		public FString EmitterName => new FString(BaseAddress+0x28);
		
		/// <summary>
		/// Name: bIsEnabled
		/// Type: BoolProperty
		/// Offset: 0x38
		/// Size: 0x01
		/// </summary>
		public bool bIsEnabled
		{
			get
			{
				return ReadBool(0x38);
			}
			set
			{
				WriteBool(0x38,value);
			}
		}
		
		/// <summary>
		/// Name: SpawnRate
		/// Type: FloatProperty
		/// Offset: 0x3C
		/// Size: 0x04
		/// </summary>
		public float SpawnRate
		{
			get
			{
				return ReadSingle(0x3C);
			}
			set
			{
				WriteSingle(0x3C,value);
			}
		}
		
		/// <summary>
		/// Name: Material
		/// Type: ObjectProperty
		/// Offset: 0x40
		/// Size: 0x08
		/// </summary>
		public UMaterial Material => ReadUObject<UMaterial>(0x40);
		
		/// <summary>
		/// Name: RenderModuleType
		/// Type: ByteProperty
		/// Offset: 0x48
		/// Size: 0x01
		/// </summary>
		public byte RenderModuleType
		{
			get
			{
				return ReadByte(0x48);
			}
			set
			{
				WriteByte(0x48,value);
			}
		}
		
		/// <summary>
		/// Name: StartTime
		/// Type: FloatProperty
		/// Offset: 0x4C
		/// Size: 0x04
		/// </summary>
		public float StartTime
		{
			get
			{
				return ReadSingle(0x4C);
			}
			set
			{
				WriteSingle(0x4C,value);
			}
		}
		
		/// <summary>
		/// Name: EndTime
		/// Type: FloatProperty
		/// Offset: 0x50
		/// Size: 0x04
		/// </summary>
		public float EndTime
		{
			get
			{
				return ReadSingle(0x50);
			}
			set
			{
				WriteSingle(0x50,value);
			}
		}
		
		/// <summary>
		/// Name: RendererProperties
		/// Type: ObjectProperty
		/// Offset: 0x58
		/// Size: 0x08
		/// </summary>
		public UNiagaraEffectRendererProperties RendererProperties => ReadUObject<UNiagaraEffectRendererProperties>(0x58);
		
		/// <summary>
		/// Name: NumLoops
		/// Type: IntProperty
		/// Offset: 0x60
		/// Size: 0x04
		/// </summary>
		public int NumLoops
		{
			get
			{
				return ReadInt32(0x60);
			}
			set
			{
				WriteInt32(0x60,value);
			}
		}
		
		/// <summary>
		/// Name: UpdateScriptProps
		/// Type: StructProperty
		/// Offset: 0x68
		/// Size: 0x68
		/// </summary>
		public FNiagaraEmitterScriptProperties UpdateScriptProps => ReadStruct<FNiagaraEmitterScriptProperties>(0x68);
		
		/// <summary>
		/// Name: SpawnScriptProps
		/// Type: StructProperty
		/// Offset: 0xD0
		/// Size: 0x68
		/// </summary>
		public FNiagaraEmitterScriptProperties SpawnScriptProps => ReadStruct<FNiagaraEmitterScriptProperties>(0xD0);
		
	}


	/// <summary>
	/// UNiagaraEffect:UObject
	/// Size: 0x48
	/// Properties: 2
	/// </summary>
	public class UNiagaraEffect:UObject
	{
		public override int ObjectSize => 72;
		/// <summary>
		/// Name: EmitterPropsSerialized
		/// Type: TArray<FDeprecatedNiagaraEmitterProperties>
		/// Offset: 0x28
		/// Size: 0x10
		/// SubElement Size: 0x2E0
		/// </summary>
		public TArray<FDeprecatedNiagaraEmitterProperties> EmitterPropsSerialized => new TArray<FDeprecatedNiagaraEmitterProperties>(BaseAddress+0x28);
		
		/// <summary>
		/// Name: EmitterProps
		/// Type: TArray<UNiagaraEmitterProperties>
		/// Offset: 0x38
		/// Size: 0x10
		/// SubElement Size: 0x138
		/// </summary>
		public TArray<UNiagaraEmitterProperties> EmitterProps => new TArray<UNiagaraEmitterProperties>(BaseAddress+0x38);
		
	}


	/// <summary>
	/// UNiagaraEventReceiverEmitterAction:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UNiagaraEventReceiverEmitterAction:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UNiagaraEventReceiverEmitterAction_SpawnParticles:UNiagaraEventReceiverEmitterAction
	/// Size: 0x30
	/// Properties: 1
	/// </summary>
	public class UNiagaraEventReceiverEmitterAction_SpawnParticles:UNiagaraEventReceiverEmitterAction
	{
		public override int ObjectSize => 48;
		/// <summary>
		/// Name: NumParticles
		/// Type: UInt32Property
		/// Offset: 0x28
		/// Size: 0x04
		/// </summary>
		
	}


	/// <summary>
	/// UNiagaraFunctionLibrary:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UNiagaraFunctionLibrary:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UNiagaraScriptSourceBase:UObject
	/// Size: 0x48
	/// Properties: 0
	/// </summary>
	public class UNiagaraScriptSourceBase:UObject
	{
		public override int ObjectSize => 72;
	}


	/// <summary>
	/// UNiagaraSequence:UMovieSceneSequence
	/// Size: 0x30
	/// Properties: 1
	/// </summary>
	public class UNiagaraSequence:UMovieSceneSequence
	{
		public override int ObjectSize => 48;
		/// <summary>
		/// Name: MovieScene
		/// Type: ObjectProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		public UMovieScene MovieScene => ReadUObject<UMovieScene>(0x28);
		
	}


	/// <summary>
	/// ACameraRig_Crane:AActor
	/// Size: 0x420
	/// Properties: 11
	/// </summary>
	public class ACameraRig_Crane:AActor
	{
		public override int ObjectSize => 1056;
		/// <summary>
		/// Name: CranePitch
		/// Type: FloatProperty
		/// Offset: 0x3D0
		/// Size: 0x04
		/// </summary>
		public float CranePitch
		{
			get
			{
				return ReadSingle(0x3D0);
			}
			set
			{
				WriteSingle(0x3D0,value);
			}
		}
		
		/// <summary>
		/// Name: CraneYaw
		/// Type: FloatProperty
		/// Offset: 0x3D4
		/// Size: 0x04
		/// </summary>
		public float CraneYaw
		{
			get
			{
				return ReadSingle(0x3D4);
			}
			set
			{
				WriteSingle(0x3D4,value);
			}
		}
		
		/// <summary>
		/// Name: CraneArmLength
		/// Type: FloatProperty
		/// Offset: 0x3D8
		/// Size: 0x04
		/// </summary>
		public float CraneArmLength
		{
			get
			{
				return ReadSingle(0x3D8);
			}
			set
			{
				WriteSingle(0x3D8,value);
			}
		}
		
		/// <summary>
		/// Name: TransformComponent
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public USceneComponent TransformComponent => ReadUObject<USceneComponent>(0x3E0);
		
		/// <summary>
		/// Name: CraneYawControl
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public USceneComponent CraneYawControl => ReadUObject<USceneComponent>(0x3E8);
		
		/// <summary>
		/// Name: CranePitchControl
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public USceneComponent CranePitchControl => ReadUObject<USceneComponent>(0x3F0);
		
		/// <summary>
		/// Name: CraneCameraMount
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public USceneComponent CraneCameraMount => ReadUObject<USceneComponent>(0x3F8);
		
		/// <summary>
		/// Name: PreviewMesh_CraneArm
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent PreviewMesh_CraneArm => ReadUObject<UStaticMeshComponent>(0x400);
		
		/// <summary>
		/// Name: PreviewMesh_CraneBase
		/// Type: ObjectProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent PreviewMesh_CraneBase => ReadUObject<UStaticMeshComponent>(0x408);
		
		/// <summary>
		/// Name: PreviewMesh_CraneMount
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent PreviewMesh_CraneMount => ReadUObject<UStaticMeshComponent>(0x410);
		
		/// <summary>
		/// Name: PreviewMesh_CraneCounterWeight
		/// Type: ObjectProperty
		/// Offset: 0x418
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent PreviewMesh_CraneCounterWeight => ReadUObject<UStaticMeshComponent>(0x418);
		
	}


	/// <summary>
	/// ACameraRig_Rail:AActor
	/// Size: 0x418
	/// Properties: 8
	/// </summary>
	public class ACameraRig_Rail:AActor
	{
		public override int ObjectSize => 1048;
		/// <summary>
		/// Name: CurrentPositionOnRail
		/// Type: FloatProperty
		/// Offset: 0x3D0
		/// Size: 0x04
		/// </summary>
		public float CurrentPositionOnRail
		{
			get
			{
				return ReadSingle(0x3D0);
			}
			set
			{
				WriteSingle(0x3D0,value);
			}
		}
		
		/// <summary>
		/// Name: TransformComponent
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public USceneComponent TransformComponent => ReadUObject<USceneComponent>(0x3D8);
		
		/// <summary>
		/// Name: RailSplineComponent
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public USplineComponent RailSplineComponent => ReadUObject<USplineComponent>(0x3E0);
		
		/// <summary>
		/// Name: RailCameraMount
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public USceneComponent RailCameraMount => ReadUObject<USceneComponent>(0x3E8);
		
		/// <summary>
		/// Name: PreviewMesh_Rail
		/// Type: ObjectProperty
		/// Offset: 0x3F0
		/// Size: 0x08
		/// </summary>
		public USplineMeshComponent PreviewMesh_Rail => ReadUObject<USplineMeshComponent>(0x3F0);
		
		/// <summary>
		/// Name: PreviewRailMeshSegments
		/// Type: TArray<USplineMeshComponent>
		/// Offset: 0x3F8
		/// Size: 0x10
		/// SubElement Size: 0x780
		/// </summary>
		public TArray<USplineMeshComponent> PreviewRailMeshSegments => new TArray<USplineMeshComponent>(BaseAddress+0x3F8);
		
		/// <summary>
		/// Name: PreviewRailStaticMesh
		/// Type: ObjectProperty
		/// Offset: 0x408
		/// Size: 0x08
		/// </summary>
		public UStaticMesh PreviewRailStaticMesh => ReadUObject<UStaticMesh>(0x408);
		
		/// <summary>
		/// Name: PreviewMesh_Mount
		/// Type: ObjectProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent PreviewMesh_Mount => ReadUObject<UStaticMeshComponent>(0x410);
		
	}


	/// <summary>
	/// ACameraActor:AActor
	/// Size: 0x7A0
	/// Properties: 8
	/// </summary>
	public class ACameraActor:AActor
	{
		public override int ObjectSize => 1952;
		/// <summary>
		/// Name: AutoActivateForPlayer
		/// Type: ByteProperty
		/// Offset: 0x3D0
		/// Size: 0x01
		/// </summary>
		public byte AutoActivateForPlayer
		{
			get
			{
				return ReadByte(0x3D0);
			}
			set
			{
				WriteByte(0x3D0,value);
			}
		}
		
		/// <summary>
		/// Name: CameraComponent
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UCameraComponent CameraComponent => ReadUObject<UCameraComponent>(0x3D8);
		
		/// <summary>
		/// Name: SceneComponent
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public USceneComponent SceneComponent => ReadUObject<USceneComponent>(0x3E0);
		
		/// <summary>
		/// Name: bConstrainAspectRatio
		/// Type: BoolProperty
		/// Offset: 0x3F0
		/// Size: 0x01
		/// </summary>
		public bool bConstrainAspectRatio => (ReadByte(0x03F0) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: AspectRatio
		/// Type: FloatProperty
		/// Offset: 0x3F4
		/// Size: 0x04
		/// </summary>
		public float AspectRatio
		{
			get
			{
				return ReadSingle(0x3F4);
			}
			set
			{
				WriteSingle(0x3F4,value);
			}
		}
		
		/// <summary>
		/// Name: FOVAngle
		/// Type: FloatProperty
		/// Offset: 0x3F8
		/// Size: 0x04
		/// </summary>
		public float FOVAngle
		{
			get
			{
				return ReadSingle(0x3F8);
			}
			set
			{
				WriteSingle(0x3F8,value);
			}
		}
		
		/// <summary>
		/// Name: PostProcessBlendWeight
		/// Type: FloatProperty
		/// Offset: 0x3FC
		/// Size: 0x04
		/// </summary>
		public float PostProcessBlendWeight
		{
			get
			{
				return ReadSingle(0x3FC);
			}
			set
			{
				WriteSingle(0x3FC,value);
			}
		}
		
		/// <summary>
		/// Name: PostProcessSettings
		/// Type: StructProperty
		/// Offset: 0x400
		/// Size: 0x3A0
		/// </summary>
		public FPostProcessSettings PostProcessSettings => ReadStruct<FPostProcessSettings>(0x400);
		
	}


	/// <summary>
	/// ACineCameraActor:ACameraActor
	/// Size: 0x7D8
	/// Properties: 1
	/// </summary>
	public class ACineCameraActor:ACameraActor
	{
		public override int ObjectSize => 2008;
		/// <summary>
		/// Name: LookatTrackingSettings
		/// Type: StructProperty
		/// Offset: 0x7A0
		/// Size: 0x30
		/// </summary>
		public FCameraLookatTrackingSettings LookatTrackingSettings => ReadStruct<FCameraLookatTrackingSettings>(0x7A0);
		
	}


	/// <summary>
	/// UCineCameraComponent:UCameraComponent
	/// Size: 0x6F0
	/// Properties: 12
	/// </summary>
	public class UCineCameraComponent:UCameraComponent
	{
		public override int ObjectSize => 1776;
		/// <summary>
		/// Name: FilmbackSettings
		/// Type: StructProperty
		/// Offset: 0x640
		/// Size: 0x0C
		/// </summary>
		public FCameraFilmbackSettings FilmbackSettings => ReadStruct<FCameraFilmbackSettings>(0x640);
		
		/// <summary>
		/// Name: LensSettings
		/// Type: StructProperty
		/// Offset: 0x64C
		/// Size: 0x14
		/// </summary>
		public FCameraLensSettings LensSettings => ReadStruct<FCameraLensSettings>(0x64C);
		
		/// <summary>
		/// Name: FocusSettings
		/// Type: StructProperty
		/// Offset: 0x660
		/// Size: 0x30
		/// </summary>
		public FCameraFocusSettings FocusSettings => ReadStruct<FCameraFocusSettings>(0x660);
		
		/// <summary>
		/// Name: CurrentFocalLength
		/// Type: FloatProperty
		/// Offset: 0x690
		/// Size: 0x04
		/// </summary>
		public float CurrentFocalLength
		{
			get
			{
				return ReadSingle(0x690);
			}
			set
			{
				WriteSingle(0x690,value);
			}
		}
		
		/// <summary>
		/// Name: CurrentAperture
		/// Type: FloatProperty
		/// Offset: 0x694
		/// Size: 0x04
		/// </summary>
		public float CurrentAperture
		{
			get
			{
				return ReadSingle(0x694);
			}
			set
			{
				WriteSingle(0x694,value);
			}
		}
		
		/// <summary>
		/// Name: CurrentFocusDistance
		/// Type: FloatProperty
		/// Offset: 0x698
		/// Size: 0x04
		/// </summary>
		public float CurrentFocusDistance
		{
			get
			{
				return ReadSingle(0x698);
			}
			set
			{
				WriteSingle(0x698,value);
			}
		}
		
		/// <summary>
		/// Name: FilmbackPresets
		/// Type: TArray<FNamedFilmbackPreset>
		/// Offset: 0x6A8
		/// Size: 0x10
		/// SubElement Size: 0x20
		/// </summary>
		public TArray<FNamedFilmbackPreset> FilmbackPresets => new TArray<FNamedFilmbackPreset>(BaseAddress+0x6A8);
		
		/// <summary>
		/// Name: LensPresets
		/// Type: TArray<FNamedLensPreset>
		/// Offset: 0x6B8
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<FNamedLensPreset> LensPresets => new TArray<FNamedLensPreset>(BaseAddress+0x6B8);
		
		/// <summary>
		/// Name: DefaultFilmbackPresetName
		/// Type: StrProperty
		/// Offset: 0x6C8
		/// Size: 0x10
		/// </summary>
		public FString DefaultFilmbackPresetName => new FString(BaseAddress+0x6C8);
		
		/// <summary>
		/// Name: DefaultLensPresetName
		/// Type: StrProperty
		/// Offset: 0x6D8
		/// Size: 0x10
		/// </summary>
		public FString DefaultLensPresetName => new FString(BaseAddress+0x6D8);
		
		/// <summary>
		/// Name: DefaultLensFocalLength
		/// Type: FloatProperty
		/// Offset: 0x6E8
		/// Size: 0x04
		/// </summary>
		public float DefaultLensFocalLength
		{
			get
			{
				return ReadSingle(0x6E8);
			}
			set
			{
				WriteSingle(0x6E8,value);
			}
		}
		
		/// <summary>
		/// Name: DefaultLensFStop
		/// Type: FloatProperty
		/// Offset: 0x6EC
		/// Size: 0x04
		/// </summary>
		public float DefaultLensFStop
		{
			get
			{
				return ReadSingle(0x6EC);
			}
			set
			{
				WriteSingle(0x6EC,value);
			}
		}
		
	}


	/// <summary>
	/// UConsoleSettings:UObject
	/// Size: 0x70
	/// Properties: 10
	/// </summary>
	public class UConsoleSettings:UObject
	{
		public override int ObjectSize => 112;
		/// <summary>
		/// Name: MaxScrollbackSize
		/// Type: IntProperty
		/// Offset: 0x28
		/// Size: 0x04
		/// </summary>
		public int MaxScrollbackSize
		{
			get
			{
				return ReadInt32(0x28);
			}
			set
			{
				WriteInt32(0x28,value);
			}
		}
		
		/// <summary>
		/// Name: ManualAutoCompleteList
		/// Type: TArray<FAutoCompleteCommand>
		/// Offset: 0x30
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<FAutoCompleteCommand> ManualAutoCompleteList => new TArray<FAutoCompleteCommand>(BaseAddress+0x30);
		
		/// <summary>
		/// Name: AutoCompleteMapPaths
		/// Type: TArray<>
		/// Offset: 0x40
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: BackgroundOpacityPercentage
		/// Type: FloatProperty
		/// Offset: 0x50
		/// Size: 0x04
		/// </summary>
		public float BackgroundOpacityPercentage
		{
			get
			{
				return ReadSingle(0x50);
			}
			set
			{
				WriteSingle(0x50,value);
			}
		}
		
		/// <summary>
		/// Name: bOrderTopToBottom
		/// Type: BoolProperty
		/// Offset: 0x54
		/// Size: 0x01
		/// </summary>
		public bool bOrderTopToBottom
		{
			get
			{
				return ReadBool(0x54);
			}
			set
			{
				WriteBool(0x54,value);
			}
		}
		
		/// <summary>
		/// Name: InputColor
		/// Type: StructProperty
		/// Offset: 0x58
		/// Size: 0x04
		/// </summary>
		public FColor InputColor => ReadStruct<FColor>(0x58);
		
		/// <summary>
		/// Name: HistoryColor
		/// Type: StructProperty
		/// Offset: 0x5C
		/// Size: 0x04
		/// </summary>
		public FColor HistoryColor => ReadStruct<FColor>(0x5C);
		
		/// <summary>
		/// Name: AutoCompleteCommandColor
		/// Type: StructProperty
		/// Offset: 0x60
		/// Size: 0x04
		/// </summary>
		public FColor AutoCompleteCommandColor => ReadStruct<FColor>(0x60);
		
		/// <summary>
		/// Name: AutoCompleteCVarColor
		/// Type: StructProperty
		/// Offset: 0x64
		/// Size: 0x04
		/// </summary>
		public FColor AutoCompleteCVarColor => ReadStruct<FColor>(0x64);
		
		/// <summary>
		/// Name: AutoCompleteFadedColor
		/// Type: StructProperty
		/// Offset: 0x68
		/// Size: 0x04
		/// </summary>
		public FColor AutoCompleteFadedColor => ReadStruct<FColor>(0x68);
		
	}


	/// <summary>
	/// UGameMapsSettings:UObject
	/// Size: 0xB0
	/// Properties: 11
	/// </summary>
	public class UGameMapsSettings:UObject
	{
		public override int ObjectSize => 176;
		/// <summary>
		/// Name: EditorStartupMap
		/// Type: StructProperty
		/// Offset: 0x28
		/// Size: 0x10
		/// </summary>
		public FStringAssetReference EditorStartupMap => ReadStruct<FStringAssetReference>(0x28);
		
		/// <summary>
		/// Name: LocalMapOptions
		/// Type: StrProperty
		/// Offset: 0x38
		/// Size: 0x10
		/// </summary>
		public FString LocalMapOptions => new FString(BaseAddress+0x38);
		
		/// <summary>
		/// Name: TransitionMap
		/// Type: StructProperty
		/// Offset: 0x48
		/// Size: 0x10
		/// </summary>
		public FStringAssetReference TransitionMap => ReadStruct<FStringAssetReference>(0x48);
		
		/// <summary>
		/// Name: bUseSplitscreen
		/// Type: BoolProperty
		/// Offset: 0x58
		/// Size: 0x01
		/// </summary>
		public bool bUseSplitscreen
		{
			get
			{
				return ReadBool(0x58);
			}
			set
			{
				WriteBool(0x58,value);
			}
		}
		
		/// <summary>
		/// Name: TwoPlayerSplitscreenLayout
		/// Type: ByteProperty
		/// Offset: 0x59
		/// Size: 0x01
		/// </summary>
		public byte TwoPlayerSplitscreenLayout
		{
			get
			{
				return ReadByte(0x59);
			}
			set
			{
				WriteByte(0x59,value);
			}
		}
		
		/// <summary>
		/// Name: ThreePlayerSplitscreenLayout
		/// Type: ByteProperty
		/// Offset: 0x5A
		/// Size: 0x01
		/// </summary>
		public byte ThreePlayerSplitscreenLayout
		{
			get
			{
				return ReadByte(0x5A);
			}
			set
			{
				WriteByte(0x5A,value);
			}
		}
		
		/// <summary>
		/// Name: GameInstanceClass
		/// Type: StructProperty
		/// Offset: 0x60
		/// Size: 0x10
		/// </summary>
		public FStringClassReference GameInstanceClass => ReadStruct<FStringClassReference>(0x60);
		
		/// <summary>
		/// Name: GameDefaultMap
		/// Type: StructProperty
		/// Offset: 0x70
		/// Size: 0x10
		/// </summary>
		public FStringAssetReference GameDefaultMap => ReadStruct<FStringAssetReference>(0x70);
		
		/// <summary>
		/// Name: ServerDefaultMap
		/// Type: StructProperty
		/// Offset: 0x80
		/// Size: 0x10
		/// </summary>
		public FStringAssetReference ServerDefaultMap => ReadStruct<FStringAssetReference>(0x80);
		
		/// <summary>
		/// Name: GlobalDefaultGameMode
		/// Type: StructProperty
		/// Offset: 0x90
		/// Size: 0x10
		/// </summary>
		public FStringClassReference GlobalDefaultGameMode => ReadStruct<FStringClassReference>(0x90);
		
		/// <summary>
		/// Name: GlobalDefaultServerGameMode
		/// Type: StructProperty
		/// Offset: 0xA0
		/// Size: 0x10
		/// </summary>
		public FStringClassReference GlobalDefaultServerGameMode => ReadStruct<FStringClassReference>(0xA0);
		
	}


	/// <summary>
	/// UGameNetworkManagerSettings:UObject
	/// Size: 0x58
	/// Properties: 11
	/// </summary>
	public class UGameNetworkManagerSettings:UObject
	{
		public override int ObjectSize => 88;
		/// <summary>
		/// Name: MinDynamicBandwidth
		/// Type: IntProperty
		/// Offset: 0x28
		/// Size: 0x04
		/// </summary>
		public int MinDynamicBandwidth
		{
			get
			{
				return ReadInt32(0x28);
			}
			set
			{
				WriteInt32(0x28,value);
			}
		}
		
		/// <summary>
		/// Name: MaxDynamicBandwidth
		/// Type: IntProperty
		/// Offset: 0x2C
		/// Size: 0x04
		/// </summary>
		public int MaxDynamicBandwidth
		{
			get
			{
				return ReadInt32(0x2C);
			}
			set
			{
				WriteInt32(0x2C,value);
			}
		}
		
		/// <summary>
		/// Name: TotalNetBandwidth
		/// Type: IntProperty
		/// Offset: 0x30
		/// Size: 0x04
		/// </summary>
		public int TotalNetBandwidth
		{
			get
			{
				return ReadInt32(0x30);
			}
			set
			{
				WriteInt32(0x30,value);
			}
		}
		
		/// <summary>
		/// Name: BadPingThreshold
		/// Type: IntProperty
		/// Offset: 0x34
		/// Size: 0x04
		/// </summary>
		public int BadPingThreshold
		{
			get
			{
				return ReadInt32(0x34);
			}
			set
			{
				WriteInt32(0x34,value);
			}
		}
		
		/// <summary>
		/// Name: bIsStandbyCheckingEnabled
		/// Type: BoolProperty
		/// Offset: 0x38
		/// Size: 0x01
		/// </summary>
		public bool bIsStandbyCheckingEnabled => (ReadByte(0x0038) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: StandbyRxCheatTime
		/// Type: FloatProperty
		/// Offset: 0x3C
		/// Size: 0x04
		/// </summary>
		public float StandbyRxCheatTime
		{
			get
			{
				return ReadSingle(0x3C);
			}
			set
			{
				WriteSingle(0x3C,value);
			}
		}
		
		/// <summary>
		/// Name: StandbyTxCheatTime
		/// Type: FloatProperty
		/// Offset: 0x40
		/// Size: 0x04
		/// </summary>
		public float StandbyTxCheatTime
		{
			get
			{
				return ReadSingle(0x40);
			}
			set
			{
				WriteSingle(0x40,value);
			}
		}
		
		/// <summary>
		/// Name: PercentMissingForRxStandby
		/// Type: FloatProperty
		/// Offset: 0x44
		/// Size: 0x04
		/// </summary>
		public float PercentMissingForRxStandby
		{
			get
			{
				return ReadSingle(0x44);
			}
			set
			{
				WriteSingle(0x44,value);
			}
		}
		
		/// <summary>
		/// Name: PercentMissingForTxStandby
		/// Type: FloatProperty
		/// Offset: 0x48
		/// Size: 0x04
		/// </summary>
		public float PercentMissingForTxStandby
		{
			get
			{
				return ReadSingle(0x48);
			}
			set
			{
				WriteSingle(0x48,value);
			}
		}
		
		/// <summary>
		/// Name: PercentForBadPing
		/// Type: FloatProperty
		/// Offset: 0x4C
		/// Size: 0x04
		/// </summary>
		public float PercentForBadPing
		{
			get
			{
				return ReadSingle(0x4C);
			}
			set
			{
				WriteSingle(0x4C,value);
			}
		}
		
		/// <summary>
		/// Name: JoinInProgressStandbyWaitTime
		/// Type: FloatProperty
		/// Offset: 0x50
		/// Size: 0x04
		/// </summary>
		public float JoinInProgressStandbyWaitTime
		{
			get
			{
				return ReadSingle(0x50);
			}
			set
			{
				WriteSingle(0x50,value);
			}
		}
		
	}


	/// <summary>
	/// UGameSessionSettings:UObject
	/// Size: 0x38
	/// Properties: 3
	/// </summary>
	public class UGameSessionSettings:UObject
	{
		public override int ObjectSize => 56;
		/// <summary>
		/// Name: MaxSpectators
		/// Type: IntProperty
		/// Offset: 0x28
		/// Size: 0x04
		/// </summary>
		public int MaxSpectators
		{
			get
			{
				return ReadInt32(0x28);
			}
			set
			{
				WriteInt32(0x28,value);
			}
		}
		
		/// <summary>
		/// Name: MaxPlayers
		/// Type: IntProperty
		/// Offset: 0x2C
		/// Size: 0x04
		/// </summary>
		public int MaxPlayers
		{
			get
			{
				return ReadInt32(0x2C);
			}
			set
			{
				WriteInt32(0x2C,value);
			}
		}
		
		/// <summary>
		/// Name: bRequiresPushToTalk
		/// Type: BoolProperty
		/// Offset: 0x30
		/// Size: 0x01
		/// </summary>
		public bool bRequiresPushToTalk => (ReadByte(0x0030) & 0x01) == 0x01;
		
	}


	/// <summary>
	/// UGeneralEngineSettings:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UGeneralEngineSettings:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UGeneralProjectSettings:UObject
	/// Size: 0xF0
	/// Properties: 12
	/// </summary>
	public class UGeneralProjectSettings:UObject
	{
		public override int ObjectSize => 240;
		/// <summary>
		/// Name: CompanyName
		/// Type: StrProperty
		/// Offset: 0x28
		/// Size: 0x10
		/// </summary>
		public FString CompanyName => new FString(BaseAddress+0x28);
		
		/// <summary>
		/// Name: CompanyDistinguishedName
		/// Type: StrProperty
		/// Offset: 0x38
		/// Size: 0x10
		/// </summary>
		public FString CompanyDistinguishedName => new FString(BaseAddress+0x38);
		
		/// <summary>
		/// Name: CopyrightNotice
		/// Type: StrProperty
		/// Offset: 0x48
		/// Size: 0x10
		/// </summary>
		public FString CopyrightNotice => new FString(BaseAddress+0x48);
		
		/// <summary>
		/// Name: Description
		/// Type: StrProperty
		/// Offset: 0x58
		/// Size: 0x10
		/// </summary>
		public FString Description => new FString(BaseAddress+0x58);
		
		/// <summary>
		/// Name: Homepage
		/// Type: StrProperty
		/// Offset: 0x68
		/// Size: 0x10
		/// </summary>
		public FString Homepage => new FString(BaseAddress+0x68);
		
		/// <summary>
		/// Name: LicensingTerms
		/// Type: StrProperty
		/// Offset: 0x78
		/// Size: 0x10
		/// </summary>
		public FString LicensingTerms => new FString(BaseAddress+0x78);
		
		/// <summary>
		/// Name: PrivacyPolicy
		/// Type: StrProperty
		/// Offset: 0x88
		/// Size: 0x10
		/// </summary>
		public FString PrivacyPolicy => new FString(BaseAddress+0x88);
		
		/// <summary>
		/// Name: ProjectID
		/// Type: StructProperty
		/// Offset: 0x98
		/// Size: 0x10
		/// </summary>
		public FGuid ProjectID => ReadStruct<FGuid>(0x98);
		
		/// <summary>
		/// Name: ProjectName
		/// Type: StrProperty
		/// Offset: 0xA8
		/// Size: 0x10
		/// </summary>
		public FString ProjectName => new FString(BaseAddress+0xA8);
		
		/// <summary>
		/// Name: ProjectVersion
		/// Type: StrProperty
		/// Offset: 0xB8
		/// Size: 0x10
		/// </summary>
		public FString ProjectVersion => new FString(BaseAddress+0xB8);
		
		/// <summary>
		/// Name: SupportContact
		/// Type: StrProperty
		/// Offset: 0xC8
		/// Size: 0x10
		/// </summary>
		public FString SupportContact => new FString(BaseAddress+0xC8);
		
		/// <summary>
		/// Name: ProjectDisplayedTitle
		/// Type: TextProperty
		/// Offset: 0xD8
		/// Size: 0x18
		/// </summary>
		
	}


	/// <summary>
	/// UHudSettings:UObject
	/// Size: 0x40
	/// Properties: 2
	/// </summary>
	public class UHudSettings:UObject
	{
		public override int ObjectSize => 64;
		/// <summary>
		/// Name: bShowHUD
		/// Type: BoolProperty
		/// Offset: 0x28
		/// Size: 0x01
		/// </summary>
		public bool bShowHUD => (ReadByte(0x0028) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: DebugDisplay
		/// Type: TArray<FName>
		/// Offset: 0x30
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		public TArray<FName> DebugDisplay => new TArray<FName>(BaseAddress+0x30);
		
	}


	/// <summary>
	/// UEditableGameplayTagQuery:UObject
	/// Size: 0x98
	/// Properties: 3
	/// </summary>
	public class UEditableGameplayTagQuery:UObject
	{
		public override int ObjectSize => 152;
		/// <summary>
		/// Name: UserDescription
		/// Type: StrProperty
		/// Offset: 0x28
		/// Size: 0x10
		/// </summary>
		public FString UserDescription => new FString(BaseAddress+0x28);
		
		/// <summary>
		/// Name: RootExpression
		/// Type: ObjectProperty
		/// Offset: 0x48
		/// Size: 0x08
		/// </summary>
		public UEditableGameplayTagQueryExpression RootExpression => ReadUObject<UEditableGameplayTagQueryExpression>(0x48);
		
		/// <summary>
		/// Name: TagQueryExportText_Helper
		/// Type: StructProperty
		/// Offset: 0x50
		/// Size: 0x48
		/// </summary>
		public FGameplayTagQuery TagQueryExportText_Helper => ReadStruct<FGameplayTagQuery>(0x50);
		
	}


	/// <summary>
	/// UEditableGameplayTagQueryExpression:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UEditableGameplayTagQueryExpression:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UEditableGameplayTagQueryExpression_AnyTagsMatch:UEditableGameplayTagQueryExpression
	/// Size: 0x48
	/// Properties: 1
	/// </summary>
	public class UEditableGameplayTagQueryExpression_AnyTagsMatch:UEditableGameplayTagQueryExpression
	{
		public override int ObjectSize => 72;
		/// <summary>
		/// Name: Tags
		/// Type: StructProperty
		/// Offset: 0x28
		/// Size: 0x20
		/// </summary>
		public FGameplayTagContainer Tags => ReadStruct<FGameplayTagContainer>(0x28);
		
	}


	/// <summary>
	/// UEditableGameplayTagQueryExpression_AllTagsMatch:UEditableGameplayTagQueryExpression
	/// Size: 0x48
	/// Properties: 1
	/// </summary>
	public class UEditableGameplayTagQueryExpression_AllTagsMatch:UEditableGameplayTagQueryExpression
	{
		public override int ObjectSize => 72;
		/// <summary>
		/// Name: Tags
		/// Type: StructProperty
		/// Offset: 0x28
		/// Size: 0x20
		/// </summary>
		public FGameplayTagContainer Tags => ReadStruct<FGameplayTagContainer>(0x28);
		
	}


	/// <summary>
	/// UEditableGameplayTagQueryExpression_NoTagsMatch:UEditableGameplayTagQueryExpression
	/// Size: 0x48
	/// Properties: 1
	/// </summary>
	public class UEditableGameplayTagQueryExpression_NoTagsMatch:UEditableGameplayTagQueryExpression
	{
		public override int ObjectSize => 72;
		/// <summary>
		/// Name: Tags
		/// Type: StructProperty
		/// Offset: 0x28
		/// Size: 0x20
		/// </summary>
		public FGameplayTagContainer Tags => ReadStruct<FGameplayTagContainer>(0x28);
		
	}


	/// <summary>
	/// UEditableGameplayTagQueryExpression_AnyExprMatch:UEditableGameplayTagQueryExpression
	/// Size: 0x38
	/// Properties: 1
	/// </summary>
	public class UEditableGameplayTagQueryExpression_AnyExprMatch:UEditableGameplayTagQueryExpression
	{
		public override int ObjectSize => 56;
		/// <summary>
		/// Name: Expressions
		/// Type: TArray<UEditableGameplayTagQueryExpression>
		/// Offset: 0x28
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<UEditableGameplayTagQueryExpression> Expressions => new TArray<UEditableGameplayTagQueryExpression>(BaseAddress+0x28);
		
	}


	/// <summary>
	/// UEditableGameplayTagQueryExpression_AllExprMatch:UEditableGameplayTagQueryExpression
	/// Size: 0x38
	/// Properties: 1
	/// </summary>
	public class UEditableGameplayTagQueryExpression_AllExprMatch:UEditableGameplayTagQueryExpression
	{
		public override int ObjectSize => 56;
		/// <summary>
		/// Name: Expressions
		/// Type: TArray<UEditableGameplayTagQueryExpression>
		/// Offset: 0x28
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<UEditableGameplayTagQueryExpression> Expressions => new TArray<UEditableGameplayTagQueryExpression>(BaseAddress+0x28);
		
	}


	/// <summary>
	/// UEditableGameplayTagQueryExpression_NoExprMatch:UEditableGameplayTagQueryExpression
	/// Size: 0x38
	/// Properties: 1
	/// </summary>
	public class UEditableGameplayTagQueryExpression_NoExprMatch:UEditableGameplayTagQueryExpression
	{
		public override int ObjectSize => 56;
		/// <summary>
		/// Name: Expressions
		/// Type: TArray<UEditableGameplayTagQueryExpression>
		/// Offset: 0x28
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<UEditableGameplayTagQueryExpression> Expressions => new TArray<UEditableGameplayTagQueryExpression>(BaseAddress+0x28);
		
	}


	/// <summary>
	/// UGameplayTagAssetInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UGameplayTagAssetInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UBlueprintGameplayTagLibrary:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBlueprintGameplayTagLibrary:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UGameplayTagsManager:UObject
	/// Size: 0x1D0
	/// Properties: 1
	/// </summary>
	public class UGameplayTagsManager:UObject
	{
		public override int ObjectSize => 464;
		/// <summary>
		/// Name: GameplayTagTables
		/// Type: TArray<UDataTable>
		/// Offset: 0x100
		/// Size: 0x10
		/// SubElement Size: 0x80
		/// </summary>
		public TArray<UDataTable> GameplayTagTables => new TArray<UDataTable>(BaseAddress+0x100);
		
	}


	/// <summary>
	/// UGameplayTagsSettings:UObject
	/// Size: 0x50
	/// Properties: 3
	/// </summary>
	public class UGameplayTagsSettings:UObject
	{
		public override int ObjectSize => 80;
		/// <summary>
		/// Name: GameplayTags
		/// Type: TArray<>
		/// Offset: 0x28
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: CommonlyReplicatedTags
		/// Type: TArray<>
		/// Offset: 0x38
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: NetIndexFirstBitSegment
		/// Type: IntProperty
		/// Offset: 0x48
		/// Size: 0x04
		/// </summary>
		public int NetIndexFirstBitSegment
		{
			get
			{
				return ReadInt32(0x48);
			}
			set
			{
				WriteInt32(0x48,value);
			}
		}
		
	}


	/// <summary>
	/// UGameplayTaskOwnerInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UGameplayTaskOwnerInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UGameplayTask:UObject
	/// Size: 0x68
	/// Properties: 2
	/// </summary>
	public class UGameplayTask:UObject
	{
		public override int ObjectSize => 104;
		/// <summary>
		/// Name: InstanceName
		/// Type: NameProperty
		/// Offset: 0x30
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: ChildTask
		/// Type: ObjectProperty
		/// Offset: 0x60
		/// Size: 0x08
		/// </summary>
		public UGameplayTask ChildTask => ReadUObject<UGameplayTask>(0x60);
		
	}


	/// <summary>
	/// UGameplayTask_SpawnActor:UGameplayTask
	/// Size: 0xA8
	/// Properties: 1
	/// </summary>
	public class UGameplayTask_SpawnActor:UGameplayTask
	{
		public override int ObjectSize => 168;
		/// <summary>
		/// Name: ClassToSpawn
		/// Type: ClassProperty
		/// Offset: 0xA0
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// UGameplayTask_WaitDelay:UGameplayTask
	/// Size: 0x80
	/// Properties: 0
	/// </summary>
	public class UGameplayTask_WaitDelay:UGameplayTask
	{
		public override int ObjectSize => 128;
	}


	/// <summary>
	/// UGameplayTaskResource:UObject
	/// Size: 0x38
	/// Properties: 3
	/// </summary>
	public class UGameplayTaskResource:UObject
	{
		public override int ObjectSize => 56;
		/// <summary>
		/// Name: ManualResourceID
		/// Type: IntProperty
		/// Offset: 0x28
		/// Size: 0x04
		/// </summary>
		public int ManualResourceID
		{
			get
			{
				return ReadInt32(0x28);
			}
			set
			{
				WriteInt32(0x28,value);
			}
		}
		
		/// <summary>
		/// Name: AutoResourceID
		/// Type: Int8Property
		/// Offset: 0x2C
		/// Size: 0x01
		/// </summary>
		
		/// <summary>
		/// Name: bManuallySetID
		/// Type: BoolProperty
		/// Offset: 0x30
		/// Size: 0x01
		/// </summary>
		public bool bManuallySetID => (ReadByte(0x0030) & 0x01) == 0x01;
		
	}


	/// <summary>
	/// UGameplayTasksComponent:UActorComponent
	/// Size: 0x140
	/// Properties: 3
	/// </summary>
	public class UGameplayTasksComponent:UActorComponent
	{
		public override int ObjectSize => 320;
		/// <summary>
		/// Name: SimulatedTasks
		/// Type: TArray<UGameplayTask>
		/// Offset: 0xE0
		/// Size: 0x10
		/// SubElement Size: 0x68
		/// </summary>
		public TArray<UGameplayTask> SimulatedTasks => new TArray<UGameplayTask>(BaseAddress+0xE0);
		
		/// <summary>
		/// Name: TaskPriorityQueue
		/// Type: TArray<UGameplayTask>
		/// Offset: 0xF0
		/// Size: 0x10
		/// SubElement Size: 0x68
		/// </summary>
		public TArray<UGameplayTask> TaskPriorityQueue => new TArray<UGameplayTask>(BaseAddress+0xF0);
		
		/// <summary>
		/// Name: TickingTasks
		/// Type: TArray<UGameplayTask>
		/// Offset: 0x110
		/// Size: 0x10
		/// SubElement Size: 0x68
		/// </summary>
		public TArray<UGameplayTask> TickingTasks => new TArray<UGameplayTask>(BaseAddress+0x110);
		
	}


	/// <summary>
	/// UAIResourceInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UAIResourceInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UAIAsyncTaskBlueprintProxy:UObject
	/// Size: 0x68
	/// Properties: 0
	/// </summary>
	public class UAIAsyncTaskBlueprintProxy:UObject
	{
		public override int ObjectSize => 104;
	}


	/// <summary>
	/// UAIBlueprintHelperLibrary:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UAIBlueprintHelperLibrary:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UPawnActionsComponent:UActorComponent
	/// Size: 0x110
	/// Properties: 4
	/// </summary>
	public class UPawnActionsComponent:UActorComponent
	{
		public override int ObjectSize => 272;
		/// <summary>
		/// Name: ControlledPawn
		/// Type: ObjectProperty
		/// Offset: 0xD8
		/// Size: 0x08
		/// </summary>
		public APawn ControlledPawn => ReadUObject<APawn>(0xD8);
		
		/// <summary>
		/// Name: ActionStacks
		/// Type: TArray<FPawnActionStack>
		/// Offset: 0xE0
		/// Size: 0x10
		/// SubElement Size: 0x08
		/// </summary>
		public TArray<FPawnActionStack> ActionStacks => new TArray<FPawnActionStack>(BaseAddress+0xE0);
		
		/// <summary>
		/// Name: ActionEvents
		/// Type: TArray<FPawnActionEvent>
		/// Offset: 0xF0
		/// Size: 0x10
		/// SubElement Size: 0x18
		/// </summary>
		public TArray<FPawnActionEvent> ActionEvents => new TArray<FPawnActionEvent>(BaseAddress+0xF0);
		
		/// <summary>
		/// Name: CurrentAction
		/// Type: ObjectProperty
		/// Offset: 0x100
		/// Size: 0x08
		/// </summary>
		public UPawnAction CurrentAction => ReadUObject<UPawnAction>(0x100);
		
	}


	/// <summary>
	/// UAIPerceptionListenerInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UAIPerceptionListenerInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UBehaviorTreeTypes:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBehaviorTreeTypes:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UGenericTeamAgentInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UGenericTeamAgentInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// ADetourCrowdAIController:AAIController
	/// Size: 0x4B8
	/// Properties: 0
	/// </summary>
	public class ADetourCrowdAIController:AAIController
	{
		public override int ObjectSize => 1208;
	}


	/// <summary>
	/// UAIDataProvider:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UAIDataProvider:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UAIDataProvider_QueryParams:UAIDataProvider
	/// Size: 0x40
	/// Properties: 4
	/// </summary>
	public class UAIDataProvider_QueryParams:UAIDataProvider
	{
		public override int ObjectSize => 64;
		/// <summary>
		/// Name: ParamName
		/// Type: NameProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: FloatValue
		/// Type: FloatProperty
		/// Offset: 0x30
		/// Size: 0x04
		/// </summary>
		public float FloatValue
		{
			get
			{
				return ReadSingle(0x30);
			}
			set
			{
				WriteSingle(0x30,value);
			}
		}
		
		/// <summary>
		/// Name: IntValue
		/// Type: IntProperty
		/// Offset: 0x34
		/// Size: 0x04
		/// </summary>
		public int IntValue
		{
			get
			{
				return ReadInt32(0x34);
			}
			set
			{
				WriteInt32(0x34,value);
			}
		}
		
		/// <summary>
		/// Name: BoolValue
		/// Type: BoolProperty
		/// Offset: 0x38
		/// Size: 0x01
		/// </summary>
		public bool BoolValue
		{
			get
			{
				return ReadBool(0x38);
			}
			set
			{
				WriteBool(0x38,value);
			}
		}
		
	}


	/// <summary>
	/// UAIHotSpotManager:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UAIHotSpotManager:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UAISystemBase:UObject
	/// Size: 0x48
	/// Properties: 3
	/// </summary>
	public class UAISystemBase:UObject
	{
		public override int ObjectSize => 72;
		/// <summary>
		/// Name: AISystemClassName
		/// Type: StructProperty
		/// Offset: 0x28
		/// Size: 0x10
		/// </summary>
		public FStringClassReference AISystemClassName => ReadStruct<FStringClassReference>(0x28);
		
		/// <summary>
		/// Name: AISystemModuleName
		/// Type: NameProperty
		/// Offset: 0x38
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: bInstantiateAISystemOnClient
		/// Type: BoolProperty
		/// Offset: 0x40
		/// Size: 0x01
		/// </summary>
		public bool bInstantiateAISystemOnClient
		{
			get
			{
				return ReadBool(0x40);
			}
			set
			{
				WriteBool(0x40,value);
			}
		}
		
	}


	/// <summary>
	/// UAISystem:UAISystemBase
	/// Size: 0x108
	/// Properties: 16
	/// </summary>
	public class UAISystem:UAISystemBase
	{
		public override int ObjectSize => 264;
		/// <summary>
		/// Name: PerceptionSystemClassName
		/// Type: StructProperty
		/// Offset: 0x48
		/// Size: 0x10
		/// </summary>
		public FStringClassReference PerceptionSystemClassName => ReadStruct<FStringClassReference>(0x48);
		
		/// <summary>
		/// Name: HotSpotManagerClassName
		/// Type: StructProperty
		/// Offset: 0x58
		/// Size: 0x10
		/// </summary>
		public FStringClassReference HotSpotManagerClassName => ReadStruct<FStringClassReference>(0x58);
		
		/// <summary>
		/// Name: AcceptanceRadius
		/// Type: FloatProperty
		/// Offset: 0x68
		/// Size: 0x04
		/// </summary>
		public float AcceptanceRadius
		{
			get
			{
				return ReadSingle(0x68);
			}
			set
			{
				WriteSingle(0x68,value);
			}
		}
		
		/// <summary>
		/// Name: PathfollowingRegularPathPointAcceptanceRadius
		/// Type: FloatProperty
		/// Offset: 0x6C
		/// Size: 0x04
		/// </summary>
		public float PathfollowingRegularPathPointAcceptanceRadius
		{
			get
			{
				return ReadSingle(0x6C);
			}
			set
			{
				WriteSingle(0x6C,value);
			}
		}
		
		/// <summary>
		/// Name: PathfollowingNavLinkAcceptanceRadius
		/// Type: FloatProperty
		/// Offset: 0x70
		/// Size: 0x04
		/// </summary>
		public float PathfollowingNavLinkAcceptanceRadius
		{
			get
			{
				return ReadSingle(0x70);
			}
			set
			{
				WriteSingle(0x70,value);
			}
		}
		
		/// <summary>
		/// Name: bFinishMoveOnGoalOverlap
		/// Type: BoolProperty
		/// Offset: 0x74
		/// Size: 0x01
		/// </summary>
		public bool bFinishMoveOnGoalOverlap
		{
			get
			{
				return ReadBool(0x74);
			}
			set
			{
				WriteBool(0x74,value);
			}
		}
		
		/// <summary>
		/// Name: bAcceptPartialPaths
		/// Type: BoolProperty
		/// Offset: 0x75
		/// Size: 0x01
		/// </summary>
		public bool bAcceptPartialPaths
		{
			get
			{
				return ReadBool(0x75);
			}
			set
			{
				WriteBool(0x75,value);
			}
		}
		
		/// <summary>
		/// Name: bAllowStrafing
		/// Type: BoolProperty
		/// Offset: 0x76
		/// Size: 0x01
		/// </summary>
		public bool bAllowStrafing
		{
			get
			{
				return ReadBool(0x76);
			}
			set
			{
				WriteBool(0x76,value);
			}
		}
		
		/// <summary>
		/// Name: bEnableBTAITasks
		/// Type: BoolProperty
		/// Offset: 0x77
		/// Size: 0x01
		/// </summary>
		public bool bEnableBTAITasks
		{
			get
			{
				return ReadBool(0x77);
			}
			set
			{
				WriteBool(0x77,value);
			}
		}
		
		/// <summary>
		/// Name: bAllowControllersAsEQSQuerier
		/// Type: BoolProperty
		/// Offset: 0x78
		/// Size: 0x01
		/// </summary>
		public bool bAllowControllersAsEQSQuerier
		{
			get
			{
				return ReadBool(0x78);
			}
			set
			{
				WriteBool(0x78,value);
			}
		}
		
		/// <summary>
		/// Name: bEnableDebuggerPlugin
		/// Type: BoolProperty
		/// Offset: 0x79
		/// Size: 0x01
		/// </summary>
		public bool bEnableDebuggerPlugin
		{
			get
			{
				return ReadBool(0x79);
			}
			set
			{
				WriteBool(0x79,value);
			}
		}
		
		/// <summary>
		/// Name: BehaviorTreeManager
		/// Type: ObjectProperty
		/// Offset: 0x80
		/// Size: 0x08
		/// </summary>
		public UBehaviorTreeManager BehaviorTreeManager => ReadUObject<UBehaviorTreeManager>(0x80);
		
		/// <summary>
		/// Name: EnvironmentQueryManager
		/// Type: ObjectProperty
		/// Offset: 0x88
		/// Size: 0x08
		/// </summary>
		public UEnvQueryManager EnvironmentQueryManager => ReadUObject<UEnvQueryManager>(0x88);
		
		/// <summary>
		/// Name: PerceptionSystem
		/// Type: ObjectProperty
		/// Offset: 0x90
		/// Size: 0x08
		/// </summary>
		public UAIPerceptionSystem PerceptionSystem => ReadUObject<UAIPerceptionSystem>(0x90);
		
		/// <summary>
		/// Name: AllProxyObjects
		/// Type: TArray<UAIAsyncTaskBlueprintProxy>
		/// Offset: 0x98
		/// Size: 0x10
		/// SubElement Size: 0x68
		/// </summary>
		public TArray<UAIAsyncTaskBlueprintProxy> AllProxyObjects => new TArray<UAIAsyncTaskBlueprintProxy>(BaseAddress+0x98);
		
		/// <summary>
		/// Name: HotSpotManager
		/// Type: ObjectProperty
		/// Offset: 0xA8
		/// Size: 0x08
		/// </summary>
		public UAIHotSpotManager HotSpotManager => ReadUObject<UAIHotSpotManager>(0xA8);
		
	}


	/// <summary>
	/// UAIPerceptionSystem:UObject
	/// Size: 0x130
	/// Properties: 2
	/// </summary>
	public class UAIPerceptionSystem:UObject
	{
		public override int ObjectSize => 304;
		/// <summary>
		/// Name: Senses
		/// Type: TArray<UAISense>
		/// Offset: 0x80
		/// Size: 0x10
		/// SubElement Size: 0x120
		/// </summary>
		public TArray<UAISense> Senses => new TArray<UAISense>(BaseAddress+0x80);
		
		/// <summary>
		/// Name: PerceptionAgingRate
		/// Type: FloatProperty
		/// Offset: 0x90
		/// Size: 0x04
		/// </summary>
		public float PerceptionAgingRate
		{
			get
			{
				return ReadSingle(0x90);
			}
			set
			{
				WriteSingle(0x90,value);
			}
		}
		
	}


	/// <summary>
	/// UAIPerceptionComponent:UActorComponent
	/// Size: 0x1C8
	/// Properties: 8
	/// </summary>
	public class UAIPerceptionComponent:UActorComponent
	{
		public override int ObjectSize => 456;
		/// <summary>
		/// Name: HearingRange
		/// Type: FloatProperty
		/// Offset: 0xD8
		/// Size: 0x04
		/// </summary>
		public float HearingRange
		{
			get
			{
				return ReadSingle(0xD8);
			}
			set
			{
				WriteSingle(0xD8,value);
			}
		}
		
		/// <summary>
		/// Name: LoSHearingRange
		/// Type: FloatProperty
		/// Offset: 0xDC
		/// Size: 0x04
		/// </summary>
		public float LoSHearingRange
		{
			get
			{
				return ReadSingle(0xDC);
			}
			set
			{
				WriteSingle(0xDC,value);
			}
		}
		
		/// <summary>
		/// Name: SightRadius
		/// Type: FloatProperty
		/// Offset: 0xE0
		/// Size: 0x04
		/// </summary>
		public float SightRadius
		{
			get
			{
				return ReadSingle(0xE0);
			}
			set
			{
				WriteSingle(0xE0,value);
			}
		}
		
		/// <summary>
		/// Name: LoseSightRadius
		/// Type: FloatProperty
		/// Offset: 0xE4
		/// Size: 0x04
		/// </summary>
		public float LoseSightRadius
		{
			get
			{
				return ReadSingle(0xE4);
			}
			set
			{
				WriteSingle(0xE4,value);
			}
		}
		
		/// <summary>
		/// Name: PeripheralVisionAngle
		/// Type: FloatProperty
		/// Offset: 0xE8
		/// Size: 0x04
		/// </summary>
		public float PeripheralVisionAngle
		{
			get
			{
				return ReadSingle(0xE8);
			}
			set
			{
				WriteSingle(0xE8,value);
			}
		}
		
		/// <summary>
		/// Name: SensesConfig
		/// Type: TArray<UAISenseConfig>
		/// Offset: 0xF0
		/// Size: 0x10
		/// SubElement Size: 0x48
		/// </summary>
		public TArray<UAISenseConfig> SensesConfig => new TArray<UAISenseConfig>(BaseAddress+0xF0);
		
		/// <summary>
		/// Name: DominantSense
		/// Type: ClassProperty
		/// Offset: 0x100
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: AIOwner
		/// Type: ObjectProperty
		/// Offset: 0x118
		/// Size: 0x08
		/// </summary>
		public AAIController AIOwner => ReadUObject<AAIController>(0x118);
		
	}


	/// <summary>
	/// UAIPerceptionStimuliSourceComponent:UActorComponent
	/// Size: 0xF0
	/// Properties: 2
	/// </summary>
	public class UAIPerceptionStimuliSourceComponent:UActorComponent
	{
		public override int ObjectSize => 240;
		/// <summary>
		/// Name: bAutoRegisterAsSource
		/// Type: BoolProperty
		/// Offset: 0xD8
		/// Size: 0x01
		/// </summary>
		public bool bAutoRegisterAsSource => (ReadByte(0x00D8) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: RegisterAsSourceForSenses
		/// Type: TArray<>
		/// Offset: 0xE0
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
	}


	/// <summary>
	/// UAIResource_Movement:UGameplayTaskResource
	/// Size: 0x38
	/// Properties: 0
	/// </summary>
	public class UAIResource_Movement:UGameplayTaskResource
	{
		public override int ObjectSize => 56;
	}


	/// <summary>
	/// UAIResource_Logic:UGameplayTaskResource
	/// Size: 0x38
	/// Properties: 0
	/// </summary>
	public class UAIResource_Logic:UGameplayTaskResource
	{
		public override int ObjectSize => 56;
	}


	/// <summary>
	/// UAISense_Blueprint:UAISense
	/// Size: 0x150
	/// Properties: 3
	/// </summary>
	public class UAISense_Blueprint:UAISense
	{
		public override int ObjectSize => 336;
		/// <summary>
		/// Name: ListenerDataType
		/// Type: ClassProperty
		/// Offset: 0x120
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: ListenerContainer
		/// Type: TArray<UAIPerceptionComponent>
		/// Offset: 0x128
		/// Size: 0x10
		/// SubElement Size: 0x1C8
		/// </summary>
		public TArray<UAIPerceptionComponent> ListenerContainer => new TArray<UAIPerceptionComponent>(BaseAddress+0x128);
		
		/// <summary>
		/// Name: UnprocessedEvents
		/// Type: TArray<UAISenseEvent>
		/// Offset: 0x138
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<UAISenseEvent> UnprocessedEvents => new TArray<UAISenseEvent>(BaseAddress+0x138);
		
	}


	/// <summary>
	/// UAISense_Damage:UAISense
	/// Size: 0x130
	/// Properties: 1
	/// </summary>
	public class UAISense_Damage:UAISense
	{
		public override int ObjectSize => 304;
		/// <summary>
		/// Name: RegisteredEvents
		/// Type: TArray<FAIDamageEvent>
		/// Offset: 0x120
		/// Size: 0x10
		/// SubElement Size: 0x30
		/// </summary>
		public TArray<FAIDamageEvent> RegisteredEvents => new TArray<FAIDamageEvent>(BaseAddress+0x120);
		
	}


	/// <summary>
	/// UAISense_Hearing:UAISense
	/// Size: 0x190
	/// Properties: 2
	/// </summary>
	public class UAISense_Hearing:UAISense
	{
		public override int ObjectSize => 400;
		/// <summary>
		/// Name: NoiseEvents
		/// Type: TArray<FAINoiseEvent>
		/// Offset: 0x120
		/// Size: 0x10
		/// SubElement Size: 0x30
		/// </summary>
		public TArray<FAINoiseEvent> NoiseEvents => new TArray<FAINoiseEvent>(BaseAddress+0x120);
		
		/// <summary>
		/// Name: SpeedOfSoundSq
		/// Type: FloatProperty
		/// Offset: 0x130
		/// Size: 0x04
		/// </summary>
		public float SpeedOfSoundSq
		{
			get
			{
				return ReadSingle(0x130);
			}
			set
			{
				WriteSingle(0x130,value);
			}
		}
		
	}


	/// <summary>
	/// UAISense_Prediction:UAISense
	/// Size: 0x130
	/// Properties: 1
	/// </summary>
	public class UAISense_Prediction:UAISense
	{
		public override int ObjectSize => 304;
		/// <summary>
		/// Name: RegisteredEvents
		/// Type: TArray<FAIPredictionEvent>
		/// Offset: 0x120
		/// Size: 0x10
		/// SubElement Size: 0x18
		/// </summary>
		public TArray<FAIPredictionEvent> RegisteredEvents => new TArray<FAIPredictionEvent>(BaseAddress+0x120);
		
	}


	/// <summary>
	/// UAISense_Sight:UAISense
	/// Size: 0x1F0
	/// Properties: 6
	/// </summary>
	public class UAISense_Sight:UAISense
	{
		public override int ObjectSize => 496;
		/// <summary>
		/// Name: MaxTracesPerTick
		/// Type: IntProperty
		/// Offset: 0x1D0
		/// Size: 0x04
		/// </summary>
		public int MaxTracesPerTick
		{
			get
			{
				return ReadInt32(0x1D0);
			}
			set
			{
				WriteInt32(0x1D0,value);
			}
		}
		
		/// <summary>
		/// Name: MinQueriesPerTimeSliceCheck
		/// Type: IntProperty
		/// Offset: 0x1D4
		/// Size: 0x04
		/// </summary>
		public int MinQueriesPerTimeSliceCheck
		{
			get
			{
				return ReadInt32(0x1D4);
			}
			set
			{
				WriteInt32(0x1D4,value);
			}
		}
		
		/// <summary>
		/// Name: MaxTimeSlicePerTick
		/// Type: DoubleProperty
		/// Offset: 0x1D8
		/// Size: 0x08
		/// </summary>
		public double MaxTimeSlicePerTick
		{
			get
			{
				return ReadDouble(0x1D8);
			}
			set
			{
				WriteDouble(0x1D8,value);
			}
		}
		
		/// <summary>
		/// Name: HighImportanceQueryDistanceThreshold
		/// Type: FloatProperty
		/// Offset: 0x1E0
		/// Size: 0x04
		/// </summary>
		public float HighImportanceQueryDistanceThreshold
		{
			get
			{
				return ReadSingle(0x1E0);
			}
			set
			{
				WriteSingle(0x1E0,value);
			}
		}
		
		/// <summary>
		/// Name: MaxQueryImportance
		/// Type: FloatProperty
		/// Offset: 0x1E8
		/// Size: 0x04
		/// </summary>
		public float MaxQueryImportance
		{
			get
			{
				return ReadSingle(0x1E8);
			}
			set
			{
				WriteSingle(0x1E8,value);
			}
		}
		
		/// <summary>
		/// Name: SightLimitQueryImportance
		/// Type: FloatProperty
		/// Offset: 0x1EC
		/// Size: 0x04
		/// </summary>
		public float SightLimitQueryImportance
		{
			get
			{
				return ReadSingle(0x1EC);
			}
			set
			{
				WriteSingle(0x1EC,value);
			}
		}
		
	}


	/// <summary>
	/// UAISense_Team:UAISense
	/// Size: 0x130
	/// Properties: 1
	/// </summary>
	public class UAISense_Team:UAISense
	{
		public override int ObjectSize => 304;
		/// <summary>
		/// Name: RegisteredEvents
		/// Type: TArray<FAITeamStimulusEvent>
		/// Offset: 0x120
		/// Size: 0x10
		/// SubElement Size: 0x38
		/// </summary>
		public TArray<FAITeamStimulusEvent> RegisteredEvents => new TArray<FAITeamStimulusEvent>(BaseAddress+0x120);
		
	}


	/// <summary>
	/// UAISense_Touch:UAISense
	/// Size: 0x130
	/// Properties: 1
	/// </summary>
	public class UAISense_Touch:UAISense
	{
		public override int ObjectSize => 304;
		/// <summary>
		/// Name: RegisteredEvents
		/// Type: TArray<FAITouchEvent>
		/// Offset: 0x120
		/// Size: 0x10
		/// SubElement Size: 0x20
		/// </summary>
		public TArray<FAITouchEvent> RegisteredEvents => new TArray<FAITouchEvent>(BaseAddress+0x120);
		
	}


	/// <summary>
	/// UUserDefinedStruct:UScriptStruct
	/// Size: 0xA8
	/// Properties: 1
	/// </summary>
	public class UUserDefinedStruct:UScriptStruct
	{
		public override int ObjectSize => 168;
		/// <summary>
		/// Name: Guid
		/// Type: StructProperty
		/// Offset: 0x98
		/// Size: 0x10
		/// </summary>
		public FGuid Guid => ReadStruct<FGuid>(0x98);
		
	}


	/// <summary>
	/// UAISenseBlueprintListener:UUserDefinedStruct
	/// Size: 0xA8
	/// Properties: 0
	/// </summary>
	public class UAISenseBlueprintListener:UUserDefinedStruct
	{
		public override int ObjectSize => 168;
	}


	/// <summary>
	/// UAISenseConfig_Blueprint:UAISenseConfig
	/// Size: 0x50
	/// Properties: 1
	/// </summary>
	public class UAISenseConfig_Blueprint:UAISenseConfig
	{
		public override int ObjectSize => 80;
		/// <summary>
		/// Name: Implementation
		/// Type: ClassProperty
		/// Offset: 0x48
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// UAISenseConfig_Damage:UAISenseConfig
	/// Size: 0x50
	/// Properties: 1
	/// </summary>
	public class UAISenseConfig_Damage:UAISenseConfig
	{
		public override int ObjectSize => 80;
		/// <summary>
		/// Name: Implementation
		/// Type: ClassProperty
		/// Offset: 0x48
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// UAISenseConfig_Hearing:UAISenseConfig
	/// Size: 0x60
	/// Properties: 5
	/// </summary>
	public class UAISenseConfig_Hearing:UAISenseConfig
	{
		public override int ObjectSize => 96;
		/// <summary>
		/// Name: Implementation
		/// Type: ClassProperty
		/// Offset: 0x48
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: HearingRange
		/// Type: FloatProperty
		/// Offset: 0x50
		/// Size: 0x04
		/// </summary>
		public float HearingRange
		{
			get
			{
				return ReadSingle(0x50);
			}
			set
			{
				WriteSingle(0x50,value);
			}
		}
		
		/// <summary>
		/// Name: LoSHearingRange
		/// Type: FloatProperty
		/// Offset: 0x54
		/// Size: 0x04
		/// </summary>
		public float LoSHearingRange
		{
			get
			{
				return ReadSingle(0x54);
			}
			set
			{
				WriteSingle(0x54,value);
			}
		}
		
		/// <summary>
		/// Name: bUseLoSHearing
		/// Type: BoolProperty
		/// Offset: 0x58
		/// Size: 0x01
		/// </summary>
		public bool bUseLoSHearing => (ReadByte(0x0058) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: DetectionByAffiliation
		/// Type: StructProperty
		/// Offset: 0x5C
		/// Size: 0x04
		/// </summary>
		public FAISenseAffiliationFilter DetectionByAffiliation => ReadStruct<FAISenseAffiliationFilter>(0x5C);
		
	}


	/// <summary>
	/// UAISenseConfig_Prediction:UAISenseConfig
	/// Size: 0x48
	/// Properties: 0
	/// </summary>
	public class UAISenseConfig_Prediction:UAISenseConfig
	{
		public override int ObjectSize => 72;
	}


	/// <summary>
	/// UAISenseConfig_Sight:UAISenseConfig
	/// Size: 0x68
	/// Properties: 6
	/// </summary>
	public class UAISenseConfig_Sight:UAISenseConfig
	{
		public override int ObjectSize => 104;
		/// <summary>
		/// Name: Implementation
		/// Type: ClassProperty
		/// Offset: 0x48
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: SightRadius
		/// Type: FloatProperty
		/// Offset: 0x50
		/// Size: 0x04
		/// </summary>
		public float SightRadius
		{
			get
			{
				return ReadSingle(0x50);
			}
			set
			{
				WriteSingle(0x50,value);
			}
		}
		
		/// <summary>
		/// Name: LoseSightRadius
		/// Type: FloatProperty
		/// Offset: 0x54
		/// Size: 0x04
		/// </summary>
		public float LoseSightRadius
		{
			get
			{
				return ReadSingle(0x54);
			}
			set
			{
				WriteSingle(0x54,value);
			}
		}
		
		/// <summary>
		/// Name: PeripheralVisionAngleDegrees
		/// Type: FloatProperty
		/// Offset: 0x58
		/// Size: 0x04
		/// </summary>
		public float PeripheralVisionAngleDegrees
		{
			get
			{
				return ReadSingle(0x58);
			}
			set
			{
				WriteSingle(0x58,value);
			}
		}
		
		/// <summary>
		/// Name: DetectionByAffiliation
		/// Type: StructProperty
		/// Offset: 0x5C
		/// Size: 0x04
		/// </summary>
		public FAISenseAffiliationFilter DetectionByAffiliation => ReadStruct<FAISenseAffiliationFilter>(0x5C);
		
		/// <summary>
		/// Name: AutoSuccessRangeFromLastSeenLocation
		/// Type: FloatProperty
		/// Offset: 0x60
		/// Size: 0x04
		/// </summary>
		public float AutoSuccessRangeFromLastSeenLocation
		{
			get
			{
				return ReadSingle(0x60);
			}
			set
			{
				WriteSingle(0x60,value);
			}
		}
		
	}


	/// <summary>
	/// UAISenseConfig_Team:UAISenseConfig
	/// Size: 0x48
	/// Properties: 0
	/// </summary>
	public class UAISenseConfig_Team:UAISenseConfig
	{
		public override int ObjectSize => 72;
	}


	/// <summary>
	/// UAISenseConfig_Touch:UAISenseConfig
	/// Size: 0x48
	/// Properties: 0
	/// </summary>
	public class UAISenseConfig_Touch:UAISenseConfig
	{
		public override int ObjectSize => 72;
	}


	/// <summary>
	/// UAISenseEvent:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UAISenseEvent:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UAISenseEvent_Damage:UAISenseEvent
	/// Size: 0x58
	/// Properties: 1
	/// </summary>
	public class UAISenseEvent_Damage:UAISenseEvent
	{
		public override int ObjectSize => 88;
		/// <summary>
		/// Name: Event
		/// Type: StructProperty
		/// Offset: 0x28
		/// Size: 0x30
		/// </summary>
		public FAIDamageEvent Event => ReadStruct<FAIDamageEvent>(0x28);
		
	}


	/// <summary>
	/// UAISenseEvent_Hearing:UAISenseEvent
	/// Size: 0x58
	/// Properties: 1
	/// </summary>
	public class UAISenseEvent_Hearing:UAISenseEvent
	{
		public override int ObjectSize => 88;
		/// <summary>
		/// Name: Event
		/// Type: StructProperty
		/// Offset: 0x28
		/// Size: 0x30
		/// </summary>
		public FAINoiseEvent Event => ReadStruct<FAINoiseEvent>(0x28);
		
	}


	/// <summary>
	/// UAISightTargetInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UAISightTargetInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UAITask:UGameplayTask
	/// Size: 0x70
	/// Properties: 1
	/// </summary>
	public class UAITask:UGameplayTask
	{
		public override int ObjectSize => 112;
		/// <summary>
		/// Name: OwnerController
		/// Type: ObjectProperty
		/// Offset: 0x68
		/// Size: 0x08
		/// </summary>
		public AAIController OwnerController => ReadUObject<AAIController>(0x68);
		
	}


	/// <summary>
	/// UAITask_LockLogic:UAITask
	/// Size: 0x70
	/// Properties: 0
	/// </summary>
	public class UAITask_LockLogic:UAITask
	{
		public override int ObjectSize => 112;
	}


	/// <summary>
	/// UAITask_MoveTo:UAITask
	/// Size: 0x108
	/// Properties: 1
	/// </summary>
	public class UAITask_MoveTo:UAITask
	{
		public override int ObjectSize => 264;
		/// <summary>
		/// Name: MoveRequest
		/// Type: StructProperty
		/// Offset: 0x90
		/// Size: 0x38
		/// </summary>
		public FAIMoveRequest MoveRequest => ReadStruct<FAIMoveRequest>(0x90);
		
	}


	/// <summary>
	/// UBTNode:UObject
	/// Size: 0x58
	/// Properties: 3
	/// </summary>
	public class UBTNode:UObject
	{
		public override int ObjectSize => 88;
		/// <summary>
		/// Name: NodeName
		/// Type: StrProperty
		/// Offset: 0x30
		/// Size: 0x10
		/// </summary>
		public FString NodeName => new FString(BaseAddress+0x30);
		
		/// <summary>
		/// Name: TreeAsset
		/// Type: ObjectProperty
		/// Offset: 0x40
		/// Size: 0x08
		/// </summary>
		public UBehaviorTree TreeAsset => ReadUObject<UBehaviorTree>(0x40);
		
		/// <summary>
		/// Name: ParentNode
		/// Type: ObjectProperty
		/// Offset: 0x48
		/// Size: 0x08
		/// </summary>
		public UBTCompositeNode ParentNode => ReadUObject<UBTCompositeNode>(0x48);
		
	}


	/// <summary>
	/// UBTCompositeNode:UBTNode
	/// Size: 0xD0
	/// Properties: 2
	/// </summary>
	public class UBTCompositeNode:UBTNode
	{
		public override int ObjectSize => 208;
		/// <summary>
		/// Name: Children
		/// Type: TArray<FBTCompositeChild>
		/// Offset: 0x58
		/// Size: 0x10
		/// SubElement Size: 0x30
		/// </summary>
		public TArray<FBTCompositeChild> Children => new TArray<FBTCompositeChild>(BaseAddress+0x58);
		
		/// <summary>
		/// Name: Services
		/// Type: TArray<UBTService>
		/// Offset: 0x68
		/// Size: 0x10
		/// SubElement Size: 0x70
		/// </summary>
		public TArray<UBTService> Services => new TArray<UBTService>(BaseAddress+0x68);
		
	}


	/// <summary>
	/// UBTTaskNode:UBTNode
	/// Size: 0x70
	/// Properties: 2
	/// </summary>
	public class UBTTaskNode:UBTNode
	{
		public override int ObjectSize => 112;
		/// <summary>
		/// Name: Services
		/// Type: TArray<UBTService>
		/// Offset: 0x58
		/// Size: 0x10
		/// SubElement Size: 0x70
		/// </summary>
		public TArray<UBTService> Services => new TArray<UBTService>(BaseAddress+0x58);
		
		/// <summary>
		/// Name: bIgnoreRestartSelf
		/// Type: BoolProperty
		/// Offset: 0x68
		/// Size: 0x01
		/// </summary>
		public bool bIgnoreRestartSelf => (ReadByte(0x0068) & 0x01) == 0x01;
		
	}


	/// <summary>
	/// UBehaviorTree:UObject
	/// Size: 0x60
	/// Properties: 4
	/// </summary>
	public class UBehaviorTree:UObject
	{
		public override int ObjectSize => 96;
		/// <summary>
		/// Name: RootNode
		/// Type: ObjectProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		public UBTCompositeNode RootNode => ReadUObject<UBTCompositeNode>(0x28);
		
		/// <summary>
		/// Name: BlackboardAsset
		/// Type: ObjectProperty
		/// Offset: 0x30
		/// Size: 0x08
		/// </summary>
		public UBlackboardData BlackboardAsset => ReadUObject<UBlackboardData>(0x30);
		
		/// <summary>
		/// Name: RootDecorators
		/// Type: TArray<UBTDecorator>
		/// Offset: 0x38
		/// Size: 0x10
		/// SubElement Size: 0x68
		/// </summary>
		public TArray<UBTDecorator> RootDecorators => new TArray<UBTDecorator>(BaseAddress+0x38);
		
		/// <summary>
		/// Name: RootDecoratorOps
		/// Type: TArray<FBTDecoratorLogic>
		/// Offset: 0x48
		/// Size: 0x10
		/// SubElement Size: 0x04
		/// </summary>
		public TArray<FBTDecoratorLogic> RootDecoratorOps => new TArray<FBTDecoratorLogic>(BaseAddress+0x48);
		
	}


	/// <summary>
	/// UBehaviorTreeManager:UObject
	/// Size: 0x50
	/// Properties: 3
	/// </summary>
	public class UBehaviorTreeManager:UObject
	{
		public override int ObjectSize => 80;
		/// <summary>
		/// Name: MaxDebuggerSteps
		/// Type: IntProperty
		/// Offset: 0x28
		/// Size: 0x04
		/// </summary>
		public int MaxDebuggerSteps
		{
			get
			{
				return ReadInt32(0x28);
			}
			set
			{
				WriteInt32(0x28,value);
			}
		}
		
		/// <summary>
		/// Name: LoadedTemplates
		/// Type: TArray<FBehaviorTreeTemplateInfo>
		/// Offset: 0x30
		/// Size: 0x10
		/// SubElement Size: 0x18
		/// </summary>
		public TArray<FBehaviorTreeTemplateInfo> LoadedTemplates => new TArray<FBehaviorTreeTemplateInfo>(BaseAddress+0x30);
		
		/// <summary>
		/// Name: ActiveComponents
		/// Type: TArray<UBehaviorTreeComponent>
		/// Offset: 0x40
		/// Size: 0x10
		/// SubElement Size: 0x270
		/// </summary>
		public TArray<UBehaviorTreeComponent> ActiveComponents => new TArray<UBehaviorTreeComponent>(BaseAddress+0x40);
		
	}


	/// <summary>
	/// UBlackboardKeyType:UObject
	/// Size: 0x30
	/// Properties: 0
	/// </summary>
	public class UBlackboardKeyType:UObject
	{
		public override int ObjectSize => 48;
	}


	/// <summary>
	/// UBlackboardKeyType_Enum:UBlackboardKeyType
	/// Size: 0x50
	/// Properties: 3
	/// </summary>
	public class UBlackboardKeyType_Enum:UBlackboardKeyType
	{
		public override int ObjectSize => 80;
		/// <summary>
		/// Name: EnumType
		/// Type: ObjectProperty
		/// Offset: 0x30
		/// Size: 0x08
		/// </summary>
		public UEnum EnumType => ReadUObject<UEnum>(0x30);
		
		/// <summary>
		/// Name: EnumName
		/// Type: StrProperty
		/// Offset: 0x38
		/// Size: 0x10
		/// </summary>
		public FString EnumName => new FString(BaseAddress+0x38);
		
		/// <summary>
		/// Name: bIsEnumNameValid
		/// Type: BoolProperty
		/// Offset: 0x48
		/// Size: 0x01
		/// </summary>
		public bool bIsEnumNameValid => (ReadByte(0x0048) & 0x01) == 0x01;
		
	}


	/// <summary>
	/// UBlackboardKeyType_NativeEnum:UBlackboardKeyType
	/// Size: 0x48
	/// Properties: 2
	/// </summary>
	public class UBlackboardKeyType_NativeEnum:UBlackboardKeyType
	{
		public override int ObjectSize => 72;
		/// <summary>
		/// Name: EnumName
		/// Type: StrProperty
		/// Offset: 0x30
		/// Size: 0x10
		/// </summary>
		public FString EnumName => new FString(BaseAddress+0x30);
		
		/// <summary>
		/// Name: EnumType
		/// Type: ObjectProperty
		/// Offset: 0x40
		/// Size: 0x08
		/// </summary>
		public UEnum EnumType => ReadUObject<UEnum>(0x40);
		
	}


	/// <summary>
	/// UDataAsset:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UDataAsset:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UBlackboardData:UDataAsset
	/// Size: 0x48
	/// Properties: 3
	/// </summary>
	public class UBlackboardData:UDataAsset
	{
		public override int ObjectSize => 72;
		/// <summary>
		/// Name: Parent
		/// Type: ObjectProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		public UBlackboardData Parent => ReadUObject<UBlackboardData>(0x28);
		
		/// <summary>
		/// Name: Keys
		/// Type: TArray<FBlackboardEntry>
		/// Offset: 0x30
		/// Size: 0x10
		/// SubElement Size: 0x18
		/// </summary>
		public TArray<FBlackboardEntry> Keys => new TArray<FBlackboardEntry>(BaseAddress+0x30);
		
		/// <summary>
		/// Name: bHasSynchronizedKeys
		/// Type: BoolProperty
		/// Offset: 0x40
		/// Size: 0x01
		/// </summary>
		public bool bHasSynchronizedKeys => (ReadByte(0x0040) & 0x01) == 0x01;
		
	}


	/// <summary>
	/// UBlackboardComponent:UActorComponent
	/// Size: 0x1D0
	/// Properties: 3
	/// </summary>
	public class UBlackboardComponent:UActorComponent
	{
		public override int ObjectSize => 464;
		/// <summary>
		/// Name: BrainComp
		/// Type: ObjectProperty
		/// Offset: 0xD8
		/// Size: 0x08
		/// </summary>
		public UBrainComponent BrainComp => ReadUObject<UBrainComponent>(0xD8);
		
		/// <summary>
		/// Name: BlackboardAsset
		/// Type: ObjectProperty
		/// Offset: 0xE0
		/// Size: 0x08
		/// </summary>
		public UBlackboardData BlackboardAsset => ReadUObject<UBlackboardData>(0xE0);
		
		/// <summary>
		/// Name: KeyInstances
		/// Type: TArray<UBlackboardKeyType>
		/// Offset: 0x108
		/// Size: 0x10
		/// SubElement Size: 0x30
		/// </summary>
		public TArray<UBlackboardKeyType> KeyInstances => new TArray<UBlackboardKeyType>(BaseAddress+0x108);
		
	}


	/// <summary>
	/// UBlackboardKeyType_Bool:UBlackboardKeyType
	/// Size: 0x30
	/// Properties: 0
	/// </summary>
	public class UBlackboardKeyType_Bool:UBlackboardKeyType
	{
		public override int ObjectSize => 48;
	}


	/// <summary>
	/// UBlackboardKeyType_Class:UBlackboardKeyType
	/// Size: 0x38
	/// Properties: 1
	/// </summary>
	public class UBlackboardKeyType_Class:UBlackboardKeyType
	{
		public override int ObjectSize => 56;
		/// <summary>
		/// Name: BaseClass
		/// Type: ClassProperty
		/// Offset: 0x30
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// UBlackboardKeyType_Float:UBlackboardKeyType
	/// Size: 0x30
	/// Properties: 0
	/// </summary>
	public class UBlackboardKeyType_Float:UBlackboardKeyType
	{
		public override int ObjectSize => 48;
	}


	/// <summary>
	/// UBlackboardKeyType_Int:UBlackboardKeyType
	/// Size: 0x30
	/// Properties: 0
	/// </summary>
	public class UBlackboardKeyType_Int:UBlackboardKeyType
	{
		public override int ObjectSize => 48;
	}


	/// <summary>
	/// UBlackboardKeyType_Name:UBlackboardKeyType
	/// Size: 0x30
	/// Properties: 0
	/// </summary>
	public class UBlackboardKeyType_Name:UBlackboardKeyType
	{
		public override int ObjectSize => 48;
	}


	/// <summary>
	/// UBlackboardKeyType_Object:UBlackboardKeyType
	/// Size: 0x38
	/// Properties: 1
	/// </summary>
	public class UBlackboardKeyType_Object:UBlackboardKeyType
	{
		public override int ObjectSize => 56;
		/// <summary>
		/// Name: BaseClass
		/// Type: ClassProperty
		/// Offset: 0x30
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// UBlackboardKeyType_Rotator:UBlackboardKeyType
	/// Size: 0x30
	/// Properties: 0
	/// </summary>
	public class UBlackboardKeyType_Rotator:UBlackboardKeyType
	{
		public override int ObjectSize => 48;
	}


	/// <summary>
	/// UBlackboardKeyType_String:UBlackboardKeyType
	/// Size: 0x40
	/// Properties: 1
	/// </summary>
	public class UBlackboardKeyType_String:UBlackboardKeyType
	{
		public override int ObjectSize => 64;
		/// <summary>
		/// Name: StringValue
		/// Type: StrProperty
		/// Offset: 0x30
		/// Size: 0x10
		/// </summary>
		public FString StringValue => new FString(BaseAddress+0x30);
		
	}


	/// <summary>
	/// UBlackboardKeyType_Vector:UBlackboardKeyType
	/// Size: 0x30
	/// Properties: 0
	/// </summary>
	public class UBlackboardKeyType_Vector:UBlackboardKeyType
	{
		public override int ObjectSize => 48;
	}


	/// <summary>
	/// UBTFunctionLibrary:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBTFunctionLibrary:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UBTAuxiliaryNode:UBTNode
	/// Size: 0x60
	/// Properties: 0
	/// </summary>
	public class UBTAuxiliaryNode:UBTNode
	{
		public override int ObjectSize => 96;
	}


	/// <summary>
	/// UBTDecorator:UBTAuxiliaryNode
	/// Size: 0x68
	/// Properties: 2
	/// </summary>
	public class UBTDecorator:UBTAuxiliaryNode
	{
		public override int ObjectSize => 104;
		/// <summary>
		/// Name: bInverseCondition
		/// Type: BoolProperty
		/// Offset: 0x60
		/// Size: 0x01
		/// </summary>
		public bool bInverseCondition => (ReadByte(0x0060) & 0x80) == 0x80;
		
		/// <summary>
		/// Name: FlowAbortMode
		/// Type: ByteProperty
		/// Offset: 0x64
		/// Size: 0x01
		/// </summary>
		public byte FlowAbortMode
		{
			get
			{
				return ReadByte(0x64);
			}
			set
			{
				WriteByte(0x64,value);
			}
		}
		
	}


	/// <summary>
	/// UBTDecorator_BlackboardBase:UBTDecorator
	/// Size: 0x90
	/// Properties: 1
	/// </summary>
	public class UBTDecorator_BlackboardBase:UBTDecorator
	{
		public override int ObjectSize => 144;
		/// <summary>
		/// Name: BlackboardKey
		/// Type: StructProperty
		/// Offset: 0x68
		/// Size: 0x28
		/// </summary>
		public FBlackboardKeySelector BlackboardKey => ReadStruct<FBlackboardKeySelector>(0x68);
		
	}


	/// <summary>
	/// UBTDecorator_Blackboard:UBTDecorator_BlackboardBase
	/// Size: 0xC0
	/// Properties: 6
	/// </summary>
	public class UBTDecorator_Blackboard:UBTDecorator_BlackboardBase
	{
		public override int ObjectSize => 192;
		/// <summary>
		/// Name: IntValue
		/// Type: IntProperty
		/// Offset: 0x90
		/// Size: 0x04
		/// </summary>
		public int IntValue
		{
			get
			{
				return ReadInt32(0x90);
			}
			set
			{
				WriteInt32(0x90,value);
			}
		}
		
		/// <summary>
		/// Name: FloatValue
		/// Type: FloatProperty
		/// Offset: 0x94
		/// Size: 0x04
		/// </summary>
		public float FloatValue
		{
			get
			{
				return ReadSingle(0x94);
			}
			set
			{
				WriteSingle(0x94,value);
			}
		}
		
		/// <summary>
		/// Name: StringValue
		/// Type: StrProperty
		/// Offset: 0x98
		/// Size: 0x10
		/// </summary>
		public FString StringValue => new FString(BaseAddress+0x98);
		
		/// <summary>
		/// Name: CachedDescription
		/// Type: StrProperty
		/// Offset: 0xA8
		/// Size: 0x10
		/// </summary>
		public FString CachedDescription => new FString(BaseAddress+0xA8);
		
		/// <summary>
		/// Name: OperationType
		/// Type: ByteProperty
		/// Offset: 0xB8
		/// Size: 0x01
		/// </summary>
		public byte OperationType
		{
			get
			{
				return ReadByte(0xB8);
			}
			set
			{
				WriteByte(0xB8,value);
			}
		}
		
		/// <summary>
		/// Name: NotifyObserver
		/// Type: ByteProperty
		/// Offset: 0xB9
		/// Size: 0x01
		/// </summary>
		public byte NotifyObserver
		{
			get
			{
				return ReadByte(0xB9);
			}
			set
			{
				WriteByte(0xB9,value);
			}
		}
		
	}


	/// <summary>
	/// UBTDecorator_ConditionalLoop:UBTDecorator_Blackboard
	/// Size: 0xC0
	/// Properties: 0
	/// </summary>
	public class UBTDecorator_ConditionalLoop:UBTDecorator_Blackboard
	{
		public override int ObjectSize => 192;
	}


	/// <summary>
	/// UBTDecorator_IsAtLocation:UBTDecorator_BlackboardBase
	/// Size: 0x98
	/// Properties: 2
	/// </summary>
	public class UBTDecorator_IsAtLocation:UBTDecorator_BlackboardBase
	{
		public override int ObjectSize => 152;
		/// <summary>
		/// Name: AcceptableRadius
		/// Type: FloatProperty
		/// Offset: 0x90
		/// Size: 0x04
		/// </summary>
		public float AcceptableRadius
		{
			get
			{
				return ReadSingle(0x90);
			}
			set
			{
				WriteSingle(0x90,value);
			}
		}
		
		/// <summary>
		/// Name: bUseNavAgentGoalLocation
		/// Type: BoolProperty
		/// Offset: 0x94
		/// Size: 0x01
		/// </summary>
		public bool bUseNavAgentGoalLocation
		{
			get
			{
				return ReadBool(0x94);
			}
			set
			{
				WriteBool(0x94,value);
			}
		}
		
	}


	/// <summary>
	/// UBTDecorator_IsBBEntryOfClass:UBTDecorator_BlackboardBase
	/// Size: 0x98
	/// Properties: 1
	/// </summary>
	public class UBTDecorator_IsBBEntryOfClass:UBTDecorator_BlackboardBase
	{
		public override int ObjectSize => 152;
		/// <summary>
		/// Name: TestClass
		/// Type: ClassProperty
		/// Offset: 0x90
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// UBTDecorator_BlueprintBase:UBTDecorator
	/// Size: 0xA0
	/// Properties: 6
	/// </summary>
	public class UBTDecorator_BlueprintBase:UBTDecorator
	{
		public override int ObjectSize => 160;
		/// <summary>
		/// Name: AIOwner
		/// Type: ObjectProperty
		/// Offset: 0x68
		/// Size: 0x08
		/// </summary>
		public AAIController AIOwner => ReadUObject<AAIController>(0x68);
		
		/// <summary>
		/// Name: ActorOwner
		/// Type: ObjectProperty
		/// Offset: 0x70
		/// Size: 0x08
		/// </summary>
		public AActor ActorOwner => ReadUObject<AActor>(0x70);
		
		/// <summary>
		/// Name: ObservedKeyNames
		/// Type: TArray<FName>
		/// Offset: 0x78
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		public TArray<FName> ObservedKeyNames => new TArray<FName>(BaseAddress+0x78);
		
		/// <summary>
		/// Name: bShowPropertyDetails
		/// Type: BoolProperty
		/// Offset: 0x98
		/// Size: 0x01
		/// </summary>
		public bool bShowPropertyDetails => (ReadByte(0x0098) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bCheckConditionOnlyBlackBoardChanges
		/// Type: BoolProperty
		/// Offset: 0x98
		/// Size: 0x01
		/// </summary>
		public bool bCheckConditionOnlyBlackBoardChanges => (ReadByte(0x0098) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bIsObservingBB
		/// Type: BoolProperty
		/// Offset: 0x98
		/// Size: 0x01
		/// </summary>
		public bool bIsObservingBB => (ReadByte(0x0098) & 0x04) == 0x04;
		
	}


	/// <summary>
	/// UBTDecorator_CheckGameplayTagsOnActor:UBTDecorator
	/// Size: 0xC8
	/// Properties: 4
	/// </summary>
	public class UBTDecorator_CheckGameplayTagsOnActor:UBTDecorator
	{
		public override int ObjectSize => 200;
		/// <summary>
		/// Name: ActorToCheck
		/// Type: StructProperty
		/// Offset: 0x68
		/// Size: 0x28
		/// </summary>
		public FBlackboardKeySelector ActorToCheck => ReadStruct<FBlackboardKeySelector>(0x68);
		
		/// <summary>
		/// Name: TagsToMatch
		/// Type: ByteProperty
		/// Offset: 0x90
		/// Size: 0x01
		/// </summary>
		public byte TagsToMatch
		{
			get
			{
				return ReadByte(0x90);
			}
			set
			{
				WriteByte(0x90,value);
			}
		}
		
		/// <summary>
		/// Name: GameplayTags
		/// Type: StructProperty
		/// Offset: 0x98
		/// Size: 0x20
		/// </summary>
		public FGameplayTagContainer GameplayTags => ReadStruct<FGameplayTagContainer>(0x98);
		
		/// <summary>
		/// Name: CachedDescription
		/// Type: StrProperty
		/// Offset: 0xB8
		/// Size: 0x10
		/// </summary>
		public FString CachedDescription => new FString(BaseAddress+0xB8);
		
	}


	/// <summary>
	/// UBTDecorator_CompareBBEntries:UBTDecorator
	/// Size: 0xC0
	/// Properties: 3
	/// </summary>
	public class UBTDecorator_CompareBBEntries:UBTDecorator
	{
		public override int ObjectSize => 192;
		/// <summary>
		/// Name: Operator
		/// Type: ByteProperty
		/// Offset: 0x68
		/// Size: 0x01
		/// </summary>
		public byte Operator
		{
			get
			{
				return ReadByte(0x68);
			}
			set
			{
				WriteByte(0x68,value);
			}
		}
		
		/// <summary>
		/// Name: BlackboardKeyA
		/// Type: StructProperty
		/// Offset: 0x70
		/// Size: 0x28
		/// </summary>
		public FBlackboardKeySelector BlackboardKeyA => ReadStruct<FBlackboardKeySelector>(0x70);
		
		/// <summary>
		/// Name: BlackboardKeyB
		/// Type: StructProperty
		/// Offset: 0x98
		/// Size: 0x28
		/// </summary>
		public FBlackboardKeySelector BlackboardKeyB => ReadStruct<FBlackboardKeySelector>(0x98);
		
	}


	/// <summary>
	/// UBTDecorator_ConeCheck:UBTDecorator
	/// Size: 0xF0
	/// Properties: 4
	/// </summary>
	public class UBTDecorator_ConeCheck:UBTDecorator
	{
		public override int ObjectSize => 240;
		/// <summary>
		/// Name: ConeHalfAngle
		/// Type: FloatProperty
		/// Offset: 0x68
		/// Size: 0x04
		/// </summary>
		public float ConeHalfAngle
		{
			get
			{
				return ReadSingle(0x68);
			}
			set
			{
				WriteSingle(0x68,value);
			}
		}
		
		/// <summary>
		/// Name: ConeOrigin
		/// Type: StructProperty
		/// Offset: 0x70
		/// Size: 0x28
		/// </summary>
		public FBlackboardKeySelector ConeOrigin => ReadStruct<FBlackboardKeySelector>(0x70);
		
		/// <summary>
		/// Name: ConeDirection
		/// Type: StructProperty
		/// Offset: 0x98
		/// Size: 0x28
		/// </summary>
		public FBlackboardKeySelector ConeDirection => ReadStruct<FBlackboardKeySelector>(0x98);
		
		/// <summary>
		/// Name: Observed
		/// Type: StructProperty
		/// Offset: 0xC0
		/// Size: 0x28
		/// </summary>
		public FBlackboardKeySelector Observed => ReadStruct<FBlackboardKeySelector>(0xC0);
		
	}


	/// <summary>
	/// UBTDecorator_Cooldown:UBTDecorator
	/// Size: 0x70
	/// Properties: 1
	/// </summary>
	public class UBTDecorator_Cooldown:UBTDecorator
	{
		public override int ObjectSize => 112;
		/// <summary>
		/// Name: CoolDownTime
		/// Type: FloatProperty
		/// Offset: 0x68
		/// Size: 0x04
		/// </summary>
		public float CoolDownTime
		{
			get
			{
				return ReadSingle(0x68);
			}
			set
			{
				WriteSingle(0x68,value);
			}
		}
		
	}


	/// <summary>
	/// UBTDecorator_DoesPathExist:UBTDecorator
	/// Size: 0xC8
	/// Properties: 5
	/// </summary>
	public class UBTDecorator_DoesPathExist:UBTDecorator
	{
		public override int ObjectSize => 200;
		/// <summary>
		/// Name: BlackboardKeyA
		/// Type: StructProperty
		/// Offset: 0x68
		/// Size: 0x28
		/// </summary>
		public FBlackboardKeySelector BlackboardKeyA => ReadStruct<FBlackboardKeySelector>(0x68);
		
		/// <summary>
		/// Name: BlackboardKeyB
		/// Type: StructProperty
		/// Offset: 0x90
		/// Size: 0x28
		/// </summary>
		public FBlackboardKeySelector BlackboardKeyB => ReadStruct<FBlackboardKeySelector>(0x90);
		
		/// <summary>
		/// Name: bUseSelf
		/// Type: BoolProperty
		/// Offset: 0xB8
		/// Size: 0x01
		/// </summary>
		public bool bUseSelf => (ReadByte(0x00B8) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: PathQueryType
		/// Type: ByteProperty
		/// Offset: 0xBC
		/// Size: 0x01
		/// </summary>
		public byte PathQueryType
		{
			get
			{
				return ReadByte(0xBC);
			}
			set
			{
				WriteByte(0xBC,value);
			}
		}
		
		/// <summary>
		/// Name: FilterClass
		/// Type: ClassProperty
		/// Offset: 0xC0
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// UBTDecorator_ForceSuccess:UBTDecorator
	/// Size: 0x68
	/// Properties: 0
	/// </summary>
	public class UBTDecorator_ForceSuccess:UBTDecorator
	{
		public override int ObjectSize => 104;
	}


	/// <summary>
	/// UBTDecorator_KeepInCone:UBTDecorator
	/// Size: 0xC8
	/// Properties: 5
	/// </summary>
	public class UBTDecorator_KeepInCone:UBTDecorator
	{
		public override int ObjectSize => 200;
		/// <summary>
		/// Name: ConeHalfAngle
		/// Type: FloatProperty
		/// Offset: 0x68
		/// Size: 0x04
		/// </summary>
		public float ConeHalfAngle
		{
			get
			{
				return ReadSingle(0x68);
			}
			set
			{
				WriteSingle(0x68,value);
			}
		}
		
		/// <summary>
		/// Name: ConeOrigin
		/// Type: StructProperty
		/// Offset: 0x70
		/// Size: 0x28
		/// </summary>
		public FBlackboardKeySelector ConeOrigin => ReadStruct<FBlackboardKeySelector>(0x70);
		
		/// <summary>
		/// Name: Observed
		/// Type: StructProperty
		/// Offset: 0x98
		/// Size: 0x28
		/// </summary>
		public FBlackboardKeySelector Observed => ReadStruct<FBlackboardKeySelector>(0x98);
		
		/// <summary>
		/// Name: bUseSelfAsOrigin
		/// Type: BoolProperty
		/// Offset: 0xC0
		/// Size: 0x01
		/// </summary>
		public bool bUseSelfAsOrigin => (ReadByte(0x00C0) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bUseSelfAsObserved
		/// Type: BoolProperty
		/// Offset: 0xC0
		/// Size: 0x01
		/// </summary>
		public bool bUseSelfAsObserved => (ReadByte(0x00C0) & 0x02) == 0x02;
		
	}


	/// <summary>
	/// UBTDecorator_Loop:UBTDecorator
	/// Size: 0x78
	/// Properties: 3
	/// </summary>
	public class UBTDecorator_Loop:UBTDecorator
	{
		public override int ObjectSize => 120;
		/// <summary>
		/// Name: NumLoops
		/// Type: IntProperty
		/// Offset: 0x68
		/// Size: 0x04
		/// </summary>
		public int NumLoops
		{
			get
			{
				return ReadInt32(0x68);
			}
			set
			{
				WriteInt32(0x68,value);
			}
		}
		
		/// <summary>
		/// Name: bInfiniteLoop
		/// Type: BoolProperty
		/// Offset: 0x6C
		/// Size: 0x01
		/// </summary>
		public bool bInfiniteLoop
		{
			get
			{
				return ReadBool(0x6C);
			}
			set
			{
				WriteBool(0x6C,value);
			}
		}
		
		/// <summary>
		/// Name: InfiniteLoopTimeoutTime
		/// Type: FloatProperty
		/// Offset: 0x70
		/// Size: 0x04
		/// </summary>
		public float InfiniteLoopTimeoutTime
		{
			get
			{
				return ReadSingle(0x70);
			}
			set
			{
				WriteSingle(0x70,value);
			}
		}
		
	}


	/// <summary>
	/// UBTDecorator_ReachedMoveGoal:UBTDecorator
	/// Size: 0x68
	/// Properties: 0
	/// </summary>
	public class UBTDecorator_ReachedMoveGoal:UBTDecorator
	{
		public override int ObjectSize => 104;
	}


	/// <summary>
	/// UBTDecorator_SetTagCooldown:UBTDecorator
	/// Size: 0x78
	/// Properties: 3
	/// </summary>
	public class UBTDecorator_SetTagCooldown:UBTDecorator
	{
		public override int ObjectSize => 120;
		/// <summary>
		/// Name: CooldownTag
		/// Type: StructProperty
		/// Offset: 0x68
		/// Size: 0x08
		/// </summary>
		public FGameplayTag CooldownTag => ReadStruct<FGameplayTag>(0x68);
		
		/// <summary>
		/// Name: CooldownDuration
		/// Type: FloatProperty
		/// Offset: 0x70
		/// Size: 0x04
		/// </summary>
		public float CooldownDuration
		{
			get
			{
				return ReadSingle(0x70);
			}
			set
			{
				WriteSingle(0x70,value);
			}
		}
		
		/// <summary>
		/// Name: bAddToExistingDuration
		/// Type: BoolProperty
		/// Offset: 0x74
		/// Size: 0x01
		/// </summary>
		public bool bAddToExistingDuration
		{
			get
			{
				return ReadBool(0x74);
			}
			set
			{
				WriteBool(0x74,value);
			}
		}
		
	}


	/// <summary>
	/// UBTDecorator_TagCooldown:UBTDecorator
	/// Size: 0x78
	/// Properties: 4
	/// </summary>
	public class UBTDecorator_TagCooldown:UBTDecorator
	{
		public override int ObjectSize => 120;
		/// <summary>
		/// Name: CooldownTag
		/// Type: StructProperty
		/// Offset: 0x68
		/// Size: 0x08
		/// </summary>
		public FGameplayTag CooldownTag => ReadStruct<FGameplayTag>(0x68);
		
		/// <summary>
		/// Name: CooldownDuration
		/// Type: FloatProperty
		/// Offset: 0x70
		/// Size: 0x04
		/// </summary>
		public float CooldownDuration
		{
			get
			{
				return ReadSingle(0x70);
			}
			set
			{
				WriteSingle(0x70,value);
			}
		}
		
		/// <summary>
		/// Name: bAddToExistingDuration
		/// Type: BoolProperty
		/// Offset: 0x74
		/// Size: 0x01
		/// </summary>
		public bool bAddToExistingDuration
		{
			get
			{
				return ReadBool(0x74);
			}
			set
			{
				WriteBool(0x74,value);
			}
		}
		
		/// <summary>
		/// Name: bActivatesCooldown
		/// Type: BoolProperty
		/// Offset: 0x75
		/// Size: 0x01
		/// </summary>
		public bool bActivatesCooldown
		{
			get
			{
				return ReadBool(0x75);
			}
			set
			{
				WriteBool(0x75,value);
			}
		}
		
	}


	/// <summary>
	/// UBTDecorator_TimeLimit:UBTDecorator
	/// Size: 0x70
	/// Properties: 1
	/// </summary>
	public class UBTDecorator_TimeLimit:UBTDecorator
	{
		public override int ObjectSize => 112;
		/// <summary>
		/// Name: TimeLimit
		/// Type: FloatProperty
		/// Offset: 0x68
		/// Size: 0x04
		/// </summary>
		public float TimeLimit
		{
			get
			{
				return ReadSingle(0x68);
			}
			set
			{
				WriteSingle(0x68,value);
			}
		}
		
	}


	/// <summary>
	/// UBTService:UBTAuxiliaryNode
	/// Size: 0x70
	/// Properties: 4
	/// </summary>
	public class UBTService:UBTAuxiliaryNode
	{
		public override int ObjectSize => 112;
		/// <summary>
		/// Name: Interval
		/// Type: FloatProperty
		/// Offset: 0x60
		/// Size: 0x04
		/// </summary>
		public float Interval
		{
			get
			{
				return ReadSingle(0x60);
			}
			set
			{
				WriteSingle(0x60,value);
			}
		}
		
		/// <summary>
		/// Name: RandomDeviation
		/// Type: FloatProperty
		/// Offset: 0x64
		/// Size: 0x04
		/// </summary>
		public float RandomDeviation
		{
			get
			{
				return ReadSingle(0x64);
			}
			set
			{
				WriteSingle(0x64,value);
			}
		}
		
		/// <summary>
		/// Name: bCallTickOnSearchStart
		/// Type: BoolProperty
		/// Offset: 0x68
		/// Size: 0x01
		/// </summary>
		public bool bCallTickOnSearchStart => (ReadByte(0x0068) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bRestartTimerOnEachActivation
		/// Type: BoolProperty
		/// Offset: 0x68
		/// Size: 0x01
		/// </summary>
		public bool bRestartTimerOnEachActivation => (ReadByte(0x0068) & 0x02) == 0x02;
		
	}


	/// <summary>
	/// UBTService_BlackboardBase:UBTService
	/// Size: 0x98
	/// Properties: 1
	/// </summary>
	public class UBTService_BlackboardBase:UBTService
	{
		public override int ObjectSize => 152;
		/// <summary>
		/// Name: BlackboardKey
		/// Type: StructProperty
		/// Offset: 0x70
		/// Size: 0x28
		/// </summary>
		public FBlackboardKeySelector BlackboardKey => ReadStruct<FBlackboardKeySelector>(0x70);
		
	}


	/// <summary>
	/// UBTService_DefaultFocus:UBTService_BlackboardBase
	/// Size: 0xA0
	/// Properties: 1
	/// </summary>
	public class UBTService_DefaultFocus:UBTService_BlackboardBase
	{
		public override int ObjectSize => 160;
		/// <summary>
		/// Name: FocusPriority
		/// Type: ByteProperty
		/// Offset: 0x98
		/// Size: 0x01
		/// </summary>
		public byte FocusPriority
		{
			get
			{
				return ReadByte(0x98);
			}
			set
			{
				WriteByte(0x98,value);
			}
		}
		
	}


	/// <summary>
	/// UEnvQueryItemType:UObject
	/// Size: 0x30
	/// Properties: 0
	/// </summary>
	public class UEnvQueryItemType:UObject
	{
		public override int ObjectSize => 48;
	}


	/// <summary>
	/// UEnvQueryContext:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UEnvQueryContext:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UEnvQueryTypes:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UEnvQueryTypes:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UBTService_RunEQS:UBTService_BlackboardBase
	/// Size: 0x120
	/// Properties: 1
	/// </summary>
	public class UBTService_RunEQS:UBTService_BlackboardBase
	{
		public override int ObjectSize => 288;
		/// <summary>
		/// Name: EQSRequest
		/// Type: StructProperty
		/// Offset: 0x98
		/// Size: 0x48
		/// </summary>
		public FEQSParametrizedQueryExecutionRequest EQSRequest => ReadStruct<FEQSParametrizedQueryExecutionRequest>(0x98);
		
	}


	/// <summary>
	/// UBTService_BlueprintBase:UBTService
	/// Size: 0x98
	/// Properties: 4
	/// </summary>
	public class UBTService_BlueprintBase:UBTService
	{
		public override int ObjectSize => 152;
		/// <summary>
		/// Name: AIOwner
		/// Type: ObjectProperty
		/// Offset: 0x70
		/// Size: 0x08
		/// </summary>
		public AAIController AIOwner => ReadUObject<AAIController>(0x70);
		
		/// <summary>
		/// Name: ActorOwner
		/// Type: ObjectProperty
		/// Offset: 0x78
		/// Size: 0x08
		/// </summary>
		public AActor ActorOwner => ReadUObject<AActor>(0x78);
		
		/// <summary>
		/// Name: bShowPropertyDetails
		/// Type: BoolProperty
		/// Offset: 0x90
		/// Size: 0x01
		/// </summary>
		public bool bShowPropertyDetails => (ReadByte(0x0090) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bShowEventDetails
		/// Type: BoolProperty
		/// Offset: 0x90
		/// Size: 0x01
		/// </summary>
		public bool bShowEventDetails => (ReadByte(0x0090) & 0x02) == 0x02;
		
	}


	/// <summary>
	/// UBTComposite_Selector:UBTCompositeNode
	/// Size: 0xD0
	/// Properties: 0
	/// </summary>
	public class UBTComposite_Selector:UBTCompositeNode
	{
		public override int ObjectSize => 208;
	}


	/// <summary>
	/// UBTComposite_Sequence:UBTCompositeNode
	/// Size: 0xD0
	/// Properties: 0
	/// </summary>
	public class UBTComposite_Sequence:UBTCompositeNode
	{
		public override int ObjectSize => 208;
	}


	/// <summary>
	/// UBTComposite_SimpleParallel:UBTCompositeNode
	/// Size: 0xD0
	/// Properties: 1
	/// </summary>
	public class UBTComposite_SimpleParallel:UBTCompositeNode
	{
		public override int ObjectSize => 208;
		/// <summary>
		/// Name: FinishMode
		/// Type: ByteProperty
		/// Offset: 0xC8
		/// Size: 0x01
		/// </summary>
		public byte FinishMode
		{
			get
			{
				return ReadByte(0xC8);
			}
			set
			{
				WriteByte(0xC8,value);
			}
		}
		
	}


	/// <summary>
	/// UBTTask_BlackboardBase:UBTTaskNode
	/// Size: 0x98
	/// Properties: 1
	/// </summary>
	public class UBTTask_BlackboardBase:UBTTaskNode
	{
		public override int ObjectSize => 152;
		/// <summary>
		/// Name: BlackboardKey
		/// Type: StructProperty
		/// Offset: 0x70
		/// Size: 0x28
		/// </summary>
		public FBlackboardKeySelector BlackboardKey => ReadStruct<FBlackboardKeySelector>(0x70);
		
	}


	/// <summary>
	/// UBTTask_MoveTo:UBTTask_BlackboardBase
	/// Size: 0xB0
	/// Properties: 9
	/// </summary>
	public class UBTTask_MoveTo:UBTTask_BlackboardBase
	{
		public override int ObjectSize => 176;
		/// <summary>
		/// Name: AcceptableRadius
		/// Type: FloatProperty
		/// Offset: 0x98
		/// Size: 0x04
		/// </summary>
		public float AcceptableRadius
		{
			get
			{
				return ReadSingle(0x98);
			}
			set
			{
				WriteSingle(0x98,value);
			}
		}
		
		/// <summary>
		/// Name: FilterClass
		/// Type: ClassProperty
		/// Offset: 0xA0
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: ObservedBlackboardValueTolerance
		/// Type: FloatProperty
		/// Offset: 0xA8
		/// Size: 0x04
		/// </summary>
		public float ObservedBlackboardValueTolerance
		{
			get
			{
				return ReadSingle(0xA8);
			}
			set
			{
				WriteSingle(0xA8,value);
			}
		}
		
		/// <summary>
		/// Name: bObserveBlackboardValue
		/// Type: BoolProperty
		/// Offset: 0xAC
		/// Size: 0x01
		/// </summary>
		public bool bObserveBlackboardValue => (ReadByte(0x00AC) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bAllowStrafe
		/// Type: BoolProperty
		/// Offset: 0xAC
		/// Size: 0x01
		/// </summary>
		public bool bAllowStrafe => (ReadByte(0x00AC) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bAllowPartialPath
		/// Type: BoolProperty
		/// Offset: 0xAC
		/// Size: 0x01
		/// </summary>
		public bool bAllowPartialPath => (ReadByte(0x00AC) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bTrackMovingGoal
		/// Type: BoolProperty
		/// Offset: 0xAC
		/// Size: 0x01
		/// </summary>
		public bool bTrackMovingGoal => (ReadByte(0x00AC) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bProjectGoalLocation
		/// Type: BoolProperty
		/// Offset: 0xAC
		/// Size: 0x01
		/// </summary>
		public bool bProjectGoalLocation => (ReadByte(0x00AC) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bStopOnOverlap
		/// Type: BoolProperty
		/// Offset: 0xAC
		/// Size: 0x01
		/// </summary>
		public bool bStopOnOverlap => (ReadByte(0x00AC) & 0x20) == 0x20;
		
	}


	/// <summary>
	/// UBTTask_MoveDirectlyToward:UBTTask_MoveTo
	/// Size: 0xB8
	/// Properties: 3
	/// </summary>
	public class UBTTask_MoveDirectlyToward:UBTTask_MoveTo
	{
		public override int ObjectSize => 184;
		/// <summary>
		/// Name: bDisablePathUpdateOnGoalLocationChange
		/// Type: BoolProperty
		/// Offset: 0xB0
		/// Size: 0x01
		/// </summary>
		public bool bDisablePathUpdateOnGoalLocationChange => (ReadByte(0x00B0) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bProjectVectorGoalToNavigation
		/// Type: BoolProperty
		/// Offset: 0xB0
		/// Size: 0x01
		/// </summary>
		public bool bProjectVectorGoalToNavigation => (ReadByte(0x00B0) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bUpdatedDeprecatedProperties
		/// Type: BoolProperty
		/// Offset: 0xB0
		/// Size: 0x01
		/// </summary>
		public bool bUpdatedDeprecatedProperties => (ReadByte(0x00B0) & 0x04) == 0x04;
		
	}


	/// <summary>
	/// UBTTask_RotateToFaceBBEntry:UBTTask_BlackboardBase
	/// Size: 0xA0
	/// Properties: 1
	/// </summary>
	public class UBTTask_RotateToFaceBBEntry:UBTTask_BlackboardBase
	{
		public override int ObjectSize => 160;
		/// <summary>
		/// Name: Precision
		/// Type: FloatProperty
		/// Offset: 0x98
		/// Size: 0x04
		/// </summary>
		public float Precision
		{
			get
			{
				return ReadSingle(0x98);
			}
			set
			{
				WriteSingle(0x98,value);
			}
		}
		
	}


	/// <summary>
	/// UBTTask_RunEQSQuery:UBTTask_BlackboardBase
	/// Size: 0x180
	/// Properties: 7
	/// </summary>
	public class UBTTask_RunEQSQuery:UBTTask_BlackboardBase
	{
		public override int ObjectSize => 384;
		/// <summary>
		/// Name: QueryTemplate
		/// Type: ObjectProperty
		/// Offset: 0x98
		/// Size: 0x08
		/// </summary>
		public UEnvQuery QueryTemplate => ReadUObject<UEnvQuery>(0x98);
		
		/// <summary>
		/// Name: QueryParams
		/// Type: TArray<FEnvNamedValue>
		/// Offset: 0xA0
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FEnvNamedValue> QueryParams => new TArray<FEnvNamedValue>(BaseAddress+0xA0);
		
		/// <summary>
		/// Name: QueryConfig
		/// Type: TArray<FAIDynamicParam>
		/// Offset: 0xB0
		/// Size: 0x10
		/// SubElement Size: 0x38
		/// </summary>
		public TArray<FAIDynamicParam> QueryConfig => new TArray<FAIDynamicParam>(BaseAddress+0xB0);
		
		/// <summary>
		/// Name: RunMode
		/// Type: ByteProperty
		/// Offset: 0xC0
		/// Size: 0x01
		/// </summary>
		public byte RunMode
		{
			get
			{
				return ReadByte(0xC0);
			}
			set
			{
				WriteByte(0xC0,value);
			}
		}
		
		/// <summary>
		/// Name: EQSQueryBlackboardKey
		/// Type: StructProperty
		/// Offset: 0xC8
		/// Size: 0x28
		/// </summary>
		public FBlackboardKeySelector EQSQueryBlackboardKey => ReadStruct<FBlackboardKeySelector>(0xC8);
		
		/// <summary>
		/// Name: bUseBBKey
		/// Type: BoolProperty
		/// Offset: 0xF0
		/// Size: 0x01
		/// </summary>
		public bool bUseBBKey
		{
			get
			{
				return ReadBool(0xF0);
			}
			set
			{
				WriteBool(0xF0,value);
			}
		}
		
		/// <summary>
		/// Name: EQSRequest
		/// Type: StructProperty
		/// Offset: 0xF8
		/// Size: 0x48
		/// </summary>
		public FEQSParametrizedQueryExecutionRequest EQSRequest => ReadStruct<FEQSParametrizedQueryExecutionRequest>(0xF8);
		
	}


	/// <summary>
	/// UBTTask_BlueprintBase:UBTTaskNode
	/// Size: 0xA0
	/// Properties: 3
	/// </summary>
	public class UBTTask_BlueprintBase:UBTTaskNode
	{
		public override int ObjectSize => 160;
		/// <summary>
		/// Name: AIOwner
		/// Type: ObjectProperty
		/// Offset: 0x70
		/// Size: 0x08
		/// </summary>
		public AAIController AIOwner => ReadUObject<AAIController>(0x70);
		
		/// <summary>
		/// Name: ActorOwner
		/// Type: ObjectProperty
		/// Offset: 0x78
		/// Size: 0x08
		/// </summary>
		public AActor ActorOwner => ReadUObject<AActor>(0x78);
		
		/// <summary>
		/// Name: bShowPropertyDetails
		/// Type: BoolProperty
		/// Offset: 0x98
		/// Size: 0x01
		/// </summary>
		public bool bShowPropertyDetails => (ReadByte(0x0098) & 0x01) == 0x01;
		
	}


	/// <summary>
	/// UBTTask_MakeNoise:UBTTaskNode
	/// Size: 0x78
	/// Properties: 1
	/// </summary>
	public class UBTTask_MakeNoise:UBTTaskNode
	{
		public override int ObjectSize => 120;
		/// <summary>
		/// Name: Loudnes
		/// Type: FloatProperty
		/// Offset: 0x70
		/// Size: 0x04
		/// </summary>
		public float Loudnes
		{
			get
			{
				return ReadSingle(0x70);
			}
			set
			{
				WriteSingle(0x70,value);
			}
		}
		
	}


	/// <summary>
	/// UPawnAction:UObject
	/// Size: 0xD0
	/// Properties: 9
	/// </summary>
	public class UPawnAction:UObject
	{
		public override int ObjectSize => 208;
		/// <summary>
		/// Name: ChildAction
		/// Type: ObjectProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		public UPawnAction ChildAction => ReadUObject<UPawnAction>(0x28);
		
		/// <summary>
		/// Name: ParentAction
		/// Type: ObjectProperty
		/// Offset: 0x30
		/// Size: 0x08
		/// </summary>
		public UPawnAction ParentAction => ReadUObject<UPawnAction>(0x30);
		
		/// <summary>
		/// Name: OwnerComponent
		/// Type: ObjectProperty
		/// Offset: 0x38
		/// Size: 0x08
		/// </summary>
		public UPawnActionsComponent OwnerComponent => ReadUObject<UPawnActionsComponent>(0x38);
		
		/// <summary>
		/// Name: Instigator
		/// Type: ObjectProperty
		/// Offset: 0x40
		/// Size: 0x08
		/// </summary>
		public UObject Instigator => ReadUObject<UObject>(0x40);
		
		/// <summary>
		/// Name: BrainComp
		/// Type: ObjectProperty
		/// Offset: 0x48
		/// Size: 0x08
		/// </summary>
		public UBrainComponent BrainComp => ReadUObject<UBrainComponent>(0x48);
		
		/// <summary>
		/// Name: bAllowNewSameClassInstance
		/// Type: BoolProperty
		/// Offset: 0xB8
		/// Size: 0x01
		/// </summary>
		public bool bAllowNewSameClassInstance => (ReadByte(0x00B8) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bReplaceActiveSameClassInstance
		/// Type: BoolProperty
		/// Offset: 0xB8
		/// Size: 0x01
		/// </summary>
		public bool bReplaceActiveSameClassInstance => (ReadByte(0x00B8) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bShouldPauseMovement
		/// Type: BoolProperty
		/// Offset: 0xB8
		/// Size: 0x01
		/// </summary>
		public bool bShouldPauseMovement => (ReadByte(0x00B8) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bAlwaysNotifyOnFinished
		/// Type: BoolProperty
		/// Offset: 0xB8
		/// Size: 0x01
		/// </summary>
		public bool bAlwaysNotifyOnFinished => (ReadByte(0x00B8) & 0x08) == 0x08;
		
	}


	/// <summary>
	/// UBTTask_PawnActionBase:UBTTaskNode
	/// Size: 0x70
	/// Properties: 0
	/// </summary>
	public class UBTTask_PawnActionBase:UBTTaskNode
	{
		public override int ObjectSize => 112;
	}


	/// <summary>
	/// UBTTask_PushPawnAction:UBTTask_PawnActionBase
	/// Size: 0x78
	/// Properties: 1
	/// </summary>
	public class UBTTask_PushPawnAction:UBTTask_PawnActionBase
	{
		public override int ObjectSize => 120;
		/// <summary>
		/// Name: Action
		/// Type: ObjectProperty
		/// Offset: 0x70
		/// Size: 0x08
		/// </summary>
		public UPawnAction Action => ReadUObject<UPawnAction>(0x70);
		
	}


	/// <summary>
	/// UBTTask_PlayAnimation:UBTTaskNode
	/// Size: 0xF0
	/// Properties: 5
	/// </summary>
	public class UBTTask_PlayAnimation:UBTTaskNode
	{
		public override int ObjectSize => 240;
		/// <summary>
		/// Name: AnimationToPlay
		/// Type: ObjectProperty
		/// Offset: 0x70
		/// Size: 0x08
		/// </summary>
		public UAnimationAsset AnimationToPlay => ReadUObject<UAnimationAsset>(0x70);
		
		/// <summary>
		/// Name: bLooping
		/// Type: BoolProperty
		/// Offset: 0x78
		/// Size: 0x01
		/// </summary>
		public bool bLooping => (ReadByte(0x0078) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bNonBlocking
		/// Type: BoolProperty
		/// Offset: 0x78
		/// Size: 0x01
		/// </summary>
		public bool bNonBlocking => (ReadByte(0x0078) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: MyOwnerComp
		/// Type: ObjectProperty
		/// Offset: 0x80
		/// Size: 0x08
		/// </summary>
		public UBehaviorTreeComponent MyOwnerComp => ReadUObject<UBehaviorTreeComponent>(0x80);
		
		/// <summary>
		/// Name: CachedSkelMesh
		/// Type: ObjectProperty
		/// Offset: 0x88
		/// Size: 0x08
		/// </summary>
		public USkeletalMeshComponent CachedSkelMesh => ReadUObject<USkeletalMeshComponent>(0x88);
		
	}


	/// <summary>
	/// UBTTask_PlaySound:UBTTaskNode
	/// Size: 0x78
	/// Properties: 1
	/// </summary>
	public class UBTTask_PlaySound:UBTTaskNode
	{
		public override int ObjectSize => 120;
		/// <summary>
		/// Name: SoundToPlay
		/// Type: ObjectProperty
		/// Offset: 0x70
		/// Size: 0x08
		/// </summary>
		public USoundCue SoundToPlay => ReadUObject<USoundCue>(0x70);
		
	}


	/// <summary>
	/// UBTTask_RunBehavior:UBTTaskNode
	/// Size: 0x78
	/// Properties: 1
	/// </summary>
	public class UBTTask_RunBehavior:UBTTaskNode
	{
		public override int ObjectSize => 120;
		/// <summary>
		/// Name: BehaviorAsset
		/// Type: ObjectProperty
		/// Offset: 0x70
		/// Size: 0x08
		/// </summary>
		public UBehaviorTree BehaviorAsset => ReadUObject<UBehaviorTree>(0x70);
		
	}


	/// <summary>
	/// UBTTask_RunBehaviorDynamic:UBTTaskNode
	/// Size: 0x88
	/// Properties: 3
	/// </summary>
	public class UBTTask_RunBehaviorDynamic:UBTTaskNode
	{
		public override int ObjectSize => 136;
		/// <summary>
		/// Name: InjectionTag
		/// Type: StructProperty
		/// Offset: 0x70
		/// Size: 0x08
		/// </summary>
		public FGameplayTag InjectionTag => ReadStruct<FGameplayTag>(0x70);
		
		/// <summary>
		/// Name: DefaultBehaviorAsset
		/// Type: ObjectProperty
		/// Offset: 0x78
		/// Size: 0x08
		/// </summary>
		public UBehaviorTree DefaultBehaviorAsset => ReadUObject<UBehaviorTree>(0x78);
		
		/// <summary>
		/// Name: BehaviorAsset
		/// Type: ObjectProperty
		/// Offset: 0x80
		/// Size: 0x08
		/// </summary>
		public UBehaviorTree BehaviorAsset => ReadUObject<UBehaviorTree>(0x80);
		
	}


	/// <summary>
	/// UBTTask_SetTagCooldown:UBTTaskNode
	/// Size: 0x80
	/// Properties: 3
	/// </summary>
	public class UBTTask_SetTagCooldown:UBTTaskNode
	{
		public override int ObjectSize => 128;
		/// <summary>
		/// Name: CooldownTag
		/// Type: StructProperty
		/// Offset: 0x70
		/// Size: 0x08
		/// </summary>
		public FGameplayTag CooldownTag => ReadStruct<FGameplayTag>(0x70);
		
		/// <summary>
		/// Name: bAddToExistingDuration
		/// Type: BoolProperty
		/// Offset: 0x78
		/// Size: 0x01
		/// </summary>
		public bool bAddToExistingDuration
		{
			get
			{
				return ReadBool(0x78);
			}
			set
			{
				WriteBool(0x78,value);
			}
		}
		
		/// <summary>
		/// Name: CooldownDuration
		/// Type: FloatProperty
		/// Offset: 0x7C
		/// Size: 0x04
		/// </summary>
		public float CooldownDuration
		{
			get
			{
				return ReadSingle(0x7C);
			}
			set
			{
				WriteSingle(0x7C,value);
			}
		}
		
	}


	/// <summary>
	/// UBTTask_Wait:UBTTaskNode
	/// Size: 0x78
	/// Properties: 2
	/// </summary>
	public class UBTTask_Wait:UBTTaskNode
	{
		public override int ObjectSize => 120;
		/// <summary>
		/// Name: WaitTime
		/// Type: FloatProperty
		/// Offset: 0x70
		/// Size: 0x04
		/// </summary>
		public float WaitTime
		{
			get
			{
				return ReadSingle(0x70);
			}
			set
			{
				WriteSingle(0x70,value);
			}
		}
		
		/// <summary>
		/// Name: RandomDeviation
		/// Type: FloatProperty
		/// Offset: 0x74
		/// Size: 0x04
		/// </summary>
		public float RandomDeviation
		{
			get
			{
				return ReadSingle(0x74);
			}
			set
			{
				WriteSingle(0x74,value);
			}
		}
		
	}


	/// <summary>
	/// UBTTask_WaitBlackboardTime:UBTTask_Wait
	/// Size: 0xA0
	/// Properties: 1
	/// </summary>
	public class UBTTask_WaitBlackboardTime:UBTTask_Wait
	{
		public override int ObjectSize => 160;
		/// <summary>
		/// Name: BlackboardKey
		/// Type: StructProperty
		/// Offset: 0x78
		/// Size: 0x28
		/// </summary>
		public FBlackboardKeySelector BlackboardKey => ReadStruct<FBlackboardKeySelector>(0x78);
		
	}


	/// <summary>
	/// UCrowdAgentInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UCrowdAgentInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UCrowdManager:UObject
	/// Size: 0xE8
	/// Properties: 10
	/// </summary>
	public class UCrowdManager:UObject
	{
		public override int ObjectSize => 232;
		/// <summary>
		/// Name: MyNavData
		/// Type: ObjectProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		public ANavigationData MyNavData => ReadUObject<ANavigationData>(0x28);
		
		/// <summary>
		/// Name: AvoidanceConfig
		/// Type: TArray<FCrowdAvoidanceConfig>
		/// Offset: 0x30
		/// Size: 0x10
		/// SubElement Size: 0x1C
		/// </summary>
		public TArray<FCrowdAvoidanceConfig> AvoidanceConfig => new TArray<FCrowdAvoidanceConfig>(BaseAddress+0x30);
		
		/// <summary>
		/// Name: SamplingPatterns
		/// Type: TArray<FCrowdAvoidanceSamplingPattern>
		/// Offset: 0x40
		/// Size: 0x10
		/// SubElement Size: 0x20
		/// </summary>
		public TArray<FCrowdAvoidanceSamplingPattern> SamplingPatterns => new TArray<FCrowdAvoidanceSamplingPattern>(BaseAddress+0x40);
		
		/// <summary>
		/// Name: MaxAgents
		/// Type: IntProperty
		/// Offset: 0x50
		/// Size: 0x04
		/// </summary>
		public int MaxAgents
		{
			get
			{
				return ReadInt32(0x50);
			}
			set
			{
				WriteInt32(0x50,value);
			}
		}
		
		/// <summary>
		/// Name: MaxAgentRadius
		/// Type: FloatProperty
		/// Offset: 0x54
		/// Size: 0x04
		/// </summary>
		public float MaxAgentRadius
		{
			get
			{
				return ReadSingle(0x54);
			}
			set
			{
				WriteSingle(0x54,value);
			}
		}
		
		/// <summary>
		/// Name: MaxAvoidedAgents
		/// Type: IntProperty
		/// Offset: 0x58
		/// Size: 0x04
		/// </summary>
		public int MaxAvoidedAgents
		{
			get
			{
				return ReadInt32(0x58);
			}
			set
			{
				WriteInt32(0x58,value);
			}
		}
		
		/// <summary>
		/// Name: MaxAvoidedWalls
		/// Type: IntProperty
		/// Offset: 0x5C
		/// Size: 0x04
		/// </summary>
		public int MaxAvoidedWalls
		{
			get
			{
				return ReadInt32(0x5C);
			}
			set
			{
				WriteInt32(0x5C,value);
			}
		}
		
		/// <summary>
		/// Name: NavmeshCheckInterval
		/// Type: FloatProperty
		/// Offset: 0x60
		/// Size: 0x04
		/// </summary>
		public float NavmeshCheckInterval
		{
			get
			{
				return ReadSingle(0x60);
			}
			set
			{
				WriteSingle(0x60,value);
			}
		}
		
		/// <summary>
		/// Name: PathOptimizationInterval
		/// Type: FloatProperty
		/// Offset: 0x64
		/// Size: 0x04
		/// </summary>
		public float PathOptimizationInterval
		{
			get
			{
				return ReadSingle(0x64);
			}
			set
			{
				WriteSingle(0x64,value);
			}
		}
		
		/// <summary>
		/// Name: bResolveCollisions
		/// Type: BoolProperty
		/// Offset: 0x68
		/// Size: 0x01
		/// </summary>
		public bool bResolveCollisions => (ReadByte(0x0068) & 0x08) == 0x08;
		
	}


	/// <summary>
	/// UEnvQuery:UDataAsset
	/// Size: 0x40
	/// Properties: 2
	/// </summary>
	public class UEnvQuery:UDataAsset
	{
		public override int ObjectSize => 64;
		/// <summary>
		/// Name: QueryName
		/// Type: NameProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: Options
		/// Type: TArray<UEnvQueryOption>
		/// Offset: 0x30
		/// Size: 0x10
		/// SubElement Size: 0x40
		/// </summary>
		public TArray<UEnvQueryOption> Options => new TArray<UEnvQueryOption>(BaseAddress+0x30);
		
	}


	/// <summary>
	/// UEnvQueryContext_BlueprintBase:UEnvQueryContext
	/// Size: 0x30
	/// Properties: 0
	/// </summary>
	public class UEnvQueryContext_BlueprintBase:UEnvQueryContext
	{
		public override int ObjectSize => 48;
	}


	/// <summary>
	/// UEnvQueryContext_Item:UEnvQueryContext
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UEnvQueryContext_Item:UEnvQueryContext
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UEnvQueryContext_Querier:UEnvQueryContext
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UEnvQueryContext_Querier:UEnvQueryContext
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UVisualLoggerExtension:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UVisualLoggerExtension:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UEnvQueryDebugHelpers:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UEnvQueryDebugHelpers:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UEQSQueryResultSourceInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UEQSQueryResultSourceInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UEnvQueryInstanceBlueprintWrapper:UObject
	/// Size: 0x78
	/// Properties: 3
	/// </summary>
	public class UEnvQueryInstanceBlueprintWrapper:UObject
	{
		public override int ObjectSize => 120;
		/// <summary>
		/// Name: QueryID
		/// Type: IntProperty
		/// Offset: 0x30
		/// Size: 0x04
		/// </summary>
		public int QueryID
		{
			get
			{
				return ReadInt32(0x30);
			}
			set
			{
				WriteInt32(0x30,value);
			}
		}
		
		/// <summary>
		/// Name: ItemType
		/// Type: ClassProperty
		/// Offset: 0x58
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: OptionIndex
		/// Type: IntProperty
		/// Offset: 0x60
		/// Size: 0x04
		/// </summary>
		public int OptionIndex
		{
			get
			{
				return ReadInt32(0x60);
			}
			set
			{
				WriteInt32(0x60,value);
			}
		}
		
	}


	/// <summary>
	/// UEnvQueryItemType_VectorBase:UEnvQueryItemType
	/// Size: 0x30
	/// Properties: 0
	/// </summary>
	public class UEnvQueryItemType_VectorBase:UEnvQueryItemType
	{
		public override int ObjectSize => 48;
	}


	/// <summary>
	/// UEnvQueryItemType_ActorBase:UEnvQueryItemType_VectorBase
	/// Size: 0x30
	/// Properties: 0
	/// </summary>
	public class UEnvQueryItemType_ActorBase:UEnvQueryItemType_VectorBase
	{
		public override int ObjectSize => 48;
	}


	/// <summary>
	/// UEnvQueryItemType_Actor:UEnvQueryItemType_ActorBase
	/// Size: 0x30
	/// Properties: 0
	/// </summary>
	public class UEnvQueryItemType_Actor:UEnvQueryItemType_ActorBase
	{
		public override int ObjectSize => 48;
	}


	/// <summary>
	/// UEnvQueryItemType_Direction:UEnvQueryItemType_VectorBase
	/// Size: 0x30
	/// Properties: 0
	/// </summary>
	public class UEnvQueryItemType_Direction:UEnvQueryItemType_VectorBase
	{
		public override int ObjectSize => 48;
	}


	/// <summary>
	/// UEnvQueryItemType_Point:UEnvQueryItemType_VectorBase
	/// Size: 0x30
	/// Properties: 0
	/// </summary>
	public class UEnvQueryItemType_Point:UEnvQueryItemType_VectorBase
	{
		public override int ObjectSize => 48;
	}


	/// <summary>
	/// UEnvQueryManager:UObject
	/// Size: 0x138
	/// Properties: 7
	/// </summary>
	public class UEnvQueryManager:UObject
	{
		public override int ObjectSize => 312;
		/// <summary>
		/// Name: InstanceCache
		/// Type: TArray<FEnvQueryInstanceCache>
		/// Offset: 0x98
		/// Size: 0x10
		/// SubElement Size: 0x1D0
		/// </summary>
		public TArray<FEnvQueryInstanceCache> InstanceCache => new TArray<FEnvQueryInstanceCache>(BaseAddress+0x98);
		
		/// <summary>
		/// Name: LocalContexts
		/// Type: TArray<UEnvQueryContext>
		/// Offset: 0xA8
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<UEnvQueryContext> LocalContexts => new TArray<UEnvQueryContext>(BaseAddress+0xA8);
		
		/// <summary>
		/// Name: GCShieldedWrappers
		/// Type: TArray<UEnvQueryInstanceBlueprintWrapper>
		/// Offset: 0xB8
		/// Size: 0x10
		/// SubElement Size: 0x78
		/// </summary>
		public TArray<UEnvQueryInstanceBlueprintWrapper> GCShieldedWrappers => new TArray<UEnvQueryInstanceBlueprintWrapper>(BaseAddress+0xB8);
		
		/// <summary>
		/// Name: MaxAllowedTestingTime
		/// Type: DoubleProperty
		/// Offset: 0x120
		/// Size: 0x08
		/// </summary>
		public double MaxAllowedTestingTime
		{
			get
			{
				return ReadDouble(0x120);
			}
			set
			{
				WriteDouble(0x120,value);
			}
		}
		
		/// <summary>
		/// Name: bTestQueriesUsingBreadth
		/// Type: BoolProperty
		/// Offset: 0x128
		/// Size: 0x01
		/// </summary>
		public bool bTestQueriesUsingBreadth
		{
			get
			{
				return ReadBool(0x128);
			}
			set
			{
				WriteBool(0x128,value);
			}
		}
		
		/// <summary>
		/// Name: QueryCountWarningThreshold
		/// Type: IntProperty
		/// Offset: 0x12C
		/// Size: 0x04
		/// </summary>
		public int QueryCountWarningThreshold
		{
			get
			{
				return ReadInt32(0x12C);
			}
			set
			{
				WriteInt32(0x12C,value);
			}
		}
		
		/// <summary>
		/// Name: QueryCountWarningInterval
		/// Type: DoubleProperty
		/// Offset: 0x130
		/// Size: 0x08
		/// </summary>
		public double QueryCountWarningInterval
		{
			get
			{
				return ReadDouble(0x130);
			}
			set
			{
				WriteDouble(0x130,value);
			}
		}
		
	}


	/// <summary>
	/// UEnvQueryNode:UObject
	/// Size: 0x30
	/// Properties: 1
	/// </summary>
	public class UEnvQueryNode:UObject
	{
		public override int ObjectSize => 48;
		/// <summary>
		/// Name: VerNum
		/// Type: IntProperty
		/// Offset: 0x28
		/// Size: 0x04
		/// </summary>
		public int VerNum
		{
			get
			{
				return ReadInt32(0x28);
			}
			set
			{
				WriteInt32(0x28,value);
			}
		}
		
	}


	/// <summary>
	/// UEnvQueryGenerator:UEnvQueryNode
	/// Size: 0x50
	/// Properties: 3
	/// </summary>
	public class UEnvQueryGenerator:UEnvQueryNode
	{
		public override int ObjectSize => 80;
		/// <summary>
		/// Name: OptionName
		/// Type: StrProperty
		/// Offset: 0x30
		/// Size: 0x10
		/// </summary>
		public FString OptionName => new FString(BaseAddress+0x30);
		
		/// <summary>
		/// Name: ItemType
		/// Type: ClassProperty
		/// Offset: 0x40
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: bAutoSortTests
		/// Type: BoolProperty
		/// Offset: 0x48
		/// Size: 0x01
		/// </summary>
		public bool bAutoSortTests => (ReadByte(0x0048) & 0x01) == 0x01;
		
	}


	/// <summary>
	/// UEnvQueryGenerator_ActorsOfClass:UEnvQueryGenerator
	/// Size: 0x90
	/// Properties: 3
	/// </summary>
	public class UEnvQueryGenerator_ActorsOfClass:UEnvQueryGenerator
	{
		public override int ObjectSize => 144;
		/// <summary>
		/// Name: SearchRadius
		/// Type: StructProperty
		/// Offset: 0x50
		/// Size: 0x30
		/// </summary>
		public FAIDataProviderFloatValue SearchRadius => ReadStruct<FAIDataProviderFloatValue>(0x50);
		
		/// <summary>
		/// Name: SearchedActorClass
		/// Type: ClassProperty
		/// Offset: 0x80
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: SearchCenter
		/// Type: ClassProperty
		/// Offset: 0x88
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// UEnvQueryGenerator_BlueprintBase:UEnvQueryGenerator
	/// Size: 0x80
	/// Properties: 3
	/// </summary>
	public class UEnvQueryGenerator_BlueprintBase:UEnvQueryGenerator
	{
		public override int ObjectSize => 128;
		/// <summary>
		/// Name: GeneratorsActionDescription
		/// Type: TextProperty
		/// Offset: 0x50
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: Context
		/// Type: ClassProperty
		/// Offset: 0x68
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: GeneratedItemType
		/// Type: ClassProperty
		/// Offset: 0x70
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// UEnvQueryGenerator_Composite:UEnvQueryGenerator
	/// Size: 0x68
	/// Properties: 2
	/// </summary>
	public class UEnvQueryGenerator_Composite:UEnvQueryGenerator
	{
		public override int ObjectSize => 104;
		/// <summary>
		/// Name: Generators
		/// Type: TArray<UEnvQueryGenerator>
		/// Offset: 0x50
		/// Size: 0x10
		/// SubElement Size: 0x50
		/// </summary>
		public TArray<UEnvQueryGenerator> Generators => new TArray<UEnvQueryGenerator>(BaseAddress+0x50);
		
		/// <summary>
		/// Name: bHasMatchingItemType
		/// Type: BoolProperty
		/// Offset: 0x60
		/// Size: 0x01
		/// </summary>
		public bool bHasMatchingItemType
		{
			get
			{
				return ReadBool(0x60);
			}
			set
			{
				WriteBool(0x60,value);
			}
		}
		
	}


	/// <summary>
	/// UEnvQueryGenerator_CurrentLocation:UEnvQueryGenerator
	/// Size: 0x58
	/// Properties: 1
	/// </summary>
	public class UEnvQueryGenerator_CurrentLocation:UEnvQueryGenerator
	{
		public override int ObjectSize => 88;
		/// <summary>
		/// Name: QueryContext
		/// Type: ClassProperty
		/// Offset: 0x50
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// UEnvQueryGenerator_ProjectedPoints:UEnvQueryGenerator
	/// Size: 0x80
	/// Properties: 1
	/// </summary>
	public class UEnvQueryGenerator_ProjectedPoints:UEnvQueryGenerator
	{
		public override int ObjectSize => 128;
		/// <summary>
		/// Name: ProjectionData
		/// Type: StructProperty
		/// Offset: 0x50
		/// Size: 0x30
		/// </summary>
		public FEnvTraceData ProjectionData => ReadStruct<FEnvTraceData>(0x50);
		
	}


	/// <summary>
	/// UEnvQueryGenerator_Donut:UEnvQueryGenerator_ProjectedPoints
	/// Size: 0x1A8
	/// Properties: 9
	/// </summary>
	public class UEnvQueryGenerator_Donut:UEnvQueryGenerator_ProjectedPoints
	{
		public override int ObjectSize => 424;
		/// <summary>
		/// Name: InnerRadius
		/// Type: StructProperty
		/// Offset: 0x80
		/// Size: 0x30
		/// </summary>
		public FAIDataProviderFloatValue InnerRadius => ReadStruct<FAIDataProviderFloatValue>(0x80);
		
		/// <summary>
		/// Name: OuterRadius
		/// Type: StructProperty
		/// Offset: 0xB0
		/// Size: 0x30
		/// </summary>
		public FAIDataProviderFloatValue OuterRadius => ReadStruct<FAIDataProviderFloatValue>(0xB0);
		
		/// <summary>
		/// Name: NumberOfRings
		/// Type: StructProperty
		/// Offset: 0xE0
		/// Size: 0x30
		/// </summary>
		public FAIDataProviderIntValue NumberOfRings => ReadStruct<FAIDataProviderIntValue>(0xE0);
		
		/// <summary>
		/// Name: PointsPerRing
		/// Type: StructProperty
		/// Offset: 0x110
		/// Size: 0x30
		/// </summary>
		public FAIDataProviderIntValue PointsPerRing => ReadStruct<FAIDataProviderIntValue>(0x110);
		
		/// <summary>
		/// Name: ArcDirection
		/// Type: StructProperty
		/// Offset: 0x140
		/// Size: 0x20
		/// </summary>
		public FEnvDirection ArcDirection => ReadStruct<FEnvDirection>(0x140);
		
		/// <summary>
		/// Name: ArcAngle
		/// Type: StructProperty
		/// Offset: 0x160
		/// Size: 0x30
		/// </summary>
		public FAIDataProviderFloatValue ArcAngle => ReadStruct<FAIDataProviderFloatValue>(0x160);
		
		/// <summary>
		/// Name: bUseSpiralPattern
		/// Type: BoolProperty
		/// Offset: 0x190
		/// Size: 0x01
		/// </summary>
		public bool bUseSpiralPattern
		{
			get
			{
				return ReadBool(0x190);
			}
			set
			{
				WriteBool(0x190,value);
			}
		}
		
		/// <summary>
		/// Name: Center
		/// Type: ClassProperty
		/// Offset: 0x198
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: bDefineArc
		/// Type: BoolProperty
		/// Offset: 0x1A0
		/// Size: 0x01
		/// </summary>
		public bool bDefineArc => (ReadByte(0x01A0) & 0x01) == 0x01;
		
	}


	/// <summary>
	/// UEnvQueryGenerator_OnCircle:UEnvQueryGenerator_ProjectedPoints
	/// Size: 0x1E8
	/// Properties: 12
	/// </summary>
	public class UEnvQueryGenerator_OnCircle:UEnvQueryGenerator_ProjectedPoints
	{
		public override int ObjectSize => 488;
		/// <summary>
		/// Name: CircleRadius
		/// Type: StructProperty
		/// Offset: 0x80
		/// Size: 0x30
		/// </summary>
		public FAIDataProviderFloatValue CircleRadius => ReadStruct<FAIDataProviderFloatValue>(0x80);
		
		/// <summary>
		/// Name: SpaceBetween
		/// Type: StructProperty
		/// Offset: 0xB0
		/// Size: 0x30
		/// </summary>
		public FAIDataProviderFloatValue SpaceBetween => ReadStruct<FAIDataProviderFloatValue>(0xB0);
		
		/// <summary>
		/// Name: NumberOfPoints
		/// Type: StructProperty
		/// Offset: 0xE0
		/// Size: 0x30
		/// </summary>
		public FAIDataProviderIntValue NumberOfPoints => ReadStruct<FAIDataProviderIntValue>(0xE0);
		
		/// <summary>
		/// Name: PointOnCircleSpacingMethod
		/// Type: ByteProperty
		/// Offset: 0x110
		/// Size: 0x01
		/// </summary>
		public byte PointOnCircleSpacingMethod
		{
			get
			{
				return ReadByte(0x110);
			}
			set
			{
				WriteByte(0x110,value);
			}
		}
		
		/// <summary>
		/// Name: ArcDirection
		/// Type: StructProperty
		/// Offset: 0x118
		/// Size: 0x20
		/// </summary>
		public FEnvDirection ArcDirection => ReadStruct<FEnvDirection>(0x118);
		
		/// <summary>
		/// Name: ArcAngle
		/// Type: StructProperty
		/// Offset: 0x138
		/// Size: 0x30
		/// </summary>
		public FAIDataProviderFloatValue ArcAngle => ReadStruct<FAIDataProviderFloatValue>(0x138);
		
		/// <summary>
		/// Name: AngleRadians
		/// Type: FloatProperty
		/// Offset: 0x168
		/// Size: 0x04
		/// </summary>
		public float AngleRadians
		{
			get
			{
				return ReadSingle(0x168);
			}
			set
			{
				WriteSingle(0x168,value);
			}
		}
		
		/// <summary>
		/// Name: CircleCenter
		/// Type: ClassProperty
		/// Offset: 0x170
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: bIgnoreAnyContextActorsWhenGeneratingCircle
		/// Type: BoolProperty
		/// Offset: 0x178
		/// Size: 0x01
		/// </summary>
		public bool bIgnoreAnyContextActorsWhenGeneratingCircle
		{
			get
			{
				return ReadBool(0x178);
			}
			set
			{
				WriteBool(0x178,value);
			}
		}
		
		/// <summary>
		/// Name: CircleCenterZOffset
		/// Type: StructProperty
		/// Offset: 0x180
		/// Size: 0x30
		/// </summary>
		public FAIDataProviderFloatValue CircleCenterZOffset => ReadStruct<FAIDataProviderFloatValue>(0x180);
		
		/// <summary>
		/// Name: TraceData
		/// Type: StructProperty
		/// Offset: 0x1B0
		/// Size: 0x30
		/// </summary>
		public FEnvTraceData TraceData => ReadStruct<FEnvTraceData>(0x1B0);
		
		/// <summary>
		/// Name: bDefineArc
		/// Type: BoolProperty
		/// Offset: 0x1E0
		/// Size: 0x01
		/// </summary>
		public bool bDefineArc => (ReadByte(0x01E0) & 0x01) == 0x01;
		
	}


	/// <summary>
	/// UEnvQueryGenerator_SimpleGrid:UEnvQueryGenerator_ProjectedPoints
	/// Size: 0xE8
	/// Properties: 3
	/// </summary>
	public class UEnvQueryGenerator_SimpleGrid:UEnvQueryGenerator_ProjectedPoints
	{
		public override int ObjectSize => 232;
		/// <summary>
		/// Name: GridSize
		/// Type: StructProperty
		/// Offset: 0x80
		/// Size: 0x30
		/// </summary>
		public FAIDataProviderFloatValue GridSize => ReadStruct<FAIDataProviderFloatValue>(0x80);
		
		/// <summary>
		/// Name: SpaceBetween
		/// Type: StructProperty
		/// Offset: 0xB0
		/// Size: 0x30
		/// </summary>
		public FAIDataProviderFloatValue SpaceBetween => ReadStruct<FAIDataProviderFloatValue>(0xB0);
		
		/// <summary>
		/// Name: GenerateAround
		/// Type: ClassProperty
		/// Offset: 0xE0
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// UEnvQueryGenerator_PathingGrid:UEnvQueryGenerator_SimpleGrid
	/// Size: 0x150
	/// Properties: 3
	/// </summary>
	public class UEnvQueryGenerator_PathingGrid:UEnvQueryGenerator_SimpleGrid
	{
		public override int ObjectSize => 336;
		/// <summary>
		/// Name: PathToItem
		/// Type: StructProperty
		/// Offset: 0xE8
		/// Size: 0x30
		/// </summary>
		public FAIDataProviderBoolValue PathToItem => ReadStruct<FAIDataProviderBoolValue>(0xE8);
		
		/// <summary>
		/// Name: NavigationFilter
		/// Type: ClassProperty
		/// Offset: 0x118
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: ScanRangeMultiplier
		/// Type: StructProperty
		/// Offset: 0x120
		/// Size: 0x30
		/// </summary>
		public FAIDataProviderFloatValue ScanRangeMultiplier => ReadStruct<FAIDataProviderFloatValue>(0x120);
		
	}


	/// <summary>
	/// UEnvQueryTest:UEnvQueryNode
	/// Size: 0x1C0
	/// Properties: 18
	/// </summary>
	public class UEnvQueryTest:UEnvQueryNode
	{
		public override int ObjectSize => 448;
		/// <summary>
		/// Name: TestOrder
		/// Type: IntProperty
		/// Offset: 0x30
		/// Size: 0x04
		/// </summary>
		public int TestOrder
		{
			get
			{
				return ReadInt32(0x30);
			}
			set
			{
				WriteInt32(0x30,value);
			}
		}
		
		/// <summary>
		/// Name: TestPurpose
		/// Type: ByteProperty
		/// Offset: 0x34
		/// Size: 0x01
		/// </summary>
		public byte TestPurpose
		{
			get
			{
				return ReadByte(0x34);
			}
			set
			{
				WriteByte(0x34,value);
			}
		}
		
		/// <summary>
		/// Name: TestComment
		/// Type: StrProperty
		/// Offset: 0x38
		/// Size: 0x10
		/// </summary>
		public FString TestComment => new FString(BaseAddress+0x38);
		
		/// <summary>
		/// Name: MultipleContextFilterOp
		/// Type: ByteProperty
		/// Offset: 0x48
		/// Size: 0x01
		/// </summary>
		public byte MultipleContextFilterOp
		{
			get
			{
				return ReadByte(0x48);
			}
			set
			{
				WriteByte(0x48,value);
			}
		}
		
		/// <summary>
		/// Name: MultipleContextScoreOp
		/// Type: ByteProperty
		/// Offset: 0x49
		/// Size: 0x01
		/// </summary>
		public byte MultipleContextScoreOp
		{
			get
			{
				return ReadByte(0x49);
			}
			set
			{
				WriteByte(0x49,value);
			}
		}
		
		/// <summary>
		/// Name: FilterType
		/// Type: ByteProperty
		/// Offset: 0x4A
		/// Size: 0x01
		/// </summary>
		public byte FilterType
		{
			get
			{
				return ReadByte(0x4A);
			}
			set
			{
				WriteByte(0x4A,value);
			}
		}
		
		/// <summary>
		/// Name: BoolValue
		/// Type: StructProperty
		/// Offset: 0x50
		/// Size: 0x30
		/// </summary>
		public FAIDataProviderBoolValue BoolValue => ReadStruct<FAIDataProviderBoolValue>(0x50);
		
		/// <summary>
		/// Name: FloatValueMin
		/// Type: StructProperty
		/// Offset: 0x80
		/// Size: 0x30
		/// </summary>
		public FAIDataProviderFloatValue FloatValueMin => ReadStruct<FAIDataProviderFloatValue>(0x80);
		
		/// <summary>
		/// Name: FloatValueMax
		/// Type: StructProperty
		/// Offset: 0xB0
		/// Size: 0x30
		/// </summary>
		public FAIDataProviderFloatValue FloatValueMax => ReadStruct<FAIDataProviderFloatValue>(0xB0);
		
		/// <summary>
		/// Name: ScoringEquation
		/// Type: ByteProperty
		/// Offset: 0xE1
		/// Size: 0x01
		/// </summary>
		public byte ScoringEquation
		{
			get
			{
				return ReadByte(0xE1);
			}
			set
			{
				WriteByte(0xE1,value);
			}
		}
		
		/// <summary>
		/// Name: ClampMinType
		/// Type: ByteProperty
		/// Offset: 0xE2
		/// Size: 0x01
		/// </summary>
		public byte ClampMinType
		{
			get
			{
				return ReadByte(0xE2);
			}
			set
			{
				WriteByte(0xE2,value);
			}
		}
		
		/// <summary>
		/// Name: ClampMaxType
		/// Type: ByteProperty
		/// Offset: 0xE3
		/// Size: 0x01
		/// </summary>
		public byte ClampMaxType
		{
			get
			{
				return ReadByte(0xE3);
			}
			set
			{
				WriteByte(0xE3,value);
			}
		}
		
		/// <summary>
		/// Name: ScoreClampMin
		/// Type: StructProperty
		/// Offset: 0xE8
		/// Size: 0x30
		/// </summary>
		public FAIDataProviderFloatValue ScoreClampMin => ReadStruct<FAIDataProviderFloatValue>(0xE8);
		
		/// <summary>
		/// Name: ScoreClampMax
		/// Type: StructProperty
		/// Offset: 0x118
		/// Size: 0x30
		/// </summary>
		public FAIDataProviderFloatValue ScoreClampMax => ReadStruct<FAIDataProviderFloatValue>(0x118);
		
		/// <summary>
		/// Name: ScoringFactor
		/// Type: StructProperty
		/// Offset: 0x148
		/// Size: 0x30
		/// </summary>
		public FAIDataProviderFloatValue ScoringFactor => ReadStruct<FAIDataProviderFloatValue>(0x148);
		
		/// <summary>
		/// Name: ReferenceValue
		/// Type: StructProperty
		/// Offset: 0x178
		/// Size: 0x30
		/// </summary>
		public FAIDataProviderFloatValue ReferenceValue => ReadStruct<FAIDataProviderFloatValue>(0x178);
		
		/// <summary>
		/// Name: bDefineReferenceValue
		/// Type: BoolProperty
		/// Offset: 0x1A8
		/// Size: 0x01
		/// </summary>
		public bool bDefineReferenceValue
		{
			get
			{
				return ReadBool(0x1A8);
			}
			set
			{
				WriteBool(0x1A8,value);
			}
		}
		
		/// <summary>
		/// Name: bWorkOnFloatValues
		/// Type: BoolProperty
		/// Offset: 0x1B8
		/// Size: 0x01
		/// </summary>
		public bool bWorkOnFloatValues => (ReadByte(0x01B8) & 0x01) == 0x01;
		
	}


	/// <summary>
	/// UEnvQueryTest_Distance:UEnvQueryTest
	/// Size: 0x1D0
	/// Properties: 2
	/// </summary>
	public class UEnvQueryTest_Distance:UEnvQueryTest
	{
		public override int ObjectSize => 464;
		/// <summary>
		/// Name: TestMode
		/// Type: ByteProperty
		/// Offset: 0x1C0
		/// Size: 0x01
		/// </summary>
		public byte TestMode
		{
			get
			{
				return ReadByte(0x1C0);
			}
			set
			{
				WriteByte(0x1C0,value);
			}
		}
		
		/// <summary>
		/// Name: DistanceTo
		/// Type: ClassProperty
		/// Offset: 0x1C8
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// UEnvQueryTest_Dot:UEnvQueryTest
	/// Size: 0x208
	/// Properties: 4
	/// </summary>
	public class UEnvQueryTest_Dot:UEnvQueryTest
	{
		public override int ObjectSize => 520;
		/// <summary>
		/// Name: LineA
		/// Type: StructProperty
		/// Offset: 0x1C0
		/// Size: 0x20
		/// </summary>
		public FEnvDirection LineA => ReadStruct<FEnvDirection>(0x1C0);
		
		/// <summary>
		/// Name: LineB
		/// Type: StructProperty
		/// Offset: 0x1E0
		/// Size: 0x20
		/// </summary>
		public FEnvDirection LineB => ReadStruct<FEnvDirection>(0x1E0);
		
		/// <summary>
		/// Name: TestMode
		/// Type: ByteProperty
		/// Offset: 0x200
		/// Size: 0x01
		/// </summary>
		public byte TestMode
		{
			get
			{
				return ReadByte(0x200);
			}
			set
			{
				WriteByte(0x200,value);
			}
		}
		
		/// <summary>
		/// Name: bAbsoluteValue
		/// Type: BoolProperty
		/// Offset: 0x201
		/// Size: 0x01
		/// </summary>
		public bool bAbsoluteValue
		{
			get
			{
				return ReadBool(0x201);
			}
			set
			{
				WriteBool(0x201,value);
			}
		}
		
	}


	/// <summary>
	/// UEnvQueryTest_GameplayTags:UEnvQueryTest
	/// Size: 0x1E8
	/// Properties: 2
	/// </summary>
	public class UEnvQueryTest_GameplayTags:UEnvQueryTest
	{
		public override int ObjectSize => 488;
		/// <summary>
		/// Name: TagsToMatch
		/// Type: ByteProperty
		/// Offset: 0x1C0
		/// Size: 0x01
		/// </summary>
		public byte TagsToMatch
		{
			get
			{
				return ReadByte(0x1C0);
			}
			set
			{
				WriteByte(0x1C0,value);
			}
		}
		
		/// <summary>
		/// Name: GameplayTags
		/// Type: StructProperty
		/// Offset: 0x1C8
		/// Size: 0x20
		/// </summary>
		public FGameplayTagContainer GameplayTags => ReadStruct<FGameplayTagContainer>(0x1C8);
		
	}


	/// <summary>
	/// UEnvQueryTest_Overlap:UEnvQueryTest
	/// Size: 0x1E0
	/// Properties: 1
	/// </summary>
	public class UEnvQueryTest_Overlap:UEnvQueryTest
	{
		public override int ObjectSize => 480;
		/// <summary>
		/// Name: OverlapData
		/// Type: StructProperty
		/// Offset: 0x1C0
		/// Size: 0x20
		/// </summary>
		public FEnvOverlapData OverlapData => ReadStruct<FEnvOverlapData>(0x1C0);
		
	}


	/// <summary>
	/// UEnvQueryTest_Pathfinding:UEnvQueryTest
	/// Size: 0x238
	/// Properties: 5
	/// </summary>
	public class UEnvQueryTest_Pathfinding:UEnvQueryTest
	{
		public override int ObjectSize => 568;
		/// <summary>
		/// Name: TestMode
		/// Type: ByteProperty
		/// Offset: 0x1C0
		/// Size: 0x01
		/// </summary>
		public byte TestMode
		{
			get
			{
				return ReadByte(0x1C0);
			}
			set
			{
				WriteByte(0x1C0,value);
			}
		}
		
		/// <summary>
		/// Name: Context
		/// Type: ClassProperty
		/// Offset: 0x1C8
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: PathFromContext
		/// Type: StructProperty
		/// Offset: 0x1D0
		/// Size: 0x30
		/// </summary>
		public FAIDataProviderBoolValue PathFromContext => ReadStruct<FAIDataProviderBoolValue>(0x1D0);
		
		/// <summary>
		/// Name: SkipUnreachable
		/// Type: StructProperty
		/// Offset: 0x200
		/// Size: 0x30
		/// </summary>
		public FAIDataProviderBoolValue SkipUnreachable => ReadStruct<FAIDataProviderBoolValue>(0x200);
		
		/// <summary>
		/// Name: FilterClass
		/// Type: ClassProperty
		/// Offset: 0x230
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// UEnvQueryTest_PathfindingBatch:UEnvQueryTest_Pathfinding
	/// Size: 0x268
	/// Properties: 1
	/// </summary>
	public class UEnvQueryTest_PathfindingBatch:UEnvQueryTest_Pathfinding
	{
		public override int ObjectSize => 616;
		/// <summary>
		/// Name: ScanRangeMultiplier
		/// Type: StructProperty
		/// Offset: 0x238
		/// Size: 0x30
		/// </summary>
		public FAIDataProviderFloatValue ScanRangeMultiplier => ReadStruct<FAIDataProviderFloatValue>(0x238);
		
	}


	/// <summary>
	/// UEnvQueryTest_Project:UEnvQueryTest
	/// Size: 0x1F0
	/// Properties: 1
	/// </summary>
	public class UEnvQueryTest_Project:UEnvQueryTest
	{
		public override int ObjectSize => 496;
		/// <summary>
		/// Name: ProjectionData
		/// Type: StructProperty
		/// Offset: 0x1C0
		/// Size: 0x30
		/// </summary>
		public FEnvTraceData ProjectionData => ReadStruct<FEnvTraceData>(0x1C0);
		
	}


	/// <summary>
	/// UEnvQueryTest_Random:UEnvQueryTest
	/// Size: 0x1C0
	/// Properties: 0
	/// </summary>
	public class UEnvQueryTest_Random:UEnvQueryTest
	{
		public override int ObjectSize => 448;
	}


	/// <summary>
	/// UEnvQueryTest_Trace:UEnvQueryTest
	/// Size: 0x288
	/// Properties: 5
	/// </summary>
	public class UEnvQueryTest_Trace:UEnvQueryTest
	{
		public override int ObjectSize => 648;
		/// <summary>
		/// Name: TraceData
		/// Type: StructProperty
		/// Offset: 0x1C0
		/// Size: 0x30
		/// </summary>
		public FEnvTraceData TraceData => ReadStruct<FEnvTraceData>(0x1C0);
		
		/// <summary>
		/// Name: TraceFromContext
		/// Type: StructProperty
		/// Offset: 0x1F0
		/// Size: 0x30
		/// </summary>
		public FAIDataProviderBoolValue TraceFromContext => ReadStruct<FAIDataProviderBoolValue>(0x1F0);
		
		/// <summary>
		/// Name: ItemHeightOffset
		/// Type: StructProperty
		/// Offset: 0x220
		/// Size: 0x30
		/// </summary>
		public FAIDataProviderFloatValue ItemHeightOffset => ReadStruct<FAIDataProviderFloatValue>(0x220);
		
		/// <summary>
		/// Name: ContextHeightOffset
		/// Type: StructProperty
		/// Offset: 0x250
		/// Size: 0x30
		/// </summary>
		public FAIDataProviderFloatValue ContextHeightOffset => ReadStruct<FAIDataProviderFloatValue>(0x250);
		
		/// <summary>
		/// Name: Context
		/// Type: ClassProperty
		/// Offset: 0x280
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// UEnvQueryOption:UObject
	/// Size: 0x40
	/// Properties: 2
	/// </summary>
	public class UEnvQueryOption:UObject
	{
		public override int ObjectSize => 64;
		/// <summary>
		/// Name: Generator
		/// Type: ObjectProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		public UEnvQueryGenerator Generator => ReadUObject<UEnvQueryGenerator>(0x28);
		
		/// <summary>
		/// Name: Tests
		/// Type: TArray<UEnvQueryTest>
		/// Offset: 0x30
		/// Size: 0x10
		/// SubElement Size: 0x1C0
		/// </summary>
		public TArray<UEnvQueryTest> Tests => new TArray<UEnvQueryTest>(BaseAddress+0x30);
		
	}


	/// <summary>
	/// UEQSRenderingComponent:UPrimitiveComponent
	/// Size: 0x5C0
	/// Properties: 0
	/// </summary>
	public class UEQSRenderingComponent:UPrimitiveComponent
	{
		public override int ObjectSize => 1472;
	}


	/// <summary>
	/// AEQSTestingPawn:ACharacter
	/// Size: 0x850
	/// Properties: 12
	/// </summary>
	public class AEQSTestingPawn:ACharacter
	{
		public override int ObjectSize => 2128;
		/// <summary>
		/// Name: QueryTemplate
		/// Type: ObjectProperty
		/// Offset: 0x7E8
		/// Size: 0x08
		/// </summary>
		public UEnvQuery QueryTemplate => ReadUObject<UEnvQuery>(0x7E8);
		
		/// <summary>
		/// Name: QueryParams
		/// Type: TArray<FEnvNamedValue>
		/// Offset: 0x7F0
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FEnvNamedValue> QueryParams => new TArray<FEnvNamedValue>(BaseAddress+0x7F0);
		
		/// <summary>
		/// Name: QueryConfig
		/// Type: TArray<FAIDynamicParam>
		/// Offset: 0x800
		/// Size: 0x10
		/// SubElement Size: 0x38
		/// </summary>
		public TArray<FAIDynamicParam> QueryConfig => new TArray<FAIDynamicParam>(BaseAddress+0x800);
		
		/// <summary>
		/// Name: TimeLimitPerStep
		/// Type: FloatProperty
		/// Offset: 0x810
		/// Size: 0x04
		/// </summary>
		public float TimeLimitPerStep
		{
			get
			{
				return ReadSingle(0x810);
			}
			set
			{
				WriteSingle(0x810,value);
			}
		}
		
		/// <summary>
		/// Name: StepToDebugDraw
		/// Type: IntProperty
		/// Offset: 0x814
		/// Size: 0x04
		/// </summary>
		public int StepToDebugDraw
		{
			get
			{
				return ReadInt32(0x814);
			}
			set
			{
				WriteInt32(0x814,value);
			}
		}
		
		/// <summary>
		/// Name: HighlightMode
		/// Type: ByteProperty
		/// Offset: 0x818
		/// Size: 0x01
		/// </summary>
		public byte HighlightMode
		{
			get
			{
				return ReadByte(0x818);
			}
			set
			{
				WriteByte(0x818,value);
			}
		}
		
		/// <summary>
		/// Name: bDrawLabels
		/// Type: BoolProperty
		/// Offset: 0x81C
		/// Size: 0x01
		/// </summary>
		public bool bDrawLabels => (ReadByte(0x081C) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bDrawFailedItems
		/// Type: BoolProperty
		/// Offset: 0x81C
		/// Size: 0x01
		/// </summary>
		public bool bDrawFailedItems => (ReadByte(0x081C) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bReRunQueryOnlyOnFinishedMove
		/// Type: BoolProperty
		/// Offset: 0x81C
		/// Size: 0x01
		/// </summary>
		public bool bReRunQueryOnlyOnFinishedMove => (ReadByte(0x081C) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bShouldBeVisibleInGame
		/// Type: BoolProperty
		/// Offset: 0x81C
		/// Size: 0x01
		/// </summary>
		public bool bShouldBeVisibleInGame => (ReadByte(0x081C) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bTickDuringGame
		/// Type: BoolProperty
		/// Offset: 0x81C
		/// Size: 0x01
		/// </summary>
		public bool bTickDuringGame => (ReadByte(0x081C) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: QueryingMode
		/// Type: ByteProperty
		/// Offset: 0x820
		/// Size: 0x01
		/// </summary>
		public byte QueryingMode
		{
			get
			{
				return ReadByte(0x820);
			}
			set
			{
				WriteByte(0x820,value);
			}
		}
		
	}


	/// <summary>
	/// UCrowdFollowingComponent:UPathFollowingComponent
	/// Size: 0x390
	/// Properties: 5
	/// </summary>
	public class UCrowdFollowingComponent:UPathFollowingComponent
	{
		public override int ObjectSize => 912;
		/// <summary>
		/// Name: CrowdAgentMoveDirection
		/// Type: StructProperty
		/// Offset: 0x340
		/// Size: 0x0C
		/// </summary>
		public FVector CrowdAgentMoveDirection => ReadStruct<FVector>(0x340);
		
		/// <summary>
		/// Name: CharacterMovement
		/// Type: ObjectProperty
		/// Offset: 0x350
		/// Size: 0x08
		/// </summary>
		public UCharacterMovementComponent CharacterMovement => ReadUObject<UCharacterMovementComponent>(0x350);
		
		/// <summary>
		/// Name: AvoidanceGroup
		/// Type: StructProperty
		/// Offset: 0x358
		/// Size: 0x04
		/// </summary>
		public FNavAvoidanceMask AvoidanceGroup => ReadStruct<FNavAvoidanceMask>(0x358);
		
		/// <summary>
		/// Name: GroupsToAvoid
		/// Type: StructProperty
		/// Offset: 0x35C
		/// Size: 0x04
		/// </summary>
		public FNavAvoidanceMask GroupsToAvoid => ReadStruct<FNavAvoidanceMask>(0x35C);
		
		/// <summary>
		/// Name: GroupsToIgnore
		/// Type: StructProperty
		/// Offset: 0x360
		/// Size: 0x04
		/// </summary>
		public FNavAvoidanceMask GroupsToIgnore => ReadStruct<FNavAvoidanceMask>(0x360);
		
	}


	/// <summary>
	/// UPawnAction_BlueprintBase:UPawnAction
	/// Size: 0xD0
	/// Properties: 0
	/// </summary>
	public class UPawnAction_BlueprintBase:UPawnAction
	{
		public override int ObjectSize => 208;
	}


	/// <summary>
	/// UPawnAction_Move:UPawnAction
	/// Size: 0x120
	/// Properties: 11
	/// </summary>
	public class UPawnAction_Move:UPawnAction
	{
		public override int ObjectSize => 288;
		/// <summary>
		/// Name: GoalActor
		/// Type: ObjectProperty
		/// Offset: 0xD0
		/// Size: 0x08
		/// </summary>
		public AActor GoalActor => ReadUObject<AActor>(0xD0);
		
		/// <summary>
		/// Name: GoalLocation
		/// Type: StructProperty
		/// Offset: 0xD8
		/// Size: 0x0C
		/// </summary>
		public FVector GoalLocation => ReadStruct<FVector>(0xD8);
		
		/// <summary>
		/// Name: AcceptableRadius
		/// Type: FloatProperty
		/// Offset: 0xE4
		/// Size: 0x04
		/// </summary>
		public float AcceptableRadius
		{
			get
			{
				return ReadSingle(0xE4);
			}
			set
			{
				WriteSingle(0xE4,value);
			}
		}
		
		/// <summary>
		/// Name: FilterClass
		/// Type: ClassProperty
		/// Offset: 0xE8
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: bAllowStrafe
		/// Type: BoolProperty
		/// Offset: 0xF0
		/// Size: 0x01
		/// </summary>
		public bool bAllowStrafe => (ReadByte(0x00F0) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bFinishOnOverlap
		/// Type: BoolProperty
		/// Offset: 0xF0
		/// Size: 0x01
		/// </summary>
		public bool bFinishOnOverlap => (ReadByte(0x00F0) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bUsePathfinding
		/// Type: BoolProperty
		/// Offset: 0xF0
		/// Size: 0x01
		/// </summary>
		public bool bUsePathfinding => (ReadByte(0x00F0) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bAllowPartialPath
		/// Type: BoolProperty
		/// Offset: 0xF0
		/// Size: 0x01
		/// </summary>
		public bool bAllowPartialPath => (ReadByte(0x00F0) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bProjectGoalToNavigation
		/// Type: BoolProperty
		/// Offset: 0xF0
		/// Size: 0x01
		/// </summary>
		public bool bProjectGoalToNavigation => (ReadByte(0x00F0) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bUpdatePathToGoal
		/// Type: BoolProperty
		/// Offset: 0xF0
		/// Size: 0x01
		/// </summary>
		public bool bUpdatePathToGoal => (ReadByte(0x00F0) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: bAbortChildActionOnPathChange
		/// Type: BoolProperty
		/// Offset: 0xF0
		/// Size: 0x01
		/// </summary>
		public bool bAbortChildActionOnPathChange => (ReadByte(0x00F0) & 0x40) == 0x40;
		
	}


	/// <summary>
	/// UPawnAction_Repeat:UPawnAction
	/// Size: 0xF0
	/// Properties: 3
	/// </summary>
	public class UPawnAction_Repeat:UPawnAction
	{
		public override int ObjectSize => 240;
		/// <summary>
		/// Name: ActionToRepeat
		/// Type: ObjectProperty
		/// Offset: 0xD0
		/// Size: 0x08
		/// </summary>
		public UPawnAction ActionToRepeat => ReadUObject<UPawnAction>(0xD0);
		
		/// <summary>
		/// Name: RecentActionCopy
		/// Type: ObjectProperty
		/// Offset: 0xD8
		/// Size: 0x08
		/// </summary>
		public UPawnAction RecentActionCopy => ReadUObject<UPawnAction>(0xD8);
		
		/// <summary>
		/// Name: ChildFailureHandlingMode
		/// Type: ByteProperty
		/// Offset: 0xE0
		/// Size: 0x01
		/// </summary>
		public byte ChildFailureHandlingMode
		{
			get
			{
				return ReadByte(0xE0);
			}
			set
			{
				WriteByte(0xE0,value);
			}
		}
		
	}


	/// <summary>
	/// UPawnAction_Sequence:UPawnAction
	/// Size: 0x100
	/// Properties: 3
	/// </summary>
	public class UPawnAction_Sequence:UPawnAction
	{
		public override int ObjectSize => 256;
		/// <summary>
		/// Name: ActionSequence
		/// Type: TArray<UPawnAction>
		/// Offset: 0xD0
		/// Size: 0x10
		/// SubElement Size: 0xD0
		/// </summary>
		public TArray<UPawnAction> ActionSequence => new TArray<UPawnAction>(BaseAddress+0xD0);
		
		/// <summary>
		/// Name: ChildFailureHandlingMode
		/// Type: ByteProperty
		/// Offset: 0xE0
		/// Size: 0x01
		/// </summary>
		public byte ChildFailureHandlingMode
		{
			get
			{
				return ReadByte(0xE0);
			}
			set
			{
				WriteByte(0xE0,value);
			}
		}
		
		/// <summary>
		/// Name: RecentActionCopy
		/// Type: ObjectProperty
		/// Offset: 0xE8
		/// Size: 0x08
		/// </summary>
		public UPawnAction RecentActionCopy => ReadUObject<UPawnAction>(0xE8);
		
	}


	/// <summary>
	/// UPawnAction_Wait:UPawnAction
	/// Size: 0xE0
	/// Properties: 1
	/// </summary>
	public class UPawnAction_Wait:UPawnAction
	{
		public override int ObjectSize => 224;
		/// <summary>
		/// Name: TimeToWait
		/// Type: FloatProperty
		/// Offset: 0xD0
		/// Size: 0x04
		/// </summary>
		public float TimeToWait
		{
			get
			{
				return ReadSingle(0xD0);
			}
			set
			{
				WriteSingle(0xD0,value);
			}
		}
		
	}


	/// <summary>
	/// UPawnSensingComponent:UActorComponent
	/// Size: 0x120
	/// Properties: 11
	/// </summary>
	public class UPawnSensingComponent:UActorComponent
	{
		public override int ObjectSize => 288;
		/// <summary>
		/// Name: HearingThreshold
		/// Type: FloatProperty
		/// Offset: 0xD8
		/// Size: 0x04
		/// </summary>
		public float HearingThreshold
		{
			get
			{
				return ReadSingle(0xD8);
			}
			set
			{
				WriteSingle(0xD8,value);
			}
		}
		
		/// <summary>
		/// Name: LOSHearingThreshold
		/// Type: FloatProperty
		/// Offset: 0xDC
		/// Size: 0x04
		/// </summary>
		public float LOSHearingThreshold
		{
			get
			{
				return ReadSingle(0xDC);
			}
			set
			{
				WriteSingle(0xDC,value);
			}
		}
		
		/// <summary>
		/// Name: SightRadius
		/// Type: FloatProperty
		/// Offset: 0xE0
		/// Size: 0x04
		/// </summary>
		public float SightRadius
		{
			get
			{
				return ReadSingle(0xE0);
			}
			set
			{
				WriteSingle(0xE0,value);
			}
		}
		
		/// <summary>
		/// Name: SensingInterval
		/// Type: FloatProperty
		/// Offset: 0xE4
		/// Size: 0x04
		/// </summary>
		public float SensingInterval
		{
			get
			{
				return ReadSingle(0xE4);
			}
			set
			{
				WriteSingle(0xE4,value);
			}
		}
		
		/// <summary>
		/// Name: HearingMaxSoundAge
		/// Type: FloatProperty
		/// Offset: 0xE8
		/// Size: 0x04
		/// </summary>
		public float HearingMaxSoundAge
		{
			get
			{
				return ReadSingle(0xE8);
			}
			set
			{
				WriteSingle(0xE8,value);
			}
		}
		
		/// <summary>
		/// Name: bEnableSensingUpdates
		/// Type: BoolProperty
		/// Offset: 0xEC
		/// Size: 0x01
		/// </summary>
		public bool bEnableSensingUpdates => (ReadByte(0x00EC) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bOnlySensePlayers
		/// Type: BoolProperty
		/// Offset: 0xEC
		/// Size: 0x01
		/// </summary>
		public bool bOnlySensePlayers => (ReadByte(0x00EC) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bSeePawns
		/// Type: BoolProperty
		/// Offset: 0xEC
		/// Size: 0x01
		/// </summary>
		public bool bSeePawns => (ReadByte(0x00EC) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bHearNoises
		/// Type: BoolProperty
		/// Offset: 0xEC
		/// Size: 0x01
		/// </summary>
		public bool bHearNoises => (ReadByte(0x00EC) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: PeripheralVisionAngle
		/// Type: FloatProperty
		/// Offset: 0x118
		/// Size: 0x04
		/// </summary>
		public float PeripheralVisionAngle
		{
			get
			{
				return ReadSingle(0x118);
			}
			set
			{
				WriteSingle(0x118,value);
			}
		}
		
		/// <summary>
		/// Name: PeripheralVisionCosine
		/// Type: FloatProperty
		/// Offset: 0x11C
		/// Size: 0x04
		/// </summary>
		public float PeripheralVisionCosine
		{
			get
			{
				return ReadSingle(0x11C);
			}
			set
			{
				WriteSingle(0x11C,value);
			}
		}
		
	}


	/// <summary>
	/// UHandlerComponentFactory:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UHandlerComponentFactory:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// ULevelSequence:UMovieSceneSequence
	/// Size: 0xD0
	/// Properties: 3
	/// </summary>
	public class ULevelSequence:UMovieSceneSequence
	{
		public override int ObjectSize => 208;
		/// <summary>
		/// Name: MovieScene
		/// Type: ObjectProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		public UMovieScene MovieScene => ReadUObject<UMovieScene>(0x28);
		
		/// <summary>
		/// Name: ObjectReferences
		/// Type: StructProperty
		/// Offset: 0x30
		/// Size: 0x50
		/// </summary>
		public FLevelSequenceObjectReferenceMap ObjectReferences => ReadStruct<FLevelSequenceObjectReferenceMap>(0x30);
		
		/// <summary>
		/// Name: PossessedObjects
		/// Type: MapProperty
		/// Offset: 0x80
		/// Size: 0x50
		/// </summary>
		
	}


	/// <summary>
	/// ULevelSequencePlayer:UObject
	/// Size: 0xA8
	/// Properties: 4
	/// </summary>
	public class ULevelSequencePlayer:UObject
	{
		public override int ObjectSize => 168;
		/// <summary>
		/// Name: LevelSequence
		/// Type: ObjectProperty
		/// Offset: 0x48
		/// Size: 0x08
		/// </summary>
		public ULevelSequence LevelSequence => ReadUObject<ULevelSequence>(0x48);
		
		/// <summary>
		/// Name: bIsPlaying
		/// Type: BoolProperty
		/// Offset: 0x50
		/// Size: 0x01
		/// </summary>
		public bool bIsPlaying
		{
			get
			{
				return ReadBool(0x50);
			}
			set
			{
				WriteBool(0x50,value);
			}
		}
		
		/// <summary>
		/// Name: TimeCursorPosition
		/// Type: FloatProperty
		/// Offset: 0x54
		/// Size: 0x04
		/// </summary>
		public float TimeCursorPosition
		{
			get
			{
				return ReadSingle(0x54);
			}
			set
			{
				WriteSingle(0x54,value);
			}
		}
		
		/// <summary>
		/// Name: PlaybackSettings
		/// Type: StructProperty
		/// Offset: 0x64
		/// Size: 0x08
		/// </summary>
		public FLevelSequencePlaybackSettings PlaybackSettings => ReadStruct<FLevelSequencePlaybackSettings>(0x64);
		
	}


	/// <summary>
	/// ALevelSequenceActor:AActor
	/// Size: 0x3F8
	/// Properties: 4
	/// </summary>
	public class ALevelSequenceActor:AActor
	{
		public override int ObjectSize => 1016;
		/// <summary>
		/// Name: bAutoPlay
		/// Type: BoolProperty
		/// Offset: 0x3D0
		/// Size: 0x01
		/// </summary>
		public bool bAutoPlay
		{
			get
			{
				return ReadBool(0x3D0);
			}
			set
			{
				WriteBool(0x3D0,value);
			}
		}
		
		/// <summary>
		/// Name: PlaybackSettings
		/// Type: StructProperty
		/// Offset: 0x3D4
		/// Size: 0x08
		/// </summary>
		public FLevelSequencePlaybackSettings PlaybackSettings => ReadStruct<FLevelSequencePlaybackSettings>(0x3D4);
		
		/// <summary>
		/// Name: SequencePlayer
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public ULevelSequencePlayer SequencePlayer => ReadUObject<ULevelSequencePlayer>(0x3E0);
		
		/// <summary>
		/// Name: LevelSequence
		/// Type: StructProperty
		/// Offset: 0x3E8
		/// Size: 0x10
		/// </summary>
		public FStringAssetReference LevelSequence => ReadStruct<FStringAssetReference>(0x3E8);
		
	}


	/// <summary>
	/// UMovieSceneCaptureInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UMovieSceneCaptureInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UMovieSceneCaptureProtocolSettings:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UMovieSceneCaptureProtocolSettings:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UMovieSceneCapture:UObject
	/// Size: 0x1F0
	/// Properties: 7
	/// </summary>
	public class UMovieSceneCapture:UObject
	{
		public override int ObjectSize => 496;
		/// <summary>
		/// Name: CaptureType
		/// Type: StructProperty
		/// Offset: 0x38
		/// Size: 0x08
		/// </summary>
		public FCaptureProtocolID CaptureType => ReadStruct<FCaptureProtocolID>(0x38);
		
		/// <summary>
		/// Name: ProtocolSettings
		/// Type: ObjectProperty
		/// Offset: 0x40
		/// Size: 0x08
		/// </summary>
		public UMovieSceneCaptureProtocolSettings ProtocolSettings => ReadUObject<UMovieSceneCaptureProtocolSettings>(0x40);
		
		/// <summary>
		/// Name: Settings
		/// Type: StructProperty
		/// Offset: 0x48
		/// Size: 0x48
		/// </summary>
		public FMovieSceneCaptureSettings Settings => ReadStruct<FMovieSceneCaptureSettings>(0x48);
		
		/// <summary>
		/// Name: bUseSeparateProcess
		/// Type: BoolProperty
		/// Offset: 0x90
		/// Size: 0x01
		/// </summary>
		public bool bUseSeparateProcess
		{
			get
			{
				return ReadBool(0x90);
			}
			set
			{
				WriteBool(0x90,value);
			}
		}
		
		/// <summary>
		/// Name: bCloseEditorWhenCaptureStarts
		/// Type: BoolProperty
		/// Offset: 0x91
		/// Size: 0x01
		/// </summary>
		public bool bCloseEditorWhenCaptureStarts
		{
			get
			{
				return ReadBool(0x91);
			}
			set
			{
				WriteBool(0x91,value);
			}
		}
		
		/// <summary>
		/// Name: AdditionalCommandLineArguments
		/// Type: StrProperty
		/// Offset: 0x98
		/// Size: 0x10
		/// </summary>
		public FString AdditionalCommandLineArguments => new FString(BaseAddress+0x98);
		
		/// <summary>
		/// Name: InheritedCommandLineArguments
		/// Type: StrProperty
		/// Offset: 0xA8
		/// Size: 0x10
		/// </summary>
		public FString InheritedCommandLineArguments => new FString(BaseAddress+0xA8);
		
	}


	/// <summary>
	/// UAutomatedLevelSequenceCapture:UMovieSceneCapture
	/// Size: 0x1F0
	/// Properties: 0
	/// </summary>
	public class UAutomatedLevelSequenceCapture:UMovieSceneCapture
	{
		public override int ObjectSize => 496;
	}


	/// <summary>
	/// ULevelCapture:UMovieSceneCapture
	/// Size: 0x210
	/// Properties: 2
	/// </summary>
	public class ULevelCapture:UMovieSceneCapture
	{
		public override int ObjectSize => 528;
		/// <summary>
		/// Name: bAutoStartCapture
		/// Type: BoolProperty
		/// Offset: 0x1F0
		/// Size: 0x01
		/// </summary>
		public bool bAutoStartCapture
		{
			get
			{
				return ReadBool(0x1F0);
			}
			set
			{
				WriteBool(0x1F0,value);
			}
		}
		
		/// <summary>
		/// Name: PrerequisiteActorId
		/// Type: StructProperty
		/// Offset: 0x1FC
		/// Size: 0x10
		/// </summary>
		public FGuid PrerequisiteActorId => ReadStruct<FGuid>(0x1FC);
		
	}


	/// <summary>
	/// UMovieSceneCaptureEnvironment:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UMovieSceneCaptureEnvironment:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UFrameGrabberProtocolSettings:UMovieSceneCaptureProtocolSettings
	/// Size: 0x30
	/// Properties: 0
	/// </summary>
	public class UFrameGrabberProtocolSettings:UMovieSceneCaptureProtocolSettings
	{
		public override int ObjectSize => 48;
	}


	/// <summary>
	/// UBmpImageCaptureSettings:UMovieSceneCaptureProtocolSettings
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBmpImageCaptureSettings:UMovieSceneCaptureProtocolSettings
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UImageCaptureSettings:UFrameGrabberProtocolSettings
	/// Size: 0x38
	/// Properties: 1
	/// </summary>
	public class UImageCaptureSettings:UFrameGrabberProtocolSettings
	{
		public override int ObjectSize => 56;
		/// <summary>
		/// Name: CompressionQuality
		/// Type: IntProperty
		/// Offset: 0x30
		/// Size: 0x04
		/// </summary>
		public int CompressionQuality
		{
			get
			{
				return ReadInt32(0x30);
			}
			set
			{
				WriteInt32(0x30,value);
			}
		}
		
	}


	/// <summary>
	/// UCompositionGraphCaptureSettings:UMovieSceneCaptureProtocolSettings
	/// Size: 0x50
	/// Properties: 3
	/// </summary>
	public class UCompositionGraphCaptureSettings:UMovieSceneCaptureProtocolSettings
	{
		public override int ObjectSize => 80;
		/// <summary>
		/// Name: IncludeRenderPasses
		/// Type: StructProperty
		/// Offset: 0x28
		/// Size: 0x10
		/// </summary>
		public FCompositionGraphCapturePasses IncludeRenderPasses => ReadStruct<FCompositionGraphCapturePasses>(0x28);
		
		/// <summary>
		/// Name: bCaptureFramesInHDR
		/// Type: BoolProperty
		/// Offset: 0x38
		/// Size: 0x01
		/// </summary>
		public bool bCaptureFramesInHDR
		{
			get
			{
				return ReadBool(0x38);
			}
			set
			{
				WriteBool(0x38,value);
			}
		}
		
		/// <summary>
		/// Name: PostProcessingMaterial
		/// Type: StructProperty
		/// Offset: 0x40
		/// Size: 0x10
		/// </summary>
		public FStringAssetReference PostProcessingMaterial => ReadStruct<FStringAssetReference>(0x40);
		
	}


	/// <summary>
	/// UVideoCaptureSettings:UFrameGrabberProtocolSettings
	/// Size: 0x48
	/// Properties: 3
	/// </summary>
	public class UVideoCaptureSettings:UFrameGrabberProtocolSettings
	{
		public override int ObjectSize => 72;
		/// <summary>
		/// Name: bUseCompression
		/// Type: BoolProperty
		/// Offset: 0x30
		/// Size: 0x01
		/// </summary>
		public bool bUseCompression
		{
			get
			{
				return ReadBool(0x30);
			}
			set
			{
				WriteBool(0x30,value);
			}
		}
		
		/// <summary>
		/// Name: CompressionQuality
		/// Type: FloatProperty
		/// Offset: 0x34
		/// Size: 0x04
		/// </summary>
		public float CompressionQuality
		{
			get
			{
				return ReadSingle(0x34);
			}
			set
			{
				WriteSingle(0x34,value);
			}
		}
		
		/// <summary>
		/// Name: VideoCodec
		/// Type: StrProperty
		/// Offset: 0x38
		/// Size: 0x10
		/// </summary>
		public FString VideoCodec => new FString(BaseAddress+0x38);
		
	}


	/// <summary>
	/// UMoviePlayerSettings:UObject
	/// Size: 0x40
	/// Properties: 3
	/// </summary>
	public class UMoviePlayerSettings:UObject
	{
		public override int ObjectSize => 64;
		/// <summary>
		/// Name: bWaitForMoviesToComplete
		/// Type: BoolProperty
		/// Offset: 0x28
		/// Size: 0x01
		/// </summary>
		public bool bWaitForMoviesToComplete
		{
			get
			{
				return ReadBool(0x28);
			}
			set
			{
				WriteBool(0x28,value);
			}
		}
		
		/// <summary>
		/// Name: bMoviesAreSkippable
		/// Type: BoolProperty
		/// Offset: 0x29
		/// Size: 0x01
		/// </summary>
		public bool bMoviesAreSkippable
		{
			get
			{
				return ReadBool(0x29);
			}
			set
			{
				WriteBool(0x29,value);
			}
		}
		
		/// <summary>
		/// Name: StartupMovies
		/// Type: TArray<>
		/// Offset: 0x30
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
	}


	/// <summary>
	/// UNamedInterfaces:UObject
	/// Size: 0xC0
	/// Properties: 2
	/// </summary>
	public class UNamedInterfaces:UObject
	{
		public override int ObjectSize => 192;
		/// <summary>
		/// Name: NamedInterfaces
		/// Type: TArray<FNamedInterface>
		/// Offset: 0x28
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FNamedInterface> NamedInterfaces => new TArray<FNamedInterface>(BaseAddress+0x28);
		
		/// <summary>
		/// Name: NamedInterfaceDefs
		/// Type: TArray<FNamedInterfaceDef>
		/// Offset: 0x38
		/// Size: 0x10
		/// SubElement Size: 0x18
		/// </summary>
		public TArray<FNamedInterfaceDef> NamedInterfaceDefs => new TArray<FNamedInterfaceDef>(BaseAddress+0x38);
		
	}


	/// <summary>
	/// UTurnBasedMatchInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UTurnBasedMatchInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UAchievementBlueprintLibrary:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UAchievementBlueprintLibrary:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UInAppPurchaseCallbackProxy:UObject
	/// Size: 0xC0
	/// Properties: 0
	/// </summary>
	public class UInAppPurchaseCallbackProxy:UObject
	{
		public override int ObjectSize => 192;
	}


	/// <summary>
	/// UInAppPurchaseQueryCallbackProxy:UObject
	/// Size: 0xD0
	/// Properties: 0
	/// </summary>
	public class UInAppPurchaseQueryCallbackProxy:UObject
	{
		public override int ObjectSize => 208;
	}


	/// <summary>
	/// UInAppPurchaseRestoreCallbackProxy:UObject
	/// Size: 0xD0
	/// Properties: 0
	/// </summary>
	public class UInAppPurchaseRestoreCallbackProxy:UObject
	{
		public override int ObjectSize => 208;
	}


	/// <summary>
	/// UNetConnection:UPlayer
	/// Size: 0x336A0
	/// Properties: 12
	/// </summary>
	public class UNetConnection:UPlayer
	{
		public override int ObjectSize => 210592;
		/// <summary>
		/// Name: Children
		/// Type: TArray<UChildConnection>
		/// Offset: 0x48
		/// Size: 0x10
		/// SubElement Size: 0x336A8
		/// </summary>
		public TArray<UChildConnection> Children => new TArray<UChildConnection>(BaseAddress+0x48);
		
		/// <summary>
		/// Name: Driver
		/// Type: ObjectProperty
		/// Offset: 0x58
		/// Size: 0x08
		/// </summary>
		public UNetDriver Driver => ReadUObject<UNetDriver>(0x58);
		
		/// <summary>
		/// Name: PackageMap
		/// Type: ObjectProperty
		/// Offset: 0x60
		/// Size: 0x08
		/// </summary>
		public UPackageMap PackageMap => ReadUObject<UPackageMap>(0x60);
		
		/// <summary>
		/// Name: OpenChannels
		/// Type: TArray<UChannel>
		/// Offset: 0x68
		/// Size: 0x10
		/// SubElement Size: 0x68
		/// </summary>
		public TArray<UChannel> OpenChannels => new TArray<UChannel>(BaseAddress+0x68);
		
		/// <summary>
		/// Name: SentTemporaries
		/// Type: TArray<AActor>
		/// Offset: 0x78
		/// Size: 0x10
		/// SubElement Size: 0x3D0
		/// </summary>
		public TArray<AActor> SentTemporaries => new TArray<AActor>(BaseAddress+0x78);
		
		/// <summary>
		/// Name: ViewTarget
		/// Type: ObjectProperty
		/// Offset: 0x88
		/// Size: 0x08
		/// </summary>
		public AActor ViewTarget => ReadUObject<AActor>(0x88);
		
		/// <summary>
		/// Name: OwningActor
		/// Type: ObjectProperty
		/// Offset: 0x90
		/// Size: 0x08
		/// </summary>
		public AActor OwningActor => ReadUObject<AActor>(0x90);
		
		/// <summary>
		/// Name: MaxPacket
		/// Type: IntProperty
		/// Offset: 0x98
		/// Size: 0x04
		/// </summary>
		public int MaxPacket
		{
			get
			{
				return ReadInt32(0x98);
			}
			set
			{
				WriteInt32(0x98,value);
			}
		}
		
		/// <summary>
		/// Name: InternalAck
		/// Type: BoolProperty
		/// Offset: 0x9C
		/// Size: 0x01
		/// </summary>
		public bool InternalAck => (ReadByte(0x009C) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: AsyncLoadedObjects
		/// Type: TArray<UObject>
		/// Offset: 0xA0
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<UObject> AsyncLoadedObjects => new TArray<UObject>(BaseAddress+0xA0);
		
		/// <summary>
		/// Name: LastReceiveTime
		/// Type: DoubleProperty
		/// Offset: 0x1D8
		/// Size: 0x08
		/// </summary>
		public double LastReceiveTime
		{
			get
			{
				return ReadDouble(0x1D8);
			}
			set
			{
				WriteDouble(0x1D8,value);
			}
		}
		
		/// <summary>
		/// Name: ChannelsToTick
		/// Type: TArray<UChannel>
		/// Offset: 0x33690
		/// Size: 0x10
		/// SubElement Size: 0x68
		/// </summary>
		public TArray<UChannel> ChannelsToTick => new TArray<UChannel>(BaseAddress+0x33690);
		
	}


	/// <summary>
	/// UIpConnection:UNetConnection
	/// Size: 0x336C0
	/// Properties: 0
	/// </summary>
	public class UIpConnection:UNetConnection
	{
		public override int ObjectSize => 210624;
	}


	/// <summary>
	/// UNetDriver:UObject
	/// Size: 0x350
	/// Properties: 22
	/// </summary>
	public class UNetDriver:UObject
	{
		public override int ObjectSize => 848;
		/// <summary>
		/// Name: NetConnectionClassName
		/// Type: StrProperty
		/// Offset: 0x30
		/// Size: 0x10
		/// </summary>
		public FString NetConnectionClassName => new FString(BaseAddress+0x30);
		
		/// <summary>
		/// Name: MaxDownloadSize
		/// Type: IntProperty
		/// Offset: 0x40
		/// Size: 0x04
		/// </summary>
		public int MaxDownloadSize
		{
			get
			{
				return ReadInt32(0x40);
			}
			set
			{
				WriteInt32(0x40,value);
			}
		}
		
		/// <summary>
		/// Name: bClampListenServerTickRate
		/// Type: BoolProperty
		/// Offset: 0x44
		/// Size: 0x01
		/// </summary>
		public bool bClampListenServerTickRate => (ReadByte(0x0044) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: NetServerMaxTickRate
		/// Type: IntProperty
		/// Offset: 0x48
		/// Size: 0x04
		/// </summary>
		public int NetServerMaxTickRate
		{
			get
			{
				return ReadInt32(0x48);
			}
			set
			{
				WriteInt32(0x48,value);
			}
		}
		
		/// <summary>
		/// Name: MaxInternetClientRate
		/// Type: IntProperty
		/// Offset: 0x4C
		/// Size: 0x04
		/// </summary>
		public int MaxInternetClientRate
		{
			get
			{
				return ReadInt32(0x4C);
			}
			set
			{
				WriteInt32(0x4C,value);
			}
		}
		
		/// <summary>
		/// Name: MaxClientRate
		/// Type: IntProperty
		/// Offset: 0x50
		/// Size: 0x04
		/// </summary>
		public int MaxClientRate
		{
			get
			{
				return ReadInt32(0x50);
			}
			set
			{
				WriteInt32(0x50,value);
			}
		}
		
		/// <summary>
		/// Name: ServerTravelPause
		/// Type: FloatProperty
		/// Offset: 0x54
		/// Size: 0x04
		/// </summary>
		public float ServerTravelPause
		{
			get
			{
				return ReadSingle(0x54);
			}
			set
			{
				WriteSingle(0x54,value);
			}
		}
		
		/// <summary>
		/// Name: SpawnPrioritySeconds
		/// Type: FloatProperty
		/// Offset: 0x58
		/// Size: 0x04
		/// </summary>
		public float SpawnPrioritySeconds
		{
			get
			{
				return ReadSingle(0x58);
			}
			set
			{
				WriteSingle(0x58,value);
			}
		}
		
		/// <summary>
		/// Name: RelevantTimeout
		/// Type: FloatProperty
		/// Offset: 0x5C
		/// Size: 0x04
		/// </summary>
		public float RelevantTimeout
		{
			get
			{
				return ReadSingle(0x5C);
			}
			set
			{
				WriteSingle(0x5C,value);
			}
		}
		
		/// <summary>
		/// Name: ExtendedRelevantTimeout
		/// Type: FloatProperty
		/// Offset: 0x60
		/// Size: 0x04
		/// </summary>
		public float ExtendedRelevantTimeout
		{
			get
			{
				return ReadSingle(0x60);
			}
			set
			{
				WriteSingle(0x60,value);
			}
		}
		
		/// <summary>
		/// Name: KeepAliveTime
		/// Type: FloatProperty
		/// Offset: 0x64
		/// Size: 0x04
		/// </summary>
		public float KeepAliveTime
		{
			get
			{
				return ReadSingle(0x64);
			}
			set
			{
				WriteSingle(0x64,value);
			}
		}
		
		/// <summary>
		/// Name: InitialConnectTimeout
		/// Type: FloatProperty
		/// Offset: 0x68
		/// Size: 0x04
		/// </summary>
		public float InitialConnectTimeout
		{
			get
			{
				return ReadSingle(0x68);
			}
			set
			{
				WriteSingle(0x68,value);
			}
		}
		
		/// <summary>
		/// Name: ConnectionTimeout
		/// Type: FloatProperty
		/// Offset: 0x6C
		/// Size: 0x04
		/// </summary>
		public float ConnectionTimeout
		{
			get
			{
				return ReadSingle(0x6C);
			}
			set
			{
				WriteSingle(0x6C,value);
			}
		}
		
		/// <summary>
		/// Name: bNoTimeouts
		/// Type: BoolProperty
		/// Offset: 0x70
		/// Size: 0x01
		/// </summary>
		public bool bNoTimeouts
		{
			get
			{
				return ReadBool(0x70);
			}
			set
			{
				WriteBool(0x70,value);
			}
		}
		
		/// <summary>
		/// Name: ServerConnection
		/// Type: ObjectProperty
		/// Offset: 0x78
		/// Size: 0x08
		/// </summary>
		public UNetConnection ServerConnection => ReadUObject<UNetConnection>(0x78);
		
		/// <summary>
		/// Name: ClientConnections
		/// Type: TArray<UNetConnection>
		/// Offset: 0x80
		/// Size: 0x10
		/// SubElement Size: 0x336A0
		/// </summary>
		public TArray<UNetConnection> ClientConnections => new TArray<UNetConnection>(BaseAddress+0x80);
		
		/// <summary>
		/// Name: World
		/// Type: ObjectProperty
		/// Offset: 0xA8
		/// Size: 0x08
		/// </summary>
		public UWorld World => ReadUObject<UWorld>(0xA8);
		
		/// <summary>
		/// Name: NetConnectionClass
		/// Type: ClassProperty
		/// Offset: 0xD0
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: RoleProperty
		/// Type: ObjectProperty
		/// Offset: 0xD8
		/// Size: 0x08
		/// </summary>
		public UProperty RoleProperty => ReadUObject<UProperty>(0xD8);
		
		/// <summary>
		/// Name: RemoteRoleProperty
		/// Type: ObjectProperty
		/// Offset: 0xE0
		/// Size: 0x08
		/// </summary>
		public UProperty RemoteRoleProperty => ReadUObject<UProperty>(0xE0);
		
		/// <summary>
		/// Name: NetDriverName
		/// Type: NameProperty
		/// Offset: 0xE8
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: Time
		/// Type: FloatProperty
		/// Offset: 0xF8
		/// Size: 0x04
		/// </summary>
		public float Time
		{
			get
			{
				return ReadSingle(0xF8);
			}
			set
			{
				WriteSingle(0xF8,value);
			}
		}
		
	}


	/// <summary>
	/// UIpNetDriver:UNetDriver
	/// Size: 0x370
	/// Properties: 3
	/// </summary>
	public class UIpNetDriver:UNetDriver
	{
		public override int ObjectSize => 880;
		/// <summary>
		/// Name: LogPortUnreach
		/// Type: BoolProperty
		/// Offset: 0x350
		/// Size: 0x01
		/// </summary>
		public bool LogPortUnreach => (ReadByte(0x0350) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: AllowPlayerPortUnreach
		/// Type: BoolProperty
		/// Offset: 0x350
		/// Size: 0x01
		/// </summary>
		public bool AllowPlayerPortUnreach => (ReadByte(0x0350) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: MaxPortCountToTry
		/// Type: UInt32Property
		/// Offset: 0x354
		/// Size: 0x04
		/// </summary>
		
	}


	/// <summary>
	/// ULeaderboardBlueprintLibrary:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class ULeaderboardBlueprintLibrary:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// ULeaderboardFlushCallbackProxy:UObject
	/// Size: 0xA0
	/// Properties: 0
	/// </summary>
	public class ULeaderboardFlushCallbackProxy:UObject
	{
		public override int ObjectSize => 160;
	}


	/// <summary>
	/// ULeaderboardQueryCallbackProxy:UObject
	/// Size: 0xD0
	/// Properties: 0
	/// </summary>
	public class ULeaderboardQueryCallbackProxy:UObject
	{
		public override int ObjectSize => 208;
	}


	/// <summary>
	/// ULogoutCallbackProxy:UBlueprintAsyncActionBase
	/// Size: 0x60
	/// Properties: 0
	/// </summary>
	public class ULogoutCallbackProxy:UBlueprintAsyncActionBase
	{
		public override int ObjectSize => 96;
	}


	/// <summary>
	/// AOnlineBeacon:AActor
	/// Size: 0x3F8
	/// Properties: 3
	/// </summary>
	public class AOnlineBeacon:AActor
	{
		public override int ObjectSize => 1016;
		/// <summary>
		/// Name: BeaconConnectionInitialTimeout
		/// Type: FloatProperty
		/// Offset: 0x3D8
		/// Size: 0x04
		/// </summary>
		public float BeaconConnectionInitialTimeout
		{
			get
			{
				return ReadSingle(0x3D8);
			}
			set
			{
				WriteSingle(0x3D8,value);
			}
		}
		
		/// <summary>
		/// Name: BeaconConnectionTimeout
		/// Type: FloatProperty
		/// Offset: 0x3DC
		/// Size: 0x04
		/// </summary>
		public float BeaconConnectionTimeout
		{
			get
			{
				return ReadSingle(0x3DC);
			}
			set
			{
				WriteSingle(0x3DC,value);
			}
		}
		
		/// <summary>
		/// Name: NetDriver
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UNetDriver NetDriver => ReadUObject<UNetDriver>(0x3E0);
		
	}


	/// <summary>
	/// AOnlineBeaconClient:AOnlineBeacon
	/// Size: 0x460
	/// Properties: 3
	/// </summary>
	public class AOnlineBeaconClient:AOnlineBeacon
	{
		public override int ObjectSize => 1120;
		/// <summary>
		/// Name: BeaconOwner
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public AOnlineBeaconHostObject BeaconOwner => ReadUObject<AOnlineBeaconHostObject>(0x3F8);
		
		/// <summary>
		/// Name: BeaconConnection
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UNetConnection BeaconConnection => ReadUObject<UNetConnection>(0x400);
		
		/// <summary>
		/// Name: ConnectionState
		/// Type: ByteProperty
		/// Offset: 0x408
		/// Size: 0x01
		/// </summary>
		public byte ConnectionState
		{
			get
			{
				return ReadByte(0x408);
			}
			set
			{
				WriteByte(0x408,value);
			}
		}
		
	}


	/// <summary>
	/// UPartyBeaconState:UObject
	/// Size: 0x68
	/// Properties: 8
	/// </summary>
	public class UPartyBeaconState:UObject
	{
		public override int ObjectSize => 104;
		/// <summary>
		/// Name: SessionName
		/// Type: NameProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: NumConsumedReservations
		/// Type: IntProperty
		/// Offset: 0x30
		/// Size: 0x04
		/// </summary>
		public int NumConsumedReservations
		{
			get
			{
				return ReadInt32(0x30);
			}
			set
			{
				WriteInt32(0x30,value);
			}
		}
		
		/// <summary>
		/// Name: MaxReservations
		/// Type: IntProperty
		/// Offset: 0x34
		/// Size: 0x04
		/// </summary>
		public int MaxReservations
		{
			get
			{
				return ReadInt32(0x34);
			}
			set
			{
				WriteInt32(0x34,value);
			}
		}
		
		/// <summary>
		/// Name: NumTeams
		/// Type: IntProperty
		/// Offset: 0x38
		/// Size: 0x04
		/// </summary>
		public int NumTeams
		{
			get
			{
				return ReadInt32(0x38);
			}
			set
			{
				WriteInt32(0x38,value);
			}
		}
		
		/// <summary>
		/// Name: NumPlayersPerTeam
		/// Type: IntProperty
		/// Offset: 0x3C
		/// Size: 0x04
		/// </summary>
		public int NumPlayersPerTeam
		{
			get
			{
				return ReadInt32(0x3C);
			}
			set
			{
				WriteInt32(0x3C,value);
			}
		}
		
		/// <summary>
		/// Name: ReservedHostTeamNum
		/// Type: IntProperty
		/// Offset: 0x40
		/// Size: 0x04
		/// </summary>
		public int ReservedHostTeamNum
		{
			get
			{
				return ReadInt32(0x40);
			}
			set
			{
				WriteInt32(0x40,value);
			}
		}
		
		/// <summary>
		/// Name: ForceTeamNum
		/// Type: IntProperty
		/// Offset: 0x44
		/// Size: 0x04
		/// </summary>
		public int ForceTeamNum
		{
			get
			{
				return ReadInt32(0x44);
			}
			set
			{
				WriteInt32(0x44,value);
			}
		}
		
		/// <summary>
		/// Name: Reservations
		/// Type: TArray<FPartyReservation>
		/// Offset: 0x48
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<FPartyReservation> Reservations => new TArray<FPartyReservation>(BaseAddress+0x48);
		
	}


	/// <summary>
	/// APartyBeaconClient:AOnlineBeaconClient
	/// Size: 0x590
	/// Properties: 5
	/// </summary>
	public class APartyBeaconClient:AOnlineBeaconClient
	{
		public override int ObjectSize => 1424;
		/// <summary>
		/// Name: DestSessionId
		/// Type: StrProperty
		/// Offset: 0x520
		/// Size: 0x10
		/// </summary>
		public FString DestSessionId => new FString(BaseAddress+0x520);
		
		/// <summary>
		/// Name: PendingReservation
		/// Type: StructProperty
		/// Offset: 0x530
		/// Size: 0x28
		/// </summary>
		public FPartyReservation PendingReservation => ReadStruct<FPartyReservation>(0x530);
		
		/// <summary>
		/// Name: RequestType
		/// Type: ByteProperty
		/// Offset: 0x558
		/// Size: 0x01
		/// </summary>
		public byte RequestType
		{
			get
			{
				return ReadByte(0x558);
			}
			set
			{
				WriteByte(0x558,value);
			}
		}
		
		/// <summary>
		/// Name: bPendingReservationSent
		/// Type: BoolProperty
		/// Offset: 0x559
		/// Size: 0x01
		/// </summary>
		public bool bPendingReservationSent
		{
			get
			{
				return ReadBool(0x559);
			}
			set
			{
				WriteBool(0x559,value);
			}
		}
		
		/// <summary>
		/// Name: bCancelReservation
		/// Type: BoolProperty
		/// Offset: 0x55A
		/// Size: 0x01
		/// </summary>
		public bool bCancelReservation
		{
			get
			{
				return ReadBool(0x55A);
			}
			set
			{
				WriteBool(0x55A,value);
			}
		}
		
	}


	/// <summary>
	/// ATestBeaconClient:AOnlineBeaconClient
	/// Size: 0x460
	/// Properties: 0
	/// </summary>
	public class ATestBeaconClient:AOnlineBeaconClient
	{
		public override int ObjectSize => 1120;
	}


	/// <summary>
	/// AOnlineBeaconHost:AOnlineBeacon
	/// Size: 0x4B0
	/// Properties: 2
	/// </summary>
	public class AOnlineBeaconHost:AOnlineBeacon
	{
		public override int ObjectSize => 1200;
		/// <summary>
		/// Name: ListenPort
		/// Type: IntProperty
		/// Offset: 0x3F8
		/// Size: 0x04
		/// </summary>
		public int ListenPort
		{
			get
			{
				return ReadInt32(0x3F8);
			}
			set
			{
				WriteInt32(0x3F8,value);
			}
		}
		
		/// <summary>
		/// Name: ClientActors
		/// Type: TArray<AOnlineBeaconClient>
		/// Offset: 0x400
		/// Size: 0x10
		/// SubElement Size: 0x460
		/// </summary>
		public TArray<AOnlineBeaconClient> ClientActors => new TArray<AOnlineBeaconClient>(BaseAddress+0x400);
		
	}


	/// <summary>
	/// AOnlineBeaconHostObject:AActor
	/// Size: 0x3F8
	/// Properties: 3
	/// </summary>
	public class AOnlineBeaconHostObject:AActor
	{
		public override int ObjectSize => 1016;
		/// <summary>
		/// Name: BeaconTypeName
		/// Type: StrProperty
		/// Offset: 0x3D0
		/// Size: 0x10
		/// </summary>
		public FString BeaconTypeName => new FString(BaseAddress+0x3D0);
		
		/// <summary>
		/// Name: ClientBeaconActorClass
		/// Type: ClassProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: ClientActors
		/// Type: TArray<AOnlineBeaconClient>
		/// Offset: 0x3E8
		/// Size: 0x10
		/// SubElement Size: 0x460
		/// </summary>
		public TArray<AOnlineBeaconClient> ClientActors => new TArray<AOnlineBeaconClient>(BaseAddress+0x3E8);
		
	}


	/// <summary>
	/// APartyBeaconHost:AOnlineBeaconHostObject
	/// Size: 0x550
	/// Properties: 4
	/// </summary>
	public class APartyBeaconHost:AOnlineBeaconHostObject
	{
		public override int ObjectSize => 1360;
		/// <summary>
		/// Name: State
		/// Type: ObjectProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		public UPartyBeaconState State => ReadUObject<UPartyBeaconState>(0x3F8);
		
		/// <summary>
		/// Name: bNoTimeouts
		/// Type: BoolProperty
		/// Offset: 0x540
		/// Size: 0x01
		/// </summary>
		public bool bNoTimeouts
		{
			get
			{
				return ReadBool(0x540);
			}
			set
			{
				WriteBool(0x540,value);
			}
		}
		
		/// <summary>
		/// Name: SessionTimeoutSecs
		/// Type: FloatProperty
		/// Offset: 0x544
		/// Size: 0x04
		/// </summary>
		public float SessionTimeoutSecs
		{
			get
			{
				return ReadSingle(0x544);
			}
			set
			{
				WriteSingle(0x544,value);
			}
		}
		
		/// <summary>
		/// Name: TravelSessionTimeoutSecs
		/// Type: FloatProperty
		/// Offset: 0x548
		/// Size: 0x04
		/// </summary>
		public float TravelSessionTimeoutSecs
		{
			get
			{
				return ReadSingle(0x548);
			}
			set
			{
				WriteSingle(0x548,value);
			}
		}
		
	}


	/// <summary>
	/// ATestBeaconHost:AOnlineBeaconHostObject
	/// Size: 0x3F8
	/// Properties: 0
	/// </summary>
	public class ATestBeaconHost:AOnlineBeaconHostObject
	{
		public override int ObjectSize => 1016;
	}


	/// <summary>
	/// UOnlineBlueprintCallProxyBase:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UOnlineBlueprintCallProxyBase:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UAchievementQueryCallbackProxy:UOnlineBlueprintCallProxyBase
	/// Size: 0x60
	/// Properties: 0
	/// </summary>
	public class UAchievementQueryCallbackProxy:UOnlineBlueprintCallProxyBase
	{
		public override int ObjectSize => 96;
	}


	/// <summary>
	/// UAchievementWriteCallbackProxy:UOnlineBlueprintCallProxyBase
	/// Size: 0x78
	/// Properties: 0
	/// </summary>
	public class UAchievementWriteCallbackProxy:UOnlineBlueprintCallProxyBase
	{
		public override int ObjectSize => 120;
	}


	/// <summary>
	/// UConnectionCallbackProxy:UOnlineBlueprintCallProxyBase
	/// Size: 0xA0
	/// Properties: 0
	/// </summary>
	public class UConnectionCallbackProxy:UOnlineBlueprintCallProxyBase
	{
		public override int ObjectSize => 160;
	}


	/// <summary>
	/// UCreateSessionCallbackProxy:UOnlineBlueprintCallProxyBase
	/// Size: 0xF0
	/// Properties: 0
	/// </summary>
	public class UCreateSessionCallbackProxy:UOnlineBlueprintCallProxyBase
	{
		public override int ObjectSize => 240;
	}


	/// <summary>
	/// UDestroySessionCallbackProxy:UOnlineBlueprintCallProxyBase
	/// Size: 0xA0
	/// Properties: 0
	/// </summary>
	public class UDestroySessionCallbackProxy:UOnlineBlueprintCallProxyBase
	{
		public override int ObjectSize => 160;
	}


	/// <summary>
	/// UEndMatchCallbackProxy:UOnlineBlueprintCallProxyBase
	/// Size: 0x78
	/// Properties: 0
	/// </summary>
	public class UEndMatchCallbackProxy:UOnlineBlueprintCallProxyBase
	{
		public override int ObjectSize => 120;
	}


	/// <summary>
	/// UEndTurnCallbackProxy:UOnlineBlueprintCallProxyBase
	/// Size: 0x70
	/// Properties: 0
	/// </summary>
	public class UEndTurnCallbackProxy:UOnlineBlueprintCallProxyBase
	{
		public override int ObjectSize => 112;
	}


	/// <summary>
	/// UFindSessionsCallbackProxy:UOnlineBlueprintCallProxyBase
	/// Size: 0xC0
	/// Properties: 0
	/// </summary>
	public class UFindSessionsCallbackProxy:UOnlineBlueprintCallProxyBase
	{
		public override int ObjectSize => 192;
	}


	/// <summary>
	/// UFindTurnBasedMatchCallbackProxy:UOnlineBlueprintCallProxyBase
	/// Size: 0x80
	/// Properties: 0
	/// </summary>
	public class UFindTurnBasedMatchCallbackProxy:UOnlineBlueprintCallProxyBase
	{
		public override int ObjectSize => 128;
	}


	/// <summary>
	/// UJoinSessionCallbackProxy:UOnlineBlueprintCallProxyBase
	/// Size: 0x170
	/// Properties: 0
	/// </summary>
	public class UJoinSessionCallbackProxy:UOnlineBlueprintCallProxyBase
	{
		public override int ObjectSize => 368;
	}


	/// <summary>
	/// UQuitMatchCallbackProxy:UOnlineBlueprintCallProxyBase
	/// Size: 0x70
	/// Properties: 0
	/// </summary>
	public class UQuitMatchCallbackProxy:UOnlineBlueprintCallProxyBase
	{
		public override int ObjectSize => 112;
	}


	/// <summary>
	/// UDeveloperSettings:UObject
	/// Size: 0x38
	/// Properties: 0
	/// </summary>
	public class UDeveloperSettings:UObject
	{
		public override int ObjectSize => 56;
	}


	/// <summary>
	/// UOnlinePIESettings:UDeveloperSettings
	/// Size: 0x50
	/// Properties: 2
	/// </summary>
	public class UOnlinePIESettings:UDeveloperSettings
	{
		public override int ObjectSize => 80;
		/// <summary>
		/// Name: bOnlinePIEEnabled
		/// Type: BoolProperty
		/// Offset: 0x38
		/// Size: 0x01
		/// </summary>
		public bool bOnlinePIEEnabled
		{
			get
			{
				return ReadBool(0x38);
			}
			set
			{
				WriteBool(0x38,value);
			}
		}
		
		/// <summary>
		/// Name: Logins
		/// Type: TArray<FPIELoginSettingsInternal>
		/// Offset: 0x40
		/// Size: 0x10
		/// SubElement Size: 0x40
		/// </summary>
		public TArray<FPIELoginSettingsInternal> Logins => new TArray<FPIELoginSettingsInternal>(BaseAddress+0x40);
		
	}


	/// <summary>
	/// UOnlineSession:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UOnlineSession:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UOnlineSessionClient:UOnlineSession
	/// Size: 0x240
	/// Properties: 2
	/// </summary>
	public class UOnlineSessionClient:UOnlineSession
	{
		public override int ObjectSize => 576;
		/// <summary>
		/// Name: bIsFromInvite
		/// Type: BoolProperty
		/// Offset: 0x230
		/// Size: 0x01
		/// </summary>
		public bool bIsFromInvite
		{
			get
			{
				return ReadBool(0x230);
			}
			set
			{
				WriteBool(0x230,value);
			}
		}
		
		/// <summary>
		/// Name: bHandlingDisconnect
		/// Type: BoolProperty
		/// Offset: 0x231
		/// Size: 0x01
		/// </summary>
		public bool bHandlingDisconnect
		{
			get
			{
				return ReadBool(0x231);
			}
			set
			{
				WriteBool(0x231,value);
			}
		}
		
	}


	/// <summary>
	/// UShowLoginUICallbackProxy:UBlueprintAsyncActionBase
	/// Size: 0x58
	/// Properties: 0
	/// </summary>
	public class UShowLoginUICallbackProxy:UBlueprintAsyncActionBase
	{
		public override int ObjectSize => 88;
	}


	/// <summary>
	/// UTurnBasedBlueprintLibrary:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UTurnBasedBlueprintLibrary:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UGameLiveStreamingFunctionLibrary:UBlueprintFunctionLibrary
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UGameLiveStreamingFunctionLibrary:UBlueprintFunctionLibrary
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UQueryLiveStreamsCallbackProxy:UOnlineBlueprintCallProxyBase
	/// Size: 0x48
	/// Properties: 0
	/// </summary>
	public class UQueryLiveStreamsCallbackProxy:UOnlineBlueprintCallProxyBase
	{
		public override int ObjectSize => 72;
	}


	/// <summary>
	/// UModel:UObject
	/// Size: 0x578
	/// Properties: 0
	/// </summary>
	public class UModel:UObject
	{
		public override int ObjectSize => 1400;
	}


	/// <summary>
	/// UEngineBaseTypes:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UEngineBaseTypes:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UDamageType:UObject
	/// Size: 0x40
	/// Properties: 7
	/// </summary>
	public class UDamageType:UObject
	{
		public override int ObjectSize => 64;
		/// <summary>
		/// Name: bCausedByWorld
		/// Type: BoolProperty
		/// Offset: 0x28
		/// Size: 0x01
		/// </summary>
		public bool bCausedByWorld => (ReadByte(0x0028) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bScaleMomentumByMass
		/// Type: BoolProperty
		/// Offset: 0x28
		/// Size: 0x01
		/// </summary>
		public bool bScaleMomentumByMass => (ReadByte(0x0028) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: DamageImpulse
		/// Type: FloatProperty
		/// Offset: 0x2C
		/// Size: 0x04
		/// </summary>
		public float DamageImpulse
		{
			get
			{
				return ReadSingle(0x2C);
			}
			set
			{
				WriteSingle(0x2C,value);
			}
		}
		
		/// <summary>
		/// Name: bRadialDamageVelChange
		/// Type: BoolProperty
		/// Offset: 0x30
		/// Size: 0x01
		/// </summary>
		public bool bRadialDamageVelChange => (ReadByte(0x0030) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: DestructibleImpulse
		/// Type: FloatProperty
		/// Offset: 0x34
		/// Size: 0x04
		/// </summary>
		public float DestructibleImpulse
		{
			get
			{
				return ReadSingle(0x34);
			}
			set
			{
				WriteSingle(0x34,value);
			}
		}
		
		/// <summary>
		/// Name: DestructibleDamageSpreadScale
		/// Type: FloatProperty
		/// Offset: 0x38
		/// Size: 0x04
		/// </summary>
		public float DestructibleDamageSpreadScale
		{
			get
			{
				return ReadSingle(0x38);
			}
			set
			{
				WriteSingle(0x38,value);
			}
		}
		
		/// <summary>
		/// Name: DamageFalloff
		/// Type: FloatProperty
		/// Offset: 0x3C
		/// Size: 0x04
		/// </summary>
		public float DamageFalloff
		{
			get
			{
				return ReadSingle(0x3C);
			}
			set
			{
				WriteSingle(0x3C,value);
			}
		}
		
	}


	/// <summary>
	/// UEngineTypes:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UEngineTypes:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UEdGraphNode:UObject
	/// Size: 0x90
	/// Properties: 16
	/// </summary>
	public class UEdGraphNode:UObject
	{
		public override int ObjectSize => 144;
		/// <summary>
		/// Name: Pins
		/// Type: TArray<UEdGraphPin>
		/// Offset: 0x28
		/// Size: 0x10
		/// SubElement Size: 0x110
		/// </summary>
		public TArray<UEdGraphPin> Pins => new TArray<UEdGraphPin>(BaseAddress+0x28);
		
		/// <summary>
		/// Name: NodePosX
		/// Type: IntProperty
		/// Offset: 0x38
		/// Size: 0x04
		/// </summary>
		public int NodePosX
		{
			get
			{
				return ReadInt32(0x38);
			}
			set
			{
				WriteInt32(0x38,value);
			}
		}
		
		/// <summary>
		/// Name: NodePosY
		/// Type: IntProperty
		/// Offset: 0x3C
		/// Size: 0x04
		/// </summary>
		public int NodePosY
		{
			get
			{
				return ReadInt32(0x3C);
			}
			set
			{
				WriteInt32(0x3C,value);
			}
		}
		
		/// <summary>
		/// Name: NodeWidth
		/// Type: IntProperty
		/// Offset: 0x40
		/// Size: 0x04
		/// </summary>
		public int NodeWidth
		{
			get
			{
				return ReadInt32(0x40);
			}
			set
			{
				WriteInt32(0x40,value);
			}
		}
		
		/// <summary>
		/// Name: NodeHeight
		/// Type: IntProperty
		/// Offset: 0x44
		/// Size: 0x04
		/// </summary>
		public int NodeHeight
		{
			get
			{
				return ReadInt32(0x44);
			}
			set
			{
				WriteInt32(0x44,value);
			}
		}
		
		/// <summary>
		/// Name: bHasCompilerMessage
		/// Type: BoolProperty
		/// Offset: 0x48
		/// Size: 0x01
		/// </summary>
		public bool bHasCompilerMessage => (ReadByte(0x0048) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: NodeComment
		/// Type: StrProperty
		/// Offset: 0x50
		/// Size: 0x10
		/// </summary>
		public FString NodeComment => new FString(BaseAddress+0x50);
		
		/// <summary>
		/// Name: bCommentBubblePinned
		/// Type: BoolProperty
		/// Offset: 0x60
		/// Size: 0x01
		/// </summary>
		public bool bCommentBubblePinned
		{
			get
			{
				return ReadBool(0x60);
			}
			set
			{
				WriteBool(0x60,value);
			}
		}
		
		/// <summary>
		/// Name: bCommentBubbleVisible
		/// Type: BoolProperty
		/// Offset: 0x61
		/// Size: 0x01
		/// </summary>
		public bool bCommentBubbleVisible
		{
			get
			{
				return ReadBool(0x61);
			}
			set
			{
				WriteBool(0x61,value);
			}
		}
		
		/// <summary>
		/// Name: ErrorType
		/// Type: IntProperty
		/// Offset: 0x64
		/// Size: 0x04
		/// </summary>
		public int ErrorType
		{
			get
			{
				return ReadInt32(0x64);
			}
			set
			{
				WriteInt32(0x64,value);
			}
		}
		
		/// <summary>
		/// Name: ErrorMsg
		/// Type: StrProperty
		/// Offset: 0x68
		/// Size: 0x10
		/// </summary>
		public FString ErrorMsg => new FString(BaseAddress+0x68);
		
		/// <summary>
		/// Name: NodeGuid
		/// Type: StructProperty
		/// Offset: 0x78
		/// Size: 0x10
		/// </summary>
		public FGuid NodeGuid => ReadStruct<FGuid>(0x78);
		
		/// <summary>
		/// Name: AdvancedPinDisplay
		/// Type: ByteProperty
		/// Offset: 0x88
		/// Size: 0x01
		/// </summary>
		public byte AdvancedPinDisplay
		{
			get
			{
				return ReadByte(0x88);
			}
			set
			{
				WriteByte(0x88,value);
			}
		}
		
		/// <summary>
		/// Name: EnabledState
		/// Type: ByteProperty
		/// Offset: 0x89
		/// Size: 0x01
		/// </summary>
		public byte EnabledState
		{
			get
			{
				return ReadByte(0x89);
			}
			set
			{
				WriteByte(0x89,value);
			}
		}
		
		/// <summary>
		/// Name: bUserSetEnabledState
		/// Type: BoolProperty
		/// Offset: 0x8A
		/// Size: 0x01
		/// </summary>
		public bool bUserSetEnabledState
		{
			get
			{
				return ReadBool(0x8A);
			}
			set
			{
				WriteBool(0x8A,value);
			}
		}
		
		/// <summary>
		/// Name: bIsNodeEnabled
		/// Type: BoolProperty
		/// Offset: 0x8B
		/// Size: 0x01
		/// </summary>
		public bool bIsNodeEnabled
		{
			get
			{
				return ReadBool(0x8B);
			}
			set
			{
				WriteBool(0x8B,value);
			}
		}
		
	}


	/// <summary>
	/// UEdGraphPin:UObject
	/// Size: 0x110
	/// Properties: 12
	/// </summary>
	public class UEdGraphPin:UObject
	{
		public override int ObjectSize => 272;
		/// <summary>
		/// Name: PinName
		/// Type: StrProperty
		/// Offset: 0x28
		/// Size: 0x10
		/// </summary>
		public FString PinName => new FString(BaseAddress+0x28);
		
		/// <summary>
		/// Name: PinToolTip
		/// Type: StrProperty
		/// Offset: 0x38
		/// Size: 0x10
		/// </summary>
		public FString PinToolTip => new FString(BaseAddress+0x38);
		
		/// <summary>
		/// Name: Direction
		/// Type: ByteProperty
		/// Offset: 0x48
		/// Size: 0x01
		/// </summary>
		public byte Direction
		{
			get
			{
				return ReadByte(0x48);
			}
			set
			{
				WriteByte(0x48,value);
			}
		}
		
		/// <summary>
		/// Name: PinType
		/// Type: StructProperty
		/// Offset: 0x50
		/// Size: 0x50
		/// </summary>
		public FEdGraphPinType PinType => ReadStruct<FEdGraphPinType>(0x50);
		
		/// <summary>
		/// Name: DefaultValue
		/// Type: StrProperty
		/// Offset: 0xA0
		/// Size: 0x10
		/// </summary>
		public FString DefaultValue => new FString(BaseAddress+0xA0);
		
		/// <summary>
		/// Name: AutogeneratedDefaultValue
		/// Type: StrProperty
		/// Offset: 0xB0
		/// Size: 0x10
		/// </summary>
		public FString AutogeneratedDefaultValue => new FString(BaseAddress+0xB0);
		
		/// <summary>
		/// Name: DefaultObject
		/// Type: ObjectProperty
		/// Offset: 0xC0
		/// Size: 0x08
		/// </summary>
		public UObject DefaultObject => ReadUObject<UObject>(0xC0);
		
		/// <summary>
		/// Name: DefaultTextValue
		/// Type: TextProperty
		/// Offset: 0xC8
		/// Size: 0x18
		/// </summary>
		
		/// <summary>
		/// Name: LinkedTo
		/// Type: TArray<UEdGraphPin>
		/// Offset: 0xE0
		/// Size: 0x10
		/// SubElement Size: 0x110
		/// </summary>
		public TArray<UEdGraphPin> LinkedTo => new TArray<UEdGraphPin>(BaseAddress+0xE0);
		
		/// <summary>
		/// Name: SubPins
		/// Type: TArray<UEdGraphPin>
		/// Offset: 0xF0
		/// Size: 0x10
		/// SubElement Size: 0x110
		/// </summary>
		public TArray<UEdGraphPin> SubPins => new TArray<UEdGraphPin>(BaseAddress+0xF0);
		
		/// <summary>
		/// Name: ParentPin
		/// Type: ObjectProperty
		/// Offset: 0x100
		/// Size: 0x08
		/// </summary>
		public UEdGraphPin ParentPin => ReadUObject<UEdGraphPin>(0x100);
		
		/// <summary>
		/// Name: ReferencePassThroughConnection
		/// Type: ObjectProperty
		/// Offset: 0x108
		/// Size: 0x08
		/// </summary>
		public UEdGraphPin ReferencePassThroughConnection => ReadUObject<UEdGraphPin>(0x108);
		
	}


	/// <summary>
	/// UBlueprintCore:UObject
	/// Size: 0x50
	/// Properties: 5
	/// </summary>
	public class UBlueprintCore:UObject
	{
		public override int ObjectSize => 80;
		/// <summary>
		/// Name: SkeletonGeneratedClass
		/// Type: ClassProperty
		/// Offset: 0x28
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: GeneratedClass
		/// Type: ClassProperty
		/// Offset: 0x30
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: bLegacyNeedToPurgeSkelRefs
		/// Type: BoolProperty
		/// Offset: 0x38
		/// Size: 0x01
		/// </summary>
		public bool bLegacyNeedToPurgeSkelRefs
		{
			get
			{
				return ReadBool(0x38);
			}
			set
			{
				WriteBool(0x38,value);
			}
		}
		
		/// <summary>
		/// Name: bLegacyGeneratedClassIsAuthoritative
		/// Type: BoolProperty
		/// Offset: 0x39
		/// Size: 0x01
		/// </summary>
		public bool bLegacyGeneratedClassIsAuthoritative
		{
			get
			{
				return ReadBool(0x39);
			}
			set
			{
				WriteBool(0x39,value);
			}
		}
		
		/// <summary>
		/// Name: BlueprintGuid
		/// Type: StructProperty
		/// Offset: 0x3C
		/// Size: 0x10
		/// </summary>
		public FGuid BlueprintGuid => ReadStruct<FGuid>(0x3C);
		
	}


	/// <summary>
	/// UBlueprint:UBlueprintCore
	/// Size: 0x190
	/// Properties: 11
	/// </summary>
	public class UBlueprint:UBlueprintCore
	{
		public override int ObjectSize => 400;
		/// <summary>
		/// Name: bRecompileOnLoad
		/// Type: BoolProperty
		/// Offset: 0x50
		/// Size: 0x01
		/// </summary>
		public bool bRecompileOnLoad => (ReadByte(0x0050) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: ParentClass
		/// Type: ClassProperty
		/// Offset: 0x58
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: PRIVATE_InnermostPreviousCDO
		/// Type: ObjectProperty
		/// Offset: 0x60
		/// Size: 0x08
		/// </summary>
		public UObject PRIVATE_InnermostPreviousCDO => ReadUObject<UObject>(0x60);
		
		/// <summary>
		/// Name: bHasBeenRegenerated
		/// Type: BoolProperty
		/// Offset: 0x68
		/// Size: 0x01
		/// </summary>
		public bool bHasBeenRegenerated => (ReadByte(0x0068) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bIsRegeneratingOnLoad
		/// Type: BoolProperty
		/// Offset: 0x68
		/// Size: 0x01
		/// </summary>
		public bool bIsRegeneratingOnLoad => (ReadByte(0x0068) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: SimpleConstructionScript
		/// Type: ObjectProperty
		/// Offset: 0x70
		/// Size: 0x08
		/// </summary>
		public USimpleConstructionScript SimpleConstructionScript => ReadUObject<USimpleConstructionScript>(0x70);
		
		/// <summary>
		/// Name: ComponentTemplates
		/// Type: TArray<UActorComponent>
		/// Offset: 0x78
		/// Size: 0x10
		/// SubElement Size: 0xD8
		/// </summary>
		public TArray<UActorComponent> ComponentTemplates => new TArray<UActorComponent>(BaseAddress+0x78);
		
		/// <summary>
		/// Name: Timelines
		/// Type: TArray<UTimelineTemplate>
		/// Offset: 0x88
		/// Size: 0x10
		/// SubElement Size: 0x98
		/// </summary>
		public TArray<UTimelineTemplate> Timelines => new TArray<UTimelineTemplate>(BaseAddress+0x88);
		
		/// <summary>
		/// Name: InheritableComponentHandler
		/// Type: ObjectProperty
		/// Offset: 0x98
		/// Size: 0x08
		/// </summary>
		public UInheritableComponentHandler InheritableComponentHandler => ReadUObject<UInheritableComponentHandler>(0x98);
		
		/// <summary>
		/// Name: BlueprintType
		/// Type: ByteProperty
		/// Offset: 0xA0
		/// Size: 0x01
		/// </summary>
		public byte BlueprintType
		{
			get
			{
				return ReadByte(0xA0);
			}
			set
			{
				WriteByte(0xA0,value);
			}
		}
		
		/// <summary>
		/// Name: BlueprintSystemVersion
		/// Type: IntProperty
		/// Offset: 0xA4
		/// Size: 0x04
		/// </summary>
		public int BlueprintSystemVersion
		{
			get
			{
				return ReadInt32(0xA4);
			}
			set
			{
				WriteInt32(0xA4,value);
			}
		}
		
	}


	/// <summary>
	/// UInterface_AssetUserData:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UInterface_AssetUserData:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// AAmbientSound:AActor
	/// Size: 0x3D8
	/// Properties: 1
	/// </summary>
	public class AAmbientSound:AActor
	{
		public override int ObjectSize => 984;
		/// <summary>
		/// Name: AudioComponent
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UAudioComponent AudioComponent => ReadUObject<UAudioComponent>(0x3D0);
		
	}


	/// <summary>
	/// UPendingNetGame:UObject
	/// Size: 0xC8
	/// Properties: 2
	/// </summary>
	public class UPendingNetGame:UObject
	{
		public override int ObjectSize => 200;
		/// <summary>
		/// Name: NetDriver
		/// Type: ObjectProperty
		/// Offset: 0x30
		/// Size: 0x08
		/// </summary>
		public UNetDriver NetDriver => ReadUObject<UNetDriver>(0x30);
		
		/// <summary>
		/// Name: DemoNetDriver
		/// Type: ObjectProperty
		/// Offset: 0x38
		/// Size: 0x08
		/// </summary>
		public UDemoNetDriver DemoNetDriver => ReadUObject<UDemoNetDriver>(0x38);
		
	}


	/// <summary>
	/// UWorld:UObject
	/// Size: 0x920
	/// Properties: 26
	/// </summary>
	public class UWorld:UObject
	{
		public override int ObjectSize => 2336;
		/// <summary>
		/// Name: PersistentLevel
		/// Type: ObjectProperty
		/// Offset: 0x30
		/// Size: 0x08
		/// </summary>
		public ULevel PersistentLevel => ReadUObject<ULevel>(0x30);
		
		/// <summary>
		/// Name: NetDriver
		/// Type: ObjectProperty
		/// Offset: 0x38
		/// Size: 0x08
		/// </summary>
		public UNetDriver NetDriver => ReadUObject<UNetDriver>(0x38);
		
		/// <summary>
		/// Name: LineBatcher
		/// Type: ObjectProperty
		/// Offset: 0x40
		/// Size: 0x08
		/// </summary>
		public ULineBatchComponent LineBatcher => ReadUObject<ULineBatchComponent>(0x40);
		
		/// <summary>
		/// Name: PersistentLineBatcher
		/// Type: ObjectProperty
		/// Offset: 0x48
		/// Size: 0x08
		/// </summary>
		public ULineBatchComponent PersistentLineBatcher => ReadUObject<ULineBatchComponent>(0x48);
		
		/// <summary>
		/// Name: ForegroundLineBatcher
		/// Type: ObjectProperty
		/// Offset: 0x50
		/// Size: 0x08
		/// </summary>
		public ULineBatchComponent ForegroundLineBatcher => ReadUObject<ULineBatchComponent>(0x50);
		
		/// <summary>
		/// Name: GameState
		/// Type: ObjectProperty
		/// Offset: 0x58
		/// Size: 0x08
		/// </summary>
		public AGameState GameState => ReadUObject<AGameState>(0x58);
		
		/// <summary>
		/// Name: NetworkManager
		/// Type: ObjectProperty
		/// Offset: 0x60
		/// Size: 0x08
		/// </summary>
		public AGameNetworkManager NetworkManager => ReadUObject<AGameNetworkManager>(0x60);
		
		/// <summary>
		/// Name: PhysicsCollisionHandler
		/// Type: ObjectProperty
		/// Offset: 0x68
		/// Size: 0x08
		/// </summary>
		public UPhysicsCollisionHandler PhysicsCollisionHandler => ReadUObject<UPhysicsCollisionHandler>(0x68);
		
		/// <summary>
		/// Name: ExtraReferencedObjects
		/// Type: TArray<UObject>
		/// Offset: 0x70
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<UObject> ExtraReferencedObjects => new TArray<UObject>(BaseAddress+0x70);
		
		/// <summary>
		/// Name: PerModuleDataObjects
		/// Type: TArray<UObject>
		/// Offset: 0x80
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<UObject> PerModuleDataObjects => new TArray<UObject>(BaseAddress+0x80);
		
		/// <summary>
		/// Name: StreamingLevels
		/// Type: TArray<ULevelStreaming>
		/// Offset: 0x90
		/// Size: 0x10
		/// SubElement Size: 0x160
		/// </summary>
		public TArray<ULevelStreaming> StreamingLevels => new TArray<ULevelStreaming>(BaseAddress+0x90);
		
		/// <summary>
		/// Name: StreamingLevelsPrefix
		/// Type: StrProperty
		/// Offset: 0xA0
		/// Size: 0x10
		/// </summary>
		public FString StreamingLevelsPrefix => new FString(BaseAddress+0xA0);
		
		/// <summary>
		/// Name: CurrentLevelPendingVisibility
		/// Type: ObjectProperty
		/// Offset: 0xB0
		/// Size: 0x08
		/// </summary>
		public ULevel CurrentLevelPendingVisibility => ReadUObject<ULevel>(0xB0);
		
		/// <summary>
		/// Name: DemoNetDriver
		/// Type: ObjectProperty
		/// Offset: 0xB8
		/// Size: 0x08
		/// </summary>
		public UDemoNetDriver DemoNetDriver => ReadUObject<UDemoNetDriver>(0xB8);
		
		/// <summary>
		/// Name: MyParticleEventManager
		/// Type: ObjectProperty
		/// Offset: 0xC0
		/// Size: 0x08
		/// </summary>
		public AParticleEventManager MyParticleEventManager => ReadUObject<AParticleEventManager>(0xC0);
		
		/// <summary>
		/// Name: DefaultPhysicsVolume
		/// Type: ObjectProperty
		/// Offset: 0xC8
		/// Size: 0x08
		/// </summary>
		public APhysicsVolume DefaultPhysicsVolume => ReadUObject<APhysicsVolume>(0xC8);
		
		/// <summary>
		/// Name: NavigationSystem
		/// Type: ObjectProperty
		/// Offset: 0xE8
		/// Size: 0x08
		/// </summary>
		public UNavigationSystem NavigationSystem => ReadUObject<UNavigationSystem>(0xE8);
		
		/// <summary>
		/// Name: AuthorityGameMode
		/// Type: ObjectProperty
		/// Offset: 0xF0
		/// Size: 0x08
		/// </summary>
		public AGameMode AuthorityGameMode => ReadUObject<AGameMode>(0xF0);
		
		/// <summary>
		/// Name: AISystem
		/// Type: ObjectProperty
		/// Offset: 0xF8
		/// Size: 0x08
		/// </summary>
		public UAISystemBase AISystem => ReadUObject<UAISystemBase>(0xF8);
		
		/// <summary>
		/// Name: AvoidanceManager
		/// Type: ObjectProperty
		/// Offset: 0x100
		/// Size: 0x08
		/// </summary>
		public UAvoidanceManager AvoidanceManager => ReadUObject<UAvoidanceManager>(0x100);
		
		/// <summary>
		/// Name: Levels
		/// Type: TArray<ULevel>
		/// Offset: 0x108
		/// Size: 0x10
		/// SubElement Size: 0x3D0
		/// </summary>
		public TArray<ULevel> Levels => new TArray<ULevel>(BaseAddress+0x108);
		
		/// <summary>
		/// Name: CurrentLevel
		/// Type: ObjectProperty
		/// Offset: 0x118
		/// Size: 0x08
		/// </summary>
		public ULevel CurrentLevel => ReadUObject<ULevel>(0x118);
		
		/// <summary>
		/// Name: OwningGameInstance
		/// Type: ObjectProperty
		/// Offset: 0x120
		/// Size: 0x08
		/// </summary>
		public UGameInstance OwningGameInstance => ReadUObject<UGameInstance>(0x120);
		
		/// <summary>
		/// Name: ParameterCollectionInstances
		/// Type: TArray<UMaterialParameterCollectionInstance>
		/// Offset: 0x128
		/// Size: 0x10
		/// SubElement Size: 0xE8
		/// </summary>
		public TArray<UMaterialParameterCollectionInstance> ParameterCollectionInstances => new TArray<UMaterialParameterCollectionInstance>(BaseAddress+0x128);
		
		/// <summary>
		/// Name: WorldComposition
		/// Type: ObjectProperty
		/// Offset: 0x8C8
		/// Size: 0x08
		/// </summary>
		public UWorldComposition WorldComposition => ReadUObject<UWorldComposition>(0x8C8);
		
		/// <summary>
		/// Name: bAreConstraintsDirty
		/// Type: BoolProperty
		/// Offset: 0x90E
		/// Size: 0x01
		/// </summary>
		public bool bAreConstraintsDirty => (ReadByte(0x090E) & 0x01) == 0x01;
		
	}


	/// <summary>
	/// ULevel:UObject
	/// Size: 0x3D0
	/// Properties: 16
	/// </summary>
	public class ULevel:UObject
	{
		public override int ObjectSize => 976;
		/// <summary>
		/// Name: OwningWorld
		/// Type: ObjectProperty
		/// Offset: 0xB8
		/// Size: 0x08
		/// </summary>
		public UWorld OwningWorld => ReadUObject<UWorld>(0xB8);
		
		/// <summary>
		/// Name: Model
		/// Type: ObjectProperty
		/// Offset: 0xC0
		/// Size: 0x08
		/// </summary>
		public UModel Model => ReadUObject<UModel>(0xC0);
		
		/// <summary>
		/// Name: ModelComponents
		/// Type: TArray<UModelComponent>
		/// Offset: 0xC8
		/// Size: 0x10
		/// SubElement Size: 0x5E0
		/// </summary>
		public TArray<UModelComponent> ModelComponents => new TArray<UModelComponent>(BaseAddress+0xC8);
		
		/// <summary>
		/// Name: LevelScriptActor
		/// Type: ObjectProperty
		/// Offset: 0xD8
		/// Size: 0x08
		/// </summary>
		public ALevelScriptActor LevelScriptActor => ReadUObject<ALevelScriptActor>(0xD8);
		
		/// <summary>
		/// Name: NavListStart
		/// Type: ObjectProperty
		/// Offset: 0xE0
		/// Size: 0x08
		/// </summary>
		public ANavigationObjectBase NavListStart => ReadUObject<ANavigationObjectBase>(0xE0);
		
		/// <summary>
		/// Name: NavListEnd
		/// Type: ObjectProperty
		/// Offset: 0xE8
		/// Size: 0x08
		/// </summary>
		public ANavigationObjectBase NavListEnd => ReadUObject<ANavigationObjectBase>(0xE8);
		
		/// <summary>
		/// Name: NavDataChunks
		/// Type: TArray<UNavigationDataChunk>
		/// Offset: 0xF0
		/// Size: 0x10
		/// SubElement Size: 0x30
		/// </summary>
		public TArray<UNavigationDataChunk> NavDataChunks => new TArray<UNavigationDataChunk>(BaseAddress+0xF0);
		
		/// <summary>
		/// Name: LightmapTotalSize
		/// Type: FloatProperty
		/// Offset: 0x100
		/// Size: 0x04
		/// </summary>
		public float LightmapTotalSize
		{
			get
			{
				return ReadSingle(0x100);
			}
			set
			{
				WriteSingle(0x100,value);
			}
		}
		
		/// <summary>
		/// Name: ShadowmapTotalSize
		/// Type: FloatProperty
		/// Offset: 0x104
		/// Size: 0x04
		/// </summary>
		public float ShadowmapTotalSize
		{
			get
			{
				return ReadSingle(0x104);
			}
			set
			{
				WriteSingle(0x104,value);
			}
		}
		
		/// <summary>
		/// Name: StaticNavigableGeometry
		/// Type: TArray<FVector>
		/// Offset: 0x108
		/// Size: 0x10
		/// SubElement Size: 0x0C
		/// </summary>
		public TArray<FVector> StaticNavigableGeometry => new TArray<FVector>(BaseAddress+0x108);
		
		/// <summary>
		/// Name: StreamingTextureGuids
		/// Type: TArray<FGuid>
		/// Offset: 0x118
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FGuid> StreamingTextureGuids => new TArray<FGuid>(BaseAddress+0x118);
		
		/// <summary>
		/// Name: bTextureStreamingRotationChanged
		/// Type: BoolProperty
		/// Offset: 0x2A8
		/// Size: 0x01
		/// </summary>
		public bool bTextureStreamingRotationChanged => (ReadByte(0x02A8) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bIsVisible
		/// Type: BoolProperty
		/// Offset: 0x2A8
		/// Size: 0x01
		/// </summary>
		public bool bIsVisible => (ReadByte(0x02A8) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bLocked
		/// Type: BoolProperty
		/// Offset: 0x2A8
		/// Size: 0x01
		/// </summary>
		public bool bLocked => (ReadByte(0x02A8) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: WorldSettings
		/// Type: ObjectProperty
		/// Offset: 0x3A0
		/// Size: 0x08
		/// </summary>
		public AWorldSettings WorldSettings => ReadUObject<AWorldSettings>(0x3A0);
		
		/// <summary>
		/// Name: AssetUserData
		/// Type: TArray<UAssetUserData>
		/// Offset: 0x3A8
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<UAssetUserData> AssetUserData => new TArray<UAssetUserData>(BaseAddress+0x3A8);
		
	}


	/// <summary>
	/// ABrushShape:ABrush
	/// Size: 0x408
	/// Properties: 0
	/// </summary>
	public class ABrushShape:ABrush
	{
		public override int ObjectSize => 1032;
	}


	/// <summary>
	/// AAudioVolume:AVolume
	/// Size: 0x458
	/// Properties: 5
	/// </summary>
	public class AAudioVolume:AVolume
	{
		public override int ObjectSize => 1112;
		/// <summary>
		/// Name: Priority
		/// Type: FloatProperty
		/// Offset: 0x408
		/// Size: 0x04
		/// </summary>
		public float Priority
		{
			get
			{
				return ReadSingle(0x408);
			}
			set
			{
				WriteSingle(0x408,value);
			}
		}
		
		/// <summary>
		/// Name: bEnabled
		/// Type: BoolProperty
		/// Offset: 0x40C
		/// Size: 0x01
		/// </summary>
		public bool bEnabled => (ReadByte(0x040C) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: Settings
		/// Type: StructProperty
		/// Offset: 0x410
		/// Size: 0x18
		/// </summary>
		public FReverbSettings Settings => ReadStruct<FReverbSettings>(0x410);
		
		/// <summary>
		/// Name: AmbientZoneSettings
		/// Type: StructProperty
		/// Offset: 0x428
		/// Size: 0x24
		/// </summary>
		public FInteriorSettings AmbientZoneSettings => ReadStruct<FInteriorSettings>(0x428);
		
		/// <summary>
		/// Name: NextLowerPriorityVolume
		/// Type: ObjectProperty
		/// Offset: 0x450
		/// Size: 0x08
		/// </summary>
		public AAudioVolume NextLowerPriorityVolume => ReadUObject<AAudioVolume>(0x450);
		
	}


	/// <summary>
	/// ABlockingVolume:AVolume
	/// Size: 0x408
	/// Properties: 0
	/// </summary>
	public class ABlockingVolume:AVolume
	{
		public override int ObjectSize => 1032;
	}


	/// <summary>
	/// ACameraBlockingVolume:AVolume
	/// Size: 0x408
	/// Properties: 0
	/// </summary>
	public class ACameraBlockingVolume:AVolume
	{
		public override int ObjectSize => 1032;
	}


	/// <summary>
	/// ACullDistanceVolume:AVolume
	/// Size: 0x420
	/// Properties: 2
	/// </summary>
	public class ACullDistanceVolume:AVolume
	{
		public override int ObjectSize => 1056;
		/// <summary>
		/// Name: CullDistances
		/// Type: TArray<FCullDistanceSizePair>
		/// Offset: 0x408
		/// Size: 0x10
		/// SubElement Size: 0x08
		/// </summary>
		public TArray<FCullDistanceSizePair> CullDistances => new TArray<FCullDistanceSizePair>(BaseAddress+0x408);
		
		/// <summary>
		/// Name: bEnabled
		/// Type: BoolProperty
		/// Offset: 0x418
		/// Size: 0x01
		/// </summary>
		public bool bEnabled => (ReadByte(0x0418) & 0x01) == 0x01;
		
	}


	/// <summary>
	/// AHLODMeshCullingVolume:AVolume
	/// Size: 0x408
	/// Properties: 0
	/// </summary>
	public class AHLODMeshCullingVolume:AVolume
	{
		public override int ObjectSize => 1032;
	}


	/// <summary>
	/// ALevelStreamingVolume:AVolume
	/// Size: 0x420
	/// Properties: 4
	/// </summary>
	public class ALevelStreamingVolume:AVolume
	{
		public override int ObjectSize => 1056;
		/// <summary>
		/// Name: StreamingLevelNames
		/// Type: TArray<FName>
		/// Offset: 0x408
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		public TArray<FName> StreamingLevelNames => new TArray<FName>(BaseAddress+0x408);
		
		/// <summary>
		/// Name: bEditorPreVisOnly
		/// Type: BoolProperty
		/// Offset: 0x418
		/// Size: 0x01
		/// </summary>
		public bool bEditorPreVisOnly => (ReadByte(0x0418) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bDisabled
		/// Type: BoolProperty
		/// Offset: 0x418
		/// Size: 0x01
		/// </summary>
		public bool bDisabled => (ReadByte(0x0418) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: StreamingUsage
		/// Type: ByteProperty
		/// Offset: 0x41C
		/// Size: 0x01
		/// </summary>
		public byte StreamingUsage
		{
			get
			{
				return ReadByte(0x41C);
			}
			set
			{
				WriteByte(0x41C,value);
			}
		}
		
	}


	/// <summary>
	/// ALightmassCharacterIndirectDetailVolume:AVolume
	/// Size: 0x408
	/// Properties: 0
	/// </summary>
	public class ALightmassCharacterIndirectDetailVolume:AVolume
	{
		public override int ObjectSize => 1032;
	}


	/// <summary>
	/// ALightmassImportanceVolume:AVolume
	/// Size: 0x408
	/// Properties: 0
	/// </summary>
	public class ALightmassImportanceVolume:AVolume
	{
		public override int ObjectSize => 1032;
	}


	/// <summary>
	/// ANavMeshBoundsVolume:AVolume
	/// Size: 0x410
	/// Properties: 1
	/// </summary>
	public class ANavMeshBoundsVolume:AVolume
	{
		public override int ObjectSize => 1040;
		/// <summary>
		/// Name: SupportedAgents
		/// Type: StructProperty
		/// Offset: 0x408
		/// Size: 0x04
		/// </summary>
		public FNavAgentSelector SupportedAgents => ReadStruct<FNavAgentSelector>(0x408);
		
	}


	/// <summary>
	/// UNavigationQueryFilter:UObject
	/// Size: 0x48
	/// Properties: 3
	/// </summary>
	public class UNavigationQueryFilter:UObject
	{
		public override int ObjectSize => 72;
		/// <summary>
		/// Name: Areas
		/// Type: TArray<FNavigationFilterArea>
		/// Offset: 0x28
		/// Size: 0x10
		/// SubElement Size: 0x18
		/// </summary>
		public TArray<FNavigationFilterArea> Areas => new TArray<FNavigationFilterArea>(BaseAddress+0x28);
		
		/// <summary>
		/// Name: IncludeFlags
		/// Type: StructProperty
		/// Offset: 0x38
		/// Size: 0x04
		/// </summary>
		public FNavigationFilterFlags IncludeFlags => ReadStruct<FNavigationFilterFlags>(0x38);
		
		/// <summary>
		/// Name: ExcludeFlags
		/// Type: StructProperty
		/// Offset: 0x3C
		/// Size: 0x04
		/// </summary>
		public FNavigationFilterFlags ExcludeFlags => ReadStruct<FNavigationFilterFlags>(0x3C);
		
	}


	/// <summary>
	/// UNavigationTypes:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UNavigationTypes:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UNavRelevantInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UNavRelevantInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// ANavModifierVolume:AVolume
	/// Size: 0x418
	/// Properties: 1
	/// </summary>
	public class ANavModifierVolume:AVolume
	{
		public override int ObjectSize => 1048;
		/// <summary>
		/// Name: AreaClass
		/// Type: ClassProperty
		/// Offset: 0x410
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// APhysicsVolume:AVolume
	/// Size: 0x418
	/// Properties: 5
	/// </summary>
	public class APhysicsVolume:AVolume
	{
		public override int ObjectSize => 1048;
		/// <summary>
		/// Name: TerminalVelocity
		/// Type: FloatProperty
		/// Offset: 0x408
		/// Size: 0x04
		/// </summary>
		public float TerminalVelocity
		{
			get
			{
				return ReadSingle(0x408);
			}
			set
			{
				WriteSingle(0x408,value);
			}
		}
		
		/// <summary>
		/// Name: Priority
		/// Type: IntProperty
		/// Offset: 0x40C
		/// Size: 0x04
		/// </summary>
		public int Priority
		{
			get
			{
				return ReadInt32(0x40C);
			}
			set
			{
				WriteInt32(0x40C,value);
			}
		}
		
		/// <summary>
		/// Name: FluidFriction
		/// Type: FloatProperty
		/// Offset: 0x410
		/// Size: 0x04
		/// </summary>
		public float FluidFriction
		{
			get
			{
				return ReadSingle(0x410);
			}
			set
			{
				WriteSingle(0x410,value);
			}
		}
		
		/// <summary>
		/// Name: bWaterVolume
		/// Type: BoolProperty
		/// Offset: 0x414
		/// Size: 0x01
		/// </summary>
		public bool bWaterVolume => (ReadByte(0x0414) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bPhysicsOnContact
		/// Type: BoolProperty
		/// Offset: 0x414
		/// Size: 0x01
		/// </summary>
		public bool bPhysicsOnContact => (ReadByte(0x0414) & 0x02) == 0x02;
		
	}


	/// <summary>
	/// ADefaultPhysicsVolume:APhysicsVolume
	/// Size: 0x418
	/// Properties: 0
	/// </summary>
	public class ADefaultPhysicsVolume:APhysicsVolume
	{
		public override int ObjectSize => 1048;
	}


	/// <summary>
	/// AKillZVolume:APhysicsVolume
	/// Size: 0x418
	/// Properties: 0
	/// </summary>
	public class AKillZVolume:APhysicsVolume
	{
		public override int ObjectSize => 1048;
	}


	/// <summary>
	/// APainCausingVolume:APhysicsVolume
	/// Size: 0x440
	/// Properties: 7
	/// </summary>
	public class APainCausingVolume:APhysicsVolume
	{
		public override int ObjectSize => 1088;
		/// <summary>
		/// Name: bPainCausing
		/// Type: BoolProperty
		/// Offset: 0x418
		/// Size: 0x01
		/// </summary>
		public bool bPainCausing => (ReadByte(0x0418) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: DamagePerSec
		/// Type: FloatProperty
		/// Offset: 0x41C
		/// Size: 0x04
		/// </summary>
		public float DamagePerSec
		{
			get
			{
				return ReadSingle(0x41C);
			}
			set
			{
				WriteSingle(0x41C,value);
			}
		}
		
		/// <summary>
		/// Name: DamageType
		/// Type: ClassProperty
		/// Offset: 0x420
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: PainInterval
		/// Type: FloatProperty
		/// Offset: 0x428
		/// Size: 0x04
		/// </summary>
		public float PainInterval
		{
			get
			{
				return ReadSingle(0x428);
			}
			set
			{
				WriteSingle(0x428,value);
			}
		}
		
		/// <summary>
		/// Name: bEntryPain
		/// Type: BoolProperty
		/// Offset: 0x42C
		/// Size: 0x01
		/// </summary>
		public bool bEntryPain => (ReadByte(0x042C) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: BACKUP_bPainCausing
		/// Type: BoolProperty
		/// Offset: 0x42C
		/// Size: 0x01
		/// </summary>
		public bool BACKUP_bPainCausing => (ReadByte(0x042C) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: DamageInstigator
		/// Type: ObjectProperty
		/// Offset: 0x430
		/// Size: 0x08
		/// </summary>
		public AController DamageInstigator => ReadUObject<AController>(0x430);
		
	}


	/// <summary>
	/// UBlendableInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UBlendableInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UScene:UObject
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UScene:UObject
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UInterface_PostProcessVolume:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UInterface_PostProcessVolume:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// APostProcessVolume:AVolume
	/// Size: 0x7C0
	/// Properties: 6
	/// </summary>
	public class APostProcessVolume:AVolume
	{
		public override int ObjectSize => 1984;
		/// <summary>
		/// Name: Settings
		/// Type: StructProperty
		/// Offset: 0x410
		/// Size: 0x3A0
		/// </summary>
		public FPostProcessSettings Settings => ReadStruct<FPostProcessSettings>(0x410);
		
		/// <summary>
		/// Name: Priority
		/// Type: FloatProperty
		/// Offset: 0x7B0
		/// Size: 0x04
		/// </summary>
		public float Priority
		{
			get
			{
				return ReadSingle(0x7B0);
			}
			set
			{
				WriteSingle(0x7B0,value);
			}
		}
		
		/// <summary>
		/// Name: BlendRadius
		/// Type: FloatProperty
		/// Offset: 0x7B4
		/// Size: 0x04
		/// </summary>
		public float BlendRadius
		{
			get
			{
				return ReadSingle(0x7B4);
			}
			set
			{
				WriteSingle(0x7B4,value);
			}
		}
		
		/// <summary>
		/// Name: BlendWeight
		/// Type: FloatProperty
		/// Offset: 0x7B8
		/// Size: 0x04
		/// </summary>
		public float BlendWeight
		{
			get
			{
				return ReadSingle(0x7B8);
			}
			set
			{
				WriteSingle(0x7B8,value);
			}
		}
		
		/// <summary>
		/// Name: bEnabled
		/// Type: BoolProperty
		/// Offset: 0x7BC
		/// Size: 0x01
		/// </summary>
		public bool bEnabled => (ReadByte(0x07BC) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bUnbound
		/// Type: BoolProperty
		/// Offset: 0x7BC
		/// Size: 0x01
		/// </summary>
		public bool bUnbound => (ReadByte(0x07BC) & 0x02) == 0x02;
		
	}


	/// <summary>
	/// APrecomputedVisibilityOverrideVolume:AVolume
	/// Size: 0x438
	/// Properties: 3
	/// </summary>
	public class APrecomputedVisibilityOverrideVolume:AVolume
	{
		public override int ObjectSize => 1080;
		/// <summary>
		/// Name: OverrideVisibleActors
		/// Type: TArray<AActor>
		/// Offset: 0x408
		/// Size: 0x10
		/// SubElement Size: 0x3D0
		/// </summary>
		public TArray<AActor> OverrideVisibleActors => new TArray<AActor>(BaseAddress+0x408);
		
		/// <summary>
		/// Name: OverrideInvisibleActors
		/// Type: TArray<AActor>
		/// Offset: 0x418
		/// Size: 0x10
		/// SubElement Size: 0x3D0
		/// </summary>
		public TArray<AActor> OverrideInvisibleActors => new TArray<AActor>(BaseAddress+0x418);
		
		/// <summary>
		/// Name: OverrideInvisibleLevels
		/// Type: TArray<FName>
		/// Offset: 0x428
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		public TArray<FName> OverrideInvisibleLevels => new TArray<FName>(BaseAddress+0x428);
		
	}


	/// <summary>
	/// APrecomputedVisibilityVolume:AVolume
	/// Size: 0x408
	/// Properties: 0
	/// </summary>
	public class APrecomputedVisibilityVolume:AVolume
	{
		public override int ObjectSize => 1032;
	}


	/// <summary>
	/// APreCullTrianglesVolume:AVolume
	/// Size: 0x408
	/// Properties: 0
	/// </summary>
	public class APreCullTrianglesVolume:AVolume
	{
		public override int ObjectSize => 1032;
	}


	/// <summary>
	/// ATriggerVolume:AVolume
	/// Size: 0x408
	/// Properties: 0
	/// </summary>
	public class ATriggerVolume:AVolume
	{
		public override int ObjectSize => 1032;
	}


	/// <summary>
	/// UNavAgentInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UNavAgentInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// UCameraShake:UObject
	/// Size: 0x160
	/// Properties: 18
	/// </summary>
	public class UCameraShake:UObject
	{
		public override int ObjectSize => 352;
		/// <summary>
		/// Name: bSingleInstance
		/// Type: BoolProperty
		/// Offset: 0x28
		/// Size: 0x01
		/// </summary>
		public bool bSingleInstance => (ReadByte(0x0028) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: OscillationDuration
		/// Type: FloatProperty
		/// Offset: 0x2C
		/// Size: 0x04
		/// </summary>
		public float OscillationDuration
		{
			get
			{
				return ReadSingle(0x2C);
			}
			set
			{
				WriteSingle(0x2C,value);
			}
		}
		
		/// <summary>
		/// Name: OscillationBlendInTime
		/// Type: FloatProperty
		/// Offset: 0x30
		/// Size: 0x04
		/// </summary>
		public float OscillationBlendInTime
		{
			get
			{
				return ReadSingle(0x30);
			}
			set
			{
				WriteSingle(0x30,value);
			}
		}
		
		/// <summary>
		/// Name: OscillationBlendOutTime
		/// Type: FloatProperty
		/// Offset: 0x34
		/// Size: 0x04
		/// </summary>
		public float OscillationBlendOutTime
		{
			get
			{
				return ReadSingle(0x34);
			}
			set
			{
				WriteSingle(0x34,value);
			}
		}
		
		/// <summary>
		/// Name: RotOscillation
		/// Type: StructProperty
		/// Offset: 0x38
		/// Size: 0x24
		/// </summary>
		public FROscillator RotOscillation => ReadStruct<FROscillator>(0x38);
		
		/// <summary>
		/// Name: LocOscillation
		/// Type: StructProperty
		/// Offset: 0x5C
		/// Size: 0x24
		/// </summary>
		public FVOscillator LocOscillation => ReadStruct<FVOscillator>(0x5C);
		
		/// <summary>
		/// Name: FOVOscillation
		/// Type: StructProperty
		/// Offset: 0x80
		/// Size: 0x0C
		/// </summary>
		public FFOscillator FOVOscillation => ReadStruct<FFOscillator>(0x80);
		
		/// <summary>
		/// Name: AnimPlayRate
		/// Type: FloatProperty
		/// Offset: 0x8C
		/// Size: 0x04
		/// </summary>
		public float AnimPlayRate
		{
			get
			{
				return ReadSingle(0x8C);
			}
			set
			{
				WriteSingle(0x8C,value);
			}
		}
		
		/// <summary>
		/// Name: AnimScale
		/// Type: FloatProperty
		/// Offset: 0x90
		/// Size: 0x04
		/// </summary>
		public float AnimScale
		{
			get
			{
				return ReadSingle(0x90);
			}
			set
			{
				WriteSingle(0x90,value);
			}
		}
		
		/// <summary>
		/// Name: AnimBlendInTime
		/// Type: FloatProperty
		/// Offset: 0x94
		/// Size: 0x04
		/// </summary>
		public float AnimBlendInTime
		{
			get
			{
				return ReadSingle(0x94);
			}
			set
			{
				WriteSingle(0x94,value);
			}
		}
		
		/// <summary>
		/// Name: AnimBlendOutTime
		/// Type: FloatProperty
		/// Offset: 0x98
		/// Size: 0x04
		/// </summary>
		public float AnimBlendOutTime
		{
			get
			{
				return ReadSingle(0x98);
			}
			set
			{
				WriteSingle(0x98,value);
			}
		}
		
		/// <summary>
		/// Name: RandomAnimSegmentDuration
		/// Type: FloatProperty
		/// Offset: 0x9C
		/// Size: 0x04
		/// </summary>
		public float RandomAnimSegmentDuration
		{
			get
			{
				return ReadSingle(0x9C);
			}
			set
			{
				WriteSingle(0x9C,value);
			}
		}
		
		/// <summary>
		/// Name: Anim
		/// Type: ObjectProperty
		/// Offset: 0xA0
		/// Size: 0x08
		/// </summary>
		public UCameraAnim Anim => ReadUObject<UCameraAnim>(0xA0);
		
		/// <summary>
		/// Name: bRandomAnimSegment
		/// Type: BoolProperty
		/// Offset: 0xA8
		/// Size: 0x01
		/// </summary>
		public bool bRandomAnimSegment => (ReadByte(0x00A8) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: CameraOwner
		/// Type: ObjectProperty
		/// Offset: 0xC0
		/// Size: 0x08
		/// </summary>
		public APlayerCameraManager CameraOwner => ReadUObject<APlayerCameraManager>(0xC0);
		
		/// <summary>
		/// Name: ShakeScale
		/// Type: FloatProperty
		/// Offset: 0x148
		/// Size: 0x04
		/// </summary>
		public float ShakeScale
		{
			get
			{
				return ReadSingle(0x148);
			}
			set
			{
				WriteSingle(0x148,value);
			}
		}
		
		/// <summary>
		/// Name: OscillatorTimeRemaining
		/// Type: FloatProperty
		/// Offset: 0x14C
		/// Size: 0x04
		/// </summary>
		public float OscillatorTimeRemaining
		{
			get
			{
				return ReadSingle(0x14C);
			}
			set
			{
				WriteSingle(0x14C,value);
			}
		}
		
		/// <summary>
		/// Name: AnimInst
		/// Type: ObjectProperty
		/// Offset: 0x150
		/// Size: 0x08
		/// </summary>
		public UCameraAnimInst AnimInst => ReadUObject<UCameraAnimInst>(0x150);
		
	}


	/// <summary>
	/// UInputComponent:UActorComponent
	/// Size: 0x150
	/// Properties: 0
	/// </summary>
	public class UInputComponent:UActorComponent
	{
		public override int ObjectSize => 336;
	}


	/// <summary>
	/// UCurveBase:UObject
	/// Size: 0x30
	/// Properties: 0
	/// </summary>
	public class UCurveBase:UObject
	{
		public override int ObjectSize => 48;
	}


	/// <summary>
	/// UCurveFloat:UCurveBase
	/// Size: 0xB0
	/// Properties: 2
	/// </summary>
	public class UCurveFloat:UCurveBase
	{
		public override int ObjectSize => 176;
		/// <summary>
		/// Name: FloatCurve
		/// Type: StructProperty
		/// Offset: 0x30
		/// Size: 0x78
		/// </summary>
		public FRichCurve FloatCurve => ReadStruct<FRichCurve>(0x30);
		
		/// <summary>
		/// Name: bIsEventCurve
		/// Type: BoolProperty
		/// Offset: 0xA8
		/// Size: 0x01
		/// </summary>
		public bool bIsEventCurve
		{
			get
			{
				return ReadBool(0xA8);
			}
			set
			{
				WriteBool(0xA8,value);
			}
		}
		
	}


	/// <summary>
	/// UForceFeedbackEffect:UObject
	/// Size: 0x40
	/// Properties: 2
	/// </summary>
	public class UForceFeedbackEffect:UObject
	{
		public override int ObjectSize => 64;
		/// <summary>
		/// Name: ChannelDetails
		/// Type: TArray<FForceFeedbackChannelDetails>
		/// Offset: 0x28
		/// Size: 0x10
		/// SubElement Size: 0x88
		/// </summary>
		public TArray<FForceFeedbackChannelDetails> ChannelDetails => new TArray<FForceFeedbackChannelDetails>(BaseAddress+0x28);
		
		/// <summary>
		/// Name: Duration
		/// Type: FloatProperty
		/// Offset: 0x38
		/// Size: 0x04
		/// </summary>
		public float Duration
		{
			get
			{
				return ReadSingle(0x38);
			}
			set
			{
				WriteSingle(0x38,value);
			}
		}
		
	}


	/// <summary>
	/// ADebugCameraController:APlayerController
	/// Size: 0x710
	/// Properties: 3
	/// </summary>
	public class ADebugCameraController:APlayerController
	{
		public override int ObjectSize => 1808;
		/// <summary>
		/// Name: bShowSelectedInfo
		/// Type: BoolProperty
		/// Offset: 0x6C8
		/// Size: 0x01
		/// </summary>
		public bool bShowSelectedInfo => (ReadByte(0x06C8) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bIsFrozenRendering
		/// Type: BoolProperty
		/// Offset: 0x6C8
		/// Size: 0x01
		/// </summary>
		public bool bIsFrozenRendering => (ReadByte(0x06C8) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: DrawFrustum
		/// Type: ObjectProperty
		/// Offset: 0x6D0
		/// Size: 0x08
		/// </summary>
		public UDrawFrustumComponent DrawFrustum => ReadUObject<UDrawFrustumComponent>(0x6D0);
		
	}


	/// <summary>
	/// ADecalActor:AActor
	/// Size: 0x3D8
	/// Properties: 1
	/// </summary>
	public class ADecalActor:AActor
	{
		public override int ObjectSize => 984;
		/// <summary>
		/// Name: Decal
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UDecalComponent Decal => ReadUObject<UDecalComponent>(0x3D0);
		
	}


	/// <summary>
	/// ADestructibleActor:AActor
	/// Size: 0x3F0
	/// Properties: 2
	/// </summary>
	public class ADestructibleActor:AActor
	{
		public override int ObjectSize => 1008;
		/// <summary>
		/// Name: DestructibleComponent
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UDestructibleComponent DestructibleComponent => ReadUObject<UDestructibleComponent>(0x3D0);
		
		/// <summary>
		/// Name: bAffectNavigation
		/// Type: BoolProperty
		/// Offset: 0x3D8
		/// Size: 0x01
		/// </summary>
		public bool bAffectNavigation => (ReadByte(0x03D8) & 0x01) == 0x01;
		
	}


	/// <summary>
	/// ADocumentationActor:AActor
	/// Size: 0x3D8
	/// Properties: 0
	/// </summary>
	public class ADocumentationActor:AActor
	{
		public override int ObjectSize => 984;
	}


	/// <summary>
	/// AEmitter:AActor
	/// Size: 0x420
	/// Properties: 4
	/// </summary>
	public class AEmitter:AActor
	{
		public override int ObjectSize => 1056;
		/// <summary>
		/// Name: ParticleSystemComponent
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UParticleSystemComponent ParticleSystemComponent => ReadUObject<UParticleSystemComponent>(0x3D0);
		
		/// <summary>
		/// Name: bDestroyOnSystemFinish
		/// Type: BoolProperty
		/// Offset: 0x3D8
		/// Size: 0x01
		/// </summary>
		public bool bDestroyOnSystemFinish => (ReadByte(0x03D8) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bPostUpdateTickGroup
		/// Type: BoolProperty
		/// Offset: 0x3D8
		/// Size: 0x01
		/// </summary>
		public bool bPostUpdateTickGroup => (ReadByte(0x03D8) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bCurrentlyActive
		/// Type: BoolProperty
		/// Offset: 0x3D8
		/// Size: 0x01
		/// </summary>
		public bool bCurrentlyActive => (ReadByte(0x03D8) & 0x04) == 0x04;
		
	}


	/// <summary>
	/// AEmitterCameraLensEffectBase:AEmitter
	/// Size: 0x490
	/// Properties: 8
	/// </summary>
	public class AEmitterCameraLensEffectBase:AEmitter
	{
		public override int ObjectSize => 1168;
		/// <summary>
		/// Name: PS_CameraEffect
		/// Type: ObjectProperty
		/// Offset: 0x420
		/// Size: 0x08
		/// </summary>
		public UParticleSystem PS_CameraEffect => ReadUObject<UParticleSystem>(0x420);
		
		/// <summary>
		/// Name: PS_CameraEffectNonExtremeContent
		/// Type: ObjectProperty
		/// Offset: 0x428
		/// Size: 0x08
		/// </summary>
		public UParticleSystem PS_CameraEffectNonExtremeContent => ReadUObject<UParticleSystem>(0x428);
		
		/// <summary>
		/// Name: BaseCamera
		/// Type: ObjectProperty
		/// Offset: 0x430
		/// Size: 0x08
		/// </summary>
		public APlayerCameraManager BaseCamera => ReadUObject<APlayerCameraManager>(0x430);
		
		/// <summary>
		/// Name: RelativeTransform
		/// Type: StructProperty
		/// Offset: 0x440
		/// Size: 0x30
		/// </summary>
		public FTransform RelativeTransform => ReadStruct<FTransform>(0x440);
		
		/// <summary>
		/// Name: BaseFOV
		/// Type: FloatProperty
		/// Offset: 0x470
		/// Size: 0x04
		/// </summary>
		public float BaseFOV
		{
			get
			{
				return ReadSingle(0x470);
			}
			set
			{
				WriteSingle(0x470,value);
			}
		}
		
		/// <summary>
		/// Name: bAllowMultipleInstances
		/// Type: BoolProperty
		/// Offset: 0x474
		/// Size: 0x01
		/// </summary>
		public bool bAllowMultipleInstances => (ReadByte(0x0474) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: EmittersToTreatAsSame
		/// Type: TArray<>
		/// Offset: 0x478
		/// Size: 0x10
		/// SubElement Size: 0x00
		/// </summary>
		
		/// <summary>
		/// Name: DistFromCamera
		/// Type: FloatProperty
		/// Offset: 0x488
		/// Size: 0x04
		/// </summary>
		public float DistFromCamera
		{
			get
			{
				return ReadSingle(0x488);
			}
			set
			{
				WriteSingle(0x488,value);
			}
		}
		
	}


	/// <summary>
	/// ADebugCameraHUD:AHUD
	/// Size: 0x4D0
	/// Properties: 0
	/// </summary>
	public class ADebugCameraHUD:AHUD
	{
		public override int ObjectSize => 1232;
	}


	/// <summary>
	/// AAtmosphericFog:AInfo
	/// Size: 0x3D8
	/// Properties: 1
	/// </summary>
	public class AAtmosphericFog:AInfo
	{
		public override int ObjectSize => 984;
		/// <summary>
		/// Name: AtmosphericFogComponent
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UAtmosphericFogComponent AtmosphericFogComponent => ReadUObject<UAtmosphericFogComponent>(0x3D0);
		
	}


	/// <summary>
	/// AExponentialHeightFog:AInfo
	/// Size: 0x3E0
	/// Properties: 2
	/// </summary>
	public class AExponentialHeightFog:AInfo
	{
		public override int ObjectSize => 992;
		/// <summary>
		/// Name: Component
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UExponentialHeightFogComponent Component => ReadUObject<UExponentialHeightFogComponent>(0x3D0);
		
		/// <summary>
		/// Name: bEnabled
		/// Type: BoolProperty
		/// Offset: 0x3D8
		/// Size: 0x01
		/// </summary>
		public bool bEnabled => (ReadByte(0x03D8) & 0x01) == 0x01;
		
	}


	/// <summary>
	/// ANavigationObjectBase:AActor
	/// Size: 0x3F8
	/// Properties: 4
	/// </summary>
	public class ANavigationObjectBase:AActor
	{
		public override int ObjectSize => 1016;
		/// <summary>
		/// Name: CapsuleComponent
		/// Type: ObjectProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent CapsuleComponent => ReadUObject<UCapsuleComponent>(0x3D8);
		
		/// <summary>
		/// Name: GoodSprite
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UBillboardComponent GoodSprite => ReadUObject<UBillboardComponent>(0x3E0);
		
		/// <summary>
		/// Name: BadSprite
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UBillboardComponent BadSprite => ReadUObject<UBillboardComponent>(0x3E8);
		
		/// <summary>
		/// Name: bIsPIEPlayerStart
		/// Type: BoolProperty
		/// Offset: 0x3F0
		/// Size: 0x01
		/// </summary>
		public bool bIsPIEPlayerStart => (ReadByte(0x03F0) & 0x01) == 0x01;
		
	}


	/// <summary>
	/// APlayerStart:ANavigationObjectBase
	/// Size: 0x400
	/// Properties: 1
	/// </summary>
	public class APlayerStart:ANavigationObjectBase
	{
		public override int ObjectSize => 1024;
		/// <summary>
		/// Name: PlayerStartTag
		/// Type: NameProperty
		/// Offset: 0x3F8
		/// Size: 0x08
		/// </summary>
		
	}


	/// <summary>
	/// AGameNetworkManager:AInfo
	/// Size: 0x448
	/// Properties: 31
	/// </summary>
	public class AGameNetworkManager:AInfo
	{
		public override int ObjectSize => 1096;
		/// <summary>
		/// Name: AdjustedNetSpeed
		/// Type: IntProperty
		/// Offset: 0x3D0
		/// Size: 0x04
		/// </summary>
		public int AdjustedNetSpeed
		{
			get
			{
				return ReadInt32(0x3D0);
			}
			set
			{
				WriteInt32(0x3D0,value);
			}
		}
		
		/// <summary>
		/// Name: LastNetSpeedUpdateTime
		/// Type: FloatProperty
		/// Offset: 0x3D4
		/// Size: 0x04
		/// </summary>
		public float LastNetSpeedUpdateTime
		{
			get
			{
				return ReadSingle(0x3D4);
			}
			set
			{
				WriteSingle(0x3D4,value);
			}
		}
		
		/// <summary>
		/// Name: TotalNetBandwidth
		/// Type: IntProperty
		/// Offset: 0x3D8
		/// Size: 0x04
		/// </summary>
		public int TotalNetBandwidth
		{
			get
			{
				return ReadInt32(0x3D8);
			}
			set
			{
				WriteInt32(0x3D8,value);
			}
		}
		
		/// <summary>
		/// Name: MinDynamicBandwidth
		/// Type: IntProperty
		/// Offset: 0x3DC
		/// Size: 0x04
		/// </summary>
		public int MinDynamicBandwidth
		{
			get
			{
				return ReadInt32(0x3DC);
			}
			set
			{
				WriteInt32(0x3DC,value);
			}
		}
		
		/// <summary>
		/// Name: MaxDynamicBandwidth
		/// Type: IntProperty
		/// Offset: 0x3E0
		/// Size: 0x04
		/// </summary>
		public int MaxDynamicBandwidth
		{
			get
			{
				return ReadInt32(0x3E0);
			}
			set
			{
				WriteInt32(0x3E0,value);
			}
		}
		
		/// <summary>
		/// Name: bIsStandbyCheckingEnabled
		/// Type: BoolProperty
		/// Offset: 0x3E4
		/// Size: 0x01
		/// </summary>
		public bool bIsStandbyCheckingEnabled => (ReadByte(0x03E4) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bHasStandbyCheatTriggered
		/// Type: BoolProperty
		/// Offset: 0x3E4
		/// Size: 0x01
		/// </summary>
		public bool bHasStandbyCheatTriggered => (ReadByte(0x03E4) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: StandbyRxCheatTime
		/// Type: FloatProperty
		/// Offset: 0x3E8
		/// Size: 0x04
		/// </summary>
		public float StandbyRxCheatTime
		{
			get
			{
				return ReadSingle(0x3E8);
			}
			set
			{
				WriteSingle(0x3E8,value);
			}
		}
		
		/// <summary>
		/// Name: StandbyTxCheatTime
		/// Type: FloatProperty
		/// Offset: 0x3EC
		/// Size: 0x04
		/// </summary>
		public float StandbyTxCheatTime
		{
			get
			{
				return ReadSingle(0x3EC);
			}
			set
			{
				WriteSingle(0x3EC,value);
			}
		}
		
		/// <summary>
		/// Name: BadPingThreshold
		/// Type: IntProperty
		/// Offset: 0x3F0
		/// Size: 0x04
		/// </summary>
		public int BadPingThreshold
		{
			get
			{
				return ReadInt32(0x3F0);
			}
			set
			{
				WriteInt32(0x3F0,value);
			}
		}
		
		/// <summary>
		/// Name: PercentMissingForRxStandby
		/// Type: FloatProperty
		/// Offset: 0x3F4
		/// Size: 0x04
		/// </summary>
		public float PercentMissingForRxStandby
		{
			get
			{
				return ReadSingle(0x3F4);
			}
			set
			{
				WriteSingle(0x3F4,value);
			}
		}
		
		/// <summary>
		/// Name: PercentMissingForTxStandby
		/// Type: FloatProperty
		/// Offset: 0x3F8
		/// Size: 0x04
		/// </summary>
		public float PercentMissingForTxStandby
		{
			get
			{
				return ReadSingle(0x3F8);
			}
			set
			{
				WriteSingle(0x3F8,value);
			}
		}
		
		/// <summary>
		/// Name: PercentForBadPing
		/// Type: FloatProperty
		/// Offset: 0x3FC
		/// Size: 0x04
		/// </summary>
		public float PercentForBadPing
		{
			get
			{
				return ReadSingle(0x3FC);
			}
			set
			{
				WriteSingle(0x3FC,value);
			}
		}
		
		/// <summary>
		/// Name: JoinInProgressStandbyWaitTime
		/// Type: FloatProperty
		/// Offset: 0x400
		/// Size: 0x04
		/// </summary>
		public float JoinInProgressStandbyWaitTime
		{
			get
			{
				return ReadSingle(0x400);
			}
			set
			{
				WriteSingle(0x400,value);
			}
		}
		
		/// <summary>
		/// Name: MoveRepSize
		/// Type: FloatProperty
		/// Offset: 0x404
		/// Size: 0x04
		/// </summary>
		public float MoveRepSize
		{
			get
			{
				return ReadSingle(0x404);
			}
			set
			{
				WriteSingle(0x404,value);
			}
		}
		
		/// <summary>
		/// Name: MAXPOSITIONERRORSQUARED
		/// Type: FloatProperty
		/// Offset: 0x408
		/// Size: 0x04
		/// </summary>
		public float MAXPOSITIONERRORSQUARED
		{
			get
			{
				return ReadSingle(0x408);
			}
			set
			{
				WriteSingle(0x408,value);
			}
		}
		
		/// <summary>
		/// Name: MAXLENIENTPOSITIONERRORSQUARED
		/// Type: FloatProperty
		/// Offset: 0x40C
		/// Size: 0x04
		/// </summary>
		public float MAXLENIENTPOSITIONERRORSQUARED
		{
			get
			{
				return ReadSingle(0x40C);
			}
			set
			{
				WriteSingle(0x40C,value);
			}
		}
		
		/// <summary>
		/// Name: MAXNEARZEROVELOCITYSQUARED
		/// Type: FloatProperty
		/// Offset: 0x410
		/// Size: 0x04
		/// </summary>
		public float MAXNEARZEROVELOCITYSQUARED
		{
			get
			{
				return ReadSingle(0x410);
			}
			set
			{
				WriteSingle(0x410,value);
			}
		}
		
		/// <summary>
		/// Name: CLIENTADJUSTUPDATECOST
		/// Type: FloatProperty
		/// Offset: 0x414
		/// Size: 0x04
		/// </summary>
		public float CLIENTADJUSTUPDATECOST
		{
			get
			{
				return ReadSingle(0x414);
			}
			set
			{
				WriteSingle(0x414,value);
			}
		}
		
		/// <summary>
		/// Name: MAXCLIENTUPDATEINTERVAL
		/// Type: FloatProperty
		/// Offset: 0x418
		/// Size: 0x04
		/// </summary>
		public float MAXCLIENTUPDATEINTERVAL
		{
			get
			{
				return ReadSingle(0x418);
			}
			set
			{
				WriteSingle(0x418,value);
			}
		}
		
		/// <summary>
		/// Name: MaxMoveDeltaTime
		/// Type: FloatProperty
		/// Offset: 0x41C
		/// Size: 0x04
		/// </summary>
		public float MaxMoveDeltaTime
		{
			get
			{
				return ReadSingle(0x41C);
			}
			set
			{
				WriteSingle(0x41C,value);
			}
		}
		
		/// <summary>
		/// Name: ClientAuthorativePosition
		/// Type: BoolProperty
		/// Offset: 0x420
		/// Size: 0x01
		/// </summary>
		public bool ClientAuthorativePosition
		{
			get
			{
				return ReadBool(0x420);
			}
			set
			{
				WriteBool(0x420,value);
			}
		}
		
		/// <summary>
		/// Name: ClientErrorUpdateRateLimit
		/// Type: FloatProperty
		/// Offset: 0x424
		/// Size: 0x04
		/// </summary>
		public float ClientErrorUpdateRateLimit
		{
			get
			{
				return ReadSingle(0x424);
			}
			set
			{
				WriteSingle(0x424,value);
			}
		}
		
		/// <summary>
		/// Name: bMovementTimeDiscrepancyDetection
		/// Type: BoolProperty
		/// Offset: 0x428
		/// Size: 0x01
		/// </summary>
		public bool bMovementTimeDiscrepancyDetection
		{
			get
			{
				return ReadBool(0x428);
			}
			set
			{
				WriteBool(0x428,value);
			}
		}
		
		/// <summary>
		/// Name: bMovementTimeDiscrepancyResolution
		/// Type: BoolProperty
		/// Offset: 0x429
		/// Size: 0x01
		/// </summary>
		public bool bMovementTimeDiscrepancyResolution
		{
			get
			{
				return ReadBool(0x429);
			}
			set
			{
				WriteBool(0x429,value);
			}
		}
		
		/// <summary>
		/// Name: MovementTimeDiscrepancyMaxTimeMargin
		/// Type: FloatProperty
		/// Offset: 0x42C
		/// Size: 0x04
		/// </summary>
		public float MovementTimeDiscrepancyMaxTimeMargin
		{
			get
			{
				return ReadSingle(0x42C);
			}
			set
			{
				WriteSingle(0x42C,value);
			}
		}
		
		/// <summary>
		/// Name: MovementTimeDiscrepancyMinTimeMargin
		/// Type: FloatProperty
		/// Offset: 0x430
		/// Size: 0x04
		/// </summary>
		public float MovementTimeDiscrepancyMinTimeMargin
		{
			get
			{
				return ReadSingle(0x430);
			}
			set
			{
				WriteSingle(0x430,value);
			}
		}
		
		/// <summary>
		/// Name: MovementTimeDiscrepancyResolutionRate
		/// Type: FloatProperty
		/// Offset: 0x434
		/// Size: 0x04
		/// </summary>
		public float MovementTimeDiscrepancyResolutionRate
		{
			get
			{
				return ReadSingle(0x434);
			}
			set
			{
				WriteSingle(0x434,value);
			}
		}
		
		/// <summary>
		/// Name: MovementTimeDiscrepancyDriftAllowance
		/// Type: FloatProperty
		/// Offset: 0x438
		/// Size: 0x04
		/// </summary>
		public float MovementTimeDiscrepancyDriftAllowance
		{
			get
			{
				return ReadSingle(0x438);
			}
			set
			{
				WriteSingle(0x438,value);
			}
		}
		
		/// <summary>
		/// Name: bMovementTimeDiscrepancyForceCorrectionsDuringResolution
		/// Type: BoolProperty
		/// Offset: 0x43C
		/// Size: 0x01
		/// </summary>
		public bool bMovementTimeDiscrepancyForceCorrectionsDuringResolution
		{
			get
			{
				return ReadBool(0x43C);
			}
			set
			{
				WriteBool(0x43C,value);
			}
		}
		
		/// <summary>
		/// Name: bUseDistanceBasedRelevancy
		/// Type: BoolProperty
		/// Offset: 0x43D
		/// Size: 0x01
		/// </summary>
		public bool bUseDistanceBasedRelevancy
		{
			get
			{
				return ReadBool(0x43D);
			}
			set
			{
				WriteBool(0x43D,value);
			}
		}
		
	}


	/// <summary>
	/// ASkyLight:AInfo
	/// Size: 0x3E0
	/// Properties: 2
	/// </summary>
	public class ASkyLight:AInfo
	{
		public override int ObjectSize => 992;
		/// <summary>
		/// Name: LightComponent
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public USkyLightComponent LightComponent => ReadUObject<USkyLightComponent>(0x3D0);
		
		/// <summary>
		/// Name: bEnabled
		/// Type: BoolProperty
		/// Offset: 0x3D8
		/// Size: 0x01
		/// </summary>
		public bool bEnabled => (ReadByte(0x03D8) & 0x01) == 0x01;
		
	}


	/// <summary>
	/// AWindDirectionalSource:AInfo
	/// Size: 0x3D8
	/// Properties: 1
	/// </summary>
	public class AWindDirectionalSource:AInfo
	{
		public override int ObjectSize => 984;
		/// <summary>
		/// Name: Component
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UWindDirectionalSourceComponent Component => ReadUObject<UWindDirectionalSourceComponent>(0x3D0);
		
	}


	/// <summary>
	/// ALevelBounds:AActor
	/// Size: 0x3D8
	/// Properties: 1
	/// </summary>
	public class ALevelBounds:AActor
	{
		public override int ObjectSize => 984;
		/// <summary>
		/// Name: bAutoUpdateBounds
		/// Type: BoolProperty
		/// Offset: 0x3D0
		/// Size: 0x01
		/// </summary>
		public bool bAutoUpdateBounds
		{
			get
			{
				return ReadBool(0x3D0);
			}
			set
			{
				WriteBool(0x3D0,value);
			}
		}
		
	}


	/// <summary>
	/// ULightComponentBase:USceneComponent
	/// Size: 0x240
	/// Properties: 11
	/// </summary>
	public class ULightComponentBase:USceneComponent
	{
		public override int ObjectSize => 576;
		/// <summary>
		/// Name: LightGuid
		/// Type: StructProperty
		/// Offset: 0x218
		/// Size: 0x10
		/// </summary>
		public FGuid LightGuid => ReadStruct<FGuid>(0x218);
		
		/// <summary>
		/// Name: Brightness
		/// Type: FloatProperty
		/// Offset: 0x228
		/// Size: 0x04
		/// </summary>
		public float Brightness
		{
			get
			{
				return ReadSingle(0x228);
			}
			set
			{
				WriteSingle(0x228,value);
			}
		}
		
		/// <summary>
		/// Name: Intensity
		/// Type: FloatProperty
		/// Offset: 0x22C
		/// Size: 0x04
		/// </summary>
		public float Intensity
		{
			get
			{
				return ReadSingle(0x22C);
			}
			set
			{
				WriteSingle(0x22C,value);
			}
		}
		
		/// <summary>
		/// Name: LightColor
		/// Type: StructProperty
		/// Offset: 0x230
		/// Size: 0x04
		/// </summary>
		public FColor LightColor => ReadStruct<FColor>(0x230);
		
		/// <summary>
		/// Name: bAffectsWorld
		/// Type: BoolProperty
		/// Offset: 0x234
		/// Size: 0x01
		/// </summary>
		public bool bAffectsWorld => (ReadByte(0x0234) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: CastShadows
		/// Type: BoolProperty
		/// Offset: 0x234
		/// Size: 0x01
		/// </summary>
		public bool CastShadows => (ReadByte(0x0234) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: CastStaticShadows
		/// Type: BoolProperty
		/// Offset: 0x234
		/// Size: 0x01
		/// </summary>
		public bool CastStaticShadows => (ReadByte(0x0234) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: CastDynamicShadows
		/// Type: BoolProperty
		/// Offset: 0x234
		/// Size: 0x01
		/// </summary>
		public bool CastDynamicShadows => (ReadByte(0x0234) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bAffectTranslucentLighting
		/// Type: BoolProperty
		/// Offset: 0x234
		/// Size: 0x01
		/// </summary>
		public bool bAffectTranslucentLighting => (ReadByte(0x0234) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bPrecomputedLightingIsValid
		/// Type: BoolProperty
		/// Offset: 0x234
		/// Size: 0x01
		/// </summary>
		public bool bPrecomputedLightingIsValid => (ReadByte(0x0234) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: IndirectLightingIntensity
		/// Type: FloatProperty
		/// Offset: 0x238
		/// Size: 0x04
		/// </summary>
		public float IndirectLightingIntensity
		{
			get
			{
				return ReadSingle(0x238);
			}
			set
			{
				WriteSingle(0x238,value);
			}
		}
		
	}


	/// <summary>
	/// ULightComponent:ULightComponentBase
	/// Size: 0x3A0
	/// Properties: 24
	/// </summary>
	public class ULightComponent:ULightComponentBase
	{
		public override int ObjectSize => 928;
		/// <summary>
		/// Name: Temperature
		/// Type: FloatProperty
		/// Offset: 0x240
		/// Size: 0x04
		/// </summary>
		public float Temperature
		{
			get
			{
				return ReadSingle(0x240);
			}
			set
			{
				WriteSingle(0x240,value);
			}
		}
		
		/// <summary>
		/// Name: bUseTemperature
		/// Type: BoolProperty
		/// Offset: 0x244
		/// Size: 0x01
		/// </summary>
		public bool bUseTemperature => (ReadByte(0x0244) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: ShadowMapChannel
		/// Type: IntProperty
		/// Offset: 0x248
		/// Size: 0x04
		/// </summary>
		public int ShadowMapChannel
		{
			get
			{
				return ReadInt32(0x248);
			}
			set
			{
				WriteInt32(0x248,value);
			}
		}
		
		/// <summary>
		/// Name: MinRoughness
		/// Type: FloatProperty
		/// Offset: 0x250
		/// Size: 0x04
		/// </summary>
		public float MinRoughness
		{
			get
			{
				return ReadSingle(0x250);
			}
			set
			{
				WriteSingle(0x250,value);
			}
		}
		
		/// <summary>
		/// Name: ShadowBias
		/// Type: FloatProperty
		/// Offset: 0x254
		/// Size: 0x04
		/// </summary>
		public float ShadowBias
		{
			get
			{
				return ReadSingle(0x254);
			}
			set
			{
				WriteSingle(0x254,value);
			}
		}
		
		/// <summary>
		/// Name: ShadowSharpen
		/// Type: FloatProperty
		/// Offset: 0x258
		/// Size: 0x04
		/// </summary>
		public float ShadowSharpen
		{
			get
			{
				return ReadSingle(0x258);
			}
			set
			{
				WriteSingle(0x258,value);
			}
		}
		
		/// <summary>
		/// Name: InverseSquaredFalloff
		/// Type: BoolProperty
		/// Offset: 0x25C
		/// Size: 0x01
		/// </summary>
		public bool InverseSquaredFalloff => (ReadByte(0x025C) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: CastTranslucentShadows
		/// Type: BoolProperty
		/// Offset: 0x25C
		/// Size: 0x01
		/// </summary>
		public bool CastTranslucentShadows => (ReadByte(0x025C) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bCastShadowsFromCinematicObjectsOnly
		/// Type: BoolProperty
		/// Offset: 0x25C
		/// Size: 0x01
		/// </summary>
		public bool bCastShadowsFromCinematicObjectsOnly => (ReadByte(0x025C) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bAffectDynamicIndirectLighting
		/// Type: BoolProperty
		/// Offset: 0x25C
		/// Size: 0x01
		/// </summary>
		public bool bAffectDynamicIndirectLighting => (ReadByte(0x025C) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: LightingChannels
		/// Type: StructProperty
		/// Offset: 0x260
		/// Size: 0x03
		/// </summary>
		public FLightingChannels LightingChannels => ReadStruct<FLightingChannels>(0x260);
		
		/// <summary>
		/// Name: LightFunctionMaterial
		/// Type: ObjectProperty
		/// Offset: 0x268
		/// Size: 0x08
		/// </summary>
		public UMaterialInterface LightFunctionMaterial => ReadUObject<UMaterialInterface>(0x268);
		
		/// <summary>
		/// Name: LightFunctionScale
		/// Type: StructProperty
		/// Offset: 0x270
		/// Size: 0x0C
		/// </summary>
		public FVector LightFunctionScale => ReadStruct<FVector>(0x270);
		
		/// <summary>
		/// Name: IESTexture
		/// Type: ObjectProperty
		/// Offset: 0x280
		/// Size: 0x08
		/// </summary>
		public UTextureLightProfile IESTexture => ReadUObject<UTextureLightProfile>(0x280);
		
		/// <summary>
		/// Name: bUseIESBrightness
		/// Type: BoolProperty
		/// Offset: 0x288
		/// Size: 0x01
		/// </summary>
		public bool bUseIESBrightness => (ReadByte(0x0288) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: IESBrightnessScale
		/// Type: FloatProperty
		/// Offset: 0x28C
		/// Size: 0x04
		/// </summary>
		public float IESBrightnessScale
		{
			get
			{
				return ReadSingle(0x28C);
			}
			set
			{
				WriteSingle(0x28C,value);
			}
		}
		
		/// <summary>
		/// Name: LightFunctionFadeDistance
		/// Type: FloatProperty
		/// Offset: 0x290
		/// Size: 0x04
		/// </summary>
		public float LightFunctionFadeDistance
		{
			get
			{
				return ReadSingle(0x290);
			}
			set
			{
				WriteSingle(0x290,value);
			}
		}
		
		/// <summary>
		/// Name: DisabledBrightness
		/// Type: FloatProperty
		/// Offset: 0x294
		/// Size: 0x04
		/// </summary>
		public float DisabledBrightness
		{
			get
			{
				return ReadSingle(0x294);
			}
			set
			{
				WriteSingle(0x294,value);
			}
		}
		
		/// <summary>
		/// Name: bEnableLightShaftBloom
		/// Type: BoolProperty
		/// Offset: 0x298
		/// Size: 0x01
		/// </summary>
		public bool bEnableLightShaftBloom => (ReadByte(0x0298) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: BloomScale
		/// Type: FloatProperty
		/// Offset: 0x29C
		/// Size: 0x04
		/// </summary>
		public float BloomScale
		{
			get
			{
				return ReadSingle(0x29C);
			}
			set
			{
				WriteSingle(0x29C,value);
			}
		}
		
		/// <summary>
		/// Name: BloomThreshold
		/// Type: FloatProperty
		/// Offset: 0x2A0
		/// Size: 0x04
		/// </summary>
		public float BloomThreshold
		{
			get
			{
				return ReadSingle(0x2A0);
			}
			set
			{
				WriteSingle(0x2A0,value);
			}
		}
		
		/// <summary>
		/// Name: BloomTint
		/// Type: StructProperty
		/// Offset: 0x2A4
		/// Size: 0x04
		/// </summary>
		public FColor BloomTint => ReadStruct<FColor>(0x2A4);
		
		/// <summary>
		/// Name: bUseRayTracedDistanceFieldShadows
		/// Type: BoolProperty
		/// Offset: 0x2A8
		/// Size: 0x01
		/// </summary>
		public bool bUseRayTracedDistanceFieldShadows
		{
			get
			{
				return ReadBool(0x2A8);
			}
			set
			{
				WriteBool(0x2A8,value);
			}
		}
		
		/// <summary>
		/// Name: RayStartOffsetDepthScale
		/// Type: FloatProperty
		/// Offset: 0x2AC
		/// Size: 0x04
		/// </summary>
		public float RayStartOffsetDepthScale
		{
			get
			{
				return ReadSingle(0x2AC);
			}
			set
			{
				WriteSingle(0x2AC,value);
			}
		}
		
	}


	/// <summary>
	/// ALight:AActor
	/// Size: 0x3E0
	/// Properties: 2
	/// </summary>
	public class ALight:AActor
	{
		public override int ObjectSize => 992;
		/// <summary>
		/// Name: LightComponent
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public ULightComponent LightComponent => ReadUObject<ULightComponent>(0x3D0);
		
		/// <summary>
		/// Name: bEnabled
		/// Type: BoolProperty
		/// Offset: 0x3D8
		/// Size: 0x01
		/// </summary>
		public bool bEnabled => (ReadByte(0x03D8) & 0x01) == 0x01;
		
	}


	/// <summary>
	/// ADirectionalLight:ALight
	/// Size: 0x3E0
	/// Properties: 0
	/// </summary>
	public class ADirectionalLight:ALight
	{
		public override int ObjectSize => 992;
	}


	/// <summary>
	/// APointLight:ALight
	/// Size: 0x3E8
	/// Properties: 1
	/// </summary>
	public class APointLight:ALight
	{
		public override int ObjectSize => 1000;
		/// <summary>
		/// Name: PointLightComponent
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UPointLightComponent PointLightComponent => ReadUObject<UPointLightComponent>(0x3E0);
		
	}


	/// <summary>
	/// ASpotLight:ALight
	/// Size: 0x3E8
	/// Properties: 1
	/// </summary>
	public class ASpotLight:ALight
	{
		public override int ObjectSize => 1000;
		/// <summary>
		/// Name: SpotLightComponent
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public USpotLightComponent SpotLightComponent => ReadUObject<USpotLightComponent>(0x3E0);
		
	}


	/// <summary>
	/// AGeneratedMeshAreaLight:ASpotLight
	/// Size: 0x3E8
	/// Properties: 0
	/// </summary>
	public class AGeneratedMeshAreaLight:ASpotLight
	{
		public override int ObjectSize => 1000;
	}


	/// <summary>
	/// ALightmassPortal:AActor
	/// Size: 0x3D8
	/// Properties: 1
	/// </summary>
	public class ALightmassPortal:AActor
	{
		public override int ObjectSize => 984;
		/// <summary>
		/// Name: PortalComponent
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public ULightmassPortalComponent PortalComponent => ReadUObject<ULightmassPortalComponent>(0x3D0);
		
	}


	/// <summary>
	/// ALODActor:AActor
	/// Size: 0x400
	/// Properties: 5
	/// </summary>
	public class ALODActor:AActor
	{
		public override int ObjectSize => 1024;
		/// <summary>
		/// Name: StaticMeshComponent
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UStaticMeshComponent StaticMeshComponent => ReadUObject<UStaticMeshComponent>(0x3D0);
		
		/// <summary>
		/// Name: SubActors
		/// Type: TArray<AActor>
		/// Offset: 0x3D8
		/// Size: 0x10
		/// SubElement Size: 0x3D0
		/// </summary>
		public TArray<AActor> SubActors => new TArray<AActor>(BaseAddress+0x3D8);
		
		/// <summary>
		/// Name: LODDrawDistance
		/// Type: FloatProperty
		/// Offset: 0x3E8
		/// Size: 0x04
		/// </summary>
		public float LODDrawDistance
		{
			get
			{
				return ReadSingle(0x3E8);
			}
			set
			{
				WriteSingle(0x3E8,value);
			}
		}
		
		/// <summary>
		/// Name: LODlevel
		/// Type: IntProperty
		/// Offset: 0x3EC
		/// Size: 0x04
		/// </summary>
		public int LODlevel
		{
			get
			{
				return ReadInt32(0x3EC);
			}
			set
			{
				WriteInt32(0x3EC,value);
			}
		}
		
		/// <summary>
		/// Name: SubObjects
		/// Type: TArray<UObject>
		/// Offset: 0x3F0
		/// Size: 0x10
		/// SubElement Size: 0x28
		/// </summary>
		public TArray<UObject> SubObjects => new TArray<UObject>(BaseAddress+0x3F0);
		
	}


	/// <summary>
	/// AMaterialInstanceActor:AActor
	/// Size: 0x3E0
	/// Properties: 1
	/// </summary>
	public class AMaterialInstanceActor:AActor
	{
		public override int ObjectSize => 992;
		/// <summary>
		/// Name: TargetActors
		/// Type: TArray<AActor>
		/// Offset: 0x3D0
		/// Size: 0x10
		/// SubElement Size: 0x3D0
		/// </summary>
		public TArray<AActor> TargetActors => new TArray<AActor>(BaseAddress+0x3D0);
		
	}


	/// <summary>
	/// AMatineeActor:AActor
	/// Size: 0x478
	/// Properties: 29
	/// </summary>
	public class AMatineeActor:AActor
	{
		public override int ObjectSize => 1144;
		/// <summary>
		/// Name: MatineeData
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UInterpData MatineeData => ReadUObject<UInterpData>(0x3D0);
		
		/// <summary>
		/// Name: MatineeControllerName
		/// Type: NameProperty
		/// Offset: 0x3D8
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: PlayRate
		/// Type: FloatProperty
		/// Offset: 0x3E0
		/// Size: 0x04
		/// </summary>
		public float PlayRate
		{
			get
			{
				return ReadSingle(0x3E0);
			}
			set
			{
				WriteSingle(0x3E0,value);
			}
		}
		
		/// <summary>
		/// Name: bPlayOnLevelLoad
		/// Type: BoolProperty
		/// Offset: 0x3E4
		/// Size: 0x01
		/// </summary>
		public bool bPlayOnLevelLoad => (ReadByte(0x03E4) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bForceStartPos
		/// Type: BoolProperty
		/// Offset: 0x3E4
		/// Size: 0x01
		/// </summary>
		public bool bForceStartPos => (ReadByte(0x03E4) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: ForceStartPosition
		/// Type: FloatProperty
		/// Offset: 0x3E8
		/// Size: 0x04
		/// </summary>
		public float ForceStartPosition
		{
			get
			{
				return ReadSingle(0x3E8);
			}
			set
			{
				WriteSingle(0x3E8,value);
			}
		}
		
		/// <summary>
		/// Name: bLooping
		/// Type: BoolProperty
		/// Offset: 0x3EC
		/// Size: 0x01
		/// </summary>
		public bool bLooping => (ReadByte(0x03EC) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bRewindOnPlay
		/// Type: BoolProperty
		/// Offset: 0x3EC
		/// Size: 0x01
		/// </summary>
		public bool bRewindOnPlay => (ReadByte(0x03EC) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bNoResetOnRewind
		/// Type: BoolProperty
		/// Offset: 0x3EC
		/// Size: 0x01
		/// </summary>
		public bool bNoResetOnRewind => (ReadByte(0x03EC) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bRewindIfAlreadyPlaying
		/// Type: BoolProperty
		/// Offset: 0x3EC
		/// Size: 0x01
		/// </summary>
		public bool bRewindIfAlreadyPlaying => (ReadByte(0x03EC) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bDisableRadioFilter
		/// Type: BoolProperty
		/// Offset: 0x3EC
		/// Size: 0x01
		/// </summary>
		public bool bDisableRadioFilter => (ReadByte(0x03EC) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bClientSideOnly
		/// Type: BoolProperty
		/// Offset: 0x3EC
		/// Size: 0x01
		/// </summary>
		public bool bClientSideOnly => (ReadByte(0x03EC) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: bSkipUpdateIfNotVisible
		/// Type: BoolProperty
		/// Offset: 0x3EC
		/// Size: 0x01
		/// </summary>
		public bool bSkipUpdateIfNotVisible => (ReadByte(0x03EC) & 0x40) == 0x40;
		
		/// <summary>
		/// Name: bIsSkippable
		/// Type: BoolProperty
		/// Offset: 0x3EC
		/// Size: 0x01
		/// </summary>
		public bool bIsSkippable => (ReadByte(0x03EC) & 0x80) == 0x80;
		
		/// <summary>
		/// Name: PreferredSplitScreenNum
		/// Type: IntProperty
		/// Offset: 0x3F0
		/// Size: 0x04
		/// </summary>
		public int PreferredSplitScreenNum
		{
			get
			{
				return ReadInt32(0x3F0);
			}
			set
			{
				WriteInt32(0x3F0,value);
			}
		}
		
		/// <summary>
		/// Name: bDisableMovementInput
		/// Type: BoolProperty
		/// Offset: 0x3F4
		/// Size: 0x01
		/// </summary>
		public bool bDisableMovementInput => (ReadByte(0x03F4) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bDisableLookAtInput
		/// Type: BoolProperty
		/// Offset: 0x3F4
		/// Size: 0x01
		/// </summary>
		public bool bDisableLookAtInput => (ReadByte(0x03F4) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bHidePlayer
		/// Type: BoolProperty
		/// Offset: 0x3F4
		/// Size: 0x01
		/// </summary>
		public bool bHidePlayer => (ReadByte(0x03F4) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bHideHud
		/// Type: BoolProperty
		/// Offset: 0x3F4
		/// Size: 0x01
		/// </summary>
		public bool bHideHud => (ReadByte(0x03F4) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: GroupActorInfos
		/// Type: TArray<FInterpGroupActorInfo>
		/// Offset: 0x3F8
		/// Size: 0x10
		/// SubElement Size: 0x18
		/// </summary>
		public TArray<FInterpGroupActorInfo> GroupActorInfos => new TArray<FInterpGroupActorInfo>(BaseAddress+0x3F8);
		
		/// <summary>
		/// Name: bShouldShowGore
		/// Type: BoolProperty
		/// Offset: 0x408
		/// Size: 0x01
		/// </summary>
		public bool bShouldShowGore => (ReadByte(0x0408) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: GroupInst
		/// Type: TArray<UInterpGroupInst>
		/// Offset: 0x410
		/// Size: 0x10
		/// SubElement Size: 0x48
		/// </summary>
		public TArray<UInterpGroupInst> GroupInst => new TArray<UInterpGroupInst>(BaseAddress+0x410);
		
		/// <summary>
		/// Name: CameraCuts
		/// Type: TArray<FCameraCutInfo>
		/// Offset: 0x420
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FCameraCutInfo> CameraCuts => new TArray<FCameraCutInfo>(BaseAddress+0x420);
		
		/// <summary>
		/// Name: bIsPlaying
		/// Type: BoolProperty
		/// Offset: 0x430
		/// Size: 0x01
		/// </summary>
		public bool bIsPlaying => (ReadByte(0x0430) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bReversePlayback
		/// Type: BoolProperty
		/// Offset: 0x430
		/// Size: 0x01
		/// </summary>
		public bool bReversePlayback => (ReadByte(0x0430) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bPaused
		/// Type: BoolProperty
		/// Offset: 0x430
		/// Size: 0x01
		/// </summary>
		public bool bPaused => (ReadByte(0x0430) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bPendingStop
		/// Type: BoolProperty
		/// Offset: 0x430
		/// Size: 0x01
		/// </summary>
		public bool bPendingStop => (ReadByte(0x0430) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: InterpPosition
		/// Type: FloatProperty
		/// Offset: 0x434
		/// Size: 0x04
		/// </summary>
		public float InterpPosition
		{
			get
			{
				return ReadSingle(0x434);
			}
			set
			{
				WriteSingle(0x434,value);
			}
		}
		
		/// <summary>
		/// Name: ReplicationForceIsPlaying
		/// Type: ByteProperty
		/// Offset: 0x43C
		/// Size: 0x01
		/// </summary>
		public byte ReplicationForceIsPlaying
		{
			get
			{
				return ReadByte(0x43C);
			}
			set
			{
				WriteByte(0x43C,value);
			}
		}
		
	}


	/// <summary>
	/// AMatineeActorCameraAnim:AMatineeActor
	/// Size: 0x480
	/// Properties: 1
	/// </summary>
	public class AMatineeActorCameraAnim:AMatineeActor
	{
		public override int ObjectSize => 1152;
		/// <summary>
		/// Name: CameraAnim
		/// Type: ObjectProperty
		/// Offset: 0x478
		/// Size: 0x08
		/// </summary>
		public UCameraAnim CameraAnim => ReadUObject<UCameraAnim>(0x478);
		
	}


	/// <summary>
	/// ANavigationData:AActor
	/// Size: 0x570
	/// Properties: 11
	/// </summary>
	public class ANavigationData:AActor
	{
		public override int ObjectSize => 1392;
		/// <summary>
		/// Name: RenderingComp
		/// Type: ObjectProperty
		/// Offset: 0x3D0
		/// Size: 0x08
		/// </summary>
		public UPrimitiveComponent RenderingComp => ReadUObject<UPrimitiveComponent>(0x3D0);
		
		/// <summary>
		/// Name: NavDataConfig
		/// Type: StructProperty
		/// Offset: 0x3D8
		/// Size: 0x50
		/// </summary>
		public FNavDataConfig NavDataConfig => ReadStruct<FNavDataConfig>(0x3D8);
		
		/// <summary>
		/// Name: bEnableDrawing
		/// Type: BoolProperty
		/// Offset: 0x428
		/// Size: 0x01
		/// </summary>
		public bool bEnableDrawing => (ReadByte(0x0428) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bForceRebuildOnLoad
		/// Type: BoolProperty
		/// Offset: 0x428
		/// Size: 0x01
		/// </summary>
		public bool bForceRebuildOnLoad => (ReadByte(0x0428) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bCanBeMainNavData
		/// Type: BoolProperty
		/// Offset: 0x428
		/// Size: 0x01
		/// </summary>
		public bool bCanBeMainNavData => (ReadByte(0x0428) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bCanSpawnOnRebuild
		/// Type: BoolProperty
		/// Offset: 0x428
		/// Size: 0x01
		/// </summary>
		public bool bCanSpawnOnRebuild => (ReadByte(0x0428) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bRebuildAtRuntime
		/// Type: BoolProperty
		/// Offset: 0x428
		/// Size: 0x01
		/// </summary>
		public bool bRebuildAtRuntime => (ReadByte(0x0428) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: RuntimeGeneration
		/// Type: ByteProperty
		/// Offset: 0x42C
		/// Size: 0x01
		/// </summary>
		public byte RuntimeGeneration
		{
			get
			{
				return ReadByte(0x42C);
			}
			set
			{
				WriteByte(0x42C,value);
			}
		}
		
		/// <summary>
		/// Name: ObservedPathsTickInterval
		/// Type: FloatProperty
		/// Offset: 0x430
		/// Size: 0x04
		/// </summary>
		public float ObservedPathsTickInterval
		{
			get
			{
				return ReadSingle(0x430);
			}
			set
			{
				WriteSingle(0x430,value);
			}
		}
		
		/// <summary>
		/// Name: DataVersion
		/// Type: UInt32Property
		/// Offset: 0x434
		/// Size: 0x04
		/// </summary>
		
		/// <summary>
		/// Name: SupportedAreas
		/// Type: TArray<FSupportedAreaData>
		/// Offset: 0x508
		/// Size: 0x10
		/// SubElement Size: 0x20
		/// </summary>
		public TArray<FSupportedAreaData> SupportedAreas => new TArray<FSupportedAreaData>(BaseAddress+0x508);
		
	}


	/// <summary>
	/// AAbstractNavData:ANavigationData
	/// Size: 0x570
	/// Properties: 0
	/// </summary>
	public class AAbstractNavData:ANavigationData
	{
		public override int ObjectSize => 1392;
	}


	/// <summary>
	/// ANavigationGraph:ANavigationData
	/// Size: 0x570
	/// Properties: 0
	/// </summary>
	public class ANavigationGraph:ANavigationData
	{
		public override int ObjectSize => 1392;
	}


	/// <summary>
	/// ARecastNavMesh:ANavigationData
	/// Size: 0x680
	/// Properties: 52
	/// </summary>
	public class ARecastNavMesh:ANavigationData
	{
		public override int ObjectSize => 1664;
		/// <summary>
		/// Name: bDrawTriangleEdges
		/// Type: BoolProperty
		/// Offset: 0x570
		/// Size: 0x01
		/// </summary>
		public bool bDrawTriangleEdges => (ReadByte(0x0570) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bDrawPolyEdges
		/// Type: BoolProperty
		/// Offset: 0x570
		/// Size: 0x01
		/// </summary>
		public bool bDrawPolyEdges => (ReadByte(0x0570) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bDrawFilledPolys
		/// Type: BoolProperty
		/// Offset: 0x570
		/// Size: 0x01
		/// </summary>
		public bool bDrawFilledPolys => (ReadByte(0x0570) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bDrawNavMeshEdges
		/// Type: BoolProperty
		/// Offset: 0x570
		/// Size: 0x01
		/// </summary>
		public bool bDrawNavMeshEdges => (ReadByte(0x0570) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bDrawTileBounds
		/// Type: BoolProperty
		/// Offset: 0x570
		/// Size: 0x01
		/// </summary>
		public bool bDrawTileBounds => (ReadByte(0x0570) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bDrawPathCollidingGeometry
		/// Type: BoolProperty
		/// Offset: 0x570
		/// Size: 0x01
		/// </summary>
		public bool bDrawPathCollidingGeometry => (ReadByte(0x0570) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: bDrawTileLabels
		/// Type: BoolProperty
		/// Offset: 0x570
		/// Size: 0x01
		/// </summary>
		public bool bDrawTileLabels => (ReadByte(0x0570) & 0x40) == 0x40;
		
		/// <summary>
		/// Name: bDrawPolygonLabels
		/// Type: BoolProperty
		/// Offset: 0x570
		/// Size: 0x01
		/// </summary>
		public bool bDrawPolygonLabels => (ReadByte(0x0570) & 0x80) == 0x80;
		
		/// <summary>
		/// Name: bDrawDefaultPolygonCost
		/// Type: BoolProperty
		/// Offset: 0x571
		/// Size: 0x01
		/// </summary>
		public bool bDrawDefaultPolygonCost => (ReadByte(0x0571) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bDrawLabelsOnPathNodes
		/// Type: BoolProperty
		/// Offset: 0x571
		/// Size: 0x01
		/// </summary>
		public bool bDrawLabelsOnPathNodes => (ReadByte(0x0571) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bDrawNavLinks
		/// Type: BoolProperty
		/// Offset: 0x571
		/// Size: 0x01
		/// </summary>
		public bool bDrawNavLinks => (ReadByte(0x0571) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bDrawFailedNavLinks
		/// Type: BoolProperty
		/// Offset: 0x571
		/// Size: 0x01
		/// </summary>
		public bool bDrawFailedNavLinks => (ReadByte(0x0571) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bDrawClusters
		/// Type: BoolProperty
		/// Offset: 0x571
		/// Size: 0x01
		/// </summary>
		public bool bDrawClusters => (ReadByte(0x0571) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bDrawOctree
		/// Type: BoolProperty
		/// Offset: 0x571
		/// Size: 0x01
		/// </summary>
		public bool bDrawOctree => (ReadByte(0x0571) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: bDistinctlyDrawTilesBeingBuilt
		/// Type: BoolProperty
		/// Offset: 0x571
		/// Size: 0x01
		/// </summary>
		public bool bDistinctlyDrawTilesBeingBuilt => (ReadByte(0x0571) & 0x40) == 0x40;
		
		/// <summary>
		/// Name: bDrawNavMesh
		/// Type: BoolProperty
		/// Offset: 0x571
		/// Size: 0x01
		/// </summary>
		public bool bDrawNavMesh => (ReadByte(0x0571) & 0x80) == 0x80;
		
		/// <summary>
		/// Name: DrawOffset
		/// Type: FloatProperty
		/// Offset: 0x574
		/// Size: 0x04
		/// </summary>
		public float DrawOffset
		{
			get
			{
				return ReadSingle(0x574);
			}
			set
			{
				WriteSingle(0x574,value);
			}
		}
		
		/// <summary>
		/// Name: bFixedTilePoolSize
		/// Type: BoolProperty
		/// Offset: 0x578
		/// Size: 0x01
		/// </summary>
		public bool bFixedTilePoolSize => (ReadByte(0x0578) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: TilePoolSize
		/// Type: IntProperty
		/// Offset: 0x57C
		/// Size: 0x04
		/// </summary>
		public int TilePoolSize
		{
			get
			{
				return ReadInt32(0x57C);
			}
			set
			{
				WriteInt32(0x57C,value);
			}
		}
		
		/// <summary>
		/// Name: TileSizeUU
		/// Type: FloatProperty
		/// Offset: 0x580
		/// Size: 0x04
		/// </summary>
		public float TileSizeUU
		{
			get
			{
				return ReadSingle(0x580);
			}
			set
			{
				WriteSingle(0x580,value);
			}
		}
		
		/// <summary>
		/// Name: CellSize
		/// Type: FloatProperty
		/// Offset: 0x584
		/// Size: 0x04
		/// </summary>
		public float CellSize
		{
			get
			{
				return ReadSingle(0x584);
			}
			set
			{
				WriteSingle(0x584,value);
			}
		}
		
		/// <summary>
		/// Name: CellHeight
		/// Type: FloatProperty
		/// Offset: 0x588
		/// Size: 0x04
		/// </summary>
		public float CellHeight
		{
			get
			{
				return ReadSingle(0x588);
			}
			set
			{
				WriteSingle(0x588,value);
			}
		}
		
		/// <summary>
		/// Name: AgentRadius
		/// Type: FloatProperty
		/// Offset: 0x58C
		/// Size: 0x04
		/// </summary>
		public float AgentRadius
		{
			get
			{
				return ReadSingle(0x58C);
			}
			set
			{
				WriteSingle(0x58C,value);
			}
		}
		
		/// <summary>
		/// Name: AgentHeight
		/// Type: FloatProperty
		/// Offset: 0x590
		/// Size: 0x04
		/// </summary>
		public float AgentHeight
		{
			get
			{
				return ReadSingle(0x590);
			}
			set
			{
				WriteSingle(0x590,value);
			}
		}
		
		/// <summary>
		/// Name: AgentMaxHeight
		/// Type: FloatProperty
		/// Offset: 0x594
		/// Size: 0x04
		/// </summary>
		public float AgentMaxHeight
		{
			get
			{
				return ReadSingle(0x594);
			}
			set
			{
				WriteSingle(0x594,value);
			}
		}
		
		/// <summary>
		/// Name: AgentMaxSlope
		/// Type: FloatProperty
		/// Offset: 0x598
		/// Size: 0x04
		/// </summary>
		public float AgentMaxSlope
		{
			get
			{
				return ReadSingle(0x598);
			}
			set
			{
				WriteSingle(0x598,value);
			}
		}
		
		/// <summary>
		/// Name: AgentMaxStepHeight
		/// Type: FloatProperty
		/// Offset: 0x59C
		/// Size: 0x04
		/// </summary>
		public float AgentMaxStepHeight
		{
			get
			{
				return ReadSingle(0x59C);
			}
			set
			{
				WriteSingle(0x59C,value);
			}
		}
		
		/// <summary>
		/// Name: MinRegionArea
		/// Type: FloatProperty
		/// Offset: 0x5A0
		/// Size: 0x04
		/// </summary>
		public float MinRegionArea
		{
			get
			{
				return ReadSingle(0x5A0);
			}
			set
			{
				WriteSingle(0x5A0,value);
			}
		}
		
		/// <summary>
		/// Name: MergeRegionSize
		/// Type: FloatProperty
		/// Offset: 0x5A4
		/// Size: 0x04
		/// </summary>
		public float MergeRegionSize
		{
			get
			{
				return ReadSingle(0x5A4);
			}
			set
			{
				WriteSingle(0x5A4,value);
			}
		}
		
		/// <summary>
		/// Name: MaxSimplificationError
		/// Type: FloatProperty
		/// Offset: 0x5A8
		/// Size: 0x04
		/// </summary>
		public float MaxSimplificationError
		{
			get
			{
				return ReadSingle(0x5A8);
			}
			set
			{
				WriteSingle(0x5A8,value);
			}
		}
		
		/// <summary>
		/// Name: MaxSimultaneousTileGenerationJobsCount
		/// Type: IntProperty
		/// Offset: 0x5AC
		/// Size: 0x04
		/// </summary>
		public int MaxSimultaneousTileGenerationJobsCount
		{
			get
			{
				return ReadInt32(0x5AC);
			}
			set
			{
				WriteInt32(0x5AC,value);
			}
		}
		
		/// <summary>
		/// Name: TileNumberHardLimit
		/// Type: IntProperty
		/// Offset: 0x5B0
		/// Size: 0x04
		/// </summary>
		public int TileNumberHardLimit
		{
			get
			{
				return ReadInt32(0x5B0);
			}
			set
			{
				WriteInt32(0x5B0,value);
			}
		}
		
		/// <summary>
		/// Name: PolyRefTileBits
		/// Type: IntProperty
		/// Offset: 0x5B4
		/// Size: 0x04
		/// </summary>
		public int PolyRefTileBits
		{
			get
			{
				return ReadInt32(0x5B4);
			}
			set
			{
				WriteInt32(0x5B4,value);
			}
		}
		
		/// <summary>
		/// Name: PolyRefNavPolyBits
		/// Type: IntProperty
		/// Offset: 0x5B8
		/// Size: 0x04
		/// </summary>
		public int PolyRefNavPolyBits
		{
			get
			{
				return ReadInt32(0x5B8);
			}
			set
			{
				WriteInt32(0x5B8,value);
			}
		}
		
		/// <summary>
		/// Name: PolyRefSaltBits
		/// Type: IntProperty
		/// Offset: 0x5BC
		/// Size: 0x04
		/// </summary>
		public int PolyRefSaltBits
		{
			get
			{
				return ReadInt32(0x5BC);
			}
			set
			{
				WriteInt32(0x5BC,value);
			}
		}
		
		/// <summary>
		/// Name: DefaultDrawDistance
		/// Type: FloatProperty
		/// Offset: 0x5C0
		/// Size: 0x04
		/// </summary>
		public float DefaultDrawDistance
		{
			get
			{
				return ReadSingle(0x5C0);
			}
			set
			{
				WriteSingle(0x5C0,value);
			}
		}
		
		/// <summary>
		/// Name: DefaultMaxSearchNodes
		/// Type: FloatProperty
		/// Offset: 0x5C4
		/// Size: 0x04
		/// </summary>
		public float DefaultMaxSearchNodes
		{
			get
			{
				return ReadSingle(0x5C4);
			}
			set
			{
				WriteSingle(0x5C4,value);
			}
		}
		
		/// <summary>
		/// Name: DefaultMaxHierarchicalSearchNodes
		/// Type: FloatProperty
		/// Offset: 0x5C8
		/// Size: 0x04
		/// </summary>
		public float DefaultMaxHierarchicalSearchNodes
		{
			get
			{
				return ReadSingle(0x5C8);
			}
			set
			{
				WriteSingle(0x5C8,value);
			}
		}
		
		/// <summary>
		/// Name: RegionPartitioning
		/// Type: ByteProperty
		/// Offset: 0x5CC
		/// Size: 0x01
		/// </summary>
		public byte RegionPartitioning
		{
			get
			{
				return ReadByte(0x5CC);
			}
			set
			{
				WriteByte(0x5CC,value);
			}
		}
		
		/// <summary>
		/// Name: LayerPartitioning
		/// Type: ByteProperty
		/// Offset: 0x5CD
		/// Size: 0x01
		/// </summary>
		public byte LayerPartitioning
		{
			get
			{
				return ReadByte(0x5CD);
			}
			set
			{
				WriteByte(0x5CD,value);
			}
		}
		
		/// <summary>
		/// Name: RegionChunkSplits
		/// Type: IntProperty
		/// Offset: 0x5D0
		/// Size: 0x04
		/// </summary>
		public int RegionChunkSplits
		{
			get
			{
				return ReadInt32(0x5D0);
			}
			set
			{
				WriteInt32(0x5D0,value);
			}
		}
		
		/// <summary>
		/// Name: LayerChunkSplits
		/// Type: IntProperty
		/// Offset: 0x5D4
		/// Size: 0x04
		/// </summary>
		public int LayerChunkSplits
		{
			get
			{
				return ReadInt32(0x5D4);
			}
			set
			{
				WriteInt32(0x5D4,value);
			}
		}
		
		/// <summary>
		/// Name: bSortNavigationAreasByCost
		/// Type: BoolProperty
		/// Offset: 0x5D8
		/// Size: 0x01
		/// </summary>
		public bool bSortNavigationAreasByCost => (ReadByte(0x05D8) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bPerformVoxelFiltering
		/// Type: BoolProperty
		/// Offset: 0x5D8
		/// Size: 0x01
		/// </summary>
		public bool bPerformVoxelFiltering => (ReadByte(0x05D8) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bMarkLowHeightAreas
		/// Type: BoolProperty
		/// Offset: 0x5D8
		/// Size: 0x01
		/// </summary>
		public bool bMarkLowHeightAreas => (ReadByte(0x05D8) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bDoFullyAsyncNavDataGathering
		/// Type: BoolProperty
		/// Offset: 0x5D8
		/// Size: 0x01
		/// </summary>
		public bool bDoFullyAsyncNavDataGathering => (ReadByte(0x05D8) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bUseBetterOffsetsFromCorners
		/// Type: BoolProperty
		/// Offset: 0x5D8
		/// Size: 0x01
		/// </summary>
		public bool bUseBetterOffsetsFromCorners => (ReadByte(0x05D8) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bUseVirtualFilters
		/// Type: BoolProperty
		/// Offset: 0x5D8
		/// Size: 0x01
		/// </summary>
		public bool bUseVirtualFilters => (ReadByte(0x05D8) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: bUseVoxelCache
		/// Type: BoolProperty
		/// Offset: 0x5D8
		/// Size: 0x01
		/// </summary>
		public bool bUseVoxelCache => (ReadByte(0x05D8) & 0x40) == 0x40;
		
		/// <summary>
		/// Name: TileSetUpdateInterval
		/// Type: FloatProperty
		/// Offset: 0x5DC
		/// Size: 0x04
		/// </summary>
		public float TileSetUpdateInterval
		{
			get
			{
				return ReadSingle(0x5DC);
			}
			set
			{
				WriteSingle(0x5DC,value);
			}
		}
		
		/// <summary>
		/// Name: HeuristicScale
		/// Type: FloatProperty
		/// Offset: 0x5E0
		/// Size: 0x04
		/// </summary>
		public float HeuristicScale
		{
			get
			{
				return ReadSingle(0x5E0);
			}
			set
			{
				WriteSingle(0x5E0,value);
			}
		}
		
		/// <summary>
		/// Name: VerticalDeviationFromGroundCompensation
		/// Type: FloatProperty
		/// Offset: 0x5E4
		/// Size: 0x04
		/// </summary>
		public float VerticalDeviationFromGroundCompensation
		{
			get
			{
				return ReadSingle(0x5E4);
			}
			set
			{
				WriteSingle(0x5E4,value);
			}
		}
		
	}


	/// <summary>
	/// ANavigationGraphNode:AActor
	/// Size: 0x3D0
	/// Properties: 0
	/// </summary>
	public class ANavigationGraphNode:AActor
	{
		public override int ObjectSize => 976;
	}


	/// <summary>
	/// APlayerStartPIE:APlayerStart
	/// Size: 0x400
	/// Properties: 0
	/// </summary>
	public class APlayerStartPIE:APlayerStart
	{
		public override int ObjectSize => 1024;
	}


	/// <summary>
	/// UNavPathObserverInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UNavPathObserverInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// ANavigationTestingActor:AActor
	/// Size: 0x4E0
	/// Properties: 28
	/// </summary>
	public class ANavigationTestingActor:AActor
	{
		public override int ObjectSize => 1248;
		/// <summary>
		/// Name: CapsuleComponent
		/// Type: ObjectProperty
		/// Offset: 0x3E0
		/// Size: 0x08
		/// </summary>
		public UCapsuleComponent CapsuleComponent => ReadUObject<UCapsuleComponent>(0x3E0);
		
		/// <summary>
		/// Name: InvokerComponent
		/// Type: ObjectProperty
		/// Offset: 0x3E8
		/// Size: 0x08
		/// </summary>
		public UNavigationInvokerComponent InvokerComponent => ReadUObject<UNavigationInvokerComponent>(0x3E8);
		
		/// <summary>
		/// Name: bActAsNavigationInvoker
		/// Type: BoolProperty
		/// Offset: 0x3F0
		/// Size: 0x01
		/// </summary>
		public bool bActAsNavigationInvoker => (ReadByte(0x03F0) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: NavAgentProps
		/// Type: StructProperty
		/// Offset: 0x3F8
		/// Size: 0x20
		/// </summary>
		public FNavAgentProperties NavAgentProps => ReadStruct<FNavAgentProperties>(0x3F8);
		
		/// <summary>
		/// Name: QueryingExtent
		/// Type: StructProperty
		/// Offset: 0x418
		/// Size: 0x0C
		/// </summary>
		public FVector QueryingExtent => ReadStruct<FVector>(0x418);
		
		/// <summary>
		/// Name: MyNavData
		/// Type: ObjectProperty
		/// Offset: 0x428
		/// Size: 0x08
		/// </summary>
		public ANavigationData MyNavData => ReadUObject<ANavigationData>(0x428);
		
		/// <summary>
		/// Name: ProjectedLocation
		/// Type: StructProperty
		/// Offset: 0x430
		/// Size: 0x0C
		/// </summary>
		public FVector ProjectedLocation => ReadStruct<FVector>(0x430);
		
		/// <summary>
		/// Name: bProjectedLocationValid
		/// Type: BoolProperty
		/// Offset: 0x43C
		/// Size: 0x01
		/// </summary>
		public bool bProjectedLocationValid => (ReadByte(0x043C) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bSearchStart
		/// Type: BoolProperty
		/// Offset: 0x43C
		/// Size: 0x01
		/// </summary>
		public bool bSearchStart => (ReadByte(0x043C) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bUseHierarchicalPathfinding
		/// Type: BoolProperty
		/// Offset: 0x43C
		/// Size: 0x01
		/// </summary>
		public bool bUseHierarchicalPathfinding => (ReadByte(0x043C) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bGatherDetailedInfo
		/// Type: BoolProperty
		/// Offset: 0x43C
		/// Size: 0x01
		/// </summary>
		public bool bGatherDetailedInfo => (ReadByte(0x043C) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bDrawDistanceToWall
		/// Type: BoolProperty
		/// Offset: 0x43C
		/// Size: 0x01
		/// </summary>
		public bool bDrawDistanceToWall => (ReadByte(0x043C) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bShowNodePool
		/// Type: BoolProperty
		/// Offset: 0x43C
		/// Size: 0x01
		/// </summary>
		public bool bShowNodePool => (ReadByte(0x043C) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: bShowBestPath
		/// Type: BoolProperty
		/// Offset: 0x43C
		/// Size: 0x01
		/// </summary>
		public bool bShowBestPath => (ReadByte(0x043C) & 0x40) == 0x40;
		
		/// <summary>
		/// Name: bShowDiffWithPreviousStep
		/// Type: BoolProperty
		/// Offset: 0x43C
		/// Size: 0x01
		/// </summary>
		public bool bShowDiffWithPreviousStep => (ReadByte(0x043C) & 0x80) == 0x80;
		
		/// <summary>
		/// Name: bShouldBeVisibleInGame
		/// Type: BoolProperty
		/// Offset: 0x43D
		/// Size: 0x01
		/// </summary>
		public bool bShouldBeVisibleInGame => (ReadByte(0x043D) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: CostDisplayMode
		/// Type: ByteProperty
		/// Offset: 0x440
		/// Size: 0x01
		/// </summary>
		public byte CostDisplayMode
		{
			get
			{
				return ReadByte(0x440);
			}
			set
			{
				WriteByte(0x440,value);
			}
		}
		
		/// <summary>
		/// Name: TextCanvasOffset
		/// Type: StructProperty
		/// Offset: 0x444
		/// Size: 0x08
		/// </summary>
		public FVector2D TextCanvasOffset => ReadStruct<FVector2D>(0x444);
		
		/// <summary>
		/// Name: bPathExist
		/// Type: BoolProperty
		/// Offset: 0x44C
		/// Size: 0x01
		/// </summary>
		public bool bPathExist => (ReadByte(0x044C) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bPathIsPartial
		/// Type: BoolProperty
		/// Offset: 0x44C
		/// Size: 0x01
		/// </summary>
		public bool bPathIsPartial => (ReadByte(0x044C) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bPathSearchOutOfNodes
		/// Type: BoolProperty
		/// Offset: 0x44C
		/// Size: 0x01
		/// </summary>
		public bool bPathSearchOutOfNodes => (ReadByte(0x044C) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: PathfindingTime
		/// Type: FloatProperty
		/// Offset: 0x450
		/// Size: 0x04
		/// </summary>
		public float PathfindingTime
		{
			get
			{
				return ReadSingle(0x450);
			}
			set
			{
				WriteSingle(0x450,value);
			}
		}
		
		/// <summary>
		/// Name: PathCost
		/// Type: FloatProperty
		/// Offset: 0x454
		/// Size: 0x04
		/// </summary>
		public float PathCost
		{
			get
			{
				return ReadSingle(0x454);
			}
			set
			{
				WriteSingle(0x454,value);
			}
		}
		
		/// <summary>
		/// Name: PathfindingSteps
		/// Type: IntProperty
		/// Offset: 0x458
		/// Size: 0x04
		/// </summary>
		public int PathfindingSteps
		{
			get
			{
				return ReadInt32(0x458);
			}
			set
			{
				WriteInt32(0x458,value);
			}
		}
		
		/// <summary>
		/// Name: OtherActor
		/// Type: ObjectProperty
		/// Offset: 0x460
		/// Size: 0x08
		/// </summary>
		public ANavigationTestingActor OtherActor => ReadUObject<ANavigationTestingActor>(0x460);
		
		/// <summary>
		/// Name: FilterClass
		/// Type: ClassProperty
		/// Offset: 0x468
		/// Size: 0x08
		/// </summary>
		
		/// <summary>
		/// Name: ShowStepIndex
		/// Type: IntProperty
		/// Offset: 0x470
		/// Size: 0x04
		/// </summary>
		public int ShowStepIndex
		{
			get
			{
				return ReadInt32(0x470);
			}
			set
			{
				WriteInt32(0x470,value);
			}
		}
		
		/// <summary>
		/// Name: OffsetFromCornersDistance
		/// Type: FloatProperty
		/// Offset: 0x474
		/// Size: 0x04
		/// </summary>
		public float OffsetFromCornersDistance
		{
			get
			{
				return ReadSingle(0x474);
			}
			set
			{
				WriteSingle(0x474,value);
			}
		}
		
	}


	/// <summary>
	/// UNavArea:UObject
	/// Size: 0x40
	/// Properties: 20
	/// </summary>
	public class UNavArea:UObject
	{
		public override int ObjectSize => 64;
		/// <summary>
		/// Name: DefaultCost
		/// Type: FloatProperty
		/// Offset: 0x28
		/// Size: 0x04
		/// </summary>
		public float DefaultCost
		{
			get
			{
				return ReadSingle(0x28);
			}
			set
			{
				WriteSingle(0x28,value);
			}
		}
		
		/// <summary>
		/// Name: FixedAreaEnteringCost
		/// Type: FloatProperty
		/// Offset: 0x2C
		/// Size: 0x04
		/// </summary>
		public float FixedAreaEnteringCost
		{
			get
			{
				return ReadSingle(0x2C);
			}
			set
			{
				WriteSingle(0x2C,value);
			}
		}
		
		/// <summary>
		/// Name: DrawColor
		/// Type: StructProperty
		/// Offset: 0x30
		/// Size: 0x04
		/// </summary>
		public FColor DrawColor => ReadStruct<FColor>(0x30);
		
		/// <summary>
		/// Name: SupportedAgents
		/// Type: StructProperty
		/// Offset: 0x34
		/// Size: 0x04
		/// </summary>
		public FNavAgentSelector SupportedAgents => ReadStruct<FNavAgentSelector>(0x34);
		
		/// <summary>
		/// Name: bSupportsAgent0
		/// Type: BoolProperty
		/// Offset: 0x38
		/// Size: 0x01
		/// </summary>
		public bool bSupportsAgent0 => (ReadByte(0x0038) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bSupportsAgent1
		/// Type: BoolProperty
		/// Offset: 0x38
		/// Size: 0x01
		/// </summary>
		public bool bSupportsAgent1 => (ReadByte(0x0038) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bSupportsAgent2
		/// Type: BoolProperty
		/// Offset: 0x38
		/// Size: 0x01
		/// </summary>
		public bool bSupportsAgent2 => (ReadByte(0x0038) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bSupportsAgent3
		/// Type: BoolProperty
		/// Offset: 0x38
		/// Size: 0x01
		/// </summary>
		public bool bSupportsAgent3 => (ReadByte(0x0038) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bSupportsAgent4
		/// Type: BoolProperty
		/// Offset: 0x38
		/// Size: 0x01
		/// </summary>
		public bool bSupportsAgent4 => (ReadByte(0x0038) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bSupportsAgent5
		/// Type: BoolProperty
		/// Offset: 0x38
		/// Size: 0x01
		/// </summary>
		public bool bSupportsAgent5 => (ReadByte(0x0038) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: bSupportsAgent6
		/// Type: BoolProperty
		/// Offset: 0x38
		/// Size: 0x01
		/// </summary>
		public bool bSupportsAgent6 => (ReadByte(0x0038) & 0x40) == 0x40;
		
		/// <summary>
		/// Name: bSupportsAgent7
		/// Type: BoolProperty
		/// Offset: 0x38
		/// Size: 0x01
		/// </summary>
		public bool bSupportsAgent7 => (ReadByte(0x0038) & 0x80) == 0x80;
		
		/// <summary>
		/// Name: bSupportsAgent8
		/// Type: BoolProperty
		/// Offset: 0x39
		/// Size: 0x01
		/// </summary>
		public bool bSupportsAgent8 => (ReadByte(0x0039) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bSupportsAgent9
		/// Type: BoolProperty
		/// Offset: 0x39
		/// Size: 0x01
		/// </summary>
		public bool bSupportsAgent9 => (ReadByte(0x0039) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bSupportsAgent10
		/// Type: BoolProperty
		/// Offset: 0x39
		/// Size: 0x01
		/// </summary>
		public bool bSupportsAgent10 => (ReadByte(0x0039) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bSupportsAgent11
		/// Type: BoolProperty
		/// Offset: 0x39
		/// Size: 0x01
		/// </summary>
		public bool bSupportsAgent11 => (ReadByte(0x0039) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: bSupportsAgent12
		/// Type: BoolProperty
		/// Offset: 0x39
		/// Size: 0x01
		/// </summary>
		public bool bSupportsAgent12 => (ReadByte(0x0039) & 0x10) == 0x10;
		
		/// <summary>
		/// Name: bSupportsAgent13
		/// Type: BoolProperty
		/// Offset: 0x39
		/// Size: 0x01
		/// </summary>
		public bool bSupportsAgent13 => (ReadByte(0x0039) & 0x20) == 0x20;
		
		/// <summary>
		/// Name: bSupportsAgent14
		/// Type: BoolProperty
		/// Offset: 0x39
		/// Size: 0x01
		/// </summary>
		public bool bSupportsAgent14 => (ReadByte(0x0039) & 0x40) == 0x40;
		
		/// <summary>
		/// Name: bSupportsAgent15
		/// Type: BoolProperty
		/// Offset: 0x39
		/// Size: 0x01
		/// </summary>
		public bool bSupportsAgent15 => (ReadByte(0x0039) & 0x80) == 0x80;
		
	}


	/// <summary>
	/// UNavLinkDefinition:UObject
	/// Size: 0x50
	/// Properties: 2
	/// </summary>
	public class UNavLinkDefinition:UObject
	{
		public override int ObjectSize => 80;
		/// <summary>
		/// Name: Links
		/// Type: TArray<FNavigationLink>
		/// Offset: 0x28
		/// Size: 0x10
		/// SubElement Size: 0x48
		/// </summary>
		public TArray<FNavigationLink> Links => new TArray<FNavigationLink>(BaseAddress+0x28);
		
		/// <summary>
		/// Name: SegmentLinks
		/// Type: TArray<FNavigationSegmentLink>
		/// Offset: 0x38
		/// Size: 0x10
		/// SubElement Size: 0x60
		/// </summary>
		public TArray<FNavigationSegmentLink> SegmentLinks => new TArray<FNavigationSegmentLink>(BaseAddress+0x38);
		
	}


	/// <summary>
	/// UNavLinkHostInterface:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UNavLinkHostInterface:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// ANavLinkProxy:AActor
	/// Size: 0x420
	/// Properties: 4
	/// </summary>
	public class ANavLinkProxy:AActor
	{
		public override int ObjectSize => 1056;
		/// <summary>
		/// Name: PointLinks
		/// Type: TArray<FNavigationLink>
		/// Offset: 0x3E0
		/// Size: 0x10
		/// SubElement Size: 0x48
		/// </summary>
		public TArray<FNavigationLink> PointLinks => new TArray<FNavigationLink>(BaseAddress+0x3E0);
		
		/// <summary>
		/// Name: SegmentLinks
		/// Type: TArray<FNavigationSegmentLink>
		/// Offset: 0x3F0
		/// Size: 0x10
		/// SubElement Size: 0x60
		/// </summary>
		public TArray<FNavigationSegmentLink> SegmentLinks => new TArray<FNavigationSegmentLink>(BaseAddress+0x3F0);
		
		/// <summary>
		/// Name: SmartLinkComp
		/// Type: ObjectProperty
		/// Offset: 0x400
		/// Size: 0x08
		/// </summary>
		public UNavLinkCustomComponent SmartLinkComp => ReadUObject<UNavLinkCustomComponent>(0x400);
		
		/// <summary>
		/// Name: bSmartLinkIsRelevant
		/// Type: BoolProperty
		/// Offset: 0x408
		/// Size: 0x01
		/// </summary>
		public bool bSmartLinkIsRelevant
		{
			get
			{
				return ReadBool(0x408);
			}
			set
			{
				WriteBool(0x408,value);
			}
		}
		
	}


	/// <summary>
	/// ANote:AActor
	/// Size: 0x3D0
	/// Properties: 0
	/// </summary>
	public class ANote:AActor
	{
		public override int ObjectSize => 976;
	}


	/// <summary>
	/// AParticleEventManager:AActor
	/// Size: 0x3D0
	/// Properties: 0
	/// </summary>
	public class AParticleEventManager:AActor
	{
		public override int ObjectSize => 976;
	}


	/// <summary>
	/// USkeleton:UObject
	/// Size: 0x2D0
	/// Properties: 7
	/// </summary>
	public class USkeleton:UObject
	{
		public override int ObjectSize => 720;
		/// <summary>
		/// Name: BoneTree
		/// Type: TArray<FBoneNode>
		/// Offset: 0x28
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FBoneNode> BoneTree => new TArray<FBoneNode>(BaseAddress+0x28);
		
		/// <summary>
		/// Name: RefLocalPoses
		/// Type: TArray<FTransform>
		/// Offset: 0x38
		/// Size: 0x10
		/// SubElement Size: 0x30
		/// </summary>
		public TArray<FTransform> RefLocalPoses => new TArray<FTransform>(BaseAddress+0x38);
		
		/// <summary>
		/// Name: LinkupCache
		/// Type: TArray<FSkeletonToMeshLinkup>
		/// Offset: 0xC8
		/// Size: 0x10
		/// SubElement Size: 0x20
		/// </summary>
		public TArray<FSkeletonToMeshLinkup> LinkupCache => new TArray<FSkeletonToMeshLinkup>(BaseAddress+0xC8);
		
		/// <summary>
		/// Name: Sockets
		/// Type: TArray<USkeletalMeshSocket>
		/// Offset: 0xD8
		/// Size: 0x10
		/// SubElement Size: 0x60
		/// </summary>
		public TArray<USkeletalMeshSocket> Sockets => new TArray<USkeletalMeshSocket>(BaseAddress+0xD8);
		
		/// <summary>
		/// Name: SmartNames
		/// Type: StructProperty
		/// Offset: 0x138
		/// Size: 0x50
		/// </summary>
		public FSmartNameContainer SmartNames => ReadStruct<FSmartNameContainer>(0x138);
		
		/// <summary>
		/// Name: BlendProfiles
		/// Type: TArray<UBlendProfile>
		/// Offset: 0x198
		/// Size: 0x10
		/// SubElement Size: 0x48
		/// </summary>
		public TArray<UBlendProfile> BlendProfiles => new TArray<UBlendProfile>(BaseAddress+0x198);
		
		/// <summary>
		/// Name: SlotGroups
		/// Type: TArray<FAnimSlotGroup>
		/// Offset: 0x1A8
		/// Size: 0x10
		/// SubElement Size: 0x18
		/// </summary>
		public TArray<FAnimSlotGroup> SlotGroups => new TArray<FAnimSlotGroup>(BaseAddress+0x1A8);
		
	}


	/// <summary>
	/// UInterface_CollisionDataProvider:UInterface
	/// Size: 0x28
	/// Properties: 0
	/// </summary>
	public class UInterface_CollisionDataProvider:UInterface
	{
		public override int ObjectSize => 40;
	}


	/// <summary>
	/// USkeletalMesh:UObject
	/// Size: 0x240
	/// Properties: 22
	/// </summary>
	public class USkeletalMesh:UObject
	{
		public override int ObjectSize => 576;
		/// <summary>
		/// Name: Skeleton
		/// Type: ObjectProperty
		/// Offset: 0x48
		/// Size: 0x08
		/// </summary>
		public USkeleton Skeleton => ReadUObject<USkeleton>(0x48);
		
		/// <summary>
		/// Name: ImportedBounds
		/// Type: StructProperty
		/// Offset: 0x50
		/// Size: 0x1C
		/// </summary>
		public FBoxSphereBounds ImportedBounds => ReadStruct<FBoxSphereBounds>(0x50);
		
		/// <summary>
		/// Name: ExtendedBounds
		/// Type: StructProperty
		/// Offset: 0x6C
		/// Size: 0x1C
		/// </summary>
		public FBoxSphereBounds ExtendedBounds => ReadStruct<FBoxSphereBounds>(0x6C);
		
		/// <summary>
		/// Name: PositiveBoundsExtension
		/// Type: StructProperty
		/// Offset: 0x88
		/// Size: 0x0C
		/// </summary>
		public FVector PositiveBoundsExtension => ReadStruct<FVector>(0x88);
		
		/// <summary>
		/// Name: NegativeBoundsExtension
		/// Type: StructProperty
		/// Offset: 0x94
		/// Size: 0x0C
		/// </summary>
		public FVector NegativeBoundsExtension => ReadStruct<FVector>(0x94);
		
		/// <summary>
		/// Name: Materials
		/// Type: TArray<FSkeletalMaterial>
		/// Offset: 0xA0
		/// Size: 0x10
		/// SubElement Size: 0x10
		/// </summary>
		public TArray<FSkeletalMaterial> Materials => new TArray<FSkeletalMaterial>(BaseAddress+0xA0);
		
		/// <summary>
		/// Name: SkelMirrorTable
		/// Type: TArray<FBoneMirrorInfo>
		/// Offset: 0xB0
		/// Size: 0x10
		/// SubElement Size: 0x08
		/// </summary>
		public TArray<FBoneMirrorInfo> SkelMirrorTable => new TArray<FBoneMirrorInfo>(BaseAddress+0xB0);
		
		/// <summary>
		/// Name: SkelMirrorAxis
		/// Type: ByteProperty
		/// Offset: 0xC0
		/// Size: 0x01
		/// </summary>
		public byte SkelMirrorAxis
		{
			get
			{
				return ReadByte(0xC0);
			}
			set
			{
				WriteByte(0xC0,value);
			}
		}
		
		/// <summary>
		/// Name: SkelMirrorFlipAxis
		/// Type: ByteProperty
		/// Offset: 0xC1
		/// Size: 0x01
		/// </summary>
		public byte SkelMirrorFlipAxis
		{
			get
			{
				return ReadByte(0xC1);
			}
			set
			{
				WriteByte(0xC1,value);
			}
		}
		
		/// <summary>
		/// Name: LODInfo
		/// Type: TArray<FSkeletalMeshLODInfo>
		/// Offset: 0xC8
		/// Size: 0x10
		/// SubElement Size: 0x378
		/// </summary>
		public TArray<FSkeletalMeshLODInfo> LODInfo => new TArray<FSkeletalMeshLODInfo>(BaseAddress+0xC8);
		
		/// <summary>
		/// Name: bUseFullPrecisionUVs
		/// Type: BoolProperty
		/// Offset: 0xD8
		/// Size: 0x01
		/// </summary>
		public bool bUseFullPrecisionUVs => (ReadByte(0x00D8) & 0x01) == 0x01;
		
		/// <summary>
		/// Name: bHasBeenSimplified
		/// Type: BoolProperty
		/// Offset: 0xD8
		/// Size: 0x01
		/// </summary>
		public bool bHasBeenSimplified => (ReadByte(0x00D8) & 0x02) == 0x02;
		
		/// <summary>
		/// Name: bHasVertexColors
		/// Type: BoolProperty
		/// Offset: 0xD8
		/// Size: 0x01
		/// </summary>
		public bool bHasVertexColors => (ReadByte(0x00D8) & 0x04) == 0x04;
		
		/// <summary>
		/// Name: bEnablePerPolyCollision
		/// Type: BoolProperty
		/// Offset: 0xD8
		/// Size: 0x01
		/// </summary>
		public bool bEnablePerPolyCollision => (ReadByte(0x00D8) & 0x08) == 0x08;
		
		/// <summary>
		/// Name: BodySetup
		/// Type: ObjectProperty
		/// Offset: 0xE0
		/// Size: 0x08
		/// </summary>
		public UBodySetup BodySetup => ReadUObject<UBodySetup>(0xE0);
		
		/// <summary>
		/// Name: PhysicsAsset
		/// Type: ObjectProperty
		/// Offset: 0xE8
		/// Size: 0x08
		/// </summary>
		public UPhysicsAsset PhysicsAsset => ReadUObject<UPhysicsAsset>(0xE8);
		
		/// <summary>
		/// Name: ShadowPhysicsAsset
		/// Type: ObjectProperty
		/// Offset: 0xF0
		/// Size: 0x08
		/// </summary>
		public UPhysicsAsset ShadowPhysicsAsset => ReadUObject<UPhysicsAsset>(0xF0);
		
		/// <summary>
		/// Name: StreamingDistanceMultiplier
		/// Type: FloatProperty
		/// Offset: 0xF8
		/// Size: 0x04
		/// </summary>
		public float StreamingDistanceMultiplier
		{
			get
			{
				return ReadSingle(0xF8);
			}
			set
			{
				WriteSingle(0xF8,value);
			}
		}
		
		/// <summary>
		/// Name: MorphTargets
		/// Type: TArray<UMorphTarget>
		/// Offset: 0x100
		/// Size: 0x10
		/// SubElement Size: 0x40
		/// </summary>
		public TArray<UMorphTarget> MorphTargets => new TArray<UMorphTarget>(BaseAddress+0x100);
		
		/// <summary>
		/// Name: ClothingAssets
		/// Type: TArray<FClothingAssetData>
		/// Offset: 0x1E8
		/// Size: 0x10
		/// SubElement Size: 0xF0
		/// </summary>
		public TArray<FClothingAssetData> ClothingAssets => new TArray<FClothingAssetData>(BaseAddress+0x1E8);
		
		/// <summary>
		/// Name: AssetUserData
		/// Type: TArray<UAssetUserData>
		/// Size: 0x10