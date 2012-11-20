//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: protos/BattleReport.proto
// Note: requires additional types generated from: protobuf-net.proto
namespace Action.Model
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BattleReport")]
  public partial class BattleReport : global::ProtoBuf.IExtensible
  {
    public BattleReport() {}
    

    private string _UID = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"UID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string UID
    {
      get { return _UID; }
      set { _UID = value; }
    }
    private readonly global::System.Collections.Generic.List<Action.Model.BattleUnit> _Units = new global::System.Collections.Generic.List<Action.Model.BattleUnit>();
    [global::ProtoBuf.ProtoMember(2, Name=@"Units", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Action.Model.BattleUnit> Units
    {
      get { return _Units; }
    }
  
    private readonly global::System.Collections.Generic.List<Action.Model.BattleBout> _Bouts = new global::System.Collections.Generic.List<Action.Model.BattleBout>();
    [global::ProtoBuf.ProtoMember(3, Name=@"Bouts", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Action.Model.BattleBout> Bouts
    {
      get { return _Bouts; }
    }
  

    private string _Player1 = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Player1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Player1
    {
      get { return _Player1; }
      set { _Player1 = value; }
    }

    private string _Player2 = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Player2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Player2
    {
      get { return _Player2; }
      set { _Player2 = value; }
    }

    private bool _Win = default(bool);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Win", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool Win
    {
      get { return _Win; }
      set { _Win = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BattleUnit")]
  public partial class BattleUnit : global::ProtoBuf.IExtensible
  {
    public BattleUnit() {}
    

    private int _SID = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"SID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int SID
    {
      get { return _SID; }
      set { _SID = value; }
    }

    private int _Id = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Id
    {
      get { return _Id; }
      set { _Id = value; }
    }

    private int _Pos = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Pos", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Pos
    {
      get { return _Pos; }
      set { _Pos = value; }
    }

    private int _HP = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"HP", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int HP
    {
      get { return _HP; }
      set { _HP = value; }
    }

    private int _MP = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"MP", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int MP
    {
      get { return _MP; }
      set { _MP = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BattleBout")]
  public partial class BattleBout : global::ProtoBuf.IExtensible
  {
    public BattleBout() {}
    

    private int _SID = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"SID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int SID
    {
      get { return _SID; }
      set { _SID = value; }
    }
    private readonly global::System.Collections.Generic.List<Action.Model.BattleAction> _Actions = new global::System.Collections.Generic.List<Action.Model.BattleAction>();
    [global::ProtoBuf.ProtoMember(2, Name=@"Actions", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Action.Model.BattleAction> Actions
    {
      get { return _Actions; }
    }
  
    private readonly global::System.Collections.Generic.List<Action.Model.BattleEffect> _Effects = new global::System.Collections.Generic.List<Action.Model.BattleEffect>();
    [global::ProtoBuf.ProtoMember(3, Name=@"Effects", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Action.Model.BattleEffect> Effects
    {
      get { return _Effects; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BattleAction")]
  public partial class BattleAction : global::ProtoBuf.IExtensible
  {
    public BattleAction() {}
    

    private int _UnitSID = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"UnitSID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int UnitSID
    {
      get { return _UnitSID; }
      set { _UnitSID = value; }
    }

    private Action.Model.BattleActionType _Type = Action.Model.BattleActionType.Cast;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Action.Model.BattleActionType.Cast)]
    public Action.Model.BattleActionType Type
    {
      get { return _Type; }
      set { _Type = value; }
    }

    private int _Param = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Param", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Param
    {
      get { return _Param; }
      set { _Param = value; }
    }
    private readonly global::System.Collections.Generic.List<Action.Model.BattleEffect> _Effects = new global::System.Collections.Generic.List<Action.Model.BattleEffect>();
    [global::ProtoBuf.ProtoMember(4, Name=@"Effects", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Action.Model.BattleEffect> Effects
    {
      get { return _Effects; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BattleEffect")]
  public partial class BattleEffect : global::ProtoBuf.IExtensible
  {
    public BattleEffect() {}
    

    private int _UnitSID = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"UnitSID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int UnitSID
    {
      get { return _UnitSID; }
      set { _UnitSID = value; }
    }

    private Action.Model.BattleEffectType _Type = Action.Model.BattleEffectType.None;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Action.Model.BattleEffectType.None)]
    public Action.Model.BattleEffectType Type
    {
      get { return _Type; }
      set { _Type = value; }
    }

    private int _PlusHP = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"PlusHP", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int PlusHP
    {
      get { return _PlusHP; }
      set { _PlusHP = value; }
    }

    private int _PlusMP = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"PlusMP", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int PlusMP
    {
      get { return _PlusMP; }
      set { _PlusMP = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"BattleActionType")]
    public enum BattleActionType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"Cast", Value=1)]
      Cast = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Move", Value=2)]
      Move = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"BattleEffectType")]
    public enum BattleEffectType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"None", Value=-1)]
      None = -1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Dodge", Value=0)]
      Dodge = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Block", Value=1)]
      Block = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Attack", Value=2)]
      Attack = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Critical", Value=3)]
      Critical = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Cure", Value=4)]
      Cure = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AddMP", Value=5)]
      AddMP = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ReduceMP", Value=6)]
      ReduceMP = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AddAttack", Value=7)]
      AddAttack = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ReduceAttack", Value=8)]
      ReduceAttack = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AddDefence", Value=9)]
      AddDefence = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ReduceDefence", Value=10)]
      ReduceDefence = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Stun", Value=11)]
      Stun = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Poison", Value=12)]
      Poison = 12
    }
  
}