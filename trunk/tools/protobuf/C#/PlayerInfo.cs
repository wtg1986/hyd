//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: protos/PlayerInfo.proto
// Note: requires additional types generated from: protobuf-net.proto
namespace Action.Model
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Role")]
  public partial class Role : global::ProtoBuf.IExtensible
  {
    public Role() {}
    

    private string _Name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Name
    {
      get { return _Name; }
      set { _Name = value; }
    }

    private int _Job = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Job", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Job
    {
      get { return _Job; }
      set { _Job = value; }
    }

    private int _Sex = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Sex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Sex
    {
      get { return _Sex; }
      set { _Sex = value; }
    }

    private int _Level = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Level
    {
      get { return _Level; }
      set { _Level = value; }
    }

    private int _Skin = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Skin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Skin
    {
      get { return _Skin; }
      set { _Skin = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Right")]
  public partial class Right : global::ProtoBuf.IExtensible
  {
    public Right() {}
    
    private readonly global::System.Collections.Generic.List<int> _Items = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(1, Name=@"Items", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> Items
    {
      get { return _Items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}