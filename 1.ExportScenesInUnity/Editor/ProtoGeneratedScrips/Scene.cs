//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Scene.proto
namespace killer.proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Vector3")]
  public partial class Vector3 : global::ProtoBuf.IExtensible
  {
    public Vector3() {}
    
    private double _x = (double)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((double)0)]
    public double x
    {
      get { return _x; }
      set { _x = value; }
    }
    private double _y = (double)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((double)0)]
    public double y
    {
      get { return _y; }
      set { _y = value; }
    }
    private double _z = (double)0;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"z", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((double)0)]
    public double z
    {
      get { return _z; }
      set { _z = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Vector4")]
  public partial class Vector4 : global::ProtoBuf.IExtensible
  {
    public Vector4() {}
    
    private double _x = (double)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((double)0)]
    public double x
    {
      get { return _x; }
      set { _x = value; }
    }
    private double _y = (double)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((double)0)]
    public double y
    {
      get { return _y; }
      set { _y = value; }
    }
    private double _z = (double)0;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"z", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((double)0)]
    public double z
    {
      get { return _z; }
      set { _z = value; }
    }
    private double _w = (double)0;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"w", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((double)0)]
    public double w
    {
      get { return _w; }
      set { _w = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"U3DPhysxScene")]
  public partial class U3DPhysxScene : global::ProtoBuf.IExtensible
  {
    public U3DPhysxScene() {}
    
    private int _id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _scene_name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"scene_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string scene_name
    {
      get { return _scene_name; }
      set { _scene_name = value; }
    }
    private readonly global::System.Collections.Generic.List<killer.proto.U3DPhysxBox> _box_collider = new global::System.Collections.Generic.List<killer.proto.U3DPhysxBox>();
    [global::ProtoBuf.ProtoMember(3, Name=@"box_collider", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<killer.proto.U3DPhysxBox> box_collider
    {
      get { return _box_collider; }
    }
  
    private readonly global::System.Collections.Generic.List<killer.proto.U3DPhysxSphere> _sphere_collider = new global::System.Collections.Generic.List<killer.proto.U3DPhysxSphere>();
    [global::ProtoBuf.ProtoMember(4, Name=@"sphere_collider", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<killer.proto.U3DPhysxSphere> sphere_collider
    {
      get { return _sphere_collider; }
    }
  
    private readonly global::System.Collections.Generic.List<killer.proto.U3DPhysxCapsule> _capsule_collider = new global::System.Collections.Generic.List<killer.proto.U3DPhysxCapsule>();
    [global::ProtoBuf.ProtoMember(5, Name=@"capsule_collider", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<killer.proto.U3DPhysxCapsule> capsule_collider
    {
      get { return _capsule_collider; }
    }
  
    private readonly global::System.Collections.Generic.List<killer.proto.U3DPhysxMesh> _mesh_collider = new global::System.Collections.Generic.List<killer.proto.U3DPhysxMesh>();
    [global::ProtoBuf.ProtoMember(6, Name=@"mesh_collider", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<killer.proto.U3DPhysxMesh> mesh_collider
    {
      get { return _mesh_collider; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"U3DPhysxSphere")]
  public partial class U3DPhysxSphere : global::ProtoBuf.IExtensible
  {
    public U3DPhysxSphere() {}
    
    private int _id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private killer.proto.ColliderType _type = killer.proto.ColliderType.BOX;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(killer.proto.ColliderType.BOX)]
    public killer.proto.ColliderType type
    {
      get { return _type; }
      set { _type = value; }
    }
    private killer.proto.Vector3 _pos = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"pos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public killer.proto.Vector3 pos
    {
      get { return _pos; }
      set { _pos = value; }
    }
    private double _radius = default(double);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"radius", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(double))]
    public double radius
    {
      get { return _radius; }
      set { _radius = value; }
    }
    private killer.proto.Vector4 _rotation = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"rotation", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public killer.proto.Vector4 rotation
    {
      get { return _rotation; }
      set { _rotation = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"U3DPhysxBox")]
  public partial class U3DPhysxBox : global::ProtoBuf.IExtensible
  {
    public U3DPhysxBox() {}
    
    private int _id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private killer.proto.ColliderType _type = killer.proto.ColliderType.BOX;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(killer.proto.ColliderType.BOX)]
    public killer.proto.ColliderType type
    {
      get { return _type; }
      set { _type = value; }
    }
    private killer.proto.Vector3 _pos = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"pos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public killer.proto.Vector3 pos
    {
      get { return _pos; }
      set { _pos = value; }
    }
    private double _x_extents = default(double);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"x_extents", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(double))]
    public double x_extents
    {
      get { return _x_extents; }
      set { _x_extents = value; }
    }
    private double _y_extents = default(double);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"y_extents", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(double))]
    public double y_extents
    {
      get { return _y_extents; }
      set { _y_extents = value; }
    }
    private double _z_extents = default(double);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"z_extents", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(double))]
    public double z_extents
    {
      get { return _z_extents; }
      set { _z_extents = value; }
    }
    private killer.proto.Vector4 _rotation = null;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"rotation", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public killer.proto.Vector4 rotation
    {
      get { return _rotation; }
      set { _rotation = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"U3DPhysxCapsule")]
  public partial class U3DPhysxCapsule : global::ProtoBuf.IExtensible
  {
    public U3DPhysxCapsule() {}
    
    private int _id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private killer.proto.ColliderType _type = killer.proto.ColliderType.BOX;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(killer.proto.ColliderType.BOX)]
    public killer.proto.ColliderType type
    {
      get { return _type; }
      set { _type = value; }
    }
    private killer.proto.Vector3 _pos = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"pos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public killer.proto.Vector3 pos
    {
      get { return _pos; }
      set { _pos = value; }
    }
    private double _raduis = default(double);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"raduis", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(double))]
    public double raduis
    {
      get { return _raduis; }
      set { _raduis = value; }
    }
    private double _height = default(double);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"height", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(double))]
    public double height
    {
      get { return _height; }
      set { _height = value; }
    }
    private killer.proto.Vector4 _rotation = null;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"rotation", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public killer.proto.Vector4 rotation
    {
      get { return _rotation; }
      set { _rotation = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"U3DPhysxMesh")]
  public partial class U3DPhysxMesh : global::ProtoBuf.IExtensible
  {
    public U3DPhysxMesh() {}
    
    private int _id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private killer.proto.ColliderType _type = killer.proto.ColliderType.BOX;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(killer.proto.ColliderType.BOX)]
    public killer.proto.ColliderType type
    {
      get { return _type; }
      set { _type = value; }
    }
    private int _vertex_count = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"vertex_count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int vertex_count
    {
      get { return _vertex_count; }
      set { _vertex_count = value; }
    }
    private readonly global::System.Collections.Generic.List<killer.proto.Vector3> _vertices = new global::System.Collections.Generic.List<killer.proto.Vector3>();
    [global::ProtoBuf.ProtoMember(4, Name=@"vertices", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<killer.proto.Vector3> vertices
    {
      get { return _vertices; }
    }
  
    private killer.proto.Vector4 _rotation = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"rotation", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public killer.proto.Vector4 rotation
    {
      get { return _rotation; }
      set { _rotation = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"ColliderType")]
    public enum ColliderType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"BOX", Value=1)]
      BOX = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SPHERE", Value=2)]
      SPHERE = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CAPSULE", Value=3)]
      CAPSULE = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MESH", Value=4)]
      MESH = 4
    }
  
}