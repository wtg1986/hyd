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

    private Action.Model.BattleUnitCollection _Units = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Units", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Action.Model.BattleUnitCollection Units
    {
      get { return _Units; }
      set { _Units = value; }
    }

    private Action.Model.BattleBoutCollection _Items = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Action.Model.BattleBoutCollection Items
    {
      get { return _Items; }
      set { _Items = value; }
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BattleUnitCollection")]
  public partial class BattleUnitCollection : global::ProtoBuf.IExtensible
  {
    public BattleUnitCollection() {}
    
    private readonly global::System.Collections.Generic.List<Action.Model.BattleUnit> _Items = new global::System.Collections.Generic.List<Action.Model.BattleUnit>();
    [global::ProtoBuf.ProtoMember(1, Name=@"Items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Action.Model.BattleUnit> Items
    {
      get { return _Items; }
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

    private Action.Model.BattleActionCollection _Actions = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Actions", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Action.Model.BattleActionCollection Actions
    {
      get { return _Actions; }
      set { _Actions = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BattleBoutCollection")]
  public partial class BattleBoutCollection : global::ProtoBuf.IExtensible
  {
    public BattleBoutCollection() {}
    
    private readonly global::System.Collections.Generic.List<Action.Model.BattleBout> _Items = new global::System.Collections.Generic.List<Action.Model.BattleBout>();
    [global::ProtoBuf.ProtoMember(1, Name=@"Items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Action.Model.BattleBout> Items
    {
      get { return _Items; }
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

    private int _Id = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Id
    {
      get { return _Id; }
      set { _Id = value; }
    }

    private int _SkillId = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"SkillId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int SkillId
    {
      get { return _SkillId; }
      set { _SkillId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BattleActionCollection")]
  public partial class BattleActionCollection : global::ProtoBuf.IExtensible
  {
    public BattleActionCollection() {}
    
    private readonly global::System.Collections.Generic.List<Action.Model.BattleAction> _Items = new global::System.Collections.Generic.List<Action.Model.BattleAction>();
    [global::ProtoBuf.ProtoMember(1, Name=@"Items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Action.Model.BattleAction> Items
    {
      get { return _Items; }
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

    private int _PlusHP = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"PlusHP", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int PlusHP
    {
      get { return _PlusHP; }
      set { _PlusHP = value; }
    }

    private int _PlusMP = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"PlusMP", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int PlusMP
    {
      get { return _PlusMP; }
      set { _PlusMP = value; }
    }

    private int _BuffId = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"BuffId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int BuffId
    {
      get { return _BuffId; }
      set { _BuffId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BattleEffectCollection")]
  public partial class BattleEffectCollection : global::ProtoBuf.IExtensible
  {
    public BattleEffectCollection() {}
    
    private readonly global::System.Collections.Generic.List<Action.Model.BattleEffect> _Items = new global::System.Collections.Generic.List<Action.Model.BattleEffect>();
    [global::ProtoBuf.ProtoMember(1, Name=@"Items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Action.Model.BattleEffect> Items
    {
      get { return _Items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}