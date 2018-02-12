//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: PBBattle.proto
namespace PBBattle
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BattleUserInfo")]
  public partial class BattleUserInfo : global::ProtoBuf.IExtensible
  {
    public BattleUserInfo() {}
    
    private int _uid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private int _battleID;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"battleID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int battleID
    {
      get { return _battleID; }
      set { _battleID = value; }
    }
    private int _roleID;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"roleID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int roleID
    {
      get { return _roleID; }
      set { _roleID = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TcpEnterBattle")]
  public partial class TcpEnterBattle : global::ProtoBuf.IExtensible
  {
    public TcpEnterBattle() {}
    
    private int _randSeed;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"randSeed", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int randSeed
    {
      get { return _randSeed; }
      set { _randSeed = value; }
    }
    private readonly global::System.Collections.Generic.List<PBBattle.BattleUserInfo> _battleUserInfo = new global::System.Collections.Generic.List<PBBattle.BattleUserInfo>();
    [global::ProtoBuf.ProtoMember(2, Name=@"battleUserInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<PBBattle.BattleUserInfo> battleUserInfo
    {
      get { return _battleUserInfo; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UdpBattleReady")]
  public partial class UdpBattleReady : global::ProtoBuf.IExtensible
  {
    public UdpBattleReady() {}
    
    private int _uid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private int _battleID;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"battleID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int battleID
    {
      get { return _battleID; }
      set { _battleID = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UdpBattleStart")]
  public partial class UdpBattleStart : global::ProtoBuf.IExtensible
  {
    public UdpBattleStart() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerOperation")]
  public partial class PlayerOperation : global::ProtoBuf.IExtensible
  {
    public PlayerOperation() {}
    
    private int _battleID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"battleID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int battleID
    {
      get { return _battleID; }
      set { _battleID = value; }
    }
    private int _move;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"move", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int move
    {
      get { return _move; }
      set { _move = value; }
    }
    private int _operationID = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"operationID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int operationID
    {
      get { return _operationID; }
      set { _operationID = value; }
    }
    private PBBattle.RightOpType _rightOperation = PBBattle.RightOpType.noop;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"rightOperation", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(PBBattle.RightOpType.noop)]
    public PBBattle.RightOpType rightOperation
    {
      get { return _rightOperation; }
      set { _rightOperation = value; }
    }
    private int _operationValue1 = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"operationValue1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int operationValue1
    {
      get { return _operationValue1; }
      set { _operationValue1 = value; }
    }
    private int _operationValue2 = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"operationValue2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int operationValue2
    {
      get { return _operationValue2; }
      set { _operationValue2 = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UdpUpPlayerOperations")]
  public partial class UdpUpPlayerOperations : global::ProtoBuf.IExtensible
  {
    public UdpUpPlayerOperations() {}
    
    private int _mesID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"mesID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int mesID
    {
      get { return _mesID; }
      set { _mesID = value; }
    }
    private PBBattle.PlayerOperation _operation;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"operation", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public PBBattle.PlayerOperation operation
    {
      get { return _operation; }
      set { _operation = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AllPlayerOperation")]
  public partial class AllPlayerOperation : global::ProtoBuf.IExtensible
  {
    public AllPlayerOperation() {}
    
    private readonly global::System.Collections.Generic.List<PBBattle.PlayerOperation> _operations = new global::System.Collections.Generic.List<PBBattle.PlayerOperation>();
    [global::ProtoBuf.ProtoMember(1, Name=@"operations", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<PBBattle.PlayerOperation> operations
    {
      get { return _operations; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UdpDownFrameOperations")]
  public partial class UdpDownFrameOperations : global::ProtoBuf.IExtensible
  {
    public UdpDownFrameOperations() {}
    
    private int _frameID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"frameID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int frameID
    {
      get { return _frameID; }
      set { _frameID = value; }
    }
    private PBBattle.AllPlayerOperation _operations;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"operations", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public PBBattle.AllPlayerOperation operations
    {
      get { return _operations; }
      set { _operations = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UdpUpDeltaFrames")]
  public partial class UdpUpDeltaFrames : global::ProtoBuf.IExtensible
  {
    public UdpUpDeltaFrames() {}
    
    private int _battleID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"battleID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int battleID
    {
      get { return _battleID; }
      set { _battleID = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _frames = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(2, Name=@"frames", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> frames
    {
      get { return _frames; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UdpDownDeltaFrames")]
  public partial class UdpDownDeltaFrames : global::ProtoBuf.IExtensible
  {
    public UdpDownDeltaFrames() {}
    
    private readonly global::System.Collections.Generic.List<PBBattle.UdpDownFrameOperations> _framesData = new global::System.Collections.Generic.List<PBBattle.UdpDownFrameOperations>();
    [global::ProtoBuf.ProtoMember(1, Name=@"framesData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<PBBattle.UdpDownFrameOperations> framesData
    {
      get { return _framesData; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UdpUpGameOver")]
  public partial class UdpUpGameOver : global::ProtoBuf.IExtensible
  {
    public UdpUpGameOver() {}
    
    private int _battleID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"battleID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int battleID
    {
      get { return _battleID; }
      set { _battleID = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UdpDownGameOver")]
  public partial class UdpDownGameOver : global::ProtoBuf.IExtensible
  {
    public UdpDownGameOver() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"RightOpType")]
    public enum RightOpType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"noop", Value=0)]
      noop = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"attack", Value=1)]
      attack = 1
    }
  
}